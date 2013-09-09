using System;
using System.Collections.ObjectModel;

namespace Backend.Objects
{
    public class DtcCodeObject
    {
        public string Manufacturer { get; set; } // Valmistaja
        public string Model { get; set; } // Malli
        public string Engine { get; set; }  // Moottori
        public string DTC { get; set; } // DTC
        public string Description { get; set; } // Kuvaus
        public int Year { get; set; } // Vuosimalli
        public DateTime AddedTime { get; set; }
        public ObservableCollection<Document> Documents { get; set; } // Documents
    }
}
