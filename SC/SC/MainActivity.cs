using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using MySql.Data.MySqlClient;


namespace SC
{
    [Activity(Label = "SC", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.NewGame);

            Button button = FindViewById<Button>(Resource.Id.Start);
            button.Click += (o, e) => {
                var Name = FindViewById<EditText>(Resource.Id.Name);
                var TeamMumber1 = FindViewById<EditText>(Resource.Id.TeamMumber1);
                var TeamMumber2 = FindViewById<EditText>(Resource.Id.TeamMumber2);
                var TeamMumber3 = FindViewById<EditText>(Resource.Id.TeamMumber3);
                var TeamMumber4 = FindViewById<EditText>(Resource.Id.TeamMumber4);

            };
            
        }

       
    }
}

