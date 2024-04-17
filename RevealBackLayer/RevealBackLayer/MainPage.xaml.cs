using Syncfusion.Maui.Backdrop;

namespace RevealBackLayer
{
    public partial class MainPage : SfBackdropPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBackLayerTapped(object sender, EventArgs e)
        {
            if (!IsBackLayerRevealed)
            {
                this.IsBackLayerRevealed = true;
            }
            else
            {
                this.IsBackLayerRevealed = false;
            }
        }
    }

}
