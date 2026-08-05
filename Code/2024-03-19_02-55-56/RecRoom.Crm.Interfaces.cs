using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BOCJODECEFO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x99FC91A802457EE", Offset = "0x0", VA = "0x99FC91C002457EE", Slot = "0")]
	void BAEFOJHIKFM(string JNEGCIDMOGG, string NHBJDCAGEJI, bool MHHCJOHIIGD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24583D802457EE", Offset = "0x0", VA = "0x24583F002457EE", Slot = "1")]
	void BLIOGPCIHHD();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24583D899FC938", Offset = "0x0", VA = "0x24583F099FC938", Slot = "2")]
	void FDHGJDKJNHB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x99FC94680245845", Offset = "0x0", VA = "0x99FC94800245845", Slot = "3")]
	void AFOEAKFECPP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24589480245845", Offset = "0x0", VA = "0x24589600245845", Slot = "4")]
	void FFBGLDABOMD(string GGOPKPCEMFD, [Optional] string MLOKDHMCEII);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JNLIAFJCIFC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KIOJPJOHNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24589E899FC938", Offset = "0x0", VA = "0x2458A0099FC938", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NKFNHHAMDHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ELDDDBMBKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98017EA802458C5", Offset = "0x0", VA = "0x98017EC002458C5", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FBGNEADOGLD> EFNCAKFJMIA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x99FD836802459BD", Offset = "0x0", VA = "0x99FD838002459BD", Slot = "3")]
	Task DPGLELIALOP();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2459C1802459BD", Offset = "0x0", VA = "0x2459C3002459BD", Slot = "4")]
	void FPNJJPKFGNF();
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
