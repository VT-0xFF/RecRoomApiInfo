using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GNDCPHCJCCL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA3518368027F1FD", Offset = "0x0", VA = "0xA3518380027F1FD", Slot = "0")]
	void DNEDLBAJEGD(string CEMANFMEADE, string EOMPCBIAMOO, bool BFNBPFHIADJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27F2288027F200", Offset = "0x0", VA = "0x27F22A0027F200", Slot = "1")]
	void ABMGLEPBMGH();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27F2288A203B7C", Offset = "0x0", VA = "0x27F22A0A203B7C", Slot = "2")]
	void MMOOLEFJFHD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA35141A8027F307", Offset = "0x0", VA = "0xA35141C0027F307", Slot = "3")]
	void JPOAMPAJNGA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27F3568027F307", Offset = "0x0", VA = "0x27F3580027F307", Slot = "4")]
	void PGFKCCEHPCM(string NDPBPDDOLMD, [Optional] string NJCGMCCDFID);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LDEDPNDHJLM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GKHKEMOFPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27F3568A351438", Offset = "0x0", VA = "0x27F3580A351438", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JFCFDFMBCLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FNCDHDBJGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA3514468027F35E", Offset = "0x0", VA = "0xA3514480027F35E", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<INGBCIHDPDM> FOIOBPOMJDI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA15EA5E8027F3D5", Offset = "0x0", VA = "0xA15EA600027F3D5", Slot = "3")]
	Task CCPNKNOIBEC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27F4968027F3D5", Offset = "0x0", VA = "0x27F4980027F3D5", Slot = "4")]
	void GLMNPCAHJLC();
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
