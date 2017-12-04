using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTodo.ViewModels;
using System.Linq;

namespace MyTodoAppTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string V = "Hallo User";

        [TestMethod]
        public void AddTodoTest()
        {
            //AAA
            //Arrange
            var mwvm = new MainWindowViewModel();
            //Act
            mwvm.TodoText = V;
            mwvm.AddTodo(null);
            //Assert
            Assert.AreEqual(V, mwvm.Todos.First().Text);
            Assert.AreEqual(String.Empty, mwvm.TodoText);

        }
    }
}
