﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_work
{
    public interface ICommand
    {
        void Execute();
        string GetDescription();
    }
}
