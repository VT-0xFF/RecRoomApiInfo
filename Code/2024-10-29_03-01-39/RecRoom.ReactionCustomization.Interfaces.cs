using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PKOLAFCJEPF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OMLGIIEIDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2A5684802A55E0", Offset = "0x0", VA = "0x2A5686002A55E0", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GDBINPMHEFP PHLDOBLLPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A568E8A8744C4", Offset = "0x0", VA = "0x2A56900A8744C4", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GDBINPMHEFP MEGPKLFHEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8744C2802A5736", Offset = "0x0", VA = "0xA8744C4002A5736", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> OEJFPPMIFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A57D6802A5740", Offset = "0x0", VA = "0x2A57D8002A5740", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A57DE8A8734E8", Offset = "0x0", VA = "0x2A57E00A8734E8", Slot = "4")]
	void MCDPEHIIEPO(List<(string, BPHGMJMFCAD)> ECEOKAFBMIP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA87138E802A5867", Offset = "0x0", VA = "0xA871390002A5867", Slot = "5")]
	string[] AFOLCAPMDKO(string NHJIFHAEBEO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A5906802A5870", Offset = "0x0", VA = "0x2A5908002A5870", Slot = "6")]
	bool APJAAIPINIC(string NHJIFHAEBEO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A590E8A8734E8", Offset = "0x0", VA = "0x2A59100A8734E8", Slot = "7")]
	string KOBMANKEBCP(string NHJIFHAEBEO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xA8734E6802A599F", Offset = "0x0", VA = "0xA8734E8002A599F", Slot = "8")]
	BPHGMJMFCAD OCJADFEHMEP(string NHJIFHAEBEO);
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
