using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samohlasky = "aeiouyáéěíóúůýAEIOUYÁÉĚÍÓÚŮÝ";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzžBCČDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";
            int samohlasek = 0, souhlasek = 0, nePismeno = 0;
            string text = textBox1.Text;
            foreach (char znak in text)
            {
                bool pomocna = false;
                if (samohlasky.Contains(znak))
                {
                    samohlasek++;
                    pomocna = true;
                }
                if (souhlasky.Contains(znak))
                {
                    souhlasek++;
                    pomocna = true;
                }
                if ((pomocna != true) &&  (((int)znak < 65) || ((int)znak > 90 && (int)znak < 97) || ((int)znak > 122)))
                {
                    nePismeno++;
                }
            }
            label3.Text = "V textu se nachází " + samohlasek.ToString() + " samohlásek.";
            label4.Text = "V textu se nachází " + souhlasek.ToString() + " souhlásek.";
            label5.Text = "V textu se nachází " + nePismeno.ToString() + " nepísmenných znaků.";
        }
        
    }
}
