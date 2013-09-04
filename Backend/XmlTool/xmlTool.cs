using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.IO;
using System;
using Backend.Objects;
using Backend.Repositories;

namespace Backend.XmlTools
{
    public class XmlTool
    {
        #region Public

        /// <summary>
        /// Tallennetaan DtcCodeObjects kokoelma XML tiedostoon
        /// </summary>
        /// <param name="DtcCodes">DtcCodeObject kokoelma</param>
        /// <returns>Palauttaa TRUE arvon jos tallennus onnistuu</returns>
        static public bool SerializeDtcCodes(ObservableCollection<DtcCodeObject> DtcCodes)
        {

                try
                {
                    var xmlSerializer = new XmlSerializer(typeof(ObservableCollection<DtcCodeObject>));
                    if (WriteXmlFile("dtccodes.xml", xmlSerializer, DtcCodes))
                        return true;
                }
                catch (Exception Ex)
                {
                    throw new ArgumentException("Error in serialization");
                }

            return false;
        }

        /// <summary>
        /// Luetaan DtcCodeObject kokoelma XML tiedostosta
        /// </summary>
        /// <returns>DtcCodeObject kokoelma</returns>
        static public ObservableCollection<DtcCodeObject> DeserializeDtcCodes()
        {
            var deSerializer = new XmlSerializer(typeof(ObservableCollection<DtcCodeObject>));
            ObservableCollection<DtcCodeObject> Projects = new ObservableCollection<DtcCodeObject>();

            if (FileCheck("dtccodes.xml"))
            {
                try
                {
                    using (TextReader textReader = new StreamReader("dtccodes.xml"))
                    {
                        Projects = (ObservableCollection<DtcCodeObject>)deSerializer.Deserialize(textReader);
                    }
                }
                catch (Exception Ex)
                {
                    GenerateNewDtcCodes();
                    throw new ArgumentException("Error while reading XML file! \n" + Ex);
                }
                finally
                {
                }
            }

            return Projects;
        }

        #endregion // Public

        #region Private Helpers

        /// <summary>
        /// Tarkistetaan onko XML tiedosto olemassa ja generoidaan DtcCodeObject kokoelma tiedosto
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        static bool FileCheck(string file)
        {
            if (!File.Exists(file)) // Auton lisäys aiheuttaa häriöö ja vika ilmeisesti tässä?
                try
                {
                    GenerateNewDtcCodes();
                }
                catch (Exception Ex)
                {
                    return false;
                }

            return true;
        }

        /// <summary>
        /// Xml Tiedostoon kirjoitus
        /// </summary>
        /// <param name="file"></param>
        /// <param name="xmlSerializer"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        static bool WriteXmlFile(string file, XmlSerializer xmlSerializer, object obj)
        {
                try
                {
                    using (TextWriter textWriter = new StreamWriter(file))
                    {
                        xmlSerializer.Serialize(textWriter, obj);
                        textWriter.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error while writing XML file!" + ex);
                }

                return true;
            
        }

        /// <summary>
        /// Generoidaan uusi DtcCodeObject kokoelma ja tallennetaan se tiedostoon. 
        /// </summary>
        /// <returns>Palauttaa TRUE jos onnistuu</returns>
        static bool GenerateNewDtcCodes()
        {
            ObservableCollection<DtcCodeObject> DtcCodes = new ObservableCollection<DtcCodeObject>();
            SerializeDtcCodes(DtcCodes);
            return true;
        }

        #endregion // Private Helpers
    }
}
