using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Collections;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Foundation.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class AutoResizeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public AutoResizeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ColumnSizeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84BBEC0", Offset = "0x84BAEC0", VA = "0x1884BBEC0")]
		public ColumnSizeAttribute(int size, int minSize, int maxSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Class)]
	public class DefaultSortAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public DefaultSortAttribute(bool ascending = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NetworkWindowColumn : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84BC980", Offset = "0x84BB980", VA = "0x1884BC980")]
		public NetworkWindowColumn(string name, string description = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Class)]
	public class PriorityAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2105650", Offset = "0x2104650", VA = "0x182105650")]
		public PriorityAttribute(int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Flags]
	public enum DataSourceTags
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		NonNetworked = 1,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Incoming = 2,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Outgoing = 4,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Suppressed = 8,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		FastForward = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		CacheRemove = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Default = 0x3F,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		All = 0x3F
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ZNDFBWYGAKQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface TOESBRVHGIX<a> : ZNDFBWYGAKQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MJWJJMXXGRQ([In] EventWriter @event, a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface FGPCHMXBZYL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool YJTRLFKSATM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int IYVVVFLCFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int NMNEBXYIGBW(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QPOKQBABVIK(NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> a, NativeArray<byte> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface HOFXCZZBTIT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class BAAASUYTNVT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class CBWYNAGPFCD<a> : TGOQEBLEEYL<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D4ABD0", Offset = "0x3D49BD0", VA = "0x183D4ABD0")]
		protected CBWYNAGPFCD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class TGOQEBLEEYL<a> : TOESBRVHGIX<a>, ZNDFBWYGAKQ where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51CDB70", Offset = "0x51CCB70", VA = "0x1851CDB70")]
		public void MJWJJMXXGRQ([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected TGOQEBLEEYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x51CDDB0", Offset = "0x51CCDB0", VA = "0x1851CDDB0", Slot = "4")]
		private void OZFLWLENZNY([In] EventWriter @event, a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class KJTQDVQFGFY<a> : TOESBRVHGIX<NativeArray<a>>, ZNDFBWYGAKQ where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x54516A0", Offset = "0x54506A0", VA = "0x1854516A0")]
		public void MJWJJMXXGRQ([In] EventWriter @event, NativeArray<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x36B5960", Offset = "0x36B4960", VA = "0x1836B5960")]
		public static ReadOnlySpan<T> MHRYDASKBZP<T>(NativeArray<T> a) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected KJTQDVQFGFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5451500", Offset = "0x5450500", VA = "0x185451500", Slot = "4")]
		private void IVIMHRXZIYS([In] EventWriter @event, NativeArray<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ONZSCWTRUYQ : TOESBRVHGIX<ONZSCWTRUYQ.Empty>, ZNDFBWYGAKQ
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct Empty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void MJWJJMXXGRQ([In] EventWriter @event, Empty a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ONZSCWTRUYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
		private void YDERSXVTTSD([In] EventWriter @event, Empty a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class GDFIKMILHJO : TOESBRVHGIX<string>, ZNDFBWYGAKQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly GDFIKMILHJO QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84BC640", Offset = "0x84BB640", VA = "0x1884BC640")]
		public void MJWJJMXXGRQ([In] EventWriter @event, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public GDFIKMILHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84BC630", Offset = "0x84BB630", VA = "0x1884BC630", Slot = "4")]
		private void HGKFQXZPUVQ([In] EventWriter @event, string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class BGJNLFXJKCX<a> : IWYRFIGKAML<a> where a : struct, IComparable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D4ABD0", Offset = "0x3D49BD0", VA = "0x183D4ABD0")]
		protected BGJNLFXJKCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class IWYRFIGKAML<a> : TOESBRVHGIX<a>, ZNDFBWYGAKQ where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x51CD9B0", Offset = "0x51CC9B0", VA = "0x1851CD9B0")]
		public void MJWJJMXXGRQ([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected IWYRFIGKAML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x51CDDF0", Offset = "0x51CCDF0", VA = "0x1851CDDF0", Slot = "4")]
		private void OZFLWLENZNY([In] EventWriter @event, a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct EventWriter : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public readonly struct FieldWriter : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly EventWriter @event;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int columnIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private readonly int dataStart;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x84BC5E0", Offset = "0x84BB5E0", VA = "0x1884BC5E0")]
			public FieldWriter(EventWriter @event, int columnIndex, int dataStart)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x84BC590", Offset = "0x84BB590", VA = "0x1884BC590")]
			public FieldWriter UUYLGABYPIL(ReadOnlySpan<byte> a)
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3C99440", Offset = "0x3C98440", VA = "0x183C99440")]
			public FieldWriter UUYLGABYPIL<T>(T a) where T : struct
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x84BC4F0", Offset = "0x84BB4F0", VA = "0x1884BC4F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FGPCHMXBZYL model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NativeList<byte> data;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84BC310", Offset = "0x84BB310", VA = "0x1884BC310")]
		public EventWriter(FGPCHMXBZYL model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84BC220", Offset = "0x84BB220", VA = "0x1884BC220")]
		public int RSQWIEISPWZ(ZNDFBWYGAKQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84BC030", Offset = "0x84BB030", VA = "0x1884BC030")]
		public FieldWriter BITWBAHFSHT(ZNDFBWYGAKQ a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84BC110", Offset = "0x84BB110", VA = "0x1884BC110")]
		public FieldWriter BITWBAHFSHT(int a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84BBF10", Offset = "0x84BAF10", VA = "0x1884BBF10")]
		public void AMONIKBVVAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84BC1C0", Offset = "0x84BB1C0", VA = "0x1884BC1C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class BMOTFKHOXHW
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x342BC10", Offset = "0x342AC10", VA = "0x18342BC10")]
		public static EventWriter Add<T>([In] this EventWriter @event, TOESBRVHGIX<T> serializer, T value)
		{
			return default(EventWriter);
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
