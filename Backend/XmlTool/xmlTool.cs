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

        static public bool SerializeDtcCodes(ObservableCollection<DtcCodeObject> DtcCodes)
        {
            var xmlSerializer = new XmlSerializer(typeof(ObservableCollection<DtcCodeObject>));
            if (WriteXmlFile("dtccodes.xml", xmlSerializer, DtcCodes))
                return true;

            return false;
        }

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

        static bool FileCheck(string file)
        {
            if (!File.Exists(file))
                try
                {
                    File.Create(file);
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
