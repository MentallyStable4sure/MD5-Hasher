
using MS4S_MD5Hasher.Handlers;

namespace MS4S_MD5Hasher.Data
{
    internal class ComparerUIData : UIItem
    {
        public TextBox PathBox { get; protected set; }
        public TextBox PathBox2 { get; protected set; }
        public Button Button { get; protected set; }

        public Presenter.UIPage CorrespondingPage => Presenter.UIPage.Comparer;

        public ComparerUIData(TextBox pathBox, TextBox pathBox2, 
            Button buttonStart)
        {
            this.PathBox = pathBox;
            this.PathBox2 = pathBox2;
            this.Button = buttonStart;
        }

        public void ShowElements(bool state)
        {
            PathBox.Visible = state;
            PathBox2.Visible = state;
            Button.Visible = state;
        }
    }
}
