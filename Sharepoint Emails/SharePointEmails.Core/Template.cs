﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using System.IO;
using SharePointEmails.Core.Substitutions;
using SharePointEmails.Core.Interfaces;
using SharePointEmails.Core.Associations;
using SharePointEmails.Core.Extensions;
using SharePointEmails.Logging;
namespace SharePointEmails.Core
{
    public class Template : ITemplate
    {
        private SPListItem m_Item = null;
        public Template()
        {
            this.Name = "Noname";
            this.Body = "No body";
            this.EventTypes = (int)TemplateTypeEnum.Unknown;
            this.State = TemplateStateEnum.Unknown;
        }
        public Template(SPListItem item)
        {
            m_Item = item;
            Refresh();
        }

        private bool BodyAttached;
        private bool SubjectAttached;
        private bool FromAttached;
        private bool ReplyAttached;

        private bool UseFileForSubject;
        private bool UseFileForBody;
        private bool UseFileForFrom;
        private bool UseFileForReply;


        public string Body { get; set; }

        public Guid Id
        {
            get;
            set;
        }

        public string Subject { set; get; }

        public string From { set; get; }

        public string Replay { set; get; }

        public string Name { get; set; }

        public IEnumerable<string> SendDraftToAdresses
        {
            get;
            set;
        }

        public TemplateStateEnum State { get; set; }

        public int EventTypes { get; set; }

        public AssociationCollection Associations
        {
            get
            {
                return AssociationCollection.ParseOrDefault(_Config);
            }
            set
            {
                _Config = (value ?? AssociationCollection.Empty).ToString();
            }
        }
        string _Config = null;



        void Refresh()
        {
            this.Name = m_Item[TemplateCT.TemplateName] as string;
            this.State = EnumConverter.ToState(m_Item[TemplateCT.TemplateState] as string);

            SPFieldUserValueCollection v = new SPFieldUserValueCollection(m_Item.Web, m_Item.GetFieldValue<object>(TemplateCT.SendDraftTo, string.Empty).ToString());

            this.SendDraftToAdresses = v.Select(p => p.User.Email).ToList();

            this.UseFileForSubject = m_Item.GetFieldValue<bool>(TemplateCT.TemplateSubjectUseFile);
            this.UseFileForBody = m_Item.GetFieldValue<bool>(TemplateCT.TemplateBodyUseFile);
            this.UseFileForFrom = m_Item.GetFieldValue<bool>(TemplateCT.TemplateFromUseFile);
            this.UseFileForReply = m_Item.GetFieldValue<bool>(TemplateCT.TemplateReplayUseFile);

            this.From = m_Item.GetValueFromTextFieldOrFile(this.UseFileForFrom, TemplateCT.TemplateFrom, TemplateCT.TemplateFromFile, out FromAttached);
            this.Replay = m_Item.GetValueFromTextFieldOrFile(this.UseFileForReply, TemplateCT.TemplateReplay, TemplateCT.TemplateReplayFile, out ReplyAttached);
            this.Body = m_Item.GetValueFromTextFieldOrFile(this.UseFileForBody, TemplateCT.TemplateBody, TemplateCT.TemplateBodyFile, out this.BodyAttached);
            this.Subject = m_Item.GetValueFromTextFieldOrFile(this.UseFileForSubject, TemplateCT.TemplateSubject, TemplateCT.TemplateSubjectFile, out this.SubjectAttached);

            if (m_Item[TemplateCT.TemplateType] != null)
            {
                var val = new SPFieldMultiChoiceValue(m_Item[TemplateCT.TemplateType].ToString());
                this.EventTypes = EnumConverter.ToType(val);
            }
            else
            {
                this.EventTypes = (int)TemplateTypeEnum.Unknown;
            }

            this.Associations = AssociationCollection.ParseOrDefault(m_Item[TemplateCT.Associations] as string);
        }

        public void SaveTo(SPListItem item)
        {
            m_Item = item;
            SaveChanges();
        }

        public void SaveChanges()
        {
            //TODO update other fields
            m_Item[TemplateCT.TemplateName] = this.Name;
            m_Item[TemplateCT.TemplateSubject] = this.Subject;
            m_Item[TemplateCT.TemplateBody] = this.Body;
            m_Item[TemplateCT.TemplateType] = EnumConverter.TypeToValue(this.EventTypes);
            m_Item[TemplateCT.TemplateState] = EnumConverter.StateToValue(this.State);
            m_Item[TemplateCT.Associations] = Associations.ToString();
            m_Item.Update();
            Refresh();
        }

        ILogger Logger
        {
            get
            {
                if (_Logger == null)
                {
                    _Logger = Application.Current.Logger;
                }
                return _Logger;
            }
        }ILogger _Logger;

        public override string ToString()
        {
            var s =
                "Name: " + Name + Environment.NewLine +
                "EventTypes: " + EventTypes + Environment.NewLine +
                "State: " + State + Environment.NewLine +
                "Pattern: " + Body + Environment.NewLine;
            foreach (var ass in Associations)
            {
                s += "Ass: " + Environment.NewLine + ass.ToString() + Environment.NewLine;
            }
            return s;
        }

    }
}
