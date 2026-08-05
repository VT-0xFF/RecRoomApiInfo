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
public class FMJJIDIAGGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int JOKFKKAHCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PlatformNotificationType GLGPHBABLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public AJBFGPDMFNA JODGOPKIPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool GDMLCFLHLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string HMJNGGMNJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string OJKBJFIDAFB;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GHDKLFINIHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LOCBBGIKEMI? EPCOGDKHJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<string, OOMFLHAHLDK<bool>> EJCBNBDHPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LOCBBGIKEMI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Undetermined,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Authorized,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Denied
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PGHMEACPFEK(bool KECICGODINP, string EABGHJKOGFH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void EGELLPEPLBN(bool KECICGODINP, string EABGHJKOGFH, LOCBBGIKEMI LGKEPFFCGFI, string FDCOCHLAHJD, string JLCAHLGGIAA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void OIFPCJFMIBJ();
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void JOBJPHCOKKF(FMJJIDIAGGC JEFCJNKKLCB, PlatformNotificationHandlerContext JDFBABENAGD);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void NNJELLICDAG(FMJJIDIAGGC JEFCJNKKLCB);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void MCEMOCKFPDC(FMJJIDIAGGC JEFCJNKKLCB, PlatformNotificationHandlerContext JDFBABENAGD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate void IAEMHLJLNLP(string DDFMJIOEBHH, string CADFJJPBALK, string PBMGONOKEKC, string FKKPCFIHDOA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GFOCAIEDCPH(string DDFMJIOEBHH, string CADFJJPBALK);
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
[FDHBNKNBNCC]
internal class NJEKCGEMJKD : HJIHAFGLKBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DMLAMHAMDCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string initializationErrorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NJEKCGEMJKD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DMLAMHAMDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		internal void JPAOKEKOIOJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7B80", Offset = "0x6ED6D80", VA = "0x186ED7B80")]
		internal void LDHKNFJGJAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IGEIHAKENBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NJEKCGEMJKD <>4__this;

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
		public Action<AJBFGPDMFNA> setDataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IGEIHAKENBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8980", Offset = "0x6ED7B80", VA = "0x186ED8980")]
		internal void BMNJBMLFOBE(bool isAllowed)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EFBHIDIMLAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string errorMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NJEKCGEMJKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LOCBBGIKEMI authorizationStatus;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EFBHIDIMLAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		internal void MJGFKOKEKIF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED83C0", Offset = "0x6ED75C0", VA = "0x186ED83C0")]
		internal void CMKCJAIHAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8480", Offset = "0x6ED7680", VA = "0x186ED8480")]
		internal void NAHJJPJOMMC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<string> MKHOCDADNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private JEPFHKMFKEC JJHJCAGMICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private MFIENBHGMNN LCLJDBJMLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private EKIBBOHHPIH HHIBBFDKPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CLDJFBKAMEJ CNEEHPPMFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CMEIMDNBBNE IJIIHDGIHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly PEBNPMEFJBI AOPMJNMMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly GHDKLFINIHK DCFMFFFLCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool GLBAMCHFMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool DDGIMJMKNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly HashSet<string> BPEFBCLMLIL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string EFJHJGBMJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string ELEHPFOFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA790", Offset = "0x6ED9990", VA = "0x186EDA790", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FMJJIDIAGGC HHOOILODNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAD50", Offset = "0x6ED9F50", VA = "0x186EDAD50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PGHMEACPFEK LHOFGJPFEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA9C0", Offset = "0x6ED9BC0", VA = "0x186EDA9C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAFB0", Offset = "0x6EDA1B0", VA = "0x186EDAFB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EGELLPEPLBN NHIBIFPMAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA450", Offset = "0x6ED9650", VA = "0x186EDA450", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA4F0", Offset = "0x6ED96F0", VA = "0x186EDA4F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OIFPCJFMIBJ IALCGIFBHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8D20", Offset = "0x6ED7F20", VA = "0x186ED8D20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAC10", Offset = "0x6ED9E10", VA = "0x186EDAC10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JOBJPHCOKKF EJHIFCNFJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA6F0", Offset = "0x6ED98F0", VA = "0x186EDA6F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EDACB0", Offset = "0x6ED9EB0", VA = "0x186EDACB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NNJELLICDAG ANPBJFNAJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA180", Offset = "0x6ED9380", VA = "0x186EDA180", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAA60", Offset = "0x6ED9C60", VA = "0x186EDAA60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MCEMOCKFPDC PIFCMJEBOBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA220", Offset = "0x6ED9420", VA = "0x186EDA220", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA2C0", Offset = "0x6ED94C0", VA = "0x186EDA2C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event IAEMHLJLNLP MHLKFHGJGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB540", Offset = "0x6EDA740", VA = "0x186EDB540", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA3B0", Offset = "0x6ED95B0", VA = "0x186EDA3B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GFOCAIEDCPH OBFNLOPEBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA650", Offset = "0x6ED9850", VA = "0x186EDA650", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAB70", Offset = "0x6ED9D70", VA = "0x186EDAB70", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action NGMOGIBPIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA5B0", Offset = "0x6ED97B0", VA = "0x186EDA5B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6EDADD0", Offset = "0x6ED9FD0", VA = "0x186EDADD0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8E80", Offset = "0x6ED8080", VA = "0x186ED8E80")]
	[GKCPJLBLCDF(EHLDMJJGFKP.None)]
	private static void CBJFBKKBGCJ(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB830", Offset = "0x6EDAA30", VA = "0x186EDB830")]
	[Preserve]
	internal NJEKCGEMJKD([NDGONEEEGIA(null)] CLDJFBKAMEJ CNEEHPPMFEO, [NDGONEEEGIA(null)] PEBNPMEFJBI AOPMJNMMFFM, [NDGONEEEGIA(null)] CMEIMDNBBNE IJIIHDGIHGJ, [NDGONEEEGIA(null)] GHDKLFINIHK CPPBBBCKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA7E0", Offset = "0x6ED99E0", VA = "0x186EDA7E0", Slot = "24")]
	public void KCEHONPEIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8BF0", Offset = "0x6ED7DF0", VA = "0x186ED8BF0", Slot = "25")]
	public void AADAONEIPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8C60", Offset = "0x6ED7E60", VA = "0x186ED8C60")]
	private void ABCEJIIAFOF(bool DGHBDNCEDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB5E0", Offset = "0x6EDA7E0", VA = "0x186EDB5E0")]
	private void ONCGGDCEEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAE70", Offset = "0x6EDA070", VA = "0x186EDAE70")]
	private void NLJIFPICABI(FMJJIDIAGGC JEFCJNKKLCB, PlatformNotificationHandlerContext JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA590", Offset = "0x6ED9790", VA = "0x186EDA590")]
	private void IHIPLOENDCN(FMJJIDIAGGC JEFCJNKKLCB, PlatformNotificationHandlerContext JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9790", Offset = "0x6ED8990", VA = "0x186ED9790", Slot = "33")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9A50", Offset = "0x6ED8C50", VA = "0x186ED9A50", Slot = "35")]
	public void ENBJELLMHAI(JEPFHKMFKEC FHLHCPACODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9EB0", Offset = "0x6ED90B0", VA = "0x186ED9EB0", Slot = "36")]
	public void GBBKMIJFGFF(MFIENBHGMNN FHLHCPACODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8EF0", Offset = "0x6ED80F0", VA = "0x186ED8EF0", Slot = "37")]
	public void CEEDCPPOLDA(EKIBBOHHPIH FHLHCPACODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9DB0", Offset = "0x6ED8FB0", VA = "0x186ED9DB0", Slot = "26")]
	public LOCBBGIKEMI FKCGLLJHAAK()
	{
		return default(LOCBBGIKEMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA360", Offset = "0x6ED9560", VA = "0x186EDA360", Slot = "27")]
	public string GMOHCFCBPIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9B80", Offset = "0x6ED8D80", VA = "0x186ED9B80", Slot = "28")]
	public GIOBGNHJLID FCOHHGAFHFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9250", Offset = "0x6ED8450", VA = "0x186ED9250", Slot = "29")]
	public GIOBGNHJLID DMBCAGAAJID(int BHGKMJBGHFK, string DDFMJIOEBHH, string LPDDCEMOGCP, string CPNIJHHHHFN, string CIFIEGNCMNA, DateTime AFBDJOKEPAC, Action<AJBFGPDMFNA> LJDGLEJKCFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9670", Offset = "0x6ED8870", VA = "0x186ED9670", Slot = "30")]
	public GIOBGNHJLID DNBJGFLJBCP(string DDFMJIOEBHH, string LPDDCEMOGCP, params int[] DAKPHENPPLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9190", Offset = "0x6ED8390", VA = "0x186ED9190", Slot = "31")]
	public bool CLMNPGBILBE(out int? EEKAMFMHHFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8DC0", Offset = "0x6ED7FC0", VA = "0x186ED8DC0", Slot = "32")]
	public bool BIBFKIBPGHH(out FMJJIDIAGGC MICNPNMDMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB050", Offset = "0x6EDA250", VA = "0x186EDB050")]
	private GIOBGNHJLID OHNAMJMPBJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAB00", Offset = "0x6ED9D00", VA = "0x186EDAB00")]
	private void LCDFFAANKAI(FMJJIDIAGGC JEFCJNKKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB4C0", Offset = "0x6EDA6C0", VA = "0x186EDB4C0")]
	private void OJBNDHNGLHI(FMJJIDIAGGC JEFCJNKKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9A30", Offset = "0x6ED8C30", VA = "0x186ED9A30")]
	private void EEFHCEGLDDN(string DDFMJIOEBHH, string CADFJJPBALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB810", Offset = "0x6EDAA10", VA = "0x186EDB810")]
	private void PGJCLKABFAM(string DDFMJIOEBHH, string CADFJJPBALK, string PBMGONOKEKC, string FKKPCFIHDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3D0", Offset = "0x8BE5D0", VA = "0x1808BF3D0")]
	private void BNFKLJDJJKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x98ADE0", Offset = "0x989FE0", VA = "0x18098ADE0")]
	[CompilerGenerated]
	private void DIGNCAPEEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EKIBBOHHPIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string NDNCCEAFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string GDGCIDKGFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string JDDJPKHEHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<FMJJIDIAGGC> EJHIFCNFJMK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GIOBGNHJLID BEBGBLHONFO();

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GIOBGNHJLID OHNAMJMPBJM();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BAAHPMPDADI(bool HEACEOCOHBA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FMJJIDIAGGC BPDOFLKAFBL();
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
public interface MFIENBHGMNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FMJJIDIAGGC> EJHIFCNFJMK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event IAEMHLJLNLP DBBGHHKDELG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event GFOCAIEDCPH GBABAPNMPGA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FMJJIDIAGGC BPDOFLKAFBL();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ABCBAPHDDJG(string LPDDCEMOGCP);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GIOBGNHJLID DMBCAGAAJID(int BHGKMJBGHFK, string DDFMJIOEBHH, string LPDDCEMOGCP, string CPNIJHHHHFN, string CIFIEGNCMNA, DateTime AFBDJOKEPAC, [Optional] Action<AJBFGPDMFNA> LJDGLEJKCFJ);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GIOBGNHJLID DNBJGFLJBCP(string DDFMJIOEBHH, string LPDDCEMOGCP, params int[] DAKPHENPPLA);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ACEPMOIGLCE(params int[] DAKPHENPPLA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HGFELHOJLLG
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private const float EMHBCDHCFJF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<FMJJIDIAGGC> EJHIFCNFJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IAEMHLJLNLP DBBGHHKDELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GFOCAIEDCPH GBABAPNMPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private OIFPCJFMIBJ IALCGIFBHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PEBNPMEFJBI AOPMJNMMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly PEMCPFGJHKJ DIFFCPFJEFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PEBNPMEFJBI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KFOHAHLAOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int BJFMAEBNMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime? EHOCPGNFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[FDHBNKNBNCC]
internal class EEALMICADBA : CLDJFBKAMEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct ENMHCAKKFBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public EEALMICADBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FMJJIDIAGGC notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PlatformNotificationHandlerContext context;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PEBNPMEFJBI AOPMJNMMFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private FMJJIDIAGGC MICNPNMDMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PlatformNotificationHandlerContext? ADADLBFFBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HashSet<string> NNOACCPALKN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event JOBJPHCOKKF EJHIFCNFJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6ED81E0", Offset = "0x6ED73E0", VA = "0x186ED81E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8280", Offset = "0x6ED7480", VA = "0x186ED8280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event MCEMOCKFPDC PIFCMJEBOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6ED80A0", Offset = "0x6ED72A0", VA = "0x186ED80A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8140", Offset = "0x6ED7340", VA = "0x186ED8140", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7F30", Offset = "0x6ED7130", VA = "0x186ED7F30")]
	[GKCPJLBLCDF(EHLDMJJGFKP.None)]
	private static void CBJFBKKBGCJ(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8320", Offset = "0x6ED7520", VA = "0x186ED8320")]
	[Preserve]
	internal EEALMICADBA([NDGONEEEGIA(null)] PEBNPMEFJBI AOPMJNMMFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7FA0", Offset = "0x6ED71A0", VA = "0x186ED7FA0", Slot = "9")]
	public bool CLMNPGBILBE(out int? EEKAMFMHHFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7DB0", Offset = "0x6ED6FB0", VA = "0x186ED7DB0", Slot = "10")]
	public bool BIBFKIBPGHH(out FMJJIDIAGGC KPJLLCNJDEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7DE0", Offset = "0x6ED6FE0", VA = "0x186ED7DE0", Slot = "11")]
	public void BKMNLNIGCAE(FMJJIDIAGGC JEFCJNKKLCB, PlatformNotificationHandlerContext JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7BC0", Offset = "0x6ED6DC0", VA = "0x186ED7BC0", Slot = "8")]
	public void AADAONEIPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7C60", Offset = "0x6ED6E60", VA = "0x186ED7C60")]
	private void AHGHKDFACLL(FMJJIDIAGGC JEFCJNKKLCB, PlatformNotificationHandlerContext JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7FD0", Offset = "0x6ED71D0", VA = "0x186ED7FD0")]
	private void ELDLHKNLHPO(FMJJIDIAGGC FDCELNLKDIK, PlatformNotificationHandlerContext JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7D90", Offset = "0x6ED6F90", VA = "0x186ED7D90")]
	[CompilerGenerated]
	private void BGCHNMNCDLM(ref ENMHCAKKFBJ P_0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AJBFGPDMFNA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int? EEKAMFMHHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DateTime PDFHAJGEOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string OAPKENNKMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string LGALCOOLPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PlatformNotificationType JPGJHLNLBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9E7BA0", Offset = "0x9E6DA0", VA = "0x1809E7BA0")]
		[CompilerGenerated]
		get
		{
			return default(PlatformNotificationType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string DDFMJIOEBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string PALAMFGNPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string LPDDCEMOGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string AFILCGOMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string AEIEFLLNEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public long? JGPCNBEMACD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB0A130", Offset = "0xB09330", VA = "0x180B0A130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int? EMFKLBFHJKG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public long? KMCALHKBCMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x158FA40", Offset = "0x158EC40", VA = "0x18158FA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public long? HBFBDJIOFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC8B060", Offset = "0xC8A260", VA = "0x180C8B060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x126E170", Offset = "0x126D370", VA = "0x18126E170")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HJIHAFGLKBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string ELEHPFOFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FMJJIDIAGGC HHOOILODNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event PGHMEACPFEK LHOFGJPFEPE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event EGELLPEPLBN NHIBIFPMAOK;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event OIFPCJFMIBJ IALCGIFBHPH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event JOBJPHCOKKF EJHIFCNFJMK;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NNJELLICDAG ANPBJFNAJNA;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event IAEMHLJLNLP MHLKFHGJGAG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event GFOCAIEDCPH OBFNLOPEBNK;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event MCEMOCKFPDC PIFCMJEBOBK;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event Action NGMOGIBPIKL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KCEHONPEIFO();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AADAONEIPBN();

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	LOCBBGIKEMI FKCGLLJHAAK();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string GMOHCFCBPIJ();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GIOBGNHJLID FCOHHGAFHFM();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	GIOBGNHJLID DMBCAGAAJID(int BHGKMJBGHFK, string DDFMJIOEBHH, string LPDDCEMOGCP, string CPNIJHHHHFN, string CIFIEGNCMNA, DateTime AFBDJOKEPAC, Action<AJBFGPDMFNA> LJDGLEJKCFJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GIOBGNHJLID DNBJGFLJBCP(string DDFMJIOEBHH, string LPDDCEMOGCP, params int[] DAKPHENPPLA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CLMNPGBILBE(out int? EEKAMFMHHFH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool BIBFKIBPGHH(out FMJJIDIAGGC MICNPNMDMKO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CLDJFBKAMEJ
{
	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event JOBJPHCOKKF EJHIFCNFJMK;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event MCEMOCKFPDC PIFCMJEBOBK;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AADAONEIPBN();

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CLMNPGBILBE(out int? EEKAMFMHHFH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BIBFKIBPGHH(out FMJJIDIAGGC MICNPNMDMKO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BKMNLNIGCAE(FMJJIDIAGGC JEFCJNKKLCB, PlatformNotificationHandlerContext JDFBABENAGD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface JEPFHKMFKEC
{
	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event OIFPCJFMIBJ IALCGIFBHPH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LOCBBGIKEMI FKCGLLJHAAK();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GIOBGNHJLID FCOHHGAFHFM();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string GMOHCFCBPIJ();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	List<FMJJIDIAGGC> BPBIHCGHCPC();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFDNILJCNKK();
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
