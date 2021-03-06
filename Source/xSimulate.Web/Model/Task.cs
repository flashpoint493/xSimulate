﻿using System;
using System.Collections.Generic;
using System.Web;
using NetFramework.DataAccess.EntityBuilder;

namespace xSimulate.Web.Model
{
    [Serializable]
    public class Task
    {
        [DataMapping]
        public int SysNo { get; set; }

        [DataMapping]
        public int CustomerSysNo { get; set; }

        [DataMapping]
        public int CustomerSettingSysNo { get; set; }

        [DataMapping]
        public int RunTimes { get; set; }

        [DataMapping]
        public int DownTimes { get; set; }

        [DataMapping]
        public DateTime BeginDate { get; set; }

        [DataMapping]
        public DateTime EndDate { get; set; }

        public decimal Costs { get; set; }

        [DataMapping]
        public string Status { get; set; }

        [DataMapping]
        public string Description { get; set; }

        [ReferencedEntity]
        public CustomerSetting Setting { get; set; }
    }
}