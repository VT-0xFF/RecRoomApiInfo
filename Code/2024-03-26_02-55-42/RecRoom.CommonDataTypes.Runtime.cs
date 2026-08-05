using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum COLGNKGAALJ
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
public interface JAJLBDIKOBO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GDHEEGEHJPM MHDBCPCIGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GDHEEGEHJPM NPBIEBMCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PLEPKCBBIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NKOHNGJHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DGHHAMKHKGM BGLDCJFNFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(JEHHDHNEMOH AOEDEPLOCED, object ICNJFMMNIKL, COLGNKGAALJ FEOEIKFIFFF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object ICNJFMMNIKL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LAJNIPGFMKJ
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
public enum GDHEEGEHJPM
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
public enum LLEIOBIFNAH
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OJLIOOIPFJL
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
public enum JEHHDHNEMOH
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PFPPJFNOPPI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6115A00", Offset = "0x6114E00", VA = "0x186115A00")]
	public static GDHEEGEHJPM CJMJFBHINMG(this JEHHDHNEMOH LFOBHMCPMIG)
	{
		return default(GDHEEGEHJPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DIGLFLHBLBI]
public class NODFMKDFENA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string JIGDGBJDDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public NODFMKDFENA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DIGLFLHBLBI]
public class PJPOIIFPKGG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long LHIMKHILIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x134DF20", Offset = "0x134D320", VA = "0x18134DF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public PJPOIIFPKGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DIGLFLHBLBI]
public class DFOOKFNGLDO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int AOCDLJNLMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public DFOOKFNGLDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DIGLFLHBLBI]
public class CJNPEFECNMP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long DPNCENBJCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x134DF20", Offset = "0x134D320", VA = "0x18134DF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public CJNPEFECNMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DIGLFLHBLBI]
public class JNIDOMAEIII
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string FFPPGGHFGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public JNIDOMAEIII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DIGLFLHBLBI]
public class EHFINMOJOJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FMKJHEMACPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public EHFINMOJOJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DIGLFLHBLBI]
public class LLAPNFAPNMC
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid ECGMEJDLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8516A0", Offset = "0x850AA0", VA = "0x1808516A0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850900", VA = "0x180851500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public LLAPNFAPNMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DIGLFLHBLBI]
public class LNEBKDNIPCH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int JEOMHHMOEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public LNEBKDNIPCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DIGLFLHBLBI]
public class KFIHAOCHIGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long MNFEEGLHMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x134DF20", Offset = "0x134D320", VA = "0x18134DF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public KFIHAOCHIGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DIGLFLHBLBI]
public class IEAOACLCJEM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long DLAJHKCLAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x134DF20", Offset = "0x134D320", VA = "0x18134DF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public IEAOACLCJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DIGLFLHBLBI]
public class BJIAECKIMEA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KOFHHJODOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? HPDLFPIEKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xEA5350", Offset = "0xEA4750", VA = "0x180EA5350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public BJIAECKIMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DIGLFLHBLBI]
public class BLKCHEHPAEM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long IJBPJCEONCG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x134DF20", Offset = "0x134D320", VA = "0x18134DF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public BLKCHEHPAEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum IKBKJBMOFHC
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DIGLFLHBLBI]
public class JIHAHDJDLGO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IKBKJBMOFHC? KIOHEDEPGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x134DF20", Offset = "0x134D320", VA = "0x18134DF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public JIHAHDJDLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DIGLFLHBLBI]
public class PIGMOPHALHM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AOCDLJNLMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public PIGMOPHALHM()
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
