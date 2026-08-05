using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DEHIHNEMMIN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA417D8A8027FEC7", Offset = "0x0", VA = "0xA417D8C0027FEC7", Slot = "0")]
	void NGNFBEPEMJF(string DFMIELEHLPM, string LHCOJKHLEMM, bool DBGMFJAJAFH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27FF168027FEC7", Offset = "0x0", VA = "0x27FF180027FEC7", Slot = "1")]
	void NBFLPOPALFD();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27FF1E8A417D7C", Offset = "0x0", VA = "0x27FF200A417D7C", Slot = "2")]
	void MODEKIAAPEA();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2C628027FF45", Offset = "0x0", VA = "0xA2D2C640027FF45", Slot = "3")]
	void EMGEBMIPGAF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27FFFE8027FF45", Offset = "0x0", VA = "0x2800000027FF45", Slot = "4")]
	void EFHMELNPOFL(string CFPBMLMOKEI, [Optional] string LDFDOGLNKBA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GHFBDKANFMN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DFOOCDEIBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27FFFE8A4186A0", Offset = "0x0", VA = "0x2800000A4186A0", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CKKAIGEGDOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CELPDEMCICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA4186BA80280051", Offset = "0x0", VA = "0xA4186BC00280051", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MFHODFBFBCJ> IHCIBBBHIBI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA4186BA802800A8", Offset = "0x0", VA = "0xA4186BC002800A8", Slot = "3")]
	Task HGDANEHJCNG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2800D3802800B0", Offset = "0x0", VA = "0x2800D5002800B0", Slot = "4")]
	void BOPCGMPFNGG();
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
