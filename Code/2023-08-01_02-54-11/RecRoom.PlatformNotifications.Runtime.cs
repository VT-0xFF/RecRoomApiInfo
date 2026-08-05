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
public class GHMNMJIHDIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int FCOHNFAGEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType FHOHNKIJHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public KBMBFMJBEGH IGGEHBMPPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool OHPENIHBCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string ILLCKGHELFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string LDFFLHIDIDG;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CKMEOLNLGAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CDPBIAHGEFN? KDOBNBMFHGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, LJAJHHFEMAM<bool>> FEGALFOCBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CDPBIAHGEFN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PBIIAFJIJJJ(bool FKDDMFACIBH, string MIPGDOLAABL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void HCKEGHFHIMG(bool FKDDMFACIBH, string MIPGDOLAABL, CDPBIAHGEFN ENGEDPAPAAK, string DMHDKAFNNAC, string IHEPAEAECLH);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GPGONBKKNGD();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void KEDBALHFJEF(GHMNMJIHDIG EKLAAHPMBHG, PlatformNotificationHandlerContext HBLIBBFCHOD);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void JFEOKHOMNAB(GHMNMJIHDIG EKLAAHPMBHG);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void BMKCNDKLCKI(GHMNMJIHDIG EKLAAHPMBHG, PlatformNotificationHandlerContext HBLIBBFCHOD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void BAGHILIHKNG(string AIGIACJJAOM, string HEGNANDEAJJ, string IBAFOGAJNHI, string GBLDHNLBKAO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void JGPGKOKPPKO(string AIGIACJJAOM, string HEGNANDEAJJ);
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
[LGDEAGBOMDC]
internal class FJOGAIKHKAA : PPCAMHHEHOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NDADECKBEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FJOGAIKHKAA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NDADECKBEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
		internal void COPADAPJKDJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x722FD70", Offset = "0x722ED70", VA = "0x18722FD70")]
		internal void ILDICMGJICO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IALMMCMEAHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public FJOGAIKHKAA <>4__this;

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
		public Action<KBMBFMJBEGH> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IALMMCMEAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x722F9E0", Offset = "0x722E9E0", VA = "0x18722F9E0")]
		internal void HDHAHKKGNKH(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class KGJJKMDJGOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public FJOGAIKHKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public CDPBIAHGEFN authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KGJJKMDJGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
		internal void ILKBHCFGKEP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x722FCB0", Offset = "0x722ECB0", VA = "0x18722FCB0")]
		internal void JHNJFEGAKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x722FBC0", Offset = "0x722EBC0", VA = "0x18722FBC0")]
		internal void AIBOOKNDKDC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> AAIINKJBGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HNHCAIIGENH CPDJEMPGDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private HICDGMHANPN JAMJCLOHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private DIBHFNHBHLJ JHFIBCKOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly JLFJGOJJKNL DGALGPPEGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly NGCLAGDODPD HIPPJIDAPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly IIOCADOPKFM JJNBDLFAGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly CKMEOLNLGAN IDJGFKJCEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool HIFMFJMCBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool HCGPJEIEMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> KLJMKNEOALL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string BFMDDCBIMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9629F0", Offset = "0x9619F0", VA = "0x1809629F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string DAKEDCFMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x722C0A0", Offset = "0x722B0A0", VA = "0x18722C0A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHMNMJIHDIG OCGNMDJGGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x722E020", Offset = "0x722D020", VA = "0x18722E020", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PBIIAFJIJJJ GCDMHEJNBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x722D720", Offset = "0x722C720", VA = "0x18722D720", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x722D200", Offset = "0x722C200", VA = "0x18722D200", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event HCKEGHFHIMG PIFMEGAPHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x722C1B0", Offset = "0x722B1B0", VA = "0x18722C1B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x722C430", Offset = "0x722B430", VA = "0x18722C430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event GPGONBKKNGD FBEBIKIEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x722DE40", Offset = "0x722CE40", VA = "0x18722DE40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x722C110", Offset = "0x722B110", VA = "0x18722C110", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event KEDBALHFJEF OHBBJIHPIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x722D680", Offset = "0x722C680", VA = "0x18722D680", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x722C390", Offset = "0x722B390", VA = "0x18722C390", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JFEOKHOMNAB KGFMKFNDNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x722D2A0", Offset = "0x722C2A0", VA = "0x18722D2A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x722CF70", Offset = "0x722BF70", VA = "0x18722CF70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BMKCNDKLCKI JPGMHCJMKID
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x722D990", Offset = "0x722C990", VA = "0x18722D990", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x722C250", Offset = "0x722B250", VA = "0x18722C250", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BAGHILIHKNG APEDFACCJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x722DA30", Offset = "0x722CA30", VA = "0x18722DA30", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x722D8F0", Offset = "0x722C8F0", VA = "0x18722D8F0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event JGPGKOKPPKO OAPAPBMLOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x722DEE0", Offset = "0x722CEE0", VA = "0x18722DEE0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x722DF80", Offset = "0x722CF80", VA = "0x18722DF80", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action INPDBIGDCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x722D140", Offset = "0x722C140", VA = "0x18722D140", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x722C2F0", Offset = "0x722B2F0", VA = "0x18722C2F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x722D340", Offset = "0x722C340", VA = "0x18722D340")]
	[OHDKPIIHCBL(BGEACDHIFOF.None)]
	private static void FHIGGLJNFIH(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x722ECE0", Offset = "0x722DCE0", VA = "0x18722ECE0")]
	[Preserve]
	internal FJOGAIKHKAA([KMDNJCFAMOJ(null)] JLFJGOJJKNL DGALGPPEGAK, [KMDNJCFAMOJ(null)] IIOCADOPKFM JJNBDLFAGAC, [KMDNJCFAMOJ(null)] NGCLAGDODPD HIPPJIDAPBC, [KMDNJCFAMOJ(null)] CKMEOLNLGAN AJCLOJJJGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x722DB20", Offset = "0x722CB20", VA = "0x18722DB20", Slot = "24")]
	public void JFGMJMMFADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x722C870", Offset = "0x722B870", VA = "0x18722C870", Slot = "25")]
	public void DCDBKDAICDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x722E6F0", Offset = "0x722D6F0", VA = "0x18722E6F0")]
	private void OLKPEIOIOHH(bool PKMEJENMBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x722E0A0", Offset = "0x722D0A0", VA = "0x18722E0A0")]
	private void OIFILAJLJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x722CB10", Offset = "0x722BB10", VA = "0x18722CB10")]
	private void DDLAANNDIAO(GHMNMJIHDIG EKLAAHPMBHG, PlatformNotificationHandlerContext HBLIBBFCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x722DE20", Offset = "0x722CE20", VA = "0x18722DE20")]
	private void JJCNKDIFAFA(GHMNMJIHDIG EKLAAHPMBHG, PlatformNotificationHandlerContext HBLIBBFCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x722CC50", Offset = "0x722BC50", VA = "0x18722CC50", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x722D010", Offset = "0x722C010", VA = "0x18722D010", Slot = "35")]
	public void EMMOCPIBIAI(HNHCAIIGENH KPPPNKNDMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x722D3B0", Offset = "0x722C3B0", VA = "0x18722D3B0", Slot = "36")]
	public void GAKPKICMBNL(HICDGMHANPN KPPPNKNDMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x722C5D0", Offset = "0x722B5D0", VA = "0x18722C5D0", Slot = "37")]
	public void DBNAENLLOEF(DIBHFNHBHLJ KPPPNKNDMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x722C4D0", Offset = "0x722B4D0", VA = "0x18722C4D0", Slot = "26")]
	public CDPBIAHGEFN CPDEEENJFIB()
	{
		return default(CDPBIAHGEFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x722DAD0", Offset = "0x722CAD0", VA = "0x18722DAD0", Slot = "27")]
	public string JAHECBGKCMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x722C8E0", Offset = "0x722B8E0", VA = "0x18722C8E0", Slot = "28")]
	public FHJJKILLDME DCJPGFLKJEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x722E2D0", Offset = "0x722D2D0", VA = "0x18722E2D0", Slot = "29")]
	public FHJJKILLDME OKFLBFCAIMH(int ELNCNPDOPGI, string AIGIACJJAOM, string JBBLOIOPEFN, string AGNAPIMADOH, string JAFNBDFBFND, DateTime OCGNPOMMCIP, Action<KBMBFMJBEGH> EPFEDNKEHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x722DD00", Offset = "0x722CD00", VA = "0x18722DD00", Slot = "30")]
	public FHJJKILLDME JFKHNFBGCHH(string AIGIACJJAOM, string JBBLOIOPEFN, params int[] PLJEAOFGOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x722D7C0", Offset = "0x722C7C0", VA = "0x18722D7C0", Slot = "31")]
	public bool HIKDHOJEMJE(out int? CAMPNMNOPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x722E7B0", Offset = "0x722D7B0", VA = "0x18722E7B0", Slot = "32")]
	public bool ONJBLIEEBPJ(out GHMNMJIHDIG KINDLEFNMCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x722E870", Offset = "0x722D870", VA = "0x18722E870")]
	private FHJJKILLDME PJDMMDBPEON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x722D880", Offset = "0x722C880", VA = "0x18722D880")]
	private void HMONHEOJCJD(GHMNMJIHDIG EKLAAHPMBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x722CEF0", Offset = "0x722BEF0", VA = "0x18722CEF0")]
	private void EBIOLEPNGIE(GHMNMJIHDIG EKLAAHPMBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x722C0F0", Offset = "0x722B0F0", VA = "0x18722C0F0")]
	private void ACBFEGMKCFJ(string AIGIACJJAOM, string HEGNANDEAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x722D1E0", Offset = "0x722C1E0", VA = "0x18722D1E0")]
	private void FCCHIDGGCPB(string AIGIACJJAOM, string HEGNANDEAJJ, string IBAFOGAJNHI, string GBLDHNLBKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xB46830", Offset = "0xB45830", VA = "0x180B46830")]
	private void MJBJJBALNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xFBDE40", Offset = "0xFBCE40", VA = "0x180FBDE40")]
	[CompilerGenerated]
	private void MHBCHFAEGDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DIBHFNHBHLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string IDFPBHGONBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string AJHJPCHMGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string COLCFIHLHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<GHMNMJIHDIG> OHBBJIHPIKK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FHJJKILLDME PNIDDEINKHA();

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FHJJKILLDME PJDMMDBPEON();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LKMAMDGGNIF(bool CDDDEANGACA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GHMNMJIHDIG MPHFPJNNKKP();
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
public interface HICDGMHANPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GHMNMJIHDIG> OHBBJIHPIKK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event BAGHILIHKNG OJNIEDAEEHA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event JGPGKOKPPKO GIOBECFCJBG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GHMNMJIHDIG MPHFPJNNKKP();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NFIOEMJEOLF(string JBBLOIOPEFN);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FHJJKILLDME OKFLBFCAIMH(int ELNCNPDOPGI, string AIGIACJJAOM, string JBBLOIOPEFN, string AGNAPIMADOH, string JAFNBDFBFND, DateTime OCGNPOMMCIP, [Optional] Action<KBMBFMJBEGH> EPFEDNKEHLA);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FHJJKILLDME JFKHNFBGCHH(string AIGIACJJAOM, string JBBLOIOPEFN, params int[] PLJEAOFGOOC);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LAJPABMMGAF(params int[] PLJEAOFGOOC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KPKNJGBPPCD
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float COOOGNLHDNN = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<GHMNMJIHDIG> OHBBJIHPIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private BAGHILIHKNG OJNIEDAEEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private JGPGKOKPPKO GIOBECFCJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GPGONBKKNGD FBEBIKIEKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IIOCADOPKFM JJNBDLFAGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly OGKJIMKMPEO IMKCGOMNNLN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IIOCADOPKFM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CKOMDEFCKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int GICIBGGNBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime? CDDPGDHKBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[LGDEAGBOMDC]
internal class GLFHHGCLKPL : JLFJGOJJKNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BMCNNKCFAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GLFHHGCLKPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GHMNMJIHDIG notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IIOCADOPKFM JJNBDLFAGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private GHMNMJIHDIG KINDLEFNMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? CIGCKJCEPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> FADLJKKCMOJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event KEDBALHFJEF OHBBJIHPIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x722F170", Offset = "0x722E170", VA = "0x18722F170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x722EFA0", Offset = "0x722DFA0", VA = "0x18722EFA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event BMKCNDKLCKI JPGMHCJMKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x722F240", Offset = "0x722E240", VA = "0x18722F240", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x722EF00", Offset = "0x722DF00", VA = "0x18722EF00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x722F100", Offset = "0x722E100", VA = "0x18722F100")]
	[OHDKPIIHCBL(BGEACDHIFOF.None)]
	private static void FHIGGLJNFIH(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x722F530", Offset = "0x722E530", VA = "0x18722F530")]
	[Preserve]
	internal GLFHHGCLKPL([KMDNJCFAMOJ(null)] IIOCADOPKFM JJNBDLFAGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x722F210", Offset = "0x722E210", VA = "0x18722F210", Slot = "9")]
	public bool HIKDHOJEMJE(out int? CAMPNMNOPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x722F500", Offset = "0x722E500", VA = "0x18722F500", Slot = "10")]
	public bool ONJBLIEEBPJ(out GHMNMJIHDIG CEKHDEFHCCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x722F2E0", Offset = "0x722E2E0", VA = "0x18722F2E0", Slot = "11")]
	public void IEFNDHCCNOE(GHMNMJIHDIG EKLAAHPMBHG, PlatformNotificationHandlerContext HBLIBBFCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x722F040", Offset = "0x722E040", VA = "0x18722F040", Slot = "8")]
	public void DCDBKDAICDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x722EDD0", Offset = "0x722DDD0", VA = "0x18722EDD0")]
	private void ALOOPJDPMLG(GHMNMJIHDIG EKLAAHPMBHG, PlatformNotificationHandlerContext HBLIBBFCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x722F430", Offset = "0x722E430", VA = "0x18722F430")]
	private void OANKEGFLDPF(GHMNMJIHDIG NILPEFLMPPK, PlatformNotificationHandlerContext HBLIBBFCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x722F0E0", Offset = "0x722E0E0", VA = "0x18722F0E0")]
	[CompilerGenerated]
	private void EGABCCGIFLF(ref BMCNNKCFAHO P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KBMBFMJBEGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int? CAMPNMNOPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DateTime HOKADPEBGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string OLAHOGPEOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string BGIPLEDDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PlatformNotificationType GLMNLAAMFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9CC1C0", Offset = "0x9CB1C0", VA = "0x1809CC1C0")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string AIGIACJJAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string EOFDCDJIKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string JBBLOIOPEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string LPECGNEGJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x947AC0", Offset = "0x946AC0", VA = "0x180947AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string FELNBOLOGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x92FA50", Offset = "0x92EA50", VA = "0x18092FA50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? CKLAGEMKNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x94AD20", Offset = "0x949D20", VA = "0x18094AD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int? NDDMMIPKNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x94AC50", Offset = "0x949C50", VA = "0x18094AC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public long? GJAHLFBOLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xADCD50", Offset = "0xADBD50", VA = "0x180ADCD50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public long? IIKHCGCAMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xF9FD70", Offset = "0xF9ED70", VA = "0x180F9FD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1B8D930", Offset = "0x1B8C930", VA = "0x181B8D930")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PPCAMHHEHOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string DAKEDCFMLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GHMNMJIHDIG OCGNMDJGGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event PBIIAFJIJJJ GCDMHEJNBFD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event HCKEGHFHIMG PIFMEGAPHCK;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event GPGONBKKNGD FBEBIKIEKJN;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event KEDBALHFJEF OHBBJIHPIKK;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JFEOKHOMNAB KGFMKFNDNGD;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event BAGHILIHKNG APEDFACCJKI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event JGPGKOKPPKO OAPAPBMLOPI;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event BMKCNDKLCKI JPGMHCJMKID;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action INPDBIGDCAE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JFGMJMMFADK();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DCDBKDAICDD();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	CDPBIAHGEFN CPDEEENJFIB();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string JAHECBGKCMN();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FHJJKILLDME DCJPGFLKJEP();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FHJJKILLDME OKFLBFCAIMH(int ELNCNPDOPGI, string AIGIACJJAOM, string JBBLOIOPEFN, string AGNAPIMADOH, string JAFNBDFBFND, DateTime OCGNPOMMCIP, Action<KBMBFMJBEGH> EPFEDNKEHLA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	FHJJKILLDME JFKHNFBGCHH(string AIGIACJJAOM, string JBBLOIOPEFN, params int[] PLJEAOFGOOC);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HIKDHOJEMJE(out int? CAMPNMNOPAE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool ONJBLIEEBPJ(out GHMNMJIHDIG KINDLEFNMCG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JLFJGOJJKNL
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event KEDBALHFJEF OHBBJIHPIKK;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event BMKCNDKLCKI JPGMHCJMKID;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCDBKDAICDD();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HIKDHOJEMJE(out int? CAMPNMNOPAE);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ONJBLIEEBPJ(out GHMNMJIHDIG KINDLEFNMCG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IEFNDHCCNOE(GHMNMJIHDIG EKLAAHPMBHG, PlatformNotificationHandlerContext HBLIBBFCHOD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface HNHCAIIGENH
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event GPGONBKKNGD FBEBIKIEKJN;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CDPBIAHGEFN CPDEEENJFIB();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FHJJKILLDME DCJPGFLKJEP();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string JAHECBGKCMN();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<GHMNMJIHDIG> LGJPFOJEDIE();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AGEDEIBOEPL();
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
