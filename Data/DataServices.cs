using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Techno_Store.Entity;

namespace Techno_Store.Data
{
    internal class DataServices
    {
        private readonly DataStore _dataStore;
        private readonly DataPath _dataPath;

        public DataServices()
        {
            _dataPath = new DataPath();
            _dataStore = new DataStore(_dataPath.filePath);
        }

        public List<Product> GetAllProduct()
        {
            return _dataStore.Products;
        }

        public void SaveChanges()
        {
            _dataStore.SaveChanges(_dataPath);
        }
    }
}
