using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl001
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }




        private void vad_Label2_Click(object sender, EventArgs e)
        {
            const string message =
      "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                // e.Cancel = true;
            }
        }
    }
}
