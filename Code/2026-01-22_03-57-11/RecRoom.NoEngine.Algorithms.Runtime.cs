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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x843C3B0", Offset = "0x843ABB0", VA = "0x18843C3B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class GZMYRFPEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly string[] GEVEXYGALDU;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8439A90", Offset = "0x8438290", VA = "0x188439A90")]
		public static bool FGLTUQNJUPI(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8439B60", Offset = "0x8438360", VA = "0x188439B60")]
		private static bool LDAYMBACGVW(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8439C30", Offset = "0x8438430", VA = "0x188439C30")]
		public static bool LDAYMBACGVW(Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8439750", Offset = "0x8437F50", VA = "0x188439750")]
		public static string CHDLZVJLAJB(string a, string b = "", bool c = true)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class OENCNRTLNXO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x843C5A0", Offset = "0x843ADA0", VA = "0x18843C5A0")]
		public static string YTUZLYSGUTV(this Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x843C500", Offset = "0x843AD00", VA = "0x18843C500")]
		public static string YTUZLYSGUTV(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x843C430", Offset = "0x843AC30", VA = "0x18843C430")]
		public static byte[] THOUIGWUIDQ(string a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class HJTNWRSYPHR
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate int CompareDelegate<T>([In] T lhs, [In] T rhs);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate U BreakDelegate<T, U>(int numberOfParts, int partIndex, [In] ReadOnlySpan<T> part);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x36D2D50", Offset = "0x36D1550", VA = "0x1836D2D50")]
		public static ReadOnlyMemory<T> ETCZGBTKVWO<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyMemory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x36DB400", Offset = "0x36D9C00", VA = "0x1836DB400")]
		public static ReadOnlySpan<T> TFCWJMMGGAJ<T>(this T[] a, int b) where T : notnull
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x36D31D0", Offset = "0x36D19D0", VA = "0x1836D31D0")]
		public static T[] FWEVSQYCBPR<T>(int a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x36D2E10", Offset = "0x36D1610", VA = "0x1836D2E10")]
		public static void EWWVDVWGAXE<T>(this T[] a, T b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x36DADE0", Offset = "0x36D95E0", VA = "0x1836DADE0")]
		public static T[] Remove<T>(this T[] originalArray, int index) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x36D34B0", Offset = "0x36D1CB0", VA = "0x1836D34B0")]
		public static void GNJZWJASNUW<T>(this T[] a, int b, int c) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x36DAEF0", Offset = "0x36D96F0", VA = "0x1836DAEF0")]
		public static void SYMSYXXPVQZ<T>(this T[] a, CompareDelegate<T> b, [Optional] T[]? preallocatedWorkBuffer) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x36DA400", Offset = "0x36D8C00", VA = "0x1836DA400")]
		private static void ROJRFZXPPXN<T>(this T[] a, int b, int c, T[] d, bool e, CompareDelegate<T> f) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x36D3560", Offset = "0x36D1D60", VA = "0x1836D3560")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x36DB590", Offset = "0x36D9D90", VA = "0x1836DB590")]
		public static void XJDMRRQBWIA<T>(this T[] a, int b, int c, CompareDelegate<T> d) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x36DB2B0", Offset = "0x36D9AB0", VA = "0x1836DB2B0")]
		public static T[] Sort<T>(this T[] array) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x36DAA80", Offset = "0x36D9280", VA = "0x1836DAA80")]
		public static T[] RRRVTEFKMFE<T>(this T[] a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x36D3C30", Offset = "0x36D2430", VA = "0x1836D3C30")]
		public static T[] OQOLDFTRQGO<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x36DB4D0", Offset = "0x36D9CD0", VA = "0x1836DB4D0")]
		public static T[] UFDOTXDIVBM<T>(this T[] a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x36D46C0", Offset = "0x36D2EC0", VA = "0x1836D46C0")]
		public static T[] QUTZKEWQAMY<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x36D27E0", Offset = "0x36D0FE0", VA = "0x1836D27E0")]
		public static U[] Break<U, T>(this T[] items, int maxItemsPerPart, BreakDelegate<T, U> xForm) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x843A460", Offset = "0x8438C60", VA = "0x18843A460")]
		public static byte[] YLMRPDUUFKO(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x843A200", Offset = "0x8438A00", VA = "0x18843A200")]
		public static byte[] KRVAMTHTPLU(this byte[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class PZYGIEFCSIY
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x843B6E0", Offset = "0x8439EE0", VA = "0x18843B6E0")]
		public static byte YDRDACKLZBM(this bool a)
		{
			return default(byte);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class JXUTPCVUFCY
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x843B6E0", Offset = "0x8439EE0", VA = "0x18843B6E0")]
		public static bool UFCXLZADREM(this byte a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class XHDVENVCWNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C18360", Offset = "0x3C16B60", VA = "0x183C18360")]
		public static void YQAIAKMJVMX<T>(this ICollection<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3C182F0", Offset = "0x3C16AF0", VA = "0x183C182F0")]
		public static void JNZMFMPYXBH<T>(this ICollection<T> a) where T : notnull, IDisposable
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class NCWSRYNPPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x38A0BE0", Offset = "0x389F3E0", VA = "0x1838A0BE0")]
		public static V BJKBTYVBKWG<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x38A0130", Offset = "0x389E930", VA = "0x1838A0130")]
		public static V BJKBTYVBKWG<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x38A1BE0", Offset = "0x38A03E0", VA = "0x1838A1BE0")]
		public static void PKRPIOIUWVW<K, V>(this IDictionary<K, List<V>> a, [In] K key, [In] V value) where K : notnull where V : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x38A26B0", Offset = "0x38A0EB0", VA = "0x1838A26B0")]
		public static TVal SJVFVALFKHJ<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] TVal defaultValue) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x38A33D0", Offset = "0x38A1BD0", VA = "0x1838A33D0")]
		public static TVal SJVFVALFKHJ<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, Func<TVal> b) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x389F470", Offset = "0x389DC70", VA = "0x18389F470")]
		public static b ALQKHLZCUQJ<b, a>(this IDictionary<a, b> a, [In] a key, [Optional][In][CS9ImprovedNullableConstraints("`default!` and null-oblivious region shouldn't be necessary in C# 9")] b defaultValue)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x38A3590", Offset = "0x38A1D90", VA = "0x1838A3590")]
		public static V Take<V, K>(this IDictionary<K, V> self, [In] K key) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x38A0FC0", Offset = "0x389F7C0", VA = "0x1838A0FC0")]
		public static T2[] MUUABBZGGOL<T2, T1>(this Dictionary<T1, T2>.ValueCollection a) where T2 : notnull where T1 : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class UHQLNPDDHLS
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
			[Cpp2IlInjected.Address(RVA = "0x5EBF4C0", Offset = "0x5EBDCC0", VA = "0x185EBF4C0")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) One(T one)
			{
				return default((bool, T, IEnumerable<T>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5EBF8A0", Offset = "0x5EBE0A0", VA = "0x185EBF8A0")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) PIDPJUSOPBO(IEnumerable<T> a)
			{
				return default((bool, T, IEnumerable<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PLYNQDPSBBP<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HashSet<a> EXFAIBHWRNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HashSet<a> TSQYLRBFJTH;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public PLYNQDPSBBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5AB8540", Offset = "0x5AB6D40", VA = "0x185AB8540")]
			internal bool KMMHJPSCLRT(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5AB83B0", Offset = "0x5AB6BB0", VA = "0x185AB83B0")]
			internal bool KMHAMIYFCGK(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class QSFLDQNBOGV<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private a VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private ISet<a> PTENQSAIHIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ISet<a> OHPSZJQIMQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IEnumerable<a> ZDHBKYVUAZU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IEnumerable<a> WLCVMSYIXWB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private IEnumerator<a> YLHXGKHQDKH;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private a DVSNWWWDAWC
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x10A36B0", Offset = "0x10A1EB0", VA = "0x1810A36B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x4FD7E30", Offset = "0x4FD6630", VA = "0x184FD7E30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1326640", Offset = "0x1324E40", VA = "0x181326640")]
			[DebuggerHidden]
			public QSFLDQNBOGV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5BDA080", Offset = "0x5BD8880", VA = "0x185BDA080", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5BD9C70", Offset = "0x5BD8470", VA = "0x185BD9C70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5BDA3E0", Offset = "0x5BD8BE0", VA = "0x185BDA3E0")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3D66D30", Offset = "0x3D65530", VA = "0x183D66D30", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4E665B0", Offset = "0x4E64DB0", VA = "0x184E665B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> RVYKOQAFHBX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5BD9580", Offset = "0x5BD7D80", VA = "0x185BD9580", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class BFAVWIQGEJN<a, b> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private a VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private IEnumerable<a> IOIMTKAJYNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IEnumerable<a> ENDVHLIOETA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private IEnumerable<b> BJJTDDTPIEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IEnumerable<b> NVSICCROJUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private a ICURSNJKQID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public a SMWMDQPACWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private IEnumerator<a> GRVQHDDIPHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IEnumerator<b> MZZZDAOJBRL;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private a DVSNWWWDAWC
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x47AC650", Offset = "0x47AAE50", VA = "0x1847AC650", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x6F69850", Offset = "0x6F68050", VA = "0x186F69850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4E6C8D0", Offset = "0x4E6B0D0", VA = "0x184E6C8D0")]
			[DebuggerHidden]
			public BFAVWIQGEJN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6F69890", Offset = "0x6F68090", VA = "0x186F69890", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6F69050", Offset = "0x6F67850", VA = "0x186F69050", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6F6A160", Offset = "0x6F68960", VA = "0x186F6A160")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6F6A340", Offset = "0x6F68B40", VA = "0x186F6A340")]
			private void YQUQFKFMWJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3D66D30", Offset = "0x3D65530", VA = "0x183D66D30", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6F69E20", Offset = "0x6F68620", VA = "0x186F69E20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> RVYKOQAFHBX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6F683F0", Offset = "0x6F66BF0", VA = "0x186F683F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class DSOMBKVBPAO<a> : IEnumerable<(a, Option<a>)>, IEnumerable, IEnumerator<(a, Option<a>)>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private (a Current, Option<a> Next) VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerable<a> IOIMTKAJYNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IEnumerable<a> ENDVHLIOETA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerator<a> DZPDVLDBMBM;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private (a, Option<a>) SFQVIHBBJMF
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2B6E970", Offset = "0x2B6D170", VA = "0x182B6E970", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, Option<a>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x411CA90", Offset = "0x411B290", VA = "0x18411CA90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B6E9A0", Offset = "0x2B6D1A0", VA = "0x182B6E9A0")]
			[DebuggerHidden]
			public DSOMBKVBPAO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x411CB90", Offset = "0x411B390", VA = "0x18411CB90", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x411BBB0", Offset = "0x411A3B0", VA = "0x18411BBB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x411CD90", Offset = "0x411B590", VA = "0x18411CD90")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x3D66D30", Offset = "0x3D65530", VA = "0x183D66D30", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x411BA10", Offset = "0x411A210", VA = "0x18411BA10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, Option<a>)> DYKWUDQFJRM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x411BAC0", Offset = "0x411A2C0", VA = "0x18411BAC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class APHEWNNUNRB<a, b> : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private b VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<a> IOIMTKAJYNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<a> ENDVHLIOETA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> FBPBRCQOIZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> VOXDUCJLVYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<a> YLHXGKHQDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private IEnumerator<b> YLNEDRBNMVQ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private b HZFFGNZMXWT
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
			[DebuggerHidden]
			public APHEWNNUNRB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x544F280", Offset = "0x544DA80", VA = "0x18544F280", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x544EC00", Offset = "0x544D400", VA = "0x18544EC00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x544F6D0", Offset = "0x544DED0", VA = "0x18544F6D0")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x544F800", Offset = "0x544E000", VA = "0x18544F800")]
			private void YQUQFKFMWJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3D66D30", Offset = "0x3D65530", VA = "0x183D66D30", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x4E368E0", Offset = "0x4E350E0", VA = "0x184E368E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> YDFICXQJKKM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x544E0F0", Offset = "0x544C8F0", VA = "0x18544E0F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WEJZDOJXKUU<a, b> : IEnumerable<(a, b)>, IEnumerable, IEnumerator<(a, b)>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private (a Lhs, b Rhs) VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private IEnumerable<a> QDELKHFNDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IEnumerable<a> SHGZMOJRMYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IEnumerable<b> QFTWLFVNCDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IEnumerable<b> AVFTAQSZPMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private IEnumerator<a> BOZWIRZAVBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private IEnumerator<b> SNGUJRIZXXN;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private (a, b) AKLFDCJYHKW
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0xCD79C0", Offset = "0xCD61C0", VA = "0x180CD79C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x4F30B30", Offset = "0x4F2F330", VA = "0x184F30B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F060", Offset = "0x1A4D860", VA = "0x181A4F060")]
			[DebuggerHidden]
			public WEJZDOJXKUU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x66ADB00", Offset = "0x66AC300", VA = "0x1866ADB00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x3D66D30", Offset = "0x3D65530", VA = "0x183D66D30", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4E48300", Offset = "0x4E46B00", VA = "0x184E48300", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, b)> YUAPZWRVUHH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x66ADA40", Offset = "0x66AC240", VA = "0x1866ADA40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3B87C30", Offset = "0x3B86430", VA = "0x183B87C30")]
		public static bool All<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x843EF40", Offset = "0x843D740", VA = "0x18843EF40")]
		public static bool All(this IEnumerable<bool> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3B97990", Offset = "0x3B96190", VA = "0x183B97990")]
		public static U SIVFVLRKTLV<U, T>(this IEnumerable<T> a, Func<U> b, Func<T, U> c, Func<IEnumerable<T>, U> d) where U : notnull where T : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3B88100", Offset = "0x3B86900", VA = "0x183B88100")]
		public static bool Any<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3B88B50", Offset = "0x3B87350", VA = "0x183B88B50")]
		public static U BXLWMSROBRD<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgAmountSwitchZeroDelegate<TArg, U> b, ArgAmountSwitchOneDelegate<TArg, T, U> c, ArgAmountSwitchManyDelegate<TArg, T, U> d) where U : notnull where T : notnull where TArg : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3B8E720", Offset = "0x3B8CF20", VA = "0x183B8E720")]
		public static IEnumerable<U> CVCFTWOKVZT<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgSelectDelegate<TArg, T, U> b) where U : notnull where T : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3B8ECE0", Offset = "0x3B8D4E0", VA = "0x183B8ECE0")]
		public static IEnumerable<T> DSNABFZAJUH<T>(params IEnumerable<T>[] enumerables) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3B87620", Offset = "0x3B85E20", VA = "0x183B87620")]
		public static bool AZRSXRWPVYN<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3B8FE40", Offset = "0x3B8E640", VA = "0x183B8FE40")]
		public static IEnumerable<(a?, b?)>? HNOSSGEGVJO<a, b>(this IEnumerable<KeyValuePair<a, b>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3B8FCB0", Offset = "0x3B8E4B0", VA = "0x183B8FCB0")]
		public static IEnumerable<T> FMOVHVTHUJI<T, TKey>(this IEnumerable<T> a, Func<T, TKey> b) where T : notnull where TKey : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3661FD0", Offset = "0x36607D0", VA = "0x183661FD0")]
		[IteratorStateMachine(typeof(QSFLDQNBOGV<>))]
		public static IEnumerable<T> RIFESYCIZED<T>(this IEnumerable<T> a, ISet<T> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3B8F570", Offset = "0x3B8DD70", VA = "0x183B8F570")]
		[IteratorStateMachine(typeof(BFAVWIQGEJN<, >))]
		public static IEnumerable<T> FDCENNOTFXB<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T with) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3B96CE0", Offset = "0x3B954E0", VA = "0x183B96CE0")]
		public static T RYZSJUZWABM<T>(this IEnumerable<T> a, T b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B96D40", Offset = "0x3B95540", VA = "0x183B96D40")]
		public static T RYZSJUZWABM<T>(this IEnumerable<T> a, T b, Func<T, bool> c) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B96500", Offset = "0x3B94D00", VA = "0x183B96500")]
		public static c? RWLCBHFWVNR<c>(this IEnumerable<c> self, Func<c, bool> predicate) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3B88770", Offset = "0x3B86F70", VA = "0x183B88770")]
		public static void BSMJTMNZRQX<T>(this IEnumerable<T> a, Action<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3BA7270", Offset = "0x3BA5A70", VA = "0x183BA7270")]
		[IteratorStateMachine(typeof(DSOMBKVBPAO<>))]
		public static IEnumerable<(T, Option<T>)> YZXVTXDLZQM<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3BA7130", Offset = "0x3BA5930", VA = "0x183BA7130")]
		public static bool WCWLEAMUEAN<T>(this IEnumerable<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3B90720", Offset = "0x3B8EF20", VA = "0x183B90720")]
		public static IEnumerable<IndexValuePair<T>> Index<T>(this IEnumerable<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B91320", Offset = "0x3B8FB20", VA = "0x183B91320")]
		public static bool IsEmpty<T>(this IEnumerable<T> self) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B960B0", Offset = "0x3B948B0", VA = "0x183B960B0")]
		public static IEnumerable<T> RSHBPUOJCOE<T>(this IEnumerable<T>? self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3627B80", Offset = "0x3626380", VA = "0x183627B80")]
		[IteratorStateMachine(typeof(APHEWNNUNRB<, >))]
		public static IEnumerable<U> RLZNQJBMDNR<U, T>(this IEnumerable<T> a, Func<SelectAmountPicker<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B8EB60", Offset = "0x3B8D360", VA = "0x183B8EB60")]
		public static IEnumerable<T> XOLLPKCXYZS<T>(this IEnumerable<IEnumerable<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B971B0", Offset = "0x3B959B0", VA = "0x183B971B0")]
		public static int SGXSKDLQFNR<T>(this IEnumerable<T> a, int b = 0) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3B9A800", Offset = "0x3B99000", VA = "0x183B9A800")]
		public static bool UQYBGYHUAZZ<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3B9A220", Offset = "0x3B98A20", VA = "0x183B9A220")]
		public static IEnumerable<T> UCQCTZGPQPV<T>(this IEnumerable<T> a, int b, int c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3B92D90", Offset = "0x3B91590", VA = "0x183B92D90")]
		public static (IEnumerable<T>, IEnumerable<T>) KHNULTZAVRT<T>(this IEnumerable<T> a, Func<T, bool> b) where T : notnull
		{
			return default((IEnumerable<T>, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3B8C6B0", Offset = "0x3B8AEB0", VA = "0x183B8C6B0")]
		public static string CBVYTACUUMY<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D750", Offset = "0x3B8BF50", VA = "0x183B8D750")]
		public static string CBVYTACUUMY<T>(this IEnumerable<T> a, Func<T, string> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3B93050", Offset = "0x3B91850", VA = "0x183B93050")]
		public static Dictionary<d?, e?>? NIWGNJFFGZQ<d, e>(this IEnumerable<KeyValuePair<d, e>> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3B94070", Offset = "0x3B92870", VA = "0x183B94070")]
		public static Dictionary<f?, g?>? NIWGNJFFGZQ<f, g>(this IEnumerable<(f Key, g Value)> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3B8FFC0", Offset = "0x3B8E7C0", VA = "0x183B8FFC0")]
		public static List<T> IECBPWNWCZA<T>(this IEnumerable<T> a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3BA6F50", Offset = "0x3BA5750", VA = "0x183BA6F50")]
		public static string VLACZRVNQOS<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3B95C00", Offset = "0x3B94400", VA = "0x183B95C00")]
		public static (IReadOnlyList<h?>?, IReadOnlyList<i?>?) QQZVWOYQVUH<h, i>(this IEnumerable<(h Lhs, i Rhs)> self)
		{
			return default((IReadOnlyList<h>, IReadOnlyList<i>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x365B8D0", Offset = "0x365A0D0", VA = "0x18365B8D0")]
		[IteratorStateMachine(typeof(WEJZDOJXKUU<, >))]
		public static IEnumerable<(T, U)> RIBXHVBQWIS<T, U>(this IEnumerable<T> a, IEnumerable<U> b) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3B945D0", Offset = "0x3B92DD0", VA = "0x183B945D0")]
		public static IEnumerable<V> NSWDKCARKFE<V, T, U>(this IEnumerable<T> a, IEnumerable<U> b, Func<T, U, V> c, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where V : notnull where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3B94770", Offset = "0x3B92F70", VA = "0x183B94770")]
		public static IEnumerable<(T, U)> NSWDKCARKFE<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3B8F2F0", Offset = "0x3B8DAF0", VA = "0x183B8F2F0")]
		public static TOut[] DXYZTYRBLCX<TOut, TIn>(this IEnumerable<TIn> a, Func<TIn, TOut> b) where TOut : notnull where TIn : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3B91C90", Offset = "0x3B90490", VA = "0x183B91C90")]
		public static Option<U> JMZDNTKSRZN<U, T>(this IEnumerable<T> a, Func<T, U> b) where U : notnull where T : notnull
		{
			return default(Option<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3B95420", Offset = "0x3B93C20", VA = "0x183B95420")]
		public static void QMLMUWDFTLV<T>(this IEnumerable<T> a) where T : notnull, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3B99160", Offset = "0x3B97960", VA = "0x183B99160")]
		public static IEnumerable<KeyValuePair<TKey, List<TItem>>> UAAPKMZSANZ<TKey, TItem>(this IEnumerable<IEnumerable<TItem>> a, Func<TItem, TKey> b) where TKey : notnull where TItem : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class LDPXFIYXWAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x37AB120", Offset = "0x37A9920", VA = "0x1837AB120")]
		public static bool GKMVXAZWMWU<T, U>(this T a, [In] U obj) where T : notnull, IEquatable<T> where U : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x37AB230", Offset = "0x37A9A30", VA = "0x1837AB230")]
		public static bool OEQAWGBRGUR<a>(a a, a b) where a : class, IEquatable<a>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class ZTZOGSNVNFR
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x137C640", Offset = "0x137AE40", VA = "0x18137C640")]
		public static bool OBOCTMQKFQZ([In] this float3 a, float3 a, float b = 1E-05f)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class IQVOYOKKTWH
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KADKMSPTNWR<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private a VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private a IOIMTKAJYNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public a ENDVHLIOETA;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a DVSNWWWDAWC
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xCD79C0", Offset = "0xCD61C0", VA = "0x180CD79C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x50C52B0", Offset = "0x50C3AB0", VA = "0x1850C52B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F060", Offset = "0x1A4D860", VA = "0x181A4F060")]
			[DebuggerHidden]
			public KADKMSPTNWR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x51DD2E0", Offset = "0x51DBAE0", VA = "0x1851DD2E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3D66D30", Offset = "0x3D65530", VA = "0x183D66D30", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x51DD360", Offset = "0x51DBB60", VA = "0x1851DD360", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> RVYKOQAFHBX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x51DD040", Offset = "0x51DB840", VA = "0x1851DD040", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3745E90", Offset = "0x3744690", VA = "0x183745E90")]
		public static void WZDKYDHMLHV<a>(this a a, Action<a> b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3745650", Offset = "0x3743E50", VA = "0x183745650")]
		public static V DTIPBDWJQOM<V, b>(this b a, Func<b, V> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] V defaultValue) where V : notnull where b : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3746020", Offset = "0x3744820", VA = "0x183746020")]
		public static c? YHXKQUIHPLQ<c>(this c a) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x37455C0", Offset = "0x3743DC0", VA = "0x1837455C0")]
		[IteratorStateMachine(typeof(KADKMSPTNWR<>))]
		public static IEnumerable<T> CNABRMVVPTJ<T>(this T a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x37457D0", Offset = "0x3743FD0", VA = "0x1837457D0")]
		public static T[] OUVBGHKRPHU<T>(this T a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class ISDDKDWMGYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly MD5 ENIFKMSTOWJ;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly SHA1 UNGRUGLMNFA;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly byte[] HYULDGGLSZQ;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly byte[] WUDCKRTLSFK;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x843B5E0", Offset = "0x8439DE0", VA = "0x18843B5E0")]
		static ISDDKDWMGYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x843B380", Offset = "0x8439B80", VA = "0x18843B380")]
		public static Guid VESFQEEGKPO([In] Guid a, [In] Guid b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x843B430", Offset = "0x8439C30", VA = "0x18843B430")]
		public static Guid VESFQEEGKPO([In] Guid a, [In] Guid b, [In] Guid c)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3749A30", Offset = "0x3748230", VA = "0x183749A30")]
		public static Guid Create<T>([In] Guid namespaceId, T value, int version = 5) where T : struct
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x843AF20", Offset = "0x8439720", VA = "0x18843AF20")]
		public static Guid Create([In] Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x843AFF0", Offset = "0x84397F0", VA = "0x18843AFF0")]
		private static Guid Create([In] Guid namespaceId, byte[] value, int length, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x374A180", Offset = "0x3748980", VA = "0x18374A180")]
		private static void YGFXUPLYCLH<T>([In] T src, Span<byte> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x374A000", Offset = "0x3748800", VA = "0x18374A000")]
		private static T HKWKFUOQRFF<T>(Span<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x843B520", Offset = "0x8439D20", VA = "0x18843B520")]
		private static void VKWYLKAZQDX(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x843B330", Offset = "0x8439B30", VA = "0x18843B330")]
		private static void QOIKHSXIAWT(byte[] a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class FUALIJSRHLS
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8439640", Offset = "0x8437E40", VA = "0x188439640")]
		public static int LKJKDDVBWZQ(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84396B0", Offset = "0x8437EB0", VA = "0x1884396B0")]
		public static int LPVQCVZXHXA(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8439700", Offset = "0x8437F00", VA = "0x188439700")]
		public static int VJJNYVCXNGA(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8439630", Offset = "0x8437E30", VA = "0x188439630")]
		public static int LGNLFJTUYRR(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72287D0", Offset = "0x7226FD0", VA = "0x1872287D0")]
		public static int IFIDFOWBFOR(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x730F300", Offset = "0x730DB00", VA = "0x18730F300")]
		public static int NBXCQWNBEPM(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8439570", Offset = "0x8437D70", VA = "0x188439570")]
		public static float APZZNRSXWDC(this int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84395C0", Offset = "0x8437DC0", VA = "0x1884395C0")]
		public static (byte, byte, byte, byte) JAOEEWRBMOZ(this int a)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84395A0", Offset = "0x8437DA0", VA = "0x1884395A0")]
		public static int HTRKRAQJOFF([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x84396F0", Offset = "0x8437EF0", VA = "0x1884396F0")]
		public static int ONVFJZNOQJF(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8439590", Offset = "0x8437D90", VA = "0x188439590")]
		public static int BDSJHKJMIGE(this int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class TQVYLMWOFRH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x843DEE0", Offset = "0x843C6E0", VA = "0x18843DEE0")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) JAOEEWRBMOZ(this long a)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x843E070", Offset = "0x843C870", VA = "0x18843E070")]
		public static long MUJTIJVHUOM([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x843DFA0", Offset = "0x843C7A0", VA = "0x18843DFA0")]
		public static string KTBOKWWVOXV(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x843E000", Offset = "0x843C800", VA = "0x18843E000")]
		public static string LWFGSKSFQPE(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x843E0C0", Offset = "0x843C8C0", VA = "0x18843E0C0")]
		public static string OKOLIOHGFQJ(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x843DDC0", Offset = "0x843C5C0", VA = "0x18843DDC0")]
		public static string DPYPIMHBTGF(this long a, long b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface JJFMTQBJMKV
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Next(int minValue, int maxValue);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float WOOBQYHKSBY(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface UQXVOVXAOUL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		long RZOQWLXSWSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class IPXKBBNEFDU
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x37434E0", Offset = "0x3741CE0", VA = "0x1837434E0")]
		public static (a?, b?) DOTRPZWPJMB<a, b>([In] this KeyValuePair<a, b> self)
		{
			return default((a, b));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3743930", Offset = "0x3742130", VA = "0x183743930")]
		public static KeyValuePair<c?, e?> VOZOCWVHZHO<c, e, d>(this KeyValuePair<c, d> self, e value)
		{
			return default(KeyValuePair<c, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class YLQFAEKLOTQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class JEOOHZUAKAG<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IList<a> CPVKPMTVBZI;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JEOOHZUAKAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x50C9420", Offset = "0x50C7C20", VA = "0x1850C9420")]
			internal a BFKINGTCPEW(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E570", Offset = "0x3C2CD70", VA = "0x183C2E570")]
		public static int HFATCVZAUKA<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3C32160", Offset = "0x3C30960", VA = "0x183C32160")]
		public static int PDORMDBEARK<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C31C40", Offset = "0x3C30440", VA = "0x183C31C40")]
		public static bool MKKNMDCODJZ<a>(this IList<a> self, a? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A4D0", Offset = "0x3C38CD0", VA = "0x183C3A4D0")]
		public static void YQAIAKMJVMX<T>(this HashSet<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C312F0", Offset = "0x3C2FAF0", VA = "0x183C312F0")]
		public static void LNAVOBESQCI<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C31370", Offset = "0x3C2FB70", VA = "0x183C31370")]
		public static void LNAVOBESQCI<T>(this IList<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DE50", Offset = "0x3C2C650", VA = "0x183C2DE50")]
		public static void DFATHUFXSCU<T>(this List<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C2B330", Offset = "0x3C29B30", VA = "0x183C2B330")]
		public static bool APIQJGBNYSN<T>(this IList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<T>? removedElements) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BC80", Offset = "0x3C2A480", VA = "0x183C2BC80")]
		public static List<b> APIQJGBNYSN<b>(this List<b> a, Predicate<b> b) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C2EA50", Offset = "0x3C2D250", VA = "0x183C2EA50")]
		public static int HFATCVZAUKA<T>(this IReadOnlyList<T> a, Predicate<T> b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C37830", Offset = "0x3C36030", VA = "0x183C37830")]
		public static bool WKTUQNDYNRX<T>(this IReadOnlyList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<int>? indices) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C7B0", Offset = "0x3C2AFB0", VA = "0x183C2C7B0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C9A0", Offset = "0x3C2B1A0", VA = "0x183C2C9A0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C39E20", Offset = "0x3C38620", VA = "0x183C39E20")]
		public static int YCKKGBDPDTU<TElement>(this IList<TElement> a, TElement b, [Optional] Func<TElement, TElement, int>? compare, int c = 0, [Optional] int? d) where TElement : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C39520", Offset = "0x3C37D20", VA = "0x183C39520")]
		public static int YCKKGBDPDTU<TElement, TKey>(this IList<TElement> a, TKey b, Func<TElement, TKey> c, [Optional] Func<TKey, TKey, int>? compare, int d = 0, [Optional] int? e) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C38F60", Offset = "0x3C37760", VA = "0x183C38F60")]
		public static int YCKKGBDPDTU<TElement, TKey>(Func<int, TElement> a, int b, TKey c, Func<TElement, TKey> d, [Optional] Func<TKey, TKey, int>? compare, int e = 0, [Optional] int? f) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C3BFA0", Offset = "0x3C3A7A0", VA = "0x183C3BFA0")]
		public static int ZLOSWOHDIBN<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3C32650", Offset = "0x3C30E50", VA = "0x183C32650")]
		public static int QJERZONGXUX<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C38130", Offset = "0x3C36930", VA = "0x183C38130")]
		public static bool XPMLHDXOFVT<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3C36330", Offset = "0x3C34B30", VA = "0x183C36330")]
		public static void TZIQITIKQYI<T>(this List<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C359A0", Offset = "0x3C341A0", VA = "0x183C359A0")]
		public static void Remove<T>(this List<T> list, IEnumerable<T> collection) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3C32330", Offset = "0x3C30B30", VA = "0x183C32330")]
		public static c PQNWWZJOANM<c>(this List<c> a, Predicate<c> b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E4F0", Offset = "0x3C2CCF0", VA = "0x183C2E4F0")]
		public static d GUJBLESMQKV<d>(this List<d> a, int b) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3C35EC0", Offset = "0x3C346C0", VA = "0x183C35EC0")]
		public static void SXGBXAVSMXM<T>(this List<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C110", Offset = "0x3C3A910", VA = "0x183C3C110")]
		public static bool ZYAQNDFQGOX<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3C31D80", Offset = "0x3C30580", VA = "0x183C31D80")]
		public static bool MTVBYGXBFYN<T>(this List<T> a, List<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A0F0", Offset = "0x3C388F0", VA = "0x183C3A0F0")]
		public static e YPEKXHWNCKI<e>(this IList<e> a) where e : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BF10", Offset = "0x3C2A710", VA = "0x183C2BF10")]
		public static bool CKCVDLFHFIE<T>(IReadOnlyList<T>? list, int a, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3C37280", Offset = "0x3C35A80", VA = "0x183C37280")]
		public static bool URZAQIZYLSO<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3C327F0", Offset = "0x3C30FF0", VA = "0x183C327F0")]
		public static void ROEOEZMBUIL<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3C377C0", Offset = "0x3C35FC0", VA = "0x183C377C0")]
		public static bool VKPNFQGOCWI<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C305B0", Offset = "0x3C2EDB0", VA = "0x183C305B0")]
		public static string KQZYGBDASXJ<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3C302C0", Offset = "0x3C2EAC0", VA = "0x183C302C0")]
		public static T HOYPROFTMVF<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DC00", Offset = "0x3C2C400", VA = "0x183C2DC00")]
		public static T DEJDSNJZRWD<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3C31A70", Offset = "0x3C30270", VA = "0x183C31A70")]
		public static void MBQVUNNITWP<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C3BC10", Offset = "0x3C3A410", VA = "0x183C3BC10")]
		public static void YVMPMZPGTKN<T>(this IList<T> a, [In] T value) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3C303B0", Offset = "0x3C2EBB0", VA = "0x183C303B0")]
		public static T KCDNSPFOOYA<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class MWZARDLIWOY
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static float RVNTQGTWBTU;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static float CSLSBODNCCB;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static bool VXNABDSPABL;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly float HWZQUILAYXF;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x843C030", Offset = "0x843A830", VA = "0x18843C030")]
		public static bool TVVAKNADDLC(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x843BB60", Offset = "0x843A360", VA = "0x18843BB60")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x843BB40", Offset = "0x843A340", VA = "0x18843BB40")]
		public static int Clamp(int value, int min, int max)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x843C010", Offset = "0x843A810", VA = "0x18843C010")]
		public static float NYWFATHBVYR(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x843BE60", Offset = "0x843A660", VA = "0x18843BE60")]
		public static float Lerp(float a, float b, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x843BB80", Offset = "0x843A380", VA = "0x18843BB80")]
		public static float DFCTNQBNQPD(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x843C1D0", Offset = "0x843A9D0", VA = "0x18843C1D0")]
		public static float WHWLMNPRFOY(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x843BB00", Offset = "0x843A300", VA = "0x18843BB00")]
		public static float ANUXHFDKYDV(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x843C120", Offset = "0x843A920", VA = "0x18843C120")]
		public static float WHWLMNPRFOY(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x843BAD0", Offset = "0x843A2D0", VA = "0x18843BAD0")]
		public static float ANUXHFDKYDV(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x843BFF0", Offset = "0x843A7F0", VA = "0x18843BFF0")]
		public static float Max(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x843BCA0", Offset = "0x843A4A0", VA = "0x18843BCA0")]
		public static float GHIWOEHIATZ(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x843BC10", Offset = "0x843A410", VA = "0x18843BC10")]
		public static float FLUSDJOIDMU(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x843BF00", Offset = "0x843A700", VA = "0x18843BF00")]
		public static float MVGHCFEIATB(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x843BB90", Offset = "0x843A390", VA = "0x18843BB90")]
		public static float ETLHYEQWOTF(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3F08980", Offset = "0x3F07180", VA = "0x183F08980")]
		public static int IHYDRQBLIKY(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class CGNYHZMWLJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private System.Random UROSNVWLWUE;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x84391D0", Offset = "0x84379D0", VA = "0x1884391D0")]
		public CGNYHZMWLJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8439150", Offset = "0x8437950", VA = "0x188439150")]
		public CGNYHZMWLJH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x795A090", Offset = "0x7958890", VA = "0x18795A090", Slot = "4")]
		public virtual int Next()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x84390F0", Offset = "0x84378F0", VA = "0x1884390F0", Slot = "5")]
		public virtual int Next(int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8438FA0", Offset = "0x84377A0", VA = "0x188438FA0", Slot = "6")]
		public virtual int Next(int minValue, int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8439120", Offset = "0x8437920", VA = "0x188439120")]
		public double SLTNKDEPOHJ()
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class QDLUINBJUKX
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x396CC40", Offset = "0x396B440", VA = "0x18396CC40")]
		[Todo("This should be replaced with the `is not` operator in C# 9.")]
		public static bool PZOOIVJIJBS<T>(this object a, [Out][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class SCCNWUZVRVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x843CC80", Offset = "0x843B480", VA = "0x18843CC80")]
		public static (float3, float3, float3) COOKUKABPFF([In] this quaternion self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x843D050", Offset = "0x843B850", VA = "0x18843D050")]
		private static float3 PMCXCIYYULB(quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x843DB10", Offset = "0x843C310", VA = "0x18843DB10")]
		private static float3 VMKRALSJJAY(float3 a, math.RotationOrder b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x843CB40", Offset = "0x843B340", VA = "0x18843CB40")]
		public static float3 BFHACBMKOLJ(this quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x843D9D0", Offset = "0x843C1D0", VA = "0x18843D9D0")]
		public static float UNWHTKNGZUG(this quaternion a, quaternion b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x843CD70", Offset = "0x843B570", VA = "0x18843CD70")]
		public static quaternion GSWMCXLIKCR(this quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x843CBF0", Offset = "0x843B3F0", VA = "0x18843CBF0")]
		[CompilerGenerated]
		internal static float3 BURSNQJDMML(float3 a)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class MBTSFMSPWMP
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class BEOHTBYQPOV : JJFMTQBJMKV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly System.Random ZGPOQLJVBFV;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8438FA0", Offset = "0x84377A0", VA = "0x188438FA0", Slot = "4")]
			public int Next(int minInclusive, int maxExclusive)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8439010", Offset = "0x8437810", VA = "0x188439010", Slot = "5")]
			public float WOOBQYHKSBY(float a, float b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8438FD0", Offset = "0x84377D0", VA = "0x188438FD0")]
			private double TELUCBFNRSP()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8439080", Offset = "0x8437880", VA = "0x188439080")]
			public BEOHTBYQPOV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly JJFMTQBJMKV HEGLPUYKBYY;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x843B6F0", Offset = "0x8439EF0", VA = "0x18843B6F0")]
		public static ulong OLANVNUWPMF()
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class IBFXTQXXMXW
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x36FD270", Offset = "0x36FBA70", VA = "0x1836FD270")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class ITPFCFPZGPQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x374E250", Offset = "0x374CA50", VA = "0x18374E250")]
		public static bool NBAMVWRIKLD<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> a, IReadOnlyDictionary<TKey, TValue> b) where TKey : notnull where TValue : notnull, IEquatable<TValue>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class QRQODARBXRR
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3977020", Offset = "0x3975820", VA = "0x183977020")]
		public static a? OPTXCMQOAPE<a, TKey>(this IReadOnlyDictionary<TKey, a> self, TKey key) where a : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class QHVMMCOXMUM
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
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
				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x48572E0", Offset = "0x4855AE0", VA = "0x1848572E0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly object? BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x4856C20", Offset = "0x4855420", VA = "0x184856C20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xB22B30", Offset = "0xB21330", VA = "0x180B22B30")]
			private Enumerator(IReadOnlyList<T> list, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x41090D0", Offset = "0x41078D0", VA = "0x1841090D0")]
			public static Enumerator<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			public readonly void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4856160", Offset = "0x4854960", VA = "0x184856160", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x28DB880", Offset = "0x28DA080", VA = "0x1828DB880", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public readonly struct Enumerable<T> : IEnumerable<T>, IEnumerable where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private readonly Enumerator<T> _enumerator;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x102F760", Offset = "0x102DF60", VA = "0x18102F760")]
			private Enumerable(Enumerator<T> enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x47A33E0", Offset = "0x47A1BE0", VA = "0x1847A33E0")]
			public static Enumerable<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerable<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x102F730", Offset = "0x102DF30", VA = "0x18102F730")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x47A3220", Offset = "0x47A1A20", VA = "0x1847A3220", Slot = "4")]
			private IEnumerator<T> RVYKOQAFHBX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x47A3220", Offset = "0x47A1A20", VA = "0x1847A3220", Slot = "5")]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x843C680", Offset = "0x843AE80", VA = "0x18843C680")]
		public static void Invoke(this IReadOnlyList<Action> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x396EE60", Offset = "0x396D660", VA = "0x18396EE60")]
		public static bool LHRMMYTLGSF<T>(this IReadOnlyList<T> a, int b, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x396EA90", Offset = "0x396D290", VA = "0x18396EA90")]
		public static bool AXHCRFEUYPI<T>(this IReadOnlyList<T> a, int b, [Out] IndexValuePair<T> result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x396F0B0", Offset = "0x396D8B0", VA = "0x18396F0B0")]
		public static T MGXUGTQNJKH<T>(this IReadOnlyList<T> a, int b, [In] T optB) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x396EC80", Offset = "0x396D480", VA = "0x18396EC80")]
		[CS9ImprovedNullableConstraints("This should return `T?` in C# 9. `default! isn't necessary.")]
		public static T BIQFMMTKGHS<T>(this IReadOnlyList<T> a, int b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x396F420", Offset = "0x396DC20", VA = "0x18396F420")]
		public static a? OPTXCMQOAPE<a>(this IReadOnlyList<a> self, int a) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x396E850", Offset = "0x396D050", VA = "0x18396E850")]
		public static Enumerable<T> AAISIYHRIBP<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(Enumerable<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class TRFOYQCAZBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3A7EDC0", Offset = "0x3A7D5C0", VA = "0x183A7EDC0")]
		public static int CVXJLXXYBRW<a>([In] this ReadOnlySequence<a> sequence, [In] a value) where a : IEquatable<a>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3A7F280", Offset = "0x3A7DA80", VA = "0x183A7F280")]
		public static bool ZKBBYIRGFFI<c>([In] this ReadOnlySequence<c> sequence, [In] ReadOnlySpan<c> other) where c : IEquatable<c>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class YHOWMORTTXK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3C29220", Offset = "0x3C27A20", VA = "0x183C29220")]
		public static string CBVYTACUUMY<T>([In] this ReadOnlySpan<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3C29EB0", Offset = "0x3C286B0", VA = "0x183C29EB0")]
		public static string VLACZRVNQOS<T>([In] this ReadOnlySpan<T> self, string a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct ReadOnlyStopwatch : UQXVOVXAOUL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly UQXVOVXAOUL _baseStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly long _baseTicks;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long RZOQWLXSWSN
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x843CA80", Offset = "0x843B280", VA = "0x18843CA80", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double HMERDOXSDCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x843C9C0", Offset = "0x843B1C0", VA = "0x18843C9C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double XJYXXHWRXVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x843C900", Offset = "0x843B100", VA = "0x18843C900")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1B80A90", Offset = "0x1B7F290", VA = "0x181B80A90")]
		public ReadOnlyStopwatch(UQXVOVXAOUL baseStopwatch, long baseTicks)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class HGDKORTUHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static UQXVOVXAOUL ARZGWZMZJTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x843A0D0", Offset = "0x84388D0", VA = "0x18843A0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8439EA0", Offset = "0x84386A0", VA = "0x188439EA0")]
		public static long CPKUUXXIFPJ(this UQXVOVXAOUL a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8439FC0", Offset = "0x84387C0", VA = "0x188439FC0")]
		public static double GLKSFMFTXUR(this UQXVOVXAOUL a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8439F30", Offset = "0x8438730", VA = "0x188439F30")]
		public static double DOWSSCNJZAO(this UQXVOVXAOUL a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x843A050", Offset = "0x8438850", VA = "0x18843A050")]
		public static ReadOnlyStopwatch VEIJKICRZDY(this UQXVOVXAOUL a)
		{
			return default(ReadOnlyStopwatch);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class YHSDWHVMPET : UQXVOVXAOUL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Stopwatch ADFUYHLJSAH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public long RZOQWLXSWSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x843F0F0", Offset = "0x843D8F0", VA = "0x18843F0F0", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		private YHSDWHVMPET(Stopwatch a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x843F110", Offset = "0x843D910", VA = "0x18843F110")]
		public static YHSDWHVMPET WRDDYCVBDRY(Stopwatch a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x843F050", Offset = "0x843D850", VA = "0x18843F050")]
		public static YHSDWHVMPET ENIIPAAZODH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class NNLECIZJCGY
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8320E30", Offset = "0x831F630", VA = "0x188320E30")]
		public static float3 up([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8320D00", Offset = "0x831F500", VA = "0x188320D00")]
		public static float3 IGFKBTUUSYY([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x11197C0", Offset = "0x1117FC0", VA = "0x1811197C0")]
		public static (float3, float3, float3) NRLPIHZLMIJ([In] this RigidTransform self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x843C350", Offset = "0x843AB50", VA = "0x18843C350")]
		public static RigidTransform VDXJKFIVAQV([In] this RigidTransform self)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class IJGKICSZNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x843AE60", Offset = "0x8439660", VA = "0x18843AE60")]
		public static RigidTransform JSOPCSQFDOT(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class MVBYWLDCXGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x843BA90", Offset = "0x843A290", VA = "0x18843BA90")]
		public static float VTCPUJHHPQI([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x843BA80", Offset = "0x843A280", VA = "0x18843BA80")]
		public static int MSANIOBFGLZ(this float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x843BA10", Offset = "0x843A210", VA = "0x18843BA10")]
		public static (byte, byte, byte, byte) JAOEEWRBMOZ(this float a)
		{
			return default((byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class ZUKJZJVQXSC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3C48680", Offset = "0x3C46E80", VA = "0x183C48680")]
		public static ReadOnlySpan<a?> TFCWJMMGGAJ<a>([In] this Span<a> self)
		{
			return default(ReadOnlySpan<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class YWLNAYCANKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x843F170", Offset = "0x843D970", VA = "0x18843F170")]
		public static StringBuilder AYEDPWLEXVL(this StringBuilder a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x843F230", Offset = "0x843DA30", VA = "0x18843F230")]
		public static StringBuilder QWZKJPBBQJM(this StringBuilder a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x843F1D0", Offset = "0x843D9D0", VA = "0x18843F1D0")]
		public static StringBuilder OREQEMHXWSP(this StringBuilder a, char b, int c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class TSALLJWVKZT
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly Regex OGDYEESCBKN;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static Regex MKRDZFASXSD;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static Regex QLVEHBBKATE;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly char[] IUHHKDZMAXL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly string[] FJOGKZZCVTS;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x75CD5B0", Offset = "0x75CBDB0", VA = "0x1875CD5B0")]
		public static bool VKPNFQGOCWI(this string? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x843EA10", Offset = "0x843D210", VA = "0x18843EA10")]
		public static string? SJWUDIRSKUZ(this string? a, int b, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x843EAD0", Offset = "0x843D2D0", VA = "0x18843EAD0")]
		public static string WDZKLOKCRBP(this string a, int b, string c = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x843EB60", Offset = "0x843D360", VA = "0x18843EB60")]
		public static int WVVKEKFWDRR(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x843E510", Offset = "0x843CD10", VA = "0x18843E510")]
		public static string OWBSQHAJMPM(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x843E360", Offset = "0x843CB60", VA = "0x18843E360")]
		public static string MCFXTMIEYIC(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x843E410", Offset = "0x843CC10", VA = "0x18843E410")]
		public static string[] NECDHGCNWIY(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x843E130", Offset = "0x843C930", VA = "0x18843E130")]
		private static bool DUIBKSBFVOB(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x843E200", Offset = "0x843CA00", VA = "0x18843E200")]
		private static bool GSUSSZRZIEA(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x843E690", Offset = "0x843CE90", VA = "0x18843E690")]
		public static int QMFCYEOXLJZ(string a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class ELYJOKMBZAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8439540", Offset = "0x8437D40", VA = "0x188439540")]
		public static bool LNASNXICJRB(this Type a, Type b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x35CF090", Offset = "0x35CD890", VA = "0x1835CF090")]
		public static bool LNASNXICJRB<T>(this Type a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class EBTZQBWJZXD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x72287D0", Offset = "0x7226FD0", VA = "0x1872287D0")]
		public static uint IFIDFOWBFOR(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x730F300", Offset = "0x730DB00", VA = "0x18730F300")]
		public static uint NBXCQWNBEPM(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8439530", Offset = "0x8437D30", VA = "0x188439530")]
		public static uint DQGEMRHVVGW(this uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8303AC0", Offset = "0x83022C0", VA = "0x188303AC0")]
		public static int MSANIOBFGLZ(this uint a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.NumberStrings
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class DVUTHJIVSWQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8439420", Offset = "0x8437C20", VA = "0x188439420")]
		public static string ZHKKFTLIOHP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8439250", Offset = "0x8437A50", VA = "0x188439250")]
		public static string LRCMAMDWJYO(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8439360", Offset = "0x8437B60", VA = "0x188439360")]
		private static string XZKFZMXDDVL(double a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class NEXWRPVBSFS
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x38A3F20", Offset = "0x38A2720", VA = "0x1838A3F20")]
		public static a HYBLFDZPJSJ<a>(IEnumerable<string> flagStrings, [Optional] a a) where a : struct, Enum, IConvertible
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x38A4D50", Offset = "0x38A3550", VA = "0x1838A4D50")]
		public static b YQGSKTOWROS<b>(IEnumerable<string> flagStrings, [Optional] b a) where b : struct, Enum, IConvertible
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x38A44C0", Offset = "0x38A2CC0", VA = "0x1838A44C0")]
		public static c KZJTZXMPCXV<c>(IEnumerable<string> flagStrings, [Optional] c a) where c : struct, Enum, IConvertible
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3891E70", Offset = "0x3890670", VA = "0x183891E70")]
		private static bool LEWAKMBZSYS(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class IUZIIBVUBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x374E5B0", Offset = "0x374CDB0", VA = "0x18374E5B0")]
		public static bool YAJRQVDACVN<a>([In] this a? self, [Out] a a) where a : struct
		{
			return default(bool);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime.Stats
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class ZOLWDPQWFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x843F2A0", Offset = "0x843DAA0", VA = "0x18843F2A0")]
		public static StatsResults BUKGWYJUBAI(IReadOnlyList<float> a, int b = -1, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x843F500", Offset = "0x843DD00", VA = "0x18843F500")]
		private static StatsResults IPYTUMYCSKJ(IReadOnlyList<float> a, int b, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x843F3B0", Offset = "0x843DBB0", VA = "0x18843F3B0")]
		private static float HINBHMXKVQU(IReadOnlyList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x843FB40", Offset = "0x843E340", VA = "0x18843FB40")]
		public static float ODDNPYNQCHV(IReadOnlyList<float> a, int b, int c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
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

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x843C650", Offset = "0x843AE50", VA = "0x18843C650")]
		public PercentileResults(float p25, float p50, float p75, float p90, float p95, float p99)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
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
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public readonly struct StatsResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class HTMPUICHBZG : IEnumerable<(StatResultFlags, float)>, IEnumerable, IEnumerator<(StatResultFlags, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private (StatResultFlags flag, float result) VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private StatResultFlags KFCEXCIBGDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public StatResultFlags AKXOFKAFKJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public StatsResults BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public StatsResults LUHQKPWTGKA;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private (StatResultFlags, float) BJBLINFFEZM
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x115C900", Offset = "0x115B100", VA = "0x18115C900", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((StatResultFlags, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x843AE10", Offset = "0x8439610", VA = "0x18843AE10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4E43AC0", Offset = "0x4E422C0", VA = "0x184E43AC0")]
			[DebuggerHidden]
			public HTMPUICHBZG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x843A7D0", Offset = "0x8438FD0", VA = "0x18843A7D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x843A790", Offset = "0x8438F90", VA = "0x18843A790", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x843A6C0", Offset = "0x8438EC0", VA = "0x18843A6C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(StatResultFlags, float)> AXDLHIAXEIF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x843A6C0", Offset = "0x8438EC0", VA = "0x18843A6C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
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
		public float XTFOPYHPFEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x843DC80", Offset = "0x843C480", VA = "0x18843DC80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MEYUQGOFOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x843DCA0", Offset = "0x843C4A0", VA = "0x18843DCA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x843DCC0", Offset = "0x843C4C0", VA = "0x18843DCC0")]
		public StatsResults(int n, int hitchN, float hitchThreshold, float hitchThresholdOffset, float min, float max, float mean, float median, float varianceSum, float lowerQuartile, float upperQuartile, PercentileResults percentileResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x843DBE0", Offset = "0x843C3E0", VA = "0x18843DBE0")]
		[IteratorStateMachine(typeof(HTMPUICHBZG))]
		public IEnumerable<(StatResultFlags, float)> BJCJDYJXCCJ(StatResultFlags a)
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
