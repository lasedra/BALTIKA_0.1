using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaltikaApp
{
    public partial class OpenImageForm : Form
    {
        public OpenImageForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void LoadImage(byte[] image)
        {
            using (MemoryStream memstr = new MemoryStream(image))
            {
                Image img = Image.FromStream(memstr);
                VesselPictureBox.Image = img;
            }
        }
    }
}
