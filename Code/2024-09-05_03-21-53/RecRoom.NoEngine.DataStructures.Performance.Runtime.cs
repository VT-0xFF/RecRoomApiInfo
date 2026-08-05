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

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C7AB30", Offset = "0x6C79530", VA = "0x186C7AB30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EFPPIBDGBKC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A104F0", Offset = "0x2A0EEF0", VA = "0x182A104F0")]
	public static CGDDIIDHBMN<T> PAHLFHMFNIB<T>(this T[] PECHDAFMNOO) where T : notnull
	{
		return default(CGDDIIDHBMN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class ECMPBJLDCGH<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CBGFCAOFHCN<T> LOHBKDJBPLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3954FD0", Offset = "0x39539D0", VA = "0x183954FD0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3954F50", Offset = "0x3953950", VA = "0x183954F50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39550B0", Offset = "0x3953AB0", VA = "0x1839550B0")]
	public static ECMPBJLDCGH<T> MMKGNMBHOIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3952590", Offset = "0x3950F90", VA = "0x183952590")]
	internal ECMPBJLDCGH([In] CBGFCAOFHCN<T> BMCAAIIMEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3954F90", Offset = "0x3953990", VA = "0x183954F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3955070", Offset = "0x3953A70", VA = "0x183955070")]
	public void JMKNGEPLGLH(int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3955010", Offset = "0x3953A10", VA = "0x183955010", Slot = "8")]
	public CBGFCAOFHCN<T>.JENINNCFKFE GetEnumerator()
	{
		return default(CBGFCAOFHCN<T>.JENINNCFKFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x39551F0", Offset = "0x3953BF0", VA = "0x1839551F0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x39551F0", Offset = "0x3953BF0", VA = "0x1839551F0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HJDAACCJIHA<T, U> : IEnumerable<T>, IEnumerable where U : DCHALCHBMIC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U BAMJMOONNHH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20679B0", Offset = "0x20663B0", VA = "0x1820679B0")]
	internal HJDAACCJIHA([In] U ANMEDFHNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E45E70", Offset = "0x3E44870", VA = "0x183E45E70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3E45E70", Offset = "0x3E44870", VA = "0x183E45E70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BOGNJIJHHHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2BC10F0", Offset = "0x2BBFAF0", VA = "0x182BC10F0")]
	public static HJDAACCJIHA<T, U> MMKGNMBHOIH<U>([In] U PECHDAFMNOO) where U : DCHALCHBMIC<T>
	{
		return default(HJDAACCJIHA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CDOCMFNFDNB<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U BAMJMOONNHH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x225DC00", Offset = "0x225C600", VA = "0x18225DC00")]
	internal CDOCMFNFDNB([In] U ANMEDFHNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x225DBE0", Offset = "0x225C5E0", VA = "0x18225DBE0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5325D80", Offset = "0x5324780", VA = "0x185325D80", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5325D80", Offset = "0x5324780", VA = "0x185325D80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IHFKBKAILEP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2C992B0", Offset = "0x2C97CB0", VA = "0x182C992B0")]
	public static CDOCMFNFDNB<T, U> MMKGNMBHOIH<U>([In] U PECHDAFMNOO) where U : IEnumerator<T>
	{
		return default(CDOCMFNFDNB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class OIHBLGOEEFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2DFEEC0", Offset = "0x2DFD8C0", VA = "0x182DFEEC0")]
	public static string HDDAGCNKCII<T>(this IEnumerable<T> PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E048A0", Offset = "0x2E032A0", VA = "0x182E048A0")]
	public static string ONEHCNIHOAI<T>(this IEnumerable<T> PECHDAFMNOO, string NGKPGOLDJBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EBJAMNBOOEL
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F110", Offset = "0x2B1DB10", VA = "0x182B1F110")]
	public static bool HKGFFCAFBHK<TSourceEnumerator, TSource>(this TSourceEnumerator PECHDAFMNOO, [In] TSource EDKOAHIAMMF) where TSourceEnumerator : DCHALCHBMIC<TSource> where TSource : GHEOLLPMBFN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F290", Offset = "0x2B1DC90", VA = "0x182B1F290")]
	public static int NHPIKCBDODI<TSourceEnumerator, TSource>(this TSourceEnumerator PECHDAFMNOO, [In] TSource CLMKDBDPNNH) where TSourceEnumerator : DCHALCHBMIC<TSource> where TSource : GHEOLLPMBFN<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B1EEA0", Offset = "0x2B1D8A0", VA = "0x182B1EEA0")]
	public static int HAPMKJBJKLG<TSourceEnumerator, TSource>(this TSourceEnumerator PECHDAFMNOO, [In] TSource CLMKDBDPNNH) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DCHALCHBMIC<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T JOCMDMELDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BCCFPJEGHLL<T> : DCHALCHBMIC<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct ANHDEOOOHJE<T, U> : IEnumerable<T>, IEnumerable where U : BCCFPJEGHLL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U BAMJMOONNHH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3E45EF0", Offset = "0x3E448F0", VA = "0x183E45EF0")]
	internal ANHDEOOOHJE([In] U ANMEDFHNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A487C0", Offset = "0x3A471C0", VA = "0x183A487C0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3E45DE0", Offset = "0x3E447E0", VA = "0x183E45DE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E45DE0", Offset = "0x3E447E0", VA = "0x183E45DE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IMENBFFMOBN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1120", Offset = "0x2BBFB20", VA = "0x182BC1120")]
	public static ANHDEOOOHJE<T, U> MMKGNMBHOIH<U>([In] U PECHDAFMNOO) where U : BCCFPJEGHLL<T>
	{
		return default(ANHDEOOOHJE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct CGDDIIDHBMN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LGPFFMLIECC : DCHALCHBMIC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] JFCHFHOFHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int ALONHEBBILJ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x442B820", Offset = "0x442A220", VA = "0x18442B820", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x442B100", Offset = "0x4429B00", VA = "0x18442B100", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x442B570", Offset = "0x4429F70", VA = "0x18442B570", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EF90", Offset = "0x1D0D990", VA = "0x181D0EF90")]
		private LGPFFMLIECC(T[] PECHDAFMNOO, int EBDDHAPIAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x442B0B0", Offset = "0x4429AB0", VA = "0x18442B0B0")]
		public static LGPFFMLIECC MMKGNMBHOIH(T[] PECHDAFMNOO)
		{
			return default(LGPFFMLIECC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x20AE0A0", Offset = "0x20ACAA0", VA = "0x1820AE0A0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x20AE0D0", Offset = "0x20ACAD0", VA = "0x1820AE0D0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] GLKIHFPHILA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x413DB40", Offset = "0x413C540", VA = "0x18413DB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2AB74A0", Offset = "0x2AB5EA0", VA = "0x182AB74A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	internal CGDDIIDHBMN(T[] FNCIFDCGDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x54371E0", Offset = "0x5435BE0", VA = "0x1854371E0")]
	public static CGDDIIDHBMN<T> MANEDJLMOBE()
	{
		return default(CGDDIIDHBMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
	public IEnumerable<T> PKIKMLNIGJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5437140", Offset = "0x5435B40", VA = "0x185437140")]
	public ReadOnlySpan<T> DDCGBLLLEDH()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5436EE0", Offset = "0x54358E0", VA = "0x185436EE0")]
	public HJDAACCJIHA<T, CGDDIIDHBMN<T>.LGPFFMLIECC> AGPECJABFJM()
	{
		return default(HJDAACCJIHA<T, LGPFFMLIECC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5437020", Offset = "0x5435A20", VA = "0x185437020")]
	public LGPFFMLIECC BFNKPCMEFOF()
	{
		return default(LGPFFMLIECC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x54370C0", Offset = "0x5435AC0", VA = "0x1854370C0")]
	public IEnumerator<T> BPGPEIEKEPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x54372C0", Offset = "0x5435CC0", VA = "0x1854372C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EKEDOJMDBGM
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26A3CF0", Offset = "0x26A26F0", VA = "0x1826A3CF0")]
	public static CGDDIIDHBMN<T> MEIGHCOPPAM<T>(params T[] FNCIFDCGDBA) where T : notnull
	{
		return default(CGDDIIDHBMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C7AAD0", Offset = "0x6C794D0", VA = "0x186C7AAD0")]
	public static Stream OIIBCKAILNA(this CGDDIIDHBMN<byte> PECHDAFMNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(CBGFCAOFHCN<>.COOCEBDPKJM))]
public struct CBGFCAOFHCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JENINNCFKFE : BCCFPJEGHLL<T>, DCHALCHBMIC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] FAMNMOCBGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int JECKABHOBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int ALONHEBBILJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4209690", Offset = "0x4208090", VA = "0x184209690", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T PHBKLGGDPDL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4208E20", Offset = "0x4207820", VA = "0x184208E20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T HONGHCNKGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4208B90", Offset = "0x4207590", VA = "0x184208B90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4208FE0", Offset = "0x42079E0", VA = "0x184208FE0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x42093F0", Offset = "0x4207DF0", VA = "0x1842093F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4209540", Offset = "0x4207F40", VA = "0x184209540")]
		internal JENINNCFKFE(T[] HLHNGAOBAAJ, int KFBJHPBJLOG, int EBDDHAPIAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4208CD0", Offset = "0x42076D0", VA = "0x184208CD0")]
		public static JENINNCFKFE MMKGNMBHOIH(CBGFCAOFHCN<T> PECHDAFMNOO)
		{
			return default(JENINNCFKFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A042E0", Offset = "0x3A02CE0", VA = "0x183A042E0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A00870", Offset = "0x39FF270", VA = "0x183A00870", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct MLCMGAMGIAB : DCHALCHBMIC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JENINNCFKFE BAMJMOONNHH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x462B400", Offset = "0x4629E00", VA = "0x18462B400", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x462B120", Offset = "0x4629B20", VA = "0x18462B120", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x462B2E0", Offset = "0x4629CE0", VA = "0x18462B2E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x20679B0", Offset = "0x20663B0", VA = "0x1820679B0")]
		private MLCMGAMGIAB([In] JENINNCFKFE ANMEDFHNEAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x462AFB0", Offset = "0x46299B0", VA = "0x18462AFB0")]
		public static MLCMGAMGIAB MMKGNMBHOIH([In] CBGFCAOFHCN<T> PECHDAFMNOO)
		{
			return default(MLCMGAMGIAB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x462B060", Offset = "0x4629A60", VA = "0x18462B060", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x462B0A0", Offset = "0x4629AA0", VA = "0x18462B0A0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x462AF70", Offset = "0x4629970", VA = "0x18462AF70", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class COOCEBDPKJM
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] FAMNMOCBGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int JECKABHOBBC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51102C0", Offset = "0x510ECC0", VA = "0x1851102C0")]
	public static CBGFCAOFHCN<T> MMKGNMBHOIH()
	{
		return default(CBGFCAOFHCN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5110370", Offset = "0x510ED70", VA = "0x185110370")]
	public static CBGFCAOFHCN<T> OFPBNCOJPNM(int HBMOJAPOCCD)
	{
		return default(CBGFCAOFHCN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EF90", Offset = "0x1D0D990", VA = "0x181D0EF90")]
	internal CBGFCAOFHCN(T[] HLHNGAOBAAJ, int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5110430", Offset = "0x510EE30", VA = "0x185110430", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OMBKBFOJMDP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int KKIPIIKGCAM<TCtx, T>([In] TCtx GDMNEIEFKPA, T CGCFANNHAMA, T GEGAHIEHOAB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C930", Offset = "0x2E1B330", VA = "0x182E1C930")]
	public static void EPGEGEJNIJO<T>(this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E18B10", Offset = "0x2E17510", VA = "0x182E18B10")]
	public static string EGEFJMBACDP<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
	public static T[] FMMCIFFBAHO<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x20AC9F0", Offset = "0x20AB3F0", VA = "0x1820AC9F0")]
	public static T PHNOCPFLPNG<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO, int PPNCECJAFNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x20AC9F0", Offset = "0x20AB3F0", VA = "0x1820AC9F0")]
	public static T KEGDHAIEAFL<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, int PPNCECJAFNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CB60", Offset = "0x2E1B560", VA = "0x182E1CB60")]
	public static T GNMDPCHNJMB<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO, int PPNCECJAFNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CF40", Offset = "0x2E1B940", VA = "0x182E1CF40")]
	public static void IDPEEMDPGBG<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, int PPNCECJAFNC, [In] T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CF40", Offset = "0x2E1B940", VA = "0x182E1CF40")]
	public static void KNLKIBDKGLK<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, int PPNCECJAFNC, T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20DE2D0", Offset = "0x20DCCD0", VA = "0x1820DE2D0")]
	public static int CJNNJCICCCJ<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E18410", Offset = "0x2E16E10", VA = "0x182E18410")]
	public static ReadOnlySpan<T> DDCGBLLLEDH<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CC60", Offset = "0x2E1B660", VA = "0x182E1CC60")]
	public static T[] HKCOFEKGPEJ<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D4A0", Offset = "0x2E1BEA0", VA = "0x182E1D4A0")]
	public static T IIFCLDKFCPN<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C9B0", Offset = "0x2E1B3B0", VA = "0x182E1C9B0")]
	public static T[] FMNGJAMHCNL<T>(this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2E22CA0", Offset = "0x2E216A0", VA = "0x182E22CA0")]
	public static CGDDIIDHBMN<T> LPBHKENFIHF<T>(this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return default(CGDDIIDHBMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C1B0", Offset = "0x2E1ABB0", VA = "0x182E1C1B0")]
	public static void EGHPKMGPEOO<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, [In] T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E22870", Offset = "0x2E21270", VA = "0x182E22870")]
	public static void LHBAGNAFNKC<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E23020", Offset = "0x2E21A20", VA = "0x182E23020")]
	public static void PBIBDHLCBJE<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, int EBDDHAPIAHH, [In] T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C6D0", Offset = "0x2E1B0D0", VA = "0x182E1C6D0")]
	public static void EMJENKCFHGB<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, int EBDDHAPIAHH, T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CA60", Offset = "0x2E1B460", VA = "0x182E1CA60")]
	public static void GFOJIDBFMJC<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2E23190", Offset = "0x2E21B90", VA = "0x182E23190")]
	public static T PMGDCPNFACF<T>(this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DCB0", Offset = "0x2E1C6B0", VA = "0x182E1DCB0")]
	public static void JMKNGEPLGLH<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E20F50", Offset = "0x2E1F950", VA = "0x182E20F50")]
	private static void KNPKFNELOJF<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, int HBMOJAPOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D550", Offset = "0x2E1BF50", VA = "0x182E1D550")]
	public static void IMAFILHGCCD<T>(this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2E22A40", Offset = "0x2E21440", VA = "0x182E22A40")]
	public static CBGFCAOFHCN<T> LNLMPMKCFAD<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO, AFELKDCONFE<T, T> CJJPFAIHKEB)
	{
		return default(CBGFCAOFHCN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E22D70", Offset = "0x2E21770", VA = "0x182E22D70")]
	public static bool MIOFMOMIMDC<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, T CLMKDBDPNNH) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D660", Offset = "0x2E1C060", VA = "0x182E1D660")]
	public static bool JFEJFNAEJBM<T>(this CBGFCAOFHCN<T> PECHDAFMNOO, [In] T CLMKDBDPNNH) where T : GHEOLLPMBFN<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A292B0", Offset = "0x2A27CB0", VA = "0x182A292B0")]
	public static bool DLOJNDBBAAK<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D730", Offset = "0x2E1C130", VA = "0x182E1D730")]
	public static bool JFLKPPKMCEH<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO, int PPNCECJAFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E22F10", Offset = "0x2E21910", VA = "0x182E22F10")]
	public static void NMMAGEFMEAN<T, TCtx>(this CBGFCAOFHCN<T> PECHDAFMNOO, [In] TCtx GDMNEIEFKPA, KKIPIIKGCAM<TCtx, T> OEGKBFMKNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C830", Offset = "0x2E1B230", VA = "0x182E1C830")]
	private static void EOONBPMLGKM<T, TCtx>(CBGFCAOFHCN<T> PECHDAFMNOO, [In] TCtx GDMNEIEFKPA, KKIPIIKGCAM<TCtx, T> OEGKBFMKNEJ, int JJANFECHPIB, int PCLCJJBOPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FF70", Offset = "0x2E1E970", VA = "0x182E1FF70")]
	private static int KNAAKCEJJMC<T, TCtx>(CBGFCAOFHCN<T> PECHDAFMNOO, [In] TCtx GDMNEIEFKPA, KKIPIIKGCAM<TCtx, T> OEGKBFMKNEJ, int JJANFECHPIB, int PCLCJJBOPND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2A290F0", Offset = "0x2A27AF0", VA = "0x182A290F0")]
	public static CBGFCAOFHCN<T>.MLCMGAMGIAB BPGPEIEKEPK<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return default(CBGFCAOFHCN<T>.MLCMGAMGIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A290F0", Offset = "0x2A27AF0", VA = "0x182A290F0")]
	public static CBGFCAOFHCN<T>.JENINNCFKFE CLIPOACHIKD<T>(this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return default(CBGFCAOFHCN<T>.JENINNCFKFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2D63750", Offset = "0x2D62150", VA = "0x182D63750")]
	public static HJDAACCJIHA<T, CBGFCAOFHCN<T>.MLCMGAMGIAB> KOBOLBCBKNN<T>([In] this CBGFCAOFHCN<T> PECHDAFMNOO)
	{
		return default(HJDAACCJIHA<T, CBGFCAOFHCN<T>.MLCMGAMGIAB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class ALEKFINNFHD
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x336AF90", Offset = "0x3369990", VA = "0x18336AF90")]
	public static T[] JODAMLNBNHO<T>(int MPLHLKNKHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void PCAPLIDLHOP<T>(T[] FNCIFDCGDBA)
	{
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
