using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTrackerApp.Models
{
    public class Issue
    {
        public Issue()
        {

        }
        public int Id { get; set; }
        public string IssueName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public enum IssueStatus
        { 
            Offen,
            Bearbeitung,
            Testen,
            Wiedergeöffnet,
            Angehalten,
            Erledigt
        }
        public IssueStatus Status { get; set; }
        public enum IssueSeverity
        {
            ShowStopper,
            Kritisch,
            Erheblich,
            Unerheblich,
            SpäterErledigen
        }
        public IssueSeverity Severity { get; set; }
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
        public IssueIsRepoducible IsRepoducible { get; set; }
        public string Reporter { get; set; }
        public string Responsible { get; set; }
        public string Supporting { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
        public string Team { get; set; }

    }
}
