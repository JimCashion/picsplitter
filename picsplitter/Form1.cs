using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picsplitter
{
    public partial class Form1 : Form
    {
        string path4x4 = @"C:\jim\picsplitter\pics\4x4\";
        string path5x5 = @"C:\jim\picsplitter\pics\5x5\";
        string path6x6 = @"C:\jim\picsplitter\pics\6x6\";
        string path7x7 = @"C:\jim\picsplitter\pics\7x7\";
        Image mainimage;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbtype.Text)
            {
                case "4x4":
                    pborig.Size = new Size(352, 352);
                    mainimage = Image.FromFile(path4x4 + cbtype.Text + ".png");
                    pborig.Image = mainimage;

                    do4x4();
                    break;
                case "5x5":
                    pborig.Size = new Size(500, 500);
                    mainimage = Image.FromFile(path5x5 + cbtype.Text + ".png");
                    pborig.Image = mainimage;

                    do5x5();
                    break;
                case "6x6":
                    pborig.Size = new Size(480, 480);
                    mainimage = Image.FromFile(path6x6 + cbtype.Text + ".png");
                    pborig.Image = mainimage;

                    do6x6();
                    break;
                case "7x7":
                    pborig.Size = new Size(490, 490);
                    mainimage = Image.FromFile(path7x7 + cbtype.Text + ".png");
                    pborig.Image = mainimage;

                    do7x7();
                    break;
            }
        }

        private void do7x7()
        {
            this.Width = 3 * 490 + 150;

            for (int x = 0;x<7;x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    PictureBox pb1 = new PictureBox();
                    pb1.Size = new Size(70, 70);
                    pb1.Location = new Point(540 + x * 70, 50 + y * 70);

                    PictureBox pb2 = new PictureBox();
                    pb2.Size = new Size(70, 70);
                    pb2.Location = new Point(1080 + x * 70, 50 + y * 70);

                    //pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    Bitmap bmp = new Bitmap(path7x7 + cbtype.Text + ".png");
                    Bitmap piece = bmp.Clone(new Rectangle(x * 70, y * 70, 70, 70), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    
                    Image i = piece;
                    pb1.Image = i;

                    string newpicpath = path7x7 + "i" + x.ToString() + "x" + y.ToString() + ".png";
                    piece.Save(newpicpath, System.Drawing.Imaging.ImageFormat.Png);

                    pb2.Image = Image.FromFile(newpicpath);

                    this.Controls.Add(pb1);
                    this.Controls.Add(pb2);
                }
            }
        }

        private void do6x6()
        {
            this.Width = 3 * 480 + 150;

            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    PictureBox pb1 = new PictureBox();
                    pb1.Size = new Size(80, 80);
                    pb1.Location = new Point(530 + x * 80, 50 + y * 80);

                    PictureBox pb2 = new PictureBox();
                    pb2.Size = new Size(80, 80);
                    pb2.Location = new Point(1060 + x * 80, 50 + y * 80);

                    //pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    Bitmap bmp = new Bitmap(path6x6 + cbtype.Text + ".png");
                    Bitmap piece = bmp.Clone(new Rectangle(x * 80, y * 80, 80, 80), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                    Image i = piece;
                    pb1.Image = i;

                    string newpicpath = path6x6 + "i" + x.ToString() + "x" + y.ToString() + ".png";
                    piece.Save(newpicpath, System.Drawing.Imaging.ImageFormat.Png);

                    pb2.Image = Image.FromFile(newpicpath);

                    this.Controls.Add(pb1);
                    this.Controls.Add(pb2);
                }
            }
        }

        private void do5x5()
        {
            this.Width = 3 * 500 + 150;

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    PictureBox pb1 = new PictureBox();
                    pb1.Size = new Size(100, 100);
                    pb1.Location = new Point(550 + x * 100, 50 + y * 100);

                    PictureBox pb2 = new PictureBox();
                    pb2.Size = new Size(100, 100);
                    pb2.Location = new Point(1100 + x * 100, 50 + y * 100);

                    //pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    Bitmap bmp = new Bitmap(path5x5 + cbtype.Text + ".png");
                    Bitmap piece = bmp.Clone(new Rectangle(x * 100, y * 100, 100, 100), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                    Image i = piece;
                    pb1.Image = i;

                    string newpicpath = path5x5 + "i" + x.ToString() + "x" + y.ToString() + ".png";
                    piece.Save(newpicpath, System.Drawing.Imaging.ImageFormat.Png);

                    pb2.Image = Image.FromFile(newpicpath);

                    this.Controls.Add(pb1);
                    this.Controls.Add(pb2);
                }
            }
        }
        private void do4x4()
        {
            this.Width = 3 * 352 + 150;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    PictureBox pb1 = new PictureBox();
                    pb1.Size = new Size(88, 88);
                    pb1.Location = new Point(400 + x * 88, 50 + y * 88);

                    PictureBox pb2 = new PictureBox();
                    pb2.Size = new Size(88, 88);
                    pb2.Location = new Point(800 + x * 88, 50 + y * 88);

                    //pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    Bitmap bmp = new Bitmap(path4x4 + cbtype.Text + ".png");
                    Bitmap piece = bmp.Clone(new Rectangle(x * 88, y * 88, 88, 88), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                    Image i = piece;
                    pb1.Image = i;

                    string newpicpath = path4x4 + "i" + x.ToString() + "x" + y.ToString() + ".png";
                    piece.Save(newpicpath, System.Drawing.Imaging.ImageFormat.Png);

                    pb2.Image = Image.FromFile(newpicpath);

                    this.Controls.Add(pb1);
                    this.Controls.Add(pb2);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbtype_SelectedIndexChanged(null, null);
        }
    }
}
