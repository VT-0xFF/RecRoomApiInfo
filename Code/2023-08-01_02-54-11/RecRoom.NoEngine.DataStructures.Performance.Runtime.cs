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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72D1760", Offset = "0x72D0760", VA = "0x1872D1760")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB36FF0", Offset = "0xB35FF0", VA = "0x180B36FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x183B060", Offset = "0x183A060", VA = "0x18183B060")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KGNECGGCKEP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T DALPLHLAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class AKFHFAKBHGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D230", Offset = "0x2A3C230", VA = "0x182A3D230")]
	public static string FBMGLDOLPNP<T>(this IEnumerable<T> DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A328C0", Offset = "0x2A318C0", VA = "0x182A328C0")]
	public static string DHBLLIDANDO<T>(this IEnumerable<T> DPHICODLGJD, string HCFFCPJOIEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CBEIKHDGPAP<T, U> : IEnumerable<T>, IEnumerable where U : JHJBCBJBMMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U CEJOCPMPBNL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1859E70", Offset = "0x1858E70", VA = "0x181859E70")]
	internal CBEIKHDGPAP(in U FOFFMOPCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1355AA0", Offset = "0x1354AA0", VA = "0x181355AA0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1859CC0", Offset = "0x1858CC0", VA = "0x181859CC0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1859CC0", Offset = "0x1858CC0", VA = "0x181859CC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HDDDDHNDOKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21E9D30", Offset = "0x21E8D30", VA = "0x1821E9D30")]
	public static CBEIKHDGPAP<T, U> CECGBIGMPDN<U>(in U DPHICODLGJD) where U : JHJBCBJBMMP<T>
	{
		return default(CBEIKHDGPAP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IMGMLNGDFNM
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28E3530", Offset = "0x28E2530", VA = "0x1828E3530")]
	public static bool OAKEGONNOPA<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator DPHICODLGJD, in TArgs JMLOLLOGKEE, in CDCHLLPHFEJ<TArgs, TSource, bool> EOOJLCJHMJA) where TSourceEnumerator : KGNECGGCKEP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x28E2960", Offset = "0x28E1960", VA = "0x1828E2960")]
	public static int DLPIJKNGKPJ<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator DPHICODLGJD, in TArgs JMLOLLOGKEE, CDCHLLPHFEJ<TArgs, TSource, bool> EOOJLCJHMJA) where TSourceEnumerator : KGNECGGCKEP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28E31E0", Offset = "0x28E21E0", VA = "0x1828E31E0")]
	public static bool MNPCAAPDFNL<TSourceEnumerator, TSource>(this TSourceEnumerator DPHICODLGJD, in TSource GDMNFPEECEP) where TSourceEnumerator : KGNECGGCKEP<TSource> where TSource : GIBCDHLKDOL<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28E2E90", Offset = "0x28E1E90", VA = "0x1828E2E90")]
	public static int KAEOIFHMPCE<TSourceEnumerator, TSource>(this TSourceEnumerator DPHICODLGJD, in TSource CKMKMNKGMMC) where TSourceEnumerator : KGNECGGCKEP<TSource> where TSource : GIBCDHLKDOL<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x28E2C10", Offset = "0x28E1C10", VA = "0x1828E2C10")]
	public static GHNJKHHMFIL<TSourceEnumerator, TSource, TResult> KAFNJLFFNHH<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator DPHICODLGJD, OOJMJIBEAPD<TSource, TResult> BODAADIHHJP) where TSourceEnumerator : FOBBIGBJCCO, KGNECGGCKEP<TSource>
	{
		return default(GHNJKHHMFIL<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x28E2C10", Offset = "0x28E1C10", VA = "0x1828E2C10")]
	public static MFMHHPMOBPK<TSourceEnumerator, TSource, TResult> EAABNJMEHEL<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator DPHICODLGJD, Func<TSource, TResult> BODAADIHHJP) where TSourceEnumerator : FOBBIGBJCCO, IEnumerator<TSource>
	{
		return default(MFMHHPMOBPK<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DMHJLPMPMNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29C1020", Offset = "0x29C0020", VA = "0x1829C1020")]
	public static bool GIELALFPKMG<TSourceEnumerator>(TSourceEnumerator DPHICODLGJD) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29C0DA0", Offset = "0x29BFDA0", VA = "0x1829C0DA0")]
	public static T AMFCICDGNBO<TSourceEnumerator>(TSourceEnumerator DPHICODLGJD) where TSourceEnumerator : KGNECGGCKEP<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x29C1370", Offset = "0x29C0370", VA = "0x1829C1370")]
	public static T[] KOOPNNBFGBD<TSourceEnumerator>(TSourceEnumerator DPHICODLGJD) where TSourceEnumerator : FOBBIGBJCCO, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x29C1130", Offset = "0x29C0130", VA = "0x1829C1130")]
	public static T JBMJBDBBHBM<TSourceEnumerator>(TSourceEnumerator DPHICODLGJD) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CNANMONHDDD<T, U> : IEnumerable<T>, IEnumerable where U : KGNECGGCKEP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U CEJOCPMPBNL;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	internal CNANMONHDDD(in U FOFFMOPCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1859D40", Offset = "0x1858D40", VA = "0x181859D40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1859D40", Offset = "0x1858D40", VA = "0x181859D40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ANMLLLDGMMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1166490", Offset = "0x1165490", VA = "0x181166490")]
	public static CNANMONHDDD<T, U> CECGBIGMPDN<U>(in U DPHICODLGJD) where U : KGNECGGCKEP<T>
	{
		return default(CNANMONHDDD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct HMEGOOAMLBB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct EKHABGLPPAA : FOBBIGBJCCO, KGNECGGCKEP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] MKLEBJODBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int JGDIHEKDMNH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int EBKBMNDKLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x29E3FB0", Offset = "0x29E2FB0", VA = "0x1829E3FB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x37941B0", Offset = "0x37931B0", VA = "0x1837941B0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3793DA0", Offset = "0x3792DA0", VA = "0x183793DA0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3793F10", Offset = "0x3792F10", VA = "0x183793F10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x953010", Offset = "0x952010", VA = "0x180953010")]
		private EKHABGLPPAA(T[] DPHICODLGJD, int EJNMEMKEIOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3793BE0", Offset = "0x3792BE0", VA = "0x183793BE0")]
		public static EKHABGLPPAA CECGBIGMPDN(T[] DPHICODLGJD)
		{
			return default(EKHABGLPPAA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3793C30", Offset = "0x3792C30", VA = "0x183793C30", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2C3FD90", Offset = "0x2C3ED90", VA = "0x182C3FD90", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly T[] BHLCLBOBGCB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MGNEPOBDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x29E3FB0", Offset = "0x29E2FB0", VA = "0x1829E3FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1898710", Offset = "0x1897710", VA = "0x181898710")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA9F760", Offset = "0xA9E760", VA = "0x180A9F760")]
	internal HMEGOOAMLBB(T[] OGEGDDKCPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35178B0", Offset = "0x35168B0", VA = "0x1835178B0")]
	public static HMEGOOAMLBB<T> PELFLFHGHGI()
	{
		return default(HMEGOOAMLBB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
	public IEnumerable<T> MBDGGMIJIDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3517670", Offset = "0x3516670", VA = "0x183517670")]
	public ReadOnlySpan<T> IIOOILPEMCB()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3517790", Offset = "0x3516790", VA = "0x183517790")]
	public CNANMONHDDD<T, HMEGOOAMLBB<T>.EKHABGLPPAA> PAPFPEAKPNN()
	{
		return default(CNANMONHDDD<T, EKHABGLPPAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3517700", Offset = "0x3516700", VA = "0x183517700")]
	public EKHABGLPPAA JFJPCEDOKBF()
	{
		return default(EKHABGLPPAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35175F0", Offset = "0x35165F0", VA = "0x1835175F0")]
	public IEnumerator<T> DHFGGODEIOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3517960", Offset = "0x3516960", VA = "0x183517960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JGNOOGJJNBN
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20B4F40", Offset = "0x20B3F40", VA = "0x1820B4F40")]
	public static HMEGOOAMLBB<T> JHBAOBHGELC<T>(params T[] OGEGDDKCPPH) where T : notnull
	{
		return default(HMEGOOAMLBB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FOBBIGBJCCO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IDFOHKDIBEA<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U CEJOCPMPBNL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1859EA0", Offset = "0x1858EA0", VA = "0x181859EA0")]
	internal IDFOHKDIBEA(in U FOFFMOPCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x18599A0", Offset = "0x18589A0", VA = "0x1818599A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1859DF0", Offset = "0x1858DF0", VA = "0x181859DF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1859DF0", Offset = "0x1858DF0", VA = "0x181859DF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ALKICHHOCGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x24338C0", Offset = "0x24328C0", VA = "0x1824338C0")]
	public static IDFOHKDIBEA<T, U> CECGBIGMPDN<U>(in U DPHICODLGJD) where U : IEnumerator<T>
	{
		return default(IDFOHKDIBEA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class AGOEJFJICPI<T> : IDisposable, FOBBIGBJCCO, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FDOMALIPIDI<T> JFPGKIGHDCH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x34FF810", Offset = "0x34FE810", VA = "0x1834FF810", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x34FF5A0", Offset = "0x34FE5A0", VA = "0x1834FF5A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34FF5C0", Offset = "0x34FE5C0", VA = "0x1834FF5C0")]
	public static AGOEJFJICPI<T> CECGBIGMPDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34FF6D0", Offset = "0x34FE6D0", VA = "0x1834FF6D0")]
	public static AGOEJFJICPI<T> CJAJAOABMGF(int JEBBAFBPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3446EE0", Offset = "0x3445EE0", VA = "0x183446EE0")]
	internal AGOEJFJICPI(in FDOMALIPIDI<T> DAHEHNAMFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34FF7F0", Offset = "0x34FE7F0", VA = "0x1834FF7F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x34FF870", Offset = "0x34FE870", VA = "0x1834FF870")]
	public void KKDPLFKFCJN(in T CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x34FF890", Offset = "0x34FE890", VA = "0x1834FF890")]
	public void LGAMLBJMJDC(int PFDGPOIGHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x34FF830", Offset = "0x34FE830", VA = "0x1834FF830", Slot = "8")]
	public FDOMALIPIDI<T>.EANBNPJACND GetEnumerator()
	{
		return default(FDOMALIPIDI<T>.EANBNPJACND);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x34FF8B0", Offset = "0x34FE8B0", VA = "0x1834FF8B0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x34FF8B0", Offset = "0x34FE8B0", VA = "0x1834FF8B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(FDOMALIPIDI<>.CPDFNCHMGCD))]
public struct FDOMALIPIDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct EANBNPJACND : FOBBIGBJCCO, JHJBCBJBMMP<T>, KGNECGGCKEP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] OKKDJEMDHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int NFPPECIGIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int JGDIHEKDMNH;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int EBKBMNDKLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA9F770", Offset = "0xA9E770", VA = "0x180A9F770", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x22A78D0", Offset = "0x22A68D0", VA = "0x1822A78D0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T BKCCIKKIAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x22A6620", Offset = "0x22A5620", VA = "0x1822A6620", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x22A6AC0", Offset = "0x22A5AC0", VA = "0x1822A6AC0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x22A7410", Offset = "0x22A6410", VA = "0x1822A7410", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1F55AD0", Offset = "0x1F54AD0", VA = "0x181F55AD0")]
		internal EANBNPJACND(T[] GDJIPDMDHHM, int PFDGPOIGHFM, int EJNMEMKEIOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x22A69C0", Offset = "0x22A59C0", VA = "0x1822A69C0")]
		public static EANBNPJACND CECGBIGMPDN(ref FDOMALIPIDI<T> DPHICODLGJD)
		{
			return default(EANBNPJACND);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x22A6A20", Offset = "0x22A5A20", VA = "0x1822A6A20", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x22A6A30", Offset = "0x22A5A30", VA = "0x1822A6A30", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct GOGNNFGAIOM : FOBBIGBJCCO, KGNECGGCKEP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EANBNPJACND CEJOCPMPBNL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int EBKBMNDKLEN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x25D13E0", Offset = "0x25D03E0", VA = "0x1825D13E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x25D2120", Offset = "0x25D1120", VA = "0x1825D2120", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x25D1800", Offset = "0x25D0800", VA = "0x1825D1800", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x25D1D00", Offset = "0x25D0D00", VA = "0x1825D1D00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
		private GOGNNFGAIOM(in EANBNPJACND FOFFMOPCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x25D12E0", Offset = "0x25D02E0", VA = "0x1825D12E0")]
		public static GOGNNFGAIOM CECGBIGMPDN(in FDOMALIPIDI<T> DPHICODLGJD)
		{
			return default(GOGNNFGAIOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x25D1410", Offset = "0x25D0410", VA = "0x1825D1410", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x25D1450", Offset = "0x25D0450", VA = "0x1825D1450", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x25D13A0", Offset = "0x25D03A0", VA = "0x1825D13A0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class CPDFNCHMGCD
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] OKKDJEMDHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int NFPPECIGIML;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1EF3B10", Offset = "0x1EF2B10", VA = "0x181EF3B10")]
	public static FDOMALIPIDI<T> CECGBIGMPDN()
	{
		return default(FDOMALIPIDI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1EF3BE0", Offset = "0x1EF2BE0", VA = "0x181EF3BE0")]
	public static FDOMALIPIDI<T> CJAJAOABMGF(int JEBBAFBPNEF)
	{
		return default(FDOMALIPIDI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x953010", Offset = "0x952010", VA = "0x180953010")]
	internal FDOMALIPIDI(T[] GDJIPDMDHHM, int PFDGPOIGHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1E705C0", Offset = "0x1E6F5C0", VA = "0x181E705C0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IHDHGKINGHG
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x189E000", Offset = "0x189D000", VA = "0x18189E000")]
	public static void JJKMDDGGLDB<T>(this ref FDOMALIPIDI<T> DPHICODLGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1898B00", Offset = "0x1897B00", VA = "0x181898B00")]
	public static string GBACJOEDPOM<T>(this in FDOMALIPIDI<T> DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
	public static T[] LHGFCJGFDBB<T>(this in FDOMALIPIDI<T> DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1898590", Offset = "0x1897590", VA = "0x181898590")]
	public static T EAOPAIAIDNN<T>(this in FDOMALIPIDI<T> DPHICODLGJD, int MBMAEEFDADD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1898590", Offset = "0x1897590", VA = "0x181898590")]
	public static T ODCBFOFHMOF<T>(this ref FDOMALIPIDI<T> DPHICODLGJD, int MBMAEEFDADD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA9F770", Offset = "0xA9E770", VA = "0x180A9F770")]
	public static int LEEMDCFGNAD<T>(this in FDOMALIPIDI<T> DPHICODLGJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x189AAA0", Offset = "0x1899AA0", VA = "0x18189AAA0")]
	public static ReadOnlySpan<T> IIOOILPEMCB<T>(this in FDOMALIPIDI<T> DPHICODLGJD)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x189FAB0", Offset = "0x189EAB0", VA = "0x18189FAB0")]
	public static ReadOnlyMemory<T> OLBHCCIMJEH<T>(this in FDOMALIPIDI<T> DPHICODLGJD)
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x189E200", Offset = "0x189D200", VA = "0x18189E200")]
	public static void KKDPLFKFCJN<T>(this ref FDOMALIPIDI<T> DPHICODLGJD, in T CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x189A310", Offset = "0x1899310", VA = "0x18189A310")]
	public static void GPEMHCPBCGJ<T>(this ref FDOMALIPIDI<T> DPHICODLGJD, int EJNMEMKEIOD, in T CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x189DFC0", Offset = "0x189CFC0", VA = "0x18189DFC0")]
	public static void JDKMAIEIFCP<T>(this ref FDOMALIPIDI<T> DPHICODLGJD, int EJNMEMKEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x189E880", Offset = "0x189D880", VA = "0x18189E880")]
	public static void LGAMLBJMJDC<T>(this ref FDOMALIPIDI<T> DPHICODLGJD, int PFDGPOIGHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1896F70", Offset = "0x1895F70", VA = "0x181896F70")]
	private static void ALLENGPMLEI<T>(this ref FDOMALIPIDI<T> DPHICODLGJD, int JEBBAFBPNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1898750", Offset = "0x1897750", VA = "0x181898750")]
	public static void EPCDHGCGJPK<T>(this ref FDOMALIPIDI<T> DPHICODLGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x189F9A0", Offset = "0x189E9A0", VA = "0x18189F9A0")]
	public static bool NOMGKDJLHOE<T>(this ref FDOMALIPIDI<T> DPHICODLGJD, in T CKMKMNKGMMC) where T : GIBCDHLKDOL<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x18984C0", Offset = "0x18974C0", VA = "0x1818984C0")]
	public static bool BLPCIPDEODE<T>(this in FDOMALIPIDI<T> DPHICODLGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x189F970", Offset = "0x189E970", VA = "0x18189F970")]
	public static bool MOIDNHEFMML<T>(this in FDOMALIPIDI<T> DPHICODLGJD, int MBMAEEFDADD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1166430", Offset = "0x1165430", VA = "0x181166430")]
	public static FDOMALIPIDI<T>.GOGNNFGAIOM DHFGGODEIOI<T>(this in FDOMALIPIDI<T> DPHICODLGJD)
	{
		return default(FDOMALIPIDI<T>.GOGNNFGAIOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1166430", Offset = "0x1165430", VA = "0x181166430")]
	public static FDOMALIPIDI<T>.EANBNPJACND PAELBDDPBMJ<T>(this ref FDOMALIPIDI<T> DPHICODLGJD)
	{
		return default(FDOMALIPIDI<T>.EANBNPJACND);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1895140", Offset = "0x1894140", VA = "0x181895140")]
	public static CNANMONHDDD<T, FDOMALIPIDI<T>.GOGNNFGAIOM> IGKLPACJADI<T>(this in FDOMALIPIDI<T> DPHICODLGJD)
	{
		return default(CNANMONHDDD<T, FDOMALIPIDI<T>.GOGNNFGAIOM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GHNJKHHMFIL<TSourceEnumerator, TSource, TResult> : FOBBIGBJCCO, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : FOBBIGBJCCO, KGNECGGCKEP<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator MKLEBJODBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OOJMJIBEAPD<TSource, TResult> LIHKJEJGBCI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x343C7B0", Offset = "0x343B7B0", VA = "0x18343C7B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult DALPLHLAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x343CD20", Offset = "0x343BD20", VA = "0x18343CD20", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x343CCA0", Offset = "0x343BCA0", VA = "0x18343CCA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C350", Offset = "0x1E2B350", VA = "0x181E2C350")]
	internal GHNJKHHMFIL(in TSourceEnumerator DPHICODLGJD, OOJMJIBEAPD<TSource, TResult> BODAADIHHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x343C8A0", Offset = "0x343B8A0", VA = "0x18343C8A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x343CA90", Offset = "0x343BA90", VA = "0x18343CA90", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x343C5A0", Offset = "0x343B5A0", VA = "0x18343C5A0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MFMHHPMOBPK<TSourceEnumerator, TSource, TResult> : FOBBIGBJCCO, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : FOBBIGBJCCO, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator MKLEBJODBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> LIHKJEJGBCI;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x29DE690", Offset = "0x29DD690", VA = "0x1829DE690", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult DALPLHLAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x29DEC30", Offset = "0x29DDC30", VA = "0x1829DEC30", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x29DEA20", Offset = "0x29DDA20", VA = "0x1829DEA20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C350", Offset = "0x1E2B350", VA = "0x181E2C350")]
	internal MFMHHPMOBPK(in TSourceEnumerator DPHICODLGJD, Func<TSource, TResult> BODAADIHHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x29DE820", Offset = "0x29DD820", VA = "0x1829DE820", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x29DE8F0", Offset = "0x29DD8F0", VA = "0x1829DE8F0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x29DE570", Offset = "0x29DD570", VA = "0x1829DE570", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JHJBCBJBMMP<T> : KGNECGGCKEP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PCKHABFNPKE
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xCD92C0", Offset = "0xCD82C0", VA = "0x180CD92C0")]
	public static HMEGOOAMLBB<T> EBOAKBCJGNA<T>(this T[] DPHICODLGJD)
	{
		return default(HMEGOOAMLBB<T>);
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
