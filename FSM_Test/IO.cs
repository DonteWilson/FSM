using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace FSM_Test
{
    class IO
    {
        public void Serialize<T>(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\SavedData\" + s + ".xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(fs, t);

                fs.Close();
            }
        }
        public T Deserialize<T>(string s)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));

            T item;

            using (FileStream fs = File.OpenRead(s))
            {
                item = (T)deserializer.Deserialize(fs);
                fs.Close();
            }
            return item;
        }
    }
}
