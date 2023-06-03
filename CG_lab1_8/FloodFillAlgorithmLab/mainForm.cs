using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloodFillAlgorithmLab
{
    public partial class mainForm : Form
    {
        private Bitmap sourceImage;
        private Bitmap resultImage;

        public mainForm()
        {
            InitializeComponent();
        }
        private void btOpen_Click(object sender, EventArgs e)
        {
            if (dOpen.ShowDialog() == DialogResult.OK)
            {
                sourceImage = new Bitmap(dOpen.OpenFile());
                pbSource.Image = sourceImage;
                resultImage = new Bitmap(sourceImage);
                pbRes.Image = resultImage;
            }
        }

        private void pbSource_MouseClick(object sender, MouseEventArgs e)
        {
            GraphicsUtils.FloodFillAlgorithm(sourceImage,
                                             resultImage,
                                             e.Location.X,
                                             e.Location.Y);
            pbRes.Image = resultImage; // Обновление PictureBox для отображения изменений
            pbRes.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
