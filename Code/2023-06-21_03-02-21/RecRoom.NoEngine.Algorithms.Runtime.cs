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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x70D7130", Offset = "0x70D6330", VA = "0x1870D7130")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CJAAIJLFEPL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70D56F0", Offset = "0x70D48F0", VA = "0x1870D56F0")]
	public static (float3, float3, float3) LNMLFIJJBNJ(this in quaternion DCMHODHEGEC)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LEPMAOKEGCP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3341570", Offset = "0x3340770", VA = "0x183341570")]
	public static bool ICHOAIKKGIH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D5BB0", Offset = "0x7D4FB0")] this in ReadOnlyMemory<T> DCMHODHEGEC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D5C20", Offset = "0x7D5020")] in ReadOnlyMemory<T> HPOECFLNEOJ) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3341780", Offset = "0x3340980", VA = "0x183341780")]
	public static int PACIKMHJFBN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D5C90", Offset = "0x7D5090")] this in ReadOnlyMemory<T?> DCMHODHEGEC, int ECHGAGIEPKE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3341690", Offset = "0x3340890", VA = "0x183341690")]
	public static string LKPIFHBJENF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D5D00", Offset = "0x7D5100")] this in ReadOnlyMemory<T> DCMHODHEGEC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FIHMEFBHCCM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3839FD0", Offset = "0x38391D0", VA = "0x183839FD0")]
	public static void KCFEDKFMPOF<T>(this ICollection<T> DCMHODHEGEC, IEnumerable<T> KBELBHAMCGD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AOBNDBFGANP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJFGLIGMDDI LBFELGIGDIH();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PKDPNLNCDGI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ANDGMJMPKKF<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public ANDGMJMPKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3931D80", Offset = "0x3930F80", VA = "0x183931D80")]
		internal TElement HGGPOLABIJH(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IJDJPMGBNNO<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public IJDJPMGBNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E50", Offset = "0x9F9050", VA = "0x1809F9E50")]
		internal int ACBJBNAGBMP(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x42F8770", Offset = "0x42F7970", VA = "0x1842F8770")]
	public static int FNFOOKFBACK<T>(this IReadOnlyList<T> BGBPILICHHA, T ACKOJNNBEBO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x42F7170", Offset = "0x42F6370", VA = "0x1842F7170")]
	public static int BAEDINEMDNK<T>(this IReadOnlyList<T> BGBPILICHHA, T ACKOJNNBEBO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x42FC0D0", Offset = "0x42FB2D0", VA = "0x1842FC0D0")]
	public static void KCFEDKFMPOF<T>(this HashSet<T> BOLFPABEECJ, IEnumerable<T> KBELBHAMCGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x42FCEA0", Offset = "0x42FC0A0", VA = "0x1842FCEA0")]
	public static void MINPEOLPAFG<T>(this IList<T> IEKCFDAIBOJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x42FCF20", Offset = "0x42FC120", VA = "0x1842FCF20")]
	public static void MINPEOLPAFG<T>(this IList<T> IEKCFDAIBOJ, int LCHAFMEPJKB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x42F74C0", Offset = "0x42F66C0", VA = "0x1842F74C0")]
	public static List<T> CKAOHGLIPNL<T>(this List<T> FDFEHAHHBAD, Predicate<T> CGMEGCMIEIE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x42F8E90", Offset = "0x42F8090", VA = "0x1842F8E90")]
	public static int FNFOOKFBACK<T>(this IReadOnlyList<T> IEKCFDAIBOJ, Predicate<T> EPCCIGFNMOG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x42F98A0", Offset = "0x42F8AA0", VA = "0x1842F98A0")]
	public static bool ILMCIGCOBKN<T>(this IReadOnlyList<T> IEKCFDAIBOJ, Predicate<T> EPCCIGFNMOG, [OPJMDPNHGGA(true)] out List<int>? AHIAHCMDHBC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x42FE170", Offset = "0x42FD370", VA = "0x1842FE170")]
	public static bool PLLNGOBMPBN<T>(this IReadOnlyList<T> IEKCFDAIBOJ, T FNPJDMFCFGH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x42FE1C0", Offset = "0x42FD3C0", VA = "0x1842FE1C0")]
	public static bool PLLNGOBMPBN<T>(this IReadOnlyList<T> IEKCFDAIBOJ, T FNPJDMFCFGH, EqualityComparer<T> DFLGKGJPBLB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x42F7910", Offset = "0x42F6B10", VA = "0x1842F7910")]
	public static int CPHBKIKBIAM<TElement, TKey>(this IList<TElement> AIOOABGBPLI, TKey JFHCPIAECLK, Func<TElement, TKey> LCOCEKHIDIO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D5E30", Offset = "0x7D5230")] Func<TKey, TKey, int> EIJFIIDKBIJ, int MMFFFGBLCAP = 0, [Optional] int? IGDJHHPIJBK) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42F7620", Offset = "0x42F6820", VA = "0x1842F7620")]
	public static int CPHBKIKBIAM<TElement, TKey>(Func<int, TElement> HFHHMNKIIKC, int IJINLFKFEHJ, TKey JFHCPIAECLK, Func<TElement, TKey> LCOCEKHIDIO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D5E90", Offset = "0x7D5290")] Func<TKey, TKey, int> EIJFIIDKBIJ, int MMFFFGBLCAP = 0, [Optional] int? IGDJHHPIJBK) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42F95B0", Offset = "0x42F87B0", VA = "0x1842F95B0")]
	public static List<T> IDMBKEDFPHF<T>(this IReadOnlyList<T> IEKCFDAIBOJ, int IGDJHHPIJBK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42F8400", Offset = "0x42F7600", VA = "0x1842F8400")]
	public static bool EEPAICNPDAP<T>(this List<T> IEKCFDAIBOJ, T FNPJDMFCFGH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x42F6FB0", Offset = "0x42F61B0", VA = "0x1842F6FB0")]
	public static void ALJDGBFLNBM<T>(this List<T> IEKCFDAIBOJ, IEnumerable<T> FDFEHAHHBAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x42FD770", Offset = "0x42FC970", VA = "0x1842FD770")]
	public static void PLKCAALIKKA<T>(this List<T> IEKCFDAIBOJ, IEnumerable<T> FDFEHAHHBAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42FD710", Offset = "0x42FC910", VA = "0x1842FD710")]
	public static T PJJNNFCIJED<T>(this List<T> FDFEHAHHBAD, Predicate<T> CGMEGCMIEIE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42F75B0", Offset = "0x42F67B0", VA = "0x1842F75B0")]
	public static T CMDDPCPKOAG<T>(this List<T> FDFEHAHHBAD, int MMFFFGBLCAP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42FD680", Offset = "0x42FC880", VA = "0x1842FD680")]
	public static bool MNBCFHBMEFI<T>(this List<T> PKOFFGOADPN, List<T> NBPJNBLBNJE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42FD5E0", Offset = "0x42FC7E0", VA = "0x1842FD5E0")]
	public static T MLHJLMECOHI<T>(this IList<T> IEKCFDAIBOJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42FCDE0", Offset = "0x42FBFE0", VA = "0x1842FCDE0")]
	public static bool MDGFIONGDHF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D5EF0", Offset = "0x7D52F0")] IReadOnlyList<T> IEKCFDAIBOJ, int MMFFFGBLCAP, [CMFCANKAKKJ("This should be `T?` in C# 9.")][IKMCMOGPPMB(false)] out T GAFKIBJKPNO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x42FB210", Offset = "0x42FA410", VA = "0x1842FB210")]
	public static bool JEIGOHHBCLP<T>(IReadOnlyList<T> IEKCFDAIBOJ, ICollection FDFEHAHHBAD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x42F7390", Offset = "0x42F6590", VA = "0x1842F7390")]
	public static void CAPGFKKGHJD<T>(IReadOnlyList<T> IEKCFDAIBOJ, ref ICollection FDFEHAHHBAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x42F7330", Offset = "0x42F6530", VA = "0x1842F7330")]
	public static bool BEANBPIFODE<T>(this IReadOnlyList<T> IEKCFDAIBOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x42F8220", Offset = "0x42F7420", VA = "0x1842F8220")]
	public static string EDIAMMKMKIF<T>(this IEnumerable<T> IEKCFDAIBOJ, string IDPDLBGLAGH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x42F9290", Offset = "0x42F8490", VA = "0x1842F9290")]
	public static T HDBCLNCHHEG<T>(this IList<T> DCMHODHEGEC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x42FCBB0", Offset = "0x42FBDB0", VA = "0x1842FCBB0")]
	public static T KJCNKJAHECK<T>(this IList<T> DCMHODHEGEC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x42F9810", Offset = "0x42F8A10", VA = "0x1842F9810")]
	public static void IIDLICAEKLG<T>(this IList<T> DCMHODHEGEC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42F9400", Offset = "0x42F8600", VA = "0x1842F9400")]
	public static void HIJDDOMIGFG<T>(this IList<T> DCMHODHEGEC, in T ACKOJNNBEBO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42F6F10", Offset = "0x42F6110", VA = "0x1842F6F10")]
	public static T ACJCNMJDEEC<T>(this IList<T> DCMHODHEGEC) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DCOGNAJPJAF
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EBHDBJDNHMK<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3563DB0", Offset = "0x3562FB0", VA = "0x183563DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2A070F0", Offset = "0x2A062F0", VA = "0x182A070F0")]
		[DebuggerHidden]
		public EBHDBJDNHMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3563B60", Offset = "0x3562D60", VA = "0x183563B60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4475830", Offset = "0x4474A30", VA = "0x184475830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3563C90", Offset = "0x3562E90", VA = "0x183563C90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDF40", Offset = "0x1CBD140", VA = "0x181CBDF40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2C021C0", Offset = "0x2C013C0", VA = "0x182C021C0")]
	public static void JIGKMOIELOP<T>(this T NIKDBMNECCB, Action<T> CMBJELINABH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2C02120", Offset = "0x2C01320", VA = "0x182C02120")]
	public static V IJPDINCNKBO<V, T>(this T NIKDBMNECCB, Func<T, V> CMBJELINABH, [Optional][CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")] V DDGOMDBNGFF) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C02370", Offset = "0x2C01570", VA = "0x182C02370")]
	public static T? NMPEDENENCC<T>(this T DCMHODHEGEC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1961440", Offset = "0x1960640", VA = "0x181961440")]
	[IteratorStateMachine(typeof(EBHDBJDNHMK<>))]
	public static IEnumerable<T> HADCLLEIDCG<T>(this T DCMHODHEGEC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C02260", Offset = "0x2C01460", VA = "0x182C02260")]
	public static T[] LGLECKFBAIC<T>(this T DCMHODHEGEC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PCKJCOJOAIC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long DKJKJOJGJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GKGCJFBJIHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PCKJCOJOAIC DMIDBIBCBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long DKMGCAJKMCP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70D5D80", Offset = "0x70D4F80", VA = "0x1870D5D80")]
	public GKGCJFBJIHM(PCKJCOJOAIC EPHPKLLOIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70D5C60", Offset = "0x70D4E60", VA = "0x1870D5C60")]
	public long JGGHIDJEFEH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70D5BD0", Offset = "0x70D4DD0", VA = "0x1870D5BD0")]
	public double AJCFKMODKBO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x70D5CF0", Offset = "0x70D4EF0", VA = "0x1870D5CF0")]
	public double JJNDFBDAGAJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CBCGNCGAMNI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x501F540", Offset = "0x501E740", VA = "0x18501F540")]
	public static bool FHOJADDGKFB(this Type DCMHODHEGEC, Type HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x322E000", Offset = "0x322D200", VA = "0x18322E000")]
	public static bool FHOJADDGKFB<T>(this Type DCMHODHEGEC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IOEPABEOFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DGJHKAHKEON(int PFBDBIGDHGP, int GBCGHPBJPOA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float FKCFOCDMJPA(float FKJAFOMOGFH, float NBFPEKDKDNP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FBLBOJGIMHB
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3117F80", Offset = "0x3117180", VA = "0x183117F80")]
	public static void GLEFOFFFOIN<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6120", Offset = "0x7D5520")] this in KeyValuePair<TKey, TValue> DCMHODHEGEC, out TKey PPNIGBBPGOI, out TValue ACKOJNNBEBO) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3118190", Offset = "0x3117390", VA = "0x183118190")]
	public static (TKey?, TValue?) MDFOMFNOKCE<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6190", Offset = "0x7D5590")] this in KeyValuePair<TKey?, TValue?> DCMHODHEGEC)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3118100", Offset = "0x3117300", VA = "0x183118100")]
	public static KeyValuePair<TKey?, UValue?> JFOGEECEGEB<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6200", Offset = "0x7D5600")] this KeyValuePair<TKey?, TValue?> DCMHODHEGEC, UValue ACKOJNNBEBO)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MEKBMBCKJGD
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38AE2F0", Offset = "0x38AD4F0", VA = "0x1838AE2F0")]
	[AMLFBPMMCGO("This should be replaced with the `is not` operator in C# 9.")]
	public static bool AFFGEICGOJA<T>(this object DCMHODHEGEC, [OPJMDPNHGGA(true)] out T GAFKIBJKPNO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HIGFOCFOCAG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70D60A0", Offset = "0x70D52A0", VA = "0x1870D60A0")]
	private static byte[] KAJPIFKGFMB(int OFNGIHKLCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x70D6900", Offset = "0x70D5B00", VA = "0x1870D6900")]
	private static byte[] MFEPEFKIKKB(long LDBEJDBPLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x70D6020", Offset = "0x70D5220", VA = "0x1870D6020")]
	private static byte[] FIEGKFBENJI(ulong LDBEJDBPLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x70D61A0", Offset = "0x70D53A0", VA = "0x1870D61A0")]
	public static Guid LAMJHHNPOCD(params Guid[] DHAHCGHMHHD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x70D6390", Offset = "0x70D5590", VA = "0x1870D6390")]
	public static Guid LNIGJBIDADO(in Guid IDDGGMACLNM, int MMFFFGBLCAP, int EJEDLELNMDA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x70D6460", Offset = "0x70D5660", VA = "0x1870D6460")]
	public static Guid LNIGJBIDADO(in Guid IDDGGMACLNM, long MMFFFGBLCAP, int EJEDLELNMDA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x70D6830", Offset = "0x70D5A30", VA = "0x1870D6830")]
	public static Guid LNIGJBIDADO(in Guid IDDGGMACLNM, ulong MMFFFGBLCAP, int EJEDLELNMDA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x70D6320", Offset = "0x70D5520", VA = "0x1870D6320")]
	public static Guid LNIGJBIDADO(in Guid IDDGGMACLNM, in Guid HACNEABIEBK, int EJEDLELNMDA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x70D6530", Offset = "0x70D5730", VA = "0x1870D6530")]
	private static Guid LNIGJBIDADO(in Guid IDDGGMACLNM, byte[] KCNCMOGNLMI, int EJEDLELNMDA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x70D5F40", Offset = "0x70D5140", VA = "0x1870D5F40")]
	private static void CDMEAHBHJMD(byte[] CNDCJIFNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x70D6120", Offset = "0x70D5320", VA = "0x1870D6120")]
	private static void KGOMOFBCNHP(byte[] CNDCJIFNLGE, int NGKKOMJDENH, int KEJINCBACKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NLFNLOEBEBD
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x13A07E0", Offset = "0x139F9E0", VA = "0x1813A07E0")]
	public static uint NLDFJDMFHMF(this uint DCMHODHEGEC, int IGDJHHPIJBK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1005AA0", Offset = "0x1004CA0", VA = "0x181005AA0")]
	public static uint OHGOIOCHFCH(this uint DCMHODHEGEC, int IGDJHHPIJBK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class APNNPFLFIMM
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x70D55E0", Offset = "0x70D47E0", VA = "0x1870D55E0")]
	public static int AJMECBDCGLG(this int DCMHODHEGEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x70D56A0", Offset = "0x70D48A0", VA = "0x1870D56A0")]
	public static int IHJDCOHDPPM(this int DCMHODHEGEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x70D5650", Offset = "0x70D4850", VA = "0x1870D5650")]
	public static int COOGIHCOIPG(this int DCMHODHEGEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x70D56E0", Offset = "0x70D48E0", VA = "0x1870D56E0")]
	public static int PJLNMEHCGFC(this int DCMHODHEGEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x13A07E0", Offset = "0x139F9E0", VA = "0x1813A07E0")]
	public static int NLDFJDMFHMF(this int DCMHODHEGEC, int IGDJHHPIJBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1005AA0", Offset = "0x1004CA0", VA = "0x181005AA0")]
	public static int OHGOIOCHFCH(this int DCMHODHEGEC, int IGDJHHPIJBK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BODIDHCCKIP
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E550", Offset = "0x2D3D750", VA = "0x182D3E550")]
	public static bool BNLDCIGEOFB<T, U>(this T DCMHODHEGEC, in U BHEOHCEHIBM) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E740", Offset = "0x2D3D940", VA = "0x182D3E740")]
	public static bool KBDAIPBFNBL<T>(ref T DCMHODHEGEC, T HPOECFLNEOJ) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ABNFJPCONGC
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float DMEHLLEMJLO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float EFFBLIDHFFF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool POMCJIIFGKJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float NIGNKMJPDNF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x70D5020", Offset = "0x70D4220", VA = "0x1870D5020")]
	public static bool HNCAHOOEIBL(float KCJELMMMDCA, float NMKMEIDKGEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4D88D60", Offset = "0x4D87F60", VA = "0x184D88D60")]
	public static float BCAFGLIHECL(float ACKOJNNBEBO, float PAOMAJAMJDG, float CALOKHBDGFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4D88D80", Offset = "0x4D87F80", VA = "0x184D88D80")]
	public static int BCAFGLIHECL(int ACKOJNNBEBO, int PAOMAJAMJDG, int CALOKHBDGFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4D88D40", Offset = "0x4D87F40", VA = "0x184D88D40")]
	public static float OHNMBCOHKMA(float ACKOJNNBEBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x70D5120", Offset = "0x70D4320", VA = "0x1870D5120")]
	public static float PNMDOIHKGOJ(float KCJELMMMDCA, float NMKMEIDKGEO, float NIKDBMNECCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70D4F50", Offset = "0x70D4150", VA = "0x1870D4F50")]
	public static float CIKHDANEPLK(float KCJELMMMDCA, float NMKMEIDKGEO, float NIKDBMNECCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x70D4F60", Offset = "0x70D4160", VA = "0x1870D4F60")]
	public static float DFFIBMEIMGD(float KCJELMMMDCA, float NMKMEIDKGEO, float ACKOJNNBEBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x70D4F10", Offset = "0x70D4110", VA = "0x1870D4F10")]
	public static float BCHILLDNPEB(float KCJELMMMDCA, float NMKMEIDKGEO, float ACKOJNNBEBO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FGOFJAKKNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x382CAB0", Offset = "0x382BCB0", VA = "0x18382CAB0")]
	public static TValue PDDDDLHDDMF<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> DCMHODHEGEC, TKey PPNIGBBPGOI) where TValue : class where TKey : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CJFGLIGMDDI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NBCMKFJCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBFCJMCBDCC();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class ADFBFEHHNJB
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class HBAOMKNGFDG : IOEPABEOFAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random NEPLHKOLCID;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x70D5DF0", Offset = "0x70D4FF0", VA = "0x1870D5DF0", Slot = "4")]
		public int DGJHKAHKEON(int FKJAFOMOGFH, int AACPBILJFCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x70D5E20", Offset = "0x70D5020", VA = "0x1870D5E20", Slot = "5")]
		public float FKCFOCDMJPA(float FKJAFOMOGFH, float NBFPEKDKDNP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x70D5E90", Offset = "0x70D5090", VA = "0x1870D5E90")]
		private double GIGMOGLJGCJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x70D5ED0", Offset = "0x70D50D0", VA = "0x1870D5ED0")]
		public HBAOMKNGFDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly IOEPABEOFAP IDMBKEDFPHF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x70D52A0", Offset = "0x70D44A0", VA = "0x1870D52A0")]
	public static ulong MGBMAIGNODB()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LLDCOLLPKMH
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool DANJMANEIFM<TArgs, T>(in TArgs AHLCEBMCJMF, T FNPJDMFCFGH);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U LDPKAJHCPNO<TArg, U>(in TArg ANPLPNKHBJM);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U OHKFBIIAKJD<TArg, T, U>(in TArg ANPLPNKHBJM, T KPGLOHJPHFD);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U PBFFGADCJKN<TArg, T, U>(in TArg ANPLPNKHBJM, IEnumerable<T> HMNOPGDGOJJ);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U GIIPLMPENAG<TArg, T, U>(in TArg ANPLPNKHBJM, T KPGLOHJPHFD);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct JONCMBIKJAM<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x36177B0", Offset = "0x36169B0", VA = "0x1836177B0")]
		[CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) PDAHHIKLEGK(T HEJLIDFHPMF)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3617740", Offset = "0x3616940", VA = "0x183617740")]
		[CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) AJOAKALLMHJ(IEnumerable<T> FPLOKNMBMPC)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LFLBOOIBPND<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A070F0", Offset = "0x2A062F0", VA = "0x182A070F0")]
		[DebuggerHidden]
		public LFLBOOIBPND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x354CB60", Offset = "0x354BD60", VA = "0x18354CB60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x354BF00", Offset = "0x354B100", VA = "0x18354BF00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x354BE00", Offset = "0x354B000", VA = "0x18354BE00")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x354C920", Offset = "0x354BB20", VA = "0x18354C920")]
		private void PKFPAMEJFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x354CA50", Offset = "0x354BC50", VA = "0x18354CA50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A06FB0", Offset = "0x2A061B0", VA = "0x182A06FB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A07080", Offset = "0x2A06280", VA = "0x182A07080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JEFANOIEMEA<T> : IEnumerable<(T, NFEJPMDMHAA<T>)>, IEnumerable, IEnumerator<(T, NFEJPMDMHAA<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, NFEJPMDMHAA<T> Next) <>2__current;

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
		private (T, NFEJPMDMHAA<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x34EB430", Offset = "0x34EA630", VA = "0x1834EB430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, NFEJPMDMHAA<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x34EB610", Offset = "0x34EA810", VA = "0x1834EB610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x275EA80", Offset = "0x275DC80", VA = "0x18275EA80")]
		[DebuggerHidden]
		public JEFANOIEMEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x34EB6B0", Offset = "0x34EA8B0", VA = "0x1834EB6B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x34EA4E0", Offset = "0x34E96E0", VA = "0x1834EA4E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x34EA0D0", Offset = "0x34E92D0", VA = "0x1834EA0D0")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x34EB4D0", Offset = "0x34EA6D0", VA = "0x1834EB4D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x34EB380", Offset = "0x34EA580", VA = "0x1834EB380", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, NFEJPMDMHAA<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2F5E3C0", Offset = "0x2F5D5C0", VA = "0x182F5E3C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FMKNPMGBCKC<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6A00", Offset = "0x7D5E00")]
		private Func<JONCMBIKJAM<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6AF0", Offset = "0x7D5EF0")]
		public Func<JONCMBIKJAM<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A070F0", Offset = "0x2A062F0", VA = "0x182A070F0")]
		[DebuggerHidden]
		public FMKNPMGBCKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F2E0", Offset = "0x3A9E4E0", VA = "0x183A9F2E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A9EDC0", Offset = "0x3A9DFC0", VA = "0x183A9EDC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A9ED70", Offset = "0x3A9DF70", VA = "0x183A9ED70")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F190", Offset = "0x3A9E390", VA = "0x183A9F190")]
		private void PKFPAMEJFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F2A0", Offset = "0x3A9E4A0", VA = "0x183A9F2A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F1E0", Offset = "0x3A9E3E0", VA = "0x183A9F1E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2F5EB10", Offset = "0x2F5DD10", VA = "0x182F5EB10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GOLKEPLFOAB<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public GOLKEPLFOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x35CE270", Offset = "0x35CD470", VA = "0x1835CE270")]
		internal bool EMDOOJPDDLH(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C8C0", Offset = "0x3F0BAC0", VA = "0x183F0C8C0")]
		internal bool ICLMOFBOFGG(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IPOLBPDJAKA<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8F8BD0", Offset = "0x8F7DD0", VA = "0x1808F8BD0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x275EA30", Offset = "0x275DC30", VA = "0x18275EA30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x275EA80", Offset = "0x275DC80", VA = "0x18275EA80")]
		[DebuggerHidden]
		public IPOLBPDJAKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x275E6D0", Offset = "0x275D8D0", VA = "0x18275E6D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x275E9F0", Offset = "0x275DBF0", VA = "0x18275E9F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x275E900", Offset = "0x275DB00", VA = "0x18275E900", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x275E9C0", Offset = "0x275DBC0", VA = "0x18275E9C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3345720", Offset = "0x3344920", VA = "0x183345720")]
	public static bool BBCEDBKKFHL<T, TArgs>(this IEnumerable<T> DCMHODHEGEC, in TArgs AHLCEBMCJMF, DANJMANEIFM<TArgs, T> EPCCIGFNMOG) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3347050", Offset = "0x3346250", VA = "0x183347050")]
	public static U ILFJGOMJJAM<U, T>(this IEnumerable<T> DCMHODHEGEC, Func<U> JFCOHACOCNI, Func<T, U> HEJLIDFHPMF, Func<IEnumerable<T>, U> FPLOKNMBMPC) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3345D20", Offset = "0x3344F20", VA = "0x183345D20")]
	public static bool DDMEFLNNJLE<T, TArgs>(this IEnumerable<T> DCMHODHEGEC, in TArgs AHLCEBMCJMF, DANJMANEIFM<TArgs, T> EPCCIGFNMOG) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3346260", Offset = "0x3345460", VA = "0x183346260")]
	public static U DGAPICGCPFD<U, T, TArg>(this IEnumerable<T> DCMHODHEGEC, in TArg ANPLPNKHBJM, LDPKAJHCPNO<TArg, U> JFCOHACOCNI, OHKFBIIAKJD<TArg, T, U> HEJLIDFHPMF, PBFFGADCJKN<TArg, T, U> FPLOKNMBMPC) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x33466B0", Offset = "0x33458B0", VA = "0x1833466B0")]
	public static IEnumerable<U> EPCPOGALLMF<U, T, TArg>(this IEnumerable<T> DCMHODHEGEC, in TArg ANPLPNKHBJM, GIIPLMPENAG<TArg, T, U> MMFBKCHICCN) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x257A700", Offset = "0x2579900", VA = "0x18257A700")]
	public static IEnumerable<T> JNJGHDOLAAN<T>(params IEnumerable<T>[] HCIKIGACIFG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3345B60", Offset = "0x3344D60", VA = "0x183345B60")]
	public static bool DABKDJLOFFL<T>(this IEnumerable<T> PHDPIMPEHFJ, IEnumerable<T> HPOECFLNEOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x257A700", Offset = "0x2579900", VA = "0x18257A700")]
	public static IEnumerable<(TKey?, TValue?)>? NJILHBLIMLH<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6320", Offset = "0x7D5720")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3345000", Offset = "0x3344200", VA = "0x183345000")]
	public static IEnumerable<T> AGLGFLKFKCA<T, TKey>(this IEnumerable<T> FACAGHKGOMI, Func<T, TKey> LICHLKGIPEN) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x27D6A20", Offset = "0x27D5C20", VA = "0x1827D6A20")]
	[IteratorStateMachine(typeof(LFLBOOIBPND<, >))]
	public static IEnumerable<T> ENLKAJPNILJ<T, U>(this IEnumerable<T> DCMHODHEGEC, IEnumerable<U> HPOECFLNEOJ, [Optional][CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")] T NEBBLOKPEOL) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1961310", Offset = "0x1960510", VA = "0x181961310")]
	public static T PLIABOGALHC<T>(this IEnumerable<T> PHDPIMPEHFJ, T DDGOMDBNGFF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3348F30", Offset = "0x3348130", VA = "0x183348F30")]
	public static T PLIABOGALHC<T>(this IEnumerable<T> PHDPIMPEHFJ, T DDGOMDBNGFF, Func<T, bool> EPCCIGFNMOG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3347200", Offset = "0x3346400", VA = "0x183347200")]
	public static T? JGKIJHICBHP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D63E0", Offset = "0x7D57E0")] this IEnumerable<T> DCMHODHEGEC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6440", Offset = "0x7D5840")] Func<T, bool> EPCCIGFNMOG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1961990", Offset = "0x1960B90", VA = "0x181961990")]
	[IteratorStateMachine(typeof(JEFANOIEMEA<>))]
	public static IEnumerable<(T, NFEJPMDMHAA<T>)> KBFPAMBOJDK<T>(this IEnumerable<T> DCMHODHEGEC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3346AF0", Offset = "0x3345CF0", VA = "0x183346AF0")]
	public static bool FIAEIENLCMM<T>(this IEnumerable<T> DCMHODHEGEC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x257A700", Offset = "0x2579900", VA = "0x18257A700")]
	public static IEnumerable<AOBPECIGIAH<T>> FPMEKFLEFKK<T>(this IEnumerable<T> DCMHODHEGEC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3347CE0", Offset = "0x3346EE0", VA = "0x183347CE0")]
	public static bool JNICLPBNKND<T>(this IEnumerable<T> DCMHODHEGEC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3346BE0", Offset = "0x3345DE0", VA = "0x183346BE0")]
	public static IEnumerable<T> HFJNIHOKHNA<T>(this IEnumerable<T> DCMHODHEGEC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x27D6980", Offset = "0x27D5B80", VA = "0x1827D6980")]
	[IteratorStateMachine(typeof(FMKNPMGBCKC<, >))]
	public static IEnumerable<U> BKOEBPCKPBK<U, T>(this IEnumerable<T> DCMHODHEGEC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6580", Offset = "0x7D5980")] Func<JONCMBIKJAM<U>, T, (bool Zero, U One, IEnumerable<U> Many)> EMCACAHPPFB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3348B40", Offset = "0x3347D40", VA = "0x183348B40")]
	public static int PACIKMHJFBN<T>(this IEnumerable<T> DCMHODHEGEC, int ECHGAGIEPKE = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3346EA0", Offset = "0x33460A0", VA = "0x183346EA0")]
	public static bool ILCPONGOJDI<T>(this IEnumerable<T> DCMHODHEGEC, IEnumerable<T> HPOECFLNEOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3346C10", Offset = "0x3345E10", VA = "0x183346C10")]
	public static (IEnumerable<T>, IEnumerable<T>) HGNKBMDLCHJ<T>(this IEnumerable<T> DCMHODHEGEC, Func<T, bool> LLFLGPEKMKJ) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3347F40", Offset = "0x3347140", VA = "0x183347F40")]
	public static string LKPIFHBJENF<T>(this IEnumerable<T> DCMHODHEGEC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x33482C0", Offset = "0x33474C0", VA = "0x1833482C0")]
	public static Dictionary<TKey?, TValue?>? MHLIEPAJCKC<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6670", Offset = "0x7D5A70")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? PHDPIMPEHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x33482C0", Offset = "0x33474C0", VA = "0x1833482C0")]
	public static Dictionary<TKey?, TValue?>? MHLIEPAJCKC<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D66D0", Offset = "0x7D5AD0")] this IEnumerable<(TKey? Key, TValue? Value)>? PHDPIMPEHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x268FC40", Offset = "0x268EE40", VA = "0x18268FC40")]
	public static HashSet<T> CDJAHICAJBN<T>(this IEnumerable<T> DCMHODHEGEC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3346AD0", Offset = "0x3345CD0", VA = "0x183346AD0")]
	public static string FHJGANGHGJG<T>(this IEnumerable<T> DCMHODHEGEC, string BDJHFMNPKBG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x27D6840", Offset = "0x27D5A40", VA = "0x1827D6840")]
	[IteratorStateMachine(typeof(IPOLBPDJAKA<, >))]
	public static IEnumerable<(T, U)> HGOFAFPDKMD<T, U>(this IEnumerable<T> JFHIJPMPOBA, IEnumerable<U> LPNFMADJDAF) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x33488C0", Offset = "0x3347AC0", VA = "0x1833488C0")]
	public static IEnumerable<V> NMDMGIJGFLO<V, T, U>(this IEnumerable<T> DCMHODHEGEC, IEnumerable<U> HPOECFLNEOJ, Func<T, U, V> GINLOBGLKMK, [Optional][CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")] T AIAEBHLFGNI, [Optional][CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")] U IAIHKMCKIFE) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3348950", Offset = "0x3347B50", VA = "0x183348950")]
	public static IEnumerable<(T, U)> NMDMGIJGFLO<T, U>(this IEnumerable<T> DCMHODHEGEC, IEnumerable<U> HPOECFLNEOJ, [Optional][CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")] T AIAEBHLFGNI, [Optional][CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")] U IAIHKMCKIFE) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HPCGEJALPAF
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2876240", Offset = "0x2875440", VA = "0x182876240")]
	public static bool GBNNECEBKHM<T>(this IReadOnlyCollection<T> DCMHODHEGEC, int MMFFFGBLCAP) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class GDDKHBNMKDM : PCKJCOJOAIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch DMIDBIBCBAN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long DKJKJOJGJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x70D5850", Offset = "0x70D4A50", VA = "0x1870D5850", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	private GDDKHBNMKDM(Stopwatch EPHPKLLOIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x70D57F0", Offset = "0x70D49F0", VA = "0x1870D57F0")]
	public static GDDKHBNMKDM BHJMHMHDPDJ(Stopwatch EPHPKLLOIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x70D5870", Offset = "0x70D4A70", VA = "0x1870D5870")]
	public static GDDKHBNMKDM ILFMIAJHHNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HKHOFEOBEAG
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x70D6980", Offset = "0x70D5B80", VA = "0x1870D6980")]
	public static RigidTransform ODDFBKOCEIF(RigidTransform BJPPJILPBEP, RigidTransform AKIAMLKFMIE)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LKFKEINIDIP<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct GHCEGGMNDGA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x41ACD50", Offset = "0x41ABF50", VA = "0x1841ACD50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int FDDHEAPLOGK;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static GKGCJFBJIHM FMBKABJEAPA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long DKJKJOJGJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2A93AA0", Offset = "0x2A92CA0", VA = "0x182A93AA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E90350", Offset = "0x3E8F550", VA = "0x183E90350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3E903B0", Offset = "0x3E8F5B0", VA = "0x183E903B0")]
	public static GHCEGGMNDGA NAJADENCPAG()
	{
		return default(GHCEGGMNDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3E901D0", Offset = "0x3E8F3D0", VA = "0x183E901D0")]
	private static void FMAANAMPIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3E90170", Offset = "0x3E8F370", VA = "0x183E90170")]
	public static void BLKLFBLJHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class EHJNCCIODOO
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x33C1A50", Offset = "0x33C0C50", VA = "0x1833C1A50")]
	public static bool ICHOAIKKGIH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D7040", Offset = "0x7D6440")] this in ReadOnlySpan<T?> DCMHODHEGEC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D70B0", Offset = "0x7D64B0")] in ReadOnlySpan<T?> HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x33C1E10", Offset = "0x33C1010", VA = "0x1833C1E10")]
	public static int PACIKMHJFBN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D7120", Offset = "0x7D6520")] this in ReadOnlySpan<T?> DCMHODHEGEC, int ECHGAGIEPKE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x33C1BD0", Offset = "0x33C0DD0", VA = "0x1833C1BD0")]
	public static string LKPIFHBJENF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D7190", Offset = "0x7D6590")] this in ReadOnlySpan<T> DCMHODHEGEC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x33C1300", Offset = "0x33C0500", VA = "0x1833C1300")]
	public static string FHJGANGHGJG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D7200", Offset = "0x7D6600")] this in ReadOnlySpan<T> DCMHODHEGEC, string BDJHFMNPKBG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IMNCACHGONO
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x10E4FB0", Offset = "0x10E41B0", VA = "0x1810E4FB0")]
	public static bool BEANBPIFODE(this string? NGMCLNPINFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x70D6A50", Offset = "0x70D5C50", VA = "0x1870D6A50")]
	public static string? CNKDJFMCHMC(this string? DCMHODHEGEC, int BCDOOFLOGMD, string FEFBGAOENMC = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x70D6B00", Offset = "0x70D5D00", VA = "0x1870D6B00")]
	public static string FMAKJPLKILC(this string DCMHODHEGEC, int BCDOOFLOGMD, string FEFBGAOENMC = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class NGPFLCCMIBF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static PCKJCOJOAIC KGNEPMKPJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x70D6FF0", Offset = "0x70D61F0", VA = "0x1870D6FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x70D6F60", Offset = "0x70D6160", VA = "0x1870D6F60")]
	public static double AJCFKMODKBO(this PCKJCOJOAIC DCMHODHEGEC, long BPKPENBEOAG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class MAKIFFGLBDG
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int FLMDMEJPNMG<T>(in T JFHIJPMPOBA, in T LPNFMADJDAF);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FOBIKPPDGKH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct GPFLOIFEAIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int PFBJKNIILDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int FEHIJPHCAED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool GHEEBMCPHNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int DJGCODDJBGO;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x435EAF0", Offset = "0x435DCF0", VA = "0x18435EAF0")]
			public GPFLOIFEAIB(int PFBJKNIILDN, int FEHIJPHCAED, bool GHEEBMCPHNF)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] ALOJNBIMNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] JBPNNHLJEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly FLMDMEJPNMG<T> EIJFIIDKBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int OFGDMCIEOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> OECJFGIHNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int MJOACFKGNKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D7310", Offset = "0x7D6710")]
		private readonly FOBIKPPDGKH<T>.GPFLOIFEAIB[] MFALIHBNCEE;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA0170", Offset = "0x3A9F370", VA = "0x183AA0170")]
		public FOBIKPPDGKH(T[] ALOJNBIMNMD, FLMDMEJPNMG<T> EIJFIIDKBIJ, int OFGDMCIEOOH, Func<bool> OECJFGIHNMH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D7370", Offset = "0x7D6770")] T[] GDKHFNMGIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3A9FE00", Offset = "0x3A9F000", VA = "0x183A9FE00")]
		public bool IBHKCKBBEDL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U LNIHFCAFFEL<T, U>(int PIPMIDCFJAF, int MFPGOGPFIEK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D73D0", Offset = "0x7D67D0")] in ReadOnlySpan<T> GCALBDCHIJF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x38A8960", Offset = "0x38A7B60", VA = "0x1838A8960")]
	public static T[] MDHPDKNMLIM<T>(int KOIBEABAMCA, T NEBBLOKPEOL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x38A9040", Offset = "0x38A8240", VA = "0x1838A9040")]
	public static void NIFCPHHHLGB<T>(this T[] AJNNGINLDNI, T NEBBLOKPEOL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B12AE0", Offset = "0x2B11CE0", VA = "0x182B12AE0")]
	public static void HGAAKADEPPJ<T>(this T[] BGBPILICHHA, int PPKKHBJMHLB, int GDMBBNPDFKJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x38A8560", Offset = "0x38A7760", VA = "0x1838A8560")]
	private static void LAEOOOOMNMH<T>(this T[] DCMHODHEGEC, int EIEFGDHAILD, int LLLGIOJNEKH, T[] HPOECFLNEOJ, int EGMBLEBIJNE, int JCFOFDKCNOC, T[] GAFKIBJKPNO, int DBEMKAHEAKP, FLMDMEJPNMG<T> EIJFIIDKBIJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x38A9400", Offset = "0x38A8600", VA = "0x1838A9400")]
	public static void ONOBMLCGLBB<T>(this T[] DCMHODHEGEC, int PFBJKNIILDN, int IGDJHHPIJBK, FLMDMEJPNMG<T> EIJFIIDKBIJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x38A84C0", Offset = "0x38A76C0", VA = "0x1838A84C0")]
	public static FOBIKPPDGKH<T> KMGDMEOAIAG<T>(this T[] DCMHODHEGEC, FLMDMEJPNMG<T> EIJFIIDKBIJ, int OFGDMCIEOOH, Func<bool> OECJFGIHNMH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D72B0", Offset = "0x7D66B0")] T[] GDKHFNMGIBF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x38A9020", Offset = "0x38A8220", VA = "0x1838A9020")]
	public static T[] MPGBILMCMBH<T>(this T[] BGBPILICHHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x38A8280", Offset = "0x38A7480", VA = "0x1838A8280")]
	public static T[] EBFDMLBNKGM<T>(this T[] ODAKENMGFIJ, T LFICHPFNHIK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x38A9860", Offset = "0x38A8A60", VA = "0x1838A9860")]
	public static T[] PFJFMKEBEMJ<T>(this T[] ODAKENMGFIJ, int MMFFFGBLCAP, T LFICHPFNHIK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x38A8410", Offset = "0x38A7610", VA = "0x1838A8410")]
	public static T[] JPILGBJPFGB<T>(this T[] ODAKENMGFIJ, int MMFFFGBLCAP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x38A91D0", Offset = "0x38A83D0", VA = "0x1838A91D0")]
	public static T[] OFJOFFLFDME<T>(this T[] ODAKENMGFIJ, int MMFFFGBLCAP, T LFICHPFNHIK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x38A8AE0", Offset = "0x38A7CE0", VA = "0x1838A8AE0")]
	public static U[] MDPAHFEEDKM<U, T>(this T[] CAGPAHEIADO, int BEEAPDOBGOL, LNIHFCAFFEL<T, U> NJBDAAIOHMJ) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x70D6D80", Offset = "0x70D5F80", VA = "0x1870D6D80")]
	public static byte[] EPNDGBAIHLA(this byte[] DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x70D6BA0", Offset = "0x70D5DA0", VA = "0x1870D6BA0")]
	public static byte[] BPKPPAJMEIF(this byte[] DCMHODHEGEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FDOJOIHGGCA
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3123410", Offset = "0x3122610", VA = "0x183123410")]
	public static void JBNACDPEFAB<K, V>(this IDictionary<K, V> DCMHODHEGEC, in K PPNIGBBPGOI, in V ACKOJNNBEBO, Func<V, V, V> JKCJFIPDKCJ) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3123C40", Offset = "0x3122E40", VA = "0x183123C40")]
	public static void PKDGNMNMMDJ<K, V>(this IDictionary<K, List<V>> DCMHODHEGEC, in K PPNIGBBPGOI, in V ACKOJNNBEBO) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3122B20", Offset = "0x3121D20", VA = "0x183122B20")]
	public static TVal INBNHJFHDEE<TVal, TKey>(this IDictionary<TKey, TVal> FIPHIMEAJGH, in TKey PPNIGBBPGOI, [Optional][CMFCANKAKKJ("`default!` shouldn't be necessary in C# 9")] TVal DDGOMDBNGFF) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x31227A0", Offset = "0x31219A0", VA = "0x1831227A0")]
	public static TVal INBNHJFHDEE<TVal, TKey>(this IDictionary<TKey, TVal> FIPHIMEAJGH, in TKey PPNIGBBPGOI, Func<TVal> IFALNHFEALA) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3122180", Offset = "0x3121380", VA = "0x183122180")]
	public static TValue IEHODMHIBOE<TValue, TKey>(this IDictionary<TKey, TValue> FIPHIMEAJGH, in TKey PPNIGBBPGOI, [Optional][CMFCANKAKKJ("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue DDGOMDBNGFF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3121AE0", Offset = "0x3120CE0", VA = "0x183121AE0")]
	public static V GIHGKGHDNDJ<V, K>(this IDictionary<K, V> DCMHODHEGEC, in K PPNIGBBPGOI) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x31217B0", Offset = "0x31209B0", VA = "0x1831217B0")]
	public static T2[] DHJGLBPNNHF<T2, T1>(this Dictionary<T1, T2>.ValueCollection PMBNOLPNFJA) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3121840", Offset = "0x3120A40", VA = "0x183121840")]
	public static bool GAHDPKFJOAE<TKey, TValue>(this IDictionary<TKey, TValue> DCMHODHEGEC, TKey PPNIGBBPGOI, TValue ACKOJNNBEBO) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class GICHJMOGMMP
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x70D5910", Offset = "0x70D4B10", VA = "0x1870D5910")]
	public static float3 BMOJHNELENK(this in RigidTransform DCMHODHEGEC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x70D5A40", Offset = "0x70D4C40", VA = "0x1870D5A40")]
	public static float3 FAMECPEAJEG(this in RigidTransform DCMHODHEGEC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x24C0350", Offset = "0x24BF550", VA = "0x1824C0350")]
	public static (float3, float3, float3) DOPGDFAHKCB(this in RigidTransform DCMHODHEGEC)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x70D5B70", Offset = "0x70D4D70", VA = "0x1870D5B70")]
	public static RigidTransform FLAPCOPMCPB(this in RigidTransform DCMHODHEGEC)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class HDAEFFGJIGD
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2861890", Offset = "0x2860A90", VA = "0x182861890")]
	public static bool EIKCLBLFBCB<T>(this IReadOnlyList<T> DCMHODHEGEC, int MMFFFGBLCAP, [CMFCANKAKKJ("This should be `T?` in C# 9.")][OPJMDPNHGGA(true)] out T GAFKIBJKPNO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2861920", Offset = "0x2860B20", VA = "0x182861920")]
	public static bool GECMCBKAOLK<T>(this IReadOnlyList<T> DCMHODHEGEC, int MMFFFGBLCAP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D75B0", Offset = "0x7D69B0")] out AOBPECIGIAH<T> GAFKIBJKPNO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2861A90", Offset = "0x2860C90", VA = "0x182861A90")]
	public static T OMCDJEBCBOD<T>(this IReadOnlyList<T> DCMHODHEGEC, int MMFFFGBLCAP, in T KOKBOEDALPM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2861B10", Offset = "0x2860D10", VA = "0x182861B10")]
	[CMFCANKAKKJ("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T PDDDDLHDDMF<T>(this IReadOnlyList<T> DCMHODHEGEC, int MMFFFGBLCAP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x28619E0", Offset = "0x2860BE0", VA = "0x1828619E0")]
	public static T? IDMJIKAKMFN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D7660", Offset = "0x7D6A60")] this IReadOnlyList<T> DCMHODHEGEC, int MMFFFGBLCAP) where T : struct
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
