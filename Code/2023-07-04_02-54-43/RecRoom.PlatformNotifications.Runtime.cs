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
public class KJEPOGKOEPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int FIFMJHLEPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType KBBBDODNMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public CGNNNCOFBLE HFNGBEKOOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool LEFPNPFMPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string JMOHPFNPHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string NJCICAKOMDA;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface INJBGACOAKG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BOIBBDNHHJO? DOCOEENJPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, LEKACFEIBBA<bool>> AEAMJLNEOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BOIBBDNHHJO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void CFGEJFIELON(bool BMKKIDBNMCL, string LOGAJGGPPBP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void IJBIFHANIGJ(bool BMKKIDBNMCL, string LOGAJGGPPBP, BOIBBDNHHJO JDOMMCBNPOB, string LODBJLOKBLP);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MKJPIPGAACP();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CANMNOFJMMB(KJEPOGKOEPB FMFOJHCBAPP, PlatformNotificationHandlerContext JHAKINLMMJL);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void LJAEKJAPNAE(KJEPOGKOEPB FMFOJHCBAPP);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FGNHIDJENJI(KJEPOGKOEPB FMFOJHCBAPP, PlatformNotificationHandlerContext JHAKINLMMJL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void OJFGDLODLAM(string KMDEONFFLPF, string LDNNDPLBKID, string LAFBAECKOLI, string LIOLEMIJGJI);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void PCFIIMKFCNB(string KMDEONFFLPF, string LDNNDPLBKID);
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
[GGHJLFJGPPO]
internal class BDLHIHDHDKE : HMAIMLHDPGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JKIMJKMGBGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public BDLHIHDHDKE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JKIMJKMGBGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		internal void CMAEDGLMOFP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71D4950", Offset = "0x71D2F50", VA = "0x1871D4950")]
		internal void NPODNBPPLCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NOBFKGGIDDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public BDLHIHDHDKE <>4__this;

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
		public Action<CGNNNCOFBLE> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public NOBFKGGIDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71D4990", Offset = "0x71D2F90", VA = "0x1871D4990")]
		internal void HPCFHONNDOM(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class APDIIOMCHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public BDLHIHDHDKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public BOIBBDNHHJO authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public APDIIOMCHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		internal void KBJPHNFNNBA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71D0E20", Offset = "0x71CF420", VA = "0x1871D0E20")]
		internal void MNLCAKKOAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x71D0DD0", Offset = "0x71CF3D0", VA = "0x1871D0DD0")]
		internal void HGJGIKBMGIG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> HFMKLNLPJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CODKJOFCLJH PICJDNNEPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private BCMMKNKBNJE LLNKGEDPOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private LFDOBLOONAD HFPIIJBBPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CEIEIIBLMCJ COAFALGPGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly GCFOBCGKOME KCDIPEJCJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly DGOJIBIJHED KFBEJIODBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly INJBGACOAKG BADFAJCGPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool FONGLKLPNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool JKGIGKMPIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> KEADPGPGEFH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string OEODIBGOKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9259E0", Offset = "0x923FE0", VA = "0x1809259E0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x920E90", Offset = "0x91F490", VA = "0x180920E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string OPBLLDCHEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x71D3A20", Offset = "0x71D2020", VA = "0x1871D3A20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CFGEJFIELON MMOFHKEPCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71D11F0", Offset = "0x71CF7F0", VA = "0x1871D11F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x71D2DC0", Offset = "0x71D13C0", VA = "0x1871D2DC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event IJBIFHANIGJ INEKENCLOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71D3980", Offset = "0x71D1F80", VA = "0x1871D3980", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71D1600", Offset = "0x71CFC00", VA = "0x1871D1600", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MKJPIPGAACP FELPEADPHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71D19C0", Offset = "0x71CFFC0", VA = "0x1871D19C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71D1560", Offset = "0x71CFB60", VA = "0x1871D1560", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event CANMNOFJMMB OGHIHFGKENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71D3840", Offset = "0x71D1E40", VA = "0x1871D3840", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71D27E0", Offset = "0x71D0DE0", VA = "0x1871D27E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LJAEKJAPNAE MLOFBJONBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71D2320", Offset = "0x71D0920", VA = "0x1871D2320", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71D38E0", Offset = "0x71D1EE0", VA = "0x1871D38E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FGNHIDJENJI NELDAPFIJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71D3A70", Offset = "0x71D2070", VA = "0x1871D3A70", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71D3580", Offset = "0x71D1B80", VA = "0x1871D3580", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event OJFGDLODLAM ELLJPCMEHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71D37A0", Offset = "0x71D1DA0", VA = "0x1871D37A0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71D1A60", Offset = "0x71D0060", VA = "0x1871D1A60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event PCFIIMKFCNB CKLKFFFGNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71D34E0", Offset = "0x71D1AE0", VA = "0x1871D34E0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71D28F0", Offset = "0x71D0EF0", VA = "0x1871D28F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action OOCBKNFCNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71D18D0", Offset = "0x71CFED0", VA = "0x1871D18D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71D29B0", Offset = "0x71D0FB0", VA = "0x1871D29B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71D0EE0", Offset = "0x71CF4E0", VA = "0x1871D0EE0")]
	[PJEDGFFEDPC(PDIHHCLCNFI.None)]
	private static void ACDBAIMHKIG(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x71D3B10", Offset = "0x71D2110", VA = "0x1871D3B10")]
	[Preserve]
	internal BDLHIHDHDKE([NALHKAIJJND(null)] CEIEIIBLMCJ COAFALGPGNB, [NALHKAIJJND(null)] DGOJIBIJHED KFBEJIODBEI, [NALHKAIJJND(null)] GCFOBCGKOME KCDIPEJCJBE, [NALHKAIJJND(null)] INJBGACOAKG FAJHLKMLAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71D32C0", Offset = "0x71D18C0", VA = "0x1871D32C0", Slot = "23")]
	public void KGHKJOCLFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x71D3130", Offset = "0x71D1730", VA = "0x1871D3130", Slot = "24")]
	public void JHMKIOCMGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x71D3000", Offset = "0x71D1600", VA = "0x1871D3000")]
	private void JBKKHGCJPIC(bool JCEINFLJDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x71D16A0", Offset = "0x71CFCA0", VA = "0x1871D16A0")]
	private void CIEJIOBNFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x71D2A50", Offset = "0x71D1050", VA = "0x1871D2A50")]
	private void HJFNEHJNLFG(KJEPOGKOEPB FMFOJHCBAPP, PlatformNotificationHandlerContext JHAKINLMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x71D3110", Offset = "0x71D1710", VA = "0x1871D3110")]
	private void JDIGBKDHOEI(KJEPOGKOEPB FMFOJHCBAPP, PlatformNotificationHandlerContext JHAKINLMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71D1F50", Offset = "0x71D0550", VA = "0x1871D1F50", Slot = "32")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71D21F0", Offset = "0x71D07F0", VA = "0x1871D21F0", Slot = "34")]
	public void EIEJCLIIHIF(CODKJOFCLJH DBMJFLMGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71D1290", Offset = "0x71CF890", VA = "0x1871D1290", Slot = "35")]
	public void BMLFEIBBFMM(BCMMKNKBNJE DBMJFLMGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x71D0F50", Offset = "0x71CF550", VA = "0x1871D0F50", Slot = "36")]
	public void ADMFPFAHNMI(LFDOBLOONAD DBMJFLMGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71D31A0", Offset = "0x71D17A0", VA = "0x1871D31A0", Slot = "25")]
	public BOIBBDNHHJO JKFBALKGGCN()
	{
		return default(BOIBBDNHHJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x71D1970", Offset = "0x71CFF70", VA = "0x1871D1970", Slot = "26")]
	public string DCHBBFMBEAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x71D2B90", Offset = "0x71D1190", VA = "0x1871D2B90", Slot = "27")]
	public ADCACBFKFKM HNCANAHOFGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71D23C0", Offset = "0x71D09C0", VA = "0x1871D23C0", Slot = "28")]
	public ADCACBFKFKM ENNOJJHMFCN(int LPHGHEJMIKK, string KMDEONFFLPF, string IKBGHKLDENG, string NFLLFFJFOEG, string NAICHAGGAAN, DateTime FPGFFLGIJHC, Action<CGNNNCOFBLE> LIMMBFLOIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x71D2E60", Offset = "0x71D1460", VA = "0x1871D2E60", Slot = "29")]
	public ADCACBFKFKM IEGEKBAODDO(string KMDEONFFLPF, string IKBGHKLDENG, params int[] DMCMKFEHLGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x71D36E0", Offset = "0x71D1CE0", VA = "0x1871D36E0", Slot = "30")]
	public bool MFMLGMBIGDJ(out int? DCMDLBGKIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x71D3620", Offset = "0x71D1C20", VA = "0x1871D3620", Slot = "31")]
	public bool LGKGKFLKKEE(out KJEPOGKOEPB NLJDJLCNMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x71D1B00", Offset = "0x71D0100", VA = "0x1871D1B00")]
	private ADCACBFKFKM DLJDMPCOKMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x71D2880", Offset = "0x71D0E80", VA = "0x1871D2880")]
	private void FIIANEGAIKD(KJEPOGKOEPB FMFOJHCBAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x71D2F80", Offset = "0x71D1580", VA = "0x1871D2F80")]
	private void IFKMKMLJCNP(KJEPOGKOEPB FMFOJHCBAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x71D2990", Offset = "0x71D0F90", VA = "0x1871D2990")]
	private void GENGFADLKHD(string KMDEONFFLPF, string LDNNDPLBKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x71D32A0", Offset = "0x71D18A0", VA = "0x1871D32A0")]
	private void JKIBEECALCO(string KMDEONFFLPF, string LDNNDPLBKID, string LAFBAECKOLI, string LIOLEMIJGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xBFFDB0", Offset = "0xBFE3B0", VA = "0x180BFFDB0")]
	private void JJILGMLHMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x11AF310", Offset = "0x11AD910", VA = "0x1811AF310")]
	[CompilerGenerated]
	private void HJKKBFFFPHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LFDOBLOONAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string JMPODKMPPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string DDBGPDFFCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<KJEPOGKOEPB> OGHIHFGKENJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ADCACBFKFKM BLGKCGLBKGJ();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ADCACBFKFKM DLJDMPCOKMA();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KJEPOGKOEPB NDGGJBGJNFM();
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
public interface BCMMKNKBNJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KJEPOGKOEPB> OGHIHFGKENJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OJFGDLODLAM KKFLAPHINAL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event PCFIIMKFCNB IGEEJDEGDPB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KJEPOGKOEPB NDGGJBGJNFM();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NFFAIFDGNJJ(string IKBGHKLDENG);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ADCACBFKFKM ENNOJJHMFCN(int LPHGHEJMIKK, string KMDEONFFLPF, string IKBGHKLDENG, string NFLLFFJFOEG, string NAICHAGGAAN, DateTime FPGFFLGIJHC, [Optional] Action<CGNNNCOFBLE> LIMMBFLOIFM);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ADCACBFKFKM IEGEKBAODDO(string KMDEONFFLPF, string IKBGHKLDENG, params int[] DMCMKFEHLGB);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PDBEEFAICIO(params int[] DMCMKFEHLGB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NDLBJIJBMFD
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float BOEOCBNMANM = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<KJEPOGKOEPB> OGHIHFGKENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private OJFGDLODLAM KKFLAPHINAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PCFIIMKFCNB IGEEJDEGDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private MKJPIPGAACP FELPEADPHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DGOJIBIJHED KFBEJIODBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly KJBDCMOEPPK PCEPCKIAOGH;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DGOJIBIJHED
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FLHPAENELMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int OEANGJIMFBN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DateTime? MPPEKDJMBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[GGHJLFJGPPO]
internal class CLJEKEKHNJN : CEIEIIBLMCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NIDCIJLCEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CLJEKEKHNJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KJEPOGKOEPB notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DGOJIBIJHED KFBEJIODBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private KJEPOGKOEPB NLJDJLCNMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? HFIHFAANMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> NMABIFIBBLL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event CANMNOFJMMB OGHIHFGKENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x71D4340", Offset = "0x71D2940", VA = "0x1871D4340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x71D3EE0", Offset = "0x71D24E0", VA = "0x1871D3EE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event FGNHIDJENJI NELDAPFIJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x71D43E0", Offset = "0x71D29E0", VA = "0x1871D43E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71D4240", Offset = "0x71D2840", VA = "0x1871D4240", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x71D3D20", Offset = "0x71D2320", VA = "0x1871D3D20")]
	[PJEDGFFEDPC(PDIHHCLCNFI.None)]
	private static void ACDBAIMHKIG(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x71D4480", Offset = "0x71D2A80", VA = "0x1871D4480")]
	[Preserve]
	internal CLJEKEKHNJN([NALHKAIJJND(null)] DGOJIBIJHED KFBEJIODBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71D4310", Offset = "0x71D2910", VA = "0x1871D4310", Slot = "9")]
	public bool MFMLGMBIGDJ(out int? DCMDLBGKIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x71D42E0", Offset = "0x71D28E0", VA = "0x1871D42E0", Slot = "10")]
	public bool LGKGKFLKKEE(out KJEPOGKOEPB MEDDHHPCACF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71D3D90", Offset = "0x71D2390", VA = "0x1871D3D90", Slot = "11")]
	public void ELJMLECEAOJ(KJEPOGKOEPB FMFOJHCBAPP, PlatformNotificationHandlerContext JHAKINLMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x71D41A0", Offset = "0x71D27A0", VA = "0x1871D41A0", Slot = "8")]
	public void JHMKIOCMGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x71D4050", Offset = "0x71D2650", VA = "0x1871D4050")]
	private void IELGEOCMGNO(KJEPOGKOEPB FMFOJHCBAPP, PlatformNotificationHandlerContext JHAKINLMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x71D3F80", Offset = "0x71D2580", VA = "0x1871D3F80")]
	private void GBMMACAGOEG(KJEPOGKOEPB ICNEMFCONJH, PlatformNotificationHandlerContext JHAKINLMMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x71D4180", Offset = "0x71D2780", VA = "0x1871D4180")]
	[CompilerGenerated]
	private void JBAOBIICPLN(ref NIDCIJLCEMG P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CGNNNCOFBLE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int? DCMDLBGKIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DateTime HJEDABOKMHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string EHOICIODKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string HGLHEKKGFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PlatformNotificationType JGCHLDCGNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x942BB0", Offset = "0x9411B0", VA = "0x180942BB0")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string KMDEONFFLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string IKBGHKLDENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x91DC10", Offset = "0x91C210", VA = "0x18091DC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string CDNILPMKJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x944010", Offset = "0x942610", VA = "0x180944010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string GBAGBODFBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x94F4E0", Offset = "0x94DAE0", VA = "0x18094F4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public long? JFHFPPLGKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x112F4E0", Offset = "0x112DAE0", VA = "0x18112F4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int? AFOHDDGINDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9259D0", Offset = "0x923FD0", VA = "0x1809259D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public long? AMODOANMDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x249FED0", Offset = "0x249E4D0", VA = "0x18249FED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? EDDMGMBKEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x13F1760", Offset = "0x13EFD60", VA = "0x1813F1760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x13F17F0", Offset = "0x13EFDF0", VA = "0x1813F17F0")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HMAIMLHDPGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string OPBLLDCHEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event CFGEJFIELON MMOFHKEPCNO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event IJBIFHANIGJ INEKENCLOOE;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event MKJPIPGAACP FELPEADPHPH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event CANMNOFJMMB OGHIHFGKENJ;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event LJAEKJAPNAE MLOFBJONBBN;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event OJFGDLODLAM ELLJPCMEHEA;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PCFIIMKFCNB CKLKFFFGNGK;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event FGNHIDJENJI NELDAPFIJHG;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action OOCBKNFCNAK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KGHKJOCLFMF();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JHMKIOCMGIJ();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BOIBBDNHHJO JKFBALKGGCN();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string DCHBBFMBEAM();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	ADCACBFKFKM HNCANAHOFGF();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ADCACBFKFKM ENNOJJHMFCN(int LPHGHEJMIKK, string KMDEONFFLPF, string IKBGHKLDENG, string NFLLFFJFOEG, string NAICHAGGAAN, DateTime FPGFFLGIJHC, Action<CGNNNCOFBLE> LIMMBFLOIFM);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	ADCACBFKFKM IEGEKBAODDO(string KMDEONFFLPF, string IKBGHKLDENG, params int[] DMCMKFEHLGB);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool MFMLGMBIGDJ(out int? DCMDLBGKIGH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LGKGKFLKKEE(out KJEPOGKOEPB NLJDJLCNMKO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CEIEIIBLMCJ
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event CANMNOFJMMB OGHIHFGKENJ;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event FGNHIDJENJI NELDAPFIJHG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHMKIOCMGIJ();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFMLGMBIGDJ(out int? DCMDLBGKIGH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LGKGKFLKKEE(out KJEPOGKOEPB NLJDJLCNMKO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ELJMLECEAOJ(KJEPOGKOEPB FMFOJHCBAPP, PlatformNotificationHandlerContext JHAKINLMMJL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CODKJOFCLJH
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event MKJPIPGAACP FELPEADPHPH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BOIBBDNHHJO JKFBALKGGCN();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ADCACBFKFKM HNCANAHOFGF();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string DCHBBFMBEAM();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<KJEPOGKOEPB> ECEDNPJDCNB();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HFIDCAAKOII();
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
