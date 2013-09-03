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
            var uusilista = AutotRepository.DtcCodes.Where(c => c.Manufacturer == manufacturersListBox.SelectedItem.ToString());
            var tes = new ObservableCollection<DtcCodeObject>(uusilista);

            modelsListbox.DataSource = null;
            modelsListbox.DataSource = tes;
            modelsListbox.DisplayMember = "Model";
        }

        private void modelsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var uusilista = AutotRepository.DtcCodes.Where(c => c.Model == modelsListbox.SelectedItem.ToString());
            var suodatettulista = new ObservableCollection<DtcCodeObject>(uusilista);

            modelsListbox.DataSource = null;
            modelsListbox.DataSource = suodatettulista;
            modelsListbox.DisplayMember = "Model";
        }
    }
}
