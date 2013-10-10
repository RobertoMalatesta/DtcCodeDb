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
using System.Collections.ObjectModel;

namespace Database
{
    public partial class Main : Form
    {
        // Fields
        DtcCodeRepository AutotRepository;
        string Model { get { return modelsListbox.SelectedItem.ToString(); }        }
        string Manufacturer { get { return manufacturersListBox.SelectedItem.ToString(); } }
        string Dtc { get { return dtcListbox.SelectedItem.ToString(); } }
        string Engine { get { return engineListbox.SelectedItem.ToString(); } }

        // Constructor
        public Main()
        {
            // Alustetaan noi kaikki visuaaliset komponentit
            InitializeComponent();

            // Alustetaan autot repository ja asetetaan handleri kokoelmalle
            // Cars_CollectionChanged pitää muuttaa jossai välissä
            AutotRepository = new DtcCodeRepository();
            AutotRepository.DtcCodes.CollectionChanged += Cars_CollectionChanged;
            
            // Asetetaan valmistajien listboxille data lähde
            manufacturersListBox.DataSource = AutotRepository.Manufacturers;

            /// Alla olevat poistetaan jossain vaiheessa
            autotListBox.DataSource = AutotRepository.DtcCodes;
            autotListBox.DisplayMember = "Manufacturer";
            autotGridView.DataSource = AutotRepository.DtcCodes;
        }

        

        private void lisääToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add secondForm = new Add(AutotRepository);
            secondForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Väliaikainen autotlistbox Delete toiminto
        private void autotListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                AutotRepository.DtcCodes.Remove(autotListBox.SelectedItem as DtcCodeObject);
        }

        #region ListBox Suodatus

        // manufacturersListBox
        private void manufacturersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Manufacturer != null)
            {
                modelsListbox.DataSource = null;
                modelsListbox.DataSource = AutotRepository.Models(Manufacturer);
            }
        }

        // modelsListBox
        private void modelsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelsListbox.SelectedItem != null)
            {
                engineListbox.DataSource = null;
                engineListbox.DataSource = AutotRepository.Engines(Model);
            }
        }

        //engineListBox
        private void engineListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (engineListbox.SelectedItem != null)
            {
                dtcListbox.DataSource = null;
                dtcListbox.DataSource = AutotRepository.DTC(Model, Engine);
            }
        }
        #endregion // ListBox Suodatus

        #region Event Handlerit

        void Cars_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            autotGridView.DataSource = null;
            autotGridView.DataSource = AutotRepository.DtcCodes;

            autotListBox.DataSource = null;
            autotListBox.DataSource = AutotRepository.DtcCodes;
            autotListBox.DisplayMember = "Manufacturer";
        }

        #endregion // Event Handlerit

        //Marko da codeing master of the universum. 
        // Feat. hC "R3l0aded" Hyttinen
        private void dtcListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtcListbox.SelectedItem != null)
            {
                // Vaihtoehto(helpompi) : 
                // textbox.Text = AutotRepository.description(Model, Engine, Dtc);

                // Pidemmässä juoksussa parempi koska tätä voidaan hyödyntää vielä enemmän myöhemmin :
                DtcCodeObject SelectedDtc = AutotRepository.SingleCodeObject(Model, Engine, Dtc);
                
                // Luodaan uusi UserControl tolla dtc avulla
                var usercontrol = new UserControl1(SelectedDtc);

                // Tyhjennetään paneeli ja lisätään uusi usercontrol paneeliin
                resultPanel.Controls.Clear();
                resultPanel.Controls.Add(usercontrol);           
            }
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void muokkaa_Click(object sender, EventArgs e)
        {

        }

        private void resultPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void muokkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custom secondForm = new custom();//Linkkaa tämäm custom ikkunaan
            secondForm.Show();
        }
    }
}
