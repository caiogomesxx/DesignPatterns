﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public interface IDocumentElement
    {
        void Accept(IVisitor visitor);
    }
}
