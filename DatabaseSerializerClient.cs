using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    internal class DatabaseSerializerClient
    {
        private IDatabaseOperations dbOperations;

        public DatabaseSerializerClient(IDatabaseOperations dbOperations)
        {
            this.dbOperations = dbOperations;
        }

        public void SerializeDatabaseToFile(string filePath, string version)
        {
            string data = dbOperations.SerializeDatabase(version);
            dbOperations.SaveToFile(data, filePath);
        }
    }

}
