using System;
using System.Collections.ObjectModel;
using Backend.Objects;
using Backend.XmlTools;

namespace Backend.Repositories
{
    public class DtcCodeRepository
    {
        public ObservableCollection<DtcCodeObject> DtcCodes;
        
        public ObservableCollection<string> Models;
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
            Models = new ObservableCollection<string>();
            Manufacturers = new ObservableCollection<string>();

            // Käydään jokainen auto läpi kokoelmassa
            foreach (DtcCodeObject Car in DtcCodes)
            {
                if (!Manufacturers.Contains(Car.Manufacturer)) //Jos valmistaja kokoelma ei sisällä kyseistä mallia lisätään se "Manufacturers" kokoelmaan
                    Manufacturers.Add(Car.Manufacturer);
            }
        }
    }
}
