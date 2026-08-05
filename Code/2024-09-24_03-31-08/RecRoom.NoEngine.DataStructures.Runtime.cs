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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C6ABD0", Offset = "0x6C695D0", VA = "0x186C6ABD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NEAFCCHAHDF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	protected NEAFCCHAHDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DNHFCELCIGM<T> : NEAFCCHAHDF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct MKCHCNGLJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum LANACKNJGEJ
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
		public LANACKNJGEJ AOGCIMANLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T GGEEGOKOMKJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int AICMLLNJJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool OGPMEMHMIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool OIPLFCCFIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? KIJBJEPCALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<MKCHCNGLJJJ>? LFGBHBDABPO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BCFCBJOGJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5AA86B0", Offset = "0x5AA70B0", VA = "0x185AA86B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8960", Offset = "0x5AA7360", VA = "0x185AA8960")]
	protected DNHFCELCIGM(bool OIPLFCCFIOM, bool OGPMEMHMIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8710", Offset = "0x5AA7110", VA = "0x185AA8710")]
	protected bool NLMJLAHBDOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5AA8380", Offset = "0x5AA6D80", VA = "0x185AA8380")]
	protected void INKCFLEKGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5AA7F40", Offset = "0x5AA6940", VA = "0x185AA7F40")]
	protected void CHDCMDBIEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2BFED70", Offset = "0x2BFD770", VA = "0x182BFED70")]
	private static void KEEOFPABBEI<U>(List<U>? GLCCIANLCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5AA84A0", Offset = "0x5AA6EA0", VA = "0x185AA84A0", Slot = "4")]
	public void KDCHLCHLBCK(T GGEEGOKOMKJ, bool MCDEOCGGKLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5AA81B0", Offset = "0x5AA6BB0", VA = "0x185AA81B0", Slot = "5")]
	public void GDFNAHCIADO(T GGEEGOKOMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5AA87B0", Offset = "0x5AA71B0", VA = "0x185AA87B0")]
	public void ODPBLJHKGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class BPJHNJKJMPB : DNHFCELCIGM<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C68A40", Offset = "0x6C67440", VA = "0x186C68A40")]
	public BPJHNJKJMPB(bool OIPLFCCFIOM = false, bool OGPMEMHMIAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C68780", Offset = "0x6C67180", VA = "0x186C68780")]
	public void CPLCIOOIDJC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C68980", Offset = "0x6C67380", VA = "0x186C68980")]
	public static BPJHNJKJMPB IPNPDFIMLPL(BPJHNJKJMPB LHNIONJAHDN, Action GGEEGOKOMKJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C689E0", Offset = "0x6C673E0", VA = "0x186C689E0")]
	public static BPJHNJKJMPB MDDNDNDEHGB(BPJHNJKJMPB LHNIONJAHDN, Action GGEEGOKOMKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GJCAFMIGDML<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDCHLCHLBCK(Action<T> GGEEGOKOMKJ, bool MCDEOCGGKLE = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDFNAHCIADO(Action<T> GGEEGOKOMKJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class ANPPHEALLCN<T> : DNHFCELCIGM<Action<T>>, GJCAFMIGDML<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A242F0", Offset = "0x3A22CF0", VA = "0x183A242F0")]
	public ANPPHEALLCN(bool OIPLFCCFIOM = false, bool OGPMEMHMIAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3EABF80", Offset = "0x3EAA980", VA = "0x183EABF80")]
	public void CPLCIOOIDJC(T NNEFLDDEJJK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A241B0", Offset = "0x3A22BB0", VA = "0x183A241B0")]
	public static ANPPHEALLCN<T> IPNPDFIMLPL(ANPPHEALLCN<T> LHNIONJAHDN, Action<T> GGEEGOKOMKJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A24250", Offset = "0x3A22C50", VA = "0x183A24250")]
	public static ANPPHEALLCN<T> MDDNDNDEHGB(ANPPHEALLCN<T> LHNIONJAHDN, Action<T> GGEEGOKOMKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MBCGAFANIEJ<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class LNJIOIKIJCK<T, U> : DNHFCELCIGM<Action<T, U>>, MBCGAFANIEJ<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A242F0", Offset = "0x3A22CF0", VA = "0x183A242F0")]
	public LNJIOIKIJCK(bool OIPLFCCFIOM = false, bool OGPMEMHMIAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x44A99F0", Offset = "0x44A83F0", VA = "0x1844A99F0")]
	public void CPLCIOOIDJC(T NNEFLDDEJJK, U FGCGMAFCFAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A241B0", Offset = "0x3A22BB0", VA = "0x183A241B0")]
	public static LNJIOIKIJCK<T, U> IPNPDFIMLPL(LNJIOIKIJCK<T, U> LHNIONJAHDN, Action<T, U> GGEEGOKOMKJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A24250", Offset = "0x3A22C50", VA = "0x183A24250")]
	public static LNJIOIKIJCK<T, U> MDDNDNDEHGB(LNJIOIKIJCK<T, U> LHNIONJAHDN, Action<T, U> GGEEGOKOMKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FIGHDDEIJIF<T, U, V> : DNHFCELCIGM<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A242F0", Offset = "0x3A22CF0", VA = "0x183A242F0")]
	public FIGHDDEIJIF(bool OIPLFCCFIOM = false, bool OGPMEMHMIAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA970", Offset = "0x3DF9370", VA = "0x183DFA970")]
	public void CPLCIOOIDJC(T NNEFLDDEJJK, U FGCGMAFCFAK, V NLEGDNPENLM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A241B0", Offset = "0x3A22BB0", VA = "0x183A241B0")]
	public static FIGHDDEIJIF<T, U, V> IPNPDFIMLPL(FIGHDDEIJIF<T, U, V> LHNIONJAHDN, Action<T, U, V> GGEEGOKOMKJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A24250", Offset = "0x3A22C50", VA = "0x183A24250")]
	public static FIGHDDEIJIF<T, U, V> MDDNDNDEHGB(FIGHDDEIJIF<T, U, V> LHNIONJAHDN, Action<T, U, V> GGEEGOKOMKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ILHMEJADBEA<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class EJEHNOJOAOD<T, U, V, W> : DNHFCELCIGM<Action<T, U, V, W>>, ILHMEJADBEA<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3A242F0", Offset = "0x3A22CF0", VA = "0x183A242F0")]
	public EJEHNOJOAOD(bool OIPLFCCFIOM = false, bool OGPMEMHMIAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3A23E60", Offset = "0x3A22860", VA = "0x183A23E60")]
	public void CPLCIOOIDJC(T NNEFLDDEJJK, U FGCGMAFCFAK, V NLEGDNPENLM, W LPDFOBDDKHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A241B0", Offset = "0x3A22BB0", VA = "0x183A241B0")]
	public static EJEHNOJOAOD<T, U, V, W> IPNPDFIMLPL(EJEHNOJOAOD<T, U, V, W> LHNIONJAHDN, Action<T, U, V, W> GGEEGOKOMKJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A24250", Offset = "0x3A22C50", VA = "0x183A24250")]
	public static EJEHNOJOAOD<T, U, V, W> MDDNDNDEHGB(EJEHNOJOAOD<T, U, V, W> LHNIONJAHDN, Action<T, U, V, W> GGEEGOKOMKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class AKBNJJMKFJG<T, U, V, W, X> : DNHFCELCIGM<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A242F0", Offset = "0x3A22CF0", VA = "0x183A242F0")]
	public AKBNJJMKFJG(bool OIPLFCCFIOM = false, bool OGPMEMHMIAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E9DEB0", Offset = "0x3E9C8B0", VA = "0x183E9DEB0")]
	public void CPLCIOOIDJC(T NNEFLDDEJJK, U FGCGMAFCFAK, V NLEGDNPENLM, W LPDFOBDDKHG, X OFCNMBDJPHM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3A241B0", Offset = "0x3A22BB0", VA = "0x183A241B0")]
	public static AKBNJJMKFJG<T, U, V, W, X> IPNPDFIMLPL(AKBNJJMKFJG<T, U, V, W, X> LHNIONJAHDN, Action<T, U, V, W, X> GGEEGOKOMKJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A24250", Offset = "0x3A22C50", VA = "0x183A24250")]
	public static AKBNJJMKFJG<T, U, V, W, X> MDDNDNDEHGB(AKBNJJMKFJG<T, U, V, W, X> LHNIONJAHDN, Action<T, U, V, W, X> GGEEGOKOMKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class EPAHDFGJCCC<T, U, V, W, X, Y> : DNHFCELCIGM<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A242F0", Offset = "0x3A22CF0", VA = "0x183A242F0")]
	public EPAHDFGJCCC(bool OIPLFCCFIOM = false, bool OGPMEMHMIAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A4D060", Offset = "0x3A4BA60", VA = "0x183A4D060")]
	public void CPLCIOOIDJC(T NNEFLDDEJJK, U FGCGMAFCFAK, V NLEGDNPENLM, W LPDFOBDDKHG, X OFCNMBDJPHM, Y CONCKFNNMJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3A241B0", Offset = "0x3A22BB0", VA = "0x183A241B0")]
	public static EPAHDFGJCCC<T, U, V, W, X, Y> IPNPDFIMLPL(EPAHDFGJCCC<T, U, V, W, X, Y> LHNIONJAHDN, Action<T, U, V, W, X, Y> GGEEGOKOMKJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A24250", Offset = "0x3A22C50", VA = "0x183A24250")]
	public static EPAHDFGJCCC<T, U, V, W, X, Y> MDDNDNDEHGB(EPAHDFGJCCC<T, U, V, W, X, Y> LHNIONJAHDN, Action<T, U, V, W, X, Y> GGEEGOKOMKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GJBFILECNEC<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HJCAPPCGINM<TKey, TVal> OJGOIKGDANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> PJPEKBPHLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HJCAPPCGINM<TKey, TVal>.EONCGGPHFFD? LIHKFIBGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int OFKMHAPDKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HJCAPPCGINM<TKey, TVal>.IHBDOEDMNMF? MJHNMBPKPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int IFJFFEFLGMJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int BIAGHNHANHG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC210", Offset = "0x3EDAC10", VA = "0x183EDC210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OAKGABBNEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884030", VA = "0x180885630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC890", Offset = "0x3EDB290", VA = "0x183EDC890")]
	public GJBFILECNEC(int OFKMHAPDKDC, [Optional] HJCAPPCGINM<TKey, TVal>.IHBDOEDMNMF? MJHNMBPKPFH, [Optional] IEqualityComparer<TKey>? GIPPNLIFIAH, [Optional] HJCAPPCGINM<TKey, TVal>.EONCGGPHFFD? LIHKFIBGFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EDBA80", Offset = "0x3EDA480", VA = "0x183EDBA80")]
	public void HJKDJNFPBMK(TKey COMNIKKFEEB, TVal IPHMAHBENGI, bool ONNFFDGNJAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC730", Offset = "0x3EDB130", VA = "0x183EDC730")]
	public bool PBFFEKPPDEI(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB860", Offset = "0x3EDA260", VA = "0x183EDB860")]
	public bool FJHIBPMOMDE(TKey LOHNBJHDMGO, [Out] TVal IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB5A0", Offset = "0x3ED9FA0", VA = "0x183EDB5A0")]
	private void BOJNIBJBDDL(TKey COMNIKKFEEB, TVal IPHMAHBENGI, int ECFPAOHDFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC260", Offset = "0x3EDAC60", VA = "0x183EDC260")]
	public bool KKAKDDIOEMA(TKey COMNIKKFEEB, TVal IPHMAHBENGI, bool ONNFFDGNJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC680", Offset = "0x3EDB080", VA = "0x183EDC680")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3EDBCB0", Offset = "0x3EDA6B0", VA = "0x183EDBCB0")]
	private void HKFNLGJKMJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC410", Offset = "0x3EDAE10", VA = "0x183EDC410")]
	private bool NDMJMLIIFOE(TKey COMNIKKFEEB, DCDNMCMJAEH NOJDLJBPIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB960", Offset = "0x3EDA360", VA = "0x183EDB960")]
	private void FKFEPCOFLPA(TKey COMNIKKFEEB, TVal IPHMAHBENGI, DCDNMCMJAEH NOJDLJBPIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC550", Offset = "0x3EDAF50", VA = "0x183EDC550")]
	private void NICGICBLEOO(TKey COMNIKKFEEB, TVal POCLHBJGKBH, DCDNMCMJAEH NOJDLJBPIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FPKGAPAFLAN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action AANCALDPLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HNLMNJFDEOA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public FPKGAPAFLAN(Action PPNPMEBLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C699E0", Offset = "0x6C683E0", VA = "0x186C699E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2ACCAF0", Offset = "0x2ACB4F0", VA = "0x182ACCAF0")]
	public static JOELGMAPIIB<T> EMJKOLAJLFI<T>(T IPHMAHBENGI, Action PPNPMEBLOML) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JOELGMAPIIB<T> : FPKGAPAFLAN where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T ADJCIFCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x430C6A0", Offset = "0x430B0A0", VA = "0x18430C6A0")]
	public JOELGMAPIIB(T IPHMAHBENGI, Action PPNPMEBLOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PKEHIIOPDJK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly PJCAMEOKJFJ<T>? PCKJCLCHODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> FLNAJCCKAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool HNLMNJFDEOA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly PKEHIIOPDJK<T> CKLKOBNMKJP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> GGPNBLCOJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x49B9FF0", Offset = "0x49B89F0", VA = "0x1849B9FF0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x49BA220", Offset = "0x49B8C20", VA = "0x1849BA220")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EMCJBNDMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x49BA2E0", Offset = "0x49B8CE0", VA = "0x1849BA2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x49BA9E0", Offset = "0x49B93E0", VA = "0x1849BA9E0")]
	public PKEHIIOPDJK(PJCAMEOKJFJ<T> LCDKEHAPBJP, PJCAMEOKJFJ<T> LECGIBNHAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x49BA630", Offset = "0x49B9030", VA = "0x1849BA630")]
	public PKEHIIOPDJK(PJCAMEOKJFJ<T> LCDKEHAPBJP, int BHLKMIGNPBH, PJCAMEOKJFJ<T> LECGIBNHAAC, int DFHDKEMDHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x49BA590", Offset = "0x49B8F90", VA = "0x1849BA590")]
	private PKEHIIOPDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x49BA190", Offset = "0x49B8B90", VA = "0x1849BA190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x49BA3A0", Offset = "0x49B8DA0", VA = "0x1849BA3A0")]
	public T[] OPHIMHIMIKB()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49BA070", Offset = "0x49B8A70", VA = "0x1849BA070")]
	public static ReadOnlySequence<T> DBMBPMAANBF(PKEHIIOPDJK<T>? FAGFDNBJNIF)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DBDJPHJPOCF : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct FBDEOPINMKF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
		public static FBDEOPINMKF OOAFHJGKFEK()
		{
			return default(FBDEOPINMKF);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B89090", Offset = "0x2B87A90", VA = "0x182B89090")]
	public static string? GDCAEHFIOEF<T>([Optional] string? ICNDFFFJNNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B89110", Offset = "0x2B87B10", VA = "0x182B89110")]
	public static string? LIEKBCHKLCA<T>([Optional] string? EIFAJBEJCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	public static DBDJPHJPOCF IDOJPEKGCAG(string ICNDFFFJNNB, string? EIFAJBEJCEO)
	{
		return default(DBDJPHJPOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BIECMIJGBJH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool EBFLPGPPKNJ(string JAFILGINHLI, BIECMIJGBJH BAHCDBCMHJN);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MMCLDLCAMAG<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MMCLDLCAMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x472FD90", Offset = "0x472E790", VA = "0x18472FD90")]
		internal void FJFAFNOFDHG(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int OEDIDFDHHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string ACCPKODGLLI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C67EE0", Offset = "0x6C668E0", VA = "0x186C67EE0")]
	public static Dictionary<string, BIECMIJGBJH> JFILMNNPBFB(Type AFLNHAHPOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1150", Offset = "0x2AEFB50", VA = "0x182AF1150")]
	public static Dictionary<string, BIECMIJGBJH> JFILMNNPBFB<T>(Type AFLNHAHPOPM, IReadOnlyDictionary<T, string> DOPEFHFMEJF) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1970", Offset = "0x2AF0370", VA = "0x182AF1970")]
	public static Dictionary<string, BIECMIJGBJH> KAJGPLFBMAE<T>(List<T> CLNPEBLICOG) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C683D0", Offset = "0x6C66DD0", VA = "0x186C683D0")]
	public static Dictionary<string, BIECMIJGBJH> MBOOKEJELOP(Type AFLNHAHPOPM, EBFLPGPPKNJ ONCMCPLIFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C68210", Offset = "0x6C66C10", VA = "0x186C68210")]
	public static Dictionary<int, string> KJAKOCJOBDP(Dictionary<string, BIECMIJGBJH> FCLIEHCKPJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PKNKGFKCKHA : NEIFONLMJBM
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool CMFNBOOBPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? BAPMEEBJIND;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual NEIFONLMJBM? ICHHGKLOEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B350", Offset = "0x6C69D50", VA = "0x186C6B350")]
	protected PKNKGFKCKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string OIFECEDJIAP();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ACB0", Offset = "0x6C696B0", VA = "0x186C6ACB0", Slot = "8")]
	public virtual string FOAOJMKJFHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AF30", Offset = "0x6C69930", VA = "0x186C6AF30", Slot = "9")]
	public void KLBEKGKEDHN(StringBuilder EDHGGEGHBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B1D0", Offset = "0x6C69BD0", VA = "0x186C6B1D0", Slot = "10")]
	public void LMEENIHHILI(StringBuilder EDHGGEGHBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6B230", Offset = "0x6C69C30", VA = "0x186C6B230", Slot = "11")]
	public void LNBCFOIDFBP(StringBuilder EDHGGEGHBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ADD0", Offset = "0x6C697D0", VA = "0x186C6ADD0", Slot = "12")]
	public void IJDFLENFEDN(StringBuilder EDHGGEGHBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AD30", Offset = "0x6C69730", VA = "0x186C6AD30")]
	public static void FOCBAOFFCKJ(StringBuilder EDHGGEGHBMD, string PNALFDIHDDH, string EONDAHFLNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E33760", Offset = "0x5E32160", VA = "0x185E33760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FPMCNHCDBAA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C69A20", Offset = "0x6C68420", VA = "0x186C69A20")]
	public FPMCNHCDBAA(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EDEEKHLINMP<TErr> : FPMCNHCDBAA where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr MOHEAPJAODP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3A03CA0", Offset = "0x3A026A0", VA = "0x183A03CA0")]
	private EDEEKHLINMP([In] TErr IGCAIIAAGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3A03BD0", Offset = "0x3A025D0", VA = "0x183A03BD0")]
	public static EDEEKHLINMP<TErr> OOAFHJGKFEK([In] TErr IGCAIIAAGDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NPDJDCOJMMJ : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm ICJOMHHOMOO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool MILDPAAPGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool PMPIELHHAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool NFHMHJNBNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C6AA80", Offset = "0x6C69480", VA = "0x186C6AA80", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long EDBNILFNKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C6AAF0", Offset = "0x6C694F0", VA = "0x186C6AAF0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6AB60", Offset = "0x6C69560", VA = "0x186C6AB60", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AA10", Offset = "0x6C69410", VA = "0x186C6AA10")]
	public NPDJDCOJMMJ(HashAlgorithm ICJOMHHOMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A840", Offset = "0x6C69240", VA = "0x186C6A840", Slot = "35")]
	public override int Read(byte[] FJOBMDHPMBB, int EDCGGCHLNEI, int CMNDBGDABDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A9E0", Offset = "0x6C693E0", VA = "0x186C6A9E0", Slot = "38")]
	public override void Write(byte[] FJOBMDHPMBB, int EDCGGCHLNEI, int CMNDBGDABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A8E0", Offset = "0x6C692E0", VA = "0x186C6A8E0", Slot = "33")]
	public override long Seek(long EDCGGCHLNEI, SeekOrigin AAJPOGDAOAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A970", Offset = "0x6C69370", VA = "0x186C6A970", Slot = "34")]
	public override void SetLength(long IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A770", Offset = "0x6C69170", VA = "0x186C6A770")]
	public byte[] KMBIJGBPLOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NEIFONLMJBM
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FOAOJMKJFHK();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OIFECEDJIAP();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IHFBNHEJBAF<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions ADJCIFCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IGNBALNMBFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string HPJMIEJIICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PJCAMEOKJFJ<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static PJCAMEOKJFJ<T>? FIDKJCPOOEB;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object ONFFACHMNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? IALPDPJOEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool HNLMNJFDEOA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x92EC70", Offset = "0x92D670", VA = "0x18092EC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x49B39A0", Offset = "0x49B23A0", VA = "0x1849B39A0")]
	private static PJCAMEOKJFJ<T> KOBAODJBLBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49B24F0", Offset = "0x49B0EF0", VA = "0x1849B24F0")]
	private static void DDHFJCECEAH(PJCAMEOKJFJ<T> EANLACGGJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x40DA8A0", Offset = "0x40D92A0", VA = "0x1840DA8A0")]
	private PJCAMEOKJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x49B3580", Offset = "0x49B1F80", VA = "0x1849B3580")]
	public static PJCAMEOKJFJ<T> EMJKOLAJLFI(ReadOnlyMemory<T> ENPGMGIEDFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x49B31A0", Offset = "0x49B1BA0", VA = "0x1849B31A0")]
	public static PJCAMEOKJFJ<T> EMJKOLAJLFI(IMemoryOwner<T> HLBNDNFJJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x49B3860", Offset = "0x49B2260", VA = "0x1849B3860")]
	public static void GGKCHFKKLIJ(PJCAMEOKJFJ<T> LCDKEHAPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x49B2D20", Offset = "0x49B1720", VA = "0x1849B2D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x49B3750", Offset = "0x49B2150", VA = "0x1849B3750")]
	public PJCAMEOKJFJ<T> FFOEOKOCNDM(IMemoryOwner<T> HLBNDNFJJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x49B30A0", Offset = "0x49B1AA0", VA = "0x1849B30A0")]
	private void EKOCBMDLKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x49B3E50", Offset = "0x49B2850", VA = "0x1849B3E50")]
	private PJCAMEOKJFJ<T> LNEMIDPLFMN(PJCAMEOKJFJ<T> EANLACGGJJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OMJBFNLOHKO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C6AC50", Offset = "0x6C69650", VA = "0x186C6AC50")]
	public OMJBFNLOHKO(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FPGHPPLDPEJ<TOk> : OMJBFNLOHKO where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk DBAIPOMODAB;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3E09B90", Offset = "0x3E08590", VA = "0x183E09B90")]
	private FPGHPPLDPEJ([In] TOk KJJDPPHMNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3E09A00", Offset = "0x3E08400", VA = "0x183E09A00")]
	public static FPGHPPLDPEJ<TOk> OOAFHJGKFEK([In] TOk KJJDPPHMNIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct CDOLGFBAJII<TOk, TErr> : IEquatable<CDOLGFBAJII<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> NANNDMILDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr MOHEAPJAODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk DBAIPOMODAB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool LAJJGAFKMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x53EFD60", Offset = "0x53EE760", VA = "0x1853EFD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LNKBJBGLMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x53EEA60", Offset = "0x53ED460", VA = "0x1853EEA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x53F5090", Offset = "0x53F3A90", VA = "0x1853F5090")]
	internal CDOLGFBAJII([In] TErr IGCAIIAAGDG, [In] TOk KJJDPPHMNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x53F16A0", Offset = "0x53F00A0", VA = "0x1853F16A0")]
	public static CDOLGFBAJII<TOk, TErr> HJJJBALEKMA([In] TErr IGCAIIAAGDG)
	{
		return default(CDOLGFBAJII<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x53F0260", Offset = "0x53EEC60", VA = "0x1853F0260")]
	public static CDOLGFBAJII<TOk, TErr> GGEKGKLJLMN([In] TOk KJJDPPHMNIA)
	{
		return default(CDOLGFBAJII<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6120", Offset = "0x2BF4B20", VA = "0x182BF6120")]
	public CDOLGFBAJII<TOk?, UErr?> ODNABELCMHK<UErr>()
	{
		return default(CDOLGFBAJII<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF4A80", Offset = "0x2BF3480", VA = "0x182BF4A80")]
	public CDOLGFBAJII<UOk?, TErr?> IBIGIBAGCHC<UOk>()
	{
		return default(CDOLGFBAJII<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5490", Offset = "0x2BF3E90", VA = "0x182BF5490")]
	public CDOLGFBAJII<UOk?, TErr?> OCFEPPLNDMD<UOk>()
	{
		return default(CDOLGFBAJII<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF44E0", Offset = "0x2BF2EE0", VA = "0x182BF44E0")]
	public CDOLGFBAJII<TOk?, UErr?> GBDIOKGPGKB<UErr>()
	{
		return default(CDOLGFBAJII<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x53F2F00", Offset = "0x53F1900", VA = "0x1853F2F00")]
	public CDOLGFBAJII<AJBBHDJGBPP, TErr> OCBMPLJBLHG()
	{
		return default(CDOLGFBAJII<AJBBHDJGBPP, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53F1E10", Offset = "0x53F0810", VA = "0x1853F1E10")]
	public static bool JGJOKBKMGBC([In] CDOLGFBAJII<TOk, TErr> OMCEEKENOBB, [In] CDOLGFBAJII<TOk, TErr> MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53EEF40", Offset = "0x53ED940", VA = "0x1853EEF40", Slot = "4")]
	public bool Equals(CDOLGFBAJII<TOk, TErr> CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53EF1A0", Offset = "0x53EDBA0", VA = "0x1853EF1A0", Slot = "0")]
	public override bool Equals(object CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x53F10A0", Offset = "0x53EFAA0", VA = "0x1853F10A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x53F3EA0", Offset = "0x53F28A0", VA = "0x1853F3EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IBNJBNHBCAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FFLPAAAMCNA<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<CDOLGFBAJII<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<CDOLGFBAJII<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF660", Offset = "0x3DEE060", VA = "0x183DEF660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF980", Offset = "0x3DEE380", VA = "0x183DEF980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D903B0", Offset = "0x2D8EDB0", VA = "0x182D903B0")]
	public static CDOLGFBAJII<TOk?, TErr?> DBAIPOMODAB<TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [In] TOk KJJDPPHMNIA)
	{
		return default(CDOLGFBAJII<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D90460", Offset = "0x2D8EE60", VA = "0x182D90460")]
	public static CDOLGFBAJII<AJBBHDJGBPP, TErr?> DBAIPOMODAB<TErr>([In] this CDOLGFBAJII<AJBBHDJGBPP, TErr> NKCEKILMAAM)
	{
		return default(CDOLGFBAJII<AJBBHDJGBPP, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D903B0", Offset = "0x2D8EDB0", VA = "0x182D903B0")]
	public static CDOLGFBAJII<TOk?, TErr?> MOHEAPJAODP<TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [In] TErr IGCAIIAAGDG)
	{
		return default(CDOLGFBAJII<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D91300", Offset = "0x2D8FD00", VA = "0x182D91300")]
	public static TOk? JINAAKDMEIO<TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D90A40", Offset = "0x2D8F440", VA = "0x182D90A40")]
	[AsyncStateMachine(typeof(FFLPAAAMCNA<, >))]
	public static Task<TOk?>? GHOEEBJBKGL<TOk, TErr>(this Task<CDOLGFBAJII<TOk, TErr>> NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D908E0", Offset = "0x2D8F2E0", VA = "0x182D908E0")]
	public static TErr? FOJMICBGBFA<TErr, TOk>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D92480", Offset = "0x2D90E80", VA = "0x182D92480")]
	public static bool PPNALPBHAAA<TOk, TErr, UErr, UOk>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [Out] CDOLGFBAJII<UOk, UErr> EMBGKJCPMJK) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D915E0", Offset = "0x2D8FFE0", VA = "0x182D915E0")]
	public static bool KICINAOIFDG<TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [Out][NotNullWhen(true)] TOk KJJDPPHMNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D91DE0", Offset = "0x2D907E0", VA = "0x182D91DE0")]
	public static bool NIHAIKKICJM<TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [Out][NotNullWhen(true)] TErr IGCAIIAAGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D90FB0", Offset = "0x2D8F9B0", VA = "0x182D90FB0")]
	public static bool IHEHEMJPHFF<TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [Out][NotNullWhen(true)] TOk KJJDPPHMNIA, [Out][NotNullWhen(false)] TErr IGCAIIAAGDG) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2D90D10", Offset = "0x2D8F710", VA = "0x182D90D10")]
	public static bool IGEDJJMPCNC<TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [Out][NotNullWhen(true)] TOk KJJDPPHMNIA, [Out] CDOLGFBAJII<TOk, TErr> EMBGKJCPMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D926F0", Offset = "0x2D910F0", VA = "0x182D926F0")]
	public static bool PPNALPBHAAA<TOk, TErr, UErr, UOk>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [Out][NotNullWhen(true)] TOk KJJDPPHMNIA, [Out] CDOLGFBAJII<UOk, UErr> EMBGKJCPMJK) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D91FA0", Offset = "0x2D909A0", VA = "0x182D91FA0")]
	public static bool PDOHPFCKJMA<TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [Out][NotNullWhen(true)] TOk KJJDPPHMNIA, [Out] CDOLGFBAJII<AJBBHDJGBPP, TErr> EMBGKJCPMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D91A20", Offset = "0x2D90420", VA = "0x182D91A20")]
	public static CDOLGFBAJII<UOk, UErr> LALKLJCIJIN<UOk, UErr, TOk, TErr>([In] this CDOLGFBAJII<TOk, TErr> NKCEKILMAAM, [In] CDOLGFBAJII<UOk, UErr> DICHKFJDHIG) where TOk : UOk where TErr : UErr
	{
		return default(CDOLGFBAJII<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D90040", Offset = "0x2D8EA40", VA = "0x182D90040")]
	public static CDOLGFBAJII<TOk?[]?, TErr?> ADBFENJGCIC<TOk, TErr>(this IEnumerable<CDOLGFBAJII<TOk, TErr>> NKCEKILMAAM)
	{
		return default(CDOLGFBAJII<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MHFINEILHEF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E700", Offset = "0x2C8D100", VA = "0x182C8E700")]
	public static CDOLGFBAJII<TOk, T> DBAIPOMODAB<TOk>([In] TOk KJJDPPHMNIA) where TOk : notnull
	{
		return default(CDOLGFBAJII<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4698D10", Offset = "0x4697710", VA = "0x184698D10")]
	public static CDOLGFBAJII<AJBBHDJGBPP, T> DBAIPOMODAB()
	{
		return default(CDOLGFBAJII<AJBBHDJGBPP, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E700", Offset = "0x2C8D100", VA = "0x182C8E700")]
	public static CDOLGFBAJII<T, TErr> MOHEAPJAODP<TErr>([In] TErr IGCAIIAAGDG) where TErr : notnull
	{
		return default(CDOLGFBAJII<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct MBALPCHGGJD<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly FGOKPCLCGNJ INHCGCINENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> LLAOLPIPCFI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6270", Offset = "0x3EA4C70", VA = "0x183EA6270")]
	public static MBALPCHGGJD<TKey, TValue> OOAFHJGKFEK(string MPOBGCPIOEI)
	{
		return default(MBALPCHGGJD<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6390", Offset = "0x3EA4D90", VA = "0x183EA6390")]
	internal MBALPCHGGJD(Dictionary<TKey, TValue> IPHMAHBENGI, FGOKPCLCGNJ MOBCMNPOMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3EA61D0", Offset = "0x3EA4BD0", VA = "0x183EA61D0")]
	public EFNJNMIDCEL<TKey, TValue> NBDMKIDCIJP([Out] Dictionary<TKey, TValue> IPHMAHBENGI)
	{
		return default(EFNJNMIDCEL<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct EFNJNMIDCEL<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> LLAOLPIPCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly EMDABDDPFIA APELKCAKELG;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x22F1CA0", Offset = "0x22F06A0", VA = "0x1822F1CA0")]
	internal EFNJNMIDCEL(Dictionary<TKey, TValue> IPHMAHBENGI, EMDABDDPFIA PINIGOICBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FD40", Offset = "0x3A0E740", VA = "0x183A0FD40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct KPGJLCNIIGJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly FGOKPCLCGNJ INHCGCINENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> LLAOLPIPCFI;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6270", Offset = "0x3EA4C70", VA = "0x183EA6270")]
	public static KPGJLCNIIGJ<T> OOAFHJGKFEK(string MPOBGCPIOEI)
	{
		return default(KPGJLCNIIGJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6390", Offset = "0x3EA4D90", VA = "0x183EA6390")]
	internal KPGJLCNIIGJ(HashSet<T> IPHMAHBENGI, FGOKPCLCGNJ MOBCMNPOMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3EA61D0", Offset = "0x3EA4BD0", VA = "0x183EA61D0")]
	public AJFNAMAFLGL<T> NBDMKIDCIJP([Out] HashSet<T> IPHMAHBENGI)
	{
		return default(AJFNAMAFLGL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct AJFNAMAFLGL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> LLAOLPIPCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EMDABDDPFIA APELKCAKELG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x22F1CA0", Offset = "0x22F06A0", VA = "0x1822F1CA0")]
	internal AJFNAMAFLGL(HashSet<T> IPHMAHBENGI, EMDABDDPFIA PINIGOICBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FD40", Offset = "0x3A0E740", VA = "0x183A0FD40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct AMEABFHCLEB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FGOKPCLCGNJ INHCGCINENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> LLAOLPIPCFI;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6270", Offset = "0x3EA4C70", VA = "0x183EA6270")]
	public static AMEABFHCLEB<T> OOAFHJGKFEK(string MPOBGCPIOEI)
	{
		return default(AMEABFHCLEB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6390", Offset = "0x3EA4D90", VA = "0x183EA6390")]
	internal AMEABFHCLEB(Stack<T> IPHMAHBENGI, FGOKPCLCGNJ MOBCMNPOMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3EA61D0", Offset = "0x3EA4BD0", VA = "0x183EA61D0")]
	public OMGIEJJMBCC<T> NBDMKIDCIJP([Out] Stack<T> IPHMAHBENGI)
	{
		return default(OMGIEJJMBCC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct OMGIEJJMBCC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> LLAOLPIPCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EMDABDDPFIA APELKCAKELG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x22F1CA0", Offset = "0x22F06A0", VA = "0x1822F1CA0")]
	internal OMGIEJJMBCC(Stack<T> IPHMAHBENGI, EMDABDDPFIA PINIGOICBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A0FD40", Offset = "0x3A0E740", VA = "0x183A0FD40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class MBLIOBFEBHI<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct DFGNDNHMCNA : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly MBLIOBFEBHI<T> JNBNLEMDFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int JHOIPOBCHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool HOLALCIEMAL;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x202CF80", Offset = "0x202B980", VA = "0x18202CF80")]
		public DFGNDNHMCNA(MBLIOBFEBHI<T> KCEPABIAINB, int NLFDFCKLCHN, bool KEHJJFHPGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5A884C0", Offset = "0x5A86EC0", VA = "0x185A884C0")]
		public MBLIOBFEBHI<T>.EOFIOLCAILD PBHEMGCNMMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5A885B0", Offset = "0x5A86FB0", VA = "0x185A885B0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5A885B0", Offset = "0x5A86FB0", VA = "0x185A885B0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class EOFIOLCAILD : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly MBLIOBFEBHI<T> JNBNLEMDFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int PAJNMKCCGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int IMAPBIDBLMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool HOLALCIEMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool GABONBIGEHF;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x3A4B290", Offset = "0x3A49C90", VA = "0x183A4B290")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3A4B4F0", Offset = "0x3A49EF0", VA = "0x183A4B4F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3A4B5A0", Offset = "0x3A49FA0", VA = "0x183A4B5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A4BB40", Offset = "0x3A4A540", VA = "0x183A4BB40")]
		public EOFIOLCAILD(MBLIOBFEBHI<T> KCEPABIAINB, int NLFDFCKLCHN, bool KEHJJFHPGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A4B350", Offset = "0x3A49D50", VA = "0x183A4B350", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3A4B3E0", Offset = "0x3A49DE0", VA = "0x183A4B3E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class ONEEIILPFKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ONEEIILPFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x490A500", Offset = "0x4908F00", VA = "0x18490A500")]
		internal T HNJIKPCIEHG(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] LNFBMINHLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int IMAPBIDBLMC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int LKCNHCHHNNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x467EA70", Offset = "0x467D470", VA = "0x18467EA70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T EEAPHIFBJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3DB8B00", Offset = "0x3DB7500", VA = "0x183DB8B00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T PNIOHMAODCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x467EA30", Offset = "0x467D430", VA = "0x18467EA30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x467EB90", Offset = "0x467D590", VA = "0x18467EB90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1C8C1A0", Offset = "0x1C8ABA0", VA = "0x181C8C1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x13B96A0", Offset = "0x13B80A0", VA = "0x1813B96A0")]
	private static int BCNLOINKNAD(int ENMILGHAHOM, int CGDCIDKGGML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x467ECA0", Offset = "0x467D6A0", VA = "0x18467ECA0")]
	public MBLIOBFEBHI(int ECFPAOHDFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x467EDC0", Offset = "0x467D7C0", VA = "0x18467EDC0")]
	public MBLIOBFEBHI(int ECFPAOHDFEB, Func<T> OHLNKNHGNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x467ED20", Offset = "0x467D720", VA = "0x18467ED20")]
	public MBLIOBFEBHI(T[] CCIELLHDDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x467EA00", Offset = "0x467D400", VA = "0x18467EA00")]
	public void BHJAPOKHKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x467EAD0", Offset = "0x467D4D0", VA = "0x18467EAD0")]
	public IEnumerable<T> HDMIJCMLJLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x467EC00", Offset = "0x467D600", VA = "0x18467EC00")]
	public MBLIOBFEBHI<T>.EOFIOLCAILD PBHEMGCNMMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AE10", Offset = "0x3E49810", VA = "0x183E4AE10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AE10", Offset = "0x3E49810", VA = "0x183E4AE10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OFCMJDIIAFF
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F003C0", Offset = "0x2EFEDC0", VA = "0x182F003C0")]
	public static MBLIOBFEBHI<T> OOAFHJGKFEK<T>(int ECFPAOHDFEB, Func<T> OHLNKNHGNKF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class DDMMABHIGOA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct HBBKPKCMKMJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly DDMMABHIGOA<T> OHFMLDNGNLC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T ADJCIFCGLHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x3F43970", Offset = "0x3F42370", VA = "0x183F43970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F43940", Offset = "0x3F42340", VA = "0x183F43940", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
		public HBBKPKCMKMJ(DDMMABHIGOA<T> OHFMLDNGNLC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BIALCMOBFJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<HBBKPKCMKMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DDMMABHIGOA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x50C03B0", Offset = "0x50BEDB0", VA = "0x1850C03B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5350", Offset = "0x3DF3D50", VA = "0x183DF5350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim BHDNKIBBABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T FHNCCICEJBE;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5A7B4A0", Offset = "0x5A79EA0", VA = "0x185A7B4A0")]
	public DDMMABHIGOA([In] T FHNCCICEJBE, int KDDPBEMPEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5A7B460", Offset = "0x5A79E60", VA = "0x185A7B460")]
	public DDMMABHIGOA([In] T FHNCCICEJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5A7AD50", Offset = "0x5A79750", VA = "0x185A7AD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5A7B210", Offset = "0x5A79C10", VA = "0x185A7B210")]
	public HBBKPKCMKMJ LAAMLADCMIP()
	{
		return default(HBBKPKCMKMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5A7AD90", Offset = "0x5A79790", VA = "0x185A7AD90")]
	[AsyncStateMachine(typeof(DDMMABHIGOA<>.BIALCMOBFJP))]
	public Task<DDMMABHIGOA<T>.HBBKPKCMKMJ> IFOICGAFAAO(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5A7B250", Offset = "0x5A79C50", VA = "0x185A7B250")]
	public void NJKMJFNLACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class KEMLIHHFFLI
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A1E0", Offset = "0x6C68BE0", VA = "0x186C6A1E0")]
	public static DDMMABHIGOA<AJBBHDJGBPP> OOAFHJGKFEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0970", Offset = "0x2BCF370", VA = "0x182BD0970")]
	public static DDMMABHIGOA<T> OOAFHJGKFEK<T>([In] T FHNCCICEJBE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class HAKONNOGEBH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct AGOENBIAMHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly HAKONNOGEBH<T> OIJEODCONLD;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T ADJCIFCGLHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x3E06770", Offset = "0x3E05170", VA = "0x183E06770")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E97250", Offset = "0x3E95C50", VA = "0x183E97250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
		internal AGOENBIAMHB(HAKONNOGEBH<T> OHFMLDNGNLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct FNIKNBJOHAH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly HAKONNOGEBH<T> OIJEODCONLD;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T ADJCIFCGLHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x3E06770", Offset = "0x3E05170", VA = "0x183E06770")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E06680", Offset = "0x3E05080", VA = "0x183E06680", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
		internal FNIKNBJOHAH(HAKONNOGEBH<T> OHFMLDNGNLC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct IJGMJIKIDLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<FNIKNBJOHAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public HAKONNOGEBH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private DDMMABHIGOA<AJBBHDJGBPP>.HBBKPKCMKMJ <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<DDMMABHIGOA<AJBBHDJGBPP>.HBBKPKCMKMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x409EEA0", Offset = "0x409D8A0", VA = "0x18409EEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5350", Offset = "0x3DF3D50", VA = "0x183DF5350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly DDMMABHIGOA<int> KBEGNACMNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DDMMABHIGOA<AJBBHDJGBPP> NIOLHDLGLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly DDMMABHIGOA<AJBBHDJGBPP> LNIKJGGPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T CIMGEIMBIBP;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3F436E0", Offset = "0x3F420E0", VA = "0x183F436E0")]
	internal HAKONNOGEBH(DDMMABHIGOA<int> HAIFHCHCEFB, DDMMABHIGOA<AJBBHDJGBPP> IPBKNLNHAOC, DDMMABHIGOA<AJBBHDJGBPP> MKICLMFOBMB, [In] T FHNCCICEJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3F42870", Offset = "0x3F41270", VA = "0x183F42870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F42C10", Offset = "0x3F41610", VA = "0x183F42C10")]
	public AGOENBIAMHB FOKGFCGOOPP()
	{
		return default(AGOENBIAMHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F43160", Offset = "0x3F41B60", VA = "0x183F43160")]
	public FNIKNBJOHAH IMMKLNFIFBN()
	{
		return default(FNIKNBJOHAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3F435C0", Offset = "0x3F41FC0", VA = "0x183F435C0")]
	[AsyncStateMachine(typeof(HAKONNOGEBH<>.IJGMJIKIDLO))]
	public Task<HAKONNOGEBH<T>.FNIKNBJOHAH> JKHMNHKDFAJ(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CMEMBCHDLPE
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6C68AA0", Offset = "0x6C674A0", VA = "0x186C68AA0")]
	public static HAKONNOGEBH<AJBBHDJGBPP> OOAFHJGKFEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2B5BB40", Offset = "0x2B5A540", VA = "0x182B5BB40")]
	public static HAKONNOGEBH<T> OOAFHJGKFEK<T>([In] T FHNCCICEJBE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class GJBKLDBLKEL<TData> : PKNKGFKCKHA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string LCPAEDDGIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData EIPGALGMOJD;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
	public override string OIFECEDJIAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3EDCA90", Offset = "0x3EDB490", VA = "0x183EDCA90")]
	internal GJBKLDBLKEL(string BBDGOIMNDJI, [In] TData LNCKNHNHHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HAEPBBAGBJC
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6C69A80", Offset = "0x6C68480", VA = "0x186C69A80")]
	public static GJBKLDBLKEL<AJBBHDJGBPP> OOAFHJGKFEK(string BBDGOIMNDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2ACCAF0", Offset = "0x2ACB4F0", VA = "0x182ACCAF0")]
	public static GJBKLDBLKEL<TData> OOAFHJGKFEK<TData>(string BBDGOIMNDJI, [In] TData LNCKNHNHHDF) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class FGOKPCLCGNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool LGKAJIJENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string IGNOIENNNCA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8F0ED0", Offset = "0x8EF8D0", VA = "0x1808F0ED0")]
	private FGOKPCLCGNJ(bool ABACJKPGMHL, string DBCOCEPMKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C69650", Offset = "0x6C68050", VA = "0x186C69650")]
	public static FGOKPCLCGNJ OOAFHJGKFEK(string DBCOCEPMKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6C69590", Offset = "0x6C67F90", VA = "0x186C69590")]
	public EMDABDDPFIA NBDMKIDCIJP()
	{
		return default(EMDABDDPFIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct EMDABDDPFIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly FGOKPCLCGNJ NPCOBKNCGHD;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	internal EMDABDDPFIA(FGOKPCLCGNJ MPOBGCPIOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C69490", Offset = "0x6C67E90", VA = "0x186C69490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class ONFNPMDFDJF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EJFPAGCOJIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public EJFPAGCOJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A24F70", Offset = "0x3A23970", VA = "0x183A24F70")]
		internal int IIKFFBGGPJC(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? KINLEBNGJBE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> DIMEEMFFBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x490AA10", Offset = "0x4909410", VA = "0x18490AA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JKJGGPJDJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x490A640", Offset = "0x4909040", VA = "0x18490A640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x885600", Offset = "0x884000", VA = "0x180885600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x490A850", Offset = "0x4909250", VA = "0x18490A850")]
	public bool KDCHLCHLBCK(T OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x490A6E0", Offset = "0x49090E0", VA = "0x18490A6E0")]
	public bool GDFNAHCIADO(T OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x490A690", Offset = "0x4909090", VA = "0x18490A690")]
	public bool DDGNJIHOIKG(T OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x490AA50", Offset = "0x4909450", VA = "0x18490AA50")]
	public void PEIPIMGGMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x490AB30", Offset = "0x4909530", VA = "0x18490AB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public ONFNPMDFDJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class INDEDCJDEPL
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class IKBPKBAIPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IKBPKBAIPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C69C90", Offset = "0x6C68690", VA = "0x186C69C90")]
		internal int IIKFFBGGPJC(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? KINLEBNGJBE;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> DIMEEMFFBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6C69F30", Offset = "0x6C68930", VA = "0x186C69F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool JKJGGPJDJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6C69D40", Offset = "0x6C68740", VA = "0x186C69D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x885600", Offset = "0x884000", VA = "0x180885600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C69E50", Offset = "0x6C68850", VA = "0x186C69E50")]
	public bool KDCHLCHLBCK(object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C69DB0", Offset = "0x6C687B0", VA = "0x186C69DB0")]
	public bool GDFNAHCIADO(object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C69D50", Offset = "0x6C68750", VA = "0x186C69D50")]
	public bool DDGNJIHOIKG(object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C69FC0", Offset = "0x6C689C0", VA = "0x186C69FC0")]
	public void PEIPIMGGMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A030", Offset = "0x6C68A30", VA = "0x186C6A030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public INDEDCJDEPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class BCJFGAIKODP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct OIKFIODIPIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float AAHGBGABHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T ADJCIFCGLHC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, OIKFIODIPIA> BHMPBJAIPDE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T HJBCBJPIEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x12AA330", Offset = "0x12A8D30", VA = "0x1812AA330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x12A9920", Offset = "0x12A8320", VA = "0x1812A9920", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? OCBBCPGCBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool KDBJPNBHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5099110", Offset = "0x5097B10", VA = "0x185099110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5096CA0", Offset = "0x50956A0", VA = "0x185096CA0")]
	public bool FALBPNDCFJG(T IPHMAHBENGI, object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3E07230", Offset = "0x3E05C30", VA = "0x183E07230")]
	public bool AAGAMFHOOMJ(object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BB80", Offset = "0x3F9A580", VA = "0x183F9BB80")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5097510", Offset = "0x5095F10", VA = "0x185097510")]
	public bool FJHIBPMOMDE(object OEELDHBFFAF, [Out] T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x50989B0", Offset = "0x50973B0", VA = "0x1850989B0")]
	[OKKPIGINHED("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FLBELJFCDKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3E07AA0", Offset = "0x3E064A0", VA = "0x183E07AA0")]
	public BCJFGAIKODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class FKBHKHOFIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly string FODDJLKPGNI;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public FKBHKHOFIEC(string FODDJLKPGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6C696C0", Offset = "0x6C680C0", VA = "0x186C696C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class CIFJECHLBBL<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private List<WeakReference<T>>? KINLEBNGJBE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JKJGGPJDJKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x54D50B0", Offset = "0x54D3AB0", VA = "0x1854D50B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54D51D0", Offset = "0x54D3BD0", VA = "0x1854D51D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x54D5510", Offset = "0x54D3F10", VA = "0x1854D5510")]
	public void KDCHLCHLBCK(T OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54D5370", Offset = "0x54D3D70", VA = "0x1854D5370")]
	public void GDFNAHCIADO(T OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x54D5780", Offset = "0x54D4180", VA = "0x1854D5780")]
	public void PEIPIMGGMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x54D57C0", Offset = "0x54D41C0", VA = "0x1854D57C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public CIFJECHLBBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class BPHDEBBNLNL
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6B70", Offset = "0x2AF5570", VA = "0x182AF6B70")]
	public static void OHHHFNECKHG<T>(this List<T> GLCCIANLCJC, int ENMILGHAHOM) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class MGCBBGMNPGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<object, float> BHMPBJAIPDE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float OEMBAHOCBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E20", Offset = "0x9B2820", VA = "0x1809B3E20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9B4320", Offset = "0x9B2D20", VA = "0x1809B4320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A3F0", Offset = "0x6C68DF0", VA = "0x186C6A3F0")]
	public void FALBPNDCFJG(float IPHMAHBENGI, object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A250", Offset = "0x6C68C50", VA = "0x186C6A250")]
	public void AAGAMFHOOMJ(object OEELDHBFFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A460", Offset = "0x6C68E60", VA = "0x186C6A460")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A2C0", Offset = "0x6C68CC0", VA = "0x186C6A2C0")]
	private void CMKDCFBLHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6A4B0", Offset = "0x6C68EB0", VA = "0x186C6A4B0")]
	public MGCBBGMNPGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface EJPHPAFHCLP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ECJGDNNMOKO KIJKLDICDMC;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class COMLPPJJGPO : EJPHPAFHCLP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct FMJMEKPIHLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float MIKAPCLAFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly float OLCHHCBEFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal readonly bool DDBKACNOMBL;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float BKOAINILKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6C69710", Offset = "0x6C68110", VA = "0x186C69710")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C69880", Offset = "0x6C68280", VA = "0x186C69880")]
		public FMJMEKPIHLA(float ICLEKBDIINO, float BCIIGBDEKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C69720", Offset = "0x6C68120", VA = "0x186C69720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class AIOOCPMFLBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public COMLPPJJGPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AIOOCPMFLBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6C67E40", Offset = "0x6C66840", VA = "0x186C67E40")]
		internal void DJDDPDDPCCP(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int PAODLCPDLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int CNANBGBOENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly EJPHPAFHCLP[] MMPFKIHAHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly ECJGDNNMOKO[] HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly FMJMEKPIHLA[] BGIJDLGOHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private FMJMEKPIHLA BMHNPAODIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NELNHAFDEJH DADCEMCMJOH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ECJGDNNMOKO KIJKLDICDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C68B70", Offset = "0x6C67570", VA = "0x186C68B70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6C69240", Offset = "0x6C67C40", VA = "0x186C69240", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C69300", Offset = "0x6C67D00", VA = "0x186C69300")]
	public COMLPPJJGPO(int PAODLCPDLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C691B0", Offset = "0x6C67BB0", VA = "0x186C691B0")]
	public NELNHAFDEJH ICLLGMAIFKA(FMJMEKPIHLA KFMCFDFMFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C68D40", Offset = "0x6C67740", VA = "0x186C68D40")]
	public void FDDLKCJJLIJ(EJPHPAFHCLP NFGHDHLABHL, [Optional] FMJMEKPIHLA CDMGNADLJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C68C30", Offset = "0x6C67630", VA = "0x186C68C30", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void ECJGDNNMOKO(float JMOFNDHPCFH);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ABDECFFNDGO
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class FCIDJLPEBMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly EJPHPAFHCLP PDINEGEMHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly ECJGDNNMOKO AGMLFHLAIFJ;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6C69500", Offset = "0x6C67F00", VA = "0x186C69500")]
		public FCIDJLPEBMO(EJPHPAFHCLP PDINEGEMHBA, ECJGDNNMOKO AGMLFHLAIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6C694B0", Offset = "0x6C67EB0", VA = "0x186C694B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6C67DD0", Offset = "0x6C667D0", VA = "0x186C67DD0")]
	internal static bool LKOJHLMFLKA(float KPNKONMDFPM, float NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6C57E20", Offset = "0x6C56820", VA = "0x186C57E20")]
	internal static float IJIOOCNNAOK(float KPNKONMDFPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6C67D10", Offset = "0x6C66710", VA = "0x186C67D10")]
	public static IDisposable BANJDGFLAGP(this EJPHPAFHCLP PDINEGEMHBA, ECJGDNNMOKO AGMLFHLAIFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NELNHAFDEJH : EJPHPAFHCLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private float JMOFNDHPCFH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float ANKPPKNDGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6C6A5E0", Offset = "0x6C68FE0", VA = "0x186C6A5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ECJGDNNMOKO? KIJKLDICDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6C6A540", Offset = "0x6C68F40", VA = "0x186C6A540", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6C6A6D0", Offset = "0x6C690D0", VA = "0x186C6A6D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public NELNHAFDEJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface MEDGEHCLJHG<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BGCEMMJMFPN<T> DJJCLMNJKEF([Out] T IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODPBLJHKGDP();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class BIFJDJNEKIL<T> : MEDGEHCLJHG<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ConcurrentStack<T> ALMMEKPIJNH;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x50C23C0", Offset = "0x50C0DC0", VA = "0x1850C23C0", Slot = "4")]
	public BGCEMMJMFPN<T> DJJCLMNJKEF([Out] T IPHMAHBENGI)
	{
		return default(BGCEMMJMFPN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x50C2340", Offset = "0x50C0D40", VA = "0x1850C2340")]
	public void CADFCIHNIMB(T LIALNENBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3EDEFE0", Offset = "0x3EDD9E0", VA = "0x183EDEFE0", Slot = "5")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	protected virtual void GALNMKDGFEN(T EOHEBOJDMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x50C2460", Offset = "0x50C0E60", VA = "0x1850C2460")]
	private T GJMIFHLLDMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x50C2500", Offset = "0x50C0F00", VA = "0x1850C2500")]
	public BIFJDJNEKIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct BGCEMMJMFPN<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly T LIALNENBCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly BIFJDJNEKIL<T> HMIMBMEPECC;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
	internal BGCEMMJMFPN(T IPHMAHBENGI, BIFJDJNEKIL<T> HMIMBMEPECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x50AD6F0", Offset = "0x50AC0F0", VA = "0x1850AD6F0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class HKPOPACCKKD : BIFJDJNEKIL<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly HKPOPACCKKD GHBFIIGNNDE;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C69B20", Offset = "0x6C68520", VA = "0x186C69B20")]
	public static BGCEMMJMFPN<StringBuilder> GJMIFHLLDMF([Out] StringBuilder IPHMAHBENGI)
	{
		return default(BGCEMMJMFPN<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C69B00", Offset = "0x6C68500", VA = "0x186C69B00", Slot = "6")]
	protected override void GALNMKDGFEN(StringBuilder EOHEBOJDMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C69C50", Offset = "0x6C68650", VA = "0x186C69C50")]
	public HKPOPACCKKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class CJCHMGCEJIP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x66DA900", Offset = "0x66D9300", VA = "0x1866DA900")]
	public CJCHMGCEJIP(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class MHBIOKCOBCK<TKey, TValue> : CBDKJBLJGPP<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, AJGCCKCCIGH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class APIBEDHGIIE : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public MHBIOKCOBCK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x12AA330", Offset = "0x12A8D30", VA = "0x1812AA330", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41A7080", Offset = "0x41A5A80", VA = "0x1841A7080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public APIBEDHGIIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C14100", Offset = "0x3C12B00", VA = "0x183C14100", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x41A6450", Offset = "0x41A4E50", VA = "0x1841A6450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x41A6360", Offset = "0x41A4D60", VA = "0x1841A6360")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x41A6270", Offset = "0x41A4C70", VA = "0x1841A6270")]
		private void EEFNKGAPPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x41A7030", Offset = "0x41A5A30", VA = "0x1841A7030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CBDKJBLJGPP<TKey, TValue> IEIJHCMOBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IDictionary<TKey, TValue> FFOILJJPHBI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4698810", Offset = "0x4697210", VA = "0x184698810", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MEAEOHJNNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x46989B0", Offset = "0x46973B0", VA = "0x1846989B0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4698CC0", Offset = "0x46976C0", VA = "0x184698CC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> HMCGKPKIHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4698A40", Offset = "0x4697440", VA = "0x184698A40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> AMANFBLOFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4698B60", Offset = "0x4697560", VA = "0x184698B60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4698680", Offset = "0x4697080", VA = "0x184698680")]
	public MHBIOKCOBCK(CBDKJBLJGPP<TKey, TValue> IEIJHCMOBAD, [Optional] IDictionary<TKey, TValue>? FFOILJJPHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4696360", Offset = "0x4694D60", VA = "0x184696360", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4696C20", Offset = "0x4695620", VA = "0x184696C20")]
	public void EEACKNCBIME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4695CF0", Offset = "0x46946F0", VA = "0x184695CF0", Slot = "9")]
	public void Add(TKey COMNIKKFEEB, TValue IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x46975A0", Offset = "0x4695FA0", VA = "0x1846975A0")]
	public void HJCDADMOLGK(TKey COMNIKKFEEB, TValue IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4696D40", Offset = "0x4695740", VA = "0x184696D40")]
	public void ELONIGPBLEA(TKey COMNIKKFEEB, TValue IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4696ED0", Offset = "0x46958D0", VA = "0x184696ED0")]
	public void EMAPNBDJKFF(TKey COMNIKKFEEB, TValue IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4696270", Offset = "0x4694C70", VA = "0x184696270")]
	public void CHCLJCAGHDL(TKey COMNIKKFEEB, TValue IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4697D00", Offset = "0x4696700", VA = "0x184697D00", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4697D50", Offset = "0x4696750", VA = "0x184697D50", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4698250", Offset = "0x4696C50", VA = "0x184698250", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x46964A0", Offset = "0x4694EA0", VA = "0x1846964A0", Slot = "8")]
	public bool ContainsKey(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x46979A0", Offset = "0x46963A0", VA = "0x1846979A0")]
	public bool MKMMAOILCOG(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4697730", Offset = "0x4696130", VA = "0x184697730")]
	public bool JAMPDHFKGNL(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4697A60", Offset = "0x4696460", VA = "0x184697A60", Slot = "10")]
	public bool Remove(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x46984E0", Offset = "0x4696EE0", VA = "0x1846984E0", Slot = "11")]
	public bool TryGetValue(TKey COMNIKKFEEB, [Out] TValue IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x46967A0", Offset = "0x46951A0", VA = "0x1846967A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] FEMJEOMOEIN, int CFALBIKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4395090", Offset = "0x4393A90", VA = "0x184395090", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4697420", Offset = "0x4695E20", VA = "0x184697420", Slot = "19")]
	[IteratorStateMachine(typeof(MHBIOKCOBCK<, >.APIBEDHGIIE))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4697850", Offset = "0x4696250", VA = "0x184697850", Slot = "21")]
	public bool JNLHCKDEICK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4695A10", Offset = "0x4694410", VA = "0x184695A10")]
	private TValue AEFEGMPHMGP(TKey COMNIKKFEEB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface AJGCCKCCIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JNLHCKDEICK();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface CBDKJBLJGPP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AJGCCKCCIGH
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public sealed class HJCAPPCGINM<TKey, TVal> : CBDKJBLJGPP<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AJGCCKCCIGH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate int IHBDOEDMNMF(TKey COMNIKKFEEB, TVal IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void EONCGGPHFFD(TKey COMNIKKFEEB, TVal IPHMAHBENGI, DCDNMCMJAEH NOJDLJBPIDL);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class GMGPICGDOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey NJIIHIBALEA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9F9DB0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal ADJCIFCGLHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9BE080", Offset = "0x9BCA80", VA = "0x1809BE080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int BKOAINILKFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8C4080", Offset = "0x8C2A80", VA = "0x1808C4080")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8C3670", Offset = "0x8C2070", VA = "0x1808C3670")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset ACJNFCAFGBD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xE73910", Offset = "0xE72310", VA = "0x180E73910")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1861280", Offset = "0x185FC80", VA = "0x181861280")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0EB0", Offset = "0x3EDF8B0", VA = "0x183EE0EB0")]
		public GMGPICGDOHJ(TKey COMNIKKFEEB, TVal POCLHBJGKBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class NKNFPNHOEHJ : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HJCAPPCGINM<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LinkedList<GMGPICGDOHJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x12AA330", Offset = "0x12A8D30", VA = "0x1812AA330", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x47F3370", Offset = "0x47F1D70", VA = "0x1847F3370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x891320", Offset = "0x88FD20", VA = "0x180891320")]
		[DebuggerHidden]
		public NKNFPNHOEHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C0EED0", Offset = "0x3C0D8D0", VA = "0x183C0EED0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x47F0DE0", Offset = "0x47EF7E0", VA = "0x1847F0DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x47F0A50", Offset = "0x47EF450", VA = "0x1847F0A50")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x47F3050", Offset = "0x47F1A50", VA = "0x1847F3050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int ILENKKLPCLD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<TKey, LinkedListNode<GMGPICGDOHJ>> EKCBANNELMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LinkedList<GMGPICGDOHJ> ILEIPJNADDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly IHBDOEDMNMF? MJHNMBPKPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly TimeSpan FNNKBLMAFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly EONCGGPHFFD? LIHKFIBGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly DHHDDNBKGKJ AFDBGJPPJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool FFKJAJCHNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<TKey> FHKNPPIAAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<TVal> BLGCDHJLEHG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OAKGABBNEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x893070", Offset = "0x891A70", VA = "0x180893070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int BIAGHNHANHG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x90FDC0", Offset = "0x90E7C0", VA = "0x18090FDC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x90FA60", Offset = "0x90E460", VA = "0x18090FA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3FBE2F0", Offset = "0x3FBCCF0", VA = "0x183FBE2F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int FLFLJECHPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3F9BB80", Offset = "0x3F9A580", VA = "0x183F9BB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> AMANFBLOFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3FBE470", Offset = "0x3FBCE70", VA = "0x183FBE470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.EDNOJFFIHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3FB82C0", Offset = "0x3FB6CC0", VA = "0x183FB82C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool MEAEOHJNNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3FBE420", Offset = "0x3FBCE20", VA = "0x183FBE420", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3FBE500", Offset = "0x3FBCF00", VA = "0x183FBE500", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3FAE2D0", Offset = "0x3FACCD0", VA = "0x183FAE2D0")]
	private bool JDPCIKPBIGF(int PAODLCPDLEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3FAE3C0", Offset = "0x3FACDC0", VA = "0x183FAE3C0")]
	private void LDIOKJBKNKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC450", Offset = "0x3FBAE50", VA = "0x183FBC450")]
	public HJCAPPCGINM(int PAODLCPDLEP, [Optional] IHBDOEDMNMF? MJHNMBPKPFH, [Optional] IEqualityComparer<TKey>? GIPPNLIFIAH, [Optional] EONCGGPHFFD? LIHKFIBGFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3FB93C0", Offset = "0x3FB7DC0", VA = "0x183FB93C0")]
	public HJCAPPCGINM(TimeSpan FNNKBLMAFFE, [Optional] IEqualityComparer<TKey>? GIPPNLIFIAH, [Optional] EONCGGPHFFD? LIHKFIBGFGB, [Optional] DHHDDNBKGKJ? AFDBGJPPJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3FB9340", Offset = "0x3FB7D40", VA = "0x183FB9340")]
	public HJCAPPCGINM(int PAODLCPDLEP, TimeSpan FNNKBLMAFFE, [Optional] IEqualityComparer<TKey>? GIPPNLIFIAH, [Optional] EONCGGPHFFD? LIHKFIBGFGB, [Optional] DHHDDNBKGKJ? AFDBGJPPJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC530", Offset = "0x3FBAF30", VA = "0x183FBC530")]
	public HJCAPPCGINM(int PAODLCPDLEP, IHBDOEDMNMF? MJHNMBPKPFH, TimeSpan FNNKBLMAFFE, [Optional] IEqualityComparer<TKey>? GIPPNLIFIAH, [Optional] EONCGGPHFFD? LIHKFIBGFGB, [Optional] DHHDDNBKGKJ? AFDBGJPPJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3FAE320", Offset = "0x3FACD20", VA = "0x183FAE320", Slot = "21")]
	public bool JNLHCKDEICK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3FACCD0", Offset = "0x3FAB6D0", VA = "0x183FACCD0", Slot = "22")]
	public bool HDJEACPIJAC(int ECFPAOHDFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1A60", Offset = "0x3FA0460", VA = "0x183FA1A60")]
	private bool CCMCIBNFANB(int ECFPAOHDFEB, DCDNMCMJAEH NOJDLJBPIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3FB1350", Offset = "0x3FAFD50", VA = "0x183FB1350")]
	public void ODIPBPJKHHK(TKey COMNIKKFEEB, TVal IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3F9C8D0", Offset = "0x3F9B2D0", VA = "0x183F9C8D0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3F9C630", Offset = "0x3F9B030", VA = "0x183F9C630", Slot = "9")]
	public void Add(TKey COMNIKKFEEB, TVal IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA4D40", Offset = "0x3FA3740", VA = "0x183FA4D40", Slot = "8")]
	public bool ContainsKey(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3FB7590", Offset = "0x3FB5F90", VA = "0x183FB7590", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3FB71B0", Offset = "0x3FB5BB0", VA = "0x183FB71B0", Slot = "10")]
	public bool Remove(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3FB7E00", Offset = "0x3FB6800", VA = "0x183FB7E00", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3FAD600", Offset = "0x3FAC000", VA = "0x183FAD600")]
	private bool HLBJLKCMCID(TKey COMNIKKFEEB, [Out] TVal IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3FAB840", Offset = "0x3FAA240", VA = "0x183FAB840")]
	private TVal GJMIFHLLDMF(TKey LOHNBJHDMGO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3FB9140", Offset = "0x3FB7B40", VA = "0x183FB9140", Slot = "11")]
	public bool TryGetValue(TKey LOHNBJHDMGO, [Out] TVal IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3FA4A00", Offset = "0x3FA3400", VA = "0x183FA4A00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3FA5110", Offset = "0x3FA3B10", VA = "0x183FA5110", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FEMJEOMOEIN, int CFALBIKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3FB0E50", Offset = "0x3FAF850", VA = "0x183FB0E50")]
	private void NICGICBLEOO(TKey COMNIKKFEEB, TVal POCLHBJGKBH, DCDNMCMJAEH NOJDLJBPIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3FAFCC0", Offset = "0x3FAE6C0", VA = "0x183FAFCC0")]
	private bool LPNNFPENJKE(GMGPICGDOHJ GBKLLLIPPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3FB31C0", Offset = "0x3FB1BC0", VA = "0x183FB31C0")]
	private void PFJHGDEIGND(LinkedListNode<GMGPICGDOHJ> IFEIIEEALOL, TVal HELFJHKDFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8A50", Offset = "0x3FA7450", VA = "0x183FA8A50")]
	private void FALBPNDCFJG(TKey COMNIKKFEEB, TVal IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3F9DF30", Offset = "0x3F9C930", VA = "0x183F9DF30")]
	private void BJNKCCHPHIO(GMGPICGDOHJ GBKLLLIPPEB, TVal HELFJHKDFKA, int JGGDILEBCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3FAC120", Offset = "0x3FAAB20", VA = "0x183FAC120", Slot = "19")]
	[IteratorStateMachine(typeof(HJCAPPCGINM<, >.NKNFPNHOEHJ))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3FB8310", Offset = "0x3FB6D10", VA = "0x183FB8310", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum DCDNMCMJAEH : byte
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
public class DBBIGODDAMP<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly TKey CFKKKNJGLIP;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5A70340", Offset = "0x5A6ED40", VA = "0x185A70340")]
	public DBBIGODDAMP(TKey GDKOACMLFFE, Exception DEHBLLKHAIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CHOCPGJCGAJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3140", Offset = "0x5FB1B40", VA = "0x185FB3140")]
	public CHOCPGJCGAJ(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class FCBLFPACJGL<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GCKAPJMDFDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FCBLFPACJGL<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public GCKAPJMDFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2BD0", Offset = "0x3EC15D0", VA = "0x183EC2BD0")]
		internal Task<TResource> OHOHDKLBFKD(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct NPKIGGIALGL : IAsyncStateMachine
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
		public FCBLFPACJGL<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x47FCD50", Offset = "0x47FB750", VA = "0x1847FCD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x47FD030", Offset = "0x47FBA30", VA = "0x1847FD030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct FFNOOPBAKAJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x3DEFA10", Offset = "0x3DEE410", VA = "0x183DEFA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3DF07B0", Offset = "0x3DEF1B0", VA = "0x183DF07B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly HLMEOFMHDLN<TId, Task<TResource>> NBOHHOODHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> JIFGLKJOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? OMKENJLCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Action<TResource>? AOEAIMGGPLK;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF160", Offset = "0x3DDDB60", VA = "0x183DDF160")]
	public FCBLFPACJGL(int BAMIDGGKEFN = 0, [Optional] IEqualityComparer<TId>? IBEEOKGPBAF, [Optional] Func<TId, CancellationToken, Task<TResource>>? OKEKDBIOKPE, [Optional] Action<TResource>? AELIKDLMHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE7E0", Offset = "0x3DDD1E0", VA = "0x183DDE7E0")]
	public JOELGMAPIIB<Task<TResource>> HGDOPKCICEN(TId DNICIAANFHD, [Optional] Func<TId, CancellationToken, Task<TResource>>? OKEKDBIOKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE010", Offset = "0x3DDCA10", VA = "0x183DDE010")]
	private void EHACANLJJKL(Task<TResource> DJIALEEMCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEB90", Offset = "0x3DDD590", VA = "0x183DDEB90")]
	[AsyncStateMachine(typeof(FCBLFPACJGL<, >.NPKIGGIALGL))]
	private Task PMGJGLGJGIF(Task<TResource> DJIALEEMCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE9C0", Offset = "0x3DDD3C0", VA = "0x183DDE9C0")]
	public void NBDCFPALFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEA20", Offset = "0x3DDD420", VA = "0x183DDEA20")]
	public HLMEOFMHDLN<TId, Task<TResource>>.AEDHDDFFGFP PBHEMGCNMMA()
	{
		return default(HLMEOFMHDLN<TId, Task<TResource>>.AEDHDDFFGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEF90", Offset = "0x3DDD990", VA = "0x183DDEF90", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEF90", Offset = "0x3DDD990", VA = "0x183DDEF90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD910", Offset = "0x3DDC310", VA = "0x183DDD910")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(FCBLFPACJGL<, >.FFNOOPBAKAJ))]
	internal static Task BAILFNNKCFJ(Task<TResource> DJIALEEMCOO, CancellationTokenSource BIAMEFLNKAL, Dictionary<Task<TResource>, CancellationTokenSource> DKBJDHBMAHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class HLMEOFMHDLN<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class PHNJIJFBFIP : IEquatable<PHNJIJFBFIP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TValue ADJCIFCGLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int ECLAIHGLBKB;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xB93990", Offset = "0xB92390", VA = "0x180B93990")]
		public PHNJIJFBFIP(TValue IPHMAHBENGI, int MDNDNCGPCPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x49A9670", Offset = "0x49A8070", VA = "0x1849A9670", Slot = "4")]
		public bool Equals(PHNJIJFBFIP? CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x49A9700", Offset = "0x49A8100", VA = "0x1849A9700", Slot = "0")]
		public override bool Equals(object? FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x49A9830", Offset = "0x49A8230", VA = "0x1849A9830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct AEDHDDFFGFP : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<TKey, PHNJIJFBFIP>.Enumerator LFKIJGCPHNA;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x3E83AE0", Offset = "0x3E824E0", VA = "0x183E83AE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x3E83F10", Offset = "0x3E82910", VA = "0x183E83F10", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3E83C50", Offset = "0x3E82650", VA = "0x183E83C50")]
		public AEDHDDFFGFP(HLMEOFMHDLN<TKey, TValue> BHMPBJAIPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E835F0", Offset = "0x3E81FF0", VA = "0x183E835F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E83670", Offset = "0x3E82070", VA = "0x183E83670", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E83790", Offset = "0x3E82190", VA = "0x183E83790", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class PAOMCLEMIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HLMEOFMHDLN<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public PHNJIJFBFIP refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PAOMCLEMIDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4998150", Offset = "0x4996B50", VA = "0x184998150")]
		internal void OHOHDKLBFKD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Dictionary<TKey, PHNJIJFBFIP> DENKAGLIDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly Func<TKey, TValue>? GLHKGFHKKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Action<TValue>? ADMNEFCMBJB;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3FC98A0", Offset = "0x3FC82A0", VA = "0x183FC98A0")]
	public HLMEOFMHDLN(int BAMIDGGKEFN = 0, [Optional] IEqualityComparer<TKey>? GIPPNLIFIAH, [Optional] Func<TKey, TValue>? NMIDAGLJBEH, [Optional] Action<TValue>? DAHGCALGNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3FC8940", Offset = "0x3FC7340", VA = "0x183FC8940")]
	public JOELGMAPIIB<TValue> HGDOPKCICEN(TKey COMNIKKFEEB, [Optional] Func<TKey, TValue>? BPIAIJAHBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3FC80C0", Offset = "0x3FC6AC0", VA = "0x183FC80C0")]
	private void CADFCIHNIMB(TKey COMNIKKFEEB, PHNJIJFBFIP LIPHKMOGJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3FC8F90", Offset = "0x3FC7990", VA = "0x183FC8F90")]
	public void NBDCFPALFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3FC9690", Offset = "0x3FC8090", VA = "0x183FC9690")]
	public AEDHDDFFGFP PBHEMGCNMMA()
	{
		return default(AEDHDDFFGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3FC96D0", Offset = "0x3FC80D0", VA = "0x183FC96D0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3FC96D0", Offset = "0x3FC80D0", VA = "0x183FC96D0", Slot = "5")]
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
