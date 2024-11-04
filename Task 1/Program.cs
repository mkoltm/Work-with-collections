using System;
using System.Collections.Generic;

//ЗАВДАННЯ 1

// Клас для представлення завдань
class Task
{
    public int TaskId { get; set; }
    public string Description { get; set; }

    public Task(int taskId, string description)
    {
        TaskId = taskId;
        Description = description;
    }
}

// Клас для управління завданнями
class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(int taskId, string description)
    {
        Task newTask = new Task(taskId, description);
        tasks.Add(newTask);
        Console.WriteLine($"Task added: {newTask.TaskId} - {newTask.Description}");
    }

    public void RemoveTask(int taskId)
    {
        Task taskToRemove = tasks.Find(task => task.TaskId == taskId);

        if (taskToRemove != null)
        {
            tasks.Remove(taskToRemove);
            Console.WriteLine($"Task removed: {taskToRemove.TaskId} - {taskToRemove.Description}");
        }
        else
        {
            Console.WriteLine($"Task with TaskId {taskId} not found.");
        }
    }

    public void DisplayTasks()
    {
        Console.WriteLine("Tasks:");

        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.TaskId} - {task.Description}");
        }
    }
}

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        // Додавання завдань
        taskManager.AddTask(1, "Complete homework");
        taskManager.AddTask(2, "Read a book");

        // Виведення усіх завдань
        taskManager.DisplayTasks();

        // Видалення завдання
        taskManager.RemoveTask(1);

        // Виведення усіх завдань після видалення
        taskManager.DisplayTasks();
    }
}