using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace WpfApp_SmartCookbook
{
    public class MyStorage
    {
        internal static void WriteXml<T>(T data, string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                FileStream stream;
                stream = new FileStream(fileName, FileMode.Create);
                serializer.Serialize(stream, data);
                stream.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
                throw;
            }
        }

        internal static T ReadXml<T>(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x, "Caution...");
                return default(T);
            }
        }
    }
}
