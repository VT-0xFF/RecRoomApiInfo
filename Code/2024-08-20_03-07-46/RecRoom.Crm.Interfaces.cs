using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CAAHEFDNKBK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA461AEE8027FFDB", Offset = "0x0", VA = "0xA461AF00027FFDB", Slot = "0")]
	void NBKIIOFHBBD(string KNMHLGJHCFC, string AMMDOLMBBDA, bool IBAGLCKMGOB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28002A8027FFDB", Offset = "0x0", VA = "0x28002C0027FFDB", Slot = "1")]
	void ONPBFBGAOBP();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28002E8A461AE0", Offset = "0x0", VA = "0x2800300A461AE0", Slot = "2")]
	void COHDGMIADMC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA24FD1A80280055", Offset = "0x0", VA = "0xA24FD1C00280055", Slot = "3")]
	void HCBLOMBGADA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2800FC80280055", Offset = "0x0", VA = "0x2800FE00280055", Slot = "4")]
	void DJDBOKCJAJF(string IHECLGKBIAJ, [Optional] string GLNBLMJIHEA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NBAKKNFCMLK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LFBGABMGCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2800FC8A463A04", Offset = "0x0", VA = "0x2800FE0A463A04", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HLKOKLEAEBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MIJGLKMJGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA463A1E8028014F", Offset = "0x0", VA = "0xA463A200028014F", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FBMMGENMCML> JFFLMEMKLGM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA463A1E802801A6", Offset = "0x0", VA = "0xA463A20002801A6", Slot = "3")]
	Task LFNNOPDGNGK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2801D3802801B0", Offset = "0x0", VA = "0x2801D5002801B0", Slot = "4")]
	void CLDDABPDPLI();
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
