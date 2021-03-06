﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTrackerApp.Models
{
        public enum IssueStatus
        { 
            Offen,
            Bearbeitung,
            Testen,
            Wiedergeöffnet,
            Angehalten,
            Erledigt
        }
        public enum IssueSeverity
        {
            ShowStopper,
            Kritisch,
            Erheblich,
            Unerheblich,
            SpäterErledigen
        }
        public enum IssueIsRepoducible
        {
            Immer,
            Manchmal,
            Nie
        }
        public enum IssueCategory
        {
            UserInterface,
            BusinessLogic,
            Database,
            Hardware,
            Network,
            Communication
        }

    public class Issue
    {
        public Issue()
        {

        }
        public int Id { get; set; }
        public string IssueName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        //public IssueStatus Status { get; set; }
        //public IssueSeverity Severity { get; set; }
        //public IssueIsRepoducible IsRepoducible { get; set; }
        public int Status { get; set; }
        public int Severity { get; set; }
        public int IsRepoducible { get; set; }
        public string Reporter { get; set; }
        public string Responsible { get; set; }
        public string Supporting { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
        public string Team { get; set; }

    }
}
