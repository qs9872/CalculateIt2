﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateIt2.Engine
{
    public interface IVisitorAcceptor
    {
        void Accept(IVisitor visitor);
    }
}
