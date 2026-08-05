using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum DALHHKANNHO
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
public interface HPOIABCKGFG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JNLADLMDAPD NFOBFNOLLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	JNLADLMDAPD MICFICINEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HAKJKILEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PPNIFOILIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AOBPFOPEJNG HKJOFNPIIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(DNMJKNGAONH IKILGNIHODP, object NJLOKHEKBBE, DALHHKANNHO LOLKACMOLOC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object NJLOKHEKBBE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PICKJNJGBPK
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
public enum JNLADLMDAPD
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
public enum JCIPLFFADAA
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FGNKNPKDIMC
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
public enum DNMJKNGAONH
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IDMIAONDCBE
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x693BE80", Offset = "0x693A480", VA = "0x18693BE80")]
	public static JNLADLMDAPD PMLDPANBLHF(this DNMJKNGAONH HIHEPGOGOFO)
	{
		return default(JNLADLMDAPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[GEPACHABNHD]
public class JOGAOAEBPEO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string KDKGHLCLOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public JOGAOAEBPEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GEPACHABNHD]
public class PMPEMMIIONI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long KFDFFIPINKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public PMPEMMIIONI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[GEPACHABNHD]
public class NFIPFPFIIOO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DEMEDLGHJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public NFIPFPFIIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[GEPACHABNHD]
public class OFNGIKMDBLG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long JDKKIMPKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public OFNGIKMDBLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[GEPACHABNHD]
public class ACBOOLDJBNL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string CMKJEMHOENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public ACBOOLDJBNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[GEPACHABNHD]
public class KCJKICMPGPG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CEGLBJNJHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public KCJKICMPGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[GEPACHABNHD]
public class FCCCDKAPDDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid HMELGIIAOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA60", Offset = "0x8FA060", VA = "0x1808FBA60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD80", Offset = "0x9CE380", VA = "0x1809CFD80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public FCCCDKAPDDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[GEPACHABNHD]
public class JMFNJKBCPPF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BNFCJKIGPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public JMFNJKBCPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GEPACHABNHD]
public class DJDNCBEIHIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long NDDCACDNKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public DJDNCBEIHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[GEPACHABNHD]
public class EEGOGDNAMJF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long OIEFKBEMMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public EEGOGDNAMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[GEPACHABNHD]
public class LKHONCBEONE
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string NGFHOHDHIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? HJPNGOLJPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x104D6A0", Offset = "0x104BCA0", VA = "0x18104D6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public LKHONCBEONE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GEPACHABNHD]
public class JNCLMDKLBPH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long NIEFPOFJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public JNCLMDKLBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum PHADKLOHJGF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[GEPACHABNHD]
public class MIKKFELLOBI
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PHADKLOHJGF? NLPDDFMBDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1533670", Offset = "0x1531C70", VA = "0x181533670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public MIKKFELLOBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[GEPACHABNHD]
public class EDIHBMMPPNO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int DEMEDLGHJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x871860", Offset = "0x86FE60", VA = "0x180871860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public EDIHBMMPPNO()
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
