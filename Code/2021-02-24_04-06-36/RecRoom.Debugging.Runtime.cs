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
		[Cpp2IlInjected.Address(RVA = "0x2269390", Offset = "0x2268390", VA = "0x182269390")]
		internal static bool IsAssignableTo(this Type self, Type other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1A3EBD0", Offset = "0x1A3DBD0", VA = "0x181A3EBD0")]
		internal static bool IsAssignableTo<T>(this Type self)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class DebugUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2AD80", Offset = "0x2A180")]
		private static readonly ISet<(string, int)> seenFails;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2B0D0", Offset = "0x2A4D0")]
		private static readonly IDictionary<(string, int), long> throttles;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2B340", Offset = "0x2A740")]
		private static readonly IDictionary<(string, int), object> changes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3299EF0", Offset = "0x3298EF0", VA = "0x183299EF0")]
		public static bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x329A6A0", Offset = "0x32996A0", VA = "0x18329A6A0")]
		private static bool TestFlags(in LogFlags? flags, in LogFlags defaultFlag, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x329A5C0", Offset = "0x32995C0", VA = "0x18329A5C0")]
		private static bool TestFlagsWithLevel(in LogFlags? flags, LogLevel level, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3299950", Offset = "0x3298950", VA = "0x183299950")]
		public static bool Assert(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x32998D0", Offset = "0x32988D0", VA = "0x1832998D0")]
		public static bool AssertDbg(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3299A50", Offset = "0x3298A50", VA = "0x183299A50")]
		public static void Fail(object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8A0", Offset = "0x5FC8A0", VA = "0x1805FD8A0")]
		public static T FailWithDbg<T>(object message, in T result, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x329A460", Offset = "0x3299460", VA = "0x18329A460")]
		public static void Log(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x329A300", Offset = "0x3299300", VA = "0x18329A300")]
		public static void Log(Func<object> message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x329A1A0", Offset = "0x32991A0", VA = "0x18329A1A0")]
		public static void LogWarning(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x329A040", Offset = "0x3299040", VA = "0x18329A040")]
		public static void LogError(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3299E70", Offset = "0x3298E70", VA = "0x183299E70")]
		private static object Format(object message, in LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3299DF0", Offset = "0x3298DF0", VA = "0x183299DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x329ACD0", Offset = "0x3299CD0", VA = "0x18329ACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static LogFlags LogFlags
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x329AB50", Offset = "0x3299B50", VA = "0x18329AB50")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x329AD30", Offset = "0x3299D30", VA = "0x18329AD30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IRecRoomLogHandlerDependencies RecRoomLogHandlerDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x329ABB0", Offset = "0x3299BB0", VA = "0x18329ABB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x329AD90", Offset = "0x3299D90", VA = "0x18329AD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static bool ShowDuplicateLogs
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x329AC70", Offset = "0x3299C70", VA = "0x18329AC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x329A8A0", Offset = "0x32998A0", VA = "0x18329A8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D7110", Offset = "0x3D6110", VA = "0x1803D7110", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3CA300", Offset = "0x3C9300", VA = "0x1803CA300")]
			public EmptyDisposable()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D7110", Offset = "0x3D6110", VA = "0x1803D7110", Slot = "4")]
		public void LogSpam(float collectionSeconds, int spamThreshold, int logAmount, int exceptionAmount, string lastLog, string lastException, int lastLogCopies, int lastExceptionCopies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x329ADF0", Offset = "0x3299DF0", VA = "0x18329ADF0", Slot = "5")]
		public IDisposable UpdateAtRate(float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3CA300", Offset = "0x3C9300", VA = "0x1803CA300")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FB850", Offset = "0x1FAC50", VA = "0x1801FB850")]
		private LogFlags(LogFlags1 flags1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x30D780", Offset = "0x30CB80", VA = "0x18030D780")]
		private LogFlags(LogFlags1 flags1, LogFlags2 flags2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x30D790", Offset = "0x30CB90", VA = "0x18030D790")]
		private LogFlags(char char0, char char1, char char2, char char3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x329BC20", Offset = "0x329AC20", VA = "0x18329BC20")]
		public static LogFlags operator |(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x329BC00", Offset = "0x329AC00", VA = "0x18329BC00")]
		public static LogFlags operator &(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x329BC40", Offset = "0x329AC40", VA = "0x18329BC40")]
		public static bool operator !=(in LogFlags lhs, in LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x329B380", Offset = "0x329A380", VA = "0x18329B380")]
		private static (LogFlags1, LogFlags2) Deconstruct(in LogFlags self)
		{
			return default((LogFlags1, LogFlags2));
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x30D530", Offset = "0x30C930", VA = "0x18030D530", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x30D540", Offset = "0x30C940", VA = "0x18030D540", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x30D5D0", Offset = "0x30C9D0", VA = "0x18030D5D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xF3E0C0", Offset = "0xF3D0C0", VA = "0x180F3E0C0")]
		private static void PartToString<T>(StringBuilder inSb, T flag, bool empty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x30D690", Offset = "0x30CA90", VA = "0x18030D690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x30D680", Offset = "0x30CA80", VA = "0x18030D680")]
		public bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x30D520", Offset = "0x30C920", VA = "0x18030D520")]
		public string EncodeLogFlagsString(string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x30D510", Offset = "0x30C910", VA = "0x18030D510")]
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
				[Cpp2IlInjected.Address(RVA = "0x164C40", Offset = "0x164040", VA = "0x180164C40")]
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
				[Cpp2IlInjected.Address(RVA = "0x165F50", Offset = "0x165350", VA = "0x180165F50")]
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
				[Cpp2IlInjected.Address(RVA = "0x169B90", Offset = "0x168F90", VA = "0x180169B90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1BA890", Offset = "0x1B9C90", VA = "0x1801BA890")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x30D320", Offset = "0x30C720", VA = "0x18030D320", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x165F40", Offset = "0x165340", VA = "0x180165F40")]
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
				[Cpp2IlInjected.Address(RVA = "0x165F50", Offset = "0x165350", VA = "0x180165F50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x16EBB0", Offset = "0x16DFB0", VA = "0x18016EBB0")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x30D290", Offset = "0x30C690", VA = "0x18030D290", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x329C990", Offset = "0x329B990", VA = "0x18329C990")]
		public RecRoomLogHandler(ILogHandler chainedLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x329C180", Offset = "0x329B180", VA = "0x18329C180")]
		public void SetActive(bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x329C3F0", Offset = "0x329B3F0", VA = "0x18329C3F0")]
		private void StaggeredUpdate(float _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x329BC60", Offset = "0x329AC60", VA = "0x18329BC60", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x329C630", Offset = "0x329B630", VA = "0x18329C630")]
		private void TryLogRepeatedException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x329BE50", Offset = "0x329AE50", VA = "0x18329BE50", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x329C770", Offset = "0x329B770", VA = "0x18329C770")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CE73E0", Offset = "0x1CE63E0", VA = "0x181CE73E0")]
		public static Func<Type, bool> ToFunc<T>(this CanConvertPredicate self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xE1E640", Offset = "0xE1D640", VA = "0x180E1E640")]
		private static bool Assignable<T>(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1A3C520", Offset = "0x1A3B520", VA = "0x181A3C520")]
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
		[Cpp2IlInjected.Address(RVA = "0x17D0A00", Offset = "0x17CFA00", VA = "0x1817D0A00", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x17D0AC0", Offset = "0x17CFAC0", VA = "0x1817D0AC0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x17D0F90", Offset = "0x17CFF90", VA = "0x1817D0F90", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x17D10F0", Offset = "0x17D00F0", VA = "0x1817D10F0")]
		internal FunctionalJsonConverter(Func<Type, bool> canConvertFunc, Action<JsonWriter, T> writeJsonAction)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class FunctionalJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1ACC8A0", Offset = "0x1ACB8A0", VA = "0x181ACC8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x329AFA0", Offset = "0x3299FA0", VA = "0x18329AFA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x329B000", Offset = "0x329A000", VA = "0x18329B000")]
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
			[Cpp2IlInjected.Address(RVA = "0x329B060", Offset = "0x329A060", VA = "0x18329B060")]
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
			[Cpp2IlInjected.Address(RVA = "0x329B0C0", Offset = "0x329A0C0", VA = "0x18329B0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x17E1B40", Offset = "0x17E0B40", VA = "0x1817E1B40", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x17E1BA0", Offset = "0x17E0BA0", VA = "0x1817E1BA0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x17E1C70", Offset = "0x17E0C70", VA = "0x1817E1C70", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x17E1D70", Offset = "0x17E0D70", VA = "0x1817E1D70")]
		internal ToStringJsonConverter(Func<Type, bool> canConvertFunc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class ToStringJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1ADFD10", Offset = "0x1ADED10", VA = "0x181ADFD10")]
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
