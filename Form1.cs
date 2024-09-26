using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvalto_20240926
{
    public partial class form : Form
    {
        public int asd = 0;
        public form()
        {
            InitializeComponent();

        }

        private void btirany_Click(object sender, EventArgs e)
        {
            txromai.Text = "";
            txarab.Text = "";

            asd = asd + 1;
            if (asd % 2 == 0)
            {
                btirany.Text = "-->";
                txarab.Enabled = false;
                txromai.Enabled = true;
            }
            else
            {
                btirany.Text = "<--";
                txarab.Enabled = true;
                txromai.Enabled = false;
                
            }
        }

        private void btatvalt_Click(object sender, EventArgs e)
        {
            //int arab=Convert.ToInt32(txarab.Text);
            

            if (txarab.Text == "1")
            {
                txromai.Text = "I";
            }
            else if (txarab.Text == "2")
            {
                txromai.Text = "II";
            }
            else if (txarab.Text == "3")
            {
                txromai.Text = "III";
            }
            else if (txarab.Text == "4")
            {
                txromai.Text = "IV";
            }
            else if (txarab.Text == "5")
            {
                txromai.Text = "V";
            }
            else if (txarab.Text == "6")
            {
                txromai.Text = "VI";
            }
            else if (txarab.Text == "7")
            {
                txromai.Text = "VII";
            }
            else if (txarab.Text == "8")
            {
                txromai.Text = "VIII";
            }
            else if (txarab.Text == "9")
            {
                txromai.Text = "IX";
            }
            else if (txarab.Text == "10")
            {
                txromai.Text = "X";
            }
            //else if ()
            //{
            //    txromai.Text = "Hiba!";
            //}



            else if (txromai.Text == "I")
            {
                txarab.Text = "1";
            }
            else if (txromai.Text == "II")
            {
                txarab.Text = "2";
            }
            else if (txromai.Text == "III")
            {
                txarab.Text = "3";
            }
            else if (txromai.Text == "IV")
            {
                txarab.Text = "4";
            }
            else if (txromai.Text == "V")
            {
                txarab.Text = "5";
            }
            else if (txromai.Text == "VI")
            {
                txarab.Text = "6";
            }
            else if (txromai.Text == "VII")
            {
                txarab.Text = "7";
            }
            else if (txromai.Text == "VIII")
            {
                txarab.Text = "8";
            }
            else if (txromai.Text == "IX")
            {
                txarab.Text = "9";
            }
            else if (txromai.Text == "X")
            {
                txarab.Text = "10";
            }
            else
            {
                if (txarab.Text == "1" && txarab.Text == "2" && txarab.Text == "3" && txarab.Text == "4" && txarab.Text == "5" && txarab.Text == "6" && txarab.Text == "7" && txarab.Text == "8" && txarab.Text == "9" && txarab.Text == "10")
                {

                }
                
            }
        }
    }
}
