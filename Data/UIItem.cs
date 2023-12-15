using MS4S_MD5Hasher.Handlers;

namespace MS4S_MD5Hasher.Data
{
    //base UI Item piece to call ShowElements(true/false) from presenter
    public interface UIItem
    {
        public Button Button { get; }

        public Presenter.UIPage CorrespondingPage { get; }

        public void ShowElements(bool state);
    }
}
