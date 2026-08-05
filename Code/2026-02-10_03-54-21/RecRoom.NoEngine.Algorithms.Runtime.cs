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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x856E430", Offset = "0x856D630", VA = "0x18856E430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class WOIQDOUDUNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly string[] GTTWZSDCTOB;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8570280", Offset = "0x856F480", VA = "0x188570280")]
		public static bool WAEJXAHPFWP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85701B0", Offset = "0x856F3B0", VA = "0x1885701B0")]
		private static bool MGXSOCBWIQJ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8570060", Offset = "0x856F260", VA = "0x188570060")]
		public static bool MGXSOCBWIQJ(Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8570350", Offset = "0x856F550", VA = "0x188570350")]
		public static string YUFNOHTESCY(string a, string b = "", bool c = true)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KFUHRTYDRHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x856D400", Offset = "0x856C600", VA = "0x18856D400")]
		public static string XPQYMKSYXFS(this Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x856D360", Offset = "0x856C560", VA = "0x18856D360")]
		public static string XPQYMKSYXFS(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x856D290", Offset = "0x856C490", VA = "0x18856D290")]
		public static byte[] TNHCIWLXZIB(string a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PIFTZGECFLW
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate int CompareDelegate<T>([In] T lhs, [In] T rhs);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate U BreakDelegate<T, U>(int numberOfParts, int partIndex, [In] ReadOnlySpan<T> part);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x395BF30", Offset = "0x395B130", VA = "0x18395BF30")]
		public static ReadOnlyMemory<T> WIRGOAJOSKR<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyMemory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3958B50", Offset = "0x3957D50", VA = "0x183958B50")]
		public static ReadOnlySpan<T> CZLFOFDRATM<T>(this T[] a, int b) where T : notnull
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x395A050", Offset = "0x3959250", VA = "0x18395A050")]
		public static T[] JMAPYKFXPKY<T>(int a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x395B210", Offset = "0x395A410", VA = "0x18395B210")]
		public static void PMXIKYWHWMN<T>(this T[] a, T b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x395B4C0", Offset = "0x395A6C0", VA = "0x18395B4C0")]
		public static T[] Remove<T>(this T[] originalArray, int index) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x395C2A0", Offset = "0x395B4A0", VA = "0x18395C2A0")]
		public static void XVULSISGOTT<T>(this T[] a, int b, int c) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3957E00", Offset = "0x3957000", VA = "0x183957E00")]
		public static void ALXVSUGGUSY<T>(this T[] a, CompareDelegate<T> b, [Optional] T[]? preallocatedWorkBuffer) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x395B690", Offset = "0x395A890", VA = "0x18395B690")]
		private static void TIRLUALYWUK<T>(this T[] a, int b, int c, T[] d, bool e, CompareDelegate<T> f) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x395A120", Offset = "0x3959320", VA = "0x18395A120")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x39596B0", Offset = "0x39588B0", VA = "0x1839596B0")]
		public static void IRJHBIBDMBT<T>(this T[] a, int b, int c, CompareDelegate<T> d) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x395B5D0", Offset = "0x395A7D0", VA = "0x18395B5D0")]
		public static T[] Sort<T>(this T[] array) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x395A7F0", Offset = "0x39599F0", VA = "0x18395A7F0")]
		public static T[] NAAFKPNHCWV<T>(this T[] a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3958C20", Offset = "0x3957E20", VA = "0x183958C20")]
		public static T[] DZESNJNPNDJ<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x395BF90", Offset = "0x395B190", VA = "0x18395BF90")]
		public static T[] WSGZYVKUFWL<T>(this T[] a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x39585B0", Offset = "0x39577B0", VA = "0x1839585B0")]
		public static T[] CSEEVNLJHGD<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3958040", Offset = "0x3957240", VA = "0x183958040")]
		public static U[] Break<U, T>(this T[] items, int maxItemsPerPart, BreakDelegate<T, U> xForm) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x856E820", Offset = "0x856DA20", VA = "0x18856E820")]
		public static byte[] PWAYPOFYRBB(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x856E5C0", Offset = "0x856D7C0", VA = "0x18856E5C0")]
		public static byte[] GSDLPVGYJPJ(this byte[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class VZDZEJNKJVV
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x856C1D0", Offset = "0x856B3D0", VA = "0x18856C1D0")]
		public static byte MZUJHAWFJHX(this bool a)
		{
			return default(byte);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class BTDFXAVZQGR
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x856C1D0", Offset = "0x856B3D0", VA = "0x18856C1D0")]
		public static bool GFGUIXXGHHF(this byte a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class QWWJUWGZBDZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39DDF70", Offset = "0x39DD170", VA = "0x1839DDF70")]
		public static void MZZRSCBKLOU<T>(this ICollection<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39DEC80", Offset = "0x39DDE80", VA = "0x1839DEC80")]
		public static void XTLOKYMKKQS<T>(this ICollection<T> a) where T : notnull, IDisposable
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class MGUYNBZOLTJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3845670", Offset = "0x3844870", VA = "0x183845670")]
		public static V AOWGPFLUDDN<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3844BD0", Offset = "0x3843DD0", VA = "0x183844BD0")]
		public static V AOWGPFLUDDN<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3848C80", Offset = "0x3847E80", VA = "0x183848C80")]
		public static void VRLJKPPGUVX<K, V>(this IDictionary<K, List<V>> a, [In] K key, [In] V value) where K : notnull where V : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x38461B0", Offset = "0x38453B0", VA = "0x1838461B0")]
		public static TVal IRPQMINUYLG<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] TVal defaultValue) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3846EC0", Offset = "0x38460C0", VA = "0x183846EC0")]
		public static TVal IRPQMINUYLG<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, Func<TVal> b) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3847080", Offset = "0x3846280", VA = "0x183847080")]
		public static b KOGDEEMVEKC<b, a>(this IDictionary<a, b> a, [In] a key, [Optional][In][CS9ImprovedNullableConstraints("`default!` and null-oblivious region shouldn't be necessary in C# 9")] b defaultValue)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3847F50", Offset = "0x3847150", VA = "0x183847F50")]
		public static V Take<V, K>(this IDictionary<K, V> self, [In] K key) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3847DC0", Offset = "0x3846FC0", VA = "0x183847DC0")]
		public static T2[] MJIDFJYDGKS<T2, T1>(this Dictionary<T1, T2>.ValueCollection a) where T2 : notnull where T1 : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class ONLGUEIOBCN
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
			[Cpp2IlInjected.Address(RVA = "0x5F8BDB0", Offset = "0x5F8AFB0", VA = "0x185F8BDB0")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) One(T one)
			{
				return default((bool, T, IEnumerable<T>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5F8C1A0", Offset = "0x5F8B3A0", VA = "0x185F8C1A0")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) UBFVRZXSZLB(IEnumerable<T> a)
			{
				return default((bool, T, IEnumerable<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class LNHJLOQYVYU<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HashSet<a> MAEAVEMXGKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HashSet<a> TZCHTQEVNOK;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public LNHJLOQYVYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x53B6EA0", Offset = "0x53B60A0", VA = "0x1853B6EA0")]
			internal bool KMIXLNOZNYW(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x53B7030", Offset = "0x53B6230", VA = "0x1853B7030")]
			internal bool KMOEIUIWXKF(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class GUTXOXZJKCQ<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private a HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private ISet<a> JXHRNLYBSQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ISet<a> KNXUHIBXXOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IEnumerable<a> NKOSPNKMPJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IEnumerable<a> WTMGDEAMFSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private IEnumerator<a> XORIMGFAPUY;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private a QKLNCJRFZQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x10C6600", Offset = "0x10C5800", VA = "0x1810C6600", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x4EC2310", Offset = "0x4EC1510", VA = "0x184EC2310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x135A0D0", Offset = "0x13592D0", VA = "0x18135A0D0")]
			[DebuggerHidden]
			public GUTXOXZJKCQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4EC2340", Offset = "0x4EC1540", VA = "0x184EC2340", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4EC24C0", Offset = "0x4EC16C0", VA = "0x184EC24C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x4EC3140", Offset = "0x4EC2340", VA = "0x184EC3140")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CBF0", Offset = "0x3D9BDF0", VA = "0x183D9CBF0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x4E81A20", Offset = "0x4E80C20", VA = "0x184E81A20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> ULRXOZXQGZW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4EC23F0", Offset = "0x4EC15F0", VA = "0x184EC23F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class LDCNDXUFPKK<a, b> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private a HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private IEnumerable<a> OYZBLKLUINM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IEnumerable<a> RZAIPVBJONR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private IEnumerable<b> WZNDGLRLXES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IEnumerable<b> USTDVQCAKJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private a CYRSHPSGGRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public a MXXHXEHZSMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private IEnumerator<a> EEECAIQKTSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IEnumerator<b> SFZTZBRVGAE;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private a QKLNCJRFZQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x474F050", Offset = "0x474E250", VA = "0x18474F050", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x5372C50", Offset = "0x5371E50", VA = "0x185372C50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4F28AE0", Offset = "0x4F27CE0", VA = "0x184F28AE0")]
			[DebuggerHidden]
			public LDCNDXUFPKK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5372FB0", Offset = "0x53721B0", VA = "0x185372FB0", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5373BD0", Offset = "0x5372DD0", VA = "0x185373BD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x53749D0", Offset = "0x5373BD0", VA = "0x1853749D0")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5374830", Offset = "0x5373A30", VA = "0x185374830")]
			private void RJYPYWGNHOQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CBF0", Offset = "0x3D9BDF0", VA = "0x183D9CBF0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5374B70", Offset = "0x5373D70", VA = "0x185374B70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> ULRXOZXQGZW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5373320", Offset = "0x5372520", VA = "0x185373320", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class QWZNQDPWQMT<a> : IEnumerable<(a, Option<a>)>, IEnumerable, IEnumerator<(a, Option<a>)>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private (a Current, Option<a> Next) HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerable<a> OYZBLKLUINM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IEnumerable<a> RZAIPVBJONR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerator<a> DANFDFCVWZH;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private (a, Option<a>) EJALWTRTPQG
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2B853D0", Offset = "0x2B845D0", VA = "0x182B853D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, Option<a>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x5CCC140", Offset = "0x5CCB340", VA = "0x185CCC140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B85D20", Offset = "0x2B84F20", VA = "0x182B85D20")]
			[DebuggerHidden]
			public QWZNQDPWQMT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5CCC3C0", Offset = "0x5CCB5C0", VA = "0x185CCC3C0", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5CCCF10", Offset = "0x5CCC110", VA = "0x185CCCF10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5CCD590", Offset = "0x5CCC790", VA = "0x185CCD590")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CBF0", Offset = "0x3D9BDF0", VA = "0x183D9CBF0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5CCC310", Offset = "0x5CCB510", VA = "0x185CCC310", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, Option<a>)> JPZTOKFOEQB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5CCC470", Offset = "0x5CCB670", VA = "0x185CCC470", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class ROZVEGDZOGW<a, b> : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private b HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<a> OYZBLKLUINM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<a> RZAIPVBJONR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> IXSXAINXNCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> BJTNUXETWPW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<a> XORIMGFAPUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private IEnumerator<b> XPHDEAMSSCZ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private b NHXNEHLEOWC
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public ROZVEGDZOGW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5D04AA0", Offset = "0x5D03CA0", VA = "0x185D04AA0", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5D04D10", Offset = "0x5D03F10", VA = "0x185D04D10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5D051E0", Offset = "0x5D043E0", VA = "0x185D051E0")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5D05190", Offset = "0x5D04390", VA = "0x185D05190")]
			private void RJYPYWGNHOQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CBF0", Offset = "0x3D9BDF0", VA = "0x183D9CBF0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x4E1A390", Offset = "0x4E19590", VA = "0x184E1A390", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> WUKYUZEZPHD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x5D04C40", Offset = "0x5D03E40", VA = "0x185D04C40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WOIZMWEILWT<a, b> : IEnumerable<(a, b)>, IEnumerable, IEnumerator<(a, b)>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private (a Lhs, b Rhs) HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private IEnumerable<a> NWYYAQRKSYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IEnumerable<a> DWDAUAIXYTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IEnumerable<b> WKXROTASVMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IEnumerable<b> QPIGXSCZHMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private IEnumerator<a> JGWXHJNITUX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private IEnumerator<b> FFMYAQFDGVQ;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private (a, b) YIHXOKQZYVV
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0xB2F4C0", Offset = "0xB2E6C0", VA = "0x180B2F4C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x5C83BE0", Offset = "0x5C82DE0", VA = "0x185C83BE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1AA4D30", Offset = "0x1AA3F30", VA = "0x181AA4D30")]
			[DebuggerHidden]
			public WOIZMWEILWT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x67B1C50", Offset = "0x67B0E50", VA = "0x1867B1C50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CBF0", Offset = "0x3D9BDF0", VA = "0x183D9CBF0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4E2A6A0", Offset = "0x4E298A0", VA = "0x184E2A6A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, b)> GJHAFQHRGDO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x67B1B80", Offset = "0x67B0D80", VA = "0x1867B1B80", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39278A0", Offset = "0x3926AA0", VA = "0x1839278A0")]
		public static bool All<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x856E4B0", Offset = "0x856D6B0", VA = "0x18856E4B0")]
		public static bool All(this IEnumerable<bool> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3934640", Offset = "0x3933840", VA = "0x183934640")]
		public static U KTGVVWYZKGA<U, T>(this IEnumerable<T> a, Func<U> b, Func<T, U> c, Func<IEnumerable<T>, U> d) where U : notnull where T : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3927D70", Offset = "0x3926F70", VA = "0x183927D70")]
		public static bool Any<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x392CF40", Offset = "0x392C140", VA = "0x18392CF40")]
		public static U FKSQAEUAMDC<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgAmountSwitchZeroDelegate<TArg, U> b, ArgAmountSwitchOneDelegate<TArg, T, U> c, ArgAmountSwitchManyDelegate<TArg, T, U> d) where U : notnull where T : notnull where TArg : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3936AF0", Offset = "0x3935CF0", VA = "0x183936AF0")]
		public static IEnumerable<U> PYJGMOQJHHG<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgSelectDelegate<TArg, T, U> b) where U : notnull where T : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3934B70", Offset = "0x3933D70", VA = "0x183934B70")]
		public static IEnumerable<T> KYIYTVTUQTO<T>(params IEnumerable<T>[] enumerables) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3930BF0", Offset = "0x392FDF0", VA = "0x183930BF0")]
		public static bool HPZIWYZQICA<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3934140", Offset = "0x3933340", VA = "0x183934140")]
		public static IEnumerable<(a?, b?)>? KRRGRACSUSP<a, b>(this IEnumerable<KeyValuePair<a, b>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x39354D0", Offset = "0x39346D0", VA = "0x1839354D0")]
		public static IEnumerable<T> NFJLLAIFLNT<T, TKey>(this IEnumerable<T> a, Func<T, TKey> b) where T : notnull where TKey : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x36B5CE0", Offset = "0x36B4EE0", VA = "0x1836B5CE0")]
		[IteratorStateMachine(typeof(GUTXOXZJKCQ<>))]
		public static IEnumerable<T> INORVGKDTMA<T>(this IEnumerable<T> a, ISet<T> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x39306D0", Offset = "0x392F8D0", VA = "0x1839306D0")]
		[IteratorStateMachine(typeof(LDCNDXUFPKK<, >))]
		public static IEnumerable<T> GVJMWLEKGEE<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T with) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x392C700", Offset = "0x392B900", VA = "0x18392C700")]
		public static T DAYLFSRTNIT<T>(this IEnumerable<T> a, T b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x392C760", Offset = "0x392B960", VA = "0x18392C760")]
		public static T DAYLFSRTNIT<T>(this IEnumerable<T> a, T b, Func<T, bool> c) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3937160", Offset = "0x3936360", VA = "0x183937160")]
		public static c? URSQSAYKXXQ<c>(this IEnumerable<c> self, Func<c, bool> predicate) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x393B0B0", Offset = "0x393A2B0", VA = "0x18393B0B0")]
		public static void WLCHAAONDXY<T>(this IEnumerable<T> a, Action<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x392CB10", Offset = "0x392BD10", VA = "0x18392CB10")]
		[IteratorStateMachine(typeof(QWZNQDPWQMT<>))]
		public static IEnumerable<(T, Option<T>)> EUSENRAOJTR<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3935EA0", Offset = "0x39350A0", VA = "0x183935EA0")]
		public static bool ONUNHLQBQCE<T>(this IEnumerable<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3932AB0", Offset = "0x3931CB0", VA = "0x183932AB0")]
		public static IEnumerable<IndexValuePair<T>> Index<T>(this IEnumerable<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x39336B0", Offset = "0x39328B0", VA = "0x1839336B0")]
		public static bool IsEmpty<T>(this IEnumerable<T> self) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3934D40", Offset = "0x3933F40", VA = "0x183934D40")]
		public static IEnumerable<T> LFZPEDVCJJL<T>(this IEnumerable<T>? self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3679CB0", Offset = "0x3678EB0", VA = "0x183679CB0")]
		[IteratorStateMachine(typeof(ROZVEGDZOGW<, >))]
		public static IEnumerable<U> IYEIZYLVHDW<U, T>(this IEnumerable<T> a, Func<SelectAmountPicker<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x39349F0", Offset = "0x3933BF0", VA = "0x1839349F0")]
		public static IEnumerable<T> NDUPLYQXOED<T>(this IEnumerable<IEnumerable<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3936350", Offset = "0x3935550", VA = "0x183936350")]
		public static int OZHYJFLWSKO<T>(this IEnumerable<T> a, int b = 0) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3935B60", Offset = "0x3934D60", VA = "0x183935B60")]
		public static bool OHRQKEPXAAU<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x392CA30", Offset = "0x392BC30", VA = "0x18392CA30")]
		public static IEnumerable<T> DKURMTLLOOE<T>(this IEnumerable<T> a, int b, int c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x392AC10", Offset = "0x3929E10", VA = "0x18392AC10")]
		public static (IEnumerable<T>, IEnumerable<T>) BSHVHRVRAKY<T>(this IEnumerable<T> a, Func<T, bool> b) where T : notnull
		{
			return default((IEnumerable<T>, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3938710", Offset = "0x3937910", VA = "0x183938710")]
		public static string VKMNJIWCZKR<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3939930", Offset = "0x3938B30", VA = "0x183939930")]
		public static string VKMNJIWCZKR<T>(this IEnumerable<T> a, Func<T, string> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3929290", Offset = "0x3928490", VA = "0x183929290")]
		public static Dictionary<d?, e?>? BIIQFXFGAAV<d, e>(this IEnumerable<KeyValuePair<d, e>> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x392A2B0", Offset = "0x39294B0", VA = "0x18392A2B0")]
		public static Dictionary<f?, g?>? BIIQFXFGAAV<f, g>(this IEnumerable<(f Key, g Value)> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3930DB0", Offset = "0x392FFB0", VA = "0x183930DB0")]
		public static List<T> ICAHLKMGJXX<T>(this IEnumerable<T> a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3934DE0", Offset = "0x3933FE0", VA = "0x183934DE0")]
		public static string LXVYLIRGEGT<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3933CE0", Offset = "0x3932EE0", VA = "0x183933CE0")]
		public static (IReadOnlyList<h?>?, IReadOnlyList<i?>?) JPFXGYZLGBM<h, i>(this IEnumerable<(h Lhs, i Rhs)> self)
		{
			return default((IReadOnlyList<h>, IReadOnlyList<i>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x36AF580", Offset = "0x36AE780", VA = "0x1836AF580")]
		[IteratorStateMachine(typeof(WOIZMWEILWT<, >))]
		public static IEnumerable<(T, U)> LIMDMXYCYAD<T, U>(this IEnumerable<T> a, IEnumerable<U> b) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3927F20", Offset = "0x3927120", VA = "0x183927F20")]
		public static IEnumerable<V> BCFNWLUETUX<V, T, U>(this IEnumerable<T> a, IEnumerable<U> b, Func<T, U, V> c, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where V : notnull where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3927FD0", Offset = "0x39271D0", VA = "0x183927FD0")]
		public static IEnumerable<(T, U)> BCFNWLUETUX<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x393A970", Offset = "0x3939B70", VA = "0x18393A970")]
		public static TOut[] WAYMBITQTFA<TOut, TIn>(this IEnumerable<TIn> a, Func<TIn, TOut> b) where TOut : notnull where TIn : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3931A90", Offset = "0x3930C90", VA = "0x183931A90")]
		public static Option<U> ICSJMWFFEAM<U, T>(this IEnumerable<T> a, Func<T, U> b) where U : notnull where T : notnull
		{
			return default(Option<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3937950", Offset = "0x3936B50", VA = "0x183937950")]
		public static void UVIZOKGCOHO<T>(this IEnumerable<T> a) where T : notnull, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x392D180", Offset = "0x392C380", VA = "0x18392D180")]
		public static IEnumerable<KeyValuePair<TKey, List<TItem>>> GJHEDEPLWFS<TKey, TItem>(this IEnumerable<IEnumerable<TItem>> a, Func<TItem, TKey> b) where TKey : notnull where TItem : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class PKCXCJCKDYT
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x395D480", Offset = "0x395C680", VA = "0x18395D480")]
		public static bool EGWIJBBZFJH<T, U>(this T a, [In] U obj) where T : notnull, IEquatable<T> where U : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x395D080", Offset = "0x395C280", VA = "0x18395D080")]
		public static bool CGZPCRKGCMM<a>(a a, a b) where a : class, IEquatable<a>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class PZLDKBXDGEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x137A8F0", Offset = "0x1379AF0", VA = "0x18137A8F0")]
		public static bool OGBNKGUTGYU([In] this float3 a, float3 a, float b = 1E-05f)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class CEZAKMZUOVO
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class ONPLHRZRIAQ<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private a HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private a OYZBLKLUINM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public a RZAIPVBJONR;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a QKLNCJRFZQP
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xB2F4C0", Offset = "0xB2E6C0", VA = "0x180B2F4C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0x50D8790", Offset = "0x50D7990", VA = "0x1850D8790", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x1AA4D30", Offset = "0x1AA3F30", VA = "0x181AA4D30")]
			[DebuggerHidden]
			public ONPLHRZRIAQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x5A894E0", Offset = "0x5A886E0", VA = "0x185A894E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CBF0", Offset = "0x3D9BDF0", VA = "0x183D9CBF0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5A895D0", Offset = "0x5A887D0", VA = "0x185A895D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> ULRXOZXQGZW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5A892F0", Offset = "0x5A884F0", VA = "0x185A892F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x34D29B0", Offset = "0x34D1BB0", VA = "0x1834D29B0")]
		public static void ABAOHRFCHBA<a>(this a a, Action<a> b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x34D3780", Offset = "0x34D2980", VA = "0x1834D3780")]
		public static V SCKKVQXKRCB<V, b>(this b a, Func<b, V> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] V defaultValue) where V : notnull where b : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x34D3530", Offset = "0x34D2730", VA = "0x1834D3530")]
		public static c? PAPYGNXKUEB<c>(this c a) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x34D2C10", Offset = "0x34D1E10", VA = "0x1834D2C10")]
		[IteratorStateMachine(typeof(ONPLHRZRIAQ<>))]
		public static IEnumerable<T> FZXMYAJPWIK<T>(this T a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x34D2D30", Offset = "0x34D1F30", VA = "0x1834D2D30")]
		public static T[] IMAJSJCDSWJ<T>(this T a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class BETFLHOSIHO
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly MD5 XNAQSNKUISM;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly SHA1 CUAARIEOXOZ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly byte[] SRAWYCPYUVD;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly byte[] LBVRGGTPKUP;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x856BF40", Offset = "0x856B140", VA = "0x18856BF40")]
		static BETFLHOSIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x856BC90", Offset = "0x856AE90", VA = "0x18856BC90")]
		public static Guid DJDCVGHYHQB([In] Guid a, [In] Guid b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x856BD40", Offset = "0x856AF40", VA = "0x18856BD40")]
		public static Guid DJDCVGHYHQB([In] Guid a, [In] Guid b, [In] Guid c)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3406160", Offset = "0x3405360", VA = "0x183406160")]
		public static Guid Create<T>([In] Guid namespaceId, T value, int version = 5) where T : struct
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x856B880", Offset = "0x856AA80", VA = "0x18856B880")]
		public static Guid Create([In] Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x856B950", Offset = "0x856AB50", VA = "0x18856B950")]
		private static Guid Create([In] Guid namespaceId, byte[] value, int length, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x34068B0", Offset = "0x3405AB0", VA = "0x1834068B0")]
		private static void WFXWAFMCRYG<T>([In] T src, Span<byte> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3406730", Offset = "0x3405930", VA = "0x183406730")]
		private static T PASXWUOYUVO<T>(Span<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x856BE80", Offset = "0x856B080", VA = "0x18856BE80")]
		private static void WEGRZCHBPJS(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x856BE30", Offset = "0x856B030", VA = "0x18856BE30")]
		private static void PXTRCTQNDOC(byte[] a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class UQAGWEKRRTJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x856F650", Offset = "0x856E850", VA = "0x18856F650")]
		public static int FOAXACHOOMJ(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x856F750", Offset = "0x856E950", VA = "0x18856F750")]
		public static int REFEZLRIBAJ(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x856F600", Offset = "0x856E800", VA = "0x18856F600")]
		public static int AJKAYOXAEIV(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x856F730", Offset = "0x856E930", VA = "0x18856F730")]
		public static int ORLFYYUAKQG(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7349340", Offset = "0x7348540", VA = "0x187349340")]
		public static int UZKLUNRYLQG(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7426B80", Offset = "0x7425D80", VA = "0x187426B80")]
		public static int OKUQPPAHVOX(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x856F790", Offset = "0x856E990", VA = "0x18856F790")]
		public static float SERGQMANDKJ(this int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x856F6C0", Offset = "0x856E8C0", VA = "0x18856F6C0")]
		public static (byte, byte, byte, byte) MYIJUPDQLIY(this int a)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x856F7B0", Offset = "0x856E9B0", VA = "0x18856F7B0")]
		public static int SHWKJXQHOGS([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x856F7D0", Offset = "0x856E9D0", VA = "0x18856F7D0")]
		public static int VLVFOHUIWWK(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x856F740", Offset = "0x856E940", VA = "0x18856F740")]
		public static int PZTIWPKYGYJ(this int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class EUOGQUWYOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x856C310", Offset = "0x856B510", VA = "0x18856C310")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) MYIJUPDQLIY(this long a)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x856C5C0", Offset = "0x856B7C0", VA = "0x18856C5C0")]
		public static long QQQVBIXCGTN([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x856C560", Offset = "0x856B760", VA = "0x18856C560")]
		public static string PKRQODZBGCM(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x856C3D0", Offset = "0x856B5D0", VA = "0x18856C3D0")]
		public static string OQDYZEAFMBL(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x856C610", Offset = "0x856B810", VA = "0x18856C610")]
		public static string VJHBJILHDMC(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x856C440", Offset = "0x856B640", VA = "0x18856C440")]
		public static string OSVZUYPWSXO(this long a, long b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface WWBSLJXBMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Next(int minValue, int maxValue);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float OVXZPCLYCZL(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface KVYWVIGHLAM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		long LTYDINJXZAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class KUPENRWTHQT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x380A1C0", Offset = "0x38093C0", VA = "0x18380A1C0")]
		public static (a?, b?) ATYLCJEDGCE<a, b>([In] this KeyValuePair<a, b> self)
		{
			return default((a, b));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x380A610", Offset = "0x3809810", VA = "0x18380A610")]
		public static KeyValuePair<c?, e?> HDULFNDIMWB<c, e, d>(this KeyValuePair<c, d> self, e value)
		{
			return default(KeyValuePair<c, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class DBKBBNOGKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class KHDROQQYNCD<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IList<a> AWMTOEQDOEN;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public KHDROQQYNCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x52060E0", Offset = "0x52052E0", VA = "0x1852060E0")]
			internal a CGYXEQLAEPD(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x35BC3D0", Offset = "0x35BB5D0", VA = "0x1835BC3D0")]
		public static int VHDZBOTOOMV<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x35B83D0", Offset = "0x35B75D0", VA = "0x1835B83D0")]
		public static int LRUQLYYPGUR<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x35BBDA0", Offset = "0x35BAFA0", VA = "0x1835BBDA0")]
		public static bool SWKVSUNSEQU<a>(this IList<a> self, a? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x35B88D0", Offset = "0x35B7AD0", VA = "0x1835B88D0")]
		public static void MZZRSCBKLOU<T>(this HashSet<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x35BE950", Offset = "0x35BDB50", VA = "0x1835BE950")]
		public static void VRFOOTQSELX<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x35BE610", Offset = "0x35BD810", VA = "0x1835BE610")]
		public static void VRFOOTQSELX<T>(this IList<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x35BAE70", Offset = "0x35BA070", VA = "0x1835BAE70")]
		public static void RSFOAYZGZOJ<T>(this List<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x35BA350", Offset = "0x35B9550", VA = "0x1835BA350")]
		public static bool QCRHTHBWUWC<T>(this IList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<T>? removedElements) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x35BACA0", Offset = "0x35B9EA0", VA = "0x1835BACA0")]
		public static List<b> QCRHTHBWUWC<b>(this List<b> a, Predicate<b> b) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x35BC790", Offset = "0x35BB990", VA = "0x1835BC790")]
		public static int VHDZBOTOOMV<T>(this IReadOnlyList<T> a, Predicate<T> b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x35B2740", Offset = "0x35B1940", VA = "0x1835B2740")]
		public static bool AROTZHRBPGM<T>(this IReadOnlyList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<int>? indices) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x35B4AB0", Offset = "0x35B3CB0", VA = "0x1835B4AB0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x35B49C0", Offset = "0x35B3BC0", VA = "0x1835B49C0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x35B2470", Offset = "0x35B1670", VA = "0x1835B2470")]
		public static int AOWJHUCINHL<TElement>(this IList<TElement> a, TElement b, [Optional] Func<TElement, TElement, int>? compare, int c = 0, [Optional] int? d) where TElement : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x35B1B70", Offset = "0x35B0D70", VA = "0x1835B1B70")]
		public static int AOWJHUCINHL<TElement, TKey>(this IList<TElement> a, TKey b, Func<TElement, TKey> c, [Optional] Func<TKey, TKey, int>? compare, int d = 0, [Optional] int? e) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x35B15B0", Offset = "0x35B07B0", VA = "0x1835B15B0")]
		public static int AOWJHUCINHL<TElement, TKey>(Func<int, TElement> a, int b, TKey c, Func<TElement, TKey> d, [Optional] Func<TKey, TKey, int>? compare, int e = 0, [Optional] int? f) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x35BBF80", Offset = "0x35BB180", VA = "0x1835BBF80")]
		public static int TTEOGXTHDPE<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x35BF7E0", Offset = "0x35BE9E0", VA = "0x1835BF7E0")]
		public static int WYIMLPSXSWQ<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x35B7280", Offset = "0x35B6480", VA = "0x1835B7280")]
		public static bool ETYXOQNVQME<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x35BF340", Offset = "0x35BE540", VA = "0x1835BF340")]
		public static void WRHAKFYQJHZ<T>(this List<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x35BB7D0", Offset = "0x35BA9D0", VA = "0x1835BB7D0")]
		public static void Remove<T>(this List<T> list, IEnumerable<T> collection) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x35B7090", Offset = "0x35B6290", VA = "0x1835B7090")]
		public static c EORRLTBOLSH<c>(this List<c> a, Predicate<c> b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x35BADF0", Offset = "0x35B9FF0", VA = "0x1835BADF0")]
		public static d QDGWOCUBZUS<d>(this List<d> a, int b) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x35BC290", Offset = "0x35BB490", VA = "0x1835BC290")]
		public static void UZUXRQHCFDH<T>(this List<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x35B7C20", Offset = "0x35B6E20", VA = "0x1835B7C20")]
		public static bool HMBUWTMZQPC<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x35BFA30", Offset = "0x35BEC30", VA = "0x1835BFA30")]
		public static bool YIRAFJNGFRO<T>(this List<T> a, List<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x35BED80", Offset = "0x35BDF80", VA = "0x1835BED80")]
		public static e VXMKDYHHPQP<e>(this IList<e> a) where e : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x35B7DE0", Offset = "0x35B6FE0", VA = "0x1835B7DE0")]
		public static bool HTSDYXLPMON<T>(IReadOnlyList<T>? list, int a, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x35B3C00", Offset = "0x35B2E00", VA = "0x1835B3C00")]
		public static bool BMHIWPAICVX<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x35B6A10", Offset = "0x35B5C10", VA = "0x1835B6A10")]
		public static void DCKJYWIZYHW<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x35BBB90", Offset = "0x35BAD90", VA = "0x1835BBB90")]
		public static bool SMITEOICKSN<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x35BFB70", Offset = "0x35BED70", VA = "0x1835BFB70")]
		public static string ZSJNUXMAKVO<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x35B7990", Offset = "0x35B6B90", VA = "0x1835B7990")]
		public static T FAXDJXETCOW<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x35B9FB0", Offset = "0x35B91B0", VA = "0x1835B9FB0")]
		public static T NEILAQDSKVS<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x35B7A70", Offset = "0x35B6C70", VA = "0x1835B7A70")]
		public static void FIPYOARMCLW<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x35B7EA0", Offset = "0x35B70A0", VA = "0x1835B7EA0")]
		public static void KCTLGYDBLQA<T>(this IList<T> a, [In] T value) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x35BEE20", Offset = "0x35BE020", VA = "0x1835BEE20")]
		public static T WMXDRNITYDZ<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class VNQKFFLEQMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static float HARDVFEUVND;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static float IECJVLQGOZI;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static bool FLEIJOHTLVE;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly float QFTXCBGNRFA;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x856FEB0", Offset = "0x856F0B0", VA = "0x18856FEB0")]
		public static bool ZTEWGVXVSKB(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x856F890", Offset = "0x856EA90", VA = "0x18856F890")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x856F870", Offset = "0x856EA70", VA = "0x18856F870")]
		public static int Clamp(int value, int min, int max)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x856FA20", Offset = "0x856EC20", VA = "0x18856FA20")]
		public static float EMIYLTFDVOQ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x856FC10", Offset = "0x856EE10", VA = "0x18856FC10")]
		public static float Lerp(float a, float b, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x856FC00", Offset = "0x856EE00", VA = "0x18856FC00")]
		public static float ITVCUERARMU(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x856F960", Offset = "0x856EB60", VA = "0x18856F960")]
		public static float EGAURARCUFX(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x856FE70", Offset = "0x856F070", VA = "0x18856FE70")]
		public static float UVCBOITRIOI(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x856F8B0", Offset = "0x856EAB0", VA = "0x18856F8B0")]
		public static float EGAURARCUFX(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x856FE40", Offset = "0x856F040", VA = "0x18856FE40")]
		public static float UVCBOITRIOI(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x856FCB0", Offset = "0x856EEB0", VA = "0x18856FCB0")]
		public static float Max(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x856FA40", Offset = "0x856EC40", VA = "0x18856FA40")]
		public static float HGWNHCNCMUU(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x856F7E0", Offset = "0x856E9E0", VA = "0x18856F7E0")]
		public static float APOIQKHADDR(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x856FCD0", Offset = "0x856EED0", VA = "0x18856FCD0")]
		public static float PKTFTRIFSKM(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x856FDC0", Offset = "0x856EFC0", VA = "0x18856FDC0")]
		public static float TYWDYMSRGIO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6560", Offset = "0x3DC5760", VA = "0x183DC6560")]
		public static int WLAGDPXKAOT(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class BORGQKVKPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private System.Random GVLRNUTGCOP;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x856C0D0", Offset = "0x856B2D0", VA = "0x18856C0D0")]
		public BORGQKVKPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x856C150", Offset = "0x856B350", VA = "0x18856C150")]
		public BORGQKVKPEO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7A75190", Offset = "0x7A74390", VA = "0x187A75190", Slot = "4")]
		public virtual int Next()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x856C070", Offset = "0x856B270", VA = "0x18856C070", Slot = "5")]
		public virtual int Next(int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x856C040", Offset = "0x856B240", VA = "0x18856C040", Slot = "6")]
		public virtual int Next(int minValue, int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x856C0A0", Offset = "0x856B2A0", VA = "0x18856C0A0")]
		public double VBULVMBOGEI()
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class GAOMJNFKFWG
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3726950", Offset = "0x3725B50", VA = "0x183726950")]
		[Todo("This should be replaced with the `is not` operator in C# 9.")]
		public static bool JQOGPUYVPGV<T>(this object a, [Out][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class AREXTSXXWEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x856B5E0", Offset = "0x856A7E0", VA = "0x18856B5E0")]
		public static (float3, float3, float3) QGRKWOIDSFQ([In] this quaternion self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x856A800", Offset = "0x8569A00", VA = "0x18856A800")]
		private static float3 BTDMLQJOHPQ(quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x856B510", Offset = "0x856A710", VA = "0x18856B510")]
		private static float3 JVXLTNOOBUH(float3 a, math.RotationOrder b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x856B180", Offset = "0x856A380", VA = "0x18856B180")]
		public static float3 FMDREQNVAYO(this quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x856A6C0", Offset = "0x85698C0", VA = "0x18856A6C0")]
		public static float AWNERPJVSBP(this quaternion a, quaternion b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x856B230", Offset = "0x856A430", VA = "0x18856B230")]
		public static quaternion FXCBCXWFGMK(this quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x856B6D0", Offset = "0x856A8D0", VA = "0x18856B6D0")]
		[CompilerGenerated]
		internal static float3 ZVSJHHDJZYU(float3 a)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class TUBCRQFANKW
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class KYNMOVUOTCS : WWBSLJXBMKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly System.Random FHVRSMNJMKK;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x856C040", Offset = "0x856B240", VA = "0x18856C040", Slot = "4")]
			public int Next(int minInclusive, int maxExclusive)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x856D4B0", Offset = "0x856C6B0", VA = "0x18856D4B0", Slot = "5")]
			public float OVXZPCLYCZL(float a, float b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x856D520", Offset = "0x856C720", VA = "0x18856D520")]
			private double UBPEHQFZOZY()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x856D560", Offset = "0x856C760", VA = "0x18856D560")]
			public KYNMOVUOTCS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly WWBSLJXBMKE DGAMSNSLPXZ;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x856F270", Offset = "0x856E470", VA = "0x18856F270")]
		public static ulong GLLBXXVSJWY()
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class AMTVCAWQHQN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x30B7610", Offset = "0x30B6810", VA = "0x1830B7610")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class IVIFXEWNDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x37A6990", Offset = "0x37A5B90", VA = "0x1837A6990")]
		public static bool IWIIDOUCIXM<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> a, IReadOnlyDictionary<TKey, TValue> b) where TKey : notnull where TValue : notnull, IEquatable<TValue>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class XAETSGKMYWS
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3C42700", Offset = "0x3C41900", VA = "0x183C42700")]
		public static a? RWIRUOTGBKF<a, TKey>(this IReadOnlyDictionary<TKey, a> self, TKey key) where a : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class ZCPYEMCPHTL
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
				[Cpp2IlInjected.Address(RVA = "0x47F9530", Offset = "0x47F8730", VA = "0x1847F9530", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly object? CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x47F82F0", Offset = "0x47F74F0", VA = "0x1847F82F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xB4E9A0", Offset = "0xB4DBA0", VA = "0x180B4E9A0")]
			private Enumerator(IReadOnlyList<T> list, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x40724F0", Offset = "0x40716F0", VA = "0x1840724F0")]
			public static Enumerator<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			public readonly void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x47F8700", Offset = "0x47F7900", VA = "0x1847F8700", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x28FF7C0", Offset = "0x28FE9C0", VA = "0x1828FF7C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x105B060", Offset = "0x105A260", VA = "0x18105B060")]
			private Enumerable(Enumerator<T> enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x47433F0", Offset = "0x47425F0", VA = "0x1847433F0")]
			public static Enumerable<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerable<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x105B030", Offset = "0x105A230", VA = "0x18105B030")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4743220", Offset = "0x4742420", VA = "0x184743220", Slot = "4")]
			private IEnumerator<T> ULRXOZXQGZW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4743220", Offset = "0x4742420", VA = "0x184743220", Slot = "5")]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8570F80", Offset = "0x8570180", VA = "0x188570F80")]
		public static void Invoke(this IReadOnlyList<Action> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3C57270", Offset = "0x3C56470", VA = "0x183C57270")]
		public static bool GDGJFTLPVBG<T>(this IReadOnlyList<T> a, int b, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3C57A50", Offset = "0x3C56C50", VA = "0x183C57A50")]
		public static bool SFWVCQDYUNH<T>(this IReadOnlyList<T> a, int b, [Out] IndexValuePair<T> result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3C56FA0", Offset = "0x3C561A0", VA = "0x183C56FA0")]
		public static T BCMFQFPOGGM<T>(this IReadOnlyList<T> a, int b, [In] T optB) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3C574E0", Offset = "0x3C566E0", VA = "0x183C574E0")]
		[CS9ImprovedNullableConstraints("This should return `T?` in C# 9. `default! isn't necessary.")]
		public static T NJEICNFLLMR<T>(this IReadOnlyList<T> a, int b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3C577B0", Offset = "0x3C569B0", VA = "0x183C577B0")]
		public static a? RWIRUOTGBKF<a>(this IReadOnlyList<a> self, int a) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3C57590", Offset = "0x3C56790", VA = "0x183C57590")]
		public static Enumerable<T> QXALEKQXZAY<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(Enumerable<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class EHXIEACHTNA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3627CF0", Offset = "0x3626EF0", VA = "0x183627CF0")]
		public static int XIKTRIUEHCJ<a>([In] this ReadOnlySequence<a> sequence, [In] a value) where a : IEquatable<a>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x36277A0", Offset = "0x36269A0", VA = "0x1836277A0")]
		public static bool WDOKKLFHLLZ<c>([In] this ReadOnlySequence<c> sequence, [In] ReadOnlySpan<c> other) where c : IEquatable<c>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class ODAZOFDZSZP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3921B10", Offset = "0x3920D10", VA = "0x183921B10")]
		public static string VKMNJIWCZKR<T>([In] this ReadOnlySpan<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3921060", Offset = "0x3920260", VA = "0x183921060")]
		public static string LXVYLIRGEGT<T>([In] this ReadOnlySpan<T> self, string a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct ReadOnlyStopwatch : KVYWVIGHLAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly KVYWVIGHLAM _baseStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly long _baseTicks;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long LTYDINJXZAK
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x856EF10", Offset = "0x856E110", VA = "0x18856EF10", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double WVDXAIEEXLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x856EE50", Offset = "0x856E050", VA = "0x18856EE50")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double IGOBYBPMXBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x856ED90", Offset = "0x856DF90", VA = "0x18856ED90")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1BAFC40", Offset = "0x1BAEE40", VA = "0x181BAFC40")]
		public ReadOnlyStopwatch(KVYWVIGHLAM baseStopwatch, long baseTicks)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class ZVDRMRMAGGU
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static KVYWVIGHLAM NSDFRGIIYSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8571430", Offset = "0x8570630", VA = "0x188571430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8571310", Offset = "0x8570510", VA = "0x188571310")]
		public static long GZTUTYIUTVS(this KVYWVIGHLAM a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8571200", Offset = "0x8570400", VA = "0x188571200")]
		public static double AACBGHRBYLW(this KVYWVIGHLAM a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x85713A0", Offset = "0x85705A0", VA = "0x1885713A0")]
		public static double JOYTHXYMNGR(this KVYWVIGHLAM a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8571290", Offset = "0x8570490", VA = "0x188571290")]
		public static ReadOnlyStopwatch DYQFZWGRLIV(this KVYWVIGHLAM a)
		{
			return default(ReadOnlyStopwatch);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class AWPVEXIRWKQ : KVYWVIGHLAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Stopwatch FFSIOOBIIAE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public long LTYDINJXZAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x856B860", Offset = "0x856AA60", VA = "0x18856B860", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		private AWPVEXIRWKQ(Stopwatch a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x856B760", Offset = "0x856A960", VA = "0x18856B760")]
		public static AWPVEXIRWKQ BUJKYAGEQBV(Stopwatch a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x856B7C0", Offset = "0x856A9C0", VA = "0x18856B7C0")]
		public static AWPVEXIRWKQ CVZWLGUQJIK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class JTLYMYCMMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8452820", Offset = "0x8451A20", VA = "0x188452820")]
		public static float3 up([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x84526F0", Offset = "0x84518F0", VA = "0x1884526F0")]
		public static float3 YLFXBFLGPEN([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1139F10", Offset = "0x1139110", VA = "0x181139F10")]
		public static (float3, float3, float3) KLBPHADBRSG([In] this RigidTransform self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x856D230", Offset = "0x856C430", VA = "0x18856D230")]
		public static RigidTransform OIBVEPFBQCE([In] this RigidTransform self)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class LVWXKPFPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x856D5D0", Offset = "0x856C7D0", VA = "0x18856D5D0")]
		public static RigidTransform LELCFVNBCKI(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class SXSVPAIMEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x856EFD0", Offset = "0x856E1D0", VA = "0x18856EFD0")]
		public static float LQXNUOZRVPT([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x856F080", Offset = "0x856E280", VA = "0x18856F080")]
		public static int PUQNOGDTMMW(this float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x856F010", Offset = "0x856E210", VA = "0x18856F010")]
		public static (byte, byte, byte, byte) MYIJUPDQLIY(this float a)
		{
			return default((byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class BVKHXUJNWOT
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3419730", Offset = "0x3418930", VA = "0x183419730")]
		public static ReadOnlySpan<a?> CZLFOFDRATM<a>([In] this Span<a> self)
		{
			return default(ReadOnlySpan<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class BVPQGZLCASH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x856C1E0", Offset = "0x856B3E0", VA = "0x18856C1E0")]
		public static StringBuilder LHAPMEJPVJE(this StringBuilder a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x856C2A0", Offset = "0x856B4A0", VA = "0x18856C2A0")]
		public static StringBuilder ZCRYKWCKFWN(this StringBuilder a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x856C240", Offset = "0x856B440", VA = "0x18856C240")]
		public static StringBuilder RVTJLBFUYRA(this StringBuilder a, char b, int c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class MUURPJBPXTK
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly Regex FGVPMXMVBKM;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static Regex NHLRHZUJCTE;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static Regex RZUAECTRMRJ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly char[] QRRWJYCDWNS;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly string[] EBCBCBODSEX;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x76E45B0", Offset = "0x76E37B0", VA = "0x1876E45B0")]
		public static bool SMITEOICKSN(this string? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x856E070", Offset = "0x856D270", VA = "0x18856E070")]
		public static string? ULDENPTMERE(this string? a, int b, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x856DDB0", Offset = "0x856CFB0", VA = "0x18856DDB0")]
		public static string PGAVHSOAADK(this string a, int b, string c = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x856D690", Offset = "0x856C890", VA = "0x18856D690")]
		public static int AAPFFPLFIKW(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x856D700", Offset = "0x856C900", VA = "0x18856D700")]
		public static string ANIRKMADEGT(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x856DD00", Offset = "0x856CF00", VA = "0x18856DD00")]
		public static string FGJKPJHDWUZ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x856DC00", Offset = "0x856CE00", VA = "0x18856DC00")]
		public static string[] EQCRKWGHYEP(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x856DFA0", Offset = "0x856D1A0", VA = "0x18856DFA0")]
		private static bool RXVQFFKEVBA(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x856DE40", Offset = "0x856D040", VA = "0x18856DE40")]
		private static bool PJCVEOWXGKJ(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x856D880", Offset = "0x856CA80", VA = "0x18856D880")]
		public static int CITQOTLTRUQ(string a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class XXAIPZFCDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85707B0", Offset = "0x856F9B0", VA = "0x1885707B0")]
		public static bool WKQQVTSHOXO(this Type a, Type b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3C481E0", Offset = "0x3C473E0", VA = "0x183C481E0")]
		public static bool WKQQVTSHOXO<T>(this Type a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class EYKPGWVQOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7349340", Offset = "0x7348540", VA = "0x187349340")]
		public static uint UZKLUNRYLQG(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7426B80", Offset = "0x7425D80", VA = "0x187426B80")]
		public static uint OKUQPPAHVOX(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x856C680", Offset = "0x856B880", VA = "0x18856C680")]
		public static uint JKNXYGXRWTD(this uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8435930", Offset = "0x8434B30", VA = "0x188435930")]
		public static int PUQNOGDTMMW(this uint a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.NumberStrings
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class QFFZFEDJAVF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x856EC80", Offset = "0x856DE80", VA = "0x18856EC80")]
		public static string UIMTEBSEWNG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x856EB70", Offset = "0x856DD70", VA = "0x18856EB70")]
		public static string NQGMLHMXFYN(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x856EAB0", Offset = "0x856DCB0", VA = "0x18856EAB0")]
		private static string JSELGBKTTLC(double a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class AENCHLFBIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x30A6830", Offset = "0x30A5A30", VA = "0x1830A6830")]
		public static a EHXVIZOICGO<a>(IEnumerable<string> flagStrings, [Optional] a a) where a : struct, Enum, IConvertible
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x30A6DC0", Offset = "0x30A5FC0", VA = "0x1830A6DC0")]
		public static b IHEJMNHFRGT<b>(IEnumerable<string> flagStrings, [Optional] b a) where b : struct, Enum, IConvertible
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x30A7640", Offset = "0x30A6840", VA = "0x1830A7640")]
		public static c WXCMXKLMTMS<c>(IEnumerable<string> flagStrings, [Optional] c a) where c : struct, Enum, IConvertible
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x30A3F00", Offset = "0x30A3100", VA = "0x1830A3F00")]
		private static bool JFAOKGOORBT(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class LYANBKYAGYI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x381AFA0", Offset = "0x381A1A0", VA = "0x18381AFA0")]
		public static bool YRIJXRPZWIO<a>([In] this a? self, [Out] a a) where a : struct
		{
			return default(bool);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime.Stats
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class GRLVYGHGBZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x856D120", Offset = "0x856C320", VA = "0x18856D120")]
		public static StatsResults XQMWNHKOTUJ(IReadOnlyList<float> a, int b = -1, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x856C690", Offset = "0x856B890", VA = "0x18856C690")]
		private static StatsResults GYJTHHNOIQI(IReadOnlyList<float> a, int b, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x856CFD0", Offset = "0x856C1D0", VA = "0x18856CFD0")]
		private static float VVLXBDOQCWT(IReadOnlyList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x856CCB0", Offset = "0x856BEB0", VA = "0x18856CCB0")]
		public static float JBCSEKGCLMK(IReadOnlyList<float> a, int b, int c)
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
		[Cpp2IlInjected.Address(RVA = "0x856EA80", Offset = "0x856DC80", VA = "0x18856EA80")]
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
		private sealed class XYYLUQUKIWR : IEnumerable<(StatResultFlags, float)>, IEnumerable, IEnumerator<(StatResultFlags, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private (StatResultFlags flag, float result) HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private StatResultFlags MLSWMABILCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public StatResultFlags UPROVEQLYAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public StatsResults LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public StatsResults ZFZPMTYYXUH;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private (StatResultFlags, float) WYTJLMTLSDF
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x1196090", Offset = "0x1195290", VA = "0x181196090", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((StatResultFlags, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x85707E0", Offset = "0x856F9E0", VA = "0x1885707E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4E27CE0", Offset = "0x4E26EE0", VA = "0x184E27CE0")]
			[DebuggerHidden]
			public XYYLUQUKIWR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8570900", Offset = "0x856FB00", VA = "0x188570900", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8570F40", Offset = "0x8570140", VA = "0x188570F40", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8570830", Offset = "0x856FA30", VA = "0x188570830", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(StatResultFlags, float)> PDOORSQJYPS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8570830", Offset = "0x856FA30", VA = "0x188570830", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
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
		public float GWFOBWNCVSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x856F090", Offset = "0x856E290", VA = "0x18856F090")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float YPFORSMFLFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x856F0B0", Offset = "0x856E2B0", VA = "0x18856F0B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x856F170", Offset = "0x856E370", VA = "0x18856F170")]
		public StatsResults(int n, int hitchN, float hitchThreshold, float hitchThresholdOffset, float min, float max, float mean, float median, float varianceSum, float lowerQuartile, float upperQuartile, PercentileResults percentileResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x856F0D0", Offset = "0x856E2D0", VA = "0x18856F0D0")]
		[IteratorStateMachine(typeof(XYYLUQUKIWR))]
		public IEnumerable<(StatResultFlags, float)> XCDDVNEGGDQ(StatResultFlags a)
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
