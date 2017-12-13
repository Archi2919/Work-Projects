using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class frmScreenSaver : Form
    {
        //Store a list of pictures
        List<Image> SSImages = new List<Image>();

        List<BritPic> BritPics = new List<BritPic>();
        //used to generate random numbers
        Random rand = new Random();


        public frmScreenSaver()
        {
            InitializeComponent();
        }

        private void frmScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            CloseScreenSaver();
        }

        private void frmScreenSaver_Click(object sender, EventArgs e)
        {
            CloseScreenSaver();
        }

        public void CloseScreenSaver()
        {
            this.Close();
        }

        private void frmScreenSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pictures");

            foreach (string image in images)
            {
                //creates a new bitmap picture and adds to the list
                SSImages.Add(new Bitmap(image));
            }

            for (int i = 0; i < 50; i++)
            {
                //keep adding images until there are 50 images
                BritPic mp = new BritPic();
                //remainder of the count in the list
                mp.PictureNumber = i % SSImages.Count;
                //get a random number between the windows width and height 
                mp.CoOrdinateX = rand.Next(0, Width);
                mp.CoOrdinateY = rand.Next(0, Height);
                //adds the picture object to the list
                BritPics.Add(mp);
            }
        }

        private void pictureTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void frmScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics)
            {
                e.Graphics.DrawImage(SSImages[bp.PictureNumber], bp.CoOrdinateX, bp.CoOrdinateY);
                bp.CoOrdinateX -= 2;

                //if the picture moves off the left edge of the screen move it back to the right edge
                if (bp.CoOrdinateX < -250)
                    bp.CoOrdinateX = Width + rand.Next(20, 100);
            }
        }
    }
}
