using System;
using System.Collections.ObjectModel;
using Backend.Objects;
using Backend.XmlTools;

namespace Backend.Repositories
{
    /// <summary>
    /// DtcCodeRepository toimii varastona DtcCodeille
    /// Tämä luokka hoitaa DtcCodejen lataaamisen ja suodattamisen
    /// </summary>
    public class DtcCodeRepository
    {
        public ObservableCollection<DtcCodeObject> DtcCodes;
        public ObservableCollection<string> Manufacturers;


        // Constructor
        public DtcCodeRepository()
        {
            // Ladataan autot
            DtcCodes = Load();
            // Lisätään EventHandler
            DtcCodes.CollectionChanged += Cars_CollectionChanged;

            ManufacturerParser();
        }

        #region Cars collection funktiot

        // Handleri Cars kokoelman muutokselle. Tallennus kun kokoelma muuttuu
        void Cars_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            XmlTool.SerializeDtcCodes(DtcCodes);
        }

        // Tallennus funktio
        public void Save()
        {
            // Tallennetaan tiedot XML tiedostoon
            XmlTool.SerializeDtcCodes(DtcCodes);

            // Suoritetaan parserointi uudelleen
            ManufacturerParser();
        }

        // Ladataan kokoelma XML tiedostosta
        ObservableCollection<DtcCodeObject> Load()
        {
            // Tähän lataus funktio
            ObservableCollection<DtcCodeObject> autot = XmlTool.DeserializeDtcCodes();
            if (autot == null)
                autot = new ObservableCollection<DtcCodeObject>();
            return autot;
        }

        #endregion // Autot collection funktiot

        // Parserointi käy läpi valmistajat ja luo listan eri valmistajista
        void ManufacturerParser()
        {
            Manufacturers = new ObservableCollection<string>();

            // Käydään jokainen auto läpi kokoelmassa
            foreach (DtcCodeObject Car in DtcCodes)
            {
                if (!Manufacturers.Contains(Car.Manufacturer)) //Jos valmistaja kokoelma ei sisällä kyseistä mallia lisätään se "Manufacturers" kokoelmaan
                    Manufacturers.Add(Car.Manufacturer);
            }
        }

        /// <summary>
        /// Palautetaan kokoelma malleista autovalmistajan mukaan
        /// </summary>
        /// <param name="manufacturer">Valmistajan nimi</param>
        /// <returns></returns>
        public ObservableCollection<string> Models(string manufacturer)
        {
            ObservableCollection<string> List = new ObservableCollection<string>();

            foreach (DtcCodeObject Dtc in DtcCodes)
                if (!List.Contains(Dtc.Model) && Dtc.Manufacturer == manufacturer)
                    List.Add(Dtc.Model);
            
            return List;
        }

        /// <summary>
        /// Palautetaan kokoelma moottoreista mallin mukaan
        /// </summary>
        /// <param name="model">Malli</param>
        /// <returns></returns>
        public ObservableCollection<string> Engines(string model)
        {
            ObservableCollection<string> List = new ObservableCollection<string>();

            foreach (DtcCodeObject Dtc in DtcCodes)
                    if (!List.Contains(Dtc.Engine) && Dtc.Model == model)
                        List.Add(Dtc.Engine);

            return List;
        }

        /// <summary>
        /// Palautetaan kokoelma DTC:stä mallin ja moottorin perusteella
        /// </summary>
        /// <param name="model">Malli</param>
        /// <param name="engine">Moottori</param>
        /// <returns></returns>
        public ObservableCollection<string> DTC(string model, string engine)
        {
            ObservableCollection<string> List = new ObservableCollection<string>();

            foreach (DtcCodeObject Dtc in DtcCodes)
                if (!List.Contains(Dtc.DTC) && Dtc.Model == model && Dtc.Engine == engine)
                    List.Add(Dtc.DTC);

            return List;
        }
    }
}
