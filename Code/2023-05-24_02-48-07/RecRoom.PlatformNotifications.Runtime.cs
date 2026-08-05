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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ONDLDAMFIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		internal void FPMEDKAKMBG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DF80", Offset = "0x6F8CB80", VA = "0x186F8DF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DAOHEFMEIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AFE0", Offset = "0x6F89BE0", VA = "0x186F8AFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public EKIIEJHCJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		internal void HPGPOLKFBHD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B180", Offset = "0x6F89D80", VA = "0x186F8B180")]
		internal void JEKPICAINLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B130", Offset = "0x6F89D30", VA = "0x186F8B130")]
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
		[Cpp2IlInjected.Address(RVA = "0x84D800", Offset = "0x84C400", VA = "0x18084D800", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89D540", Offset = "0x89C140", VA = "0x18089D540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string KFLFHLGGLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CCE0", Offset = "0x6F8B8E0", VA = "0x186F8CCE0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PDOJOFBPAKG GAMIEODLCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CBA0", Offset = "0x6F8B7A0", VA = "0x186F8CBA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DA50", Offset = "0x6F8C650", VA = "0x186F8DA50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BHKHNGMGCHD LGBCIIFOEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CC40", Offset = "0x6F8B840", VA = "0x186F8CC40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C1F0", Offset = "0x6F8ADF0", VA = "0x186F8C1F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LDKIEBHAMFE KPPDFGMBLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D9B0", Offset = "0x6F8C5B0", VA = "0x186F8D9B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CD30", Offset = "0x6F8B930", VA = "0x186F8CD30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event PCAPOFHEEEM AJIDEAIOLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CF90", Offset = "0x6F8BB90", VA = "0x186F8CF90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CB00", Offset = "0x6F8B700", VA = "0x186F8CB00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event CEJALBNDOMO OJLMPHOOFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B240", Offset = "0x6F89E40", VA = "0x186F8B240", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C290", Offset = "0x6F8AE90", VA = "0x186F8C290", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PJGNFFEAINK DKMGHBABKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CE70", Offset = "0x6F8BA70", VA = "0x186F8CE70", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B900", Offset = "0x6F8A500", VA = "0x186F8B900", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event AFDMDMCFEBK AFHNHPADBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C150", Offset = "0x6F8AD50", VA = "0x186F8C150", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B2E0", Offset = "0x6F89EE0", VA = "0x186F8B2E0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event KPEONADKINL PFLKMGABDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C330", Offset = "0x6F8AF30", VA = "0x186F8C330", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DAF0", Offset = "0x6F8C6F0", VA = "0x186F8DAF0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action HEPEEGOJMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C9F0", Offset = "0x6F8B5F0", VA = "0x186F8C9F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CDD0", Offset = "0x6F8B9D0", VA = "0x186F8CDD0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CA90", Offset = "0x6F8B690", VA = "0x186F8CA90")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DE90", Offset = "0x6F8CA90", VA = "0x186F8DE90")]
	[Preserve]
	internal FNOPAEHNMOD([ACEKLAKDMBL(null)] CJDPKGADGIH BIBEGGCMBIK, [ACEKLAKDMBL(null)] OFMGHOIACNF PCMEGBFDMLD, [ACEKLAKDMBL(null)] EDGHCOGIIEI OEDOFDBDLNG, [ACEKLAKDMBL(null)] LJHCCABAIOC GEAIFDNFEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DC50", Offset = "0x6F8C850", VA = "0x186F8DC50", Slot = "23")]
	public void PBAELFIBGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D2D0", Offset = "0x6F8BED0", VA = "0x186F8D2D0", Slot = "24")]
	public void MIOBLCPKFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C8E0", Offset = "0x6F8B4E0", VA = "0x186F8C8E0")]
	private void IIIHAAKHFHN(bool MMKJEPBGOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D340", Offset = "0x6F8BF40", VA = "0x186F8D340")]
	private void MJPMMKNMBNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B7B0", Offset = "0x6F8A3B0", VA = "0x186F8B7B0")]
	private void BNCBHDOIADA(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C870", Offset = "0x6F8B470", VA = "0x186F8C870")]
	private void HCPOCKIPHHL(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BD80", Offset = "0x6F8A980", VA = "0x186F8BD80", Slot = "32")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C020", Offset = "0x6F8AC20", VA = "0x186F8C020", Slot = "34")]
	public void EDGGHLPPPAK(HACNNHJDCIJ HGFMEPEKMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C5A0", Offset = "0x6F8B1A0", VA = "0x186F8C5A0", Slot = "35")]
	public void GNKJMGMACJK(IGFEPHOMJKL HGFMEPEKMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D030", Offset = "0x6F8BC30", VA = "0x186F8D030", Slot = "36")]
	public void MBBOKLAFOKJ(NFGGLICEMKM HGFMEPEKMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C3D0", Offset = "0x6F8AFD0", VA = "0x186F8C3D0", Slot = "25")]
	public ANLLKONFFGB GBMLEFIKPDL()
	{
		return default(ANLLKONFFGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C890", Offset = "0x6F8B490", VA = "0x186F8C890", Slot = "26")]
	public string HEKIKBPPIOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BB30", Offset = "0x6F8A730", VA = "0x186F8BB30", Slot = "27")]
	public EILHPPDHBHH DBAMFILIOBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B380", Offset = "0x6F89F80", VA = "0x186F8B380", Slot = "28")]
	public EILHPPDHBHH ALFLCGEKMBH(int INMAFMKCGOJ, string LHGHMOCEKND, string KBBEMPODLCC, string LCGFFMJDNPA, string MGOKFBGMMNC, DateTime LGDOHFNPFEI, Action<COKACHOCJDL> HJLFMPJMEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B9A0", Offset = "0x6F8A5A0", VA = "0x186F8B9A0", Slot = "29")]
	public EILHPPDHBHH BPDCKOPCCJF(string LHGHMOCEKND, string KBBEMPODLCC, params int[] BBCMBDHPLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DB90", Offset = "0x6F8C790", VA = "0x186F8DB90", Slot = "30")]
	public bool OHNOFHKOKKH(out int? AGMAMFDBLIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C4E0", Offset = "0x6F8B0E0", VA = "0x186F8C4E0", Slot = "31")]
	public bool GFDAGNHPLFB(out EPGLNFHALNM EGPGEBCKIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D560", Offset = "0x6F8C160", VA = "0x186F8D560")]
	private EILHPPDHBHH NAKOGKIKANC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BAC0", Offset = "0x6F8A6C0", VA = "0x186F8BAC0")]
	private void CJDHENFGFKF(EPGLNFHALNM NNKMAJMJMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CF10", Offset = "0x6F8BB10", VA = "0x186F8CF10")]
	private void LKHNNDBEJLC(EPGLNFHALNM NNKMAJMJMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DE70", Offset = "0x6F8CA70", VA = "0x186F8DE70")]
	private void PMPFLGCIBAM(string LHGHMOCEKND, string PHLIFPPEJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BD60", Offset = "0x6F8A960", VA = "0x186F8BD60")]
	private void DOLDDLOIEII(string LHGHMOCEKND, string PHLIFPPEJGL, string AAOLPJCANPC, string LBEOLPPPADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x14CB640", Offset = "0x14CA240", VA = "0x1814CB640")]
	private void IDJDONAGCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1923640", Offset = "0x1922240", VA = "0x181923640")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F8A9F0", Offset = "0x6F895F0", VA = "0x186F8A9F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A8B0", Offset = "0x6F894B0", VA = "0x186F8A8B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event PJGNFFEAINK DKMGHBABKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A950", Offset = "0x6F89550", VA = "0x186F8A950", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A430", Offset = "0x6F89030", VA = "0x186F8A430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A840", Offset = "0x6F89440", VA = "0x186F8A840")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AB80", Offset = "0x6F89780", VA = "0x186F8AB80")]
	[Preserve]
	internal ALMEHEMHFAK([ACEKLAKDMBL(null)] OFMGHOIACNF PCMEGBFDMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AB50", Offset = "0x6F89750", VA = "0x186F8AB50", Slot = "9")]
	public bool OHNOFHKOKKH(out int? AGMAMFDBLIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A5F0", Offset = "0x6F891F0", VA = "0x186F8A5F0", Slot = "10")]
	public bool GFDAGNHPLFB(out EPGLNFHALNM NIHNHOGMLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A6F0", Offset = "0x6F892F0", VA = "0x186F8A6F0", Slot = "11")]
	public void HANNHBJJNFF(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AAB0", Offset = "0x6F896B0", VA = "0x186F8AAB0", Slot = "8")]
	public void MIOBLCPKFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A4D0", Offset = "0x6F890D0", VA = "0x186F8A4D0")]
	private void FGLFJIOIKPB(EPGLNFHALNM NNKMAJMJMPB, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A620", Offset = "0x6F89220", VA = "0x186F8A620")]
	private void GPIMONOFLIJ(EPGLNFHALNM KMIIADOPLHP, PlatformNotificationHandlerContext JFDMKPDIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AA90", Offset = "0x6F89690", VA = "0x186F8AA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240")]
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
		[Cpp2IlInjected.Address(RVA = "0x8360A0", Offset = "0x834CA0", VA = "0x1808360A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83EB00", Offset = "0x83D700", VA = "0x18083EB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x83EB10", Offset = "0x83D710", VA = "0x18083EB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x836090", Offset = "0x834C90", VA = "0x180836090")]
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
		[Cpp2IlInjected.Address(RVA = "0x84D7F0", Offset = "0x84C3F0", VA = "0x18084D7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x17A09A0", Offset = "0x179F5A0", VA = "0x1817A09A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84D810", Offset = "0x84C410", VA = "0x18084D810")]
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
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABD9C0", VA = "0x180ABEDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FAB710", Offset = "0x1FAA310", VA = "0x181FAB710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x24AED00", Offset = "0x24AD900", VA = "0x1824AED00")]
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
