using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HACJNJOMGPF
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
public readonly struct FLLAIIIAIID
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string BNLCGJMBNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ECLIDHNEDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x180F600", Offset = "0x180E600", VA = "0x18180F600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3A50C20", Offset = "0x3A4FC20", VA = "0x183A50C20")]
	public FLLAIIIAIID(string EJDEHHPOEKA, bool FJNCPMIAGCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FCBOKDDFNMF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CPNBFADJHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJCEAJNKENN(AEEBJFDDJKI PFIDAIAGHJK, bool NHIMOAGIDEG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKOACGIKBEC(LNIMNABFGFK EINEAGMJDPE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string AMAAIFDOGPH(string PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HACJNJOMGPF LHGKMKEPBON(string AIILFLBNNCM, string ONDDMEPBDDI, EOIFFKEGMMC EONEKJHIIJJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCAFCOGBLKD(string AIILFLBNNCM, EOIFFKEGMMC EONEKJHIIJJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FLLAIIIAIID NONIAMLDDBD(string AIILFLBNNCM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CLCLAMKKPAB(GIFIJHKEGCI NEHHMEJGJEP, CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EOIFFKEGMMC : IEquatable<EOIFFKEGMMC>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	long GMIBMNELHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string KGOOFJIHGLC
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
public interface AEEBJFDDJKI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string BMJNHOGGBPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OIAKIKAFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LAKNBOENMDE
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
