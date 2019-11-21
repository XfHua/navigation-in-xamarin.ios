using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace App73
{
    [Register("UIViewControllerC")]
    public class UIViewControllerC : UIViewController
    {


        public UIViewControllerC()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view

            View.BackgroundColor = UIColor.Blue;

            UIButton myButton = new UIButton(UIButtonType.System);
            myButton.Frame = new CoreGraphics.CGRect(25, 25, 300, 150);
            myButton.SetTitle("Hello, World!CCCCCCCCCCCC", UIControlState.Normal);


            UIViewControllerD controlD =new UIViewControllerD();

            Action action = () => {
                NavigationController.PopToRootViewController(true);
            };

            myButton.TouchUpInside += (sender, e) => {
                
                //1. navigate to D
                //NavigationController.PushViewController(new UIViewControllerD(), true);
                
                //2. present D
                NavigationController.PresentViewController(controlD, true, action);
            };

            Add(myButton);

        }
    }
}