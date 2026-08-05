using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class FGLMFMKAOMH<TData> : BDPIDPDHGEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FEMPLJOMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData IHMOEAABGNA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
	public override string GMMJBFEOGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3587300", Offset = "0x3586700", VA = "0x183587300")]
	internal FGLMFMKAOMH(string DCKDMGKGDFN, [In] TData MFNOAEFOKBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HINCEBLGIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6210", Offset = "0x1DA5610", VA = "0x181DA6210")]
	public static FGLMFMKAOMH<PJHBHBBODGG> JKJFENIAMEL(string DCKDMGKGDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24E45D0", Offset = "0x24E39D0", VA = "0x1824E45D0")]
	public static FGLMFMKAOMH<TData> JKJFENIAMEL<TData>(string DCKDMGKGDFN, [In] TData MFNOAEFOKBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KMNOPDJMFCC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26E4880", Offset = "0x26E3C80", VA = "0x1826E4880")]
	public static KKHLNMGODKL<TOk, MPIKAEBOCFI> BLPJPPLDGNC<TOk>([In] this KKHLNMGODKL<TOk, MPIKAEBOCFI> NHHBAHIFHJK, string DCKDMGKGDFN)
	{
		return default(KKHLNMGODKL<TOk, MPIKAEBOCFI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BDPIDPDHGEO : NOJMEPFJKIM, MPIKAEBOCFI, PKFDKDKJAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D6DA30", Offset = "0x1D6CE30", VA = "0x181D6DA30")]
	protected BDPIDPDHGEO()
	{
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
