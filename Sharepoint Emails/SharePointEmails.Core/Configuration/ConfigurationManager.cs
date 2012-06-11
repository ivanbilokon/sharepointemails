﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint;

namespace SharePointEmails.Core.Configuration
{
    public class ConfigurationManager
    {
        const string s = "asdfasdfsdafsdf";

        public FarmConfiguration GetConfigOrdefault(SPFarm farm)
        {
            var str = farm.Properties[s] as string;
            return SerializeHelper.ParseOrDefault<FarmConfiguration>(str);
        }
        public WebConfiguration GetConfigOrdefault(SPWeb web)
        {
            var str = web.Properties[s];
            return SerializeHelper.ParseOrDefault<WebConfiguration>(str);
        }
    }
}
