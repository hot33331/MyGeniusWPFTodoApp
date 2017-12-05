using MyTodo.Entities;
using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace MyTodo.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowViewModel 
    {

        public MainWindowViewModel()
        {
            //if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            //{
            //    Todos.Add(new Todo(){Text = "Laufen"});
            //    Todos.Add(new Todo() { Text = "Tanzen" });
            //    Todos.Add(new Todo() { Text = "Singen" });
            //}
        }
        public string TodoText { get; set; }

        public ObservableCollection<Todo> Todos { get; set; } = new ObservableCollection<Todo>();

        public Todo SelectedTodo { get; set; }  
        
        public void AddTodo(object sender, RoutedEventArgs eventArgs)
        {
            Todo todo = new Todo();
            todo.Text = TodoText;
            Todos.Add(todo);

            TodoText = String.Empty;
        }

        public void RemoveTodo(object sender, RoutedEventArgs eventArgs)
        {
            Todos.Remove(SelectedTodo);
        }

       
    }
}
