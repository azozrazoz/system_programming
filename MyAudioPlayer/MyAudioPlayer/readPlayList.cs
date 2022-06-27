using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyAudioPlayer
{
    class readPlayList
    {
        private ArrayList name = new ArrayList();
        private string m_xmlFile;

        public string PlayListPath
        {
            get
            {
                return m_xmlFile;
            }
            set
            {
                m_xmlFile = value;
                MakePlaylist();
            }
        }

        public ArrayList PlayList
        {
            get
            {
                return name;
            }
        }
        private void MakePlaylist()
        {
            XmlTextReader readList = new XmlTextReader(m_xmlFile);
            while (readList.Read())
            {
                if (readList.NodeType == XmlNodeType.Element)
                {
                    if (readList.LocalName.Equals("media"))
                    {
                        name.Add(readList.GetAttribute(0).ToString());
                    }
                }
            }
        }
    }
}
