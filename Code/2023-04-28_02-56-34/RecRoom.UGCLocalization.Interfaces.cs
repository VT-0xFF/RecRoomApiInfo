using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EAMEAMPLBDP
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
public readonly struct NJDEEAHEMBK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string ELLLOODOFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BFGCPMOMPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C1BE0", Offset = "0x8C05E0", VA = "0x1808C1BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8C8AC0", Offset = "0x8C74C0", VA = "0x1808C8AC0")]
	public NJDEEAHEMBK(string JNIGPBNMPDD, bool ILAAJMNMEPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GIFKACLJBBM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MOGPIOFAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NKOEBNIMPNM(DAFEMFMFPJA MCLIFNMABNA, bool EFCPHECCPHK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGDLNKEAMLL(ALDNBFOLDOE GOKPFGBACOI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string ELLIBKODFNO(string MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EAMEAMPLBDP HBFAGJBJJNN(string INMBNMCFFPA, string KCGHNGOMAMI, ref INPGLFCLBEJ MAJGOGDLOBD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JAGDKLGLFGG(string INMBNMCFFPA, INPGLFCLBEJ MAJGOGDLOBD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NJDEEAHEMBK EJMPFDGEOBO(string INMBNMCFFPA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task MDAODOAONHN(OAGGKMECOKN CFEABAFCLMD, CancellationToken OIMNLGJCBEC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface INPGLFCLBEJ : IEquatable<INPGLFCLBEJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	long IKLMOKJELML
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string ODOOPBEOJAM
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
public interface DAFEMFMFPJA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string NHBHMEJMJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JAHNMDCJHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EAAGMANEEBE
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
