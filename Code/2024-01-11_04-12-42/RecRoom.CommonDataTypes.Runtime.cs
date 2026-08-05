using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LPHGKHOPEDO
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
public interface LONGHHOEDJF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KMBAEANLFLE KDLGNKAOFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	KMBAEANLFLE IBFLICBKEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MJBIMPBKNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IHNAOHPDKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BCNLEBGHOIF JJIOMJKBOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(OAFDECBKELO IGLEDEKLOGD, object BDAPLOBBPIE, LPHGKHOPEDO HPLMCDPDBHP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object BDAPLOBBPIE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LFPGKGJALBP
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
	PartyInviteMessage
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KMBAEANLFLE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HOCBGBDDEHH
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KBPIBNPNHIB
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OAFDECBKELO
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OIMBCGEGDHH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DC20", Offset = "0x5F4C620", VA = "0x185F4DC20")]
	public static KMBAEANLFLE FKNAKAOFACH(this OAFDECBKELO GMLCEBAHCFB)
	{
		return default(KMBAEANLFLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[KGPBOCHAIBL]
public class JJEMBCFNCMB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string CKBOPEFDMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JJEMBCFNCMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KGPBOCHAIBL]
public class MAMIFGCLLLK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long IFMPGLDOIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x128D4E0", Offset = "0x128BEE0", VA = "0x18128D4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MAMIFGCLLLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KGPBOCHAIBL]
public class DCCBHGBPNDP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BJHGHJELKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7965B0", Offset = "0x794FB0", VA = "0x1807965B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public DCCBHGBPNDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KGPBOCHAIBL]
public class IAMBONHJEDF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long BGJKAFDAFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x128D4E0", Offset = "0x128BEE0", VA = "0x18128D4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IAMBONHJEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KGPBOCHAIBL]
public class EOHGCCCJCIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string DDCMNGPGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public EOHGCCCJCIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KGPBOCHAIBL]
public class IEECJCKKKJB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OFDCOLBBGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7965B0", Offset = "0x794FB0", VA = "0x1807965B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IEECJCKKKJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KGPBOCHAIBL]
public class IJJBDNLKMCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid LKKGLEIKAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50300", VA = "0x180B51900")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1BCA120", Offset = "0x1BC8B20", VA = "0x181BCA120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IJJBDNLKMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[KGPBOCHAIBL]
public class FJFHCGKONDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MAOPMBJGACB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7965B0", Offset = "0x794FB0", VA = "0x1807965B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FJFHCGKONDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[KGPBOCHAIBL]
public class FAHLCDPEMFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long ANCMNNJLFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x128D4E0", Offset = "0x128BEE0", VA = "0x18128D4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FAHLCDPEMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KGPBOCHAIBL]
public class OBHHHNMIABP
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long LEAGIJABHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x128D4E0", Offset = "0x128BEE0", VA = "0x18128D4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public OBHHHNMIABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KGPBOCHAIBL]
public class HPNGEPDBGHE
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string NGAEKLDEOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? PIMPALNPOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE0B620", Offset = "0xE0A020", VA = "0x180E0B620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public HPNGEPDBGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KGPBOCHAIBL]
public class MFBAOLGJKFB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long HBMNDPEJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x128D4E0", Offset = "0x128BEE0", VA = "0x18128D4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MFBAOLGJKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum CMPFKKIEGCB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[KGPBOCHAIBL]
public class ODBFGOGJJJC
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CMPFKKIEGCB? HJDMEFDOOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x128D4E0", Offset = "0x128BEE0", VA = "0x18128D4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public ODBFGOGJJJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KGPBOCHAIBL]
public class LDJLGEHKNHI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BJHGHJELKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7965B0", Offset = "0x794FB0", VA = "0x1807965B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public LDJLGEHKNHI()
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
