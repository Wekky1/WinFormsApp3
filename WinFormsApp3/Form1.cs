using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.FirstWord1 = TxtFirst.Text;
            Properties.Settings.Default.SecondWord2 = TxtSecond.Text;

            MessageBox.Show(Logic.Compare(TxtFirst.Text, TxtSecond.Text));
        }
    }

    public class Logic
    {
        public static string Compare(string FirstString, string SecondString)
        {
            string outMessage = string.Empty;

            for (int i = 0; i <= FirstString.Length - 2; i++)
            {
                for (int j = i + 1; j <= FirstString.Length - 1; j++)
                {
                    if (FirstString[i] == FirstString[j])
                        FirstString = FirstString.Remove(j, 1);
                }
            }


            for (int i = 0; i < FirstString.Length; i++)
            {
                if (SecondString.Contains(FirstString[i]))
                    outMessage += "Да ";

                else
                    outMessage += "Нет ";
            }

            return outMessage;
        }

    }
}
