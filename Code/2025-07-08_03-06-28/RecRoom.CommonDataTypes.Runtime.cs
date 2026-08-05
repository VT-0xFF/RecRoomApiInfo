using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JHNCELEDFLA
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
public interface EGNMHMDNBAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MMPCEMOONNA LOBNCEBJDBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MMPCEMOONNA KCELLEDBFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FAJOEMALFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NOCGHDGOFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EPBKGABEMJJ PELFIBPCFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(GHIGIDLCAFL DHIAJOJJGCB, object OCGDLEBGIMO, JHNCELEDFLA HNGPPDLEICO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object OCGDLEBGIMO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NLFKICDNAEH
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
public enum MMPCEMOONNA
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
public enum CLPMIHPMBFM
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OODNCPLIONM
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
public enum GHIGIDLCAFL
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GAGIGLJIDGH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FD3790", Offset = "0x7FD2590", VA = "0x187FD3790")]
	public static MMPCEMOONNA PIDABBKCIPE(this GHIGIDLCAFL ICPOMAFNIKG)
	{
		return default(MMPCEMOONNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[KAEFKGKCJBJ]
public class NJBPPBCNOBB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string DHMKIGDMBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public NJBPPBCNOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KAEFKGKCJBJ]
public class LEKFNJLKHAK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long NBAAIIHONBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE319C0", Offset = "0xE307C0", VA = "0x180E319C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LEKFNJLKHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KAEFKGKCJBJ]
public class FNHHLPKMHPK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PCBFONIICIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public FNHHLPKMHPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KAEFKGKCJBJ]
public class CIMJOALAKHO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long PIDHICJDIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE319C0", Offset = "0xE307C0", VA = "0x180E319C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public CIMJOALAKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KAEFKGKCJBJ]
public class AMADMDGABEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string AMIAMMDGGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public AMADMDGABEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[KAEFKGKCJBJ]
public class BCNKBBPLHFO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JICCNLOALLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public BCNKBBPLHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KAEFKGKCJBJ]
public class KKIPHHIMBBH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid BEKGCCGIBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDE0", Offset = "0xE4ABE0", VA = "0x180E4BDE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public KKIPHHIMBBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[KAEFKGKCJBJ]
public class ABLBOPPKIKP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KBJPGDHJICN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public ABLBOPPKIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[KAEFKGKCJBJ]
public class FJOAIOMMEMN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long KOENJDLAMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xE319C0", Offset = "0xE307C0", VA = "0x180E319C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public FJOAIOMMEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KAEFKGKCJBJ]
public class OAKIIJOFDMP
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long AOLJENPEHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE319C0", Offset = "0xE307C0", VA = "0x180E319C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public OAKIIJOFDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KAEFKGKCJBJ]
public class KJNIIJPLNFL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FFFOFBKHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? AKLMIPAGALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD70690", Offset = "0xD6F490", VA = "0x180D70690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public KJNIIJPLNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KAEFKGKCJBJ]
public class POBBHGABKGO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long NFPIPEECHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE319C0", Offset = "0xE307C0", VA = "0x180E319C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public POBBHGABKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum JGIEJAGMFAH
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OBSOLETE_New,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[KAEFKGKCJBJ]
public class HLCHLIMAKIC
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JGIEJAGMFAH? OHHFGHGJJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xE319C0", Offset = "0xE307C0", VA = "0x180E319C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public HLCHLIMAKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KAEFKGKCJBJ]
public class LOMCGAOHOCO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int PCBFONIICIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LOMCGAOHOCO()
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
