using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        

      

        private void button1_Click(object sender, EventArgs e)
        {

            Pen p = new Pen(Color.Black);
            Class1.PersonThinBuilder ptb = new Class1.PersonThinBuilder(pictureBox1.CreateGraphics(), p);
            Class1.PersonDirctor pdThin = new Class1.PersonDirctor(ptb);
            pdThin.CreatePerson();

            Class1.PersonFatBuilder pfb = new Class1.PersonFatBuilder(pictureBox2.CreateGraphics(), p);
            Class1.PersonDirctor pdFat = new Class1.PersonDirctor(pfb);
            pdFat.CreatePerson();
        }
    }
}
