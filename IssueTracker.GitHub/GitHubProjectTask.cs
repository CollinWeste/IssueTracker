using IssueTracker.Interface;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IssueTracker.GitHub
{
    internal class GitHubProjectTask : IProjectTask
    {
        public string Issue => throw new NotImplementedException();

        public string IssueLink => throw new NotImplementedException();

        public string Summary => throw new NotImplementedException();

        public string Status => throw new NotImplementedException();

        public string StatusLink => throw new NotImplementedException();

        public bool CodeComplete => throw new NotImplementedException();

        public bool TestComplete => throw new NotImplementedException();

        public bool HasTest => throw new NotImplementedException();

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
