using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Calculator
{
    [Activity(Label = "Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            var button = FindViewById<Button>(Resource.Id.button1);
            var editText1 = FindViewById<EditText>(Resource.Id.editText1);
            var editText2 = FindViewById<EditText>(Resource.Id.editText2);
            var textView3 = FindViewById<TextView>(Resource.Id.textView3);
            button.Click += delegate
             {
                 textView3.Text = (Convert.ToInt32(editText1.Text) + Convert.ToInt32(editText2.Text)).ToString();
             };
        }
    }
}

