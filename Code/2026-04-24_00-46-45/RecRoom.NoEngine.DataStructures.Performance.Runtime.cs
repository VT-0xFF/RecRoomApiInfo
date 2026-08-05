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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B1DF80", Offset = "0x9B1C980", VA = "0x189B1DF80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Performance
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class RTAJZOABAUK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0040", Offset = "0x3EDEA40", VA = "0x183EE0040")]
		public static ReadOnlyArray<T> ICVEFLYCEFH<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFFE0", Offset = "0x3EDE9E0", VA = "0x183EDFFE0")]
		public static CopyEnumerable<T, CopyEnumerator<T>> FEBOYWXIBSB<T>(this T[] a) where T : notnull
		{
			return default(CopyEnumerable<T, CopyEnumerator<T>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class YOAQUGQZHOO<a> : IDisposable, ULTYGGNROTW, IEnumerable<a>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private UnsafeList<a> TXYAKHNYNUJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public a this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x514C9C0", Offset = "0x514B3C0", VA = "0x18514C9C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x514C760", Offset = "0x514B160", VA = "0x18514C760")]
		public static YOAQUGQZHOO<a> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5006810", Offset = "0x5005210", VA = "0x185006810")]
		internal YOAQUGQZHOO([In] UnsafeList<a> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x514C570", Offset = "0x514AF70", VA = "0x18514C570", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x514C740", Offset = "0x514B140", VA = "0x18514C740")]
		public void MDTNLXOLGTJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x514C6C0", Offset = "0x514B0C0", VA = "0x18514C6C0", Slot = "8")]
		public UnsafeList<a>.MutEnumerator GetEnumerator()
		{
			return default(UnsafeList<a>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x514C5B0", Offset = "0x514AFB0", VA = "0x18514C5B0", Slot = "6")]
		private IEnumerator<a> EZYGKGYZAUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x514C5B0", Offset = "0x514AFB0", VA = "0x18514C5B0", Slot = "7")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct ConstEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : LAOQERQLANP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
		internal ConstEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x535E100", Offset = "0x535CB00", VA = "0x18535E100", Slot = "4")]
		private IEnumerator<T> EZYGKGYZAUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x535E100", Offset = "0x535CB00", VA = "0x18535E100", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DBPXCOPHGVG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x380F520", Offset = "0x380DF20", VA = "0x18380F520")]
		public static ConstEnumerable<a, U> New<U>([In] U self) where U : LAOQERQLANP<a>
		{
			return default(ConstEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class KYGITCUTFNV
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C08B60", Offset = "0x3C07560", VA = "0x183C08B60")]
		public static int Count<T, U>([In] this ConstEnumerable<T, U> self) where U : LAOQERQLANP<T>, ULTYGGNROTW
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class UNWVLUSRLYZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D26AF0", Offset = "0x7D254F0", VA = "0x187D26AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
		internal CopyEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x535E100", Offset = "0x535CB00", VA = "0x18535E100", Slot = "4")]
		private IEnumerator<T> EZYGKGYZAUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x535E100", Offset = "0x535CB00", VA = "0x18535E100", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class WLNZDBMBCCO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x380F520", Offset = "0x380DF20", VA = "0x18380F520")]
		public static CopyEnumerable<a, U> New<U>([In] U self) where U : IEnumerator<a>
		{
			return default(CopyEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class JIVJITRMVXT
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B8C6C0", Offset = "0x3B8B0C0", VA = "0x183B8C6C0")]
		public static CopyEnumerable<d, CopySelectEnumerator<b, c, d>> SOTSCEVXSML<d, b, c>([In] this CopyEnumerable<c, b> self, Func<c, d> a) where b : ULTYGGNROTW, IEnumerator<c>
		{
			return default(CopyEnumerable<d, CopySelectEnumerator<b, c, d>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CopyEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, ULTYGGNROTW
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
			[Cpp2IlInjected.Address(RVA = "0x5372930", Offset = "0x5371330", VA = "0x185372930", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private readonly object IFKDFAMTOCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x53728E0", Offset = "0x53712E0", VA = "0x1853728E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE090", Offset = "0x2BACA90", VA = "0x182BAE090", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
		private CopyEnumerator(T[] self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5372790", Offset = "0x5371190", VA = "0x185372790")]
		public static CopyEnumerator<T> New(T[] self)
		{
			return default(CopyEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BADD60", Offset = "0x2BAC760", VA = "0x182BADD60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE080", Offset = "0x2BACA80", VA = "0x182BAE080", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CopySelectEnumerator<TSourceEnumerator, TSource, TResult> : ULTYGGNROTW, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : ULTYGGNROTW, IEnumerator<TSource>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TSourceEnumerator _self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Func<TSource, TResult> _selector;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5372FC0", Offset = "0x53719C0", VA = "0x185372FC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly TResult Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5373300", Offset = "0x5371D00", VA = "0x185373300", Slot = "5")]
			get
			{
				return (TResult)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private readonly object IFKDFAMTOCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5372E10", Offset = "0x5371810", VA = "0x185372E10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BC84E0", Offset = "0x2BC6EE0", VA = "0x182BC84E0")]
		internal CopySelectEnumerator([In] TSourceEnumerator self, Func<TSource, TResult> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5372CD0", Offset = "0x53716D0", VA = "0x185372CD0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5372F90", Offset = "0x5371990", VA = "0x185372F90", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5372A30", Offset = "0x5371430", VA = "0x185372A30", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class ZEKRDIPJLSP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x416FF10", Offset = "0x416E910", VA = "0x18416FF10")]
		public static string VEHYHTQWXIH<a>(this IEnumerable<a> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4159990", Offset = "0x4158390", VA = "0x184159990")]
		public static string LOOKKUHWKZZ<c>(this IEnumerable<c> a, string b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class WVSTUJCAFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x411A500", Offset = "0x4118F00", VA = "0x18411A500")]
		public static bool HTZSKPBYVNT<g, h>(this g a, [In] h item) where g : LAOQERQLANP<h> where h : SCCEHWEFPHH<h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x411AC50", Offset = "0x4119650", VA = "0x18411AC50")]
		public static int ZUWTEBGDMSR<i, j>(this i a, [In] j value) where i : LAOQERQLANP<j> where j : SCCEHWEFPHH<j>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x411A850", Offset = "0x4119250", VA = "0x18411A850")]
		public static CopySelectEnumerator<n, o, p> SOTSCEVXSML<n, o, p>(this n a, Func<o, p> b) where n : ULTYGGNROTW, IEnumerator<o>
		{
			return default(CopySelectEnumerator<n, o, p>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x411A440", Offset = "0x4118E40", VA = "0x18411A440")]
		public static int EGGFVSIPJCN<s, t>(this s a, [In] t value) where s : IEnumerator<t> where t : IEquatable<t>
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface LAOQERQLANP<a> : IEnumerator<a>, IEnumerator, IDisposable
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
	public interface ULTYGGNROTW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface LBNSNSASDAU<a> : LAOQERQLANP<a>, IEnumerator<a>, IEnumerator, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct MutEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : LBNSNSASDAU<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x535E4B0", Offset = "0x535CEB0", VA = "0x18535E4B0")]
		internal MutEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x535E2E0", Offset = "0x535CCE0", VA = "0x18535E2E0", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x535E260", Offset = "0x535CC60", VA = "0x18535E260", Slot = "4")]
		private IEnumerator<T> EZYGKGYZAUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x535E260", Offset = "0x535CC60", VA = "0x18535E260", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class DCCZSSLPHCN<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x380F580", Offset = "0x380DF80", VA = "0x18380F580")]
		public static MutEnumerable<a, U> New<U>([In] U self) where U : LBNSNSASDAU<a>
		{
			return default(MutEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ReadOnlyArray<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct Enumerator : ULTYGGNROTW, LAOQERQLANP<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly T[] _self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public readonly int DJHUXMLNUTX
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2BAE090", Offset = "0x2BACA90", VA = "0x182BAE090", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2BADCE0", Offset = "0x2BAC6E0", VA = "0x182BADCE0", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly T KCZFSMOPHDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5BCE450", Offset = "0x5BCCE50", VA = "0x185BCE450", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly object? IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x5BD04E0", Offset = "0x5BCEEE0", VA = "0x185BD04E0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
			private Enumerator(T[] self, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5372790", Offset = "0x5371190", VA = "0x185372790")]
			public static Enumerator New(T[] self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2BADD60", Offset = "0x2BAC760", VA = "0x182BADD60", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE080", Offset = "0x2BACA80", VA = "0x182BAE080", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly T[] _array;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int XNBAVDEQHQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE090", Offset = "0x2BACA90", VA = "0x182BAE090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE6C0", Offset = "0x2BAD0C0", VA = "0x182BAE6C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		internal ReadOnlyArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7692730", Offset = "0x7691130", VA = "0x187692730")]
		public static ReadOnlyArray<T> Empty()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
		public IEnumerable<T> IWWIIPFRJYE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x76928D0", Offset = "0x76912D0", VA = "0x1876928D0")]
		public ReadOnlySpan<T> JMBCEAENHVG()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7692670", Offset = "0x7691070", VA = "0x187692670")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> BKPJBHQVBXV()
		{
			return default(ConstEnumerable<T, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7692870", Offset = "0x7691270", VA = "0x187692870")]
		public Enumerator HPRDWIYFCQT()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x76927F0", Offset = "0x76911F0", VA = "0x1876927F0")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7692B30", Offset = "0x7691530", VA = "0x187692B30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class WWDFWUMXFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x339F520", Offset = "0x339DF20", VA = "0x18339F520")]
		public static ReadOnlyArray<T> KFAOWKMAKWH<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1E000", Offset = "0x9B1CA00", VA = "0x189B1E000")]
		public static Stream STAGZVUYIUK(this ReadOnlyArray<byte> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DebuggerTypeProxy(typeof(UnsafeList<>.SJHIZCQUPAH))]
	public struct UnsafeList<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct MutEnumerator : ULTYGGNROTW, LBNSNSASDAU<T>, LAOQERQLANP<T>, IEnumerator<T>, IEnumerator, IDisposable
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
			public readonly int DJHUXMLNUTX
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xF8BE60", Offset = "0xF8A860", VA = "0x180F8BE60", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x71471F0", Offset = "0x7145BF0", VA = "0x1871471F0", Slot = "11")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public readonly T IWCYQTZYSBI
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x7145CC0", Offset = "0x71446C0", VA = "0x187145CC0")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private readonly T PCAZCRRNXAR
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x7146CD0", Offset = "0x71456D0", VA = "0x187146CD0", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly T KCZFSMOPHDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x71459A0", Offset = "0x71443A0", VA = "0x1871459A0", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x7146810", Offset = "0x7145210", VA = "0x187146810", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9B80", Offset = "0x4EF8580", VA = "0x184EF9B80")]
			internal MutEnumerator(T[] items, int count, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7146360", Offset = "0x7144D60", VA = "0x187146360")]
			public static MutEnumerator New(UnsafeList<T> self)
			{
				return default(MutEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5BB3B90", Offset = "0x5BB2590", VA = "0x185BB3B90", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5BB3BA0", Offset = "0x5BB25A0", VA = "0x185BB3BA0", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct Enumerator : ULTYGGNROTW, LAOQERQLANP<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int DJHUXMLNUTX
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x5BD1AB0", Offset = "0x5BD04B0", VA = "0x185BD1AB0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x5BD2360", Offset = "0x5BD0D60", VA = "0x185BD2360", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly T KCZFSMOPHDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x5BCE410", Offset = "0x5BCCE10", VA = "0x185BCE410", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x5BD03E0", Offset = "0x5BCEDE0", VA = "0x185BD03E0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
			private Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5BD0330", Offset = "0x5BCED30", VA = "0x185BD0330")]
			public static Enumerator New([In] UnsafeList<T> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5BD0250", Offset = "0x5BCEC50", VA = "0x185BD0250", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5BD0570", Offset = "0x5BCEF70", VA = "0x185BD0570", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5BCE3C0", Offset = "0x5BCCDC0", VA = "0x185BCE3C0", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public sealed class SJHIZCQUPAH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal T[] _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal int _count;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7D438E0", Offset = "0x7D422E0", VA = "0x187D438E0")]
		public static UnsafeList<T> New()
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45200", Offset = "0x7D43C00", VA = "0x187D45200")]
		public static UnsafeList<T> YDUAXTAHNPC(int a)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
		internal UnsafeList(T[] items, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7D44C00", Offset = "0x7D43600", VA = "0x187D44C00", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class MHXVUDZHRBS
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public delegate int SortCpyDelegate<TCtx, T>([In] TCtx ctx, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3C39FC0", Offset = "0x3C389C0", VA = "0x183C39FC0")]
		public static void Destroy<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3C3BA80", Offset = "0x3C3A480", VA = "0x183C3BA80")]
		public static string HZFIIBDKWMV<a>([In] this UnsafeList<a> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
		public static b[] YZKJKMPUNQM<b>([In] this UnsafeList<b> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE6C0", Offset = "0x2BAD0C0", VA = "0x182BAE6C0")]
		public static T Get<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A3C0", Offset = "0x3C38DC0", VA = "0x183C3A3C0")]
		public static c TBLSZXWCOGY<c>(this UnsafeList<c> a, int b)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A120", Offset = "0x3C38B20", VA = "0x183C3A120")]
		public static T GetCpy<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3C40A70", Offset = "0x3C3F470", VA = "0x183C40A70")]
		public static void Set<T>(this UnsafeList<T> self, int i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3C40A70", Offset = "0x3C3F470", VA = "0x183C40A70")]
		public static void YRLDDFPOHEY<d>(this UnsafeList<d> a, int b, d c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xF8BE60", Offset = "0xF8A860", VA = "0x180F8BE60")]
		public static int XAVQJSXVKBX<e>([In] this UnsafeList<e> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DBE0", Offset = "0x3C3C5E0", VA = "0x183C3DBE0")]
		public static ReadOnlySpan<g> JMBCEAENHVG<g>([In] this UnsafeList<g> self)
		{
			return default(ReadOnlySpan<g>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3C41060", Offset = "0x3C3FA60", VA = "0x183C41060")]
		public static k[] WIDAWYHKFUN<k>([In] this UnsafeList<k> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3C40770", Offset = "0x3C3F170", VA = "0x183C40770")]
		public static m SGXTQBVTAEO<m>([In] this UnsafeList<m> self)
		{
			return (m)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3C44410", Offset = "0x3C42E10", VA = "0x183C44410")]
		public static ReadOnlyArray<q> ZWWTJPZCXAL<q>(this UnsafeList<q> a)
		{
			return default(ReadOnlyArray<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3C38910", Offset = "0x3C37310", VA = "0x183C38910")]
		public static void Add<T>(this UnsafeList<T> self, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3C41470", Offset = "0x3C3FE70", VA = "0x183C41470")]
		public static void YNQAKNAMKZD<r>(this UnsafeList<r> a, r b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D910", Offset = "0x3C3C310", VA = "0x183C3D910")]
		public static void Insert<T>(this UnsafeList<T> self, int index, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D7A0", Offset = "0x3C3C1A0", VA = "0x183C3D7A0")]
		public static void IWJYIKUPLDC<s>(this UnsafeList<s> a, int b, [In] UnsafeList<s> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3C400C0", Offset = "0x3C3EAC0", VA = "0x183C400C0")]
		public static void QUJNCFCEDML<t>(this UnsafeList<t> a, int b, t c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3C40EA0", Offset = "0x3C3F8A0", VA = "0x183C40EA0")]
		public static void VDAZNXZCGLJ<u>(this UnsafeList<u> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3C441F0", Offset = "0x3C42BF0", VA = "0x183C441F0")]
		public static v ZSBLZQOEZJM<v>(this UnsafeList<v> a)
		{
			return (v)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F030", Offset = "0x3C3DA30", VA = "0x183C3F030")]
		public static void MDTNLXOLGTJ<w>(this UnsafeList<w> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3C426F0", Offset = "0x3C410F0", VA = "0x183C426F0")]
		private static void ZGUKVPQUPVO<x>(this UnsafeList<x> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3C39660", Offset = "0x3C38060", VA = "0x183C39660")]
		public static void Clear<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3C39910", Offset = "0x3C38310", VA = "0x183C39910")]
		public static UnsafeList<T> Clone<T>([In] this UnsafeList<T> self, InFunc<T, T> cloneItem)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3C40470", Offset = "0x3C3EE70", VA = "0x183C40470")]
		public static int SEUPVMMGXUO<y>([In] this UnsafeList<y> self, y a) where y : IEquatable<y>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3C39E10", Offset = "0x3C38810", VA = "0x183C39E10")]
		public static bool Contains<T>([In] this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3C402D0", Offset = "0x3C3ECD0", VA = "0x183C402D0")]
		public static bool Remove<T>(this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3C38D60", Offset = "0x3C37760", VA = "0x183C38D60")]
		public static bool CNBIDDNGHFD<z>(this UnsafeList<z> a, [In] z value) where z : SCCEHWEFPHH<z>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3C39FB0", Offset = "0x3C389B0", VA = "0x183C39FB0")]
		public static bool DFPZNIZKTBH<ba>([In] this UnsafeList<ba> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3C37FC0", Offset = "0x3C369C0", VA = "0x183C37FC0")]
		public static void AXMTAMSZYYM<bg, bf>(this UnsafeList<bg> a, [In] bf ctx, SortCpyDelegate<bf, bg> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A650", Offset = "0x3C39050", VA = "0x183C3A650")]
		private static void HGWYJHMYHUJ<bi, bh>(UnsafeList<bi> a, [In] bh ctx, SortCpyDelegate<bh, bi> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C39380", Offset = "0x3C37D80", VA = "0x183C39380")]
		private static int CVFJYNJAXVR<bk, bj>(UnsafeList<bk> a, [In] bj ctx, SortCpyDelegate<bj, bk> b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A330", Offset = "0x3C38D30", VA = "0x183C3A330")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T>([In] this UnsafeList<T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3C40060", Offset = "0x3C3EA60", VA = "0x183C40060")]
		public static UnsafeList<bl>.MutEnumerator MEWAPICAMGS<bl>(this UnsafeList<bl> a)
		{
			return default(UnsafeList<bl>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3C407C0", Offset = "0x3C3F1C0", VA = "0x183C407C0")]
		public static ConstEnumerable<bm, UnsafeList<bm>.Enumerator> SXJZHXIMNGQ<bm>([In] this UnsafeList<bm> self)
		{
			return default(ConstEnumerable<bm, UnsafeList<bm>.Enumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class MIUETPXCKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3C44630", Offset = "0x3C43030", VA = "0x183C44630")]
		public static a[] ZNPJYEWADCC<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void OMBUTKYPHTD<b>(b[] a)
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
