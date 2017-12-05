using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyTodo
{
    /// <summary>
    /// Interaction logic for AddTodoUserControl.xaml
    /// </summary>
    public partial class AddTodoUserControl : UserControl
    {


        public string TodoText
        {
            get { return (string)GetValue(TodoTextProperty); }
            set { SetValue(TodoTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TodoText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TodoTextProperty =
            DependencyProperty.Register("TodoText", typeof(string), typeof(AddTodoUserControl), new PropertyMetadata(String.Empty));

        public static readonly RoutedEvent OkClickEvent = EventManager.RegisterRoutedEvent("OkClick",
            RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AddTodoUserControl));

        public event RoutedEventHandler OkClick
        {
            add { AddHandler(OkClickEvent,value);}
            remove { RemoveHandler(OkClickEvent,value);}
        }

        public AddTodoUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var eventArgs =new RoutedEventArgs(OkClickEvent);
            RaiseEvent(eventArgs);
        }
    }
}
