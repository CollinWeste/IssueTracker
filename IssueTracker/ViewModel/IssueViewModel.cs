using IssueTracker.Interface;
using IssueTracker.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace IssueTracker.ViewModel
{
    public class IssueViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<IProjectTask> Items { get; private set; }

        public IItemManager ItemManager
        {
            get => _itemManager;
            set
            {
                if (value != _itemManager)
                {
                    _itemManager = value;

                    Items = new ObservableCollection<IProjectTask>(_itemManager.GetTasks());
                    OnPropertyChanged(nameof(Items));
                }
            }
        }
        private IItemManager _itemManager;

        #region Commands

        public ICommand OpenInBrowserCommand => 
            _openInBrowserCommand ?? (_openInBrowserCommand = new Command(() => { }));
        private ICommand _openInBrowserCommand;

        public ICommand OpenPullRequestCommand =>
            _openPullRequestCommand ?? (_openPullRequestCommand = new Command(() => { }));
        private ICommand _openPullRequestCommand;

        public ICommand AddTestCommand =>
            _addTestCommand ?? (_addTestCommand = new Command(() => { }));
        private ICommand _addTestCommand;

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
