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
	[Cpp2IlInjected.Address(RVA = "0x66B0260", Offset = "0x66AF260", VA = "0x1866B0260")]
	public static ProfilerCategory LIAEPGPGBDL(string NFBOKLLGOFB)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GDJOIMEGLII
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1457760", Offset = "0x1456760", VA = "0x181457760")]
	public static ProfilerCategory HLCMIAOOHOM(ushort LDIAGFPEDGM)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66AFA80", Offset = "0x66AEA80", VA = "0x1866AFA80")]
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
	[Cpp2IlInjected.Address(RVA = "0x66AFC30", Offset = "0x66AEC30", VA = "0x1866AFC30")]
	public static (string, double) HOOCDFGAPEP(double LODAGNBBEJD, ProfilerMarkerDataUnit CPIELMKMFNO, bool JIDGLOKLMPI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66AFF80", Offset = "0x66AEF80", VA = "0x1866AFF80")]
	public static (string, double) KMAEDLPOHIL(double IBICGAFKINH, bool JIDGLOKLMPI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66B00C0", Offset = "0x66AF0C0", VA = "0x1866B00C0")]
	public static (string, double) KNGJHFLPCAM(double EKOMCFHNHDB, bool JIDGLOKLMPI = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66AFAE0", Offset = "0x66AEAE0", VA = "0x1866AFAE0")]
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
