using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MBIKJPPIHKG
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
public interface GAPBDNHMPFG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JIBEGIKCJLB LJCADFLGAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	JIBEGIKCJLB PKILOJOADPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AOKNCFHAGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BIHPODJCJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BDDIJCFMLKF BIKOPKHEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(FOGODCILGBN FEOCBGIHCDL, object CFGHNHCDKCN, MBIKJPPIHKG IABPFIADDDK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object CFGHNHCDKCN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum GALNDMNAHDD
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
public enum JIBEGIKCJLB
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
public enum AFPGILBAGPB
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BIBDLICGHIK
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
public enum FOGODCILGBN
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LLNHKCJCDJA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C77240", Offset = "0x6C76640", VA = "0x186C77240")]
	public static JIBEGIKCJLB OGHDFMLHBLO(this FOGODCILGBN CFINOJHBLLF)
	{
		return default(JIBEGIKCJLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NLICMHACDLN : short
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
[OHJCDGFPGHK]
public class JJKMPCCCMMI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string MLHHHBEDBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public JJKMPCCCMMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[OHJCDGFPGHK]
public class JNGAFJJEBEN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long KANBOFIDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public JNGAFJJEBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[OHJCDGFPGHK]
public class OOANEGCANIK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JDAAOJECPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public OOANEGCANIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[OHJCDGFPGHK]
public class JALGMNCJLOB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long KPBMAMGDDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public JALGMNCJLOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[OHJCDGFPGHK]
public class DEEFMHDILGL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string KONNOFEJAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DEEFMHDILGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[OHJCDGFPGHK]
public class HKBDMOFGNNL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FMFIDEKFCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public HKBDMOFGNNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[OHJCDGFPGHK]
public class MIIOKCNIPIL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid GEDOHMBPDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAE8120", Offset = "0xAE7520", VA = "0x180AE8120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public MIIOKCNIPIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[OHJCDGFPGHK]
public class AHONLEAHOOH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CINCJCBNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public AHONLEAHOOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OHJCDGFPGHK]
public class LLBENAFOGDK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long HBPEFBIPMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public LLBENAFOGDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[OHJCDGFPGHK]
public class IINGIGKHPBA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long JNIMFOAFBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public IINGIGKHPBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[OHJCDGFPGHK]
public class OPOACCINKCG
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string ACEHNFDNFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? CELLFMGMIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x13800E0", Offset = "0x137F4E0", VA = "0x1813800E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public OPOACCINKCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[OHJCDGFPGHK]
public class PADPKDHAEOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long NGOFINMEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public PADPKDHAEOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FNNDALINNLI
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OHJCDGFPGHK]
public class BEHPNBOGGHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FNNDALINNLI? CELJMJABDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public BEHPNBOGGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[OHJCDGFPGHK]
public class OMCDPFLONEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int JDAAOJECPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public OMCDPFLONEJ()
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
