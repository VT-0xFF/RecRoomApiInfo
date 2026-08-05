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
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FDE9E0", Offset = "0x6FDD7E0", VA = "0x186FDE9E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
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
		[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OJPDNCLFNGI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEE30", Offset = "0x6FDDC30", VA = "0x186FDEE30")]
	public static (float3, float3, float3) JEKGNFAJGDJ(this in quaternion FEEMIHFJMDK)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JPJLCGMDKAO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B1E0", Offset = "0x2E09FE0", VA = "0x182E0B1E0")]
	public static bool CPIMMPDFLKL<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2980", Offset = "0x7A1D80")] this in ReadOnlyMemory<T> FEEMIHFJMDK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A29F0", Offset = "0x7A1DF0")] in ReadOnlyMemory<T> FGBEDAPNDEP) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B300", Offset = "0x2E0A100", VA = "0x182E0B300")]
	public static int HNMKGLOJHKD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2A60", Offset = "0x7A1E60")] this in ReadOnlyMemory<T?> FEEMIHFJMDK, int IFGCGBIKJJL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B3C0", Offset = "0x2E0A1C0", VA = "0x182E0B3C0")]
	public static string PPEMDMGOPKD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2AD0", Offset = "0x7A1ED0")] this in ReadOnlyMemory<T> FEEMIHFJMDK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FPJEOHNDDLI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x233DA20", Offset = "0x233C820", VA = "0x18233DA20")]
	public static void JLFFFFDBMNL<T>(this ICollection<T> FEEMIHFJMDK, IEnumerable<T> LLMAEEFJLEM) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FJPHEANBIEF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLPPJIKFFAL MJEKHMIIGFF();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GCCIONELPBC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BDJNBILMCOM<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public BDJNBILMCOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4770", Offset = "0x3DE3570", VA = "0x183DE4770")]
		internal TElement IBIHLFEDCLM(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EDOPDJCFDNN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public EDOPDJCFDNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA74790", Offset = "0xA73590", VA = "0x180A74790")]
		internal int KMFLOPGMDPE(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3465680", Offset = "0x3464480", VA = "0x183465680")]
	public static int GJMFCBKGNNK<T>(this IReadOnlyList<T> PKPHLPFOPGM, T KKLNCEHOHED) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3464C10", Offset = "0x3463A10", VA = "0x183464C10")]
	public static int EJECPCLJLAG<T>(this IReadOnlyList<T> PKPHLPFOPGM, T KKLNCEHOHED) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x34667A0", Offset = "0x34655A0", VA = "0x1834667A0")]
	public static void JLFFFFDBMNL<T>(this HashSet<T> LFPKJINAOPL, IEnumerable<T> LLMAEEFJLEM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3464DD0", Offset = "0x3463BD0", VA = "0x183464DD0")]
	public static void EKJGLMDKHAA<T>(this IList<T> IPGDFFNNILJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3464E50", Offset = "0x3463C50", VA = "0x183464E50")]
	public static void EKJGLMDKHAA<T>(this IList<T> IPGDFFNNILJ, int DCBCIMEFAOC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x34649F0", Offset = "0x34637F0", VA = "0x1834649F0")]
	public static List<T> DGMLCNEFCHC<T>(this List<T> IGAKKONPCPC, Predicate<T> JFKPNAODGMM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3465F10", Offset = "0x3464D10", VA = "0x183465F10")]
	public static int GJMFCBKGNNK<T>(this IReadOnlyList<T> IPGDFFNNILJ, Predicate<T> MIMEEOMMODG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x23441E0", Offset = "0x2342FE0", VA = "0x1823441E0")]
	public static bool AIGIEFHLONI<T>(this IReadOnlyList<T> IPGDFFNNILJ, Predicate<T> MIMEEOMMODG, [DCNKMACCFPP(true)] out List<int>? MECEKIGLPDJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3461880", Offset = "0x3460680", VA = "0x183461880")]
	public static bool BBJPLADBJND<T>(this IReadOnlyList<T> IPGDFFNNILJ, T IGAFFKCMBEK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34618D0", Offset = "0x34606D0", VA = "0x1834618D0")]
	public static bool BBJPLADBJND<T>(this IReadOnlyList<T> IPGDFFNNILJ, T IGAFFKCMBEK, EqualityComparer<T> PEBMGIGBOAF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x34640C0", Offset = "0x3462EC0", VA = "0x1834640C0")]
	public static int DBFHHHGIHIP<TElement, TKey>(this IList<TElement> DDFILJACODM, TKey LIFIBKOHLGH, Func<TElement, TKey> CNHLOAEKALJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2C00", Offset = "0x7A2000")] Func<TKey, TKey, int> DHCDKHJFFKD, int FHOMILACEHB = 0, [Optional] int? FNLBOMKPGBB) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3463DC0", Offset = "0x3462BC0", VA = "0x183463DC0")]
	public static int DBFHHHGIHIP<TElement, TKey>(Func<int, TElement> EGOOKNDJCDC, int GJJJCNGNLKA, TKey LIFIBKOHLGH, Func<TElement, TKey> CNHLOAEKALJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2C60", Offset = "0x7A2060")] Func<TKey, TKey, int> DHCDKHJFFKD, int FHOMILACEHB = 0, [Optional] int? FNLBOMKPGBB) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3466540", Offset = "0x3465340", VA = "0x183466540")]
	public static List<T> JJDFJHMEGCP<T>(this IReadOnlyList<T> IPGDFFNNILJ, int FNLBOMKPGBB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3466320", Offset = "0x3465120", VA = "0x183466320")]
	public static bool JANLBCKDPHI<T>(this List<T> IPGDFFNNILJ, T IGAFFKCMBEK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2343DE0", Offset = "0x2342BE0", VA = "0x182343DE0")]
	public static void ACHLPDJFLEO<T>(this List<T> IPGDFFNNILJ, IEnumerable<T> IGAKKONPCPC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3467C60", Offset = "0x3466A60", VA = "0x183467C60")]
	public static void OIPPMFBKPAM<T>(this List<T> IPGDFFNNILJ, IEnumerable<T> IGAKKONPCPC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3465530", Offset = "0x3464330", VA = "0x183465530")]
	public static T EPOEFGLFOBI<T>(this List<T> IGAKKONPCPC, Predicate<T> JFKPNAODGMM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3467400", Offset = "0x3466200", VA = "0x183467400")]
	public static T LAOKJLOGKEL<T>(this List<T> IGAKKONPCPC, int FHOMILACEHB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3465590", Offset = "0x3464390", VA = "0x183465590")]
	public static bool FFNEFHPHPHJ<T>(this List<T> GHJACIALJEA, List<T> OHOAMGFALGE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2343D40", Offset = "0x2342B40", VA = "0x182343D40")]
	public static T ACELCCIOGAE<T>(this IList<T> IPGDFFNNILJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3467960", Offset = "0x3466760", VA = "0x183467960")]
	public static bool NCOEMKAPEFP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2CC0", Offset = "0x7A20C0")] IReadOnlyList<T> IPGDFFNNILJ, int FHOMILACEHB, [MNOKKOCBECA("This should be `T?` in C# 9.")][CDPAEOOJFFF(false)] out T IFKOGMJAAJG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3463200", Offset = "0x3462000", VA = "0x183463200")]
	public static bool BNCLGKCMMMA<T>(IReadOnlyList<T> IPGDFFNNILJ, ICollection IGAKKONPCPC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3464AE0", Offset = "0x34638E0", VA = "0x183464AE0")]
	public static void DOKBAAINMDJ<T>(IReadOnlyList<T> IPGDFFNNILJ, ref ICollection IGAKKONPCPC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3465620", Offset = "0x3464420", VA = "0x183465620")]
	public static bool GELLMIJKDDH<T>(this IReadOnlyList<T> IPGDFFNNILJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3467780", Offset = "0x3466580", VA = "0x183467780")]
	public static string MJBHLHCJJOP<T>(this IEnumerable<T> IPGDFFNNILJ, string DPIODNMFLDN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x34676D0", Offset = "0x34664D0", VA = "0x1834676D0")]
	public static T LLGKCNBCNEN<T>(this IList<T> FEEMIHFJMDK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3467A20", Offset = "0x3466820", VA = "0x183467A20")]
	public static T OHMPNHJCGIH<T>(this IList<T> FEEMIHFJMDK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3467370", Offset = "0x3466170", VA = "0x183467370")]
	public static void KJPLJAEMOHC<T>(this IList<T> FEEMIHFJMDK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3466170", Offset = "0x3464F70", VA = "0x183466170")]
	public static void HOBCODIAKGD<T>(this IList<T> FEEMIHFJMDK, in T KKLNCEHOHED) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34672D0", Offset = "0x34660D0", VA = "0x1834672D0")]
	public static T JMJIKGLNJIC<T>(this IList<T> FEEMIHFJMDK) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FJONFNJFOEN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HCKDKMGBMIP<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x365BFA0", Offset = "0x365ADA0", VA = "0x18365BFA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2AC38C0", Offset = "0x2AC26C0", VA = "0x182AC38C0")]
		[DebuggerHidden]
		public HCKDKMGBMIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x365BDA0", Offset = "0x365ABA0", VA = "0x18365BDA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3B40CF0", Offset = "0x3B3FAF0", VA = "0x183B40CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x365BDD0", Offset = "0x365ABD0", VA = "0x18365BDD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3186F70", Offset = "0x3185D70", VA = "0x183186F70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x233A840", Offset = "0x2339640", VA = "0x18233A840")]
	public static void HNHFOAGFGNN<T>(this T FHCFEADADAC, Action<T> BAHAPLHKBGO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x233A540", Offset = "0x2339340", VA = "0x18233A540")]
	public static V BFFCCMLJOGC<V, T>(this T FHCFEADADAC, Func<T, V> BAHAPLHKBGO, [Optional][MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")] V DGNBLLFJDJH) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x233A680", Offset = "0x2339480", VA = "0x18233A680")]
	public static T? FBDOMCMHPOE<T>(this T FEEMIHFJMDK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x233A7C0", Offset = "0x23395C0", VA = "0x18233A7C0")]
	[IteratorStateMachine(typeof(HCKDKMGBMIP<>))]
	public static IEnumerable<T> FELPJJIGGFK<T>(this T FEEMIHFJMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x233A460", Offset = "0x2339260", VA = "0x18233A460")]
	public static T[] AACNJFKOKKH<T>(this T FEEMIHFJMDK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FCKCPEJBEAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long OCBHOPAAONA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CHGLGOFOMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly FCKCPEJBEAJ NPDLDPJFDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long DDHKEFMKOHE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD330", Offset = "0x6FDC130", VA = "0x186FDD330")]
	public CHGLGOFOMAC(FCKCPEJBEAJ JOLLOICFHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD180", Offset = "0x6FDBF80", VA = "0x186FDD180")]
	public long GLDJHBGEKPH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD2A0", Offset = "0x6FDC0A0", VA = "0x186FDD2A0")]
	public double PBOOPDEINHP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD210", Offset = "0x6FDC010", VA = "0x186FDD210")]
	public double JPEKPAPGNON()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GOJOGCFLMBD
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xF3DC60", Offset = "0xF3CA60", VA = "0x180F3DC60")]
	public static bool CLLLNHJNAJJ(this Type FEEMIHFJMDK, Type FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3471AC0", Offset = "0x34708C0", VA = "0x183471AC0")]
	public static bool CLLLNHJNAJJ<T>(this Type FEEMIHFJMDK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KDAOKCGOFFC
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DMFLBEPFMAE(int KHJFJGKFOHB, int FJGKOIAFMJM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float AMLGGLEDLKD(float LHABMONKJJF, float IOIDJBFAEDO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HFOKKKCGOJB
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31DCDB0", Offset = "0x31DBBB0", VA = "0x1831DCDB0")]
	public static void ODIHOPAGDEH<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2EF0", Offset = "0x7A22F0")] this in KeyValuePair<TKey, TValue> FEEMIHFJMDK, out TKey LGKPJAJAOLI, out TValue KKLNCEHOHED) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31DCB00", Offset = "0x31DB900", VA = "0x1831DCB00")]
	public static (TKey?, TValue?) GNJOOMICBNA<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2F60", Offset = "0x7A2360")] this in KeyValuePair<TKey?, TValue?> FEEMIHFJMDK)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x31DCCE0", Offset = "0x31DBAE0", VA = "0x1831DCCE0")]
	public static KeyValuePair<TKey?, UValue?> MGJNAADLPKL<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A2FD0", Offset = "0x7A23D0")] this KeyValuePair<TKey?, TValue?> FEEMIHFJMDK, UValue KKLNCEHOHED)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class INKJAKOCJIK
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x25E9180", Offset = "0x25E7F80", VA = "0x1825E9180")]
	[NPLFFICJPOI("This should be replaced with the `is not` operator in C# 9.")]
	public static bool CGGHPNDHFGH<T>(this object FEEMIHFJMDK, [DCNKMACCFPP(true)] out T IFKOGMJAAJG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MHLJNEILBEE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDFB0", Offset = "0x6FDCDB0", VA = "0x186FDDFB0")]
	private static byte[] CKJOBBOLLMD(int KOLPKJLAKOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE030", Offset = "0x6FDCE30", VA = "0x186FDE030")]
	private static byte[] DIKGKHFHBPA(long PPKOGNPNACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE0B0", Offset = "0x6FDCEB0", VA = "0x186FDE0B0")]
	private static byte[] EFCLCIOHDNI(ulong PPKOGNPNACA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE860", Offset = "0x6FDD660", VA = "0x186FDE860")]
	public static Guid HKBCPPFHEMN(params Guid[] GCGHCKDCEOF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE570", Offset = "0x6FDD370", VA = "0x186FDE570")]
	public static Guid FLOGCKGNDEE(in Guid IBEBFJLGIHF, int FHOMILACEHB, int OAFCEFJIFII = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE4A0", Offset = "0x6FDD2A0", VA = "0x186FDE4A0")]
	public static Guid FLOGCKGNDEE(in Guid IBEBFJLGIHF, long FHOMILACEHB, int OAFCEFJIFII = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE6B0", Offset = "0x6FDD4B0", VA = "0x186FDE6B0")]
	public static Guid FLOGCKGNDEE(in Guid IBEBFJLGIHF, ulong FHOMILACEHB, int OAFCEFJIFII = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE640", Offset = "0x6FDD440", VA = "0x186FDE640")]
	public static Guid FLOGCKGNDEE(in Guid IBEBFJLGIHF, in Guid JPMKOCEIPFO, int OAFCEFJIFII = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE1B0", Offset = "0x6FDCFB0", VA = "0x186FDE1B0")]
	private static Guid FLOGCKGNDEE(in Guid IBEBFJLGIHF, byte[] GODEIPCMGGL, int OAFCEFJIFII = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE780", Offset = "0x6FDD580", VA = "0x186FDE780")]
	private static void GJHFCAIOFDF(byte[] LOOGPKNLJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE130", Offset = "0x6FDCF30", VA = "0x186FDE130")]
	private static void EOOEDFHEJOE(byte[] LOOGPKNLJEM, int BGNJLPDNBMK, int MDKJCMEMIDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LLGGCPLLGDD
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x174B1C0", Offset = "0x1749FC0", VA = "0x18174B1C0")]
	public static uint DGNHNEEBBHC(this uint FEEMIHFJMDK, int FNLBOMKPGBB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1210E60", Offset = "0x120FC60", VA = "0x181210E60")]
	public static uint GHGMJPFNHKF(this uint FEEMIHFJMDK, int FNLBOMKPGBB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OPCIMLDAHKM
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEF30", Offset = "0x6FDDD30", VA = "0x186FDEF30")]
	public static int ALAKGCKAOJC(this int FEEMIHFJMDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF000", Offset = "0x6FDDE00", VA = "0x186FDF000")]
	public static int ODHFPKCLEHN(this int FEEMIHFJMDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEFB0", Offset = "0x6FDDDB0", VA = "0x186FDEFB0")]
	public static int KBPOJJFJJBM(this int FEEMIHFJMDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEFA0", Offset = "0x6FDDDA0", VA = "0x186FDEFA0")]
	public static int HKALFGKEHNF(this int FEEMIHFJMDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x174B1C0", Offset = "0x1749FC0", VA = "0x18174B1C0")]
	public static int DGNHNEEBBHC(this int FEEMIHFJMDK, int FNLBOMKPGBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1210E60", Offset = "0x120FC60", VA = "0x181210E60")]
	public static int GHGMJPFNHKF(this int FEEMIHFJMDK, int FNLBOMKPGBB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EAMIIEHNIFK
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3782780", Offset = "0x3781580", VA = "0x183782780")]
	public static bool JOGKEELNJLN<T, U>(this T FEEMIHFJMDK, in U GNOEFMFMEOO) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x37826E0", Offset = "0x37814E0", VA = "0x1837826E0")]
	public static bool CAKICNGIEAK<T>(ref T FEEMIHFJMDK, T FGBEDAPNDEP) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PCFNIEMDODL
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float LIAINOBOPAE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float GCJODDBAHNC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool JAGACOHIOAH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float IBIGNAFAOKA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF1F0", Offset = "0x6FDDFF0", VA = "0x186FDF1F0")]
	public static bool NPBEEICAGOG(float IKGMJGNOMBA, float GOEPIJCAGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB340", Offset = "0x4EDA140", VA = "0x184EDB340")]
	public static float HMHKLOJDLLP(float KKLNCEHOHED, float DMGBLCHJFOM, float AFEELFFAOPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB360", Offset = "0x4EDA160", VA = "0x184EDB360")]
	public static int HMHKLOJDLLP(int KKLNCEHOHED, int DMGBLCHJFOM, int AFEELFFAOPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB320", Offset = "0x4EDA120", VA = "0x184EDB320")]
	public static float ALLMKMKNOIC(float KKLNCEHOHED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF040", Offset = "0x6FDDE40", VA = "0x186FDF040")]
	public static float CENNJFIKLNC(float IKGMJGNOMBA, float GOEPIJCAGGA, float FHCFEADADAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF0E0", Offset = "0x6FDDEE0", VA = "0x186FDF0E0")]
	public static float CGBHGCNHIBM(float IKGMJGNOMBA, float GOEPIJCAGGA, float FHCFEADADAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF130", Offset = "0x6FDDF30", VA = "0x186FDF130")]
	public static float JIPNKOBOLLH(float IKGMJGNOMBA, float GOEPIJCAGGA, float KKLNCEHOHED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FDF0F0", Offset = "0x6FDDEF0", VA = "0x186FDF0F0")]
	public static float IFOCNEOAAFC(float IKGMJGNOMBA, float GOEPIJCAGGA, float KKLNCEHOHED)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CBLNNOBEKJK
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC4A0", Offset = "0x2CCB2A0", VA = "0x182CCC4A0")]
	public static TValue BCDJPKNOHBC<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> FEEMIHFJMDK, TKey LGKPJAJAOLI) where TValue : class where TKey : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CLPPJIKFFAL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AFDJCBGMJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPAALEHIGMF();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GCJHKDCKJEC
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class FNFOIDJELIJ : KDAOKCGOFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random DMDCOKAAODJ;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD6C0", Offset = "0x6FDC4C0", VA = "0x186FDD6C0", Slot = "4")]
		public int DMFLBEPFMAE(int LHABMONKJJF, int EDABNIEKAFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD610", Offset = "0x6FDC410", VA = "0x186FDD610", Slot = "5")]
		public float AMLGGLEDLKD(float LHABMONKJJF, float IOIDJBFAEDO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD680", Offset = "0x6FDC480", VA = "0x186FDD680")]
		private double CAOIPNPPIKI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD6F0", Offset = "0x6FDC4F0", VA = "0x186FDD6F0")]
		public FNFOIDJELIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KDAOKCGOFFC JJDFJHMEGCP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD760", Offset = "0x6FDC560", VA = "0x186FDD760")]
	public static ulong MMPMPNPEAGK()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NOGKMHBLPGJ
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool PDKIPPDJMJM<TArgs, T>(in TArgs DCPGFNKOIOA, T IGAFFKCMBEK);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U BGLILPDMCBO<TArg, U>(in TArg GAECONBCCJH);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U JHOKFMJBFHK<TArg, T, U>(in TArg GAECONBCCJH, T FODHHFDFGON);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U JNAHLGODAEF<TArg, T, U>(in TArg GAECONBCCJH, IEnumerable<T> BAHBPPHMFLI);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U JNEIGDCAPPC<TArg, T, U>(in TArg GAECONBCCJH, T FODHHFDFGON);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct GCNCOEJGCLN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x393B820", Offset = "0x393A620", VA = "0x18393B820")]
		[MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) KNFJAGLHALP(T OEKHHPOCLIA)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x393B7B0", Offset = "0x393A5B0", VA = "0x18393B7B0")]
		[MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CGCGNBMCLHI(IEnumerable<T> KFFCJIAHDPA)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KDKJGDMAPIF<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AC38C0", Offset = "0x2AC26C0", VA = "0x182AC38C0")]
		[DebuggerHidden]
		public KDKJGDMAPIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4192D60", Offset = "0x4191B60", VA = "0x184192D60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4192440", Offset = "0x4191240", VA = "0x184192440", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4192110", Offset = "0x4190F10", VA = "0x184192110")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4191F60", Offset = "0x4190D60", VA = "0x184191F60")]
		private void HMDILAAEAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4192C90", Offset = "0x4191A90", VA = "0x184192C90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4192B80", Offset = "0x4191980", VA = "0x184192B80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x33FCC70", Offset = "0x33FBA70", VA = "0x1833FCC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FIDMADAKNLN<T> : IEnumerable<(T, PJNDAEIJLOE<T>)>, IEnumerable, IEnumerator<(T, PJNDAEIJLOE<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, PJNDAEIJLOE<T> Next) <>2__current;

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
		private (T, PJNDAEIJLOE<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4189010", Offset = "0x4187E10", VA = "0x184189010", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, PJNDAEIJLOE<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x4676BA0", Offset = "0x46759A0", VA = "0x184676BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x35EAA60", Offset = "0x35E9860", VA = "0x1835EAA60")]
		[DebuggerHidden]
		public FIDMADAKNLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4676C40", Offset = "0x4675A40", VA = "0x184676C40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4675FE0", Offset = "0x4674DE0", VA = "0x184675FE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4675650", Offset = "0x4674450", VA = "0x184675650")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x46769E0", Offset = "0x46757E0", VA = "0x1846769E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4676880", Offset = "0x4675680", VA = "0x184676880", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, PJNDAEIJLOE<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF5D0", Offset = "0x3CEE3D0", VA = "0x183CEF5D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JAEMGGDMMID<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A37D0", Offset = "0x7A2BD0")]
		private Func<GCNCOEJGCLN<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A38C0", Offset = "0x7A2CC0")]
		public Func<GCNCOEJGCLN<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AC38C0", Offset = "0x2AC26C0", VA = "0x182AC38C0")]
		[DebuggerHidden]
		public JAEMGGDMMID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3188BB0", Offset = "0x31879B0", VA = "0x183188BB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x31886C0", Offset = "0x31874C0", VA = "0x1831886C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3188670", Offset = "0x3187470", VA = "0x183188670")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3188620", Offset = "0x3187420", VA = "0x183188620")]
		private void HMDILAAEAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3188B70", Offset = "0x3187970", VA = "0x183188B70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3188A80", Offset = "0x3187880", VA = "0x183188A80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3188B40", Offset = "0x3187940", VA = "0x183188B40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EHCMFMFPNCC<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public EHCMFMFPNCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x30D8940", Offset = "0x30D7740", VA = "0x1830D8940")]
		internal bool JCFGMLDCIAO(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x30D88D0", Offset = "0x30D76D0", VA = "0x1830D88D0")]
		internal bool HMPIMPDFCNE(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class PBLJAAIDIIC<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x93C090", Offset = "0x93AE90", VA = "0x18093C090", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x35EAA10", Offset = "0x35E9810", VA = "0x1835EAA10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x35EAA60", Offset = "0x35E9860", VA = "0x1835EAA60")]
		[DebuggerHidden]
		public PBLJAAIDIIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x35EA6F0", Offset = "0x35E94F0", VA = "0x1835EA6F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x35EA9D0", Offset = "0x35E97D0", VA = "0x1835EA9D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x35EA910", Offset = "0x35E9710", VA = "0x1835EA910", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C53150", Offset = "0x2C51F50", VA = "0x182C53150", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3410660", Offset = "0x340F460", VA = "0x183410660")]
	public static bool BGFDIHEAFGE<T, TArgs>(this IEnumerable<T> FEEMIHFJMDK, in TArgs DCPGFNKOIOA, PDKIPPDJMJM<TArgs, T> MIMEEOMMODG) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x34128F0", Offset = "0x34116F0", VA = "0x1834128F0")]
	public static U MHKLJIMGPIF<U, T>(this IEnumerable<T> FEEMIHFJMDK, Func<U> OONEHIJFBMP, Func<T, U> OEKHHPOCLIA, Func<IEnumerable<T>, U> KFFCJIAHDPA) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3411CC0", Offset = "0x3410AC0", VA = "0x183411CC0")]
	public static bool GCNJPCNKJFL<T, TArgs>(this IEnumerable<T> FEEMIHFJMDK, in TArgs DCPGFNKOIOA, PDKIPPDJMJM<TArgs, T> MIMEEOMMODG) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x34134F0", Offset = "0x34122F0", VA = "0x1834134F0")]
	public static U PMJPLMIMMOI<U, T, TArg>(this IEnumerable<T> FEEMIHFJMDK, in TArg GAECONBCCJH, BGLILPDMCBO<TArg, U> OONEHIJFBMP, JHOKFMJBFHK<TArg, T, U> OEKHHPOCLIA, JNAHLGODAEF<TArg, T, U> KFFCJIAHDPA) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3412AA0", Offset = "0x34118A0", VA = "0x183412AA0")]
	public static IEnumerable<U> MMPJCDJCINN<U, T, TArg>(this IEnumerable<T> FEEMIHFJMDK, in TArg GAECONBCCJH, JNEIGDCAPPC<TArg, T, U> OHINOBJEIOM) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x28190E0", Offset = "0x2817EE0", VA = "0x1828190E0")]
	public static IEnumerable<T> LDBKAJIHPPC<T>(params IEnumerable<T>[] EDIHAGAFMHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3412640", Offset = "0x3411440", VA = "0x183412640")]
	public static bool IHGJIDMBANC<T>(this IEnumerable<T> KGDHPOJLMNA, IEnumerable<T> FGBEDAPNDEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28190E0", Offset = "0x2817EE0", VA = "0x1828190E0")]
	public static IEnumerable<(TKey?, TValue?)>? FDCIIGCNFIE<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A30F0", Offset = "0x7A24F0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3410AC0", Offset = "0x340F8C0", VA = "0x183410AC0")]
	public static IEnumerable<T> BPHCFCBPHFD<T, TKey>(this IEnumerable<T> CKBMKIFNOID, Func<T, TKey> LCOEHIAHNIM) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1F76800", Offset = "0x1F75600", VA = "0x181F76800")]
	[IteratorStateMachine(typeof(KDKJGDMAPIF<, >))]
	public static IEnumerable<T> JEPLNNBBKOB<T, U>(this IEnumerable<T> FEEMIHFJMDK, IEnumerable<U> FGBEDAPNDEP, [Optional][MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")] T EBIBGHEPBDF) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x30F68F0", Offset = "0x30F56F0", VA = "0x1830F68F0")]
	public static T GGGLFADMKEC<T>(this IEnumerable<T> KGDHPOJLMNA, T DGNBLLFJDJH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3412200", Offset = "0x3411000", VA = "0x183412200")]
	public static T GGGLFADMKEC<T>(this IEnumerable<T> KGDHPOJLMNA, T DGNBLLFJDJH, Func<T, bool> MIMEEOMMODG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3411A20", Offset = "0x3410820", VA = "0x183411A20")]
	public static T? EBBBLCHEMEP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A31B0", Offset = "0x7A25B0")] this IEnumerable<T> FEEMIHFJMDK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3210", Offset = "0x7A2610")] Func<T, bool> MIMEEOMMODG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x30F7070", Offset = "0x30F5E70", VA = "0x1830F7070")]
	[IteratorStateMachine(typeof(FIDMADAKNLN<>))]
	public static IEnumerable<(T, PJNDAEIJLOE<T>)> BCLMHIBBAAL<T>(this IEnumerable<T> FEEMIHFJMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3413400", Offset = "0x3412200", VA = "0x183413400")]
	public static bool PGFHEMFAEEJ<T>(this IEnumerable<T> FEEMIHFJMDK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x28190E0", Offset = "0x2817EE0", VA = "0x1828190E0")]
	public static IEnumerable<GHDKILHJCNJ<T>> PGIEFBHCKJD<T>(this IEnumerable<T> FEEMIHFJMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x34128D0", Offset = "0x34116D0", VA = "0x1834128D0")]
	public static bool KDDGCCJAMHP<T>(this IEnumerable<T> FEEMIHFJMDK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x340FD60", Offset = "0x340EB60", VA = "0x18340FD60")]
	public static IEnumerable<T> ALMCKLCJJEO<T>(this IEnumerable<T> FEEMIHFJMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F76760", Offset = "0x1F75560", VA = "0x181F76760")]
	[IteratorStateMachine(typeof(JAEMGGDMMID<, >))]
	public static IEnumerable<U> IDHBBGDAHLG<U, T>(this IEnumerable<T> FEEMIHFJMDK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3350", Offset = "0x7A2750")] Func<GCNCOEJGCLN<U>, T, (bool Zero, U One, IEnumerable<U> Many)> BGAJLNEHKGJ) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3412250", Offset = "0x3411050", VA = "0x183412250")]
	public static int HNMKGLOJHKD<T>(this IEnumerable<T> FEEMIHFJMDK, int IFGCGBIKJJL = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3413250", Offset = "0x3412050", VA = "0x183413250")]
	public static bool PCNPLIOCIDH<T>(this IEnumerable<T> FEEMIHFJMDK, IEnumerable<T> FGBEDAPNDEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x340FD90", Offset = "0x340EB90", VA = "0x18340FD90")]
	public static (IEnumerable<T>, IEnumerable<T>) AMHHPBMNGPP<T>(this IEnumerable<T> FEEMIHFJMDK, Func<T, bool> IEHIADOMFML) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3413A30", Offset = "0x3412830", VA = "0x183413A30")]
	public static string PPEMDMGOPKD<T>(this IEnumerable<T> FEEMIHFJMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3412F00", Offset = "0x3411D00", VA = "0x183412F00")]
	public static Dictionary<TKey?, TValue?>? NNMHLELONFJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3440", Offset = "0x7A2840")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? KGDHPOJLMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3412F00", Offset = "0x3411D00", VA = "0x183412F00")]
	public static Dictionary<TKey?, TValue?>? NNMHLELONFJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A34A0", Offset = "0x7A28A0")] this IEnumerable<(TKey? Key, TValue? Value)>? KGDHPOJLMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2339E20", Offset = "0x2338C20", VA = "0x182339E20")]
	public static HashSet<T> GCGKCJNOHJA<T>(this IEnumerable<T> FEEMIHFJMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3412EE0", Offset = "0x3411CE0", VA = "0x183412EE0")]
	public static string MNFPDBDCDLK<T>(this IEnumerable<T> FEEMIHFJMDK, string AHBKGEHJLOL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1F766C0", Offset = "0x1F754C0", VA = "0x181F766C0")]
	[IteratorStateMachine(typeof(PBLJAAIDIIC<, >))]
	public static IEnumerable<(T, U)> HGMKFIGCMAB<T, U>(this IEnumerable<T> AEFFKJDEELO, IEnumerable<U> CPGPPMFIMKK) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3410F50", Offset = "0x340FD50", VA = "0x183410F50")]
	public static IEnumerable<V> COJBMHHHGBD<V, T, U>(this IEnumerable<T> FEEMIHFJMDK, IEnumerable<U> FGBEDAPNDEP, Func<T, U, V> EBDHPKBKPMN, [Optional][MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")] T KJOPNCPHMEF, [Optional][MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")] U NKHIKIJKIBJ) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3410FE0", Offset = "0x340FDE0", VA = "0x183410FE0")]
	public static IEnumerable<(T, U)> COJBMHHHGBD<T, U>(this IEnumerable<T> FEEMIHFJMDK, IEnumerable<U> FGBEDAPNDEP, [Optional][MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")] T KJOPNCPHMEF, [Optional][MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")] U NKHIKIJKIBJ) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class ECFNJDCLKDA
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3783300", Offset = "0x3782100", VA = "0x183783300")]
	public static bool HPMLGAHDOPI<T>(this IReadOnlyCollection<T> FEEMIHFJMDK, int FHOMILACEHB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HPHFIIHCHME : FCKCPEJBEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch NPDLDPJFDLD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long OCBHOPAAONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FDDE40", Offset = "0x6FDCC40", VA = "0x186FDDE40", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	private HPHFIIHCHME(Stopwatch JOLLOICFHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDD40", Offset = "0x6FDCB40", VA = "0x186FDDD40")]
	public static HPHFIIHCHME BEGGOOLDNMO(Stopwatch JOLLOICFHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDDA0", Offset = "0x6FDCBA0", VA = "0x186FDDDA0")]
	public static HPHFIIHCHME FJJMCLFBGDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FCIKHKIIGKM
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD3A0", Offset = "0x6FDC1A0", VA = "0x186FDD3A0")]
	public static RigidTransform GJAMGHMKIGM(RigidTransform LGGDEGAHBKA, RigidTransform ACCOHLIGPGI)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class AAJELAAHAPG<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct JDFDBDHODOC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x318ED10", Offset = "0x318DB10", VA = "0x18318ED10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int APHCMNIFKAI;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static CHGLGOFOMAC GGBMNAMNINP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long OCBHOPAAONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4321DE0", Offset = "0x4320BE0", VA = "0x184321DE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x54E7F80", Offset = "0x54E6D80", VA = "0x1854E7F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x54E8050", Offset = "0x54E6E50", VA = "0x1854E8050")]
	public static JDFDBDHODOC IPGGHJACGOB()
	{
		return default(JDFDBDHODOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x54E81F0", Offset = "0x54E6FF0", VA = "0x1854E81F0")]
	private static void LACCACJNLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x54E7FE0", Offset = "0x54E6DE0", VA = "0x1854E7FE0")]
	public static void HKOMOLJGOCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LBBMKCFDKNK
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E52C00", Offset = "0x2E51A00", VA = "0x182E52C00")]
	public static bool CPIMMPDFLKL<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3E10", Offset = "0x7A3210")] this in ReadOnlySpan<T?> FEEMIHFJMDK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3E80", Offset = "0x7A3280")] in ReadOnlySpan<T?> FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2E52D80", Offset = "0x2E51B80", VA = "0x182E52D80")]
	public static int HNMKGLOJHKD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3EF0", Offset = "0x7A32F0")] this in ReadOnlySpan<T?> FEEMIHFJMDK, int IFGCGBIKJJL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2E532B0", Offset = "0x2E520B0", VA = "0x182E532B0")]
	public static string PPEMDMGOPKD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3F60", Offset = "0x7A3360")] this in ReadOnlySpan<T> FEEMIHFJMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2E52EA0", Offset = "0x2E51CA0", VA = "0x182E52EA0")]
	public static string MNFPDBDCDLK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A3FD0", Offset = "0x7A33D0")] this in ReadOnlySpan<T> FEEMIHFJMDK, string AHBKGEHJLOL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class KEGPJOFAEGI
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x130CAA0", Offset = "0x130B8A0", VA = "0x18130CAA0")]
	public static bool GELLMIJKDDH(this string? MAGABHMDKJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDF00", Offset = "0x6FDCD00", VA = "0x186FDDF00")]
	public static string? NGDDPINMBBE(this string? FEEMIHFJMDK, int FLBENAFEKLM, string MEBIAOPFFFE = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDE60", Offset = "0x6FDCC60", VA = "0x186FDDE60")]
	public static string HOPJIHGPIDE(this string FEEMIHFJMDK, int FLBENAFEKLM, string MEBIAOPFFFE = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class APCJJMDNOGB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static FCKCPEJBEAJ PABPHOEJCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FDCFB0", Offset = "0x6FDBDB0", VA = "0x186FDCFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD010", Offset = "0x6FDBE10", VA = "0x186FDD010")]
	public static double PBOOPDEINHP(this FCKCPEJBEAJ FEEMIHFJMDK, long GNJFOGFCJFL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class OIGFNPAACML
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int DNPNJHHCBDC<T>(in T AEFFKJDEELO, in T CPGPPMFIMKK);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class NPLNHBGAHMI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct BCFECJIHJKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int DIDHGEABMII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int GDBDGHNEKAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool IPLGDACDBAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int PBLPJDDGNOB;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4B40", Offset = "0x3DD3940", VA = "0x183DD4B40")]
			public BCFECJIHJKA(int DIDHGEABMII, int GDBDGHNEKAF, bool IPLGDACDBAE)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] ONHCLMGAGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] BHBCEDEAEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly DNPNJHHCBDC<T> DHCDKHJFFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int OFLFAAOLDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> LANPOOJIFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int JDPAKNAIPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A40E0", Offset = "0x7A34E0")]
		private readonly NPLNHBGAHMI<T>.BCFECJIHJKA[] KNGACPIPMEF;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x470E130", Offset = "0x470CF30", VA = "0x18470E130")]
		public NPLNHBGAHMI(T[] ONHCLMGAGFD, DNPNJHHCBDC<T> DHCDKHJFFKD, int OFLFAAOLDJB, Func<bool> LANPOOJIFCB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4140", Offset = "0x7A3540")] T[] ENEANCNCPMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x470DDC0", Offset = "0x470CBC0", VA = "0x18470DDC0")]
		public bool KGCGICENNCK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U JJGJNOFECAA<T, U>(int HBGHKGJNGEK, int BDPBDHKJMJO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A41A0", Offset = "0x7A35A0")] in ReadOnlySpan<T> HDJGBNOJGBF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3272AA0", Offset = "0x32718A0", VA = "0x183272AA0")]
	public static T[] HNECAGOIGNN<T>(int IBDNNEMEJLA, T EBIBGHEPBDF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3271B10", Offset = "0x3270910", VA = "0x183271B10")]
	public static void CGEDIOOAPMH<T>(this T[] PKILCHAOIOE, T EBIBGHEPBDF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2E747F0", Offset = "0x2E735F0", VA = "0x182E747F0")]
	public static void AIOLHBIJHGH<T>(this T[] PKPHLPFOPGM, int EFGAFPEAGGO, int BEAKPHPNBOP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3272C40", Offset = "0x3271A40", VA = "0x183272C40")]
	private static void LBFIILAEHME<T>(this T[] FEEMIHFJMDK, int HFCCHLGNDMD, int EMNODKOBLFC, T[] FGBEDAPNDEP, int BIMAIKPJEDA, int HAILGLAEGFA, T[] IFKOGMJAAJG, int LCLPOMADMDP, DNPNJHHCBDC<T> DHCDKHJFFKD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3272420", Offset = "0x3271220", VA = "0x183272420")]
	public static void FNANAFFKGAN<T>(this T[] FEEMIHFJMDK, int DIDHGEABMII, int FNLBOMKPGBB, DNPNJHHCBDC<T> DHCDKHJFFKD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3273030", Offset = "0x3271E30", VA = "0x183273030")]
	public static NPLNHBGAHMI<T> LLMGAOAPBOP<T>(this T[] FEEMIHFJMDK, DNPNJHHCBDC<T> DHCDKHJFFKD, int OFLFAAOLDJB, Func<bool> LANPOOJIFCB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4080", Offset = "0x7A3480")] T[] ENEANCNCPMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3272C20", Offset = "0x3271A20", VA = "0x183272C20")]
	public static T[] JHFCCAIPKJM<T>(this T[] PKPHLPFOPGM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3272290", Offset = "0x3271090", VA = "0x183272290")]
	public static T[] DIBJIHNADGN<T>(this T[] LMAGPJNLAFF, T EBGHOHHAAIK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3271CA0", Offset = "0x3270AA0", VA = "0x183271CA0")]
	public static T[] DBPDECGJGPH<T>(this T[] LMAGPJNLAFF, int FHOMILACEHB, T EBGHOHHAAIK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3272370", Offset = "0x3271170", VA = "0x183272370")]
	public static T[] FKNJHCAOEJH<T>(this T[] LMAGPJNLAFF, int FHOMILACEHB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3272870", Offset = "0x3271670", VA = "0x183272870")]
	public static T[] HACBHMKBBGI<T>(this T[] LMAGPJNLAFF, int FHOMILACEHB, T EBGHOHHAAIK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x32715D0", Offset = "0x32703D0", VA = "0x1832715D0")]
	public static U[] BEAODHABJDH<U, T>(this T[] KLBCGPELFKC, int PLBDDHOFIHA, JJGJNOFECAA<T, U> FLANLFJCAII) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEA70", Offset = "0x6FDD870", VA = "0x186FDEA70")]
	public static byte[] ECGGDHOOHJD(this byte[] FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEC50", Offset = "0x6FDDA50", VA = "0x186FDEC50")]
	public static byte[] HEMEAILLFHI(this byte[] FEEMIHFJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BDKJINKNNBP
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4508F90", Offset = "0x4507D90", VA = "0x184508F90")]
	public static void KBEBOCOIKNP<K, V>(this IDictionary<K, V> FEEMIHFJMDK, in K LGKPJAJAOLI, in V KKLNCEHOHED, Func<V, V, V> DMBPBGECLCF) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x450A3B0", Offset = "0x45091B0", VA = "0x18450A3B0")]
	public static void PKCOANBDKNO<K, V>(this IDictionary<K, List<V>> FEEMIHFJMDK, in K LGKPJAJAOLI, in V KKLNCEHOHED) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x45098C0", Offset = "0x45086C0", VA = "0x1845098C0")]
	public static TVal LCDMADHPAHK<TVal, TKey>(this IDictionary<TKey, TVal> FCBFEOILBOB, in TKey LGKPJAJAOLI, [Optional][MNOKKOCBECA("`default!` shouldn't be necessary in C# 9")] TVal DGNBLLFJDJH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4509520", Offset = "0x4508320", VA = "0x184509520")]
	public static TVal LCDMADHPAHK<TVal, TKey>(this IDictionary<TKey, TVal> FCBFEOILBOB, in TKey LGKPJAJAOLI, Func<TVal> GDIOLEJPLFN) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4508850", Offset = "0x4507650", VA = "0x184508850")]
	public static TValue JMJIKDOFAHD<TValue, TKey>(this IDictionary<TKey, TValue> FCBFEOILBOB, in TKey LGKPJAJAOLI, [Optional][MNOKKOCBECA("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue DGNBLLFJDJH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x45081F0", Offset = "0x4506FF0", VA = "0x1845081F0")]
	public static V EDFDFGKGNCL<V, K>(this IDictionary<K, V> FEEMIHFJMDK, in K LGKPJAJAOLI) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x45087C0", Offset = "0x45075C0", VA = "0x1845087C0")]
	public static T2[] HOFIGAGGNKF<T2, T1>(this Dictionary<T1, T2>.ValueCollection ILPABGOLMFO) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4508070", Offset = "0x4506E70", VA = "0x184508070")]
	public static bool CBMPBAPEBLM<TKey, TValue>(this IDictionary<TKey, TValue> FEEMIHFJMDK, TKey LGKPJAJAOLI, TValue KKLNCEHOHED) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class GMDFJNINMOE
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDAA0", Offset = "0x6FDC8A0", VA = "0x186FDDAA0")]
	public static float3 EACKAAHFODB(this in RigidTransform FEEMIHFJMDK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDBB0", Offset = "0x6FDC9B0", VA = "0x186FDDBB0")]
	public static float3 LCADCICJONC(this in RigidTransform FEEMIHFJMDK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x304C950", Offset = "0x304B750", VA = "0x18304C950")]
	public static (float3, float3, float3) KPGKMELBBAB(this in RigidTransform FEEMIHFJMDK)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDCE0", Offset = "0x6FDCAE0", VA = "0x186FDDCE0")]
	public static RigidTransform LPOKEONELEF(this in RigidTransform FEEMIHFJMDK)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MCENNIBJAPL
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x302D960", Offset = "0x302C760", VA = "0x18302D960")]
	public static bool NENMDMPJEFC<T>(this IReadOnlyList<T> FEEMIHFJMDK, int FHOMILACEHB, [MNOKKOCBECA("This should be `T?` in C# 9.")][DCNKMACCFPP(true)] out T IFKOGMJAAJG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x302D810", Offset = "0x302C610", VA = "0x18302D810")]
	public static bool FHGNPDAADJC<T>(this IReadOnlyList<T> FEEMIHFJMDK, int FHOMILACEHB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4380", Offset = "0x7A3780")] out GHDKILHJCNJ<T> IFKOGMJAAJG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x302D9F0", Offset = "0x302C7F0", VA = "0x18302D9F0")]
	public static T PPNPCNGBFPN<T>(this IReadOnlyList<T> FEEMIHFJMDK, int FHOMILACEHB, in T CEGLCMGMFNH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x301E560", Offset = "0x301D360", VA = "0x18301E560")]
	[MNOKKOCBECA("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T BCDJPKNOHBC<T>(this IReadOnlyList<T> FEEMIHFJMDK, int FHOMILACEHB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public static T? EFAGJNHOKLP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4430", Offset = "0x7A3830")] this IReadOnlyList<T> FEEMIHFJMDK, int FHOMILACEHB) where T : struct
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
