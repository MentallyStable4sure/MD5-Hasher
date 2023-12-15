using MS4S_MD5Hasher.Properties;

//Not much goin here, just a themes controller that can switch up between theme backs
namespace MS4S_MD5Hasher.Handlers
{
    public enum Themes
    {
        BeerMaf = 0,
        Underwater,
        ElfForest,
        ChurchGoth,
        AyakaBlackBra,
        SonaCyanBra,
        GwenShowsPanties,
        RaidenPurpleBra,
        RaidenNSFW,
        YelanNSFW
    }

    internal class ThemeController
    {
        private ComboBox themeBox;

        private Form form;

        public ThemeController(Form form, ComboBox themeBox)
        {
            this.form = form;
            this.themeBox = themeBox;

            themeBox.SelectedIndexChanged += SetNewTheme;
        }

        private void SetNewTheme(object? sender, EventArgs e)
        {
            var theme = (Themes)themeBox.SelectedIndex;
            Bitmap map;

            switch (theme)
            {
                case Themes.RaidenPurpleBra:
                    map = Resources.raidenpurplebra;
                    break;
                case Themes.Underwater:
                    map = Resources.bg;
                    break;
                case Themes.ElfForest:
                    map = Resources.elfforest;
                    break;
                case Themes.ChurchGoth:
                    map = Resources.churchgoth;
                    break;
                case Themes.SonaCyanBra:
                    map = Resources.sona;
                    break;
                case Themes.AyakaBlackBra:
                    map = Resources.ayaka;
                    break;
                case Themes.GwenShowsPanties:
                    map = Resources.gwenshowoff;
                    break;
                case Themes.RaidenNSFW:
                    map = Resources.raiden;
                    break;
                case Themes.YelanNSFW:
                    map = Resources.yelan;
                    break;

                default:
                    map = Resources.beermaf;
                    break;
            }

            form.BackgroundImage = map;
        }
    }
}
