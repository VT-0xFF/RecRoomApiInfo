using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ODEIGIMLAIP
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
public interface JFHIBMMIPJK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HLCOIJOICKJ COCCEMMHDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	HLCOIJOICKJ JFMBBGIDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MAFACKMNPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MLBCAKODAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LFHDLKLNBFG BBEKAMALENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(JKNNKPOEKGO ACDLNMFCGPJ, object OECMOOGGOOF, ODEIGIMLAIP PNLPPPCKGCA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object OECMOOGGOOF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MIEFNLJBHBO
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
	PlayTogether
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HLCOIJOICKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DKIECPCCNMA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NIOOALMGPDM
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JKNNKPOEKGO
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LIEJLJCGNNH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6793D90", Offset = "0x6792590", VA = "0x186793D90")]
	public static HLCOIJOICKJ IAHANGHECBF(this JKNNKPOEKGO MCJDOPPFHLD)
	{
		return default(HLCOIJOICKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[EENANNFMPDF]
public class OJDLKOPEFIG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string CHGKCOCHPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OJDLKOPEFIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[EENANNFMPDF]
public class NMHJNOLBFFL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long IJAAFLOGCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14A6C30", Offset = "0x14A5430", VA = "0x1814A6C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NMHJNOLBFFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[EENANNFMPDF]
public class KECEFMCFFGM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LJCNEOABAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84CEA0", Offset = "0x84B6A0", VA = "0x18084CEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KECEFMCFFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[EENANNFMPDF]
public class DFNKLKHLALL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long NKOJKNOPBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x14A6C30", Offset = "0x14A5430", VA = "0x1814A6C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public DFNKLKHLALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[EENANNFMPDF]
public class IFGPKLDEMGD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string GAPMAKOMMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public IFGPKLDEMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[EENANNFMPDF]
public class DAMMPGLBPPD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FGCNECEDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84CEA0", Offset = "0x84B6A0", VA = "0x18084CEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public DAMMPGLBPPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[EENANNFMPDF]
public class AMLPFFFEDJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid MPAEJKCEDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9616D0", Offset = "0x95FED0", VA = "0x1809616D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public AMLPFFFEDJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[EENANNFMPDF]
public class AAFPOPOKPNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JICEPFJPCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84CEA0", Offset = "0x84B6A0", VA = "0x18084CEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public AAFPOPOKPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[EENANNFMPDF]
public class AJOEIFMOHKE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long LHIIIIBFBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x14A6C30", Offset = "0x14A5430", VA = "0x1814A6C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public AJOEIFMOHKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[EENANNFMPDF]
public class FNJBNJBNEGE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long AKALDDOGDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x14A6C30", Offset = "0x14A5430", VA = "0x1814A6C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public FNJBNJBNEGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[EENANNFMPDF]
public class AAGBBHPKCIN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string IDJMIMJDACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? KHENIABKLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xFC8530", Offset = "0xFC6D30", VA = "0x180FC8530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public AAGBBHPKCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[EENANNFMPDF]
public class FCMMIBIJKMN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long KOOGAEAMFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x14A6C30", Offset = "0x14A5430", VA = "0x1814A6C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public FCMMIBIJKMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum MMDFDHNFHFL
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[EENANNFMPDF]
public class LDDOHNKPOMO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MMDFDHNFHFL? IBDGLPEPENO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x14A6C30", Offset = "0x14A5430", VA = "0x1814A6C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public LDDOHNKPOMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[EENANNFMPDF]
public class ACGCGNHGDND
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int LJCNEOABAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84CEA0", Offset = "0x84B6A0", VA = "0x18084CEA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ACGCGNHGDND()
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
