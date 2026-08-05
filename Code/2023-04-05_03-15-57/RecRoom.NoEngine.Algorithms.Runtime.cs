using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6668210", Offset = "0x6667210", VA = "0x186668210")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CKIFMDLBLLM
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate int EPELMEPBLBK<T>(in T AJDPMFOKMPC, in T DAAPHBHBHCO);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class GFHMIECOIDH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private struct CNHIFMOGLDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public readonly int GJPBLFPOONO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly int DGKBJMLJKJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly bool FCNJOLANDJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int DNKKJCPCBLB;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2EED130", Offset = "0x2EEC130", VA = "0x182EED130")]
			public CNHIFMOGLDM(int GJPBLFPOONO, int DGKBJMLJKJI, bool FCNJOLANDJP)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly T[] CBLHMABDMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly T[] FEKDBKMKCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly EPELMEPBLBK<T> HBKJEAGAKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly int OFJDFHLGFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Func<bool> IELNCFNHIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int OPBKOMDGLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly CNHIFMOGLDM[] DKAJDLCKJED;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28F1380", Offset = "0x28F0380", VA = "0x1828F1380")]
		public GFHMIECOIDH(T[] CBLHMABDMMM, EPELMEPBLBK<T> HBKJEAGAKKP, int OFJDFHLGFBG, Func<bool> IELNCFNHIDL, T[] PKPKNJICONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28F0FF0", Offset = "0x28EFFF0", VA = "0x1828F0FF0")]
		public bool ACNMKOHBBPO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate U HENGPCKDEGG<T, U>(int EEAHJGGOIKH, int MAMHFDOLFKM, in ReadOnlySpan<T> JIACAECEIBG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23509A0", Offset = "0x234F9A0", VA = "0x1823509A0")]
	public static ReadOnlyMemory<T> PBHGCHMNNBF<T>(this T[] AOFCPKBHFEM)
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x283CFD0", Offset = "0x283BFD0", VA = "0x18283CFD0")]
	public static T[] CNJKCPLPDLK<T>(int MKMGHJFMNMB, T FDEAOIFPBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x283CE40", Offset = "0x283BE40", VA = "0x18283CE40")]
	public static void BCHKCBODCFH<T>(this T[] FICCNBPNNHA, T FDEAOIFPBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26EF030", Offset = "0x26EE030", VA = "0x1826EF030")]
	public static void DOJLKBEKEJJ<T>(this T[] EGIDMCNFHCK, int BDAADCOCKII, int CENFIFAIEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x283D730", Offset = "0x283C730", VA = "0x18283D730")]
	private static void HDJIBMJJHEA<T>(this T[] AOFCPKBHFEM, int BMKDJDNNMEA, int ONGABMOBOPN, T[] JHMCLPBFJBC, int KDLGOIJNGDD, int AGFNEHFAFHC, T[] GPPHCPBMODE, int IHMGMKEEKNA, EPELMEPBLBK<T> HBKJEAGAKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x283D230", Offset = "0x283C230", VA = "0x18283D230")]
	public static void DOEMNNGLIMD<T>(this T[] AOFCPKBHFEM, int GJPBLFPOONO, int KJAHKKMJHHG, EPELMEPBLBK<T> HBKJEAGAKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x283DB30", Offset = "0x283CB30", VA = "0x18283DB30")]
	public static GFHMIECOIDH<T> IFBEBFOHMML<T>(this T[] AOFCPKBHFEM, EPELMEPBLBK<T> HBKJEAGAKKP, int OFJDFHLGFBG, Func<bool> IELNCFNHIDL, [Optional] T[] PKPKNJICONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x283DBD0", Offset = "0x283CBD0", VA = "0x18283DBD0")]
	public static T[] OIEPKIMNLDG<T>(this T[] EGIDMCNFHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x283D150", Offset = "0x283C150", VA = "0x18283D150")]
	public static T[] DLGINBBAKFC<T>(this T[] PEHJIPFOPCH, T AELGGFIADMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x283E1E0", Offset = "0x283D1E0", VA = "0x18283E1E0")]
	public static T[] PKHENHIFNJG<T>(this T[] PEHJIPFOPCH, int EGBCAPEEJBF, T AELGGFIADMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x283DBF0", Offset = "0x283CBF0", VA = "0x18283DBF0")]
	public static T[] OJMMOGOBFED<T>(this T[] PEHJIPFOPCH, int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x283CC10", Offset = "0x283BC10", VA = "0x18283CC10")]
	public static T[] BCEAFBFEJOA<T>(this T[] PEHJIPFOPCH, int EGBCAPEEJBF, T AELGGFIADMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x283DCA0", Offset = "0x283CCA0", VA = "0x18283DCA0")]
	public static U[] PJDKJEPEHHO<U, T>(this T[] OBPNIKFBDBK, int EMIJCJILDFM, HENGPCKDEGG<T, U> CGBGOOPBDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66668D0", Offset = "0x66658D0", VA = "0x1866668D0")]
	public static byte[] OAHOOHLHJPM(this byte[] AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6666AE0", Offset = "0x6665AE0", VA = "0x186666AE0")]
	public static byte[] PGDKHNKPMDM(this byte[] AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KENOFCEMIHB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x21E6300", Offset = "0x21E5300", VA = "0x1821E6300")]
	public static void CMEPDJJCKOF<T>(this ICollection<T> AOFCPKBHFEM, IEnumerable<T> ECLIJHMKGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KOLEOACHALH
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFAB0", Offset = "0x2FBEAB0", VA = "0x182FBFAB0")]
	public static void GBFGOMPMDNG<K, V>(this IDictionary<K, V> AOFCPKBHFEM, in K EBOIOCBODNI, in V KPPLMEOMNGF, Func<V, V, V> LOGLPMMEKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2FBF520", Offset = "0x2FBE520", VA = "0x182FBF520")]
	public static void AKHHODHOFAE<K, V>(this IDictionary<K, List<V>> AOFCPKBHFEM, in K EBOIOCBODNI, in V KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0BD0", Offset = "0x2FBFBD0", VA = "0x182FC0BD0")]
	public static TVal KKIINDDINID<TVal, TKey>(this IDictionary<TKey, TVal> GCMGJFGGLEN, in TKey EBOIOCBODNI, [Optional] TVal PNIJKHBHNEL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0840", Offset = "0x2FBF840", VA = "0x182FC0840")]
	public static TVal KKIINDDINID<TVal, TKey>(this IDictionary<TKey, TVal> GCMGJFGGLEN, in TKey EBOIOCBODNI, Func<TVal> KECFFGCANAL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0020", Offset = "0x2FBF020", VA = "0x182FC0020")]
	public static TValue HPGKMHPNJHL<TValue, TKey>(this IDictionary<TKey, TValue> GCMGJFGGLEN, in TKey EBOIOCBODNI, [Optional] in TValue PNIJKHBHNEL)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1790", Offset = "0x2FC0790", VA = "0x182FC1790")]
	public static V LDNAALFCOGL<V, K>(this IDictionary<K, V> AOFCPKBHFEM, in K EBOIOCBODNI)
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2FC07B0", Offset = "0x2FBF7B0", VA = "0x182FC07B0")]
	public static T2[] IFPMJMGFJLK<T2, T1>(this Dictionary<T1, T2>.ValueCollection ECDHPFPEBML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MMFLJNIJHID
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate bool AEFNAAOMLJF<TArgs, T>(in TArgs KCPODLJODHA, T DKIDMLOAMGB);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate U KEMAFOOKLOC<TArg, U>(in TArg OGEFBAJDPAC);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate U PHPPNMNDEBD<TArg, T, U>(in TArg OGEFBAJDPAC, T GBEOCIOFDDF);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate U BBEOAAGBFGL<TArg, T, U>(in TArg OGEFBAJDPAC, IEnumerable<T> KDCOOOFOCDB);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate U MKDGAEDBIAJ<TArg, T, U>(in TArg OGEFBAJDPAC, T GBEOCIOFDDF);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct BPAHEPIJMJP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x27F9FB0", Offset = "0x27F8FB0", VA = "0x1827F9FB0")]
		public (bool, T, IEnumerable<T>) BKDHGDDJKDD(T OCMDHDJPHNM)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x27FA020", Offset = "0x27F9020", VA = "0x1827FA020")]
		public (bool, T, IEnumerable<T>) ENHAFLCPFKL(IEnumerable<T> NAOMIGPBCKL)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KCNFBLBEEAP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int salt;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public KCNFBLBEEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x281F0A0", Offset = "0x281E0A0", VA = "0x18281F0A0")]
		internal int <SequenceGetHashCode>b__0(int prev, T current)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BMNCLDLIFCM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public BMNCLDLIFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x10FE6D0", Offset = "0x10FD6D0", VA = "0x1810FE6D0")]
		internal bool <SetEqual>b__0(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x27F1F90", Offset = "0x27F0F90", VA = "0x1827F1F90")]
		internal bool <SetEqual>b__1(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2248080", Offset = "0x2247080", VA = "0x182248080")]
	public static bool OOJLNPFKDBC<T, TArgs>(this IEnumerable<T> AOFCPKBHFEM, in TArgs KCPODLJODHA, AEFNAAOMLJF<TArgs, T> LEGCKHOACDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x22423D0", Offset = "0x22413D0", VA = "0x1822423D0")]
	public static U HFEAKHONOLL<U, T>(this IEnumerable<T> AOFCPKBHFEM, Func<U> DNNDPDKPLBK, Func<T, U> OCMDHDJPHNM, Func<IEnumerable<T>, U> NAOMIGPBCKL)
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x22467D0", Offset = "0x22457D0", VA = "0x1822467D0")]
	public static bool MILBNLDJCCH<T, TArgs>(this IEnumerable<T> AOFCPKBHFEM, in TArgs KCPODLJODHA, AEFNAAOMLJF<TArgs, T> LEGCKHOACDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x22474D0", Offset = "0x22464D0", VA = "0x1822474D0")]
	public static U OLELGPBDMGE<U, T, TArg>(this IEnumerable<T> AOFCPKBHFEM, in TArg OGEFBAJDPAC, KEMAFOOKLOC<TArg, U> DNNDPDKPLBK, PHPPNMNDEBD<TArg, T, U> OCMDHDJPHNM, BBEOAAGBFGL<TArg, T, U> NAOMIGPBCKL)
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2246B30", Offset = "0x2245B30", VA = "0x182246B30")]
	public static IEnumerable<U> NEBIDBHHEGI<U, T, TArg>(this IEnumerable<T> AOFCPKBHFEM, in TArg OGEFBAJDPAC, MKDGAEDBIAJ<TArg, T, U> HFHIHCPBKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x22341B0", Offset = "0x22331B0", VA = "0x1822341B0")]
	public static IEnumerable<T> FKBGFDNJNPI<T>(params IEnumerable<T>[] NFDAHHPOOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2245750", Offset = "0x2244750", VA = "0x182245750")]
	public static bool IGJCMFHLIOH<T>(this IEnumerable<T> EHNCKNECPAL, IEnumerable<T> JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x22341B0", Offset = "0x22331B0", VA = "0x1822341B0")]
	public static IEnumerable<(TKey, TValue)> KKCCPMCJCGM<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2246F70", Offset = "0x2245F70", VA = "0x182246F70")]
	public static IEnumerable<T> NJGEOBEAGDL<T, TKey>(this IEnumerable<T> NLKNKDBPBIB, Func<T, TKey> MAMGNMBMDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1764680", Offset = "0x1763680", VA = "0x181764680")]
	[IteratorStateMachine(typeof(IEEDGNHKGAM))]
	public static IEnumerable<T> AIOHLMAPMAJ<T, U>(this IEnumerable<T> AOFCPKBHFEM, IEnumerable<U> JHMCLPBFJBC, [Optional] T FDEAOIFPBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x10311F0", Offset = "0x10301F0", VA = "0x1810311F0")]
	public static T AGGGHGMNFAB<T>(this IEnumerable<T> EHNCKNECPAL, T PNIJKHBHNEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2241B90", Offset = "0x2240B90", VA = "0x182241B90")]
	public static T AGGGHGMNFAB<T>(this IEnumerable<T> EHNCKNECPAL, T PNIJKHBHNEL, Func<T, bool> LEGCKHOACDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2247850", Offset = "0x2246850", VA = "0x182247850")]
	[IteratorStateMachine(typeof(FDBHBJNJEBM))]
	public static IEnumerable<(T, global::AHICIJODGBD<T>)> ONENFGJFHHK<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2247150", Offset = "0x2246150", VA = "0x182247150")]
	public static bool NOPJAMBBOIH<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22341B0", Offset = "0x22331B0", VA = "0x1822341B0")]
	public static IEnumerable<global::DGBFLINGGFB<T>> NOAKOLDJPCH<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x22421E0", Offset = "0x22411E0", VA = "0x1822421E0")]
	public static bool CFLJFFCDDJL<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2242200", Offset = "0x2241200", VA = "0x182242200")]
	public static IEnumerable<T> DCOLICIDNGK<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1764740", Offset = "0x1763740", VA = "0x181764740")]
	[IteratorStateMachine(typeof(CCPOOMJENIC))]
	public static IEnumerable<U> MILEFMMLLLO<U, T>(this IEnumerable<T> AOFCPKBHFEM, Func<BPAHEPIJMJP<U>, T, (bool Zero, U One, IEnumerable<U> Many)> BJJPIKGDJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2246550", Offset = "0x2245550", VA = "0x182246550")]
	public static int MEIMIDGJKEA<T>(this IEnumerable<T> AOFCPKBHFEM, int NNDFPDNBBHD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2242230", Offset = "0x2241230", VA = "0x182242230")]
	public static bool EFNNMGMCBEF<T>(this IEnumerable<T> AOFCPKBHFEM, IEnumerable<T> JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2247240", Offset = "0x2246240", VA = "0x182247240")]
	public static (IEnumerable<T>, IEnumerable<T>) OAOLBKCIJGN<T>(this IEnumerable<T> AOFCPKBHFEM, Func<T, bool> EBLLINLFEMC)
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2245A80", Offset = "0x2244A80", VA = "0x182245A80")]
	public static string IGLOMLHGOJI<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2246200", Offset = "0x2245200", VA = "0x182246200")]
	public static Dictionary<TKey, TValue> KDHLHFGFCHI<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> EHNCKNECPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2246200", Offset = "0x2245200", VA = "0x182246200")]
	public static Dictionary<TKey, TValue> KDHLHFGFCHI<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> EHNCKNECPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1764620", Offset = "0x1763620", VA = "0x181764620")]
	public static HashSet<T> KCGMJFLAPGK<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2242C40", Offset = "0x2241C40", VA = "0x182242C40")]
	public static string HHHDAKNDPOB<T>(this IEnumerable<T> AOFCPKBHFEM, string GAIFEEANGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA7160", Offset = "0x1EA6160", VA = "0x181EA7160")]
	[IteratorStateMachine(typeof(OLEHIJBIIBA))]
	public static IEnumerable<(T, U)> OONMMHOFCKM<T, U>(this IEnumerable<T> AJDPMFOKMPC, IEnumerable<U> DAAPHBHBHCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2241F60", Offset = "0x2240F60", VA = "0x182241F60")]
	public static IEnumerable<V> AKGPMNPBHAB<V, T, U>(this IEnumerable<T> AOFCPKBHFEM, IEnumerable<U> JHMCLPBFJBC, Func<T, U, V> PAKAPHLDKDN, [Optional] T COOJDAOHKCH, [Optional] U PEFJJLNEDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2241FF0", Offset = "0x2240FF0", VA = "0x182241FF0")]
	public static IEnumerable<(T, U)> AKGPMNPBHAB<T, U>(this IEnumerable<T> AOFCPKBHFEM, IEnumerable<U> JHMCLPBFJBC, [Optional] T COOJDAOHKCH, [Optional] U PEFJJLNEDLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MDDHCKLDAHP
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2236720", Offset = "0x2235720", VA = "0x182236720")]
	public static bool NDKCPBDKHPF<T, U>(this T AOFCPKBHFEM, in U AELIHOPICED) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2236680", Offset = "0x2235680", VA = "0x182236680")]
	public static bool DCENOJFNLPH<T>(ref T AOFCPKBHFEM, T JHMCLPBFJBC) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class HDMEBCIGIHC
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2C83470", Offset = "0x2C82470", VA = "0x182C83470")]
	public static bool AOGBKGLMJDK(this in float3 BECDKHGLGNB, float3 ICPOAGANOLH, float HAOMKJEAMEJ = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class FJOBBCAEECN
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x234F2D0", Offset = "0x234E2D0", VA = "0x18234F2D0")]
	public static void BHDEEEHNPPB<T>(this T JELHNILOKLO, Action<T> OMGPNPJOAMJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x234F560", Offset = "0x234E560", VA = "0x18234F560")]
	public static V NNANKGGIJCH<V, T>(this T JELHNILOKLO, Func<T, V> OMGPNPJOAMJ, [Optional] V PNIJKHBHNEL) where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x234F310", Offset = "0x234E310", VA = "0x18234F310")]
	public static T? CADMPFEDLFL<T>(this T AOFCPKBHFEM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x21E51B0", Offset = "0x21E41B0", VA = "0x1821E51B0")]
	[IteratorStateMachine(typeof(OPGJPDOGGNB))]
	public static IEnumerable<T> GMGNKNLMAOK<T>(this T AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x234F480", Offset = "0x234E480", VA = "0x18234F480")]
	public static T[] MFCINMKEGJA<T>(this T AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LGCBOLAILAF
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6667730", Offset = "0x6666730", VA = "0x186667730")]
	private static byte[] ANJMEMANGDB(int IKPJHGONMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6667D30", Offset = "0x6666D30", VA = "0x186667D30")]
	private static byte[] DDGPMOLDEDF(long DGNBBNCNHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6667FA0", Offset = "0x6666FA0", VA = "0x186667FA0")]
	private static byte[] KKMFLLOGMNH(ulong DGNBBNCNHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6667DB0", Offset = "0x6666DB0", VA = "0x186667DB0")]
	public static Guid HHNDJHENABI(params Guid[] OOLMLOEJEHI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x66677B0", Offset = "0x66667B0", VA = "0x1866677B0")]
	public static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, int EGBCAPEEJBF, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6667870", Offset = "0x6666870", VA = "0x186667870")]
	public static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, long EGBCAPEEJBF, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6667C70", Offset = "0x6666C70", VA = "0x186667C70")]
	public static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, ulong EGBCAPEEJBF, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6667930", Offset = "0x6666930", VA = "0x186667930")]
	public static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, in Guid DEDPKNJBGAE, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x66679A0", Offset = "0x66669A0", VA = "0x1866679A0")]
	private static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, byte[] AIHCPPOCBAH, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6668020", Offset = "0x6667020", VA = "0x186668020")]
	private static void LFMBAOCBCFP(byte[] DBODHDCBMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6667F20", Offset = "0x6666F20", VA = "0x186667F20")]
	private static void JJOPKHBIJDG(byte[] DBODHDCBMLJ, int NJMNOIGKPAI, int LIILEENPBBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface DABAKKNLGAB
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLALKMFCABJ ONPGJEFMHBP();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KLALKMFCABJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FFBFJBAACDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAAIONJMHHB();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MHMMDOPAIJB
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HODLDDNMMHG(int LJHLOOAKFHM, int OELAFDACJKF);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float BEDNMPFLAIN(float NGOGKMJIFGH, float HKHGNFGBFBM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GNFJJFILLEA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	long HMOHDCAKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MLGMEEFNGDH
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6668160", Offset = "0x6667160", VA = "0x186668160")]
	public static int FLJCDBEPCEC(this int AOFCPKBHFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x66681D0", Offset = "0x66671D0", VA = "0x1866681D0")]
	public static int NNPOKKAFFHC(this int AOFCPKBHFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6668110", Offset = "0x6667110", VA = "0x186668110")]
	public static int FLDABDHFLHD(this int AOFCPKBHFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6668100", Offset = "0x6667100", VA = "0x186668100")]
	public static int DGEPGIANHAD(this int AOFCPKBHFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xE97E60", Offset = "0xE96E60", VA = "0x180E97E60")]
	public static int GEKKACHJDGA(this int AOFCPKBHFEM, int KJAHKKMJHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xB70760", Offset = "0xB6F760", VA = "0x180B70760")]
	public static int OJLACBGMIGK(this int AOFCPKBHFEM, int KJAHKKMJHHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PCPPDMKINDO
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x248F750", Offset = "0x248E750", VA = "0x18248F750")]
	public static void LEPJGOMAPEJ<TKey, TValue>(this in KeyValuePair<TKey, TValue> AOFCPKBHFEM, out TKey EBOIOCBODNI, out TValue KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x248F5D0", Offset = "0x248E5D0", VA = "0x18248F5D0")]
	public static (TKey, TValue) BLDJBBKKOAD<TKey, TValue>(this in KeyValuePair<TKey, TValue> AOFCPKBHFEM)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x248F6D0", Offset = "0x248E6D0", VA = "0x18248F6D0")]
	public static KeyValuePair<TKey, UValue> HBCIEGDJMIF<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> AOFCPKBHFEM, UValue KPPLMEOMNGF)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FLPINJHKKPG
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PIKIOCOFBNH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Random rng;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public PIKIOCOFBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A41A0", Offset = "0x8A31A0", VA = "0x1808A41A0")]
		internal int <Random>b__0(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x23538F0", Offset = "0x23528F0", VA = "0x1823538F0")]
	public static int IJBABNEDIAH<T>(this IReadOnlyList<T> EGIDMCNFHCK, T KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2357800", Offset = "0x2356800", VA = "0x182357800")]
	public static int OCOGOPKLIHK<T>(this IReadOnlyList<T> EGIDMCNFHCK, T KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2352730", Offset = "0x2351730", VA = "0x182352730")]
	public static void CMEPDJJCKOF<T>(this HashSet<T> FIKNOHMIHMG, IEnumerable<T> ECLIJHMKGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x23570A0", Offset = "0x23560A0", VA = "0x1823570A0")]
	public static void OBAAGAHLAGC<T>(this IList<T> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2357120", Offset = "0x2356120", VA = "0x182357120")]
	public static void OBAAGAHLAGC<T>(this IList<T> EHJGMBFBLBN, int MDLGDFBBDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2353420", Offset = "0x2352420", VA = "0x182353420")]
	public static List<T> EDAFAKDPACE<T>(this List<T> MAGFIPGLPJJ, Predicate<T> ELLKBPHIOKA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2353EC0", Offset = "0x2352EC0", VA = "0x182353EC0")]
	public static int IJBABNEDIAH<T>(this IReadOnlyList<T> EHJGMBFBLBN, Predicate<T> LEGCKHOACDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2356DF0", Offset = "0x2355DF0", VA = "0x182356DF0")]
	public static bool NFKEFNKJPAJ<T>(this IReadOnlyList<T> EHJGMBFBLBN, Predicate<T> LEGCKHOACDJ, out List<int> CAHDBKNLLCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2351FB0", Offset = "0x2350FB0", VA = "0x182351FB0")]
	public static bool BNDEAHDJONI<T>(this IReadOnlyList<T> EHJGMBFBLBN, T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2351E20", Offset = "0x2350E20", VA = "0x182351E20")]
	public static bool BNDEAHDJONI<T>(this IReadOnlyList<T> EHJGMBFBLBN, T DKIDMLOAMGB, EqualityComparer<T> DFFHCMEFKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2351600", Offset = "0x2350600", VA = "0x182351600")]
	public static int AALPDKBGILI<TElement, TKey>(this IList<TElement> DDHKKDLOAKA, TKey AIPIMPLOIOD, Func<TElement, TKey> AJFAIABEBKM, [Optional] Func<TKey, TKey, int> HBKJEAGAKKP, int EGBCAPEEJBF = 0, [Optional] int? KJAHKKMJHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x23545A0", Offset = "0x23535A0", VA = "0x1823545A0")]
	public static List<T> LGJPFPONOKK<T>(this IReadOnlyList<T> EHJGMBFBLBN, int KJAHKKMJHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2353630", Offset = "0x2352630", VA = "0x182353630")]
	public static bool GNBBCEAHDPP<T>(this List<T> EHJGMBFBLBN, T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2353260", Offset = "0x2352260", VA = "0x182353260")]
	public static void DKHHKEINDOL<T>(this List<T> EHJGMBFBLBN, IEnumerable<T> MAGFIPGLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2357B90", Offset = "0x2356B90", VA = "0x182357B90")]
	public static void PMMODKPOELK<T>(this List<T> EHJGMBFBLBN, IEnumerable<T> MAGFIPGLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2353510", Offset = "0x2352510", VA = "0x182353510")]
	public static T FNIKBOLIKBE<T>(this List<T> MAGFIPGLPJJ, Predicate<T> ELLKBPHIOKA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2357030", Offset = "0x2356030", VA = "0x182357030")]
	public static T OAOKFECMAIK<T>(this List<T> MAGFIPGLPJJ, int EGBCAPEEJBF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2354470", Offset = "0x2353470", VA = "0x182354470")]
	public static bool JPHCNEHLNNG<T>(this List<T> LPBEHDHCMGK, List<T> PDKAFEILMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2354500", Offset = "0x2353500", VA = "0x182354500")]
	public static T KIKKDEPPBMO<T>(this IList<T> EHJGMBFBLBN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2353570", Offset = "0x2352570", VA = "0x182353570")]
	public static bool GMDEDDMBDCL<T>(IReadOnlyList<T> EHJGMBFBLBN, int EGBCAPEEJBF, out T GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2355C00", Offset = "0x2354C00", VA = "0x182355C00")]
	public static bool LHJMCEMGOCC<T>(IReadOnlyList<T> EHJGMBFBLBN, ICollection MAGFIPGLPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2351D00", Offset = "0x2350D00", VA = "0x182351D00")]
	public static void BADGNDINMFH<T>(IReadOnlyList<T> EHJGMBFBLBN, ref ICollection MAGFIPGLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x23569B0", Offset = "0x23559B0", VA = "0x1823569B0")]
	public static bool MCDFEFALNJL<T>(this IReadOnlyList<T> EHJGMBFBLBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x23579B0", Offset = "0x23569B0", VA = "0x1823579B0")]
	public static string PLIABEBEPOA<T>(this IEnumerable<T> EHJGMBFBLBN, string APHKIMFFFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2356820", Offset = "0x2355820", VA = "0x182356820")]
	public static T LHMIMNPKHGH<T>(this IList<T> AOFCPKBHFEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2356A90", Offset = "0x2355A90", VA = "0x182356A90")]
	public static T NAMAJDCPMPI<T>(this IList<T> AOFCPKBHFEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x23543E0", Offset = "0x23533E0", VA = "0x1823543E0")]
	public static void JNENKOFIBDN<T>(this IList<T> AOFCPKBHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2356C40", Offset = "0x2355C40", VA = "0x182356C40")]
	public static void NCJPHCHGJEM<T>(this IList<T> AOFCPKBHFEM, in T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2353850", Offset = "0x2352850", VA = "0x182353850")]
	public static T IIFMEJLKCJL<T>(this IList<T> AOFCPKBHFEM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class JDBLCPBLJLJ
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static float FIKHNBGPGIH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static float OILEPBLBFHL;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static bool DMJMOAPFDCK;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly float GMBCANJGFEO;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6667280", Offset = "0x6666280", VA = "0x186667280")]
	public static bool FNLBLCKHAED(float BECDKHGLGNB, float ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4915980", Offset = "0x4914980", VA = "0x184915980")]
	public static float OGFGECJCCHB(float KPPLMEOMNGF, float EKDCKLAKFJN, float IBFPNBPAEOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x49159A0", Offset = "0x49149A0", VA = "0x1849159A0")]
	public static int OGFGECJCCHB(int KPPLMEOMNGF, int EKDCKLAKFJN, int IBFPNBPAEOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4915960", Offset = "0x4914960", VA = "0x184915960")]
	public static float IIMNPFDEBFF(float KPPLMEOMNGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6667440", Offset = "0x6666440", VA = "0x186667440")]
	public static float KADPLFGEIDC(float BECDKHGLGNB, float ICPOAGANOLH, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3952DA0", Offset = "0x3951DA0", VA = "0x183952DA0")]
	public static float FAPJENLENAN(float BECDKHGLGNB, float ICPOAGANOLH, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6667380", Offset = "0x6666380", VA = "0x186667380")]
	public static float HFFAPPEDELG(float BECDKHGLGNB, float ICPOAGANOLH, float KPPLMEOMNGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x66674E0", Offset = "0x66664E0", VA = "0x1866674E0")]
	public static float NACCOPKKCIK(float BECDKHGLGNB, float ICPOAGANOLH, float KPPLMEOMNGF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BNANOKNNLPO
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x32A7560", Offset = "0x32A6560", VA = "0x1832A7560")]
	public static bool LOMFAFDABPE<T>(this object AOFCPKBHFEM, out T GPPHCPBMODE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KPJMOKDCFHI
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x66676C0", Offset = "0x66666C0", VA = "0x1866676C0")]
	public static bool AOGBKGLMJDK(this quaternion AJDPMFOKMPC, quaternion DAAPHBHBHCO, float OGEFIELCPJN = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class OPAGDEJPNCN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private sealed class IOGLKJHEJLJ : MHMMDOPAIJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Random PIPMCLBDLLN;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x66671E0", Offset = "0x66661E0", VA = "0x1866671E0", Slot = "4")]
		public int HODLDDNMMHG(int NGOGKMJIFGH, int AOPKGCJDLNM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6667130", Offset = "0x6666130", VA = "0x186667130", Slot = "5")]
		public float BEDNMPFLAIN(float NGOGKMJIFGH, float HKHGNFGBFBM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x66671A0", Offset = "0x66661A0", VA = "0x1866671A0")]
		private double GEOGKAPGKBF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6667210", Offset = "0x6666210", VA = "0x186667210")]
		public IOGLKJHEJLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly MHMMDOPAIJB LGJPFPONOKK;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x66682A0", Offset = "0x66672A0", VA = "0x1866682A0")]
	public static ulong CKCAMNKFGPB()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FAMDOEAIJHI
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2349EE0", Offset = "0x2348EE0", VA = "0x182349EE0")]
	public static bool PMCEJLNJLEC<T>(this IReadOnlyCollection<T> AOFCPKBHFEM, int EGBCAPEEJBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CBBHBAEPBKD
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x32AAC80", Offset = "0x32A9C80", VA = "0x1832AAC80")]
	public static bool OHBANFGHGGE<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF, out T GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x32AAB30", Offset = "0x32A9B30", VA = "0x1832AAB30")]
	public static bool EOELPOCMKIG<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF, out global::DGBFLINGGFB<T> GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x32AAAB0", Offset = "0x32A9AB0", VA = "0x1832AAAB0")]
	public static T EKFIDEKLFGB<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF, in T FBBJJPJMOPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x22B6EC0", Offset = "0x22B5EC0", VA = "0x1822B6EC0")]
	public static T BCMDOJLGGCO<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x32AAA00", Offset = "0x32A9A00", VA = "0x1832AAA00")]
	public static T? AFEDLCAEHGA<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KGJENKLKFOI
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x21E7A10", Offset = "0x21E6A10", VA = "0x1821E7A10")]
	public static T BOEAFIEBIHC<T>(this in ReadOnlyMemory<T> AOFCPKBHFEM, int EGBCAPEEJBF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IKMGKHGCJIL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static GNFJJFILLEA JOMHBADDBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6666FF0", Offset = "0x6665FF0", VA = "0x186666FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6666F60", Offset = "0x6665F60", VA = "0x186666F60")]
	public static double AIMBKFIEDBD(this GNFJJFILLEA AOFCPKBHFEM, long LFENIFPDNOH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class AFFHKOFPEIA : GNFJJFILLEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Stopwatch KFLMLLGELBK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long HMOHDCAKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x66668B0", Offset = "0x66658B0", VA = "0x1866668B0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	private AFFHKOFPEIA(Stopwatch PKADFIOHLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6666850", Offset = "0x6665850", VA = "0x186666850")]
	public static AFFHKOFPEIA FEPENBMLCIL(Stopwatch PKADFIOHLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x66667B0", Offset = "0x66657B0", VA = "0x1866667B0")]
	public static AFFHKOFPEIA ACGDBFNOCMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IHCJEKHGMAK
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6666F00", Offset = "0x6665F00", VA = "0x186666F00")]
	public static RigidTransform HHLBBGKAECP(this in RigidTransform AOFCPKBHFEM)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class KMJPCDHDLAL
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6667600", Offset = "0x6666600", VA = "0x186667600")]
	public static RigidTransform GEDKCLAJAIH(RigidTransform GHMEPNPMHGC, RigidTransform OFHKALFLKOF)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class PGOCMJEOBGN
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xC2C8C0", Offset = "0xC2B8C0", VA = "0x180C2C8C0")]
	public static bool MCDFEFALNJL(this string JBBLMAOAMGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class IKJEGAPCMIH<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LMDBNJNBPID : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3309650", Offset = "0x3308650", VA = "0x183309650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static int CNBJNKEGHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static IFLEFHLGBOA LGJKIBPIMKN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long HMOHDCAKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1108C50", Offset = "0x1107C50", VA = "0x181108C50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x11089F0", Offset = "0x11079F0", VA = "0x1811089F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1108CA0", Offset = "0x1107CA0", VA = "0x181108CA0")]
	public static LMDBNJNBPID MKANFFBBFFF()
	{
		return default(LMDBNJNBPID);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1108AC0", Offset = "0x1107AC0", VA = "0x181108AC0")]
	private static void IMFCBCCGGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1108A50", Offset = "0x1107A50", VA = "0x181108A50")]
	public static void IKINEIFADPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct IFLEFHLGBOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly GNFJJFILLEA KFLMLLGELBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly long LOPEGGKGEBI;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6666E90", Offset = "0x6665E90", VA = "0x186666E90")]
	public IFLEFHLGBOA(GNFJJFILLEA PKADFIOHLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6666CE0", Offset = "0x6665CE0", VA = "0x186666CE0")]
	public long AHKNJNGKACH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6666D70", Offset = "0x6665D70", VA = "0x186666D70")]
	public double AIMBKFIEDBD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6666E00", Offset = "0x6665E00", VA = "0x186666E00")]
	public double LAPJFJIDJFG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ANOOCGLOJIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA16F40", Offset = "0xA15F40", VA = "0x180A16F40")]
	public static bool MAHFGFPAPEI(this Type AOFCPKBHFEM, Type JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x176E230", Offset = "0x176D230", VA = "0x18176E230")]
	public static bool MAHFGFPAPEI<T>(this Type AOFCPKBHFEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class HJBELDPCPJN
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xE97E60", Offset = "0xE96E60", VA = "0x180E97E60")]
	public static uint GEKKACHJDGA(this uint AOFCPKBHFEM, int KJAHKKMJHHG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xB70760", Offset = "0xB6F760", VA = "0x180B70760")]
	public static uint OJLACBGMIGK(this uint AOFCPKBHFEM, int KJAHKKMJHHG)
	{
		return default(uint);
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
