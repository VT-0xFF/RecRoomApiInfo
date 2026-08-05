using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62A6A90", Offset = "0x62A5C90", VA = "0x1862A6A90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NPNNIODPLOE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected NPNNIODPLOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CNGFCJMFNGB<T> : NPNNIODPLOE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LMLIIHNDDOP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JGLANNDKCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public JGLANNDKCGJ FLPJMDMACMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T GKGLDBAJJCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int JBGNEBFGMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JIMJHIPADBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool DCOKHDEADDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? DNOBKGLJEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LMLIIHNDDOP>? KALGEOEHBDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LBKMAIECONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C3D420", Offset = "0x4C3C620", VA = "0x184C3D420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C3DCA0", Offset = "0x4C3CEA0", VA = "0x184C3DCA0")]
	protected CNGFCJMFNGB(bool DCOKHDEADDG, bool JIMJHIPADBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D470", Offset = "0x4C3C670", VA = "0x184C3D470")]
	protected bool BOGDGCFHMNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D6E0", Offset = "0x4C3C8E0", VA = "0x184C3D6E0")]
	protected void IKCHMBNNOHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D510", Offset = "0x4C3C710", VA = "0x184C3D510")]
	protected void CHMOBNNPLFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2576B80", Offset = "0x2575D80", VA = "0x182576B80")]
	private static void CKFHFEOIHEE<U>(List<U>? JLCIFHJMGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C3DAE0", Offset = "0x4C3CCE0", VA = "0x184C3DAE0", Slot = "4")]
	public void OEOPOJPHCNL(T GKGLDBAJJCH, bool EJPIBPILGBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D7D0", Offset = "0x4C3C9D0", VA = "0x184C3D7D0", Slot = "5")]
	public void MFEEKLGJAPH(T GKGLDBAJJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D970", Offset = "0x4C3CB70", VA = "0x184C3D970")]
	public void NDGKPACNNFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EMLPAPLNECP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEOPOJPHCNL(Action GKGLDBAJJCH, bool EJPIBPILGBG = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFEEKLGJAPH(Action GKGLDBAJJCH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AGKHEGBIBIG : CNGFCJMFNGB<Action>, EMLPAPLNECP
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62A4850", Offset = "0x62A3A50", VA = "0x1862A4850")]
	public AGKHEGBIBIG(bool DCOKHDEADDG = false, bool JIMJHIPADBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62A4590", Offset = "0x62A3790", VA = "0x1862A4590")]
	public void DPCEAIGMMMP()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62A47F0", Offset = "0x62A39F0", VA = "0x1862A47F0")]
	public static AGKHEGBIBIG MBJPJBDPKJP(AGKHEGBIBIG KJKDFDMIPKK, Action GKGLDBAJJCH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62A4790", Offset = "0x62A3990", VA = "0x1862A4790")]
	public static AGKHEGBIBIG HKGOFCKCKJJ(AGKHEGBIBIG KJKDFDMIPKK, Action GKGLDBAJJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OHPMIHCCIDK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEOPOJPHCNL(Action<T> GKGLDBAJJCH, bool EJPIBPILGBG = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFEEKLGJAPH(Action<T> GKGLDBAJJCH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class JMOHOLLMHII<T> : CNGFCJMFNGB<Action<T>>, OHPMIHCCIDK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3462990", Offset = "0x3461B90", VA = "0x183462990")]
	public JMOHOLLMHII(bool DCOKHDEADDG = false, bool JIMJHIPADBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C30A50", Offset = "0x3C2FC50", VA = "0x183C30A50")]
	public void DPCEAIGMMMP(T MOAGOANMCEN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3462900", Offset = "0x3461B00", VA = "0x183462900")]
	public static JMOHOLLMHII<T> MBJPJBDPKJP(JMOHOLLMHII<T> KJKDFDMIPKK, Action<T> GKGLDBAJJCH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3462870", Offset = "0x3461A70", VA = "0x183462870")]
	public static JMOHOLLMHII<T> HKGOFCKCKJJ(JMOHOLLMHII<T> KJKDFDMIPKK, Action<T> GKGLDBAJJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HPPDOBJLMLC<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EDFKKMBKCDD<T, U> : CNGFCJMFNGB<Action<T, U>>, HPPDOBJLMLC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3462990", Offset = "0x3461B90", VA = "0x183462990")]
	public EDFKKMBKCDD(bool DCOKHDEADDG = false, bool JIMJHIPADBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3460B30", Offset = "0x345FD30", VA = "0x183460B30")]
	public void DPCEAIGMMMP(T MOAGOANMCEN, U KDFJHNDMMPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3462900", Offset = "0x3461B00", VA = "0x183462900")]
	public static EDFKKMBKCDD<T, U> MBJPJBDPKJP(EDFKKMBKCDD<T, U> KJKDFDMIPKK, Action<T, U> GKGLDBAJJCH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3462870", Offset = "0x3461A70", VA = "0x183462870")]
	public static EDFKKMBKCDD<T, U> HKGOFCKCKJJ(EDFKKMBKCDD<T, U> KJKDFDMIPKK, Action<T, U> GKGLDBAJJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class EJMHBCOCIKO<T, U, V> : CNGFCJMFNGB<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3462990", Offset = "0x3461B90", VA = "0x183462990")]
	public EJMHBCOCIKO(bool DCOKHDEADDG = false, bool JIMJHIPADBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x34857E0", Offset = "0x34849E0", VA = "0x1834857E0")]
	public void DPCEAIGMMMP(T MOAGOANMCEN, U KDFJHNDMMPK, V IFBNMJJOJMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3462900", Offset = "0x3461B00", VA = "0x183462900")]
	public static EJMHBCOCIKO<T, U, V> MBJPJBDPKJP(EJMHBCOCIKO<T, U, V> KJKDFDMIPKK, Action<T, U, V> GKGLDBAJJCH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3462870", Offset = "0x3461A70", VA = "0x183462870")]
	public static EJMHBCOCIKO<T, U, V> HKGOFCKCKJJ(EJMHBCOCIKO<T, U, V> KJKDFDMIPKK, Action<T, U, V> GKGLDBAJJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FBDBPDFBONC<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FBLMGHCKFFA<T, U, V, W> : CNGFCJMFNGB<Action<T, U, V, W>>, FBDBPDFBONC<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3462990", Offset = "0x3461B90", VA = "0x183462990")]
	public FBLMGHCKFFA(bool DCOKHDEADDG = false, bool JIMJHIPADBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37D8720", Offset = "0x37D7920", VA = "0x1837D8720")]
	public void DPCEAIGMMMP(T MOAGOANMCEN, U KDFJHNDMMPK, V IFBNMJJOJMJ, W KLBKDHONFBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3462900", Offset = "0x3461B00", VA = "0x183462900")]
	public static FBLMGHCKFFA<T, U, V, W> MBJPJBDPKJP(FBLMGHCKFFA<T, U, V, W> KJKDFDMIPKK, Action<T, U, V, W> GKGLDBAJJCH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3462870", Offset = "0x3461A70", VA = "0x183462870")]
	public static FBLMGHCKFFA<T, U, V, W> HKGOFCKCKJJ(FBLMGHCKFFA<T, U, V, W> KJKDFDMIPKK, Action<T, U, V, W> GKGLDBAJJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NHHPGEJMIIN<T, U, V, W, X> : CNGFCJMFNGB<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3462990", Offset = "0x3461B90", VA = "0x183462990")]
	public NHHPGEJMIIN(bool DCOKHDEADDG = false, bool JIMJHIPADBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x406C4B0", Offset = "0x406B6B0", VA = "0x18406C4B0")]
	public void DPCEAIGMMMP(T MOAGOANMCEN, U KDFJHNDMMPK, V IFBNMJJOJMJ, W KLBKDHONFBL, X KPEEHKEJDAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3462900", Offset = "0x3461B00", VA = "0x183462900")]
	public static NHHPGEJMIIN<T, U, V, W, X> MBJPJBDPKJP(NHHPGEJMIIN<T, U, V, W, X> KJKDFDMIPKK, Action<T, U, V, W, X> GKGLDBAJJCH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3462870", Offset = "0x3461A70", VA = "0x183462870")]
	public static NHHPGEJMIIN<T, U, V, W, X> HKGOFCKCKJJ(NHHPGEJMIIN<T, U, V, W, X> KJKDFDMIPKK, Action<T, U, V, W, X> GKGLDBAJJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class OHGPMKDKGCK<T, U, V, W, X, Y> : CNGFCJMFNGB<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3462990", Offset = "0x3461B90", VA = "0x183462990")]
	public OHGPMKDKGCK(bool DCOKHDEADDG = false, bool JIMJHIPADBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4185CB0", Offset = "0x4184EB0", VA = "0x184185CB0")]
	public void DPCEAIGMMMP(T MOAGOANMCEN, U KDFJHNDMMPK, V IFBNMJJOJMJ, W KLBKDHONFBL, X KPEEHKEJDAP, Y OEKGMAOIIKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3462900", Offset = "0x3461B00", VA = "0x183462900")]
	public static OHGPMKDKGCK<T, U, V, W, X, Y> MBJPJBDPKJP(OHGPMKDKGCK<T, U, V, W, X, Y> KJKDFDMIPKK, Action<T, U, V, W, X, Y> GKGLDBAJJCH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3462870", Offset = "0x3461A70", VA = "0x183462870")]
	public static OHGPMKDKGCK<T, U, V, W, X, Y> HKGOFCKCKJJ(OHGPMKDKGCK<T, U, V, W, X, Y> KJKDFDMIPKK, Action<T, U, V, W, X, Y> GKGLDBAJJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FOGEIFBHHNE<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AHINDIHIDML<TKey, TVal> KAMJBMDKBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> LMFAIPKCJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly AHINDIHIDML<TKey, TVal>.EMBACNDGINP? LMKIBFMAGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int AIGBGKMAPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AHINDIHIDML<TKey, TVal>.LCMALILAHFL? FOAEBBNNEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int PEDJANAEKDO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int DKFOGPDKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3818380", Offset = "0x3817580", VA = "0x183818380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FGPMDJIDHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B9980", Offset = "0x7B8B80", VA = "0x1807B9980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38192F0", Offset = "0x38184F0", VA = "0x1838192F0")]
	public FOGEIFBHHNE(int AIGBGKMAPIJ, [Optional] AHINDIHIDML<TKey, TVal>.LCMALILAHFL? FOAEBBNNEOB, [Optional] IEqualityComparer<TKey>? HBCDMEFGJPN, [Optional] AHINDIHIDML<TKey, TVal>.EMBACNDGINP? LMKIBFMAGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3818E60", Offset = "0x3818060", VA = "0x183818E60")]
	public void MIDBKIBNICI(TKey GOBGGNLGONA, TVal NICEPFIEJED, bool HEKIPHGAKHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3818760", Offset = "0x3817960", VA = "0x183818760")]
	public bool ELMMEDLHAJK(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3819220", Offset = "0x3818420", VA = "0x183819220")]
	public bool PEFGNEHBCPG(TKey FHICNGPLFBN, [Out] TVal NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x38183C0", Offset = "0x38175C0", VA = "0x1838183C0")]
	private void CLPKKCABAHP(TKey GOBGGNLGONA, TVal NICEPFIEJED, int MKJBDDDPMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38185F0", Offset = "0x38177F0", VA = "0x1838185F0")]
	public bool CMJLGLJLNAA(TKey GOBGGNLGONA, TVal NICEPFIEJED, bool HEKIPHGAKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38190F0", Offset = "0x38182F0", VA = "0x1838190F0")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3818880", Offset = "0x3817A80", VA = "0x183818880")]
	private void FBIDFKHBEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3819010", Offset = "0x3818210", VA = "0x183819010")]
	private bool NBHPCOHHKCP(TKey GOBGGNLGONA, JLIPFEDMPKC LGGFDGCPFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3819150", Offset = "0x3818350", VA = "0x183819150")]
	private void OGAMKCLDOHI(TKey GOBGGNLGONA, TVal NICEPFIEJED, JLIPFEDMPKC LGGFDGCPFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3818D40", Offset = "0x3817F40", VA = "0x183818D40")]
	private void FDEFNJADMCB(TKey GOBGGNLGONA, TVal LJPPKNAEGOB, JLIPFEDMPKC LGGFDGCPFCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MFAKAOGOEKO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action HKIHEOMADKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool AOIEIGDGOJH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public MFAKAOGOEKO(Action DNMIKPGIBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62A6550", Offset = "0x62A5750", VA = "0x1862A6550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26A5E30", Offset = "0x26A5030", VA = "0x1826A5E30")]
	public static IFNEFIDKPAH<T> LAFNMEJJDLL<T>(T NICEPFIEJED, Action DNMIKPGIBGA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class IFNEFIDKPAH<T> : MFAKAOGOEKO where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F6B0", Offset = "0x3A3E8B0", VA = "0x183A3F6B0")]
	public IFNEFIDKPAH(T NICEPFIEJED, Action DNMIKPGIBGA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HNAEADEHOKP : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct HLAHBHCFJNK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
		public static HLAHBHCFJNK MIJABIECKKD()
		{
			return default(HLAHBHCFJNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x290C1C0", Offset = "0x290B3C0", VA = "0x18290C1C0")]
	public static string? JHKPHBEGDKH<T>([Optional] string? CFKHFKKPIEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x290C140", Offset = "0x290B340", VA = "0x18290C140")]
	public static string? ANOLHDFCMOI<T>([Optional] string? PNFIENGBGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
	public static HNAEADEHOKP GOFIODGEAFC(string CFKHFKKPIEG, string? PNFIENGBGCP)
	{
		return default(HNAEADEHOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GNJHHMGGNHB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool AIENLHAHPAO(string AJCDLICAMFM, GNJHHMGGNHB BGEPJKHMEGN);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FOJAOFJIHOI<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public FOJAOFJIHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3819570", Offset = "0x3818770", VA = "0x183819570")]
		internal void MAOLGHPIGCO(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int LILHNKAIGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string CIKOOOEBBLI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62A58A0", Offset = "0x62A4AA0", VA = "0x1862A58A0")]
	public static Dictionary<string, GNJHHMGGNHB> BCPKOFEJHEJ(Type EDPFIOENFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28F2310", Offset = "0x28F1510", VA = "0x1828F2310")]
	public static Dictionary<string, GNJHHMGGNHB> BCPKOFEJHEJ<T>(Type EDPFIOENFLM, IReadOnlyDictionary<T, string> EMKGFEPGKJA) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28F1C50", Offset = "0x28F0E50", VA = "0x1828F1C50")]
	public static Dictionary<string, GNJHHMGGNHB> ANFPKKEMEHH<T>(List<T> OPNOBLCJKKO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62A5BD0", Offset = "0x62A4DD0", VA = "0x1862A5BD0")]
	public static Dictionary<string, GNJHHMGGNHB> MAGBKGFJJDE(Type EDPFIOENFLM, AIENLHAHPAO BHPICHOJMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x62A56E0", Offset = "0x62A48E0", VA = "0x1862A56E0")]
	public static Dictionary<int, string> ACMHLGKLGNC(Dictionary<string, GNJHHMGGNHB> GBHPBJPAFFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class OMPNGPMCKPG : LNFCDOMCNGI
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static bool HCOLHEKIIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly string? POGFAKDOADI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual LNFCDOMCNGI? NDOGIFBHADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x62A7260", Offset = "0x62A6460", VA = "0x1862A7260")]
	protected OMPNGPMCKPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string FIHEJJCABJP();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x62A6F30", Offset = "0x62A6130", VA = "0x1862A6F30", Slot = "8")]
	public virtual string KNBHFAOEHDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62A6FB0", Offset = "0x62A61B0", VA = "0x1862A6FB0", Slot = "9")]
	public void PMMBDNJOJFG(StringBuilder JPLKLKEAPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x62A6E30", Offset = "0x62A6030", VA = "0x1862A6E30", Slot = "10")]
	public void JNGHFKDDGHL(StringBuilder JPLKLKEAPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x62A6D10", Offset = "0x62A5F10", VA = "0x1862A6D10", Slot = "11")]
	public void ICKAMFMBIPN(StringBuilder JPLKLKEAPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x62A6BB0", Offset = "0x62A5DB0", VA = "0x1862A6BB0", Slot = "12")]
	public void BGLDHBCILFO(StringBuilder JPLKLKEAPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62A6E90", Offset = "0x62A6090", VA = "0x1862A6E90")]
	public static void KGFCFONFOGF(StringBuilder JPLKLKEAPIE, string OAOCJOMDPMM, string EJFGBABIFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x54F0F90", Offset = "0x54F0190", VA = "0x1854F0F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CLHIDNFFNLF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x62A4990", Offset = "0x62A3B90", VA = "0x1862A4990")]
	public CLHIDNFFNLF(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IOAHEEBMLFB<TErr> : CLHIDNFFNLF where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TErr JOPHLNBHHMC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FC80", Offset = "0x3A5EE80", VA = "0x183A5FC80")]
	private IOAHEEBMLFB([In] TErr KMJOCGPPBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FBC0", Offset = "0x3A5EDC0", VA = "0x183A5FBC0")]
	public static IOAHEEBMLFB<TErr> MIJABIECKKD([In] TErr KMJOCGPPBJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LNFCDOMCNGI
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KNBHFAOEHDK();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string FIHEJJCABJP();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EFFHOFOCFKC<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OIABANALBHL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string JDAIECLPCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NLFMCMCCCCJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x62A6A30", Offset = "0x62A5C30", VA = "0x1862A6A30")]
	public NLFMCMCCCCJ(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DAOEGFCHPOF<TOk> : NLFMCMCCCCJ where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly TOk EJGHPAHLMJK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x50FC900", Offset = "0x50FBB00", VA = "0x1850FC900")]
	private DAOEGFCHPOF([In] TOk NLLMPMEKHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x388C110", Offset = "0x388B310", VA = "0x18388C110")]
	public static DAOEGFCHPOF<TOk> MIJABIECKKD([In] TOk NLLMPMEKHFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct NFMFLMAOFMP<TOk, TErr> : IEquatable<NFMFLMAOFMP<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly EqualityComparer<TErr> DJPAOHKBPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TErr JOPHLNBHHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly TOk EJGHPAHLMJK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JHMKCCLHIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x40211A0", Offset = "0x40203A0", VA = "0x1840211A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ICLOHMPBMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4021F30", Offset = "0x4021130", VA = "0x184021F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4022A10", Offset = "0x4021C10", VA = "0x184022A10")]
	internal NFMFLMAOFMP([In] TErr KMJOCGPPBJB, [In] TOk NLLMPMEKHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4021E70", Offset = "0x4021070", VA = "0x184021E70")]
	public static NFMFLMAOFMP<TOk, TErr> JBELNACAMBG([In] TErr KMJOCGPPBJB)
	{
		return default(NFMFLMAOFMP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4021FC0", Offset = "0x40211C0", VA = "0x184021FC0")]
	public static NFMFLMAOFMP<TOk, TErr> PCKEIAMKFGK([In] TOk NLLMPMEKHFM)
	{
		return default(NFMFLMAOFMP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x267DFD0", Offset = "0x267D1D0", VA = "0x18267DFD0")]
	public NFMFLMAOFMP<TOk?, UErr?> LJJPOLOPKLO<UErr>()
	{
		return default(NFMFLMAOFMP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x267CC00", Offset = "0x267BE00", VA = "0x18267CC00")]
	public NFMFLMAOFMP<UOk?, TErr?> ALCCDMIMFKO<UOk>()
	{
		return default(NFMFLMAOFMP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x267D7F0", Offset = "0x267C9F0", VA = "0x18267D7F0")]
	public NFMFLMAOFMP<UOk?, TErr?> KLKKBFFKLEC<UOk>()
	{
		return default(NFMFLMAOFMP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x267E4A0", Offset = "0x267D6A0", VA = "0x18267E4A0")]
	public NFMFLMAOFMP<TOk?, UErr?> LKFNJHCKPEA<UErr>()
	{
		return default(NFMFLMAOFMP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4021CA0", Offset = "0x4020EA0", VA = "0x184021CA0")]
	public NFMFLMAOFMP<LKEAICJEMFK, TErr> IOHPNIKINIP()
	{
		return default(NFMFLMAOFMP<LKEAICJEMFK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4020F80", Offset = "0x4020180", VA = "0x184020F80")]
	public static bool AIPCENMEJFE([In] NFMFLMAOFMP<TOk, TErr> EBKLEGBLPGD, [In] NFMFLMAOFMP<TOk, TErr> JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x40216E0", Offset = "0x40208E0", VA = "0x1840216E0", Slot = "4")]
	public bool Equals(NFMFLMAOFMP<TOk, TErr> NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4021570", Offset = "0x4020770", VA = "0x184021570", Slot = "0")]
	public override bool Equals(object NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4021920", Offset = "0x4020B20", VA = "0x184021920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4022590", Offset = "0x4021790", VA = "0x184022590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DHIKHIMHJLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct DENKBMIPMDH<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Task<NFMFLMAOFMP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<NFMFLMAOFMP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5112510", Offset = "0x5111710", VA = "0x185112510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5112B10", Offset = "0x5111D10", VA = "0x185112B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2753FE0", Offset = "0x27531E0", VA = "0x182753FE0")]
	public static NFMFLMAOFMP<TOk?, TErr?> EJGHPAHLMJK<TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [In] TOk NLLMPMEKHFM)
	{
		return default(NFMFLMAOFMP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2754070", Offset = "0x2753270", VA = "0x182754070")]
	public static NFMFLMAOFMP<LKEAICJEMFK, TErr?> EJGHPAHLMJK<TErr>([In] this NFMFLMAOFMP<LKEAICJEMFK, TErr> KNKOEEEKHDK)
	{
		return default(NFMFLMAOFMP<LKEAICJEMFK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2753FE0", Offset = "0x27531E0", VA = "0x182753FE0")]
	public static NFMFLMAOFMP<TOk?, TErr?> JOPHLNBHHMC<TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [In] TErr KMJOCGPPBJB)
	{
		return default(NFMFLMAOFMP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27550C0", Offset = "0x27542C0", VA = "0x1827550C0")]
	public static TOk? HBNGJPHNCKN<TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27566E0", Offset = "0x27558E0", VA = "0x1827566E0")]
	[AsyncStateMachine(typeof(DENKBMIPMDH<, >))]
	public static Task<TOk?>? OBKMHHEGPBE<TOk, TErr>(this Task<NFMFLMAOFMP<TOk, TErr>> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2754C90", Offset = "0x2753E90", VA = "0x182754C90")]
	public static TErr? FOFPNOMGMCK<TErr, TOk>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2755590", Offset = "0x2754790", VA = "0x182755590")]
	public static bool LGIAKKNDGFD<TOk, TErr, UErr, UOk>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [Out] NFMFLMAOFMP<UOk, UErr> HMCOFIIMHLC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2754170", Offset = "0x2753370", VA = "0x182754170")]
	public static bool FDFKFHPENEO<TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [Out][NotNullWhen(true)] TOk NLLMPMEKHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2755450", Offset = "0x2754650", VA = "0x182755450")]
	public static bool LCHPMCBJIBI<TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [Out][NotNullWhen(true)] TErr KMJOCGPPBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2753A80", Offset = "0x2752C80", VA = "0x182753A80")]
	public static bool ACHGIMMKMFP<TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [Out][NotNullWhen(true)] TOk NLLMPMEKHFM, [Out][NotNullWhen(false)] TErr KMJOCGPPBJB) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27565E0", Offset = "0x27557E0", VA = "0x1827565E0")]
	public static bool MGKMEHHNIOE<TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [Out][NotNullWhen(true)] TOk NLLMPMEKHFM, [Out] NFMFLMAOFMP<TOk, TErr> HMCOFIIMHLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x27557C0", Offset = "0x27549C0", VA = "0x1827557C0")]
	public static bool LGIAKKNDGFD<TOk, TErr, UErr, UOk>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [Out][NotNullWhen(true)] TOk NLLMPMEKHFM, [Out] NFMFLMAOFMP<UOk, UErr> HMCOFIIMHLC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2753C40", Offset = "0x2752E40", VA = "0x182753C40")]
	public static bool AFBKLPLCJBI<TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [Out][NotNullWhen(true)] TOk NLLMPMEKHFM, [Out] NFMFLMAOFMP<LKEAICJEMFK, TErr> HMCOFIIMHLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2754760", Offset = "0x2753960", VA = "0x182754760")]
	public static NFMFLMAOFMP<UOk, UErr> FHDLPNHGAPC<UOk, UErr, TOk, TErr>([In] this NFMFLMAOFMP<TOk, TErr> KNKOEEEKHDK, [In] NFMFLMAOFMP<UOk, UErr> PMBMOONGPPJ) where TOk : UOk where TErr : UErr
	{
		return default(NFMFLMAOFMP<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27541E0", Offset = "0x27533E0", VA = "0x1827541E0")]
	public static NFMFLMAOFMP<TOk?[]?, TErr?> FGFLJHOJDJF<TOk, TErr>(this IEnumerable<NFMFLMAOFMP<TOk, TErr>> KNKOEEEKHDK)
	{
		return default(NFMFLMAOFMP<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IDCODAIPOIN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x257FEA0", Offset = "0x257F0A0", VA = "0x18257FEA0")]
	public static NFMFLMAOFMP<TOk, T> EJGHPAHLMJK<TOk>([In] TOk NLLMPMEKHFM) where TOk : notnull
	{
		return default(NFMFLMAOFMP<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3A3A990", Offset = "0x3A39B90", VA = "0x183A3A990")]
	public static NFMFLMAOFMP<LKEAICJEMFK, T> EJGHPAHLMJK()
	{
		return default(NFMFLMAOFMP<LKEAICJEMFK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x257FF20", Offset = "0x257F120", VA = "0x18257FF20")]
	public static NFMFLMAOFMP<T, TErr> JOPHLNBHHMC<TErr>([In] TErr KMJOCGPPBJB) where TErr : notnull
	{
		return default(NFMFLMAOFMP<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public sealed class MAPHDHMBCMB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct FOFCPPHMHGM : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly MAPHDHMBCMB<T> PIPHLMIAIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly int IOEIDMNEGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly bool JAGPCIDGMII;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A100", Offset = "0x1D49300", VA = "0x181D4A100")]
		public FOFCPPHMHGM(MAPHDHMBCMB<T> PFGBPGKFOLN, int OCOHOJBMAEA, bool KNGMEDDAJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3818260", Offset = "0x3817460", VA = "0x183818260")]
		public MAPHDHMBCMB<T>.AGAHIIBBLIC ODDJKKOCOEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3818340", Offset = "0x3817540", VA = "0x183818340", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3818340", Offset = "0x3817540", VA = "0x183818340", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class AGAHIIBBLIC : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly MAPHDHMBCMB<T> PIPHLMIAIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly int NJCDIAIEPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int FCMMIHDKLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly bool JAGPCIDGMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool AGANPABHBOH;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x388E8F0", Offset = "0x388DAF0", VA = "0x18388E8F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x388EA10", Offset = "0x388DC10", VA = "0x18388EA10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x388EB90", Offset = "0x388DD90", VA = "0x18388EB90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x388EC20", Offset = "0x388DE20", VA = "0x18388EC20")]
		public AGAHIIBBLIC(MAPHDHMBCMB<T> PFGBPGKFOLN, int OCOHOJBMAEA, bool KNGMEDDAJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x388E970", Offset = "0x388DB70", VA = "0x18388E970", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x388E9F0", Offset = "0x388DBF0", VA = "0x18388E9F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IKBPGLEMKEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IKBPGLEMKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A561E0", Offset = "0x3A553E0", VA = "0x183A561E0")]
		internal T FNOIMPLHEIM(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly T[] MPLIGBJLMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int FCMMIHDKLPI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IAAHNFFMLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3F43F40", Offset = "0x3F43140", VA = "0x183F43F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T DCJELCPGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x37CE8A0", Offset = "0x37CDAA0", VA = "0x1837CE8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T GNHHBJIJMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F44240", Offset = "0x3F43440", VA = "0x183F44240")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3F43FD0", Offset = "0x3F431D0", VA = "0x183F43FD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FPAACNPAGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1749B80", Offset = "0x1748D80", VA = "0x181749B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xFFFFB0", Offset = "0xFFF1B0", VA = "0x180FFFFB0")]
	private static int PDCECLDILLH(int HMFNCGHECPG, int HHOELNLHIEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3F44310", Offset = "0x3F43510", VA = "0x183F44310")]
	public MAPHDHMBCMB(int MKJBDDDPMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3F444C0", Offset = "0x3F436C0", VA = "0x183F444C0")]
	public MAPHDHMBCMB(int MKJBDDDPMKM, Func<T> PFPMKBEAEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3F44620", Offset = "0x3F43820", VA = "0x183F44620")]
	public MAPHDHMBCMB(T[] NOIICBHICIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3F440D0", Offset = "0x3F432D0", VA = "0x183F440D0")]
	public void GJACNAMCCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3F44100", Offset = "0x3F43300", VA = "0x183F44100")]
	public IEnumerable<T> KOBODBGKPNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F441C0", Offset = "0x3F433C0", VA = "0x183F441C0")]
	public MAPHDHMBCMB<T>.AGAHIIBBLIC ODDJKKOCOEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3862AC0", Offset = "0x3861CC0", VA = "0x183862AC0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3862AC0", Offset = "0x3861CC0", VA = "0x183862AC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PHGKIPNIKBA
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BAB0", Offset = "0x2A6ACB0", VA = "0x182A6BAB0")]
	public static MAPHDHMBCMB<T> MIJABIECKKD<T>(int MKJBDDDPMKM, Func<T> PFPMKBEAEAN) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E39080", Offset = "0x1E38280", VA = "0x181E39080")]
		public RRColor(float JPCMMEHHHNC, float DDPFKOKDDGB, float HGMCBKHHGFH, float JPEEHDCLFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62A7520", Offset = "0x62A6720", VA = "0x1862A7520", Slot = "4")]
		public bool Equals(RRColor NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62A75A0", Offset = "0x62A67A0", VA = "0x1862A75A0", Slot = "0")]
		public override bool Equals(object NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62A76A0", Offset = "0x62A68A0", VA = "0x1862A76A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x62A7720", Offset = "0x62A6920", VA = "0x1862A7720", Slot = "5")]
		public string ToString(string IHFDBLMLKMD, IFormatProvider BOPPNKJEBFP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class EFNFKHCGHAK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct EBLHKIEIEIO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly EFNFKHCGHAK<T> NPIDKAMDOKI;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T FJJHODHBEGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x345E470", Offset = "0x345D670", VA = "0x18345E470")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x345E440", Offset = "0x345D640", VA = "0x18345E440", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
		public EBLHKIEIEIO(EFNFKHCGHAK<T> NPIDKAMDOKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct HMGMMPDIAJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<EBLHKIEIEIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public EFNFKHCGHAK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x39853D0", Offset = "0x39845D0", VA = "0x1839853D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3277CF0", Offset = "0x3276EF0", VA = "0x183277CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly SemaphoreSlim JCMJCLMDPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private T HKFDJMCEGFF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3476270", Offset = "0x3475470", VA = "0x183476270")]
	public EFNFKHCGHAK([In] T HKFDJMCEGFF, int FGAFNEBCIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x34761B0", Offset = "0x34753B0", VA = "0x1834761B0")]
	public EFNFKHCGHAK([In] T HKFDJMCEGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3475D10", Offset = "0x3474F10", VA = "0x183475D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3475CD0", Offset = "0x3474ED0", VA = "0x183475CD0")]
	public EBLHKIEIEIO BGGLNGNMFOG()
	{
		return default(EBLHKIEIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3475D70", Offset = "0x3474F70", VA = "0x183475D70")]
	[AsyncStateMachine(typeof(EFNFKHCGHAK<>.HMGMMPDIAJD))]
	public Task<EFNFKHCGHAK<T>.EBLHKIEIEIO> KICEEGHKGLP(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3475D50", Offset = "0x3474F50", VA = "0x183475D50")]
	public void JJHLIHMMEGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DAEEIPAHNEN
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62A49F0", Offset = "0x62A3BF0", VA = "0x1862A49F0")]
	public static EFNFKHCGHAK<LKEAICJEMFK> MIJABIECKKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x271FBA0", Offset = "0x271EDA0", VA = "0x18271FBA0")]
	public static EFNFKHCGHAK<T> MIJABIECKKD<T>([In] T HKFDJMCEGFF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KJLENPKDHCM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct IJKIKDABPKK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly KJLENPKDHCM<T> IGMCDEKHDEK;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T FJJHODHBEGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3A56120", Offset = "0x3A55320", VA = "0x183A56120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A56000", Offset = "0x3A55200", VA = "0x183A56000", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
		internal IJKIKDABPKK(KJLENPKDHCM<T> NPIDKAMDOKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct BEMLPABGICO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly KJLENPKDHCM<T> IGMCDEKHDEK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T FJJHODHBEGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x3A56120", Offset = "0x3A55320", VA = "0x183A56120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4894B20", Offset = "0x4893D20", VA = "0x184894B20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
		internal BEMLPABGICO(KJLENPKDHCM<T> NPIDKAMDOKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GMHCALOOAHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<BEMLPABGICO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public KJLENPKDHCM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EFNFKHCGHAK<LKEAICJEMFK>.EBLHKIEIEIO <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<EFNFKHCGHAK<LKEAICJEMFK>.EBLHKIEIEIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x38C7520", Offset = "0x38C6720", VA = "0x1838C7520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3277CF0", Offset = "0x3276EF0", VA = "0x183277CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly EFNFKHCGHAK<int> KOLNPECJBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly EFNFKHCGHAK<LKEAICJEMFK> KGKFAFKPIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly EFNFKHCGHAK<LKEAICJEMFK> DBLNJOPKNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T JGKNMBEMGBC;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C993F0", Offset = "0x3C985F0", VA = "0x183C993F0")]
	internal KJLENPKDHCM(EFNFKHCGHAK<int> EBDGNIKNKAM, EFNFKHCGHAK<LKEAICJEMFK> PKIPAPGGEMK, EFNFKHCGHAK<LKEAICJEMFK> KAOJAJKMHDF, [In] T HKFDJMCEGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3C98CC0", Offset = "0x3C97EC0", VA = "0x183C98CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3C98700", Offset = "0x3C97900", VA = "0x183C98700")]
	public IJKIKDABPKK AGJBOGGPKJE()
	{
		return default(IJKIKDABPKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3C99210", Offset = "0x3C98410", VA = "0x183C99210")]
	public BEMLPABGICO PDEJFMIBDBD()
	{
		return default(BEMLPABGICO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3C99000", Offset = "0x3C98200", VA = "0x183C99000")]
	[AsyncStateMachine(typeof(KJLENPKDHCM<>.GMHCALOOAHC))]
	public Task<KJLENPKDHCM<T>.BEMLPABGICO> JDAOKFOKOMJ(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OPKDAGECIHG
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x62A72D0", Offset = "0x62A64D0", VA = "0x1862A72D0")]
	public static KJLENPKDHCM<LKEAICJEMFK> MIJABIECKKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A50650", Offset = "0x2A4F850", VA = "0x182A50650")]
	public static KJLENPKDHCM<T> MIJABIECKKD<T>([In] T HKFDJMCEGFF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class EHHOGJABEJI<TData> : OMPNGPMCKPG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly string EBIHFAEPEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly TData HCKHOAGNJJN;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
	public override string FIHEJJCABJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3479710", Offset = "0x3478910", VA = "0x183479710")]
	internal EHHOGJABEJI(string JGNAJPMGGNE, [In] TData FODGEDCJIDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class FBDHGALOHCE
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x62A4D40", Offset = "0x62A3F40", VA = "0x1862A4D40")]
	public static EHHOGJABEJI<LKEAICJEMFK> MIJABIECKKD(string JGNAJPMGGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x26A5E30", Offset = "0x26A5030", VA = "0x1826A5E30")]
	public static EHHOGJABEJI<TData> MIJABIECKKD<TData>(string JGNAJPMGGNE, [In] TData FODGEDCJIDC) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HELCDNENFLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly Dictionary<object, float> FOGKLDABGBI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float MIMIEGNFKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x94A870", Offset = "0x949A70", VA = "0x18094A870")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x94A910", Offset = "0x949B10", VA = "0x18094A910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62A5F90", Offset = "0x62A5190", VA = "0x1862A5F90")]
	public void CBHGKBMPIGJ(float NICEPFIEJED, object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x62A6130", Offset = "0x62A5330", VA = "0x1862A6130")]
	public void MANDAODFEFB(object FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x62A61A0", Offset = "0x62A53A0", VA = "0x1862A61A0")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62A6000", Offset = "0x62A5200", VA = "0x1862A6000")]
	private void KLOEAJHAJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x62A61F0", Offset = "0x62A53F0", VA = "0x1862A61F0")]
	public HELCDNENFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class LEJLAPEDIDG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class FGGHMGLJAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public FGGHMGLJAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x37FCC10", Offset = "0x37FBE10", VA = "0x1837FCC10")]
		internal int EBEEHCNNNPJ(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private HashSet<T>? APNIJCOAHDF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> IMLAOKIHIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D26340", Offset = "0x3D25540", VA = "0x183D26340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EBHMAIEOIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D262D0", Offset = "0x3D254D0", VA = "0x183D262D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2820", Offset = "0x7C1A20", VA = "0x1807C2820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3D26480", Offset = "0x3D25680", VA = "0x183D26480")]
	public bool OEOPOJPHCNL(T FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3D26370", Offset = "0x3D25570", VA = "0x183D26370")]
	public bool MFEEKLGJAPH(T FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3D26300", Offset = "0x3D25500", VA = "0x183D26300")]
	public bool GIIBKAKCCGO(T FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3D265D0", Offset = "0x3D257D0", VA = "0x183D265D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LEJLAPEDIDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PMCKCPFJJBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly string JKLDLKDJPOI;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public PMCKCPFJJBP(string JKLDLKDJPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62A74D0", Offset = "0x62A66D0", VA = "0x1862A74D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class NFAPFDEEOME
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class ENBJJDGECBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public ENBJJDGECBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x62A4A60", Offset = "0x62A3C60", VA = "0x1862A4A60")]
		internal int EBEEHCNNNPJ(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<object>? APNIJCOAHDF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> IMLAOKIHIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x62A6600", Offset = "0x62A5800", VA = "0x1862A6600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EBHMAIEOIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x62A6590", Offset = "0x62A5790", VA = "0x1862A6590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C2820", Offset = "0x7C1A20", VA = "0x1807C2820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x62A67A0", Offset = "0x62A59A0", VA = "0x1862A67A0")]
	public bool OEOPOJPHCNL(object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x62A6700", Offset = "0x62A5900", VA = "0x1862A6700")]
	public bool MFEEKLGJAPH(object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x62A65A0", Offset = "0x62A57A0", VA = "0x1862A65A0")]
	public bool GIIBKAKCCGO(object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x62A6690", Offset = "0x62A5890", VA = "0x1862A6690")]
	public void ICCOGLGKANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x62A6880", Offset = "0x62A5A80", VA = "0x1862A6880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NFAPFDEEOME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class EFFKGKGGADI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct FMKPLDJALCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float LKDHPLDPOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public T FJJHODHBEGH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, FMKPLDJALCN> FOGKLDABGBI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T DDMBKGKBMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xF26220", Offset = "0xF25420", VA = "0x180F26220", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xF24C30", Offset = "0xF23E30", VA = "0x180F24C30", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? NEHLDOAEHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NNMCPIBGCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3475380", Offset = "0x3474580", VA = "0x183475380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3473A70", Offset = "0x3472C70", VA = "0x183473A70")]
	public bool CBHGKBMPIGJ(T NICEPFIEJED, object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x34753C0", Offset = "0x34745C0", VA = "0x1834753C0")]
	public bool MANDAODFEFB(object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3475420", Offset = "0x3474620", VA = "0x183475420")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3475450", Offset = "0x3474650", VA = "0x183475450")]
	public bool PEFGNEHBCPG(object FCKLPDKGPKE, [Out] T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x34744B0", Offset = "0x34736B0", VA = "0x1834744B0")]
	[CGEGMLFOCCL("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool DDKBMLHNBGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x34757A0", Offset = "0x34749A0", VA = "0x1834757A0")]
	public EFFKGKGGADI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class KOKNAAJOPHN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<WeakReference<T>>? APNIJCOAHDF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EBHMAIEOIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9370", Offset = "0x3CB8570", VA = "0x183CB9370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9480", Offset = "0x3CB8680", VA = "0x183CB9480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9700", Offset = "0x3CB8900", VA = "0x183CB9700")]
	public void OEOPOJPHCNL(T FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3CB95C0", Offset = "0x3CB87C0", VA = "0x183CB95C0")]
	public void MFEEKLGJAPH(T FCKLPDKGPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9460", Offset = "0x3CB8660", VA = "0x183CB9460")]
	public void ICCOGLGKANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9900", Offset = "0x3CB8B00", VA = "0x183CB9900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public KOKNAAJOPHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class DOOHDLIFPDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2728960", Offset = "0x2727B60", VA = "0x182728960")]
	public static void NPOOEDKMGNH<T>(this List<T> JLCIFHJMGPA, int HMFNCGHECPG) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface MAENGEFPLDJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NCKGFKCCKNN NKEHBGEOHBC;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class GLHEFCHDPOC : MAENGEFPLDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public readonly struct KNEKIEBKGAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly float CHNNBJODNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly float GHOBLBEPOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		internal readonly bool KMIBCIBKNDH;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float JPOIEEJJKGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x62A6280", Offset = "0x62A5480", VA = "0x1862A6280")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62A63F0", Offset = "0x62A55F0", VA = "0x1862A63F0")]
		public KNEKIEBKGAO(float PFGKDMDHLBN, float KOILIPEDBEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x62A6290", Offset = "0x62A5490", VA = "0x1862A6290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class ODIAECEONEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GLHEFCHDPOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public ODIAECEONEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62A6B10", Offset = "0x62A5D10", VA = "0x1862A6B10")]
		internal void FKHPGKDEDAJ(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly int DIHLAEIGMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private int ICMFNHHHIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly MAENGEFPLDJ[] NBHFHFBLNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NCKGFKCCKNN[] KIGDILPPPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly KNEKIEBKGAO[] JEBBNDKAJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private KNEKIEBKGAO FDDCEJMCKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FAJOLONPKDC MDBLBCOCNOC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NCKGFKCCKNN NKEHBGEOHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x62A5020", Offset = "0x62A4220", VA = "0x1862A5020", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x62A4F60", Offset = "0x62A4160", VA = "0x1862A4F60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x62A5550", Offset = "0x62A4750", VA = "0x1862A5550")]
	public GLHEFCHDPOC(int DIHLAEIGMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x62A4DC0", Offset = "0x62A3FC0", VA = "0x1862A4DC0")]
	public FAJOLONPKDC CHFPDCBDFHK(KNEKIEBKGAO AGKONCHFBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x62A50E0", Offset = "0x62A42E0", VA = "0x1862A50E0")]
	public void OLLNNKDPHNE(MAENGEFPLDJ DEBJKHLLCEI, [Optional] KNEKIEBKGAO OEJPOMIOIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x62A4E50", Offset = "0x62A4050", VA = "0x1862A4E50", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public delegate void NCKGFKCCKNN(float KOHKCABDAPB);
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class PKCCMKKDJKC
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BLGGEKKMIDK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly MAENGEFPLDJ LHOGMNOJODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly NCKGFKCCKNN IAPBAMILEGB;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x62A4900", Offset = "0x62A3B00", VA = "0x1862A4900")]
		public BLGGEKKMIDK(MAENGEFPLDJ LHOGMNOJODN, NCKGFKCCKNN IAPBAMILEGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x62A48B0", Offset = "0x62A3AB0", VA = "0x1862A48B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x62A73A0", Offset = "0x62A65A0", VA = "0x1862A73A0")]
	internal static bool JDIEKDOGCFA(float JPEEHDCLFEK, float HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6297D60", Offset = "0x6296F60", VA = "0x186297D60")]
	internal static float GOCFLEHJOLD(float JPEEHDCLFEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x62A7410", Offset = "0x62A6610", VA = "0x1862A7410")]
	public static IDisposable NEJBJMCAHAM(this MAENGEFPLDJ LHOGMNOJODN, NCKGFKCCKNN IAPBAMILEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FAJOLONPKDC : MAENGEFPLDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private float KOHKCABDAPB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public float JGPMGLPMNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x62A4B10", Offset = "0x62A3D10", VA = "0x1862A4B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NCKGFKCCKNN? NKEHBGEOHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x62A4CA0", Offset = "0x62A3EA0", VA = "0x1862A4CA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x62A4C00", Offset = "0x62A3E00", VA = "0x1862A4C00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public FAJOLONPKDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class BKAPDIACAAL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D64C10", Offset = "0x5D63E10", VA = "0x185D64C10")]
	public BKAPDIACAAL(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[DefaultMember("Item")]
public class FEBMOIFHPEI<TKey, TValue> : ILBBPHJBCKD<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, HCEODMPGOJJ where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class PNLCKKINHOF : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public FEBMOIFHPEI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xF26220", Offset = "0xF25420", VA = "0x180F26220", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x427B3E0", Offset = "0x427A5E0", VA = "0x18427B3E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		[DebuggerHidden]
		public PNLCKKINHOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x37E5340", Offset = "0x37E4540", VA = "0x1837E5340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x427A6F0", Offset = "0x42798F0", VA = "0x18427A6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x427A600", Offset = "0x4279800", VA = "0x18427A600")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x427B200", Offset = "0x427A400", VA = "0x18427B200")]
		private void OFANLJKOCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x427B340", Offset = "0x427A540", VA = "0x18427B340", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly ILBBPHJBCKD<TKey, TValue> CMANJIEHAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IDictionary<TKey, TValue> BHKPCBCJCCG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x37F9C00", Offset = "0x37F8E00", VA = "0x1837F9C00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool EABCDIJODPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TValue HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x37F9DC0", Offset = "0x37F8FC0", VA = "0x1837F9DC0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x37FA020", Offset = "0x37F9220", VA = "0x1837FA020", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> EIAJNMLLEND
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x37F9E00", Offset = "0x37F9000", VA = "0x1837F9E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TValue> FPJNCEHDNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x37F9F00", Offset = "0x37F9100", VA = "0x1837F9F00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x37F9A80", Offset = "0x37F8C80", VA = "0x1837F9A80")]
	public FEBMOIFHPEI(ILBBPHJBCKD<TKey, TValue> CMANJIEHAGM, [Optional] IDictionary<TKey, TValue>? BHKPCBCJCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x37F7830", Offset = "0x37F6A30", VA = "0x1837F7830", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x37F8180", Offset = "0x37F7380", VA = "0x1837F8180")]
	public void ENLBMOKEKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x37F7100", Offset = "0x37F6300", VA = "0x1837F7100", Slot = "9")]
	public void Add(TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x37F8950", Offset = "0x37F7B50", VA = "0x1837F8950")]
	public void HOHNMMAOPKP(TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x37F8C10", Offset = "0x37F7E10", VA = "0x1837F8C10")]
	public void JIAMBHBEKGI(TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x37F8300", Offset = "0x37F7500", VA = "0x1837F8300")]
	public void GOBJAPEMKME(TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x37F80E0", Offset = "0x37F72E0", VA = "0x1837F80E0")]
	public void DNAFKOPJEIE(TKey GOBGGNLGONA, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x37F90D0", Offset = "0x37F82D0", VA = "0x1837F90D0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> DMLEKJCHBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x37F92C0", Offset = "0x37F84C0", VA = "0x1837F92C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x37F9620", Offset = "0x37F8820", VA = "0x1837F9620", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x37F7930", Offset = "0x37F6B30", VA = "0x1837F7930", Slot = "8")]
	public bool ContainsKey(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x37F8B40", Offset = "0x37F7D40", VA = "0x1837F8B40")]
	public bool HPKFNBCLNIL(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x37F6FD0", Offset = "0x37F61D0", VA = "0x1837F6FD0")]
	public bool AFKMDLNLHCB(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x37F8F30", Offset = "0x37F8130", VA = "0x1837F8F30", Slot = "10")]
	public bool Remove(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x37F98E0", Offset = "0x37F8AE0", VA = "0x1837F98E0", Slot = "11")]
	public bool TryGetValue(TKey GOBGGNLGONA, [Out] TValue NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x37F7E30", Offset = "0x37F7030", VA = "0x1837F7E30", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] GEHAOEPMDJB, int NENFDGMLFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x37F97E0", Offset = "0x37F89E0", VA = "0x1837F97E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x37F8670", Offset = "0x37F7870", VA = "0x1837F8670", Slot = "19")]
	[IteratorStateMachine(typeof(FEBMOIFHPEI<, >.PNLCKKINHOF))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x37F8790", Offset = "0x37F7990", VA = "0x1837F8790", Slot = "21")]
	public bool HEOJINNDJNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x37F7740", Offset = "0x37F6940", VA = "0x1837F7740")]
	private TValue CFFJCCJBFIP(TKey GOBGGNLGONA)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface HCEODMPGOJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEOJINNDJNH();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface ILBBPHJBCKD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HCEODMPGOJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
public sealed class AHINDIHIDML<TKey, TVal> : ILBBPHJBCKD<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HCEODMPGOJJ where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate int LCMALILAHFL(TKey GOBGGNLGONA, TVal NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public delegate void EMBACNDGINP(TKey GOBGGNLGONA, TVal NICEPFIEJED, JLIPFEDMPKC LGGFDGCPFCF);

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class AMPADJMILFI
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public TKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TVal FJJHODHBEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x822030", Offset = "0x821230", VA = "0x180822030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int JPOIEEJJKGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x7F40C0", Offset = "0x7F32C0", VA = "0x1807F40C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x7F36B0", Offset = "0x7F28B0", VA = "0x1807F36B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public DateTimeOffset HMODGJDKLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAEBD80", Offset = "0xAEAF80", VA = "0x180AEBD80")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x1380860", Offset = "0x137FA60", VA = "0x181380860")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3AFB5C0", Offset = "0x3AFA7C0", VA = "0x183AFB5C0")]
		public AMPADJMILFI(TKey GOBGGNLGONA, TVal LJPPKNAEGOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HKPIJINDAJK : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AHINDIHIDML<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private LinkedList<AMPADJMILFI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xF26220", Offset = "0xF25420", VA = "0x180F26220", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x37E8630", Offset = "0x37E7830", VA = "0x1837E8630", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		[DebuggerHidden]
		public HKPIJINDAJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x37E03F0", Offset = "0x37DF5F0", VA = "0x1837E03F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3981170", Offset = "0x3980370", VA = "0x183981170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x39806F0", Offset = "0x397F8F0", VA = "0x1839806F0")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3982E70", Offset = "0x3982070", VA = "0x183982E70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public const int AMBECLLLNHD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<TKey, LinkedListNode<AMPADJMILFI>> OANGKDNJHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly LinkedList<AMPADJMILFI> PGOFMEKCPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LCMALILAHFL? FOAEBBNNEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TimeSpan HNICOAMDFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly EMBACNDGINP? LMKIBFMAGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly DMEKHIFJEEK LODNGBAJEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool NDFMKJPONDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly List<TKey> OMAHCADECHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<TVal> MPIBCLNLGLB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FGPMDJIDHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3320", VA = "0x1807C4120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int DKFOGPDKAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9C46B0", Offset = "0x9C38B0", VA = "0x1809C46B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4490", Offset = "0x9C3690", VA = "0x1809C4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x38FC560", Offset = "0x38FB760", VA = "0x1838FC560", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	internal int FHDDHCODKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x38F4EF0", Offset = "0x38F40F0", VA = "0x1838F4EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public ICollection<TVal> FPJNCEHDNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x38FC670", Offset = "0x38FB870", VA = "0x1838FC670", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ICollection<TKey> IDictionary<TKey, TVal>.BDAEDGOPEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x38F90A0", Offset = "0x38F82A0", VA = "0x1838F90A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EABCDIJODPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public TVal HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x38FC630", Offset = "0x38FB830", VA = "0x1838FC630", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x38FC6C0", Offset = "0x38FB8C0", VA = "0x1838FC6C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x38F37C0", Offset = "0x38F29C0", VA = "0x1838F37C0")]
	private bool GKNAEPJFLDF(int DIHLAEIGMPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x38F3AB0", Offset = "0x38F2CB0", VA = "0x1838F3AB0")]
	private void IGLMIFDMPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x38FA3D0", Offset = "0x38F95D0", VA = "0x1838FA3D0")]
	public AHINDIHIDML(int DIHLAEIGMPG, [Optional] LCMALILAHFL? FOAEBBNNEOB, [Optional] IEqualityComparer<TKey>? HBCDMEFGJPN, [Optional] EMBACNDGINP? LMKIBFMAGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x38F9A90", Offset = "0x38F8C90", VA = "0x1838F9A90")]
	public AHINDIHIDML(TimeSpan HNICOAMDFMJ, [Optional] IEqualityComparer<TKey>? HBCDMEFGJPN, [Optional] EMBACNDGINP? LMKIBFMAGDJ, [Optional] DMEKHIFJEEK? LODNGBAJEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x38F9F90", Offset = "0x38F9190", VA = "0x1838F9F90")]
	public AHINDIHIDML(int DIHLAEIGMPG, TimeSpan HNICOAMDFMJ, [Optional] IEqualityComparer<TKey>? HBCDMEFGJPN, [Optional] EMBACNDGINP? LMKIBFMAGDJ, [Optional] DMEKHIFJEEK? LODNGBAJEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x38FB8D0", Offset = "0x38FAAD0", VA = "0x1838FB8D0")]
	public AHINDIHIDML(int DIHLAEIGMPG, LCMALILAHFL? FOAEBBNNEOB, TimeSpan HNICOAMDFMJ, [Optional] IEqualityComparer<TKey>? HBCDMEFGJPN, [Optional] EMBACNDGINP? LMKIBFMAGDJ, [Optional] DMEKHIFJEEK? LODNGBAJEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x38F3A50", Offset = "0x38F2C50", VA = "0x1838F3A50", Slot = "21")]
	public bool HEOJINNDJNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x38F7D80", Offset = "0x38F6F80", VA = "0x1838F7D80", Slot = "22")]
	public bool PODIAEDDOMI(int MKJBDDDPMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x38F0890", Offset = "0x38EFA90", VA = "0x1838F0890")]
	private bool EOHEHONBPCA(int MKJBDDDPMKM, JLIPFEDMPKC LGGFDGCPFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x38EB0D0", Offset = "0x38EA2D0", VA = "0x1838EB0D0")]
	public void BHMONLIGLCO(TKey GOBGGNLGONA, TVal NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x38EA250", Offset = "0x38E9450", VA = "0x1838EA250", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DMLEKJCHBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x38EA3F0", Offset = "0x38E95F0", VA = "0x1838EA3F0", Slot = "9")]
	public void Add(TKey GOBGGNLGONA, TVal NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x38EC900", Offset = "0x38EBB00", VA = "0x1838EC900", Slot = "8")]
	public bool ContainsKey(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x38F8750", Offset = "0x38F7950", VA = "0x1838F8750", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x38F8510", Offset = "0x38F7710", VA = "0x1838F8510", Slot = "10")]
	public bool Remove(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x38F8B10", Offset = "0x38F7D10", VA = "0x1838F8B10", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x38F2DB0", Offset = "0x38F1FB0", VA = "0x1838F2DB0")]
	private bool FFKLEGDPMKI(TKey GOBGGNLGONA, [Out] TVal NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x38F7910", Offset = "0x38F6B10", VA = "0x1838F7910")]
	private TVal OLBNKGLEPPK(TKey FHICNGPLFBN)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x38F9900", Offset = "0x38F8B00", VA = "0x1838F9900", Slot = "11")]
	public bool TryGetValue(TKey FHICNGPLFBN, [Out] TVal NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x38EC860", Offset = "0x38EBA60", VA = "0x1838EC860", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x38EE160", Offset = "0x38ED360", VA = "0x1838EE160", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GEHAOEPMDJB, int NENFDGMLFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x38F2240", Offset = "0x38F1440", VA = "0x1838F2240")]
	private void FDEFNJADMCB(TKey GOBGGNLGONA, TVal LJPPKNAEGOB, JLIPFEDMPKC LGGFDGCPFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x38EE950", Offset = "0x38EDB50", VA = "0x1838EE950")]
	private bool EKHLDGAKEGB(AMPADJMILFI NEGEJKDJKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x38F6810", Offset = "0x38F5A10", VA = "0x1838F6810")]
	private void OFGPIDPLHFK(LinkedListNode<AMPADJMILFI> DEEFKDJEPDO, TVal AOEOAHBCBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x38EB1B0", Offset = "0x38EA3B0", VA = "0x1838EB1B0")]
	private void CBHGKBMPIGJ(TKey GOBGGNLGONA, TVal NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x38F4D20", Offset = "0x38F3F20", VA = "0x1838F4D20")]
	private void IHPLAJAPIAC(AMPADJMILFI NEGEJKDJKDD, TVal AOEOAHBCBKJ, int GAJHCGJHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x38F3810", Offset = "0x38F2A10", VA = "0x1838F3810", Slot = "19")]
	[IteratorStateMachine(typeof(AHINDIHIDML<, >.HKPIJINDAJK))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x38F90D0", Offset = "0x38F82D0", VA = "0x1838F90D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public enum JLIPFEDMPKC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class OGEIIPCODGH<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly TKey GNLOHLONNBG;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4183560", Offset = "0x4182760", VA = "0x184183560")]
	public OGEIIPCODGH(TKey JMCIGEHEOGL, Exception EBFLENHEHHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class BKOGNECIAJC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x565D3A0", Offset = "0x565C5A0", VA = "0x18565D3A0")]
	public BKOGNECIAJC(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class IONPCIOLGHJ<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class EFFHJMLMJFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IONPCIOLGHJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public EFFHJMLMJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x34734F0", Offset = "0x34726F0", VA = "0x1834734F0")]
		internal Task<TResource> PHIPKGICLEB(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct EMHKGOEIFOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IONPCIOLGHJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x348F8E0", Offset = "0x348EAE0", VA = "0x18348F8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3490180", Offset = "0x348F380", VA = "0x183490180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct BLIDFIGKGAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x48A9420", Offset = "0x48A8620", VA = "0x1848A9420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x48A9D50", Offset = "0x48A8F50", VA = "0x1848A9D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly FHNDOFLLNKJ<TId, Task<TResource>> NAMBINAJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> CDNKANNHKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? AJALMAEKIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Action<TResource>? NOOBJHJLMLI;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3A63180", Offset = "0x3A62380", VA = "0x183A63180")]
	public IONPCIOLGHJ(int GKLCOJCLEIA = 0, [Optional] IEqualityComparer<TId>? EPACCDMMHFJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? HOANCKEKKGD, [Optional] Action<TResource>? JOCOILNLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3A62C90", Offset = "0x3A61E90", VA = "0x183A62C90")]
	public IFNEFIDKPAH<Task<TResource>> PGLPCKLKBJO(TId JNIKIHKLGAD, [Optional] Func<TId, CancellationToken, Task<TResource>>? HOANCKEKKGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3A61FD0", Offset = "0x3A611D0", VA = "0x183A61FD0")]
	private void IOMPALJAJPM(Task<TResource> OCAKELEHPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3A62690", Offset = "0x3A61890", VA = "0x183A62690")]
	[AsyncStateMachine(typeof(IONPCIOLGHJ<, >.EMHKGOEIFOO))]
	private Task MHGJMOHOEHM(Task<TResource> OCAKELEHPCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3A62660", Offset = "0x3A61860", VA = "0x183A62660")]
	public void JLLDPHEFBDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3A62990", Offset = "0x3A61B90", VA = "0x183A62990")]
	public FHNDOFLLNKJ<TId, Task<TResource>>.OBELFBBDKGG ODDJKKOCOEI()
	{
		return default(FHNDOFLLNKJ<TId, Task<TResource>>.OBELFBBDKGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3A63060", Offset = "0x3A62260", VA = "0x183A63060", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3A63060", Offset = "0x3A62260", VA = "0x183A63060", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3A62400", Offset = "0x3A61600", VA = "0x183A62400")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(IONPCIOLGHJ<, >.BLIDFIGKGAB))]
	internal static Task JDIBGCGHLID(Task<TResource> OCAKELEHPCL, CancellationTokenSource HMAEBLEAPMM, Dictionary<Task<TResource>, CancellationTokenSource> FDDHBCPHOIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class FHNDOFLLNKJ<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private sealed class IHCOPMICKLN : IEquatable<IHCOPMICKLN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly TValue FJJHODHBEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int COEEBMIAANH;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x82CC90", Offset = "0x82BE90", VA = "0x18082CC90")]
		public IHCOPMICKLN(TValue NICEPFIEJED, int MPKIKELMBOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F7D0", Offset = "0x3A3E9D0", VA = "0x183A3F7D0", Slot = "4")]
		public bool Equals(IHCOPMICKLN? NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F740", Offset = "0x3A3E940", VA = "0x183A3F740", Slot = "0")]
		public override bool Equals(object? JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F850", Offset = "0x3A3EA50", VA = "0x183A3F850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct OBELFBBDKGG : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<TKey, IHCOPMICKLN>.Enumerator GCCAFNGAFPH;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x412E790", Offset = "0x412D990", VA = "0x18412E790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public (TKey Key, TValue Value, int RefCount) DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x412EB60", Offset = "0x412DD60", VA = "0x18412EB60", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x412E8F0", Offset = "0x412DAF0", VA = "0x18412E8F0")]
		public OBELFBBDKGG(FHNDOFLLNKJ<TKey, TValue> FOGKLDABGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x412E340", Offset = "0x412D540", VA = "0x18412E340", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x412E3C0", Offset = "0x412D5C0", VA = "0x18412E3C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x412E4F0", Offset = "0x412D6F0", VA = "0x18412E4F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class LNKMBHKAMHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public FHNDOFLLNKJ<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public IHCOPMICKLN refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LNKMBHKAMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3D945E0", Offset = "0x3D937E0", VA = "0x183D945E0")]
		internal void PHIPKGICLEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<TKey, IHCOPMICKLN> KMMGHHEMDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Func<TKey, TValue>? APKGHPKEMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Action<TValue>? MFDBOJIGEJH;

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x37FF910", Offset = "0x37FEB10", VA = "0x1837FF910")]
	public FHNDOFLLNKJ(int GKLCOJCLEIA = 0, [Optional] IEqualityComparer<TKey>? HBCDMEFGJPN, [Optional] Func<TKey, TValue>? JEDDDPDAOPO, [Optional] Action<TValue>? BGHBJECDOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x37FF4A0", Offset = "0x37FE6A0", VA = "0x1837FF4A0")]
	public IFNEFIDKPAH<TValue> PGLPCKLKBJO(TKey GOBGGNLGONA, [Optional] Func<TKey, TValue>? HDILAFDKDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x37FE710", Offset = "0x37FD910", VA = "0x1837FE710")]
	private void EJBBKCPFFPM(TKey GOBGGNLGONA, IHCOPMICKLN FOKJEFECFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x37FE900", Offset = "0x37FDB00", VA = "0x1837FE900")]
	public void JLLDPHEFBDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x37FEF00", Offset = "0x37FE100", VA = "0x1837FEF00")]
	public OBELFBBDKGG ODDJKKOCOEI()
	{
		return default(OBELFBBDKGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x37FF750", Offset = "0x37FE950", VA = "0x1837FF750", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x37FF750", Offset = "0x37FE950", VA = "0x1837FF750", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
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
