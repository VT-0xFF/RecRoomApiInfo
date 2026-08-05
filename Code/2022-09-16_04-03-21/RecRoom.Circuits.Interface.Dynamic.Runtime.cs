using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DICLKKJCGFA<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer PJOHIICJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAFINNIHOLC(in TObject DEGGOOGCHFA, in TRpcParam PIBKCCAKALF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIOJLOPPALP(in TObject DEGGOOGCHFA, in TRpcParam PIBKCCAKALF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENEABFEPOMN(in TObject DEGGOOGCHFA, in TRpcParam PIBKCCAKALF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KCNLPNEHNAO(in TObject DEGGOOGCHFA, in TRpcParam PIBKCCAKALF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNGAHFBIKJD(in TObject DEGGOOGCHFA, in TRpcReceiver CEFJKGFKDKM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	TPlayer OBFCCAEODOO(in TObject DEGGOOGCHFA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JOFCDGKFOLD(in TObject DEGGOOGCHFA, in TPlayer LGGPAKMMAEI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	TSyncField CLMHDNOPCGN(in TObject DEGGOOGCHFA, in TSyncFieldParam PIBKCCAKALF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LODKDJJBHLD(in TSyncField MGKGEEIKGHD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HGGDEKBAMHC(in TSyncField MGKGEEIKGHD, in TSyncFieldValue CJMMBFLIBMO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface APDMDGFAAMJ<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPIOPAEGIGM(in TRpcParam MJHIGMCCOPA);
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
