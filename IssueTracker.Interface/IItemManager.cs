using System.Collections.Generic;
using System.Threading.Tasks;

namespace IssueTracker.Interface
{
    public interface IItemManager
    {
        IEnumerable<IProjectTask> GetTasks();
        Task<string> OpenPullRequest(IProjectTask task);
        Task<string> AddTests(IProjectTask task);
        Task<string> CompleteTask(IProjectTask task);
    }
}
