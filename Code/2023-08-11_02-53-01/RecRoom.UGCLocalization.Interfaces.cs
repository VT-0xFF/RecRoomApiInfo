using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MBBJDCMJPBE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string KMMOCAPNCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NCDKNAAIICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FAHHHLCNNFM
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
public enum HJCMOFLDBDH
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
public readonly struct CPKLILAGLCI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string ECMDAFNLHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MCOBKJCAGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE12560", Offset = "0xE10D60", VA = "0x180E12560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1AAFE90", Offset = "0x1AAE690", VA = "0x181AAFE90")]
	public CPKLILAGLCI(string AFMHCMJAMIM, bool GBPBALGOJPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PGBGDHIBGCE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PPHLPHPBEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEGAJHODFOB(MBBJDCMJPBE HNIHEJEANNM, bool HLEJICMEJHJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAAAKIPHAFJ(KHHPFHOAEJL LHKEKFAGIAO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string NHKIGFJHNOF(string AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HJCMOFLDBDH EHAGONJALFL(string HPHFPAEFIGC, string ODHKMJMLAIP, ref GHKPOHJAPKP NPHOKDDIOJD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIAAOKJKFOL(string HPHFPAEFIGC, GHKPOHJAPKP NPHOKDDIOJD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CPKLILAGLCI CFGGPKADHNM(string HPHFPAEFIGC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task IINCHPBGOPG(CACOFKKHDCM HDPBEFNDNDD, CancellationToken NNLBJPBEHPF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GHKPOHJAPKP : IEquatable<GHKPOHJAPKP>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	long LFODACJMPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string JAJKCIDCJIM
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
