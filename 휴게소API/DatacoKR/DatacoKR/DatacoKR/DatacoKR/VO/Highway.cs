using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatacoKR
{
    class Highway
    {
        private string unitName;    // 휴게소 이름
        private string unitCode;    // 휴게소 코드
        private string routeNo;     // 노선 코드
        private string routeName;   // 노선명
        private string xValue;
        private string yValue;

        public Highway()
        {
            
        }

        public string UnitName { get => unitName; set => unitName = value; }
        public string UnitCode { get => unitCode; set => unitCode = value; }
        public string RouteNo { get => routeNo; set => routeNo = value; }
        public string RouteName { get => routeName; set => routeName = value; }
        public string XValue { get => xValue; set => xValue = value; }
        public string YValue { get => yValue; set => yValue = value; }
    }
}
