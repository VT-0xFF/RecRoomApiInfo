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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C3F090", Offset = "0x6C3D690", VA = "0x186C3F090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HAAGAOHNIIN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	protected HAAGAOHNIIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GGHGDCNPFAM<T> : HAAGAOHNIIN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct BOEPMHBNNAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum AKNCLELFBEF
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
		public AKNCLELFBEF JLAAKHANEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T PMCMEAHOBEF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int BEFHNOLKEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool FCDCIMHFHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool CIGIGOAHHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? HLOBNFEBAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<BOEPMHBNNAC>? NOHGJMKFDEH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GODOPKHMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7090", Offset = "0x3DE5690", VA = "0x183DE7090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7AF0", Offset = "0x3DE60F0", VA = "0x183DE7AF0")]
	protected GGHGDCNPFAM(bool CIGIGOAHHAA, bool FCDCIMHFHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DE75B0", Offset = "0x3DE5BB0", VA = "0x183DE75B0")]
	protected bool HHAHFNNEFMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DE79D0", Offset = "0x3DE5FD0", VA = "0x183DE79D0")]
	protected void PHCBBOAIEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7100", Offset = "0x3DE5700", VA = "0x183DE7100")]
	protected void DKHBBHNDLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29434A0", Offset = "0x2941AA0", VA = "0x1829434A0")]
	private static void GMCGEIOCBEN<U>(List<U>? OLAPNOFMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE73A0", Offset = "0x3DE59A0", VA = "0x183DE73A0", Slot = "4")]
	public void FABNFHGMHGJ(T PMCMEAHOBEF, bool PAAMEENNNBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7650", Offset = "0x3DE5C50", VA = "0x183DE7650", Slot = "5")]
	public void MBEEDABKNGP(T PMCMEAHOBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7820", Offset = "0x3DE5E20", VA = "0x183DE7820")]
	public void MPAAPCHGDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GHNLMGKLHKE : GGHGDCNPFAM<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DB00", Offset = "0x6C3C100", VA = "0x186C3DB00")]
	public GHNLMGKLHKE(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D840", Offset = "0x6C3BE40", VA = "0x186C3D840")]
	public void FJEDBGMGJGG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DAA0", Offset = "0x6C3C0A0", VA = "0x186C3DAA0")]
	public static GHNLMGKLHKE PAFCMDDLEJB(GHNLMGKLHKE PPBDJDNHLED, Action PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DA40", Offset = "0x6C3C040", VA = "0x186C3DA40")]
	public static GHNLMGKLHKE LGBBBPLMLIL(GHNLMGKLHKE PPBDJDNHLED, Action PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MODDMLILIKO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FABNFHGMHGJ(Action<T> PMCMEAHOBEF, bool PAAMEENNNBP = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBEEDABKNGP(Action<T> PMCMEAHOBEF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KHECJJJIFBB<T> : GGHGDCNPFAM<Action<T>>, MODDMLILIKO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D23780", Offset = "0x3D21D80", VA = "0x183D23780")]
	public KHECJJJIFBB(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4353D60", Offset = "0x4352360", VA = "0x184353D60")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4354820", Offset = "0x4352E20", VA = "0x184354820")]
	public static KHECJJJIFBB<T> PAFCMDDLEJB(KHECJJJIFBB<T> PPBDJDNHLED, Action<T> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4354780", Offset = "0x4352D80", VA = "0x184354780")]
	public static KHECJJJIFBB<T> LGBBBPLMLIL(KHECJJJIFBB<T> PPBDJDNHLED, Action<T> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CBCOEENKMEI<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class LLEJOEJOMJB<T, U> : GGHGDCNPFAM<Action<T, U>>, CBCOEENKMEI<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D23780", Offset = "0x3D21D80", VA = "0x183D23780")]
	public LLEJOEJOMJB(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4409BE0", Offset = "0x44081E0", VA = "0x184409BE0")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4354820", Offset = "0x4352E20", VA = "0x184354820")]
	public static LLEJOEJOMJB<T, U> PAFCMDDLEJB(LLEJOEJOMJB<T, U> PPBDJDNHLED, Action<T, U> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4354780", Offset = "0x4352D80", VA = "0x184354780")]
	public static LLEJOEJOMJB<T, U> LGBBBPLMLIL(LLEJOEJOMJB<T, U> PPBDJDNHLED, Action<T, U> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MFOJMBEOKED<T, U, V> : GGHGDCNPFAM<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D23780", Offset = "0x3D21D80", VA = "0x183D23780")]
	public MFOJMBEOKED(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4691260", Offset = "0x468F860", VA = "0x184691260")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA, V LEKEIHPCIEI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4354820", Offset = "0x4352E20", VA = "0x184354820")]
	public static MFOJMBEOKED<T, U, V> PAFCMDDLEJB(MFOJMBEOKED<T, U, V> PPBDJDNHLED, Action<T, U, V> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4354780", Offset = "0x4352D80", VA = "0x184354780")]
	public static MFOJMBEOKED<T, U, V> LGBBBPLMLIL(MFOJMBEOKED<T, U, V> PPBDJDNHLED, Action<T, U, V> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LNJEPGINCIJ<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class PODADAJPNKL<T, U, V, W> : GGHGDCNPFAM<Action<T, U, V, W>>, LNJEPGINCIJ<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D23780", Offset = "0x3D21D80", VA = "0x183D23780")]
	public PODADAJPNKL(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x49487A0", Offset = "0x4946DA0", VA = "0x1849487A0")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA, V LEKEIHPCIEI, W BPBILCHNBCA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4354820", Offset = "0x4352E20", VA = "0x184354820")]
	public static PODADAJPNKL<T, U, V, W> PAFCMDDLEJB(PODADAJPNKL<T, U, V, W> PPBDJDNHLED, Action<T, U, V, W> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4354780", Offset = "0x4352D80", VA = "0x184354780")]
	public static PODADAJPNKL<T, U, V, W> LGBBBPLMLIL(PODADAJPNKL<T, U, V, W> PPBDJDNHLED, Action<T, U, V, W> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NPHLJGNJJME<T, U, V, W, X> : GGHGDCNPFAM<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D23780", Offset = "0x3D21D80", VA = "0x183D23780")]
	public NPHLJGNJJME(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4731E70", Offset = "0x4730470", VA = "0x184731E70")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA, V LEKEIHPCIEI, W BPBILCHNBCA, X NCPIGLMANIM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4354820", Offset = "0x4352E20", VA = "0x184354820")]
	public static NPHLJGNJJME<T, U, V, W, X> PAFCMDDLEJB(NPHLJGNJJME<T, U, V, W, X> PPBDJDNHLED, Action<T, U, V, W, X> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4354780", Offset = "0x4352D80", VA = "0x184354780")]
	public static NPHLJGNJJME<T, U, V, W, X> LGBBBPLMLIL(NPHLJGNJJME<T, U, V, W, X> PPBDJDNHLED, Action<T, U, V, W, X> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BJOHHCIFEDA<T, U, V, W, X, Y> : GGHGDCNPFAM<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D23780", Offset = "0x3D21D80", VA = "0x183D23780")]
	public BJOHHCIFEDA(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x509A090", Offset = "0x5098690", VA = "0x18509A090")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA, V LEKEIHPCIEI, W BPBILCHNBCA, X NCPIGLMANIM, Y DJBPOPBDKAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4354820", Offset = "0x4352E20", VA = "0x184354820")]
	public static BJOHHCIFEDA<T, U, V, W, X, Y> PAFCMDDLEJB(BJOHHCIFEDA<T, U, V, W, X, Y> PPBDJDNHLED, Action<T, U, V, W, X, Y> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4354780", Offset = "0x4352D80", VA = "0x184354780")]
	public static BJOHHCIFEDA<T, U, V, W, X, Y> LGBBBPLMLIL(BJOHHCIFEDA<T, U, V, W, X, Y> PPBDJDNHLED, Action<T, U, V, W, X, Y> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FJDOEBGJBDF<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OPOIEJEJAIC<TKey, TVal> CKKAEJJHLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> DIMLHEMBGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OPOIEJEJAIC<TKey, TVal>.HFHNFNDOJEH? IAPLAOKPJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int HCFJBCMPLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OPOIEJEJAIC<TKey, TVal>.JDLBAPAHMMA? COPOIMMCIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int DBBPINMLOKP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int ODAIHEMGKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3D27930", Offset = "0x3D25F30", VA = "0x183D27930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JKEHIMLHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x886FD0", Offset = "0x8855D0", VA = "0x180886FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D27990", Offset = "0x3D25F90", VA = "0x183D27990")]
	public FJDOEBGJBDF(int HCFJBCMPLOC, [Optional] OPOIEJEJAIC<TKey, TVal>.JDLBAPAHMMA? COPOIMMCIOI, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] OPOIEJEJAIC<TKey, TVal>.HFHNFNDOJEH? IAPLAOKPJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D265D0", Offset = "0x3D24BD0", VA = "0x183D265D0")]
	public void BCGLIBJPPHJ(TKey LFOBGDLOPID, TVal KLABJGGMBGH, bool JJBIJMBFNIH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D274B0", Offset = "0x3D25AB0", VA = "0x183D274B0")]
	public bool MNEHOJFPCBJ(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D273B0", Offset = "0x3D259B0", VA = "0x183D273B0")]
	public bool LAFFHOKCOBI(TKey BANNIIGGBKD, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3D269F0", Offset = "0x3D24FF0", VA = "0x183D269F0")]
	private void DCKDJDAKFKJ(TKey LFOBGDLOPID, TVal KLABJGGMBGH, int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D26820", Offset = "0x3D24E20", VA = "0x183D26820")]
	public bool CIGBGFPJDDG(TKey LFOBGDLOPID, TVal KLABJGGMBGH, bool JJBIJMBFNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D27620", Offset = "0x3D25C20", VA = "0x183D27620")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D26E20", Offset = "0x3D25420", VA = "0x183D26E20")]
	private void HGEADEHFELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D26CD0", Offset = "0x3D252D0", VA = "0x183D26CD0")]
	private bool GMIGIIEIJHJ(TKey LFOBGDLOPID, DLEIAGJLADM ONIANAELCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D27800", Offset = "0x3D25E00", VA = "0x183D27800")]
	private void PHEDGPLOOAI(TKey LFOBGDLOPID, TVal KLABJGGMBGH, DLEIAGJLADM ONIANAELCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D276D0", Offset = "0x3D25CD0", VA = "0x183D276D0")]
	private void NHEKBMHHJBF(TKey LFOBGDLOPID, TVal AAJFAHDADNL, DLEIAGJLADM ONIANAELCBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IKKBBBGOEIJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action EHAOOGOPJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool BPFKLNPOHOM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public IKKBBBGOEIJ(Action OMALCONAAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E480", Offset = "0x6C3CA80", VA = "0x186C3E480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A630", Offset = "0x2B18C30", VA = "0x182B1A630")]
	public static EMDFPNDLNED<T> GMDNOGMNFLF<T>(T KLABJGGMBGH, Action OMALCONAAEJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EMDFPNDLNED<T> : IKKBBBGOEIJ where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3986080", Offset = "0x3984680", VA = "0x183986080")]
	public EMDFPNDLNED(T KLABJGGMBGH, Action OMALCONAAEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class IKFMMAFNCDG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HNCNBMPBPMH<T>? CICIIICEEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> KOEPLJPGHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool BPFKLNPOHOM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly IKFMMAFNCDG<T> PGEMABEMKPO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> FCPPJJAFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCD40", Offset = "0x3FDB340", VA = "0x183FDCD40")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCC80", Offset = "0x3FDB280", VA = "0x183FDCC80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FKPHAIMPOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCF00", Offset = "0x3FDB500", VA = "0x183FDCF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD4E0", Offset = "0x3FDBAE0", VA = "0x183FDD4E0")]
	public IKFMMAFNCDG(HNCNBMPBPMH<T> MOLPCGJFJBL, HNCNBMPBPMH<T> AOGEIBLHLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD5E0", Offset = "0x3FDBBE0", VA = "0x183FDD5E0")]
	public IKFMMAFNCDG(HNCNBMPBPMH<T> MOLPCGJFJBL, int NBPJLJIBBHP, HNCNBMPBPMH<T> AOGEIBLHLDG, int GNOIGGGFMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3FDD9B0", Offset = "0x3FDBFB0", VA = "0x183FDD9B0")]
	private IKFMMAFNCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3FDCB30", Offset = "0x3FDB130", VA = "0x183FDCB30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC9B0", Offset = "0x3FDAFB0", VA = "0x183FDC9B0")]
	public T[] DAJAPAGKKGO()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC880", Offset = "0x3FDAE80", VA = "0x183FDC880")]
	public static ReadOnlySequence<T> BIEOCAPMHCM(IKFMMAFNCDG<T>? CPICPHKKOGA)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct OGMGECKBGAC : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DEGIHAFPOIK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40")]
		public static DEGIHAFPOIK GGBAHLJJLHO()
		{
			return default(DEGIHAFPOIK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E560", Offset = "0x2E3CB60", VA = "0x182E3E560")]
	public static string? NKBIHILKBNC<T>([Optional] string? JNLJHPGJODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E4E0", Offset = "0x2E3CAE0", VA = "0x182E3E4E0")]
	public static string? FBLGDABFGHG<T>([Optional] string? JGEJHAKOPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40")]
	public static OGMGECKBGAC IPHAGGDKEPB(string JNLJHPGJODG, string? JGEJHAKOPPO)
	{
		return default(OGMGECKBGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OKCGCELKKAL
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool IKCLOHNLGFL(string LMGDBKCPGFM, OKCGCELKKAL ALMAOBHIIHO);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OHGNDOAGJBO<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OHGNDOAGJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4824240", Offset = "0x4822840", VA = "0x184824240")]
		internal void DOFILDMCKDC(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int HBEFBGGFFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string ACDKMCBLDBN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C3F110", Offset = "0x6C3D710", VA = "0x186C3F110")]
	public static Dictionary<string, OKCGCELKKAL> KCIFLBLJCCF(Type LKNKNGAOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E44E90", Offset = "0x2E43490", VA = "0x182E44E90")]
	public static Dictionary<string, OKCGCELKKAL> KCIFLBLJCCF<T>(Type LKNKNGAOOJD, IReadOnlyDictionary<T, string> PDKHGJEMEFP) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E44710", Offset = "0x2E42D10", VA = "0x182E44710")]
	public static Dictionary<string, OKCGCELKKAL> FIMBIKNMMHN<T>(List<T> BKHBFACNBFA) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C3F440", Offset = "0x6C3DA40", VA = "0x186C3F440")]
	public static Dictionary<string, OKCGCELKKAL> MLDNHAPKPFP(Type LKNKNGAOOJD, IKCLOHNLGFL BDHKDJGKMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C3F800", Offset = "0x6C3DE00", VA = "0x186C3F800")]
	public static Dictionary<int, string> PAFELLGBABA(Dictionary<string, OKCGCELKKAL> MKLJJBDOOGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class LBGFPGMHGDG : JHLAIJINHDF
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool MHOMCLDODJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? KMEABAKJPEM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual JHLAIJINHDF? GLFEJPFJNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EDF0", Offset = "0x6C3D3F0", VA = "0x186C3EDF0")]
	protected LBGFPGMHGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string CKGPGAAGKNB();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E900", Offset = "0x6C3CF00", VA = "0x186C3E900", Slot = "8")]
	public virtual string FHHOLEOBILE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EB40", Offset = "0x6C3D140", VA = "0x186C3EB40", Slot = "9")]
	public void NONFBAGGMDC(StringBuilder CHLKGLNHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E980", Offset = "0x6C3CF80", VA = "0x186C3E980", Slot = "10")]
	public void GCCKCFKNKNK(StringBuilder CHLKGLNHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E7E0", Offset = "0x6C3CDE0", VA = "0x186C3E7E0", Slot = "11")]
	public void BFJBFDMOONF(StringBuilder CHLKGLNHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E9E0", Offset = "0x6C3CFE0", VA = "0x186C3E9E0", Slot = "12")]
	public void JMOAFNOOPPC(StringBuilder CHLKGLNHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E740", Offset = "0x6C3CD40", VA = "0x186C3E740")]
	public static void ANEHJNLAJOF(StringBuilder CHLKGLNHGFE, string MOMPLMHLOLO, string CFFCPCCOHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E114E0", Offset = "0x5E0FAE0", VA = "0x185E114E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FIEOBGAOJLE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D4F0", Offset = "0x6C3BAF0", VA = "0x186C3D4F0")]
	public FIEOBGAOJLE(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BOLGIAEKLDA<TErr> : FIEOBGAOJLE where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr HMMFGPLEEMJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x50B2E40", Offset = "0x50B1440", VA = "0x1850B2E40")]
	private BOLGIAEKLDA([In] TErr LIBMGCHELHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x50B2D60", Offset = "0x50B1360", VA = "0x1850B2D60")]
	public static BOLGIAEKLDA<TErr> GGBAHLJJLHO([In] TErr LIBMGCHELHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IIOIFNBPMBI : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm CEFGNPFENHH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool BDAHOJLFHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool AEDLMMEPKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool GMDJMBMKNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C3E330", Offset = "0x6C3C930", VA = "0x186C3E330", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long EHFBMINIGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C3E3A0", Offset = "0x6C3C9A0", VA = "0x186C3E3A0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C3E410", Offset = "0x6C3CA10", VA = "0x186C3E410", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E2C0", Offset = "0x6C3C8C0", VA = "0x186C3E2C0")]
	public IIOIFNBPMBI(HashAlgorithm CEFGNPFENHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E0F0", Offset = "0x6C3C6F0", VA = "0x186C3E0F0", Slot = "35")]
	public override int Read(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int FIGHABPEBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E290", Offset = "0x6C3C890", VA = "0x186C3E290", Slot = "38")]
	public override void Write(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E190", Offset = "0x6C3C790", VA = "0x186C3E190", Slot = "33")]
	public override long Seek(long IEHCONIHMPO, SeekOrigin LHEBMMKGLMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E220", Offset = "0x6C3C820", VA = "0x186C3E220", Slot = "34")]
	public override void SetLength(long KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E020", Offset = "0x6C3C620", VA = "0x186C3E020")]
	public byte[] IEIANCELHGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JHLAIJINHDF
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FHHOLEOBILE();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CKGPGAAGKNB();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BOPGAAOHCAO<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CFCJCJGOFFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string ODIGDFBGJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HNCNBMPBPMH<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static HNCNBMPBPMH<T>? OGADEDGPNHE;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object AAFIKIPMGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? LGDJDDCMIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool BPFKLNPOHOM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9F2CE0", Offset = "0x9F12E0", VA = "0x1809F2CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3E8A520", Offset = "0x3E88B20", VA = "0x183E8A520")]
	private static HNCNBMPBPMH<T> DPOKOFIFLAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3E89F40", Offset = "0x3E88540", VA = "0x183E89F40")]
	private static void DOJEDEKGPBO(HNCNBMPBPMH<T> DIEIHMFNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x39870C0", Offset = "0x39856C0", VA = "0x1839870C0")]
	private HNCNBMPBPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3E8B250", Offset = "0x3E89850", VA = "0x183E8B250")]
	public static HNCNBMPBPMH<T> GMDNOGMNFLF(ReadOnlyMemory<T> MBLLGDBCFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3E8B030", Offset = "0x3E89630", VA = "0x183E8B030")]
	public static HNCNBMPBPMH<T> GMDNOGMNFLF(IMemoryOwner<T> JELMGINMMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E8B810", Offset = "0x3E89E10", VA = "0x183E8B810")]
	public static void NANGFLKIHLP(HNCNBMPBPMH<T> MOLPCGJFJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3E8A9F0", Offset = "0x3E88FF0", VA = "0x183E8A9F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3E8AF10", Offset = "0x3E89510", VA = "0x183E8AF10")]
	public HNCNBMPBPMH<T> GGKHFFLDDLC(IMemoryOwner<T> JELMGINMMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3E8B710", Offset = "0x3E89D10", VA = "0x183E8B710")]
	private void GPNOECPNDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3E8B950", Offset = "0x3E89F50", VA = "0x183E8B950")]
	private HNCNBMPBPMH<T> NIOGEFDEBPJ(HNCNBMPBPMH<T> DIEIHMFNGOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BBIEKFPFKKE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C3C4C0", Offset = "0x6C3AAC0", VA = "0x186C3C4C0")]
	public BBIEKFPFKKE(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OGEBKHBKCHJ<TOk> : BBIEKFPFKKE where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk FAHIEBJJMNN;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x481EBC0", Offset = "0x481D1C0", VA = "0x18481EBC0")]
	private OGEBKHBKCHJ([In] TOk EKMNKIFKPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7590", Offset = "0x3DA5B90", VA = "0x183DA7590")]
	public static OGEBKHBKCHJ<TOk> GGBAHLJJLHO([In] TOk EKMNKIFKPDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct BCLNLKLFCPB<TOk, TErr> : IEquatable<BCLNLKLFCPB<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> MHNCBBKDFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr HMMFGPLEEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk FAHIEBJJMNN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool LNHHHFPFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5022270", Offset = "0x5020870", VA = "0x185022270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BODAAODMEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x50227D0", Offset = "0x5020DD0", VA = "0x1850227D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x50293D0", Offset = "0x50279D0", VA = "0x1850293D0")]
	internal BCLNLKLFCPB([In] TErr LIBMGCHELHD, [In] TOk EKMNKIFKPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5024170", Offset = "0x5022770", VA = "0x185024170")]
	public static BCLNLKLFCPB<TOk, TErr> FNJHKJCOLLP([In] TErr LIBMGCHELHD)
	{
		return default(BCLNLKLFCPB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5026C50", Offset = "0x5025250", VA = "0x185026C50")]
	public static BCLNLKLFCPB<TOk, TErr> MONOOFKONME([In] TOk EKMNKIFKPDG)
	{
		return default(BCLNLKLFCPB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x293AE30", Offset = "0x2939430", VA = "0x18293AE30")]
	public BCLNLKLFCPB<TOk?, UErr?> HPAAJDGAINH<UErr>()
	{
		return default(BCLNLKLFCPB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x29399C0", Offset = "0x2937FC0", VA = "0x1829399C0")]
	public BCLNLKLFCPB<UOk?, TErr?> ABDMFCLOMPO<UOk>()
	{
		return default(BCLNLKLFCPB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x293A520", Offset = "0x2938B20", VA = "0x18293A520")]
	public BCLNLKLFCPB<UOk?, TErr?> BHLJAGFPOBF<UOk>()
	{
		return default(BCLNLKLFCPB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x293B6F0", Offset = "0x2939CF0", VA = "0x18293B6F0")]
	public BCLNLKLFCPB<TOk?, UErr?> OLDICICFGKC<UErr>()
	{
		return default(BCLNLKLFCPB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5023C60", Offset = "0x5022260", VA = "0x185023C60")]
	public BCLNLKLFCPB<BLGMJKLPHOM, TErr> FHIIKIDOAHP()
	{
		return default(BCLNLKLFCPB<BLGMJKLPHOM, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5025CF0", Offset = "0x50242F0", VA = "0x185025CF0")]
	public static bool MNAFCOICNLK([In] BCLNLKLFCPB<TOk, TErr> NFCDCHABNCB, [In] BCLNLKLFCPB<TOk, TErr> BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5022CE0", Offset = "0x50212E0", VA = "0x185022CE0", Slot = "4")]
	public bool Equals(BCLNLKLFCPB<TOk, TErr> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5023350", Offset = "0x5021950", VA = "0x185023350", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5024CE0", Offset = "0x50232E0", VA = "0x185024CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5029020", Offset = "0x5027620", VA = "0x185029020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class AAKCNDDJPIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct IKPGLNNBDCH<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<BCLNLKLFCPB<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<BCLNLKLFCPB<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3FE05C0", Offset = "0x3FDEBC0", VA = "0x183FE05C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3FE0900", Offset = "0x3FDEF00", VA = "0x183FE0900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3341C70", Offset = "0x3340270", VA = "0x183341C70")]
	public static BCLNLKLFCPB<TOk?, TErr?> FAHIEBJJMNN<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [In] TOk EKMNKIFKPDG)
	{
		return default(BCLNLKLFCPB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3341D80", Offset = "0x3340380", VA = "0x183341D80")]
	public static BCLNLKLFCPB<BLGMJKLPHOM, TErr?> FAHIEBJJMNN<TErr>([In] this BCLNLKLFCPB<BLGMJKLPHOM, TErr> BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<BLGMJKLPHOM, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3341C70", Offset = "0x3340270", VA = "0x183341C70")]
	public static BCLNLKLFCPB<TOk?, TErr?> HMMFGPLEEMJ<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [In] TErr LIBMGCHELHD)
	{
		return default(BCLNLKLFCPB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x33437D0", Offset = "0x3341DD0", VA = "0x1833437D0")]
	public static TOk? NMMHDODCLBC<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3342D10", Offset = "0x3341310", VA = "0x183342D10")]
	[AsyncStateMachine(typeof(IKPGLNNBDCH<, >))]
	public static Task<TOk?>? JLIMDBDICHN<TOk, TErr>(this Task<BCLNLKLFCPB<TOk, TErr>> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3342500", Offset = "0x3340B00", VA = "0x183342500")]
	public static TErr? IELNMCKFAAE<TErr, TOk>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x33407A0", Offset = "0x333EDA0", VA = "0x1833407A0")]
	public static bool ADJJFPEJKAG<TOk, TErr, UErr, UOk>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out] BCLNLKLFCPB<UOk, UErr> JGMIFKEBIBG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3343570", Offset = "0x3341B70", VA = "0x183343570")]
	public static bool LKHDEEDHLPD<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3341F40", Offset = "0x3340540", VA = "0x183341F40")]
	public static bool GMDMPGLPJMD<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TErr LIBMGCHELHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x33421C0", Offset = "0x33407C0", VA = "0x1833421C0")]
	public static bool GNNKGOEBGMP<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG, [Out][NotNullWhen(false)] TErr LIBMGCHELHD) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3342FE0", Offset = "0x33415E0", VA = "0x183342FE0")]
	public static bool JMDKDOMEKJG<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG, [Out] BCLNLKLFCPB<TOk, TErr> JGMIFKEBIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x33408D0", Offset = "0x333EED0", VA = "0x1833408D0")]
	public static bool ADJJFPEJKAG<TOk, TErr, UErr, UOk>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG, [Out] BCLNLKLFCPB<UOk, UErr> JGMIFKEBIBG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x33431C0", Offset = "0x33417C0", VA = "0x1833431C0")]
	public static bool JNFDNKGEMFO<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG, [Out] BCLNLKLFCPB<BLGMJKLPHOM, TErr> JGMIFKEBIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x33429B0", Offset = "0x3340FB0", VA = "0x1833429B0")]
	public static BCLNLKLFCPB<UOk, UErr> JCNKGBPGJFN<UOk, UErr, TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [In] BCLNLKLFCPB<UOk, UErr> MNKBAIOBLHC) where TOk : UOk where TErr : UErr
	{
		return default(BCLNLKLFCPB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3341850", Offset = "0x333FE50", VA = "0x183341850")]
	public static BCLNLKLFCPB<TOk?[]?, TErr?> AJAKOMEJHNM<TOk, TErr>(this IEnumerable<BCLNLKLFCPB<TOk, TErr>> BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class ICJFIJPHEKK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2947530", Offset = "0x2945B30", VA = "0x182947530")]
	public static BCLNLKLFCPB<TOk, T> FAHIEBJJMNN<TOk>([In] TOk EKMNKIFKPDG) where TOk : notnull
	{
		return default(BCLNLKLFCPB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3F4E900", Offset = "0x3F4CF00", VA = "0x183F4E900")]
	public static BCLNLKLFCPB<BLGMJKLPHOM, T> FAHIEBJJMNN()
	{
		return default(BCLNLKLFCPB<BLGMJKLPHOM, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2947530", Offset = "0x2945B30", VA = "0x182947530")]
	public static BCLNLKLFCPB<T, TErr> HMMFGPLEEMJ<TErr>([In] TErr LIBMGCHELHD) where TErr : notnull
	{
		return default(BCLNLKLFCPB<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct CBFNPGOBIBB<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly KBFHEAKJDEM CGKAECCBEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> EKHKGFMJCHF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D250", Offset = "0x3E6B850", VA = "0x183E6D250")]
	public static CBFNPGOBIBB<TKey, TValue> GGBAHLJJLHO(string EIGKPCONJCB)
	{
		return default(CBFNPGOBIBB<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D380", Offset = "0x3E6B980", VA = "0x183E6D380")]
	internal CBFNPGOBIBB(Dictionary<TKey, TValue> KLABJGGMBGH, KBFHEAKJDEM JMAHNFNHFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D1A0", Offset = "0x3E6B7A0", VA = "0x183E6D1A0")]
	public BOCDMMEFONB<TKey, TValue> FJBGAALOJLL([Out] Dictionary<TKey, TValue> KLABJGGMBGH)
	{
		return default(BOCDMMEFONB<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct BOCDMMEFONB<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> EKHKGFMJCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly IFDFMPHCELI OIANOPHMAKM;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2268590", Offset = "0x2266B90", VA = "0x182268590")]
	internal BOCDMMEFONB(Dictionary<TKey, TValue> KLABJGGMBGH, IFDFMPHCELI GBLLAKFMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3DA71E0", Offset = "0x3DA57E0", VA = "0x183DA71E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct OOMOGHEAAOM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly KBFHEAKJDEM CGKAECCBEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> EKHKGFMJCHF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D250", Offset = "0x3E6B850", VA = "0x183E6D250")]
	public static OOMOGHEAAOM<T> GGBAHLJJLHO(string EIGKPCONJCB)
	{
		return default(OOMOGHEAAOM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D380", Offset = "0x3E6B980", VA = "0x183E6D380")]
	internal OOMOGHEAAOM(HashSet<T> KLABJGGMBGH, KBFHEAKJDEM JMAHNFNHFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D1A0", Offset = "0x3E6B7A0", VA = "0x183E6D1A0")]
	public AGCIIIHEMPA<T> FJBGAALOJLL([Out] HashSet<T> KLABJGGMBGH)
	{
		return default(AGCIIIHEMPA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct AGCIIIHEMPA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> EKHKGFMJCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IFDFMPHCELI OIANOPHMAKM;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2268590", Offset = "0x2266B90", VA = "0x182268590")]
	internal AGCIIIHEMPA(HashSet<T> KLABJGGMBGH, IFDFMPHCELI GBLLAKFMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3DA71E0", Offset = "0x3DA57E0", VA = "0x183DA71E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct HEDMLFNJKHG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KBFHEAKJDEM CGKAECCBEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> EKHKGFMJCHF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D250", Offset = "0x3E6B850", VA = "0x183E6D250")]
	public static HEDMLFNJKHG<T> GGBAHLJJLHO(string EIGKPCONJCB)
	{
		return default(HEDMLFNJKHG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D380", Offset = "0x3E6B980", VA = "0x183E6D380")]
	internal HEDMLFNJKHG(Stack<T> KLABJGGMBGH, KBFHEAKJDEM JMAHNFNHFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D1A0", Offset = "0x3E6B7A0", VA = "0x183E6D1A0")]
	public KCDODCBIEJM<T> FJBGAALOJLL([Out] Stack<T> KLABJGGMBGH)
	{
		return default(KCDODCBIEJM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KCDODCBIEJM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> EKHKGFMJCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IFDFMPHCELI OIANOPHMAKM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2268590", Offset = "0x2266B90", VA = "0x182268590")]
	internal KCDODCBIEJM(Stack<T> KLABJGGMBGH, IFDFMPHCELI GBLLAKFMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3DA71E0", Offset = "0x3DA57E0", VA = "0x183DA71E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class PJKMINGADML<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct HEIMNNCONEA : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly PJKMINGADML<T> EKFNPIOLJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int NHAKOPDMONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool CPMKIJHFOAC;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3750", Offset = "0x1FA1D50", VA = "0x181FA3750")]
		public HEIMNNCONEA(PJKMINGADML<T> BDPEMHOFOHC, int NBCCCAMFPGE, bool KAMMDKBCNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F230", Offset = "0x3E6D830", VA = "0x183E6F230")]
		public PJKMINGADML<T>.POPEDNHAIGH HNHGFOAAHAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F330", Offset = "0x3E6D930", VA = "0x183E6F330", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F330", Offset = "0x3E6D930", VA = "0x183E6F330", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class POPEDNHAIGH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly PJKMINGADML<T> EKFNPIOLJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int FLFHNABKAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int IBHAOOHPDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool CPMKIJHFOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool OGPFCJCDGLC;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x4950260", Offset = "0x494E860", VA = "0x184950260")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x4950470", Offset = "0x494EA70", VA = "0x184950470", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x4950700", Offset = "0x494ED00", VA = "0x184950700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4950AE0", Offset = "0x494F0E0", VA = "0x184950AE0")]
		public POPEDNHAIGH(PJKMINGADML<T> BDPEMHOFOHC, int NBCCCAMFPGE, bool KAMMDKBCNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4950360", Offset = "0x494E960", VA = "0x184950360", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4950400", Offset = "0x494EA00", VA = "0x184950400", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NNODLJDPHCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public NNODLJDPHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x47300A0", Offset = "0x472E6A0", VA = "0x1847300A0")]
		internal T KADFCEPNOJB(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] HFMJNPDGPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int IBHAOOHPDBM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int JBBIJLDBJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x491E1E0", Offset = "0x491C7E0", VA = "0x18491E1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T JINHOCMBIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CFC990", Offset = "0x3CFAF90", VA = "0x183CFC990")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T FBNLOBKJFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x491E1A0", Offset = "0x491C7A0", VA = "0x18491E1A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x491DF20", Offset = "0x491C520", VA = "0x18491DF20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1B419D0", Offset = "0x1B3FFD0", VA = "0x181B419D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x13230C0", Offset = "0x13216C0", VA = "0x1813230C0")]
	private static int LOAMKNNONEE(int HGFDMIDEFHN, int KHMKAEGDPPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x491E240", Offset = "0x491C840", VA = "0x18491E240")]
	public PJKMINGADML(int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x491E370", Offset = "0x491C970", VA = "0x18491E370")]
	public PJKMINGADML(int BHEAFIOEIAD, Func<T> CELJDAIDPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x491E7C0", Offset = "0x491CDC0", VA = "0x18491E7C0")]
	public PJKMINGADML(T[] KCIKOPILENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x491E0D0", Offset = "0x491C6D0", VA = "0x18491E0D0")]
	public void HFKPHGFKOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x491E000", Offset = "0x491C600", VA = "0x18491E000")]
	public IEnumerable<T> FNGIBAAAKGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x491E100", Offset = "0x491C700", VA = "0x18491E100")]
	public PJKMINGADML<T>.POPEDNHAIGH HNHGFOAAHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3D78ED0", Offset = "0x3D774D0", VA = "0x183D78ED0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3D78ED0", Offset = "0x3D774D0", VA = "0x183D78ED0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class PJKAHOIEECA
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2E63300", Offset = "0x2E61900", VA = "0x182E63300")]
	public static PJKMINGADML<T> GGBAHLJJLHO<T>(int BHEAFIOEIAD, Func<T> CELJDAIDPKF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class FLHAGBLLKLO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct IFHCPKCIOJL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly FLHAGBLLKLO<T> GGLMDMLPDFB;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T PGPGCBGPPOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A5C0", Offset = "0x3F78BC0", VA = "0x183F7A5C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A5E0", Offset = "0x3F78BE0", VA = "0x183F7A5E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
		public IFHCPKCIOJL(FLHAGBLLKLO<T> GGLMDMLPDFB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CIILKEOAPLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<IFHCPKCIOJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FLHAGBLLKLO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x55A9710", Offset = "0x55A7D10", VA = "0x1855A9710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4947C00", Offset = "0x4946200", VA = "0x184947C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim HPHELALHCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T GOEOMDMENPE;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3D34410", Offset = "0x3D32A10", VA = "0x183D34410")]
	public FLHAGBLLKLO([In] T GOEOMDMENPE, int DFFCLKCIGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3D343D0", Offset = "0x3D329D0", VA = "0x183D343D0")]
	public FLHAGBLLKLO([In] T GOEOMDMENPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3D33E70", Offset = "0x3D32470", VA = "0x183D33E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3D33EB0", Offset = "0x3D324B0", VA = "0x183D33EB0")]
	public IFHCPKCIOJL FCJOJLLNDHE()
	{
		return default(IFHCPKCIOJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3D33EF0", Offset = "0x3D324F0", VA = "0x183D33EF0")]
	[AsyncStateMachine(typeof(FLHAGBLLKLO<>.CIILKEOAPLB))]
	public Task<FLHAGBLLKLO<T>.IFHCPKCIOJL> JBDCGOPGPJJ(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3D343B0", Offset = "0x3D329B0", VA = "0x183D343B0")]
	public void NLDJHLKAJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class DMFIFPLAINI
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D430", Offset = "0x6C3BA30", VA = "0x186C3D430")]
	public static FLHAGBLLKLO<BLGMJKLPHOM> GGBAHLJJLHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BE40", Offset = "0x2A0A440", VA = "0x182A0BE40")]
	public static FLHAGBLLKLO<T> GGBAHLJJLHO<T>([In] T GOEOMDMENPE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class MEEBNKPAKKO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct ABMDGFKMFLB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly MEEBNKPAKKO<T> FADLMKJPOCN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T PGPGCBGPPOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x3D02AB0", Offset = "0x3D010B0", VA = "0x183D02AB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A360", Offset = "0x3D88960", VA = "0x183D8A360", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
		internal ABMDGFKMFLB(MEEBNKPAKKO<T> GGLMDMLPDFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct FBJFJPKAEAP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly MEEBNKPAKKO<T> FADLMKJPOCN;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T PGPGCBGPPOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x3D02AB0", Offset = "0x3D010B0", VA = "0x183D02AB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D02B20", Offset = "0x3D01120", VA = "0x183D02B20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
		internal FBJFJPKAEAP(MEEBNKPAKKO<T> GGLMDMLPDFB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DGGDPHGPHAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<FBJFJPKAEAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public MEEBNKPAKKO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private FLHAGBLLKLO<BLGMJKLPHOM>.IFHCPKCIOJL <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<FLHAGBLLKLO<BLGMJKLPHOM>.IFHCPKCIOJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5A57150", Offset = "0x5A55750", VA = "0x185A57150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4947C00", Offset = "0x4946200", VA = "0x184947C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FLHAGBLLKLO<int> NHEAJFPEJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FLHAGBLLKLO<BLGMJKLPHOM> KDAGNAHIFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly FLHAGBLLKLO<BLGMJKLPHOM> CFENDDAMINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T GBANAKCBABJ;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x468F4A0", Offset = "0x468DAA0", VA = "0x18468F4A0")]
	internal MEEBNKPAKKO(FLHAGBLLKLO<int> JPHKPELEMMK, FLHAGBLLKLO<BLGMJKLPHOM> HBBEEPIECAH, FLHAGBLLKLO<BLGMJKLPHOM> OKLIGNLMCFE, [In] T GOEOMDMENPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x468E700", Offset = "0x468CD00", VA = "0x18468E700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x468EA40", Offset = "0x468D040", VA = "0x18468EA40")]
	public ABMDGFKMFLB GAPGEIOILGP()
	{
		return default(ABMDGFKMFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x468EFA0", Offset = "0x468D5A0", VA = "0x18468EFA0")]
	public FBJFJPKAEAP GMAKAKDGBAO()
	{
		return default(FBJFJPKAEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x468F2F0", Offset = "0x468D8F0", VA = "0x18468F2F0")]
	[AsyncStateMachine(typeof(MEEBNKPAKKO<>.DGGDPHGPHAD))]
	public Task<MEEBNKPAKKO<T>.FBJFJPKAEAP> NKEELLMKCIA(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JLPEMOEMDCA
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E540", Offset = "0x6C3CB40", VA = "0x186C3E540")]
	public static MEEBNKPAKKO<BLGMJKLPHOM> GGBAHLJJLHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2D437A0", Offset = "0x2D41DA0", VA = "0x182D437A0")]
	public static MEEBNKPAKKO<T> GGBAHLJJLHO<T>([In] T GOEOMDMENPE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class HBJAJJJGMOP<TData> : LBGFPGMHGDG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string OCGNGJODMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData MJHCHFCOEOK;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3E69250", Offset = "0x3E67850", VA = "0x183E69250")]
	internal HBJAJJJGMOP(string KFAOBDLOMDC, [In] TData JGCMECODHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JKIGLNAKFEH
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E4C0", Offset = "0x6C3CAC0", VA = "0x186C3E4C0")]
	public static HBJAJJJGMOP<BLGMJKLPHOM> GGBAHLJJLHO(string KFAOBDLOMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A630", Offset = "0x2B18C30", VA = "0x182B1A630")]
	public static HBJAJJJGMOP<TData> GGBAHLJJLHO<TData>(string KFAOBDLOMDC, [In] TData JGCMECODHDI) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class KBFHEAKJDEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool BIJAALKEPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string PBGOGMDKPMK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x122B6E0", Offset = "0x1229CE0", VA = "0x18122B6E0")]
	private KBFHEAKJDEM(bool IDAIPEJPKHH, string DLLDANCDIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E6D0", Offset = "0x6C3CCD0", VA = "0x186C3E6D0")]
	public static KBFHEAKJDEM GGBAHLJJLHO(string DLLDANCDIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E610", Offset = "0x6C3CC10", VA = "0x186C3E610")]
	public IFDFMPHCELI FJBGAALOJLL()
	{
		return default(IFDFMPHCELI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct IFDFMPHCELI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KBFHEAKJDEM BCMIIMHKIDL;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
	internal IFDFMPHCELI(KBFHEAKJDEM EIGKPCONJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E000", Offset = "0x6C3C600", VA = "0x186C3E000", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FLDJBKGNCLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Dictionary<object, float> HGEMHLLLPMH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float OMLEKOCBGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x91DD80", Offset = "0x91C380", VA = "0x18091DD80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x91D750", Offset = "0x91BD50", VA = "0x18091D750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D6F0", Offset = "0x6C3BCF0", VA = "0x186C3D6F0")]
	public void GMBIHPHNNPE(float KLABJGGMBGH, object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D550", Offset = "0x6C3BB50", VA = "0x186C3D550")]
	public void BDCMENKNKIJ(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D760", Offset = "0x6C3BD60", VA = "0x186C3D760")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D5C0", Offset = "0x6C3BBC0", VA = "0x186C3D5C0")]
	private void GCMMHLCEJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D7B0", Offset = "0x6C3BDB0", VA = "0x186C3D7B0")]
	public FLDJBKGNCLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class FNNHLEBNCBD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KOBNFJAFEJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public KOBNFJAFEJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x436F360", Offset = "0x436D960", VA = "0x18436F360")]
		internal int DONBLAIMGHN(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private HashSet<T>? EAHIJHLAKCA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IReadOnlyCollection<T> FFGCDMFICFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CA30", Offset = "0x3D3B030", VA = "0x183D3CA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GPLCCGGIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CCE0", Offset = "0x3D3B2E0", VA = "0x183D3CCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8920C0", Offset = "0x8906C0", VA = "0x1808920C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3D3C800", Offset = "0x3D3AE00", VA = "0x183D3C800")]
	public bool FABNFHGMHGJ(T FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3D3CB60", Offset = "0x3D3B160", VA = "0x183D3CB60")]
	public bool MBEEDABKNGP(T FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3D3C9E0", Offset = "0x3D3AFE0", VA = "0x183D3C9E0")]
	public bool FEAHPDAAGAE(T FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3D3CA70", Offset = "0x3D3B070", VA = "0x183D3CA70")]
	public void IFCLODGLLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3D3CD30", Offset = "0x3D3B330", VA = "0x183D3CD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public FNNHLEBNCBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class EAFCCNKEDEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly string EKHPMBGFPFP;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public EAFCCNKEDEM(string EKHPMBGFPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D4A0", Offset = "0x6C3BAA0", VA = "0x186C3D4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class GLGPGBPNFLE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class BGEPGGJHBFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public BGEPGGJHBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C3C520", Offset = "0x6C3AB20", VA = "0x186C3C520")]
		internal int DONBLAIMGHN(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private HashSet<object>? EAHIJHLAKCA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyCollection<object> FFGCDMFICFB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C3DCA0", Offset = "0x6C3C2A0", VA = "0x186C3DCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool GPLCCGGIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6C3DE40", Offset = "0x6C3C440", VA = "0x186C3DE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8920C0", Offset = "0x8906C0", VA = "0x1808920C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DB60", Offset = "0x6C3C160", VA = "0x186C3DB60")]
	public bool FABNFHGMHGJ(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DDA0", Offset = "0x6C3C3A0", VA = "0x186C3DDA0")]
	public bool MBEEDABKNGP(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DC40", Offset = "0x6C3C240", VA = "0x186C3DC40")]
	public bool FEAHPDAAGAE(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DD30", Offset = "0x6C3C330", VA = "0x186C3DD30")]
	public void IFCLODGLLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DE50", Offset = "0x6C3C450", VA = "0x186C3DE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public GLGPGBPNFLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class GOJDLPKALLN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct DKDHBCNAABN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float HOLMEBECIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public T PGPGCBGPPOH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<object, DKDHBCNAABN> HGEMHLLLPMH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public virtual T OFGKMAGDPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x120D670", Offset = "0x120BC70", VA = "0x18120D670", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x120CC50", Offset = "0x120B250", VA = "0x18120CC50", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public object? PBKCNPBGHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LLEHPMPCDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD270", Offset = "0x3DFB870", VA = "0x183DFD270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD780", Offset = "0x3DFBD80", VA = "0x183DFD780")]
	public bool GMBIHPHNNPE(T KLABJGGMBGH, object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3D205F0", Offset = "0x3D1EBF0", VA = "0x183D205F0")]
	public bool BDCMENKNKIJ(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3D37A90", Offset = "0x3D36090", VA = "0x183D37A90")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF530", Offset = "0x3DFDB30", VA = "0x183DFF530")]
	public bool LAFFHOKCOBI(object FLLNLBHFENG, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3DFED80", Offset = "0x3DFD380", VA = "0x183DFED80")]
	[CPCEDDOKEKI("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool IMFFCFJEHBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3D20E10", Offset = "0x3D1F410", VA = "0x183D20E10")]
	public GOJDLPKALLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class DMNDLJBGMEJ<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private List<WeakReference<T>>? EAHIJHLAKCA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GPLCCGGIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5A6E530", Offset = "0x5A6CB30", VA = "0x185A6E530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5A6DEF0", Offset = "0x5A6C4F0", VA = "0x185A6DEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5A6E0A0", Offset = "0x5A6C6A0", VA = "0x185A6E0A0")]
	public void FABNFHGMHGJ(T FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5A6E380", Offset = "0x5A6C980", VA = "0x185A6E380")]
	public void MBEEDABKNGP(T FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5A6E330", Offset = "0x5A6C930", VA = "0x185A6E330")]
	public void IFCLODGLLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5A6E660", Offset = "0x5A6CC60", VA = "0x185A6E660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public DMNDLJBGMEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal static class DLJFKAHAMEK
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2B15880", Offset = "0x2B13E80", VA = "0x182B15880")]
	public static void AAOPJACGKPM<T>(this List<T> OLAPNOFMNPM, int HGFDMIDEFHN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface KIAENMCLBPA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MPPFFBOOLBI JHLCOOJBGDI;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DEDDEELPDLO : KIAENMCLBPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct DLEDIHKPJKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float LHKIFFPBGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly float MIFABMICKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal readonly bool OGCLLAHCFGD;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float KHAEIGABOJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6C3D160", Offset = "0x6C3B760", VA = "0x186C3D160")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C3D2D0", Offset = "0x6C3B8D0", VA = "0x186C3D2D0")]
		public DLEDIHKPJKB(float OENMMCMOJOM, float FOOPMAMGEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C3D170", Offset = "0x6C3B770", VA = "0x186C3D170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OKJEBFPKKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DEDDEELPDLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OKJEBFPKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6C3F9C0", Offset = "0x6C3DFC0", VA = "0x186C3F9C0")]
		internal void LKCHNIGPJDI(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int HCAOLDLEJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int ANOJDOHEBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KIAENMCLBPA[] DGDHCHIKHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MPPFFBOOLBI[] GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly DLEDIHKPJKB[] GEPFKAMHOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private DLEDIHKPJKB BOOAPHHOHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NHPDOFIEOLC BGDNEILBKCB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MPPFFBOOLBI JHLCOOJBGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C3C950", Offset = "0x6C3AF50", VA = "0x186C3C950", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6C3CA10", Offset = "0x6C3B010", VA = "0x186C3CA10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CFD0", Offset = "0x6C3B5D0", VA = "0x186C3CFD0")]
	public DEDDEELPDLO(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CF40", Offset = "0x6C3B540", VA = "0x186C3CF40")]
	public NHPDOFIEOLC PGCPHLAJMKC(DLEDIHKPJKB PCIGIFGMPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CAD0", Offset = "0x6C3B0D0", VA = "0x186C3CAD0")]
	public void MLGPAMJFFHK(KIAENMCLBPA IHCJKNPJGGA, [Optional] DLEDIHKPJKB ENHALDAODKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C3C840", Offset = "0x6C3AE40", VA = "0x186C3C840", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void MPPFFBOOLBI(float HFLGBGLDNCG);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class PELAOJPAMJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class CNBEJLNDDCH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly KIAENMCLBPA IDGNANOJOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly MPPFFBOOLBI JMKAJHCEDCI;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6C3C620", Offset = "0x6C3AC20", VA = "0x186C3C620")]
		public CNBEJLNDDCH(KIAENMCLBPA IDGNANOJOBM, MPPFFBOOLBI JMKAJHCEDCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6C3C5D0", Offset = "0x6C3ABD0", VA = "0x186C3C5D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6C3FA60", Offset = "0x6C3E060", VA = "0x186C3FA60")]
	internal static bool DKJEECLBMJN(float MOKDKAEJAPP, float MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CD90", Offset = "0x6C2B390", VA = "0x186C2CD90")]
	internal static float GDHOOAMKIEP(float MOKDKAEJAPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6C3FAD0", Offset = "0x6C3E0D0", VA = "0x186C3FAD0")]
	public static IDisposable IBLBIMPCNCK(this KIAENMCLBPA IDGNANOJOBM, MPPFFBOOLBI JMKAJHCEDCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NHPDOFIEOLC : KIAENMCLBPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private float HFLGBGLDNCG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float GCLDPKFAPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6C3EE60", Offset = "0x6C3D460", VA = "0x186C3EE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MPPFFBOOLBI? JHLCOOJBGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6C3EF50", Offset = "0x6C3D550", VA = "0x186C3EF50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6C3EFF0", Offset = "0x6C3D5F0", VA = "0x186C3EFF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public NHPDOFIEOLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface GBLHCGDFMLL<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AGMOFPPEEHD<T> KINKNPKFCGM([Out] T KLABJGGMBGH);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPAAPCHGDCP();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class OHLANCPOAGD<T> : GBLHCGDFMLL<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ConcurrentStack<T> FDFNPLPCCEO;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4824390", Offset = "0x4822990", VA = "0x184824390", Slot = "4")]
	public AGMOFPPEEHD<T> KINKNPKFCGM([Out] T KLABJGGMBGH)
	{
		return default(AGMOFPPEEHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4824310", Offset = "0x4822910", VA = "0x184824310")]
	public void CJCAMEPPGCI(T JKPIGPKLAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3F48B20", Offset = "0x3F47120", VA = "0x183F48B20", Slot = "5")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "6")]
	protected virtual void OLEDBFHDGEA(T ANOOCBHGPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4824430", Offset = "0x4822A30", VA = "0x184824430")]
	private T PBGHNKGJFJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x48244E0", Offset = "0x4822AE0", VA = "0x1848244E0")]
	public OHLANCPOAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct AGMOFPPEEHD<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly T JKPIGPKLAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly OHLANCPOAGD<T> PNBHHBNOEKE;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xC51880", Offset = "0xC4FE80", VA = "0x180C51880")]
	internal AGMOFPPEEHD(T KLABJGGMBGH, OHLANCPOAGD<T> PNBHHBNOEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3DA8B00", Offset = "0x3DA7100", VA = "0x183DA8B00", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class DBOFOMALIFL : OHLANCPOAGD<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly DBOFOMALIFL DFEEMNKDOMA;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C3C6D0", Offset = "0x6C3ACD0", VA = "0x186C3C6D0")]
	public static AGMOFPPEEHD<StringBuilder> PBGHNKGJFJB([Out] StringBuilder KLABJGGMBGH)
	{
		return default(AGMOFPPEEHD<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C3C6B0", Offset = "0x6C3ACB0", VA = "0x186C3C6B0", Slot = "6")]
	protected override void OLEDBFHDGEA(StringBuilder ANOOCBHGPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C3C800", Offset = "0x6C3AE00", VA = "0x186C3C800")]
	public DBOFOMALIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class MOHEAONHKJN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x66B5990", Offset = "0x66B3F90", VA = "0x1866B5990")]
	public MOHEAONHKJN(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class MMKFBDDFLAD<TKey, TValue> : GDPMBAGKHOA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, HKPPOJGFHDF where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class LPNKNLFPCAD : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public MMKFBDDFLAD<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x120D670", Offset = "0x120BC70", VA = "0x18120D670", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x4479F10", Offset = "0x4478510", VA = "0x184479F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public LPNKNLFPCAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3BA0870", Offset = "0x3B9EE70", VA = "0x183BA0870", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4479A30", Offset = "0x4478030", VA = "0x184479A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x44791C0", Offset = "0x44777C0", VA = "0x1844791C0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4479120", Offset = "0x4477720", VA = "0x184479120")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4479EC0", Offset = "0x44784C0", VA = "0x184479EC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly GDPMBAGKHOA<TKey, TValue> NJACILJEJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IDictionary<TKey, TValue> IDOOGHKMEAL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x46B4550", Offset = "0x46B2B50", VA = "0x1846B4550", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PBLDLBGBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x46B4660", Offset = "0x46B2C60", VA = "0x1846B4660", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x46B4910", Offset = "0x46B2F10", VA = "0x1846B4910", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> IAJFPBHMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x46B46B0", Offset = "0x46B2CB0", VA = "0x1846B46B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> EMLPAKLEEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x46B47E0", Offset = "0x46B2DE0", VA = "0x1846B47E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x46B42E0", Offset = "0x46B28E0", VA = "0x1846B42E0")]
	public MMKFBDDFLAD(GDPMBAGKHOA<TKey, TValue> NJACILJEJCL, [Optional] IDictionary<TKey, TValue>? IDOOGHKMEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x46B2020", Offset = "0x46B0620", VA = "0x1846B2020", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x46B3260", Offset = "0x46B1860", VA = "0x1846B3260")]
	public void IKOKFLPIGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x46B1900", Offset = "0x46AFF00", VA = "0x1846B1900", Slot = "9")]
	public void Add(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x46B1600", Offset = "0x46AFC00", VA = "0x1846B1600")]
	public void ALNKLDMCEIA(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x46B1C70", Offset = "0x46B0270", VA = "0x1846B1C70")]
	public void CAPAPIIGFJK(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x46B2EF0", Offset = "0x46B14F0", VA = "0x1846B2EF0")]
	public void HCCBCFINBOO(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x46B2A10", Offset = "0x46B1010", VA = "0x1846B2A10")]
	public void FFJHLCGHNFO(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x46B38F0", Offset = "0x46B1EF0", VA = "0x1846B38F0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x46B3B30", Offset = "0x46B2130", VA = "0x1846B3B30", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x46B3E90", Offset = "0x46B2490", VA = "0x1846B3E90", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x46B2160", Offset = "0x46B0760", VA = "0x1846B2160", Slot = "8")]
	public bool ContainsKey(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x46B1F50", Offset = "0x46B0550", VA = "0x1846B1F50")]
	public bool CBNDHIIBNIC(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x46B2B10", Offset = "0x46B1110", VA = "0x1846B2B10")]
	public bool GJBNDOLHBCN(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x46B3740", Offset = "0x46B1D40", VA = "0x1846B3740", Slot = "10")]
	public bool Remove(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x46B4130", Offset = "0x46B2730", VA = "0x1846B4130", Slot = "11")]
	public bool TryGetValue(TKey LFOBGDLOPID, [Out] TValue KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x46B2480", Offset = "0x46B0A80", VA = "0x1846B2480", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] DKEEEGEFALD, int FFJKEOACOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x42D5D20", Offset = "0x42D4320", VA = "0x1842D5D20", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x46B2CF0", Offset = "0x46B12F0", VA = "0x1846B2CF0", Slot = "19")]
	[IteratorStateMachine(typeof(MMKFBDDFLAD<, >.LPNKNLFPCAD))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x46B32B0", Offset = "0x46B18B0", VA = "0x1846B32B0", Slot = "21")]
	public bool NICBNIPDCNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x46B3470", Offset = "0x46B1A70", VA = "0x1846B3470")]
	private TValue PLMFAIELKLP(TKey LFOBGDLOPID)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface HKPPOJGFHDF
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NICBNIPDCNC();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface GDPMBAGKHOA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HKPPOJGFHDF
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public sealed class OPOIEJEJAIC<TKey, TVal> : GDPMBAGKHOA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HKPPOJGFHDF where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate int JDLBAPAHMMA(TKey LFOBGDLOPID, TVal KLABJGGMBGH);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void HFHNFNDOJEH(TKey LFOBGDLOPID, TVal KLABJGGMBGH, DLEIAGJLADM ONIANAELCBB);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class FAFOKHJGLBE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x96B660", Offset = "0x969C60", VA = "0x18096B660")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal PGPGCBGPPOH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x91F1E0", Offset = "0x91D7E0", VA = "0x18091F1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int KHAEIGABOJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8C59A0", Offset = "0x8C3FA0", VA = "0x1808C59A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8C50B0", Offset = "0x8C36B0", VA = "0x1808C50B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset JOFOOIFLFLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xDCF450", Offset = "0xDCDA50", VA = "0x180DCF450")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1719740", Offset = "0x1717D40", VA = "0x181719740")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D00AA0", Offset = "0x3CFF0A0", VA = "0x183D00AA0")]
		public FAFOKHJGLBE(TKey LFOBGDLOPID, TVal AAJFAHDADNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class KCMIKBLHIKJ : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OPOIEJEJAIC<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LinkedList<FAFOKHJGLBE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x120D670", Offset = "0x120BC70", VA = "0x18120D670", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x3BA3BD0", Offset = "0x3BA21D0", VA = "0x183BA3BD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
		[DebuggerHidden]
		public KCMIKBLHIKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B9B4A0", Offset = "0x3B99AA0", VA = "0x183B9B4A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x433D5D0", Offset = "0x433BBD0", VA = "0x18433D5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x433B970", Offset = "0x4339F70", VA = "0x18433B970")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x433E120", Offset = "0x433C720", VA = "0x18433E120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int FBFLEELGCKD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<TKey, LinkedListNode<FAFOKHJGLBE>> EAKMHOHFPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LinkedList<FAFOKHJGLBE> LDBKEDGOKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JDLBAPAHMMA? COPOIMMCIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly TimeSpan JHDHGJGCPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly HFHNFNDOJEH? IAPLAOKPJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly OHIFAJBNMJH BIDEMPOCPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool MPGDCADKEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<TKey> OPJBGFHDBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<TVal> PBPNAFGELMA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JKEHIMLHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x895290", Offset = "0x893890", VA = "0x180895290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int ODAIHEMGKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xCB09D0", Offset = "0xCAEFD0", VA = "0x180CB09D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xCB0570", Offset = "0xCAEB70", VA = "0x180CB0570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4857250", Offset = "0x4855850", VA = "0x184857250", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int HEJMGCIBLHD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3D37A90", Offset = "0x3D36090", VA = "0x183D37A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> EMLPAKLEEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4857400", Offset = "0x4855A00", VA = "0x184857400", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.NEANIKPIBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4852E70", Offset = "0x4851470", VA = "0x184852E70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PBLDLBGBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4857330", Offset = "0x4855930", VA = "0x184857330", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x48574F0", Offset = "0x4855AF0", VA = "0x1848574F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4842B90", Offset = "0x4841190", VA = "0x184842B90")]
	private bool FBDKPKDGINO(int HCAOLDLEJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4841EF0", Offset = "0x48404F0", VA = "0x184841EF0")]
	private void EFFAANMMPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4854750", Offset = "0x4852D50", VA = "0x184854750")]
	public OPOIEJEJAIC(int HCAOLDLEJCN, [Optional] JDLBAPAHMMA? COPOIMMCIOI, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] HFHNFNDOJEH? IAPLAOKPJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4854010", Offset = "0x4852610", VA = "0x184854010")]
	public OPOIEJEJAIC(TimeSpan JHDHGJGCPOH, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] HFHNFNDOJEH? IAPLAOKPJCA, [Optional] OHIFAJBNMJH? BIDEMPOCPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x48545F0", Offset = "0x4852BF0", VA = "0x1848545F0")]
	public OPOIEJEJAIC(int HCAOLDLEJCN, TimeSpan JHDHGJGCPOH, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] HFHNFNDOJEH? IAPLAOKPJCA, [Optional] OHIFAJBNMJH? BIDEMPOCPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4855930", Offset = "0x4853F30", VA = "0x184855930")]
	public OPOIEJEJAIC(int HCAOLDLEJCN, JDLBAPAHMMA? COPOIMMCIOI, TimeSpan JHDHGJGCPOH, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] HFHNFNDOJEH? IAPLAOKPJCA, [Optional] OHIFAJBNMJH? BIDEMPOCPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4851110", Offset = "0x484F710", VA = "0x184851110", Slot = "21")]
	public bool NICBNIPDCNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4844FF0", Offset = "0x48435F0", VA = "0x184844FF0", Slot = "22")]
	public bool GEEBHNCMHID(int BHEAFIOEIAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x484F1F0", Offset = "0x484D7F0", VA = "0x18484F1F0")]
	private bool JGDAMCPCELE(int BHEAFIOEIAD, DLEIAGJLADM ONIANAELCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x48423F0", Offset = "0x48409F0", VA = "0x1848423F0")]
	public void ENCKAHEIPGI(TKey LFOBGDLOPID, TVal KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x483F260", Offset = "0x483D860", VA = "0x18483F260", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x483EA20", Offset = "0x483D020", VA = "0x18483EA20", Slot = "9")]
	public void Add(TKey LFOBGDLOPID, TVal KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x483FB00", Offset = "0x483E100", VA = "0x18483FB00", Slot = "8")]
	public bool ContainsKey(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4852760", Offset = "0x4850D60", VA = "0x184852760", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x48521A0", Offset = "0x48507A0", VA = "0x1848521A0", Slot = "10")]
	public bool Remove(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4852970", Offset = "0x4850F70", VA = "0x184852970", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x48443D0", Offset = "0x48429D0", VA = "0x1848443D0")]
	private bool FIAAFAPNPCL(TKey LFOBGDLOPID, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4851A40", Offset = "0x4850040", VA = "0x184851A40")]
	private TVal PBGHNKGJFJB(TKey BANNIIGGBKD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4853980", Offset = "0x4851F80", VA = "0x184853980", Slot = "11")]
	public bool TryGetValue(TKey BANNIIGGBKD, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x483F900", Offset = "0x483DF00", VA = "0x18483F900", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4840A60", Offset = "0x483F060", VA = "0x184840A60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DKEEEGEFALD, int FFJKEOACOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x48507F0", Offset = "0x484EDF0", VA = "0x1848507F0")]
	private void NHEKBMHHJBF(TKey LFOBGDLOPID, TVal AAJFAHDADNL, DLEIAGJLADM ONIANAELCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x48433B0", Offset = "0x48419B0", VA = "0x1848433B0")]
	private bool FEHAODBHJDC(FAFOKHJGLBE AJGOLABLGFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x484C0F0", Offset = "0x484A6F0", VA = "0x18484C0F0")]
	private void JFFKKLFNOFI(LinkedListNode<FAFOKHJGLBE> IHEJPMODFFG, TVal MMECFHEAHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4845610", Offset = "0x4843C10", VA = "0x184845610")]
	private void GMBIHPHNNPE(TKey LFOBGDLOPID, TVal KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x48482D0", Offset = "0x48468D0", VA = "0x1848482D0")]
	private void JBIABMEEHFE(FAFOKHJGLBE AJGOLABLGFN, TVal MMECFHEAHOI, int IEHKAGPEILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4847570", Offset = "0x4845B70", VA = "0x184847570", Slot = "19")]
	[IteratorStateMachine(typeof(OPOIEJEJAIC<, >.KCMIKBLHIKJ))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4852EC0", Offset = "0x48514C0", VA = "0x184852EC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum DLEIAGJLADM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LEDHMPLONMO<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly TKey PPADNGPHPNE;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x43F5D40", Offset = "0x43F4340", VA = "0x1843F5D40")]
	public LEDHMPLONMO(TKey FHMNOCEMOLD, Exception OCHGOHJLMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class IODOKJFBHMN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F841D0", Offset = "0x5F827D0", VA = "0x185F841D0")]
	public IODOKJFBHMN(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BDGMGOKIHEA<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GGFHHAMNGMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public BDGMGOKIHEA<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GGFHHAMNGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6380", Offset = "0x3DE4980", VA = "0x183DE6380")]
		internal Task<TResource> FPHNCMGHAOG(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct IOFOGBEOABM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public BDGMGOKIHEA<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE000", Offset = "0x3FEC600", VA = "0x183FEE000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3FEE720", Offset = "0x3FECD20", VA = "0x183FEE720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct GMANIGBFBFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8D40", Offset = "0x3DF7340", VA = "0x183DF8D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3DF91A0", Offset = "0x3DF77A0", VA = "0x183DF91A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly LLLIKDHPEPN<TId, Task<TResource>> CGBGFBFMDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> NIGJAFCMMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? GKFNNFMGJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Action<TResource>? EHNKLIHAKPB;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5036740", Offset = "0x5034D40", VA = "0x185036740")]
	public BDGMGOKIHEA(int PNEOLMDLHBN = 0, [Optional] IEqualityComparer<TId>? CNAFKGLMNPL, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACCCKCBDAHL, [Optional] Action<TResource>? HNCDJHAEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5035210", Offset = "0x5033810", VA = "0x185035210")]
	public EMDFPNDLNED<Task<TResource>> EADCAPENOHN(TId MCAKFNPAKIL, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACCCKCBDAHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5036420", Offset = "0x5034A20", VA = "0x185036420")]
	private void OCFKJOBKHJN(Task<TResource> KECDGIGMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x50357F0", Offset = "0x5033DF0", VA = "0x1850357F0")]
	[AsyncStateMachine(typeof(BDGMGOKIHEA<, >.IOFOGBEOABM))]
	private Task EFBJDGPGAIN(Task<TResource> KECDGIGMBNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x50359F0", Offset = "0x5033FF0", VA = "0x1850359F0")]
	public void HFHFGMPNGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5035A50", Offset = "0x5034050", VA = "0x185035A50")]
	public LLLIKDHPEPN<TId, Task<TResource>>.LNIEJMOICNK HNHGFOAAHAF()
	{
		return default(LLLIKDHPEPN<TId, Task<TResource>>.LNIEJMOICNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5036550", Offset = "0x5034B50", VA = "0x185036550", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5036550", Offset = "0x5034B50", VA = "0x185036550", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5035BD0", Offset = "0x50341D0", VA = "0x185035BD0")]
	[AsyncStateMachine(typeof(BDGMGOKIHEA<, >.GMANIGBFBFB))]
	[CompilerGenerated]
	internal static Task IECPCEHCAEF(Task<TResource> KECDGIGMBNG, CancellationTokenSource GPPNCOBMCAK, Dictionary<Task<TResource>, CancellationTokenSource> INFMMHCAJDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class LLLIKDHPEPN<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class HCNMOOLFHND : IEquatable<HCNMOOLFHND>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TValue PGPGCBGPPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int MLOFHACCJAL;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xB07C90", Offset = "0xB06290", VA = "0x180B07C90")]
		public HCNMOOLFHND(TValue KLABJGGMBGH, int GHKLMABMCNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3E6C040", Offset = "0x3E6A640", VA = "0x183E6C040", Slot = "4")]
		public bool Equals(HCNMOOLFHND? PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E6BF90", Offset = "0x3E6A590", VA = "0x183E6BF90", Slot = "0")]
		public override bool Equals(object? GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E6C280", Offset = "0x3E6A880", VA = "0x183E6C280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct LNIEJMOICNK : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<TKey, HCNMOOLFHND>.Enumerator MCCHAJLEDFO;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4410090", Offset = "0x440E690", VA = "0x184410090", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x44105F0", Offset = "0x440EBF0", VA = "0x1844105F0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4410360", Offset = "0x440E960", VA = "0x184410360")]
		public LNIEJMOICNK(LLLIKDHPEPN<TKey, TValue> HGEMHLLLPMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x440FCD0", Offset = "0x440E2D0", VA = "0x18440FCD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x440FD10", Offset = "0x440E310", VA = "0x18440FD10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x440FDD0", Offset = "0x440E3D0", VA = "0x18440FDD0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class HPDAHAMLOKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public LLLIKDHPEPN<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public HCNMOOLFHND refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HPDAHAMLOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E93470", Offset = "0x3E91A70", VA = "0x183E93470")]
		internal void FPHNCMGHAOG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Dictionary<TKey, HCNMOOLFHND> CNPPCKNCAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly Func<TKey, TValue>? HKGECHHKJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Action<TValue>? FJIFIBEEGCJ;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x440BC40", Offset = "0x440A240", VA = "0x18440BC40")]
	public LLLIKDHPEPN(int PNEOLMDLHBN = 0, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] Func<TKey, TValue>? JNMJADJEMPC, [Optional] Action<TValue>? BJCGECPPHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x440AC90", Offset = "0x4409290", VA = "0x18440AC90")]
	public EMDFPNDLNED<TValue> EADCAPENOHN(TKey LFOBGDLOPID, [Optional] Func<TKey, TValue>? LMGHMFACOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x440A280", Offset = "0x4408880", VA = "0x18440A280")]
	private void CJCAMEPPGCI(TKey LFOBGDLOPID, HCNMOOLFHND GCBBDDMICGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x440B550", Offset = "0x4409B50", VA = "0x18440B550")]
	public void HFHFGMPNGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x440B990", Offset = "0x4409F90", VA = "0x18440B990")]
	public LNIEJMOICNK HNHGFOAAHAF()
	{
		return default(LNIEJMOICNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x440BBA0", Offset = "0x440A1A0", VA = "0x18440BBA0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x440BBA0", Offset = "0x440A1A0", VA = "0x18440BBA0", Slot = "5")]
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
