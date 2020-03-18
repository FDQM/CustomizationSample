using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomizationSample.Controls;
using CustomizationSample.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryIOS))]
namespace CustomizationSample.iOS.Renderers
{
    class ExtendedEntryIOS:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.DarkGray;
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}