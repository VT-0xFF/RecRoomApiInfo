using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA1530", Offset = "0x6EA0930", VA = "0x186EA1530")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JFMLJEMJMEH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] BDGOGKPINMM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0A80", Offset = "0x6E9FE80", VA = "0x186EA0A80")]
	public static bool OEAJJDMIMNL(string FMAJCGNCFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EA09B0", Offset = "0x6E9FDB0", VA = "0x186EA09B0")]
	private static bool BCBHIDBNDJI(string MOKGCFCFCPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0860", Offset = "0x6E9FC60", VA = "0x186EA0860")]
	public static bool BCBHIDBNDJI(Exception LGAEDPBIIBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0530", Offset = "0x6E9F930", VA = "0x186EA0530")]
	public static string ADMEJOOLHPB(string CKEJEIFKOJA, string MPHJCCJMKLK = "", bool DILEAJGCFHN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EDLLKABIMND
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F030", Offset = "0x6E9E430", VA = "0x186E9F030")]
	public static string NEHMCEIDONP(this Guid GPJCGLBMIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F0E0", Offset = "0x6E9E4E0", VA = "0x186E9F0E0")]
	public static string NEHMCEIDONP(this byte[] FAHBHOHHIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EF60", Offset = "0x6E9E360", VA = "0x186E9EF60")]
	public static byte[] KONEBLEMIBP(string KEHGCHBMOAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MMAEKEHOJOG
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int NMAMGEDLOGJ<T>([In] T JKMLNPBBJIG, [In] T JDJGFJGMEAK);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class AKBAJIGIPGG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct PDJBFHDCEKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int PGAHHGFJKBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int HILPPJEFBDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool CLPHEOOPKHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int NBEKJAGBDGI;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x4AD6B00", Offset = "0x4AD5F00", VA = "0x184AD6B00")]
			public PDJBFHDCEKF(int PGAHHGFJKBL, int HILPPJEFBDJ, bool CLPHEOOPKHG)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] BKPENGJGCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] AHIBFMFHFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly NMAMGEDLOGJ<T> OKDIHAHMBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int LDIDGKALJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> EDPDIJCJKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int PBBDCHKNIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly PDJBFHDCEKF[] DNEBDMMFIKJ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4008D30", Offset = "0x4008130", VA = "0x184008D30")]
		public AKBAJIGIPGG(T[] BKPENGJGCIB, NMAMGEDLOGJ<T> OKDIHAHMBLG, int LDIDGKALJJF, Func<bool> EDPDIJCJKBN, T[]? COFDADLGLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40086E0", Offset = "0x4007AE0", VA = "0x1840086E0")]
		public bool CDECNLKHJPG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U IALIKCBMMKO<T, U>(int IJIOPDEHFCK, int PGBOPMBMLCJ, [In] ReadOnlySpan<T> BMKAKKMHAJB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F426A0", Offset = "0x2F41AA0", VA = "0x182F426A0")]
	public static T[] FIBLGNNGKDA<T>(int IKJKAFPPDBP, T BPDKDONPBCO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F43EC0", Offset = "0x2F432C0", VA = "0x182F43EC0")]
	public static void MHOBDKHOBFN<T>(this T[] MJEBPLBCAHJ, T BPDKDONPBCO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2F42620", Offset = "0x2F41A20", VA = "0x182F42620")]
	public static void FFJPNPEEBOA<T>(this T[] IGGIDMIPNHL, int PGOOPNPHNCA, int EIMDGAJLOMD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2F42060", Offset = "0x2F41460", VA = "0x182F42060")]
	private static void BFNCMELBLCI<T>(this T[] MCPMOAEEEOJ, int GIBEFFDFGAE, int KPFPJJMHKBF, T[] KNLMODPGFOA, int OIFPACMPKNH, int HPFHPGPKIFB, T[] IPNDOKDOGDG, int OPBINNCAGDI, NMAMGEDLOGJ<T> OKDIHAHMBLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2F42840", Offset = "0x2F41C40", VA = "0x182F42840")]
	public static void GBPLGJAIDAI<T>(this T[] MCPMOAEEEOJ, int PGAHHGFJKBL, int HMELIAGANNM, NMAMGEDLOGJ<T> OKDIHAHMBLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2F41FA0", Offset = "0x2F413A0", VA = "0x182F41FA0")]
	public static AKBAJIGIPGG<T> AHCKMFFNMHI<T>(this T[] MCPMOAEEEOJ, NMAMGEDLOGJ<T> OKDIHAHMBLG, int LDIDGKALJJF, Func<bool> EDPDIJCJKBN, [Optional] T[]? COFDADLGLJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F43BD0", Offset = "0x2F42FD0", VA = "0x182F43BD0")]
	public static T[] JLCMPKEBCDB<T>(this T[] IGGIDMIPNHL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F42420", Offset = "0x2F41820", VA = "0x182F42420")]
	public static T[] DLEDOIJGDFI<T>(this T[] LCIFMKOCJBE, T ECODPECAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F43300", Offset = "0x2F42700", VA = "0x182F43300")]
	public static T[] JIEGFGFNGJC<T>(this T[] LCIFMKOCJBE, int HAJICDLBEKC, T ECODPECAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2F42C50", Offset = "0x2F42050", VA = "0x182F42C50")]
	public static T[] HEFHIMKNFFJ<T>(this T[] LCIFMKOCJBE, int HAJICDLBEKC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F43C20", Offset = "0x2F43020", VA = "0x182F43C20")]
	public static T[] MGDIDFLBJCJ<T>(this T[] LCIFMKOCJBE, int HAJICDLBEKC, T ECODPECAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F42D00", Offset = "0x2F42100", VA = "0x182F42D00")]
	public static U[] HPGDIIHCPEF<U, T>(this T[] JHBKFOICCJL, int IPEICNCCOBM, IALIKCBMMKO<T, U> DFFJBCDAFKJ) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0E30", Offset = "0x6EA0230", VA = "0x186EA0E30")]
	public static byte[] EKEMFIDKCLD(this byte[] MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA10C0", Offset = "0x6EA04C0", VA = "0x186EA10C0")]
	public static byte[] GKNBHIKBBLH(this byte[] MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PLJPENPFKAB
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0E20", Offset = "0x6EA0220", VA = "0x186EA0E20")]
	public static byte PKFJBMOOFHB(this bool MCPMOAEEEOJ)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MGOFPCLEPFL
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0E20", Offset = "0x6EA0220", VA = "0x186EA0E20")]
	public static bool CPLEGCGLHKE(this byte MCPMOAEEEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BIDMHKJIOPP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2590", Offset = "0x2BF1990", VA = "0x182BF2590")]
	public static void FFAAAODPHAO<T>(this ICollection<T> MCPMOAEEEOJ, IEnumerable<T> HAIEMBCHPMF) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BAPLBNKKCAE
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6230", Offset = "0x2BE5630", VA = "0x182BE6230")]
	public static V DJJJFPBLINM<V, K>(this IDictionary<K, V> MCPMOAEEEOJ, [In] K OEOMDKHBDFI, [In] V EEPLCHCGAIN, Func<V, V, V> PLOOICBICGB) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6B60", Offset = "0x2BE5F60", VA = "0x182BE6B60")]
	public static void FILKLCMBLPJ<K, V>(this IDictionary<K, List<V>> MCPMOAEEEOJ, [In] K OEOMDKHBDFI, [In] V EEPLCHCGAIN) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8320", Offset = "0x2BE7720", VA = "0x182BE8320")]
	public static TVal LHBELHOKPEJ<TVal, TKey>(this IDictionary<TKey, TVal> BNDGLAGJGHN, [In] TKey OEOMDKHBDFI, [Optional][BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")] TVal BMLEAJPEFAD) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8160", Offset = "0x2BE7560", VA = "0x182BE8160")]
	public static TVal LHBELHOKPEJ<TVal, TKey>(this IDictionary<TKey, TVal> BNDGLAGJGHN, [In] TKey OEOMDKHBDFI, Func<TVal> LPBPBKJEJPF) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7180", Offset = "0x2BE6580", VA = "0x182BE7180")]
	public static TValue KAGMKJDDCCL<TValue, TKey>(this IDictionary<TKey, TValue> BNDGLAGJGHN, [In] TKey OEOMDKHBDFI, [Optional][In][BFAKOGDFABI("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue BMLEAJPEFAD)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7DF0", Offset = "0x2BE71F0", VA = "0x182BE7DF0")]
	public static V LGOEPCONOBN<V, K>(this IDictionary<K, V> MCPMOAEEEOJ, [In] K OEOMDKHBDFI) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7BC0", Offset = "0x2BE6FC0", VA = "0x182BE7BC0")]
	public static T2[] KHNNMIAFACK<T2, T1>(this Dictionary<T1, T2>.ValueCollection PEPEFILOFHK) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IGIDMOFPLMC
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool AHIOAGKFDCN<TArgs, T>([In] TArgs CJLBFJEOAOD, T HHDONFMCNBA);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U JHNDDEFECKF<TArg, U>([In] TArg NDJFIKMCNAE);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U NNBDFGENAHD<TArg, T, U>([In] TArg NDJFIKMCNAE, T FCFKEIFCDCL);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U FEPCAMEOMLF<TArg, T, U>([In] TArg NDJFIKMCNAE, IEnumerable<T> KODDIJIFMHA);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U LOBCENKHDOA<TArg, T, U>([In] TArg NDJFIKMCNAE, T FCFKEIFCDCL);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct MCMFIJNLHGN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x47B7C60", Offset = "0x47B7060", VA = "0x1847B7C60")]
		[BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) PBMIKEJGPAN(T IBFPPIHKANO)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x47B7C00", Offset = "0x47B7000", VA = "0x1847B7C00")]
		[BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) BBOIMJBCJGD(IEnumerable<T> BKMHNLEIBMA)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EHMNNILLJJB<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private ISet<T> set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ISet<T> <>3__set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private IEnumerable<T> source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IEnumerable<T> <>3__source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E50", Offset = "0x9B2250", VA = "0x1809B2E50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3B6DA60", Offset = "0x3B6CE60", VA = "0x183B6DA60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD3D620", Offset = "0xD3CA20", VA = "0x180D3D620")]
		[DebuggerHidden]
		public EHMNNILLJJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3B6DAA0", Offset = "0x3B6CEA0", VA = "0x183B6DAA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D030", Offset = "0x3B6C430", VA = "0x183B6D030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3B6CFE0", Offset = "0x3B6C3E0", VA = "0x183B6CFE0")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D9C0", Offset = "0x3B6CDC0", VA = "0x183B6D9C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D7C0", Offset = "0x3B6CBC0", VA = "0x183B6D7C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D980", Offset = "0x3B6CD80", VA = "0x183B6D980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class IBBPMPOPKBI<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IEnumerable<U> other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IEnumerable<U> <>3__other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private T with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public T <>3__with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private IEnumerator<T> <selfEnumerator>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<U> <otherEnumerator>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public IBBPMPOPKBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x42243F0", Offset = "0x42237F0", VA = "0x1842243F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x42235A0", Offset = "0x42229A0", VA = "0x1842235A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x42233A0", Offset = "0x42227A0", VA = "0x1842233A0")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4223550", Offset = "0x4222950", VA = "0x184223550")]
		private void FKMGMNDEOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4224350", Offset = "0x4223750", VA = "0x184224350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4224210", Offset = "0x4223610", VA = "0x184224210", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5A60", Offset = "0x3EA4E60", VA = "0x183EA5A60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OALLMODFCEO<T> : IEnumerable<(T, EAJEDGEMDCE<T>)>, IEnumerable, IEnumerator<(T, EAJEDGEMDCE<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, EAJEDGEMDCE<T> Next) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IEnumerator<T> <enumerator>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private (T, EAJEDGEMDCE<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3C1A790", Offset = "0x3C19B90", VA = "0x183C1A790", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, EAJEDGEMDCE<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x49FFD10", Offset = "0x49FF110", VA = "0x1849FFD10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x20FCBE0", Offset = "0x20FBFE0", VA = "0x1820FCBE0")]
		[DebuggerHidden]
		public OALLMODFCEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3B48AD0", Offset = "0x3B47ED0", VA = "0x183B48AD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x49FE950", Offset = "0x49FDD50", VA = "0x1849FE950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x49FE320", Offset = "0x49FD720", VA = "0x1849FE320")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x49FFBD0", Offset = "0x49FEFD0", VA = "0x1849FFBD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x49FFAF0", Offset = "0x49FEEF0", VA = "0x1849FFAF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, EAJEDGEMDCE<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5A60", Offset = "0x3EA4E60", VA = "0x183EA5A60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PBNBPMOFOEL<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private U <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private Func<MCMFIJNLHGN<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<MCMFIJNLHGN<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private IEnumerator<U> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public PBNBPMOFOEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4AD1B40", Offset = "0x4AD0F40", VA = "0x184AD1B40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4AD1660", Offset = "0x4AD0A60", VA = "0x184AD1660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4AD15C0", Offset = "0x4AD09C0", VA = "0x184AD15C0")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4AD1610", Offset = "0x4AD0A10", VA = "0x184AD1610")]
		private void FKMGMNDEOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4AD1AF0", Offset = "0x4AD0EF0", VA = "0x184AD1AF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3FAD7D0", Offset = "0x3FACBD0", VA = "0x183FAD7D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3FADDF0", Offset = "0x3FAD1F0", VA = "0x183FADDF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FLPJBHAJLGC<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FLPJBHAJLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3B8F130", Offset = "0x3B8E530", VA = "0x183B8F130")]
		internal bool ELFNGEBGJDM(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E6E0", Offset = "0x3F5DAE0", VA = "0x183F5E6E0")]
		internal bool ECOKMIJDHDM(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LBNEGNLDKLM<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private IEnumerator<T> <lhsIt>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IEnumerator<U> <rhsIt>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9220B0", Offset = "0x9214B0", VA = "0x1809220B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3FA3590", Offset = "0x3FA2990", VA = "0x183FA3590", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x20FCBE0", Offset = "0x20FBFE0", VA = "0x1820FCBE0")]
		[DebuggerHidden]
		public LBNEGNLDKLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x458CDD0", Offset = "0x458C1D0", VA = "0x18458CDD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x458D0E0", Offset = "0x458C4E0", VA = "0x18458D0E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x458D000", Offset = "0x458C400", VA = "0x18458D000", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5A60", Offset = "0x3EA4E60", VA = "0x183EA5A60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2E93AA0", Offset = "0x2E92EA0", VA = "0x182E93AA0")]
	public static bool PJAHNPHHCOJ<T, TArgs>(this IEnumerable<T> MCPMOAEEEOJ, [In] TArgs CJLBFJEOAOD, AHIOAGKFDCN<TArgs, T> MNAFDOMGIPE) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0420", Offset = "0x6E9F820", VA = "0x186EA0420")]
	public static bool PJAHNPHHCOJ(this IEnumerable<bool> MCPMOAEEEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2E90550", Offset = "0x2E8F950", VA = "0x182E90550")]
	public static U IBELECGNKBF<U, T>(this IEnumerable<T> MCPMOAEEEOJ, Func<U> FPOKKCOHHLF, Func<T, U> IBFPPIHKANO, Func<IEnumerable<T>, U> BKMHNLEIBMA) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2E8F6A0", Offset = "0x2E8EAA0", VA = "0x182E8F6A0")]
	public static bool FCKAPOIENJM<T, TArgs>(this IEnumerable<T> MCPMOAEEEOJ, [In] TArgs CJLBFJEOAOD, AHIOAGKFDCN<TArgs, T> MNAFDOMGIPE) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2E92150", Offset = "0x2E91550", VA = "0x182E92150")]
	public static U MBCOODMJPAP<U, T, TArg>(this IEnumerable<T> MCPMOAEEEOJ, [In] TArg NDJFIKMCNAE, JHNDDEFECKF<TArg, U> FPOKKCOHHLF, NNBDFGENAHD<TArg, T, U> IBFPPIHKANO, FEPCAMEOMLF<TArg, T, U> BKMHNLEIBMA) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2E92980", Offset = "0x2E91D80", VA = "0x182E92980")]
	public static IEnumerable<U> OIMGJGJKPCD<U, T, TArg>(this IEnumerable<T> MCPMOAEEEOJ, [In] TArg NDJFIKMCNAE, LOBCENKHDOA<TArg, T, U> OHGNLOKBMLN) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D510", Offset = "0x2E8C910", VA = "0x182E8D510")]
	public static IEnumerable<T> LEOPJBLOLFK<T>(params IEnumerable<T>[] KDGIFMCFCDI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D320", Offset = "0x2E8C720", VA = "0x182E8D320")]
	public static bool AILCDHJNNKK<T>(this IEnumerable<T> GHEAAGKLGOO, IEnumerable<T> KNLMODPGFOA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D510", Offset = "0x2E8C910", VA = "0x182E8D510")]
	public static IEnumerable<(TKey?, TValue?)>? BPMDNKHHPAH<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2E90330", Offset = "0x2E8F730", VA = "0x182E90330")]
	public static IEnumerable<T> HMNPGNCKFEH<T, TKey>(this IEnumerable<T> NCAEOPCKAMO, Func<T, TKey> PAPJLOKDKEN) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D99520", Offset = "0x2D98920", VA = "0x182D99520")]
	[IteratorStateMachine(typeof(EHMNNILLJJB<>))]
	public static IEnumerable<T> JOLIDJDJGKL<T>(this IEnumerable<T> GHEAAGKLGOO, ISet<T> NELNDAHMMFN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DDE8D0", Offset = "0x2DDDCD0", VA = "0x182DDE8D0")]
	[IteratorStateMachine(typeof(IBBPMPOPKBI<, >))]
	public static IEnumerable<T> CDGCDPKMAHG<T, U>(this IEnumerable<T> MCPMOAEEEOJ, IEnumerable<U> KNLMODPGFOA, [Optional][BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")] T BPDKDONPBCO) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B59F50", Offset = "0x2B59350", VA = "0x182B59F50")]
	public static T HLCFLIMOABH<T>(this IEnumerable<T> GHEAAGKLGOO, T BMLEAJPEFAD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E902B0", Offset = "0x2E8F6B0", VA = "0x182E902B0")]
	public static T HLCFLIMOABH<T>(this IEnumerable<T> GHEAAGKLGOO, T BMLEAJPEFAD, Func<T, bool> MNAFDOMGIPE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E8FA20", Offset = "0x2E8EE20", VA = "0x182E8FA20")]
	public static T? FDOCLHMKHPC<T>(this IEnumerable<T> MCPMOAEEEOJ, Func<T, bool> MNAFDOMGIPE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2E90B00", Offset = "0x2E8FF00", VA = "0x182E90B00")]
	public static void JJJPAKHAOBM<T>(this IEnumerable<T> MCPMOAEEEOJ, Action<T> ACIGGFPDBDE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D890", Offset = "0x2D6CC90", VA = "0x182D6D890")]
	[IteratorStateMachine(typeof(OALLMODFCEO<>))]
	public static IEnumerable<(T, EAJEDGEMDCE<T>)> ILFLBDEBHPK<T>(this IEnumerable<T> MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2E92EC0", Offset = "0x2E922C0", VA = "0x182E92EC0")]
	public static bool OKJJCOBGKEL<T>(this IEnumerable<T> MCPMOAEEEOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D510", Offset = "0x2E8C910", VA = "0x182E8D510")]
	public static IEnumerable<LJJMDOMAGEC<T>> KMIIBMECGKI<T>(this IEnumerable<T> MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E90510", Offset = "0x2E8F910", VA = "0x182E90510")]
	public static bool HNBCNJGJEII<T>(this IEnumerable<T> MCPMOAEEEOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2E8E110", Offset = "0x2E8D510", VA = "0x182E8E110")]
	public static IEnumerable<T> DONPJKKMEPD<T>(this IEnumerable<T>? MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D520", Offset = "0x2D6C920", VA = "0x182D6D520")]
	[IteratorStateMachine(typeof(PBNBPMOFOEL<, >))]
	public static IEnumerable<U> KADFDIEBECM<U, T>(this IEnumerable<T> MCPMOAEEEOJ, Func<MCMFIJNLHGN<U>, T, (bool Zero, U One, IEnumerable<U> Many)> ILKOJFJKGEA) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D510", Offset = "0x2E8C910", VA = "0x182E8D510")]
	public static IEnumerable<T> MINEKODJGFK<T>(this IEnumerable<IEnumerable<T>> MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E91CC0", Offset = "0x2E910C0", VA = "0x182E91CC0")]
	public static int KHDLNOPMMFP<T>(this IEnumerable<T> MCPMOAEEEOJ, int LAGELOLKBGF = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E92650", Offset = "0x2E91A50", VA = "0x182E92650")]
	public static bool MFONANCLMME<T>(this IEnumerable<T> MCPMOAEEEOJ, IEnumerable<T> KNLMODPGFOA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D7B0", Offset = "0x2E8CBB0", VA = "0x182E8D7B0")]
	public static IEnumerable<T> CEPIAMDDOCD<T>(this IEnumerable<T> MCPMOAEEEOJ, int ENBGDLHEOKD, int NJGNCGLIMPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E92FF0", Offset = "0x2E923F0", VA = "0x182E92FF0")]
	public static (IEnumerable<T>, IEnumerable<T>) PIFIFFEEEEB<T>(this IEnumerable<T> MCPMOAEEEOJ, Func<T, bool> HBGCPONFBFG) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2E8EA50", Offset = "0x2E8DE50", VA = "0x182E8EA50")]
	public static string FBININKGAIA<T>(this IEnumerable<T> MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D030", Offset = "0x2E8C430", VA = "0x182E8D030")]
	public static Dictionary<TKey?, TValue?>? AIFHMKKLEJH<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> GHEAAGKLGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D030", Offset = "0x2E8C430", VA = "0x182E8D030")]
	public static Dictionary<TKey?, TValue?>? AIFHMKKLEJH<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> GHEAAGKLGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E928C0", Offset = "0x2E91CC0", VA = "0x182E928C0")]
	public static List<T> MICLDNNFHGN<T>(this IEnumerable<T> MCPMOAEEEOJ, int BIMLHBENMHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E92110", Offset = "0x2E91510", VA = "0x182E92110")]
	public static string LPAMDBKLPMM<T>(this IEnumerable<T> MCPMOAEEEOJ, string HADEHDFMALH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D830", Offset = "0x2E8CC30", VA = "0x182E8D830")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) DBJHLJGPBDL<T, U>(this IEnumerable<(T Lhs, U Rhs)> MCPMOAEEEOJ)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D925B0", Offset = "0x2D919B0", VA = "0x182D925B0")]
	[IteratorStateMachine(typeof(LBNEGNLDKLM<, >))]
	public static IEnumerable<(T, U)> IGPDFBCNJHC<T, U>(this IEnumerable<T> JKMLNPBBJIG, IEnumerable<U> JDJGFJGMEAK) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E91A20", Offset = "0x2E90E20", VA = "0x182E91A20")]
	public static IEnumerable<V> JNOBCALFBMN<V, T, U>(this IEnumerable<T> MCPMOAEEEOJ, IEnumerable<U> KNLMODPGFOA, Func<T, U, V> INGNHNIBBOI, [Optional][BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")] T FCDLPFMPMEC, [Optional][BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")] U MIJAAHICNME) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E91AF0", Offset = "0x2E90EF0", VA = "0x182E91AF0")]
	public static IEnumerable<(T, U)> JNOBCALFBMN<T, U>(this IEnumerable<T> MCPMOAEEEOJ, IEnumerable<U> KNLMODPGFOA, [Optional][BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")] T FCDLPFMPMEC, [Optional][BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")] U MIJAAHICNME) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E8EFA0", Offset = "0x2E8E3A0", VA = "0x182E8EFA0")]
	public static TOut[] FBPOKNCGKJB<TOut, TIn>(this IEnumerable<TIn> NCAEOPCKAMO, Func<TIn, TOut> PENNHIKLJGE) where TOut : notnull where TIn : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E8E150", Offset = "0x2E8D550", VA = "0x182E8E150")]
	public static EAJEDGEMDCE<U> EHMFPMNAFEK<U, T>(this IEnumerable<T> FIOIDGFGFOO, Func<T, U> CFBPIMGILDA) where U : notnull where T : notnull
	{
		return default(EAJEDGEMDCE<U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LIJIEBMOJMA
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F067E0", Offset = "0x2F05BE0", VA = "0x182F067E0")]
	public static bool ABPKMCNIOJD<T, U>(this T MCPMOAEEEOJ, [In] U FMAFBHGACNM) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F06A00", Offset = "0x2F05E00", VA = "0x182F06A00")]
	public static bool AJOMIAOIHOM<T>(T MCPMOAEEEOJ, T KNLMODPGFOA) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class OEMMOFNNJKA
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xF3ACC0", Offset = "0xF3A0C0", VA = "0x180F3ACC0")]
	public static bool FGJOCLIFKHO([In] this float3 NIPIGODEADI, float3 BCMPBHCEGGA, float PFJKDGLGOOO = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IAGFOBADHNP
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class IOGOIOIJKPK<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x9B2E50", Offset = "0x9B2250", VA = "0x1809B2E50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3F97430", Offset = "0x3F96830", VA = "0x183F97430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xD3D620", Offset = "0xD3CA20", VA = "0x180D3D620")]
		[DebuggerHidden]
		public IOGOIOIJKPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4261520", Offset = "0x4260920", VA = "0x184261520", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4261740", Offset = "0x4260B40", VA = "0x184261740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4261550", Offset = "0x4260950", VA = "0x184261550", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C71DA0", Offset = "0x3C711A0", VA = "0x183C71DA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E87280", Offset = "0x2E86680", VA = "0x182E87280")]
	public static void PAOEPFLACNO<T>(this T KBFPLGGGODF, Action<T> MHMHPDJFMDE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E871A0", Offset = "0x2E865A0", VA = "0x182E871A0")]
	public static V JICNOLIDCKD<V, T>(this T KBFPLGGGODF, Func<T, V> MHMHPDJFMDE, [Optional][BFAKOGDFABI("`default!` shouldn't be necessary in C# 9")] V BMLEAJPEFAD) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E87120", Offset = "0x2E86520", VA = "0x182E87120")]
	public static T? IGOICAMFCOA<T>(this T MCPMOAEEEOJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E86ED0", Offset = "0x2E862D0", VA = "0x182E86ED0")]
	[IteratorStateMachine(typeof(IOGOIOIJKPK<>))]
	public static IEnumerable<T> IEBKDONPJPH<T>(this T MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E86DB0", Offset = "0x2E861B0", VA = "0x182E86DB0")]
	public static T[] HEIPAFAKJEC<T>(this T MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GJALJMPFKLK
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F9E0", Offset = "0x6E9EDE0", VA = "0x186E9F9E0")]
	private static byte[] BOHNJFDOFDK(int JMKAJEFKMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FC60", Offset = "0x6E9F060", VA = "0x186E9FC60")]
	private static byte[] IKNKACFJBDP(long CAKOFGKDGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F960", Offset = "0x6E9ED60", VA = "0x186E9F960")]
	private static byte[] ACBJKOFLINF(ulong CAKOFGKDGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FAF0", Offset = "0x6E9EEF0", VA = "0x186E9FAF0")]
	public static Guid IFKDNFPGNPP(params Guid[] CAMCJAGFICO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0280", Offset = "0x6E9F680", VA = "0x186EA0280")]
	public static Guid JMOKCOIDHBC([In] Guid BCBBOLPNFEG, int HAJICDLBEKC, int ABNEAOFINHP = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0350", Offset = "0x6E9F750", VA = "0x186EA0350")]
	public static Guid JMOKCOIDHBC([In] Guid BCBBOLPNFEG, long HAJICDLBEKC, int ABNEAOFINHP = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FDA0", Offset = "0x6E9F1A0", VA = "0x186E9FDA0")]
	public static Guid JMOKCOIDHBC([In] Guid BCBBOLPNFEG, ulong HAJICDLBEKC, int ABNEAOFINHP = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FD30", Offset = "0x6E9F130", VA = "0x186E9FD30")]
	public static Guid JMOKCOIDHBC([In] Guid BCBBOLPNFEG, [In] Guid PMGPKHFCIAE, int ABNEAOFINHP = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FE70", Offset = "0x6E9F270", VA = "0x186E9FE70")]
	private static Guid JMOKCOIDHBC([In] Guid BCBBOLPNFEG, byte[] GHPIMDKEDOE, int ABNEAOFINHP = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FA60", Offset = "0x6E9EE60", VA = "0x186E9FA60")]
	private static void EJKPJDDAGKK(byte[] GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E9FCE0", Offset = "0x6E9F0E0", VA = "0x186E9FCE0")]
	private static void JHMGJHHOBGO(byte[] GPJCGLBMIBA, int OPJKGPJPNJJ, int EANFIEEELEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class GIFENBHPOBF
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F830", Offset = "0x6E9EC30", VA = "0x186E9F830")]
	public static int ENLIMFHPABG(this int MCPMOAEEEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F780", Offset = "0x6E9EB80", VA = "0x186E9F780")]
	public static int BACCMPKHMBJ(this int MCPMOAEEEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F7C0", Offset = "0x6E9EBC0", VA = "0x186E9F7C0")]
	public static int BFHOCALMKAG(this int MCPMOAEEEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F8A0", Offset = "0x6E9ECA0", VA = "0x186E9F8A0")]
	public static int GCECLDIKLCK(this int MCPMOAEEEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E88C70", Offset = "0x5E88070", VA = "0x185E88C70")]
	public static int KEIKMGNDEAD(this int MCPMOAEEEOJ, int HMELIAGANNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5F589E0", Offset = "0x5F57DE0", VA = "0x185F589E0")]
	public static int AMHBBFPFCCB(this int MCPMOAEEEOJ, int HMELIAGANNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F8B0", Offset = "0x6E9ECB0", VA = "0x186E9F8B0")]
	public static float HMGADHABBGB(this int MCPMOAEEEOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F8D0", Offset = "0x6E9ECD0", VA = "0x186E9F8D0")]
	public static (byte, byte, byte, byte) NINJKBNKACF(this int MCPMOAEEEOJ)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F940", Offset = "0x6E9ED40", VA = "0x186E9F940")]
	public static int OLNILEEKPFG([In] this (byte Fourth, byte Third, byte Second, byte First) MCPMOAEEEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F810", Offset = "0x6E9EC10", VA = "0x186E9F810")]
	public static int BIDNICEAEPB(this int MCPMOAEEEOJ, int PGMLADDCJKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F820", Offset = "0x6E9EC20", VA = "0x186E9F820")]
	public static int CPJMDBCOEEE(this int MCPMOAEEEOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PPDDPNANKMM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3290", Offset = "0x6EA2690", VA = "0x186EA3290")]
	public static (byte, byte, byte, byte, byte, byte, byte, byte) NINJKBNKACF(this long MCPMOAEEEOJ)
	{
		return default((byte, byte, byte, byte, byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3240", Offset = "0x6EA2640", VA = "0x186EA3240")]
	public static long JAGPCLJCENK([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) MCPMOAEEEOJ)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EDPEMOMFBPL
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NMKLPFBIAMC(int DPANLBJAOGL, int FDEMIOHINCD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float INGPELPLOED(float LJDODKPGLCG, float HPPJGLJIOML);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CPHOGIMEMJO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long KMGAHOAFGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class OMLODJBOODD
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x30326D0", Offset = "0x3031AD0", VA = "0x1830326D0")]
	public static (TKey?, TValue?) AIDGJFKFBLN<TKey, TValue>([In] this KeyValuePair<TKey, TValue> MCPMOAEEEOJ)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x30327D0", Offset = "0x3031BD0", VA = "0x1830327D0")]
	public static KeyValuePair<TKey?, UValue?> PGKJPMMDLIP<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> MCPMOAEEEOJ, UValue EEPLCHCGAIN)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MGIKBAJGANO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GGEHGLKDPIH<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public GGEHGLKDPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4093EB0", Offset = "0x40932B0", VA = "0x184093EB0")]
		internal TElement IDBLOCOONFM(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F2F4E0", Offset = "0x2F2E8E0", VA = "0x182F2F4E0")]
	public static int BGCEDABFPAE<T>(this IReadOnlyList<T> IGGIDMIPNHL, T EEPLCHCGAIN) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F30A60", Offset = "0x2F2FE60", VA = "0x182F30A60")]
	public static int EDKPKOBNEGO<T>(this IReadOnlyList<T> IGGIDMIPNHL, T EEPLCHCGAIN) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F30C50", Offset = "0x2F30050", VA = "0x182F30C50")]
	public static void FFAAAODPHAO<T>(this HashSet<T> IIIGMBMKEKN, IEnumerable<T> HAIEMBCHPMF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F33760", Offset = "0x2F32B60", VA = "0x182F33760")]
	public static void KOCFPELMEAP<T>(this IList<T> KDBAFFDDPME) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F33410", Offset = "0x2F32810", VA = "0x182F33410")]
	public static void KOCFPELMEAP<T>(this IList<T> KDBAFFDDPME, int GCBJJDFIECN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F34360", Offset = "0x2F33760", VA = "0x182F34360")]
	public static void PONOHEKAELH<T>(this List<T> KDBAFFDDPME) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F308E0", Offset = "0x2F2FCE0", VA = "0x182F308E0")]
	public static List<T> EAPGFLOJBBD<T>(this List<T> JJGPKFAMMFF, Predicate<T> ECHPIHDGNNI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F2FB10", Offset = "0x2F2EF10", VA = "0x182F2FB10")]
	public static int BGCEDABFPAE<T>(this IReadOnlyList<T> KDBAFFDDPME, Predicate<T> MNAFDOMGIPE) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F32EE0", Offset = "0x2F322E0", VA = "0x182F32EE0")]
	public static bool JCCIONCNANI<T>(this IReadOnlyList<T> KDBAFFDDPME, Predicate<T> MNAFDOMGIPE, [Out][NotNullWhen(true)] List<int>? FJHCOGHKDDO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F321E0", Offset = "0x2F315E0", VA = "0x182F321E0")]
	public static bool FLEJEGPKCKH<T>(this IReadOnlyList<T> KDBAFFDDPME, T HHDONFMCNBA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F32260", Offset = "0x2F31660", VA = "0x182F32260")]
	public static bool FLEJEGPKCKH<T>(this IReadOnlyList<T> KDBAFFDDPME, T HHDONFMCNBA, EqualityComparer<T> IPJKNPILFIK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F2EC60", Offset = "0x2F2E060", VA = "0x182F2EC60")]
	public static int AEFDJJGOFJJ<TElement, TKey>(this IList<TElement> OEMFEAAEBOG, TKey JDOGAADNPIM, Func<TElement, TKey> JGHDDHDGKCA, [Optional] Func<TKey, TKey, int>? OKDIHAHMBLG, int HAJICDLBEKC = 0, [Optional] int? HMELIAGANNM) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E520", Offset = "0x2F2D920", VA = "0x182F2E520")]
	public static int AEFDJJGOFJJ<TElement, TKey>(Func<int, TElement> JFMKAEMBJKL, int DAIMNBGLODH, TKey JDOGAADNPIM, Func<TElement, TKey> JGHDDHDGKCA, [Optional] Func<TKey, TKey, int>? OKDIHAHMBLG, int HAJICDLBEKC = 0, [Optional] int? HMELIAGANNM) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F32A80", Offset = "0x2F31E80", VA = "0x182F32A80")]
	public static bool HMHHNHLGKFK<T>(this List<T> KDBAFFDDPME, T HHDONFMCNBA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F306B0", Offset = "0x2F2FAB0", VA = "0x182F306B0")]
	public static void CDPONFGPHPL<T>(this List<T> KDBAFFDDPME, IEnumerable<T> JJGPKFAMMFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F30220", Offset = "0x2F2F620", VA = "0x182F30220")]
	public static void BJFEGIDGDBE<T>(this List<T> KDBAFFDDPME, IEnumerable<T> JJGPKFAMMFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F30620", Offset = "0x2F2FA20", VA = "0x182F30620")]
	public static T BKDOGEIBJKB<T>(this List<T> JJGPKFAMMFF, Predicate<T> ECHPIHDGNNI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2F32560", Offset = "0x2F31960", VA = "0x182F32560")]
	public static T GCFGLDKNLGB<T>(this List<T> JJGPKFAMMFF, int HAJICDLBEKC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2F32BF0", Offset = "0x2F31FF0", VA = "0x182F32BF0")]
	public static void HOMCHKJBOIP<T>(this List<T> KDBAFFDDPME, int HAJICDLBEKC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2F2F3F0", Offset = "0x2F2E7F0", VA = "0x182F2F3F0")]
	public static bool BFGLFECKKJP<T>(this List<T> INJGLHEIFCD, List<T> CGDJDGOIMFD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F32890", Offset = "0x2F31C90", VA = "0x182F32890")]
	public static T HLGKLJEKCLA<T>(this IList<T> KDBAFFDDPME) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F31970", Offset = "0x2F30D70", VA = "0x182F31970")]
	public static bool FHFHHGFIEHE<T>(IReadOnlyList<T>? KDBAFFDDPME, int HAJICDLBEKC, [Out][MaybeNullWhen(false)][BFAKOGDFABI("This should be `T?` in C# 9.")] T IPNDOKDOGDG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F2D7B0", Offset = "0x2F2CBB0", VA = "0x182F2D7B0")]
	public static bool AACGNAGPNFM<T>(IReadOnlyList<T> KDBAFFDDPME, ICollection JJGPKFAMMFF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2F323B0", Offset = "0x2F317B0", VA = "0x182F323B0")]
	public static void FMBLCMFNFOD<T>(IReadOnlyList<T> KDBAFFDDPME, ICollection JJGPKFAMMFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C8CD70", Offset = "0x2C8C170", VA = "0x182C8CD70")]
	public static bool OOIPBBIPNNE<T>(this IReadOnlyList<T> KDBAFFDDPME) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2F32D20", Offset = "0x2F32120", VA = "0x182F32D20")]
	public static string IKBGLFOCFEB<T>(this IEnumerable<T> KDBAFFDDPME, string AOGLHAGFPCP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2F34040", Offset = "0x2F33440", VA = "0x182F34040")]
	public static T PFGAIKJBOJG<T>(this IList<T> MCPMOAEEEOJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F33D10", Offset = "0x2F33110", VA = "0x182F33D10")]
	public static T OJCKJMBHLDN<T>(this IList<T> MCPMOAEEEOJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F33380", Offset = "0x2F32780", VA = "0x182F33380")]
	public static void JONNLKOBMBN<T>(this IList<T> MCPMOAEEEOJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F32700", Offset = "0x2F31B00", VA = "0x182F32700")]
	public static void HDNMCKMKHAN<T>(this IList<T> MCPMOAEEEOJ, [In] T EEPLCHCGAIN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2F32600", Offset = "0x2F31A00", VA = "0x182F32600")]
	public static T GKBLCALILIL<T>(this IList<T> MCPMOAEEEOJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2F340E0", Offset = "0x2F334E0", VA = "0x182F340E0")]
	public static void PKEMGEJNDPM<T>(this List<T> MCPMOAEEEOJ) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DGMOMMFAPII
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static float FAFOHECKHKE;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static float IAHGKAMNLAN;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static bool MHFKNNGLCMG;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly float MIFIOPEDJGC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EA80", Offset = "0x6E9DE80", VA = "0x186E9EA80")]
	public static bool LIHIAFBNKJF(float NIPIGODEADI, float BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E9ED80", Offset = "0x6E9E180", VA = "0x186E9ED80")]
	public static float NFJBHDFLBKP(float EEPLCHCGAIN, float DBFICLBOEFG, float EGCLLCBPEBE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EDA0", Offset = "0x6E9E1A0", VA = "0x186E9EDA0")]
	public static int NFJBHDFLBKP(int EEPLCHCGAIN, int DBFICLBOEFG, int EGCLLCBPEBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EDC0", Offset = "0x6E9E1C0", VA = "0x186E9EDC0")]
	public static float OHMEKBLIIMD(float EEPLCHCGAIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E9ECE0", Offset = "0x6E9E0E0", VA = "0x186E9ECE0")]
	public static float MJHIKKOMOBP(float NIPIGODEADI, float BCMPBHCEGGA, float KBFPLGGGODF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E9C0", Offset = "0x6E9DDC0", VA = "0x186E9E9C0")]
	public static float IDOFNDPOFCK(float NIPIGODEADI, float BCMPBHCEGGA, float KBFPLGGGODF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EDE0", Offset = "0x6E9E1E0", VA = "0x186E9EDE0")]
	public static float PJHLHELDANN(float NIPIGODEADI, float BCMPBHCEGGA, float EEPLCHCGAIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E980", Offset = "0x6E9DD80", VA = "0x186E9E980")]
	public static float GPHDNPMIKMI(float NIPIGODEADI, float BCMPBHCEGGA, float EEPLCHCGAIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E9D0", Offset = "0x6E9DDD0", VA = "0x186E9E9D0")]
	public static float ILDPLHKNFFD(float NIPIGODEADI, float BCMPBHCEGGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E7C0", Offset = "0x6E9DBC0", VA = "0x186E9E7C0")]
	public static float DBAHFDBIGON(float APDLENCJHAI, float KDGMCPCFIID, float IHDCGCNLPCE, float JGFMAIPJNOD, float BBBGCFNLFEE, float KDDKBBMEFBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E9F0", Offset = "0x6E9DDF0", VA = "0x186E9E9F0")]
	public static float JIJOEIAHKPD(float EEPLCHCGAIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EB70", Offset = "0x6E9DF70", VA = "0x186E9EB70")]
	public static float LOHLOCMGLFL(float EEPLCHCGAIN, float DBFICLBOEFG, float EGCLLCBPEBE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EC60", Offset = "0x6E9E060", VA = "0x186E9EC60")]
	public static float MAJFPEGMKAN(float PKMIJIEDBJO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class COOACKHNEND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private System.Random NACIODHKDMC;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E730", Offset = "0x6E9DB30", VA = "0x186E9E730")]
	public COOACKHNEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E6B0", Offset = "0x6E9DAB0", VA = "0x186E9E6B0")]
	public COOACKHNEND(int GCBJJDFIECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x65FCFC0", Offset = "0x65FC3C0", VA = "0x1865FCFC0", Slot = "4")]
	public virtual int NMKLPFBIAMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E680", Offset = "0x6E9DA80", VA = "0x186E9E680", Slot = "5")]
	public virtual int NMKLPFBIAMC(int FDEMIOHINCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E650", Offset = "0x6E9DA50", VA = "0x186E9E650", Slot = "6")]
	public virtual int NMKLPFBIAMC(int DPANLBJAOGL, int FDEMIOHINCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E620", Offset = "0x6E9DA20", VA = "0x186E9E620")]
	public double LNABMDIJBAM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JFGMHLIKICJ
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2EB27A0", Offset = "0x2EB1BA0", VA = "0x182EB27A0")]
	[ALGEIKMJAHG("This should be replaced with the `is not` operator in C# 9.")]
	public static bool IAGFPHIFHJL<T>(this object MCPMOAEEEOJ, [Out][NotNullWhen(true)] T IPNDOKDOGDG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PLBNDHMHPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3010", Offset = "0x6EA2410", VA = "0x186EA3010")]
	public static (float3, float3, float3) KCAGBMGCDBG([In] this quaternion MCPMOAEEEOJ)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6EA21A0", Offset = "0x6EA15A0", VA = "0x186EA21A0")]
	private static float3 AAHGGCCCDFO(quaternion GFILOBLKEMP, math.RotationOrder DENOKNGHHDI = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6EA2B10", Offset = "0x6EA1F10", VA = "0x186EA2B10")]
	private static float3 ADPGBPDBJEM(float3 EDDOILDBAPF, math.RotationOrder DENOKNGHHDI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3100", Offset = "0x6EA2500", VA = "0x186EA3100")]
	public static float3 LFKHFDHLBHE(this quaternion GFILOBLKEMP, math.RotationOrder DENOKNGHHDI = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6EA2BE0", Offset = "0x6EA1FE0", VA = "0x186EA2BE0")]
	public static float CFMEMNEGCFN(this quaternion JKMLNPBBJIG, quaternion JDJGFJGMEAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6EA2D30", Offset = "0x6EA2130", VA = "0x186EA2D30")]
	public static quaternion CHGHKIJMBLJ(this quaternion MDJOMEFJFHD, float3 IFOHBPMBAIN)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6EA31B0", Offset = "0x6EA25B0", VA = "0x186EA31B0")]
	[CompilerGenerated]
	internal static float3 PCJFFPJEKNM(float3 EDDOILDBAPF)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CJKOHIOJOAE
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class NFGMEKMEEKN : EDPEMOMFBPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly System.Random EGPDIALMHPO;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E650", Offset = "0x6E9DA50", VA = "0x186E9E650", Slot = "4")]
		public int NMKLPFBIAMC(int LJDODKPGLCG, int CECHFJJHNNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1440", Offset = "0x6EA0840", VA = "0x186EA1440", Slot = "5")]
		public float INGPELPLOED(float LJDODKPGLCG, float HPPJGLJIOML)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1400", Offset = "0x6EA0800", VA = "0x186EA1400")]
		private double EKKJBDFPEKG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA14B0", Offset = "0x6EA08B0", VA = "0x186EA14B0")]
		public NFGMEKMEEKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly EDPEMOMFBPL GFEEKDEIJHH;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E2F0", Offset = "0x6E9D6F0", VA = "0x186E9E2F0")]
	public static ulong HPECMCFHDEN()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class FACFGNDDLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A510", Offset = "0x2E29910", VA = "0x182E2A510")]
	public static bool ICJMIFHHPPC<T>(this IReadOnlyCollection<T> MCPMOAEEEOJ, int HAJICDLBEKC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class PCANNNGHKCI
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x303CFE0", Offset = "0x303C3E0", VA = "0x18303CFE0")]
	public static bool ELLLNKEFKDJ<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> MCPMOAEEEOJ, IReadOnlyDictionary<TKey, TValue> KNLMODPGFOA) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MGDFOHKELFI
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2F2C3B0", Offset = "0x2F2B7B0", VA = "0x182F2C3B0")]
	public static TValue? NEPPFHJGEEO<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> MCPMOAEEEOJ, TKey OEOMDKHBDFI) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class EIJHIHLKFMN
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F180", Offset = "0x6E9E580", VA = "0x186E9F180")]
	public static void NCEDFJEFMFN(this IReadOnlyList<Action> MCPMOAEEEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFA70", Offset = "0x2CCEE70", VA = "0x182CCFA70")]
	public static bool LCKMIEGKAOE<T>(this IReadOnlyList<T> MCPMOAEEEOJ, int HAJICDLBEKC, [Out][NotNullWhen(true)][BFAKOGDFABI("This should be `T?` in C# 9.")] T IPNDOKDOGDG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF990", Offset = "0x2CCED90", VA = "0x182CCF990")]
	public static bool ICHLCPBPKIN<T>(this IReadOnlyList<T> MCPMOAEEEOJ, int HAJICDLBEKC, [Out] LJJMDOMAGEC<T> IPNDOKDOGDG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFBC0", Offset = "0x2CCEFC0", VA = "0x182CCFBC0")]
	public static T MIODOAMHADL<T>(this IReadOnlyList<T> MCPMOAEEEOJ, int HAJICDLBEKC, [In] T GGCMLKILADA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF940", Offset = "0x2CCED40", VA = "0x182CCF940")]
	[BFAKOGDFABI("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T GCBJFELODJL<T>(this IReadOnlyList<T> MCPMOAEEEOJ, int HAJICDLBEKC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFC60", Offset = "0x2CCF060", VA = "0x182CCFC60")]
	public static T? NEPPFHJGEEO<T>(this IReadOnlyList<T> MCPMOAEEEOJ, int HAJICDLBEKC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DFHCMKMLILP
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1620", Offset = "0x2CA0A20", VA = "0x182CA1620")]
	public static int EDNOBGFMLLB<T>([In] this ReadOnlySequence<T> JNDDGFBGMGM, [In] T EEPLCHCGAIN) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1200", Offset = "0x2CA0600", VA = "0x182CA1200")]
	public static bool EDMIHGPEKBH<T>([In] this ReadOnlySequence<T> JNDDGFBGMGM, [In] ReadOnlySpan<T> KNLMODPGFOA) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class MEIKBONGNJP
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2F26C70", Offset = "0x2F26070", VA = "0x182F26C70")]
	public static string FBININKGAIA<T>([In] this ReadOnlySpan<T> MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2F273D0", Offset = "0x2F267D0", VA = "0x182F273D0")]
	public static string LPAMDBKLPMM<T>([In] this ReadOnlySpan<T> MCPMOAEEEOJ, string HADEHDFMALH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct EMMNDMEKHLP : CPHOGIMEMJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CPHOGIMEMJO NMPOHFNAABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly long BCMBGJIDFJC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long KMGAHOAFGLP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F4D0", Offset = "0x6E9E8D0", VA = "0x186E9F4D0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double JFHDCGFMGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F410", Offset = "0x6E9E810", VA = "0x186E9F410")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double LJKMPPGPAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F590", Offset = "0x6E9E990", VA = "0x186E9F590")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1490B90", Offset = "0x148FF90", VA = "0x181490B90")]
	public EMMNDMEKHLP(CPHOGIMEMJO BNOFHEMALEA, long AFINABKEABL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BDPBADAACJF
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static CPHOGIMEMJO PCGMPNFIHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6E9DF50", Offset = "0x6E9D350", VA = "0x186E9DF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DFA0", Offset = "0x6E9D3A0", VA = "0x186E9DFA0")]
	public static long PCNOJMGMJMO(this CPHOGIMEMJO MCPMOAEEEOJ, long AFINABKEABL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DDB0", Offset = "0x6E9D1B0", VA = "0x186E9DDB0")]
	public static double AKHBCCLAOIJ(this CPHOGIMEMJO MCPMOAEEEOJ, long AFINABKEABL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DEC0", Offset = "0x6E9D2C0", VA = "0x186E9DEC0")]
	public static double MKNHGJAHHOM(this CPHOGIMEMJO MCPMOAEEEOJ, long AFINABKEABL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6E9DE40", Offset = "0x6E9D240", VA = "0x186E9DE40")]
	public static EMMNDMEKHLP LKKFLFILGDC(this CPHOGIMEMJO MCPMOAEEEOJ)
	{
		return default(EMMNDMEKHLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class BNNFDANNBAM : CPHOGIMEMJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch ODIOCNCPKAB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long KMGAHOAFGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E9E180", Offset = "0x6E9D580", VA = "0x186E9E180", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	private BNNFDANNBAM(Stopwatch OOBCNKBCDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E250", Offset = "0x6E9D650", VA = "0x186E9E250")]
	public static BNNFDANNBAM OGNCNNIJPFO(Stopwatch OOBCNKBCDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E1A0", Offset = "0x6E9D5A0", VA = "0x186E9E1A0")]
	public static BNNFDANNBAM HAAHJDMDIOH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BKCDBODCOGD
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE46D0", Offset = "0x6DE3AD0", VA = "0x186DE46D0")]
	public static float3 OMJAIIGLGCI([In] this RigidTransform MCPMOAEEEOJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE45A0", Offset = "0x6DE39A0", VA = "0x186DE45A0")]
	public static float3 JIHCCFOLBKG([In] this RigidTransform MCPMOAEEEOJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xC14EB0", Offset = "0xC142B0", VA = "0x180C14EB0")]
	public static (float3, float3, float3) GIGCMMIJFFJ([In] this RigidTransform MCPMOAEEEOJ)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E120", Offset = "0x6E9D520", VA = "0x186E9E120")]
	public static RigidTransform FCDOGFGBFLB([In] this RigidTransform MCPMOAEEEOJ)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KHGALGFPFMC
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0D60", Offset = "0x6EA0160", VA = "0x186EA0D60")]
	public static RigidTransform DLDIAPBIJEO(RigidTransform OJCGHAFLLIA, RigidTransform ADBCALGKFBA)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class NBGNEPAMKOC
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1350", Offset = "0x6EA0750", VA = "0x186EA1350")]
	public static float NCOGBBPHHAM([In] this (byte Fourth, byte Third, byte Second, byte First) MCPMOAEEEOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1340", Offset = "0x6EA0740", VA = "0x186EA1340")]
	public static int KBHHKLNHOGI(this float MCPMOAEEEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1390", Offset = "0x6EA0790", VA = "0x186EA1390")]
	public static (byte, byte, byte, byte) NINJKBNKACF(this float MCPMOAEEEOJ)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BNPCGEAIFCB
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6120", Offset = "0x2BF5520", VA = "0x182BF6120")]
	public static ReadOnlySpan<T?> MJEMPIHBNNA<T>([In] this Span<T> MCPMOAEEEOJ)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class GALJECPFNDG
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F720", Offset = "0x6E9EB20", VA = "0x186E9F720")]
	public static StringBuilder NKDMFGOAODE(this StringBuilder MCPMOAEEEOJ, int HDJEJPCGJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F650", Offset = "0x6E9EA50", VA = "0x186E9F650")]
	public static StringBuilder CFIEEMANIAG(this StringBuilder MCPMOAEEEOJ, int HDJEJPCGJBI, string CKEJEIFKOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E9F6C0", Offset = "0x6E9EAC0", VA = "0x186E9F6C0")]
	public static StringBuilder ELHECPKNEEH(this StringBuilder MCPMOAEEEOJ, char AIOAKPNLPPG, int KOPLFDIGBJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OLJFAGLHACN
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static Regex FMEDCENEPOA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static Regex EHCDILMDNGO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly char[] FHIMBAEOLBH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly string[] KPNOIGLOBDF;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x621DEA0", Offset = "0x621D2A0", VA = "0x18621DEA0")]
	public static bool OOIPBBIPNNE(this string? CGPMIHKPHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1DE0", Offset = "0x6EA11E0", VA = "0x186EA1DE0")]
	public static string? JOEOHFBIFCL(this string? MCPMOAEEEOJ, int EOANMDEAJKL, string EAMBJMFPMBC = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1BD0", Offset = "0x6EA0FD0", VA = "0x186EA1BD0")]
	public static string HIJHFPBGNLD(this string MCPMOAEEEOJ, int EOANMDEAJKL, string EAMBJMFPMBC = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA15B0", Offset = "0x6EA09B0", VA = "0x186EA15B0")]
	public static int ENGDNKKBHBL(this string CGPMIHKPHGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA19B0", Offset = "0x6EA0DB0", VA = "0x186EA19B0")]
	public static string HDGBBINCONF(this string CGPMIHKPHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1D00", Offset = "0x6EA1100", VA = "0x186EA1D00")]
	public static string[] JCPPLLPAHDA(this string CGPMIHKPHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1C70", Offset = "0x6EA1070", VA = "0x186EA1C70")]
	private static bool ICEAEHIPAMH(string CDMNEMPOKAK, int PGAHHGFJKBL, [Out] int CBHLHANGEDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1A60", Offset = "0x6EA0E60", VA = "0x186EA1A60")]
	private static bool HDLPKFNJPCH(string CDMNEMPOKAK, int PGAHHGFJKBL, [Out] int CBHLHANGEDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1620", Offset = "0x6EA0A20", VA = "0x186EA1620")]
	public static int GFIGAAHIDHF(string CDMNEMPOKAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CEBDBEDEOAG
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E2C0", Offset = "0x6E9D6C0", VA = "0x186E9E2C0")]
	public static bool GBOBPCEOCDP(this Type MCPMOAEEEOJ, Type KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2C4ED40", Offset = "0x2C4E140", VA = "0x182C4ED40")]
	public static bool GBOBPCEOCDP<T>(this Type MCPMOAEEEOJ) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class BGDNPCCLJAI
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5E88C70", Offset = "0x5E88070", VA = "0x185E88C70")]
	public static uint KEIKMGNDEAD(this uint MCPMOAEEEOJ, int HMELIAGANNM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5F589E0", Offset = "0x5F57DE0", VA = "0x185F589E0")]
	public static uint AMHBBFPFCCB(this uint MCPMOAEEEOJ, int HMELIAGANNM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E110", Offset = "0x6E9D510", VA = "0x186E9E110")]
	public static uint OJBFOCBOFKE(this uint MCPMOAEEEOJ, uint HEDLODLOOLN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x13276A0", Offset = "0x1326AA0", VA = "0x1813276A0")]
	public static int KBHHKLNHOGI(this uint MCPMOAEEEOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class FMLNAOONOMD
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2E501D0", Offset = "0x2E4F5D0", VA = "0x182E501D0")]
	public static bool MALEOEDPCDA<T>([In] this T? MCPMOAEEEOJ, [Out] T EEPLCHCGAIN) where T : struct
	{
		return default(bool);
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
