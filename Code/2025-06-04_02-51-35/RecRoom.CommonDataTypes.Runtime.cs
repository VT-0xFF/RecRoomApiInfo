using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MLLCELNAEOK
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
public interface LEKJEIBMIOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OINIEFHFHHB IBPIOGMOACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OINIEFHFHHB DNIBAGDNKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NEEHOJPBKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNJCLKDBGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KECNPIDOCPH HNEAKPPCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(DBCPDFKKKDC NPFPKFFJHFE, object KAJENDFCCBJ, MLLCELNAEOK IAOOMFIBPGC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object KAJENDFCCBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JFNOPIFJHHB
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
	WidgetWatch
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OINIEFHFHHB
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AJCLEGGLDFO
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EPCINFIDNOL
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DBCPDFKKKDC
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KLPDBGIPLIA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE1E0", Offset = "0x7EBC9E0", VA = "0x187EBE1E0")]
	public static OINIEFHFHHB AHOLMLIEJEC(this DBCPDFKKKDC MFMCIMMKBLC)
	{
		return default(OINIEFHFHHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[JHLCFIPIAOM]
public class FBNPMEOMDOI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string FFBHAMBBIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FBNPMEOMDOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[JHLCFIPIAOM]
public class OJDADHBAFIO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OJDADHBAFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[JHLCFIPIAOM]
public class PEGKHHHKODF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NPAGAHHHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PEGKHHHKODF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[JHLCFIPIAOM]
public class NLLIDCGNDKL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long NDDPEADFJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NLLIDCGNDKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JHLCFIPIAOM]
public class IIFDLIBOJPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string DHMJNNAFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IIFDLIBOJPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[JHLCFIPIAOM]
public class KCFOIPGDEIA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int INPICHNICJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KCFOIPGDEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[JHLCFIPIAOM]
public class AIJDBLGALEE
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public AIJDBLGALEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[JHLCFIPIAOM]
public class FOFNFIHOGLO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OJKNHLCGPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FOFNFIHOGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[JHLCFIPIAOM]
public class HMEEBHDLBGD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long EMPNLHIOGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HMEEBHDLBGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[JHLCFIPIAOM]
public class KPAOOOIHDND
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long AMEENNFCBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KPAOOOIHDND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[JHLCFIPIAOM]
public class MFELMDCBGEI
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FFPMCIPACIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? CPIOFIAPHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MFELMDCBGEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[JHLCFIPIAOM]
public class NHENOJKCODD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long EDBNDBHNINP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NHENOJKCODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum JCBIPMIBGOD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[JHLCFIPIAOM]
public class EBLGFLPJMPD
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JCBIPMIBGOD? AHIEMABNJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public EBLGFLPJMPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[JHLCFIPIAOM]
public class JAPADDPHFHL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NPAGAHHHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public JAPADDPHFHL()
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
