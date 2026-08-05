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
public class GBPHOEFGICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int MAGNOMDANLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType KEFHMMCGAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public BKEHDEEGIKJ MLBCINNEHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool LDFMEJKLJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string AFJDIEPEKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string FCBANLJJLFH;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DGDEHEHCFCF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FEPINEHIEGH? FIHHPOKDGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, global::CBFHNKNAJIN<bool>> JCNIBACICLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FEPINEHIEGH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void COGMJIJLCOL(bool BKPFMPLIAJI, string NBBBCCFKKBO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void IMCJHELIMDC(bool BKPFMPLIAJI, string NBBBCCFKKBO, FEPINEHIEGH FEONEIONAPL, string IJNLJGNNJFA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PEJFIGFFEIB();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FHCOEPOMNLE(GBPHOEFGICP EJGEJONJPIP, PlatformNotificationHandlerContext GEKPLLKAIKG);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void AMPGGKBGANL(GBPHOEFGICP EJGEJONJPIP);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void DJIBKDEOLLL(GBPHOEFGICP EJGEJONJPIP, PlatformNotificationHandlerContext GEKPLLKAIKG);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void FHGKOJJOPMF(string LFNONJNNDHO, string NEGBJFNKPNE, string FBOMIGCLEHH, string GIGBPOHGDCL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void KFGFMLPJLNK(string LFNONJNNDHO, string NEGBJFNKPNE);
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
[HNGHGBCLJCP]
internal class FGAIMAFPADI : LDONGPPBMPJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BNNOFOMKGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FGAIMAFPADI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BNNOFOMKGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		internal void LHDPGDHFEIK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x16A48F0", Offset = "0x16A3CF0", VA = "0x1816A48F0")]
		internal void PNPMIMIDNIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HCDCHFFEPMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public FGAIMAFPADI <>4__this;

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
		public Action<BKEHDEEGIKJ> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HCDCHFFEPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x16A7B30", Offset = "0x16A6F30", VA = "0x1816A7B30")]
		internal void DCOIDEBHEFC(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MBKHKGIJNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public FGAIMAFPADI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public FEPINEHIEGH authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MBKHKGIJNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		internal void DBJAHGBHCMD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x16A8040", Offset = "0x16A7440", VA = "0x1816A8040")]
		internal void BCPMMEFPNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x16A8100", Offset = "0x16A7500", VA = "0x1816A8100")]
		internal void DBFFOABIDBO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> NFIHMLCNHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NHNFOCDDJKC OGJICJBAHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private OHBHFDEADPO KHJCOEHCCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private GJFFJNLODLI DPJJJFCADLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly COMBIHHNGHB OKFMDECGLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CJHJPPDHOCF CBKJDAMHNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly OPFMLCNFFOJ EHAEPBGECBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly DGDEHEHCFCF MCKIAFDAFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool GOINCLDKBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool OOIKBEGEFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> ABFEBMMOIKA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string DHFOEAAPDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89EC90", Offset = "0x89E090", VA = "0x18089EC90", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89EBD0", Offset = "0x89DFD0", VA = "0x18089EBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string MADGMOEHKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x16A5ED0", Offset = "0x16A52D0", VA = "0x1816A5ED0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event COGMJIJLCOL OOIABPIAGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x16A5440", Offset = "0x16A4840", VA = "0x1816A5440", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x16A7090", Offset = "0x16A6490", VA = "0x1816A7090", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event IMCJHELIMDC DDPAFKAEIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x16A7130", Offset = "0x16A6530", VA = "0x1816A7130", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x16A7310", Offset = "0x16A6710", VA = "0x1816A7310", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PEJFIGFFEIB NLFKDLPCAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x16A71D0", Offset = "0x16A65D0", VA = "0x1816A71D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x16A5690", Offset = "0x16A4A90", VA = "0x1816A5690", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FHCOEPOMNLE LJPMDMPEHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x16A5E30", Offset = "0x16A5230", VA = "0x1816A5E30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x16A6FF0", Offset = "0x16A63F0", VA = "0x1816A6FF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event AMPGGKBGANL LDNBAKGONEB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x16A66F0", Offset = "0x16A5AF0", VA = "0x1816A66F0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x16A6200", Offset = "0x16A5600", VA = "0x1816A6200", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DJIBKDEOLLL FJJDJGKJOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x16A6790", Offset = "0x16A5B90", VA = "0x1816A6790", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x16A6140", Offset = "0x16A5540", VA = "0x1816A6140", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event FHGKOJJOPMF AGJEDEGEPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x16A54E0", Offset = "0x16A48E0", VA = "0x1816A54E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x16A6830", Offset = "0x16A5C30", VA = "0x1816A6830", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event KFGFMLPJLNK FALMAADGCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x16A5580", Offset = "0x16A4980", VA = "0x1816A5580", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x16A7270", Offset = "0x16A6670", VA = "0x1816A7270", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action GGNEPJDPHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x16A62A0", Offset = "0x16A56A0", VA = "0x1816A62A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x16A6F50", Offset = "0x16A6350", VA = "0x1816A6F50", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x16A7940", Offset = "0x16A6D40", VA = "0x1816A7940")]
	[HECCOHDEPAK(JCKMLGOOEHJ.None)]
	private static void PKIDGDOGENM(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x16A79B0", Offset = "0x16A6DB0", VA = "0x1816A79B0")]
	[Preserve]
	internal FGAIMAFPADI([KFMNGACPMHN(null)] COMBIHHNGHB OKFMDECGLDD, [KFMNGACPMHN(null)] OPFMLCNFFOJ EHAEPBGECBM, [KFMNGACPMHN(null)] CJHJPPDHOCF CBKJDAMHNML, [KFMNGACPMHN(null)] DGDEHEHCFCF HIHLCMINDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x16A7580", Offset = "0x16A6980", VA = "0x1816A7580", Slot = "23")]
	public void OAGJEKOOFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x16A77A0", Offset = "0x16A6BA0", VA = "0x1816A77A0", Slot = "24")]
	public void OAGPAOPIGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x16A65E0", Offset = "0x16A59E0", VA = "0x1816A65E0")]
	private void HDIHCLKPGMB(bool KJBECPCFDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x16A5F20", Offset = "0x16A5320", VA = "0x1816A5F20")]
	private void FKIKNADLNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x16A5860", Offset = "0x16A4C60", VA = "0x1816A5860")]
	private void DDNKLCBOIMD(GBPHOEFGICP EJGEJONJPIP, PlatformNotificationHandlerContext GEKPLLKAIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x16A5150", Offset = "0x16A4550", VA = "0x1816A5150")]
	private void AIMLOPJGAOJ(GBPHOEFGICP EJGEJONJPIP, PlatformNotificationHandlerContext GEKPLLKAIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x16A5B10", Offset = "0x16A4F10", VA = "0x1816A5B10", Slot = "32")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x16A5730", Offset = "0x16A4B30", VA = "0x1816A5730", Slot = "34")]
	public void CIFDIHMLPID(NHNFOCDDJKC PKLMJOFPOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x16A5170", Offset = "0x16A4570", VA = "0x1816A5170", Slot = "35")]
	public void AKDPMKHGDNC(OHBHFDEADPO PKLMJOFPOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x16A6340", Offset = "0x16A5740", VA = "0x1816A6340", Slot = "36")]
	public void GMLNLEBCILI(GJFFJNLODLI PKLMJOFPOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x16A7830", Offset = "0x16A6C30", VA = "0x1816A7830", Slot = "25")]
	public FEPINEHIEGH OKNPHLCBOEL()
	{
		return default(FEPINEHIEGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x16A7530", Offset = "0x16A6930", VA = "0x1816A7530", Slot = "26")]
	public string NLDGCOECOGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x16A68D0", Offset = "0x16A5CD0", VA = "0x1816A68D0", Slot = "27")]
	public FKADHPEOOEO JCKFPACLLEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x16A4D20", Offset = "0x16A4120", VA = "0x1816A4D20", Slot = "28")]
	public FKADHPEOOEO AIGCAMMJPMI(int KDNGDJGKPMI, string LFNONJNNDHO, string POHNNKFMKBE, string CHPOCOLDNGJ, string GCNLKIDIIKN, DateTime GPJANJPLPNB, Action<BKEHDEEGIKJ> OOIFIHEAAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16A59D0", Offset = "0x16A4DD0", VA = "0x1816A59D0", Slot = "29")]
	public FKADHPEOOEO DHIAFGBGKFH(string LFNONJNNDHO, string POHNNKFMKBE, params int[] DOKDNIDAHPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16A73B0", Offset = "0x16A67B0", VA = "0x1816A73B0", Slot = "30")]
	public bool NJHPBEPBOFB(out int? FLKHDEBHMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16A7470", Offset = "0x16A6870", VA = "0x1816A7470", Slot = "31")]
	public bool NJPOFDLFNBP(out GBPHOEFGICP ILIJFPLNBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x16A6B00", Offset = "0x16A5F00", VA = "0x1816A6B00")]
	private FKADHPEOOEO JIEEBPGBCCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x16A5620", Offset = "0x16A4A20", VA = "0x1816A5620")]
	private void BILKPOCLEDM(GBPHOEFGICP EJGEJONJPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x16A5DB0", Offset = "0x16A51B0", VA = "0x1816A5DB0")]
	private void EBIOEJGCDMO(GBPHOEFGICP EJGEJONJPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x16A61E0", Offset = "0x16A55E0", VA = "0x1816A61E0")]
	private void FNILPFAGBNH(string LFNONJNNDHO, string NEGBJFNKPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x16A5AF0", Offset = "0x16A4EF0", VA = "0x1816A5AF0")]
	private void DKIIAAKOKKO(string LFNONJNNDHO, string NEGBJFNKPNE, string FBOMIGCLEHH, string GIGBPOHGDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x16A59B0", Offset = "0x16A4DB0", VA = "0x1816A59B0")]
	private void DFPBMGPLNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x16A7810", Offset = "0x16A6C10", VA = "0x1816A7810")]
	[CompilerGenerated]
	private void OCPMHEENIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GJFFJNLODLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string CNGMNHBJOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string KFGCPOHJKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<GBPHOEFGICP> LJPMDMPEHOI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FKADHPEOOEO FLKHIEAKEIH();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FKADHPEOOEO JIEEBPGBCCD();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GBPHOEFGICP PDCPGIEBDFK();
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
public interface OHBHFDEADPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GBPHOEFGICP> LJPMDMPEHOI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event FHGKOJJOPMF IMOKODEFCFM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event KFGFMLPJLNK JDPJMIJMIIO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GBPHOEFGICP PDCPGIEBDFK();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DGBFMMJHKLF(string POHNNKFMKBE);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FKADHPEOOEO AIGCAMMJPMI(int KDNGDJGKPMI, string LFNONJNNDHO, string POHNNKFMKBE, string CHPOCOLDNGJ, string GCNLKIDIIKN, DateTime GPJANJPLPNB, [Optional] Action<BKEHDEEGIKJ> OOIFIHEAAHK);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FKADHPEOOEO DHIAFGBGKFH(string LFNONJNNDHO, string POHNNKFMKBE, params int[] DOKDNIDAHPP);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ICKHCDCGMHC(params int[] DOKDNIDAHPP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PGMKAGHMHII
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float BMAHKAHIKKO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<GBPHOEFGICP> LJPMDMPEHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private FHGKOJJOPMF IMOKODEFCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private KFGFMLPJLNK JDPJMIJMIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PEJFIGFFEIB NLFKDLPCAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OPFMLCNFFOJ EHAEPBGECBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly DKBFAHPNMLB PKBACCDFFAF;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OPFMLCNFFOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PNEMJABIHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int KHCLKDMNFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DateTime? OJDCIKLNFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HNGHGBCLJCP]
internal class MILEEOEKBPA : COMBIHHNGHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LHDDNKGKPPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public MILEEOEKBPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GBPHOEFGICP notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OPFMLCNFFOJ EHAEPBGECBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private GBPHOEFGICP ILIJFPLNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? HBEFIOMHDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> CMCJCIDOHGD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event FHCOEPOMNLE LJPMDMPEHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x16A82A0", Offset = "0x16A76A0", VA = "0x1816A82A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x16A84A0", Offset = "0x16A78A0", VA = "0x1816A84A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event DJIBKDEOLLL FJJDJGKJOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x16A8400", Offset = "0x16A7800", VA = "0x1816A8400", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x16A8360", Offset = "0x16A7760", VA = "0x1816A8360", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x16A8830", Offset = "0x16A7C30", VA = "0x1816A8830")]
	[HECCOHDEPAK(JCKMLGOOEHJ.None)]
	private static void PKIDGDOGENM(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x16A88A0", Offset = "0x16A7CA0", VA = "0x1816A88A0")]
	[Preserve]
	internal MILEEOEKBPA([KFMNGACPMHN(null)] OPFMLCNFFOJ EHAEPBGECBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x16A8660", Offset = "0x16A7A60", VA = "0x1816A8660", Slot = "9")]
	public bool NJHPBEPBOFB(out int? FLKHDEBHMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x16A8690", Offset = "0x16A7A90", VA = "0x1816A8690", Slot = "10")]
	public bool NJPOFDLFNBP(out GBPHOEFGICP GIKIHOBBNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x16A8150", Offset = "0x16A7550", VA = "0x1816A8150", Slot = "11")]
	public void BAIMJMEOCEJ(GBPHOEFGICP EJGEJONJPIP, PlatformNotificationHandlerContext GEKPLLKAIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x16A86C0", Offset = "0x16A7AC0", VA = "0x1816A86C0", Slot = "8")]
	public void OAGPAOPIGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x16A8540", Offset = "0x16A7940", VA = "0x1816A8540")]
	private void MMFFCHDAPIM(GBPHOEFGICP EJGEJONJPIP, PlatformNotificationHandlerContext GEKPLLKAIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x16A8760", Offset = "0x16A7B60", VA = "0x1816A8760")]
	private void PJIMGJMCNFP(GBPHOEFGICP FCKGDDHNDCL, PlatformNotificationHandlerContext GEKPLLKAIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x16A8340", Offset = "0x16A7740", VA = "0x1816A8340")]
	[CompilerGenerated]
	private void FKKMOECIDCO(ref LHDDNKGKPPF P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BKEHDEEGIKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int? FLKHDEBHMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DateTime DOGHCNMGMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string MHFIEGCAEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string OIMFBCGGEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PlatformNotificationType IHCGFGIBAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x854AC0", Offset = "0x853EC0", VA = "0x180854AC0")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string LFNONJNNDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string POHNNKFMKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F1740", Offset = "0x7F0B40", VA = "0x1807F1740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string DFIMGODAHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x809410", Offset = "0x808810", VA = "0x180809410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NHJOKINCNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F45E0", Offset = "0x7F39E0", VA = "0x1807F45E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public long? DECEJJGGNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x16A48C0", Offset = "0x16A3CC0", VA = "0x1816A48C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int? HDLNGLBHLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89ED20", Offset = "0x89E120", VA = "0x18089ED20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public long? ODOGOKINCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xB5B350", Offset = "0xB5A750", VA = "0x180B5B350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? MEFEJANAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x16A48D0", Offset = "0x16A3CD0", VA = "0x1816A48D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x16A48E0", Offset = "0x16A3CE0", VA = "0x1816A48E0")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LDONGPPBMPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string MADGMOEHKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event COGMJIJLCOL OOIABPIAGGK;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event IMCJHELIMDC DDPAFKAEIJK;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event PEJFIGFFEIB NLFKDLPCAMH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event FHCOEPOMNLE LJPMDMPEHOI;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event AMPGGKBGANL LDNBAKGONEB;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event FHGKOJJOPMF AGJEDEGEPKH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event KFGFMLPJLNK FALMAADGCGD;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event DJIBKDEOLLL FJJDJGKJOCO;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action GGNEPJDPHJG;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OAGJEKOOFKN();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OAGPAOPIGCO();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	FEPINEHIEGH OKNPHLCBOEL();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string NLDGCOECOGH();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	FKADHPEOOEO JCKFPACLLEG();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FKADHPEOOEO AIGCAMMJPMI(int KDNGDJGKPMI, string LFNONJNNDHO, string POHNNKFMKBE, string CHPOCOLDNGJ, string GCNLKIDIIKN, DateTime GPJANJPLPNB, Action<BKEHDEEGIKJ> OOIFIHEAAHK);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	FKADHPEOOEO DHIAFGBGKFH(string LFNONJNNDHO, string POHNNKFMKBE, params int[] DOKDNIDAHPP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool NJHPBEPBOFB(out int? FLKHDEBHMHD);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NJPOFDLFNBP(out GBPHOEFGICP ILIJFPLNBAL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface COMBIHHNGHB
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event FHCOEPOMNLE LJPMDMPEHOI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event DJIBKDEOLLL FJJDJGKJOCO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OAGPAOPIGCO();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NJHPBEPBOFB(out int? FLKHDEBHMHD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NJPOFDLFNBP(out GBPHOEFGICP ILIJFPLNBAL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BAIMJMEOCEJ(GBPHOEFGICP EJGEJONJPIP, PlatformNotificationHandlerContext GEKPLLKAIKG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NHNFOCDDJKC
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event PEJFIGFFEIB NLFKDLPCAMH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FEPINEHIEGH OKNPHLCBOEL();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKADHPEOOEO JCKFPACLLEG();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string NLDGCOECOGH();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<GBPHOEFGICP> JLMOEHHPDGF();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNPLPAOBHJD();
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
