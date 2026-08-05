using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F31BC0", Offset = "0x6F303C0", VA = "0x186F31BC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NLFHJMNEADI<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T PDEEINOIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class DIOEBHIEODK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3075A10", Offset = "0x3074210", VA = "0x183075A10")]
	public static string BMAEGLAOLPG<T>(this IEnumerable<T> PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3077B10", Offset = "0x3076310", VA = "0x183077B10")]
	public static string DNLFPADLBHI<T>(this IEnumerable<T> PECDBPPMOJP, string BLKFGEJPHCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MFCPJMDLKCI<T, U> : IEnumerable<T>, IEnumerable where U : MNLNNJOBLJG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U OFKABHEMFHH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2110040", Offset = "0x210E840", VA = "0x182110040")]
	internal MFCPJMDLKCI(in U EAIMLCNINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1AB0840", Offset = "0x1AAF040", VA = "0x181AB0840", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x210FF00", Offset = "0x210E700", VA = "0x18210FF00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x210FF00", Offset = "0x210E700", VA = "0x18210FF00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FBODDHEBEHN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F623F0", Offset = "0x1F60BF0", VA = "0x181F623F0")]
	public static MFCPJMDLKCI<T, U> NKAIHPJAMOL<U>(in U PECDBPPMOJP) where U : MNLNNJOBLJG<T>
	{
		return default(MFCPJMDLKCI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JBPFLCJENFH
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x111C330", Offset = "0x111AB30", VA = "0x18111C330")]
	public static bool HDCOALKHOCA<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator PECDBPPMOJP, in TArgs HPDOEALAHJH, in IOPIMNFAOPF<TArgs, TSource, bool> PLKOLLLEBGA) where TSourceEnumerator : NLFHJMNEADI<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x111CB20", Offset = "0x111B320", VA = "0x18111CB20")]
	public static int LGCAIDLGGNP<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator PECDBPPMOJP, in TArgs HPDOEALAHJH, IOPIMNFAOPF<TArgs, TSource, bool> PLKOLLLEBGA) where TSourceEnumerator : NLFHJMNEADI<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x111CDD0", Offset = "0x111B5D0", VA = "0x18111CDD0")]
	public static bool OJCAFDKKDGN<TSourceEnumerator, TSource>(this TSourceEnumerator PECDBPPMOJP, in TSource AMBKJGJJFNP) where TSourceEnumerator : NLFHJMNEADI<TSource> where TSource : PKABNOGAKFM<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x111C7D0", Offset = "0x111AFD0", VA = "0x18111C7D0")]
	public static int KCPHCCLEMKL<TSourceEnumerator, TSource>(this TSourceEnumerator PECDBPPMOJP, in TSource MENBIMCLIOI) where TSourceEnumerator : NLFHJMNEADI<TSource> where TSource : PKABNOGAKFM<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x111C2A0", Offset = "0x111AAA0", VA = "0x18111C2A0")]
	public static JKABJAFPLBG<TSourceEnumerator, TSource, TResult> LJLIFOCDGNF<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator PECDBPPMOJP, HLGLPMPGPPG<TSource, TResult> PDGKFCFIMKC) where TSourceEnumerator : OHMFGEGKJKK, NLFHJMNEADI<TSource>
	{
		return default(JKABJAFPLBG<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x111C2A0", Offset = "0x111AAA0", VA = "0x18111C2A0")]
	public static NCBJIKHEJMI<TSourceEnumerator, TSource, TResult> GPBDAKPOOOJ<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator PECDBPPMOJP, Func<TSource, TResult> PDGKFCFIMKC) where TSourceEnumerator : OHMFGEGKJKK, IEnumerator<TSource>
	{
		return default(NCBJIKHEJMI<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LCIGOKFHIIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3777FC0", Offset = "0x37767C0", VA = "0x183777FC0")]
	public static bool JFNLIPADMFB<TSourceEnumerator>(TSourceEnumerator PECDBPPMOJP) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37780D0", Offset = "0x37768D0", VA = "0x1837780D0")]
	public static T LPCJJGKAGPL<TSourceEnumerator>(TSourceEnumerator PECDBPPMOJP) where TSourceEnumerator : NLFHJMNEADI<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2D651C0", Offset = "0x2D639C0", VA = "0x182D651C0")]
	public static T[] CCHDFJGPIKB<TSourceEnumerator>(TSourceEnumerator PECDBPPMOJP) where TSourceEnumerator : OHMFGEGKJKK, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3778350", Offset = "0x3776B50", VA = "0x183778350")]
	public static T NHEODIKPGFL<TSourceEnumerator>(TSourceEnumerator PECDBPPMOJP) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct DFJMAOKIJCE<T, U> : IEnumerable<T>, IEnumerable where U : NLFHJMNEADI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U OFKABHEMFHH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	internal DFJMAOKIJCE(in U EAIMLCNINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x210FF90", Offset = "0x210E790", VA = "0x18210FF90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x210FF90", Offset = "0x210E790", VA = "0x18210FF90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GIEFCDNAKEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F623C0", Offset = "0x1F60BC0", VA = "0x181F623C0")]
	public static DFJMAOKIJCE<T, U> NKAIHPJAMOL<U>(in U PECDBPPMOJP) where U : NLFHJMNEADI<T>
	{
		return default(DFJMAOKIJCE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct GBHIAEEONNH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JIFFENLBKPA : OHMFGEGKJKK, NLFHJMNEADI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] LEFIMNMECDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int DKNGOBLBOBI;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int GKGAEPJBJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x23ADF60", Offset = "0x23AC760", VA = "0x1823ADF60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2C53C80", Offset = "0x2C52480", VA = "0x182C53C80", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2C536E0", Offset = "0x2C51EE0", VA = "0x182C536E0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2C53A70", Offset = "0x2C52270", VA = "0x182C53A70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xBCBB10", Offset = "0xBCA310", VA = "0x180BCBB10")]
		private JIFFENLBKPA(T[] PECDBPPMOJP, int AMOEKOMGDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2C53610", Offset = "0x2C51E10", VA = "0x182C53610")]
		public static JIFFENLBKPA NKAIHPJAMOL(T[] PECDBPPMOJP)
		{
			return default(JIFFENLBKPA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2C535E0", Offset = "0x2C51DE0", VA = "0x182C535E0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2C53660", Offset = "0x2C51E60", VA = "0x182C53660", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly T[] AAOCPBGNLKE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EGAMNLBINDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x23ADF60", Offset = "0x23AC760", VA = "0x1823ADF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CA1530", Offset = "0x1C9FD30", VA = "0x181CA1530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	internal GBHIAEEONNH(T[] DLLMPOAIBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E79F00", Offset = "0x2E78700", VA = "0x182E79F00")]
	public static GBHIAEEONNH<T> GMPFDGPOJIJ()
	{
		return default(GBHIAEEONNH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
	public IEnumerable<T> NPKOLIGLOEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2E79FB0", Offset = "0x2E787B0", VA = "0x182E79FB0")]
	public ReadOnlySpan<T> MKJIPCCAMOD()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2E79CD0", Offset = "0x2E784D0", VA = "0x182E79CD0")]
	public DFJMAOKIJCE<T, GBHIAEEONNH<T>.JIFFENLBKPA> DDMIFOAFFIH()
	{
		return default(DFJMAOKIJCE<T, JIFFENLBKPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2E79DF0", Offset = "0x2E785F0", VA = "0x182E79DF0")]
	public JIFFENLBKPA FELPDCOMDHK()
	{
		return default(JIFFENLBKPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2E79E80", Offset = "0x2E78680", VA = "0x182E79E80")]
	public IEnumerator<T> GAACJCPNEFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2E7A040", Offset = "0x2E78840", VA = "0x182E7A040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EHJLDJPBPFM
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x12A5330", Offset = "0x12A3B30", VA = "0x1812A5330")]
	public static GBHIAEEONNH<T> POJNDFFPKOB<T>(params T[] DLLMPOAIBGN) where T : notnull
	{
		return default(GBHIAEEONNH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OHMFGEGKJKK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct EBGAKOKEMCO<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U OFKABHEMFHH;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2D93F90", Offset = "0x2D92790", VA = "0x182D93F90")]
	internal EBGAKOKEMCO(in U EAIMLCNINDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1AB0740", Offset = "0x1AAEF40", VA = "0x181AB0740", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2D93B40", Offset = "0x2D92340", VA = "0x182D93B40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D93B40", Offset = "0x2D92340", VA = "0x182D93B40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DGCLJIDLKMO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F9E0", Offset = "0x1F5E1E0", VA = "0x181F5F9E0")]
	public static EBGAKOKEMCO<T, U> NKAIHPJAMOL<U>(in U PECDBPPMOJP) where U : IEnumerator<T>
	{
		return default(EBGAKOKEMCO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class PFCKCLFKKIF<T> : IDisposable, OHMFGEGKJKK, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GLMJLJAKPHK<T> MPCPGABGLGK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21A8910", Offset = "0x21A7110", VA = "0x1821A8910", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x21A8790", Offset = "0x21A6F90", VA = "0x1821A8790")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x21A8990", Offset = "0x21A7190", VA = "0x1821A8990")]
	public static PFCKCLFKKIF<T> NKAIHPJAMOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x21A87D0", Offset = "0x21A6FD0", VA = "0x1821A87D0")]
	public static PFCKCLFKKIF<T> FCJDMFNLKAA(int LNKEFEELODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x21A8B10", Offset = "0x21A7310", VA = "0x1821A8B10")]
	internal PFCKCLFKKIF(in GLMJLJAKPHK<T> PBDNMEDOHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x21A87B0", Offset = "0x21A6FB0", VA = "0x1821A87B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x21A88F0", Offset = "0x21A70F0", VA = "0x1821A88F0")]
	public void GLILACFFLBJ(in T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x21A8970", Offset = "0x21A7170", VA = "0x1821A8970")]
	public void KKABBFIFONB(int JMKNAPEFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x21A8930", Offset = "0x21A7130", VA = "0x1821A8930", Slot = "8")]
	public GLMJLJAKPHK<T>.CDKONHKADEL GetEnumerator()
	{
		return default(GLMJLJAKPHK<T>.CDKONHKADEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x21A8AA0", Offset = "0x21A72A0", VA = "0x1821A8AA0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x21A8AA0", Offset = "0x21A72A0", VA = "0x1821A8AA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(GLMJLJAKPHK<>.LMNMLNBJDEA))]
public struct GLMJLJAKPHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct CDKONHKADEL : OHMFGEGKJKK, MNLNNJOBLJG<T>, NLFHJMNEADI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] EFIPBCHBMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int LAHBBMDGKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int DKNGOBLBOBI;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int GKGAEPJBJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1A82220", Offset = "0x1A80A20", VA = "0x181A82220", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x294FF00", Offset = "0x294E700", VA = "0x18294FF00", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T OFNHFKMAMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x294EBB0", Offset = "0x294D3B0", VA = "0x18294EBB0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x294F350", Offset = "0x294DB50", VA = "0x18294F350", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x294F5C0", Offset = "0x294DDC0", VA = "0x18294F5C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x22E8D90", Offset = "0x22E7590", VA = "0x1822E8D90")]
		internal CDKONHKADEL(T[] GFONPGDKJGC, int JMKNAPEFDDB, int AMOEKOMGDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x294EF60", Offset = "0x294D760", VA = "0x18294EF60")]
		public static CDKONHKADEL NKAIHPJAMOL(ref GLMJLJAKPHK<T> PECDBPPMOJP)
		{
			return default(CDKONHKADEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2916830", Offset = "0x2915030", VA = "0x182916830", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x271E8E0", Offset = "0x271D0E0", VA = "0x18271E8E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct JNAHDIGIBAD : OHMFGEGKJKK, NLFHJMNEADI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CDKONHKADEL OFKABHEMFHH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int GKGAEPJBJAI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x27CFD00", Offset = "0x27CE500", VA = "0x1827CFD00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x27D0D50", Offset = "0x27CF550", VA = "0x1827D0D50", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x27CFE70", Offset = "0x27CE670", VA = "0x1827CFE70", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x27D0470", Offset = "0x27CEC70", VA = "0x1827D0470", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
		private JNAHDIGIBAD(in CDKONHKADEL EAIMLCNINDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x27CFD70", Offset = "0x27CE570", VA = "0x1827CFD70")]
		public static JNAHDIGIBAD NKAIHPJAMOL(in GLMJLJAKPHK<T> PECDBPPMOJP)
		{
			return default(JNAHDIGIBAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x27CFD30", Offset = "0x27CE530", VA = "0x1827CFD30", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x27CFE30", Offset = "0x27CE630", VA = "0x1827CFE30", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x27CFCC0", Offset = "0x27CE4C0", VA = "0x1827CFCC0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class LMNMLNBJDEA
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] EFIPBCHBMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int LAHBBMDGKLI;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x208B160", Offset = "0x2089960", VA = "0x18208B160")]
	public static GLMJLJAKPHK<T> NKAIHPJAMOL()
	{
		return default(GLMJLJAKPHK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x208B080", Offset = "0x2089880", VA = "0x18208B080")]
	public static GLMJLJAKPHK<T> FCJDMFNLKAA(int LNKEFEELODK)
	{
		return default(GLMJLJAKPHK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xBCBB10", Offset = "0xBCA310", VA = "0x180BCBB10")]
	internal GLMJLJAKPHK(T[] GFONPGDKJGC, int JMKNAPEFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x208B230", Offset = "0x2089A30", VA = "0x18208B230", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GDPKAMAEBBH
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F630", Offset = "0x1B8DE30", VA = "0x181B8F630")]
	public static void CLOOKKNDFON<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1B90240", Offset = "0x1B8EA40", VA = "0x181B90240")]
	public static string IFEBGDADJMJ<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
	public static T[] NGKOGIFPKMO<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1CA14F0", Offset = "0x1C9FCF0", VA = "0x181CA14F0")]
	public static T LPKBLHIFLLL<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP, int NLNOELCPLOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1570", Offset = "0x1C9FD70", VA = "0x181CA1570")]
	public static T MOOHLFEKHJG<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, int NLNOELCPLOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1CA14B0", Offset = "0x1C9FCB0", VA = "0x181CA14B0")]
	public static T LELCMMABJLH<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP, int NLNOELCPLOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1CA5660", Offset = "0x1CA3E60", VA = "0x181CA5660")]
	public static void OLFLGMGEIBD<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, int NLNOELCPLOI, in T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F6A0", Offset = "0x1B8DEA0", VA = "0x181B8F6A0")]
	public static void DHHIELABBJB<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, int NLNOELCPLOI, T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1A82220", Offset = "0x1A80A20", VA = "0x181A82220")]
	public static int OGPAAFONOID<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1CA17B0", Offset = "0x1C9FFB0", VA = "0x181CA17B0")]
	public static ReadOnlySpan<T> MKJIPCCAMOD<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F910", Offset = "0x1B8E110", VA = "0x181B8F910")]
	public static void GLILACFFLBJ<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, in T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1CA5BE0", Offset = "0x1CA43E0", VA = "0x181CA5BE0")]
	public static void PAHBEPKNIKA<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, int AMOEKOMGDLG, in T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F730", Offset = "0x1B8DF30", VA = "0x181B8F730")]
	public static void EDJJLOJGDBA<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1B90190", Offset = "0x1B8E990", VA = "0x181B90190")]
	public static T HLGIFJJBJPH<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1CA05F0", Offset = "0x1C9EDF0", VA = "0x181CA05F0")]
	public static void KKABBFIFONB<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, int JMKNAPEFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1B91D10", Offset = "0x1B90510", VA = "0x181B91D10")]
	private static void KFKHOEBKKOC<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, int LNKEFEELODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F770", Offset = "0x1B8DF70", VA = "0x181B8F770")]
	public static void EEMEPIGIECC<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1CA5520", Offset = "0x1CA3D20", VA = "0x181CA5520")]
	public static bool NFNDDGEEAHL<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP, in T MENBIMCLIOI) where T : PKABNOGAKFM<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F900", Offset = "0x1B8E100", VA = "0x181B8F900")]
	public static bool GKHBBLGCCAM<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1B90210", Offset = "0x1B8EA10", VA = "0x181B90210")]
	public static bool ICMDOFBAFGI<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP, int NLNOELCPLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9A7C50", Offset = "0x9A6450", VA = "0x1809A7C50")]
	public static GLMJLJAKPHK<T>.JNAHDIGIBAD GAACJCPNEFN<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return default(GLMJLJAKPHK<T>.JNAHDIGIBAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9A7C50", Offset = "0x9A6450", VA = "0x1809A7C50")]
	public static GLMJLJAKPHK<T>.CDKONHKADEL KHALLFHBLBB<T>(this ref GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return default(GLMJLJAKPHK<T>.CDKONHKADEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1B865F0", Offset = "0x1B84DF0", VA = "0x181B865F0")]
	public static DFJMAOKIJCE<T, GLMJLJAKPHK<T>.JNAHDIGIBAD> GEMPNOELNJK<T>(this in GLMJLJAKPHK<T> PECDBPPMOJP)
	{
		return default(DFJMAOKIJCE<T, GLMJLJAKPHK<T>.JNAHDIGIBAD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JKABJAFPLBG<TSourceEnumerator, TSource, TResult> : OHMFGEGKJKK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : OHMFGEGKJKK, NLFHJMNEADI<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator LEFIMNMECDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HLGLPMPGPPG<TSource, TResult> MKGODMEPFCM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x27C6F60", Offset = "0x27C5760", VA = "0x1827C6F60", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult PDEEINOIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x27C7800", Offset = "0x27C6000", VA = "0x1827C7800", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x27C7580", Offset = "0x27C5D80", VA = "0x1827C7580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1AAFD10", Offset = "0x1AAE510", VA = "0x181AAFD10")]
	internal JKABJAFPLBG(in TSourceEnumerator PECDBPPMOJP, HLGLPMPGPPG<TSource, TResult> PDGKFCFIMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27C7190", Offset = "0x27C5990", VA = "0x1827C7190", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27C7460", Offset = "0x27C5C60", VA = "0x1827C7460", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27C6D70", Offset = "0x27C5570", VA = "0x1827C6D70", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NCBJIKHEJMI<TSourceEnumerator, TSource, TResult> : OHMFGEGKJKK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : OHMFGEGKJKK, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator LEFIMNMECDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> MKGODMEPFCM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4025070", Offset = "0x4023870", VA = "0x184025070", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult PDEEINOIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x27C7980", Offset = "0x27C6180", VA = "0x1827C7980", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x27C75C0", Offset = "0x27C5DC0", VA = "0x1827C75C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1AAFD10", Offset = "0x1AAE510", VA = "0x181AAFD10")]
	internal NCBJIKHEJMI(in TSourceEnumerator PECDBPPMOJP, Func<TSource, TResult> PDGKFCFIMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x40251B0", Offset = "0x40239B0", VA = "0x1840251B0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4025280", Offset = "0x4023A80", VA = "0x184025280", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4024EF0", Offset = "0x40236F0", VA = "0x184024EF0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface MNLNNJOBLJG<T> : NLFHJMNEADI<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LHOILNIGBHG
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9A7B70", Offset = "0x9A6370", VA = "0x1809A7B70")]
	public static GBHIAEEONNH<T> AMFFHFKPOLH<T>(this T[] PECDBPPMOJP)
	{
		return default(GBHIAEEONNH<T>);
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
