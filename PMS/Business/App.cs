using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Business
{
    class App
    {
        private static string connectionString;
        
        public static string ConnectionString 
        { 
            get
            {
                return connectionString;
            }
            
            set
            {
                connectionString = value;
            }
        }
    }
}
