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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6261D80", Offset = "0x6261180", VA = "0x186261D80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class APFHPAENIBE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected APFHPAENIBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KPHJFECGKAB<T> : APFHPAENIBE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct DIPIOBPLNBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum DKGLOGNNPEO
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
		public DKGLOGNNPEO NBMJAHOKHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T PNAPELFIIEJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int ILGCCNBMGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool MHDLFLJBKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool ACDMHOMGAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? GBBPFEMDMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<DIPIOBPLNBK>? KLBJNBHLEGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HABIMFAENAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C85C90", Offset = "0x3C85090", VA = "0x183C85C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C860B0", Offset = "0x3C854B0", VA = "0x183C860B0")]
	protected KPHJFECGKAB(bool ACDMHOMGAMG, bool MHDLFLJBKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C86010", Offset = "0x3C85410", VA = "0x183C86010")]
	protected bool PIOACAHAGKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C859B0", Offset = "0x3C84DB0", VA = "0x183C859B0")]
	protected void EIIMBIGIEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C857D0", Offset = "0x3C84BD0", VA = "0x183C857D0")]
	protected void BBAEEDFKANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x271C600", Offset = "0x271BA00", VA = "0x18271C600")]
	private static void DMEHPEMINGI<U>(List<U>? OCAIIBKPIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C85AB0", Offset = "0x3C84EB0", VA = "0x183C85AB0", Slot = "4")]
	public void FFIECPFJEFG(T PNAPELFIIEJ, bool HJALNEICDKE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C85E60", Offset = "0x3C85260", VA = "0x183C85E60", Slot = "5")]
	public void PIABDNKCBCD(T PNAPELFIIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C85CE0", Offset = "0x3C850E0", VA = "0x183C85CE0")]
	public void OIGNPMFKFFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JAACPONGCKD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFIECPFJEFG(Action PNAPELFIIEJ, bool HJALNEICDKE = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIABDNKCBCD(Action PNAPELFIIEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DGHHAMKHKGM : KPHJFECGKAB<Action>, JAACPONGCKD
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x625FE50", Offset = "0x625F250", VA = "0x18625FE50")]
	public DGHHAMKHKGM(bool ACDMHOMGAMG = false, bool MHDLFLJBKCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x625FB90", Offset = "0x625EF90", VA = "0x18625FB90")]
	public void CAFHCMPOKLC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x625FDF0", Offset = "0x625F1F0", VA = "0x18625FDF0")]
	public static DGHHAMKHKGM LDGADLBOPAE(DGHHAMKHKGM NEEGDECIEEF, Action PNAPELFIIEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x625FD90", Offset = "0x625F190", VA = "0x18625FD90")]
	public static DGHHAMKHKGM KEAKECAEBKE(DGHHAMKHKGM NEEGDECIEEF, Action PNAPELFIIEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CCKHPDPKKHP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFIECPFJEFG(Action<T> PNAPELFIIEJ, bool HJALNEICDKE = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIABDNKCBCD(Action<T> PNAPELFIIEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class JGNHMIKEILN<T> : KPHJFECGKAB<Action<T>>, CCKHPDPKKHP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x336E730", Offset = "0x336DB30", VA = "0x18336E730")]
	public JGNHMIKEILN(bool ACDMHOMGAMG = false, bool MHDLFLJBKCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F330", Offset = "0x3B9E730", VA = "0x183B9F330")]
	public void CAFHCMPOKLC(T PLGHLMOEPOB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x336E6A0", Offset = "0x336DAA0", VA = "0x18336E6A0")]
	public static JGNHMIKEILN<T> LDGADLBOPAE(JGNHMIKEILN<T> NEEGDECIEEF, Action<T> PNAPELFIIEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x336E610", Offset = "0x336DA10", VA = "0x18336E610")]
	public static JGNHMIKEILN<T> KEAKECAEBKE(JGNHMIKEILN<T> NEEGDECIEEF, Action<T> PNAPELFIIEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FOGFBNFBAED<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CNCBMPDPOAH<T, U> : KPHJFECGKAB<Action<T, U>>, FOGFBNFBAED<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x336E730", Offset = "0x336DB30", VA = "0x18336E730")]
	public CNCBMPDPOAH(bool ACDMHOMGAMG = false, bool MHDLFLJBKCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4CB54D0", Offset = "0x4CB48D0", VA = "0x184CB54D0")]
	public void CAFHCMPOKLC(T PLGHLMOEPOB, U OOAKLKDADOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x336E6A0", Offset = "0x336DAA0", VA = "0x18336E6A0")]
	public static CNCBMPDPOAH<T, U> LDGADLBOPAE(CNCBMPDPOAH<T, U> NEEGDECIEEF, Action<T, U> PNAPELFIIEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x336E610", Offset = "0x336DA10", VA = "0x18336E610")]
	public static CNCBMPDPOAH<T, U> KEAKECAEBKE(CNCBMPDPOAH<T, U> NEEGDECIEEF, Action<T, U> PNAPELFIIEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class APBODAALHDH<T, U, V> : KPHJFECGKAB<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x336E730", Offset = "0x336DB30", VA = "0x18336E730")]
	public APBODAALHDH(bool ACDMHOMGAMG = false, bool MHDLFLJBKCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A27060", Offset = "0x3A26460", VA = "0x183A27060")]
	public void CAFHCMPOKLC(T PLGHLMOEPOB, U OOAKLKDADOF, V FHKCANODEBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x336E6A0", Offset = "0x336DAA0", VA = "0x18336E6A0")]
	public static APBODAALHDH<T, U, V> LDGADLBOPAE(APBODAALHDH<T, U, V> NEEGDECIEEF, Action<T, U, V> PNAPELFIIEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x336E610", Offset = "0x336DA10", VA = "0x18336E610")]
	public static APBODAALHDH<T, U, V> KEAKECAEBKE(APBODAALHDH<T, U, V> NEEGDECIEEF, Action<T, U, V> PNAPELFIIEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ONMAMMLAMEK<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ENGGJBLHHCL<T, U, V, W> : KPHJFECGKAB<Action<T, U, V, W>>, ONMAMMLAMEK<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x336E730", Offset = "0x336DB30", VA = "0x18336E730")]
	public ENGGJBLHHCL(bool ACDMHOMGAMG = false, bool MHDLFLJBKCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x336DB10", Offset = "0x336CF10", VA = "0x18336DB10")]
	public void CAFHCMPOKLC(T PLGHLMOEPOB, U OOAKLKDADOF, V FHKCANODEBA, W HIJJEKIGNJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x336E6A0", Offset = "0x336DAA0", VA = "0x18336E6A0")]
	public static ENGGJBLHHCL<T, U, V, W> LDGADLBOPAE(ENGGJBLHHCL<T, U, V, W> NEEGDECIEEF, Action<T, U, V, W> PNAPELFIIEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x336E610", Offset = "0x336DA10", VA = "0x18336E610")]
	public static ENGGJBLHHCL<T, U, V, W> KEAKECAEBKE(ENGGJBLHHCL<T, U, V, W> NEEGDECIEEF, Action<T, U, V, W> PNAPELFIIEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HNFBBNLKHDJ<T, U, V, W, X> : KPHJFECGKAB<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x336E730", Offset = "0x336DB30", VA = "0x18336E730")]
	public HNFBBNLKHDJ(bool ACDMHOMGAMG = false, bool MHDLFLJBKCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x387CD10", Offset = "0x387C110", VA = "0x18387CD10")]
	public void CAFHCMPOKLC(T PLGHLMOEPOB, U OOAKLKDADOF, V FHKCANODEBA, W HIJJEKIGNJP, X LCKGOLLEJPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x336E6A0", Offset = "0x336DAA0", VA = "0x18336E6A0")]
	public static HNFBBNLKHDJ<T, U, V, W, X> LDGADLBOPAE(HNFBBNLKHDJ<T, U, V, W, X> NEEGDECIEEF, Action<T, U, V, W, X> PNAPELFIIEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x336E610", Offset = "0x336DA10", VA = "0x18336E610")]
	public static HNFBBNLKHDJ<T, U, V, W, X> KEAKECAEBKE(HNFBBNLKHDJ<T, U, V, W, X> NEEGDECIEEF, Action<T, U, V, W, X> PNAPELFIIEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class HINNBNGCOKD<T, U, V, W, X, Y> : KPHJFECGKAB<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x336E730", Offset = "0x336DB30", VA = "0x18336E730")]
	public HINNBNGCOKD(bool ACDMHOMGAMG = false, bool MHDLFLJBKCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3866590", Offset = "0x3865990", VA = "0x183866590")]
	public void CAFHCMPOKLC(T PLGHLMOEPOB, U OOAKLKDADOF, V FHKCANODEBA, W HIJJEKIGNJP, X LCKGOLLEJPE, Y OHIBEIOBHMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x336E6A0", Offset = "0x336DAA0", VA = "0x18336E6A0")]
	public static HINNBNGCOKD<T, U, V, W, X, Y> LDGADLBOPAE(HINNBNGCOKD<T, U, V, W, X, Y> NEEGDECIEEF, Action<T, U, V, W, X, Y> PNAPELFIIEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x336E610", Offset = "0x336DA10", VA = "0x18336E610")]
	public static HINNBNGCOKD<T, U, V, W, X, Y> KEAKECAEBKE(HINNBNGCOKD<T, U, V, W, X, Y> NEEGDECIEEF, Action<T, U, V, W, X, Y> PNAPELFIIEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GPCBOCFDAGA<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NCDJKCDGAPJ<TKey, TVal> EIKJENDCMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> GJCGGLCJDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NCDJKCDGAPJ<TKey, TVal>.FLFIHBFOHLL? ENCKFHNDKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int DDHKDODMNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NCDJKCDGAPJ<TKey, TVal>.NNNDADIIMDB? DOLDFADIPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int JLKGPLFNAEN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int AJEKEKJMGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37F2B50", Offset = "0x37F1F50", VA = "0x1837F2B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FBEDICLDNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C6760", Offset = "0x7C5B60", VA = "0x1807C6760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x37F3AF0", Offset = "0x37F2EF0", VA = "0x1837F3AF0")]
	public GPCBOCFDAGA(int DDHKDODMNDI, [Optional] NCDJKCDGAPJ<TKey, TVal>.NNNDADIIMDB? DOLDFADIPOC, [Optional] IEqualityComparer<TKey>? BAJLOCKCJKC, [Optional] NCDJKCDGAPJ<TKey, TVal>.FLFIHBFOHLL? ENCKFHNDKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37F33C0", Offset = "0x37F27C0", VA = "0x1837F33C0")]
	public void JKMLBOHMCPF(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN, bool DDEAMEALCCJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x37F30C0", Offset = "0x37F24C0", VA = "0x1837F30C0")]
	public bool FDALFONIJNI(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37F32E0", Offset = "0x37F26E0", VA = "0x1837F32E0")]
	public bool JFDMGELHHBG(TKey DDKLCIAKGKD, [Out] TVal PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37F2D30", Offset = "0x37F2130", VA = "0x1837F2D30")]
	private void DPLCANKAIIF(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN, int HIAJHKACHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37F2BA0", Offset = "0x37F1FA0", VA = "0x1837F2BA0")]
	public bool CEAEODMJGMA(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN, bool DDEAMEALCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37F3A90", Offset = "0x37F2E90", VA = "0x1837F3A90")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37F3590", Offset = "0x37F2990", VA = "0x1837F3590")]
	private void OHIONICGIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37F31F0", Offset = "0x37F25F0", VA = "0x1837F31F0")]
	private bool HDHGPNFBODC(TKey NIOPCMHKLMB, KKJMHKEDGAE HOKIEGJILGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x37F2A70", Offset = "0x37F1E70", VA = "0x1837F2A70")]
	private void AKPHKELMGPP(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN, KKJMHKEDGAE HOKIEGJILGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37F2F90", Offset = "0x37F2390", VA = "0x1837F2F90")]
	private void FAMFJCKKMJI(TKey NIOPCMHKLMB, TVal FNMPHGMIIBA, KKJMHKEDGAE HOKIEGJILGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PLODKGKCBME : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action LKNMBJDEEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NJCCKMPDCLF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public PLODKGKCBME(Action JDBCMGBJBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62626B0", Offset = "0x6261AB0", VA = "0x1862626B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2662B80", Offset = "0x2661F80", VA = "0x182662B80")]
	public static FIOJPADPCHG<T> HEJOOLMEDMH<T>(T PCGOHCLJAPN, Action JDBCMGBJBOP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class FIOJPADPCHG<T> : PLODKGKCBME where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36E6890", Offset = "0x36E5C90", VA = "0x1836E6890")]
	public FIOJPADPCHG(T PCGOHCLJAPN, Action JDBCMGBJBOP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LKGPDLCIFPA : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct OOFBIAGDMLM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
		public static OOFBIAGDMLM HGJFOBLHCKL()
		{
			return default(OOFBIAGDMLM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	public static LKGPDLCIFPA LIODGANGHEE(Type NBMJAHOKHAI, [Optional] string? MMLABBDPBMJ, [Optional] string? OPIFBHEKMPK, bool GPPGIEAFGGK = false)
	{
		return default(LKGPDLCIFPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	public static LKGPDLCIFPA LIODGANGHEE<T>([Optional] string? MMLABBDPBMJ, [Optional] string? OPIFBHEKMPK, bool GPPGIEAFGGK = false)
	{
		return default(LKGPDLCIFPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OKLHFKFOADE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool PEMDFPJJFIF(string ANDDHGEMHEO, OKLHFKFOADE HLFDNOBHJJM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int EKIHNFGMJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string BGFJLDNDGID;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6261FC0", Offset = "0x62613C0", VA = "0x186261FC0")]
	public static Dictionary<string, OKLHFKFOADE> HJMPENKLEPN(Type KNAMCLAGDFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62622F0", Offset = "0x62616F0", VA = "0x1862622F0")]
	public static Dictionary<string, OKLHFKFOADE> IGFOOHLGHKL(Type KNAMCLAGDFP, PEMDFPJJFIF EPCELIBGLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6261E00", Offset = "0x6261200", VA = "0x186261E00")]
	public static Dictionary<int, string> BKNDCMKOIEI(Dictionary<string, OKLHFKFOADE> CNGBAHCAJJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class FEBGENKADMF : BJDMIMOJLDG
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool DFNHBPJKJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string? FAOPDJHKHAP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual BJDMIMOJLDG? GIEPOKEEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x62605C0", Offset = "0x625F9C0", VA = "0x1862605C0")]
	protected FEBGENKADMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string PEMDIIHBGJG();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x625FFB0", Offset = "0x625F3B0", VA = "0x18625FFB0", Slot = "8")]
	public virtual string HEMALIDDBKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6260030", Offset = "0x625F430", VA = "0x186260030", Slot = "9")]
	public void IFMKHHBNGJP(StringBuilder KABKPHOILKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6260440", Offset = "0x625F840", VA = "0x186260440", Slot = "10")]
	public void KGNDBKGIIAO(StringBuilder KABKPHOILKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x62604A0", Offset = "0x625F8A0", VA = "0x1862604A0", Slot = "11")]
	public void NDNCHMHECHN(StringBuilder KABKPHOILKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62602E0", Offset = "0x625F6E0", VA = "0x1862602E0", Slot = "12")]
	public void IICEHJFIGIF(StringBuilder KABKPHOILKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x625FF10", Offset = "0x625F310", VA = "0x18625FF10")]
	public static void DGEJOKPBOIF(StringBuilder KABKPHOILKN, string HPHDAMOIBID, string OCBMIMEPODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x54C2990", Offset = "0x54C1D90", VA = "0x1854C2990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EDDDIFHCACD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x625FEB0", Offset = "0x625F2B0", VA = "0x18625FEB0")]
	public EDDDIFHCACD(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JGMMJNAIEDH<TErr> : EDDDIFHCACD where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TErr DFOIDHAJHGC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D100", Offset = "0x3B9C500", VA = "0x183B9D100")]
	private JGMMJNAIEDH([In] TErr PPIEBDADPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D030", Offset = "0x3B9C430", VA = "0x183B9D030")]
	public static JGMMJNAIEDH<TErr> HGJFOBLHCKL([In] TErr PPIEBDADPEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BJDMIMOJLDG
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HEMALIDDBKK();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PEMDIIHBGJG();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MCCNDIKFMEH<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FKFMAPIPHGH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string HPPEHAGNNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LEDDNKEPKBE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6261490", Offset = "0x6260890", VA = "0x186261490")]
	public LEDDNKEPKBE(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DNPBFAHKBLO<TOk> : LEDDNKEPKBE where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TOk AANCFCOMFCB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x50FF080", Offset = "0x50FE480", VA = "0x1850FF080")]
	private DNPBFAHKBLO([In] TOk LNFDBCMKMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x37C9700", Offset = "0x37C8B00", VA = "0x1837C9700")]
	public static DNPBFAHKBLO<TOk> HGJFOBLHCKL([In] TOk LNFDBCMKMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct OJIJNKCPBAD<TOk, TErr> : IEquatable<OJIJNKCPBAD<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly EqualityComparer<TErr> PLODHAOJCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TErr DFOIDHAJHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TOk AANCFCOMFCB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PMDKOKNLEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x40E0830", Offset = "0x40DFC30", VA = "0x1840E0830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OOKMHPPMELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x40E0AD0", Offset = "0x40DFED0", VA = "0x1840E0AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x40E0D70", Offset = "0x40E0170", VA = "0x1840E0D70")]
	internal OJIJNKCPBAD([In] TErr PPIEBDADPEO, [In] TOk LNFDBCMKMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x40E0570", Offset = "0x40DF970", VA = "0x1840E0570")]
	public static OJIJNKCPBAD<TOk, TErr> ECLKKIMKAJB([In] TErr PPIEBDADPEO)
	{
		return default(OJIJNKCPBAD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x40E0460", Offset = "0x40DF860", VA = "0x1840E0460")]
	public static OJIJNKCPBAD<TOk, TErr> CMKEJFIKAFP([In] TOk LNFDBCMKMAF)
	{
		return default(OJIJNKCPBAD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2727400", Offset = "0x2726800", VA = "0x182727400")]
	public OJIJNKCPBAD<TOk?, UErr?> NIMILMLBPKD<UErr>()
	{
		return default(OJIJNKCPBAD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27270D0", Offset = "0x27264D0", VA = "0x1827270D0")]
	public OJIJNKCPBAD<UOk?, TErr?> IHCJFPOMHIH<UOk>()
	{
		return default(OJIJNKCPBAD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2728380", Offset = "0x2727780", VA = "0x182728380")]
	public OJIJNKCPBAD<UOk?, TErr?> OCALDBMJODF<UOk>()
	{
		return default(OJIJNKCPBAD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2726A70", Offset = "0x2725E70", VA = "0x182726A70")]
	public OJIJNKCPBAD<TOk?, UErr?> FAICCLEOKIL<UErr>()
	{
		return default(OJIJNKCPBAD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x40E04E0", Offset = "0x40DF8E0", VA = "0x1840E04E0")]
	public OJIJNKCPBAD<GLCFOAMDFIN, TErr> DAHGBINCBPG()
	{
		return default(OJIJNKCPBAD<GLCFOAMDFIN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x40E09A0", Offset = "0x40DFDA0", VA = "0x1840E09A0")]
	public static bool IDILALBKFJC([In] OJIJNKCPBAD<TOk, TErr> OOGPCKEGMIK, [In] OJIJNKCPBAD<TOk, TErr> NPEJHBIFPCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x40E05D0", Offset = "0x40DF9D0", VA = "0x1840E05D0", Slot = "4")]
	public bool Equals(OJIJNKCPBAD<TOk, TErr> MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x40E06A0", Offset = "0x40DFAA0", VA = "0x1840E06A0", Slot = "0")]
	public override bool Equals(object MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x40E08F0", Offset = "0x40DFCF0", VA = "0x1840E08F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x40E0B60", Offset = "0x40DFF60", VA = "0x1840E0B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LOEIEALPDHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct ACONELMCDAO<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Task<OJIJNKCPBAD<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<OJIJNKCPBAD<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x377CB00", Offset = "0x377BF00", VA = "0x18377CB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x377D140", Offset = "0x377C540", VA = "0x18377D140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x28923F0", Offset = "0x28917F0", VA = "0x1828923F0")]
	public static OJIJNKCPBAD<TOk?, TErr?> AANCFCOMFCB<TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [In] TOk LNFDBCMKMAF)
	{
		return default(OJIJNKCPBAD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2892480", Offset = "0x2891880", VA = "0x182892480")]
	public static OJIJNKCPBAD<GLCFOAMDFIN, TErr?> AANCFCOMFCB<TErr>([In] this OJIJNKCPBAD<GLCFOAMDFIN, TErr> MEEBIDIALDO)
	{
		return default(OJIJNKCPBAD<GLCFOAMDFIN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x28923F0", Offset = "0x28917F0", VA = "0x1828923F0")]
	public static OJIJNKCPBAD<TOk?, TErr?> DFOIDHAJHGC<TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [In] TErr PPIEBDADPEO)
	{
		return default(OJIJNKCPBAD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x28939E0", Offset = "0x2892DE0", VA = "0x1828939E0")]
	public static TOk? IBELCJCPOHO<TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2892640", Offset = "0x2891A40", VA = "0x182892640")]
	[AsyncStateMachine(typeof(ACONELMCDAO<, >))]
	public static Task<TOk?>? BKOPEFAONLN<TOk, TErr>(this Task<OJIJNKCPBAD<TOk, TErr>> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2894D10", Offset = "0x2894110", VA = "0x182894D10")]
	public static TErr? MFNNDKENBFC<TErr, TOk>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x28928E0", Offset = "0x2891CE0", VA = "0x1828928E0")]
	public static bool DAONPJLPNPC<TOk, TErr, UErr, UOk>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [Out] OJIJNKCPBAD<UOk, UErr> MLLGDGAHJBO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2894B00", Offset = "0x2893F00", VA = "0x182894B00")]
	public static bool KKMJOKAEMEA<TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [Out][NotNullWhen(true)] TOk LNFDBCMKMAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2895080", Offset = "0x2894480", VA = "0x182895080")]
	public static bool OKPLIPDOGLM<TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [Out][NotNullWhen(true)] TErr PPIEBDADPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2894B70", Offset = "0x2893F70", VA = "0x182894B70")]
	public static bool LEDNPDJKPGH<TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [Out][NotNullWhen(true)] TOk LNFDBCMKMAF, [Out][NotNullWhen(false)] TErr PPIEBDADPEO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2892540", Offset = "0x2891940", VA = "0x182892540")]
	public static bool AJHNLBHEOIA<TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [Out][NotNullWhen(true)] TOk LNFDBCMKMAF, [Out] OJIJNKCPBAD<TOk, TErr> MLLGDGAHJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x28929F0", Offset = "0x2891DF0", VA = "0x1828929F0")]
	public static bool DAONPJLPNPC<TOk, TErr, UErr, UOk>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [Out][NotNullWhen(true)] TOk LNFDBCMKMAF, [Out] OJIJNKCPBAD<UOk, UErr> MLLGDGAHJBO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2894240", Offset = "0x2893640", VA = "0x182894240")]
	public static bool JBJIDHMEPJL<TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [Out][NotNullWhen(true)] TOk LNFDBCMKMAF, [Out] OJIJNKCPBAD<GLCFOAMDFIN, TErr> MLLGDGAHJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x28946C0", Offset = "0x2893AC0", VA = "0x1828946C0")]
	public static OJIJNKCPBAD<UOk, UErr> JCCCLNLPHMK<UOk, UErr, TOk, TErr>([In] this OJIJNKCPBAD<TOk, TErr> MEEBIDIALDO, [In] OJIJNKCPBAD<UOk, UErr> OBMKPHNOIOK) where TOk : UOk where TErr : UErr
	{
		return default(OJIJNKCPBAD<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2893E30", Offset = "0x2893230", VA = "0x182893E30")]
	public static OJIJNKCPBAD<TOk?[]?, TErr?> IHPHOMBBIPP<TOk, TErr>(this IEnumerable<OJIJNKCPBAD<TOk, TErr>> MEEBIDIALDO)
	{
		return default(OJIJNKCPBAD<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CNCEBGAGMEJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2306500", Offset = "0x2305900", VA = "0x182306500")]
	public static OJIJNKCPBAD<TOk, T> AANCFCOMFCB<TOk>([In] TOk LNFDBCMKMAF) where TOk : notnull
	{
		return default(OJIJNKCPBAD<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4CB6AD0", Offset = "0x4CB5ED0", VA = "0x184CB6AD0")]
	public static OJIJNKCPBAD<GLCFOAMDFIN, T> AANCFCOMFCB()
	{
		return default(OJIJNKCPBAD<GLCFOAMDFIN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2306500", Offset = "0x2305900", VA = "0x182306500")]
	public static OJIJNKCPBAD<T, TErr> DFOIDHAJHGC<TErr>([In] TErr PPIEBDADPEO) where TErr : notnull
	{
		return default(OJIJNKCPBAD<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class JNJGHLHAGFG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct MKIIPKANEKC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly JNJGHLHAGFG<T> MIEFJMFHGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly int OJCNHOBPHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly bool EGALHOKPMIL;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7FE0", Offset = "0x1CE73E0", VA = "0x181CE7FE0")]
		public MKIIPKANEKC(JNJGHLHAGFG<T> OOANNHIADDH, int POCIFJBHIHD, bool BJBCNFAIGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A130", Offset = "0x3F09530", VA = "0x183F0A130")]
		public JNJGHLHAGFG<T>.OLCPPLGJFGE CKFAHJNIOKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A220", Offset = "0x3F09620", VA = "0x183F0A220", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A220", Offset = "0x3F09620", VA = "0x183F0A220", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class OLCPPLGJFGE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly JNJGHLHAGFG<T> MIEFJMFHGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly int COHNAJNDMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int CDHFJFHGCGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly bool EGALHOKPMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool HIECCLPEMDP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x40E82D0", Offset = "0x40E76D0", VA = "0x1840E82D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x40E83F0", Offset = "0x40E77F0", VA = "0x1840E83F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x40E8590", Offset = "0x40E7990", VA = "0x1840E8590", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x40E8C00", Offset = "0x40E8000", VA = "0x1840E8C00")]
		public OLCPPLGJFGE(JNJGHLHAGFG<T> OOANNHIADDH, int POCIFJBHIHD, bool BJBCNFAIGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x40E8240", Offset = "0x40E7640", VA = "0x1840E8240", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x40E83D0", Offset = "0x40E77D0", VA = "0x1840E83D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FFAPNELDLCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public FFAPNELDLCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x36D2F60", Offset = "0x36D2360", VA = "0x1836D2F60")]
		internal T LHNBKEHCNOJ(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly T[] NNCLDFFBNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int CDHFJFHGCGD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ILINHEAGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC700", Offset = "0x3BABB00", VA = "0x183BAC700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T MPGEHNMDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x36A34D0", Offset = "0x36A28D0", VA = "0x1836A34D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T KPEIOJKKKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC6D0", Offset = "0x3BABAD0", VA = "0x183BAC6D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC4F0", Offset = "0x3BAB8F0", VA = "0x183BAC4F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GGHIHFENJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x17064F0", Offset = "0x17058F0", VA = "0x1817064F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xFDB5C0", Offset = "0xFDA9C0", VA = "0x180FDB5C0")]
	private static int NKDIAECKIJJ(int PMLKPJNGBAD, int POJMEHKIPEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC930", Offset = "0x3BABD30", VA = "0x183BAC930")]
	public JNJGHLHAGFG(int HIAJHKACHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3BACA40", Offset = "0x3BABE40", VA = "0x183BACA40")]
	public JNJGHLHAGFG(int HIAJHKACHMC, Func<T> KOGDJOJIONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC750", Offset = "0x3BABB50", VA = "0x183BAC750")]
	public JNJGHLHAGFG(T[] LEFKIOOOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC6A0", Offset = "0x3BABAA0", VA = "0x183BAC6A0")]
	public void JJKKMDEFCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC5E0", Offset = "0x3BAB9E0", VA = "0x183BAC5E0")]
	public IEnumerable<T> IBNONGEJEDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC550", Offset = "0x3BAB950", VA = "0x183BAC550")]
	public JNJGHLHAGFG<T>.OLCPPLGJFGE CKFAHJNIOKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x331C720", Offset = "0x331BB20", VA = "0x18331C720", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x331C720", Offset = "0x331BB20", VA = "0x18331C720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KOFLLOHAIGF
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2880750", Offset = "0x287FB50", VA = "0x182880750")]
	public static JNJGHLHAGFG<T> HGJFOBLHCKL<T>(int HIAJHKACHMC, Func<T> KOGDJOJIONH) where T : notnull
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
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1DD3F10", Offset = "0x1DD3310", VA = "0x181DD3F10")]
		public RRColor(float ODIMBMMGNME, float DCDNCMOAJPP, float GJKNLEMINPO, float HKHMJOHPMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62626F0", Offset = "0x6261AF0", VA = "0x1862626F0", Slot = "4")]
		public bool Equals(RRColor MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6262770", Offset = "0x6261B70", VA = "0x186262770", Slot = "0")]
		public override bool Equals(object MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6262870", Offset = "0x6261C70", VA = "0x186262870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62628F0", Offset = "0x6261CF0", VA = "0x1862628F0", Slot = "5")]
		public string ToString(string OFLCCFMHOME, IFormatProvider IINKNGFGKEJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class DLNFEPHHBGC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct JIGBFEGFGGC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly DLNFEPHHBGC<T> CDGLALOBMCM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T EIHNEEOMIED
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3BA22F0", Offset = "0x3BA16F0", VA = "0x183BA22F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3BA22C0", Offset = "0x3BA16C0", VA = "0x183BA22C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
		public JIGBFEGFGGC(DLNFEPHHBGC<T> CDGLALOBMCM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HGKFBHMAEBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<JIGBFEGFGGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DLNFEPHHBGC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x385B610", Offset = "0x385AA10", VA = "0x18385B610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x311C300", Offset = "0x311B700", VA = "0x18311C300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim GCONJPMBLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T OFBLJNNIHFO;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x50FCBA0", Offset = "0x50FBFA0", VA = "0x1850FCBA0")]
	public DLNFEPHHBGC([In] T OFBLJNNIHFO, int MOMHGCDGEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x50FCA30", Offset = "0x50FBE30", VA = "0x1850FCA30")]
	public DLNFEPHHBGC([In] T OFBLJNNIHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50FC550", Offset = "0x50FB950", VA = "0x1850FC550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50FC510", Offset = "0x50FB910", VA = "0x1850FC510")]
	public JIGBFEGFGGC BDGFDGONIII()
	{
		return default(JIGBFEGFGGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x50FC7F0", Offset = "0x50FBBF0", VA = "0x1850FC7F0")]
	[AsyncStateMachine(typeof(DLNFEPHHBGC<>.HGKFBHMAEBD))]
	public Task<DLNFEPHHBGC<T>.JIGBFEGFGGC> MEMCNJDALEA(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50FC590", Offset = "0x50FB990", VA = "0x1850FC590")]
	public void KGLKABGKABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NHDEAEBHOBL
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6261D10", Offset = "0x6261110", VA = "0x186261D10")]
	public static DLNFEPHHBGC<GLCFOAMDFIN> HGJFOBLHCKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2623F10", Offset = "0x2623310", VA = "0x182623F10")]
	public static DLNFEPHHBGC<T> HGJFOBLHCKL<T>([In] T OFBLJNNIHFO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DFOLEMAGFBE<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct MGAENILGDOL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly DFOLEMAGFBE<T> IPOHMFAMCOP;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T EIHNEEOMIED
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3EF8E70", Offset = "0x3EF8270", VA = "0x183EF8E70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8C30", Offset = "0x3EF8030", VA = "0x183EF8C30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
		internal MGAENILGDOL(DFOLEMAGFBE<T> CDGLALOBMCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct PLDCEDINECN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly DFOLEMAGFBE<T> IPOHMFAMCOP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T EIHNEEOMIED
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3EF8E70", Offset = "0x3EF8270", VA = "0x183EF8E70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x41B2600", Offset = "0x41B1A00", VA = "0x1841B2600", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
		internal PLDCEDINECN(DFOLEMAGFBE<T> CDGLALOBMCM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LNFLGGHAABN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<PLDCEDINECN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public DFOLEMAGFBE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private DLNFEPHHBGC<GLCFOAMDFIN>.JIGBFEGFGGC <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<DLNFEPHHBGC<GLCFOAMDFIN>.JIGBFEGFGGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A7D0", Offset = "0x3D29BD0", VA = "0x183D2A7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x311C300", Offset = "0x311B700", VA = "0x18311C300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DLNFEPHHBGC<int> DPDFCJIPKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly DLNFEPHHBGC<GLCFOAMDFIN> JFJHCHAMKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly DLNFEPHHBGC<GLCFOAMDFIN> GFFCFOOEPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T FNDPBEDJFAF;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x50F0330", Offset = "0x50EF730", VA = "0x1850F0330")]
	internal DFOLEMAGFBE(DLNFEPHHBGC<int> CPMCDDLEFIF, DLNFEPHHBGC<GLCFOAMDFIN> KNKMCLAPAHG, DLNFEPHHBGC<GLCFOAMDFIN> HNJOIIENDGJ, [In] T OFBLJNNIHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x50EF690", Offset = "0x50EEA90", VA = "0x1850EF690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x50EF790", Offset = "0x50EEB90", VA = "0x1850EF790")]
	public MGAENILGDOL HPJHOMGBHDO()
	{
		return default(MGAENILGDOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x50EFEB0", Offset = "0x50EF2B0", VA = "0x1850EFEB0")]
	public PLDCEDINECN KAIGLPDMMCL()
	{
		return default(PLDCEDINECN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x50EFFA0", Offset = "0x50EF3A0", VA = "0x1850EFFA0")]
	[AsyncStateMachine(typeof(DFOLEMAGFBE<>.LNFLGGHAABN))]
	public Task<DFOLEMAGFBE<T>.PLDCEDINECN> MJPKDOEKHJB(CancellationToken KNKAEBKAEBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HLGLCMJEDBB
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x62610A0", Offset = "0x62604A0", VA = "0x1862610A0")]
	public static DFOLEMAGFBE<GLCFOAMDFIN> HGJFOBLHCKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2816950", Offset = "0x2815D50", VA = "0x182816950")]
	public static DFOLEMAGFBE<T> HGJFOBLHCKL<T>([In] T OFBLJNNIHFO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class EOLIIDBHNLN<TData> : FEBGENKADMF where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly string LNMJBEBMHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly TData CIKHIKEBPOF;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
	public override string PEMDIIHBGJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3371CE0", Offset = "0x33710E0", VA = "0x183371CE0")]
	internal EOLIIDBHNLN(string JEBCFBFPEMG, [In] TData FLKOGFDGJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DFKMPGHFEDI
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x625FB10", Offset = "0x625EF10", VA = "0x18625FB10")]
	public static EOLIIDBHNLN<GLCFOAMDFIN> HGJFOBLHCKL(string JEBCFBFPEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2662B80", Offset = "0x2661F80", VA = "0x182662B80")]
	public static EOLIIDBHNLN<TData> HGJFOBLHCKL<TData>(string JEBCFBFPEMG, [In] TData FLKOGFDGJDF) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class NAMFJEBPGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly Dictionary<object, float> HIPPGGLCLBC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float KFLCBEHGKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x944730", Offset = "0x943B30", VA = "0x180944730")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9447D0", Offset = "0x943BD0", VA = "0x1809447D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6261C10", Offset = "0x6261010", VA = "0x186261C10")]
	public void KEEOLFKBIJH(float PCGOHCLJAPN, object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6261BA0", Offset = "0x6260FA0", VA = "0x186261BA0")]
	public void EHEEBOIOGGL(object ICNJFMMNIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6261A70", Offset = "0x6260E70", VA = "0x186261A70")]
	private void DOFJNJKBBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6261C80", Offset = "0x6261080", VA = "0x186261C80")]
	public NAMFJEBPGDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class EBNCFCFLNCK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IDOKIEFFIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IDOKIEFFIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x399F910", Offset = "0x399ED10", VA = "0x18399F910")]
		internal int MBIGOLAJLNP(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private HashSet<T>? FLJJCDMIPIH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> LHONKALLICL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x33164A0", Offset = "0x33158A0", VA = "0x1833164A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool KGNGJEPLJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3316460", Offset = "0x3315860", VA = "0x183316460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C7740", Offset = "0x7C6B40", VA = "0x1807C7740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x33162B0", Offset = "0x33156B0", VA = "0x1833162B0")]
	public bool FFIECPFJEFG(T ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x33164D0", Offset = "0x33158D0", VA = "0x1833164D0")]
	public bool PIABDNKCBCD(T ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3316420", Offset = "0x3315820", VA = "0x183316420")]
	public bool LBFIBDMBLKM(T ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x33165F0", Offset = "0x33159F0", VA = "0x1833165F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public EBNCFCFLNCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HMKEPMLABHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly string OMCEAEADNHM;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public HMKEPMLABHI(string OMCEAEADNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6261170", Offset = "0x6260570", VA = "0x186261170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class LEPMAMFFPJF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GMNMDJOPDNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GMNMDJOPDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x62606D0", Offset = "0x625FAD0", VA = "0x1862606D0")]
		internal int MBIGOLAJLNP(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<object>? FLJJCDMIPIH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> LHONKALLICL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x62616B0", Offset = "0x6260AB0", VA = "0x1862616B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool KGNGJEPLJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6261630", Offset = "0x6260A30", VA = "0x186261630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C7740", Offset = "0x7C6B40", VA = "0x1807C7740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x62614F0", Offset = "0x62608F0", VA = "0x1862614F0")]
	public bool FFIECPFJEFG(object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6261740", Offset = "0x6260B40", VA = "0x186261740")]
	public bool PIABDNKCBCD(object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62615D0", Offset = "0x62609D0", VA = "0x1862615D0")]
	public bool LBFIBDMBLKM(object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6261640", Offset = "0x6260A40", VA = "0x186261640")]
	public void NBJEDFLJBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x62617E0", Offset = "0x6260BE0", VA = "0x1862617E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public LEPMAMFFPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FCEBEFBJKEA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct DBHBCMACCNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float CLNKEFLHKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public T EIHNEEOMIED;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Dictionary<object, DBHBCMACCNG> HIPPGGLCLBC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T BDNCCEJMLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xEE40B0", Offset = "0xEE34B0", VA = "0x180EE40B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xEE3690", Offset = "0xEE2A90", VA = "0x180EE3690", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? PCBANGGPOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MLEHHLOOALM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x36AEED0", Offset = "0x36AE2D0", VA = "0x1836AEED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x36AEA00", Offset = "0x36ADE00", VA = "0x1836AEA00")]
	public bool KEEOLFKBIJH(T PCGOHCLJAPN, object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x336BFF0", Offset = "0x336B3F0", VA = "0x18336BFF0")]
	public bool EHEEBOIOGGL(object ICNJFMMNIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x36AEF20", Offset = "0x36AE320", VA = "0x1836AEF20")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x36AE4B0", Offset = "0x36AD8B0", VA = "0x1836AE4B0")]
	public bool JFDMGELHHBG(object ICNJFMMNIKL, [Out] T PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x36B01D0", Offset = "0x36AF5D0", VA = "0x1836B01D0")]
	[KNKMEDCNICD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OLKGFFLHGJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x36B0550", Offset = "0x36AF950", VA = "0x1836B0550")]
	public FCEBEFBJKEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NJMJHIEGALE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NFLKAFGJHDI MOFIEMCOENO;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HKMFNMHKCNF : NJMJHIEGALE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct KMKPOPOALKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float OEBPOHMGJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public readonly float BEFCIIIMLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		internal readonly bool JOKPAMMGCJH;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JOOOJCLOMDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x62611C0", Offset = "0x62605C0", VA = "0x1862611C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6261330", Offset = "0x6260730", VA = "0x186261330")]
		public KMKPOPOALKB(float IEPLFGFMPDD, float HLFFIBCGIOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x62611D0", Offset = "0x62605D0", VA = "0x1862611D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FMCDPLPOIPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public HKMFNMHKCNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public FMCDPLPOIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6260630", Offset = "0x625FA30", VA = "0x186260630")]
		internal void FPBIFBFEDBF(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly int MIFMOLKOCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int MGNBNCPKNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NJMJHIEGALE[] DMDLCNBGLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NFLKAFGJHDI[] ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly KMKPOPOALKB[] NEHNEMOBBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private KMKPOPOALKB PGHPJAJLLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BMIHPPNPOPO FIAFACLJIBO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NFLKAFGJHDI MOFIEMCOENO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6260780", Offset = "0x625FB80", VA = "0x186260780", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x62609E0", Offset = "0x625FDE0", VA = "0x1862609E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6260F10", Offset = "0x6260310", VA = "0x186260F10")]
	public HKMFNMHKCNF(int MIFMOLKOCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6260840", Offset = "0x625FC40", VA = "0x186260840")]
	public BMIHPPNPOPO DABJFAELDAO(KMKPOPOALKB NJIAABNGJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6260AA0", Offset = "0x625FEA0", VA = "0x186260AA0")]
	public void MANPJHJDOKL(NJMJHIEGALE HFFBOGHHIEN, [Optional] KMKPOPOALKB AGAHEALIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x62608D0", Offset = "0x625FCD0", VA = "0x1862608D0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void NFLKAFGJHDI(float PDIKPHBHNBE);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AHNFBAOIDME
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class MDPJGPHPNOH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly NJMJHIEGALE BOCNHAGCPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly NFLKAFGJHDI KCNCNEMPBGA;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x62619E0", Offset = "0x6260DE0", VA = "0x1862619E0")]
		public MDPJGPHPNOH(NJMJHIEGALE BOCNHAGCPJL, NFLKAFGJHDI KCNCNEMPBGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6261990", Offset = "0x6260D90", VA = "0x186261990", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x625F7B0", Offset = "0x625EBB0", VA = "0x18625F7B0")]
	internal static bool ECCHFIOAAIP(float HKHMJOHPMKP, float GJKNLEMINPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6252B30", Offset = "0x6251F30", VA = "0x186252B30")]
	internal static float BGJKOAPOCKO(float HKHMJOHPMKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x625F820", Offset = "0x625EC20", VA = "0x18625F820")]
	public static IDisposable JJHOMDDNKOJ(this NJMJHIEGALE BOCNHAGCPJL, NFLKAFGJHDI KCNCNEMPBGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class BMIHPPNPOPO : NJMJHIEGALE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float PDIKPHBHNBE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float PIKLDLLMNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x625FA20", Offset = "0x625EE20", VA = "0x18625FA20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NFLKAFGJHDI? MOFIEMCOENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x625F8E0", Offset = "0x625ECE0", VA = "0x18625F8E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x625F980", Offset = "0x625ED80", VA = "0x18625F980", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public BMIHPPNPOPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class EMLNEJOGLOI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D489B0", Offset = "0x5D47DB0", VA = "0x185D489B0")]
	public EMLNEJOGLOI(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class IJOHIKBMMLO<TKey, TValue> : PMGNCGPAILP<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, JPJIMJDKMKM where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class MABJDBNNHLO : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public IJOHIKBMMLO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xEE40B0", Offset = "0xEE34B0", VA = "0x180EE40B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3EEBAA0", Offset = "0x3EEAEA0", VA = "0x183EEBAA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public MABJDBNNHLO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x36C4130", Offset = "0x36C3530", VA = "0x1836C4130", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB130", Offset = "0x3EEA530", VA = "0x183EEB130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAD30", Offset = "0x3EEA130", VA = "0x183EEAD30")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB960", Offset = "0x3EEAD60", VA = "0x183EEB960")]
		private void ODFILHFIFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3EEBA50", Offset = "0x3EEAE50", VA = "0x183EEBA50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly PMGNCGPAILP<TKey, TValue> NNNBDBNBJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IDictionary<TKey, TValue> IOFABBCFIJD;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x39BE3F0", Offset = "0x39BD7F0", VA = "0x1839BE3F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool EFGCLFKEOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x39BE590", Offset = "0x39BD990", VA = "0x1839BE590", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x39BE820", Offset = "0x39BDC20", VA = "0x1839BE820", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> MCCONIHHGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x39BE600", Offset = "0x39BDA00", VA = "0x1839BE600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> LAGEMNIOLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x39BE710", Offset = "0x39BDB10", VA = "0x1839BE710", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x39BE270", Offset = "0x39BD670", VA = "0x1839BE270")]
	public IJOHIKBMMLO(PMGNCGPAILP<TKey, TValue> NNNBDBNBJPG, [Optional] IDictionary<TKey, TValue>? IOFABBCFIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x39BC230", Offset = "0x39BB630", VA = "0x1839BC230", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x39BD110", Offset = "0x39BC510", VA = "0x1839BD110")]
	public void LFNGCAHDJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x39BBC40", Offset = "0x39BB040", VA = "0x1839BBC40", Slot = "9")]
	public void Add(TKey NIOPCMHKLMB, TValue PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x39BBF50", Offset = "0x39BB350", VA = "0x1839BBF50")]
	public void BKKKCEOKHNM(TKey NIOPCMHKLMB, TValue PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x39BB810", Offset = "0x39BAC10", VA = "0x1839BB810")]
	public void APJICAFKPKD(TKey NIOPCMHKLMB, TValue PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x39BD290", Offset = "0x39BC690", VA = "0x1839BD290")]
	public void ODLNFLCCHHH(TKey NIOPCMHKLMB, TValue PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x39BD070", Offset = "0x39BC470", VA = "0x1839BD070")]
	public void JCDOOOMAFGJ(TKey NIOPCMHKLMB, TValue PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x39BD890", Offset = "0x39BCC90", VA = "0x1839BD890", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LPGJEPJPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x39BDA90", Offset = "0x39BCE90", VA = "0x1839BDA90", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x39BDDF0", Offset = "0x39BD1F0", VA = "0x1839BDDF0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x39BC2A0", Offset = "0x39BB6A0", VA = "0x1839BC2A0", Slot = "8")]
	public bool ContainsKey(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x39BCDF0", Offset = "0x39BC1F0", VA = "0x1839BCDF0")]
	public bool GFNOHAEFNKL(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x39BC100", Offset = "0x39BB500", VA = "0x1839BC100")]
	public bool BMBMEKIKOCD(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x39BD6E0", Offset = "0x39BCAE0", VA = "0x1839BD6E0", Slot = "10")]
	public bool Remove(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x39BDFE0", Offset = "0x39BD3E0", VA = "0x1839BDFE0", Slot = "11")]
	public bool TryGetValue(TKey NIOPCMHKLMB, [Out] TValue PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x39BC890", Offset = "0x39BBC90", VA = "0x1839BC890", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] KGECIFKDBHF, int PADDMAPAGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x39BDFB0", Offset = "0x39BD3B0", VA = "0x1839BDFB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x39BCEC0", Offset = "0x39BC2C0", VA = "0x1839BCEC0", Slot = "19")]
	[IteratorStateMachine(typeof(IJOHIKBMMLO<, >.MABJDBNNHLO))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x39BB650", Offset = "0x39BAA50", VA = "0x1839BB650", Slot = "21")]
	public bool APDBHFCGPEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x39BCAE0", Offset = "0x39BBEE0", VA = "0x1839BCAE0")]
	private TValue FLHGEBHAPBO(TKey NIOPCMHKLMB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface JPJIMJDKMKM
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool APDBHFCGPEC();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface PMGNCGPAILP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, JPJIMJDKMKM
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class NCDJKCDGAPJ<TKey, TVal> : PMGNCGPAILP<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, JPJIMJDKMKM where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int NNNDADIIMDB(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void FLFIHBFOHLL(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN, KKJMHKEDGAE HOKIEGJILGD);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class CNMGKGLKHCK
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8516A0", Offset = "0x850AA0", VA = "0x1808516A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal EIHNEEOMIED
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x968FD0", Offset = "0x9683D0", VA = "0x180968FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int JOOOJCLOMDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7FC300", Offset = "0x7FB700", VA = "0x1807FC300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7FB980", Offset = "0x7FAD80", VA = "0x1807FB980")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset BINJMPPGBLM
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAE23E0", Offset = "0xAE17E0", VA = "0x180AE23E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x132E620", Offset = "0x132DA20", VA = "0x18132E620")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4CB8600", Offset = "0x4CB7A00", VA = "0x184CB8600")]
		public CNMGKGLKHCK(TKey NIOPCMHKLMB, TVal FNMPHGMIIBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GEBJHEEFGMO : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NCDJKCDGAPJ<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LinkedList<CNMGKGLKHCK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xEE40B0", Offset = "0xEE34B0", VA = "0x180EE40B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x37BD810", Offset = "0x37BCC10", VA = "0x1837BD810", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public GEBJHEEFGMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x36BEDD0", Offset = "0x36BE1D0", VA = "0x1836BEDD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x37BCA40", Offset = "0x37BBE40", VA = "0x1837BCA40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x37BAB20", Offset = "0x37B9F20", VA = "0x1837BAB20")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x37BD6F0", Offset = "0x37BCAF0", VA = "0x1837BD6F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const int INLGPDPNGIE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TKey, LinkedListNode<CNMGKGLKHCK>> FPJNNJHDBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LinkedList<CNMGKGLKHCK> IMBKAAIKCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NNNDADIIMDB? DOLDFADIPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly TimeSpan AMBLGCOPKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly FLFIHBFOHLL? ENCKFHNDKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly MPLAMDAIPEG BHGECHJPLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool CAJAOBMCKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly List<TKey> LJNHEEOPKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly List<TVal> DBEMIGHJHPI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int FBEDICLDNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD110", Offset = "0x7CC510", VA = "0x1807CD110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int AJEKEKJMGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9BDF90", Offset = "0x9BD390", VA = "0x1809BDF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9BDCD0", Offset = "0x9BD0D0", VA = "0x1809BDCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3F869D0", Offset = "0x3F85DD0", VA = "0x183F869D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int DBJGLFMLOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x399AFD0", Offset = "0x399A3D0", VA = "0x18399AFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> LAGEMNIOLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3F86B00", Offset = "0x3F85F00", VA = "0x183F86B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.DMFECJPMBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3F81C50", Offset = "0x3F81050", VA = "0x183F81C50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EFGCLFKEOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3F86A60", Offset = "0x3F85E60", VA = "0x183F86A60", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3F86B90", Offset = "0x3F85F90", VA = "0x183F86B90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3F7FA60", Offset = "0x3F7EE60", VA = "0x183F7FA60")]
	private bool LIKIGPGPOOI(int MIFMOLKOCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3F77A90", Offset = "0x3F76E90", VA = "0x183F77A90")]
	private void ICMFEHFMKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3F840C0", Offset = "0x3F834C0", VA = "0x183F840C0")]
	public NCDJKCDGAPJ(int MIFMOLKOCID, [Optional] NNNDADIIMDB? DOLDFADIPOC, [Optional] IEqualityComparer<TKey>? BAJLOCKCJKC, [Optional] FLFIHBFOHLL? ENCKFHNDKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3F82AA0", Offset = "0x3F81EA0", VA = "0x183F82AA0")]
	public NCDJKCDGAPJ(TimeSpan AMBLGCOPKKM, [Optional] IEqualityComparer<TKey>? BAJLOCKCJKC, [Optional] FLFIHBFOHLL? ENCKFHNDKFN, [Optional] MPLAMDAIPEG? BHGECHJPLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3F82AF0", Offset = "0x3F81EF0", VA = "0x183F82AF0")]
	public NCDJKCDGAPJ(int MIFMOLKOCID, TimeSpan AMBLGCOPKKM, [Optional] IEqualityComparer<TKey>? BAJLOCKCJKC, [Optional] FLFIHBFOHLL? ENCKFHNDKFN, [Optional] MPLAMDAIPEG? BHGECHJPLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3F85750", Offset = "0x3F84B50", VA = "0x183F85750")]
	public NCDJKCDGAPJ(int MIFMOLKOCID, NNNDADIIMDB? DOLDFADIPOC, TimeSpan AMBLGCOPKKM, [Optional] IEqualityComparer<TKey>? BAJLOCKCJKC, [Optional] FLFIHBFOHLL? ENCKFHNDKFN, [Optional] MPLAMDAIPEG? BHGECHJPLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3F6C5B0", Offset = "0x3F6B9B0", VA = "0x183F6C5B0", Slot = "21")]
	public bool APDBHFCGPEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3F7FE70", Offset = "0x3F7F270", VA = "0x183F7FE70", Slot = "22")]
	public bool MDCKDHAPFMD(int HIAJHKACHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3F6D710", Offset = "0x3F6CB10", VA = "0x183F6D710")]
	private bool CCDBCEMJKKL(int HIAJHKACHMC, KKJMHKEDGAE HOKIEGJILGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3F808F0", Offset = "0x3F7FCF0", VA = "0x183F808F0")]
	public void NINGCLMMDDO(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3F6D350", Offset = "0x3F6C750", VA = "0x183F6D350", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LPGJEPJPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3F6C8B0", Offset = "0x3F6BCB0", VA = "0x183F6C8B0", Slot = "9")]
	public void Add(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3F71D30", Offset = "0x3F71130", VA = "0x183F71D30", Slot = "8")]
	public bool ContainsKey(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3F811E0", Offset = "0x3F805E0", VA = "0x183F811E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3F80F60", Offset = "0x3F80360", VA = "0x183F80F60", Slot = "10")]
	public bool Remove(TKey NIOPCMHKLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3F818D0", Offset = "0x3F80CD0", VA = "0x183F818D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LPGJEPJPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3F7BAA0", Offset = "0x3F7AEA0", VA = "0x183F7BAA0")]
	private bool JOIPHEONDHE(TKey NIOPCMHKLMB, [Out] TVal PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3F765F0", Offset = "0x3F759F0", VA = "0x183F765F0")]
	private TVal EBLDKANKNCA(TKey DDKLCIAKGKD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3F82580", Offset = "0x3F81980", VA = "0x183F82580", Slot = "11")]
	public bool TryGetValue(TKey DDKLCIAKGKD, [Out] TVal PCGOHCLJAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3F71B30", Offset = "0x3F70F30", VA = "0x183F71B30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3F72EC0", Offset = "0x3F722C0", VA = "0x183F72EC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KGECIFKDBHF, int PADDMAPAGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3F76C60", Offset = "0x3F76060", VA = "0x183F76C60")]
	private void FAMFJCKKMJI(TKey NIOPCMHKLMB, TVal FNMPHGMIIBA, KKJMHKEDGAE HOKIEGJILGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3F754F0", Offset = "0x3F748F0", VA = "0x183F754F0")]
	private bool DBGBLLJFMEN(CNMGKGLKHCK ICEGOHANOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A650", Offset = "0x3F79A50", VA = "0x183F7A650")]
	private void ILBCAHNDCNN(LinkedListNode<CNMGKGLKHCK> LBJKNNJHLOG, TVal JADIFKAAHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3F7BEF0", Offset = "0x3F7B2F0", VA = "0x183F7BEF0")]
	private void KEEOLFKBIJH(TKey NIOPCMHKLMB, TVal PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3F7F4C0", Offset = "0x3F7E8C0", VA = "0x183F7F4C0")]
	private void KPFMHKDMFGI(CNMGKGLKHCK ICEGOHANOEM, TVal JADIFKAAHNO, int DGPLGHIHJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3F77970", Offset = "0x3F76D70", VA = "0x183F77970", Slot = "19")]
	[IteratorStateMachine(typeof(NCDJKCDGAPJ<, >.GEBJHEEFGMO))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3F81C80", Offset = "0x3F81080", VA = "0x183F81C80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum KKJMHKEDGAE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RemovedViaClear
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DIGGMGFELJE<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly TKey LDKJEBKAMEN;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x50F3460", Offset = "0x50F2860", VA = "0x1850F3460")]
	public DIGGMGFELJE(TKey OIGFMGMDLMB, Exception ANBJHAGKAMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FDPGBJFHJGL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5646790", Offset = "0x5645B90", VA = "0x185646790")]
	public FDPGBJFHJGL(string JEBCFBFPEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FCOFGKOADKD<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class HGLPOEGBONO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public FCOFGKOADKD<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public HGLPOEGBONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x385C8B0", Offset = "0x385BCB0", VA = "0x18385C8B0")]
		internal Task<TResource> KDDLLGDOOFH(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EEKHCHCFAEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x33449B0", Offset = "0x3343DB0", VA = "0x1833449B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x33450B0", Offset = "0x33444B0", VA = "0x1833450B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct JGABGGMOEGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3B97320", Offset = "0x3B96720", VA = "0x183B97320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3B97840", Offset = "0x3B96C40", VA = "0x183B97840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LBCOFDLFFCA<TId, Task<TResource>> ABLJNHDDAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> DFDGCPOFDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? ANMDJFIEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Action<TResource>? JBICCKADFAF;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x36B6620", Offset = "0x36B5A20", VA = "0x1836B6620")]
	public FCOFGKOADKD(int FNLKBKJHEBI = 0, [Optional] IEqualityComparer<TId>? NFJKCELNIPL, [Optional] Func<TId, CancellationToken, Task<TResource>>? JCKFLFHMEAN, [Optional] Action<TResource>? JIPDAOFLBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x36B5C10", Offset = "0x36B5010", VA = "0x1836B5C10")]
	public FIOJPADPCHG<Task<TResource>> JJLHOIFOJCO(TId BFMGPLIBCKL, [Optional] Func<TId, CancellationToken, Task<TResource>>? JCKFLFHMEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x36B53D0", Offset = "0x36B47D0", VA = "0x1836B53D0")]
	private void CACEIIMLPCD(Task<TResource> JKFKBCIOAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x36B5700", Offset = "0x36B4B00", VA = "0x1836B5700")]
	public void CBMMBGFLCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x36B57A0", Offset = "0x36B4BA0", VA = "0x1836B57A0")]
	public LBCOFDLFFCA<TId, Task<TResource>>.HLAEKNALCMJ CKFAHJNIOKH()
	{
		return default(LBCOFDLFFCA<TId, Task<TResource>>.HLAEKNALCMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x36B6450", Offset = "0x36B5850", VA = "0x1836B6450", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x36B6450", Offset = "0x36B5850", VA = "0x1836B6450", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x36B5AE0", Offset = "0x36B4EE0", VA = "0x1836B5AE0")]
	[AsyncStateMachine(typeof(FCOFGKOADKD<, >.EEKHCHCFAEH))]
	[CompilerGenerated]
	internal static Task GLIFIODBAEB(Task<TResource> JKFKBCIOAGB, CancellationTokenSource FPBCHFPENDC, Dictionary<Task<TResource>, CancellationTokenSource> MENMIIFDDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x36B6230", Offset = "0x36B5630", VA = "0x1836B6230")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(FCOFGKOADKD<, >.JGABGGMOEGN))]
	internal static Task JMHCGMEJHAA(Task<TResource> JKFKBCIOAGB, Action<TResource> EKIOGOLGMOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LBCOFDLFFCA<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class HKPKIDMDPNC : IEquatable<HKPKIDMDPNC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TValue EIHNEEOMIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int GFKOFNHGOPO;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1CAE3F0", Offset = "0x1CAD7F0", VA = "0x181CAE3F0")]
		public HKPKIDMDPNC(TValue PCGOHCLJAPN, int PGBLGHBDKFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3870510", Offset = "0x386F910", VA = "0x183870510", Slot = "4")]
		public bool Equals(HKPKIDMDPNC? MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3870470", Offset = "0x386F870", VA = "0x183870470", Slot = "0")]
		public override bool Equals(object? LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x38706C0", Offset = "0x386FAC0", VA = "0x1838706C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct HLAEKNALCMJ : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Dictionary<TKey, HKPKIDMDPNC>.Enumerator LMJAKBIIIIC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3870B90", Offset = "0x386FF90", VA = "0x183870B90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3871100", Offset = "0x3870500", VA = "0x183871100", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3870E40", Offset = "0x3870240", VA = "0x183870E40")]
		public HLAEKNALCMJ(LBCOFDLFFCA<TKey, TValue> HIPPGGLCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3870880", Offset = "0x386FC80", VA = "0x183870880", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3870940", Offset = "0x386FD40", VA = "0x183870940", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3870AE0", Offset = "0x386FEE0", VA = "0x183870AE0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class ABKOHDMNBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LBCOFDLFFCA<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HKPKIDMDPNC refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public ABKOHDMNBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x37771C0", Offset = "0x37765C0", VA = "0x1837771C0")]
		internal void KDDLLGDOOFH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, HKPKIDMDPNC> IFCEHLCLHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Func<TKey, TValue>? BABCLKJECKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Action<TValue>? HMFBNLFGGDG;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DB10", Offset = "0x3D0CF10", VA = "0x183D0DB10")]
	public LBCOFDLFFCA(int FNLKBKJHEBI = 0, [Optional] IEqualityComparer<TKey>? BAJLOCKCJKC, [Optional] Func<TKey, TValue>? OFHNEMABEPP, [Optional] Action<TValue>? FLLENJKCAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CDD0", Offset = "0x3D0C1D0", VA = "0x183D0CDD0")]
	public FIOJPADPCHG<TValue> JJLHOIFOJCO(TKey NIOPCMHKLMB, [Optional] Func<TKey, TValue>? FJGGMKIPPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D730", Offset = "0x3D0CB30", VA = "0x183D0D730")]
	private void LBDCCEJODEM(TKey NIOPCMHKLMB, HKPKIDMDPNC MNPGENKODCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C760", Offset = "0x3D0BB60", VA = "0x183D0C760")]
	public void CBMMBGFLCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CD10", Offset = "0x3D0C110", VA = "0x183D0CD10")]
	public HLAEKNALCMJ CKFAHJNIOKH()
	{
		return default(HLAEKNALCMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DA70", Offset = "0x3D0CE70", VA = "0x183D0DA70", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DA70", Offset = "0x3D0CE70", VA = "0x183D0DA70", Slot = "5")]
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
