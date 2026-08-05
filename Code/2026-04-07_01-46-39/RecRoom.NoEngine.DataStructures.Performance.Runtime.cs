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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B0A4F0", Offset = "0x9B094F0", VA = "0x189B0A4F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Performance
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FSFRRDLAFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8DB0", Offset = "0x3AC7DB0", VA = "0x183AC8DB0")]
		public static ReadOnlyArray<T> GTJCYPZPAXL<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB970", Offset = "0x3ACA970", VA = "0x183ACB970")]
		public static CopyEnumerable<T, CopyEnumerator<T>> UBIDTQQCHHH<T>(this T[] a) where T : notnull
		{
			return default(CopyEnumerable<T, CopyEnumerator<T>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class RBFZHTLYAOC<a> : IDisposable, CAEGQGHKZKM, IEnumerable<a>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private UnsafeList<a> PYYABSCVHMZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int XKLXOHCJQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public a this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7801F00", Offset = "0x7800F00", VA = "0x187801F00")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7801BB0", Offset = "0x7800BB0", VA = "0x187801BB0")]
		public static RBFZHTLYAOC<a> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4FCB780", Offset = "0x4FCA780", VA = "0x184FCB780")]
		internal RBFZHTLYAOC([In] UnsafeList<a> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7801AD0", Offset = "0x7800AD0", VA = "0x187801AD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7801E30", Offset = "0x7800E30", VA = "0x187801E30")]
		public void XHUDUYHITHV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7801B20", Offset = "0x7800B20", VA = "0x187801B20", Slot = "8")]
		public UnsafeList<a>.MutEnumerator GetEnumerator()
		{
			return default(UnsafeList<a>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7801D70", Offset = "0x7800D70", VA = "0x187801D70", Slot = "6")]
		private IEnumerator<a> VRLGJIXUKVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7801D70", Offset = "0x7800D70", VA = "0x187801D70", Slot = "7")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct ConstEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : CPNMZULKFNT<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
		internal ConstEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5369510", Offset = "0x5368510", VA = "0x185369510", Slot = "4")]
		private IEnumerator<T> VRLGJIXUKVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5369510", Offset = "0x5368510", VA = "0x185369510", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class KPQIEYTSJBK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x38BBA00", Offset = "0x38BAA00", VA = "0x1838BBA00")]
		public static ConstEnumerable<a, U> New<U>([In] U self) where U : CPNMZULKFNT<a>
		{
			return default(ConstEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MRXNVFLKODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A6A0", Offset = "0x3C196A0", VA = "0x183C1A6A0")]
		public static int Count<T, U>([In] this ConstEnumerable<T, U> self) where U : CPNMZULKFNT<T>, CAEGQGHKZKM
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class KVPTZLUGLZX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6867680", Offset = "0x6866680", VA = "0x186867680")]
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
		[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
		internal CopyEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5369510", Offset = "0x5368510", VA = "0x185369510", Slot = "4")]
		private IEnumerator<T> VRLGJIXUKVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5369510", Offset = "0x5368510", VA = "0x185369510", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class HDYESZFYSVY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x38BBA00", Offset = "0x38BAA00", VA = "0x1838BBA00")]
		public static CopyEnumerable<a, U> New<U>([In] U self) where U : IEnumerator<a>
		{
			return default(CopyEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class EVHWKCORVAR
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x394D540", Offset = "0x394C540", VA = "0x18394D540")]
		public static CopyEnumerable<d, CopySelectEnumerator<b, c, d>> JVKNOQWPDVN<d, b, c>([In] this CopyEnumerable<c, b> self, Func<c, d> a) where b : CAEGQGHKZKM, IEnumerator<c>
		{
			return default(CopyEnumerable<d, CopySelectEnumerator<b, c, d>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CopyEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, CAEGQGHKZKM
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
			[Cpp2IlInjected.Address(RVA = "0x537DBD0", Offset = "0x537CBD0", VA = "0x18537DBD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private readonly object BVCEDTADISM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x537DB30", Offset = "0x537CB30", VA = "0x18537DB30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly int XKLXOHCJQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2B78D90", Offset = "0x2B77D90", VA = "0x182B78D90", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDAE230", Offset = "0xDAD230", VA = "0x180DAE230")]
		private CopyEnumerator(T[] self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x537DB80", Offset = "0x537CB80", VA = "0x18537DB80")]
		public static CopyEnumerator<T> New(T[] self)
		{
			return default(CopyEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B78E90", Offset = "0x2B77E90", VA = "0x182B78E90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B79110", Offset = "0x2B78110", VA = "0x182B79110", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CopySelectEnumerator<TSourceEnumerator, TSource, TResult> : CAEGQGHKZKM, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : CAEGQGHKZKM, IEnumerator<TSource>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TSourceEnumerator _self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Func<TSource, TResult> _selector;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly int XKLXOHCJQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x537E000", Offset = "0x537D000", VA = "0x18537E000", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly TResult Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x537E590", Offset = "0x537D590", VA = "0x18537E590", Slot = "5")]
			get
			{
				return (TResult)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private readonly object BVCEDTADISM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x537E140", Offset = "0x537D140", VA = "0x18537E140", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B840", Offset = "0x2B8A840", VA = "0x182B8B840")]
		internal CopySelectEnumerator([In] TSourceEnumerator self, Func<TSource, TResult> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x537E2C0", Offset = "0x537D2C0", VA = "0x18537E2C0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x537E440", Offset = "0x537D440", VA = "0x18537E440", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x537DCD0", Offset = "0x537CCD0", VA = "0x18537DCD0", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class WIAISEAXWJN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x40F44E0", Offset = "0x40F34E0", VA = "0x1840F44E0")]
		public static string WJMCENMGOTN<a>(this IEnumerable<a> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x40E6180", Offset = "0x40E5180", VA = "0x1840E6180")]
		public static string FRFBVOMJHGL<c>(this IEnumerable<c> a, string b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class CPWHVWMYYYY
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37E8400", Offset = "0x37E7400", VA = "0x1837E8400")]
		public static bool ZVWAKDHZLNT<g, h>(this g a, [In] h item) where g : CPNMZULKFNT<h> where h : VZURHGBSTCB<h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37E7E40", Offset = "0x37E6E40", VA = "0x1837E7E40")]
		public static int IBVOSEIMBEB<i, j>(this i a, [In] j value) where i : CPNMZULKFNT<j> where j : VZURHGBSTCB<j>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37E7F00", Offset = "0x37E6F00", VA = "0x1837E7F00")]
		public static CopySelectEnumerator<n, o, p> JVKNOQWPDVN<n, o, p>(this n a, Func<o, p> b) where n : CAEGQGHKZKM, IEnumerator<o>
		{
			return default(CopySelectEnumerator<n, o, p>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37E8340", Offset = "0x37E7340", VA = "0x1837E8340")]
		public static int MLULHXTYTJX<s, t>(this s a, [In] t value) where s : IEnumerator<t> where t : IEquatable<t>
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface CPNMZULKFNT<a> : IEnumerator<a>, IEnumerator, IDisposable
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
	public interface CAEGQGHKZKM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int XKLXOHCJQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface VPQLKCREQAA<a> : CPNMZULKFNT<a>, IEnumerator<a>, IEnumerator, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct MutEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : VPQLKCREQAA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x53697C0", Offset = "0x53687C0", VA = "0x1853697C0")]
		internal MutEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5369420", Offset = "0x5368420", VA = "0x185369420", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5369570", Offset = "0x5368570", VA = "0x185369570", Slot = "4")]
		private IEnumerator<T> VRLGJIXUKVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5369570", Offset = "0x5368570", VA = "0x185369570", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class NTLEPJAZJPT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x38BB9A0", Offset = "0x38BA9A0", VA = "0x1838BB9A0")]
		public static MutEnumerable<a, U> New<U>([In] U self) where U : VPQLKCREQAA<a>
		{
			return default(MutEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ReadOnlyArray<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct Enumerator : CAEGQGHKZKM, CPNMZULKFNT<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly T[] _self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public readonly int XKLXOHCJQTX
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2B78D90", Offset = "0x2B77D90", VA = "0x182B78D90", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2B78DB0", Offset = "0x2B77DB0", VA = "0x182B78DB0", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly T ORVKBIETJGN
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5B86990", Offset = "0x5B85990", VA = "0x185B86990", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly object? BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x5B86A30", Offset = "0x5B85A30", VA = "0x185B86A30", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xDAE230", Offset = "0xDAD230", VA = "0x180DAE230")]
			private Enumerator(T[] self, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x537DB80", Offset = "0x537CB80", VA = "0x18537DB80")]
			public static Enumerator New(T[] self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2B78E90", Offset = "0x2B77E90", VA = "0x182B78E90", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2B79110", Offset = "0x2B78110", VA = "0x182B79110", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly T[] _array;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int HEJIPADGNQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2B78D90", Offset = "0x2B77D90", VA = "0x182B78D90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2B79820", Offset = "0x2B78820", VA = "0x182B79820")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		internal ReadOnlyArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x785A150", Offset = "0x7859150", VA = "0x18785A150")]
		public static ReadOnlyArray<T> Empty()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
		public IEnumerable<T> LBMDEHENDGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x785A500", Offset = "0x7859500", VA = "0x18785A500")]
		public ReadOnlySpan<T> MUWIBAMXWSI()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x785A790", Offset = "0x7859790", VA = "0x18785A790")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> TOJIZDRNCXB()
		{
			return default(ConstEnumerable<T, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x785AF70", Offset = "0x7859F70", VA = "0x18785AF70")]
		public Enumerator ZTLDUEYXDPZ()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x785A340", Offset = "0x7859340", VA = "0x18785A340")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x785AC30", Offset = "0x7859C30", VA = "0x18785AC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class RPZZZJSBNUJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x39B5680", Offset = "0x39B4680", VA = "0x1839B5680")]
		public static ReadOnlyArray<T> TABOLLIPANB<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9B0A570", Offset = "0x9B09570", VA = "0x189B0A570")]
		public static Stream DKAJWLMSLCC(this ReadOnlyArray<byte> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DebuggerTypeProxy(typeof(UnsafeList<>.BBFVCIGKRPJ))]
	public struct UnsafeList<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct MutEnumerator : CAEGQGHKZKM, VPQLKCREQAA<T>, CPNMZULKFNT<T>, IEnumerator<T>, IEnumerator, IDisposable
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
			public readonly int XKLXOHCJQTX
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xF584A0", Offset = "0xF574A0", VA = "0x180F584A0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x72863F0", Offset = "0x72853F0", VA = "0x1872863F0", Slot = "11")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public readonly T CYEHBBWYWSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x7286010", Offset = "0x7285010", VA = "0x187286010")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private readonly T PGLNFLXSXFH
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x7285860", Offset = "0x7284860", VA = "0x187285860", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly T ORVKBIETJGN
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x7284A50", Offset = "0x7283A50", VA = "0x187284A50", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x7284FD0", Offset = "0x7283FD0", VA = "0x187284FD0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4EDAEA0", Offset = "0x4ED9EA0", VA = "0x184EDAEA0")]
			internal MutEnumerator(T[] items, int count, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7285740", Offset = "0x7284740", VA = "0x187285740")]
			public static MutEnumerator New(UnsafeList<T> self)
			{
				return default(MutEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5B6CFA0", Offset = "0x5B6BFA0", VA = "0x185B6CFA0", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5B6CFB0", Offset = "0x5B6BFB0", VA = "0x185B6CFB0", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct Enumerator : CAEGQGHKZKM, CPNMZULKFNT<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int XKLXOHCJQTX
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x5B86910", Offset = "0x5B85910", VA = "0x185B86910", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x5B8AC20", Offset = "0x5B89C20", VA = "0x185B8AC20", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly T ORVKBIETJGN
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x5B869F0", Offset = "0x5B859F0", VA = "0x185B869F0", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x5B86AC0", Offset = "0x5B85AC0", VA = "0x185B86AC0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
			private Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5B88C00", Offset = "0x5B87C00", VA = "0x185B88C00")]
			public static Enumerator New([In] UnsafeList<T> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5B88B20", Offset = "0x5B87B20", VA = "0x185B88B20", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5B88CB0", Offset = "0x5B87CB0", VA = "0x185B88CB0", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5B868C0", Offset = "0x5B858C0", VA = "0x185B868C0", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public sealed class BBFVCIGKRPJ
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal T[] _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal int _count;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EBA0", Offset = "0x7F3DBA0", VA = "0x187F3EBA0")]
		public static UnsafeList<T> New()
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EA70", Offset = "0x7F3DA70", VA = "0x187F3EA70")]
		public static UnsafeList<T> LCNHZFSNGFS(int a)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xDAE230", Offset = "0xDAD230", VA = "0x180DAE230")]
		internal UnsafeList(T[] items, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F40940", Offset = "0x7F3F940", VA = "0x187F40940", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class SGQPHRJKPPW
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public delegate int SortCpyDelegate<TCtx, T>([In] TCtx ctx, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8C30", Offset = "0x3EE7C30", VA = "0x183EE8C30")]
		public static void Destroy<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3EECEF0", Offset = "0x3EEBEF0", VA = "0x183EECEF0")]
		public static string LJSHBXAEUPP<a>([In] this UnsafeList<a> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
		public static b[] GOAVMPBQBXG<b>([In] this UnsafeList<b> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B79820", Offset = "0x2B78820", VA = "0x182B79820")]
		public static T Get<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8D80", Offset = "0x3EE7D80", VA = "0x183EE8D80")]
		public static c FMNARAWZCCY<c>(this UnsafeList<c> a, int b)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA940", Offset = "0x3EE9940", VA = "0x183EEA940")]
		public static T GetCpy<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3EE88F0", Offset = "0x3EE78F0", VA = "0x183EE88F0")]
		public static void Set<T>(this UnsafeList<T> self, int i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3EE88F0", Offset = "0x3EE78F0", VA = "0x183EE88F0")]
		public static void DKBRAGJZTHC<d>(this UnsafeList<d> a, int b, d c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xF584A0", Offset = "0xF574A0", VA = "0x180F584A0")]
		public static int SCHSMMIDATL<e>([In] this UnsafeList<e> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3EEEBB0", Offset = "0x3EEDBB0", VA = "0x183EEEBB0")]
		public static ReadOnlySpan<g> MUWIBAMXWSI<g>([In] this UnsafeList<g> self)
		{
			return default(ReadOnlySpan<g>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3EEFD30", Offset = "0x3EEED30", VA = "0x183EEFD30")]
		public static k[] TBGIINETWER<k>([In] this UnsafeList<k> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF2B0", Offset = "0x3EEE2B0", VA = "0x183EEF2B0")]
		public static m PQTQLPQTPCW<m>([In] this UnsafeList<m> self)
		{
			return (m)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB4B0", Offset = "0x3EEA4B0", VA = "0x183EEB4B0")]
		public static ReadOnlyArray<q> JDENQVYCZYD<q>(this UnsafeList<q> a)
		{
			return default(ReadOnlyArray<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7270", Offset = "0x3EE6270", VA = "0x183EE7270")]
		public static void Add<T>(this UnsafeList<T> self, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3EEFFF0", Offset = "0x3EEEFF0", VA = "0x183EEFFF0")]
		public static void TIJMETXQOWR<r>(this UnsafeList<r> a, r b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB040", Offset = "0x3EEA040", VA = "0x183EEB040")]
		public static void Insert<T>(this UnsafeList<T> self, int index, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3EE83B0", Offset = "0x3EE73B0", VA = "0x183EE83B0")]
		public static void DJSRRCVPXEI<s>(this UnsafeList<s> a, int b, [In] UnsafeList<s> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0330", Offset = "0x3EEF330", VA = "0x183EF0330")]
		public static void WZUJHUXQPXN<t>(this UnsafeList<t> a, int b, t c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8EE0", Offset = "0x3EE7EE0", VA = "0x183EE8EE0")]
		public static void FWAYYBTKHHN<u>(this UnsafeList<u> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF170", Offset = "0x3EEE170", VA = "0x183EEF170")]
		public static v PJMPBCCUMNY<v>(this UnsafeList<v> a)
		{
			return (v)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0D80", Offset = "0x3EEFD80", VA = "0x183EF0D80")]
		public static void XHUDUYHITHV<w>(this UnsafeList<w> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9B80", Offset = "0x3EE8B80", VA = "0x183EE9B80")]
		private static void GAKMMDDZWUU<x>(this UnsafeList<x> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7A60", Offset = "0x3EE6A60", VA = "0x183EE7A60")]
		public static void Clear<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7D10", Offset = "0x3EE6D10", VA = "0x183EE7D10")]
		public static UnsafeList<T> Clone<T>([In] this UnsafeList<T> self, InFunc<T, T> cloneItem)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3EEEEB0", Offset = "0x3EEDEB0", VA = "0x183EEEEB0")]
		public static int MVWDZYSTPQO<y>([In] this UnsafeList<y> self, y a) where y : IEquatable<y>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8210", Offset = "0x3EE7210", VA = "0x183EE8210")]
		public static bool Contains<T>([In] this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF450", Offset = "0x3EEE450", VA = "0x183EEF450")]
		public static bool Remove<T>(this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6760", Offset = "0x3EE5760", VA = "0x183EE6760")]
		public static bool AKQFBKACELD<z>(this UnsafeList<z> a, [In] z value) where z : VZURHGBSTCB<z>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CC50", Offset = "0x3D6BC50", VA = "0x183D6CC50")]
		public static bool ZANTMLNUIXH<ba>([In] this UnsafeList<ba> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF370", Offset = "0x3EEE370", VA = "0x183EEF370")]
		public static void PSNHTPXFJEA<bg, bf>(this UnsafeList<bg> a, [In] bf ctx, SortCpyDelegate<bf, bg> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAC90", Offset = "0x3EE9C90", VA = "0x183EEAC90")]
		private static void IDPUFYKDDMR<bi, bh>(UnsafeList<bi> a, [In] bh ctx, SortCpyDelegate<bh, bi> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3EEBB90", Offset = "0x3EEAB90", VA = "0x183EEBB90")]
		private static int KBONOJNOYEX<bk, bj>(UnsafeList<bk> a, [In] bj ctx, SortCpyDelegate<bj, bk> b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAB50", Offset = "0x3EE9B50", VA = "0x183EEAB50")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T>([In] this UnsafeList<T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF5F0", Offset = "0x3EEE5F0", VA = "0x183EEF5F0")]
		public static UnsafeList<bl>.MutEnumerator SPPFSVZNENE<bl>(this UnsafeList<bl> a)
		{
			return default(UnsafeList<bl>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3EF1670", Offset = "0x3EF0670", VA = "0x183EF1670")]
		public static ConstEnumerable<bm, UnsafeList<bm>.Enumerator> ZXOEKPMOXZK<bm>([In] this UnsafeList<bm> self)
		{
			return default(ConstEnumerable<bm, UnsafeList<bm>.Enumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class BDWHGMPJRTY
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3729650", Offset = "0x3728650", VA = "0x183729650")]
		public static a[] IVQAJVESVCK<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void IFJDFLQWPHD<b>(b[] a)
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
