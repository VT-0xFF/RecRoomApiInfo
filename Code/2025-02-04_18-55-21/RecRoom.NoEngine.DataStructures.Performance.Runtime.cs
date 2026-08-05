using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73884D0", Offset = "0x73872D0", VA = "0x1873884D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GPDMPBMKLLO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3094C60", Offset = "0x3093A60", VA = "0x183094C60")]
	public static HGHMKAOFCFL<T> KGAFMFONOMH<T>(this T[] DJAJDIFOIHP) where T : notnull
	{
		return default(HGHMKAOFCFL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class IBPDNOOFNEH<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ICNNLNCPOAH<T> IFFADEBAIFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46CBA70", Offset = "0x46CA870", VA = "0x1846CBA70", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x46CBBE0", Offset = "0x46CA9E0", VA = "0x1846CBBE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x46CBAB0", Offset = "0x46CA8B0", VA = "0x1846CBAB0")]
	public static IBPDNOOFNEH<T> MKHEJJEDOII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x46CBCA0", Offset = "0x46CAAA0", VA = "0x1846CBCA0")]
	internal IBPDNOOFNEH([In] ICNNLNCPOAH<T> MNCBDJMAFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46CB9E0", Offset = "0x46CA7E0", VA = "0x1846CB9E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x46CB9A0", Offset = "0x46CA7A0", VA = "0x1846CB9A0")]
	public void DJHKOJKKMII(int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46CBA20", Offset = "0x46CA820", VA = "0x1846CBA20", Slot = "8")]
	public ICNNLNCPOAH<T>.DCILCAAAPKJ GetEnumerator()
	{
		return default(ICNNLNCPOAH<T>.DCILCAAAPKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46CBC20", Offset = "0x46CAA20", VA = "0x1846CBC20", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46CBC20", Offset = "0x46CAA20", VA = "0x1846CBC20", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MPMMLMNCAMA<T, U> : IEnumerable<T>, IEnumerable where U : IKKKIJJJEDP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U EKHDCNBFLPL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24E0CD0", Offset = "0x24DFAD0", VA = "0x1824E0CD0")]
	internal MPMMLMNCAMA([In] U NCNLLJPEKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4CB21B0", Offset = "0x4CB0FB0", VA = "0x184CB21B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4CB21B0", Offset = "0x4CB0FB0", VA = "0x184CB21B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NPIIAPCJECN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x35B1FC0", Offset = "0x35B0DC0", VA = "0x1835B1FC0")]
	public static MPMMLMNCAMA<T, U> MKHEJJEDOII<U>([In] U DJAJDIFOIHP) where U : IKKKIJJJEDP<T>
	{
		return default(MPMMLMNCAMA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CCJJBDDAFNK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U EKHDCNBFLPL;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24E0CD0", Offset = "0x24DFAD0", VA = "0x1824E0CD0")]
	internal CCJJBDDAFNK([In] U NCNLLJPEKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CB21B0", Offset = "0x4CB0FB0", VA = "0x184CB21B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4CB21B0", Offset = "0x4CB0FB0", VA = "0x184CB21B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GMKKNJAMCFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35B1FC0", Offset = "0x35B0DC0", VA = "0x1835B1FC0")]
	public static CCJJBDDAFNK<T, U> MKHEJJEDOII<U>([In] U DJAJDIFOIHP) where U : IEnumerator<T>
	{
		return default(CCJJBDDAFNK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HIGEKBNBLFG
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32BDC60", Offset = "0x32BCA60", VA = "0x1832BDC60")]
	public static string BDDKFLKCGNA<T>(this IEnumerable<T> DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32C2EB0", Offset = "0x32C1CB0", VA = "0x1832C2EB0")]
	public static string IFHNAHBLBCG<T>(this IEnumerable<T> DJAJDIFOIHP, string DIFLBIFFGIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NFGIPKFBEIH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3457560", Offset = "0x3456360", VA = "0x183457560")]
	public static bool NMMDBPMJDIN<TSourceEnumerator, TSource>(this TSourceEnumerator DJAJDIFOIHP, [In] TSource MJONLBMPPCK) where TSourceEnumerator : IKKKIJJJEDP<TSource> where TSource : DOBJOHBJOOL<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3457090", Offset = "0x3455E90", VA = "0x183457090")]
	public static int CPIDNMPAHMK<TSourceEnumerator, TSource>(this TSourceEnumerator DJAJDIFOIHP, [In] TSource IPHILEOFJLB) where TSourceEnumerator : IKKKIJJJEDP<TSource> where TSource : DOBJOHBJOOL<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34572F0", Offset = "0x34560F0", VA = "0x1834572F0")]
	public static int GBAJKKPEBNI<TSourceEnumerator, TSource>(this TSourceEnumerator DJAJDIFOIHP, [In] TSource IPHILEOFJLB) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IKKKIJJJEDP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ABCAFDPDGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LJLOONCMMCG<T> : IKKKIJJJEDP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct MLMCKAIABPP<T, U> : IEnumerable<T>, IEnumerable where U : LJLOONCMMCG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U EKHDCNBFLPL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2220", Offset = "0x4CB1020", VA = "0x184CB2220")]
	internal MLMCKAIABPP([In] U NCNLLJPEKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x409EBA0", Offset = "0x409D9A0", VA = "0x18409EBA0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2120", Offset = "0x4CB0F20", VA = "0x184CB2120", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2120", Offset = "0x4CB0F20", VA = "0x184CB2120", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IDBLHFIFKDE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35B2140", Offset = "0x35B0F40", VA = "0x1835B2140")]
	public static MLMCKAIABPP<T, U> MKHEJJEDOII<U>([In] U DJAJDIFOIHP) where U : LJLOONCMMCG<T>
	{
		return default(MLMCKAIABPP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct HGHMKAOFCFL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LMMIAMLCJHJ : IKKKIJJJEDP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] MDBDHKGJAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int JFGKLPPOBEB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4AAD650", Offset = "0x4AAC450", VA = "0x184AAD650", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4AAD020", Offset = "0x4AABE20", VA = "0x184AAD020", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4AAD2F0", Offset = "0x4AAC0F0", VA = "0x184AAD2F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAFEA80", Offset = "0xAFD880", VA = "0x180AFEA80")]
		private LMMIAMLCJHJ(T[] DJAJDIFOIHP, int KNCPCNBMDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x43A4E30", Offset = "0x43A3C30", VA = "0x1843A4E30")]
		public static LMMIAMLCJHJ MKHEJJEDOII(T[] DJAJDIFOIHP)
		{
			return default(LMMIAMLCJHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2534420", Offset = "0x2533220", VA = "0x182534420", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2533E10", Offset = "0x2532C10", VA = "0x182533E10", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] AALJPKDCOPJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x456FB10", Offset = "0x456E910", VA = "0x18456FB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x33700F0", Offset = "0x336EEF0", VA = "0x1833700F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	internal HGHMKAOFCFL(T[] EOOCBMPNEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x456FB30", Offset = "0x456E930", VA = "0x18456FB30")]
	public static HGHMKAOFCFL<T> JBBIPKIKKBB()
	{
		return default(HGHMKAOFCFL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
	public IEnumerable<T> ALMLDFAKCGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x456FD30", Offset = "0x456EB30", VA = "0x18456FD30")]
	public ReadOnlySpan<T> LLLFBOLNPDG()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x456FC00", Offset = "0x456EA00", VA = "0x18456FC00")]
	public MPMMLMNCAMA<T, HGHMKAOFCFL<T>.LMMIAMLCJHJ> JPKJBHCGJIN()
	{
		return default(MPMMLMNCAMA<T, LMMIAMLCJHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x456FA70", Offset = "0x456E870", VA = "0x18456FA70")]
	public LMMIAMLCJHJ EFJIMOIGIOA()
	{
		return default(LMMIAMLCJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x456FDD0", Offset = "0x456EBD0", VA = "0x18456FDD0")]
	public IEnumerator<T> NAPBKLICNNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x456FE50", Offset = "0x456EC50", VA = "0x18456FE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PDEDKFHNLCD
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x30F23B0", Offset = "0x30F11B0", VA = "0x1830F23B0")]
	public static HGHMKAOFCFL<T> DAPIAPIBJIO<T>(params T[] EOOCBMPNEML) where T : notnull
	{
		return default(HGHMKAOFCFL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7388550", Offset = "0x7387350", VA = "0x187388550")]
	public static Stream NCNGIHJKJNM(this HGHMKAOFCFL<byte> DJAJDIFOIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(ICNNLNCPOAH<>.DAPBBHECADH))]
public struct ICNNLNCPOAH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct DCILCAAAPKJ : LJLOONCMMCG<T>, IKKKIJJJEDP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] CHLKNLAICJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int DCFGOEOFJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int JFGKLPPOBEB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x60F4D70", Offset = "0x60F3B70", VA = "0x1860F4D70", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T PNAKNGBDAPL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x60F4280", Offset = "0x60F3080", VA = "0x1860F4280")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T KPKGELKMGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x60F4470", Offset = "0x60F3270", VA = "0x1860F4470", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x60F4740", Offset = "0x60F3540", VA = "0x1860F4740", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x60F49E0", Offset = "0x60F37E0", VA = "0x1860F49E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4D069A0", Offset = "0x4D057A0", VA = "0x184D069A0")]
		internal DCILCAAAPKJ(T[] CMEOIDEONPB, int BMGBDLLODJK, int KNCPCNBMDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60F45B0", Offset = "0x60F33B0", VA = "0x1860F45B0")]
		public static DCILCAAAPKJ MKHEJJEDOII(ICNNLNCPOAH<T> DJAJDIFOIHP)
		{
			return default(DCILCAAAPKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x405E210", Offset = "0x405D010", VA = "0x18405E210", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4059790", Offset = "0x4058590", VA = "0x184059790", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct EPHMAGKOEIN : IKKKIJJJEDP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DCILCAAAPKJ EKHDCNBFLPL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4008A50", Offset = "0x4007850", VA = "0x184008A50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4008690", Offset = "0x4007490", VA = "0x184008690", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x40087D0", Offset = "0x40075D0", VA = "0x1840087D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x24E0CD0", Offset = "0x24DFAD0", VA = "0x1824E0CD0")]
		private EPHMAGKOEIN([In] DCILCAAAPKJ NCNLLJPEKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4008560", Offset = "0x4007360", VA = "0x184008560")]
		public static EPHMAGKOEIN MKHEJJEDOII([In] ICNNLNCPOAH<T> DJAJDIFOIHP)
		{
			return default(EPHMAGKOEIN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4008610", Offset = "0x4007410", VA = "0x184008610", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4008650", Offset = "0x4007450", VA = "0x184008650", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4008520", Offset = "0x4007320", VA = "0x184008520", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class DAPBBHECADH
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] CHLKNLAICJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int DCFGOEOFJPH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x46D11E0", Offset = "0x46CFFE0", VA = "0x1846D11E0")]
	public static ICNNLNCPOAH<T> MKHEJJEDOII()
	{
		return default(ICNNLNCPOAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46D1290", Offset = "0x46D0090", VA = "0x1846D1290")]
	public static ICNNLNCPOAH<T> OFEHALKOHMM(int MLAKJOPIGGN)
	{
		return default(ICNNLNCPOAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAFEA80", Offset = "0xAFD880", VA = "0x180AFEA80")]
	internal ICNNLNCPOAH(T[] CMEOIDEONPB, int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46D1350", Offset = "0x46D0150", VA = "0x1846D1350", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KCPILIEGEMC
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int BCMAELPDNNI<TCtx, T>([In] TCtx OHLKKDIOCBG, T NMOPBJNEFKL, T KCJDGOIFCIF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3376FA0", Offset = "0x3375DA0", VA = "0x183376FA0")]
	public static void MJMAPJMIAED<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3377F40", Offset = "0x3376D40", VA = "0x183377F40")]
	public static string PFINFJNPLEH<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
	public static T[] LAGMKMHFFNK<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2535AA0", Offset = "0x25348A0", VA = "0x182535AA0")]
	public static T ANFJBBFMPMK<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP, int JELBMBFLBOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2535AA0", Offset = "0x25348A0", VA = "0x182535AA0")]
	public static T GOELIMIGNPD<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int JELBMBFLBOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3377080", Offset = "0x3375E80", VA = "0x183377080")]
	public static T MKAJKOFOGBI<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP, int JELBMBFLBOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3372F90", Offset = "0x3371D90", VA = "0x183372F90")]
	public static void DJKOKNNCNMK<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int JELBMBFLBOP, [In] T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3373920", Offset = "0x3372720", VA = "0x183373920")]
	public static void EAFOBHDECCG<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int JELBMBFLBOP, T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2533EA0", Offset = "0x2532CA0", VA = "0x182533EA0")]
	public static int JKBNBILBMCJ<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3376810", Offset = "0x3375610", VA = "0x183376810")]
	public static ReadOnlySpan<T> LLLFBOLNPDG<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3373790", Offset = "0x3372590", VA = "0x183373790")]
	public static T[] EADDDJOEJPE<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x33767D0", Offset = "0x33755D0", VA = "0x1833767D0")]
	public static T KPPNPAMGPLG<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3377260", Offset = "0x3376060", VA = "0x183377260")]
	public static T[] MPHGGGOKBOE<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3376ED0", Offset = "0x3375CD0", VA = "0x183376ED0")]
	public static HGHMKAOFCFL<T> MIAEBBKCFIG<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return default(HGHMKAOFCFL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3376B20", Offset = "0x3375920", VA = "0x183376B20")]
	public static void MDGAONDGEMG<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, [In] T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3375F60", Offset = "0x3374D60", VA = "0x183375F60")]
	public static void GNCFNDENIBN<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3370380", Offset = "0x336F180", VA = "0x183370380")]
	public static void DCGPLIBNGEG<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int KNCPCNBMDNF, [In] T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3376170", Offset = "0x3374F70", VA = "0x183376170")]
	public static void HGLLJACLIHB<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int KNCPCNBMDNF, [In] ICNNLNCPOAH<T> DCFFMJLJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3376410", Offset = "0x3375210", VA = "0x183376410")]
	public static void JLHIOIHGLND<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int KNCPCNBMDNF, T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3376230", Offset = "0x3375030", VA = "0x183376230")]
	public static void HNFFLMKNOKC<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x337BB40", Offset = "0x337A940", VA = "0x18337BB40")]
	public static T PLFNLDNBHOK<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x33708B0", Offset = "0x336F6B0", VA = "0x1833708B0")]
	public static void DJHKOJKKMII<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3373C80", Offset = "0x3372A80", VA = "0x183373C80")]
	private static void FJGODDCIPGC<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, int MLAKJOPIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3377310", Offset = "0x3376110", VA = "0x183377310")]
	public static void NCEIDOKFHPG<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3376570", Offset = "0x3375370", VA = "0x183376570")]
	public static ICNNLNCPOAH<T> KPIDJMMGJOI<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP, JNCHFGKJAPD<T, T> EBIHAANBLKE)
	{
		return default(ICNNLNCPOAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3376270", Offset = "0x3375070", VA = "0x183376270")]
	public static bool IEINLEAGPOE<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, T IPHILEOFJLB) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3375E20", Offset = "0x3374C20", VA = "0x183375E20")]
	public static bool GNBBKAAJDBM<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP, [In] T IPHILEOFJLB) where T : DOBJOHBJOOL<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3377490", Offset = "0x3376290", VA = "0x183377490")]
	public static bool OBOEGBKEDDJ<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x33705B0", Offset = "0x336F3B0", VA = "0x1833705B0")]
	public static bool DDDEEEGBGIO<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP, int JELBMBFLBOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3377210", Offset = "0x3376010", VA = "0x183377210")]
	public static void MNJGFFMEOLI<T, TCtx>(this ICNNLNCPOAH<T> DJAJDIFOIHP, [In] TCtx OHLKKDIOCBG, BCMAELPDNNI<TCtx, T> FEMACHAKACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3375D20", Offset = "0x3374B20", VA = "0x183375D20")]
	private static void GHCCGMMDGGG<T, TCtx>(ICNNLNCPOAH<T> DJAJDIFOIHP, [In] TCtx OHLKKDIOCBG, BCMAELPDNNI<TCtx, T> FEMACHAKACN, int CEMDGBFKBBJ, int BMDPNFIOKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x33774A0", Offset = "0x33762A0", VA = "0x1833774A0")]
	private static int ODGKEHBFLON<T, TCtx>(ICNNLNCPOAH<T> DJAJDIFOIHP, [In] TCtx OHLKKDIOCBG, BCMAELPDNNI<TCtx, T> FEMACHAKACN, int CEMDGBFKBBJ, int BMDPNFIOKPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x30950F0", Offset = "0x3093EF0", VA = "0x1830950F0")]
	public static ICNNLNCPOAH<T>.EPHMAGKOEIN NAPBKLICNNH<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return default(ICNNLNCPOAH<T>.EPHMAGKOEIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x30950F0", Offset = "0x3093EF0", VA = "0x1830950F0")]
	public static ICNNLNCPOAH<T>.DCILCAAAPKJ HPDDCFDDJED<T>(this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return default(ICNNLNCPOAH<T>.DCILCAAAPKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3370060", Offset = "0x336EE60", VA = "0x183370060")]
	public static MPMMLMNCAMA<T, ICNNLNCPOAH<T>.EPHMAGKOEIN> ALINGAGCCNO<T>([In] this ICNNLNCPOAH<T> DJAJDIFOIHP)
	{
		return default(MPMMLMNCAMA<T, ICNNLNCPOAH<T>.EPHMAGKOEIN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class INBEDBIGGJO
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3326EA0", Offset = "0x3325CA0", VA = "0x183326EA0")]
	public static T[] IDEDDJILLCO<T>(int IECADCKMGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	public static void PGPJNIPLFAL<T>(T[] EOOCBMPNEML)
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
