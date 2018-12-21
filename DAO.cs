using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmRestStop
{
    class DAO
    {
        private static DAO instance = null;
        private DBConnection con;
        private DAO()
        {
        }
        public static DAO GetInstance()
        {
            if (instance == null)
            {
                instance = new DAO();
                instance.con = new DBConnection();
            }
            return instance;
        }
        public bool SaveFood(Food food)
        {
            string sp = "InsertRestfood";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("stdRestCd", food.StdRestCd);
            sqlParameters[1] = new SqlParameter("StdRestNm", food.StdRestNm);
            sqlParameters[2] = new SqlParameter("RestCd", food.RestCd);
            sqlParameters[2] = new SqlParameter("Seq", food.Seq);
            sqlParameters[2] = new SqlParameter("FoodNm", food.FoodNm);
            sqlParameters[2] = new SqlParameter("FoodCost", food.FoodCost);
            sqlParameters[2] = new SqlParameter("SeasonMenu", food.SeasonMenu);
            sqlParameters[2] = new SqlParameter("Etc", food.Etc);
            sqlParameters[2] = new SqlParameter("LsttmAltrDttm", food.LsttmAltrDttm);

            bool result = false;
            if (con.ExcuteInsert(sp, sqlParameters))
            {
                result = true;
            }
            return result;
        }

    }
}
