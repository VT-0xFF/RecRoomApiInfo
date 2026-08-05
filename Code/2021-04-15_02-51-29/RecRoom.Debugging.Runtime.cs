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
		[Cpp2IlInjected.Address(RVA = "0xA23F00", Offset = "0xA22700", VA = "0x180A23F00")]
		internal static bool IsAssignableTo(this Type self, Type other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23AE8B0", Offset = "0x23AD0B0", VA = "0x1823AE8B0")]
		internal static bool IsAssignableTo<T>(this Type self)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class DebugUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x111FB0", Offset = "0x1113B0")]
		private static readonly ISet<(string, int)> seenFails;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1122A0", Offset = "0x1116A0")]
		private static readonly IDictionary<(string, int), long> throttles;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1128C0", Offset = "0x111CC0")]
		private static readonly IDictionary<(string, int), object> changes;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x33E9E50", Offset = "0x33E8650", VA = "0x1833E9E50")]
		public static bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x33EA760", Offset = "0x33E8F60", VA = "0x1833EA760")]
		private static bool TestFlags(in LogFlags? flags, in LogFlags defaultFlag, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x33EA680", Offset = "0x33E8E80", VA = "0x1833EA680")]
		private static bool TestFlagsWithLevel(in LogFlags? flags, LogLevel level, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x33E98B0", Offset = "0x33E80B0", VA = "0x1833E98B0")]
		public static bool Assert(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x33E9830", Offset = "0x33E8030", VA = "0x1833E9830")]
		public static bool AssertDbg(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x33E99B0", Offset = "0x33E81B0", VA = "0x1833E99B0")]
		public static void Fail(object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x50F540", Offset = "0x50DD40", VA = "0x18050F540")]
		public static T FailWithDbg<T>(object message, in T result, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x33EA520", Offset = "0x33E8D20", VA = "0x1833EA520")]
		public static void Log(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x33EA3C0", Offset = "0x33E8BC0", VA = "0x1833EA3C0")]
		public static void Log(Func<object> message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x33EA260", Offset = "0x33E8A60", VA = "0x1833EA260")]
		public static void LogWarning(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x33EA100", Offset = "0x33E8900", VA = "0x1833EA100")]
		public static void LogError(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x33E9FA0", Offset = "0x33E87A0", VA = "0x1833E9FA0")]
		public static void LogError(Func<object> message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x33E9DD0", Offset = "0x33E85D0", VA = "0x1833E9DD0")]
		private static object Format(object message, in LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x33E9D50", Offset = "0x33E8550", VA = "0x1833E9D50")]
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
			[Cpp2IlInjected.Address(RVA = "0x33EAD90", Offset = "0x33E9590", VA = "0x1833EAD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static LogFlags LogFlags
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x33EAC10", Offset = "0x33E9410", VA = "0x1833EAC10")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x33EADF0", Offset = "0x33E95F0", VA = "0x1833EADF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IRecRoomLogHandlerDependencies RecRoomLogHandlerDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x33EAC70", Offset = "0x33E9470", VA = "0x1833EAC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x33EAE50", Offset = "0x33E9650", VA = "0x1833EAE50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static bool ShowDuplicateLogs
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x33EAD30", Offset = "0x33E9530", VA = "0x1833EAD30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x33EA960", Offset = "0x33E9160", VA = "0x1833EA960")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3D3670", Offset = "0x3D1E70", VA = "0x1803D3670")]
			public EmptyDisposable()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "4")]
		public void LogSpam(float collectionSeconds, int spamThreshold, int logAmount, int exceptionAmount, string lastLog, string lastException, int lastLogCopies, int lastExceptionCopies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x33EAEB0", Offset = "0x33E96B0", VA = "0x1833EAEB0", Slot = "5")]
		public IDisposable UpdateAtRate(float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3670", Offset = "0x3D1E70", VA = "0x1803D3670")]
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
				[Cpp2IlInjected.Address(RVA = "0x3A2430", Offset = "0x3A1830", VA = "0x1803A2430")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public string Summary
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x3A2450", Offset = "0x3A1850", VA = "0x1803A2450")]
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
		[Cpp2IlInjected.Address(RVA = "0x33EB400", Offset = "0x33E9C00", VA = "0x1833EB400")]
		public static void MarkGeneration([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x33EB1E0", Offset = "0x33E99E0", VA = "0x1833EB1E0")]
		public static Result CheckForLeaks()
		{
			return default(Result);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x33EB5D0", Offset = "0x33E9DD0", VA = "0x1833EB5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BED60", Offset = "0x2BE160", VA = "0x1802BED60")]
		private LogFlags(LogFlags1 flags1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3A23A0", Offset = "0x3A17A0", VA = "0x1803A23A0")]
		private LogFlags(LogFlags1 flags1, LogFlags2 flags2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3A23B0", Offset = "0x3A17B0", VA = "0x1803A23B0")]
		private LogFlags(char char0, char char1, char char2, char char3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x33EC440", Offset = "0x33EAC40", VA = "0x1833EC440")]
		public static LogFlags operator |(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x33EC420", Offset = "0x33EAC20", VA = "0x1833EC420")]
		public static LogFlags operator &(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x33EC460", Offset = "0x33EAC60", VA = "0x1833EC460")]
		public static bool operator !=(in LogFlags lhs, in LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x33EBB80", Offset = "0x33EA380", VA = "0x1833EBB80")]
		private static (LogFlags1, LogFlags2) Deconstruct(in LogFlags self)
		{
			return default((LogFlags1, LogFlags2));
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3A2150", Offset = "0x3A1550", VA = "0x1803A2150", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3A2160", Offset = "0x3A1560", VA = "0x1803A2160", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3A21F0", Offset = "0x3A15F0", VA = "0x1803A21F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1F35730", Offset = "0x1F33F30", VA = "0x181F35730")]
		private static void PartToString<T>(StringBuilder inSb, T flag, bool empty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A22B0", Offset = "0x3A16B0", VA = "0x1803A22B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A22A0", Offset = "0x3A16A0", VA = "0x1803A22A0")]
		public bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A2140", Offset = "0x3A1540", VA = "0x1803A2140")]
		public string EncodeLogFlagsString(string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A2130", Offset = "0x3A1530", VA = "0x1803A2130")]
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
				[Cpp2IlInjected.Address(RVA = "0x2D90", Offset = "0x2190", VA = "0x180002D90")]
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
				[Cpp2IlInjected.Address(RVA = "0x8740", Offset = "0x7B40", VA = "0x180008740")]
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
				[Cpp2IlInjected.Address(RVA = "0x8730", Offset = "0x7B30", VA = "0x180008730")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x277A80", Offset = "0x276E80", VA = "0x180277A80")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3A1F20", Offset = "0x3A1320", VA = "0x1803A1F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8720", Offset = "0x7B20", VA = "0x180008720")]
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
				[Cpp2IlInjected.Address(RVA = "0x8740", Offset = "0x7B40", VA = "0x180008740")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x100E0", Offset = "0xF4E0", VA = "0x1800100E0")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3A1E90", Offset = "0x3A1290", VA = "0x1803A1E90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x33ED1B0", Offset = "0x33EB9B0", VA = "0x1833ED1B0")]
		public RecRoomLogHandler(ILogHandler chainedLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x33EC9A0", Offset = "0x33EB1A0", VA = "0x1833EC9A0")]
		public void SetActive(bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x33ECC10", Offset = "0x33EB410", VA = "0x1833ECC10")]
		private void StaggeredUpdate(float _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x33EC480", Offset = "0x33EAC80", VA = "0x1833EC480", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x33ECE50", Offset = "0x33EB650", VA = "0x1833ECE50")]
		private void TryLogRepeatedException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x33EC670", Offset = "0x33EAE70", VA = "0x1833EC670", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x33ECF90", Offset = "0x33EB790", VA = "0x1833ECF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x24B8C30", Offset = "0x24B7430", VA = "0x1824B8C30")]
		public static Func<Type, bool> ToFunc<T>(this CanConvertPredicate self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1FD17E0", Offset = "0x1FCFFE0", VA = "0x181FD17E0")]
		private static bool Assignable<T>(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x23AC420", Offset = "0x23AAC20", VA = "0x1823AC420")]
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
		[Cpp2IlInjected.Address(RVA = "0x2692950", Offset = "0x2691150", VA = "0x182692950", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2692A10", Offset = "0x2691210", VA = "0x182692A10", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2692EE0", Offset = "0x26916E0", VA = "0x182692EE0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2693040", Offset = "0x2691840", VA = "0x182693040")]
		internal FunctionalJsonConverter(Func<Type, bool> canConvertFunc, Action<JsonWriter, T> writeJsonAction)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class FunctionalJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x222FB90", Offset = "0x222E390", VA = "0x18222FB90")]
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
			[Cpp2IlInjected.Address(RVA = "0x33EB060", Offset = "0x33E9860", VA = "0x1833EB060")]
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
			[Cpp2IlInjected.Address(RVA = "0x33EB0C0", Offset = "0x33E98C0", VA = "0x1833EB0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x33EB120", Offset = "0x33E9920", VA = "0x1833EB120")]
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
			[Cpp2IlInjected.Address(RVA = "0x33EB180", Offset = "0x33E9980", VA = "0x1833EB180")]
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
		[Cpp2IlInjected.Address(RVA = "0x26A92A0", Offset = "0x26A7AA0", VA = "0x1826A92A0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x26A9300", Offset = "0x26A7B00", VA = "0x1826A9300", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x26A93D0", Offset = "0x26A7BD0", VA = "0x1826A93D0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x26A94D0", Offset = "0x26A7CD0", VA = "0x1826A94D0")]
		internal ToStringJsonConverter(Func<Type, bool> canConvertFunc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ToStringJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x223A040", Offset = "0x2238840", VA = "0x18223A040")]
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
