using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBot
{
    public class StoreAvailability
    {
        public static string strAvailabilityJson = "[" + @"{
  'R536' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R438' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R424' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : true,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : true,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : true,
    'MG4E2ZD/A' : true
  },
  'R315' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R425' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : false,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R469' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R367' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : true,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : true,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : true,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : true,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : true,
    'MG4E2ZD/A' : true
  },
  'R477' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : false,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R522' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : true,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : true,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : true,
    'MG4H2ZD/A' : true,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : true,
    'MG4E2ZD/A' : true
  },
  'R178' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R277' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : true,
    'MG4E2ZD/A' : false
  },
  'R374' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : true,
    'MG4E2ZD/A' : false
  },
  'R276' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : false,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R394' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : false,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R395' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R373' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : false,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : false,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : false,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : false,
    'MG4E2ZD/A' : false
  },
  'R470' : {
    'MG4J2ZD/A' : false,
    'MG472ZD/A' : true,
    'MGAJ2ZD/A' : false,
    'MG4A2ZD/A' : true,
    'MGAA2ZD/A' : false,
    'MGAH2ZD/A' : false,
    'MG4F2ZD/A' : false,
    'MGAK2ZD/A' : false,
    'MG4C2ZD/A' : true,
    'MGA82ZD/A' : false,
    'MGAC2ZD/A' : false,
    'MGA92ZD/A' : false,
    'MGAF2ZD/A' : false,
    'MG492ZD/A' : false,
    'MG4H2ZD/A' : false,
    'MGAE2ZD/A' : false,
    'MG482ZD/A' : true,
    'MG4E2ZD/A' : true
  },
  'updated' : 1411379280464
}" + "]";
        public static string strStoreJson = "[" + @"{
  'updatedTime' : '11h48',
  'stores' : [ {
    'storeNumber' : 'R477',
    'storeName' : 'Aix-en-Provence',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R470',
    'storeName' : 'Atlantis',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R395',
    'storeName' : 'CAP 3000',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R276',
    'storeName' : 'Carrousel du Louvre',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R438',
    'storeName' : 'CarrÃ© SÃ©nart',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R469',
    'storeName' : 'Confluence',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R522',
    'storeName' : 'La Toison dâ€™Or',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R178',
    'storeName' : 'Les Quatre Temps',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R367',
    'storeName' : 'Odysseum',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R277',
    'storeName' : 'OpÃ©ra',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R374',
    'storeName' : 'Parly 2',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R373',
    'storeName' : 'Part-Dieu',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R536',
    'storeName' : 'Rosny 2',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R424',
    'storeName' : 'Sainte-Catherine',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R394',
    'storeName' : 'Strasbourg',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R425',
    'storeName' : 'Val dâ€™Europe',
    'storeEnabled' : true
  }, {
    'storeNumber' : 'R315',
    'storeName' : 'VÃ©lizy 2',
    'storeEnabled' : true
  } ],
  'timezone' : 'CEST',
  'updatedDate' : 'lundi 22 septembre',
  'reservationURL' : 'https://reserve-fr.apple.com/FR/fr_FR/reserve/iPhone'
}" + "]";
    }
}
