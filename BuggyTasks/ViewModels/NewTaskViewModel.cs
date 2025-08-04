using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using BuggyTasks.Models;

namespace BuggyTasks.ViewModels;

public partial class NewTaskViewModel : ObservableObject
{
    [ObservableProperty]
    string newTaskTitle = string.Empty;

    public ICommand AddNewTaskCommand { get; } 

    public NewTaskViewModel()
    {
        AddNewTaskCommand = new RelayCommand(OnAddTask, CanAddTask);
    }

    void OnAddTask()
    {
        if (string.IsNullOrWhiteSpace(NewTaskTitle))
            return;

        var newTask = new TaskItem
        {
            Title = NewTaskTitle,
            Description = $"Task created on {DateTime.Now:g}",
            IsCompleted = false,
            CreatedDate = DateTime.Now
        };

        // TODO: Add to a shared task service/repository
        Console.WriteLine($"Added task: {newTask.Title}");
        
        // Clear the input
        NewTaskTitle = string.Empty;
        
        // Navigate back
        Shell.Current.GoToAsync("..");
    }

    bool CanAddTask()
    {
        return !string.IsNullOrWhiteSpace(NewTaskTitle);
    }
}