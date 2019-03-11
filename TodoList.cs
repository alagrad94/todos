using System;
using System.Collections.Generic;

namespace Todos
{

  public class TodoList {

    private List<Todo> _todoList = new List<Todo>();

    public void AddTopPriorityTodo(Todo todo) {
      _todoList.Insert(0, todo);
    }

    public void AddLeastPriorityTodo(Todo todo) {
      _todoList.Add(todo);
    }

    public Todo GetElementAt(int index) {
      return _todoList[index];
    }

    public Todo GetRandomTodo(){

      Random random = new Random();
      int r = random.Next(_todoList.Count);

      Todo randomTodo = _todoList[r];

      return randomTodo;
    }
    public Todo GetTopPriorityTodo(bool includeCompleted) {

      Todo topPrioriy = null;

      if (includeCompleted == true) {

        topPrioriy = _todoList[0];

      } else if (includeCompleted == false) {

        topPrioriy = _todoList.Find(x => !x.IsComplete);

      } else if (includeCompleted == false && _todoList.TrueForAll(x => x.IsComplete = true)){

        topPrioriy = null;
      }

      return topPrioriy;
    }

    public void PrintAll() {
      foreach (Todo todo in _todoList)
      {
        Console.WriteLine($"Todo: {todo.Text}. Done? {todo.IsComplete}. Due on: {todo.DueDate}");
      }
    }

    public void PrintIncomplete() {

      foreach (Todo todo in _todoList){

        if (!todo.IsComplete){
        Console.WriteLine($"Todo: {todo.Text}. Done? {todo.IsComplete}. Due on: {todo.DueDate}");
        }
      }
    }
  }
}