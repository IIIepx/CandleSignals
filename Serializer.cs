using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace WinFormsSerialization
{
    public static class Serializer
    {
        #region Сериализация и десериализация по одному экземпляру

        public static void SaveToBinnary<T>(String FileName, T SerializableObject)
        {
            using (FileStream fs = File.Create(FileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, SerializableObject);
            }
        }

        public static T LoadFromBinnary<T>(String FileName)
        {
            using (FileStream fs = File.Open(FileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(fs);
            }
        }

        //====================================================================

        public static void SaveToXml<T>(String FileName, T SerializableObject)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter textWriter = new StreamWriter(FileName))
            {
                serializer.Serialize(textWriter, SerializableObject);
            }
        }

        public static T LoadFromXml<T>(String FileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader textReader = new StreamReader(FileName))
            {
                return (T)serializer.Deserialize(textReader);
            }
        } 
        #endregion

        #region Сериализация и десериализация списка объектов

        public static void SaveListToBinnary<T>(String FileName, List<T> SerializableObjects)
        {
            using (FileStream fs = File.Create(FileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, SerializableObjects);
            }
        }

        public static List<T> LoadListFromBinnary<T>(String FileName)
        {
            using (FileStream fs = File.Open(FileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<T>)formatter.Deserialize(fs);
            }
        }

        //====================================================================

        public static void SaveListToXml<T>(String FileName, List<T> SerializableObjects)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter textWriter = new StreamWriter(FileName))
            {
                serializer.Serialize(textWriter, SerializableObjects);
            }
        }

        public static List<T> LoadListFromXml<T>(String FileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader textReader = new StreamReader(FileName))
            {
                return (List<T>)serializer.Deserialize(textReader);
            }
        }  
        #endregion
    }
}
