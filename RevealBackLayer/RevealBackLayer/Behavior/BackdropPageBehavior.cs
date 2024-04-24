using Syncfusion.Maui.Backdrop;

namespace RevealBackLayer
{
    public class BackdropPageBehavior : Behavior<SfBackdropPage>
    {
        private SfBackdropPage? backdropPage;
        private Button? revealButton;
        private bool IsBackLayerRevealed;

        protected override void OnAttachedTo(SfBackdropPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.backdropPage = bindable.FindByName<SfBackdropPage>("backdropPage");
            this.revealButton = bindable.FindByName<Button>("revealButton");
            this.revealButton.Clicked += RevealButton_Clicked;
        }

        private void RevealButton_Clicked(object? sender, EventArgs e)
        {
            if (this.backdropPage != null)
            {
                if (!IsBackLayerRevealed)
                {
                    this.IsBackLayerRevealed = true;
                    this.backdropPage.IsBackLayerRevealed = this.IsBackLayerRevealed;
                }
                else
                {
                    this.IsBackLayerRevealed = false;
                    this.backdropPage.IsBackLayerRevealed = this.IsBackLayerRevealed;
                }
            }
        }

        protected override void OnDetachingFrom(SfBackdropPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.backdropPage != null)
            {
                this.backdropPage = null;
            }
            
            if (this.revealButton != null)
            {
                this.revealButton.Clicked -= RevealButton_Clicked;
                this.revealButton = null;
            }
        }
    }
}
