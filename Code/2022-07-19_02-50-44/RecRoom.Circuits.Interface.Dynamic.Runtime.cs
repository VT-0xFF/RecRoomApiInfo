using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EKCIFAAAJBO<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer ADPCKODBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCPMOLHEJIO(in TObject OOJKHPLJJMJ, in TRpcParam BNNJOKOOGLA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFMKEFBBBBH(in TObject OOJKHPLJJMJ, in TRpcParam BNNJOKOOGLA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJBHMAHKELL(in TObject OOJKHPLJJMJ, in TRpcParam BNNJOKOOGLA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPAEGLNBCMH(in TObject OOJKHPLJJMJ, in TRpcParam BNNJOKOOGLA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DGODGLMFOCM(in TObject OOJKHPLJJMJ, in TRpcReceiver JDAAHNBGABL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	TPlayer JHDAJGFNPAN(in TObject OOJKHPLJJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NNGNCDBKIAC(in TObject OOJKHPLJJMJ, in TPlayer HHBNCLHAPHN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	TSyncField IHLOFLMDHLI(in TObject OOJKHPLJJMJ, in TSyncFieldParam BNNJOKOOGLA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FGOAMPAEJIE(in TSyncField HFNHGDHDCMM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KKOOPFNNEHA(in TSyncField HFNHGDHDCMM, in TSyncFieldValue BMNJAHFFOPC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ODMJPDENFDP<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBHGLBOJAJN(in TRpcParam KAIJPPOLHDF);
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
