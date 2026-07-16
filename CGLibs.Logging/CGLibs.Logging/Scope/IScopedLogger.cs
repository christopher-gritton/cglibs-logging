using Microsoft.Extensions.Logging;

namespace CGLibs.Logging.Scope;
public interface IScopedLogger : ILogger, IDisposable
{
    string ScopeId { get; }
}
