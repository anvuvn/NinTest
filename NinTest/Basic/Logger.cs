using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.Basic
{
    public class Logger
    {      
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged;

        public void Log(string message)                                                                               
        {
            if(string.IsNullOrWhiteSpace(message)) {
                throw new ArgumentNullException();
            }

            LastError = message;
            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}
