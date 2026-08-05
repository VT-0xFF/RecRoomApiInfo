using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LKCCDHFCHBA
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
public interface CLCJAKCDCHO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FAHOOLAMKPI CCDFOCLKBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FAHOOLAMKPI IILIKOGLOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MJKJHOGHGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JFMBJDMOECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HBPNKKOKOOA NBNGJKLGDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(FAIBCMLAJHJ NMFGOKGPEGC, object HNGIMMGBLII, LKCCDHFCHBA DLELGMMBCCC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object HNGIMMGBLII);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KCHDEPJHLPG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string JGMCJOIEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KILEAINGIIP
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
	AutoMerged,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	WidgetWatch,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	PlayerCard
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FAHOOLAMKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LPNLIPGNEGB
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MOKHJFCDJAP
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FAIBCMLAJHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GHFAPFHDKCD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x836E460", Offset = "0x836CA60", VA = "0x18836E460")]
	public static FAHOOLAMKPI PLIIBNLPLCA(this FAIBCMLAJHJ JDJJDFOGKAI)
	{
		return default(FAHOOLAMKPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GIJKPPBGMNE]
public class EPKLLPNAJID
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string CAOANIEEMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public EPKLLPNAJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[GIJKPPBGMNE]
public class CGAGKBHKODP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CGAGKBHKODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[GIJKPPBGMNE]
public class HJFKLFAAJCM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NGMDLLPJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HJFKLFAAJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[GIJKPPBGMNE]
public class CODIDMGINED
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long JNIMEMKAGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CODIDMGINED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[GIJKPPBGMNE]
public class OGAKPGPNCMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string APKICFOEGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OGAKPGPNCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[GIJKPPBGMNE]
public class KKOLJJICGNO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IEIFDCKJKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KKOLJJICGNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[GIJKPPBGMNE]
public class JKOPIFKJLKO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid HDOBIKLCIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xEADD60", Offset = "0xEAC360", VA = "0x180EADD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JKOPIFKJLKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GIJKPPBGMNE]
public class OHLGLLMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JACICBPEGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OHLGLLMBKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[GIJKPPBGMNE]
public class HABKOANLBCE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long BBCKGGOFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public HABKOANLBCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[GIJKPPBGMNE]
public class FLMEINMCNPA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long JPEICEICIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FLMEINMCNPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GIJKPPBGMNE]
public class DKJNOMBIEEN
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string FDEFAAMHLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int? GDLHJIJPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public DKJNOMBIEEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[GIJKPPBGMNE]
public class BCGGNELFKNA
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public long PLALMOMPJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BCGGNELFKNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MLFNPGFGGFH
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[GIJKPPBGMNE]
public class MLLJNMDEHEM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MLFNPGFGGFH? HCIFMMCKJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xE993A0", Offset = "0xE979A0", VA = "0x180E993A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MLLJNMDEHEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[GIJKPPBGMNE]
public class LCHPDNEPIGO
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NGMDLLPJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LCHPDNEPIGO()
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
