using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompositeDemo.Models
{
    public class TestA: TestAbstract, IMijnInterface
    {
        public string MijnString(int getal)
        {
            throw new NotImplementedException();
        }

        public void DoeIetsAnders()
        {
            
        }
    }
}