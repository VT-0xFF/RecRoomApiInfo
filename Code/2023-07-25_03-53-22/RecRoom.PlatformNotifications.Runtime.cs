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
public class MKLIJEGEFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int DGBKDMMDCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType HCKGHBENCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public OCGPDFJGEFM MKBHOGOAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool GFOLOIAHGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string OIAHBFGNAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string FLGKNBGFMGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ECBKHNKEHFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KJGIJHOJKOC? JEEEDADHGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, IBHBGBJGJHP<bool>> PJFNEFCLEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KJGIJHOJKOC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MFAHPGPCHDE(bool DHPCHJKOPIB, string HDFFHJKOOCG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void COCNKLOKBND(bool DHPCHJKOPIB, string HDFFHJKOOCG, KJGIJHOJKOC HMLIJKCNLBB, string FFKJLIDBALM);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HCEMDMKHBJC();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void JJCGADGCONA(MKLIJEGEFAO IFLPODEJGCD, PlatformNotificationHandlerContext AEOEKGNDHFM);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void ECMLKBAHNMA(MKLIJEGEFAO IFLPODEJGCD);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void GFDGGDFPPCC(MKLIJEGEFAO IFLPODEJGCD, PlatformNotificationHandlerContext AEOEKGNDHFM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void NJCMHJCGJNA(string EKKACNOBLHA, string JFEPAJGODLC, string GHEJLAOAGJB, string CGONCKBPODL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void LAJEHBAKEMN(string EKKACNOBLHA, string JFEPAJGODLC);
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
[LADFGCPPLHJ]
internal class MIPOPKEKJMB : CDLBMNKPGDC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KKDECLMOJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MIPOPKEKJMB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public KKDECLMOJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		internal void EIGOHEMGNDL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x726E620", Offset = "0x726D620", VA = "0x18726E620")]
		internal void KEDPPGGDNHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HFLAAAOHGLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public MIPOPKEKJMB <>4__this;

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
		public Action<OCGPDFJGEFM> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public HFLAAAOHGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x726E440", Offset = "0x726D440", VA = "0x18726E440")]
		internal void IOHAEHHKJHE(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LJJDCDGINGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public MIPOPKEKJMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public KJGIJHOJKOC authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LJJDCDGINGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		internal void DKBPJMANMIB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x726E6B0", Offset = "0x726D6B0", VA = "0x18726E6B0")]
		internal void JNACHMLGCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x726E660", Offset = "0x726D660", VA = "0x18726E660")]
		internal void GEBHMLBNDKI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> KMMMAGKDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CCFBCODOAOF LECJAAIHAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private JBCHBNDCDNE MNNHOHIAOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private AEMENGHBFCH GHNCDHPIANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly OIOHMMINJLA IECCLPFBKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly GDMGDOKLFNJ GINAJLPIJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly MGEEJKJCIPH FONFBBEHIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly ECBKHNKEHFP CFHKLGAJIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CIHMBAPJFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool JFBGKIOPACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> OJNOJJGOEFK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string ODAMEFGFFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9768A0", Offset = "0x9758A0", VA = "0x1809768A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string JMGOMLFMOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x726FA20", Offset = "0x726EA20", VA = "0x18726FA20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MFAHPGPCHDE OBOGCNKDPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7270A30", Offset = "0x726FA30", VA = "0x187270A30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7271390", Offset = "0x7270390", VA = "0x187271390", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event COCNKLOKBND MKGNHDCIHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x726F590", Offset = "0x726E590", VA = "0x18726F590", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x726FB60", Offset = "0x726EB60", VA = "0x18726FB60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event HCEMDMKHBJC GDOGIGOENMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7270990", Offset = "0x726F990", VA = "0x187270990", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7270670", Offset = "0x726F670", VA = "0x187270670", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JJCGADGCONA BLLEIEGHEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x726FD60", Offset = "0x726ED60", VA = "0x18726FD60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7270AD0", Offset = "0x726FAD0", VA = "0x187270AD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event ECMLKBAHNMA CMCMGMODJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72711B0", Offset = "0x72701B0", VA = "0x1872711B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x726FC00", Offset = "0x726EC00", VA = "0x18726FC00", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GFDGGDFPPCC AGNPBEKHPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x726FCC0", Offset = "0x726ECC0", VA = "0x18726FCC0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x726FAC0", Offset = "0x726EAC0", VA = "0x18726FAC0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event NJCMHJCGJNA EPGMCEGONLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7270B70", Offset = "0x726FB70", VA = "0x187270B70", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x726E800", Offset = "0x726D800", VA = "0x18726E800", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event LAJEHBAKEMN DFFJLDPPLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x726F740", Offset = "0x726E740", VA = "0x18726F740", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7270710", Offset = "0x726F710", VA = "0x187270710", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action CHLFCPDGPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x726F630", Offset = "0x726E630", VA = "0x18726F630", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x726F250", Offset = "0x726E250", VA = "0x18726F250", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x726F6D0", Offset = "0x726E6D0", VA = "0x18726F6D0")]
	[FBCFLFBFGIL(LAFFCBAHJKM.None)]
	private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7271430", Offset = "0x7270430", VA = "0x187271430")]
	[Preserve]
	internal MIPOPKEKJMB([JFLEHDEIONF(null)] OIOHMMINJLA IECCLPFBKNC, [JFLEHDEIONF(null)] MGEEJKJCIPH FONFBBEHIMN, [JFLEHDEIONF(null)] GDMGDOKLFNJ GINAJLPIJLK, [JFLEHDEIONF(null)] ECBKHNKEHFP BBFEMHKPCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7270220", Offset = "0x726F220", VA = "0x187270220", Slot = "23")]
	public void LLEBBJIFEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x726EF20", Offset = "0x726DF20", VA = "0x18726EF20", Slot = "24")]
	public void BGHBJBEJLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x726F7E0", Offset = "0x726E7E0", VA = "0x18726F7E0")]
	private void HIGCKFCJKKB(bool MBBHBDJELPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x726E8A0", Offset = "0x726D8A0", VA = "0x18726E8A0")]
	private void ACIAEJIELBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7271250", Offset = "0x7270250", VA = "0x187271250")]
	private void PJKPKHKPBLK(MKLIJEGEFAO IFLPODEJGCD, PlatformNotificationHandlerContext AEOEKGNDHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7270C10", Offset = "0x726FC10", VA = "0x187270C10")]
	private void NKLMEKBEKMN(MKLIJEGEFAO IFLPODEJGCD, PlatformNotificationHandlerContext AEOEKGNDHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x726F2F0", Offset = "0x726E2F0", VA = "0x18726F2F0", Slot = "32")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x726F8F0", Offset = "0x726E8F0", VA = "0x18726F8F0", Slot = "34")]
	public void IDELIEFCGEC(CCFBCODOAOF CAKIIDPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x726EC50", Offset = "0x726DC50", VA = "0x18726EC50", Slot = "35")]
	public void ANFGBLFICGI(JBCHBNDCDNE CAKIIDPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x726EF90", Offset = "0x726DF90", VA = "0x18726EF90", Slot = "36")]
	public void BLFHFNPPNJP(AEMENGHBFCH CAKIIDPHAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x726EB50", Offset = "0x726DB50", VA = "0x18726EB50", Slot = "25")]
	public KJGIJHOJKOC AMANLAJDGFD()
	{
		return default(KJGIJHOJKOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x726FA70", Offset = "0x726EA70", VA = "0x18726FA70", Slot = "26")]
	public string IHBDOOIDPFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7270440", Offset = "0x726F440", VA = "0x187270440", Slot = "27")]
	public GAEMIFNLIHB LNIMLIPIFEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x726FE00", Offset = "0x726EE00", VA = "0x18726FE00", Slot = "28")]
	public GAEMIFNLIHB LKCPFFOLNJO(int BAOOEIEBKMH, string EKKACNOBLHA, string FHJIOGDDBKF, string EOFFACGNFMG, string CKIIOJOABAO, DateTime GCLMMCCPNDD, Action<OCGPDFJGEFM> JMPNLGKOBCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72707B0", Offset = "0x726F7B0", VA = "0x1872707B0", Slot = "29")]
	public GAEMIFNLIHB MBEKDBKIADB(string EKKACNOBLHA, string FHJIOGDDBKF, params int[] IHEDJDOOKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7270C30", Offset = "0x726FC30", VA = "0x187270C30", Slot = "30")]
	public bool OGECLLGMFBK(out int? CPBBCPFIMJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72708D0", Offset = "0x726F8D0", VA = "0x1872708D0", Slot = "31")]
	public bool MGHNKIHJGPC(out MKLIJEGEFAO AFNDCOABCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7270CF0", Offset = "0x726FCF0", VA = "0x187270CF0")]
	private GAEMIFNLIHB PBHMFABAIMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7271140", Offset = "0x7270140", VA = "0x187271140")]
	private void PFOOIJCAFFP(MKLIJEGEFAO IFLPODEJGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x726EAD0", Offset = "0x726DAD0", VA = "0x18726EAD0")]
	private void ADIAEOAHHGA(MKLIJEGEFAO IFLPODEJGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x726FCA0", Offset = "0x726ECA0", VA = "0x18726FCA0")]
	private void KLPFCOPBIMK(string EKKACNOBLHA, string JFEPAJGODLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x726F230", Offset = "0x726E230", VA = "0x18726F230")]
	private void CGOACHKIBFP(string EKKACNOBLHA, string JFEPAJGODLC, string GHEJLAOAGJB, string CGONCKBPODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xC57E70", Offset = "0xC56E70", VA = "0x180C57E70")]
	private void LKGCPMNKCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x12D6CA0", Offset = "0x12D5CA0", VA = "0x1812D6CA0")]
	[CompilerGenerated]
	private void AIGIEDIICAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AEMENGHBFCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string KGEOOHIMPFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string IHPCMNALJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<MKLIJEGEFAO> BLLEIEGHEKN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GAEMIFNLIHB FKFAMNEABCJ();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GAEMIFNLIHB PBHMFABAIMA();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MKLIJEGEFAO PNINOKFPPCM();
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
public interface JBCHBNDCDNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MKLIJEGEFAO> BLLEIEGHEKN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event NJCMHJCGJNA FFDEOKAJJJI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event LAJEHBAKEMN DIHGCDJFCKN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MKLIJEGEFAO PNINOKFPPCM();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KCPIHIPJJIG(string FHJIOGDDBKF);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GAEMIFNLIHB LKCPFFOLNJO(int BAOOEIEBKMH, string EKKACNOBLHA, string FHJIOGDDBKF, string EOFFACGNFMG, string CKIIOJOABAO, DateTime GCLMMCCPNDD, [Optional] Action<OCGPDFJGEFM> JMPNLGKOBCA);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GAEMIFNLIHB MBEKDBKIADB(string EKKACNOBLHA, string FHJIOGDDBKF, params int[] IHEDJDOOKAH);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NIDOHNGCAAJ(params int[] IHEDJDOOKAH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GEPDDIDOEPI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float BJGKFOONMAA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<MKLIJEGEFAO> BLLEIEGHEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NJCMHJCGJNA FFDEOKAJJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LAJEHBAKEMN DIHGCDJFCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private HCEMDMKHBJC GDOGIGOENMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly MGEEJKJCIPH FONFBBEHIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EDKLOBCPLML MNMAOHAMKAN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MGEEJKJCIPH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ELOPBHMBBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int CAEENHJDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DateTime? ODEHJIJOBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[LADFGCPPLHJ]
internal class PLHPBEOFGIK : OIOHMMINJLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HGEBHGDLECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PLHPBEOFGIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public MKLIJEGEFAO notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MGEEJKJCIPH FONFBBEHIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private MKLIJEGEFAO AFNDCOABCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? MLKLPJKGHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> LHGACKLDFMC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event JJCGADGCONA BLLEIEGHEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7271970", Offset = "0x7270970", VA = "0x187271970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7271A40", Offset = "0x7270A40", VA = "0x187271A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event GFDGGDFPPCC AGNPBEKHPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72718D0", Offset = "0x72708D0", VA = "0x1872718D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7271830", Offset = "0x7270830", VA = "0x187271830", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72717C0", Offset = "0x72707C0", VA = "0x1872717C0")]
	[FBCFLFBFGIL(LAFFCBAHJKM.None)]
	private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7271C80", Offset = "0x7270C80", VA = "0x187271C80")]
	[Preserve]
	internal PLHPBEOFGIK([JFLEHDEIONF(null)] MGEEJKJCIPH FONFBBEHIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7271C30", Offset = "0x7270C30", VA = "0x187271C30", Slot = "9")]
	public bool OGECLLGMFBK(out int? CPBBCPFIMJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7271A10", Offset = "0x7270A10", VA = "0x187271A10", Slot = "10")]
	public bool MGHNKIHJGPC(out MKLIJEGEFAO MEMJFMCOLDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7271AE0", Offset = "0x7270AE0", VA = "0x187271AE0", Slot = "11")]
	public void NIGAMDLKIDL(MKLIJEGEFAO IFLPODEJGCD, PlatformNotificationHandlerContext AEOEKGNDHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72715F0", Offset = "0x72705F0", VA = "0x1872715F0", Slot = "8")]
	public void BGHBJBEJLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7271690", Offset = "0x7270690", VA = "0x187271690")]
	private void CFHLHDINHBP(MKLIJEGEFAO IFLPODEJGCD, PlatformNotificationHandlerContext AEOEKGNDHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7271520", Offset = "0x7270520", VA = "0x187271520")]
	private void AEAHHKADMHA(MKLIJEGEFAO FEEDKLNBMGP, PlatformNotificationHandlerContext AEOEKGNDHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7271C60", Offset = "0x7270C60", VA = "0x187271C60")]
	[CompilerGenerated]
	private void PACNGGCNAJI(ref HGEBHGDLECN P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OCGPDFJGEFM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int? CPBBCPFIMJO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DateTime CFDDBPDCDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string GGAAKLBDIEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string NNMLGLKNBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PlatformNotificationType JPMBABEJILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8B0", Offset = "0xA1D8B0", VA = "0x180A1E8B0")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string EKKACNOBLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FHJIOGDDBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string JOLIBAKHABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string LEFHFFAGLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x97E580", Offset = "0x97D580", VA = "0x18097E580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public long? NNKGDPMPFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC277B0", Offset = "0xC267B0", VA = "0x180C277B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int? KDMIBDMEKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public long? MLDMDFFFKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xED20E0", Offset = "0xED10E0", VA = "0x180ED20E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? IHGIEILPMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x17032D0", Offset = "0x17022D0", VA = "0x1817032D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1D42AA0", Offset = "0x1D41AA0", VA = "0x181D42AA0")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CDLBMNKPGDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string JMGOMLFMOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event MFAHPGPCHDE OBOGCNKDPAL;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event COCNKLOKBND MKGNHDCIHPN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event HCEMDMKHBJC GDOGIGOENMD;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event JJCGADGCONA BLLEIEGHEKN;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ECMLKBAHNMA CMCMGMODJEN;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event NJCMHJCGJNA EPGMCEGONLC;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event LAJEHBAKEMN DFFJLDPPLHC;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event GFDGGDFPPCC AGNPBEKHPKH;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action CHLFCPDGPPC;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LLEBBJIFEDK();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BGHBJBEJLFO();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	KJGIJHOJKOC AMANLAJDGFD();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string IHBDOOIDPFD();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	GAEMIFNLIHB LNIMLIPIFEB();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GAEMIFNLIHB LKCPFFOLNJO(int BAOOEIEBKMH, string EKKACNOBLHA, string FHJIOGDDBKF, string EOFFACGNFMG, string CKIIOJOABAO, DateTime GCLMMCCPNDD, Action<OCGPDFJGEFM> JMPNLGKOBCA);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GAEMIFNLIHB MBEKDBKIADB(string EKKACNOBLHA, string FHJIOGDDBKF, params int[] IHEDJDOOKAH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool OGECLLGMFBK(out int? CPBBCPFIMJO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MGHNKIHJGPC(out MKLIJEGEFAO AFNDCOABCJA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OIOHMMINJLA
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event JJCGADGCONA BLLEIEGHEKN;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event GFDGGDFPPCC AGNPBEKHPKH;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGHBJBEJLFO();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OGECLLGMFBK(out int? CPBBCPFIMJO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MGHNKIHJGPC(out MKLIJEGEFAO AFNDCOABCJA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NIGAMDLKIDL(MKLIJEGEFAO IFLPODEJGCD, PlatformNotificationHandlerContext AEOEKGNDHFM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CCFBCODOAOF
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event HCEMDMKHBJC GDOGIGOENMD;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KJGIJHOJKOC AMANLAJDGFD();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GAEMIFNLIHB LNIMLIPIFEB();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string IHBDOOIDPFD();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<MKLIJEGEFAO> BGPANGAENIO();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JAFIALEJJEE();
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
