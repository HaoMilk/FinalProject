﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Common.DTO
{
    public class SendEmailBySMTPInput
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public List<string> Recipient { get; set; }
    }
}
