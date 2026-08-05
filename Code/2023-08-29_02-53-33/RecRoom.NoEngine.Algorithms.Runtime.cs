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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F4A100", Offset = "0x6F49500", VA = "0x186F4A100")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LBNPDDDCPOH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F49F30", Offset = "0x6F49330", VA = "0x186F49F30")]
	public static (float3, float3, float3) NNLGDHPIFJJ(this in quaternion JCOLBAAGCGE)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NAKKLIJPLKF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3410", Offset = "0x1FE2810", VA = "0x181FE3410")]
	public static bool KEEIBJMDIPF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B58B0", Offset = "0x6B4CB0")] this in ReadOnlyMemory<T> JCOLBAAGCGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5920", Offset = "0x6B4D20")] in ReadOnlyMemory<T> LNOOAJJNCAE) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3350", Offset = "0x1FE2750", VA = "0x181FE3350")]
	public static int FAIEFHJKMCO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5990", Offset = "0x6B4D90")] this in ReadOnlyMemory<T?> JCOLBAAGCGE, int CPKBDLNCAOC = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3530", Offset = "0x1FE2930", VA = "0x181FE3530")]
	public static string MIODNCJHDNI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5A00", Offset = "0x6B4E00")] this in ReadOnlyMemory<T> JCOLBAAGCGE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IEBIONGPMMD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x18176F0", Offset = "0x1816AF0", VA = "0x1818176F0")]
	public static void BNPPEBKKNKC<T>(this ICollection<T> JCOLBAAGCGE, IEnumerable<T> PJNDNKMLPNK) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HEFFFBJCCND
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNNPEIFDHLL JBBJLPCKEFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LMBFMHDFCJO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PAELKCHEBCI<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public PAELKCHEBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24D58F0", Offset = "0x24D4CF0", VA = "0x1824D58F0")]
		internal TElement NIHHECBAEAF(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FDMHJCBHNKO<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public FDMHJCBHNKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA2FA10", Offset = "0xA2EE10", VA = "0x180A2FA10")]
		internal int OGPLIEANLEK(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x242AA10", Offset = "0x2429E10", VA = "0x18242AA10")]
	public static int DDJFEIDPBKE<T>(this IReadOnlyList<T> KGHLGBOMEFA, T KKIAKNLLHIO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x242B9C0", Offset = "0x242ADC0", VA = "0x18242B9C0")]
	public static int ELADBEECKCP<T>(this IReadOnlyList<T> KGHLGBOMEFA, T KKIAKNLLHIO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x242A760", Offset = "0x2429B60", VA = "0x18242A760")]
	public static void BNPPEBKKNKC<T>(this HashSet<T> NDJHNKNNCHI, IEnumerable<T> PJNDNKMLPNK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x242FC20", Offset = "0x242F020", VA = "0x18242FC20")]
	public static void KCIGLGCOFAC<T>(this IList<T> OCCNFAKIALD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x242FCA0", Offset = "0x242F0A0", VA = "0x18242FCA0")]
	public static void KCIGLGCOFAC<T>(this IList<T> OCCNFAKIALD, int AMHKFOEOLFA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x242B4E0", Offset = "0x242A8E0", VA = "0x18242B4E0")]
	public static List<T> DIOFPNECNOD<T>(this List<T> GHPBLCEJEKI, Predicate<T> ILJAFENCBMI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x242B280", Offset = "0x242A680", VA = "0x18242B280")]
	public static int DDJFEIDPBKE<T>(this IReadOnlyList<T> OCCNFAKIALD, Predicate<T> ONPNCHGDFJP) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x292B5E0", Offset = "0x292A9E0", VA = "0x18292B5E0")]
	public static bool OHPGGEPEKOD<T>(this IReadOnlyList<T> OCCNFAKIALD, Predicate<T> ONPNCHGDFJP, [PIJLCHPMKPF(true)] out List<int>? NLMDNELOIKN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x242EFD0", Offset = "0x242E3D0", VA = "0x18242EFD0")]
	public static bool KBBBHMHGNAB<T>(this IReadOnlyList<T> OCCNFAKIALD, T ADJFAODNAMI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x242EE90", Offset = "0x242E290", VA = "0x18242EE90")]
	public static bool KBBBHMHGNAB<T>(this IReadOnlyList<T> OCCNFAKIALD, T ADJFAODNAMI, EqualityComparer<T> HFLKGIFCEEE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x242F310", Offset = "0x242E710", VA = "0x18242F310")]
	public static int KCAMMBKEBDG<TElement, TKey>(this IList<TElement> NFMDHFOOIPK, TKey GKOMDNLKMJN, Func<TElement, TKey> ODIOHBCJJEK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5AF0", Offset = "0x6B4EF0")] Func<TKey, TKey, int> HABMBJAKDFB, int NANJAGEOPJI = 0, [Optional] int? ECOAGJBCGAI) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x242F020", Offset = "0x242E420", VA = "0x18242F020")]
	public static int KCAMMBKEBDG<TElement, TKey>(Func<int, TElement> EDCMLJEJLGG, int NALAFGLBEFE, TKey GKOMDNLKMJN, Func<TElement, TKey> ODIOHBCJJEK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5B50", Offset = "0x6B4F50")] Func<TKey, TKey, int> HABMBJAKDFB, int NANJAGEOPJI = 0, [Optional] int? ECOAGJBCGAI) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x242B5D0", Offset = "0x242A9D0", VA = "0x18242B5D0")]
	public static List<T> DPONEPENKEP<T>(this IReadOnlyList<T> OCCNFAKIALD, int ECOAGJBCGAI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x242BCE0", Offset = "0x242B0E0", VA = "0x18242BCE0")]
	public static bool FMAGBPCHEII<T>(this List<T> OCCNFAKIALD, T ADJFAODNAMI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x242E230", Offset = "0x242D630", VA = "0x18242E230")]
	public static void GMJNGMAEPLB<T>(this List<T> OCCNFAKIALD, IEnumerable<T> GHPBLCEJEKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x292BD50", Offset = "0x292B150", VA = "0x18292BD50")]
	public static void PBDAKCGNFND<T>(this List<T> OCCNFAKIALD, IEnumerable<T> GHPBLCEJEKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2429ED0", Offset = "0x24292D0", VA = "0x182429ED0")]
	public static T BHKJGJFOCBO<T>(this List<T> GHPBLCEJEKI, Predicate<T> ILJAFENCBMI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x242E480", Offset = "0x242D880", VA = "0x18242E480")]
	public static T HJLMFHLDLIF<T>(this List<T> GHPBLCEJEKI, int NANJAGEOPJI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x242E3F0", Offset = "0x242D7F0", VA = "0x18242E3F0")]
	public static bool HDCPAABGAHA<T>(this List<T> BPNKPBHOOEI, List<T> ICPPJGLLABN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x292B360", Offset = "0x292A760", VA = "0x18292B360")]
	public static T NBCCMDFNLKG<T>(this IList<T> OCCNFAKIALD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x242BB80", Offset = "0x242AF80", VA = "0x18242BB80")]
	public static bool FLKHPDOHNML<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5BB0", Offset = "0x6B4FB0")] IReadOnlyList<T> OCCNFAKIALD, int NANJAGEOPJI, [OMENNNHHMEF(false)][GIHCKDALKPA("This should be `T?` in C# 9.")] out T OHCLGKAJOMN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x242D670", Offset = "0x242CA70", VA = "0x18242D670")]
	public static bool FMOAJIAHPJL<T>(IReadOnlyList<T> OCCNFAKIALD, ICollection GHPBLCEJEKI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2430510", Offset = "0x242F910", VA = "0x182430510")]
	public static void KHKJDPKEIOA<T>(IReadOnlyList<T> OCCNFAKIALD, ref ICollection GHPBLCEJEKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x292BEF0", Offset = "0x292B2F0", VA = "0x18292BEF0")]
	public static bool PEJKHMKJDNK<T>(this IReadOnlyList<T> OCCNFAKIALD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x292B400", Offset = "0x292A800", VA = "0x18292B400")]
	public static string NCEJHGOPEKK<T>(this IEnumerable<T> OCCNFAKIALD, string BNFJPKGHAHE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x292BB10", Offset = "0x292AF10", VA = "0x18292BB10")]
	public static T OMFBCHAAOHC<T>(this IList<T> JCOLBAAGCGE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x292B130", Offset = "0x292A530", VA = "0x18292B130")]
	public static T MNJBEMPPIOD<T>(this IList<T> JCOLBAAGCGE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x292B0A0", Offset = "0x292A4A0", VA = "0x18292B0A0")]
	public static void MIHEJJKIILO<T>(this IList<T> JCOLBAAGCGE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2430360", Offset = "0x242F760", VA = "0x182430360")]
	public static void KGOIKPCLNAC<T>(this IList<T> JCOLBAAGCGE, in T KKIAKNLLHIO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x292B000", Offset = "0x292A400", VA = "0x18292B000")]
	public static T LHPMNAFPIHD<T>(this IList<T> JCOLBAAGCGE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x242B830", Offset = "0x242AC30", VA = "0x18242B830")]
	public static void EKBAGPCMDCI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5C60", Offset = "0x6B5060")] this List<T> JCOLBAAGCGE) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DLKBHKMMAKO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CPMJBDJLECM<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C05A60", Offset = "0x2C04E60", VA = "0x182C05A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x204C140", Offset = "0x204B540", VA = "0x18204C140")]
		[DebuggerHidden]
		public CPMJBDJLECM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2C05860", Offset = "0x2C04C60", VA = "0x182C05860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2C05A20", Offset = "0x2C04E20", VA = "0x182C05A20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2C05890", Offset = "0x2C04C90", VA = "0x182C05890", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x23045C0", Offset = "0x23039C0", VA = "0x1823045C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2D456C0", Offset = "0x2D44AC0", VA = "0x182D456C0")]
	public static void HBEFGEGLBNH<T>(this T CECLOGMADIP, Action<T> LDDCLKKLJOI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2D45620", Offset = "0x2D44A20", VA = "0x182D45620")]
	public static V GFINOGFMOGG<V, T>(this T CECLOGMADIP, Func<T, V> LDDCLKKLJOI, [Optional][GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")] V OLNFJPNAOBM) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2D453D0", Offset = "0x2D447D0", VA = "0x182D453D0")]
	public static T? AMHHPKMNKKM<T>(this T JCOLBAAGCGE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x196DF80", Offset = "0x196D380", VA = "0x18196DF80")]
	[IteratorStateMachine(typeof(CPMJBDJLECM<>))]
	public static IEnumerable<T> NNNFLGAHIGN<T>(this T JCOLBAAGCGE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2D45540", Offset = "0x2D44940", VA = "0x182D45540")]
	public static T[] DFBABIDOIOG<T>(this T JCOLBAAGCGE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GLOAINKLAPE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long PFBCILEDCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OIFLOBKEHAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GLOAINKLAPE APDFPJPPKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long CDAFNFMLODO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A490", Offset = "0x6F49890", VA = "0x186F4A490")]
	public OIFLOBKEHAD(GLOAINKLAPE AFDFOBICFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A400", Offset = "0x6F49800", VA = "0x186F4A400")]
	public long JGNBKCEFEPH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A370", Offset = "0x6F49770", VA = "0x186F4A370")]
	public double IBJIHHCFMNO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A2E0", Offset = "0x6F496E0", VA = "0x186F4A2E0")]
	public double IBJHIKPPEIC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OPFBDJLPGLC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4738BC0", Offset = "0x4737FC0", VA = "0x184738BC0")]
	public static bool BLNAMEPECJO(this Type JCOLBAAGCGE, Type LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x12CB110", Offset = "0x12CA510", VA = "0x1812CB110")]
	public static bool BLNAMEPECJO<T>(this Type JCOLBAAGCGE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JKFDAABBLHB
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GJEEICJJLDO(int GMHFCEHFBAF, int EIFJALPDBDD);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float GPHJDKBALHC(float IMJFPJJIFNE, float AGCDOJCENOI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NFCNBLDCOEF
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1840", Offset = "0x2BD0C40", VA = "0x182BD1840")]
	public static void IAFKAHLPOAN<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5DF0", Offset = "0x6B51F0")] this in KeyValuePair<TKey, TValue> JCOLBAAGCGE, out TKey KOFPKIJDAMC, out TValue KKIAKNLLHIO) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEF00", Offset = "0x1FEE300", VA = "0x181FEEF00")]
	public static (TKey?, TValue?) HHIKPDAKHBC<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5E60", Offset = "0x6B5260")] this in KeyValuePair<TKey?, TValue?> JCOLBAAGCGE)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEED0", Offset = "0x1FEE2D0", VA = "0x181FEEED0")]
	public static KeyValuePair<TKey?, UValue?> FINLGLMLKOA<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B5ED0", Offset = "0x6B52D0")] this KeyValuePair<TKey?, TValue?> JCOLBAAGCGE, UValue KKIAKNLLHIO)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BIPHJJBKHJE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3304620", Offset = "0x3303A20", VA = "0x183304620")]
	[EMKCLHFPCCP("This should be replaced with the `is not` operator in C# 9.")]
	public static bool AFILMNGKDDL<T>(this object JCOLBAAGCGE, [PIJLCHPMKPF(true)] out T OHCLGKAJOMN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IEMOKAKJIPI
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F494C0", Offset = "0x6F488C0", VA = "0x186F494C0")]
	private static byte[] KLFFMDMGDIB(int EIJHBAGMILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F49B20", Offset = "0x6F48F20", VA = "0x186F49B20")]
	private static byte[] PNACDPCOMBF(long LJLMDICAEEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F49160", Offset = "0x6F48560", VA = "0x186F49160")]
	private static byte[] ELOPNJDFMOF(ulong LJLMDICAEEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F49340", Offset = "0x6F48740", VA = "0x186F49340")]
	public static Guid JBKAMEONPCP(params Guid[] EOEGAEHPGAA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F49680", Offset = "0x6F48A80", VA = "0x186F49680")]
	public static Guid OBPHLOEIGIJ(in Guid MBLFOKHJFPP, int NANJAGEOPJI, int HEGEMCIFGEI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F49A50", Offset = "0x6F48E50", VA = "0x186F49A50")]
	public static Guid OBPHLOEIGIJ(in Guid MBLFOKHJFPP, long NANJAGEOPJI, int HEGEMCIFGEI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F495B0", Offset = "0x6F489B0", VA = "0x186F495B0")]
	public static Guid OBPHLOEIGIJ(in Guid MBLFOKHJFPP, ulong NANJAGEOPJI, int HEGEMCIFGEI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F49540", Offset = "0x6F48940", VA = "0x186F49540")]
	public static Guid OBPHLOEIGIJ(in Guid MBLFOKHJFPP, in Guid ILFKLIMCDMB, int HEGEMCIFGEI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F49750", Offset = "0x6F48B50", VA = "0x186F49750")]
	private static Guid OBPHLOEIGIJ(in Guid MBLFOKHJFPP, byte[] HANGGNJJHGG, int HEGEMCIFGEI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F491E0", Offset = "0x6F485E0", VA = "0x186F491E0")]
	private static void GADNNOJNAKN(byte[] EBABBHGKMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F492C0", Offset = "0x6F486C0", VA = "0x186F492C0")]
	private static void IENDENOMLJD(byte[] EBABBHGKMJL, int OEMIPMEJOAJ, int NJNCIEAMKKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JIEDJFCPOOI
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x677D620", Offset = "0x677CA20", VA = "0x18677D620")]
	public static uint IOCFLBMOOMK(this uint JCOLBAAGCGE, int ECOAGJBCGAI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5208910", Offset = "0x5207D10", VA = "0x185208910")]
	public static uint EEHEAABKFMH(this uint JCOLBAAGCGE, int ECOAGJBCGAI)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HBNLEKHGNEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F490E0", Offset = "0x6F484E0", VA = "0x186F490E0")]
	public static int OGKHOFJGDHB(this int JCOLBAAGCGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F490A0", Offset = "0x6F484A0", VA = "0x186F490A0")]
	public static int OCABBMMMMAI(this int JCOLBAAGCGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F49050", Offset = "0x6F48450", VA = "0x186F49050")]
	public static int NPNOGOOGPHF(this int JCOLBAAGCGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F49150", Offset = "0x6F48550", VA = "0x186F49150")]
	public static int PMGEPLCNKDA(this int JCOLBAAGCGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x677D620", Offset = "0x677CA20", VA = "0x18677D620")]
	public static int IOCFLBMOOMK(this int JCOLBAAGCGE, int ECOAGJBCGAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5208910", Offset = "0x5207D10", VA = "0x185208910")]
	public static int EEHEAABKFMH(this int JCOLBAAGCGE, int ECOAGJBCGAI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KFELHAKEBMF
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x228CCC0", Offset = "0x228C0C0", VA = "0x18228CCC0")]
	public static bool DPNPGIGHAOG<T, U>(this T JCOLBAAGCGE, in U ICNDEPGFBMI) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x228CDD0", Offset = "0x228C1D0", VA = "0x18228CDD0")]
	public static bool JPLHDGCIICB<T>(ref T JCOLBAAGCGE, T LNOOAJJNCAE) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class JCNJLIJGJBF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float GBFBBBLANND;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float DAOKMCPALDG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool GCIEEEMABDJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float PFGIJNIABFA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F49D50", Offset = "0x6F49150", VA = "0x186F49D50")]
	public static bool LFNOEDCMPFC(float EJOFMGLMADH, float CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5021C70", Offset = "0x5021070", VA = "0x185021C70")]
	public static float EIELFDJNLID(float KKIAKNLLHIO, float JMCICGNCKGD, float NMNMMIHHPBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5021C90", Offset = "0x5021090", VA = "0x185021C90")]
	public static int EIELFDJNLID(int KKIAKNLLHIO, int JMCICGNCKGD, int NMNMMIHHPBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5021C50", Offset = "0x5021050", VA = "0x185021C50")]
	public static float DMBBNPACPFD(float KKIAKNLLHIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F49BF0", Offset = "0x6F48FF0", VA = "0x186F49BF0")]
	public static float EPPKAGMFDNH(float EJOFMGLMADH, float CMACFBOCONA, float CECLOGMADIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F49BE0", Offset = "0x6F48FE0", VA = "0x186F49BE0")]
	public static float DMNADHDEKMK(float EJOFMGLMADH, float CMACFBOCONA, float CECLOGMADIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F49C90", Offset = "0x6F49090", VA = "0x186F49C90")]
	public static float IJFFOAAIHMJ(float EJOFMGLMADH, float CMACFBOCONA, float KKIAKNLLHIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F49BA0", Offset = "0x6F48FA0", VA = "0x186F49BA0")]
	public static float DAINGGDAIKE(float EJOFMGLMADH, float CMACFBOCONA, float KKIAKNLLHIO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class APFGFLLBOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2145BC0", Offset = "0x2144FC0", VA = "0x182145BC0")]
	public static TValue GJJNNEPBPNO<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> JCOLBAAGCGE, TKey KOFPKIJDAMC) where TValue : class where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2145E60", Offset = "0x2145260", VA = "0x182145E60")]
	public static bool IACDFLKNDGM<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> JCOLBAAGCGE, IReadOnlyDictionary<TKey, TValue> LNOOAJJNCAE) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CNNPEIFDHLL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EPCPPDDJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAOIGBOKEJI();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GJDIJPGLKLJ
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class GKIPFMGMPAJ : JKFDAABBLHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random DNCDHIBMMJC;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F48DE0", Offset = "0x6F481E0", VA = "0x186F48DE0", Slot = "4")]
		public int GJEEICJJLDO(int IMJFPJJIFNE, int IGNLNADLEFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F48E10", Offset = "0x6F48210", VA = "0x186F48E10", Slot = "5")]
		public float GPHJDKBALHC(float IMJFPJJIFNE, float AGCDOJCENOI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F48E80", Offset = "0x6F48280", VA = "0x186F48E80")]
		private double MKGHKBNKJGJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F48EC0", Offset = "0x6F482C0", VA = "0x186F48EC0")]
		public GKIPFMGMPAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JKFDAABBLHB DPONEPENKEP;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F48AA0", Offset = "0x6F47EA0", VA = "0x186F48AA0")]
	public static ulong MLJDJEHNMGE()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class DNDLLFLDJCC
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool HIFFFOAMOEF<TArgs, T>(in TArgs KLEPOOAJLPJ, T ADJFAODNAMI);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U FAPHEONPPAA<TArg, U>(in TArg FADMIIJIPLK);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U EABCMDIDGKD<TArg, T, U>(in TArg FADMIIJIPLK, T AMCOMEAPPLD);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U NLBPKJFILOI<TArg, T, U>(in TArg FADMIIJIPLK, IEnumerable<T> KHFPKPBIJME);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U EGOCDPDGFHK<TArg, T, U>(in TArg FADMIIJIPLK, T AMCOMEAPPLD);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct PAJCBMCODCL<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x24E7FA0", Offset = "0x24E73A0", VA = "0x1824E7FA0")]
		[GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) KGGCKEOAHEC(T BHJGGAIKJIN)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x24E7F30", Offset = "0x24E7330", VA = "0x1824E7F30")]
		[GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) IAIDLANCCKJ(IEnumerable<T> DCKPEINFGPN)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MNLJIDJCHON<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x204C140", Offset = "0x204B540", VA = "0x18204C140")]
		[DebuggerHidden]
		public MNLJIDJCHON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2758670", Offset = "0x2757A70", VA = "0x182758670", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2757A40", Offset = "0x2756E40", VA = "0x182757A40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2757990", Offset = "0x2756D90", VA = "0x182757990")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2757890", Offset = "0x2756C90", VA = "0x182757890")]
		private void HHNPGKLOEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2758560", Offset = "0x2757960", VA = "0x182758560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2758490", Offset = "0x2757890", VA = "0x182758490", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2361230", Offset = "0x2360630", VA = "0x182361230", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KEDBMKOGMGK<T> : IEnumerable<(T, NNJDIBIFCBF<T>)>, IEnumerable, IEnumerator<(T, NNJDIBIFCBF<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, NNJDIBIFCBF<T> Next) <>2__current;

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
		private (T, NNJDIBIFCBF<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x2203140", Offset = "0x2202540", VA = "0x182203140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, NNJDIBIFCBF<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2203370", Offset = "0x2202770", VA = "0x182203370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2027AB0", Offset = "0x2026EB0", VA = "0x182027AB0")]
		[DebuggerHidden]
		public KEDBMKOGMGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x22033C0", Offset = "0x22027C0", VA = "0x1822033C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2202AC0", Offset = "0x2201EC0", VA = "0x182202AC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2201D10", Offset = "0x2201110", VA = "0x182201D10")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x22031E0", Offset = "0x22025E0", VA = "0x1822031E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2202F00", Offset = "0x2202300", VA = "0x182202F00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, NNJDIBIFCBF<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF00130", Offset = "0xEFF530", VA = "0x180F00130", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CMHBHIKOBPI<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6700", Offset = "0x6B5B00")]
		private Func<PAJCBMCODCL<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B67F0", Offset = "0x6B5BF0")]
		public Func<PAJCBMCODCL<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x204C140", Offset = "0x204B540", VA = "0x18204C140")]
		[DebuggerHidden]
		public CMHBHIKOBPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3296A30", Offset = "0x3295E30", VA = "0x183296A30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3296560", Offset = "0x3295960", VA = "0x183296560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3296510", Offset = "0x3295910", VA = "0x183296510")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x32964C0", Offset = "0x32958C0", VA = "0x1832964C0")]
		private void HHNPGKLOEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x32969F0", Offset = "0x3295DF0", VA = "0x1832969F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3296930", Offset = "0x3295D30", VA = "0x183296930", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x24F3B50", Offset = "0x24F2F50", VA = "0x1824F3B50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EKDHDOMMBDK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public EKDHDOMMBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xEF1DD0", Offset = "0xEF11D0", VA = "0x180EF1DD0")]
		internal bool FGFOJCLBLOJ(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E7D930", Offset = "0x2E7CD30", VA = "0x182E7D930")]
		internal bool GJNBABNENCN(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ALEIFIOLCPI<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xA38A80", Offset = "0xA37E80", VA = "0x180A38A80", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x30F2A50", Offset = "0x30F1E50", VA = "0x1830F2A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2027AB0", Offset = "0x2026EB0", VA = "0x182027AB0")]
		[DebuggerHidden]
		public ALEIFIOLCPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x30F2720", Offset = "0x30F1B20", VA = "0x1830F2720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x30F2A10", Offset = "0x30F1E10", VA = "0x1830F2A10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x30F2950", Offset = "0x30F1D50", VA = "0x1830F2950", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x235E630", Offset = "0x235DA30", VA = "0x18235E630", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2D48430", Offset = "0x2D47830", VA = "0x182D48430")]
	public static bool FDAFFDEAPNN<T, TArgs>(this IEnumerable<T> JCOLBAAGCGE, in TArgs KLEPOOAJLPJ, HIFFFOAMOEF<TArgs, T> ONPNCHGDFJP) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2D46840", Offset = "0x2D45C40", VA = "0x182D46840")]
	public static U DKAHHAMHPFA<U, T>(this IEnumerable<T> JCOLBAAGCGE, Func<U> AFOPDMMLDFF, Func<T, U> BHJGGAIKJIN, Func<IEnumerable<T>, U> DCKPEINFGPN) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2D49140", Offset = "0x2D48540", VA = "0x182D49140")]
	public static bool JDGPFIDBLNI<T, TArgs>(this IEnumerable<T> JCOLBAAGCGE, in TArgs KLEPOOAJLPJ, HIFFFOAMOEF<TArgs, T> ONPNCHGDFJP) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2D48DC0", Offset = "0x2D481C0", VA = "0x182D48DC0")]
	public static U HCHOEJBJAKG<U, T, TArg>(this IEnumerable<T> JCOLBAAGCGE, in TArg FADMIIJIPLK, FAPHEONPPAA<TArg, U> AFOPDMMLDFF, EABCMDIDGKD<TArg, T, U> BHJGGAIKJIN, NLBPKJFILOI<TArg, T, U> DCKPEINFGPN) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2D47AD0", Offset = "0x2D46ED0", VA = "0x182D47AD0")]
	public static IEnumerable<U> FCBFBDFAGBD<U, T, TArg>(this IEnumerable<T> JCOLBAAGCGE, in TArg FADMIIJIPLK, EGOCDPDGFHK<TArg, T, U> DCBDGEGEAOB) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D6BDB0", Offset = "0x1D6B1B0", VA = "0x181D6BDB0")]
	public static IEnumerable<T> OKBHGNLOCJG<T>(params IEnumerable<T>[] IJEFHIAKNHC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2D463D0", Offset = "0x2D457D0", VA = "0x182D463D0")]
	public static bool COIPDOAAEOH<T>(this IEnumerable<T> CANIEFMHGCA, IEnumerable<T> LNOOAJJNCAE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D6BDB0", Offset = "0x1D6B1B0", VA = "0x181D6BDB0")]
	public static IEnumerable<(TKey?, TValue?)>? CLHJNAAHMOM<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6020", Offset = "0x6B5420")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A010", Offset = "0x2D49410", VA = "0x182D4A010")]
	public static IEnumerable<T> NMABIINMFLP<T, TKey>(this IEnumerable<T> OHPPBPBLLMM, Func<T, TKey> GHEFGDJLDEO) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1400E60", Offset = "0x1400260", VA = "0x181400E60")]
	[IteratorStateMachine(typeof(MNLJIDJCHON<, >))]
	public static IEnumerable<T> MDHOJDBFOEK<T, U>(this IEnumerable<T> JCOLBAAGCGE, IEnumerable<U> LNOOAJJNCAE, [Optional][GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")] T DPIFECNJPAM) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1157040", Offset = "0x1156440", VA = "0x181157040")]
	public static T EPIJMPKHHEE<T>(this IEnumerable<T> CANIEFMHGCA, T OLNFJPNAOBM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2D47690", Offset = "0x2D46A90", VA = "0x182D47690")]
	public static T EPIJMPKHHEE<T>(this IEnumerable<T> CANIEFMHGCA, T OLNFJPNAOBM, Func<T, bool> ONPNCHGDFJP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2D473F0", Offset = "0x2D467F0", VA = "0x182D473F0")]
	public static T? EHEJEGFLPDK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B60F0", Offset = "0x6B54F0")] this IEnumerable<T> JCOLBAAGCGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6150", Offset = "0x6B5550")] Func<T, bool> ONPNCHGDFJP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x11578B0", Offset = "0x1156CB0", VA = "0x1811578B0")]
	[IteratorStateMachine(typeof(KEDBMKOGMGK<>))]
	public static IEnumerable<(T, NNJDIBIFCBF<T>)> DDHAAILHGDC<T>(this IEnumerable<T> JCOLBAAGCGE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2D499D0", Offset = "0x2D48DD0", VA = "0x182D499D0")]
	public static bool MAAFACJPPHJ<T>(this IEnumerable<T> JCOLBAAGCGE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D6BDB0", Offset = "0x1D6B1B0", VA = "0x181D6BDB0")]
	public static IEnumerable<ODPPKBIAGLP<T>> BJNMAHEDMNC<T>(this IEnumerable<T> JCOLBAAGCGE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2D49FF0", Offset = "0x2D493F0", VA = "0x182D49FF0")]
	public static bool NGKCNIJNPNN<T>(this IEnumerable<T> JCOLBAAGCGE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A480", Offset = "0x2D49880", VA = "0x182D4A480")]
	public static IEnumerable<T> OOOKLDEDHKK<T>(this IEnumerable<T> JCOLBAAGCGE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1400DC0", Offset = "0x14001C0", VA = "0x181400DC0")]
	[IteratorStateMachine(typeof(CMHBHIKOBPI<, >))]
	public static IEnumerable<U> CEMMOAKPGAI<U, T>(this IEnumerable<T> JCOLBAAGCGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6280", Offset = "0x6B5680")] Func<PAJCBMCODCL<U>, T, (bool Zero, U One, IEnumerable<U> Many)> FKBKJKFAKFN) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2D476E0", Offset = "0x2D46AE0", VA = "0x182D476E0")]
	public static int FAIEFHJKMCO<T>(this IEnumerable<T> JCOLBAAGCGE, int CPKBDLNCAOC = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2D46690", Offset = "0x2D45A90", VA = "0x182D46690")]
	public static bool DFLFPDNPOCG<T>(this IEnumerable<T> JCOLBAAGCGE, IEnumerable<T> LNOOAJJNCAE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A1F0", Offset = "0x2D495F0", VA = "0x182D4A1F0")]
	public static (IEnumerable<T>, IEnumerable<T>) NPNHGHLEEEB<T>(this IEnumerable<T> JCOLBAAGCGE, Func<T, bool> LJILJCBGAEH) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2D49B90", Offset = "0x2D48F90", VA = "0x182D49B90")]
	public static string MIODNCJHDNI<T>(this IEnumerable<T> JCOLBAAGCGE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2D49680", Offset = "0x2D48A80", VA = "0x182D49680")]
	public static Dictionary<TKey?, TValue?>? JEODPKANPCN<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6370", Offset = "0x6B5770")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? CANIEFMHGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2D49680", Offset = "0x2D48A80", VA = "0x182D49680")]
	public static Dictionary<TKey?, TValue?>? JEODPKANPCN<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B63D0", Offset = "0x6B57D0")] this IEnumerable<(TKey? Key, TValue? Value)>? CANIEFMHGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xBC7E80", Offset = "0xBC7280", VA = "0x180BC7E80")]
	public static HashSet<T> GHDGGHPOCOO<T>(this IEnumerable<T> JCOLBAAGCGE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D48870", Offset = "0x2D47C70", VA = "0x182D48870")]
	public static string GFFMMKLGEDK<T>(this IEnumerable<T> JCOLBAAGCGE, string IHLOOOPEBIC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1400D20", Offset = "0x1400120", VA = "0x181400D20")]
	[IteratorStateMachine(typeof(ALEIFIOLCPI<, >))]
	public static IEnumerable<(T, U)> BLDMDAGMODH<T, U>(this IEnumerable<T> LLKHFJFGFIB, IEnumerable<U> LDJLPHFLLEO) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2D48B40", Offset = "0x2D47F40", VA = "0x182D48B40")]
	public static IEnumerable<V> GKDEBAPLMLH<V, T, U>(this IEnumerable<T> JCOLBAAGCGE, IEnumerable<U> LNOOAJJNCAE, Func<T, U, V> HOOHOLJDIHP, [Optional][GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")] T MDGDLMAPBNJ, [Optional][GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")] U LOBKNOANGNB) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D48BD0", Offset = "0x2D47FD0", VA = "0x182D48BD0")]
	public static IEnumerable<(T, U)> GKDEBAPLMLH<T, U>(this IEnumerable<T> JCOLBAAGCGE, IEnumerable<U> LNOOAJJNCAE, [Optional][GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")] T MDGDLMAPBNJ, [Optional][GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")] U LOBKNOANGNB) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class LJAJPFOKGAC
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2429A60", Offset = "0x2428E60", VA = "0x182429A60")]
	public static bool IDNCEGGGNNL<T>(this IReadOnlyCollection<T> JCOLBAAGCGE, int NANJAGEOPJI) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class GLIPCFDMKJP : GLOAINKLAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch APDFPJPPKFJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long PFBCILEDCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F48FD0", Offset = "0x6F483D0", VA = "0x186F48FD0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FE490", VA = "0x1807FF090")]
	private GLIPCFDMKJP(Stopwatch AFDFOBICFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F48FF0", Offset = "0x6F483F0", VA = "0x186F48FF0")]
	public static GLIPCFDMKJP LJAIHFOPJOK(Stopwatch AFDFOBICFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F48F30", Offset = "0x6F48330", VA = "0x186F48F30")]
	public static GLIPCFDMKJP GEEBJDDIEBM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MNMPHOEEPBF
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A030", Offset = "0x6F49430", VA = "0x186F4A030")]
	public static RigidTransform HIBHAOHBCIB(RigidTransform ONPJJAIFPEM, RigidTransform HKCFDEHHABB)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class PHKHPEFEDOE<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct BDFHFOLCFFD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x24C58F0", Offset = "0x24C4CF0", VA = "0x1824C58F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int ONEKCIGCAEI;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static OIFLOBKEHAD BILGMLMINAO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long PFBCILEDCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F530F0", Offset = "0x1F524F0", VA = "0x181F530F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x26ACDB0", Offset = "0x26AC1B0", VA = "0x1826ACDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x26ACBB0", Offset = "0x26ABFB0", VA = "0x1826ACBB0")]
	public static BDFHFOLCFFD ECMLEMIAPCK()
	{
		return default(BDFHFOLCFFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x26ACE10", Offset = "0x26AC210", VA = "0x1826ACE10")]
	private static void NICBEGEEDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x26ACD50", Offset = "0x26AC150", VA = "0x1826ACD50")]
	public static void FJKIFKDAPPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DJMOIAKNAOP
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D44E90", Offset = "0x2D44290", VA = "0x182D44E90")]
	public static bool KEEIBJMDIPF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6D00", Offset = "0x6B6100")] this in ReadOnlySpan<T?> JCOLBAAGCGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6D70", Offset = "0x6B6170")] in ReadOnlySpan<T?> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D44940", Offset = "0x2D43D40", VA = "0x182D44940")]
	public static int FAIEFHJKMCO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6DE0", Offset = "0x6B61E0")] this in ReadOnlySpan<T?> JCOLBAAGCGE, int CPKBDLNCAOC = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D45010", Offset = "0x2D44410", VA = "0x182D45010")]
	public static string MIODNCJHDNI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6E50", Offset = "0x6B6250")] this in ReadOnlySpan<T> JCOLBAAGCGE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D44A60", Offset = "0x2D43E60", VA = "0x182D44A60")]
	public static string GFFMMKLGEDK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6EC0", Offset = "0x6B62C0")] this in ReadOnlySpan<T> JCOLBAAGCGE, string IHLOOOPEBIC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OCNBKBAHNBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55CE090", Offset = "0x55CD490", VA = "0x1855CE090")]
	public static bool PEJKHMKJDNK(this string? ABFHPKCOHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A230", Offset = "0x6F49630", VA = "0x186F4A230")]
	public static string? PEEHKMFNGGJ(this string? JCOLBAAGCGE, int ALAIALIEIPL, string ICMJDFHFBOJ = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A190", Offset = "0x6F49590", VA = "0x186F4A190")]
	public static string GGFHEHJLBDO(this string JCOLBAAGCGE, int ALAIALIEIPL, string ICMJDFHFBOJ = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AMJJGENMHHA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static GLOAINKLAPE AFMCGIPEBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F482E0", Offset = "0x6F476E0", VA = "0x186F482E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F48250", Offset = "0x6F47650", VA = "0x186F48250")]
	public static double IBJIHHCFMNO(this GLOAINKLAPE JCOLBAAGCGE, long GLHGLIIKPNP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class CMKKGGLPNEN
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int BCIMOAMCBHB<T>(in T LLKHFJFGFIB, in T LDJLPHFLLEO);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class PONHFCIONDC<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct DNDIGFLIANC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int MIICGJCNLLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int FGALENKFDAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool NDFPDHGPKAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int HOACNHFIKJO;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x2507AE0", Offset = "0x2506EE0", VA = "0x182507AE0")]
			public DNDIGFLIANC(int MIICGJCNLLL, int FGALENKFDAB, bool NDFPDHGPKAC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] BGFHFNHKIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] BDGEMPAFNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly BCIMOAMCBHB<T> HABMBJAKDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int BGCNMFODMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> OLMKGJICHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int LFCJPDJDCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7010", Offset = "0x6B6410")]
		private readonly PONHFCIONDC<T>.DNDIGFLIANC[] JPCMGMNGHKN;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x255CB00", Offset = "0x255BF00", VA = "0x18255CB00")]
		public PONHFCIONDC(T[] BGFHFNHKIFA, BCIMOAMCBHB<T> HABMBJAKDFB, int BGCNMFODMKF, Func<bool> OLMKGJICHNL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7070", Offset = "0x6B6470")] T[] LMJKMCCCOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x255C790", Offset = "0x255BB90", VA = "0x18255C790")]
		public bool FNDKIPCHBHD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U IKEAHJAEHCF<T, U>(int MIDIAJAGELL, int IFFDEAHPLAD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B70D0", Offset = "0x6B64D0")] in ReadOnlySpan<T> BCOMCHLDLGB);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1CECFA0", Offset = "0x1CEC3A0", VA = "0x181CECFA0")]
	public static T[] FMAJMHFMFPP<T>(int JECAINLJFKC, T DPIFECNJPAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CED7B0", Offset = "0x1CECBB0", VA = "0x181CED7B0")]
	public static void LJBBAEAFCOH<T>(this T[] GAGKMPHNJGL, T DPIFECNJPAM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC4E0", Offset = "0x1CEB8E0", VA = "0x181CEC4E0")]
	public static void AGAMIPDKGGN<T>(this T[] KGHLGBOMEFA, int GNPGECNAJNK, int DLLKDLAAHLJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1CECB80", Offset = "0x1CEBF80", VA = "0x181CECB80")]
	private static void DCHBIHAEODC<T>(this T[] JCOLBAAGCGE, int BCMEKFIFCAO, int GPGIGNBHAJB, T[] LNOOAJJNCAE, int KCPPADHBBKA, int CFFDIADEGFJ, T[] OHCLGKAJOMN, int IDALCLHBAJH, BCIMOAMCBHB<T> HABMBJAKDFB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1CED350", Offset = "0x1CEC750", VA = "0x181CED350")]
	public static void KEEKKAFNIAM<T>(this T[] JCOLBAAGCGE, int MIICGJCNLLL, int ECOAGJBCGAI, BCIMOAMCBHB<T> HABMBJAKDFB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1CED200", Offset = "0x1CEC600", VA = "0x181CED200")]
	public static PONHFCIONDC<T> HNNAEIMKJJA<T>(this T[] JCOLBAAGCGE, BCIMOAMCBHB<T> HABMBJAKDFB, int BGCNMFODMKF, Func<bool> OLMKGJICHNL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6FB0", Offset = "0x6B63B0")] T[] LMJKMCCCOPE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1CECF80", Offset = "0x1CEC380", VA = "0x181CECF80")]
	public static T[] FLGMKABKIFN<T>(this T[] KGHLGBOMEFA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1CED120", Offset = "0x1CEC520", VA = "0x181CED120")]
	public static T[] HHFMJNFCOGF<T>(this T[] EOKGDNJJNPE, T OFFEPANAGAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC590", Offset = "0x1CEB990", VA = "0x181CEC590")]
	public static T[] APNMAOMIJIK<T>(this T[] EOKGDNJJNPE, int NANJAGEOPJI, T OFFEPANAGAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1CED2A0", Offset = "0x1CEC6A0", VA = "0x181CED2A0")]
	public static T[] JBDKHJCEDPG<T>(this T[] EOKGDNJJNPE, int NANJAGEOPJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1CED940", Offset = "0x1CECD40", VA = "0x181CED940")]
	public static T[] MKIAKDJMGOA<T>(this T[] EOKGDNJJNPE, int NANJAGEOPJI, T OFFEPANAGAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1CEBEF0", Offset = "0x1CEB2F0", VA = "0x181CEBEF0")]
	public static U[] ABOJPDPAGAE<U, T>(this T[] CJPIHDACEJM, int HDCNIKFNDKB, IKEAHJAEHCF<T, U> CDIGDFNIAPD) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6F48420", Offset = "0x6F47820", VA = "0x186F48420")]
	public static byte[] KICPCAGCFOP(this byte[] JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6F48600", Offset = "0x6F47A00", VA = "0x186F48600")]
	public static byte[] KMCOOJAJNGC(this byte[] JCOLBAAGCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LOOIICDDDIO
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x29308C0", Offset = "0x292FCC0", VA = "0x1829308C0")]
	public static void PCIADHMBANG<K, V>(this IDictionary<K, V> JCOLBAAGCGE, in K KOFPKIJDAMC, in V KKIAKNLLHIO, Func<V, V, V> ONDHMBBLPAJ) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x292E760", Offset = "0x292DB60", VA = "0x18292E760")]
	public static void ENHNILHIJKA<K, V>(this IDictionary<K, List<V>> JCOLBAAGCGE, in K KOFPKIJDAMC, in V KKIAKNLLHIO) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x292FFD0", Offset = "0x292F3D0", VA = "0x18292FFD0")]
	public static TVal NLGINGBIEEK<TVal, TKey>(this IDictionary<TKey, TVal> CEDFPOKBHBN, in TKey KOFPKIJDAMC, [Optional][GIHCKDALKPA("`default!` shouldn't be necessary in C# 9")] TVal OLNFJPNAOBM) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x292FB70", Offset = "0x292EF70", VA = "0x18292FB70")]
	public static TVal NLGINGBIEEK<TVal, TKey>(this IDictionary<TKey, TVal> CEDFPOKBHBN, in TKey KOFPKIJDAMC, Func<TVal> CKEKDKHJHLH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x292FAA0", Offset = "0x292EEA0", VA = "0x18292FAA0")]
	public static TValue MBLNHLDPNHC<TValue, TKey>(this IDictionary<TKey, TValue> CEDFPOKBHBN, in TKey KOFPKIJDAMC, [Optional][GIHCKDALKPA("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue OLNFJPNAOBM)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x292EEB0", Offset = "0x292E2B0", VA = "0x18292EEB0")]
	public static V FGBPHOOBOKO<V, K>(this IDictionary<K, V> JCOLBAAGCGE, in K KOFPKIJDAMC) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x292E6D0", Offset = "0x292DAD0", VA = "0x18292E6D0")]
	public static T2[] CDNJFLGEAIB<T2, T1>(this Dictionary<T1, T2>.ValueCollection MNPODODFLLO) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x292E310", Offset = "0x292D710", VA = "0x18292E310")]
	public static bool CCKFLLFIEGA<TKey, TValue>(this IDictionary<TKey, TValue> JCOLBAAGCGE, TKey KOFPKIJDAMC, TValue KKIAKNLLHIO) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EJMDAHNFJMF
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F487E0", Offset = "0x6F47BE0", VA = "0x186F487E0")]
	public static float3 DOJCGCEBINJ(this in RigidTransform JCOLBAAGCGE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F48910", Offset = "0x6F47D10", VA = "0x186F48910")]
	public static float3 JPCNADHMKLL(this in RigidTransform JCOLBAAGCGE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1842170", Offset = "0x1841570", VA = "0x181842170")]
	public static (float3, float3, float3) KIGNDBDJNNO(this in RigidTransform JCOLBAAGCGE)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6F48A40", Offset = "0x6F47E40", VA = "0x186F48A40")]
	public static RigidTransform KOEBAPBIGGO(this in RigidTransform JCOLBAAGCGE)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JOKGEJDEOKN
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x227B300", Offset = "0x227A700", VA = "0x18227B300")]
	public static bool HPMOKKNEDOE<T>(this IReadOnlyList<T> JCOLBAAGCGE, int NANJAGEOPJI, [GIHCKDALKPA("This should be `T?` in C# 9.")][PIJLCHPMKPF(true)] out T OHCLGKAJOMN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x227B390", Offset = "0x227A790", VA = "0x18227B390")]
	public static bool MELAJJPNKNL<T>(this IReadOnlyList<T> JCOLBAAGCGE, int NANJAGEOPJI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B72B0", Offset = "0x6B66B0")] out ODPPKBIAGLP<T> OHCLGKAJOMN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x227B1F0", Offset = "0x227A5F0", VA = "0x18227B1F0")]
	public static T HBEFFFDDMIN<T>(this IReadOnlyList<T> JCOLBAAGCGE, int NANJAGEOPJI, in T DOIIFHNPMBA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1812C90", Offset = "0x1812090", VA = "0x181812C90")]
	[GIHCKDALKPA("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T GJJNNEPBPNO<T>(this IReadOnlyList<T> JCOLBAAGCGE, int NANJAGEOPJI) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x227B450", Offset = "0x227A850", VA = "0x18227B450")]
	public static T? OLMKDNHPAPK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7360", Offset = "0x6B6760")] this IReadOnlyList<T> JCOLBAAGCGE, int NANJAGEOPJI) where T : struct
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
