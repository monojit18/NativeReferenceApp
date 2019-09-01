using System;
using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using NativeReferenceApp.ViewModels;

namespace NativeReferenceApp.Droid
{
    [Activity(Label = "NativeReferenceApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        private NRAViewModel _nraViewModel;

        private async void NativeButtonClick(object sender, EventArgs e)
        {

            _nraViewModel.Notify = (object bindingInfo) =>
            {
                RunOnUiThread(() =>
                {

                    var str = (string)bindingInfo;
                    var ed = FindViewById<EditText>(Resource.Id.editText1);
                    ed.Text = str;

                });

            };

            await _nraViewModel.RetrieveNameAsync();

        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            _nraViewModel = new NRAViewModel();

            var btn = FindViewById<Button>(Resource.Id.button1);
            btn.Click += NativeButtonClick;


        }
       
    }
}

