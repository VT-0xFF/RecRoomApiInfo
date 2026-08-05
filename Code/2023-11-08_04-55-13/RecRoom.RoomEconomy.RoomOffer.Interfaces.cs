using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PGBKJFEMJGC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BJPKLEOBMLD<APANCMLALFB> PJHIBGHEFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x233EE3892F8268", Offset = "0x0", VA = "0x233EE5092F8268", Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x92F827680233EEB", Offset = "0x0", VA = "0x92F827800233EEB", Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BJPKLEOBMLD<Guid> EEPBOFKLBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x233F3A80233EEB", Offset = "0x0", VA = "0x233F3C00233EEB", Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x233F3E892F8268", Offset = "0x0", VA = "0x233F40092F8268", Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x921107680233F65", Offset = "0x0", VA = "0x921107800233F65", Slot = "4")]
	Task<EFFPFBGFCJB<APANCMLALFB, string>> GDKMMOHCLCA(long GCFELHFPIGG, string NDLLBBKGIJD, string HBNFGFDAEMN, string JJGDEEOHCJI, int CGIIKGHBKIM, MLJKOAJPDMI JNACNBMPHFA, [Optional] Dictionary<Guid, int> HGOIKODANBM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23400C80233F65", Offset = "0x0", VA = "0x23400E00233F65", Slot = "5")]
	Task<EFFPFBGFCJB<APANCMLALFB, string>> DPCPHIDPCEF(Guid KCFLIJIFDIF, string NDLLBBKGIJD, string HBNFGFDAEMN, string JJGDEEOHCJI, int CGIIKGHBKIM, MLJKOAJPDMI JNACNBMPHFA, [Optional] Dictionary<Guid, int> HGOIKODANBM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x23400C892F810C", Offset = "0x0", VA = "0x23400E092F810C", Slot = "6")]
	Task<EFFPFBGFCJB<bool, string>> FHMEHKEANFI(Guid KCFLIJIFDIF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x92F81268023405F", Offset = "0x0", VA = "0x92F81280023405F", Slot = "7")]
	IEnumerable<APANCMLALFB> BKGNEJHHBNM();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2340638023405F", Offset = "0x0", VA = "0x2340650023405F", Slot = "8")]
	bool FHICKBGNGDO(Guid KCFLIJIFDIF, [Out] APANCMLALFB EILIDKJAKIM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x234063892F8138", Offset = "0x0", VA = "0x234065092F8138", Slot = "9")]
	bool FDHNEGKJLPE(Guid EFLGAAKBPNM, [Out] List<string> OKNMLFFCPAN);
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
