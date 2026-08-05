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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public AutoResizeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ColumnSizeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85AE100", Offset = "0x85ACF00", VA = "0x1885AE100")]
		public ColumnSizeAttribute(int size, int minSize, int maxSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Class)]
	public class DefaultSortAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public DefaultSortAttribute(bool ascending = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NetworkWindowColumn : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85AE920", Offset = "0x85AD720", VA = "0x1885AE920")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24D42A0", Offset = "0x24D30A0", VA = "0x1824D42A0")]
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
	public interface AJRRMDGAPHS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface RXLJPRTECLR<a> : AJRRMDGAPHS
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IQOBUFAIOTE([In] EventWriter @event, a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface WDCLPGRLXGX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MRKQWDMPDWK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int CGANELQZEXG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MHEHOPTUEWM(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OXORIWHYNGW(NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> a, NativeArray<byte> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface MXKEQYFMHUT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class SHMDZOSEZPX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class QSDFMNXDHRF<a> : DREFQXLHLIX<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x522CF10", Offset = "0x522BD10", VA = "0x18522CF10")]
		protected QSDFMNXDHRF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class DREFQXLHLIX<a> : RXLJPRTECLR<a>, AJRRMDGAPHS where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x430EA60", Offset = "0x430D860", VA = "0x18430EA60")]
		public void IQOBUFAIOTE([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected DREFQXLHLIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x430E900", Offset = "0x430D700", VA = "0x18430E900", Slot = "4")]
		private void HFUKVURSVSO([In] EventWriter @event, a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class UIJISVDEXZE<a> : RXLJPRTECLR<NativeArray<a>>, AJRRMDGAPHS where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6417CF0", Offset = "0x6416AF0", VA = "0x186417CF0")]
		public void IQOBUFAIOTE([In] EventWriter @event, NativeArray<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3B60", Offset = "0x3EE2960", VA = "0x183EE3B60")]
		public static ReadOnlySpan<T> QLKMVCYFBQB<T>(NativeArray<T> a) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected UIJISVDEXZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6417C90", Offset = "0x6416A90", VA = "0x186417C90", Slot = "4")]
		private void DUEJESYCHQO([In] EventWriter @event, NativeArray<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PQFQBLBOWRW : RXLJPRTECLR<PQFQBLBOWRW.Empty>, AJRRMDGAPHS
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct Empty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public void IQOBUFAIOTE([In] EventWriter @event, Empty a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PQFQBLBOWRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		private void YOHDTBDIYNJ([In] EventWriter @event, Empty a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class TPYGAQUFIGI : RXLJPRTECLR<string>, AJRRMDGAPHS
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly TPYGAQUFIGI GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85AE970", Offset = "0x85AD770", VA = "0x1885AE970")]
		public void IQOBUFAIOTE([In] EventWriter @event, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TPYGAQUFIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85AEC40", Offset = "0x85ADA40", VA = "0x1885AEC40", Slot = "4")]
		private void UNTAZOGJZBE([In] EventWriter @event, string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class PRXJQYPQPMH<a> : JBHNXVBARWD<a> where a : struct, IComparable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x522CF10", Offset = "0x522BD10", VA = "0x18522CF10")]
		protected PRXJQYPQPMH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class JBHNXVBARWD<a> : RXLJPRTECLR<a>, AJRRMDGAPHS where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x53C2B30", Offset = "0x53C1930", VA = "0x1853C2B30")]
		public void IQOBUFAIOTE([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected JBHNXVBARWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x53C2950", Offset = "0x53C1750", VA = "0x1853C2950", Slot = "4")]
		private void HFUKVURSVSO([In] EventWriter @event, a a)
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

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x85AE8D0", Offset = "0x85AD6D0", VA = "0x1885AE8D0")]
			public FieldWriter(EventWriter @event, int columnIndex, int dataStart)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85AE7E0", Offset = "0x85AD5E0", VA = "0x1885AE7E0")]
			public FieldWriter AINMEIQJDDF(ReadOnlySpan<byte> a)
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3EC5010", Offset = "0x3EC3E10", VA = "0x183EC5010")]
			public FieldWriter AINMEIQJDDF<T>(T a) where T : struct
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85AE830", Offset = "0x85AD630", VA = "0x1885AE830", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private WDCLPGRLXGX model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NativeList<byte> data;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85AE5F0", Offset = "0x85AD3F0", VA = "0x1885AE5F0")]
		public EventWriter(WDCLPGRLXGX model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85AE370", Offset = "0x85AD170", VA = "0x1885AE370")]
		public int KVMWOFMIXOZ(AJRRMDGAPHS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85AE460", Offset = "0x85AD260", VA = "0x1885AE460")]
		public FieldWriter PYTNXQUSKBX(AJRRMDGAPHS a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85AE540", Offset = "0x85AD340", VA = "0x1885AE540")]
		public FieldWriter PYTNXQUSKBX(int a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85AE250", Offset = "0x85AD050", VA = "0x1885AE250")]
		public void IDYEONHPVDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85AE150", Offset = "0x85ACF50", VA = "0x1885AE150")]
		public EventWriter Cancel()
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85AE1F0", Offset = "0x85ACFF0", VA = "0x1885AE1F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ELLTGLXIUXS
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37F3720", Offset = "0x37F2520", VA = "0x1837F3720")]
		public static EventWriter Add<T>([In] this EventWriter @event, RXLJPRTECLR<T> serializer, T value)
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
