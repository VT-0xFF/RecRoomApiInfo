using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MCAIGEBAPCK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x914135A80232B40", Offset = "0x0", VA = "0x914135C00232B40", Slot = "0")]
	void DHCPIDBINNG(string DCCBOJHHHDF, string EECEAGNACGO, bool KFBBAKHNJGN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x232BC080232B40", Offset = "0x0", VA = "0x232BC200232B40", Slot = "1")]
	void EDGPJGKMMPB();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x232BCE8913B8F0", Offset = "0x0", VA = "0x232BD00913B8F0", Slot = "2")]
	void MFKJONLLMCH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x913A12A80232C00", Offset = "0x0", VA = "0x913A12C00232C00", Slot = "3")]
	void BCPNGNDGMNK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x232C3680232C00", Offset = "0x0", VA = "0x232C3800232C00", Slot = "4")]
	void HPNJCBNBAGM(string NLBKPHJJHIA, [Optional] string GBALFOMIFKD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IIACGBNOJPL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DGFIAAEDKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x232C3E89139D8C", Offset = "0x0", VA = "0x232C4009139D8C", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KKPPIAFLMCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MOEFFHDDIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9138ACE80232C66", Offset = "0x0", VA = "0x9138AD000232C66", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PAHDBKKCHEM> FHEPJLCMJIG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x913A12A80232CD0", Offset = "0x0", VA = "0x913A12C00232CD0", Slot = "3")]
	Task JMCKLNABHHJ();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x232D6B80232CD0", Offset = "0x0", VA = "0x232D6D00232CD0", Slot = "4")]
	void GPJBDIFOFCM();
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
