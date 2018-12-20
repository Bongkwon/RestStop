using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestStop
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
    }
}
