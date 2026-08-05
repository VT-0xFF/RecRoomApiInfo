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
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x66E6EA0", Offset = "0x66E62A0", VA = "0x1866E6EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F20EA0", Offset = "0x2F202A0", VA = "0x182F20EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3184470", Offset = "0x3183870", VA = "0x183184470")]
		public GFHMIECOIDH(T[] CBLHMABDMMM, EPELMEPBLBK<T> HBKJEAGAKKP, int OFJDFHLGFBG, Func<bool> IELNCFNHIDL, T[] PKPKNJICONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x31840E0", Offset = "0x31834E0", VA = "0x1831840E0")]
		public bool ACNMKOHBBPO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate U HENGPCKDEGG<T, U>(int EEAHJGGOIKH, int MAMHFDOLFKM, in ReadOnlySpan<T> JIACAECEIBG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2339960", Offset = "0x2338D60", VA = "0x182339960")]
	public static ReadOnlyMemory<T> PBHGCHMNNBF<T>(this T[] AOFCPKBHFEM)
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF430", Offset = "0x2DFE830", VA = "0x182DFF430")]
	public static T[] CNJKCPLPDLK<T>(int MKMGHJFMNMB, T FDEAOIFPBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF2A0", Offset = "0x2DFE6A0", VA = "0x182DFF2A0")]
	public static void BCHKCBODCFH<T>(this T[] FICCNBPNNHA, T FDEAOIFPBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1475340", Offset = "0x1474740", VA = "0x181475340")]
	public static void DOJLKBEKEJJ<T>(this T[] EGIDMCNFHCK, int BDAADCOCKII, int CENFIFAIEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2DFFB90", Offset = "0x2DFEF90", VA = "0x182DFFB90")]
	private static void HDJIBMJJHEA<T>(this T[] AOFCPKBHFEM, int BMKDJDNNMEA, int ONGABMOBOPN, T[] JHMCLPBFJBC, int KDLGOIJNGDD, int AGFNEHFAFHC, T[] GPPHCPBMODE, int IHMGMKEEKNA, EPELMEPBLBK<T> HBKJEAGAKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF690", Offset = "0x2DFEA90", VA = "0x182DFF690")]
	public static void DOEMNNGLIMD<T>(this T[] AOFCPKBHFEM, int GJPBLFPOONO, int KJAHKKMJHHG, EPELMEPBLBK<T> HBKJEAGAKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2DFFF90", Offset = "0x2DFF390", VA = "0x182DFFF90")]
	public static GFHMIECOIDH<T> IFBEBFOHMML<T>(this T[] AOFCPKBHFEM, EPELMEPBLBK<T> HBKJEAGAKKP, int OFJDFHLGFBG, Func<bool> IELNCFNHIDL, [Optional] T[] PKPKNJICONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2E00030", Offset = "0x2DFF430", VA = "0x182E00030")]
	public static T[] OIEPKIMNLDG<T>(this T[] EGIDMCNFHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF5B0", Offset = "0x2DFE9B0", VA = "0x182DFF5B0")]
	public static T[] DLGINBBAKFC<T>(this T[] PEHJIPFOPCH, T AELGGFIADMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2E00640", Offset = "0x2DFFA40", VA = "0x182E00640")]
	public static T[] PKHENHIFNJG<T>(this T[] PEHJIPFOPCH, int EGBCAPEEJBF, T AELGGFIADMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E00050", Offset = "0x2DFF450", VA = "0x182E00050")]
	public static T[] OJMMOGOBFED<T>(this T[] PEHJIPFOPCH, int EGBCAPEEJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF070", Offset = "0x2DFE470", VA = "0x182DFF070")]
	public static T[] BCEAFBFEJOA<T>(this T[] PEHJIPFOPCH, int EGBCAPEEJBF, T AELGGFIADMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E00100", Offset = "0x2DFF500", VA = "0x182E00100")]
	public static U[] PJDKJEPEHHO<U, T>(this T[] OBPNIKFBDBK, int EMIJCJILDFM, HENGPCKDEGG<T, U> CGBGOOPBDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66E5560", Offset = "0x66E4960", VA = "0x1866E5560")]
	public static byte[] OAHOOHLHJPM(this byte[] AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x66E5770", Offset = "0x66E4B70", VA = "0x1866E5770")]
	public static byte[] PGDKHNKPMDM(this byte[] AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KENOFCEMIHB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37D3A10", Offset = "0x37D2E10", VA = "0x1837D3A10")]
	public static void CMEPDJJCKOF<T>(this ICollection<T> AOFCPKBHFEM, IEnumerable<T> ECLIJHMKGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KOLEOACHALH
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37E0D90", Offset = "0x37E0190", VA = "0x1837E0D90")]
	public static void GBFGOMPMDNG<K, V>(this IDictionary<K, V> AOFCPKBHFEM, in K EBOIOCBODNI, in V KPPLMEOMNGF, Func<V, V, V> LOGLPMMEKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x37E0740", Offset = "0x37DFB40", VA = "0x1837E0740")]
	public static void AKHHODHOFAE<K, V>(this IDictionary<K, List<V>> AOFCPKBHFEM, in K EBOIOCBODNI, in V KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37E1EB0", Offset = "0x37E12B0", VA = "0x1837E1EB0")]
	public static TVal KKIINDDINID<TVal, TKey>(this IDictionary<TKey, TVal> GCMGJFGGLEN, in TKey EBOIOCBODNI, [Optional] TVal PNIJKHBHNEL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37E1B20", Offset = "0x37E0F20", VA = "0x1837E1B20")]
	public static TVal KKIINDDINID<TVal, TKey>(this IDictionary<TKey, TVal> GCMGJFGGLEN, in TKey EBOIOCBODNI, Func<TVal> KECFFGCANAL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37E1300", Offset = "0x37E0700", VA = "0x1837E1300")]
	public static TValue HPGKMHPNJHL<TValue, TKey>(this IDictionary<TKey, TValue> GCMGJFGGLEN, in TKey EBOIOCBODNI, [Optional] in TValue PNIJKHBHNEL)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37E2970", Offset = "0x37E1D70", VA = "0x1837E2970")]
	public static V LDNAALFCOGL<V, K>(this IDictionary<K, V> AOFCPKBHFEM, in K EBOIOCBODNI)
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37E1A90", Offset = "0x37E0E90", VA = "0x1837E1A90")]
	public static T2[] IFPMJMGFJLK<T2, T1>(this Dictionary<T1, T2>.ValueCollection ECDHPFPEBML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37E0CD0", Offset = "0x37E00D0", VA = "0x1837E0CD0")]
	public static bool APHPNPEMCLE<TKey, TValue>(this IDictionary<TKey, TValue> AOFCPKBHFEM, TKey EBOIOCBODNI, TValue KPPLMEOMNGF)
	{
		return default(bool);
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
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2964F00", Offset = "0x2964300", VA = "0x182964F00")]
		public (bool, T, IEnumerable<T>) BKDHGDDJKDD(T OCMDHDJPHNM)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2964F70", Offset = "0x2964370", VA = "0x182964F70")]
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

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public KCNFBLBEEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x284B100", Offset = "0x284A500", VA = "0x18284B100")]
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

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public BMNCLDLIFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x166EC70", Offset = "0x166E070", VA = "0x18166EC70")]
		internal bool <SetEqual>b__0(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x40C01C0", Offset = "0x40BF5C0", VA = "0x1840C01C0")]
		internal bool <SetEqual>b__1(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x24B05B0", Offset = "0x24AF9B0", VA = "0x1824B05B0")]
	public static bool OOJLNPFKDBC<T, TArgs>(this IEnumerable<T> AOFCPKBHFEM, in TArgs KCPODLJODHA, AEFNAAOMLJF<TArgs, T> LEGCKHOACDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x24AC070", Offset = "0x24AB470", VA = "0x1824AC070")]
	public static U HFEAKHONOLL<U, T>(this IEnumerable<T> AOFCPKBHFEM, Func<U> DNNDPDKPLBK, Func<T, U> OCMDHDJPHNM, Func<IEnumerable<T>, U> NAOMIGPBCKL)
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x24AEC80", Offset = "0x24AE080", VA = "0x1824AEC80")]
	public static bool MILBNLDJCCH<T, TArgs>(this IEnumerable<T> AOFCPKBHFEM, in TArgs KCPODLJODHA, AEFNAAOMLJF<TArgs, T> LEGCKHOACDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x24AF980", Offset = "0x24AED80", VA = "0x1824AF980")]
	public static U OLELGPBDMGE<U, T, TArg>(this IEnumerable<T> AOFCPKBHFEM, in TArg OGEFBAJDPAC, KEMAFOOKLOC<TArg, U> DNNDPDKPLBK, PHPPNMNDEBD<TArg, T, U> OCMDHDJPHNM, BBEOAAGBFGL<TArg, T, U> NAOMIGPBCKL)
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x24AEFE0", Offset = "0x24AE3E0", VA = "0x1824AEFE0")]
	public static IEnumerable<U> NEBIDBHHEGI<U, T, TArg>(this IEnumerable<T> AOFCPKBHFEM, in TArg OGEFBAJDPAC, MKDGAEDBIAJ<TArg, T, U> HFHIHCPBKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x23E57A0", Offset = "0x23E4BA0", VA = "0x1823E57A0")]
	public static IEnumerable<T> FKBGFDNJNPI<T>(params IEnumerable<T>[] NFDAHHPOOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x24ADFC0", Offset = "0x24AD3C0", VA = "0x1824ADFC0")]
	public static bool IGJCMFHLIOH<T>(this IEnumerable<T> EHNCKNECPAL, IEnumerable<T> JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x23E57A0", Offset = "0x23E4BA0", VA = "0x1823E57A0")]
	public static IEnumerable<(TKey, TValue)> KKCCPMCJCGM<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x24AF420", Offset = "0x24AE820", VA = "0x1824AF420")]
	public static IEnumerable<T> NJGEOBEAGDL<T, TKey>(this IEnumerable<T> NLKNKDBPBIB, Func<T, TKey> MAMGNMBMDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x17E5830", Offset = "0x17E4C30", VA = "0x1817E5830")]
	[IteratorStateMachine(typeof(IEEDGNHKGAM))]
	public static IEnumerable<T> AIOHLMAPMAJ<T, U>(this IEnumerable<T> AOFCPKBHFEM, IEnumerable<U> JHMCLPBFJBC, [Optional] T FDEAOIFPBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x147D520", Offset = "0x147C920", VA = "0x18147D520")]
	public static T AGGGHGMNFAB<T>(this IEnumerable<T> EHNCKNECPAL, T PNIJKHBHNEL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x24AB830", Offset = "0x24AAC30", VA = "0x1824AB830")]
	public static T AGGGHGMNFAB<T>(this IEnumerable<T> EHNCKNECPAL, T PNIJKHBHNEL, Func<T, bool> LEGCKHOACDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x24AFD80", Offset = "0x24AF180", VA = "0x1824AFD80")]
	[IteratorStateMachine(typeof(FDBHBJNJEBM))]
	public static IEnumerable<(T, global::AHICIJODGBD<T>)> ONENFGJFHHK<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x24AF600", Offset = "0x24AEA00", VA = "0x1824AF600")]
	public static bool NOPJAMBBOIH<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x23E57A0", Offset = "0x23E4BA0", VA = "0x1823E57A0")]
	public static IEnumerable<global::DGBFLINGGFB<T>> NOAKOLDJPCH<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x24ABE80", Offset = "0x24AB280", VA = "0x1824ABE80")]
	public static bool CFLJFFCDDJL<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x24ABEA0", Offset = "0x24AB2A0", VA = "0x1824ABEA0")]
	public static IEnumerable<T> DCOLICIDNGK<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x17E56F0", Offset = "0x17E4AF0", VA = "0x1817E56F0")]
	[IteratorStateMachine(typeof(CCPOOMJENIC))]
	public static IEnumerable<U> MILEFMMLLLO<U, T>(this IEnumerable<T> AOFCPKBHFEM, Func<BPAHEPIJMJP<U>, T, (bool Zero, U One, IEnumerable<U> Many)> BJJPIKGDJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x24AEA00", Offset = "0x24ADE00", VA = "0x1824AEA00")]
	public static int MEIMIDGJKEA<T>(this IEnumerable<T> AOFCPKBHFEM, int NNDFPDNBBHD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x24ABED0", Offset = "0x24AB2D0", VA = "0x1824ABED0")]
	public static bool EFNNMGMCBEF<T>(this IEnumerable<T> AOFCPKBHFEM, IEnumerable<T> JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x24AF6F0", Offset = "0x24AEAF0", VA = "0x1824AF6F0")]
	public static (IEnumerable<T>, IEnumerable<T>) OAOLBKCIJGN<T>(this IEnumerable<T> AOFCPKBHFEM, Func<T, bool> EBLLINLFEMC)
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x24AE2F0", Offset = "0x24AD6F0", VA = "0x1824AE2F0")]
	public static string IGLOMLHGOJI<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x24AE6B0", Offset = "0x24ADAB0", VA = "0x1824AE6B0")]
	public static Dictionary<TKey, TValue> KDHLHFGFCHI<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> EHNCKNECPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x24AE6B0", Offset = "0x24ADAB0", VA = "0x1824AE6B0")]
	public static Dictionary<TKey, TValue> KDHLHFGFCHI<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> EHNCKNECPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2321610", Offset = "0x2320A10", VA = "0x182321610")]
	public static HashSet<T> KCGMJFLAPGK<T>(this IEnumerable<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24AC9A0", Offset = "0x24ABDA0", VA = "0x1824AC9A0")]
	public static string HHHDAKNDPOB<T>(this IEnumerable<T> AOFCPKBHFEM, string GAIFEEANGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x17E5650", Offset = "0x17E4A50", VA = "0x1817E5650")]
	[IteratorStateMachine(typeof(OLEHIJBIIBA))]
	public static IEnumerable<(T, U)> OONMMHOFCKM<T, U>(this IEnumerable<T> AJDPMFOKMPC, IEnumerable<U> DAAPHBHBHCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24ABC00", Offset = "0x24AB000", VA = "0x1824ABC00")]
	public static IEnumerable<V> AKGPMNPBHAB<V, T, U>(this IEnumerable<T> AOFCPKBHFEM, IEnumerable<U> JHMCLPBFJBC, Func<T, U, V> PAKAPHLDKDN, [Optional] T COOJDAOHKCH, [Optional] U PEFJJLNEDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24ABC90", Offset = "0x24AB090", VA = "0x1824ABC90")]
	public static IEnumerable<(T, U)> AKGPMNPBHAB<T, U>(this IEnumerable<T> AOFCPKBHFEM, IEnumerable<U> JHMCLPBFJBC, [Optional] T COOJDAOHKCH, [Optional] U PEFJJLNEDLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MDDHCKLDAHP
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x29E9D90", Offset = "0x29E9190", VA = "0x1829E9D90")]
	public static bool NDKCPBDKHPF<T, U>(this T AOFCPKBHFEM, in U AELIHOPICED) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x29E9CF0", Offset = "0x29E90F0", VA = "0x1829E9CF0")]
	public static bool DCENOJFNLPH<T>(ref T AOFCPKBHFEM, T JHMCLPBFJBC) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class HDMEBCIGIHC
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD17A0", Offset = "0x2CD0BA0", VA = "0x182CD17A0")]
	public static bool AOGBKGLMJDK(this in float3 BECDKHGLGNB, float3 ICPOAGANOLH, float HAOMKJEAMEJ = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class FJOBBCAEECN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x237F400", Offset = "0x237E800", VA = "0x18237F400")]
	public static void BHDEEEHNPPB<T>(this T JELHNILOKLO, Action<T> OMGPNPJOAMJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x237F780", Offset = "0x237EB80", VA = "0x18237F780")]
	public static V NNANKGGIJCH<V, T>(this T JELHNILOKLO, Func<T, V> OMGPNPJOAMJ, [Optional] V PNIJKHBHNEL) where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x237F480", Offset = "0x237E880", VA = "0x18237F480")]
	public static T? CADMPFEDLFL<T>(this T AOFCPKBHFEM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x237F5B0", Offset = "0x237E9B0", VA = "0x18237F5B0")]
	[IteratorStateMachine(typeof(OPGJPDOGGNB))]
	public static IEnumerable<T> GMGNKNLMAOK<T>(this T AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x237F6A0", Offset = "0x237EAA0", VA = "0x18237F6A0")]
	public static T[] MFCINMKEGJA<T>(this T AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LGCBOLAILAF
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x66E63C0", Offset = "0x66E57C0", VA = "0x1866E63C0")]
	private static byte[] ANJMEMANGDB(int IKPJHGONMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x66E69C0", Offset = "0x66E5DC0", VA = "0x1866E69C0")]
	private static byte[] DDGPMOLDEDF(long DGNBBNCNHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x66E6C30", Offset = "0x66E6030", VA = "0x1866E6C30")]
	private static byte[] KKMFLLOGMNH(ulong DGNBBNCNHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x66E6A40", Offset = "0x66E5E40", VA = "0x1866E6A40")]
	public static Guid HHNDJHENABI(params Guid[] OOLMLOEJEHI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x66E6440", Offset = "0x66E5840", VA = "0x1866E6440")]
	public static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, int EGBCAPEEJBF, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x66E6500", Offset = "0x66E5900", VA = "0x1866E6500")]
	public static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, long EGBCAPEEJBF, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x66E6900", Offset = "0x66E5D00", VA = "0x1866E6900")]
	public static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, ulong EGBCAPEEJBF, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x66E65C0", Offset = "0x66E59C0", VA = "0x1866E65C0")]
	public static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, in Guid DEDPKNJBGAE, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x66E6630", Offset = "0x66E5A30", VA = "0x1866E6630")]
	private static Guid BMDGCEOIEEG(in Guid OFCEKGDHKAE, byte[] AIHCPPOCBAH, int LFMBJAIIPEH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x66E6CB0", Offset = "0x66E60B0", VA = "0x1866E6CB0")]
	private static void LFMBAOCBCFP(byte[] DBODHDCBMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x66E6BB0", Offset = "0x66E5FB0", VA = "0x1866E6BB0")]
	private static void JJOPKHBIJDG(byte[] DBODHDCBMLJ, int NJMNOIGKPAI, int LIILEENPBBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface DABAKKNLGAB
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLALKMFCABJ ONPGJEFMHBP();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KLALKMFCABJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FFBFJBAACDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAAIONJMHHB();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MHMMDOPAIJB
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HODLDDNMMHG(int LJHLOOAKFHM, int OELAFDACJKF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float BEDNMPFLAIN(float NGOGKMJIFGH, float HKHGNFGBFBM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GNFJJFILLEA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	long HMOHDCAKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MLGMEEFNGDH
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x66E6DF0", Offset = "0x66E61F0", VA = "0x1866E6DF0")]
	public static int FLJCDBEPCEC(this int AOFCPKBHFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x66E6E60", Offset = "0x66E6260", VA = "0x1866E6E60")]
	public static int NNPOKKAFFHC(this int AOFCPKBHFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x66E6DA0", Offset = "0x66E61A0", VA = "0x1866E6DA0")]
	public static int FLDABDHFLHD(this int AOFCPKBHFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x66E6D90", Offset = "0x66E6190", VA = "0x1866E6D90")]
	public static int DGEPGIANHAD(this int AOFCPKBHFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xE9D060", Offset = "0xE9C460", VA = "0x180E9D060")]
	public static int GEKKACHJDGA(this int AOFCPKBHFEM, int KJAHKKMJHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0xB71760", Offset = "0xB70B60", VA = "0x180B71760")]
	public static int OJLACBGMIGK(this int AOFCPKBHFEM, int KJAHKKMJHHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PCPPDMKINDO
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2344570", Offset = "0x2343970", VA = "0x182344570")]
	public static void LEPJGOMAPEJ<TKey, TValue>(this in KeyValuePair<TKey, TValue> AOFCPKBHFEM, out TKey EBOIOCBODNI, out TValue KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x23443F0", Offset = "0x23437F0", VA = "0x1823443F0")]
	public static (TKey, TValue) BLDJBBKKOAD<TKey, TValue>(this in KeyValuePair<TKey, TValue> AOFCPKBHFEM)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x23444F0", Offset = "0x23438F0", VA = "0x1823444F0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public PIKIOCOFBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A51A0", Offset = "0x8A45A0", VA = "0x1808A51A0")]
		internal int <Random>b__0(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2383A40", Offset = "0x2382E40", VA = "0x182383A40")]
	public static int IJBABNEDIAH<T>(this IReadOnlyList<T> EGIDMCNFHCK, T KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2387B40", Offset = "0x2386F40", VA = "0x182387B40")]
	public static int OCOGOPKLIHK<T>(this IReadOnlyList<T> EGIDMCNFHCK, T KPPLMEOMNGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2382880", Offset = "0x2381C80", VA = "0x182382880")]
	public static void CMEPDJJCKOF<T>(this HashSet<T> FIKNOHMIHMG, IEnumerable<T> ECLIJHMKGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x23873E0", Offset = "0x23867E0", VA = "0x1823873E0")]
	public static void OBAAGAHLAGC<T>(this IList<T> EHJGMBFBLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2387460", Offset = "0x2386860", VA = "0x182387460")]
	public static void OBAAGAHLAGC<T>(this IList<T> EHJGMBFBLBN, int MDLGDFBBDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2383570", Offset = "0x2382970", VA = "0x182383570")]
	public static List<T> EDAFAKDPACE<T>(this List<T> MAGFIPGLPJJ, Predicate<T> ELLKBPHIOKA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2384010", Offset = "0x2383410", VA = "0x182384010")]
	public static int IJBABNEDIAH<T>(this IReadOnlyList<T> EHJGMBFBLBN, Predicate<T> LEGCKHOACDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2386EF0", Offset = "0x23862F0", VA = "0x182386EF0")]
	public static bool NFKEFNKJPAJ<T>(this IReadOnlyList<T> EHJGMBFBLBN, Predicate<T> LEGCKHOACDJ, out List<int> CAHDBKNLLCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x23821A0", Offset = "0x23815A0", VA = "0x1823821A0")]
	public static bool BNDEAHDJONI<T>(this IReadOnlyList<T> EHJGMBFBLBN, T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2382010", Offset = "0x2381410", VA = "0x182382010")]
	public static bool BNDEAHDJONI<T>(this IReadOnlyList<T> EHJGMBFBLBN, T DKIDMLOAMGB, EqualityComparer<T> DFFHCMEFKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x23817F0", Offset = "0x2380BF0", VA = "0x1823817F0")]
	public static int AALPDKBGILI<TElement, TKey>(this IList<TElement> DDHKKDLOAKA, TKey AIPIMPLOIOD, Func<TElement, TKey> AJFAIABEBKM, [Optional] Func<TKey, TKey, int> HBKJEAGAKKP, int EGBCAPEEJBF = 0, [Optional] int? KJAHKKMJHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x23846F0", Offset = "0x2383AF0", VA = "0x1823846F0")]
	public static List<T> LGJPFPONOKK<T>(this IReadOnlyList<T> EHJGMBFBLBN, int KJAHKKMJHHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2383780", Offset = "0x2382B80", VA = "0x182383780")]
	public static bool GNBBCEAHDPP<T>(this List<T> EHJGMBFBLBN, T DKIDMLOAMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x23833B0", Offset = "0x23827B0", VA = "0x1823833B0")]
	public static void DKHHKEINDOL<T>(this List<T> EHJGMBFBLBN, IEnumerable<T> MAGFIPGLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2387ED0", Offset = "0x23872D0", VA = "0x182387ED0")]
	public static void PMMODKPOELK<T>(this List<T> EHJGMBFBLBN, IEnumerable<T> MAGFIPGLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2383660", Offset = "0x2382A60", VA = "0x182383660")]
	public static T FNIKBOLIKBE<T>(this List<T> MAGFIPGLPJJ, Predicate<T> ELLKBPHIOKA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2387370", Offset = "0x2386770", VA = "0x182387370")]
	public static T OAOKFECMAIK<T>(this List<T> MAGFIPGLPJJ, int EGBCAPEEJBF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x23845C0", Offset = "0x23839C0", VA = "0x1823845C0")]
	public static bool JPHCNEHLNNG<T>(this List<T> LPBEHDHCMGK, List<T> PDKAFEILMHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2384650", Offset = "0x2383A50", VA = "0x182384650")]
	public static T KIKKDEPPBMO<T>(this IList<T> EHJGMBFBLBN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x23836C0", Offset = "0x2382AC0", VA = "0x1823836C0")]
	public static bool GMDEDDMBDCL<T>(IReadOnlyList<T> EHJGMBFBLBN, int EGBCAPEEJBF, out T GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2385D50", Offset = "0x2385150", VA = "0x182385D50")]
	public static bool LHJMCEMGOCC<T>(IReadOnlyList<T> EHJGMBFBLBN, ICollection MAGFIPGLPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2381EF0", Offset = "0x23812F0", VA = "0x182381EF0")]
	public static void BADGNDINMFH<T>(IReadOnlyList<T> EHJGMBFBLBN, ref ICollection MAGFIPGLPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2322A50", Offset = "0x2321E50", VA = "0x182322A50")]
	public static bool MCDFEFALNJL<T>(this IReadOnlyList<T> EHJGMBFBLBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2387CF0", Offset = "0x23870F0", VA = "0x182387CF0")]
	public static string PLIABEBEPOA<T>(this IEnumerable<T> EHJGMBFBLBN, string APHKIMFFFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2386970", Offset = "0x2385D70", VA = "0x182386970")]
	public static T LHMIMNPKHGH<T>(this IList<T> AOFCPKBHFEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2386B90", Offset = "0x2385F90", VA = "0x182386B90")]
	public static T NAMAJDCPMPI<T>(this IList<T> AOFCPKBHFEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2384530", Offset = "0x2383930", VA = "0x182384530")]
	public static void JNENKOFIBDN<T>(this IList<T> AOFCPKBHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2386D40", Offset = "0x2386140", VA = "0x182386D40")]
	public static void NCJPHCHGJEM<T>(this IList<T> AOFCPKBHFEM, in T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x23839A0", Offset = "0x2382DA0", VA = "0x1823839A0")]
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

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x66E5F10", Offset = "0x66E5310", VA = "0x1866E5F10")]
	public static bool FNLBLCKHAED(float BECDKHGLGNB, float ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x49CBD50", Offset = "0x49CB150", VA = "0x1849CBD50")]
	public static float OGFGECJCCHB(float KPPLMEOMNGF, float EKDCKLAKFJN, float IBFPNBPAEOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x49CBD70", Offset = "0x49CB170", VA = "0x1849CBD70")]
	public static int OGFGECJCCHB(int KPPLMEOMNGF, int EKDCKLAKFJN, int IBFPNBPAEOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x49CBD30", Offset = "0x49CB130", VA = "0x1849CBD30")]
	public static float IIMNPFDEBFF(float KPPLMEOMNGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x66E60D0", Offset = "0x66E54D0", VA = "0x1866E60D0")]
	public static float KADPLFGEIDC(float BECDKHGLGNB, float ICPOAGANOLH, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x39F6380", Offset = "0x39F5780", VA = "0x1839F6380")]
	public static float FAPJENLENAN(float BECDKHGLGNB, float ICPOAGANOLH, float JELHNILOKLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x66E6010", Offset = "0x66E5410", VA = "0x1866E6010")]
	public static float HFFAPPEDELG(float BECDKHGLGNB, float ICPOAGANOLH, float KPPLMEOMNGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x66E6170", Offset = "0x66E5570", VA = "0x1866E6170")]
	public static float NACCOPKKCIK(float BECDKHGLGNB, float ICPOAGANOLH, float KPPLMEOMNGF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BNANOKNNLPO
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE9830", Offset = "0x2DE8C30", VA = "0x182DE9830")]
	public static bool LOMFAFDABPE<T>(this object AOFCPKBHFEM, out T GPPHCPBMODE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KPJMOKDCFHI
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x66E6350", Offset = "0x66E5750", VA = "0x1866E6350")]
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

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x66E5E70", Offset = "0x66E5270", VA = "0x1866E5E70", Slot = "4")]
		public int HODLDDNMMHG(int NGOGKMJIFGH, int AOPKGCJDLNM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x66E5DC0", Offset = "0x66E51C0", VA = "0x1866E5DC0", Slot = "5")]
		public float BEDNMPFLAIN(float NGOGKMJIFGH, float HKHGNFGBFBM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x66E5E30", Offset = "0x66E5230", VA = "0x1866E5E30")]
		private double GEOGKAPGKBF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x66E5EA0", Offset = "0x66E52A0", VA = "0x1866E5EA0")]
		public IOGLKJHEJLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly MHMMDOPAIJB LGJPFPONOKK;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x66E6F30", Offset = "0x66E6330", VA = "0x1866E6F30")]
	public static ulong CKCAMNKFGPB()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FAMDOEAIJHI
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E68D20", Offset = "0x1E68120", VA = "0x181E68D20")]
	public static bool PMCEJLNJLEC<T>(this IReadOnlyCollection<T> AOFCPKBHFEM, int EGBCAPEEJBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CBBHBAEPBKD
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2DECF50", Offset = "0x2DEC350", VA = "0x182DECF50")]
	public static bool OHBANFGHGGE<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF, out T GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2DECE00", Offset = "0x2DEC200", VA = "0x182DECE00")]
	public static bool EOELPOCMKIG<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF, out global::DGBFLINGGFB<T> GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2DECD80", Offset = "0x2DEC180", VA = "0x182DECD80")]
	public static T EKFIDEKLFGB<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF, in T FBBJJPJMOPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x242BA30", Offset = "0x242AE30", VA = "0x18242BA30")]
	public static T BCMDOJLGGCO<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DECCD0", Offset = "0x2DEC0D0", VA = "0x182DECCD0")]
	public static T? AFEDLCAEHGA<T>(this IReadOnlyList<T> AOFCPKBHFEM, int EGBCAPEEJBF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KGJENKLKFOI
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x37D5100", Offset = "0x37D4500", VA = "0x1837D5100")]
	public static T BOEAFIEBIHC<T>(this in ReadOnlyMemory<T> AOFCPKBHFEM, int EGBCAPEEJBF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x37D5320", Offset = "0x37D4720", VA = "0x1837D5320")]
	public static bool OLCIPNJNGHJ<T>(this in ReadOnlyMemory<T> AOFCPKBHFEM, in ReadOnlyMemory<T> JHMCLPBFJBC) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x37D5260", Offset = "0x37D4660", VA = "0x1837D5260")]
	public static int MEIMIDGJKEA<T>(this in ReadOnlyMemory<T> AOFCPKBHFEM, int NNDFPDNBBHD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x37D51C0", Offset = "0x37D45C0", VA = "0x1837D51C0")]
	public static string IGLOMLHGOJI<T>(this in ReadOnlyMemory<T> AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class LPFKODPHIHG
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x29DA780", Offset = "0x29D9B80", VA = "0x1829DA780")]
	public static bool OLCIPNJNGHJ<T>(this in ReadOnlySpan<T> AOFCPKBHFEM, in ReadOnlySpan<T> JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x29DA660", Offset = "0x29D9A60", VA = "0x1829DA660")]
	public static int MEIMIDGJKEA<T>(this in ReadOnlySpan<T> AOFCPKBHFEM, int NNDFPDNBBHD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x29DA500", Offset = "0x29D9900", VA = "0x1829DA500")]
	public static string IGLOMLHGOJI<T>(this in ReadOnlySpan<T> AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x29DA160", Offset = "0x29D9560", VA = "0x1829DA160")]
	public static string HHHDAKNDPOB<T>(this in ReadOnlySpan<T> AOFCPKBHFEM, string GAIFEEANGAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class IKMGKHGCJIL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static GNFJJFILLEA JOMHBADDBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x66E5C80", Offset = "0x66E5080", VA = "0x1866E5C80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x66E5BF0", Offset = "0x66E4FF0", VA = "0x1866E5BF0")]
	public static double AIMBKFIEDBD(this GNFJJFILLEA AOFCPKBHFEM, long LFENIFPDNOH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class AFFHKOFPEIA : GNFJJFILLEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Stopwatch KFLMLLGELBK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long HMOHDCAKFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x66E5540", Offset = "0x66E4940", VA = "0x1866E5540", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	private AFFHKOFPEIA(Stopwatch PKADFIOHLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x66E54E0", Offset = "0x66E48E0", VA = "0x1866E54E0")]
	public static AFFHKOFPEIA FEPENBMLCIL(Stopwatch PKADFIOHLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x66E5440", Offset = "0x66E4840", VA = "0x1866E5440")]
	public static AFFHKOFPEIA ACGDBFNOCMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class IHCJEKHGMAK
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x66E5B90", Offset = "0x66E4F90", VA = "0x1866E5B90")]
	public static RigidTransform HHLBBGKAECP(this in RigidTransform AOFCPKBHFEM)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class KMJPCDHDLAL
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x66E6290", Offset = "0x66E5690", VA = "0x1866E6290")]
	public static RigidTransform GEDKCLAJAIH(RigidTransform GHMEPNPMHGC, RigidTransform OFHKALFLKOF)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class PGOCMJEOBGN
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC2D8C0", Offset = "0xC2CCC0", VA = "0x180C2D8C0")]
	public static bool MCDFEFALNJL(this string JBBLMAOAMGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IKJEGAPCMIH<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct LMDBNJNBPID : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x37E8650", Offset = "0x37E7A50", VA = "0x1837E8650", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2267520", Offset = "0x2266920", VA = "0x182267520")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x22672C0", Offset = "0x22666C0", VA = "0x1822672C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2267570", Offset = "0x2266970", VA = "0x182267570")]
	public static LMDBNJNBPID MKANFFBBFFF()
	{
		return default(LMDBNJNBPID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2267390", Offset = "0x2266790", VA = "0x182267390")]
	private static void IMFCBCCGGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2267320", Offset = "0x2266720", VA = "0x182267320")]
	public static void IKINEIFADPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct IFLEFHLGBOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly GNFJJFILLEA KFLMLLGELBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly long LOPEGGKGEBI;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x66E5B20", Offset = "0x66E4F20", VA = "0x1866E5B20")]
	public IFLEFHLGBOA(GNFJJFILLEA PKADFIOHLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x66E5970", Offset = "0x66E4D70", VA = "0x1866E5970")]
	public long AHKNJNGKACH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x66E5A00", Offset = "0x66E4E00", VA = "0x1866E5A00")]
	public double AIMBKFIEDBD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x66E5A90", Offset = "0x66E4E90", VA = "0x1866E5A90")]
	public double LAPJFJIDJFG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class ANOOCGLOJIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA17F40", Offset = "0xA17340", VA = "0x180A17F40")]
	public static bool MAHFGFPAPEI(this Type AOFCPKBHFEM, Type JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD6F0", Offset = "0x2BACAF0", VA = "0x182BAD6F0")]
	public static bool MAHFGFPAPEI<T>(this Type AOFCPKBHFEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HJBELDPCPJN
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xE9D060", Offset = "0xE9C460", VA = "0x180E9D060")]
	public static uint GEKKACHJDGA(this uint AOFCPKBHFEM, int KJAHKKMJHHG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xB71760", Offset = "0xB70B60", VA = "0x180B71760")]
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
