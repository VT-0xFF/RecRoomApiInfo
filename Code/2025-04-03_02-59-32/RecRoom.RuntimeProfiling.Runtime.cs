using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NDIBAIODMFF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle NPPEFAKFMCD(ProfilerCategory CMAMNCPNLFL, string AGGCDNLDFCJ);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static NPPEFAKFMCD JBOCHFOJJIN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82DC720", Offset = "0x82DBB20", VA = "0x1882DC720")]
	static NDIBAIODMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x37B8920", Offset = "0x37B7D20", VA = "0x1837B8920")]
	public static byte OPJEJIJHHFI<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82DC690", Offset = "0x82DBA90", VA = "0x1882DC690")]
	public static ProfilerRecorderHandle EBEALGBMIBB(ProfilerCategory HOOOCOBIOEI, string NMNCEIFABGL)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82DC710", Offset = "0x82DBB10", VA = "0x1882DC710")]
	public static ProfilerCategory OPKHFCKMNIM(string HOOOCOBIOEI)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DOFFHKEJPEM<T> : IEquatable<DOFFHKEJPEM<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* EBPAMCHNFHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6695F70", Offset = "0x6695370", VA = "0x186695F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66964A0", Offset = "0x66958A0", VA = "0x1866964A0")]
	public DOFFHKEJPEM(ProfilerCategory CMAMNCPNLFL, string IGEPDAOOLBO, ProfilerMarkerDataUnit POMIPFBFPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2034140", Offset = "0x2033540", VA = "0x182034140", Slot = "4")]
	public bool Equals(DOFFHKEJPEM<T> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6695FB0", Offset = "0x66953B0", VA = "0x186695FB0", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DLPKLFDJGNC : IEquatable<DLPKLFDJGNC>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AAALLBFFEBH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr OHICDMELKFO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82DC500", Offset = "0x82DB900", VA = "0x1882DC500")]
		internal AAALLBFFEBH(IntPtr OHICDMELKFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82DC4F0", Offset = "0x82DB8F0", VA = "0x1882DC4F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr OHICDMELKFO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82DC590", Offset = "0x82DB990", VA = "0x1882DC590")]
	public DLPKLFDJGNC(ushort MBDIDMHEMIB, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82DC540", Offset = "0x82DB940", VA = "0x1882DC540")]
	public DLPKLFDJGNC(ProfilerCategory CMAMNCPNLFL, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82DC520", Offset = "0x82DB920", VA = "0x1882DC520")]
	public AAALLBFFEBH FJFFMLEDJFG()
	{
		return default(AAALLBFFEBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82DC510", Offset = "0x82DB910", VA = "0x1882DC510", Slot = "4")]
	public bool Equals(DLPKLFDJGNC KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82DC510", Offset = "0x82DB910", VA = "0x1882DC510", Slot = "5")]
	public bool Equals(ProfilerMarker KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class KFMCBGJJHMH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36A9A90", Offset = "0x36A8E90", VA = "0x1836A9A90")]
	internal unsafe static bool FNIMBAFGBMK<T>(ProfilerCounterValue<T> CNCLCOOJCND, [Out] T* LEAOLDPINHO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32A9B50", Offset = "0x32A8F50", VA = "0x1832A9B50")]
	public static ProfilerCategory OCNBHBIMDDA(ushort EOPEOHEMDAF)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82DC5C0", Offset = "0x82DB9C0", VA = "0x1882DC5C0")]
	public static ushort HGDHIBOOIOB(string OLPKHAIGBMN)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DEAKAOOAAML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort KIOOMMLNBEM;
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
