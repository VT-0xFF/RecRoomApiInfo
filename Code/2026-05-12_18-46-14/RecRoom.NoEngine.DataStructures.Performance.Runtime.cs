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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4550", Offset = "0x9AF2F50", VA = "0x189AF4550")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Performance
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class OZQHCMMOZWA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D71DB0", Offset = "0x3D707B0", VA = "0x183D71DB0")]
		public static ReadOnlyArray<T> BSHMRUWNZOT<T>(this T[] a) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D73BB0", Offset = "0x3D725B0", VA = "0x183D73BB0")]
		public static CopyEnumerable<T, CopyEnumerator<T>> LYRPATPLSBR<T>(this T[] a) where T : notnull
		{
			return default(CopyEnumerable<T, CopyEnumerator<T>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class HTSSEZPFVXK<a> : IDisposable, NMPLJEDQXRI, IEnumerable<a>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private UnsafeList<a> XNVEPLJVSPN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public a this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x65E8C20", Offset = "0x65E7620", VA = "0x1865E8C20")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x65E8AB0", Offset = "0x65E74B0", VA = "0x1865E8AB0")]
		public static HTSSEZPFVXK<a> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x500C240", Offset = "0x500AC40", VA = "0x18500C240")]
		internal HTSSEZPFVXK([In] UnsafeList<a> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65E88F0", Offset = "0x65E72F0", VA = "0x1865E88F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65E8BA0", Offset = "0x65E75A0", VA = "0x1865E8BA0")]
		public void RMNAUYQEYVP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65E8910", Offset = "0x65E7310", VA = "0x1865E8910", Slot = "8")]
		public UnsafeList<a>.MutEnumerator GetEnumerator()
		{
			return default(UnsafeList<a>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65E8810", Offset = "0x65E7210", VA = "0x1865E8810", Slot = "6")]
		private IEnumerator<a> KEHYSNFVZBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65E8810", Offset = "0x65E7210", VA = "0x1865E8810", Slot = "7")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct ConstEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : UNJNXPBQHRR<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x12DECE0", Offset = "0x12DD6E0", VA = "0x1812DECE0")]
		internal ConstEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5490CE0", Offset = "0x548F6E0", VA = "0x185490CE0", Slot = "4")]
		private IEnumerator<T> KEHYSNFVZBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5490CE0", Offset = "0x548F6E0", VA = "0x185490CE0", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GEVGUELNBHM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x39541C0", Offset = "0x3952BC0", VA = "0x1839541C0")]
		public static ConstEnumerable<a, U> New<U>([In] U self) where U : UNJNXPBQHRR<a>
		{
			return default(ConstEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class XKBJLYQMCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x412C3E0", Offset = "0x412ADE0", VA = "0x18412C3E0")]
		public static int Count<T, U>([In] this ConstEnumerable<T, U> self) where U : UNJNXPBQHRR<T>, NMPLJEDQXRI
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class RPGLECBKEJR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x781B4D0", Offset = "0x7819ED0", VA = "0x18781B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x12DECE0", Offset = "0x12DD6E0", VA = "0x1812DECE0")]
		internal CopyEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5490CE0", Offset = "0x548F6E0", VA = "0x185490CE0", Slot = "4")]
		private IEnumerator<T> KEHYSNFVZBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5490CE0", Offset = "0x548F6E0", VA = "0x185490CE0", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class MDNYKEOCNRW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39541C0", Offset = "0x3952BC0", VA = "0x1839541C0")]
		public static CopyEnumerable<a, U> New<U>([In] U self) where U : IEnumerator<a>
		{
			return default(CopyEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class ILMDGPHCEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0C10", Offset = "0x3BAF610", VA = "0x183BB0C10")]
		public static CopyEnumerable<d, CopySelectEnumerator<b, c, d>> JWXMQJGSSAZ<d, b, c>([In] this CopyEnumerable<c, b> self, Func<c, d> a) where b : NMPLJEDQXRI, IEnumerator<c>
		{
			return default(CopyEnumerable<d, CopySelectEnumerator<b, c, d>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CopyEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, NMPLJEDQXRI
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
			[Cpp2IlInjected.Address(RVA = "0x54A54A0", Offset = "0x54A3EA0", VA = "0x1854A54A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private readonly object KXFWSOWDLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x54A5450", Offset = "0x54A3E50", VA = "0x1854A5450", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2B95160", Offset = "0x2B93B60", VA = "0x182B95160", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDC3640", Offset = "0xDC2040", VA = "0x180DC3640")]
		private CopyEnumerator(T[] self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x54A5300", Offset = "0x54A3D00", VA = "0x1854A5300")]
		public static CopyEnumerator<T> New(T[] self)
		{
			return default(CopyEnumerator<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B94DF0", Offset = "0x2B937F0", VA = "0x182B94DF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B95150", Offset = "0x2B93B50", VA = "0x182B95150", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct CopySelectEnumerator<TSourceEnumerator, TSource, TResult> : NMPLJEDQXRI, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : NMPLJEDQXRI, IEnumerator<TSource>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TSourceEnumerator _self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Func<TSource, TResult> _selector;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x54A5D00", Offset = "0x54A4700", VA = "0x1854A5D00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public readonly TResult Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x54A5E70", Offset = "0x54A4870", VA = "0x1854A5E70", Slot = "5")]
			get
			{
				return (TResult)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private readonly object KXFWSOWDLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x54A5880", Offset = "0x54A4280", VA = "0x1854A5880", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7EF0", Offset = "0x2BA68F0", VA = "0x182BA7EF0")]
		internal CopySelectEnumerator([In] TSourceEnumerator self, Func<TSource, TResult> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x54A5840", Offset = "0x54A4240", VA = "0x1854A5840", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x54A5B00", Offset = "0x54A4500", VA = "0x1854A5B00", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x54A55A0", Offset = "0x54A3FA0", VA = "0x1854A55A0", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class CPHUMQEZVEZ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x381FCF0", Offset = "0x381E6F0", VA = "0x18381FCF0")]
		public static string XQUGYMTKBHH<a>(this IEnumerable<a> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3807170", Offset = "0x3805B70", VA = "0x183807170")]
		public static string IYKFUYEUZKR<c>(this IEnumerable<c> a, string b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class OMLXXRAYRDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CB50", Offset = "0x3D6B550", VA = "0x183D6CB50")]
		public static bool ZQXDXFHJKQL<g, h>(this g a, [In] h item) where g : UNJNXPBQHRR<h> where h : WTBFSIOAEWL<h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C570", Offset = "0x3D6AF70", VA = "0x183D6C570")]
		public static int BJLIONHIPTJ<i, j>(this i a, [In] j value) where i : UNJNXPBQHRR<j> where j : WTBFSIOAEWL<j>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C630", Offset = "0x3D6B030", VA = "0x183D6C630")]
		public static CopySelectEnumerator<n, o, p> JWXMQJGSSAZ<n, o, p>(this n a, Func<o, p> b) where n : NMPLJEDQXRI, IEnumerator<o>
		{
			return default(CopySelectEnumerator<n, o, p>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CA90", Offset = "0x3D6B490", VA = "0x183D6CA90")]
		public static int XQTNZNMORCT<s, t>(this s a, [In] t value) where s : IEnumerator<t> where t : IEquatable<t>
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface UNJNXPBQHRR<a> : IEnumerator<a>, IEnumerator, IDisposable
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
	public interface NMPLJEDQXRI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface KKLMVMEYQKC<a> : UNJNXPBQHRR<a>, IEnumerator<a>, IEnumerator, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct MutEnumerable<T, U> : IEnumerable<T>, IEnumerable where U : KKLMVMEYQKC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly U _enumerator;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5491090", Offset = "0x548FA90", VA = "0x185491090")]
		internal MutEnumerable([In] U enumerator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5490EC0", Offset = "0x548F8C0", VA = "0x185490EC0", Slot = "6")]
		public U GetEnumerator()
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5490E40", Offset = "0x548F840", VA = "0x185490E40", Slot = "4")]
		private IEnumerator<T> KEHYSNFVZBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5490E40", Offset = "0x548F840", VA = "0x185490E40", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class UMZNCKUGOQL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3954220", Offset = "0x3952C20", VA = "0x183954220")]
		public static MutEnumerable<a, U> New<U>([In] U self) where U : KKLMVMEYQKC<a>
		{
			return default(MutEnumerable<a, U>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ReadOnlyArray<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct Enumerator : NMPLJEDQXRI, UNJNXPBQHRR<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly T[] _self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public readonly int KQOHZIVUHAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x2B95160", Offset = "0x2B93B60", VA = "0x182B95160", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x2B95180", Offset = "0x2B93B80", VA = "0x182B95180", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private readonly T GNSAKLWDGDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5CA1930", Offset = "0x5CA0330", VA = "0x185CA1930", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly object? KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x5CA3980", Offset = "0x5CA2380", VA = "0x185CA3980", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xDC3640", Offset = "0xDC2040", VA = "0x180DC3640")]
			private Enumerator(T[] self, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x54A5300", Offset = "0x54A3D00", VA = "0x1854A5300")]
			public static Enumerator New(T[] self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2B94DF0", Offset = "0x2B937F0", VA = "0x182B94DF0", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2B95150", Offset = "0x2B93B50", VA = "0x182B95150", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly T[] _array;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int FUKZCZVBGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2B95160", Offset = "0x2B93B60", VA = "0x182B95160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2B952D0", Offset = "0x2B93CD0", VA = "0x182B952D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xEF0480", Offset = "0xEEEE80", VA = "0x180EF0480")]
		internal ReadOnlyArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x784AF50", Offset = "0x7849950", VA = "0x18784AF50")]
		public static ReadOnlyArray<T> Empty()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEF0460", Offset = "0xEEEE60", VA = "0x180EF0460")]
		public IEnumerable<T> OLHHQHKLQQG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x784B4A0", Offset = "0x7849EA0", VA = "0x18784B4A0")]
		public ReadOnlySpan<T> TVBKTQGFCHU()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x784AD80", Offset = "0x7849780", VA = "0x18784AD80")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> EAWOIIIFIPP()
		{
			return default(ConstEnumerable<T, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x784AC90", Offset = "0x7849690", VA = "0x18784AC90")]
		public Enumerator BIJMVGNXFUZ()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x784B140", Offset = "0x7849B40", VA = "0x18784B140")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x784B860", Offset = "0x784A260", VA = "0x18784B860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class KOQTWAQYJRN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x337A930", Offset = "0x3379330", VA = "0x18337A930")]
		public static ReadOnlyArray<T> PVVUYPAAPYV<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF44F0", Offset = "0x9AF2EF0", VA = "0x189AF44F0")]
		public static Stream VNCTVEBILHK(this ReadOnlyArray<byte> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DebuggerTypeProxy(typeof(UnsafeList<>.TRVZRYKUCVL))]
	public struct UnsafeList<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct MutEnumerator : NMPLJEDQXRI, KKLMVMEYQKC<T>, UNJNXPBQHRR<T>, IEnumerator<T>, IEnumerator, IDisposable
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
			public readonly int KQOHZIVUHAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xF7AA50", Offset = "0xF79450", VA = "0x180F7AA50", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x728C200", Offset = "0x728AC00", VA = "0x18728C200", Slot = "11")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public readonly T TEUGTAJKAAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x728A7B0", Offset = "0x72891B0", VA = "0x18728A7B0")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private readonly T TNBNNJUYAJR
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x728AE70", Offset = "0x7289870", VA = "0x18728AE70", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly T GNSAKLWDGDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x728B300", Offset = "0x7289D00", VA = "0x18728B300", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private readonly object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x728BAF0", Offset = "0x728A4F0", VA = "0x18728BAF0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4EEB8C0", Offset = "0x4EEA2C0", VA = "0x184EEB8C0")]
			internal MutEnumerator(T[] items, int count, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x728B690", Offset = "0x728A090", VA = "0x18728B690")]
			public static MutEnumerator New(UnsafeList<T> self)
			{
				return default(MutEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5C88050", Offset = "0x5C86A50", VA = "0x185C88050", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5C88060", Offset = "0x5C86A60", VA = "0x185C88060", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct Enumerator : NMPLJEDQXRI, UNJNXPBQHRR<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public int KQOHZIVUHAP
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x5CA4EF0", Offset = "0x5CA38F0", VA = "0x185CA4EF0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x5CA5880", Offset = "0x5CA4280", VA = "0x185CA5880", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly T GNSAKLWDGDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x5CA1990", Offset = "0x5CA0390", VA = "0x185CA1990", Slot = "6")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private readonly object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x5CA3900", Offset = "0x5CA2300", VA = "0x185CA3900", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x12DECE0", Offset = "0x12DD6E0", VA = "0x1812DECE0")]
			private Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5CA3850", Offset = "0x5CA2250", VA = "0x185CA3850")]
			public static Enumerator New([In] UnsafeList<T> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5CA3770", Offset = "0x5CA2170", VA = "0x185CA3770", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5CA3A90", Offset = "0x5CA2490", VA = "0x185CA3A90", Slot = "10")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5CA18E0", Offset = "0x5CA02E0", VA = "0x185CA18E0", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public sealed class TRVZRYKUCVL
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal T[] _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal int _count;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7F24BE0", Offset = "0x7F235E0", VA = "0x187F24BE0")]
		public static UnsafeList<T> New()
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7F25A20", Offset = "0x7F24420", VA = "0x187F25A20")]
		public static UnsafeList<T> XNWNYMBADUO(int a)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xDC3640", Offset = "0xDC2040", VA = "0x180DC3640")]
		internal UnsafeList(T[] items, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F25580", Offset = "0x7F23F80", VA = "0x187F25580", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class CBZBAHZCKSS
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public delegate int SortCpyDelegate<TCtx, T>([In] TCtx ctx, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x37F18B0", Offset = "0x37F02B0", VA = "0x1837F18B0")]
		public static void Destroy<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x37EE190", Offset = "0x37ECB90", VA = "0x1837EE190")]
		public static string AJTGVISIQSH<a>([In] this UnsafeList<a> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xEF0460", Offset = "0xEEEE60", VA = "0x180EF0460")]
		public static b[] YYXQZQGTYFQ<b>([In] this UnsafeList<b> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B952D0", Offset = "0x2B93CD0", VA = "0x182B952D0")]
		public static T Get<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x37F0830", Offset = "0x37EF230", VA = "0x1837F0830")]
		public static c BOIEDZNMIRM<c>(this UnsafeList<c> a, int b)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x37F1CE0", Offset = "0x37F06E0", VA = "0x1837F1CE0")]
		public static T GetCpy<T>([In] this UnsafeList<T> self, int i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x37F25C0", Offset = "0x37F0FC0", VA = "0x1837F25C0")]
		public static void Set<T>(this UnsafeList<T> self, int i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x37F25C0", Offset = "0x37F0FC0", VA = "0x1837F25C0")]
		public static void IAQBDPQXRLQ<d>(this UnsafeList<d> a, int b, d c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xF7AA50", Offset = "0xF79450", VA = "0x180F7AA50")]
		public static int APBHXPELCRV<e>([In] this UnsafeList<e> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x37F5750", Offset = "0x37F4150", VA = "0x1837F5750")]
		public static ReadOnlySpan<g> TVBKTQGFCHU<g>([In] this UnsafeList<g> self)
		{
			return default(ReadOnlySpan<g>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x37F0D10", Offset = "0x37EF710", VA = "0x1837F0D10")]
		public static k[] CGZKHGIVWKD<k>([In] this UnsafeList<k> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x37F5A90", Offset = "0x37F4490", VA = "0x1837F5A90")]
		public static m TXSUJLVHVYE<m>([In] this UnsafeList<m> self)
		{
			return (m)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x37F3250", Offset = "0x37F1C50", VA = "0x1837F3250")]
		public static ReadOnlyArray<q> RDFFOGZMASR<q>(this UnsafeList<q> a)
		{
			return default(ReadOnlyArray<q>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x37F0270", Offset = "0x37EEC70", VA = "0x1837F0270")]
		public static void Add<T>(this UnsafeList<T> self, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x37F5BD0", Offset = "0x37F45D0", VA = "0x1837F5BD0")]
		public static void WHFUUGMPVFB<r>(this UnsafeList<r> a, r b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x37F2A90", Offset = "0x37F1490", VA = "0x1837F2A90")]
		public static void Insert<T>(this UnsafeList<T> self, int index, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x37F55E0", Offset = "0x37F3FE0", VA = "0x1837F55E0")]
		public static void TIKCLWGFVNA<s>(this UnsafeList<s> a, int b, [In] UnsafeList<s> values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x37F2EC0", Offset = "0x37F18C0", VA = "0x1837F2EC0")]
		public static void OKWFSIWIOFH<t>(this UnsafeList<t> a, int b, t c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x37F0740", Offset = "0x37EF140", VA = "0x1837F0740")]
		public static void BLPASJBTPOR<u>(this UnsafeList<u> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x37F2DC0", Offset = "0x37F17C0", VA = "0x1837F2DC0")]
		public static v MOQBZIAWUCA<v>(this UnsafeList<v> a)
		{
			return (v)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x37F3F10", Offset = "0x37F2910", VA = "0x1837F3F10")]
		public static void RMNAUYQEYVP<w>(this UnsafeList<w> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x37F6140", Offset = "0x37F4B40", VA = "0x1837F6140")]
		private static void WPSJPYLSEAG<x>(this UnsafeList<x> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x37F0F50", Offset = "0x37EF950", VA = "0x1837F0F50")]
		public static void Clear<T>(this UnsafeList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x37F1200", Offset = "0x37EFC00", VA = "0x1837F1200")]
		public static UnsafeList<T> Clone<T>([In] this UnsafeList<T> self, InFunc<T, T> cloneItem)
		{
			return default(UnsafeList<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x37F2010", Offset = "0x37F0A10", VA = "0x1837F2010")]
		public static int HYFKXKFRQII<y>([In] this UnsafeList<y> self, y a) where y : IEquatable<y>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x37F1700", Offset = "0x37F0100", VA = "0x1837F1700")]
		public static bool Contains<T>([In] this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x37F4EC0", Offset = "0x37F38C0", VA = "0x1837F4EC0")]
		public static bool Remove<T>(this UnsafeList<T> self, T value) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x37F0A10", Offset = "0x37EF410", VA = "0x1837F0A10")]
		public static bool BOIUETCBEEH<z>(this UnsafeList<z> a, [In] z value) where z : WTBFSIOAEWL<z>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x37F5F10", Offset = "0x37F4910", VA = "0x1837F5F10")]
		public static bool WJCYHWPRZIP<ba>([In] this UnsafeList<ba> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x37F29B0", Offset = "0x37F13B0", VA = "0x1837F29B0")]
		public static void ILIWIPIFCBM<bg, bf>(this UnsafeList<bg> a, [In] bf ctx, SortCpyDelegate<bf, bg> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x37F1A60", Offset = "0x37F0460", VA = "0x1837F1A60")]
		private static void EMWRTNRXYVB<bi, bh>(UnsafeList<bi> a, [In] bh ctx, SortCpyDelegate<bh, bi> b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x37F7F10", Offset = "0x37F6910", VA = "0x1837F7F10")]
		private static int ZHNONDYMXPP<bk, bj>(UnsafeList<bk> a, [In] bj ctx, SortCpyDelegate<bj, bk> b, int c, int d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x37F1F20", Offset = "0x37F0920", VA = "0x1837F1F20")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T>([In] this UnsafeList<T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x37F2D60", Offset = "0x37F1760", VA = "0x1837F2D60")]
		public static UnsafeList<bl>.MutEnumerator JMJTRQOTJFC<bl>(this UnsafeList<bl> a)
		{
			return default(UnsafeList<bl>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x37F7930", Offset = "0x37F6330", VA = "0x1837F7930")]
		public static ConstEnumerable<bm, UnsafeList<bm>.Enumerator> XJDVMKKPGQS<bm>([In] this UnsafeList<bm> self)
		{
			return default(ConstEnumerable<bm, UnsafeList<bm>.Enumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class KABFACTMGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3C07E40", Offset = "0x3C06840", VA = "0x183C07E40")]
		public static a[] YGNHJSMBRYA<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		public static void TYVOZPTHYPN<b>(b[] a)
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
