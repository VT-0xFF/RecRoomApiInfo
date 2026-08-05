using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IHALFBFEIDH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer JGGEMGBADFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEFBHGHMLAG(in TObject HLJJNKOAONN, in TRpcParam HPLLIJEIOJA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGFGCPDIAEE(in TObject HLJJNKOAONN, in TRpcParam HPLLIJEIOJA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMMCGFIJNDK(in TObject HLJJNKOAONN, in TRpcParam HPLLIJEIOJA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBMGOHJHJDP(in TObject HLJJNKOAONN, in TRpcParam HPLLIJEIOJA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HAPMFIBEFEP(in TObject HLJJNKOAONN, in TRpcReceiver APHECPEBILI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	TPlayer GIMLGAGCPMP(in TObject HLJJNKOAONN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DIEMIHFLLGG(in TObject HLJJNKOAONN, in TPlayer FJDBBBHKGMF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	TSyncField JAACKFDCCJA(in TObject HLJJNKOAONN, in TSyncFieldParam HPLLIJEIOJA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LBNFAGOFAEC(in TSyncField DOOJKMGBABP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AIGODHONHGG(in TSyncField DOOJKMGBABP, in TSyncFieldValue PDMPLJICJLE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KMKBGBOCAEL<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBLAICDANIO(in TRpcParam FHCMCNABNIM);
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
