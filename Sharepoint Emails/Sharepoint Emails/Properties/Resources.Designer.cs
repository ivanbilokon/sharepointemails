﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharepointEmails.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SharepointEmails.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot;&gt;
        ///    &lt;xsl:output method=&quot;text&quot; indent=&quot;yes&quot;/&gt;
        ///    &lt;xsl:template match=&quot;@* | node()&quot;&gt;
        ///      &lt;xsl:value-of select=&quot;EventData[1]/@AdminEmail&quot;/&gt;
        ///    &lt;/xsl:template&gt;
        ///&lt;/xsl:stylesheet&gt;
        ///.
        /// </summary>
        public static string AdminAddressTemplate {
            get {
                return ResourceManager.GetString("AdminAddressTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;!-- If you are customizing alerttemplates.xml or alerttemplates_sms.xml, please ensure you keep them in synchronization in every parts except the format section. --&gt;
        ///&lt;AlertTemplates&gt;
        ///    &lt;AlertTemplate Type=&quot;List&quot;  Name=&quot;SPAlertTemplateType.GenericList&quot;&gt;
        ///        &lt;EventTypes IsVisible=&quot;True&quot;/&gt;
        ///        &lt;Format&gt;
        ///&lt;Digest&gt;
        ///    &lt;Header&gt;&lt;HTML&gt;&lt;![CDATA[&lt;html dir = $Resources:core,PageDirection;&gt;
        /// &lt;head&gt;
        /// &lt;base href=&quot;]]&gt;&lt;/HTML&gt;&lt;GetVar Name=&quot;SiteUrl&quot; URLEncodeAsURL=&quot;TR [rest of string was truncated]&quot;;.
        /// </summary>
        public static string alerttemplates {
            get {
                return ResourceManager.GetString("alerttemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot; xmlns:user=&quot;urn:my-scripts&quot;&gt;
        ///    &lt;xsl:output method=&quot;xml&quot; indent=&quot;yes&quot;/&gt;
        ///   
        ///    &lt;xsl:template match=&quot;@* | node()&quot;&gt;
        ///      &lt;Html&gt;
        ///        &lt;head&gt;
        ///          &lt;base href=&quot;{SSite.Url}&quot;/&gt;
        ///          &lt;style type=&quot;text/css&quot;&gt;
        ///            .main table{
        ///            border: 1px solid black;
        ///            }
        ///            .m [rest of string was truncated]&quot;;.
        /// </summary>
        public static string BodyTemplate {
            get {
                return ResourceManager.GetString("BodyTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; 
        ///                xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot; 
        ///                xmlns:user=&quot;urn:my-scripts&quot;
        ///                xmlns:d=&quot;urn:sharepointemail-discussionboard&quot;&gt;
        ///  &lt;xsl:output method=&quot;xml&quot; indent=&quot;yes&quot;/&gt;
        ///
        ///  &lt;xsl:template match=&quot;@* | node()&quot;&gt;
        ///    &lt;Html&gt;
        ///      &lt;head&gt;
        ///        &lt;base href=&quot;{SSite.Url}&quot;/&gt;
        ///      &lt;/head&gt;
        ///      &lt;Body&gt;
        ///        &lt;div  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string BodyTemplateForDiscussionBoard {
            get {
                return ResourceManager.GetString("BodyTemplateForDiscussionBoard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema id=&quot;DiscussionBoardSchema&quot;
        ///    targetNamespace=&quot;urn:sharepointemail-discussionboard&quot;
        ///    elementFormDefault=&quot;qualified&quot;
        ///    xmlns=&quot;urn:sharepointemail-discussionboard&quot;
        ///    xmlns:mstns=&quot;urn:sharepointemail-discussionboard&quot;
        ///    xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///&gt;
        ///
        ///  &lt;xs:element name=&quot;DiscussionBoard&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;xs:element name=&quot;Discussion&quot; maxOccurs=&quot;1&quot; minOccurs=&quot;1&quot;&gt;
        ///          
        ///        &lt;/xs:eleme [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DiscussionBoardSchema {
            get {
                return ResourceManager.GetString("DiscussionBoardSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot;&gt;
        ///    &lt;xsl:output method=&quot;text&quot; indent=&quot;yes&quot;/&gt;
        ///    &lt;xsl:template match=&quot;@* | node()&quot;&gt;
        ///      &lt;xsl:value-of select=&quot;EventData[1]/@ListEmail&quot;/&gt;
        ///    &lt;/xsl:template&gt;
        ///&lt;/xsl:stylesheet&gt;
        ///.
        /// </summary>
        public static string ListAddressTemplate {
            get {
                return ResourceManager.GetString("ListAddressTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;xsl:stylesheet xmlns:xsl=&apos;http://www.w3.org/1999/XSL/Transform&apos; version=&apos;1.0&apos;&gt;
        ///  &lt;xsl:template match=&apos;Data&apos;&gt;
        ///    &lt;subject&gt;
        ///      Subject for &quot;{SList.Title}&quot;
        ///    &lt;/subject&gt;
        ///  &lt;/xsl:template&gt;
        ///&lt;/xsl:stylesheet&gt;.
        /// </summary>
        public static string subjXslt {
            get {
                return ResourceManager.GetString("subjXslt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;xsl:stylesheet xmlns:xsl=&apos;http://www.w3.org/1999/XSL/Transform&apos; version=&apos;1.0&apos;&gt;
        ///  &lt;xsl:template match=&apos;Data&apos;&gt;
        ///    &lt;HTML&gt;
        ///      &lt;BODY&gt;
        ///        &lt;TABLE BORDER=&apos;2&apos;&gt;
        ///          &lt;TR&gt;
        ///            &lt;TD&gt;Field Name&lt;/TD&gt;
        ///            &lt;TD&gt;Old Value&lt;/TD&gt;
        ///            &lt;TD&gt;New Value&lt;/TD&gt;
        ///          &lt;/TR&gt;
        ///          &lt;xsl:apply-templates select=&apos;EventData/Field&apos;/&gt;
        ///        &lt;/TABLE&gt;
        ///          &lt;xsl:choose&gt;
        ///            &lt;xsl:when test=&quot;EventData/Approve[1]/@Status =&apos;Pending&apos;&quot;&gt;
        ///              &lt;xsl:choose&gt;
        ///                 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string testbody {
            get {
                return ResourceManager.GetString("testbody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;Data&gt;
        ///  &lt;EventData EventType=&quot;2&quot; EventTypeName=&quot;Modify&quot;&gt;
        ///    &lt;Field Type=&quot;Type1&quot; DisplayName=&quot;Title&quot; Name=&quot;_Title&quot; Changed=&quot;false&quot; New=&quot;new value of Title&quot; Old=&quot;old value of Title&quot; Value=&quot;some value of Title&quot; /&gt;
        ///    &lt;Field Type=&quot;Type2&quot; DisplayName=&quot;FileName&quot; Name=&quot;_FileName&quot; Changed=&quot;true&quot; New=&quot;new value of FileName&quot; Old=&quot;old value of FileName&quot; Value=&quot;some value of FileName&quot; /&gt;
        ///    &lt;Field Type=&quot;Type3&quot; DisplayName=&quot;YesNoField&quot; Name=&quot;_YesNoField&quot; Changed=&quot;false&quot; N [rest of string was truncated]&quot;;.
        /// </summary>
        public static string TestContextXML {
            get {
                return ResourceManager.GetString("TestContextXML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Data&gt;
        ///  &lt;EventData EventType=&quot;1&quot; EventTypeName=&quot;Add&quot; ListEmail=&quot;disc@dev.test.domain.com&quot; AdminEmail=&quot;melnikvitaly@gmail.com&quot;&gt;
        ///    &lt;Field Type=&quot;string&quot; DisplayName=&quot;Content Type ID&quot; Name=&quot;ContentTypeId&quot; Changed=&quot;true&quot; New=&quot;0x010700F7F50D2C1749FC45A820B1832F80583D&quot; Old=&quot;&quot; Value=&quot;0x010700F7F50D2C1749FC45A820B1832F80583D&quot; Hidden=&quot;true&quot; /&gt;
        ///    &lt;Field Type=&quot;string&quot; DisplayName=&quot;Body&quot; Name=&quot;Body&quot; Changed=&quot;true&quot; New=&quot;&amp;lt;div class=&amp;quot;ExternalClassA42E99C976A5497B8B2BDE5C5B91EE41&amp;quot;&amp;gt;&amp;lt;div&amp;gt;&amp;lt;div  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string TEstXMLMessageAdded {
            get {
                return ResourceManager.GetString("TEstXMLMessageAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;
        ///    xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot;
        ///&gt;
        ///    &lt;xsl:output method=&quot;xml&quot; indent=&quot;yes&quot;/&gt;
        ///
        ///    &lt;xsl:template match=&quot;@* | node()&quot;&gt;
        ///        &lt;xsl:copy&gt;
        ///            &lt;xsl:apply-templates select=&quot;@* | node()&quot;/&gt;
        ///        &lt;/xsl:copy&gt;
        ///    &lt;/xsl:template&gt;
        ///&lt;/xsl:stylesheet&gt;
        ///.
        /// </summary>
        public static string Utils {
            get {
                return ResourceManager.GetString("Utils", resourceCulture);
            }
        }
    }
}
