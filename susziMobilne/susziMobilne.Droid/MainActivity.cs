using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.Net;
using Windows.Data.Json;

namespace susziMobilne.Droid
{
    [Activity(Label = "susziMobilne.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += Button_Click;
        }

        private async void Button_Click(object sender, EventArgs e)
        {

            string login = FindViewById<EditText>(Resource.Id.loginTextBox).Text;
            string password = FindViewById<EditText>(Resource.Id.passwordTextBox).Text;
            RestService service = new RestService();
            var c=await service.CheckUser(login, password);
            
            if(string.IsNullOrEmpty(c))
            {

            }
            //service.CheckUserCompleted += Service_CheckUserCompleted;


            //if(ApiService.CheckUser(login,password))
            //{

            //}
        }

        //private void Service_CheckUserCompleted(object sender, Test e)
        //{
        //    if(e.value)
        //    {
        //        string c = "";
        //    }
        //}
    }
}


