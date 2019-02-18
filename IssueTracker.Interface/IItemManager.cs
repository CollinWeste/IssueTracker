using System.Collections.Generic;
using System.Threading.Tasks;

namespace IssueTracker.Interface
{
    public interface IItemManager
    {
        IEnumerable<ITask> GetTasks();
        Task<string> OpenPullRequest(ITask task);
        Task<string> AddTests(ITask task);
        Task<string> CompleteTask(ITask task);
    }
}
