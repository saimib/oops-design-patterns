using System;
namespace design_patterns.Singleton
{
    class Database
    {
        private static Database _database = null;
        private int _numberOfConnections = 0;
        private Database()
        {
            
        }

        public static Database getInstance() {

          if (_database == null) {
            _database = new Database();
          }

          return _database;
        }

        public void WriteData(string data) {
          Console.WriteLine(data);
          _numberOfConnections++;
        }

        public int GetNumberOfConnections(){
          return _numberOfConnections;
        }
    }
}