using Application.Interfaces;

namespace Application.Modules;

class LogTracingService : ILogging
{
	private readonly string _id;

	public LogTracingService()
	{
		_id = GenerateId();
	}

	private string GenerateId() { return ""; }

	public void Log(LogLevel level, string msg) { }
}