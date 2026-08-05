using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BNKOGMHPING
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
public interface CMDOKCCFENI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EPKOJLICKAL IELOBOHILDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EPKOJLICKAL OLCDFDDFONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EFCELMBEPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GDPBCGDGLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LDNMACGBDLI IHBAEDPNANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(PNEAENMNFCH CFLNMALEOHB, object ABHFNNFMPHA, BNKOGMHPING ALEEOPFLOLJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object ABHFNNFMPHA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BNIEMJFOFIF
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
	OpenProfileRadialMenu,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RemoteCommand
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EPKOJLICKAL
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HPHCIBNKJJE
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KGOIPAMDPNC
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PNEAENMNFCH
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NLPKMLOPHEO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6CFDD30", Offset = "0x6CFD130", VA = "0x186CFDD30")]
	public static EPKOJLICKAL OEDAMHGCBOC(this PNEAENMNFCH GJELEMMNCEG)
	{
		return default(EPKOJLICKAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EDOHJDFIDEJ : short
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Happy = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Love = 1,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Laugh = 2,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	TongueOut = 3,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Wink = 4,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Smirk = 5,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	SmileSweat = 10,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Grimacing = 11,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Shocked = 12,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Thinking = 13,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Sleeping = 14,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Sad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Angry = 21,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Nauseated = 22,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Flat = 23,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Smile = 100
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ONBIEBAAFPD]
public class OECMNEHNAKI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string HDFIGLFKEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public OECMNEHNAKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ONBIEBAAFPD]
public class NOBHJKJPEJO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long LMAPJLOLJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public NOBHJKJPEJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ONBIEBAAFPD]
public class GEOKMNINOMA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PKIDNHKHCDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public GEOKMNINOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ONBIEBAAFPD]
public class BMMDHNCNEFN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long DNNEIFGLEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public BMMDHNCNEFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ONBIEBAAFPD]
public class GFGADDPHNOE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string LOLDPFMCAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public GFGADDPHNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[ONBIEBAAFPD]
public class DPKEBMCPOAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MMLKFKFPMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public DPKEBMCPOAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ONBIEBAAFPD]
public class NMFOGFLJNOF
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid OBECHJDDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA9B260", Offset = "0xA9A660", VA = "0x180A9B260")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B470", Offset = "0xA9A870", VA = "0x180A9B470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public NMFOGFLJNOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[ONBIEBAAFPD]
public class HLEDCOOIIBL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BJIHMLMLOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public HLEDCOOIIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ONBIEBAAFPD]
public class OJEEHFDEJEA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long DHHAINECIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public OJEEHFDEJEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ONBIEBAAFPD]
public class NOGEDCMCCHB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long ADFPMHCIGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public NOGEDCMCCHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ONBIEBAAFPD]
public class OHKPBAEFFDI
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string CGKHJLPLMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? JBDEAPFAICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x13315A0", Offset = "0x13309A0", VA = "0x1813315A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public OHKPBAEFFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[ONBIEBAAFPD]
public class CJLKIDPPACG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long JPDOKJIAKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public CJLKIDPPACG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum GHINHHECJNL
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ONBIEBAAFPD]
public class PJJPBOFOJGI
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GHINHHECJNL? FJAKKIECBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public PJJPBOFOJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ONBIEBAAFPD]
public class DEHPJJDHLNB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int PKIDNHKHCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public DEHPJJDHLNB()
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
