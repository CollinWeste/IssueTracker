using IssueTracker.Interface;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IssueTracker.ViewModel
{
    public class IssueViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ITask> Items { get; private set; }

        public IItemManager ItemManager
        {
            get => _itemManager;
            set
            {
                if (value != _itemManager)
                {
                    _itemManager = value;

                    Items = new ObservableCollection<ITask>(_itemManager.GetTasks());
                    OnPropertyChanged(nameof(Items));
                }
            }
        }
        private IItemManager _itemManager;

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
