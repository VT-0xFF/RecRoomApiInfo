using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EHEPBOMPJOD
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
public readonly struct OHNLOMCDIFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string HIIKLEIJFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ECMEMBCHKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFE0", Offset = "0xC1A3E0", VA = "0x180C1AFE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x15EEE20", Offset = "0x15EE220", VA = "0x1815EEE20")]
	public OHNLOMCDIFJ(string AOFEJGHEJNP, bool FEKEFBJEIID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JGCHGPOINCA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FJGGNFEPDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDDAKOKDECC(IPNJNHIHPDP IJLEHINPAGF, bool KFMEJIELJKA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIOBJICDJHF(OIBKBLGJIPN EDHFGAMFCNC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string MHKJIGIDGPI(string OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHEPBOMPJOD PJDDEOCDFFF(string DMDJHFCNJAP, string IPKJFPCBFNH, LGEFFNGAHCD FGGAIOBOFGA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOKIOAPCCLH(string DMDJHFCNJAP, LGEFFNGAHCD FGGAIOBOFGA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OHNLOMCDIFJ FGOCKILKMPK(string DMDJHFCNJAP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BOBCJNHHLLE(JLCHIDAEKKK FAGMDOIFLMG, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LGEFFNGAHCD : IEquatable<LGEFFNGAHCD>
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	long MHHGANKHAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string CHEOEBIHKAA
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
public interface IPNJNHIHPDP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MLFLBCBJEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ADABONNOGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EHIBOEEMHJN
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
