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
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x605D3F0", Offset = "0x605C1F0", VA = "0x18605D3F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FDKHLDGEHMA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected FDKHLDGEHMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class AEPHMJCCAPJ<T> : FDKHLDGEHMA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct MHMLDFLEADM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JICAKOOKNIG
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
		public JICAKOOKNIG HJCFEPLFGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T APDAGBKMGMB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int PDPCIJGAOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool DJGPALNJBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool ACGBFJHFPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? DCGAJGHGMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<MHMLDFLEADM>? GOCCDFODJJI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BNOOELANPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x368B870", Offset = "0x368A670", VA = "0x18368B870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x368BB40", Offset = "0x368A940", VA = "0x18368BB40")]
	protected AEPHMJCCAPJ(bool ACGBFJHFPCG, bool DJGPALNJBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x368B410", Offset = "0x368A210", VA = "0x18368B410")]
	protected bool DKGFCNOIKLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x368B8C0", Offset = "0x368A6C0", VA = "0x18368B8C0")]
	protected void IICHNAEBIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x368B690", Offset = "0x368A490", VA = "0x18368B690")]
	protected void HHBDOFFCIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2194C00", Offset = "0x2193A00", VA = "0x182194C00")]
	private static void CKLHABOBCLK<U>(List<U>? HFLDOAFOIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x368B4B0", Offset = "0x368A2B0", VA = "0x18368B4B0", Slot = "4")]
	public void EHPBILHDFGD(T APDAGBKMGMB, bool JCJPFCAEGNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x368B260", Offset = "0x368A060", VA = "0x18368B260", Slot = "5")]
	public void CPMMAHJGJAD(T APDAGBKMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x368B9C0", Offset = "0x368A7C0", VA = "0x18368B9C0")]
	public void LJNFEICKFHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EBNMHIGEHAA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHPBILHDFGD(Action APDAGBKMGMB, bool JCJPFCAEGNM = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPMMAHJGJAD(Action APDAGBKMGMB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class AHOMABILGKI : AEPHMJCCAPJ<Action>, EBNMHIGEHAA
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x605B220", Offset = "0x605A020", VA = "0x18605B220")]
	public AHOMABILGKI(bool ACGBFJHFPCG = false, bool DJGPALNJBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x605AF60", Offset = "0x6059D60", VA = "0x18605AF60")]
	public void HJLFLPDKJMP()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x605B160", Offset = "0x6059F60", VA = "0x18605B160")]
	public static AHOMABILGKI NPOIEBJCKFC(AHOMABILGKI FMOOOEEEBHG, Action APDAGBKMGMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x605B1C0", Offset = "0x6059FC0", VA = "0x18605B1C0")]
	public static AHOMABILGKI PJAFLCNCBFI(AHOMABILGKI FMOOOEEEBHG, Action APDAGBKMGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ENMBIPEHJFG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHPBILHDFGD(Action<T> APDAGBKMGMB, bool JCJPFCAEGNM = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPMMAHJGJAD(Action<T> APDAGBKMGMB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class JBCIPMEOJLB<T> : AEPHMJCCAPJ<Action<T>>, ENMBIPEHJFG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D40", Offset = "0x37E8B40", VA = "0x1837E9D40")]
	public JBCIPMEOJLB(bool ACGBFJHFPCG = false, bool DJGPALNJBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x39A1B70", Offset = "0x39A0970", VA = "0x1839A1B70")]
	public void HJLFLPDKJMP(T LNJHGKLPHDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37E9C20", Offset = "0x37E8A20", VA = "0x1837E9C20")]
	public static JBCIPMEOJLB<T> NPOIEBJCKFC(JBCIPMEOJLB<T> FMOOOEEEBHG, Action<T> APDAGBKMGMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37E9CB0", Offset = "0x37E8AB0", VA = "0x1837E9CB0")]
	public static JBCIPMEOJLB<T> PJAFLCNCBFI(JBCIPMEOJLB<T> FMOOOEEEBHG, Action<T> APDAGBKMGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CCGLJJNFLMA<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IBLNPGMIBPH<T, U> : AEPHMJCCAPJ<Action<T, U>>, CCGLJJNFLMA<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D40", Offset = "0x37E8B40", VA = "0x1837E9D40")]
	public IBLNPGMIBPH(bool ACGBFJHFPCG = false, bool DJGPALNJBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37F9F70", Offset = "0x37F8D70", VA = "0x1837F9F70")]
	public void HJLFLPDKJMP(T LNJHGKLPHDO, U HEFDLEKJBHI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37E9C20", Offset = "0x37E8A20", VA = "0x1837E9C20")]
	public static IBLNPGMIBPH<T, U> NPOIEBJCKFC(IBLNPGMIBPH<T, U> FMOOOEEEBHG, Action<T, U> APDAGBKMGMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37E9CB0", Offset = "0x37E8AB0", VA = "0x1837E9CB0")]
	public static IBLNPGMIBPH<T, U> PJAFLCNCBFI(IBLNPGMIBPH<T, U> FMOOOEEEBHG, Action<T, U> APDAGBKMGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class LDGEDNBADNP<T, U, V> : AEPHMJCCAPJ<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D40", Offset = "0x37E8B40", VA = "0x1837E9D40")]
	public LDGEDNBADNP(bool ACGBFJHFPCG = false, bool DJGPALNJBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B3DAE0", Offset = "0x3B3C8E0", VA = "0x183B3DAE0")]
	public void HJLFLPDKJMP(T LNJHGKLPHDO, U HEFDLEKJBHI, V DBEGAKOKNOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37E9C20", Offset = "0x37E8A20", VA = "0x1837E9C20")]
	public static LDGEDNBADNP<T, U, V> NPOIEBJCKFC(LDGEDNBADNP<T, U, V> FMOOOEEEBHG, Action<T, U, V> APDAGBKMGMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37E9CB0", Offset = "0x37E8AB0", VA = "0x1837E9CB0")]
	public static LDGEDNBADNP<T, U, V> PJAFLCNCBFI(LDGEDNBADNP<T, U, V> FMOOOEEEBHG, Action<T, U, V> APDAGBKMGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IKOJDOFFHAM<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class IHODMFEAFMF<T, U, V, W> : AEPHMJCCAPJ<Action<T, U, V, W>>, IKOJDOFFHAM<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D40", Offset = "0x37E8B40", VA = "0x1837E9D40")]
	public IHODMFEAFMF(bool ACGBFJHFPCG = false, bool DJGPALNJBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38100D0", Offset = "0x380EED0", VA = "0x1838100D0")]
	public void HJLFLPDKJMP(T LNJHGKLPHDO, U HEFDLEKJBHI, V DBEGAKOKNOL, W PCGLBNPPNBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37E9C20", Offset = "0x37E8A20", VA = "0x1837E9C20")]
	public static IHODMFEAFMF<T, U, V, W> NPOIEBJCKFC(IHODMFEAFMF<T, U, V, W> FMOOOEEEBHG, Action<T, U, V, W> APDAGBKMGMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37E9CB0", Offset = "0x37E8AB0", VA = "0x1837E9CB0")]
	public static IHODMFEAFMF<T, U, V, W> PJAFLCNCBFI(IHODMFEAFMF<T, U, V, W> FMOOOEEEBHG, Action<T, U, V, W> APDAGBKMGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class JLEJJDMJMDO<T, U, V, W, X> : AEPHMJCCAPJ<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D40", Offset = "0x37E8B40", VA = "0x1837E9D40")]
	public JLEJJDMJMDO(bool ACGBFJHFPCG = false, bool DJGPALNJBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B750", Offset = "0x3A0A550", VA = "0x183A0B750")]
	public void HJLFLPDKJMP(T LNJHGKLPHDO, U HEFDLEKJBHI, V DBEGAKOKNOL, W PCGLBNPPNBP, X PCOMFHJKLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37E9C20", Offset = "0x37E8A20", VA = "0x1837E9C20")]
	public static JLEJJDMJMDO<T, U, V, W, X> NPOIEBJCKFC(JLEJJDMJMDO<T, U, V, W, X> FMOOOEEEBHG, Action<T, U, V, W, X> APDAGBKMGMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37E9CB0", Offset = "0x37E8AB0", VA = "0x1837E9CB0")]
	public static JLEJJDMJMDO<T, U, V, W, X> PJAFLCNCBFI(JLEJJDMJMDO<T, U, V, W, X> FMOOOEEEBHG, Action<T, U, V, W, X> APDAGBKMGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class IAJIPICMLBF<T, U, V, W, X, Y> : AEPHMJCCAPJ<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D40", Offset = "0x37E8B40", VA = "0x1837E9D40")]
	public IAJIPICMLBF(bool ACGBFJHFPCG = false, bool DJGPALNJBMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37E9470", Offset = "0x37E8270", VA = "0x1837E9470")]
	public void HJLFLPDKJMP(T LNJHGKLPHDO, U HEFDLEKJBHI, V DBEGAKOKNOL, W PCGLBNPPNBP, X PCOMFHJKLCD, Y EANLPGFBDDM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x37E9C20", Offset = "0x37E8A20", VA = "0x1837E9C20")]
	public static IAJIPICMLBF<T, U, V, W, X, Y> NPOIEBJCKFC(IAJIPICMLBF<T, U, V, W, X, Y> FMOOOEEEBHG, Action<T, U, V, W, X, Y> APDAGBKMGMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37E9CB0", Offset = "0x37E8AB0", VA = "0x1837E9CB0")]
	public static IAJIPICMLBF<T, U, V, W, X, Y> PJAFLCNCBFI(IAJIPICMLBF<T, U, V, W, X, Y> FMOOOEEEBHG, Action<T, U, V, W, X, Y> APDAGBKMGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FPJKKGCFCOB<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EODJEADNCOB<TKey, TVal> PAGPMCMGBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> ENCJEPKAAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int CMGCIHBNIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly EODJEADNCOB<TKey, TVal>.IGOFPDBOOID? PGLPOBPDFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int EDEOHGLFFFP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int ACBDJFHAFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3628FE0", Offset = "0x3627DE0", VA = "0x183628FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ELBHIJPAFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BDDC0", VA = "0x1808BEFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3629250", Offset = "0x3628050", VA = "0x183629250")]
	public FPJKKGCFCOB(int CMGCIHBNIMH, [Optional] EODJEADNCOB<TKey, TVal>.IGOFPDBOOID? PGLPOBPDFKN, [Optional] IEqualityComparer<TKey>? OFOIBJDIOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3628B00", Offset = "0x3627900", VA = "0x183628B00")]
	public void GMKJOBJEOOG(TKey IDGIKKEFDCG, TVal MBDKMNBCLGF, bool BNJGGPPEKFO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3628CD0", Offset = "0x3627AD0", VA = "0x183628CD0")]
	public bool HMOIKOMMNNC(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3628F00", Offset = "0x3627D00", VA = "0x183628F00")]
	public bool JPCECNBPLDE(TKey JPBAKCAAHEF, [Out] TVal MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3629030", Offset = "0x3627E30", VA = "0x183629030")]
	private void OHHFOFEJGCM(TKey IDGIKKEFDCG, TVal MBDKMNBCLGF, int GENDLFFGOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3628D70", Offset = "0x3627B70", VA = "0x183628D70")]
	public bool IBLAPIODLIA(TKey IDGIKKEFDCG, TVal MBDKMNBCLGF, bool BNJGGPPEKFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3628A40", Offset = "0x3627840", VA = "0x183628A40")]
	private bool BMNCGGPCCIG(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OCDPCHKANHP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action AAMHKDMBHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool JDHHNBHGPMC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	public OCDPCHKANHP(Action FOFIEAHFHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x605D470", Offset = "0x605C270", VA = "0x18605D470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x24082C0", Offset = "0x24070C0", VA = "0x1824082C0")]
	public static HPJIADMGLDJ<T> KCGHAKHJLMB<T>(T MBDKMNBCLGF, Action FOFIEAHFHIE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HPJIADMGLDJ<T> : OCDPCHKANHP where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T AOJPLLHPPML
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3761C50", Offset = "0x3760A50", VA = "0x183761C50")]
	public HPJIADMGLDJ(T MBDKMNBCLGF, Action FOFIEAHFHIE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FAIKJEPOLAE : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct FBDEINBBBMD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0")]
		public static FBDEINBBBMD DCPHPAHCOGO()
		{
			return default(FBDEINBBBMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0")]
	public static FAIKJEPOLAE LGAODFEAPCK(Type HJCFEPLFGPG, [Optional] string? DMPMEKKGNBE, [Optional] string? AAFIBNGABHB, bool DOINLLGNFMM = false)
	{
		return default(FAIKJEPOLAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0")]
	public static FAIKJEPOLAE LGAODFEAPCK<T>([Optional] string? DMPMEKKGNBE, [Optional] string? AAFIBNGABHB, bool DOINLLGNFMM = false)
	{
		return default(FAIKJEPOLAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OHODIPFGKMP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool BFDLIDAOCJL(string DFKGJKNLKHL, OHODIPFGKMP FGJJOANPKPI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int ECHPJMAFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string FIHGKEBGBOB;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x605DB60", Offset = "0x605C960", VA = "0x18605DB60")]
	public static Dictionary<string, OHODIPFGKMP> PEACMNOLMGC(Type FFNFLPNOIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x605D670", Offset = "0x605C470", VA = "0x18605D670")]
	public static Dictionary<string, OHODIPFGKMP> GCCNKJBBMPD(Type FFNFLPNOIBM, BFDLIDAOCJL JKBDBMEBBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x605D4B0", Offset = "0x605C2B0", VA = "0x18605D4B0")]
	public static Dictionary<int, string> BKMBENCMFBF(Dictionary<string, OHODIPFGKMP> LGDFGELLOEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class BLCGFLBNPHB : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string DHMFLLFAIHD(string MFEKCDHJOJK);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	protected BLCGFLBNPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class HFGDJMMINEP : KPPOPJKBMGO
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool EBEFGBFMMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? IEENBBIAOEM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual KPPOPJKBMGO? AIPJIEFNIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x605BCC0", Offset = "0x605AAC0", VA = "0x18605BCC0")]
	protected HFGDJMMINEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string EFDGLBEJKDO();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x605BC40", Offset = "0x605AA40", VA = "0x18605BC40", Slot = "8")]
	public virtual string MPLCLDIEPCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x605B990", Offset = "0x605A790", VA = "0x18605B990", Slot = "9")]
	public void KKPFHMNNGEJ(StringBuilder CJDKGDBMBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x605B610", Offset = "0x605A410", VA = "0x18605B610", Slot = "10")]
	public void AINFIEAIGAG(StringBuilder CJDKGDBMBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x605B7D0", Offset = "0x605A5D0", VA = "0x18605B7D0", Slot = "11")]
	public void FGJOIKNBJFF(StringBuilder CJDKGDBMBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x605B670", Offset = "0x605A470", VA = "0x18605B670", Slot = "12")]
	public void CJPELGNMKOF(StringBuilder CJDKGDBMBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x605B8F0", Offset = "0x605A6F0", VA = "0x18605B8F0")]
	public static void INJHECFKOII(StringBuilder CJDKGDBMBBF, string IGJLAIBKGCG, string ALHHDLLPGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x532E660", Offset = "0x532D460", VA = "0x18532E660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HAKMBNOPNPB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x605B5B0", Offset = "0x605A3B0", VA = "0x18605B5B0")]
	public HAKMBNOPNPB(string EKPMNNKLPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KGDGBGPPAGA<TErr> : HAKMBNOPNPB where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr NBKEAFDHFGP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A99470", Offset = "0x3A98270", VA = "0x183A99470")]
	private KGDGBGPPAGA([In] TErr BFMIDINCDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A993A0", Offset = "0x3A981A0", VA = "0x183A993A0")]
	public static KGDGBGPPAGA<TErr> DCPHPAHCOGO([In] TErr BFMIDINCDGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KPPOPJKBMGO
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MPLCLDIEPCE();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EFDGLBEJKDO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NOOEKMCCKPC<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions AOJPLLHPPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DBPKEJEJCBA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string AKBCKBGEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JEFCEIKLOEC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x605CB20", Offset = "0x605B920", VA = "0x18605CB20")]
	public JEFCEIKLOEC(string EKPMNNKLPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PDAJJIHMBJK<TOk> : JEFCEIKLOEC where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk GCPPFCEHDOP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3F987E0", Offset = "0x3F975E0", VA = "0x183F987E0")]
	private PDAJJIHMBJK([In] TOk AOEIEBHFGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3730F70", Offset = "0x372FD70", VA = "0x183730F70")]
	public static PDAJJIHMBJK<TOk> DCPHPAHCOGO([In] TOk AOEIEBHFGFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct CGKJAMMICEF<TOk, TErr> : IEquatable<CGKJAMMICEF<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> HMICHABCNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr NBKEAFDHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk GCPPFCEHDOP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HPOKKNGFHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x48F52C0", Offset = "0x48F40C0", VA = "0x1848F52C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NECBOHKJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x48F69A0", Offset = "0x48F57A0", VA = "0x1848F69A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x48F8EC0", Offset = "0x48F7CC0", VA = "0x1848F8EC0")]
	internal CGKJAMMICEF([In] TErr BFMIDINCDGB, [In] TOk AOEIEBHFGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x48F5520", Offset = "0x48F4320", VA = "0x1848F5520")]
	public static CGKJAMMICEF<TOk, TErr> EBJCOIDFONE([In] TErr BFMIDINCDGB)
	{
		return default(CGKJAMMICEF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x48F6F90", Offset = "0x48F5D90", VA = "0x1848F6F90")]
	public static CGKJAMMICEF<TOk, TErr> IGAMJOKEPMD([In] TOk AOEIEBHFGFM)
	{
		return default(CGKJAMMICEF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2F048D0", Offset = "0x2F036D0", VA = "0x182F048D0")]
	public CGKJAMMICEF<TOk?, UErr?> FKMBDHLLEJJ<UErr>()
	{
		return default(CGKJAMMICEF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2F03550", Offset = "0x2F02350", VA = "0x182F03550")]
	public CGKJAMMICEF<UOk?, TErr?> AOGFDNCAOOA<UOk>()
	{
		return default(CGKJAMMICEF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2F040D0", Offset = "0x2F02ED0", VA = "0x182F040D0")]
	public CGKJAMMICEF<UOk?, TErr?> BNJGNFJHCFG<UOk>()
	{
		return default(CGKJAMMICEF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2F05050", Offset = "0x2F03E50", VA = "0x182F05050")]
	public CGKJAMMICEF<TOk?, UErr?> IMKEICAABFB<UErr>()
	{
		return default(CGKJAMMICEF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x48F7180", Offset = "0x48F5F80", VA = "0x1848F7180")]
	public CGKJAMMICEF<BCBPFABBCDG, TErr> KDBOIGDENNE()
	{
		return default(CGKJAMMICEF<BCBPFABBCDG, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x48F7CF0", Offset = "0x48F6AF0", VA = "0x1848F7CF0")]
	public static bool KFENMBPPCHH([In] CGKJAMMICEF<TOk, TErr> PDAKJJLHJDL, [In] CGKJAMMICEF<TOk, TErr> KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x48F57D0", Offset = "0x48F45D0", VA = "0x1848F57D0", Slot = "4")]
	public bool Equals(CGKJAMMICEF<TOk, TErr> GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x48F5FA0", Offset = "0x48F4DA0", VA = "0x1848F5FA0", Slot = "0")]
	public override bool Equals(object GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x48F6690", Offset = "0x48F5490", VA = "0x1848F6690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x48F86F0", Offset = "0x48F74F0", VA = "0x1848F86F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DBHHCNADNDG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct FNHNHDHMKFE<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<CGKJAMMICEF<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<CGKJAMMICEF<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3622A30", Offset = "0x3621830", VA = "0x183622A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3622D50", Offset = "0x3621B50", VA = "0x183622D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24646A0", Offset = "0x24634A0", VA = "0x1824646A0")]
	public static CGKJAMMICEF<TOk?, TErr?> GCPPFCEHDOP<TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [In] TOk AOEIEBHFGFM)
	{
		return default(CGKJAMMICEF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2464770", Offset = "0x2463570", VA = "0x182464770")]
	public static CGKJAMMICEF<BCBPFABBCDG, TErr?> GCPPFCEHDOP<TErr>([In] this CGKJAMMICEF<BCBPFABBCDG, TErr> OJFDNDCDDBK)
	{
		return default(CGKJAMMICEF<BCBPFABBCDG, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x24646A0", Offset = "0x24634A0", VA = "0x1824646A0")]
	public static CGKJAMMICEF<TOk?, TErr?> NBKEAFDHFGP<TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [In] TErr BFMIDINCDGB)
	{
		return default(CGKJAMMICEF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x24660A0", Offset = "0x2464EA0", VA = "0x1824660A0")]
	public static TOk? OONOGFCHNNA<TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2464320", Offset = "0x2463120", VA = "0x182464320")]
	[AsyncStateMachine(typeof(FNHNHDHMKFE<, >))]
	public static Task<TOk?>? BOHPDKPPMDH<TOk, TErr>(this Task<CGKJAMMICEF<TOk, TErr>> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x24647F0", Offset = "0x24635F0", VA = "0x1824647F0")]
	public static TErr? HFILKEKCJJM<TErr, TOk>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2464E20", Offset = "0x2463C20", VA = "0x182464E20")]
	public static bool JBLBIKLOHAO<TOk, TErr, UErr, UOk>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [Out] CGKJAMMICEF<UOk, UErr> PGMMNJINBJN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x24659D0", Offset = "0x24647D0", VA = "0x1824659D0")]
	public static bool JLBNIJCDBIM<TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [Out][NotNullWhen(true)] TOk AOEIEBHFGFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x24645C0", Offset = "0x24633C0", VA = "0x1824645C0")]
	public static bool EKKOEAFLIDK<TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [Out][NotNullWhen(true)] TErr BFMIDINCDGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2464C10", Offset = "0x2463A10", VA = "0x182464C10")]
	public static bool ICJMJDNIMDE<TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [Out][NotNullWhen(true)] TOk AOEIEBHFGFM, [Out][NotNullWhen(false)] TErr BFMIDINCDGB) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2465D80", Offset = "0x2464B80", VA = "0x182465D80")]
	public static bool LDCBIGNINME<TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [Out][NotNullWhen(true)] TOk AOEIEBHFGFM, [Out] CGKJAMMICEF<TOk, TErr> PGMMNJINBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2464D00", Offset = "0x2463B00", VA = "0x182464D00")]
	public static bool JBLBIKLOHAO<TOk, TErr, UErr, UOk>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [Out][NotNullWhen(true)] TOk AOEIEBHFGFM, [Out] CGKJAMMICEF<UOk, UErr> PGMMNJINBJN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x24640A0", Offset = "0x2462EA0", VA = "0x1824640A0")]
	public static bool ACFFADJMMJJ<TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [Out][NotNullWhen(true)] TOk AOEIEBHFGFM, [Out] CGKJAMMICEF<BCBPFABBCDG, TErr> PGMMNJINBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2466380", Offset = "0x2465180", VA = "0x182466380")]
	public static CGKJAMMICEF<UOk, UErr> PLIJLGGFPMD<UOk, UErr, TOk, TErr>([In] this CGKJAMMICEF<TOk, TErr> OJFDNDCDDBK, [In] CGKJAMMICEF<UOk, UErr> JFLBCAAFGDD) where TOk : UOk where TErr : UErr
	{
		return default(CGKJAMMICEF<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2465A40", Offset = "0x2464840", VA = "0x182465A40")]
	public static CGKJAMMICEF<TOk?[]?, TErr?> KKJIIEPDIAA<TOk, TErr>(this IEnumerable<CGKJAMMICEF<TOk, TErr>> OJFDNDCDDBK)
	{
		return default(CGKJAMMICEF<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IGIINAEPMHP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x21A88E0", Offset = "0x21A76E0", VA = "0x1821A88E0")]
	public static CGKJAMMICEF<TOk, T> GCPPFCEHDOP<TOk>([In] TOk AOEIEBHFGFM) where TOk : notnull
	{
		return default(CGKJAMMICEF<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x380AD10", Offset = "0x3809B10", VA = "0x18380AD10")]
	public static CGKJAMMICEF<BCBPFABBCDG, T> GCPPFCEHDOP()
	{
		return default(CGKJAMMICEF<BCBPFABBCDG, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x21A88E0", Offset = "0x21A76E0", VA = "0x1821A88E0")]
	public static CGKJAMMICEF<T, TErr> NBKEAFDHFGP<TErr>([In] TErr BFMIDINCDGB) where TErr : notnull
	{
		return default(CGKJAMMICEF<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public sealed class APKIDHFLHMG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct GAJHHDJHPAM : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly APKIDHFLHMG<T> HBMLJMADPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int HEJMHFBPOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool EDAANALJBPC;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1C2B0B0", Offset = "0x1C29EB0", VA = "0x181C2B0B0")]
		public GAJHHDJHPAM(APKIDHFLHMG<T> OGNMHOKFLGN, int PLPPHBPHFHG, bool HLLBAPJMAAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x36C83D0", Offset = "0x36C71D0", VA = "0x1836C83D0")]
		public APKIDHFLHMG<T>.CLINIIAKCMP BCGCEOCJJAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x36C84C0", Offset = "0x36C72C0", VA = "0x1836C84C0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x36C84C0", Offset = "0x36C72C0", VA = "0x1836C84C0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class CLINIIAKCMP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly APKIDHFLHMG<T> HBMLJMADPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int GBFNCGHJBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int PGCOBEGLKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool EDAANALJBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool BLMNJHIDLDM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4AB96A0", Offset = "0x4AB84A0", VA = "0x184AB96A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4AB9790", Offset = "0x4AB8590", VA = "0x184AB9790", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4AB99A0", Offset = "0x4AB87A0", VA = "0x184AB99A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4AB9DA0", Offset = "0x4AB8BA0", VA = "0x184AB9DA0")]
		public CLINIIAKCMP(APKIDHFLHMG<T> OGNMHOKFLGN, int PLPPHBPHFHG, bool HLLBAPJMAAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4AB96E0", Offset = "0x4AB84E0", VA = "0x184AB96E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4AB9770", Offset = "0x4AB8570", VA = "0x184AB9770", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PMONAEJEJPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public PMONAEJEJPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4052330", Offset = "0x4051130", VA = "0x184052330")]
		internal T MBBAJEHOCMN(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] EKLHJNHDDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int PGCOBEGLKCH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GDBIDAGOPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x36B8740", Offset = "0x36B7540", VA = "0x1836B8740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T GCDIDLPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x35D4870", Offset = "0x35D3670", VA = "0x1835D4870")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T PAEFCMFOLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x36B8590", Offset = "0x36B7390", VA = "0x1836B8590")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x36B8690", Offset = "0x36B7490", VA = "0x1836B8690")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PIOKOHDJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1629050", Offset = "0x1627E50", VA = "0x181629050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xF02AE0", Offset = "0xF018E0", VA = "0x180F02AE0")]
	private static int DFPMHFBGDPA(int HPLKFBKKIBG, int GENFKPIGLNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x36B8A50", Offset = "0x36B7850", VA = "0x1836B8A50")]
	public APKIDHFLHMG(int GENDLFFGOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x36B8830", Offset = "0x36B7630", VA = "0x1836B8830")]
	public APKIDHFLHMG(int GENDLFFGOMM, Func<T> HEKBJMGPEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x36B89B0", Offset = "0x36B77B0", VA = "0x1836B89B0")]
	public APKIDHFLHMG(T[] PNAEPBNICFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x36B85C0", Offset = "0x36B73C0", VA = "0x1836B85C0")]
	public void EMHEIJJDDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x36B84D0", Offset = "0x36B72D0", VA = "0x1836B84D0")]
	public IEnumerable<T> CLJLEFFNJNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x36B8440", Offset = "0x36B7240", VA = "0x1836B8440")]
	public APKIDHFLHMG<T>.CLINIIAKCMP BCGCEOCJJAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35FC940", Offset = "0x35FB740", VA = "0x1835FC940", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x35FC940", Offset = "0x35FB740", VA = "0x1835FC940", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EEJNEMGGHKP
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x248CD00", Offset = "0x248BB00", VA = "0x18248CD00")]
	public static APKIDHFLHMG<T> DCPHPAHCOGO<T>(int GENDLFFGOMM, Func<T> HEKBJMGPEKM) where T : notnull
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
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E0B0", Offset = "0x1D0CEB0", VA = "0x181D0E0B0")]
		public RRColor(float CBMBPKNBJOB, float MOEOGLEJBOH, float BJNEJGMGENI, float OIPELOMOKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x605DE90", Offset = "0x605CC90", VA = "0x18605DE90", Slot = "4")]
		public bool Equals(RRColor GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x605DF10", Offset = "0x605CD10", VA = "0x18605DF10", Slot = "0")]
		public override bool Equals(object GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x605E010", Offset = "0x605CE10", VA = "0x18605E010", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x605E090", Offset = "0x605CE90", VA = "0x18605E090", Slot = "5")]
		public string ToString(string OIAIKKGGJAI, IFormatProvider ODLKCGNNFLG)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class CHNLPCJMDCL<TData> : HFGDJMMINEP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly string OMMMEOELCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly TData LHCDIJPGOMG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
	public override string EFDGLBEJKDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x49D3A70", Offset = "0x49D2870", VA = "0x1849D3A70")]
	internal CHNLPCJMDCL(string EKPMNNKLPFJ, [In] TData HKPHNGEBIED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class APIKGOLCEKL
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x605B280", Offset = "0x605A080", VA = "0x18605B280")]
	public static CHNLPCJMDCL<BCBPFABBCDG> DCPHPAHCOGO(string EKPMNNKLPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x24082C0", Offset = "0x24070C0", VA = "0x1824082C0")]
	public static CHNLPCJMDCL<TData> DCPHPAHCOGO<TData>(string EKPMNNKLPFJ, [In] TData HKPHNGEBIED) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HFPLIOHOBFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<object, float> CIIBEKGMGII;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float HHKGPLBEEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89F230", Offset = "0x89E030", VA = "0x18089F230")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x89F2D0", Offset = "0x89E0D0", VA = "0x18089F2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x605BED0", Offset = "0x605ACD0", VA = "0x18605BED0")]
	public void PPFIDGJABPB(float MBDKMNBCLGF, object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x605BE60", Offset = "0x605AC60", VA = "0x18605BE60")]
	public void JCEEGHPMMAE(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x605BD30", Offset = "0x605AB30", VA = "0x18605BD30")]
	private void IIBFIGMMDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x605BF40", Offset = "0x605AD40", VA = "0x18605BF40")]
	public HFPLIOHOBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class HILEFJNIJPP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class HLMJCFNEOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public HLMJCFNEOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x375A0B0", Offset = "0x3758EB0", VA = "0x18375A0B0")]
		internal int PAFJONHPFAA(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private HashSet<T>? GGAINFECJHA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IReadOnlyCollection<T> MOOANMFLOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x37541E0", Offset = "0x3752FE0", VA = "0x1837541E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool NHMBPCJDDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3754160", Offset = "0x3752F60", VA = "0x183754160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7944A0", Offset = "0x7932A0", VA = "0x1807944A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x794470", Offset = "0x793270", VA = "0x180794470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3753FF0", Offset = "0x3752DF0", VA = "0x183753FF0")]
	public bool EHPBILHDFGD(T CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3753ED0", Offset = "0x3752CD0", VA = "0x183753ED0")]
	public bool CPMMAHJGJAD(T CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x37541A0", Offset = "0x3752FA0", VA = "0x1837541A0")]
	public bool PCLOONMEAJB(T CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3754210", Offset = "0x3753010", VA = "0x183754210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public HILEFJNIJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KKLNGHGCING
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly string NPGCIHGAAFE;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	public KKLNGHGCING(string NPGCIHGAAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x605CB80", Offset = "0x605B980", VA = "0x18605CB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NJMPJPAIPEI
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class MFNFKJKHOLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public MFNFKJKHOLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x605CBD0", Offset = "0x605B9D0", VA = "0x18605CBD0")]
		internal int PAFJONHPFAA(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private HashSet<object>? GGAINFECJHA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<object> MOOANMFLOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x605D1B0", Offset = "0x605BFB0", VA = "0x18605D1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NHMBPCJDDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x605D140", Offset = "0x605BF40", VA = "0x18605D140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7944A0", Offset = "0x7932A0", VA = "0x1807944A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x794470", Offset = "0x793270", VA = "0x180794470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x605D060", Offset = "0x605BE60", VA = "0x18605D060")]
	public bool EHPBILHDFGD(object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x605CF50", Offset = "0x605BD50", VA = "0x18605CF50")]
	public bool CPMMAHJGJAD(object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x605D150", Offset = "0x605BF50", VA = "0x18605D150")]
	public bool PCLOONMEAJB(object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x605CFF0", Offset = "0x605BDF0", VA = "0x18605CFF0")]
	public void EHJKPAOACEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x605D240", Offset = "0x605C040", VA = "0x18605D240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public NJMPJPAIPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class AALKOAKIONG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct NOHCCGKIJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public float KKHDODLOEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public T AOJPLLHPPML;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Dictionary<object, NOHCCGKIJOF> CIIBEKGMGII;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public virtual T LELCGFJBAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xE35110", Offset = "0xE33F10", VA = "0x180E35110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xE346F0", Offset = "0xE334F0", VA = "0x180E346F0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public object? KKJDBKADHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7944B0", Offset = "0x7932B0", VA = "0x1807944B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool HMPLFKDJHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3678AD0", Offset = "0x36778D0", VA = "0x183678AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x367A570", Offset = "0x3679370", VA = "0x18367A570")]
	public bool PPFIDGJABPB(T MBDKMNBCLGF, object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3678B20", Offset = "0x3677920", VA = "0x183678B20")]
	public bool JCEEGHPMMAE(object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3678F20", Offset = "0x3677D20", VA = "0x183678F20")]
	public void LJNFEICKFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3678CA0", Offset = "0x3677AA0", VA = "0x183678CA0")]
	public bool JPCECNBPLDE(object CGFEMNMBCOK, [Out] T MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x36795C0", Offset = "0x36783C0", VA = "0x1836795C0")]
	[NDCGPKMGJFC("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool NFLKDFBFEFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x367AD70", Offset = "0x3679B70", VA = "0x18367AD70")]
	public AALKOAKIONG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface KMGDMPBOAGL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AEPCDONHNNG LNEPNPDAKKE;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class IHEHCKKCHPO : KMGDMPBOAGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct NDMELEHJPCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly float HKKNIOFHBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly float APJJALPOAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly bool NKGKIMMPNMN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float ELGBHPFJHPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x605CC80", Offset = "0x605BA80", VA = "0x18605CC80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x605CDF0", Offset = "0x605BBF0", VA = "0x18605CDF0")]
		public NDMELEHJPCA(float GMKGLLAPKMM, float KKCAHMFFJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x605CC90", Offset = "0x605BA90", VA = "0x18605CC90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class GFBIKHMHEPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IHEHCKKCHPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public GFBIKHMHEPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x605B430", Offset = "0x605A230", VA = "0x18605B430")]
		internal void HCPDEGNMMJE(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly int IBODGIFCPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int MIKBNMGMKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KMGDMPBOAGL[] BHOCOMGCHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AEPCDONHNNG[] KJKENJAPKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NDMELEHJPCA[] CKGIPAIOBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private NDMELEHJPCA NGELPDLLIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly HLIGACBDBMP DLNNFLMNLHA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event AEPCDONHNNG LNEPNPDAKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x605C2C0", Offset = "0x605B0C0", VA = "0x18605C2C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x605C200", Offset = "0x605B000", VA = "0x18605C200", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x605C990", Offset = "0x605B790", VA = "0x18605C990")]
	public IHEHCKKCHPO(int IBODGIFCPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x605C900", Offset = "0x605B700", VA = "0x18605C900")]
	public HLIGACBDBMP HFBLGKGDOIM(NDMELEHJPCA APNOCEFBELF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x605C380", Offset = "0x605B180", VA = "0x18605C380")]
	public void DOAGKMCGILK(KMGDMPBOAGL OLHCPJCPIOO, [Optional] NDMELEHJPCA ALFHHELFLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x605C7F0", Offset = "0x605B5F0", VA = "0x18605C7F0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public delegate void AEPCDONHNNG(float ADGPIGNCHCN);
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CDOJPHLFGDN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private class GJDEJKBMFAB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly KMGDMPBOAGL PICHFKFKDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly AEPCDONHNNG EAGOMMNFHFH;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x605B520", Offset = "0x605A320", VA = "0x18605B520")]
		public GJDEJKBMFAB(KMGDMPBOAGL PICHFKFKDMO, AEPCDONHNNG EAGOMMNFHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x605B4D0", Offset = "0x605A2D0", VA = "0x18605B4D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x605B300", Offset = "0x605A100", VA = "0x18605B300")]
	internal static bool FBALDOFPONG(float OIPELOMOKGO, float BJNEJGMGENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x604FFB0", Offset = "0x604EDB0", VA = "0x18604FFB0")]
	internal static float FHJGKPHJJKF(float OIPELOMOKGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x605B370", Offset = "0x605A170", VA = "0x18605B370")]
	public static IDisposable IDMPDBHBBFF(this KMGDMPBOAGL PICHFKFKDMO, AEPCDONHNNG EAGOMMNFHFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HLIGACBDBMP : KMGDMPBOAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float ADGPIGNCHCN;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float FBDKGKLEGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x605C070", Offset = "0x605AE70", VA = "0x18605C070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event AEPCDONHNNG? LNEPNPDAKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x605C160", Offset = "0x605AF60", VA = "0x18605C160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x605BFD0", Offset = "0x605ADD0", VA = "0x18605BFD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public HLIGACBDBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class PDPICNFMANO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B82570", Offset = "0x5B81370", VA = "0x185B82570")]
	public PDPICNFMANO(string EKPMNNKLPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DefaultMember("Item")]
public class JHEEMONNKGO<TKey, TValue> : OFINJBEEPJJ<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, LLJAFEELNOK where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class DKOJDJKCJID : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JHEEMONNKGO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xE35110", Offset = "0xE33F10", VA = "0x180E35110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4F651B0", Offset = "0x4F63FB0", VA = "0x184F651B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public DKOJDJKCJID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x34BE310", Offset = "0x34BD110", VA = "0x1834BE310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4F64490", Offset = "0x4F63290", VA = "0x184F64490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4F64440", Offset = "0x4F63240", VA = "0x184F64440")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4F64FD0", Offset = "0x4F63DD0", VA = "0x184F64FD0")]
		private void PDOLPCEBNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4F650C0", Offset = "0x4F63EC0", VA = "0x184F650C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly OFINJBEEPJJ<TKey, TValue> LGLHDOOAAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly IDictionary<TKey, TValue> KMIHPJAMHCJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x39B70F0", Offset = "0x39B5EF0", VA = "0x1839B70F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CEHPCHNOICL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TValue CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x39B7390", Offset = "0x39B6190", VA = "0x1839B7390", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x39B7610", Offset = "0x39B6410", VA = "0x1839B7610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ICollection<TKey> BFFKJKEDGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x39B73D0", Offset = "0x39B61D0", VA = "0x1839B73D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ICollection<TValue> LBJKKGJMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x39B74E0", Offset = "0x39B62E0", VA = "0x1839B74E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x39B7040", Offset = "0x39B5E40", VA = "0x1839B7040")]
	public JHEEMONNKGO(OFINJBEEPJJ<TKey, TValue> LGLHDOOAAKE, [Optional] IDictionary<TKey, TValue>? KMIHPJAMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x39B4A10", Offset = "0x39B3810", VA = "0x1839B4A10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x39B63A0", Offset = "0x39B51A0", VA = "0x1839B63A0")]
	public void PCOHMLGOBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x39B46A0", Offset = "0x39B34A0", VA = "0x1839B46A0", Slot = "9")]
	public void Add(TKey IDGIKKEFDCG, TValue MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x39B5510", Offset = "0x39B4310", VA = "0x1839B5510")]
	public void JOAIEDMKKFL(TKey IDGIKKEFDCG, TValue MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x39B61F0", Offset = "0x39B4FF0", VA = "0x1839B61F0")]
	public void OJBKLAIGOMH(TKey IDGIKKEFDCG, TValue MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x39B5EE0", Offset = "0x39B4CE0", VA = "0x1839B5EE0")]
	public void OBELPMKOKAI(TKey IDGIKKEFDCG, TValue MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x39B5AD0", Offset = "0x39B48D0", VA = "0x1839B5AD0")]
	public void LAGNILKJKJL(TKey IDGIKKEFDCG, TValue MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x39B6660", Offset = "0x39B5460", VA = "0x1839B6660", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> KMBHPJEIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x39B6860", Offset = "0x39B5660", VA = "0x1839B6860", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x39B6BC0", Offset = "0x39B59C0", VA = "0x1839B6BC0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x39B4A80", Offset = "0x39B3880", VA = "0x1839B4A80", Slot = "8")]
	public bool ContainsKey(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x39B4420", Offset = "0x39B3220", VA = "0x1839B4420")]
	public bool ADDBBBLDJII(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x39B5440", Offset = "0x39B4240", VA = "0x1839B5440")]
	public bool HIDKBLKBJNL(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x39B64B0", Offset = "0x39B52B0", VA = "0x1839B64B0", Slot = "10")]
	public bool Remove(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x39B6DB0", Offset = "0x39B5BB0", VA = "0x1839B6DB0", Slot = "11")]
	public bool TryGetValue(TKey IDGIKKEFDCG, [Out] TValue MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x39B5070", Offset = "0x39B3E70", VA = "0x1839B5070", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] IPODKPLEDFE, int BKFPMJOKOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x39B6D80", Offset = "0x39B5B80", VA = "0x1839B6D80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x39B5350", Offset = "0x39B4150", VA = "0x1839B5350", Slot = "19")]
	[IteratorStateMachine(typeof(JHEEMONNKGO<, >.DKOJDJKCJID))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x39B5B70", Offset = "0x39B4970", VA = "0x1839B5B70", Slot = "21")]
	public bool LANENDJCPJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x39B5880", Offset = "0x39B4680", VA = "0x1839B5880")]
	private TValue JPHBLFHBLGO(TKey IDGIKKEFDCG)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LLJAFEELNOK
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LANENDJCPJD();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OFINJBEEPJJ<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LLJAFEELNOK
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DefaultMember("Item")]
public sealed class EODJEADNCOB<TKey, TVal> : OFINJBEEPJJ<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LLJAFEELNOK where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate int IGOFPDBOOID(TKey IDGIKKEFDCG, TVal MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class ALDLNNJGGCN
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public TKey OFBDILANEMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xB5EDE0", Offset = "0xB5DBE0", VA = "0x180B5EDE0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TVal AOJPLLHPPML
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BDDC0", VA = "0x1808BEFC0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8BEFA0", Offset = "0x8BDDA0", VA = "0x1808BEFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int ELGBHPFJHPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7CD3E0", Offset = "0x7CC1E0", VA = "0x1807CD3E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7CC820", Offset = "0x7CB620", VA = "0x1807CC820")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DateTimeOffset MJLFIOAKGDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA302F0", Offset = "0xA2F0F0", VA = "0x180A302F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x128B070", Offset = "0x1289E70", VA = "0x18128B070")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x36AEBA0", Offset = "0x36AD9A0", VA = "0x1836AEBA0")]
		public ALDLNNJGGCN(TKey IDGIKKEFDCG, TVal AJHKDPJBHMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class FAHENFBGBLI : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public EODJEADNCOB<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private LinkedList<ALDLNNJGGCN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xE35110", Offset = "0xE33F10", VA = "0x180E35110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x35D7130", Offset = "0x35D5F30", VA = "0x1835D7130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7933A0", Offset = "0x7921A0", VA = "0x1807933A0")]
		[DebuggerHidden]
		public FAHENFBGBLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3368F90", Offset = "0x3367D90", VA = "0x183368F90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x35D6DF0", Offset = "0x35D5BF0", VA = "0x1835D6DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x35D6DD0", Offset = "0x35D5BD0", VA = "0x1835D6DD0")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x35D70E0", Offset = "0x35D5EE0", VA = "0x1835D70E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int HKIPALICMCM = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<TKey, LinkedListNode<ALDLNNJGGCN>> KEBGCBDIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly LinkedList<ALDLNNJGGCN> KBDMAMBLDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly IGOFPDBOOID? PGLPOBPDFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly TimeSpan NEJAHFKIDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly JLHLIMBBEGG JIOLLFEEFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool FKEGGOJCBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly List<TKey> ACJDDFOOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<TVal> LHEMDBKEIKH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int ELBHIJPAFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC440", Offset = "0x7AB240", VA = "0x1807AC440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	internal int ACBDJFHAFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC450", Offset = "0x7AB250", VA = "0x1807AC450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xE26AB0", Offset = "0xE258B0", VA = "0x180E26AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3294790", Offset = "0x3293590", VA = "0x183294790", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	internal int AOBGMDMIJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x328D880", Offset = "0x328C680", VA = "0x18328D880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICollection<TVal> LBJKKGJMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x32948C0", Offset = "0x32936C0", VA = "0x1832948C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ICollection<TKey> IDictionary<TKey, TVal>.AFHNJGGABGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3290480", Offset = "0x328F280", VA = "0x183290480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CEHPCHNOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public TVal CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3294820", Offset = "0x3293620", VA = "0x183294820", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3294910", Offset = "0x3293710", VA = "0x183294910", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x328D830", Offset = "0x328C630", VA = "0x18328D830")]
	private bool PDGDEAGACOJ(int IBODGIFCPFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x328AB50", Offset = "0x3289950", VA = "0x18328AB50")]
	private void GINHNOABNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x32942D0", Offset = "0x32930D0", VA = "0x1832942D0")]
	public EODJEADNCOB(int IBODGIFCPFK, [Optional] IGOFPDBOOID? PGLPOBPDFKN, [Optional] IEqualityComparer<TKey>? OFOIBJDIOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x32912D0", Offset = "0x32900D0", VA = "0x1832912D0")]
	public EODJEADNCOB(TimeSpan NEJAHFKIDAB, [Optional] IEqualityComparer<TKey>? OFOIBJDIOEM, [Optional] JLHLIMBBEGG? JIOLLFEEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3291310", Offset = "0x3290110", VA = "0x183291310")]
	public EODJEADNCOB(int IBODGIFCPFK, TimeSpan NEJAHFKIDAB, [Optional] IEqualityComparer<TKey>? OFOIBJDIOEM, [Optional] JLHLIMBBEGG? JIOLLFEEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3291810", Offset = "0x3290610", VA = "0x183291810")]
	public EODJEADNCOB(int IBODGIFCPFK, IGOFPDBOOID? PGLPOBPDFKN, TimeSpan NEJAHFKIDAB, [Optional] IEqualityComparer<TKey>? OFOIBJDIOEM, [Optional] JLHLIMBBEGG? JIOLLFEEFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x328B1E0", Offset = "0x3289FE0", VA = "0x18328B1E0", Slot = "21")]
	public bool LANENDJCPJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x328A510", Offset = "0x3289310", VA = "0x18328A510", Slot = "22")]
	public bool GADBIOIGLJN(int GENDLFFGOMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3287390", Offset = "0x3286190", VA = "0x183287390")]
	private bool EADNIPCAKJG(int GENDLFFGOMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3284920", Offset = "0x3283720", VA = "0x183284920")]
	public void COLNBMOOCNM(TKey IDGIKKEFDCG, TVal MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x32836F0", Offset = "0x32824F0", VA = "0x1832836F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KMBHPJEIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3283850", Offset = "0x3282650", VA = "0x183283850", Slot = "9")]
	public void Add(TKey IDGIKKEFDCG, TVal MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3284D20", Offset = "0x3283B20", VA = "0x183284D20", Slot = "8")]
	public bool ContainsKey(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x328F860", Offset = "0x328E660", VA = "0x18328F860", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x328F7E0", Offset = "0x328E5E0", VA = "0x18328F7E0", Slot = "10")]
	public bool Remove(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x328FEC0", Offset = "0x328ECC0", VA = "0x18328FEC0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x328D160", Offset = "0x328BF60", VA = "0x18328D160")]
	private bool PAGDEKCFJJN(TKey IDGIKKEFDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x328B900", Offset = "0x328A700", VA = "0x18328B900")]
	private TVal NAKCAFGMIJA(TKey JPBAKCAAHEF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3291110", Offset = "0x328FF10", VA = "0x183291110", Slot = "11")]
	public bool TryGetValue(TKey JPBAKCAAHEF, [Out] TVal MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3284C90", Offset = "0x3283A90", VA = "0x183284C90", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3286310", Offset = "0x3285110", VA = "0x183286310", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IPODKPLEDFE, int BKFPMJOKOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3282F70", Offset = "0x3281D70", VA = "0x183282F70")]
	private bool ALDFHOKFCEJ(ALDLNNJGGCN IIPEKCHFNGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x32899A0", Offset = "0x32887A0", VA = "0x1832899A0")]
	private void EMFIKAJGLPI(LinkedListNode<ALDLNNJGGCN> KFNIDJOEGOF, TVal JKNLOGKCBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x328E0D0", Offset = "0x328CED0", VA = "0x18328E0D0")]
	private void PPFIDGJABPB(TKey IDGIKKEFDCG, TVal MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x328BCC0", Offset = "0x328AAC0", VA = "0x18328BCC0")]
	private void NAMCNOHDMKE(ALDLNNJGGCN IIPEKCHFNGM, TVal JKNLOGKCBLL, int BKOECBHHAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x328B030", Offset = "0x3289E30", VA = "0x18328B030", Slot = "19")]
	[IteratorStateMachine(typeof(EODJEADNCOB<, >.FAHENFBGBLI))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x32904B0", Offset = "0x328F2B0", VA = "0x1832904B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class EHIIAPOADBL<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class DONOBEDADDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public EHIIAPOADBL<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public DONOBEDADDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4F76B90", Offset = "0x4F75990", VA = "0x184F76B90")]
		internal Task<TResource> AJMKKLDOPKL(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct FBNEHFJCFLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x35DC9D0", Offset = "0x35DB7D0", VA = "0x1835DC9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x35DD010", Offset = "0x35DBE10", VA = "0x1835DD010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct IPBFHMLGHCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x381F4E0", Offset = "0x381E2E0", VA = "0x18381F4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x381FA60", Offset = "0x381E860", VA = "0x18381FA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly JEKEGBCNFDB<TId, Task<TResource>> GIENLJOHOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> FHMNPNOCPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? OFBLCGFGDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Action<TResource>? PDCIFOKPCBA;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3247470", Offset = "0x3246270", VA = "0x183247470")]
	public EHIIAPOADBL(int OMLLNNICHGP = 0, [Optional] IEqualityComparer<TId>? LBBGIPOMAAD, [Optional] Func<TId, CancellationToken, Task<TResource>>? DMOGGMHDDMP, [Optional] Action<TResource>? IJKPNNMHOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3246A30", Offset = "0x3245830", VA = "0x183246A30")]
	public HPJIADMGLDJ<Task<TResource>> JICIKCCCMKJ(TId JDEPDKNELPP, [Optional] Func<TId, CancellationToken, Task<TResource>>? DMOGGMHDDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3246E00", Offset = "0x3245C00", VA = "0x183246E00")]
	private void JPKCFIJNBHD(Task<TResource> LBLAAGGIDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x32466A0", Offset = "0x32454A0", VA = "0x1832466A0")]
	public void GFIHOBMNLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3246630", Offset = "0x3245430", VA = "0x183246630")]
	public JEKEGBCNFDB<TId, Task<TResource>>.CFLMPFKLABC BCGCEOCJJAB()
	{
		return default(JEKEGBCNFDB<TId, Task<TResource>>.CFLMPFKLABC);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x32473D0", Offset = "0x32461D0", VA = "0x1832473D0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x32473D0", Offset = "0x32461D0", VA = "0x1832473D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3247170", Offset = "0x3245F70", VA = "0x183247170")]
	[AsyncStateMachine(typeof(EHIIAPOADBL<, >.FBNEHFJCFLH))]
	[CompilerGenerated]
	internal static Task OGLHGBLEMCK(Task<TResource> LBLAAGGIDIG, CancellationTokenSource BMBOFIMEBLJ, Dictionary<Task<TResource>, CancellationTokenSource> HGCNEJIBGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3246220", Offset = "0x3245020", VA = "0x183246220")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(EHIIAPOADBL<, >.IPBFHMLGHCC))]
	internal static Task AJEADOOGHOC(Task<TResource> LBLAAGGIDIG, Action<TResource> PCNMBAGJMHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class JEKEGBCNFDB<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class JIOLNMJJPIF : IEquatable<JIOLNMJJPIF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TValue AOJPLLHPPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int CJABHNLBCOL;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1BAD5D0", Offset = "0x1BAC3D0", VA = "0x181BAD5D0")]
		public JIOLNMJJPIF(TValue MBDKMNBCLGF, int HAGKCACINHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3A03AF0", Offset = "0x3A028F0", VA = "0x183A03AF0", Slot = "4")]
		public bool Equals(JIOLNMJJPIF? GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3A03A50", Offset = "0x3A02850", VA = "0x183A03A50", Slot = "0")]
		public override bool Equals(object? FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3A03C10", Offset = "0x3A02A10", VA = "0x183A03C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct CFLMPFKLABC : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Dictionary<TKey, JIOLNMJJPIF>.Enumerator GCMNODHKOEF;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x47FF340", Offset = "0x47FE140", VA = "0x1847FF340", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TKey Key, TValue Value, int RefCount) GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x47FF780", Offset = "0x47FE580", VA = "0x1847FF780", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x47FF530", Offset = "0x47FE330", VA = "0x1847FF530")]
		public CFLMPFKLABC(JEKEGBCNFDB<TKey, TValue> CIIBEKGMGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x47FF030", Offset = "0x47FDE30", VA = "0x1847FF030", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x47FF0B0", Offset = "0x47FDEB0", VA = "0x1847FF0B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x47FF130", Offset = "0x47FDF30", VA = "0x1847FF130", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class KHNIDDNDIOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JEKEGBCNFDB<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JIOLNMJJPIF refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public KHNIDDNDIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3AA3140", Offset = "0x3AA1F40", VA = "0x183AA3140")]
		internal void AJMKKLDOPKL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<TKey, JIOLNMJJPIF> OBBJKGOLBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Func<TKey, TValue>? DIKLPGKHKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Action<TValue>? FDELKCMIEOP;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x39AB1E0", Offset = "0x39A9FE0", VA = "0x1839AB1E0")]
	public JEKEGBCNFDB(int OMLLNNICHGP = 0, [Optional] IEqualityComparer<TKey>? OFOIBJDIOEM, [Optional] Func<TKey, TValue>? ELNOMODBONG, [Optional] Action<TValue>? AFPKLIHONID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x39AAA90", Offset = "0x39A9890", VA = "0x1839AAA90")]
	public HPJIADMGLDJ<TValue> JICIKCCCMKJ(TKey IDGIKKEFDCG, [Optional] Func<TKey, TValue>? DFAPKAKPLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x39A9EF0", Offset = "0x39A8CF0", VA = "0x1839A9EF0")]
	private void ENHCKFGAJIO(TKey IDGIKKEFDCG, JIOLNMJJPIF IDEDOBDONAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x39AA1E0", Offset = "0x39A8FE0", VA = "0x1839AA1E0")]
	public void GFIHOBMNLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x39A9EB0", Offset = "0x39A8CB0", VA = "0x1839A9EB0")]
	public CFLMPFKLABC BCGCEOCJJAB()
	{
		return default(CFLMPFKLABC);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x39AB140", Offset = "0x39A9F40", VA = "0x1839AB140", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x39AB140", Offset = "0x39A9F40", VA = "0x1839AB140", Slot = "5")]
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
