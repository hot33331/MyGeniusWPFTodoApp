﻿using MyTodo.Entities;
using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

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

        public void RemoveTodo(object sender, RoutedEventArgs eventArgs)
        {
            Todo selectedTodo = (Todo)((Button) sender).Tag;
            Todos.Remove(selectedTodo);
        }

       
    }
}
