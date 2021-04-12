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

namespace RandomImageApp
{
    public partial class Form1 : Form
    {
        List<Bitmap> picturesList = new List<Bitmap>();
        Random random = new Random();
        private string filename;

        public Form1()
        {
            InitializeComponent();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            try
            {


                if (picBox2.Image != null)
                {
                    Image flipImage = picBox2.Image;
                    flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    picBox2.Image = flipImage;
                }
                else
                {
                    MessageBox.Show("No Image");
                }
            }
            catch
            {
                MessageBox.Show("Error is Foud");
            }
        }

        private void picChangeTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] paths = Directory.GetFiles(@"E:\dont delete windows10\windows 10\Desktop\Images", "*.jpg");
                List<string> images = paths.ToList();
                Random random = new Random();
                picBox2.ImageLocation = paths[random.Next(0, images.Count - 1)];
            }
            catch
            {
                MessageBox.Show("Error is Foud");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelDelete.Visible = false;



        }

        private void btnAddtoFolder_Click(object sender, EventArgs e)
        {
           
            panelAdd.Visible = true;
            panelAdd.Location = new Point(258, 12); ; 

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
        
            string imagelocation = "";

            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = dialog.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            File.Copy(txtPath.Text, Path.Combine(@"E:\dont delete windows10\windows 10\Desktop\Images",Path.GetFileName(txtPath.Text)),true);
            MessageBox.Show("Image Successfully Added");
            txtPath.Text = "";          
            panelAdd.Visible = false;
        }

        private void btnRemoveImgFromFolder_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            panelDelete.Location = new Point(258, 12);
        }

        private void btnDeleteBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDeletePath.Text = dialog.FileName;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
                var filePath = txtDeletePath.Text;
                if (File.Exists(filePath))
                {
                    DialogResult dialog = MessageBox.Show("Do you Want to Delete ", "Exit", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        File.Delete(filePath);
                    }
                    else if (dialog == DialogResult.No)
                    {

                    }
                    txtDeletePath.Text = "";
                    panelDelete.Visible = false;
                }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
        }

        private void btnCloseAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
        }
    }
}
