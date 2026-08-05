using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OEEDNMMFHOC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DFJAHBIGIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75EAFA6802A7849", Offset = "0x0", VA = "0x75EAFA8002A7849", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BPJNBFNJBMJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OKKHDGAGDIB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75EC072802A7901", Offset = "0x0", VA = "0x75EC074002A7901", Slot = "2")]
	bool GINAJMPILCG(BHKHJDMPNOC CBDMOLBDGNP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A7929802A7910", Offset = "0x0", VA = "0x2A792B002A7910", Slot = "3")]
	void EANDLCOKCOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OHAGKEEDBFD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BNFABGOGNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A792E875EAFA0", Offset = "0x0", VA = "0x2A7930075EAFA0", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface INICFBPFBEI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75EC072802A79C1", Offset = "0x0", VA = "0x75EC074002A79C1", Slot = "0")]
	IDisposable Play(MDOGAJLHJNL JIDDPJJGCBL, string PJIPJEKMNDN, float IFDELLDHIPH, [Optional] Action MCFINHLOBAO, [Optional] object GNGKIBCGJGM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A79E9802A79D0", Offset = "0x0", VA = "0x2A79EB002A79D0", Slot = "1")]
	IDisposable Play(MDOGAJLHJNL JIDDPJJGCBL, float EAMAPAINIOB, GLKDFMKEKCB INHBNPJNLAN, string PJIPJEKMNDN, Color? OPMAKAAGDNA, string EKJFALFEHBK, Color? GEOFJDIFJGD, float IFDELLDHIPH, [Optional] Action MCFINHLOBAO, [Optional] object GNGKIBCGJGM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IGIAKJHJMJO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A79EE875EAFA0", Offset = "0x0", VA = "0x2A79F0075EAFA0", Slot = "0")]
	void CPCGCAJMKHF(BLKLDFBMGPO FDKJOICKJIH, List<KeepsakeInstanceDTO> BECPPJDKIHJ);
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
