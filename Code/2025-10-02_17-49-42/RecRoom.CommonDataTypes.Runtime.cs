using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AHKBMCCCGKL
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
public interface JNMDHMIIIGL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MBJPIIOBCCH HGFNINLOOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MBJPIIOBCCH FAPAPFFDONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DJGDLIAAGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KALLGIOBOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EBDGCEEEFPM KFLNCLBGNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(OMJAAOIGDKB CANMKEMLCPM, object MFKHKDDANII, AHKBMCCCGKL GMCNPLKBPIA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object MFKHKDDANII);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FJOPDGCALOP
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MBJPIIOBCCH
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
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HKKHJGMNBJD
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LKNHDGPAOON
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
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum OMJAAOIGDKB
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GGAKIEKEEIC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83FE860", Offset = "0x83FD260", VA = "0x1883FE860")]
	public static MBJPIIOBCCH NPGMMJKINHI(this OMJAAOIGDKB GDIJNLEACAN)
	{
		return default(MBJPIIOBCCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NMCNMLEECDM]
public class DLMBHLBADKM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string NCGLFKMEMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DLMBHLBADKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NMCNMLEECDM]
public class IENHLBFKHJG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IENHLBFKHJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NMCNMLEECDM]
public class DICGKEPOHBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DICGKEPOHBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[NMCNMLEECDM]
public class DBLJGHPPCGE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long BCIDBFOBJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DBLJGHPPCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[NMCNMLEECDM]
public class BIOCDHJOEFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string MOAPBELAHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BIOCDHJOEFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[NMCNMLEECDM]
public class NOHIIOCLDDC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DFAIJJHPPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NOHIIOCLDDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[NMCNMLEECDM]
public class MEGBPBFKICJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MEGBPBFKICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[NMCNMLEECDM]
public class ECLDPENKEPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KNIEGDDICKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ECLDPENKEPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[NMCNMLEECDM]
public class APPPFBALOCF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long NELAGJIDIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public APPPFBALOCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[NMCNMLEECDM]
public class GCNCJGFGGON
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long FLKEPANIJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GCNCJGFGGON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NMCNMLEECDM]
public class FLLMPOIADGD
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KIKCDFHIPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? JHMPHLECNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FLLMPOIADGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NMCNMLEECDM]
public class OIECCGJKEKG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long EHMLPLKCLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OIECCGJKEKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum CCEODADJANI
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NMCNMLEECDM]
public class MEDJOICPEIK
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CCEODADJANI? BABHGHANHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MEDJOICPEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[NMCNMLEECDM]
public class LEHBCJLDCCF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LEHBCJLDCCF()
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
