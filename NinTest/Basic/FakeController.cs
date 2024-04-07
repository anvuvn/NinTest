using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.Basic
{
    public class FakeController
    {
        public ActionResult GetItem(int id)
        {
            if (id > 0)
                return new Ok();
            //
            return new NotFound();
        }
    }
    
    public class ActionResult { }
    public class NotFound : ActionResult { }
    public class Ok : ActionResult { }  
}


