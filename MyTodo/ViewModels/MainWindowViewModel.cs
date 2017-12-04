using MyTodo.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _todoText;

        public string TodoText { get { return _todoText; } set { _todoText = value; OnPropertyChanged("TodoText"); } }

        public ObservableCollection<Todo> Todos { get; set; } = new ObservableCollection<Todo>();

        public DelegateComand AddTodoCommand { get; set; }

        public MainWindowViewModel()
        {
            AddTodoCommand = new DelegateComand(AddTodo);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddTodo(object args)
        {
            Todo todo = new Todo();
            todo.Text = TodoText;
            Todos.Add(todo);

            TodoText = String.Empty;
        }

        public void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
