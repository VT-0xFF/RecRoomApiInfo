using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PPEHIEBOKFA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x672D3A0", Offset = "0x672C7A0", VA = "0x18672D3A0")]
	public static ProfilerCategory LIAEPGPGBDL(string NFBOKLLGOFB)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GDJOIMEGLII
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x11F5AD0", Offset = "0x11F4ED0", VA = "0x1811F5AD0")]
	public static ProfilerCategory HLCMIAOOHOM(ushort LDIAGFPEDGM)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x672CBC0", Offset = "0x672BFC0", VA = "0x18672CBC0")]
	public static ushort OLICALOLDPP(string NFBOKLLGOFB)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PJKOIHABBNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerCategory NMAMPMADCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GFOEMMHODBA GGCBMOIBGLF;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GFOEMMHODBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ushort NCCNEKCAANB;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KMHLFCFNICN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x672CD70", Offset = "0x672C170", VA = "0x18672CD70")]
	public static (string, double) HOOCDFGAPEP(double LODAGNBBEJD, ProfilerMarkerDataUnit CPIELMKMFNO, bool JIDGLOKLMPI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x672D0C0", Offset = "0x672C4C0", VA = "0x18672D0C0")]
	public static (string, double) KMAEDLPOHIL(double IBICGAFKINH, bool JIDGLOKLMPI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x672D200", Offset = "0x672C600", VA = "0x18672D200")]
	public static (string, double) KNGJHFLPCAM(double EKOMCFHNHDB, bool JIDGLOKLMPI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x672CC20", Offset = "0x672C020", VA = "0x18672CC20")]
	public static (string, double) DJGLDEAHPJL(double NBHNHFBNHLD, bool JIDGLOKLMPI = true)
	{
		return default((string, double));
	}
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
