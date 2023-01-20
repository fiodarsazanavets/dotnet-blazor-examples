using Microsoft.AspNetCore.Components;

namespace BlazorDataBinding;

[EventHandler("onspecialpaste", typeof(SpecialPasteEventArgs),
    enableStopPropagation: true, enablePreventDefault: true)]
public static class EventHandlers
{
}

public class SpecialPasteEventArgs : EventArgs
{
    public string? PastedData { get; set; }
}
