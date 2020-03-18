using CustomizationSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomizationSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            DeviceOrientation orientation = DependencyService.Get<IOrientation>().GetOrientation();
            OrientationLabel.Text = "This view is in " + orientation.ToString() + " Mode";
        }
    }
}
