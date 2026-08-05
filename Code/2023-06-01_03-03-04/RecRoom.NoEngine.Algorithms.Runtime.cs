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
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FB6870", Offset = "0x6FB5470", VA = "0x186FB6870")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
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
		[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HOILNFAKEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x291DB50", Offset = "0x291C750", VA = "0x18291DB50")]
	public static T PNBJHLBKMLC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7842B0", Offset = "0x7836B0")] this in ReadOnlyMemory<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x291D7B0", Offset = "0x291C3B0", VA = "0x18291D7B0")]
	public static bool HBCNIMJOHIE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784320", Offset = "0x783720")] this in ReadOnlyMemory<T> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784390", Offset = "0x783790")] in ReadOnlyMemory<T> MDHJAFNLPON) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x291D970", Offset = "0x291C570", VA = "0x18291D970")]
	public static int LHEDPPNOEIM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784400", Offset = "0x783800")] this in ReadOnlyMemory<T?> GPOCLJBKMHA, int COIKHAAMKGK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x291D8D0", Offset = "0x291C4D0", VA = "0x18291D8D0")]
	public static string LFGBFEHHMOI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784470", Offset = "0x783870")] this in ReadOnlyMemory<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DKOJIHDECMA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x36D9E70", Offset = "0x36D8A70", VA = "0x1836D9E70")]
	public static void MIEPPGEFOLJ<T>(this ICollection<T> GPOCLJBKMHA, IEnumerable<T> OMCHMPJJNDE) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GINBLAHFFIH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKLNELNKDNK CIAALDMCOFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DCJCGPDDHGB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KOKACOAODJC<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public KOKACOAODJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4034120", Offset = "0x4032D20", VA = "0x184034120")]
		internal TElement OMEEPKDPLLH(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KKAINNNEDBA<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public KKAINNNEDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA7D9F0", Offset = "0xA7C5F0", VA = "0x180A7D9F0")]
		internal int DILFJLLIIEG(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B737E0", Offset = "0x2B723E0", VA = "0x182B737E0")]
	public static int EKGGAPJDMPI<T>(this IReadOnlyList<T> EABDNHJFDCB, T ECNGHFJBIJL) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2B77B60", Offset = "0x2B76760", VA = "0x182B77B60")]
	public static int LLLBPINPPHO<T>(this IReadOnlyList<T> EABDNHJFDCB, T ECNGHFJBIJL) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B78110", Offset = "0x2B76D10", VA = "0x182B78110")]
	public static void MIEPPGEFOLJ<T>(this HashSet<T> JAEDJOIGJCA, IEnumerable<T> OMCHMPJJNDE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B72E10", Offset = "0x2B71A10", VA = "0x182B72E10")]
	public static void CPBOKOOIDND<T>(this IList<T> IFADMANLNLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B72AE0", Offset = "0x2B716E0", VA = "0x182B72AE0")]
	public static void CPBOKOOIDND<T>(this IList<T> IFADMANLNLG, int AKJEJNFFNAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B736F0", Offset = "0x2B722F0", VA = "0x182B736F0")]
	public static List<T> DGPHIHHLIGK<T>(this List<T> MJPJIGOGOAP, Predicate<T> LDNIBEBMKBJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B74070", Offset = "0x2B72C70", VA = "0x182B74070")]
	public static int EKGGAPJDMPI<T>(this IReadOnlyList<T> IFADMANLNLG, Predicate<T> GKMOGNDGOID) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2B76700", Offset = "0x2B75300", VA = "0x182B76700")]
	public static bool IHKNDOHHJNG<T>(this IReadOnlyList<T> IFADMANLNLG, Predicate<T> GKMOGNDGOID, [NEFDIDCKCBL(true)] out List<int>? LPCDBCDPGDB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B79490", Offset = "0x2B78090", VA = "0x182B79490")]
	public static bool ODOLPHCGINH<T>(this IReadOnlyList<T> IFADMANLNLG, T FHJBBMIILLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B794E0", Offset = "0x2B780E0", VA = "0x182B794E0")]
	public static bool ODOLPHCGINH<T>(this IReadOnlyList<T> IFADMANLNLG, T FHJBBMIILLG, EqualityComparer<T> MJKDLIIFPMD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B75BB0", VA = "0x182B76FB0")]
	public static int KKMGALLACPF<TElement, TKey>(this IList<TElement> LMPIHKKJCOP, TKey NKPLBELFHAM, Func<TElement, TKey> IBGBJCJCCIJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7845A0", Offset = "0x7839A0")] Func<TKey, TKey, int> IBMKHDGPJMJ, int NHHNPPKPBIA = 0, [Optional] int? FGHOJPFDCIA) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B76CB0", Offset = "0x2B758B0", VA = "0x182B76CB0")]
	public static int KKMGALLACPF<TElement, TKey>(Func<int, TElement> LBPCFCDCDPH, int GCOLLKEBKMP, TKey NKPLBELFHAM, Func<TElement, TKey> IBGBJCJCCIJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784600", Offset = "0x783A00")] Func<TKey, TKey, int> IBMKHDGPJMJ, int NHHNPPKPBIA = 0, [Optional] int? FGHOJPFDCIA) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B79620", Offset = "0x2B78220", VA = "0x182B79620")]
	public static List<T> OMNBIOGNEGL<T>(this IReadOnlyList<T> IFADMANLNLG, int FGHOJPFDCIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B743B0", Offset = "0x2B72FB0", VA = "0x182B743B0")]
	public static bool GMBFAKMOAHN<T>(this List<T> IFADMANLNLG, T FHJBBMIILLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B779A0", Offset = "0x2B765A0", VA = "0x182B779A0")]
	public static void LFHJGNABIOA<T>(this List<T> IFADMANLNLG, IEnumerable<T> MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B73240", Offset = "0x2B71E40", VA = "0x182B73240")]
	public static void CPPHPNNFPKL<T>(this List<T> IFADMANLNLG, IEnumerable<T> MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B766A0", Offset = "0x2B752A0", VA = "0x182B766A0")]
	public static T IABJPCMKPIF<T>(this List<T> MJPJIGOGOAP, Predicate<T> LDNIBEBMKBJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B742D0", Offset = "0x2B72ED0", VA = "0x182B742D0")]
	public static T GEIGIJFEAKF<T>(this List<T> MJPJIGOGOAP, int NHHNPPKPBIA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B79AC0", Offset = "0x2B786C0", VA = "0x182B79AC0")]
	public static bool PMLALBOKOCH<T>(this List<T> LBOCLDIDPAI, List<T> AMILGMMNNLF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B729B0", Offset = "0x2B715B0", VA = "0x182B729B0")]
	public static T ANINGBDNMFP<T>(this IList<T> IFADMANLNLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B778E0", Offset = "0x2B764E0", VA = "0x182B778E0")]
	public static bool LFEEDCEMDFG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784660", Offset = "0x783A60")] IReadOnlyList<T> IFADMANLNLG, int NHHNPPKPBIA, [PFABLHCCGAA("This should be `T?` in C# 9.")][KDNNMIKGJNK(false)] out T IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B75A40", Offset = "0x2B74640", VA = "0x182B75A40")]
	public static bool HAAIJOMPHEI<T>(IReadOnlyList<T> IFADMANLNLG, ICollection MJPJIGOGOAP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B76B80", Offset = "0x2B75780", VA = "0x182B76B80")]
	public static void JMIDLDFNKLF<T>(IReadOnlyList<T> IFADMANLNLG, ref ICollection MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B780B0", Offset = "0x2B76CB0", VA = "0x182B780B0")]
	public static bool MGPLEOACKMI<T>(this IReadOnlyList<T> IFADMANLNLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B77D20", Offset = "0x2B76920", VA = "0x182B77D20")]
	public static string LOCKPNJEEIM<T>(this IEnumerable<T> IFADMANLNLG, string OHDEOODOLIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B73640", Offset = "0x2B72240", VA = "0x182B73640")]
	public static T DEENIEHBOEK<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B79880", Offset = "0x2B78480", VA = "0x182B79880")]
	public static T OPOHOEAKJCN<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B72A50", Offset = "0x2B71650", VA = "0x182B72A50")]
	public static void BPIBEAGMILL<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B77F00", Offset = "0x2B76B00", VA = "0x182B77F00")]
	public static void MCFKNPGGJPE<T>(this IList<T> GPOCLJBKMHA, in T ECNGHFJBIJL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B76600", Offset = "0x2B75200", VA = "0x182B76600")]
	public static T HMIEFNEFPKE<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OJBCLCCPNBM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LEBNCJDONJK<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2602580", Offset = "0x2601180", VA = "0x182602580", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1FC23F0", Offset = "0x1FC0FF0", VA = "0x181FC23F0")]
		[DebuggerHidden]
		public LEBNCJDONJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2602300", Offset = "0x2600F00", VA = "0x182602300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x41996A0", Offset = "0x41982A0", VA = "0x1841996A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2602430", Offset = "0x2601030", VA = "0x182602430", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x26024D0", Offset = "0x26010D0", VA = "0x1826024D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B370", Offset = "0x1F69F70", VA = "0x181F6B370")]
	public static void KGFEHDKIPGN<T>(this T NFOHJNABMAP, Action<T> CPKEIIHODAD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B3B0", Offset = "0x1F69FB0", VA = "0x181F6B3B0")]
	public static V PIGEFIDNMMF<V, T>(this T NFOHJNABMAP, Func<T, V> CPKEIIHODAD, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] V IGBKLJLDCLC) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B160", Offset = "0x1F69D60", VA = "0x181F6B160")]
	public static T? AJGLMFFHNGC<T>(this T GPOCLJBKMHA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x14590E0", Offset = "0x1457CE0", VA = "0x1814590E0")]
	[IteratorStateMachine(typeof(LEBNCJDONJK<>))]
	public static IEnumerable<T> CLHOANNABOC<T>(this T GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B290", Offset = "0x1F69E90", VA = "0x181F6B290")]
	public static T[] GAFDDHBLLPP<T>(this T GPOCLJBKMHA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OEFMBCPLDCP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct BAEONBJNHCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OEFMBCPLDCP FEOGNMNIBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long JIJHAANDOPO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB49D0", Offset = "0x6FB35D0", VA = "0x186FB49D0")]
	public BAEONBJNHCH(OEFMBCPLDCP NGBOPHHNHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4940", Offset = "0x6FB3540", VA = "0x186FB4940")]
	public long NGPOCKMDBHI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4820", Offset = "0x6FB3420", VA = "0x186FB4820")]
	public double AHFHIJOPNHD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FB48B0", Offset = "0x6FB34B0", VA = "0x186FB48B0")]
	public double IAHCLIABHCK()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MCMLJFAHLNH
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xBDFB80", Offset = "0xBDE780", VA = "0x180BDFB80")]
	public static bool BKFMPOMIDNM(this Type GPOCLJBKMHA, Type MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2678880", Offset = "0x2677480", VA = "0x182678880")]
	public static bool BKFMPOMIDNM<T>(this Type GPOCLJBKMHA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PELNJLOCJJB
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FGBCPLCCPFP(int NIEMFBGOMOD, int ILGKECLAAID);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float LMGIJHDAFIG(float EJGADLIIMFB, float PKDPPAIKIFG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CFAKOPBAOPO
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E560", Offset = "0x2C6D160", VA = "0x182C6E560")]
	public static void PLOLBHIBFDI<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7848C0", Offset = "0x783CC0")] this in KeyValuePair<TKey, TValue> GPOCLJBKMHA, out TKey BDFCACLHAFA, out TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E290", Offset = "0x2C6CE90", VA = "0x182C6E290")]
	public static (TKey?, TValue?) IIPGDALAIHB<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784930", Offset = "0x783D30")] this in KeyValuePair<TKey?, TValue?> GPOCLJBKMHA)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E4D0", Offset = "0x2C6D0D0", VA = "0x182C6E4D0")]
	public static KeyValuePair<TKey?, UValue?> JOFGMBKBHDB<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7849A0", Offset = "0x783DA0")] this KeyValuePair<TKey?, TValue?> GPOCLJBKMHA, UValue ECNGHFJBIJL)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PKPGNIBCIDB
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1F77ED0", Offset = "0x1F76AD0", VA = "0x181F77ED0")]
	[KPFEFEMPEAJ("This should be replaced with the `is not` operator in C# 9.")]
	public static bool PHBEFFAIJCB<T>(this object GPOCLJBKMHA, [NEFDIDCKCBL(true)] out T IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HMGBKLJCAKC
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB57F0", Offset = "0x6FB43F0", VA = "0x186FB57F0")]
	private static byte[] JDINLNICCDP(int CPOCCBGJOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5E40", Offset = "0x6FB4A40", VA = "0x186FB5E40")]
	private static byte[] NJPPPEMKOCL(long AAACKIAOAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5770", Offset = "0x6FB4370", VA = "0x186FB5770")]
	private static byte[] IJDMHELFDJK(ulong AAACKIAOAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5490", Offset = "0x6FB4090", VA = "0x186FB5490")]
	public static Guid AIJMOCDIFNB(params Guid[] KFCBFPPKJFD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5D00", Offset = "0x6FB4900", VA = "0x186FB5D00")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, int NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5870", Offset = "0x6FB4470", VA = "0x186FB5870")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, long NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5940", Offset = "0x6FB4540", VA = "0x186FB5940")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, ulong NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5DD0", Offset = "0x6FB49D0", VA = "0x186FB5DD0")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, in Guid MENMDNKLKHO, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5A10", Offset = "0x6FB4610", VA = "0x186FB5A10")]
	private static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, byte[] LDABDAEDGOP, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5690", Offset = "0x6FB4290", VA = "0x186FB5690")]
	private static void EBMICMPPCPB(byte[] PCFHAIHNKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5610", Offset = "0x6FB4210", VA = "0x186FB5610")]
	private static void DEMIBBHKODD(byte[] PCFHAIHNKAK, int FDMHBFLJJHC, int DNGDHCADJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MKJPMCEMIBC
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1028D80", Offset = "0x1027980", VA = "0x181028D80")]
	public static uint NFPIDIALDPL(this uint GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xDA6860", Offset = "0xDA5460", VA = "0x180DA6860")]
	public static uint FEDECAAPMCL(this uint GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KJEMLMHCKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6FB63A0", Offset = "0x6FB4FA0", VA = "0x186FB63A0")]
	public static int AMEMBHHOAHO(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6470", Offset = "0x6FB5070", VA = "0x186FB6470")]
	public static int NIAMKLBCFJF(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6410", Offset = "0x6FB5010", VA = "0x186FB6410")]
	public static int EFDFNMGCKLM(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6460", Offset = "0x6FB5060", VA = "0x186FB6460")]
	public static int FOHKLKDIEFL(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1028D80", Offset = "0x1027980", VA = "0x181028D80")]
	public static int NFPIDIALDPL(this int GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xDA6860", Offset = "0xDA5460", VA = "0x180DA6860")]
	public static int FEDECAAPMCL(this int GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NKDCDIIFKGM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B46240", Offset = "0x2B44E40", VA = "0x182B46240")]
	public static bool AOIMMBEHODN<T, U>(this T GPOCLJBKMHA, in U HHNPCHNMLMA) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B46440", Offset = "0x2B45040", VA = "0x182B46440")]
	public static bool FCIMIMCEDEF<T>(ref T GPOCLJBKMHA, T MDHJAFNLPON) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ENMMOPHJIKC
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float DALDNIINMAG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float EPKMCCBCODI;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool KJDECCMCHKF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float OEDIJOIENIM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5270", Offset = "0x6FB3E70", VA = "0x186FB5270")]
	public static bool CGACCPBLGHL(float NBLDAOBEAEA, float PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4A22EF0", Offset = "0x4A21AF0", VA = "0x184A22EF0")]
	public static float KCFCDPNCADC(float ECNGHFJBIJL, float FAFCDNENBCM, float LDBGNHOKNMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4A22F10", Offset = "0x4A21B10", VA = "0x184A22F10")]
	public static int KCFCDPNCADC(int ECNGHFJBIJL, int FAFCDNENBCM, int LDBGNHOKNMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4A22ED0", Offset = "0x4A21AD0", VA = "0x184A22ED0")]
	public static float HLKJFFNLECF(float ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5100", Offset = "0x6FB3D00", VA = "0x186FB5100")]
	public static float AIGDJPHNLNK(float NBLDAOBEAEA, float PAJLLFKCBBD, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5260", Offset = "0x6FB3E60", VA = "0x186FB5260")]
	public static float BGCPOCIBABB(float NBLDAOBEAEA, float PAJLLFKCBBD, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FB51A0", Offset = "0x6FB3DA0", VA = "0x186FB51A0")]
	public static float AKOHMAOJFLN(float NBLDAOBEAEA, float PAJLLFKCBBD, float ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5370", Offset = "0x6FB3F70", VA = "0x186FB5370")]
	public static float MIPOADEAFCG(float NBLDAOBEAEA, float PAJLLFKCBBD, float ECNGHFJBIJL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MCBDAPHCNFM
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2678450", Offset = "0x2677050", VA = "0x182678450")]
	public static TValue LFLDODNIOJL<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> GPOCLJBKMHA, TKey BDFCACLHAFA) where TValue : class where TKey : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BKLNELNKDNK : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BCIDLILPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKEBEGBOMMH();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CKFKJBJCGJE
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private sealed class CBAPNLFHMEL : PELNJLOCJJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random DCGLMBOAPBA;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4A80", Offset = "0x6FB3680", VA = "0x186FB4A80", Slot = "4")]
		public int FGBCPLCCPFP(int EJGADLIIMFB, int DBLIHCGFONC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4AB0", Offset = "0x6FB36B0", VA = "0x186FB4AB0", Slot = "5")]
		public float LMGIJHDAFIG(float EJGADLIIMFB, float PKDPPAIKIFG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4A40", Offset = "0x6FB3640", VA = "0x186FB4A40")]
		private double EBCNBHODGGC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4B20", Offset = "0x6FB3720", VA = "0x186FB4B20")]
		public CBAPNLFHMEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly PELNJLOCJJB OMNBIOGNEGL;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4B90", Offset = "0x6FB3790", VA = "0x186FB4B90")]
	public static ulong JPIOIHOGNLM()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DHLJMOIKMPI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate bool OCDNLPMOLBD<TArgs, T>(in TArgs PFFFGKKOEPM, T FHJBBMIILLG);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate U MFPMLMAJEBK<TArg, U>(in TArg AIMHDAMIMIL);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U PMGOLHHAFEE<TArg, T, U>(in TArg AIMHDAMIMIL, T JNADKFFEIOO);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U JJMOIBOGHCE<TArg, T, U>(in TArg AIMHDAMIMIL, IEnumerable<T> CHCFPJJJGHE);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U JAILCACHDFJ<TArg, T, U>(in TArg AIMHDAMIMIL, T JNADKFFEIOO);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct HLKBHHMBBLH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2E77A30", Offset = "0x2E76630", VA = "0x182E77A30")]
		[PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) IGGPMGLINFM(T HFJJKCHIIHE)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2E779C0", Offset = "0x2E765C0", VA = "0x182E779C0")]
		[PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CPAOPJIMLBK(IEnumerable<T> MALDFIPILGH)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class DLJHOFGNLMC<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1FC23F0", Offset = "0x1FC0FF0", VA = "0x181FC23F0")]
		[DebuggerHidden]
		public DLJHOFGNLMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A48FB0", Offset = "0x2A47BB0", VA = "0x182A48FB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A482B0", Offset = "0x2A46EB0", VA = "0x182A482B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A48260", Offset = "0x2A46E60", VA = "0x182A48260")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A48BF0", Offset = "0x2A477F0", VA = "0x182A48BF0")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A48EE0", Offset = "0x2A47AE0", VA = "0x182A48EE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A48CF0", Offset = "0x2A478F0", VA = "0x182A48CF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x26DF740", Offset = "0x26DE340", VA = "0x1826DF740", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AOKKHDKCCHN<T> : IEnumerable<(T, NBIGGEBJMFN<T>)>, IEnumerable, IEnumerator<(T, NBIGGEBJMFN<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, NBIGGEBJMFN<T> Next) <>2__current;

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
		private (T, NBIGGEBJMFN<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x322B610", Offset = "0x322A210", VA = "0x18322B610", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, NBIGGEBJMFN<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x322B7E0", Offset = "0x322A3E0", VA = "0x18322B7E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x322B8F0", Offset = "0x322A4F0", VA = "0x18322B8F0")]
		[DebuggerHidden]
		public AOKKHDKCCHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x322B890", Offset = "0x322A490", VA = "0x18322B890", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x322A6B0", Offset = "0x32292B0", VA = "0x18322A6B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x322A1B0", Offset = "0x3228DB0", VA = "0x18322A1B0")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x322B670", Offset = "0x322A270", VA = "0x18322B670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x322B480", Offset = "0x322A080", VA = "0x18322B480", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, NBIGGEBJMFN<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2901200", Offset = "0x28FFE00", VA = "0x182901200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AKCDJLDKIJJ<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785190", Offset = "0x784590")]
		private Func<HLKBHHMBBLH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785280", Offset = "0x784680")]
		public Func<HLKBHHMBBLH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1FC23F0", Offset = "0x1FC0FF0", VA = "0x181FC23F0")]
		[DebuggerHidden]
		public AKCDJLDKIJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BDD0", Offset = "0x3F5A9D0", VA = "0x183F5BDD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B8C0", Offset = "0x3F5A4C0", VA = "0x183F5B8C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B870", Offset = "0x3F5A470", VA = "0x183F5B870")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BC80", Offset = "0x3F5A880", VA = "0x183F5BC80")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BD90", Offset = "0x3F5A990", VA = "0x183F5BD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BCD0", Offset = "0x3F5A8D0", VA = "0x183F5BCD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2983E90", Offset = "0x2982A90", VA = "0x182983E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HLECECHMAME<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public HLECECHMAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28FF720", Offset = "0x28FE320", VA = "0x1828FF720")]
		internal bool MNNJBCNOGAI(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2E778B0", Offset = "0x2E764B0", VA = "0x182E778B0")]
		internal bool HLKMIIFKOLK(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IAJANMKIDNL<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x843900", Offset = "0x842500", VA = "0x180843900", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x474C7E0", Offset = "0x474B3E0", VA = "0x18474C7E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x322B8F0", Offset = "0x322A4F0", VA = "0x18322B8F0")]
		[DebuggerHidden]
		public IAJANMKIDNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x474C4C0", Offset = "0x474B0C0", VA = "0x18474C4C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x474C7A0", Offset = "0x474B3A0", VA = "0x18474C7A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x474C6E0", Offset = "0x474B2E0", VA = "0x18474C6E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1C76AA0", Offset = "0x1C756A0", VA = "0x181C76AA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B480", Offset = "0x2B8A080", VA = "0x182B8B480")]
	public static bool OOEHNELKHPL<T, TArgs>(this IEnumerable<T> GPOCLJBKMHA, in TArgs PFFFGKKOEPM, OCDNLPMOLBD<TArgs, T> GKMOGNDGOID) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B87DA0", Offset = "0x2B869A0", VA = "0x182B87DA0")]
	public static U CNLHDKLHDDK<U, T>(this IEnumerable<T> GPOCLJBKMHA, Func<U> AEPABDGGILI, Func<T, U> HFJJKCHIIHE, Func<IEnumerable<T>, U> MALDFIPILGH) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2B87920", Offset = "0x2B86520", VA = "0x182B87920")]
	public static bool CENKBDLFCPA<T, TArgs>(this IEnumerable<T> GPOCLJBKMHA, in TArgs PFFFGKKOEPM, OCDNLPMOLBD<TArgs, T> GKMOGNDGOID) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2B88570", Offset = "0x2B87170", VA = "0x182B88570")]
	public static U FAJNMFLPOPC<U, T, TArg>(this IEnumerable<T> GPOCLJBKMHA, in TArg AIMHDAMIMIL, MFPMLMAJEBK<TArg, U> AEPABDGGILI, PMGOLHHAFEE<TArg, T, U> HFJJKCHIIHE, JJMOIBOGHCE<TArg, T, U> MALDFIPILGH) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2B891B0", Offset = "0x2B87DB0", VA = "0x182B891B0")]
	public static IEnumerable<U> KECMLOKFADN<U, T, TArg>(this IEnumerable<T> GPOCLJBKMHA, in TArg AIMHDAMIMIL, JAILCACHDFJ<TArg, T, U> PEBLDEGHPBH) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2679560", Offset = "0x2678160", VA = "0x182679560")]
	public static IEnumerable<T> FOLJHAIOCPK<T>(params IEnumerable<T>[] DDDPJMBCFKJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2B88D60", Offset = "0x2B87960", VA = "0x182B88D60")]
	public static bool JFHAKHHOCCL<T>(this IEnumerable<T> PDHOFJLLEID, IEnumerable<T> MDHJAFNLPON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2679560", Offset = "0x2678160", VA = "0x182679560")]
	public static IEnumerable<(TKey?, TValue?)>? KHFPNJGADJA<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784AC0", Offset = "0x783EC0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2B87580", Offset = "0x2B86180", VA = "0x182B87580")]
	public static IEnumerable<T> BGKDFNDGCLH<T, TKey>(this IEnumerable<T> IHKODGEFCEF, Func<T, TKey> CCCCOHGNCHJ) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x22E0ED0", Offset = "0x22DFAD0", VA = "0x1822E0ED0")]
	[IteratorStateMachine(typeof(DLJHOFGNLMC<, >))]
	public static IEnumerable<T> IKFFCPEKMGP<T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T JJIHMENIGAO) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1458D90", Offset = "0x1457990", VA = "0x181458D90")]
	public static T HAAEMDMDMLB<T>(this IEnumerable<T> PDHOFJLLEID, T IGBKLJLDCLC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2B888F0", Offset = "0x2B874F0", VA = "0x182B888F0")]
	public static T HAAEMDMDMLB<T>(this IEnumerable<T> PDHOFJLLEID, T IGBKLJLDCLC, Func<T, bool> GKMOGNDGOID) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8AA30", Offset = "0x2B89630", VA = "0x182B8AA30")]
	public static T? NOCFCLOLMEI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784B80", Offset = "0x783F80")] this IEnumerable<T> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784BE0", Offset = "0x783FE0")] Func<T, bool> GKMOGNDGOID) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1459630", Offset = "0x1458230", VA = "0x181459630")]
	[IteratorStateMachine(typeof(AOKKHDKCCHN<>))]
	public static IEnumerable<(T, NBIGGEBJMFN<T>)> CLCNONKHKAO<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B88480", Offset = "0x2B87080", VA = "0x182B88480")]
	public static bool DODELLPEOPI<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2679560", Offset = "0x2678160", VA = "0x182679560")]
	public static IEnumerable<FDBENDDJJIN<T>> OJOINFOLDPA<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B8ACF0", Offset = "0x2B898F0", VA = "0x182B8ACF0")]
	public static bool OKHCPHKNICN<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A1B0", Offset = "0x2B88DB0", VA = "0x182B8A1B0")]
	public static IEnumerable<T> NAODOGPDHDP<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F15580", Offset = "0x1F14180", VA = "0x181F15580")]
	[IteratorStateMachine(typeof(AKCDJLDKIJJ<, >))]
	public static IEnumerable<U> BOMHJKBKGAC<U, T>(this IEnumerable<T> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784D10", Offset = "0x784110")] Func<HLKBHHMBBLH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> MHPHLGPGCON) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2B89DC0", Offset = "0x2B889C0", VA = "0x182B89DC0")]
	public static int LHEDPPNOEIM<T>(this IEnumerable<T> GPOCLJBKMHA, int COIKHAAMKGK = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2B895F0", Offset = "0x2B881F0", VA = "0x182B895F0")]
	public static bool KIMKKEOMLBA<T>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<T> MDHJAFNLPON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B88F20", Offset = "0x2B87B20", VA = "0x182B88F20")]
	public static (IEnumerable<T>, IEnumerable<T>) JPLINNABNHO<T>(this IEnumerable<T> GPOCLJBKMHA, Func<T, bool> LIMHPPGEFGK) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B89960", Offset = "0x2B88560", VA = "0x182B89960")]
	public static string LFGBFEHHMOI<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2B88940", Offset = "0x2B87540", VA = "0x182B88940")]
	public static Dictionary<TKey?, TValue?>? HNCFBENFMLP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784E00", Offset = "0x784200")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? PDHOFJLLEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2B88940", Offset = "0x2B87540", VA = "0x182B88940")]
	public static Dictionary<TKey?, TValue?>? HNCFBENFMLP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784E60", Offset = "0x784260")] this IEnumerable<(TKey? Key, TValue? Value)>? PDHOFJLLEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1E70190", Offset = "0x1E6ED90", VA = "0x181E70190")]
	public static HashSet<T> PGJFADIIINC<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8ACD0", Offset = "0x2B898D0", VA = "0x182B8ACD0")]
	public static string OJBCKPNPIHC<T>(this IEnumerable<T> GPOCLJBKMHA, string BHBIFNNNNHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x22E0D90", Offset = "0x22DF990", VA = "0x1822E0D90")]
	[IteratorStateMachine(typeof(IAJANMKIDNL<, >))]
	public static IEnumerable<(T, U)> IIONLKHJGPM<T, U>(this IEnumerable<T> EOEOFNCKKHJ, IEnumerable<U> AOEAFBFCPPC) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B88200", Offset = "0x2B86E00", VA = "0x182B88200")]
	public static IEnumerable<V> CPEOJENKING<V, T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, Func<T, U, V> DBHAKFLALEC, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T BGMHMGIDCIG, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] U JBBCNCIPJBI) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B88290", Offset = "0x2B86E90", VA = "0x182B88290")]
	public static IEnumerable<(T, U)> CPEOJENKING<T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T BGMHMGIDCIG, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] U JBBCNCIPJBI) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EJJAFKLGLOF
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B480", Offset = "0x2A5A080", VA = "0x182A5B480")]
	public static bool DNPJDDECIKO<T>(this IReadOnlyCollection<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class IEGILFHOGFD : OEFMBCPLDCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch FEOGNMNIBEI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5EC0", Offset = "0x6FB4AC0", VA = "0x186FB5EC0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	private IEGILFHOGFD(Stopwatch NGBOPHHNHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5F80", Offset = "0x6FB4B80", VA = "0x186FB5F80")]
	public static IEGILFHOGFD PFNPLHBPFPH(Stopwatch NGBOPHHNHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5EE0", Offset = "0x6FB4AE0", VA = "0x186FB5EE0")]
	public static IEGILFHOGFD NAPOIKCMMCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NMOKNMMPCNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6600", Offset = "0x6FB5200", VA = "0x186FB6600")]
	public static RigidTransform OGPCDCIDJEH(RigidTransform GPFAFMOEHGM, RigidTransform BAEIKDDHHKE)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BONELACKBFD<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct NJACONBOGPL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8F10", Offset = "0x1FC7B10", VA = "0x181FC8F10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int MKAKMHPOAHA;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static BAEONBJNHCH MBGIKMDPBOG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x29F9D50", Offset = "0x29F8950", VA = "0x1829F9D50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x34B2DF0", Offset = "0x34B19F0", VA = "0x1834B2DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x34B2E50", Offset = "0x34B1A50", VA = "0x1834B2E50")]
	public static NJACONBOGPL IJNDHEIFCIK()
	{
		return default(NJACONBOGPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x34B2C60", Offset = "0x34B1860", VA = "0x1834B2C60")]
	private static void CNDJDCFHOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x34B2FF0", Offset = "0x34B1BF0", VA = "0x1834B2FF0")]
	public static void NHGHFKAFNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class AHEMNGIOABF
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x174FBC0", Offset = "0x174E7C0", VA = "0x18174FBC0")]
	public static bool HBCNIMJOHIE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785790", Offset = "0x784B90")] this in ReadOnlySpan<T?> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785800", Offset = "0x784C00")] in ReadOnlySpan<T?> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x174FEC0", Offset = "0x174EAC0", VA = "0x18174FEC0")]
	public static int LHEDPPNOEIM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785870", Offset = "0x784C70")] this in ReadOnlySpan<T?> GPOCLJBKMHA, int COIKHAAMKGK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x174FD40", Offset = "0x174E940", VA = "0x18174FD40")]
	public static string LFGBFEHHMOI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7858E0", Offset = "0x784CE0")] this in ReadOnlySpan<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x174FFE0", Offset = "0x174EBE0", VA = "0x18174FFE0")]
	public static string OJBCKPNPIHC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785950", Offset = "0x784D50")] this in ReadOnlySpan<T> GPOCLJBKMHA, string BHBIFNNNNHA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LCLBLFIAKPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xE5F480", Offset = "0xE5E080", VA = "0x180E5F480")]
	public static bool MGPLEOACKMI(this string? IJAKCFMLLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FB64B0", Offset = "0x6FB50B0", VA = "0x186FB64B0")]
	public static string? CHPMLDBLKLP(this string? GPOCLJBKMHA, int NHAAHCAPBBL, string CEFDGIKHHKI = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6560", Offset = "0x6FB5160", VA = "0x186FB6560")]
	public static string JPEBMGHMGOH(this string GPOCLJBKMHA, int NHAAHCAPBBL, string CEFDGIKHHKI = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CNENNIFMDBC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static OEFMBCPLDCP MPNEELDFHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4F60", Offset = "0x6FB3B60", VA = "0x186FB4F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4ED0", Offset = "0x6FB3AD0", VA = "0x186FB4ED0")]
	public static double AHFHIJOPNHD(this OEFMBCPLDCP GPOCLJBKMHA, long OBFPOLGFFMO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class KALIDOAAEHE
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate int CNNAGKIBEOP<T>(in T EOEOFNCKKHJ, in T AOEAFBFCPPC);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class ADGJBCMIFMA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private struct NLEBPMGHHPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int GOGKDEGLBIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int JBOMFIHOBMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool IHLNAFGBDCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int DMBJKFHPBGF;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x38B97A0", Offset = "0x38B83A0", VA = "0x1838B97A0")]
			public NLEBPMGHHPF(int GOGKDEGLBIL, int JBOMFIHOBMC, bool IHLNAFGBDCM)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] DGLONHDJAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] DKALJHNFONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly CNNAGKIBEOP<T> IBMKHDGPJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int MMKFNEOHNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> FHOJOOFKKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int KOIIOPHDGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785A60", Offset = "0x784E60")]
		private readonly ADGJBCMIFMA<T>.NLEBPMGHHPF[] NBGDFKLHLOB;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x377C810", Offset = "0x377B410", VA = "0x18377C810")]
		public ADGJBCMIFMA(T[] DGLONHDJAEF, CNNAGKIBEOP<T> IBMKHDGPJMJ, int MMKFNEOHNED, Func<bool> FHOJOOFKKKB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785AC0", Offset = "0x784EC0")] T[] JMDIKJDFBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x377C160", Offset = "0x377AD60", VA = "0x18377C160")]
		public bool HCNIFKMNBGL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate U KOMAFILEBGG<T, U>(int MCFAKADLDHC, int MIEKHCNMCPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785B20", Offset = "0x784F20")] in ReadOnlySpan<T> NHOIFPKFJIN);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x174B500", Offset = "0x174A100", VA = "0x18174B500")]
	public static ReadOnlyMemory<T> JHBNLOBJEED<T>(this T[] GPOCLJBKMHA) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2E59A60", Offset = "0x2E58660", VA = "0x182E59A60")]
	public static T[] PCJPEOHDEHM<T>(int GEFPLPIBMGI, T JJIHMENIGAO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2E59CC0", Offset = "0x2E588C0", VA = "0x182E59CC0")]
	public static void PMIKGMCNBOI<T>(this T[] MENABBKMAHK, T JJIHMENIGAO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x24C64E0", Offset = "0x24C50E0", VA = "0x1824C64E0")]
	public static void ILJLNOOHGAI<T>(this T[] EABDNHJFDCB, int OCIFJAIBHIA, int BJBICJAGAJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2E582A0", Offset = "0x2E56EA0", VA = "0x182E582A0")]
	private static void CCOMOJAIDOD<T>(this T[] GPOCLJBKMHA, int INMPMPFNNIP, int CNKIFFMKMOE, T[] MDHJAFNLPON, int DGEJJBIIHKD, int GAPMHHJNHOF, T[] IIMBBHEIGGD, int BICKKGMIBKK, CNNAGKIBEOP<T> IBMKHDGPJMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2E58C70", Offset = "0x2E57870", VA = "0x182E58C70")]
	public static void GCAEEGBJGOH<T>(this T[] GPOCLJBKMHA, int GOGKDEGLBIL, int FGHOJPFDCIA, CNNAGKIBEOP<T> IBMKHDGPJMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2E58690", Offset = "0x2E57290", VA = "0x182E58690")]
	public static ADGJBCMIFMA<T> CMFFPNICJOE<T>(this T[] GPOCLJBKMHA, CNNAGKIBEOP<T> IBMKHDGPJMJ, int MMKFNEOHNED, Func<bool> FHOJOOFKKKB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785A00", Offset = "0x784E00")] T[] JMDIKJDFBMI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2E590C0", Offset = "0x2E57CC0", VA = "0x182E590C0")]
	public static T[] HOIHKHFBLLG<T>(this T[] EABDNHJFDCB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2E59BE0", Offset = "0x2E587E0", VA = "0x182E59BE0")]
	public static T[] PGPGNDPIKGK<T>(this T[] FOBNDAKIFJN, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2E59470", Offset = "0x2E58070", VA = "0x182E59470")]
	public static T[] OJKELHMDINN<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E59190", Offset = "0x2E57D90", VA = "0x182E59190")]
	public static T[] INEMDPJECJE<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2E59240", Offset = "0x2E57E40", VA = "0x182E59240")]
	public static T[] JGKCBIJAJLL<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E58730", Offset = "0x2E57330", VA = "0x182E58730")]
	public static U[] EHFIOAPPLMI<U, T>(this T[] IHGFGANOELJ, int CCLMMIKOIAM, KOMAFILEBGG<T, U> EGDCLPPDABB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6FB61C0", Offset = "0x6FB4DC0", VA = "0x186FB61C0")]
	public static byte[] DEAELMLHGOG(this byte[] GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5FE0", Offset = "0x6FB4BE0", VA = "0x186FB5FE0")]
	public static byte[] CPIJCFAMKJG(this byte[] GPOCLJBKMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BAGEHDPMPKN
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4F00", Offset = "0x2FF3B00", VA = "0x182FF4F00")]
	public static void JPIGKIGLPKD<K, V>(this IDictionary<K, V> GPOCLJBKMHA, in K BDFCACLHAFA, in V ECNGHFJBIJL, Func<V, V, V> BFBCIOLIGJH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3190", Offset = "0x2FF1D90", VA = "0x182FF3190")]
	public static void DAOKCNHAFLM<K, V>(this IDictionary<K, List<V>> GPOCLJBKMHA, in K BDFCACLHAFA, in V ECNGHFJBIJL) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4B80", Offset = "0x2FF3780", VA = "0x182FF4B80")]
	public static TVal JLOACIOBEMO<TVal, TKey>(this IDictionary<TKey, TVal> BAOLHJKGDLB, in TKey BDFCACLHAFA, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] TVal IGBKLJLDCLC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4260", Offset = "0x2FF2E60", VA = "0x182FF4260")]
	public static TVal JLOACIOBEMO<TVal, TKey>(this IDictionary<TKey, TVal> BAOLHJKGDLB, in TKey BDFCACLHAFA, Func<TVal> AHBJKPMJFOH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2FF4000", Offset = "0x2FF2C00", VA = "0x182FF4000")]
	public static TValue HHJBLJEFAKG<TValue, TKey>(this IDictionary<TKey, TValue> BAOLHJKGDLB, in TKey BDFCACLHAFA, [Optional][PFABLHCCGAA("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue IGBKLJLDCLC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2BC0", Offset = "0x2FF17C0", VA = "0x182FF2BC0")]
	public static V AJNGMBMFLEB<V, K>(this IDictionary<K, V> GPOCLJBKMHA, in K BDFCACLHAFA) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3910", Offset = "0x2FF2510", VA = "0x182FF3910")]
	public static T2[] GMJCFHAOGEP<T2, T1>(this Dictionary<T1, T2>.ValueCollection JOONHIOHMIH) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2FF40E0", Offset = "0x2FF2CE0", VA = "0x182FF40E0")]
	public static bool JCOHIHLGEAI<TKey, TValue>(this IDictionary<TKey, TValue> GPOCLJBKMHA, TKey BDFCACLHAFA, TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DBAKBCEBDCL
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB50A0", Offset = "0x6FB3CA0", VA = "0x186FB50A0")]
	public static RigidTransform GNMIMHHEAJM(this in RigidTransform GPOCLJBKMHA)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EFJMLAEGCCN
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2A57320", Offset = "0x2A55F20", VA = "0x182A57320")]
	public static bool KFBGNHHGLGM<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, [PFABLHCCGAA("This should be `T?` in C# 9.")][NEFDIDCKCBL(true)] out T IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2A571D0", Offset = "0x2A55DD0", VA = "0x182A571D0")]
	public static bool JNAIJCLBAFB<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785D00", Offset = "0x785100")] out FDBENDDJJIN<T> IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2A570A0", Offset = "0x2A55CA0", VA = "0x182A570A0")]
	public static T ACGLFPEEOAF<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, in T EOHICGFEFIM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x174B830", Offset = "0x174A430", VA = "0x18174B830")]
	[PFABLHCCGAA("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T LFLDODNIOJL<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2A57120", Offset = "0x2A55D20", VA = "0x182A57120")]
	public static T? FABCCMJJBKI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785DB0", Offset = "0x7851B0")] this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : struct
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
