using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AddMaster
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Add_Clicked(object sender, System.EventArgs e)
        {
            double dblFirstNumber, dblSecondNumber;
            double.TryParse(txtFirstNumber.Text, out dblFirstNumber);
            double.TryParse(txtSecondNumber.Text, out dblSecondNumber);

            lblDisplay.Text = (dblFirstNumber + dblSecondNumber).ToString();

        }

        void Clear_Clicked(object sender, System.EventArgs e)
        {
            txtFirstNumber.Text = String.Empty;
            txtSecondNumber.Text = String.Empty;
            lblDisplay.Text = "0";
        }
    }
}
