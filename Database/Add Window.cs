using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Repositories;
using Backend.Objects;

namespace Database
{
    public partial class Add : Form
    {
        DtcCodeRepository DtcRepository;

        public Add(DtcCodeRepository dtctrepository)
        {
            InitializeComponent();
            DtcRepository = dtctrepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tallenna nappi
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton.Focus();
            DtcCodeObject uusiauto = new DtcCodeObject 
            { 
                Model = ModelTextBox.Text, 
                Engine = EngineTextBox.Text, 
                DTC = DtcTextBox.Text, 
                Manufacturer = ManufacturerTextBox.Text,
                Description = DescriptionTextBox.Text,
                AddedTime = DateTime.Now
            };

            DtcRepository.DtcCodes.Add(uusiauto);
            DtcRepository.Save();
            this.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Importbutton_Click(object sender, EventArgs e)// Tästä alas omaa settiä
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Tallenna kuva tiedosto";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
              if(saveFileDialog1.FileName != "")
            {
              // Saves the Image via a FileStream created by the OpenFile method.
              System.IO.FileStream fs = 
                 (System.IO.FileStream)saveFileDialog1.OpenFile();
              // Saves the Image in the appropriate ImageFormat based upon the
              // File type selected in the dialog box.
              // NOTE that the FilterIndex property is one-based.
              switch(saveFileDialog1.FilterIndex)
                      {
                         case 1 : 
                         this.Importbutton.Image.Save(fs, 
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                         break;

                         case 2 : 
                         this.Importbutton.Image.Save(fs, 
                            System.Drawing.Imaging.ImageFormat.Bmp);
                         break;

                         case 3 : 
                         this.Importbutton.Image.Save(fs, 
                            System.Drawing.Imaging.ImageFormat.Gif);
                         break;
                     }

           fs.Close();
            }
        }

        }
    }

