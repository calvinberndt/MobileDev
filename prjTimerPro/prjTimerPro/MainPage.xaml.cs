using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using prjTimerPro.Custom;
using System.Threading;

namespace prjTimerPro

{
    public partial class MainPage : ContentPage
    {

        cTimerLogic otimerlogic;
        bool isRunning; 

        public MainPage()
        {
            InitializeComponent();
            otimerlogic = new cTimerLogic();
        }

        void Start_Clicked(object sender, System.EventArgs e)
        {
            btnStop.IsEnabled = true;
            btnStart.IsEnabled = false;
            isRunning = true;

            Device.StartTimer(TimeSpan.FromSeconds(1),() => {
                otimerlogic.SecTickCounter();
                lblDisplay.Text = otimerlogic.GetFormatedString();
                return isRunning;
            });
        }

        void Stop_Clicked(object sender, System.EventArgs e)
        {
            btnStop.IsEnabled = false;
            btnStart.IsEnabled = true;
            isRunning = false;
        }

        void Reset_Clicked(object sender, System.EventArgs e)
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
            lblDisplay.Text = "00:00:00";
        }
    }
}
