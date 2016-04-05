using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace FSM_Test
{
    //Public Class that contains serialze and deserialize
    class IO
    {
        //Used to serialize data and can pass any args of any time.
        public void Serialize<T>(string s, T t)
        {
            //creates a folder thast will contain all saved data
            using (FileStream fs = File.Create(@"..\SavedData\" + s + ".xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                //calls the serialization function.
                serializer.Serialize(fs, t);
                //closes the fstream
                fs.Close();
            }
        }
        //deserializes data and pass Type
        public T Deserialize<T>(string s)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            //A type variable that stores data
            T item;

            using (FileStream fs = File.OpenRead(s))
            {
                //calls the deserialize function item.
                item = (T)deserializer.Deserialize(fs);
                //closes the fstream
                fs.Close();
            }
            return item;
        }
    }
}
