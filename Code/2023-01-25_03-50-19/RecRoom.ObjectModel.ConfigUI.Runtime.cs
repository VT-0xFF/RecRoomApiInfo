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
	[Cpp2IlInjected.Address(RVA = "0x60343F0", Offset = "0x60333F0", VA = "0x1860343F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public MMPGNDCOABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x24CDF30", Offset = "0x24CCF30", VA = "0x1824CDF30")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24CE010", Offset = "0x24CD010", VA = "0x1824CE010")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67E030", Offset = "0x67D030", VA = "0x18067E030")]
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
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public ICMHEEODFMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x224C830", Offset = "0x224B830", VA = "0x18224C830")]
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
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public NADMCEFGJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x238F030", Offset = "0x238E030", VA = "0x18238F030")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x238F2B0", Offset = "0x238E2B0", VA = "0x18238F2B0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2080EE0", Offset = "0x207FEE0", VA = "0x182080EE0")]
	protected LCAKJGEIBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2080A90", Offset = "0x207FA90", VA = "0x182080A90", Slot = "5")]
	public virtual void EKEBCGGHIHL(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO, JDFKGADHEGK HCKJEGFDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2080CE0", Offset = "0x207FCE0", VA = "0x182080CE0", Slot = "6")]
	protected virtual NNBCEHLGBNM IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20805C0", Offset = "0x207F5C0", VA = "0x1820805C0", Slot = "7")]
	protected virtual AMOPOPHIBAF BAJLHAKCFHA(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2080E60", Offset = "0x207FE60", VA = "0x182080E60")]
	private static Enum MCEINMJHOPJ(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2080750", Offset = "0x207F750", VA = "0x182080750")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FAC0", Offset = "0x67EAC0", VA = "0x18067FAC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NOLDFLLDJKB[] NBIJMEMGPJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6034950", Offset = "0x6033950", VA = "0x186034950", Slot = "6")]
	public void JGMOEBJPLEH(MFDIJJOFCMP KJBBHHLPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void EKEBCGGHIHL(CIMNJIOJIIP EPNJFCCHKIB, JDFKGADHEGK HCKJEGFDPNA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x22E55A0", Offset = "0x22E45A0", VA = "0x1822E55A0")]
	protected static T JNIJPJIGCEA<T>(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x22E55F0", Offset = "0x22E45F0", VA = "0x1822E55F0")]
	protected static void KNBBMABFAKM<T>(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO, T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public CIOBKDLNMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3EAABA0", Offset = "0x3EA9BA0", VA = "0x183EAABA0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3EAAE00", Offset = "0x3EA9E00", VA = "0x183EAAE00")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67E030", Offset = "0x67D030", VA = "0x18067E030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x208DF90", Offset = "0x208CF90", VA = "0x18208DF90")]
	protected LLHNMAMBPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x208CB20", Offset = "0x208BB20", VA = "0x18208CB20", Slot = "4")]
	public void EKEBCGGHIHL(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO, JDFKGADHEGK HCKJEGFDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x208D9C0", Offset = "0x208C9C0", VA = "0x18208D9C0")]
	private static T JNIJPJIGCEA(CIMNJIOJIIP EPNJFCCHKIB, NOLDFLLDJKB FJONJLMIBBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x208DE80", Offset = "0x208CE80", VA = "0x18208DE80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6035A00", Offset = "0x6034A00", VA = "0x186035A00", Slot = "5")]
		public void MMDJBGIHOMB(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6035360", Offset = "0x6034360", VA = "0x186035360", Slot = "6")]
		public void BPIAPAMCDPP(OKKPKCPMOFL GNDGFHCLBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6035660", Offset = "0x6034660", VA = "0x186035660", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6034DF0", Offset = "0x6033DF0", VA = "0x186034DF0", Slot = "4")]
		public void BPAKHIELBHD(CIMNJIOJIIP LOFMELEJPEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6034D60", Offset = "0x6033D60", VA = "0x186034D60")]
		private void BIDBDLADDOO(CIMNJIOJIIP LOFMELEJPEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6035750", Offset = "0x6034750", VA = "0x186035750")]
		private void ECMKHCMNPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6035780", Offset = "0x6034780", VA = "0x186035780")]
		private void EKEBCGGHIHL(FDDKPOFDJHH EJHAEKHHJBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6034340", Offset = "0x6033340", VA = "0x186034340", Slot = "9")]
	public override bool IDAJFEJBPJG(Type IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6034250", Offset = "0x6033250", VA = "0x186034250", Slot = "6")]
	protected override NNBCEHLGBNM IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60343F0", Offset = "0x60333F0", VA = "0x1860343F0")]
	public CAALOCDAGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[EFDNKCIGNEF(0)]
internal class EGPDHONCBBJ : EBPAFHGHPHO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6035F20", Offset = "0x6034F20", VA = "0x186035F20", Slot = "9")]
	public override bool IDAJFEJBPJG(Type IGEIBCJNCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6035E30", Offset = "0x6034E30", VA = "0x186035E30", Slot = "6")]
	protected override NNBCEHLGBNM IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60343F0", Offset = "0x60333F0", VA = "0x1860343F0")]
	public EGPDHONCBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CCANOLFJIOC(typeof(PCBPGNABPLP), 1)]
internal class IBCJLCLNMEI : global::LCAKJGEIBDF<PCBPGNABPLP>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6037710", Offset = "0x6036710", VA = "0x186037710", Slot = "7")]
	protected override AMOPOPHIBAF BAJLHAKCFHA(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6037800", Offset = "0x6036800", VA = "0x186037800")]
	public IBCJLCLNMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KJMAMEKEGEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6037B50", Offset = "0x6036B50", VA = "0x186037B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DKLHJAGACDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6035C70", Offset = "0x6034C70", VA = "0x186035C70")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6035DA0", Offset = "0x6034DA0", VA = "0x186035DA0")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x67E030", Offset = "0x67D030", VA = "0x18067E030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override ELBABKAKAAC[] IBJDAGIDDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60369C0", Offset = "0x60359C0", VA = "0x1860369C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override ELBABKAKAAC[] PDCDHHHKCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6036520", Offset = "0x6035520", VA = "0x186036520", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6036600", Offset = "0x6035600", VA = "0x186036600", Slot = "10")]
	public override void EKEBCGGHIHL(CIMNJIOJIIP EPNJFCCHKIB, JDFKGADHEGK HCKJEGFDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public GPJJLJAIAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CCANOLFJIOC(typeof(bool))]
internal class HGOFOHLHLJB : global::LLHNMAMBPIK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60375E0", Offset = "0x60365E0", VA = "0x1860375E0", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60376D0", Offset = "0x60366D0", VA = "0x1860376D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public GFEJPCFHIGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6035FD0", Offset = "0x6034FD0", VA = "0x186035FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public KPNPNAJBNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60380A0", Offset = "0x60370A0", VA = "0x1860380A0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6038110", Offset = "0x6037110", VA = "0x186038110")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6038F60", Offset = "0x6037F60", VA = "0x186038F60", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6039020", Offset = "0x6038020", VA = "0x186039020")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public DGAGNPCKHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6035AE0", Offset = "0x6034AE0", VA = "0x186035AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IMOOLANMAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6037A20", Offset = "0x6036A20", VA = "0x186037A20")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6037AB0", Offset = "0x6036AB0", VA = "0x186037AB0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6034430", Offset = "0x6033430", VA = "0x186034430", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x60344F0", Offset = "0x60334F0", VA = "0x1860344F0")]
	public CCAOOEELAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CCANOLFJIOC(typeof(float))]
internal class LCLFCMAOJBH : global::LLHNMAMBPIK<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6038190", Offset = "0x6037190", VA = "0x186038190", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6038280", Offset = "0x6037280", VA = "0x186038280")]
	public LCLFCMAOJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CCANOLFJIOC(typeof(int))]
internal class ACGAAPMGBCG : global::LLHNMAMBPIK<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6033F00", Offset = "0x6032F00", VA = "0x186033F00", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6033FF0", Offset = "0x6032FF0", VA = "0x186033FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public IJEBMEHGPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6037840", Offset = "0x6036840", VA = "0x186037840")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public PCJAGJPAALM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x603A220", Offset = "0x6039220", VA = "0x18603A220")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x603A270", Offset = "0x6039270", VA = "0x18603A270")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60382C0", Offset = "0x60372C0", VA = "0x1860382C0", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6038380", Offset = "0x6037380", VA = "0x186038380")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public LPKNBFBINGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x60383C0", Offset = "0x60373C0", VA = "0x1860383C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public AHHJFHIAAPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6034030", Offset = "0x6033030", VA = "0x186034030")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6034090", Offset = "0x6033090", VA = "0x186034090")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60340A0", Offset = "0x60330A0", VA = "0x1860340A0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6034100", Offset = "0x6033100", VA = "0x186034100")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6034110", Offset = "0x6033110", VA = "0x186034110")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6034170", Offset = "0x6033170", VA = "0x186034170")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6038710", Offset = "0x6037710", VA = "0x186038710", Slot = "5")]
	protected override IJPOIGCBOCI IBOEICGEKEL(JDFKGADHEGK HCKJEGFDPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60387D0", Offset = "0x60377D0", VA = "0x1860387D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6034530", Offset = "0x6033530", VA = "0x186034530")]
	public static void JOJMIANJLAJ(Type EOJNOFIBBFN, Type ACPIPFHPMJO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct GMKMECHCBBI
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6036340", Offset = "0x6035340", VA = "0x186036340")]
	public static NativeList<int> HOLGJHAIOJD(CIMNJIOJIIP EPNJFCCHKIB, NIMHHIKGLPG GLAPLAOCNKE)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6036160", Offset = "0x6035160", VA = "0x186036160")]
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
	[Cpp2IlInjected.Address(RVA = "0x60374C0", Offset = "0x60364C0", VA = "0x1860374C0")]
	public HGOCFBCPLME(NIMHHIKGLPG GLAPLAOCNKE, MFDIJJOFCMP KJBBHHLPGKO, JDFKGADHEGK HCKJEGFDPNA, Action<FDDKPOFDJHH> DPMLPMLJBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6036B00", Offset = "0x6035B00", VA = "0x186036B00")]
	public void FIMNOEFGBHG(NativeList<FDDKPOFDJHH> CFGGCMMMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60373A0", Offset = "0x60363A0", VA = "0x1860373A0")]
	private void MDCFGAHIAHA(IPECHNMOHGG JOKFNNKABBO, FDDKPOFDJHH EJHAEKHHJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6036AA0", Offset = "0x6035AA0", VA = "0x186036AA0")]
	public void AJAOMAKPCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6036F20", Offset = "0x6035F20", VA = "0x186036F20")]
	private void KNPAHBMNNLJ(IPECHNMOHGG JOKFNNKABBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6036E80", Offset = "0x6035E80", VA = "0x186036E80")]
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x85A6E0", Offset = "0x8596E0", VA = "0x18085A6E0")]
			[DebuggerHidden]
			public KJNPNIMIPIG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6037FD0", Offset = "0x6036FD0", VA = "0x186037FD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6037C90", Offset = "0x6036C90", VA = "0x186037C90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6038050", Offset = "0x6037050", VA = "0x186038050")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6037F90", Offset = "0x6036F90", VA = "0x186037F90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6037EE0", Offset = "0x6036EE0", VA = "0x186037EE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NOLDFLLDJKB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6037EE0", Offset = "0x6036EE0", VA = "0x186037EE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x603A510", Offset = "0x6039510", VA = "0x18603A510")]
		public PropertiesByType(MFDIJJOFCMP KJBBHHLPGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x603A330", Offset = "0x6039330", VA = "0x18603A330")]
		[IteratorStateMachine(typeof(KJNPNIMIPIG))]
		public IEnumerable<NOLDFLLDJKB> AGMPJAIIGJH(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x603A3C0", Offset = "0x60393C0", VA = "0x18603A3C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x603A440", Offset = "0x6039440", VA = "0x18603A440")]
		private long KEFKNOPDKEL(NOLDFLLDJKB FJONJLMIBBO)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x603A400", Offset = "0x6039400", VA = "0x18603A400")]
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
	[Cpp2IlInjected.Address(RVA = "0x6034910", Offset = "0x6033910", VA = "0x186034910")]
	public CKKGLCGBDKO(int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60347C0", Offset = "0x60337C0", VA = "0x1860347C0")]
	public static CKKGLCGBDKO NBCGGNFJHGH(int CIMAPKKBLKM, NativeArray<int> JDJBDCDEPOJ)
	{
		return default(CKKGLCGBDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6034610", Offset = "0x6033610", VA = "0x186034610")]
	public bool DIAPBLEJNDD(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6034630", Offset = "0x6033630", VA = "0x186034630")]
	public void FAFPJPFNCCD(int NPDGHPHAKDK, bool DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6034640", Offset = "0x6033640", VA = "0x186034640")]
	public bool FFMFMKIFAJN(NOLDFLLDJKB[] JDJBDCDEPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6034700", Offset = "0x6033700", VA = "0x186034700")]
	public bool IFABFKANHOI(NOLDFLLDJKB[] JDJBDCDEPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6034620", Offset = "0x6033620", VA = "0x186034620", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x603A0D0", Offset = "0x60390D0", VA = "0x18603A0D0")]
	public OHBAEBNNMLF(NIMHHIKGLPG GLAPLAOCNKE, MFDIJJOFCMP KJBBHHLPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6039D40", Offset = "0x6038D40", VA = "0x186039D40")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6039060", Offset = "0x6038060", VA = "0x186039060")]
	public void AHOGMINLLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6039550", Offset = "0x6038550", VA = "0x186039550")]
	public NativeList<FDDKPOFDJHH> GMEGNGFMBEE(NativeArray<int> JDJBDCDEPOJ)
	{
		return default(NativeList<FDDKPOFDJHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6039C70", Offset = "0x6038C70", VA = "0x186039C70")]
	private bool KBKCNOJCNHJ(CHFPDADGPHF IINLNCOCPGF, CKKGLCGBDKO OGKDIHAFBIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2784B30", Offset = "0x2783B30", VA = "0x182784B30")]
	private void MNINBOIHCHA<TInterface, TAttribute>(Action<TInterface, TAttribute> IGGFHHEDAPI) where TInterface : CHFPDADGPHF where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6039520", Offset = "0x6038520", VA = "0x186039520")]
	private void DMHELOMPICK(Type IGEIBCJNCHF, Type FHMLLOKGAGH, Type BJCNJFOFJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2784AD0", Offset = "0x2783AD0", VA = "0x182784AD0")]
	private TInterface MCDKBGLJGOI<TInterface>(Type IGEIBCJNCHF)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6039E10", Offset = "0x6038E10", VA = "0x186039E10")]
	private void LMFDPEIFGEB(CHFPDADGPHF IINLNCOCPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x60391D0", Offset = "0x60381D0", VA = "0x1860391D0")]
	private int ALHEEBCFMKF(CHFPDADGPHF EBFDFNHDGGE, int BBCHOGHICAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6039270", Offset = "0x6038270", VA = "0x186039270")]
	private void BOFLDJEJDOB(NOMFBEGPHDP IINLNCOCPGF, CCANOLFJIOC CELBDMKCLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x60399B0", Offset = "0x60389B0", VA = "0x1860399B0")]
	private void IBLGDHPLCDI(APFDBDFHKEC IINLNCOCPGF, EFDNKCIGNEF CELBDMKCLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6039EE0", Offset = "0x6038EE0", VA = "0x186039EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC39000", Offset = "0xC38000", VA = "0x180C39000")]
		get
		{
			return default(NativeList<FDDKPOFDJHH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6038EE0", Offset = "0x6037EE0", VA = "0x186038EE0")]
	public NGHIEBNHJCK(MFDIJJOFCMP KJBBHHLPGKO, List<CHFPDADGPHF> JHFOBHFKGOM, NativeArray<FDDKPOFDJHH> CFGGCMMMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6038C10", Offset = "0x6037C10", VA = "0x186038C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6038810", Offset = "0x6037810", VA = "0x186038810")]
	private NativeList<FDDKPOFDJHH> DGJNKEDHOHI(NativeArray<FDDKPOFDJHH> KBDJDKOJFLE)
	{
		return default(NativeList<FDDKPOFDJHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6038C50", Offset = "0x6037C50", VA = "0x186038C50")]
	private bool KPBMAHINCLM(CHFPDADGPHF IINLNCOCPGF, CKKGLCGBDKO KIIHLDDBNOC, int LFPJPFNFLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6038D20", Offset = "0x6037D20", VA = "0x186038D20")]
	private void LGFEOMCIPKC(CHFPDADGPHF IINLNCOCPGF, CKKGLCGBDKO DPIKJLNDNHO, int LFPJPFNFLED)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct PDABGJAENPN : IComparer<FDDKPOFDJHH>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x603A2D0", Offset = "0x60392D0", VA = "0x18603A2D0", Slot = "4")]
	public int Compare(FDDKPOFDJHH NCNGLFNLPAG, FDDKPOFDJHH OPGAGDBKIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x603A2E0", Offset = "0x60392E0", VA = "0x18603A2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x603A810", Offset = "0x6039810", VA = "0x18603A810", Slot = "6")]
		public sealed override void EFMBJNCKONM(GEJJOANAKLE KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x603A910", Offset = "0x6039910", VA = "0x18603A910", Slot = "4")]
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
