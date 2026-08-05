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
internal abstract class GGEKFCJKMBO : global::KJBHHDMJJAE<Enum>, CJJBEJJCJLP, LBDHAIEAABD, NGGOPFAACDC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool EFFGPOFPPCB(Type LIJLAEFJGCI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x580FE00", Offset = "0x580EA00", VA = "0x18580FE00")]
	protected GGEKFCJKMBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class KJBHHDMJJAE<T> : LBDHAIEAABD, NGGOPFAACDC where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void JFGFLIADKMA(Func<T> BOPMLEANFNA, Action<T> APNOOOLFECP, string FHNLBBBEDLN, CNAIOOCFPBI MDENPOJAPFE);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void GPNIBNKHEGJ(Func<int> BOPMLEANFNA, Action<int> APNOOOLFECP, string FHNLBBBEDLN, CNAIOOCFPBI MDENPOJAPFE);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class DEMEIFJBECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public GFHDAMOBKPG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public CNAIOOCFPBI property;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public DEMEIFJBECH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE4F0", Offset = "0x3EDD0F0", VA = "0x183EDE4F0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE590", Offset = "0x3EDD190", VA = "0x183EDE590")]
		internal void <CreateUI>b__1(T value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ICEEACCFLBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public global::KJBHHDMJJAE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public PLGAADKOGHE ui;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public ICEEACCFLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9000", Offset = "0x3EE7C00", VA = "0x183EE9000")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, CNAIOOCFPBI property)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BBMBCIHEGNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public BBMBCIHEGNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3EDDF60", Offset = "0x3EDCB60", VA = "0x183EDDF60")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE0B0", Offset = "0x3EDCCB0", VA = "0x183EDE0B0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3EECAA0", Offset = "0x3EEB6A0", VA = "0x183EECAA0")]
	protected KJBHHDMJJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC220", Offset = "0x3EEAE20", VA = "0x183EEC220", Slot = "5")]
	public virtual void AOEANFMGMHA(GFHDAMOBKPG NALIGBNAOPA, CNAIOOCFPBI MDENPOJAPFE, PLGAADKOGHE ONCBAEEDPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC5E0", Offset = "0x3EEB1E0", VA = "0x183EEC5E0", Slot = "6")]
	protected virtual JFGFLIADKMA CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC9E0", Offset = "0x3EEB5E0", VA = "0x183EEC9E0", Slot = "7")]
	protected virtual GPNIBNKHEGJ PPHKLNCHCEN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC970", Offset = "0x3EEB570", VA = "0x183EEC970")]
	private static Enum MFNALGPHEMI(GFHDAMOBKPG NALIGBNAOPA, CNAIOOCFPBI MDENPOJAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC7F0", Offset = "0x3EEB3F0", VA = "0x183EEC7F0")]
	private static void KGJIEKDOJAP(GFHDAMOBKPG NALIGBNAOPA, CNAIOOCFPBI MDENPOJAPFE, Enum KGJOJGIPNPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class EMDCKOHMBKK : NDEEHEPIMHB, NGGOPFAACDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CNAIOOCFPBI[] JKEPOGDFDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CNAIOOCFPBI[] JNKIKAGCJJE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CNAIOOCFPBI[] BHPMNPBJDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public CNAIOOCFPBI[] BPDEGAHINPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract BDHIOHAFMEG[] HLPOGMGGAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract BDHIOHAFMEG[] AHOMFCHHDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x58111C0", Offset = "0x580FDC0", VA = "0x1858111C0", Slot = "6")]
	public void HILHGJFFAMN(ODHGFDMHCDN JANNOOLHKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void AOEANFMGMHA(GFHDAMOBKPG NALIGBNAOPA, PLGAADKOGHE ONCBAEEDPCK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2018A90", Offset = "0x2017690", VA = "0x182018A90")]
	protected static T AGEJOKDIDCO<T>(GFHDAMOBKPG NALIGBNAOPA, CNAIOOCFPBI MDENPOJAPFE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x233D5F0", Offset = "0x233C1F0", VA = "0x18233D5F0")]
	protected static void COJFMJPIIEB<T>(GFHDAMOBKPG NALIGBNAOPA, CNAIOOCFPBI MDENPOJAPFE, T KGJOJGIPNPH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected EMDCKOHMBKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class MCDPBKLFLOA<T> : LBDHAIEAABD, NGGOPFAACDC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void AOGHNGGNNJO(Func<T> BOPMLEANFNA, Action<T> APNOOOLFECP, string FHNLBBBEDLN, CNAIOOCFPBI MDENPOJAPFE);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IKDMECAJDMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public GFHDAMOBKPG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CNAIOOCFPBI property;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public IKDMECAJDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x36E3C20", Offset = "0x36E2820", VA = "0x1836E3C20")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x36E3F20", Offset = "0x36E2B20", VA = "0x1836E3F20")]
		internal void <CreateUI>b__1(T value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x36EB9F0", Offset = "0x36EA5F0", VA = "0x1836EB9F0")]
	protected MCDPBKLFLOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x36EA580", Offset = "0x36E9180", VA = "0x1836EA580", Slot = "4")]
	public void AOEANFMGMHA(GFHDAMOBKPG NALIGBNAOPA, CNAIOOCFPBI MDENPOJAPFE, PLGAADKOGHE ONCBAEEDPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract AOGHNGGNNJO CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36EA180", Offset = "0x36E8D80", VA = "0x1836EA180")]
	private static T AGEJOKDIDCO(GFHDAMOBKPG NALIGBNAOPA, CNAIOOCFPBI MDENPOJAPFE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36EB1F0", Offset = "0x36E9DF0", VA = "0x1836EB1F0")]
	private static void COJFMJPIIEB(GFHDAMOBKPG NALIGBNAOPA, CNAIOOCFPBI MDENPOJAPFE, T KGJOJGIPNPH)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[MHBJLGEIMOG(typeof(ACKDKNAHDHH), new string[] { })]
	[GOMFNBMFGBH(ELBDNIJMKBJ.ConfigUI)]
	internal class ConfigUIService : ACKDKNAHDHH, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private PLGAADKOGHE CPKBPLODOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JMOLPEEPLPD CFKDALFFNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ODHGFDMHCDN JANNOOLHKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JFMOGOGAIDN HCHDDBIBLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private GFHDAMOBKPG NALIGBNAOPA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5810DA0", Offset = "0x580F9A0", VA = "0x185810DA0", Slot = "5")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5810B60", Offset = "0x580F760", VA = "0x185810B60", Slot = "6")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5810510", Offset = "0x580F110", VA = "0x185810510", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x58105F0", Offset = "0x580F1F0", VA = "0x1858105F0", Slot = "4")]
		public void GJKMAIAPONH(GFHDAMOBKPG CGEEKMFICOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5810AA0", Offset = "0x580F6A0", VA = "0x185810AA0")]
		private void IGIIEBAFINN(GFHDAMOBKPG CGEEKMFICOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5810B30", Offset = "0x580F730", VA = "0x185810B30")]
		private void JCGPPCJNMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x58102B0", Offset = "0x580EEB0", VA = "0x1858102B0")]
		private void AOEANFMGMHA(FJIELDJOPKJ ECKGDNDILDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[FPNDCEFKONI(0)]
internal class CBCMGHEIHLE : GGEKFCJKMBO
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x580FD60", Offset = "0x580E960", VA = "0x18580FD60", Slot = "9")]
	public override bool EFFGPOFPPCB(Type LIJLAEFJGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x580FCE0", Offset = "0x580E8E0", VA = "0x18580FCE0", Slot = "6")]
	protected override JFGFLIADKMA CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x580FE00", Offset = "0x580EA00", VA = "0x18580FE00")]
	public CBCMGHEIHLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[FPNDCEFKONI(0)]
internal class MKGFLIOLAIL : GGEKFCJKMBO
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5814020", Offset = "0x5812C20", VA = "0x185814020", Slot = "9")]
	public override bool EFFGPOFPPCB(Type LIJLAEFJGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5813FA0", Offset = "0x5812BA0", VA = "0x185813FA0", Slot = "6")]
	protected override JFGFLIADKMA CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x580FE00", Offset = "0x580EA00", VA = "0x18580FE00")]
	public MKGFLIOLAIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[LBGDPCLNNOP(typeof(HEIDOPLIFDP), 1)]
internal class HOBDNGNMHCN : global::KJBHHDMJJAE<HEIDOPLIFDP>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5812030", Offset = "0x5810C30", VA = "0x185812030", Slot = "7")]
	protected override GPNIBNKHEGJ PPHKLNCHCEN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x58120B0", Offset = "0x5810CB0", VA = "0x1858120B0")]
	public HOBDNGNMHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CHCMHAKGEPK(2)]
internal class CDKNJFDHLLK : EMDCKOHMBKK
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JGGPHOJFOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public GFHDAMOBKPG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CDKNJFDHLLK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JGGPHOJFOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5813230", Offset = "0x5811E30", VA = "0x185813230")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5813340", Offset = "0x5811F40", VA = "0x185813340")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override BDHIOHAFMEG[] AHOMFCHHDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5810000", Offset = "0x580EC00", VA = "0x185810000", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override BDHIOHAFMEG[] HLPOGMGGAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x58100C0", Offset = "0x580ECC0", VA = "0x1858100C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x580FE40", Offset = "0x580EA40", VA = "0x18580FE40", Slot = "10")]
	public override void AOEANFMGMHA(GFHDAMOBKPG NALIGBNAOPA, PLGAADKOGHE ONCBAEEDPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public CDKNJFDHLLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[LBGDPCLNNOP(typeof(bool))]
internal class BBFEJFFIBJE : global::MCDPBKLFLOA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x580F460", Offset = "0x580E060", VA = "0x18580F460", Slot = "5")]
	protected override AOGHNGGNNJO CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x580F4E0", Offset = "0x580E0E0", VA = "0x18580F4E0")]
	public BBFEJFFIBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[LBGDPCLNNOP(typeof(FixedString32))]
internal class JNAFGMICMHM : global::MCDPBKLFLOA<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EMDPBNNGCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public PLGAADKOGHE ui;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public EMDPBNNGCCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x58115D0", Offset = "0x58101D0", VA = "0x1858115D0")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, CNAIOOCFPBI property)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JCGCPFAAFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JCGCPFAAFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5812150", Offset = "0x5810D50", VA = "0x185812150")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x58121D0", Offset = "0x5810DD0", VA = "0x1858121D0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58133D0", Offset = "0x5811FD0", VA = "0x1858133D0", Slot = "5")]
	protected override AOGHNGGNNJO CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5813470", Offset = "0x5812070", VA = "0x185813470")]
	public JNAFGMICMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[LBGDPCLNNOP(typeof(FixedString64))]
internal class LHOHMNBGJIL : global::MCDPBKLFLOA<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CHCNNKNMHFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PLGAADKOGHE ui;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CHCNNKNMHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5810180", Offset = "0x580ED80", VA = "0x185810180")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, CNAIOOCFPBI property)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GDGCNPFNGBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public GDGCNPFNGBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x58117E0", Offset = "0x58103E0", VA = "0x1858117E0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5811890", Offset = "0x5810490", VA = "0x185811890")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x58134B0", Offset = "0x58120B0", VA = "0x1858134B0", Slot = "5")]
	protected override AOGHNGGNNJO CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5813550", Offset = "0x5812150", VA = "0x185813550")]
	public LHOHMNBGJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[LBGDPCLNNOP(typeof(float))]
internal class HJGLJOHPBHP : global::MCDPBKLFLOA<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5811F70", Offset = "0x5810B70", VA = "0x185811F70", Slot = "5")]
	protected override AOGHNGGNNJO CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5811FF0", Offset = "0x5810BF0", VA = "0x185811FF0")]
	public HJGLJOHPBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[LBGDPCLNNOP(typeof(int))]
internal class AGCIMDCFFJB : global::MCDPBKLFLOA<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x580F3A0", Offset = "0x580DFA0", VA = "0x18580F3A0", Slot = "5")]
	protected override AOGHNGGNNJO CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x580F420", Offset = "0x580E020", VA = "0x18580F420")]
	public AGCIMDCFFJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[LBGDPCLNNOP(typeof(uint))]
internal class FDLBHLIOABJ : global::MCDPBKLFLOA<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NMEOGOGFBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PLGAADKOGHE ui;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NMEOGOGFBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x58147A0", Offset = "0x58133A0", VA = "0x1858147A0")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, CNAIOOCFPBI property)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NBLMCPIPKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NBLMCPIPKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x58140C0", Offset = "0x5812CC0", VA = "0x1858140C0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5814110", Offset = "0x5812D10", VA = "0x185814110")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5811700", Offset = "0x5810300", VA = "0x185811700", Slot = "5")]
	protected override AOGHNGGNNJO CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x58117A0", Offset = "0x58103A0", VA = "0x1858117A0")]
	public FDLBHLIOABJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[LBGDPCLNNOP(typeof(Vector3))]
internal class DMIGJJONJGB : global::MCDPBKLFLOA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ECMEPNPLLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PLGAADKOGHE ui;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ECMEPNPLLLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5810F40", Offset = "0x580FB40", VA = "0x185810F40")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, CNAIOOCFPBI property)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NDGDBMAGHIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public NDGDBMAGHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5814170", Offset = "0x5812D70", VA = "0x185814170")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x58141C0", Offset = "0x5812DC0", VA = "0x1858141C0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x58141D0", Offset = "0x5812DD0", VA = "0x1858141D0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5814230", Offset = "0x5812E30", VA = "0x185814230")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5814240", Offset = "0x5812E40", VA = "0x185814240")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x58142A0", Offset = "0x5812EA0", VA = "0x1858142A0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5810E60", Offset = "0x580FA60", VA = "0x185810E60", Slot = "5")]
	protected override AOGHNGGNNJO CLEHIBKNOMN(PLGAADKOGHE ONCBAEEDPCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5810F00", Offset = "0x580FB00", VA = "0x185810F00")]
	public DMIGJJONJGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal struct FJIELDJOPKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public int NFDFCJACACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public int GMLJADBNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public int OPGMLDDCKPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class BLHCMDOGHDH
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x580F520", Offset = "0x580E120", VA = "0x18580F520")]
	public static void HHAIDDNALDE(Type BHJPCJIKCPJ, Type EHBOGAFOJCB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal struct BPFLFDLEICM
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x580FB30", Offset = "0x580E730", VA = "0x18580FB30")]
	public static NativeList<int> NIGOGAPMHPA(GFHDAMOBKPG NALIGBNAOPA, JMOLPEEPLPD CFKDALFFNAB)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x580F940", Offset = "0x580E540", VA = "0x18580F940")]
	private static bool KAKJJJEDJJF(CNAIOOCFPBI MDENPOJAPFE, GFHDAMOBKPG NALIGBNAOPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class MEINPLBIJDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly JMOLPEEPLPD CFKDALFFNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly ODHGFDMHCDN JANNOOLHKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly PLGAADKOGHE ONCBAEEDPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Action<FJIELDJOPKJ> GCEJOKKOMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HashSet<OPGBJHDIFOD> JMPPBAIGFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<OPGBJHDIFOD, List<FJIELDJOPKJ>> BHJOBLKBDJP;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5813EA0", Offset = "0x5812AA0", VA = "0x185813EA0")]
	public MEINPLBIJDO(JMOLPEEPLPD CFKDALFFNAB, ODHGFDMHCDN JANNOOLHKPG, PLGAADKOGHE ONCBAEEDPCK, Action<FJIELDJOPKJ> GCEJOKKOMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5813590", Offset = "0x5812190", VA = "0x185813590")]
	public void FJGPPPMHAKK(NativeList<FJIELDJOPKJ> CIBINOMGEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5813D50", Offset = "0x5812950", VA = "0x185813D50")]
	private void NHCFHKMINEG(OPGBJHDIFOD MFEOBENMMAK, FJIELDJOPKJ ECKGDNDILDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5813E40", Offset = "0x5812A40", VA = "0x185813E40")]
	public void OMACNKGGPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5813860", Offset = "0x5812460", VA = "0x185813860")]
	private void HOPBNIKCEDB(OPGBJHDIFOD MFEOBENMMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5813CC0", Offset = "0x58128C0", VA = "0x185813CC0")]
	private void JIONLNONOMF(OPGBJHDIFOD MFEOBENMMAK)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class NKJIJGIEKPB : IEnumerable<CNAIOOCFPBI>, IEnumerable, IEnumerator<CNAIOOCFPBI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private CNAIOOCFPBI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public PropertiesByType <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Type <>3__type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private NativeMultiHashMap<long, int>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private CNAIOOCFPBI System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
			[DebuggerHidden]
			public NKJIJGIEKPB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x58146C0", Offset = "0x58132C0", VA = "0x1858146C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5814370", Offset = "0x5812F70", VA = "0x185814370", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5814760", Offset = "0x5813360", VA = "0x185814760")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5814670", Offset = "0x5813270", VA = "0x185814670", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x58145C0", Offset = "0x58131C0", VA = "0x1858145C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CNAIOOCFPBI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x58145C0", Offset = "0x58131C0", VA = "0x1858145C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ODHGFDMHCDN JANNOOLHKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NativeMultiHashMap<long, int> IKNMPIOEPFA;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5814B20", Offset = "0x5813720", VA = "0x185814B20")]
		public PropertiesByType(ODHGFDMHCDN JANNOOLHKPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5814A40", Offset = "0x5813640", VA = "0x185814A40")]
		[IteratorStateMachine(typeof(NKJIJGIEKPB))]
		public IEnumerable<CNAIOOCFPBI> MFACPEPJCCH(Type LIJLAEFJGCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5814920", Offset = "0x5813520", VA = "0x185814920", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x58149B0", Offset = "0x58135B0", VA = "0x1858149B0")]
		private long HIGMJIPNJHK(CNAIOOCFPBI MDENPOJAPFE)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5814960", Offset = "0x5813560", VA = "0x185814960")]
		private long HIGMJIPNJHK(Type LIJLAEFJGCI)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct BMMBOHHCBAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NativeBitArray AOAPPIIAEFO;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x580F900", Offset = "0x580E500", VA = "0x18580F900")]
	public BMMBOHHCBAL(int BKKGFAKFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x580F7A0", Offset = "0x580E3A0", VA = "0x18580F7A0")]
	public static BMMBOHHCBAL OJKKMHFEOHL(int LAODCMGHKOP, NativeArray<int> GCALAGNGEDP)
	{
		return default(BMMBOHHCBAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x580F6B0", Offset = "0x580E2B0", VA = "0x18580F6B0")]
	public bool DJEHAFPHMKN(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x580F6D0", Offset = "0x580E2D0", VA = "0x18580F6D0")]
	public void GELHLBKPBFF(int HIANDEDCLIF, bool KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x580F6E0", Offset = "0x580E2E0", VA = "0x18580F6E0")]
	public bool KFCANNDMMGE(CNAIOOCFPBI[] GCALAGNGEDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x580F5F0", Offset = "0x580E1F0", VA = "0x18580F5F0")]
	public bool AAHIBAANGKI(CNAIOOCFPBI[] GCALAGNGEDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x580F6C0", Offset = "0x580E2C0", VA = "0x18580F6C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class JFMOGOGAIDN
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly JMOLPEEPLPD CFKDALFFNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ODHGFDMHCDN JANNOOLHKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly List<NGGOPFAACDC> OCMFECPCMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly PropertiesByType IKNMPIOEPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private NativeMultiHashMap<int, int> PCHPGJCGKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeList<int> IPCBMCBAFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<NGGOPFAACDC> CADJOGNCEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5813110", Offset = "0x5811D10", VA = "0x185813110")]
	public JFMOGOGAIDN(JMOLPEEPLPD CFKDALFFNAB, ODHGFDMHCDN JANNOOLHKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x58124E0", Offset = "0x58110E0", VA = "0x1858124E0")]
	public void BMILBDCJANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5812F10", Offset = "0x5811B10", VA = "0x185812F10")]
	public void OBAPPCHAHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5812590", Offset = "0x5811190", VA = "0x185812590")]
	public NativeList<FJIELDJOPKJ> CBGHGIMBJMM(NativeArray<int> GCALAGNGEDP)
	{
		return default(NativeList<FJIELDJOPKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x58129A0", Offset = "0x58115A0", VA = "0x1858129A0")]
	private bool GHCJJLDKEFK(NGGOPFAACDC AEMFOPGBHNH, BMMBOHHCBAL PBHANLDKCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2D43E00", Offset = "0x2D42A00", VA = "0x182D43E00")]
	private void LNDCAJKFOLK<TInterface, TAttribute>(Action<TInterface, TAttribute> DMDFAIGCLEA) where TInterface : NGGOPFAACDC where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5812970", Offset = "0x5811570", VA = "0x185812970")]
	private void DLCEHMMAHKI(Type LIJLAEFJGCI, Type PBEILECEECP, Type BNCNFFHGNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3D54560", Offset = "0x3D53160", VA = "0x183D54560")]
	private TInterface HPKDEDOOLIJ<TInterface>(Type LIJLAEFJGCI)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5812FF0", Offset = "0x5811BF0", VA = "0x185812FF0")]
	private void PFGJAIGKOJP(NGGOPFAACDC AEMFOPGBHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5812E80", Offset = "0x5811A80", VA = "0x185812E80")]
	private int JGHIADPPGIF(NGGOPFAACDC HPCDOELFBLK, int OPGMLDDCKPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5812250", Offset = "0x5810E50", VA = "0x185812250")]
	private void BIDCIJPMFEK(LBDHAIEAABD AEMFOPGBHNH, LBGDPCLNNOP DKDNEDJBPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5812A60", Offset = "0x5811660", VA = "0x185812A60")]
	private void ICPEKPGKEAK(CJJBEJJCJLP AEMFOPGBHNH, FPNDCEFKONI DKDNEDJBPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5812D00", Offset = "0x5811900", VA = "0x185812D00")]
	private void IJGANBPKABN(NDEEHEPIMHB AEMFOPGBHNH, CHCMHAKGEPK DKDNEDJBPKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal struct GIBNONABMME : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly ODHGFDMHCDN JANNOOLHKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<NGGOPFAACDC> OCMFECPCMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private NativeList<FJIELDJOPKJ> HGNEHJBMLAF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<FJIELDJOPKJ> IMAJGNBJFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA40", Offset = "0x8FC640", VA = "0x1808FDA40")]
		get
		{
			return default(NativeList<FJIELDJOPKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5811EF0", Offset = "0x5810AF0", VA = "0x185811EF0")]
	public GIBNONABMME(ODHGFDMHCDN JANNOOLHKPG, List<NGGOPFAACDC> OCMFECPCMJI, NativeArray<FJIELDJOPKJ> CIBINOMGEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5811B90", Offset = "0x5810790", VA = "0x185811B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5811BD0", Offset = "0x58107D0", VA = "0x185811BD0")]
	private NativeList<FJIELDJOPKJ> OHBEGFDAAIE(NativeArray<FJIELDJOPKJ> ICGFHAALAOA)
	{
		return default(NativeList<FJIELDJOPKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5811AD0", Offset = "0x58106D0", VA = "0x185811AD0")]
	private bool CGHAIBIGKNJ(NGGOPFAACDC AEMFOPGBHNH, BMMBOHHCBAL ACHNGMFGFLI, int GMLJADBNFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5811930", Offset = "0x5810530", VA = "0x185811930")]
	private void ACDHMPLIJMJ(NGGOPFAACDC AEMFOPGBHNH, BMMBOHHCBAL AOAPPIIAEFO, int GMLJADBNFOH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct IOBIBBONBNG : IComparer<FJIELDJOPKJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x58120F0", Offset = "0x5810CF0", VA = "0x1858120F0", Slot = "4")]
	public int Compare(FJIELDJOPKJ FNKIIBFNLFB, FJIELDJOPKJ EDLPJGEPJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5812100", Offset = "0x5810D00", VA = "0x185812100")]
	public static void EOGECOLDIPK(NativeList<FJIELDJOPKJ> CIBINOMGEBO)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	internal class _RRAssemblyIndex : DGENKNGBBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5814DE0", Offset = "0x58139E0", VA = "0x185814DE0", Slot = "6")]
		public sealed override void CBLNFNGILAM(ENOEKOONOEP KCGMNIDCJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5814EE0", Offset = "0x5813AE0", VA = "0x185814EE0", Slot = "4")]
		public sealed override void JHENDOAEKLB()
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
