using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NMMCKIHJHMN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string BGPABBODICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FDOBJKEKOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MKOGEAKNHAI
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
public enum MEHGLCGHCMG
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
public readonly struct CHDBHDGJFOH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string PAIIGINHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NCEJKHHJDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x12EC450", Offset = "0x12EB450", VA = "0x1812EC450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xF26520", Offset = "0xF25520", VA = "0x180F26520")]
	public CHDBHDGJFOH(string FNFHAMDAPNA, bool NPHELNJCPNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HIHMNJNPEEO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EMJDJPPCMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNBNGBCDLAI(NMMCKIHJHMN OJGIKIHBCKE, bool DDHDBPLDGLB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPOFGJONOAL(OCMKINIOLDE CAPINCBBCIM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string IPKAOBPAEBI(string FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MEHGLCGHCMG KECKNFBJMIB(string BNKALJCFFDK, string LPNPMOOMCIB, ref OMOEALAKDAF PHNPADMMPCN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJPAOBMOKNN(string BNKALJCFFDK, OMOEALAKDAF PHNPADMMPCN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CHDBHDGJFOH LKLPDDLFILE(string BNKALJCFFDK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JGFOAIHADDE(CAMHKKGEKKA JDCEJMEBGBH, CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OMOEALAKDAF : IEquatable<OMOEALAKDAF>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	long FLJAKEAGLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string INLDDEPOFLJ
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
