using Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class DatabaseSingleton :DBContext
    {
        private static DBContext _context;
        private static DatabaseSingleton _instance;
        private static ManualResetEvent _initEvent = new ManualResetEvent(false);

        static DatabaseSingleton()
        {
            ThreadPool.QueueUserWorkItem(state => Init());
            
        }

        public static DatabaseSingleton Instance()
        {
            _initEvent.WaitOne();
        return _instance;
    }
    private static DBContext Init()
    {
        _instance = new DatabaseSingleton();
      DBContext _context = new DBContext();

           

            _initEvent.Set();
            return _context;
        }
}
}
