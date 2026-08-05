using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x61F7EF0", Offset = "0x61F70F0", VA = "0x1861F7EF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ICICILDBMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	protected ICICILDBMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DNKACAIDPJG<T> : ICICILDBMEN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct NNHODPMLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum AINNEOKIPPG
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
		public AINNEOKIPPG DMEGHACCPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T CEBHNDLCHED;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int BOIPLIIHDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool PHDHKNFIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool HDJEDBDPKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? HPBMHHDIEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<NNHODPMLLIH>? FGDHFJJNKBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EPFNDPMOOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x508B560", Offset = "0x508A760", VA = "0x18508B560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x508BA40", Offset = "0x508AC40", VA = "0x18508BA40")]
	protected DNKACAIDPJG(bool HDJEDBDPKED, bool PHDHKNFIFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x508B160", Offset = "0x508A360", VA = "0x18508B160")]
	protected bool BFOOAKBLBLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x508B5B0", Offset = "0x508A7B0", VA = "0x18508B5B0")]
	protected void OBKKFCCJBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x508B380", Offset = "0x508A580", VA = "0x18508B380")]
	protected void KAHJCDODNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22D6240", Offset = "0x22D5440", VA = "0x1822D6240")]
	private static void MDKJIEHMHBM<U>(List<U>? MJCNKJMKHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x508B6B0", Offset = "0x508A8B0", VA = "0x18508B6B0", Slot = "4")]
	public void OJOKKDMOJFN(T CEBHNDLCHED, bool OJDAIFBJBBN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x508B890", Offset = "0x508AA90", VA = "0x18508B890", Slot = "5")]
	public void PADFOOPDKDB(T CEBHNDLCHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x508B200", Offset = "0x508A400", VA = "0x18508B200")]
	public void IICCKONGNNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HFDOKIDNKKA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJOKKDMOJFN(Action CEBHNDLCHED, bool OJDAIFBJBBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PADFOOPDKDB(Action CEBHNDLCHED);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DIKKIJJDOON : DNKACAIDPJG<Action>, HFDOKIDNKKA
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61F6750", Offset = "0x61F5950", VA = "0x1861F6750")]
	public DIKKIJJDOON(bool HDJEDBDPKED = false, bool PHDHKNFIFGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61F6490", Offset = "0x61F5690", VA = "0x1861F6490")]
	public void DIOOPMGFNAE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61F66F0", Offset = "0x61F58F0", VA = "0x1861F66F0")]
	public static DIKKIJJDOON JACEKEKEPIE(DIKKIJJDOON OBBMMENJDIL, Action CEBHNDLCHED)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61F6690", Offset = "0x61F5890", VA = "0x1861F6690")]
	public static DIKKIJJDOON GFMPBDJLCFM(DIKKIJJDOON OBBMMENJDIL, Action CEBHNDLCHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JLMPAFJIBMD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJOKKDMOJFN(Action<T> CEBHNDLCHED, bool OJDAIFBJBBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PADFOOPDKDB(Action<T> CEBHNDLCHED);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class APOAGECOPGB<T> : DNKACAIDPJG<Action<T>>, JLMPAFJIBMD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32B5530", Offset = "0x32B4730", VA = "0x1832B5530")]
	public APOAGECOPGB(bool HDJEDBDPKED = false, bool PHDHKNFIFGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37B8930", Offset = "0x37B7B30", VA = "0x1837B8930")]
	public void DIOOPMGFNAE(T LFCIAEJOMBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32B54A0", Offset = "0x32B46A0", VA = "0x1832B54A0")]
	public static APOAGECOPGB<T> JACEKEKEPIE(APOAGECOPGB<T> OBBMMENJDIL, Action<T> CEBHNDLCHED)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32B5410", Offset = "0x32B4610", VA = "0x1832B5410")]
	public static APOAGECOPGB<T> GFMPBDJLCFM(APOAGECOPGB<T> OBBMMENJDIL, Action<T> CEBHNDLCHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JNHEMPJILPN<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KIDGADDAONM<T, U> : DNKACAIDPJG<Action<T, U>>, JNHEMPJILPN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32B5530", Offset = "0x32B4730", VA = "0x1832B5530")]
	public KIDGADDAONM(bool HDJEDBDPKED = false, bool PHDHKNFIFGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B66420", Offset = "0x3B65620", VA = "0x183B66420")]
	public void DIOOPMGFNAE(T LFCIAEJOMBP, U DNEKIBBOEFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32B54A0", Offset = "0x32B46A0", VA = "0x1832B54A0")]
	public static KIDGADDAONM<T, U> JACEKEKEPIE(KIDGADDAONM<T, U> OBBMMENJDIL, Action<T, U> CEBHNDLCHED)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32B5410", Offset = "0x32B4610", VA = "0x1832B5410")]
	public static KIDGADDAONM<T, U> GFMPBDJLCFM(KIDGADDAONM<T, U> OBBMMENJDIL, Action<T, U> CEBHNDLCHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HHNANIHJCKD<T, U, V> : DNKACAIDPJG<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32B5530", Offset = "0x32B4730", VA = "0x1832B5530")]
	public HHNANIHJCKD(bool HDJEDBDPKED = false, bool PHDHKNFIFGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37F0EE0", Offset = "0x37F00E0", VA = "0x1837F0EE0")]
	public void DIOOPMGFNAE(T LFCIAEJOMBP, U DNEKIBBOEFH, V NGEKMKMEBJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32B54A0", Offset = "0x32B46A0", VA = "0x1832B54A0")]
	public static HHNANIHJCKD<T, U, V> JACEKEKEPIE(HHNANIHJCKD<T, U, V> OBBMMENJDIL, Action<T, U, V> CEBHNDLCHED)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x32B5410", Offset = "0x32B4610", VA = "0x1832B5410")]
	public static HHNANIHJCKD<T, U, V> GFMPBDJLCFM(HHNANIHJCKD<T, U, V> OBBMMENJDIL, Action<T, U, V> CEBHNDLCHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CMKONMECFAD<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class BKNLFLIAFAG<T, U, V, W> : DNKACAIDPJG<Action<T, U, V, W>>, CMKONMECFAD<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32B5530", Offset = "0x32B4730", VA = "0x1832B5530")]
	public BKNLFLIAFAG(bool HDJEDBDPKED = false, bool PHDHKNFIFGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x47B09B0", Offset = "0x47AFBB0", VA = "0x1847B09B0")]
	public void DIOOPMGFNAE(T LFCIAEJOMBP, U DNEKIBBOEFH, V NGEKMKMEBJI, W MBCBCOEONAH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32B54A0", Offset = "0x32B46A0", VA = "0x1832B54A0")]
	public static BKNLFLIAFAG<T, U, V, W> JACEKEKEPIE(BKNLFLIAFAG<T, U, V, W> OBBMMENJDIL, Action<T, U, V, W> CEBHNDLCHED)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32B5410", Offset = "0x32B4610", VA = "0x1832B5410")]
	public static BKNLFLIAFAG<T, U, V, W> GFMPBDJLCFM(BKNLFLIAFAG<T, U, V, W> OBBMMENJDIL, Action<T, U, V, W> CEBHNDLCHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class EGOBFFJFPLH<T, U, V, W, X> : DNKACAIDPJG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32B5530", Offset = "0x32B4730", VA = "0x1832B5530")]
	public EGOBFFJFPLH(bool HDJEDBDPKED = false, bool PHDHKNFIFGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x32B4BF0", Offset = "0x32B3DF0", VA = "0x1832B4BF0")]
	public void DIOOPMGFNAE(T LFCIAEJOMBP, U DNEKIBBOEFH, V NGEKMKMEBJI, W MBCBCOEONAH, X DHOHKCEOCND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32B54A0", Offset = "0x32B46A0", VA = "0x1832B54A0")]
	public static EGOBFFJFPLH<T, U, V, W, X> JACEKEKEPIE(EGOBFFJFPLH<T, U, V, W, X> OBBMMENJDIL, Action<T, U, V, W, X> CEBHNDLCHED)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32B5410", Offset = "0x32B4610", VA = "0x1832B5410")]
	public static EGOBFFJFPLH<T, U, V, W, X> GFMPBDJLCFM(EGOBFFJFPLH<T, U, V, W, X> OBBMMENJDIL, Action<T, U, V, W, X> CEBHNDLCHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class AFHLEMDFOLE<T, U, V, W, X, Y> : DNKACAIDPJG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32B5530", Offset = "0x32B4730", VA = "0x1832B5530")]
	public AFHLEMDFOLE(bool HDJEDBDPKED = false, bool PHDHKNFIFGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37A1B70", Offset = "0x37A0D70", VA = "0x1837A1B70")]
	public void DIOOPMGFNAE(T LFCIAEJOMBP, U DNEKIBBOEFH, V NGEKMKMEBJI, W MBCBCOEONAH, X DHOHKCEOCND, Y CKNDNFKDDJC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32B54A0", Offset = "0x32B46A0", VA = "0x1832B54A0")]
	public static AFHLEMDFOLE<T, U, V, W, X, Y> JACEKEKEPIE(AFHLEMDFOLE<T, U, V, W, X, Y> OBBMMENJDIL, Action<T, U, V, W, X, Y> CEBHNDLCHED)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x32B5410", Offset = "0x32B4610", VA = "0x1832B5410")]
	public static AFHLEMDFOLE<T, U, V, W, X, Y> GFMPBDJLCFM(AFHLEMDFOLE<T, U, V, W, X, Y> OBBMMENJDIL, Action<T, U, V, W, X, Y> CEBHNDLCHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HDPINPBBHFN<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NACLCEEHGAO<TKey, TVal> PNAJJLOGLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> ELLHOFMPGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int KJIHOONNPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NACLCEEHGAO<TKey, TVal>.DHGKFEJNONL? NJHJFJMOBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int NJKEDNLGPLF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int FLEPOEGCKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37BFC80", Offset = "0x37BEE80", VA = "0x1837BFC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FONPHGJAKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x37C03B0", Offset = "0x37BF5B0", VA = "0x1837C03B0")]
	public HDPINPBBHFN(int KJIHOONNPJN, [Optional] NACLCEEHGAO<TKey, TVal>.DHGKFEJNONL? NJHJFJMOBNA, [Optional] IEqualityComparer<TKey>? BPPELEFJHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37BFCD0", Offset = "0x37BEED0", VA = "0x1837BFCD0")]
	public void EGCAMDABJKA(TKey HKNPGHOCJDO, TVal AFCGKMGKPEF, bool DKNMFDBNGCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x37C0180", Offset = "0x37BF380", VA = "0x1837C0180")]
	public bool KFCNLJCMPPP(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37BFBA0", Offset = "0x37BEDA0", VA = "0x1837BFBA0")]
	public bool AOAADIOEPBK(TKey IDFJIKJFNIA, [Out] TVal AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37BFF60", Offset = "0x37BF160", VA = "0x1837BFF60")]
	private void JPPDKHAFIEF(TKey HKNPGHOCJDO, TVal AFCGKMGKPEF, int DKMFLNHKFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37C0220", Offset = "0x37BF420", VA = "0x1837C0220")]
	public bool OHFGDCNAABB(TKey HKNPGHOCJDO, TVal AFCGKMGKPEF, bool DKNMFDBNGCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37BFEA0", Offset = "0x37BF0A0", VA = "0x1837BFEA0")]
	private bool GLLCHHHBAJK(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DHEHGHINCNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action LKLHENPLBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool EFEEPOHIPEJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public DHEHGHINCNJ(Action EHGFAKEALPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61F6450", Offset = "0x61F5650", VA = "0x1861F6450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2614FA0", Offset = "0x26141A0", VA = "0x182614FA0")]
	public static ININENKNCEG<T> NAIBINGPDAH<T>(T AFCGKMGKPEF, Action EHGFAKEALPN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ININENKNCEG<T> : DHEHGHINCNJ where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T FMINBKHGIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38B3C40", Offset = "0x38B2E40", VA = "0x1838B3C40")]
	public ININENKNCEG(T AFCGKMGKPEF, Action EHGFAKEALPN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BMEHHGBDHJD : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct CBHMJOPDIFD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0")]
		public static CBHMJOPDIFD GOMGEEBODDD()
		{
			return default(CBHMJOPDIFD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0")]
	public static BMEHHGBDHJD FONJMPBBNDI(Type DMEGHACCPAC, [Optional] string? ONJBACADCDJ, [Optional] string? FNCIEMADMJO, bool LGMIIABAKMI = false)
	{
		return default(BMEHHGBDHJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0")]
	public static BMEHHGBDHJD FONJMPBBNDI<T>([Optional] string? ONJBACADCDJ, [Optional] string? FNCIEMADMJO, bool LGMIIABAKMI = false)
	{
		return default(BMEHHGBDHJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KGHLGOHBMGA
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool NPOBKFNFOFK(string IPPCAIKOPDH, KGHLGOHBMGA BLNEHFKGLEH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int INAFIMGOJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string ACOCJAPJILL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61F76E0", Offset = "0x61F68E0", VA = "0x1861F76E0")]
	public static Dictionary<string, KGHLGOHBMGA> OEHHBOALECG(Type CLOLKCIHPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61F7160", Offset = "0x61F6360", VA = "0x1861F7160")]
	public static Dictionary<string, KGHLGOHBMGA> EMHEIGHHHAN(Type CLOLKCIHPFL, NPOBKFNFOFK GLEECNLHLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x61F7520", Offset = "0x61F6720", VA = "0x1861F7520")]
	public static Dictionary<int, string> JGGHJIOPFNF(Dictionary<string, KGHLGOHBMGA> CGONJAIKCGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class EICMLFAAIEJ : CHOGLKODFOC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool GPNJGKFEDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? LFFABAGLGPG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual CHOGLKODFOC? GDJFFLIKPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61F6E60", Offset = "0x61F6060", VA = "0x1861F6E60")]
	protected EICMLFAAIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string OKCJCMAJCGL();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61F67B0", Offset = "0x61F59B0", VA = "0x1861F67B0", Slot = "8")]
	public virtual string BNICICEJMOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61F6830", Offset = "0x61F5A30", VA = "0x1861F6830", Slot = "9")]
	public void CFDBDMMFHIG(StringBuilder NNIBCGKCOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61F6D60", Offset = "0x61F5F60", VA = "0x1861F6D60", Slot = "10")]
	public void KGBEMDFPALH(StringBuilder NNIBCGKCOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61F6AE0", Offset = "0x61F5CE0", VA = "0x1861F6AE0", Slot = "11")]
	public void CMMHMEBJJIK(StringBuilder NNIBCGKCOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61F6C00", Offset = "0x61F5E00", VA = "0x1861F6C00", Slot = "12")]
	public void JHPHCAHEKDL(StringBuilder NNIBCGKCOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61F6DC0", Offset = "0x61F5FC0", VA = "0x1861F6DC0")]
	public static void MBAOEPNKNDM(StringBuilder NNIBCGKCOAP, string OEPBDPEGDNG, string ALBOBMCFKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x545BE60", Offset = "0x545B060", VA = "0x18545BE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LFFGMCJLCFP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61F7AF0", Offset = "0x61F6CF0", VA = "0x1861F7AF0")]
	public LFFGMCJLCFP(string LFMFEFFGFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DBGOOONJEEO<TErr> : LFFGMCJLCFP where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr CNEEAFJIANN;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5062270", Offset = "0x5061470", VA = "0x185062270")]
	private DBGOOONJEEO([In] TErr BGFNAIIPNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x50621A0", Offset = "0x50613A0", VA = "0x1850621A0")]
	public static DBGOOONJEEO<TErr> GOMGEEBODDD([In] TErr BGFNAIIPNKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CHOGLKODFOC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BNICICEJMOG();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OKCJCMAJCGL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AKGDAMCONIB<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions FMINBKHGIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MNLNJBNBJGH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string OMJPMNIEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EKAPOJFNOJH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61F6ED0", Offset = "0x61F60D0", VA = "0x1861F6ED0")]
	public EKAPOJFNOJH(string LFMFEFFGFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ABAHPBKGMJH<TOk> : EKAPOJFNOJH where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk NKBOMIDEJPL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3705480", Offset = "0x3704680", VA = "0x183705480")]
	private ABAHPBKGMJH([In] TOk APAMFANPBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3705230", Offset = "0x3704430", VA = "0x183705230")]
	public static ABAHPBKGMJH<TOk> GOMGEEBODDD([In] TOk APAMFANPBJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct BLNBDNPDEEM<TOk, TErr> : IEquatable<BLNBDNPDEEM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> JMOECLMLKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr CNEEAFJIANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk NKBOMIDEJPL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PLIMJOFNOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x47B5A90", Offset = "0x47B4C90", VA = "0x1847B5A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FNLAKJPJMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x47B4D60", Offset = "0x47B3F60", VA = "0x1847B4D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47B88C0", Offset = "0x47B7AC0", VA = "0x1847B88C0")]
	internal BLNBDNPDEEM([In] TErr BGFNAIIPNKC, [In] TOk APAMFANPBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x47B3A80", Offset = "0x47B2C80", VA = "0x1847B3A80")]
	public static BLNBDNPDEEM<TOk, TErr> GALEJFEPJBF([In] TErr BGFNAIIPNKC)
	{
		return default(BLNBDNPDEEM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x47B5350", Offset = "0x47B4550", VA = "0x1847B5350")]
	public static BLNBDNPDEEM<TOk, TErr> HEPFNDLKDIM([In] TOk APAMFANPBJF)
	{
		return default(BLNBDNPDEEM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x22B3C60", Offset = "0x22B2E60", VA = "0x1822B3C60")]
	public BLNBDNPDEEM<TOk?, UErr?> ANDADALHEBF<UErr>()
	{
		return default(BLNBDNPDEEM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x22B54B0", Offset = "0x22B46B0", VA = "0x1822B54B0")]
	public BLNBDNPDEEM<UOk?, TErr?> PIOFMJNAFFG<UOk>()
	{
		return default(BLNBDNPDEEM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x22B45C0", Offset = "0x22B37C0", VA = "0x1822B45C0")]
	public BLNBDNPDEEM<UOk?, TErr?> HACMJCILNEG<UOk>()
	{
		return default(BLNBDNPDEEM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x22B4E40", Offset = "0x22B4040", VA = "0x1822B4E40")]
	public BLNBDNPDEEM<TOk?, UErr?> IJAFMBIAMDN<UErr>()
	{
		return default(BLNBDNPDEEM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x47B23B0", Offset = "0x47B15B0", VA = "0x1847B23B0")]
	public BLNBDNPDEEM<PGENBOHGKNI, TErr> DPCMPMMBCJI()
	{
		return default(BLNBDNPDEEM<PGENBOHGKNI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x47B10F0", Offset = "0x47B02F0", VA = "0x1847B10F0")]
	public static bool CDBCKLPENDN([In] BLNBDNPDEEM<TOk, TErr> GNBALBEAIKA, [In] BLNBDNPDEEM<TOk, TErr> ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x47B2B20", Offset = "0x47B1D20", VA = "0x1847B2B20", Slot = "4")]
	public bool Equals(BLNBDNPDEEM<TOk, TErr> NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x47B27F0", Offset = "0x47B19F0", VA = "0x1847B27F0", Slot = "0")]
	public override bool Equals(object NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x47B43D0", Offset = "0x47B35D0", VA = "0x1847B43D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x47B7650", Offset = "0x47B6850", VA = "0x1847B7650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DIBFGHAOFEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct ICJPBAAJLKK<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<BLNBDNPDEEM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<BLNBDNPDEEM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x388AFB0", Offset = "0x388A1B0", VA = "0x18388AFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x388B5F0", Offset = "0x388A7F0", VA = "0x18388B5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26157B0", Offset = "0x26149B0", VA = "0x1826157B0")]
	public static BLNBDNPDEEM<TOk?, TErr?> NKBOMIDEJPL<TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [In] TOk APAMFANPBJF)
	{
		return default(BLNBDNPDEEM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2617AF0", Offset = "0x2616CF0", VA = "0x182617AF0")]
	public static BLNBDNPDEEM<PGENBOHGKNI, TErr?> NKBOMIDEJPL<TErr>([In] this BLNBDNPDEEM<PGENBOHGKNI, TErr> KPBGCHDNDLM)
	{
		return default(BLNBDNPDEEM<PGENBOHGKNI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x26157B0", Offset = "0x26149B0", VA = "0x1826157B0")]
	public static BLNBDNPDEEM<TOk?, TErr?> CNEEAFJIANN<TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [In] TErr BGFNAIIPNKC)
	{
		return default(BLNBDNPDEEM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2615A50", Offset = "0x2614C50", VA = "0x182615A50")]
	public static TOk? EFIOIPBILPJ<TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x26162D0", Offset = "0x26154D0", VA = "0x1826162D0")]
	[AsyncStateMachine(typeof(ICJPBAAJLKK<, >))]
	public static Task<TOk?>? GPKJGBDKLPP<TOk, TErr>(this Task<BLNBDNPDEEM<TOk, TErr>> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x26154A0", Offset = "0x26146A0", VA = "0x1826154A0")]
	public static TErr? BPFHIHGHDMK<TErr, TOk>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2616570", Offset = "0x2615770", VA = "0x182616570")]
	public static bool HKCLHCINBLC<TOk, TErr, UErr, UOk>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [Out] BLNBDNPDEEM<UOk, UErr> DPGOFBMJOBA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2618080", Offset = "0x2617280", VA = "0x182618080")]
	public static bool PDGCHFJGOMI<TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [Out][NotNullWhen(true)] TOk APAMFANPBJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2615930", Offset = "0x2614B30", VA = "0x182615930")]
	public static bool DGOABEMEOIM<TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [Out][NotNullWhen(true)] TErr BGFNAIIPNKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2617900", Offset = "0x2616B00", VA = "0x182617900")]
	public static bool JGINEINPIKG<TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [Out][NotNullWhen(true)] TOk APAMFANPBJF, [Out][NotNullWhen(false)] TErr BGFNAIIPNKC) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26179F0", Offset = "0x2616BF0", VA = "0x1826179F0")]
	public static bool NKBBEPFIIHC<TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [Out][NotNullWhen(true)] TOk APAMFANPBJF, [Out] BLNBDNPDEEM<TOk, TErr> DPGOFBMJOBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26167A0", Offset = "0x26159A0", VA = "0x1826167A0")]
	public static bool HKCLHCINBLC<TOk, TErr, UErr, UOk>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [Out][NotNullWhen(true)] TOk APAMFANPBJF, [Out] BLNBDNPDEEM<UOk, UErr> DPGOFBMJOBA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2615F70", Offset = "0x2615170", VA = "0x182615F70")]
	public static bool EPOEEBKCECL<TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [Out][NotNullWhen(true)] TOk APAMFANPBJF, [Out] BLNBDNPDEEM<PGENBOHGKNI, TErr> DPGOFBMJOBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2617D60", Offset = "0x2616F60", VA = "0x182617D60")]
	public static BLNBDNPDEEM<UOk, UErr> OEMHNIFOANP<UOk, UErr, TOk, TErr>([In] this BLNBDNPDEEM<TOk, TErr> KPBGCHDNDLM, [In] BLNBDNPDEEM<UOk, UErr> BBEDKDLIKBI) where TOk : UOk where TErr : UErr
	{
		return default(BLNBDNPDEEM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26175C0", Offset = "0x26167C0", VA = "0x1826175C0")]
	public static BLNBDNPDEEM<TOk?[]?, TErr?> HPEGDIEGENN<TOk, TErr>(this IEnumerable<BLNBDNPDEEM<TOk, TErr>> KPBGCHDNDLM)
	{
		return default(BLNBDNPDEEM<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class BFKHMPPKNNH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x22B3600", Offset = "0x22B2800", VA = "0x1822B3600")]
	public static BLNBDNPDEEM<TOk, T> NKBOMIDEJPL<TOk>([In] TOk APAMFANPBJF) where TOk : notnull
	{
		return default(BLNBDNPDEEM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4797040", Offset = "0x4796240", VA = "0x184797040")]
	public static BLNBDNPDEEM<PGENBOHGKNI, T> NKBOMIDEJPL()
	{
		return default(BLNBDNPDEEM<PGENBOHGKNI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x22B3600", Offset = "0x22B2800", VA = "0x1822B3600")]
	public static BLNBDNPDEEM<T, TErr> CNEEAFJIANN<TErr>([In] TErr BGFNAIIPNKC) where TErr : notnull
	{
		return default(BLNBDNPDEEM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class ALOEKPHFBNG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct NHGNBIKHNOP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ALOEKPHFBNG<T> JBGGBHLFPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int MFMIBEGKFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool KHCENPMKAED;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1CCACA0", Offset = "0x1CC9EA0", VA = "0x181CCACA0")]
		public NHGNBIKHNOP(ALOEKPHFBNG<T> BFLJLPICFCB, int HDBHHNHEDJG, bool HBNAMEDNGAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3F20A90", Offset = "0x3F1FC90", VA = "0x183F20A90")]
		public ALOEKPHFBNG<T>.EFJPIEGECKA HPMIKEPMPON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3F20B80", Offset = "0x3F1FD80", VA = "0x183F20B80", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3F20B80", Offset = "0x3F1FD80", VA = "0x183F20B80", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class EFJPIEGECKA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly ALOEKPHFBNG<T> JBGGBHLFPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int EEOBHAPFCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int EMGDCPIHNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool KHCENPMKAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool AONCLMLJBKO;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x32B0930", Offset = "0x32AFB30", VA = "0x1832B0930")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x32B0AB0", Offset = "0x32AFCB0", VA = "0x1832B0AB0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x32B0CF0", Offset = "0x32AFEF0", VA = "0x1832B0CF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x32B12F0", Offset = "0x32B04F0", VA = "0x1832B12F0")]
		public EFJPIEGECKA(ALOEKPHFBNG<T> BFLJLPICFCB, int HDBHHNHEDJG, bool HBNAMEDNGAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x32B0970", Offset = "0x32AFB70", VA = "0x1832B0970", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x32B0A00", Offset = "0x32AFC00", VA = "0x1832B0A00", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JDIJGMNOPMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public JDIJGMNOPMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3A71070", Offset = "0x3A70270", VA = "0x183A71070")]
		internal T IFKGGAHJEJL(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] DMCAGDHHGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int EMGDCPIHNDE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KFILPJHHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x37AACF0", Offset = "0x37A9EF0", VA = "0x1837AACF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T DNINAAJGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x360C440", Offset = "0x360B640", VA = "0x18360C440")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T GLDIDDCPOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x37AAAE0", Offset = "0x37A9CE0", VA = "0x1837AAAE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x37AAC90", Offset = "0x37A9E90", VA = "0x1837AAC90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DOKCLGDELIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x16F02C0", Offset = "0x16EF4C0", VA = "0x1816F02C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xFD0300", Offset = "0xFCF500", VA = "0x180FD0300")]
	private static int DPNOEICBLGE(int ILNNGHKJMBD, int NCLKCGHBFFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37AB000", Offset = "0x37AA200", VA = "0x1837AB000")]
	public ALOEKPHFBNG(int DKMFLNHKFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x37AADE0", Offset = "0x37A9FE0", VA = "0x1837AADE0")]
	public ALOEKPHFBNG(int DKMFLNHKFDF, Func<T> LFJIPHFJBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37AB110", Offset = "0x37AA310", VA = "0x1837AB110")]
	public ALOEKPHFBNG(T[] CDNFLDEAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37AA9F0", Offset = "0x37A9BF0", VA = "0x1837AA9F0")]
	public void DKEFMJEOKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37AAA20", Offset = "0x37A9C20", VA = "0x1837AAA20")]
	public IEnumerable<T> GFHFFBOCNDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37AAB10", Offset = "0x37A9D10", VA = "0x1837AAB10")]
	public ALOEKPHFBNG<T>.EFJPIEGECKA HPMIKEPMPON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x36D2AD0", Offset = "0x36D1CD0", VA = "0x1836D2AD0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x36D2AD0", Offset = "0x36D1CD0", VA = "0x1836D2AD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FMPDDOJEDHC
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x274EAC0", Offset = "0x274DCC0", VA = "0x18274EAC0")]
	public static ALOEKPHFBNG<T> GOMGEEBODDD<T>(int DKMFLNHKFDF, Func<T> LFJIPHFJBJB) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3710", Offset = "0x1DB2910", VA = "0x181DB3710")]
		public RRColor(float PGPFOODFIEA, float EGJAEKFCIGO, float LPGCLIAKDPH, float HEFLGIBKJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x61F8040", Offset = "0x61F7240", VA = "0x1861F8040", Slot = "4")]
		public bool Equals(RRColor NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x61F80C0", Offset = "0x61F72C0", VA = "0x1861F80C0", Slot = "0")]
		public override bool Equals(object NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61F81C0", Offset = "0x61F73C0", VA = "0x1861F81C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x61F8240", Offset = "0x61F7440", VA = "0x1861F8240", Slot = "5")]
		public string ToString(string JMLJCJAAPJD, IFormatProvider FJPPDOOHIOC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class FHEJFDNPPBG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct NJKBLBIFOOE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly FHEJFDNPPBG<T> LDPNGKPMFNK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T FMINBKHGIKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3F5DF60", Offset = "0x3F5D160", VA = "0x183F5DF60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F5DF30", Offset = "0x3F5D130", VA = "0x183F5DF30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
		public NJKBLBIFOOE(FHEJFDNPPBG<T> LDPNGKPMFNK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FPLIBNMHMDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<NJKBLBIFOOE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FHEJFDNPPBG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x366EF90", Offset = "0x366E190", VA = "0x18366EF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x30D4150", Offset = "0x30D3350", VA = "0x1830D4150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly SemaphoreSlim BKECGIGDNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T OFGKCHFGFAP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3648C80", Offset = "0x3647E80", VA = "0x183648C80")]
	public FHEJFDNPPBG([In] T OFGKCHFGFAP, int FAHBOOEAGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3648C60", Offset = "0x3647E60", VA = "0x183648C60")]
	public FHEJFDNPPBG([In] T OFGKCHFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x36486C0", Offset = "0x36478C0", VA = "0x1836486C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3648700", Offset = "0x3647900", VA = "0x183648700")]
	public NJKBLBIFOOE EFGNOCNEBAJ()
	{
		return default(NJKBLBIFOOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3648860", Offset = "0x3647A60", VA = "0x183648860")]
	[AsyncStateMachine(typeof(FHEJFDNPPBG<>.FPLIBNMHMDD))]
	public Task<FHEJFDNPPBG<T>.NJKBLBIFOOE> FLLICPKNGKM(CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x36486A0", Offset = "0x36478A0", VA = "0x1836486A0")]
	public void BFJDOEMDHEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class APEBAHIIGDP
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61F5450", Offset = "0x61F4650", VA = "0x1861F5450")]
	public static FHEJFDNPPBG<PGENBOHGKNI> GOMGEEBODDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x263C560", Offset = "0x263B760", VA = "0x18263C560")]
	public static FHEJFDNPPBG<T> GOMGEEBODDD<T>([In] T OFGKCHFGFAP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class OEGPBNECFJE<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct KPEFKJNCDIJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly OEGPBNECFJE<T> FCPBCIHPHHA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T FMINBKHGIKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3BA0130", Offset = "0x3B9F330", VA = "0x183BA0130")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3B9FDD0", Offset = "0x3B9EFD0", VA = "0x183B9FDD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
		internal KPEFKJNCDIJ(OEGPBNECFJE<T> LDPNGKPMFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct PCLHCGICPCN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly OEGPBNECFJE<T> FCPBCIHPHHA;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T FMINBKHGIKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3BA0130", Offset = "0x3B9F330", VA = "0x183BA0130")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x412A3A0", Offset = "0x41295A0", VA = "0x18412A3A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
		internal PCLHCGICPCN(OEGPBNECFJE<T> LDPNGKPMFNK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LLPGECHBEMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<PCLHCGICPCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public OEGPBNECFJE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FHEJFDNPPBG<PGENBOHGKNI>.NJKBLBIFOOE <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<FHEJFDNPPBG<PGENBOHGKNI>.NJKBLBIFOOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CA1740", Offset = "0x3CA0940", VA = "0x183CA1740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x30D4150", Offset = "0x30D3350", VA = "0x1830D4150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FHEJFDNPPBG<int> ANHMHPNMEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FHEJFDNPPBG<PGENBOHGKNI> CANKDDKJMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly FHEJFDNPPBG<PGENBOHGKNI> JNHGPDAKPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private T GHOPKKBAFKI;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4065850", Offset = "0x4064A50", VA = "0x184065850")]
	internal OEGPBNECFJE(FHEJFDNPPBG<int> OGEEBGIEFPO, FHEJFDNPPBG<PGENBOHGKNI> ONFMJKHLCOE, FHEJFDNPPBG<PGENBOHGKNI> KMGAOAMKFIH, [In] T OFGKCHFGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4064DC0", Offset = "0x4063FC0", VA = "0x184064DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4065210", Offset = "0x4064410", VA = "0x184065210")]
	public KPEFKJNCDIJ IPIDAKPHGJN()
	{
		return default(KPEFKJNCDIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4065120", Offset = "0x4064320", VA = "0x184065120")]
	public PCLHCGICPCN EGPLHGBNEEA()
	{
		return default(PCLHCGICPCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4064A30", Offset = "0x4063C30", VA = "0x184064A30")]
	[AsyncStateMachine(typeof(OEGPBNECFJE<>.LLPGECHBEMN))]
	public Task<OEGPBNECFJE<T>.PCLHCGICPCN> BLENJHNNNAH(CancellationToken OBNOJDAGGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PFEPMJIMALC
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x61F7F70", Offset = "0x61F7170", VA = "0x1861F7F70")]
	public static OEGPBNECFJE<PGENBOHGKNI> GOMGEEBODDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28E1960", Offset = "0x28E0B60", VA = "0x1828E1960")]
	public static OEGPBNECFJE<T> GOMGEEBODDD<T>([In] T OFGKCHFGFAP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BDBAHDFKLLE<TData> : EICMLFAAIEJ where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly string FANNLPKLMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly TData DOMOOIMCODE;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "7")]
	public override string OKCJCMAJCGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x478CAA0", Offset = "0x478BCA0", VA = "0x18478CAA0")]
	internal BDBAHDFKLLE(string LFMFEFFGFLH, [In] TData GKNJGNIHLDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NCCDPLGDBGF
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x61F7E20", Offset = "0x61F7020", VA = "0x1861F7E20")]
	public static BDBAHDFKLLE<PGENBOHGKNI> GOMGEEBODDD(string LFMFEFFGFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2614FA0", Offset = "0x26141A0", VA = "0x182614FA0")]
	public static BDBAHDFKLLE<TData> GOMGEEBODDD<TData>(string LFMFEFFGFLH, [In] TData GKNJGNIHLDH) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class ACEOOMFDMHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly Dictionary<object, float> KIDIHHHGLCE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float AICEHOEJCMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x943DF0", Offset = "0x942FF0", VA = "0x180943DF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x943E90", Offset = "0x943090", VA = "0x180943E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x61F5230", Offset = "0x61F4430", VA = "0x1861F5230")]
	public void FPPDILEGGNE(float AFCGKMGKPEF, object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x61F52A0", Offset = "0x61F44A0", VA = "0x1861F52A0")]
	public void MODILKLACII(object COAGHPOILPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61F5100", Offset = "0x61F4300", VA = "0x1861F5100")]
	private void AAPHBGIPGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x61F5310", Offset = "0x61F4510", VA = "0x1861F5310")]
	public ACEOOMFDMHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PDPLNANCCJM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JJEONHHIEPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public JJEONHHIEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFA20", Offset = "0x3AAEC20", VA = "0x183AAFA20")]
		internal int BGPKBOLIIEC(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HashSet<T>? HCIPGNKDDHK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> GHONGKBGPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x412FC80", Offset = "0x412EE80", VA = "0x18412FC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JJGHMJPEHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x412FC40", Offset = "0x412EE40", VA = "0x18412FC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0510", Offset = "0x7BF710", VA = "0x1807C0510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0520", Offset = "0x7BF720", VA = "0x1807C0520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x412FCF0", Offset = "0x412EEF0", VA = "0x18412FCF0")]
	public bool OJOKKDMOJFN(T COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x412FE60", Offset = "0x412F060", VA = "0x18412FE60")]
	public bool PADFOOPDKDB(T COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x412FCB0", Offset = "0x412EEB0", VA = "0x18412FCB0")]
	public bool NGGGJPKJNOI(T COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x412FF80", Offset = "0x412F180", VA = "0x18412FF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public PDPLNANCCJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NGPNBCHKDKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly string BLEJFFPBHFO;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public NGPNBCHKDKD(string BLEJFFPBHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x61F7EA0", Offset = "0x61F70A0", VA = "0x1861F7EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class COECADDMBED
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class AHBJAMBOOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public AHBJAMBOOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x61F53A0", Offset = "0x61F45A0", VA = "0x1861F53A0")]
		internal int BGPKBOLIIEC(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private HashSet<object>? HCIPGNKDDHK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> GHONGKBGPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x61F5670", Offset = "0x61F4870", VA = "0x1861F5670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool JJGHMJPEHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61F55F0", Offset = "0x61F47F0", VA = "0x1861F55F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0510", Offset = "0x7BF710", VA = "0x1807C0510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0520", Offset = "0x7BF720", VA = "0x1807C0520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x61F5760", Offset = "0x61F4960", VA = "0x1861F5760")]
	public bool OJOKKDMOJFN(object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x61F5840", Offset = "0x61F4A40", VA = "0x1861F5840")]
	public bool PADFOOPDKDB(object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x61F5700", Offset = "0x61F4900", VA = "0x1861F5700")]
	public bool NGGGJPKJNOI(object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x61F5600", Offset = "0x61F4800", VA = "0x1861F5600")]
	public void IDKLOGCJEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x61F58E0", Offset = "0x61F4AE0", VA = "0x1861F58E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public COECADDMBED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GBBEFNPDLGB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct OOICEEDFGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float AFJOLBGNGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public T FMINBKHGIKA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Dictionary<object, OOICEEDFGKO> KIDIHHHGLCE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T ANFPBNOELJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xED77B0", Offset = "0xED69B0", VA = "0x180ED77B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xED6D80", Offset = "0xED5F80", VA = "0x180ED6D80", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? NBPKPJBECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BIPHEDEEMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x37265A0", Offset = "0x37257A0", VA = "0x1837265A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3724900", Offset = "0x3723B00", VA = "0x183724900")]
	public bool FPPDILEGGNE(T AFCGKMGKPEF, object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3726530", Offset = "0x3725730", VA = "0x183726530")]
	public bool MODILKLACII(object COAGHPOILPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3726500", Offset = "0x3725700", VA = "0x183726500")]
	public void IICCKONGNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3724450", Offset = "0x3723650", VA = "0x183724450")]
	public bool AOAADIOEPBK(object COAGHPOILPB, [Out] T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x37255A0", Offset = "0x37247A0", VA = "0x1837255A0")]
	[AMIJKAOLDJP("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool HCOADGDFCMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x37265F0", Offset = "0x37257F0", VA = "0x1837265F0")]
	public GBBEFNPDLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BNLLCCGLLJA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DCGMNDBIKMF EFMOIFMEEHA;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class COMMFEBOPIM : BNLLCCGLLJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct NAKHNDDIJKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly float DDALJGFIKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float HIGLEHLPIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		internal readonly bool DOGDMICGGBB;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float OMLLDMPJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x61F7B50", Offset = "0x61F6D50", VA = "0x1861F7B50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x61F7CC0", Offset = "0x61F6EC0", VA = "0x1861F7CC0")]
		public NAKHNDDIJKB(float LIFMPBNCBOL, float NIANJOAGOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x61F7B60", Offset = "0x61F6D60", VA = "0x1861F7B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DFAAKHMPLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public COMMFEBOPIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public DFAAKHMPLHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x61F63B0", Offset = "0x61F55B0", VA = "0x1861F63B0")]
		internal void JIGIMDKKJOI(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly int EOPCNNFHDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private int MHOHNEKJEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BNLLCCGLLJA[] HHIIPPBAAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DCGMNDBIKMF[] NJKFJGHCCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NAKHNDDIJKB[] DEALBFIBPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NAKHNDDIJKB AAKEHNHCKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JFIPFPAAIFJ IHHKKPJPECI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event DCGMNDBIKMF EFMOIFMEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x61F6160", Offset = "0x61F5360", VA = "0x1861F6160", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61F5A90", Offset = "0x61F4C90", VA = "0x1861F5A90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x61F6220", Offset = "0x61F5420", VA = "0x1861F6220")]
	public COMMFEBOPIM(int EOPCNNFHDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x61F5C60", Offset = "0x61F4E60", VA = "0x1861F5C60")]
	public JFIPFPAAIFJ ECCMCIFONEO(NAKHNDDIJKB DHAEHODPIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x61F5CF0", Offset = "0x61F4EF0", VA = "0x1861F5CF0")]
	public void EIBPHHNIEGE(BNLLCCGLLJA IKKOGOPABEH, [Optional] NAKHNDDIJKB CBMBIDLILHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x61F5B50", Offset = "0x61F4D50", VA = "0x1861F5B50", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void DCGMNDBIKMF(float CGIIDGMEOHH);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BFCABLDPIIO
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class KMJMBPPCJOC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly BNLLCCGLLJA IFMMPCMHADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly DCGMNDBIKMF FPMNHFJNBFL;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x61F7A60", Offset = "0x61F6C60", VA = "0x1861F7A60")]
		public KMJMBPPCJOC(BNLLCCGLLJA IFMMPCMHADG, DCGMNDBIKMF FPMNHFJNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x61F7A10", Offset = "0x61F6C10", VA = "0x1861F7A10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x61F54C0", Offset = "0x61F46C0", VA = "0x1861F54C0")]
	internal static bool NDIDMAJNHKD(float HEFLGIBKJHK, float LPGCLIAKDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x61E7DA0", Offset = "0x61E6FA0", VA = "0x1861E7DA0")]
	internal static float BDALHKGBFMB(float HEFLGIBKJHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x61F5530", Offset = "0x61F4730", VA = "0x1861F5530")]
	public static IDisposable OIBOABFEGLF(this BNLLCCGLLJA IFMMPCMHADG, DCGMNDBIKMF FPMNHFJNBFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JFIPFPAAIFJ : BNLLCCGLLJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float CGIIDGMEOHH;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float LLABFGBMEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61F7070", Offset = "0x61F6270", VA = "0x1861F7070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event DCGMNDBIKMF? EFMOIFMEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x61F6FD0", Offset = "0x61F61D0", VA = "0x1861F6FD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x61F6F30", Offset = "0x61F6130", VA = "0x1861F6F30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public JFIPFPAAIFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HBJPNFGOHMO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2070", Offset = "0x5CE1270", VA = "0x185CE2070")]
	public HBJPNFGOHMO(string LFMFEFFGFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class JMAFCPNHLKJ<TKey, TValue> : CBGHKFGMOLA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, JBOLFBNGNDH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class KBOHEOKBIHM : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public JMAFCPNHLKJ<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xED77B0", Offset = "0xED69B0", VA = "0x180ED77B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3B48AB0", Offset = "0x3B47CB0", VA = "0x183B48AB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		[DebuggerHidden]
		public KBOHEOKBIHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x368B830", Offset = "0x368AA30", VA = "0x18368B830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3B47E80", Offset = "0x3B47080", VA = "0x183B47E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B47D40", Offset = "0x3B46F40", VA = "0x183B47D40")]
		private void EBDKPHOBLLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3B47D90", Offset = "0x3B46F90", VA = "0x183B47D90")]
		private void GOIMEKOFDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3B489C0", Offset = "0x3B47BC0", VA = "0x183B489C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly CBGHKFGMOLA<TKey, TValue> NBKAGPHGECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IDictionary<TKey, TValue> AIEDLJAOFKB;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5770", Offset = "0x3AC4970", VA = "0x183AC5770", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool FPDKMGECOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5870", Offset = "0x3AC4A70", VA = "0x183AC5870", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5AF0", Offset = "0x3AC4CF0", VA = "0x183AC5AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> CLBKIHGHECL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3AC58B0", Offset = "0x3AC4AB0", VA = "0x183AC58B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> ECMNIOOBHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3AC59C0", Offset = "0x3AC4BC0", VA = "0x183AC59C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5520", Offset = "0x3AC4720", VA = "0x183AC5520")]
	public JMAFCPNHLKJ(CBGHKFGMOLA<TKey, TValue> NBKAGPHGECN, [Optional] IDictionary<TKey, TValue>? AIEDLJAOFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3280", Offset = "0x3AC2480", VA = "0x183AC3280", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3B30", Offset = "0x3AC2D30", VA = "0x183AC3B30")]
	public void DIAMKELOMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2A30", Offset = "0x3AC1C30", VA = "0x183AC2A30", Slot = "9")]
	public void Add(TKey HKNPGHOCJDO, TValue AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4720", Offset = "0x3AC3920", VA = "0x183AC4720")]
	public void LKICHMGEHFP(TKey HKNPGHOCJDO, TValue AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3C70", Offset = "0x3AC2E70", VA = "0x183AC3C70")]
	public void GBBCKIKEKNE(TKey HKNPGHOCJDO, TValue AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC2DC0", Offset = "0x3AC1FC0", VA = "0x183AC2DC0")]
	public void CNJKLJFPCGD(TKey HKNPGHOCJDO, TValue AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3AC40A0", Offset = "0x3AC32A0", VA = "0x183AC40A0")]
	public void HIBOOHOFCMB(TKey HKNPGHOCJDO, TValue AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4B60", Offset = "0x3AC3D60", VA = "0x183AC4B60", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> BCCLIJMKECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4D40", Offset = "0x3AC3F40", VA = "0x183AC4D40", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3AC50A0", Offset = "0x3AC42A0", VA = "0x183AC50A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3390", Offset = "0x3AC2590", VA = "0x183AC3390", Slot = "8")]
	public bool ContainsKey(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4140", Offset = "0x3AC3340", VA = "0x183AC4140")]
	public bool HLKDDPEECCC(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3AC42D0", Offset = "0x3AC34D0", VA = "0x183AC42D0")]
	public bool JAKKFALHIHA(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4990", Offset = "0x3AC3B90", VA = "0x183AC4990", Slot = "10")]
	public bool Remove(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5370", Offset = "0x3AC4570", VA = "0x183AC5370", Slot = "11")]
	public bool TryGetValue(TKey HKNPGHOCJDO, [Out] TValue AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3AC38E0", Offset = "0x3AC2AE0", VA = "0x183AC38E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NPPGGGEFJIJ, int CEJCILDFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5260", Offset = "0x3AC4460", VA = "0x183AC5260", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3F80", Offset = "0x3AC3180", VA = "0x183AC3F80", Slot = "19")]
	[IteratorStateMachine(typeof(JMAFCPNHLKJ<, >.KBOHEOKBIHM))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3B80", Offset = "0x3AC2D80", VA = "0x183AC3B80", Slot = "21")]
	public bool FPJKFDICGHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4550", Offset = "0x3AC3750", VA = "0x183AC4550")]
	private TValue JBMMPLLOPGF(TKey HKNPGHOCJDO)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface JBOLFBNGNDH
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPJKFDICGHF();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface CBGHKFGMOLA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, JBOLFBNGNDH
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class NACLCEEHGAO<TKey, TVal> : CBGHKFGMOLA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, JBOLFBNGNDH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int DHGKFEJNONL(TKey HKNPGHOCJDO, TVal AFCGKMGKPEF);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class GDDIBHJCOHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84F9D0", VA = "0x1808507D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal FMINBKHGIKA
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x969DD0", Offset = "0x968FD0", VA = "0x180969DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int OMLLDMPJCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7FA4E0", Offset = "0x7F96E0", VA = "0x1807FA4E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7F9AE0", Offset = "0x7F8CE0", VA = "0x1807F9AE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset FDOHOAKABHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xAE2190", Offset = "0xAE1390", VA = "0x180AE2190")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x131DEE0", Offset = "0x131D0E0", VA = "0x18131DEE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x37300B0", Offset = "0x372F2B0", VA = "0x1837300B0")]
		public GDDIBHJCOHC(TKey HKNPGHOCJDO, TVal PDNEJFLCFBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class INKLCNFJHBK : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public NACLCEEHGAO<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private LinkedList<GDDIBHJCOHC>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xED77B0", Offset = "0xED69B0", VA = "0x180ED77B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x38B6910", Offset = "0x38B5B10", VA = "0x1838B6910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
		[DebuggerHidden]
		public INKLCNFJHBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x32B04C0", Offset = "0x32AF6C0", VA = "0x1832B04C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x38B5EA0", Offset = "0x38B50A0", VA = "0x1838B5EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x38B3CA0", Offset = "0x38B2EA0", VA = "0x1838B3CA0")]
		private void EBDKPHOBLLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x38B64B0", Offset = "0x38B56B0", VA = "0x1838B64B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public const int KILONNOCMJG = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, LinkedListNode<GDDIBHJCOHC>> GFJKGGANEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LinkedList<GDDIBHJCOHC> NHBMDJABFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DHGKFEJNONL? NJHJFJMOBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly TimeSpan LNFHFAOFCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly JLLGJGJFGAL BCKINFONLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool HBBEDJOBBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<TKey> NPDFHLAHJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly List<TVal> JEOHIOKBBNJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int FONPHGJAKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7D96E0", Offset = "0x7D88E0", VA = "0x1807D96E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int FLEPOEGCKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D96F0", Offset = "0x7D88F0", VA = "0x1807D96F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xEF6340", Offset = "0xEF5540", VA = "0x180EF6340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7990", Offset = "0x3EF6B90", VA = "0x183EF7990", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int FGFCBEKIHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF17E0", Offset = "0x3EF09E0", VA = "0x183EF17E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> ECMNIOOBHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7AC0", Offset = "0x3EF6CC0", VA = "0x183EF7AC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.HFEKHNEGACN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2D00", Offset = "0x3EF1F00", VA = "0x183EF2D00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool FPDKMGECOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3EF79F0", Offset = "0x3EF6BF0", VA = "0x183EF79F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7B10", Offset = "0x3EF6D10", VA = "0x183EF7B10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3EECD50", Offset = "0x3EEBF50", VA = "0x183EECD50")]
	private bool KODINCPEEOE(int EOPCNNFHDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3EEAE60", Offset = "0x3EEA060", VA = "0x183EEAE60")]
	private void GICCLDDINBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5390", Offset = "0x3EF4590", VA = "0x183EF5390")]
	public NACLCEEHGAO(int EOPCNNFHDCM, [Optional] DHGKFEJNONL? NJHJFJMOBNA, [Optional] IEqualityComparer<TKey>? BPPELEFJHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3C50", Offset = "0x3EF2E50", VA = "0x183EF3C50")]
	public NACLCEEHGAO(TimeSpan LNFHFAOFCID, [Optional] IEqualityComparer<TKey>? BPPELEFJHOC, [Optional] JLLGJGJFGAL? BCKINFONLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3C10", Offset = "0x3EF2E10", VA = "0x183EF3C10")]
	public NACLCEEHGAO(int EOPCNNFHDCM, TimeSpan LNFHFAOFCID, [Optional] IEqualityComparer<TKey>? BPPELEFJHOC, [Optional] JLLGJGJFGAL? BCKINFONLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3EF74D0", Offset = "0x3EF66D0", VA = "0x183EF74D0")]
	public NACLCEEHGAO(int EOPCNNFHDCM, DHGKFEJNONL? NJHJFJMOBNA, TimeSpan LNFHFAOFCID, [Optional] IEqualityComparer<TKey>? BPPELEFJHOC, [Optional] JLLGJGJFGAL? BCKINFONLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3EE8AE0", Offset = "0x3EE7CE0", VA = "0x183EE8AE0", Slot = "21")]
	public bool FPJKFDICGHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3EED160", Offset = "0x3EEC360", VA = "0x183EED160", Slot = "22")]
	public bool LNFNKJOBAFO(int DKMFLNHKFDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3EE42E0", Offset = "0x3EE34E0", VA = "0x183EE42E0")]
	private bool CEEFNLIDOMA(int DKMFLNHKFDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE83D0", Offset = "0x3EE75D0", VA = "0x183EE83D0")]
	public void FMPOAGCCLEO(TKey HKNPGHOCJDO, TVal AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3B10", Offset = "0x3EE2D10", VA = "0x183EE3B10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BCCLIJMKECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3F20", Offset = "0x3EE3120", VA = "0x183EE3F20", Slot = "9")]
	public void Add(TKey HKNPGHOCJDO, TVal AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4BD0", Offset = "0x3EE3DD0", VA = "0x183EE4BD0", Slot = "8")]
	public bool ContainsKey(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2670", Offset = "0x3EF1870", VA = "0x183EF2670", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1FD0", Offset = "0x3EF11D0", VA = "0x183EF1FD0", Slot = "10")]
	public bool Remove(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2860", Offset = "0x3EF1A60", VA = "0x183EF2860", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> BCCLIJMKECF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3EF19C0", Offset = "0x3EF0BC0", VA = "0x183EF19C0")]
	private bool PNBFKFGBHOJ(TKey HKNPGHOCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3EE82D0", Offset = "0x3EE74D0", VA = "0x183EE82D0")]
	private TVal EOIPIOCNLEH(TKey IDFJIKJFNIA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3450", Offset = "0x3EF2650", VA = "0x183EF3450", Slot = "11")]
	public bool TryGetValue(TKey IDFJIKJFNIA, [Out] TVal AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4A00", Offset = "0x3EE3C00", VA = "0x183EE4A00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3EE6A80", Offset = "0x3EE5C80", VA = "0x183EE6A80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NPPGGGEFJIJ, int CEJCILDFGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3EED740", Offset = "0x3EEC940", VA = "0x183EED740")]
	private bool LPNOMFCNNHN(GDDIBHJCOHC EICENFFELAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0D20", Offset = "0x3EEFF20", VA = "0x183EF0D20")]
	private void NNKBJFELOCD(LinkedListNode<GDDIBHJCOHC> GPGGPBHOCAJ, TVal DGJLMCNNGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3EEA380", Offset = "0x3EE9580", VA = "0x183EEA380")]
	private void FPPDILEGGNE(TKey HKNPGHOCJDO, TVal AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBA90", Offset = "0x3EEAC90", VA = "0x183EEBA90")]
	private void HAIODMKPIJP(GDDIBHJCOHC EICENFFELAJ, TVal DGJLMCNNGAF, int KPDKDIMCEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB340", Offset = "0x3EEA540", VA = "0x183EEB340", Slot = "19")]
	[IteratorStateMachine(typeof(NACLCEEHGAO<, >.INKLCNFJHBK))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2D30", Offset = "0x3EF1F30", VA = "0x183EF2D30", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class EIEECHKONJI<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class ODEIKJEPDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EIEECHKONJI<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public ODEIKJEPDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x405D340", Offset = "0x405C540", VA = "0x18405D340")]
		internal Task<TResource> AANOHJDOPDP(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct OLLBPEAHEIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x407D400", Offset = "0x407C600", VA = "0x18407D400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x407D780", Offset = "0x407C980", VA = "0x18407D780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct MEOEENEOJBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3E6E880", Offset = "0x3E6DA80", VA = "0x183E6E880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3E6ED40", Offset = "0x3E6DF40", VA = "0x183E6ED40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly LLNGKBMJLND<TId, Task<TResource>> GKFEHMEKDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> DDOGHKAHFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? KKAMBGJMFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Action<TResource>? BKOLICPNHOH;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x32BBC50", Offset = "0x32BAE50", VA = "0x1832BBC50")]
	public EIEECHKONJI(int FGDNBAMFLGF = 0, [Optional] IEqualityComparer<TId>? DEILKMHKIHH, [Optional] Func<TId, CancellationToken, Task<TResource>>? NEFJFICAIED, [Optional] Action<TResource>? DDLPPAEOIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x32BB5A0", Offset = "0x32BA7A0", VA = "0x1832BB5A0")]
	public ININENKNCEG<Task<TResource>> KMNIPMONMMA(TId EOHPLEHPKEN, [Optional] Func<TId, CancellationToken, Task<TResource>>? NEFJFICAIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x32BAC20", Offset = "0x32B9E20", VA = "0x1832BAC20")]
	private void DGPNIHPKHIJ(Task<TResource> GMIPPGJENPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x32BAD30", Offset = "0x32B9F30", VA = "0x1832BAD30")]
	public void ENKLBONIKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x32BB0F0", Offset = "0x32BA2F0", VA = "0x1832BB0F0")]
	public LLNGKBMJLND<TId, Task<TResource>>.JOANCEAPABE HPMIKEPMPON()
	{
		return default(LLNGKBMJLND<TId, Task<TResource>>.JOANCEAPABE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x32BBBB0", Offset = "0x32BADB0", VA = "0x1832BBBB0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x32BBBB0", Offset = "0x32BADB0", VA = "0x1832BBBB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x32BAD60", Offset = "0x32B9F60", VA = "0x1832BAD60")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(EIEECHKONJI<, >.OLLBPEAHEIF))]
	internal static Task FFCGMEDDHHL(Task<TResource> GMIPPGJENPH, CancellationTokenSource IGPBLPFPMLL, Dictionary<Task<TResource>, CancellationTokenSource> POJNFJFDIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x32BB970", Offset = "0x32BAB70", VA = "0x1832BB970")]
	[AsyncStateMachine(typeof(EIEECHKONJI<, >.MEOEENEOJBN))]
	[CompilerGenerated]
	internal static Task OJGBMGNNMAF(Task<TResource> GMIPPGJENPH, Action<TResource> CPLLFAIFCFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class LLNGKBMJLND<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private sealed class PPFNBIBOKMD : IEquatable<PPFNBIBOKMD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly TValue FMINBKHGIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int LKBKMDCIDAH;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1C7E1A0", Offset = "0x1C7D3A0", VA = "0x181C7E1A0")]
		public PPFNBIBOKMD(TValue AFCGKMGKPEF, int EECAMICDCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x415ADF0", Offset = "0x4159FF0", VA = "0x18415ADF0", Slot = "4")]
		public bool Equals(PPFNBIBOKMD? NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x415AD50", Offset = "0x4159F50", VA = "0x18415AD50", Slot = "0")]
		public override bool Equals(object? MFLACBLODGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x415AE80", Offset = "0x415A080", VA = "0x18415AE80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct JOANCEAPABE : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Dictionary<TKey, PPFNBIBOKMD>.Enumerator EKDJJFOEANO;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3AC9340", Offset = "0x3AC8540", VA = "0x183AC9340", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3AC9630", Offset = "0x3AC8830", VA = "0x183AC9630", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3AC93E0", Offset = "0x3AC85E0", VA = "0x183AC93E0")]
		public JOANCEAPABE(LLNGKBMJLND<TKey, TValue> KIDIHHHGLCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8EE0", Offset = "0x3AC80E0", VA = "0x183AC8EE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8F20", Offset = "0x3AC8120", VA = "0x183AC8F20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9090", Offset = "0x3AC8290", VA = "0x183AC9090", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class FJANAKLBGDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LLNGKBMJLND<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public PPFNBIBOKMD refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public FJANAKLBGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x364CF30", Offset = "0x364C130", VA = "0x18364CF30")]
		internal void AANOHJDOPDP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<TKey, PPFNBIBOKMD> FCJBLMEMBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<TKey, TValue>? EOHEBHNMHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly Action<TValue>? FHLFDLJOMEL;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1130", Offset = "0x3CA0330", VA = "0x183CA1130")]
	public LLNGKBMJLND(int FGDNBAMFLGF = 0, [Optional] IEqualityComparer<TKey>? BPPELEFJHOC, [Optional] Func<TKey, TValue>? KIAOJEENFOJ, [Optional] Action<TValue>? BDNJKCOECNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3CA06A0", Offset = "0x3C9F8A0", VA = "0x183CA06A0")]
	public ININENKNCEG<TValue> KMNIPMONMMA(TKey HKNPGHOCJDO, [Optional] Func<TKey, TValue>? ALCBGGOEAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0C70", Offset = "0x3C9FE70", VA = "0x183CA0C70")]
	private void PFNABIFCBEO(TKey HKNPGHOCJDO, PPFNBIBOKMD ILNOMDPHAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3C9FF70", Offset = "0x3C9F170", VA = "0x183C9FF70")]
	public void ENKLBONIKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3CA03B0", Offset = "0x3C9F5B0", VA = "0x183CA03B0")]
	public JOANCEAPABE HPMIKEPMPON()
	{
		return default(JOANCEAPABE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0F60", Offset = "0x3CA0160", VA = "0x183CA0F60", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0F60", Offset = "0x3CA0160", VA = "0x183CA0F60", Slot = "5")]
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
