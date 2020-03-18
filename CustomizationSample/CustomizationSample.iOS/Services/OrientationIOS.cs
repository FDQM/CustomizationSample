using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomizationSample.iOS.Services;
using CustomizationSample.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(OrientationIOS))]
namespace CustomizationSample.iOS.Services
{
    class OrientationIOS : IOrientation
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}