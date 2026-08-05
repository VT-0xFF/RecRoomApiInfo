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
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F180A0", Offset = "0x6F16AA0", VA = "0x186F180A0", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x197E170", Offset = "0x197CB70", VA = "0x18197E170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C5A0", Offset = "0x6F1AFA0", VA = "0x186F1C5A0")]
		private void ACOMFCOBJKA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C7F0", Offset = "0x6F1B1F0", VA = "0x186F1C7F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C850", Offset = "0x6F1B250", VA = "0x186F1C850", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CF40", Offset = "0x6F1B940", VA = "0x186F1CF40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class AFOEKDFJPJP : GEFJHGPKEBN<Enum>, PGPHECMAOJA, BALIIDMICML, MEJOJAFIHKB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool HFKBCHMDBDC(Type BKKHBFLPOHJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F14B20", Offset = "0x6F13520", VA = "0x186F14B20")]
	protected AFOEKDFJPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal abstract class GEFJHGPKEBN<T> : BALIIDMICML, MEJOJAFIHKB where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KLMJFENNPFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public KAPMJNBAGLO property;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KLMJFENNPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4562C00", Offset = "0x4561600", VA = "0x184562C00")]
		internal bool CIOMDADMACD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x40E61E0", Offset = "0x40E4BE0", VA = "0x1840E61E0")]
	protected GEFJHGPKEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x40E5D80", Offset = "0x40E4780", VA = "0x1840E5D80")]
	protected void GJKKIOODGIN(APLLDNDJAGD FHMBDNEADLF, KAPMJNBAGLO JKKOEFMEAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x40E5B10", Offset = "0x40E4510", VA = "0x1840E5B10")]
	protected void ECAPAAKDFCP(OHLNFHKAOPN<T> FHMBDNEADLF, KAPMJNBAGLO JKKOEFMEAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class EOGFKIGHBCP : FLHFANDJNGC, MEJOJAFIHKB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract HAANENPBPKN[] AJBFOPELAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract HAANENPBPKN[] COODMDNHBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GIFBBGNBILK FFBALOHEAFH, HCCIFADLEDK INBPJBFKGBM, GJPBLCEMLGA JAPBCIFGNFP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2D6BB00", Offset = "0x2D6A500", VA = "0x182D6BB00")]
	protected static T CBBPABEJAOP<T>(JLGFNBKOOPK NHJDBLOCBFH, MEPBHNPODPL<T> JKKOEFMEAMD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2D6BB50", Offset = "0x2D6A550", VA = "0x182D6BB50")]
	protected static void GACHDHEOPDP<T>(JLGFNBKOOPK NHJDBLOCBFH, MEPBHNPODPL<T> JKKOEFMEAMD, T PKCLPFEIPFH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	protected EOGFKIGHBCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal abstract class AMHDKCOEGGC<T> : BALIIDMICML, MEJOJAFIHKB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JOELLJLBFCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KAPMJNBAGLO property;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JOELLJLBFCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4445EE0", Offset = "0x44448E0", VA = "0x184445EE0")]
		internal bool CIOMDADMACD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x415B6F0", Offset = "0x415A0F0", VA = "0x18415B6F0")]
	protected AMHDKCOEGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x415B2E0", Offset = "0x4159CE0", VA = "0x18415B2E0")]
	protected void GJKKIOODGIN(APLLDNDJAGD FHMBDNEADLF, KAPMJNBAGLO JKKOEFMEAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x415A180", Offset = "0x4158B80", VA = "0x18415A180")]
	protected void ECAPAAKDFCP(OHLNFHKAOPN<T> FHMBDNEADLF, KAPMJNBAGLO JKKOEFMEAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(GIFBBGNBILK), new string[] { })]
internal class OLLMKCMPMII : GIFBBGNBILK, IIBEELHAOEN, CGBLBMCHGNL, GPMHGHCNDML, DGPGGKHFMFC
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DependsOn]
	private HCCIFADLEDK INBPJBFKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[DependsOn]
	private GJPBLCEMLGA CLLMEABNFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private POMBOIMGMNI KOFKDJAMGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private JLGFNBKOOPK NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private List<KAPMJNBAGLO> AIAMOGEMLMG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JLGFNBKOOPK FHAEPMAPDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xED5150", Offset = "0xED3B50", VA = "0x180ED5150", Slot = "5")]
		get
		{
			return default(JLGFNBKOOPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A9D0", Offset = "0x6F193D0", VA = "0x186F1A9D0", Slot = "6")]
	public void OLJENCLOJEC(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A350", Offset = "0x6F18D50", VA = "0x186F1A350", Slot = "7")]
	public void ENOAJELNKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F19E20", Offset = "0x6F18820", VA = "0x186F19E20", Slot = "4")]
	public void DFLLFNPALIF(JLGFNBKOOPK FPJEGABFKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F19DA0", Offset = "0x6F187A0", VA = "0x186F19DA0")]
	private void CLCJFBIKBEH(JLGFNBKOOPK FPJEGABFKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A450", Offset = "0x6F18E50", VA = "0x186F1A450")]
	private void IOCLEAAHGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A650", Offset = "0x6F19050", VA = "0x186F1A650")]
	private void OHBLPNEFKGK(BPNFAGHJBGK NHIENMOKGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A960", Offset = "0x6F19360", VA = "0x186F1A960", Slot = "8")]
	private void OHIECHPGLCJ(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F19D60", Offset = "0x6F18760", VA = "0x186F19D60", Slot = "9")]
	private void ACPNJHKHIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ADA0", Offset = "0x6F197A0", VA = "0x186F1ADA0")]
	public OLLMKCMPMII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[IKAKOKNHAEB(0)]
internal class GJJMIDGELCK : AFOEKDFJPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F15B30", Offset = "0x6F14530", VA = "0x186F15B30", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F15A90", Offset = "0x6F14490", VA = "0x186F15A90", Slot = "7")]
	public override bool HFKBCHMDBDC(Type BKKHBFLPOHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F14B20", Offset = "0x6F13520", VA = "0x186F14B20")]
	public GJJMIDGELCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[IKAKOKNHAEB(0)]
internal class ADIOPLGBNPN : AFOEKDFJPJP
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F14A70", Offset = "0x6F13470", VA = "0x186F14A70", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F149C0", Offset = "0x6F133C0", VA = "0x186F149C0", Slot = "7")]
	public override bool HFKBCHMDBDC(Type BKKHBFLPOHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F14B20", Offset = "0x6F13520", VA = "0x186F14B20")]
	public ADIOPLGBNPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[LABJLELJHAC(typeof(DJGJAENKNLL), 1)]
internal class MDDBMMBLMMF : GEFJHGPKEBN<DJGJAENKNLL>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F18D70", Offset = "0x6F17770", VA = "0x186F18D70", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F18EC0", Offset = "0x6F178C0", VA = "0x186F18EC0")]
	public MDDBMMBLMMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DFOKJAAMFMH(2)]
internal class CKLGCHJCCKF : EOGFKIGHBCP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LEDCFOBPLFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GIFBBGNBILK configUIService;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LEDCFOBPLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F17F20", Offset = "0x6F16920", VA = "0x186F17F20")]
		internal (int, int) FFCLMBKMHEE()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F17E40", Offset = "0x6F16840", VA = "0x186F17E40")]
		internal void ADGKMJNDOIA((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override HAANENPBPKN[] AJBFOPELAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override HAANENPBPKN[] COODMDNHBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F14BF0", Offset = "0x6F135F0", VA = "0x186F14BF0", Slot = "9")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GIFBBGNBILK FFBALOHEAFH, HCCIFADLEDK INBPJBFKGBM, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F14FC0", Offset = "0x6F139C0", VA = "0x186F14FC0")]
	public CKLGCHJCCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[LABJLELJHAC(typeof(bool))]
internal class HFGHAHHGKMB : AMHDKCOEGGC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F16000", Offset = "0x6F14A00", VA = "0x186F16000", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F16090", Offset = "0x6F14A90", VA = "0x186F16090")]
	public HFGHAHHGKMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[LABJLELJHAC(typeof(FixedString32Bytes))]
internal class MHIFDDOHKDJ : AMHDKCOEGGC<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class EINIJJHJFKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KAPMJNBAGLO property;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EINIJJHJFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F155C0", Offset = "0x6F13FC0", VA = "0x186F155C0")]
		internal string FFCLMBKMHEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6F15550", Offset = "0x6F13F50", VA = "0x186F15550")]
		internal void ADGKMJNDOIA(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F18F00", Offset = "0x6F17900", VA = "0x186F18F00", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F190A0", Offset = "0x6F17AA0", VA = "0x186F190A0")]
	public MHIFDDOHKDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[LABJLELJHAC(typeof(FixedString64Bytes))]
internal class IKCCNAIBEJI : AMHDKCOEGGC<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IBDEFGCABLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public KAPMJNBAGLO property;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public IBDEFGCABLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F16160", Offset = "0x6F14B60", VA = "0x186F16160")]
		internal string FFCLMBKMHEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F160D0", Offset = "0x6F14AD0", VA = "0x186F160D0")]
		internal void ADGKMJNDOIA(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F161E0", Offset = "0x6F14BE0", VA = "0x186F161E0", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F16380", Offset = "0x6F14D80", VA = "0x186F16380")]
	public IKCCNAIBEJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[LABJLELJHAC(typeof(float3))]
internal class EODDLGIOFHM : AMHDKCOEGGC<float3>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class OCOLDLJEJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KAPMJNBAGLO property;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public OCOLDLJEJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F19AA0", Offset = "0x6F184A0", VA = "0x186F19AA0")]
		internal float FFCLMBKMHEE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F19A90", Offset = "0x6F18490", VA = "0x186F19A90")]
		internal void ADGKMJNDOIA(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F19B80", Offset = "0x6F18580", VA = "0x186F19B80")]
		internal float GJOJJEGAKPA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6F19CD0", Offset = "0x6F186D0", VA = "0x186F19CD0")]
		internal void JEJJDEDBKNB(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6F19CE0", Offset = "0x6F186E0", VA = "0x186F19CE0")]
		internal float NOLBMAHLEIO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6F19D50", Offset = "0x6F18750", VA = "0x186F19D50")]
		internal void PFALPAEEDKG(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6F19B10", Offset = "0x6F18510", VA = "0x186F19B10")]
		internal float FMPLPKHHJAM(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F19BF0", Offset = "0x6F185F0", VA = "0x186F19BF0")]
		internal void HLDBBMKOFKJ(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F15620", Offset = "0x6F14020", VA = "0x186F15620", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F15A50", Offset = "0x6F14450", VA = "0x186F15A50")]
	public EODDLGIOFHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[LABJLELJHAC(typeof(float))]
internal class HCIGMMMEAIJ : AMHDKCOEGGC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F15BE0", Offset = "0x6F145E0", VA = "0x186F15BE0", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F15C70", Offset = "0x6F14670", VA = "0x186F15C70")]
	public HCIGMMMEAIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[LABJLELJHAC(typeof(int))]
internal class MMPEJBAOPOP : AMHDKCOEGGC<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F190E0", Offset = "0x6F17AE0", VA = "0x186F190E0", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F19170", Offset = "0x6F17B70", VA = "0x186F19170")]
	public MMPEJBAOPOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[LABJLELJHAC(typeof(quaternion))]
internal class KHKMHINHOPL : AMHDKCOEGGC<quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KBIDIPKDLIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public KAPMJNBAGLO property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KBIDIPKDLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F16C10", Offset = "0x6F15610", VA = "0x186F16C10")]
		internal float FFCLMBKMHEE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6F16C00", Offset = "0x6F15600", VA = "0x186F16C00")]
		internal void ADGKMJNDOIA(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6F16C20", Offset = "0x6F15620", VA = "0x186F16C20")]
		internal float GJOJJEGAKPA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F16DA0", Offset = "0x6F157A0", VA = "0x186F16DA0")]
		internal void JEJJDEDBKNB(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F16DB0", Offset = "0x6F157B0", VA = "0x186F16DB0")]
		internal float NOLBMAHLEIO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F17020", Offset = "0x6F15A20", VA = "0x186F17020")]
		internal void PFALPAEEDKG(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F16C30", Offset = "0x6F15630", VA = "0x186F16C30")]
		internal float GLDBKHAKHOA(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6F16DC0", Offset = "0x6F157C0", VA = "0x186F16DC0")]
		internal void PCKAEFGKKEJ(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F17030", Offset = "0x6F15A30", VA = "0x186F17030", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F17460", Offset = "0x6F15E60", VA = "0x186F17460")]
	public KHKMHINHOPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[LABJLELJHAC(typeof(uint))]
internal class KMOGEOPJEJP : AMHDKCOEGGC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class BJMLFIKHFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KAPMJNBAGLO property;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BJMLFIKHFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6F14BB0", Offset = "0x6F135B0", VA = "0x186F14BB0")]
		internal int FFCLMBKMHEE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6F14B60", Offset = "0x6F13560", VA = "0x186F14B60")]
		internal void ADGKMJNDOIA(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F174A0", Offset = "0x6F15EA0", VA = "0x186F174A0", Slot = "5")]
	public override void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F17640", Offset = "0x6F16040", VA = "0x186F17640")]
	public KMOGEOPJEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal struct BPNFAGHJBGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int PNDFLDINNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public HAANENPBPKN JKKOEFMEAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int OFKEGOMNGIE;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class NKCBBAGOPEG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F191B0", Offset = "0x6F17BB0", VA = "0x186F191B0")]
	public static void GNAGLOIPHPG(Type EGLKMJPAGGM, Type APNCFCIECDA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct HDFOGLDLDND
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F15DA0", Offset = "0x6F147A0", VA = "0x186F15DA0")]
	public static NativeList<HAANENPBPKN> LFPEFNOKHOI(JLGFNBKOOPK NHJDBLOCBFH, HCCIFADLEDK INBPJBFKGBM)
	{
		return default(NativeList<HAANENPBPKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F15CB0", Offset = "0x6F146B0", VA = "0x186F15CB0")]
	private static bool ALHEGOPLCGO(HAANENPBPKN JKKOEFMEAMD, JLGFNBKOOPK NHJDBLOCBFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KOCHHEAPAAJ : KAPMJNBAGLO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HAANENPBPKN JKKOEFMEAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HCCIFADLEDK OEDJHEBOFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly JLGFNBKOOPK NHJDBLOCBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F17680", Offset = "0x6F16080", VA = "0x186F17680", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PEPIFPBONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F17A80", Offset = "0x6F16480", VA = "0x186F17A80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FBPGMFLLCMG DMFMIJMACMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F17B10", Offset = "0x6F16510", VA = "0x186F17B10", Slot = "8")]
		get
		{
			return default(FBPGMFLLCMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type DLLABFENMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F17B60", Offset = "0x6F16560", VA = "0x186F17B60", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action MLPOPDKHCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F17BC0", Offset = "0x6F165C0", VA = "0x186F17BC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6F17910", Offset = "0x6F16310", VA = "0x186F17910", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F17D40", Offset = "0x6F16740", VA = "0x186F17D40")]
	public KOCHHEAPAAJ(JLGFNBKOOPK NHJDBLOCBFH, HAANENPBPKN JKKOEFMEAMD, HCCIFADLEDK OEDJHEBOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F17800", Offset = "0x6F16200", VA = "0x186F17800")]
	private void CKDPKLLHLEH(MDOMNFDGKMA GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F17C60", Offset = "0x6F16660", VA = "0x186F17C60", Slot = "10")]
	public void KJCABELIABF(PFLMKDOBNJI PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F176E0", Offset = "0x6F160E0", VA = "0x186F176E0", Slot = "11")]
	public void CADIEIMFLMA(NPHBBIONIHJ PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F179B0", Offset = "0x6F163B0", VA = "0x186F179B0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ADHACFPKKGJ(1)]
internal sealed class PJPCNMEDGHI : NKCAEPEHJJA, BALIIDMICML, MEJOJAFIHKB
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JCKFOBOAJNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KAPMJNBAGLO property;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public JCKFOBOAJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F16A40", Offset = "0x6F15440", VA = "0x186F16A40")]
		internal bool FFCLMBKMHEE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F169C0", Offset = "0x6F153C0", VA = "0x186F169C0")]
		internal string ADGKMJNDOIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F16A90", Offset = "0x6F15490", VA = "0x186F16A90")]
		internal void GJOJJEGAKPA(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F16B20", Offset = "0x6F15520", VA = "0x186F16B20")]
		internal string JEJJDEDBKNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HAANENPBPKN HIFFIALDCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F1AE30", Offset = "0x6F19830", VA = "0x186F1AE30", Slot = "4")]
		get
		{
			return default(HAANENPBPKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AEA0", Offset = "0x6F198A0", VA = "0x186F1AEA0", Slot = "5")]
	public void OHBLPNEFKGK(KAPMJNBAGLO JKKOEFMEAMD, GJPBLCEMLGA JAPBCIFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public PJPCNMEDGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class MCOINPHIGHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HCCIFADLEDK INBPJBFKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly GJPBLCEMLGA JAPBCIFGNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<BPNFAGHJBGK> IFPLLCOIADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<EOBGAELGDNE> PMOPOAAEBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<EOBGAELGDNE, List<BPNFAGHJBGK>> JGBOFBKPLIG;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F18C50", Offset = "0x6F17650", VA = "0x186F18C50")]
	public MCOINPHIGHD(HCCIFADLEDK INBPJBFKGBM, GJPBLCEMLGA JAPBCIFGNFP, Action<BPNFAGHJBGK> IFPLLCOIADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F186D0", Offset = "0x6F170D0", VA = "0x186F186D0")]
	public void HPPMMHNKCDI(NativeList<BPNFAGHJBGK> POHBLLACGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F18A50", Offset = "0x6F17450", VA = "0x186F18A50")]
	private void KNGFFKHAJDH(EOBGAELGDNE FPJLBCBAPGI, BPNFAGHJBGK NHIENMOKGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F18BF0", Offset = "0x6F175F0", VA = "0x186F18BF0")]
	public void OGNJJPMHFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F18250", Offset = "0x6F16C50", VA = "0x186F18250")]
	private void FLPHACKLEPE(EOBGAELGDNE FPJLBCBAPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F181B0", Offset = "0x6F16BB0", VA = "0x186F181B0")]
	private void FAGFPMHDFKO(EOBGAELGDNE FPJLBCBAPGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class DBHFOLJLLAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OAKMMJFLFDL : IEnumerable<HAANENPBPKN>, IEnumerable, IEnumerator<HAANENPBPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private HAANENPBPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public DBHFOLJLLAI <>4__this;

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
		private HAANENPBPKN System.Collections.Generic.IEnumerator<RecRoom.DataLayer.NetworkProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA10880", Offset = "0xA0F280", VA = "0x180A10880", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HAANENPBPKN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6F199B0", Offset = "0x6F183B0", VA = "0x186F199B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD95FE0", Offset = "0xD949E0", VA = "0x180D95FE0")]
		[DebuggerHidden]
		public OAKMMJFLFDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F19A00", Offset = "0x6F18400", VA = "0x186F19A00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F19640", Offset = "0x6F18040", VA = "0x186F19640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F195F0", Offset = "0x6F17FF0", VA = "0x186F195F0")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F19960", Offset = "0x6F18360", VA = "0x186F19960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F198A0", Offset = "0x6F182A0", VA = "0x186F198A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HAANENPBPKN> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F198A0", Offset = "0x6F182A0", VA = "0x186F198A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeParallelMultiHashMap<long, int> KJDFPOOAMNE;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F15300", Offset = "0x6F13D00", VA = "0x186F15300")]
	public DBHFOLJLLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F151E0", Offset = "0x6F13BE0", VA = "0x186F151E0")]
	[IteratorStateMachine(typeof(OAKMMJFLFDL))]
	public IEnumerable<HAANENPBPKN> EEOFEEOINDN(Type BKKHBFLPOHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F151A0", Offset = "0x6F13BA0", VA = "0x186F151A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F150E0", Offset = "0x6F13AE0", VA = "0x186F150E0")]
	private long CPOCMHJGBEE(HAANENPBPKN JKKOEFMEAMD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F15160", Offset = "0x6F13B60", VA = "0x186F15160")]
	private long CPOCMHJGBEE(Type BKKHBFLPOHJ)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal struct NOJLFMINKOF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeBitArray LHFMMONGLLH;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6F19590", Offset = "0x6F17F90", VA = "0x186F19590")]
	public NOJLFMINKOF(int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6F19410", Offset = "0x6F17E10", VA = "0x186F19410")]
	public static NOJLFMINKOF INGHAPFEGHK(int LFENHKJMLMG, NativeArray<HAANENPBPKN> FPNIMNHKJCC)
	{
		return default(NOJLFMINKOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F19280", Offset = "0x6F17C80", VA = "0x186F19280")]
	public bool BGGCJBKGOLN(int GCBONJOGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F19290", Offset = "0x6F17C90", VA = "0x186F19290")]
	public void CADIEIMFLMA(int GCBONJOGHCD, bool PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F192B0", Offset = "0x6F17CB0", VA = "0x186F192B0")]
	public bool FOBKGKLHFPO(HAANENPBPKN[] FPNIMNHKJCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F19360", Offset = "0x6F17D60", VA = "0x186F19360")]
	public bool HDCPIDFMNFM(HAANENPBPKN[] FPNIMNHKJCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F192A0", Offset = "0x6F17CA0", VA = "0x186F192A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class POMBOIMGMNI
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly HCCIFADLEDK INBPJBFKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<MEJOJAFIHKB> FOMGOENJFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly DBHFOLJLLAI KJDFPOOAMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeParallelMultiHashMap<int, int> DFBCBKKJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeList<int> CFAEIKPFDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool MOGBFDJDEOF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public List<MEJOJAFIHKB> PCKGKJCGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C440", Offset = "0x6F1AE40", VA = "0x186F1C440")]
	public POMBOIMGMNI(HCCIFADLEDK INBPJBFKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C170", Offset = "0x6F1AB70", VA = "0x186F1C170")]
	public void JFMJGMNFMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BFB0", Offset = "0x6F1A9B0", VA = "0x186F1BFB0")]
	public void ICPAGNLELJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B780", Offset = "0x6F1A180", VA = "0x186F1B780")]
	public NativeList<BPNFAGHJBGK> GHHABFBBOMI(NativeArray<HAANENPBPKN> FPNIMNHKJCC)
	{
		return default(NativeList<BPNFAGHJBGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C250", Offset = "0x6F1AC50", VA = "0x186F1C250")]
	private bool MCOIGPFGNDD(MEJOJAFIHKB PBKNLCHBHIH, NOJLFMINKOF CGJEECFAEFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3097C30", Offset = "0x3096630", VA = "0x183097C30")]
	private void IBMBBIIIOEK<TInterface, TAttribute>(Action<TInterface, TAttribute> DGNIMPLCENK) where TInterface : MEJOJAFIHKB where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BF80", Offset = "0x6F1A980", VA = "0x186F1BF80")]
	private void HBMFBGFDBIJ(Type BKKHBFLPOHJ, Type NEBMMKJDCHE, Type COKGIICLLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3097E90", Offset = "0x3096890", VA = "0x183097E90")]
	private TInterface KIBMNMIANFM<TInterface>(Type BKKHBFLPOHJ)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C320", Offset = "0x6F1AD20", VA = "0x186F1C320")]
	private int MIHMEDBGHBB(MEJOJAFIHKB JOCHLDFCNHJ, int OFKEGOMNGIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B310", Offset = "0x6F19D10", VA = "0x186F1B310")]
	private void DEHKNNMGJFC(BALIIDMICML PBKNLCHBHIH, LABJLELJHAC AFFEMJLMGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BC70", Offset = "0x6F1A670", VA = "0x186F1BC70")]
	private void GPDNBGOJDOC(PGPHECMAOJA PBKNLCHBHIH, IKAKOKNHAEB AFFEMJLMGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B5A0", Offset = "0x6F19FA0", VA = "0x186F1B5A0")]
	private void DMEGGJCICLK(FLHFANDJNGC PBKNLCHBHIH, DFOKJAAMFMH AFFEMJLMGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B6B0", Offset = "0x6F1A0B0", VA = "0x186F1B6B0")]
	private void GBMJDGGIDJB(NKCAEPEHJJA PBKNLCHBHIH, ADHACFPKKGJ AFFEMJLMGLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct IKNLBOBHILK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly List<MEJOJAFIHKB> FOMGOENJFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NativeList<BPNFAGHJBGK> GNFOKINEPCC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NativeList<BPNFAGHJBGK> LKBIKAEGONC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2861420", Offset = "0x285FE20", VA = "0x182861420")]
		get
		{
			return default(NativeList<BPNFAGHJBGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F16960", Offset = "0x6F15360", VA = "0x186F16960")]
	public IKNLBOBHILK(List<MEJOJAFIHKB> FOMGOENJFEJ, NativeArray<BPNFAGHJBGK> POHBLLACGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F163C0", Offset = "0x6F14DC0", VA = "0x186F163C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F164F0", Offset = "0x6F14EF0", VA = "0x186F164F0")]
	private NativeList<BPNFAGHJBGK> NDKINDAJFHM(NativeArray<BPNFAGHJBGK> DHKDFCNEAHG)
	{
		return default(NativeList<BPNFAGHJBGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F16400", Offset = "0x6F14E00", VA = "0x186F16400")]
	private bool EAGLFEDLGDK(MEJOJAFIHKB PBKNLCHBHIH, NOJLFMINKOF CNGHNGHCPKP, HAANENPBPKN JKKOEFMEAMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F16820", Offset = "0x6F15220", VA = "0x186F16820")]
	private void PNMFOKGEKBM(MEJOJAFIHKB PBKNLCHBHIH, NOJLFMINKOF LHFMMONGLLH, HAANENPBPKN MCCICLPJEFE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct DLLNDOKLGFH : IComparer<BPNFAGHJBGK>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F154F0", Offset = "0x6F13EF0", VA = "0x186F154F0", Slot = "4")]
	public int Compare(BPNFAGHJBGK PEMPEACEHBG, BPNFAGHJBGK FDDPOELCNDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F15500", Offset = "0x6F13F00", VA = "0x186F15500")]
	public static void GOMFIMJFMEC(NativeList<BPNFAGHJBGK> POHBLLACGLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class ADHACFPKKGJ : NFPCMNBBBFO
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F149B0", Offset = "0x6F133B0", VA = "0x186F149B0")]
	public ADHACFPKKGJ(int NIPGNMFIFME = 1)
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
