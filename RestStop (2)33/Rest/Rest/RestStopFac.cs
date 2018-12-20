using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest
{
    class RestStopFac
    {
        private string batchMenu;
        private string brand;
        private string convenience;
        private string direction;
        private string serviceAreaCode;
        private string serviceAreaName;
        private string telNo;
        private string truckSaYn; 

        public string BatchMenu
        {
            get { return batchMenu; }
            set { batchMenu = value; }
        }
        
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        
        public string Convenience
        {
            get { return convenience; }
            set { convenience = value; }
        }
        
        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        
        public string ServiceAreaCode
        {
            get { return serviceAreaCode; }
            set { serviceAreaCode = value; }
        }
        
        public string ServiceAreaName
        {
            get { return serviceAreaName; }
            set { serviceAreaName = value; }
        }
        
        public string TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
        
        public string TruckSaYn
        {
            get { return truckSaYn; }
            set { truckSaYn = value; }
        }

        public RestStopFac(string batchMenu, string brand, string convenience, string direction, string serviceAreaCode, string serviceAreaName, string telNo, string truckSaYn)
        {
            this.batchMenu = batchMenu;
            this.brand = brand;
            this.convenience = convenience;
            this.direction = direction;
            this.serviceAreaCode = serviceAreaCode;
            this.serviceAreaName = serviceAreaName;
            this.telNo = telNo;
            this.truckSaYn = truckSaYn;
        }
    }
}
