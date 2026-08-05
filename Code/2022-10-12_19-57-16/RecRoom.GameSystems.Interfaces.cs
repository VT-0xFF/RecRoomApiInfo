using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HBDIBKMFAMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ENIJEBFPICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x29CFDC8029CFD0", Offset = "0x0", VA = "0x29CFDE0029CFD0", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CCAGLFFFGIN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NOOHPDDLKBC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29D0768029CFF0", Offset = "0x0", VA = "0x29D0780029CFF0", Slot = "2")]
	bool IPCODNLIADC(NKLAEFFIMFK HAGDGFGNGBI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29D07687404DF4", Offset = "0x0", VA = "0x29D07807404DF4", Slot = "3")]
	void AGLHPPHNGBF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BEECGMDFGBP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MOMPGHLPCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7404E068029D0CD", Offset = "0x0", VA = "0x7404E080029D0CD", Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IDAKMPKKEAF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29D1228029D0CD", Offset = "0x0", VA = "0x29D1240029D0CD", Slot = "0")]
	IDisposable Play(HHNHJJHMLHI NJADLHKOODJ, string DCAHIMBFJKG, float LHKNOFOGOFA, [Optional] Action FNAODFKKBJA, [Optional] object GBLEIOLILGK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29D12E87404E1C", Offset = "0x0", VA = "0x29D13007404E1C", Slot = "1")]
	IDisposable Play(HHNHJJHMLHI NJADLHKOODJ, float FDBBMHOJPLG, JAPANECPIKL JJKOFKONFAC, string DCAHIMBFJKG, Color? HKJFILNGBFP, string DKEAKIMIIGA, Color? GFACCGBOJFM, float LHKNOFOGOFA, [Optional] Action FNAODFKKBJA, [Optional] object GBLEIOLILGK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ECCGPMNDJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72EC3FA8029D234", Offset = "0x0", VA = "0x72EC3FC0029D234", Slot = "0")]
	void LPJJABHCHMK(KHMOACGNIHJ FELFFCMELCN, List<KeepsakeInstanceDTO> EJGIIBGHPBA);
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
