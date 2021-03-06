﻿using Android.App;
using Android.Content;
using Xamarin.Forms;
using RadioZonica.Droid;
using RadioZonica.Interfaces;

[assembly: Dependency(typeof(ShareService))]
namespace RadioZonica.Droid
{
    class ShareService : ISocial
    {
        public void ShareLink(string Title)
        {
            var context = Forms.Context;
            Activity activity = context as Activity;

            Intent share = new Intent(Intent.ActionSend);
            share.SetType("text/plain");
            share.AddFlags(ActivityFlags.ClearWhenTaskReset);
            share.PutExtra(Intent.ExtraText, Title);

            activity.StartActivity(Intent.CreateChooser(share, "Compartir!"));
        }
    }
}