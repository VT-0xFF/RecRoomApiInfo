using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EELJBPKLIMC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29BB3C8029BA75", Offset = "0x0", VA = "0x29BB3E0029BA75", Slot = "0")]
	void IMCKICAGPDO(string DDNMNIOMOPM, string DJGKCKPEHKE, bool ILDDBPEHBCL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29BB3C8A9BED30", Offset = "0x0", VA = "0x29BB3E0A9BED30", Slot = "1")]
	void POBFPFKLAJM();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA9BED4A8029BB8F", Offset = "0x0", VA = "0xA9BED4C0029BB8F", Slot = "2")]
	void ALGHAINFECP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29BB938029BB8F", Offset = "0x0", VA = "0x29BB950029BB8F", Slot = "3")]
	void IDFBIHPLBCH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29BB938A9BED5C", Offset = "0x0", VA = "0x29BB950A9BED5C", Slot = "4")]
	void LMBLBOHGOBA(string HLIJNPAAKME, [Optional] string CNFHHHDPALA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GAHCGONFOIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CHBCGHPNKEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NGBOIGOHKJD MMJLKAEHBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA9BED4A8029BBE6", Offset = "0x0", VA = "0xA9BED4C0029BBE6", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KGAIEAFJHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29BC138029BBF0", Offset = "0x0", VA = "0x29BC150029BBF0", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<AOCCEFFEDED> LELELHNFFJI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29BD1D8029BCCE", Offset = "0x0", VA = "0x29BD1F0029BCCE", Slot = "4")]
	Task CGCFJDLGJFP();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29BD1D8A9BE62C", Offset = "0x0", VA = "0x29BD1F0A9BE62C", Slot = "5")]
	void PGLAGHNEHAA();
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
