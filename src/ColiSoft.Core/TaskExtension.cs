using System;
using System.Threading;
using System.Threading.Tasks;

public static class TaskExtension
{
	public static Task WithCancellation(this Task task, CancellationToken ct)
	{
		return task.ContinueWith(t => t.GetAwaiter().GetResult(), ct);
	}

	public static Task<T> WithCancellation<T>(this Task<T> task, CancellationToken ct)
	{	
		return task.ContinueWith(t => t.GetAwaiter().GetResult(), ct);
	}

    public static async Task WithTimeout(this Task task, int timeout)
    {
        if (timeout == 0)
            await task;
        if (task == await Task.WhenAny(task, Task.Delay(timeout)))
            await task;
        else
            throw new TimeoutException();  
    }
    
    public static async Task<T> WithTimeout<T>(this Task<T> task, int timeout)
    {
        if (timeout == 0)
            return await task;
        if (task == await Task.WhenAny(task, Task.Delay(timeout)))
            return await task;
        else
            throw new TimeoutException();
    }
}
