using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using CoreGraphics;

namespace App73
{

    [Register("UIViewControllerB")]
    public class UIViewControllerB : UIViewController
    {
        public UIViewControllerB()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {

            base.ViewDidLoad();

            // Perform any additional setup after loading the view

            View.BackgroundColor = UIColor.Yellow;

            UIButton myButton = new UIButton(UIButtonType.System);
            myButton.Frame = new CGRect(25, 25, 300, 150);
            myButton.SetTitle("Hello, World!BBBBBBBBB", UIControlState.Normal);

            myButton.TouchUpInside += (sender, e) => {

                NavigationController.PushViewController(new UIViewControllerC(), true);
            };

            Add(myButton);

        }
    }
}