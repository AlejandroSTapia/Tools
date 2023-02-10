using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tools.Droid
{

    [Activity(Label = "Caja de herramientas",
        Icon = "@mipmap/icon",
        Theme = "@style/newTheme",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize )]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            //Subscribe a MainActivity
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}