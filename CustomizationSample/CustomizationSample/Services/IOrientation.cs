using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace CustomizationSample.Services
{
    public interface IOrientation
    {
        DeviceOrientation GetOrientation();
    }
}
