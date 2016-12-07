using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompositeDemo.Models
{
    public class SequentieBlock:ICodeBlock
    {

        public List<ICodeBlock> Compositie = new List<ICodeBlock>();

        public void DoeHet()
        {
            foreach (var cb in Compositie)
            {
                cb.DoeHet();
            }
        }
    }
}