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
	[Cpp2IlInjected.Address(RVA = "0x69411E0", Offset = "0x693FBE0", VA = "0x1869411E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public LFJBNIDJCLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x39CF090", Offset = "0x39CDA90", VA = "0x1839CF090")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x39CF1C0", Offset = "0x39CDBC0", VA = "0x1839CF1C0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4C590", VA = "0x180A4DB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public PJBFLLKPMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2607010", Offset = "0x2605A10", VA = "0x182607010")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public GIBCEBMKIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x346FD50", Offset = "0x346E750", VA = "0x18346FD50")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x346FFD0", Offset = "0x346E9D0", VA = "0x18346FFD0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x346C1D0", Offset = "0x346ABD0", VA = "0x18346C1D0")]
	protected GGEGGJNBPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x346BB50", Offset = "0x346A550", VA = "0x18346BB50", Slot = "5")]
	public virtual void AOPCKJNNALE(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD, GJKHIHIFPBD MLKIMELJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x346BDA0", Offset = "0x346A7A0", VA = "0x18346BDA0", Slot = "6")]
	protected virtual BGCGBJICALL DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x346BEA0", Offset = "0x346A8A0", VA = "0x18346BEA0", Slot = "7")]
	protected virtual DKHILKBLFDA FDMLEFJMFJD(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x346B880", Offset = "0x346A280", VA = "0x18346B880")]
	private static Enum ANNIKINOBDA(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x346BF40", Offset = "0x346A940", VA = "0x18346BF40")]
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
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public PPBNAGHDKKA[] LJIPIEEPIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69420B0", Offset = "0x6940AB0", VA = "0x1869420B0", Slot = "6")]
	public void GJPLHHGHDFM(ILADIFIOBIK OAMPBIMBKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void AOPCKJNNALE(GKNDEBMEIID BJOALNIEBDH, GJKHIHIFPBD MLKIMELJFGI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x24C09B0", Offset = "0x24BF3B0", VA = "0x1824C09B0")]
	protected static T MHNDFMJHLCB<T>(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x24C08E0", Offset = "0x24BF2E0", VA = "0x1824C08E0")]
	protected static void COONODJIOAI<T>(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD, T LPJDDLMPNCG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public ACJAKHOCIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A983B0", Offset = "0x2A96DB0", VA = "0x182A983B0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2A986B0", Offset = "0x2A970B0", VA = "0x182A986B0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4C590", VA = "0x180A4DB90")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2EFCF80", Offset = "0x2EFB980", VA = "0x182EFCF80")]
	protected CJHGOMEEICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2EFBA90", Offset = "0x2EFA490", VA = "0x182EFBA90", Slot = "4")]
	public void AOPCKJNNALE(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD, GJKHIHIFPBD MLKIMELJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2EFCA80", Offset = "0x2EFB480", VA = "0x182EFCA80")]
	private static T MHNDFMJHLCB(GKNDEBMEIID BJOALNIEBDH, PPBNAGHDKKA GJEJKJANAJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC730", Offset = "0x2EFB130", VA = "0x182EFC730")]
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
		[Cpp2IlInjected.Address(RVA = "0x693F610", Offset = "0x693E010", VA = "0x18693F610", Slot = "5")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x693F6A0", Offset = "0x693E0A0", VA = "0x18693F6A0", Slot = "6")]
		public void LOIIDKBBIDB(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x693EFB0", Offset = "0x693D9B0", VA = "0x18693EFB0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x693F0A0", Offset = "0x693DAA0", VA = "0x18693F0A0", Slot = "4")]
		public void FFIPOLEMFCL(GKNDEBMEIID NAIHPCNGKAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x693F9A0", Offset = "0x693E3A0", VA = "0x18693F9A0")]
		private void NCFDHHJLNMH(GKNDEBMEIID NAIHPCNGKAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x693EF80", Offset = "0x693D980", VA = "0x18693EF80")]
		private void DOEAGLHJGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x693ED00", Offset = "0x693D700", VA = "0x18693ED00")]
		private void AOPCKJNNALE(PBJDOLDHHJL IOMDCEAIKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x6941130", Offset = "0x693FB30", VA = "0x186941130", Slot = "9")]
	public override bool EICFMPICPKL(Type OGILDIMGIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6941040", Offset = "0x693FA40", VA = "0x186941040", Slot = "6")]
	protected override BGCGBJICALL DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69411E0", Offset = "0x693FBE0", VA = "0x1869411E0")]
	public EKGGHFBEBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[LIHGBLOIIHF(0)]
internal class PKHIHLPEJAB : JJBJHOGGLHN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6943390", Offset = "0x6941D90", VA = "0x186943390", Slot = "9")]
	public override bool EICFMPICPKL(Type OGILDIMGIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69432A0", Offset = "0x6941CA0", VA = "0x1869432A0", Slot = "6")]
	protected override BGCGBJICALL DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69411E0", Offset = "0x693FBE0", VA = "0x1869411E0")]
	public PKHIHLPEJAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KJFKEBHIONB(typeof(MAODNMABAFO), 1)]
internal class JCOLILMCIEA : global::GGEGGJNBPCI<MAODNMABAFO>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6941B70", Offset = "0x6940570", VA = "0x186941B70", Slot = "7")]
	protected override DKHILKBLFDA FDMLEFJMFJD(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6941C60", Offset = "0x6940660", VA = "0x186941C60")]
	public JCOLILMCIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DHICMOPLOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x693FA80", Offset = "0x693E480", VA = "0x18693FA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DLHDMJBOGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x693FBC0", Offset = "0x693E5C0", VA = "0x18693FBC0")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x693FCF0", Offset = "0x693E6F0", VA = "0x18693FCF0")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4C590", VA = "0x180A4DB90")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DDIEEGNDNAH[] OCGHIFPCDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x69416C0", Offset = "0x69400C0", VA = "0x1869416C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DDIEEGNDNAH[] CMGJNCNCOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69415E0", Offset = "0x693FFE0", VA = "0x1869415E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6941220", Offset = "0x693FC20", VA = "0x186941220", Slot = "10")]
	public override void AOPCKJNNALE(GKNDEBMEIID BJOALNIEBDH, GJKHIHIFPBD MLKIMELJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public FJNCBAKBHHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KJFKEBHIONB(typeof(bool))]
internal class ACJHJBINLNJ : global::CJHGOMEEICB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x693D010", Offset = "0x693BA10", VA = "0x18693D010", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x693D100", Offset = "0x693BB00", VA = "0x18693D100")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NOGIJDOPOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6942C20", Offset = "0x6941620", VA = "0x186942C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public BHKOIBLALNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x693E100", Offset = "0x693CB00", VA = "0x18693E100")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x693E170", Offset = "0x693CB70", VA = "0x18693E170")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69419C0", Offset = "0x69403C0", VA = "0x1869419C0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6941A80", Offset = "0x6940480", VA = "0x186941A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public BPJMNDCLAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x693E1F0", Offset = "0x693CBF0", VA = "0x18693E1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MOHNJIGPJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6942AF0", Offset = "0x69414F0", VA = "0x186942AF0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6942B80", Offset = "0x6941580", VA = "0x186942B80")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69424C0", Offset = "0x6940EC0", VA = "0x1869424C0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6942580", Offset = "0x6940F80", VA = "0x186942580")]
	public LAMKGOOOGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KJFKEBHIONB(typeof(float))]
internal class CMAIDINFJEC : global::CJHGOMEEICB<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x693EAD0", Offset = "0x693D4D0", VA = "0x18693EAD0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x693EBC0", Offset = "0x693D5C0", VA = "0x18693EBC0")]
	public CMAIDINFJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KJFKEBHIONB(typeof(int))]
internal class OLHFIJBOOLM : global::CJHGOMEEICB<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6942DB0", Offset = "0x69417B0", VA = "0x186942DB0", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6942EA0", Offset = "0x69418A0", VA = "0x186942EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LHOCEKIGNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69425C0", Offset = "0x6940FC0", VA = "0x1869425C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public JBMEIJFGKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6941AC0", Offset = "0x69404C0", VA = "0x186941AC0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6941B10", Offset = "0x6940510", VA = "0x186941B10")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x693EC00", Offset = "0x693D600", VA = "0x18693EC00", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x693ECC0", Offset = "0x693D6C0", VA = "0x18693ECC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public LPNPAABAOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69427A0", Offset = "0x69411A0", VA = "0x1869427A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GNJEFEIKBEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69417A0", Offset = "0x69401A0", VA = "0x1869417A0")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6941800", Offset = "0x6940200", VA = "0x186941800")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6941810", Offset = "0x6940210", VA = "0x186941810")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6941870", Offset = "0x6940270", VA = "0x186941870")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6941880", Offset = "0x6940280", VA = "0x186941880")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69418E0", Offset = "0x69402E0", VA = "0x1869418E0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x693FD80", Offset = "0x693E780", VA = "0x18693FD80", Slot = "5")]
	protected override DGPNGCOLDIF DPOKPADGGLI(GJKHIHIFPBD MLKIMELJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x693FE40", Offset = "0x693E840", VA = "0x18693FE40")]
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
	[Cpp2IlInjected.Address(RVA = "0x693E020", Offset = "0x693CA20", VA = "0x18693E020")]
	public static void BJAIFJDHPHK(Type CMMDKBIPOFD, Type KDJNGPENDKB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct PKCJDILACLK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69430C0", Offset = "0x6941AC0", VA = "0x1869430C0")]
	public static NativeList<int> MBJCPKKFBAJ(GKNDEBMEIID BJOALNIEBDH, MDIHCNNBEEC CKHGNFAHGKM)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6942EE0", Offset = "0x69418E0", VA = "0x186942EE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x693DB60", Offset = "0x693C560", VA = "0x18693DB60")]
	public ALALFOGNNIG(MDIHCNNBEEC CKHGNFAHGKM, ILADIFIOBIK OAMPBIMBKMB, GJKHIHIFPBD MLKIMELJFGI, Action<PBJDOLDHHJL> IJAJELACLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x693D140", Offset = "0x693BB40", VA = "0x18693D140")]
	public void CAFJFACHGJM(NativeList<PBJDOLDHHJL> LBGCOKDCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x693D9A0", Offset = "0x693C3A0", VA = "0x18693D9A0")]
	private void JCMMPHJNFAL(EONMLKEIFOO KJJMKJFNPPK, PBJDOLDHHJL IOMDCEAIKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x693D940", Offset = "0x693C340", VA = "0x18693D940")]
	public void GEKOPFAGCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x693D4C0", Offset = "0x693BEC0", VA = "0x18693D4C0")]
	private void CBLPBOGOGGI(EONMLKEIFOO KJJMKJFNPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x693DAC0", Offset = "0x693C4C0", VA = "0x18693DAC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8D5DA0", Offset = "0x8D47A0", VA = "0x1808D5DA0")]
			[DebuggerHidden]
			public KHPCFEPAAAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6941FE0", Offset = "0x69409E0", VA = "0x186941FE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6941CA0", Offset = "0x69406A0", VA = "0x186941CA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6942060", Offset = "0x6940A60", VA = "0x186942060")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6941FA0", Offset = "0x69409A0", VA = "0x186941FA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6941EF0", Offset = "0x69408F0", VA = "0x186941EF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PPBNAGHDKKA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6941EF0", Offset = "0x69408F0", VA = "0x186941EF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6943620", Offset = "0x6942020", VA = "0x186943620")]
		public PropertiesByType(ILADIFIOBIK OAMPBIMBKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6943540", Offset = "0x6941F40", VA = "0x186943540")]
		[IteratorStateMachine(typeof(KHPCFEPAAAK))]
		public IEnumerable<PPBNAGHDKKA> JLCMCNLFOPP(Type OGILDIMGIOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6943440", Offset = "0x6941E40", VA = "0x186943440", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6943480", Offset = "0x6941E80", VA = "0x186943480")]
		private long HAGDDONLLKH(PPBNAGHDKKA GJEJKJANAJD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6943500", Offset = "0x6941F00", VA = "0x186943500")]
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
	[Cpp2IlInjected.Address(RVA = "0x693DF80", Offset = "0x693C980", VA = "0x18693DF80")]
	public AMPDNGLEHOL(int EJMNNLNLAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x693DE30", Offset = "0x693C830", VA = "0x18693DE30")]
	public static AMPDNGLEHOL NHDDOEEONPP(int IPADGNLNKOB, NativeArray<int> FNBGFGCHFDN)
	{
		return default(AMPDNGLEHOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x693DC80", Offset = "0x693C680", VA = "0x18693DC80")]
	public bool AAMENLIPJIG(int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x693DCA0", Offset = "0x693C6A0", VA = "0x18693DCA0")]
	public void EFMALMFMJGL(int EGNHJGKABLC, bool LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x693DD70", Offset = "0x693C770", VA = "0x18693DD70")]
	public bool KIONFMFHIDL(PPBNAGHDKKA[] FNBGFGCHFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x693DCB0", Offset = "0x693C6B0", VA = "0x18693DCB0")]
	public bool JNMNAOKGLFK(PPBNAGHDKKA[] FNBGFGCHFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x693DC90", Offset = "0x693C690", VA = "0x18693DC90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6940EF0", Offset = "0x693F8F0", VA = "0x186940EF0")]
	public EKFHICPOBKK(MDIHCNNBEEC CKHGNFAHGKM, ILADIFIOBIK OAMPBIMBKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6940020", Offset = "0x693EA20", VA = "0x186940020")]
	public void BINPACHFFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6940C60", Offset = "0x693F660", VA = "0x186940C60")]
	public void KOPBNHFFIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x69400F0", Offset = "0x693EAF0", VA = "0x1869400F0")]
	public NativeList<PBJDOLDHHJL> CJFMFPHDKMI(NativeArray<int> FNBGFGCHFDN)
	{
		return default(NativeList<PBJDOLDHHJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x693FE80", Offset = "0x693E880", VA = "0x18693FE80")]
	private bool ACKOCHHNMHK(AHPKJPDGIIA EALCNELAPPM, AMPDNGLEHOL ANONGDKKAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B260", Offset = "0x1D79C60", VA = "0x181D7B260")]
	private void KIPEPADLCCK<TInterface, TAttribute>(Action<TInterface, TAttribute> GNCHPDAPALO) where TInterface : AHPKJPDGIIA where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6940DD0", Offset = "0x693F7D0", VA = "0x186940DD0")]
	private void OBBACDHEHAN(Type OGILDIMGIOH, Type NHCMIDLJAIE, Type OOJDFOPEHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1D7B200", Offset = "0x1D79C00", VA = "0x181D7B200")]
	private TInterface GIPLJDHCMMJ<TInterface>(Type OGILDIMGIOH)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x693FF50", Offset = "0x693E950", VA = "0x18693FF50")]
	private void ALIDHGCLJNJ(AHPKJPDGIIA EALCNELAPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6940E00", Offset = "0x693F800", VA = "0x186940E00")]
	private int ODDAMOPEBLG(AHPKJPDGIIA OHBNFBFIMDH, int EICBOGNBLMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69409B0", Offset = "0x693F3B0", VA = "0x1869409B0")]
	private void ICGFMGFIIEK(LKIOKOKKIGC EALCNELAPPM, KJFKEBHIONB MDFMJJLJGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69406F0", Offset = "0x693F0F0", VA = "0x1869406F0")]
	private void DMGHHEKEKAB(FGCDFMAGLPF EALCNELAPPM, LIHGBLOIIHF MDFMJJLJGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6940550", Offset = "0x693EF50", VA = "0x186940550")]
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
		[Cpp2IlInjected.Address(RVA = "0xCB3A00", Offset = "0xCB2400", VA = "0x180CB3A00")]
		get
		{
			return default(NativeList<PBJDOLDHHJL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x693EA50", Offset = "0x693D450", VA = "0x18693EA50")]
	public BPMEFMCIHAP(ILADIFIOBIK OAMPBIMBKMB, List<AHPKJPDGIIA> EOBEPHGLKJF, NativeArray<PBJDOLDHHJL> LBGCOKDCNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x693E540", Offset = "0x693CF40", VA = "0x18693E540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x693E650", Offset = "0x693D050", VA = "0x18693E650")]
	private NativeList<PBJDOLDHHJL> OCOGNMOLIBN(NativeArray<PBJDOLDHHJL> NKPIGDLEJKD)
	{
		return default(NativeList<PBJDOLDHHJL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x693E580", Offset = "0x693CF80", VA = "0x18693E580")]
	private bool GIELPGGCAOO(AHPKJPDGIIA EALCNELAPPM, AMPDNGLEHOL ALHCFBACJEI, int CHNPGCEONOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x693E380", Offset = "0x693CD80", VA = "0x18693E380")]
	private void BKNOBBOOFGA(AHPKJPDGIIA EALCNELAPPM, AMPDNGLEHOL NGGLINOOBIJ, int CHNPGCEONOA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct ANAMIFGGKKN : IComparer<PBJDOLDHHJL>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x693DFC0", Offset = "0x693C9C0", VA = "0x18693DFC0", Slot = "4")]
	public int Compare(PBJDOLDHHJL HFOFADIOHHP, PBJDOLDHHJL GFCGIJPPCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x693DFD0", Offset = "0x693C9D0", VA = "0x18693DFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6943AA0", Offset = "0x69424A0", VA = "0x186943AA0", Slot = "6")]
		public sealed override void MNNDBLCHNEL(CKMMIMLGKKB MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6943920", Offset = "0x6942320", VA = "0x186943920", Slot = "4")]
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
