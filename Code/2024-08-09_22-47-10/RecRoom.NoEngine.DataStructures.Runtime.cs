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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x69CD960", Offset = "0x69CCD60", VA = "0x1869CD960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class EJBMFFDOGGC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	protected EJBMFFDOGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class FAOKJHIJNEP<T> : EJBMFFDOGGC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct BAHHLCHAAAG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum BFJLNAOKPBN
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
		public BFJLNAOKPBN EPPKBKJHHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T FADGJFNLBLP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int MIOIFHKMCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool PFLMCJLGOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool PDFFJOHOGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? BPFIHGLKOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<BAHHLCHAAAG>? KOENKOAABPD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JBCLFIMPEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C054F0", Offset = "0x3C048F0", VA = "0x183C054F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C05B30", Offset = "0x3C04F30", VA = "0x183C05B30")]
	protected FAOKJHIJNEP(bool PDFFJOHOGJM, bool PFLMCJLGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C05710", Offset = "0x3C04B10", VA = "0x183C05710")]
	protected bool NJHFKDHBMKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C05A20", Offset = "0x3C04E20", VA = "0x183C05A20")]
	protected void OIIKIHHJGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C057B0", Offset = "0x3C04BB0", VA = "0x183C057B0")]
	protected void NLEEODOAEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29C5EE0", Offset = "0x29C52E0", VA = "0x1829C5EE0")]
	private static void KJJJPEDNINL<U>(List<U>? EGGGJKKPDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C05150", Offset = "0x3C04550", VA = "0x183C05150", Slot = "4")]
	public void HINMMBAADBG(T FADGJFNLBLP, bool GAIKGMBFPOF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C05550", Offset = "0x3C04950", VA = "0x183C05550", Slot = "5")]
	public void LHAIFCNDDDC(T FADGJFNLBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C05350", Offset = "0x3C04750", VA = "0x183C05350")]
	public void IHJLNMEMMCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class IDDBOOGKPOH : FAOKJHIJNEP<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69CC880", Offset = "0x69CBC80", VA = "0x1869CC880")]
	public IDDBOOGKPOH(bool PDFFJOHOGJM = false, bool PFLMCJLGOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69CC680", Offset = "0x69CBA80", VA = "0x1869CC680")]
	public void KGLFFAEFCMK()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69CC5C0", Offset = "0x69CB9C0", VA = "0x1869CC5C0")]
	public static IDDBOOGKPOH CDGOBHHNFHF(IDDBOOGKPOH BHMIJEJFBMG, Action FADGJFNLBLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69CC620", Offset = "0x69CBA20", VA = "0x1869CC620")]
	public static IDDBOOGKPOH JNBOOEIEALK(IDDBOOGKPOH BHMIJEJFBMG, Action FADGJFNLBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LDOFCHACGJL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HINMMBAADBG(Action<T> FADGJFNLBLP, bool GAIKGMBFPOF = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHAIFCNDDDC(Action<T> FADGJFNLBLP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HLCMNEBCMLD<T> : FAOKJHIJNEP<Action<T>>, LDOFCHACGJL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C14210", Offset = "0x3C13610", VA = "0x183C14210")]
	public HLCMNEBCMLD(bool PDFFJOHOGJM = false, bool PFLMCJLGOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B650", Offset = "0x3D8AA50", VA = "0x183D8B650")]
	public void KGLFFAEFCMK(T JILAKCNFFBM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C10530", Offset = "0x3C0F930", VA = "0x183C10530")]
	public static HLCMNEBCMLD<T> CDGOBHHNFHF(HLCMNEBCMLD<T> BHMIJEJFBMG, Action<T> FADGJFNLBLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C105D0", Offset = "0x3C0F9D0", VA = "0x183C105D0")]
	public static HLCMNEBCMLD<T> JNBOOEIEALK(HLCMNEBCMLD<T> BHMIJEJFBMG, Action<T> FADGJFNLBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HNJFEFLPEEF<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FGIECLHLMKA<T, U> : FAOKJHIJNEP<Action<T, U>>, HNJFEFLPEEF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C14210", Offset = "0x3C13610", VA = "0x183C14210")]
	public FGIECLHLMKA(bool PDFFJOHOGJM = false, bool PFLMCJLGOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C12280", Offset = "0x3C11680", VA = "0x183C12280")]
	public void KGLFFAEFCMK(T JILAKCNFFBM, U LHMNLCMOFPN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C10530", Offset = "0x3C0F930", VA = "0x183C10530")]
	public static FGIECLHLMKA<T, U> CDGOBHHNFHF(FGIECLHLMKA<T, U> BHMIJEJFBMG, Action<T, U> FADGJFNLBLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C105D0", Offset = "0x3C0F9D0", VA = "0x183C105D0")]
	public static FGIECLHLMKA<T, U> JNBOOEIEALK(FGIECLHLMKA<T, U> BHMIJEJFBMG, Action<T, U> FADGJFNLBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class DMOKIFNKBFF<T, U, V> : FAOKJHIJNEP<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C14210", Offset = "0x3C13610", VA = "0x183C14210")]
	public DMOKIFNKBFF(bool PDFFJOHOGJM = false, bool PFLMCJLGOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x57AAA40", Offset = "0x57A9E40", VA = "0x1857AAA40")]
	public void KGLFFAEFCMK(T JILAKCNFFBM, U LHMNLCMOFPN, V LMJDILMPEPB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C10530", Offset = "0x3C0F930", VA = "0x183C10530")]
	public static DMOKIFNKBFF<T, U, V> CDGOBHHNFHF(DMOKIFNKBFF<T, U, V> BHMIJEJFBMG, Action<T, U, V> FADGJFNLBLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C105D0", Offset = "0x3C0F9D0", VA = "0x183C105D0")]
	public static DMOKIFNKBFF<T, U, V> JNBOOEIEALK(DMOKIFNKBFF<T, U, V> BHMIJEJFBMG, Action<T, U, V> FADGJFNLBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BGBEMCMCDAP<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class KPDEMCMPLDH<T, U, V, W> : FAOKJHIJNEP<Action<T, U, V, W>>, BGBEMCMCDAP<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C14210", Offset = "0x3C13610", VA = "0x183C14210")]
	public KPDEMCMPLDH(bool PDFFJOHOGJM = false, bool PFLMCJLGOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x41B4680", Offset = "0x41B3A80", VA = "0x1841B4680")]
	public void KGLFFAEFCMK(T JILAKCNFFBM, U LHMNLCMOFPN, V LMJDILMPEPB, W GBJEKHMFAAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3C10530", Offset = "0x3C0F930", VA = "0x183C10530")]
	public static KPDEMCMPLDH<T, U, V, W> CDGOBHHNFHF(KPDEMCMPLDH<T, U, V, W> BHMIJEJFBMG, Action<T, U, V, W> FADGJFNLBLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C105D0", Offset = "0x3C0F9D0", VA = "0x183C105D0")]
	public static KPDEMCMPLDH<T, U, V, W> JNBOOEIEALK(KPDEMCMPLDH<T, U, V, W> BHMIJEJFBMG, Action<T, U, V, W> FADGJFNLBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class GHCDMDDONHK<T, U, V, W, X> : FAOKJHIJNEP<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C14210", Offset = "0x3C13610", VA = "0x183C14210")]
	public GHCDMDDONHK(bool PDFFJOHOGJM = false, bool PFLMCJLGOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D0BFA0", Offset = "0x3D0B3A0", VA = "0x183D0BFA0")]
	public void KGLFFAEFCMK(T JILAKCNFFBM, U LHMNLCMOFPN, V LMJDILMPEPB, W GBJEKHMFAAD, X PCHHOKEGOFA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C10530", Offset = "0x3C0F930", VA = "0x183C10530")]
	public static GHCDMDDONHK<T, U, V, W, X> CDGOBHHNFHF(GHCDMDDONHK<T, U, V, W, X> BHMIJEJFBMG, Action<T, U, V, W, X> FADGJFNLBLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C105D0", Offset = "0x3C0F9D0", VA = "0x183C105D0")]
	public static GHCDMDDONHK<T, U, V, W, X> JNBOOEIEALK(GHCDMDDONHK<T, U, V, W, X> BHMIJEJFBMG, Action<T, U, V, W, X> FADGJFNLBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MCHPHPAFJFB<T, U, V, W, X, Y> : FAOKJHIJNEP<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C14210", Offset = "0x3C13610", VA = "0x183C14210")]
	public MCHPHPAFJFB(bool PDFFJOHOGJM = false, bool PFLMCJLGOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x442A4A0", Offset = "0x44298A0", VA = "0x18442A4A0")]
	public void KGLFFAEFCMK(T JILAKCNFFBM, U LHMNLCMOFPN, V LMJDILMPEPB, W GBJEKHMFAAD, X PCHHOKEGOFA, Y PDEIPLKJFKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C10530", Offset = "0x3C0F930", VA = "0x183C10530")]
	public static MCHPHPAFJFB<T, U, V, W, X, Y> CDGOBHHNFHF(MCHPHPAFJFB<T, U, V, W, X, Y> BHMIJEJFBMG, Action<T, U, V, W, X, Y> FADGJFNLBLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C105D0", Offset = "0x3C0F9D0", VA = "0x183C105D0")]
	public static MCHPHPAFJFB<T, U, V, W, X, Y> JNBOOEIEALK(MCHPHPAFJFB<T, U, V, W, X, Y> BHMIJEJFBMG, Action<T, U, V, W, X, Y> FADGJFNLBLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EONKPPNBPLP<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EKKHAIENDFM<TKey, TVal> IEJBNJCCGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FCHJGAJFHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EKKHAIENDFM<TKey, TVal>.GJKPIGIGINO? EGHIENPIIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int PCMFMOMGHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EKKHAIENDFM<TKey, TVal>.FNIOMMEFNLM? BCGLFNGGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int HCOLCBGAPGL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int HLLPDLANKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x38A8820", Offset = "0x38A7C20", VA = "0x1838A8820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KCFIBABDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84D8E0", Offset = "0x84CCE0", VA = "0x18084D8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38A90C0", Offset = "0x38A84C0", VA = "0x1838A90C0")]
	public EONKPPNBPLP(int PCMFMOMGHAG, [Optional] EKKHAIENDFM<TKey, TVal>.FNIOMMEFNLM? BCGLFNGGIPE, [Optional] IEqualityComparer<TKey>? DLECDAECJBD, [Optional] EKKHAIENDFM<TKey, TVal>.GJKPIGIGINO? EGHIENPIIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38A8330", Offset = "0x38A7730", VA = "0x1838A8330")]
	public void AODFGHKMPKD(TKey PEDCMDADFIN, TVal OBEEJPGJPFD, bool GBIMPGLEDHN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38A8DB0", Offset = "0x38A81B0", VA = "0x1838A8DB0")]
	public bool PCNJILEEFML(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38A8B80", Offset = "0x38A7F80", VA = "0x1838A8B80")]
	public bool LPPDNPILAFJ(TKey CJPLGKPLOID, [Out] TVal OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x38A8560", Offset = "0x38A7960", VA = "0x1838A8560")]
	private void BGJADJDIIIA(TKey PEDCMDADFIN, TVal OBEEJPGJPFD, int CGDIEJGGJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x38A8F10", Offset = "0x38A8310", VA = "0x1838A8F10")]
	public bool PNJABNPHEFJ(TKey PEDCMDADFIN, TVal OBEEJPGJPFD, bool GBIMPGLEDHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x38A8990", Offset = "0x38A7D90", VA = "0x1838A8990")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38A7DD0", Offset = "0x38A71D0", VA = "0x1838A7DD0")]
	private void ABMDCMOEJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38A8A40", Offset = "0x38A7E40", VA = "0x1838A8A40")]
	private bool LKFNEFDEJDL(TKey PEDCMDADFIN, BAHDLBOHLPA PCEHLDFDGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38A8870", Offset = "0x38A7C70", VA = "0x1838A8870")]
	private void HDMOKMLJCIG(TKey PEDCMDADFIN, TVal OBEEJPGJPFD, BAHDLBOHLPA PCEHLDFDGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38A8C80", Offset = "0x38A8080", VA = "0x1838A8C80")]
	private void OODCMMBBEHI(TKey PEDCMDADFIN, TVal ELOBPEFBAOG, BAHDLBOHLPA PCEHLDFDGKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DIKANDNNFHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action JFIHFJMLFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool KIIADHIFHLC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public DIKANDNNFHA(Action EKIBOKOLFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69CBEE0", Offset = "0x69CB2E0", VA = "0x1869CBEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2993FE0", Offset = "0x29933E0", VA = "0x182993FE0")]
	public static HBLPGBNKBAE<T> IBMNHJIAJMD<T>(T OBEEJPGJPFD, Action EKIBOKOLFHK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HBLPGBNKBAE<T> : DIKANDNNFHA where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D51390", Offset = "0x3D50790", VA = "0x183D51390")]
	public HBLPGBNKBAE(T OBEEJPGJPFD, Action EKIBOKOLFHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KEANECDCJIE<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly INKOGCBHIJP<T>? BAFECIPHAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> CHCFHGBABLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool KIIADHIFHLC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly KEANECDCJIE<T> ADMHPKLFINC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> LHDEBCFIDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x417CE00", Offset = "0x417C200", VA = "0x18417CE00")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long LHAGCGMDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x417D130", Offset = "0x417C530", VA = "0x18417D130")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OODFNLHIOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x417D3D0", Offset = "0x417C7D0", VA = "0x18417D3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x417D5E0", Offset = "0x417C9E0", VA = "0x18417D5E0")]
	public KEANECDCJIE(INKOGCBHIJP<T> AOJMOGFEDOF, INKOGCBHIJP<T> PNNNKHNHMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x417DB30", Offset = "0x417CF30", VA = "0x18417DB30")]
	public KEANECDCJIE(INKOGCBHIJP<T> AOJMOGFEDOF, int OCDCDAOIAHP, INKOGCBHIJP<T> PNNNKHNHMGA, int BPGNOEICGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x417D6D0", Offset = "0x417CAD0", VA = "0x18417D6D0")]
	private KEANECDCJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x417CFE0", Offset = "0x417C3E0", VA = "0x18417CFE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x417CF30", Offset = "0x417C330", VA = "0x18417CF30")]
	public T[] DDIJPMGPJCD()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x417D1F0", Offset = "0x417C5F0", VA = "0x18417D1F0")]
	public static ReadOnlySequence<T> JHFAHDJBNPM(KEANECDCJIE<T>? KJLAIINFKNM)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MNJBIBIKDGH : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct OKMAGOJDOCF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960")]
		public static OKMAGOJDOCF DDEJLDFANAB()
		{
			return default(OKMAGOJDOCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2C56BC0", Offset = "0x2C55FC0", VA = "0x182C56BC0")]
	public static string? HCIHAIDMCLI<T>([Optional] string? IBIFKAEALKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2C56C40", Offset = "0x2C56040", VA = "0x182C56C40")]
	public static string? ILDOELNHKEO<T>([Optional] string? AFLNMEBKJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960")]
	public static MNJBIBIKDGH LGFLGPOJCKG(string IBIFKAEALKE, string? AFLNMEBKJFJ)
	{
		return default(MNJBIBIKDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OLJDNHLONJI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool PAFDKBIFAAI(string NHPOKFJPMIA, OLJDNHLONJI FJEDFMGGOJP);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PPCGICCNACB<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public PPCGICCNACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x47F60B0", Offset = "0x47F54B0", VA = "0x1847F60B0")]
		internal void MHPKKGDCNON(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int LOBINIIDBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string PLLHDLDAAKH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69CD9E0", Offset = "0x69CCDE0", VA = "0x1869CD9E0")]
	public static Dictionary<string, OLJDNHLONJI> IMCEMPHCFHK(Type NNEDBKLGMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2D163E0", Offset = "0x2D157E0", VA = "0x182D163E0")]
	public static Dictionary<string, OLJDNHLONJI> IMCEMPHCFHK<T>(Type NNEDBKLGMOJ, IReadOnlyDictionary<T, string> IBGNEDBCNPN) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2D16C20", Offset = "0x2D16020", VA = "0x182D16C20")]
	public static Dictionary<string, OLJDNHLONJI> PPNNCNBIJAK<T>(List<T> GCCPMHDLFHK) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x69CDED0", Offset = "0x69CD2D0", VA = "0x1869CDED0")]
	public static Dictionary<string, OLJDNHLONJI> KJALOKANJMD(Type NNEDBKLGMOJ, PAFDKBIFAAI GCKDFHDKCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69CDD10", Offset = "0x69CD110", VA = "0x1869CDD10")]
	public static Dictionary<int, string> JJALHLKIJFM(Dictionary<string, OLJDNHLONJI> LMADGEINEAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class NDGMACBFDAM : EHALGCGAKNL
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool KIICKLFDGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? NAOEKEEJIBD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual EHALGCGAKNL? EJNCOKHAPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69CD8F0", Offset = "0x69CCCF0", VA = "0x1869CD8F0")]
	protected NDGMACBFDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GBCPGMBELKL();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69CD240", Offset = "0x69CC640", VA = "0x1869CD240", Slot = "8")]
	public virtual string CEIHFNNANCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69CD640", Offset = "0x69CCA40", VA = "0x1869CD640", Slot = "9")]
	public void KNJIPDCJBFO(StringBuilder ECLLAFFOGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69CD2C0", Offset = "0x69CC6C0", VA = "0x1869CD2C0", Slot = "10")]
	public void CGLILGMMCCL(StringBuilder ECLLAFFOGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69CD520", Offset = "0x69CC920", VA = "0x1869CD520", Slot = "11")]
	public void KMNPCHHBDGN(StringBuilder ECLLAFFOGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69CD3C0", Offset = "0x69CC7C0", VA = "0x1869CD3C0", Slot = "12")]
	public void HOCCMGMOBEF(StringBuilder ECLLAFFOGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69CD320", Offset = "0x69CC720", VA = "0x1869CD320")]
	public static void HILIGKGMJGM(StringBuilder ECLLAFFOGPI, string DMIDNBGIOEG, string PDIDFFBDLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FA30", Offset = "0x5B8EE30", VA = "0x185B8FA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FAFHGNJPDGL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69CBF20", Offset = "0x69CB320", VA = "0x1869CBF20")]
	public FAFHGNJPDGL(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JKBNBCFDCAA<TErr> : FAFHGNJPDGL where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr FOEFAMIOPFC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x406A8C0", Offset = "0x4069CC0", VA = "0x18406A8C0")]
	private JKBNBCFDCAA([In] TErr AEODDHFADNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x406A7F0", Offset = "0x4069BF0", VA = "0x18406A7F0")]
	public static JKBNBCFDCAA<TErr> DDEJLDFANAB([In] TErr AEODDHFADNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PFIILJENONF : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm PFMFNNBDBJL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool NIDHICMEJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool MOACFHMIOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool EEJLLDKGCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long LHAGCGMDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69CE5C0", Offset = "0x69CD9C0", VA = "0x1869CE5C0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long DJODFMOGEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69CE630", Offset = "0x69CDA30", VA = "0x1869CE630", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69CE6A0", Offset = "0x69CDAA0", VA = "0x1869CE6A0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69CE550", Offset = "0x69CD950", VA = "0x1869CE550")]
	public PFIILJENONF(HashAlgorithm PFMFNNBDBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69CE370", Offset = "0x69CD770", VA = "0x1869CE370", Slot = "35")]
	public override int Read(byte[] OAAIHOHLDCK, int BILMLHHHLMM, int MLMABEGDEJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69CE520", Offset = "0x69CD920", VA = "0x1869CE520", Slot = "38")]
	public override void Write(byte[] OAAIHOHLDCK, int BILMLHHHLMM, int MLMABEGDEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69CE410", Offset = "0x69CD810", VA = "0x1869CE410", Slot = "33")]
	public override long Seek(long BILMLHHHLMM, SeekOrigin ONDJJILFCHN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69CE4A0", Offset = "0x69CD8A0", VA = "0x1869CE4A0", Slot = "34")]
	public override void SetLength(long OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69CE290", Offset = "0x69CD690", VA = "0x1869CE290")]
	public byte[] LGDOPAGJNMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EHALGCGAKNL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CEIHFNNANCI();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GBCPGMBELKL();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KLJKKIGEDML<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PELIPOHCNLF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string OIJJNEFMNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class INKOGCBHIJP<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static INKOGCBHIJP<T>? OLKHMEPPGOL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object CNNGFDDCIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? GMJCHMLMADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool KIIADHIFHLC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ENEMNHNNKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x95D4A0", Offset = "0x95C8A0", VA = "0x18095D4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A460", Offset = "0x3E79860", VA = "0x183E7A460")]
	private static INKOGCBHIJP<T> DNKMLGOPKPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B950", Offset = "0x3E7AD50", VA = "0x183E7B950")]
	private static void NGNEMKEILBG(INKOGCBHIJP<T> CGEDPFEDPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3E4DFE0", Offset = "0x3E4D3E0", VA = "0x183E4DFE0")]
	private INKOGCBHIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B580", Offset = "0x3E7A980", VA = "0x183E7B580")]
	public static INKOGCBHIJP<T> IBMNHJIAJMD(ReadOnlyMemory<T> BMEIKHNJDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B370", Offset = "0x3E7A770", VA = "0x183E7B370")]
	public static INKOGCBHIJP<T> IBMNHJIAJMD(IMemoryOwner<T> JOKKABLCCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B060", Offset = "0x3E7A460", VA = "0x183E7B060")]
	public static void HEOBHBKPLDH(INKOGCBHIJP<T> AOJMOGFEDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A900", Offset = "0x3E79D00", VA = "0x183E7A900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AE00", Offset = "0x3E7A200", VA = "0x183E7AE00")]
	public INKOGCBHIJP<T> GAGCAMMLDDC(IMemoryOwner<T> JOKKABLCCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B850", Offset = "0x3E7AC50", VA = "0x183E7B850")]
	private void IDNDIGBHLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AF10", Offset = "0x3E7A310", VA = "0x183E7AF10")]
	private INKOGCBHIJP<T> GGFOGKOPAJA(INKOGCBHIJP<T> CGEDPFEDPGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ADCODLBBDCF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69CB080", Offset = "0x69CA480", VA = "0x1869CB080")]
	public ADCODLBBDCF(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CJDLHANCALO<TOk> : ADCODLBBDCF where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk EPAMLPHBLKO;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5030E80", Offset = "0x5030280", VA = "0x185030E80")]
	private CJDLHANCALO([In] TOk KDHHPJECAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3807510", Offset = "0x3806910", VA = "0x183807510")]
	public static CJDLHANCALO<TOk> DDEJLDFANAB([In] TOk KDHHPJECAPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PJHADMLCJMO : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly ReadOnlySequence<byte> CHCFHGBABLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private SequencePosition AFEMHMGKLPL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override bool NIDHICMEJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override bool MOACFHMIOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override bool EEJLLDKGCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public override long LHAGCGMDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69CF0E0", Offset = "0x69CE4E0", VA = "0x1869CF0E0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override long DJODFMOGEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69CF140", Offset = "0x69CE540", VA = "0x1869CF140", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69CF210", Offset = "0x69CE610", VA = "0x1869CF210", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69CF010", Offset = "0x69CE410", VA = "0x1869CF010")]
	public PJHADMLCJMO(ReadOnlySequence<byte> KJLAIINFKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69CEBC0", Offset = "0x69CDFC0", VA = "0x1869CEBC0", Slot = "33")]
	public override long Seek(long BILMLHHHLMM, SeekOrigin ONDJJILFCHN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69CE720", Offset = "0x69CDB20", VA = "0x1869CE720", Slot = "35")]
	public override int Read(byte[] OAAIHOHLDCK, int BILMLHHHLMM, int MLMABEGDEJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x69CEF50", Offset = "0x69CE350", VA = "0x1869CEF50", Slot = "34")]
	public override void SetLength(long OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x69CEFB0", Offset = "0x69CE3B0", VA = "0x1869CEFB0", Slot = "38")]
	public override void Write(byte[] OAAIHOHLDCK, int BILMLHHHLMM, int MLMABEGDEJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct NNKIHJJJOOI<TOk, TErr> : IEquatable<NNKIHJJJOOI<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> DDNHOBPPELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr FOEFAMIOPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk EPAMLPHBLKO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EPPKOALNHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x454FD70", Offset = "0x454F170", VA = "0x18454FD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HFFPHHLCJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x454D870", Offset = "0x454CC70", VA = "0x18454D870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4555340", Offset = "0x4554740", VA = "0x184555340")]
	internal NNKIHJJJOOI([In] TErr AEODDHFADNJ, [In] TOk KDHHPJECAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x45507B0", Offset = "0x454FBB0", VA = "0x1845507B0")]
	public static NNKIHJJJOOI<TOk, TErr> IEKFBEHFNNA([In] TErr AEODDHFADNJ)
	{
		return default(NNKIHJJJOOI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x454D6F0", Offset = "0x454CAF0", VA = "0x18454D6F0")]
	public static NNKIHJJJOOI<TOk, TErr> AFHEIJIJBMP([In] TOk KDHHPJECAPC)
	{
		return default(NNKIHJJJOOI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2C006E0", Offset = "0x2BFFAE0", VA = "0x182C006E0")]
	public NNKIHJJJOOI<TOk?, UErr?> PDAFOAHILEL<UErr>()
	{
		return default(NNKIHJJJOOI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF1C0", Offset = "0x2BFE5C0", VA = "0x182BFF1C0")]
	public NNKIHJJJOOI<UOk?, TErr?> EALLKCPEBLK<UOk>()
	{
		return default(NNKIHJJJOOI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C00230", Offset = "0x2BFF630", VA = "0x182C00230")]
	public NNKIHJJJOOI<UOk?, TErr?> NGIFNFNNMHD<UOk>()
	{
		return default(NNKIHJJJOOI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF640", Offset = "0x2BFEA40", VA = "0x182BFF640")]
	public NNKIHJJJOOI<TOk?, UErr?> LAHJEKFMLDD<UErr>()
	{
		return default(NNKIHJJJOOI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4552330", Offset = "0x4551730", VA = "0x184552330")]
	public NNKIHJJJOOI<AEFODLADDHH, TErr> JEFMDICKCFI()
	{
		return default(NNKIHJJJOOI<AEFODLADDHH, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4551690", Offset = "0x4550A90", VA = "0x184551690")]
	public static bool JAICCEKEELH([In] NNKIHJJJOOI<TOk, TErr> JNFNBKNOBNN, [In] NNKIHJJJOOI<TOk, TErr> CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x454DE10", Offset = "0x454D210", VA = "0x18454DE10", Slot = "4")]
	public bool Equals(NNKIHJJJOOI<TOk, TErr> IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x454DEE0", Offset = "0x454D2E0", VA = "0x18454DEE0", Slot = "0")]
	public override bool Equals(object IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x454EE00", Offset = "0x454E200", VA = "0x18454EE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4553B60", Offset = "0x4552F60", VA = "0x184553B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class HFCPKCGEEOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KOKBBMEKBPP<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<NNKIHJJJOOI<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<NNKIHJJJOOI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x41B2820", Offset = "0x41B1C20", VA = "0x1841B2820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x41B2B40", Offset = "0x41B1F40", VA = "0x1841B2B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A940", Offset = "0x2B79D40", VA = "0x182B7A940")]
	public static NNKIHJJJOOI<TOk?, TErr?> EPAMLPHBLKO<TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [In] TOk KDHHPJECAPC)
	{
		return default(NNKIHJJJOOI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A990", Offset = "0x2B79D90", VA = "0x182B7A990")]
	public static NNKIHJJJOOI<AEFODLADDHH, TErr?> EPAMLPHBLKO<TErr>([In] this NNKIHJJJOOI<AEFODLADDHH, TErr> ABPJKOBADEP)
	{
		return default(NNKIHJJJOOI<AEFODLADDHH, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A940", Offset = "0x2B79D40", VA = "0x182B7A940")]
	public static NNKIHJJJOOI<TOk?, TErr?> FOEFAMIOPFC<TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [In] TErr AEODDHFADNJ)
	{
		return default(NNKIHJJJOOI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A3A0", Offset = "0x2B797A0", VA = "0x182B7A3A0")]
	public static TOk? CPJNCFJLLJD<TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B79F60", Offset = "0x2B79360", VA = "0x182B79F60")]
	[AsyncStateMachine(typeof(KOKBBMEKBPP<, >))]
	public static Task<TOk?>? CGBDGPIMCHM<TOk, TErr>(this Task<NNKIHJJJOOI<TOk, TErr>> ABPJKOBADEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B79A70", Offset = "0x2B78E70", VA = "0x182B79A70")]
	public static TErr? AEHFMIOJNBC<TErr, TOk>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BA70", Offset = "0x2B7AE70", VA = "0x182B7BA70")]
	public static bool LGLMEIAOFNJ<TOk, TErr, UErr, UOk>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [Out] NNKIHJJJOOI<UOk, UErr> ALFINHHCJDN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B79E70", Offset = "0x2B79270", VA = "0x182B79E70")]
	public static bool BLIKEGGDBAK<TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [Out][NotNullWhen(true)] TOk KDHHPJECAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B79D90", Offset = "0x2B79190", VA = "0x182B79D90")]
	public static bool AMJONBMGPMK<TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [Out][NotNullWhen(true)] TErr AEODDHFADNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CCE0", Offset = "0x2B7C0E0", VA = "0x182B7CCE0")]
	public static bool MFIHKLFCMKC<TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [Out][NotNullWhen(true)] TOk KDHHPJECAPC, [Out][NotNullWhen(false)] TErr AEODDHFADNJ) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A7E0", Offset = "0x2B79BE0", VA = "0x182B7A7E0")]
	public static bool EMKOOMNPFLE<TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [Out][NotNullWhen(true)] TOk KDHHPJECAPC, [Out] NNKIHJJJOOI<TOk, TErr> ALFINHHCJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BCD0", Offset = "0x2B7B0D0", VA = "0x182B7BCD0")]
	public static bool LGLMEIAOFNJ<TOk, TErr, UErr, UOk>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [Out][NotNullWhen(true)] TOk KDHHPJECAPC, [Out] NNKIHJJJOOI<UOk, UErr> ALFINHHCJDN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AC30", Offset = "0x2B7A030", VA = "0x182B7AC30")]
	public static bool GBHEFHDIOOA<TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [Out][NotNullWhen(true)] TOk KDHHPJECAPC, [Out] NNKIHJJJOOI<AEFODLADDHH, TErr> ALFINHHCJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B5F0", Offset = "0x2B7A9F0", VA = "0x182B7B5F0")]
	public static NNKIHJJJOOI<UOk, UErr> LDPCFIKEMKL<UOk, UErr, TOk, TErr>([In] this NNKIHJJJOOI<TOk, TErr> ABPJKOBADEP, [In] NNKIHJJJOOI<UOk, UErr> MHKDAHGGECP) where TOk : UOk where TErr : UErr
	{
		return default(NNKIHJJJOOI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AFE0", Offset = "0x2B7A3E0", VA = "0x182B7AFE0")]
	public static NNKIHJJJOOI<TOk?[]?, TErr?> HIOCAALEANM<TOk, TErr>(this IEnumerable<NNKIHJJJOOI<TOk, TErr>> ABPJKOBADEP)
	{
		return default(NNKIHJJJOOI<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NBOMPNOGMKB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE6F0", Offset = "0x2BFDAF0", VA = "0x182BFE6F0")]
	public static NNKIHJJJOOI<TOk, T> EPAMLPHBLKO<TOk>([In] TOk KDHHPJECAPC) where TOk : notnull
	{
		return default(NNKIHJJJOOI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x44E62E0", Offset = "0x44E56E0", VA = "0x1844E62E0")]
	public static NNKIHJJJOOI<AEFODLADDHH, T> EPAMLPHBLKO()
	{
		return default(NNKIHJJJOOI<AEFODLADDHH, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE790", Offset = "0x2BFDB90", VA = "0x182BFE790")]
	public static NNKIHJJJOOI<T, TErr> FOEFAMIOPFC<TErr>([In] TErr AEODDHFADNJ) where TErr : notnull
	{
		return default(NNKIHJJJOOI<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct MDPKLNLDHKO<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly MAFDHCHNNGN LGGLACOPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> NDBCCNEHODP;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3870", Offset = "0x3CF2C70", VA = "0x183CF3870")]
	public static MDPKLNLDHKO<TKey, TValue> DDEJLDFANAB(string NMIKEFKOPMC)
	{
		return default(MDPKLNLDHKO<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3990", Offset = "0x3CF2D90", VA = "0x183CF3990")]
	internal MDPKLNLDHKO(Dictionary<TKey, TValue> OBEEJPGJPFD, MAFDHCHNNGN FCFBDLPKMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3CF37D0", Offset = "0x3CF2BD0", VA = "0x183CF37D0")]
	public BKDMPDFFHEN<TKey, TValue> CLIGNBJOKPC([Out] Dictionary<TKey, TValue> OBEEJPGJPFD)
	{
		return default(BKDMPDFFHEN<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct BKDMPDFFHEN<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> NDBCCNEHODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KNIBGMHEAIH EIBODBMOKAO;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x21AA870", Offset = "0x21A9C70", VA = "0x1821AA870")]
	internal BKDMPDFFHEN(Dictionary<TKey, TValue> OBEEJPGJPFD, KNIBGMHEAIH JNFKJDMHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D17B60", Offset = "0x3D16F60", VA = "0x183D17B60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct GBNICPIODOH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly MAFDHCHNNGN LGGLACOPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> NDBCCNEHODP;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3870", Offset = "0x3CF2C70", VA = "0x183CF3870")]
	public static GBNICPIODOH<T> DDEJLDFANAB(string NMIKEFKOPMC)
	{
		return default(GBNICPIODOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3990", Offset = "0x3CF2D90", VA = "0x183CF3990")]
	internal GBNICPIODOH(HashSet<T> OBEEJPGJPFD, MAFDHCHNNGN FCFBDLPKMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CF37D0", Offset = "0x3CF2BD0", VA = "0x183CF37D0")]
	public LOFKJOLDLAL<T> CLIGNBJOKPC([Out] HashSet<T> OBEEJPGJPFD)
	{
		return default(LOFKJOLDLAL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LOFKJOLDLAL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> NDBCCNEHODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KNIBGMHEAIH EIBODBMOKAO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x21AA870", Offset = "0x21A9C70", VA = "0x1821AA870")]
	internal LOFKJOLDLAL(HashSet<T> OBEEJPGJPFD, KNIBGMHEAIH JNFKJDMHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D17B60", Offset = "0x3D16F60", VA = "0x183D17B60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct GECJHLABCLI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MAFDHCHNNGN LGGLACOPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> NDBCCNEHODP;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3870", Offset = "0x3CF2C70", VA = "0x183CF3870")]
	public static GECJHLABCLI<T> DDEJLDFANAB(string NMIKEFKOPMC)
	{
		return default(GECJHLABCLI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3990", Offset = "0x3CF2D90", VA = "0x183CF3990")]
	internal GECJHLABCLI(Stack<T> OBEEJPGJPFD, MAFDHCHNNGN FCFBDLPKMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3CF37D0", Offset = "0x3CF2BD0", VA = "0x183CF37D0")]
	public GIPABNJPFMN<T> CLIGNBJOKPC([Out] Stack<T> OBEEJPGJPFD)
	{
		return default(GIPABNJPFMN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct GIPABNJPFMN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> NDBCCNEHODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly KNIBGMHEAIH EIBODBMOKAO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21AA870", Offset = "0x21A9C70", VA = "0x1821AA870")]
	internal GIPABNJPFMN(Stack<T> OBEEJPGJPFD, KNIBGMHEAIH JNFKJDMHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3D17B60", Offset = "0x3D16F60", VA = "0x183D17B60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public sealed class ABMHCBNKMOB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct GAKDKNBIJPN : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ABMHCBNKMOB<T> KFOIPMICHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int HLAEPJNOFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool BPLJFHIIALD;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1EDCC80", Offset = "0x1EDC080", VA = "0x181EDCC80")]
		public GAKDKNBIJPN(ABMHCBNKMOB<T> DJKNDPHDPMJ, int IMEJCCOLLNB, bool IICJFEHCJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9F50", Offset = "0x3CE9350", VA = "0x183CE9F50")]
		public ABMHCBNKMOB<T>.APAAMCMNKCC GHLGIEPLNLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA040", Offset = "0x3CE9440", VA = "0x183CEA040", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA040", Offset = "0x3CE9440", VA = "0x183CEA040", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class APAAMCMNKCC : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly ABMHCBNKMOB<T> KFOIPMICHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int HMDPKIEGGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int DJJBLONGGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool BPLJFHIIALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool KDIDMCFALFA;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T AKMKAIGAIOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x3D7CAC0", Offset = "0x3D7BEC0", VA = "0x183D7CAC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3D7CC70", Offset = "0x3D7C070", VA = "0x183D7CC70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3D7CE90", Offset = "0x3D7C290", VA = "0x183D7CE90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D030", Offset = "0x3D7C430", VA = "0x183D7D030")]
		public APAAMCMNKCC(ABMHCBNKMOB<T> DJKNDPHDPMJ, int IMEJCCOLLNB, bool IICJFEHCJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CB40", Offset = "0x3D7BF40", VA = "0x183D7CB40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CBD0", Offset = "0x3D7BFD0", VA = "0x183D7CBD0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class LNHHCAHMELD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public LNHHCAHMELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4251EA0", Offset = "0x42512A0", VA = "0x184251EA0")]
		internal T EDPCOFAEBIN(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] BPECLLFBDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int DJJBLONGGDA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GLMJGINONMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2CA0", Offset = "0x3CB20A0", VA = "0x183CB2CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T AKMKAIGAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF290", Offset = "0x3BFE690", VA = "0x183BFF290")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T DLIKKPIGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2910", Offset = "0x3CB1D10", VA = "0x183CB2910")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2AE0", Offset = "0x3CB1EE0", VA = "0x183CB2AE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LHAGCGMDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1A15200", Offset = "0x1A14600", VA = "0x181A15200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1232970", Offset = "0x1231D70", VA = "0x181232970")]
	private static int JHBMAKCGGPD(int AGAGKNBDCIG, int CHJNEOPKHME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3000", Offset = "0x3CB2400", VA = "0x183CB3000")]
	public ABMHCBNKMOB(int CGDIEJGGJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2D00", Offset = "0x3CB2100", VA = "0x183CB2D00")]
	public ABMHCBNKMOB(int CGDIEJGGJMK, Func<T> ALEBKOMMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2EC0", Offset = "0x3CB22C0", VA = "0x183CB2EC0")]
	public ABMHCBNKMOB(T[] MDKDACOPOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2A10", Offset = "0x3CB1E10", VA = "0x183CB2A10")]
	public void FOMHFGJIMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2950", Offset = "0x3CB1D50", VA = "0x183CB2950")]
	public IEnumerable<T> FJOPGOPJJOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2A40", Offset = "0x3CB1E40", VA = "0x183CB2A40")]
	public ABMHCBNKMOB<T>.APAAMCMNKCC GHLGIEPLNLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3C80450", Offset = "0x3C7F850", VA = "0x183C80450", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3C80450", Offset = "0x3C7F850", VA = "0x183C80450", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EKFLCMPHMJM
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x29E7330", Offset = "0x29E6730", VA = "0x1829E7330")]
	public static ABMHCBNKMOB<T> DDEJLDFANAB<T>(int CGDIEJGGJMK, Func<T> ALEBKOMMHCJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class DJBLIEENADL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct KFJFJBLLGMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly DJBLIEENADL<T> HBMGILIHJMH;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T KHLHBLNGCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x4182870", Offset = "0x4181C70", VA = "0x184182870")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4182840", Offset = "0x4181C40", VA = "0x184182840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
		public KFJFJBLLGMH(DJBLIEENADL<T> HBMGILIHJMH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct JOHLIJJEODD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<KFJFJBLLGMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public DJBLIEENADL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x407D180", Offset = "0x407C580", VA = "0x18407D180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x40342F0", Offset = "0x40336F0", VA = "0x1840342F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly SemaphoreSlim JBKNFAKIGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private T MKGIJENNKIC;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5795010", Offset = "0x5794410", VA = "0x185795010")]
	public DJBLIEENADL([In] T MKGIJENNKIC, int FBOJEIBHMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5794E80", Offset = "0x5794280", VA = "0x185794E80")]
	public DJBLIEENADL([In] T MKGIJENNKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x57948C0", Offset = "0x5793CC0", VA = "0x1857948C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5794DA0", Offset = "0x57941A0", VA = "0x185794DA0")]
	public KFJFJBLLGMH OLPEJEPCKMN()
	{
		return default(KFJFJBLLGMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5794C80", Offset = "0x5794080", VA = "0x185794C80")]
	[AsyncStateMachine(typeof(DJBLIEENADL<>.JOHLIJJEODD))]
	public Task<DJBLIEENADL<T>.KFJFJBLLGMH> NKGLNDFBANH(CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5794900", Offset = "0x5793D00", VA = "0x185794900")]
	public void JDBELKCJBEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class PNFBBAANPBA
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x69CF350", Offset = "0x69CE750", VA = "0x1869CF350")]
	public static DJBLIEENADL<AEFODLADDHH> DDEJLDFANAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x299BA00", Offset = "0x299AE00", VA = "0x18299BA00")]
	public static DJBLIEENADL<T> DDEJLDFANAB<T>([In] T MKGIJENNKIC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class DPMJFENOEKG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct CNNKJCKGFBF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly DPMJFENOEKG<T> HGBBLFOAMJL;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T KHLHBLNGCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x41B2DE0", Offset = "0x41B21E0", VA = "0x1841B2DE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x503BB60", Offset = "0x503AF60", VA = "0x18503BB60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
		internal CNNKJCKGFBF(DPMJFENOEKG<T> HBMGILIHJMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct KPBLDOMPBGH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly DPMJFENOEKG<T> HGBBLFOAMJL;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T KHLHBLNGCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x41B2DE0", Offset = "0x41B21E0", VA = "0x1841B2DE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x41B2D40", Offset = "0x41B2140", VA = "0x1841B2D40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
		internal KPBLDOMPBGH(DPMJFENOEKG<T> HBMGILIHJMH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PPIPIAJNGJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<KPBLDOMPBGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DPMJFENOEKG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DJBLIEENADL<AEFODLADDHH>.KFJFJBLLGMH <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<DJBLIEENADL<AEFODLADDHH>.KFJFJBLLGMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x47F6D20", Offset = "0x47F6120", VA = "0x1847F6D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x40342F0", Offset = "0x40336F0", VA = "0x1840342F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly DJBLIEENADL<int> JNEKMADKAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly DJBLIEENADL<AEFODLADDHH> AKMOJEGINCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly DJBLIEENADL<AEFODLADDHH> NGDOPAFOCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private T HMINBLBNLJN;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x57AF900", Offset = "0x57AED00", VA = "0x1857AF900")]
	internal DPMJFENOEKG(DJBLIEENADL<int> ENNMPFBLAIK, DJBLIEENADL<AEFODLADDHH> CAOJIBOBFPI, DJBLIEENADL<AEFODLADDHH> CBLLBAHBPFG, [In] T MKGIJENNKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x57AEEE0", Offset = "0x57AE2E0", VA = "0x1857AEEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x57AF220", Offset = "0x57AE620", VA = "0x1857AF220")]
	public CNNKJCKGFBF KLMIKLLHGOP()
	{
		return default(CNNKJCKGFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x57AF5A0", Offset = "0x57AE9A0", VA = "0x1857AF5A0")]
	public KPBLDOMPBGH LLPOKIINHBD()
	{
		return default(KPBLDOMPBGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x57AEDC0", Offset = "0x57AE1C0", VA = "0x1857AEDC0")]
	[AsyncStateMachine(typeof(DPMJFENOEKG<>.PPIPIAJNGJK))]
	public Task<DPMJFENOEKG<T>.KPBLDOMPBGH> CDBBFNLMMKP(CancellationToken GNJJGEHBGKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JABBJLABKND
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x69CC990", Offset = "0x69CBD90", VA = "0x1869CC990")]
	public static DPMJFENOEKG<AEFODLADDHH> DDEJLDFANAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB420", Offset = "0x2BCA820", VA = "0x182BCB420")]
	public static DPMJFENOEKG<T> DDEJLDFANAB<T>([In] T MKGIJENNKIC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class EDGBMDPPHFL<TData> : NDGMACBFDAM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string IBHMBHJJPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData GAMKDEPHLKE;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
	public override string GBCPGMBELKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x37EADB0", Offset = "0x37EA1B0", VA = "0x1837EADB0")]
	internal EDGBMDPPHFL(string PBDOHNMILPN, [In] TData LDNEPNAGEGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KGIHJKCLJHF
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x69CCD50", Offset = "0x69CC150", VA = "0x1869CCD50")]
	public static EDGBMDPPHFL<AEFODLADDHH> DDEJLDFANAB(string PBDOHNMILPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2993FE0", Offset = "0x29933E0", VA = "0x182993FE0")]
	public static EDGBMDPPHFL<TData> DDEJLDFANAB<TData>(string PBDOHNMILPN, [In] TData LDNEPNAGEGN) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class MAFDHCHNNGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	internal bool NDKMHMOONMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly string MFOGJCMIIOI;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1170830", Offset = "0x116FC30", VA = "0x181170830")]
	private MAFDHCHNNGN(bool OGGPIFEAAHL, string AIOOPHMKFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69CCF00", Offset = "0x69CC300", VA = "0x1869CCF00")]
	public static MAFDHCHNNGN DDEJLDFANAB(string AIOOPHMKFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x69CCE40", Offset = "0x69CC240", VA = "0x1869CCE40")]
	public KNIBGMHEAIH CLIGNBJOKPC()
	{
		return default(KNIBGMHEAIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct KNIBGMHEAIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MAFDHCHNNGN ENIDPHBALLI;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	internal KNIBGMHEAIH(MAFDHCHNNGN NMIKEFKOPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x69CCDD0", Offset = "0x69CC1D0", VA = "0x1869CCDD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class JACMCLDKMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Dictionary<object, float> HLFLEOMHHLN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public float NDGNDPOEKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x995C50", Offset = "0x995050", VA = "0x180995C50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF9BDE0", Offset = "0xF9B1E0", VA = "0x180F9BDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x69CCC00", Offset = "0x69CC000", VA = "0x1869CCC00")]
	public void FOIJBIHDOMH(float OBEEJPGJPFD, object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69CCB90", Offset = "0x69CBF90", VA = "0x1869CCB90")]
	public void EIJCBENOGDI(object IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69CCC70", Offset = "0x69CC070", VA = "0x1869CCC70")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69CCA60", Offset = "0x69CBE60", VA = "0x1869CCA60")]
	private void BNGFEJHMOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x69CCCC0", Offset = "0x69CC0C0", VA = "0x1869CCCC0")]
	public JACMCLDKMCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class GGHNACNIGFL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class CGDJBPNGEEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public CGDJBPNGEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x502C780", Offset = "0x502BB80", VA = "0x18502C780")]
		internal int LEDHIBFEJOI(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private HashSet<T>? LPAAJFAEIKM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<T> JNDJCKEBEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B430", Offset = "0x3D0A830", VA = "0x183D0B430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HJDCJAHNCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B630", Offset = "0x3D0AA30", VA = "0x183D0B630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x851810", Offset = "0x850C10", VA = "0x180851810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B470", Offset = "0x3D0A870", VA = "0x183D0B470")]
	public bool HINMMBAADBG(T IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B6D0", Offset = "0x3D0AAD0", VA = "0x183D0B6D0")]
	public bool LHAIFCNDDDC(T IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B680", Offset = "0x3D0AA80", VA = "0x183D0B680")]
	public bool IMCHJPMIMGD(T IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B840", Offset = "0x3D0AC40", VA = "0x183D0B840")]
	public void PCPACKAJFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B920", Offset = "0x3D0AD20", VA = "0x183D0B920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public GGHNACNIGFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KNIEAOFLAHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string GDJAMNBLCJJ;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public KNIEAOFLAHM(string GDJAMNBLCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69CCDF0", Offset = "0x69CC1F0", VA = "0x1869CCDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public sealed class HGDIPJDAGFM
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class IOBEGLELOCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public IOBEGLELOCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x69CC8E0", Offset = "0x69CBCE0", VA = "0x1869CC8E0")]
		internal int LEDHIBFEJOI(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private HashSet<object>? LPAAJFAEIKM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IReadOnlyCollection<object> JNDJCKEBEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x69CC120", Offset = "0x69CB520", VA = "0x1869CC120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HJDCJAHNCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x69CC290", Offset = "0x69CB690", VA = "0x1869CC290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x851810", Offset = "0x850C10", VA = "0x180851810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x69CC1B0", Offset = "0x69CB5B0", VA = "0x1869CC1B0")]
	public bool HINMMBAADBG(object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x69CC300", Offset = "0x69CB700", VA = "0x1869CC300")]
	public bool LHAIFCNDDDC(object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69CC2A0", Offset = "0x69CB6A0", VA = "0x1869CC2A0")]
	public bool IMCHJPMIMGD(object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x69CC3A0", Offset = "0x69CB7A0", VA = "0x1869CC3A0")]
	public void PCPACKAJFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x69CC410", Offset = "0x69CB810", VA = "0x1869CC410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public HGDIPJDAGFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PAFBECGKDIG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct JKOMOFHDNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float DONCGGEOHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public T KHLHBLNGCMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<object, JKOMOFHDNGJ> HLFLEOMHHLN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public virtual T NGNBBADFIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x115E770", Offset = "0x115DB70", VA = "0x18115E770", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x115DD50", Offset = "0x115D150", VA = "0x18115DD50", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public object? AGFKBJMNEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850C00", VA = "0x180851800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool FMMDDAKGCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x47C5910", Offset = "0x47C4D10", VA = "0x1847C5910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x47C4F70", Offset = "0x47C4370", VA = "0x1847C4F70")]
	public bool FOIJBIHDOMH(T OBEEJPGJPFD, object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x417F750", Offset = "0x417EB50", VA = "0x18417F750")]
	public bool EIJCBENOGDI(object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x38231E0", Offset = "0x38225E0", VA = "0x1838231E0")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x47C5590", Offset = "0x47C4990", VA = "0x1847C5590")]
	public bool LPPDNPILAFJ(object IAIFDAAIBBN, [Out] T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x47C4810", Offset = "0x47C3C10", VA = "0x1847C4810")]
	[MPLLCOLDBMG("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BFFIACFLGPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x417FD80", Offset = "0x417F180", VA = "0x18417FD80")]
	public PAFBECGKDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class DLHJELOIAMB<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? LPAAJFAEIKM;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool HJDCJAHNCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x57A1DC0", Offset = "0x57A11C0", VA = "0x1857A1DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x57A20C0", Offset = "0x57A14C0", VA = "0x1857A20C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x57A1B50", Offset = "0x57A0F50", VA = "0x1857A1B50")]
	public void HINMMBAADBG(T IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x57A1EE0", Offset = "0x57A12E0", VA = "0x1857A1EE0")]
	public void LHAIFCNDDDC(T IAIFDAAIBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x57A2080", Offset = "0x57A1480", VA = "0x1857A2080")]
	public void PCPACKAJFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x57A2260", Offset = "0x57A1660", VA = "0x1857A2260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public DLHJELOIAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class DHPDKEBGBGL
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x28F2C80", Offset = "0x28F2080", VA = "0x1828F2C80")]
	public static void IBKMFCNOAPN<T>(this List<T> EGGGJKKPDIP, int AGAGKNBDCIG) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface JALLDNNKLGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BFDHBNDAPBO NHEKKOBNDDP;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DFBBNODABGG : JALLDNNKLGJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public readonly struct MCNLPHAAJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public readonly float OBMMDJGNFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly float DKMKGDDFHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal readonly bool MDFNJNDPCHM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float MBPNHHIKNBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x69CCF70", Offset = "0x69CC370", VA = "0x1869CCF70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x69CD0E0", Offset = "0x69CC4E0", VA = "0x1869CD0E0")]
		public MCNLPHAAJDA(float DEABOIPAFEI, float ANJAKFNPOHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x69CCF80", Offset = "0x69CC380", VA = "0x1869CCF80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class BMEPMAEIMBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DFBBNODABGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public BMEPMAEIMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x69CB1C0", Offset = "0x69CA5C0", VA = "0x1869CB1C0")]
		internal void JDPJJHCPNGK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int HKIABBKKICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int HDCBKIHNKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JALLDNNKLGJ[] FIJFOKKABJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly BFDHBNDAPBO[] PKEMJFONHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MCNLPHAAJDA[] APELOFJBDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private MCNLPHAAJDA OGLPJNDMAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly DGAEKGNLCBP ILOKGELKIIF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BFDHBNDAPBO NHEKKOBNDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x69CBA60", Offset = "0x69CAE60", VA = "0x1869CBA60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x69CB4A0", Offset = "0x69CA8A0", VA = "0x1869CB4A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x69CBB20", Offset = "0x69CAF20", VA = "0x1869CBB20")]
	public DFBBNODABGG(int HKIABBKKICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x69CB9D0", Offset = "0x69CADD0", VA = "0x1869CB9D0")]
	public DGAEKGNLCBP JKIHJDAFEGA(MCNLPHAAJDA AGCBIMLBLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x69CB560", Offset = "0x69CA960", VA = "0x1869CB560")]
	public void IFIMCIEJMGE(JALLDNNKLGJ DAKFOLEAGBO, [Optional] MCNLPHAAJDA PBJGNNHNLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x69CB390", Offset = "0x69CA790", VA = "0x1869CB390", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate void BFDHBNDAPBO(float CPPAJPJEMAI);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CMCNHGKAKEF
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class BFNPJOMNOOD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly JALLDNNKLGJ MNAKMGOPLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly BFDHBNDAPBO PKJIBFLDCKK;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x69CB130", Offset = "0x69CA530", VA = "0x1869CB130")]
		public BFNPJOMNOOD(JALLDNNKLGJ MNAKMGOPLBG, BFDHBNDAPBO PKJIBFLDCKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x69CB0E0", Offset = "0x69CA4E0", VA = "0x1869CB0E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x69CB320", Offset = "0x69CA720", VA = "0x1869CB320")]
	internal static bool OGMCEONGBKL(float DKLJHPKNDLA, float EALBLGNMNKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x69BBC10", Offset = "0x69BB010", VA = "0x1869BBC10")]
	internal static float HOKINNMNJBJ(float DKLJHPKNDLA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x69CB260", Offset = "0x69CA660", VA = "0x1869CB260")]
	public static IDisposable HPBOBIJGJBP(this JALLDNNKLGJ MNAKMGOPLBG, BFDHBNDAPBO PKJIBFLDCKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DGAEKGNLCBP : JALLDNNKLGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private float CPPAJPJEMAI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float JFIHOMBFPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x69CBDF0", Offset = "0x69CB1F0", VA = "0x1869CBDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BFDHBNDAPBO? NHEKKOBNDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x69CBD50", Offset = "0x69CB150", VA = "0x1869CBD50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x69CBCB0", Offset = "0x69CB0B0", VA = "0x1869CBCB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public DGAEKGNLCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LDLOHPGCHAN<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NLNCLBFHJLK<T> MHAKCBKKDMD([Out] T OBEEJPGJPFD);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHJLNMEMMCN();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PIGKABCNPLK<T> : LDLOHPGCHAN<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly ConcurrentStack<T> NFKOFNHLKKD;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x47E0320", Offset = "0x47DF720", VA = "0x1847E0320", Slot = "4")]
	public NLNCLBFHJLK<T> MHAKCBKKDMD([Out] T OBEEJPGJPFD)
	{
		return default(NLNCLBFHJLK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x47E02A0", Offset = "0x47DF6A0", VA = "0x1847E02A0")]
	public void BNLEGFFBAHJ(T DNFFPOCBPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x42422F0", Offset = "0x42416F0", VA = "0x1842422F0", Slot = "5")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "6")]
	protected virtual void BLDDKAGNGIH(T CIADOPIGAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x47E03C0", Offset = "0x47DF7C0", VA = "0x1847E03C0")]
	private T PJLOLBBNKPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x47E0460", Offset = "0x47DF860", VA = "0x1847E0460")]
	public PIGKABCNPLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct NLNCLBFHJLK<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly T DNFFPOCBPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly PIGKABCNPLK<T> JFMKLALBFFP;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
	internal NLNCLBFHJLK(T OBEEJPGJPFD, PIGKABCNPLK<T> JFMKLALBFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x452FDC0", Offset = "0x452F1C0", VA = "0x18452FDC0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class GMFIJLPLNPF : PIGKABCNPLK<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly GMFIJLPLNPF CLHFPJDPLGI;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x69CBFA0", Offset = "0x69CB3A0", VA = "0x1869CBFA0")]
	public static NLNCLBFHJLK<StringBuilder> PJLOLBBNKPI([Out] StringBuilder OBEEJPGJPFD)
	{
		return default(NLNCLBFHJLK<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x69CBF80", Offset = "0x69CB380", VA = "0x1869CBF80", Slot = "6")]
	protected override void BLDDKAGNGIH(StringBuilder CIADOPIGAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x69CC0E0", Offset = "0x69CB4E0", VA = "0x1869CC0E0")]
	public GMFIJLPLNPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class CCDHEJJPKLB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x642FF80", Offset = "0x642F380", VA = "0x18642FF80")]
	public CCDHEJJPKLB(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class IJCJNPDJOBM<TKey, TValue> : ICNIFEFNOGP<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, KLCGCBCODBP where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class ILOGIPHMDAJ : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public IJCJNPDJOBM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x115E770", Offset = "0x115DB70", VA = "0x18115E770", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3E75080", Offset = "0x3E74480", VA = "0x183E75080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public ILOGIPHMDAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3B30310", Offset = "0x3B2F710", VA = "0x183B30310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E74360", Offset = "0x3E73760", VA = "0x183E74360", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E742C0", Offset = "0x3E736C0", VA = "0x183E742C0")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E74EA0", Offset = "0x3E742A0", VA = "0x183E74EA0")]
		private void OANBEGBCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E75030", Offset = "0x3E74430", VA = "0x183E75030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly ICNIFEFNOGP<TKey, TValue> FCHJOOJNKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IDictionary<TKey, TValue> IMAGHNMHJCI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3E51DD0", Offset = "0x3E511D0", VA = "0x183E51DD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LMFKAPMEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public TValue OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3E52080", Offset = "0x3E51480", VA = "0x183E52080", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3E52310", Offset = "0x3E51710", VA = "0x183E52310", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ICollection<TKey> PELJIFFDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3E520D0", Offset = "0x3E514D0", VA = "0x183E520D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ICollection<TValue> LAJDOBJNEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3E521F0", Offset = "0x3E515F0", VA = "0x183E521F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3E51D10", Offset = "0x3E51110", VA = "0x183E51D10")]
	public IJCJNPDJOBM(ICNIFEFNOGP<TKey, TValue> FCHJOOJNKEC, [Optional] IDictionary<TKey, TValue>? IMAGHNMHJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F6B0", Offset = "0x3E4EAB0", VA = "0x183E4F6B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3E51060", Offset = "0x3E50460", VA = "0x183E51060")]
	public void OPGICPOCEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F040", Offset = "0x3E4E440", VA = "0x183E4F040", Slot = "9")]
	public void Add(TKey PEDCMDADFIN, TValue OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3E50750", Offset = "0x3E4FB50", VA = "0x183E50750")]
	public void KEOALECHFJF(TKey PEDCMDADFIN, TValue OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3E502D0", Offset = "0x3E4F6D0", VA = "0x183E502D0")]
	public void IBNEJLAFPLO(TKey PEDCMDADFIN, TValue OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3E50B50", Offset = "0x3E4FF50", VA = "0x183E50B50")]
	public void LAGIFKGNAJC(TKey PEDCMDADFIN, TValue OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F5C0", Offset = "0x3E4E9C0", VA = "0x183E4F5C0")]
	public void BBHFFPKOANK(TKey PEDCMDADFIN, TValue OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3E51310", Offset = "0x3E50710", VA = "0x183E51310", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3E51540", Offset = "0x3E50940", VA = "0x183E51540", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3E518A0", Offset = "0x3E50CA0", VA = "0x183E518A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F7F0", Offset = "0x3E4EBF0", VA = "0x183E4F7F0", Slot = "8")]
	public bool ContainsKey(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3E504C0", Offset = "0x3E4F8C0", VA = "0x183E504C0")]
	public bool JEIGJPOJGKG(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3E50130", Offset = "0x3E4F530", VA = "0x183E50130")]
	public bool HFMKCKCELCF(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3E51170", Offset = "0x3E50570", VA = "0x183E51170", Slot = "10")]
	public bool Remove(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3E51B70", Offset = "0x3E50F70", VA = "0x183E51B70", Slot = "11")]
	public bool TryGetValue(TKey PEDCMDADFIN, [Out] TValue OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3E4FD30", Offset = "0x3E4F130", VA = "0x183E4FD30", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] ELFCOFFIPBP, int PAHMHEIBJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3E51A60", Offset = "0x3E50E60", VA = "0x183E51A60", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3E50020", Offset = "0x3E4F420", VA = "0x183E50020", Slot = "19")]
	[IteratorStateMachine(typeof(IJCJNPDJOBM<, >.ILOGIPHMDAJ))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3E505E0", Offset = "0x3E4F9E0", VA = "0x183E505E0", Slot = "21")]
	public bool KECCOIDDFAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3E50D80", Offset = "0x3E50180", VA = "0x183E50D80")]
	private TValue MEMHAKOCLCJ(TKey PEDCMDADFIN)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface KLCGCBCODBP
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KECCOIDDFAN();
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface ICNIFEFNOGP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KLCGCBCODBP
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public sealed class EKKHAIENDFM<TKey, TVal> : ICNIFEFNOGP<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KLCGCBCODBP where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate int FNIOMMEFNLM(TKey PEDCMDADFIN, TVal OBEEJPGJPFD);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void GJKPIGIGINO(TKey PEDCMDADFIN, TVal OBEEJPGJPFD, BAHDLBOHLPA PCEHLDFDGKI);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private class EOOJNEJLDBH
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public TKey IHHIJGDCGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B50", Offset = "0x99FF50", VA = "0x1809A0B50")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TVal KHLHBLNGCMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x9874E0", Offset = "0x9868E0", VA = "0x1809874E0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x986F90", Offset = "0x986390", VA = "0x180986F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int MBPNHHIKNBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x88BB00", Offset = "0x88AF00", VA = "0x18088BB00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x88B150", Offset = "0x88A550", VA = "0x18088B150")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DateTimeOffset IHOCFFFLKKA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xD2CB80", Offset = "0xD2BF80", VA = "0x180D2CB80")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x15E0530", Offset = "0x15DF930", VA = "0x1815E0530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x38AB1B0", Offset = "0x38AA5B0", VA = "0x1838AB1B0")]
		public EOOJNEJLDBH(TKey PEDCMDADFIN, TVal ELOBPEFBAOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class IALFBENFLBC : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public EKKHAIENDFM<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private LinkedList<EOOJNEJLDBH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x115E770", Offset = "0x115DB70", VA = "0x18115E770", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3B33540", Offset = "0x3B32940", VA = "0x183B33540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public IALFBENFLBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x39D6180", Offset = "0x39D5580", VA = "0x1839D6180", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E2EB20", Offset = "0x3E2DF20", VA = "0x183E2EB20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E770", Offset = "0x3E2DB70", VA = "0x183E2E770")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F8B0", Offset = "0x3E2ECB0", VA = "0x183E2F8B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int LABGBJGOOBI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<TKey, LinkedListNode<EOOJNEJLDBH>> AFNLKMGKFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly LinkedList<EOOJNEJLDBH> KJEFFOFMJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly FNIOMMEFNLM? BCGLFNGGIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly TimeSpan LMHENKNHEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly GJKPIGIGINO? EGHIENPIIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MGCCPOFMDKP FENCGKIOOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool DHKNFGBFJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<TKey> PANGKMPGFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly List<TVal> MBIGDFNDGNM;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KCFIBABDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x85B590", Offset = "0x85A990", VA = "0x18085B590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int HLLPDLANKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xC09BF0", Offset = "0xC08FF0", VA = "0x180C09BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xC093E0", Offset = "0xC087E0", VA = "0x180C093E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x382B7B0", Offset = "0x382ABB0", VA = "0x18382B7B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal int HIEMMOGLKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x38231E0", Offset = "0x38225E0", VA = "0x1838231E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ICollection<TVal> LAJDOBJNEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x382B930", Offset = "0x382AD30", VA = "0x18382B930", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ICollection<TKey> IDictionary<TKey, TVal>.AKLDLCCDAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3826740", Offset = "0x3825B40", VA = "0x183826740", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool LMFKAPMEMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TVal OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x382B8E0", Offset = "0x382ACE0", VA = "0x18382B8E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x382B980", Offset = "0x382AD80", VA = "0x18382B980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3823230", Offset = "0x3822630", VA = "0x183823230")]
	private bool NGOGKNKDHFE(int HKIABBKKICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3823280", Offset = "0x3822680", VA = "0x183823280")]
	private void OFOPCMOAJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3827840", Offset = "0x3826C40", VA = "0x183827840")]
	public EKKHAIENDFM(int HKIABBKKICG, [Optional] FNIOMMEFNLM? BCGLFNGGIPE, [Optional] IEqualityComparer<TKey>? DLECDAECJBD, [Optional] GJKPIGIGINO? EGHIENPIIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3827920", Offset = "0x3826D20", VA = "0x183827920")]
	public EKKHAIENDFM(TimeSpan LMHENKNHEBI, [Optional] IEqualityComparer<TKey>? DLECDAECJBD, [Optional] GJKPIGIGINO? EGHIENPIIDA, [Optional] MGCCPOFMDKP? FENCGKIOOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x38277C0", Offset = "0x3826BC0", VA = "0x1838277C0")]
	public EKKHAIENDFM(int HKIABBKKICG, TimeSpan LMHENKNHEBI, [Optional] IEqualityComparer<TKey>? DLECDAECJBD, [Optional] GJKPIGIGINO? EGHIENPIIDA, [Optional] MGCCPOFMDKP? FENCGKIOOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3829830", Offset = "0x3828C30", VA = "0x183829830")]
	public EKKHAIENDFM(int HKIABBKKICG, FNIOMMEFNLM? BCGLFNGGIPE, TimeSpan LMHENKNHEBI, [Optional] IEqualityComparer<TKey>? DLECDAECJBD, [Optional] GJKPIGIGINO? EGHIENPIIDA, [Optional] MGCCPOFMDKP? FENCGKIOOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x38205C0", Offset = "0x381F9C0", VA = "0x1838205C0", Slot = "21")]
	public bool KECCOIDDFAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3822C60", Offset = "0x3822060", VA = "0x183822C60", Slot = "22")]
	public bool MMNBKHMCMMC(int CGDIEJGGJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x38109C0", Offset = "0x380FDC0", VA = "0x1838109C0")]
	private bool AAEBHCKGAAC(int CGDIEJGGJMK, BAHDLBOHLPA PCEHLDFDGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3820EE0", Offset = "0x38202E0", VA = "0x183820EE0")]
	public void KGJINEABJGO(TKey PEDCMDADFIN, TVal OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3814F60", Offset = "0x3814360", VA = "0x183814F60", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OFMNHGBOMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3814DA0", Offset = "0x38141A0", VA = "0x183814DA0", Slot = "9")]
	public void Add(TKey PEDCMDADFIN, TVal OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3815A70", Offset = "0x3814E70", VA = "0x183815A70", Slot = "8")]
	public bool ContainsKey(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3825D90", Offset = "0x3825190", VA = "0x183825D90", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3825610", Offset = "0x3824A10", VA = "0x183825610", Slot = "10")]
	public bool Remove(TKey PEDCMDADFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3826130", Offset = "0x3825530", VA = "0x183826130", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> OFMNHGBOMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3818CF0", Offset = "0x38180F0", VA = "0x183818CF0")]
	private bool EPAKLDFCBDK(TKey PEDCMDADFIN, [Out] TVal OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3824B00", Offset = "0x3823F00", VA = "0x183824B00")]
	private TVal PJLOLBBNKPI(TKey CJPLGKPLOID)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3826BD0", Offset = "0x3825FD0", VA = "0x183826BD0", Slot = "11")]
	public bool TryGetValue(TKey CJPLGKPLOID, [Out] TVal OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3815890", Offset = "0x3814C90", VA = "0x183815890", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3815C30", Offset = "0x3815030", VA = "0x183815C30", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] ELFCOFFIPBP, int PAHMHEIBJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3823D60", Offset = "0x3823160", VA = "0x183823D60")]
	private void OODCMMBBEHI(TKey PEDCMDADFIN, TVal ELOBPEFBAOG, BAHDLBOHLPA PCEHLDFDGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3813900", Offset = "0x3812D00", VA = "0x183813900")]
	private bool AONIEOMNLBC(EOOJNEJLDBH JFPHNKIMAMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x381FAE0", Offset = "0x381EEE0", VA = "0x18381FAE0")]
	private void INJPCLGDKJG(LinkedListNode<EOOJNEJLDBH> NNHHHLMKIEO, TVal GHKAPCPBCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x381B120", Offset = "0x381A520", VA = "0x18381B120")]
	private void FOIJBIHDOMH(TKey PEDCMDADFIN, TVal OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3821F00", Offset = "0x3821300", VA = "0x183821F00")]
	private void MHIFNPHOLEF(EOOJNEJLDBH JFPHNKIMAMM, TVal GHKAPCPBCAP, int DNJIPLMCGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x381C250", Offset = "0x381B650", VA = "0x18381C250", Slot = "19")]
	[IteratorStateMachine(typeof(EKKHAIENDFM<, >.IALFBENFLBC))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3826790", Offset = "0x3825B90", VA = "0x183826790", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public enum BAHDLBOHLPA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class JBMAEIIHAGK<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly TKey ONONHPDAHKC;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4020330", Offset = "0x401F730", VA = "0x184020330")]
	public JBMAEIIHAGK(TKey NKKJPPIKNPF, Exception PEHEBDOPJEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PGBLIGFDDGH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D12EE0", Offset = "0x5D122E0", VA = "0x185D12EE0")]
	public PGBLIGFDDGH(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class MOLKPPMKELD<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NLEFFNBMLBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public MOLKPPMKELD<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public NLEFFNBMLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x452DF50", Offset = "0x452D350", VA = "0x18452DF50")]
		internal Task<TResource> JCGBBMBIBPC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct JKJMNEBFGFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public MOLKPPMKELD<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x406D330", Offset = "0x406C730", VA = "0x18406D330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x406D730", Offset = "0x406CB30", VA = "0x18406D730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct PGDHHNJFJMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x47D7A60", Offset = "0x47D6E60", VA = "0x1847D7A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x47D7E40", Offset = "0x47D7240", VA = "0x1847D7E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly OKBNIGBJBEA<TId, Task<TResource>> PFNJEMGIPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> MIPDBFEKCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? ENFMADICLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Action<TResource>? OEJKOJAIIPJ;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4483990", Offset = "0x4482D90", VA = "0x184483990")]
	public MOLKPPMKELD(int GELNCKGOOGO = 0, [Optional] IEqualityComparer<TId>? MGMNMGNHBEI, [Optional] Func<TId, CancellationToken, Task<TResource>>? NBBIEMFABAA, [Optional] Action<TResource>? OHPAJHMNNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4482E30", Offset = "0x4482230", VA = "0x184482E30")]
	public HBLPGBNKBAE<Task<TResource>> MBCGHPOLLBN(TId GNBDDFJPEIA, [Optional] Func<TId, CancellationToken, Task<TResource>>? NBBIEMFABAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4482500", Offset = "0x4481900", VA = "0x184482500")]
	private void GHLAODMOCOE(Task<TResource> LKENJOBMDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x44836C0", Offset = "0x4482AC0", VA = "0x1844836C0")]
	[AsyncStateMachine(typeof(MOLKPPMKELD<, >.JKJMNEBFGFD))]
	private Task NAFJGNNDGAI(Task<TResource> LKENJOBMDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4482140", Offset = "0x4481540", VA = "0x184482140")]
	public void DCDDLNMAPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x44826A0", Offset = "0x4481AA0", VA = "0x1844826A0")]
	public OKBNIGBJBEA<TId, Task<TResource>>.LNFDECCOOCH GHLGIEPLNLN()
	{
		return default(OKBNIGBJBEA<TId, Task<TResource>>.LNFDECCOOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x44837C0", Offset = "0x4482BC0", VA = "0x1844837C0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x44837C0", Offset = "0x4482BC0", VA = "0x1844837C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x44829F0", Offset = "0x4481DF0", VA = "0x1844829F0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(MOLKPPMKELD<, >.PGDHHNJFJMN))]
	internal static Task KJCFPJAIMKL(Task<TResource> LKENJOBMDDP, CancellationTokenSource NNNHODELDNF, Dictionary<Task<TResource>, CancellationTokenSource> JPKABACDGJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class OKBNIGBJBEA<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private sealed class LGMNHKFJBLA : IEquatable<LGMNHKFJBLA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly TValue KHLHBLNGCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int FCPBBJFLGJP;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA267F0", Offset = "0xA25BF0", VA = "0x180A267F0")]
		public LGMNHKFJBLA(TValue OBEEJPGJPFD, int HAHLNGALIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x42345B0", Offset = "0x42339B0", VA = "0x1842345B0", Slot = "4")]
		public bool Equals(LGMNHKFJBLA? IEDCHGMDIML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4234510", Offset = "0x4233910", VA = "0x184234510", Slot = "0")]
		public override bool Equals(object? LALIGKIKEBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x42347F0", Offset = "0x4233BF0", VA = "0x1842347F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct LNFDECCOOCH : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Dictionary<TKey, LGMNHKFJBLA>.Enumerator OBHDKPLCGME;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x42516B0", Offset = "0x4250AB0", VA = "0x1842516B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public (TKey Key, TValue Value, int RefCount) AKMKAIGAIOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x4251B10", Offset = "0x4250F10", VA = "0x184251B10", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4251970", Offset = "0x4250D70", VA = "0x184251970")]
		public LNFDECCOOCH(OKBNIGBJBEA<TKey, TValue> HLFLEOMHHLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4251310", Offset = "0x4250710", VA = "0x184251310", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4251350", Offset = "0x4250750", VA = "0x184251350", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4251410", Offset = "0x4250810", VA = "0x184251410", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class KNPNNLNGBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public OKBNIGBJBEA<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public LGMNHKFJBLA refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public KNPNNLNGBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x41AE470", Offset = "0x41AD870", VA = "0x1841AE470")]
		internal void JCGBBMBIBPC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Dictionary<TKey, LGMNHKFJBLA> LLFLKNKNMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Func<TKey, TValue>? KOCOOEPJODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Action<TValue>? FNACBMBAOBL;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x470B5A0", Offset = "0x470A9A0", VA = "0x18470B5A0")]
	public OKBNIGBJBEA(int GELNCKGOOGO = 0, [Optional] IEqualityComparer<TKey>? DLECDAECJBD, [Optional] Func<TKey, TValue>? OKBMNBCKMAP, [Optional] Action<TValue>? FFHGAMBJCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x470AD80", Offset = "0x470A180", VA = "0x18470AD80")]
	public HBLPGBNKBAE<TValue> MBCGHPOLLBN(TKey PEDCMDADFIN, [Optional] Func<TKey, TValue>? LOHMOOALHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4709CE0", Offset = "0x47090E0", VA = "0x184709CE0")]
	private void BNLEGFFBAHJ(TKey PEDCMDADFIN, LGMNHKFJBLA AHPDDPGLMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x470A290", Offset = "0x4709690", VA = "0x18470A290")]
	public void DCDDLNMAPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x470A740", Offset = "0x4709B40", VA = "0x18470A740")]
	public LNFDECCOOCH GHLGIEPLNLN()
	{
		return default(LNFDECCOOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x470B470", Offset = "0x470A870", VA = "0x18470B470", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x470B470", Offset = "0x470A870", VA = "0x18470B470", Slot = "5")]
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
