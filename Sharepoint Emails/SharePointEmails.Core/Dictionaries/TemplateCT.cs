﻿using System;
public static class TemplateCT
{
    public const string CTId = "0x01006230043d1f824022a80ad3e43a7b6da4";
    public const string FeatureId = "50e13f0b-69b1-43cf-8627-d782e7efa4cc";
    public const string TemplateName = "TemplateName";
    public const string TemplateBody = "TemplateBody";
    public const string TemplateType = "TemplateType";
    public const string TemplateState = "TemplateState";
    public const string SendDraftTo = "SendDraftTo";
    public const string Associations = "Associations";
    public const string TemplateSubject = "TemplateSubject";
    public const string TemplateBodyFile = "TemplateBodyFile";
    public const string TemplateSubjectFile = "TemplateSubjectFile";
    public const string TemplateSubjectUseFile = "TemplateSubjectUseFile";
    public const string TemplateBodyUseFile = "TemplateBodyUseFile";
    
    public const string TemplateFrom = "TemplateFrom";
    public const string TemplateFromUseFile = "TemplateFromUseFile";
    public const string TemplateFromFile = "TemplateFromFile";

    public const string TemplateReplay = "TemplateReplay";
    public const string TemplateReplayUseFile = "TemplateReplayUseFile";
    public const string TemplateReplayFile = "TemplateReplayFile";

    public static class StateChoices
    {
        public const string Draft = "Draft";
        public const string Published = "Published";
    }

    public static class TypeChoices
    {
        public const string ItemRemoved = "Item added";
        public const string ItemAdded = "Item removed";
        public const string ItemUpdated = "Item updated";
        public const string All = "All";
    }
}