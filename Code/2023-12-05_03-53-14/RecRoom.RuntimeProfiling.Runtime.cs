using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BMACPABMEKP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64F3D80", Offset = "0x64F3180", VA = "0x1864F3D80")]
	public static ProfilerCategory FDEPBNFFJAC(string BBHMDNICLFC)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PFGOJFOGFKG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51BBCD0", Offset = "0x51BB0D0", VA = "0x1851BBCD0")]
	public static ProfilerCategory IKKMFGNEHEK(ushort JOIBMNHHBML)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64F3D90", Offset = "0x64F3190", VA = "0x1864F3D90")]
	public static ushort ENBIALMBEIC(string BBHMDNICLFC)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DOGMBIPEMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerCategory OPJDDCOPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public LJODOFAGGHC JOPMKAJFNAG;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LJODOFAGGHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ushort PKEKFFJBJAA;
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
