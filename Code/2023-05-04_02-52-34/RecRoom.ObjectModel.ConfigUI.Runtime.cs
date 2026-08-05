using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.ObjectModel.ConfigUI;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal abstract class JJBJHOGGLHN : global::GGEGGJNBPCI<Enum>, FGCDFMAGLPF, LKIOKOKKIGC, AHPKJPDGIIA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool EICFMPICPKL(Type OGILDIMGIOH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69612D0", Offset = "0x69606D0", VA = "0x1869612D0")]
	protected JJBJHOGGLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class GGEGGJNBPCI<T> : LKIOKOKKIGC, AHPKJPDGIIA where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void BGCGBJICALL(Func<T> ODHJHGHDKDM, Action<T> CPLDDCNHBMK, string AMNLGEBHFHK, PPBNAGHDKKA GJEJKJANAJD, Func<bool> LEJDIIEOMAE);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void DKHILKBLFDA(Func<int> ODHJHGHDKDM, Action<int> CPLDDCNHBMK, string AMNLGEBHFHK, PPBNAGHDKKA GJEJKJANAJD, Func<bool> LEJDIIEOMAE);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LFJBNIDJCLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public GKNDEBMEIID targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PPBNAGHDKKA property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public LFJBNIDJCLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x33CB110", Offset = "0x33CA510", VA = "0x1833CB110")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x33CB240", Offset = "0x33CA640", VA = "0x1833CB240")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A6950", Offset = "0x9A5D50", VA = "0x1809A6950")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PJBFLLKPMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::GGEGGJNBPCI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public GJKHIHIFPBD ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public PJBFLLKPMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2631D60", Offset = "0x2631160", VA = "0x182631D60")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, PPBNAGHDKKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GIBCEBMKIAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public GIBCEBMKIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x34592B0", Offset = "0x34586B0", VA = "0x1834592B0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3459530", Offset = "0x3458930", VA = "0x183459530")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3116870", Offset = "0x3115C70", VA = "0x183116870")]
	protected GGEGGJNBPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x31161F0", Offset = "0x31155F0", VA = "0x1831161F0", Slot = "5")]
	public virtual void AOPCKJNNALE(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD, GJKHIHIFPBD MLKIMELJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3116440", Offset = "0x3115840", VA = "0x183116440", Slot = "6")]
	protected virtual BGCGBJICALL DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3116540", Offset = "0x3115940", VA = "0x183116540", Slot = "7")]
	protected virtual DKHILKBLFDA FDMLEFJMFJD(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3115F20", Offset = "0x3115320", VA = "0x183115F20")]
	private static Enum ANNIKINOBDA(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x31165E0", Offset = "0x31159E0", VA = "0x1831165E0")]
	private static void HKLHLMDMINH(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD, Enum LPJDDLMPNCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class KOOJOEGDEED : ALFINKCKDAB, AHPKJPDGIIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private PPBNAGHDKKA[] HABCNHLBGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private PPBNAGHDKKA[] OCDOCBKEHJN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PPBNAGHDKKA[] GDNCKOGHLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public PPBNAGHDKKA[] LJIPIEEPIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract DDIEEGNDNAH[] CMGJNCNCOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract DDIEEGNDNAH[] OCGHIFPCDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69621A0", Offset = "0x69615A0", VA = "0x1869621A0", Slot = "6")]
	public void GJPLHHGHDFM(ILADIFIOBIK OAMPBIMBKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void AOPCKJNNALE(GKNDEBMEIID BJOALNIEBDH, GJKHIHIFPBD MLKIMELJFGI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B170", Offset = "0x1F0A570", VA = "0x181F0B170")]
	protected static T MHNDFMJHLCB<T>(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B0A0", Offset = "0x1F0A4A0", VA = "0x181F0B0A0")]
	protected static void COONODJIOAI<T>(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD, T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	protected KOOJOEGDEED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class CJHGOMEEICB<T> : LKIOKOKKIGC, AHPKJPDGIIA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void DGPNGCOLDIF(Func<T> ODHJHGHDKDM, Action<T> CPLDDCNHBMK, string AMNLGEBHFHK, PPBNAGHDKKA GJEJKJANAJD, Func<bool> LEJDIIEOMAE);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class ACJAKHOCIKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public GKNDEBMEIID targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PPBNAGHDKKA property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public ACJAKHOCIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A2C9B0", Offset = "0x2A2BDB0", VA = "0x182A2C9B0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2A2CCB0", Offset = "0x2A2C0B0", VA = "0x182A2CCB0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A6950", Offset = "0x9A5D50", VA = "0x1809A6950")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x258FD90", Offset = "0x258F190", VA = "0x18258FD90")]
	protected CJHGOMEEICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x258E8A0", Offset = "0x258DCA0", VA = "0x18258E8A0", Slot = "4")]
	public void AOPCKJNNALE(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD, GJKHIHIFPBD MLKIMELJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x258F890", Offset = "0x258EC90", VA = "0x18258F890")]
	private static T MHNDFMJHLCB(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x258F540", Offset = "0x258E940", VA = "0x18258F540")]
	private static void COONODJIOAI(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD, T LPJDDLMPNCG)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ConfigUI)]
	[HAMPPOKOPOP(typeof(MLHDMNAPIDM), new string[] { })]
	internal class ConfigUIService : MLHDMNAPIDM, GBCNOEIKEOL, IJGJDJPFIAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[OMAMNFHDGBM]
		private ILADIFIOBIK OAMPBIMBKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[OMAMNFHDGBM]
		private MDIHCNNBEEC CKHGNFAHGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[OMAMNFHDGBM]
		private GJKHIHIFPBD MPFBPOBBLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EKFHICPOBKK JFCOHPNLNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private GKNDEBMEIID BJOALNIEBDH;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x695F700", Offset = "0x695EB00", VA = "0x18695F700", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x695F790", Offset = "0x695EB90", VA = "0x18695F790", Slot = "6")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x695F0A0", Offset = "0x695E4A0", VA = "0x18695F0A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x695F190", Offset = "0x695E590", VA = "0x18695F190", Slot = "4")]
		public void FFIPOLEMFCL(GKNDEBMEIID NAIHPCNGKAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x695FA90", Offset = "0x695EE90", VA = "0x18695FA90")]
		private void NCFDHHJLNMH(GKNDEBMEIID NAIHPCNGKAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x695F070", Offset = "0x695E470", VA = "0x18695F070")]
		private void DOEAGLHJGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x695EDF0", Offset = "0x695E1F0", VA = "0x18695EDF0")]
		private void AOPCKJNNALE(PBJDOLDHHJL IOMDCEAIKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[LIHGBLOIIHF(0)]
internal class EKGGHFBEBME : JJBJHOGGLHN
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6961220", Offset = "0x6960620", VA = "0x186961220", Slot = "9")]
	public override bool EICFMPICPKL(Type OGILDIMGIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6961130", Offset = "0x6960530", VA = "0x186961130", Slot = "6")]
	protected override BGCGBJICALL DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69612D0", Offset = "0x69606D0", VA = "0x1869612D0")]
	public EKGGHFBEBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[LIHGBLOIIHF(0)]
internal class PKHIHLPEJAB : JJBJHOGGLHN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6963480", Offset = "0x6962880", VA = "0x186963480", Slot = "9")]
	public override bool EICFMPICPKL(Type OGILDIMGIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6963390", Offset = "0x6962790", VA = "0x186963390", Slot = "6")]
	protected override BGCGBJICALL DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69612D0", Offset = "0x69606D0", VA = "0x1869612D0")]
	public PKHIHLPEJAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KJFKEBHIONB(typeof(MAODNMABAFO), 1)]
internal class JCOLILMCIEA : global::GGEGGJNBPCI<MAODNMABAFO>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6961C60", Offset = "0x6961060", VA = "0x186961C60", Slot = "7")]
	protected override DKHILKBLFDA FDMLEFJMFJD(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6961D50", Offset = "0x6961150", VA = "0x186961D50")]
	public JCOLILMCIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DHICMOPLOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x695FB70", Offset = "0x695EF70", VA = "0x18695FB70")]
	public static bool OCJBFJPPEHP(this PPBNAGHDKKA GJEJKJANAJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GLOPONODKMI(2)]
internal class FJNCBAKBHHL : KOOJOEGDEED
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DLHDMJBOGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public GKNDEBMEIID targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FJNCBAKBHHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DLHDMJBOGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x695FCB0", Offset = "0x695F0B0", VA = "0x18695FCB0")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x695FDE0", Offset = "0x695F1E0", VA = "0x18695FDE0")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9A6950", Offset = "0x9A5D50", VA = "0x1809A6950")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DDIEEGNDNAH[] OCGHIFPCDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x69617B0", Offset = "0x6960BB0", VA = "0x1869617B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DDIEEGNDNAH[] CMGJNCNCOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69616D0", Offset = "0x6960AD0", VA = "0x1869616D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6961310", Offset = "0x6960710", VA = "0x186961310", Slot = "10")]
	public override void AOPCKJNNALE(GKNDEBMEIID BJOALNIEBDH, GJKHIHIFPBD MLKIMELJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public FJNCBAKBHHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KJFKEBHIONB(typeof(bool))]
internal class ACJHJBINLNJ : global::CJHGOMEEICB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x695D100", Offset = "0x695C500", VA = "0x18695D100", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x695D1F0", Offset = "0x695C5F0", VA = "0x18695D1F0")]
	public ACJHJBINLNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KJFKEBHIONB(typeof(FixedString32))]
internal class HLMIFMCINHM : global::CJHGOMEEICB<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NOGIJDOPOFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GJKHIHIFPBD ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NOGIJDOPOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6962D10", Offset = "0x6962110", VA = "0x186962D10")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, PPBNAGHDKKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BHKOIBLALNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BHKOIBLALNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x695E1F0", Offset = "0x695D5F0", VA = "0x18695E1F0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x695E260", Offset = "0x695D660", VA = "0x18695E260")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6961AB0", Offset = "0x6960EB0", VA = "0x186961AB0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6961B70", Offset = "0x6960F70", VA = "0x186961B70")]
	public HLMIFMCINHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KJFKEBHIONB(typeof(FixedString64))]
internal class LAMKGOOOGIO : global::CJHGOMEEICB<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BPJMNDCLAHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GJKHIHIFPBD ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BPJMNDCLAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x695E2E0", Offset = "0x695D6E0", VA = "0x18695E2E0")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, PPBNAGHDKKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MOHNJIGPJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MOHNJIGPJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6962BE0", Offset = "0x6961FE0", VA = "0x186962BE0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6962C70", Offset = "0x6962070", VA = "0x186962C70")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69625B0", Offset = "0x69619B0", VA = "0x1869625B0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6962670", Offset = "0x6961A70", VA = "0x186962670")]
	public LAMKGOOOGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KJFKEBHIONB(typeof(float))]
internal class CMAIDINFJEC : global::CJHGOMEEICB<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x695EBC0", Offset = "0x695DFC0", VA = "0x18695EBC0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x695ECB0", Offset = "0x695E0B0", VA = "0x18695ECB0")]
	public CMAIDINFJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KJFKEBHIONB(typeof(int))]
internal class OLHFIJBOOLM : global::CJHGOMEEICB<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6962EA0", Offset = "0x69622A0", VA = "0x186962EA0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6962F90", Offset = "0x6962390", VA = "0x186962F90")]
	public OLHFIJBOOLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[KJFKEBHIONB(typeof(uint))]
internal class CNBGEJJKBLI : global::CJHGOMEEICB<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LHOCEKIGNNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GJKHIHIFPBD ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LHOCEKIGNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69626B0", Offset = "0x6961AB0", VA = "0x1869626B0")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, PPBNAGHDKKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JBMEIJFGKAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public JBMEIJFGKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6961BB0", Offset = "0x6960FB0", VA = "0x186961BB0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6961C00", Offset = "0x6961000", VA = "0x186961C00")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x695ECF0", Offset = "0x695E0F0", VA = "0x18695ECF0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x695EDB0", Offset = "0x695E1B0", VA = "0x18695EDB0")]
	public CNBGEJJKBLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[KJFKEBHIONB(typeof(Vector3))]
internal class EGHIKPJHDHH : global::CJHGOMEEICB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LPNPAABAOGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public GJKHIHIFPBD ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public LPNPAABAOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6962890", Offset = "0x6961C90", VA = "0x186962890")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, PPBNAGHDKKA property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GNJEFEIKBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GNJEFEIKBEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6961890", Offset = "0x6960C90", VA = "0x186961890")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69618F0", Offset = "0x6960CF0", VA = "0x1869618F0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6961900", Offset = "0x6960D00", VA = "0x186961900")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6961960", Offset = "0x6960D60", VA = "0x186961960")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6961970", Offset = "0x6960D70", VA = "0x186961970")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69619D0", Offset = "0x6960DD0", VA = "0x1869619D0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x695FE70", Offset = "0x695F270", VA = "0x18695FE70", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x695FF30", Offset = "0x695F330", VA = "0x18695FF30")]
	public EGHIKPJHDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct PBJDOLDHHJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int GKHKODKGNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int CHNPGCEONOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int EICBOGNBLMD;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class BHEAJKPHIHO
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x695E110", Offset = "0x695D510", VA = "0x18695E110")]
	public static void BJAIFJDHPHK(Type CMMDKBIPOFD, Type KDJNGPENDKB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct PKCJDILACLK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69631B0", Offset = "0x69625B0", VA = "0x1869631B0")]
	public static NativeList<int> MBJCPKKFBAJ(GKNDEBMEIID BJOALNIEBDH, MDIHCNNBEEC CKHGNFAHGKM)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6962FD0", Offset = "0x69623D0", VA = "0x186962FD0")]
	private static bool CLAJMDHDFMB(PPBNAGHDKKA GJEJKJANAJD, GKNDEBMEIID BJOALNIEBDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class ALALFOGNNIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly MDIHCNNBEEC CKHGNFAHGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ILADIFIOBIK OAMPBIMBKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly GJKHIHIFPBD MLKIMELJFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<PBJDOLDHHJL> IJAJELACLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<EONMLKEIFOO> OINHGMLHJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<EONMLKEIFOO, List<PBJDOLDHHJL>> EIFEGNLKBLP;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x695DC50", Offset = "0x695D050", VA = "0x18695DC50")]
	public ALALFOGNNIG(MDIHCNNBEEC CKHGNFAHGKM, ILADIFIOBIK OAMPBIMBKMB, GJKHIHIFPBD MLKIMELJFGI, Action<PBJDOLDHHJL> IJAJELACLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x695D230", Offset = "0x695C630", VA = "0x18695D230")]
	public void CAFJFACHGJM(NativeList<PBJDOLDHHJL> LBGCOKDCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x695DA90", Offset = "0x695CE90", VA = "0x18695DA90")]
	private void JCMMPHJNFAL(EONMLKEIFOO KJJMKJFNPPK, PBJDOLDHHJL IOMDCEAIKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x695DA30", Offset = "0x695CE30", VA = "0x18695DA30")]
	public void GEKOPFAGCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x695D5B0", Offset = "0x695C9B0", VA = "0x18695D5B0")]
	private void CBLPBOGOGGI(EONMLKEIFOO KJJMKJFNPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x695DBB0", Offset = "0x695CFB0", VA = "0x18695DBB0")]
	private void ODCDMKPJGEP(EONMLKEIFOO KJJMKJFNPPK)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[JEGJCCBDMOE(OLCAJGBKOGB.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KHPCFEPAAAK : IEnumerable<PPBNAGHDKKA>, IEnumerable, IEnumerator<PPBNAGHDKKA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private PPBNAGHDKKA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public PropertiesByType <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Type <>3__type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private NativeMultiHashMap<long, int>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private PPBNAGHDKKA System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB0C7E0", Offset = "0xB0BBE0", VA = "0x180B0C7E0")]
			[DebuggerHidden]
			public KHPCFEPAAAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x69620D0", Offset = "0x69614D0", VA = "0x1869620D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6961D90", Offset = "0x6961190", VA = "0x186961D90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6962150", Offset = "0x6961550", VA = "0x186962150")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6962090", Offset = "0x6961490", VA = "0x186962090", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6961FE0", Offset = "0x69613E0", VA = "0x186961FE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PPBNAGHDKKA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6961FE0", Offset = "0x69613E0", VA = "0x186961FE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly ILADIFIOBIK OAMPBIMBKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> KCLOHIBLIBC;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6963710", Offset = "0x6962B10", VA = "0x186963710")]
		public PropertiesByType(ILADIFIOBIK OAMPBIMBKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6963630", Offset = "0x6962A30", VA = "0x186963630")]
		[IteratorStateMachine(typeof(KHPCFEPAAAK))]
		public IEnumerable<PPBNAGHDKKA> JLCMCNLFOPP(Type OGILDIMGIOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6963530", Offset = "0x6962930", VA = "0x186963530", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6963570", Offset = "0x6962970", VA = "0x186963570")]
		private long HAGDDONLLKH(PPBNAGHDKKA GJEJKJANAJD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69635F0", Offset = "0x69629F0", VA = "0x1869635F0")]
		private long HAGDDONLLKH(Type OGILDIMGIOH)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct AMPDNGLEHOL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray NGGLINOOBIJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x695E070", Offset = "0x695D470", VA = "0x18695E070")]
	public AMPDNGLEHOL(int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x695DF20", Offset = "0x695D320", VA = "0x18695DF20")]
	public static AMPDNGLEHOL NHDDOEEONPP(int IPADGNLNKOB, NativeArray<int> FNBGFGCHFDN)
	{
		return default(AMPDNGLEHOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x695DD70", Offset = "0x695D170", VA = "0x18695DD70")]
	public bool AAMENLIPJIG(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x695DD90", Offset = "0x695D190", VA = "0x18695DD90")]
	public void EFMALMFMJGL(int EGNHJGKABLC, bool LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x695DE60", Offset = "0x695D260", VA = "0x18695DE60")]
	public bool KIONFMFHIDL(PPBNAGHDKKA[] FNBGFGCHFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x695DDA0", Offset = "0x695D1A0", VA = "0x18695DDA0")]
	public bool JNMNAOKGLFK(PPBNAGHDKKA[] FNBGFGCHFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x695DD80", Offset = "0x695D180", VA = "0x18695DD80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class EKFHICPOBKK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly KLBHBMBPLOA JFFPIFJCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MDIHCNNBEEC CKHGNFAHGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly ILADIFIOBIK OAMPBIMBKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<AHPKJPDGIIA> EOBEPHGLKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType KCLOHIBLIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> NLKKEOCKGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> GFHGLGGMPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<AHPKJPDGIIA> KNCHGHIMBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6960FE0", Offset = "0x69603E0", VA = "0x186960FE0")]
	public EKFHICPOBKK(MDIHCNNBEEC CKHGNFAHGKM, ILADIFIOBIK OAMPBIMBKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6960110", Offset = "0x695F510", VA = "0x186960110")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6960D50", Offset = "0x6960150", VA = "0x186960D50")]
	public void KOPBNHFFIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x69601E0", Offset = "0x695F5E0", VA = "0x1869601E0")]
	public NativeList<PBJDOLDHHJL> CJFMFPHDKMI(NativeArray<int> FNBGFGCHFDN)
	{
		return default(NativeList<PBJDOLDHHJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x695FF70", Offset = "0x695F370", VA = "0x18695FF70")]
	private bool ACKOCHHNMHK(AHPKJPDGIIA EALCNELAPPM, AMPDNGLEHOL ANONGDKKAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x169FD20", Offset = "0x169F120", VA = "0x18169FD20")]
	private void KIPEPADLCCK<TInterface, TAttribute>(Action<TInterface, TAttribute> GNCHPDAPALO) where TInterface : AHPKJPDGIIA where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6960EC0", Offset = "0x69602C0", VA = "0x186960EC0")]
	private void OBBACDHEHAN(Type OGILDIMGIOH, Type NHCMIDLJAIE, Type OOJDFOPEHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x169FCC0", Offset = "0x169F0C0", VA = "0x18169FCC0")]
	private TInterface GIPLJDHCMMJ<TInterface>(Type OGILDIMGIOH)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6960040", Offset = "0x695F440", VA = "0x186960040")]
	private void ALIDHGCLJNJ(AHPKJPDGIIA EALCNELAPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6960EF0", Offset = "0x69602F0", VA = "0x186960EF0")]
	private int ODDAMOPEBLG(AHPKJPDGIIA OHBNFBFIMDH, int EICBOGNBLMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6960AA0", Offset = "0x695FEA0", VA = "0x186960AA0")]
	private void ICGFMGFIIEK(LKIOKOKKIGC EALCNELAPPM, KJFKEBHIONB MDFMJJLJGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69607E0", Offset = "0x695FBE0", VA = "0x1869607E0")]
	private void DMGHHEKEKAB(FGCDFMAGLPF EALCNELAPPM, LIHGBLOIIHF MDFMJJLJGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6960640", Offset = "0x695FA40", VA = "0x186960640")]
	private void DHFGHKPEFGN(ALFINKCKDAB EALCNELAPPM, GLOPONODKMI MDFMJJLJGBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct BPMEFMCIHAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ILADIFIOBIK OAMPBIMBKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<AHPKJPDGIIA> EOBEPHGLKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<PBJDOLDHHJL> DHPIONHDBGL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<PBJDOLDHHJL> HJGOIOEDCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9F0", Offset = "0xA3DDF0", VA = "0x180A3E9F0")]
		get
		{
			return default(NativeList<PBJDOLDHHJL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x695EB40", Offset = "0x695DF40", VA = "0x18695EB40")]
	public BPMEFMCIHAP(ILADIFIOBIK OAMPBIMBKMB, List<AHPKJPDGIIA> EOBEPHGLKJF, NativeArray<PBJDOLDHHJL> LBGCOKDCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x695E630", Offset = "0x695DA30", VA = "0x18695E630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x695E740", Offset = "0x695DB40", VA = "0x18695E740")]
	private NativeList<PBJDOLDHHJL> OCOGNMOLIBN(NativeArray<PBJDOLDHHJL> NKPIGDLEJKD)
	{
		return default(NativeList<PBJDOLDHHJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x695E670", Offset = "0x695DA70", VA = "0x18695E670")]
	private bool GIELPGGCAOO(AHPKJPDGIIA EALCNELAPPM, AMPDNGLEHOL ALHCFBACJEI, int CHNPGCEONOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x695E470", Offset = "0x695D870", VA = "0x18695E470")]
	private void BKNOBBOOFGA(AHPKJPDGIIA EALCNELAPPM, AMPDNGLEHOL NGGLINOOBIJ, int CHNPGCEONOA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct ANAMIFGGKKN : IComparer<PBJDOLDHHJL>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x695E0B0", Offset = "0x695D4B0", VA = "0x18695E0B0", Slot = "4")]
	public int Compare(PBJDOLDHHJL HFOFADIOHHP, PBJDOLDHHJL GFCGIJPPCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x695E0C0", Offset = "0x695D4C0", VA = "0x18695E0C0")]
	public static void KJCPAGPFOFN(NativeList<PBJDOLDHHJL> LBGCOKDCNMO)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : AAHOHGIJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6963B90", Offset = "0x6962F90", VA = "0x186963B90", Slot = "6")]
		public sealed override void MNNDBLCHNEL(CKMMIMLGKKB MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6963A10", Offset = "0x6962E10", VA = "0x186963A10", Slot = "4")]
		public sealed override void KLMOEJEAKPE()
		{
		}
	}
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
