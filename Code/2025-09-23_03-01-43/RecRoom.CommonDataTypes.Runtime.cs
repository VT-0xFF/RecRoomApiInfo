using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ADOBPJFKGJA
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
public interface HEAELCMEANA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CPNGJDOHMPE GFNDFENGLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	CPNGJDOHMPE JCIMJDBOELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CFNGHGKOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CDNAEGKNCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HLLOFHFLNHG KBOGFKBMODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(IAFOFGCELBG EBHNDMEAKBB, object INEEADCBMPK, ADOBPJFKGJA EOENKBEJCMN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object INEEADCBMPK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JGJFCAADGMB
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
public enum CPNGJDOHMPE
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
public enum KMPLGPDHOOM
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KNDOABLKIHG
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
public enum IAFOFGCELBG
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AJFLDHFBHCF
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8408580", Offset = "0x8406B80", VA = "0x188408580")]
	public static CPNGJDOHMPE MMFDNLMPGNK(this IAFOFGCELBG IBLGEJEKAPD)
	{
		return default(CPNGJDOHMPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[KFIGMDMNOJM]
public class LHGMNNFDIDI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string FDGBEADHJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LHGMNNFDIDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KFIGMDMNOJM]
public class MKEMBEAEPIH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long DLJLNOEPAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEB19B0", Offset = "0xEAFFB0", VA = "0x180EB19B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public MKEMBEAEPIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KFIGMDMNOJM]
public class BGLGPGLNMLL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EGEHJHGMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public BGLGPGLNMLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KFIGMDMNOJM]
public class FIONMINHBJA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long OMCFDILDDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEB19B0", Offset = "0xEAFFB0", VA = "0x180EB19B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public FIONMINHBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KFIGMDMNOJM]
public class GCBFMLFCBKG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string KIBOIAPOBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public GCBFMLFCBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KFIGMDMNOJM]
public class DCJGJGGAKPC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ADEKKDPOGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DCJGJGGAKPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KFIGMDMNOJM]
public class EJNJDBADICB
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid BFLHNIJGHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xECC1C0", Offset = "0xECA7C0", VA = "0x180ECC1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public EJNJDBADICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[KFIGMDMNOJM]
public class ONNFGPOFPHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int GLKEDDHKOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public ONNFGPOFPHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[KFIGMDMNOJM]
public class JEKDKHKDCOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long MPPHGEBJGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xEB19B0", Offset = "0xEAFFB0", VA = "0x180EB19B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JEKDKHKDCOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KFIGMDMNOJM]
public class EGFMLIHHGBF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long NLGPOKHPPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xEB19B0", Offset = "0xEAFFB0", VA = "0x180EB19B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public EGFMLIHHGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KFIGMDMNOJM]
public class EOFBCHGKEEM
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KMGBCMKCLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? JIKAHNLELMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE15260", Offset = "0xE13860", VA = "0x180E15260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public EOFBCHGKEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KFIGMDMNOJM]
public class HPFHCMDPJFL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long HPADFIAOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEB19B0", Offset = "0xEAFFB0", VA = "0x180EB19B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public HPFHCMDPJFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum IPJNCLIBKFO
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[KFIGMDMNOJM]
public class NELBDOPJIID
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IPJNCLIBKFO? ACHIJAILLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xEB19B0", Offset = "0xEAFFB0", VA = "0x180EB19B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public NELBDOPJIID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KFIGMDMNOJM]
public class KCPAGEJMPOM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int EGEHJHGMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public KCPAGEJMPOM()
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
