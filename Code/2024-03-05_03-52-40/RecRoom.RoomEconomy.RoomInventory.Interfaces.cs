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
public class BCGFEGMKOGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly CJJHGPMCODM OFKKBMLMDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long EDOFPONLMHN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KNJCECDFHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6664DC0", Offset = "0x6663BC0", VA = "0x186664DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6664DD0", Offset = "0x6663BD0", VA = "0x186664DD0")]
	public BCGFEGMKOGJ(CJJHGPMCODM ELGNBNFKLLL, long DPKFLHPPNCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HLGHKHEGFAC
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
public interface FHGLKHOKIOO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	CGNODMPJOCB PMNOFOHLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	AIHFEFKAOFF<CHMEJIJINHI> FDHHMLBCKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AIHFEFKAOFF<Guid> ICBJPNOFAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EKPMNGLHMHM<PDOKOPHMPMB, int> ONKDBOEPLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CGNODMPJOCB GDEKFPILPID
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<BOHHCOEKANF<CHMEJIJINHI, string>> KMJHEMFIMBH(long GMKNHGGIMFN, string OCCHBLONHPL, string LOJNCNHFKNG, string ADIDHJHOAFD, RoomInventoryItemProperties IPHKNHPFNEF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<BOHHCOEKANF<CHMEJIJINHI, string>> PKBDGHOFJBF(Guid NEFPOFJBCHM, [Optional] string OCCHBLONHPL, [Optional] string LOJNCNHFKNG, [Optional] string ADIDHJHOAFD, [Optional] List<long> PIFPKHNOLEH, [Optional] RoomInventoryItemProperties IPHKNHPFNEF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<BOHHCOEKANF<bool, string>> PEFHGEIIJDN(Guid NEFPOFJBCHM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<CHMEJIJINHI> HAMJGIKDJCC();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<CHMEJIJINHI> CGHJCPADELO();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DILEGOFKFEP();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AEHHFFCCDGK(Guid NEFPOFJBCHM, [Out] CHMEJIJINHI HCNCOOIBAKK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LGCHEGIBFML(string IOHNOGHPPLB, [Out] CHMEJIJINHI HCNCOOIBAKK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<PDOKOPHMPMB> GNGKMHIBCDN();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool CNLDHLFGDBN(Guid NEFPOFJBCHM, [Out] PDOKOPHMPMB BIIFKJEFLLC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<int> MJNCBHJCGAE(MFDHGPCGOEK EOHHOGEBGCB, Guid NEFPOFJBCHM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<BCGFEGMKOGJ> JBCNJBFCIMJ(MFDHGPCGOEK EOHHOGEBGCB, Guid NEFPOFJBCHM, int EJIKHJDMNAB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string PMANIMNGICH(CJJHGPMCODM ELGNBNFKLLL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool OGKDMJJDCEG();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ACDPMAMKBAP : FHGLKHOKIOO
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDALKFEIADJ(IEnumerable<CDDFHBAKGMO> ENGKIPPBNHK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PDOKOPHMPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid IMPACOHMGKJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6665BC0", Offset = "0x66649C0", VA = "0x186665BC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KNJCECDFHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6665C30", Offset = "0x6664A30", VA = "0x186665C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long GIMELBFIGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA70", Offset = "0x7BD870", VA = "0x1807BEA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long CHCGKHLJLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F40", Offset = "0x7B7D40", VA = "0x1807B8F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? CBEIFPCNGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A90", Offset = "0x7C5890", VA = "0x1807C6A90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7C6AB0", Offset = "0x7C58B0", VA = "0x1807C6AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OMCAJBGHIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A42A0", Offset = "0x8A30A0", VA = "0x1808A42A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1A64420", Offset = "0x1A63220", VA = "0x181A64420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6665E40", Offset = "0x6664C40", VA = "0x186665E40")]
	public PDOKOPHMPMB(CDDFHBAKGMO MPKDFLBJJAD, bool GKEOAIGEKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B425E0", Offset = "0x1B413E0", VA = "0x181B425E0")]
	public PDOKOPHMPMB(Guid NEFPOFJBCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6665C50", Offset = "0x6664A50", VA = "0x186665C50")]
	internal bool LAGHJNJIPJP(CDDFHBAKGMO MPKDFLBJJAD, long IIDAIGMJJEJ, Action<PDOKOPHMPMB, int> AJANIHNLCCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6665BD0", Offset = "0x66649D0", VA = "0x186665BD0")]
	internal void HHIKNABHFOB(long JIMFGDMLFHH, Action<PDOKOPHMPMB, int> AJANIHNLCCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CHMEJIJINHI : IEquatable<CHMEJIJINHI>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int ENLJOOHFLLJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int OJEHKLKAEEO = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int MIHBJNLMDDB = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int EMNEPDODJDB = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid IMPACOHMGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x825DE0", Offset = "0x824BE0", VA = "0x180825DE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long LKPPEKJMAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEBE830", Offset = "0xEBD630", VA = "0x180EBE830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string PAHJIBDDKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F60", Offset = "0x7B7D60", VA = "0x1807B8F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string ILFKNLMCGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string NIINCCAEDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BE970", Offset = "0x7BD770", VA = "0x1807BE970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime BIFOJLIDADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B40", Offset = "0x7B7940", VA = "0x1807B8B40")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1A3BFB0", Offset = "0x1A3ADB0", VA = "0x181A3BFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime CMMHHLAIMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB70", Offset = "0x7BD970", VA = "0x1807BEB70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1A66460", Offset = "0x1A65260", VA = "0x181A66460")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public HashSet<long> EJKDHOEMHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8D0", Offset = "0x7BA6D0", VA = "0x1807BB8D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB840", Offset = "0x7BA640", VA = "0x1807BB840")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public RoomInventoryItemProperties NBEPILANCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB880", Offset = "0x7BA680", VA = "0x1807BB880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB860", Offset = "0x7BA660", VA = "0x1807BB860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6665540", Offset = "0x6664340", VA = "0x186665540")]
	public CHMEJIJINHI(OOANLAKDJHI MPKDFLBJJAD, [Optional] RoomInventoryItemProperties IPHKNHPFNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6664FF0", Offset = "0x6663DF0", VA = "0x186664FF0", Slot = "4")]
	public bool Equals(CHMEJIJINHI EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6664E10", Offset = "0x6663C10", VA = "0x186664E10", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6665170", Offset = "0x6663F70", VA = "0x186665170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6665250", Offset = "0x6664050", VA = "0x186665250")]
	private HashSet<long> ICGELILPLBM(OOANLAKDJHI MPKDFLBJJAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FNNNCPBPFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private PDOKOPHMPMB BIIFKJEFLLC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CHMEJIJINHI MHBGKABKFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PDOKOPHMPMB FONEGFBBFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6665780", Offset = "0x6664580", VA = "0x186665780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6665810", Offset = "0x6664610", VA = "0x186665810")]
	public FNNNCPBPFDL(CHMEJIJINHI HCNCOOIBAKK, [Optional] PDOKOPHMPMB BIIFKJEFLLC)
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
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6666030", Offset = "0x6664E30", VA = "0x186666030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7B8180", Offset = "0x7B6F80", VA = "0x1807B8180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C6A70", Offset = "0x7C5870", VA = "0x1807C6A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x998A10", Offset = "0x997810", VA = "0x180998A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x998A20", Offset = "0x997820", VA = "0x180998A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public HLGHKHEGFAC Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
			[CompilerGenerated]
			get
			{
				return default(HLGHKHEGFAC);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7C24C0", Offset = "0x7C12C0", VA = "0x1807C24C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6665EF0", Offset = "0x6664CF0", VA = "0x186665EF0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6665F30", Offset = "0x6664D30", VA = "0x186665F30")]
		public static RoomInventoryItemProperties MAIDNGBLMAC(RoomInventoryItemProperties IPHKNHPFNEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB980", Offset = "0x1ACA780", VA = "0x181ACB980")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FILGEJPOPFI
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const int JENBKAMDDFF = 10;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public long GIFEFJJDMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x130E730", Offset = "0x130D530", VA = "0x18130E730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string PAHJIBDDKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F50", Offset = "0x7B7D50", VA = "0x1807B8F50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public RoomInventoryTagClientProperties NBEPILANCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F00", Offset = "0x7B7D00", VA = "0x1807B8F00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MCDFNOJMCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6665680", Offset = "0x6664480", VA = "0x186665680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x66656A0", Offset = "0x66644A0", VA = "0x1866656A0")]
	public FILGEJPOPFI(FFFKNLOMCCL MPKDFLBJJAD, [Optional] RoomInventoryTagClientProperties IPHKNHPFNEF)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6666280", Offset = "0x6665080", VA = "0x186666280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7B8180", Offset = "0x7B6F80", VA = "0x1807B8180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7C6A70", Offset = "0x7C5870", VA = "0x1807C6A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6666080", Offset = "0x6664E80", VA = "0x186666080")]
		public void BLICNNCIAGL(Dictionary<string, object> KJOKICDNNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class NBHDPGHNEOL
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6665B60", Offset = "0x6664960", VA = "0x186665B60")]
	public static int NMLMAJIAOGC(long PBDJDCDANCD)
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
