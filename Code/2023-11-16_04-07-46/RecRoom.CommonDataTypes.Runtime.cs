using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IGIMPDEFLNJ
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
public interface KEBJLGEGNOC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LMGOFMCGLJL OANNIICCIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LMGOFMCGLJL HJNHPKNPELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AIKPEEHIEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DKANKEKKKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DNHICBJBOMM BLCCNLMAFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(LGEPFDLCAAF LBINLMKHKHB, object PDIBILKHEBM, IGIMPDEFLNJ ELAMBHMPGHD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object PDIBILKHEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HAGNFIMKEPM
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
	PartyInviteMessage
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LMGOFMCGLJL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NGBEGJJBAGE
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NNMENBBEBPJ
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum LGEPFDLCAAF
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FFBNLDABGGO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F5C0", Offset = "0x5D6E5C0", VA = "0x185D6F5C0")]
	public static LMGOFMCGLJL CNFCGDDMOIA(this LGEPFDLCAAF PMFIIBOFEAB)
	{
		return default(LMGOFMCGLJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[CONDOMLHDLH]
public class NDHOHHFJAAN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string NIJLBOICNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public NDHOHHFJAAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CONDOMLHDLH]
public class DMAAEPFJNCM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long AFIMLDIFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DMAAEPFJNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CONDOMLHDLH]
public class MBAGLMHKHAA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IMJFMGJDAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77AFF0", Offset = "0x779FF0", VA = "0x18077AFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MBAGLMHKHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[CONDOMLHDLH]
public class FOLHBENOOGB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long KFFAJNNIHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public FOLHBENOOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CONDOMLHDLH]
public class FNBJPNFIFAP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string KBNKNJMCBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public FNBJPNFIFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[CONDOMLHDLH]
public class EOIDFMJDGIF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IACBCCIGPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77AFF0", Offset = "0x779FF0", VA = "0x18077AFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public EOIDFMJDGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CONDOMLHDLH]
public class FKILFKNGOEL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid APMFIINJHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1B3D060", Offset = "0x1B3C060", VA = "0x181B3D060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public FKILFKNGOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CONDOMLHDLH]
public class CJGLKCOFJBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EFILDGNHNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77AFF0", Offset = "0x779FF0", VA = "0x18077AFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public CJGLKCOFJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[CONDOMLHDLH]
public class JCCNGCOCEBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long LEGBNOIBPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public JCCNGCOCEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CONDOMLHDLH]
public class DIOFNBJMLKE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long CHGFBJFMADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public DIOFNBJMLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CONDOMLHDLH]
public class MLBFHLHEEKC
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string PHKIAGCNNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? NLNDBAAMMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD8D280", Offset = "0xD8C280", VA = "0x180D8D280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MLBFHLHEEKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CONDOMLHDLH]
public class BCHLHHELDBK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long IKKEAEHGNIL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public BCHLHHELDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum OIPJMBANHMG
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CONDOMLHDLH]
public class KAHNLLKMAGH
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OIPJMBANHMG? HKDLOGOMPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1205280", Offset = "0x1204280", VA = "0x181205280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KAHNLLKMAGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CONDOMLHDLH]
public class GOKKPOPLGIL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int IMJFMGJDAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x77AFF0", Offset = "0x779FF0", VA = "0x18077AFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public GOKKPOPLGIL()
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
