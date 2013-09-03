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
        DtcCodeRepository AutotRepository;

        public Main()
        {
            InitializeComponent();
            AutotRepository = new DtcCodeRepository();

            autotGridView.DataSource = AutotRepository.DtcCodes;

            AutotRepository.DtcCodes.CollectionChanged += Cars_CollectionChanged;
            autotListBox.DataSource = AutotRepository.DtcCodes;

            manufacturersListBox.DataSource = AutotRepository.Manufacturers;
        }

        void Cars_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            autotGridView.DataSource = null;
            autotGridView.DataSource = AutotRepository.DtcCodes;

            autotListBox.DataSource = null;
            autotListBox.DataSource = AutotRepository.DtcCodes;

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

        private void autotListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                AutotRepository.DtcCodes.Remove(autotListBox.SelectedItem as DtcCodeObject);
        }

        private void manufacturersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manufacturersListBox.SelectedItem != null)
            {
                string Manufacturer = manufacturersListBox.SelectedItem.ToString();
                var uusilista = AutotRepository.DtcCodes.Where(c => c.Manufacturer == Manufacturer);
                var suodatettulista = new ObservableCollection<DtcCodeObject>(uusilista);

                ObservableCollection<string> models = new ObservableCollection<string>();
                foreach (DtcCodeObject dtc in suodatettulista)
                {
                }

                modelsListbox.DataSource = null;
                modelsListbox.DataSource = suodatettulista;
                modelsListbox.DisplayMember = "Model";
            }
        }

        private void modelsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelsListbox.SelectedItem != null)
            {
                var dtc = modelsListbox.SelectedItem as DtcCodeObject;
                var uusilista = AutotRepository.DtcCodes.Where(c => c.Model == dtc.Model && c.Manufacturer == dtc.Manufacturer);
                var suodatettulista = new ObservableCollection<DtcCodeObject>(uusilista);

                engineListbox.DataSource = null;
                engineListbox.DataSource = suodatettulista;
                engineListbox.DisplayMember = "Engine";
            }
        }

        private void engineListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (engineListbox.SelectedItem != null)
            {
                var dtc = engineListbox.SelectedItem as DtcCodeObject;
                var uusilista = AutotRepository.DtcCodes.Where(c => c.Engine == dtc.Engine && c.Model == dtc.Model);
                var suodatettulista = new ObservableCollection<DtcCodeObject>(uusilista);

                dtcListbox.DataSource = null;
                dtcListbox.DataSource = suodatettulista;
                dtcListbox.DisplayMember = "DTC";
            }
        }
    }
}
