using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DEGJPEPEGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28EDCC8028EDA0", Offset = "0x0", VA = "0x28EDCE0028EDA0", Slot = "0")]
	void EBLCIBIJEON(string CBMKNNPGFNJ, string CNKKBKBNKII, bool EHHIBJIGIHI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28EDCE88D336C0", Offset = "0x0", VA = "0x28EDD008D336C0", Slot = "1")]
	void MHKJDLEHOPO();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8D336BE8028EE00", Offset = "0x0", VA = "0x8D336C00028EE00", Slot = "2")]
	void BOIGBFDMLAC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28EE368028EE00", Offset = "0x0", VA = "0x28EE380028EE00", Slot = "3")]
	void JEOCMOBKGIK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28EE3E88D335F0", Offset = "0x0", VA = "0x28EE4008D335F0", Slot = "4")]
	void NNPHNIKDIEN(string CCBCMGPHDLJ, [Optional] string JNKFKBEKMGG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FNHDOPIJDOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OPCMBDOMNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D336BE8028EE6E", Offset = "0x0", VA = "0x8D336C00028EE6E", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28EEA68028EE70", Offset = "0x0", VA = "0x28EEA80028EE70", Slot = "1")]
	Task OKGBGAPINEO();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28EEAE88D335F0", Offset = "0x0", VA = "0x28EEB008D335F0", Slot = "2")]
	void OMJIIKCHOAL();
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
