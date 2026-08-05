using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GAHNJEIJAEO
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
public interface LBODAALNGJG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MBJGJIOKGOO AHGFCBBINFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MBJGJIOKGOO KIDPOCEBKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MODBOLIPJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CKAKFCCCHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IDDBOOGKPOH BCEGMIEJIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(ACDIDPDHJFF DOBPEBPMDGH, object IAIFDAAIBBN, GAHNJEIJAEO OMFADEMDLDL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object IAIFDAAIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CFAMAABIGEH
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
public enum MBJGJIOKGOO
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
public enum GBNMJCDNDFN
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EKLCFIBNCNF
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
public enum ACDIDPDHJFF
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PAJDEFLMLGI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x682D520", Offset = "0x682C920", VA = "0x18682D520")]
	public static MBJGJIOKGOO ABPDMHIFDED(this ACDIDPDHJFF KBNNEODEGCO)
	{
		return default(MBJGJIOKGOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[PKPOFAOAALP]
public class KGFPCIOBLFI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string CNFPEODDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public KGFPCIOBLFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PKPOFAOAALP]
public class CJCFMMIBPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long CJNCPNGBHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x15E2EA0", Offset = "0x15E22A0", VA = "0x1815E2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public CJCFMMIBPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PKPOFAOAALP]
public class KABIKNOEBAI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EFPFNCGDCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public KABIKNOEBAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[PKPOFAOAALP]
public class OLMKEMJMCLB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long PLPGJMIJPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x15E2EA0", Offset = "0x15E22A0", VA = "0x1815E2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public OLMKEMJMCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PKPOFAOAALP]
public class GPBGHEPAEAI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string JLJACPJFAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public GPBGHEPAEAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[PKPOFAOAALP]
public class IEMFOKKIPOC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OMLIMBNBMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public IEMFOKKIPOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[PKPOFAOAALP]
public class HJBOPKMCJJK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid GAKNFNKCCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B50", Offset = "0x99FF50", VA = "0x1809A0B50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA94D30", Offset = "0xA94130", VA = "0x180A94D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public HJBOPKMCJJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[PKPOFAOAALP]
public class GHPGDEPPOLD
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int GBNOONMAEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public GHPGDEPPOLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[PKPOFAOAALP]
public class EGPFMKCOCHD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long DFNNJNJDGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x15E2EA0", Offset = "0x15E22A0", VA = "0x1815E2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public EGPFMKCOCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[PKPOFAOAALP]
public class GDMOLJFIDFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long MJAKDNPPMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x15E2EA0", Offset = "0x15E22A0", VA = "0x1815E2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public GDMOLJFIDFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[PKPOFAOAALP]
public class JNMDIHDCGGL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string CFNEDDPNMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? IDPBJEKBDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1114940", Offset = "0x1113D40", VA = "0x181114940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public JNMDIHDCGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PKPOFAOAALP]
public class HKILPPAHDNG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long CGBPIIPMBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x15E2EA0", Offset = "0x15E22A0", VA = "0x1815E2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public HKILPPAHDNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum ICOIMJOGNAD
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[PKPOFAOAALP]
public class CEPBCNDKOOC
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ICOIMJOGNAD? ILDJLFKPKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x15E2EA0", Offset = "0x15E22A0", VA = "0x1815E2EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public CEPBCNDKOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[PKPOFAOAALP]
public class FKLIGIAOJJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int EFPFNCGDCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public FKLIGIAOJJJ()
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
