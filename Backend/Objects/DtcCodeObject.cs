using System;
using System.Collections.ObjectModel;

namespace Backend.Objects
{
    /// <summary>
    /// DtcCodeObject on se objekti mikä sisältää kaikki DTC tiedot
    /// </summary>
    public class DtcCodeObject
    {
        /// <summary>
        /// Valmistaja
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Malli
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Moottori
        /// </summary>
        public string Engine { get; set; }
        
        /// <summary>
        /// DTC
        /// </summary>
        public string DTC { get; set; }
        
        /// <summary>
        /// Kuvaus
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        ///  Vuosimalli
        /// </summary>
        public int Year { get; set; }
  
        /// <summary>
        /// Documentit / Tiedostot. JPG, PDF, DOCX.
        /// </summary>
        ObservableCollection<Document> Documents { get; set; }

    }
}
