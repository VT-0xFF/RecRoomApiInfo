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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9983D90", Offset = "0x9982B90", VA = "0x189983D90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class DGFYGHCKCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly string[] MLWFUEGLCNW;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9980BE0", Offset = "0x997F9E0", VA = "0x189980BE0")]
		public static bool IJIVFTYWAMY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99809C0", Offset = "0x997F7C0", VA = "0x1899809C0")]
		private static bool EFOYONJKGWO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9980A90", Offset = "0x997F890", VA = "0x189980A90")]
		public static bool EFOYONJKGWO(Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9980CB0", Offset = "0x997FAB0", VA = "0x189980CB0")]
		public static string WZRPIOLFBKV(string a, string b = "", bool c = true)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class RSJQIRTQWGW
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9984F10", Offset = "0x9983D10", VA = "0x189984F10")]
		public static string OCFLOPDSCXD(this Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9984E70", Offset = "0x9983C70", VA = "0x189984E70")]
		public static string OCFLOPDSCXD(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9984DA0", Offset = "0x9983BA0", VA = "0x189984DA0")]
		public static byte[] KDGAGGJGRCE(string a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class QQFOEUKKBIF
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate int CompareDelegate<T>([In] T lhs, [In] T rhs);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate U BreakDelegate<T, U>(int numberOfParts, int partIndex, [In] ReadOnlySpan<T> part);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E292F0", Offset = "0x3E280F0", VA = "0x183E292F0")]
		public static ReadOnlyMemory<T> GCPDBORXGEM<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyMemory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E293E0", Offset = "0x3E281E0", VA = "0x183E293E0")]
		public static ReadOnlySpan<T> GUOUWQVGAHZ<T>(this T[] a, int b) where T : notnull
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E29E50", Offset = "0x3E28C50", VA = "0x183E29E50")]
		public static T[] LPIZWTRWDUR<T>(int a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3E2AE90", Offset = "0x3E29C90", VA = "0x183E2AE90")]
		public static void RHTVVVQZPBG<T>(this T[] a, T b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B140", Offset = "0x3E29F40", VA = "0x183E2B140")]
		public static T[] Remove<T>(this T[] originalArray, int index) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3E28250", Offset = "0x3E27050", VA = "0x183E28250")]
		public static void EEGDIRZNZAY<T>(this T[] a, int b, int c) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BDA0", Offset = "0x3E2ABA0", VA = "0x183E2BDA0")]
		public static void VETILFNLZDR<T>(this T[] a, CompareDelegate<T> b, [Optional] T[]? preallocatedWorkBuffer) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A5B0", Offset = "0x3E293B0", VA = "0x183E2A5B0")]
		private static void PRCSDBSBPEB<T>(this T[] a, int b, int c, T[] d, bool e, CompareDelegate<T> f) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3E29EE0", Offset = "0x3E28CE0", VA = "0x183E29EE0")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3E294B0", Offset = "0x3E282B0", VA = "0x183E294B0")]
		public static void JWYNATAELIG<T>(this T[] a, int b, int c, CompareDelegate<T> d) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BCE0", Offset = "0x3E2AAE0", VA = "0x183E2BCE0")]
		public static T[] Sort<T>(this T[] array) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3E288D0", Offset = "0x3E276D0", VA = "0x183E288D0")]
		public static T[] FWMHMIXNCAA<T>(this T[] a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B250", Offset = "0x3E2A050", VA = "0x183E2B250")]
		public static T[] SKAECBRFJKU<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BFE0", Offset = "0x3E2ADE0", VA = "0x183E2BFE0")]
		public static T[] VXBAQMYNMFK<T>(this T[] a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E28300", Offset = "0x3E27100", VA = "0x183E28300")]
		public static T[] FRLLIGEDLJU<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E27A90", Offset = "0x3E26890", VA = "0x183E27A90")]
		public static U[] Break<U, T>(this T[] items, int maxItemsPerPart, BreakDelegate<T, U> xForm) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99848D0", Offset = "0x99836D0", VA = "0x1899848D0")]
		public static byte[] GJJHVZYCDJW(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9984B30", Offset = "0x9983930", VA = "0x189984B30")]
		public static byte[] TIAGGZCVAMY(this byte[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ZLVLMIXFZHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9984D90", Offset = "0x9983B90", VA = "0x189984D90")]
		public static byte UTIPRYHXBWU(this bool a)
		{
			return default(byte);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class RBPNADZKNXU
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9984D90", Offset = "0x9983B90", VA = "0x189984D90")]
		public static bool GVTMDGIFTTQ(this byte a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ETKSMOHCOOY
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3937030", Offset = "0x3935E30", VA = "0x183937030")]
		public static void QAAXATRKPYJ<T>(this ICollection<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39364A0", Offset = "0x39352A0", VA = "0x1839364A0")]
		public static void BNTUEEHBYLN<T>(this ICollection<T> a) where T : notnull, IDisposable
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class NOKLNBYKAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D45150", Offset = "0x3D43F50", VA = "0x183D45150")]
		public static V NUBGZHUSWFC<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D446E0", Offset = "0x3D434E0", VA = "0x183D446E0")]
		public static V NUBGZHUSWFC<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D44490", Offset = "0x3D43290", VA = "0x183D44490")]
		public static void KJZCMAAZRMO<K, V>(this IDictionary<K, List<V>> a, [In] K key, [In] V value) where K : notnull where V : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D46470", Offset = "0x3D45270", VA = "0x183D46470")]
		public static TVal WEZWPWCRGIB<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] TVal defaultValue) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D47160", Offset = "0x3D45F60", VA = "0x183D47160")]
		public static TVal WEZWPWCRGIB<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, Func<TVal> b) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3D430E0", Offset = "0x3D41EE0", VA = "0x183D430E0")]
		public static b CSDZVHFIPXV<b, a>(this IDictionary<a, b> a, [In] a key, [Optional][In][CS9ImprovedNullableConstraints("`default!` and null-oblivious region shouldn't be necessary in C# 9")] b defaultValue)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D45420", Offset = "0x3D44220", VA = "0x183D45420")]
		public static V Take<V, K>(this IDictionary<K, V> self, [In] K key) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D43E10", Offset = "0x3D42C10", VA = "0x183D43E10")]
		public static T2[] GVVLPKOYPSV<T2, T1>(this Dictionary<T1, T2>.ValueCollection a) where T2 : notnull where T1 : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class NKANIIETZHA
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
			[Cpp2IlInjected.Address(RVA = "0x78CD290", Offset = "0x78CC090", VA = "0x1878CD290")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) One(T one)
			{
				return default((bool, T, IEnumerable<T>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x78CD080", Offset = "0x78CBE80", VA = "0x1878CD080")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) IECEUAJQNRY(IEnumerable<T> a)
			{
				return default((bool, T, IEnumerable<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class YGNJGVHAJNB<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HashSet<a> XVTMYZIKUTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HashSet<a> SSMMYNPLQCH;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public YGNJGVHAJNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x509AFA0", Offset = "0x5099DA0", VA = "0x18509AFA0")]
			internal bool HZWNPRVOWVJ(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x509AE40", Offset = "0x5099C40", VA = "0x18509AE40")]
			internal bool HZRGSLBRNKA(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class WRULZRGRECD<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private a OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private ISet<a> NZGXUSLZNYT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ISet<a> OKSUAWVOHVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IEnumerable<a> FMJAVNDMHPS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IEnumerable<a> PMZWKSOSSDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private IEnumerator<a> ULWCKXMDKCB;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private a HTALOBYUKAE
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x131D930", Offset = "0x131C730", VA = "0x18131D930", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x663E690", Offset = "0x663D490", VA = "0x18663E690", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x15A3320", Offset = "0x15A2120", VA = "0x1815A3320")]
			[DebuggerHidden]
			public WRULZRGRECD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x85B68D0", Offset = "0x85B56D0", VA = "0x1885B68D0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x85B64C0", Offset = "0x85B52C0", VA = "0x1885B64C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x85B6A60", Offset = "0x85B5860", VA = "0x1885B6A60")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x65BF9A0", Offset = "0x65BE7A0", VA = "0x1865BF9A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> EJVKVOJRYRR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x85B6AB0", Offset = "0x85B58B0", VA = "0x1885B6AB0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class QVFDIFFRLBD<a, b> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private a OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private IEnumerable<a> FAZYPCYHAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IEnumerable<a> RNCLEYXITXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private IEnumerable<b> NSYGDMVSVYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IEnumerable<b> GKPEYFIXWWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private a WFJKKFOXGIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public a PGCKDLFCMJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private IEnumerator<a> TVZEGXMAPEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IEnumerator<b> EMSBKJALTRF;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private a HTALOBYUKAE
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x5102FF0", Offset = "0x5101DF0", VA = "0x185102FF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x75FA3F0", Offset = "0x75F91F0", VA = "0x1875FA3F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x65C8910", Offset = "0x65C7710", VA = "0x1865C8910")]
			[DebuggerHidden]
			public QVFDIFFRLBD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x75FB790", Offset = "0x75FA590", VA = "0x1875FB790", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x75FB330", Offset = "0x75FA130", VA = "0x1875FB330", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x75FC080", Offset = "0x75FAE80", VA = "0x1875FC080")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x75FBEA0", Offset = "0x75FACA0", VA = "0x1875FBEA0")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x75FA0B0", Offset = "0x75F8EB0", VA = "0x1875FA0B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> EJVKVOJRYRR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x75FC0E0", Offset = "0x75FAEE0", VA = "0x1875FC0E0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class ZNKHHKCOSOM<a> : IEnumerable<(a, Option<a>)>, IEnumerable, IEnumerator<(a, Option<a>)>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private (a Current, Option<a> Next) OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerable<a> FAZYPCYHAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IEnumerable<a> RNCLEYXITXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerator<a> HBDFKZHIFTC;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private (a, Option<a>) WCJWXERNZOD
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x2E03050", Offset = "0x2E01E50", VA = "0x182E03050", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, Option<a>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x5119DF0", Offset = "0x5118BF0", VA = "0x185119DF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2E03370", Offset = "0x2E02170", VA = "0x182E03370")]
			[DebuggerHidden]
			public ZNKHHKCOSOM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x511AD20", Offset = "0x5119B20", VA = "0x18511AD20", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5119E40", Offset = "0x5118C40", VA = "0x185119E40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x511AF50", Offset = "0x5119D50", VA = "0x18511AF50")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x511B090", Offset = "0x5119E90", VA = "0x18511B090", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, Option<a>)> XZUXXFDMBNO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x511AFD0", Offset = "0x5119DD0", VA = "0x18511AFD0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class PYYINOFUQMV<a, b> : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private b OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<a> FAZYPCYHAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<a> RNCLEYXITXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> BIMCTFFCMVK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> KCZZOQERKPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<a> ULWCKXMDKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private IEnumerator<b> ULGHTDELHUA;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private b JFMGJKDFHGR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public PYYINOFUQMV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x73B8E30", Offset = "0x73B7C30", VA = "0x1873B8E30", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x73B8860", Offset = "0x73B7660", VA = "0x1873B8860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x73B91E0", Offset = "0x73B7FE0", VA = "0x1873B91E0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x73B8FD0", Offset = "0x73B7DD0", VA = "0x1873B8FD0")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x64B1CA0", Offset = "0x64B0AA0", VA = "0x1864B1CA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> AHCSEPJDIGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x73B9230", Offset = "0x73B8030", VA = "0x1873B9230", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class TVWIEZAPIDU<a, b> : IEnumerable<(a, b)>, IEnumerable, IEnumerator<(a, b)>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private (a Lhs, b Rhs) OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private IEnumerable<a> GNPSYKEKVGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IEnumerable<a> JWAXBOTAMRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IEnumerable<b> WANHLSLBVPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IEnumerable<b> KJCUSKNWWIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private IEnumerator<a> DZTLDEPLOCU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private IEnumerator<b> FHJACSNMIVH;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private (a, b) UJHGRENNHZK
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x7A21A50", Offset = "0x7A20850", VA = "0x187A21A50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1D13E20", Offset = "0x1D12C20", VA = "0x181D13E20")]
			[DebuggerHidden]
			public TVWIEZAPIDU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7A28DB0", Offset = "0x7A27BB0", VA = "0x187A28DB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x64C3AB0", Offset = "0x64C28B0", VA = "0x1864C3AB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, b)> IPSFLHQIJJJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7A29510", Offset = "0x7A28310", VA = "0x187A29510", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FF20", Offset = "0x3D1ED20", VA = "0x183D1FF20")]
		public static bool All<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9983C70", Offset = "0x9982A70", VA = "0x189983C70")]
		public static bool All(this IEnumerable<bool> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D26FF0", Offset = "0x3D25DF0", VA = "0x183D26FF0")]
		public static U MXQAVFLUZOB<U, T>(this IEnumerable<T> a, Func<U> b, Func<T, U> c, Func<IEnumerable<T>, U> d) where U : notnull where T : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3D203F0", Offset = "0x3D1F1F0", VA = "0x183D203F0")]
		public static bool Any<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F7A0", Offset = "0x3D3E5A0", VA = "0x183D3F7A0")]
		public static U YNONMQZUOFV<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgAmountSwitchZeroDelegate<TArg, U> b, ArgAmountSwitchOneDelegate<TArg, T, U> c, ArgAmountSwitchManyDelegate<TArg, T, U> d) where U : notnull where T : notnull where TArg : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CF70", Offset = "0x3D3BD70", VA = "0x183D3CF70")]
		public static IEnumerable<U> TURZFUWPQOH<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgSelectDelegate<TArg, T, U> b) where U : notnull where T : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D28930", Offset = "0x3D27730", VA = "0x183D28930")]
		public static IEnumerable<T> OHNGNBMSZNT<T>(params IEnumerable<T>[] enumerables) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D4C0", Offset = "0x3D3C2C0", VA = "0x183D3D4C0")]
		public static bool UHCYTINMTHF<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D21290", Offset = "0x3D20090", VA = "0x183D21290")]
		public static IEnumerable<(a?, b?)>? GOVGFDFUBYG<a, b>(this IEnumerable<KeyValuePair<a, b>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3D26250", Offset = "0x3D25050", VA = "0x183D26250")]
		public static IEnumerable<T> KNEUGUNAXYE<T, TKey>(this IEnumerable<T> a, Func<T, TKey> b) where T : notnull where TKey : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A0DBE0", Offset = "0x3A0C9E0", VA = "0x183A0DBE0")]
		[IteratorStateMachine(typeof(WRULZRGRECD<>))]
		public static IEnumerable<T> UBSWWLTPTRT<T>(this IEnumerable<T> a, ISet<T> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3D21410", Offset = "0x3D20210", VA = "0x183D21410")]
		[IteratorStateMachine(typeof(QVFDIFFRLBD<, >))]
		public static IEnumerable<T> IBUALPVWMCR<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T with) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F2B0", Offset = "0x3D3E0B0", VA = "0x183D3F2B0")]
		public static T XWDJAGAMYWA<T>(this IEnumerable<T> a, T b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F370", Offset = "0x3D3E170", VA = "0x183D3F370")]
		public static T XWDJAGAMYWA<T>(this IEnumerable<T> a, T b, Func<T, bool> c) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DA30", Offset = "0x3D3C830", VA = "0x183D3DA30")]
		public static c? VQJWKMDTNHH<c>(this IEnumerable<c> self, Func<c, bool> predicate) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3D268B0", Offset = "0x3D256B0", VA = "0x183D268B0")]
		public static void MFZKSPSXRIB<T>(this IEnumerable<T> a, Action<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3D28AB0", Offset = "0x3D278B0", VA = "0x183D28AB0")]
		[IteratorStateMachine(typeof(ZNKHHKCOSOM<>))]
		public static IEnumerable<(T, Option<T>)> OIYXQCFVBEC<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D29040", Offset = "0x3D27E40", VA = "0x183D29040")]
		public static bool PJVAUYEFCJR<T>(this IEnumerable<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3D21DF0", Offset = "0x3D20BF0", VA = "0x183D21DF0")]
		public static IEnumerable<IndexValuePair<T>> Index<T>(this IEnumerable<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D229F0", Offset = "0x3D217F0", VA = "0x183D229F0")]
		public static bool IsEmpty<T>(this IEnumerable<T> self) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3D211E0", Offset = "0x3D1FFE0", VA = "0x183D211E0")]
		public static IEnumerable<T> FWUXUFLZHAG<T>(this IEnumerable<T>? self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3991E50", Offset = "0x3990C50", VA = "0x183991E50")]
		[IteratorStateMachine(typeof(PYYINOFUQMV<, >))]
		public static IEnumerable<U> XTWVUTLFUXP<U, T>(this IEnumerable<T> a, Func<SelectAmountPicker<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D207D0", Offset = "0x3D1F5D0", VA = "0x183D207D0")]
		public static IEnumerable<T> DGNFTIYHICC<T>(this IEnumerable<IEnumerable<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D25910", Offset = "0x3D24710", VA = "0x183D25910")]
		public static int JXXSEITUJDT<T>(this IEnumerable<T> a, int b = 0) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D20E50", Offset = "0x3D1FC50", VA = "0x183D20E50")]
		public static bool EFGIIOGBNNH<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D3FBB0", Offset = "0x3D3E9B0", VA = "0x183D3FBB0")]
		public static IEnumerable<T> YPKEAIPOPLT<T>(this IEnumerable<T> a, int b, int c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3D252E0", Offset = "0x3D240E0", VA = "0x183D252E0")]
		public static (IEnumerable<T>, IEnumerable<T>) JOUHVRQDQAX<T>(this IEnumerable<T> a, Func<T, bool> b) where T : notnull
		{
			return default((IEnumerable<T>, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3D29340", Offset = "0x3D28140", VA = "0x183D29340")]
		public static string QFPEPEWSFZY<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3D297E0", Offset = "0x3D285E0", VA = "0x183D297E0")]
		public static string QFPEPEWSFZY<T>(this IEnumerable<T> a, Func<T, string> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B060", Offset = "0x3D29E60", VA = "0x183D2B060")]
		public static Dictionary<d?, e?>? SUFGMSJXSHW<d, e>(this IEnumerable<KeyValuePair<d, e>> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C0F0", Offset = "0x3D2AEF0", VA = "0x183D2C0F0")]
		public static Dictionary<f?, g?>? SUFGMSJXSHW<f, g>(this IEnumerable<(f Key, g Value)> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3D21690", Offset = "0x3D20490", VA = "0x183D21690")]
		public static List<T> IWQXBOMVHAM<T>(this IEnumerable<T> a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3D205A0", Offset = "0x3D1F3A0", VA = "0x183D205A0")]
		public static string BUQIBNRACUU<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3D40220", Offset = "0x3D3F020", VA = "0x183D40220")]
		public static (IReadOnlyList<h?>?, IReadOnlyList<i?>?) YRISYPJXDRP<h, i>(this IEnumerable<(h Lhs, i Rhs)> self)
		{
			return default((IReadOnlyList<h>, IReadOnlyList<i>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3A06910", Offset = "0x3A05710", VA = "0x183A06910")]
		[IteratorStateMachine(typeof(TVWIEZAPIDU<, >))]
		public static IEnumerable<(T, U)> NNPAJBICXNC<T, U>(this IEnumerable<T> a, IEnumerable<U> b) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E650", Offset = "0x3D3D450", VA = "0x183D3E650")]
		public static IEnumerable<V> XUGDLPRBRIE<V, T, U>(this IEnumerable<T> a, IEnumerable<U> b, Func<T, U, V> c, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where V : notnull where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E700", Offset = "0x3D3D500", VA = "0x183D3E700")]
		public static IEnumerable<(T, U)> XUGDLPRBRIE<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E3D0", Offset = "0x3D3D1D0", VA = "0x183D3E3D0")]
		public static TOut[] XSACBDBRIDX<TOut, TIn>(this IEnumerable<TIn> a, Func<TIn, TOut> b) where TOut : notnull where TIn : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3D27A90", Offset = "0x3D26890", VA = "0x183D27A90")]
		public static Option<U> OCQPSVNDXWB<U, T>(this IEnumerable<T> a, Func<T, U> b) where U : notnull where T : notnull
		{
			return default(Option<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3D28E00", Offset = "0x3D27C00", VA = "0x183D28E00")]
		public static void OOTVWZPWSFH<T>(this IEnumerable<T> a) where T : notnull, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3D23FF0", Offset = "0x3D22DF0", VA = "0x183D23FF0")]
		public static IEnumerable<KeyValuePair<TKey, List<TItem>>> JACSQGBPAZP<TKey, TItem>(this IEnumerable<IEnumerable<TItem>> a, Func<TItem, TKey> b) where TKey : notnull where TItem : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class EEJVPEPYRSC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x392F080", Offset = "0x392DE80", VA = "0x18392F080")]
		public static bool WMRKZERCVTY<T, U>(this T a, [In] U obj) where T : notnull, IEquatable<T> where U : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x392ECE0", Offset = "0x392DAE0", VA = "0x18392ECE0")]
		public static bool GRZLWPBEJFV<a>(a a, a b) where a : class, IEquatable<a>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class TBSECJKJIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x15BA380", Offset = "0x15B9180", VA = "0x1815BA380")]
		public static bool ONEGSRGKENB([In] this float3 a, float3 a, float b = 1E-05f)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class FNALEKBFLCW
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9981D90", Offset = "0x9980B90", VA = "0x189981D90")]
		public static float3 TFGENJZLOEV([In] this float4x4 localToWorld, [In] float3 point)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9981CB0", Offset = "0x9980AB0", VA = "0x189981CB0")]
		public static float3 HXAVYAUDZYL([In] this float4x4 localToWorld, [In] float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class NNQIYFWRYEV
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class KHGRUXUTHJV<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private a OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private a FAZYPCYHAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public a RNCLEYXITXO;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a HTALOBYUKAE
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6651620", Offset = "0x6650420", VA = "0x186651620", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x1D13E20", Offset = "0x1D12C20", VA = "0x181D13E20")]
			[DebuggerHidden]
			public KHGRUXUTHJV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x67946E0", Offset = "0x67934E0", VA = "0x1867946E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6794580", Offset = "0x6793380", VA = "0x186794580", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> EJVKVOJRYRR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6794730", Offset = "0x6793530", VA = "0x186794730", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D42860", Offset = "0x3D41660", VA = "0x183D42860")]
		public static void JHLQMXLVQVD<a>(this a a, Action<a> b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D42350", Offset = "0x3D41150", VA = "0x183D42350")]
		public static V AWCDIRGICEC<V, b>(this b a, Func<b, V> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] V defaultValue) where V : notnull where b : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D42610", Offset = "0x3D41410", VA = "0x183D42610")]
		public static c? HJCZSUDWRAM<c>(this c a) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D42BC0", Offset = "0x3D419C0", VA = "0x183D42BC0")]
		[IteratorStateMachine(typeof(KHGRUXUTHJV<>))]
		public static IEnumerable<T> WSPTCLNNVZH<T>(this T a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D428B0", Offset = "0x3D416B0", VA = "0x183D428B0")]
		public static T[] LAYGJKCJTJK<T>(this T a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class NCWZLMZAHTV
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly MD5 WVXPIGSCDHV;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly SHA1 XSLSQMUPNFK;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly byte[] VIVXHGVUAJS;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly byte[] ELTSPLJCPYK;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9983800", Offset = "0x9982600", VA = "0x189983800")]
		static NCWZLMZAHTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9983660", Offset = "0x9982460", VA = "0x189983660")]
		public static Guid VTKZFQZWVFQ([In] Guid a, [In] Guid b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9983710", Offset = "0x9982510", VA = "0x189983710")]
		public static Guid VTKZFQZWVFQ([In] Guid a, [In] Guid b, [In] Guid c)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D1ACF0", Offset = "0x3D19AF0", VA = "0x183D1ACF0")]
		public static Guid Create<T>([In] Guid namespaceId, T value, int version = 5) where T : struct
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9983480", Offset = "0x9982280", VA = "0x189983480")]
		public static Guid Create([In] Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9983130", Offset = "0x9981F30", VA = "0x189983130")]
		private static Guid Create([In] Guid namespaceId, byte[] value, int length, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B2E0", Offset = "0x3D1A0E0", VA = "0x183D1B2E0")]
		private static void UUCRAPWMRDN<T>([In] T src, Span<byte> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B5F0", Offset = "0x3D1A3F0", VA = "0x183D1B5F0")]
		private static T XYHCHXIOAQR<T>(Span<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9983550", Offset = "0x9982350", VA = "0x189983550")]
		private static void EURCMYWQDGT(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9983610", Offset = "0x9982410", VA = "0x189983610")]
		private static void REFPGVKKDCZ(byte[] a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class VOARQCJAOUW
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9985E20", Offset = "0x9984C20", VA = "0x189985E20")]
		public static int NYQJMQEDGUI(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9985DA0", Offset = "0x9984BA0", VA = "0x189985DA0")]
		public static int ASFWQBRMYBK(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9985E90", Offset = "0x9984C90", VA = "0x189985E90")]
		public static int OXFBCICQYPY(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9985F70", Offset = "0x9984D70", VA = "0x189985F70")]
		public static int ZWECCRUHEZT(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x87014E0", Offset = "0x87002E0", VA = "0x1887014E0")]
		public static int NHNPRZLFCKX(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x87DFFC0", Offset = "0x87DEDC0", VA = "0x1887DFFC0")]
		public static int RJWNSPFEHCE(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9985DE0", Offset = "0x9984BE0", VA = "0x189985DE0")]
		public static float AUGQPLVKKNQ(this int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9985F00", Offset = "0x9984D00", VA = "0x189985F00")]
		public static (byte, byte, byte, byte) VYJUNIPTHMX(this int a)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9985E00", Offset = "0x9984C00", VA = "0x189985E00")]
		public static int NOMXPFDVPYF([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9985EF0", Offset = "0x9984CF0", VA = "0x189985EF0")]
		public static int TCQHCIMTRCF(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9985EE0", Offset = "0x9984CE0", VA = "0x189985EE0")]
		public static int QAKBIUCINEO(this int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class WUMBVDXRKIT
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9986230", Offset = "0x9985030", VA = "0x189986230")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) VYJUNIPTHMX(this long a)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9985F80", Offset = "0x9984D80", VA = "0x189985F80")]
		public static long AIXCNNXZZYK([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9985FD0", Offset = "0x9984DD0", VA = "0x189985FD0")]
		public static string GNIYOFVXFAZ(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9986030", Offset = "0x9984E30", VA = "0x189986030")]
		public static string IMMKBIFDRLC(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x99861C0", Offset = "0x9984FC0", VA = "0x1899861C0")]
		public static string TMRRCKXTCQD(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x99860A0", Offset = "0x9984EA0", VA = "0x1899860A0")]
		public static string KEOXSJXWGWD(this long a, long b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface UCGLINRHHGX
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Next(int minValue, int maxValue);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float MDDROTMVWKQ(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface GDMUHHRAWUF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		long BKMNAZKSZNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class GUQPELHAEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3A90", Offset = "0x3AC2890", VA = "0x183AC3A90")]
		public static (a?, b?) FFPIKGCINGH<a, b>([In] this KeyValuePair<a, b> self)
		{
			return default((a, b));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3EE0", Offset = "0x3AC2CE0", VA = "0x183AC3EE0")]
		public static KeyValuePair<c?, e?> QYTAKEOTUWO<c, e, d>(this KeyValuePair<c, d> self, e value)
		{
			return default(KeyValuePair<c, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class KLFAIAVYQYU
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class OQSWBSPHOUY<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IList<a> XCKJDNTSLSE;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public OQSWBSPHOUY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x729D630", Offset = "0x729C430", VA = "0x18729D630")]
			internal a SLUCZKYITDG(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3BBFA10", Offset = "0x3BBE810", VA = "0x183BBFA10")]
		public static int UUWLVEWKJNE<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5810", Offset = "0x3BB4610", VA = "0x183BB5810")]
		public static int GJIWLQNDPVA<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBB30", Offset = "0x3BBA930", VA = "0x183BBBB30")]
		public static bool NXBMKXWKXPD<a>(this IList<a> self, a? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBF50", Offset = "0x3BBAD50", VA = "0x183BBBF50")]
		public static void QAAXATRKPYJ<T>(this HashSet<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3BBA9B0", Offset = "0x3BB97B0", VA = "0x183BBA9B0")]
		public static void NDFJDABYWEC<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3BBA670", Offset = "0x3BB9470", VA = "0x183BBA670")]
		public static void NDFJDABYWEC<T>(this IList<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6520", Offset = "0x3BB5320", VA = "0x183BB6520")]
		public static void KCEJACMVWNY<T>(this List<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3BB59E0", Offset = "0x3BB47E0", VA = "0x183BB59E0")]
		public static bool JAULKEYWBUP<T>(this IList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<T>? removedElements) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6330", Offset = "0x3BB5130", VA = "0x183BB6330")]
		public static List<b> JAULKEYWBUP<b>(this List<b> a, Predicate<b> b) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3BBFD60", Offset = "0x3BBEB60", VA = "0x183BBFD60")]
		public static int UUWLVEWKJNE<T>(this IReadOnlyList<T> a, Predicate<T> b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2CB0", Offset = "0x3BB1AB0", VA = "0x183BB2CB0")]
		public static bool CZLBXZJFKAL<T>(this IReadOnlyList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<int>? indices) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3BF0", Offset = "0x3BB29F0", VA = "0x183BB3BF0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3B00", Offset = "0x3BB2900", VA = "0x183BB3B00")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9F50", Offset = "0x3BB8D50", VA = "0x183BB9F50")]
		public static int MPNOZZBDLVO<TElement>(this IList<TElement> a, TElement b, [Optional] Func<TElement, TElement, int>? compare, int c = 0, [Optional] int? d) where TElement : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9650", Offset = "0x3BB8450", VA = "0x183BB9650")]
		public static int MPNOZZBDLVO<TElement, TKey>(this IList<TElement> a, TKey b, Func<TElement, TKey> c, [Optional] Func<TKey, TKey, int>? compare, int d = 0, [Optional] int? e) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9090", Offset = "0x3BB7E90", VA = "0x183BB9090")]
		public static int MPNOZZBDLVO<TElement, TKey>(Func<int, TElement> a, int b, TKey c, Func<TElement, TKey> d, [Optional] Func<TKey, TKey, int>? compare, int e = 0, [Optional] int? f) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3BBF9B0", Offset = "0x3BBE7B0", VA = "0x183BBF9B0")]
		public static int URCPZEACFVH<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3BBF520", Offset = "0x3BBE320", VA = "0x183BBF520")]
		public static int TRLMPBLBPNL<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3BB51C0", Offset = "0x3BB3FC0", VA = "0x183BB51C0")]
		public static bool FJLAXDYYJNB<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1E00", Offset = "0x3BC0C00", VA = "0x183BC1E00")]
		public static void YRIUTIJZKAW<T>(this List<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD990", Offset = "0x3BBC790", VA = "0x183BBD990")]
		public static void Remove<T>(this List<T> list, IEnumerable<T> collection) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD630", Offset = "0x3BBC430", VA = "0x183BBD630")]
		public static c QIGYRUUHWDO<c>(this List<c> a, Predicate<c> b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7180", Offset = "0x3BB5F80", VA = "0x183BB7180")]
		public static d KUWRJGYLJBJ<d>(this List<d> a, int b) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6E50", Offset = "0x3BB5C50", VA = "0x183BB6E50")]
		public static void KNKNRKOMSXK<T>(this List<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3BBAEF0", Offset = "0x3BB9CF0", VA = "0x183BBAEF0")]
		public static bool NOJUBWZOBIV<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7040", Offset = "0x3BB5E40", VA = "0x183BB7040")]
		public static bool KNNKFJYSHST<T>(this List<T> a, List<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2C10", Offset = "0x3BB1A10", VA = "0x183BB2C10")]
		public static e CQYPIBHTDXU<e>(this IList<e> a) where e : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3BBF800", Offset = "0x3BBE600", VA = "0x183BBF800")]
		public static bool UHFMIPBPBEC<T>(IReadOnlyList<T>? list, int a, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3BBED50", Offset = "0x3BBDB50", VA = "0x183BBED50")]
		public static bool TQUWLVNFZSM<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7FA0", Offset = "0x3BB6DA0", VA = "0x183BB7FA0")]
		public static void MIAWNAYKKYJ<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1A60", Offset = "0x3BC0860", VA = "0x183BC1A60")]
		public static bool XCGRVZWHAOK<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3BBAFC0", Offset = "0x3BB9DC0", VA = "0x183BBAFC0")]
		public static string NTGRREUYIHX<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1980", Offset = "0x3BC0780", VA = "0x183BC1980")]
		public static T WNOOTZNCXRX<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3BBDD50", Offset = "0x3BBCB50", VA = "0x183BBDD50")]
		public static T SGJBPRKPDHD<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6480", Offset = "0x3BB5280", VA = "0x183BB6480")]
		public static void JCICPOEDWOR<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3BC13A0", Offset = "0x3BC01A0", VA = "0x183BC13A0")]
		public static void WISFNQFFOLB<T>(this IList<T> a, [In] T value) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7200", Offset = "0x3BB6000", VA = "0x183BB7200")]
		public static T LRDOIJUFSEW<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class PNFKAFHASSC
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static float GJOEJYCNUSY;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static float FCNDZGIYLKL;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static bool MFTXJOWFEKT;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly float JAVRLBDZIIB;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9984000", Offset = "0x9982E00", VA = "0x189984000")]
		public static bool EKBTWHUFEVU(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9983F40", Offset = "0x9982D40", VA = "0x189983F40")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9983F60", Offset = "0x9982D60", VA = "0x189983F60")]
		public static int Clamp(int value, int min, int max)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x99840F0", Offset = "0x9982EF0", VA = "0x1899840F0")]
		public static float ETBVCXWHLIX(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9984200", Offset = "0x9983000", VA = "0x189984200")]
		public static float Lerp(float a, float b, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x99844F0", Offset = "0x99832F0", VA = "0x1899844F0")]
		public static float XMZCUZKDENN(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9984590", Offset = "0x9983390", VA = "0x189984590")]
		public static float ZFVJXQDUXHU(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x99842C0", Offset = "0x99830C0", VA = "0x1899842C0")]
		public static float QPBELQFVHLL(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9984650", Offset = "0x9983450", VA = "0x189984650")]
		public static float ZFVJXQDUXHU(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9984300", Offset = "0x9983100", VA = "0x189984300")]
		public static float QPBELQFVHLL(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x99842A0", Offset = "0x99830A0", VA = "0x1899842A0")]
		public static float Max(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9984330", Offset = "0x9983130", VA = "0x189984330")]
		public static float TFYIHPUWMCV(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9984500", Offset = "0x9983300", VA = "0x189984500")]
		public static float YLHFGMJEWGC(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9984110", Offset = "0x9982F10", VA = "0x189984110")]
		public static float ITHQVDKJUMB(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9983F80", Offset = "0x9982D80", VA = "0x189983F80")]
		public static float DVENYCULQOV(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x500A810", Offset = "0x5009610", VA = "0x18500A810")]
		public static int QIVJBUQKHGS(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ZNKNTDLJNFV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private System.Random MQZNXHHRAXY;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9986630", Offset = "0x9985430", VA = "0x189986630")]
		public ZNKNTDLJNFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x99866B0", Offset = "0x99854B0", VA = "0x1899866B0")]
		public ZNKNTDLJNFV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8E5F5F0", Offset = "0x8E5E3F0", VA = "0x188E5F5F0", Slot = "4")]
		public virtual int Next()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9986600", Offset = "0x9985400", VA = "0x189986600", Slot = "5")]
		public virtual int Next(int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9985CC0", Offset = "0x9984AC0", VA = "0x189985CC0", Slot = "6")]
		public virtual int Next(int minValue, int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x99865D0", Offset = "0x99853D0", VA = "0x1899865D0")]
		public double MXMALVTTNMF()
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class GQWOMGWMTKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3920", Offset = "0x3AC2720", VA = "0x183AC3920")]
		[Todo("This should be replaced with the `is not` operator in C# 9.")]
		public static bool YRLXPZTQKLY<T>(this object a, [Out][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class CCCNDHVDZEE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x997F5C0", Offset = "0x997E3C0", VA = "0x18997F5C0")]
		public static (float3, float3, float3) AWCGHZZBFYF([In] this quaternion self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x997F760", Offset = "0x997E560", VA = "0x18997F760")]
		private static float3 GYOHTNKBLKR(quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x99805A0", Offset = "0x997F3A0", VA = "0x1899805A0")]
		private static float3 SCBMEYGEGRA(float3 a, math.RotationOrder b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x997F6B0", Offset = "0x997E4B0", VA = "0x18997F6B0")]
		public static float3 FGBEGCKSEGZ(this quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9980460", Offset = "0x997F260", VA = "0x189980460")]
		public static float RPAKPPNXNNO(this quaternion a, quaternion b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x99800E0", Offset = "0x997EEE0", VA = "0x1899800E0")]
		public static quaternion JIQDJUGCKXV(this quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x99803D0", Offset = "0x997F1D0", VA = "0x1899803D0")]
		[CompilerGenerated]
		internal static float3 MOQUTJXLRIZ(float3 a)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class CRFXKNBZYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class VBHJFCJBWBF : UCGLINRHHGX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly System.Random THDAVOPVOCZ;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9985CC0", Offset = "0x9984AC0", VA = "0x189985CC0", Slot = "4")]
			public int Next(int minInclusive, int maxExclusive)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x9985C50", Offset = "0x9984A50", VA = "0x189985C50", Slot = "5")]
			public float MDDROTMVWKQ(float a, float b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9985CF0", Offset = "0x9984AF0", VA = "0x189985CF0")]
			private double YWEAXIYTSDX()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9985D30", Offset = "0x9984B30", VA = "0x189985D30")]
			public VBHJFCJBWBF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly UCGLINRHHGX JBOJCAGWOHI;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9980670", Offset = "0x997F470", VA = "0x189980670")]
		public static ulong UBEKBHODWRR()
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class IHEJWWIYQSS
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB1F0", Offset = "0x3AE9FF0", VA = "0x183AEB1F0")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class UOIOMXVSKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x408D8A0", Offset = "0x408C6A0", VA = "0x18408D8A0")]
		public static bool NBVFQCVUMGP<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> a, IReadOnlyDictionary<TKey, TValue> b) where TKey : notnull where TValue : notnull, IEquatable<TValue>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class VZADJQYXLVD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x40C3E70", Offset = "0x40C2C70", VA = "0x1840C3E70")]
		public static a? MRBCFZMDKGI<a, TKey>(this IReadOnlyDictionary<TKey, a> self, TKey key) where a : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class JPSUGQCQZGW
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
				[Cpp2IlInjected.Address(RVA = "0x5C6B430", Offset = "0x5C6A230", VA = "0x185C6B430", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly object? ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x5C69CE0", Offset = "0x5C68AE0", VA = "0x185C69CE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xD9EB20", Offset = "0xD9D920", VA = "0x180D9EB20")]
			private Enumerator(IReadOnlyList<T> list, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5303780", Offset = "0x5302580", VA = "0x185303780")]
			public static Enumerator<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			public readonly void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5C6A2E0", Offset = "0x5C690E0", VA = "0x185C6A2E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x2B6FB20", Offset = "0x2B6E920", VA = "0x182B6FB20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x12AF450", Offset = "0x12AE250", VA = "0x1812AF450")]
			private Enumerable(Enumerator<T> enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x5B886D0", Offset = "0x5B874D0", VA = "0x185B886D0")]
			public static Enumerable<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerable<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x12AF420", Offset = "0x12AE220", VA = "0x1812AF420")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5B88400", Offset = "0x5B87200", VA = "0x185B88400", Slot = "4")]
			private IEnumerator<T> EJVKVOJRYRR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x5B88400", Offset = "0x5B87200", VA = "0x185B88400", Slot = "5")]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9982DF0", Offset = "0x9981BF0", VA = "0x189982DF0")]
		public static void Invoke(this IReadOnlyList<Action> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3B456F0", Offset = "0x3B444F0", VA = "0x183B456F0")]
		public static bool YOABBVTNACT<T>(this IReadOnlyList<T> a, int b, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3B44FD0", Offset = "0x3B43DD0", VA = "0x183B44FD0")]
		public static bool GZAVPZPBPEQ<T>(this IReadOnlyList<T> a, int b, [Out] IndexValuePair<T> result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3B451A0", Offset = "0x3B43FA0", VA = "0x183B451A0")]
		public static T MGGIOHFPJJP<T>(this IReadOnlyList<T> a, int b, [In] T optB) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3B45960", Offset = "0x3B44760", VA = "0x183B45960")]
		[CS9ImprovedNullableConstraints("This should return `T?` in C# 9. `default! isn't necessary.")]
		public static T YXYDCWLWVEC<T>(this IReadOnlyList<T> a, int b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3B45500", Offset = "0x3B44300", VA = "0x183B45500")]
		public static a? MRBCFZMDKGI<a>(this IReadOnlyList<a> self, int a) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3B44D90", Offset = "0x3B43B90", VA = "0x183B44D90")]
		public static Enumerable<T> GMHVZFESYCP<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(Enumerable<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class XAJMMSQVHQF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x410CEE0", Offset = "0x410BCE0", VA = "0x18410CEE0")]
		public static int UHIGQEZJBOK<a>([In] this ReadOnlySequence<a> sequence, [In] a value) where a : IEquatable<a>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x410C990", Offset = "0x410B790", VA = "0x18410C990")]
		public static bool FSSRFWCDNLC<c>([In] this ReadOnlySequence<c> sequence, [In] ReadOnlySpan<c> other) where c : IEquatable<c>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class JNJJGSAISUK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3B44870", Offset = "0x3B43670", VA = "0x183B44870")]
		public static string QFPEPEWSFZY<T>([In] this ReadOnlySpan<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3B43860", Offset = "0x3B42660", VA = "0x183B43860")]
		public static string BUQIBNRACUU<T>([In] this ReadOnlySpan<T> self, string a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct ReadOnlyStopwatch : GDMUHHRAWUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly GDMUHHRAWUF _baseStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly long _baseTicks;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long BKMNAZKSZNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x9984FC0", Offset = "0x9983DC0", VA = "0x189984FC0", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double VNLSHEDDMTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9985080", Offset = "0x9983E80", VA = "0x189985080")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double XXONTRFSKEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9985140", Offset = "0x9983F40", VA = "0x189985140")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1E377E0", Offset = "0x1E365E0", VA = "0x181E377E0")]
		public ReadOnlyStopwatch(GDMUHHRAWUF baseStopwatch, long baseTicks)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class NJOEOSPMOUR
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static GDMUHHRAWUF SVGXENHUXFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x99839A0", Offset = "0x99827A0", VA = "0x1899839A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9983B00", Offset = "0x9982900", VA = "0x189983B00")]
		public static long TKCCXEUBUWF(this GDMUHHRAWUF a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9983910", Offset = "0x9982710", VA = "0x189983910")]
		public static double GRFDVNJRIIX(this GDMUHHRAWUF a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x99839F0", Offset = "0x99827F0", VA = "0x1899839F0")]
		public static double NQSWZZJLCKM(this GDMUHHRAWUF a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9983A80", Offset = "0x9982880", VA = "0x189983A80")]
		public static ReadOnlyStopwatch RVAQSAVXTGY(this GDMUHHRAWUF a)
		{
			return default(ReadOnlyStopwatch);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class HXCREVDPWTD : GDMUHHRAWUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Stopwatch ZUMDMDRAUAR;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public long BKMNAZKSZNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9982CA0", Offset = "0x9981AA0", VA = "0x189982CA0", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		private HXCREVDPWTD(Stopwatch a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9982CC0", Offset = "0x9981AC0", VA = "0x189982CC0")]
		public static HXCREVDPWTD JVICTENYFMQ(Stopwatch a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9982D20", Offset = "0x9981B20", VA = "0x189982D20")]
		public static HXCREVDPWTD LZGTJNWFZYP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class TTXAYMKXQPA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9864030", Offset = "0x9862E30", VA = "0x189864030")]
		public static float3 up([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9863F00", Offset = "0x9862D00", VA = "0x189863F00")]
		public static float3 VNPXVCXMRJI([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x1392F60", Offset = "0x1391D60", VA = "0x181392F60")]
		public static (float3, float3, float3) EPCRNCBTTFJ([In] this RigidTransform self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x99853E0", Offset = "0x99841E0", VA = "0x1899853E0")]
		public static RigidTransform CHXGSUXGRBB([In] this RigidTransform self)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class KKJRJFRTHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9983070", Offset = "0x9981E70", VA = "0x189983070")]
		public static RigidTransform QVSUYDVXYWR(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class PXKOVDUURCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x99847F0", Offset = "0x99835F0", VA = "0x1899847F0")]
		public static float EXEMUZBFZOK([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x99847E0", Offset = "0x99835E0", VA = "0x1899847E0")]
		public static int AVNNYKVZTWV(this float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9984830", Offset = "0x9983630", VA = "0x189984830")]
		public static (byte, byte, byte, byte) VYJUNIPTHMX(this float a)
		{
			return default((byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class WHFSBSFRYFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x41002D0", Offset = "0x40FF0D0", VA = "0x1841002D0")]
		public static ReadOnlySpan<a?> GUOUWQVGAHZ<a>([In] this Span<a> self)
		{
			return default(ReadOnlySpan<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class PMQOCMGZNWW
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9983E70", Offset = "0x9982C70", VA = "0x189983E70")]
		public static StringBuilder OMMULMLLBPB(this StringBuilder a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9983ED0", Offset = "0x9982CD0", VA = "0x189983ED0")]
		public static StringBuilder PBGUVOVMXMY(this StringBuilder a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9983E10", Offset = "0x9982C10", VA = "0x189983E10")]
		public static StringBuilder KGCMBWVZQQV(this StringBuilder a, char b, int c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class FNMPIPCQWSD
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly Regex CUNSKEOTBXB;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static Regex MNSZAURBFFH;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static Regex ELAHCHGOFXO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly char[] MIQHVRLHEAL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly string[] BQAUMRWYTGO;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2E20", Offset = "0x8AA1C20", VA = "0x188AA2E20")]
		public static bool XCGRVZWHAOK(this string? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9981ED0", Offset = "0x9980CD0", VA = "0x189981ED0")]
		public static string? DXDJMKMQNLB(this string? a, int b, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9982830", Offset = "0x9981630", VA = "0x189982830")]
		public static string SBQNFPQACTN(this string a, int b, string c = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x99820F0", Offset = "0x9980EF0", VA = "0x1899820F0")]
		public static int JSXIBXRULUV(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x99824E0", Offset = "0x99812E0", VA = "0x1899824E0")]
		public static string ONBFIGCLWPO(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x99828C0", Offset = "0x99816C0", VA = "0x1899828C0")]
		public static string YXOPCSPFTSA(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9982660", Offset = "0x9981460", VA = "0x189982660")]
		public static string[] QNYNBKLCZHA(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9982760", Offset = "0x9981560", VA = "0x189982760")]
		private static bool QZUFPOLFXRR(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9981F90", Offset = "0x9980D90", VA = "0x189981F90")]
		private static bool JHTRRPIGRIS(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9982160", Offset = "0x9980F60", VA = "0x189982160")]
		public static int LGTARAWSYEF(string a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class IDSGHXHONFS
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9982DC0", Offset = "0x9981BC0", VA = "0x189982DC0")]
		public static bool WFKFCMVFMYZ(this Type a, Type b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB190", Offset = "0x3AE9F90", VA = "0x183AEB190")]
		public static bool WFKFCMVFMYZ<T>(this Type a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class NUKXKMGZAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x87014E0", Offset = "0x87002E0", VA = "0x1887014E0")]
		public static uint NHNPRZLFCKX(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x87DFFC0", Offset = "0x87DEDC0", VA = "0x1887DFFC0")]
		public static uint RJWNSPFEHCE(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9983D80", Offset = "0x9982B80", VA = "0x189983D80")]
		public static uint MFQAVRXHJYA(this uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9846B60", Offset = "0x9845960", VA = "0x189846B60")]
		public static int AVNNYKVZTWV(this uint a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.NumberStrings
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class XCLJSHFLEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x99862F0", Offset = "0x99850F0", VA = "0x1899862F0")]
		public static string JAOTBDHKPIL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9986400", Offset = "0x9985200", VA = "0x189986400")]
		public static string NNNAGNZOSPS(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9986510", Offset = "0x9985310", VA = "0x189986510")]
		private static string RCSVVLJSGNB(double a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class MLKJQOGHRZY
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C109B0", Offset = "0x3C0F7B0", VA = "0x183C109B0")]
		public static a WJCTANXAEVB<a>(IEnumerable<string> flagStrings, [Optional] a a) where a : struct, Enum, IConvertible
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FBD0", Offset = "0x3C0E9D0", VA = "0x183C0FBD0")]
		public static b DUGLHPUVIPK<b>(IEnumerable<string> flagStrings, [Optional] b a) where b : struct, Enum, IConvertible
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C10450", Offset = "0x3C0F250", VA = "0x183C10450")]
		public static c FTTWHWTBUOJ<c>(IEnumerable<string> flagStrings, [Optional] c a) where c : struct, Enum, IConvertible
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C07C90", Offset = "0x3C06A90", VA = "0x183C07C90")]
		private static bool AJPPRTFMYKI(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class AECTPNYWLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3360650", Offset = "0x335F450", VA = "0x183360650")]
		public static bool DYYXCKVRTVT<a>([In] this a? self, [Out] a a) where a : struct
		{
			return default(bool);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime.Stats
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class DXTHBFGQNZY
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9981580", Offset = "0x9980380", VA = "0x189981580")]
		public static StatsResults NFDCXLICBKS(IReadOnlyList<float> a, int b = -1, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9981690", Offset = "0x9980490", VA = "0x189981690")]
		private static StatsResults YIIFHHQKRDV(IReadOnlyList<float> a, int b, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9981430", Offset = "0x9980230", VA = "0x189981430")]
		private static float JSKVOFUNQSW(IReadOnlyList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9981110", Offset = "0x997FF10", VA = "0x189981110")]
		public static float EULNIIHRTOR(IReadOnlyList<float> a, int b, int c)
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
		[Cpp2IlInjected.Address(RVA = "0x99848A0", Offset = "0x99836A0", VA = "0x1899848A0")]
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
		private sealed class UJNJDQKNNIS : IEnumerable<(StatResultFlags, float)>, IEnumerable, IEnumerator<(StatResultFlags, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private (StatResultFlags flag, float result) OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private StatResultFlags JTBPWUDBHYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public StatResultFlags QIRXNYMSCDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public StatsResults XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public StatsResults QMTTMRITYJA;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private (StatResultFlags, float) AQBGKMUISYY
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x13EF890", Offset = "0x13EE690", VA = "0x1813EF890", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((StatResultFlags, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x99854B0", Offset = "0x99842B0", VA = "0x1899854B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x64BEF30", Offset = "0x64BDD30", VA = "0x1864BEF30")]
			[DebuggerHidden]
			public UJNJDQKNNIS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9985500", Offset = "0x9984300", VA = "0x189985500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9985C10", Offset = "0x9984A10", VA = "0x189985C10", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9985B40", Offset = "0x9984940", VA = "0x189985B40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(StatResultFlags, float)> OEPEDAYEKWT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9985B40", Offset = "0x9984940", VA = "0x189985B40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
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
		public float JKPLRYAWQWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x99852A0", Offset = "0x99840A0", VA = "0x1899852A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ZBFDSMWZXRR
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x99852C0", Offset = "0x99840C0", VA = "0x1899852C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x99852E0", Offset = "0x99840E0", VA = "0x1899852E0")]
		public StatsResults(int n, int hitchN, float hitchThreshold, float hitchThresholdOffset, float min, float max, float mean, float median, float varianceSum, float lowerQuartile, float upperQuartile, PercentileResults percentileResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9985200", Offset = "0x9984000", VA = "0x189985200")]
		[IteratorStateMachine(typeof(UJNJDQKNNIS))]
		public IEnumerable<(StatResultFlags, float)> HOYROKSXADB(StatResultFlags a)
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
