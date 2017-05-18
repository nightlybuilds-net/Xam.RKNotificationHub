// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xam.RKNotificationHub.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton IncrementButton { get; set; }

		[Outlet]
		UIKit.UIView TestView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TestView != null) {
				TestView.Dispose ();
				TestView = null;
			}

			if (IncrementButton != null) {
				IncrementButton.Dispose ();
				IncrementButton = null;
			}
		}
	}
}
