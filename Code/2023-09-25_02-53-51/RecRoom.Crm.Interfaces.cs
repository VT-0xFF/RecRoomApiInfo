using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JPKODDLNBAL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22460E88ECAC0C", Offset = "0x0", VA = "0x22461008ECAC0C", Slot = "0")]
	void AIDGLKEKHDG(string PKAFLNKNDJE, string PLGKONKNIKB, bool JCMPOPLOMNK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8ECB38A802246A8", Offset = "0x0", VA = "0x8ECB38C002246A8", Slot = "1")]
	void OMMAFBIMIGL();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x224735802246B0", Offset = "0x0", VA = "0x224737002246B0", Slot = "2")]
	void LFDFKJPOMOG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22473E88EC7C2C", Offset = "0x0", VA = "0x22474008EC7C2C", Slot = "3")]
	void DIAMGGCMCCD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8EC9C7E802247CF", Offset = "0x0", VA = "0x8EC9C80002247CF", Slot = "4")]
	void BMLLKMFPINK(string BKPFJDEPNEJ, [Optional] string JFNGCICMBII);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KNJNLLGBPHO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DIHGILGODNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x224868802247D0", Offset = "0x0", VA = "0x22486A002247D0", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x22486E88ECAC0C", Offset = "0x0", VA = "0x22487008ECAC0C", Slot = "1")]
	Task AJGMOCJMJGA();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8ECABDA80224916", Offset = "0x0", VA = "0x8ECABDC00224916", Slot = "2")]
	void CGCDLMDFFPJ();
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
