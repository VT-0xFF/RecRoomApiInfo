using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using RecRoom.PlatformNotifications;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EPGLNFHALNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int JAPINFBOCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType JFINBJKLHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public COKACHOCJDL NHNBGMIPAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool LGAJLCIEMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string MNMKEOJLNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string ELEGEBFIDFG;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LJHCCABAIOC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ANLLKONFFGB? MJKKJKIJDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, global::NBFPPJGKGOH<bool>> BICEBMHOADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ANLLKONFFGB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PDOJOFBPAKG(bool GGKLFMPBGIO, string LJGKGILKHCG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void BHKHNGMGCHD(bool GGKLFMPBGIO, string LJGKGILKHCG, ANLLKONFFGB IGKFEJHNOOO, string FLDJLPKNKKO);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LDKIEBHAMFE();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PCAPOFHEEEM(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void CEJALBNDOMO(EPGLNFHALNM NNKMAJMJMPB);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void PJGNFFEAINK(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void AFDMDMCFEBK(string LHGHMOCEKND, string PHLIFPPEJGL, string AAOLPJCANPC, string LBEOLPPPADF);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void KPEONADKINL(string LHGHMOCEKND, string PHLIFPPEJGL);
namespace RecRoom.PlatformNotifications
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum PlatformNotificationHandlerContext
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		AppRunning,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		AppForegrounded,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		AppLaunched,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		DismissedAtLaunch
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JIAMBIICBFF]
internal class FNOPAEHNMOD : PDOFHJEKKFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ONDLDAMFIKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FNOPAEHNMOD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ONDLDAMFIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
		internal void FPMEDKAKMBG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1628AA0", Offset = "0x16272A0", VA = "0x181628AA0")]
		internal void BOGHEFLNBOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DAOHEFMEIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public FNOPAEHNMOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int identifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public string notificationKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public string category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public string title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public string body;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public DateTime scheduledDateUTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<COKACHOCJDL> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DAOHEFMEIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1625AC0", Offset = "0x16242C0", VA = "0x181625AC0")]
		internal void CKCPKGMHEKJ(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EKIIEJHCJJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public FNOPAEHNMOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ANLLKONFFGB authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public EKIIEJHCJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
		internal void HPGPOLKFBHD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1625C60", Offset = "0x1624460", VA = "0x181625C60")]
		internal void JEKPICAINLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1625C10", Offset = "0x1624410", VA = "0x181625C10")]
		internal void GMOKPBLKDGK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> OAJLPKMMFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HACNNHJDCIJ DACNHENDPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IGFEPHOMJKL GHGNDJCGEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NFGGLICEMKM FCAFKNABGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CJDPKGADGIH BIBEGGCMBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly EDGHCOGIIEI OEDOFDBDLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly OFMGHOIACNF PCMEGBFDMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly LJHCCABAIOC NNHKFHBGEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool PHHNAHNIKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool NPHLBFADJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> BBLIMCKBEJB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string FGEJKGJCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C35F0", Offset = "0x8C1DF0", VA = "0x1808C35F0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9130B0", Offset = "0x9118B0", VA = "0x1809130B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string KFLFHLGGLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1627800", Offset = "0x1626000", VA = "0x181627800", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PDOJOFBPAKG GAMIEODLCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x16276A0", Offset = "0x1625EA0", VA = "0x1816276A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1628570", Offset = "0x1626D70", VA = "0x181628570", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BHKHNGMGCHD LGBCIIFOEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1627760", Offset = "0x1625F60", VA = "0x181627760", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1626CD0", Offset = "0x16254D0", VA = "0x181626CD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LDKIEBHAMFE KPPDFGMBLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x16284D0", Offset = "0x1626CD0", VA = "0x1816284D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1627850", Offset = "0x1626050", VA = "0x181627850", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event PCAPOFHEEEM AJIDEAIOLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1627AB0", Offset = "0x16262B0", VA = "0x181627AB0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1627600", Offset = "0x1625E00", VA = "0x181627600", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event CEJALBNDOMO OJLMPHOOFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1625D20", Offset = "0x1624520", VA = "0x181625D20", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PJGNFFEAINK DKMGHBABKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1627990", Offset = "0x1626190", VA = "0x181627990", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x16263E0", Offset = "0x1624BE0", VA = "0x1816263E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event AFDMDMCFEBK AFHNHPADBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1626C30", Offset = "0x1625430", VA = "0x181626C30", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1625DC0", Offset = "0x16245C0", VA = "0x181625DC0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event KPEONADKINL PFLKMGABDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1626E10", Offset = "0x1625610", VA = "0x181626E10", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1628610", Offset = "0x1626E10", VA = "0x181628610", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action HEPEEGOJMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x16274F0", Offset = "0x1625CF0", VA = "0x1816274F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x16278F0", Offset = "0x16260F0", VA = "0x1816278F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1627590", Offset = "0x1625D90", VA = "0x181627590")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x16289B0", Offset = "0x16271B0", VA = "0x1816289B0")]
	[Preserve]
	internal FNOPAEHNMOD([ACEKLAKDMBL(null)] CJDPKGADGIH BIBEGGCMBIK, [ACEKLAKDMBL(null)] OFMGHOIACNF PCMEGBFDMLD, [ACEKLAKDMBL(null)] EDGHCOGIIEI OEDOFDBDLNG, [ACEKLAKDMBL(null)] LJHCCABAIOC GEAIFDNFEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1628770", Offset = "0x1626F70", VA = "0x181628770", Slot = "23")]
	public void PBAELFIBGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1627DF0", Offset = "0x16265F0", VA = "0x181627DF0", Slot = "24")]
	public void MIOBLCPKFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x16273E0", Offset = "0x1625BE0", VA = "0x1816273E0")]
	private void IIIHAAKHFHN(bool MMKJEPBGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1627E60", Offset = "0x1626660", VA = "0x181627E60")]
	private void MJPMMKNMBNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1626290", Offset = "0x1624A90", VA = "0x181626290")]
	private void BNCBHDOIADA(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1627350", Offset = "0x1625B50", VA = "0x181627350")]
	private void HCPOCKIPHHL(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1626860", Offset = "0x1625060", VA = "0x181626860", Slot = "32")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1626B00", Offset = "0x1625300", VA = "0x181626B00", Slot = "34")]
	public void EDGGHLPPPAK(HACNNHJDCIJ HGFMEPEKMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1627080", Offset = "0x1625880", VA = "0x181627080", Slot = "35")]
	public void GNKJMGMACJK(IGFEPHOMJKL HGFMEPEKMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1627B50", Offset = "0x1626350", VA = "0x181627B50", Slot = "36")]
	public void MBBOKLAFOKJ(NFGGLICEMKM HGFMEPEKMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1626EB0", Offset = "0x16256B0", VA = "0x181626EB0", Slot = "25")]
	public ANLLKONFFGB GBMLEFIKPDL()
	{
		return default(ANLLKONFFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1627370", Offset = "0x1625B70", VA = "0x181627370", Slot = "26")]
	public string HEKIKBPPIOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1626610", Offset = "0x1624E10", VA = "0x181626610", Slot = "27")]
	public EILHPPDHBHH DBAMFILIOBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1625E60", Offset = "0x1624660", VA = "0x181625E60", Slot = "28")]
	public EILHPPDHBHH ALFLCGEKMBH(int INMAFMKCGOJ, string LHGHMOCEKND, string KBBEMPODLCC, string LCGFFMJDNPA, string MGOKFBGMMNC, DateTime LGDOHFNPFEI, Action<COKACHOCJDL> HJLFMPJMEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1626480", Offset = "0x1624C80", VA = "0x181626480", Slot = "29")]
	public EILHPPDHBHH BPDCKOPCCJF(string LHGHMOCEKND, string KBBEMPODLCC, params int[] BBCMBDHPLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16286B0", Offset = "0x1626EB0", VA = "0x1816286B0", Slot = "30")]
	public bool OHNOFHKOKKH(out int? AGMAMFDBLIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1626FC0", Offset = "0x16257C0", VA = "0x181626FC0", Slot = "31")]
	public bool GFDAGNHPLFB(out EPGLNFHALNM EGPGEBCKIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1628080", Offset = "0x1626880", VA = "0x181628080")]
	private EILHPPDHBHH NAKOGKIKANC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x16265A0", Offset = "0x1624DA0", VA = "0x1816265A0")]
	private void CJDHENFGFKF(EPGLNFHALNM NNKMAJMJMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1627A30", Offset = "0x1626230", VA = "0x181627A30")]
	private void LKHNNDBEJLC(EPGLNFHALNM NNKMAJMJMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1628990", Offset = "0x1627190", VA = "0x181628990")]
	private void PMPFLGCIBAM(string LHGHMOCEKND, string PHLIFPPEJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1626840", Offset = "0x1625040", VA = "0x181626840")]
	private void DOLDDLOIEII(string LHGHMOCEKND, string PHLIFPPEJGL, string AAOLPJCANPC, string LBEOLPPPADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x16273C0", Offset = "0x1625BC0", VA = "0x1816273C0")]
	private void IDJDONAGCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1627740", Offset = "0x1625F40", VA = "0x181627740")]
	[CompilerGenerated]
	private void KCGBEDMFKNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NFGGLICEMKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string HCEHKLNGFML
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string PIIFHPDGBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<EPGLNFHALNM> AJIDEAIOLNK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EILHPPDHBHH MPHDLCHACKI();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EILHPPDHBHH NAKOGKIKANC();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EPGLNFHALNM JIBLIAGJEHD();
}
namespace RecRoom.PlatformNotifications
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PlatformNotificationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		Local,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Remote
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IGFEPHOMJKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<EPGLNFHALNM> AJIDEAIOLNK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event AFDMDMCFEBK CKLNIEKNFNO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event KPEONADKINL MMBCGFDPBFP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EPGLNFHALNM JIBLIAGJEHD();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JNLGJOJLAPG(string KBBEMPODLCC);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EILHPPDHBHH ALFLCGEKMBH(int INMAFMKCGOJ, string LHGHMOCEKND, string KBBEMPODLCC, string LCGFFMJDNPA, string MGOKFBGMMNC, DateTime LGDOHFNPFEI, [Optional] Action<COKACHOCJDL> HJLFMPJMEHI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EILHPPDHBHH BPDCKOPCCJF(string LHGHMOCEKND, string KBBEMPODLCC, params int[] BBCMBDHPLLD);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JABKPCKNEPH(params int[] BBCMBDHPLLD);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FBOIODOHLKG
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float CHKCOGJLNOH = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<EPGLNFHALNM> AJIDEAIOLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private AFDMDMCFEBK CKLNIEKNFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private KPEONADKINL MMBCGFDPBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LDKIEBHAMFE KPPDFGMBLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OFMGHOIACNF PCMEGBFDMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MIGOFOLIJGE AHHBOMNOGMN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OFMGHOIACNF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JABCECBIEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int GJAEOHFDHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DateTime? BCLIHIGBMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[JIAMBIICBFF]
internal class ALMEHEMHFAK : CJDPKGADGIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DAPGFICPMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public ALMEHEMHFAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EPGLNFHALNM notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OFMGHOIACNF PCMEGBFDMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EPGLNFHALNM EGPGEBCKIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? BLHDKIGGFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> LLFILPOENBJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event PCAPOFHEEEM AJIDEAIOLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x16254B0", Offset = "0x1623CB0", VA = "0x1816254B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1625370", Offset = "0x1623B70", VA = "0x181625370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event PJGNFFEAINK DKMGHBABKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1625410", Offset = "0x1623C10", VA = "0x181625410", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1624EF0", Offset = "0x16236F0", VA = "0x181624EF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1625300", Offset = "0x1623B00", VA = "0x181625300")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1625640", Offset = "0x1623E40", VA = "0x181625640")]
	[Preserve]
	internal ALMEHEMHFAK([ACEKLAKDMBL(null)] OFMGHOIACNF PCMEGBFDMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1625610", Offset = "0x1623E10", VA = "0x181625610", Slot = "9")]
	public bool OHNOFHKOKKH(out int? AGMAMFDBLIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x16250B0", Offset = "0x16238B0", VA = "0x1816250B0", Slot = "10")]
	public bool GFDAGNHPLFB(out EPGLNFHALNM NIHNHOGMLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x16251B0", Offset = "0x16239B0", VA = "0x1816251B0", Slot = "11")]
	public void HANNHBJJNFF(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1625570", Offset = "0x1623D70", VA = "0x181625570", Slot = "8")]
	public void MIOBLCPKFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1624F90", Offset = "0x1623790", VA = "0x181624F90")]
	private void FGLFJIOIKPB(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x16250E0", Offset = "0x16238E0", VA = "0x1816250E0")]
	private void GPIMONOFLIJ(EPGLNFHALNM KMIIADOPLHP, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1625550", Offset = "0x1623D50", VA = "0x181625550")]
	[CompilerGenerated]
	private void LOLIBNFGLFF(ref DAPGFICPMLH P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class COKACHOCJDL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int? AGMAMFDBLIO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DateTime MBGMIPDACCP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string LHMONOIIPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string DJEEBIMHMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PlatformNotificationType KGIIACFPECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEE0", Offset = "0x8AA6E0", VA = "0x1808ABEE0")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string LHGHMOCEKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F3660", Offset = "0x7F1E60", VA = "0x1807F3660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KBBEMPODLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F51E0", Offset = "0x7F39E0", VA = "0x1807F51E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string LBPGHLKFEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x80DE70", Offset = "0x80C670", VA = "0x18080DE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string OMADCFACENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8C35E0", Offset = "0x8C1DE0", VA = "0x1808C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public long? BGIJOJAIGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAFEA50", Offset = "0xAFD250", VA = "0x180AFEA50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int? DBBDKOJAIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8C3600", Offset = "0x8C1E00", VA = "0x1808C3600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public long? DMAOCMDFEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xB5CD90", Offset = "0xB5B590", VA = "0x180B5CD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? HAMIEGOKEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1625AB0", Offset = "0x16242B0", VA = "0x181625AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1625AA0", Offset = "0x16242A0", VA = "0x181625AA0")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PDOFHJEKKFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string KFLFHLGGLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event PDOJOFBPAKG GAMIEODLCDN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event BHKHNGMGCHD LGBCIIFOEJP;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event LDKIEBHAMFE KPPDFGMBLBD;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event PCAPOFHEEEM AJIDEAIOLNK;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event CEJALBNDOMO OJLMPHOOFBP;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event AFDMDMCFEBK AFHNHPADBNI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event KPEONADKINL PFLKMGABDMD;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event PJGNFFEAINK DKMGHBABKFE;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action HEPEEGOJMCF;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PBAELFIBGFO();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MIOBLCPKFCK();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	ANLLKONFFGB GBMLEFIKPDL();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string HEKIKBPPIOL();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	EILHPPDHBHH DBAMFILIOBL();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	EILHPPDHBHH ALFLCGEKMBH(int INMAFMKCGOJ, string LHGHMOCEKND, string KBBEMPODLCC, string LCGFFMJDNPA, string MGOKFBGMMNC, DateTime LGDOHFNPFEI, Action<COKACHOCJDL> HJLFMPJMEHI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EILHPPDHBHH BPDCKOPCCJF(string LHGHMOCEKND, string KBBEMPODLCC, params int[] BBCMBDHPLLD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool OHNOFHKOKKH(out int? AGMAMFDBLIO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool GFDAGNHPLFB(out EPGLNFHALNM EGPGEBCKIDL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CJDPKGADGIH
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event PCAPOFHEEEM AJIDEAIOLNK;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event PJGNFFEAINK DKMGHBABKFE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIOBLCPKFCK();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OHNOFHKOKKH(out int? AGMAMFDBLIO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GFDAGNHPLFB(out EPGLNFHALNM EGPGEBCKIDL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HANNHBJJNFF(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HACNNHJDCIJ
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event LDKIEBHAMFE KPPDFGMBLBD;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ANLLKONFFGB GBMLEFIKPDL();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EILHPPDHBHH DBAMFILIOBL();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string HEKIKBPPIOL();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<EPGLNFHALNM> HKCEKGMIAJN();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDACGBNAHBI();
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
