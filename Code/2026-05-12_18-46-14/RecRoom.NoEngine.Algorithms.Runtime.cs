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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AE3140", Offset = "0x9AE1B40", VA = "0x189AE3140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class ILBMKHUCSVQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly string[] LFDFNXVXXNL;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2180", Offset = "0x9AE0B80", VA = "0x189AE2180")]
		public static bool QRGQRMOXGAP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1C20", Offset = "0x9AE0620", VA = "0x189AE1C20")]
		private static bool DMUUNAWJEHD(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1CF0", Offset = "0x9AE06F0", VA = "0x189AE1CF0")]
		public static bool DMUUNAWJEHD(Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1E40", Offset = "0x9AE0840", VA = "0x189AE1E40")]
		public static string JLQYZRATWCY(string a, string b = "", bool c = true)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class BGNUCJXDXND
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE04D0", Offset = "0x9ADEED0", VA = "0x189AE04D0")]
		public static string LENPNXPVCQY(this Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0580", Offset = "0x9ADEF80", VA = "0x189AE0580")]
		public static string LENPNXPVCQY(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0620", Offset = "0x9ADF020", VA = "0x189AE0620")]
		public static byte[] RBILPCACFTD(string a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OZQHCMMOZWA
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate int CompareDelegate<T>([In] T lhs, [In] T rhs);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate U BreakDelegate<T, U>(int numberOfParts, int partIndex, [In] ReadOnlySpan<T> part);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D753C0", Offset = "0x3D73DC0", VA = "0x183D753C0")]
		public static ReadOnlyMemory<T> VXGXOSIHPJX<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyMemory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D752F0", Offset = "0x3D73CF0", VA = "0x183D752F0")]
		public static ReadOnlySpan<T> TVBKTQGFCHU<T>(this T[] a, int b) where T : notnull
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D751D0", Offset = "0x3D73BD0", VA = "0x183D751D0")]
		public static T[] TQDZQNHMKQQ<T>(int a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D74D50", Offset = "0x3D73750", VA = "0x183D74D50")]
		public static void SZJSBLXUISZ<T>(this T[] a, T b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D74B80", Offset = "0x3D73580", VA = "0x183D74B80")]
		public static T[] Remove<T>(this T[] originalArray, int index) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D725B0", Offset = "0x3D70FB0", VA = "0x183D725B0")]
		public static void GFTRXSMUFRD<T>(this T[] a, int b, int c) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D72EF0", Offset = "0x3D718F0", VA = "0x183D72EF0")]
		public static void IUBGZGJWLNW<T>(this T[] a, CompareDelegate<T> b, [Optional] T[]? preallocatedWorkBuffer) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D73C10", Offset = "0x3D72610", VA = "0x183D73C10")]
		private static void MXUJKSRTWTE<T>(this T[] a, int b, int c, T[] d, bool e, CompareDelegate<T> f) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D744B0", Offset = "0x3D72EB0", VA = "0x183D744B0")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D72660", Offset = "0x3D71060", VA = "0x183D72660")]
		public static void GSEWAUMIWFT<T>(this T[] a, int b, int c, CompareDelegate<T> d) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D75000", Offset = "0x3D73A00", VA = "0x183D75000")]
		public static T[] Sort<T>(this T[] array) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D73130", Offset = "0x3D71B30", VA = "0x183D73130")]
		public static T[] LLXFTLUAGVP<T>(this T[] a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D75420", Offset = "0x3D73E20", VA = "0x183D75420")]
		public static T[] YADRVRFQMNZ<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D74C90", Offset = "0x3D73690", VA = "0x183D74C90")]
		public static T[] SUCIOQQIBLR<T>(this T[] a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D75EB0", Offset = "0x3D748B0", VA = "0x183D75EB0")]
		public static T[] YYLMTFRJMQD<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D71DF0", Offset = "0x3D707F0", VA = "0x183D71DF0")]
		public static U[] Break<U, T>(this T[] items, int maxItemsPerPart, BreakDelegate<T, U> xForm) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4320", Offset = "0x9AE2D20", VA = "0x189AE4320")]
		public static byte[] DLIHITAFZCH(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4580", Offset = "0x9AE2F80", VA = "0x189AE4580")]
		public static byte[] VPSKCJFGLTR(this byte[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class YBCXAISIHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0B70", Offset = "0x9ADF570", VA = "0x189AE0B70")]
		public static byte FPBXLGOKTVD(this bool a)
		{
			return default(byte);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class DBEQHAVYDYB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0B70", Offset = "0x9ADF570", VA = "0x189AE0B70")]
		public static bool OGDZPGVRXQL(this byte a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class DPOJAMCDTPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x390F460", Offset = "0x390DE60", VA = "0x18390F460")]
		public static void JDWUGDMAJUI<T>(this ICollection<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3910490", Offset = "0x390EE90", VA = "0x183910490")]
		public static void WIBSACRCIYS<T>(this ICollection<T> a) where T : notnull, IDisposable
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class IJWJRZXXAOX
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B85370", Offset = "0x3B83D70", VA = "0x183B85370")]
		public static V SUOBYQLDRJZ<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3B848C0", Offset = "0x3B832C0", VA = "0x183B848C0")]
		public static V SUOBYQLDRJZ<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3B83290", Offset = "0x3B81C90", VA = "0x183B83290")]
		public static void BEYZAVKJNLX<K, V>(this IDictionary<K, List<V>> a, [In] K key, [In] V value) where K : notnull where V : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3B86690", Offset = "0x3B85090", VA = "0x183B86690")]
		public static TVal WHQWPQBBMIE<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] TVal defaultValue) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3B873B0", Offset = "0x3B85DB0", VA = "0x183B873B0")]
		public static TVal WHQWPQBBMIE<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, Func<TVal> b) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3B83A60", Offset = "0x3B82460", VA = "0x183B83A60")]
		public static b HLMYVEIWFOG<b, a>(this IDictionary<a, b> a, [In] a key, [Optional][In][CS9ImprovedNullableConstraints("`default!` and null-oblivious region shouldn't be necessary in C# 9")] b defaultValue)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B85640", Offset = "0x3B84040", VA = "0x183B85640")]
		public static V Take<V, K>(this IDictionary<K, V> self, [In] K key) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3B84790", Offset = "0x3B83190", VA = "0x183B84790")]
		public static T2[] QUXLCTIMAMW<T2, T1>(this Dictionary<T1, T2>.ValueCollection a) where T2 : notnull where T1 : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CPHUMQEZVEZ
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
			[Cpp2IlInjected.Address(RVA = "0x7ADC190", Offset = "0x7ADAB90", VA = "0x187ADC190")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) One(T one)
			{
				return default((bool, T, IEnumerable<T>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7ADC580", Offset = "0x7ADAF80", VA = "0x187ADC580")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) ZIZJBHSVMTF(IEnumerable<T> a)
			{
				return default((bool, T, IEnumerable<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class OLDKPGBKYRW<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HashSet<a> LBLPUZWQSAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HashSet<a> KXZJBHWIAJQ;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public OLDKPGBKYRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x740D750", Offset = "0x740C150", VA = "0x18740D750")]
			internal bool ERUZKAHXVJE(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x740D920", Offset = "0x740C320", VA = "0x18740D920")]
			internal bool ESAGHHBVEUN(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class GBHXWWZUUPW<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private a AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private ISet<a> IUKDASVXYRK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ISet<a> CACSNWCECUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IEnumerable<a> SMSLVFIAEDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IEnumerable<a> XPRWKSICURS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private IEnumerator<a> ONPYAFUWWYM;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private a GNSAKLWDGDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x13682A0", Offset = "0x1366CA0", VA = "0x1813682A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x64C2290", Offset = "0x64C0C90", VA = "0x1864C2290", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x15F05D0", Offset = "0x15EEFD0", VA = "0x1815F05D0")]
			[DebuggerHidden]
			public GBHXWWZUUPW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x64C12D0", Offset = "0x64BFCD0", VA = "0x1864C12D0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x64C16F0", Offset = "0x64C00F0", VA = "0x1864C16F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x64C2370", Offset = "0x64C0D70", VA = "0x1864C2370")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA810", Offset = "0x4EF9210", VA = "0x184EFA810", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x64C1430", Offset = "0x64BFE30", VA = "0x1864C1430", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> KEHYSNFVZBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x64C1150", Offset = "0x64BFB50", VA = "0x1864C1150", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class OVOAKDDWFDY<a, b> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private a AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private IEnumerable<a> LGBGXMPTAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IEnumerable<a> XVIDHJNVFSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private IEnumerable<b> KIZSTVTHHJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IEnumerable<b> ACPEGRDNBPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private a GRBQDYRSHTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public a YLOJPZTKRCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private IEnumerator<a> YFUXIRZDTSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IEnumerator<b> SXDBCANUPRG;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private a GNSAKLWDGDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x5CB1410", Offset = "0x5CAFE10", VA = "0x185CB1410", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x742A980", Offset = "0x7429380", VA = "0x18742A980", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x672BDA0", Offset = "0x672A7A0", VA = "0x18672BDA0")]
			[DebuggerHidden]
			public OVOAKDDWFDY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7428DE0", Offset = "0x74277E0", VA = "0x187428DE0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x742A520", Offset = "0x7428F20", VA = "0x18742A520", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x742AD40", Offset = "0x7429740", VA = "0x18742AD40")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x742AB50", Offset = "0x7429550", VA = "0x18742AB50")]
			private void SMGDSKUDEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA810", Offset = "0x4EF9210", VA = "0x184EFA810", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7429490", Offset = "0x7427E90", VA = "0x187429490", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> KEHYSNFVZBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7428B50", Offset = "0x7427550", VA = "0x187428B50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class ZGNVRJHUBSL<a> : IEnumerable<(a, Option<a>)>, IEnumerable, IEnumerator<(a, Option<a>)>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private (a Current, Option<a> Next) AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerable<a> LGBGXMPTAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IEnumerable<a> XVIDHJNVFSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerator<a> FUCVCPCMKYB;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private (a, Option<a>) VGMKIPJCVPY
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2E270C0", Offset = "0x2E25AC0", VA = "0x182E270C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, Option<a>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x519E0B0", Offset = "0x519CAB0", VA = "0x18519E0B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2E273E0", Offset = "0x2E25DE0", VA = "0x182E273E0")]
			[DebuggerHidden]
			public ZGNVRJHUBSL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x519CF10", Offset = "0x519B910", VA = "0x18519CF10", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x519DB20", Offset = "0x519C520", VA = "0x18519DB20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x519E3E0", Offset = "0x519CDE0", VA = "0x18519E3E0")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA810", Offset = "0x4EF9210", VA = "0x184EFA810", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x519E330", Offset = "0x519CD30", VA = "0x18519E330", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, Option<a>)> QMQBOMAMMVH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x519CE50", Offset = "0x519B850", VA = "0x18519CE50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class MFGCJGUJEBY<a, b> : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private b AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<a> LGBGXMPTAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<a> XVIDHJNVFSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> IYGTJYDWWXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> ULORRIYKZMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<a> ONPYAFUWWYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private IEnumerator<b> OOFSSACOZGN;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private b HSQAHHEZFIS
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x104AC00", Offset = "0x1049600", VA = "0x18104AC00")]
			[DebuggerHidden]
			public MFGCJGUJEBY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7068EB0", Offset = "0x70678B0", VA = "0x187068EB0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7069B40", Offset = "0x7068540", VA = "0x187069B40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x706A460", Offset = "0x7068E60", VA = "0x18706A460")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x706A320", Offset = "0x7068D20", VA = "0x18706A320")]
			private void SMGDSKUDEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA810", Offset = "0x4EF9210", VA = "0x184EFA810", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x657AC20", Offset = "0x6579620", VA = "0x18657AC20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> RFDSTCLWBMZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7068C60", Offset = "0x7067660", VA = "0x187068C60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WIMCCRUPIRB<a, b> : IEnumerable<(a, b)>, IEnumerable, IEnumerator<(a, b)>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private (a Lhs, b Rhs) AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private IEnumerable<a> SMPMNHQEZIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IEnumerable<a> HPXHFBEBKIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IEnumerable<b> KODDXDLNROP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IEnumerable<b> ECTNXQHVGIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private IEnumerator<a> CJQVLVAFFXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private IEnumerator<b> HTELWMWSPVM;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private (a, b) MYLVSRNQGQP
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0xDA3550", Offset = "0xDA1F50", VA = "0x180DA3550", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x650CD70", Offset = "0x650B770", VA = "0x18650CD70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1D3DC10", Offset = "0x1D3C610", VA = "0x181D3DC10")]
			[DebuggerHidden]
			public WIMCCRUPIRB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8720060", Offset = "0x871EA60", VA = "0x188720060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA810", Offset = "0x4EF9210", VA = "0x184EFA810", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6589F00", Offset = "0x6588900", VA = "0x186589F00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, b)> FCMEBULDXYQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x871FD90", Offset = "0x871E790", VA = "0x18871FD90", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3800E90", Offset = "0x37FF890", VA = "0x183800E90")]
		public static bool All<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AE06F0", Offset = "0x9ADF0F0", VA = "0x189AE06F0")]
		public static bool All(this IEnumerable<bool> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x380FF90", Offset = "0x380E990", VA = "0x18380FF90")]
		public static U KCXHKLJYHGM<U, T>(this IEnumerable<T> a, Func<U> b, Func<T, U> c, Func<IEnumerable<T>, U> d) where U : notnull where T : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3801360", Offset = "0x37FFD60", VA = "0x183801360")]
		public static bool Any<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803600", VA = "0x183804C00")]
		public static U EKQZALSAFLG<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgAmountSwitchZeroDelegate<TArg, U> b, ArgAmountSwitchOneDelegate<TArg, T, U> c, ArgAmountSwitchManyDelegate<TArg, T, U> d) where U : notnull where T : notnull where TArg : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3801B60", Offset = "0x3800560", VA = "0x183801B60")]
		public static IEnumerable<U> BRYAUVVAWUI<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgSelectDelegate<TArg, T, U> b) where U : notnull where T : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x38045A0", Offset = "0x3802FA0", VA = "0x1838045A0")]
		public static IEnumerable<T> CTVFSFPMGGA<T>(params IEnumerable<T>[] enumerables) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3805C30", Offset = "0x3804630", VA = "0x183805C30")]
		public static bool GTNPLQBRBAQ<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3801510", Offset = "0x37FFF10", VA = "0x183801510")]
		public static IEnumerable<(a?, b?)>? BBOKGMPSQCH<a, b>(this IEnumerable<KeyValuePair<a, b>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3805810", Offset = "0x3804210", VA = "0x183805810")]
		public static IEnumerable<T> GIWPMFWURBT<T, TKey>(this IEnumerable<T> a, Func<T, TKey> b) where T : notnull where TKey : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3816EF0", Offset = "0x38158F0", VA = "0x183816EF0")]
		[IteratorStateMachine(typeof(GBHXWWZUUPW<>))]
		public static IEnumerable<T> ZJDPRLUDYHW<T>(this IEnumerable<T> a, ISet<T> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3813CB0", Offset = "0x38126B0", VA = "0x183813CB0")]
		[IteratorStateMachine(typeof(OVOAKDDWFDY<, >))]
		public static IEnumerable<T> SYKCOBSGBAY<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T with) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3813150", Offset = "0x3811B50", VA = "0x183813150")]
		public static T NQKGKVCTBSX<T>(this IEnumerable<T> a, T b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x38131B0", Offset = "0x3811BB0", VA = "0x1838131B0")]
		public static T NQKGKVCTBSX<T>(this IEnumerable<T> a, T b, Func<T, bool> c) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x38168A0", Offset = "0x38152A0", VA = "0x1838168A0")]
		public static c? YWTOSRSBFAO<c>(this IEnumerable<c> self, Func<c, bool> predicate) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3815A60", Offset = "0x3814460", VA = "0x183815A60")]
		public static void YAJLIXBXLTI<T>(this IEnumerable<T> a, Action<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3814010", Offset = "0x3812A10", VA = "0x183814010")]
		[IteratorStateMachine(typeof(ZGNVRJHUBSL<>))]
		public static IEnumerable<(T, Option<T>)> TEHVNHJELMX<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3804720", Offset = "0x3803120", VA = "0x183804720")]
		public static bool CYJUJDFYUII<T>(this IEnumerable<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x380C270", Offset = "0x380AC70", VA = "0x18380C270")]
		public static IEnumerable<IndexValuePair<T>> Index<T>(this IEnumerable<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x380CE70", Offset = "0x380B870", VA = "0x18380CE70")]
		public static bool IsEmpty<T>(this IEnumerable<T> self) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3805E40", Offset = "0x3804840", VA = "0x183805E40")]
		public static IEnumerable<T> HHCXZKUOGCF<T>(this IEnumerable<T>? self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3814A40", Offset = "0x3813440", VA = "0x183814A40")]
		[IteratorStateMachine(typeof(MFGCJGUJEBY<, >))]
		public static IEnumerable<U> WYRRZIWSEPK<U, T>(this IEnumerable<T> a, Func<SelectAmountPicker<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3804420", Offset = "0x3802E20", VA = "0x183804420")]
		public static IEnumerable<T> UDEHWOQKLTJ<T>(this IEnumerable<IEnumerable<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3817310", Offset = "0x3815D10", VA = "0x183817310")]
		public static int ZRVCKBJQILU<T>(this IEnumerable<T> a, int b = 0) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3800700", Offset = "0x37FF100", VA = "0x183800700")]
		public static bool AZCBLXNKZOU<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3810390", Offset = "0x380ED90", VA = "0x183810390")]
		public static IEnumerable<T> KMBMUJNDTTW<T>(this IEnumerable<T> a, int b, int c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3816230", Offset = "0x3814C30", VA = "0x183816230")]
		public static (IEnumerable<T>, IEnumerable<T>) YKWWCFZPPQY<T>(this IEnumerable<T> a, Func<T, bool> b) where T : notnull
		{
			return default((IEnumerable<T>, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3814E40", Offset = "0x3813840", VA = "0x183814E40")]
		public static string XQUGYMTKBHH<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x38152E0", Offset = "0x3813CE0", VA = "0x1838152E0")]
		public static string XQUGYMTKBHH<T>(this IEnumerable<T> a, Func<T, string> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3810470", Offset = "0x380EE70", VA = "0x183810470")]
		public static Dictionary<d?, e?>? LVJZJBICXNP<d, e>(this IEnumerable<KeyValuePair<d, e>> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3811490", Offset = "0x380FE90", VA = "0x183811490")]
		public static Dictionary<f?, g?>? LVJZJBICXNP<f, g>(this IEnumerable<(f Key, g Value)> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x38119F0", Offset = "0x38103F0", VA = "0x1838119F0")]
		public static List<T> LZUJHCFJLOZ<T>(this IEnumerable<T> a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x37FFFD0", Offset = "0x37FE9D0", VA = "0x1837FFFD0")]
		public static string AEBPHJIZKCT<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3813850", Offset = "0x3812250", VA = "0x183813850")]
		public static (IReadOnlyList<h?>?, IReadOnlyList<i?>?) NSQUSGISHEK<h, i>(this IEnumerable<(h Lhs, i Rhs)> self)
		{
			return default((IReadOnlyList<h>, IReadOnlyList<i>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x380D020", Offset = "0x380BA20", VA = "0x18380D020")]
		[IteratorStateMachine(typeof(WIMCCRUPIRB<, >))]
		public static IEnumerable<(T, U)> JLVDAOFJXIX<T, U>(this IEnumerable<T> a, IEnumerable<U> b) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3805EE0", Offset = "0x38048E0", VA = "0x183805EE0")]
		public static IEnumerable<V> HIJDMLABHOD<V, T, U>(this IEnumerable<T> a, IEnumerable<U> b, Func<T, U, V> c, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where V : notnull where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3806080", Offset = "0x3804A80", VA = "0x183806080")]
		public static IEnumerable<(T, U)> HIJDMLABHOD<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3806EF0", Offset = "0x38058F0", VA = "0x183806EF0")]
		public static TOut[] ILWFXVFTYDA<TOut, TIn>(this IEnumerable<TIn> a, Func<TIn, TOut> b) where TOut : notnull where TIn : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x380D950", Offset = "0x380C350", VA = "0x18380D950")]
		public static Option<U> JPCMCLHFXPC<U, T>(this IEnumerable<T> a, Func<T, U> b) where U : notnull where T : notnull
		{
			return default(Option<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3805100", Offset = "0x3803B00", VA = "0x183805100")]
		public static void FBTPWBFHBAY<T>(this IEnumerable<T> a) where T : notnull, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x38033C0", Offset = "0x3801DC0", VA = "0x1838033C0")]
		public static IEnumerable<KeyValuePair<TKey, List<TItem>>> CKXQZZPSVYI<TKey, TItem>(this IEnumerable<IEnumerable<TItem>> a, Func<TItem, TKey> b) where TKey : notnull where TItem : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class SAXWPLXSVVB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3F19190", Offset = "0x3F17B90", VA = "0x183F19190")]
		public static bool VQDBDMBKVYB<T, U>(this T a, [In] U obj) where T : notnull, IEquatable<T> where U : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3F18D90", Offset = "0x3F17790", VA = "0x183F18D90")]
		public static bool ERDUQXTASRS<a>(a a, a b) where a : class, IEquatable<a>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class EVHTBABOYTU
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x15C8B10", Offset = "0x15C7510", VA = "0x1815C8B10")]
		public static bool XRYWPPUTMYU([In] this float3 a, float3 a, float b = 1E-05f)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class QAAYYBDEBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4C40", Offset = "0x9AE3640", VA = "0x189AE4C40")]
		public static float3 MWSATSPJQWG([In] this float4x4 localToWorld, [In] float3 point)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4B60", Offset = "0x9AE3560", VA = "0x189AE4B60")]
		public static float3 BHEQTYKFVWO([In] this float4x4 localToWorld, [In] float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class RYQKZKCLGFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class JVLTPWBOFSI<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private a AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private a LGBGXMPTAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public a XVIDHJNVFSL;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a GNSAKLWDGDF
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xDA3550", Offset = "0xDA1F50", VA = "0x180DA3550", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6777370", Offset = "0x6775D70", VA = "0x186777370", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1D3DC10", Offset = "0x1D3C610", VA = "0x181D3DC10")]
			[DebuggerHidden]
			public JVLTPWBOFSI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x67C9F20", Offset = "0x67C8920", VA = "0x1867C9F20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA810", Offset = "0x4EF9210", VA = "0x184EFA810", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x67C9B50", Offset = "0x67C8550", VA = "0x1867C9B50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> KEHYSNFVZBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x67C96C0", Offset = "0x67C80C0", VA = "0x1867C96C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0F90", Offset = "0x3EEF990", VA = "0x183EF0F90")]
		public static void MKOTIEYVMZM<a>(this a a, Action<a> b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3EF10F0", Offset = "0x3EEFAF0", VA = "0x183EF10F0")]
		public static V RXEQVIORRWZ<V, b>(this b a, Func<b, V> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] V defaultValue) where V : notnull where b : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0D40", Offset = "0x3EEF740", VA = "0x183EF0D40")]
		public static c? KJXREBOAAEJ<c>(this c a) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1060", Offset = "0x3EEFA60", VA = "0x183EF1060")]
		[IteratorStateMachine(typeof(JVLTPWBOFSI<>))]
		public static IEnumerable<T> NCSSLLOBLQO<T>(this T a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0970", Offset = "0x3EEF370", VA = "0x183EF0970")]
		public static T[] GNVZYNVUBYZ<T>(this T a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class SCRKNCHSYOA
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly MD5 OJAKMJZLVOQ;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly SHA1 UPTPWLEDEFP;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly byte[] JAFVJXRSFTL;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly byte[] FVEBDTLMQGT;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6AC0", Offset = "0x9AE54C0", VA = "0x189AE6AC0")]
		static SCRKNCHSYOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6950", Offset = "0x9AE5350", VA = "0x189AE6950")]
		public static Guid RKNQNTFJHMJ([In] Guid a, [In] Guid b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6860", Offset = "0x9AE5260", VA = "0x189AE6860")]
		public static Guid RKNQNTFJHMJ([In] Guid a, [In] Guid b, [In] Guid c)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F241F0", Offset = "0x3F22BF0", VA = "0x183F241F0")]
		public static Guid Create<T>([In] Guid namespaceId, T value, int version = 5) where T : struct
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6740", Offset = "0x9AE5140", VA = "0x189AE6740")]
		public static Guid Create([In] Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6400", Offset = "0x9AE4E00", VA = "0x189AE6400")]
		private static Guid Create([In] Guid namespaceId, byte[] value, int length, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F24940", Offset = "0x3F23340", VA = "0x183F24940")]
		private static void XGEFRFMTABA<T>([In] T src, Span<byte> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F247C0", Offset = "0x3F231C0", VA = "0x183F247C0")]
		private static T DAOUNAUWTPW<T>(Span<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6A00", Offset = "0x9AE5400", VA = "0x189AE6A00")]
		private static void ZNUGURFORMM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6810", Offset = "0x9AE5210", VA = "0x189AE6810")]
		private static void JHCGMRFQWYC(byte[] a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class ESSANMMATEX
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1920", Offset = "0x9AE0320", VA = "0x189AE1920")]
		public static int CCFAMWWPFNT(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1AC0", Offset = "0x9AE04C0", VA = "0x189AE1AC0")]
		public static int ZXSZDWSXDHL(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AE19C0", Offset = "0x9AE03C0", VA = "0x189AE19C0")]
		public static int KMILDWIXAQF(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1AB0", Offset = "0x9AE04B0", VA = "0x189AE1AB0")]
		public static int YSSFKGFABFQ(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8876270", Offset = "0x8874C70", VA = "0x188876270")]
		public static int XIKHEMXXNCK(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8953A40", Offset = "0x8952440", VA = "0x188953A40")]
		public static int QKUMTNCVUEH(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE19A0", Offset = "0x9AE03A0", VA = "0x189AE19A0")]
		public static float JZHTKAOBDUN(this int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1A40", Offset = "0x9AE0440", VA = "0x189AE1A40")]
		public static (byte, byte, byte, byte) WSGBAZDQOOY(this int a)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1A10", Offset = "0x9AE0410", VA = "0x189AE1A10")]
		public static int NDOOHOTYCNM([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1A30", Offset = "0x9AE0430", VA = "0x189AE1A30")]
		public static int VUQXRVUHFHE(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1990", Offset = "0x9AE0390", VA = "0x189AE1990")]
		public static int EDUNVRIZLGZ(this int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class CQDSBGHFTEW
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0AB0", Offset = "0x9ADF4B0", VA = "0x189AE0AB0")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) WSGBAZDQOOY(this long a)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0990", Offset = "0x9ADF390", VA = "0x189AE0990")]
		public static long FUAUHSPSMPV([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0A50", Offset = "0x9ADF450", VA = "0x189AE0A50")]
		public static string SVLMEWTATJC(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0800", Offset = "0x9ADF200", VA = "0x189AE0800")]
		public static string CKHXJEYGBIR(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9AE09E0", Offset = "0x9ADF3E0", VA = "0x189AE09E0")]
		public static string HJHTKVICGRU(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0870", Offset = "0x9ADF270", VA = "0x189AE0870")]
		public static string DDZDUWWBVQY(this long a, long b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface CTRRBQWZPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Next(int minValue, int maxValue);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float HJVSXKEOLMB(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface VYVNYDWJGJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		long KBNUSLDIWAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class GYEPQALUPAT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3B02970", Offset = "0x3B01370", VA = "0x183B02970")]
		public static (a?, b?) APAPAEDYFJC<a, b>([In] this KeyValuePair<a, b> self)
		{
			return default((a, b));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3B02DC0", Offset = "0x3B017C0", VA = "0x183B02DC0")]
		public static KeyValuePair<c?, e?> AXDPTZVZTBX<c, e, d>(this KeyValuePair<c, d> self, e value)
		{
			return default(KeyValuePair<c, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class PJOBKNUFLVR
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class KSZKICSFMPF<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IList<a> MMCEPFULXHD;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public KSZKICSFMPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6901220", Offset = "0x68FFC20", VA = "0x186901220")]
			internal a GJCUBBNOYTT(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3D8FC40", Offset = "0x3D8E640", VA = "0x183D8FC40")]
		public static int SFNHFNZUKVD<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EF70", Offset = "0x3D8D970", VA = "0x183D8EF70")]
		public static int KIGYKVSOUEZ<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D88880", Offset = "0x3D87280", VA = "0x183D88880")]
		public static bool DBZAZSLDWIM<a>(this IList<a> self, a? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CDC0", Offset = "0x3D8B7C0", VA = "0x183D8CDC0")]
		public static void JDWUGDMAJUI<T>(this HashSet<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D8BB00", Offset = "0x3D8A500", VA = "0x183D8BB00")]
		public static void GNYGCKRBZYR<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B7B0", Offset = "0x3D8A1B0", VA = "0x183D8B7B0")]
		public static void GNYGCKRBZYR<T>(this IList<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D8BF40", Offset = "0x3D8A940", VA = "0x183D8BF40")]
		public static void IKQDILESOPD<T>(this List<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D94770", Offset = "0x3D93170", VA = "0x183D94770")]
		public static bool WVLZWYIBJXU<T>(this IList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<T>? removedElements) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D950C0", Offset = "0x3D93AC0", VA = "0x183D950C0")]
		public static List<b> WVLZWYIBJXU<b>(this List<b> a, Predicate<b> b) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D900E0", Offset = "0x3D8EAE0", VA = "0x183D900E0")]
		public static int SFNHFNZUKVD<T>(this IReadOnlyList<T> a, Predicate<T> b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D8ABF0", Offset = "0x3D895F0", VA = "0x183D8ABF0")]
		public static bool FOWJLMLMNGU<T>(this IReadOnlyList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<int>? indices) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D86CA0", Offset = "0x3D856A0", VA = "0x183D86CA0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D86BB0", Offset = "0x3D855B0", VA = "0x183D86BB0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D8A4D0", Offset = "0x3D88ED0", VA = "0x183D8A4D0")]
		public static int DILLCZEIOVT<TElement>(this IList<TElement> a, TElement b, [Optional] Func<TElement, TElement, int>? compare, int c = 0, [Optional] int? d) where TElement : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D89BD0", Offset = "0x3D885D0", VA = "0x183D89BD0")]
		public static int DILLCZEIOVT<TElement, TKey>(this IList<TElement> a, TKey b, Func<TElement, TKey> c, [Optional] Func<TKey, TKey, int>? compare, int d = 0, [Optional] int? e) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D89610", Offset = "0x3D88010", VA = "0x183D89610")]
		public static int DILLCZEIOVT<TElement, TKey>(Func<int, TElement> a, int b, TKey c, Func<TElement, TKey> d, [Optional] Func<TKey, TKey, int>? compare, int e = 0, [Optional] int? f) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D85150", Offset = "0x3D83B50", VA = "0x183D85150")]
		public static int AJYMJUYLMLQ<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3D8AA50", Offset = "0x3D89450", VA = "0x183D8AA50")]
		public static int DRLLVCAMPCE<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3D8C730", Offset = "0x3D8B130", VA = "0x183D8C730")]
		public static bool ITZBOFSRHVW<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3D92FA0", Offset = "0x3D919A0", VA = "0x183D92FA0")]
		public static void UDJHSJIIVKD<T>(this List<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F880", Offset = "0x3D8E280", VA = "0x183D8F880")]
		public static void Remove<T>(this List<T> list, IEnumerable<T> collection) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D92BF0", Offset = "0x3D915F0", VA = "0x183D92BF0")]
		public static c TVUHTGGRAAX<c>(this List<c> a, Predicate<c> b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EC40", Offset = "0x3D8D640", VA = "0x183D8EC40")]
		public static d JPNEDGWZULY<d>(this List<d> a, int b) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D85FC0", Offset = "0x3D849C0", VA = "0x183D85FC0")]
		public static void CWNRYZFGDDX<T>(this List<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D95770", Offset = "0x3D94170", VA = "0x183D95770")]
		public static bool ZNBRLESSHZC<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F460", Offset = "0x3D8DE60", VA = "0x183D8F460")]
		public static bool QUINCQDCUQE<T>(this List<T> a, List<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D85DC0", Offset = "0x3D847C0", VA = "0x183D85DC0")]
		public static e CQFFGXGHPRN<e>(this IList<e> a) where e : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3D852F0", Offset = "0x3D83CF0", VA = "0x183D852F0")]
		public static bool ANJKXYXCWDT<T>(IReadOnlyList<T>? list, int a, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3D93EF0", Offset = "0x3D928F0", VA = "0x183D93EF0")]
		public static bool UPEDHGJBRZD<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D92570", Offset = "0x3D90F70", VA = "0x183D92570")]
		public static void SQZSTFXJYOY<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F150", Offset = "0x3D8DB50", VA = "0x183D8F150")]
		public static bool LIPRFECRVWZ<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3D85450", Offset = "0x3D83E50", VA = "0x183D85450")]
		public static string CLJQFHCQYNO<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D95580", Offset = "0x3D93F80", VA = "0x183D95580")]
		public static T YGLASNMWSCO<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3D94430", Offset = "0x3D92E30", VA = "0x183D94430")]
		public static T WPDLVCUNTEI<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3D853B0", Offset = "0x3D83DB0", VA = "0x183D853B0")]
		public static void AUZBTHUPHZW<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3D88970", Offset = "0x3D87370", VA = "0x183D88970")]
		public static void DHWZBLTJXNW<T>(this IList<T> a, [In] T value) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F1C0", Offset = "0x3D8DBC0", VA = "0x183D8F1C0")]
		public static T PLQCSSURZXV<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class RHBGQAKZWWN
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static float BRUCJTIUQBX;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static float ASUJMZMWLSS;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static bool IEXOWCARQMS;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly float TXLOENACDOO;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5E30", Offset = "0x9AE4830", VA = "0x189AE5E30")]
		public static bool TPDOSJNZZYB(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9AE59C0", Offset = "0x9AE43C0", VA = "0x189AE59C0")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9AE59E0", Offset = "0x9AE43E0", VA = "0x189AE59E0")]
		public static int Clamp(int value, int min, int max)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5DA0", Offset = "0x9AE47A0", VA = "0x189AE5DA0")]
		public static float SMJLKFNGVJC(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5BF0", Offset = "0x9AE45F0", VA = "0x189AE5BF0")]
		public static float Lerp(float a, float b, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9AE60E0", Offset = "0x9AE4AE0", VA = "0x189AE60E0")]
		public static float ZWXVJMWHRWQ(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5A80", Offset = "0x9AE4480", VA = "0x189AE5A80")]
		public static float HTJNLZLPXKZ(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5DC0", Offset = "0x9AE47C0", VA = "0x189AE5DC0")]
		public static float STYTBISWJUI(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5B40", Offset = "0x9AE4540", VA = "0x189AE5B40")]
		public static float HTJNLZLPXKZ(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5E00", Offset = "0x9AE4800", VA = "0x189AE5E00")]
		public static float STYTBISWJUI(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5D80", Offset = "0x9AE4780", VA = "0x189AE5D80")]
		public static float Max(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5F20", Offset = "0x9AE4920", VA = "0x189AE5F20")]
		public static float UHGIMGEFIWQ(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5930", Offset = "0x9AE4330", VA = "0x189AE5930")]
		public static float BXXQOCVIEBZ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5C90", Offset = "0x9AE4690", VA = "0x189AE5C90")]
		public static float MVGEKGOGKSM(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5A00", Offset = "0x9AE4400", VA = "0x189AE5A00")]
		public static float GZORLWHUREK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x525C850", Offset = "0x525B250", VA = "0x18525C850")]
		public static int JLICDDFUQEP(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class JHSNGUFCOAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private System.Random ZSLTGFXXNVN;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2450", Offset = "0x9AE0E50", VA = "0x189AE2450")]
		public JHSNGUFCOAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9AE23D0", Offset = "0x9AE0DD0", VA = "0x189AE23D0")]
		public JHSNGUFCOAS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8FCEE70", Offset = "0x8FCD870", VA = "0x188FCEE70", Slot = "4")]
		public virtual int Next()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9AE23A0", Offset = "0x9AE0DA0", VA = "0x189AE23A0", Slot = "5")]
		public virtual int Next(int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0430", Offset = "0x9ADEE30", VA = "0x189AE0430", Slot = "6")]
		public virtual int Next(int minValue, int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2370", Offset = "0x9AE0D70", VA = "0x189AE2370")]
		public double FXCAEOFTGOU()
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class MKFIBBAQLXM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3C429A0", Offset = "0x3C413A0", VA = "0x183C429A0")]
		[Todo("This should be replaced with the `is not` operator in C# 9.")]
		public static bool AYPCOBDXXYZ<T>(this object a, [Out][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class OSLTMEKMHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3C90", Offset = "0x9AE2690", VA = "0x189AE3C90")]
		public static (float3, float3, float3) KAYKYZOJBAO([In] this quaternion self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3310", Offset = "0x9AE1D10", VA = "0x189AE3310")]
		private static float3 CHUDWBGLJNM(quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4250", Offset = "0x9AE2C50", VA = "0x189AE4250")]
		private static float3 ZWKQBHMNSMD(float3 a, math.RotationOrder b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE41A0", Offset = "0x9AE2BA0", VA = "0x189AE41A0")]
		public static float3 XODBGWRDZGW(this quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3D80", Offset = "0x9AE2780", VA = "0x189AE3D80")]
		public static float MFPUXPMPUVH(this quaternion a, quaternion b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3EC0", Offset = "0x9AE28C0", VA = "0x189AE3EC0")]
		public static quaternion PULBWOKFUJI(this quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3280", Offset = "0x9AE1C80", VA = "0x189AE3280")]
		[CompilerGenerated]
		internal static float3 AEILOHFOAXS(float3 a)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class PZIEZMZJQTA
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class ARESDIMILJU : CTRRBQWZPIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly System.Random CIAZQNPHKWS;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9AE0430", Offset = "0x9ADEE30", VA = "0x189AE0430", Slot = "4")]
			public int Next(int minInclusive, int maxExclusive)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x9AE03C0", Offset = "0x9ADEDC0", VA = "0x189AE03C0", Slot = "5")]
			public float HJVSXKEOLMB(float a, float b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9AE0380", Offset = "0x9ADED80", VA = "0x189AE0380")]
			private double DXDNXTDSJYG()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9AE0460", Offset = "0x9ADEE60", VA = "0x189AE0460")]
			public ARESDIMILJU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly CTRRBQWZPIE DHWYBMYSAMD;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4810", Offset = "0x9AE3210", VA = "0x189AE4810")]
		public static ulong VBXFROCWSUQ()
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class LXXFBUCXZBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A310", Offset = "0x3C18D10", VA = "0x183C1A310")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class WEYTYSOGPSN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x411D3C0", Offset = "0x411BDC0", VA = "0x18411D3C0")]
		public static bool PXAFEIXHWUS<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> a, IReadOnlyDictionary<TKey, TValue> b) where TKey : notnull where TValue : notnull, IEquatable<TValue>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class PTIBBECIRLU
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3D96170", Offset = "0x3D94B70", VA = "0x183D96170")]
		public static a? FBGTNFVJTYB<a, TKey>(this IReadOnlyDictionary<TKey, a> self, TKey key) where a : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class YICIAKYGIWZ
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
				[Cpp2IlInjected.Address(RVA = "0x5D87E50", Offset = "0x5D86850", VA = "0x185D87E50", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly object? KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x5D86F80", Offset = "0x5D85980", VA = "0x185D86F80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xDC3640", Offset = "0xDC2040", VA = "0x180DC3640")]
			private Enumerator(IReadOnlyList<T> list, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x54A5300", Offset = "0x54A3D00", VA = "0x1854A5300")]
			public static Enumerator<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			public readonly void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5D863F0", Offset = "0x5D84DF0", VA = "0x185D863F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x2B95150", Offset = "0x2B93B50", VA = "0x182B95150", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x12DECE0", Offset = "0x12DD6E0", VA = "0x1812DECE0")]
			private Enumerable(Enumerator<T> enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x5CA11C0", Offset = "0x5C9FBC0", VA = "0x185CA11C0")]
			public static Enumerable<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerable<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5CA10F0", Offset = "0x5C9FAF0", VA = "0x185CA10F0", Slot = "4")]
			private IEnumerator<T> KEHYSNFVZBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x5CA10F0", Offset = "0x5C9FAF0", VA = "0x185CA10F0", Slot = "5")]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7170", Offset = "0x9AE5B70", VA = "0x189AE7170")]
		public static void Invoke(this IReadOnlyList<Action> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4138680", Offset = "0x4137080", VA = "0x184138680")]
		public static bool IAMPTCAGJIA<T>(this IReadOnlyList<T> a, int b, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x41389B0", Offset = "0x41373B0", VA = "0x1841389B0")]
		public static bool INALFKTFYIZ<T>(this IReadOnlyList<T> a, int b, [Out] IndexValuePair<T> result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4138B80", Offset = "0x4137580", VA = "0x184138B80")]
		public static T JPMZLMDGOYQ<T>(this IReadOnlyList<T> a, int b, [In] T optB) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4138220", Offset = "0x4136C20", VA = "0x184138220")]
		[CS9ImprovedNullableConstraints("This should return `T?` in C# 9. `default! isn't necessary.")]
		public static T EBFGMWFPDIR<T>(this IReadOnlyList<T> a, int b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4138490", Offset = "0x4136E90", VA = "0x184138490")]
		public static a? FBGTNFVJTYB<a>(this IReadOnlyList<a> self, int a) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4138D20", Offset = "0x4137720", VA = "0x184138D20")]
		public static Enumerable<T> OLBTHYSESIU<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(Enumerable<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class FWTQEZMZBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2EC0", Offset = "0x3AE18C0", VA = "0x183AE2EC0")]
		public static int JZUFNJECDTX<a>([In] this ReadOnlySequence<a> sequence, [In] a value) where a : IEquatable<a>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2970", Offset = "0x3AE1370", VA = "0x183AE2970")]
		public static bool IEMMDTIVEBB<c>([In] this ReadOnlySequence<c> sequence, [In] ReadOnlySpan<c> other) where c : IEquatable<c>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class WQNYSJNYZXX
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4122350", Offset = "0x4120D50", VA = "0x184122350")]
		public static string XQUGYMTKBHH<T>([In] this ReadOnlySpan<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x41218A0", Offset = "0x41202A0", VA = "0x1841218A0")]
		public static string AEBPHJIZKCT<T>([In] this ReadOnlySpan<T> self, string a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct ReadOnlyStopwatch : VYVNYDWJGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly VYVNYDWJGJO _baseStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly long _baseTicks;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long KBNUSLDIWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x9AE6340", Offset = "0x9AE4D40", VA = "0x189AE6340", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double LKQYCKYUJDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9AE61C0", Offset = "0x9AE4BC0", VA = "0x189AE61C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double XVSQAXJELKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9AE6280", Offset = "0x9AE4C80", VA = "0x189AE6280")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B720", Offset = "0x1E5A120", VA = "0x181E5B720")]
		public ReadOnlyStopwatch(VYVNYDWJGJO baseStopwatch, long baseTicks)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class WWAHDLMLQYI
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static VYVNYDWJGJO IBQWLTUPASJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x9AE6FB0", Offset = "0x9AE59B0", VA = "0x189AE6FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6EA0", Offset = "0x9AE58A0", VA = "0x189AE6EA0")]
		public static long FBRXZXGHJYM(this VYVNYDWJGJO a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6E10", Offset = "0x9AE5810", VA = "0x189AE6E10")]
		public static double EIYIABFAMBK(this VYVNYDWJGJO a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7000", Offset = "0x9AE5A00", VA = "0x189AE7000")]
		public static double ZPBNTMENLMN(this VYVNYDWJGJO a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6F30", Offset = "0x9AE5930", VA = "0x189AE6F30")]
		public static ReadOnlyStopwatch IOGGRPRPBZL(this VYVNYDWJGJO a)
		{
			return default(ReadOnlyStopwatch);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class FMVRQZAUGIU : VYVNYDWJGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Stopwatch WCIISHSKIWQ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public long KBNUSLDIWAW
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE1B60", Offset = "0x9AE0560", VA = "0x189AE1B60", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		private FMVRQZAUGIU(Stopwatch a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1B00", Offset = "0x9AE0500", VA = "0x189AE1B00")]
		public static FMVRQZAUGIU AWJIMTZVOKD(Stopwatch a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1B80", Offset = "0x9AE0580", VA = "0x189AE1B80")]
		public static FMVRQZAUGIU XUFYEXAMSIO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class ZRRVIAOVENN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x99C7EE0", Offset = "0x99C68E0", VA = "0x1899C7EE0")]
		public static float3 up([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x99C7DB0", Offset = "0x99C67B0", VA = "0x1899C7DB0")]
		public static float3 WTAXRICYMPT([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x13C19B0", Offset = "0x13C03B0", VA = "0x1813C19B0")]
		public static (float3, float3, float3) YXMHMBVLYNU([In] this RigidTransform self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7400", Offset = "0x9AE5E00", VA = "0x189AE7400")]
		public static RigidTransform XICPUXKTFAM([In] this RigidTransform self)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class OIUPAXTMSSX
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9AE31C0", Offset = "0x9AE1BC0", VA = "0x189AE31C0")]
		public static RigidTransform XOITDQMCRBG(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class MHDNHPGTPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3090", Offset = "0x9AE1A90", VA = "0x189AE3090")]
		public static float HVVHQPIPXEB([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3080", Offset = "0x9AE1A80", VA = "0x189AE3080")]
		public static int FFQLGOVVYQW(this float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9AE30D0", Offset = "0x9AE1AD0", VA = "0x189AE30D0")]
		public static (byte, byte, byte, byte) WSGBAZDQOOY(this float a)
		{
			return default((byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class GDYTOANSUHR
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4AD0", Offset = "0x3AF34D0", VA = "0x183AF4AD0")]
		public static ReadOnlySpan<a?> TVBKTQGFCHU<a>([In] this Span<a> self)
		{
			return default(ReadOnlySpan<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class RBLJVLMLPQP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9AE50D0", Offset = "0x9AE3AD0", VA = "0x189AE50D0")]
		public static StringBuilder IREMOGFIPOK(this StringBuilder a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5060", Offset = "0x9AE3A60", VA = "0x189AE5060")]
		public static StringBuilder HDULHONYJDT(this StringBuilder a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5130", Offset = "0x9AE3B30", VA = "0x189AE5130")]
		public static StringBuilder KORXZVTOONY(this StringBuilder a, char b, int c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class ERGCADBQEVS
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly Regex TZMUABBNGRK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static Regex PWCBFCKMBNE;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static Regex PGGTVPFMXVF;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly char[] WJHZXRZDMIE;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly string[] DNPQVZEPDZJ;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8C14090", Offset = "0x8C12A90", VA = "0x188C14090")]
		public static bool LIPRFECRVWZ(this string? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE11A0", Offset = "0x9ADFBA0", VA = "0x189AE11A0")]
		public static string? LMEZXNPAGPY(this string? a, int b, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1490", Offset = "0x9ADFE90", VA = "0x189AE1490")]
		public static string UDLSESZVFLG(this string a, int b, string c = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1130", Offset = "0x9ADFB30", VA = "0x189AE1130")]
		public static int LIKISFLMUFY(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1310", Offset = "0x9ADFD10", VA = "0x189AE1310")]
		public static string PKDHSRVJZJJ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1260", Offset = "0x9ADFC60", VA = "0x189AE1260")]
		public static string OJDENKVEZVT(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1520", Offset = "0x9ADFF20", VA = "0x189AE1520")]
		public static string[] VYQFLSABFVZ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0B80", Offset = "0x9ADF580", VA = "0x189AE0B80")]
		private static bool AUEGJJRCJDE(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0C50", Offset = "0x9ADF650", VA = "0x189AE0C50")]
		private static bool FJUMMYAKQSB(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0DB0", Offset = "0x9ADF7B0", VA = "0x189AE0DB0")]
		public static int JESJMGIRMYE(string a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class PQVDUYMERXN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9AE47E0", Offset = "0x9AE31E0", VA = "0x189AE47E0")]
		public static bool PGGVRUKVNLC(this Type a, Type b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3D95DC0", Offset = "0x3D947C0", VA = "0x183D95DC0")]
		public static bool PGGVRUKVNLC<T>(this Type a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class RRDKYQORDIY
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8876270", Offset = "0x8874C70", VA = "0x188876270")]
		public static uint XIKHEMXXNCK(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8953A40", Offset = "0x8952440", VA = "0x188953A40")]
		public static uint QKUMTNCVUEH(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE61B0", Offset = "0x9AE4BB0", VA = "0x189AE61B0")]
		public static uint UAHNHFXWEMB(this uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x99AABD0", Offset = "0x99A95D0", VA = "0x1899AABD0")]
		public static int FFQLGOVVYQW(this uint a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.NumberStrings
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class QXPBJMOTBJR
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4D80", Offset = "0x9AE3780", VA = "0x189AE4D80")]
		public static string DCRWHIVBXGI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4F50", Offset = "0x9AE3950", VA = "0x189AE4F50")]
		public static string ZJFKQHEZFGZ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4E90", Offset = "0x9AE3890", VA = "0x189AE4E90")]
		private static string YDKRCJAEZSE(double a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class UVMJVYYLOPV
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x40A6F30", Offset = "0x40A5930", VA = "0x1840A6F30")]
		public static a WUXSMSQTLXA<a>(IEnumerable<string> flagStrings, [Optional] a a) where a : struct, Enum, IConvertible
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x40A6150", Offset = "0x40A4B50", VA = "0x1840A6150")]
		public static b MCELZZJOBRF<b>(IEnumerable<string> flagStrings, [Optional] b a) where b : struct, Enum, IConvertible
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x40A69D0", Offset = "0x40A53D0", VA = "0x1840A69D0")]
		public static c TVNLHRNYKYG<c>(IEnumerable<string> flagStrings, [Optional] c a) where c : struct, Enum, IConvertible
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x40975F0", Offset = "0x4095FF0", VA = "0x1840975F0")]
		private static bool JXUJFATXVEV(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class RIIHJQZFDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3E67D20", Offset = "0x3E66720", VA = "0x183E67D20")]
		public static bool GRGOHOJISGC<a>([In] this a? self, [Out] a a) where a : struct
		{
			return default(bool);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime.Stats
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class KPLKJKSBPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9AE24D0", Offset = "0x9AE0ED0", VA = "0x189AE24D0")]
		public static StatsResults BJGYWWRUELH(IReadOnlyList<float> a, int b = -1, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2A50", Offset = "0x9AE1450", VA = "0x189AE2A50")]
		private static StatsResults VQALJNUKOVW(IReadOnlyList<float> a, int b, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9AE25E0", Offset = "0x9AE0FE0", VA = "0x189AE25E0")]
		private static float LMRUKZAEIDR(IReadOnlyList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2730", Offset = "0x9AE1130", VA = "0x189AE2730")]
		public static float RLFVKOWIXSG(IReadOnlyList<float> a, int b, int c)
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
		[Cpp2IlInjected.Address(RVA = "0x9AE4B30", Offset = "0x9AE3530", VA = "0x189AE4B30")]
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
		private sealed class RCQETGYQWAN : IEnumerable<(StatResultFlags, float)>, IEnumerable, IEnumerator<(StatResultFlags, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private (StatResultFlags flag, float result) AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private StatResultFlags XHLSMLWWHCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public StatResultFlags WXAERSJUDCY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public StatsResults AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public StatsResults CYUPCHVBHXZ;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private (StatResultFlags, float) NEVMZLQVLBN
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x141DD80", Offset = "0x141C780", VA = "0x18141DD80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((StatResultFlags, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x9AE58A0", Offset = "0x9AE42A0", VA = "0x189AE58A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6588600", Offset = "0x6587000", VA = "0x186588600")]
			[DebuggerHidden]
			public RCQETGYQWAN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9AE5260", Offset = "0x9AE3C60", VA = "0x189AE5260", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9AE58F0", Offset = "0x9AE42F0", VA = "0x189AE58F0", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9AE5190", Offset = "0x9AE3B90", VA = "0x189AE5190", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(StatResultFlags, float)> NJFAEBPDQBW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9AE5190", Offset = "0x9AE3B90", VA = "0x189AE5190", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
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
		public float AAOYSORIYKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9AE6BC0", Offset = "0x9AE55C0", VA = "0x189AE6BC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FURXVFBYDUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9AE6BE0", Offset = "0x9AE55E0", VA = "0x189AE6BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6CA0", Offset = "0x9AE56A0", VA = "0x189AE6CA0")]
		public StatsResults(int n, int hitchN, float hitchThreshold, float hitchThresholdOffset, float min, float max, float mean, float median, float varianceSum, float lowerQuartile, float upperQuartile, PercentileResults percentileResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6C00", Offset = "0x9AE5600", VA = "0x189AE6C00")]
		[IteratorStateMachine(typeof(RCQETGYQWAN))]
		public IEnumerable<(StatResultFlags, float)> PDPPBLNNWOC(StatResultFlags a)
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
