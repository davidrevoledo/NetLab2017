using System.Collections.Generic;
using DI.Data.Entities;

namespace DI
{
    public class DataBase
    {
        private static DataBase dataBase;

        private DataBase()
        {
            
        }

        public static DataBase Instance
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new DataBase();
                }

                return dataBase;
            }
        }

        public List<Client> Clients => new List<Client>
        {
            new Client(),
            new Client()
        };
    }
}