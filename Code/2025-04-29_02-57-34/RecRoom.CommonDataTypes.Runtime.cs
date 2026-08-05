using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AADOFKGEBHB
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
public interface IAPGLPOMFJM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BFKHGOBIMND DJOFKEJOFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BFKHGOBIMND PBABPFODLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AFAIBEHIKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DPMGCJDJFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KFBDEOPEKLE BEPMKDHGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(LOPBABOCEEG NMPLFEAMDPN, object PAHPIGHLKFG, AADOFKGEBHB CBJBMBLMJFG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object PAHPIGHLKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LJAGCEPHFLM
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
public enum BFKHGOBIMND
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
public enum JBKEIOFEABB
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BLJNHLEKLLK
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
public enum LOPBABOCEEG
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IEANKFJBIAK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A590", Offset = "0x7A19990", VA = "0x187A1A590")]
	public static BFKHGOBIMND MJGLJIELKDC(this LOPBABOCEEG FDNGPAPMHIO)
	{
		return default(BFKHGOBIMND);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[MKIDEHJJIOO]
public class CIBINCCDNHN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string GANMJJOEPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public CIBINCCDNHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[MKIDEHJJIOO]
public class CBPPBMNEPAF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long OOPNDDKBIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCD070", VA = "0x180CCDC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public CBPPBMNEPAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[MKIDEHJJIOO]
public class HENLCNACDIC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DLNFHNEMOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HENLCNACDIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[MKIDEHJJIOO]
public class FFAPPBOFLKH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long MCHGCNEPBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCD070", VA = "0x180CCDC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public FFAPPBOFLKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[MKIDEHJJIOO]
public class AKBMHIPFLBA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string KCONGBEEEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public AKBMHIPFLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[MKIDEHJJIOO]
public class AKONMHKFJAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FMFCCNBPFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public AKONMHKFJAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[MKIDEHJJIOO]
public class PGDGGMHFBEO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid NMFHCOEDCMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xEFF440", Offset = "0xEFE840", VA = "0x180EFF440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public PGDGGMHFBEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[MKIDEHJJIOO]
public class JGNLBJNEJGK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EDAKJDMEKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public JGNLBJNEJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[MKIDEHJJIOO]
public class KCEHBCLODMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long ELODKKCLHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCD070", VA = "0x180CCDC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KCEHBCLODMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[MKIDEHJJIOO]
public class DHHKFEBIDDE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long FOPBKFNCMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCD070", VA = "0x180CCDC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public DHHKFEBIDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[MKIDEHJJIOO]
public class CDFHELECPLF
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string ACGJHCCKOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? KACCPPPODDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC35DD0", Offset = "0xC351D0", VA = "0x180C35DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public CDFHELECPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[MKIDEHJJIOO]
public class PFKKHBLCDLL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long OHHGGDOIAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCD070", VA = "0x180CCDC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public PFKKHBLCDLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum PLAADCEDLCE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MKIDEHJJIOO]
public class PCBHKCLOJLO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PLAADCEDLCE? ADMFFLKMOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCD070", VA = "0x180CCDC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public PCBHKCLOJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MKIDEHJJIOO]
public class OOHKGIJAKIG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int DLNFHNEMOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public OOHKGIJAKIG()
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
