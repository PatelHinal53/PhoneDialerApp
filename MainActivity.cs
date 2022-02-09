using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Xamarin.Essentials;

namespace PhoneDialerAppEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText ClickedOnDial;
        private Button button1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ClickedOnDial = FindViewById<EditText>(Resource.Id.editText);
            button1 = FindViewById<Button>(Resource.Id.button);

            button1.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ClickedOnDial = FindViewById<EditText>(Resource.Id.editText);

            string number = ClickedOnDial.Text;
            PhoneDialer.Open(number);
        }   
    }
}