using MS4S_MD5Hasher.Data;

namespace MS4S_MD5Hasher.Handlers
{

    public partial class Presenter
    {
        private UIItem[] datas;

        public enum UIPage
        {
            Menu = 0,
            Comparer,
            Encoder
        }

        public Presenter(UIItem[] datas) => this.datas = datas;

        public void ShowUI(UIPage ui)
        {
            foreach (var data in datas)
            {
                data.ShowElements(data.CorrespondingPage == ui);
            }
        }
    }
}
