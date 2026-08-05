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
public class LDLGFNGLDKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int MFJHLPCKFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType JJGFPAEGNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ENNPEIILCJN OHALDHAAEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool JFEDHCJLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string LCJKCDEJIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string ECKPKELKCAK;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LFGHOONHKBD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NCPDDBLNKKO? OKEPOHDPANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, MCFFIFIPNKE<bool>> JHFFKNMLOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NCPDDBLNKKO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void AOBOMGBOIMC(bool AAFCDNDAJKK, string LEMHDHLMNOL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NHDJKBKDEHJ(bool AAFCDNDAJKK, string LEMHDHLMNOL, NCPDDBLNKKO BPMLJHJOILP, string GAOLOMEJCOK, string OPEBNAPIHKG);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KFGHEGAIDDN();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void BKIJLEOHLFO(LDLGFNGLDKL CHAECGMHLIF, PlatformNotificationHandlerContext JNNDIHFHMHC);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FPCGCNKAFBO(LDLGFNGLDKL CHAECGMHLIF);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void ADCAIDMGPGO(LDLGFNGLDKL CHAECGMHLIF, PlatformNotificationHandlerContext JNNDIHFHMHC);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void LHHGLPPBOCK(string LFCIAGNBDPO, string GJGLOPMBIID, string FJFDPGNKLOH, string LAAILNMDDME);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void PPODMIMCFCE(string LFCIAGNBDPO, string GJGLOPMBIID);
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
[BFHCHFMBBNB]
internal class IADNHOLALEH : LMFNBEIFFMP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JJEAAOBHIPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IADNHOLALEH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public JJEAAOBHIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		internal void NLLANLBEIEB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F07790", Offset = "0x6F06B90", VA = "0x186F07790")]
		internal void NHGFCMACBEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OHLGPDKEEPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public IADNHOLALEH <>4__this;

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
		public Action<ENNPEIILCJN> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public OHLGPDKEEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F08440", Offset = "0x6F07840", VA = "0x186F08440")]
		internal void AAFNDBDEPJL(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class INKNHDEBIEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IADNHOLALEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NCPDDBLNKKO authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public INKNHDEBIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		internal void LKHHBGEMGII(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F076D0", Offset = "0x6F06AD0", VA = "0x186F076D0")]
		internal void MHOIGGLAKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F075E0", Offset = "0x6F069E0", VA = "0x186F075E0")]
		internal void ILPNPBLPJFE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> ONLJAIDBIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private AGLIOMJODMO AJIHGIIPPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private LPAHECGEHJE IBEDMCHLALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private DMAMPBCHHPG MLFJHELAGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HBPFJBKMAAH GLLGKAKBFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly PBOHIBPCHBK KFFKHIINMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FGCBHOCJKEA HIHJOFCKGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly LFGHOONHKBD OAEEKFOJACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool OJOANCEJMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool FHMPDGHNJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> HJNEKLKAGND;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string LCFFOMGMADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x94B840", Offset = "0x94AC40", VA = "0x18094B840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string DAFGOINOGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F06530", Offset = "0x6F05930", VA = "0x186F06530", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LDLGFNGLDKL FDGDLMFLNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F072D0", Offset = "0x6F066D0", VA = "0x186F072D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event AOBOMGBOIMC DKLLGIOMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F060D0", Offset = "0x6F054D0", VA = "0x186F060D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F05E60", Offset = "0x6F05260", VA = "0x186F05E60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NHDJKBKDEHJ NDKCEHBFGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F04E70", Offset = "0x6F04270", VA = "0x186F04E70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F048B0", Offset = "0x6F03CB0", VA = "0x186F048B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KFGHEGAIDDN JEKHCDLFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F06E60", Offset = "0x6F06260", VA = "0x186F06E60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F07230", Offset = "0x6F06630", VA = "0x186F07230", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event BKIJLEOHLFO PBLGELKEHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F06AF0", Offset = "0x6F05EF0", VA = "0x186F06AF0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F06030", Offset = "0x6F05430", VA = "0x186F06030", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FPCGCNKAFBO PIJANDJAEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F04FB0", Offset = "0x6F043B0", VA = "0x186F04FB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F06170", Offset = "0x6F05570", VA = "0x186F06170", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ADCAIDMGPGO ABHLIBIKMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F04F10", Offset = "0x6F04310", VA = "0x186F04F10", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F04DD0", Offset = "0x6F041D0", VA = "0x186F04DD0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event LHHGLPPBOCK EEGMGGMIHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F049D0", Offset = "0x6F03DD0", VA = "0x186F049D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F05540", Offset = "0x6F04940", VA = "0x186F05540", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event PPODMIMCFCE FFBAIPNKIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F06210", Offset = "0x6F05610", VA = "0x186F06210", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F054A0", Offset = "0x6F048A0", VA = "0x186F054A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action PGIKILHHJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F062B0", Offset = "0x6F056B0", VA = "0x186F062B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F06490", Offset = "0x6F05890", VA = "0x186F06490", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F06F00", Offset = "0x6F06300", VA = "0x186F06F00")]
	[GHLDKGGJCDP(FGNCLGKDFDK.None)]
	private static void NAFFPAPIKOC(EPBOEGFMAOO OHJGEOICJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F074F0", Offset = "0x6F068F0", VA = "0x186F074F0")]
	[Preserve]
	internal IADNHOLALEH([EPGFAMNCJKC(null)] HBPFJBKMAAH GLLGKAKBFGM, [EPGFAMNCJKC(null)] FGCBHOCJKEA HIHJOFCKGAC, [EPGFAMNCJKC(null)] PBOHIBPCHBK KFFKHIINMAO, [EPGFAMNCJKC(null)] LFGHOONHKBD CPIBKOBEODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F04A70", Offset = "0x6F03E70", VA = "0x186F04A70", Slot = "24")]
	public void BEFDPLAELIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F05170", Offset = "0x6F04570", VA = "0x186F05170", Slot = "25")]
	public void DHGOCGCNKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F07410", Offset = "0x6F06810", VA = "0x186F07410")]
	private void PJNNNKKIJCN(bool KBGEKHKOJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F05810", Offset = "0x6F04C10", VA = "0x186F05810")]
	private void EOAOCKNDMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F06350", Offset = "0x6F05750", VA = "0x186F06350")]
	private void IIFMONDHHIO(LDLGFNGLDKL CHAECGMHLIF, PlatformNotificationHandlerContext JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F06F70", Offset = "0x6F06370", VA = "0x186F06F70")]
	private void NGAFAGKNNPF(LDLGFNGLDKL CHAECGMHLIF, PlatformNotificationHandlerContext JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F05200", Offset = "0x6F04600", VA = "0x186F05200", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F04C50", Offset = "0x6F04050", VA = "0x186F04C50", Slot = "35")]
	public void BFPHMJJPKPM(AGLIOMJODMO EDKEDLEOENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F06B90", Offset = "0x6F05F90", VA = "0x186F06B90", Slot = "36")]
	public void MHMGCJLCHJH(LPAHECGEHJE EDKEDLEOENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F06F90", Offset = "0x6F06390", VA = "0x186F06F90", Slot = "37")]
	public void NIMOFGHLDBP(DMAMPBCHHPG EDKEDLEOENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F069F0", Offset = "0x6F05DF0", VA = "0x186F069F0", Slot = "26")]
	public NCPDDBLNKKO LGMFHILELDO()
	{
		return default(NCPDDBLNKKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F04D80", Offset = "0x6F04180", VA = "0x186F04D80", Slot = "27")]
	public string BJFIEJFACFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F055E0", Offset = "0x6F049E0", VA = "0x186F055E0", Slot = "28")]
	public CCKGNGCPCCF ELFLOIPAECC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F05A40", Offset = "0x6F04E40", VA = "0x186F05A40", Slot = "29")]
	public CCKGNGCPCCF FNEONHJPEHH(int ENOCBMENPGH, string LFCIAGNBDPO, string ECFGKMJGODM, string CIDIPJNLOCI, string GKFGNGLEBAH, DateTime ACLALKOPFGM, Action<ENNPEIILCJN> IJELNPPFFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F05050", Offset = "0x6F04450", VA = "0x186F05050", Slot = "30")]
	public CCKGNGCPCCF CJOELKAGGOA(string LFCIAGNBDPO, string ECFGKMJGODM, params int[] MINLDGGIKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F07350", Offset = "0x6F06750", VA = "0x186F07350", Slot = "31")]
	public bool PHKPGLBHIBM(out int? FBAKFDKGCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F05F70", Offset = "0x6F05370", VA = "0x186F05F70", Slot = "32")]
	public bool GLADNOJECKL(out LDLGFNGLDKL AGOGEMIJAHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F06580", Offset = "0x6F05980", VA = "0x186F06580")]
	private CCKGNGCPCCF LDCHAMIOMOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F05F00", Offset = "0x6F05300", VA = "0x186F05F00")]
	private void GEHMPCKHFKP(LDLGFNGLDKL CHAECGMHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F04950", Offset = "0x6F03D50", VA = "0x186F04950")]
	private void AEPNMBKAMGC(LDLGFNGLDKL CHAECGMHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F051E0", Offset = "0x6F045E0", VA = "0x186F051E0")]
	private void DJGFEJDFHFG(string LFCIAGNBDPO, string GJGLOPMBIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F074D0", Offset = "0x6F068D0", VA = "0x186F074D0")]
	private void PNGOKGPHLBL(string LFCIAGNBDPO, string GJGLOPMBIID, string FJFDPGNKLOH, string LAAILNMDDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xC220E0", Offset = "0xC214E0", VA = "0x180C220E0")]
	private void GMEDJFFKPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x9BD020", Offset = "0x9BC420", VA = "0x1809BD020")]
	[CompilerGenerated]
	private void AMNMIHKCFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DMAMPBCHHPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string EIHLDLFHBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string KBNOHNCJBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string OAJBGMIJHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<LDLGFNGLDKL> PBLGELKEHHI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CCKGNGCPCCF PNGGDGKMFMG();

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CCKGNGCPCCF LDCHAMIOMOO();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EOFEDLKHNHC(bool BLICINMDPPN);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LDLGFNGLDKL DNEHCDCLHLF();
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
public interface LPAHECGEHJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LDLGFNGLDKL> PBLGELKEHHI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event LHHGLPPBOCK IAMCHHEKAMF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event PPODMIMCFCE BBJGBDDDGPK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LDLGFNGLDKL DNEHCDCLHLF();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KFPBFEGBELM(string ECFGKMJGODM);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CCKGNGCPCCF FNEONHJPEHH(int ENOCBMENPGH, string LFCIAGNBDPO, string ECFGKMJGODM, string CIDIPJNLOCI, string GKFGNGLEBAH, DateTime ACLALKOPFGM, [Optional] Action<ENNPEIILCJN> IJELNPPFFNG);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CCKGNGCPCCF CJOELKAGGOA(string LFCIAGNBDPO, string ECFGKMJGODM, params int[] MINLDGGIKHJ);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODHEIEPIPIB(params int[] MINLDGGIKHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HFEDBGCMAMC
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float HEGLJACJPPF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<LDLGFNGLDKL> PBLGELKEHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LHHGLPPBOCK IAMCHHEKAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PPODMIMCFCE BBJGBDDDGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private KFGHEGAIDDN JEKHCDLFPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FGCBHOCJKEA HIHJOFCKGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly PKBGBEDEGAH BEIHHMBEGCC;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FGCBHOCJKEA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool NMOAAKMIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int FBNGNGMLDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime? HNOKMNMBAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[BFHCHFMBBNB]
internal class LLOOGHDDEGE : HBPFJBKMAAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PGCJBGJFPPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LLOOGHDDEGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public LDLGFNGLDKL notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FGCBHOCJKEA HIHJOFCKGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private LDLGFNGLDKL AGOGEMIJAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? EPBNNLNFCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> LHJPAIFHJBJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event BKIJLEOHLFO PBLGELKEHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F07E50", Offset = "0x6F07250", VA = "0x186F07E50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F07CE0", Offset = "0x6F070E0", VA = "0x186F07CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event ADCAIDMGPGO ABHLIBIKMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F07870", Offset = "0x6F06C70", VA = "0x186F07870", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F077D0", Offset = "0x6F06BD0", VA = "0x186F077D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F07EF0", Offset = "0x6F072F0", VA = "0x186F07EF0")]
	[GHLDKGGJCDP(FGNCLGKDFDK.None)]
	private static void NAFFPAPIKOC(EPBOEGFMAOO OHJGEOICJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F07F90", Offset = "0x6F07390", VA = "0x186F07F90")]
	[Preserve]
	internal LLOOGHDDEGE([EPGFAMNCJKC(null)] FGCBHOCJKEA HIHJOFCKGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F07F60", Offset = "0x6F07360", VA = "0x186F07F60", Slot = "9")]
	public bool PHKPGLBHIBM(out int? FBAKFDKGCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F07CB0", Offset = "0x6F070B0", VA = "0x186F07CB0", Slot = "10")]
	public bool GLADNOJECKL(out LDLGFNGLDKL OGFOGFOGDEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F07B60", Offset = "0x6F06F60", VA = "0x186F07B60", Slot = "11")]
	public void FKIBKODACAI(LDLGFNGLDKL CHAECGMHLIF, PlatformNotificationHandlerContext JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F07A60", Offset = "0x6F06E60", VA = "0x186F07A60", Slot = "8")]
	public void DHGOCGCNKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F07910", Offset = "0x6F06D10", VA = "0x186F07910")]
	private void DAIOIJBMAEM(LDLGFNGLDKL CHAECGMHLIF, PlatformNotificationHandlerContext JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F07D80", Offset = "0x6F07180", VA = "0x186F07D80")]
	private void HOACJFMECBI(LDLGFNGLDKL GLMKFGPKGIG, PlatformNotificationHandlerContext JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F07A40", Offset = "0x6F06E40", VA = "0x186F07A40")]
	[CompilerGenerated]
	private void DCFAAIOFFHC(ref PGCJBGJFPPH P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ENNPEIILCJN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int? FBAKFDKGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DateTime AAIOHMIPCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string GFDDOLIKHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string FGFEBEFENPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PlatformNotificationType FCOLOFBHAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x976C20", Offset = "0x976020", VA = "0x180976C20")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string LFCIAGNBDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string ADKMDCKLIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FB0", Offset = "0x8C23B0", VA = "0x1808C2FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string ECFGKMJGODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string AEHPOCNHMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string ENFLEFANLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x94A3F0", Offset = "0x9497F0", VA = "0x18094A3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? ELKHBDAEFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x17433F0", Offset = "0x17427F0", VA = "0x1817433F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int? CKPOLAOEFMD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public long? KJJOKPDJLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x192B160", Offset = "0x192A560", VA = "0x18192B160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public long? KLOAGIPENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x97DA30", Offset = "0x97CE30", VA = "0x18097DA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x97DA20", Offset = "0x97CE20", VA = "0x18097DA20")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LMFNBEIFFMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string DAFGOINOGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LDLGFNGLDKL FDGDLMFLNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event AOBOMGBOIMC DKLLGIOMFFE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NHDJKBKDEHJ NDKCEHBFGPL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event KFGHEGAIDDN JEKHCDLFPBN;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event BKIJLEOHLFO PBLGELKEHHI;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FPCGCNKAFBO PIJANDJAEAM;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event LHHGLPPBOCK EEGMGGMIHEG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PPODMIMCFCE FFBAIPNKIKJ;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event ADCAIDMGPGO ABHLIBIKMOF;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action PGIKILHHJGL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BEFDPLAELIH();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DHGOCGCNKNJ();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NCPDDBLNKKO LGMFHILELDO();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string BJFIEJFACFM();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CCKGNGCPCCF ELFLOIPAECC();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CCKGNGCPCCF FNEONHJPEHH(int ENOCBMENPGH, string LFCIAGNBDPO, string ECFGKMJGODM, string CIDIPJNLOCI, string GKFGNGLEBAH, DateTime ACLALKOPFGM, Action<ENNPEIILCJN> IJELNPPFFNG);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CCKGNGCPCCF CJOELKAGGOA(string LFCIAGNBDPO, string ECFGKMJGODM, params int[] MINLDGGIKHJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PHKPGLBHIBM(out int? FBAKFDKGCHF);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool GLADNOJECKL(out LDLGFNGLDKL AGOGEMIJAHN);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HBPFJBKMAAH
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event BKIJLEOHLFO PBLGELKEHHI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event ADCAIDMGPGO ABHLIBIKMOF;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHGOCGCNKNJ();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PHKPGLBHIBM(out int? FBAKFDKGCHF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GLADNOJECKL(out LDLGFNGLDKL AGOGEMIJAHN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKIBKODACAI(LDLGFNGLDKL CHAECGMHLIF, PlatformNotificationHandlerContext JNNDIHFHMHC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AGLIOMJODMO
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event KFGHEGAIDDN JEKHCDLFPBN;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCPDDBLNKKO LGMFHILELDO();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCKGNGCPCCF ELFLOIPAECC();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string BJFIEJFACFM();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<LDLGFNGLDKL> HGOHDLCEFGG();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IIEJPGCBHAN();
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
