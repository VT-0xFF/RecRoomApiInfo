using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FCBIIANKGIC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JHABGEBKEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6F8802AF6F0", Offset = "0x0", VA = "0x2AF6FA002AF6F0", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GIFNICJMCAD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PDEJNFDLBIM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2AF718802AF710", Offset = "0x0", VA = "0x2AF71A002AF710", Slot = "2")]
	bool LOMCBHMCDOB(BNDKPFJHMMD JPKLCIEHLOF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2AF71E875D2270", Offset = "0x0", VA = "0x2AF720075D2270", Slot = "3")]
	void LHADAMBMHGM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FONHOINMDOA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DEBKALPHFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75D226E802AF72A", Offset = "0x0", VA = "0x75D2270002AF72A", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MLCGJDDDGDE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2AF738802AF730", Offset = "0x0", VA = "0x2AF73A002AF730", Slot = "0")]
	IDisposable Play(NFOOMCPDOIP IINNBKIBJPL, string LNFAAKOAMML, float CINBMJOKHMJ, [Optional] Action PKPGAEOFIGD, [Optional] object DHDAOLBKMGH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2AF73E875D2270", Offset = "0x0", VA = "0x2AF740075D2270", Slot = "1")]
	IDisposable Play(NFOOMCPDOIP IINNBKIBJPL, float PLAJHBDICIO, JMDEHBMFPFP LICBINPKDAC, string LNFAAKOAMML, Color? BEIJLHHPOGE, string IMHEBABFKLO, Color? OINBJCHJGAL, float CINBMJOKHMJ, [Optional] Action PKPGAEOFIGD, [Optional] object DHDAOLBKMGH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HPIGGOHLABK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75D226E802AF74A", Offset = "0x0", VA = "0x75D2270002AF74A", Slot = "0")]
	void CMEILOHPMLA(IFHIAHJKMIE MJJEGFLNEIJ, List<KeepsakeInstanceDTO> ABEHBJLLFML);
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
