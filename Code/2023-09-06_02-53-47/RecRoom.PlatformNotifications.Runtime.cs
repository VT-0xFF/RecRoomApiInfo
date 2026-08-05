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
public class PJIGNLCJLBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int CGJJNHKKONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType BJFLOLKBEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public NFIGCLLMHLF APMPAEEBFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool KMBGAKEJKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string MKMLHFPALFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string IKBAGGBCBGP;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FBDMPHFFPHN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MCAMMDNOIJN? JPIMIBGECEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, MFBKDKPGMNP<bool>> MAEAKDDEKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MCAMMDNOIJN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MNCFBEJIMIP(bool HCGGIGOJKEA, string IACLLOOABOM);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void LBDKEKJKLNC(bool HCGGIGOJKEA, string IACLLOOABOM, MCAMMDNOIJN EEEINLJLIEK, string DCEGGIJLHGI, string LIKPJKBNMFC);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void ABJCCNMOJFJ();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void MDOIPNGJOPO(PJIGNLCJLBM NCJIPAGLNIB, PlatformNotificationHandlerContext MFPELEJLJLD);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void JIPNBKHLBEM(PJIGNLCJLBM NCJIPAGLNIB);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void NAMMMJHJDKH(PJIGNLCJLBM NCJIPAGLNIB, PlatformNotificationHandlerContext MFPELEJLJLD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void PMAJHHAJNNM(string EGPADHJOCOL, string GGKDCMPBAGB, string FNHOMDHFFJE, string EHBFGJOIAJO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void LJEDFEPLJAG(string EGPADHJOCOL, string GGKDCMPBAGB);
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
[ONEJPGBFBKC]
internal class PLHMIGHPMFE : LCGJMEEMNHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class EPADLKPNKGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public PLHMIGHPMFE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EPADLKPNKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		internal void CDDAMCMDCAE(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F53A30", Offset = "0x6F52030", VA = "0x186F53A30")]
		internal void GPMOFKJMAJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class COIBEOJBFOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PLHMIGHPMFE <>4__this;

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
		public Action<NFIGCLLMHLF> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public COIBEOJBFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F538E0", Offset = "0x6F51EE0", VA = "0x186F538E0")]
		internal void BJJPDOLNAAH(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class HEPEEMNBMBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PLHMIGHPMFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MCAMMDNOIJN authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HEPEEMNBMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		internal void KIGOFEPIOKF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F53B60", Offset = "0x6F52160", VA = "0x186F53B60")]
		internal void PCOLLLPAPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F53A70", Offset = "0x6F52070", VA = "0x186F53A70")]
		internal void FDLDLOAJHLE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> IJEAAOMBFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MBABGJIDAOF BMJFILAMPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private LEBPBHLIHLL MCLAIFDOKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private MIKNIPGAKMA NJLFHMCOOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly BDDJOJOOHBB PJLGPFPEPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly EGAMGCEGNED PGKMBMNPIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HKNPBIHGOEE KHHJPAGDDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly FBDMPHFFPHN IJNIMHBHPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool CGDAFPLGBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool BDJJLMCENAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> EMNCNDACOLE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string DFFMCKENOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9383D0", Offset = "0x9369D0", VA = "0x1809383D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string GOCJCCDHCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F56100", Offset = "0x6F54700", VA = "0x186F56100", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PJIGNLCJLBM MGLNHMDPEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F56A10", Offset = "0x6F55010", VA = "0x186F56A10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MNCFBEJIMIP PIMCIJPCEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F54EB0", Offset = "0x6F534B0", VA = "0x186F54EB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F54D70", Offset = "0x6F53370", VA = "0x186F54D70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LBDKEKJKLNC JMNFGNAONGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F56B50", Offset = "0x6F55150", VA = "0x186F56B50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F558E0", Offset = "0x6F53EE0", VA = "0x186F558E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ABJCCNMOJFJ MOHINKFCKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F54E10", Offset = "0x6F53410", VA = "0x186F54E10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F54F50", Offset = "0x6F53550", VA = "0x186F54F50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MDOIPNGJOPO KDCEJAJKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F55C20", Offset = "0x6F54220", VA = "0x186F55C20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F55B80", Offset = "0x6F54180", VA = "0x186F55B80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JIPNBKHLBEM KGGACIEFJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F56AB0", Offset = "0x6F550B0", VA = "0x186F56AB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F55F70", Offset = "0x6F54570", VA = "0x186F55F70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NAMMMJHJDKH FNFMMNCBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F55D10", Offset = "0x6F54310", VA = "0x186F55D10", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F54970", Offset = "0x6F52F70", VA = "0x186F54970", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event PMAJHHAJNNM HENEOPLJKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F56870", Offset = "0x6F54E70", VA = "0x186F56870", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F56710", Offset = "0x6F54D10", VA = "0x186F56710", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event LJEDFEPLJAG EJMCCBEIMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F548D0", Offset = "0x6F52ED0", VA = "0x186F548D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F55DB0", Offset = "0x6F543B0", VA = "0x186F55DB0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action KCKNKOLONFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F567D0", Offset = "0x6F54DD0", VA = "0x186F567D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F541E0", Offset = "0x6F527E0", VA = "0x186F541E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F56010", Offset = "0x6F54610", VA = "0x186F56010")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F56E20", Offset = "0x6F55420", VA = "0x186F56E20")]
	[Preserve]
	internal PLHMIGHPMFE([BBBJPGKHPHG(null)] BDDJOJOOHBB PJLGPFPEPJO, [BBBJPGKHPHG(null)] HKNPBIHGOEE KHHJPAGDDBB, [BBBJPGKHPHG(null)] EGAMGCEGNED PGKMBMNPIGA, [BBBJPGKHPHG(null)] FBDMPHFFPHN IGLCGHPCAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F55460", Offset = "0x6F53A60", VA = "0x186F55460", Slot = "24")]
	public void GMAKAKECEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F54860", Offset = "0x6F52E60", VA = "0x186F54860", Slot = "25")]
	public void CEKCPAOGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F56650", Offset = "0x6F54C50", VA = "0x186F56650")]
	private void MMKIOPGFCGN(bool GHGOAJFOICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F56420", Offset = "0x6F54A20", VA = "0x186F56420")]
	private void MLMFOMPMPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F55980", Offset = "0x6F53F80", VA = "0x186F55980")]
	private void HJAEEGDLPHI(PJIGNLCJLBM NCJIPAGLNIB, PlatformNotificationHandlerContext MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F567B0", Offset = "0x6F54DB0", VA = "0x186F567B0")]
	private void NIGLAHMIDGI(PJIGNLCJLBM NCJIPAGLNIB, PlatformNotificationHandlerContext MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F54A10", Offset = "0x6F53010", VA = "0x186F54A10", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F546C0", Offset = "0x6F52CC0", VA = "0x186F546C0", Slot = "35")]
	public void BHHOEJBAGLB(MBABGJIDAOF AAADIAJNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F56150", Offset = "0x6F54750", VA = "0x186F56150", Slot = "36")]
	public void MDHDOEEOHGJ(LEBPBHLIHLL AAADIAJNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F55640", Offset = "0x6F53C40", VA = "0x186F55640", Slot = "37")]
	public void GPJPEIKFFOH(MIKNIPGAKMA AAADIAJNHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F56910", Offset = "0x6F54F10", VA = "0x186F56910", Slot = "26")]
	public MCAMMDNOIJN OBJOIONNIIL()
	{
		return default(MCAMMDNOIJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F55CC0", Offset = "0x6F542C0", VA = "0x186F55CC0", Slot = "27")]
	public string IMBLIPCHMPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F56BF0", Offset = "0x6F551F0", VA = "0x186F56BF0", Slot = "28")]
	public HHGLIBCDIDA PMLLPOFADII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F542A0", Offset = "0x6F528A0", VA = "0x186F542A0", Slot = "29")]
	public HHGLIBCDIDA BDIPEBGHPHP(int PKFCGPNEKHF, string EGPADHJOCOL, string ILLGCEENAAK, string BHLGPCEAOGF, string OHGELPFECPD, DateTime PMAJCJJLIBC, Action<NFIGCLLMHLF> NBIAAMKJJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F55E50", Offset = "0x6F54450", VA = "0x186F55E50", Slot = "30")]
	public HHGLIBCDIDA JMAJMJMPKDM(string EGPADHJOCOL, string ILLGCEENAAK, params int[] DFPPFAGJCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F55AC0", Offset = "0x6F540C0", VA = "0x186F55AC0", Slot = "31")]
	public bool HJDNLAMKCDN(out int? JKKKELOONBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F54CB0", Offset = "0x6F532B0", VA = "0x186F54CB0", Slot = "32")]
	public bool EAPCIANGNPE(out PJIGNLCJLBM DAALNPKJLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F54FF0", Offset = "0x6F535F0", VA = "0x186F54FF0")]
	private HHGLIBCDIDA GEFJBCDJFKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F547F0", Offset = "0x6F52DF0", VA = "0x186F547F0")]
	private void BJDFGICIOLM(PJIGNLCJLBM NCJIPAGLNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F56080", Offset = "0x6F54680", VA = "0x186F56080")]
	private void KPFJIKBLFKD(PJIGNLCJLBM NCJIPAGLNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F56A90", Offset = "0x6F55090", VA = "0x186F56A90")]
	private void PFIMIJBDMGE(string EGPADHJOCOL, string GGKDCMPBAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F54280", Offset = "0x6F52880", VA = "0x186F54280")]
	private void ALJIFNNAHKG(string EGPADHJOCOL, string GGKDCMPBAGB, string FNHOMDHFFJE, string EHBFGJOIAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA48110", Offset = "0xA46710", VA = "0x180A48110")]
	private void OBHFBBNNOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x924E00", Offset = "0x923400", VA = "0x180924E00")]
	[CompilerGenerated]
	private void IEJDFKAKAMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MIKNIPGAKMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string LGBFOJINIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string LMMDFNIIMME
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string DGGGBEAGMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<PJIGNLCJLBM> KDCEJAJKLPL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HHGLIBCDIDA IEAKACNFJBC();

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HHGLIBCDIDA GEFJBCDJFKB();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GBGCDEJDDKA(bool LBOEBKGMKFC);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PJIGNLCJLBM PEKDMGBKBAF();
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
public interface LEBPBHLIHLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<PJIGNLCJLBM> KDCEJAJKLPL;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event PMAJHHAJNNM FOPGKHMEDKK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event LJEDFEPLJAG CBEANLMNDFP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PJIGNLCJLBM PEKDMGBKBAF();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BALCHCHJEHF(string ILLGCEENAAK);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HHGLIBCDIDA BDIPEBGHPHP(int PKFCGPNEKHF, string EGPADHJOCOL, string ILLGCEENAAK, string BHLGPCEAOGF, string OHGELPFECPD, DateTime PMAJCJJLIBC, [Optional] Action<NFIGCLLMHLF> NBIAAMKJJGM);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HHGLIBCDIDA JMAJMJMPKDM(string EGPADHJOCOL, string ILLGCEENAAK, params int[] DFPPFAGJCIH);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BKAABDDDECN(params int[] DFPPFAGJCIH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class APMCAFEFDHI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float JCJCPKIIILA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<PJIGNLCJLBM> KDCEJAJKLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PMAJHHAJNNM FOPGKHMEDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LJEDFEPLJAG CBEANLMNDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ABJCCNMOJFJ MOHINKFCKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HKNPBIHGOEE KHHJPAGDDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly CDNNNIJHPJN EBLGJABNHNN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HKNPBIHGOEE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HNPIFBPLGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int LAFOHILENNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime? NAPKCOHNOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ONEJPGBFBKC]
internal class CKNOJAFOFCG : BDDJOJOOHBB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DPEJEDDFOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CKNOJAFOFCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public PJIGNLCJLBM notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HKNPBIHGOEE KHHJPAGDDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private PJIGNLCJLBM DAALNPKJLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? AKOPJEOCMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> AKOKAPGNLGN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event MDOIPNGJOPO KDCEJAJKLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F53470", Offset = "0x6F51A70", VA = "0x186F53470", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F533D0", Offset = "0x6F519D0", VA = "0x186F533D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event NAMMMJHJDKH FNFMMNCBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F53510", Offset = "0x6F51B10", VA = "0x186F53510", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F531A0", Offset = "0x6F517A0", VA = "0x186F531A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F53700", Offset = "0x6F51D00", VA = "0x186F53700")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F53840", Offset = "0x6F51E40", VA = "0x186F53840")]
	[Preserve]
	internal CKNOJAFOFCG([BBBJPGKHPHG(null)] HKNPBIHGOEE KHHJPAGDDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F533A0", Offset = "0x6F519A0", VA = "0x186F533A0", Slot = "9")]
	public bool HJDNLAMKCDN(out int? JKKKELOONBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F53240", Offset = "0x6F51840", VA = "0x186F53240", Slot = "10")]
	public bool EAPCIANGNPE(out PJIGNLCJLBM HCEPPIGFBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F535B0", Offset = "0x6F51BB0", VA = "0x186F535B0", Slot = "11")]
	public void JBIEDCJFLLL(PJIGNLCJLBM NCJIPAGLNIB, PlatformNotificationHandlerContext MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F53080", Offset = "0x6F51680", VA = "0x186F53080", Slot = "8")]
	public void CEKCPAOGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F53270", Offset = "0x6F51870", VA = "0x186F53270")]
	private void FBOCKBNKBED(PJIGNLCJLBM NCJIPAGLNIB, PlatformNotificationHandlerContext MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F53770", Offset = "0x6F51D70", VA = "0x186F53770")]
	private void KKPOLNIMHIM(PJIGNLCJLBM PLIPPMMCJOG, PlatformNotificationHandlerContext MFPELEJLJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F53180", Offset = "0x6F51780", VA = "0x186F53180")]
	[CompilerGenerated]
	private void DIDEDIBGLLI(ref DPEJEDDFOFH P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NFIGCLLMHLF
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int? JKKKELOONBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DateTime MCGFPJIKBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string IBDILFGJEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string MLFJEDLAIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PlatformNotificationType JNDKACNDKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BE0", Offset = "0x9A81E0", VA = "0x1809A9BE0")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string EGPADHJOCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string FOGPDGHFMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string ILLGCEENAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string NKICOIJOKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string BMJFBAOCCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? GBNBFKENEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xE3A7C0", Offset = "0xE38DC0", VA = "0x180E3A7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int? HCBFBOFLOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public long? FPJHBGHDILM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xEF1EC0", Offset = "0xEF04C0", VA = "0x180EF1EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public long? AHLGFJPMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xEDBDC0", Offset = "0xEDA3C0", VA = "0x180EDBDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x190A610", Offset = "0x1908C10", VA = "0x18190A610")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LCGJMEEMNHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string GOCJCCDHCMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PJIGNLCJLBM MGLNHMDPEON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event MNCFBEJIMIP PIMCIJPCEMD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event LBDKEKJKLNC JMNFGNAONGN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event ABJCCNMOJFJ MOHINKFCKIF;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event MDOIPNGJOPO KDCEJAJKLPL;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event JIPNBKHLBEM KGGACIEFJLF;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PMAJHHAJNNM HENEOPLJKKK;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event LJEDFEPLJAG EJMCCBEIMFI;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event NAMMMJHJDKH FNFMMNCBJGO;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action KCKNKOLONFG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GMAKAKECEDK();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CEKCPAOGHNK();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	MCAMMDNOIJN OBJOIONNIIL();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string IMBLIPCHMPB();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	HHGLIBCDIDA PMLLPOFADII();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HHGLIBCDIDA BDIPEBGHPHP(int PKFCGPNEKHF, string EGPADHJOCOL, string ILLGCEENAAK, string BHLGPCEAOGF, string OHGELPFECPD, DateTime PMAJCJJLIBC, Action<NFIGCLLMHLF> NBIAAMKJJGM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HHGLIBCDIDA JMAJMJMPKDM(string EGPADHJOCOL, string ILLGCEENAAK, params int[] DFPPFAGJCIH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HJDNLAMKCDN(out int? JKKKELOONBO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool EAPCIANGNPE(out PJIGNLCJLBM DAALNPKJLHP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BDDJOJOOHBB
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event MDOIPNGJOPO KDCEJAJKLPL;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event NAMMMJHJDKH FNFMMNCBJGO;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CEKCPAOGHNK();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HJDNLAMKCDN(out int? JKKKELOONBO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EAPCIANGNPE(out PJIGNLCJLBM DAALNPKJLHP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBIEDCJFLLL(PJIGNLCJLBM NCJIPAGLNIB, PlatformNotificationHandlerContext MFPELEJLJLD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MBABGJIDAOF
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event ABJCCNMOJFJ MOHINKFCKIF;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCAMMDNOIJN OBJOIONNIIL();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HHGLIBCDIDA PMLLPOFADII();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string IMBLIPCHMPB();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<PJIGNLCJLBM> FJMPEJNPEAB();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMNBKLHFMCG();
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
