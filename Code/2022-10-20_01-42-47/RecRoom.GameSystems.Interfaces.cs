using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HDDHAPBAIMI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HACFIBBIAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x29E4EE87456DC4", Offset = "0x0", VA = "0x29E4F007456DC4", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ALHGGIGIAMK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HIAEMDMKGMP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29E54287456DD4", Offset = "0x0", VA = "0x29E54407456DD4", Slot = "2")]
	bool KNMJNCNPEIL(FIEIEDKJONJ ILKNFOJNGMK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7456DE68029E54B", Offset = "0x0", VA = "0x7456DE80029E54B", Slot = "3")]
	void ENLLOFEENAF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KMCIKKGPHKM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HNKKMPKPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29E55B8029E550", Offset = "0x0", VA = "0x29E55D0029E550", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LNDALGFGLLI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29E55B873229D0", Offset = "0x0", VA = "0x29E55D073229D0", Slot = "0")]
	IDisposable Play(IIFJKKEFKMJ LGHAOJOJBOG, string IBAMPIFAGPJ, float CPFLOLADECM, [Optional] Action GKAOJENLDLL, [Optional] object OOHMNLIIOII);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7456DF68029E5A0", Offset = "0x0", VA = "0x7456DF80029E5A0", Slot = "1")]
	IDisposable Play(IIFJKKEFKMJ LGHAOJOJBOG, float AFENNENHJCK, JCEJOPOMIAN CDEMCJJCCNL, string IBAMPIFAGPJ, Color? BJAKCLLENJI, string IOPCAFBLALI, Color? JKPIKKJPPPL, float CPFLOLADECM, [Optional] Action GKAOJENLDLL, [Optional] object OOHMNLIIOII);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EIBPNDCCNNG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29E5A58029E5A0", Offset = "0x0", VA = "0x29E5A70029E5A0", Slot = "0")]
	void DMLKKGKBHID(IOFNFGHMKGC DBFKJDOIKKB, List<KeepsakeInstanceDTO> FMCKCKAGPMH);
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
