using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NNCEHHEEHBH
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
public interface KNCOOLILKJA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MDPOHPKKJGL GLHHAAJCFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MDPOHPKKJGL FFBFLGLFLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DFNCNMDMGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NNHKFIPMEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LJECGABKDKN AGGKMBNJCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(EAMMKDENKFB MCKFADJOAHH, object JECMOKMEJED, NNCEHHEEHBH LPKKLMEOBCL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object JECMOKMEJED);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JGACDDNNDPJ
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
public enum MDPOHPKKJGL
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
public enum CHCIGPNKAHC
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GFJKJJFHBLO
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
public enum EAMMKDENKFB
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DDILAMOBIKP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BF80", Offset = "0x5D8A780", VA = "0x185D8BF80")]
	public static MDPOHPKKJGL EIIONJIJGNM(this EAMMKDENKFB JECPNLKEDGA)
	{
		return default(MDPOHPKKJGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[GAPBJHAGMOB]
public class AHBJJGEPPFL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string NLPJMOCINPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public AHBJJGEPPFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GAPBJHAGMOB]
public class ADPJADDGNDO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long BIGMFDGONPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ADPJADDGNDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[GAPBJHAGMOB]
public class GIAGNEJCDAO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HLNPFHBINHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77C550", Offset = "0x77AD50", VA = "0x18077C550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public GIAGNEJCDAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[GAPBJHAGMOB]
public class IPEBGPDKALG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long KHIOAAHLGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public IPEBGPDKALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[GAPBJHAGMOB]
public class JFOEABELPCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string DPCOCHEHCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JFOEABELPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[GAPBJHAGMOB]
public class OMBDAKKBNII
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ADBHPCNJCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77C550", Offset = "0x77AD50", VA = "0x18077C550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public OMBDAKKBNII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[GAPBJHAGMOB]
public class CHGCDMABMPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid JEICIBDKNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1B7B790", Offset = "0x1B79F90", VA = "0x181B7B790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public CHGCDMABMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[GAPBJHAGMOB]
public class CDNOIDDCOOF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FIMEJMOBKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77C550", Offset = "0x77AD50", VA = "0x18077C550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public CDNOIDDCOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GAPBJHAGMOB]
public class HMFOAJFBKIE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long PKBGGCOJMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public HMFOAJFBKIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[GAPBJHAGMOB]
public class MPAPBIAGNKG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long BCGODNEICJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public MPAPBIAGNKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[GAPBJHAGMOB]
public class OJOFLICLAKK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string LAGKKBLFHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? MGCHBCHFPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDCA240", Offset = "0xDC8A40", VA = "0x180DCA240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public OJOFLICLAKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GAPBJHAGMOB]
public class GLIIOADKKMA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long FIJGDBIJGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public GLIIOADKKMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum CBAMFGJNDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[GAPBJHAGMOB]
public class PPJFGJCEHJL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CBAMFGJNDLI? POEBCDJHPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1247100", Offset = "0x1245900", VA = "0x181247100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public PPJFGJCEHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[GAPBJHAGMOB]
public class DEMPFFOIOIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HLNPFHBINHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x77C550", Offset = "0x77AD50", VA = "0x18077C550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public DEMPFFOIOIJ()
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
