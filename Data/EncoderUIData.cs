using MS4S_MD5Hasher.Handlers;

namespace MS4S_MD5Hasher.Data
{
    internal class EncoderUIData : UIItem
    {
        public TextBox PathBox { get; protected set; }
        public Button Button { get; protected set; }
        public Button ButtonBrowse { get; protected set; }
        public TextBox CustomName { get; protected set; }
        public TextBox CustomSeparator { get; protected set; }

        public Presenter.UIPage CorrespondingPage => Presenter.UIPage.Encoder;

        public EncoderUIData(TextBox pathBox, TextBox customName,
            TextBox customSeparator, Button buttonStart, Button buttonBrowse)
        {
            this.PathBox = pathBox;
            this.CustomName = customName;
            this.CustomSeparator = customSeparator;
            this.Button = buttonStart;
            this.ButtonBrowse = buttonBrowse;
        }

        public void ShowElements(bool state)
        {
            PathBox.Visible = state;
            Button.Visible = state;
            CustomName.Visible = state;
            CustomSeparator.Visible = state;
            ButtonBrowse.Visible = state;
        }
    }
}
