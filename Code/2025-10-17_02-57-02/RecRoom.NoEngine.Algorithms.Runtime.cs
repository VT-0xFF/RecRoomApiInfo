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
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657910", Offset = "0x8655F10", VA = "0x188657910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NoEngine_Algorithms_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8656730", Offset = "0x8654D30", VA = "0x188656730", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class LFRFJBGERMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly string[] UOZKDVLNNVX;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8655FE0", Offset = "0x86545E0", VA = "0x188655FE0")]
		public static bool FYEGWEHHOQL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86563F0", Offset = "0x86549F0", VA = "0x1886563F0")]
		private static bool RZVMBYVWSSJ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86564C0", Offset = "0x8654AC0", VA = "0x1886564C0")]
		public static bool RZVMBYVWSSJ(Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86560B0", Offset = "0x86546B0", VA = "0x1886560B0")]
		public static string OPIKVFSJWSM(string a, string b = "", bool c = true)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class JCIROFUFHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8655F00", Offset = "0x8654500", VA = "0x188655F00")]
		public static string OYNMLGOTRDC(this Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8655E60", Offset = "0x8654460", VA = "0x188655E60")]
		public static string OYNMLGOTRDC(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8655D90", Offset = "0x8654390", VA = "0x188655D90")]
		public static byte[] LUMLQBKPCJH(string a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class QGDQDKYBPOE
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate int CompareDelegate<T>([In] T lhs, [In] T rhs);

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public delegate U BreakDelegate<T, U>(int numberOfParts, int partIndex, [In] ReadOnlySpan<T> part);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F9C0", Offset = "0x3C2DFC0", VA = "0x183C2F9C0")]
		public static ReadOnlyMemory<T> ERRXIQTJQXD<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyMemory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C32C60", Offset = "0x3C31260", VA = "0x183C32C60")]
		public static ReadOnlySpan<T> YYOWHAPSXKO<T>(this T[] a, int b) where T : notnull
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C325B0", Offset = "0x3C30BB0", VA = "0x183C325B0")]
		public static T[] QLXGKGFFTMA<T>(int a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C30F60", Offset = "0x3C2F560", VA = "0x183C30F60")]
		public static void JSUJEWRUVTH<T>(this T[] a, T b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C32640", Offset = "0x3C30C40", VA = "0x183C32640")]
		public static T[] Remove<T>(this T[] originalArray, int index) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C32B20", Offset = "0x3C31120", VA = "0x183C32B20")]
		public static void VDGMSIZNEKJ<T>(this T[] a, int b, int c) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3C31250", Offset = "0x3C2F850", VA = "0x183C31250")]
		public static void MECPEAEZIDK<T>(this T[] a, CompareDelegate<T> b, [Optional] T[]? preallocatedWorkBuffer) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C2FA20", Offset = "0x3C2E020", VA = "0x183C2FA20")]
		private static void IDJCAVRPWUW<T>(this T[] a, int b, int c, T[] d, bool e, CompareDelegate<T> f) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3C31DC0", Offset = "0x3C303C0", VA = "0x183C31DC0")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C30710", Offset = "0x3C2ED10", VA = "0x183C30710")]
		public static void JPPXMBPXEYZ<T>(this T[] a, int b, int c, CompareDelegate<T> d) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C32810", Offset = "0x3C30E10", VA = "0x183C32810")]
		public static T[] Sort<T>(this T[] array) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F120", Offset = "0x3C2D720", VA = "0x183C2F120")]
		public static T[] DANPYTIOZQB<T>(this T[] a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C31490", Offset = "0x3C2FA90", VA = "0x183C31490")]
		public static T[] MKMPNGXZNRR<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C32750", Offset = "0x3C30D50", VA = "0x183C32750")]
		public static T[] STERUECYCGT<T>(this T[] a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C30420", Offset = "0x3C2EA20", VA = "0x183C30420")]
		public static T[] ILLZCDZLBCH<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C2EBB0", Offset = "0x3C2D1B0", VA = "0x183C2EBB0")]
		public static U[] Break<U, T>(this T[] items, int maxItemsPerPart, BreakDelegate<T, U> xForm) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8657C50", Offset = "0x8656250", VA = "0x188657C50")]
		public static byte[] NCSBJSFDAVZ(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8657EB0", Offset = "0x86564B0", VA = "0x188657EB0")]
		public static byte[] XRGDPMBBPET(this byte[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ANUCALTICZN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8653360", Offset = "0x8651960", VA = "0x188653360")]
		public static byte ABMJBAJHMBL(this bool a)
		{
			return default(byte);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class WLTLWOOSJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8653360", Offset = "0x8651960", VA = "0x188653360")]
		public static bool VTTGJQABVCT(this byte a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class SDRPPEWLJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D17C70", Offset = "0x3D16270", VA = "0x183D17C70")]
		public static void EIIARTIDLHW<T>(this ICollection<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D18B50", Offset = "0x3D17150", VA = "0x183D18B50")]
		public static void SYABUFWBBTE<T>(this ICollection<T> a) where T : notnull, IDisposable
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class MIZTQXXTBED
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x39EEE30", Offset = "0x39ED430", VA = "0x1839EEE30")]
		public static V RFUGDAUKLPB<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x39EE390", Offset = "0x39EC990", VA = "0x1839EE390")]
		public static V RFUGDAUKLPB<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x39EDF80", Offset = "0x39EC580", VA = "0x1839EDF80")]
		public static void OUTZEAWRKAF<K, V>(this IDictionary<K, List<V>> a, [In] K key, [In] V value) where K : notnull where V : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39EC9B0", Offset = "0x39EAFB0", VA = "0x1839EC9B0")]
		public static TVal MPKFVNXTCYQ<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] TVal defaultValue) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x39ED6C0", Offset = "0x39EBCC0", VA = "0x1839ED6C0")]
		public static TVal MPKFVNXTCYQ<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, Func<TVal> b) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39EB130", Offset = "0x39E9730", VA = "0x1839EB130")]
		public static b IWOFHFKQOOW<b, a>(this IDictionary<a, b> a, [In] a key, [Optional][In][CS9ImprovedNullableConstraints("`default!` and null-oblivious region shouldn't be necessary in C# 9")] b defaultValue)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39EF100", Offset = "0x39ED700", VA = "0x1839EF100")]
		public static V Take<V, K>(this IDictionary<K, V> self, [In] K key) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x39EE260", Offset = "0x39EC860", VA = "0x1839EE260")]
		public static T2[] QQZVJXILBMW<T2, T1>(this Dictionary<T1, T2>.ValueCollection a) where T2 : notnull where T1 : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class RFLSZXWQDND
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate bool AllPredicate<TArgs, T>([In] TArgs args, T item);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate U ArgAmountSwitchZeroDelegate<TArg, U>([In] TArg arg);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate U ArgAmountSwitchOneDelegate<TArg, T, U>([In] TArg arg, T element);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate U ArgAmountSwitchManyDelegate<TArg, T, U>([In] TArg arg, IEnumerable<T> elements);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate U ArgSelectDelegate<TArg, T, U>([In] TArg arg, T element);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public readonly struct SelectAmountPicker<T> where T : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6051B10", Offset = "0x6050110", VA = "0x186051B10")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) One(T one)
			{
				return default((bool, T, IEnumerable<T>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6051B70", Offset = "0x6050170", VA = "0x186051B70")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) VHZNVRNLJDF(IEnumerable<T> a)
			{
				return default((bool, T, IEnumerable<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class QSYFVWRLSWI<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HashSet<a> HLGAPFPRMLY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HashSet<a> EJRIWBDNBMS;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QSYFVWRLSWI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5D07A50", Offset = "0x5D06050", VA = "0x185D07A50")]
			internal bool XXRATYOTYMW(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5D07C40", Offset = "0x5D06240", VA = "0x185D07C40")]
			internal bool XXWHRFIRHYF(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class EMYWIMSDXLW<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private a MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private ISet<a> THQLUVNKHKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ISet<a> JPVWRDKJCXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IEnumerable<a> EEOYAONDPON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IEnumerable<a> BZOXDQOIWYY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private IEnumerator<a> TPFONUYPLCA;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private a HNCVYZVQHWH
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x138D000", Offset = "0x138B600", VA = "0x18138D000", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x4933410", Offset = "0x4931A10", VA = "0x184933410", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x15FB710", Offset = "0x15F9D10", VA = "0x1815FB710")]
			[DebuggerHidden]
			public EMYWIMSDXLW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x49332B0", Offset = "0x49318B0", VA = "0x1849332B0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4933D10", Offset = "0x4932310", VA = "0x184933D10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x49334F0", Offset = "0x4931AF0", VA = "0x1849334F0")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x49331F0", Offset = "0x49317F0", VA = "0x1849331F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CDFQCYMHDZO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4933620", Offset = "0x4931C20", VA = "0x184933620", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class RBFSSSTPAJM<a, b> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private a MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private IEnumerable<a> ECYRSYGSVOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IEnumerable<a> TQKAAWXBHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private IEnumerable<b> GYQKRHGDQGW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IEnumerable<b> HTKDBHMXWPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private a ITDCNWXXUKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public a NQJQGAPZTDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private IEnumerator<a> FEIYASWTFZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IEnumerator<b> OHHFJPFFDKY;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private a HNCVYZVQHWH
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x494E3D0", Offset = "0x494C9D0", VA = "0x18494E3D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x5D2F230", Offset = "0x5D2D830", VA = "0x185D2F230", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5025240", Offset = "0x5023840", VA = "0x185025240")]
			[DebuggerHidden]
			public RBFSSSTPAJM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5D2ECA0", Offset = "0x5D2D2A0", VA = "0x185D2ECA0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5D30700", Offset = "0x5D2ED00", VA = "0x185D30700", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5D2F450", Offset = "0x5D2DA50", VA = "0x185D2F450")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x5D2F2C0", Offset = "0x5D2D8C0", VA = "0x185D2F2C0")]
			private void KOSXCWUKUNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5D2EBC0", Offset = "0x5D2D1C0", VA = "0x185D2EBC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CDFQCYMHDZO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5D2F630", Offset = "0x5D2DC30", VA = "0x185D2F630", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class CFIZUFMWLHV<a> : IEnumerable<(a, Option<a>)>, IEnumerable, IEnumerator<(a, Option<a>)>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private (a Current, Option<a> Next) MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerable<a> ECYRSYGSVOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IEnumerable<a> TQKAAWXBHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerator<a> GYVJKLNGRIJ;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private (a, Option<a>) DRIACIOVBLM
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x2D82D80", Offset = "0x2D81380", VA = "0x182D82D80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, Option<a>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x40D0130", Offset = "0x40CE730", VA = "0x1840D0130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2D836D0", Offset = "0x2D81CD0", VA = "0x182D836D0")]
			[DebuggerHidden]
			public CFIZUFMWLHV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x40CFFE0", Offset = "0x40CE5E0", VA = "0x1840CFFE0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x40D0450", Offset = "0x40CEA50", VA = "0x1840D0450", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x40D0230", Offset = "0x40CE830", VA = "0x1840D0230")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x40D1540", Offset = "0x40CFB40", VA = "0x1840D1540", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, Option<a>)> XKAOHRYNUAF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x40D0360", Offset = "0x40CE960", VA = "0x1840D0360", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class OOUBXVVQGOC<a, b> : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private b MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<a> ECYRSYGSVOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<a> TQKAAWXBHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> XDMATCVSDZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> AGCHFTCPNKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<a> TPFONUYPLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private IEnumerator<b> TPVJFPGHNKB;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private b PNSHTBMTBHY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public OOUBXVVQGOC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5BC4150", Offset = "0x5BC2750", VA = "0x185BC4150", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5BC51C0", Offset = "0x5BC37C0", VA = "0x185BC51C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5BC4580", Offset = "0x5BC2B80", VA = "0x185BC4580")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x5BC4450", Offset = "0x5BC2A50", VA = "0x185BC4450")]
			private void KOSXCWUKUNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x4FDCF30", Offset = "0x4FDB530", VA = "0x184FDCF30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> PEFCWQTSYMJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5BC46B0", Offset = "0x5BC2CB0", VA = "0x185BC46B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class DMIXPNVAYYP<a, b> : IEnumerable<(a, b)>, IEnumerable, IEnumerator<(a, b)>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private (a Lhs, b Rhs) MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private IEnumerable<a> EKZISIMCJJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IEnumerable<a> JXIAYTMYIWK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IEnumerable<b> BAWXZFQAMJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IEnumerable<b> CTYOJIILXRG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private IEnumerator<a> JBKDRBGWALJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private IEnumerator<b> NQJGDHYBIEW;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private (a, b) MEWOMSHBAZJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x431A1C0", Offset = "0x43187C0", VA = "0x18431A1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xC5F770", Offset = "0xC5DD70", VA = "0x180C5F770")]
			[DebuggerHidden]
			public DMIXPNVAYYP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x431A2D0", Offset = "0x43188D0", VA = "0x18431A2D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x431A100", Offset = "0x4318700", VA = "0x18431A100", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, b)> AXXECCNCEAY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x431A210", Offset = "0x4318810", VA = "0x18431A210", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E620", Offset = "0x3C3CC20", VA = "0x183C3E620")]
		public static bool All<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8658430", Offset = "0x8656A30", VA = "0x188658430")]
		public static bool All(this IEnumerable<bool> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C43B80", Offset = "0x3C42180", VA = "0x183C43B80")]
		public static U GXWVKSFTTMU<U, T>(this IEnumerable<T> a, Func<U> b, Func<T, U> c, Func<IEnumerable<T>, U> d) where U : notnull where T : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3C3EAF0", Offset = "0x3C3D0F0", VA = "0x183C3EAF0")]
		public static bool Any<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C47450", Offset = "0x3C45A50", VA = "0x183C47450")]
		public static U OEVISTNHRCE<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgAmountSwitchZeroDelegate<TArg, U> b, ArgAmountSwitchOneDelegate<TArg, T, U> c, ArgAmountSwitchManyDelegate<TArg, T, U> d) where U : notnull where T : notnull where TArg : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3C479E0", Offset = "0x3C45FE0", VA = "0x183C479E0")]
		public static IEnumerable<U> OJIGETQVBYQ<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgSelectDelegate<TArg, T, U> b) where U : notnull where T : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C48E80", Offset = "0x3C47480", VA = "0x183C48E80")]
		public static IEnumerable<T> PJALYCXIEQQ<T>(params IEnumerable<T>[] enumerables) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BD90", Offset = "0x3C4A390", VA = "0x183C4BD90")]
		public static bool SLAZMFKCFYE<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C440B0", Offset = "0x3C426B0", VA = "0x183C440B0")]
		public static IEnumerable<(a?, b?)>? HXKOCRWPWXB<a, b>(this IEnumerable<KeyValuePair<a, b>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3C420F0", Offset = "0x3C406F0", VA = "0x183C420F0")]
		public static IEnumerable<T> FFNLNHOOCAN<T, TKey>(this IEnumerable<T> a, Func<T, TKey> b) where T : notnull where TKey : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3879770", Offset = "0x3877D70", VA = "0x183879770")]
		[IteratorStateMachine(typeof(EMYWIMSDXLW<>))]
		public static IEnumerable<T> XLNNNKATZBS<T>(this IEnumerable<T> a, ISet<T> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3C41080", Offset = "0x3C3F680", VA = "0x183C41080")]
		[IteratorStateMachine(typeof(RBFSSSTPAJM<, >))]
		public static IEnumerable<T> EJZBCXHCBZK<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T with) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B9A0", Offset = "0x3C49FA0", VA = "0x183C4B9A0")]
		public static T RIWLCLSGNTZ<T>(this IEnumerable<T> a, T b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BA60", Offset = "0x3C4A060", VA = "0x183C4BA60")]
		public static T RIWLCLSGNTZ<T>(this IEnumerable<T> a, T b, Func<T, bool> c) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3C46A90", Offset = "0x3C45090", VA = "0x183C46A90")]
		public static c? NBPFAEWOHMK<c>(this IEnumerable<c> self, Func<c, bool> predicate) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D900", Offset = "0x3C3BF00", VA = "0x183C3D900")]
		public static void AYXCZKEBAQW<T>(this IEnumerable<T> a, Action<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3C46650", Offset = "0x3C44C50", VA = "0x183C46650")]
		[IteratorStateMachine(typeof(CFIZUFMWLHV<>))]
		public static IEnumerable<(T, Option<T>)> MVIJDMENTIL<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C40F40", Offset = "0x3C3F540", VA = "0x183C40F40")]
		public static bool CZZCAYSPBRO<T>(this IEnumerable<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C45710", Offset = "0x3C43D10", VA = "0x183C45710")]
		public static IEnumerable<IndexValuePair<T>> Index<T>(this IEnumerable<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3C46310", Offset = "0x3C44910", VA = "0x183C46310")]
		public static bool IsEmpty<T>(this IEnumerable<T> self) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C47010", Offset = "0x3C45610", VA = "0x183C47010")]
		public static IEnumerable<T> ODJZTYMPTHL<T>(this IEnumerable<T>? self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3846C80", Offset = "0x3845280", VA = "0x183846C80")]
		[IteratorStateMachine(typeof(OOUBXVVQGOC<, >))]
		public static IEnumerable<U> FWZAYSAZHII<U, T>(this IEnumerable<T> a, Func<SelectAmountPicker<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3C43F30", Offset = "0x3C42530", VA = "0x183C43F30")]
		public static IEnumerable<T> HBIGMGBGCYP<T>(this IEnumerable<IEnumerable<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C49370", Offset = "0x3C47970", VA = "0x183C49370")]
		public static int PQKWGZIERNA<T>(this IEnumerable<T> a, int b = 0) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3C450D0", Offset = "0x3C436D0", VA = "0x183C450D0")]
		public static bool IRDAGWXOWSU<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C46570", Offset = "0x3C44B70", VA = "0x183C46570")]
		public static IEnumerable<T> KDQJDBYUOAU<T>(this IEnumerable<T> a, int b, int c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C50390", Offset = "0x3C4E990", VA = "0x183C50390")]
		public static (IEnumerable<T>, IEnumerable<T>) XGTCHLMIDZC<T>(this IEnumerable<T> a, Func<T, bool> b) where T : notnull
		{
			return default((IEnumerable<T>, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F820", Offset = "0x3C3DE20", VA = "0x183C3F820")]
		public static string BVNRPPLOBVP<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3C408E0", Offset = "0x3C3EEE0", VA = "0x183C408E0")]
		public static string BVNRPPLOBVP<T>(this IEnumerable<T> a, Func<T, string> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3C42280", Offset = "0x3C40880", VA = "0x183C42280")]
		public static Dictionary<d?, e?>? GRAAHVDNYNX<d, e>(this IEnumerable<KeyValuePair<d, e>> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3C432A0", Offset = "0x3C418A0", VA = "0x183C432A0")]
		public static Dictionary<f?, g?>? GRAAHVDNYNX<f, g>(this IEnumerable<(f Key, g Value)> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BF50", Offset = "0x3C4A550", VA = "0x183C4BF50")]
		public static List<T> UCEGWCSALAB<T>(this IEnumerable<T> a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C41A00", Offset = "0x3C40000", VA = "0x183C41A00")]
		public static string FBTWSLNTWLF<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EC90", Offset = "0x3C4D290", VA = "0x183C4EC90")]
		public static (IReadOnlyList<h?>?, IReadOnlyList<i?>?) VJKAQFZKLRE<h, i>(this IEnumerable<(h Lhs, i Rhs)> self)
		{
			return default((IReadOnlyList<h>, IReadOnlyList<i>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3872F90", Offset = "0x3871590", VA = "0x183872F90")]
		[IteratorStateMachine(typeof(DMIXPNVAYYP<, >))]
		public static IEnumerable<(T, U)> DAVMDNMFSVV<T, U>(this IEnumerable<T> a, IEnumerable<U> b) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3C497C0", Offset = "0x3C47DC0", VA = "0x183C497C0")]
		public static IEnumerable<V> PSFYPTCMXZR<V, T, U>(this IEnumerable<T> a, IEnumerable<U> b, Func<T, U, V> c, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where V : notnull where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3C49960", Offset = "0x3C47F60", VA = "0x183C49960")]
		public static IEnumerable<(T, U)> PSFYPTCMXZR<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C41780", Offset = "0x3C3FD80", VA = "0x183C41780")]
		public static TOut[] EQHQGIHOHUO<TOut, TIn>(this IEnumerable<TIn> a, Func<TIn, TOut> b) where TOut : notnull where TIn : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C4ABD0", Offset = "0x3C491D0", VA = "0x183C4ABD0")]
		public static Option<U> RFAUFATIXNS<U, T>(this IEnumerable<T> a, Func<T, U> b) where U : notnull where T : notnull
		{
			return default(Option<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DF90", Offset = "0x3C3C590", VA = "0x183C3DF90")]
		public static void AZSTLWVRSUI<T>(this IEnumerable<T> a) where T : notnull, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D810", Offset = "0x3C4BE10", VA = "0x183C4D810")]
		public static IEnumerable<KeyValuePair<TKey, List<TItem>>> UKMSOFSNPGA<TKey, TItem>(this IEnumerable<IEnumerable<TItem>> a, Func<TItem, TKey> b) where TKey : notnull where TItem : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class TUPJUNACADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D624E0", Offset = "0x3D60AE0", VA = "0x183D624E0")]
		public static bool EYKHFREWMZH<T, U>(this T a, [In] U obj) where T : notnull, IEquatable<T> where U : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D625F0", Offset = "0x3D60BF0", VA = "0x183D625F0")]
		public static bool GOGCVNLBSSM<a>(a a, a b) where a : class, IEquatable<a>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class PIPPUSAXSXY
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x18356B0", Offset = "0x1833CB0", VA = "0x1818356B0")]
		public static bool ZMGRLKLZMLS([In] this float3 a, float3 a, float b = 1E-05f)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class QEHDKYANWFS
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class IGKEKUKIGSA<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private a MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private a ECYRSYGSVOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public a TQKAAWXBHGP;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a HNCVYZVQHWH
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x51D4570", Offset = "0x51D2B70", VA = "0x1851D4570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xC5F770", Offset = "0xC5DD70", VA = "0x180C5F770")]
			[DebuggerHidden]
			public IGKEKUKIGSA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x51D4AA0", Offset = "0x51D30A0", VA = "0x1851D4AA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x51D43E0", Offset = "0x51D29E0", VA = "0x1851D43E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> CDFQCYMHDZO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x51D47E0", Offset = "0x51D2DE0", VA = "0x1851D47E0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DCA0", Offset = "0x3C2C2A0", VA = "0x183C2DCA0")]
		public static void TAYKHFTNTKS<a>(this a a, Action<a> b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D1C0", Offset = "0x3C2B7C0", VA = "0x183C2D1C0")]
		public static V JLACWMRTWJD<V, b>(this b a, Func<b, V> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] V defaultValue) where V : notnull where b : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DE30", Offset = "0x3C2C430", VA = "0x183C2DE30")]
		public static c? XHWERYXPCDX<c>(this c a) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DC10", Offset = "0x3C2C210", VA = "0x183C2DC10")]
		[IteratorStateMachine(typeof(IGKEKUKIGSA<>))]
		public static IEnumerable<T> SNMGGHYZMLA<T>(this T a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D770", Offset = "0x3C2BD70", VA = "0x183C2D770")]
		public static T[] PLSZCRQAXWJ<T>(this T a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class GuidBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly MD5 OVFXJIYXCTO;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly SHA1 HVAYSHWXZLD;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly byte[] EPGVDMSNZLP;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly byte[] FUTFJNRKYQL;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86558B0", Offset = "0x8653EB0", VA = "0x1886558B0")]
		static GuidBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x86557B0", Offset = "0x8653DB0", VA = "0x1886557B0")]
		public static Guid RXTQRNFSIYB([In] Guid a, [In] Guid b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x86556C0", Offset = "0x8653CC0", VA = "0x1886556C0")]
		public static Guid RXTQRNFSIYB([In] Guid a, [In] Guid b, [In] Guid c)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x38EB820", Offset = "0x38E9E20", VA = "0x1838EB820")]
		public static Guid Create<T>([In] Guid namespaceId, T value, int version = 5) where T : struct
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x86552B0", Offset = "0x86538B0", VA = "0x1886552B0")]
		public static Guid Create([In] Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8655380", Offset = "0x8653980", VA = "0x188655380")]
		private static Guid Create([In] Guid namespaceId, byte[] value, int length, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x38EBF70", Offset = "0x38EA570", VA = "0x1838EBF70")]
		private static void YBUMEGRTXES<T>([In] T src, Span<byte> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x38EBDF0", Offset = "0x38EA3F0", VA = "0x1838EBDF0")]
		private static T NYURONDQPAQ<T>(Span<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8655600", Offset = "0x8653C00", VA = "0x188655600")]
		private static void NJVZRCAFRTC(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8655860", Offset = "0x8653E60", VA = "0x188655860")]
		private static void SOICPYPCKUO(byte[] a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class EJNDQFJVHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86543D0", Offset = "0x86529D0", VA = "0x1886543D0")]
		public static int OGPBEFSMTXD(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8654450", Offset = "0x8652A50", VA = "0x188654450")]
		public static int TOXIJBATCZP(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x86544D0", Offset = "0x8652AD0", VA = "0x1886544D0")]
		public static int ZZSAEJBOTHP(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8654440", Offset = "0x8652A40", VA = "0x188654440")]
		public static int PMSRBFAMPGK(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x73D97B0", Offset = "0x73D7DB0", VA = "0x1873D97B0")]
		public static int HOURLSFYLMK(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x74C01C0", Offset = "0x74BE7C0", VA = "0x1874C01C0")]
		public static int GZGQRIHFVIX(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x86544B0", Offset = "0x8652AB0", VA = "0x1886544B0")]
		public static float VCKPDAQRSAN(this int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8654340", Offset = "0x8652940", VA = "0x188654340")]
		public static (byte, byte, byte, byte) CFCTFZWYNWI(this int a)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8654490", Offset = "0x8652A90", VA = "0x188654490")]
		public static int TTWFLOJLYFY([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x86543C0", Offset = "0x86529C0", VA = "0x1886543C0")]
		public static int JNRXQFWJLVU(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x86543B0", Offset = "0x86529B0", VA = "0x1886543B0")]
		public static int EVSNFIQYZAZ(this int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class FGCLSRBUJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8654640", Offset = "0x8652C40", VA = "0x188654640")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) CFCTFZWYNWI(this long a)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8654840", Offset = "0x8652E40", VA = "0x188654840")]
		public static long ZMRPDFESTPN([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8654700", Offset = "0x8652D00", VA = "0x188654700")]
		public static string IZWQBMKJULW(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x86547D0", Offset = "0x8652DD0", VA = "0x1886547D0")]
		public static string WHRLWAQJKKV(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8654760", Offset = "0x8652D60", VA = "0x188654760")]
		public static string QQMTZGZASRQ(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8654520", Offset = "0x8652B20", VA = "0x188654520")]
		public static string AHHBMLDWGLK(this long a, long b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface XUVTPJDVKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Next(int minValue, int maxValue);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float BJUKJCGQCUJ(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface TOLNHOOCINS
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		long CJXHDENBTCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class ZOWZHINQCMT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7070", Offset = "0x3EF5670", VA = "0x183EF7070")]
		public static (a?, b?) OWRONDDBSDG<a, b>([In] this KeyValuePair<a, b> self)
		{
			return default((a, b));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3EF74C0", Offset = "0x3EF5AC0", VA = "0x183EF74C0")]
		public static KeyValuePair<c?, e?> YNBPADDEVXX<c, e, d>(this KeyValuePair<c, d> self, e value)
		{
			return default(KeyValuePair<c, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class NNKTQTMWRDR
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class LYPNIJGFSWL<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public IList<a> KXTVLHGHYBP;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public LYPNIJGFSWL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x54883B0", Offset = "0x54869B0", VA = "0x1854883B0")]
			internal a LCWJYNJQZEJ(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDDF0", Offset = "0x3ACC3F0", VA = "0x183ACDDF0")]
		public static int HTBDUCUSFKR<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9260", Offset = "0x3AC7860", VA = "0x183AC9260")]
		public static int CGJSKKWWKMF<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3AD55C0", Offset = "0x3AD3BC0", VA = "0x183AD55C0")]
		public static bool SYXSSAZPWYA<a>(this IList<a> self, a? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB3B0", Offset = "0x3AC99B0", VA = "0x183ACB3B0")]
		public static void EIIARTIDLHW<T>(this HashSet<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3ACCE60", Offset = "0x3ACB460", VA = "0x183ACCE60")]
		public static void FSAUDAYVAYZ<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3ACCEE0", Offset = "0x3ACB4E0", VA = "0x183ACCEE0")]
		public static void FSAUDAYVAYZ<T>(this IList<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7CB0", Offset = "0x3AC62B0", VA = "0x183AC7CB0")]
		public static void ALUHNPSUUGZ<T>(this List<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8520", Offset = "0x3AC6B20", VA = "0x183AC8520")]
		public static bool BZOJNIHSFOK<T>(this IList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<T>? removedElements) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8BF0", Offset = "0x3AC71F0", VA = "0x183AC8BF0")]
		public static List<b> BZOJNIHSFOK<b>(this List<b> a, Predicate<b> b) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDEF0", Offset = "0x3ACC4F0", VA = "0x183ACDEF0")]
		public static int HTBDUCUSFKR<T>(this IReadOnlyList<T> a, Predicate<T> b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3AD56B0", Offset = "0x3AD3CB0", VA = "0x183AD56B0")]
		public static bool USLZCFXNHJC<T>(this IReadOnlyList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<int>? indices) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9BF0", Offset = "0x3AC81F0", VA = "0x183AC9BF0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9B00", Offset = "0x3AC8100", VA = "0x183AC9B00")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AD31F0", Offset = "0x3AD17F0", VA = "0x183AD31F0")]
		public static int OYDKBYMMTNT<TElement>(this IList<TElement> a, TElement b, [Optional] Func<TElement, TElement, int>? compare, int c = 0, [Optional] int? d) where TElement : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3AD28F0", Offset = "0x3AD0EF0", VA = "0x183AD28F0")]
		public static int OYDKBYMMTNT<TElement, TKey>(this IList<TElement> a, TKey b, Func<TElement, TKey> c, [Optional] Func<TKey, TKey, int>? compare, int d = 0, [Optional] int? e) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2610", Offset = "0x3AD0C10", VA = "0x183AD2610")]
		public static int OYDKBYMMTNT<TElement, TKey>(Func<int, TElement> a, int b, TKey c, Func<TElement, TKey> d, [Optional] Func<TKey, TKey, int>? compare, int e = 0, [Optional] int? f) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AD53A0", Offset = "0x3AD39A0", VA = "0x183AD53A0")]
		public static int SIZHMVOVVGK<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer, [Optional] Log? c) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDB40", Offset = "0x3ACC140", VA = "0x183ACDB40")]
		public static int GVZWJRNXHSI<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer, [Optional] Log? c) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6730", Offset = "0x3AD4D30", VA = "0x183AD6730")]
		public static bool ZARWLFYSJOY<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3ACFAB0", Offset = "0x3ACE0B0", VA = "0x183ACFAB0")]
		public static void KVLQAQJJEHJ<T>(this List<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4ED0", Offset = "0x3AD34D0", VA = "0x183AD4ED0")]
		public static void Remove<T>(this List<T> list, IEnumerable<T> collection) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF500", Offset = "0x3ACDB00", VA = "0x183ACF500")]
		public static c JYLHHTLGIED<c>(this List<c> a, Predicate<c> b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3AD60C0", Offset = "0x3AD46C0", VA = "0x183AD60C0")]
		public static d XLSCBBWIBCS<d>(this List<d> a, int b) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5F80", Offset = "0x3AD4580", VA = "0x183AD5F80")]
		public static void WOIIYSZWVEB<T>(this List<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6250", Offset = "0x3AD4850", VA = "0x183AD6250")]
		public static bool XWBRZUMZLUA<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3AC83E0", Offset = "0x3AC69E0", VA = "0x183AC83E0")]
		public static bool BOSJBSUFMJW<T>(this List<T> a, List<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3ACFCB0", Offset = "0x3ACE2B0", VA = "0x183ACFCB0")]
		public static e LLMSQBLDXZJ<e>(this IList<e> a) where e : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6460", Offset = "0x3AD4A60", VA = "0x183AD6460")]
		public static bool XYJFHRNJQMV<T>(IReadOnlyList<T>? list, int a, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3AD46B0", Offset = "0x3AD2CB0", VA = "0x183AD46B0")]
		public static bool QARWIJSUIPX<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3AD1260", Offset = "0x3ACF860", VA = "0x183AD1260")]
		public static void MSHRXYXIGOU<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDD80", Offset = "0x3ACC380", VA = "0x183ACDD80")]
		public static bool HIVZYVPYRVX<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3ACFD50", Offset = "0x3ACE350", VA = "0x183ACFD50")]
		public static string MAQZUROIJFG<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3880", Offset = "0x3AD1E80", VA = "0x183AD3880")]
		public static T PFNUQLBKPCG<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3AD18E0", Offset = "0x3ACFEE0", VA = "0x183AD18E0")]
		public static T NLKQWQRARQU<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6520", Offset = "0x3AD4B20", VA = "0x183AD6520")]
		public static void YZBWVRXKWEA<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD5D0", Offset = "0x3ACBBD0", VA = "0x183ACD5D0")]
		public static void GDCDUGRKZIU<T>(this IList<T> a, [In] T value) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF580", Offset = "0x3ACDB80", VA = "0x183ACF580")]
		public static T KKFUQCFSLTB<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class FNGSHZVLGOZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static float BVSSXXINYCZ;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static float RWFSXFKOWNM;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool WBAIDAZRAWC;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly float HWONAZTKLXA;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8654D10", Offset = "0x8653310", VA = "0x188654D10")]
		public static bool QKAUPDICMSN(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x86548B0", Offset = "0x8652EB0", VA = "0x1886548B0")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8654890", Offset = "0x8652E90", VA = "0x188654890")]
		public static int Clamp(int value, int min, int max)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8654F50", Offset = "0x8653550", VA = "0x188654F50")]
		public static float XTIOVFEGAXG(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8654C50", Offset = "0x8653250", VA = "0x188654C50")]
		public static float Lerp(float a, float b, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8654A90", Offset = "0x8653090", VA = "0x188654A90")]
		public static float EJYWZHGMRLS(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8654E00", Offset = "0x8653400", VA = "0x188654E00")]
		public static float SMCLJHQUBPD(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8654C10", Offset = "0x8653210", VA = "0x188654C10")]
		public static float LQLPGJBLBBC(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8654CF0", Offset = "0x86532F0", VA = "0x188654CF0")]
		public static float Max(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x86548D0", Offset = "0x8652ED0", VA = "0x1886548D0")]
		public static float EDTTSJGCLPW(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8654EC0", Offset = "0x86534C0", VA = "0x188654EC0")]
		public static float SUYWLJVCDVZ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8654B20", Offset = "0x8653120", VA = "0x188654B20")]
		public static float IWSISMRSKFK(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8654AA0", Offset = "0x86530A0", VA = "0x188654AA0")]
		public static float GFUYIDTMSFY(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4115340", Offset = "0x4113940", VA = "0x184115340")]
		public static int OZOXBZNCLDZ(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class PXEOKTLTGPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private System.Random QSSBWONUJFJ;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8657BA0", Offset = "0x86561A0", VA = "0x188657BA0")]
		public PXEOKTLTGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8657B20", Offset = "0x8656120", VA = "0x188657B20")]
		public PXEOKTLTGPA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7BA0130", Offset = "0x7B9E730", VA = "0x187BA0130", Slot = "4")]
		public virtual int Next()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8657AF0", Offset = "0x86560F0", VA = "0x188657AF0", Slot = "5")]
		public virtual int Next(int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x86533E0", Offset = "0x86519E0", VA = "0x1886533E0", Slot = "6")]
		public virtual int Next(int minValue, int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8657AC0", Offset = "0x86560C0", VA = "0x188657AC0")]
		public double KHWOLWPAOEE()
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class PZAYXFOIZIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3B2E650", Offset = "0x3B2CC50", VA = "0x183B2E650")]
		[Todo("This should be replaced with the `is not` operator in C# 9.")]
		public static bool UDTISLTRDEF<T>(this object a, [Out][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class NKWOQJPPSYT
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8656870", Offset = "0x8654E70", VA = "0x188656870")]
		public static (float3, float3, float3) DNFMAXYBTPE([In] this quaternion self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8656E50", Offset = "0x8655450", VA = "0x188656E50")]
		private static float3 UZGRUAOZYXI(quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8656D80", Offset = "0x8655380", VA = "0x188656D80")]
		private static float3 SSFQFUFHDBB(float3 a, math.RotationOrder b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8656960", Offset = "0x8654F60", VA = "0x188656960")]
		public static float3 IXYOERGINCC(this quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86577D0", Offset = "0x8655DD0", VA = "0x1886577D0")]
		public static float WYWKDZDRHAR(this quaternion a, quaternion b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8656A10", Offset = "0x8655010", VA = "0x188656A10")]
		public static quaternion JIKKBLGLEMW(this quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8656CF0", Offset = "0x86552F0", VA = "0x188656CF0")]
		[CompilerGenerated]
		internal static float3 JJBBSVZJATG(float3 a)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class QOBKUZVLSVQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class CCGYRKBYFWW : XUVTPJDVKJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly System.Random KYKWBDZXUES;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x86533E0", Offset = "0x86519E0", VA = "0x1886533E0", Slot = "4")]
			public int Next(int minInclusive, int maxExclusive)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8653370", Offset = "0x8651970", VA = "0x188653370", Slot = "5")]
			public float BJUKJCGQCUJ(float a, float b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8653410", Offset = "0x8651A10", VA = "0x188653410")]
			private double OIXPZKQCAWC()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8653450", Offset = "0x8651A50", VA = "0x188653450")]
			public CCGYRKBYFWW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly XUVTPJDVKJK HDAVWWNBRJZ;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8658110", Offset = "0x8656710", VA = "0x188658110")]
		public static ulong NJNGRELKSCI()
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class ATVTILBOCVD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x32A38E0", Offset = "0x32A1EE0", VA = "0x1832A38E0")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class EUFNSKIAIRX
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x37F88A0", Offset = "0x37F6EA0", VA = "0x1837F88A0")]
		public static bool LDZSKSYXSFM<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> a, IReadOnlyDictionary<TKey, TValue> b) where TKey : notnull where TValue : notnull, IEquatable<TValue>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class YVJESSEXLTQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8510", Offset = "0x3EE6B10", VA = "0x183EE8510")]
		public static a? OOMIDVFCRLX<a, TKey>(this IReadOnlyDictionary<TKey, a> self, TKey key) where a : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class GLUBIVENRZT
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private readonly IReadOnlyList<T> _list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x4A1BF80", Offset = "0x4A1A580", VA = "0x184A1BF80", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly object? HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x4A1A9E0", Offset = "0x4A18FE0", VA = "0x184A1A9E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xE1EEC0", Offset = "0xE1D4C0", VA = "0x180E1EEC0")]
			private Enumerator(IReadOnlyList<T> list, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x4304670", Offset = "0x4302C70", VA = "0x184304670")]
			public static Enumerator<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			public readonly void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4A1AC70", Offset = "0x4A19270", VA = "0x184A1AC70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x2AFED00", Offset = "0x2AFD300", VA = "0x182AFED00", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public readonly struct Enumerable<T> : IEnumerable<T>, IEnumerable where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private readonly Enumerator<T> _enumerator;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x1317F40", Offset = "0x1316540", VA = "0x181317F40")]
			private Enumerable(Enumerator<T> enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x496AC70", Offset = "0x4969270", VA = "0x18496AC70")]
			public static Enumerable<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerable<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x1317F10", Offset = "0x1316510", VA = "0x181317F10")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x496ABB0", Offset = "0x49691B0", VA = "0x18496ABB0", Slot = "4")]
			private IEnumerator<T> CDFQCYMHDZO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x496ABB0", Offset = "0x49691B0", VA = "0x18496ABB0", Slot = "5")]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8655030", Offset = "0x8653630", VA = "0x188655030")]
		public static void Invoke(this IReadOnlyList<Action> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x38E4D40", Offset = "0x38E3340", VA = "0x1838E4D40")]
		public static bool ZKJFYFPTSEI<T>(this IReadOnlyList<T> a, int b, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x38E4630", Offset = "0x38E2C30", VA = "0x1838E4630")]
		public static bool GWFHQDXQUKJ<T>(this IReadOnlyList<T> a, int b, [Out] IndexValuePair<T> result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x38E42B0", Offset = "0x38E28B0", VA = "0x1838E42B0")]
		public static T BAVSSGHZEGY<T>(this IReadOnlyList<T> a, int b, [In] T optB) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x38E4B60", Offset = "0x38E3160", VA = "0x1838E4B60")]
		[CS9ImprovedNullableConstraints("This should return `T?` in C# 9. `default! isn't necessary.")]
		public static T UKEODJNVLFL<T>(this IReadOnlyList<T> a, int b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x38E48C0", Offset = "0x38E2EC0", VA = "0x1838E48C0")]
		public static a? OOMIDVFCRLX<a>(this IReadOnlyList<a> self, int a) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x38E49E0", Offset = "0x38E2FE0", VA = "0x1838E49E0")]
		public static Enumerable<T> SQAYKEBXRCI<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(Enumerable<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class OEVCENJCAES
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3B03440", Offset = "0x3B01A40", VA = "0x183B03440")]
		public static int DAWBYAWITUB<a>([In] this ReadOnlySequence<a> sequence, [In] a value) where a : IEquatable<a>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3B03900", Offset = "0x3B01F00", VA = "0x183B03900")]
		public static bool JZVDVKWOSWL<c>([In] this ReadOnlySequence<c> sequence, [In] ReadOnlySpan<c> other) where c : IEquatable<c>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class SWIXNMHLGGR
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BEC0", Offset = "0x3D1A4C0", VA = "0x183D1BEC0")]
		public static string BVNRPPLOBVP<T>([In] this ReadOnlySpan<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CB50", Offset = "0x3D1B150", VA = "0x183D1CB50")]
		public static string FBTWSLNTWLF<T>([In] this ReadOnlySpan<T> self, string a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct ReadOnlyStopwatch : TOLNHOOCINS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly TOLNHOOCINS _baseStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly long _baseTicks;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long CJXHDENBTCC
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8658610", Offset = "0x8656C10", VA = "0x188658610", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double MZFFAUSXSTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x86586D0", Offset = "0x8656CD0", VA = "0x1886586D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double WGHVEMDUQKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8658550", Offset = "0x8656B50", VA = "0x188658550")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1E20300", Offset = "0x1E1E900", VA = "0x181E20300")]
		public ReadOnlyStopwatch(TOLNHOOCINS baseStopwatch, long baseTicks)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class IQBHNUDFMKA
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static TOLNHOOCINS AIYFDRFAFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8655BD0", Offset = "0x86541D0", VA = "0x188655BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8655A30", Offset = "0x8654030", VA = "0x188655A30")]
		public static long MBABWLXMXKU(this TOLNHOOCINS a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8655C20", Offset = "0x8654220", VA = "0x188655C20")]
		public static double UQPKEKERXAE(this TOLNHOOCINS a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8655AC0", Offset = "0x86540C0", VA = "0x188655AC0")]
		public static double QEMCVVLSKYV(this TOLNHOOCINS a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8655B50", Offset = "0x8654150", VA = "0x188655B50")]
		public static ReadOnlyStopwatch SDHBLBGEKIV(this TOLNHOOCINS a)
		{
			return default(ReadOnlyStopwatch);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class ZYECAXINFNC : TOLNHOOCINS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Stopwatch XAASEZKQYCE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public long CJXHDENBTCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x865A140", Offset = "0x8658740", VA = "0x18865A140", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		private ZYECAXINFNC(Stopwatch a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x865A0E0", Offset = "0x86586E0", VA = "0x18865A0E0")]
		public static ZYECAXINFNC JJFOPKYUAFJ(Stopwatch a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x865A040", Offset = "0x8658640", VA = "0x18865A040")]
		public static ZYECAXINFNC IFMQYYLNAMC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class WXWUWZDIFDR
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8528BC0", Offset = "0x85271C0", VA = "0x188528BC0")]
		public static float3 up([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8528A90", Offset = "0x8527090", VA = "0x188528A90")]
		public static float3 JJTLEKJSFRH([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x13F7610", Offset = "0x13F5C10", VA = "0x1813F7610")]
		public static (float3, float3, float3) DCADSMLNZYW([In] this RigidTransform self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8659180", Offset = "0x8657780", VA = "0x188659180")]
		public static RigidTransform XNZEZGULCIU([In] this RigidTransform self)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class MAIOGCIMFJZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x86567B0", Offset = "0x8654DB0", VA = "0x1886567B0")]
		public static RigidTransform REFARVTUASM(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class YSRWUXHUNUT
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x865A000", Offset = "0x8658600", VA = "0x18865A000")]
		public static float JXHSSXCVEDT([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8659FF0", Offset = "0x86585F0", VA = "0x188659FF0")]
		public static int CWYXBDCZJLI(this float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8659F80", Offset = "0x8658580", VA = "0x188659F80")]
		public static (byte, byte, byte, byte) CFCTFZWYNWI(this float a)
		{
			return default((byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class CKLGWSGSLSL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x36C60A0", Offset = "0x36C46A0", VA = "0x1836C60A0")]
		public static ReadOnlySpan<a?> YYOWHAPSXKO<a>([In] this Span<a> self)
		{
			return default(ReadOnlySpan<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class PPNMWNNEGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8657A60", Offset = "0x8656060", VA = "0x188657A60")]
		public static StringBuilder RXHINVOEMIG(this StringBuilder a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x86579F0", Offset = "0x8655FF0", VA = "0x1886579F0")]
		public static StringBuilder PTOVGRFCYMJ(this StringBuilder a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8657990", Offset = "0x8655F90", VA = "0x188657990")]
		public static StringBuilder OKJDPIQUBSW(this StringBuilder a, char b, int c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class XOGHDWMWKWU
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Regex CTFZEUBCLRS;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static Regex JHFLGIWRLEK;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static Regex JTPQEWJHTAT;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly char[] XSFFLFCHWCM;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly string[] SGVQJNEJZBN;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x777E270", Offset = "0x777C870", VA = "0x18777E270")]
		public static bool HIVZYVPYRVX(this string? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8659BC0", Offset = "0x86581C0", VA = "0x188659BC0")]
		public static string? ZZNZNTKZZDI(this string? a, int b, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8659650", Offset = "0x8657C50", VA = "0x188659650")]
		public static string PMMHSFXIKGI(this string a, int b, string c = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x86595E0", Offset = "0x8657BE0", VA = "0x1886595E0")]
		public static int HTJSVCRFIKC(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8659290", Offset = "0x8657890", VA = "0x188659290")]
		public static string CUPFLZDFZLJ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x86591E0", Offset = "0x86577E0", VA = "0x1886591E0")]
		public static string AHBRNKFQGOR(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8659410", Offset = "0x8657A10", VA = "0x188659410")]
		public static string[] FVRKTNACWXF(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8659510", Offset = "0x8657B10", VA = "0x188659510")]
		private static bool HJPCRIXRGVY(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8659A60", Offset = "0x8658060", VA = "0x188659A60")]
		private static bool XNSQDQGRKPD(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x86596E0", Offset = "0x8657CE0", VA = "0x1886596E0")]
		public static int XBPEVAXENCY(string a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class LDKQHMZTSAT
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8655FB0", Offset = "0x86545B0", VA = "0x188655FB0")]
		public static bool MJIRBHFKSUA(this Type a, Type b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x39BA990", Offset = "0x39B8F90", VA = "0x1839BA990")]
		public static bool MJIRBHFKSUA<T>(this Type a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class RRPIFSWBLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x73D97B0", Offset = "0x73D7DB0", VA = "0x1873D97B0")]
		public static uint HOURLSFYLMK(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x74C01C0", Offset = "0x74BE7C0", VA = "0x1874C01C0")]
		public static uint GZGQRIHFVIX(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8658540", Offset = "0x8656B40", VA = "0x188658540")]
		public static uint WYWMERCTCVT(this uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x850B690", Offset = "0x8509C90", VA = "0x18850B690")]
		public static int CWYXBDCZJLI(this uint a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.NumberStrings
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class CSTCELZKGVR
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x86534C0", Offset = "0x8651AC0", VA = "0x1886534C0")]
		public static string HAMCJPMWSOA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8653690", Offset = "0x8651C90", VA = "0x188653690")]
		public static string PTUSAHNTCQF(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x86535D0", Offset = "0x8651BD0", VA = "0x1886535D0")]
		private static string KECQSAONBSY(double a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class JVOVFVDKOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3986A80", Offset = "0x3985080", VA = "0x183986A80")]
		public static a JYVFLAVTEQG<a>(IEnumerable<string> flagStrings, [Optional] a a) where a : struct, Enum, IConvertible
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3987010", Offset = "0x3985610", VA = "0x183987010")]
		public static b WWUNZTRKQQH<b>(IEnumerable<string> flagStrings, [Optional] b a) where b : struct, Enum, IConvertible
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3986520", Offset = "0x3984B20", VA = "0x183986520")]
		public static c FFJLMTBKDSS<c>(IEnumerable<string> flagStrings, [Optional] c a) where c : struct, Enum, IConvertible
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x397A9E0", Offset = "0x3978FE0", VA = "0x18397A9E0")]
		private static bool YUXDUOGOMKJ(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class IZSCCCPKFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x395A740", Offset = "0x3958D40", VA = "0x18395A740")]
		public static bool HMSYCCKQCXE<a>([In] this a? self, [Out] a a) where a : struct
		{
			return default(bool);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime.Stats
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class DVSFFQJBDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8653F10", Offset = "0x8652510", VA = "0x188653F10")]
		public static StatsResults TXJROKFXIWN(IReadOnlyList<float> a, int b = -1, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x86538F0", Offset = "0x8651EF0", VA = "0x1886538F0")]
		private static StatsResults TEYAVVFUSYM(IReadOnlyList<float> a, int b, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x86537A0", Offset = "0x8651DA0", VA = "0x1886537A0")]
		private static float FNGUVFEDIED(IReadOnlyList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8654020", Offset = "0x8652620", VA = "0x188654020")]
		public static float XBYQKVDHZZE(IReadOnlyList<float> a, int b, int c)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct PercentileResults
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly float P25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float P50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly float P75;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly float P90;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly float P95;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly float P99;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8657C20", Offset = "0x8656220", VA = "0x188657C20")]
		public PercentileResults(float p25, float p50, float p75, float p90, float p95, float p99)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Flags]
	public enum StatResultFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		N = 2,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Min = 4,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Max = 8,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Mean = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Median = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		SVariance = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		PVariance = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Q1 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Q3 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		P25 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		P50 = 0x800,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		P75 = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		P90 = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		P95 = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		P99 = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		HitchN = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		HitchThres = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		HitchThresOff = 0x40000,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		PercentileFlags = 0xFC00,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		HitchFlags = 0x70000,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public readonly struct StatsResults
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class THFEBGRIWZP : IEnumerable<(StatResultFlags, float)>, IEnumerable, IEnumerator<(StatResultFlags, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private (StatResultFlags flag, float result) MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private StatResultFlags PHVDAZUACKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public StatResultFlags JBJFHGRRZEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public StatsResults CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public StatsResults ASRQRNSDJHF;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private (StatResultFlags, float) BRMTMKXCJCP
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x143A1F0", Offset = "0x14387F0", VA = "0x18143A1F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((StatResultFlags, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x8658970", Offset = "0x8656F70", VA = "0x188658970", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4FEAFD0", Offset = "0x4FE95D0", VA = "0x184FEAFD0")]
			[DebuggerHidden]
			public THFEBGRIWZP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8658A90", Offset = "0x8657090", VA = "0x188658A90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x86590D0", Offset = "0x86576D0", VA = "0x1886590D0", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x86589C0", Offset = "0x8656FC0", VA = "0x1886589C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(StatResultFlags, float)> NVLBZNZMUWY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x86589C0", Offset = "0x8656FC0", VA = "0x1886589C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly int N;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly int HitchN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly float HitchThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float HitchThresholdOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float Min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float Max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float Mean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly float Median;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly float varianceSum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly float LowerQuartile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly float UpperQuartile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly PercentileResults PercentileResults;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CALILIZOLWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8658850", Offset = "0x8656E50", VA = "0x188658850")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float RKFEPGHJXUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8658830", Offset = "0x8656E30", VA = "0x188658830")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8658870", Offset = "0x8656E70", VA = "0x188658870")]
		public StatsResults(int n, int hitchN, float hitchThreshold, float hitchThresholdOffset, float min, float max, float mean, float median, float varianceSum, float lowerQuartile, float upperQuartile, PercentileResults percentileResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8658790", Offset = "0x8656D90", VA = "0x188658790")]
		[IteratorStateMachine(typeof(THFEBGRIWZP))]
		public IEnumerable<(StatResultFlags, float)> IJKDZJBVBPY(StatResultFlags a)
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
