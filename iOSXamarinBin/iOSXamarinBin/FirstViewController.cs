using System;
using UIKit;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System.Collections.Generic;

namespace iOSXamarinBin
{
    public partial class FirstViewController : UIViewController
    {
        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib

            AnalyticsBtn.TouchUpInside += (object sender, EventArgs e) => {
                Analytics.TrackEvent("Video clicked", new Dictionary<string, string> {
                    { "Category", "Music" },
                    { "FileName", "favorite.avi"}
                });
            };

            CrashBtn.TouchUpInside += (object sender, EventArgs e) => {
                Crashes.GenerateTestCrash();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
