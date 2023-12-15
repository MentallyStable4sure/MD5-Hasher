using MS4S_MD5Hasher.Data;
using MS4S_MD5Hasher.Handlers;

namespace MS4S_MD5Hasher
{
    public partial class MS4SMD5Hasher : Form
    {
        private string filename = "sum";
        private string separator = ":";

        private Hasher hasher;
        private HashComparer comparer;
        private Presenter presenter;

        public MS4SMD5Hasher()
        {
            InitializeComponent();

            var comparerData = new ComparerUIData(pathBox, pathBox2, startCompareButton);
            var encoderData = new EncoderUIData(pathBox, filenameBox, separatorBox, startEncodeButton, browseButton);

            new ThemeController(this, themeBox);
            hasher = new Hasher(folderBrowser, encoderData);
            comparer = new HashComparer(pathBox, pathBox2);
            presenter = new Presenter(
                new UIItem[]
                {
                    comparerData,
                    encoderData,
                    new MenuUIData(labelOr, encodeModeButton, compareModeButton)
                });

            presenter.ShowUI(Presenter.UIPage.Menu);
        }

        private void button1_Click(object sender, EventArgs e) => hasher.BrowseDirectory();

        private void UpdatePath(object sender, FileSystemEventArgs e) => pathBox.Text = e.FullPath;

        private void startButton_Click(object sender, EventArgs e)
        {
            if (filenameBox.Text.Length > 0) filename = filenameBox.Text;
            if (separatorBox.Text.Length > 0) separator = separatorBox.Text;

            loadingAnimation.Visible = true;
            hasher.Checksum(filename, separator);
            loadingAnimation.Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e) => Application.Exit();

        private void compareModeButton_Click(object sender, EventArgs e) => presenter.ShowUI(Presenter.UIPage.Comparer);

        private void encodeModeButton_Click(object sender, EventArgs e) => presenter.ShowUI(Presenter.UIPage.Encoder);

        private void menuButton_Click(object sender, EventArgs e) => presenter.ShowUI(Presenter.UIPage.Menu);
    }
}