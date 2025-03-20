using Application.Interfaces;

namespace Application.Modules;

class SysLogger : ILogging
{
	public SysLogger()
	{
	}

	public static void Log(LogLevel level, string msg) 
	{
		Console.WriteLine($"[{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fffffff")}] {level.ToString().ToUpper()}: {msg}");
	}
}