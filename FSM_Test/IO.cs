using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace FSM_Test
{
    //Save Test
    class IO
    {
        public void SerializeGameData<T>(string s, T t, string path)
        {
            if (Directory.Exists(path))
            {
                using (FileStream fs = File.Create(path + @"..\PartySave\" + s + ".xml"))
                {
                    XmlSerializer Serial = new XmlSerializer(typeof(T));
                    Serial.Serialize(fs, t);

                    fs.Close();
                }
            }
        }

        public T DeserializeGameData<T>(string s)
        {
            T t;

            using (FileStream fs = File.OpenRead(s + ".xml"))
            {
                XmlSerializer Deserial = new XmlSerializer(typeof(T));
                t = (T)Deserial.Deserialize(fs);
                fs.Close();
            }

            return t;
        }
    }



        
}

