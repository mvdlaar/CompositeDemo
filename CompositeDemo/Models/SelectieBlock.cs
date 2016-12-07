using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompositeDemo.Models
{
    public class SelectieBlock: ICodeBlock
    {
        public List<ICodeBlock> Compositie = new List<ICodeBlock>();

        public void DoeHet()
        {
            // Voer een aantal elementen uit compositie wel of niet uit op basis van een conditie
        }

    }
}