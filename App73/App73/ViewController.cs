using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace App73
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            UIButton myButton = new UIButton(UIButtonType.System);
            myButton.Frame = new CGRect(25, 25, 300, 150);
            myButton.SetTitle("Hello, World!AAAAAAA", UIControlState.Normal);
            myButton.TouchUpInside += (sender, e) => {
                NavigationController.PushViewController(new UIViewControllerB(), true);
            };

            Add(myButton);
        }
    }
}