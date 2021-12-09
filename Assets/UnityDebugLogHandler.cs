using System;
using UnityEngine;

namespace UnityVrBase
{
    public class UnityDebugLogHandler : ILogHandler
    {
        private readonly ILogHandler _builtinHandler = Debug.unityLogger.logHandler;

        public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
        {
            //if (logType == LogType.Error)
            _builtinHandler.LogFormat(logType, context, format, args);
        }

        public void LogException(Exception exception, UnityEngine.Object context)
        {
            _builtinHandler.LogException(exception, context);
        }
    }
}