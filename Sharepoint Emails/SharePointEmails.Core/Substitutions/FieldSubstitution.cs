﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SharePointEmails.Core.Substitutions;

namespace SharePointEmails.Core
{
    public class FieldSubstitution : ISubstitution
    {
        public string Pattern
        {
            get
            {
                return "[FieldName]";
            }
        }

        //[Title:O:]
        public string Description
        {
            get
            {
                return "Field substitution";
            }
        }

        public string Process(string text, ISubstitutionContext context)
        {
            string res = text;
            var mc = Regex.Matches(res, @"\[(.+?)\]");

            foreach (Match m in mc)
            {
                ModifiersCollection modifiers =new ModifiersCollection();
                var fieldNameWithModifiers = m.Value.Trim(']', '[');
                var mod = Regex.Match(fieldNameWithModifiers, @"\:.+");
                if (mod != null && mod.Value != null)
                {
                    modifiers = ModifiersCollection.Parse(mod.Value);
                }
                
                var withoutModifiers=(mod!=null&&!string.IsNullOrEmpty(mod.Value))?fieldNameWithModifiers.Replace(mod.Value,""):fieldNameWithModifiers;
                string fieldTextValue = context.GetField(withoutModifiers, modifiers);
                if (fieldTextValue == null)
                {
                    fieldTextValue = "no \"" + fieldNameWithModifiers + "\"";
                }
                if (!string.IsNullOrEmpty(m.Value))
                {
                    res = res.Replace(m.Value, fieldTextValue);
                }
            }
            return res;
        }

        public List<string> GetAvailableKeys(ISubstitutionContext context)
        {
            var res = new List<string>() { "field1", "field2" };
            return res;
        }
    }
}
