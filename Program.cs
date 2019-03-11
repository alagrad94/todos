using System;

namespace Todos
{
  class Program
  {
    static void Main()
    {
      TodoList todoList = new TodoList();

        // Add some less important things...
      todoList.AddLeastPriorityTodo(
        new Todo() {
          Text = "Take clothes to Goodwill",
          DueDate = DateTime.Today.AddDays(7)
        }
      );

      todoList.AddLeastPriorityTodo(
        new Todo() {
          Text = "Help friend move",
          DueDate = DateTime.Today.AddDays(14)
        }
      );

      // Add some more important things...
      todoList.AddTopPriorityTodo(
        new Todo() {
          Text = "Do laundry",
          DueDate = DateTime.Today.AddDays(1)
        }
      );

      todoList.AddTopPriorityTodo(
        new Todo() {
          Text = "Clean house",
          DueDate = DateTime.Today
        }
      );

      // Print a report of Todos
      Console.WriteLine("All Todos");
      Console.WriteLine("---------");

      todoList.PrintAll();

      Console.WriteLine("---------");
      Console.WriteLine();

      // Print some individual Todos:

      // Should be "Help friend move"
      Todo helpMove = todoList.GetElementAt(3);
      Console.WriteLine(helpMove);

      bool includeComplete = false;
      Todo cleanHouse = todoList.GetTopPriorityTodo(includeComplete);
      Console.WriteLine(cleanHouse);

      cleanHouse.IsComplete = true;
      Console.WriteLine(cleanHouse);

      // Now the top, INCOMPLETE priority todo is laundry
      Todo laundry = todoList.GetTopPriorityTodo(includeComplete);
      Console.WriteLine(laundry);

      // Print a report of incomplete Todos
      // Should be everything except "Clean House"
      Console.WriteLine();
      Console.WriteLine("Incomplete Todos");
      Console.WriteLine("---------");

      todoList.PrintIncomplete();

      Console.WriteLine("---------");
      Console.WriteLine();


      Todo randomTodo = todoList.GetRandomTodo();
      Console.WriteLine("A random todo");
      Console.WriteLine(randomTodo);
    }
  }
}