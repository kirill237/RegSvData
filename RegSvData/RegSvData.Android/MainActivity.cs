using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Android.Content;
using System.Threading;

namespace RegSvData.Droid
{
    

	[Activity (Label = "RegSvData", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
        public static int width;
        protected override void OnCreate (Bundle bundle)
		{
            this.RequestedOrientation = ScreenOrientation.Portrait;
            TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

            var metrics = Resources.DisplayMetrics;
            width = metrics.HeightPixels;
            Console.Out.WriteLine(width.ToString());

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication (new RegSvData.App ());


        }

        public override void OnBackPressed()
        {
            OnStop();
        }
    }
}

