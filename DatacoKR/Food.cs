using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmRestStop
{
    class Food
    {
        private string stdRestCd;

        public string StdRestCd
        {
            get { return stdRestCd; }
            set { stdRestCd = value; }
        }

        private string stdRestNm;

        public string StdRestNm
        {
            get { return stdRestNm; }
            set { stdRestNm = value; }
        }

        private string restCd;

        public string RestCd
        {
            get { return restCd; }
            set { restCd = value; }
        }

        private int seq;

        public int Seq
        {
            get { return seq; }
            set { seq = value; }
        }

        private string foodNm;

        public string FoodNm
        {
            get { return foodNm; }
            set { foodNm = value; }
        }

        private int foodCost;

        public int FoodCost
        {
            get { return foodCost; }
            set { foodCost = value; }
        }

        private string seasonMenu;

        public string SeasonMenu
        {
            get { return seasonMenu; }
            set { seasonMenu = value; }
        }

        private string etc;

        public string Etc
        {
            get { return etc; }
            set { etc = value; }
        }

        private DateTime lsttmAltrDttm;

        public DateTime LsttmAltrDttm
        {
            get { return lsttmAltrDttm; }
            set { lsttmAltrDttm = value; }
        }

    }
}
