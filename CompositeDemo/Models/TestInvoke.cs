using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompositeDemo.Models
{
    public class TestInvoke
    {
        public void DoeIets()
        {
            TestA a = new TestA();
            IMijnInterface imi = new TestA();
            a.MijnString(1);
            imi.MijnString(2);

            a.DoeIetsAnders();
            TestAbstract b = new TestA();
        }

    }
}