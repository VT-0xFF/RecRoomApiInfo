using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FNAKFCDICHD
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
public interface DEDCBEODMLC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OGAHGNGLJDN GKLMFHLHKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OGAHGNGLJDN GCPNIHMPNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CPBDCMMKKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CJIPDBJDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DPAIEAIPOBP GACHEHEOOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(GDNPPOAFEKB PAOOHMLOOFI, object GMMJMENGHCD, FNAKFCDICHD CJCOBDOEDHO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object GMMJMENGHCD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CCJAFCCMPKH
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
public enum OGAHGNGLJDN
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
public enum OMFDNHFJONF
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum MGKGHDLGOFG
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
public enum GDNPPOAFEKB
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JOJCIDJGPEN
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x608D760", Offset = "0x608C960", VA = "0x18608D760")]
	public static OGAHGNGLJDN DCLIFIOGNLK(this GDNPPOAFEKB PAIKDKBMDIL)
	{
		return default(OGAHGNGLJDN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[ODHFCIFLBBE]
public class BKPLOHIEFJB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string LPCBNNIBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BKPLOHIEFJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ODHFCIFLBBE]
public class KEBMAIGILJG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long LBNIJAICHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135CCC0", VA = "0x18135DAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KEBMAIGILJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ODHFCIFLBBE]
public class LGCLIFJJKIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ABMMILJECDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public LGCLIFJJKIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ODHFCIFLBBE]
public class LJOBPJIBOOK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long APDFOMJKCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135CCC0", VA = "0x18135DAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public LJOBPJIBOOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ODHFCIFLBBE]
public class BEFJEOEIBMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string HKEJPMPMBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BEFJEOEIBMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ODHFCIFLBBE]
public class NHDMIKLAADA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IHBIBLIGACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public NHDMIKLAADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[ODHFCIFLBBE]
public class ECCGLBEKGHM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid EMOCBNOOBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x854310", Offset = "0x853510", VA = "0x180854310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ECCGLBEKGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ODHFCIFLBBE]
public class BNHABECMMOG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KDCOCJDNFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BNHABECMMOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[ODHFCIFLBBE]
public class FNPIMFNLABE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long BFKKGNNAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135CCC0", VA = "0x18135DAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public FNPIMFNLABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ODHFCIFLBBE]
public class ADJKBGEOCDF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long KIOKMGJHJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135CCC0", VA = "0x18135DAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ADJKBGEOCDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ODHFCIFLBBE]
public class DDDNLNONDHH
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string EMELKPPHPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? DAFAEICOMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE9A060", Offset = "0xE99260", VA = "0x180E9A060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public DDDNLNONDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ODHFCIFLBBE]
public class AFBOBHOMDII
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long PIGIFOHNHED
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135CCC0", VA = "0x18135DAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public AFBOBHOMDII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum CJJGPGEIKPF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ODHFCIFLBBE]
public class OKCGFGDPMAM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CJJGPGEIKPF? DAKPIBLMEFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x135DAC0", Offset = "0x135CCC0", VA = "0x18135DAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public OKCGFGDPMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ODHFCIFLBBE]
public class AEHEKIAJKKF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int ABMMILJECDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BE610", Offset = "0x7BD810", VA = "0x1807BE610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public AEHEKIAJKKF()
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
