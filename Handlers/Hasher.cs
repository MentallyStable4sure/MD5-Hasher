
using MS4S_MD5Hasher.Data;
using System.Security.Cryptography;

namespace MS4S_MD5Hasher.Handlers
{
    //class that contains all compute hashing for encoding
    internal class Hasher
    {
        private FolderBrowserDialog folderBrowser;
        private EncoderUIData uiData;

        private const string FILE_FORMAT = ".txt";

        public Hasher(FolderBrowserDialog folderBrowser, EncoderUIData uiData)
        {
            this.uiData = uiData;
            this.folderBrowser = folderBrowser;
            string path = Directory.GetCurrentDirectory();

            this.folderBrowser.InitialDirectory = path;
            this.folderBrowser.SelectedPath = path;
        }

        //browse folder that is gonna be encoded
        public void BrowseDirectory()
        {
            var dialogResult = folderBrowser.ShowDialog();

            //if user canceled checking path (nothing selected) means that we cannot proceed further
            if (dialogResult != DialogResult.OK)
            {
                uiData.PathBox.Text = string.Empty;
                folderBrowser.SelectedPath = string.Empty;
                uiData.Button.Visible = false;
                return;
            }

            var path = folderBrowser.SelectedPath;
            if (!Directory.Exists(path) && path.Length > 1)
            {
                dialogResult = DialogResult.Cancel;
                folderBrowser.SelectedPath = string.Empty;
                uiData.PathBox.Text = string.Empty;
                return;
            }

            folderBrowser.InitialDirectory = path;
            folderBrowser.SelectedPath = path;
            uiData.PathBox.Text = path;
        }

        //actual encoding
        public void Checksum(string customFilename = "checksum", string customSeparator = ":")
        {
            if (folderBrowser.SelectedPath == null || folderBrowser.SelectedPath.Length <= 1)
            {
                MessageBox.Show("Please, provide a path which will be used to calculate all files and hashes for them");
                return;
            }

            string cachedPath = uiData.PathBox.Text;
            uiData.PathBox.Text = "Computing MD5 hashes...";

            string abosulteDirectory = folderBrowser.SelectedPath;
            string hashListFile = Path.Combine(abosulteDirectory, $"{customFilename}{FILE_FORMAT}");

            if (File.Exists(hashListFile)) File.Delete(hashListFile); //basically if we already have those just delete it and create again since its easier then parse it over
            File.Create(hashListFile).Close();

            int counter = 0;
            string[] allFiles = Directory.GetFiles(abosulteDirectory, "*.*", SearchOption.AllDirectories); //get all files from main path and its subfolders
            string[] lines = new string[allFiles.Length];

            //lookup for all files contained in directory including subfolders
            foreach (string file in allFiles)
            {
                using (var md5 = MD5.Create())
                {
                    FileInfo info = new FileInfo(file);
                    string filePath = info.FullName;
                    if (filePath == hashListFile) continue;
                    {
                        using (var stream = File.OpenRead(filePath))
                        {
                            byte[] fileMD5 = md5.ComputeHash(stream); //hash each file
                            string hash = BitConverter.ToString(fileMD5).Replace("-", "").ToLower(); //convert it to a web and more readable string
                            string currDir = Path.GetRelativePath(abosulteDirectory, filePath); //getting the relative path so its not a long version but /{subfolder}/{item}
                            lines[counter] = $"{currDir}{customSeparator}{hash}"; //set it to our line formatted as we wanted
                        }
                        counter++;
                    }
                }
            }

            uiData.PathBox.Text = "Writing hashes to a file...";
            WriteToFile(hashListFile, lines);
            uiData.PathBox.Text = cachedPath;
        }

        private void WriteToFile(string fileFullPath, string[] lines)
        {
            File.AppendAllLines(fileFullPath, lines);
            MessageBox.Show($"File created at {fileFullPath}.\nTotal: {lines.Length} lines/files", "MS4S MD5 Hasher");
        }
    }
}
