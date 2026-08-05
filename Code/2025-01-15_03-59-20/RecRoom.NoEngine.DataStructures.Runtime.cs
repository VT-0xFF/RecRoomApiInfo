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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70F8D90", Offset = "0x70F8190", VA = "0x1870F8D90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CHOCNBPPBOM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected CHOCNBPPBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OBGLNLGJDME<T> : CHOCNBPPBOM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct CINIMAHHJDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum MPGADOMONIN
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
		public MPGADOMONIN IFBDJLKPHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T OLHFOBIBHCJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int OPKKBHMNDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool FPMNCCFCDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KIEGAGKBCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? EDPEGDNFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CINIMAHHJDM>? MCLLBIKOJDG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FCJJGGPFCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B7AD10", Offset = "0x4B7A110", VA = "0x184B7AD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B7B0", Offset = "0x4B7ABB0", VA = "0x184B7B7B0")]
	protected OBGLNLGJDME(bool KIEGAGKBCNB, bool FPMNCCFCDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B5E0", Offset = "0x4B7A9E0", VA = "0x184B7B5E0")]
	protected bool HGJAPEKOKNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B680", Offset = "0x4B7AA80", VA = "0x184B7B680")]
	protected void HMJJPHEEPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B340", Offset = "0x4B7A740", VA = "0x184B7B340")]
	protected void EEFDHKFKFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x32D8D70", Offset = "0x32D8170", VA = "0x1832D8D70")]
	private static void JACKPGECPLN<U>(List<U>? CECMFLAILAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B120", Offset = "0x4B7A520", VA = "0x184B7B120", Slot = "4")]
	public void EBDKDKCDLND(T OLHFOBIBHCJ, bool GAFNEDIMFGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AD80", Offset = "0x4B7A180", VA = "0x184B7AD80", Slot = "5")]
	public void BDKJEBALGLD(T OLHFOBIBHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7AF60", Offset = "0x4B7A360", VA = "0x184B7AF60")]
	public void CDMKLDGEKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MIPKPFFHABJ : OBGLNLGJDME<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70F89D0", Offset = "0x70F7DD0", VA = "0x1870F89D0")]
	public MIPKPFFHABJ(bool KIEGAGKBCNB = false, bool FPMNCCFCDAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70F8770", Offset = "0x70F7B70", VA = "0x1870F8770")]
	public void CAHJKFNDGBI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70F8970", Offset = "0x70F7D70", VA = "0x1870F8970")]
	public static MIPKPFFHABJ DMLGBCNJJBA(MIPKPFFHABJ DINADCIIEJA, Action OLHFOBIBHCJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70F8710", Offset = "0x70F7B10", VA = "0x1870F8710")]
	public static MIPKPFFHABJ AGOHDCADFNP(MIPKPFFHABJ DINADCIIEJA, Action OLHFOBIBHCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NDJAOIDIEAL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBDKDKCDLND(Action<T> OLHFOBIBHCJ, bool GAFNEDIMFGN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDKJEBALGLD(Action<T> OLHFOBIBHCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FABEAAEBPBG<T> : OBGLNLGJDME<Action<T>>, NDJAOIDIEAL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C80330", Offset = "0x3C7F730", VA = "0x183C80330")]
	public FABEAAEBPBG(bool KIEGAGKBCNB = false, bool FPMNCCFCDAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x404C7C0", Offset = "0x404BBC0", VA = "0x18404C7C0")]
	public void CAHJKFNDGBI(T OPGNNMINDKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C80280", Offset = "0x3C7F680", VA = "0x183C80280")]
	public static FABEAAEBPBG<T> DMLGBCNJJBA(FABEAAEBPBG<T> DINADCIIEJA, Action<T> OLHFOBIBHCJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C4F0", Offset = "0x3C7B8F0", VA = "0x183C7C4F0")]
	public static FABEAAEBPBG<T> AGOHDCADFNP(FABEAAEBPBG<T> DINADCIIEJA, Action<T> OLHFOBIBHCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FJFFIGBALIK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class ECDLJKHIKLK<T, U> : OBGLNLGJDME<Action<T, U>>, FJFFIGBALIK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C80330", Offset = "0x3C7F730", VA = "0x183C80330")]
	public ECDLJKHIKLK(bool KIEGAGKBCNB = false, bool FPMNCCFCDAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C7FF60", Offset = "0x3C7F360", VA = "0x183C7FF60")]
	public void CAHJKFNDGBI(T OPGNNMINDKO, U EIMJLIHEHPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C80280", Offset = "0x3C7F680", VA = "0x183C80280")]
	public static ECDLJKHIKLK<T, U> DMLGBCNJJBA(ECDLJKHIKLK<T, U> DINADCIIEJA, Action<T, U> OLHFOBIBHCJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C4F0", Offset = "0x3C7B8F0", VA = "0x183C7C4F0")]
	public static ECDLJKHIKLK<T, U> AGOHDCADFNP(ECDLJKHIKLK<T, U> DINADCIIEJA, Action<T, U> OLHFOBIBHCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MACPLFCKHIA<T, U, V> : OBGLNLGJDME<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C80330", Offset = "0x3C7F730", VA = "0x183C80330")]
	public MACPLFCKHIA(bool KIEGAGKBCNB = false, bool FPMNCCFCDAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x49B5C80", Offset = "0x49B5080", VA = "0x1849B5C80")]
	public void CAHJKFNDGBI(T OPGNNMINDKO, U EIMJLIHEHPO, V LLKDJGHBOID)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C80280", Offset = "0x3C7F680", VA = "0x183C80280")]
	public static MACPLFCKHIA<T, U, V> DMLGBCNJJBA(MACPLFCKHIA<T, U, V> DINADCIIEJA, Action<T, U, V> OLHFOBIBHCJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C4F0", Offset = "0x3C7B8F0", VA = "0x183C7C4F0")]
	public static MACPLFCKHIA<T, U, V> AGOHDCADFNP(MACPLFCKHIA<T, U, V> DINADCIIEJA, Action<T, U, V> OLHFOBIBHCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LOOBKKJGNDG<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class PMLEJLGJAGG<T, U, V, W> : OBGLNLGJDME<Action<T, U, V, W>>, LOOBKKJGNDG<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C80330", Offset = "0x3C7F730", VA = "0x183C80330")]
	public PMLEJLGJAGG(bool KIEGAGKBCNB = false, bool FPMNCCFCDAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4CAE520", Offset = "0x4CAD920", VA = "0x184CAE520")]
	public void CAHJKFNDGBI(T OPGNNMINDKO, U EIMJLIHEHPO, V LLKDJGHBOID, W MLOFEILNACF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3C80280", Offset = "0x3C7F680", VA = "0x183C80280")]
	public static PMLEJLGJAGG<T, U, V, W> DMLGBCNJJBA(PMLEJLGJAGG<T, U, V, W> DINADCIIEJA, Action<T, U, V, W> OLHFOBIBHCJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C4F0", Offset = "0x3C7B8F0", VA = "0x183C7C4F0")]
	public static PMLEJLGJAGG<T, U, V, W> AGOHDCADFNP(PMLEJLGJAGG<T, U, V, W> DINADCIIEJA, Action<T, U, V, W> OLHFOBIBHCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JBJPJEJAAKK<T, U, V, W, X> : OBGLNLGJDME<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C80330", Offset = "0x3C7F730", VA = "0x183C80330")]
	public JBJPJEJAAKK(bool KIEGAGKBCNB = false, bool FPMNCCFCDAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4572390", Offset = "0x4571790", VA = "0x184572390")]
	public void CAHJKFNDGBI(T OPGNNMINDKO, U EIMJLIHEHPO, V LLKDJGHBOID, W MLOFEILNACF, X KENGFOGLPKI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C80280", Offset = "0x3C7F680", VA = "0x183C80280")]
	public static JBJPJEJAAKK<T, U, V, W, X> DMLGBCNJJBA(JBJPJEJAAKK<T, U, V, W, X> DINADCIIEJA, Action<T, U, V, W, X> OLHFOBIBHCJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C4F0", Offset = "0x3C7B8F0", VA = "0x183C7C4F0")]
	public static JBJPJEJAAKK<T, U, V, W, X> AGOHDCADFNP(JBJPJEJAAKK<T, U, V, W, X> DINADCIIEJA, Action<T, U, V, W, X> OLHFOBIBHCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class PCEFBGFANMH<T, U, V, W, X, Y> : OBGLNLGJDME<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C80330", Offset = "0x3C7F730", VA = "0x183C80330")]
	public PCEFBGFANMH(bool KIEGAGKBCNB = false, bool FPMNCCFCDAK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4C57DC0", Offset = "0x4C571C0", VA = "0x184C57DC0")]
	public void CAHJKFNDGBI(T OPGNNMINDKO, U EIMJLIHEHPO, V LLKDJGHBOID, W MLOFEILNACF, X KENGFOGLPKI, Y IFGPABAHODO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C80280", Offset = "0x3C7F680", VA = "0x183C80280")]
	public static PCEFBGFANMH<T, U, V, W, X, Y> DMLGBCNJJBA(PCEFBGFANMH<T, U, V, W, X, Y> DINADCIIEJA, Action<T, U, V, W, X, Y> OLHFOBIBHCJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C4F0", Offset = "0x3C7B8F0", VA = "0x183C7C4F0")]
	public static PCEFBGFANMH<T, U, V, W, X, Y> AGOHDCADFNP(PCEFBGFANMH<T, U, V, W, X, Y> DINADCIIEJA, Action<T, U, V, W, X, Y> OLHFOBIBHCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JDKDOACAFKD<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KHPJJBFPLGK<TKey, TVal> PNCGKJFJIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BAHMKKGKBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KHPJJBFPLGK<TKey, TVal>.PCEODJNFLFC? EBLELOPEDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int DLAJCNLEBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KHPJJBFPLGK<TKey, TVal>.MGHPKBNJLDG? KHDIJDKEJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int PGINJDKALBL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int HJFDOBNMJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x457A160", Offset = "0x4579560", VA = "0x18457A160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DLIFFIGOOBE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C50", Offset = "0x8C8050", VA = "0x1808C8C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x457B3C0", Offset = "0x457A7C0", VA = "0x18457B3C0")]
	public JDKDOACAFKD(int DLAJCNLEBKG, [Optional] KHPJJBFPLGK<TKey, TVal>.MGHPKBNJLDG? KHDIJDKEJNF, [Optional] IEqualityComparer<TKey>? NACDEAONMGC, [Optional] KHPJJBFPLGK<TKey, TVal>.PCEODJNFLFC? EBLELOPEDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x457ABD0", Offset = "0x4579FD0", VA = "0x18457ABD0")]
	public void NLBBDJHOGCK(TKey LDCKBFKFIKC, TVal HCPAOILCJCB, bool HENEFLEGMPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4579FF0", Offset = "0x45793F0", VA = "0x184579FF0")]
	public bool BAHBLNBHPID(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x457AAD0", Offset = "0x4579ED0", VA = "0x18457AAD0")]
	public bool LINPJOCPLAE(TKey LKMCKCKNIPH, [Out] TVal HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x457A270", Offset = "0x4579670", VA = "0x18457A270")]
	private void IKBCNMDGKKB(TKey LDCKBFKFIKC, TVal HCPAOILCJCB, int BGDDCGNLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x457A900", Offset = "0x4579D00", VA = "0x18457A900")]
	public bool KKEPHINBPKF(TKey LDCKBFKFIKC, TVal HCPAOILCJCB, bool HENEFLEGMPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x457A1C0", Offset = "0x45795C0", VA = "0x18457A1C0")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x457AE20", Offset = "0x457A220", VA = "0x18457AE20")]
	private void PEGEELFFKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x457A7B0", Offset = "0x4579BB0", VA = "0x18457A7B0")]
	private bool KKAHGKFBBED(TKey LDCKBFKFIKC, ICHGLMJLOAP OCIFOIBHPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x457A680", Offset = "0x4579A80", VA = "0x18457A680")]
	private void KIBBHHOCFKP(TKey LDCKBFKFIKC, TVal HCPAOILCJCB, ICHGLMJLOAP OCIFOIBHPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x457A550", Offset = "0x4579950", VA = "0x18457A550")]
	private void JCFMJPJCBLC(TKey LDCKBFKFIKC, TVal BBFFJMPBBGO, ICHGLMJLOAP OCIFOIBHPJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LBJIHLHHHJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action IEHHIJBNBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MLOFBNBBKBK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public LBJIHLHHHJJ(Action EHPPLAMIOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x70F7B90", Offset = "0x70F6F90", VA = "0x1870F7B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2E46D50", Offset = "0x2E46150", VA = "0x182E46D50")]
	public static PMAODDEEHAH<T> KOPOAAAOIOD<T>(T HCPAOILCJCB, Action EHPPLAMIOHC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class PMAODDEEHAH<T> : LBJIHLHHHJJ where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T GFHLLJBPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8D00", Offset = "0x4CA8100", VA = "0x184CA8D00")]
	public PMAODDEEHAH(T HCPAOILCJCB, Action EHPPLAMIOHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GFAINJEMHOH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MGMDFMMIBHI<T>? JLJJPMONBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> PEHACCDODHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool MLOFBNBBKBK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GFAINJEMHOH<T> MGEHKGIFIKI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> JNGPIDDFABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4191320", Offset = "0x4190720", VA = "0x184191320")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EPMKILCCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x41916D0", Offset = "0x4190AD0", VA = "0x1841916D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PJCKOFPFAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x41911D0", Offset = "0x41905D0", VA = "0x1841911D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4191A50", Offset = "0x4190E50", VA = "0x184191A50")]
	public GFAINJEMHOH(MGMDFMMIBHI<T> AGOJOCKIKBE, MGMDFMMIBHI<T> JENJEFHPHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4191F20", Offset = "0x4191320", VA = "0x184191F20")]
	public GFAINJEMHOH(MGMDFMMIBHI<T> AGOJOCKIKBE, int GDCLLKFPEAF, MGMDFMMIBHI<T> JENJEFHPHDF, int ECEMMDOHBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x41919A0", Offset = "0x4190DA0", VA = "0x1841919A0")]
	private GFAINJEMHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4191290", Offset = "0x4190690", VA = "0x184191290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x41914E0", Offset = "0x41908E0", VA = "0x1841914E0")]
	public T[] GPFELNBEICA()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41915A0", Offset = "0x41909A0", VA = "0x1841915A0")]
	public static ReadOnlySequence<T> IDKOEJANABA(GFAINJEMHOH<T>? BPLPEMOPIIJ)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HKIIKADHLEC : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct FAABJBDKKEF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
		public static FAABJBDKKEF ODOFIFAGLAJ()
		{
			return default(FAABJBDKKEF);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x70F7340", Offset = "0x70F6740", VA = "0x1870F7340")]
	public static string JIJKNBGAGMK(Type IFBDJLKPHIG, [Optional] string? FHPEFLFGKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3081670", Offset = "0x3080A70", VA = "0x183081670")]
	public static string? JIJKNBGAGMK<T>([Optional] string? FHPEFLFGKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x30815F0", Offset = "0x30809F0", VA = "0x1830815F0")]
	public static string? ADAFAIABJFI<T>([Optional] string? CIGBMDONNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
	public static HKIIKADHLEC MEINOAHMLLJ(string FHPEFLFGKEI, string? CIGBMDONNAN)
	{
		return default(HKIIKADHLEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CKGLPPPLONC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool LPIKNBGBGPK(string GLHKBKFFDFF, CKGLPPPLONC NKENMANNOLC);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EAAGBIHLCLD<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EAAGBIHLCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C78BD0", Offset = "0x3C77FD0", VA = "0x183C78BD0")]
		internal void MKLBJGKKJOM(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int GAADACALPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string JCIPPIGBLNM;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x70F6C00", Offset = "0x70F6000", VA = "0x1870F6C00")]
	public static Dictionary<string, CKGLPPPLONC> LEJCDGJOJKO(Type HAAEGDLOJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E47F20", Offset = "0x2E47320", VA = "0x182E47F20")]
	public static Dictionary<string, CKGLPPPLONC> LEJCDGJOJKO<T>(Type HAAEGDLOJGF, IReadOnlyDictionary<T, string> LOHLMFOKFAD) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2E477C0", Offset = "0x2E46BC0", VA = "0x182E477C0")]
	public static Dictionary<string, CKGLPPPLONC> FAHBEDFONBE<T>(List<T> EBJNNDMCHBE) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x70F6850", Offset = "0x70F5C50", VA = "0x1870F6850")]
	public static Dictionary<string, CKGLPPPLONC> GKBJEPINIPP(Type HAAEGDLOJGF, LPIKNBGBGPK GGNKJLIFGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x70F6690", Offset = "0x70F5A90", VA = "0x1870F6690")]
	public static Dictionary<int, string> ECKNCPONJBH(Dictionary<string, CKGLPPPLONC> MAPPNBHJLPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PJPEMJHFJLC : NAONGKGFBLO
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool HMCKEENNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? PEBNHCHCGBN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual NAONGKGFBLO? HDDABNLPGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x70F9F10", Offset = "0x70F9310", VA = "0x1870F9F10")]
	protected PJPEMJHFJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string MMDDBBBPGKC();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x70F98D0", Offset = "0x70F8CD0", VA = "0x1870F98D0", Slot = "8")]
	public virtual string FDIPJKFBEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x70F9950", Offset = "0x70F8D50", VA = "0x1870F9950", Slot = "9")]
	public void FLNEKKBCOIM(StringBuilder ICPJFPKJFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x70F9870", Offset = "0x70F8C70", VA = "0x1870F9870", Slot = "10")]
	public void EHALKJIAIGC(StringBuilder ICPJFPKJFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x70F9C90", Offset = "0x70F9090", VA = "0x1870F9C90", Slot = "11")]
	public void JBEFJPDNNBH(StringBuilder ICPJFPKJFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x70F9DB0", Offset = "0x70F91B0", VA = "0x1870F9DB0", Slot = "12")]
	public void MIOPGDCGKCC(StringBuilder ICPJFPKJFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x70F9BF0", Offset = "0x70F8FF0", VA = "0x1870F9BF0")]
	public static void HIBLLBJINPM(StringBuilder ICPJFPKJFIA, string FFPLBIECAOF, string NIHKHBOOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x621D0A0", Offset = "0x621C4A0", VA = "0x18621D0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KFIOGBHGOMC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x70F7A40", Offset = "0x70F6E40", VA = "0x1870F7A40")]
	public KFIOGBHGOMC(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OLLKMMJCBGK<TErr> : KFIOGBHGOMC where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr PDNCKFPBPGM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4B911E0", Offset = "0x4B905E0", VA = "0x184B911E0")]
	private OLLKMMJCBGK([In] TErr ILINDLDDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4B91100", Offset = "0x4B90500", VA = "0x184B91100")]
	public static OLLKMMJCBGK<TErr> ODOFIFAGLAJ([In] TErr ILINDLDDKPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KABFAMKFBND : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm HONLMCNPJGH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool ABAOABJDHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool KBAHCPGDFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool PBLAEPMJLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long EPMKILCCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70F78F0", Offset = "0x70F6CF0", VA = "0x1870F78F0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long FGALHLKMLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x70F7960", Offset = "0x70F6D60", VA = "0x1870F7960", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x70F79D0", Offset = "0x70F6DD0", VA = "0x1870F79D0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x70F7880", Offset = "0x70F6C80", VA = "0x1870F7880")]
	public KABFAMKFBND(HashAlgorithm HONLMCNPJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x70F76B0", Offset = "0x70F6AB0", VA = "0x1870F76B0", Slot = "35")]
	public override int Read(byte[] CELIBNPACII, int LHBPAMEKCBO, int ABPDJOGPHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x70F7850", Offset = "0x70F6C50", VA = "0x1870F7850", Slot = "38")]
	public override void Write(byte[] CELIBNPACII, int LHBPAMEKCBO, int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x70F7750", Offset = "0x70F6B50", VA = "0x1870F7750", Slot = "33")]
	public override long Seek(long LHBPAMEKCBO, SeekOrigin KJLHJAKALDP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x70F77E0", Offset = "0x70F6BE0", VA = "0x1870F77E0", Slot = "34")]
	public override void SetLength(long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x70F75E0", Offset = "0x70F69E0", VA = "0x1870F75E0")]
	public byte[] KJEBDGFHAHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NAONGKGFBLO
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FDIPJKFBEKB();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MMDDBBBPGKC();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BDHJNNHJNNI<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions GFHLLJBPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BEPJEPGFEMB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string EEHANAAHPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MGMDFMMIBHI<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static MGMDFMMIBHI<T>? JLBFLAKPBDA;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object JENBEJLPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? NALCNBECNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool MLOFBNBBKBK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BEICAADJBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9000", Offset = "0x9F8400", VA = "0x1809F9000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49F31A0", Offset = "0x49F25A0", VA = "0x1849F31A0")]
	private static MGMDFMMIBHI<T> KHKCMMPKPKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49F2480", Offset = "0x49F1880", VA = "0x1849F2480")]
	private static void BAEOLLFLGPB(MGMDFMMIBHI<T> NCLKGNGIHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x43D82F0", Offset = "0x43D76F0", VA = "0x1843D82F0")]
	private MGMDFMMIBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x49F3680", Offset = "0x49F2A80", VA = "0x1849F3680")]
	public static MGMDFMMIBHI<T> KOPOAAAOIOD(ReadOnlyMemory<T> KAGKKDFEHAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x49F3860", Offset = "0x49F2C60", VA = "0x1849F3860")]
	public static MGMDFMMIBHI<T> KOPOAAAOIOD(IMemoryOwner<T> KIGPJPJEBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x49F3EE0", Offset = "0x49F32E0", VA = "0x1849F3EE0")]
	public static void PEALBBEJBGH(MGMDFMMIBHI<T> AGOJOCKIKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x49F2D10", Offset = "0x49F2110", VA = "0x1849F2D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x49F3C60", Offset = "0x49F3060", VA = "0x1849F3C60")]
	public MGMDFMMIBHI<T> NHPGNDAJLNG(IMemoryOwner<T> KIGPJPJEBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x49F30A0", Offset = "0x49F24A0", VA = "0x1849F30A0")]
	private void KCAPMPPKIDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x49F3D80", Offset = "0x49F3180", VA = "0x1849F3D80")]
	private MGMDFMMIBHI<T> OMLBJKLAHCP(MGMDFMMIBHI<T> NCLKGNGIHDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KLMFPAJHJHN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x70F7AA0", Offset = "0x70F6EA0", VA = "0x1870F7AA0")]
	public KLMFPAJHJHN(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PACIHDPNKJB<TOk> : KLMFPAJHJHN where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk AEAHPKKKMLH;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4C43CA0", Offset = "0x4C430A0", VA = "0x184C43CA0")]
	private PACIHDPNKJB([In] TOk IHOIHNEJEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x40A4C20", Offset = "0x40A4020", VA = "0x1840A4C20")]
	public static PACIHDPNKJB<TOk> ODOFIFAGLAJ([In] TOk IHOIHNEJEIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct ABNAGONECLM<TOk, TErr> : IEquatable<ABNAGONECLM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> FCDEPKONDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr PDNCKFPBPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk AEAHPKKKMLH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool AIOFBOFOJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4132440", Offset = "0x4131840", VA = "0x184132440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool JCOHAKDJFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x41309F0", Offset = "0x412FDF0", VA = "0x1841309F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4137140", Offset = "0x4136540", VA = "0x184137140")]
	internal ABNAGONECLM([In] TErr ILINDLDDKPJ, [In] TOk IHOIHNEJEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x412DCE0", Offset = "0x412D0E0", VA = "0x18412DCE0")]
	public static ABNAGONECLM<TOk, TErr> EEMPMGNMLMM([In] TErr ILINDLDDKPJ)
	{
		return default(ABNAGONECLM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4133380", Offset = "0x4132780", VA = "0x184133380")]
	public static ABNAGONECLM<TOk, TErr> PNCHNLPJKDC([In] TOk IHOIHNEJEIE)
	{
		return default(ABNAGONECLM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2979900", Offset = "0x2978D00", VA = "0x182979900")]
	public ABNAGONECLM<TOk?, UErr?> ACHFPMOOLOA<UErr>()
	{
		return default(ABNAGONECLM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x297A810", Offset = "0x2979C10", VA = "0x18297A810")]
	public ABNAGONECLM<UOk?, TErr?> BJGMDKEPGOD<UOk>()
	{
		return default(ABNAGONECLM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x297ADD0", Offset = "0x297A1D0", VA = "0x18297ADD0")]
	public ABNAGONECLM<UOk?, TErr?> CLKADALHKAO<UOk>()
	{
		return default(ABNAGONECLM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2979DF0", Offset = "0x29791F0", VA = "0x182979DF0")]
	public ABNAGONECLM<TOk?, UErr?> AMMLBFJLNGC<UErr>()
	{
		return default(ABNAGONECLM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4133530", Offset = "0x4132930", VA = "0x184133530")]
	public ABNAGONECLM<ALHKDJHEAFJ, TErr> POLKOKBIINM()
	{
		return default(ABNAGONECLM<ALHKDJHEAFJ, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x412F890", Offset = "0x412EC90", VA = "0x18412F890")]
	public static bool FANHDJJNLED([In] ABNAGONECLM<TOk, TErr> KLFFMNNBENE, [In] ABNAGONECLM<TOk, TErr> EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x412E530", Offset = "0x412D930", VA = "0x18412E530", Slot = "4")]
	public bool Equals(ABNAGONECLM<TOk, TErr> BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x412E3A0", Offset = "0x412D7A0", VA = "0x18412E3A0", Slot = "0")]
	public override bool Equals(object BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4131B90", Offset = "0x4130F90", VA = "0x184131B90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4136800", Offset = "0x4135C00", VA = "0x184136800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class KCNOIOGBFPG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GGMMMIGJEHF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<ABNAGONECLM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<ABNAGONECLM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4197A10", Offset = "0x4196E10", VA = "0x184197A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41983D0", Offset = "0x41977D0", VA = "0x1841983D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x31080F0", Offset = "0x31074F0", VA = "0x1831080F0")]
	public static ABNAGONECLM<TOk?, TErr?> AEAHPKKKMLH<TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [In] TOk IHOIHNEJEIE)
	{
		return default(ABNAGONECLM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x31081F0", Offset = "0x31075F0", VA = "0x1831081F0")]
	public static ABNAGONECLM<ALHKDJHEAFJ, TErr?> AEAHPKKKMLH<TErr>([In] this ABNAGONECLM<ALHKDJHEAFJ, TErr> MPLBPEBNKFP)
	{
		return default(ABNAGONECLM<ALHKDJHEAFJ, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31080F0", Offset = "0x31074F0", VA = "0x1831080F0")]
	public static ABNAGONECLM<TOk?, TErr?> PDNCKFPBPGM<TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [In] TErr ILINDLDDKPJ)
	{
		return default(ABNAGONECLM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x310A840", Offset = "0x3109C40", VA = "0x18310A840")]
	public static TOk? LMPPIBIKBDL<TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x31099B0", Offset = "0x3108DB0", VA = "0x1831099B0")]
	[AsyncStateMachine(typeof(GGMMMIGJEHF<, >))]
	public static Task<TOk?>? KDAJLJLNOGG<TOk, TErr>(this Task<ABNAGONECLM<TOk, TErr>> MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3108330", Offset = "0x3107730", VA = "0x183108330")]
	public static TErr? ENHGPDIMFIN<TErr, TOk>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3108970", Offset = "0x3107D70", VA = "0x183108970")]
	public static bool INMDFDFMJIB<TOk, TErr, UErr, UOk>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [Out] ABNAGONECLM<UOk, UErr> PPPBAKGOBCN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x310A620", Offset = "0x3109A20", VA = "0x18310A620")]
	public static bool LGKDJAOFOCA<TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [Out] TOk IHOIHNEJEIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x310B270", Offset = "0x310A670", VA = "0x18310B270")]
	public static bool MFBCPFNLIPB<TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [Out][NotNullWhen(true)] TErr ILINDLDDKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3109E10", Offset = "0x3109210", VA = "0x183109E10")]
	public static bool LAOFCJENEFB<TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [Out][NotNullWhen(true)] TOk IHOIHNEJEIE, [Out][NotNullWhen(false)] TErr ILINDLDDKPJ) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3108750", Offset = "0x3107B50", VA = "0x183108750")]
	public static bool HMDOBGAAEIB<TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [Out][NotNullWhen(true)] TOk IHOIHNEJEIE, [Out] ABNAGONECLM<TOk, TErr> PPPBAKGOBCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3108840", Offset = "0x3107C40", VA = "0x183108840")]
	public static bool INMDFDFMJIB<TOk, TErr, UErr, UOk>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [Out][NotNullWhen(true)] TOk IHOIHNEJEIE, [Out] ABNAGONECLM<UOk, UErr> PPPBAKGOBCN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x310AED0", Offset = "0x310A2D0", VA = "0x18310AED0")]
	public static bool MBALJGEAKGP<TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [Out][NotNullWhen(true)] TOk IHOIHNEJEIE, [Out] ABNAGONECLM<ALHKDJHEAFJ, TErr> PPPBAKGOBCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3109E90", Offset = "0x3109290", VA = "0x183109E90")]
	public static ABNAGONECLM<UOk, UErr> LFLJDNHLBAP<UOk, UErr, TOk, TErr>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, [In] ABNAGONECLM<UOk, UErr> PGHMIFOEHOF) where TOk : UOk where TErr : UErr
	{
		return default(ABNAGONECLM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x310B660", Offset = "0x310AA60", VA = "0x18310B660")]
	public static ABNAGONECLM<TOk?[]?, TErr?> NKFDHDMJGFE<TOk, TErr>(this IEnumerable<ABNAGONECLM<TOk, TErr>> MPLBPEBNKFP)
	{
		return default(ABNAGONECLM<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x310B3B0", Offset = "0x310A7B0", VA = "0x18310B3B0")]
	public static ABNAGONECLM<UOk?, TErr?> NIMJEGACONA<UOk, TErr, TOk>([In] this ABNAGONECLM<TOk, TErr> MPLBPEBNKFP, Func<TOk, UOk> KPHHCOKABJK)
	{
		return default(ABNAGONECLM<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FMAEHAPFPNG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x31841C0", Offset = "0x31835C0", VA = "0x1831841C0")]
	public static ABNAGONECLM<TOk, T> AEAHPKKKMLH<TOk>([In] TOk IHOIHNEJEIE) where TOk : notnull
	{
		return default(ABNAGONECLM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x40AA160", Offset = "0x40A9560", VA = "0x1840AA160")]
	public static ABNAGONECLM<ALHKDJHEAFJ, T> AEAHPKKKMLH()
	{
		return default(ABNAGONECLM<ALHKDJHEAFJ, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3184130", Offset = "0x3183530", VA = "0x183184130")]
	public static ABNAGONECLM<T, TErr> PDNCKFPBPGM<TErr>([In] TErr ILINDLDDKPJ) where TErr : notnull
	{
		return default(ABNAGONECLM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct NKIHGFAMMIB<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly NJLFBECFAOH NKEAJEKOACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> FLDIFBEDGFP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x42FE4B0", Offset = "0x42FD8B0", VA = "0x1842FE4B0")]
	public static NKIHGFAMMIB<TKey, TValue> ODOFIFAGLAJ(string NOIHGGNEIML)
	{
		return default(NKIHGFAMMIB<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x42FE5E0", Offset = "0x42FD9E0", VA = "0x1842FE5E0")]
	internal NKIHGFAMMIB(Dictionary<TKey, TValue> HCPAOILCJCB, NJLFBECFAOH HMGGHACMEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD800", VA = "0x1842FE400")]
	public BCBMKICFAKA<TKey, TValue> AICLLDGDBKD([Out] Dictionary<TKey, TValue> HCPAOILCJCB)
	{
		return default(BCBMKICFAKA<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct BCBMKICFAKA<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> FLDIFBEDGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly OPNPECEHNMC CCDAAMGDOCN;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2525F60", Offset = "0x2525360", VA = "0x182525F60")]
	internal BCBMKICFAKA(Dictionary<TKey, TValue> HCPAOILCJCB, OPNPECEHNMC ECKNEFJKMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x432F7B0", Offset = "0x432EBB0", VA = "0x18432F7B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct APGKKICAHLD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly NJLFBECFAOH NKEAJEKOACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> FLDIFBEDGFP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x42FE4B0", Offset = "0x42FD8B0", VA = "0x1842FE4B0")]
	public static APGKKICAHLD<T> ODOFIFAGLAJ(string NOIHGGNEIML)
	{
		return default(APGKKICAHLD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x42FE5E0", Offset = "0x42FD9E0", VA = "0x1842FE5E0")]
	internal APGKKICAHLD(HashSet<T> HCPAOILCJCB, NJLFBECFAOH HMGGHACMEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD800", VA = "0x1842FE400")]
	public IDDGHAAGPLM<T> AICLLDGDBKD([Out] HashSet<T> HCPAOILCJCB)
	{
		return default(IDDGHAAGPLM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct IDDGHAAGPLM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> FLDIFBEDGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OPNPECEHNMC CCDAAMGDOCN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2525F60", Offset = "0x2525360", VA = "0x182525F60")]
	internal IDDGHAAGPLM(HashSet<T> HCPAOILCJCB, OPNPECEHNMC ECKNEFJKMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x432F7B0", Offset = "0x432EBB0", VA = "0x18432F7B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct DMMMNGNEOCE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NJLFBECFAOH NKEAJEKOACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> FLDIFBEDGFP;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x42FE4B0", Offset = "0x42FD8B0", VA = "0x1842FE4B0")]
	public static DMMMNGNEOCE<T> ODOFIFAGLAJ(string NOIHGGNEIML)
	{
		return default(DMMMNGNEOCE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42FE5E0", Offset = "0x42FD9E0", VA = "0x1842FE5E0")]
	internal DMMMNGNEOCE(Stack<T> HCPAOILCJCB, NJLFBECFAOH HMGGHACMEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x42FE400", Offset = "0x42FD800", VA = "0x1842FE400")]
	public KODOBBBJDMK<T> AICLLDGDBKD([Out] Stack<T> HCPAOILCJCB)
	{
		return default(KODOBBBJDMK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KODOBBBJDMK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> FLDIFBEDGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly OPNPECEHNMC CCDAAMGDOCN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2525F60", Offset = "0x2525360", VA = "0x182525F60")]
	internal KODOBBBJDMK(Stack<T> HCPAOILCJCB, OPNPECEHNMC ECKNEFJKMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x432F7B0", Offset = "0x432EBB0", VA = "0x18432F7B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class HPLDMJDBKBP<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct PCHPPBOMILD : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly HPLDMJDBKBP<T> ICFOFAMGABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int FBPAPNGLIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool HFCAINBGBOJ;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x22164E0", Offset = "0x22158E0", VA = "0x1822164E0")]
		public PCHPPBOMILD(HPLDMJDBKBP<T> HKNABNLJGOH, int OEKGGENJELP, bool ADICHJHCBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4C59680", Offset = "0x4C58A80", VA = "0x184C59680")]
		public HPLDMJDBKBP<T>.BLNODNLJGPH JDJKPBEKJIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4C59780", Offset = "0x4C58B80", VA = "0x184C59780", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4C59780", Offset = "0x4C58B80", VA = "0x184C59780", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class BLNODNLJGPH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HPLDMJDBKBP<T> ICFOFAMGABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int DEOFMKKDCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int CBHNADMFCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool HFCAINBGBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool ABMEPBPFCDK;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x53DBED0", Offset = "0x53DB2D0", VA = "0x1853DBED0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x53DC0E0", Offset = "0x53DB4E0", VA = "0x1853DC0E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x53DC160", Offset = "0x53DB560", VA = "0x1853DC160", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x53DC420", Offset = "0x53DB820", VA = "0x1853DC420")]
		public BLNODNLJGPH(HPLDMJDBKBP<T> HKNABNLJGOH, int OEKGGENJELP, bool ADICHJHCBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x53DBFD0", Offset = "0x53DB3D0", VA = "0x1853DBFD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x53DC070", Offset = "0x53DB470", VA = "0x1853DC070", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class KCOGCMIBIPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public KCOGCMIBIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x465E1D0", Offset = "0x465D5D0", VA = "0x18465E1D0")]
		internal T ILHGHBJFLPC(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] AEEEAMBLKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int CBHNADMFCEN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PKCPPAIBOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4276CA0", Offset = "0x42760A0", VA = "0x184276CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T DLFFLJHEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x40488A0", Offset = "0x4047CA0", VA = "0x1840488A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T MGJENIPPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4276C60", Offset = "0x4276060", VA = "0x184276C60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4276A70", Offset = "0x4275E70", VA = "0x184276A70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EPMKILCCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE4B0", Offset = "0x1EBD8B0", VA = "0x181EBE4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x156FE30", Offset = "0x156F230", VA = "0x18156FE30")]
	private static int GMAAEMJEINI(int IIACLAMOIEE, int OIPEPMJNPGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4276DA0", Offset = "0x42761A0", VA = "0x184276DA0")]
	public HPLDMJDBKBP(int BGDDCGNLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4276E30", Offset = "0x4276230", VA = "0x184276E30")]
	public HPLDMJDBKBP(int BGDDCGNLDBK, Func<T> ELHNKNBKLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4277140", Offset = "0x4276540", VA = "0x184277140")]
	public HPLDMJDBKBP(T[] KNHLIMDEMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4276900", Offset = "0x4275D00", VA = "0x184276900")]
	public void EKAFLPHCNBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4276930", Offset = "0x4275D30", VA = "0x184276930")]
	public IEnumerable<T> FOBKEMCHBFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4276BC0", Offset = "0x4275FC0", VA = "0x184276BC0")]
	public HPLDMJDBKBP<T>.BLNODNLJGPH JDJKPBEKJIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C2E0", Offset = "0x3C7B6E0", VA = "0x183C7C2E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C2E0", Offset = "0x3C7B6E0", VA = "0x183C7C2E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OEOBDDOFNEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x32158E0", Offset = "0x3214CE0", VA = "0x1832158E0")]
	public static HPLDMJDBKBP<T> ODOFIFAGLAJ<T>(int BGDDCGNLDBK, Func<T> ELHNKNBKLCM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class PJCEBKMNINC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct JMNIMPHBNEN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly PJCEBKMNINC<T> EDDACCIEPFN;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T GFHLLJBPNAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x4596B60", Offset = "0x4595F60", VA = "0x184596B60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4596B30", Offset = "0x4595F30", VA = "0x184596B30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
		public JMNIMPHBNEN(PJCEBKMNINC<T> EDDACCIEPFN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CNAEMNFLKIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<JMNIMPHBNEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public PJCEBKMNINC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5903A10", Offset = "0x5902E10", VA = "0x185903A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5DA0", Offset = "0x3CC51A0", VA = "0x183CC5DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim CKOBNIALEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T JEHHJPJCBHP;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4C6F620", Offset = "0x4C6EA20", VA = "0x184C6F620")]
	public PJCEBKMNINC([In] T JEHHJPJCBHP, int OFIHCHDAPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4C6F490", Offset = "0x4C6E890", VA = "0x184C6F490")]
	public PJCEBKMNINC([In] T JEHHJPJCBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C6EF30", Offset = "0x4C6E330", VA = "0x184C6EF30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4C6EF70", Offset = "0x4C6E370", VA = "0x184C6EF70")]
	public JMNIMPHBNEN GMFCBCEDBOL()
	{
		return default(JMNIMPHBNEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4C6F340", Offset = "0x4C6E740", VA = "0x184C6F340")]
	[AsyncStateMachine(typeof(PJCEBKMNINC<>.CNAEMNFLKIG))]
	public Task<PJCEBKMNINC<T>.JMNIMPHBNEN> MCPDPAADCKF(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C6F470", Offset = "0x4C6E870", VA = "0x184C6F470")]
	public void PGENGDPMBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AMAPCCANIGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x70F65A0", Offset = "0x70F59A0", VA = "0x1870F65A0")]
	public static PJCEBKMNINC<ALHKDJHEAFJ> ODOFIFAGLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E46CD0", Offset = "0x2E460D0", VA = "0x182E46CD0")]
	public static PJCEBKMNINC<T> ODOFIFAGLAJ<T>([In] T JEHHJPJCBHP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FFLHAPGINJI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct DDLMIEHPOPF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly FFLHAPGINJI<T> EBLEKHPLDGL;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T GFHLLJBPNAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x41AE5D0", Offset = "0x41AD9D0", VA = "0x1841AE5D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E53DC0", Offset = "0x5E531C0", VA = "0x185E53DC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
		internal DDLMIEHPOPF(FFLHAPGINJI<T> EDDACCIEPFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct GNNFJCCBPOA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly FFLHAPGINJI<T> EBLEKHPLDGL;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T GFHLLJBPNAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x41AE5D0", Offset = "0x41AD9D0", VA = "0x1841AE5D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x41AE530", Offset = "0x41AD930", VA = "0x1841AE530", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
		internal GNNFJCCBPOA(FFLHAPGINJI<T> EDDACCIEPFN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct LECHBELEIBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<GNNFJCCBPOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public FFLHAPGINJI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private PJCEBKMNINC<ALHKDJHEAFJ>.JMNIMPHBNEN <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<PJCEBKMNINC<ALHKDJHEAFJ>.JMNIMPHBNEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x47BEE00", Offset = "0x47BE200", VA = "0x1847BEE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5DA0", Offset = "0x3CC51A0", VA = "0x183CC5DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly PJCEBKMNINC<int> DEHHHNDHMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly PJCEBKMNINC<ALHKDJHEAFJ> OAODNJBCLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PJCEBKMNINC<ALHKDJHEAFJ> MHCMHDDEPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T CBIGEDIFABO;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4079AB0", Offset = "0x4078EB0", VA = "0x184079AB0")]
	internal FFLHAPGINJI(PJCEBKMNINC<int> PKLDLGAPPEN, PJCEBKMNINC<ALHKDJHEAFJ> HLJEDILNGLG, PJCEBKMNINC<ALHKDJHEAFJ> HHNMIJOHNGC, [In] T JEHHJPJCBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4078FD0", Offset = "0x40783D0", VA = "0x184078FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4079150", Offset = "0x4078550", VA = "0x184079150")]
	public DDLMIEHPOPF FDDODJDFILN()
	{
		return default(DDLMIEHPOPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4078DF0", Offset = "0x40781F0", VA = "0x184078DF0")]
	public GNNFJCCBPOA BNJLCFOPFMP()
	{
		return default(GNNFJCCBPOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4079690", Offset = "0x4078A90", VA = "0x184079690")]
	[AsyncStateMachine(typeof(FFLHAPGINJI<>.LECHBELEIBB))]
	public Task<FFLHAPGINJI<T>.GNNFJCCBPOA> PEDDOJLIEDM(CancellationToken FHGIOBPPFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OILKLJNAMDF
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x70F8E10", Offset = "0x70F8210", VA = "0x1870F8E10")]
	public static FFLHAPGINJI<ALHKDJHEAFJ> ODOFIFAGLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3217050", Offset = "0x3216450", VA = "0x183217050")]
	public static FFLHAPGINJI<T> ODOFIFAGLAJ<T>([In] T JEHHJPJCBHP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class CFHFIFBGCNK<TData> : PJPEMJHFJLC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string DIJFEMNHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData GLBGLIBCAOD;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
	public override string MMDDBBBPGKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5702A30", Offset = "0x5701E30", VA = "0x185702A30")]
	internal CFHFIFBGCNK(string LNICHECHJFC, [In] TData JGCOLLOOLHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class ANHGOPLEEMO
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x70F6610", Offset = "0x70F5A10", VA = "0x1870F6610")]
	public static CFHFIFBGCNK<ALHKDJHEAFJ> ODOFIFAGLAJ(string LNICHECHJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2E46D50", Offset = "0x2E46150", VA = "0x182E46D50")]
	public static CFHFIFBGCNK<TData> ODOFIFAGLAJ<TData>(string LNICHECHJFC, [In] TData JGCOLLOOLHL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class NJLFBECFAOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool DNPCFEGPIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string PIAFINEIJBJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA35C50", Offset = "0xA35050", VA = "0x180A35C50")]
	private NJLFBECFAOH(bool KLHJOLODEDO, string LFAIDBGILDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x70F8D20", Offset = "0x70F8120", VA = "0x1870F8D20")]
	public static NJLFBECFAOH ODOFIFAGLAJ(string LFAIDBGILDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x70F8C60", Offset = "0x70F8060", VA = "0x1870F8C60")]
	public OPNPECEHNMC AICLLDGDBKD()
	{
		return default(OPNPECEHNMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct OPNPECEHNMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NJLFBECFAOH JJJEELNOIIB;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	internal OPNPECEHNMC(NJLFBECFAOH NOIHGGNEIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x70F8EE0", Offset = "0x70F82E0", VA = "0x1870F8EE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class HNKIPMFJOLC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EMJPDEIMEKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EMJPDEIMEKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3CDEF20", Offset = "0x3CDE320", VA = "0x183CDEF20")]
		internal int IOPCLLFBKEK(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? IEIELJKJDHH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> PJDJIGIPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x42739F0", Offset = "0x4272DF0", VA = "0x1842739F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool AOICNIKBOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x42738B0", Offset = "0x4272CB0", VA = "0x1842738B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C60", Offset = "0x8C8060", VA = "0x1808C8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x42736D0", Offset = "0x4272AD0", VA = "0x1842736D0")]
	public bool EBDKDKCDLND(T CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4273550", Offset = "0x4272950", VA = "0x184273550")]
	public bool BDKJEBALGLD(T CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4273A30", Offset = "0x4272E30", VA = "0x184273A30")]
	public bool PLOBJDDHBDK(T CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4273900", Offset = "0x4272D00", VA = "0x184273900")]
	public void FHMEIIFEAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4273A80", Offset = "0x4272E80", VA = "0x184273A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public HNKIPMFJOLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class MFGPGCPLCOD
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EJGCPPCHBDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EJGCPPCHBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x70F70C0", Offset = "0x70F64C0", VA = "0x1870F70C0")]
		internal int IOPCLLFBKEK(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? IEIELJKJDHH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> PJDJIGIPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x70F8470", Offset = "0x70F7870", VA = "0x1870F8470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool AOICNIKBOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x70F83F0", Offset = "0x70F77F0", VA = "0x1870F83F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C60", Offset = "0x8C8060", VA = "0x1808C8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x70F8310", Offset = "0x70F7710", VA = "0x1870F8310")]
	public bool EBDKDKCDLND(object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x70F8270", Offset = "0x70F7670", VA = "0x1870F8270")]
	public bool BDKJEBALGLD(object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x70F8500", Offset = "0x70F7900", VA = "0x1870F8500")]
	public bool PLOBJDDHBDK(object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x70F8400", Offset = "0x70F7800", VA = "0x1870F8400")]
	public void FHMEIIFEAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x70F8560", Offset = "0x70F7960", VA = "0x1870F8560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MFGPGCPLCOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GFOECDEFAOP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct CKCFOLJKHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float OLEJIJODNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T GFHLLJBPNAP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, CKCFOLJKHCN> INNPOFPBAKD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T NGMFAJJALFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1477290", Offset = "0x1476690", VA = "0x181477290", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1476620", Offset = "0x1475A20", VA = "0x181476620", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? GICOEPLIDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C80", Offset = "0x8C8080", VA = "0x1808C8C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool AGJOLDIKCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4192C10", Offset = "0x4192010", VA = "0x184192C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x41949A0", Offset = "0x4193DA0", VA = "0x1841949A0")]
	public bool OAIFNLOOELA(T HCPAOILCJCB, object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4195360", Offset = "0x4194760", VA = "0x184195360")]
	public bool ODEANAEKGHL(object CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4192C70", Offset = "0x4192070", VA = "0x184192C70")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4194870", Offset = "0x4193C70", VA = "0x184194870")]
	public bool LINPJOCPLAE(object CMNJCPJBHGE, [Out] T HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x41933E0", Offset = "0x41927E0", VA = "0x1841933E0")]
	[MIBJBKKFACK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool GEIKDNDIKPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4195410", Offset = "0x4194810", VA = "0x184195410")]
	public GFOECDEFAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class IMPNODMCNME : GDBFCOCFADE<PALGLKMIOIC>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal class KOGKJCHMGKN : IEqualityComparer<PALGLKMIOIC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal static readonly KOGKJCHMGKN ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x70F7B00", Offset = "0x70F6F00", VA = "0x1870F7B00", Slot = "4")]
		public bool Equals(PALGLKMIOIC KENGFOGLPKI, PALGLKMIOIC IFGPABAHODO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6407280", Offset = "0x6406680", VA = "0x186407280", Slot = "5")]
		public int GetHashCode(PALGLKMIOIC NCHBKHMIMGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public KOGKJCHMGKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x70F7570", Offset = "0x70F6970", VA = "0x1870F7570")]
	public IMPNODMCNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x70F7430", Offset = "0x70F6830", VA = "0x1870F7430", Slot = "4")]
	public override bool EBDKDKCDLND(PALGLKMIOIC CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x70F7380", Offset = "0x70F6780", VA = "0x1870F7380", Slot = "5")]
	public override bool BDKJEBALGLD(PALGLKMIOIC CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x70F74E0", Offset = "0x70F68E0", VA = "0x1870F74E0")]
	private static void IKEGJDGHHIO(PALGLKMIOIC CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1376CF0", Offset = "0x13760F0", VA = "0x181376CF0", Slot = "6")]
	protected override string JPNKEMEADKH(PALGLKMIOIC CMNJCPJBHGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class PALGLKMIOIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string NBLNLIEDNEB;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public PALGLKMIOIC(string NBLNLIEDNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x70F8F00", Offset = "0x70F8300", VA = "0x1870F8F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class GDBFCOCFADE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEqualityComparer<T> GNOIOLAMEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<T>? IEIELJKJDHH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AOICNIKBOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4190080", Offset = "0x418F480", VA = "0x184190080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x96FA40", Offset = "0x96EE40", VA = "0x18096FA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x41904C0", Offset = "0x418F8C0", VA = "0x1841904C0")]
	internal GDBFCOCFADE(IEqualityComparer<T> GNOIOLAMEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x418FEA0", Offset = "0x418F2A0", VA = "0x18418FEA0", Slot = "4")]
	public virtual bool EBDKDKCDLND(T CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x418FD20", Offset = "0x418F120", VA = "0x18418FD20", Slot = "5")]
	public virtual bool BDKJEBALGLD(T CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x41900D0", Offset = "0x418F4D0", VA = "0x1841900D0")]
	public void FHMEIIFEAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string JPNKEMEADKH(T CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x41901C0", Offset = "0x418F5C0", VA = "0x1841901C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class JNFLJAOLJJI<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? IEIELJKJDHH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AOICNIKBOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4598B00", Offset = "0x4597F00", VA = "0x184598B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4598C80", Offset = "0x4598080", VA = "0x184598C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4598870", Offset = "0x4597C70", VA = "0x184598870")]
	public void EBDKDKCDLND(T CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x45986C0", Offset = "0x4597AC0", VA = "0x1845986C0")]
	public void BDKJEBALGLD(T CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4598C30", Offset = "0x4598030", VA = "0x184598C30")]
	public void FHMEIIFEAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4598E30", Offset = "0x4598230", VA = "0x184598E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public JNFLJAOLJJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class AGEPJJBOBDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x312D200", Offset = "0x312C600", VA = "0x18312D200")]
	public static void HLHGIEHDCCN<T>(this List<T> CECMFLAILAL, int IIACLAMOIEE) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LNFKKLGHBEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, float> INNPOFPBAKD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float CDBAMDPGGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB05EB0", Offset = "0xB052B0", VA = "0x180B05EB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB05970", Offset = "0xB04D70", VA = "0x180B05970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x70F7D50", Offset = "0x70F7150", VA = "0x1870F7D50")]
	public void OAIFNLOOELA(float HCPAOILCJCB, object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x70F7DC0", Offset = "0x70F71C0", VA = "0x1870F7DC0")]
	public void ODEANAEKGHL(object CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x70F7BD0", Offset = "0x70F6FD0", VA = "0x1870F7BD0")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x70F7C20", Offset = "0x70F7020", VA = "0x1870F7C20")]
	private void IPGGACELDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x70F7E30", Offset = "0x70F7230", VA = "0x1870F7E30")]
	public LNFKKLGHBEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface FFAOHLJEEBB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PCHPOLLMJLF KJFPNPOBMFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PGEPEEEPGPE : FFAOHLJEEBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct LOOJNMKHLCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly float INEAJMHODFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly float ACFPBEHFGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal readonly bool BDPCGJLEFCD;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float EMINOKGEAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x70F7EC0", Offset = "0x70F72C0", VA = "0x1870F7EC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x70F8030", Offset = "0x70F7430", VA = "0x1870F8030")]
		public LOOJNMKHLCN(float JJJPINFOLNN, float LACNKIEAGAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x70F7ED0", Offset = "0x70F72D0", VA = "0x1870F7ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class FFAGCGIJMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PGEPEEEPGPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FFAGCGIJMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x70F72A0", Offset = "0x70F66A0", VA = "0x1870F72A0")]
		internal void GBCFCJKOAEN(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int GNOHMAFCFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int CAMIKGIPGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly FFAOHLJEEBB[] NOEGGHEJLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly PCHPOLLMJLF[] IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LOOJNMKHLCN[] OKFLMOCGLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private LOOJNMKHLCN LEAKKEBIMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NFELGJLCDGC FPMBCDHMHMB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PCHPOLLMJLF KJFPNPOBMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x70F9620", Offset = "0x70F8A20", VA = "0x1870F9620", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x70F8F50", Offset = "0x70F8350", VA = "0x1870F8F50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x70F96E0", Offset = "0x70F8AE0", VA = "0x1870F96E0")]
	public PGEPEEEPGPE(int GNOHMAFCFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x70F9590", Offset = "0x70F8990", VA = "0x1870F9590")]
	public NFELGJLCDGC IDGDDPHJICC(LOOJNMKHLCN OCBAIMLDLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x70F9120", Offset = "0x70F8520", VA = "0x1870F9120")]
	public void GKPNFGOIFPO(FFAOHLJEEBB CFOKMPKLCIL, [Optional] LOOJNMKHLCN FLOLNNPKLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x70F9010", Offset = "0x70F8410", VA = "0x1870F9010", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate void PCHPOLLMJLF(float FEFOPHHCAEN);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class ENEMJEKCBPD
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class LPIFPEEDGPH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly FFAOHLJEEBB NADIKCJAKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly PCHPOLLMJLF CPIKECCHPBJ;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x70F81E0", Offset = "0x70F75E0", VA = "0x1870F81E0")]
		public LPIFPEEDGPH(FFAOHLJEEBB NADIKCJAKFD, PCHPOLLMJLF CPIKECCHPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x70F8190", Offset = "0x70F7590", VA = "0x1870F8190", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x70F7230", Offset = "0x70F6630", VA = "0x1870F7230")]
	internal static bool KAIKIKKCBFH(float DDIIBBHFODJ, float BCCGANGEINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x70E3C40", Offset = "0x70E3040", VA = "0x1870E3C40")]
	internal static float MECLLKPPHEK(float DDIIBBHFODJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x70F7170", Offset = "0x70F6570", VA = "0x1870F7170")]
	public static IDisposable CEPLFMMBNIH(this FFAOHLJEEBB NADIKCJAKFD, PCHPOLLMJLF CPIKECCHPBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NFELGJLCDGC : FFAOHLJEEBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private float FEFOPHHCAEN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float NCFLHBNGLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x70F8A30", Offset = "0x70F7E30", VA = "0x1870F8A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PCHPOLLMJLF? KJFPNPOBMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x70F8BC0", Offset = "0x70F7FC0", VA = "0x1870F8BC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x70F8B20", Offset = "0x70F7F20", VA = "0x1870F8B20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public NFELGJLCDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface NBEJMFKLPFG<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JNBNLHGPMPN<T> ECCEODIIMHH([Out] T HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDMKLDGEKPL();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class JHJPPFEPFLL<T> : NBEJMFKLPFG<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ConcurrentStack<T> KAEAFCFADBN;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4584950", Offset = "0x4583D50", VA = "0x184584950", Slot = "4")]
	public JNBNLHGPMPN<T> ECCEODIIMHH([Out] T HCPAOILCJCB)
	{
		return default(JNBNLHGPMPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x45849F0", Offset = "0x4583DF0", VA = "0x1845849F0")]
	public void OLENLPMJDLF(T LFJOHGOFMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3CCACA0", Offset = "0x3CCA0A0", VA = "0x183CCACA0", Slot = "5")]
	public void CDMKLDGEKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
	protected virtual void MPONCDPFDDF(T NCDMJOENLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x45848A0", Offset = "0x4583CA0", VA = "0x1845848A0")]
	private T AFFELPLAAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4584A70", Offset = "0x4583E70", VA = "0x184584A70")]
	public JHJPPFEPFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct JNBNLHGPMPN<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly T LFJOHGOFMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly JHJPPFEPFLL<T> NJHPHKJIADI;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
	internal JNBNLHGPMPN(T HCPAOILCJCB, JHJPPFEPFLL<T> NJHPHKJIADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4597810", Offset = "0x4596C10", VA = "0x184597810", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CNLMMHANOFI : JHJPPFEPFLL<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly CNLMMHANOFI ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x70F6F30", Offset = "0x70F6330", VA = "0x1870F6F30")]
	public static JNBNLHGPMPN<StringBuilder> AFFELPLAAIM([Out] StringBuilder HCPAOILCJCB)
	{
		return default(JNBNLHGPMPN<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x70F6FD0", Offset = "0x70F63D0", VA = "0x1870F6FD0", Slot = "6")]
	protected override void MPONCDPFDDF(StringBuilder NCDMJOENLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x70F7080", Offset = "0x70F6480", VA = "0x1870F7080")]
	public CNLMMHANOFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LNJCCHCPECH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEFF0", Offset = "0x6ACE3F0", VA = "0x186ACEFF0")]
	public LNJCCHCPECH(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DefaultMember("Item")]
public class NFBHNJGLDOI<TKey, TValue> : NEMMBKBPOMA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, CMCMHPJOOGO where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LGEFHCAAADI : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NFBHNJGLDOI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1477290", Offset = "0x1476690", VA = "0x181477290", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x47C8BB0", Offset = "0x47C7FB0", VA = "0x1847C8BB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public LGEFHCAAADI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x40E8DB0", Offset = "0x40E81B0", VA = "0x1840E8DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x47C8530", Offset = "0x47C7930", VA = "0x1847C8530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x47C8A70", Offset = "0x47C7E70", VA = "0x1847C8A70")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x47C7B40", Offset = "0x47C6F40", VA = "0x1847C7B40")]
		private void GFPCIOJGMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x47C8AC0", Offset = "0x47C7EC0", VA = "0x1847C8AC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly NEMMBKBPOMA<TKey, TValue> GIAPLIBBPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IDictionary<TKey, TValue> EHANFNPBPGH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4A711D0", Offset = "0x4A705D0", VA = "0x184A711D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DNNGBKHPAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public TValue EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4A712A0", Offset = "0x4A706A0", VA = "0x184A712A0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4A71590", Offset = "0x4A70990", VA = "0x184A71590", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ICollection<TKey> CNNBDHKBDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4A71330", Offset = "0x4A70730", VA = "0x184A71330", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICollection<TValue> HHBEAJGHAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4A71460", Offset = "0x4A70860", VA = "0x184A71460", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4A70F60", Offset = "0x4A70360", VA = "0x184A70F60")]
	public NFBHNJGLDOI(NEMMBKBPOMA<TKey, TValue> GIAPLIBBPHM, [Optional] IDictionary<TKey, TValue>? EHANFNPBPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4A6E700", Offset = "0x4A6DB00", VA = "0x184A6E700", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F920", Offset = "0x4A6ED20", VA = "0x184A6F920")]
	public void HKEKFJPBPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4A6E250", Offset = "0x4A6D650", VA = "0x184A6E250", Slot = "9")]
	public void Add(TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4A6FEB0", Offset = "0x4A6F2B0", VA = "0x184A6FEB0")]
	public void NNHIMMEHHEO(TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4A6FB60", Offset = "0x4A6EF60", VA = "0x184A6FB60")]
	public void JAEEHEAGJCP(TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F120", Offset = "0x4A6E520", VA = "0x184A6F120")]
	public void GHHFGDIHLOH(TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F730", Offset = "0x4A6EB30", VA = "0x184A6F730")]
	public void HILEABGJNMP(TKey LDCKBFKFIKC, TValue HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4A705D0", Offset = "0x4A6F9D0", VA = "0x184A705D0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4A707C0", Offset = "0x4A6FBC0", VA = "0x184A707C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4A70B20", Offset = "0x4A6FF20", VA = "0x184A70B20", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4A6E840", Offset = "0x4A6DC40", VA = "0x184A6E840", Slot = "8")]
	public bool ContainsKey(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F000", Offset = "0x4A6E400", VA = "0x184A6F000")]
	public bool EEEPEFPJALC(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F9D0", Offset = "0x4A6EDD0", VA = "0x184A6F9D0")]
	public bool HLAGCBBCAJJ(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4A703E0", Offset = "0x4A6F7E0", VA = "0x184A703E0", Slot = "10")]
	public bool Remove(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x4A70CE0", Offset = "0x4A700E0", VA = "0x184A70CE0", Slot = "11")]
	public bool TryGetValue(TKey LDCKBFKFIKC, [Out] TValue HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4A6EB60", Offset = "0x4A6DF60", VA = "0x184A6EB60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] CHDCMIMONFN, int ECPOGOHOPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x462DEC0", Offset = "0x462D2C0", VA = "0x18462DEC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4A6F680", Offset = "0x4A6EA80", VA = "0x184A6F680", Slot = "19")]
	[IteratorStateMachine(typeof(NFBHNJGLDOI<, >.LGEFHCAAADI))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4A6FD90", Offset = "0x4A6F190", VA = "0x184A6FD90", Slot = "21")]
	public bool MEKJAKFMNFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4A70040", Offset = "0x4A6F440", VA = "0x184A70040")]
	private TValue OGKDLEMOIJG(TKey LDCKBFKFIKC)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface CMCMHPJOOGO
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MEKJAKFMNFP();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface NEMMBKBPOMA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CMCMHPJOOGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public sealed class KHPJJBFPLGK<TKey, TVal> : NEMMBKBPOMA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CMCMHPJOOGO where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate int MGHPKBNJLDG(TKey LDCKBFKFIKC, TVal HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate void PCEODJNFLFC(TKey LDCKBFKFIKC, TVal HCPAOILCJCB, ICHGLMJLOAP OCIFOIBHPJJ);

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class OBEMEKEBBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xB5FC10", Offset = "0xB5F010", VA = "0x180B5FC10")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public TVal GFHLLJBPNAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x96FA40", Offset = "0x96EE40", VA = "0x18096FA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int EMINOKGEAOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x906930", Offset = "0x905D30", VA = "0x180906930")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x905F30", Offset = "0x905330", VA = "0x180905F30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public DateTimeOffset MEKDLILCEPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x100D810", Offset = "0x100CC10", VA = "0x18100D810")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1A5D6B0", Offset = "0x1A5CAB0", VA = "0x181A5D6B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4B7A520", Offset = "0x4B79920", VA = "0x184B7A520")]
		public OBEMEKEBBGJ(TKey LDCKBFKFIKC, TVal BBFFJMPBBGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class IPOHFPOGAAA : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KHPJJBFPLGK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private LinkedList<OBEMEKEBBGJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1477290", Offset = "0x1476690", VA = "0x181477290", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x43D3260", Offset = "0x43D2660", VA = "0x1843D3260", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public IPOHFPOGAAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3FC22B0", Offset = "0x3FC16B0", VA = "0x183FC22B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x43D2550", Offset = "0x43D1950", VA = "0x1843D2550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x43D2EE0", Offset = "0x43D22E0", VA = "0x1843D2EE0")]
		private void NOLPLDAPGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x43D2F90", Offset = "0x43D2390", VA = "0x1843D2F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int GPBHEJFCHLK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, LinkedListNode<OBEMEKEBBGJ>> GOAIHOHACPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<OBEMEKEBBGJ> FENKHBGOOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MGHPKBNJLDG? KHDIJDKEJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly TimeSpan PDMPMELMPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly PCEODJNFLFC? EBLELOPEDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly EHICLJOCAMK JOENEDFCOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool DEGKGJEHJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<TKey> IGOFGJPEDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<TVal> NNKIJDNNMLD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DLIFFIGOOBE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D52D0", VA = "0x1808D5ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int HJFDOBNMJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x96EF30", Offset = "0x96E330", VA = "0x18096EF30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA95CF0", Offset = "0xA950F0", VA = "0x180A95CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x46794A0", Offset = "0x46788A0", VA = "0x1846794A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal int OJLOGLLLHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4192C70", Offset = "0x4192070", VA = "0x184192C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ICollection<TVal> HHBEAJGHAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4679650", Offset = "0x4678A50", VA = "0x184679650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ICollection<TKey> IDictionary<TKey, TVal>.MDBPPLJFNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4676A60", Offset = "0x4675E60", VA = "0x184676A60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DNNGBKHPAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TVal EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4679540", Offset = "0x4678940", VA = "0x184679540", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x46796E0", Offset = "0x4678AE0", VA = "0x1846796E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4669F10", Offset = "0x4669310", VA = "0x184669F10")]
	private bool AALGCBEJJCF(int GNOHMAFCFKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x46726E0", Offset = "0x4671AE0", VA = "0x1846726E0")]
	private void KCGJCKLFJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x46780E0", Offset = "0x46774E0", VA = "0x1846780E0")]
	public KHPJJBFPLGK(int GNOHMAFCFKD, [Optional] MGHPKBNJLDG? KHDIJDKEJNF, [Optional] IEqualityComparer<TKey>? NACDEAONMGC, [Optional] PCEODJNFLFC? EBLELOPEDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x46778C0", Offset = "0x4676CC0", VA = "0x1846778C0")]
	public KHPJJBFPLGK(TimeSpan PDMPMELMPJP, [Optional] IEqualityComparer<TKey>? NACDEAONMGC, [Optional] PCEODJNFLFC? EBLELOPEDOC, [Optional] EHICLJOCAMK? JOENEDFCOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4678060", Offset = "0x4677460", VA = "0x184678060")]
	public KHPJJBFPLGK(int GNOHMAFCFKD, TimeSpan PDMPMELMPJP, [Optional] IEqualityComparer<TKey>? NACDEAONMGC, [Optional] PCEODJNFLFC? EBLELOPEDOC, [Optional] EHICLJOCAMK? JOENEDFCOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4678640", Offset = "0x4677A40", VA = "0x184678640")]
	public KHPJJBFPLGK(int GNOHMAFCFKD, MGHPKBNJLDG? KHDIJDKEJNF, TimeSpan PDMPMELMPJP, [Optional] IEqualityComparer<TKey>? NACDEAONMGC, [Optional] PCEODJNFLFC? EBLELOPEDOC, [Optional] EHICLJOCAMK? JOENEDFCOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x46748C0", Offset = "0x4673CC0", VA = "0x1846748C0", Slot = "21")]
	public bool MEKJAKFMNFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x466F1A0", Offset = "0x466E5A0", VA = "0x18466F1A0", Slot = "22")]
	public bool HCNIFBLHKBF(int BGDDCGNLDBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x466CF70", Offset = "0x466C370", VA = "0x18466CF70")]
	private bool CJIBBKBCMPC(int BGDDCGNLDBK, ICHGLMJLOAP OCIFOIBHPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4672FC0", Offset = "0x46723C0", VA = "0x184672FC0")]
	public void KJLAKIGFJAC(TKey LDCKBFKFIKC, TVal HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x466A940", Offset = "0x4669D40", VA = "0x18466A940", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FKIFNEPLBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x466A9F0", Offset = "0x4669DF0", VA = "0x18466A9F0", Slot = "9")]
	public void Add(TKey LDCKBFKFIKC, TVal HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x466D730", Offset = "0x466CB30", VA = "0x18466D730", Slot = "8")]
	public bool ContainsKey(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x46762F0", Offset = "0x46756F0", VA = "0x1846762F0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x46760E0", Offset = "0x46754E0", VA = "0x1846760E0", Slot = "10")]
	public bool Remove(TKey LDCKBFKFIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x46766B0", Offset = "0x4675AB0", VA = "0x1846766B0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> FKIFNEPLBJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4673940", Offset = "0x4672D40", VA = "0x184673940")]
	private bool KKMAENCFFBP(TKey LDCKBFKFIKC, [Out] TVal HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4669F60", Offset = "0x4669360", VA = "0x184669F60")]
	private TVal AFFELPLAAIM(TKey LKMCKCKNIPH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4676D10", Offset = "0x4676110", VA = "0x184676D10", Slot = "11")]
	public bool TryGetValue(TKey LKMCKCKNIPH, [Out] TVal HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x466D590", Offset = "0x466C990", VA = "0x18466D590", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x466DF20", Offset = "0x466D320", VA = "0x18466DF20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CHDCMIMONFN, int ECPOGOHOPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x46719A0", Offset = "0x4670DA0", VA = "0x1846719A0")]
	private void JCFMJPJCBLC(TKey LDCKBFKFIKC, TVal BBFFJMPBBGO, ICHGLMJLOAP OCIFOIBHPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4672230", Offset = "0x4671630", VA = "0x184672230")]
	private bool JGLCFIKIIJC(OBEMEKEBBGJ PNMJMHFHCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x466FEA0", Offset = "0x466F2A0", VA = "0x18466FEA0")]
	private void HNKOKMMJCPA(LinkedListNode<OBEMEKEBBGJ> JIOBNCAJGML, TVal CNBOFDKAIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4675B10", Offset = "0x4674F10", VA = "0x184675B10")]
	private void OAIFNLOOELA(TKey LDCKBFKFIKC, TVal HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4674480", Offset = "0x4673880", VA = "0x184674480")]
	private void LBDOHHIKFLN(OBEMEKEBBGJ PNMJMHFHCOB, TVal CNBOFDKAIKM, int DOPCGIEFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x466ECD0", Offset = "0x466E0D0", VA = "0x18466ECD0", Slot = "19")]
	[IteratorStateMachine(typeof(KHPJJBFPLGK<, >.IPOHFPOGAAA))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4676AB0", Offset = "0x4675EB0", VA = "0x184676AB0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum ICHGLMJLOAP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class NFADAHBLLEL<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly TKey CGPHJCKFEIF;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4A6DC00", Offset = "0x4A6D000", VA = "0x184A6DC00")]
	public NFADAHBLLEL(TKey FPJMEPBGBNF, Exception AMBPMFFJDPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class DLHOMJLLNJP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x639C460", Offset = "0x639B860", VA = "0x18639C460")]
	public DLHOMJLLNJP(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class ICLEEDLMCMC<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class EFIFMNNOBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public ICLEEDLMCMC<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EFIFMNNOBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0CD0", Offset = "0x3CC00D0", VA = "0x183CC0CD0")]
		internal Task<TResource> AFGIJNAFMLB(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct DKGGJKABBKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public ICLEEDLMCMC<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BDB0", Offset = "0x5E7B1B0", VA = "0x185E7BDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C1D0", Offset = "0x5E7B5D0", VA = "0x185E7C1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct HNENILNMKAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4272620", Offset = "0x4271A20", VA = "0x184272620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4273100", Offset = "0x4272500", VA = "0x184273100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly MPMAONLJHNL<TId, Task<TResource>> ANMIKLJIDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> PEAAJMMEKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? OAEHBHOMCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Action<TResource>? PFEBFPCLOBK;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x432EEE0", Offset = "0x432E2E0", VA = "0x18432EEE0")]
	public ICLEEDLMCMC(int FDBBIFPCBFE = 0, [Optional] IEqualityComparer<TId>? NAEIDILCHBE, [Optional] Func<TId, CancellationToken, Task<TResource>>? DFLAHMIBANG, [Optional] Action<TResource>? AINDEEAJMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x432E150", Offset = "0x432D550", VA = "0x18432E150")]
	public PMAODDEEHAH<Task<TResource>> IKNLOMCGOEA(TId LPMIIFILJPI, [Optional] Func<TId, CancellationToken, Task<TResource>>? DFLAHMIBANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x432DD00", Offset = "0x432D100", VA = "0x18432DD00")]
	private void EAPJADGDHFK(Task<TResource> LCFJPCOMAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x432E9F0", Offset = "0x432DDF0", VA = "0x18432E9F0")]
	[AsyncStateMachine(typeof(ICLEEDLMCMC<, >.DKGGJKABBKD))]
	private Task LABOAJMNKBG(Task<TResource> LCFJPCOMAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x432E890", Offset = "0x432DC90", VA = "0x18432E890")]
	public void JOJFADPOLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x432E710", Offset = "0x432DB10", VA = "0x18432E710")]
	public MPMAONLJHNL<TId, Task<TResource>>.ALHNEDALAEF JDJKPBEKJIJ()
	{
		return default(MPMAONLJHNL<TId, Task<TResource>>.ALHNEDALAEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x432ECF0", Offset = "0x432E0F0", VA = "0x18432ECF0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x432ECF0", Offset = "0x432E0F0", VA = "0x18432ECF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x432D970", Offset = "0x432CD70", VA = "0x18432D970")]
	[AsyncStateMachine(typeof(ICLEEDLMCMC<, >.HNENILNMKAG))]
	[CompilerGenerated]
	internal static Task CAFHLDGBAPA(Task<TResource> LCFJPCOMAFL, CancellationTokenSource EMGKMFIHCID, Dictionary<Task<TResource>, CancellationTokenSource> AJKFGBMDMHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MPMAONLJHNL<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class GDPLAADLJAB : IEquatable<GDPLAADLJAB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly TValue GFHLLJBPNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int PPNCEBBHCMM;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xD2E870", Offset = "0xD2DC70", VA = "0x180D2E870")]
		public GDPLAADLJAB(TValue HCPAOILCJCB, int DCPNIMMKCGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4190D90", Offset = "0x4190190", VA = "0x184190D90", Slot = "4")]
		public bool Equals(GDPLAADLJAB? BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4190E20", Offset = "0x4190220", VA = "0x184190E20", Slot = "0")]
		public override bool Equals(object? NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4190ED0", Offset = "0x41902D0", VA = "0x184190ED0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct ALHNEDALAEF : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Dictionary<TKey, GDPLAADLJAB>.Enumerator CAHIMBEBGJJ;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x42EBF60", Offset = "0x42EB360", VA = "0x1842EBF60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public (TKey Key, TValue Value, int RefCount) DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x42EC3D0", Offset = "0x42EB7D0", VA = "0x1842EC3D0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x42EC150", Offset = "0x42EB550", VA = "0x1842EC150")]
		public ALHNEDALAEF(MPMAONLJHNL<TKey, TValue> INNPOFPBAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x42EBBA0", Offset = "0x42EAFA0", VA = "0x1842EBBA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x42EBC20", Offset = "0x42EB020", VA = "0x1842EBC20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x42EBCA0", Offset = "0x42EB0A0", VA = "0x1842EBCA0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class HGMELAKCHDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public MPMAONLJHNL<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public GDPLAADLJAB refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HGMELAKCHDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x424AA00", Offset = "0x4249E00", VA = "0x18424AA00")]
		internal void AFGIJNAFMLB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<TKey, GDPLAADLJAB> ILNDPKLNEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Func<TKey, TValue>? HMPGIBJIINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Action<TValue>? FFAFHAPDAGB;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4A1D0A0", Offset = "0x4A1C4A0", VA = "0x184A1D0A0")]
	public MPMAONLJHNL(int FDBBIFPCBFE = 0, [Optional] IEqualityComparer<TKey>? NACDEAONMGC, [Optional] Func<TKey, TValue>? OOIBDNOPOBC, [Optional] Action<TValue>? FHKIKONGDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4A1C030", Offset = "0x4A1B430", VA = "0x184A1C030")]
	public PMAODDEEHAH<TValue> IKNLOMCGOEA(TKey LDCKBFKFIKC, [Optional] Func<TKey, TValue>? FEKLOBKPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4A1CAE0", Offset = "0x4A1BEE0", VA = "0x184A1CAE0")]
	private void OLENLPMJDLF(TKey LDCKBFKFIKC, GDPLAADLJAB MAKBFOKOEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4A1C420", Offset = "0x4A1B820", VA = "0x184A1C420")]
	public void JOJFADPOLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4A1C360", Offset = "0x4A1B760", VA = "0x184A1C360")]
	public ALHNEDALAEF JDJKPBEKJIJ()
	{
		return default(ALHNEDALAEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4A1CF50", Offset = "0x4A1C350", VA = "0x184A1CF50", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4A1CF50", Offset = "0x4A1C350", VA = "0x184A1CF50", Slot = "5")]
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
