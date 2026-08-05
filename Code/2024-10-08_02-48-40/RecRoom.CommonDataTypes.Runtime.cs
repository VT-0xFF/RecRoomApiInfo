using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EKNDMPGELDJ
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
public interface FCHDAKOIGHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PEODBIJNKLA GDBMFPFPAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	PEODBIJNKLA AJCKJJCDGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NCHGIEEFDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OCBILBHHEOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OAACCCGABIO NGEKNOMKHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(PAHLFCDFHBP PMPJMCMGACN, object NIOIDOPDJKO, EKNDMPGELDJ PFDDBFPHACL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object NIOIDOPDJKO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HFGIFFNMLJL
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
public enum PEODBIJNKLA
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
public enum HLOGPECCNJD
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CDAAFAHKGPL
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
public enum PAHLFCDFHBP
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DHPOOFLMJFO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B91D40", Offset = "0x6B90F40", VA = "0x186B91D40")]
	public static PEODBIJNKLA NADDHELBKGK(this PAHLFCDFHBP MEOGGEENDMF)
	{
		return default(PEODBIJNKLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GCHEHPBJEEK : short
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
[MDNEFDDEAEO]
public class OODBDPGMFEH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string DLMAOONANLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public OODBDPGMFEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[MDNEFDDEAEO]
public class JCKEIBALHDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long KAHMLHFALKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x94C410", Offset = "0x94B610", VA = "0x18094C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public JCKEIBALHDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[MDNEFDDEAEO]
public class ELJHKCPAPKA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BGPOEMNEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public ELJHKCPAPKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[MDNEFDDEAEO]
public class HMAKGOLFHLE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long DDFMGENLHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x94C410", Offset = "0x94B610", VA = "0x18094C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public HMAKGOLFHLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[MDNEFDDEAEO]
public class DDGBHKIAEEL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string LAMIKLOCNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public DDGBHKIAEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[MDNEFDDEAEO]
public class EKFLLIGBALC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PDCJEIDFKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public EKFLLIGBALC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[MDNEFDDEAEO]
public class LAIIBDPCDDL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid ALIKILDEAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA7FAC0", Offset = "0xA7ECC0", VA = "0x180A7FAC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA7FDF0", Offset = "0xA7EFF0", VA = "0x180A7FDF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public LAIIBDPCDDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[MDNEFDDEAEO]
public class MLLGJMNPAJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OLCLOANAEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public MLLGJMNPAJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[MDNEFDDEAEO]
public class IMKLLEEEIBF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long FGKPNMHHCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x94C410", Offset = "0x94B610", VA = "0x18094C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public IMKLLEEEIBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[MDNEFDDEAEO]
public class BGKMKLJDMHH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long LPOBCAPOIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x94C410", Offset = "0x94B610", VA = "0x18094C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public BGKMKLJDMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[MDNEFDDEAEO]
public class PEMILIGJKHP
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KIHOOLJJMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? IIKKHPAPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1313520", Offset = "0x1312720", VA = "0x181313520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public PEMILIGJKHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[MDNEFDDEAEO]
public class DJLGHNHHFGM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long ILEPPIILLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x94C410", Offset = "0x94B610", VA = "0x18094C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public DJLGHNHHFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum JDMNIAGBDHD
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MDNEFDDEAEO]
public class GJMEKBMDBCM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JDMNIAGBDHD? BMGOOHHNOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x94C410", Offset = "0x94B610", VA = "0x18094C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public GJMEKBMDBCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[MDNEFDDEAEO]
public class LNGDEBHHLKD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BGPOEMNEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public LNGDEBHHLKD()
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
