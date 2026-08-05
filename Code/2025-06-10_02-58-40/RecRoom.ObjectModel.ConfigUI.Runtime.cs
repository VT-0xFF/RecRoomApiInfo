using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E06080", Offset = "0x7E05280", VA = "0x187E06080", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E08C50", Offset = "0x7E07E50", VA = "0x187E08C50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E08280", Offset = "0x7E07480", VA = "0x187E08280")]
		private void AGIDAPFICKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E084D0", Offset = "0x7E076D0", VA = "0x187E084D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E08530", Offset = "0x7E07730", VA = "0x187E08530", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E08C70", Offset = "0x7E07E70", VA = "0x187E08C70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class PLNCEAIOANC : FPPFMINFFNP<Enum>, BEDCGIOLHAP, PMBCFGKLBNM, HEGPJOOKECN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool LFKIIDNLILM(Type GDHKDBJPDLG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E01B10", Offset = "0x7E00D10", VA = "0x187E01B10")]
	protected PLNCEAIOANC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal abstract class FPPFMINFFNP<T> : PMBCFGKLBNM, HEGPJOOKECN where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KDGDBLBNDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public NJOFFJDNHAF property;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KDGDBLBNDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5129A50", Offset = "0x5128C50", VA = "0x185129A50")]
		internal bool NOPNAFLKNMH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B4D4C0", Offset = "0x4B4C6C0", VA = "0x184B4D4C0")]
	protected FPPFMINFFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B4D0C0", Offset = "0x4B4C2C0", VA = "0x184B4D0C0")]
	protected void HBPHINMLMCG(CLMOBGNFBDH JKJCIPJAKEC, NJOFFJDNHAF MEGAJPAELNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46EABF0", Offset = "0x46E9DF0", VA = "0x1846EABF0")]
	protected void MFDFIDOEKGM(MKILBBBAEFA<T> JKJCIPJAKEC, NJOFFJDNHAF MEGAJPAELNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class IMCKDEEHFHI : OBBDGEFKCDK, HEGPJOOKECN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract OOPJKCMDMCJ[] CDDGFINBGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract OOPJKCMDMCJ[] DDBBFHJHECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, NALONKBHPAC BACBMENDKME, EJGCKAHLIPM AMCNLDBGKFH, FGHOEMOKGFD OELIIIMBGFG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A4FD40", Offset = "0x3A4EF40", VA = "0x183A4FD40")]
	protected static T JMDHMPAHEMH<T>(JCMFEJFBHJF FBNDONAGNIN, IGAJFIDJJMO<T> MEGAJPAELNI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A4FC50", Offset = "0x3A4EE50", VA = "0x183A4FC50")]
	protected static void HOMDCKLHALB<T>(JCMFEJFBHJF FBNDONAGNIN, IGAJFIDJJMO<T> MEGAJPAELNI, T KJIOHKMJAPE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected IMCKDEEHFHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal abstract class EOCCCHOFHMC<T> : PMBCFGKLBNM, HEGPJOOKECN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GDPFMJJHJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public NJOFFJDNHAF property;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GDPFMJJHJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4BF4EE0", Offset = "0x4BF40E0", VA = "0x184BF4EE0")]
		internal bool NOPNAFLKNMH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x46EB380", Offset = "0x46EA580", VA = "0x1846EB380")]
	protected EOCCCHOFHMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x46E9DF0", Offset = "0x46E8FF0", VA = "0x1846E9DF0")]
	protected void HBPHINMLMCG(CLMOBGNFBDH JKJCIPJAKEC, NJOFFJDNHAF MEGAJPAELNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x46EAE10", Offset = "0x46EA010", VA = "0x1846EAE10")]
	protected void MFDFIDOEKGM(MKILBBBAEFA<T> JKJCIPJAKEC, NJOFFJDNHAF MEGAJPAELNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(NALONKBHPAC), new string[] { })]
internal class MJBJGMLOKKH : NALONKBHPAC, KMKODLCHFCF, EJADEOIPJPK, LNIDKKDBPDJ, OBFJDPCMLDN
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DependsOn]
	private EJGCKAHLIPM AMCNLDBGKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[DependsOn]
	private FGHOEMOKGFD ALIKELGBGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KLHODPGFBGH EEPAGEKDMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private JCMFEJFBHJF FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private List<NJOFFJDNHAF> JJEAGIPKPPD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JCMFEJFBHJF NHNONNLNCGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1507630", Offset = "0x1506830", VA = "0x181507630", Slot = "5")]
		get
		{
			return default(JCMFEJFBHJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E06790", Offset = "0x7E05990", VA = "0x187E06790", Slot = "6")]
	public void InitExternal(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E07270", Offset = "0x7E06470", VA = "0x187E07270", Slot = "7")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E06AE0", Offset = "0x7E05CE0", VA = "0x187E06AE0", Slot = "4")]
	public void KGACCDHMNJH(JCMFEJFBHJF GFFENHAIMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E07000", Offset = "0x7E06200", VA = "0x187E07000")]
	private void LBBHCGOEIAJ(JCMFEJFBHJF GFFENHAIMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E07070", Offset = "0x7E06270", VA = "0x187E07070")]
	private void NCEPDBAFHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E06440", Offset = "0x7E05640", VA = "0x187E06440")]
	private void ELOHMKJMDOB(GDPCAOEIGNO AMMJLOOGFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E063D0", Offset = "0x7E055D0", VA = "0x187E063D0", Slot = "8")]
	private void DDIHEPEDMIL(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x11D7350", Offset = "0x11D6550", VA = "0x1811D7350", Slot = "9")]
	private void OEBCMEIKBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E073F0", Offset = "0x7E065F0", VA = "0x187E073F0")]
	public MJBJGMLOKKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DNKFKMHJNEG(0)]
internal class BPLFLDJBNLB : PLNCEAIOANC
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E019C0", Offset = "0x7E00BC0", VA = "0x187E019C0", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E01A70", Offset = "0x7E00C70", VA = "0x187E01A70", Slot = "7")]
	public override bool LFKIIDNLILM(Type GDHKDBJPDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E01B10", Offset = "0x7E00D10", VA = "0x187E01B10")]
	public BPLFLDJBNLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DNKFKMHJNEG(0)]
internal class OMHNLDFNLAN : PLNCEAIOANC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E07480", Offset = "0x7E06680", VA = "0x187E07480", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E07530", Offset = "0x7E06730", VA = "0x187E07530", Slot = "7")]
	public override bool LFKIIDNLILM(Type GDHKDBJPDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E01B10", Offset = "0x7E00D10", VA = "0x187E01B10")]
	public OMHNLDFNLAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[MCCLPHGHGDC(typeof(OFLMEILHLBB), 1)]
internal class PMKNHJAHBPA : FPPFMINFFNP<OFLMEILHLBB>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E080F0", Offset = "0x7E072F0", VA = "0x187E080F0", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E08240", Offset = "0x7E07440", VA = "0x187E08240")]
	public PMKNHJAHBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JGDDGKGIALH(2)]
internal class ALMNMEMDFMM : IMCKDEEHFHI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class CNKBNJPEEPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NALONKBHPAC configUIService;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CNKBNJPEEPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7E01C30", Offset = "0x7E00E30", VA = "0x187E01C30")]
		internal (int, int) IILKGDHEEAA()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E01B50", Offset = "0x7E00D50", VA = "0x187E01B50")]
		internal void BIAEIHAKNFC((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override OOPJKCMDMCJ[] CDDGFINBGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override OOPJKCMDMCJ[] DDBBFHJHECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E014D0", Offset = "0x7E006D0", VA = "0x187E014D0", Slot = "9")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, NALONKBHPAC BACBMENDKME, EJGCKAHLIPM AMCNLDBGKFH, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E018A0", Offset = "0x7E00AA0", VA = "0x187E018A0")]
	public ALMNMEMDFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[MCCLPHGHGDC(typeof(bool))]
internal class KGBKDKLLABA : EOCCCHOFHMC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E03A10", Offset = "0x7E02C10", VA = "0x187E03A10", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E03AA0", Offset = "0x7E02CA0", VA = "0x187E03AA0")]
	public KGBKDKLLABA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[MCCLPHGHGDC(typeof(FixedString32Bytes))]
internal class JALNFFPMDMC : EOCCCHOFHMC<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class IDLPNMEPLDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public NJOFFJDNHAF property;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public IDLPNMEPLDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E03010", Offset = "0x7E02210", VA = "0x187E03010")]
		internal string IILKGDHEEAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E02FA0", Offset = "0x7E021A0", VA = "0x187E02FA0")]
		internal void BIAEIHAKNFC(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E03070", Offset = "0x7E02270", VA = "0x187E03070", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E03210", Offset = "0x7E02410", VA = "0x187E03210")]
	public JALNFFPMDMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[MCCLPHGHGDC(typeof(FixedString64Bytes))]
internal class LBIBOKODDEK : EOCCCHOFHMC<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KKEEJOKABLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NJOFFJDNHAF property;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KKEEJOKABLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E03B70", Offset = "0x7E02D70", VA = "0x187E03B70")]
		internal string IILKGDHEEAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E03AE0", Offset = "0x7E02CE0", VA = "0x187E03AE0")]
		internal void BIAEIHAKNFC(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E05EA0", Offset = "0x7E050A0", VA = "0x187E05EA0", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E06040", Offset = "0x7E05240", VA = "0x187E06040")]
	public LBIBOKODDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[MCCLPHGHGDC(typeof(float3))]
internal class IBHMHHNBMDG : EOCCCHOFHMC<float3>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JICKKMCFAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NJOFFJDNHAF property;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public JICKKMCFAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E03360", Offset = "0x7E02560", VA = "0x187E03360")]
		internal float IILKGDHEEAA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7E03260", Offset = "0x7E02460", VA = "0x187E03260")]
		internal void BIAEIHAKNFC(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7E03440", Offset = "0x7E02640", VA = "0x187E03440")]
		internal float JFPOPLCGKCD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7E03350", Offset = "0x7E02550", VA = "0x187E03350")]
		internal void GELJANGONHP(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7E034B0", Offset = "0x7E026B0", VA = "0x187E034B0")]
		internal float NHEAFDDMPGL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E03520", Offset = "0x7E02720", VA = "0x187E03520")]
		internal void OAIDLLHFBHN(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7E033D0", Offset = "0x7E025D0", VA = "0x187E033D0")]
		internal float IODELNMOFHD(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7E03270", Offset = "0x7E02470", VA = "0x187E03270")]
		internal void DGMLJHNPDOM(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E02B30", Offset = "0x7E01D30", VA = "0x187E02B30", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E02F60", Offset = "0x7E02160", VA = "0x187E02F60")]
	public IBHMHHNBMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MCCLPHGHGDC(typeof(float))]
internal class PGPCBGLLCKF : EOCCCHOFHMC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E08020", Offset = "0x7E07220", VA = "0x187E08020", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E080B0", Offset = "0x7E072B0", VA = "0x187E080B0")]
	public PGPCBGLLCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MCCLPHGHGDC(typeof(int))]
internal class HHLCIDIJBDF : EOCCCHOFHMC<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E02A60", Offset = "0x7E01C60", VA = "0x187E02A60", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E02AF0", Offset = "0x7E01CF0", VA = "0x187E02AF0")]
	public HHLCIDIJBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[MCCLPHGHGDC(typeof(quaternion))]
internal class PDMIDGLKDMN : EOCCCHOFHMC<quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GCPLPKCGCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NJOFFJDNHAF property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GCPLPKCGCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7E02990", Offset = "0x7E01B90", VA = "0x187E02990")]
		internal float IILKGDHEEAA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7E025A0", Offset = "0x7E017A0", VA = "0x187E025A0")]
		internal void BIAEIHAKNFC(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7E029A0", Offset = "0x7E01BA0", VA = "0x187E029A0")]
		internal float JFPOPLCGKCD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7E02980", Offset = "0x7E01B80", VA = "0x187E02980")]
		internal void GELJANGONHP(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E029B0", Offset = "0x7E01BB0", VA = "0x187E029B0")]
		internal float NHEAFDDMPGL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E029C0", Offset = "0x7E01BC0", VA = "0x187E029C0")]
		internal void OAIDLLHFBHN(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E025B0", Offset = "0x7E017B0", VA = "0x187E025B0")]
		internal float EEFCMPPPMGP(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E02720", Offset = "0x7E01920", VA = "0x187E02720")]
		internal void FGEGIJECHDD(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E07BB0", Offset = "0x7E06DB0", VA = "0x187E07BB0", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E07FE0", Offset = "0x7E071E0", VA = "0x187E07FE0")]
	public PDMIDGLKDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[MCCLPHGHGDC(typeof(uint))]
internal class KLBGCOHLOOE : EOCCCHOFHMC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HCPCGIIJPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NJOFFJDNHAF property;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HCPCGIIJPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E02A20", Offset = "0x7E01C20", VA = "0x187E02A20")]
		internal int IILKGDHEEAA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7E029D0", Offset = "0x7E01BD0", VA = "0x187E029D0")]
		internal void BIAEIHAKNFC(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E03BF0", Offset = "0x7E02DF0", VA = "0x187E03BF0", Slot = "5")]
	public override void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E03D90", Offset = "0x7E02F90", VA = "0x187E03D90")]
	public KLBGCOHLOOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal struct GDPCAOEIGNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int HHNJHMNPCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public OOPJKCMDMCJ MEGAJPAELNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int JKPJMPOAKPP;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class PCKJDDGIGOG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E07AE0", Offset = "0x7E06CE0", VA = "0x187E07AE0")]
	public static void CGPKMHMEKJJ(Type EKIMNEDICHC, Type BJFFKIKHOEH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct ADLGMMBPHHK
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E01110", Offset = "0x7E00310", VA = "0x187E01110")]
	public static NativeList<OOPJKCMDMCJ> FALGKCIFFED(JCMFEJFBHJF FBNDONAGNIN, EJGCKAHLIPM AMCNLDBGKFH)
	{
		return default(NativeList<OOPJKCMDMCJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E013E0", Offset = "0x7E005E0", VA = "0x187E013E0")]
	private static bool OLJLKHDFDHJ(OOPJKCMDMCJ MEGAJPAELNI, JCMFEJFBHJF FBNDONAGNIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KNFMHMDGOKD : NJOFFJDNHAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OOPJKCMDMCJ MEGAJPAELNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly EJGCKAHLIPM HMJBLCLPFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly JCMFEJFBHJF FBNDONAGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E05D00", Offset = "0x7E04F00", VA = "0x187E05D00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LKJEHOPDGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E05A80", Offset = "0x7E04C80", VA = "0x187E05A80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public OGCPECJLBAM IMEPFFKCKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E05D60", Offset = "0x7E04F60", VA = "0x187E05D60", Slot = "8")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type BGLOFMKFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E05C10", Offset = "0x7E04E10", VA = "0x187E05C10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action MCJKNLDOICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7E05C60", Offset = "0x7E04E60", VA = "0x187E05C60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7E059E0", Offset = "0x7E04BE0", VA = "0x187E059E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E05DB0", Offset = "0x7E04FB0", VA = "0x187E05DB0")]
	public KNFMHMDGOKD(JCMFEJFBHJF FBNDONAGNIN, OOPJKCMDMCJ MEGAJPAELNI, EJGCKAHLIPM HMJBLCLPFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7E05B00", Offset = "0x7E04D00", VA = "0x187E05B00")]
	private void GKAPLPIKOOM(HBHPHBBJEBO CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E05710", Offset = "0x7E04910", VA = "0x187E05710", Slot = "10")]
	public void AFHCIICHJIO(COFGDNEKJBL KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7E057F0", Offset = "0x7E049F0", VA = "0x187E057F0", Slot = "11")]
	public void DEEMOOGCBGF(ECNHDPCIGGN KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7E05910", Offset = "0x7E04B10", VA = "0x187E05910", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[JHDLANPJKBB(1)]
internal sealed class JINCBNBMIAD : BLOCHGMPLJN, PMBCFGKLBNM, HEGPJOOKECN
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MENICKLDEBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NJOFFJDNHAF property;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public MENICKLDEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7E062F0", Offset = "0x7E054F0", VA = "0x187E062F0")]
		internal bool IILKGDHEEAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7E06190", Offset = "0x7E05390", VA = "0x187E06190")]
		internal string BIAEIHAKNFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E06340", Offset = "0x7E05540", VA = "0x187E06340")]
		internal void JFPOPLCGKCD(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E06210", Offset = "0x7E05410", VA = "0x187E06210")]
		internal string GELJANGONHP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OOPJKCMDMCJ DJMDDAMJOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E039A0", Offset = "0x7E02BA0", VA = "0x187E039A0", Slot = "4")]
		get
		{
			return default(OOPJKCMDMCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7E03530", Offset = "0x7E02730", VA = "0x187E03530", Slot = "5")]
	public void ELOHMKJMDOB(NJOFFJDNHAF MEGAJPAELNI, FGHOEMOKGFD OELIIIMBGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JINCBNBMIAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class ABMDMGONPOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly EJGCKAHLIPM AMCNLDBGKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FGHOEMOKGFD OELIIIMBGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<GDPCAOEIGNO> DEDAKGPAOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<NHCMEGKMCMK> FGJHEIJCNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<NHCMEGKMCMK, List<GDPCAOEIGNO>> ILCCNFFOMDM;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E00FF0", Offset = "0x7E001F0", VA = "0x187E00FF0")]
	public ABMDMGONPOP(EJGCKAHLIPM AMCNLDBGKFH, FGHOEMOKGFD OELIIIMBGFG, Action<GDPCAOEIGNO> DEDAKGPAOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E00710", Offset = "0x7DFF910", VA = "0x187E00710")]
	public void FIDGNCHJMLB(NativeList<GDPCAOEIGNO> CBKKCDNIPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E00590", Offset = "0x7DFF790", VA = "0x187E00590")]
	private void CCLHDHNAADL(NHCMEGKMCMK IMLPAHMDDDJ, GDPCAOEIGNO AMMJLOOGFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7E00A70", Offset = "0x7DFFC70", VA = "0x187E00A70")]
	public void JLHHHGOKMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E00B70", Offset = "0x7DFFD70", VA = "0x187E00B70")]
	private void PJEDELCHOGO(NHCMEGKMCMK IMLPAHMDDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E00AD0", Offset = "0x7DFFCD0", VA = "0x187E00AD0")]
	private void NKAKFEIGPAA(NHCMEGKMCMK IMLPAHMDDDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class EKJPADMBMGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PACNCGIHBNI : IEnumerable<OOPJKCMDMCJ>, IEnumerable, IEnumerator<OOPJKCMDMCJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private OOPJKCMDMCJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public EKJPADMBMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NativeParallelMultiHashMap<long, int>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private OOPJKCMDMCJ System.Collections.Generic.IEnumerator<RecRoom.DataLayer.NetworkProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA90990", Offset = "0xA8FB90", VA = "0x180A90990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OOPJKCMDMCJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7E07A00", Offset = "0x7E06C00", VA = "0x187E07A00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x137E0F0", Offset = "0x137D2F0", VA = "0x18137E0F0")]
		[DebuggerHidden]
		public PACNCGIHBNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E07A50", Offset = "0x7E06C50", VA = "0x187E07A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E07690", Offset = "0x7E06890", VA = "0x187E07690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E07640", Offset = "0x7E06840", VA = "0x187E07640")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E079B0", Offset = "0x7E06BB0", VA = "0x187E079B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E078F0", Offset = "0x7E06AF0", VA = "0x187E078F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OOPJKCMDMCJ> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7E078F0", Offset = "0x7E06AF0", VA = "0x187E078F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeParallelMultiHashMap<long, int> NIIAFBEIDGN;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E01FD0", Offset = "0x7E011D0", VA = "0x187E01FD0")]
	public EKJPADMBMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E01DB0", Offset = "0x7E00FB0", VA = "0x187E01DB0")]
	[IteratorStateMachine(typeof(PACNCGIHBNI))]
	public IEnumerable<OOPJKCMDMCJ> COHHJDPJMCH(Type GDHKDBJPDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E01E50", Offset = "0x7E01050", VA = "0x187E01E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E01ED0", Offset = "0x7E010D0", VA = "0x187E01ED0")]
	private long MICBKJOGLKK(OOPJKCMDMCJ MEGAJPAELNI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7E01E90", Offset = "0x7E01090", VA = "0x187E01E90")]
	private long MICBKJOGLKK(Type GDHKDBJPDLG)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal struct GAPPBCLPKIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeBitArray KEADBIMJEGC;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7E02540", Offset = "0x7E01740", VA = "0x187E02540")]
	public GAPPBCLPKIP(int OCEHNHGKKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7E022A0", Offset = "0x7E014A0", VA = "0x187E022A0")]
	public static GAPPBCLPKIP HECGPPDJNGE(int POKPPHJAIGN, NativeArray<OOPJKCMDMCJ> GFKOIMIAEOH)
	{
		return default(GAPPBCLPKIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7E021C0", Offset = "0x7E013C0", VA = "0x187E021C0")]
	public bool CBNEDOLOHPA(int CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E021D0", Offset = "0x7E013D0", VA = "0x187E021D0")]
	public void DEEMOOGCBGF(int CMDFFDAPDIB, bool KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E021F0", Offset = "0x7E013F0", VA = "0x187E021F0")]
	public bool GHOELHMHBHL(OOPJKCMDMCJ[] GFKOIMIAEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E02490", Offset = "0x7E01690", VA = "0x187E02490")]
	public bool MGCDHBAPECL(OOPJKCMDMCJ[] GFKOIMIAEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7E021E0", Offset = "0x7E013E0", VA = "0x187E021E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class KLHODPGFBGH
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly EJGCKAHLIPM AMCNLDBGKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<HEGPJOOKECN> CDDJOPOLEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly EKJPADMBMGP NIIAFBEIDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeParallelMultiHashMap<int, int> BBDHBDIJAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeList<int> JJEPGNHPIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public List<HEGPJOOKECN> JDKPHKMMCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7E04FB0", Offset = "0x7E041B0", VA = "0x187E04FB0")]
	public KLHODPGFBGH(EJGCKAHLIPM AMCNLDBGKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E03EE0", Offset = "0x7E030E0", VA = "0x187E03EE0")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E03FC0", Offset = "0x7E031C0", VA = "0x187E03FC0")]
	public void CJAOFCJDJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7E045C0", Offset = "0x7E037C0", VA = "0x187E045C0")]
	public NativeList<GDPCAOEIGNO> FKMIMNBAJII(NativeArray<OOPJKCMDMCJ> GFKOIMIAEOH)
	{
		return default(NativeList<GDPCAOEIGNO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E04180", Offset = "0x7E03380", VA = "0x187E04180")]
	private bool CKJMPPEEMKK(HEGPJOOKECN ADKBCBGPCJB, GAPPBCLPKIP OMOCNINJMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8D30", Offset = "0x3AB7F30", VA = "0x183AB8D30")]
	private void GPDKLGPFDIK<TInterface, TAttribute>(Action<TInterface, TAttribute> KMALGBNFCMI) where TInterface : HEGPJOOKECN where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7E04E10", Offset = "0x7E04010", VA = "0x187E04E10")]
	private void OJFFJABNHOC(Type GDHKDBJPDLG, Type MAMHOPOBMAP, Type IPJHHEJNJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8F40", Offset = "0x3AB8140", VA = "0x183AB8F40")]
	private TInterface KDMMHDDNKMM<TInterface>(Type GDHKDBJPDLG)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7E04E40", Offset = "0x7E04040", VA = "0x187E04E40")]
	private int PFHAGAOPJGD(HEGPJOOKECN JIGEBIJNNOJ, int JKPJMPOAKPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7E04AB0", Offset = "0x7E03CB0", VA = "0x187E04AB0")]
	private void HMJKBNPAIJE(PMBCFGKLBNM ADKBCBGPCJB, MCCLPHGHGDC HLHDEHABGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7E04250", Offset = "0x7E03450", VA = "0x187E04250")]
	private void CPLLJHCFPPM(BEDCGIOLHAP ADKBCBGPCJB, DNKFKMHJNEG HLHDEHABGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7E03DD0", Offset = "0x7E02FD0", VA = "0x187E03DD0")]
	private void ALEGIDNFOMH(OBBDGEFKCDK ADKBCBGPCJB, JGDDGKGIALH HLHDEHABGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E04D40", Offset = "0x7E03F40", VA = "0x187E04D40")]
	private void IMAIFGOLGFF(BLOCHGMPLJN ADKBCBGPCJB, JHDLANPJKBB HLHDEHABGKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KLNKLHMAENN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly List<HEGPJOOKECN> CDDJOPOLEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NativeList<GDPCAOEIGNO> LKMBKGBLCEH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NativeList<GDPCAOEIGNO> LLHCPMKKEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2A93520", Offset = "0x2A92720", VA = "0x182A93520")]
		get
		{
			return default(NativeList<GDPCAOEIGNO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E056B0", Offset = "0x7E048B0", VA = "0x187E056B0")]
	public KLNKLHMAENN(List<HEGPJOOKECN> CDDJOPOLEJN, NativeArray<GDPCAOEIGNO> CBKKCDNIPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E05110", Offset = "0x7E04310", VA = "0x187E05110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E05150", Offset = "0x7E04350", VA = "0x187E05150")]
	private NativeList<GDPCAOEIGNO> FOOBHPMILPM(NativeArray<GDPCAOEIGNO> ACPKPBFFPNO)
	{
		return default(NativeList<GDPCAOEIGNO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E055C0", Offset = "0x7E047C0", VA = "0x187E055C0")]
	private bool MKCGJOHDJCP(HEGPJOOKECN ADKBCBGPCJB, GAPPBCLPKIP OKOAKDJLNHI, OOPJKCMDMCJ MEGAJPAELNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E05480", Offset = "0x7E04680", VA = "0x187E05480")]
	private void JAMKCCIKDNB(HEGPJOOKECN ADKBCBGPCJB, GAPPBCLPKIP KEADBIMJEGC, OOPJKCMDMCJ GBOFDIKGPCE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct ONPMEHILPPC : IComparer<GDPCAOEIGNO>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E075E0", Offset = "0x7E067E0", VA = "0x187E075E0", Slot = "4")]
	public int Compare(GDPCAOEIGNO BGPKBCGBDMP, GDPCAOEIGNO NIJBGCGEGBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E075F0", Offset = "0x7E067F0", VA = "0x187E075F0")]
	public static void DNECOIMFKEA(NativeList<GDPCAOEIGNO> CBKKCDNIPCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class JHDLANPJKBB : GIHIKOLFNGF
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E03250", Offset = "0x7E02450", VA = "0x187E03250")]
	public JHDLANPJKBB(int OBFEBJHFBGN = 1)
	{
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
