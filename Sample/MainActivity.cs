using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Umeng.Message;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            PushAgent mPushAgent = PushAgent.GetInstance(this);
            mPushAgent.Enable();
            new TaskFactory().StartNew(() =>
            {
                mPushAgent.AddAlias("15050851037", "test");
            });

            PushAgent.GetInstance(this).OnAppStart();
        }
    }
}

