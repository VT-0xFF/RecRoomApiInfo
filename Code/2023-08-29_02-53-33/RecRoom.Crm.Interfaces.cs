using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EMICGEIMIOF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2582AE88A7BEFC", Offset = "0x0", VA = "0x2582B008A7BEFC", Slot = "0")]
	void FPEGBOPLJKI(string LBMAILMEAED, string KLDNLDLLNND, bool MGDAPOJHHPB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8A78406802582D9", Offset = "0x0", VA = "0x8A78408002582D9", Slot = "1")]
	void LKAKOHDIFDK();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x258393802582D9", Offset = "0x0", VA = "0x258395002582D9", Slot = "2")]
	void OJFHEEKFGDH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x25839388A7AC84", Offset = "0x0", VA = "0x25839508A7AC84", Slot = "3")]
	void CHKALINELBA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8A7ACA2802583DE", Offset = "0x0", VA = "0x8A7ACA4002583DE", Slot = "4")]
	void EDAHAFEFEOD(string OFOLDFODADE, [Optional] string BJEAEFHFKCD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KABDAIIIKJE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GNHJBMKBFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2583E2802583DE", Offset = "0x0", VA = "0x2583E4002583DE", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2583E288A7ACB4", Offset = "0x0", VA = "0x2583E408A7ACB4", Slot = "1")]
	Task DJICDEMBLDL();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8A7ACA28025842D", Offset = "0x0", VA = "0x8A7ACA40025842D", Slot = "2")]
	void FJKIFKDAPPI();
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
