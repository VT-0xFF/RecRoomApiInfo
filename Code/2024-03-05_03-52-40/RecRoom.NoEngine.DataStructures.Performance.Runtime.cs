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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6185A10", Offset = "0x6184810", VA = "0x186185A10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KABJFMKNPEI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22A5960", Offset = "0x22A4760", VA = "0x1822A5960")]
	public static IPPOBGFPAOB<T> CGHCFCMJPCP<T>(this T[] OELHNDCFEMO) where T : notnull
	{
		return default(IPPOBGFPAOB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class PDBIOLJBBHG<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FFPIJGBCMLA<T> IENLMEMGLFE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x409AB40", Offset = "0x4099940", VA = "0x18409AB40", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x409ABE0", Offset = "0x40999E0", VA = "0x18409ABE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x409AC10", Offset = "0x4099A10", VA = "0x18409AC10")]
	public static PDBIOLJBBHG<T> IKCDCJJCDKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2650", Offset = "0x3EE1450", VA = "0x183EE2650")]
	internal PDBIOLJBBHG([In] FFPIJGBCMLA<T> EJHNGBHNBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x409AB20", Offset = "0x4099920", VA = "0x18409AB20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x409ABC0", Offset = "0x40999C0", VA = "0x18409ABC0")]
	public void HGHKKEOEJNM(int DPKFLHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x409AB70", Offset = "0x4099970", VA = "0x18409AB70", Slot = "8")]
	public FFPIJGBCMLA<T>.HDBNCPMCICK GetEnumerator()
	{
		return default(FFPIJGBCMLA<T>.HDBNCPMCICK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x409AD30", Offset = "0x4099B30", VA = "0x18409AD30", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x409AD30", Offset = "0x4099B30", VA = "0x18409AD30", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PKNKEOLHBCK<T, U> : IEnumerable<T>, IEnumerable where U : PAHGMJPLIMG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U FBBKICMGHPF;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D94C10", Offset = "0x1D93A10", VA = "0x181D94C10")]
	internal PKNKEOLHBCK([In] U GKFDOPGLMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3613CB0", Offset = "0x3612AB0", VA = "0x183613CB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3613CB0", Offset = "0x3612AB0", VA = "0x183613CB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MAMADGEJPEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22A19B0", Offset = "0x22A07B0", VA = "0x1822A19B0")]
	public static PKNKEOLHBCK<T, U> IKCDCJJCDKO<U>([In] U OELHNDCFEMO) where U : PAHGMJPLIMG<T>
	{
		return default(PKNKEOLHBCK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FJFCBJBPNEH<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U FBBKICMGHPF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3613B30", Offset = "0x3612930", VA = "0x183613B30")]
	internal FJFCBJBPNEH([In] U GKFDOPGLMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3338520", Offset = "0x3337320", VA = "0x183338520", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3613730", Offset = "0x3612530", VA = "0x183613730", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3613730", Offset = "0x3612530", VA = "0x183613730", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class COKKFCKHDCF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22A19E0", Offset = "0x22A07E0", VA = "0x1822A19E0")]
	public static FJFCBJBPNEH<T, U> IKCDCJJCDKO<U>([In] U OELHNDCFEMO) where U : IEnumerator<T>
	{
		return default(FJFCBJBPNEH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class OBDPHJFOEEE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x288A930", Offset = "0x2889730", VA = "0x18288A930")]
	public static string CHBAAILALJK<T>(this IEnumerable<T> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x288DCA0", Offset = "0x288CAA0", VA = "0x18288DCA0")]
	public static string EMODJJDPNGO<T>(this IEnumerable<T> OELHNDCFEMO, string DBJDPMPCNDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CDNGPOBMJAC
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x258E9C0", Offset = "0x258D7C0", VA = "0x18258E9C0")]
	public static bool NAFEMIOKILN<TSourceEnumerator, TSource>(this TSourceEnumerator OELHNDCFEMO, [In] TSource IFKPOCGDKDB) where TSourceEnumerator : PAHGMJPLIMG<TSource> where TSource : CFGACMJPKMC<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x258E830", Offset = "0x258D630", VA = "0x18258E830")]
	public static int BMOENIHCMFH<TSourceEnumerator, TSource>(this TSourceEnumerator OELHNDCFEMO, [In] TSource MAEBFBHFPDE) where TSourceEnumerator : PAHGMJPLIMG<TSource> where TSource : CFGACMJPKMC<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PAHGMJPLIMG<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T OGCIBGAMGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KGFGKIPJNBI<T> : PAHGMJPLIMG<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct KEILBFKJIKJ<T, U> : IEnumerable<T>, IEnumerable where U : KGFGKIPJNBI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U FBBKICMGHPF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3A46320", Offset = "0x3A45120", VA = "0x183A46320")]
	internal KEILBFKJIKJ([In] U GKFDOPGLMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3345BC0", Offset = "0x33449C0", VA = "0x183345BC0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F240", Offset = "0x3B0E040", VA = "0x183B0F240", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F240", Offset = "0x3B0E040", VA = "0x183B0F240", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DLPFGPOGFDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x22A2DD0", Offset = "0x22A1BD0", VA = "0x1822A2DD0")]
	public static KEILBFKJIKJ<T, U> IKCDCJJCDKO<U>([In] U OELHNDCFEMO) where U : KGFGKIPJNBI<T>
	{
		return default(KEILBFKJIKJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct IPPOBGFPAOB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct GJIPHGJJOCG : PAHGMJPLIMG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] MJHNKEACFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int FBJKKAIPHPA;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x370C500", Offset = "0x370B300", VA = "0x18370C500", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x370BF50", Offset = "0x370AD50", VA = "0x18370BF50", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x370C0F0", Offset = "0x370AEF0", VA = "0x18370C0F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1865EF0", Offset = "0x1864CF0", VA = "0x181865EF0")]
		private GJIPHGJJOCG(T[] OELHNDCFEMO, int OHINPGIGDNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x370BCB0", Offset = "0x370AAB0", VA = "0x18370BCB0")]
		public static GJIPHGJJOCG IKCDCJJCDKO(T[] OELHNDCFEMO)
		{
			return default(GJIPHGJJOCG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAC40", Offset = "0x1DA9A40", VA = "0x181DAAC40", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAC70", Offset = "0x1DA9A70", VA = "0x181DAAC70", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] PMFKJPHBDGA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EINKGEEBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x38AC700", Offset = "0x38AB500", VA = "0x1838AC700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T GKAMGCEMFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x25F90A0", Offset = "0x25F7EA0", VA = "0x1825F90A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
	internal IPPOBGFPAOB(T[] HHAMBPGBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x38AC5C0", Offset = "0x38AB3C0", VA = "0x1838AC5C0")]
	public static IPPOBGFPAOB<T> DGHDBBJHGGP()
	{
		return default(IPPOBGFPAOB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
	public IEnumerable<T> DEHHJPIMACG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38AC8D0", Offset = "0x38AB6D0", VA = "0x1838AC8D0")]
	public ReadOnlyMemory<T> OBAPBAHPMEF()
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38AC840", Offset = "0x38AB640", VA = "0x1838AC840")]
	public ReadOnlySpan<T> KAPJCOIOMHD()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x38AC720", Offset = "0x38AB520", VA = "0x1838AC720")]
	public PKNKEOLHBCK<T, IPPOBGFPAOB<T>.GJIPHGJJOCG> IGOMBOAECEI()
	{
		return default(PKNKEOLHBCK<T, GJIPHGJJOCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38AC530", Offset = "0x38AB330", VA = "0x1838AC530")]
	public GJIPHGJJOCG ADDEGMINONE()
	{
		return default(GJIPHGJJOCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38AC680", Offset = "0x38AB480", VA = "0x1838AC680")]
	public IEnumerator<T> GGNEAJGHJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x38AC960", Offset = "0x38AB760", VA = "0x1838AC960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LKMPOGGHMOA
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x25198D0", Offset = "0x25186D0", VA = "0x1825198D0")]
	public static IPPOBGFPAOB<T> MIDKDJAKNGP<T>(params T[] HHAMBPGBENG) where T : notnull
	{
		return default(IPPOBGFPAOB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61859B0", Offset = "0x61847B0", VA = "0x1861859B0")]
	public static Stream MBKCEDCCCOJ(this IPPOBGFPAOB<byte> OELHNDCFEMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(FFPIJGBCMLA<>.PMHMAAEEAOH))]
public struct FFPIJGBCMLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct HDBNCPMCICK : KGFGKIPJNBI<T>, PAHGMJPLIMG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] GPAKCHKPJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int CPMFKFCAAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int FBJKKAIPHPA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3792080", Offset = "0x3790E80", VA = "0x183792080", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T EKFHEGJKNKG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x37917F0", Offset = "0x37905F0", VA = "0x1837917F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3791B50", Offset = "0x3790950", VA = "0x183791B50", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3791BB0", Offset = "0x37909B0", VA = "0x183791BB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3791FA0", Offset = "0x3790DA0", VA = "0x183791FA0")]
		internal HDBNCPMCICK(T[] EGCLMNAPIFL, int DPKFLHPPNCH, int OHINPGIGDNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37918E0", Offset = "0x37906E0", VA = "0x1837918E0")]
		public static HDBNCPMCICK IKCDCJJCDKO(FFPIJGBCMLA<T> OELHNDCFEMO)
		{
			return default(HDBNCPMCICK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3304B00", Offset = "0x3303900", VA = "0x183304B00", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3301DB0", Offset = "0x3300BB0", VA = "0x183301DB0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct FGKNNFKLCGN : PAHGMJPLIMG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HDBNCPMCICK FBBKICMGHPF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3603EE0", Offset = "0x3602CE0", VA = "0x183603EE0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3603A40", Offset = "0x3602840", VA = "0x183603A40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3603B90", Offset = "0x3602990", VA = "0x183603B90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1D94C10", Offset = "0x1D93A10", VA = "0x181D94C10")]
		private FGKNNFKLCGN([In] HDBNCPMCICK GKFDOPGLMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x36038B0", Offset = "0x36026B0", VA = "0x1836038B0")]
		public static FGKNNFKLCGN IKCDCJJCDKO([In] FFPIJGBCMLA<T> OELHNDCFEMO)
		{
			return default(FGKNNFKLCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3603960", Offset = "0x3602760", VA = "0x183603960", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x36039A0", Offset = "0x36027A0", VA = "0x1836039A0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3603870", Offset = "0x3602670", VA = "0x183603870", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class PMHMAAEEAOH
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] GPAKCHKPJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int CPMFKFCAAGL;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x35FB820", Offset = "0x35FA620", VA = "0x1835FB820")]
	public static FFPIJGBCMLA<T> IKCDCJJCDKO()
	{
		return default(FFPIJGBCMLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x35FB8C0", Offset = "0x35FA6C0", VA = "0x1835FB8C0")]
	public static FFPIJGBCMLA<T> PJJLGNLPJCF(int DKDCFCAKJAJ)
	{
		return default(FFPIJGBCMLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1865EF0", Offset = "0x1864CF0", VA = "0x181865EF0")]
	internal FFPIJGBCMLA(T[] EGCLMNAPIFL, int DPKFLHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35FB970", Offset = "0x35FA770", VA = "0x1835FB970", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EDEFKBANNCE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x25F5B20", Offset = "0x25F4920", VA = "0x1825F5B20")]
	public static void COJAMHJFIEG<T>(this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x25FB6C0", Offset = "0x25FA4C0", VA = "0x1825FB6C0")]
	public static string PEKCEHGGCCK<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
	public static T[] JAODPMDOGKJ<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x25FB2B0", Offset = "0x25FA0B0", VA = "0x1825FB2B0")]
	public static T MHEOMGMBJHC<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO, int GKGOKFIMAIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAB90", Offset = "0x1DA9990", VA = "0x181DAAB90")]
	public static T IEAJCJMIOHE<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, int GKGOKFIMAIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x25F5A80", Offset = "0x25F4880", VA = "0x1825F5A80")]
	public static T COENEOCIEIO<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO, int GKGOKFIMAIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25F5DF0", Offset = "0x25F4BF0", VA = "0x1825F5DF0")]
	public static void DFGFKLLLOGA<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, int GKGOKFIMAIP, [In] T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25F9200", Offset = "0x25F8000", VA = "0x1825F9200")]
	public static void IEFFJBLCOCG<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, int GKGOKFIMAIP, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0020", Offset = "0x1D9EE20", VA = "0x181DA0020")]
	public static int MIKCMFEBOEM<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25FAF30", Offset = "0x25F9D30", VA = "0x1825FAF30")]
	public static ReadOnlySpan<T> KAPJCOIOMHD<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25F5C10", Offset = "0x25F4A10", VA = "0x1825F5C10")]
	public static T[] CPDFCJLPGJA<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x25FB540", Offset = "0x25FA340", VA = "0x1825FB540")]
	public static T ONIIPOJOJGH<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25F6DC0", Offset = "0x25F5BC0", VA = "0x1825F6DC0")]
	public static T[] GMBPDOPHKOI<T>(this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25F6530", Offset = "0x25F5330", VA = "0x1825F6530")]
	public static IPPOBGFPAOB<T> EOIEEPGGLKC<T>(this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return default(IPPOBGFPAOB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25F6830", Offset = "0x25F5630", VA = "0x1825F6830")]
	public static void GALNLGNAACN<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, [In] T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25F5880", Offset = "0x25F4680", VA = "0x1825F5880")]
	public static void AGLKANBEGBB<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25F6670", Offset = "0x25F5470", VA = "0x1825F6670")]
	public static void FPKCONKHPOM<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, int OHINPGIGDNE, [In] T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x25F59B0", Offset = "0x25F47B0", VA = "0x1825F59B0")]
	public static void ALFONFPACHD<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x25FB320", Offset = "0x25FA120", VA = "0x1825FB320")]
	public static T MIJKCCEKEKP<T>(this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x25F7900", Offset = "0x25F6700", VA = "0x1825F7900")]
	public static void HGHKKEOEJNM<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, int DPKFLHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x25F9570", Offset = "0x25F8370", VA = "0x1825F9570")]
	private static void ILPEDGONBCF<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, int DKDCFCAKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x25FB430", Offset = "0x25FA230", VA = "0x1825FB430")]
	public static void OCIHDBDLDKI<T>(this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x25FB0B0", Offset = "0x25F9EB0", VA = "0x1825FB0B0")]
	public static FFPIJGBCMLA<T> MAIDNGBLMAC<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO, NKFOPCDNGGF<T, T> LOAJHIPJPCA)
	{
		return default(FFPIJGBCMLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x25FB010", Offset = "0x25F9E10", VA = "0x1825FB010")]
	public static bool LPNKONCOFEK<T>(this FFPIJGBCMLA<T> OELHNDCFEMO, [In] T MAEBFBHFPDE) where T : CFGACMJPKMC<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25FB000", Offset = "0x25F9E00", VA = "0x1825FB000")]
	public static bool KMJOLKOJMGL<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25FB380", Offset = "0x25FA180", VA = "0x1825FB380")]
	public static bool NIMCBFIACMN<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO, int GKGOKFIMAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x25F6D90", Offset = "0x25F5B90", VA = "0x1825F6D90")]
	public static FFPIJGBCMLA<T>.FGKNNFKLCGN GGNEAJGHJIC<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return default(FFPIJGBCMLA<T>.FGKNNFKLCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25F6D90", Offset = "0x25F5B90", VA = "0x1825F6D90")]
	public static FFPIJGBCMLA<T>.HDBNCPMCICK KPKMKOKFKIA<T>(this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return default(FFPIJGBCMLA<T>.HDBNCPMCICK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25FAEC0", Offset = "0x25F9CC0", VA = "0x1825FAEC0")]
	public static PKNKEOLHBCK<T, FFPIJGBCMLA<T>.FGKNNFKLCGN> JPGNJFCBBKO<T>([In] this FFPIJGBCMLA<T> OELHNDCFEMO)
	{
		return default(PKNKEOLHBCK<T, FFPIJGBCMLA<T>.FGKNNFKLCGN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class FLPEMCAEELC
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2734FE0", Offset = "0x2733DE0", VA = "0x182734FE0")]
	public static T[] IMKENEPIPCC<T>(int JEOEJJBKODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	public static void BOIDPIPMFIE<T>(T[] HHAMBPGBENG)
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
