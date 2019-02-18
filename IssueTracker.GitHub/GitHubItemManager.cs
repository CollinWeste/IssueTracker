using IssueTracker.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.GitHub
{
    class GitHubItemManager : IItemManager
    {
        public Task<string> AddTests(IProjectTask task)
        {
            throw new NotImplementedException();
        }

        public Task<string> CompleteTask(IProjectTask task)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProjectTask> GetTasks()
        {
            throw new NotImplementedException();
        }

        public Task<string> OpenPullRequest(IProjectTask task)
        {
            throw new NotImplementedException();
        }
    }
}
