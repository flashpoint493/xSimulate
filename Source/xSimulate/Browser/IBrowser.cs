﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xSimulate.Action;

namespace xSimulate.Browser
{
    public interface IBrowser
    {
        void Run(IAction action);

        bool IsComplete();
    }
}
