﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using System.Xml.Serialization;
using System.IO;
using SharePointEmails.Core.Associations;

namespace SharePointEmails.Core
{
    [Serializable]
    public class AssociationConfiguration:List<Association>
    {
        static XmlSerializer Searilizer
        {

            get
            {
                if (_Serializer == null)
                {
                    _Serializer = new XmlSerializer(typeof(AssociationConfiguration));
                }
                return _Serializer;
            }
        }static XmlSerializer _Serializer;

        public static AssociationConfiguration Parse(string str)
        {
            using (var reader = new StringReader(str))
            {
                return (AssociationConfiguration)Searilizer.Deserialize(reader);
            }
        }

        public static AssociationConfiguration ParseOrDefault(string str)
        {
            try
            {
                return Parse(str);
            }
            catch
            {
                return new AssociationConfiguration();
            }
        }

        public static AssociationConfiguration Empty { get { return new AssociationConfiguration(); } }

        public override string ToString()
        {
            var value = new StringBuilder();
            using (var writer = new StringWriter(value))
            {
                Searilizer.Serialize(writer, this);
            }
            return value.ToString();
        }
    }

  

   

  
    
}