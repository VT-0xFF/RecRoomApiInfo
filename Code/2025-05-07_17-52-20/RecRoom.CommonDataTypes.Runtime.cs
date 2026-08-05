using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GANCIHBBPMJ
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
public interface IHIKFHAFOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EPILIOJENIA LJKOLGHFGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EPILIOJENIA DHHOFMFEPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CPCEPDAHMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LKIFCKNDCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GCADBNOOJOM JDPOGPDHOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(HMOOKBBLEEH DLDOAMNHDEG, object EJJDDFFADPC, GANCIHBBPMJ DPEJEDCKJBD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object EJJDDFFADPC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BMGLPAIAFKI
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
public enum EPILIOJENIA
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
public enum LHJGCPMNJCC
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FBFPIHENAFH
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
public enum HMOOKBBLEEH
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PENLNCNMNKK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B7FC90", Offset = "0x7B7EC90", VA = "0x187B7FC90")]
	public static EPILIOJENIA DJOLELPKODF(this HMOOKBBLEEH MECLDBHCDJI)
	{
		return default(EPILIOJENIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[KGJMAOFDNAE]
public class CJFEMPKADDM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string EEPNEFAFLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public CJFEMPKADDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KGJMAOFDNAE]
public class ICKNFHIGHCN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public ICKNFHIGHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KGJMAOFDNAE]
public class OLKFGMJLLHK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OLKFGMJLLHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KGJMAOFDNAE]
public class CCFLHNIDLLN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long OOAAJPONLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public CCFLHNIDLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KGJMAOFDNAE]
public class FNFHDDMDNEA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string NHNLBOFCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FNFHDDMDNEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KGJMAOFDNAE]
public class KFODAMHAKEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IEECKJOAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KFODAMHAKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KGJMAOFDNAE]
public class APLHJJJNNEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public APLHJJJNNEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[KGJMAOFDNAE]
public class DDOCAEFGKDA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int PNPOJLABGON
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DDOCAEFGKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[KGJMAOFDNAE]
public class FJLAPBKCMIE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long FOOJEFMOBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FJLAPBKCMIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KGJMAOFDNAE]
public class IEGLFEFCIGA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long MFGIGBBNBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public IEGLFEFCIGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KGJMAOFDNAE]
public class HMHLEJGHEDA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string LMPFHKHMEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? DJFGEDHPJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HMHLEJGHEDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KGJMAOFDNAE]
public class HMJNMHGEMLM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long DFGOKPKCGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HMJNMHGEMLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum CEGKHGBADJG
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[KGJMAOFDNAE]
public class LAMBHLKMKCK
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CEGKHGBADJG? BNOBFCCPPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LAMBHLKMKCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KGJMAOFDNAE]
public class LLNLFMFLPAD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LLNLFMFLPAD()
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
