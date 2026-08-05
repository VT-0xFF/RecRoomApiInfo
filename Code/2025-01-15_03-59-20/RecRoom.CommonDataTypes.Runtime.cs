using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum KBFNLOCEICJ
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
public interface OJFBINKFANM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IAAAHHDLLON KACOJDHBNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IAAAHHDLLON MCBMNHGNBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AGHALEHHKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MBJIEKCHNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MIPKPFFHABJ LPCMACAIFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(JGKLNAPMNDE PMKINKEGJIP, object CMNJCPJBHGE, KBFNLOCEICJ HPFPPNDKBPG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object CMNJCPJBHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FELAKFKIKEF
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
public enum IAAAHHDLLON
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
public enum KKAPHBALCIM
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EGIFJNGOMEF
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
public enum JGKLNAPMNDE
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NJFIAIEKFNE
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F26CB0", Offset = "0x6F260B0", VA = "0x186F26CB0")]
	public static IAAAHHDLLON JHBNDNKMJNK(this JGKLNAPMNDE BGFBLNEGPHO)
	{
		return default(IAAAHHDLLON);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[JCFBDGBMEPJ]
public class KGJNFIGEAOE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string HCPJBEFDBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KGJNFIGEAOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[JCFBDGBMEPJ]
public class IKHONOAOEBD
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long JHIEDJKCDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x957D40", Offset = "0x957140", VA = "0x180957D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IKHONOAOEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[JCFBDGBMEPJ]
public class LACKNBBBDCL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CHMKHDNDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LACKNBBBDCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[JCFBDGBMEPJ]
public class LEFLLPAJMBK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long NGLFDFLCCAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x957D40", Offset = "0x957140", VA = "0x180957D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LEFLLPAJMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JCFBDGBMEPJ]
public class IBBGOPEIEDP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string CEPJEDBKPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IBBGOPEIEDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[JCFBDGBMEPJ]
public class EIDJIPKCOGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BBOCFHIBIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EIDJIPKCOGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[JCFBDGBMEPJ]
public class GDOFNAEGLMO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid PMMDFDOJGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB5FC10", Offset = "0xB5F010", VA = "0x180B5FC10")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xB5F920", Offset = "0xB5ED20", VA = "0x180B5F920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GDOFNAEGLMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[JCFBDGBMEPJ]
public class AHJGIFFHCJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int ILMBNCFFDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public AHJGIFFHCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[JCFBDGBMEPJ]
public class MIMKNCKHPKL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long KGDPFBIDGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x957D40", Offset = "0x957140", VA = "0x180957D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MIMKNCKHPKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[JCFBDGBMEPJ]
public class HMEENJPKLGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long FCJOEEAMNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x957D40", Offset = "0x957140", VA = "0x180957D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HMEENJPKLGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[JCFBDGBMEPJ]
public class OMNCPJHMLBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string MCIGCACBHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? CCFLLINGEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x13F9DC0", Offset = "0x13F91C0", VA = "0x1813F9DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OMNCPJHMLBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[JCFBDGBMEPJ]
public class HIINHIFPIJK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long IBJNFJAKGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x957D40", Offset = "0x957140", VA = "0x180957D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HIINHIFPIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum AACGEBDLLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[JCFBDGBMEPJ]
public class FBNMDFKBFFE
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public AACGEBDLLKK? CEDJGNOHONM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x957D40", Offset = "0x957140", VA = "0x180957D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FBNMDFKBFFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[JCFBDGBMEPJ]
public class CGKKACNIABF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int CHMKHDNDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public CGKKACNIABF()
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
