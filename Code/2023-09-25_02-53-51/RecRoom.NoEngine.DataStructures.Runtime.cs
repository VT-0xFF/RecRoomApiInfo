using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F420", Offset = "0x5D4E820", VA = "0x185D4F420")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CBBKIBIOKOB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected CBBKIBIOKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class EICGMKIPLAO<T> : CBBKIBIOKOB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct NHNAKFKIEON
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum MOFANAGNLOG
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
		public MOFANAGNLOG DJMKKNDNCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T PAFFKHOCLGN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int EIGNMFCELKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool AOMPJALLNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool JKMOLGLMPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NPDJPFBJEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<NHNAKFKIEON>? NKNENGJCNMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NGMBHJLAGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3027B80", Offset = "0x3026F80", VA = "0x183027B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3028460", Offset = "0x3027860", VA = "0x183028460")]
	protected EICGMKIPLAO(bool JKMOLGLMPBF, bool AOMPJALLNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30283C0", Offset = "0x30277C0", VA = "0x1830283C0")]
	protected bool PJPCAFKCNMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3028140", Offset = "0x3027540", VA = "0x183028140")]
	protected void OAJKMHKHAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3027DB0", Offset = "0x30271B0", VA = "0x183027DB0")]
	protected void GIMFAEMGDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4D60", Offset = "0x1FF4160", VA = "0x181FF4D60")]
	private static void GODIBNDKDDH<U>(List<U>? NMLNNLIOHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3027BD0", Offset = "0x3026FD0", VA = "0x183027BD0", Slot = "4")]
	public void GIHKKMKIIOJ(T PAFFKHOCLGN, bool CAKLEFCFKJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3027F90", Offset = "0x3027390", VA = "0x183027F90", Slot = "5")]
	public void HFJFDMFKDND(T PAFFKHOCLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3028240", Offset = "0x3027640", VA = "0x183028240")]
	public void OOAOJFKKMLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HAPLCBGDCCN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIHKKMKIIOJ(Action PAFFKHOCLGN, bool CAKLEFCFKJE = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFJFDMFKDND(Action PAFFKHOCLGN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class HJKDHGFMLBJ : EICGMKIPLAO<Action>, HAPLCBGDCCN
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E3C0", Offset = "0x5D4D7C0", VA = "0x185D4E3C0")]
	public HJKDHGFMLBJ(bool JKMOLGLMPBF = false, bool AOMPJALLNFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E100", Offset = "0x5D4D500", VA = "0x185D4E100")]
	public void DFPIJIPLDKJ()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E360", Offset = "0x5D4D760", VA = "0x185D4E360")]
	public static HJKDHGFMLBJ LIGONOCHFCL(HJKDHGFMLBJ EPBOAADMILH, Action PAFFKHOCLGN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E300", Offset = "0x5D4D700", VA = "0x185D4E300")]
	public static HJKDHGFMLBJ IOMFPACHEIM(HJKDHGFMLBJ EPBOAADMILH, Action PAFFKHOCLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CBCGIDOHAHD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIHKKMKIIOJ(Action<T> PAFFKHOCLGN, bool CAKLEFCFKJE = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFJFDMFKDND(Action<T> PAFFKHOCLGN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KNCNJDFAHCK<T> : EICGMKIPLAO<Action<T>>, CBCGIDOHAHD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x30453C0", Offset = "0x30447C0", VA = "0x1830453C0")]
	public KNCNJDFAHCK(bool JKMOLGLMPBF = false, bool AOMPJALLNFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x382AD80", Offset = "0x382A180", VA = "0x18382AD80")]
	public void DFPIJIPLDKJ(T BFGAGBINHNP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37B7C10", Offset = "0x37B7010", VA = "0x1837B7C10")]
	public static KNCNJDFAHCK<T> LIGONOCHFCL(KNCNJDFAHCK<T> EPBOAADMILH, Action<T> PAFFKHOCLGN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B80", Offset = "0x37B6F80", VA = "0x1837B7B80")]
	public static KNCNJDFAHCK<T> IOMFPACHEIM(KNCNJDFAHCK<T> EPBOAADMILH, Action<T> PAFFKHOCLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GMFFDGOECDA<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LINIMCFGJKE<T, U> : EICGMKIPLAO<Action<T, U>>, GMFFDGOECDA<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x30453C0", Offset = "0x30447C0", VA = "0x1830453C0")]
	public LINIMCFGJKE(bool JKMOLGLMPBF = false, bool AOMPJALLNFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38E2370", Offset = "0x38E1770", VA = "0x1838E2370")]
	public void DFPIJIPLDKJ(T BFGAGBINHNP, U EPDKOFDFLPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37B7C10", Offset = "0x37B7010", VA = "0x1837B7C10")]
	public static LINIMCFGJKE<T, U> LIGONOCHFCL(LINIMCFGJKE<T, U> EPBOAADMILH, Action<T, U> PAFFKHOCLGN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B80", Offset = "0x37B6F80", VA = "0x1837B7B80")]
	public static LINIMCFGJKE<T, U> IOMFPACHEIM(LINIMCFGJKE<T, U> EPBOAADMILH, Action<T, U> PAFFKHOCLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class JPKJNFPNANM<T, U, V> : EICGMKIPLAO<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30453C0", Offset = "0x30447C0", VA = "0x1830453C0")]
	public JPKJNFPNANM(bool JKMOLGLMPBF = false, bool AOMPJALLNFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37B6520", Offset = "0x37B5920", VA = "0x1837B6520")]
	public void DFPIJIPLDKJ(T BFGAGBINHNP, U EPDKOFDFLPG, V JMKAEDPOKOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37B7C10", Offset = "0x37B7010", VA = "0x1837B7C10")]
	public static JPKJNFPNANM<T, U, V> LIGONOCHFCL(JPKJNFPNANM<T, U, V> EPBOAADMILH, Action<T, U, V> PAFFKHOCLGN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B80", Offset = "0x37B6F80", VA = "0x1837B7B80")]
	public static JPKJNFPNANM<T, U, V> IOMFPACHEIM(JPKJNFPNANM<T, U, V> EPBOAADMILH, Action<T, U, V> PAFFKHOCLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KGHFNILEBPF<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LFCCHOKKIBF<T, U, V, W> : EICGMKIPLAO<Action<T, U, V, W>>, KGHFNILEBPF<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x30453C0", Offset = "0x30447C0", VA = "0x1830453C0")]
	public LFCCHOKKIBF(bool JKMOLGLMPBF = false, bool AOMPJALLNFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38C2960", Offset = "0x38C1D60", VA = "0x1838C2960")]
	public void DFPIJIPLDKJ(T BFGAGBINHNP, U EPDKOFDFLPG, V JMKAEDPOKOH, W PCOIPGEOEOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37B7C10", Offset = "0x37B7010", VA = "0x1837B7C10")]
	public static LFCCHOKKIBF<T, U, V, W> LIGONOCHFCL(LFCCHOKKIBF<T, U, V, W> EPBOAADMILH, Action<T, U, V, W> PAFFKHOCLGN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B80", Offset = "0x37B6F80", VA = "0x1837B7B80")]
	public static LFCCHOKKIBF<T, U, V, W> IOMFPACHEIM(LFCCHOKKIBF<T, U, V, W> EPBOAADMILH, Action<T, U, V, W> PAFFKHOCLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KPAFAIOHNEB<T, U, V, W, X> : EICGMKIPLAO<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30453C0", Offset = "0x30447C0", VA = "0x1830453C0")]
	public KPAFAIOHNEB(bool JKMOLGLMPBF = false, bool AOMPJALLNFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3837820", Offset = "0x3836C20", VA = "0x183837820")]
	public void DFPIJIPLDKJ(T BFGAGBINHNP, U EPDKOFDFLPG, V JMKAEDPOKOH, W PCOIPGEOEOP, X DCLOFHDPPBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37B7C10", Offset = "0x37B7010", VA = "0x1837B7C10")]
	public static KPAFAIOHNEB<T, U, V, W, X> LIGONOCHFCL(KPAFAIOHNEB<T, U, V, W, X> EPBOAADMILH, Action<T, U, V, W, X> PAFFKHOCLGN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B80", Offset = "0x37B6F80", VA = "0x1837B7B80")]
	public static KPAFAIOHNEB<T, U, V, W, X> IOMFPACHEIM(KPAFAIOHNEB<T, U, V, W, X> EPBOAADMILH, Action<T, U, V, W, X> PAFFKHOCLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NHBJCHBEJPK<T, U, V, W, X, Y> : EICGMKIPLAO<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30453C0", Offset = "0x30447C0", VA = "0x1830453C0")]
	public NHBJCHBEJPK(bool JKMOLGLMPBF = false, bool AOMPJALLNFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC660", Offset = "0x3BDBA60", VA = "0x183BDC660")]
	public void DFPIJIPLDKJ(T BFGAGBINHNP, U EPDKOFDFLPG, V JMKAEDPOKOH, W PCOIPGEOEOP, X DCLOFHDPPBE, Y JMNKJKLHIOM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x37B7C10", Offset = "0x37B7010", VA = "0x1837B7C10")]
	public static NHBJCHBEJPK<T, U, V, W, X, Y> LIGONOCHFCL(NHBJCHBEJPK<T, U, V, W, X, Y> EPBOAADMILH, Action<T, U, V, W, X, Y> PAFFKHOCLGN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37B7B80", Offset = "0x37B6F80", VA = "0x1837B7B80")]
	public static NHBJCHBEJPK<T, U, V, W, X, Y> IOMFPACHEIM(NHBJCHBEJPK<T, U, V, W, X, Y> EPBOAADMILH, Action<T, U, V, W, X, Y> PAFFKHOCLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JGJMPGBLIFD<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GBCLKJPHEGN<TKey, TVal> AIBCHGEBPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> LNKKDLKOLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int GOFBNPBHCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GBCLKJPHEGN<TKey, TVal>.GPAEJOAMFAM? IODDOABDDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int LEBCOADAFBL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int HIKKDLFBIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x379F890", Offset = "0x379EC90", VA = "0x18379F890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int MEONMMKPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x379F8E0", Offset = "0x379ECE0", VA = "0x18379F8E0")]
	public JGJMPGBLIFD(int GOFBNPBHCGH, [Optional] GBCLKJPHEGN<TKey, TVal>.GPAEJOAMFAM? IODDOABDDAB, [Optional] IEqualityComparer<TKey>? CHJMBOGPJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x379F260", Offset = "0x379E660", VA = "0x18379F260")]
	public void BAHENMEPNKN(TKey IHHOPACLNAK, TVal LPCGJALKADL, bool EMHJFIIAJNG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x379F7F0", Offset = "0x379EBF0", VA = "0x18379F7F0")]
	public bool LJPEFIAAEBE(TKey IHHOPACLNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x379F710", Offset = "0x379EB10", VA = "0x18379F710")]
	public bool ICNJHDADGEL(TKey BBLOFHLNEPD, [Out] TVal LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x379F430", Offset = "0x379E830", VA = "0x18379F430")]
	private void BIKADMCCBHA(TKey IHHOPACLNAK, TVal LPCGJALKADL, int JGDHMDLNCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x379F0D0", Offset = "0x379E4D0", VA = "0x18379F0D0")]
	public bool AHJGIPMFBIN(TKey IHHOPACLNAK, TVal LPCGJALKADL, bool EMHJFIIAJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x379F650", Offset = "0x379EA50", VA = "0x18379F650")]
	private bool DAAHBNCJDPI(TKey IHHOPACLNAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public sealed class GBCLKJPHEGN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate int GPAEJOAMFAM(TKey IHHOPACLNAK, TVal LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class ICMNNEEPEOE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TKey GJLBOFLDHNC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA40000", Offset = "0xA3F400", VA = "0x180A40000")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TVal OFPAGNFLHNE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x764500", VA = "0x180765100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NLNGCCHEOCA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x76B420", Offset = "0x76A820", VA = "0x18076B420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x76BB80", Offset = "0x76AF80", VA = "0x18076BB80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DateTime DGMJKIMAECC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x767720", Offset = "0x766B20", VA = "0x180767720")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x35C2280", Offset = "0x35C1680", VA = "0x1835C2280")]
		public ICMNNEEPEOE(TKey IHHOPACLNAK, TVal FLJKEGLJDCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LMDBAIKLFIM : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public GBCLKJPHEGN<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private LinkedList<ICMNNEEPEOE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD23080", Offset = "0xD22480", VA = "0x180D23080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3919E10", Offset = "0x3919210", VA = "0x183919E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public LMDBAIKLFIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x32DE880", Offset = "0x32DDC80", VA = "0x1832DE880", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3919030", Offset = "0x3918430", VA = "0x183919030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3919C10", Offset = "0x3919010", VA = "0x183919C10")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3919D20", Offset = "0x3919120", VA = "0x183919D20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int MAINLIAGDLO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Dictionary<TKey, LinkedListNode<ICMNNEEPEOE>> OIGCGFNKDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LinkedList<ICMNNEEPEOE> LIGCACIJKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GPAEJOAMFAM? IODDOABDDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly TimeSpan IDFAEICGDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OHKOACDHKPC PFCMFFDNFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool DAHGLOJEJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<TKey> HANIIHMPDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TVal> IGMFFCGAMPG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MEONMMKPIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7815B0", Offset = "0x7809B0", VA = "0x1807815B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal int HIKKDLFBIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7815C0", Offset = "0x7809C0", VA = "0x1807815C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD1B080", Offset = "0xD1A480", VA = "0x180D1B080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x34634A0", Offset = "0x34628A0", VA = "0x1834634A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ICollection<TVal> BAJBGMLDIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x34635D0", Offset = "0x34629D0", VA = "0x1834635D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ICollection<TKey> IDictionary<TKey, TVal>.BGDFBLKBJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3460E80", Offset = "0x3460280", VA = "0x183460E80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DNCECCDBGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TVal ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3463580", Offset = "0x3462980", VA = "0x183463580", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3463680", Offset = "0x3462A80", VA = "0x183463680", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3459830", Offset = "0x3458C30", VA = "0x183459830")]
	private bool CCBPGEMOLKK(int ACGAEDNGFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x345DE70", Offset = "0x345D270", VA = "0x18345DE70")]
	private void GJLGEICHBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3462A60", Offset = "0x3461E60", VA = "0x183462A60")]
	public GBCLKJPHEGN(int ACGAEDNGFFD, [Optional] GPAEJOAMFAM? IODDOABDDAB, [Optional] IEqualityComparer<TKey>? CHJMBOGPJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34617E0", Offset = "0x3460BE0", VA = "0x1834617E0")]
	public GBCLKJPHEGN(int ACGAEDNGFFD, TimeSpan IDFAEICGDEJ, [Optional] IEqualityComparer<TKey>? CHJMBOGPJJI, [Optional] OHKOACDHKPC? PFCMFFDNFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34619A0", Offset = "0x3460DA0", VA = "0x1834619A0")]
	public GBCLKJPHEGN(int ACGAEDNGFFD, GPAEJOAMFAM? IODDOABDDAB, TimeSpan IDFAEICGDEJ, [Optional] IEqualityComparer<TKey>? CHJMBOGPJJI, [Optional] OHKOACDHKPC? PFCMFFDNFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x34597C0", Offset = "0x3458BC0", VA = "0x1834597C0")]
	public bool BEHOPCEPIKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x345D650", Offset = "0x345CA50", VA = "0x18345D650")]
	public bool FEAPAGBADGC(int JGDHMDLNCOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x345CB10", Offset = "0x345BF10", VA = "0x18345CB10")]
	public void FAJCEJLMNJF(TKey IHHOPACLNAK, TVal LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34590B0", Offset = "0x34584B0", VA = "0x1834590B0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IBHHDIJNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x34594D0", Offset = "0x34588D0", VA = "0x1834594D0", Slot = "9")]
	public void Add(TKey IHHOPACLNAK, TVal LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x345AAB0", Offset = "0x3459EB0", VA = "0x18345AAB0", Slot = "8")]
	public bool ContainsKey(TKey IHHOPACLNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x345AAB0", Offset = "0x3459EB0", VA = "0x18345AAB0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3460BC0", Offset = "0x345FFC0", VA = "0x183460BC0", Slot = "10")]
	public bool Remove(TKey IHHOPACLNAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3460B70", Offset = "0x345FF70", VA = "0x183460B70", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IBHHDIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x345FC60", Offset = "0x345F060", VA = "0x18345FC60")]
	private TVal KJBHHOOLCCM(TKey BBLOFHLNEPD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3460EE0", Offset = "0x34602E0", VA = "0x183460EE0", Slot = "11")]
	public bool TryGetValue(TKey BBLOFHLNEPD, [Out] TVal LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x345A910", Offset = "0x3459D10", VA = "0x18345A910", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x345B2A0", Offset = "0x345A6A0", VA = "0x18345B2A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FOAJABBKLPB, int MHBLGNNCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34600A0", Offset = "0x345F4A0", VA = "0x1834600A0")]
	private bool PEKNPADGDMA(ICMNNEEPEOE LKMFOLNNNCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x345F680", Offset = "0x345EA80", VA = "0x18345F680")]
	private void IPNALGMJCGB(LinkedListNode<ICMNNEEPEOE> EIFHNJKDOCF, TVal GJFJLOBMJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3459880", Offset = "0x3458C80", VA = "0x183459880")]
	private void COLCALHNJEC(TKey IHHOPACLNAK, TVal LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x345C2E0", Offset = "0x345B6E0", VA = "0x18345C2E0")]
	private void DDNHIEPLGGK(ICMNNEEPEOE LKMFOLNNNCL, TVal GJFJLOBMJBE, int OMDAPPFNPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x345E3E0", Offset = "0x345D7E0", VA = "0x18345E3E0", Slot = "19")]
	[IteratorStateMachine(typeof(GBCLKJPHEGN<, >.LMDBAIKLFIM))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3460EB0", Offset = "0x34602B0", VA = "0x183460EB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct IEJKDOPFGIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
	public static IEJKDOPFGIA MHFBJFFHDKD(Type DJMKKNDNCBM, [Optional] string? OPDHFDOOOEG, [Optional] string? GKPDDHMBHLM, bool JBFKFBLEENM = false)
	{
		return default(IEJKDOPFGIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
	public static IEJKDOPFGIA MHFBJFFHDKD<T>([Optional] string? OPDHFDOOOEG, [Optional] string? GKPDDHMBHLM, bool JBFKFBLEENM = false)
	{
		return default(IEJKDOPFGIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OPACAGJCGOO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool OEJLEAIGPKO(string FFLPEGBACAJ, OPACAGJCGOO EKMLADGAENI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int BMDIIPBLIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public string OCGDKFDKMDK;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FC30", Offset = "0x5D4F030", VA = "0x185D4FC30")]
	public static Dictionary<string, OPACAGJCGOO> FKEJEKHECOC(Type EBALPOJPFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F740", Offset = "0x5D4EB40", VA = "0x185D4F740")]
	public static Dictionary<string, OPACAGJCGOO> AHCFFLMODHM(Type EBALPOJPFMD, OEJLEAIGPKO DAHAILABAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FF60", Offset = "0x5D4F360", VA = "0x185D4FF60")]
	public static Dictionary<int, string> OFMMFAMMOFJ(Dictionary<string, OPACAGJCGOO> OFAFLOECBGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class DLNHCMPGJGB : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string LEFOCAFCCCD(string HJKKEBPEJPC);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x773100", Offset = "0x772500", VA = "0x180773100")]
	protected DLNHCMPGJGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class PGBNOEKHDBP : IEAOACDDPEG
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static bool GLCKEIABMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly string? CFHFJJPOHHD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public virtual IEAOACDDPEG? KENGCGDBOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D507D0", Offset = "0x5D4FBD0", VA = "0x185D507D0")]
	protected PGBNOEKHDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string EAPOOJKPODL();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D50120", Offset = "0x5D4F520", VA = "0x185D50120", Slot = "8")]
	public virtual string AKCGFPKIKFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D503C0", Offset = "0x5D4F7C0", VA = "0x185D503C0", Slot = "9")]
	public void MJKLOLGIFDJ(StringBuilder PNCNCDDBLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D501A0", Offset = "0x5D4F5A0", VA = "0x185D501A0", Slot = "10")]
	public void CBGPFHJHHND(StringBuilder PNCNCDDBLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D502A0", Offset = "0x5D4F6A0", VA = "0x185D502A0", Slot = "11")]
	public void GGBOOAPCLBJ(StringBuilder PNCNCDDBLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D50670", Offset = "0x5D4FA70", VA = "0x185D50670", Slot = "12")]
	public void OFGDADEGMGM(StringBuilder PNCNCDDBLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D50200", Offset = "0x5D4F600", VA = "0x185D50200")]
	public static void COPHJOHMLFM(StringBuilder PNCNCDDBLMF, string AOPEKGKJIAM, string OGNBBIDEIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50F3670", Offset = "0x50F2A70", VA = "0x1850F3670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ADKLOHEFDMC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D9D0", Offset = "0x5D4CDD0", VA = "0x185D4D9D0")]
	public ADKLOHEFDMC(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LJEMCFOHGNE<TErr> : ADKLOHEFDMC where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly TErr MNLOCHAOGIH;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x38EE680", Offset = "0x38EDA80", VA = "0x1838EE680")]
	private LJEMCFOHGNE([In] TErr GDBBPNGNPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38EE5B0", Offset = "0x38ED9B0", VA = "0x1838EE5B0")]
	public static LJEMCFOHGNE<TErr> CLFIPFKIGEN([In] TErr GDBBPNGNPHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IEAOACDDPEG
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AKCGFPKIKFG();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EAPOOJKPODL();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LAABAIKMJKH<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TOptions OFPAGNFLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BEHLPJBHOPB
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string MJFIPGHMOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KKAAHBKNANI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F1E0", Offset = "0x5D4E5E0", VA = "0x185D4F1E0")]
	public KKAAHBKNANI(string LMJAPBNMKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GEEHJCIKEBO<TOk> : KKAAHBKNANI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly TOk BOFIPMJMKLP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3469070", Offset = "0x3468470", VA = "0x183469070")]
	private GEEHJCIKEBO([In] TOk LAEPIPOLGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3468FA0", Offset = "0x34683A0", VA = "0x183468FA0")]
	public static GEEHJCIKEBO<TOk> CLFIPFKIGEN([In] TOk LAEPIPOLGMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MEEAMGFNJIM<TOk, TErr> : IEquatable<MEEAMGFNJIM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly EqualityComparer<TErr> MDLCFIPPFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal readonly TErr MNLOCHAOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly TOk BOFIPMJMKLP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool FHNCAIBFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF69A0", Offset = "0x3AF5DA0", VA = "0x183AF69A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PMKCLGPPHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5800", Offset = "0x3AF4C00", VA = "0x183AF5800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7130", Offset = "0x3AF6530", VA = "0x183AF7130")]
	internal MEEAMGFNJIM([In] TErr GDBBPNGNPHH, [In] TOk LAEPIPOLGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF58F0", Offset = "0x3AF4CF0", VA = "0x183AF58F0")]
	public static MEEAMGFNJIM<TOk, TErr> EOAIEPPKINK([In] TErr GDBBPNGNPHH)
	{
		return default(MEEAMGFNJIM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6830", Offset = "0x3AF5C30", VA = "0x183AF6830")]
	public static MEEAMGFNJIM<TOk, TErr> HDONHMNIPNG([In] TOk LAEPIPOLGMI)
	{
		return default(MEEAMGFNJIM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x21548C0", Offset = "0x2153CC0", VA = "0x1821548C0")]
	public MEEAMGFNJIM<UOk?, TErr?> JODNEDMHOBG<UOk>()
	{
		return default(MEEAMGFNJIM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2153D80", Offset = "0x2153180", VA = "0x182153D80")]
	public MEEAMGFNJIM<UOk?, TErr?> BBAJEMHOKEH<UOk>()
	{
		return default(MEEAMGFNJIM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2154580", Offset = "0x2153980", VA = "0x182154580")]
	public MEEAMGFNJIM<TOk?, UErr?> DHFPCMODOFJ<UErr>()
	{
		return default(MEEAMGFNJIM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6910", Offset = "0x3AF5D10", VA = "0x183AF6910")]
	public MEEAMGFNJIM<EOKBOBHHEEM, TErr> JBCEJIAKHNC()
	{
		return default(MEEAMGFNJIM<EOKBOBHHEEM, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3AF64F0", Offset = "0x3AF58F0", VA = "0x183AF64F0")]
	public static bool HCMKGGFOPFL([In] MEEAMGFNJIM<TOk, TErr> AHKCLAHHIPP, [In] MEEAMGFNJIM<TOk, TErr> MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5A20", Offset = "0x3AF4E20", VA = "0x183AF5A20", Slot = "4")]
	public bool Equals(MEEAMGFNJIM<TOk, TErr> KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5E10", Offset = "0x3AF5210", VA = "0x183AF5E10", Slot = "0")]
	public override bool Equals(object KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6150", Offset = "0x3AF5550", VA = "0x183AF6150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6B90", Offset = "0x3AF5F90", VA = "0x183AF6B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GFLHPJDBLOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct DBELHGHLLJP<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task<MEEAMGFNJIM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<MEEAMGFNJIM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4CDA590", Offset = "0x4CD9990", VA = "0x184CDA590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4CDABD0", Offset = "0x4CD9FD0", VA = "0x184CDABD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HJBBAAOGCKI<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TOk <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IEnumerable<MEEAMGFNJIM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IEnumerable<MEEAMGFNJIM<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<MEEAMGFNJIM<TOk, TErr>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (TOk?)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850C40", VA = "0x180851840")]
		[DebuggerHidden]
		public HJBBAAOGCKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x32DE880", Offset = "0x32DDC80", VA = "0x1832DE880", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x351EB90", Offset = "0x351DF90", VA = "0x18351EB90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x351EEC0", Offset = "0x351E2C0", VA = "0x18351EEC0")]
		private void OGHCJJGAJNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x351EFD0", Offset = "0x351E3D0", VA = "0x18351EFD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x351EF10", Offset = "0x351E310", VA = "0x18351EF10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x32E3340", Offset = "0x32E2740", VA = "0x1832E3340", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x23C28A0", Offset = "0x23C1CA0", VA = "0x1823C28A0")]
	public static MEEAMGFNJIM<TOk?, TErr?> BOFIPMJMKLP<TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [In] TOk LAEPIPOLGMI)
	{
		return default(MEEAMGFNJIM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x23C28E0", Offset = "0x23C1CE0", VA = "0x1823C28E0")]
	public static MEEAMGFNJIM<EOKBOBHHEEM, TErr?> BOFIPMJMKLP<TErr>([In] this MEEAMGFNJIM<EOKBOBHHEEM, TErr> CLFMFOEGLFG)
	{
		return default(MEEAMGFNJIM<EOKBOBHHEEM, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x23C28A0", Offset = "0x23C1CA0", VA = "0x1823C28A0")]
	public static MEEAMGFNJIM<TOk?, TErr?> MNLOCHAOGIH<TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [In] TErr GDBBPNGNPHH)
	{
		return default(MEEAMGFNJIM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x23C24B0", Offset = "0x23C18B0", VA = "0x1823C24B0")]
	public static TOk? BMHPLFIJGDD<TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x23C3210", Offset = "0x23C2610", VA = "0x1823C3210")]
	[AsyncStateMachine(typeof(DBELHGHLLJP<, >))]
	public static Task<TOk?>? FCCONEOFMKE<TOk, TErr>(this Task<MEEAMGFNJIM<TOk, TErr>> CLFMFOEGLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x23C36C0", Offset = "0x23C2AC0", VA = "0x1823C36C0")]
	public static TErr? FCGMHMFGKKC<TErr, TOk>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x23C3990", Offset = "0x23C2D90", VA = "0x1823C3990")]
	public static bool NDOFHHLEOMC<TOk, TErr, UErr, UOk>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [Out] MEEAMGFNJIM<UOk, UErr> AFNFDGOKGPN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x23C3820", Offset = "0x23C2C20", VA = "0x1823C3820")]
	public static bool MIHGIIHFBCJ<TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [Out][NotNullWhen(true)] TOk LAEPIPOLGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x23C4B00", Offset = "0x23C3F00", VA = "0x1823C4B00")]
	public static bool PEPOIAMNDOL<TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [Out][NotNullWhen(true)] TErr GDBBPNGNPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x23C4660", Offset = "0x23C3A60", VA = "0x1823C4660")]
	public static bool OPLLOGIMEDN<TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [Out][NotNullWhen(true)] TOk LAEPIPOLGMI, [Out][NotNullWhen(false)] TErr GDBBPNGNPHH) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x23C3890", Offset = "0x23C2C90", VA = "0x1823C3890")]
	public static bool MMCIKOHMBPO<TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [Out][NotNullWhen(true)] TOk LAEPIPOLGMI, [Out] MEEAMGFNJIM<TOk, TErr> AFNFDGOKGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x23C3BC0", Offset = "0x23C2FC0", VA = "0x1823C3BC0")]
	public static bool NDOFHHLEOMC<TOk, TErr, UErr, UOk>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [Out][NotNullWhen(true)] TOk LAEPIPOLGMI, [Out] MEEAMGFNJIM<UOk, UErr> AFNFDGOKGPN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x23C2A30", Offset = "0x23C1E30", VA = "0x1823C2A30")]
	public static bool DIFEODPNPGF<TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [Out][NotNullWhen(true)] TOk LAEPIPOLGMI, [Out] MEEAMGFNJIM<EOKBOBHHEEM, TErr> AFNFDGOKGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x23C3000", Offset = "0x23C2400", VA = "0x1823C3000")]
	public static MEEAMGFNJIM<UOk, UErr> EGBFFGMMPCJ<UOk, UErr, TOk, TErr>([In] this MEEAMGFNJIM<TOk, TErr> CLFMFOEGLFG, [In] MEEAMGFNJIM<UOk, UErr> JMBKGKDJDLG) where TOk : UOk where TErr : UErr
	{
		return default(MEEAMGFNJIM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x23C4750", Offset = "0x23C3B50", VA = "0x1823C4750")]
	public static MEEAMGFNJIM<TOk?[]?, TErr?> PEDHPKMIDCM<TOk, TErr>(this IEnumerable<MEEAMGFNJIM<TOk, TErr>> CLFMFOEGLFG)
	{
		return default(MEEAMGFNJIM<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x21A0AC0", Offset = "0x219FEC0", VA = "0x1821A0AC0")]
	[IteratorStateMachine(typeof(HJBBAAOGCKI<, >))]
	public static IEnumerable<TOk?>? FJMJIDICHAG<TOk, TErr>(this IEnumerable<MEEAMGFNJIM<TOk, TErr>> CLFMFOEGLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class PBKCLCBKJII<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x22FBB30", Offset = "0x22FAF30", VA = "0x1822FBB30")]
	public static MEEAMGFNJIM<TOk, T> BOFIPMJMKLP<TOk>([In] TOk LAEPIPOLGMI) where TOk : notnull
	{
		return default(MEEAMGFNJIM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3250", Offset = "0x3DA2650", VA = "0x183DA3250")]
	public static MEEAMGFNJIM<EOKBOBHHEEM, T> BOFIPMJMKLP()
	{
		return default(MEEAMGFNJIM<EOKBOBHHEEM, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x22FBB30", Offset = "0x22FAF30", VA = "0x1822FBB30")]
	public static MEEAMGFNJIM<T, TErr> MNLOCHAOGIH<TErr>([In] TErr GDBBPNGNPHH) where TErr : notnull
	{
		return default(MEEAMGFNJIM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public sealed class ACNMFPCDIDJ<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private readonly struct AKMIGIHBGFP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ACNMFPCDIDJ<T> LADLDAOEIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int OFEAGGDOJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool HJDIIPJHGFC;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1B43100", Offset = "0x1B42500", VA = "0x181B43100")]
		public AKMIGIHBGFP(ACNMFPCDIDJ<T> GHADCFDOJAA, int PKEKGNCCEKG, bool JPBJLJDFNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x35DD0F0", Offset = "0x35DC4F0", VA = "0x1835DD0F0")]
		public ACNMFPCDIDJ<T>.EJKPLGKJAJM DDJBJFDOGGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x35DD1E0", Offset = "0x35DC5E0", VA = "0x1835DD1E0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x35DD1E0", Offset = "0x35DC5E0", VA = "0x1835DD1E0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class EJKPLGKJAJM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly ACNMFPCDIDJ<T> LADLDAOEIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int MPJEBGKMJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int CDNBDAAHFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool HJDIIPJHGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool FCDPPOOCFPP;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T KCBEOJELDAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x302A400", Offset = "0x3029800", VA = "0x18302A400")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x302A560", Offset = "0x3029960", VA = "0x18302A560", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x302A7B0", Offset = "0x3029BB0", VA = "0x18302A7B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x302AAB0", Offset = "0x3029EB0", VA = "0x18302AAB0")]
		public EJKPLGKJAJM(ACNMFPCDIDJ<T> GHADCFDOJAA, int PKEKGNCCEKG, bool JPBJLJDFNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x302A330", Offset = "0x3029730", VA = "0x18302A330", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x302A4C0", Offset = "0x30298C0", VA = "0x18302A4C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FJIEPJPOICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public FJIEPJPOICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x33B77F0", Offset = "0x33B6BF0", VA = "0x1833B77F0")]
		internal T KAFCKKHAIGB(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] AHAENHLDGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int CDNBDAAHFEN;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int CBAPCPLAKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x343BF80", Offset = "0x343B380", VA = "0x18343BF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T KCBEOJELDAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x337A110", Offset = "0x3379510", VA = "0x18337A110")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T LFNJHALOMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x343C000", Offset = "0x343B400", VA = "0x18343C000")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x343BED0", Offset = "0x343B2D0", VA = "0x18343BED0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int JBNGEMMLBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x14DA1F0", Offset = "0x14D95F0", VA = "0x1814DA1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xE03C80", Offset = "0xE03080", VA = "0x180E03C80")]
	private static int NKMOOBDOOIC(int JPEMHHILGGG, int FADEBHLHEEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x343C0F0", Offset = "0x343B4F0", VA = "0x18343C0F0")]
	public ACNMFPCDIDJ(int JGDHMDLNCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x343C160", Offset = "0x343B560", VA = "0x18343C160")]
	public ACNMFPCDIDJ(int JGDHMDLNCOL, Func<T> EEAHNDADAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x343C2E0", Offset = "0x343B6E0", VA = "0x18343C2E0")]
	public ACNMFPCDIDJ(T[] COIJKGGMHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x343BFD0", Offset = "0x343B3D0", VA = "0x18343BFD0")]
	public void FEHJHHJGJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x343C030", Offset = "0x343B430", VA = "0x18343C030")]
	public IEnumerable<T> LGGFFAGCKGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x343BDA0", Offset = "0x343B1A0", VA = "0x18343BDA0")]
	public ACNMFPCDIDJ<T>.EJKPLGKJAJM DDJBJFDOGGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x340CE40", Offset = "0x340C240", VA = "0x18340CE40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x340CE40", Offset = "0x340C240", VA = "0x18340CE40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class JFFAGBDKLNM
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x240FFB0", Offset = "0x240F3B0", VA = "0x18240FFB0")]
	public static ACNMFPCDIDJ<T> CLFIPFKIGEN<T>(int JGDHMDLNCOL, Func<T> EEAHNDADAIC) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1C220E0", Offset = "0x1C214E0", VA = "0x181C220E0")]
		public RRColor(float OADEONFPOBE, float DIKCKBDFPMD, float OGHJEHJOFGN, float BOGGCLFEFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D50840", Offset = "0x5D4FC40", VA = "0x185D50840", Slot = "4")]
		public bool Equals(RRColor KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D508C0", Offset = "0x5D4FCC0", VA = "0x185D508C0", Slot = "0")]
		public override bool Equals(object KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D509C0", Offset = "0x5D4FDC0", VA = "0x185D509C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D50A40", Offset = "0x5D4FE40", VA = "0x185D50A40", Slot = "5")]
		public string ToString(string AFHDKJPDCMJ, IFormatProvider NDAHCBAINJI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class NDDAPBDFFGI<TData> : PGBNOEKHDBP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly string ALLNCMAEEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly TData GJGGJKOHCEI;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
	public override string EAPOOJKPODL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF9E0", Offset = "0x3BCEDE0", VA = "0x183BCF9E0")]
	internal NDDAPBDFFGI(string LMJAPBNMKLG, [In] TData OOIBMCBCEPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DOHMIMDENDC
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2195370", Offset = "0x2194770", VA = "0x182195370")]
	public static NDDAPBDFFGI<TData> CLFIPFKIGEN<TData>(string LMJAPBNMKLG, [In] TData OOIBMCBCEPD) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class OBMFFCJHCID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Dictionary<object, float> ABNKDGCABLG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float JFKPDAEBJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FA0", Offset = "0x8A93A0", VA = "0x1808A9FA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xBA6710", Offset = "0xBA5B10", VA = "0x180BA6710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F4A0", Offset = "0x5D4E8A0", VA = "0x185D4F4A0")]
	public void COLCALHNJEC(float LPCGJALKADL, object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F510", Offset = "0x5D4E910", VA = "0x185D4F510")]
	public void DBOPCPAFBLG(object IBLOMPOENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F580", Offset = "0x5D4E980", VA = "0x185D4F580")]
	private void JPKEBIIBDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F6B0", Offset = "0x5D4EAB0", VA = "0x185D4F6B0")]
	public OBMFFCJHCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class AFGEOAMANNM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class CIPAGLCCOFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public CIPAGLCCOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x49B35E0", Offset = "0x49B29E0", VA = "0x1849B35E0")]
		internal int FANOGKHFKPA(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<T>? PFLMOHAKNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<T> CGOFANPBFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x34ADAC0", Offset = "0x34ACEC0", VA = "0x1834ADAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool OJPBEAOHLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x34ADC60", Offset = "0x34AD060", VA = "0x1834ADC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76B440", Offset = "0x76A840", VA = "0x18076B440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x34ADAF0", Offset = "0x34ACEF0", VA = "0x1834ADAF0")]
	public bool GIHKKMKIIOJ(T IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x34ADCA0", Offset = "0x34AD0A0", VA = "0x1834ADCA0")]
	public bool HFJFDMFKDND(T IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x34ADDC0", Offset = "0x34AD1C0", VA = "0x1834ADDC0")]
	public bool KNNGDFDBEMF(T IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x34ADE00", Offset = "0x34AD200", VA = "0x1834ADE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public AFGEOAMANNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class NHAKFPLMIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly string FHLKBCJAIBI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x767650", Offset = "0x766A50", VA = "0x180767650")]
	public NHAKFPLMIPB(string FHLKBCJAIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F3D0", Offset = "0x5D4E7D0", VA = "0x185D4F3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class ILIODHAIMDL
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class MFOBHIPCBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public MFOBHIPCBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F320", Offset = "0x5D4E720", VA = "0x185D4F320")]
		internal int FANOGKHFKPA(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<object>? PFLMOHAKNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<object> CGOFANPBFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E420", Offset = "0x5D4D820", VA = "0x185D4E420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool OJPBEAOHLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E590", Offset = "0x5D4D990", VA = "0x185D4E590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x765400", Offset = "0x764800", VA = "0x180765400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76B440", Offset = "0x76A840", VA = "0x18076B440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E4B0", Offset = "0x5D4D8B0", VA = "0x185D4E4B0")]
	public bool GIHKKMKIIOJ(object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E5A0", Offset = "0x5D4D9A0", VA = "0x185D4E5A0")]
	public bool HFJFDMFKDND(object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E640", Offset = "0x5D4DA40", VA = "0x185D4E640")]
	public bool KNNGDFDBEMF(object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E6A0", Offset = "0x5D4DAA0", VA = "0x185D4E6A0")]
	public void NMNCBAEOODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E710", Offset = "0x5D4DB10", VA = "0x185D4E710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public ILIODHAIMDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class PNEIOIOPGBE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct CHOIMEHMOOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float ICBIFNOBJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public T OFPAGNFLHNE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<object, CHOIMEHMOOE> ABNKDGCABLG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual T DINBNJPIGAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD23080", Offset = "0xD22480", VA = "0x180D23080", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD21AD0", Offset = "0xD20ED0", VA = "0x180D21AD0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public object? INDABGEFELD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A830", VA = "0x18076B430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JHMBMEPFKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3E84CE0", Offset = "0x3E840E0", VA = "0x183E84CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3E84E00", Offset = "0x3E84200", VA = "0x183E84E00")]
	public bool COLCALHNJEC(T LPCGJALKADL, object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x351D2C0", Offset = "0x351C6C0", VA = "0x18351D2C0")]
	public bool DBOPCPAFBLG(object IBLOMPOENGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3E858C0", Offset = "0x3E84CC0", VA = "0x183E858C0")]
	public void OOAOJFKKMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3E85720", Offset = "0x3E84B20", VA = "0x183E85720")]
	public bool ICNJHDADGEL(object IBLOMPOENGH, [Out] T LPCGJALKADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3E865C0", Offset = "0x3E859C0", VA = "0x183E865C0")]
	[LANJOPGFCOK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OPDHELGDHHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3E86EF0", Offset = "0x3E862F0", VA = "0x183E86EF0")]
	public PNEIOIOPGBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KBEHKOHFOFA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FJAGAGNLDBF GCADDHJIFKH;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KDNDFIEIIAJ : KBEHKOHFOFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct GHKIPDJPPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public readonly float BAOPEKBBIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly float DBBNOGJCDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal readonly bool ADBIFDDOPEC;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float NLNGCCHEOCA
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5D4DD00", Offset = "0x5D4D100", VA = "0x185D4DD00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DE70", Offset = "0x5D4D270", VA = "0x185D4DE70")]
		public GHKIPDJPPNL(float CJJOHOENBLA, float KAABKEFBBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DD10", Offset = "0x5D4D110", VA = "0x185D4DD10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DGIAOBNFKLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KDNDFIEIIAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public DGIAOBNFKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DC60", Offset = "0x5D4D060", VA = "0x185D4DC60")]
		internal void INHKJCMJBAN(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly int ACGAEDNGFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int CEOCPMECDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly KBEHKOHFOFA[] EIEIEKCANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FJAGAGNLDBF[] FDEKFCDLHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GHKIPDJPPNL[] KOEGGMNELJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GHKIPDJPPNL CCFBBAMHLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly BJKFFLKACKO EGGEIBECFOH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event FJAGAGNLDBF GCADDHJIFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E8C0", Offset = "0x5D4DCC0", VA = "0x185D4E8C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4EA90", Offset = "0x5D4DE90", VA = "0x185D4EA90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F050", Offset = "0x5D4E450", VA = "0x185D4F050")]
	public KDNDFIEIIAJ(int ACGAEDNGFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EB50", Offset = "0x5D4DF50", VA = "0x185D4EB50")]
	public BJKFFLKACKO EIHBKGJBCBA(GHKIPDJPPNL DKFJHNAPKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EBE0", Offset = "0x5D4DFE0", VA = "0x185D4EBE0")]
	public void HFAMLHLOONF(KBEHKOHFOFA LJDCCMJIBBI, [Optional] GHKIPDJPPNL MBDNNGAMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E980", Offset = "0x5D4DD80", VA = "0x185D4E980", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void FJAGAGNLDBF(float MFOKJACCBFB);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GLPJIOKDMAD
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class MBJKDILJPMF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly KBEHKOHFOFA KBLNFPCANCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly FJAGAGNLDBF AIBILCAOCLG;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F290", Offset = "0x5D4E690", VA = "0x185D4F290")]
		public MBJKDILJPMF(KBEHKOHFOFA KBLNFPCANCK, FJAGAGNLDBF AIBILCAOCLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F240", Offset = "0x5D4E640", VA = "0x185D4F240", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D4DFD0", Offset = "0x5D4D3D0", VA = "0x185D4DFD0")]
	internal static bool HLNGHDNPGDH(float BOGGCLFEFDJ, float OGHJEHJOFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D46820", Offset = "0x5D45C20", VA = "0x185D46820")]
	internal static float KMLMMMBEAJH(float BOGGCLFEFDJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E040", Offset = "0x5D4D440", VA = "0x185D4E040")]
	public static IDisposable MIKFJDHNHCH(this KBEHKOHFOFA KBLNFPCANCK, FJAGAGNLDBF AIBILCAOCLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BJKFFLKACKO : KBEHKOHFOFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private float MFOKJACCBFB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float EDAFHDJGJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DAD0", Offset = "0x5D4CED0", VA = "0x185D4DAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FJAGAGNLDBF? GCADDHJIFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DA30", Offset = "0x5D4CE30", VA = "0x185D4DA30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D4DBC0", Offset = "0x5D4CFC0", VA = "0x185D4DBC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BJKFFLKACKO()
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
