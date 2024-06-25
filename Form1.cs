using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace ClipCut_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            {
                string url = txtUrl.Text;
                string fileName = txtFileName.Text;
                int videoMaxLength = (int)numVideoMaxLength.Value;
                string selectedDirectory = txtDirectory.Text;

                if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(fileName) || string.IsNullOrWhiteSpace(selectedDirectory))
                {
                    MessageBox.Show("Please provide valid URL, File Name, and Directory.");
                    return;
                }

                try
                {
                    string savePath = Path.Combine(selectedDirectory, "YoutubeDownloads" , fileName);
                    if (!Directory.Exists(savePath))
                    {
                        Directory.CreateDirectory(savePath);
                    }

                    var youtube = new YoutubeClient();
                    var video = await youtube.Videos.GetAsync(url);
                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                    // Get the 720p stream
                    var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                    if (streamInfo == null)
                    {
                        MessageBox.Show(streamManifest.GetMuxedStreams() + " stream available.");
                        return;
                    }
                    
                    string videoPath = Path.Combine(selectedDirectory, "YoutubeDownloads", $"{video.Title}.mp4");
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, videoPath);

                    var inputFile = new MediaFile { Filename = videoPath };

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                        double duration = inputFile.Metadata.Duration.TotalSeconds;

                        int cut = 0;
                        double extraCut = 0;

                        while (duration >= videoMaxLength)
                        {
                            if (duration < videoMaxLength * 2)
                            {
                                cut += 1;
                                extraCut = duration;
                                break;
                            }
                            duration -= videoMaxLength;
                            cut += 1;
                        }

                        progressBar.Maximum = cut;
                        progressBar.Value = 0;

                        double clipDuration = 0;
                        for (int i = 0; i < cut; i++)
                        {
                            var start = TimeSpan.FromSeconds(clipDuration);
                            var end = (i == cut - 1) ? TimeSpan.FromSeconds(clipDuration + extraCut) : TimeSpan.FromSeconds(clipDuration + videoMaxLength);
                            string outputFilePath = Path.Combine(savePath, $"Clip_{i + 1}.mp4");

                            var options = new ConversionOptions { Seek = start, MaxVideoDuration = end - start };
                            engine.Convert(inputFile, new MediaFile { Filename = outputFilePath }, options);

                            clipDuration += videoMaxLength;
                            progressBar.Value++;
                        }
                    }
                    if (Directory.Exists(savePath))
                    {
                        MessageBox.Show("Videos downloaded and cut successfully.");
                        progressBar.Value = 0;
                        Process.Start("explorer.exe", savePath);
                    }
                    else
                    {
                        MessageBox.Show("Folder not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    progressBar.Value = 0;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select the directory to save the video clips";
                folderBrowser.ShowNewFolderButton = true;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtDirectory.Text = folderBrowser.SelectedPath;
                }
            }
        }
    }
}
