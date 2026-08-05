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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8105580", Offset = "0x8103D80", VA = "0x188105580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ABCEHCCKLGC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37F6C00", Offset = "0x37F5400", VA = "0x1837F6C00")]
	public static LBCPBJKCGNG<T> BCLNPNDBLLN<T>(this T[] DKBBJFIDEGB) where T : notnull
	{
		return default(LBCPBJKCGNG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x41E1410", Offset = "0x41DFC10", VA = "0x1841E1410")]
	public static CNJPGMIIFBK<T, JAFFMOPJLPG<T>> BCHFFDMDGKH<T>(this T[] DKBBJFIDEGB) where T : notnull
	{
		return default(CNJPGMIIFBK<T, JAFFMOPJLPG<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class JKOCDJKJBKC<T> : IDisposable, DAFJFMFEPEF, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GJEDEGEJPLA<T> HMEAKNABFCG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x50C7980", Offset = "0x50C6180", VA = "0x1850C7980", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x50C79C0", Offset = "0x50C61C0", VA = "0x1850C79C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50C7760", Offset = "0x50C5F60", VA = "0x1850C7760")]
	public static JKOCDJKJBKC<T> CCPKJDCALBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4755290", Offset = "0x4753A90", VA = "0x184755290")]
	internal JKOCDJKJBKC([In] GJEDEGEJPLA<T> DIIOBAFKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x50C78E0", Offset = "0x50C60E0", VA = "0x1850C78E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50C78A0", Offset = "0x50C60A0", VA = "0x1850C78A0")]
	public void CKPGFBBHDHP(int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x50C7920", Offset = "0x50C6120", VA = "0x1850C7920", Slot = "8")]
	public GJEDEGEJPLA<T>.GFCMHNANCPO GetEnumerator()
	{
		return default(GJEDEGEJPLA<T>.GFCMHNANCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50C7A00", Offset = "0x50C6200", VA = "0x1850C7A00", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x50C7A00", Offset = "0x50C6200", VA = "0x1850C7A00", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct OCDFHHMPNOP<T, U> : IEnumerable<T>, IEnumerable where U : KMEHPGKODON<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U KOCLFMMJHHH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11254E0", Offset = "0x1123CE0", VA = "0x1811254E0")]
	internal OCDFHHMPNOP([In] U DCDHHMABBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4C86EE0", Offset = "0x4C856E0", VA = "0x184C86EE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C86EE0", Offset = "0x4C856E0", VA = "0x184C86EE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NOFENJIPNDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F635F0", Offset = "0x2F61DF0", VA = "0x182F635F0")]
	public static OCDFHHMPNOP<T, U> CCPKJDCALBG<U>([In] U DKBBJFIDEGB) where U : KMEHPGKODON<T>
	{
		return default(OCDFHHMPNOP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BHCNNPGADDA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x616EB90", Offset = "0x616D390", VA = "0x18616EB90")]
	public static CNJPGMIIFBK<T, JAFFMOPJLPG<T>> CCPKJDCALBG([In] T[] DKBBJFIDEGB)
	{
		return default(CNJPGMIIFBK<T, JAFFMOPJLPG<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct CNJPGMIIFBK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U KOCLFMMJHHH;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1268020", Offset = "0x1266820", VA = "0x181268020")]
	internal CNJPGMIIFBK([In] U DCDHHMABBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1267FF0", Offset = "0x12667F0", VA = "0x181267FF0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6883340", Offset = "0x6881B40", VA = "0x186883340", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6883340", Offset = "0x6881B40", VA = "0x186883340", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GPHNDOKPCMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x414A0E0", Offset = "0x41488E0", VA = "0x18414A0E0")]
	public static CNJPGMIIFBK<T, U> CCPKJDCALBG<U>([In] U DKBBJFIDEGB) where U : IEnumerator<T>
	{
		return default(CNJPGMIIFBK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FIPBFDBKGDH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x39BEEF0", Offset = "0x39BD6F0", VA = "0x1839BEEF0")]
	public static CNJPGMIIFBK<TResult, CFHAJKFLDJI<TSourceEnumerator, TSource, TResult>> NEOCKPENJHM<TResult, TSourceEnumerator, TSource>([In] this CNJPGMIIFBK<TSource, TSourceEnumerator> DKBBJFIDEGB, Func<TSource, TResult> HAJBEIGPEKE) where TSourceEnumerator : DAFJFMFEPEF, IEnumerator<TSource>
	{
		return default(CNJPGMIIFBK<TResult, CFHAJKFLDJI<TSourceEnumerator, TSource, TResult>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JAFFMOPJLPG<T> : IEnumerator<T>, IEnumerator, IDisposable, DAFJFMFEPEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly T[] DDFOMBDMPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int MFDMJKGOEFM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly T EBPBANINJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5075660", Offset = "0x5073E60", VA = "0x185075660", Slot = "4")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5075610", Offset = "0x5073E10", VA = "0x185075610", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xC9CD20", Offset = "0xC9B520", VA = "0x180C9CD20")]
	private JAFFMOPJLPG(T[] DKBBJFIDEGB, int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50755C0", Offset = "0x5073DC0", VA = "0x1850755C0")]
	public static JAFFMOPJLPG<T> CCPKJDCALBG(T[] DKBBJFIDEGB)
	{
		return default(JAFFMOPJLPG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2882290", Offset = "0x2880A90", VA = "0x182882290", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28822C0", Offset = "0x2880AC0", VA = "0x1828822C0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CFHAJKFLDJI<TSourceEnumerator, TSource, TResult> : DAFJFMFEPEF, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : DAFJFMFEPEF, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator DDFOMBDMPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> BCGJJOOEJMG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly TResult EBPBANINJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x669A830", Offset = "0x6699030", VA = "0x18669A830", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x669A770", Offset = "0x6698F70", VA = "0x18669A770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2891E70", Offset = "0x2890670", VA = "0x182891E70")]
	internal CFHAJKFLDJI([In] TSourceEnumerator DKBBJFIDEGB, Func<TSource, TResult> HAJBEIGPEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x669A650", Offset = "0x6698E50", VA = "0x18669A650", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x669A6E0", Offset = "0x6698EE0", VA = "0x18669A6E0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55A0E80", Offset = "0x559F680", VA = "0x1855A0E80", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class DNELOMHMOLC
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x381E990", Offset = "0x381D190", VA = "0x18381E990")]
	public static string JCFCHICPINP<T>(this IEnumerable<T> DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x38098B0", Offset = "0x38080B0", VA = "0x1838098B0")]
	public static string AHPHMPIENMB<T>(this IEnumerable<T> DKBBJFIDEGB, string EGBLMKEEJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HOKDJHBMGEI
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BD40", Offset = "0x3A0A540", VA = "0x183A0BD40")]
	public static bool AAOCJBDJEII<TSourceEnumerator, TSource>(this TSourceEnumerator DKBBJFIDEGB, [In] TSource NAGJHHJDFPB) where TSourceEnumerator : KMEHPGKODON<TSource> where TSource : FLLPMOIALDN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A0C130", Offset = "0x3A0A930", VA = "0x183A0C130")]
	public static int EDGCIFFCDPD<TSourceEnumerator, TSource>(this TSourceEnumerator DKBBJFIDEGB, [In] TSource MGONBEDEDON) where TSourceEnumerator : KMEHPGKODON<TSource> where TSource : FLLPMOIALDN<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A0C390", Offset = "0x3A0AB90", VA = "0x183A0C390")]
	public static CFHAJKFLDJI<TSourceEnumerator, TSource, TResult> NEOCKPENJHM<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator DKBBJFIDEGB, Func<TSource, TResult> HAJBEIGPEKE) where TSourceEnumerator : DAFJFMFEPEF, IEnumerator<TSource>
	{
		return default(CFHAJKFLDJI<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3A0BEC0", Offset = "0x3A0A6C0", VA = "0x183A0BEC0")]
	public static int EAOKDPLPPJK<TSourceEnumerator, TSource>(this TSourceEnumerator DKBBJFIDEGB, [In] TSource MGONBEDEDON) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KMEHPGKODON<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	T EBPBANINJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DAFJFMFEPEF
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NBFAKIIBPFK<T> : KMEHPGKODON<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct GFJPOBLGLNL<T, U> : IEnumerable<T>, IEnumerable where U : NBFAKIIBPFK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U KOCLFMMJHHH;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C86F60", Offset = "0x4C85760", VA = "0x184C86F60")]
	internal GFJPOBLGLNL([In] U DCDHHMABBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4809F70", Offset = "0x4808770", VA = "0x184809F70", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4C86E50", Offset = "0x4C85650", VA = "0x184C86E50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4C86E50", Offset = "0x4C85650", VA = "0x184C86E50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class AOGGOLILBNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2F63620", Offset = "0x2F61E20", VA = "0x182F63620")]
	public static GFJPOBLGLNL<T, U> CCPKJDCALBG<U>([In] U DKBBJFIDEGB) where U : NBFAKIIBPFK<T>
	{
		return default(GFJPOBLGLNL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public readonly struct LBCPBJKCGNG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct CBMOPDCLJDO : DAFJFMFEPEF, KMEHPGKODON<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] DDFOMBDMPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int MFDMJKGOEFM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x2882250", Offset = "0x2880A50", VA = "0x182882250", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x65B4550", Offset = "0x65B2D50", VA = "0x1865B4550", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x65B4AA0", Offset = "0x65B32A0", VA = "0x1865B4AA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC9CD20", Offset = "0xC9B520", VA = "0x180C9CD20")]
		private CBMOPDCLJDO(T[] DKBBJFIDEGB, int PNJCJGEIDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x50755C0", Offset = "0x5073DC0", VA = "0x1850755C0")]
		public static CBMOPDCLJDO CCPKJDCALBG(T[] DKBBJFIDEGB)
		{
			return default(CBMOPDCLJDO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2882290", Offset = "0x2880A90", VA = "0x182882290", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28822C0", Offset = "0x2880AC0", VA = "0x1828822C0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] IIGHIAGDKCC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x51F6EE0", Offset = "0x51F56E0", VA = "0x1851F6EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28821E0", Offset = "0x28809E0", VA = "0x1828821E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
	internal LBCPBJKCGNG(T[] LPBOBEPEKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x52647D0", Offset = "0x5262FD0", VA = "0x1852647D0")]
	public static LBCPBJKCGNG<T> EBKBGKJDDBM()
	{
		return default(LBCPBJKCGNG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
	public IEnumerable<T> LDGLEGGNHOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5264730", Offset = "0x5262F30", VA = "0x185264730")]
	public ReadOnlySpan<T> BDCOOOHFFND()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5264930", Offset = "0x5263130", VA = "0x185264930")]
	public OCDFHHMPNOP<T, LBCPBJKCGNG<T>.CBMOPDCLJDO> KHMAEBKNDLI()
	{
		return default(OCDFHHMPNOP<T, CBMOPDCLJDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5264690", Offset = "0x5262E90", VA = "0x185264690")]
	public CBMOPDCLJDO AKKALODFOCA()
	{
		return default(CBMOPDCLJDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x52648B0", Offset = "0x52630B0", VA = "0x1852648B0")]
	public IEnumerator<T> KFPOPIJHFBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5264A70", Offset = "0x5263270", VA = "0x185264A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class APCNMEBCBBB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37F6EE0", Offset = "0x37F56E0", VA = "0x1837F6EE0")]
	public static LBCPBJKCGNG<T> IADHOIFABPF<T>(params T[] LPBOBEPEKNH) where T : notnull
	{
		return default(LBCPBJKCGNG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8105520", Offset = "0x8103D20", VA = "0x188105520")]
	public static Stream CPDMIGNOKDM(this LBCPBJKCGNG<byte> DKBBJFIDEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DebuggerTypeProxy(typeof(GJEDEGEJPLA<>.AOAOGBGNJIP))]
public struct GJEDEGEJPLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct GFCMHNANCPO : DAFJFMFEPEF, NBFAKIIBPFK<T>, KMEHPGKODON<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] OANILNLNKBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int FLHHMMGEFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int MFDMJKGOEFM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4C85520", Offset = "0x4C83D20", VA = "0x184C85520", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T LNPNPOOFEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4C853D0", Offset = "0x4C83BD0", VA = "0x184C853D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private readonly T LGCIHJHMADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4C85380", Offset = "0x4C83B80", VA = "0x184C85380", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4C85400", Offset = "0x4C83C00", VA = "0x184C85400", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4C85450", Offset = "0x4C83C50", VA = "0x184C85450", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4C854E0", Offset = "0x4C83CE0", VA = "0x184C854E0")]
		internal GFCMHNANCPO(T[] DBAICDFECAB, int FMGALNGIOGC, int PNJCJGEIDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4C85320", Offset = "0x4C83B20", VA = "0x184C85320")]
		public static GFCMHNANCPO CCPKJDCALBG(GJEDEGEJPLA<T> DKBBJFIDEGB)
		{
			return default(GFCMHNANCPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x47BA190", Offset = "0x47B8990", VA = "0x1847BA190", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x47B4230", Offset = "0x47B2A30", VA = "0x1847B4230", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct NADPJLNGBLG : DAFJFMFEPEF, KMEHPGKODON<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GFCMHNANCPO KOCLFMMJHHH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x55A1380", Offset = "0x559FB80", VA = "0x1855A1380", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x55A0F80", Offset = "0x559F780", VA = "0x1855A0F80", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x55A1140", Offset = "0x559F940", VA = "0x1855A1140", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x11254E0", Offset = "0x1123CE0", VA = "0x1811254E0")]
		private NADPJLNGBLG([In] GFCMHNANCPO DCDHHMABBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x55A0DD0", Offset = "0x559F5D0", VA = "0x1855A0DD0")]
		public static NADPJLNGBLG CCPKJDCALBG([In] GJEDEGEJPLA<T> DKBBJFIDEGB)
		{
			return default(NADPJLNGBLG);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x55A0EC0", Offset = "0x559F6C0", VA = "0x1855A0EC0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x55A0F00", Offset = "0x559F700", VA = "0x1855A0F00", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x55A0E80", Offset = "0x559F680", VA = "0x1855A0E80", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class AOAOGBGNJIP
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] OANILNLNKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int FLHHMMGEFMF;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4C947A0", Offset = "0x4C92FA0", VA = "0x184C947A0")]
	public static GJEDEGEJPLA<T> CCPKJDCALBG()
	{
		return default(GJEDEGEJPLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C946E0", Offset = "0x4C92EE0", VA = "0x184C946E0")]
	public static GJEDEGEJPLA<T> BNCDKNDMDDN(int BEMGFNOEFHN)
	{
		return default(GJEDEGEJPLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xC9CD20", Offset = "0xC9B520", VA = "0x180C9CD20")]
	internal GJEDEGEJPLA(T[] DBAICDFECAB, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C94850", Offset = "0x4C93050", VA = "0x184C94850", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HFGEKBMAAML
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate int IONINOKIBGA<TCtx, T>([In] TCtx HEKEBEBCDAB, T NOGJAHKGFJD, T LHMEHOJLNDH);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3A02B00", Offset = "0x3A01300", VA = "0x183A02B00")]
	public static void MMIAFMKGHIE<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x39F7650", Offset = "0x39F5E50", VA = "0x1839F7650")]
	public static string BNGAHLEMIAK<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
	public static T[] BNFPCIBPHDH<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28821E0", Offset = "0x28809E0", VA = "0x1828821E0")]
	public static T CEJDCFFPPDB<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB, int CCPDHPNHILC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x39FB3D0", Offset = "0x39F9BD0", VA = "0x1839FB3D0")]
	public static T HIPNFKJEKNO<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int CCPDHPNHILC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x39FEC30", Offset = "0x39FD430", VA = "0x1839FEC30")]
	public static T FBFBMIHHHMP<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB, int CCPDHPNHILC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3A02D40", Offset = "0x3A01540", VA = "0x183A02D40")]
	public static void NNLOAAEAPBJ<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int CCPDHPNHILC, [In] T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3A02D40", Offset = "0x3A01540", VA = "0x183A02D40")]
	public static void OIFCJOOHIAA<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int CCPDHPNHILC, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xE48A70", Offset = "0xE47270", VA = "0x180E48A70")]
	public static int BIMIOEFEJJK<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x39F6950", Offset = "0x39F5150", VA = "0x1839F6950")]
	public static ReadOnlySpan<T> BDCOOOHFFND<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3A02500", Offset = "0x3A00D00", VA = "0x183A02500")]
	public static T[] IEPILEBBHOM<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3A03750", Offset = "0x3A01F50", VA = "0x183A03750")]
	public static T OPKGGLPIMCA<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3A01460", Offset = "0x39FFC60", VA = "0x183A01460")]
	public static T[] GFMKBPPBKBL<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3A02960", Offset = "0x3A01160", VA = "0x183A02960")]
	public static LBCPBJKCGNG<T> LDCIFNFBDMA<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return default(LBCPBJKCGNG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3A01510", Offset = "0x39FFD10", VA = "0x183A01510")]
	public static void GGGBGBDKNKJ<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, [In] T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x39F6780", Offset = "0x39F4F80", VA = "0x1839F6780")]
	public static void ANAOAMLPPCH<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x39FE900", Offset = "0x39FD100", VA = "0x1839FE900")]
	public static void DBIMNIOCAGM<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int PNJCJGEIDHG, [In] T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3A02740", Offset = "0x3A00F40", VA = "0x183A02740")]
	public static void JPEBMJBJFBG<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int PNJCJGEIDHG, [In] GJEDEGEJPLA<T> IFMNLKCJNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3A02800", Offset = "0x3A01000", VA = "0x183A02800")]
	public static void KOPNNLBOMFE<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int PNJCJGEIDHG, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3A01D90", Offset = "0x3A00590", VA = "0x183A01D90")]
	public static void HNMLFODLNIF<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A01B50", Offset = "0x3A00350", VA = "0x183A01B50")]
	public static T HIAMCNGGGNN<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x39FC170", Offset = "0x39FA970", VA = "0x1839FC170")]
	public static void CKPGFBBHDHP<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x39FF7B0", Offset = "0x39FDFB0", VA = "0x1839FF7B0")]
	private static void FJIBMLFNLAC<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, int BEMGFNOEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x39FB5C0", Offset = "0x39F9DC0", VA = "0x1839FB5C0")]
	public static void CGGBONADGHB<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x39FED00", Offset = "0x39FD500", VA = "0x1839FED00")]
	public static GJEDEGEJPLA<T> FGIKHGILDDC<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB, BCPKGKKIGOM<T, T> CMHCDELADBE)
	{
		return default(GJEDEGEJPLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3A01BF0", Offset = "0x3A003F0", VA = "0x183A01BF0")]
	public static bool HKOLMKDGPPH<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, T MGONBEDEDON) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3A02A30", Offset = "0x3A01230", VA = "0x183A02A30")]
	public static bool MIDCPHJKDEH<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB, [In] T MGONBEDEDON) where T : FLLPMOIALDN<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x37FA9E0", Offset = "0x37F91E0", VA = "0x1837FA9E0")]
	public static bool JNLECKPDOLI<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3A026E0", Offset = "0x3A00EE0", VA = "0x183A026E0")]
	public static bool JHDJKLNOJFP<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB, int CCPDHPNHILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x39FEB30", Offset = "0x39FD330", VA = "0x1839FEB30")]
	public static void EAIDNKEKLGM<T, TCtx>(this GJEDEGEJPLA<T> DKBBJFIDEGB, [In] TCtx HEKEBEBCDAB, IONINOKIBGA<TCtx, T> HIKEFAEPBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x39FE800", Offset = "0x39FD000", VA = "0x1839FE800")]
	private static void CNKFOBGICLP<T, TCtx>(GJEDEGEJPLA<T> DKBBJFIDEGB, [In] TCtx HEKEBEBCDAB, IONINOKIBGA<TCtx, T> HIKEFAEPBKH, int MPJBDBKIAPG, int BLDLGIEEEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A01DD0", Offset = "0x3A005D0", VA = "0x183A01DD0")]
	private static int IBNFKOHALAK<T, TCtx>(GJEDEGEJPLA<T> DKBBJFIDEGB, [In] TCtx HEKEBEBCDAB, IONINOKIBGA<TCtx, T> HIKEFAEPBKH, int MPJBDBKIAPG, int BLDLGIEEEJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x37F6C30", Offset = "0x37F5430", VA = "0x1837F6C30")]
	public static GJEDEGEJPLA<T>.NADPJLNGBLG KFPOPIJHFBP<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return default(GJEDEGEJPLA<T>.NADPJLNGBLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x37F6C30", Offset = "0x37F5430", VA = "0x1837F6C30")]
	public static GJEDEGEJPLA<T>.GFCMHNANCPO CAAIHFIJPLJ<T>(this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return default(GJEDEGEJPLA<T>.GFCMHNANCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x37F6B70", Offset = "0x37F5370", VA = "0x1837F6B70")]
	public static OCDFHHMPNOP<T, GJEDEGEJPLA<T>.NADPJLNGBLG> FIGAAFICBKE<T>([In] this GJEDEGEJPLA<T> DKBBJFIDEGB)
	{
		return default(OCDFHHMPNOP<T, GJEDEGEJPLA<T>.NADPJLNGBLG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class BKNDKGAAFGE
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x372D690", Offset = "0x372BE90", VA = "0x18372D690")]
	public static T[] NDEMPJCIBJN<T>(int GGIJOHIPOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	public static void LCMHPGPOBGE<T>(T[] LPBOBEPEKNH)
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
