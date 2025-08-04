using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BuggyTasks.Models;

namespace BuggyTasks.ViewModels;

public partial class TaskListViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<TaskItem> tasks;

    public TaskListViewModel()
    {
        Tasks = new ObservableCollection<TaskItem>
        {
            new TaskItem { Title = "Test Task 1", Description = "This is a test task", IsCompleted = false, CreatedDate = DateTime.Now.AddDays(-1) },
            new TaskItem { Title = "Test Task 2", Description = "Another test task", IsCompleted = true, CreatedDate = DateTime.Now.AddDays(-2) }
        };
    }

    [RelayCommand]
    void ToggleTask(TaskItem task)
    {
        if (task != null)
        {
            task.IsCompleted = !task.IsCompleted;
        }
    }

    [RelayCommand]
    void DeleteTask(TaskItem task)
    {
        if (task != null)
        {
            Tasks.Remove(task);
        }
    }
}