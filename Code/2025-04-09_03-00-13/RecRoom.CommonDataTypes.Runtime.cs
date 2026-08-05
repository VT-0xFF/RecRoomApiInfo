using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MFAHAFOKKIH
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
public interface EGBLDHIEDOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EJCICOAICPO JFKABKMKEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EJCICOAICPO LECJKLPDFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EFLDLMLMILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AHKMPFJDAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OPNNLJDPBAB LCNCKJDEALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(AKKBKDEMKOF MNNCJJJAHCN, object HHGPJKKLNIG, MFAHAFOKKIH PKKOAIHLPOK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object HHGPJKKLNIG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OAHDFMFCLMB
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
public enum EJCICOAICPO
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
public enum GLGOJODNLKL
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KLGNOGCBJJJ
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
public enum AKKBKDEMKOF
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GIBECJNFFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77F2060", Offset = "0x77F1460", VA = "0x1877F2060")]
	public static EJCICOAICPO GKEAIPLOCDF(this AKKBKDEMKOF KGLDBFDNHBG)
	{
		return default(EJCICOAICPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[GCJPFNEJPBH]
public class CJPCBLMECAN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string JPFEDEDIOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public CJPCBLMECAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GCJPFNEJPBH]
public class JLJFIKOGNEG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long GGHGNFHHKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC67C10", Offset = "0xC67010", VA = "0x180C67C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public JLJFIKOGNEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[GCJPFNEJPBH]
public class NAAEFMPCNEK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EMBFOIFGOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public NAAEFMPCNEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[GCJPFNEJPBH]
public class HFMDIJPGDGH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long BPHHEEPNIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC67C10", Offset = "0xC67010", VA = "0x180C67C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public HFMDIJPGDGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[GCJPFNEJPBH]
public class DBEEHNGDCOP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string DDJEHCIELAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public DBEEHNGDCOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[GCJPFNEJPBH]
public class KPGLFKEKGHA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ENIKFPJBGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public KPGLFKEKGHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[GCJPFNEJPBH]
public class GJKLFBMGHMM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid IHOCAHKEPON
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F10", Offset = "0xBA3310", VA = "0x180BA3F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public GJKLFBMGHMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[GCJPFNEJPBH]
public class FHANNOMMOAN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int LFJOBGOLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public FHANNOMMOAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GCJPFNEJPBH]
public class GINABCDCPPA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long FMKKIGECCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC67C10", Offset = "0xC67010", VA = "0x180C67C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public GINABCDCPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[GCJPFNEJPBH]
public class DGNHFDGLECL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long AEKKIBMMGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC67C10", Offset = "0xC67010", VA = "0x180C67C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public DGNHFDGLECL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[GCJPFNEJPBH]
public class LJJIAHDJHNO
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string NHIKNPDDGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? KBHEAKNBNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xBD34D0", Offset = "0xBD28D0", VA = "0x180BD34D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public LJJIAHDJHNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GCJPFNEJPBH]
public class CDOALMNMLAD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long IJOCJMEJIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC67C10", Offset = "0xC67010", VA = "0x180C67C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public CDOALMNMLAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum MKLIMMHLOAN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[GCJPFNEJPBH]
public class ILACJPADDNI
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MKLIMMHLOAN? JIODACGNDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xC67C10", Offset = "0xC67010", VA = "0x180C67C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public ILACJPADDNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[GCJPFNEJPBH]
public class PDCBNOMGKPK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int EMBFOIFGOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public PDCBNOMGKPK()
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
