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
        /// Serialisoi DtcCodeObject kokoelman XML tiedostoon
        /// </summary>
        /// <param name="DtcCodes">DtcCodeObject kokoelma mikä halutaan tallentaa</param>
        /// <returns></returns>
        static public bool SerializeDtcCodes(ObservableCollection<DtcCodeObject> DtcCodes)
        {
            var xmlSerializer = new XmlSerializer(typeof(ObservableCollection<DtcCodeObject>));
            if (WriteXmlFile("dtccodes.xml", xmlSerializer, DtcCodes))
                return true;

            return false;
        }

        /// <summary>
        /// Ladataan DtcCodeObject kokoelma XML tiedostosta
        /// </summary>
        /// <returns>Palauttaa DtcCodeObject kokoelman</returns>
        static public ObservableCollection<DtcCodeObject> DeserializeDtcCodes()
        {
            var deSerializer = new XmlSerializer(typeof(ObservableCollection<DtcCodeObject>));
            ObservableCollection<DtcCodeObject> Projects = new ObservableCollection<DtcCodeObject>();

            if (File.Exists("dtccodes.xml"))
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
        /// Tarkistetaan onko tiedostoa olemassa. Jos ei niin generoidaan uusi
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        static bool FileCheck(string file)
        {
            if (!File.Exists(file))
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

        static bool WriteXmlFile(string file, XmlSerializer xmlSerializer, object obj)
        {
            if (FileCheck(file))
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

            return false;
            
        }

        static bool GenerateNewDtcCodes()
        {
            ObservableCollection<DtcCodeObject> DtcCodes = new ObservableCollection<DtcCodeObject>();
            SerializeDtcCodes(DtcCodes);
            return true;
        }

        #endregion // Private Helpers
    }
}
