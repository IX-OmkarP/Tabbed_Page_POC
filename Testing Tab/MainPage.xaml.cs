using Testing_Tab.View;

namespace Testing_Tab
{
    public partial class MainPage : TabbedPage
    {
        int count = 0;
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
                        Title = "Tab Page 1";
                        BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_1_Color"];
                    }
                    else if (CurrentPage is Tab_Page_2)
                    {
                        Title = "Tab Page 2";
                        BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_2_Color"];
                    }
                    else if (CurrentPage is Tab_Page_3)
                    {
                        Title = "Tab Page 3";
                        BarBackgroundColor = (Color)Application.Current.Resources["Tab_Page_3_Color"];
                    }
                    else
                    {
                        Title = "Unset Title";
                        BarBackgroundColor = (Color)Application.Current.Resources["No_Title_Color"];
                    }
                }
            }
            catch
            {
                Title = "Error";
                BarBackgroundColor = (Color)Application.Current.Resources["No_Title_Color"];
            }
        }
    }

}
