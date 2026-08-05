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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IPFNJGFGMAH
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle OLJDMLBCOMM(ProfilerCategory LPMLMMNKNGK, string GINGPGBEEAH);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static OLJDMLBCOMM MNIEGCHIOID;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8260F00", Offset = "0x8260300", VA = "0x188260F00")]
	static IPFNJGFGMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3664D10", Offset = "0x3664110", VA = "0x183664D10")]
	public static byte MABEPJCNLJK<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8260E80", Offset = "0x8260280", VA = "0x188260E80")]
	public static ProfilerRecorderHandle KBFHBOPNIEF(ProfilerCategory MAIEDAJPAAE, string EJEOLIGPBMG)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8260E70", Offset = "0x8260270", VA = "0x188260E70")]
	public static ProfilerCategory CMMGPDPFNNP(string MAIEDAJPAAE)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct JGIEHHMLFDJ<T> : IEquatable<JGIEHHMLFDJ<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* NNNLIOAIBKA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0390", Offset = "0x4BDF790", VA = "0x184BE0390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4BE05D0", Offset = "0x4BDF9D0", VA = "0x184BE05D0")]
	public JGIEHHMLFDJ(ProfilerCategory LPMLMMNKNGK, string MPGDCPPMNJN, ProfilerMarkerDataUnit OKIGBPPALGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF5DB0", Offset = "0x1FF51B0", VA = "0x181FF5DB0", Slot = "4")]
	public bool Equals(JGIEHHMLFDJ<T> JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4BE03C0", Offset = "0x4BDF7C0", VA = "0x184BE03C0", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> JAPIEEBOJEA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MFJNPCCDHFN : IEquatable<MFJNPCCDHFN>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct LNOKGIAFDMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr ICPNBOAKOMP;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8261260", Offset = "0x8260660", VA = "0x188261260")]
		internal LNOKGIAFDMO(IntPtr ICPNBOAKOMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8261250", Offset = "0x8260650", VA = "0x188261250", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr ICPNBOAKOMP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82612A0", Offset = "0x82606A0", VA = "0x1882612A0")]
	public MFJNPCCDHFN(ushort NPNFBHCIGCM, string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82612D0", Offset = "0x82606D0", VA = "0x1882612D0")]
	public MFJNPCCDHFN(ProfilerCategory LPMLMMNKNGK, string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8261280", Offset = "0x8260680", VA = "0x188261280")]
	public LNOKGIAFDMO KKPKDAMINME()
	{
		return default(LNOKGIAFDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8261270", Offset = "0x8260670", VA = "0x188261270", Slot = "4")]
	public bool Equals(MFJNPCCDHFN JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8261270", Offset = "0x8260670", VA = "0x188261270", Slot = "5")]
	public bool Equals(ProfilerMarker JAPIEEBOJEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class LEKMBONNIOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36BC840", Offset = "0x36BBC40", VA = "0x1836BC840")]
	internal unsafe static bool AAHFEKCBDPI<T>(ProfilerCounterValue<T> GGIBOOKBOJI, [Out] T* KEIOHFHAMCK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3292210", Offset = "0x3291610", VA = "0x183292210")]
	public static ProfilerCategory EBPJOKIFEFP(ushort IIPOMHKPFMG)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8261180", Offset = "0x8260580", VA = "0x188261180")]
	public static ushort JGDAEALODCF(string EKJGLNNCJKC)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GFAMJEGLOMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort PGGJCMLDMIH;
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
