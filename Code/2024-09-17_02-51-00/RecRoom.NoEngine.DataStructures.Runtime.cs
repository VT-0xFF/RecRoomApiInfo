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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D26340", Offset = "0x6D24D40", VA = "0x186D26340")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HAAGAOHNIIN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3ED58A0", Offset = "0x3ED42A0", VA = "0x183ED58A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3ED6300", Offset = "0x3ED4D00", VA = "0x183ED6300")]
	protected GGHGDCNPFAM(bool CIGIGOAHHAA, bool FCDCIMHFHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5DC0", Offset = "0x3ED47C0", VA = "0x183ED5DC0")]
	protected bool HHAHFNNEFMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3ED61E0", Offset = "0x3ED4BE0", VA = "0x183ED61E0")]
	protected void PHCBBOAIEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5910", Offset = "0x3ED4310", VA = "0x183ED5910")]
	protected void DKHBBHNDLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B08C20", Offset = "0x2B07620", VA = "0x182B08C20")]
	private static void GMCGEIOCBEN<U>(List<U>? OLAPNOFMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5BB0", Offset = "0x3ED45B0", VA = "0x183ED5BB0", Slot = "4")]
	public void FABNFHGMHGJ(T PMCMEAHOBEF, bool PAAMEENNNBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5E60", Offset = "0x3ED4860", VA = "0x183ED5E60", Slot = "5")]
	public void MBEEDABKNGP(T PMCMEAHOBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED6030", Offset = "0x3ED4A30", VA = "0x183ED6030")]
	public void MPAAPCHGDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GHNLMGKLHKE : GGHGDCNPFAM<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D24D00", Offset = "0x6D23700", VA = "0x186D24D00")]
	public GHNLMGKLHKE(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D24A40", Offset = "0x6D23440", VA = "0x186D24A40")]
	public void FJEDBGMGJGG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D24CA0", Offset = "0x6D236A0", VA = "0x186D24CA0")]
	public static GHNLMGKLHKE PAFCMDDLEJB(GHNLMGKLHKE PPBDJDNHLED, Action PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D24C40", Offset = "0x6D23640", VA = "0x186D24C40")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DF5C80", Offset = "0x3DF4680", VA = "0x183DF5C80")]
	public KHECJJJIFBB(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4429A20", Offset = "0x4428420", VA = "0x184429A20")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x442A4E0", Offset = "0x4428EE0", VA = "0x18442A4E0")]
	public static KHECJJJIFBB<T> PAFCMDDLEJB(KHECJJJIFBB<T> PPBDJDNHLED, Action<T> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x442A440", Offset = "0x4428E40", VA = "0x18442A440")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DF5C80", Offset = "0x3DF4680", VA = "0x183DF5C80")]
	public LLEJOEJOMJB(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x44E0AA0", Offset = "0x44DF4A0", VA = "0x1844E0AA0")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x442A4E0", Offset = "0x4428EE0", VA = "0x18442A4E0")]
	public static LLEJOEJOMJB<T, U> PAFCMDDLEJB(LLEJOEJOMJB<T, U> PPBDJDNHLED, Action<T, U> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x442A440", Offset = "0x4428E40", VA = "0x18442A440")]
	public static LLEJOEJOMJB<T, U> LGBBBPLMLIL(LLEJOEJOMJB<T, U> PPBDJDNHLED, Action<T, U> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MFOJMBEOKED<T, U, V> : GGHGDCNPFAM<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5C80", Offset = "0x3DF4680", VA = "0x183DF5C80")]
	public MFOJMBEOKED(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4767BB0", Offset = "0x47665B0", VA = "0x184767BB0")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA, V LEKEIHPCIEI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x442A4E0", Offset = "0x4428EE0", VA = "0x18442A4E0")]
	public static MFOJMBEOKED<T, U, V> PAFCMDDLEJB(MFOJMBEOKED<T, U, V> PPBDJDNHLED, Action<T, U, V> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x442A440", Offset = "0x4428E40", VA = "0x18442A440")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DF5C80", Offset = "0x3DF4680", VA = "0x183DF5C80")]
	public PODADAJPNKL(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4A20B10", Offset = "0x4A1F510", VA = "0x184A20B10")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA, V LEKEIHPCIEI, W BPBILCHNBCA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x442A4E0", Offset = "0x4428EE0", VA = "0x18442A4E0")]
	public static PODADAJPNKL<T, U, V, W> PAFCMDDLEJB(PODADAJPNKL<T, U, V, W> PPBDJDNHLED, Action<T, U, V, W> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x442A440", Offset = "0x4428E40", VA = "0x18442A440")]
	public static PODADAJPNKL<T, U, V, W> LGBBBPLMLIL(PODADAJPNKL<T, U, V, W> PPBDJDNHLED, Action<T, U, V, W> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NPHLJGNJJME<T, U, V, W, X> : GGHGDCNPFAM<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5C80", Offset = "0x3DF4680", VA = "0x183DF5C80")]
	public NPHLJGNJJME(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4808490", Offset = "0x4806E90", VA = "0x184808490")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA, V LEKEIHPCIEI, W BPBILCHNBCA, X NCPIGLMANIM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x442A4E0", Offset = "0x4428EE0", VA = "0x18442A4E0")]
	public static NPHLJGNJJME<T, U, V, W, X> PAFCMDDLEJB(NPHLJGNJJME<T, U, V, W, X> PPBDJDNHLED, Action<T, U, V, W, X> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x442A440", Offset = "0x4428E40", VA = "0x18442A440")]
	public static NPHLJGNJJME<T, U, V, W, X> LGBBBPLMLIL(NPHLJGNJJME<T, U, V, W, X> PPBDJDNHLED, Action<T, U, V, W, X> PMCMEAHOBEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BJOHHCIFEDA<T, U, V, W, X, Y> : GGHGDCNPFAM<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5C80", Offset = "0x3DF4680", VA = "0x183DF5C80")]
	public BJOHHCIFEDA(bool CIGIGOAHHAA = false, bool FCDCIMHFHKO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x517D8B0", Offset = "0x517C2B0", VA = "0x18517D8B0")]
	public void FJEDBGMGJGG(T KGPMLIHPPAA, U DJIAOMHLDJA, V LEKEIHPCIEI, W BPBILCHNBCA, X NCPIGLMANIM, Y DJBPOPBDKAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x442A4E0", Offset = "0x4428EE0", VA = "0x18442A4E0")]
	public static BJOHHCIFEDA<T, U, V, W, X, Y> PAFCMDDLEJB(BJOHHCIFEDA<T, U, V, W, X, Y> PPBDJDNHLED, Action<T, U, V, W, X, Y> PMCMEAHOBEF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x442A440", Offset = "0x4428E40", VA = "0x18442A440")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DF9CB0", Offset = "0x3DF86B0", VA = "0x183DF9CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JKEHIMLHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x898FD0", Offset = "0x8979D0", VA = "0x180898FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9D10", Offset = "0x3DF8710", VA = "0x183DF9D10")]
	public FJDOEBGJBDF(int HCFJBCMPLOC, [Optional] OPOIEJEJAIC<TKey, TVal>.JDLBAPAHMMA? COPOIMMCIOI, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] OPOIEJEJAIC<TKey, TVal>.HFHNFNDOJEH? IAPLAOKPJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8950", Offset = "0x3DF7350", VA = "0x183DF8950")]
	public void BCGLIBJPPHJ(TKey LFOBGDLOPID, TVal KLABJGGMBGH, bool JJBIJMBFNIH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9830", Offset = "0x3DF8230", VA = "0x183DF9830")]
	public bool MNEHOJFPCBJ(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9730", Offset = "0x3DF8130", VA = "0x183DF9730")]
	public bool LAFFHOKCOBI(TKey BANNIIGGBKD, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8D70", Offset = "0x3DF7770", VA = "0x183DF8D70")]
	private void DCKDJDAKFKJ(TKey LFOBGDLOPID, TVal KLABJGGMBGH, int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8BA0", Offset = "0x3DF75A0", VA = "0x183DF8BA0")]
	public bool CIGBGFPJDDG(TKey LFOBGDLOPID, TVal KLABJGGMBGH, bool JJBIJMBFNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DF99A0", Offset = "0x3DF83A0", VA = "0x183DF99A0")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DF91A0", Offset = "0x3DF7BA0", VA = "0x183DF91A0")]
	private void HGEADEHFELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9050", Offset = "0x3DF7A50", VA = "0x183DF9050")]
	private bool GMIGIIEIJHJ(TKey LFOBGDLOPID, DLEIAGJLADM ONIANAELCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9B80", Offset = "0x3DF8580", VA = "0x183DF9B80")]
	private void PHEDGPLOOAI(TKey LFOBGDLOPID, TVal KLABJGGMBGH, DLEIAGJLADM ONIANAELCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9A50", Offset = "0x3DF8450", VA = "0x183DF9A50")]
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
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public IKKBBBGOEIJ(Action OMALCONAAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D25680", Offset = "0x6D24080", VA = "0x186D25680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4D70", Offset = "0x2BD3770", VA = "0x182BD4D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A5A970", Offset = "0x3A59370", VA = "0x183A5A970")]
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
		[Cpp2IlInjected.Address(RVA = "0x40AD700", Offset = "0x40AC100", VA = "0x1840AD700")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x40AD640", Offset = "0x40AC040", VA = "0x1840AD640")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FKPHAIMPOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x40AD8C0", Offset = "0x40AC2C0", VA = "0x1840AD8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x40ADEA0", Offset = "0x40AC8A0", VA = "0x1840ADEA0")]
	public IKFMMAFNCDG(HNCNBMPBPMH<T> MOLPCGJFJBL, HNCNBMPBPMH<T> AOGEIBLHLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x40ADFA0", Offset = "0x40AC9A0", VA = "0x1840ADFA0")]
	public IKFMMAFNCDG(HNCNBMPBPMH<T> MOLPCGJFJBL, int NBPJLJIBBHP, HNCNBMPBPMH<T> AOGEIBLHLDG, int GNOIGGGFMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x40AE370", Offset = "0x40ACD70", VA = "0x1840AE370")]
	private IKFMMAFNCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x40AD4F0", Offset = "0x40ABEF0", VA = "0x1840AD4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x40AD370", Offset = "0x40ABD70", VA = "0x1840AD370")]
	public T[] DAJAPAGKKGO()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x40AD240", Offset = "0x40ABC40", VA = "0x1840AD240")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
		public static DEGIHAFPOIK GGBAHLJJLHO()
		{
			return default(DEGIHAFPOIK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2F199C0", Offset = "0x2F183C0", VA = "0x182F199C0")]
	public static string? NKBIHILKBNC<T>([Optional] string? JNLJHPGJODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2F19940", Offset = "0x2F18340", VA = "0x182F19940")]
	public static string? FBLGDABFGHG<T>([Optional] string? JGEJHAKOPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
	public static OGMGECKBGAC IPHAGGDKEPB(string JNLJHPGJODG, string? JGEJHAKOPPO)
	{
		return default(OGMGECKBGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OHGNDOAGJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x48F7500", Offset = "0x48F5F00", VA = "0x1848F7500")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D263C0", Offset = "0x6D24DC0", VA = "0x186D263C0")]
	public static Dictionary<string, OKCGCELKKAL> KCIFLBLJCCF(Type LKNKNGAOOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F20600", Offset = "0x2F1F000", VA = "0x182F20600")]
	public static Dictionary<string, OKCGCELKKAL> KCIFLBLJCCF<T>(Type LKNKNGAOOJD, IReadOnlyDictionary<T, string> PDKHGJEMEFP) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F1FE80", Offset = "0x2F1E880", VA = "0x182F1FE80")]
	public static Dictionary<string, OKCGCELKKAL> FIMBIKNMMHN<T>(List<T> BKHBFACNBFA) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D266F0", Offset = "0x6D250F0", VA = "0x186D266F0")]
	public static Dictionary<string, OKCGCELKKAL> MLDNHAPKPFP(Type LKNKNGAOOJD, IKCLOHNLGFL BDHKDJGKMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D26AB0", Offset = "0x6D254B0", VA = "0x186D26AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D25FF0", Offset = "0x6D249F0", VA = "0x186D25FF0")]
	protected LBGFPGMHGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string CKGPGAAGKNB();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D25B00", Offset = "0x6D24500", VA = "0x186D25B00", Slot = "8")]
	public virtual string FHHOLEOBILE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D25D40", Offset = "0x6D24740", VA = "0x186D25D40", Slot = "9")]
	public void NONFBAGGMDC(StringBuilder CHLKGLNHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D25B80", Offset = "0x6D24580", VA = "0x186D25B80", Slot = "10")]
	public void GCCKCFKNKNK(StringBuilder CHLKGLNHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D259E0", Offset = "0x6D243E0", VA = "0x186D259E0", Slot = "11")]
	public void BFJBFDMOONF(StringBuilder CHLKGLNHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D25BE0", Offset = "0x6D245E0", VA = "0x186D25BE0", Slot = "12")]
	public void JMOAFNOOPPC(StringBuilder CHLKGLNHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D25940", Offset = "0x6D24340", VA = "0x186D25940")]
	public static void ANEHJNLAJOF(StringBuilder CHLKGLNHGFE, string MOMPLMHLOLO, string CFFCPCCOHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4C20", Offset = "0x5EF3620", VA = "0x185EF4C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FIEOBGAOJLE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D246F0", Offset = "0x6D230F0", VA = "0x186D246F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x51964B0", Offset = "0x5194EB0", VA = "0x1851964B0")]
	private BOLGIAEKLDA([In] TErr LIBMGCHELHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x51963D0", Offset = "0x5194DD0", VA = "0x1851963D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool AEDLMMEPKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool GMDJMBMKNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D25530", Offset = "0x6D23F30", VA = "0x186D25530", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long EHFBMINIGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D255A0", Offset = "0x6D23FA0", VA = "0x186D255A0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6D25610", Offset = "0x6D24010", VA = "0x186D25610", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D254C0", Offset = "0x6D23EC0", VA = "0x186D254C0")]
	public IIOIFNBPMBI(HashAlgorithm CEFGNPFENHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D252F0", Offset = "0x6D23CF0", VA = "0x186D252F0", Slot = "35")]
	public override int Read(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int FIGHABPEBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D25490", Offset = "0x6D23E90", VA = "0x186D25490", Slot = "38")]
	public override void Write(byte[] DJOHOLIEOKK, int IEHCONIHMPO, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D25390", Offset = "0x6D23D90", VA = "0x186D25390", Slot = "33")]
	public override long Seek(long IEHCONIHMPO, SeekOrigin LHEBMMKGLMP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D25420", Offset = "0x6D23E20", VA = "0x186D25420", Slot = "34")]
	public override void SetLength(long KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D25220", Offset = "0x6D23C20", VA = "0x186D25220")]
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
		[Cpp2IlInjected.Address(RVA = "0x941870", Offset = "0x940270", VA = "0x180941870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3F53330", Offset = "0x3F51D30", VA = "0x183F53330")]
	private static HNCNBMPBPMH<T> DPOKOFIFLAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3F52D50", Offset = "0x3F51750", VA = "0x183F52D50")]
	private static void DOJEDEKGPBO(HNCNBMPBPMH<T> DIEIHMFNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3A5B9B0", Offset = "0x3A5A3B0", VA = "0x183A5B9B0")]
	private HNCNBMPBPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3F54060", Offset = "0x3F52A60", VA = "0x183F54060")]
	public static HNCNBMPBPMH<T> GMDNOGMNFLF(ReadOnlyMemory<T> MBLLGDBCFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3F53E40", Offset = "0x3F52840", VA = "0x183F53E40")]
	public static HNCNBMPBPMH<T> GMDNOGMNFLF(IMemoryOwner<T> JELMGINMMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3F54620", Offset = "0x3F53020", VA = "0x183F54620")]
	public static void NANGFLKIHLP(HNCNBMPBPMH<T> MOLPCGJFJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3F53800", Offset = "0x3F52200", VA = "0x183F53800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F53D20", Offset = "0x3F52720", VA = "0x183F53D20")]
	public HNCNBMPBPMH<T> GGKHFFLDDLC(IMemoryOwner<T> JELMGINMMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F54520", Offset = "0x3F52F20", VA = "0x183F54520")]
	private void GPNOECPNDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3F54760", Offset = "0x3F53160", VA = "0x183F54760")]
	private HNCNBMPBPMH<T> NIOGEFDEBPJ(HNCNBMPBPMH<T> DIEIHMFNGOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BBIEKFPFKKE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D23770", Offset = "0x6D22170", VA = "0x186D23770")]
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
	[Cpp2IlInjected.Address(RVA = "0x48F1E70", Offset = "0x48F0870", VA = "0x1848F1E70")]
	private OGEBKHBKCHJ([In] TOk EKMNKIFKPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CF00", Offset = "0x3E7B900", VA = "0x183E7CF00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5103040", Offset = "0x5101A40", VA = "0x185103040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BODAAODMEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5103100", Offset = "0x5101B00", VA = "0x185103100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5104D90", Offset = "0x5103790", VA = "0x185104D90")]
	internal BCLNLKLFCPB([In] TErr LIBMGCHELHD, [In] TOk EKMNKIFKPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x51037E0", Offset = "0x51021E0", VA = "0x1851037E0")]
	public static BCLNLKLFCPB<TOk, TErr> FNJHKJCOLLP([In] TErr LIBMGCHELHD)
	{
		return default(BCLNLKLFCPB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5104340", Offset = "0x5102D40", VA = "0x185104340")]
	public static BCLNLKLFCPB<TOk, TErr> MONOOFKONME([In] TOk EKMNKIFKPDG)
	{
		return default(BCLNLKLFCPB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B00430", Offset = "0x2AFEE30", VA = "0x182B00430")]
	public BCLNLKLFCPB<TOk?, UErr?> HPAAJDGAINH<UErr>()
	{
		return default(BCLNLKLFCPB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEFC0", Offset = "0x2AFD9C0", VA = "0x182AFEFC0")]
	public BCLNLKLFCPB<UOk?, TErr?> ABDMFCLOMPO<UOk>()
	{
		return default(BCLNLKLFCPB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFB20", Offset = "0x2AFE520", VA = "0x182AFFB20")]
	public BCLNLKLFCPB<UOk?, TErr?> BHLJAGFPOBF<UOk>()
	{
		return default(BCLNLKLFCPB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B00CF0", Offset = "0x2AFF6F0", VA = "0x182B00CF0")]
	public BCLNLKLFCPB<TOk?, UErr?> OLDICICFGKC<UErr>()
	{
		return default(BCLNLKLFCPB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5103740", Offset = "0x5102140", VA = "0x185103740")]
	public BCLNLKLFCPB<BLGMJKLPHOM, TErr> FHIIKIDOAHP()
	{
		return default(BCLNLKLFCPB<BLGMJKLPHOM, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5103D60", Offset = "0x5102760", VA = "0x185103D60")]
	public static bool MNAFCOICNLK([In] BCLNLKLFCPB<TOk, TErr> NFCDCHABNCB, [In] BCLNLKLFCPB<TOk, TErr> BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5103190", Offset = "0x5101B90", VA = "0x185103190", Slot = "4")]
	public bool Equals(BCLNLKLFCPB<TOk, TErr> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x51035A0", Offset = "0x5101FA0", VA = "0x1851035A0", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5103C20", Offset = "0x5102620", VA = "0x185103C20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5104B30", Offset = "0x5103530", VA = "0x185104B30", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x40B0F80", Offset = "0x40AF980", VA = "0x1840B0F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x40B12C0", Offset = "0x40AFCC0", VA = "0x1840B12C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3438AE0", Offset = "0x34374E0", VA = "0x183438AE0")]
	public static BCLNLKLFCPB<TOk?, TErr?> FAHIEBJJMNN<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [In] TOk EKMNKIFKPDG)
	{
		return default(BCLNLKLFCPB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3438BF0", Offset = "0x34375F0", VA = "0x183438BF0")]
	public static BCLNLKLFCPB<BLGMJKLPHOM, TErr?> FAHIEBJJMNN<TErr>([In] this BCLNLKLFCPB<BLGMJKLPHOM, TErr> BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<BLGMJKLPHOM, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3438AE0", Offset = "0x34374E0", VA = "0x183438AE0")]
	public static BCLNLKLFCPB<TOk?, TErr?> HMMFGPLEEMJ<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [In] TErr LIBMGCHELHD)
	{
		return default(BCLNLKLFCPB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x343A640", Offset = "0x3439040", VA = "0x18343A640")]
	public static TOk? NMMHDODCLBC<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3439B80", Offset = "0x3438580", VA = "0x183439B80")]
	[AsyncStateMachine(typeof(IKPGLNNBDCH<, >))]
	public static Task<TOk?>? JLIMDBDICHN<TOk, TErr>(this Task<BCLNLKLFCPB<TOk, TErr>> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3439370", Offset = "0x3437D70", VA = "0x183439370")]
	public static TErr? IELNMCKFAAE<TErr, TOk>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3437680", Offset = "0x3436080", VA = "0x183437680")]
	public static bool ADJJFPEJKAG<TOk, TErr, UErr, UOk>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out] BCLNLKLFCPB<UOk, UErr> JGMIFKEBIBG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x343A3E0", Offset = "0x3438DE0", VA = "0x18343A3E0")]
	public static bool LKHDEEDHLPD<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3438DB0", Offset = "0x34377B0", VA = "0x183438DB0")]
	public static bool GMDMPGLPJMD<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TErr LIBMGCHELHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3439030", Offset = "0x3437A30", VA = "0x183439030")]
	public static bool GNNKGOEBGMP<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG, [Out][NotNullWhen(false)] TErr LIBMGCHELHD) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3439E50", Offset = "0x3438850", VA = "0x183439E50")]
	public static bool JMDKDOMEKJG<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG, [Out] BCLNLKLFCPB<TOk, TErr> JGMIFKEBIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x34377B0", Offset = "0x34361B0", VA = "0x1834377B0")]
	public static bool ADJJFPEJKAG<TOk, TErr, UErr, UOk>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG, [Out] BCLNLKLFCPB<UOk, UErr> JGMIFKEBIBG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x343A030", Offset = "0x3438A30", VA = "0x18343A030")]
	public static bool JNFDNKGEMFO<TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [Out][NotNullWhen(true)] TOk EKMNKIFKPDG, [Out] BCLNLKLFCPB<BLGMJKLPHOM, TErr> JGMIFKEBIBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3439820", Offset = "0x3438220", VA = "0x183439820")]
	public static BCLNLKLFCPB<UOk, UErr> JCNKGBPGJFN<UOk, UErr, TOk, TErr>([In] this BCLNLKLFCPB<TOk, TErr> BJNJBGHPMEH, [In] BCLNLKLFCPB<UOk, UErr> MNKBAIOBLHC) where TOk : UOk where TErr : UErr
	{
		return default(BCLNLKLFCPB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3438730", Offset = "0x3437130", VA = "0x183438730")]
	public static BCLNLKLFCPB<TOk?[]?, TErr?> AJAKOMEJHNM<TOk, TErr>(this IEnumerable<BCLNLKLFCPB<TOk, TErr>> BJNJBGHPMEH)
	{
		return default(BCLNLKLFCPB<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class ICJFIJPHEKK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CCB0", Offset = "0x2B0B6B0", VA = "0x182B0CCB0")]
	public static BCLNLKLFCPB<TOk, T> FAHIEBJJMNN<TOk>([In] TOk EKMNKIFKPDG) where TOk : notnull
	{
		return default(BCLNLKLFCPB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x401ECA0", Offset = "0x401D6A0", VA = "0x18401ECA0")]
	public static BCLNLKLFCPB<BLGMJKLPHOM, T> FAHIEBJJMNN()
	{
		return default(BCLNLKLFCPB<BLGMJKLPHOM, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CCB0", Offset = "0x2B0B6B0", VA = "0x182B0CCB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F35080", Offset = "0x3F33A80", VA = "0x183F35080")]
	public static CBFNPGOBIBB<TKey, TValue> GGBAHLJJLHO(string EIGKPCONJCB)
	{
		return default(CBFNPGOBIBB<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F351B0", Offset = "0x3F33BB0", VA = "0x183F351B0")]
	internal CBFNPGOBIBB(Dictionary<TKey, TValue> KLABJGGMBGH, KBFHEAKJDEM JMAHNFNHFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F34FD0", Offset = "0x3F339D0", VA = "0x183F34FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x230B0C0", Offset = "0x2309AC0", VA = "0x18230B0C0")]
	internal BOCDMMEFONB(Dictionary<TKey, TValue> KLABJGGMBGH, IFDFMPHCELI GBLLAKFMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CB50", Offset = "0x3E7B550", VA = "0x183E7CB50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F35080", Offset = "0x3F33A80", VA = "0x183F35080")]
	public static OOMOGHEAAOM<T> GGBAHLJJLHO(string EIGKPCONJCB)
	{
		return default(OOMOGHEAAOM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F351B0", Offset = "0x3F33BB0", VA = "0x183F351B0")]
	internal OOMOGHEAAOM(HashSet<T> KLABJGGMBGH, KBFHEAKJDEM JMAHNFNHFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F34FD0", Offset = "0x3F339D0", VA = "0x183F34FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x230B0C0", Offset = "0x2309AC0", VA = "0x18230B0C0")]
	internal AGCIIIHEMPA(HashSet<T> KLABJGGMBGH, IFDFMPHCELI GBLLAKFMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CB50", Offset = "0x3E7B550", VA = "0x183E7CB50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F35080", Offset = "0x3F33A80", VA = "0x183F35080")]
	public static HEDMLFNJKHG<T> GGBAHLJJLHO(string EIGKPCONJCB)
	{
		return default(HEDMLFNJKHG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F351B0", Offset = "0x3F33BB0", VA = "0x183F351B0")]
	internal HEDMLFNJKHG(Stack<T> KLABJGGMBGH, KBFHEAKJDEM JMAHNFNHFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F34FD0", Offset = "0x3F339D0", VA = "0x183F34FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x230B0C0", Offset = "0x2309AC0", VA = "0x18230B0C0")]
	internal KCDODCBIEJM(Stack<T> KLABJGGMBGH, IFDFMPHCELI GBLLAKFMDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CB50", Offset = "0x3E7B550", VA = "0x183E7CB50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2044620", Offset = "0x2043020", VA = "0x182044620")]
		public HEIMNNCONEA(PJKMINGADML<T> BDPEMHOFOHC, int NBCCCAMFPGE, bool KAMMDKBCNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F37060", Offset = "0x3F35A60", VA = "0x183F37060")]
		public PJKMINGADML<T>.POPEDNHAIGH HNHGFOAAHAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F37160", Offset = "0x3F35B60", VA = "0x183F37160", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F37160", Offset = "0x3F35B60", VA = "0x183F37160", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4A285D0", Offset = "0x4A26FD0", VA = "0x184A285D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x4A287E0", Offset = "0x4A271E0", VA = "0x184A287E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x4A28A70", Offset = "0x4A27470", VA = "0x184A28A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4A28E50", Offset = "0x4A27850", VA = "0x184A28E50")]
		public POPEDNHAIGH(PJKMINGADML<T> BDPEMHOFOHC, int NBCCCAMFPGE, bool KAMMDKBCNPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4A286D0", Offset = "0x4A270D0", VA = "0x184A286D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4A28770", Offset = "0x4A27170", VA = "0x184A28770", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NNODLJDPHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4806730", Offset = "0x4805130", VA = "0x184806730")]
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
		[Cpp2IlInjected.Address(RVA = "0x49F5570", Offset = "0x49F3F70", VA = "0x1849F5570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T JINHOCMBIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0280", Offset = "0x3DCEC80", VA = "0x183DD0280")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T FBNLOBKJFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x49F5530", Offset = "0x49F3F30", VA = "0x1849F5530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x49F52B0", Offset = "0x49F3CB0", VA = "0x1849F52B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0350", Offset = "0x1C9ED50", VA = "0x181CA0350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x13CE6F0", Offset = "0x13CD0F0", VA = "0x1813CE6F0")]
	private static int LOAMKNNONEE(int HGFDMIDEFHN, int KHMKAEGDPPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x49F55D0", Offset = "0x49F3FD0", VA = "0x1849F55D0")]
	public PJKMINGADML(int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x49F5700", Offset = "0x49F4100", VA = "0x1849F5700")]
	public PJKMINGADML(int BHEAFIOEIAD, Func<T> CELJDAIDPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x49F5B50", Offset = "0x49F4550", VA = "0x1849F5B50")]
	public PJKMINGADML(T[] KCIKOPILENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x49F5460", Offset = "0x49F3E60", VA = "0x1849F5460")]
	public void HFKPHGFKOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x49F5390", Offset = "0x49F3D90", VA = "0x1849F5390")]
	public IEnumerable<T> FNGIBAAAKGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x49F5490", Offset = "0x49F3E90", VA = "0x1849F5490")]
	public PJKMINGADML<T>.POPEDNHAIGH HNHGFOAAHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F720", Offset = "0x3E4E120", VA = "0x183E4F720", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E4F720", Offset = "0x3E4E120", VA = "0x183E4F720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class PJKAHOIEECA
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F3EC70", Offset = "0x2F3D670", VA = "0x182F3EC70")]
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
			[Cpp2IlInjected.Address(RVA = "0x404ACF0", Offset = "0x40496F0", VA = "0x18404ACF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x404AD10", Offset = "0x4049710", VA = "0x18404AD10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x5677AE0", Offset = "0x56764E0", VA = "0x185677AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4A1FF70", Offset = "0x4A1E970", VA = "0x184A1FF70", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E06790", Offset = "0x3E05190", VA = "0x183E06790")]
	public FLHAGBLLKLO([In] T GOEOMDMENPE, int DFFCLKCIGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3E06750", Offset = "0x3E05150", VA = "0x183E06750")]
	public FLHAGBLLKLO([In] T GOEOMDMENPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3E061F0", Offset = "0x3E04BF0", VA = "0x183E061F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3E06230", Offset = "0x3E04C30", VA = "0x183E06230")]
	public IFHCPKCIOJL FCJOJLLNDHE()
	{
		return default(IFHCPKCIOJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E06270", Offset = "0x3E04C70", VA = "0x183E06270")]
	[AsyncStateMachine(typeof(FLHAGBLLKLO<>.CIILKEOAPLB))]
	public Task<FLHAGBLLKLO<T>.IFHCPKCIOJL> JBDCGOPGPJJ(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E06730", Offset = "0x3E05130", VA = "0x183E06730")]
	public void NLDJHLKAJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class DMFIFPLAINI
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D24630", Offset = "0x6D23030", VA = "0x186D24630")]
	public static FLHAGBLLKLO<BLGMJKLPHOM> GGBAHLJJLHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDA20", Offset = "0x2ACC420", VA = "0x182ACDA20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD6340", Offset = "0x3DD4D40", VA = "0x183DD6340")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C5C0", Offset = "0x3E5AFC0", VA = "0x183E5C5C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DD6340", Offset = "0x3DD4D40", VA = "0x183DD6340")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DD63B0", Offset = "0x3DD4DB0", VA = "0x183DD63B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B401B0", Offset = "0x5B3EBB0", VA = "0x185B401B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4A1FF70", Offset = "0x4A1E970", VA = "0x184A1FF70", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4765E60", Offset = "0x4764860", VA = "0x184765E60")]
	internal MEEBNKPAKKO(FLHAGBLLKLO<int> JPHKPELEMMK, FLHAGBLLKLO<BLGMJKLPHOM> HBBEEPIECAH, FLHAGBLLKLO<BLGMJKLPHOM> OKLIGNLMCFE, [In] T GOEOMDMENPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x47650C0", Offset = "0x4763AC0", VA = "0x1847650C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4765400", Offset = "0x4763E00", VA = "0x184765400")]
	public ABMDGFKMFLB GAPGEIOILGP()
	{
		return default(ABMDGFKMFLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4765960", Offset = "0x4764360", VA = "0x184765960")]
	public FBJFJPKAEAP GMAKAKDGBAO()
	{
		return default(FBJFJPKAEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4765CB0", Offset = "0x47646B0", VA = "0x184765CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D25740", Offset = "0x6D24140", VA = "0x186D25740")]
	public static MEEBNKPAKKO<BLGMJKLPHOM> GGBAHLJJLHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E22F50", Offset = "0x2E21950", VA = "0x182E22F50")]
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
	[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3F31080", Offset = "0x3F2FA80", VA = "0x183F31080")]
	internal HBJAJJJGMOP(string KFAOBDLOMDC, [In] TData JGCMECODHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JKIGLNAKFEH
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6D256C0", Offset = "0x6D240C0", VA = "0x186D256C0")]
	public static HBJAJJJGMOP<BLGMJKLPHOM> GGBAHLJJLHO(string KFAOBDLOMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4D70", Offset = "0x2BD3770", VA = "0x182BD4D70")]
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
	[Cpp2IlInjected.Address(RVA = "0x911E50", Offset = "0x910850", VA = "0x180911E50")]
	private KBFHEAKJDEM(bool IDAIPEJPKHH, string DLLDANCDIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D258D0", Offset = "0x6D242D0", VA = "0x186D258D0")]
	public static KBFHEAKJDEM GGBAHLJJLHO(string DLLDANCDIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D25810", Offset = "0x6D24210", VA = "0x186D25810")]
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
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	internal IFDFMPHCELI(KBFHEAKJDEM EIGKPCONJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D25200", Offset = "0x6D23C00", VA = "0x186D25200", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class OJEBPLNNGLA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class GGNMKAIAALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GGNMKAIAALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3ED77F0", Offset = "0x3ED61F0", VA = "0x183ED77F0")]
		internal int DONBLAIMGHN(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? EAHIJHLAKCA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> FFGCDMFICFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x48FBF50", Offset = "0x48FA950", VA = "0x1848FBF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GPLCCGGIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x48FC200", Offset = "0x48FAC00", VA = "0x1848FC200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A40C0", Offset = "0x8A2AC0", VA = "0x1808A40C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x48FBD20", Offset = "0x48FA720", VA = "0x1848FBD20")]
	public bool FABNFHGMHGJ(T FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x48FC080", Offset = "0x48FAA80", VA = "0x1848FC080")]
	public bool MBEEDABKNGP(T FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x48FBF00", Offset = "0x48FA900", VA = "0x1848FBF00")]
	public bool FEAHPDAAGAE(T FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x48FBF90", Offset = "0x48FA990", VA = "0x1848FBF90")]
	public void IFCLODGLLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x48FC250", Offset = "0x48FAC50", VA = "0x1848FC250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public OJEBPLNNGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class HOLNLKKBEGE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class MIAHEPDFAGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MIAHEPDFAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D26060", Offset = "0x6D24A60", VA = "0x186D26060")]
		internal int DONBLAIMGHN(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? EAHIJHLAKCA;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> FFGCDMFICFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6D24EA0", Offset = "0x6D238A0", VA = "0x186D24EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool GPLCCGGIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6D25040", Offset = "0x6D23A40", VA = "0x186D25040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8A40C0", Offset = "0x8A2AC0", VA = "0x1808A40C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D24D60", Offset = "0x6D23760", VA = "0x186D24D60")]
	public bool FABNFHGMHGJ(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D24FA0", Offset = "0x6D239A0", VA = "0x186D24FA0")]
	public bool MBEEDABKNGP(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6D24E40", Offset = "0x6D23840", VA = "0x186D24E40")]
	public bool FEAHPDAAGAE(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D24F30", Offset = "0x6D23930", VA = "0x186D24F30")]
	public void IFCLODGLLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D25050", Offset = "0x6D23A50", VA = "0x186D25050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public HOLNLKKBEGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class EAIGACMIAOO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct OGLOGMFICEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float HOLMEBECIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T PGPGCBGPPOH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, OGLOGMFICEC> HGEMHLLLPMH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T OFGKMAGDPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x12BF010", Offset = "0x12BDA10", VA = "0x1812BF010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x12BE5F0", Offset = "0x12BCFF0", VA = "0x1812BE5F0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? PBKCNPBGHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool LLEHPMPCDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3A0E800", Offset = "0x3A0D200", VA = "0x183A0E800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F0C0", Offset = "0x3A0DAC0", VA = "0x183A0F0C0")]
	public bool GMBIHPHNNPE(T KLABJGGMBGH, object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E750", Offset = "0x3A0D150", VA = "0x183A0E750")]
	public bool BDCMENKNKIJ(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A10E60", Offset = "0x3A0F860", VA = "0x183A10E60")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A10AC0", Offset = "0x3A0F4C0", VA = "0x183A10AC0")]
	public bool LAFFHOKCOBI(object FLLNLBHFENG, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A0F220", Offset = "0x3A0DC20", VA = "0x183A0F220")]
	[CPCEDDOKEKI("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool IMFFCFJEHBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A10EC0", Offset = "0x3A0F8C0", VA = "0x183A10EC0")]
	public EAIGACMIAOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class EAFCCNKEDEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly string EKHPMBGFPFP;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public EAFCCNKEDEM(string EKHPMBGFPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D246A0", Offset = "0x6D230A0", VA = "0x186D246A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class DMNDLJBGMEJ<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private List<WeakReference<T>>? EAHIJHLAKCA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GPLCCGGIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B56D60", Offset = "0x5B55760", VA = "0x185B56D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5B56720", Offset = "0x5B55120", VA = "0x185B56720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5B568D0", Offset = "0x5B552D0", VA = "0x185B568D0")]
	public void FABNFHGMHGJ(T FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5B56BB0", Offset = "0x5B555B0", VA = "0x185B56BB0")]
	public void MBEEDABKNGP(T FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5B56B60", Offset = "0x5B55560", VA = "0x185B56B60")]
	public void IFCLODGLLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5B56E90", Offset = "0x5B55890", VA = "0x185B56E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public DMNDLJBGMEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class DLJFKAHAMEK
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0150", Offset = "0x2BCEB50", VA = "0x182BD0150")]
	public static void AAOPJACGKPM<T>(this List<T> OLAPNOFMNPM, int HGFDMIDEFHN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class FLDJBKGNCLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<object, float> HGEMHLLLPMH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float OMLEKOCBGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9C14D0", Offset = "0x9BFED0", VA = "0x1809C14D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9C0EF0", Offset = "0x9BF8F0", VA = "0x1809C0EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D248F0", Offset = "0x6D232F0", VA = "0x186D248F0")]
	public void GMBIHPHNNPE(float KLABJGGMBGH, object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D24750", Offset = "0x6D23150", VA = "0x186D24750")]
	public void BDCMENKNKIJ(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D24960", Offset = "0x6D23360", VA = "0x186D24960")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D247C0", Offset = "0x6D231C0", VA = "0x186D247C0")]
	private void GCMMHLCEJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D249B0", Offset = "0x6D233B0", VA = "0x186D249B0")]
	public FLDJBKGNCLA()
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
			[Cpp2IlInjected.Address(RVA = "0x6D24360", Offset = "0x6D22D60", VA = "0x186D24360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D244D0", Offset = "0x6D22ED0", VA = "0x186D244D0")]
		public DLEDIHKPJKB(float OENMMCMOJOM, float FOOPMAMGEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D24370", Offset = "0x6D22D70", VA = "0x186D24370", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OKJEBFPKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6D26C70", Offset = "0x6D25670", VA = "0x186D26C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D23B50", Offset = "0x6D22550", VA = "0x186D23B50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6D23C10", Offset = "0x6D22610", VA = "0x186D23C10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6D241D0", Offset = "0x6D22BD0", VA = "0x186D241D0")]
	public DEDDEELPDLO(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6D24140", Offset = "0x6D22B40", VA = "0x186D24140")]
	public NHPDOFIEOLC PGCPHLAJMKC(DLEDIHKPJKB PCIGIFGMPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6D23CD0", Offset = "0x6D226D0", VA = "0x186D23CD0")]
	public void MLGPAMJFFHK(KIAENMCLBPA IHCJKNPJGGA, [Optional] DLEDIHKPJKB ENHALDAODKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6D23A40", Offset = "0x6D22440", VA = "0x186D23A40", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D23820", Offset = "0x6D22220", VA = "0x186D23820")]
		public CNBEJLNDDCH(KIAENMCLBPA IDGNANOJOBM, MPPFFBOOLBI JMKAJHCEDCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6D237D0", Offset = "0x6D221D0", VA = "0x186D237D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D26D10", Offset = "0x6D25710", VA = "0x186D26D10")]
	internal static bool DKJEECLBMJN(float MOKDKAEJAPP, float MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6D14040", Offset = "0x6D12A40", VA = "0x186D14040")]
	internal static float GDHOOAMKIEP(float MOKDKAEJAPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D26D80", Offset = "0x6D25780", VA = "0x186D26D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D26110", Offset = "0x6D24B10", VA = "0x186D26110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MPPFFBOOLBI? JHLCOOJBGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6D26200", Offset = "0x6D24C00", VA = "0x186D26200", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6D262A0", Offset = "0x6D24CA0", VA = "0x186D262A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x48F7650", Offset = "0x48F6050", VA = "0x1848F7650", Slot = "4")]
	public AGMOFPPEEHD<T> KINKNPKFCGM([Out] T KLABJGGMBGH)
	{
		return default(AGMOFPPEEHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x48F75D0", Offset = "0x48F5FD0", VA = "0x1848F75D0")]
	public void CJCAMEPPGCI(T JKPIGPKLAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4018EC0", Offset = "0x40178C0", VA = "0x184018EC0", Slot = "5")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
	protected virtual void OLEDBFHDGEA(T ANOOCBHGPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x48F76F0", Offset = "0x48F60F0", VA = "0x1848F76F0")]
	private T PBGHNKGJFJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x48F77A0", Offset = "0x48F61A0", VA = "0x1848F77A0")]
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
	[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
	internal AGMOFPPEEHD(T KLABJGGMBGH, OHLANCPOAGD<T> PNBHHBNOEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3E7E470", Offset = "0x3E7CE70", VA = "0x183E7E470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D238D0", Offset = "0x6D222D0", VA = "0x186D238D0")]
	public static AGMOFPPEEHD<StringBuilder> PBGHNKGJFJB([Out] StringBuilder KLABJGGMBGH)
	{
		return default(AGMOFPPEEHD<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D238B0", Offset = "0x6D222B0", VA = "0x186D238B0", Slot = "6")]
	protected override void OLEDBFHDGEA(StringBuilder ANOOCBHGPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D23A00", Offset = "0x6D22400", VA = "0x186D23A00")]
	public DBOFOMALIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class MOHEAONHKJN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67992F0", Offset = "0x6797CF0", VA = "0x1867992F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BF010", Offset = "0x12BDA10", VA = "0x1812BF010", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4551DC0", Offset = "0x45507C0", VA = "0x184551DC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public LPNKNLFPCAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EAE0", Offset = "0x3C4D4E0", VA = "0x183C4EAE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x45518E0", Offset = "0x45502E0", VA = "0x1845518E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4551070", Offset = "0x454FA70", VA = "0x184551070")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4550FD0", Offset = "0x454F9D0", VA = "0x184550FD0")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4551D70", Offset = "0x4550770", VA = "0x184551D70", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x478AF00", Offset = "0x4789900", VA = "0x18478AF00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PBLDLBGBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x478B010", Offset = "0x4789A10", VA = "0x18478B010", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x478B2C0", Offset = "0x4789CC0", VA = "0x18478B2C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> IAJFPBHMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x478B060", Offset = "0x4789A60", VA = "0x18478B060", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> EMLPAKLEEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x478B190", Offset = "0x4789B90", VA = "0x18478B190", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x478AC90", Offset = "0x4789690", VA = "0x18478AC90")]
	public MMKFBDDFLAD(GDPMBAGKHOA<TKey, TValue> NJACILJEJCL, [Optional] IDictionary<TKey, TValue>? IDOOGHKMEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x47889D0", Offset = "0x47873D0", VA = "0x1847889D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4789C10", Offset = "0x4788610", VA = "0x184789C10")]
	public void IKOKFLPIGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x47882B0", Offset = "0x4786CB0", VA = "0x1847882B0", Slot = "9")]
	public void Add(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4787FB0", Offset = "0x47869B0", VA = "0x184787FB0")]
	public void ALNKLDMCEIA(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4788620", Offset = "0x4787020", VA = "0x184788620")]
	public void CAPAPIIGFJK(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x47898A0", Offset = "0x47882A0", VA = "0x1847898A0")]
	public void HCCBCFINBOO(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x47893C0", Offset = "0x4787DC0", VA = "0x1847893C0")]
	public void FFJHLCGHNFO(TKey LFOBGDLOPID, TValue KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x478A2A0", Offset = "0x4788CA0", VA = "0x18478A2A0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x478A4E0", Offset = "0x4788EE0", VA = "0x18478A4E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x478A840", Offset = "0x4789240", VA = "0x18478A840", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4788B10", Offset = "0x4787510", VA = "0x184788B10", Slot = "8")]
	public bool ContainsKey(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4788900", Offset = "0x4787300", VA = "0x184788900")]
	public bool CBNDHIIBNIC(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x47894C0", Offset = "0x4787EC0", VA = "0x1847894C0")]
	public bool GJBNDOLHBCN(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x478A0F0", Offset = "0x4788AF0", VA = "0x18478A0F0", Slot = "10")]
	public bool Remove(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x478AAE0", Offset = "0x47894E0", VA = "0x18478AAE0", Slot = "11")]
	public bool TryGetValue(TKey LFOBGDLOPID, [Out] TValue KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4788E30", Offset = "0x4787830", VA = "0x184788E30", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] DKEEEGEFALD, int FFJKEOACOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x43A8700", Offset = "0x43A7100", VA = "0x1843A8700", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x47896A0", Offset = "0x47880A0", VA = "0x1847896A0", Slot = "19")]
	[IteratorStateMachine(typeof(MMKFBDDFLAD<, >.LPNKNLFPCAD))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4789C60", Offset = "0x4788660", VA = "0x184789C60", Slot = "21")]
	public bool NICBNIPDCNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4789E20", Offset = "0x4788820", VA = "0x184789E20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA13B20", Offset = "0xA12520", VA = "0x180A13B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9D22F0", Offset = "0x9D0CF0", VA = "0x1809D22F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int KHAEIGABOJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8D79A0", Offset = "0x8D63A0", VA = "0x1808D79A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D70B0", Offset = "0x8D5AB0", VA = "0x1808D70B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset JOFOOIFLFLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xE883A0", Offset = "0xE86DA0", VA = "0x180E883A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x18776A0", Offset = "0x18760A0", VA = "0x1818776A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4690", Offset = "0x3DD3090", VA = "0x183DD4690")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BF010", Offset = "0x12BDA10", VA = "0x1812BF010", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4412EA0", Offset = "0x44118A0", VA = "0x184412EA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public KCMIKBLHIKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C49710", Offset = "0x3C48110", VA = "0x183C49710", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4412080", Offset = "0x4410A80", VA = "0x184412080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4410420", Offset = "0x440EE20", VA = "0x184410420")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4412BD0", Offset = "0x44115D0", VA = "0x184412BD0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A7290", Offset = "0x8A5C90", VA = "0x1808A7290")]
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
		[Cpp2IlInjected.Address(RVA = "0x928A90", Offset = "0x927490", VA = "0x180928A90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x928820", Offset = "0x927220", VA = "0x180928820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x491D150", Offset = "0x491BB50", VA = "0x18491D150", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int HEJMGCIBLHD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3A10E60", Offset = "0x3A0F860", VA = "0x183A10E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> EMLPAKLEEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x491D2C0", Offset = "0x491BCC0", VA = "0x18491D2C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.NEANIKPIBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x491B3E0", Offset = "0x4919DE0", VA = "0x18491B3E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PBLDLBGBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x491D1F0", Offset = "0x491BBF0", VA = "0x18491D1F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x491D370", Offset = "0x491BD70", VA = "0x18491D370", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4914630", Offset = "0x4913030", VA = "0x184914630")]
	private bool FBDKPKDGINO(int HCAOLDLEJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4913D50", Offset = "0x4912750", VA = "0x184913D50")]
	private void EFFAANMMPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x491BB50", Offset = "0x491A550", VA = "0x18491BB50")]
	public OPOIEJEJAIC(int HCAOLDLEJCN, [Optional] JDLBAPAHMMA? COPOIMMCIOI, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] HFHNFNDOJEH? IAPLAOKPJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x491C530", Offset = "0x491AF30", VA = "0x18491C530")]
	public OPOIEJEJAIC(TimeSpan JHDHGJGCPOH, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] HFHNFNDOJEH? IAPLAOKPJCA, [Optional] OHIFAJBNMJH? BIDEMPOCPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x491BAD0", Offset = "0x491A4D0", VA = "0x18491BAD0")]
	public OPOIEJEJAIC(int HCAOLDLEJCN, TimeSpan JHDHGJGCPOH, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] HFHNFNDOJEH? IAPLAOKPJCA, [Optional] OHIFAJBNMJH? BIDEMPOCPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x491C690", Offset = "0x491B090", VA = "0x18491C690")]
	public OPOIEJEJAIC(int HCAOLDLEJCN, JDLBAPAHMMA? COPOIMMCIOI, TimeSpan JHDHGJGCPOH, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] HFHNFNDOJEH? IAPLAOKPJCA, [Optional] OHIFAJBNMJH? BIDEMPOCPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x491A5D0", Offset = "0x4918FD0", VA = "0x18491A5D0", Slot = "21")]
	public bool NICBNIPDCNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4915680", Offset = "0x4914080", VA = "0x184915680", Slot = "22")]
	public bool GEEBHNCMHID(int BHEAFIOEIAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4919420", Offset = "0x4917E20", VA = "0x184919420")]
	private bool JGDAMCPCELE(int BHEAFIOEIAD, DLEIAGJLADM ONIANAELCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4914250", Offset = "0x4912C50", VA = "0x184914250")]
	public void ENCKAHEIPGI(TKey LFOBGDLOPID, TVal KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4912980", Offset = "0x4911380", VA = "0x184912980", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x49125D0", Offset = "0x4910FD0", VA = "0x1849125D0", Slot = "9")]
	public void Add(TKey LFOBGDLOPID, TVal KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4912E90", Offset = "0x4911890", VA = "0x184912E90", Slot = "8")]
	public bool ContainsKey(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x491B050", Offset = "0x4919A50", VA = "0x18491B050", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x491AD50", Offset = "0x4919750", VA = "0x18491AD50", Slot = "10")]
	public bool Remove(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x491B290", Offset = "0x4919C90", VA = "0x18491B290", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4915260", Offset = "0x4913C60", VA = "0x184915260")]
	private bool FIAAFAPNPCL(TKey LFOBGDLOPID, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x491A9F0", Offset = "0x49193F0", VA = "0x18491A9F0")]
	private TVal PBGHNKGJFJB(TKey BANNIIGGBKD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x491B8C0", Offset = "0x491A2C0", VA = "0x18491B8C0", Slot = "11")]
	public bool TryGetValue(TKey BANNIIGGBKD, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4912CF0", Offset = "0x49116F0", VA = "0x184912CF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x49132F0", Offset = "0x4911CF0", VA = "0x1849132F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DKEEEGEFALD, int FFJKEOACOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x491A070", Offset = "0x4918A70", VA = "0x18491A070")]
	private void NHEKBMHHJBF(TKey LFOBGDLOPID, TVal AAJFAHDADNL, DLEIAGJLADM ONIANAELCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x49149A0", Offset = "0x49133A0", VA = "0x1849149A0")]
	private bool FEHAODBHJDC(FAFOKHJGLBE AJGOLABLGFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4918180", Offset = "0x4916B80", VA = "0x184918180")]
	private void JFFKKLFNOFI(LinkedListNode<FAFOKHJGLBE> IHEJPMODFFG, TVal MMECFHEAHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x49157E0", Offset = "0x49141E0", VA = "0x1849157E0")]
	private void GMBIHPHNNPE(TKey LFOBGDLOPID, TVal KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4916BC0", Offset = "0x49155C0", VA = "0x184916BC0")]
	private void JBIABMEEHFE(FAFOKHJGLBE AJGOLABLGFN, TVal MMECFHEAHOI, int IEHKAGPEILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4916620", Offset = "0x4915020", VA = "0x184916620", Slot = "19")]
	[IteratorStateMachine(typeof(OPOIEJEJAIC<, >.KCMIKBLHIKJ))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x491B430", Offset = "0x4919E30", VA = "0x18491B430", Slot = "20")]
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
	[Cpp2IlInjected.Address(RVA = "0x44CCC00", Offset = "0x44CB600", VA = "0x1844CCC00")]
	public LEDHMPLONMO(TKey FHMNOCEMOLD, Exception OCHGOHJLMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class IODOKJFBHMN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6067920", Offset = "0x6066320", VA = "0x186067920")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GGFHHAMNGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4B90", Offset = "0x3ED3590", VA = "0x183ED4B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x40BF7B0", Offset = "0x40BE1B0", VA = "0x1840BF7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x40BFED0", Offset = "0x40BE8D0", VA = "0x1840BFED0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EE6F40", Offset = "0x3EE5940", VA = "0x183EE6F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3EE73A0", Offset = "0x3EE5DA0", VA = "0x183EE73A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5119730", Offset = "0x5118130", VA = "0x185119730")]
	public BDGMGOKIHEA(int PNEOLMDLHBN = 0, [Optional] IEqualityComparer<TId>? CNAFKGLMNPL, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACCCKCBDAHL, [Optional] Action<TResource>? HNCDJHAEGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5118200", Offset = "0x5116C00", VA = "0x185118200")]
	public EMDFPNDLNED<Task<TResource>> EADCAPENOHN(TId MCAKFNPAKIL, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACCCKCBDAHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5119410", Offset = "0x5117E10", VA = "0x185119410")]
	private void OCFKJOBKHJN(Task<TResource> KECDGIGMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x51187E0", Offset = "0x51171E0", VA = "0x1851187E0")]
	[AsyncStateMachine(typeof(BDGMGOKIHEA<, >.IOFOGBEOABM))]
	private Task EFBJDGPGAIN(Task<TResource> KECDGIGMBNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x51189E0", Offset = "0x51173E0", VA = "0x1851189E0")]
	public void HFHFGMPNGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5118A40", Offset = "0x5117440", VA = "0x185118A40")]
	public LLLIKDHPEPN<TId, Task<TResource>>.LNIEJMOICNK HNHGFOAAHAF()
	{
		return default(LLLIKDHPEPN<TId, Task<TResource>>.LNIEJMOICNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5119540", Offset = "0x5117F40", VA = "0x185119540", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5119540", Offset = "0x5117F40", VA = "0x185119540", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5118BC0", Offset = "0x51175C0", VA = "0x185118BC0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(BDGMGOKIHEA<, >.GMANIGBFBFB))]
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
		[Cpp2IlInjected.Address(RVA = "0xBBB970", Offset = "0xBBA370", VA = "0x180BBB970")]
		public HCNMOOLFHND(TValue KLABJGGMBGH, int GHKLMABMCNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F33E70", Offset = "0x3F32870", VA = "0x183F33E70", Slot = "4")]
		public bool Equals(HCNMOOLFHND? PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F33DC0", Offset = "0x3F327C0", VA = "0x183F33DC0", Slot = "0")]
		public override bool Equals(object? GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F340B0", Offset = "0x3F32AB0", VA = "0x183F340B0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x44E7230", Offset = "0x44E5C30", VA = "0x1844E7230", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x44E7790", Offset = "0x44E6190", VA = "0x1844E7790", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x44E7500", Offset = "0x44E5F00", VA = "0x1844E7500")]
		public LNIEJMOICNK(LLLIKDHPEPN<TKey, TValue> HGEMHLLLPMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x44E6E70", Offset = "0x44E5870", VA = "0x1844E6E70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x44E6EB0", Offset = "0x44E58B0", VA = "0x1844E6EB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x44E6F70", Offset = "0x44E5970", VA = "0x1844E6F70", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HPDAHAMLOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B490", Offset = "0x3F59E90", VA = "0x183F5B490")]
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
	[Cpp2IlInjected.Address(RVA = "0x44E2B00", Offset = "0x44E1500", VA = "0x1844E2B00")]
	public LLLIKDHPEPN(int PNEOLMDLHBN = 0, [Optional] IEqualityComparer<TKey>? PPPENLMAJJF, [Optional] Func<TKey, TValue>? JNMJADJEMPC, [Optional] Action<TValue>? BJCGECPPHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x44E1B50", Offset = "0x44E0550", VA = "0x1844E1B50")]
	public EMDFPNDLNED<TValue> EADCAPENOHN(TKey LFOBGDLOPID, [Optional] Func<TKey, TValue>? LMGHMFACOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x44E1140", Offset = "0x44DFB40", VA = "0x1844E1140")]
	private void CJCAMEPPGCI(TKey LFOBGDLOPID, HCNMOOLFHND GCBBDDMICGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x44E2410", Offset = "0x44E0E10", VA = "0x1844E2410")]
	public void HFHFGMPNGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x44E2850", Offset = "0x44E1250", VA = "0x1844E2850")]
	public LNIEJMOICNK HNHGFOAAHAF()
	{
		return default(LNIEJMOICNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x44E2A60", Offset = "0x44E1460", VA = "0x1844E2A60", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x44E2A60", Offset = "0x44E1460", VA = "0x1844E2A60", Slot = "5")]
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
