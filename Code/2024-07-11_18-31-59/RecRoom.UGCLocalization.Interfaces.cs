using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HEFNODEIGBB
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
public readonly struct KMDIPCCJHJM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string INOFFPEFLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2B10", VA = "0x1808C4110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LIMELJKHDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA5A0", Offset = "0x1BB8FA0", VA = "0x181BBA5A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4221960", Offset = "0x4220360", VA = "0x184221960")]
	public KMDIPCCJHJM(string PGFCIKJHGNL, bool AAENMELCLEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BOKGGMAHILG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PGNEDBKBDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BBIDOBBCAGI(AIBDKGMIMGJ JEEJBJMNMEE, bool CKPMODOEIJG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAIBDOGECIC(CKJAAMAMPKA FCMADEBOIJK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string MKDHCEOOGIE(string EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HEFNODEIGBB MDMMLEKAMDM(string NNMCMDGKEKK, string LDPKCIGIIMG, LNOEHLHELHJ PEAOBKNBMDG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHEILKOAAIK(string NNMCMDGKEKK, LNOEHLHELHJ PEAOBKNBMDG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KMDIPCCJHJM JHHJNFNGLKL(string NNMCMDGKEKK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BEIBMELONCE(INAMFDDJCJB MEGACNKHFJL, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LNOEHLHELHJ : IEquatable<LNOEHLHELHJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	long CODEDOIEGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string BKLODLGGFPE
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
public interface AIBDKGMIMGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MONIDIHNPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IAFJAGJAAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CKJCEFHLBKL
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
