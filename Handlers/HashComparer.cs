using MS4S_MD5Hasher.Data;
using System.Text;

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
                MessageBox.Show("[Error] Please provide both files to check and their separators, they should be text formatted");
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
                info.AppendLine("[Error] No need to check further since length arent matching, they are NOT equal");
                SignWithDetails(info, firstFile, firstFileLines.Length, secondFile, secondFileLines.Length);
                return;
            }

            for (int i = 0; i < firstFileLines.Length; i++)
            {
                if (firstFileLines[i].Length <= 1) continue; //prob empty line we dont care about that
                string[] split = firstFileLines[i].Split(firstSeparator);
                if(split == null || split.Length < 1)
                {
                    info.AppendLine($"[Error] We tried to split hash with path in half but we couldn't, double check separator, you gave us: '{firstSeparator}', but looks like its not it");
                    SignWithDetails(info, firstFile, firstFileLines.Length, secondFile, secondFileLines.Length);
                    return;
                }
                string firstHash = split[1]; //first file separator TODO: custom player separator

                if(!CheckPair(firstHash, secondFileLines, secondSeparator))
                {
                    info.AppendLine($"[Error] We tried our best my dudes, but nothing with this hash: {firstHash} was found in second file, you might wanna double check your separator or second file just doesnt have this hash..");
                    SignWithDetails(info, firstFile, firstFileLines.Length, secondFile, secondFileLines.Length);
                    return;
                }
            }

            info.AppendLine($"♡♡♡♡♡♡♡♡");
            info.AppendLine($"[Good] They purrfectly matched each other, 100%");

            SignWithDetails(info, firstFile, firstFileLines.Length, secondFile, secondFileLines.Length);
        }

        private bool CheckPair(string firstHash, string[] whereToCheck, string separator = ":")
        {
            foreach (string secondLine in whereToCheck)
            {
                string[] split = secondLine.Split(separator);
                if (split == null || split.Length < 1) return false; //wrong separator we couldnt cut

                string secondHash = secondLine.Split(separator)[1]; //second file separator TODO: custom player separator
                if (secondHash != firstHash) continue; //didnt find match, check next

                return true; //we did it boys, we found the pair
            }

            return false; //sadge, we did our best iterating entire stack but nothing was found :C
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
