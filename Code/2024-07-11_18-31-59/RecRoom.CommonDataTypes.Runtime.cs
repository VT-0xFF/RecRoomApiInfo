using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FABKIOJODAO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	PERMANENT,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	ROOM_SUPPORT,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	CUSTOM_LOCOMOTION,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	DEBUG
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AKDKNLGGONO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OCNFCEPHEAO GDEEMMBHFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OCNFCEPHEAO JCJEMAAHHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool INFBNBDEBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KCKDMFCBCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EHODCIMNDCH OPCPHAMFJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(EBMIOPCOADC AFMFLPCPANL, object EOCJCEFCOOA, FABKIOJODAO CBHPEKJLLAF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object EOCJCEFCOOA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JCFHEBGCHLI
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Code,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	PartyGesture,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	ProfileScreen,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PeopleMenuShortcut,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	InviteToPartyDialog,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	PartyInviteInChat,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AutoRejoinPartyChat,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	InviteOnlineFriends,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	PartyInviteMessage,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	PlayTogether,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	OpenProfileRadialMenu
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OCNFCEPHEAO
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CKJFBEDOINM
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KINOJIILIBB
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum EBMIOPCOADC
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NCJHNCDKAGB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x680DC90", Offset = "0x680C690", VA = "0x18680DC90")]
	public static OCNFCEPHEAO KNFJJLCOGFD(this EBMIOPCOADC DNCAOAEPAKK)
	{
		return default(OCNFCEPHEAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[GPDIKBEHPOJ]
public class KEIECJPLCAO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string HMLJPLOGNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x851AF0", VA = "0x1808530F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public KEIECJPLCAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GPDIKBEHPOJ]
public class BMFPGMICNOM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long GKKIJACBHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public BMFPGMICNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[GPDIKBEHPOJ]
public class MGADKKINIPP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BMKBFHAKCHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public MGADKKINIPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[GPDIKBEHPOJ]
public class KOINIJBALMN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long JEFJBKLBBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public KOINIJBALMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[GPDIKBEHPOJ]
public class JDONDKLEOIO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string BLNKAGIFCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x851AF0", VA = "0x1808530F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public JDONDKLEOIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[GPDIKBEHPOJ]
public class CIDIDBPCHNB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JGJJLEIOIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public CIDIDBPCHNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[GPDIKBEHPOJ]
public class MFPODPELMCF
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid HCPJAAJLFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C87B0", VA = "0x1808C9DB0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98E180", Offset = "0x98CB80", VA = "0x18098E180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public MFPODPELMCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[GPDIKBEHPOJ]
public class IMPKPFNNPKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EPLEAFJLJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public IMPKPFNNPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GPDIKBEHPOJ]
public class EDHJIJELCDP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long AHDCNLHKKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public EDHJIJELCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[GPDIKBEHPOJ]
public class PCMCAAOENAB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long NHBBMMIFBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public PCMCAAOENAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[GPDIKBEHPOJ]
public class GIEACPODBFG
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string GINPNCFNIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x851AF0", VA = "0x1808530F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? FPKBNFALHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x100EA70", Offset = "0x100D470", VA = "0x18100EA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public GIEACPODBFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GPDIKBEHPOJ]
public class BIIOBKJOGDC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long NNNBEAJEMJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public BIIOBKJOGDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum KCPEPBLOKGL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[GPDIKBEHPOJ]
public class NIOKPNGJMPA
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KCPEPBLOKGL? LPGDPFPFPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public NIOKPNGJMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[GPDIKBEHPOJ]
public class KEJMJHMJNDD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BMKBFHAKCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public KEJMJHMJNDD()
	{
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
