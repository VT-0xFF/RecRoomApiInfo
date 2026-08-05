using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LFLEAFMGJCC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7BF13E0", Offset = "0x7BF05E0", VA = "0x187BF13E0")]
	public static ProfilerCategory IFHGNCOPJNC(string PNIJDNGJJIH)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct NHMMMDNJCLE : IEquatable<NHMMMDNJCLE>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct FNCJIPIDDAF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr LLKLOGEGFFM;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BF13D0", Offset = "0x7BF05D0", VA = "0x187BF13D0")]
		internal FNCJIPIDDAF(IntPtr LLKLOGEGFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BF13C0", Offset = "0x7BF05C0", VA = "0x187BF13C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort MIOGNLDAMKN = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr LLKLOGEGFFM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1450", Offset = "0x7BF0650", VA = "0x187BF1450")]
	public NHMMMDNJCLE(ushort BNKJMLKEGGJ, string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1420", Offset = "0x7BF0620", VA = "0x187BF1420")]
	public NHMMMDNJCLE(string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1400", Offset = "0x7BF0600", VA = "0x187BF1400")]
	public FNCJIPIDDAF GODGCKAEDMD()
	{
		return default(FNCJIPIDDAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BF13F0", Offset = "0x7BF05F0", VA = "0x187BF13F0", Slot = "4")]
	public bool Equals(NHMMMDNJCLE JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BF13F0", Offset = "0x7BF05F0", VA = "0x187BF13F0", Slot = "5")]
	public bool Equals(ProfilerMarker JAINJPLCLDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PCLPDMKNFDF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2F90640", Offset = "0x2F8F840", VA = "0x182F90640")]
	public static ProfilerCategory DAJEIONICCH(ushort BDICACINFAB)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1480", Offset = "0x7BF0680", VA = "0x187BF1480")]
	public static ushort MNNBHNJPAHD(string FLJNHPBMJCB)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JLHDFPMGBLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort NKCGKGAAMOI;
}
namespace Cpp2IlInjected;

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
