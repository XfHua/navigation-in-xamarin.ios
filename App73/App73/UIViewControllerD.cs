using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace App73
{

    [Register("UIViewControllerA")]
    public class UIViewControllerD : UIViewController
    {

        public event EventHandler DidDismissCallBack;

        public UIViewControllerD()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view

            View.BackgroundColor = UIColor.Red;

            UIButton myButton = new UIButton(UIButtonType.System);
            myButton.Frame = new CoreGraphics.CGRect(25, 25, 300, 150);
            myButton.SetTitle("Hello, World!ddddddddd", UIControlState.Normal);

            myButton.TouchUpInside += (sender, e) => {

                //1. navigate to root ViewControll
                //NavigationController.PopToRootViewController(true);

                //2. Dismiss D
                this.DismissViewController(true,null);

            };

            Add(myButton);

        }
    }
}