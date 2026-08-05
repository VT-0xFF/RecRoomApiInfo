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
public class KPEBFJDKENJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int FFLEAJNGBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType MKAJEKLIICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public AEKMOMPGFDB HOIDFIPJAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool DHKHOEIJFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string PKDGGDNFHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string CKEBGKGPMNF;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IKEFNCAINEG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EKKJAALLMMI? LHNPDPHAFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, AHPDIJDJLKD<bool>> ILEAJCAIPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EKKJAALLMMI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void NNNLLKLHCCN(bool FNODIEFDFAE, string CNADKOFBHMF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void ILMHDNMBLDI(bool FNODIEFDFAE, string CNADKOFBHMF, EKKJAALLMMI IOGOAOBDGJB, string GKNJCIECGND);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NCCBLKNPAAF();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NBDMFAJPGLA(KPEBFJDKENJ ENINOFJGBNJ, PlatformNotificationHandlerContext CNBGAPJABKP);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void CMGJIOFDIPI(KPEBFJDKENJ ENINOFJGBNJ);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void PIGMFGHALGD(KPEBFJDKENJ ENINOFJGBNJ, PlatformNotificationHandlerContext CNBGAPJABKP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void AJDHECCBPKO(string MHBKLHEODDA, string JHLGEFLPBCD, string EPLJFJOFJJF, string DJCHLJDFMJJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GPPKCAGFAHK(string MHBKLHEODDA, string JHLGEFLPBCD);
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
[MMBMKHHBAJO]
internal class INHDPOPNOGM : FLGEAGKKAMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BDOHEEEFDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public INHDPOPNOGM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BDOHEEEFDEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
		internal void APKDJNJLLNL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x18DF0E0", Offset = "0x18DDEE0", VA = "0x1818DF0E0")]
		internal void DCMJOKKCPIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class KLEIBJEMBOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public INHDPOPNOGM <>4__this;

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
		public Action<AEKMOMPGFDB> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KLEIBJEMBOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x18E2B60", Offset = "0x18E1960", VA = "0x1818E2B60")]
		internal void ALLGDAOCLBD(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FNOENLBCDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public INHDPOPNOGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public EKKJAALLMMI authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FNOENLBCDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
		internal void NBKCHEBLINL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x18DF170", Offset = "0x18DDF70", VA = "0x1818DF170")]
		internal void FOOJBKEIKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x18DF120", Offset = "0x18DDF20", VA = "0x1818DF120")]
		internal void DFENEHENIED()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> MGNPPHLKJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NEDMGGAEDCD LEOGFLLFNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private BIPKAKNFDPB DNNJHINDIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private KCHOCIHNFNK PEANJAJAIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly EAPLKHNILNL GPHMDGMDEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly COLGJFNKLEG CHHMNADFGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HNGLGANCEPJ LAKEDDLCDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IKEFNCAINEG JEGBNAMIOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool DBAHIAEGKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool KIOFHPPANAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> HMOLCPIMJLK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string DCFGMLMIEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x998D70", Offset = "0x997B70", VA = "0x180998D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string ABGDJMJKLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x18E1C40", Offset = "0x18E0A40", VA = "0x1818E1C40", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NNNLLKLHCCN CECJLDHPJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x18DF660", Offset = "0x18DE460", VA = "0x1818DF660", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x18E10B0", Offset = "0x18DFEB0", VA = "0x1818E10B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ILMHDNMBLDI FDFBBBBKKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x18DF860", Offset = "0x18DE660", VA = "0x1818DF860", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x18E1010", Offset = "0x18DFE10", VA = "0x1818E1010", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NCCBLKNPAAF PCIBMOCLAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x18E20A0", Offset = "0x18E0EA0", VA = "0x1818E20A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x18E0390", Offset = "0x18DF190", VA = "0x1818E0390", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NBDMFAJPGLA HEAKCOLMFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x18E2140", Offset = "0x18E0F40", VA = "0x1818E2140", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x18E1170", Offset = "0x18DFF70", VA = "0x1818E1170", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event CMGJIOFDIPI ODPBMIMGJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x18E21E0", Offset = "0x18E0FE0", VA = "0x1818E21E0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x18DF720", Offset = "0x18DE520", VA = "0x1818DF720", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PIGMFGHALGD CDOFHNJGFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18DFE00", Offset = "0x18DEC00", VA = "0x1818DFE00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x18E0430", Offset = "0x18DF230", VA = "0x1818E0430", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event AJDHECCBPKO CPMOGFCGBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x18E0D50", Offset = "0x18DFB50", VA = "0x1818E0D50", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x18E1F60", Offset = "0x18E0D60", VA = "0x1818E1F60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GPPKCAGFAHK AFGEHLKCOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x18E2000", Offset = "0x18E0E00", VA = "0x1818E2000", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x18DFCF0", Offset = "0x18DEAF0", VA = "0x1818DFCF0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action MEMPKMAMNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x18DF7C0", Offset = "0x18DE5C0", VA = "0x1818DF7C0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x18E1B80", Offset = "0x18E0980", VA = "0x1818E1B80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x18DF5F0", Offset = "0x18DE3F0", VA = "0x1818DF5F0")]
	[GIEEOCCBBIJ(PFHGMCKNAFN.None)]
	private static void BALEBCFJGHH(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x18E2280", Offset = "0x18E1080", VA = "0x1818E2280")]
	[Preserve]
	internal INHDPOPNOGM([DNPFPOCMFCA(null)] EAPLKHNILNL GPHMDGMDEMO, [DNPFPOCMFCA(null)] HNGLGANCEPJ LAKEDDLCDCI, [DNPFPOCMFCA(null)] COLGJFNKLEG CHHMNADFGCK, [DNPFPOCMFCA(null)] IKEFNCAINEG PJMJNHMCCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x18E0DF0", Offset = "0x18DFBF0", VA = "0x1818E0DF0", Slot = "23")]
	public void HFKECJNCAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x18E1210", Offset = "0x18E0010", VA = "0x1818E1210", Slot = "24")]
	public void JIGFKIAHCNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x18E1880", Offset = "0x18E0680", VA = "0x1818E1880")]
	private void LIFLINHIIMD(bool NCNPICDONAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x18E0B30", Offset = "0x18DF930", VA = "0x1818E0B30")]
	private void GPBOOOBDGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x18DF900", Offset = "0x18DE700", VA = "0x1818DF900")]
	private void DDDGIDLEHEI(KPEBFJDKENJ ENINOFJGBNJ, PlatformNotificationHandlerContext CNBGAPJABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x18DF700", Offset = "0x18DE500", VA = "0x1818DF700")]
	private void BEPNALICFGD(KPEBFJDKENJ ENINOFJGBNJ, PlatformNotificationHandlerContext CNBGAPJABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x18DFA50", Offset = "0x18DE850", VA = "0x1818DFA50", Slot = "32")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x18E1A50", Offset = "0x18E0850", VA = "0x1818E1A50", Slot = "34")]
	public void NCJDDGEHEJE(NEDMGGAEDCD LNBJPHPCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x18E1C90", Offset = "0x18E0A90", VA = "0x1818E1C90", Slot = "35")]
	public void NIHLKMCJFHI(BIPKAKNFDPB LNBJPHPCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x18DFEC0", Offset = "0x18DECC0", VA = "0x1818DFEC0", Slot = "36")]
	public void FCMLPECFGPO(KCHOCIHNFNK LNBJPHPCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x18E0900", Offset = "0x18DF700", VA = "0x1818E0900", Slot = "25")]
	public EKKJAALLMMI GJOIBENOBCD()
	{
		return default(EKKJAALLMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x18E1830", Offset = "0x18E0630", VA = "0x1818E1830", Slot = "26")]
	public string LFEGNLNJJKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x18E0160", Offset = "0x18DEF60", VA = "0x1818E0160", Slot = "27")]
	public NONMCJIBNII FDGJOECCHJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x18E04D0", Offset = "0x18DF2D0", VA = "0x1818E04D0", Slot = "28")]
	public NONMCJIBNII GCFAKMFNNJL(int IIHDMHKNBFH, string MHBKLHEODDA, string KCFMNBKCILK, string MEGPOFCBHAK, string CKHAGCIIDJI, DateTime BHLOJCNDEDO, Action<AEKMOMPGFDB> PMIKDLPAEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x18E0A10", Offset = "0x18DF810", VA = "0x1818E0A10", Slot = "29")]
	public NONMCJIBNII GOIICKCOBCD(string MHBKLHEODDA, string KCFMNBKCILK, params int[] COKOABJPBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x18E1990", Offset = "0x18E0790", VA = "0x1818E1990", Slot = "30")]
	public bool MNLOHPBIDKM(out int? DNPNKPENJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x18E1280", Offset = "0x18E0080", VA = "0x1818E1280", Slot = "31")]
	public bool JNILGCMAHCK(out KPEBFJDKENJ HDKGNGKHBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x18E1340", Offset = "0x18E0140", VA = "0x1818E1340")]
	private NONMCJIBNII KBHNCJDMOCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x18DFD90", Offset = "0x18DEB90", VA = "0x1818DFD90")]
	private void EBIGMLKIAAE(KPEBFJDKENJ ENINOFJGBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x18E17B0", Offset = "0x18E05B0", VA = "0x1818E17B0")]
	private void KGNPEEBPIKP(KPEBFJDKENJ ENINOFJGBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x18E1C20", Offset = "0x18E0A20", VA = "0x1818E1C20")]
	private void NEEHDDIHOHF(string MHBKLHEODDA, string JHLGEFLPBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x18E1790", Offset = "0x18E0590", VA = "0x1818E1790")]
	private void KDLBOHDMIAA(string MHBKLHEODDA, string JHLGEFLPBCD, string EPLJFJOFJJF, string DJCHLJDFMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x18E1150", Offset = "0x18DFF50", VA = "0x1818E1150")]
	private void IMHAEDIIHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x18DFEA0", Offset = "0x18DECA0", VA = "0x1818DFEA0")]
	[CompilerGenerated]
	private void EJLPODNJFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KCHOCIHNFNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string PCFBKMJAIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MOOJKCDDJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<KPEBFJDKENJ> HEAKCOLMFIJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NONMCJIBNII NKLMIDAHOBN();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NONMCJIBNII KBHNCJDMOCK();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KPEBFJDKENJ DBDPOLDPOMP();
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
public interface BIPKAKNFDPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KPEBFJDKENJ> HEAKCOLMFIJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event AJDHECCBPKO OEKFKMDJFEJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event GPPKCAGFAHK PKDPDNDAOKL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KPEBFJDKENJ DBDPOLDPOMP();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BODMAGFFKIN(string KCFMNBKCILK);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NONMCJIBNII GCFAKMFNNJL(int IIHDMHKNBFH, string MHBKLHEODDA, string KCFMNBKCILK, string MEGPOFCBHAK, string CKHAGCIIDJI, DateTime BHLOJCNDEDO, [Optional] Action<AEKMOMPGFDB> PMIKDLPAEDI);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NONMCJIBNII GOIICKCOBCD(string MHBKLHEODDA, string KCFMNBKCILK, params int[] COKOABJPBFB);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GGBOGIAKLKL(params int[] COKOABJPBFB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EEOEOBKKILP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float LLEICPPNPEK = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<KPEBFJDKENJ> HEAKCOLMFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private AJDHECCBPKO OEKFKMDJFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GPPKCAGFAHK PKDPDNDAOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NCCBLKNPAAF PCIBMOCLAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HNGLGANCEPJ LAKEDDLCDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly NFCNLBHHELA ALIOLHEBBMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HNGLGANCEPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool DBPJIOCGBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int NDFIJBEFEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DateTime? MCNDGDHIKML
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MMBMKHHBAJO]
internal class KEGJKGPPLJH : EAPLKHNILNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NHBPPGGPDMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public KEGJKGPPLJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KPEBFJDKENJ notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HNGLGANCEPJ LAKEDDLCDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private KPEBFJDKENJ HDKGNGKHBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? DAPICIKBNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> BKKIEAAEHPJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event NBDMFAJPGLA HEAKCOLMFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x18E2A20", Offset = "0x18E1820", VA = "0x1818E2A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x18E2860", Offset = "0x18E1660", VA = "0x1818E2860", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event PIGMFGHALGD CDOFHNJGFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x18E24B0", Offset = "0x18E12B0", VA = "0x1818E24B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x18E2550", Offset = "0x18E1350", VA = "0x1818E2550", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x18E2370", Offset = "0x18E1170", VA = "0x1818E2370")]
	[GIEEOCCBBIJ(PFHGMCKNAFN.None)]
	private static void BALEBCFJGHH(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x18E2AC0", Offset = "0x18E18C0", VA = "0x1818E2AC0")]
	[Preserve]
	internal KEGJKGPPLJH([DNPFPOCMFCA(null)] HNGLGANCEPJ LAKEDDLCDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x18E29F0", Offset = "0x18E17F0", VA = "0x1818E29F0", Slot = "9")]
	public bool MNLOHPBIDKM(out int? DNPNKPENJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x18E29A0", Offset = "0x18E17A0", VA = "0x1818E29A0", Slot = "10")]
	public bool JNILGCMAHCK(out KPEBFJDKENJ LMEFPDEEFJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x18E25F0", Offset = "0x18E13F0", VA = "0x1818E25F0", Slot = "11")]
	public void GMEOKGGBMCG(KPEBFJDKENJ ENINOFJGBNJ, PlatformNotificationHandlerContext CNBGAPJABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x18E2900", Offset = "0x18E1700", VA = "0x1818E2900", Slot = "8")]
	public void JIGFKIAHCNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x18E2740", Offset = "0x18E1540", VA = "0x1818E2740")]
	private void IFMHJIHKBKG(KPEBFJDKENJ ENINOFJGBNJ, PlatformNotificationHandlerContext CNBGAPJABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x18E23E0", Offset = "0x18E11E0", VA = "0x1818E23E0")]
	private void CPOBBEDOCPK(KPEBFJDKENJ IHNIDMGLJIC, PlatformNotificationHandlerContext CNBGAPJABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x18E29D0", Offset = "0x18E17D0", VA = "0x1818E29D0")]
	[CompilerGenerated]
	private void MENODNLBDCI(ref NHBPPGGPDMK P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AEKMOMPGFDB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int? DNPNKPENJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DateTime CMJMCGBJEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string OFBFNJHNAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string GEMPHABJHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PlatformNotificationType HFJAKEMNMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x91A270", Offset = "0x919070", VA = "0x18091A270")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string MHBKLHEODDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KCFMNBKCILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string DBBKDIEPNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string DIFFCDDPLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public long? PKNBIJOCMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x105DFC0", Offset = "0x105CDC0", VA = "0x18105DFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int? AKGBNHFCLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public long? NOBPCOEJMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCDEEE0", Offset = "0xCDDCE0", VA = "0x180CDEEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? OFOPNAOLFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x18DEC10", Offset = "0x18DDA10", VA = "0x1818DEC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x18DEC00", Offset = "0x18DDA00", VA = "0x1818DEC00")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FLGEAGKKAMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string ABGDJMJKLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NNNLLKLHCCN CECJLDHPJLD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event ILMHDNMBLDI FDFBBBBKKHE;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event NCCBLKNPAAF PCIBMOCLAIA;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event NBDMFAJPGLA HEAKCOLMFIJ;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event CMGJIOFDIPI ODPBMIMGJCN;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event AJDHECCBPKO CPMOGFCGBCN;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event GPPKCAGFAHK AFGEHLKCOAG;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event PIGMFGHALGD CDOFHNJGFMB;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action MEMPKMAMNNE;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HFKECJNCAPE();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JIGFKIAHCNP();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	EKKJAALLMMI GJOIBENOBCD();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string LFEGNLNJJKK();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	NONMCJIBNII FDGJOECCHJN();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NONMCJIBNII GCFAKMFNNJL(int IIHDMHKNBFH, string MHBKLHEODDA, string KCFMNBKCILK, string MEGPOFCBHAK, string CKHAGCIIDJI, DateTime BHLOJCNDEDO, Action<AEKMOMPGFDB> PMIKDLPAEDI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NONMCJIBNII GOIICKCOBCD(string MHBKLHEODDA, string KCFMNBKCILK, params int[] COKOABJPBFB);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool MNLOHPBIDKM(out int? DNPNKPENJIM);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool JNILGCMAHCK(out KPEBFJDKENJ HDKGNGKHBHG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EAPLKHNILNL
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event NBDMFAJPGLA HEAKCOLMFIJ;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event PIGMFGHALGD CDOFHNJGFMB;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIGFKIAHCNP();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNLOHPBIDKM(out int? DNPNKPENJIM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JNILGCMAHCK(out KPEBFJDKENJ HDKGNGKHBHG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GMEOKGGBMCG(KPEBFJDKENJ ENINOFJGBNJ, PlatformNotificationHandlerContext CNBGAPJABKP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NEDMGGAEDCD
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event NCCBLKNPAAF PCIBMOCLAIA;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EKKJAALLMMI GJOIBENOBCD();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NONMCJIBNII FDGJOECCHJN();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string LFEGNLNJJKK();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<KPEBFJDKENJ> JNEOOBINAEM();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BBDDOCEKCLM();
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
