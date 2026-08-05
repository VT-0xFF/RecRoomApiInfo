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
		[Cpp2IlInjected.Address(RVA = "0x18D7530", Offset = "0x18D6530", VA = "0x1818D7530")]
		public static LogString ClassName<T>(this T _)
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x18D75C0", Offset = "0x18D65C0", VA = "0x1818D75C0")]
		public static LogString QualifiedFnName<T>(this T self, [CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x24DB9D0", Offset = "0x24DA9D0", VA = "0x1824DB9D0")]
		internal static bool IsAssignableTo(this Type self, Type other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1C02EF0", Offset = "0x1C01EF0", VA = "0x181C02EF0")]
		internal static bool IsAssignableTo<T>(this Type self)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class DebugUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x55340", Offset = "0x54740")]
		private static readonly ISet<(string, int)> seenFails;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x56BE0", Offset = "0x55FE0")]
		private static readonly IDictionary<(string, int), long> throttles;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x57050", Offset = "0x56450")]
		private static readonly IDictionary<(string, int), object> changes;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x34C8CC0", Offset = "0x34C7CC0", VA = "0x1834C8CC0")]
		public static bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x34C95D0", Offset = "0x34C85D0", VA = "0x1834C95D0")]
		private static bool TestFlags(in LogFlags? flags, in LogFlags defaultFlag, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x34C94F0", Offset = "0x34C84F0", VA = "0x1834C94F0")]
		private static bool TestFlagsWithLevel(in LogFlags? flags, LogLevel level, out LogFlags flagsActual)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x34C8720", Offset = "0x34C7720", VA = "0x1834C8720")]
		public static bool Assert(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x34C86A0", Offset = "0x34C76A0", VA = "0x1834C86A0")]
		public static bool AssertDbg(bool condition, object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x34C8820", Offset = "0x34C7820", VA = "0x1834C8820")]
		public static void Fail(object message, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5891D0", VA = "0x18058A1D0")]
		public static T FailWithDbg<T>(object message, in T result, [Optional] in LogFlags? flags, LogLevel level = LogLevel.Error)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x34C9390", Offset = "0x34C8390", VA = "0x1834C9390")]
		public static void Log(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x34C9230", Offset = "0x34C8230", VA = "0x1834C9230")]
		public static void Log(Func<object> message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x34C90D0", Offset = "0x34C80D0", VA = "0x1834C90D0")]
		public static void LogWarning(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x34C8F70", Offset = "0x34C7F70", VA = "0x1834C8F70")]
		public static void LogError(object message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x34C8E10", Offset = "0x34C7E10", VA = "0x1834C8E10")]
		public static void LogError(Func<object> message, [Optional] in LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x34C8C40", Offset = "0x34C7C40", VA = "0x1834C8C40")]
		private static object Format(object message, in LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x34C8BC0", Offset = "0x34C7BC0", VA = "0x1834C8BC0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x34C9C00", Offset = "0x34C8C00", VA = "0x1834C9C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static LogFlags LogFlags
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x34C9A80", Offset = "0x34C8A80", VA = "0x1834C9A80")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x34C9C60", Offset = "0x34C8C60", VA = "0x1834C9C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static IRecRoomLogHandlerDependencies RecRoomLogHandlerDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x34C9AE0", Offset = "0x34C8AE0", VA = "0x1834C9AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x34C9CC0", Offset = "0x34C8CC0", VA = "0x1834C9CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static bool ShowDuplicateLogs
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x34C9BA0", Offset = "0x34C8BA0", VA = "0x1834C9BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x34C97D0", Offset = "0x34C87D0", VA = "0x1834C97D0")]
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
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3D8940", Offset = "0x3D7940", VA = "0x1803D8940", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3D80E0", Offset = "0x3D70E0", VA = "0x1803D80E0")]
			public EmptyDisposable()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D8940", Offset = "0x3D7940", VA = "0x1803D8940", Slot = "4")]
		public void LogSpam(float collectionSeconds, int spamThreshold, int logAmount, int exceptionAmount, string lastLog, string lastException, int lastLogCopies, int lastExceptionCopies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x34C9D20", Offset = "0x34C8D20", VA = "0x1834C9D20", Slot = "5")]
		public IDisposable UpdateAtRate(float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D80E0", Offset = "0x3D70E0", VA = "0x1803D80E0")]
		public EmptyRecRoomLogHandlerDependencies()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IRecRoomLogHandlerDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LogSpam(float collectionSeconds, int spamThreshold, int logAmount, int exceptionAmount, string lastLog, string lastException, int lastLogCopies, int lastExceptionCopies);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
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
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x34CC0C0", Offset = "0x34CB0C0", VA = "0x1834CC0C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public string Summary
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x34CC0D0", Offset = "0x34CB0D0", VA = "0x1834CC0D0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x34CA270", Offset = "0x34C9270", VA = "0x1834CA270")]
		public static void MarkGeneration([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x34CA050", Offset = "0x34C9050", VA = "0x1834CA050")]
		public static Result CheckForLeaks()
		{
			return default(Result);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x34CA440", Offset = "0x34C9440", VA = "0x1834CA440")]
		private static void ProcessGeneration(List<Item> generation, List<Item> found, string label)
		{
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct LogFlags : IEquatable<LogFlags>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[Flags]
		private enum LogFlags1
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			Default = 1,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Debug = 2,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			CircuitsV2Debug = 4,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			CircuitsV2RecRoomIntegration = 8,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			CircuitsV2Lifecycle = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			CircuitsV2Reduce = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			CircuitsV2Visualization = 0x40,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			CircuitsV2Heat = 0x80,
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			CircuitsV2PlayerLogic = 0x100,
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			RoomReset = 0x200,
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			CircuitsV2Memory = 0x400,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			SynchronizedFields = 0x800,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			All = -1
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[Flags]
		private enum LogFlags2
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			All = -1
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly LogFlags None;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly LogFlags Default;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Obsolete]
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
		public static readonly LogFlags CircuitsV2Memory;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly LogFlags RoomReset;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly LogFlags SynchronizedFields;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal static readonly LogFlags AllInternal;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Obsolete]
		public static readonly LogFlags All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LogFlags1 _flags1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly LogFlags2 _flags2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly char _char0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly char _char1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly char _char2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly char _char3;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1895C30", Offset = "0x1894C30", VA = "0x181895C30")]
		private LogFlags(LogFlags1 flags1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E10", Offset = "0x5D7E10", VA = "0x1805D8E10")]
		private LogFlags(LogFlags1 flags1, LogFlags2 flags2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x34CB2E0", Offset = "0x34CA2E0", VA = "0x1834CB2E0")]
		private LogFlags(char char0, char char1, char char2, char char3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x34CB320", Offset = "0x34CA320", VA = "0x1834CB320")]
		public static LogFlags operator |(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x34CB300", Offset = "0x34CA300", VA = "0x1834CB300")]
		public static LogFlags operator &(in LogFlags self, in LogFlags other)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x34CB340", Offset = "0x34CA340", VA = "0x1834CB340")]
		public static bool operator !=(in LogFlags lhs, in LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9F0", Offset = "0x34C99F0", VA = "0x1834CA9F0")]
		private static (LogFlags1, LogFlags2) Deconstruct(in LogFlags self)
		{
			return default((LogFlags1, LogFlags2));
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x34CAD10", Offset = "0x34C9D10", VA = "0x1834CAD10", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x34CAE10", Offset = "0x34C9E10", VA = "0x1834CAE10", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x34CAEA0", Offset = "0x34C9EA0", VA = "0x1834CAEA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x14D7640", Offset = "0x14D6640", VA = "0x1814D7640")]
		private static void PartToString<T>(StringBuilder inSb, T flag, bool empty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x34CAFF0", Offset = "0x34C9FF0", VA = "0x1834CAFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x34CAF50", Offset = "0x34C9F50", VA = "0x1834CAF50")]
		public bool HasFlags(in LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x34CAA40", Offset = "0x34C9A40", VA = "0x1834CAA40")]
		public string EncodeLogFlagsString(string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x34CA790", Offset = "0x34C9790", VA = "0x1834CA790")]
		public string DecodeLogFlagsString(string value)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum LogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Log,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Error
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct LogString
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly string Value;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6073B0", Offset = "0x6063B0", VA = "0x1806073B0")]
		public LogString(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5CB530", Offset = "0x5CA530", VA = "0x1805CB530")]
		public static implicit operator LogString(string other)
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x610B40", Offset = "0x60FB40", VA = "0x180610B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class RecRoomLogHandler : ILogHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private struct CachedLog : IEquatable<CachedLog>
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public LogType LogType
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6ED620", Offset = "0x6EC620", VA = "0x1806ED620")]
				[CompilerGenerated]
				get
				{
					return default(LogType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public UnityEngine.Object Context
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x610B50", Offset = "0x60FB50", VA = "0x180610B50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public string Message
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x426940", Offset = "0x425940", VA = "0x180426940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1449120", Offset = "0x1448120", VA = "0x181449120")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x34C85A0", Offset = "0x34C75A0", VA = "0x1834C85A0", Slot = "4")]
			public bool Equals(CachedLog obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private struct CachedException : IEquatable<CachedException>
		{
			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public Exception Exception
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x610B40", Offset = "0x60FB40", VA = "0x180610B40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public UnityEngine.Object Context
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x610B50", Offset = "0x60FB50", VA = "0x180610B50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4A0980", Offset = "0x49F980", VA = "0x1804A0980")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x34C8530", Offset = "0x34C7530", VA = "0x1834C8530", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly ILogHandler chainedLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IDisposable updateAtRateToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int numLogs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int numExceptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CachedLog? lastLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int logCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private CachedException? lastException;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int exceptionCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private bool enabled;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x34CC090", Offset = "0x34CB090", VA = "0x1834CC090")]
		public RecRoomLogHandler(ILogHandler chainedLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x34CB880", Offset = "0x34CA880", VA = "0x1834CB880")]
		public void SetActive(bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x34CBAF0", Offset = "0x34CAAF0", VA = "0x1834CBAF0")]
		private void StaggeredUpdate(float _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x34CB360", Offset = "0x34CA360", VA = "0x1834CB360", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x34CBD30", Offset = "0x34CAD30", VA = "0x1834CBD30")]
		private void TryLogRepeatedException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x34CB550", Offset = "0x34CA550", VA = "0x1834CB550", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x34CBE70", Offset = "0x34CAE70", VA = "0x1834CBE70")]
		private void TryLogRepeatedLog()
		{
		}
	}
}
namespace RecRoom.Debugging.Json
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum CanConvertPredicate
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Assignable,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Equal
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class CanConvertPredicateExt
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x22AC1C0", Offset = "0x22AB1C0", VA = "0x1822AC1C0")]
		public static Func<Type, bool> ToFunc<T>(this CanConvertPredicate self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xF1EE50", Offset = "0xF1DE50", VA = "0x180F1EE50")]
		private static bool Assignable<T>(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1C00A60", Offset = "0x1BFFA60", VA = "0x181C00A60")]
		private static bool Equal<T>(Type objectType)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class FunctionalJsonConverter<T> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly Func<Type, bool> canConvertFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Action<JsonWriter, T> writeJsonAction;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x20B0040", Offset = "0x20AF040", VA = "0x1820B0040", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x20B0100", Offset = "0x20AF100", VA = "0x1820B0100", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x20B05D0", Offset = "0x20AF5D0", VA = "0x1820B05D0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x20B0730", Offset = "0x20AF730", VA = "0x1820B0730")]
		internal FunctionalJsonConverter(Func<Type, bool> canConvertFunc, Action<JsonWriter, T> writeJsonAction)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class FunctionalJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x18D8460", Offset = "0x18D7460", VA = "0x1818D8460")]
		public static FunctionalJsonConverter<T> New<T>(Action<JsonWriter, T> writeJsonAction, CanConvertPredicate canConvertPredicate = CanConvertPredicate.Assignable)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class JsonConverters
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static JsonConverter QuaternionJsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x34C9ED0", Offset = "0x34C8ED0", VA = "0x1834C9ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static JsonConverter StringEnumConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x34C9F30", Offset = "0x34C8F30", VA = "0x1834C9F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static JsonConverter UnityObjectJsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x34C9F90", Offset = "0x34C8F90", VA = "0x1834C9F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static JsonConverter Vector3JsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x34C9FF0", Offset = "0x34C8FF0", VA = "0x1834C9FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class ToStringJsonConverter<T> : JsonConverter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly Func<Type, bool> canConvertFunc;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x20BFCB0", Offset = "0x20BECB0", VA = "0x1820BFCB0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x20BFD10", Offset = "0x20BED10", VA = "0x1820BFD10", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x20BFDE0", Offset = "0x20BEDE0", VA = "0x1820BFDE0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x20BFEE0", Offset = "0x20BEEE0", VA = "0x1820BFEE0")]
		internal ToStringJsonConverter(Func<Type, bool> canConvertFunc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ToStringJsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x18E2A00", Offset = "0x18E1A00", VA = "0x1818E2A00")]
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
