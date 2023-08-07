using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace erpX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class materialReceive : ContentPage
    {
        bool isNewFrameVisible = false;
        public materialReceive()
        {
            InitializeComponent();
        }

        private void newButton_Clicked(object sender, EventArgs e)
        {
            isNewFrameVisible = !isNewFrameVisible;
            newFrame.IsVisible = isNewFrameVisible;
        }

    }
}