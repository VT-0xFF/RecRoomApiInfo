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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public AutoResizeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ColumnSizeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82A7000", Offset = "0x82A6400", VA = "0x1882A7000")]
		public ColumnSizeAttribute(int size, int minSize, int maxSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Class)]
	public class DefaultSortAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public DefaultSortAttribute(bool ascending = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NetworkWindowColumn : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82A7810", Offset = "0x82A6C10", VA = "0x1882A7810")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCF20", Offset = "0x1FDC320", VA = "0x181FDCF20")]
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
	public interface MSWHHHEHJKT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface LPCOTVLJQFO<a> : MSWHHHEHJKT
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KGQELHKJNKJ([In] EventWriter @event, a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface HUYEQKIYRSS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool KYLWYHZGZVV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int BHRNNJXMGDV
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int OXORZUWBDFT(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EENKGRSIGZR(NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> a, NativeArray<byte> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface CWMBHOVWFMG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class NTAOGJMAMHQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class IBVYGRVJBAW<a> : MGPFENPSMVU<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4F50E40", Offset = "0x4F50240", VA = "0x184F50E40")]
		protected IBVYGRVJBAW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class MGPFENPSMVU<a> : LPCOTVLJQFO<a>, MSWHHHEHJKT where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x57D1760", Offset = "0x57D0B60", VA = "0x1857D1760")]
		public void KGQELHKJNKJ([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected MGPFENPSMVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x57D1550", Offset = "0x57D0950", VA = "0x1857D1550", Slot = "4")]
		private void DXSTKWRIDYZ([In] EventWriter @event, a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class PMWYCBCDNKJ<a> : LPCOTVLJQFO<NativeArray<a>>, MSWHHHEHJKT where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5A58350", Offset = "0x5A57750", VA = "0x185A58350")]
		public void KGQELHKJNKJ([In] EventWriter @event, NativeArray<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x35DC8A0", Offset = "0x35DBCA0", VA = "0x1835DC8A0")]
		public static ReadOnlySpan<T> XXAVRHORTYY<T>(NativeArray<T> a) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected PMWYCBCDNKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5A584E0", Offset = "0x5A578E0", VA = "0x185A584E0", Slot = "4")]
		private void YMHVYPIPTRZ([In] EventWriter @event, NativeArray<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ASCOXPGNATX : LPCOTVLJQFO<ASCOXPGNATX.Empty>, MSWHHHEHJKT
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct Empty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public void KGQELHKJNKJ([In] EventWriter @event, Empty a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ASCOXPGNATX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		private void JMKSNYYFJXS([In] EventWriter @event, Empty a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AORGPEDZFGZ : LPCOTVLJQFO<string>, MSWHHHEHJKT
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly AORGPEDZFGZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82A6CC0", Offset = "0x82A60C0", VA = "0x1882A6CC0")]
		public void KGQELHKJNKJ([In] EventWriter @event, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AORGPEDZFGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82A6CB0", Offset = "0x82A60B0", VA = "0x1882A6CB0", Slot = "4")]
		private void IIFDPYOAXUJ([In] EventWriter @event, string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class ONSLURKKJCW<a> : QKPGYYHSCEC<a> where a : struct, IComparable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4F50E40", Offset = "0x4F50240", VA = "0x184F50E40")]
		protected ONSLURKKJCW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class QKPGYYHSCEC<a> : LPCOTVLJQFO<a>, MSWHHHEHJKT where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7F10", Offset = "0x5AE7310", VA = "0x185AE7F10")]
		public void KGQELHKJNKJ([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected QKPGYYHSCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7C20", Offset = "0x5AE7020", VA = "0x185AE7C20", Slot = "4")]
		private void DXSTKWRIDYZ([In] EventWriter @event, a a)
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
			[Cpp2IlInjected.Address(RVA = "0x82A77C0", Offset = "0x82A6BC0", VA = "0x1882A77C0")]
			public FieldWriter(EventWriter @event, int columnIndex, int dataStart)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82A7770", Offset = "0x82A6B70", VA = "0x1882A7770")]
			public FieldWriter FTZTBTAIDWC(ReadOnlySpan<byte> a)
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3C4AC10", Offset = "0x3C4A010", VA = "0x183C4AC10")]
			public FieldWriter FTZTBTAIDWC<T>(T a) where T : struct
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x82A76D0", Offset = "0x82A6AD0", VA = "0x1882A76D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HUYEQKIYRSS model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NativeList<byte> data;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82A74F0", Offset = "0x82A68F0", VA = "0x1882A74F0")]
		public EventWriter(HUYEQKIYRSS model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82A7150", Offset = "0x82A6550", VA = "0x1882A7150")]
		public int KUUFDPYODXC(MSWHHHEHJKT a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82A7240", Offset = "0x82A6640", VA = "0x1882A7240")]
		public FieldWriter LKFLTLCTBQW(MSWHHHEHJKT a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82A7320", Offset = "0x82A6720", VA = "0x1882A7320")]
		public FieldWriter LKFLTLCTBQW(int a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82A73D0", Offset = "0x82A67D0", VA = "0x1882A73D0")]
		public void SPZOFEDLTUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82A7050", Offset = "0x82A6450", VA = "0x1882A7050")]
		public EventWriter Cancel()
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82A70F0", Offset = "0x82A64F0", VA = "0x1882A70F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class GWPZKGDGEZR
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3655B90", Offset = "0x3654F90", VA = "0x183655B90")]
		public static EventWriter Add<T>([In] this EventWriter @event, LPCOTVLJQFO<T> serializer, T value)
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
