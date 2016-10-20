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
}
