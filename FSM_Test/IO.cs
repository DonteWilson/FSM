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
            using (FileStream fs = File.Create(path + s + ".xml"))
            {
                XmlSerializer Serial = new XmlSerializer(typeof(T));
                Serial.Serialize(fs, t);

                fs.Close();
            }
        }
        //Deserializes data from path
        public T DeserializeGameData<T>(string s)
        {
            XmlSerializer Deserial = new XmlSerializer(typeof(T));

            T t;

            using (FileStream fs = File.OpenRead(s))
            {
                
                t = (T)Deserial.Deserialize(fs);
                fs.Close();
            }

            return t;
        }
    }



        
}

