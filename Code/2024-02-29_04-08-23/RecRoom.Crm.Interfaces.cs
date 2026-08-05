using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CFDPEGBHBCB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24341A80243375", Offset = "0x0", VA = "0x24341C00243375", Slot = "0")]
	void AICJOEOKFEK(string LJOEKNEACHB, string NCOGLNCIKOP, bool HEJLJMCCPGJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24341A8975D5D0", Offset = "0x0", VA = "0x24341C0975D5D0", Slot = "1")]
	void DNGDOOJGIDG();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x975D5EA8024346D", Offset = "0x0", VA = "0x975D5EC0024346D", Slot = "2")]
	void ELDMOKDHLEF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2434718024346D", Offset = "0x0", VA = "0x2434730024346D", Slot = "3")]
	void GOEEKDABALG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2434718975D5FC", Offset = "0x0", VA = "0x2434730975D5FC", Slot = "4")]
	void AIPEKCGBCBE(string HNCMMELDDJD, [Optional] string BNAOJIFJIDN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NICMMJBEPIA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GEIANIJEPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x975D5EA802434C4", Offset = "0x0", VA = "0x975D5EC002434C4", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CHKOBOBKOIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HOCMFPJFBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2434F2802434D0", Offset = "0x0", VA = "0x2434F4002434D0", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<DKAKNDIBGIH> MDJHELKKIEC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2435D880243589", Offset = "0x0", VA = "0x2435DA00243589", Slot = "3")]
	Task FCIFMHNEBDM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2435D88975C0EC", Offset = "0x0", VA = "0x2435DA0975C0EC", Slot = "4")]
	void MNGHADJNDMD();
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
