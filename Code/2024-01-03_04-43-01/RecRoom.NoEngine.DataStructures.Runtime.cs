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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E946A0", Offset = "0x5E932A0", VA = "0x185E946A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class KIICBADLOIH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected KIICBADLOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CHGOCENANIB<T> : KIICBADLOIH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct PHHDIGBGOMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum HKABENBJABO
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
		public HKABENBJABO OMKEAAPIABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T GAFABDCELFL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int EDFBMPIPLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool KINHDBJGHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool GBLAFGAAKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? GCCBKGKOMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<PHHDIGBGOMF>? LAAPEPGEGFF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BGFKJMPACJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4A38D60", Offset = "0x4A37960", VA = "0x184A38D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A38DB0", Offset = "0x4A379B0", VA = "0x184A38DB0")]
	protected CHGOCENANIB(bool GBLAFGAAKDP, bool KINHDBJGHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A384D0", Offset = "0x4A370D0", VA = "0x184A384D0")]
	protected bool BAAIOLCDCGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A38A80", Offset = "0x4A37680", VA = "0x184A38A80")]
	protected void IOCFPHIHDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A38B80", Offset = "0x4A37780", VA = "0x184A38B80")]
	protected void JDOHICBJILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D2E880", Offset = "0x2D2D480", VA = "0x182D2E880")]
	private static void BKPMJPCNFCE<U>(List<U>? ALFGCABNDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A386F0", Offset = "0x4A372F0", VA = "0x184A386F0", Slot = "4")]
	public void HFMDKEOMMOI(T GAFABDCELFL, bool PKGDFPKKNIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A388D0", Offset = "0x4A374D0", VA = "0x184A388D0", Slot = "5")]
	public void IFJPOCDCFNK(T GAFABDCELFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A38570", Offset = "0x4A37170", VA = "0x184A38570")]
	public void GMINFKPEKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NNKIMJMHKEO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFMDKEOMMOI(Action GAFABDCELFL, bool PKGDFPKKNIL = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFJPOCDCFNK(Action GAFABDCELFL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class NGHNHLLDGBJ : CHGOCENANIB<Action>, NNKIMJMHKEO
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E94640", Offset = "0x5E93240", VA = "0x185E94640")]
	public NGHNHLLDGBJ(bool GBLAFGAAKDP = false, bool KINHDBJGHGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E94440", Offset = "0x5E93040", VA = "0x185E94440")]
	public void POLBKJKNIDF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E94380", Offset = "0x5E92F80", VA = "0x185E94380")]
	public static NGHNHLLDGBJ CNAFECNPDIL(NGHNHLLDGBJ HAENPCDJLNA, Action GAFABDCELFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E943E0", Offset = "0x5E92FE0", VA = "0x185E943E0")]
	public static NGHNHLLDGBJ ODFMOCCMCOB(NGHNHLLDGBJ HAENPCDJLNA, Action GAFABDCELFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NPODHBGKOII<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFMDKEOMMOI(Action<T> GAFABDCELFL, bool PKGDFPKKNIL = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFJPOCDCFNK(Action<T> GAFABDCELFL);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class LBFCDLOMLLJ<T> : CHGOCENANIB<Action<T>>, NPODHBGKOII<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x372A1C0", Offset = "0x3728DC0", VA = "0x18372A1C0")]
	public LBFCDLOMLLJ(bool GBLAFGAAKDP = false, bool KINHDBJGHGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DEF0", Offset = "0x3A2CAF0", VA = "0x183A2DEF0")]
	public void POLBKJKNIDF(T GHKAOLMKPMN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3726DB0", Offset = "0x37259B0", VA = "0x183726DB0")]
	public static LBFCDLOMLLJ<T> CNAFECNPDIL(LBFCDLOMLLJ<T> HAENPCDJLNA, Action<T> GAFABDCELFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3726E40", Offset = "0x3725A40", VA = "0x183726E40")]
	public static LBFCDLOMLLJ<T> ODFMOCCMCOB(LBFCDLOMLLJ<T> HAENPCDJLNA, Action<T> GAFABDCELFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MCAOIDGKNJJ<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CGINFNNBHBJ<T, U> : CHGOCENANIB<Action<T, U>>, MCAOIDGKNJJ<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x372A1C0", Offset = "0x3728DC0", VA = "0x18372A1C0")]
	public CGINFNNBHBJ(bool GBLAFGAAKDP = false, bool KINHDBJGHGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x496D640", Offset = "0x496C240", VA = "0x18496D640")]
	public void POLBKJKNIDF(T GHKAOLMKPMN, U NICAOJBNCFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3726DB0", Offset = "0x37259B0", VA = "0x183726DB0")]
	public static CGINFNNBHBJ<T, U> CNAFECNPDIL(CGINFNNBHBJ<T, U> HAENPCDJLNA, Action<T, U> GAFABDCELFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3726E40", Offset = "0x3725A40", VA = "0x183726E40")]
	public static CGINFNNBHBJ<T, U> ODFMOCCMCOB(CGINFNNBHBJ<T, U> HAENPCDJLNA, Action<T, U> GAFABDCELFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class AOPMODEMDFJ<T, U, V> : CHGOCENANIB<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x372A1C0", Offset = "0x3728DC0", VA = "0x18372A1C0")]
	public AOPMODEMDFJ(bool GBLAFGAAKDP = false, bool KINHDBJGHGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3729340", Offset = "0x3727F40", VA = "0x183729340")]
	public void POLBKJKNIDF(T GHKAOLMKPMN, U NICAOJBNCFG, V NDGLLLKBMIO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3726DB0", Offset = "0x37259B0", VA = "0x183726DB0")]
	public static AOPMODEMDFJ<T, U, V> CNAFECNPDIL(AOPMODEMDFJ<T, U, V> HAENPCDJLNA, Action<T, U, V> GAFABDCELFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3726E40", Offset = "0x3725A40", VA = "0x183726E40")]
	public static AOPMODEMDFJ<T, U, V> ODFMOCCMCOB(AOPMODEMDFJ<T, U, V> HAENPCDJLNA, Action<T, U, V> GAFABDCELFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LDMONKMAIJL<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MEHHDHGICNK<T, U, V, W> : CHGOCENANIB<Action<T, U, V, W>>, LDMONKMAIJL<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x372A1C0", Offset = "0x3728DC0", VA = "0x18372A1C0")]
	public MEHHDHGICNK(bool GBLAFGAAKDP = false, bool KINHDBJGHGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C81400", Offset = "0x3C80000", VA = "0x183C81400")]
	public void POLBKJKNIDF(T GHKAOLMKPMN, U NICAOJBNCFG, V NDGLLLKBMIO, W NGJMGEHADAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3726DB0", Offset = "0x37259B0", VA = "0x183726DB0")]
	public static MEHHDHGICNK<T, U, V, W> CNAFECNPDIL(MEHHDHGICNK<T, U, V, W> HAENPCDJLNA, Action<T, U, V, W> GAFABDCELFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3726E40", Offset = "0x3725A40", VA = "0x183726E40")]
	public static MEHHDHGICNK<T, U, V, W> ODFMOCCMCOB(MEHHDHGICNK<T, U, V, W> HAENPCDJLNA, Action<T, U, V, W> GAFABDCELFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class LOKDICIJBGM<T, U, V, W, X> : CHGOCENANIB<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x372A1C0", Offset = "0x3728DC0", VA = "0x18372A1C0")]
	public LOKDICIJBGM(bool GBLAFGAAKDP = false, bool KINHDBJGHGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A8BF80", Offset = "0x3A8AB80", VA = "0x183A8BF80")]
	public void POLBKJKNIDF(T GHKAOLMKPMN, U NICAOJBNCFG, V NDGLLLKBMIO, W NGJMGEHADAK, X HPIMCNPJDMN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3726DB0", Offset = "0x37259B0", VA = "0x183726DB0")]
	public static LOKDICIJBGM<T, U, V, W, X> CNAFECNPDIL(LOKDICIJBGM<T, U, V, W, X> HAENPCDJLNA, Action<T, U, V, W, X> GAFABDCELFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3726E40", Offset = "0x3725A40", VA = "0x183726E40")]
	public static LOKDICIJBGM<T, U, V, W, X> ODFMOCCMCOB(LOKDICIJBGM<T, U, V, W, X> HAENPCDJLNA, Action<T, U, V, W, X> GAFABDCELFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MGKIPCNGJDA<T, U, V, W, X, Y> : CHGOCENANIB<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x372A1C0", Offset = "0x3728DC0", VA = "0x18372A1C0")]
	public MGKIPCNGJDA(bool GBLAFGAAKDP = false, bool KINHDBJGHGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C94010", Offset = "0x3C92C10", VA = "0x183C94010")]
	public void POLBKJKNIDF(T GHKAOLMKPMN, U NICAOJBNCFG, V NDGLLLKBMIO, W NGJMGEHADAK, X HPIMCNPJDMN, Y BKLHNKCOAIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3726DB0", Offset = "0x37259B0", VA = "0x183726DB0")]
	public static MGKIPCNGJDA<T, U, V, W, X, Y> CNAFECNPDIL(MGKIPCNGJDA<T, U, V, W, X, Y> HAENPCDJLNA, Action<T, U, V, W, X, Y> GAFABDCELFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3726E40", Offset = "0x3725A40", VA = "0x183726E40")]
	public static MGKIPCNGJDA<T, U, V, W, X, Y> ODFMOCCMCOB(MGKIPCNGJDA<T, U, V, W, X, Y> HAENPCDJLNA, Action<T, U, V, W, X, Y> GAFABDCELFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AOBPHEELIHF<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LOAKNLLGOMD<TKey, TVal> LCKINNOOFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> OGGLMDJLGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int HFCIKDGJLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LOAKNLLGOMD<TKey, TVal>.JNPJEFDCGEB? EJALIHJLFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int GCMNHBKECLM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int GLBGKHABPBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37220E0", Offset = "0x3720CE0", VA = "0x1837220E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DADANDKJIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x896A30", Offset = "0x895630", VA = "0x180896A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3722130", Offset = "0x3720D30", VA = "0x183722130")]
	public AOBPHEELIHF(int HFCIKDGJLPN, [Optional] LOAKNLLGOMD<TKey, TVal>.JNPJEFDCGEB? EJALIHJLFBJ, [Optional] IEqualityComparer<TKey>? BFJKPANOANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3721CA0", Offset = "0x37208A0", VA = "0x183721CA0")]
	public void DNOPDGECJPG(TKey PPNDANAOAMK, TVal GCPEEAODAIB, bool JIAPECLNAHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3721C00", Offset = "0x3720800", VA = "0x183721C00")]
	public bool DLNKPBDIEBP(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3721E70", Offset = "0x3720A70", VA = "0x183721E70")]
	public bool IKGDLKABABA(TKey KPCNLIOCEMG, [Out] TVal GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37219E0", Offset = "0x37205E0", VA = "0x1837219E0")]
	private void DFOFMFCCBKC(TKey PPNDANAOAMK, TVal GCPEEAODAIB, int JIGGJNDJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3721F50", Offset = "0x3720B50", VA = "0x183721F50")]
	public bool INIOEIPFDMJ(TKey PPNDANAOAMK, TVal GCPEEAODAIB, bool JIAPECLNAHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3721920", Offset = "0x3720520", VA = "0x183721920")]
	private bool CIJGHMJOEGG(TKey PPNDANAOAMK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct BEFJNOBFPAB : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct PLCCLLKBGAK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
		public static PLCCLLKBGAK OOMHMBNJBCG()
		{
			return default(PLCCLLKBGAK);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
	public static BEFJNOBFPAB EPKMFHMDBBK(Type OMKEAAPIABA, [Optional] string? EOMIIHNEGNK, [Optional] string? BPHADPCEKDD, bool JKOAECMFCJG = false)
	{
		return default(BEFJNOBFPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
	public static BEFJNOBFPAB EPKMFHMDBBK<T>([Optional] string? EOMIIHNEGNK, [Optional] string? BPHADPCEKDD, bool JKOAECMFCJG = false)
	{
		return default(BEFJNOBFPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JCCJFAAJOOF
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate bool NAFNLHFBLGE(string MBOFDOHLJFE, JCCJFAAJOOF IFDPBMDGHLH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public int DACFGCGDCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public string LMBPNOJENFI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E93440", Offset = "0x5E92040", VA = "0x185E93440")]
	public static Dictionary<string, JCCJFAAJOOF> CNIMJLGHEKC(Type OMDPEHNEHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E92F50", Offset = "0x5E91B50", VA = "0x185E92F50")]
	public static Dictionary<string, JCCJFAAJOOF> ADCHJMJDLMJ(Type OMDPEHNEHJH, NAFNLHFBLGE GEGMMHMHMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E93770", Offset = "0x5E92370", VA = "0x185E93770")]
	public static Dictionary<int, string> JPLONIALJNK(Dictionary<string, JCCJFAAJOOF> NOOIIGLDGHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class OKMJFPLFEIL : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JJDHKAOFKGE(string CEMIIACNFMD);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x77FD00", VA = "0x180781100")]
	protected OKMJFPLFEIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class LGEMOLNFJEJ : KGBAABPCOOC
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static bool PEFMGGGGIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string? NDFGFFKNHFD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual KGBAABPCOOC? PMMILLKAHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E94030", Offset = "0x5E92C30", VA = "0x185E94030")]
	protected LGEMOLNFJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KDELHCHBOAN();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E93980", Offset = "0x5E92580", VA = "0x185E93980", Slot = "8")]
	public virtual string AJCFBIFLFGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E93A00", Offset = "0x5E92600", VA = "0x185E93A00", Slot = "9")]
	public void ENLBGGPJBBL(StringBuilder OEJAOEGGCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E93FD0", Offset = "0x5E92BD0", VA = "0x185E93FD0", Slot = "10")]
	public void PIMJCDOPEBH(StringBuilder OEJAOEGGCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E93EB0", Offset = "0x5E92AB0", VA = "0x185E93EB0", Slot = "11")]
	public void NNHJBIOJMMJ(StringBuilder OEJAOEGGCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E93CB0", Offset = "0x5E928B0", VA = "0x185E93CB0", Slot = "12")]
	public void MFEPGCNNJEN(StringBuilder OEJAOEGGCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E93E10", Offset = "0x5E92A10", VA = "0x185E93E10")]
	public static void NEKHNFEOMDE(StringBuilder OEJAOEGGCBJ, string INGLDIOOHII, string PHGMHOCNJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51D47D0", Offset = "0x51D33D0", VA = "0x1851D47D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IFEPJMKAKDJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E92D70", Offset = "0x5E91970", VA = "0x185E92D70")]
	public IFEPJMKAKDJ(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IIBOMHEJKJE<TErr> : IFEPJMKAKDJ where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly TErr EAAIJIJHHFI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37375A0", Offset = "0x37361A0", VA = "0x1837375A0")]
	private IIBOMHEJKJE([In] TErr DFJCJICIFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37374D0", Offset = "0x37360D0", VA = "0x1837374D0")]
	public static IIBOMHEJKJE<TErr> OOMHMBNJBCG([In] TErr DFJCJICIFFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface KGBAABPCOOC
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AJCFBIFLFGL();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KDELHCHBOAN();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OCMKLJLPPMH<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TOptions GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FBMIHGDBGPF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MAPOMEOINAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GPJLLPLMJOO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E92D10", Offset = "0x5E91910", VA = "0x185E92D10")]
	public GPJLLPLMJOO(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JOKFIOELHLJ<TOk> : GPJLLPLMJOO where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly TOk CFKJAGEPACK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x392C800", Offset = "0x392B400", VA = "0x18392C800")]
	private JOKFIOELHLJ([In] TOk EIGKKMHKJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34EDA40", Offset = "0x34EC640", VA = "0x1834EDA40")]
	public static JOKFIOELHLJ<TOk> OOMHMBNJBCG([In] TOk EIGKKMHKJGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct MEPDFJNPAPE<TOk, TErr> : IEquatable<MEPDFJNPAPE<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly EqualityComparer<TErr> BNIHLNEADFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly TErr EAAIJIJHHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal readonly TOk CFKJAGEPACK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MBNMCGJLDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3C86840", Offset = "0x3C85440", VA = "0x183C86840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CHIMLNCLBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3C86D40", Offset = "0x3C85940", VA = "0x183C86D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B6C0", Offset = "0x3C8A2C0", VA = "0x183C8B6C0")]
	internal MEPDFJNPAPE([In] TErr DFJCJICIFFI, [In] TOk EIGKKMHKJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C89B30", Offset = "0x3C88730", VA = "0x183C89B30")]
	public static MEPDFJNPAPE<TOk, TErr> JPODHJNKOAH([In] TErr DFJCJICIFFI)
	{
		return default(MEPDFJNPAPE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3C87450", Offset = "0x3C86050", VA = "0x183C87450")]
	public static MEPDFJNPAPE<TOk, TErr> EPCHKEOPPOI([In] TOk EIGKKMHKJGE)
	{
		return default(MEPDFJNPAPE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2439410", Offset = "0x2438010", VA = "0x182439410")]
	public MEPDFJNPAPE<TOk?, UErr?> BLBIAKEGLBG<UErr>()
	{
		return default(MEPDFJNPAPE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2439DC0", Offset = "0x24389C0", VA = "0x182439DC0")]
	public MEPDFJNPAPE<UOk?, TErr?> FFOKGLHFDLN<UOk>()
	{
		return default(MEPDFJNPAPE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x243A820", Offset = "0x2439420", VA = "0x18243A820")]
	public MEPDFJNPAPE<UOk?, TErr?> LLOOEKLINJM<UOk>()
	{
		return default(MEPDFJNPAPE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x243A530", Offset = "0x2439130", VA = "0x18243A530")]
	public MEPDFJNPAPE<TOk?, UErr?> IAEMGABFIAL<UErr>()
	{
		return default(MEPDFJNPAPE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3C89E90", Offset = "0x3C88A90", VA = "0x183C89E90")]
	public MEPDFJNPAPE<JNKPKLDONNF, TErr> NFJKBEOGPOG()
	{
		return default(MEPDFJNPAPE<JNKPKLDONNF, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3C89000", Offset = "0x3C87C00", VA = "0x183C89000")]
	public static bool JONBIHPGCCI([In] MEPDFJNPAPE<TOk, TErr> CNJMMNBENNL, [In] MEPDFJNPAPE<TOk, TErr> PLPCDFMLHIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3C87610", Offset = "0x3C86210", VA = "0x183C87610", Slot = "4")]
	public bool Equals(MEPDFJNPAPE<TOk, TErr> LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C876E0", Offset = "0x3C862E0", VA = "0x183C876E0", Slot = "0")]
	public override bool Equals(object LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3C88480", Offset = "0x3C87080", VA = "0x183C88480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3C8B2E0", Offset = "0x3C89EE0", VA = "0x183C8B2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KFDPCHKPIEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct BOBNDFPELID<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task<MEPDFJNPAPE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<MEPDFJNPAPE<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x467FB00", Offset = "0x467E700", VA = "0x18467FB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x467FE20", Offset = "0x467EA20", VA = "0x18467FE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KFNOFONGPAO<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TOk <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IEnumerable<MEPDFJNPAPE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IEnumerable<MEPDFJNPAPE<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IEnumerator<MEPDFJNPAPE<TOk, TErr>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (TOk?)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
		[DebuggerHidden]
		public KFNOFONGPAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3309BA0", Offset = "0x33087A0", VA = "0x183309BA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x397AF20", Offset = "0x3979B20", VA = "0x18397AF20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x397AED0", Offset = "0x3979AD0", VA = "0x18397AED0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x397B310", Offset = "0x3979F10", VA = "0x18397B310", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x397B250", Offset = "0x3979E50", VA = "0x18397B250", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x330EFE0", Offset = "0x330DBE0", VA = "0x18330EFE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x256AA90", Offset = "0x2569690", VA = "0x18256AA90")]
	public static MEPDFJNPAPE<TOk?, TErr?> CFKJAGEPACK<TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [In] TOk EIGKKMHKJGE)
	{
		return default(MEPDFJNPAPE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x256AB20", Offset = "0x2569720", VA = "0x18256AB20")]
	public static MEPDFJNPAPE<JNKPKLDONNF, TErr?> CFKJAGEPACK<TErr>([In] this MEPDFJNPAPE<JNKPKLDONNF, TErr> HHHLENOMLMP)
	{
		return default(MEPDFJNPAPE<JNKPKLDONNF, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x256AA90", Offset = "0x2569690", VA = "0x18256AA90")]
	public static MEPDFJNPAPE<TOk?, TErr?> EAAIJIJHHFI<TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [In] TErr DFJCJICIFFI)
	{
		return default(MEPDFJNPAPE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x256A600", Offset = "0x2569200", VA = "0x18256A600")]
	public static TOk? BNKEECJPIFB<TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x256ABA0", Offset = "0x25697A0", VA = "0x18256ABA0")]
	[AsyncStateMachine(typeof(BOBNDFPELID<, >))]
	public static Task<TOk?>? GODFBMBJCEB<TOk, TErr>(this Task<MEPDFJNPAPE<TOk, TErr>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2569F40", Offset = "0x2568B40", VA = "0x182569F40")]
	public static TErr? BABHCOLKOEO<TErr, TOk>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x256BAE0", Offset = "0x256A6E0", VA = "0x18256BAE0")]
	public static bool PGEMCMKKMKK<TOk, TErr, UErr, UOk>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [Out] MEPDFJNPAPE<UOk, UErr> AKNGNNDAFLJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x256B970", Offset = "0x256A570", VA = "0x18256B970")]
	public static bool OIFBGEPPIII<TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [Out][NotNullWhen(true)] TOk EIGKKMHKJGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x256AE40", Offset = "0x2569A40", VA = "0x18256AE40")]
	public static bool IICEINNECIL<TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [Out][NotNullWhen(true)] TErr DFJCJICIFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x256B480", Offset = "0x256A080", VA = "0x18256B480")]
	public static bool LFKMFPOGMKO<TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [Out][NotNullWhen(true)] TOk EIGKKMHKJGE, [Out][NotNullWhen(false)] TErr DFJCJICIFFI) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x256B9E0", Offset = "0x256A5E0", VA = "0x18256B9E0")]
	public static bool PFLOFPOBLMP<TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [Out][NotNullWhen(true)] TOk EIGKKMHKJGE, [Out] MEPDFJNPAPE<TOk, TErr> AKNGNNDAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x256BBF0", Offset = "0x256A7F0", VA = "0x18256BBF0")]
	public static bool PGEMCMKKMKK<TOk, TErr, UErr, UOk>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [Out][NotNullWhen(true)] TOk EIGKKMHKJGE, [Out] MEPDFJNPAPE<UOk, UErr> AKNGNNDAFLJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x256A2D0", Offset = "0x2568ED0", VA = "0x18256A2D0")]
	public static bool BJDMMBGPJLI<TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [Out][NotNullWhen(true)] TOk EIGKKMHKJGE, [Out] MEPDFJNPAPE<JNKPKLDONNF, TErr> AKNGNNDAFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x256B150", Offset = "0x2569D50", VA = "0x18256B150")]
	public static MEPDFJNPAPE<UOk, UErr> JHAJEEPCADN<UOk, UErr, TOk, TErr>([In] this MEPDFJNPAPE<TOk, TErr> HHHLENOMLMP, [In] MEPDFJNPAPE<UOk, UErr> IKFHEHLCJCA) where TOk : UOk where TErr : UErr
	{
		return default(MEPDFJNPAPE<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x256B570", Offset = "0x256A170", VA = "0x18256B570")]
	public static MEPDFJNPAPE<TOk?[]?, TErr?> NOJJJDKEDMM<TOk, TErr>(this IEnumerable<MEPDFJNPAPE<TOk, TErr>> HHHLENOMLMP)
	{
		return default(MEPDFJNPAPE<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x23510F0", Offset = "0x234FCF0", VA = "0x1823510F0")]
	[IteratorStateMachine(typeof(KFNOFONGPAO<, >))]
	public static IEnumerable<TOk?>? KNIFDEIHLEF<TOk, TErr>(this IEnumerable<MEPDFJNPAPE<TOk, TErr>> HHHLENOMLMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KLNAICFCEAE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x210EB30", Offset = "0x210D730", VA = "0x18210EB30")]
	public static MEPDFJNPAPE<TOk, T> CFKJAGEPACK<TOk>([In] TOk EIGKKMHKJGE) where TOk : notnull
	{
		return default(MEPDFJNPAPE<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x398CA60", Offset = "0x398B660", VA = "0x18398CA60")]
	public static MEPDFJNPAPE<JNKPKLDONNF, T> CFKJAGEPACK()
	{
		return default(MEPDFJNPAPE<JNKPKLDONNF, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x210EB30", Offset = "0x210D730", VA = "0x18210EB30")]
	public static MEPDFJNPAPE<T, TErr> EAAIJIJHHFI<TErr>([In] TErr DFJCJICIFFI) where TErr : notnull
	{
		return default(MEPDFJNPAPE<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class JACNCDGNHJM<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct IBAFHGCJAPE : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly JACNCDGNHJM<T> COHBBHAGCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int KAABDEKMMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly bool JDEPKABGNLE;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1BE4290", Offset = "0x1BE2E90", VA = "0x181BE4290")]
		public IBAFHGCJAPE(JACNCDGNHJM<T> OGDBMIPIOMM, int FABHIHODJHP, bool GEDMDCHNMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x370A450", Offset = "0x3709050", VA = "0x18370A450")]
		public JACNCDGNHJM<T>.PBOIBDNCMMI IFFPMJIPELE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x370A540", Offset = "0x3709140", VA = "0x18370A540", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x370A540", Offset = "0x3709140", VA = "0x18370A540", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class PBOIBDNCMMI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly JACNCDGNHJM<T> COHBBHAGCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly int MBPOIBAINMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int PBOAADOGOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly bool JDEPKABGNLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool PAGAOICADAG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3E92F00", Offset = "0x3E91B00", VA = "0x183E92F00")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x3E930B0", Offset = "0x3E91CB0", VA = "0x183E930B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3E93330", Offset = "0x3E91F30", VA = "0x183E93330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3E933C0", Offset = "0x3E91FC0", VA = "0x183E933C0")]
		public PBOIBDNCMMI(JACNCDGNHJM<T> OGDBMIPIOMM, int FABHIHODJHP, bool GEDMDCHNMND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E93000", Offset = "0x3E91C00", VA = "0x183E93000", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3E93090", Offset = "0x3E91C90", VA = "0x183E93090", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FFNHEFPDIJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FFNHEFPDIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x34E04A0", Offset = "0x34DF0A0", VA = "0x1834E04A0")]
		internal T JBJBGKEPCGL(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly T[] IHENKFGHONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int PBOAADOGOFH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IGOJAMKGJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x38DCA10", Offset = "0x38DB610", VA = "0x1838DCA10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T FLKMMGJNGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x34C3270", Offset = "0x34C1E70", VA = "0x1834C3270")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T ENPKBKCAFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x38DC9E0", Offset = "0x38DB5E0", VA = "0x1838DC9E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x38DC980", Offset = "0x38DB580", VA = "0x1838DC980")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HOBMJDIAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x15EBF70", Offset = "0x15EAB70", VA = "0x1815EBF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xEBF8A0", Offset = "0xEBE4A0", VA = "0x180EBF8A0")]
	private static int GNDKBOBHNAJ(int DCGGFHOCGGH, int NBJKCBMEDIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x38DCBE0", Offset = "0x38DB7E0", VA = "0x1838DCBE0")]
	public JACNCDGNHJM(int JIGGJNDJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38DCC50", Offset = "0x38DB850", VA = "0x1838DCC50")]
	public JACNCDGNHJM(int JIGGJNDJAAO, Func<T> ACJGGIDNBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38DD0F0", Offset = "0x38DBCF0", VA = "0x1838DD0F0")]
	public JACNCDGNHJM(T[] OALAPCBMCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x38DCAF0", Offset = "0x38DB6F0", VA = "0x1838DCAF0")]
	public void IMIBBBHEFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x38DCB20", Offset = "0x38DB720", VA = "0x1838DCB20")]
	public IEnumerable<T> JDJAKNLPPLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38DCA60", Offset = "0x38DB660", VA = "0x1838DCA60")]
	public JACNCDGNHJM<T>.PBOIBDNCMMI IFFPMJIPELE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3532890", Offset = "0x3531490", VA = "0x183532890", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3532890", Offset = "0x3531490", VA = "0x183532890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class GMALOAJCIKK
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x24FC440", Offset = "0x24FB040", VA = "0x1824FC440")]
	public static JACNCDGNHJM<T> OOMHMBNJBCG<T>(int JIGGJNDJAAO, Func<T> ACJGGIDNBLK) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6090", Offset = "0x1CC4C90", VA = "0x181CC6090")]
		public RRColor(float OIPEAFPNBJB, float MLIJGNHNOEI, float KNDAEONALIC, float FLGIINLNNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E947A0", Offset = "0x5E933A0", VA = "0x185E947A0", Slot = "4")]
		public bool Equals(RRColor LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E94820", Offset = "0x5E93420", VA = "0x185E94820", Slot = "0")]
		public override bool Equals(object LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E94920", Offset = "0x5E93520", VA = "0x185E94920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E949A0", Offset = "0x5E935A0", VA = "0x185E949A0", Slot = "5")]
		public string ToString(string CCDBHMCDPAB, IFormatProvider HKKKEFBFIMM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class ABHIDHIMGHP<TData> : LGEMOLNFJEJ where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly string JODIMDLOCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly TData PGHMPBDPLMA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
	public override string KDELHCHBOAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35475F0", Offset = "0x35461F0", VA = "0x1835475F0")]
	internal ABHIDHIMGHP(string EOOPGFAEMIH, [In] TData IGJLGPELHOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OIDMGGHMIEA
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E94720", Offset = "0x5E93320", VA = "0x185E94720")]
	public static ABHIDHIMGHP<JNKPKLDONNF> OOMHMBNJBCG(string EOOPGFAEMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2381150", Offset = "0x237FD50", VA = "0x182381150")]
	public static ABHIDHIMGHP<TData> OOMHMBNJBCG<TData>(string EOOPGFAEMIH, [In] TData IGJLGPELHOJ) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class CINBKAJLECK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Dictionary<object, float> AHCKPBMADJL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MLFOLAEDAND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8720A0", Offset = "0x870CA0", VA = "0x1808720A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x872140", Offset = "0x870D40", VA = "0x180872140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E918B0", Offset = "0x5E904B0", VA = "0x185E918B0")]
	public void AAADJMOHACO(float GCPEEAODAIB, object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E91A50", Offset = "0x5E90650", VA = "0x185E91A50")]
	public void PCNPPMMEDPP(object KJCAGLABEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E91920", Offset = "0x5E90520", VA = "0x185E91920")]
	private void DOHHBFMFFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E91AC0", Offset = "0x5E906C0", VA = "0x185E91AC0")]
	public CINBKAJLECK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class LAKLBFAKEHM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DJEHLBDBPHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public DJEHLBDBPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4E48890", Offset = "0x4E47490", VA = "0x184E48890")]
		internal int KBLPNELNFPF(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HashSet<T>? DDCLEMEKLPP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<T> HLMEIGFHACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A266F0", Offset = "0x3A252F0", VA = "0x183A266F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CNEPIEFKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A266B0", Offset = "0x3A252B0", VA = "0x183A266B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x77E240", Offset = "0x77CE40", VA = "0x18077E240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A26420", Offset = "0x3A25020", VA = "0x183A26420")]
	public bool HFMDKEOMMOI(T KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A26590", Offset = "0x3A25190", VA = "0x183A26590")]
	public bool IFJPOCDCFNK(T KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A263E0", Offset = "0x3A24FE0", VA = "0x183A263E0")]
	public bool EBENCGGDEAG(T KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A26720", Offset = "0x3A25320", VA = "0x183A26720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public LAKLBFAKEHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class KOHNFGELOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly string EJBAMLMGONM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public KOHNFGELOEJ(string EJBAMLMGONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E93930", Offset = "0x5E92530", VA = "0x185E93930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class FBHLHHEDNEC
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class NDIMDMEONCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NDIMDMEONCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E942D0", Offset = "0x5E92ED0", VA = "0x185E942D0")]
		internal int KBLPNELNFPF(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private HashSet<object>? DDCLEMEKLPP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<object> HLMEIGFHACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E91EE0", Offset = "0x5E90AE0", VA = "0x185E91EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CNEPIEFKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E91E60", Offset = "0x5E90A60", VA = "0x185E91E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x77E240", Offset = "0x77CE40", VA = "0x18077E240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E91CE0", Offset = "0x5E908E0", VA = "0x185E91CE0")]
	public bool HFMDKEOMMOI(object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E91DC0", Offset = "0x5E909C0", VA = "0x185E91DC0")]
	public bool IFJPOCDCFNK(object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E91C80", Offset = "0x5E90880", VA = "0x185E91C80")]
	public bool EBENCGGDEAG(object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E91E70", Offset = "0x5E90A70", VA = "0x185E91E70")]
	public void MIGJIANEPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E91F70", Offset = "0x5E90B70", VA = "0x185E91F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public FBHLHHEDNEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NMHMFCNGCHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct KNCGDJBBALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public float GIIJDHHDPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public T GMFAJOGMKIF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<object, KNCGDJBBALJ> AHCKPBMADJL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public virtual T BLLJNIFIFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xDFA010", Offset = "0xDF8C10", VA = "0x180DFA010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xDF95F0", Offset = "0xDF81F0", VA = "0x180DF95F0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public object? OKGACMAMPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool MCKGMMCJDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BDF0", Offset = "0x3D2A9F0", VA = "0x183D2BDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D29F10", Offset = "0x3D28B10", VA = "0x183D29F10")]
	public bool AAADJMOHACO(T GCPEEAODAIB, object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x39846C0", Offset = "0x39832C0", VA = "0x1839846C0")]
	public bool PCNPPMMEDPP(object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BA30", Offset = "0x3D2A630", VA = "0x183D2BA30")]
	public void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BA60", Offset = "0x3D2A660", VA = "0x183D2BA60")]
	public bool IKGDLKABABA(object KJCAGLABEME, [Out] T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A760", Offset = "0x3D29360", VA = "0x183D2A760")]
	[BNMOEEOCHBF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool EJCCBIOBMKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BE40", Offset = "0x3D2AA40", VA = "0x183D2BE40")]
	public NMHMFCNGCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EHFEOOAJECL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BDEMODOIFBD LNJALIBMOMF;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class GNDIMEMADBJ : EHFEOOAJECL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct GCKOBNMLFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly float LLDDGFIBKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly float GPGNCMFFFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal readonly bool LNBKOGHJAFI;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float JKLDCECNLBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x5E92120", Offset = "0x5E90D20", VA = "0x185E92120")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E92290", Offset = "0x5E90E90", VA = "0x185E92290")]
		public GCKOBNMLFBL(float DIOBLODNDCP, float AEFDKINALJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E92130", Offset = "0x5E90D30", VA = "0x185E92130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IGNNLIAMNHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GNDIMEMADBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IGNNLIAMNHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E92DD0", Offset = "0x5E919D0", VA = "0x185E92DD0")]
		internal void PJGFCOKBMAK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly int AAAINGBCLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private int NOHALJIPHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly EHFEOOAJECL[] NCNJCCKPOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly BDEMODOIFBD[] IENMGICDHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly GCKOBNMLFBL[] CHGKAOKJLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private GCKOBNMLFBL POACMFOOGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly LPKFHNPIOJH BCFBCGLLEJE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BDEMODOIFBD LNJALIBMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E92AC0", Offset = "0x5E916C0", VA = "0x185E92AC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E92480", Offset = "0x5E91080", VA = "0x185E92480", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E92B80", Offset = "0x5E91780", VA = "0x185E92B80")]
	public GNDIMEMADBJ(int AAAINGBCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E923F0", Offset = "0x5E90FF0", VA = "0x185E923F0")]
	public LPKFHNPIOJH BEAOILJEDBM(GCKOBNMLFBL ADDDGLKAEAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E92650", Offset = "0x5E91250", VA = "0x185E92650")]
	public void GJPFPPJPNHJ(EHFEOOAJECL MNBMNLJOONC, [Optional] GCKOBNMLFBL MOLNMPCFJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E92540", Offset = "0x5E91140", VA = "0x185E92540", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate void BDEMODOIFBD(float MLKKAHKGKMH);
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DPOOMAIGBEF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class IKHKADLIPAL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly EHFEOOAJECL EDIBOEJHACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly BDEMODOIFBD FCFEFDOJHCD;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E92EC0", Offset = "0x5E91AC0", VA = "0x185E92EC0")]
		public IKHKADLIPAL(EHFEOOAJECL EDIBOEJHACB, BDEMODOIFBD FCFEFDOJHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E92E70", Offset = "0x5E91A70", VA = "0x185E92E70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E91B50", Offset = "0x5E90750", VA = "0x185E91B50")]
	internal static bool JOECHPJAFBH(float FLGIINLNNEM, float KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E854A0", Offset = "0x5E840A0", VA = "0x185E854A0")]
	internal static float KOPFMEKHDKC(float FLGIINLNNEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E91BC0", Offset = "0x5E907C0", VA = "0x185E91BC0")]
	public static IDisposable MFMJNOMKMON(this EHFEOOAJECL EDIBOEJHACB, BDEMODOIFBD FCFEFDOJHCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class LPKFHNPIOJH : EHFEOOAJECL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private float MLKKAHKGKMH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float EJKPGHDLLAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E94140", Offset = "0x5E92D40", VA = "0x185E94140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BDEMODOIFBD? LNJALIBMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E94230", Offset = "0x5E92E30", VA = "0x185E94230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E940A0", Offset = "0x5E92CA0", VA = "0x185E940A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public LPKFHNPIOJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KBFKEHNLBMH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5A0A1A0", Offset = "0x5A08DA0", VA = "0x185A0A1A0")]
	public KBFKEHNLBMH(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class MIIJLIEJLGL<TKey, TValue> : LNOKNHKHPJI<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, GJOOOFNALCD where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class JCNGKKICCLB : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MIIJLIEJLGL<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xDFA010", Offset = "0xDF8C10", VA = "0x180DFA010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x38E7CE0", Offset = "0x38E68E0", VA = "0x1838E7CE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public JCNGKKICCLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x330F790", Offset = "0x330E390", VA = "0x18330F790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x38E70B0", Offset = "0x38E5CB0", VA = "0x1838E70B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x38E7010", Offset = "0x38E5C10", VA = "0x1838E7010")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x38E6ED0", Offset = "0x38E5AD0", VA = "0x1838E6ED0")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x38E7BF0", Offset = "0x38E67F0", VA = "0x1838E7BF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LNOKNHKHPJI<TKey, TValue> HNICPCAMJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly IDictionary<TKey, TValue> ILOHNOLAGPO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C99470", Offset = "0x3C98070", VA = "0x183C99470", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GNNIBHGIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TValue NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C99570", Offset = "0x3C98170", VA = "0x183C99570", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C997D0", Offset = "0x3C983D0", VA = "0x183C997D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public ICollection<TKey> BJKBPODNNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3C995B0", Offset = "0x3C981B0", VA = "0x183C995B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ICollection<TValue> JJJPEOBCNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C996C0", Offset = "0x3C982C0", VA = "0x183C996C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3C99220", Offset = "0x3C97E20", VA = "0x183C99220")]
	public MIIJLIEJLGL(LNOKNHKHPJI<TKey, TValue> HNICPCAMJMC, [Optional] IDictionary<TKey, TValue>? ILOHNOLAGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C96D40", Offset = "0x3C95940", VA = "0x183C96D40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C976E0", Offset = "0x3C962E0", VA = "0x183C976E0")]
	public void FCMLOGAKPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C96750", Offset = "0x3C95350", VA = "0x183C96750", Slot = "9")]
	public void Add(TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C97DE0", Offset = "0x3C969E0", VA = "0x183C97DE0")]
	public void ILKANIMFHOD(TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C96B90", Offset = "0x3C95790", VA = "0x183C96B90")]
	public void COIBHBKBDNJ(TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3C97880", Offset = "0x3C96480", VA = "0x183C97880")]
	public void GJKPLLMLAND(TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C98370", Offset = "0x3C96F70", VA = "0x183C98370")]
	public void OPMDMIPODOP(TKey PPNDANAOAMK, TValue GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3C98860", Offset = "0x3C97460", VA = "0x183C98860", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> KADOGPFLCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3C98A40", Offset = "0x3C97640", VA = "0x183C98A40", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3C98DA0", Offset = "0x3C979A0", VA = "0x183C98DA0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3C96E50", Offset = "0x3C95A50", VA = "0x183C96E50", Slot = "8")]
	public bool ContainsKey(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3C97FF0", Offset = "0x3C96BF0", VA = "0x183C97FF0")]
	public bool OFOAFOCIELI(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3C98500", Offset = "0x3C97100", VA = "0x183C98500")]
	public bool PMDNAPFAJNF(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3C985D0", Offset = "0x3C971D0", VA = "0x183C985D0", Slot = "10")]
	public bool Remove(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3C99070", Offset = "0x3C97C70", VA = "0x183C99070", Slot = "11")]
	public bool TryGetValue(TKey PPNDANAOAMK, [Out] TValue GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3C96F00", Offset = "0x3C95B00", VA = "0x183C96F00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] DAJPKFPFPMI, int DOCPNNGFPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3C98F60", Offset = "0x3C97B60", VA = "0x183C98F60", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3C97BF0", Offset = "0x3C967F0", VA = "0x183C97BF0", Slot = "19")]
	[IteratorStateMachine(typeof(MIIJLIEJLGL<, >.JCNGKKICCLB))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3C97690", Offset = "0x3C96290", VA = "0x183C97690", Slot = "21")]
	public bool EJDOKCFCLOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3C98270", Offset = "0x3C96E70", VA = "0x183C98270")]
	private TValue OMGFBAAGFKG(TKey PPNDANAOAMK)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface GJOOOFNALCD
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJDOKCFCLOI();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LNOKNHKHPJI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GJOOOFNALCD
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[DefaultMember("Item")]
public sealed class LOAKNLLGOMD<TKey, TVal> : LNOKNHKHPJI<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GJOOOFNALCD where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate int JNPJEFDCGEB(TKey PPNDANAOAMK, TVal GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class FENOBIANCMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TKey PLLFMAPAGEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB2A490", Offset = "0xB29090", VA = "0x180B2A490")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TVal GMFAJOGMKIF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x896A30", Offset = "0x895630", VA = "0x180896A30")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x896A40", Offset = "0x895640", VA = "0x180896A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int JKLDCECNLBC
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7B2640", Offset = "0x7B1240", VA = "0x1807B2640")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D20", Offset = "0x7B0920", VA = "0x1807B1D20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public DateTimeOffset NIMCEFHFDGH
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x9FCA80", Offset = "0x9FB680", VA = "0x1809FCA80")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1227800", Offset = "0x1226400", VA = "0x181227800")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x34CF4A0", Offset = "0x34CE0A0", VA = "0x1834CF4A0")]
		public FENOBIANCMK(TKey PPNDANAOAMK, TVal FEGNLFKFNHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PEALCBBGKDC : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public LOAKNLLGOMD<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private LinkedList<FENOBIANCMK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xDFA010", Offset = "0xDF8C10", VA = "0x180DFA010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3E98FF0", Offset = "0x3E97BF0", VA = "0x183E98FF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public PEALCBBGKDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3309BA0", Offset = "0x33087A0", VA = "0x183309BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3E97FD0", Offset = "0x3E96BD0", VA = "0x183E97FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3E96760", Offset = "0x3E95360", VA = "0x183E96760")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3E98F50", Offset = "0x3E97B50", VA = "0x183E98F50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const int OCGNGMMKJGH = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Dictionary<TKey, LinkedListNode<FENOBIANCMK>> KLGHILNPGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly LinkedList<FENOBIANCMK> OFIALFMCKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly JNPJEFDCGEB? EJALIHJLFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly TimeSpan LHBPFOAGPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NMDJAPLLCLI ALHFBCJMJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool EGLIIMDOJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly List<TKey> KADDAODBFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly List<TVal> MEJIJNCAOMH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int DADANDKJIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x78F560", Offset = "0x78E160", VA = "0x18078F560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	internal int GLBGKHABPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x78F570", Offset = "0x78E170", VA = "0x18078F570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xDF2BB0", Offset = "0xDF17B0", VA = "0x180DF2BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3A80510", Offset = "0x3A7F110", VA = "0x183A80510", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int GHLMLHCPJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x358DE60", Offset = "0x358CA60", VA = "0x18358DE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> JJJPEOBCNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3A80640", Offset = "0x3A7F240", VA = "0x183A80640", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ICollection<TKey> IDictionary<TKey, TVal>.BPGKGABHGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3A7DA20", Offset = "0x3A7C620", VA = "0x183A7DA20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool GNNIBHGIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public TVal NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3A805A0", Offset = "0x3A7F1A0", VA = "0x183A805A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3A80690", Offset = "0x3A7F290", VA = "0x183A80690", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B020", Offset = "0x3A79C20", VA = "0x183A7B020")]
	private bool JNIHJHPLDKJ(int AAAINGBCLDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A7CBA0", Offset = "0x3A7B7A0", VA = "0x183A7CBA0")]
	private void PJFMIBGFBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F210", Offset = "0x3A7DE10", VA = "0x183A7F210")]
	public LOAKNLLGOMD(int AAAINGBCLDC, [Optional] JNPJEFDCGEB? EJALIHJLFBJ, [Optional] IEqualityComparer<TKey>? BFJKPANOANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EF50", Offset = "0x3A7DB50", VA = "0x183A7EF50")]
	public LOAKNLLGOMD(TimeSpan LHBPFOAGPJC, [Optional] IEqualityComparer<TKey>? BFJKPANOANO, [Optional] NMDJAPLLCLI? ALHFBCJMJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EF90", Offset = "0x3A7DB90", VA = "0x183A7EF90")]
	public LOAKNLLGOMD(int AAAINGBCLDC, TimeSpan LHBPFOAGPJC, [Optional] IEqualityComparer<TKey>? BFJKPANOANO, [Optional] NMDJAPLLCLI? ALHFBCJMJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F2D0", Offset = "0x3A7DED0", VA = "0x183A7F2D0")]
	public LOAKNLLGOMD(int AAAINGBCLDC, JNPJEFDCGEB? EJALIHJLFBJ, TimeSpan LHBPFOAGPJC, [Optional] IEqualityComparer<TKey>? BFJKPANOANO, [Optional] NMDJAPLLCLI? ALHFBCJMJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3A788C0", Offset = "0x3A774C0", VA = "0x183A788C0", Slot = "21")]
	public bool EJDOKCFCLOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C350", Offset = "0x3A7AF50", VA = "0x183A7C350", Slot = "22")]
	public bool LJEPEFHOIHA(int JIGGJNDJAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3A7BD40", Offset = "0x3A7A940", VA = "0x183A7BD40")]
	private bool KKJFOMDKCAG(int JIGGJNDJAAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3A7A670", Offset = "0x3A79270", VA = "0x183A7A670")]
	public void INLCAGHFLDH(TKey PPNDANAOAMK, TVal GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3A75F20", Offset = "0x3A74B20", VA = "0x183A75F20", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KADOGPFLCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3A758A0", Offset = "0x3A744A0", VA = "0x183A758A0", Slot = "9")]
	public void Add(TKey PPNDANAOAMK, TVal GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3A77150", Offset = "0x3A75D50", VA = "0x183A77150", Slot = "8")]
	public bool ContainsKey(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D170", Offset = "0x3A7BD70", VA = "0x183A7D170", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D0F0", Offset = "0x3A7BCF0", VA = "0x183A7D0F0", Slot = "10")]
	public bool Remove(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3A7D7E0", Offset = "0x3A7C3E0", VA = "0x183A7D7E0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C810", Offset = "0x3A7B410", VA = "0x183A7C810")]
	private bool MOLCOPJNLBD(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3A7AC40", Offset = "0x3A79840", VA = "0x183A7AC40")]
	private TVal IOOJPMIEEDI(TKey KPCNLIOCEMG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DC50", Offset = "0x3A7C850", VA = "0x183A7DC50", Slot = "11")]
	public bool TryGetValue(TKey KPCNLIOCEMG, [Out] TVal GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3A76F70", Offset = "0x3A75B70", VA = "0x183A76F70", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3A77B70", Offset = "0x3A76770", VA = "0x183A77B70", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DAJPKFPFPMI, int DOCPNNGFPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3A7B4F0", Offset = "0x3A7A0F0", VA = "0x183A7B4F0")]
	private bool KBDEHGPFOON(FENOBIANCMK CIGJCLPPABB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3A79060", Offset = "0x3A77C60", VA = "0x183A79060")]
	private void EPHPLKKHOGB(LinkedListNode<FENOBIANCMK> BCOBMBJEDAH, TVal CGEKFJOFDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3A74AF0", Offset = "0x3A736F0", VA = "0x183A74AF0")]
	private void AAADJMOHACO(TKey PPNDANAOAMK, TVal GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3A767F0", Offset = "0x3A753F0", VA = "0x183A767F0")]
	private void CDGPKEPGECO(FENOBIANCMK CIGJCLPPABB, TVal CGEKFJOFDCO, int ACOMFCEADLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3A7A2F0", Offset = "0x3A78EF0", VA = "0x183A7A2F0", Slot = "19")]
	[IteratorStateMachine(typeof(LOAKNLLGOMD<, >.PEALCBBGKDC))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DA50", Offset = "0x3A7C650", VA = "0x183A7DA50", Slot = "20")]
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
