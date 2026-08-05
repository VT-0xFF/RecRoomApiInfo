using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PKIBGCAJLHC
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
public readonly struct KDKEFALHFFN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string MLEANJPMHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ENGCCPJAIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1CADC80", Offset = "0x1CAD080", VA = "0x181CADC80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BA60", Offset = "0x3D7AE60", VA = "0x183D7BA60")]
	public KDKEFALHFFN(string GLHIADDNDKB, bool LGFLCADACJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FEDCAJDBJCG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OHKODOMKLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BIAMAMIHHNN(FADMMEPBOKO PBFNLOBMJJD, bool PHHPGKLENNN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EICHPKLMDBA(KKLGAOKAOFM AFNMBPMIHMN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string KAHNNLEFECG(string IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PKIBGCAJLHC CECDPLNDNKL(string IKENFNDDIPB, string LMADGEINEAF, HDKPGOIAKAC FMFHCJFKACL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGCFKEOLJEJ(string IKENFNDDIPB, HDKPGOIAKAC FMFHCJFKACL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDKEFALHFFN JANMKJMPFLG(string IKENFNDDIPB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CGCLOBIGCGD(IEDMIHBCLFA OPHKHOFMGAH, CancellationToken GNJJGEHBGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HDKPGOIAKAC : IEquatable<HDKPGOIAKAC>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	long PIBGEMNFMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string BAGPMMOAKMM
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
public interface FADMMEPBOKO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MANJJPLNJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MILNPPODDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NLNEHIFIJPI
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
