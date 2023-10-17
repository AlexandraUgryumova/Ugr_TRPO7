using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практическая_7
{
    class DataBase
    {
        private static DataBase dataBase;

        private ToursDataSetTableAdapters.ToursTableAdapter toursTable;

        private ToursDataSet toursData;

        private DataBase()
        {
            toursTable = new ToursDataSetTableAdapters.ToursTableAdapter();
            toursData = new ToursDataSet();
            toursTable.Fill(toursData.Tours);
        }
        public static DataBase DataBaseInstance
        {
            get
            {
                if(dataBase == null)
                {
                    dataBase = new DataBase();
                }
                return dataBase;
            }
        }
        public ToursDataSetTableAdapters.ToursTableAdapter ToursTableAdapter
        {
            get
            {
                return toursTable;
            }
        }
        public ToursDataSet ToursData
        {
            get
            {
                return toursData;
            }
        }
    }
}
