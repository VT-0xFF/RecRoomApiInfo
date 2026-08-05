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
public class JOPBJGNBIHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int GNCJFEGHCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType PDFLIGHJGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public LEEMGCNIDFC JPCDACILKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool JHMCFIGKJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string IKMANHLCAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string EJMPODNKGGB;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NCCPDMFDDFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DBELAMDILIB? DONPEFOMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, NHJDNADPIAN<bool>> EJDIIAOJOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DBELAMDILIB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LJLHONPINDH(bool LKCMOCEILKH, string PEEOOIILKMJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MBFENPNJAJO(bool LKCMOCEILKH, string PEEOOIILKMJ, DBELAMDILIB ILGMHHAJPCO, string IBIKCCMDMHA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FJJFNKEFEPD();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void BLPGBMFPPDN(JOPBJGNBIHF JBOGJBNHLLB, PlatformNotificationHandlerContext APPLJOFCBIB);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void AJJOPNMKDPN(JOPBJGNBIHF JBOGJBNHLLB);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FMGCIBFCAPG(JOPBJGNBIHF JBOGJBNHLLB, PlatformNotificationHandlerContext APPLJOFCBIB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void GJFJFGCAFFE(string FCPMDDAJCDG, string DGAJMEMLKHF, string NMPMBNHHOCC, string EKDMIODJJHB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void CHDNDMDPLCD(string FCPMDDAJCDG, string DGAJMEMLKHF);
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
[HMFLENOJLJJ]
internal class HEIMIFGGCPG : EBCCBIMFMLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OCPPJIONNAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HEIMIFGGCPG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OCPPJIONNAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		internal void IPIKNFKONGL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1547D60", Offset = "0x1546F60", VA = "0x181547D60")]
		internal void GPNMCCPHKHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BLEJJCOOOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public HEIMIFGGCPG <>4__this;

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
		public Action<LEEMGCNIDFC> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BLEJJCOOOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1543890", Offset = "0x1542A90", VA = "0x181543890")]
		internal void LCKFMOBFAOJ(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IAFNCNNGDKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HEIMIFGGCPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public DBELAMDILIB authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IAFNCNNGDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		internal void GLPOFDGIKFL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1547520", Offset = "0x1546720", VA = "0x181547520")]
		internal void AMMEAOGPHPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x15475E0", Offset = "0x15467E0", VA = "0x1815475E0")]
		internal void NLHCDDEJNIN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> OFHPPAOHLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private AEGANELAMEO LLFLDFAMNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private KDMNIGJEOIN GGEILLLIPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NKFJONKDLKO INGMLGJKFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CFLDLJDAJFH HCLFDDKAIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly OALJEHGGMAD IAOLLPNAOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly ALFDPOAEKJL NEIBJEBCNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly NCCPDMFDDFP BIENDKMLDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool BEOMIIHFMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool HKNIHJOGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> MHMLMIKIEOO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string DEGKIJHDJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x93C0D0", Offset = "0x93B2D0", VA = "0x18093C0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string KHGEDCBHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1544B10", Offset = "0x1543D10", VA = "0x181544B10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LJLHONPINDH EMPGLAGBPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1545620", Offset = "0x1544820", VA = "0x181545620", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1545A40", Offset = "0x1544C40", VA = "0x181545A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MBFENPNJAJO GOKLPPEEKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x15448C0", Offset = "0x1543AC0", VA = "0x1815448C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1545000", Offset = "0x1544200", VA = "0x181545000", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FJJFNKEFEPD LLGAPCDKEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1545C00", Offset = "0x1544E00", VA = "0x181545C00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1546C30", Offset = "0x1545E30", VA = "0x181546C30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event BLPGBMFPPDN ANFHLDJMCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1545760", Offset = "0x1544960", VA = "0x181545760", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x15456C0", Offset = "0x15448C0", VA = "0x1815456C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event AJJOPNMKDPN CGOFPADFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1547280", Offset = "0x1546480", VA = "0x181547280", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x15471E0", Offset = "0x15463E0", VA = "0x1815471E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FMGCIBFCAPG MDHCBLDIAIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1544960", Offset = "0x1543B60", VA = "0x181544960", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1545400", Offset = "0x1544600", VA = "0x181545400", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event GJFJFGCAFFE JBOAAJHBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1546B90", Offset = "0x1545D90", VA = "0x181546B90", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1544B60", Offset = "0x1543D60", VA = "0x181544B60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event CHDNDMDPLCD IMCMANPJFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1546280", Offset = "0x1545480", VA = "0x181546280", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1544A70", Offset = "0x1543C70", VA = "0x181544A70", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action IHLGDIALALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1546CD0", Offset = "0x1545ED0", VA = "0x181546CD0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x15461E0", Offset = "0x15453E0", VA = "0x1815461E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1544A00", Offset = "0x1543C00", VA = "0x181544A00")]
	[MPKPGFJAEKF(OJBJGAAILBP.None)]
	private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1547430", Offset = "0x1546630", VA = "0x181547430")]
	[Preserve]
	internal HEIMIFGGCPG([IDNKOMINBGM(null)] CFLDLJDAJFH HCLFDDKAIBN, [IDNKOMINBGM(null)] ALFDPOAEKJL NEIBJEBCNCE, [IDNKOMINBGM(null)] OALJEHGGMAD IAOLLPNAOOO, [IDNKOMINBGM(null)] NCCPDMFDDFP HIMIFCBAJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1546D70", Offset = "0x1545F70", VA = "0x181546D70", Slot = "23")]
	public void OHLMLHJNBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1545800", Offset = "0x1544A00", VA = "0x181545800", Slot = "24")]
	public void GFBDJNPLMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1547320", Offset = "0x1546520", VA = "0x181547320")]
	private void PKMBHHMODJK(bool CEPOGFMIBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1546FB0", Offset = "0x15461B0", VA = "0x181546FB0")]
	private void ONKCDOJKCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1544C00", Offset = "0x1543E00", VA = "0x181544C00")]
	private void DAEAAMEMJBG(JOPBJGNBIHF JBOGJBNHLLB, PlatformNotificationHandlerContext APPLJOFCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1546F90", Offset = "0x1546190", VA = "0x181546F90")]
	private void OKHHJPDMCKJ(JOPBJGNBIHF JBOGJBNHLLB, PlatformNotificationHandlerContext APPLJOFCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1545160", Offset = "0x1544360", VA = "0x181545160", Slot = "32")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1545910", Offset = "0x1544B10", VA = "0x181545910", Slot = "34")]
	public void HCHPEDFFAIM(AEGANELAMEO PNAGJFGNFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1545F10", Offset = "0x1545110", VA = "0x181545F10", Slot = "35")]
	public void JIPGHFCLKFK(KDMNIGJEOIN PNAGJFGNFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1544D60", Offset = "0x1543F60", VA = "0x181544D60", Slot = "36")]
	public void DHHIPFPONDB(NKFJONKDLKO PNAGJFGNFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x15447C0", Offset = "0x15439C0", VA = "0x1815447C0", Slot = "25")]
	public DBELAMDILIB AIODNIBDMCG()
	{
		return default(DBELAMDILIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x15455D0", Offset = "0x15447D0", VA = "0x1815455D0", Slot = "26")]
	public string FGIHNFKNELJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1545CC0", Offset = "0x1544EC0", VA = "0x181545CC0", Slot = "27")]
	public OOPPNGPPPLE IPEGBCPANOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1546770", Offset = "0x1545970", VA = "0x181546770", Slot = "28")]
	public OOPPNGPPPLE NEGHEECJPDM(int HACBENAKGJJ, string FCPMDDAJCDG, string BBDLOPHBELB, string CIGBJEEDBNB, string HGFMMFLFEAD, DateTime PHHNKGOBABP, Action<LEEMGCNIDFC> JGMJINMIGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1545AE0", Offset = "0x1544CE0", VA = "0x181545AE0", Slot = "29")]
	public OOPPNGPPPLE HPJBMLHIJGG(string FCPMDDAJCDG, string BBDLOPHBELB, params int[] PLEIIONBMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x15450A0", Offset = "0x15442A0", VA = "0x1815450A0", Slot = "30")]
	public bool DPDKGIJCAPM(out int? HNAKENADKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1545510", Offset = "0x1544710", VA = "0x181545510", Slot = "31")]
	public bool EIOFBNNBMLO(out JOPBJGNBIHF JAENPAOEJFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1546320", Offset = "0x1545520", VA = "0x181546320")]
	private OOPPNGPPPLE LBMAJJDKPJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x15454A0", Offset = "0x15446A0", VA = "0x1815454A0")]
	private void EAAGAHLHKLH(JOPBJGNBIHF JBOGJBNHLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1545890", Offset = "0x1544A90", VA = "0x181545890")]
	private void HCHJHPBHCPC(JOPBJGNBIHF JBOGJBNHLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1545CA0", Offset = "0x1544EA0", VA = "0x181545CA0")]
	private void ILMOIHIIFDC(string FCPMDDAJCDG, string DGAJMEMLKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1545870", Offset = "0x1544A70", VA = "0x181545870")]
	private void GKJAOBDHFGH(string FCPMDDAJCDG, string DGAJMEMLKHF, string NMPMBNHHOCC, string EKDMIODJJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1544D40", Offset = "0x1543F40", VA = "0x181544D40")]
	private void DFKHLBMBPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1545EF0", Offset = "0x15450F0", VA = "0x181545EF0")]
	[CompilerGenerated]
	private void JGGAEFKNAFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NKFJONKDLKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string DFHNMPNEDDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string GENOJEADKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<JOPBJGNBIHF> ANFHLDJMCEE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOPPNGPPPLE MCNAKHNACLN();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OOPPNGPPPLE LBMAJJDKPJD();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JOPBJGNBIHF DEEKIJGIEKL();
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
public interface KDMNIGJEOIN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<JOPBJGNBIHF> ANFHLDJMCEE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event GJFJFGCAFFE LHDGAMFMJLE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event CHDNDMDPLCD ODNPEJAGBPD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JOPBJGNBIHF DEEKIJGIEKL();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OMAOKBLEKFD(string BBDLOPHBELB);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OOPPNGPPPLE NEGHEECJPDM(int HACBENAKGJJ, string FCPMDDAJCDG, string BBDLOPHBELB, string CIGBJEEDBNB, string HGFMMFLFEAD, DateTime PHHNKGOBABP, [Optional] Action<LEEMGCNIDFC> JGMJINMIGND);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OOPPNGPPPLE HPJBMLHIJGG(string FCPMDDAJCDG, string BBDLOPHBELB, params int[] PLEIIONBMPE);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ALJJKPGECAM(params int[] PLEIIONBMPE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BJNEDPEMKAM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float CGIAPDHDFMF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<JOPBJGNBIHF> ANFHLDJMCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GJFJFGCAFFE LHDGAMFMJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CHDNDMDPLCD ODNPEJAGBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private FJJFNKEFEPD LLGAPCDKEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly ALFDPOAEKJL NEIBJEBCNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HOBPEPKDKNI CHAOLJOCGCA;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ALFDPOAEKJL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LIDBDLGABCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int PPGNBMGKJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DateTime? IIGEPEEJFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HMFLENOJLJJ]
internal class FJAAJPLEHAM : CFLDLJDAJFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct AHLINKAEJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public FJAAJPLEHAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JOPBJGNBIHF notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ALFDPOAEKJL NEIBJEBCNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private JOPBJGNBIHF JAENPAOEJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? CJLNALFOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> JHPFCNDDNDM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event BLPGBMFPPDN ANFHLDJMCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1543F40", Offset = "0x1543140", VA = "0x181543F40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1543EA0", Offset = "0x15430A0", VA = "0x181543EA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event FMGCIBFCAPG MDHCBLDIAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1543A90", Offset = "0x1542C90", VA = "0x181543A90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1543CA0", Offset = "0x1542EA0", VA = "0x181543CA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1543B30", Offset = "0x1542D30", VA = "0x181543B30")]
	[MPKPGFJAEKF(OJBJGAAILBP.None)]
	private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x15441D0", Offset = "0x15433D0", VA = "0x1815441D0")]
	[Preserve]
	internal FJAAJPLEHAM([IDNKOMINBGM(null)] ALFDPOAEKJL NEIBJEBCNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1543C70", Offset = "0x1542E70", VA = "0x181543C70", Slot = "9")]
	public bool DPDKGIJCAPM(out int? HNAKENADKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1543D40", Offset = "0x1542F40", VA = "0x181543D40", Slot = "10")]
	public bool EIOFBNNBMLO(out JOPBJGNBIHF OFGFLIHOLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1544080", Offset = "0x1543280", VA = "0x181544080", Slot = "11")]
	public void JIPOHAECODL(JOPBJGNBIHF JBOGJBNHLLB, PlatformNotificationHandlerContext APPLJOFCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1543FE0", Offset = "0x15431E0", VA = "0x181543FE0", Slot = "8")]
	public void GFBDJNPLMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1543D70", Offset = "0x1542F70", VA = "0x181543D70")]
	private void ELPLNLNGNFL(JOPBJGNBIHF JBOGJBNHLLB, PlatformNotificationHandlerContext APPLJOFCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1543BA0", Offset = "0x1542DA0", VA = "0x181543BA0")]
	private void CELJFOGMDAJ(JOPBJGNBIHF AIMDHJHOMMN, PlatformNotificationHandlerContext APPLJOFCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1543A70", Offset = "0x1542C70", VA = "0x181543A70")]
	[CompilerGenerated]
	private void ABCJKNHLPLD(ref AHLINKAEJKN P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LEEMGCNIDFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int? HNAKENADKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DateTime PDCIAOLANIN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string BJEGDGKINOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string MJHCNNFELCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PlatformNotificationType EAGDFNCDDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C00", Offset = "0x8D5E00", VA = "0x1808D6C00")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string FCPMDDAJCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string BBDLOPHBELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string MCODHEAOHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NFMEAACEONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8EE410", Offset = "0x8ED610", VA = "0x1808EE410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public long? NADNGCKBNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1547650", Offset = "0x1546850", VA = "0x181547650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int? ACFOGDEGGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8EE430", Offset = "0x8ED630", VA = "0x1808EE430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public long? KHDENBLDIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xC2FAC0", Offset = "0xC2ECC0", VA = "0x180C2FAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? LNBFDCAEKJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1547630", Offset = "0x1546830", VA = "0x181547630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1547640", Offset = "0x1546840", VA = "0x181547640")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EBCCBIMFMLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string KHGEDCBHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event LJLHONPINDH EMPGLAGBPEK;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event MBFENPNJAJO GOKLPPEEKBN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event FJJFNKEFEPD LLGAPCDKEAC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event BLPGBMFPPDN ANFHLDJMCEE;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event AJJOPNMKDPN CGOFPADFPNL;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event GJFJFGCAFFE JBOAAJHBPPD;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event CHDNDMDPLCD IMCMANPJFIJ;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event FMGCIBFCAPG MDHCBLDIAIO;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action IHLGDIALALK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OHLMLHJNBAL();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GFBDJNPLMOG();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	DBELAMDILIB AIODNIBDMCG();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string FGIHNFKNELJ();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	OOPPNGPPPLE IPEGBCPANOM();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OOPPNGPPPLE NEGHEECJPDM(int HACBENAKGJJ, string FCPMDDAJCDG, string BBDLOPHBELB, string CIGBJEEDBNB, string HGFMMFLFEAD, DateTime PHHNKGOBABP, Action<LEEMGCNIDFC> JGMJINMIGND);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OOPPNGPPPLE HPJBMLHIJGG(string FCPMDDAJCDG, string BBDLOPHBELB, params int[] PLEIIONBMPE);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool DPDKGIJCAPM(out int? HNAKENADKLO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EIOFBNNBMLO(out JOPBJGNBIHF JAENPAOEJFI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CFLDLJDAJFH
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event BLPGBMFPPDN ANFHLDJMCEE;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event FMGCIBFCAPG MDHCBLDIAIO;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GFBDJNPLMOG();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DPDKGIJCAPM(out int? HNAKENADKLO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EIOFBNNBMLO(out JOPBJGNBIHF JAENPAOEJFI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JIPOHAECODL(JOPBJGNBIHF JBOGJBNHLLB, PlatformNotificationHandlerContext APPLJOFCBIB);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AEGANELAMEO
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event FJJFNKEFEPD LLGAPCDKEAC;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBELAMDILIB AIODNIBDMCG();

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOPPNGPPPLE IPEGBCPANOM();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string FGIHNFKNELJ();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<JOPBJGNBIHF> FOHPPOMKHNL();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KKPOLFNHBLK();
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
