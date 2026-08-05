using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98DCEC0", Offset = "0x98DC2C0", VA = "0x1898DCEC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class AUKPPPCPLHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly string[] PRGJATECBDV;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98D8D90", Offset = "0x98D8190", VA = "0x1898D8D90")]
		public static bool FMWMJHBXJQJ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98D8FB0", Offset = "0x98D83B0", VA = "0x1898D8FB0")]
		private static bool NLQQEMFAVUL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98D8E60", Offset = "0x98D8260", VA = "0x1898D8E60")]
		public static bool NLQQEMFAVUL(Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98D9080", Offset = "0x98D8480", VA = "0x1898D9080")]
		public static string ZCVXASITZFE(string a, string b = "", bool c = true)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class AYEMFZJMMLR
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98D9890", Offset = "0x98D8C90", VA = "0x1898D9890")]
		public static string QROJOXNWODM(this Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x98D9940", Offset = "0x98D8D40", VA = "0x1898D9940")]
		public static string QROJOXNWODM(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x98D97C0", Offset = "0x98D8BC0", VA = "0x1898D97C0")]
		public static byte[] HDFVCAADSXJ(string a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class XBEVJNUFFBM
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate int CompareDelegate<T>([In] T lhs, [In] T rhs);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate U BreakDelegate<T, U>(int numberOfParts, int partIndex, [In] ReadOnlySpan<T> part);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4103900", Offset = "0x4102D00", VA = "0x184103900")]
		public static ReadOnlyMemory<T> UMVECNRVHSX<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyMemory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x41039F0", Offset = "0x4102DF0", VA = "0x1841039F0")]
		public static ReadOnlySpan<T> VYKBYLLHFFG<T>(this T[] a, int b) where T : notnull
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4103C90", Offset = "0x4103090", VA = "0x184103C90")]
		public static T[] ZJBPWSEVFWW<T>(int a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4100190", Offset = "0x40FF590", VA = "0x184100190")]
		public static void CZXWHALAOTF<T>(this T[] a, T b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x41034F0", Offset = "0x41028F0", VA = "0x1841034F0")]
		public static T[] Remove<T>(this T[] originalArray, int index) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x41021E0", Offset = "0x41015E0", VA = "0x1841021E0")]
		public static void IFMIXJGHOTJ<T>(this T[] a, int b, int c) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x41036C0", Offset = "0x4102AC0", VA = "0x1841036C0")]
		public static void TDBJXIUKQHA<T>(this T[] a, CompareDelegate<T> b, [Optional] T[]? preallocatedWorkBuffer) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41016F0", Offset = "0x4100AF0", VA = "0x1841016F0")]
		private static void FWZCYPDPOQE<T>(this T[] a, int b, int c, T[] d, bool e, CompareDelegate<T> f) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4102290", Offset = "0x4101690", VA = "0x184102290")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4100440", Offset = "0x40FF840", VA = "0x184100440")]
		public static void DRXPAJQCMTN<T>(this T[] a, int b, int c, CompareDelegate<T> d) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4103600", Offset = "0x4102A00", VA = "0x184103600")]
		public static T[] Sort<T>(this T[] array) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4100CD0", Offset = "0x41000D0", VA = "0x184100CD0")]
		public static T[] EUMMTTSRRMD<T>(this T[] a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4102A20", Offset = "0x4101E20", VA = "0x184102A20")]
		public static T[] QATWZZGDOXT<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4102960", Offset = "0x4101D60", VA = "0x184102960")]
		public static T[] OKXBYJBIEPT<T>(this T[] a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x40FFC80", Offset = "0x40FF080", VA = "0x1840FFC80")]
		public static T[] CPJURFCXKXL<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x40FF710", Offset = "0x40FEB10", VA = "0x1840FF710")]
		public static U[] Break<U, T>(this T[] items, int maxItemsPerPart, BreakDelegate<T, U> xForm) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98DF0D0", Offset = "0x98DE4D0", VA = "0x1898DF0D0")]
		public static byte[] SEULFIXBDBL(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98DEE70", Offset = "0x98DE270", VA = "0x1898DEE70")]
		public static byte[] NELWBECXPOZ(this byte[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class MCWBPEACMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98DC990", Offset = "0x98DBD90", VA = "0x1898DC990")]
		public static byte VRHJEZTVCMH(this bool a)
		{
			return default(byte);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class LHZRHCAFUCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98DC990", Offset = "0x98DBD90", VA = "0x1898DC990")]
		public static bool FVDCBGKNSFT(this byte a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class WVXYERKQGWZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x40F5130", Offset = "0x40F4530", VA = "0x1840F5130")]
		public static void CXTOSJAUCLM<T>(this ICollection<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x40F6360", Offset = "0x40F5760", VA = "0x1840F6360")]
		public static void XFPZRSEGTCU<T>(this ICollection<T> a) where T : notnull, IDisposable
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class JYTXCWJSAYR
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B86FF0", Offset = "0x3B863F0", VA = "0x183B86FF0")]
		public static V QKLDXXXLYSJ<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3B86570", Offset = "0x3B85970", VA = "0x183B86570")]
		public static V QKLDXXXLYSJ<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3B83940", Offset = "0x3B82D40", VA = "0x183B83940")]
		public static void GVOXZALEMQP<K, V>(this IDictionary<K, List<V>> a, [In] K key, [In] V value) where K : notnull where V : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3B85630", Offset = "0x3B84A30", VA = "0x183B85630")]
		public static TVal MZMYSFGSYRA<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] TVal defaultValue) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3B86350", Offset = "0x3B85750", VA = "0x183B86350")]
		public static TVal MZMYSFGSYRA<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, Func<TVal> b) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3B84110", Offset = "0x3B83510", VA = "0x183B84110")]
		public static b KQSJKEOOXWQ<b, a>(this IDictionary<a, b> a, [In] a key, [Optional][In][CS9ImprovedNullableConstraints("`default!` and null-oblivious region shouldn't be necessary in C# 9")] b defaultValue)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B872E0", Offset = "0x3B866E0", VA = "0x183B872E0")]
		public static V Take<V, K>(this IDictionary<K, V> self, [In] K key) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3B832B0", Offset = "0x3B826B0", VA = "0x183B832B0")]
		public static T2[] GCFCJAORPHG<T2, T1>(this Dictionary<T1, T2>.ValueCollection a) where T2 : notnull where T1 : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class UMHGZKWDODB
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate bool AllPredicate<TArgs, T>([In] TArgs args, T item);

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate U ArgAmountSwitchZeroDelegate<TArg, U>([In] TArg arg);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate U ArgAmountSwitchOneDelegate<TArg, T, U>([In] TArg arg, T element);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate U ArgAmountSwitchManyDelegate<TArg, T, U>([In] TArg arg, IEnumerable<T> elements);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate U ArgSelectDelegate<TArg, T, U>([In] TArg arg, T element);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public readonly struct SelectAmountPicker<T> where T : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x794DB30", Offset = "0x794CF30", VA = "0x18794DB30")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) One(T one)
			{
				return default((bool, T, IEnumerable<T>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x794D920", Offset = "0x794CD20", VA = "0x18794D920")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) KSCSCJPWGJH(IEnumerable<T> a)
			{
				return default((bool, T, IEnumerable<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GFKQLABLILQ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HashSet<a> DKBXDYERULO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HashSet<a> BNRGHOWLHTO;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public GFKQLABLILQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6352240", Offset = "0x6351640", VA = "0x186352240")]
			internal bool ZEHOWABYHLG(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6352370", Offset = "0x6351770", VA = "0x186352370")]
			internal bool ZEMVTGVVQWP(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class TXNDRSNDRNI<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private a BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private ISet<a> STEUTALXDIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ISet<a> IYBCYPJLVDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IEnumerable<a> CJYRBJQEHHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IEnumerable<a> JEHQQSPWCFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private IEnumerator<a> MXGZQBRVDOG;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private a NZYGQNLOMZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x135B8F0", Offset = "0x135ACF0", VA = "0x18135B8F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x6614000", Offset = "0x6613400", VA = "0x186614000", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x15B8830", Offset = "0x15B7C30", VA = "0x1815B8830")]
			[DebuggerHidden]
			public TXNDRSNDRNI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDF30", Offset = "0x7ABD330", VA = "0x187ABDF30", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDA50", Offset = "0x7ABCE50", VA = "0x187ABDA50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7ABCFE0", Offset = "0x7ABC3E0", VA = "0x187ABCFE0")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x65CF610", Offset = "0x65CEA10", VA = "0x1865CF610", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CGPFBVATFDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDE70", Offset = "0x7ABD270", VA = "0x187ABDE70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class PNFQFYSCCVG<a, b> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private a BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private IEnumerable<a> ROPKNDTPDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IEnumerable<a> IRZNNVETZMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private IEnumerable<b> OYYILYLNGQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IEnumerable<b> VYNQQNJVWOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private a PHPJLQBIWBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public a PTTHVFIWUHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private IEnumerator<a> UXOOPHPVRXX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IEnumerator<b> MDIREISWFAG;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private a NZYGQNLOMZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x4E874C0", Offset = "0x4E868C0", VA = "0x184E874C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x7463410", Offset = "0x7462810", VA = "0x187463410", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x65D8650", Offset = "0x65D7A50", VA = "0x1865D8650")]
			[DebuggerHidden]
			public PNFQFYSCCVG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7463960", Offset = "0x7462D60", VA = "0x187463960", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7462C10", Offset = "0x7462010", VA = "0x187462C10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7461AB0", Offset = "0x7460EB0", VA = "0x187461AB0")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7461BB0", Offset = "0x7460FB0", VA = "0x187461BB0")]
			private void ALONWGIYSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7461D00", Offset = "0x7461100", VA = "0x187461D00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CGPFBVATFDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7463450", Offset = "0x7462850", VA = "0x187463450", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class DDNQKPWLQSB<a> : IEnumerable<(a, Option<a>)>, IEnumerable, IEnumerator<(a, Option<a>)>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private (a Current, Option<a> Next) BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerable<a> ROPKNDTPDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IEnumerable<a> IRZNNVETZMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerator<a> YBLMBXXENJV;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private (a, Option<a>) ATHCRHQFVSQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2E01870", Offset = "0x2E00C70", VA = "0x182E01870", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, Option<a>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x5331330", Offset = "0x5330730", VA = "0x185331330", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2E018A0", Offset = "0x2E00CA0", VA = "0x182E018A0")]
			[DebuggerHidden]
			public DDNQKPWLQSB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5331520", Offset = "0x5330920", VA = "0x185331520", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5330420", Offset = "0x532F820", VA = "0x185330420", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5330230", Offset = "0x532F630", VA = "0x185330230")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x53317E0", Offset = "0x5330BE0", VA = "0x1853317E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, Option<a>)> VVGCIPDZKEH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5331430", Offset = "0x5330830", VA = "0x185331430", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class MTOVDFPPTHS<a, b> : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private b BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<a> ROPKNDTPDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<a> IRZNNVETZMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> KEMYWVAXUGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> ENSKXQAQZUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<a> MXGZQBRVDOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private IEnumerator<b> MXBSSUXXUCX;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private b YAVPLRPZZEU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public MTOVDFPPTHS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6FA7760", Offset = "0x6FA6B60", VA = "0x186FA7760", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6FA6590", Offset = "0x6FA5990", VA = "0x186FA6590", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6FA6070", Offset = "0x6FA5470", VA = "0x186FA6070")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6FA61B0", Offset = "0x6FA55B0", VA = "0x186FA61B0")]
			private void ALONWGIYSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x64A8880", Offset = "0x64A7C80", VA = "0x1864A8880", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> HVGJCMDSJFZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6FA7530", Offset = "0x6FA6930", VA = "0x186FA7530", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WRATEHPMWHP<a, b> : IEnumerable<(a, b)>, IEnumerable, IEnumerator<(a, b)>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private (a Lhs, b Rhs) BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private IEnumerable<a> OEMXTSJJIET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IEnumerable<a> CPBUUOMTYYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IEnumerable<b> OROVKOEFRUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IEnumerable<b> NCEGHGGCYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private IEnumerator<a> XLTHPIXACSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private IEnumerator<b> TYDZIPAWUPS;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private (a, b) QLVHGHZHCBL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x6630FE0", Offset = "0x66303E0", VA = "0x186630FE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1D1C970", Offset = "0x1D1BD70", VA = "0x181D1C970")]
			[DebuggerHidden]
			public WRATEHPMWHP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8528D20", Offset = "0x8528120", VA = "0x188528D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x64BA330", Offset = "0x64B9730", VA = "0x1864BA330", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, b)> WVLZXQVYNRE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x85294B0", Offset = "0x85288B0", VA = "0x1885294B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4063EF0", Offset = "0x40632F0", VA = "0x184063EF0")]
		public static bool All<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98DED60", Offset = "0x98DE160", VA = "0x1898DED60")]
		public static bool All(this IEnumerable<bool> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4072C70", Offset = "0x4072070", VA = "0x184072C70")]
		public static U SVFQUZTEYZY<U, T>(this IEnumerable<T> a, Func<U> b, Func<T, U> c, Func<IEnumerable<T>, U> d) where U : notnull where T : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x40643C0", Offset = "0x40637C0", VA = "0x1840643C0")]
		public static bool Any<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x406BD30", Offset = "0x406B130", VA = "0x18406BD30")]
		public static U JWQVTSLHQOO<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgAmountSwitchZeroDelegate<TArg, U> b, ArgAmountSwitchOneDelegate<TArg, T, U> c, ArgAmountSwitchManyDelegate<TArg, T, U> d) where U : notnull where T : notnull where TArg : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4081120", Offset = "0x4080520", VA = "0x184081120")]
		public static IEnumerable<U> XVHSUBQIEPI<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgSelectDelegate<TArg, T, U> b) where U : notnull where T : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4067980", Offset = "0x4066D80", VA = "0x184067980")]
		public static IEnumerable<T> DBLAWIYWAGS<T>(params IEnumerable<T>[] enumerables) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x406C8C0", Offset = "0x406BCC0", VA = "0x18406C8C0")]
		public static bool MYJSNYPOEGK<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4063890", Offset = "0x4062C90", VA = "0x184063890")]
		public static IEnumerable<(a?, b?)>? AGOZQBRADQZ<a, b>(this IEnumerable<KeyValuePair<a, b>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4075490", Offset = "0x4074890", VA = "0x184075490")]
		public static IEnumerable<T> WUENDUDIJKD<T, TKey>(this IEnumerable<T> a, Func<T, TKey> b) where T : notnull where TKey : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A07400", Offset = "0x3A06800", VA = "0x183A07400")]
		[IteratorStateMachine(typeof(TXNDRSNDRNI<>))]
		public static IEnumerable<T> KMLXOARDNYW<T>(this IEnumerable<T> a, ISet<T> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4072EA0", Offset = "0x40722A0", VA = "0x184072EA0")]
		[IteratorStateMachine(typeof(PNFQFYSCCVG<, >))]
		public static IEnumerable<T> TRHILPBMPPI<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T with) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x406C4D0", Offset = "0x406B8D0", VA = "0x18406C4D0")]
		public static T LGJEZUMJLAV<T>(this IEnumerable<T> a, T b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x406C590", Offset = "0x406B990", VA = "0x18406C590")]
		public static T LGJEZUMJLAV<T>(this IEnumerable<T> a, T b, Func<T, bool> c) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4073E70", Offset = "0x4073270", VA = "0x184073E70")]
		public static c? UHPEZZKGZEM<c>(this IEnumerable<c> self, Func<c, bool> predicate) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4082AD0", Offset = "0x4081ED0", VA = "0x184082AD0")]
		public static void YHIGSRGBCBW<T>(this IEnumerable<T> a, Action<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4063A10", Offset = "0x4062E10", VA = "0x184063A10")]
		[IteratorStateMachine(typeof(DDNQKPWLQSB<>))]
		public static IEnumerable<(T, Option<T>)> ASHQLOKLDXD<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x406A2E0", Offset = "0x40696E0", VA = "0x18406A2E0")]
		public static bool JCUTQPIITCS<T>(this IEnumerable<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4068E70", Offset = "0x4068270", VA = "0x184068E70")]
		public static IEnumerable<IndexValuePair<T>> Index<T>(this IEnumerable<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4069A70", Offset = "0x4068E70", VA = "0x184069A70")]
		public static bool IsEmpty<T>(this IEnumerable<T> self) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x406BFC0", Offset = "0x406B3C0", VA = "0x18406BFC0")]
		public static IEnumerable<T> KBUBCFKBLDV<T>(this IEnumerable<T>? self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x39892D0", Offset = "0x39886D0", VA = "0x1839892D0")]
		[IteratorStateMachine(typeof(MTOVDFPPTHS<, >))]
		public static IEnumerable<U> CWBQTRMYPSC<U, T>(this IEnumerable<T> a, Func<SelectAmountPicker<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4067800", Offset = "0x4066C00", VA = "0x184067800")]
		public static IEnumerable<T> MDBNHJILUYZ<T>(this IEnumerable<IEnumerable<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4069E70", Offset = "0x4069270", VA = "0x184069E70")]
		public static int JBPRQOZNGKY<T>(this IEnumerable<T> a, int b = 0) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4067340", Offset = "0x4066740", VA = "0x184067340")]
		public static bool CUPIGOJZMGO<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4080CF0", Offset = "0x40800F0", VA = "0x184080CF0")]
		public static IEnumerable<T> XMVDVXUXDXU<T>(this IEnumerable<T> a, int b, int c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4082350", Offset = "0x4081750", VA = "0x184082350")]
		public static (IEnumerable<T>, IEnumerable<T>) YBGJUYGJWUW<T>(this IEnumerable<T> a, Func<T, bool> b) where T : notnull
		{
			return default((IEnumerable<T>, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x406E0C0", Offset = "0x406D4C0", VA = "0x18406E0C0")]
		public static string NZIMYSSOZYH<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x406F160", Offset = "0x406E560", VA = "0x18406F160")]
		public static string NZIMYSSOZYH<T>(this IEnumerable<T> a, Func<T, string> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x406A420", Offset = "0x4069820", VA = "0x18406A420")]
		public static Dictionary<d?, e?>? JOIJJKPTOXN<d, e>(this IEnumerable<KeyValuePair<d, e>> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x406B440", Offset = "0x406A840", VA = "0x18406B440")]
		public static Dictionary<f?, g?>? JOIJJKPTOXN<f, g>(this IEnumerable<(f Key, g Value)> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x40669E0", Offset = "0x4065DE0", VA = "0x1840669E0")]
		public static List<T> BXTNCEIEWPV<T>(this IEnumerable<T> a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x406C060", Offset = "0x406B460", VA = "0x18406C060")]
		public static string KVHIWQXCGVH<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x406D020", Offset = "0x406C420", VA = "0x18406D020")]
		public static (IReadOnlyList<h?>?, IReadOnlyList<i?>?) MZZCJLSPUHG<h, i>(this IEnumerable<(h Lhs, i Rhs)> self)
		{
			return default((IReadOnlyList<h>, IReadOnlyList<i>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3A00240", Offset = "0x39FF640", VA = "0x183A00240")]
		[IteratorStateMachine(typeof(WRATEHPMWHP<, >))]
		public static IEnumerable<(T, U)> EFSFKEPXOFD<T, U>(this IEnumerable<T> a, IEnumerable<U> b) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x40813E0", Offset = "0x40807E0", VA = "0x1840813E0")]
		public static IEnumerable<V> XYBGJQJQNLH<V, T, U>(this IEnumerable<T> a, IEnumerable<U> b, Func<T, U, V> c, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where V : notnull where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4081580", Offset = "0x4080980", VA = "0x184081580")]
		public static IEnumerable<(T, U)> XYBGJQJQNLH<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4074840", Offset = "0x4073C40", VA = "0x184074840")]
		public static TOut[] WLJASDWHXAU<TOut, TIn>(this IEnumerable<TIn> a, Func<TIn, TOut> b) where TOut : notnull where TIn : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4070650", Offset = "0x406FA50", VA = "0x184070650")]
		public static Option<U> QJFXNIRCGMW<U, T>(this IEnumerable<T> a, Func<T, U> b) where U : notnull where T : notnull
		{
			return default(Option<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4074D80", Offset = "0x4074180", VA = "0x184074D80")]
		public static void WUDJWXKONFU<T>(this IEnumerable<T> a) where T : notnull, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4065AF0", Offset = "0x4064EF0", VA = "0x184065AF0")]
		public static IEnumerable<KeyValuePair<TKey, List<TItem>>> BLXFLIBHTVY<TKey, TItem>(this IEnumerable<IEnumerable<TItem>> a, Func<TItem, TKey> b) where TKey : notnull where TItem : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class SIBHMYCDCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD020", Offset = "0x3ECC420", VA = "0x183ECD020")]
		public static bool BNQDQUXFUOH<T, U>(this T a, [In] U obj) where T : notnull, IEquatable<T> where U : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD130", Offset = "0x3ECC530", VA = "0x183ECD130")]
		public static bool ZINBBAYTGEK<a>(a a, a b) where a : class, IEquatable<a>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class IKRTLBQHRVO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x15CBAC0", Offset = "0x15CAEC0", VA = "0x1815CBAC0")]
		public static bool FKUPXTLJTBA([In] this float3 a, float3 a, float b = 1E-05f)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class XWQINXFDRZB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x98DF3F0", Offset = "0x98DE7F0", VA = "0x1898DF3F0")]
		public static float3 NLZEWPZFVDW([In] this float4x4 localToWorld, [In] float3 point)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x98DF530", Offset = "0x98DE930", VA = "0x1898DF530")]
		public static float3 UURMKVTOUMY([In] this float4x4 localToWorld, [In] float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class ONAVOTACRXA
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class WKYVCJXOFJQ<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private a BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private a ROPKNDTPDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public a IRZNNVETZMV;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a NZYGQNLOMZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6626680", Offset = "0x6625A80", VA = "0x186626680", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1D1C970", Offset = "0x1D1BD70", VA = "0x181D1C970")]
			[DebuggerHidden]
			public WKYVCJXOFJQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x851AA60", Offset = "0x8519E60", VA = "0x18851AA60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x851A8E0", Offset = "0x8519CE0", VA = "0x18851A8E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CGPFBVATFDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x851AC60", Offset = "0x851A060", VA = "0x18851AC60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CD30", Offset = "0x3D3C130", VA = "0x183D3CD30")]
		public static void CVAGRAJHXAM<a>(this a a, Action<a> b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CBB0", Offset = "0x3D3BFB0", VA = "0x183D3CBB0")]
		public static V BZLGNSFEUVF<V, b>(this b a, Func<b, V> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] V defaultValue) where V : notnull where b : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D150", Offset = "0x3D3C550", VA = "0x183D3D150")]
		public static c? NSNZKRKNHPZ<c>(this c a) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D9E0", Offset = "0x3D3CDE0", VA = "0x183D3D9E0")]
		[IteratorStateMachine(typeof(WKYVCJXOFJQ<>))]
		public static IEnumerable<T> ZGZLVLQDMEY<T>(this T a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CD80", Offset = "0x3D3C180", VA = "0x183D3CD80")]
		public static T[] JVZGJIOVJBN<T>(this T a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class EEJXMTEBPIC
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly MD5 KBSXHVUFQEO;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly SHA1 HPXBXDCTCIH;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly byte[] RUDWMPKYBWD;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly byte[] VZBFCKLRLQB;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x98DAF10", Offset = "0x98DA310", VA = "0x1898DAF10")]
		static EEJXMTEBPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x98DAD70", Offset = "0x98DA170", VA = "0x1898DAD70")]
		public static Guid YMTRFGJAFCL([In] Guid a, [In] Guid b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x98DAE20", Offset = "0x98DA220", VA = "0x1898DAE20")]
		public static Guid YMTRFGJAFCL([In] Guid a, [In] Guid b, [In] Guid c)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3919620", Offset = "0x3918A20", VA = "0x183919620")]
		public static Guid Create<T>([In] Guid namespaceId, T value, int version = 5) where T : struct
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x98DAB90", Offset = "0x98D9F90", VA = "0x1898DAB90")]
		public static Guid Create([In] Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x98DA850", Offset = "0x98D9C50", VA = "0x1898DA850")]
		private static Guid Create([In] Guid namespaceId, byte[] value, int length, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3919310", Offset = "0x3918710", VA = "0x183919310")]
		private static void CDTJSNSDHHG<T>([In] T src, Span<byte> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3919BF0", Offset = "0x3918FF0", VA = "0x183919BF0")]
		private static T VFVTBQIAXQO<T>(Span<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x98DACB0", Offset = "0x98DA0B0", VA = "0x1898DACB0")]
		private static void PIBNNIXHNXQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x98DAC60", Offset = "0x98DA060", VA = "0x1898DAC60")]
		private static void HUWTPKHUDQM(byte[] a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class YANHZHOKSRP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x98DF6E0", Offset = "0x98DEAE0", VA = "0x1898DF6E0")]
		public static int LOLQHEDXJBN(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x98DF620", Offset = "0x98DEA20", VA = "0x1898DF620")]
		public static int HIAUOINVVDB(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x98DF690", Offset = "0x98DEA90", VA = "0x1898DF690")]
		public static int LKPKHZDQEEP(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x98DF750", Offset = "0x98DEB50", VA = "0x1898DF750")]
		public static int OAIILMMTTIY(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8670B30", Offset = "0x866FF30", VA = "0x188670B30")]
		public static int BNVQMUBANCY(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x874E6C0", Offset = "0x874DAC0", VA = "0x18874E6C0")]
		public static int VEOMIOQMEDH(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x98DF670", Offset = "0x98DEA70", VA = "0x1898DF670")]
		public static float JJRPFLEPVGX(this int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x98DF780", Offset = "0x98DEB80", VA = "0x1898DF780")]
		public static (byte, byte, byte, byte) WPSBYEBCXOW(this int a)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x98DF760", Offset = "0x98DEB60", VA = "0x1898DF760")]
		public static int TVRHWGGTRFG([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x98DF610", Offset = "0x98DEA10", VA = "0x1898DF610")]
		public static int COHIOMWXCSM(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x98DF660", Offset = "0x98DEA60", VA = "0x1898DF660")]
		public static int HLIEDFUIYNF(this int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class DEMYEPVNMRS
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x98D9FF0", Offset = "0x98D93F0", VA = "0x1898D9FF0")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) WPSBYEBCXOW(this long a)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x98D9DA0", Offset = "0x98D91A0", VA = "0x1898D9DA0")]
		public static long JCDUWKLLALP([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x98D9D40", Offset = "0x98D9140", VA = "0x1898D9D40")]
		public static string DDKHRWOJHNA(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x98D9F80", Offset = "0x98D9380", VA = "0x1898D9F80")]
		public static string WMXKQKYZDIP(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x98D9F10", Offset = "0x98D9310", VA = "0x1898D9F10")]
		public static string NUMWJTQKPSA(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x98D9DF0", Offset = "0x98D91F0", VA = "0x1898D9DF0")]
		public static string LQEJAGRIWSO(this long a, long b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface SHYGWCVGQZQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Next(int minValue, int maxValue);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float IYFADOFVRCD(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface QPLAPKDKZUS
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		long XDZUGPJPFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class ZBNAIYZVSNX
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x411FF10", Offset = "0x411F310", VA = "0x18411FF10")]
		public static (a?, b?) BKYQZPTXOIO<a, b>([In] this KeyValuePair<a, b> self)
		{
			return default((a, b));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4120360", Offset = "0x411F760", VA = "0x184120360")]
		public static KeyValuePair<c?, e?> ZFBATRCCRLJ<c, e, d>(this KeyValuePair<c, d> self, e value)
		{
			return default(KeyValuePair<c, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class ZSMFOKVNHCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class CQHOZJCYZDX<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IList<a> JFZUISICWSD;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public CQHOZJCYZDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4F9DB40", Offset = "0x4F9CF40", VA = "0x184F9DB40")]
			internal a OKLXUXCXIFB(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4130A10", Offset = "0x412FE10", VA = "0x184130A10")]
		public static int HEZTSEKSYVV<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x41352B0", Offset = "0x41346B0", VA = "0x1841352B0")]
		public static int RPNLGTVZOUX<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4127CF0", Offset = "0x41270F0", VA = "0x184127CF0")]
		public static bool ASOWMPONEKK<a>(this IList<a> self, a? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4128120", Offset = "0x4127520", VA = "0x184128120")]
		public static void CXTOSJAUCLM<T>(this HashSet<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4130270", Offset = "0x412F670", VA = "0x184130270")]
		public static void HCFEUJVAZYL<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x41302F0", Offset = "0x412F6F0", VA = "0x1841302F0")]
		public static void HCFEUJVAZYL<T>(this IList<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4135BB0", Offset = "0x4134FB0", VA = "0x184135BB0")]
		public static void VDRXDTMBFFZ<T>(this List<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x41328F0", Offset = "0x4131CF0", VA = "0x1841328F0")]
		public static bool JDTZYZOOBXC<T>(this IList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<T>? removedElements) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4132FC0", Offset = "0x41323C0", VA = "0x184132FC0")]
		public static List<b> JDTZYZOOBXC<b>(this List<b> a, Predicate<b> b) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4130F00", Offset = "0x4130300", VA = "0x184130F00")]
		public static int HEZTSEKSYVV<T>(this IReadOnlyList<T> a, Predicate<T> b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x41273B0", Offset = "0x41267B0", VA = "0x1841273B0")]
		public static bool ARTTOHZRVVA<T>(this IReadOnlyList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<int>? indices) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x412A070", Offset = "0x4129470", VA = "0x18412A070")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x412A260", Offset = "0x4129660", VA = "0x18412A260")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x412CF80", Offset = "0x412C380", VA = "0x18412CF80")]
		public static int DJGBMFVSKXB<TElement>(this IList<TElement> a, TElement b, [Optional] Func<TElement, TElement, int>? compare, int c = 0, [Optional] int? d) where TElement : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x412C960", Offset = "0x412BD60", VA = "0x18412C960")]
		public static int DJGBMFVSKXB<TElement, TKey>(this IList<TElement> a, TKey b, Func<TElement, TKey> c, [Optional] Func<TKey, TKey, int>? compare, int d = 0, [Optional] int? e) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x412C0C0", Offset = "0x412B4C0", VA = "0x18412C0C0")]
		public static int DJGBMFVSKXB<TElement, TKey>(Func<int, TElement> a, int b, TKey c, Func<TElement, TKey> d, [Optional] Func<TKey, TKey, int>? compare, int e = 0, [Optional] int? f) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x41272D0", Offset = "0x41266D0", VA = "0x1841272D0")]
		public static int AATHIJOGAJO<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x412D4F0", Offset = "0x412C8F0", VA = "0x18412D4F0")]
		public static int EJMMDZZYAXI<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4132540", Offset = "0x4131940", VA = "0x184132540")]
		public static bool HPQUPFHGSHI<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4134E10", Offset = "0x4134210", VA = "0x184134E10")]
		public static void RDHNPOLRDDL<T>(this List<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4135770", Offset = "0x4134B70", VA = "0x184135770")]
		public static void Remove<T>(this List<T> list, IEnumerable<T> collection) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4127330", Offset = "0x4126730", VA = "0x184127330")]
		public static c AHQNWDZHGIJ<c>(this List<c> a, Predicate<c> b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4135B30", Offset = "0x4134F30", VA = "0x184135B30")]
		public static d SMMWEXKDIMY<d>(this List<d> a, int b) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4133920", Offset = "0x4132D20", VA = "0x184133920")]
		public static void LQLUZRUGVAX<T>(this List<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4136550", Offset = "0x4135950", VA = "0x184136550")]
		public static bool XZDLTBZXQXE<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4133B10", Offset = "0x4132F10", VA = "0x184133B10")]
		public static bool OBSXQACRYAK<T>(this List<T> a, List<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x412FE00", Offset = "0x412F200", VA = "0x18412FE00")]
		public static e HBZMPKTULSB<e>(this IList<e> a) where e : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x41334D0", Offset = "0x41328D0", VA = "0x1841334D0")]
		public static bool JXGWNHQSLWD<T>(IReadOnlyList<T>? list, int a, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x412E3E0", Offset = "0x412D7E0", VA = "0x18412E3E0")]
		public static bool FAVLZZJJAXV<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x412F780", Offset = "0x412EB80", VA = "0x18412F780")]
		public static void GWWZDTWHDFQ<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x412EB70", Offset = "0x412DF70", VA = "0x18412EB70")]
		public static bool GEZLRCOJFGX<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4134170", Offset = "0x4133570", VA = "0x184134170")]
		public static string QQSIZWHIXIG<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4134080", Offset = "0x4133480", VA = "0x184134080")]
		public static T QNYORRGREUU<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x412E920", Offset = "0x412DD20", VA = "0x18412E920")]
		public static T FXQVGMSGSYS<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4133C50", Offset = "0x4133050", VA = "0x184133C50")]
		public static void QDNOJUOLSNU<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4133590", Offset = "0x4132990", VA = "0x184133590")]
		public static void LLJCOVDRDDQ<T>(this IList<T> a, [In] T value) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4136240", Offset = "0x4135640", VA = "0x184136240")]
		public static T XOFMLHPZXJD<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class FFRXIWBGXYL
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static float EPFJYIKPICH;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static float FTSYPLMPAPG;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static bool QHHPNWTAULK;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly float WQTOVAHPMQQ;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x98DB500", Offset = "0x98DA900", VA = "0x1898DB500")]
		public static bool OMHTPNYYFOT(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x98DB1A0", Offset = "0x98DA5A0", VA = "0x1898DB1A0")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x98DB180", Offset = "0x98DA580", VA = "0x1898DB180")]
		public static int Clamp(int value, int min, int max)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x98DB410", Offset = "0x98DA810", VA = "0x1898DB410")]
		public static float LEOJNMPDMHE(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x98DB430", Offset = "0x98DA830", VA = "0x1898DB430")]
		public static float Lerp(float a, float b, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x98DB4D0", Offset = "0x98DA8D0", VA = "0x1898DB4D0")]
		public static float MDBPIDTXIXE(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x98DB010", Offset = "0x98DA410", VA = "0x1898DB010")]
		public static float BLLBVLWRMYT(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x98DB760", Offset = "0x98DAB60", VA = "0x1898DB760")]
		public static float ZGBBRNCJVKS(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x98DB0D0", Offset = "0x98DA4D0", VA = "0x1898DB0D0")]
		public static float BLLBVLWRMYT(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x98DB7A0", Offset = "0x98DABA0", VA = "0x1898DB7A0")]
		public static float ZGBBRNCJVKS(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x98DB4E0", Offset = "0x98DA8E0", VA = "0x1898DB4E0")]
		public static float Max(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x98DB1C0", Offset = "0x98DA5C0", VA = "0x1898DB1C0")]
		public static float FORBISLLRTQ(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x98DB380", Offset = "0x98DA780", VA = "0x1898DB380")]
		public static float HJKHXPWQWOR(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x98DB670", Offset = "0x98DAA70", VA = "0x1898DB670")]
		public static float TDFLQJAJHEC(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x98DB5F0", Offset = "0x98DA9F0", VA = "0x1898DB5F0")]
		public static float OXCIJOUHDJS(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4FBA140", Offset = "0x4FB9540", VA = "0x184FBA140")]
		public static int RSZHLNGPOGV(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class MJRPJQWGVKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private System.Random GCLAXEIFPQN;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x98DCD40", Offset = "0x98DC140", VA = "0x1898DCD40")]
		public MJRPJQWGVKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x98DCCC0", Offset = "0x98DC0C0", VA = "0x1898DCCC0")]
		public MJRPJQWGVKE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9370", Offset = "0x8DC8770", VA = "0x188DC9370", Slot = "4")]
		public virtual int Next()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x98DCC30", Offset = "0x98DC030", VA = "0x1898DCC30", Slot = "5")]
		public virtual int Next(int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x98DCC60", Offset = "0x98DC060", VA = "0x1898DCC60", Slot = "6")]
		public virtual int Next(int minValue, int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x98DCC90", Offset = "0x98DC090", VA = "0x1898DCC90")]
		public double OXRMXTUUBDE()
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class NZYFGLPJMSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3D13450", Offset = "0x3D12850", VA = "0x183D13450")]
		[Todo("This should be replaced with the `is not` operator in C# 9.")]
		public static bool LTHILBTWXZB<T>(this object a, [Out][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class HIPLHIXFZUZ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x98DC210", Offset = "0x98DB610", VA = "0x1898DC210")]
		public static (float3, float3, float3) FYXCYIQRQLG([In] this quaternion self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x98DB890", Offset = "0x98DAC90", VA = "0x1898DB890")]
		private static float3 AMBYAZTRDCY(quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x98DC860", Offset = "0x98DBC60", VA = "0x1898DC860")]
		private static float3 OMYDQGVGJQJ(float3 a, math.RotationOrder b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x98DC300", Offset = "0x98DB700", VA = "0x1898DC300")]
		public static float3 IHDYQWVQFQM(this quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x98DC690", Offset = "0x98DBA90", VA = "0x1898DC690")]
		public static float MCIDSBWHOQH(this quaternion a, quaternion b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x98DC3B0", Offset = "0x98DB7B0", VA = "0x1898DC3B0")]
		public static quaternion JKLBYHCNFUA(this quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x98DC7D0", Offset = "0x98DBBD0", VA = "0x1898DC7D0")]
		[CompilerGenerated]
		internal static float3 OMADOXYQSDY(float3 a)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class ZFWFHIJBUCM
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class ZPBVLFWJNGA : SHYGWCVGQZQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly System.Random ZEIDQHGZCWQ;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x98DCC60", Offset = "0x98DC060", VA = "0x1898DCC60", Slot = "4")]
			public int Next(int minInclusive, int maxExclusive)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x98DFC30", Offset = "0x98DF030", VA = "0x1898DFC30", Slot = "5")]
			public float IYFADOFVRCD(float a, float b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x98DFCA0", Offset = "0x98DF0A0", VA = "0x1898DFCA0")]
			private double QFYAWDYNOYU()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x98DFCE0", Offset = "0x98DF0E0", VA = "0x1898DFCE0")]
			public ZPBVLFWJNGA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly SHYGWCVGQZQ JRWFSLJACHD;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x98DF910", Offset = "0x98DED10", VA = "0x1898DF910")]
		public static ulong VXQLHJUQQMW()
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class OTYRIUPRQCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AE80", Offset = "0x3D4A280", VA = "0x183D4AE80")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class MRMMIXOXBAT
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3C05230", Offset = "0x3C04630", VA = "0x183C05230")]
		public static bool ZJGEPOFVCTK<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> a, IReadOnlyDictionary<TKey, TValue> b) where TKey : notnull where TValue : notnull, IEquatable<TValue>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class EBWMFCQBFQQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3918330", Offset = "0x3917730", VA = "0x183918330")]
		public static a? NAFIGDWATPJ<a, TKey>(this IReadOnlyDictionary<TKey, a> self, TKey key) where a : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class MHDVSAMWBOD
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly IReadOnlyList<T> _list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x5C36C60", Offset = "0x5C36060", VA = "0x185C36C60", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly object? ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x5C35FD0", Offset = "0x5C353D0", VA = "0x185C35FD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xDACAB0", Offset = "0xDABEB0", VA = "0x180DACAB0")]
			private Enumerator(IReadOnlyList<T> list, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5308860", Offset = "0x5307C60", VA = "0x185308860")]
			public static Enumerator<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			public readonly void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5C35740", Offset = "0x5C34B40", VA = "0x185C35740", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x2B7BD20", Offset = "0x2B7B120", VA = "0x182B7BD20", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public readonly struct Enumerable<T> : IEnumerable<T>, IEnumerable where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private readonly Enumerator<T> _enumerator;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
			private Enumerable(Enumerator<T> enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x5B563D0", Offset = "0x5B557D0", VA = "0x185B563D0")]
			public static Enumerable<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerable<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5B56100", Offset = "0x5B55500", VA = "0x185B56100", Slot = "4")]
			private IEnumerator<T> CGPFBVATFDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x5B56100", Offset = "0x5B55500", VA = "0x185B56100", Slot = "5")]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x98DC9A0", Offset = "0x98DBDA0", VA = "0x1898DC9A0")]
		public static void Invoke(this IReadOnlyList<Action> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF620", Offset = "0x3BFEA20", VA = "0x183BFF620")]
		public static bool RRJZBUUOGPY<T>(this IReadOnlyList<T> a, int b, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF420", Offset = "0x3BFE820", VA = "0x183BFF420")]
		public static bool ROASBFWKERB<T>(this IReadOnlyList<T> a, int b, [Out] IndexValuePair<T> result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF870", Offset = "0x3BFEC70", VA = "0x183BFF870")]
		public static T XHYBYKIMKRI<T>(this IReadOnlyList<T> a, int b, [In] T optB) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3BFEEB0", Offset = "0x3BFE2B0", VA = "0x183BFEEB0")]
		[CS9ImprovedNullableConstraints("This should return `T?` in C# 9. `default! isn't necessary.")]
		public static T EGUJYWNIMYH<T>(this IReadOnlyList<T> a, int b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF120", Offset = "0x3BFE520", VA = "0x183BFF120")]
		public static a? NAFIGDWATPJ<a>(this IReadOnlyList<a> self, int a) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF1E0", Offset = "0x3BFE5E0", VA = "0x183BFF1E0")]
		public static Enumerable<T> RAHERNTOHAO<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(Enumerable<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class WAWIWGGGEQU
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x40ECE50", Offset = "0x40EC250", VA = "0x1840ECE50")]
		public static int MKCMEGJCBST<a>([In] this ReadOnlySequence<a> sequence, [In] a value) where a : IEquatable<a>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x40ED310", Offset = "0x40EC710", VA = "0x1840ED310")]
		public static bool TOUZAESUPSN<c>([In] this ReadOnlySequence<c> sequence, [In] ReadOnlySpan<c> other) where c : IEquatable<c>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class WZLSMQZSVYH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x40F83C0", Offset = "0x40F77C0", VA = "0x1840F83C0")]
		public static string NZIMYSSOZYH<T>([In] this ReadOnlySpan<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x40F7910", Offset = "0x40F6D10", VA = "0x1840F7910")]
		public static string KVHIWQXCGVH<T>([In] this ReadOnlySpan<T> self, string a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct ReadOnlyStopwatch : QPLAPKDKZUS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly QPLAPKDKZUS _baseStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly long _baseTicks;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long XDZUGPJPFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x98DEA50", Offset = "0x98DDE50", VA = "0x1898DEA50", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double OBANBTXQUJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x98DE990", Offset = "0x98DDD90", VA = "0x1898DE990")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double NOCBKHQAIAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x98DE8D0", Offset = "0x98DDCD0", VA = "0x1898DE8D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1E40420", Offset = "0x1E3F820", VA = "0x181E40420")]
		public ReadOnlyStopwatch(QPLAPKDKZUS baseStopwatch, long baseTicks)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class BUPRXPEADMC
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static QPLAPKDKZUS PRBYYDRENRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x98D9A70", Offset = "0x98D8E70", VA = "0x1898D9A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x98D9AC0", Offset = "0x98D8EC0", VA = "0x1898D9AC0")]
		public static long LGUPCMNOEJA(this QPLAPKDKZUS a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x98D99E0", Offset = "0x98D8DE0", VA = "0x1898D99E0")]
		public static double BGQNNBTPCCW(this QPLAPKDKZUS a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x98D9BD0", Offset = "0x98D8FD0", VA = "0x1898D9BD0")]
		public static double WBQEPPYTXHJ(this QPLAPKDKZUS a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x98D9B50", Offset = "0x98D8F50", VA = "0x1898D9B50")]
		public static ReadOnlyStopwatch UBXAFMOLYWP(this QPLAPKDKZUS a)
		{
			return default(ReadOnlyStopwatch);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class YWUIVWWDILM : QPLAPKDKZUS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Stopwatch JZBASUSJRUO;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public long XDZUGPJPFNC
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x98DF8F0", Offset = "0x98DECF0", VA = "0x1898DF8F0", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		private YWUIVWWDILM(Stopwatch a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x98DF7F0", Offset = "0x98DEBF0", VA = "0x1898DF7F0")]
		public static YWUIVWWDILM JIHACNEAFPX(Stopwatch a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x98DF850", Offset = "0x98DEC50", VA = "0x1898DF850")]
		public static YWUIVWWDILM NGNVLNYETAU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class IAEFAGOFJYR
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x97C02F0", Offset = "0x97BF6F0", VA = "0x1897C02F0")]
		public static float3 up([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x97C01C0", Offset = "0x97BF5C0", VA = "0x1897C01C0")]
		public static float3 UCNQMYKXCSH([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x13B4EB0", Offset = "0x13B42B0", VA = "0x1813B4EB0")]
		public static (float3, float3, float3) GODIRPSIDEM([In] this RigidTransform self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x98DC930", Offset = "0x98DBD30", VA = "0x1898DC930")]
		public static RigidTransform GXVBHELFAOC([In] this RigidTransform self)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class MWKTWUJGABX
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x98DCDD0", Offset = "0x98DC1D0", VA = "0x1898DCDD0")]
		public static RigidTransform PFWHHXTJQPM(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class XOSHJTZYTXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x98DF330", Offset = "0x98DE730", VA = "0x1898DF330")]
		public static float NDGTVQDSSTJ([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x98DF3E0", Offset = "0x98DE7E0", VA = "0x1898DF3E0")]
		public static int YIYTRRORXFS(this float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x98DF370", Offset = "0x98DE770", VA = "0x1898DF370")]
		public static (byte, byte, byte, byte) WPSBYEBCXOW(this float a)
		{
			return default((byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class EQJXHCPYOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3929510", Offset = "0x3928910", VA = "0x183929510")]
		public static ReadOnlySpan<a?> VYKBYLLHFFG<a>([In] this Span<a> self)
		{
			return default(ReadOnlySpan<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class ACEBRSXMMEV
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x98D8D30", Offset = "0x98D8130", VA = "0x1898D8D30")]
		public static StringBuilder SUCLCQFIBIE(this StringBuilder a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x98D8C60", Offset = "0x98D8060", VA = "0x1898D8C60")]
		public static StringBuilder OCDGOTXWVQT(this StringBuilder a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x98D8CD0", Offset = "0x98D80D0", VA = "0x1898D8CD0")]
		public static StringBuilder OGXRDLKZRGI(this StringBuilder a, char b, int c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class PQOLRHVDSVY
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly Regex QSYWWWBDRAS;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static Regex CNFYKQVTGUY;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static Regex VSVEJLLWLXL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly char[] LZOKHJCHCQK;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly string[] XIVCOEEIYYF;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8A0EC80", Offset = "0x8A0E080", VA = "0x188A0EC80")]
		public static bool GEZLRCOJFGX(this string? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x98DE000", Offset = "0x98DD400", VA = "0x1898DE000")]
		public static string? VNRJHBIJQYU(this string? a, int b, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x98DDB00", Offset = "0x98DCF00", VA = "0x1898DDB00")]
		public static string BLRMLCJAGXU(this string a, int b, string c = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x98DDEE0", Offset = "0x98DD2E0", VA = "0x1898DDEE0")]
		public static int OQTMJDVQXSI(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD60", Offset = "0x98DD160", VA = "0x1898DDD60")]
		public static string LAPGCYJGPWF(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x98DDF50", Offset = "0x98DD350", VA = "0x1898DDF50")]
		public static string QTWVNUBWAJZ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x98DDC60", Offset = "0x98DD060", VA = "0x1898DDC60")]
		public static string[] KPKUWWYQKRD(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x98DDB90", Offset = "0x98DCF90", VA = "0x1898DDB90")]
		private static bool ELMLXLKKTGA(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x98DE440", Offset = "0x98DD840", VA = "0x1898DE440")]
		private static bool ZPELDGYWRCP(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x98DE0C0", Offset = "0x98DD4C0", VA = "0x1898DE0C0")]
		public static int VWNSJAAFHTE(string a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class NYCOYJUYLSF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x98DCE90", Offset = "0x98DC290", VA = "0x1898DCE90")]
		public static bool JQOVZJIIJEO(this Type a, Type b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3D12B40", Offset = "0x3D11F40", VA = "0x183D12B40")]
		public static bool JQOVZJIIJEO<T>(this Type a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class MKSTOYEWGOS
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8670B30", Offset = "0x866FF30", VA = "0x188670B30")]
		public static uint BNVQMUBANCY(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x874E6C0", Offset = "0x874DAC0", VA = "0x18874E6C0")]
		public static uint VEOMIOQMEDH(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x98DCDC0", Offset = "0x98DC1C0", VA = "0x1898DCDC0")]
		public static uint NUHAEJPMIBR(this uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x97A2F80", Offset = "0x97A2380", VA = "0x1897A2F80")]
		public static int YIYTRRORXFS(this uint a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.NumberStrings
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class AWCJQJOJPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x98D94E0", Offset = "0x98D88E0", VA = "0x1898D94E0")]
		public static string BLRKMTTWKDI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x98D96B0", Offset = "0x98D8AB0", VA = "0x1898D96B0")]
		public static string UXRRBXQTIET(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x98D95F0", Offset = "0x98D89F0", VA = "0x1898D95F0")]
		private static string SONUMXFYAHM(double a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class RNOKPOATKTT
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BD70", Offset = "0x3E0B170", VA = "0x183E0BD70")]
		public static a FCEINWLQFPW<a>(IEnumerable<string> flagStrings, [Optional] a a) where a : struct, Enum, IConvertible
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3E0B810", Offset = "0x3E0AC10", VA = "0x183E0B810")]
		public static b CGQYWGZMMQV<b>(IEnumerable<string> flagStrings, [Optional] b a) where b : struct, Enum, IConvertible
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C310", Offset = "0x3E0B710", VA = "0x183E0C310")]
		public static c IWBUFSJUGXG<c>(IEnumerable<string> flagStrings, [Optional] c a) where c : struct, Enum, IConvertible
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3E09930", Offset = "0x3E08D30", VA = "0x183E09930")]
		private static bool OZUZBRDWARV(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class ZURKQNIYLQS
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4136620", Offset = "0x4135A20", VA = "0x184136620")]
		public static bool XMKTYRNKGMU<a>([In] this a? self, [Out] a a) where a : struct
		{
			return default(bool);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime.Stats
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class OJUHVLYBNSV
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x98DD260", Offset = "0x98DC660", VA = "0x1898DD260")]
		public static StatsResults WCYAVSVGSPZ(IReadOnlyList<float> a, int b = -1, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x98DD370", Offset = "0x98DC770", VA = "0x1898DD370")]
		private static StatsResults WFHLTTGUMDA(IReadOnlyList<float> a, int b, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x98DD9B0", Offset = "0x98DCDB0", VA = "0x1898DD9B0")]
		private static float YWHRNODHKRD(IReadOnlyList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x98DCF40", Offset = "0x98DC340", VA = "0x1898DCF40")]
		public static float JDIRERZGPGI(IReadOnlyList<float> a, int b, int c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct PercentileResults
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly float P25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly float P50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float P75;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly float P90;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly float P95;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly float P99;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x98DE8A0", Offset = "0x98DDCA0", VA = "0x1898DE8A0")]
		public PercentileResults(float p25, float p50, float p75, float p90, float p95, float p99)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Flags]
	public enum StatResultFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		N = 2,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Min = 4,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Max = 8,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Mean = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Median = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		SVariance = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		PVariance = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Q1 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Q3 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		P25 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		P50 = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		P75 = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		P90 = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		P95 = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		P99 = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		HitchN = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		HitchThres = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		HitchThresOff = 0x40000,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		PercentileFlags = 0xFC00,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		HitchFlags = 0x70000,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public readonly struct StatsResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class EDQTVAPVIOH : IEnumerable<(StatResultFlags, float)>, IEnumerable, IEnumerator<(StatResultFlags, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private (StatResultFlags flag, float result) BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private StatResultFlags GESQOZKUAEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public StatResultFlags PVSRUOIJPNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public StatsResults IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public StatsResults FQZOPPOTNZH;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private (StatResultFlags, float) VWCTJBYERSB
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x13F81B0", Offset = "0x13F75B0", VA = "0x1813F81B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((StatResultFlags, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x98DA7C0", Offset = "0x98D9BC0", VA = "0x1898DA7C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x64B5AB0", Offset = "0x64B4EB0", VA = "0x1864B5AB0")]
			[DebuggerHidden]
			public EDQTVAPVIOH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x98DA180", Offset = "0x98D9580", VA = "0x1898DA180", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x98DA810", Offset = "0x98D9C10", VA = "0x1898DA810", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x98DA0B0", Offset = "0x98D94B0", VA = "0x1898DA0B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(StatResultFlags, float)> EOOOLXCBNPM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x98DA0B0", Offset = "0x98D94B0", VA = "0x1898DA0B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly int N;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly int HitchN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly float HitchThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly float HitchThresholdOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float Min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float Max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float Mean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float Median;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly float varianceSum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly float LowerQuartile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly float UpperQuartile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly PercentileResults PercentileResults;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float HVIQGEXQTQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x98DEBD0", Offset = "0x98DDFD0", VA = "0x1898DEBD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float YQOFYPAOIMG
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x98DEBB0", Offset = "0x98DDFB0", VA = "0x1898DEBB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x98DEBF0", Offset = "0x98DDFF0", VA = "0x1898DEBF0")]
		public StatsResults(int n, int hitchN, float hitchThreshold, float hitchThresholdOffset, float min, float max, float mean, float median, float varianceSum, float lowerQuartile, float upperQuartile, PercentileResults percentileResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x98DEB10", Offset = "0x98DDF10", VA = "0x1898DEB10")]
		[IteratorStateMachine(typeof(EDQTVAPVIOH))]
		public IEnumerable<(StatResultFlags, float)> BKEWNQKCKHG(StatResultFlags a)
		{
			return null;
		}
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
