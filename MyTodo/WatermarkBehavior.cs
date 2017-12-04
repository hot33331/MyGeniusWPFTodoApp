using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace MyTodo
{
    public class WatermarkBehavior: Behavior<TextBox>
    {
        public string Text { get; set; }  
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.GotFocus += AssociatedObject_GotFocus;
            AssociatedObject.LostFocus += AssociatedObject_LostFocus;
            AssociatedObject_LostFocus(this,new RoutedEventArgs());
        }

        private void AssociatedObject_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            TextBox actualTextBox = AssociatedObject;
            if (actualTextBox.Text == String.Empty)
            {
                actualTextBox.Text = Text;
                actualTextBox.Foreground=new SolidColorBrush(Colors.Gray);
                actualTextBox.FontStyle = FontStyles.Italic;

            }
        }

        private void AssociatedObject_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            TextBox actualTextBox = AssociatedObject;
            if (actualTextBox.Text == Text)
            {
                actualTextBox.Text = string.Empty;
                actualTextBox.Foreground=new SolidColorBrush(Colors.Black);
                actualTextBox.FontStyle = FontStyles.Normal;
            }
        }
    }
}
