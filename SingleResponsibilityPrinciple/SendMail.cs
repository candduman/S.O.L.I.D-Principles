﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class SendMail : ISend
    {
        public string send()
        {
            return "SendMail";
        }
    }
}
