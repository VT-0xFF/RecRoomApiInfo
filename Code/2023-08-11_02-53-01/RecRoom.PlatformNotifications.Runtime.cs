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
public class DBAPAMFAIFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int MIBBGBKINAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType ILFDEIBDFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public GIJMEBMJNGF HEOPJELIEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool KIEEJALOGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string OFHIFCBJKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string GCADHJIJHOM;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FNAMAOINKOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DKPBNBLKHOO? INEMANEKPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, JJMNNLLBAJO<bool>> NOLBNBJAABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DKPBNBLKHOO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EKNDJOJMJLM(bool NFFGKDNLOEK, string FHHEEEGOKNF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void KOCBHAEJMKE(bool NFFGKDNLOEK, string FHHEEEGOKNF, DKPBNBLKHOO DCFHNELFCCD, string AMCDGOPKAOE, string KBHKLKKNMLK);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FLNCMNDDFJJ();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void OOFNJCEHIBF(DBAPAMFAIFC CGMCKIOHEJM, PlatformNotificationHandlerContext HNBDDLBIIOF);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void EKPLAHNPPCE(DBAPAMFAIFC CGMCKIOHEJM);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void FNPDKAKJBFD(DBAPAMFAIFC CGMCKIOHEJM, PlatformNotificationHandlerContext HNBDDLBIIOF);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void CBFIAEAINOG(string MAPAAJDLNGI, string JJAONHLCBBE, string IHPNBKNCNHD, string HFINBEOGJJP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void IAGNDLIBHIN(string MAPAAJDLNGI, string JJAONHLCBBE);
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
[ACFLGLMHDEN]
internal class KMIGHABIKIE : HOLFLNPLEBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class INOIOJEBOME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public KMIGHABIKIE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public INOIOJEBOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		internal void FECJFHGHFHJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E85E00", Offset = "0x6E84600", VA = "0x186E85E00")]
		internal void FLFGGFCODEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BDHCLMAPEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public KMIGHABIKIE <>4__this;

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
		public Action<GIJMEBMJNGF> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BDHCLMAPEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E85B90", Offset = "0x6E84390", VA = "0x186E85B90")]
		internal void JPLCGPCOOMM(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ONEOHBPHADO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public KMIGHABIKIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public DKPBNBLKHOO authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ONEOHBPHADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		internal void PKOBJJIDBHF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E89780", Offset = "0x6E87F80", VA = "0x186E89780")]
		internal void FHNBFBFCHIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6E89840", Offset = "0x6E88040", VA = "0x186E89840")]
		internal void LFEBMLDBJPH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> MGPPNGPNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PPHLCPEIBHJ OGEPFPBIPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private BCLLGNELFCL EJCNBCEJMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private OMDONAKEBDC JKNNHJJMMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HEGENOHPANF FJPBJKGDNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly JLELFANOIJD PFPLJNBNPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly NEFMIGGCAHA OPBOGHOHKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly FNAMAOINKOD AIPCEAEKJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool FHHKHMFNLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool MBOBNAFNCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> IIMHOKCHMPK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string ONAIMEKOBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A86F0", VA = "0x1808A9EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string NONAMBPOGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E87F70", Offset = "0x6E86770", VA = "0x186E87F70", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DBAPAMFAIFC DIOMGPDFPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E87380", Offset = "0x6E85B80", VA = "0x186E87380", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EKNDJOJMJLM JPPHEFNDOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E872E0", Offset = "0x6E85AE0", VA = "0x186E872E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E88800", Offset = "0x6E87000", VA = "0x186E88800", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KOCBHAEJMKE BGBKEAGIMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E88060", Offset = "0x6E86860", VA = "0x186E88060", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E87400", Offset = "0x6E85C00", VA = "0x186E87400", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FLNCMNDDFJJ GCNEGKFNLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E88420", Offset = "0x6E86C20", VA = "0x186E88420", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E87FC0", Offset = "0x6E867C0", VA = "0x186E87FC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event OOFNJCEHIBF HADAABAGHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E87580", Offset = "0x6E85D80", VA = "0x186E87580", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E86CE0", Offset = "0x6E854E0", VA = "0x186E86CE0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EKPLAHNPPCE AADPNHEIFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E88940", Offset = "0x6E87140", VA = "0x186E88940", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E87620", Offset = "0x6E85E20", VA = "0x186E87620", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FNPDKAKJBFD JMEABMLFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E889E0", Offset = "0x6E871E0", VA = "0x186E889E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E888A0", Offset = "0x6E870A0", VA = "0x186E888A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event CBFIAEAINOG EJNMNCKAFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E88180", Offset = "0x6E86980", VA = "0x186E88180", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E88240", Offset = "0x6E86A40", VA = "0x186E88240", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event IAGNDLIBHIN PPLAHHNJELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E86640", Offset = "0x6E84E40", VA = "0x186E86640", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6E88760", Offset = "0x6E86F60", VA = "0x186E88760", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action ICNCMGJMAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E85E40", Offset = "0x6E84640", VA = "0x186E85E40", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E85FA0", Offset = "0x6E847A0", VA = "0x186E85FA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E87140", Offset = "0x6E85940", VA = "0x186E87140")]
	[NFOBBCLLFPP(BGPNPCEMJLD.None)]
	private static void EBMOAACPAFK(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E88A80", Offset = "0x6E87280", VA = "0x186E88A80")]
	[Preserve]
	internal KMIGHABIKIE([JHPEMCNOMHI(null)] HEGENOHPANF FJPBJKGDNPI, [JHPEMCNOMHI(null)] NEFMIGGCAHA OPBOGHOHKBK, [JHPEMCNOMHI(null)] JLELFANOIJD PFPLJNBNPBN, [JHPEMCNOMHI(null)] FNAMAOINKOD LFCKIHDGDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E86040", Offset = "0x6E84840", VA = "0x186E86040", Slot = "24")]
	public void BDCEDMLOOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E87BE0", Offset = "0x6E863E0", VA = "0x186E87BE0", Slot = "25")]
	public void JIOHGFADAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E85EE0", Offset = "0x6E846E0", VA = "0x186E85EE0")]
	private void APLIPBKBOEJ(bool JEJMPPELMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E879B0", Offset = "0x6E861B0", VA = "0x186E879B0")]
	private void JABBCKJDENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E882E0", Offset = "0x6E86AE0", VA = "0x186E882E0")]
	private void OHGEMOGDOJM(DBAPAMFAIFC CGMCKIOHEJM, PlatformNotificationHandlerContext HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E88220", Offset = "0x6E86A20", VA = "0x186E88220")]
	private void NGBNGJCGLFA(DBAPAMFAIFC CGMCKIOHEJM, PlatformNotificationHandlerContext HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E86EA0", Offset = "0x6E856A0", VA = "0x186E86EA0", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E871B0", Offset = "0x6E859B0", VA = "0x186E871B0", Slot = "35")]
	public void EEEDCEDIJCG(PPHLCPEIBHJ HPKCFMILJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E87C50", Offset = "0x6E86450", VA = "0x186E87C50", Slot = "36")]
	public void JJJNJKCMNOL(BCLLGNELFCL HPKCFMILJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E884C0", Offset = "0x6E86CC0", VA = "0x186E884C0", Slot = "37")]
	public void OPDJBOMGEHP(OMDONAKEBDC HPKCFMILJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E86DA0", Offset = "0x6E855A0", VA = "0x186E86DA0", Slot = "26")]
	public DKPBNBLKHOO DKDCPEBGMDC()
	{
		return default(DKPBNBLKHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E87F20", Offset = "0x6E86720", VA = "0x186E87F20", Slot = "27")]
	public string KDCCCAAPNFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E876C0", Offset = "0x6E85EC0", VA = "0x186E876C0", Slot = "28")]
	public GHJKEMFHLHG GMNLFBOKDGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E86220", Offset = "0x6E84A20", VA = "0x186E86220", Slot = "29")]
	public GHJKEMFHLHG CGMAJAAILCJ(int LGMAPJFAAAE, string MAPAAJDLNGI, string FDDLGGHNBKN, string AJHPBFHBCEG, string LPNFOGBFJIN, DateTime GAALHMHLABJ, Action<GIJMEBMJNGF> ICDGJCAABPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E86BC0", Offset = "0x6E853C0", VA = "0x186E86BC0", Slot = "30")]
	public GHJKEMFHLHG DHKGBGKPEBP(string MAPAAJDLNGI, string FDDLGGHNBKN, params int[] BBHBJHNGLGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E878F0", Offset = "0x6E860F0", VA = "0x186E878F0", Slot = "31")]
	public bool IKDICAIBAHK(out int? PLCHDJPLMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E874A0", Offset = "0x6E85CA0", VA = "0x186E874A0", Slot = "32")]
	public bool FFFNEAEMDMB(out DBAPAMFAIFC CMHCDHAGKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E86750", Offset = "0x6E84F50", VA = "0x186E86750")]
	private GHJKEMFHLHG DDANCKBJFCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E866E0", Offset = "0x6E84EE0", VA = "0x186E866E0")]
	private void CMJHLKMCPPG(DBAPAMFAIFC CGMCKIOHEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E88100", Offset = "0x6E86900", VA = "0x186E88100")]
	private void MOIBJFPAFIE(DBAPAMFAIFC CGMCKIOHEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E87560", Offset = "0x6E85D60", VA = "0x186E87560")]
	private void FOIOIIMMCBD(string MAPAAJDLNGI, string JJAONHLCBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E86D80", Offset = "0x6E85580", VA = "0x186E86D80")]
	private void DJKLENDGKLJ(string MAPAAJDLNGI, string JJAONHLCBBE, string IHPNBKNCNHD, string HFINBEOGJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F43B0", Offset = "0x7F2BB0", VA = "0x1807F43B0")]
	private void CEHGIPJOGIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8A4540", Offset = "0x8A2D40", VA = "0x1808A4540")]
	[CompilerGenerated]
	private void GPEAOLMHAEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OMDONAKEBDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string IBFGJJJMLKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string PLGKHPNPPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string JOINCANAKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<DBAPAMFAIFC> HADAABAGHCI;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GHJKEMFHLHG BDGHBBNODAD();

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GHJKEMFHLHG DDANCKBJFCD();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OBLAKAMHMBH(bool CCDFBDLEDKM);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DBAPAMFAIFC KGCMFNHGMML();
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
public interface BCLLGNELFCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<DBAPAMFAIFC> HADAABAGHCI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event CBFIAEAINOG KCCIFFCFBJG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event IAGNDLIBHIN LOCBBOHIAGF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DBAPAMFAIFC KGCMFNHGMML();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KPLLHALGBGK(string FDDLGGHNBKN);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GHJKEMFHLHG CGMAJAAILCJ(int LGMAPJFAAAE, string MAPAAJDLNGI, string FDDLGGHNBKN, string AJHPBFHBCEG, string LPNFOGBFJIN, DateTime GAALHMHLABJ, [Optional] Action<GIJMEBMJNGF> ICDGJCAABPC);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GHJKEMFHLHG DHKGBGKPEBP(string MAPAAJDLNGI, string FDDLGGHNBKN, params int[] BBHBJHNGLGL);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EMJDHPAKFAD(params int[] BBHBJHNGLGL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JLKAJODLHKD
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float NAMBKIFOFGG = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<DBAPAMFAIFC> HADAABAGHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CBFIAEAINOG KCCIFFCFBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IAGNDLIBHIN LOCBBOHIAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private FLNCMNDDFJJ GCNEGKFNLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NEFMIGGCAHA OPBOGHOHKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MBGNMJJGJPO HONOIPDBDEI;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NEFMIGGCAHA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GKBAGGAGAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int GDBLMHGPFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime? EIOBBOMFEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ACFLGLMHDEN]
internal class OKHNCLADIAM : HEGENOHPANF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KKKCILPKONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OKHNCLADIAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DBAPAMFAIFC notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NEFMIGGCAHA OPBOGHOHKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private DBAPAMFAIFC CMHCDHAGKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? MBNPNFPFFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> HGMMOEHBBFD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event OOFNJCEHIBF HADAABAGHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6E891B0", Offset = "0x6E879B0", VA = "0x186E891B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E88F80", Offset = "0x6E87780", VA = "0x186E88F80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event FNPDKAKJBFD JMEABMLFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6E89640", Offset = "0x6E87E40", VA = "0x186E89640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E895A0", Offset = "0x6E87DA0", VA = "0x186E895A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E89020", Offset = "0x6E87820", VA = "0x186E89020")]
	[NFOBBCLLFPP(BGPNPCEMJLD.None)]
	private static void EBMOAACPAFK(LIFDIPFHEEA KEMGJJIKGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E896E0", Offset = "0x6E87EE0", VA = "0x186E896E0")]
	[Preserve]
	internal OKHNCLADIAM([JHPEMCNOMHI(null)] NEFMIGGCAHA OPBOGHOHKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E89380", Offset = "0x6E87B80", VA = "0x186E89380", Slot = "9")]
	public bool IKDICAIBAHK(out int? PLCHDJPLMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E89160", Offset = "0x6E87960", VA = "0x186E89160", Slot = "10")]
	public bool FFFNEAEMDMB(out DBAPAMFAIFC KFKNJOJAAFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E89450", Offset = "0x6E87C50", VA = "0x186E89450", Slot = "11")]
	public void JOLGLFLIFHL(DBAPAMFAIFC CGMCKIOHEJM, PlatformNotificationHandlerContext HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E893B0", Offset = "0x6E87BB0", VA = "0x186E893B0", Slot = "8")]
	public void JIOHGFADAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E89250", Offset = "0x6E87A50", VA = "0x186E89250")]
	private void HMOJPPLBAIN(DBAPAMFAIFC CGMCKIOHEJM, PlatformNotificationHandlerContext HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E89090", Offset = "0x6E87890", VA = "0x186E89090")]
	private void EGAFJDECLGK(DBAPAMFAIFC LFJLJMEMPKJ, PlatformNotificationHandlerContext HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E89190", Offset = "0x6E87990", VA = "0x186E89190")]
	[CompilerGenerated]
	private void GHFFDJDJENL(ref KKKCILPKONF P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GIJMEBMJNGF
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int? PLCHDJPLMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DateTime NMFMOMBNMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string FLLIFFEHOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string FBHNOKHMJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PlatformNotificationType PAKKDNIJPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B70", Offset = "0x8E7370", VA = "0x1808E8B70")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string MAPAAJDLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string OBMIKAHLCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string FDDLGGHNBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string BJFFMOOKJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string IGFKLOHOMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED0", Offset = "0x8A86D0", VA = "0x1808A9ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? BNMBODCJOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xBB0D00", Offset = "0xBAF500", VA = "0x180BB0D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int? BCAFFMKJCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7360", VA = "0x1808E8B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public long? BPDKBEPFHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA75710", Offset = "0xA73F10", VA = "0x180A75710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public long? AFGKPOPONBN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2B0", Offset = "0xCF9AB0", VA = "0x180CFB2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xFCA1B0", Offset = "0xFC89B0", VA = "0x180FCA1B0")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HOLFLNPLEBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string NONAMBPOGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DBAPAMFAIFC DIOMGPDFPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event EKNDJOJMJLM JPPHEFNDOEA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event KOCBHAEJMKE BGBKEAGIMBP;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event FLNCMNDDFJJ GCNEGKFNLPJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event OOFNJCEHIBF HADAABAGHCI;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EKPLAHNPPCE AADPNHEIFAB;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event CBFIAEAINOG EJNMNCKAFNB;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event IAGNDLIBHIN PPLAHHNJELH;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event FNPDKAKJBFD JMEABMLFLEF;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action ICNCMGJMAHM;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BDCEDMLOOPD();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JIOHGFADAGG();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	DKPBNBLKHOO DKDCPEBGMDC();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string KDCCCAAPNFB();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GHJKEMFHLHG GMNLFBOKDGJ();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GHJKEMFHLHG CGMAJAAILCJ(int LGMAPJFAAAE, string MAPAAJDLNGI, string FDDLGGHNBKN, string AJHPBFHBCEG, string LPNFOGBFJIN, DateTime GAALHMHLABJ, Action<GIJMEBMJNGF> ICDGJCAABPC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GHJKEMFHLHG DHKGBGKPEBP(string MAPAAJDLNGI, string FDDLGGHNBKN, params int[] BBHBJHNGLGL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IKDICAIBAHK(out int? PLCHDJPLMNC);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool FFFNEAEMDMB(out DBAPAMFAIFC CMHCDHAGKFC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HEGENOHPANF
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event OOFNJCEHIBF HADAABAGHCI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event FNPDKAKJBFD JMEABMLFLEF;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIOHGFADAGG();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IKDICAIBAHK(out int? PLCHDJPLMNC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FFFNEAEMDMB(out DBAPAMFAIFC CMHCDHAGKFC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JOLGLFLIFHL(DBAPAMFAIFC CGMCKIOHEJM, PlatformNotificationHandlerContext HNBDDLBIIOF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PPHLCPEIBHJ
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event FLNCMNDDFJJ GCNEGKFNLPJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DKPBNBLKHOO DKDCPEBGMDC();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GHJKEMFHLHG GMNLFBOKDGJ();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string KDCCCAAPNFB();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<DBAPAMFAIFC> HFFACDAEFJK();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCLNNIHGKMG();
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
