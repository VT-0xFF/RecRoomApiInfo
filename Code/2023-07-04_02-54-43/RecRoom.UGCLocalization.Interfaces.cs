using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LEFGCDHBCAB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string FKDGDPBLJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PJJPFLJFMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DDNADNDLPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RefreshLocalizableContent();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JKFMKCFFHLK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Translated,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	AwaitingTranslations,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Untranslated
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct BPAPMKHIBDL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string IDNEPKHJHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BNOGBFNCOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x15C4E70", Offset = "0x15C3470", VA = "0x1815C4E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xFA9D10", Offset = "0xFA8310", VA = "0x180FA9D10")]
	public BPAPMKHIBDL(string EGOBKGDOFOI, bool KPOEMICGNFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PKMMECKHDCL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HOMBPKKEKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LAICFKAMPNM(LEFGCDHBCAB BIIKLPMNIBF, bool OGJCOIOGMOG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDMBIHJLLOF(NGDMEJFKJLL DNCLKGCICOE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string OFHPBIKMAFP(string LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JKFMKCFFHLK MOGGJOEKODO(string MPJFBLCPPIA, string BDIPIDIIILI, ref POBLHANKLOE LDGLMPNPPHE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGBOGAPCOMF(string MPJFBLCPPIA, POBLHANKLOE LDGLMPNPPHE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BPAPMKHIBDL OLJJNFLMEIK(string MPJFBLCPPIA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task HKHHAPGGIEE(KBDALPDHODH EGNEHPMLPBH, CancellationToken OOAGLCBNIOG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface POBLHANKLOE : IEquatable<POBLHANKLOE>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	long NEAPDBBCPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string PNEJJFAJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}
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
