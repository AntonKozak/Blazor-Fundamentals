using Microsoft.JSInterop;

namespace BlazorFundamentals.Helper;

public static class IJSRuntimeExtensions
{
    public static async Task ToastrSuccess(this IJSRuntime jsRuntime, string message, string title)
    {
        await jsRuntime.InvokeVoidAsync("showToastr", "success", message, title);
    }
    public static async Task ToastrError(this IJSRuntime jsRuntime, string message, string title)
    {
        await jsRuntime.InvokeVoidAsync("showToastr", "error", message, title);
    }



}
