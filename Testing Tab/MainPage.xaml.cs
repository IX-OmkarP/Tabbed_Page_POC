using Testing_Tab.Helper;
using Testing_Tab.View;

namespace Testing_Tab
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            CurrentPageChanged += MainPage_CurrentPageChanged;
        }
        private void MainPage_CurrentPageChanged(object sender, EventArgs e)
        {
            ChangeTabColor();
        }

        private void ChangeTabColor()
        {
            try
            {
                if (CurrentPage != null)
                {
                    if (CurrentPage is Tab_Page_1)
                    {
                        Title = Constants.TITLE_TAB_PAGE_1;
                        BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_1_Color"];

                        ((NavigationPage)Parent).Title = Constants.TITLE_TAB_PAGE_1;
                        ((NavigationPage)Parent).BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_1_Color"];
                    }
                    else if (CurrentPage is Tab_Page_2)
                    {
                        Title = Constants.TITLE_TAB_PAGE_2;
                        BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_2_Color"];

                        ((NavigationPage)Parent).Title = Constants.TITLE_TAB_PAGE_2;
                        ((NavigationPage)Parent).BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_2_Color"];
                    }
                    else if (CurrentPage is Tab_Page_3)
                    {
                        Title = Constants.TITLE_TAB_PAGE_3;
                        BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_3_Color"];

                        ((NavigationPage)Parent).Title = Constants.TITLE_TAB_PAGE_3;
                        ((NavigationPage)Parent).BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_3_Color"];
                    }
                    else
                    {
                        Title = Constants.TITLE_NO_TITLE;
                        BarBackgroundColor = (Color)Application.Current.Resources["No_Title_Color"];

                        ((NavigationPage)Parent).Title = Constants.TITLE_NO_TITLE;
                        ((NavigationPage)Parent).BarBackgroundColor = (Color)Application.Current.Resources["No_Title_Color"];
                    }
                }
            }
            catch
            {
                Title = Constants.TITLE_NO_TITLE;
                BarBackgroundColor = (Color)Application.Current.Resources["No_Title_Color"];
                ((NavigationPage)Parent).BarBackgroundColor = (Color)Application.Current.Resources["No_Title_Color"];
            }
        }
    }

}
