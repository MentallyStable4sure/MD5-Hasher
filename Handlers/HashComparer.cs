using System.Text;
using MS4S_MD5Hasher.Data;

namespace MS4S_MD5Hasher.Handlers
{
    internal class HashComparer
    {
        private ComparerUIData data;

        public HashComparer(ComparerUIData data)
        {
            this.data = data;
            data.Button.Click += CheckMandatoryData;

            data.BrowseFirstButton.Click += SetFirstPath;
            data.BrowseSecondButton.Click += SetSecondPath;
        }

        private void SetFirstPath(object? sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            data.PathBox.Text = fileDialog.FileName;
        }

        private void SetSecondPath(object? sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            data.PathBox2.Text = fileDialog.FileName;
        }

        private void CheckMandatoryData(object? sender, EventArgs e)
        {
            data.Separator.Text = data.Separator.Text.Length < 1 ? ":" : data.Separator.Text;
            data.Separator2.Text = data.Separator2.Text.Length < 1 ? ":" : data.Separator2.Text;

            if (data.PathBox.Text.Length < 1 || data.PathBox2.Text.Length < 1)
            {
                MessageBox.Show("[ERROR] Please provide both files to check and their separators, they should be text formatted");
                return;
            }

            Compare(data.PathBox.Text, data.Separator.Text, data.PathBox2.Text, data.Separator2.Text);
        }

        public void Compare(string firstFile, string firstSeparator, string secondFile, string secondSeparator)
        {
            string[] firstFileLines = File.ReadAllLines(firstFile);
            string[] secondFileLines = File.ReadAllLines(secondFile);

            StringBuilder info = new StringBuilder();
            bool isEqualLength = firstFileLines.Length == secondFileLines.Length;

            info.AppendLine($"LINE LENGTH MATCH: {isEqualLength}");

            if(!isEqualLength)
            {
                info.AppendLine("[ERROR] Length arent matching, they are NOT equal");
            }

            List<string> filesToUpdate = new List<string>();

            filesToUpdate = CheckPair(firstFileLines, secondFileLines, firstSeparator, secondSeparator);
            var reverseFiles = CheckPair(secondFileLines, firstFileLines, secondSeparator, firstSeparator, filesToUpdate);
            foreach (string file in reverseFiles)
            {
                filesToUpdate.Add(file);
            }

            if(filesToUpdate.Count > 0)
            {
                info.AppendLine("Files needs to be updated (their hashes aren't matching or not found in one of files):\n\n");
                foreach (string updateLine in filesToUpdate)
                {
                    info.AppendLine(updateLine.Split(firstSeparator)[0]);
                }

                SignWithDetails(info, firstFile, firstFileLines.Length, secondFile, secondFileLines.Length);
                return;
            }

            info.AppendLine($"♡♡♡♡♡♡♡♡");
            info.AppendLine($"[SUCCESS] They purrfectly matched each other, 100%");

            SignWithDetails(info, firstFile, firstFileLines.Length, secondFile, secondFileLines.Length);
        }

        private List<string> CheckPair(string[] firstList, string[] secondList, string firstSeparator, string secondSeparator, List<string> itemsToIgnore = null)
        {
            var ignored = itemsToIgnore == null ? new List<string>() : itemsToIgnore;

            List<string> filesToUpdate = new List<string>();
            foreach (string line in firstList)
            {
                if (ignored.Count > 0 && ignored.Contains(line)) continue;
                if (line.Length <= 2) continue; //prob empty line we dont care about that

                bool isFoundMatch = false;
                foreach (string secondLine in secondList)
                {
                    if (ignored.Count > 0 && ignored.Contains(secondLine)) continue;
                    if (secondLine.Length <= 2) continue; //prob same empty line we dont care about that

                    if (secondLine.Split(secondSeparator)[1] != line.Split(firstSeparator)[1]) continue;
                    isFoundMatch = true;
                }
                if (!isFoundMatch) filesToUpdate.Add(line.Split(firstSeparator)[0]);
            }
            return filesToUpdate;
        }

        private void SignWithDetails(StringBuilder info, string firstFile, int firstFileLines, string secondFile, int secondFileLines)
        {
            info.AppendLine($"\n\nDetails:\n");
            info.AppendLine($"File: {firstFile}\nContains: {firstFileLines} lines/hashes\n");
            info.AppendLine($"File: {secondFile}\nContains: {secondFileLines} lines/hashes");

            MessageBox.Show(info.ToString());
        }
    }
}
