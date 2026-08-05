using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IINGOHGGBAL<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer BBLMEJGPFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKIGLDNODPM(in TObject CCPIHKCBGHF, in TRpcParam EPHCHIPDIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJGFFPLEFKP(in TObject CCPIHKCBGHF, in TRpcParam EPHCHIPDIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBOKGLEGLAI(in TObject CCPIHKCBGHF, in TRpcParam EPHCHIPDIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGACFHFFPPA(in TObject CCPIHKCBGHF, in TRpcParam EPHCHIPDIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNNJEBHFGMC(in TObject CCPIHKCBGHF, in TRpcReceiver BOKNDOBPMIO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	TPlayer IJGBBKHNKEC(in TObject CCPIHKCBGHF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ACHMADOLHPL(in TObject CCPIHKCBGHF, in TPlayer NIKGDEJFIJN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	TSyncField DNJELPFEKOL(in TObject CCPIHKCBGHF, in TSyncFieldParam EPHCHIPDIOJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MHFEMBBBLHC(in TSyncField MIHOKHNODHJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HGGOCLDJMNJ(in TSyncField MIHOKHNODHJ, in TSyncFieldValue IGJPNMBCJPK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IFFGBPHLNDG<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIFAPHHGFJG(in TRpcParam CGKOOFFNHKL);
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
