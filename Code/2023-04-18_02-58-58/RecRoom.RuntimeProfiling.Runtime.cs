using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NEDHAKFHKMF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6817F10", Offset = "0x6817110", VA = "0x186817F10")]
	public static ProfilerCategory IKHOFKODEND(string DIEPDLKBMCG)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CMGANFBLMEH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x957650", Offset = "0x956850", VA = "0x180957650")]
	public static ProfilerCategory JHAAHOBJHDD(ushort LIMHFIDKJGB)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6817730", Offset = "0x6816930", VA = "0x186817730")]
	public static ushort BCAKEKGIPDN(string DIEPDLKBMCG)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FBEFKJNHOBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerCategory GFCPAMJILIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public LABPGNJLEAF FAAFFEEAHMO;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LABPGNJLEAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ushort MDGOLHHMKOG;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FKBFGEALNEB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6817A70", Offset = "0x6816C70", VA = "0x186817A70")]
	public static (string, double) FBHJFHOIPGP(double FNGFEOHNOKM, ProfilerMarkerDataUnit KMOPEAKIPMC, bool LIBFIAEGOME = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6817930", Offset = "0x6816B30", VA = "0x186817930")]
	public static (string, double) DKACABHILEG(double IOLDOBIBLID, bool LIBFIAEGOME = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6817790", Offset = "0x6816990", VA = "0x186817790")]
	public static (string, double) DBNBEBJPCLJ(double CGMKGNFHFEN, bool LIBFIAEGOME = true)
	{
		return default((string, double));
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6817DC0", Offset = "0x6816FC0", VA = "0x186817DC0")]
	public static (string, double) IFIOJLNOKNE(double FEIEDDAACPA, bool LIBFIAEGOME = true)
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
