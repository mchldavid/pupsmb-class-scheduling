using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ClassSchedulingComputerAided
{
    public class SaveXML
    {
        public static void SaveData(object obj, string filename)
        {
            XmlSerializer xml = new XmlSerializer(obj.GetType());
            TextWriter wr = new StreamWriter(filename);
            xml.Serialize(wr, obj);
            wr.Close();
        }
    }
}
