using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CIPFCLPJMOJ
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
public interface IPGOOOLACMB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IGBHOLHLEMO BIHDLNLMMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IGBHOLHLEMO MHLAPHIGILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PCDGDLCDKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CMGNENOMAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	COOFKGJALFM JBPAJPHCELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(PJMBJLGBJOG BPCEKDEOKLP, object GNAAILLDOKI, CIPFCLPJMOJ KLEICHAFCLM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object GNAAILLDOKI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CEGMLPEHGPF
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
public enum IGBHOLHLEMO
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
public enum AGCPAOLGFAF
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JBEJAIADLAN
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
public enum PJMBJLGBJOG
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GHOKCLJOPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7829010", Offset = "0x7827A10", VA = "0x187829010")]
	public static IGBHOLHLEMO AJELIEKEIBJ(this PJMBJLGBJOG NDELDEDNMOL)
	{
		return default(IGBHOLHLEMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[CGLNJJKAJNP]
public class LHCAGJHAGKH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string FOOPFBOMFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LHCAGJHAGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CGLNJJKAJNP]
public class CHECIODDOJE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long FJEOJHLFBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC8BC00", Offset = "0xC8A600", VA = "0x180C8BC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public CHECIODDOJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CGLNJJKAJNP]
public class HLECADDEEOG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NLHGLNCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public HLECADDEEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[CGLNJJKAJNP]
public class KOAAEHJCPPB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long JNGHKHHHIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC8BC00", Offset = "0xC8A600", VA = "0x180C8BC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public KOAAEHJCPPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CGLNJJKAJNP]
public class FIANHMFIKFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string ECGFAOBOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public FIANHMFIKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[CGLNJJKAJNP]
public class ACOOFIBMJGL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HFJJPJODCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public ACOOFIBMJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CGLNJJKAJNP]
public class MLMIFLHGOKE
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid AIGDOOGMEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xEC09F0", Offset = "0xEBF3F0", VA = "0x180EC09F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xEC0AB0", Offset = "0xEBF4B0", VA = "0x180EC0AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public MLMIFLHGOKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CGLNJJKAJNP]
public class FFKNFDIPCOP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int GFINMKBJKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public FFKNFDIPCOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[CGLNJJKAJNP]
public class PBOKJJKEOAL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long MCHEIACMIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC8BC00", Offset = "0xC8A600", VA = "0x180C8BC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public PBOKJJKEOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CGLNJJKAJNP]
public class EIOGGIKDHLI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long OEPOAPNMLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC8BC00", Offset = "0xC8A600", VA = "0x180C8BC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public EIOGGIKDHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CGLNJJKAJNP]
public class DMEGMPEFBFL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string PCCGHFLDBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? PAOFHGBDBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC01020", Offset = "0xBFFA20", VA = "0x180C01020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public DMEGMPEFBFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CGLNJJKAJNP]
public class IAPKPIGPHNP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long FLFAMNMFNDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC8BC00", Offset = "0xC8A600", VA = "0x180C8BC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public IAPKPIGPHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum COLAAAFBPCP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CGLNJJKAJNP]
public class OKIFCLHELDM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public COLAAAFBPCP? ACBKIFMIEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xC8BC00", Offset = "0xC8A600", VA = "0x180C8BC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public OKIFCLHELDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CGLNJJKAJNP]
public class JMDBJCJHOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NLHGLNCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public JMDBJCJHOAE()
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
