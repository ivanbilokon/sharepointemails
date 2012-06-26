﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.SharePoint;
using SharePointEmails.Logging;

namespace SharePointEmails.Core.Substitutions
{
    class ContextSubstitution : ISubstitution
    {
        ILogger Logger { set; get; }
        public ContextSubstitution()
        {
            Logger = ClassContainer.Instance.Resolve<ILogger>();
        }
        public string Pattern
        {
            get { return "{VarName}"; }
        }

        public string Description
        {
            get { return Pattern; }
        }

        public string Process(string text, ISubstitutionContext context)
        {
            var res = text;
            foreach (Match m in Regex.Matches(text, @"\{([^\$]+?)\}"))
            {
                try
                {
                    res = res.Replace(m.Value, context.GetContextValue(m.Groups[1].Value) ?? "no value");
                }
                catch (Exception ex)
                {
                    Logger.Write(ex, SeverityEnum.Error);
                }
            }
            return res;
        }

        public List<string> GetAvailableKeys(ISubstitutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
