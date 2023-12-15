using MS4S_MD5Hasher.Handlers;

namespace MS4S_MD5Hasher.Data
{
    internal class MenuUIData : UIItem
    {
        public Label OrLabel { get; protected set; }
        public Button Button { get; protected set; }
        public Button Button2 { get; protected set; }

        public Presenter.UIPage CorrespondingPage => Presenter.UIPage.Menu;

        public MenuUIData(Label orBox, Button buttonEncodeMode,
            Button buttonCompareMode)
        {
            this.OrLabel = orBox;
            this.Button = buttonCompareMode;
            this.Button2 = buttonEncodeMode;
        }

        public void ShowElements(bool state)
        {
            OrLabel.Visible = state;
            Button.Visible = state;
            Button2.Visible = state;
        }
    }
}
