
using System.Security.Cryptography;

namespace MS4S_MD5Hasher
{
    internal class Hasher
    {
        private FolderBrowserDialog folderBrowser;

        private const string FILE_FORMAT = ".txt";

        public Hasher(FolderBrowserDialog folderBrowser)
        {
            this.folderBrowser = folderBrowser;
            string path = Directory.GetCurrentDirectory();

            this.folderBrowser.InitialDirectory = path;
            this.folderBrowser.SelectedPath = path;
        }

        public void Checksum(string customFilename = "checksum", string customSeparator = ":")
        {
            if (folderBrowser.SelectedPath == null || folderBrowser.SelectedPath.Length <= 1)
            {
                MessageBox.Show("Please, provide a path which will be used to calculate all files and hashes for them");
                return;
            }

            string abosulteDirectory = folderBrowser.SelectedPath;
            string hashListFile = Path.Combine(abosulteDirectory, $"{customFilename}{FILE_FORMAT}");

            if (File.Exists(hashListFile)) File.Delete(hashListFile);
            File.Create(hashListFile).Close();

            int counter = 0;
            string[] allFiles = Directory.GetFiles(abosulteDirectory, "*.*", SearchOption.AllDirectories);
            string[] lines = new string[allFiles.Length];

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
                            byte[] fileMD5 = md5.ComputeHash(stream);
                            string hash = BitConverter.ToString(fileMD5).Replace("-", "").ToLower();
                            string currDir = Path.GetRelativePath(abosulteDirectory, filePath);
                            lines[counter] = $"{currDir}{customSeparator}{hash}";
                        }
                        counter++;
                    }
                }
            }
            WriteToFile(hashListFile, lines);
        }

        private void WriteToFile(string fileFullPath, string[] lines)
        {
            File.AppendAllLines(fileFullPath, lines);
            MessageBox.Show($"File created at {fileFullPath}.\nTotal: {lines.Length} lines/files", "MS4S MD5 Hasher");
        }
    }
}
