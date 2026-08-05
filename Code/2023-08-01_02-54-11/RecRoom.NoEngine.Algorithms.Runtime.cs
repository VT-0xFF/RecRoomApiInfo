using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;
using UnityEngine;

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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x726BDA0", Offset = "0x726ADA0", VA = "0x18726BDA0")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
public static class NCPOGPLOPIB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x726BCA0", Offset = "0x726ACA0", VA = "0x18726BCA0")]
	public static (float3, float3, float3) LJLAEJJBEFN(this in quaternion DPHICODLGJD)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KNBNFAGGMDG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x234FAC0", Offset = "0x234EAC0", VA = "0x18234FAC0")]
	public static bool BIMCHHIIGLB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x701CF0", Offset = "0x7010F0")] this in ReadOnlyMemory<T> DPHICODLGJD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x701D60", Offset = "0x701160")] in ReadOnlyMemory<T> JONIFABKCAI) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x234FCD0", Offset = "0x234ECD0", VA = "0x18234FCD0")]
	public static int GLAKDOMDIGD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x701DD0", Offset = "0x7011D0")] this in ReadOnlyMemory<T?> DPHICODLGJD, int NOFCNJLFFMP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x234FBE0", Offset = "0x234EBE0", VA = "0x18234FBE0")]
	public static string FBMGLDOLPNP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x701E40", Offset = "0x701240")] this in ReadOnlyMemory<T> DPHICODLGJD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KAMKAHAFLII
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x13B4F80", Offset = "0x13B3F80", VA = "0x1813B4F80")]
	public static void LDKJPGOJLHA<T>(this ICollection<T> DPHICODLGJD, IEnumerable<T> EEBPEGLIDHM) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BDDIANJACHG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJGHNHCAJOH CLBNKIPBPIG();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GIPBOJHMNAC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IDIKOPFADHF<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public IDIKOPFADHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x185A410", Offset = "0x1859410", VA = "0x18185A410")]
		internal TElement CFLPHLPHJEM(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JDCPHALOKOH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public JDCPHALOKOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x130CE20", Offset = "0x130BE20", VA = "0x18130CE20")]
		internal int NMNHNKOOJHA(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x295C7C0", Offset = "0x295B7C0", VA = "0x18295C7C0")]
	public static int GOFEPLAKGDM<T>(this IReadOnlyList<T> OGEGDDKCPPH, T CKMKMNKGMMC) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x295B310", Offset = "0x295A310", VA = "0x18295B310")]
	public static int EJHODEFKFLJ<T>(this IReadOnlyList<T> OGEGDDKCPPH, T CKMKMNKGMMC) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x295E3E0", Offset = "0x295D3E0", VA = "0x18295E3E0")]
	public static void LDKJPGOJLHA<T>(this HashSet<T> KKAOOHBDCEG, IEnumerable<T> EEBPEGLIDHM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x295D470", Offset = "0x295C470", VA = "0x18295D470")]
	public static void HIKPDMHPLOC<T>(this IList<T> IHMGNIOOIJN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x295D150", Offset = "0x295C150", VA = "0x18295D150")]
	public static void HIKPDMHPLOC<T>(this IList<T> IHMGNIOOIJN, int GCICDAOOCOL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x295B4D0", Offset = "0x295A4D0", VA = "0x18295B4D0")]
	public static List<T> ELJIBPNAAKP<T>(this List<T> IOBPFBILMIA, Predicate<T> MPGELOPFEDM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x295CB70", Offset = "0x295BB70", VA = "0x18295CB70")]
	public static int GOFEPLAKGDM<T>(this IReadOnlyList<T> IHMGNIOOIJN, Predicate<T> EOOJLCJHMJA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2960FF0", Offset = "0x295FFF0", VA = "0x182960FF0")]
	public static bool PMLEJIFIEPB<T>(this IReadOnlyList<T> IHMGNIOOIJN, Predicate<T> EOOJLCJHMJA, [PNMIPGNDCLG(true)] out List<int>? HDIBLAFEMDB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x295BF50", Offset = "0x295AF50", VA = "0x18295BF50")]
	public static bool FCOLACKIJCJ<T>(this IReadOnlyList<T> IHMGNIOOIJN, T GDMNFPEECEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x295BFA0", Offset = "0x295AFA0", VA = "0x18295BFA0")]
	public static bool FCOLACKIJCJ<T>(this IReadOnlyList<T> IHMGNIOOIJN, T GDMNFPEECEP, EqualityComparer<T> ENFOKHPMBND) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x295A5E0", Offset = "0x29595E0", VA = "0x18295A5E0")]
	public static int BDGBBNPIPBE<TElement, TKey>(this IList<TElement> FDNMHJLBOLP, TKey GINBPAFBNFE, Func<TElement, TKey> MBJLHINNABK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x701F30", Offset = "0x701330")] Func<TKey, TKey, int> BEICPGBGDNM, int EJNMEMKEIOD = 0, [Optional] int? PFDGPOIGHFM) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x295A2F0", Offset = "0x29592F0", VA = "0x18295A2F0")]
	public static int BDGBBNPIPBE<TElement, TKey>(Func<int, TElement> MIPBPJKIPGJ, int ILOICBKCDME, TKey GINBPAFBNFE, Func<TElement, TKey> MBJLHINNABK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x701F90", Offset = "0x701390")] Func<TKey, TKey, int> BEICPGBGDNM, int EJNMEMKEIOD = 0, [Optional] int? PFDGPOIGHFM) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x295D890", Offset = "0x295C890", VA = "0x18295D890")]
	public static List<T> HKOLOPNJFLG<T>(this IReadOnlyList<T> IHMGNIOOIJN, int PFDGPOIGHFM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x295C1F0", Offset = "0x295B1F0", VA = "0x18295C1F0")]
	public static bool FGBGOJHBHOK<T>(this List<T> IHMGNIOOIJN, T GDMNFPEECEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x295B150", Offset = "0x295A150", VA = "0x18295B150")]
	public static void EAJODNFLDEM<T>(this List<T> IHMGNIOOIJN, IEnumerable<T> IOBPFBILMIA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x295CDD0", Offset = "0x295BDD0", VA = "0x18295CDD0")]
	public static void HBPDDHHFGHN<T>(this List<T> IHMGNIOOIJN, IEnumerable<T> IOBPFBILMIA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x295E690", Offset = "0x295D690", VA = "0x18295E690")]
	public static T LFFKHKHAHAN<T>(this List<T> IOBPFBILMIA, Predicate<T> MPGELOPFEDM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x295B080", Offset = "0x295A080", VA = "0x18295B080")]
	public static T DIGGFLENNBI<T>(this List<T> IOBPFBILMIA, int EJNMEMKEIOD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2960E30", Offset = "0x295FE30", VA = "0x182960E30")]
	public static bool PHAAOAKCDPM<T>(this List<T> EHLHEMLNPOF, List<T> PNONIHCAEFC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x295E920", Offset = "0x295D920", VA = "0x18295E920")]
	public static T MJGOIJOABMM<T>(this IList<T> IHMGNIOOIJN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x295DAF0", Offset = "0x295CAF0", VA = "0x18295DAF0")]
	public static bool JOCICLHEFLJ<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x701FF0", Offset = "0x7013F0")] IReadOnlyList<T> IHMGNIOOIJN, int EJNMEMKEIOD, [KLLDEAAPMNN(false)][GKLNCOHNNBN("This should be `T?` in C# 9.")] out T MLAOHBBKEKK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x295FEB0", Offset = "0x295EEB0", VA = "0x18295FEB0")]
	public static bool NHDFCCCEGCA<T>(IReadOnlyList<T> IHMGNIOOIJN, ICollection IOBPFBILMIA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2960EC0", Offset = "0x295FEC0", VA = "0x182960EC0")]
	public static void PIMHPKDMBJP<T>(IReadOnlyList<T> IHMGNIOOIJN, ref ICollection IOBPFBILMIA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x295B0F0", Offset = "0x295A0F0", VA = "0x18295B0F0")]
	public static bool DLHEFEALLBK<T>(this IReadOnlyList<T> IHMGNIOOIJN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x295CF70", Offset = "0x295BF70", VA = "0x18295CF70")]
	public static string HHMMEFAEOFL<T>(this IEnumerable<T> IHMGNIOOIJN, string GFHDLIGMPKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x295A240", Offset = "0x2959240", VA = "0x18295A240")]
	public static T ANEDELOFMAO<T>(this IList<T> DPHICODLGJD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x295E6F0", Offset = "0x295D6F0", VA = "0x18295E6F0")]
	public static T LMDPANIDIOE<T>(this IList<T> DPHICODLGJD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x295B5C0", Offset = "0x295A5C0", VA = "0x18295B5C0")]
	public static void EOMJEIAMJJC<T>(this IList<T> DPHICODLGJD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2959E30", Offset = "0x2958E30", VA = "0x182959E30")]
	public static void AJEGBMDMBED<T>(this IList<T> DPHICODLGJD, in T CKMKMNKGMMC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2960D90", Offset = "0x295FD90", VA = "0x182960D90")]
	public static T NIJLJDFDNCB<T>(this IList<T> DPHICODLGJD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x295AEF0", Offset = "0x2959EF0", VA = "0x18295AEF0")]
	public static void BPAAAOJMCDB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7020A0", Offset = "0x7014A0")] this List<T> DPHICODLGJD) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PKHBEBCJEKD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OAAPDHKBGGL<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x21D6D50", Offset = "0x21D5D50", VA = "0x1821D6D50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x185A3D0", Offset = "0x18593D0", VA = "0x18185A3D0")]
		[DebuggerHidden]
		public OAAPDHKBGGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x21D6B00", Offset = "0x21D5B00", VA = "0x1821D6B00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x21D6CD0", Offset = "0x21D5CD0", VA = "0x1821D6CD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x21D6C30", Offset = "0x21D5C30", VA = "0x1821D6C30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1F52770", Offset = "0x1F51770", VA = "0x181F52770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2ED8560", Offset = "0x2ED7560", VA = "0x182ED8560")]
	public static void KCMOPOOCCGK<T>(this T DIIOIJOPPCN, Action<T> BLEMOMOMAKE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2ED8710", Offset = "0x2ED7710", VA = "0x182ED8710")]
	public static V PMLJBEFJJME<V, T>(this T DIIOIJOPPCN, Func<T, V> BLEMOMOMAKE, [Optional][GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")] V AFGLNBMEDLH) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2ED85A0", Offset = "0x2ED75A0", VA = "0x182ED85A0")]
	public static T? NKBNLKOJMMO<T>(this T DPHICODLGJD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1E13D60", Offset = "0x1E12D60", VA = "0x181E13D60")]
	[IteratorStateMachine(typeof(OAAPDHKBGGL<>))]
	public static IEnumerable<T> FNKJGJCEKDB<T>(this T DPHICODLGJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2ED87B0", Offset = "0x2ED77B0", VA = "0x182ED87B0")]
	public static T[] PPKALPHABGM<T>(this T DPHICODLGJD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EDBNMODBJEC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long AJKKECLMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct JFILDJPBAPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly EDBNMODBJEC IFPEONGHCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long GLDPEPPCKHN;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x726B760", Offset = "0x726A760", VA = "0x18726B760")]
	public JFILDJPBAPH(EDBNMODBJEC BKPCKGDEGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x726B6D0", Offset = "0x726A6D0", VA = "0x18726B6D0")]
	public long MGFGHGAFJDO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x726B5B0", Offset = "0x726A5B0", VA = "0x18726B5B0")]
	public double ANABMJDODBB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x726B640", Offset = "0x726A640", VA = "0x18726B640")]
	public double LOKHPAHAPGB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KEGJJDEFJLE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4A374C0", Offset = "0x4A364C0", VA = "0x184A374C0")]
	public static bool ICKEHDADKJD(this Type DPHICODLGJD, Type JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2346560", Offset = "0x2345560", VA = "0x182346560")]
	public static bool ICKEHDADKJD<T>(this Type DPHICODLGJD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JKCNFPCPOMB
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GMDBILMCIGN(int KNNOMCDMNDJ, int IMANPDNENPO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float PKNJHPKHEIH(float GJBKBDIPBMK, float LFGABGAGMLN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MNJCFMBDMCF
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x116BDA0", Offset = "0x116ADA0", VA = "0x18116BDA0")]
	public static void DMICLBPODJA<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702230", Offset = "0x701630")] this in KeyValuePair<TKey, TValue> DPHICODLGJD, out TKey CDBHHMNALJL, out TValue CKMKMNKGMMC) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x116BB00", Offset = "0x116AB00", VA = "0x18116BB00")]
	public static (TKey?, TValue?) BIGMBJDEGKC<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7022A0", Offset = "0x7016A0")] this in KeyValuePair<TKey?, TValue?> DPHICODLGJD)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x116BF60", Offset = "0x116AF60", VA = "0x18116BF60")]
	public static KeyValuePair<TKey?, UValue?> MGJCIMJCFAO<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702310", Offset = "0x701710")] this KeyValuePair<TKey?, TValue?> DPHICODLGJD, UValue CKMKMNKGMMC)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KCLCAEFEKPF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x13BB610", Offset = "0x13BA610", VA = "0x1813BB610")]
	[CLJAKKFHCIL("This should be replaced with the `is not` operator in C# 9.")]
	public static bool HHJCLMHLKBI<T>(this object DPHICODLGJD, [PNMIPGNDCLG(true)] out T MLAOHBBKEKK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CDLGFAMGBCL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7269F40", Offset = "0x7268F40", VA = "0x187269F40")]
	private static byte[] FOPGELLLIAM(int FCIFIOFFLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7269EC0", Offset = "0x7268EC0", VA = "0x187269EC0")]
	private static byte[] AFIFFOFDFHD(long KNCNFHJIOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x726A880", Offset = "0x7269880", VA = "0x18726A880")]
	private static byte[] PCCLJCJOAAL(ulong KNCNFHJIOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x726A620", Offset = "0x7269620", VA = "0x18726A620")]
	public static Guid LBNJMJNNHIM(params Guid[] APLIGKCDFOA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x726A4D0", Offset = "0x72694D0", VA = "0x18726A4D0")]
	public static Guid GGPPECCFBMF(in Guid HDPOPKKIGNP, int EJNMEMKEIOD, int DFLAEIEBLPA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x726A390", Offset = "0x7269390", VA = "0x18726A390")]
	public static Guid GGPPECCFBMF(in Guid HDPOPKKIGNP, long EJNMEMKEIOD, int DFLAEIEBLPA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7269FC0", Offset = "0x7268FC0", VA = "0x187269FC0")]
	public static Guid GGPPECCFBMF(in Guid HDPOPKKIGNP, ulong EJNMEMKEIOD, int DFLAEIEBLPA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x726A460", Offset = "0x7269460", VA = "0x18726A460")]
	public static Guid GGPPECCFBMF(in Guid HDPOPKKIGNP, in Guid OLBEHLJLDJA, int DFLAEIEBLPA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x726A090", Offset = "0x7269090", VA = "0x18726A090")]
	private static Guid GGPPECCFBMF(in Guid HDPOPKKIGNP, byte[] NJEIJEKNEPK, int DFLAEIEBLPA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x726A7A0", Offset = "0x72697A0", VA = "0x18726A7A0")]
	private static void MAMJHIMKEBA(byte[] AGKIPDJPNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x726A5A0", Offset = "0x72695A0", VA = "0x18726A5A0")]
	private static void GKAIFCGLJPE(byte[] AGKIPDJPNCN, int KOMAFEKIKMM, int MKGHCBPGAGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CHIJHDBMKAL
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A73F00", Offset = "0x6A72F00", VA = "0x186A73F00")]
	public static uint GODHNEHJPAK(this uint DPHICODLGJD, int PFDGPOIGHFM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x55BFED0", Offset = "0x55BEED0", VA = "0x1855BFED0")]
	public static uint LODMLNNADKB(this uint DPHICODLGJD, int PFDGPOIGHFM)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MIHFEAGJLDM
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x726BBD0", Offset = "0x726ABD0", VA = "0x18726BBD0")]
	public static int EGMAKDNGLKA(this int DPHICODLGJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x726BB90", Offset = "0x726AB90", VA = "0x18726BB90")]
	public static int ALAMAAKEENO(this int DPHICODLGJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x726BC50", Offset = "0x726AC50", VA = "0x18726BC50")]
	public static int HLCJOPINDLK(this int DPHICODLGJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x726BC40", Offset = "0x726AC40", VA = "0x18726BC40")]
	public static int HDKCKNHCMGK(this int DPHICODLGJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A73F00", Offset = "0x6A72F00", VA = "0x186A73F00")]
	public static int GODHNEHJPAK(this int DPHICODLGJD, int PFDGPOIGHFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55BFED0", Offset = "0x55BEED0", VA = "0x1855BFED0")]
	public static int LODMLNNADKB(this int DPHICODLGJD, int PFDGPOIGHFM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NOKOGMIDIDE
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3122AB0", Offset = "0x3121AB0", VA = "0x183122AB0")]
	public static bool FEOHGKKOHIM<T, U>(this T DPHICODLGJD, in U DCGPCJKHCOO) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3122A20", Offset = "0x3121A20", VA = "0x183122A20")]
	public static bool ABJMCGFDJLJ<T>(ref T DPHICODLGJD, T JONIFABKCAI) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class EEJGHMEPHEO
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float GGOEAEHAPHP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float EPHLFKNAAIH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool FJJFGLKMLPO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float PGPAFGMFHHI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x726AC00", Offset = "0x7269C00", VA = "0x18726AC00")]
	public static bool IFCLLKHFMON(float CDICEDNOPPN, float ANCILJKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x46FE720", Offset = "0x46FD720", VA = "0x1846FE720")]
	public static float CIICKEJNMHC(float CKMKMNKGMMC, float BEMEKAFAHNO, float OPMIDBCHPFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x46FE740", Offset = "0x46FD740", VA = "0x1846FE740")]
	public static int CIICKEJNMHC(int CKMKMNKGMMC, int BEMEKAFAHNO, int OPMIDBCHPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x46FE700", Offset = "0x46FD700", VA = "0x1846FE700")]
	public static float LIEIHOOCPPK(float CKMKMNKGMMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x726AA90", Offset = "0x7269A90", VA = "0x18726AA90")]
	public static float CBPNKLCNPHE(float CDICEDNOPPN, float ANCILJKDKHM, float DIIOIJOPPCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x726AB30", Offset = "0x7269B30", VA = "0x18726AB30")]
	public static float CGCOPGEBFEC(float CDICEDNOPPN, float ANCILJKDKHM, float DIIOIJOPPCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x726AB40", Offset = "0x7269B40", VA = "0x18726AB40")]
	public static float GEGFLCNMCOH(float CDICEDNOPPN, float ANCILJKDKHM, float CKMKMNKGMMC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x726AA50", Offset = "0x7269A50", VA = "0x18726AA50")]
	public static float BDIOPPLKEEG(float CDICEDNOPPN, float ANCILJKDKHM, float CKMKMNKGMMC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class OCJEFGABGIG
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29255B0", Offset = "0x29245B0", VA = "0x1829255B0")]
	public static TValue FLPKHHIDOKH<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> DPHICODLGJD, TKey CDBHHMNALJL) where TValue : class where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2925850", Offset = "0x2924850", VA = "0x182925850")]
	public static bool IFBACHCCNJB<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> DPHICODLGJD, IReadOnlyDictionary<TKey, TValue> JONIFABKCAI) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NJGHNHCAJOH : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KMMILJAOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOPHNHDDMPL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FGMMHMALJJF
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class DPCPLGLKDFL : JKCNFPCPOMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random FPHEPLPJDOD;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x726A940", Offset = "0x7269940", VA = "0x18726A940", Slot = "4")]
		public int GMDBILMCIGN(int GJBKBDIPBMK, int MCHOCBPNPFJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x726A970", Offset = "0x7269970", VA = "0x18726A970", Slot = "5")]
		public float PKNJHPKHEIH(float GJBKBDIPBMK, float LFGABGAGMLN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x726A900", Offset = "0x7269900", VA = "0x18726A900")]
		private double ALMPHFBEIKJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x726A9E0", Offset = "0x72699E0", VA = "0x18726A9E0")]
		public DPCPLGLKDFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JKCNFPCPOMB HKOLOPNJFLG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x726ADE0", Offset = "0x7269DE0", VA = "0x18726ADE0")]
	public static ulong KPHFKNBBCBN()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ANFBFJELFKF
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool CGHKBIPIHAL<TArgs, T>(in TArgs JMLOLLOGKEE, T GDMNFPEECEP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U FBLKNJOENOK<TArg, U>(in TArg HKOOLAFMDPF);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U DPKJIKAMJLM<TArg, T, U>(in TArg HKOOLAFMDPF, T OMNHNNHGJAE);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U BCCIHLCLEAG<TArg, T, U>(in TArg HKOOLAFMDPF, IEnumerable<T> KKCHKODIJBH);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U JNLANEEKOLA<TArg, T, U>(in TArg HKOOLAFMDPF, T OMNHNNHGJAE);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct KJLFMGCGHAK<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x232CEB0", Offset = "0x232BEB0", VA = "0x18232CEB0")]
		[GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) JIKKDHECCLP(T OPHOEKADGIB)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x232CE40", Offset = "0x232BE40", VA = "0x18232CE40")]
		[GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) FMNPHOKAINH(IEnumerable<T> ECHHPMHCMMG)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OLNNGEBKLDB<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IEnumerable<U> other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public IEnumerable<U> <>3__other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private T with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T <>3__with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IEnumerator<T> <selfEnumerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IEnumerator<U> <otherEnumerator>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool <selfDidMove>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool <otherDidMove>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x185A3D0", Offset = "0x18593D0", VA = "0x18185A3D0")]
		[DebuggerHidden]
		public OLNNGEBKLDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x25E69A0", Offset = "0x25E59A0", VA = "0x1825E69A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x25E63C0", Offset = "0x25E53C0", VA = "0x1825E63C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x25E5CA0", Offset = "0x25E4CA0", VA = "0x1825E5CA0")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x25E6760", Offset = "0x25E5760", VA = "0x1825E6760")]
		private void PJBNDPOBDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x25E6890", Offset = "0x25E5890", VA = "0x1825E6890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E530", Offset = "0x1F3D530", VA = "0x181F3E530", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F36CD0", Offset = "0x1F35CD0", VA = "0x181F36CD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class PBCGIHIENIE<T> : IEnumerable<(T, JNDLNMMKMGN<T>)>, IEnumerable, IEnumerator<(T, JNDLNMMKMGN<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, JNDLNMMKMGN<T> Next) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<T> <enumerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private T <current>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private (T, JNDLNMMKMGN<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x32D01D0", Offset = "0x32CF1D0", VA = "0x1832D01D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, JNDLNMMKMGN<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x32D0400", Offset = "0x32CF400", VA = "0x1832D0400", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F750", Offset = "0x1F0E750", VA = "0x181F0F750")]
		[DebuggerHidden]
		public PBCGIHIENIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x32D0450", Offset = "0x32CF450", VA = "0x1832D0450", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x32CF740", Offset = "0x32CE740", VA = "0x1832CF740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x32CED80", Offset = "0x32CDD80", VA = "0x1832CED80")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x32D0270", Offset = "0x32CF270", VA = "0x1832D0270", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x32D0120", Offset = "0x32CF120", VA = "0x1832D0120", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, JNDLNMMKMGN<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2342FA0", Offset = "0x2341FA0", VA = "0x182342FA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CIKDKMEELOA<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private U <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702B40", Offset = "0x701F40")]
		private Func<KJLFMGCGHAK<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702C30", Offset = "0x702030")]
		public Func<KJLFMGCGHAK<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IEnumerator<T> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T <item>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <zero>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private U <one>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerable<U> <many>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<U> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private U <manyItem>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x185A3D0", Offset = "0x18593D0", VA = "0x18185A3D0")]
		[DebuggerHidden]
		public CIKDKMEELOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2180600", Offset = "0x217F600", VA = "0x182180600", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x21800B0", Offset = "0x217F0B0", VA = "0x1821800B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2180060", Offset = "0x217F060", VA = "0x182180060")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2180480", Offset = "0x217F480", VA = "0x182180480")]
		private void PJBNDPOBDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x21805C0", Offset = "0x217F5C0", VA = "0x1821805C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x21804D0", Offset = "0x217F4D0", VA = "0x1821804D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2180590", Offset = "0x217F590", VA = "0x182180590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DHDCFPCBPMG<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public DHDCFPCBPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2695070", Offset = "0x2694070", VA = "0x182695070")]
		internal bool AHGCALPHNNI(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x26950B0", Offset = "0x26940B0", VA = "0x1826950B0")]
		internal bool MCFLOJBIHII(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FIHKDCJEAEH<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IEnumerator<T> <lhsIt>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private IEnumerator<U> <rhsIt>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xACBFD0", Offset = "0xACAFD0", VA = "0x180ACBFD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F0F700", Offset = "0x1F0E700", VA = "0x181F0F700", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F750", Offset = "0x1F0E750", VA = "0x181F0F750")]
		[DebuggerHidden]
		public FIHKDCJEAEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F3D0", Offset = "0x1F0E3D0", VA = "0x181F0F3D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F6C0", Offset = "0x1F0E6C0", VA = "0x181F0F6C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F600", Offset = "0x1F0E600", VA = "0x181F0F600", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xEE4360", Offset = "0xEE3360", VA = "0x180EE4360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1B3D0E0", Offset = "0x1B3C0E0", VA = "0x181B3D0E0")]
	public static bool BCOBACMGFBL<T, TArgs>(this IEnumerable<T> DPHICODLGJD, in TArgs JMLOLLOGKEE, CGHKBIPIHAL<TArgs, T> EOOJLCJHMJA) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F3D0", Offset = "0x1B3E3D0", VA = "0x181B3F3D0")]
	public static U HIEMHCFGKFI<U, T>(this IEnumerable<T> DPHICODLGJD, Func<U> DEDMMHFACJK, Func<T, U> OPHOEKADGIB, Func<IEnumerable<T>, U> ECHHPMHCMMG) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1B3E220", Offset = "0x1B3D220", VA = "0x181B3E220")]
	public static bool GIELALFPKMG<T, TArgs>(this IEnumerable<T> DPHICODLGJD, in TArgs JMLOLLOGKEE, CGHKBIPIHAL<TArgs, T> EOOJLCJHMJA) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1B3D960", Offset = "0x1B3C960", VA = "0x181B3D960")]
	public static U DMGFEIGFIKO<U, T, TArg>(this IEnumerable<T> DPHICODLGJD, in TArg HKOOLAFMDPF, FBLKNJOENOK<TArg, U> DEDMMHFACJK, DPKJIKAMJLM<TArg, T, U> OPHOEKADGIB, BCCIHLCLEAG<TArg, T, U> ECHHPMHCMMG) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1B3D540", Offset = "0x1B3C540", VA = "0x181B3D540")]
	public static IEnumerable<U> CKEFGDAOJPK<U, T, TArg>(this IEnumerable<T> DPHICODLGJD, in TArg HKOOLAFMDPF, JNLANEEKOLA<TArg, T, U> BODAADIHHJP) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x11697A0", Offset = "0x11687A0", VA = "0x1811697A0")]
	public static IEnumerable<T> CAGEOLAONFC<T>(params IEnumerable<T>[] CBFLDJLKLDL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F580", Offset = "0x1B3E580", VA = "0x181B3F580")]
	public static bool HKNGDFHNDPB<T>(this IEnumerable<T> PCALNIOABDP, IEnumerable<T> JONIFABKCAI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x11697A0", Offset = "0x11687A0", VA = "0x1811697A0")]
	public static IEnumerable<(TKey?, TValue?)>? DINCJOKMFPA<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702460", Offset = "0x701860")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1B409B0", Offset = "0x1B3F9B0", VA = "0x181B409B0")]
	public static IEnumerable<T> LBIGPABCEAB<T, TKey>(this IEnumerable<T> NALKKEFIEJB, Func<T, TKey> CJLMEGECKDE) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xFF9720", Offset = "0xFF8720", VA = "0x180FF9720")]
	[IteratorStateMachine(typeof(OLNNGEBKLDB<, >))]
	public static IEnumerable<T> MJFFIAIHHFG<T, U>(this IEnumerable<T> DPHICODLGJD, IEnumerable<U> JONIFABKCAI, [Optional][GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")] T GOCDPPPLDNH) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1B40910", Offset = "0x1B3F910", VA = "0x181B40910")]
	public static T KLJGPFFAMLG<T>(this IEnumerable<T> PCALNIOABDP, T AFGLNBMEDLH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1B40940", Offset = "0x1B3F940", VA = "0x181B40940")]
	public static T KLJGPFFAMLG<T>(this IEnumerable<T> PCALNIOABDP, T AFGLNBMEDLH, Func<T, bool> EOOJLCJHMJA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1B403E0", Offset = "0x1B3F3E0", VA = "0x181B403E0")]
	public static T? JKMKNEMEHOJ<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702530", Offset = "0x701930")] this IEnumerable<T> DPHICODLGJD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702590", Offset = "0x701990")] Func<T, bool> EOOJLCJHMJA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1B40C90", Offset = "0x1B3FC90", VA = "0x181B40C90")]
	[IteratorStateMachine(typeof(PBCGIHIENIE<>))]
	public static IEnumerable<(T, JNDLNMMKMGN<T>)> MCIMIPLOIGN<T>(this IEnumerable<T> DPHICODLGJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F740", Offset = "0x1B3E740", VA = "0x181B3F740")]
	public static bool IKMMHLCJJGE<T>(this IEnumerable<T> DPHICODLGJD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x11697A0", Offset = "0x11687A0", VA = "0x1811697A0")]
	public static IEnumerable<FFDJOBIIGBH<T>> EHPNNEFNFPF<T>(this IEnumerable<T> DPHICODLGJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1B40990", Offset = "0x1B3F990", VA = "0x181B40990")]
	public static bool LADFHPMJJHE<T>(this IEnumerable<T> DPHICODLGJD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1B40E60", Offset = "0x1B3FE60", VA = "0x181B40E60")]
	public static IEnumerable<T> NKGJHGKFHFA<T>(this IEnumerable<T> DPHICODLGJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xFF9680", Offset = "0xFF8680", VA = "0x180FF9680")]
	[IteratorStateMachine(typeof(CIKDKMEELOA<, >))]
	public static IEnumerable<U> FMHFEAOHMMD<U, T>(this IEnumerable<T> DPHICODLGJD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7026C0", Offset = "0x701AC0")] Func<KJLFMGCGHAK<U>, T, (bool Zero, U One, IEnumerable<U> Many)> MHICIOEEPOE) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1B3E760", Offset = "0x1B3D760", VA = "0x181B3E760")]
	public static int GLAKDOMDIGD<T>(this IEnumerable<T> DPHICODLGJD, int NOFCNJLFFMP = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F830", Offset = "0x1B3E830", VA = "0x181B3F830")]
	public static bool IOHLKJKCMJO<T>(this IEnumerable<T> DPHICODLGJD, IEnumerable<T> JONIFABKCAI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1B40680", Offset = "0x1B3F680", VA = "0x181B40680")]
	public static (IEnumerable<T>, IEnumerable<T>) JLAOJGPKGJA<T>(this IEnumerable<T> DPHICODLGJD, Func<T, bool> EDFFIJNFNGE) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1B3DDC0", Offset = "0x1B3CDC0", VA = "0x181B3DDC0")]
	public static string FBMGLDOLPNP<T>(this IEnumerable<T> DPHICODLGJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F080", Offset = "0x1B3E080", VA = "0x181B3F080")]
	public static Dictionary<TKey?, TValue?>? HENCKJJNIIO<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7027B0", Offset = "0x701BB0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? PCALNIOABDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F080", Offset = "0x1B3E080", VA = "0x181B3F080")]
	public static Dictionary<TKey?, TValue?>? HENCKJJNIIO<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x702810", Offset = "0x701C10")] this IEnumerable<(TKey? Key, TValue? Value)>? PCALNIOABDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x13ED190", Offset = "0x13EC190", VA = "0x1813ED190")]
	public static HashSet<T> OAOPPMOFHDN<T>(this IEnumerable<T> DPHICODLGJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1B3D520", Offset = "0x1B3C520", VA = "0x181B3D520")]
	public static string BOKIFGJJMPF<T>(this IEnumerable<T> DPHICODLGJD, string HCFFCPJOIEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xFF95E0", Offset = "0xFF85E0", VA = "0x180FF95E0")]
	[IteratorStateMachine(typeof(FIHKDCJEAEH<, >))]
	public static IEnumerable<(T, U)> PAPFKAHJBEI<T, U>(this IEnumerable<T> BEHCKOODGGG, IEnumerable<U> IOJJDIDNFKB) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1B3EE00", Offset = "0x1B3DE00", VA = "0x181B3EE00")]
	public static IEnumerable<V> HDODGMIOAGD<V, T, U>(this IEnumerable<T> DPHICODLGJD, IEnumerable<U> JONIFABKCAI, Func<T, U, V> ONIAJDPODHM, [Optional][GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")] T KLFDJGOJJDB, [Optional][GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")] U NOPECFIABCA) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1B3EE90", Offset = "0x1B3DE90", VA = "0x181B3EE90")]
	public static IEnumerable<(T, U)> HDODGMIOAGD<T, U>(this IEnumerable<T> DPHICODLGJD, IEnumerable<U> JONIFABKCAI, [Optional][GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")] T KLFDJGOJJDB, [Optional][GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")] U NOPECFIABCA) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class LGKCEOILADJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x23546A0", Offset = "0x23536A0", VA = "0x1823546A0")]
	public static bool MOIDNHEFMML<T>(this IReadOnlyCollection<T> DPHICODLGJD, int EJNMEMKEIOD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class PDIJOHMDIDE : EDBNMODBJEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch IFPEONGHCNG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long AJKKECLMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x726BFE0", Offset = "0x726AFE0", VA = "0x18726BFE0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	private PDIJOHMDIDE(Stopwatch BKPCKGDEGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x726BF80", Offset = "0x726AF80", VA = "0x18726BF80")]
	public static PDIJOHMDIDE CMAEOLEFHDL(Stopwatch BKPCKGDEGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x726C000", Offset = "0x726B000", VA = "0x18726C000")]
	public static PDIJOHMDIDE OFDFDODCHFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AHBHJAOHCJE
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7269DF0", Offset = "0x7268DF0", VA = "0x187269DF0")]
	public static RigidTransform NODOMEJFFEK(RigidTransform IPBLPCMCPNC, RigidTransform NMOMIEKCICE)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CDHBLPNGLDE<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct PLCHGKJAIAL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E76C20", Offset = "0x1E75C20", VA = "0x181E76C20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int KEDBOFECIEH;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static JFILDJPBAPH NJDAFBKDGKF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long AJKKECLMDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x216F960", Offset = "0x216E960", VA = "0x18216F960")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x216FB50", Offset = "0x216EB50", VA = "0x18216FB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x216F9B0", Offset = "0x216E9B0", VA = "0x18216F9B0")]
	public static PLCHGKJAIAL LLJHPNBGHHH()
	{
		return default(PLCHGKJAIAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x216FC10", Offset = "0x216EC10", VA = "0x18216FC10")]
	private static void PKNPJBDALPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x216FBB0", Offset = "0x216EBB0", VA = "0x18216FBB0")]
	public static void OMJIIKCHOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class AFDHCMCCOJA
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A21A70", Offset = "0x2A20A70", VA = "0x182A21A70")]
	public static bool BIMCHHIIGLB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703140", Offset = "0x702540")] this in ReadOnlySpan<T?> DPHICODLGJD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7031B0", Offset = "0x7025B0")] in ReadOnlySpan<T?> JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A22580", Offset = "0x2A21580", VA = "0x182A22580")]
	public static int GLAKDOMDIGD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703220", Offset = "0x702620")] this in ReadOnlySpan<T?> DPHICODLGJD, int NOFCNJLFFMP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A22340", Offset = "0x2A21340", VA = "0x182A22340")]
	public static string FBMGLDOLPNP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703290", Offset = "0x702690")] this in ReadOnlySpan<T> DPHICODLGJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A21BF0", Offset = "0x2A20BF0", VA = "0x182A21BF0")]
	public static string BOKIFGJJMPF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703300", Offset = "0x702700")] this in ReadOnlySpan<T> DPHICODLGJD, string HCFFCPJOIEP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OIDFAMNCHFM
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x58BFA20", Offset = "0x58BEA20", VA = "0x1858BFA20")]
	public static bool DLHEFEALLBK(this string? BJFKJLHFKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x726BED0", Offset = "0x726AED0", VA = "0x18726BED0")]
	public static string? NFHKADAAOBG(this string? DPHICODLGJD, int GBMCFPCCNIJ, string NAFEDCNDKAC = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x726BE30", Offset = "0x726AE30", VA = "0x18726BE30")]
	public static string EHGHCGBOGNE(this string DPHICODLGJD, int GBMCFPCCNIJ, string NAFEDCNDKAC = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class GAANHDNKPPI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static EDBNMODBJEC PBFMNKIDAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x726B470", Offset = "0x726A470", VA = "0x18726B470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x726B3E0", Offset = "0x726A3E0", VA = "0x18726B3E0")]
	public static double ANABMJDODBB(this EDBNMODBJEC DPHICODLGJD, long CEGCAFDHJKB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class MDILEOGNCEI
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int GOHGJGAAHIF<T>(in T BEHCKOODGGG, in T IOJJDIDNFKB);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class OEFHAIJIDJA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct IDFGMJGDAAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int GOKCMPDIEBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int ILEBHLNPNAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool CKOACDBJMGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int OBDCGBGILCD;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1859930", Offset = "0x1858930", VA = "0x181859930")]
			public IDFGMJGDAAC(int GOKCMPDIEBG, int ILEBHLNPNAO, bool CKOACDBJMGF)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] JBNDOBLJKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] KFACGFNMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly GOHGJGAAHIF<T> BEICPGBGDNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int BFMPKEEBFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> OICBMFGDMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int GHGLNGCOFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703450", Offset = "0x702850")]
		private readonly OEFHAIJIDJA<T>.IDFGMJGDAAC[] IOOMJCHPBGL;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2C29A20", Offset = "0x2C28A20", VA = "0x182C29A20")]
		public OEFHAIJIDJA(T[] JBNDOBLJKCD, GOHGJGAAHIF<T> BEICPGBGDNM, int BFMPKEEBFHL, Func<bool> OICBMFGDMPE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7034B0", Offset = "0x7028B0")] T[] BEPEJAGGMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2C29370", Offset = "0x2C28370", VA = "0x182C29370")]
		public bool CCDJKOJDLAE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U IOFKEAAKMPF<T, U>(int BPMFIDIMBEE, int FIJLOIABDKO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x703510", Offset = "0x702910")] in ReadOnlySpan<T> OHOOKNEEEGG);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0E10", Offset = "0x2DDFE10", VA = "0x182DE0E10")]
	public static T[] FJLLMKIMHGP<T>(int GFFJJOEGODF, T GOCDPPPLDNH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DE26C0", Offset = "0x2DE16C0", VA = "0x182DE26C0")]
	public static void ONFABOKMNGC<T>(this T[] KDMBIONAEFF, T GOCDPPPLDNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F135D0", Offset = "0x1F125D0", VA = "0x181F135D0")]
	public static void ELAKEGDGCLL<T>(this T[] OGEGDDKCPPH, int MBMAEEFDADD, int LPDDOLBOCMH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1AA0", Offset = "0x2DE0AA0", VA = "0x182DE1AA0")]
	private static void NCGONCFEIBN<T>(this T[] DPHICODLGJD, int IKDEPLPAEOG, int KODMEKKDHIA, T[] JONIFABKCAI, int LEMGPMNFKME, int AKDDIIFPBEB, T[] MLAOHBBKEKK, int JJCGICECOBE, GOHGJGAAHIF<T> BEICPGBGDNM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0F90", Offset = "0x2DDFF90", VA = "0x182DE0F90")]
	public static void GJGPICGPFLJ<T>(this T[] DPHICODLGJD, int GOKCMPDIEBG, int PFDGPOIGHFM, GOHGJGAAHIF<T> BEICPGBGDNM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2DE19E0", Offset = "0x2DE09E0", VA = "0x182DE19E0")]
	public static OEFHAIJIDJA<T> IGHGDGGNOGI<T>(this T[] DPHICODLGJD, GOHGJGAAHIF<T> BEICPGBGDNM, int BFMPKEEBFHL, Func<bool> OICBMFGDMPE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7033F0", Offset = "0x7027F0")] T[] BEPEJAGGMMB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1A80", Offset = "0x2DE0A80", VA = "0x182DE1A80")]
	public static T[] JLPIHGCCKLF<T>(this T[] OGEGDDKCPPH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0C80", Offset = "0x2DDFC80", VA = "0x182DE0C80")]
	public static T[] ANCCPCMFIJB<T>(this T[] IIOHFMNPHNH, T EPNNIEKFFJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2DE13F0", Offset = "0x2DE03F0", VA = "0x182DE13F0")]
	public static T[] GNKKLKPOCLN<T>(this T[] IIOHFMNPHNH, int EJNMEMKEIOD, T EPNNIEKFFJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1EA0", Offset = "0x2DE0EA0", VA = "0x182DE1EA0")]
	public static T[] NGJIBJLCOHH<T>(this T[] IIOHFMNPHNH, int EJNMEMKEIOD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1F50", Offset = "0x2DE0F50", VA = "0x182DE1F50")]
	public static T[] OJLIOEGDFHJ<T>(this T[] IIOHFMNPHNH, int EJNMEMKEIOD, T EPNNIEKFFJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2180", Offset = "0x2DE1180", VA = "0x182DE2180")]
	public static U[] OKHLNLAAMGA<U, T>(this T[] GDJIPDMDHHM, int ACMHADMCMOI, IOFKEAAKMPF<T, U> FDEAAEHLKMB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x726B9B0", Offset = "0x726A9B0", VA = "0x18726B9B0")]
	public static byte[] KLLGHIBDIBH(this byte[] DPHICODLGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x726B7D0", Offset = "0x726A7D0", VA = "0x18726B7D0")]
	public static byte[] EKMOHPGGDAJ(this byte[] DPHICODLGJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JEPGHDJAHGE
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x20B20D0", Offset = "0x20B10D0", VA = "0x1820B20D0")]
	public static void MOJOEOEOBAD<K, V>(this IDictionary<K, V> DPHICODLGJD, in K CDBHHMNALJL, in V CKMKMNKGMMC, Func<V, V, V> HIOMAJLFJLF) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x20B0C30", Offset = "0x20AFC30", VA = "0x1820B0C30")]
	public static void JPJOBHALFBM<K, V>(this IDictionary<K, List<V>> DPHICODLGJD, in K CDBHHMNALJL, in V CKMKMNKGMMC) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x20B1D50", Offset = "0x20B0D50", VA = "0x1820B1D50")]
	public static TVal KGKILFBDHLD<TVal, TKey>(this IDictionary<TKey, TVal> AINALLHHLMD, in TKey CDBHHMNALJL, [Optional][GKLNCOHNNBN("`default!` shouldn't be necessary in C# 9")] TVal AFGLNBMEDLH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x20B1380", Offset = "0x20B0380", VA = "0x1820B1380")]
	public static TVal KGKILFBDHLD<TVal, TKey>(this IDictionary<TKey, TVal> AINALLHHLMD, in TKey CDBHHMNALJL, Func<TVal> PAAAPCCBGGC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x20B0B60", Offset = "0x20AFB60", VA = "0x1820B0B60")]
	public static TValue FAEFMOGHDHA<TValue, TKey>(this IDictionary<TKey, TValue> AINALLHHLMD, in TKey CDBHHMNALJL, [Optional][GKLNCOHNNBN("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue AFGLNBMEDLH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x20B2720", Offset = "0x20B1720", VA = "0x1820B2720")]
	public static V NLFKMLFGKBJ<V, K>(this IDictionary<K, V> DPHICODLGJD, in K CDBHHMNALJL) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x20B0210", Offset = "0x20AF210", VA = "0x1820B0210")]
	public static T2[] BCIJGOFCAEP<T2, T1>(this Dictionary<T1, T2>.ValueCollection AAIJKDAGGDK) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x20B02A0", Offset = "0x20AF2A0", VA = "0x1820B02A0")]
	public static bool DOIKGLENCKK<TKey, TValue>(this IDictionary<TKey, TValue> DPHICODLGJD, TKey CDBHHMNALJL, TValue CKMKMNKGMMC) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FOMIHGCPOEP
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x726B120", Offset = "0x726A120", VA = "0x18726B120")]
	public static float3 MKMPHCFHOIN(this in RigidTransform DPHICODLGJD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x726B250", Offset = "0x726A250", VA = "0x18726B250")]
	public static float3 NCHEHAFAMPC(this in RigidTransform DPHICODLGJD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1ED3C80", Offset = "0x1ED2C80", VA = "0x181ED3C80")]
	public static (float3, float3, float3) FPHGAFPIHAK(this in RigidTransform DPHICODLGJD)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x726B380", Offset = "0x726A380", VA = "0x18726B380")]
	public static RigidTransform PFCFCKIELFH(this in RigidTransform DPHICODLGJD)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class DBGHCFJNGEL
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x221DA50", Offset = "0x221CA50", VA = "0x18221DA50")]
	public static bool BBJOPJDJGON<T>(this IReadOnlyList<T> DPHICODLGJD, int EJNMEMKEIOD, [GKLNCOHNNBN("This should be `T?` in C# 9.")][PNMIPGNDCLG(true)] out T MLAOHBBKEKK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x221DAE0", Offset = "0x221CAE0", VA = "0x18221DAE0")]
	public static bool EIOPJEGMAGA<T>(this IReadOnlyList<T> DPHICODLGJD, int EJNMEMKEIOD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7036F0", Offset = "0x702AF0")] out FFDJOBIIGBH<T> MLAOHBBKEKK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x221D940", Offset = "0x221C940", VA = "0x18221D940")]
	public static T AENPMDGDMPE<T>(this IReadOnlyList<T> DPHICODLGJD, int EJNMEMKEIOD, in T IJOJBGAJNCD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8DC0", Offset = "0x1FC7DC0", VA = "0x181FC8DC0")]
	[GKLNCOHNNBN("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T FLPKHHIDOKH<T>(this IReadOnlyList<T> DPHICODLGJD, int EJNMEMKEIOD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x221DBA0", Offset = "0x221CBA0", VA = "0x18221DBA0")]
	public static T? MIBADKBJCFP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7037A0", Offset = "0x702BA0")] this IReadOnlyList<T> DPHICODLGJD, int EJNMEMKEIOD) where T : struct
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
