using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HDJJMDJNBHG
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
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct FGOJMAHOADG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string MNGNIFIKPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FBJJPAHHKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x19B6D00", Offset = "0x19B5F00", VA = "0x1819B6D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3890760", Offset = "0x388F960", VA = "0x183890760")]
	public FGOJMAHOADG(string HHOFNBFBJPK, bool KAIDNLEPCCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MJEIAMCDOKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HDEDIPAMLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFNCCOGHDJM(OECPDJHIKDC NPGLLJKPDFJ, bool KIOKGDOKJKG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIDIMCPOBHP(KCKCHBANCCN MDDPLLFCMCP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string LIPEDOFFNKE(string GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDJJMDJNBHG DAGOBOLNMNI(string BCCNBNMLJOF, string HEEIDJMADFG, MJHNPHNFNIK GADFEAMPAMO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NICHENKNCNL(string BCCNBNMLJOF, MJHNPHNFNIK GADFEAMPAMO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FGOJMAHOADG EONKCMIEKGG(string BCCNBNMLJOF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task LFJFDIDHNBG(LFJINOFAHCP LMHBHCNFPNB, CancellationToken IOOGCHJMBIE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MJHNPHNFNIK : IEquatable<MJHNPHNFNIK>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	long PAIBFKFLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string BHDIICGNBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OECPDJHIKDC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string KEHEIENBIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CBNBECLKFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IJDEJOFAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RefreshLocalizableContent();
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
