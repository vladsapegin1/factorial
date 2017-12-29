using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryFactorial;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool ok = false;
            Factorial fact = new Factorial();
            int n = 0;
                ok = int.TryParse(textBox1.Text, out n);
            if (!ok)
                textBox1.Text = "Некорректный ввод!";
            else if (ok && n > 0)
                result.Text = n + "! = " + fact.calculate(n);


        }
    }
}
