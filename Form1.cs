
namespace MS4S_MD5Hasher
{
    public partial class MS4SMD5Hasher : Form
    {
        private string filename = "sum";
        private string separator = ":";

        private Hasher hasher;

        public MS4SMD5Hasher()
        {
            InitializeComponent();
            new ThemeController(this, themeBox);
            hasher = new Hasher(folderBrowser);

            ShowRestUI(false);
            loadingAnimation.Visible = false;

            pathBox.PlaceholderText = "Choose path where to take files to encode";
            pathBox.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e) => BrowseDirectory();

        private void UpdatePath(object sender, FileSystemEventArgs e) => pathBox.Text = e.FullPath;

        public void BrowseDirectory()
        {
            var dialogResult = folderBrowser.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                pathBox.Text = string.Empty;
                startButton.Visible = false;
                return;
            }

            var path = folderBrowser.SelectedPath;
            if (!Directory.Exists(path) && path.Length > 1)
            {
                DialogResult = DialogResult.Cancel;
                pathBox.Text = string.Empty;
                return;
            }

            folderBrowser.InitialDirectory = path;
            pathBox.Text = path;

            ShowRestUI(true);
        }

        public void ShowRestUI(bool state)
        {
            startButton.Visible = state;
            filenameBox.Visible = state;
            separatorBox.Visible = state;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (filenameBox.Text.Length > 0) filename = filenameBox.Text;
            if (separatorBox.Text.Length > 0) separator = separatorBox.Text;

            loadingAnimation.Visible = true;
            string cachedPath = pathBox.Text;
            pathBox.Text = "Computing MD5 hashes...";

            hasher.Checksum(filename, separator);

            pathBox.Text = cachedPath;
            loadingAnimation.Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e) => Application.Exit();
    }
}