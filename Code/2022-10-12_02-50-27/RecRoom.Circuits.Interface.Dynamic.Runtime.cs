using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HNKKLEIMDFA<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer NCGONMNFDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBCBENLODBK(in TObject ODMJCJPGHNI, in TRpcParam KDAIJKFCLIH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDBJILNENMN(in TObject ODMJCJPGHNI, in TRpcParam KDAIJKFCLIH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MAHKABNNOEG(in TObject ODMJCJPGHNI, in TRpcParam KDAIJKFCLIH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGBEPEGDMOG(in TObject ODMJCJPGHNI, in TRpcParam KDAIJKFCLIH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNGMHEHHAEP(in TObject ODMJCJPGHNI, in TRpcReceiver IFNNJKKFPDF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	TPlayer NIBMKLBOINO(in TObject ODMJCJPGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HLDAKECIHAF(in TObject ODMJCJPGHNI, in TPlayer FFLNBEOJALG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	TSyncField KEDHPPFLDHP(in TObject ODMJCJPGHNI, in TSyncFieldParam KDAIJKFCLIH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MAIELKPKJML(in TSyncField OLMMLKLFKFH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CMPNGAPLFLN(in TSyncField OLMMLKLFKFH, in TSyncFieldValue CCIMHDCKHOF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AMCILOGJMJG<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POADLMIPLKJ(in TRpcParam NCHNGIGODJK);
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
