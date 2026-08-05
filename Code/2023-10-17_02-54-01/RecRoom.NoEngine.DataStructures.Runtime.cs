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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D56EC0", Offset = "0x5D556C0", VA = "0x185D56EC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PNOCALPEIMF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected PNOCALPEIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OGPMPGCFHAP<T> : PNOCALPEIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LGDCAAILPND
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum FMAKFINHHDD
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
		public FMAKFINHHDD GFGNPBCFEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T OONIIOMBHJI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LEAAKCMHJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool ADPAHODNMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KLCIOCADJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? JIJHJEDCMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LGDCAAILPND>? NCEFAHFJALP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CIPCFIDEPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3CD78D0", Offset = "0x3CD60D0", VA = "0x183CD78D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7E50", Offset = "0x3CD6650", VA = "0x183CD7E50")]
	protected OGPMPGCFHAP(bool KLCIOCADJGI, bool ADPAHODNMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7920", Offset = "0x3CD6120", VA = "0x183CD7920")]
	protected bool IPHGJDBNGLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7BA0", Offset = "0x3CD63A0", VA = "0x183CD7BA0")]
	protected void OMMLKCOFAMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD79C0", Offset = "0x3CD61C0", VA = "0x183CD79C0")]
	protected void NEGOGMFIAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22B5130", Offset = "0x22B3930", VA = "0x1822B5130")]
	private static void DHFIEIPLKLN<U>(List<U>? HBKECNHANOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD76F0", Offset = "0x3CD5EF0", VA = "0x183CD76F0", Slot = "4")]
	public void BONJGFNEKBE(T OONIIOMBHJI, bool CAFMCBDPFKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7CA0", Offset = "0x3CD64A0", VA = "0x183CD7CA0", Slot = "5")]
	public void PJFBCFIPABD(T OONIIOMBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7570", Offset = "0x3CD5D70", VA = "0x183CD7570")]
	public void BEIKHFOBAHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DPBKEIFDJIL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BONJGFNEKBE(Action OONIIOMBHJI, bool CAFMCBDPFKM = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJFBCFIPABD(Action OONIIOMBHJI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BJPMGBAMGNN : OGPMPGCFHAP<Action>, DPBKEIFDJIL
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D54DB0", Offset = "0x5D535B0", VA = "0x185D54DB0")]
	public BJPMGBAMGNN(bool KLCIOCADJGI = false, bool ADPAHODNMMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D54AF0", Offset = "0x5D532F0", VA = "0x185D54AF0")]
	public void BHJKEIPKKOJ()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D54D50", Offset = "0x5D53550", VA = "0x185D54D50")]
	public static BJPMGBAMGNN KMOGMICJDHO(BJPMGBAMGNN FCFFLIEEAKL, Action OONIIOMBHJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D54CF0", Offset = "0x5D534F0", VA = "0x185D54CF0")]
	public static BJPMGBAMGNN JEOOEADEPIC(BJPMGBAMGNN FCFFLIEEAKL, Action OONIIOMBHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DJDEOAOLNNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BONJGFNEKBE(Action<T> OONIIOMBHJI, bool CAFMCBDPFKM = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJFBCFIPABD(Action<T> OONIIOMBHJI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class MBOBMBMLJPH<T> : OGPMPGCFHAP<Action<T>>, DJDEOAOLNNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34DB630", Offset = "0x34D9E30", VA = "0x1834DB630")]
	public MBOBMBMLJPH(bool KLCIOCADJGI = false, bool ADPAHODNMMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2B60", Offset = "0x3AE1360", VA = "0x183AE2B60")]
	public void BHJKEIPKKOJ(T INGJCJMKCCN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x356F120", Offset = "0x356D920", VA = "0x18356F120")]
	public static MBOBMBMLJPH<T> KMOGMICJDHO(MBOBMBMLJPH<T> FCFFLIEEAKL, Action<T> OONIIOMBHJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x356F090", Offset = "0x356D890", VA = "0x18356F090")]
	public static MBOBMBMLJPH<T> JEOOEADEPIC(MBOBMBMLJPH<T> FCFFLIEEAKL, Action<T> OONIIOMBHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BMJKPCKKECL<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class JEAOGCMOGDE<T, U> : OGPMPGCFHAP<Action<T, U>>, BMJKPCKKECL<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x34DB630", Offset = "0x34D9E30", VA = "0x1834DB630")]
	public JEAOGCMOGDE(bool KLCIOCADJGI = false, bool ADPAHODNMMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37E9260", Offset = "0x37E7A60", VA = "0x1837E9260")]
	public void BHJKEIPKKOJ(T INGJCJMKCCN, U LOHBBMECPKB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x356F120", Offset = "0x356D920", VA = "0x18356F120")]
	public static JEAOGCMOGDE<T, U> KMOGMICJDHO(JEAOGCMOGDE<T, U> FCFFLIEEAKL, Action<T, U> OONIIOMBHJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x356F090", Offset = "0x356D890", VA = "0x18356F090")]
	public static JEAOGCMOGDE<T, U> JEOOEADEPIC(JEAOGCMOGDE<T, U> FCFFLIEEAKL, Action<T, U> OONIIOMBHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MHLFPCNBIHM<T, U, V> : OGPMPGCFHAP<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34DB630", Offset = "0x34D9E30", VA = "0x1834DB630")]
	public MHLFPCNBIHM(bool KLCIOCADJGI = false, bool ADPAHODNMMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B07E60", Offset = "0x3B06660", VA = "0x183B07E60")]
	public void BHJKEIPKKOJ(T INGJCJMKCCN, U LOHBBMECPKB, V EJBGEGKBPNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x356F120", Offset = "0x356D920", VA = "0x18356F120")]
	public static MHLFPCNBIHM<T, U, V> KMOGMICJDHO(MHLFPCNBIHM<T, U, V> FCFFLIEEAKL, Action<T, U, V> OONIIOMBHJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x356F090", Offset = "0x356D890", VA = "0x18356F090")]
	public static MHLFPCNBIHM<T, U, V> JEOOEADEPIC(MHLFPCNBIHM<T, U, V> FCFFLIEEAKL, Action<T, U, V> OONIIOMBHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AKGNOKENFDO<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class DOHMDHPLIIH<T, U, V, W> : OGPMPGCFHAP<Action<T, U, V, W>>, AKGNOKENFDO<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34DB630", Offset = "0x34D9E30", VA = "0x1834DB630")]
	public DOHMDHPLIIH(bool KLCIOCADJGI = false, bool ADPAHODNMMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E260", Offset = "0x4D1CA60", VA = "0x184D1E260")]
	public void BHJKEIPKKOJ(T INGJCJMKCCN, U LOHBBMECPKB, V EJBGEGKBPNL, W OANPIMIBBEM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x356F120", Offset = "0x356D920", VA = "0x18356F120")]
	public static DOHMDHPLIIH<T, U, V, W> KMOGMICJDHO(DOHMDHPLIIH<T, U, V, W> FCFFLIEEAKL, Action<T, U, V, W> OONIIOMBHJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x356F090", Offset = "0x356D890", VA = "0x18356F090")]
	public static DOHMDHPLIIH<T, U, V, W> JEOOEADEPIC(DOHMDHPLIIH<T, U, V, W> FCFFLIEEAKL, Action<T, U, V, W> OONIIOMBHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HEGJDELBAPF<T, U, V, W, X> : OGPMPGCFHAP<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34DB630", Offset = "0x34D9E30", VA = "0x1834DB630")]
	public HEGJDELBAPF(bool KLCIOCADJGI = false, bool ADPAHODNMMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x356ECD0", Offset = "0x356D4D0", VA = "0x18356ECD0")]
	public void BHJKEIPKKOJ(T INGJCJMKCCN, U LOHBBMECPKB, V EJBGEGKBPNL, W OANPIMIBBEM, X IILAPOMEGLM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x356F120", Offset = "0x356D920", VA = "0x18356F120")]
	public static HEGJDELBAPF<T, U, V, W, X> KMOGMICJDHO(HEGJDELBAPF<T, U, V, W, X> FCFFLIEEAKL, Action<T, U, V, W, X> OONIIOMBHJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x356F090", Offset = "0x356D890", VA = "0x18356F090")]
	public static HEGJDELBAPF<T, U, V, W, X> JEOOEADEPIC(HEGJDELBAPF<T, U, V, W, X> FCFFLIEEAKL, Action<T, U, V, W, X> OONIIOMBHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class OOIKIFGEJEA<T, U, V, W, X, Y> : OGPMPGCFHAP<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34DB630", Offset = "0x34D9E30", VA = "0x1834DB630")]
	public OOIKIFGEJEA(bool KLCIOCADJGI = false, bool ADPAHODNMMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF63F0", Offset = "0x3CF4BF0", VA = "0x183CF63F0")]
	public void BHJKEIPKKOJ(T INGJCJMKCCN, U LOHBBMECPKB, V EJBGEGKBPNL, W OANPIMIBBEM, X IILAPOMEGLM, Y BNBBAPGFCCO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x356F120", Offset = "0x356D920", VA = "0x18356F120")]
	public static OOIKIFGEJEA<T, U, V, W, X, Y> KMOGMICJDHO(OOIKIFGEJEA<T, U, V, W, X, Y> FCFFLIEEAKL, Action<T, U, V, W, X, Y> OONIIOMBHJI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x356F090", Offset = "0x356D890", VA = "0x18356F090")]
	public static OOIKIFGEJEA<T, U, V, W, X, Y> JEOOEADEPIC(OOIKIFGEJEA<T, U, V, W, X, Y> FCFFLIEEAKL, Action<T, U, V, W, X, Y> OONIIOMBHJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JAHJIIBJPOM<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ANNKFHDNJKL<TKey, TVal> OMCNGFOBDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> LOEBNHCDDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int MDEGOOPLHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly ANNKFHDNJKL<TKey, TVal>.DHFGFDLJGEC? DMFLHDOIEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int BDIMBECGKBO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int PHGFPDLNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37D8B10", Offset = "0x37D7310", VA = "0x1837D8B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KPFJFCCFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x37D8ED0", Offset = "0x37D76D0", VA = "0x1837D8ED0")]
	public JAHJIIBJPOM(int MDEGOOPLHMC, [Optional] ANNKFHDNJKL<TKey, TVal>.DHFGFDLJGEC? DMFLHDOIEKI, [Optional] IEqualityComparer<TKey>? LFDOLHGMGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37D8B60", Offset = "0x37D7360", VA = "0x1837D8B60")]
	public void IOPAFEFLBJO(TKey OHPCNPKOLBJ, TVal FKKGMPDEPMA, bool NAMBBDKOFNA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x37D8A70", Offset = "0x37D7270", VA = "0x1837D8A70")]
	public bool FBCLDPNAJLH(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37D8D30", Offset = "0x37D7530", VA = "0x1837D8D30")]
	public bool OCMBKDFPCIC(TKey ENDMHKCFGAC, [Out] TVal FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37D86C0", Offset = "0x37D6EC0", VA = "0x1837D86C0")]
	private void AFECIOHLDHP(TKey OHPCNPKOLBJ, TVal FKKGMPDEPMA, int ALCHALOFNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37D88E0", Offset = "0x37D70E0", VA = "0x1837D88E0")]
	public bool BMEEDNIBCMM(TKey OHPCNPKOLBJ, TVal FKKGMPDEPMA, bool NAMBBDKOFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37D8E10", Offset = "0x37D7610", VA = "0x1837D8E10")]
	private bool OIFPIBDBCNL(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public sealed class ANNKFHDNJKL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate int DHFGFDLJGEC(TKey OHPCNPKOLBJ, TVal FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class JGKAEEODDHK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TVal PENMJFOMGMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int JFBFKJBMEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x76A240", Offset = "0x768A40", VA = "0x18076A240")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x76A230", Offset = "0x768A30", VA = "0x18076A230")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DateTime HECBACGBGNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x76E490", Offset = "0x76CC90", VA = "0x18076E490")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x37F6240", Offset = "0x37F4A40", VA = "0x1837F6240")]
		public JGKAEEODDHK(TKey OHPCNPKOLBJ, TVal LLMHDPLKODA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EFBPKMAHOEL : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ANNKFHDNJKL<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private LinkedList<JGKAEEODDHK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD5F440", Offset = "0xD5DC40", VA = "0x180D5F440", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x30668F0", Offset = "0x30650F0", VA = "0x1830668F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public EFBPKMAHOEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3058DD0", Offset = "0x30575D0", VA = "0x183058DD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3066050", Offset = "0x3064850", VA = "0x183066050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3066670", Offset = "0x3064E70", VA = "0x183066670")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3066810", Offset = "0x3065010", VA = "0x183066810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int GLFEPNAJPMP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Dictionary<TKey, LinkedListNode<JGKAEEODDHK>> PPJFMCCCMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LinkedList<JGKAEEODDHK> PFPIKJNGOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DHFGFDLJGEC? DMFLHDOIEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly TimeSpan MJDNJJPLLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LBIPAEGLLIM FELCAGANLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool IOKNCEJFGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<TKey> JMOPJMJGKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TVal> LGFNOHLLBDA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KPFJFCCFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x780BE0", Offset = "0x77F3E0", VA = "0x180780BE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal int PHGFPDLNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x780BF0", Offset = "0x77F3F0", VA = "0x180780BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD52470", Offset = "0xD50C70", VA = "0x180D52470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x353E650", Offset = "0x353CE50", VA = "0x18353E650", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ICollection<TVal> PCCFJEBLDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x353E780", Offset = "0x353CF80", VA = "0x18353E780", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ICollection<TKey> IDictionary<TKey, TVal>.AINKNKEPDFE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x353C030", Offset = "0x353A830", VA = "0x18353C030", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BHLLMPIDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TVal HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x353E6C0", Offset = "0x353CEC0", VA = "0x18353E6C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x353E7D0", Offset = "0x353CFD0", VA = "0x18353E7D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3538200", Offset = "0x3536A00", VA = "0x183538200")]
	private bool JPCKDPNCIFN(int AFOFPPEGLDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x353B210", Offset = "0x3539A10", VA = "0x18353B210")]
	private void OLJKPHKBNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x353CE50", Offset = "0x353B650", VA = "0x18353CE50")]
	public ANNKFHDNJKL(int AFOFPPEGLDI, [Optional] DHFGFDLJGEC? DMFLHDOIEKI, [Optional] IEqualityComparer<TKey>? LFDOLHGMGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x353CF10", Offset = "0x353B710", VA = "0x18353CF10")]
	public ANNKFHDNJKL(int AFOFPPEGLDI, TimeSpan MJDNJJPLLGB, [Optional] IEqualityComparer<TKey>? LFDOLHGMGMP, [Optional] LBIPAEGLLIM? FELCAGANLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x353D350", Offset = "0x353BB50", VA = "0x18353D350")]
	public ANNKFHDNJKL(int AFOFPPEGLDI, DHFGFDLJGEC? DMFLHDOIEKI, TimeSpan MJDNJJPLLGB, [Optional] IEqualityComparer<TKey>? LFDOLHGMGMP, [Optional] LBIPAEGLLIM? FELCAGANLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3537FE0", Offset = "0x35367E0", VA = "0x183537FE0")]
	public bool GMHGHBIHHCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3535720", Offset = "0x3533F20", VA = "0x183535720")]
	public bool BDBCOBMPIOA(int ALCHALOFNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x353AE40", Offset = "0x3539640", VA = "0x18353AE40")]
	public void NLGFMFNDGBJ(TKey OHPCNPKOLBJ, TVal FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3534600", Offset = "0x3532E00", VA = "0x183534600", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BBKHFDEMMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3534120", Offset = "0x3532920", VA = "0x183534120", Slot = "9")]
	public void Add(TKey OHPCNPKOLBJ, TVal FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3535BD0", Offset = "0x35343D0", VA = "0x183535BD0", Slot = "8")]
	public bool ContainsKey(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3535BD0", Offset = "0x35343D0", VA = "0x183535BD0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x353B660", Offset = "0x3539E60", VA = "0x18353B660", Slot = "10")]
	public bool Remove(TKey OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x353B8F0", Offset = "0x353A0F0", VA = "0x18353B8F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3537AF0", Offset = "0x35362F0", VA = "0x183537AF0")]
	private TVal FBPOFKNEBFB(TKey ENDMHKCFGAC)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x353C7C0", Offset = "0x353AFC0", VA = "0x18353C7C0", Slot = "11")]
	public bool TryGetValue(TKey ENDMHKCFGAC, [Out] TVal FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x35359E0", Offset = "0x35341E0", VA = "0x1835359E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3536D30", Offset = "0x3535530", VA = "0x183536D30", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] INLAJDDNHAO, int ILBHPPPGDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3538320", Offset = "0x3536B20", VA = "0x183538320")]
	private bool LCKJMINOBON(JGKAEEODDHK LILOFDOPKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3539EE0", Offset = "0x35386E0", VA = "0x183539EE0")]
	private void MJHOHGHGELE(LinkedListNode<JGKAEEODDHK> NJHNMAHHOFE, TVal OPLCONEPBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x35389D0", Offset = "0x35371D0", VA = "0x1835389D0")]
	private void MBJHCBMMMCF(TKey OHPCNPKOLBJ, TVal FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3537210", Offset = "0x3535A10", VA = "0x183537210")]
	private void EABPMDLMEMB(JGKAEEODDHK LILOFDOPKLN, TVal OPLCONEPBPN, int HOIGBFLHEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3538170", Offset = "0x3536970", VA = "0x183538170", Slot = "19")]
	[IteratorStateMachine(typeof(ANNKFHDNJKL<, >.EFBPKMAHOEL))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x353C060", Offset = "0x353A860", VA = "0x18353C060", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct DONEPLDDCIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
	public static DONEPLDDCIP GEJJKAGDKLH(Type GFGNPBCFEMC, [Optional] string? EPOGKLEKFDC, [Optional] string? KJKIGIJNFEN, bool IFANNIOGNEI = false)
	{
		return default(DONEPLDDCIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
	public static DONEPLDDCIP GEJJKAGDKLH<T>([Optional] string? EPOGKLEKFDC, [Optional] string? KJKIGIJNFEN, bool IFANNIOGNEI = false)
	{
		return default(DONEPLDDCIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NEJBAEMJEJI
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool GKKAPEKONKF(string LFBMADHHLBN, NEJBAEMJEJI JJIMBECFBJE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int OKPFOPOABKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public string OHPJMNEMOJM;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D569D0", Offset = "0x5D551D0", VA = "0x185D569D0")]
	public static Dictionary<string, NEJBAEMJEJI> IFBMBDHMAMB(Type PDPBANGJAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D564E0", Offset = "0x5D54CE0", VA = "0x185D564E0")]
	public static Dictionary<string, NEJBAEMJEJI> CMCAPIKEEMG(Type PDPBANGJAIJ, GKKAPEKONKF IAIKMBLEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D56D00", Offset = "0x5D55500", VA = "0x185D56D00")]
	public static Dictionary<int, string> LBJHCMBHCMP(Dictionary<string, NEJBAEMJEJI> KLIANGHAKAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class LFPEGEGCACF : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string OIDLIBPKLAB(string MEMKKNNDEPK);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	protected LFPEGEGCACF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class BJFJCNKKJDP : HNHFFBALMII
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static bool EEBOHGOOINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly string? HAMKJOACCHG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public virtual HNHFFBALMII? NKLILLKCBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D54A80", Offset = "0x5D53280", VA = "0x185D54A80")]
	protected BJFJCNKKJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string DGMFKNHADKE();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D54630", Offset = "0x5D52E30", VA = "0x185D54630", Slot = "8")]
	public virtual string JODBLPNBBHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D546B0", Offset = "0x5D52EB0", VA = "0x185D546B0", Slot = "9")]
	public void OOGJIHOKGOC(StringBuilder DPALHCMCODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D545D0", Offset = "0x5D52DD0", VA = "0x185D545D0", Slot = "10")]
	public void IIGMHKBNNAM(StringBuilder DPALHCMCODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D54960", Offset = "0x5D53160", VA = "0x185D54960", Slot = "11")]
	public void PLDGBCEPLHA(StringBuilder DPALHCMCODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D543D0", Offset = "0x5D52BD0", VA = "0x185D543D0", Slot = "12")]
	public void CBHGCLENHFD(StringBuilder DPALHCMCODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D54530", Offset = "0x5D52D30", VA = "0x185D54530")]
	public static void HAIHBJKMMEP(StringBuilder DPALHCMCODE, string JLLCDOEMBKB, string CHIGOJGOCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50CEF90", Offset = "0x50CD790", VA = "0x1850CEF90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BEJOPDEFJCL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D540D0", Offset = "0x5D528D0", VA = "0x185D540D0")]
	public BEJOPDEFJCL(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KPPKKFPIMIK<TErr> : BEJOPDEFJCL where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly TErr FDDGFIMPJIB;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x388D070", Offset = "0x388B870", VA = "0x18388D070")]
	private KPPKKFPIMIK([In] TErr POIAODAIGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x388CFA0", Offset = "0x388B7A0", VA = "0x18388CFA0")]
	public static KPPKKFPIMIK<TErr> KKMBICLNKPK([In] TErr POIAODAIGHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HNHFFBALMII
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JODBLPNBBHB();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DGMFKNHADKE();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GOAAHNOJEMO<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TOptions PENMJFOMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CECHIGACAOK
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string AIDHNAEKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LJPLPJECAJK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D563A0", Offset = "0x5D54BA0", VA = "0x185D563A0")]
	public LJPLPJECAJK(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FMGCGNHAGNJ<TOk> : LJPLPJECAJK where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly TOk MNICHMIMJBF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3427610", Offset = "0x3425E10", VA = "0x183427610")]
	private FMGCGNHAGNJ([In] TOk CDGCEODHIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x30ABF30", Offset = "0x30AA730", VA = "0x1830ABF30")]
	public static FMGCGNHAGNJ<TOk> KKMBICLNKPK([In] TOk CDGCEODHIJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct EOPMGLNDIOA<TOk, TErr> : IEquatable<EOPMGLNDIOA<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly EqualityComparer<TErr> OOPAHJKJIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal readonly TErr FDDGFIMPJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly TOk MNICHMIMJBF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool LLFDKBOOECM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x30A8C70", Offset = "0x30A7470", VA = "0x1830A8C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AJFCKGBFHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x30A7BF0", Offset = "0x30A63F0", VA = "0x1830A7BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x30AB6A0", Offset = "0x30A9EA0", VA = "0x1830AB6A0")]
	internal EOPMGLNDIOA([In] TErr POIAODAIGHM, [In] TOk CDGCEODHIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x30A8290", Offset = "0x30A6A90", VA = "0x1830A8290")]
	public static EOPMGLNDIOA<TOk, TErr> MKDJFBCCHAH([In] TErr POIAODAIGHM)
	{
		return default(EOPMGLNDIOA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x30A8A10", Offset = "0x30A7210", VA = "0x1830A8A10")]
	public static EOPMGLNDIOA<TOk, TErr> NBGPODOEBIE([In] TOk CDGCEODHIJK)
	{
		return default(EOPMGLNDIOA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2158080", Offset = "0x2156880", VA = "0x182158080")]
	public EOPMGLNDIOA<UOk?, TErr?> INAHGDNBMMI<UOk>()
	{
		return default(EOPMGLNDIOA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2157730", Offset = "0x2155F30", VA = "0x182157730")]
	public EOPMGLNDIOA<UOk?, TErr?> FOGODLMEPOP<UOk>()
	{
		return default(EOPMGLNDIOA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2157080", Offset = "0x2155880", VA = "0x182157080")]
	public EOPMGLNDIOA<TOk?, UErr?> CHOKGHHMAHC<UErr>()
	{
		return default(EOPMGLNDIOA<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x30A7600", Offset = "0x30A5E00", VA = "0x1830A7600")]
	public EOPMGLNDIOA<JGIANJFFIJK, TErr> JIFFMBNIFBI()
	{
		return default(EOPMGLNDIOA<JGIANJFFIJK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x30A4DB0", Offset = "0x30A35B0", VA = "0x1830A4DB0")]
	public static bool BIBGNMIHGGC([In] EOPMGLNDIOA<TOk, TErr> PEEDIPGMMHL, [In] EOPMGLNDIOA<TOk, TErr> PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x30A58D0", Offset = "0x30A40D0", VA = "0x1830A58D0", Slot = "4")]
	public bool Equals(EOPMGLNDIOA<TOk, TErr> IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x30A5B30", Offset = "0x30A4330", VA = "0x1830A5B30", Slot = "0")]
	public override bool Equals(object IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x30A74E0", Offset = "0x30A5CE0", VA = "0x1830A74E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x30AB130", Offset = "0x30A9930", VA = "0x1830AB130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NPEOGDEALCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GEIABMPFJPF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task<EOPMGLNDIOA<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<EOPMGLNDIOA<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x34D3CB0", Offset = "0x34D24B0", VA = "0x1834D3CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x34D4610", Offset = "0x34D2E10", VA = "0x1834D4610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class OHMOOPDFJLG<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
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
		private IEnumerable<EOPMGLNDIOA<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IEnumerable<EOPMGLNDIOA<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<EOPMGLNDIOA<TOk, TErr>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public OHMOOPDFJLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3058DD0", Offset = "0x30575D0", VA = "0x183058DD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF7E0", Offset = "0x3CDDFE0", VA = "0x183CDF7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFB10", Offset = "0x3CDE310", VA = "0x183CDFB10")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFC20", Offset = "0x3CDE420", VA = "0x183CDFC20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CDFB60", Offset = "0x3CDE360", VA = "0x183CDFB60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3227FA0", Offset = "0x32267A0", VA = "0x183227FA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x24BEB20", Offset = "0x24BD320", VA = "0x1824BEB20")]
	public static EOPMGLNDIOA<TOk?, TErr?> MNICHMIMJBF<TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [In] TOk CDGCEODHIJK)
	{
		return default(EOPMGLNDIOA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x24C0F40", Offset = "0x24BF740", VA = "0x1824C0F40")]
	public static EOPMGLNDIOA<JGIANJFFIJK, TErr?> MNICHMIMJBF<TErr>([In] this EOPMGLNDIOA<JGIANJFFIJK, TErr> AFFJMIFONEM)
	{
		return default(EOPMGLNDIOA<JGIANJFFIJK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x24BEB20", Offset = "0x24BD320", VA = "0x1824BEB20")]
	public static EOPMGLNDIOA<TOk?, TErr?> FDDGFIMPJIB<TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [In] TErr POIAODAIGHM)
	{
		return default(EOPMGLNDIOA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x24C0320", Offset = "0x24BEB20", VA = "0x1824C0320")]
	public static TOk? HCBLMIIIHLP<TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x24C0880", Offset = "0x24BF080", VA = "0x1824C0880")]
	[AsyncStateMachine(typeof(GEIABMPFJPF<, >))]
	public static Task<TOk?>? KDFGEBAHOMO<TOk, TErr>(this Task<EOPMGLNDIOA<TOk, TErr>> AFFJMIFONEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x24C0BD0", Offset = "0x24BF3D0", VA = "0x1824C0BD0")]
	public static TErr? MLEHHDEGEFA<TErr, TOk>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x24BEF00", Offset = "0x24BD700", VA = "0x1824BEF00")]
	public static bool DJFAOPBALCL<TOk, TErr, UErr, UOk>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [Out] EOPMGLNDIOA<UOk, UErr> OGLDFEMADMC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x24BED90", Offset = "0x24BD590", VA = "0x1824BED90")]
	public static bool ACFHKGODOLL<TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [Out][NotNullWhen(true)] TOk CDGCEODHIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x24C0F70", Offset = "0x24BF770", VA = "0x1824C0F70")]
	public static bool PGKHIDKOJKC<TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [Out][NotNullWhen(true)] TErr POIAODAIGHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x24BFBD0", Offset = "0x24BE3D0", VA = "0x1824BFBD0")]
	public static bool DPLALNHLGNB<TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [Out][NotNullWhen(true)] TOk CDGCEODHIJK, [Out][NotNullWhen(false)] TErr POIAODAIGHM) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x24BEE00", Offset = "0x24BD600", VA = "0x1824BEE00")]
	public static bool BNFBLMOLHPM<TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [Out][NotNullWhen(true)] TOk CDGCEODHIJK, [Out] EOPMGLNDIOA<TOk, TErr> OGLDFEMADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x24BF010", Offset = "0x24BD810", VA = "0x1824BF010")]
	public static bool DJFAOPBALCL<TOk, TErr, UErr, UOk>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [Out][NotNullWhen(true)] TOk CDGCEODHIJK, [Out] EOPMGLNDIOA<UOk, UErr> OGLDFEMADMC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x24BFE70", Offset = "0x24BE670", VA = "0x1824BFE70")]
	public static bool GONGAMDNBHI<TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [Out][NotNullWhen(true)] TOk CDGCEODHIJK, [Out] EOPMGLNDIOA<JGIANJFFIJK, TErr> OGLDFEMADMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x24C1170", Offset = "0x24BF970", VA = "0x1824C1170")]
	public static EOPMGLNDIOA<UOk, UErr> PLLLFBCGBNF<UOk, UErr, TOk, TErr>([In] this EOPMGLNDIOA<TOk, TErr> AFFJMIFONEM, [In] EOPMGLNDIOA<UOk, UErr> EANKMFHELBA) where TOk : UOk where TErr : UErr
	{
		return default(EOPMGLNDIOA<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x24C0540", Offset = "0x24BED40", VA = "0x1824C0540")]
	public static EOPMGLNDIOA<TOk?[]?, TErr?> IBCAGNBDIGP<TOk, TErr>(this IEnumerable<EOPMGLNDIOA<TOk, TErr>> AFFJMIFONEM)
	{
		return default(EOPMGLNDIOA<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x22B0260", Offset = "0x22AEA60", VA = "0x1822B0260")]
	[IteratorStateMachine(typeof(OHMOOPDFJLG<, >))]
	public static IEnumerable<TOk?>? ICLCMKEIBMO<TOk, TErr>(this IEnumerable<EOPMGLNDIOA<TOk, TErr>> AFFJMIFONEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KDJIDDLFHJC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2292B70", Offset = "0x2291370", VA = "0x182292B70")]
	public static EOPMGLNDIOA<TOk, T> MNICHMIMJBF<TOk>([In] TOk CDGCEODHIJK) where TOk : notnull
	{
		return default(EOPMGLNDIOA<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3859C00", Offset = "0x3858400", VA = "0x183859C00")]
	public static EOPMGLNDIOA<JGIANJFFIJK, T> MNICHMIMJBF()
	{
		return default(EOPMGLNDIOA<JGIANJFFIJK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2292B70", Offset = "0x2291370", VA = "0x182292B70")]
	public static EOPMGLNDIOA<T, TErr> FDDGFIMPJIB<TErr>([In] TErr POIAODAIGHM) where TErr : notnull
	{
		return default(EOPMGLNDIOA<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public sealed class GDFFIHDGPCO<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private readonly struct DLOFKIHDGII : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly GDFFIHDGPCO<T> IHHNBBMCFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int GGMDJPGGEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool EFCICDNAEED;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1B49D10", Offset = "0x1B48510", VA = "0x181B49D10")]
		public DLOFKIHDGII(GDFFIHDGPCO<T> PCEPPDLMHCM, int IDBCLAANONJ, bool POHGEFEPGAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4D1D7F0", Offset = "0x4D1BFF0", VA = "0x184D1D7F0")]
		public GDFFIHDGPCO<T>.OOJKCPICMAG EKEEKKCIFJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4D1D8E0", Offset = "0x4D1C0E0", VA = "0x184D1D8E0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4D1D8E0", Offset = "0x4D1C0E0", VA = "0x184D1D8E0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class OOJKCPICMAG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly GDFFIHDGPCO<T> IHHNBBMCFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int NKFEJJAHPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int ILNEPKOKDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool EFCICDNAEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool MANJIBPABNA;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T NPBPBJCHJJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3CF6800", Offset = "0x3CF5000", VA = "0x183CF6800")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3CF69B0", Offset = "0x3CF51B0", VA = "0x183CF69B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x3CF6A20", Offset = "0x3CF5220", VA = "0x183CF6A20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7080", Offset = "0x3CF5880", VA = "0x183CF7080")]
		public OOJKCPICMAG(GDFFIHDGPCO<T> PCEPPDLMHCM, int IDBCLAANONJ, bool POHGEFEPGAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3CF68C0", Offset = "0x3CF50C0", VA = "0x183CF68C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6950", Offset = "0x3CF5150", VA = "0x183CF6950", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MOAJBPLLDHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MOAJBPLLDHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3B49450", Offset = "0x3B47C50", VA = "0x183B49450")]
		internal T EHIAOAJMCDN(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] LDFELICCGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int ILNEPKOKDNB;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PFKHHAHBINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x34D1FD0", Offset = "0x34D07D0", VA = "0x1834D1FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T NPBPBJCHJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x33E9CF0", Offset = "0x33E84F0", VA = "0x1833E9CF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T FELPMHHOECD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x34D1EB0", Offset = "0x34D06B0", VA = "0x1834D1EB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x34D2110", Offset = "0x34D0910", VA = "0x1834D2110")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LPJHKGAOANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15076E0", Offset = "0x1505EE0", VA = "0x1815076E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xE26360", Offset = "0xE24B60", VA = "0x180E26360")]
	private static int BOALFNKBFGJ(int LFEFGCGCIAG, int HPFMIMMLOKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x34D2390", Offset = "0x34D0B90", VA = "0x1834D2390")]
	public GDFFIHDGPCO(int ALCHALOFNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x34D2170", Offset = "0x34D0970", VA = "0x1834D2170")]
	public GDFFIHDGPCO(int ALCHALOFNIJ, Func<T> HCKADBHHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x34D25E0", Offset = "0x34D0DE0", VA = "0x1834D25E0")]
	public GDFFIHDGPCO(T[] GINKMKLCKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x34D1EE0", Offset = "0x34D06E0", VA = "0x1834D1EE0")]
	public void FIOMFNAAIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x34D1F10", Offset = "0x34D0710", VA = "0x1834D1F10")]
	public IEnumerable<T> JEGCLBKLHEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x34D1E20", Offset = "0x34D0620", VA = "0x1834D1E20")]
	public GDFFIHDGPCO<T>.OOJKCPICMAG EKEEKKCIFJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x338ADA0", Offset = "0x33895A0", VA = "0x18338ADA0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x338ADA0", Offset = "0x33895A0", VA = "0x18338ADA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class COIIHCEHNLG
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x21F1EF0", Offset = "0x21F06F0", VA = "0x1821F1EF0")]
	public static GDFFIHDGPCO<T> KKMBICLNKPK<T>(int ALCHALOFNIJ, Func<T> HCKADBHHCEA) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x1C29280", Offset = "0x1C27A80", VA = "0x181C29280")]
		public RRColor(float FPMFDFOAOMK, float KFNMLAFPLMK, float DNOEGKBPKDC, float EOFAJFKEBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D56F40", Offset = "0x5D55740", VA = "0x185D56F40", Slot = "4")]
		public bool Equals(RRColor IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D56FC0", Offset = "0x5D557C0", VA = "0x185D56FC0", Slot = "0")]
		public override bool Equals(object IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D570C0", Offset = "0x5D558C0", VA = "0x185D570C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D57140", Offset = "0x5D55940", VA = "0x185D57140", Slot = "5")]
		public string ToString(string KDEPONGBNBL, IFormatProvider EOGMDBIKFJF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class BFJLHCNFEJB<TData> : BJFJCNKKJDP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly string IDHPNAJLNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly TData IDDGLNBEBBG;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
	public override string DGMFKNHADKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x43F2970", Offset = "0x43F1170", VA = "0x1843F2970")]
	internal BFJLHCNFEJB(string BKGEBGGPBLH, [In] TData AELCABDCBDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KEIJMIFCHGI
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x22229A0", Offset = "0x22211A0", VA = "0x1822229A0")]
	public static BFJLHCNFEJB<TData> KKMBICLNKPK<TData>(string BKGEBGGPBLH, [In] TData AELCABDCBDD) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BGOKCOOGDFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Dictionary<object, float> ODGKAPIJCAN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float OMCFJNGJEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7EE890", Offset = "0x7ED090", VA = "0x1807EE890")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE930", Offset = "0x7ED130", VA = "0x1807EE930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D541A0", Offset = "0x5D529A0", VA = "0x185D541A0")]
	public void MBJHCBMMMCF(float FKKGMPDEPMA, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5D54130", Offset = "0x5D52930", VA = "0x185D54130")]
	public void JOFGEAIJLMD(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D54210", Offset = "0x5D52A10", VA = "0x185D54210")]
	private void OPPIDHHOBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D54340", Offset = "0x5D52B40", VA = "0x185D54340")]
	public BGOKCOOGDFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class KKNFFPJFICE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class KAGKIIGEGDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public KAGKIIGEGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3852E60", Offset = "0x3851660", VA = "0x183852E60")]
		internal int GGKINMOBPPP(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<T>? GBADDAGNAFH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<T> LBKOEAIALKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3880070", Offset = "0x387E870", VA = "0x183880070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool DIGKAJPHPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x38800E0", Offset = "0x387E8E0", VA = "0x1838800E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76B5C0", Offset = "0x769DC0", VA = "0x18076B5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x387FF00", Offset = "0x387E700", VA = "0x18387FF00")]
	public bool BONJGFNEKBE(T KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3880120", Offset = "0x387E920", VA = "0x183880120")]
	public bool PJFBCFIPABD(T KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x38800A0", Offset = "0x387E8A0", VA = "0x1838800A0")]
	public bool FGLNMIBCGML(T KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3880240", Offset = "0x387EA40", VA = "0x183880240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KKNFFPJFICE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class JCNOBKCLCPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly string NJKABOPHCHO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public JCNOBKCLCPM(string NJKABOPHCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D56350", Offset = "0x5D54B50", VA = "0x185D56350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class BOKOFNDFGJO
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class BOCOKLPEACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BOCOKLPEACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5D54E10", Offset = "0x5D53610", VA = "0x185D54E10")]
		internal int GGKINMOBPPP(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<object>? GBADDAGNAFH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<object> LBKOEAIALKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D55010", Offset = "0x5D53810", VA = "0x185D55010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool DIGKAJPHPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D55100", Offset = "0x5D53900", VA = "0x185D55100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76B5C0", Offset = "0x769DC0", VA = "0x18076B5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D54EC0", Offset = "0x5D536C0", VA = "0x185D54EC0")]
	public bool BONJGFNEKBE(object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D55110", Offset = "0x5D53910", VA = "0x185D55110")]
	public bool PJFBCFIPABD(object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D550A0", Offset = "0x5D538A0", VA = "0x185D550A0")]
	public bool FGLNMIBCGML(object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D54FA0", Offset = "0x5D537A0", VA = "0x185D54FA0")]
	public void DMLFCNEOIOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D551B0", Offset = "0x5D539B0", VA = "0x185D551B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BOKOFNDFGJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class AAKBOGCEFIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct FGMALKEJNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float PMPGADNFOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public T PENMJFOMGMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<object, FGMALKEJNLK> ODGKAPIJCAN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual T IMCFEIGNAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD5F440", Offset = "0xD5DC40", VA = "0x180D5F440", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD5EA20", Offset = "0xD5D220", VA = "0x180D5EA20", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public object? CEHPHENOKKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PEGKONONGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x347D490", Offset = "0x347BC90", VA = "0x18347D490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x347D7D0", Offset = "0x347BFD0", VA = "0x18347D7D0")]
	public bool MBJHCBMMMCF(T FKKGMPDEPMA, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x347D400", Offset = "0x347BC00", VA = "0x18347D400")]
	public bool JOFGEAIJLMD(object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x347BDD0", Offset = "0x347A5D0", VA = "0x18347BDD0")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x347DDC0", Offset = "0x347C5C0", VA = "0x18347DDC0")]
	public bool OCMBKDFPCIC(object KIAKEGJPMAL, [Out] T FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x347C150", Offset = "0x347A950", VA = "0x18347C150")]
	[NPPCPPENLBO("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JGBMEOLLDOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x347E070", Offset = "0x347C870", VA = "0x18347E070")]
	public AAKBOGCEFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface BMHPEAOJIIJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BBPBFMKJKPP MHNMLCHLJDK;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FINJGDFJPJF : BMHPEAOJIIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct DOAOFKJCABD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public readonly float IIKKOHLIEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly float GGLEHKIOADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal readonly bool ODGHFELEPIL;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float JFBFKJBMEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5D55590", Offset = "0x5D53D90", VA = "0x185D55590")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5D55700", Offset = "0x5D53F00", VA = "0x185D55700")]
		public DOAOFKJCABD(float OKLBOBFEAFH, float NHGOLACKIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D555A0", Offset = "0x5D53DA0", VA = "0x185D555A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class GOJIKLGGMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FINJGDFJPJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GOJIKLGGMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D562B0", Offset = "0x5D54AB0", VA = "0x185D562B0")]
		internal void DKFJINOJOBC(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly int AFOFPPEGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int ENFONFPEKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BMHPEAOJIIJ[] GFBPJNOKDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly BBPBFMKJKPP[] HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly DOAOFKJCABD[] ELJCFJIMIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private DOAOFKJCABD JKKFMLBAIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CABPPMPBKEH NNAFBDHONBG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BBPBFMKJKPP MHNMLCHLJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D55FD0", Offset = "0x5D547D0", VA = "0x185D55FD0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D55F10", Offset = "0x5D54710", VA = "0x185D55F10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D56120", Offset = "0x5D54920", VA = "0x185D56120")]
	public FINJGDFJPJF(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D56090", Offset = "0x5D54890", VA = "0x185D56090")]
	public CABPPMPBKEH PDGADBCGIPO(DOAOFKJCABD PIGGPAHNFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D55AA0", Offset = "0x5D542A0", VA = "0x185D55AA0")]
	public void FMHMCOLHNJE(BMHPEAOJIIJ LCCHAKFGHKD, [Optional] DOAOFKJCABD EAIAHMAGBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D55990", Offset = "0x5D54190", VA = "0x185D55990", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void BBPBFMKJKPP(float HCHEOAHOBMM);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class EPPAJNNMPFF
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class LLCALBKCIGG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly BMHPEAOJIIJ PMGNMNCIOJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly BBPBFMKJKPP ABCKGGDLEKO;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D56450", Offset = "0x5D54C50", VA = "0x185D56450")]
		public LLCALBKCIGG(BMHPEAOJIIJ PMGNMNCIOJM, BBPBFMKJKPP ABCKGGDLEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D56400", Offset = "0x5D54C00", VA = "0x185D56400", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D55860", Offset = "0x5D54060", VA = "0x185D55860")]
	internal static bool CPAJGNFPNNC(float EOFAJFKEBLN, float DNOEGKBPKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F460", Offset = "0x5D4DC60", VA = "0x185D4F460")]
	internal static float MPODNFMOHJL(float EOFAJFKEBLN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D558D0", Offset = "0x5D540D0", VA = "0x185D558D0")]
	public static IDisposable LNHKELMGMHI(this BMHPEAOJIIJ PMGNMNCIOJM, BBPBFMKJKPP ABCKGGDLEKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CABPPMPBKEH : BMHPEAOJIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private float HCHEOAHOBMM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float NKGMCPKNFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D55400", Offset = "0x5D53C00", VA = "0x185D55400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BBPBFMKJKPP? MHNMLCHLJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D554F0", Offset = "0x5D53CF0", VA = "0x185D554F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D55360", Offset = "0x5D53B60", VA = "0x185D55360", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CABPPMPBKEH()
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
