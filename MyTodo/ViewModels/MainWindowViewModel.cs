using MyTodo.Entities;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyTodo.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel 
    {
        

        public string TodoText { get; set; }

        public ObservableCollection<Todo> Todos { get; set; } = new ObservableCollection<Todo>();


        
        public void AddTodo(object sender, RoutedEventArgs eventArgs)
        {
            Todo todo = new Todo();
            todo.Text = TodoText;
            Todos.Add(todo);

            TodoText = String.Empty;
        }

       
    }
}
