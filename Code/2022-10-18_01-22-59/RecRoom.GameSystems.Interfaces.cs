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
		[Cpp2IlInjected.Address(RVA = "0x731AD228029D091", Offset = "0x0", VA = "0x731AD240029D091", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ALHGGIGIAMK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HIAEMDMKGMP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7319C4E8029D14B", Offset = "0x0", VA = "0x7319C500029D14B", Slot = "2")]
	bool KNMJNCNPEIL(FIEIEDKJONJ ILKNFOJNGMK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29D1DF8029D150", Offset = "0x0", VA = "0x29D1E10029D150", Slot = "3")]
	void ENLLOFEENAF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KMCIKKGPHKM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HNKKMPKPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29D1EE8731AD24", Offset = "0x0", VA = "0x29D1F00731AD24", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LNDALGFGLLI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7319C4E8029D20B", Offset = "0x0", VA = "0x7319C500029D20B", Slot = "0")]
	IDisposable Play(IIFJKKEFKMJ LGHAOJOJBOG, string IBAMPIFAGPJ, float CPFLOLADECM, [Optional] Action GKAOJENLDLL, [Optional] object OOHMNLIIOII);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29D29F8029D210", Offset = "0x0", VA = "0x29D2A10029D210", Slot = "1")]
	IDisposable Play(IIFJKKEFKMJ LGHAOJOJBOG, float AFENNENHJCK, JCEJOPOMIAN CDEMCJJCCNL, string IBAMPIFAGPJ, Color? BJAKCLLENJI, string IOPCAFBLALI, Color? JKPIKKJPPPL, float CPFLOLADECM, [Optional] Action GKAOJENLDLL, [Optional] object OOHMNLIIOII);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EIBPNDCCNNG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29D2AE8731AD24", Offset = "0x0", VA = "0x29D2B00731AD24", Slot = "0")]
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
