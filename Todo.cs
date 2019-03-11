using System;

namespace Todos
{
  public class Todo
  {
    public string Text {get; set;}
    public bool IsComplete  {get; set;}
    public DateTime DueDate {get; set;}

    public Todo() {
      Text = "";
      IsComplete = false;
      DueDate = DateTime.Today;
    }

    public void PrintTodo() {
      Console.WriteLine($"Todo: {Text} IsComplete: {IsComplete} Due: {DueDate.ToShortDateString()}");
    }

    public string AsStringRepresentation() {
      return $"Todo: {Text}. Done? {IsComplete}. Due on: {DueDate.ToShortDateString()}";
    }

    public override string ToString() {
      string result = AsStringRepresentation();
      return result;
    }
  }
}