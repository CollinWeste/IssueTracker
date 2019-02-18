using System.ComponentModel;

namespace IssueTracker.Interface
{
    public interface IProjectTask : INotifyPropertyChanged
    {
        /// <summary>
        /// The identifier for the item.
        /// </summary>
        string Issue { get; }

        /// <summary>
        /// The url to the item.
        /// </summary>
        string IssueLink { get; }

        /// <summary>
        /// The item summary.
        /// </summary>
        string Summary { get; }

        // todo: Switch to enum
        /// <summary>
        /// The status of the item.
        /// </summary>
        string Status { get; }

        /// <summary>
        /// The url to the item status.
        /// </summary>
        string StatusLink { get; }

        /// <summary>
        /// Whether code is complete.
        /// </summary>
        bool CodeComplete { get; }

        /// <summary>
        /// Whether test is complete.
        /// </summary>
        bool TestComplete { get; }

        /// <summary>
        /// Whether a test exists.
        /// </summary>
        bool HasTest { get; }
    }
}
