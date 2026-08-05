using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MGEPEFNMFMD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x248CA88991E624", Offset = "0x0", VA = "0x248CAA0991E624", Slot = "0")]
	void HPBPDGENIPO(string DLGLJMKBCEO, string BMGINPJOPHP, bool OAIFIOKDPJA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x991E63280248CB0", Offset = "0x0", VA = "0x991E63400248CB0", Slot = "1")]
	void EADLFKJBJOI();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x248CFF80248CB0", Offset = "0x0", VA = "0x248D0100248CB0", Slot = "2")]
	void NPPAJMDCKLD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x248D0E8991E624", Offset = "0x0", VA = "0x248D100991E624", Slot = "3")]
	void NANIPGNDCCB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x980A59E80248D35", Offset = "0x0", VA = "0x980A5A000248D35", Slot = "4")]
	void DMLAHKIINPB(string FPILOFCFNEM, [Optional] string HACJOILELMK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GOKKHLHNFJK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NKLFGOJCFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x248DDC80248D35", Offset = "0x0", VA = "0x248DDE00248D35", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KFHANGMAIPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LLNGNMGGPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x248DDC8991D888", Offset = "0x0", VA = "0x248DDE0991D888", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GALDHNEPICO> IHGNKCIMBND;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x248E338991D8B4", Offset = "0x0", VA = "0x248E350991D8B4", Slot = "3")]
	Task HAJAGMDCLHL();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x991D8A280248E86", Offset = "0x0", VA = "0x991D8A400248E86", Slot = "4")]
	void KEPEANOIAHO();
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
