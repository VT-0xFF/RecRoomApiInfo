using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IIPCGNHBDBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string EJLEAJAONNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ANKFFPMIICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IGEMAEIFGNH
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
public enum IBODKBDEGLL
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
public readonly struct ILIHEFDCIND
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string JIANFOCJEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool APOFLHHKGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD9A8F0", Offset = "0xD99AF0", VA = "0x180D9A8F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x15BD010", Offset = "0x15BC210", VA = "0x1815BD010")]
	public ILIHEFDCIND(string LOACANDAGDF, bool IEHALBACNJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GGJDABNIJEB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NFFEIKOLNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MEABLEMIEJH(IIPCGNHBDBJ MKENHFKHDMB, bool EECCCGAOPOH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBBFDLFKIKM(PPPFGNOFILG DONGKHHNBIB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string OEEEKEEEDEO(string FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IBODKBDEGLL DAHOBBNHMGP(string LFAFPPNIHNP, string FGIADOJFAEB, ref HJAJAKABAFB EHJGMOKPNIA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMOFDKIJNFC(string LFAFPPNIHNP, HJAJAKABAFB EHJGMOKPNIA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ILIHEFDCIND EAPELFFDGGM(string LFAFPPNIHNP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task ICNLJOAKLKL(DIGFFKIMPNG MHPKONNINLP, CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HJAJAKABAFB : IEquatable<HJAJAKABAFB>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	long BGDCEHONODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string DHOHAFONONK
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
