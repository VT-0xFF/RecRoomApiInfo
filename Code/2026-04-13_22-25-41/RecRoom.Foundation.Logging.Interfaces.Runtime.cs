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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public AutoResizeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ColumnSizeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x987A7B0", Offset = "0x98791B0", VA = "0x18987A7B0")]
		public ColumnSizeAttribute(int size, int minSize, int maxSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Class)]
	public class DefaultSortAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
		public DefaultSortAttribute(bool ascending = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NetworkWindowColumn : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x987B260", Offset = "0x9879C60", VA = "0x18987B260")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECB10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2384EC0", Offset = "0x23838C0", VA = "0x182384EC0")]
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
	public interface NXOSAXSWDRX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface VVKLHPIXKGW<a> : NXOSAXSWDRX
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RBAQEBKMPXF([In] EventWriter @event, a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface CAOCBFUBRXG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool SRHPKSLOBOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int DADVBTRSJBD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int VSOTZDMVTBF(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZVQHZKPMJUR(NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> a, NativeArray<byte> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface JSXKZBYAQCM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class YTINUPKQZGY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class GTRQOIENLSM<a> : TYOOUIPXWQQ<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4F58790", Offset = "0x4F57190", VA = "0x184F58790")]
		protected GTRQOIENLSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class TYOOUIPXWQQ<a> : VVKLHPIXKGW<a>, NXOSAXSWDRX where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51474A0", Offset = "0x5145EA0", VA = "0x1851474A0")]
		public void RBAQEBKMPXF([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected TYOOUIPXWQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5146FA0", Offset = "0x51459A0", VA = "0x185146FA0", Slot = "4")]
		private void QLPXYCDLJDV([In] EventWriter @event, a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class FXRNEYCALVB<a> : VVKLHPIXKGW<NativeArray<a>>, NXOSAXSWDRX where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6294B30", Offset = "0x6293530", VA = "0x186294B30")]
		public void RBAQEBKMPXF([In] EventWriter @event, NativeArray<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37CF3D0", Offset = "0x37CDDD0", VA = "0x1837CF3D0")]
		public static ReadOnlySpan<T> TIUNFNFIHFI<T>(NativeArray<T> a) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected FXRNEYCALVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6294F90", Offset = "0x6293990", VA = "0x186294F90", Slot = "4")]
		private void XSNOETHPCRD([In] EventWriter @event, NativeArray<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ABQZABQZPAL : VVKLHPIXKGW<ABQZABQZPAL.Empty>, NXOSAXSWDRX
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct Empty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		public void RBAQEBKMPXF([In] EventWriter @event, Empty a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ABQZABQZPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
		private void WYYDMEAOUCW([In] EventWriter @event, Empty a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class NVHHRUIHEXZ : VVKLHPIXKGW<string>, NXOSAXSWDRX
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly NVHHRUIHEXZ UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x987AF10", Offset = "0x9879910", VA = "0x18987AF10")]
		public void RBAQEBKMPXF([In] EventWriter @event, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public NVHHRUIHEXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x987B1E0", Offset = "0x9879BE0", VA = "0x18987B1E0", Slot = "4")]
		private void VEJYHKEKLDZ([In] EventWriter @event, string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class BFZGEVRPYKU<a> : ZSVQRDCGBPC<a> where a : struct, IComparable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4F58790", Offset = "0x4F57190", VA = "0x184F58790")]
		protected BFZGEVRPYKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class ZSVQRDCGBPC<a> : VVKLHPIXKGW<a>, NXOSAXSWDRX where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x51473C0", Offset = "0x5145DC0", VA = "0x1851473C0")]
		public void RBAQEBKMPXF([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected ZSVQRDCGBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5146F80", Offset = "0x5145980", VA = "0x185146F80", Slot = "4")]
		private void QLPXYCDLJDV([In] EventWriter @event, a a)
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
			[Cpp2IlInjected.Address(RVA = "0x987AEC0", Offset = "0x98798C0", VA = "0x18987AEC0")]
			public FieldWriter(EventWriter @event, int columnIndex, int dataStart)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x987ADD0", Offset = "0x98797D0", VA = "0x18987ADD0")]
			public FieldWriter BCUPZDFBSDS(ReadOnlySpan<byte> a)
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x41462B0", Offset = "0x4144CB0", VA = "0x1841462B0")]
			public FieldWriter BCUPZDFBSDS<T>(T a) where T : struct
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x987AE20", Offset = "0x9879820", VA = "0x18987AE20", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CAOCBFUBRXG model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NativeList<byte> data;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x987ABF0", Offset = "0x98795F0", VA = "0x18987ABF0")]
		public EventWriter(CAOCBFUBRXG model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x987A9F0", Offset = "0x98793F0", VA = "0x18987A9F0")]
		public int PXOKROLXMUS(NXOSAXSWDRX a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x987A860", Offset = "0x9879260", VA = "0x18987A860")]
		public FieldWriter KVTVXSMEDJK(NXOSAXSWDRX a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x987A940", Offset = "0x9879340", VA = "0x18987A940")]
		public FieldWriter KVTVXSMEDJK(int a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x987AAD0", Offset = "0x98794D0", VA = "0x18987AAD0")]
		public void UBSUEOKZGUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x987A800", Offset = "0x9879200", VA = "0x18987A800", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class GIUYAPEMTJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5550", Offset = "0x3AD3F50", VA = "0x183AD5550")]
		public static EventWriter Add<T>([In] this EventWriter @event, VVKLHPIXKGW<T> serializer, T value)
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
