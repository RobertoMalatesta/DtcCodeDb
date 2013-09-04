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
<<<<<<< HEAD
            var uusilista = AutotRepository.DtcCodes.Where(c => c.Model == modelsListbox.SelectedItem.ToString());
            var suodatettulista = new ObservableCollection<DtcCodeObject>(uusilista);

            engineListbox.DataSource = null;
            engineListbox.DataSource = suodatettulista;
            engineListbox.DisplayMember = "Engine";
=======
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
>>>>>>> origin/Kleptomaani
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
    }
}
