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
		[Cpp2IlInjected.Address(RVA = "0x29F8518746C4F8", Offset = "0x0", VA = "0x29F8530746C4F8", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ALHGGIGIAMK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HIAEMDMKGMP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29F8AE8746C4F8", Offset = "0x0", VA = "0x29F8B00746C4F8", Slot = "2")]
	bool KNMJNCNPEIL(FIEIEDKJONJ ILKNFOJNGMK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x73FAF9E8029F8D7", Offset = "0x0", VA = "0x73FAFA00029F8D7", Slot = "3")]
	void ENLLOFEENAF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KMCIKKGPHKM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HNKKMPKPCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F9898029F8D7", Offset = "0x0", VA = "0x29F98B0029F8D7", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LNDALGFGLLI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29F9898746D374", Offset = "0x0", VA = "0x29F98B0746D374", Slot = "0")]
	IDisposable Play(IIFJKKEFKMJ LGHAOJOJBOG, string IBAMPIFAGPJ, float CPFLOLADECM, [Optional] Action GKAOJENLDLL, [Optional] object OOHMNLIIOII);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x746D3928029F9D4", Offset = "0x0", VA = "0x746D3940029F9D4", Slot = "1")]
	IDisposable Play(IIFJKKEFKMJ LGHAOJOJBOG, float AFENNENHJCK, JCEJOPOMIAN CDEMCJJCCNL, string IBAMPIFAGPJ, Color? BJAKCLLENJI, string IOPCAFBLALI, Color? JKPIKKJPPPL, float CPFLOLADECM, [Optional] Action GKAOJENLDLL, [Optional] object OOHMNLIIOII);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EIBPNDCCNNG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29F9D88029F9D4", Offset = "0x0", VA = "0x29F9DA0029F9D4", Slot = "0")]
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
