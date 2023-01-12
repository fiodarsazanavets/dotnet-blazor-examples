using Microsoft.AspNetCore.Components;

namespace BlazorCodeBehindDemo.Pages;

public class CounterBase : ComponentBase
{
    protected int CurrentCount = 0;

    protected void IncrementCount()
    {
        CurrentCount++;
    }
}