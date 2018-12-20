using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest
{
    class SearchResultByRestName
    {
        private string serviceAreaName;
        private string batchMenu;
        private string brand;
        private string convenience;
        private string telNo;
        private string truckSaYn;

        public string TruckSaYn
        {
            get { return truckSaYn; }
            set { truckSaYn = value; }
        }

        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }

        public string Convenience
        {
            get { return convenience; }
            set { convenience = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string BatchMenu
        {
            get { return batchMenu; }
            set { batchMenu = value; }
        }

        public string ServiceAreaName
        {
            get { return serviceAreaName; }
            set { serviceAreaName = value; }
        }

        public SearchResultByRestName(string serviceAreaName, string batchMenu, string brand, string convenience, string telNo, string truckSaYn)
        {
            this.serviceAreaName = serviceAreaName;
            this.batchMenu = batchMenu;
            this.brand = brand;
            this.convenience = convenience;
            this.telNo = telNo;
            this.truckSaYn = truckSaYn;
        }
    }
}
