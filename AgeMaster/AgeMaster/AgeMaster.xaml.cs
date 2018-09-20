using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgeMaster
{
    public partial class AgeMaster : ContentPage
    {
        public AgeMaster()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            string monthString = monthEntry.Text;
            string dayString = dayEntry.Text;
            string yearString = yearEntry.Text;

            int month, day, year;

            if (int.TryParse(monthString, out month))
            {
                //yayaya!
                if (int.TryParse(dayString, out day))
                {
                    //noo!
                }
                else{
                    //noo!
                }
                    if (int.TryParse(yearString, out year))
                    {
                    //yess!
                    }
                    else
                    {

                    }
            }
            
            month = int.Parse(monthString);
            day = int.Parse(dayString);
            year = int.Parse(yearString);

            DateTime birthDate = new DateTime(year, month, day);

            TimeSpan age = DateTime.Now - birthDate;

            int daysOfLife = age.Days;

            int yearsOfLife = daysOfLife / 365;

            AgeLabel.Text = yearsOfLife.ToString();

        }
    }
}
