﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharePointEmails.Logging;
using SharePointEmails.Core.Substitutions;
using SharePointEmails.Core.Interfaces;

namespace SharePointEmails.Core.Substitutions
{
    public class SubstitutionWorker : ISubstitutionWorker
    {
        private List<ISubstitution> m_preSubstitutions; //all pre substitutions
        private List<ISubstitution> m_postSustitutions; //all post substitutions
        private List<ISubstitution> m_alreadyProcessed;//substitutions which have been already used

        private ILogger m_Logger;

        private ISubstitutionContext m_currentContext;

        public SubstitutionWorker(ILogger logger, List<ISubstitution> sustitutions, List<ISubstitution> postsustitutions)
        {
            m_Logger = logger;
            m_preSubstitutions = sustitutions ?? new List<ISubstitution>();
            m_alreadyProcessed = new List<ISubstitution>();
        }

        public string OnPartLoaded(string includedPart)//some substitutions can include new parts to template so we need process them with already processed substitutions
        {
            return Process(includedPart, m_alreadyProcessed, m_currentContext, null);
        }

        string Process(string res, IList<ISubstitution> substitutions, ISubstitutionContext context, Action<ISubstitution> processedCallback)
        {
            m_Logger.WriteTrace("STARTED Processing following data:" + Environment.NewLine + res, SeverityEnum.Verbose);
            if (substitutions != null)
            {
                foreach (var substitution in substitutions)
                {
                    m_Logger.WriteTrace("STARTED substitution : " + substitution.GetType().Name + "with template :" + Environment.NewLine + res, SeverityEnum.Verbose);
                    try
                    {
                        m_currentContext = context;
                        substitution.Worker = this;
                        res = substitution.Process(res, context);
                        m_Logger.WriteTrace("FINISHED substitution : " + substitution.GetType().Name + "with result template :" + Environment.NewLine + res, SeverityEnum.Verbose);
                        if (processedCallback != null)
                        {
                            processedCallback(substitution);
                        }
                    }
                    catch (Exception ex)
                    {
                        m_Logger.WriteTrace("Error from substitution" + substitution.GetType().Name, ex, SeverityEnum.CriticalError);
                        throw;
                    }
                }
            }
            m_Logger.WriteTrace("FINISHED Processing following data:" + Environment.NewLine + res, SeverityEnum.Verbose);
            return res;
        }

        public string PreProcess(string data, ISubstitutionContext context)
        {
            return Process(data, m_preSubstitutions, context);
        }

        string Process(string data, IList<ISubstitution> subs, ISubstitutionContext context)
        {
            var res = data ?? "";
            m_alreadyProcessed.Clear();
            res = Process(data, subs, context, (s) => m_alreadyProcessed.Add(s));
            return (string.IsNullOrEmpty(res)) ? "empty" : res;
        }

        public string PostProcess(string data, ISubstitutionContext context)
        {
           return Process(data, m_postSustitutions, context);
        }
    }
}
