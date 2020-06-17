using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Buddy
{
    public partial class frmTimeBuddy : Form
    {
        public frmTimeBuddy()
        {
            InitializeComponent();

            txtInput.Text = string.Empty;
            txtOutput.Text = string.Empty;
        }

        private void btnConvCalculate_Click(object sender, EventArgs e)
        {
            string[] fields = txtInput.Text.Split(':');
            string T = txtInput.Text;
            T = T.Replace('d', '.');
            T = T.Replace('D', '.');

            try
            {
                switch (fields.Length)
                {
                    case 1:
                        txtOutput.Text = Convert1(T);
                        break;

                    case 2:
                        txtOutput.Text = Convert2(T);
                        break;

                    case 3:
                        txtOutput.Text = Convert3(T);
                        break;

                    default:
                        txtOutput.Text = "Error!";
                        break;
                }
            }
            catch { txtOutput.Text = "Error!"; }
        }

        private string Convert1 (string value)
        {
            TimeSpan time = TimeSpan.FromSeconds(Convert.ToDouble(value));

            return time.ToString(@"d\dhh\:mm\:ss\.ff");
        }

        private string Convert2(string value)
        {
            return TimeSpan.Parse("00:" + value).TotalSeconds.ToString();
        }

        private string Convert3(string value)
        {
            return TimeSpan.Parse(value).TotalSeconds.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] fields1 = txtT1.Text.Split(':');
            string T1 = txtT1.Text;
            T1 = T1.Replace('d', '.');
            T1 = T1.Replace('D', '.');

            double seconds1 = 0.0, seconds2 = 0.0;

            try
            {
                switch (fields1.Length)
                {
                    case 1:
                        seconds1 = Convert.ToDouble(T1);
                        break;

                    case 2:
                        seconds1 = Convert.ToDouble(Convert2(T1));
                        break;

                    case 3:
                        seconds1 = Convert.ToDouble(Convert3(T1));
                        break;

                    default:
                        txtResultsS.Text = "Error!";
                        break;
                }
            }
            catch { txtResultsS.Text = "Error!"; }

            string[] fields2 = txtT2.Text.Split(':');
            string T2 = txtT2.Text;
            T2 = T2.Replace('d', '.');
            T2 = T2.Replace('D', '.');

            try
            {
                switch (fields2.Length)
                {
                    case 1:
                        seconds2 = Convert.ToDouble(T2);
                        break;

                    case 2:
                        seconds2 = Convert.ToDouble(Convert2(T2));
                        break;

                    case 3:
                        seconds2 = Convert.ToDouble(Convert3(T2));
                        break;

                    default:
                        txtResultsS.Text = "Error!";
                        break;
                }
            }
            catch { txtResultsS.Text = "Error!"; }

            TimeSpan time = TimeSpan.FromSeconds(seconds1 + seconds2);

            txtResultsS.Text = Convert.ToString(seconds1 + seconds2);
            txtResultsHMS.Text = time.ToString(@"d\dhh\:mm\:ss\.ff");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            string[] fields1 = txtT1.Text.Split(':');
            string T1 = txtT1.Text;
            T1 = T1.Replace('d', '.');
            T1 = T1.Replace('D', '.');

            double seconds1 = 0.0, seconds2 = 0.0;

            try
            {
                switch (fields1.Length)
                {
                    case 1:
                        seconds1 = Convert.ToDouble(T1);
                        break;

                    case 2:
                        seconds1 = Convert.ToDouble(Convert2(T1));
                        break;

                    case 3:
                        seconds1 = Convert.ToDouble(Convert3(T1));
                        break;

                    default:
                        txtResultsS.Text = "Error!";
                        break;
                }
            }
            catch { txtResultsS.Text = "Error!"; }

            string[] fields2 = txtT2.Text.Split(':');
            string T2 = txtT2.Text;
            T2 = T2.Replace('d', '.');
            T2 = T2.Replace('D', '.');

            try
            {
                switch (fields2.Length)
                {
                    case 1:
                        seconds2 = Convert.ToDouble(T2);
                        break;

                    case 2:
                        seconds2 = Convert.ToDouble(Convert2(T2));
                        break;

                    case 3:
                        seconds2 = Convert.ToDouble(Convert3(T2));
                        break;

                    default:
                        txtResultsS.Text = "Error!";
                        break;
                }
            }
            catch { txtResultsS.Text = "Error!"; }

            TimeSpan time = TimeSpan.FromSeconds(Math.Abs(seconds1 - seconds2));

            txtResultsS.Text = Convert.ToString(Math.Abs(seconds1 - seconds2));
            txtResultsHMS.Text = time.ToString(@"d\dhh\:mm\:ss\.ff");
        }
    }
}
