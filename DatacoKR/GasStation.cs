using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatacoKR
{
    class GasStation
    {
        private string highwayName;

        public string HighwayName
        {
            get { return highwayName; }
            set { highwayName = value; }
        }
        private string restStopName;

        public string RestStopName
        {
            get { return restStopName; }
            set { restStopName = value; }
        }
        private string lpgPrice;

        public string LpgPrice
        {
            get { return lpgPrice; }
            set { lpgPrice = value; }
        }
        private string gasolinePrice;

        public string GasolinePrice
        {
            get { return gasolinePrice; }
            set { gasolinePrice = value; }
        }
        private string dieselPrice;

        public string DieselPrice
        {
            get { return dieselPrice; }
            set { dieselPrice = value; }
        }

        public GasStation(string highwayName, string restStopName, string lpgPrice, string gasolinePrice, string dieselPrice)
        {
            this.highwayName = highwayName;
            this.restStopName = restStopName;
            this.lpgPrice = lpgPrice;
            this.gasolinePrice = gasolinePrice;
            this.dieselPrice = dieselPrice;
        }
    }
}
