using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AFAGJKANGJF
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
public interface MNKIDBOAIEG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HLELPBIHDLD HNPMEHCGMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	HLELPBIHDLD EOMMAPOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ODHPGDDBLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EMFCNKPKNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JGNOJICCDHE CKOKIEPKHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(ANKNEHCBHBM FEJJOGFOPCE, object PPOILDCNBFL, AFAGJKANGJF NNIDLNKAMEF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object PPOILDCNBFL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JMEFDOGEJON
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
	OpenProfileRadialMenu,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	RemoteCommand,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	BeaconAccepted,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	BeaconOffered,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	AutoMerged
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HLELPBIHDLD
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KGOGJLHOPCJ
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NFNEOKGKAIC
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ANKNEHCBHBM
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GPGIDONCBLL
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BB65A0", Offset = "0x7BB57A0", VA = "0x187BB65A0")]
	public static HLELPBIHDLD OHJJFJEAOMH(this ANKNEHCBHBM BGIKBFMPDCC)
	{
		return default(HLELPBIHDLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DBAGFLHDBHH]
public class OPPMIIMKPGC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string LCHEKIMNPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OPPMIIMKPGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DBAGFLHDBHH]
public class HFGBJKDPPFD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long IDAIGHAHCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HFGBJKDPPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DBAGFLHDBHH]
public class FMJINKLJDLM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OGDCDIANMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FMJINKLJDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DBAGFLHDBHH]
public class BFPOOIOAFGM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long LJNIMPGGIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BFPOOIOAFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DBAGFLHDBHH]
public class LAHBFJIEOME
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string MIENOHKFICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LAHBFJIEOME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DBAGFLHDBHH]
public class DPLEHCGNDIH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ADEHAIPNBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DPLEHCGNDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DBAGFLHDBHH]
public class CBAICCILDFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CBAICCILDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DBAGFLHDBHH]
public class EKCCMOMJNNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int ALGCEHGIGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public EKCCMOMJNNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DBAGFLHDBHH]
public class CBPEJHJEPIB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long LEJEJGEINFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CBPEJHJEPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DBAGFLHDBHH]
public class LLJBIDKLDPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long KKHDEOGDELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LLJBIDKLDPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DBAGFLHDBHH]
public class KMGAPFBJFGM
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string BHGDNJKCIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? IAFGDCJDKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KMGAPFBJFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DBAGFLHDBHH]
public class GOLPFIOGDCE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long OCBFODBGHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GOLPFIOGDCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum AEFNMGIMINO
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DBAGFLHDBHH]
public class CKOJBCIHMOM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AEFNMGIMINO? GFHGFAFMMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CKOJBCIHMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DBAGFLHDBHH]
public class MMIIDFKCDME
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int OGDCDIANMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MMIIDFKCDME()
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
