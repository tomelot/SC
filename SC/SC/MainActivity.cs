using Android.App;
using Android.Widget;
using Android.OS;
using MySql.Data.MySqlClient;

namespace SC
{
    [Activity(Label = "SC", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
        }
    }
}

