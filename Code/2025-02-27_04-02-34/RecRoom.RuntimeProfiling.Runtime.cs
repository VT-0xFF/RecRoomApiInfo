using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GBJHGNKFDCH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle BNEOPIOPCOE(ProfilerCategory AJKIFLFMGBI, string IFODOKIKMFL);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static BNEOPIOPCOE NJFDCHCPKMG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5C90", Offset = "0x7EA5090", VA = "0x187EA5C90")]
	static GBJHGNKFDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5C10", Offset = "0x7EA5010", VA = "0x187EA5C10")]
	public static ProfilerRecorderHandle HIGIEJFEPCE(ProfilerCategory FEMHFMCGGDI, string KKLIHIMHNJG)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5C00", Offset = "0x7EA5000", VA = "0x187EA5C00")]
	public static ProfilerCategory GABPFCPGHBF(string FEMHFMCGGDI)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class COMIPPOHDNF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x308A340", Offset = "0x3089740", VA = "0x18308A340")]
	public static ProfilerCategory LHFMPOIAPFL(ushort KMNBHKKCBCK)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5B30", Offset = "0x7EA4F30", VA = "0x187EA5B30")]
	public static ushort FLPKIIAFGPH(string BDDFONPHDEO)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ICLEPAABEEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public ushort PCKFEOKBCOL;
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
