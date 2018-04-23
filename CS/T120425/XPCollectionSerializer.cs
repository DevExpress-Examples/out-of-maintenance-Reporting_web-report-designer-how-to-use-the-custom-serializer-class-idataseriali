using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Xpo;
using System.Xml.Serialization;
using System.IO;

namespace T120425 {
    public class XPCollectionSerializer : DevExpress.XtraReports.Native.IDataSerializer {
        public const string NAME = "XPCollectionSerializer";

        public bool CanSerialize(object data, object extensionProvider) {
            XPCollection xpCollection = data as XPCollection;
            return xpCollection != null && xpCollection.ObjectType != null;
        }

        public string Serialize(object data, object extensionProvider) {
            XmlSerializer serializer = new XmlSerializer(typeof(XPCollectionInfo));

            XPCollection xpCollection = (XPCollection) data;
            XPCollectionInfo collectionInfo = new XPCollectionInfo(xpCollection);
            
            using (StringWriter serializationWriter = new StringWriter()) {
                serializer.Serialize(serializationWriter, collectionInfo);
                return serializationWriter.ToString();
            }
        }

        public bool CanDeserialize(string value, string typeName, object extensionProvider) {
            return typeName == typeof(XPCollection).ToString();            
        }

        public object Deserialize(string value, string typeName, object extensionProvider) {
            XmlSerializer serializer = new XmlSerializer(typeof(XPCollectionInfo));
            using (StringReader deserializationReader = new StringReader(value)) {
                XPCollectionInfo collectionInfo = (XPCollectionInfo)serializer.Deserialize(deserializationReader);
                return collectionInfo.CreateXPCollection();
            }
        }

        [Serializable]
        public class XPCollectionInfo {
            public string ObjectTypeName { get; set; }
            public string ConnectionString { get; set; }
            public string DisplayableProperties { get; set; }

            public XPCollectionInfo() {
            }

            public XPCollectionInfo(XPCollection xpCollection) {
                this.ConnectionString = "XpoProvider=MSSqlServer;" + xpCollection.Session.ConnectionString;
                this.ObjectTypeName = xpCollection.ObjectType.AssemblyQualifiedName;
                this.DisplayableProperties = xpCollection.DisplayableProperties;
            }

            public XPCollection CreateXPCollection() {
                Session session = new Session();
                session.ConnectionString = this.ConnectionString;

                Type type = Type.GetType(this.ObjectTypeName, false);
                return new XPCollection(session, type) {
                    DisplayableProperties = this.DisplayableProperties
                };
            }
        }
    }    
}