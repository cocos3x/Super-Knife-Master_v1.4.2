using System;
using System.Collections.Generic;
using UnityEngine;

public sealed class BuglyAgent
{
	public delegate void LogCallbackDelegate(string condition, string stackTrace, LogType type);

	private static readonly string GAME_AGENT_CLASS;

	private static readonly int TYPE_U3D_CRASH;

	private static readonly int GAME_TYPE_UNITY;

	private static bool hasSetGameType;

	private static AndroidJavaClass _gameAgentClass;

	private static string _configChannel;

	private static string _configVersion;

	private static string _configUser;

	private static long _configDelayTime;

	private static bool _configCrashReporterPackage;

	private static bool _isInitialized;

	private static LogSeverity _autoReportLogLevel;

	private static int _crashReporterType;

	private static string _crashReporterPackage;

	private static bool _debugMode;

	private static bool _autoQuitApplicationAfterReport;

	private static readonly int EXCEPTION_TYPE_UNCAUGHT;

	private static readonly int EXCEPTION_TYPE_CAUGHT;

	private static readonly string _pluginVersion;

	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler;

	private static bool _uncaughtAutoReportOnce;

	public static AndroidJavaClass GameAgent => null;

	public static string PluginVersion => "";

	public static bool IsInitialized => false;

	public static bool AutoQuitApplicationAfterReport => false;

	private static event LogCallbackDelegate _LogCallbackEventHandler
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void ConfigCrashReporter(int type, int logLevel)
	{
	}

	public static void InitWithAppId(string appId)
	{
	}

	public static void EnableExceptionHandler()
	{
	}

	public static void RegisterLogCallback(LogCallbackDelegate handler)
	{
	}

	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler)
	{
	}

	public static void ReportException(Exception e, string message)
	{
	}

	public static void ReportException(string name, string message, string stackTrace)
	{
	}

	public static void UnregisterLogCallback(LogCallbackDelegate handler)
	{
	}

	public static void SetUserId(string userId)
	{
	}

	public static void SetScene(int sceneId)
	{
	}

	public static void AddSceneData(string key, string value)
	{
	}

	public static void ConfigDebugMode(bool enable)
	{
	}

	public static void ConfigAutoQuitApplication(bool autoQuit)
	{
	}

	public static void ConfigAutoReportLogLevel(LogSeverity level)
	{
	}

	public static void ConfigDefault(string channel, string version, string user, long delay)
	{
	}

	public static void DebugLog(string tag, string format, params object[] args)
	{
	}

	public static void PrintLog(LogSeverity level, string format, params object[] args)
	{
	}

	private static void ConfigDefaultBeforeInit(string channel, string version, string user, long delay)
	{
	}

	private static void ConfigCrashReporterPackage()
	{
	}

	private static void InitBuglyAgent(string appId)
	{
	}

	private static void EnableDebugMode(bool enable)
	{
	}

	private static void SetUserInfo(string userInfo)
	{
	}

	private static void ReportException(int type, string name, string reason, string stackTrace, bool quitProgram)
	{
	}

	private static void SetCurrentScene(int sceneId)
	{
	}

	private static void SetUnityVersion()
	{
	}

	private static void AddKeyAndValueInScene(string key, string value)
	{
	}

	private static void AddExtraDataWithException(string key, string value)
	{
	}

	private static void LogRecord(LogSeverity level, string message)
	{
	}

	private static void _SetCrashReporterType(int type)
	{
	}

	private static void _SetCrashReporterLogLevel(int logLevel)
	{
	}

	private static void _RegisterExceptionHandler()
	{
	}

	private static void _UnregisterExceptionHandler()
	{
	}

	private static void _OnLogCallbackHandler(string condition, string stackTrace, LogType type)
	{
	}

	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args)
	{
	}

	private static void _HandleException(Exception e, string message, bool uncaught)
	{
	}

	private static void _reportException(bool uncaught, string name, string reason, string stackTrace)
	{
	}

	private static void _HandleException(LogSeverity logLevel, string name, string message, string stackTrace, bool uncaught)
	{
	}
}
