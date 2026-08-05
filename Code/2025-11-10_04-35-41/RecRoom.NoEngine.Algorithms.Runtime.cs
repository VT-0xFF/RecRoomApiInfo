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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D5C20", Offset = "0x83D5020", VA = "0x1883D5C20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D5A80", Offset = "0x83D4E80", VA = "0x1883D5A80", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class PASESFWIQGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly string[] ZSDBXDDSCWL;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83D5CA0", Offset = "0x83D50A0", VA = "0x1883D5CA0")]
		public static bool LAGNERMLQWJ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83D60B0", Offset = "0x83D54B0", VA = "0x1883D60B0")]
		private static bool ZKKTOBYYABV(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83D6180", Offset = "0x83D5580", VA = "0x1883D6180")]
		public static bool ZKKTOBYYABV(Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83D5D70", Offset = "0x83D5170", VA = "0x1883D5D70")]
		public static string MEAHKRLZFLA(string a, string b = "", bool c = true)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class RITPJIABJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83D73E0", Offset = "0x83D67E0", VA = "0x1883D73E0")]
		public static string TBBWRZBDUDE(this Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83D7490", Offset = "0x83D6890", VA = "0x1883D7490")]
		public static string TBBWRZBDUDE(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83D7310", Offset = "0x83D6710", VA = "0x1883D7310")]
		public static byte[] MPEQVLHWETJ(string a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ZYHTMVNGYSW
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate int CompareDelegate<T>([In] T lhs, [In] T rhs);

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public delegate U BreakDelegate<T, U>(int numberOfParts, int partIndex, [In] ReadOnlySpan<T> part);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DBF0", Offset = "0x3C2CFF0", VA = "0x183C2DBF0")]
		public static ReadOnlyMemory<T> QRUNDEWVZDN<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyMemory<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F290", Offset = "0x3C2E690", VA = "0x183C2F290")]
		public static ReadOnlySpan<T> XXAVRHORTYY<T>(this T[] a, int b) where T : notnull
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F0B0", Offset = "0x3C2E4B0", VA = "0x183C2F0B0")]
		public static T[] WJEHVTHKIIW<T>(int a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C470", Offset = "0x3C2B870", VA = "0x183C2C470")]
		public static void DGQYBKIOBLB<T>(this T[] a, T b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DC50", Offset = "0x3C2D050", VA = "0x183C2DC50")]
		public static T[] Remove<T>(this T[] originalArray, int index) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BB20", Offset = "0x3C2AF20", VA = "0x183C2BB20")]
		public static void CINEYSMKLAD<T>(this T[] a, int b, int c) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F360", Offset = "0x3C2E760", VA = "0x183C2F360")]
		public static void YJVFTKEIHDU<T>(this T[] a, CompareDelegate<T> b, [Optional] T[]? preallocatedWorkBuffer) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C720", Offset = "0x3C2BB20", VA = "0x183C2C720")]
		private static void GOGBORSQXQQ<T>(this T[] a, int b, int c, T[] d, bool e, CompareDelegate<T> f) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D450", Offset = "0x3C2C850", VA = "0x183C2D450")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E750", Offset = "0x3C2DB50", VA = "0x183C2E750")]
		public static void WGZOSSPYYTV<T>(this T[] a, int b, int c, CompareDelegate<T> d) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DD60", Offset = "0x3C2D160", VA = "0x183C2DD60")]
		public static T[] Sort<T>(this T[] array) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BBD0", Offset = "0x3C2AFD0", VA = "0x183C2BBD0")]
		public static T[] DENCJSASZXV<T>(this T[] a, T b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DE20", Offset = "0x3C2D220", VA = "0x183C2DE20")]
		public static T[] TUVGYYVHKVP<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DB30", Offset = "0x3C2CF30", VA = "0x183C2DB30")]
		public static T[] PCNXKEUJPYN<T>(this T[] a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C2D120", Offset = "0x3C2C520", VA = "0x183C2D120")]
		public static T[] KHPOFYZSRHP<T>(this T[] a, int b, T c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C2B360", Offset = "0x3C2A760", VA = "0x183C2B360")]
		public static U[] Break<U, T>(this T[] items, int maxItemsPerPart, BreakDelegate<T, U> xForm) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83D8E20", Offset = "0x83D8220", VA = "0x1883D8E20")]
		public static byte[] YWLUKMOFMDL(this byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83D8BC0", Offset = "0x83D7FC0", VA = "0x1883D8BC0")]
		public static byte[] TXLEMZSSJSZ(this byte[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class OPXQBPRBFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83D5C10", Offset = "0x83D5010", VA = "0x1883D5C10")]
		public static byte KXHLLNRDKVF(this bool a)
		{
			return default(byte);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class NDRUVPDPEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83D5C10", Offset = "0x83D5010", VA = "0x1883D5C10")]
		public static bool TSRHIAEGIZD(this byte a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class PCSHMSECDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3875600", Offset = "0x3874A00", VA = "0x183875600")]
		public static void UTWWCRCVMLU<T>(this ICollection<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x38749F0", Offset = "0x3873DF0", VA = "0x1838749F0")]
		public static void PFDJXSTYXMI<T>(this ICollection<T> a) where T : notnull, IDisposable
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GRJXSHNMLSJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3654CD0", Offset = "0x36540D0", VA = "0x183654CD0")]
		public static V VDEHJCJAXRH<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3654220", Offset = "0x3653620", VA = "0x183654220")]
		public static V VDEHJCJAXRH<V, K>(this IDictionary<K, V> a, [In] K key, [In] V value, Func<V, V, V> b) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3652BB0", Offset = "0x3651FB0", VA = "0x183652BB0")]
		public static void SACQMFYURAD<K, V>(this IDictionary<K, List<V>> a, [In] K key, [In] V value) where K : notnull where V : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x36515C0", Offset = "0x36509C0", VA = "0x1836515C0")]
		public static TVal HJMZXZMHHFM<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] TVal defaultValue) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x36522E0", Offset = "0x36516E0", VA = "0x1836522E0")]
		public static TVal HJMZXZMHHFM<TVal, TKey>(this IDictionary<TKey, TVal> a, [In] TKey key, Func<TVal> b) where TVal : notnull where TKey : notnull
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3652E00", Offset = "0x3652200", VA = "0x183652E00")]
		public static b SBURVZXDHZS<b, a>(this IDictionary<a, b> a, [In] a key, [Optional][In][CS9ImprovedNullableConstraints("`default!` and null-oblivious region shouldn't be necessary in C# 9")] b defaultValue)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3653A40", Offset = "0x3652E40", VA = "0x183653A40")]
		public static V Take<V, K>(this IDictionary<K, V> self, [In] K key) where V : notnull where K : notnull
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3650DD0", Offset = "0x36501D0", VA = "0x183650DD0")]
		public static T2[] GIRNOEINUDS<T2, T1>(this Dictionary<T1, T2>.ValueCollection a) where T2 : notnull where T1 : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class MMZWDHLUDSH
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
			[Cpp2IlInjected.Address(RVA = "0x5E11CF0", Offset = "0x5E110F0", VA = "0x185E11CF0")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) One(T one)
			{
				return default((bool, T, IEnumerable<T>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5E11C90", Offset = "0x5E11090", VA = "0x185E11C90")]
			[CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")]
			public (bool, T, IEnumerable<T>) HQCJQWDJCZX(IEnumerable<T> a)
			{
				return default((bool, T, IEnumerable<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class CQEGNFLNFLU<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HashSet<a> UMBJYVOGVII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HashSet<a> BQBIAHOLGHC;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public CQEGNFLNFLU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3E28CF0", Offset = "0x3E280F0", VA = "0x183E28CF0")]
			internal bool TGVANWSOEMQ(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3E28FD0", Offset = "0x3E283D0", VA = "0x183E28FD0")]
			internal bool THAHLDMLNXZ(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class PEUEWMSDSQO<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private a JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private ISet<a> UMMQQQVNNYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ISet<a> IXWIUHNFZCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IEnumerable<a> GHDQVXYJJAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IEnumerable<a> BTYANZBCUQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private IEnumerator<a> BPMZBLFMONE;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private a IUWEFOGQOUV
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x1021B40", Offset = "0x1020F40", VA = "0x181021B40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x4F2E330", Offset = "0x4F2D730", VA = "0x184F2E330", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1293840", Offset = "0x1292C40", VA = "0x181293840")]
			[DebuggerHidden]
			public PEUEWMSDSQO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5A4B7C0", Offset = "0x5A4ABC0", VA = "0x185A4B7C0", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5A4BB20", Offset = "0x5A4AF20", VA = "0x185A4BB20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5A4C770", Offset = "0x5A4BB70", VA = "0x185A4C770")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26FC0", VA = "0x183D27BC0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4E95C40", Offset = "0x4E95040", VA = "0x184E95C40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> MBVYFYVBUYS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5A4B870", Offset = "0x5A4AC70", VA = "0x185A4B870", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class JMVJYVKLKNG<a, b> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private a JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private IEnumerable<a> CVCCLNVRMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IEnumerable<a> EALJAKSLXEV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private IEnumerable<b> TMTGFGVJEQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IEnumerable<b> VUZICJGIJTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private a IOVWEUCICRY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public a KSDCPKZIXUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private IEnumerator<a> BHIZOZJWGVX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IEnumerator<b> OUYTZNVZOWG;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private a IUWEFOGQOUV
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x47995D0", Offset = "0x47989D0", VA = "0x1847995D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x510CC10", Offset = "0x510C010", VA = "0x18510CC10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4E9BF80", Offset = "0x4E9B380", VA = "0x184E9BF80")]
			[DebuggerHidden]
			public JMVJYVKLKNG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x510ACD0", Offset = "0x510A0D0", VA = "0x18510ACD0", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x510BFA0", Offset = "0x510B3A0", VA = "0x18510BFA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x510CC50", Offset = "0x510C050", VA = "0x18510CC50")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x510CFD0", Offset = "0x510C3D0", VA = "0x18510CFD0")]
			private void RZEKLAKLXKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26FC0", VA = "0x183D27BC0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x510B780", Offset = "0x510AB80", VA = "0x18510B780", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> MBVYFYVBUYS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x510B340", Offset = "0x510A740", VA = "0x18510B340", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class MEZSIYAULXD<a> : IEnumerable<(a, Option<a>)>, IEnumerable, IEnumerator<(a, Option<a>)>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private (a Current, Option<a> Next) JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerable<a> CVCCLNVRMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IEnumerable<a> EALJAKSLXEV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerator<a> MCUBBZNIEDN;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private (a, Option<a>) IQMPTZRBCII
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0x2B00320", Offset = "0x2AFF720", VA = "0x182B00320", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, Option<a>));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x57D0390", Offset = "0x57CF790", VA = "0x1857D0390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2B00350", Offset = "0x2AFF750", VA = "0x182B00350")]
			[DebuggerHidden]
			public MEZSIYAULXD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x57CF0F0", Offset = "0x57CE4F0", VA = "0x1857CF0F0", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x57CFE20", Offset = "0x57CF220", VA = "0x1857CFE20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x57D03E0", Offset = "0x57CF7E0", VA = "0x1857D03E0")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26FC0", VA = "0x183D27BC0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x57CF3D0", Offset = "0x57CE7D0", VA = "0x1857CF3D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, Option<a>)> FHVCZDOJVWP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x57CF1A0", Offset = "0x57CE5A0", VA = "0x1857CF1A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class XQFYIDMFIXW<a, b> : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private b JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IEnumerable<a> CVCCLNVRMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEnumerable<a> EALJAKSLXEV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> DELPQKXTUMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Func<SelectAmountPicker<b>, a, (bool Zero, b One, IEnumerable<b> Many)> FRITNZJSXPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private IEnumerator<a> BPMZBLFMONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private IEnumerator<b> BPHSEELPFBV;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private b MJMZIVUQRDO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public XQFYIDMFIXW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA530", Offset = "0x3DB9930", VA = "0x183DBA530", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x3DBABB0", Offset = "0x3DB9FB0", VA = "0x183DBABB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3DBBC40", Offset = "0x3DBB040", VA = "0x183DBBC40")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3DBBC90", Offset = "0x3DBB090", VA = "0x183DBBC90")]
			private void RZEKLAKLXKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26FC0", VA = "0x183D27BC0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA900", Offset = "0x3DB9D00", VA = "0x183DBA900", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> MWOOXBCISSL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA830", Offset = "0x3DB9C30", VA = "0x183DBA830", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class CLQUSTJFCND<a, b> : IEnumerable<(a, b)>, IEnumerable, IEnumerator<(a, b)>, IEnumerator, IDisposable where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private (a Lhs, b Rhs) JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private IEnumerable<a> PHUEBYMSDBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IEnumerable<a> KSGJABNSGLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IEnumerable<b> BKACCOAPQRD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IEnumerable<b> OZGNQMYNEIS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private IEnumerator<a> JMRWKRDYXLT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private IEnumerator<b> YVIMEBLZHJS;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private (a, b) EUGEYRMJPVX
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((a, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x3D9F040", Offset = "0x3D9E440", VA = "0x183D9F040", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x19C1760", Offset = "0x19C0B60", VA = "0x1819C1760")]
			[DebuggerHidden]
			public CLQUSTJFCND(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x3D9E8B0", Offset = "0x3D9DCB0", VA = "0x183D9E8B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26FC0", VA = "0x183D27BC0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3D9F120", Offset = "0x3D9E520", VA = "0x183D9F120", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(a, b)> WHQXQLPTGKG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3D9E7D0", Offset = "0x3D9DBD0", VA = "0x183D9E7D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x375F6A0", Offset = "0x375EAA0", VA = "0x18375F6A0")]
		public static bool All<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83D5B00", Offset = "0x83D4F00", VA = "0x1883D5B00")]
		public static bool All(this IEnumerable<bool> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3762520", Offset = "0x3761920", VA = "0x183762520")]
		public static U BQQCTYRLVAO<U, T>(this IEnumerable<T> a, Func<U> b, Func<T, U> c, Func<IEnumerable<T>, U> d) where U : notnull where T : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x375FB70", Offset = "0x375EF70", VA = "0x18375FB70")]
		public static bool Any<T, TArgs>(this IEnumerable<T> self, [In] TArgs args, AllPredicate<TArgs, T> predicate) where T : notnull where TArgs : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x376B500", Offset = "0x376A900", VA = "0x18376B500")]
		public static U LUTWNLWIMYK<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgAmountSwitchZeroDelegate<TArg, U> b, ArgAmountSwitchOneDelegate<TArg, T, U> c, ArgAmountSwitchManyDelegate<TArg, T, U> d) where U : notnull where T : notnull where TArg : notnull
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x37673D0", Offset = "0x37667D0", VA = "0x1837673D0")]
		public static IEnumerable<U> GVTTYJYMGOC<U, T, TArg>(this IEnumerable<T> a, [In] TArg arg, ArgSelectDelegate<TArg, T, U> b) where U : notnull where T : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3764130", Offset = "0x3763530", VA = "0x183764130")]
		public static IEnumerable<T> DSJQXTLZBCW<T>(params IEnumerable<T>[] enumerables) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37629E0", Offset = "0x3761DE0", VA = "0x1837629E0")]
		public static bool BWJQKACVEKS<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3767B80", Offset = "0x3766F80", VA = "0x183767B80")]
		public static IEnumerable<(a?, b?)>? HSCWGQZWDGV<a, b>(this IEnumerable<KeyValuePair<a, b>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3771C70", Offset = "0x3771070", VA = "0x183771C70")]
		public static IEnumerable<T> WKAQCKCABBF<T, TKey>(this IEnumerable<T> a, Func<T, TKey> b) where T : notnull where TKey : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x35E7570", Offset = "0x35E6970", VA = "0x1835E7570")]
		[IteratorStateMachine(typeof(PEUEWMSDSQO<>))]
		public static IEnumerable<T> TZUJZKMAXJU<T>(this IEnumerable<T> a, ISet<T> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x376DDC0", Offset = "0x376D1C0", VA = "0x18376DDC0")]
		[IteratorStateMachine(typeof(JMVJYVKLKNG<, >))]
		public static IEnumerable<T> RLUHMGAOZEG<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T with) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3767930", Offset = "0x3766D30", VA = "0x183767930")]
		public static T HDSXEWVPQZP<T>(this IEnumerable<T> a, T b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x37679F0", Offset = "0x3766DF0", VA = "0x1837679F0")]
		public static T HDSXEWVPQZP<T>(this IEnumerable<T> a, T b, Func<T, bool> c) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x37680B0", Offset = "0x37674B0", VA = "0x1837680B0")]
		public static c? HVJTBNTERME<c>(this IEnumerable<c> self, Func<c, bool> predicate) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3763A60", Offset = "0x3762E60", VA = "0x183763A60")]
		public static void CTZHELMHZWA<T>(this IEnumerable<T> a, Action<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x376D670", Offset = "0x376CA70", VA = "0x18376D670")]
		[IteratorStateMachine(typeof(MEZSIYAULXD<>))]
		public static IEnumerable<(T, Option<T>)> OGKTVNAVFGN<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x376F8F0", Offset = "0x376ECF0", VA = "0x18376F8F0")]
		public static bool UPCPVMHEHFM<T>(this IEnumerable<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3769120", Offset = "0x3768520", VA = "0x183769120")]
		public static IEnumerable<IndexValuePair<T>> Index<T>(this IEnumerable<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3769D20", Offset = "0x3769120", VA = "0x183769D20")]
		public static bool IsEmpty<T>(this IEnumerable<T> self) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3767AE0", Offset = "0x3766EE0", VA = "0x183767AE0")]
		public static IEnumerable<T> HJZSIVNEVNZ<T>(this IEnumerable<T>? self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x35AF510", Offset = "0x35AE910", VA = "0x1835AF510")]
		[IteratorStateMachine(typeof(XQFYIDMFIXW<, >))]
		public static IEnumerable<U> AJUDTGLMONA<U, T>(this IEnumerable<T> a, Func<SelectAmountPicker<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick) where U : notnull where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3763FB0", Offset = "0x37633B0", VA = "0x183763FB0")]
		public static IEnumerable<T> TGRLTISFQMZ<T>(this IEnumerable<IEnumerable<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x37723A0", Offset = "0x37717A0", VA = "0x1837723A0")]
		public static int YLTSBBZFRBO<T>(this IEnumerable<T> a, int b = 0) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3768AE0", Offset = "0x3767EE0", VA = "0x183768AE0")]
		public static bool IWNSSCRRWDM<T>(this IEnumerable<T> a, IEnumerable<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3764480", Offset = "0x3763880", VA = "0x183764480")]
		public static IEnumerable<T> EQTVCCYGEBM<T>(this IEnumerable<T> a, int b, int c) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x376DB00", Offset = "0x376CF00", VA = "0x18376DB00")]
		public static (IEnumerable<T>, IEnumerable<T>) PJQVQFPJCVU<T>(this IEnumerable<T> a, Func<T, bool> b) where T : notnull
		{
			return default((IEnumerable<T>, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x37658A0", Offset = "0x3764CA0", VA = "0x1837658A0")]
		public static string GVFDCZDVJEP<T>(this IEnumerable<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3766AE0", Offset = "0x3765EE0", VA = "0x183766AE0")]
		public static string GVFDCZDVJEP<T>(this IEnumerable<T> a, Func<T, string> b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3772800", Offset = "0x3771C00", VA = "0x183772800")]
		public static Dictionary<d?, e?>? ZCDVIVDBGNJ<d, e>(this IEnumerable<KeyValuePair<d, e>> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3773820", Offset = "0x3772C20", VA = "0x183773820")]
		public static Dictionary<f?, g?>? ZCDVIVDBGNJ<f, g>(this IEnumerable<(f Key, g Value)> source)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x376E050", Offset = "0x376D450", VA = "0x18376E050")]
		public static List<T> SDAKMSLIWOX<T>(this IEnumerable<T> a, int b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3771E00", Offset = "0x3771200", VA = "0x183771E00")]
		public static string WVKJQHRKPMV<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3763140", Offset = "0x3762540", VA = "0x183763140")]
		public static (IReadOnlyList<h?>?, IReadOnlyList<i?>?) CLANHUPCENK<h, i>(this IEnumerable<(h Lhs, i Rhs)> self)
		{
			return default((IReadOnlyList<h>, IReadOnlyList<i>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x35E0D60", Offset = "0x35E0160", VA = "0x1835E0D60")]
		[IteratorStateMachine(typeof(CLQUSTJFCND<, >))]
		public static IEnumerable<(T, U)> ZVZMQTPSVBP<T, U>(this IEnumerable<T> a, IEnumerable<U> b) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3770C20", Offset = "0x3770020", VA = "0x183770C20")]
		public static IEnumerable<V> WIUOYWFYWJP<V, T, U>(this IEnumerable<T> a, IEnumerable<U> b, Func<T, U, V> c, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where V : notnull where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3770DC0", Offset = "0x37701C0", VA = "0x183770DC0")]
		public static IEnumerable<(T, U)> WIUOYWFYWJP<T, U>(this IEnumerable<T> a, IEnumerable<U> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] T selfWith, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] U otherWith) where T : notnull where U : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37649E0", Offset = "0x3763DE0", VA = "0x1837649E0")]
		public static TOut[] GGBRWKJJEAI<TOut, TIn>(this IEnumerable<TIn> a, Func<TIn, TOut> b) where TOut : notnull where TIn : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x376EBF0", Offset = "0x376DFF0", VA = "0x18376EBF0")]
		public static Option<U> TMVONJRMYXY<U, T>(this IEnumerable<T> a, Func<T, U> b) where U : notnull where T : notnull
		{
			return default(Option<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x376A070", Offset = "0x3769470", VA = "0x18376A070")]
		public static void JNIYPTTAQGW<T>(this IEnumerable<T> a) where T : notnull, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x37612C0", Offset = "0x37606C0", VA = "0x1837612C0")]
		public static IEnumerable<KeyValuePair<TKey, List<TItem>>> BOXCPYBBEGS<TKey, TItem>(this IEnumerable<IEnumerable<TItem>> a, Func<TItem, TKey> b) where TKey : notnull where TItem : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class LNARCGPUQHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3726240", Offset = "0x3725640", VA = "0x183726240")]
		public static bool XPHGLYPETTJ<T, U>(this T a, [In] U obj) where T : notnull, IEquatable<T> where U : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3725E40", Offset = "0x3725240", VA = "0x183725E40")]
		public static bool DGOCYCWUOOW<a>(a a, a b) where a : class, IEquatable<a>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class WNDWEZOZJHS
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1377A50", Offset = "0x1376E50", VA = "0x181377A50")]
		public static bool KZDKXPWTAOC([In] this float3 a, float3 a, float b = 1E-05f)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class YNNAWFLUXFU
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class AUJLPGPRWHA<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private a JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private a CVCCLNVRMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public a EALJAKSLXEV;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private a IUWEFOGQOUV
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x50EDE20", Offset = "0x50ED220", VA = "0x1850EDE20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x19C1760", Offset = "0x19C0B60", VA = "0x1819C1760")]
			[DebuggerHidden]
			public AUJLPGPRWHA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x55080E0", Offset = "0x55074E0", VA = "0x1855080E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26FC0", VA = "0x183D27BC0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5507FB0", Offset = "0x55073B0", VA = "0x185507FB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> MBVYFYVBUYS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x5507E50", Offset = "0x5507250", VA = "0x185507E50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FFC0", Offset = "0x3C1F3C0", VA = "0x183C1FFC0")]
		public static void PGKIJAUZUMI<a>(this a a, Action<a> b) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C20550", Offset = "0x3C1F950", VA = "0x183C20550")]
		public static V WVEOBXKKHGX<V, b>(this b a, Func<b, V> b, [Optional][CS9ImprovedNullableConstraints("`default!` shouldn't be necessary in C# 9")] V defaultValue) where V : notnull where b : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FAE0", Offset = "0x3C1EEE0", VA = "0x183C1FAE0")]
		public static c? DHIXBCKYCDV<c>(this c a) where c : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C20090", Offset = "0x3C1F490", VA = "0x183C20090")]
		[IteratorStateMachine(typeof(AUJLPGPRWHA<>))]
		public static IEnumerable<T> QFWQQBWZUQI<T>(this T a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FD30", Offset = "0x3C1F130", VA = "0x183C1FD30")]
		public static T[] EMRHCJINIID<T>(this T a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class GuidBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly MD5 FHFYSBVMXKW;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly SHA1 AJCQOKIKJVZ;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly byte[] JJSJBKPVQML;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly byte[] DKMCDXVTQWJ;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83D4530", Offset = "0x83D3930", VA = "0x1883D4530")]
		static GuidBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83D4390", Offset = "0x83D3790", VA = "0x1883D4390")]
		public static Guid TJQCKXMMAVZ([In] Guid a, [In] Guid b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83D4440", Offset = "0x83D3840", VA = "0x1883D4440")]
		public static Guid TJQCKXMMAVZ([In] Guid a, [In] Guid b, [In] Guid c)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3659970", Offset = "0x3658D70", VA = "0x183659970")]
		public static Guid Create<T>([In] Guid namespaceId, T value, int version = 5) where T : struct
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83D3FF0", Offset = "0x83D33F0", VA = "0x1883D3FF0")]
		public static Guid Create([In] Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83D40C0", Offset = "0x83D34C0", VA = "0x1883D40C0")]
		private static Guid Create([In] Guid namespaceId, byte[] value, int length, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3659F40", Offset = "0x3659340", VA = "0x183659F40")]
		private static void WQGBDMBEAYI<T>([In] T src, Span<byte> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x365A250", Offset = "0x3659650", VA = "0x18365A250")]
		private static T XWYBKDCRRCS<T>(Span<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83D3F30", Offset = "0x83D3330", VA = "0x1883D3F30")]
		private static void BRYTPEDYFRM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83D4340", Offset = "0x83D3740", VA = "0x1883D4340")]
		private static void SZBXISYEVHG(byte[] a, int b, int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class HTJCKJXWYCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83D46C0", Offset = "0x83D3AC0", VA = "0x1883D46C0")]
		public static int GTMMTTTMSCP(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83D4730", Offset = "0x83D3B30", VA = "0x1883D4730")]
		public static int JYNLSIHPTDR(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83D4800", Offset = "0x83D3C00", VA = "0x1883D4800")]
		public static int VUDMFXVYCFF(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x83D47F0", Offset = "0x83D3BF0", VA = "0x1883D47F0")]
		public static int VLRBPUQWZGE(this int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x712C670", Offset = "0x712BA70", VA = "0x18712C670")]
		public static int INNFGUMXUPK(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7212DC0", Offset = "0x72121C0", VA = "0x187212DC0")]
		public static int BZVNWNHOPFP(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83D4850", Offset = "0x83D3C50", VA = "0x1883D4850")]
		public static float XCXBHOHSROH(this int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83D4780", Offset = "0x83D3B80", VA = "0x1883D4780")]
		public static (byte, byte, byte, byte) LZXDFRKROLY(this int a)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83D4870", Offset = "0x83D3C70", VA = "0x1883D4870")]
		public static int ZKWGBAQUUSI([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83D46B0", Offset = "0x83D3AB0", VA = "0x1883D46B0")]
		public static int FJWBYKOFYMY(this int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83D4770", Offset = "0x83D3B70", VA = "0x1883D4770")]
		public static int JYPNWCOIFGP(this int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class BUZBINKNMFS
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83D2D00", Offset = "0x83D2100", VA = "0x1883D2D00")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) LZXDFRKROLY(this long a)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x83D2DC0", Offset = "0x83D21C0", VA = "0x1883D2DC0")]
		public static long OBUUWGPBWFL([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x83D3010", Offset = "0x83D2410", VA = "0x1883D3010")]
		public static string VSLPOIWHNBY(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x83D2E10", Offset = "0x83D2210", VA = "0x1883D2E10")]
		public static string PKXTNVKEEPF(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83D2E80", Offset = "0x83D2280", VA = "0x1883D2E80")]
		public static string TPKYOFCHZSI(this long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x83D2EF0", Offset = "0x83D22F0", VA = "0x1883D2EF0")]
		public static string UAQQOMKEMWW(this long a, long b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface MSIOTNTVCBY
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Next(int minValue, int maxValue);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float VGSXINKVCSH(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface TFNGQYXHZFI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		long YQAQJFZWGZG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class OMPFBMKSQLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x386DFC0", Offset = "0x386D3C0", VA = "0x18386DFC0")]
		public static (a?, b?) EJZKTQHGZEK<a, b>([In] this KeyValuePair<a, b> self)
		{
			return default((a, b));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x386E410", Offset = "0x386D810", VA = "0x18386E410")]
		public static KeyValuePair<c?, e?> YOMNPDLWMJJ<c, e, d>(this KeyValuePair<c, d> self, e value)
		{
			return default(KeyValuePair<c, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class XTJCZKLSKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class DWSMEQZIHFD<a, b> where a : notnull where b : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public IList<a> YPKPPAXDCFF;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DWSMEQZIHFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4152240", Offset = "0x4151640", VA = "0x184152240")]
			internal a BGVPYBAVLZF(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A650", Offset = "0x3C09A50", VA = "0x183C0A650")]
		public static int DMURMRKRCSL<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DED0", Offset = "0x3C0D2D0", VA = "0x183C0DED0")]
		public static int ISUCCXLLGOL<T>(this IReadOnlyList<T> a, T b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DB30", Offset = "0x3C0CF30", VA = "0x183C0DB30")]
		public static bool GWLTFEEMAZE<a>(this IList<a> self, a? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C10E90", Offset = "0x3C10290", VA = "0x183C10E90")]
		public static void UTWWCRCVMLU<T>(this HashSet<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E660", Offset = "0x3C0DA60", VA = "0x183C0E660")]
		public static void JTMUMQANMLR<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E6E0", Offset = "0x3C0DAE0", VA = "0x183C0E6E0")]
		public static void JTMUMQANMLR<T>(this IList<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C09FD0", Offset = "0x3C093D0", VA = "0x183C09FD0")]
		public static void DHXGSHSNVXN<T>(this List<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FEC0", Offset = "0x3C0F2C0", VA = "0x183C0FEC0")]
		public static bool TCWCZYPRRWM<T>(this IList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<T>? removedElements) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C10590", Offset = "0x3C0F990", VA = "0x183C10590")]
		public static List<b> TCWCZYPRRWM<b>(this List<b> a, Predicate<b> b) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C0A8E0", Offset = "0x3C09CE0", VA = "0x183C0A8E0")]
		public static int DMURMRKRCSL<T>(this IReadOnlyList<T> a, Predicate<T> b) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C06910", Offset = "0x3C05D10", VA = "0x183C06910")]
		public static bool CQQJJUACKLA<T>(this IReadOnlyList<T> a, Predicate<T> b, [Out][NotNullWhen(true)] List<int>? indices) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C07890", Offset = "0x3C06C90", VA = "0x183C07890")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C07A80", Offset = "0x3C06E80", VA = "0x183C07A80")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D6B0", Offset = "0x3C0CAB0", VA = "0x183C0D6B0")]
		public static int GKATWNPQNBJ<TElement>(this IList<TElement> a, TElement b, [Optional] Func<TElement, TElement, int>? compare, int c = 0, [Optional] int? d) where TElement : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CDB0", Offset = "0x3C0C1B0", VA = "0x183C0CDB0")]
		public static int GKATWNPQNBJ<TElement, TKey>(this IList<TElement> a, TKey b, Func<TElement, TKey> c, [Optional] Func<TKey, TKey, int>? compare, int d = 0, [Optional] int? e) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C7F0", Offset = "0x3C0BBF0", VA = "0x183C0C7F0")]
		public static int GKATWNPQNBJ<TElement, TKey>(Func<int, TElement> a, int b, TKey c, Func<TElement, TKey> d, [Optional] Func<TKey, TKey, int>? compare, int e = 0, [Optional] int? f) where TElement : notnull where TKey : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C10A70", Offset = "0x3C0FE70", VA = "0x183C10A70")]
		public static int TJNKLQMDIHC<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer, [Optional] Log? c) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3C13320", Offset = "0x3C12720", VA = "0x183C13320")]
		public static int YAFUDXKWKHY<T>(this IList<T> a, T b, [Optional] IComparer<T>? comparer, [Optional] Log? c) where T : notnull
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C12C20", Offset = "0x3C12020", VA = "0x183C12C20")]
		public static bool XZBGQGSDLHE<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3C09260", Offset = "0x3C08660", VA = "0x183C09260")]
		public static void DBQXCOFSPPT<T>(this List<T> a, IEnumerable<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FB00", Offset = "0x3C0EF00", VA = "0x183C0FB00")]
		public static void Remove<T>(this List<T> list, IEnumerable<T> collection) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3C129B0", Offset = "0x3C11DB0", VA = "0x183C129B0")]
		public static c VTZTQCFJEXD<c>(this List<c> a, Predicate<c> b) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3C12A30", Offset = "0x3C11E30", VA = "0x183C12A30")]
		public static d VXWUIDROOWM<d>(this List<d> a, int b) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F6E0", Offset = "0x3C0EAE0", VA = "0x183C0F6E0")]
		public static void RATKTQTNJSD<T>(this List<T> a, int b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E1C0", Offset = "0x3C0D5C0", VA = "0x183C0E1C0")]
		public static bool IYLPDYNGVLI<T>(this List<T> a, T b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C12620", Offset = "0x3C11A20", VA = "0x183C12620")]
		public static bool VIXDMDSLDUO<T>(this List<T> a, List<T> b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F090", Offset = "0x3C0E490", VA = "0x183C0F090")]
		public static e OLZBYIRHTJL<e>(this IList<e> a) where e : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3C095A0", Offset = "0x3C089A0", VA = "0x183C095A0")]
		public static bool DCOBXIZHAQL<T>(IReadOnlyList<T>? list, int a, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3C142B0", Offset = "0x3C136B0", VA = "0x183C142B0")]
		public static bool ZDXSGNXRTVV<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C15390", Offset = "0x3C14790", VA = "0x183C15390")]
		public static void ZWYYUTMLZVQ<T>(IReadOnlyList<T> a, ICollection b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3C10AF0", Offset = "0x3C0FEF0", VA = "0x183C10AF0")]
		public static bool UOMPJYQLIBF<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3C09660", Offset = "0x3C08A60", VA = "0x183C09660")]
		public static string DFJBPBGXDEO<T>(this IEnumerable<T> a, string b) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F4A0", Offset = "0x3C0E8A0", VA = "0x183C0F4A0")]
		public static T QOBJWQUAFSU<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C12760", Offset = "0x3C11B60", VA = "0x183C12760")]
		public static T VPPSYRHONEW<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3C0EDF0", Offset = "0x3C0E1F0", VA = "0x183C0EDF0")]
		public static void MKCUZVSFNYS<T>(this IList<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C066F0", Offset = "0x3C05AF0", VA = "0x183C066F0")]
		public static void CFOJZERIDMW<T>(this IList<T> a, [In] T value) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3C0EE90", Offset = "0x3C0E290", VA = "0x183C0EE90")]
		public static T NNUBGEBGQPD<T>(this IList<T> a) where T : notnull
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class COENLSTBSPZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static float IVERQHFYIXF;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static float PZKHTPKBPTK;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static bool XWSQLRYIFYM;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public static readonly float HQFGYYOXCMI;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83D3470", Offset = "0x83D2870", VA = "0x1883D3470")]
		public static bool RGAKZMMRDUP(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x83D3070", Offset = "0x83D2470", VA = "0x1883D3070")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x83D3090", Offset = "0x83D2490", VA = "0x1883D3090")]
		public static int Clamp(int value, int min, int max)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x83D3310", Offset = "0x83D2710", VA = "0x1883D3310")]
		public static float LKODTLFAMSW(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x83D3330", Offset = "0x83D2730", VA = "0x1883D3330")]
		public static float Lerp(float a, float b, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83D3140", Offset = "0x83D2540", VA = "0x1883D3140")]
		public static float IPVXVVZPFCK(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83D36C0", Offset = "0x83D2AC0", VA = "0x1883D36C0")]
		public static float TDVIWXTYUJZ(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83D3590", Offset = "0x83D2990", VA = "0x1883D3590")]
		public static float RHESHFZOVRM(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83D3780", Offset = "0x83D2B80", VA = "0x1883D3780")]
		public static float TDVIWXTYUJZ(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x83D3560", Offset = "0x83D2960", VA = "0x1883D3560")]
		public static float RHESHFZOVRM(int a, int b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x83D33D0", Offset = "0x83D27D0", VA = "0x1883D33D0")]
		public static float Max(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x83D3150", Offset = "0x83D2550", VA = "0x1883D3150")]
		public static float KCFHBJBMSJA(float a, float b, float c, float d, float e, float f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x83D30B0", Offset = "0x83D24B0", VA = "0x1883D30B0")]
		public static float FWKNOSJQKWJ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x83D35D0", Offset = "0x83D29D0", VA = "0x1883D35D0")]
		public static float RYNLXTWVMDQ(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x83D33F0", Offset = "0x83D27F0", VA = "0x1883D33F0")]
		public static float PTZNHODPBPG(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3E352A0", Offset = "0x3E346A0", VA = "0x183E352A0")]
		public static int BDYPRVQRJPH(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class TNTAENRKYJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private System.Random KNMOADFJDHP;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x83D7A30", Offset = "0x83D6E30", VA = "0x1883D7A30")]
		public TNTAENRKYJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x83D79B0", Offset = "0x83D6DB0", VA = "0x1883D79B0")]
		public TNTAENRKYJK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x790FD00", Offset = "0x790F100", VA = "0x18790FD00", Slot = "4")]
		public virtual int Next()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x83D7980", Offset = "0x83D6D80", VA = "0x1883D7980", Slot = "5")]
		public virtual int Next(int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x83D71C0", Offset = "0x83D65C0", VA = "0x1883D71C0", Slot = "6")]
		public virtual int Next(int minValue, int maxValue)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x83D7950", Offset = "0x83D6D50", VA = "0x1883D7950")]
		public double HCARWJYJIVU()
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class FJWEBAXNQQU
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x363C4E0", Offset = "0x363B8E0", VA = "0x18363C4E0")]
		[Todo("This should be replaced with the `is not` operator in C# 9.")]
		public static bool GPPBNIRLXGP<T>(this object a, [Out][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class IKPDPARAFBH
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x83D4D40", Offset = "0x83D4140", VA = "0x1883D4D40")]
		public static (float3, float3, float3) HWRJHQBHAWA([In] this quaternion self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x83D4E30", Offset = "0x83D4230", VA = "0x1883D4E30")]
		private static float3 KJUJDFHOBOY(quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x83D5840", Offset = "0x83D4C40", VA = "0x1883D5840")]
		private static float3 QHGHABUJYIN(float3 a, math.RotationOrder b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x83D4C90", Offset = "0x83D4090", VA = "0x1883D4C90")]
		public static float3 DRHNWSGWDCY(this quaternion a, math.RotationOrder b = math.RotationOrder.ZXY)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x83D5910", Offset = "0x83D4D10", VA = "0x1883D5910")]
		public static float SMHYJKMCOYX(this quaternion a, quaternion b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x83D49B0", Offset = "0x83D3DB0", VA = "0x1883D49B0")]
		public static quaternion CEZZMQECSCQ(this quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x83D57B0", Offset = "0x83D4BB0", VA = "0x1883D57B0")]
		[CompilerGenerated]
		internal static float3 PROHNEFEDKG(float3 a)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class AZILYACNUMQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class QGIWDGVPMHC : MSIOTNTVCBY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly System.Random MKZYCVWOMIE;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x83D71C0", Offset = "0x83D65C0", VA = "0x1883D71C0", Slot = "4")]
			public int Next(int minInclusive, int maxExclusive)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x83D7230", Offset = "0x83D6630", VA = "0x1883D7230", Slot = "5")]
			public float VGSXINKVCSH(float a, float b)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x83D71F0", Offset = "0x83D65F0", VA = "0x1883D71F0")]
			private double UORQGEEZXHC()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x83D72A0", Offset = "0x83D66A0", VA = "0x1883D72A0")]
			public QGIWDGVPMHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly MSIOTNTVCBY GYBJEWEOQQZ;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x83D2920", Offset = "0x83D1D20", VA = "0x1883D2920")]
		public static ulong QFFGKVTVXAC()
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class QXHBQEOSCZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3998670", Offset = "0x3997A70", VA = "0x183998670")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class GRUDMFVXTRZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3655550", Offset = "0x3654950", VA = "0x183655550")]
		public static bool HDCXFVYYVJS<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> a, IReadOnlyDictionary<TKey, TValue> b) where TKey : notnull where TValue : notnull, IEquatable<TValue>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class ROUOSNNFNAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x39A0EC0", Offset = "0x39A02C0", VA = "0x1839A0EC0")]
		public static a? NOKGVUZWLPB<a, TKey>(this IReadOnlyDictionary<TKey, a> self, TKey key) where a : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class UYSEASIKJJN
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
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x48425E0", Offset = "0x48419E0", VA = "0x1848425E0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly object? MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x4841710", Offset = "0x4840B10", VA = "0x184841710", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xBF6FA0", Offset = "0xBF63A0", VA = "0x180BF6FA0")]
			private Enumerator(IReadOnlyList<T> list, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x412F540", Offset = "0x412E940", VA = "0x18412F540")]
			public static Enumerator<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			public readonly void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x4840E80", Offset = "0x4840280", VA = "0x184840E80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x2870AA0", Offset = "0x286FEA0", VA = "0x182870AA0", Slot = "8")]
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

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xFB42A0", Offset = "0xFB36A0", VA = "0x180FB42A0")]
			private Enumerable(Enumerator<T> enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x478FD10", Offset = "0x478F110", VA = "0x18478FD10")]
			public static Enumerable<T> New(IReadOnlyList<T> list)
			{
				return default(Enumerable<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xFB4270", Offset = "0xFB3670", VA = "0x180FB4270")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x478FAF0", Offset = "0x478EEF0", VA = "0x18478FAF0", Slot = "4")]
			private IEnumerator<T> MBVYFYVBUYS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x478FAF0", Offset = "0x478EEF0", VA = "0x18478FAF0", Slot = "5")]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x83D7B20", Offset = "0x83D6F20", VA = "0x1883D7B20")]
		public static void Invoke(this IReadOnlyList<Action> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1DC0", Offset = "0x3BB11C0", VA = "0x183BB1DC0")]
		public static bool NCIRIRZXKOC<T>(this IReadOnlyList<T> a, int b, [Out][CS9ImprovedNullableConstraints("This should be `T?` in C# 9.")][NotNullWhen(true)] T result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1B00", Offset = "0x3BB0F00", VA = "0x183BB1B00")]
		public static bool CISISWVTUET<T>(this IReadOnlyList<T> a, int b, [Out] IndexValuePair<T> result) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2460", Offset = "0x3BB1860", VA = "0x183BB2460")]
		public static T VPUYTIVIKBA<T>(this IReadOnlyList<T> a, int b, [In] T optB) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3BB22B0", Offset = "0x3BB16B0", VA = "0x183BB22B0")]
		[CS9ImprovedNullableConstraints("This should return `T?` in C# 9. `default! isn't necessary.")]
		public static T UTAJMDEYQEX<T>(this IReadOnlyList<T> a, int b) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB20D0", Offset = "0x3BB14D0", VA = "0x183BB20D0")]
		public static a? NOKGVUZWLPB<a>(this IReadOnlyList<a> self, int a) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1C30", Offset = "0x3BB1030", VA = "0x183BB1C30")]
		public static Enumerable<T> HAACIHWDBVU<T>(this IReadOnlyList<T> a) where T : notnull
		{
			return default(Enumerable<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public static class SFUVGJOSVSU
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3A55CD0", Offset = "0x3A550D0", VA = "0x183A55CD0")]
		public static int SNBKMDXQDXR<a>([In] this ReadOnlySequence<a> sequence, [In] a value) where a : IEquatable<a>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3A56190", Offset = "0x3A55590", VA = "0x183A56190")]
		public static bool XNPMSHZJXQB<c>([In] this ReadOnlySequence<c> sequence, [In] ReadOnlySpan<c> other) where c : IEquatable<c>
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class BZTUXCBQHAX
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3365D80", Offset = "0x3365180", VA = "0x183365D80")]
		public static string GVFDCZDVJEP<T>([In] this ReadOnlySpan<T> self) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3366A10", Offset = "0x3365E10", VA = "0x183366A10")]
		public static string WVKJQHRKPMV<T>([In] this ReadOnlySpan<T> self, string a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct ReadOnlyStopwatch : TFNGQYXHZFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly TFNGQYXHZFI _baseStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly long _baseTicks;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long YQAQJFZWGZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x83D75F0", Offset = "0x83D69F0", VA = "0x1883D75F0", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double NEXEPMWXLYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x83D76B0", Offset = "0x83D6AB0", VA = "0x1883D76B0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double GBGGXEMLSFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x83D7530", Offset = "0x83D6930", VA = "0x1883D7530")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1AFA630", Offset = "0x1AF9A30", VA = "0x181AFA630")]
		public ReadOnlyStopwatch(TFNGQYXHZFI baseStopwatch, long baseTicks)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class EYZFOLYIZMC
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static TFNGQYXHZFI EMGQSXCXHOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x83D3C60", Offset = "0x83D3060", VA = "0x1883D3C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x83D3D40", Offset = "0x83D3140", VA = "0x1883D3D40")]
		public static long LEIATSXQHEO(this TFNGQYXHZFI a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83D3BD0", Offset = "0x83D2FD0", VA = "0x1883D3BD0")]
		public static double FEOTNLHXOHM(this TFNGQYXHZFI a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83D3CB0", Offset = "0x83D30B0", VA = "0x1883D3CB0")]
		public static double JCFARPJBCRB(this TFNGQYXHZFI a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83D3DD0", Offset = "0x83D31D0", VA = "0x1883D3DD0")]
		public static ReadOnlyStopwatch PFNCEPAAWCP(this TFNGQYXHZFI a)
		{
			return default(ReadOnlyStopwatch);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class HUCJPCRPLWK : TFNGQYXHZFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Stopwatch HKTPYINKBYG;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public long YQAQJFZWGZG
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x83D4990", Offset = "0x83D3D90", VA = "0x1883D4990", Slot = "4")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		private HUCJPCRPLWK(Stopwatch a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x83D4890", Offset = "0x83D3C90", VA = "0x1883D4890")]
		public static HUCJPCRPLWK CBQDDFJMHXH(Stopwatch a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x83D48F0", Offset = "0x83D3CF0", VA = "0x1883D48F0")]
		public static HUCJPCRPLWK KNKVBGWPQQA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class WTBTZHDOASB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x82A7E40", Offset = "0x82A7240", VA = "0x1882A7E40")]
		public static float3 up([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x82A7D10", Offset = "0x82A7110", VA = "0x1882A7D10")]
		public static float3 RGIGNBIQXDZ([In] this RigidTransform self)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x1075940", Offset = "0x1074D40", VA = "0x181075940")]
		public static (float3, float3, float3) IXAYZGDFHWY([In] this RigidTransform self)
		{
			return default((float3, float3, float3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x83D7DB0", Offset = "0x83D71B0", VA = "0x1883D7DB0")]
		public static RigidTransform UBRQNFQYPTU([In] this RigidTransform self)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class PSMTVZMBUOV
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x83D6520", Offset = "0x83D5920", VA = "0x1883D6520")]
		public static RigidTransform EEZSRBLOJWC(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class BHGLJEQGWMV
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x83D2C40", Offset = "0x83D2040", VA = "0x1883D2C40")]
		public static float DZJQJJPMOLB([In] this (byte Fourth, byte Third, byte Second, byte First) self)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83D2CF0", Offset = "0x83D20F0", VA = "0x1883D2CF0")]
		public static int NUSPFZBTTBC(this float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x83D2C80", Offset = "0x83D2080", VA = "0x1883D2C80")]
		public static (byte, byte, byte, byte) LZXDFRKROLY(this float a)
		{
			return default((byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class PUETFESIBJX
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x387F080", Offset = "0x387E480", VA = "0x18387F080")]
		public static ReadOnlySpan<a?> XXAVRHORTYY<a>([In] this Span<a> self)
		{
			return default(ReadOnlySpan<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class PIRIZYCABDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x83D64C0", Offset = "0x83D58C0", VA = "0x1883D64C0")]
		public static StringBuilder LPKEQPWESXS(this StringBuilder a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x83D6450", Offset = "0x83D5850", VA = "0x1883D6450")]
		public static StringBuilder LCVKWPHECAH(this StringBuilder a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x83D63F0", Offset = "0x83D57F0", VA = "0x1883D63F0")]
		public static StringBuilder JSXBQGBFSOM(this StringBuilder a, char b, int c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class XQKJSEGRYGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Regex DKDKUUBIQTI;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static Regex ZLVWWQOMMFW;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static Regex ESVZPABBXTD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly char[] SAQXVKBAIFA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly string[] IXLOAGPNDSF;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x74D0350", Offset = "0x74CF750", VA = "0x1874D0350")]
		public static bool UOMPJYQLIBF(this string? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x83D8690", Offset = "0x83D7A90", VA = "0x1883D8690")]
		public static string? YRCGVXCSHPS(this string? a, int b, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x83D8600", Offset = "0x83D7A00", VA = "0x1883D8600")]
		public static string RNYMDOGONIG(this string a, int b, string c = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x83D7EE0", Offset = "0x83D72E0", VA = "0x1883D7EE0")]
		public static int KBGONZMRSWU(this string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x83D8100", Offset = "0x83D7500", VA = "0x1883D8100")]
		public static string LSAYVUUAYGJ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x83D8050", Offset = "0x83D7450", VA = "0x1883D8050")]
		public static string LIKYDEXHNZV(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x83D7F50", Offset = "0x83D7350", VA = "0x1883D7F50")]
		public static string[] KNVNWZOZIND(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x83D7E10", Offset = "0x83D7210", VA = "0x1883D7E10")]
		private static bool FKCFDMPEYBG(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x83D8750", Offset = "0x83D7B50", VA = "0x1883D8750")]
		private static bool ZQDTMLGZEDJ(string a, int b, [Out] int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x83D8280", Offset = "0x83D7680", VA = "0x1883D8280")]
		public static int PRTPIEJLSSK(string a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class KYZILLMFXNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x83D5A50", Offset = "0x83D4E50", VA = "0x1883D5A50")]
		public static bool XFHLRIGPCNA(this Type a, Type b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3720B30", Offset = "0x371FF30", VA = "0x183720B30")]
		public static bool XFHLRIGPCNA<T>(this Type a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class XVSLAOFENVI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x712C670", Offset = "0x712BA70", VA = "0x18712C670")]
		public static uint INNFGUMXUPK(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7212DC0", Offset = "0x72121C0", VA = "0x187212DC0")]
		public static uint BZVNWNHOPFP(this uint a, int b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x83D8BB0", Offset = "0x83D7FB0", VA = "0x1883D8BB0")]
		public static uint AHMYYANOTGL(this uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x828A930", Offset = "0x8289D30", VA = "0x18828A930")]
		public static int NUSPFZBTTBC(this uint a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.NumberStrings
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class EHVYAUYGGER
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x83D3AC0", Offset = "0x83D2EC0", VA = "0x1883D3AC0")]
		public static string JEMINMIUTSW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x83D38F0", Offset = "0x83D2CF0", VA = "0x1883D38F0")]
		public static string DXMPSWTCAGP(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x83D3A00", Offset = "0x83D2E00", VA = "0x1883D3A00")]
		private static string ILAJOOOMYFY(double a)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class ZJHEHNROSYB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C22410", Offset = "0x3C21810", VA = "0x183C22410")]
		public static a BEUWQXLOKAQ<a>(IEnumerable<string> flagStrings, [Optional] a a) where a : struct, Enum, IConvertible
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C229A0", Offset = "0x3C21DA0", VA = "0x183C229A0")]
		public static b KUAQIHCPGAN<b>(IEnumerable<string> flagStrings, [Optional] b a) where b : struct, Enum, IConvertible
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C23220", Offset = "0x3C22620", VA = "0x183C23220")]
		public static c YJVDQMACAKI<c>(IEnumerable<string> flagStrings, [Optional] c a) where c : struct, Enum, IConvertible
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A910", Offset = "0x3C19D10", VA = "0x183C1A910")]
		private static bool BOTMABZVFKH(Type a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class AFJBXHCMRZY
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3023810", Offset = "0x3022C10", VA = "0x183023810")]
		public static bool WVOPMCEAKQU<a>([In] this a? self, [Out] a a) where a : struct
		{
			return default(bool);
		}
	}
}
namespace RecRoom.NoEngine.Algorithms.Runtime.Stats
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class PXFTCIIVMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x83D7080", Offset = "0x83D6480", VA = "0x1883D7080")]
		public static StatsResults XBPJYOWLTCX(IReadOnlyList<float> a, int b = -1, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x83D6A50", Offset = "0x83D5E50", VA = "0x1883D6A50")]
		private static StatsResults WCSTBGFOXZA(IReadOnlyList<float> a, int b, float c = -1f)
		{
			return default(StatsResults);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x83D6900", Offset = "0x83D5D00", VA = "0x1883D6900")]
		private static float KLFGVNSEFDD(IReadOnlyList<float> a, int b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x83D65E0", Offset = "0x83D59E0", VA = "0x1883D65E0")]
		public static float GLTIPVAUZWI(IReadOnlyList<float> a, int b, int c)
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

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x83D7190", Offset = "0x83D6590", VA = "0x1883D7190")]
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
		private sealed class AUUNKWIQGQL : IEnumerable<(StatResultFlags, float)>, IEnumerable, IEnumerator<(StatResultFlags, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private (StatResultFlags flag, float result) JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private StatResultFlags KIDSOCPGFSR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public StatResultFlags RDUPFELTGUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public StatsResults MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public StatsResults UHQSQUEGJDD;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private (StatResultFlags, float) TPHCZYQSQOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x10D2A50", Offset = "0x10D1E50", VA = "0x1810D2A50", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((StatResultFlags, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x83D28D0", Offset = "0x83D1CD0", VA = "0x1883D28D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4E59590", Offset = "0x4E58990", VA = "0x184E59590")]
			[DebuggerHidden]
			public AUUNKWIQGQL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x83D2290", Offset = "0x83D1690", VA = "0x1883D2290", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x83D2250", Offset = "0x83D1650", VA = "0x1883D2250", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x83D2180", Offset = "0x83D1580", VA = "0x1883D2180", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(StatResultFlags, float)> FVLOJEPKZVQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x83D2180", Offset = "0x83D1580", VA = "0x1883D2180", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
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
		public float AVAUNVXCXJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x83D7830", Offset = "0x83D6C30", VA = "0x1883D7830")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ZIFXCWBUECC
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x83D7810", Offset = "0x83D6C10", VA = "0x1883D7810")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x83D7850", Offset = "0x83D6C50", VA = "0x1883D7850")]
		public StatsResults(int n, int hitchN, float hitchThreshold, float hitchThresholdOffset, float min, float max, float mean, float median, float varianceSum, float lowerQuartile, float upperQuartile, PercentileResults percentileResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x83D7770", Offset = "0x83D6B70", VA = "0x1883D7770")]
		[IteratorStateMachine(typeof(AUUNKWIQGQL))]
		public IEnumerable<(StatResultFlags, float)> DHWJIFAQNWM(StatResultFlags a)
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
