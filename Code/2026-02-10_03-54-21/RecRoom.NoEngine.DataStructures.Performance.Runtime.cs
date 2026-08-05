using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x857E650", Offset = "0x857D850", VA = "0x18857E650")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Performance
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class PIFTZGECFLW
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x395A0E0", Offset = "0x39592E0", VA = "0x18395A0E0")]
		public static ReadOnlyArray<T> MHZEYSCKNRV<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x395C3B0", Offset = "0x395B5B0", VA = "0x18395C3B0")]
		public static CopyEnumerable<T, CopyEnumerator<T>> YLHOMDWGIKP<T>(this T[] a) where T : notnull
		{
			return default(CopyEnumerable<T, CopyEnumerator<T>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class JVKHHOTEJBW<a> : IDisposable, ATXMBMXARWW, IEnumerable<a>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private UnsafeList<a> WABJXDDZNEX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int XZMTABGDEVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public a this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x50EDC20", Offset = "0x50ECE20", VA = "0x1850EDC20")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x50EDA30", Offset = "0x50ECC30", VA = "0x1850EDA30")]
		public static JVKHHOTEJBW<a> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D5C480", Offset = "0x3D5B680", VA = "0x183D5C480")]
		internal JVKHHOTEJBW([In] UnsafeList<a> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x50ED8A0", Offset = "0x50ECAA0", VA = "0x1850ED8A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x50ED880", Offset = "0x50ECA80", VA = "0x1850ED880")]
		public void BOJXPSYXMZH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x50ED930", Offset = "0x50ECB30", VA = "0x1850ED930", Slot = "8")]
		public UnsafeList<a>.MutEnumerator GetEnumerator()
		{
			return default(UnsafeList<a>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x50ED970", Offset = "0x50ECB70", VA = "0x1850ED970", Slot = "6")]
		private IEnumerator<a> ULRXOZXQGZW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x50ED970", Offset = "0x50ECB70", VA = "0x1850ED970", Slot = "7")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct ConstEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : TMMYPJDQGLZ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x105B060", Offset = "0x105A260", VA = "0x18105B060")]
		internal ConstEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x105B030", Offset = "0x105A230", VA = "0x18105B030", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4064540", Offset = "0x4063740", VA = "0x184064540", Slot = "4")]
		private IEnumerator<T> ULRXOZXQGZW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4064540", Offset = "0x4063740", VA = "0x184064540", Slot = "5")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class YRJMYPEKEYW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x30A36A0", Offset = "0x30A28A0", VA = "0x1830A36A0")]
		public static ConstEnumerable<a, U> New<U>([In] U self) where U : TMMYPJDQGLZ<a>
		{
			return default(ConstEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class HFRTUBOOYLT
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x373E040", Offset = "0x373D240", VA = "0x18373E040")]
		public static int Count<T, U>([In] this ConstEnumerable<T, U> self) where U : TMMYPJDQGLZ<T>, ATXMBMXARWW
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ODQTMGTURWT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5A83B60", Offset = "0x5A82D60", VA = "0x185A83B60")]
		public static CopyEnumerable<a, CopyEnumerator<a>> New([In] a[] self)
		{
			return default(CopyEnumerable<a, CopyEnumerator<a>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct CopyEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x105B060", Offset = "0x105A260", VA = "0x18105B060")]
		internal CopyEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x105B030", Offset = "0x105A230", VA = "0x18105B030", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4064540", Offset = "0x4063740", VA = "0x184064540", Slot = "4")]
		private IEnumerator<T> ULRXOZXQGZW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4064540", Offset = "0x4063740", VA = "0x184064540", Slot = "5")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class PGMUUQAABIY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x30A36A0", Offset = "0x30A28A0", VA = "0x1830A36A0")]
		public static CopyEnumerable<a, U> New<U>([In] U self) where U : IEnumerator<a>
		{
			return default(CopyEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class XBUWYLFDEPZ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C43340", Offset = "0x3C42540", VA = "0x183C43340")]
		public static CopyEnumerable<d, CopySelectEnumerator<b, c, d>> ELIGIOPIYNH<d, b, c>([In] this CopyEnumerable<c, b> self, Func<c, d> a) where b : ATXMBMXARWW, IEnumerator<c>
		{
			return default(CopyEnumerable<d, CopySelectEnumerator<b, c, d>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CopyEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, ATXMBMXARWW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] _self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int _index;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public readonly T Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x4072540", Offset = "0x4071740", VA = "0x184072540", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private readonly object CVJXXTOQWTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x40724A0", Offset = "0x40716A0", VA = "0x1840724A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly int XZMTABGDEVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x28FF7A0", Offset = "0x28FE9A0", VA = "0x1828FF7A0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB4E9A0", Offset = "0xB4DBA0", VA = "0x180B4E9A0")]
		private CopyEnumerator(T[] self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x40724F0", Offset = "0x40716F0", VA = "0x1840724F0")]
		public static CopyEnumerator<T> New(T[] self)
		{
			return default(CopyEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28FF520", Offset = "0x28FE720", VA = "0x1828FF520", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28FF7C0", Offset = "0x28FE9C0", VA = "0x1828FF7C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CopySelectEnumerator<TSourceEnumerator, TSource, TResult> : ATXMBMXARWW, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : ATXMBMXARWW, IEnumerator<TSource>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TSourceEnumerator _self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Func<TSource, TResult> _selector;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly int XZMTABGDEVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4072A60", Offset = "0x4071C60", VA = "0x184072A60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly TResult Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4072EF0", Offset = "0x40720F0", VA = "0x184072EF0", Slot = "5")]
			get
			{
				return (TResult)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private readonly object CVJXXTOQWTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x40727A0", Offset = "0x40719A0", VA = "0x1840727A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x29125D0", Offset = "0x29117D0", VA = "0x1829125D0")]
		internal CopySelectEnumerator([In] TSourceEnumerator self, Func<TSource, TResult> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4072A20", Offset = "0x4071C20", VA = "0x184072A20", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4072DA0", Offset = "0x4071FA0", VA = "0x184072DA0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4072640", Offset = "0x4071840", VA = "0x184072640", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class ONLGUEIOBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3938650", Offset = "0x3937850", VA = "0x183938650")]
		public static string VKMNJIWCZKR<a>(this IEnumerable<a> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x393EF10", Offset = "0x393E110", VA = "0x18393EF10")]
		public static string YXAEVGYKGSF<c>(this IEnumerable<c> a, string b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class DEFMMBLTNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x35C0FA0", Offset = "0x35C01A0", VA = "0x1835C0FA0")]
		public static bool RCHHRHANASH<g, h>(this g a, [In] h item) where g : TMMYPJDQGLZ<h> where h : YTDJCTQVIZN<h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x35C0EE0", Offset = "0x35C00E0", VA = "0x1835C0EE0")]
		public static int MOWHRQTIRIH<i, j>(this i a, [In] j value) where i : TMMYPJDQGLZ<j> where j : YTDJCTQVIZN<j>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x35C06F0", Offset = "0x35BF8F0", VA = "0x1835C06F0")]
		public static CopySelectEnumerator<n, o, p> ELIGIOPIYNH<n, o, p>(this n a, Func<o, p> b) where n : ATXMBMXARWW, IEnumerator<o>
		{
			return default(CopySelectEnumerator<n, o, p>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x35C0B50", Offset = "0x35BFD50", VA = "0x1835C0B50")]
		public static int LWEMDGCFZGL<s, t>(this s a, [In] t value) where s : IEnumerator<t> where t : IEquatable<t>
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface TMMYPJDQGLZ<a> : IEnumerator<a>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		new a Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ATXMBMXARWW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int XZMTABGDEVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface HNRJVFQGAJE<a> : TMMYPJDQGLZ<a>, IEnumerator<a>, IEnumerator, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct MutEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : HNRJVFQGAJE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x40647F0", Offset = "0x40639F0", VA = "0x1840647F0")]
		internal MutEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4064450", Offset = "0x4063650", VA = "0x184064450", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x40645A0", Offset = "0x40637A0", VA = "0x1840645A0", Slot = "4")]
		private IEnumerator<T> ULRXOZXQGZW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x40645A0", Offset = "0x40637A0", VA = "0x1840645A0", Slot = "5")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class MDIPBKIHLVF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x30A3700", Offset = "0x30A2900", VA = "0x1830A3700")]
		public static MutEnumerable<a, U> New<U>([In] U self) where U : HNRJVFQGAJE<a>
		{
			return default(MutEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ReadOnlyArray<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct Enumerator : ATXMBMXARWW, TMMYPJDQGLZ<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly T[] _self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public readonly int XZMTABGDEVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x28FF7A0", Offset = "0x28FE9A0", VA = "0x1828FF7A0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x28FF7D0", Offset = "0x28FE9D0", VA = "0x1828FF7D0", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly T QKLNCJRFZQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4745740", Offset = "0x4744940", VA = "0x184745740", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly object? CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x4743BD0", Offset = "0x4742DD0", VA = "0x184743BD0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB4E9A0", Offset = "0xB4DBA0", VA = "0x180B4E9A0")]
			private Enumerator(T[] self, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x40724F0", Offset = "0x40716F0", VA = "0x1840724F0")]
			public static Enumerator New(T[] self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x28FF520", Offset = "0x28FE720", VA = "0x1828FF520", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x28FF7C0", Offset = "0x28FE9C0", VA = "0x1828FF7C0", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly T[] _array;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int EMFZFZKJVBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x28FF7A0", Offset = "0x28FE9A0", VA = "0x1828FF7A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2900470", Offset = "0x28FF670", VA = "0x182900470")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		internal ReadOnlyArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5D465B0", Offset = "0x5D457B0", VA = "0x185D465B0")]
		public static ReadOnlyArray<T> Empty()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC504B0", Offset = "0xC4F6B0", VA = "0x180C504B0")]
		public IEnumerable<T> ZUGJPDASHSW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D464C0", Offset = "0x5D456C0", VA = "0x185D464C0")]
		public ReadOnlySpan<T> CZLFOFDRATM()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5D46960", Offset = "0x5D45B60", VA = "0x185D46960")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> KSDITDALMHX()
		{
			return default(ConstEnumerable<T, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5D46B20", Offset = "0x5D45D20", VA = "0x185D46B20")]
		public Enumerator SUCDGRURMDP()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D467A0", Offset = "0x5D459A0", VA = "0x185D467A0")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D47070", Offset = "0x5D46270", VA = "0x185D47070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class DOIEMSQPODV
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x35C2060", Offset = "0x35C1260", VA = "0x1835C2060")]
		public static ReadOnlyArray<T> QBTOLJPRCBP<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x857E5F0", Offset = "0x857D7F0", VA = "0x18857E5F0")]
		public static Stream XNXOAOPHNYI(this ReadOnlyArray<byte> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DebuggerTypeProxy(typeof(UnsafeList<>.MTYLLIMLECB))]
	public struct UnsafeList<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct MutEnumerator : ATXMBMXARWW, HNRJVFQGAJE<T>, TMMYPJDQGLZ<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private readonly T[] _items;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly int _count;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public readonly int XZMTABGDEVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6DB0", VA = "0x180CF7BB0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x5956470", Offset = "0x5955670", VA = "0x185956470", Slot = "11")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public readonly T UPQBPPWFJSA
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x5954FB0", Offset = "0x59541B0", VA = "0x185954FB0")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private readonly T PHSGUAGJBTJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x5955F70", Offset = "0x5955170", VA = "0x185955F70", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly T QKLNCJRFZQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x5955A20", Offset = "0x5954C20", VA = "0x185955A20", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private readonly object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x5955190", Offset = "0x5954390", VA = "0x185955190", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x59434B0", Offset = "0x59426B0", VA = "0x1859434B0")]
			internal MutEnumerator(T[] items, int count, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5955880", Offset = "0x5954A80", VA = "0x185955880")]
			public static MutEnumerator New(UnsafeList<T> self)
			{
				return default(MutEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4748540", Offset = "0x4747740", VA = "0x184748540", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4743AF0", Offset = "0x4742CF0", VA = "0x184743AF0", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct Enumerator : ATXMBMXARWW, TMMYPJDQGLZ<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int XZMTABGDEVJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x4745510", Offset = "0x4744710", VA = "0x184745510", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x4746E70", Offset = "0x4746070", VA = "0x184746E70", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly T QKLNCJRFZQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x47456B0", Offset = "0x47448B0", VA = "0x1847456B0", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private readonly object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x4743C60", Offset = "0x4742E60", VA = "0x184743C60", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x105B060", Offset = "0x105A260", VA = "0x18105B060")]
			private Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4745460", Offset = "0x4744660", VA = "0x184745460")]
			public static Enumerator New([In] UnsafeList<T> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4745380", Offset = "0x4744580", VA = "0x184745380", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4745540", Offset = "0x4744740", VA = "0x184745540", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4743B00", Offset = "0x4742D00", VA = "0x184743B00", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public sealed class MTYLLIMLECB
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal T[] _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal int _count;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62A9330", Offset = "0x62A8530", VA = "0x1862A9330")]
		public static UnsafeList<T> New()
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62A9200", Offset = "0x62A8400", VA = "0x1862A9200")]
		public static UnsafeList<T> LGZWFUKQNVE(int a)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB4E9A0", Offset = "0xB4DBA0", VA = "0x180B4E9A0")]
		internal UnsafeList(T[] items, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62AB480", Offset = "0x62AA680", VA = "0x1862AB480", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class BTUYUOCMMVU
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public delegate int SortCpyDelegate<TCtx, T>([In] TCtx ctx, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x34118E0", Offset = "0x3410AE0", VA = "0x1834118E0")]
		public static void Destroy<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3415DF0", Offset = "0x3414FF0", VA = "0x183415DF0")]
		public static string OGSUAKDOUFR<a>([In] this UnsafeList<a> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xC504B0", Offset = "0xC4F6B0", VA = "0x180C504B0")]
		public static b[] KLLAXESKZTA<b>([In] this UnsafeList<b> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2900470", Offset = "0x28FF670", VA = "0x182900470")]
		public static T Get<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x34136D0", Offset = "0x34128D0", VA = "0x1834136D0")]
		public static c XNICNFCHVJY<c>(this UnsafeList<c> a, int b)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x34133D0", Offset = "0x34125D0", VA = "0x1834133D0")]
		public static T GetCpy<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x34115A0", Offset = "0x34107A0", VA = "0x1834115A0")]
		public static void Set<T>(this UnsafeList<T> self, int i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x34115A0", Offset = "0x34107A0", VA = "0x1834115A0")]
		public static void DEFBSOHTDJE<d>(this UnsafeList<d> a, int b, d c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6DB0", VA = "0x180CF7BB0")]
		public static int DARSCHRRXNR<e>([In] this UnsafeList<e> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3410660", Offset = "0x340F860", VA = "0x183410660")]
		public static ReadOnlySpan<g> CZLFOFDRATM<g>([In] this UnsafeList<g> self)
		{
			return default(ReadOnlySpan<g>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3417C20", Offset = "0x3416E20", VA = "0x183417C20")]
		public static k[] PQVIWHZYJED<k>([In] this UnsafeList<k> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x34183A0", Offset = "0x34175A0", VA = "0x1834183A0")]
		public static m SAUCTSBHCNW<m>([In] this UnsafeList<m> self)
		{
			return (m)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3413A00", Offset = "0x3412C00", VA = "0x183413A00")]
		public static ReadOnlyArray<q> HUDBOITGURD<q>(this UnsafeList<q> a)
		{
			return default(ReadOnlyArray<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x340D680", Offset = "0x340C880", VA = "0x18340D680")]
		public static void Add<T>(this UnsafeList<T> self, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x34141D0", Offset = "0x34133D0", VA = "0x1834141D0")]
		public static void JDGNBCGHUUX<r>(this UnsafeList<r> a, r b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3413C20", Offset = "0x3412E20", VA = "0x183413C20")]
		public static void Insert<T>(this UnsafeList<T> self, int index, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3418DA0", Offset = "0x3417FA0", VA = "0x183418DA0")]
		public static void VCXMNJAIXNI<s>(this UnsafeList<s> a, int b, [In] UnsafeList<s> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3417E60", Offset = "0x3417060", VA = "0x183417E60")]
		public static void QYNBHFYMGPL<t>(this UnsafeList<t> a, int b, t c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3417A60", Offset = "0x3416C60", VA = "0x183417A60")]
		public static void PKRRNKHPOFH<u>(this UnsafeList<u> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3417960", Offset = "0x3416B60", VA = "0x183417960")]
		public static v OJIJWNCLTSU<v>(this UnsafeList<v> a)
		{
			return (v)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x340F510", Offset = "0x340E710", VA = "0x18340F510")]
		public static void BOJXPSYXMZH<w>(this UnsafeList<w> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3412610", Offset = "0x3411810", VA = "0x183412610")]
		private static void FVZMKIZMBBA<x>(this UnsafeList<x> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3410960", Offset = "0x340FB60", VA = "0x183410960")]
		public static void Clear<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3410C10", Offset = "0x340FE10", VA = "0x183410C10")]
		public static UnsafeList<T> Clone<T>([In] this UnsafeList<T> self, InFunc<T, T> cloneItem)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3419240", Offset = "0x3418440", VA = "0x183419240")]
		public static int YEWSCGKEOEI<y>([In] this UnsafeList<y> self, y a) where y : IEquatable<y>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3411110", Offset = "0x3410310", VA = "0x183411110")]
		public static bool Contains<T>([In] this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x34181C0", Offset = "0x34173C0", VA = "0x1834181C0")]
		public static bool Remove<T>(this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3418F70", Offset = "0x3418170", VA = "0x183418F70")]
		public static bool WHBKRYKGCKT<z>(this UnsafeList<z> a, [In] z value) where z : YTDJCTQVIZN<z>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3418D90", Offset = "0x3417F90", VA = "0x183418D90")]
		public static bool UJRFHDXYQLF<ba>([In] this UnsafeList<ba> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3419160", Offset = "0x3418360", VA = "0x183419160")]
		public static void XSBURIOKJPU<bg, bf>(this UnsafeList<bg> a, [In] bf ctx, SortCpyDelegate<bf, bg> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x34189E0", Offset = "0x3417BE0", VA = "0x1834189E0")]
		private static void UETZNHNKSOP<bi, bh>(UnsafeList<bi> a, [In] bh ctx, SortCpyDelegate<bh, bi> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3414B60", Offset = "0x3413D60", VA = "0x183414B60")]
		private static int MJCBBCAWFYV<bk, bj>(UnsafeList<bk> a, [In] bj ctx, SortCpyDelegate<bj, bk> b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x34135E0", Offset = "0x34127E0", VA = "0x1834135E0")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T>([In] this UnsafeList<T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3418F10", Offset = "0x3418110", VA = "0x183418F10")]
		public static UnsafeList<bl>.MutEnumerator VRHERTZHAZW<bl>(this UnsafeList<bl> a)
		{
			return default(UnsafeList<bl>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3418070", Offset = "0x3417270", VA = "0x183418070")]
		public static ConstEnumerable<bm, UnsafeList<bm>.Enumerator> RSUIYMUWHOS<bm>([In] this UnsafeList<bm> self)
		{
			return default(ConstEnumerable<bm, UnsafeList<bm>.Enumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class ZGQQQNDIJSQ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B1C0", Offset = "0x3C5A3C0", VA = "0x183C5B1C0")]
		public static a[] OFXYCOFWMXO<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public static void BABHWEMUCNZ<b>(b[] a)
		{
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
