using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JHCGFNDBLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2481CE89720E24", Offset = "0x0", VA = "0x2481D009720E24", Slot = "0")]
	void AGKNLPHAFKB(object BNEDOBBKLOJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x972089E80248200", Offset = "0x0", VA = "0x97208A000248200", Slot = "1")]
	void OEAPCIDIDCP(object BNEDOBBKLOJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24823680248200", Offset = "0x0", VA = "0x24823800248200", Slot = "2")]
	void FJAJDELGFHO(object BNEDOBBKLOJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24823E897204FC", Offset = "0x0", VA = "0x248240097204FC", Slot = "3")]
	void KDGONHMMEBJ(object LAMCDJBBCDK, string AHKBHJGDBJA, params object[] PELDJLKMCIK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x971F23E80248266", Offset = "0x0", VA = "0x971F24000248266", Slot = "4")]
	void HKCKNEABHLE(Exception BKLOPMPJKCI);
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
