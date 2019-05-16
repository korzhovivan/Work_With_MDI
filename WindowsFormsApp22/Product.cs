using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp22
{
    [Serializable()]
    public class Product:ISerializable
    {
        
        public Product()
        {
        }

        public string Group { get; set; }
        public string Name { get; set; }
        public string Manufecturer { get; set; }
        public string Date { get; set; }
        public string Expiration { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Group", Group);
            info.AddValue("Name", Name);
            info.AddValue("Manufecturer", Manufecturer);
            info.AddValue("Date", Date);
            info.AddValue("Expiration", Expiration);
        }
        public Product(SerializationInfo info, StreamingContext context)
        {
            Group = (string)info.GetValue("Group", typeof(string));
            Name = (string)info.GetValue("Name", typeof(string));
            Manufecturer = (string)info.GetValue("Manufecturer", typeof(string));
            Date = (string)info.GetValue("Date", typeof(string));
            Expiration = (string)info.GetValue("Expiration", typeof(string));
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}