using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;
using Valve.Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class DebugExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x22F4900", Offset = "0x22F3B00", VA = "0x1822F4900")]
		internal static bool IsAssignableTo(this Type self, Type other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1875300", Offset = "0x1874500", VA = "0x181875300")]
		internal static bool IsAssignableTo<T>(this Type self)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class DebugUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2F560", Offset = "0x2E960")]
		private static readonly ISet<(string, int)> seenFails;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2F7C0", Offset = "0x2EBC0")]
		private static readonly IDictionary<(string, int), long> throttles;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2FB20", Offset = "0x2EF20")]
		private static readonly IDictionary<(string, int), object> changes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x32CA7A0", Offset = "0x32C99A0", VA = "0x1832CA7A0")]
		public static bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x32CAF50", Offset = "0x32CA150", VA = "0x1832CAF50")]
		private static bool TestFlags(in LogFlags? flags, in LogFlags defaultFlag, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x32CAE70", Offset = "0x32CA070", VA = "0x1832CAE70")]
		private static bool TestFlagsWithLevel(in LogFlags? flags, LogLevel level, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x32CA200", Offset = "0x32C9400", VA = "0x1832CA200")]
		public static bool Assert(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x32CA180", Offset = "0x32C9380", VA = "0x1832CA180")]
		public static bool AssertDbg(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x32CA300", Offset = "0x32C9500", VA = "0x1832CA300")]
		public static void Fail(object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6471A0", Offset = "0x6463A0", VA = "0x1806471A0")]
		public static T FailWithDbg<T>(object message, in T result, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x32CAD10", Offset = "0x32C9F10", VA = "0x1832CAD10")]
		public static void Log(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x32CABB0", Offset = "0x32C9DB0", VA = "0x1832CABB0")]
		public static void Log(Func<object> message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x32CAA50", Offset = "0x32C9C50", VA = "0x1832CAA50")]
		public static void LogWarning(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x32CA8F0", Offset = "0x32C9AF0", VA = "0x1832CA8F0")]
		public static void LogError(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x32CA720", Offset = "0x32C9920", VA = "0x1832CA720")]
		private static object Format(object message, in LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x32CA6A0", Offset = "0x32C98A0", VA = "0x1832CA6A0")]
		private static object Format(Func<object> message, in LogFlags flags)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class DebuggingStatics
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly RecRoomLogHandler _recRoomLogHandler;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static bool _useRecRoomLogHandler;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JsonConverter[] DefaultJsonConverters
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x32CB580", Offset = "0x32CA780", VA = "0x1832CB580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static LogFlags LogFlags
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x32CB400", Offset = "0x32CA600", VA = "0x1832CB400")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x32CB5E0", Offset = "0x32CA7E0", VA = "0x1832CB5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IRecRoomLogHandlerDependencies RecRoomLogHandlerDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x32CB460", Offset = "0x32CA660", VA = "0x1832CB460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x32CB640", Offset = "0x32CA840", VA = "0x1832CB640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static bool ShowDuplicateLogs
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x32CB520", Offset = "0x32CA720", VA = "0x1832CB520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x32CB150", Offset = "0x32CA350", VA = "0x1832CB150")]
		public static void UpdateRecRoomLogHandlerActive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal sealed class EmptyRecRoomLogHandlerDependencies : IRecRoomLogHandlerDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private sealed class EmptyDisposable : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3DAED0", Offset = "0x3DA0D0", VA = "0x1803DAED0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3CE300", Offset = "0x3CD500", VA = "0x1803CE300")]
			public EmptyDisposable()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3DAED0", Offset = "0x3DA0D0", VA = "0x1803DAED0", Slot = "4")]
		public void LogSpam(float collectionSeconds, int spamThreshold, int logAmount, int exceptionAmount, string lastLog, string lastException, int lastLogCopies, int lastExceptionCopies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x32CB6A0", Offset = "0x32CA8A0", VA = "0x1832CB6A0", Slot = "5")]
		public IDisposable UpdateAtRate(float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3CE300", Offset = "0x3CD500", VA = "0x1803CE300")]
		public EmptyRecRoomLogHandlerDependencies()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IRecRoomLogHandlerDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LogSpam(float collectionSeconds, int spamThreshold, int logAmount, int exceptionAmount, string lastLog, string lastException, int lastLogCopies, int lastExceptionCopies);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable UpdateAtRate(float hz, Action<float> update);
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct LogFlags : IEquatable<LogFlags>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[Flags]
		private enum LogFlags1
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			Default = 1,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			Debug = 2,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			CircuitsV2Debug = 4,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			CircuitsV2RecRoomIntegration = 8,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			CircuitsV2Lifecycle = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			CircuitsV2Reduce = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			CircuitsV2Visualization = 0x40,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			CircuitsV2Heat = 0x80,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			RoomReset = 0x100,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			All = -1
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[Flags]
		private enum LogFlags2
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			All = -1
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly LogFlags None;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly LogFlags Default;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly LogFlags Debug;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly LogFlags CircuitsV2Debug;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly LogFlags CircuitsV2RecRoomIntegration;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly LogFlags CircuitsV2Lifecycle;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly LogFlags CircuitsV2Reduce;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly LogFlags CircuitsV2Visualization;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly LogFlags CircuitsV2Heat;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly LogFlags RoomReset;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly LogFlags All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LogFlags1 _flags1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly LogFlags2 _flags2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly char _char0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly char _char1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly char _char2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly char _char3;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4F0", Offset = "0x1FC8F0", VA = "0x1801FD4F0")]
		private LogFlags(LogFlags1 flags1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3118F0", Offset = "0x310CF0", VA = "0x1803118F0")]
		private LogFlags(LogFlags1 flags1, LogFlags2 flags2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x311900", Offset = "0x310D00", VA = "0x180311900")]
		private LogFlags(char char0, char char1, char char2, char char3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x32CC4D0", Offset = "0x32CB6D0", VA = "0x1832CC4D0")]
		public static LogFlags operator |(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x32CC4B0", Offset = "0x32CB6B0", VA = "0x1832CC4B0")]
		public static LogFlags operator &(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x32CC4F0", Offset = "0x32CB6F0", VA = "0x1832CC4F0")]
		public static bool operator !=(in LogFlags lhs, in LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x32CBC30", Offset = "0x32CAE30", VA = "0x1832CBC30")]
		private static (LogFlags1, LogFlags2) Deconstruct(in LogFlags self)
		{
			return default((LogFlags1, LogFlags2));
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3116A0", Offset = "0x310AA0", VA = "0x1803116A0", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3116B0", Offset = "0x310AB0", VA = "0x1803116B0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x311740", Offset = "0x310B40", VA = "0x180311740", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x15D8690", Offset = "0x15D7890", VA = "0x1815D8690")]
		private static void PartToString<T>(StringBuilder inSb, T flag, bool empty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x311800", Offset = "0x310C00", VA = "0x180311800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3117F0", Offset = "0x310BF0", VA = "0x1803117F0")]
		public bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x311690", Offset = "0x310A90", VA = "0x180311690")]
		public string EncodeLogFlagsString(string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x311680", Offset = "0x310A80", VA = "0x180311680")]
		public string DecodeLogFlagsString(string value)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum LogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Log,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Error
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal sealed class RecRoomLogHandler : ILogHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private struct CachedLog : IEquatable<CachedLog>
		{
			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public LogType LogType
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x166700", Offset = "0x165B00", VA = "0x180166700")]
				[CompilerGenerated]
				get
				{
					return default(LogType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public UnityEngine.Object Context
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x1681F0", Offset = "0x1675F0", VA = "0x1801681F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public string Message
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x16BEB0", Offset = "0x16B2B0", VA = "0x18016BEB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1B3750", Offset = "0x1B2B50", VA = "0x1801B3750")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x311490", Offset = "0x310890", VA = "0x180311490", Slot = "4")]
			public bool Equals(CachedLog obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private struct CachedException : IEquatable<CachedException>
		{
			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public Exception Exception
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x166A70", Offset = "0x165E70", VA = "0x180166A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public UnityEngine.Object Context
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x1681F0", Offset = "0x1675F0", VA = "0x1801681F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x16F3E0", Offset = "0x16E7E0", VA = "0x18016F3E0")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x311400", Offset = "0x310800", VA = "0x180311400", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly ILogHandler chainedLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IDisposable updateAtRateToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int numLogs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int numExceptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CachedLog? lastLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int logCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CachedException? lastException;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int exceptionCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool enabled;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32CD240", Offset = "0x32CC440", VA = "0x1832CD240")]
		public RecRoomLogHandler(ILogHandler chainedLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32CCA30", Offset = "0x32CBC30", VA = "0x1832CCA30")]
		public void SetActive(bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x32CCCA0", Offset = "0x32CBEA0", VA = "0x1832CCCA0")]
		private void StaggeredUpdate(float _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x32CC510", Offset = "0x32CB710", VA = "0x1832CC510", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x32CCEE0", Offset = "0x32CC0E0", VA = "0x1832CCEE0")]
		private void TryLogRepeatedException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x32CC700", Offset = "0x32CB900", VA = "0x1832CC700", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32CD020", Offset = "0x32CC220", VA = "0x1832CD020")]
		private void TryLogRepeatedLog()
		{
		}
	}
}
namespace RecRoom.Debugging.Json
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum CanConvertPredicate
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Assignable,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Equal
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class CanConvertPredicateExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x256A1A0", Offset = "0x25693A0", VA = "0x18256A1A0")]
		public static Func<Type, bool> ToFunc<T>(this CanConvertPredicate self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x11EAD30", Offset = "0x11E9F30", VA = "0x1811EAD30")]
		private static bool Assignable<T>(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1872690", Offset = "0x1871890", VA = "0x181872690")]
		private static bool Equal<T>(Type objectType)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class FunctionalJsonConverter<T> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Func<Type, bool> canConvertFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Action<JsonWriter, T> writeJsonAction;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA260", Offset = "0x2AF9460", VA = "0x182AFA260", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA320", Offset = "0x2AF9520", VA = "0x182AFA320", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA7F0", Offset = "0x2AF99F0", VA = "0x182AFA7F0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA950", Offset = "0x2AF9B50", VA = "0x182AFA950")]
		internal FunctionalJsonConverter(Func<Type, bool> canConvertFunc, Action<JsonWriter, T> writeJsonAction)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class FunctionalJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x18760A0", Offset = "0x18752A0", VA = "0x1818760A0")]
		public static FunctionalJsonConverter<T> New<T>(Action<JsonWriter, T> writeJsonAction, CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JsonConverters
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static JsonConverter QuaternionJsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x32CB850", Offset = "0x32CAA50", VA = "0x1832CB850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static JsonConverter StringEnumConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x32CB8B0", Offset = "0x32CAAB0", VA = "0x1832CB8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static JsonConverter UnityObjectJsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x32CB910", Offset = "0x32CAB10", VA = "0x1832CB910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static JsonConverter Vector3JsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x32CB970", Offset = "0x32CAB70", VA = "0x1832CB970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class ToStringJsonConverter<T> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly Func<Type, bool> canConvertFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B11ED0", Offset = "0x2B110D0", VA = "0x182B11ED0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B11F30", Offset = "0x2B11130", VA = "0x182B11F30", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B12000", Offset = "0x2B11200", VA = "0x182B12000", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x214F9D0", Offset = "0x214EBD0", VA = "0x18214F9D0")]
		internal ToStringJsonConverter(Func<Type, bool> canConvertFunc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class ToStringJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x187E7F0", Offset = "0x187D9F0", VA = "0x18187E7F0")]
		public static ToStringJsonConverter<T> New<T>(CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
