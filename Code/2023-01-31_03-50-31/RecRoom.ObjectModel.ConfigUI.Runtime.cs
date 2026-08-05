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
internal abstract class EBPAFHGHPHO : global::LCAKJGEIBDF<Enum>, APFDBDFHKEC, NOMFBEGPHDP, CHFPDADGPHF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool IDAJFEJBPJG(Type IGEIBCJNCHF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6374DB0", Offset = "0x6373BB0", VA = "0x186374DB0")]
	protected EBPAFHGHPHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class LCAKJGEIBDF<T> : NOMFBEGPHDP, CHFPDADGPHF where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void NNBCEHLGBNM(Func<T> JLNFBOKNOEA, Action<T> IEOJBDIPJCJ, string IADPDEAGFAB, NOLDFLLDJKB FJONJLMIBBO, Func<bool> AOKCECNJBKN);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void AMOPOPHIBAF(Func<int> JLNFBOKNOEA, Action<int> IEOJBDIPJCJ, string IADPDEAGFAB, NOLDFLLDJKB FJONJLMIBBO, Func<bool> AOKCECNJBKN);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MMPGNDCOABB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public CIMNJIOJIIP targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public NOLDFLLDJKB property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public MMPGNDCOABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3827FB0", Offset = "0x3826DB0", VA = "0x183827FB0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3828090", Offset = "0x3826E90", VA = "0x183828090")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83CCD0", Offset = "0x83BAD0", VA = "0x18083CCD0")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ICMHEEODFMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::LCAKJGEIBDF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public JDFKGADHEGK ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public ICMHEEODFMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x32CEE10", Offset = "0x32CDC10", VA = "0x1832CEE10")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, NOLDFLLDJKB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NADMCEFGJKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public NADMCEFGJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D4A0", Offset = "0x3B9C2A0", VA = "0x183B9D4A0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D720", Offset = "0x3B9C520", VA = "0x183B9D720")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F910", Offset = "0x2E6E710", VA = "0x182E6F910")]
	protected LCAKJGEIBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F4C0", Offset = "0x2E6E2C0", VA = "0x182E6F4C0", Slot = "5")]
	public virtual void EKEBCGGHIHL(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO, JDFKGADHEGK HCKJEGFDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F710", Offset = "0x2E6E510", VA = "0x182E6F710", Slot = "6")]
	protected virtual NNBCEHLGBNM IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E6EFF0", Offset = "0x2E6DDF0", VA = "0x182E6EFF0", Slot = "7")]
	protected virtual AMOPOPHIBAF BAJLHAKCFHA(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F890", Offset = "0x2E6E690", VA = "0x182E6F890")]
	private static Enum MCEINMJHOPJ(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E6F180", Offset = "0x2E6DF80", VA = "0x182E6F180")]
	private static void BNAOOHHFIAH(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO, Enum DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class CLBMEMHDBLA : EACNEIHEHBE, CHFPDADGPHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NOLDFLLDJKB[] GGBFHIAGIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NOLDFLLDJKB[] BGMGJMOFIKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NOLDFLLDJKB[] DDOABIJANHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NOLDFLLDJKB[] NBIJMEMGPJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract ELBABKAKAAC[] PDCDHHHKCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract ELBABKAKAAC[] IBJDAGIDDGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6375310", Offset = "0x6374110", VA = "0x186375310", Slot = "6")]
	public void JGMOEBJPLEH(MFDIJJOFCMP KJBBHHLPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void EKEBCGGHIHL(CIMNJIOJIIP EPNJFCCHKIB, JDFKGADHEGK HCKJEGFDPNA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37A3330", Offset = "0x37A2130", VA = "0x1837A3330")]
	protected static T JNIJPJIGCEA<T>(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37A3380", Offset = "0x37A2180", VA = "0x1837A3380")]
	protected static void KNBBMABFAKM<T>(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO, T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	protected CLBMEMHDBLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class LLHNMAMBPIK<T> : NOMFBEGPHDP, CHFPDADGPHF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void IJPOIGCBOCI(Func<T> JLNFBOKNOEA, Action<T> IEOJBDIPJCJ, string IADPDEAGFAB, NOLDFLLDJKB FJONJLMIBBO, Func<bool> AOKCECNJBKN);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CIOBKDLNMFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CIMNJIOJIIP targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NOLDFLLDJKB property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public CIOBKDLNMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x47D7D40", Offset = "0x47D6B40", VA = "0x1847D7D40")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x47D7FA0", Offset = "0x47D6DA0", VA = "0x1847D7FA0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83CCD0", Offset = "0x83BAD0", VA = "0x18083CCD0")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4459F60", Offset = "0x4458D60", VA = "0x184459F60")]
	protected LLHNMAMBPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x44587E0", Offset = "0x44575E0", VA = "0x1844587E0", Slot = "4")]
	public void EKEBCGGHIHL(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO, JDFKGADHEGK HCKJEGFDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4459990", Offset = "0x4458790", VA = "0x184459990")]
	private static T JNIJPJIGCEA(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4459E50", Offset = "0x4458C50", VA = "0x184459E50")]
	private static void KNBBMABFAKM(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO, T DFEOJBAFBHE)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[LMNMHFHDONH(IPKPBIMLPOB.ConfigUI)]
	[DEJAKMDKDPE(typeof(HCKGMOJPOHJ), new string[] { })]
	internal class ConfigUIService : HCKGMOJPOHJ, COMOMFINKHP, BDDJKMOFDGN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[GNFGKNINDPI]
		private MFDIJJOFCMP KJBBHHLPGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[GNFGKNINDPI]
		private NIMHHIKGLPG GLAPLAOCNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[GNFGKNINDPI]
		private JDFKGADHEGK DPGEINJMFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private OHBAEBNNMLF AKGDHDKIJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CIMNJIOJIIP EPNJFCCHKIB;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63763C0", Offset = "0x63751C0", VA = "0x1863763C0", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6375D20", Offset = "0x6374B20", VA = "0x186375D20", Slot = "6")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6376020", Offset = "0x6374E20", VA = "0x186376020", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63757B0", Offset = "0x63745B0", VA = "0x1863757B0", Slot = "4")]
		public void BPAKHIELBHD(CIMNJIOJIIP LOFMELEJPEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6375720", Offset = "0x6374520", VA = "0x186375720")]
		private void BIDBDLADDOO(CIMNJIOJIIP LOFMELEJPEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6376110", Offset = "0x6374F10", VA = "0x186376110")]
		private void ECMKHCMNPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6376140", Offset = "0x6374F40", VA = "0x186376140")]
		private void EKEBCGGHIHL(FDDKPOFDJHH EJHAEKHHJBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[EFDNKCIGNEF(0)]
internal class CAALOCDAGAM : EBPAFHGHPHO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6374D00", Offset = "0x6373B00", VA = "0x186374D00", Slot = "9")]
	public override bool IDAJFEJBPJG(Type IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6374C10", Offset = "0x6373A10", VA = "0x186374C10", Slot = "6")]
	protected override NNBCEHLGBNM IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6374DB0", Offset = "0x6373BB0", VA = "0x186374DB0")]
	public CAALOCDAGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[EFDNKCIGNEF(0)]
internal class EGPDHONCBBJ : EBPAFHGHPHO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63768E0", Offset = "0x63756E0", VA = "0x1863768E0", Slot = "9")]
	public override bool IDAJFEJBPJG(Type IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63767F0", Offset = "0x63755F0", VA = "0x1863767F0", Slot = "6")]
	protected override NNBCEHLGBNM IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6374DB0", Offset = "0x6373BB0", VA = "0x186374DB0")]
	public EGPDHONCBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CCANOLFJIOC(typeof(PCBPGNABPLP), 1)]
internal class IBCJLCLNMEI : global::LCAKJGEIBDF<PCBPGNABPLP>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63780D0", Offset = "0x6376ED0", VA = "0x1863780D0", Slot = "7")]
	protected override AMOPOPHIBAF BAJLHAKCFHA(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63781C0", Offset = "0x6376FC0", VA = "0x1863781C0")]
	public IBCJLCLNMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KJMAMEKEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6378510", Offset = "0x6377310", VA = "0x186378510")]
	public static bool OFJKHACHKHA(this NOLDFLLDJKB FJONJLMIBBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[HKNJBFNFINI(2)]
internal class GPJJLJAIAND : CLBMEMHDBLA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DKLHJAGACDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CIMNJIOJIIP targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GPJJLJAIAND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public DKLHJAGACDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6376630", Offset = "0x6375430", VA = "0x186376630")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6376760", Offset = "0x6375560", VA = "0x186376760")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83CCD0", Offset = "0x83BAD0", VA = "0x18083CCD0")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override ELBABKAKAAC[] IBJDAGIDDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6377380", Offset = "0x6376180", VA = "0x186377380", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override ELBABKAKAAC[] PDCDHHHKCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6376EE0", Offset = "0x6375CE0", VA = "0x186376EE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6376FC0", Offset = "0x6375DC0", VA = "0x186376FC0", Slot = "10")]
	public override void EKEBCGGHIHL(CIMNJIOJIIP EPNJFCCHKIB, JDFKGADHEGK HCKJEGFDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public GPJJLJAIAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CCANOLFJIOC(typeof(bool))]
internal class HGOFOHLHLJB : global::LLHNMAMBPIK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6377FA0", Offset = "0x6376DA0", VA = "0x186377FA0", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6378090", Offset = "0x6376E90", VA = "0x186378090")]
	public HGOFOHLHLJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CCANOLFJIOC(typeof(FixedString32))]
internal class OCHLKNNIEGO : global::LLHNMAMBPIK<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GFEJPCFHIGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JDFKGADHEGK ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public GFEJPCFHIGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6376990", Offset = "0x6375790", VA = "0x186376990")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, NOLDFLLDJKB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KPNPNAJBNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public KPNPNAJBNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6378A60", Offset = "0x6377860", VA = "0x186378A60")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6378AD0", Offset = "0x63778D0", VA = "0x186378AD0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6379920", Offset = "0x6378720", VA = "0x186379920", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x63799E0", Offset = "0x63787E0", VA = "0x1863799E0")]
	public OCHLKNNIEGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CCANOLFJIOC(typeof(FixedString64))]
internal class CCAOOEELAAL : global::LLHNMAMBPIK<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DGAGNPCKHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JDFKGADHEGK ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public DGAGNPCKHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x63764A0", Offset = "0x63752A0", VA = "0x1863764A0")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, NOLDFLLDJKB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IMOOLANMAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public IMOOLANMAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63783E0", Offset = "0x63771E0", VA = "0x1863783E0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6378470", Offset = "0x6377270", VA = "0x186378470")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6374DF0", Offset = "0x6373BF0", VA = "0x186374DF0", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6374EB0", Offset = "0x6373CB0", VA = "0x186374EB0")]
	public CCAOOEELAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CCANOLFJIOC(typeof(float))]
internal class LCLFCMAOJBH : global::LLHNMAMBPIK<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6378B50", Offset = "0x6377950", VA = "0x186378B50", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6378C40", Offset = "0x6377A40", VA = "0x186378C40")]
	public LCLFCMAOJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CCANOLFJIOC(typeof(int))]
internal class ACGAAPMGBCG : global::LLHNMAMBPIK<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63748C0", Offset = "0x63736C0", VA = "0x1863748C0", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63749B0", Offset = "0x63737B0", VA = "0x1863749B0")]
	public ACGAAPMGBCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[CCANOLFJIOC(typeof(uint))]
internal class LFAGCKHAPNE : global::LLHNMAMBPIK<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IJEBMEHGPNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JDFKGADHEGK ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public IJEBMEHGPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6378200", Offset = "0x6377000", VA = "0x186378200")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, NOLDFLLDJKB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PCJAGJPAALM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public PCJAGJPAALM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x637ABE0", Offset = "0x63799E0", VA = "0x18637ABE0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x637AC30", Offset = "0x6379A30", VA = "0x18637AC30")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6378C80", Offset = "0x6377A80", VA = "0x186378C80", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6378D40", Offset = "0x6377B40", VA = "0x186378D40")]
	public LFAGCKHAPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[CCANOLFJIOC(typeof(Vector3))]
internal class MDBAEEHPBFH : global::LLHNMAMBPIK<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LPKNBFBINGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JDFKGADHEGK ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public LPKNBFBINGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6378D80", Offset = "0x6377B80", VA = "0x186378D80")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, NOLDFLLDJKB property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AHHJFHIAAPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public AHHJFHIAAPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63749F0", Offset = "0x63737F0", VA = "0x1863749F0")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6374A50", Offset = "0x6373850", VA = "0x186374A50")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6374A60", Offset = "0x6373860", VA = "0x186374A60")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6374AC0", Offset = "0x63738C0", VA = "0x186374AC0")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6374AD0", Offset = "0x63738D0", VA = "0x186374AD0")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6374B30", Offset = "0x6373930", VA = "0x186374B30")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x63790D0", Offset = "0x6377ED0", VA = "0x1863790D0", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6379190", Offset = "0x6377F90", VA = "0x186379190")]
	public MDBAEEHPBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct FDDKPOFDJHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int GMFCAECFEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int LFPJPFNFLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int BBCHOGHICAO;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class CCGICFDIKCF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6374EF0", Offset = "0x6373CF0", VA = "0x186374EF0")]
	public static void JOJMIANJLAJ(Type EOJNOFIBBFN, Type ACPIPFHPMJO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct GMKMECHCBBI
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6376D00", Offset = "0x6375B00", VA = "0x186376D00")]
	public static NativeList<int> HOLGJHAIOJD(CIMNJIOJIIP EPNJFCCHKIB, NIMHHIKGLPG GLAPLAOCNKE)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6376B20", Offset = "0x6375920", VA = "0x186376B20")]
	private static bool DEDKBICDBLI(NOLDFLLDJKB FJONJLMIBBO, CIMNJIOJIIP EPNJFCCHKIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class HGOCFBCPLME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly NIMHHIKGLPG GLAPLAOCNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly MFDIJJOFCMP KJBBHHLPGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JDFKGADHEGK HCKJEGFDPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<FDDKPOFDJHH> DPMLPMLJBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<IPECHNMOHGG> BAGNBDMLNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<IPECHNMOHGG, List<FDDKPOFDJHH>> AECGKCCDELI;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6377E80", Offset = "0x6376C80", VA = "0x186377E80")]
	public HGOCFBCPLME(NIMHHIKGLPG GLAPLAOCNKE, MFDIJJOFCMP KJBBHHLPGKO, JDFKGADHEGK HCKJEGFDPNA, Action<FDDKPOFDJHH> DPMLPMLJBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63774C0", Offset = "0x63762C0", VA = "0x1863774C0")]
	public void FIMNOEFGBHG(NativeList<FDDKPOFDJHH> CFGGCMMMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6377D60", Offset = "0x6376B60", VA = "0x186377D60")]
	private void MDCFGAHIAHA(IPECHNMOHGG JOKFNNKABBO, FDDKPOFDJHH EJHAEKHHJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6377460", Offset = "0x6376260", VA = "0x186377460")]
	public void AJAOMAKPCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x63778E0", Offset = "0x63766E0", VA = "0x1863778E0")]
	private void KNPAHBMNNLJ(IPECHNMOHGG JOKFNNKABBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6377840", Offset = "0x6376640", VA = "0x186377840")]
	private void FMFJELAJKAC(IPECHNMOHGG JOKFNNKABBO)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[LMNMHFHDONH(IPKPBIMLPOB.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KJNPNIMIPIG : IEnumerable<NOLDFLLDJKB>, IEnumerable, IEnumerator<NOLDFLLDJKB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private NOLDFLLDJKB <>2__current;

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
			private NOLDFLLDJKB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x973950", Offset = "0x972750", VA = "0x180973950")]
			[DebuggerHidden]
			public KJNPNIMIPIG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6378990", Offset = "0x6377790", VA = "0x186378990", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6378650", Offset = "0x6377450", VA = "0x186378650", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6378A10", Offset = "0x6377810", VA = "0x186378A10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6378950", Offset = "0x6377750", VA = "0x186378950", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x63788A0", Offset = "0x63776A0", VA = "0x1863788A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NOLDFLLDJKB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x63788A0", Offset = "0x63776A0", VA = "0x1863788A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly FBNJDMKEPCN KKLHLPEDHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MFDIJJOFCMP KJBBHHLPGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> BKJHJCBCFDJ;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x637AED0", Offset = "0x6379CD0", VA = "0x18637AED0")]
		public PropertiesByType(MFDIJJOFCMP KJBBHHLPGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x637ACF0", Offset = "0x6379AF0", VA = "0x18637ACF0")]
		[IteratorStateMachine(typeof(KJNPNIMIPIG))]
		public IEnumerable<NOLDFLLDJKB> AGMPJAIIGJH(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x637AD80", Offset = "0x6379B80", VA = "0x18637AD80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x637AE00", Offset = "0x6379C00", VA = "0x18637AE00")]
		private long KEFKNOPDKEL(NOLDFLLDJKB FJONJLMIBBO)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x637ADC0", Offset = "0x6379BC0", VA = "0x18637ADC0")]
		private long KEFKNOPDKEL(Type IGEIBCJNCHF)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct CKKGLCGBDKO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray DPIKJLNDNHO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x63752D0", Offset = "0x63740D0", VA = "0x1863752D0")]
	public CKKGLCGBDKO(int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6375180", Offset = "0x6373F80", VA = "0x186375180")]
	public static CKKGLCGBDKO NBCGGNFJHGH(int CIMAPKKBLKM, NativeArray<int> JDJBDCDEPOJ)
	{
		return default(CKKGLCGBDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6374FD0", Offset = "0x6373DD0", VA = "0x186374FD0")]
	public bool DIAPBLEJNDD(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6374FF0", Offset = "0x6373DF0", VA = "0x186374FF0")]
	public void FAFPJPFNCCD(int NPDGHPHAKDK, bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6375000", Offset = "0x6373E00", VA = "0x186375000")]
	public bool FFMFMKIFAJN(NOLDFLLDJKB[] JDJBDCDEPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63750C0", Offset = "0x6373EC0", VA = "0x1863750C0")]
	public bool IFABFKANHOI(NOLDFLLDJKB[] JDJBDCDEPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6374FE0", Offset = "0x6373DE0", VA = "0x186374FE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class OHBAEBNNMLF
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly FBNJDMKEPCN KKLHLPEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NIMHHIKGLPG GLAPLAOCNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MFDIJJOFCMP KJBBHHLPGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<CHFPDADGPHF> JHFOBHFKGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType BKJHJCBCFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> BCJOGJLNILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> BHMPFOAECHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<CHFPDADGPHF> BAIELKDAOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x637AA90", Offset = "0x6379890", VA = "0x18637AA90")]
	public OHBAEBNNMLF(NIMHHIKGLPG GLAPLAOCNKE, MFDIJJOFCMP KJBBHHLPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x637A700", Offset = "0x6379500", VA = "0x18637A700")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6379A20", Offset = "0x6378820", VA = "0x186379A20")]
	public void AHOGMINLLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6379F10", Offset = "0x6378D10", VA = "0x186379F10")]
	public NativeList<FDDKPOFDJHH> GMEGNGFMBEE(NativeArray<int> JDJBDCDEPOJ)
	{
		return default(NativeList<FDDKPOFDJHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x637A630", Offset = "0x6379430", VA = "0x18637A630")]
	private bool KBKCNOJCNHJ(CHFPDADGPHF IINLNCOCPGF, CKKGLCGBDKO OGKDIHAFBIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x33C5190", Offset = "0x33C3F90", VA = "0x1833C5190")]
	private void MNINBOIHCHA<TInterface, TAttribute>(Action<TInterface, TAttribute> IGGFHHEDAPI) where TInterface : CHFPDADGPHF where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6379EE0", Offset = "0x6378CE0", VA = "0x186379EE0")]
	private void DMHELOMPICK(Type IGEIBCJNCHF, Type FHMLLOKGAGH, Type BJCNJFOFJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x33C5130", Offset = "0x33C3F30", VA = "0x1833C5130")]
	private TInterface MCDKBGLJGOI<TInterface>(Type IGEIBCJNCHF)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x637A7D0", Offset = "0x63795D0", VA = "0x18637A7D0")]
	private void LMFDPEIFGEB(CHFPDADGPHF IINLNCOCPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6379B90", Offset = "0x6378990", VA = "0x186379B90")]
	private int ALHEEBCFMKF(CHFPDADGPHF EBFDFNHDGGE, int BBCHOGHICAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6379C30", Offset = "0x6378A30", VA = "0x186379C30")]
	private void BOFLDJEJDOB(NOMFBEGPHDP IINLNCOCPGF, CCANOLFJIOC CELBDMKCLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x637A370", Offset = "0x6379170", VA = "0x18637A370")]
	private void IBLGDHPLCDI(APFDBDFHKEC IINLNCOCPGF, EFDNKCIGNEF CELBDMKCLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x637A8A0", Offset = "0x63796A0", VA = "0x18637A8A0")]
	private void OFOJPIMGCGO(EACNEIHEHBE IINLNCOCPGF, HKNJBFNFINI CELBDMKCLBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct NGHIEBNHJCK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MFDIJJOFCMP KJBBHHLPGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<CHFPDADGPHF> JHFOBHFKGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<FDDKPOFDJHH> ENADGMKFPAC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<FDDKPOFDJHH> DEJOIJDONBN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x77D710", Offset = "0x77C510", VA = "0x18077D710")]
		get
		{
			return default(NativeList<FDDKPOFDJHH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63798A0", Offset = "0x63786A0", VA = "0x1863798A0")]
	public NGHIEBNHJCK(MFDIJJOFCMP KJBBHHLPGKO, List<CHFPDADGPHF> JHFOBHFKGOM, NativeArray<FDDKPOFDJHH> CFGGCMMMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63795D0", Offset = "0x63783D0", VA = "0x1863795D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63791D0", Offset = "0x6377FD0", VA = "0x1863791D0")]
	private NativeList<FDDKPOFDJHH> DGJNKEDHOHI(NativeArray<FDDKPOFDJHH> KBDJDKOJFLE)
	{
		return default(NativeList<FDDKPOFDJHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6379610", Offset = "0x6378410", VA = "0x186379610")]
	private bool KPBMAHINCLM(CHFPDADGPHF IINLNCOCPGF, CKKGLCGBDKO KIIHLDDBNOC, int LFPJPFNFLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63796E0", Offset = "0x63784E0", VA = "0x1863796E0")]
	private void LGFEOMCIPKC(CHFPDADGPHF IINLNCOCPGF, CKKGLCGBDKO DPIKJLNDNHO, int LFPJPFNFLED)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct PDABGJAENPN : IComparer<FDDKPOFDJHH>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x637AC90", Offset = "0x6379A90", VA = "0x18637AC90", Slot = "4")]
	public int Compare(FDDKPOFDJHH NCNGLFNLPAG, FDDKPOFDJHH OPGAGDBKIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x637ACA0", Offset = "0x6379AA0", VA = "0x18637ACA0")]
	public static void EEKEIPLAHKB(NativeList<FDDKPOFDJHH> CFGGCMMMGFO)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : GDNMPNNPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x637B1D0", Offset = "0x6379FD0", VA = "0x18637B1D0", Slot = "6")]
		public sealed override void EFMBJNCKONM(GEJJOANAKLE KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x637B2D0", Offset = "0x637A0D0", VA = "0x18637B2D0", Slot = "4")]
		public sealed override void JJOFCNGHIKE()
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
