using System;
using DevExpress.Xpo;

namespace T120425 {

    [Persistent("Categories")]
    public class Category : XPLiteObject {
        public Category()
            : base() {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Category(Session session)
            : base(session) {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction() {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        [Key(true)]
        public int CategoryID {
            get;
            set;
        }

        public string CategoryName {
            get;
            set;
        }

        public string Description {
            get;
            set;
        }

        public byte[] Picture {
            get;
            set;
        }
    }

}