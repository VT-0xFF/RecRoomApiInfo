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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ADD640", Offset = "0x6ADBC40", VA = "0x186ADD640")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NKKMALBJBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	protected NKKMALBJBFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JBPBLDBJHFM<T> : NKKMALBJBFL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct NDGACBGIEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum DKLPNHKGHLI
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
		public DKLPNHKGHLI GOAECDHCJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T PEMICEIPPPL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int ODCHPBEDJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool EPGCPACOCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool JAMGBAIGCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? DOEFJENNAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<NDGACBGIEMJ>? BJKKLMGCNHN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IFJJOHBMEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4072130", Offset = "0x4070730", VA = "0x184072130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x40729E0", Offset = "0x4070FE0", VA = "0x1840729E0")]
	protected JBPBLDBJHFM(bool JAMGBAIGCMJ, bool EPGCPACOCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4072940", Offset = "0x4070F40", VA = "0x184072940")]
	protected bool MFHLLMKMACL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4072820", Offset = "0x4070E20", VA = "0x184072820")]
	protected void MAFMCFLDCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4072580", Offset = "0x4070B80", VA = "0x184072580")]
	protected void LPKIEGPHAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD93E0", Offset = "0x2AD79E0", VA = "0x182AD93E0")]
	private static void EHCDDLFADKM<U>(List<U>? DEPHDEBCNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4072370", Offset = "0x4070970", VA = "0x184072370", Slot = "4")]
	public void LHEPNGLDBLI(T PEMICEIPPPL, bool KLPCEMFOION = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x40721A0", Offset = "0x40707A0", VA = "0x1840721A0", Slot = "5")]
	public void HHOKGKJNBNI(T PEMICEIPPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4071F80", Offset = "0x4070580", VA = "0x184071F80")]
	public void DMCFOMNOLLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class AOBPFOPEJNG : JBPBLDBJHFM<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAB60", Offset = "0x6AD9160", VA = "0x186ADAB60")]
	public AOBPFOPEJNG(bool JAMGBAIGCMJ = false, bool EPGCPACOCHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA8A0", Offset = "0x6AD8EA0", VA = "0x186ADA8A0")]
	public void DKJHOBNJMII()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAB00", Offset = "0x6AD9100", VA = "0x186ADAB00")]
	public static AOBPFOPEJNG PKEDDAIIGLG(AOBPFOPEJNG CDFNGKKMCBO, Action PEMICEIPPPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAAA0", Offset = "0x6AD90A0", VA = "0x186ADAAA0")]
	public static AOBPFOPEJNG OBIKBNNJOKL(AOBPFOPEJNG CDFNGKKMCBO, Action PEMICEIPPPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PHCCKGKKFDD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHEPNGLDBLI(Action<T> PEMICEIPPPL, bool KLPCEMFOION = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHOKGKJNBNI(Action<T> PEMICEIPPPL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class OIPILJJBCKA<T> : JBPBLDBJHFM<Action<T>>, PHCCKGKKFDD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3859A10", Offset = "0x3858010", VA = "0x183859A10")]
	public OIPILJJBCKA(bool JAMGBAIGCMJ = false, bool EPGCPACOCHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46DB230", Offset = "0x46D9830", VA = "0x1846DB230")]
	public void DKJHOBNJMII(T FCNFHCDDANP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3859960", Offset = "0x3857F60", VA = "0x183859960")]
	public static OIPILJJBCKA<T> PKEDDAIIGLG(OIPILJJBCKA<T> CDFNGKKMCBO, Action<T> PEMICEIPPPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38598C0", Offset = "0x3857EC0", VA = "0x1838598C0")]
	public static OIPILJJBCKA<T> OBIKBNNJOKL(OIPILJJBCKA<T> CDFNGKKMCBO, Action<T> PEMICEIPPPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BCFHGPHMEIJ<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class LMAFNHMDPBG<T, U> : JBPBLDBJHFM<Action<T, U>>, BCFHGPHMEIJ<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3859A10", Offset = "0x3858010", VA = "0x183859A10")]
	public LMAFNHMDPBG(bool JAMGBAIGCMJ = false, bool EPGCPACOCHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x42E97D0", Offset = "0x42E7DD0", VA = "0x1842E97D0")]
	public void DKJHOBNJMII(T FCNFHCDDANP, U EIHDOFLFOMC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3859960", Offset = "0x3857F60", VA = "0x183859960")]
	public static LMAFNHMDPBG<T, U> PKEDDAIIGLG(LMAFNHMDPBG<T, U> CDFNGKKMCBO, Action<T, U> PEMICEIPPPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38598C0", Offset = "0x3857EC0", VA = "0x1838598C0")]
	public static LMAFNHMDPBG<T, U> OBIKBNNJOKL(LMAFNHMDPBG<T, U> CDFNGKKMCBO, Action<T, U> PEMICEIPPPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EDBDIMMOBBL<T, U, V> : JBPBLDBJHFM<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3859A10", Offset = "0x3858010", VA = "0x183859A10")]
	public EDBDIMMOBBL(bool JAMGBAIGCMJ = false, bool EPGCPACOCHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3858B50", Offset = "0x3857150", VA = "0x183858B50")]
	public void DKJHOBNJMII(T FCNFHCDDANP, U EIHDOFLFOMC, V HAHPKMHGFDD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3859960", Offset = "0x3857F60", VA = "0x183859960")]
	public static EDBDIMMOBBL<T, U, V> PKEDDAIIGLG(EDBDIMMOBBL<T, U, V> CDFNGKKMCBO, Action<T, U, V> PEMICEIPPPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38598C0", Offset = "0x3857EC0", VA = "0x1838598C0")]
	public static EDBDIMMOBBL<T, U, V> OBIKBNNJOKL(EDBDIMMOBBL<T, U, V> CDFNGKKMCBO, Action<T, U, V> PEMICEIPPPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IKJKHANFPPO<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class OPCFOMELBFB<T, U, V, W> : JBPBLDBJHFM<Action<T, U, V, W>>, IKJKHANFPPO<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3859A10", Offset = "0x3858010", VA = "0x183859A10")]
	public OPCFOMELBFB(bool JAMGBAIGCMJ = false, bool EPGCPACOCHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x46FD340", Offset = "0x46FB940", VA = "0x1846FD340")]
	public void DKJHOBNJMII(T FCNFHCDDANP, U EIHDOFLFOMC, V HAHPKMHGFDD, W BLGAJFHCFEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3859960", Offset = "0x3857F60", VA = "0x183859960")]
	public static OPCFOMELBFB<T, U, V, W> PKEDDAIIGLG(OPCFOMELBFB<T, U, V, W> CDFNGKKMCBO, Action<T, U, V, W> PEMICEIPPPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38598C0", Offset = "0x3857EC0", VA = "0x1838598C0")]
	public static OPCFOMELBFB<T, U, V, W> OBIKBNNJOKL(OPCFOMELBFB<T, U, V, W> CDFNGKKMCBO, Action<T, U, V, W> PEMICEIPPPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class DFIALGIGCFM<T, U, V, W, X> : JBPBLDBJHFM<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3859A10", Offset = "0x3858010", VA = "0x183859A10")]
	public DFIALGIGCFM(bool JAMGBAIGCMJ = false, bool EPGCPACOCHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x58C3460", Offset = "0x58C1A60", VA = "0x1858C3460")]
	public void DKJHOBNJMII(T FCNFHCDDANP, U EIHDOFLFOMC, V HAHPKMHGFDD, W BLGAJFHCFEJ, X OCPDJIJPMCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3859960", Offset = "0x3857F60", VA = "0x183859960")]
	public static DFIALGIGCFM<T, U, V, W, X> PKEDDAIIGLG(DFIALGIGCFM<T, U, V, W, X> CDFNGKKMCBO, Action<T, U, V, W, X> PEMICEIPPPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38598C0", Offset = "0x3857EC0", VA = "0x1838598C0")]
	public static DFIALGIGCFM<T, U, V, W, X> OBIKBNNJOKL(DFIALGIGCFM<T, U, V, W, X> CDFNGKKMCBO, Action<T, U, V, W, X> PEMICEIPPPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MPLEGBPEEAP<T, U, V, W, X, Y> : JBPBLDBJHFM<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3859A10", Offset = "0x3858010", VA = "0x183859A10")]
	public MPLEGBPEEAP(bool JAMGBAIGCMJ = false, bool EPGCPACOCHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44F9CF0", Offset = "0x44F82F0", VA = "0x1844F9CF0")]
	public void DKJHOBNJMII(T FCNFHCDDANP, U EIHDOFLFOMC, V HAHPKMHGFDD, W BLGAJFHCFEJ, X OCPDJIJPMCG, Y DEKMKLPIHFO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3859960", Offset = "0x3857F60", VA = "0x183859960")]
	public static MPLEGBPEEAP<T, U, V, W, X, Y> PKEDDAIIGLG(MPLEGBPEEAP<T, U, V, W, X, Y> CDFNGKKMCBO, Action<T, U, V, W, X, Y> PEMICEIPPPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38598C0", Offset = "0x3857EC0", VA = "0x1838598C0")]
	public static MPLEGBPEEAP<T, U, V, W, X, Y> OBIKBNNJOKL(MPLEGBPEEAP<T, U, V, W, X, Y> CDFNGKKMCBO, Action<T, U, V, W, X, Y> PEMICEIPPPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IONGGMLOLHP<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GJMLKDCAFHK<TKey, TVal> KCNLBPAPBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FAHBHCOKHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GJMLKDCAFHK<TKey, TVal>.PLBFABMFGJA? DJODAPAMBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int LEHALGIMJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GJMLKDCAFHK<TKey, TVal>.NDPANOHFBGA? LNDFGGMKGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int BMACMJBHKGC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int ECOHEDPAHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3E94470", Offset = "0x3E92A70", VA = "0x183E94470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LDAFFHKGGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86E900", Offset = "0x86CF00", VA = "0x18086E900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E94D40", Offset = "0x3E93340", VA = "0x183E94D40")]
	public IONGGMLOLHP(int LEHALGIMJOC, [Optional] GJMLKDCAFHK<TKey, TVal>.NDPANOHFBGA? LNDFGGMKGIF, [Optional] IEqualityComparer<TKey>? IMHCCDPMLAI, [Optional] GJMLKDCAFHK<TKey, TVal>.PLBFABMFGJA? DJODAPAMBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E94AF0", Offset = "0x3E930F0", VA = "0x183E94AF0")]
	public void PDBKDHBLHLG(TKey IBBDLGCDELM, TVal DMNGPNKHPKF, bool DJPNHIEBOOC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3E946A0", Offset = "0x3E92CA0", VA = "0x183E946A0")]
	public bool LNKJLFEGCBP(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E93980", Offset = "0x3E91F80", VA = "0x183E93980")]
	public bool APLEJEFPFAB(TKey GJKHPDNCDMH, [Out] TVal DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E94810", Offset = "0x3E92E10", VA = "0x183E94810")]
	private void PAIFLNADPCJ(TKey IBBDLGCDELM, TVal DMNGPNKHPKF, int LPKLLJKOBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E944D0", Offset = "0x3E92AD0", VA = "0x183E944D0")]
	public bool LBNMBEGEMCM(TKey IBBDLGCDELM, TVal DMNGPNKHPKF, bool DJPNHIEBOOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E93D00", Offset = "0x3E92300", VA = "0x183E93D00")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E93EE0", Offset = "0x3E924E0", VA = "0x183E93EE0")]
	private void GGINNCELMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E93A80", Offset = "0x3E92080", VA = "0x183E93A80")]
	private bool CNBEOEAKDDO(TKey IBBDLGCDELM, IBBMGNDOKJN GBNNAJEHACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E93DB0", Offset = "0x3E923B0", VA = "0x183E93DB0")]
	private void FMHEMEJCCAG(TKey IBBDLGCDELM, TVal DMNGPNKHPKF, IBBMGNDOKJN GBNNAJEHACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E93BD0", Offset = "0x3E921D0", VA = "0x183E93BD0")]
	private void DJFPHLILAIJ(TKey IBBDLGCDELM, TVal KPJDKHEOHPO, IBBMGNDOKJN GBNNAJEHACL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PNLOFIKPLOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action AANDLJELEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HMDMCDIHCMB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public PNLOFIKPLOD(Action IIPPFKJLDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEB60", Offset = "0x6ADD160", VA = "0x186ADEB60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29A5D90", Offset = "0x29A4390", VA = "0x1829A5D90")]
	public static AHJCAINOMHJ<T> BBHPEKFPBBP<T>(T DMNGPNKHPKF, Action IIPPFKJLDIA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class AHJCAINOMHJ<T> : PNLOFIKPLOD where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T FJLALGMPANI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC66A0", Offset = "0x3CC4CA0", VA = "0x183CC66A0")]
	public AHJCAINOMHJ(T DMNGPNKHPKF, Action IIPPFKJLDIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class APAJPLOCNBP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DGNNIGNPBDP<T>? MMFBOJKPJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> AFOGKCNLKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool HMDMCDIHCMB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly APAJPLOCNBP<T> CHPFPNHMMDE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> LCIFKFMHCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD660", Offset = "0x3ECBC60", VA = "0x183ECD660")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD4E0", Offset = "0x3ECBAE0", VA = "0x183ECD4E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HIFFGJEKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD420", Offset = "0x3ECBA20", VA = "0x183ECD420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3ECDFD0", Offset = "0x3ECC5D0", VA = "0x183ECDFD0")]
	public APAJPLOCNBP(DGNNIGNPBDP<T> PAKHJOGNFAB, DGNNIGNPBDP<T> ECDBJBBPMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE180", Offset = "0x3ECC780", VA = "0x183ECE180")]
	public APAJPLOCNBP(DGNNIGNPBDP<T> PAKHJOGNFAB, int CMKHMGALFJE, DGNNIGNPBDP<T> ECDBJBBPMKF, int OCNGKIJHOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3ECE0D0", Offset = "0x3ECC6D0", VA = "0x183ECE0D0")]
	private APAJPLOCNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD760", Offset = "0x3ECBD60", VA = "0x183ECD760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD9E0", Offset = "0x3ECBFE0", VA = "0x183ECD9E0")]
	public T[] HPKFMOENKFN()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD7F0", Offset = "0x3ECBDF0", VA = "0x183ECD7F0")]
	public static ReadOnlySequence<T> HDKGBCFDEBL(APAJPLOCNBP<T>? EEJFHEAAALJ)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MOPBPKFEPJN : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct CGGOIPDNKMD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060")]
		public static CGGOIPDNKMD ENFOKLPNHAF()
		{
			return default(CGGOIPDNKMD);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2C78400", Offset = "0x2C76A00", VA = "0x182C78400")]
	public static string? JEDFILKMDCJ<T>([Optional] string? BLDENFFKKLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2C78380", Offset = "0x2C76980", VA = "0x182C78380")]
	public static string? FACJHJFADLF<T>([Optional] string? NAHBGCOKJLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060")]
	public static MOPBPKFEPJN AOLCCKEJHHA(string BLDENFFKKLB, string? NAHBGCOKJLM)
	{
		return default(MOPBPKFEPJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OJKMPFKGAPM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool JPEAJGNEHHH(string DCJBOEELBKB, OJKMPFKGAPM NFGDHIIKFAK);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NBMKMBJKLML<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public NBMKMBJKLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4559970", Offset = "0x4557F70", VA = "0x184559970")]
		internal void KDIDHGAODDC(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int ANPOJJGGDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string IIAMFGPKADM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDEE0", Offset = "0x6ADC4E0", VA = "0x186ADDEE0")]
	public static Dictionary<string, OJKMPFKGAPM> HBHPDPOOLAH(Type KODGOOBOLEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA880", Offset = "0x2CF8E80", VA = "0x182CFA880")]
	public static Dictionary<string, OJKMPFKGAPM> HBHPDPOOLAH<T>(Type KODGOOBOLEJ, IReadOnlyDictionary<T, string> LOKEFOGNHDI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA100", Offset = "0x2CF8700", VA = "0x182CFA100")]
	public static Dictionary<string, OJKMPFKGAPM> EPAIGCEDCPH<T>(List<T> ENNDIPFCGMF) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDB20", Offset = "0x6ADC120", VA = "0x186ADDB20")]
	public static Dictionary<string, OJKMPFKGAPM> AJBCGAPGGPD(Type KODGOOBOLEJ, JPEAJGNEHHH DGINCNDAGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE220", Offset = "0x6ADC820", VA = "0x186ADE220")]
	public static Dictionary<int, string> ICNLACLLAPD(Dictionary<string, OJKMPFKGAPM> MADFKNCBFBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PJDAENIABGC : GJMJCOBOHDO
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool OHNIJIGFMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? BCDAKLBMCEC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual GJMJCOBOHDO? ELGANDKGCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEAF0", Offset = "0x6ADD0F0", VA = "0x186ADEAF0")]
	protected PJDAENIABGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string AFLHKEIDPKB();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE950", Offset = "0x6ADCF50", VA = "0x186ADE950", Slot = "8")]
	public virtual string LBBKIGMJFKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE440", Offset = "0x6ADCA40", VA = "0x186ADE440", Slot = "9")]
	public void GKKCLMFGHPF(StringBuilder KDELJDKGFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE6F0", Offset = "0x6ADCCF0", VA = "0x186ADE6F0", Slot = "10")]
	public void IOIPADBMHEA(StringBuilder KDELJDKGFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE9D0", Offset = "0x6ADCFD0", VA = "0x186ADE9D0", Slot = "11")]
	public void LEFFNAMDPCF(StringBuilder KDELJDKGFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE7F0", Offset = "0x6ADCDF0", VA = "0x186ADE7F0", Slot = "12")]
	public void LAMAHNICHLI(StringBuilder KDELJDKGFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE750", Offset = "0x6ADCD50", VA = "0x186ADE750")]
	public static void JPMODMEFFCM(StringBuilder KDELJDKGFBC, string FBJDALPODFD, string PMFAGAODKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0AF0", Offset = "0x5C9F0F0", VA = "0x185CA0AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OLAGHNFPGIH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE3E0", Offset = "0x6ADC9E0", VA = "0x186ADE3E0")]
	public OLAGHNFPGIH(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GLDBJNMJOCP<TErr> : OLAGHNFPGIH where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr LFIMGBKMCMG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3D363D0", Offset = "0x3D349D0", VA = "0x183D363D0")]
	private GLDBJNMJOCP([In] TErr DPFHENKCHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3D362F0", Offset = "0x3D348F0", VA = "0x183D362F0")]
	public static GLDBJNMJOCP<TErr> ENFOKLPNHAF([In] TErr DPFHENKCHHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EDEOCKCMLAO : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm MCIOJFGGNEM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool DPBFHINDPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool CMICJCKLOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool HLJGHBPHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBED0", Offset = "0x6ADA4D0", VA = "0x186ADBED0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long GJMAELHLBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBF40", Offset = "0x6ADA540", VA = "0x186ADBF40", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBFB0", Offset = "0x6ADA5B0", VA = "0x186ADBFB0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBE60", Offset = "0x6ADA460", VA = "0x186ADBE60")]
	public EDEOCKCMLAO(HashAlgorithm MCIOJFGGNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBC80", Offset = "0x6ADA280", VA = "0x186ADBC80", Slot = "35")]
	public override int Read(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, int BMKFLHFENBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBE30", Offset = "0x6ADA430", VA = "0x186ADBE30", Slot = "38")]
	public override void Write(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, int BMKFLHFENBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBD20", Offset = "0x6ADA320", VA = "0x186ADBD20", Slot = "33")]
	public override long Seek(long GCMGLJCEDLO, SeekOrigin BKCDIKNOEPB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBDB0", Offset = "0x6ADA3B0", VA = "0x186ADBDB0", Slot = "34")]
	public override void SetLength(long DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBBA0", Offset = "0x6ADA1A0", VA = "0x186ADBBA0")]
	public byte[] BDMFLIFKCGI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GJMJCOBOHDO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LBBKIGMJFKE();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AFLHKEIDPKB();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FPFOIJEKMKA<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions FJLALGMPANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CCNLCFFDGEL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string MJMIKPGGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DGNNIGNPBDP<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static DGNNIGNPBDP<T>? FCGLGHJABGO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object ACPFJCOCACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? LGNNBFAIJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool HMDMCDIHCMB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DBIJCBPOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA10B60", Offset = "0xA0F160", VA = "0x180A10B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x58C8880", Offset = "0x58C6E80", VA = "0x1858C8880")]
	private static DGNNIGNPBDP<T> LJDMIKMAEOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x58C8E70", Offset = "0x58C7470", VA = "0x1858C8E70")]
	private static void OBBPFMGJFOH(DGNNIGNPBDP<T> KCLFGAKHIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3DA26A0", Offset = "0x3DA0CA0", VA = "0x183DA26A0")]
	private DGNNIGNPBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x58C7E40", Offset = "0x58C6440", VA = "0x1858C7E40")]
	public static DGNNIGNPBDP<T> BBHPEKFPBBP(ReadOnlyMemory<T> AGGBICJACGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x58C7A40", Offset = "0x58C6040", VA = "0x1858C7A40")]
	public static DGNNIGNPBDP<T> BBHPEKFPBBP(IMemoryOwner<T> JNLAMDDIDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x58C8740", Offset = "0x58C6D40", VA = "0x1858C8740")]
	public static void IPNCEEOKCDN(DGNNIGNPBDP<T> PAKHJOGNFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x58C8020", Offset = "0x58C6620", VA = "0x1858C8020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x58C8D50", Offset = "0x58C7350", VA = "0x1858C8D50")]
	public DGNNIGNPBDP<T> LOAJHLPEHFH(IMemoryOwner<T> JNLAMDDIDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x58C8640", Offset = "0x58C6C40", VA = "0x1858C8640")]
	private void FFJAJHKDAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x58C9460", Offset = "0x58C7A60", VA = "0x1858C9460")]
	private DGNNIGNPBDP<T> PCJAMHHNPBH(DGNNIGNPBDP<T> KCLFGAKHIJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BMBMBFOCOHJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6ADABC0", Offset = "0x6AD91C0", VA = "0x186ADABC0")]
	public BMBMBFOCOHJ(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JHIGDOJFIIA<TOk> : BMBMBFOCOHJ where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk FMAHAGMBBKO;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4090630", Offset = "0x408EC30", VA = "0x184090630")]
	private JHIGDOJFIIA([In] TOk GNGMCPGPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3E87020", Offset = "0x3E85620", VA = "0x183E87020")]
	public static JHIGDOJFIIA<TOk> ENFOKLPNHAF([In] TOk GNGMCPGPCFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DHHOHDJHBPB : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly ReadOnlySequence<byte> AFOGKCNLKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private SequencePosition HNAHNLHOLGK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override bool DPBFHINDPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override bool CMICJCKLOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override bool HLJGHBPHKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public override long LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB930", Offset = "0x6AD9F30", VA = "0x186ADB930", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override long GJMAELHLBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB990", Offset = "0x6AD9F90", VA = "0x186ADB990", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBA60", Offset = "0x6ADA060", VA = "0x186ADBA60", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB860", Offset = "0x6AD9E60", VA = "0x186ADB860")]
	public DHHOHDJHBPB(ReadOnlySequence<byte> EEJFHEAAALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB410", Offset = "0x6AD9A10", VA = "0x186ADB410", Slot = "33")]
	public override long Seek(long GCMGLJCEDLO, SeekOrigin BKCDIKNOEPB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAF70", Offset = "0x6AD9570", VA = "0x186ADAF70", Slot = "35")]
	public override int Read(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, int BMKFLHFENBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB7A0", Offset = "0x6AD9DA0", VA = "0x186ADB7A0", Slot = "34")]
	public override void SetLength(long DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB800", Offset = "0x6AD9E00", VA = "0x186ADB800", Slot = "38")]
	public override void Write(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, int BMKFLHFENBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct CBDPDIPONCF<TOk, TErr> : IEquatable<CBDPDIPONCF<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> KCHFOCDLBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr LFIMGBKMCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk FMAHAGMBBKO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OJPGJKNILHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x51A3FE0", Offset = "0x51A25E0", VA = "0x1851A3FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DLLOEODAEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x51A6070", Offset = "0x51A4670", VA = "0x1851A6070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x51A9A30", Offset = "0x51A8030", VA = "0x1851A9A30")]
	internal CBDPDIPONCF([In] TErr DPFHENKCHHI, [In] TOk GNGMCPGPCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x51A5AE0", Offset = "0x51A40E0", VA = "0x1851A5AE0")]
	public static CBDPDIPONCF<TOk, TErr> IDGIKEJDANF([In] TErr DPFHENKCHHI)
	{
		return default(CBDPDIPONCF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x51A1140", Offset = "0x519F740", VA = "0x1851A1140")]
	public static CBDPDIPONCF<TOk, TErr> AKDCGKMGFFO([In] TOk GNGMCPGPCFL)
	{
		return default(CBDPDIPONCF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D2B0", Offset = "0x2A0B8B0", VA = "0x182A0D2B0")]
	public CBDPDIPONCF<TOk?, UErr?> LKLMLEOLEHH<UErr>()
	{
		return default(CBDPDIPONCF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A0CCA0", Offset = "0x2A0B2A0", VA = "0x182A0CCA0")]
	public CBDPDIPONCF<UOk?, TErr?> BMDFNEKHDHD<UOk>()
	{
		return default(CBDPDIPONCF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E1C0", Offset = "0x2A0C7C0", VA = "0x182A0E1C0")]
	public CBDPDIPONCF<UOk?, TErr?> NDNDIECKMOC<UOk>()
	{
		return default(CBDPDIPONCF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2A0D680", Offset = "0x2A0BC80", VA = "0x182A0D680")]
	public CBDPDIPONCF<TOk?, UErr?> LPJAGJKKNJE<UErr>()
	{
		return default(CBDPDIPONCF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x51A66C0", Offset = "0x51A4CC0", VA = "0x1851A66C0")]
	public CBDPDIPONCF<COKMANPFJNC, TErr> PKAEGEEANGL()
	{
		return default(CBDPDIPONCF<COKMANPFJNC, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x51A2FD0", Offset = "0x51A15D0", VA = "0x1851A2FD0")]
	public static bool FFOLOHFBIHN([In] CBDPDIPONCF<TOk, TErr> CLMMPLJCADB, [In] CBDPDIPONCF<TOk, TErr> NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x51A1970", Offset = "0x519FF70", VA = "0x1851A1970", Slot = "4")]
	public bool Equals(CBDPDIPONCF<TOk, TErr> BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x51A1A50", Offset = "0x51A0050", VA = "0x1851A1A50", Slot = "0")]
	public override bool Equals(object BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x51A4BF0", Offset = "0x51A31F0", VA = "0x1851A4BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x51A8590", Offset = "0x51A6B90", VA = "0x1851A8590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class EFBOEMNMAKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BFLBLLLAMGB<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<CBDPDIPONCF<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<CBDPDIPONCF<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4EC9D40", Offset = "0x4EC8340", VA = "0x184EC9D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4ECA080", Offset = "0x4EC8680", VA = "0x184ECA080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A330D0", Offset = "0x2A316D0", VA = "0x182A330D0")]
	public static CBDPDIPONCF<TOk?, TErr?> FMAHAGMBBKO<TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [In] TOk GNGMCPGPCFL)
	{
		return default(CBDPDIPONCF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A33120", Offset = "0x2A31720", VA = "0x182A33120")]
	public static CBDPDIPONCF<COKMANPFJNC, TErr?> FMAHAGMBBKO<TErr>([In] this CBDPDIPONCF<COKMANPFJNC, TErr> HLIDMKMINHN)
	{
		return default(CBDPDIPONCF<COKMANPFJNC, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A330D0", Offset = "0x2A316D0", VA = "0x182A330D0")]
	public static CBDPDIPONCF<TOk?, TErr?> LFIMGBKMCMG<TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [In] TErr DPFHENKCHHI)
	{
		return default(CBDPDIPONCF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A31990", Offset = "0x2A2FF90", VA = "0x182A31990")]
	public static TOk? AFJDIDPGOPK<TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A33340", Offset = "0x2A31940", VA = "0x182A33340")]
	[AsyncStateMachine(typeof(BFLBLLLAMGB<, >))]
	public static Task<TOk?>? GAJMICANOCO<TOk, TErr>(this Task<CBDPDIPONCF<TOk, TErr>> HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A32AA0", Offset = "0x2A310A0", VA = "0x182A32AA0")]
	public static TErr? DFJOGNFICOJ<TErr, TOk>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A33750", Offset = "0x2A31D50", VA = "0x182A33750")]
	public static bool GJNNKDNEIFB<TOk, TErr, UErr, UOk>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [Out] CBDPDIPONCF<UOk, UErr> ALPIIKPFOBE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A34C40", Offset = "0x2A33240", VA = "0x182A34C40")]
	public static bool PJDOHKIEPDO<TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [Out][NotNullWhen(true)] TOk GNGMCPGPCFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A34B00", Offset = "0x2A33100", VA = "0x182A34B00")]
	public static bool MKKALGDNOFD<TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [Out][NotNullWhen(true)] TErr DPFHENKCHHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A34880", Offset = "0x2A32E80", VA = "0x182A34880")]
	public static bool IFHIPBBMDGA<TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [Out][NotNullWhen(true)] TOk GNGMCPGPCFL, [Out][NotNullWhen(false)] TErr DPFHENKCHHI) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A34A00", Offset = "0x2A33000", VA = "0x182A34A00")]
	public static bool IGJMDIPHJFC<TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [Out][NotNullWhen(true)] TOk GNGMCPGPCFL, [Out] CBDPDIPONCF<TOk, TErr> ALPIIKPFOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A33880", Offset = "0x2A31E80", VA = "0x182A33880")]
	public static bool GJNNKDNEIFB<TOk, TErr, UErr, UOk>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [Out][NotNullWhen(true)] TOk GNGMCPGPCFL, [Out] CBDPDIPONCF<UOk, UErr> ALPIIKPFOBE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A31EC0", Offset = "0x2A304C0", VA = "0x182A31EC0")]
	public static bool AOJAJNLBAIP<TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [Out][NotNullWhen(true)] TOk GNGMCPGPCFL, [Out] CBDPDIPONCF<COKMANPFJNC, TErr> ALPIIKPFOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A324B0", Offset = "0x2A30AB0", VA = "0x182A324B0")]
	public static CBDPDIPONCF<UOk, UErr> DEKNMFDHEML<UOk, UErr, TOk, TErr>([In] this CBDPDIPONCF<TOk, TErr> HLIDMKMINHN, [In] CBDPDIPONCF<UOk, UErr> INKFLMKONLP) where TOk : UOk where TErr : UErr
	{
		return default(CBDPDIPONCF<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A32D60", Offset = "0x2A31360", VA = "0x182A32D60")]
	public static CBDPDIPONCF<TOk?[]?, TErr?> DFMGDMMMELH<TOk, TErr>(this IEnumerable<CBDPDIPONCF<TOk, TErr>> HLIDMKMINHN)
	{
		return default(CBDPDIPONCF<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FAEKLMJCNHE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A14720", Offset = "0x2A12D20", VA = "0x182A14720")]
	public static CBDPDIPONCF<TOk, T> FMAHAGMBBKO<TOk>([In] TOk GNGMCPGPCFL) where TOk : notnull
	{
		return default(CBDPDIPONCF<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3BF65F0", Offset = "0x3BF4BF0", VA = "0x183BF65F0")]
	public static CBDPDIPONCF<COKMANPFJNC, T> FMAHAGMBBKO()
	{
		return default(CBDPDIPONCF<COKMANPFJNC, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A14690", Offset = "0x2A12C90", VA = "0x182A14690")]
	public static CBDPDIPONCF<T, TErr> LFIMGBKMCMG<TErr>([In] TErr DPFHENKCHHI) where TErr : notnull
	{
		return default(CBDPDIPONCF<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct DOHHELLHFGD<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly OAGIFJLCPFO JCFIABPDFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> KEHLKEICKEB;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9220", Offset = "0x3CF7820", VA = "0x183CF9220")]
	public static DOHHELLHFGD<TKey, TValue> ENFOKLPNHAF(string CAMDIODFJJE)
	{
		return default(DOHHELLHFGD<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9400", Offset = "0x3CF7A00", VA = "0x183CF9400")]
	internal DOHHELLHFGD(Dictionary<TKey, TValue> DMNGPNKHPKF, OAGIFJLCPFO DKDKLKDHPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9350", Offset = "0x3CF7950", VA = "0x183CF9350")]
	public IGMEHJNEPBB<TKey, TValue> FEKCMALMKHK([Out] Dictionary<TKey, TValue> DMNGPNKHPKF)
	{
		return default(IGMEHJNEPBB<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct IGMEHJNEPBB<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> KEHLKEICKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly FJMMOCJCFKP FADKPDGOGKN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x21B8E30", Offset = "0x21B7430", VA = "0x1821B8E30")]
	internal IGMEHJNEPBB(Dictionary<TKey, TValue> DMNGPNKHPKF, FJMMOCJCFKP FFFMCNFHFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E6A8E0", Offset = "0x3E68EE0", VA = "0x183E6A8E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct LCIDHPKACFP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly OAGIFJLCPFO JCFIABPDFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> KEHLKEICKEB;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9220", Offset = "0x3CF7820", VA = "0x183CF9220")]
	public static LCIDHPKACFP<T> ENFOKLPNHAF(string CAMDIODFJJE)
	{
		return default(LCIDHPKACFP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9400", Offset = "0x3CF7A00", VA = "0x183CF9400")]
	internal LCIDHPKACFP(HashSet<T> DMNGPNKHPKF, OAGIFJLCPFO DKDKLKDHPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9350", Offset = "0x3CF7950", VA = "0x183CF9350")]
	public JGCKPLEIKEG<T> FEKCMALMKHK([Out] HashSet<T> DMNGPNKHPKF)
	{
		return default(JGCKPLEIKEG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct JGCKPLEIKEG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> KEHLKEICKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FJMMOCJCFKP FADKPDGOGKN;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x21B8E30", Offset = "0x21B7430", VA = "0x1821B8E30")]
	internal JGCKPLEIKEG(HashSet<T> DMNGPNKHPKF, FJMMOCJCFKP FFFMCNFHFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3E6A8E0", Offset = "0x3E68EE0", VA = "0x183E6A8E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct GCMNHCCNJPJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OAGIFJLCPFO JCFIABPDFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> KEHLKEICKEB;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9220", Offset = "0x3CF7820", VA = "0x183CF9220")]
	public static GCMNHCCNJPJ<T> ENFOKLPNHAF(string CAMDIODFJJE)
	{
		return default(GCMNHCCNJPJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9400", Offset = "0x3CF7A00", VA = "0x183CF9400")]
	internal GCMNHCCNJPJ(Stack<T> DMNGPNKHPKF, OAGIFJLCPFO DKDKLKDHPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3CF9350", Offset = "0x3CF7950", VA = "0x183CF9350")]
	public CMFKNEFDEFM<T> FEKCMALMKHK([Out] Stack<T> DMNGPNKHPKF)
	{
		return default(CMFKNEFDEFM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct CMFKNEFDEFM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> KEHLKEICKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FJMMOCJCFKP FADKPDGOGKN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21B8E30", Offset = "0x21B7430", VA = "0x1821B8E30")]
	internal CMFKNEFDEFM(Stack<T> DMNGPNKHPKF, FJMMOCJCFKP FFFMCNFHFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E6A8E0", Offset = "0x3E68EE0", VA = "0x183E6A8E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public sealed class KFAPHNLJDLJ<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct DFLNKDIOEHP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly KFAPHNLJDLJ<T> HCHBBIIKJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int LFIHIBKBENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool ANENCDOHJIB;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1EE6570", Offset = "0x1EE4B70", VA = "0x181EE6570")]
		public DFLNKDIOEHP(KFAPHNLJDLJ<T> AKLCDEBLEOF, int KLLBEGANAML, bool LICBJIFCJIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x58C3BF0", Offset = "0x58C21F0", VA = "0x1858C3BF0")]
		public KFAPHNLJDLJ<T>.LOHGPGDDCLP GGGADAADMEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x58C3CF0", Offset = "0x58C22F0", VA = "0x1858C3CF0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x58C3CF0", Offset = "0x58C22F0", VA = "0x1858C3CF0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class LOHGPGDDCLP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly KFAPHNLJDLJ<T> HCHBBIIKJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int HKDCGCMHAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int KJMLFICDFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool ANENCDOHJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool OFEGCIANLIP;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x42ECFC0", Offset = "0x42EB5C0", VA = "0x1842ECFC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x42ED140", Offset = "0x42EB740", VA = "0x1842ED140", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x42ED310", Offset = "0x42EB910", VA = "0x1842ED310", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x42ED910", Offset = "0x42EBF10", VA = "0x1842ED910")]
		public LOHGPGDDCLP(KFAPHNLJDLJ<T> AKLCDEBLEOF, int KLLBEGANAML, bool LICBJIFCJIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x42ED080", Offset = "0x42EB680", VA = "0x1842ED080", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x42ED120", Offset = "0x42EB720", VA = "0x1842ED120", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class GNHONEEBDIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public GNHONEEBDIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D38A40", Offset = "0x3D37040", VA = "0x183D38A40")]
		internal T HJPMHDMMJFA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] ABALBGPOAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int KJMLFICDFAM;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int BOLNGFHDMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x416F9C0", Offset = "0x416DFC0", VA = "0x18416F9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T FOBIFFPGMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2FC0", Offset = "0x3BF15C0", VA = "0x183BF2FC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OCFJFMFNEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x416FD50", Offset = "0x416E350", VA = "0x18416FD50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x416FB90", Offset = "0x416E190", VA = "0x18416FB90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1974230", Offset = "0x1972830", VA = "0x181974230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x11A2C40", Offset = "0x11A1240", VA = "0x1811A2C40")]
	private static int MDPJBLEKEKH(int PDMMEDBMFPP, int JOCLJBACIHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4170000", Offset = "0x416E600", VA = "0x184170000")]
	public KFAPHNLJDLJ(int LPKLLJKOBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x416FD90", Offset = "0x416E390", VA = "0x18416FD90")]
	public KFAPHNLJDLJ(int LPKLLJKOBNO, Func<T> OOGOFBKKJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4170310", Offset = "0x416E910", VA = "0x184170310")]
	public KFAPHNLJDLJ(T[] DOCJELGKFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x416F990", Offset = "0x416DF90", VA = "0x18416F990")]
	public void FKJIKMOCNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x416FAC0", Offset = "0x416E0C0", VA = "0x18416FAC0")]
	public IEnumerable<T> MCDOICLKOJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x416FA20", Offset = "0x416E020", VA = "0x18416FA20")]
	public KFAPHNLJDLJ<T>.LOHGPGDDCLP GGGADAADMEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3C4E8F0", Offset = "0x3C4CEF0", VA = "0x183C4E8F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3C4E8F0", Offset = "0x3C4CEF0", VA = "0x183C4E8F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CIFFLBOACKM
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x29A6840", Offset = "0x29A4E40", VA = "0x1829A6840")]
	public static KFAPHNLJDLJ<T> ENFOKLPNHAF<T>(int LPKLLJKOBNO, Func<T> OOGOFBKKJJJ) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC1F0", Offset = "0x1FEA7F0", VA = "0x181FEC1F0")]
		public RRColor(float JPKMILJIBCP, float CMKCFKJEIAD, float CGBLKAAFCDI, float KHKPJFABMKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEBA0", Offset = "0x6ADD1A0", VA = "0x186ADEBA0", Slot = "4")]
		public bool Equals(RRColor BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEC20", Offset = "0x6ADD220", VA = "0x186ADEC20", Slot = "0")]
		public override bool Equals(object BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6ADED20", Offset = "0x6ADD320", VA = "0x186ADED20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEDA0", Offset = "0x6ADD3A0", VA = "0x186ADEDA0", Slot = "5")]
		public string ToString(string MLEOMJOOIIP, IFormatProvider GODIKAAPFEJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class OGIJJMHDBCD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct INEMFIFCMDM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly OGIJJMHDBCD<T> KFMOHHBJFIL;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T FJLALGMPANI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3E89330", Offset = "0x3E87930", VA = "0x183E89330")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3E89300", Offset = "0x3E87900", VA = "0x183E89300", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
		public INEMFIFCMDM(OGIJJMHDBCD<T> KFMOHHBJFIL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GPLJJDJPNNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<INEMFIFCMDM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public OGIJJMHDBCD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D459A0", Offset = "0x3D43FA0", VA = "0x183D459A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D09B40", Offset = "0x3D08140", VA = "0x183D09B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly SemaphoreSlim DCKABPIILEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private T MCJNLHJBMKC;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x46D5B10", Offset = "0x46D4110", VA = "0x1846D5B10")]
	public OGIJJMHDBCD([In] T MCJNLHJBMKC, int FHFPDEFIGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x46D5AD0", Offset = "0x46D40D0", VA = "0x1846D5AD0")]
	public OGIJJMHDBCD([In] T MCJNLHJBMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x46D5570", Offset = "0x46D3B70", VA = "0x1846D5570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x46D5A70", Offset = "0x46D4070", VA = "0x1846D5A70")]
	public INEMFIFCMDM INOFMFNILGA()
	{
		return default(INEMFIFCMDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x46D55B0", Offset = "0x46D3BB0", VA = "0x1846D55B0")]
	[AsyncStateMachine(typeof(OGIJJMHDBCD<>.GPLJJDJPNNG))]
	public Task<OGIJJMHDBCD<T>.INEMFIFCMDM> FICBPOGLGMN(CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x46D5AB0", Offset = "0x46D40B0", VA = "0x1846D5AB0")]
	public void KBEDHFMHCEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AGMBHIMNHDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6ADA830", Offset = "0x6AD8E30", VA = "0x186ADA830")]
	public static OGIJJMHDBCD<COKMANPFJNC> ENFOKLPNHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4740", Offset = "0x2BA2D40", VA = "0x182BA4740")]
	public static OGIJJMHDBCD<T> ENFOKLPNHAF<T>([In] T MCJNLHJBMKC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class NNMMAMCHLMO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct EDPLGECHKEM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly NNMMAMCHLMO<T> MCBAIBOPHBI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T FJLALGMPANI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x385B740", Offset = "0x3859D40", VA = "0x18385B740")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x385B620", Offset = "0x3859C20", VA = "0x18385B620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
		internal EDPLGECHKEM(NNMMAMCHLMO<T> KFMOHHBJFIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct FIPPMBBAJPK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly NNMMAMCHLMO<T> MCBAIBOPHBI;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T FJLALGMPANI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x385B740", Offset = "0x3859D40", VA = "0x18385B740")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FE30", Offset = "0x3C1E430", VA = "0x183C1FE30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
		internal FIPPMBBAJPK(NNMMAMCHLMO<T> KFMOHHBJFIL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BFMKPAIHNDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<FIPPMBBAJPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public NNMMAMCHLMO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private OGIJJMHDBCD<COKMANPFJNC>.INEMFIFCMDM <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter<OGIJJMHDBCD<COKMANPFJNC>.INEMFIFCMDM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4ECA660", Offset = "0x4EC8C60", VA = "0x184ECA660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D09B40", Offset = "0x3D08140", VA = "0x183D09B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly OGIJJMHDBCD<int> AOMECFKMCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly OGIJJMHDBCD<COKMANPFJNC> BLJEMCKOONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly OGIJJMHDBCD<COKMANPFJNC> GIPNOJNHCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private T DKAKEMDLEDL;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x45DCF80", Offset = "0x45DB580", VA = "0x1845DCF80")]
	internal NNMMAMCHLMO(OGIJJMHDBCD<int> FIBADGEHJCP, OGIJJMHDBCD<COKMANPFJNC> EJMFEAHLKJB, OGIJJMHDBCD<COKMANPFJNC> GCKGNPIBDHD, [In] T MCJNLHJBMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x45DC790", Offset = "0x45DAD90", VA = "0x1845DC790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x45DC310", Offset = "0x45DA910", VA = "0x1845DC310")]
	public EDPLGECHKEM BBNLCCNAPGE()
	{
		return default(EDPLGECHKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x45DC810", Offset = "0x45DAE10", VA = "0x1845DC810")]
	public FIPPMBBAJPK GDIEAOLABBA()
	{
		return default(FIPPMBBAJPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x45DCAE0", Offset = "0x45DB0E0", VA = "0x1845DCAE0")]
	[AsyncStateMachine(typeof(NNMMAMCHLMO<>.BFMKPAIHNDK))]
	public Task<NNMMAMCHLMO<T>.FIPPMBBAJPK> LPFCJOFADGB(CancellationToken FIMAIPEFOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IMDFEJFMCMM
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC470", Offset = "0x6ADAA70", VA = "0x186ADC470")]
	public static NNMMAMCHLMO<COKMANPFJNC> ENFOKLPNHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE3B0", Offset = "0x2BDC9B0", VA = "0x182BDE3B0")]
	public static NNMMAMCHLMO<T> ENFOKLPNHAF<T>([In] T MCJNLHJBMKC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class MMCMEEHMPDE<TData> : PJDAENIABGC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly string NGFLOAALGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly TData GDPGJFHLHOH;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
	public override string AFLHKEIDPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x44EE820", Offset = "0x44ECE20", VA = "0x1844EE820")]
	internal MMCMEEHMPDE(string ELIMFPDKMPD, [In] TData MMDLBEBNCGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class COAKGGFEIHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6ADAEF0", Offset = "0x6AD94F0", VA = "0x186ADAEF0")]
	public static MMCMEEHMPDE<COKMANPFJNC> ENFOKLPNHAF(string ELIMFPDKMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x29A5D90", Offset = "0x29A4390", VA = "0x1829A5D90")]
	public static MMCMEEHMPDE<TData> ENFOKLPNHAF<TData>(string ELIMFPDKMPD, [In] TData MMDLBEBNCGC) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class OAGIFJLCPFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal bool DFOHHNACNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly string EGOHMPLAOOK;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x10BE920", Offset = "0x10BCF20", VA = "0x1810BE920")]
	private OAGIFJLCPFO(bool HMBECIGAMDK, string KPIKBPNAMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD6C0", Offset = "0x6ADBCC0", VA = "0x186ADD6C0")]
	public static OAGIFJLCPFO ENFOKLPNHAF(string KPIKBPNAMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD730", Offset = "0x6ADBD30", VA = "0x186ADD730")]
	public FJMMOCJCFKP FEKCMALMKHK()
	{
		return default(FJMMOCJCFKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct FJMMOCJCFKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly OAGIFJLCPFO LFMBKIJPMOO;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	internal FJMMOCJCFKP(OAGIFJLCPFO CAMDIODFJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC160", Offset = "0x6ADA760", VA = "0x186ADC160", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class IENBDCHMCMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Dictionary<object, float> CJCKCFPDODL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public float DDHOEOODDLB
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8F7710", Offset = "0x8F5D10", VA = "0x1808F7710")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xF0A2A0", Offset = "0xF088A0", VA = "0x180F0A2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC370", Offset = "0x6ADA970", VA = "0x186ADC370")]
	public void IOOGOHAPAFI(float DMNGPNKHPKF, object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC300", Offset = "0x6ADA900", VA = "0x186ADC300")]
	public void IKNHMJKPFOG(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC180", Offset = "0x6ADA780", VA = "0x186ADC180")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC1D0", Offset = "0x6ADA7D0", VA = "0x186ADC1D0")]
	private void FDFDHFMOGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC3E0", Offset = "0x6ADA9E0", VA = "0x186ADC3E0")]
	public IENBDCHMCMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class PLBODCOJINB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class FLDBEMCEILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public FLDBEMCEILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3C383E0", Offset = "0x3C369E0", VA = "0x183C383E0")]
		internal int NAPEILNGKME(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HashSet<T>? ICLOBPELGON;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<T> POJCIOFLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x47FB500", Offset = "0x47F9B00", VA = "0x1847FB500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool MOLFLJABKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x47FB240", Offset = "0x47F9840", VA = "0x1847FB240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x86E8E0", Offset = "0x86CEE0", VA = "0x18086E8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x47FB590", Offset = "0x47F9B90", VA = "0x1847FB590")]
	public bool LHEPNGLDBLI(T NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x47FB380", Offset = "0x47F9980", VA = "0x1847FB380")]
	public bool HHOKGKJNBNI(T NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x47FB540", Offset = "0x47F9B40", VA = "0x1847FB540")]
	public bool LGJHGFMDMBF(T NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x47FB290", Offset = "0x47F9890", VA = "0x1847FB290")]
	public void HEMGOFLIFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x47FB770", Offset = "0x47F9D70", VA = "0x1847FB770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public PLBODCOJINB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class OHJDFEOJOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string HMHGKKJFGKA;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public OHJDFEOJOEJ(string HMHGKKJFGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDAD0", Offset = "0x6ADC0D0", VA = "0x186ADDAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class NJLEKBCHGOF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class JMCNNICNJNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public JMCNNICNJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC540", Offset = "0x6ADAB40", VA = "0x186ADC540")]
		internal int NAPEILNGKME(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private HashSet<object>? ICLOBPELGON;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IReadOnlyCollection<object> POJCIOFLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD2C0", Offset = "0x6ADB8C0", VA = "0x186ADD2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MOLFLJABKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD1A0", Offset = "0x6ADB7A0", VA = "0x186ADD1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86E8E0", Offset = "0x86CEE0", VA = "0x18086E8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD3B0", Offset = "0x6ADB9B0", VA = "0x186ADD3B0")]
	public bool LHEPNGLDBLI(object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD220", Offset = "0x6ADB820", VA = "0x186ADD220")]
	public bool HHOKGKJNBNI(object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD350", Offset = "0x6ADB950", VA = "0x186ADD350")]
	public bool LGJHGFMDMBF(object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD1B0", Offset = "0x6ADB7B0", VA = "0x186ADD1B0")]
	public void HEMGOFLIFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD490", Offset = "0x6ADBA90", VA = "0x186ADD490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public NJLEKBCHGOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PGFMDEOJING<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct EAPBJPCMGMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float IJLDJCOHPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T FJLALGMPANI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<object, EAPBJPCMGMD> CJCKCFPDODL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public virtual T LJHEGEJCAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x10AFAF0", Offset = "0x10AE0F0", VA = "0x1810AFAF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x10AE4F0", Offset = "0x10ACAF0", VA = "0x1810AE4F0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public object? CLDCOONINHK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x868240", Offset = "0x866840", VA = "0x180868240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NPFGJKBBJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x47BA380", Offset = "0x47B8980", VA = "0x1847BA380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x47BA830", Offset = "0x47B8E30", VA = "0x1847BA830")]
	public bool IOOGOHAPAFI(T DMNGPNKHPKF, object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x47BA3E0", Offset = "0x47B89E0", VA = "0x1847BA3E0")]
	public bool IKNHMJKPFOG(object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3D14740", Offset = "0x3D12D40", VA = "0x183D14740")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x47BA130", Offset = "0x47B8730", VA = "0x1847BA130")]
	public bool APLEJEFPFAB(object NJLOKHEKBBE, [Out] T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x47BBB70", Offset = "0x47BA170", VA = "0x1847BBB70")]
	[FBDLONGKOCP("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JFKFHEKFKBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x47BC660", Offset = "0x47BAC60", VA = "0x1847BC660")]
	public PGFMDEOJING()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class GNOKBMKHHKC<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<WeakReference<T>>? ICLOBPELGON;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MOLFLJABKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A0E0", Offset = "0x3D386E0", VA = "0x183D3A0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3D39F30", Offset = "0x3D38530", VA = "0x183D39F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A410", Offset = "0x3D38A10", VA = "0x183D3A410")]
	public void LHEPNGLDBLI(T NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A260", Offset = "0x3D38860", VA = "0x183D3A260")]
	public void HHOKGKJNBNI(T NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A210", Offset = "0x3D38810", VA = "0x183D3A210")]
	public void HEMGOFLIFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A6A0", Offset = "0x3D38CA0", VA = "0x183D3A6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public GNOKBMKHHKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class HIOGHADANJC
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x29A71C0", Offset = "0x29A57C0", VA = "0x1829A71C0")]
	public static void BCLFMGIHKHF<T>(this List<T> DEPHDEBCNCK, int PDMMEDBMFPP) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface CLEMKPOOAHL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NDDAIDEMHOM ODNCOIHKCDF;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class KEJOIJGFDLC : CLEMKPOOAHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public readonly struct OANNLPGMNGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly float PNPOMLBEDFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly float CHPBHFGPOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal readonly bool IPGIKMPLLND;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float FPMEMCFLMNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD7F0", Offset = "0x6ADBDF0", VA = "0x186ADD7F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD970", Offset = "0x6ADBF70", VA = "0x186ADD970")]
		public OANNLPGMNGL(float IJNJPAGKLKM, float ENJFDDOBAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD800", Offset = "0x6ADBE00", VA = "0x186ADD800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class BOJKOBIMAJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KEJOIJGFDLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public BOJKOBIMAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAC20", Offset = "0x6AD9220", VA = "0x186ADAC20")]
		internal void PEDACPIKLOH(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly int PLGOIBDCNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int DPFJAAJAHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CLEMKPOOAHL[] NCHNJBOIFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NDDAIDEMHOM[] MBKGOLHFIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly OANNLPGMNGL[] AGBFPDEDMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private OANNLPGMNGL IMDFFNAMEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly CKHKKHOMICP HCDPOOGENAE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NDDAIDEMHOM ODNCOIHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC5F0", Offset = "0x6ADABF0", VA = "0x186ADC5F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC7C0", Offset = "0x6ADADC0", VA = "0x186ADC7C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCD90", Offset = "0x6ADB390", VA = "0x186ADCD90")]
	public KEJOIJGFDLC(int PLGOIBDCNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCD00", Offset = "0x6ADB300", VA = "0x186ADCD00")]
	public CKHKKHOMICP NFJILGMOHDA(OANNLPGMNGL HPMBFDPLEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC880", Offset = "0x6ADAE80", VA = "0x186ADC880")]
	public void MAIIDCDGBDO(CLEMKPOOAHL BPCBKJAFGFL, [Optional] OANNLPGMNGL PLHAFGBJIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC6B0", Offset = "0x6ADACB0", VA = "0x186ADC6B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate void NDDAIDEMHOM(float FHHCHGEBPAN);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class EKPEOLHMFJH
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class KPLGEIFMKIF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly CLEMKPOOAHL OIDLONJDKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly NDDAIDEMHOM JMMEJHGHOEF;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6ADCF70", Offset = "0x6ADB570", VA = "0x186ADCF70")]
		public KPLGEIFMKIF(CLEMKPOOAHL OIDLONJDKNJ, NDDAIDEMHOM JMMEJHGHOEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6ADCF20", Offset = "0x6ADB520", VA = "0x186ADCF20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC030", Offset = "0x6ADA630", VA = "0x186ADC030")]
	internal static bool EEHLMAIKEOM(float KHKPJFABMKM, float CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA870", Offset = "0x6AC8E70", VA = "0x186ACA870")]
	internal static float AMANLCEKKGK(float KHKPJFABMKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC0A0", Offset = "0x6ADA6A0", VA = "0x186ADC0A0")]
	public static IDisposable IEBBPDMPKEN(this CLEMKPOOAHL OIDLONJDKNJ, NDDAIDEMHOM JMMEJHGHOEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class CKHKKHOMICP : CLEMKPOOAHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private float FHHCHGEBPAN;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float AJADKAOPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAD60", Offset = "0x6AD9360", VA = "0x186ADAD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NDDAIDEMHOM? ODNCOIHKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6ADACC0", Offset = "0x6AD92C0", VA = "0x186ADACC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAE50", Offset = "0x6AD9450", VA = "0x186ADAE50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public CKHKKHOMICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface DGAMKKPGEIM<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GAHMJGHMOCD<T> MFHJCEBKALF([Out] T DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMCFOMNOLLC();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class HEHCKHOCNCE<T> : DGAMKKPGEIM<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly ConcurrentStack<T> JPPHNJAEDDK;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3D97FF0", Offset = "0x3D965F0", VA = "0x183D97FF0", Slot = "4")]
	public GAHMJGHMOCD<T> MFHJCEBKALF([Out] T DMNGPNKHPKF)
	{
		return default(GAHMJGHMOCD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3D97EC0", Offset = "0x3D964C0", VA = "0x183D97EC0")]
	public void EKHKOALGJHM(T NCODBLEIMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3D97E60", Offset = "0x3D96460", VA = "0x183D97E60", Slot = "5")]
	public void DMCFOMNOLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "6")]
	protected virtual void LKLCIFGECMJ(T NMHDDFKBPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3D97F40", Offset = "0x3D96540", VA = "0x183D97F40")]
	private T FOHHCFMHKPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3D98090", Offset = "0x3D96690", VA = "0x183D98090")]
	public HEHCKHOCNCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct GAHMJGHMOCD<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly T NCODBLEIMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly HEHCKHOCNCE<T> BABPFPJMACP;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	internal GAHMJGHMOCD(T DMNGPNKHPKF, HEHCKHOCNCE<T> BABPFPJMACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3EB0", Offset = "0x3CF24B0", VA = "0x183CF3EB0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class MKKOKPABHJI : HEHCKHOCNCE<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly MKKOKPABHJI CFNNMJAMDBB;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD000", Offset = "0x6ADB600", VA = "0x186ADD000")]
	public static GAHMJGHMOCD<StringBuilder> FOHHCFMHKPE([Out] StringBuilder DMNGPNKHPKF)
	{
		return default(GAHMJGHMOCD<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD0A0", Offset = "0x6ADB6A0", VA = "0x186ADD0A0", Slot = "6")]
	protected override void LKLCIFGECMJ(StringBuilder NMHDDFKBPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD160", Offset = "0x6ADB760", VA = "0x186ADD160")]
	public MKKOKPABHJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JOOGCAFEFJD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6542200", Offset = "0x6540800", VA = "0x186542200")]
	public JOOGCAFEFJD(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class KJFCDGAAEML<TKey, TValue> : JNJEAPNEABD<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, LOIELKENBIG where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GPBABDHKDGH : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public KJFCDGAAEML<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x10AFAF0", Offset = "0x10AE0F0", VA = "0x1810AFAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C2C0", Offset = "0x3D3A8C0", VA = "0x183D3C2C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public GPBABDHKDGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x39A6180", Offset = "0x39A4780", VA = "0x1839A6180", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B660", Offset = "0x3D39C60", VA = "0x183D3B660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B610", Offset = "0x3D39C10", VA = "0x183D3B610")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B4D0", Offset = "0x3D39AD0", VA = "0x183D3B4D0")]
		private void DLKKNIILKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C220", Offset = "0x3D3A820", VA = "0x183D3C220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JNJEAPNEABD<TKey, TValue> CBCIFHIAPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly IDictionary<TKey, TValue> MGEILODOBPO;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x41BBB10", Offset = "0x41BA110", VA = "0x1841BBB10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IJMBFBLHEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public TValue CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x41BBC20", Offset = "0x41BA220", VA = "0x1841BBC20", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x41BBED0", Offset = "0x41BA4D0", VA = "0x1841BBED0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ICollection<TKey> MHEOEAKGEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x41BBC70", Offset = "0x41BA270", VA = "0x1841BBC70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ICollection<TValue> ONHPNGNLGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x41BBDA0", Offset = "0x41BA3A0", VA = "0x1841BBDA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x41BB8A0", Offset = "0x41B9EA0", VA = "0x1841BB8A0")]
	public KJFCDGAAEML(JNJEAPNEABD<TKey, TValue> CBCIFHIAPMC, [Optional] IDictionary<TKey, TValue>? MGEILODOBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x41B90E0", Offset = "0x41B76E0", VA = "0x1841B90E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x41BABF0", Offset = "0x41B91F0", VA = "0x1841BABF0")]
	public void PJMBBDEKAKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x41B8AF0", Offset = "0x41B70F0", VA = "0x1841B8AF0", Slot = "9")]
	public void Add(TKey IBBDLGCDELM, TValue DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x41B99E0", Offset = "0x41B7FE0", VA = "0x1841B99E0")]
	public void DPBAEDPAONK(TKey IBBDLGCDELM, TValue DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x41B9FC0", Offset = "0x41B85C0", VA = "0x1841B9FC0")]
	public void HNBIGNDICOJ(TKey IBBDLGCDELM, TValue DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x41BA170", Offset = "0x41B8770", VA = "0x1841BA170")]
	public void JABOFHEFHIJ(TKey IBBDLGCDELM, TValue DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x41BAA00", Offset = "0x41B9000", VA = "0x1841BAA00")]
	public void PIBFMIPCGNI(TKey IBBDLGCDELM, TValue DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x41BAF00", Offset = "0x41B9500", VA = "0x1841BAF00", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x41BB0F0", Offset = "0x41B96F0", VA = "0x1841BB0F0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x41BB2B0", Offset = "0x41B98B0", VA = "0x1841BB2B0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x41B9170", Offset = "0x41B7770", VA = "0x1841B9170", Slot = "8")]
	public bool ContainsKey(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x41B9CC0", Offset = "0x41B82C0", VA = "0x1841B9CC0")]
	public bool FMKDDDKLCAF(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x41B9010", Offset = "0x41B7610", VA = "0x1841B9010")]
	public bool BHCGCJKLFCL(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x41BAC40", Offset = "0x41B9240", VA = "0x1841BAC40", Slot = "10")]
	public bool Remove(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x41BB6F0", Offset = "0x41B9CF0", VA = "0x1841BB6F0", Slot = "11")]
	public bool TryGetValue(TKey IBBDLGCDELM, [Out] TValue DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x41B92F0", Offset = "0x41B78F0", VA = "0x1841B92F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] FAJBEEIFFCK, int FLPMGGGFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x413D8D0", Offset = "0x413BED0", VA = "0x18413D8D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x41B9E40", Offset = "0x41B8440", VA = "0x1841B9E40", Slot = "19")]
	[IteratorStateMachine(typeof(KJFCDGAAEML<, >.GPBABDHKDGH))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x41BA680", Offset = "0x41B8C80", VA = "0x1841BA680", Slot = "21")]
	public bool JMMMIHDMHPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x41BA720", Offset = "0x41B8D20", VA = "0x1841BA720")]
	private TValue LJBDAMGFAFA(TKey IBBDLGCDELM)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface LOIELKENBIG
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMMMIHDMHPH();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface JNJEAPNEABD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LOIELKENBIG
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DefaultMember("Item")]
public sealed class GJMLKDCAFHK<TKey, TVal> : JNJEAPNEABD<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LOIELKENBIG where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate int NDPANOHFBGA(TKey IBBDLGCDELM, TVal DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void PLBFABMFGJA(TKey IBBDLGCDELM, TVal DMNGPNKHPKF, IBBMGNDOKJN GBNNAJEHACL);

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private class KPLANHGEHAK
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public TKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8FBA60", Offset = "0x8FA060", VA = "0x1808FBA60")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TVal FJLALGMPANI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8F0910", Offset = "0x8EEF10", VA = "0x1808F0910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int FPMEMCFLMNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8A5C50", Offset = "0x8A4250", VA = "0x1808A5C50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A5800", Offset = "0x8A3E00", VA = "0x1808A5800")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DateTimeOffset AKKMDMJMFMN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xC70660", Offset = "0xC6EC60", VA = "0x180C70660")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x15405F0", Offset = "0x153EBF0", VA = "0x1815405F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x42397E0", Offset = "0x4237DE0", VA = "0x1842397E0")]
		public KPLANHGEHAK(TKey IBBDLGCDELM, TVal KPJDKHEOHPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class PHDLJOMDFKB : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public GJMLKDCAFHK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private LinkedList<KPLANHGEHAK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x10AFAF0", Offset = "0x10AE0F0", VA = "0x1810AFAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3B021C0", Offset = "0x3B007C0", VA = "0x183B021C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public PHDLJOMDFKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38769E0", Offset = "0x3874FE0", VA = "0x1838769E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x47E79E0", Offset = "0x47E5FE0", VA = "0x1847E79E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x47E7330", Offset = "0x47E5930", VA = "0x1847E7330")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x47EA160", Offset = "0x47E8760", VA = "0x1847EA160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public const int IDKGKEPLKJO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Dictionary<TKey, LinkedListNode<KPLANHGEHAK>> NGAHDJCCKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly LinkedList<KPLANHGEHAK> DPKJFCPDPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly NDPANOHFBGA? LNDFGGMKGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly TimeSpan EOECAEKFLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly PLBFABMFGJA? DJODAPAMBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly AIHEAHBFNLA HCHEGMFJNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool DKPJLPHPEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<TKey> PKNFEMFBGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<TVal> FPAOAMOONJD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int LDAFFHKGGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8764A0", Offset = "0x874AA0", VA = "0x1808764A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int ECOHEDPAHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB3E5E0", Offset = "0xB3CBE0", VA = "0x180B3E5E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xB3E1F0", Offset = "0xB3C7F0", VA = "0x180B3E1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A620", Offset = "0x3D18C20", VA = "0x183D1A620", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal int NBPCKPLFPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3D14740", Offset = "0x3D12D40", VA = "0x183D14740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ICollection<TVal> ONHPNGNLGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A790", Offset = "0x3D18D90", VA = "0x183D1A790", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ICollection<TKey> IDictionary<TKey, TVal>.AGGJOCJFCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3D188B0", Offset = "0x3D16EB0", VA = "0x183D188B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IJMBFBLHEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TVal CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A6C0", Offset = "0x3D18CC0", VA = "0x183D1A6C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A7E0", Offset = "0x3D18DE0", VA = "0x183D1A7E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3D16690", Offset = "0x3D14C90", VA = "0x183D16690")]
	private bool KFGCFGFGACD(int PLGOIBDCNBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3D139E0", Offset = "0x3D11FE0", VA = "0x183D139E0")]
	private void EAIHNBHBNJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3D1A540", Offset = "0x3D18B40", VA = "0x183D1A540")]
	public GJMLKDCAFHK(int PLGOIBDCNBN, [Optional] NDPANOHFBGA? LNDFGGMKGIF, [Optional] IEqualityComparer<TKey>? IMHCCDPMLAI, [Optional] PLBFABMFGJA? DJODAPAMBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3D19920", Offset = "0x3D17F20", VA = "0x183D19920")]
	public GJMLKDCAFHK(TimeSpan EOECAEKFLCF, [Optional] IEqualityComparer<TKey>? IMHCCDPMLAI, [Optional] PLBFABMFGJA? DJODAPAMBKE, [Optional] AIHEAHBFNLA? HCHEGMFJNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3D18FA0", Offset = "0x3D175A0", VA = "0x183D18FA0")]
	public GJMLKDCAFHK(int PLGOIBDCNBN, TimeSpan EOECAEKFLCF, [Optional] IEqualityComparer<TKey>? IMHCCDPMLAI, [Optional] PLBFABMFGJA? DJODAPAMBKE, [Optional] AIHEAHBFNLA? HCHEGMFJNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3D19B60", Offset = "0x3D18160", VA = "0x183D19B60")]
	public GJMLKDCAFHK(int PLGOIBDCNBN, NDPANOHFBGA? LNDFGGMKGIF, TimeSpan EOECAEKFLCF, [Optional] IEqualityComparer<TKey>? IMHCCDPMLAI, [Optional] PLBFABMFGJA? DJODAPAMBKE, [Optional] AIHEAHBFNLA? HCHEGMFJNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3D165E0", Offset = "0x3D14BE0", VA = "0x183D165E0", Slot = "21")]
	public bool JMMMIHDMHPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3D12210", Offset = "0x3D10810", VA = "0x183D12210", Slot = "22")]
	public bool DKLNDEGPHIJ(int LPKLLJKOBNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3D166E0", Offset = "0x3D14CE0", VA = "0x183D166E0")]
	private bool PDCKCCDNPKH(int LPKLLJKOBNO, IBBMGNDOKJN GBNNAJEHACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3D14060", Offset = "0x3D12660", VA = "0x183D14060")]
	public void ECADPABFBJL(TKey IBBDLGCDELM, TVal DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FEA0", Offset = "0x3D0E4A0", VA = "0x183D0FEA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JAGONPFFNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3D10070", Offset = "0x3D0E670", VA = "0x183D10070", Slot = "9")]
	public void Add(TKey IBBDLGCDELM, TVal DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3D10B80", Offset = "0x3D0F180", VA = "0x183D10B80", Slot = "8")]
	public bool ContainsKey(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D18420", Offset = "0x3D16A20", VA = "0x183D18420", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D18220", Offset = "0x3D16820", VA = "0x183D18220", Slot = "10")]
	public bool Remove(TKey IBBDLGCDELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D18610", Offset = "0x3D16C10", VA = "0x183D18610", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> JAGONPFFNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D104B0", Offset = "0x3D0EAB0", VA = "0x183D104B0")]
	private bool BPDMKMHDOMH(TKey IBBDLGCDELM, [Out] TVal DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D142E0", Offset = "0x3D128E0", VA = "0x183D142E0")]
	private TVal FOHHCFMHKPE(TKey GJKHPDNCDMH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D18940", Offset = "0x3D16F40", VA = "0x183D18940", Slot = "11")]
	public bool TryGetValue(TKey GJKHPDNCDMH, [Out] TVal DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D10A50", Offset = "0x3D0F050", VA = "0x183D10A50", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D113D0", Offset = "0x3D0F9D0", VA = "0x183D113D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FAJBEEIFFCK, int FLPMGGGFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D11AB0", Offset = "0x3D100B0", VA = "0x183D11AB0")]
	private void DJFPHLILAIJ(TKey IBBDLGCDELM, TVal KPJDKHEOHPO, IBBMGNDOKJN GBNNAJEHACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D14C50", Offset = "0x3D13250", VA = "0x183D14C50")]
	private bool GICDCMLPNLN(KPLANHGEHAK DEEHALDBGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D12E60", Offset = "0x3D11460", VA = "0x183D12E60")]
	private void DNJLCDKPEND(LinkedListNode<KPLANHGEHAK> JIJFLAOBCMI, TVal PIMFKGJDDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D152C0", Offset = "0x3D138C0", VA = "0x183D152C0")]
	private void IOOGOHAPAFI(TKey IBBDLGCDELM, TVal DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D163C0", Offset = "0x3D149C0", VA = "0x183D163C0")]
	private void JMAICDPGOAF(KPLANHGEHAK DEEHALDBGHK, TVal PIMFKGJDDND, int LKKFDNJMGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D14DE0", Offset = "0x3D133E0", VA = "0x183D14DE0", Slot = "19")]
	[IteratorStateMachine(typeof(GJMLKDCAFHK<, >.PHDLJOMDFKB))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D18900", Offset = "0x3D16F00", VA = "0x183D18900", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum IBBMGNDOKJN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IGLLOCAIIJN<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly TKey GHEDKHCIGHA;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E6A460", Offset = "0x3E68A60", VA = "0x183E6A460")]
	public IGLLOCAIIJN(TKey OKMJMFANNHH, Exception INPOOCPJGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PJCLBAGMLNF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E197E0", Offset = "0x5E17DE0", VA = "0x185E197E0")]
	public PJCLBAGMLNF(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class JGOBKBHEPCF<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class KCOEEFILGLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public JGOBKBHEPCF<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public KCOEEFILGLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4169B90", Offset = "0x4168190", VA = "0x184169B90")]
		internal Task<TResource> HGCACDGLBBM(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct PMGCIFILDNF : IAsyncStateMachine
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
		public JGOBKBHEPCF<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x47FCCE0", Offset = "0x47FB2E0", VA = "0x1847FCCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x47FD0A0", Offset = "0x47FB6A0", VA = "0x1847FD0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct BBOMNGBOCHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4EBF8B0", Offset = "0x4EBDEB0", VA = "0x184EBF8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0050", Offset = "0x4EBE650", VA = "0x184EC0050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CMCEPEEOFLM<TId, Task<TResource>> HDACFPBEDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> FLPFCLGLOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? FLFGDNCKENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Action<TResource>? OGKODEFKJJE;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x40903D0", Offset = "0x408E9D0", VA = "0x1840903D0")]
	public JGOBKBHEPCF(int BHKHFILLELG = 0, [Optional] IEqualityComparer<TId>? MLJLDONNIEC, [Optional] Func<TId, CancellationToken, Task<TResource>>? JDEIOPOJELC, [Optional] Action<TResource>? LLMNHEPCMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x408FB30", Offset = "0x408E130", VA = "0x18408FB30")]
	public AHJCAINOMHJ<Task<TResource>> HHGBIKECPHP(TId DAIJJLLIENA, [Optional] Func<TId, CancellationToken, Task<TResource>>? JDEIOPOJELC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x408EC00", Offset = "0x408D200", VA = "0x18408EC00")]
	private void BJAMHFCKFPL(Task<TResource> NAFOIMCAMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x408F090", Offset = "0x408D690", VA = "0x18408F090")]
	[AsyncStateMachine(typeof(JGOBKBHEPCF<, >.PMGCIFILDNF))]
	private Task CLAJAEDKMDJ(Task<TResource> NAFOIMCAMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x408F390", Offset = "0x408D990", VA = "0x18408F390")]
	public void DHHJHOOFPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x408F470", Offset = "0x408DA70", VA = "0x18408F470")]
	public CMCEPEEOFLM<TId, Task<TResource>>.MAACJBFPHKE GGGADAADMEJ()
	{
		return default(CMCEPEEOFLM<TId, Task<TResource>>.MAACJBFPHKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x40901E0", Offset = "0x408E7E0", VA = "0x1840901E0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x40901E0", Offset = "0x408E7E0", VA = "0x1840901E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x408FE50", Offset = "0x408E450", VA = "0x18408FE50")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(JGOBKBHEPCF<, >.BBOMNGBOCHJ))]
	internal static Task HJFMDODNGFB(Task<TResource> NAFOIMCAMMG, CancellationTokenSource BCIAHHJBPFP, Dictionary<Task<TResource>, CancellationTokenSource> BBKAIBFKAJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class CMCEPEEOFLM<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class HCGDBFONAOC : IEquatable<HCGDBFONAOC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly TValue FJLALGMPANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int GNABJCGBHDI;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x99EDD0", Offset = "0x99D3D0", VA = "0x18099EDD0")]
		public HCGDBFONAOC(TValue DMNGPNKHPKF, int PCHLCEIEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EB10", Offset = "0x3D8D110", VA = "0x183D8EB10", Slot = "4")]
		public bool Equals(HCGDBFONAOC? BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EBA0", Offset = "0x3D8D1A0", VA = "0x183D8EBA0", Slot = "0")]
		public override bool Equals(object? NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D8ECE0", Offset = "0x3D8D2E0", VA = "0x183D8ECE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct MAACJBFPHKE : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<TKey, HCGDBFONAOC>.Enumerator AKPJOIODKJI;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x44AEBC0", Offset = "0x44AD1C0", VA = "0x1844AEBC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public (TKey Key, TValue Value, int RefCount) FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x44AF030", Offset = "0x44AD630", VA = "0x1844AF030", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x44AEF60", Offset = "0x44AD560", VA = "0x1844AEF60")]
		public MAACJBFPHKE(CMCEPEEOFLM<TKey, TValue> CJCKCFPDODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x44AE800", Offset = "0x44ACE00", VA = "0x1844AE800", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x44AE8C0", Offset = "0x44ACEC0", VA = "0x1844AE8C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x44AEB10", Offset = "0x44AD110", VA = "0x1844AEB10", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class NFEPCEBAEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CMCEPEEOFLM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public HCGDBFONAOC refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public NFEPCEBAEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4563CD0", Offset = "0x45622D0", VA = "0x184563CD0")]
		internal void HGCACDGLBBM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Dictionary<TKey, HCGDBFONAOC> IGHDDFAFJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Func<TKey, TValue>? NHLGHFJDEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Action<TValue>? OEJJCOPENGG;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x549B600", Offset = "0x5499C00", VA = "0x18549B600")]
	public CMCEPEEOFLM(int BHKHFILLELG = 0, [Optional] IEqualityComparer<TKey>? IMHCCDPMLAI, [Optional] Func<TKey, TValue>? MGOFDLIKLBP, [Optional] Action<TValue>? LJFGJMGONKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x549B0E0", Offset = "0x54996E0", VA = "0x18549B0E0")]
	public AHJCAINOMHJ<TValue> HHGBIKECPHP(TKey IBBDLGCDELM, [Optional] Func<TKey, TValue>? ALOEELALOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x549A2B0", Offset = "0x54988B0", VA = "0x18549A2B0")]
	private void EKHKOALGJHM(TKey IBBDLGCDELM, HCGDBFONAOC JONBFGAHMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5499C40", Offset = "0x5498240", VA = "0x185499C40")]
	public void DHHJHOOFPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x549A6C0", Offset = "0x5498CC0", VA = "0x18549A6C0")]
	public MAACJBFPHKE GGGADAADMEJ()
	{
		return default(MAACJBFPHKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x549B410", Offset = "0x5499A10", VA = "0x18549B410", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x549B410", Offset = "0x5499A10", VA = "0x18549B410", Slot = "5")]
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
