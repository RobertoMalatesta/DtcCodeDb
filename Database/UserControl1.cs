using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Objects;

namespace Database
{
    public partial class UserControl1 : UserControl
    {
        public DtcCodeObject DtcCode;
        public UserControl1(DtcCodeObject dtccode)
        {
            DtcCode = dtccode;
            InitializeComponent();

            if (DtcCode != null)
            {
                descriptionTextbox.DataBindings.Add("text", DtcCode, "Description");
                // Tähän voi lisätä databindingeja jos haluaa tulos kenttään muutakin tietoa
            }

        }

    }
}
