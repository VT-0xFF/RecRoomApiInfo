using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FICHKIPGDFL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A461C0", Offset = "0x6A455C0", VA = "0x186A461C0")]
	public static ProfilerCategory ECMOOFLPEPH(string OIEMMGCEOBM)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OEIAEPMGKOP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x14A2CF0", Offset = "0x14A20F0", VA = "0x1814A2CF0")]
	public static ProfilerCategory BCBJAPIPFPG(ushort FEMJPIFMODI)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A459E0", Offset = "0x6A44DE0", VA = "0x186A459E0")]
	public static ushort KIFCMAPGHMM(string OIEMMGCEOBM)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IKCBKCIEPEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerCategory ELODBNLDLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GCDJFJDHJLK GBJBFPDCEHN;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GCDJFJDHJLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ushort OOKBMJKEKJN;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DMGDJCKCMAE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A45D30", Offset = "0x6A45130", VA = "0x186A45D30")]
	public static (string, double) JAPPODBFEIM(double FDKHMLMCKPI, ProfilerMarkerDataUnit GLBFCOFBIMB, bool AHHNAOCHNID = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A46080", Offset = "0x6A45480", VA = "0x186A46080")]
	public static (string, double) JOFNJGECDJO(double LLJLKEDECKM, bool AHHNAOCHNID = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A45B90", Offset = "0x6A44F90", VA = "0x186A45B90")]
	public static (string, double) CDLEFLOJMEB(double JDINKNIJEEK, bool AHHNAOCHNID = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A45A40", Offset = "0x6A44E40", VA = "0x186A45A40")]
	public static (string, double) BHFODDLNJPN(double DCFINMHFNGF, bool AHHNAOCHNID = true)
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
