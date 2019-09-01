using System;
using System.Threading.Tasks;
using UIKit;
using NativeReferenceApp.ViewModels;

namespace NativeReferenceApp.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;
        private NRAViewModel _nraViewModel;

        private async void NativeButtonClick(object sender, EventArgs e)
        {

            _nraViewModel.Notify = (object bindingInfo) =>
            {
                InvokeOnMainThread(() =>
                {

                    var str = (string)bindingInfo;
                    NativeTextView.Text = str;

                });

            };

            await _nraViewModel.RetrieveNameAsync();

        }

        public ViewController(IntPtr handle) : base(handle)
        {

            _nraViewModel = new NRAViewModel();

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Code to start the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start ();
#endif


            NativeButton.TouchUpInside += NativeButtonClick;

            
        }

        

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.        
        }
    }
}
