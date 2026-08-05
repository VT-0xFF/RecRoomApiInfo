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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C49980", Offset = "0x7C48180", VA = "0x187C49980")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ANALBLFONLL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34FFF20", Offset = "0x34FE720", VA = "0x1834FFF20")]
	public static DADDGNDMECL<T> ANPAKGKPDHP<T>(this T[] NFOGFJOGLPE) where T : notnull
	{
		return default(DADDGNDMECL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F200", Offset = "0x3F0DA00", VA = "0x183F0F200")]
	public static PFNCDBFLBAH<T, MHELDIPGLPE<T>> JEGMPHKJCND<T>(this T[] NFOGFJOGLPE) where T : notnull
	{
		return default(PFNCDBFLBAH<T, MHELDIPGLPE<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class HNIDBILDAND<T> : IDisposable, MAJMOKHLLLG, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PFLMDAPEOIN<T> FIFFPJBDNCC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4A5EA40", Offset = "0x4A5D240", VA = "0x184A5EA40", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4A5EA80", Offset = "0x4A5D280", VA = "0x184A5EA80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A5EAC0", Offset = "0x4A5D2C0", VA = "0x184A5EAC0")]
	public static HNIDBILDAND<T> CJOJELENPLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x497AE30", Offset = "0x4979630", VA = "0x18497AE30")]
	internal HNIDBILDAND([In] PFLMDAPEOIN<T> JLPKBNIJDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A5EC30", Offset = "0x4A5D430", VA = "0x184A5EC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A5EBF0", Offset = "0x4A5D3F0", VA = "0x184A5EBF0")]
	public void DDNAALJBFBE(int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A5EC70", Offset = "0x4A5D470", VA = "0x184A5EC70", Slot = "8")]
	public PFLMDAPEOIN<T>.DDGMIKFHDLC GetEnumerator()
	{
		return default(PFLMDAPEOIN<T>.DDGMIKFHDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A5ECC0", Offset = "0x4A5D4C0", VA = "0x184A5ECC0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A5ECC0", Offset = "0x4A5D4C0", VA = "0x184A5ECC0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GCOMBNOPDLG<T, U> : IEnumerable<T>, IEnumerable where U : NHOCBPGMMFP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U PKBMFKKCJJK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2718C30", Offset = "0x2717430", VA = "0x182718C30")]
	internal GCOMBNOPDLG([In] U GDPKJELKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4984B50", Offset = "0x4983350", VA = "0x184984B50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4984B50", Offset = "0x4983350", VA = "0x184984B50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HOGCCLLMBOD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x398ED70", Offset = "0x398D570", VA = "0x18398ED70")]
	public static GCOMBNOPDLG<T, U> CJOJELENPLJ<U>([In] U NFOGFJOGLPE) where U : NHOCBPGMMFP<T>
	{
		return default(GCOMBNOPDLG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JJDIPBMIINF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4DC45A0", Offset = "0x4DC2DA0", VA = "0x184DC45A0")]
	public static PFNCDBFLBAH<T, MHELDIPGLPE<T>> CJOJELENPLJ([In] T[] NFOGFJOGLPE)
	{
		return default(PFNCDBFLBAH<T, MHELDIPGLPE<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PFNCDBFLBAH<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U PKBMFKKCJJK;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5558650", Offset = "0x5556E50", VA = "0x185558650")]
	internal PFNCDBFLBAH([In] U GDPKJELKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x395E070", Offset = "0x395C870", VA = "0x18395E070", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5558190", Offset = "0x5556990", VA = "0x185558190", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5558190", Offset = "0x5556990", VA = "0x185558190", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IGAILJGJMAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x398EDD0", Offset = "0x398D5D0", VA = "0x18398EDD0")]
	public static PFNCDBFLBAH<T, U> CJOJELENPLJ<U>([In] U NFOGFJOGLPE) where U : IEnumerator<T>
	{
		return default(PFNCDBFLBAH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IPODKHAIBMN
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37F55A0", Offset = "0x37F3DA0", VA = "0x1837F55A0")]
	public static PFNCDBFLBAH<TResult, HFOBAGIMFBF<TSourceEnumerator, TSource, TResult>> BBAGOMFFPPN<TResult, TSourceEnumerator, TSource>([In] this PFNCDBFLBAH<TSource, TSourceEnumerator> NFOGFJOGLPE, Func<TSource, TResult> IGHLBLMKLKG) where TSourceEnumerator : MAJMOKHLLLG, IEnumerator<TSource>
	{
		return default(PFNCDBFLBAH<TResult, HFOBAGIMFBF<TSourceEnumerator, TSource, TResult>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MHELDIPGLPE<T> : IEnumerator<T>, IEnumerator, IDisposable, MAJMOKHLLLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly T[] KIDFHDBICMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int AOKFNNGJEBD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly T IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x52082C0", Offset = "0x5206AC0", VA = "0x1852082C0", Slot = "4")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4430110", Offset = "0x442E910", VA = "0x184430110", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xBFDCC0", Offset = "0xBFC4C0", VA = "0x180BFDCC0")]
	private MHELDIPGLPE(T[] NFOGFJOGLPE, int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x442FFE0", Offset = "0x442E7E0", VA = "0x18442FFE0")]
	public static MHELDIPGLPE<T> CJOJELENPLJ(T[] NFOGFJOGLPE)
	{
		return default(MHELDIPGLPE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x275C230", Offset = "0x275AA30", VA = "0x18275C230", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x275C260", Offset = "0x275AA60", VA = "0x18275C260", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HFOBAGIMFBF<TSourceEnumerator, TSource, TResult> : MAJMOKHLLLG, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : MAJMOKHLLLG, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator KIDFHDBICMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> BPMOPBEPBNJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly TResult IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4A45930", Offset = "0x4A44130", VA = "0x184A45930", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4A457D0", Offset = "0x4A43FD0", VA = "0x184A457D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x276E4A0", Offset = "0x276CCA0", VA = "0x18276E4A0")]
	internal HFOBAGIMFBF([In] TSourceEnumerator NFOGFJOGLPE, Func<TSource, TResult> IGHLBLMKLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4A45670", Offset = "0x4A43E70", VA = "0x184A45670", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4A45750", Offset = "0x4A43F50", VA = "0x184A45750", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4861980", Offset = "0x4860180", VA = "0x184861980", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class LGPDEGBLALH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x384ECA0", Offset = "0x384D4A0", VA = "0x18384ECA0")]
	public static string EKEFGIIMADJ<T>(this IEnumerable<T> NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x386FE50", Offset = "0x386E650", VA = "0x18386FE50")]
	public static string LAHCOIOBIDG<T>(this IEnumerable<T> NFOGFJOGLPE, string NAFCEMMIFKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NHBHKHIAAJK
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3928710", Offset = "0x3926F10", VA = "0x183928710")]
	public static bool HLBIGNMFNLC<TSourceEnumerator, TSource>(this TSourceEnumerator NFOGFJOGLPE, [In] TSource BLFLGKHLJNB) where TSourceEnumerator : NHOCBPGMMFP<TSource> where TSource : KMJPBECDOKN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3928890", Offset = "0x3927090", VA = "0x183928890")]
	public static int KGFADKGLDGI<TSourceEnumerator, TSource>(this TSourceEnumerator NFOGFJOGLPE, [In] TSource OPMIAMEJKDH) where TSourceEnumerator : NHOCBPGMMFP<TSource> where TSource : KMJPBECDOKN<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x39286B0", Offset = "0x3926EB0", VA = "0x1839286B0")]
	public static HFOBAGIMFBF<TSourceEnumerator, TSource, TResult> BBAGOMFFPPN<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator NFOGFJOGLPE, Func<TSource, TResult> IGHLBLMKLKG) where TSourceEnumerator : MAJMOKHLLLG, IEnumerator<TSource>
	{
		return default(HFOBAGIMFBF<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3928440", Offset = "0x3926C40", VA = "0x183928440")]
	public static int ADPCBDPCBIA<TSourceEnumerator, TSource>(this TSourceEnumerator NFOGFJOGLPE, [In] TSource OPMIAMEJKDH) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NHOCBPGMMFP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	T IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MAJMOKHLLLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AKIDLFILBLH<T> : NHOCBPGMMFP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct DJDKICBKDPI<T, U> : IEnumerable<T>, IEnumerable where U : AKIDLFILBLH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U PKBMFKKCJJK;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4984C80", Offset = "0x4983480", VA = "0x184984C80")]
	internal DJDKICBKDPI([In] U GDPKJELKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x44ECC00", Offset = "0x44EB400", VA = "0x1844ECC00", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4984BC0", Offset = "0x49833C0", VA = "0x184984BC0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4984BC0", Offset = "0x49833C0", VA = "0x184984BC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JIOOPIPLOMD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x398ED40", Offset = "0x398D540", VA = "0x18398ED40")]
	public static DJDKICBKDPI<T, U> CJOJELENPLJ<U>([In] U NFOGFJOGLPE) where U : AKIDLFILBLH<T>
	{
		return default(DJDKICBKDPI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public readonly struct DADDGNDMECL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct EMILPMKMJGF : MAJMOKHLLLG, NHOCBPGMMFP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] KIDFHDBICMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int AOKFNNGJEBD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x275C1F0", Offset = "0x275A9F0", VA = "0x18275C1F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4430270", Offset = "0x442EA70", VA = "0x184430270", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4430360", Offset = "0x442EB60", VA = "0x184430360", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBFDCC0", Offset = "0xBFC4C0", VA = "0x180BFDCC0")]
		private EMILPMKMJGF(T[] NFOGFJOGLPE, int FPEOONOJHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x442FFE0", Offset = "0x442E7E0", VA = "0x18442FFE0")]
		public static EMILPMKMJGF CJOJELENPLJ(T[] NFOGFJOGLPE)
		{
			return default(EMILPMKMJGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x275C230", Offset = "0x275AA30", VA = "0x18275C230", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x275C260", Offset = "0x275AA60", VA = "0x18275C260", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] JEDIGIACEEB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4DBAE30", Offset = "0x4DB9630", VA = "0x184DBAE30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T EMAHJNALJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x275D6C0", Offset = "0x275BEC0", VA = "0x18275D6C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	internal DADDGNDMECL(T[] CPIDEKBKOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68A2BA0", Offset = "0x68A13A0", VA = "0x1868A2BA0")]
	public static DADDGNDMECL<T> HMAILHHHNAA()
	{
		return default(DADDGNDMECL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
	public IEnumerable<T> LMJEOCEDPGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68A2D10", Offset = "0x68A1510", VA = "0x1868A2D10")]
	public ReadOnlySpan<T> NFKLJBIOMDD()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68A2A70", Offset = "0x68A1270", VA = "0x1868A2A70")]
	public GCOMBNOPDLG<T, DADDGNDMECL<T>.EMILPMKMJGF> HAOGOPPPEGD()
	{
		return default(GCOMBNOPDLG<T, EMILPMKMJGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68A2C70", Offset = "0x68A1470", VA = "0x1868A2C70")]
	public EMILPMKMJGF MNJJAMKEIAA()
	{
		return default(EMILPMKMJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68A29F0", Offset = "0x68A11F0", VA = "0x1868A29F0")]
	public IEnumerator<T> DPNIJJHCOGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68A2DB0", Offset = "0x68A15B0", VA = "0x1868A2DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NBKJKOPNPNP
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x352A9A0", Offset = "0x35291A0", VA = "0x18352A9A0")]
	public static DADDGNDMECL<T> AHFPJPGBHKM<T>(params T[] CPIDEKBKOPO) where T : notnull
	{
		return default(DADDGNDMECL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C49920", Offset = "0x7C48120", VA = "0x187C49920")]
	public static Stream BACNIBMIBOI(this DADDGNDMECL<byte> NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DebuggerTypeProxy(typeof(PFLMDAPEOIN<>.BOOFKPPMGPD))]
public struct PFLMDAPEOIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct DDGMIKFHDLC : MAJMOKHLLLG, AKIDLFILBLH<T>, NHOCBPGMMFP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] MJHBEIAMKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int GKJPMHLNJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int AOKFNNGJEBD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x68C0C40", Offset = "0x68BF440", VA = "0x1868C0C40", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T PEGCFJDDOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x68C0240", Offset = "0x68BEA40", VA = "0x1868C0240")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private readonly T CAIHODKPONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x68C0370", Offset = "0x68BEB70", VA = "0x1868C0370", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x68C0650", Offset = "0x68BEE50", VA = "0x1868C0650", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x68C0AF0", Offset = "0x68BF2F0", VA = "0x1868C0AF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x52CB160", Offset = "0x52C9960", VA = "0x1852CB160")]
		internal DDGMIKFHDLC(T[] ECFHLCJLIHE, int PCFOAHIEPDL, int FPEOONOJHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68C0160", Offset = "0x68BE960", VA = "0x1868C0160")]
		public static DDGMIKFHDLC CJOJELENPLJ(PFLMDAPEOIN<T> NFOGFJOGLPE)
		{
			return default(DDGMIKFHDLC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x449E720", Offset = "0x449CF20", VA = "0x18449E720", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x449D9C0", Offset = "0x449C1C0", VA = "0x18449D9C0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct FCGDBKGLPLM : MAJMOKHLLLG, NHOCBPGMMFP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DDGMIKFHDLC PKBMFKKCJJK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4861E80", Offset = "0x4860680", VA = "0x184861E80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4861B30", Offset = "0x4860330", VA = "0x184861B30", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4861CB0", Offset = "0x48604B0", VA = "0x184861CB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2718C30", Offset = "0x2717430", VA = "0x182718C30")]
		private FCGDBKGLPLM([In] DDGMIKFHDLC GDPKJELKNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x48618D0", Offset = "0x48600D0", VA = "0x1848618D0")]
		public static FCGDBKGLPLM CJOJELENPLJ([In] PFLMDAPEOIN<T> NFOGFJOGLPE)
		{
			return default(FCGDBKGLPLM);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x48619C0", Offset = "0x48601C0", VA = "0x1848619C0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4861A00", Offset = "0x4860200", VA = "0x184861A00", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4861980", Offset = "0x4860180", VA = "0x184861980", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class BOOFKPPMGPD
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] MJHBEIAMKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int GKJPMHLNJMF;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5557F40", Offset = "0x5556740", VA = "0x185557F40")]
	public static PFLMDAPEOIN<T> CJOJELENPLJ()
	{
		return default(PFLMDAPEOIN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5557FF0", Offset = "0x55567F0", VA = "0x185557FF0")]
	public static PFLMDAPEOIN<T> GENPDCCDBHG(int CFHPBCCHEDC)
	{
		return default(PFLMDAPEOIN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xBFDCC0", Offset = "0xBFC4C0", VA = "0x180BFDCC0")]
	internal PFLMDAPEOIN(T[] ECFHLCJLIHE, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x55580B0", Offset = "0x55568B0", VA = "0x1855580B0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class MBHKHJNOBIC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate int GAGDLFFNLJJ<TCtx, T>([In] TCtx NKNKDPDDMGK, T ANGFJALIIBO, T LNEMONKDKMJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x38B1A70", Offset = "0x38B0270", VA = "0x1838B1A70")]
	public static void KNAKPKDGKOD<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x38A9100", Offset = "0x38A7900", VA = "0x1838A9100")]
	public static string DCHNCIDKHNC<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
	public static T[] BJINPPHAJAN<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x360E4C0", Offset = "0x360CCC0", VA = "0x18360E4C0")]
	public static T EFPADONOPCC<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE, int JEGIFICJAGL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x38A8EB0", Offset = "0x38A76B0", VA = "0x1838A8EB0")]
	public static T CMKEOGMMGKL<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int JEGIFICJAGL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x38A8D20", Offset = "0x38A7520", VA = "0x1838A8D20")]
	public static T BICFLLJOOMC<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE, int JEGIFICJAGL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x38A6250", Offset = "0x38A4A50", VA = "0x1838A6250")]
	public static void AFOHMCJECDO<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int JEGIFICJAGL, [In] T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x38A6250", Offset = "0x38A4A50", VA = "0x1838A6250")]
	public static void ICLKMGHLDHD<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int JEGIFICJAGL, T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xD87030", Offset = "0xD85830", VA = "0x180D87030")]
	public static int GFDFFPIHKCJ<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x38B2000", Offset = "0x38B0800", VA = "0x1838B2000")]
	public static ReadOnlySpan<T> NFKLJBIOMDD<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x38B1C30", Offset = "0x38B0430", VA = "0x1838B1C30")]
	public static T[] LDDBBILOKCM<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x38B0F50", Offset = "0x38AF750", VA = "0x1838B0F50")]
	public static T JEILBIEPAEM<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x38B22A0", Offset = "0x38B0AA0", VA = "0x1838B22A0")]
	public static T[] OBMPAAPDAFO<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x38B0F90", Offset = "0x38AF790", VA = "0x1838B0F90")]
	public static DADDGNDMECL<T> JGLHHECOBDP<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return default(DADDGNDMECL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x38B2350", Offset = "0x38B0B50", VA = "0x1838B2350")]
	public static void OIHLAKEIFNH<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, [In] T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x38B10C0", Offset = "0x38AF8C0", VA = "0x1838B10C0")]
	public static void JOEBGBCNDOO<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38B0690", Offset = "0x38AEE90", VA = "0x1838B0690")]
	public static void DIKHLCLGBEB<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int FPEOONOJHML, [In] T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38A60B0", Offset = "0x38A48B0", VA = "0x1838A60B0")]
	public static void ACMAGAFKFFC<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int FPEOONOJHML, [In] PFLMDAPEOIN<T> MGEDIIGJIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x38B0800", Offset = "0x38AF000", VA = "0x1838B0800")]
	public static void DKCFACCBDDC<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int FPEOONOJHML, T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x38B1FC0", Offset = "0x38B07C0", VA = "0x1838B1FC0")]
	public static void MPKPFGMPGFE<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x38A90A0", Offset = "0x38A78A0", VA = "0x1838A90A0")]
	public static T DAOLIIPIBGF<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x38ADD70", Offset = "0x38AC570", VA = "0x1838ADD70")]
	public static void DDNAALJBFBE<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x38A6AB0", Offset = "0x38A52B0", VA = "0x1838A6AB0")]
	private static void BCFNJBPBPNN<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, int CFHPBCCHEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x38B2190", Offset = "0x38B0990", VA = "0x1838B2190")]
	public static void NNEMBDPLFBE<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x38B1D60", Offset = "0x38B0560", VA = "0x1838B1D60")]
	public static PFLMDAPEOIN<T> LMNLEEHCNJH<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE, JNHEFCFBDAL<T, T> FBPFFMONOIN)
	{
		return default(PFLMDAPEOIN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x38A6910", Offset = "0x38A5110", VA = "0x1838A6910")]
	public static bool AHELLINFOCL<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, T OPMIAMEJKDH) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x38B19A0", Offset = "0x38B01A0", VA = "0x1838B19A0")]
	public static bool KIIOJCHJOOP<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE, [In] T OPMIAMEJKDH) where T : KMJPBECDOKN<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x377CF50", Offset = "0x377B750", VA = "0x18377CF50")]
	public static bool AFPBFKGMNNM<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x38B1060", Offset = "0x38AF860", VA = "0x1838B1060")]
	public static bool JNBKPNHIBOF<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE, int JEGIFICJAGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x38B0960", Offset = "0x38AF160", VA = "0x1838B0960")]
	public static void FPJPMKNKAKC<T, TCtx>(this PFLMDAPEOIN<T> NFOGFJOGLPE, [In] TCtx NKNKDPDDMGK, GAGDLFFNLJJ<TCtx, T> OOEOMACGGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x38B09B0", Offset = "0x38AF1B0", VA = "0x1838B09B0")]
	private static void HKOLANJDDJC<T, TCtx>(PFLMDAPEOIN<T> NFOGFJOGLPE, [In] TCtx NKNKDPDDMGK, GAGDLFFNLJJ<TCtx, T> OOEOMACGGON, int LONCHBAHLLI, int GPGJOBIOAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x38B1300", Offset = "0x38AFB00", VA = "0x1838B1300")]
	private static int JPMGLABAGJL<T, TCtx>(PFLMDAPEOIN<T> NFOGFJOGLPE, [In] TCtx NKNKDPDDMGK, GAGDLFFNLJJ<TCtx, T> OOEOMACGGON, int LONCHBAHLLI, int GPGJOBIOAOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x360DCA0", Offset = "0x360C4A0", VA = "0x18360DCA0")]
	public static PFLMDAPEOIN<T>.FCGDBKGLPLM DPNIJJHCOGM<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return default(PFLMDAPEOIN<T>.FCGDBKGLPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x360DCA0", Offset = "0x360C4A0", VA = "0x18360DCA0")]
	public static PFLMDAPEOIN<T>.DDGMIKFHDLC KHILFOIOJHH<T>(this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return default(PFLMDAPEOIN<T>.DDGMIKFHDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x38B0EC0", Offset = "0x38AF6C0", VA = "0x1838B0EC0")]
	public static GCOMBNOPDLG<T, PFLMDAPEOIN<T>.FCGDBKGLPLM> IMMJCGFCONH<T>([In] this PFLMDAPEOIN<T> NFOGFJOGLPE)
	{
		return default(GCOMBNOPDLG<T, PFLMDAPEOIN<T>.FCGDBKGLPLM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class NJFMLMNJEGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x392A9B0", Offset = "0x39291B0", VA = "0x18392A9B0")]
	public static T[] ILAMACMMPGB<T>(int LBLAFDELPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	public static void DOJAPBKLPAK<T>(T[] CPIDEKBKOPO)
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
