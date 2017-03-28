using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBot
{
    class Store
    {
        public string storeName;
        public string storeNumber;
        public Phone[] phoneList;

        public Store()
        {
            phoneList = new Phone[18];
        }
    }
}
