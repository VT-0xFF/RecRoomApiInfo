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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85E9160", Offset = "0x85E8160", VA = "0x1885E9160")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Performance
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HXRUPMGTQDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3765680", Offset = "0x3764680", VA = "0x183765680")]
		public static ReadOnlyArray<T> DEPWLMTMMMK<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3765620", Offset = "0x3764620", VA = "0x183765620")]
		public static CopyEnumerable<T, CopyEnumerator<T>> CHDRDLSLJJU<T>(this T[] a) where T : notnull
		{
			return default(CopyEnumerable<T, CopyEnumerator<T>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class XLFSNFFHGIJ<a> : IDisposable, INBNBPJFRZL, IEnumerable<a>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private UnsafeList<a> WMRFDFDZTOW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public a this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3E97820", Offset = "0x3E96820", VA = "0x183E97820")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3E97620", Offset = "0x3E96620", VA = "0x183E97620")]
		public static XLFSNFFHGIJ<a> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E24680", Offset = "0x3E23680", VA = "0x183E24680")]
		internal XLFSNFFHGIJ([In] UnsafeList<a> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E97420", Offset = "0x3E96420", VA = "0x183E97420", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E975C0", Offset = "0x3E965C0", VA = "0x183E975C0")]
		public void LAOBJDCBQEM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E97470", Offset = "0x3E96470", VA = "0x183E97470", Slot = "8")]
		public UnsafeList<a>.MutEnumerator GetEnumerator()
		{
			return default(UnsafeList<a>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E97560", Offset = "0x3E96560", VA = "0x183E97560", Slot = "6")]
		private IEnumerator<a> UWMBGLNSYIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E97560", Offset = "0x3E96560", VA = "0x183E97560", Slot = "7")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct ConstEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : PQIIHBRULKY<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x104DAA0", Offset = "0x104CAA0", VA = "0x18104DAA0")]
		internal ConstEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x104DA70", Offset = "0x104CA70", VA = "0x18104DA70", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4164190", Offset = "0x4163190", VA = "0x184164190", Slot = "4")]
		private IEnumerator<T> UWMBGLNSYIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4164190", Offset = "0x4163190", VA = "0x184164190", Slot = "5")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class QNIGNYQXBXJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x35FACC0", Offset = "0x35F9CC0", VA = "0x1835FACC0")]
		public static ConstEnumerable<a, U> New<U>([In] U self) where U : PQIIHBRULKY<a>
		{
			return default(ConstEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GNJDEEILEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x374B940", Offset = "0x374A940", VA = "0x18374B940")]
		public static int Count<T, U>([In] this ConstEnumerable<T, U> self) where U : PQIIHBRULKY<T>, INBNBPJFRZL
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class MDQFCPQLYEG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5A7E250", Offset = "0x5A7D250", VA = "0x185A7E250")]
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
		[Cpp2IlInjected.Address(RVA = "0x104DAA0", Offset = "0x104CAA0", VA = "0x18104DAA0")]
		internal CopyEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x104DA70", Offset = "0x104CA70", VA = "0x18104DA70", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4164190", Offset = "0x4163190", VA = "0x184164190", Slot = "4")]
		private IEnumerator<T> UWMBGLNSYIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4164190", Offset = "0x4163190", VA = "0x184164190", Slot = "5")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class SUPQUAKFAUH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x35FACC0", Offset = "0x35F9CC0", VA = "0x1835FACC0")]
		public static CopyEnumerable<a, U> New<U>([In] U self) where U : IEnumerator<a>
		{
			return default(CopyEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class KAIQPQJMUZK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x380E130", Offset = "0x380D130", VA = "0x18380E130")]
		public static CopyEnumerable<d, CopySelectEnumerator<b, c, d>> CJWTWNSNJVQ<d, b, c>([In] this CopyEnumerable<c, b> self, Func<c, d> a) where b : INBNBPJFRZL, IEnumerator<c>
		{
			return default(CopyEnumerable<d, CopySelectEnumerator<b, c, d>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CopyEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, INBNBPJFRZL
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
			[Cpp2IlInjected.Address(RVA = "0x41724D0", Offset = "0x41714D0", VA = "0x1841724D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private readonly object OPJHDGDZAVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4172430", Offset = "0x4171430", VA = "0x184172430", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly int WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x291A900", Offset = "0x2919900", VA = "0x18291A900", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB43010", Offset = "0xB42010", VA = "0x180B43010")]
		private CopyEnumerator(T[] self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4172480", Offset = "0x4171480", VA = "0x184172480")]
		public static CopyEnumerator<T> New(T[] self)
		{
			return default(CopyEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x291AB00", Offset = "0x2919B00", VA = "0x18291AB00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x291ABE0", Offset = "0x2919BE0", VA = "0x18291ABE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CopySelectEnumerator<TSourceEnumerator, TSource, TResult> : INBNBPJFRZL, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : INBNBPJFRZL, IEnumerator<TSource>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TSourceEnumerator _self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Func<TSource, TResult> _selector;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly int WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4172A40", Offset = "0x4171A40", VA = "0x184172A40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly TResult Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4172E90", Offset = "0x4171E90", VA = "0x184172E90", Slot = "5")]
			get
			{
				return (TResult)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private readonly object OPJHDGDZAVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4172830", Offset = "0x4171830", VA = "0x184172830", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x292D120", Offset = "0x292C120", VA = "0x18292D120")]
		internal CopySelectEnumerator([In] TSourceEnumerator self, Func<TSource, TResult> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4172BC0", Offset = "0x4171BC0", VA = "0x184172BC0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4172D40", Offset = "0x4171D40", VA = "0x184172D40", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x41725D0", Offset = "0x41715D0", VA = "0x1841725D0", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class DQCVAQDPJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x35DEAF0", Offset = "0x35DDAF0", VA = "0x1835DEAF0")]
		public static string WGQBSLEKQYM<a>(this IEnumerable<a> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x35E1850", Offset = "0x35E0850", VA = "0x1835E1850")]
		public static string YWZDVTYXDCQ<c>(this IEnumerable<c> a, string b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IIWUCBCUQUR
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3780C20", Offset = "0x377FC20", VA = "0x183780C20")]
		public static bool QHEGSQKLJQW<g, h>(this g a, [In] h item) where g : PQIIHBRULKY<h> where h : MMKZQVOZTVS<h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3781240", Offset = "0x3780240", VA = "0x183781240")]
		public static int XORVYXRJRBO<i, j>(this i a, [In] j value) where i : PQIIHBRULKY<j> where j : MMKZQVOZTVS<j>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3780720", Offset = "0x377F720", VA = "0x183780720")]
		public static CopySelectEnumerator<n, o, p> CJWTWNSNJVQ<n, o, p>(this n a, Func<o, p> b) where n : INBNBPJFRZL, IEnumerator<o>
		{
			return default(CopySelectEnumerator<n, o, p>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3780B60", Offset = "0x377FB60", VA = "0x183780B60")]
		public static int FEGMTEYLXXU<s, t>(this s a, [In] t value) where s : IEnumerator<t> where t : IEquatable<t>
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface PQIIHBRULKY<a> : IEnumerator<a>, IEnumerator, IDisposable
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
	public interface INBNBPJFRZL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int WNETLZWSODY
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface MGEGHZHBVGJ<a> : PQIIHBRULKY<a>, IEnumerator<a>, IEnumerator, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct MutEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : MGEGHZHBVGJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4164340", Offset = "0x4163340", VA = "0x184164340")]
		internal MutEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4163FA0", Offset = "0x4162FA0", VA = "0x184163FA0", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x41641F0", Offset = "0x41631F0", VA = "0x1841641F0", Slot = "4")]
		private IEnumerator<T> UWMBGLNSYIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x41641F0", Offset = "0x41631F0", VA = "0x1841641F0", Slot = "5")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class DRTURYFIKEG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x35FAD20", Offset = "0x35F9D20", VA = "0x1835FAD20")]
		public static MutEnumerable<a, U> New<U>([In] U self) where U : MGEGHZHBVGJ<a>
		{
			return default(MutEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ReadOnlyArray<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct Enumerator : INBNBPJFRZL, PQIIHBRULKY<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly T[] _self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public readonly int WNETLZWSODY
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x291A900", Offset = "0x2919900", VA = "0x18291A900", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x291ABA0", Offset = "0x2919BA0", VA = "0x18291ABA0", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly T RHTHDTKBJPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x490E360", Offset = "0x490D360", VA = "0x18490E360", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly object? OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x490E2A0", Offset = "0x490D2A0", VA = "0x18490E2A0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB43010", Offset = "0xB42010", VA = "0x180B43010")]
			private Enumerator(T[] self, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4172480", Offset = "0x4171480", VA = "0x184172480")]
			public static Enumerator New(T[] self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x291AB00", Offset = "0x2919B00", VA = "0x18291AB00", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x291ABE0", Offset = "0x2919BE0", VA = "0x18291ABE0", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly T[] _array;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int KNJNUUEZHUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x291A900", Offset = "0x2919900", VA = "0x18291A900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x291C620", Offset = "0x291B620", VA = "0x18291C620")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
		internal ReadOnlyArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5EADEF0", Offset = "0x5EACEF0", VA = "0x185EADEF0")]
		public static ReadOnlyArray<T> Empty()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC41C30", Offset = "0xC40C30", VA = "0x180C41C30")]
		public IEnumerable<T> FDGZVMJLTHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE470", Offset = "0x5EAD470", VA = "0x185EAE470")]
		public ReadOnlySpan<T> MHRYDASKBZP()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE2A0", Offset = "0x5EAD2A0", VA = "0x185EAE2A0")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> IBJNVSBPSYS()
		{
			return default(ConstEnumerable<T, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EADE00", Offset = "0x5EACE00", VA = "0x185EADE00")]
		public Enumerator ELNSRNMPHAW()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE0E0", Offset = "0x5EAD0E0", VA = "0x185EAE0E0")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE9D0", Offset = "0x5EAD9D0", VA = "0x185EAE9D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ZAXVZGPSIZM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x36BF230", Offset = "0x36BE230", VA = "0x1836BF230")]
		public static ReadOnlyArray<T> ICZKLBGURNK<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85E91E0", Offset = "0x85E81E0", VA = "0x1885E91E0")]
		public static Stream FWTZOEWGMZB(this ReadOnlyArray<byte> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DebuggerTypeProxy(typeof(UnsafeList<>.EBVUUTPNVSA))]
	public struct UnsafeList<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct MutEnumerator : INBNBPJFRZL, MGEGHZHBVGJ<T>, PQIIHBRULKY<T>, IEnumerator<T>, IEnumerator, IDisposable
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
			public readonly int WNETLZWSODY
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xCED200", Offset = "0xCEC200", VA = "0x180CED200", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x5B01FB0", Offset = "0x5B00FB0", VA = "0x185B01FB0", Slot = "11")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public readonly T EEWSSEMCYKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x5B010E0", Offset = "0x5B000E0", VA = "0x185B010E0")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private readonly T YDAGPXJWBBU
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x5B019E0", Offset = "0x5B009E0", VA = "0x185B019E0", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly T RHTHDTKBJPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x5B01530", Offset = "0x5B00530", VA = "0x185B01530", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private readonly object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x5B00490", Offset = "0x5AFF490", VA = "0x185B00490", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3D41540", Offset = "0x3D40540", VA = "0x183D41540")]
			internal MutEnumerator(T[] items, int count, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5B01850", Offset = "0x5B00850", VA = "0x185B01850")]
			public static MutEnumerator New(UnsafeList<T> self)
			{
				return default(MutEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4912E40", Offset = "0x4911E40", VA = "0x184912E40", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x490E140", Offset = "0x490D140", VA = "0x18490E140", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct Enumerator : INBNBPJFRZL, PQIIHBRULKY<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int WNETLZWSODY
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x490E330", Offset = "0x490D330", VA = "0x18490E330", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x4911560", Offset = "0x4910560", VA = "0x184911560", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly T RHTHDTKBJPI
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x490E3C0", Offset = "0x490D3C0", VA = "0x18490E3C0", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private readonly object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x490E1A0", Offset = "0x490D1A0", VA = "0x18490E1A0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x104DAA0", Offset = "0x104CAA0", VA = "0x18104DAA0")]
			private Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x490FC60", Offset = "0x490EC60", VA = "0x18490FC60")]
			public static Enumerator New([In] UnsafeList<T> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x490FB80", Offset = "0x490EB80", VA = "0x18490FB80", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x490FD10", Offset = "0x490ED10", VA = "0x18490FD10", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x490E150", Offset = "0x490D150", VA = "0x18490E150", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public sealed class EBVUUTPNVSA
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal T[] _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal int _count;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63FFBA0", Offset = "0x63FEBA0", VA = "0x1863FFBA0")]
		public static UnsafeList<T> New()
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63FF680", Offset = "0x63FE680", VA = "0x1863FF680")]
		public static UnsafeList<T> FUKNBMWEXZF(int a)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB43010", Offset = "0xB42010", VA = "0x180B43010")]
		internal UnsafeList(T[] items, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6400D60", Offset = "0x63FFD60", VA = "0x186400D60", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class ALSPEDATIHT
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public delegate int SortCpyDelegate<TCtx, T>([In] TCtx ctx, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x30D02E0", Offset = "0x30CF2E0", VA = "0x1830D02E0")]
		public static void Destroy<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x30D86A0", Offset = "0x30D76A0", VA = "0x1830D86A0")]
		public static string YYCDGIGTMXE<a>([In] this UnsafeList<a> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xC41C30", Offset = "0xC40C30", VA = "0x180C41C30")]
		public static b[] KYZQTAFUUFX<b>([In] this UnsafeList<b> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x291C620", Offset = "0x291B620", VA = "0x18291C620")]
		public static T Get<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x30D0880", Offset = "0x30CF880", VA = "0x1830D0880")]
		public static c SKNXRLRNMAN<c>(this UnsafeList<c> a, int b)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x30D05B0", Offset = "0x30CF5B0", VA = "0x1830D05B0")]
		public static T GetCpy<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x30D5AC0", Offset = "0x30D4AC0", VA = "0x1830D5AC0")]
		public static void Set<T>(this UnsafeList<T> self, int i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x30D5AC0", Offset = "0x30D4AC0", VA = "0x1830D5AC0")]
		public static void OEPUROYLSIF<d>(this UnsafeList<d> a, int b, d c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xCED200", Offset = "0xCEC200", VA = "0x180CED200")]
		public static int LYKRTDJOSJG<e>([In] this UnsafeList<e> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x30D54E0", Offset = "0x30D44E0", VA = "0x1830D54E0")]
		public static ReadOnlySpan<g> MHRYDASKBZP<g>([In] this UnsafeList<g> self)
		{
			return default(ReadOnlySpan<g>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x30D6BD0", Offset = "0x30D5BD0", VA = "0x1830D6BD0")]
		public static k[] UXCBJCIVAMO<k>([In] this UnsafeList<k> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x30CF1F0", Offset = "0x30CE1F0", VA = "0x1830CF1F0")]
		public static m CBBUSYUQHIJ<m>([In] this UnsafeList<m> self)
		{
			return (m)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x30DA4B0", Offset = "0x30D94B0", VA = "0x1830DA4B0")]
		public static ReadOnlyArray<q> ZCLFKTBVUDO<q>(this UnsafeList<q> a)
		{
			return default(ReadOnlyArray<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x30CECA0", Offset = "0x30CDCA0", VA = "0x1830CECA0")]
		public static void Add<T>(this UnsafeList<T> self, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x30D7130", Offset = "0x30D6130", VA = "0x1830D7130")]
		public static void VOPBWXLPAKU<r>(this UnsafeList<r> a, r b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x30D0B10", Offset = "0x30CFB10", VA = "0x1830D0B10")]
		public static void Insert<T>(this UnsafeList<T> self, int index, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x30D03B0", Offset = "0x30CF3B0", VA = "0x1830D03B0")]
		public static void EGQUSRCJDTZ<s>(this UnsafeList<s> a, int b, [In] UnsafeList<s> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x30D5E50", Offset = "0x30D4E50", VA = "0x1830D5E50")]
		public static void PGNWGCFOPNG<t>(this UnsafeList<t> a, int b, t c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x30D54A0", Offset = "0x30D44A0", VA = "0x1830D54A0")]
		public static void LTEZPNIDGWC<u>(this UnsafeList<u> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x30D7540", Offset = "0x30D6540", VA = "0x1830D7540")]
		public static v XGHPXOJQTXH<v>(this UnsafeList<v> a)
		{
			return (v)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x30D4440", Offset = "0x30D3440", VA = "0x1830D4440")]
		public static void LAOBJDCBQEM<w>(this UnsafeList<w> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x30D1B50", Offset = "0x30D0B50", VA = "0x1830D1B50")]
		private static void JJUTANPXZLX<x>(this UnsafeList<x> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x30CF500", Offset = "0x30CE500", VA = "0x1830CF500")]
		public static void Clear<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x30CF7B0", Offset = "0x30CE7B0", VA = "0x1830CF7B0")]
		public static UnsafeList<T> Clone<T>([In] this UnsafeList<T> self, InFunc<T, T> cloneItem)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x30CF240", Offset = "0x30CE240", VA = "0x1830CF240")]
		public static int CXKAOPQIZOZ<y>([In] this UnsafeList<y> self, y a) where y : IEquatable<y>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x30CFCB0", Offset = "0x30CECB0", VA = "0x1830CFCB0")]
		public static bool Contains<T>([In] this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x30D6330", Offset = "0x30D5330", VA = "0x1830D6330")]
		public static bool Remove<T>(this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x30D61B0", Offset = "0x30D51B0", VA = "0x1830D61B0")]
		public static bool RXVLRUSQSLG<z>(this UnsafeList<z> a, [In] z value) where z : MMKZQVOZTVS<z>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x30D5E40", Offset = "0x30D4E40", VA = "0x1830D5E40")]
		public static bool OPWPRMKHCCE<ba>([In] this UnsafeList<ba> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x30D6E80", Offset = "0x30D5E80", VA = "0x1830D6E80")]
		public static void VDTBZYUKMAP<bg, bf>(this UnsafeList<bg> a, [In] bf ctx, SortCpyDelegate<bf, bg> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x30CFF30", Offset = "0x30CEF30", VA = "0x1830CFF30")]
		private static void DOVFYMGPEYO<bi, bh>(UnsafeList<bi> a, [In] bh ctx, SortCpyDelegate<bh, bi> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x30D2D20", Offset = "0x30D1D20", VA = "0x1830D2D20")]
		private static int KEKIUOURRLA<bk, bj>(UnsafeList<bk> a, [In] bj ctx, SortCpyDelegate<bj, bk> b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x30D07F0", Offset = "0x30CF7F0", VA = "0x1830D07F0")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T>([In] this UnsafeList<T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x30CF0F0", Offset = "0x30CE0F0", VA = "0x1830CF0F0")]
		public static UnsafeList<bl>.MutEnumerator BWNLTGDVXNJ<bl>(this UnsafeList<bl> a)
		{
			return default(UnsafeList<bl>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x30D6060", Offset = "0x30D5060", VA = "0x1830D6060")]
		public static ConstEnumerable<bm, UnsafeList<bm>.Enumerator> PULKCYSDEXJ<bm>([In] this UnsafeList<bm> self)
		{
			return default(ConstEnumerable<bm, UnsafeList<bm>.Enumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class PFRYTUGVWKP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3970FF0", Offset = "0x396FFF0", VA = "0x183970FF0")]
		public static a[] BBJVXWRZVOZ<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void KQKYQAJVCCS<b>(b[] a)
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
