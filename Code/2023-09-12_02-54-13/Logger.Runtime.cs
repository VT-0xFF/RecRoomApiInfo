using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FHPGBOJECFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x26593B88DBB3C0", Offset = "0x0", VA = "0x26593D08DBB3C0", Slot = "0")]
	void JGFJHJADKIM(object IGCLICKKCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8DBB3D280265942", Offset = "0x0", VA = "0x8DBB3D400265942", Slot = "1")]
	void AEEPOKKDDOD(object IGCLICKKCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26595380265942", Offset = "0x0", VA = "0x26595500265942", Slot = "2")]
	void DKPPJPJAMMM(object IGCLICKKCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x26595E88DBB3E4", Offset = "0x0", VA = "0x26596008DBB3E4", Slot = "3")]
	void LCDELDKIOPP(object AKPCLGIGABA, string EFDFEGMKBJJ, params object[] AIEGNLJMEEC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8D1B8FA802659AE", Offset = "0x0", VA = "0x8D1B8FC002659AE", Slot = "4")]
	void JPCLODNKDFI(Exception KEDDDEAIDBN);
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
