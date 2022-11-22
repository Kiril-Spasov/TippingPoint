using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TippingPoint
{
    public partial class FormTippingPoint : Form
    {
        public FormTippingPoint()
        {
            InitializeComponent();
        }

        //Initial positions of the die.
        int top = 1;
        int front = 2;
        int right = 3;
        int left = 4;
        int back = 5;
        int bottom = 6;

        private void BtnDetermineValue_Click(object sender, EventArgs e)
        {
            string line = "";

            string path = Application.StartupPath + @"\tipping.txt";
            StreamReader streamReader = new StreamReader(path);

            bool finished = false;

            while (!finished)
            {
                line = streamReader.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    Tip(line);
                }
            }
            TxtResult.Text += "Final top value is: " + top;
        }

        private void Tip(string instruction)
        {
            switch (instruction)
            {
                //We know as per assignment that two opposite sides sum up to 7.
                case "AWAY":
                    top = front;
                    front = bottom;
                    bottom = 7 - top;
                    back = 7 - front;
                    break;
                case "TOWARD":
                    front = top;
                    top = back;
                    back = 7 - front;
                    bottom = 7 - top;
                    break;
                case "LEFT":
                    left = top;
                    top = right;
                    right = 7 - left;
                    bottom = 7 - top;
                    break;
                case "RIGHT":
                    right = top;
                    top = left;
                    left = 7 - right;
                    bottom = 7 - top;
                    break;
            }
        }
    }
}
