﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProjectWithMultipleConcepts
{
    class InitChildForAbstractClass : InitAbstractClass
    {
        public override void SayName()
        {
            throw new NotImplementedException();
        }
    }
}
