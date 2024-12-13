using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseReader
{
    public class DBReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;


        public int? GetIntFromDatabase()
        {
            return numericValue; 
        }
        public bool? GetBooleanFromDatabase()
        {
            return boolValue;
        }

    }
}
