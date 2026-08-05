using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NFHFGDLPBIE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BHBDLIFHFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2AC62B876ECB54", Offset = "0x0", VA = "0x2AC62D076ECB54", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CHCONOLCGMP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BEOLPBAJKFP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6BE877CDA90", Offset = "0x0", VA = "0x2AC6C0077CDA90", Slot = "2")]
	bool LLMMLCDEIOM(HJDPDAKNNCN AJGMGOAMMCD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76A2AB6802AC6E0", Offset = "0x0", VA = "0x76A2AB8002AC6E0", Slot = "3")]
	void AABJDPAJIBN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HNCILPJLLMC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MOILGANLEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AC779802AC6E0", Offset = "0x0", VA = "0x2AC77B002AC6E0", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PLICGBLNDBF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2AC779877CDB50", Offset = "0x0", VA = "0x2AC77B077CDB50", Slot = "0")]
	IDisposable Play(GOIIMPNDAAG OJGPOBEMKIO, string FNDHFIJPMPE, float PKBACDJFJJA, [Optional] Action KDDLOKAHKOL, [Optional] object KHCNIAPFECA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77CDB6A802AC781", Offset = "0x0", VA = "0x77CDB6C002AC781", Slot = "1")]
	IDisposable Play(GOIIMPNDAAG OJGPOBEMKIO, float MGKKNPPENJL, GGBBLPGEOBA NLPKLFKEHAA, string FNDHFIJPMPE, Color? LJHOLCAHOAL, string ILOEKIBGODH, Color? CFPENJOHNEJ, float PKBACDJFJJA, [Optional] Action KDDLOKAHKOL, [Optional] object KHCNIAPFECA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NNOOEHACKEM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7AE802AC790", Offset = "0x0", VA = "0x2AC7B0002AC790", Slot = "0")]
	void DBAOGJFDCOC(DOJAMBMLNII IMJHJEINJMP, List<KeepsakeInstanceDTO> FKOOEAJDJOB);
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
