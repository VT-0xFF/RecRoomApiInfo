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
public class AIODGEHJJOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int IJLNNMHDIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType OILIJCDIDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public COMGIPPBPEA MCLHPMKICBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool JEMEJMJGDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string IKIDBPOJLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string AKPLNHMDHGE;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MNDNILJKBNF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EPICLOCFHKO? BCOEAIMCPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, KDCMFGDLEKL<bool>> AKJCFOAAONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EPICLOCFHKO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void HOEDLPCNFEA(bool PKEPEKOBHMH, string NKADMIGGGNG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void EHNNPONLAEG(bool PKEPEKOBHMH, string NKADMIGGGNG, EPICLOCFHKO ONNBGHDIENH, string AEMEEHLIDCM, string OPDINEMAOKD);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MBLFPEMMIIA();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void KILDPGFJGOE(AIODGEHJJOA KODKKCAEAEI, PlatformNotificationHandlerContext AKPCLGIGABA);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void FOIFAELIKDK(AIODGEHJJOA KODKKCAEAEI);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void JGIMOFICLPL(AIODGEHJJOA KODKKCAEAEI, PlatformNotificationHandlerContext AKPCLGIGABA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void KJKMKCJJADC(string MPCKNDIDIEO, string PHPDMFOIAKG, string JELOAHGAOBD, string MHGABBIPFOC);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void INNKDCGGPEG(string MPCKNDIDIEO, string PHPDMFOIAKG);
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
[NPECACBIKJK]
internal class CFNLHCODFGF : HFCNEIFGEDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GOKEFPBIILL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CFNLHCODFGF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GOKEFPBIILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		internal void HJLOMJDFHOC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7181230", Offset = "0x7180630", VA = "0x187181230")]
		internal void FEFABHEGFMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class INDKCFLOFCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CFNLHCODFGF <>4__this;

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
		public Action<COMGIPPBPEA> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public INDKCFLOFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7181300", Offset = "0x7180700", VA = "0x187181300")]
		internal void AMPKJKFEPOA(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NMFMOMMEGOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CFNLHCODFGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public EPICLOCFHKO authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NMFMOMMEGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		internal void EGJFGOEENGE(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7181660", Offset = "0x7180A60", VA = "0x187181660")]
		internal void PLIGEFBOJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7181570", Offset = "0x7180970", VA = "0x187181570")]
		internal void JKGCJLJALLL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> ANLAOHPEGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private DNEACNLIKOD HMEJENMPLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private FIAAFAMHAOM LENOLPLDKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private FCIABNGLJCA KECPCGDGGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HEACFPDBMGI PFFOCHNMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly AGAJJBLMBLJ OBNKFPBIDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FOEMPONDLGI JAHAFEGILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly MNDNILJKBNF KOOMEHJCPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool FCENGCEAPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool GDBAFMMEJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> JCMDKOINICG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string KMGLPHEOBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string DPMNPMFJOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x717EAF0", Offset = "0x717DEF0", VA = "0x18717EAF0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AIODGEHJJOA AMAGEACFDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7180B70", Offset = "0x717FF70", VA = "0x187180B70", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event HOEDLPCNFEA JAFAEKLNLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71805C0", Offset = "0x717F9C0", VA = "0x1871805C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x717E0F0", Offset = "0x717D4F0", VA = "0x18717E0F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EHNNPONLAEG EFGHDGOOEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x717FB30", Offset = "0x717EF30", VA = "0x18717FB30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7180020", Offset = "0x717F420", VA = "0x187180020", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MBLFPEMMIIA OACNHFPEMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x717E5B0", Offset = "0x717D9B0", VA = "0x18717E5B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x717FC70", Offset = "0x717F070", VA = "0x18717FC70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event KILDPGFJGOE NMELMDAGAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7180AD0", Offset = "0x717FED0", VA = "0x187180AD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x717E8A0", Offset = "0x717DCA0", VA = "0x18717E8A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FOIFAELIKDK AKGBLMOOIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x717E6F0", Offset = "0x717DAF0", VA = "0x18717E6F0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x717F290", Offset = "0x717E690", VA = "0x18717F290", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JGIMOFICLPL KOCJNPNJAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x717E650", Offset = "0x717DA50", VA = "0x18717E650", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x717F1F0", Offset = "0x717E5F0", VA = "0x18717F1F0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event KJKMKCJJADC GKFFBCGIDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x717E790", Offset = "0x717DB90", VA = "0x18717E790", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x717FF80", Offset = "0x717F380", VA = "0x18717FF80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event INNKDCGGPEG BIAKFCFGEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x717FBD0", Offset = "0x717EFD0", VA = "0x18717FBD0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7180360", Offset = "0x717F760", VA = "0x187180360", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action GMDJGCADGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7180C90", Offset = "0x7180090", VA = "0x187180C90", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7180BF0", Offset = "0x717FFF0", VA = "0x187180BF0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x717FD10", Offset = "0x717F110", VA = "0x18717FD10")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.None)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7180D30", Offset = "0x7180130", VA = "0x187180D30")]
	[Preserve]
	internal CFNLHCODFGF([JLJFOFICIEA(null)] HEACFPDBMGI PFFOCHNMCBI, [JLJFOFICIEA(null)] FOEMPONDLGI JAHAFEGILDD, [JLJFOFICIEA(null)] AGAJJBLMBLJ OBNKFPBIDIP, [JLJFOFICIEA(null)] MNDNILJKBNF PPHPNENEJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7180180", Offset = "0x717F580", VA = "0x187180180", Slot = "24")]
	public void MHIDNOPDKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x717E830", Offset = "0x717DC30", VA = "0x18717E830", Slot = "25")]
	public void CJLNFFCDPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x717F130", Offset = "0x717E530", VA = "0x18717F130")]
	private void FCONAFIHFOI(bool DHKKHBECOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x717EDE0", Offset = "0x717E1E0", VA = "0x18717EDE0")]
	private void EOMFBHEHLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x717FE40", Offset = "0x717F240", VA = "0x18717FE40")]
	private void KCNIBFBBBPJ(AIODGEHJJOA KODKKCAEAEI, PlatformNotificationHandlerContext AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x717FAF0", Offset = "0x717EEF0", VA = "0x18717FAF0")]
	private void IPKMIOPDBEO(AIODGEHJJOA KODKKCAEAEI, PlatformNotificationHandlerContext AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x717EB40", Offset = "0x717DF40", VA = "0x18717EB40", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x717E9C0", Offset = "0x717DDC0", VA = "0x18717E9C0", Slot = "35")]
	public void COMCBBEEOLE(DNEACNLIKOD HBKPHPNEIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x717F330", Offset = "0x717E730", VA = "0x18717F330", Slot = "36")]
	public void FPINAIFHHEK(FIAAFAMHAOM HBKPHPNEIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x717F850", Offset = "0x717EC50", VA = "0x18717F850", Slot = "37")]
	public void IOCOFJBFCBJ(FCIABNGLJCA HBKPHPNEIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7180400", Offset = "0x717F800", VA = "0x187180400", Slot = "26")]
	public EPICLOCFHKO NDBHBAGGPEL()
	{
		return default(EPICLOCFHKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7180500", Offset = "0x717F900", VA = "0x187180500", Slot = "27")]
	public string NKKGOLJIMLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x717F600", Offset = "0x717EA00", VA = "0x18717F600", Slot = "28")]
	public LMHNGLGIJDH GMABKCDBELF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x717E190", Offset = "0x717D590", VA = "0x18717E190", Slot = "29")]
	public LMHNGLGIJDH BGEDKGHBIMD(int AKKJNIHLFCP, string MPCKNDIDIEO, string ILPOOGMOEIC, string FJIALGMLGCF, string DNIDDKDIOFD, DateTime MMHOJAFNCDE, Action<COMGIPPBPEA> KEDPIONCBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x717F010", Offset = "0x717E410", VA = "0x18717F010", Slot = "30")]
	public LMHNGLGIJDH EPBFJKPPHPI(string MPCKNDIDIEO, string ILPOOGMOEIC, params int[] HLGFCAEDBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x71800C0", Offset = "0x717F4C0", VA = "0x1871800C0", Slot = "31")]
	public bool LGCDKKGEGDJ(out int? BGDDDLJMKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x717FD80", Offset = "0x717F180", VA = "0x18717FD80", Slot = "32")]
	public bool KCJBIEKHOMJ(out AIODGEHJJOA HFJFKCPKNCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7180660", Offset = "0x717FA60", VA = "0x187180660")]
	private LMHNGLGIJDH ONLMDPDBKBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7180550", Offset = "0x717F950", VA = "0x187180550")]
	private void OAHPKHOKLGJ(AIODGEHJJOA KODKKCAEAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x717E940", Offset = "0x717DD40", VA = "0x18717E940")]
	private void CKKFHLKLFGH(AIODGEHJJOA KODKKCAEAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x717FB10", Offset = "0x717EF10", VA = "0x18717FB10")]
	private void JDOODJKHOMI(string MPCKNDIDIEO, string PHPDMFOIAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x717F830", Offset = "0x717EC30", VA = "0x18717F830")]
	private void HPEKMGAEHCB(string MPCKNDIDIEO, string PHPDMFOIAKG, string JELOAHGAOBD, string MHGABBIPFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xC61130", Offset = "0xC60530", VA = "0x180C61130")]
	private void POOJIFIODEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x974A10", Offset = "0x973E10", VA = "0x180974A10")]
	[CompilerGenerated]
	private void LLBIMAFKBFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FCIABNGLJCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string AJIEFFKMCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string LADAMCENLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string LAEPJJABMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<AIODGEHJJOA> NMELMDAGAOJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LMHNGLGIJDH ANONDGNMNGI();

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LMHNGLGIJDH ONLMDPDBKBA();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IGILBMODHKB(bool CJFOKBCHMPL);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIODGEHJJOA AGPDGGFPAME();
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
public interface FIAAFAMHAOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<AIODGEHJJOA> NMELMDAGAOJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event KJKMKCJJADC EJFBPOPNCEI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event INNKDCGGPEG OBOIILNBCNJ;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AIODGEHJJOA AGPDGGFPAME();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BBAJJFCBOMO(string ILPOOGMOEIC);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LMHNGLGIJDH BGEDKGHBIMD(int AKKJNIHLFCP, string MPCKNDIDIEO, string ILPOOGMOEIC, string FJIALGMLGCF, string DNIDDKDIOFD, DateTime MMHOJAFNCDE, [Optional] Action<COMGIPPBPEA> KEDPIONCBGJ);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LMHNGLGIJDH EPBFJKPPHPI(string MPCKNDIDIEO, string ILPOOGMOEIC, params int[] HLGFCAEDBJH);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JAPECLHHBMG(params int[] HLGFCAEDBJH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IKLLEEMLOIA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float HOAELALCDMC = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<AIODGEHJJOA> NMELMDAGAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private KJKMKCJJADC EJFBPOPNCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private INNKDCGGPEG OBOIILNBCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private MBLFPEMMIIA OACNHFPEMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FOEMPONDLGI JAHAFEGILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GNILGMCMPBL NEELIDMCIKP;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FOEMPONDLGI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JLFBINFOHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int CEMLHLPOAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime? IFIPCIKOGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NPECACBIKJK]
internal class AFAIEIKDFAP : HEACFPDBMGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NGHLCICAEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AFAIEIKDFAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AIODGEHJJOA notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FOEMPONDLGI JAHAFEGILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private AIODGEHJJOA HFJFKCPKNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? GNOGBMAAOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> ADLFJJGMMPH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event KILDPGFJGOE NMELMDAGAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x717DFB0", Offset = "0x717D3B0", VA = "0x18717DFB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x717DA30", Offset = "0x717CE30", VA = "0x18717DA30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event JGIMOFICLPL KOCJNPNJAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x717D890", Offset = "0x717CC90", VA = "0x18717D890", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x717DC20", Offset = "0x717D020", VA = "0x18717DC20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x717DD90", Offset = "0x717D190", VA = "0x18717DD90")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.None)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x717E050", Offset = "0x717D450", VA = "0x18717E050")]
	[Preserve]
	internal AFAIEIKDFAP([JLJFOFICIEA(null)] FOEMPONDLGI JAHAFEGILDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x717DE30", Offset = "0x717D230", VA = "0x18717DE30", Slot = "9")]
	public bool LGCDKKGEGDJ(out int? BGDDDLJMKIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x717DE00", Offset = "0x717D200", VA = "0x18717DE00", Slot = "10")]
	public bool KCJBIEKHOMJ(out AIODGEHJJOA ADHLOIGEGFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x717DAD0", Offset = "0x717CED0", VA = "0x18717DAD0", Slot = "11")]
	public void DPHOODJEBEA(AIODGEHJJOA KODKKCAEAEI, PlatformNotificationHandlerContext AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x717D930", Offset = "0x717CD30", VA = "0x18717D930", Slot = "8")]
	public void CJLNFFCDPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x717DE80", Offset = "0x717D280", VA = "0x18717DE80")]
	private void NGDKGKDLMOM(AIODGEHJJOA KODKKCAEAEI, PlatformNotificationHandlerContext AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x717DCC0", Offset = "0x717D0C0", VA = "0x18717DCC0")]
	private void GBNLGCJELMM(AIODGEHJJOA OKEOPDJLOEC, PlatformNotificationHandlerContext AKPCLGIGABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x717DE60", Offset = "0x717D260", VA = "0x18717DE60")]
	[CompilerGenerated]
	private void MIEOBOBAJML(ref NGHLCICAEPH P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class COMGIPPBPEA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int? BGDDDLJMKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DateTime DMEKMEOAMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string JPONFHDNFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string OPGLFHHOACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PlatformNotificationType MHKNIKOLPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABD510", VA = "0x180ABE110")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string MPCKNDIDIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string OLGBFDCODHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string ILPOOGMOEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string FBDPHEGBEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string KGCFFHEGEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? JJMKKMCHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA5ABE0", Offset = "0xA59FE0", VA = "0x180A5ABE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int? AGIJGCMMBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public long? LDNINBEIDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x23BB420", Offset = "0x23BA820", VA = "0x1823BB420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public long? KFHMHOFPIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA7CE10", Offset = "0xA7C210", VA = "0x180A7CE10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C450", Offset = "0xA7B850", VA = "0x180A7C450")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HFCNEIFGEDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string DPMNPMFJOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AIODGEHJJOA AMAGEACFDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HOEDLPCNFEA JAFAEKLNLNH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event EHNNPONLAEG EFGHDGOOEEM;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event MBLFPEMMIIA OACNHFPEMDA;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event KILDPGFJGOE NMELMDAGAOJ;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FOIFAELIKDK AKGBLMOOIBD;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event KJKMKCJJADC GKFFBCGIDKF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event INNKDCGGPEG BIAKFCFGEKE;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event JGIMOFICLPL KOCJNPNJAJO;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action GMDJGCADGNL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MHIDNOPDKCM();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CJLNFFCDPNM();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	EPICLOCFHKO NDBHBAGGPEL();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string NKKGOLJIMLA();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	LMHNGLGIJDH GMABKCDBELF();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LMHNGLGIJDH BGEDKGHBIMD(int AKKJNIHLFCP, string MPCKNDIDIEO, string ILPOOGMOEIC, string FJIALGMLGCF, string DNIDDKDIOFD, DateTime MMHOJAFNCDE, Action<COMGIPPBPEA> KEDPIONCBGJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	LMHNGLGIJDH EPBFJKPPHPI(string MPCKNDIDIEO, string ILPOOGMOEIC, params int[] HLGFCAEDBJH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LGCDKKGEGDJ(out int? BGDDDLJMKIB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool KCJBIEKHOMJ(out AIODGEHJJOA HFJFKCPKNCK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HEACFPDBMGI
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event KILDPGFJGOE NMELMDAGAOJ;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event JGIMOFICLPL KOCJNPNJAJO;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJLNFFCDPNM();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LGCDKKGEGDJ(out int? BGDDDLJMKIB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KCJBIEKHOMJ(out AIODGEHJJOA HFJFKCPKNCK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DPHOODJEBEA(AIODGEHJJOA KODKKCAEAEI, PlatformNotificationHandlerContext AKPCLGIGABA);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DNEACNLIKOD
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event MBLFPEMMIIA OACNHFPEMDA;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EPICLOCFHKO NDBHBAGGPEL();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LMHNGLGIJDH GMABKCDBELF();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string NKKGOLJIMLA();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<AIODGEHJJOA> JGKPGICDNPI();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMOHKMOCLHK();
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
