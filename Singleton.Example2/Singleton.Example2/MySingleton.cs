using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example2
{
    public class MySingleton
    {
        private static MySingleton _instance;
        public Guid Id { get; private set; }
        private MySingleton()
        {
            Id = Guid.NewGuid(); // valor aleatorio de Id cada vez que se ejecuta la instancia.
        }
        public static MySingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MySingleton();
            }
            return _instance;
        }
    }
}
