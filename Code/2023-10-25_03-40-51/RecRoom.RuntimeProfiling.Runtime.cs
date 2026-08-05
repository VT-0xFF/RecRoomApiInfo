using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FIMLHBHFEFD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63191C0", Offset = "0x6317FC0", VA = "0x1863191C0")]
	public static ProfilerCategory OPMAEGFNKEG(string OBBIPCOHIJE)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PIBAOFCNPLO
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x503C2B0", Offset = "0x503B0B0", VA = "0x18503C2B0")]
	public static ProfilerCategory KMDFDAFLJED(ushort MMFAHACBFDA)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63191D0", Offset = "0x6317FD0", VA = "0x1863191D0")]
	public static ushort AGLHLDAMJAJ(string OBBIPCOHIJE)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OCAKMJPNMLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerCategory PABBJIBBIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PBLMLNDEEJG FPIIMCCPKFA;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PBLMLNDEEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ushort PDCMMIDDLCI;
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
