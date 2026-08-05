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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x60985C0", Offset = "0x60979C0", VA = "0x1860985C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JPBFNBLMMHN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24AFEC0", Offset = "0x24AF2C0", VA = "0x1824AFEC0")]
	public static BOKNCNIGGDG<T> DIJCPKIJNFJ<T>(this T[] LHCHBOKBAPK) where T : notnull
	{
		return default(BOKNCNIGGDG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class AMKIMNLAJHB<T> : IDisposable, AKHHHJJEFHH, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KGHHEJFCMNO<T> NELFDJGOCDK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x37A1FF0", Offset = "0x37A13F0", VA = "0x1837A1FF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37A1F30", Offset = "0x37A1330", VA = "0x1837A1F30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37A2020", Offset = "0x37A1420", VA = "0x1837A2020")]
	public static AMKIMNLAJHB<T> PIJMMFMEPKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37A21C0", Offset = "0x37A15C0", VA = "0x1837A21C0")]
	internal AMKIMNLAJHB([In] KGHHEJFCMNO<T> ABLKMCPEJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x37A1F60", Offset = "0x37A1360", VA = "0x1837A1F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37A1FD0", Offset = "0x37A13D0", VA = "0x1837A1FD0")]
	public void KMHLBHIONDC(int GNHCGOJHAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x37A1F80", Offset = "0x37A1380", VA = "0x1837A1F80", Slot = "8")]
	public KGHHEJFCMNO<T>.IDCANBPONDE GetEnumerator()
	{
		return default(KGHHEJFCMNO<T>.IDCANBPONDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x37A2140", Offset = "0x37A1540", VA = "0x1837A2140", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x37A2140", Offset = "0x37A1540", VA = "0x1837A2140", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct EKKLNDGDDHG<T, U> : IEnumerable<T>, IEnumerable where U : KMLNEKMGIKI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U LPNMKPGOKHO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D042B0", Offset = "0x1D036B0", VA = "0x181D042B0")]
	internal EKKLNDGDDHG([In] U JHGKLMJBPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32DD740", Offset = "0x32DCB40", VA = "0x1832DD740", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x32DD740", Offset = "0x32DCB40", VA = "0x1832DD740", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PBPCENEHEDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2472560", Offset = "0x2471960", VA = "0x182472560")]
	public static EKKLNDGDDHG<T, U> PIJMMFMEPKL<U>([In] U LHCHBOKBAPK) where U : KMLNEKMGIKI<T>
	{
		return default(EKKLNDGDDHG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EKCFHAMEAHP<TSourceEnumerator, TSource, TResult> : AKHHHJJEFHH, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : AKHHHJJEFHH, KMLNEKMGIKI<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private TSourceEnumerator DHKPGNENAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly PFAALOLFPCP<TSource, TResult> AECCPDCDCMH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x32DD0C0", Offset = "0x32DC4C0", VA = "0x1832DD0C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public readonly TResult POOCHKNOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x32DD420", Offset = "0x32DC820", VA = "0x1832DD420", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x32DD270", Offset = "0x32DC670", VA = "0x1832DD270", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32DD3A0", Offset = "0x32DC7A0", VA = "0x1832DD3A0")]
	internal EKCFHAMEAHP([In] TSourceEnumerator LHCHBOKBAPK, PFAALOLFPCP<TSource, TResult> FPOKAEKKBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x32DD150", Offset = "0x32DC550", VA = "0x1832DD150", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32DD230", Offset = "0x32DC630", VA = "0x1832DD230", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32DD080", Offset = "0x32DC480", VA = "0x1832DD080", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KNEGGGJGGPF<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly U LPNMKPGOKHO;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B75810", Offset = "0x3B74C10", VA = "0x183B75810")]
	internal KNEGGGJGGPF([In] U JHGKLMJBPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32E1C20", Offset = "0x32E1020", VA = "0x1832E1C20", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B75510", Offset = "0x3B74910", VA = "0x183B75510", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B75510", Offset = "0x3B74910", VA = "0x183B75510", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HKIBHIMHPCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x247D650", Offset = "0x247CA50", VA = "0x18247D650")]
	public static KNEGGGJGGPF<T, U> PIJMMFMEPKL<U>([In] U LHCHBOKBAPK) where U : IEnumerator<T>
	{
		return default(KNEGGGJGGPF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GDKGIICMIBF<TSourceEnumerator, TSource, TResult> : AKHHHJJEFHH, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : AKHHHJJEFHH, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator DHKPGNENAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> AECCPDCDCMH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x32DD0C0", Offset = "0x32DC4C0", VA = "0x1832DD0C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult POOCHKNOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3772EF0", Offset = "0x37722F0", VA = "0x183772EF0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3772D60", Offset = "0x3772160", VA = "0x183772D60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32DD3A0", Offset = "0x32DC7A0", VA = "0x1832DD3A0")]
	internal GDKGIICMIBF([In] TSourceEnumerator LHCHBOKBAPK, Func<TSource, TResult> FPOKAEKKBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x32DD150", Offset = "0x32DC550", VA = "0x1832DD150", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32DD230", Offset = "0x32DC630", VA = "0x1832DD230", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32DD080", Offset = "0x32DC480", VA = "0x1832DD080", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class NLHEODNNNOB
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27693B0", Offset = "0x27687B0", VA = "0x1827693B0")]
	public static string HBPMHPIIOII<T>(this IEnumerable<T> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2759DD0", Offset = "0x27591D0", VA = "0x182759DD0")]
	public static string DJHHELHIMBI<T>(this IEnumerable<T> LHCHBOKBAPK, string OBIDHFODDLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OKPIGJHOBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x278F9F0", Offset = "0x278EDF0", VA = "0x18278F9F0")]
	public static bool FPBGONDKHIM<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LHCHBOKBAPK, [In] TArgs CNLJFDAGKBD, [In] JJHNJCBEPID<TArgs, TSource, bool> MCENDLOEFLE) where TSourceEnumerator : KMLNEKMGIKI<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x278F7F0", Offset = "0x278EBF0", VA = "0x18278F7F0")]
	public static int CLOPOIGMPCO<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LHCHBOKBAPK, [In] TArgs CNLJFDAGKBD, JJHNJCBEPID<TArgs, TSource, bool> MCENDLOEFLE) where TSourceEnumerator : KMLNEKMGIKI<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x278FB80", Offset = "0x278EF80", VA = "0x18278FB80")]
	public static bool LDKKIAEMCEM<TSourceEnumerator, TSource>(this TSourceEnumerator LHCHBOKBAPK, [In] TSource JCBFPBHHLOH) where TSourceEnumerator : KMLNEKMGIKI<TSource> where TSource : BGJBDKDCKID<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x278FDD0", Offset = "0x278F1D0", VA = "0x18278FDD0")]
	public static int LLNEDIOGMLM<TSourceEnumerator, TSource>(this TSourceEnumerator LHCHBOKBAPK, [In] TSource PAHKKNONPEO) where TSourceEnumerator : KMLNEKMGIKI<TSource> where TSource : BGJBDKDCKID<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x278F990", Offset = "0x278ED90", VA = "0x18278F990")]
	public static EKCFHAMEAHP<TSourceEnumerator, TSource, TResult> DELEBNAIPOO<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LHCHBOKBAPK, PFAALOLFPCP<TSource, TResult> FPOKAEKKBKL) where TSourceEnumerator : AKHHHJJEFHH, KMLNEKMGIKI<TSource>
	{
		return default(EKCFHAMEAHP<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x278F990", Offset = "0x278ED90", VA = "0x18278F990")]
	public static GDKGIICMIBF<TSourceEnumerator, TSource, TResult> IGHDIDBCELJ<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LHCHBOKBAPK, Func<TSource, TResult> FPOKAEKKBKL) where TSourceEnumerator : AKHHHJJEFHH, IEnumerator<TSource>
	{
		return default(GDKGIICMIBF<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FGJJMIEJICJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2474FD0", Offset = "0x24743D0", VA = "0x182474FD0")]
	public static bool GCLILOEHCCG<TSourceEnumerator>(TSourceEnumerator LHCHBOKBAPK) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2475040", Offset = "0x2474440", VA = "0x182475040")]
	public static T GKHBNHCNPPA<TSourceEnumerator>(TSourceEnumerator LHCHBOKBAPK) where TSourceEnumerator : KMLNEKMGIKI<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2475F70", Offset = "0x2475370", VA = "0x182475F70")]
	public static T[] LBOHLLGFNFP<TSourceEnumerator>(TSourceEnumerator LHCHBOKBAPK) where TSourceEnumerator : AKHHHJJEFHH, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2475170", Offset = "0x2474570", VA = "0x182475170")]
	public static T HAEJPEFFNFN<TSourceEnumerator>(TSourceEnumerator LHCHBOKBAPK) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KMLNEKMGIKI<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T POOCHKNOAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AKHHHJJEFHH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AGGMANAODGD<T> : KMLNEKMGIKI<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct EKGJCHHNKIN<T, U> : IEnumerable<T>, IEnumerable where U : AGGMANAODGD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U LPNMKPGOKHO;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32DD880", Offset = "0x32DCC80", VA = "0x1832DD880")]
	internal EKGJCHHNKIN([In] U JHGKLMJBPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x32DD720", Offset = "0x32DCB20", VA = "0x1832DD720", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32DD7C0", Offset = "0x32DCBC0", VA = "0x1832DD7C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x32DD7C0", Offset = "0x32DCBC0", VA = "0x1832DD7C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EEOPIFAPEFH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2472530", Offset = "0x2471930", VA = "0x182472530")]
	public static EKGJCHHNKIN<T, U> PIJMMFMEPKL<U>([In] U LHCHBOKBAPK) where U : AGGMANAODGD<T>
	{
		return default(EKGJCHHNKIN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public readonly struct BOKNCNIGGDG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct CBBMPAIAKPP : AKHHHJJEFHH, KMLNEKMGIKI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] DHKPGNENAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int KHJOFDOKFFL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int IGPGGFCOPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1D19950", Offset = "0x1D18D50", VA = "0x181D19950", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x49BDB80", Offset = "0x49BCF80", VA = "0x1849BDB80", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x49BD4C0", Offset = "0x49BC8C0", VA = "0x1849BD4C0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x49BD930", Offset = "0x49BCD30", VA = "0x1849BD930", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x17A8790", Offset = "0x17A7B90", VA = "0x1817A8790")]
		private CBBMPAIAKPP(T[] LHCHBOKBAPK, int FGBBDGJMFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x49BD300", Offset = "0x49BC700", VA = "0x1849BD300")]
		public static CBBMPAIAKPP PIJMMFMEPKL(T[] LHCHBOKBAPK)
		{
			return default(CBBMPAIAKPP);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1D19970", Offset = "0x1D18D70", VA = "0x181D19970", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1D199D0", Offset = "0x1D18DD0", VA = "0x181D199D0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] FLCHHADIJKE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KNKPDIOFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D19950", Offset = "0x1D18D50", VA = "0x181D19950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T GDDPFDKAEND
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x26AE130", Offset = "0x26AD530", VA = "0x1826AE130")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	internal BOKNCNIGGDG(T[] CBCBEPHCJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x47C25B0", Offset = "0x47C19B0", VA = "0x1847C25B0")]
	public static BOKNCNIGGDG<T> HNPOJGAPKPM()
	{
		return default(BOKNCNIGGDG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
	public IEnumerable<T> HFFIHJFJPEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x47C2670", Offset = "0x47C1A70", VA = "0x1847C2670")]
	public ReadOnlySpan<T> JAFBCBFCNAF()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x47C2490", Offset = "0x47C1890", VA = "0x1847C2490")]
	public EKKLNDGDDHG<T, BOKNCNIGGDG<T>.CBBMPAIAKPP> HIJNEDJJMBK()
	{
		return default(EKKLNDGDDHG<T, CBBMPAIAKPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x47C2380", Offset = "0x47C1780", VA = "0x1847C2380")]
	public CBBMPAIAKPP EFIPJEGGMGI()
	{
		return default(CBBMPAIAKPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x47C2410", Offset = "0x47C1810", VA = "0x1847C2410")]
	public IEnumerator<T> FPDPCEFPILF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x47C2700", Offset = "0x47C1B00", VA = "0x1847C2700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AACNBOJDBAI
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2456530", Offset = "0x2455930", VA = "0x182456530")]
	public static BOKNCNIGGDG<T> DBMHBFECMDF<T>(params T[] CBCBEPHCJOP) where T : notnull
	{
		return default(BOKNCNIGGDG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6098560", Offset = "0x6097960", VA = "0x186098560")]
	public static Stream ABOENPGLMON(this BOKNCNIGGDG<byte> LHCHBOKBAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DebuggerTypeProxy(typeof(KGHHEJFCMNO<>.KBHHJELKEMC))]
public struct KGHHEJFCMNO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct IDCANBPONDE : AKHHHJJEFHH, AGGMANAODGD<T>, KMLNEKMGIKI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] FHBNHPMHCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int PAOCBIJPPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int KHJOFDOKFFL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int IGPGGFCOPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1D31860", Offset = "0x1D30C60", VA = "0x181D31860", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x38DA770", Offset = "0x38D9B70", VA = "0x1838DA770", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private readonly T CCODLBPONBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x38DA090", Offset = "0x38D9490", VA = "0x1838DA090", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x38DA230", Offset = "0x38D9630", VA = "0x1838DA230", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x38DA590", Offset = "0x38D9990", VA = "0x1838DA590", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A5B0", Offset = "0x1D199B0", VA = "0x181D1A5B0")]
		internal IDCANBPONDE(T[] MEKGNJLOKAF, int GNHCGOJHAJG, int FGBBDGJMFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x38DA1D0", Offset = "0x38D95D0", VA = "0x1838DA1D0")]
		public static IDCANBPONDE PIJMMFMEPKL(KGHHEJFCMNO<T> LHCHBOKBAPK)
		{
			return default(IDCANBPONDE);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3346CB0", Offset = "0x33460B0", VA = "0x183346CB0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A550", Offset = "0x1D19950", VA = "0x181D1A550", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct MDAMMMCGEAG : AKHHHJJEFHH, KMLNEKMGIKI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IDCANBPONDE LPNMKPGOKHO;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int IGPGGFCOPJC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC2A0", Offset = "0x3DFB6A0", VA = "0x183DFC2A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public readonly T POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC7C0", Offset = "0x3DFBBC0", VA = "0x183DFC7C0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC400", Offset = "0x3DFB800", VA = "0x183DFC400", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC690", Offset = "0x3DFBA90", VA = "0x183DFC690", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1D042B0", Offset = "0x1D036B0", VA = "0x181D042B0")]
		private MDAMMMCGEAG([In] IDCANBPONDE JHGKLMJBPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC310", Offset = "0x3DFB710", VA = "0x183DFC310")]
		public static MDAMMMCGEAG PIJMMFMEPKL([In] KGHHEJFCMNO<T> LHCHBOKBAPK)
		{
			return default(MDAMMMCGEAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC2D0", Offset = "0x3DFB6D0", VA = "0x183DFC2D0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC3C0", Offset = "0x3DFB7C0", VA = "0x183DFC3C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC260", Offset = "0x3DFB660", VA = "0x183DFC260", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class KBHHJELKEMC
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] FHBNHPMHCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int PAOCBIJPPII;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B37C50", Offset = "0x3B37050", VA = "0x183B37C50")]
	public static KGHHEJFCMNO<T> PIJMMFMEPKL()
	{
		return default(KGHHEJFCMNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3B37B40", Offset = "0x3B36F40", VA = "0x183B37B40")]
	public static KGHHEJFCMNO<T> IDKAACKPOFD(int BPEPAFIGLCD)
	{
		return default(KGHHEJFCMNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B37A30", Offset = "0x3B36E30", VA = "0x183B37A30")]
	public static KGHHEJFCMNO<T> GBMPKMOOGLI(int GNHCGOJHAJG)
	{
		return default(KGHHEJFCMNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x17A8790", Offset = "0x17A7B90", VA = "0x1817A8790")]
	internal KGHHEJFCMNO(T[] MEKGNJLOKAF, int GNHCGOJHAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3808780", Offset = "0x3807B80", VA = "0x183808780", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LGJMDMDEILK
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26AAAE0", Offset = "0x26A9EE0", VA = "0x1826AAAE0")]
	public static void GOHOEIHDKHJ<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26AAB80", Offset = "0x26A9F80", VA = "0x1826AAB80")]
	public static string HFAFPFHDFJO<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360")]
	public static T[] HILLAFMFHHC<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26AE130", Offset = "0x26AD530", VA = "0x1826AE130")]
	public static T LBFOALNGCEO<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK, int AMJKHBKANHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x26AE130", Offset = "0x26AD530", VA = "0x1826AE130")]
	public static T MBKMANMAECC<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, int AMJKHBKANHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x26AEC40", Offset = "0x26AE040", VA = "0x1826AEC40")]
	public static T PDGMAGPFGMO<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK, int AMJKHBKANHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x26AE610", Offset = "0x26ADA10", VA = "0x1826AE610")]
	public static void NIEAIDPCAEB<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, int AMJKHBKANHA, [In] T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26AA900", Offset = "0x26A9D00", VA = "0x1826AA900")]
	public static void ELAGBGBGHEO<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, int AMJKHBKANHA, T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D31860", Offset = "0x1D30C60", VA = "0x181D31860")]
	public static int FIENPAGGFEK<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x26ACA70", Offset = "0x26ABE70", VA = "0x1826ACA70")]
	public static ReadOnlySpan<T> JAFBCBFCNAF<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x26A7570", Offset = "0x26A6970", VA = "0x1826A7570")]
	public static T[] AAFGJJGMGOA<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26A7750", Offset = "0x26A6B50", VA = "0x1826A7750")]
	public static T[] ABDGIHOEFBC<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26ACB40", Offset = "0x26ABF40", VA = "0x1826ACB40")]
	public static BOKNCNIGGDG<T> KJLKBCHLEPN<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return default(BOKNCNIGGDG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26AA320", Offset = "0x26A9720", VA = "0x1826AA320")]
	public static void DEAIBIAHPPK<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, [In] T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26AA1F0", Offset = "0x26A95F0", VA = "0x1826AA1F0")]
	public static void CLKCJAOMOFL<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26AE430", Offset = "0x26AD830", VA = "0x1826AE430")]
	public static void NGBBCEMFLAB<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, int FGBBDGJMFEH, [In] T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26AA740", Offset = "0x26A9B40", VA = "0x1826AA740")]
	public static void DOAIIEDHOAA<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, int FGBBDGJMFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26A77D0", Offset = "0x26A6BD0", VA = "0x1826A77D0")]
	public static T ANLHCOMHFAD<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26ACBD0", Offset = "0x26ABFD0", VA = "0x1826ACBD0")]
	public static void KMHLBHIONDC<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, int GNHCGOJHAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26A7830", Offset = "0x26A6C30", VA = "0x1826A7830")]
	private static void BCNEBLOHMGE<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, int BPEPAFIGLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26AA780", Offset = "0x26A9B80", VA = "0x1826AA780")]
	public static void EKABOMHIFDI<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x26AA9D0", Offset = "0x26A9DD0", VA = "0x1826AA9D0")]
	public static bool EMDNOODLJBK<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK, [In] T PAHKKNONPEO) where T : BGJBDKDCKID<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26AE420", Offset = "0x26AD820", VA = "0x1826AE420")]
	public static bool NABJPIJAAIJ<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x26AE3A0", Offset = "0x26AD7A0", VA = "0x1826AE3A0")]
	public static bool MAOKECNBNNO<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK, int AMJKHBKANHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x24C92A0", Offset = "0x24C86A0", VA = "0x1824C92A0")]
	public static KGHHEJFCMNO<T>.MDAMMMCGEAG FPDPCEFPILF<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return default(KGHHEJFCMNO<T>.MDAMMMCGEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x24C92A0", Offset = "0x24C86A0", VA = "0x1824C92A0")]
	public static KGHHEJFCMNO<T>.IDCANBPONDE NDAIJKLGCPM<T>(this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return default(KGHHEJFCMNO<T>.IDCANBPONDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26AAA70", Offset = "0x26A9E70", VA = "0x1826AAA70")]
	public static EKKLNDGDDHG<T, KGHHEJFCMNO<T>.MDAMMMCGEAG> GOBAECEAONG<T>([In] this KGHHEJFCMNO<T> LHCHBOKBAPK)
	{
		return default(EKKLNDGDDHG<T, KGHHEJFCMNO<T>.MDAMMMCGEAG>);
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
