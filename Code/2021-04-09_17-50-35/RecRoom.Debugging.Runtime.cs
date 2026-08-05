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
		[Cpp2IlInjected.Address(RVA = "0x2669FF0", Offset = "0x26693F0", VA = "0x182669FF0")]
		internal static bool IsAssignableTo(this Type self, Type other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DBAA90", Offset = "0x1DB9E90", VA = "0x181DBAA90")]
		internal static bool IsAssignableTo<T>(this Type self)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class DebugUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0xFE120", Offset = "0xFD520")]
		private static readonly ISet<(string, int)> seenFails;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0xFE640", Offset = "0xFDA40")]
		private static readonly IDictionary<(string, int), long> throttles;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0xFEC60", Offset = "0xFE060")]
		private static readonly IDictionary<(string, int), object> changes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3378750", Offset = "0x3377B50", VA = "0x183378750")]
		public static bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3379060", Offset = "0x3378460", VA = "0x183379060")]
		private static bool TestFlags(in LogFlags? flags, in LogFlags defaultFlag, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3378F80", Offset = "0x3378380", VA = "0x183378F80")]
		private static bool TestFlagsWithLevel(in LogFlags? flags, LogLevel level, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x33781B0", Offset = "0x33775B0", VA = "0x1833781B0")]
		public static bool Assert(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3378130", Offset = "0x3377530", VA = "0x183378130")]
		public static bool AssertDbg(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x33782B0", Offset = "0x33776B0", VA = "0x1833782B0")]
		public static void Fail(object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFB0", Offset = "0x5EC3B0", VA = "0x1805ECFB0")]
		public static T FailWithDbg<T>(object message, in T result, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3378E20", Offset = "0x3378220", VA = "0x183378E20")]
		public static void Log(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3378CC0", Offset = "0x33780C0", VA = "0x183378CC0")]
		public static void Log(Func<object> message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3378B60", Offset = "0x3377F60", VA = "0x183378B60")]
		public static void LogWarning(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3378A00", Offset = "0x3377E00", VA = "0x183378A00")]
		public static void LogError(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x33788A0", Offset = "0x3377CA0", VA = "0x1833788A0")]
		public static void LogError(Func<object> message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x33786D0", Offset = "0x3377AD0", VA = "0x1833786D0")]
		private static object Format(object message, in LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3378650", Offset = "0x3377A50", VA = "0x183378650")]
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
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3379690", Offset = "0x3378A90", VA = "0x183379690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static LogFlags LogFlags
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3379510", Offset = "0x3378910", VA = "0x183379510")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x33796F0", Offset = "0x3378AF0", VA = "0x1833796F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IRecRoomLogHandlerDependencies RecRoomLogHandlerDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3379570", Offset = "0x3378970", VA = "0x183379570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3379750", Offset = "0x3378B50", VA = "0x183379750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static bool ShowDuplicateLogs
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3379630", Offset = "0x3378A30", VA = "0x183379630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3379260", Offset = "0x3378660", VA = "0x183379260")]
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
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3DC540", Offset = "0x3DB940", VA = "0x1803DC540", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3CD650", Offset = "0x3CCA50", VA = "0x1803CD650")]
			public EmptyDisposable()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC540", Offset = "0x3DB940", VA = "0x1803DC540", Slot = "4")]
		public void LogSpam(float collectionSeconds, int spamThreshold, int logAmount, int exceptionAmount, string lastLog, string lastException, int lastLogCopies, int lastExceptionCopies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x33797B0", Offset = "0x3378BB0", VA = "0x1833797B0", Slot = "5")]
		public IDisposable UpdateAtRate(float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD650", Offset = "0x3CCA50", VA = "0x1803CD650")]
		public EmptyRecRoomLogHandlerDependencies()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IRecRoomLogHandlerDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LogSpam(float collectionSeconds, int spamThreshold, int logAmount, int exceptionAmount, string lastLog, string lastException, int lastLogCopies, int lastExceptionCopies);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable UpdateAtRate(float hz, Action<float> update);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class LeakDetector
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private struct Item
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public WeakReference WeakRef;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public int TickCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int InstanceID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public string Name;
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int NewLeakCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int PersistentLeakCount;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool FoundLeaks
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x39CF80", Offset = "0x39C380", VA = "0x18039CF80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public string Summary
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x39CFA0", Offset = "0x39C3A0", VA = "0x18039CFA0")]
				get
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly List<Item> generation0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly List<Item> generation1;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<Item> generation2;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly List<Item> IMMEDIATE_NEW_LEAKS;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly List<Item> IMMEDIATE_PERSISTENT_LEAKS;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static string generationName;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static bool isGenerationMarked;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3379D00", Offset = "0x3379100", VA = "0x183379D00")]
		public static void MarkGeneration([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3379AE0", Offset = "0x3378EE0", VA = "0x183379AE0")]
		public static Result CheckForLeaks()
		{
			return default(Result);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3379ED0", Offset = "0x33792D0", VA = "0x183379ED0")]
		private static void ProcessGeneration(List<Item> generation, List<Item> found, string label)
		{
		}
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct LogFlags : IEquatable<LogFlags>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[Flags]
		private enum LogFlags1
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Default = 1,
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			Debug = 2,
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			CircuitsV2Debug = 4,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			CircuitsV2RecRoomIntegration = 8,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			CircuitsV2Lifecycle = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			CircuitsV2Reduce = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			CircuitsV2Visualization = 0x40,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			CircuitsV2Heat = 0x80,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			CircuitsV2PlayerLogic = 0x100,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			RoomReset = 0x200,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			All = -1
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[Flags]
		private enum LogFlags2
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			All = -1
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly LogFlags None;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly LogFlags Default;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly LogFlags Debug;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly LogFlags CircuitsV2Debug;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly LogFlags CircuitsV2RecRoomIntegration;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly LogFlags CircuitsV2Lifecycle;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly LogFlags CircuitsV2Reduce;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly LogFlags CircuitsV2Visualization;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly LogFlags CircuitsV2Heat;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly LogFlags CircuitsV2PlayerLogic;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly LogFlags RoomReset;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly LogFlags All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly LogFlags1 _flags1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly LogFlags2 _flags2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly char _char0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly char _char1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly char _char2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly char _char3;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BB300", Offset = "0x2BA700", VA = "0x1802BB300")]
		private LogFlags(LogFlags1 flags1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x39CEF0", Offset = "0x39C2F0", VA = "0x18039CEF0")]
		private LogFlags(LogFlags1 flags1, LogFlags2 flags2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x39CF00", Offset = "0x39C300", VA = "0x18039CF00")]
		private LogFlags(char char0, char char1, char char2, char char3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x337AD40", Offset = "0x337A140", VA = "0x18337AD40")]
		public static LogFlags operator |(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x337AD20", Offset = "0x337A120", VA = "0x18337AD20")]
		public static LogFlags operator &(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x337AD60", Offset = "0x337A160", VA = "0x18337AD60")]
		public static bool operator !=(in LogFlags lhs, in LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x337A480", Offset = "0x3379880", VA = "0x18337A480")]
		private static (LogFlags1, LogFlags2) Deconstruct(in LogFlags self)
		{
			return default((LogFlags1, LogFlags2));
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x39CCA0", Offset = "0x39C0A0", VA = "0x18039CCA0", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39CCB0", Offset = "0x39C0B0", VA = "0x18039CCB0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39CD40", Offset = "0x39C140", VA = "0x18039CD40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x184ED70", Offset = "0x184E170", VA = "0x18184ED70")]
		private static void PartToString<T>(StringBuilder inSb, T flag, bool empty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x39CE00", Offset = "0x39C200", VA = "0x18039CE00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x39CDF0", Offset = "0x39C1F0", VA = "0x18039CDF0")]
		public bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39CC90", Offset = "0x39C090", VA = "0x18039CC90")]
		public string EncodeLogFlagsString(string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x39CC80", Offset = "0x39C080", VA = "0x18039CC80")]
		public string DecodeLogFlagsString(string value)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum LogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Log,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Error
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal sealed class RecRoomLogHandler : ILogHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct CachedLog : IEquatable<CachedLog>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public LogType LogType
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xBCF0", Offset = "0xB0F0", VA = "0x18000BCF0")]
				[CompilerGenerated]
				get
				{
					return default(LogType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public UnityEngine.Object Context
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xCF50", Offset = "0xC350", VA = "0x18000CF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public string Message
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xCF20", Offset = "0xC320", VA = "0x18000CF20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x277210", Offset = "0x276610", VA = "0x180277210")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x39CA70", Offset = "0x39BE70", VA = "0x18039CA70", Slot = "4")]
			public bool Equals(CachedLog obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private struct CachedException : IEquatable<CachedException>
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public Exception Exception
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6B80", Offset = "0x5F80", VA = "0x180006B80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public UnityEngine.Object Context
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0xCF50", Offset = "0xC350", VA = "0x18000CF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9A80", Offset = "0x8E80", VA = "0x180009A80")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x39C9E0", Offset = "0x39BDE0", VA = "0x18039C9E0", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly ILogHandler chainedLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private IDisposable updateAtRateToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int numLogs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int numExceptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private CachedLog? lastLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int logCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private CachedException? lastException;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int exceptionCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool enabled;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x337BAB0", Offset = "0x337AEB0", VA = "0x18337BAB0")]
		public RecRoomLogHandler(ILogHandler chainedLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x337B2A0", Offset = "0x337A6A0", VA = "0x18337B2A0")]
		public void SetActive(bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x337B510", Offset = "0x337A910", VA = "0x18337B510")]
		private void StaggeredUpdate(float _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x337AD80", Offset = "0x337A180", VA = "0x18337AD80", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x337B750", Offset = "0x337AB50", VA = "0x18337B750")]
		private void TryLogRepeatedException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x337AF70", Offset = "0x337A370", VA = "0x18337AF70", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x337B890", Offset = "0x337AC90", VA = "0x18337B890")]
		private void TryLogRepeatedLog()
		{
		}
	}
}
namespace RecRoom.Debugging.Json
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum CanConvertPredicate
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Assignable,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Equal
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class CanConvertPredicateExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1E7DDB0", Offset = "0x1E7D1B0", VA = "0x181E7DDB0")]
		public static Func<Type, bool> ToFunc<T>(this CanConvertPredicate self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x14C17F0", Offset = "0x14C0BF0", VA = "0x1814C17F0")]
		private static bool Assignable<T>(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1F486D0", Offset = "0x1F47AD0", VA = "0x181F486D0")]
		private static bool Equal<T>(Type objectType)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class FunctionalJsonConverter<T> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Func<Type, bool> canConvertFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Action<JsonWriter, T> writeJsonAction;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x21CC650", Offset = "0x21CBA50", VA = "0x1821CC650", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x21CC710", Offset = "0x21CBB10", VA = "0x1821CC710", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x21CCBE0", Offset = "0x21CBFE0", VA = "0x1821CCBE0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x21CCD40", Offset = "0x21CC140", VA = "0x1821CCD40")]
		internal FunctionalJsonConverter(Func<Type, bool> canConvertFunc, Action<JsonWriter, T> writeJsonAction)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class FunctionalJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1DBBB20", Offset = "0x1DBAF20", VA = "0x181DBBB20")]
		public static FunctionalJsonConverter<T> New<T>(Action<JsonWriter, T> writeJsonAction, CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class JsonConverters
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static JsonConverter QuaternionJsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3379960", Offset = "0x3378D60", VA = "0x183379960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static JsonConverter StringEnumConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x33799C0", Offset = "0x3378DC0", VA = "0x1833799C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static JsonConverter UnityObjectJsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3379A20", Offset = "0x3378E20", VA = "0x183379A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static JsonConverter Vector3JsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3379A80", Offset = "0x3378E80", VA = "0x183379A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ToStringJsonConverter<T> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Func<Type, bool> canConvertFunc;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x21DFDC0", Offset = "0x21DF1C0", VA = "0x1821DFDC0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x21DFE20", Offset = "0x21DF220", VA = "0x1821DFE20", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x21DFEF0", Offset = "0x21DF2F0", VA = "0x1821DFEF0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x21DFFF0", Offset = "0x21DF3F0", VA = "0x1821DFFF0")]
		internal ToStringJsonConverter(Func<Type, bool> canConvertFunc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ToStringJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC35A0", Offset = "0x1DC29A0", VA = "0x181DC35A0")]
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
