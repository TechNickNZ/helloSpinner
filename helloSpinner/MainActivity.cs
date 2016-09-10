using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace helloSpinner
{
    [Activity(Label = "helloSpinner", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            String[] tmpString;
            tmpString = new string[9];
            int i = 0;
            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);
            ArrayAdapter SpinnerData = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem);
            SpinnerData.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerItem);

            for (i=0; i < 9; i++)
            {
                SpinnerData.Add(i);
                tmpString[i] = i.ToString();
            }

            spinner.Adapter = SpinnerData;
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;

            string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
    }
}

