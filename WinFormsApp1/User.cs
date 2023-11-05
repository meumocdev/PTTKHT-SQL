using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class User
    {
        public bool IsAdmin { get; set; }
        public bool IsSale { get; set; }
        public bool IsImport { get; set; }

        private static User _currentUser;

        private static object _locker = new object(); // Remove this if you don't need to support multi-thread.
        public static User CurrentUser
        {
            get
            {
                // Returns _currentUser, if it has been create before
                if (_currentUser != null) return _currentUser;

                // lock all threads and let them go inside lock one by one
                lock (_locker)
                {
                    // Double-checked locking: This will prevent multi-time creation of _currentUser. 
                    // e.g. two threads came together for the first time and wait in the lock(_locker).
                    if (_currentUser == null)
                    {
                        _currentUser = new User();
                    }
                    return _currentUser;
                }
            }
        }

        public static void Logout()
        {
            lock (_locker)
            {
                _currentUser = null;
            }
        }

    }
}
