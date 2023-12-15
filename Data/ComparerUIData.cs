
using MS4S_MD5Hasher.Handlers;

namespace MS4S_MD5Hasher.Data
{
    internal class ComparerUIData : UIItem
    {
        public TextBox PathBox { get; protected set; }
        public TextBox PathBox2 { get; protected set; }
        public TextBox Separator { get; protected set; }
        public TextBox Separator2 { get; protected set; }

        public Button Button { get; protected set; }
        public Button BrowseFirstButton { get; protected set; }
        public Button BrowseSecondButton { get; protected set; }

        public Presenter.UIPage CorrespondingPage => Presenter.UIPage.Comparer;

        public ComparerUIData(TextBox pathBox, TextBox pathBox2,
            TextBox separator, TextBox separator2, Button buttonStart, 
            Button browseFirst, Button browseSecond)
        {
            this.PathBox = pathBox;
            this.Separator = separator;
            this.PathBox2 = pathBox2;
            this.Separator2 = separator2;
            this.Button = buttonStart;
            this.BrowseFirstButton = browseFirst;
            this.BrowseSecondButton = browseSecond;
        }

        public void ShowElements(bool state)
        {
            PathBox.Visible = state;
            Separator.Visible = state;
            PathBox2.Visible = state;
            Separator2.Visible = state;
            Button.Visible = state;
            BrowseFirstButton.Visible = state;
            BrowseSecondButton.Visible = state;
        }
    }
}
