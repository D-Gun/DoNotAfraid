using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_1_csvToText
{
    class Dic
    {
        public static string ConnectionString {
            get 
            {
                return ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
            }
        }

        public static string FilePath {
            get 
            {
                return ConfigurationManager.AppSettings["FilePath"];
            }            
        }
    }
}
