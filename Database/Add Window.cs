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
    }
}
