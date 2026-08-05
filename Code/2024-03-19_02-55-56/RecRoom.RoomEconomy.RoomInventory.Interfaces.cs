using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HKJIADDPCDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly JKHKCEBHLFF LJNEPGKFNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long BIBAPHNHGKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IIDHIEGNGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x674DED0", Offset = "0x674CED0", VA = "0x18674DED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x674DEE0", Offset = "0x674CEE0", VA = "0x18674DEE0")]
	public HKJIADDPCDM(JKHKCEBHLFF HEOGODCLBDD, long FBDNKGNOEFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ONJBELKPAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	HiddenWhenNone,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Hidden,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AlwaysVisibleOnceOwned,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AlwaysVisible
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JADFCNEJPLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LHMMLLGDOFK DJJKNGENACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MDKLHFICKPP<PNCDJLHNDOG> ECPFANGPNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MDKLHFICKPP<Guid> CJKPKBPOKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ILKJIPKENIK<KBKHIINCPHG, int> DBMILIECFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MDKLHFICKPP<KGAGIPCPJJO> GJBNEPPBHGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MDKLHFICKPP<long> IEFOOMFAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LHMMLLGDOFK OLBJFGLMMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<PBAOJGOHCMJ<PNCDJLHNDOG, string>> BNIDGKJBKEH(long INFPDCJCIBN, string GCMHJLFFDHO, string LLMKDGFJDOI, string NADGFNKGKAA, RoomInventoryItemProperties GBMDBMGALNG, [Optional] List<long> MJGECNLGPMM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<PBAOJGOHCMJ<PNCDJLHNDOG, string>> CMLHMIBFDMP(Guid BAJDFFFPECM, [Optional] string GCMHJLFFDHO, [Optional] string LLMKDGFJDOI, [Optional] string NADGFNKGKAA, [Optional] List<long> MJGECNLGPMM, [Optional] RoomInventoryItemProperties GBMDBMGALNG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<PBAOJGOHCMJ<bool, string>> HIAONKBGOHA(Guid BAJDFFFPECM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IReadOnlyList<PNCDJLHNDOG> NCGLLKENMMF();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<PNCDJLHNDOG> KKCIAKHFEBH();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool DMNNFNGNNLA();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool MCAOFCGMPHD(Guid BAJDFFFPECM, [Out] PNCDJLHNDOG KHECBCKPCIF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool BOBJJPBGKHC(string MBNNMLMLHAM, [Out] PNCDJLHNDOG KHECBCKPCIF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IReadOnlyList<KBKHIINCPHG> JBIDKNCPMEB();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool JOCDPFCJIEK(Guid BAJDFFFPECM, [Out] KBKHIINCPHG KDIEIMOLICE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<int> LJODNOLIGGC(IDMICLLCMKN JAPHEDILMIF, Guid BAJDFFFPECM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<HKJIADDPCDM> FHNNJGOFMBN(IDMICLLCMKN JAPHEDILMIF, Guid BAJDFFFPECM, int IBMLGBPJGGA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	string MHFGALAJPEH(JKHKCEBHLFF HEOGODCLBDD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LPJCJOAOILJ();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<PBAOJGOHCMJ<KGAGIPCPJJO, string>> JEFKIBHEFHG(long INFPDCJCIBN, string GCMHJLFFDHO, RoomInventoryTagClientProperties GBMDBMGALNG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool HBOGABGBEDI(long OOBJEPAGGNK, [Out] KGAGIPCPJJO MCGOGHEABDG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MJLGFPIFKHF : JADFCNEJPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNJKIIMJFHF(IEnumerable<JHCCBBJIHAI> KKBLKLLIPPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KBKHIINCPHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid MBCKLHOFIOD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x674E170", Offset = "0x674D170", VA = "0x18674E170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IIDHIEGNGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x674E180", Offset = "0x674D180", VA = "0x18674E180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long BCMJNINKNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BC210", Offset = "0x7BB210", VA = "0x1807BC210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long KLONJIHIHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C58D0", Offset = "0x7C48D0", VA = "0x1807C58D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid? ADKDMDKMFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C87E0", Offset = "0x7C77E0", VA = "0x1807C87E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C87B0", Offset = "0x7C77B0", VA = "0x1807C87B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FAHAANAFBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6570", Offset = "0x8C5570", VA = "0x1808C6570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7280", Offset = "0x1AA6280", VA = "0x181AA7280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x674E1A0", Offset = "0x674D1A0", VA = "0x18674E1A0")]
	public KBKHIINCPHG(JHCCBBJIHAI AHLECHLLPGB, bool AEKEPGLFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1B86420", Offset = "0x1B85420", VA = "0x181B86420")]
	public KBKHIINCPHG(Guid BAJDFFFPECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x674DF20", Offset = "0x674CF20", VA = "0x18674DF20")]
	internal bool EKOOOFBJPAE(JHCCBBJIHAI AHLECHLLPGB, long OMMLBDCBFBD, Action<KBKHIINCPHG, int> FONPGCIJJAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x674E110", Offset = "0x674D110", VA = "0x18674E110")]
	internal void GKBGDFMLBON(long OMJPHBLHKIA, Action<KBKHIINCPHG, int> FONPGCIJJAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PNCDJLHNDOG : IEquatable<PNCDJLHNDOG>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int PGPFHLNIMAB = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int JFMCJHFDFFK = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int GAJDHFALBNO = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int DNFKONLKEIG = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int KJKMNEIMBGM = 10;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Guid MBCKLHOFIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x844EC0", Offset = "0x843EC0", VA = "0x180844EC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x844ED0", Offset = "0x843ED0", VA = "0x180844ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long NMPEBFBMKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xEDC620", Offset = "0xEDB620", VA = "0x180EDC620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C0", Offset = "0x7C11C0", VA = "0x1807C21C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string FPJCOOIGBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string IEHIBHAAIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC440", Offset = "0x7BB440", VA = "0x1807BC440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DateTime KCGIPALKHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C2310", VA = "0x1807C3310")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1A7A980", Offset = "0x1A79980", VA = "0x181A7A980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime OIFDGLKHFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA370", Offset = "0x1AA9370", VA = "0x181AAA370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HashSet<long> LKGKFDILJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1250", Offset = "0x7C0250", VA = "0x1807C1250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C1280", Offset = "0x7C0280", VA = "0x1807C1280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public RoomInventoryItemProperties OPABKPNMBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C1270", Offset = "0x7C0270", VA = "0x1807C1270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C1260", Offset = "0x7C0260", VA = "0x1807C1260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x674EE60", Offset = "0x674DE60", VA = "0x18674EE60")]
	public PNCDJLHNDOG(BFGFEGMCJFF AHLECHLLPGB, [Optional] RoomInventoryItemProperties GBMDBMGALNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x674E910", Offset = "0x674D910", VA = "0x18674E910", Slot = "4")]
	public bool Equals(PNCDJLHNDOG PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x674E730", Offset = "0x674D730", VA = "0x18674E730", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x674ED80", Offset = "0x674DD80", VA = "0x18674ED80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x674EA90", Offset = "0x674DA90", VA = "0x18674EA90")]
	private HashSet<long> FPKIKADCLGO(BFGFEGMCJFF AHLECHLLPGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PGNEKOFBJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private KBKHIINCPHG KDIEIMOLICE;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PNCDJLHNDOG LHOLHFCCDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KBKHIINCPHG JLCGKEKBBIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x674E350", Offset = "0x674D350", VA = "0x18674E350")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x674E3E0", Offset = "0x674D3E0", VA = "0x18674E3E0")]
	public PGNEKOFBJHO(PNCDJLHNDOG KHECBCKPCIF, [Optional] KBKHIINCPHG KDIEIMOLICE)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const int MAX_ACTION_BUTTON_TEXT_LENGTH = 12;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x674F220", Offset = "0x674E220", VA = "0x18674F220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9180", VA = "0x1807BA180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C8790", Offset = "0x7C7790", VA = "0x1807C8790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9C44A0", Offset = "0x9C34A0", VA = "0x1809C44A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9C4490", Offset = "0x9C3490", VA = "0x1809C4490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ONJBELKPAMI Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1E0", Offset = "0x7BC1E0", VA = "0x1807BD1E0")]
			[CompilerGenerated]
			get
			{
				return default(ONJBELKPAMI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7BD960", Offset = "0x7BC960", VA = "0x1807BD960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB7E9D0", Offset = "0xB7D9D0", VA = "0x180B7E9D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3F20BD0", Offset = "0x3F1FBD0", VA = "0x183F20BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8FE2D0", Offset = "0x8FD2D0", VA = "0x1808FE2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EF430", VA = "0x1809F0430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x674EFA0", Offset = "0x674DFA0", VA = "0x18674EFA0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x674F020", Offset = "0x674E020", VA = "0x18674F020")]
		public static RoomInventoryItemProperties INLJCENBBKM(RoomInventoryItemProperties GBMDBMGALNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x674F1C0", Offset = "0x674E1C0", VA = "0x18674F1C0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KGAGIPCPJJO
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const int HDADFKBCFPN = 10;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long BFNEPFDLKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1344F50", Offset = "0x1343F50", VA = "0x181344F50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public RoomInventoryTagClientProperties OPABKPNMBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool AGIIGILHIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x674E250", Offset = "0x674D250", VA = "0x18674E250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x674E270", Offset = "0x674D270", VA = "0x18674E270")]
	public KGAGIPCPJJO(LKCMJOBFNPE AHLECHLLPGB, [Optional] RoomInventoryTagClientProperties GBMDBMGALNG)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x674F470", Offset = "0x674E470", VA = "0x18674F470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9180", VA = "0x1807BA180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7C8790", Offset = "0x7C7790", VA = "0x1807C8790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x674F270", Offset = "0x674E270", VA = "0x18674F270")]
		public void KNHKIOAPMAO(Dictionary<string, object> OMGDFOAKJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class DMGCIICINGB
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x674DE70", Offset = "0x674CE70", VA = "0x18674DE70")]
	public static int EDBNIFJFCAC(long FJMKENKLHGI)
	{
		return default(int);
	}
}
namespace Cpp2IlInjected
{
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
}
