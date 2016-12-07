using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompositeDemo.Models
{
    public class IteratieBlock:ICodeBlock
    {
        public List<ICodeBlock> Compositie = new List<ICodeBlock>();

        public void DoeHet()
        {
            // Voer de compositie een aantal keer uit op basis van een conditie
        }

    }
}