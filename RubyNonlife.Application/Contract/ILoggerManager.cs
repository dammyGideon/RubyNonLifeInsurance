﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.Contract
{
    public interface ILoggerManager
    {

        void LogInfo(string message);
        void LogWarn(string message);
        void LogError(string message);
        void LogDebug (string message);
    }
}
