using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDB20", Offset = "0x7DBCD20", VA = "0x187DBDB20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class OLPGLIMPMOB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected OLPGLIMPMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class MPIIBDIJAGE<T> : OLPGLIMPMOB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct EGDOCFNJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum HADECCACHDK
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
		public HADECCACHDK GDHKDBJPDLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T CJLPDLONOLK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int NLLPDEHOFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool IGOLJCDPEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KMHBEDHJFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? JFDMJHDGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<EGDOCFNJMAE>? BPMLDHDFCNH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IEGKFLCDPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5432CB0", Offset = "0x5431EB0", VA = "0x185432CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5433390", Offset = "0x5432590", VA = "0x185433390")]
	protected MPIIBDIJAGE(bool KMHBEDHJFJI, bool IGOLJCDPEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5432D00", Offset = "0x5431F00", VA = "0x185432D00")]
	protected bool IIPHNDKOEIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5432F70", Offset = "0x5432170", VA = "0x185432F70")]
	protected void OJIEPFMIBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5432AE0", Offset = "0x5431CE0", VA = "0x185432AE0")]
	protected void DOCNPCLAIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4167370", Offset = "0x4166570", VA = "0x184167370")]
	private static void DDBLPGMEEMO<U>(List<U>? CFFEIIKPOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5432DA0", Offset = "0x5431FA0", VA = "0x185432DA0", Slot = "4")]
	public void LHOMNBOIMGH(T CJLPDLONOLK, bool DDKOLNMIKCA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x54331E0", Offset = "0x54323E0", VA = "0x1854331E0", Slot = "5")]
	public void PKCJOLGDFLO(T CJLPDLONOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5433070", Offset = "0x5432270", VA = "0x185433070")]
	public void OLKFAGPLGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EPHHEFDKGKL : MPIIBDIJAGE<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCDA0", Offset = "0x7DBBFA0", VA = "0x187DBCDA0")]
	public EPHHEFDKGKL(bool KMHBEDHJFJI = false, bool IGOLJCDPEHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCAE0", Offset = "0x7DBBCE0", VA = "0x187DBCAE0")]
	public void CLNGLIDPKMF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCD40", Offset = "0x7DBBF40", VA = "0x187DBCD40")]
	public static EPHHEFDKGKL LENAEAOFHNO(EPHHEFDKGKL COMOALCKFMN, Action CJLPDLONOLK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCCE0", Offset = "0x7DBBEE0", VA = "0x187DBCCE0")]
	public static EPHHEFDKGKL IHAOHEBBBJC(EPHHEFDKGKL COMOALCKFMN, Action CJLPDLONOLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LIGGKCPBEJC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHOMNBOIMGH(Action<T> CJLPDLONOLK, bool DDKOLNMIKCA = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKCJOLGDFLO(Action<T> CJLPDLONOLK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KFOHPPMEALH<T> : MPIIBDIJAGE<Action<T>>, LIGGKCPBEJC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4657950", Offset = "0x4656B50", VA = "0x184657950")]
	public KFOHPPMEALH(bool KMHBEDHJFJI = false, bool IGOLJCDPEHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x512D850", Offset = "0x512CA50", VA = "0x18512D850")]
	public void CLNGLIDPKMF(T DACBPJEFOKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x46578C0", Offset = "0x4656AC0", VA = "0x1846578C0")]
	public static KFOHPPMEALH<T> LENAEAOFHNO(KFOHPPMEALH<T> COMOALCKFMN, Action<T> CJLPDLONOLK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4657830", Offset = "0x4656A30", VA = "0x184657830")]
	public static KFOHPPMEALH<T> IHAOHEBBBJC(KFOHPPMEALH<T> COMOALCKFMN, Action<T> CJLPDLONOLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PHPJIGGIEBC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHOMNBOIMGH(Action<T, U> CJLPDLONOLK, bool DDKOLNMIKCA = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKCJOLGDFLO(Action<T, U> CJLPDLONOLK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class LDFPLGIGGEB<T, U> : MPIIBDIJAGE<Action<T, U>>, PHPJIGGIEBC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4657950", Offset = "0x4656B50", VA = "0x184657950")]
	public LDFPLGIGGEB(bool KMHBEDHJFJI = false, bool IGOLJCDPEHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51F3DD0", Offset = "0x51F2FD0", VA = "0x1851F3DD0")]
	public void CLNGLIDPKMF(T DACBPJEFOKJ, U ANKOEGMGKFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x46578C0", Offset = "0x4656AC0", VA = "0x1846578C0")]
	public static LDFPLGIGGEB<T, U> LENAEAOFHNO(LDFPLGIGGEB<T, U> COMOALCKFMN, Action<T, U> CJLPDLONOLK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4657830", Offset = "0x4656A30", VA = "0x184657830")]
	public static LDFPLGIGGEB<T, U> IHAOHEBBBJC(LDFPLGIGGEB<T, U> COMOALCKFMN, Action<T, U> CJLPDLONOLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NDONKLDDPDL<T, U, V> : MPIIBDIJAGE<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4657950", Offset = "0x4656B50", VA = "0x184657950")]
	public NDONKLDDPDL(bool KMHBEDHJFJI = false, bool IGOLJCDPEHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x547ADC0", Offset = "0x5479FC0", VA = "0x18547ADC0")]
	public void CLNGLIDPKMF(T DACBPJEFOKJ, U ANKOEGMGKFF, V JIKDBGFICJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x46578C0", Offset = "0x4656AC0", VA = "0x1846578C0")]
	public static NDONKLDDPDL<T, U, V> LENAEAOFHNO(NDONKLDDPDL<T, U, V> COMOALCKFMN, Action<T, U, V> CJLPDLONOLK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4657830", Offset = "0x4656A30", VA = "0x184657830")]
	public static NDONKLDDPDL<T, U, V> IHAOHEBBBJC(NDONKLDDPDL<T, U, V> COMOALCKFMN, Action<T, U, V> CJLPDLONOLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CHJMHLLHFNO<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HHNBGDJFGFO<T, U, V, W> : MPIIBDIJAGE<Action<T, U, V, W>>, CHJMHLLHFNO<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4657950", Offset = "0x4656B50", VA = "0x184657950")]
	public HHNBGDJFGFO(bool KMHBEDHJFJI = false, bool IGOLJCDPEHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4CA60B0", Offset = "0x4CA52B0", VA = "0x184CA60B0")]
	public void CLNGLIDPKMF(T DACBPJEFOKJ, U ANKOEGMGKFF, V JIKDBGFICJD, W MPPBNBGNIHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x46578C0", Offset = "0x4656AC0", VA = "0x1846578C0")]
	public static HHNBGDJFGFO<T, U, V, W> LENAEAOFHNO(HHNBGDJFGFO<T, U, V, W> COMOALCKFMN, Action<T, U, V, W> CJLPDLONOLK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4657830", Offset = "0x4656A30", VA = "0x184657830")]
	public static HHNBGDJFGFO<T, U, V, W> IHAOHEBBBJC(HHNBGDJFGFO<T, U, V, W> COMOALCKFMN, Action<T, U, V, W> CJLPDLONOLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class EAAELPJDMAB<T, U, V, W, X> : MPIIBDIJAGE<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4657950", Offset = "0x4656B50", VA = "0x184657950")]
	public EAAELPJDMAB(bool KMHBEDHJFJI = false, bool IGOLJCDPEHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4657070", Offset = "0x4656270", VA = "0x184657070")]
	public void CLNGLIDPKMF(T DACBPJEFOKJ, U ANKOEGMGKFF, V JIKDBGFICJD, W MPPBNBGNIHH, X HGCMPGNMMIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46578C0", Offset = "0x4656AC0", VA = "0x1846578C0")]
	public static EAAELPJDMAB<T, U, V, W, X> LENAEAOFHNO(EAAELPJDMAB<T, U, V, W, X> COMOALCKFMN, Action<T, U, V, W, X> CJLPDLONOLK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4657830", Offset = "0x4656A30", VA = "0x184657830")]
	public static EAAELPJDMAB<T, U, V, W, X> IHAOHEBBBJC(EAAELPJDMAB<T, U, V, W, X> COMOALCKFMN, Action<T, U, V, W, X> CJLPDLONOLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OICPJJPCLEG<T, U, V, W, X, Y> : MPIIBDIJAGE<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4657950", Offset = "0x4656B50", VA = "0x184657950")]
	public OICPJJPCLEG(bool KMHBEDHJFJI = false, bool IGOLJCDPEHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x561AD60", Offset = "0x5619F60", VA = "0x18561AD60")]
	public void CLNGLIDPKMF(T DACBPJEFOKJ, U ANKOEGMGKFF, V JIKDBGFICJD, W MPPBNBGNIHH, X HGCMPGNMMIB, Y PIALGICKFLK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x46578C0", Offset = "0x4656AC0", VA = "0x1846578C0")]
	public static OICPJJPCLEG<T, U, V, W, X, Y> LENAEAOFHNO(OICPJJPCLEG<T, U, V, W, X, Y> COMOALCKFMN, Action<T, U, V, W, X, Y> CJLPDLONOLK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4657830", Offset = "0x4656A30", VA = "0x184657830")]
	public static OICPJJPCLEG<T, U, V, W, X, Y> IHAOHEBBBJC(OICPJJPCLEG<T, U, V, W, X, Y> COMOALCKFMN, Action<T, U, V, W, X, Y> CJLPDLONOLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FJNGFEABEMJ<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EIDHCHLOOHL<TKey, TVal> PNMGFDDNNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> IFPDJHFDNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EIDHCHLOOHL<TKey, TVal>.GMONEOCEECC? JBDKCHKDIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int LPBBHAEONDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EIDHCHLOOHL<TKey, TVal>.ILHBAGOCGAN? MJKCFGIONLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int HLCDAIOHGFK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int HEKLCFHOJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4B39BD0", Offset = "0x4B38DD0", VA = "0x184B39BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BFJKGNBMPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA036F0", Offset = "0xA028F0", VA = "0x180A036F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B3A680", Offset = "0x4B39880", VA = "0x184B3A680")]
	public FJNGFEABEMJ(int LPBBHAEONDD, [Optional] EIDHCHLOOHL<TKey, TVal>.ILHBAGOCGAN? MJKCFGIONLL, [Optional] IEqualityComparer<TKey>? AJFGDBOEIKD, [Optional] EIDHCHLOOHL<TKey, TVal>.GMONEOCEECC? JBDKCHKDIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4B39C10", Offset = "0x4B38E10", VA = "0x184B39C10")]
	public void MFDNCIEJGNP(TKey MHDODBCCAJB, TVal KJIOHKMJAPE, bool NDJJIJNCLJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4B39AB0", Offset = "0x4B38CB0", VA = "0x184B39AB0")]
	public bool HKLKHMJCBJD(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4B397E0", Offset = "0x4B389E0", VA = "0x184B397E0")]
	public bool FBLKJFCBGPJ(TKey LMBJOMEGNFK, [Out] TVal KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4B39DC0", Offset = "0x4B38FC0", VA = "0x184B39DC0")]
	private void NFIKDAOMNPA(TKey MHDODBCCAJB, TVal KJIOHKMJAPE, int GCFCAGDGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4B39FF0", Offset = "0x4B391F0", VA = "0x184B39FF0")]
	public bool OAONGFKENJI(TKey MHDODBCCAJB, TVal KJIOHKMJAPE, bool NDJJIJNCLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4B3A620", Offset = "0x4B39820", VA = "0x184B3A620")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4B3A160", Offset = "0x4B39360", VA = "0x184B3A160")]
	private void OJMEFIOKAPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4B398B0", Offset = "0x4B38AB0", VA = "0x184B398B0")]
	private bool GKOJNNIAHFM(TKey MHDODBCCAJB, FFFGGGKPJDD GBBFGBIIOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4B39710", Offset = "0x4B38910", VA = "0x184B39710")]
	private void BMNAHGLHMIH(TKey MHDODBCCAJB, TVal KJIOHKMJAPE, FFFGGGKPJDD GBBFGBIIOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B39990", Offset = "0x4B38B90", VA = "0x184B39990")]
	private void HECINDKDFOE(TKey MHDODBCCAJB, TVal DIPIKNPCGFJ, FFFGGGKPJDD GBBFGBIIOBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MGLLIMJHACP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action FLDOEIHGIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PEEMAMNMBHD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public MGLLIMJHACP(Action KGIAEMKECHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDAE0", Offset = "0x7DBCCE0", VA = "0x187DBDAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2FADC80", Offset = "0x2FACE80", VA = "0x182FADC80")]
	public static MBFLJOFBBPA<T> DBJJOAFKEPP<T>(T KJIOHKMJAPE, Action KGIAEMKECHL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class MBFLJOFBBPA<T> : MGLLIMJHACP where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x53EC570", Offset = "0x53EB770", VA = "0x1853EC570")]
	public MBFLJOFBBPA(T KJIOHKMJAPE, Action KGIAEMKECHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KLCCLOMEJNI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly OHPOHDHEKEB<T>? HJDGBJJEPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> AEEGDFFELNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool PEEMAMNMBHD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly KLCCLOMEJNI<T> BCEMEONNHIA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> JEFNMKBJBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x513EAA0", Offset = "0x513DCA0", VA = "0x18513EAA0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x513EC60", Offset = "0x513DE60", VA = "0x18513EC60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AEOGNGCAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x513E760", Offset = "0x513D960", VA = "0x18513E760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x513F390", Offset = "0x513E590", VA = "0x18513F390")]
	public KLCCLOMEJNI(OHPOHDHEKEB<T> HHBKMHLEKIC, OHPOHDHEKEB<T> NBLCKCDHIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x513F450", Offset = "0x513E650", VA = "0x18513F450")]
	public KLCCLOMEJNI(OHPOHDHEKEB<T> HHBKMHLEKIC, int KOKMPCAPCJD, OHPOHDHEKEB<T> NBLCKCDHIIK, int CFBNBIMCNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x513EF60", Offset = "0x513E160", VA = "0x18513EF60")]
	private KLCCLOMEJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x513E8E0", Offset = "0x513DAE0", VA = "0x18513E8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x513EA00", Offset = "0x513DC00", VA = "0x18513EA00")]
	public T[] LAKGJCBGJBH()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x513ED20", Offset = "0x513DF20", VA = "0x18513ED20")]
	public static ReadOnlySequence<T> PDHAGBEBCNG(KLCCLOMEJNI<T>? DDBGOEIPDPI)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FHEOGKKJAKE<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable NCADABIPGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T LFLEGEJLLKE;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B33200", Offset = "0x4B32400", VA = "0x184B33200")]
	public FHEOGKKJAKE(IDisposable IMMAKBDNFNI, [In] T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B98FD0", Offset = "0x3B981D0", VA = "0x183B98FD0")]
	public static FHEOGKKJAKE<U> AJKHFOHAKMC<U>([In] FHEOGKKJAKE<T> IMMAKBDNFNI, [In] U KJIOHKMJAPE) where U : notnull
	{
		return default(FHEOGKKJAKE<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4B33080", Offset = "0x4B32280", VA = "0x184B33080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HBIPMINGIPI
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A19CF0", Offset = "0x3A18EF0", VA = "0x183A19CF0")]
	public static FHEOGKKJAKE<T> FAHGDJGLLGD<T>(IDisposable IMMAKBDNFNI, [In] T KJIOHKMJAPE) where T : notnull
	{
		return default(FHEOGKKJAKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A19D50", Offset = "0x3A18F50", VA = "0x183A19D50")]
	public static FHEOGKKJAKE<T> IIBFNJEKGKB<T>([In] this FHEOGKKJAKE<T> IPOCHJJJBCM, [Out] T KJIOHKMJAPE) where T : notnull
	{
		return default(FHEOGKKJAKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3789BF0", Offset = "0x3788DF0", VA = "0x183789BF0")]
	public static FHEOGKKJAKE<U?> AJKHFOHAKMC<U, T>([In] FHEOGKKJAKE<T> KCICANDNEOK, [In] U KJIOHKMJAPE)
	{
		return default(FHEOGKKJAKE<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct AIBGEOBFMGI : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct KACKHFGAIGF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
		public static KACKHFGAIGF FAHGDJGLLGD()
		{
			return default(KACKHFGAIGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DBA8C0", Offset = "0x7DB9AC0", VA = "0x187DBA8C0")]
	public static string DKLCPDDPEGM(Type GDHKDBJPDLG, [Optional] string? APEAHOLOGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6A20", Offset = "0x2FA5C20", VA = "0x182FA6A20")]
	public static string? DKLCPDDPEGM<T>([Optional] string? APEAHOLOGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6AA0", Offset = "0x2FA5CA0", VA = "0x182FA6AA0")]
	public static string? PBILLJNMNDE<T>([Optional] string? DPFEAJCDCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
	public static AIBGEOBFMGI DELEFIJNGAA(string APEAHOLOGCB, string? DPFEAJCDCJI)
	{
		return default(AIBGEOBFMGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EDAIBIHNMDK
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool BLOAODAEPFC(string BJKLEMIGJMK, EDAIBIHNMDK BBMJFODLBHB);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class LNLBDJAJAEJ<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LNLBDJAJAEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x522EBB0", Offset = "0x522DDB0", VA = "0x18522EBB0")]
		internal void FCEDMJCPHIC(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int GDKPICOHMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string GLLKEAMLBHM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC2B0", Offset = "0x7DBB4B0", VA = "0x187DBC2B0")]
	public static Dictionary<string, EDAIBIHNMDK> KPGDKEBOGLF(Type MFFKACCIKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3884110", Offset = "0x3883310", VA = "0x183884110")]
	public static Dictionary<string, EDAIBIHNMDK> KPGDKEBOGLF<T>(Type MFFKACCIKFM, IReadOnlyDictionary<T, string> FIDJBIMOOIJ) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3884940", Offset = "0x3883B40", VA = "0x183884940")]
	public static Dictionary<string, EDAIBIHNMDK> NJCIJKMFJHG<T>(List<T> LOFNPOCAIEH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC5F0", Offset = "0x7DBB7F0", VA = "0x187DBC5F0")]
	public static Dictionary<string, EDAIBIHNMDK> LGLCGMCHIHG(Type MFFKACCIKFM, BLOAODAEPFC FGGNIJJFDPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC0F0", Offset = "0x7DBB2F0", VA = "0x187DBC0F0")]
	public static Dictionary<int, string> EDMJGPMLOHD(Dictionary<string, EDAIBIHNMDK> MLMPPNLIAEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class DCJPFEGHGPF : JNEBIKAJDEN
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool MOKEFGOCGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? ILJEAHPHOEA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual JNEBIKAJDEN? HBFKINMDCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB1E0", Offset = "0x7DBA3E0", VA = "0x187DBB1E0")]
	protected DCJPFEGHGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string AHCNILBBCDH();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7DBADB0", Offset = "0x7DB9FB0", VA = "0x187DBADB0", Slot = "8")]
	public virtual string DOGHOGGMCGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAE90", Offset = "0x7DBA090", VA = "0x187DBAE90", Slot = "9")]
	public void KEKCAOFDKME(StringBuilder NMDKDPPLMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAE30", Offset = "0x7DBA030", VA = "0x187DBAE30", Slot = "10")]
	public void JCEELHDLFAF(StringBuilder NMDKDPPLMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAB30", Offset = "0x7DB9D30", VA = "0x187DBAB30", Slot = "11")]
	public void AKIEOEFBGNG(StringBuilder NMDKDPPLMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAC50", Offset = "0x7DB9E50", VA = "0x187DBAC50", Slot = "12")]
	public void DJNNJLHEDPL(StringBuilder NMDKDPPLMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB140", Offset = "0x7DBA340", VA = "0x187DBB140")]
	public static void KOCDPANNJEB(StringBuilder NMDKDPPLMFF, string PHCDDDIIGAJ, string DMGKFNEFCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D0BC80", Offset = "0x6D0AE80", VA = "0x186D0BC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EJOJEAIPFIH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBCA80", Offset = "0x7DBBC80", VA = "0x187DBCA80")]
	public EJOJEAIPFIH(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MIIIMPODLEI<TErr> : EJOJEAIPFIH where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr KKKEDLEFMCL;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5421180", Offset = "0x5420380", VA = "0x185421180")]
	private MIIIMPODLEI([In] TErr DIIKKFHFBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x54210C0", Offset = "0x54202C0", VA = "0x1854210C0")]
	public static MIIIMPODLEI<TErr> FAHGDJGLLGD([In] TErr DIIKKFHFBPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KMIBANHBOCA : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm JGOAMKIEOBC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool IMKONJGLLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool JHGBEEBFBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool NLGJMNJNMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD7D0", Offset = "0x7DBC9D0", VA = "0x187DBD7D0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long MILMNOPOIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD840", Offset = "0x7DBCA40", VA = "0x187DBD840", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD8B0", Offset = "0x7DBCAB0", VA = "0x187DBD8B0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD760", Offset = "0x7DBC960", VA = "0x187DBD760")]
	public KMIBANHBOCA(HashAlgorithm JGOAMKIEOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD590", Offset = "0x7DBC790", VA = "0x187DBD590", Slot = "35")]
	public override int Read(byte[] DLBFFDJEFBK, int GJBFKFHLHKP, int OCEHNHGKKJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD730", Offset = "0x7DBC930", VA = "0x187DBD730", Slot = "38")]
	public override void Write(byte[] DLBFFDJEFBK, int GJBFKFHLHKP, int OCEHNHGKKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD630", Offset = "0x7DBC830", VA = "0x187DBD630", Slot = "33")]
	public override long Seek(long GJBFKFHLHKP, SeekOrigin JJNJIAILJKL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD6C0", Offset = "0x7DBC8C0", VA = "0x187DBD6C0", Slot = "34")]
	public override void SetLength(long KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD4C0", Offset = "0x7DBC6C0", VA = "0x187DBD4C0")]
	public byte[] IBADHDKCCFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JNEBIKAJDEN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DOGHOGGMCGC();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AHCNILBBCDH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface JCHOGLGKCJJ<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface IDHMEEHGKBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string KNGFCBKMMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OHPOHDHEKEB<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static OHPOHDHEKEB<T>? FACNJMCJLGH;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object NKMJENDLLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? GONNDLMMIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool PEEMAMNMBHD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OIFFEBPIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xD17AA0", Offset = "0xD16CA0", VA = "0x180D17AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5619BB0", Offset = "0x5618DB0", VA = "0x185619BB0")]
	private static OHPOHDHEKEB<T> EOOHPHFGFLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x561A010", Offset = "0x5619210", VA = "0x18561A010")]
	private static void FPAMIPDBNMM(OHPOHDHEKEB<T> HKJNIGIGOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x464FDA0", Offset = "0x464EFA0", VA = "0x18464FDA0")]
	private OHPOHDHEKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5619240", Offset = "0x5618440", VA = "0x185619240")]
	public static OHPOHDHEKEB<T> DBJJOAFKEPP(ReadOnlyMemory<T> JHMBOBHDCNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56193F0", Offset = "0x56185F0", VA = "0x1856193F0")]
	public static OHPOHDHEKEB<T> DBJJOAFKEPP(IMemoryOwner<T> COOKGOADHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x561A650", Offset = "0x5619850", VA = "0x18561A650")]
	public static void NBMIEDLAKDA(OHPOHDHEKEB<T> HHBKMHLEKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x56199A0", Offset = "0x5618BA0", VA = "0x1856199A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x561A920", Offset = "0x5619B20", VA = "0x18561A920")]
	public OHPOHDHEKEB<T> PECECAOBPHM(IMemoryOwner<T> COOKGOADHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x561A760", Offset = "0x5619960", VA = "0x18561A760")]
	private void NGMGINDPFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x561A550", Offset = "0x5619750", VA = "0x18561A550")]
	private OHPOHDHEKEB<T> GCAFFBDEODN(OHPOHDHEKEB<T> HKJNIGIGOPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JDDJLGPDBKO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD410", Offset = "0x7DBC610", VA = "0x187DBD410")]
	public JDDJLGPDBKO(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GKNNAPIBGHO<TOk> : JDDJLGPDBKO where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk CMBGNNJCNKL;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4C1B540", Offset = "0x4C1A740", VA = "0x184C1B540")]
	private GKNNAPIBGHO([In] TOk KFMPGHABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4C1B420", Offset = "0x4C1A620", VA = "0x184C1B420")]
	public static GKNNAPIBGHO<TOk> FAHGDJGLLGD([In] TOk KFMPGHABHDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DJNAMIFBMIO<TOk, TErr> : IEquatable<DJNAMIFBMIO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> LCEOGKJHNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr KKKEDLEFMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk CMBGNNJCNKL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool PEMGFLEHOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x42195D0", Offset = "0x42187D0", VA = "0x1842195D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool AKCDBPKDODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x42173F0", Offset = "0x42165F0", VA = "0x1842173F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x421AD30", Offset = "0x4219F30", VA = "0x18421AD30")]
	internal DJNAMIFBMIO([In] TErr DIIKKFHFBPG, [In] TOk KFMPGHABHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4219760", Offset = "0x4218960", VA = "0x184219760")]
	public static DJNAMIFBMIO<TOk, TErr> PJGMGCNCFBN([In] TErr DIIKKFHFBPG)
	{
		return default(DJNAMIFBMIO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x42175A0", Offset = "0x42167A0", VA = "0x1842175A0")]
	public static DJNAMIFBMIO<TOk, TErr> DBKABDCJAEL([In] TOk KFMPGHABHDN)
	{
		return default(DJNAMIFBMIO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B92270", Offset = "0x3B91470", VA = "0x183B92270")]
	public DJNAMIFBMIO<TOk?, UErr?> CMOCPPHLNCK<UErr>()
	{
		return default(DJNAMIFBMIO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B94600", Offset = "0x3B93800", VA = "0x183B94600")]
	public DJNAMIFBMIO<UOk?, TErr?> FELEIGLJLFM<UOk>()
	{
		return default(DJNAMIFBMIO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B933D0", Offset = "0x3B925D0", VA = "0x183B933D0")]
	public DJNAMIFBMIO<UOk?, TErr?> FBNNIKHLMGN<UOk>()
	{
		return default(DJNAMIFBMIO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B94820", Offset = "0x3B93A20", VA = "0x183B94820")]
	public DJNAMIFBMIO<TOk?, UErr?> PGDHPDIBJAA<UErr>()
	{
		return default(DJNAMIFBMIO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4217360", Offset = "0x4216560", VA = "0x184217360")]
	public DJNAMIFBMIO<LMEKHMKKIDI, TErr> AMBJPEIIIFM()
	{
		return default(DJNAMIFBMIO<LMEKHMKKIDI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4217B70", Offset = "0x4216D70", VA = "0x184217B70")]
	public static bool EEDHALGLIEL([In] DJNAMIFBMIO<TOk, TErr> KEAFHNNEEAN, [In] DJNAMIFBMIO<TOk, TErr> FNKKBNJEBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4218560", Offset = "0x4217760", VA = "0x184218560", Slot = "4")]
	public bool Equals(DJNAMIFBMIO<TOk, TErr> CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4218620", Offset = "0x4217820", VA = "0x184218620", Slot = "0")]
	public override bool Equals(object CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x42193C0", Offset = "0x42185C0", VA = "0x1842193C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x421A9E0", Offset = "0x4219BE0", VA = "0x18421A9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class CJLNNLNEHPD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct DCBFMFIKPBL<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<DJNAMIFBMIO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<DJNAMIFBMIO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x41FEFD0", Offset = "0x41FE1D0", VA = "0x1841FEFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x41FFED0", Offset = "0x41FF0D0", VA = "0x1841FFED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x37F51F0", Offset = "0x37F43F0", VA = "0x1837F51F0")]
	public static DJNAMIFBMIO<TOk?, TErr?> CMBGNNJCNKL<TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [In] TOk KFMPGHABHDN)
	{
		return default(DJNAMIFBMIO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x37F52C0", Offset = "0x37F44C0", VA = "0x1837F52C0")]
	public static DJNAMIFBMIO<LMEKHMKKIDI, TErr?> CMBGNNJCNKL<TErr>([In] this DJNAMIFBMIO<LMEKHMKKIDI, TErr> IPOCHJJJBCM)
	{
		return default(DJNAMIFBMIO<LMEKHMKKIDI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x37F51F0", Offset = "0x37F43F0", VA = "0x1837F51F0")]
	public static DJNAMIFBMIO<TOk?, TErr?> KKKEDLEFMCL<TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [In] TErr DIIKKFHFBPG)
	{
		return default(DJNAMIFBMIO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x37F8580", Offset = "0x37F7780", VA = "0x1837F8580")]
	public static TOk? NLGBLOMFFIK<TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x37F4F00", Offset = "0x37F4100", VA = "0x1837F4F00")]
	[AsyncStateMachine(typeof(DCBFMFIKPBL<, >))]
	public static Task<TOk?>? AJEOHJEEAPC<TOk, TErr>(this Task<DJNAMIFBMIO<TOk, TErr>> IPOCHJJJBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x37F80E0", Offset = "0x37F72E0", VA = "0x1837F80E0")]
	public static TErr? MPILHFJBAGK<TErr, TOk>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x37F6C50", Offset = "0x37F5E50", VA = "0x1837F6C50")]
	public static bool JBBKMFNHELA<TOk, TErr, UErr, UOk>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [Out] DJNAMIFBMIO<UOk, UErr> ELKHMJCKPAM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x37F6450", Offset = "0x37F5650", VA = "0x1837F6450")]
	public static bool INAHIOKKKHE<TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [Out] TOk KFMPGHABHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x37F8C50", Offset = "0x37F7E50", VA = "0x1837F8C50")]
	public static bool PGIHFLCCFKO<TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [Out][NotNullWhen(true)] TErr DIIKKFHFBPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x37F8380", Offset = "0x37F7580", VA = "0x1837F8380")]
	public static bool NIFPCMBMODK<TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [Out][NotNullWhen(true)] TOk KFMPGHABHDN, [Out][NotNullWhen(false)] TErr DIIKKFHFBPG) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x37F7DD0", Offset = "0x37F6FD0", VA = "0x1837F7DD0")]
	public static bool MHDDJPGFFEK<TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [Out][NotNullWhen(true)] TOk KFMPGHABHDN, [Out] DJNAMIFBMIO<TOk, TErr> ELKHMJCKPAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x37F6A00", Offset = "0x37F5C00", VA = "0x1837F6A00")]
	public static bool JBBKMFNHELA<TOk, TErr, UErr, UOk>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [Out][NotNullWhen(true)] TOk KFMPGHABHDN, [Out] DJNAMIFBMIO<UOk, UErr> ELKHMJCKPAM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x37F60F0", Offset = "0x37F52F0", VA = "0x1837F60F0")]
	public static bool GBBFLHKHGLP<TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [Out][NotNullWhen(true)] TOk KFMPGHABHDN, [Out] DJNAMIFBMIO<LMEKHMKKIDI, TErr> ELKHMJCKPAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37F5700", Offset = "0x37F4900", VA = "0x1837F5700")]
	public static DJNAMIFBMIO<UOk, UErr> FGKNCIICHOD<UOk, UErr, TOk, TErr>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, [In] DJNAMIFBMIO<UOk, UErr> LDINAKFKJDF) where TOk : UOk where TErr : UErr
	{
		return default(DJNAMIFBMIO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37F53C0", Offset = "0x37F45C0", VA = "0x1837F53C0")]
	public static DJNAMIFBMIO<TOk?[]?, TErr?> DLGDJCFBBDG<TOk, TErr>(this IEnumerable<DJNAMIFBMIO<TOk, TErr>> IPOCHJJJBCM)
	{
		return default(DJNAMIFBMIO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x37F7B90", Offset = "0x37F6D90", VA = "0x1837F7B90")]
	public static DJNAMIFBMIO<UOk?, TErr?> KGOKHJEFGHO<UOk, TErr, TOk>([In] this DJNAMIFBMIO<TOk, TErr> IPOCHJJJBCM, Func<TOk, UOk> BHBAPLIKNPE)
	{
		return default(DJNAMIFBMIO<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KKPAKMMKPMC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4105A30", Offset = "0x4104C30", VA = "0x184105A30")]
	public static DJNAMIFBMIO<TOk, T> CMBGNNJCNKL<TOk>([In] TOk KFMPGHABHDN) where TOk : notnull
	{
		return default(DJNAMIFBMIO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x513CF30", Offset = "0x513C130", VA = "0x18513CF30")]
	public static DJNAMIFBMIO<LMEKHMKKIDI, T> CMBGNNJCNKL()
	{
		return default(DJNAMIFBMIO<LMEKHMKKIDI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4105A30", Offset = "0x4104C30", VA = "0x184105A30")]
	public static DJNAMIFBMIO<T, TErr> KKKEDLEFMCL<TErr>([In] TErr DIIKKFHFBPG) where TErr : notnull
	{
		return default(DJNAMIFBMIO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct OKEFCAHFNGA<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly LNDPAJNBFGA NPCCCHLGPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> IGNACDBEHGF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4940", Offset = "0x4DA3B40", VA = "0x184DA4940")]
	public static OKEFCAHFNGA<TKey, TValue> FAHGDJGLLGD(string BKDMJHGCDEA)
	{
		return default(OKEFCAHFNGA<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4AF0", Offset = "0x4DA3CF0", VA = "0x184DA4AF0")]
	internal OKEFCAHFNGA(Dictionary<TKey, TValue> KJIOHKMJAPE, LNDPAJNBFGA IMAPKCENFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4A50", Offset = "0x4DA3C50", VA = "0x184DA4A50")]
	public GCLLJBKCLGF<TKey, TValue> KDBDLHMLMMG([Out] Dictionary<TKey, TValue> KJIOHKMJAPE)
	{
		return default(GCLLJBKCLGF<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct GCLLJBKCLGF<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> IGNACDBEHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EAKEIPAFFBN KJPKMAJHCJJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF180", Offset = "0x2ADE380", VA = "0x182ADF180")]
	internal GCLLJBKCLGF(Dictionary<TKey, TValue> KJIOHKMJAPE, EAKEIPAFFBN EFLIKIJHDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4BF3930", Offset = "0x4BF2B30", VA = "0x184BF3930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct IANGJJBDDHE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly LNDPAJNBFGA NPCCCHLGPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> IGNACDBEHGF;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4940", Offset = "0x4DA3B40", VA = "0x184DA4940")]
	public static IANGJJBDDHE<T> FAHGDJGLLGD(string BKDMJHGCDEA)
	{
		return default(IANGJJBDDHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4AF0", Offset = "0x4DA3CF0", VA = "0x184DA4AF0")]
	internal IANGJJBDDHE(HashSet<T> KJIOHKMJAPE, LNDPAJNBFGA IMAPKCENFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4A50", Offset = "0x4DA3C50", VA = "0x184DA4A50")]
	public KLOCANDFDJH<T> KDBDLHMLMMG([Out] HashSet<T> KJIOHKMJAPE)
	{
		return default(KLOCANDFDJH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KLOCANDFDJH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> IGNACDBEHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EAKEIPAFFBN KJPKMAJHCJJ;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF180", Offset = "0x2ADE380", VA = "0x182ADF180")]
	internal KLOCANDFDJH(HashSet<T> KJIOHKMJAPE, EAKEIPAFFBN EFLIKIJHDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4BF3930", Offset = "0x4BF2B30", VA = "0x184BF3930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct PFFKNOHGGDI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LNDPAJNBFGA NPCCCHLGPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> IGNACDBEHGF;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4940", Offset = "0x4DA3B40", VA = "0x184DA4940")]
	public static PFFKNOHGGDI<T> FAHGDJGLLGD(string BKDMJHGCDEA)
	{
		return default(PFFKNOHGGDI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4DA4AF0", Offset = "0x4DA3CF0", VA = "0x184DA4AF0")]
	internal PFFKNOHGGDI(Stack<T> KJIOHKMJAPE, LNDPAJNBFGA IMAPKCENFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x56E6FA0", Offset = "0x56E61A0", VA = "0x1856E6FA0")]
	public PIPPEOBHFIN<T> KDBDLHMLMMG([Out] Stack<T> KJIOHKMJAPE)
	{
		return default(PIPPEOBHFIN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PIPPEOBHFIN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> IGNACDBEHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EAKEIPAFFBN KJPKMAJHCJJ;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2ADF180", Offset = "0x2ADE380", VA = "0x182ADF180")]
	internal PIPPEOBHFIN(Stack<T> KJIOHKMJAPE, EAKEIPAFFBN EFLIKIJHDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4BF3930", Offset = "0x4BF2B30", VA = "0x184BF3930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class JDFFIDKMPMB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct NEFNBEPLOJP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly JDFFIDKMPMB<T> DPEFBPHMLCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int MEMMEKKOPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool EIFMGGGIPEA;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x27611A0", Offset = "0x27603A0", VA = "0x1827611A0")]
		public NEFNBEPLOJP(JDFFIDKMPMB<T> IBLPGPPBNHF, int EPAFICJBEHH, bool NEEAMGIAEFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x547DA30", Offset = "0x547CC30", VA = "0x18547DA30")]
		public JDFFIDKMPMB<T>.BJLLAAOJCCJ BFKODFEKGDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x547DB10", Offset = "0x547CD10", VA = "0x18547DB10", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x547DB10", Offset = "0x547CD10", VA = "0x18547DB10", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class BJLLAAOJCCJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly JDFFIDKMPMB<T> DPEFBPHMLCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int POBCOMMOMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int BEMFNLKIAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool EIFMGGGIPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool IFIGOIPPMEM;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x61A01E0", Offset = "0x619F3E0", VA = "0x1861A01E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x61A0300", Offset = "0x619F500", VA = "0x1861A0300", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x61A0400", Offset = "0x619F600", VA = "0x1861A0400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61A05C0", Offset = "0x619F7C0", VA = "0x1861A05C0")]
		public BJLLAAOJCCJ(JDFFIDKMPMB<T> IBLPGPPBNHF, int EPAFICJBEHH, bool NEEAMGIAEFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61A0260", Offset = "0x619F460", VA = "0x1861A0260", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61A02E0", Offset = "0x619F4E0", VA = "0x1861A02E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class NDOHLONGIBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public NDOHLONGIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x54791D0", Offset = "0x54783D0", VA = "0x1854791D0")]
		internal T GDFIBKODBPE(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] LAHALOMIBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int BEMFNLKIAHH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HLOBFDDBAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x502B9E0", Offset = "0x502ABE0", VA = "0x18502B9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T FJFNMMOOKII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4B1BCA0", Offset = "0x4B1AEA0", VA = "0x184B1BCA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T DDDBGJONBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x502BA20", Offset = "0x502AC20", VA = "0x18502BA20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x502BB40", Offset = "0x502AD40", VA = "0x18502BB40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x26BE7D0", Offset = "0x26BD9D0", VA = "0x1826BE7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1B73B10", Offset = "0x1B72D10", VA = "0x181B73B10")]
	private static int NCPKFPABHIA(int CMDFFDAPDIB, int CLBDAFJFHFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x502BC90", Offset = "0x502AE90", VA = "0x18502BC90")]
	public JDFFIDKMPMB(int GCFCAGDGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x502BDA0", Offset = "0x502AFA0", VA = "0x18502BDA0")]
	public JDFFIDKMPMB(int GCFCAGDGDIN, Func<T> CGBJBEIHGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x502C180", Offset = "0x502B380", VA = "0x18502C180")]
	public JDFFIDKMPMB(T[] ICAAOCBKPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x502BC60", Offset = "0x502AE60", VA = "0x18502BC60")]
	public void MKDDDMKJENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x502BBA0", Offset = "0x502ADA0", VA = "0x18502BBA0")]
	public IEnumerable<T> MDCCMILHKJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x502B960", Offset = "0x502AB60", VA = "0x18502B960")]
	public JDFFIDKMPMB<T>.BJLLAAOJCCJ BFKODFEKGDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4B21290", Offset = "0x4B20490", VA = "0x184B21290", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B21290", Offset = "0x4B20490", VA = "0x184B21290", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FIMDABMDLPL
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39EBB00", Offset = "0x39EAD00", VA = "0x1839EBB00")]
	public static JDFFIDKMPMB<T> FAHGDJGLLGD<T>(int GCFCAGDGDIN, Func<T> CGBJBEIHGOP) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7DBECC0", Offset = "0x7DBDEC0", VA = "0x187DBECC0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEC80", Offset = "0x7DBDE80", VA = "0x187DBEC80")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7DBECA0", Offset = "0x7DBDEA0", VA = "0x187DBECA0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7DBECE0", Offset = "0x7DBDEE0", VA = "0x187DBECE0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEC60", Offset = "0x7DBDE60", VA = "0x187DBEC60")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28918C0", Offset = "0x2890AC0", VA = "0x1828918C0")]
		public RRColor(float EJNMHOGNAED, float IIOHDNMHIHG, float NIJBGCGEGBN, float BGPKBCGBDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C3E600", Offset = "0x7C3D800", VA = "0x187C3E600", Slot = "4")]
		public bool Equals(RRColor CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE8A0", Offset = "0x7DBDAA0", VA = "0x187DBE8A0", Slot = "0")]
		public override bool Equals(object CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE9A0", Offset = "0x7DBDBA0", VA = "0x187DBE9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEA20", Offset = "0x7DBDC20", VA = "0x187DBEA20", Slot = "5")]
		public string ToString(string LHADPGCGDPB, IFormatProvider FBKDJMLIGDE)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE840", Offset = "0x7DBDA40", VA = "0x187DBE840")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE7E0", Offset = "0x7DBD9E0", VA = "0x187DBE7E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE810", Offset = "0x7DBDA10", VA = "0x187DBE810")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE870", Offset = "0x7DBDA70", VA = "0x187DBE870")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE7B0", Offset = "0x7DBD9B0", VA = "0x187DBE7B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D24F60", Offset = "0x5D24160", VA = "0x185D24F60")]
		public RRColor32(byte EJNMHOGNAED, byte IIOHDNMHIHG, byte NIJBGCGEGBN, byte BGPKBCGBDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2273C90", Offset = "0x2272E90", VA = "0x182273C90", Slot = "4")]
		public bool Equals(RRColor32 CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE2F0", Offset = "0x7DBD4F0", VA = "0x187DBE2F0", Slot = "0")]
		public override bool Equals(object CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x13D8CD0", Offset = "0x13D7ED0", VA = "0x1813D8CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE380", Offset = "0x7DBD580", VA = "0x187DBE380")]
		public static RRColor32 PDHAGBEBCNG(RRColor NAGHCPKAEOP)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE4D0", Offset = "0x7DBD6D0", VA = "0x187DBE4D0")]
		public static RRColor PDHAGBEBCNG(RRColor32 NAGHCPKAEOP)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE540", Offset = "0x7DBD740", VA = "0x187DBE540", Slot = "5")]
		public string ToString(string LHADPGCGDPB, IFormatProvider FBKDJMLIGDE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class KDLBMFPBJPF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct BCKJOINGGJM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly KDLBMFPBJPF<T> GACDOEDIFFL;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T LFLEGEJLLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x597D330", Offset = "0x597C530", VA = "0x18597D330")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x60BE890", Offset = "0x60BDA90", VA = "0x1860BE890", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
		public BCKJOINGGJM(KDLBMFPBJPF<T> GACDOEDIFFL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct HGCNOKNOBBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<BCKJOINGGJM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public KDLBMFPBJPF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4CA2A70", Offset = "0x4CA1C70", VA = "0x184CA2A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x46828B0", Offset = "0x4681AB0", VA = "0x1846828B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim IEAPIILCFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T PHFFEPFKKME;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x512A200", Offset = "0x5129400", VA = "0x18512A200")]
	public KDLBMFPBJPF([In] T PHFFEPFKKME, int FOIJGOAPJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x512A1E0", Offset = "0x51293E0", VA = "0x18512A1E0")]
	public KDLBMFPBJPF([In] T PHFFEPFKKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5129D00", Offset = "0x5128F00", VA = "0x185129D00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5129D40", Offset = "0x5128F40", VA = "0x185129D40")]
	public BCKJOINGGJM EONOHGBFAIE()
	{
		return default(BCKJOINGGJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5129D80", Offset = "0x5128F80", VA = "0x185129D80")]
	[AsyncStateMachine(typeof(KDLBMFPBJPF<>.HGCNOKNOBBN))]
	public Task<KDLBMFPBJPF<T>.BCKJOINGGJM> HKAEGBJDADB(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x512A1C0", Offset = "0x51293C0", VA = "0x18512A1C0")]
	public void HOGBDPMADNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HGHMHOHCLMA
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD2F0", Offset = "0x7DBC4F0", VA = "0x187DBD2F0")]
	public static KDLBMFPBJPF<LMEKHMKKIDI> FAHGDJGLLGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3791E70", Offset = "0x3791070", VA = "0x183791E70")]
	public static KDLBMFPBJPF<T> FAHGDJGLLGD<T>([In] T PHFFEPFKKME) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class JHEAJNBCLLF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct ICEKKGDHALF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly JHEAJNBCLLF<T> HJDNGKNNJCA;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T LFLEGEJLLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4DA9A10", Offset = "0x4DA8C10", VA = "0x184DA9A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4DA98F0", Offset = "0x4DA8AF0", VA = "0x184DA98F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
		internal ICEKKGDHALF(JHEAJNBCLLF<T> GACDOEDIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct KIBFBFDPLFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly JHEAJNBCLLF<T> HJDNGKNNJCA;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T LFLEGEJLLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4DA9A10", Offset = "0x4DA8C10", VA = "0x184DA9A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5133F30", Offset = "0x5133130", VA = "0x185133F30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
		internal KIBFBFDPLFG(JHEAJNBCLLF<T> GACDOEDIFFL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EICDOLDJNAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<KIBFBFDPLFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JHEAJNBCLLF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private KDLBMFPBJPF<LMEKHMKKIDI>.BCKJOINGGJM <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<KDLBMFPBJPF<LMEKHMKKIDI>.BCKJOINGGJM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4682390", Offset = "0x4681590", VA = "0x184682390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x46828B0", Offset = "0x4681AB0", VA = "0x1846828B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KDLBMFPBJPF<int> OFMGCLEHMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly KDLBMFPBJPF<LMEKHMKKIDI> LOGDNMACAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly KDLBMFPBJPF<LMEKHMKKIDI> CNJKHMKJMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T NHOINDAEFNP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5048170", Offset = "0x5047370", VA = "0x185048170")]
	internal JHEAJNBCLLF(KDLBMFPBJPF<int> ANNBOACIGOM, KDLBMFPBJPF<LMEKHMKKIDI> JPHOLFFICDL, KDLBMFPBJPF<LMEKHMKKIDI> NAAMFPOKHMH, [In] T PHFFEPFKKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5047AA0", Offset = "0x5046CA0", VA = "0x185047AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5047CE0", Offset = "0x5046EE0", VA = "0x185047CE0")]
	public ICEKKGDHALF NNHKGDAPOLJ()
	{
		return default(ICEKKGDHALF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x50476D0", Offset = "0x50468D0", VA = "0x1850476D0")]
	public KIBFBFDPLFG BOGBGKANOGB()
	{
		return default(KIBFBFDPLFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x50475B0", Offset = "0x50467B0", VA = "0x1850475B0")]
	[AsyncStateMachine(typeof(JHEAJNBCLLF<>.EICDOLDJNAC))]
	public Task<JHEAJNBCLLF<T>.KIBFBFDPLFG> ACFCNIPNGPA(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EJIAMCBJDDL
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC9B0", Offset = "0x7DBBBB0", VA = "0x187DBC9B0")]
	public static JHEAJNBCLLF<LMEKHMKKIDI> FAHGDJGLLGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3895B00", Offset = "0x3894D00", VA = "0x183895B00")]
	public static JHEAJNBCLLF<T> FAHGDJGLLGD<T>([In] T PHFFEPFKKME) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class MAAGJJPKGFG<TData> : DCJPFEGHGPF where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string LDKJFCNOLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData OCEAHOAJAAG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
	public override string AHCNILBBCDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x53E8F60", Offset = "0x53E8160", VA = "0x1853E8F60")]
	internal MAAGJJPKGFG(string NPEJLHCJPAI, [In] TData CAIGHLKIDBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PKNJKIAOJNH
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDDD0", Offset = "0x7DBCFD0", VA = "0x187DBDDD0")]
	public static MAAGJJPKGFG<LMEKHMKKIDI> FAHGDJGLLGD(string NPEJLHCJPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2FADC80", Offset = "0x2FACE80", VA = "0x182FADC80")]
	public static MAAGJJPKGFG<TData> FAHGDJGLLGD<TData>(string NPEJLHCJPAI, [In] TData CAIGHLKIDBF) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class LNDPAJNBFGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool DPMJDGIMPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string DEMNJAMEKLH;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xE80D70", Offset = "0xE7FF70", VA = "0x180E80D70")]
	private LNDPAJNBFGA(bool KNMFLKOIHAE, string KAKDEBLMACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD9B0", Offset = "0x7DBCBB0", VA = "0x187DBD9B0")]
	public static LNDPAJNBFGA FAHGDJGLLGD(string KAKDEBLMACJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDA20", Offset = "0x7DBCC20", VA = "0x187DBDA20")]
	public EAKEIPAFFBN KDBDLHMLMMG()
	{
		return default(EAKEIPAFFBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct EAKEIPAFFBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LNDPAJNBFGA IIEEBMDCMLP;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
	internal EAKEIPAFFBN(LNDPAJNBFGA BKDMJHGCDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC0D0", Offset = "0x7DBB2D0", VA = "0x187DBC0D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class GDIOEPKGCCP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PHDMCFAMBEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PHDMCFAMBEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x56E8510", Offset = "0x56E7710", VA = "0x1856E8510")]
		internal int FDBEHDNKCDB(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? DECIPOOKCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> PDMLCPMIIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4BF4AE0", Offset = "0x4BF3CE0", VA = "0x184BF4AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LBJHFAJHHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4BF48A0", Offset = "0x4BF3AA0", VA = "0x184BF48A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA09780", Offset = "0xA08980", VA = "0x180A09780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4BF48D0", Offset = "0x4BF3AD0", VA = "0x184BF48D0")]
	public bool LHOMNBOIMGH(T CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4BF4B10", Offset = "0x4BF3D10", VA = "0x184BF4B10")]
	public bool PKCJOLGDFLO(T CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4BF4AA0", Offset = "0x4BF3CA0", VA = "0x184BF4AA0")]
	public bool NJCAMOKKLGF(T CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4BF4A20", Offset = "0x4BF3C20", VA = "0x184BF4A20")]
	public void LKBCCKHGJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4BF4C20", Offset = "0x4BF3E20", VA = "0x184BF4C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public GDIOEPKGCCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class PPOFIDCPAOP
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class HHNIIMHDBFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HHNIIMHDBFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD360", Offset = "0x7DBC560", VA = "0x187DBD360")]
		internal int FDBEHDNKCDB(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? DECIPOOKCMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> PDMLCPMIIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE010", Offset = "0x7DBD210", VA = "0x187DBE010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool LBJHFAJHHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDE50", Offset = "0x7DBD050", VA = "0x187DBDE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA09780", Offset = "0xA08980", VA = "0x180A09780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDE60", Offset = "0x7DBD060", VA = "0x187DBDE60")]
	public bool LHOMNBOIMGH(object CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE0A0", Offset = "0x7DBD2A0", VA = "0x187DBE0A0")]
	public bool PKCJOLGDFLO(object CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDFB0", Offset = "0x7DBD1B0", VA = "0x187DBDFB0")]
	public bool NJCAMOKKLGF(object CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDF40", Offset = "0x7DBD140", VA = "0x187DBDF40")]
	public void LKBCCKHGJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE140", Offset = "0x7DBD340", VA = "0x187DBE140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PPOFIDCPAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PJNINDLEAAN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct ABMOGJCPCJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float LOCNBAEFIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T LFLEGEJLLKE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, ABMOGJCPCJP> MGGGOEHGEIK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T JPJIDOHIEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x11030A0", Offset = "0x11022A0", VA = "0x1811030A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1A68860", Offset = "0x1A67A60", VA = "0x181A68860", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? KMKONBAHNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KHOHAAPJGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x50172E0", Offset = "0x50164E0", VA = "0x1850172E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x56F78E0", Offset = "0x56F6AE0", VA = "0x1856F78E0")]
	public bool PAMMCPIPILF(T KJIOHKMJAPE, object CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4CEA7C0", Offset = "0x4CE99C0", VA = "0x184CEA7C0")]
	public bool ADCJALNBKOH(object CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5017320", Offset = "0x5016520", VA = "0x185017320")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x56F5EB0", Offset = "0x56F50B0", VA = "0x1856F5EB0")]
	public bool FBLKJFCBGPJ(object CCLFNPCGNED, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x56F6AA0", Offset = "0x56F5CA0", VA = "0x1856F6AA0")]
	[GBIEILHEKIF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FHCDFBMOPKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAF00", Offset = "0x4CEA100", VA = "0x184CEAF00")]
	public PJNINDLEAAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DOBKDOOJHFM : KMPLHIFMALH<JPIJMPDMIDF>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class KMJGKBPDNDM : IEqualityComparer<JPIJMPDMIDF>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly KMJGKBPDNDM AIBLJDBPKAO;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD920", Offset = "0x7DBCB20", VA = "0x187DBD920", Slot = "4")]
		public bool Equals(JPIJMPDMIDF HGCMPGNMMIB, JPIJMPDMIDF PIALGICKFLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6EF51B0", Offset = "0x6EF43B0", VA = "0x186EF51B0", Slot = "5")]
		public int GetHashCode(JPIJMPDMIDF KFMNDOMPAMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KMJGKBPDNDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBC060", Offset = "0x7DBB260", VA = "0x187DBC060")]
	public DOBKDOOJHFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBF00", Offset = "0x7DBB100", VA = "0x187DBBF00", Slot = "4")]
	public override bool LHOMNBOIMGH(JPIJMPDMIDF CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBFB0", Offset = "0x7DBB1B0", VA = "0x187DBBFB0", Slot = "5")]
	public override bool PKCJOLGDFLO(JPIJMPDMIDF CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBE70", Offset = "0x7DBB070", VA = "0x187DBBE70")]
	private static void AAGLGNKJDAD(JPIJMPDMIDF CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1968320", Offset = "0x1967520", VA = "0x181968320", Slot = "6")]
	protected override string TokenToString(JPIJMPDMIDF CCLFNPCGNED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class JPIJMPDMIDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string MJBFAAFPLID;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public JPIJMPDMIDF(string MJBFAAFPLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD470", Offset = "0x7DBC670", VA = "0x187DBD470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class KMPLHIFMALH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> PFCONGNHPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? DECIPOOKCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> PDMLCPMIIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x514AB00", Offset = "0x5149D00", VA = "0x18514AB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LBJHFAJHHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4BF48A0", Offset = "0x4BF3AA0", VA = "0x184BF48A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xCEC9C0", Offset = "0xCEBBC0", VA = "0x180CEC9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x514B2F0", Offset = "0x514A4F0", VA = "0x18514B2F0")]
	public KMPLHIFMALH(IEqualityComparer<T> PFCONGNHPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x514A7B0", Offset = "0x51499B0", VA = "0x18514A7B0", Slot = "4")]
	public virtual bool LHOMNBOIMGH(T CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x514AC40", Offset = "0x5149E40", VA = "0x18514AC40", Slot = "5")]
	public virtual bool PKCJOLGDFLO(T CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x514AA80", Offset = "0x5149C80", VA = "0x18514AA80")]
	public void LKBCCKHGJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x514B010", Offset = "0x514A210", VA = "0x18514B010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class PHHKPNCAPOP<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? DECIPOOKCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LBJHFAJHHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x56E85C0", Offset = "0x56E77C0", VA = "0x1856E85C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x56E86B0", Offset = "0x56E78B0", VA = "0x1856E86B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x56E87F0", Offset = "0x56E79F0", VA = "0x1856E87F0")]
	public void LHOMNBOIMGH(T CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x56E8A10", Offset = "0x56E7C10", VA = "0x1856E8A10")]
	public void PKCJOLGDFLO(T CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x56E89F0", Offset = "0x56E7BF0", VA = "0x1856E89F0")]
	public void LKBCCKHGJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x56E8B50", Offset = "0x56E7D50", VA = "0x1856E8B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PHHKPNCAPOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class FKFBEHMLCNP
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x39ECBA0", Offset = "0x39EBDA0", VA = "0x1839ECBA0")]
	public static void KNEIJKOBFCD<T>(this List<T> CFFEIIKPOPD, int CMDFFDAPDIB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ANNGEFNGMCL<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct LIOCFCCNBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float LOCNBAEFIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T LFLEGEJLLKE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<JPIJMPDMIDF, LIOCFCCNBLB> MGGGOEHGEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> GMIGDOCKLGH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T JPJIDOHIEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3F0", Offset = "0xA0C5F0", VA = "0x180A0D3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA0D640", Offset = "0xA0C840", VA = "0x180A0D640", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private JPIJMPDMIDF? KMKONBAHNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool KHOHAAPJGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x50172E0", Offset = "0x50164E0", VA = "0x1850172E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5017440", Offset = "0x5016640", VA = "0x185017440")]
	public bool PAMMCPIPILF(T KJIOHKMJAPE, JPIJMPDMIDF CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4CEA7C0", Offset = "0x4CE99C0", VA = "0x184CEA7C0")]
	public bool ADCJALNBKOH(JPIJMPDMIDF CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5017320", Offset = "0x5016520", VA = "0x185017320")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5016D20", Offset = "0x5015F20", VA = "0x185016D20")]
	public bool FBLKJFCBGPJ(JPIJMPDMIDF CCLFNPCGNED, [Out] T KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5016D90", Offset = "0x5015F90", VA = "0x185016D90")]
	[GBIEILHEKIF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FHCDFBMOPKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5017630", Offset = "0x5016830", VA = "0x185017630")]
	public ANNGEFNGMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DNCLHGDCGPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> MGGGOEHGEIK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float ALOHPEKIBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1104F70", Offset = "0x1104170", VA = "0x181104F70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x124D840", Offset = "0x124CA40", VA = "0x18124D840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBD70", Offset = "0x7DBAF70", VA = "0x187DBBD70")]
	public void PAMMCPIPILF(float KJIOHKMJAPE, object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBB80", Offset = "0x7DBAD80", VA = "0x187DBBB80")]
	public void ADCJALNBKOH(object CCLFNPCGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBD20", Offset = "0x7DBAF20", VA = "0x187DBBD20")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBBF0", Offset = "0x7DBADF0", VA = "0x187DBBBF0")]
	private void AFBODFIAAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7DBBDE0", Offset = "0x7DBAFE0", VA = "0x187DBBDE0")]
	public DNCLHGDCGPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface GPIKKJLGADI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NMDLEPKPHNK IPHDOGJCOGP;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class DHHHLMIJLMK : GPIKKJLGADI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct FFHOBJFAIAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float PDKHLGCCMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float PFMOJGOAPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool APFGOMCKPFB;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float BBPOBHNIEFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7DBCE00", Offset = "0x7DBC000", VA = "0x187DBCE00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCF80", Offset = "0x7DBC180", VA = "0x187DBCF80")]
		public FFHOBJFAIAC(float EIGANLKFLHL, float GCHDNICOBCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7DBCE10", Offset = "0x7DBC010", VA = "0x187DBCE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class AMFMMCIKOKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DHHHLMIJLMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AMFMMCIKOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7DBA900", Offset = "0x7DB9B00", VA = "0x187DBA900")]
		internal void GCGOGCHHJPJ(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int POKPPHJAIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int EFMCNIFICBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly GPIKKJLGADI[] KAAOKKAJLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly NMDLEPKPHNK[] PLKEMCOOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FFHOBJFAIAC[] GNPALIDEEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private FFHOBJFAIAC GLAPABCKCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OHEDPJJAEEG IHNEEJJOPNP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NMDLEPKPHNK IPHDOGJCOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB250", Offset = "0x7DBA450", VA = "0x187DBB250", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB420", Offset = "0x7DBA620", VA = "0x187DBB420", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB9F0", Offset = "0x7DBABF0", VA = "0x187DBB9F0")]
	public DHHHLMIJLMK(int POKPPHJAIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB4E0", Offset = "0x7DBA6E0", VA = "0x187DBB4E0")]
	public OHEDPJJAEEG FNGHMCFJLNC(FFHOBJFAIAC CFPNMKPLIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB570", Offset = "0x7DBA770", VA = "0x187DBB570")]
	public void IOJBBFDHEEM(GPIKKJLGADI JACLNPKAPII, [Optional] FFHOBJFAIAC JAIFMIICHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7DBB310", Offset = "0x7DBA510", VA = "0x187DBB310", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void NMDLEPKPHNK(float CMFBMIMHAIC);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FOAPHJKCOBL
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class HFLGJOCHJBO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly GPIKKJLGADI OLHMOHFJPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly NMDLEPKPHNK MHPGHAHOBNK;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD260", Offset = "0x7DBC460", VA = "0x187DBD260")]
		public HFLGJOCHJBO(GPIKKJLGADI OLHMOHFJPBB, NMDLEPKPHNK MHPGHAHOBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD210", Offset = "0x7DBC410", VA = "0x187DBD210", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD0E0", Offset = "0x7DBC2E0", VA = "0x187DBD0E0")]
	internal static bool FDMNFCENJEG(float BGPKBCGBDMP, float NIJBGCGEGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7DA6AE0", Offset = "0x7DA5CE0", VA = "0x187DA6AE0")]
	internal static float DCDJMKIGCAD(float BGPKBCGBDMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD150", Offset = "0x7DBC350", VA = "0x187DBD150")]
	public static IDisposable KIEOELDOIJJ(this GPIKKJLGADI OLHMOHFJPBB, NMDLEPKPHNK MHPGHAHOBNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class OHEDPJJAEEG : GPIKKJLGADI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float CMFBMIMHAIC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float CJNHKMFGHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDC40", Offset = "0x7DBCE40", VA = "0x187DBDC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NMDLEPKPHNK? IPHDOGJCOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDBA0", Offset = "0x7DBCDA0", VA = "0x187DBDBA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDD30", Offset = "0x7DBCF30", VA = "0x187DBDD30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public OHEDPJJAEEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface HMJDOKIEEAA<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNKAOFHLKDG<T> KKGIPBEMGOM([Out] T KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLKFAGPLGGN();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HJDGJEJIDID<T> : HMJDOKIEEAA<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> ELKLMGGLIJP;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4CAD010", Offset = "0x4CAC210", VA = "0x184CAD010", Slot = "4")]
	public NNKAOFHLKDG<T> KKGIPBEMGOM([Out] T KJIOHKMJAPE)
	{
		return default(NNKAOFHLKDG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4CAD0A0", Offset = "0x4CAC2A0", VA = "0x184CAD0A0")]
	public void NCGHJFCANHM(T FGLKLKGOOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4CAD100", Offset = "0x4CAC300", VA = "0x184CAD100", Slot = "5")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "6")]
	protected virtual void LLNIAIPGAOK(T GHGNHJDFOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4CACF90", Offset = "0x4CAC190", VA = "0x184CACF90")]
	private T AFHCIICHJIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4CAD130", Offset = "0x4CAC330", VA = "0x184CAD130")]
	public HJDGJEJIDID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct NNKAOFHLKDG<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T FGLKLKGOOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly HJDGJEJIDID<T> LNBOHLIJCFM;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
	internal NNKAOFHLKDG(T KJIOHKMJAPE, HJDGJEJIDID<T> LNBOHLIJCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x54A74F0", Offset = "0x54A66F0", VA = "0x1854A74F0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class ANHGOGMEHEI : HJDGJEJIDID<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly ANHGOGMEHEI AIBLJDBPKAO;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBA9A0", Offset = "0x7DB9BA0", VA = "0x187DBA9A0")]
	public static NNKAOFHLKDG<StringBuilder> AFHCIICHJIO([Out] StringBuilder KJIOHKMJAPE)
	{
		return default(NNKAOFHLKDG<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAA40", Offset = "0x7DB9C40", VA = "0x187DBAA40", Slot = "6")]
	protected override void LLNIAIPGAOK(StringBuilder GHGNHJDFOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBAAF0", Offset = "0x7DB9CF0", VA = "0x187DBAAF0")]
	public ANHGOGMEHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FCINICCAKGD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x76528C0", Offset = "0x7651AC0", VA = "0x1876528C0")]
	public FCINICCAKGD(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class LGAHIJNEIOA<TKey, TValue> : NOMOPJIKIIO<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, FMBCEDFALGN where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class KBDNPJCEAKM : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LGAHIJNEIOA<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x11030A0", Offset = "0x11022A0", VA = "0x1811030A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4B7B4C0", Offset = "0x4B7A6C0", VA = "0x184B7B4C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public KBDNPJCEAKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B6B0", Offset = "0x4B7A8B0", VA = "0x184B7B6B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5125C20", Offset = "0x5124E20", VA = "0x185125C20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5125300", Offset = "0x5124500", VA = "0x185125300")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5125490", Offset = "0x5124690", VA = "0x185125490")]
		private void GHEPLDLLGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5126090", Offset = "0x5125290", VA = "0x185126090", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly NOMOPJIKIIO<TKey, TValue> OKKFLAIJEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> OBBICJEJPJK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x52003F0", Offset = "0x51FF5F0", VA = "0x1852003F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JNOIOHADNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5200680", Offset = "0x51FF880", VA = "0x185200680", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x52008C0", Offset = "0x51FFAC0", VA = "0x1852008C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> PCJBOJJNOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x52006C0", Offset = "0x51FF8C0", VA = "0x1852006C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> HKHNBMACGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x52007C0", Offset = "0x51FF9C0", VA = "0x1852007C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5200340", Offset = "0x51FF540", VA = "0x185200340")]
	public LGAHIJNEIOA(NOMOPJIKIIO<TKey, TValue> OKKFLAIJEFF, [Optional] IDictionary<TKey, TValue>? OBBICJEJPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x51FE210", Offset = "0x51FD410", VA = "0x1851FE210", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x51FEA40", Offset = "0x51FDC40", VA = "0x1851FEA40")]
	public void DMJCBLGMLJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x51FDB20", Offset = "0x51FCD20", VA = "0x1851FDB20", Slot = "9")]
	public void Add(TKey MHDODBCCAJB, TValue KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x51FEA90", Offset = "0x51FDC90", VA = "0x1851FEA90")]
	public void EAFCCCIKHPB(TKey MHDODBCCAJB, TValue KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x51FDFB0", Offset = "0x51FD1B0", VA = "0x1851FDFB0")]
	public void CAFNCLEJHPC(TKey MHDODBCCAJB, TValue KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x51FEF00", Offset = "0x51FE100", VA = "0x1851FEF00")]
	public void JGHCPNCPFOL(TKey MHDODBCCAJB, TValue KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x51FD940", Offset = "0x51FCB40", VA = "0x1851FD940")]
	public void AMIBONCOGLH(TKey MHDODBCCAJB, TValue KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x51FF9C0", Offset = "0x51FEBC0", VA = "0x1851FF9C0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x51FFA10", Offset = "0x51FEC10", VA = "0x1851FFA10", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x51FFF10", Offset = "0x51FF110", VA = "0x1851FFF10", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x51FE310", Offset = "0x51FD510", VA = "0x1851FE310", Slot = "8")]
	public bool ContainsKey(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x51FF690", Offset = "0x51FE890", VA = "0x1851FF690")]
	public bool NNMDMGCICPC(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x51FDEE0", Offset = "0x51FD0E0", VA = "0x1851FDEE0")]
	public bool BFMIMEAAKMO(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x51FF820", Offset = "0x51FEA20", VA = "0x1851FF820", Slot = "10")]
	public bool Remove(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x52000D0", Offset = "0x51FF2D0", VA = "0x1852000D0", Slot = "11")]
	public bool TryGetValue(TKey MHDODBCCAJB, [Out] TValue KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x51FE810", Offset = "0x51FDA10", VA = "0x1851FE810", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] KBILCKNPAKO, int NEAIGFOMGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x50FE180", Offset = "0x50FD380", VA = "0x1850FE180", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x51FED80", Offset = "0x51FDF80", VA = "0x1851FED80", Slot = "19")]
	[IteratorStateMachine(typeof(LGAHIJNEIOA<, >.KBDNPJCEAKM))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x51FEEB0", Offset = "0x51FE0B0", VA = "0x1851FEEB0", Slot = "21")]
	public bool HOCIIGNMMII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x51FF460", Offset = "0x51FE660", VA = "0x1851FF460")]
	private TValue KEOKGFHNFPN(TKey MHDODBCCAJB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface FKGOOJAPAFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string IOKEFOCLEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface FMBCEDFALGN
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOCIIGNMMII();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface NOMOPJIKIIO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FMBCEDFALGN
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class EIDHCHLOOHL<TKey, TVal> : NOMOPJIKIIO<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FMBCEDFALGN where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int ILHBAGOCGAN(TKey MHDODBCCAJB, TVal KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void GMONEOCEECC(TKey MHDODBCCAJB, TVal KJIOHKMJAPE, FFFGGGKPJDD GBBFGBIIOBJ);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class OENIGHBONEJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey JLFEKHMMFHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal LFLEGEJLLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xCEC9C0", Offset = "0xCEBBC0", VA = "0x180CEC9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int BBPOBHNIEFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA674B0", Offset = "0xA666B0", VA = "0x180A674B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xF45280", Offset = "0xF44480", VA = "0x180F45280")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset ONDDBDKLINP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x127BC40", Offset = "0x127AE40", VA = "0x18127BC40")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x13890D0", Offset = "0x13882D0", VA = "0x1813890D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x56119B0", Offset = "0x5610BB0", VA = "0x1856119B0")]
		public OENIGHBONEJ(TKey MHDODBCCAJB, TVal DIPIKNPCGFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class FHMBHHOCHOK : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public EIDHCHLOOHL<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<OENIGHBONEJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x11030A0", Offset = "0x11022A0", VA = "0x1811030A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x4B37890", Offset = "0x4B36A90", VA = "0x184B37890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public FHMBHHOCHOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4B379B0", Offset = "0x4B36BB0", VA = "0x184B379B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4B370C0", Offset = "0x4B362C0", VA = "0x184B370C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4B34F40", Offset = "0x4B34140", VA = "0x184B34F40")]
		private void DOCBGIOIEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4B37390", Offset = "0x4B36590", VA = "0x184B37390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int MHICFCJCNML = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<OENIGHBONEJ>> EHHMMBODKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<OENIGHBONEJ> DFPDPLFMNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ILHBAGOCGAN? MJKCFGIONLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan DGIMKCDJHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GMONEOCEECC? JBDKCHKDIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly NPOMJDLOFMO KBFNFLIDJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool DBJFNMGCPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> DBPGIHBBKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> BDGAMOJNBPN;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int BFJKGNBMPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xC535A0", Offset = "0xC527A0", VA = "0x180C535A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int HEKLCFHOJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xD93940", Offset = "0xD92B40", VA = "0x180D93940")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xED0D70", Offset = "0xECFF70", VA = "0x180ED0D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4695B10", Offset = "0x4694D10", VA = "0x184695B10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int KJPNFAKKGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4689530", Offset = "0x4688730", VA = "0x184689530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> HKHNBMACGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4695C20", Offset = "0x4694E20", VA = "0x184695C20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.NHPKJDJAIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4692650", Offset = "0x4691850", VA = "0x184692650", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool JNOIOHADNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal HAHLLCOCBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4695BE0", Offset = "0x4694DE0", VA = "0x184695BE0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4695C50", Offset = "0x4694E50", VA = "0x184695C50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x468E040", Offset = "0x468D240", VA = "0x18468E040")]
	private bool MACHECJMOFG(int POKPPHJAIGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x468AFB0", Offset = "0x468A1B0", VA = "0x18468AFB0")]
	private void JNMPMNLBMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4694B80", Offset = "0x4693D80", VA = "0x184694B80")]
	public EIDHCHLOOHL(int POKPPHJAIGN, [Optional] ILHBAGOCGAN? MJKCFGIONLL, [Optional] IEqualityComparer<TKey>? AJFGDBOEIKD, [Optional] GMONEOCEECC? JBDKCHKDIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4693820", Offset = "0x4692A20", VA = "0x184693820")]
	public EIDHCHLOOHL(TimeSpan DGIMKCDJHEA, [Optional] IEqualityComparer<TKey>? AJFGDBOEIKD, [Optional] GMONEOCEECC? JBDKCHKDIDL, [Optional] NPOMJDLOFMO? KBFNFLIDJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4693870", Offset = "0x4692A70", VA = "0x184693870")]
	public EIDHCHLOOHL(int POKPPHJAIGN, TimeSpan DGIMKCDJHEA, [Optional] IEqualityComparer<TKey>? AJFGDBOEIKD, [Optional] GMONEOCEECC? JBDKCHKDIDL, [Optional] NPOMJDLOFMO? KBFNFLIDJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4693040", Offset = "0x4692240", VA = "0x184693040")]
	public EIDHCHLOOHL(int POKPPHJAIGN, ILHBAGOCGAN? MJKCFGIONLL, TimeSpan DGIMKCDJHEA, [Optional] IEqualityComparer<TKey>? AJFGDBOEIKD, [Optional] GMONEOCEECC? JBDKCHKDIDL, [Optional] NPOMJDLOFMO? KBFNFLIDJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x468A260", Offset = "0x4689460", VA = "0x18468A260", Slot = "21")]
	public bool HOCIIGNMMII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x468F170", Offset = "0x468E370", VA = "0x18468F170", Slot = "22")]
	public bool NEPFENNICME(int GCFCAGDGDIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x468C770", Offset = "0x468B970", VA = "0x18468C770")]
	private bool KMBMOLFILLH(int GCFCAGDGDIN, FFFGGGKPJDD GBBFGBIIOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4689380", Offset = "0x4688580", VA = "0x184689380")]
	public void DEEMOOGCBGF(TKey MHDODBCCAJB, TVal KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4683F80", Offset = "0x4683180", VA = "0x184683F80", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LHNFJLFIPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x46849C0", Offset = "0x4683BC0", VA = "0x1846849C0", Slot = "9")]
	public void Add(TKey MHDODBCCAJB, TVal KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4684D10", Offset = "0x4683F10", VA = "0x184684D10", Slot = "8")]
	public bool ContainsKey(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4691FA0", Offset = "0x46911A0", VA = "0x184691FA0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4691BE0", Offset = "0x4690DE0", VA = "0x184691BE0", Slot = "10")]
	public bool Remove(TKey MHDODBCCAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x46922E0", Offset = "0x46914E0", VA = "0x1846922E0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LHNFJLFIPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x468FC00", Offset = "0x468EE00", VA = "0x18468FC00")]
	private bool ODACIEJEFCI(TKey MHDODBCCAJB, [Out] TVal KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4683710", Offset = "0x4682910", VA = "0x184683710")]
	private TVal AFHCIICHJIO(TKey LMBJOMEGNFK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4692D20", Offset = "0x4691F20", VA = "0x184692D20", Slot = "11")]
	public bool TryGetValue(TKey LMBJOMEGNFK, [Out] TVal KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4684B00", Offset = "0x4683D00", VA = "0x184684B00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4685A50", Offset = "0x4684C50", VA = "0x184685A50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KBILCKNPAKO, int NEAIGFOMGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4689EF0", Offset = "0x46890F0", VA = "0x184689EF0")]
	private void HECINDKDFOE(TKey MHDODBCCAJB, TVal DIPIKNPCGFJ, FFFGGGKPJDD GBBFGBIIOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x468A430", Offset = "0x4689630", VA = "0x18468A430")]
	private bool IKGLDJIPHEM(OENIGHBONEJ LGKFNBFPEFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x46887B0", Offset = "0x46879B0", VA = "0x1846887B0")]
	private void DALIPHJMFBH(LinkedListNode<OENIGHBONEJ> MOGCBENNKCK, TVal KMHJHNJDCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4690490", Offset = "0x468F690", VA = "0x184690490")]
	private void PAMMCPIPILF(TKey MHDODBCCAJB, TVal KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x468E9A0", Offset = "0x468DBA0", VA = "0x18468E9A0")]
	private void NDFPADIJHHB(OENIGHBONEJ LGKFNBFPEFG, TVal KMHJHNJDCNC, int IPOAODEDPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4689720", Offset = "0x4688920", VA = "0x184689720", Slot = "19")]
	[IteratorStateMachine(typeof(EIDHCHLOOHL<, >.FHMBHHOCHOK))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4692680", Offset = "0x4691880", VA = "0x184692680", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum FFFGGGKPJDD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class DEKKEMAFMPB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey GCAJIAFABHM;

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4206C90", Offset = "0x4205E90", VA = "0x184206C90")]
	public DEKKEMAFMPB(TKey BJLJAEMIEHM, Exception LANNDIJMBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KBFIGPDFDPJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E88150", Offset = "0x6E87350", VA = "0x186E88150")]
	public KBFIGPDFDPJ(string NPEJLHCJPAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CEJFLAGAABB<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class EHLIPDPKCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CEJFLAGAABB<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EHLIPDPKCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x467EA70", Offset = "0x467DC70", VA = "0x18467EA70")]
		internal Task<TResource> OBPCLIKJNCI(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct PDMHOEBGJHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CEJFLAGAABB<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x56E5810", Offset = "0x56E4A10", VA = "0x1856E5810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x56E6430", Offset = "0x56E5630", VA = "0x1856E6430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct IFDLKOLIPIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7180", Offset = "0x4DE6380", VA = "0x184DE7180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4DE7E20", Offset = "0x4DE7020", VA = "0x184DE7E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly LLAPMCADPDB<TId, Task<TResource>> HOPDDMHNLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> IDHJMFDJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? IAGBPOJELNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? OGOBJIALKGO;

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x66CF4C0", Offset = "0x66CE6C0", VA = "0x1866CF4C0")]
	public CEJFLAGAABB(int LJPOFFHOCIN = 0, [Optional] IEqualityComparer<TId>? OCBKJDNEKCA, [Optional] Func<TId, CancellationToken, Task<TResource>>? HEFAIOJFJDM, [Optional] Action<TResource>? HEFPEHPDJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x66CE480", Offset = "0x66CD680", VA = "0x1866CE480")]
	public MBFLJOFBBPA<Task<TResource>> HCAEEHCCBEL(TId APBCLGNDGBE, [Optional] Func<TId, CancellationToken, Task<TResource>>? HEFAIOJFJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x66CF200", Offset = "0x66CE400", VA = "0x1866CF200")]
	private void OLLLHCCMGKM(Task<TResource> MKOPIIJMBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x66CED00", Offset = "0x66CDF00", VA = "0x1866CED00")]
	[AsyncStateMachine(typeof(CEJFLAGAABB<, >.PDMHOEBGJHJ))]
	private Task HFABPFCDKLM(Task<TResource> MKOPIIJMBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x66CE450", Offset = "0x66CD650", VA = "0x1866CE450")]
	public void GJGKLDJFELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x66CE3E0", Offset = "0x66CD5E0", VA = "0x1866CE3E0")]
	public LLAPMCADPDB<TId, Task<TResource>>.IJOCOGNINOI BFKODFEKGDL()
	{
		return default(LLAPMCADPDB<TId, Task<TResource>>.IJOCOGNINOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x66CF300", Offset = "0x66CE500", VA = "0x1866CF300", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x66CF300", Offset = "0x66CE500", VA = "0x1866CF300", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x66CDE40", Offset = "0x66CD040", VA = "0x1866CDE40")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(CEJFLAGAABB<, >.IFDLKOLIPIC))]
	internal static Task BCADMCKOJIM(Task<TResource> MKOPIIJMBLM, CancellationTokenSource JBKLDOEMDAK, Dictionary<Task<TResource>, CancellationTokenSource> LFKAGAMLCIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class LLAPMCADPDB<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class HBGOCPIBKOP : IEquatable<HBGOCPIBKOP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue LFLEGEJLLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int ECNIHMIMAAO;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x11D4AD0", Offset = "0x11D3CD0", VA = "0x1811D4AD0")]
		public HBGOCPIBKOP(TValue KJIOHKMJAPE, int JOPJGLOMMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x4C96EC0", Offset = "0x4C960C0", VA = "0x184C96EC0", Slot = "4")]
		public bool Equals(HBGOCPIBKOP? CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4C96E30", Offset = "0x4C96030", VA = "0x184C96E30", Slot = "0")]
		public override bool Equals(object? KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4C97040", Offset = "0x4C96240", VA = "0x184C97040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct IJOCOGNINOI : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, HBGOCPIBKOP>.Enumerator CAHGFAEKPGE;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2560", Offset = "0x4DF1760", VA = "0x184DF2560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2990", Offset = "0x4DF1B90", VA = "0x184DF2990", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4DF28D0", Offset = "0x4DF1AD0", VA = "0x184DF28D0")]
		public IJOCOGNINOI(LLAPMCADPDB<TKey, TValue> MGGGOEHGEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4DF21C0", Offset = "0x4DF13C0", VA = "0x184DF21C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2240", Offset = "0x4DF1440", VA = "0x184DF2240", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4DF24C0", Offset = "0x4DF16C0", VA = "0x184DF24C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class ILBABFAIFEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public LLAPMCADPDB<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public HBGOCPIBKOP refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ILBABFAIFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4DF6800", Offset = "0x4DF5A00", VA = "0x184DF6800")]
		internal void OBPCLIKJNCI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, HBGOCPIBKOP> PJMDOCOOJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? OIJOOJNIHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? FIFDMLAIFHI;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x521E480", Offset = "0x521D680", VA = "0x18521E480")]
	public LLAPMCADPDB(int LJPOFFHOCIN = 0, [Optional] IEqualityComparer<TKey>? AJFGDBOEIKD, [Optional] Func<TKey, TValue>? GEAIEADEFCF, [Optional] Action<TValue>? DKDAKKBMILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x521D540", Offset = "0x521C740", VA = "0x18521D540")]
	public MBFLJOFBBPA<TValue> HCAEEHCCBEL(TKey MHDODBCCAJB, [Optional] Func<TKey, TValue>? HHDDKOFNJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x521E100", Offset = "0x521D300", VA = "0x18521E100")]
	private void NCGHJFCANHM(TKey MHDODBCCAJB, HBGOCPIBKOP CAOGBGJJCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x521D360", Offset = "0x521C560", VA = "0x18521D360")]
	public void GJGKLDJFELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x521CED0", Offset = "0x521C0D0", VA = "0x18521CED0")]
	public IJOCOGNINOI BFKODFEKGDL()
	{
		return default(IJOCOGNINOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x521E2C0", Offset = "0x521D4C0", VA = "0x18521E2C0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x521E2C0", Offset = "0x521D4C0", VA = "0x18521E2C0", Slot = "5")]
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
