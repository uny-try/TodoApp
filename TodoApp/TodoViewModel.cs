using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace TodoApp;

public partial class TodoViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<TodoItem> todoItems = new();

    [ObservableProperty]
    private string newTodoTitle = string.Empty;

    [RelayCommand]
    private void AddTodoItem()
    {
        if (!string.IsNullOrWhiteSpace(NewTodoTitle))
        {
            TodoItems.Add(new TodoItem { Title = NewTodoTitle, IsCompleted = false });
            NewTodoTitle = string.Empty;
        }
    }
}
