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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x625F730", Offset = "0x625EB30", VA = "0x18625F730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FPHBIDJFGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24A8AD0", Offset = "0x24A7ED0", VA = "0x1824A8AD0")]
	public static LMHOHLCAMLC<T> AHKILBIKKIL<T>(this T[] MEEBIDIALDO) where T : notnull
	{
		return default(LMHOHLCAMLC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class LNCHNBCHPCO<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OONLFEIMAID<T> MIEFJMFHGIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D295D0", Offset = "0x3D289D0", VA = "0x183D295D0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3D293F0", Offset = "0x3D287F0", VA = "0x183D293F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D294B0", Offset = "0x3D288B0", VA = "0x183D294B0")]
	public static LNCHNBCHPCO<T> HGJFOBLHCKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D29680", Offset = "0x3D28A80", VA = "0x183D29680")]
	internal LNCHNBCHPCO([In] OONLFEIMAID<T> OOANNHIADDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D29420", Offset = "0x3D28820", VA = "0x183D29420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D29440", Offset = "0x3D28840", VA = "0x183D29440")]
	public void GOEAADPNNCL(int JDBLGKLFJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D29460", Offset = "0x3D28860", VA = "0x183D29460", Slot = "8")]
	public OONLFEIMAID<T>.LILEAGHBLMC GetEnumerator()
	{
		return default(OONLFEIMAID<T>.LILEAGHBLMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D29600", Offset = "0x3D28A00", VA = "0x183D29600", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D29600", Offset = "0x3D28A00", VA = "0x183D29600", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DEJDBPHDKAG<T, U> : IEnumerable<T>, IEnumerable where U : KOHHOEGEIGH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U LMJAKBIIIIC;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA1E0", Offset = "0x1DA95E0", VA = "0x181DAA1E0")]
	internal DEJDBPHDKAG([In] U IFPJEBNJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x37C0B00", Offset = "0x37BFF00", VA = "0x1837C0B00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x37C0B00", Offset = "0x37BFF00", VA = "0x1837C0B00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CNADMONCLCE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x23063F0", Offset = "0x23057F0", VA = "0x1823063F0")]
	public static DEJDBPHDKAG<T, U> HGJFOBLHCKL<U>([In] U MEEBIDIALDO) where U : KOHHOEGEIGH<T>
	{
		return default(DEJDBPHDKAG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct OCIEPPKJBLK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U LMJAKBIIIIC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x40C6870", Offset = "0x40C5C70", VA = "0x1840C6870")]
	internal OCIEPPKJBLK([In] U IFPJEBNJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3CFDA00", Offset = "0x3CFCE00", VA = "0x183CFDA00", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40C6660", Offset = "0x40C5A60", VA = "0x1840C6660", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40C6660", Offset = "0x40C5A60", VA = "0x1840C6660", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NKABIFJAHIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2725370", Offset = "0x2724770", VA = "0x182725370")]
	public static OCIEPPKJBLK<T, U> HGJFOBLHCKL<U>([In] U MEEBIDIALDO) where U : IEnumerator<T>
	{
		return default(OCIEPPKJBLK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class DDNHLGDNEKK
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2649F10", Offset = "0x2649310", VA = "0x182649F10")]
	public static string AHCGAOJCEJG<T>(this IEnumerable<T> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x264F0D0", Offset = "0x264E4D0", VA = "0x18264F0D0")]
	public static string EIDNFNCINHP<T>(this IEnumerable<T> MEEBIDIALDO, string KEBMPANDJDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GOLHHHKLNFK
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27F4230", Offset = "0x27F3630", VA = "0x1827F4230")]
	public static bool COALDBFPPBC<TSourceEnumerator, TSource>(this TSourceEnumerator MEEBIDIALDO, [In] TSource LPGJEPJPGGB) where TSourceEnumerator : KOHHOEGEIGH<TSource> where TSource : IJKDBAHHGHL<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27F40A0", Offset = "0x27F34A0", VA = "0x1827F40A0")]
	public static int ACJMGCBEFPA<TSourceEnumerator, TSource>(this TSourceEnumerator MEEBIDIALDO, [In] TSource PCGOHCLJAPN) where TSourceEnumerator : KOHHOEGEIGH<TSource> where TSource : IJKDBAHHGHL<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KOHHOEGEIGH<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T MPGEHNMDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IJGCNABBBGJ<T> : KOHHOEGEIGH<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct GGMFFIIBDGO<T, U> : IEnumerable<T>, IEnumerable where U : IJGCNABBBGJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U LMJAKBIIIIC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37C0BB0", Offset = "0x37BFFB0", VA = "0x1837C0BB0")]
	internal GGMFFIIBDGO([In] U IFPJEBNJGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x340EA20", Offset = "0x340DE20", VA = "0x18340EA20", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37C0A70", Offset = "0x37BFE70", VA = "0x1837C0A70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37C0A70", Offset = "0x37BFE70", VA = "0x1837C0A70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EFAHJFMIGNK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2306420", Offset = "0x2305820", VA = "0x182306420")]
	public static GGMFFIIBDGO<T, U> HGJFOBLHCKL<U>([In] U MEEBIDIALDO) where U : IJGCNABBBGJ<T>
	{
		return default(GGMFFIIBDGO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct LMHOHLCAMLC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct KDMJKOGLINP : KOHHOEGEIGH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] BHGJJNLKHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int CDHFJFHGCGD;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3C73AC0", Offset = "0x3C72EC0", VA = "0x183C73AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3C73470", Offset = "0x3C72870", VA = "0x183C73470", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3C73530", Offset = "0x3C72930", VA = "0x183C73530", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18AF070", Offset = "0x18AE470", VA = "0x1818AF070")]
		private KDMJKOGLINP(T[] MEEBIDIALDO, int PMLKPJNGBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C73240", Offset = "0x3C72640", VA = "0x183C73240")]
		public static KDMJKOGLINP HGJFOBLHCKL(T[] MEEBIDIALDO)
		{
			return default(KDMJKOGLINP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD860", Offset = "0x1DDCC60", VA = "0x181DDD860", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DDD8D0", Offset = "0x1DDCCD0", VA = "0x181DDD8D0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] JKEOHCHMKGL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GGHIHFENJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37B6B10", Offset = "0x37B5F10", VA = "0x1837B6B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2DA9080", Offset = "0x2DA8480", VA = "0x182DA9080")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	internal LMHOHLCAMLC(T[] KGECIFKDBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D24980", Offset = "0x3D23D80", VA = "0x183D24980")]
	public static LMHOHLCAMLC<T> CCDCOKAGGMA()
	{
		return default(LMHOHLCAMLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850")]
	public IEnumerable<T> DBFILIOLJCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D24C70", Offset = "0x3D24070", VA = "0x183D24C70")]
	public ReadOnlySpan<T> PEODEOPDLBE()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D24AC0", Offset = "0x3D23EC0", VA = "0x183D24AC0")]
	public DEJDBPHDKAG<T, LMHOHLCAMLC<T>.KDMJKOGLINP> ECIKLGLACHD()
	{
		return default(DEJDBPHDKAG<T, KDMJKOGLINP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D24BE0", Offset = "0x3D23FE0", VA = "0x183D24BE0")]
	public KDMJKOGLINP PAAFHADOGAM()
	{
		return default(KDMJKOGLINP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D24A40", Offset = "0x3D23E40", VA = "0x183D24A40")]
	public IEnumerator<T> CKFAHJNIOKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D24D00", Offset = "0x3D24100", VA = "0x183D24D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NPFINKCECNP
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x24AB940", Offset = "0x24AAD40", VA = "0x1824AB940")]
	public static LMHOHLCAMLC<T> DGAOOKEMCBC<T>(params T[] KGECIFKDBHF) where T : notnull
	{
		return default(LMHOHLCAMLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x625F6D0", Offset = "0x625EAD0", VA = "0x18625F6D0")]
	public static Stream GBLJPFNAPAA(this LMHOHLCAMLC<byte> MEEBIDIALDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(OONLFEIMAID<>.PHCMEIFMOOG))]
public struct OONLFEIMAID<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct LILEAGHBLMC : IJGCNABBBGJ<T>, KOHHOEGEIGH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] EPONINGPNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int FHAAMAIKPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int CDHFJFHGCGD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3D1C510", Offset = "0x3D1B910", VA = "0x183D1C510", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T KBDHJPJNBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3D1BC20", Offset = "0x3D1B020", VA = "0x183D1BC20", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3D1BFE0", Offset = "0x3D1B3E0", VA = "0x183D1BFE0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3D1C170", Offset = "0x3D1B570", VA = "0x183D1C170", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x36B8DA0", Offset = "0x36B81A0", VA = "0x1836B8DA0")]
		internal LILEAGHBLMC(T[] LEFKIOOOAEA, int JDBLGKLFJDF, int PMLKPJNGBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BD60", Offset = "0x3D1B160", VA = "0x183D1BD60")]
		public static LILEAGHBLMC HGJFOBLHCKL(OONLFEIMAID<T> MEEBIDIALDO)
		{
			return default(LILEAGHBLMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x33C9F10", Offset = "0x33C9310", VA = "0x1833C9F10", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x33C3AE0", Offset = "0x33C2EE0", VA = "0x1833C3AE0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct DFJBEGPLHED : KOHHOEGEIGH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LILEAGHBLMC LMJAKBIIIIC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T MPGEHNMDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x50EF1C0", Offset = "0x50EE5C0", VA = "0x1850EF1C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x50EEE00", Offset = "0x50EE200", VA = "0x1850EEE00", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x50EF090", Offset = "0x50EE490", VA = "0x1850EF090", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA1E0", Offset = "0x1DA95E0", VA = "0x181DAA1E0")]
		private DFJBEGPLHED([In] LILEAGHBLMC IFPJEBNJGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50EECD0", Offset = "0x50EE0D0", VA = "0x1850EECD0")]
		public static DFJBEGPLHED HGJFOBLHCKL([In] OONLFEIMAID<T> MEEBIDIALDO)
		{
			return default(DFJBEGPLHED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x50EED80", Offset = "0x50EE180", VA = "0x1850EED80", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x50EEDC0", Offset = "0x50EE1C0", VA = "0x1850EEDC0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x50EEC90", Offset = "0x50EE090", VA = "0x1850EEC90", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class PHCMEIFMOOG
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] EPONINGPNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int FHAAMAIKPGF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4101DD0", Offset = "0x41011D0", VA = "0x184101DD0")]
	public static OONLFEIMAID<T> HGJFOBLHCKL()
	{
		return default(OONLFEIMAID<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4101D20", Offset = "0x4101120", VA = "0x184101D20")]
	public static OONLFEIMAID<T> BMEMCLKEKFC(int MIFMOLKOCID)
	{
		return default(OONLFEIMAID<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x18AF070", Offset = "0x18AE470", VA = "0x1818AF070")]
	internal OONLFEIMAID(T[] LEFKIOOOAEA, int JDBLGKLFJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4101E70", Offset = "0x4101270", VA = "0x184101E70", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ACLKBAOLHHM
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int BKHJLAHDMKP<TCtx, T>([In] TCtx NDLDDDGLLLC, T LCALDLBCJKP, T JPKPFNMFEIJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9BB0", Offset = "0x2DA8FB0", VA = "0x182DA9BB0")]
	public static void FHLEEDLMEFH<T>(this OONLFEIMAID<T> MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2DAA0F0", Offset = "0x2DA94F0", VA = "0x182DAA0F0")]
	public static string GJGPOGCJBFH<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850")]
	public static T[] OCPGCBAAMGO<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9080", Offset = "0x2DA8480", VA = "0x182DA9080")]
	public static T EBLDKANKNCA<T>([In] this OONLFEIMAID<T> MEEBIDIALDO, int DJKFAHMDLOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9080", Offset = "0x2DA8480", VA = "0x182DA9080")]
	public static T FAKNECHJMIA<T>(this OONLFEIMAID<T> MEEBIDIALDO, int DJKFAHMDLOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEE10", Offset = "0x2DAE210", VA = "0x182DAEE10")]
	public static T OBGBDGOBCIB<T>([In] this OONLFEIMAID<T> MEEBIDIALDO, int DJKFAHMDLOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE920", Offset = "0x2DADD20", VA = "0x182DAE920")]
	public static void NINGCLMMDDO<T>(this OONLFEIMAID<T> MEEBIDIALDO, int DJKFAHMDLOE, [In] T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0D30", Offset = "0x2DB0130", VA = "0x182DB0D30")]
	public static void PCJFLNDAAAI<T>(this OONLFEIMAID<T> MEEBIDIALDO, int DJKFAHMDLOE, T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3260", Offset = "0x1DD2660", VA = "0x181DD3260")]
	public static int NDIIMGODLPM<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0DD0", Offset = "0x2DB01D0", VA = "0x182DB0DD0")]
	public static ReadOnlySpan<T> PEODEOPDLBE<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8D40", Offset = "0x2DA8140", VA = "0x182DA8D40")]
	public static T[] BBJKLDJJIDJ<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8C90", Offset = "0x2DA8090", VA = "0x182DA8C90")]
	public static T APFAAPHKLHI<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9C10", Offset = "0x2DA9010", VA = "0x182DA9C10")]
	public static T[] FIDEKIICODN<T>(this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE220", Offset = "0x2DAD620", VA = "0x182DAE220")]
	public static LMHOHLCAMLC<T> IKACFJPBOLG<T>(this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return default(LMHOHLCAMLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA96C0", Offset = "0x2DA8AC0", VA = "0x182DA96C0")]
	public static void FFIECPFJEFG<T>(this OONLFEIMAID<T> MEEBIDIALDO, [In] T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF0C0", Offset = "0x2DAE4C0", VA = "0x182DAF0C0")]
	public static void OKKEOBLKOHF<T>(this OONLFEIMAID<T> MEEBIDIALDO, T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE570", Offset = "0x2DAD970", VA = "0x182DAE570")]
	public static void LALIDEJFDOI<T>(this OONLFEIMAID<T> MEEBIDIALDO, int PMLKPJNGBAD, [In] T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9680", Offset = "0x2DA8A80", VA = "0x182DA9680")]
	public static void FENDEOIBNML<T>(this OONLFEIMAID<T> MEEBIDIALDO, int PMLKPJNGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE750", Offset = "0x2DADB50", VA = "0x182DAE750")]
	public static T MLHHNALJKHO<T>(this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC870", Offset = "0x2DABC70", VA = "0x182DAC870")]
	public static void GOEAADPNNCL<T>(this OONLFEIMAID<T> MEEBIDIALDO, int JDBLGKLFJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF580", Offset = "0x2DAE980", VA = "0x182DAF580")]
	private static void ONEOBIJKNKK<T>(this OONLFEIMAID<T> MEEBIDIALDO, int MIFMOLKOCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEF40", Offset = "0x2DAE340", VA = "0x182DAEF40")]
	public static void OIGNPMFKFFL<T>(this OONLFEIMAID<T> MEEBIDIALDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE370", Offset = "0x2DAD770", VA = "0x182DAE370")]
	public static OONLFEIMAID<T> KKNGHIBJGCG<T>([In] this OONLFEIMAID<T> MEEBIDIALDO, BFHHKNBHDOM<T, T> NBOMLGGAODO)
	{
		return default(OONLFEIMAID<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8F20", Offset = "0x2DA8320", VA = "0x182DA8F20")]
	public static bool DCGPJFJLEEH<T>(this OONLFEIMAID<T> MEEBIDIALDO, [In] T PCGOHCLJAPN) where T : IJKDBAHHGHL<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x27FBD00", Offset = "0x27FB100", VA = "0x1827FBD00")]
	public static bool ILIOJLEOEKF<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9C90", Offset = "0x2DA9090", VA = "0x182DA9C90")]
	public static bool GDCDJGFLPFL<T>([In] this OONLFEIMAID<T> MEEBIDIALDO, int DJKFAHMDLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0EA0", Offset = "0x2DB02A0", VA = "0x182DB0EA0")]
	public static void PPGGCHMLJPE<T, TCtx>(this OONLFEIMAID<T> MEEBIDIALDO, [In] TCtx NDLDDDGLLLC, BKHJLAHDMKP<TCtx, T> ACLALGFNMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE2B0", Offset = "0x2DAD6B0", VA = "0x182DAE2B0")]
	private static void JEEEJJFEKKE<T, TCtx>(OONLFEIMAID<T> MEEBIDIALDO, [In] TCtx NDLDDDGLLLC, BKHJLAHDMKP<TCtx, T> ACLALGFNMAI, int KOPPNHHHAGD, int IMBDLBECKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2DA91F0", Offset = "0x2DA85F0", VA = "0x182DA91F0")]
	private static int EMCMNEMKAOM<T, TCtx>(OONLFEIMAID<T> MEEBIDIALDO, [In] TCtx NDLDDDGLLLC, BKHJLAHDMKP<TCtx, T> ACLALGFNMAI, int KOPPNHHHAGD, int IMBDLBECKEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27EAAC0", Offset = "0x27E9EC0", VA = "0x1827EAAC0")]
	public static OONLFEIMAID<T>.DFJBEGPLHED CKFAHJNIOKH<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return default(OONLFEIMAID<T>.DFJBEGPLHED);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27EAAC0", Offset = "0x27E9EC0", VA = "0x1827EAAC0")]
	public static OONLFEIMAID<T>.LILEAGHBLMC JBMPLBCNDAP<T>(this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return default(OONLFEIMAID<T>.LILEAGHBLMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27EAAF0", Offset = "0x27E9EF0", VA = "0x1827EAAF0")]
	public static DEJDBPHDKAG<T, OONLFEIMAID<T>.DFJBEGPLHED> EJCNNPGLFML<T>([In] this OONLFEIMAID<T> MEEBIDIALDO)
	{
		return default(DEJDBPHDKAG<T, OONLFEIMAID<T>.DFJBEGPLHED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class FFCNGNOMLNE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27C8780", Offset = "0x27C7B80", VA = "0x1827C8780")]
	public static T[] JJFFAIBABIB<T>(int HIAJHKACHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	public static void GMDFMPNMOIJ<T>(T[] KGECIFKDBHF)
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
