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
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x65AF850", Offset = "0x65AE050", VA = "0x1865AF850")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HFMLPOGEKCM
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate int GBNDNGCLMJA<T>(in T EHDPPFDCEJK, in T NPIMFLIIAHF);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class AIPONAKBJEI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private struct KPNPEJFFHMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public readonly int HCGAJDKMOED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly int CPNFMMNJLAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly bool BHKOHMEEBGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int IAPLLCCFBHD;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2A45370", Offset = "0x2A43B70", VA = "0x182A45370")]
			public KPNPEJFFHMP(int HCGAJDKMOED, int CPNFMMNJLAC, bool BHKOHMEEBGE)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly T[] MLBJEMNFCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly T[] PHGDHMPAACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly GBNDNGCLMJA<T> EPPAKGLAOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly int POPILDCJEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Func<bool> PBGLLMJIHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int LNOCBCNKKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly KPNPEJFFHMP[] BEAHNJAKJIE;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x33C5C40", Offset = "0x33C4440", VA = "0x1833C5C40")]
		public AIPONAKBJEI(T[] MLBJEMNFCBH, GBNDNGCLMJA<T> EPPAKGLAOGN, int POPILDCJEPM, Func<bool> PBGLLMJIHBO, T[] MFDKNMLHCGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x33C58B0", Offset = "0x33C40B0", VA = "0x1833C58B0")]
		public bool BBAKKFMAIOF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate U OEBNOAHCPOH<T, U>(int PLPKMAGOGOH, int EAJDPFENIDC, in ReadOnlySpan<T> IALIHMIEJBB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x255EBE0", Offset = "0x255D3E0", VA = "0x18255EBE0")]
	public static T[] PJAIEBJOFCN<T>(int GIGKIGNPJAP, T CEIOKBFHFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x255DFC0", Offset = "0x255C7C0", VA = "0x18255DFC0")]
	public static void JJMJBOKFBOB<T>(this T[] CKKMKILGIFP, T CEIOKBFHFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x249DE00", Offset = "0x249C600", VA = "0x18249DE00")]
	public static void EAICNNNOINP<T>(this T[] CIMBPHJAHGJ, int AOKAFHMCMMJ, int JMJAHAEGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x255E7E0", Offset = "0x255CFE0", VA = "0x18255E7E0")]
	private static void MLKMOIAEBNC<T>(this T[] DCJNPPINKOA, int PIGHGEAFHFH, int AEHBIGNAODE, T[] HAKPJJGEGOM, int NCGDOEJMCAM, int JAJOOJFJGJD, T[] KGFIMLECODA, int HEINPJOMBHI, GBNDNGCLMJA<T> EPPAKGLAOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x255D6E0", Offset = "0x255BEE0", VA = "0x18255D6E0")]
	public static void BLFPCBAOHFD<T>(this T[] DCJNPPINKOA, int HCGAJDKMOED, int FCKFNIPNJCI, GBNDNGCLMJA<T> EPPAKGLAOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x255E150", Offset = "0x255C950", VA = "0x18255E150")]
	public static AIPONAKBJEI<T> JKHPJHDJKGE<T>(this T[] DCJNPPINKOA, GBNDNGCLMJA<T> EPPAKGLAOGN, int POPILDCJEPM, Func<bool> PBGLLMJIHBO, [Optional] T[] MFDKNMLHCGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x255DBE0", Offset = "0x255C3E0", VA = "0x18255DBE0")]
	public static T[] EEHNICGMFPD<T>(this T[] CIMBPHJAHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x255DC00", Offset = "0x255C400", VA = "0x18255DC00")]
	public static T[] GGKACNLPAJP<T>(this T[] NBCJDGIIJJJ, T MJFBFNMENNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x255E1F0", Offset = "0x255C9F0", VA = "0x18255E1F0")]
	public static T[] KGBAKOPHCAJ<T>(this T[] NBCJDGIIJJJ, int LHHBOCAHDEE, T MJFBFNMENNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x255DCE0", Offset = "0x255C4E0", VA = "0x18255DCE0")]
	public static T[] HIDIJOJNEBO<T>(this T[] NBCJDGIIJJJ, int LHHBOCAHDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x255DD90", Offset = "0x255C590", VA = "0x18255DD90")]
	public static T[] HKLEAMLJHGL<T>(this T[] NBCJDGIIJJJ, int LHHBOCAHDEE, T MJFBFNMENNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x255ED60", Offset = "0x255D560", VA = "0x18255ED60")]
	public static U[] PNCBENFFPGO<U, T>(this T[] COFKFNBJGGD, int NLBOOOFGKJL, OEBNOAHCPOH<T, U> KFEFLNPBCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65AF1E0", Offset = "0x65AD9E0", VA = "0x1865AF1E0")]
	public static byte[] PFALNLGPJGI(this byte[] DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x65AEFE0", Offset = "0x65AD7E0", VA = "0x1865AEFE0")]
	public static byte[] CJEOPFOFLMK(this byte[] DCJNPPINKOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FMILAAJIIBG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x268D5C0", Offset = "0x268BDC0", VA = "0x18268D5C0")]
	public static void OGMEKNCJPGN<T>(this ICollection<T> DCJNPPINKOA, IEnumerable<T> EGAOMEOCDIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BLIJHDEDFAI
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F2C440", Offset = "0x1F2AC40", VA = "0x181F2C440")]
	public static void GFJEKGFKDHD<K, V>(this IDictionary<K, V> DCJNPPINKOA, in K NHBANLNJEIH, in V NPHADDCNBHE, Func<V, V, V> OGDDHKBFPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1F2C9B0", Offset = "0x1F2B1B0", VA = "0x181F2C9B0")]
	public static void LKIHLJHPOEI<K, V>(this IDictionary<K, List<V>> DCJNPPINKOA, in K NHBANLNJEIH, in V NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B480", Offset = "0x1F29C80", VA = "0x181F2B480")]
	public static TVal CJEAEPMIFBE<TVal, TKey>(this IDictionary<TKey, TVal> OCGEHIBMPLA, in TKey NHBANLNJEIH, [Optional] TVal CMEPDMFEMEH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B0F0", Offset = "0x1F298F0", VA = "0x181F2B0F0")]
	public static TVal CJEAEPMIFBE<TVal, TKey>(this IDictionary<TKey, TVal> OCGEHIBMPLA, in TKey NHBANLNJEIH, Func<TVal> NNLJAJHFGJD)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D130", Offset = "0x1F2B930", VA = "0x181F2D130")]
	public static TValue NDPPDBGHEHJ<TValue, TKey>(this IDictionary<TKey, TValue> OCGEHIBMPLA, in TKey NHBANLNJEIH, [Optional] in TValue CMEPDMFEMEH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F2BEE0", Offset = "0x1F2A6E0", VA = "0x181F2BEE0")]
	public static V DBILNFPCBHC<V, K>(this IDictionary<K, V> DCJNPPINKOA, in K NHBANLNJEIH)
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F2C3B0", Offset = "0x1F2ABB0", VA = "0x181F2C3B0")]
	public static T2[] DDHHGNBIMIJ<T2, T1>(this Dictionary<T1, T2>.ValueCollection DJIJFLDCFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NNEHBHKKKPB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate bool DGOLJJAKDLF<TArgs, T>(in TArgs OBPCMKOMOOP, T FNHAIFCEKHG);

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate U ODFDPHHKOGK<TArg, U>(in TArg CBHLECKANBK);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate U CCAPPLKFEBG<TArg, T, U>(in TArg CBHLECKANBK, T HDLDANNDPFJ);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate U OEHIBPDBAAK<TArg, T, U>(in TArg CBHLECKANBK, IEnumerable<T> GDAMMKPBIEJ);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate U KJNCNGMKCCO<TArg, T, U>(in TArg CBHLECKANBK, T HDLDANNDPFJ);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct ABEGOAKPELN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x26F7750", Offset = "0x26F5F50", VA = "0x1826F7750")]
		public (bool, T, IEnumerable<T>) ADBIHLCGBGK(T HIKIDDKMFIM)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x26F77C0", Offset = "0x26F5FC0", VA = "0x1826F77C0")]
		public (bool, T, IEnumerable<T>) EANDKEEBACG(IEnumerable<T> AMDLHPIMELJ)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AHEMHMOJAOL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int salt;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public AHEMHMOJAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x33B7570", Offset = "0x33B5D70", VA = "0x1833B7570")]
		internal int <SequenceGetHashCode>b__0(int prev, T current)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LHHMJONGLKE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public LHHMJONGLKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1C56AB0", Offset = "0x1C552B0", VA = "0x181C56AB0")]
		internal bool <SetEqual>b__0(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2D03E20", Offset = "0x2D02620", VA = "0x182D03E20")]
		internal bool <SetEqual>b__1(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35E7340", Offset = "0x35E5B40", VA = "0x1835E7340")]
	public static bool HIPNFCIIFJJ<T, TArgs>(this IEnumerable<T> DCJNPPINKOA, in TArgs OBPCMKOMOOP, DGOLJJAKDLF<TArgs, T> ODEIACIIKBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35EA3D0", Offset = "0x35E8BD0", VA = "0x1835EA3D0")]
	public static U IFCCHFEOCMF<U, T>(this IEnumerable<T> DCJNPPINKOA, Func<U> GCIJMCGCIBD, Func<T, U> HIKIDDKMFIM, Func<IEnumerable<T>, U> AMDLHPIMELJ)
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35EAB80", Offset = "0x35E9380", VA = "0x1835EAB80")]
	public static bool LEINDLOOEMD<T, TArgs>(this IEnumerable<T> DCJNPPINKOA, in TArgs OBPCMKOMOOP, DGOLJJAKDLF<TArgs, T> ODEIACIIKBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x35EAFD0", Offset = "0x35E97D0", VA = "0x1835EAFD0")]
	public static U OOHOCIKAMGG<U, T, TArg>(this IEnumerable<T> DCJNPPINKOA, in TArg CBHLECKANBK, ODFDPHHKOGK<TArg, U> GCIJMCGCIBD, CCAPPLKFEBG<TArg, T, U> HIKIDDKMFIM, OEHIBPDBAAK<TArg, T, U> AMDLHPIMELJ)
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35E5F20", Offset = "0x35E4720", VA = "0x1835E5F20")]
	public static IEnumerable<U> EEMGKGOPMPP<U, T, TArg>(this IEnumerable<T> DCJNPPINKOA, in TArg CBHLECKANBK, KJNCNGMKCCO<TArg, T, U> GFDELJMPLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25668B0", Offset = "0x25650B0", VA = "0x1825668B0")]
	public static IEnumerable<T> IEIFNBDOOPN<T>(params IEnumerable<T>[] EPIBPMLFJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x35E5D20", Offset = "0x35E4520", VA = "0x1835E5D20")]
	public static bool CEIJPCHKJLG<T>(this IEnumerable<T> KJFIHMLIKBG, IEnumerable<T> HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x25668B0", Offset = "0x25650B0", VA = "0x1825668B0")]
	public static IEnumerable<(TKey, TValue)> OBMLHJJJAKJ<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x35E6A30", Offset = "0x35E5230", VA = "0x1835E6A30")]
	public static IEnumerable<T> HINFHPADIKO<T, TKey>(this IEnumerable<T> LICJNBHJBFD, Func<T, TKey> CADPKOJDGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x17F2730", Offset = "0x17F0F30", VA = "0x1817F2730")]
	[IteratorStateMachine(typeof(HKGCJKOMEBG))]
	public static IEnumerable<T> PKJPGJHMNMM<T, U>(this IEnumerable<T> DCJNPPINKOA, IEnumerable<U> HAKPJJGEGOM, [Optional] T CEIOKBFHFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x103A900", Offset = "0x1039100", VA = "0x18103A900")]
	public static T EEECEIKLKGM<T>(this IEnumerable<T> KJFIHMLIKBG, T CMEPDMFEMEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x35E5ED0", Offset = "0x35E46D0", VA = "0x1835E5ED0")]
	public static T EEECEIKLKGM<T>(this IEnumerable<T> KJFIHMLIKBG, T CMEPDMFEMEH, Func<T, bool> ODEIACIIKBI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x35EA950", Offset = "0x35E9150", VA = "0x1835EA950")]
	[IteratorStateMachine(typeof(LJPGPMCLBJE))]
	public static IEnumerable<(T, global::PLKADEAGMGD<T>)> INHGICGDOHP<T>(this IEnumerable<T> DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x35EAEE0", Offset = "0x35E96E0", VA = "0x1835EAEE0")]
	public static bool NGJJKOGMDJO<T>(this IEnumerable<T> DCJNPPINKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x25668B0", Offset = "0x25650B0", VA = "0x1825668B0")]
	public static IEnumerable<global::NKFMGBDKOMD<T>> FPGJPBIHINK<T>(this IEnumerable<T> DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x35E5D00", Offset = "0x35E4500", VA = "0x1835E5D00")]
	public static bool BIJBAFFKCJE<T>(this IEnumerable<T> DCJNPPINKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x35EB5E0", Offset = "0x35E9DE0", VA = "0x1835EB5E0")]
	public static IEnumerable<T> PCEIKCJFBBD<T>(this IEnumerable<T> DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x17F27F0", Offset = "0x17F0FF0", VA = "0x1817F27F0")]
	[IteratorStateMachine(typeof(MBGKFALALOE))]
	public static IEnumerable<U> NJIBFDEKDKN<U, T>(this IEnumerable<T> DCJNPPINKOA, Func<ABEGOAKPELN<U>, T, (bool Zero, U One, IEnumerable<U> Many)> AEENGKMCDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1F1DF00", Offset = "0x1F1C700", VA = "0x181F1DF00")]
	public static int EPMLFLIKEIF<T>(this IEnumerable<T> DCJNPPINKOA, int EADNAIPACKM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x35E6360", Offset = "0x35E4B60", VA = "0x1835E6360")]
	public static bool EOKCEDNIICJ<T>(this IEnumerable<T> DCJNPPINKOA, IEnumerable<T> HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x35EB350", Offset = "0x35E9B50", VA = "0x1835EB350")]
	public static (IEnumerable<T>, IEnumerable<T>) OPFJCELJENA<T>(this IEnumerable<T> DCJNPPINKOA, Func<T, bool> EJBOMBDPCOH)
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x35EB790", Offset = "0x35E9F90", VA = "0x1835EB790")]
	public static string PDPINNPNIEL<T>(this IEnumerable<T> DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x35EA580", Offset = "0x35E8D80", VA = "0x1835EA580")]
	public static Dictionary<TKey, TValue> IKMNABGJNBJ<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> KJFIHMLIKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35EA580", Offset = "0x35E8D80", VA = "0x1835EA580")]
	public static Dictionary<TKey, TValue> IKMNABGJNBJ<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> KJFIHMLIKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x17F2E00", Offset = "0x17F1600", VA = "0x1817F2E00")]
	public static HashSet<T> LAHODOHIEND<T>(this IEnumerable<T> DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x35E7C20", Offset = "0x35E6420", VA = "0x1835E7C20")]
	public static string IEEPCMPBPCA<T>(this IEnumerable<T> DCJNPPINKOA, string EPMHLHDOOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2125DC0", Offset = "0x21245C0", VA = "0x182125DC0")]
	[IteratorStateMachine(typeof(NLLEHOIOOIF))]
	public static IEnumerable<(T, U)> CDGEODIFNIN<T, U>(this IEnumerable<T> EHDPPFDCEJK, IEnumerable<U> NPIMFLIIAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x35E67B0", Offset = "0x35E4FB0", VA = "0x1835E67B0")]
	public static IEnumerable<V> HHFJDFJDJMP<V, T, U>(this IEnumerable<T> DCJNPPINKOA, IEnumerable<U> HAKPJJGEGOM, Func<T, U, V> LCBGGMKGGPL, [Optional] T HAPJHKEMNGJ, [Optional] U ENNMILNANPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35E6840", Offset = "0x35E5040", VA = "0x1835E6840")]
	public static IEnumerable<(T, U)> HHFJDFJDJMP<T, U>(this IEnumerable<T> DCJNPPINKOA, IEnumerable<U> HAKPJJGEGOM, [Optional] T HAPJHKEMNGJ, [Optional] U ENNMILNANPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class DEDDDIJLBAN
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x22FCA20", Offset = "0x22FB220", VA = "0x1822FCA20")]
	public static bool MAKBAGHGCFA<T, U>(this T DCJNPPINKOA, in U BFHAMCLNCKB) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x22FC980", Offset = "0x22FB180", VA = "0x1822FC980")]
	public static bool KGEFJDOMBFC<T>(ref T DCJNPPINKOA, T HAKPJJGEGOM) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class ECNCCMLJFDF
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2C90160", Offset = "0x2C8E960", VA = "0x182C90160")]
	public static bool LJFJFGADHGP(this in float3 HDPOKDCLGGE, float3 JBKIIGINOKM, float IPAFIDICAFN = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NEPFJMCOIBA
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F212E0", Offset = "0x1F1FAE0", VA = "0x181F212E0")]
	public static void FGAKFPEANHJ<T>(this T KFEBAJCAAOE, Action<T> ILDEOAEFNGD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1F21490", Offset = "0x1F1FC90", VA = "0x181F21490")]
	public static V HGEDFAOMLBE<V, T>(this T KFEBAJCAAOE, Func<T, V> ILDEOAEFNGD, [Optional] V CMEPDMFEMEH) where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F21320", Offset = "0x1F1FB20", VA = "0x181F21320")]
	public static T? GGFMHHIJJHB<T>(this T DCJNPPINKOA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1BED120", Offset = "0x1BEB920", VA = "0x181BED120")]
	[IteratorStateMachine(typeof(LMOAOBPDPLO))]
	public static IEnumerable<T> HONOJDFDOOG<T>(this T DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1F21600", Offset = "0x1F1FE00", VA = "0x181F21600")]
	public static T[] MCEFHBJCOIP<T>(this T DCJNPPINKOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BBGOAPNLNDB
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x65AE0B0", Offset = "0x65AC8B0", VA = "0x1865AE0B0")]
	private static byte[] CBNKNFLJOBF(int EKEALIHCBFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x65AE480", Offset = "0x65ACC80", VA = "0x1865AE480")]
	private static byte[] LGIOFPKGMBJ(long IEAJFCBKBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x65AE290", Offset = "0x65ACA90", VA = "0x1865AE290")]
	private static byte[] KJBNGJNKMHO(ulong IEAJFCBKBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x65AE310", Offset = "0x65ACB10", VA = "0x1865AE310")]
	public static Guid LDOCFDGNCOC(params Guid[] OFCJIKKNDIO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x65AE5C0", Offset = "0x65ACDC0", VA = "0x1865AE5C0")]
	public static Guid OJONNLHFKNA(in Guid APFKEHHFEOF, int LHHBOCAHDEE, int OGPINCOPHCL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x65AE9C0", Offset = "0x65AD1C0", VA = "0x1865AE9C0")]
	public static Guid OJONNLHFKNA(in Guid APFKEHHFEOF, long LHHBOCAHDEE, int OGPINCOPHCL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x65AE500", Offset = "0x65ACD00", VA = "0x1865AE500")]
	public static Guid OJONNLHFKNA(in Guid APFKEHHFEOF, ulong LHHBOCAHDEE, int OGPINCOPHCL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x65AE950", Offset = "0x65AD150", VA = "0x1865AE950")]
	public static Guid OJONNLHFKNA(in Guid APFKEHHFEOF, in Guid LGOBLLDJPEL, int OGPINCOPHCL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x65AE680", Offset = "0x65ACE80", VA = "0x1865AE680")]
	private static Guid OJONNLHFKNA(in Guid APFKEHHFEOF, byte[] MALKAFADDBJ, int OGPINCOPHCL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x65AE1B0", Offset = "0x65AC9B0", VA = "0x1865AE1B0")]
	private static void JKKDFJEDECJ(byte[] CNMALJMHIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x65AE130", Offset = "0x65AC930", VA = "0x1865AE130")]
	private static void GKODCHPMHFK(byte[] CNMALJMHIOD, int NCBNFILGGOG, int NMABHKKNANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface EDEONLPBPGC
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BNGODOECNLC GCOFABPKLHC();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BNGODOECNLC : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CJGGNOKILDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBDJLBCGGFD();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DLGJMIMFEOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MHBDBPNPBIA(int DFNGDFIPFCL, int PHIEAJJHMHA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float BJGGBFDHHMM(float FLBDGMJLPNI, float ANMKLHCHPFE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NCNHIOJGAAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	long ADIFNBPEEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DENAJFGLIJL
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x65AEC90", Offset = "0x65AD490", VA = "0x1865AEC90")]
	public static int IAHEOLFEEEC(this int DCJNPPINKOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x65AEC50", Offset = "0x65AD450", VA = "0x1865AEC50")]
	public static int GPCFOLKLLAF(this int DCJNPPINKOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x65AED10", Offset = "0x65AD510", VA = "0x1865AED10")]
	public static int PAFEAGEEKEB(this int DCJNPPINKOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x65AED00", Offset = "0x65AD500", VA = "0x1865AED00")]
	public static int MCNJOJLOOHL(this int DCJNPPINKOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xE996B0", Offset = "0xE97EB0", VA = "0x180E996B0")]
	public static int AOLFBIJGDMB(this int DCJNPPINKOA, int FCKFNIPNJCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xB66760", Offset = "0xB64F60", VA = "0x180B66760")]
	public static int MPDBFBMBGDG(this int DCJNPPINKOA, int FCKFNIPNJCI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PJIGNOABDPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A1A0D0", Offset = "0x2A188D0", VA = "0x182A1A0D0")]
	public static void NEMBEEBJDEF<TKey, TValue>(this in KeyValuePair<TKey, TValue> DCJNPPINKOA, out TKey NHBANLNJEIH, out TValue NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A19F90", Offset = "0x2A18790", VA = "0x182A19F90")]
	public static (TKey, TValue) BCNFNNLOAGK<TKey, TValue>(this in KeyValuePair<TKey, TValue> DCJNPPINKOA)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A1A260", Offset = "0x2A18A60", VA = "0x182A1A260")]
	public static KeyValuePair<TKey, UValue> PAHPJJFOOGB<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> DCJNPPINKOA, UValue NPHADDCNBHE)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class JBONBNFLJFG
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EMDKICLECNO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Random rng;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public EMDKICLECNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8989A0", VA = "0x18089A1A0")]
		internal int <Random>b__0(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x14A44D0", Offset = "0x14A2CD0", VA = "0x1814A44D0")]
	public static int PMGCGCEOKLC<T>(this IReadOnlyList<T> CIMBPHJAHGJ, T NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C15E50", Offset = "0x2C14650", VA = "0x182C15E50")]
	public static int GHLLLKJFIHI<T>(this IReadOnlyList<T> CIMBPHJAHGJ, T NPHADDCNBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x14A3E00", Offset = "0x14A2600", VA = "0x1814A3E00")]
	public static void OGMEKNCJPGN<T>(this HashSet<T> DBOJFICDANO, IEnumerable<T> EGAOMEOCDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x14A30A0", Offset = "0x14A18A0", VA = "0x1814A30A0")]
	public static void MHLFPCGENHP<T>(this IList<T> HGPMCGJIADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x14A2D70", Offset = "0x14A1570", VA = "0x1814A2D70")]
	public static void MHLFPCGENHP<T>(this IList<T> HGPMCGJIADE, int MEFMPDFMDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x14A2700", Offset = "0x14A0F00", VA = "0x1814A2700")]
	public static List<T> KMLJIKFDFMB<T>(this List<T> MJNFLJIGHLN, Predicate<T> GPMCECCEKLI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x14A4C70", Offset = "0x14A3470", VA = "0x1814A4C70")]
	public static int PMGCGCEOKLC<T>(this IReadOnlyList<T> HGPMCGJIADE, Predicate<T> ODEIACIIKBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x14A2B30", Offset = "0x14A1330", VA = "0x1814A2B30")]
	public static bool MDILHKHMEFP<T>(this IReadOnlyList<T> HGPMCGJIADE, Predicate<T> ODEIACIIKBI, out List<int> MMKNKBBOLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F3CF50", Offset = "0x1F3B750", VA = "0x181F3CF50")]
	public static bool JEBNAOILLLF<T>(this IReadOnlyList<T> HGPMCGJIADE, T FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C17080", Offset = "0x2C15880", VA = "0x182C17080")]
	public static bool JEBNAOILLLF<T>(this IReadOnlyList<T> HGPMCGJIADE, T FNHAIFCEKHG, EqualityComparer<T> GIPMPCIMIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C16090", Offset = "0x2C14890", VA = "0x182C16090")]
	public static int GOCHHNGIOBI<TElement, TKey>(this IList<TElement> NIOKBFCAAMB, TKey EGAPDLCGKIP, Func<TElement, TKey> JDLMLNIBLML, [Optional] Func<TKey, TKey, int> EPPAKGLAOGN, int LHHBOCAHDEE = 0, [Optional] int? FCKFNIPNJCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C16940", Offset = "0x2C15140", VA = "0x182C16940")]
	public static List<T> HIIJBIMONFP<T>(this IReadOnlyList<T> HGPMCGJIADE, int FCKFNIPNJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x14A4160", Offset = "0x14A2960", VA = "0x1814A4160")]
	public static bool PJLPOCKOJHA<T>(this List<T> HGPMCGJIADE, T FNHAIFCEKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C16BA0", Offset = "0x2C153A0", VA = "0x182C16BA0")]
	public static void HJFGPJBFJOM<T>(this List<T> HGPMCGJIADE, IEnumerable<T> MJNFLJIGHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C13AF0", Offset = "0x2C122F0", VA = "0x182C13AF0")]
	public static void ALIFOBNBCOA<T>(this List<T> HGPMCGJIADE, IEnumerable<T> MJNFLJIGHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C13A90", Offset = "0x2C12290", VA = "0x182C13A90")]
	public static T AJEMEAHPCNN<T>(this List<T> MJNFLJIGHLN, Predicate<T> GPMCECCEKLI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C15DE0", Offset = "0x2C145E0", VA = "0x182C15DE0")]
	public static T EDNIJLKCHEN<T>(this List<T> MJNFLJIGHLN, int LHHBOCAHDEE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C16790", Offset = "0x2C14F90", VA = "0x182C16790")]
	public static bool HEKPAADEFBH<T>(this List<T> PKAFINGCHMN, List<T> AJDNAOCDLNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x14A2A90", Offset = "0x14A1290", VA = "0x1814A2A90")]
	public static T MDFLEKFFNGH<T>(this IList<T> HGPMCGJIADE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x14A34D0", Offset = "0x14A1CD0", VA = "0x1814A34D0")]
	public static bool NAHMFPBEMPH<T>(IReadOnlyList<T> HGPMCGJIADE, int LHHBOCAHDEE, out T KGFIMLECODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C14FB0", Offset = "0x2C137B0", VA = "0x182C14FB0")]
	public static bool BKOLMNDDDGA<T>(IReadOnlyList<T> HGPMCGJIADE, ICollection MJNFLJIGHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C16820", Offset = "0x2C15020", VA = "0x182C16820")]
	public static void HHFACFALCPC<T>(IReadOnlyList<T> HGPMCGJIADE, ref ICollection MJNFLJIGHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F6D0", Offset = "0x1F3DED0", VA = "0x181F3F6D0")]
	public static bool DDPPIEFAKKF<T>(this IReadOnlyList<T> HGPMCGJIADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C17920", Offset = "0x2C16120", VA = "0x182C17920")]
	public static string JFHENGICGAH<T>(this IEnumerable<T> HGPMCGJIADE, string ADEPLOPHNNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C16E80", Offset = "0x2C15680", VA = "0x182C16E80")]
	public static T JAKEIKDHCBB<T>(this IList<T> DCJNPPINKOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x14A27F0", Offset = "0x14A0FF0", VA = "0x1814A27F0")]
	public static T KPLPPGBKCBK<T>(this IList<T> DCJNPPINKOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C16000", Offset = "0x2C14800", VA = "0x182C16000")]
	public static void GNGMMLOICKC<T>(this IList<T> DCJNPPINKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C13C90", Offset = "0x2C12490", VA = "0x182C13C90")]
	public static void BAPODLOOBJG<T>(this IList<T> DCJNPPINKOA, in T NPHADDCNBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x14A40C0", Offset = "0x14A28C0", VA = "0x1814A40C0")]
	public static T PADJGNGBDLM<T>(this IList<T> DCJNPPINKOA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EPJLAEGNDBC
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static float HMPGIKDAFFL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static float EFAEJOHLAPG;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static bool GBAHLGLNGFB;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly float IJEHJGNBPHA;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x65AEE00", Offset = "0x65AD600", VA = "0x1865AEE00")]
	public static bool MDGDFADPDDD(float HDPOKDCLGGE, float JBKIIGINOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4946800", Offset = "0x4945000", VA = "0x184946800")]
	public static float KOIOGFKADOC(float NPHADDCNBHE, float BPCHPMCLFBF, float HDHNBDLKAPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4946820", Offset = "0x4945020", VA = "0x184946820")]
	public static int KOIOGFKADOC(int NPHADDCNBHE, int BPCHPMCLFBF, int HDHNBDLKAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x49467E0", Offset = "0x4944FE0", VA = "0x1849467E0")]
	public static float POMOLPNMLNC(float NPHADDCNBHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x65AED60", Offset = "0x65AD560", VA = "0x1865AED60")]
	public static float GBMKAPAKCJI(float HDPOKDCLGGE, float JBKIIGINOKM, float KFEBAJCAAOE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PKJMBBIAKBK
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A1AE60", Offset = "0x2A19660", VA = "0x182A1AE60")]
	public static bool HMGPPMAECNP<T>(this object DCJNPPINKOA, out T KGFIMLECODA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AAIHDAAIHIC
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x65ADFE0", Offset = "0x65AC7E0", VA = "0x1865ADFE0")]
	public static bool LJFJFGADHGP(this quaternion EHDPPFDCEJK, quaternion NPIMFLIIAHF, float JOIIEBFPIKL = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KHANDGPHIGD
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private sealed class OPGIIENKHKO : DLGJMIMFEOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Random GEBHPKODAKG;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x65AFBB0", Offset = "0x65AE3B0", VA = "0x1865AFBB0", Slot = "4")]
		public int MHBDBPNPBIA(int FLBDGMJLPNI, int KBIKLNMOFLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x65AFB00", Offset = "0x65AE300", VA = "0x1865AFB00", Slot = "5")]
		public float BJGGBFDHHMM(float FLBDGMJLPNI, float ANMKLHCHPFE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x65AFB70", Offset = "0x65AE370", VA = "0x1865AFB70")]
		private double CPOEKIDBKOP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x65AFBE0", Offset = "0x65AE3E0", VA = "0x1865AFBE0")]
		public OPGIIENKHKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly DLGJMIMFEOJ HIIJBIMONFP;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x65AF3F0", Offset = "0x65ADBF0", VA = "0x1865AF3F0")]
	public static ulong DOMCHOCHEMC()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FPHFLDMLENI
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x268E730", Offset = "0x268CF30", VA = "0x18268E730")]
	public static bool BPOKFJEDIDE<T>(this IReadOnlyCollection<T> DCJNPPINKOA, int LHHBOCAHDEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LKCAABCOAKG
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x24E1710", Offset = "0x24DFF10", VA = "0x1824E1710")]
	public static bool FEEDILOKHNP<T>(this IReadOnlyList<T> DCJNPPINKOA, int LHHBOCAHDEE, out T KGFIMLECODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x24E1820", Offset = "0x24E0020", VA = "0x1824E1820")]
	public static bool LJPGPHOCHBG<T>(this IReadOnlyList<T> DCJNPPINKOA, int LHHBOCAHDEE, out global::NKFMGBDKOMD<T> KGFIMLECODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x24E17A0", Offset = "0x24DFFA0", VA = "0x1824E17A0")]
	public static T IBFMPAMPMAN<T>(this IReadOnlyList<T> DCJNPPINKOA, int LHHBOCAHDEE, in T PCOEIIHACDL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x14A5360", Offset = "0x14A3B60", VA = "0x1814A5360")]
	public static T HBOIKICPBCP<T>(this IReadOnlyList<T> DCJNPPINKOA, int LHHBOCAHDEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x24E18E0", Offset = "0x24E00E0", VA = "0x1824E18E0")]
	public static T? NPKLNCAFINN<T>(this IReadOnlyList<T> DCJNPPINKOA, int LHHBOCAHDEE) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MCCKFNOACJC
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x24F3F80", Offset = "0x24F2780", VA = "0x1824F3F80")]
	public static T HEJAGBNBHFE<T>(this in ReadOnlyMemory<T> DCJNPPINKOA, int LHHBOCAHDEE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BFHPIOHHMBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NCNHIOJGAAO EJCEHINOCEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x65AEA80", Offset = "0x65AD280", VA = "0x1865AEA80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x65AEAE0", Offset = "0x65AD2E0", VA = "0x1865AEAE0")]
	public static double NPJGANLMCJK(this NCNHIOJGAAO DCJNPPINKOA, long PIPEDHBLNCE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class MDALHPMKLME : NCNHIOJGAAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Stopwatch HFOHCJKCAMB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long ADIFNBPEEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x65AF830", Offset = "0x65AE030", VA = "0x1865AF830", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	private MDALHPMKLME(Stopwatch LKLCJCFHEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x65AF7D0", Offset = "0x65ADFD0", VA = "0x1865AF7D0")]
	public static MDALHPMKLME ILKFOENLMDJ(Stopwatch LKLCJCFHEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x65AF730", Offset = "0x65ADF30", VA = "0x1865AF730")]
	public static MDALHPMKLME ENBCBGLDHDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AHJPLJFJPGM
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x65AE050", Offset = "0x65AC850", VA = "0x1865AE050")]
	public static RigidTransform LIPLCLMHMIL(this in RigidTransform DCJNPPINKOA)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class PFPMFDCMNII
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x65AFC50", Offset = "0x65AE450", VA = "0x1865AFC50")]
	public static RigidTransform GPFBECHLHKL(RigidTransform DILLLIOCDKN, RigidTransform FCKGFGCNECF)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class DBAJFOBCAFF
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xC228C0", Offset = "0xC210C0", VA = "0x180C228C0")]
	public static bool DDPPIEFAKKF(this string GLKCNJGCDME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DEFIMMPDLKL<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LBDGJMPAKJA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1C62390", Offset = "0x1C60B90", VA = "0x181C62390", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static int FPACLNMMJOC;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static OOMEFPEEKIP HPIPFCJLOCI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long ADIFNBPEEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3A850A0", Offset = "0x3A838A0", VA = "0x183A850A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A84D10", Offset = "0x3A83510", VA = "0x183A84D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3A84F00", Offset = "0x3A83700", VA = "0x183A84F00")]
	public static LBDGJMPAKJA KFMKHCIHDHH()
	{
		return default(LBDGJMPAKJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3A84D70", Offset = "0x3A83570", VA = "0x183A84D70")]
	private static void GMENILGEBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3A850F0", Offset = "0x3A838F0", VA = "0x183A850F0")]
	public static void NDKMADGHFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct OOMEFPEEKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NCNHIOJGAAO HFOHCJKCAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly long BHKFAHJNNLL;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x65AFA90", Offset = "0x65AE290", VA = "0x1865AFA90")]
	public OOMEFPEEKIP(NCNHIOJGAAO LKLCJCFHEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x65AF8E0", Offset = "0x65AE0E0", VA = "0x1865AF8E0")]
	public long CNBCKEMGBAD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x65AFA00", Offset = "0x65AE200", VA = "0x1865AFA00")]
	public double NPJGANLMCJK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x65AF970", Offset = "0x65AE170", VA = "0x1865AF970")]
	public double HHKBHDPOPBG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CCGACLGBNEE
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF40", Offset = "0xA0B740", VA = "0x180A0CF40")]
	public static bool NBEMJGLJCGM(this Type DCJNPPINKOA, Type HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1F32D20", Offset = "0x1F31520", VA = "0x181F32D20")]
	public static bool NBEMJGLJCGM<T>(this Type DCJNPPINKOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BGPKPDIGLEF
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xE996B0", Offset = "0xE97EB0", VA = "0x180E996B0")]
	public static uint AOLFBIJGDMB(this uint DCJNPPINKOA, int FCKFNIPNJCI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xB66760", Offset = "0xB64F60", VA = "0x180B66760")]
	public static uint MPDBFBMBGDG(this uint DCJNPPINKOA, int FCKFNIPNJCI)
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
