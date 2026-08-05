using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ECAHLAJMOFK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23BD0D8023BCBE", Offset = "0x0", VA = "0x23BD0F0023BCBE", Slot = "0")]
	void HLFPFHIHCMA(string LENMKHBHCBM, string MBJBHCPNIBI, bool LKGFONEHDGL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23BD0D895EDAF0", Offset = "0x0", VA = "0x23BD0F095EDAF0", Slot = "1")]
	void EMCCHJOFDHJ();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x95EDAFE8023BD15", Offset = "0x0", VA = "0x95EDB000023BD15", Slot = "2")]
	void KBOMDJHAKIB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23BD648023BD15", Offset = "0x0", VA = "0x23BD660023BD15", Slot = "3")]
	void ACKJKBFDFGF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23BD6E895EDAF0", Offset = "0x0", VA = "0x23BD70095EDAF0", Slot = "4")]
	void AHKOBBOCPNG(string EDHFPGBPPLM, [Optional] string NLCEAKEHAGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CMPGLMGAGIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GGJCIOBFNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x94FD09A8023BD95", Offset = "0x0", VA = "0x94FD09C0023BD95", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FAFKBJOHBKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ANFOMKPNPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23BE3C8023BD95", Offset = "0x0", VA = "0x23BE3E0023BD95", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ABBHELCIEJL> DJGAHKDFGLA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23BE938023BE8F", Offset = "0x0", VA = "0x23BE950023BE8F", Slot = "3")]
	Task FILODNFGCKM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23BE93895EDE00", Offset = "0x0", VA = "0x23BE95095EDE00", Slot = "4")]
	void AIKIIHKLAJH();
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
