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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CB490", Offset = "0x85C9A90", VA = "0x1885CB490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DFJMJNEGAGN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B310", Offset = "0x3B09910", VA = "0x183B0B310")]
	public static MKOKAOLNOHA<T> DCNIIEMDAHA<T>(this T[] CCKLBDLJPNG) where T : notnull
	{
		return default(MKOKAOLNOHA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1F00", Offset = "0x3BD0500", VA = "0x183BD1F00")]
	public static MKBNAJJCKEF<T, JNMDFDBJMCH<T>> HBPMEPGLEPB<T>(this T[] CCKLBDLJPNG) where T : notnull
	{
		return default(MKBNAJJCKEF<T, JNMDFDBJMCH<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class GKCGBMEPCDG<T> : IDisposable, OBHLADEMEOE, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OEFGLPCMBJB<T> KHLLEJJMKOB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4AA0", Offset = "0x4FF30A0", VA = "0x184FF4AA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4B60", Offset = "0x4FF3160", VA = "0x184FF4B60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4980", Offset = "0x4FF2F80", VA = "0x184FF4980")]
	public static GKCGBMEPCDG<T> BPFPEFLIIPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A56ED0", Offset = "0x4A554D0", VA = "0x184A56ED0")]
	internal GKCGBMEPCDG([In] OEFGLPCMBJB<T> FCFHEFKEJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4AD0", Offset = "0x4FF30D0", VA = "0x184FF4AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4AF0", Offset = "0x4FF30F0", VA = "0x184FF4AF0")]
	public void GJNIBOMLGDG(int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4B10", Offset = "0x4FF3110", VA = "0x184FF4B10", Slot = "8")]
	public OEFGLPCMBJB<T>.PLDMENGECKP GetEnumerator()
	{
		return default(OEFGLPCMBJB<T>.PLDMENGECKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4B90", Offset = "0x4FF3190", VA = "0x184FF4B90", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4B90", Offset = "0x4FF3190", VA = "0x184FF4B90", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct EIOAKAOMPMD<T, U> : IEnumerable<T>, IEnumerable where U : AADNMGDOCCH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U BLKIFPDMICE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1286560", Offset = "0x1284B60", VA = "0x181286560")]
	internal EIOAKAOMPMD([In] U NNLAAMJMCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4A80E00", Offset = "0x4A7F400", VA = "0x184A80E00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4A80E00", Offset = "0x4A7F400", VA = "0x184A80E00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EOPAJPIAFDL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4214F00", Offset = "0x4213500", VA = "0x184214F00")]
	public static EIOAKAOMPMD<T, U> BPFPEFLIIPC<U>([In] U CCKLBDLJPNG) where U : AADNMGDOCCH<T>
	{
		return default(EIOAKAOMPMD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IIPMEAKPDBA
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3E11760", Offset = "0x3E0FD60", VA = "0x183E11760")]
	public static int DGBEIHMBLFP<T, U>([In] this EIOAKAOMPMD<T, U> CCKLBDLJPNG) where U : AADNMGDOCCH<T>, OBHLADEMEOE
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MNPCJOIFNJA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5981230", Offset = "0x597F830", VA = "0x185981230")]
	public static MKBNAJJCKEF<T, JNMDFDBJMCH<T>> BPFPEFLIIPC([In] T[] CCKLBDLJPNG)
	{
		return default(MKBNAJJCKEF<T, JNMDFDBJMCH<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MKBNAJJCKEF<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U BLKIFPDMICE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2DF36E0", Offset = "0x2DF1CE0", VA = "0x182DF36E0")]
	internal MKBNAJJCKEF([In] U NNLAAMJMCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5672950", Offset = "0x5670F50", VA = "0x185672950", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5971370", Offset = "0x596F970", VA = "0x185971370", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5971370", Offset = "0x596F970", VA = "0x185971370", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BLDKHDLOKAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4214E50", Offset = "0x4213450", VA = "0x184214E50")]
	public static MKBNAJJCKEF<T, U> BPFPEFLIIPC<U>([In] U CCKLBDLJPNG) where U : IEnumerator<T>
	{
		return default(MKBNAJJCKEF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HAFJLICBCDE
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5220", Offset = "0x3DB3820", VA = "0x183DB5220")]
	public static MKBNAJJCKEF<TResult, BBNJPLJKNAK<TSourceEnumerator, TSource, TResult>> IHCFHPBAPON<TResult, TSourceEnumerator, TSource>([In] this MKBNAJJCKEF<TSource, TSourceEnumerator> CCKLBDLJPNG, Func<TSource, TResult> OOPPPDLPPFP) where TSourceEnumerator : OBHLADEMEOE, IEnumerator<TSource>
	{
		return default(MKBNAJJCKEF<TResult, BBNJPLJKNAK<TSourceEnumerator, TSource, TResult>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JNMDFDBJMCH<T> : IEnumerator<T>, IEnumerator, IDisposable, OBHLADEMEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly T[] HICCGOLOAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int CBJBFOFELBF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly T MKKCMPLEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x54FAC10", Offset = "0x54F9210", VA = "0x1854FAC10", Slot = "4")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x54FABC0", Offset = "0x54F91C0", VA = "0x1854FABC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AEECA0", Offset = "0x2AED2A0", VA = "0x182AEECA0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xDAFA90", Offset = "0xDAE090", VA = "0x180DAFA90")]
	private JNMDFDBJMCH(T[] CCKLBDLJPNG, int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4F4B600", Offset = "0x4F49C00", VA = "0x184F4B600")]
	public static JNMDFDBJMCH<T> BPFPEFLIIPC(T[] CCKLBDLJPNG)
	{
		return default(JNMDFDBJMCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2AEECC0", Offset = "0x2AED2C0", VA = "0x182AEECC0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2AED070", Offset = "0x2AEB670", VA = "0x182AED070", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BBNJPLJKNAK<TSourceEnumerator, TSource, TResult> : OBHLADEMEOE, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : OBHLADEMEOE, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator HICCGOLOAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> AKLIEOLIPII;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6788F10", Offset = "0x6787510", VA = "0x186788F10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult MKKCMPLEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6789260", Offset = "0x6787860", VA = "0x186789260", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67890C0", Offset = "0x67876C0", VA = "0x1867890C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B063C0", Offset = "0x2B049C0", VA = "0x182B063C0")]
	internal BBNJPLJKNAK([In] TSourceEnumerator CCKLBDLJPNG, Func<TSource, TResult> OOPPPDLPPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6788FA0", Offset = "0x67875A0", VA = "0x186788FA0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6789080", Offset = "0x6787680", VA = "0x186789080", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4F47820", Offset = "0x4F45E20", VA = "0x184F47820", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class AGOJLICPDAE
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32A6BA0", Offset = "0x32A51A0", VA = "0x1832A6BA0")]
	public static string MGIKDMJHAPH<T>(this IEnumerable<T> CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32AACF0", Offset = "0x32A92F0", VA = "0x1832AACF0")]
	public static string NOGBKJAEDBJ<T>(this IEnumerable<T> CCKLBDLJPNG, string HJHCFNGAHNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EFIKKMJIIDL
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C0AD10", Offset = "0x3C09310", VA = "0x183C0AD10")]
	public static bool MAMOGNMDPGN<TSourceEnumerator, TSource>(this TSourceEnumerator CCKLBDLJPNG, [In] TSource KGKOGFAMIIC) where TSourceEnumerator : AADNMGDOCCH<TSource> where TSource : CFFKDHOLKHH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3C0AA50", Offset = "0x3C09050", VA = "0x183C0AA50")]
	public static int CIHPDEDPIBK<TSourceEnumerator, TSource>(this TSourceEnumerator CCKLBDLJPNG, [In] TSource FKMNCAKIOFK) where TSourceEnumerator : AADNMGDOCCH<TSource> where TSource : CFFKDHOLKHH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C0ACB0", Offset = "0x3C092B0", VA = "0x183C0ACB0")]
	public static BBNJPLJKNAK<TSourceEnumerator, TSource, TResult> IHCFHPBAPON<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator CCKLBDLJPNG, Func<TSource, TResult> OOPPPDLPPFP) where TSourceEnumerator : OBHLADEMEOE, IEnumerator<TSource>
	{
		return default(BBNJPLJKNAK<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C0AE90", Offset = "0x3C09490", VA = "0x183C0AE90")]
	public static int PEGGPFOCEHN<TSourceEnumerator, TSource>(this TSourceEnumerator CCKLBDLJPNG, [In] TSource FKMNCAKIOFK) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AADNMGDOCCH<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T MKKCMPLEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OBHLADEMEOE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EDGBAGKGCHJ<T> : AADNMGDOCCH<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct IDMJJNOIFFF<T, U> : IEnumerable<T>, IEnumerable where U : EDGBAGKGCHJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U BLKIFPDMICE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x45A3140", Offset = "0x45A1740", VA = "0x1845A3140")]
	internal IDMJJNOIFFF([In] U NNLAAMJMCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EEC0", Offset = "0x4A7D4C0", VA = "0x184A7EEC0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A80E80", Offset = "0x4A7F480", VA = "0x184A80E80", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A80E80", Offset = "0x4A7F480", VA = "0x184A80E80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OGIANGDPCHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4214E80", Offset = "0x4213480", VA = "0x184214E80")]
	public static IDMJJNOIFFF<T, U> BPFPEFLIIPC<U>([In] U CCKLBDLJPNG) where U : EDGBAGKGCHJ<T>
	{
		return default(IDMJJNOIFFF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct MKOKAOLNOHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct KPMFHAHNKBJ : OBHLADEMEOE, AADNMGDOCCH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] HICCGOLOAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int CBJBFOFELBF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int DGBEIHMBLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2AEECA0", Offset = "0x2AED2A0", VA = "0x182AEECA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x560D350", Offset = "0x560B950", VA = "0x18560D350", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x560CD20", Offset = "0x560B320", VA = "0x18560CD20", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x560D1B0", Offset = "0x560B7B0", VA = "0x18560D1B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDAFA90", Offset = "0xDAE090", VA = "0x180DAFA90")]
		private KPMFHAHNKBJ(T[] CCKLBDLJPNG, int LEPAEEGOBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4F4B600", Offset = "0x4F49C00", VA = "0x184F4B600")]
		public static KPMFHAHNKBJ BPFPEFLIIPC(T[] CCKLBDLJPNG)
		{
			return default(KPMFHAHNKBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2AEECC0", Offset = "0x2AED2C0", VA = "0x182AEECC0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2AED070", Offset = "0x2AEB670", VA = "0x182AED070", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] PGJHMFCHFJG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2AEECA0", Offset = "0x2AED2A0", VA = "0x182AEECA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C13E90", Offset = "0x3C12490", VA = "0x183C13E90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
	internal MKOKAOLNOHA(T[] OHHBFAGELLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x59719C0", Offset = "0x596FFC0", VA = "0x1859719C0")]
	public static MKOKAOLNOHA<T> KBCDDOOGPEK()
	{
		return default(MKOKAOLNOHA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
	public IEnumerable<T> FDNONDOBJDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5971A80", Offset = "0x5970080", VA = "0x185971A80")]
	public ReadOnlySpan<T> NLBMKHIOOMI()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x59718A0", Offset = "0x596FEA0", VA = "0x1859718A0")]
	public EIOAKAOMPMD<T, MKOKAOLNOHA<T>.KPMFHAHNKBJ> GLEJHGDCOOA()
	{
		return default(EIOAKAOMPMD<T, KPMFHAHNKBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5971B10", Offset = "0x5970110", VA = "0x185971B10")]
	public KPMFHAHNKBJ OGCOPAAGOCB()
	{
		return default(KPMFHAHNKBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5971820", Offset = "0x596FE20", VA = "0x185971820")]
	public IEnumerator<T> DKMCAGKLCHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5971BA0", Offset = "0x59701A0", VA = "0x185971BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PINGJJGDDEB
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE2090", Offset = "0x3DE0690", VA = "0x183DE2090")]
	public static MKOKAOLNOHA<T> IEFLANDLIJL<T>(params T[] OHHBFAGELLA) where T : notnull
	{
		return default(MKOKAOLNOHA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85CB510", Offset = "0x85C9B10", VA = "0x1885CB510")]
	public static Stream HLAHDAJNFLL(this MKOKAOLNOHA<byte> CCKLBDLJPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DebuggerTypeProxy(typeof(OEFGLPCMBJB<>.DBNENDHHHPI))]
public struct OEFGLPCMBJB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct PLDMENGECKP : OBHLADEMEOE, EDGBAGKGCHJ<T>, AADNMGDOCCH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] PACNNEDLBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int DKFIGKGBCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int CBJBFOFELBF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int DGBEIHMBLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xF4F310", Offset = "0xF4D910", VA = "0x180F4F310", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5C80300", Offset = "0x5C7E900", VA = "0x185C80300", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly T FDDIFIGCPPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5C7F9A0", Offset = "0x5C7DFA0", VA = "0x185C7F9A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private readonly T LFJMPPEAPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5C7FB70", Offset = "0x5C7E170", VA = "0x185C7FB70", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5C7FD30", Offset = "0x5C7E330", VA = "0x185C7FD30", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5C800E0", Offset = "0x5C7E6E0", VA = "0x185C800E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4F23D90", Offset = "0x4F22390", VA = "0x184F23D90")]
		internal PLDMENGECKP(T[] HLOMEJLEMOF, int FEEKNNBMJMM, int LEPAEEGOBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5C7FA20", Offset = "0x5C7E020", VA = "0x185C7FA20")]
		public static PLDMENGECKP BPFPEFLIIPC(OEFGLPCMBJB<T> CCKLBDLJPNG)
		{
			return default(PLDMENGECKP);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4B0D040", Offset = "0x4B0B640", VA = "0x184B0D040", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4B08C20", Offset = "0x4B07220", VA = "0x184B08C20", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct FKEFPGMHPKD : OBHLADEMEOE, AADNMGDOCCH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PLDMENGECKP BLKIFPDMICE;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int DGBEIHMBLFP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4F477F0", Offset = "0x4F45DF0", VA = "0x184F477F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public readonly T MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4F47D60", Offset = "0x4F46360", VA = "0x184F47D60", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4F479F0", Offset = "0x4F45FF0", VA = "0x184F479F0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4F47A30", Offset = "0x4F46030", VA = "0x184F47A30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1286560", Offset = "0x1284B60", VA = "0x181286560")]
		private FKEFPGMHPKD([In] PLDMENGECKP NNLAAMJMCJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4F47740", Offset = "0x4F45D40", VA = "0x184F47740")]
		public static FKEFPGMHPKD BPFPEFLIIPC([In] OEFGLPCMBJB<T> CCKLBDLJPNG)
		{
			return default(FKEFPGMHPKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4F47860", Offset = "0x4F45E60", VA = "0x184F47860", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F478A0", Offset = "0x4F45EA0", VA = "0x184F478A0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4F47820", Offset = "0x4F45E20", VA = "0x184F47820", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class DBNENDHHHPI
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] PACNNEDLBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int DKFIGKGBCDJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EE50", Offset = "0x5B3D450", VA = "0x185B3EE50")]
	public static OEFGLPCMBJB<T> BPFPEFLIIPC()
	{
		return default(OEFGLPCMBJB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EEF0", Offset = "0x5B3D4F0", VA = "0x185B3EEF0")]
	public static OEFGLPCMBJB<T> MPCPABNEKLA(int FAALOCBOHHG)
	{
		return default(OEFGLPCMBJB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xDAFA90", Offset = "0xDAE090", VA = "0x180DAFA90")]
	internal OEFGLPCMBJB(T[] HLOMEJLEMOF, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EFA0", Offset = "0x5B3D5A0", VA = "0x185B3EFA0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EMIPDFEAIGN
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate int OHBFKMJFNFA<TCtx, T>([In] TCtx KOPCCOFFNGJ, T KNPHEACNGDK, T IMDBLBCMEAE);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3C19000", Offset = "0x3C17600", VA = "0x183C19000")]
	public static void LOMEBHIDOPA<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3C19110", Offset = "0x3C17710", VA = "0x183C19110")]
	public static string NCGHALJNDLK<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
	public static T[] MPKDCNAHPEB<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C13E90", Offset = "0x3C12490", VA = "0x183C13E90")]
	public static T JLOHDPKHFGN<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG, int JFOIDEBHAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3C13E90", Offset = "0x3C12490", VA = "0x183C13E90")]
	public static T COPAPLIALMM<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int JFOIDEBHAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C175E0", Offset = "0x3C15BE0", VA = "0x183C175E0")]
	public static T HMLEHHCICAD<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG, int JFOIDEBHAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C13170", Offset = "0x3C11770", VA = "0x183C13170")]
	public static void ADPGIIFDGLO<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int JFOIDEBHAAF, [In] T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3C17840", Offset = "0x3C15E40", VA = "0x183C17840")]
	public static void IPHDMPBDCEI<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int JFOIDEBHAAF, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xF4F310", Offset = "0xF4D910", VA = "0x180F4F310")]
	public static int BPLOMJHLMEH<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E2D0", Offset = "0x3C1C8D0", VA = "0x183C1E2D0")]
	public static ReadOnlySpan<T> NLBMKHIOOMI<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3C13B80", Offset = "0x3C12180", VA = "0x183C13B80")]
	public static T[] CCAFPDKFHCH<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3C144D0", Offset = "0x3C12AD0", VA = "0x183C144D0")]
	public static T EBHOKHKBNLK<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3C17560", Offset = "0x3C15B60", VA = "0x183C17560")]
	public static T[] HLDHGHBCLLD<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C183F0", Offset = "0x3C169F0", VA = "0x183C183F0")]
	public static MKOKAOLNOHA<T> KGGEELFIBHA<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return default(MKOKAOLNOHA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C188D0", Offset = "0x3C16ED0", VA = "0x183C188D0")]
	public static void KMLBEHGKDFG<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, [In] T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C14600", Offset = "0x3C12C00", VA = "0x183C14600")]
	public static void FEGKHPINBJH<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3C18E20", Offset = "0x3C17420", VA = "0x183C18E20")]
	public static void LIJOICNDJHE<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int LEPAEEGOBDO, [In] T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3C13DF0", Offset = "0x3C123F0", VA = "0x183C13DF0")]
	public static void CFDFHDLEKJD<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int LEPAEEGOBDO, [In] OEFGLPCMBJB<T> DMJEPOICLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3C13A50", Offset = "0x3C12050", VA = "0x183C13A50")]
	public static void CBEIJKBICMK<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int LEPAEEGOBDO, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3C14260", Offset = "0x3C12860", VA = "0x183C14260")]
	public static void DGHIAJCJCEN<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E3A0", Offset = "0x3C1C9A0", VA = "0x183C1E3A0")]
	public static T OMLFANMKPPG<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3C148D0", Offset = "0x3C12ED0", VA = "0x183C148D0")]
	public static void GJNIBOMLGDG<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1C5E0", Offset = "0x3C1ABE0", VA = "0x183C1C5E0")]
	private static void NHAMKNJJIHA<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, int FAALOCBOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E400", Offset = "0x3C1CA00", VA = "0x183C1E400")]
	public static void OOIGDCNPPFG<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3C17F60", Offset = "0x3C16560", VA = "0x183C17F60")]
	public static OEFGLPCMBJB<T> JJDCBGIHCCL<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG, JGMNCJFOLDK<T, T> AAHNIHIEOKC)
	{
		return default(OEFGLPCMBJB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3C142D0", Offset = "0x3C128D0", VA = "0x183C142D0")]
	public static int DLADLDAEKLN<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG, T FKMNCAKIOFK) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x33685B0", Offset = "0x3366BB0", VA = "0x1833685B0")]
	public static bool DIIFLEHJKPJ<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG, T FKMNCAKIOFK) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3C17440", Offset = "0x3C15A40", VA = "0x183C17440")]
	public static bool HCDNAOEAAEJ<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, T FKMNCAKIOFK) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3C144F0", Offset = "0x3C12AF0", VA = "0x183C144F0")]
	public static bool EDHLGKMMCMC<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG, [In] T FKMNCAKIOFK) where T : CFFKDHOLKHH<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3C13A40", Offset = "0x3C12040", VA = "0x183C13A40")]
	public static bool AFNNFFJLAHK<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C183B0", Offset = "0x3C169B0", VA = "0x183C183B0")]
	public static bool KEIELFOLEGI<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG, int JFOIDEBHAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3C142A0", Offset = "0x3C128A0", VA = "0x183C142A0")]
	public static void DJCFOPBDIGI<T, TCtx>(this OEFGLPCMBJB<T> CCKLBDLJPNG, [In] TCtx KOPCCOFFNGJ, OHBFKMJFNFA<TCtx, T> ABIDFLAFBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3C141A0", Offset = "0x3C127A0", VA = "0x183C141A0")]
	private static void DCBDDLBDOFB<T, TCtx>(OEFGLPCMBJB<T> CCKLBDLJPNG, [In] TCtx KOPCCOFFNGJ, OHBFKMJFNFA<TCtx, T> ABIDFLAFBOG, int NMNCEDAPOKF, int LFCLENOKFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C18480", Offset = "0x3C16A80", VA = "0x183C18480")]
	private static int KHODKENPPKI<T, TCtx>(OEFGLPCMBJB<T> CCKLBDLJPNG, [In] TCtx KOPCCOFFNGJ, OHBFKMJFNFA<TCtx, T> ABIDFLAFBOG, int NMNCEDAPOKF, int LFCLENOKFJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F5F0", Offset = "0x3B0DBF0", VA = "0x183B0F5F0")]
	public static OEFGLPCMBJB<T>.FKEFPGMHPKD DKMCAGKLCHH<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return default(OEFGLPCMBJB<T>.FKEFPGMHPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B0F5F0", Offset = "0x3B0DBF0", VA = "0x183B0F5F0")]
	public static OEFGLPCMBJB<T>.PLDMENGECKP FLJBNHKJGBK<T>(this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return default(OEFGLPCMBJB<T>.PLDMENGECKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C14590", Offset = "0x3C12B90", VA = "0x183C14590")]
	public static EIOAKAOMPMD<T, OEFGLPCMBJB<T>.FKEFPGMHPKD> ENKLIADBNOG<T>([In] this OEFGLPCMBJB<T> CCKLBDLJPNG)
	{
		return default(EIOAKAOMPMD<T, OEFGLPCMBJB<T>.FKEFPGMHPKD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class JJJLMHPMJEA
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3E385C0", Offset = "0x3E36BC0", VA = "0x183E385C0")]
	public static T[] GJFIFHEEEFJ<T>(int MLMBLBFOLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	public static void AGEIDLOONDG<T>(T[] OHHBFAGELLA)
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
