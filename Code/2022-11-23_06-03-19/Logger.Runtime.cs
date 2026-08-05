using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NJEJEKPFPFL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x287BCA80287BA0", Offset = "0x0", VA = "0x287BCC00287BA0", Slot = "0")]
	void CGAIAMLGLCP(object CBDAGBGGFJM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x287BCE873AD168", Offset = "0x0", VA = "0x287BD0073AD168", Slot = "1")]
	void MLMHALPPIKO(object CBDAGBGGFJM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x73AD16680287C0E", Offset = "0x0", VA = "0x73AD16800287C0E", Slot = "2")]
	void MEEILHODDPH(object CBDAGBGGFJM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x287C4C80287C10", Offset = "0x0", VA = "0x287C4E00287C10", Slot = "3")]
	void KPDFBBGLCFI(object EDPENIGJGLF, string FBNKELIOELL, params object[] MAGEMABOILP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x287C4E873AD168", Offset = "0x0", VA = "0x287C50073AD168", Slot = "4")]
	void BCFLJABLEAC(Exception CCFMIAPLDHN);
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
