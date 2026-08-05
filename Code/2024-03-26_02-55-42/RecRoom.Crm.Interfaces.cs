using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JMNBGKDOAIG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24933389862140", Offset = "0x0", VA = "0x24933509862140", Slot = "0")]
	void OOBMFPFFGBN(string JPPCEMGCBEB, string KJABOCMHDOG, bool FJPFDOBBIFL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9A3732E802493EC", Offset = "0x0", VA = "0x9A37330002493EC", Slot = "1")]
	void GAAOPMENGPG();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24943B802493EC", Offset = "0x0", VA = "0x24943D002493EC", Slot = "2")]
	void PNEONPGNFFG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24943B89A3734C", Offset = "0x0", VA = "0x24943D09A3734C", Slot = "3")]
	void HIAJELGOHPH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9A3735A80249443", Offset = "0x0", VA = "0x9A3735C00249443", Slot = "4")]
	void PKDJPAGJOCH(string CIKIAALPDMP, [Optional] string FJPLJOOELHA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JEDJMCAIPEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ILOMNBIHEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24949280249443", Offset = "0x0", VA = "0x24949400249443", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HKILBGOJPCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DIICEPPNFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24949E89A3734C", Offset = "0x0", VA = "0x2494A009A3734C", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KPJIBNJCFDM> MCLIGDHDDDI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24955789A380B0", Offset = "0x0", VA = "0x24955909A380B0", Slot = "3")]
	Task EOPEJCOCBHD();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9A380CA802495AA", Offset = "0x0", VA = "0x9A380CC002495AA", Slot = "4")]
	void HIHHBKCGMJF();
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
