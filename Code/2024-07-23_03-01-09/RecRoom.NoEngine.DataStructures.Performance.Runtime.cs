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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C6290", Offset = "0x69C5490", VA = "0x1869C6290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PAMDFDKOFKL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29A3F40", Offset = "0x29A3140", VA = "0x1829A3F40")]
	public static LHCIICLJEAC<T> PDMGAOFADBC<T>(this T[] HIKEOGPAJAF) where T : notnull
	{
		return default(LHCIICLJEAC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class AIHFGIJFNJJ<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MAHDLFLAHIJ<T> LJOEBDOHFJN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C140", Offset = "0x3C8B340", VA = "0x183C8C140", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C180", Offset = "0x3C8B380", VA = "0x183C8C180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BF70", Offset = "0x3C8B170", VA = "0x183C8BF70")]
	public static AIHFGIJFNJJ<T> FJAAFKPDAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C240", Offset = "0x3C8B440", VA = "0x183C8C240")]
	internal AIHFGIJFNJJ([In] MAHDLFLAHIJ<T> CIGKBEKHOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C8BF30", Offset = "0x3C8B130", VA = "0x183C8BF30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C100", Offset = "0x3C8B300", VA = "0x183C8C100")]
	public void LDPNMKMBKDP(int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C0A0", Offset = "0x3C8B2A0", VA = "0x183C8C0A0", Slot = "8")]
	public MAHDLFLAHIJ<T>.FOKBEFPNKIO GetEnumerator()
	{
		return default(MAHDLFLAHIJ<T>.FOKBEFPNKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C1C0", Offset = "0x3C8B3C0", VA = "0x183C8C1C0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C8C1C0", Offset = "0x3C8B3C0", VA = "0x183C8C1C0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DPAOMCDLCCA<T, U> : IEnumerable<T>, IEnumerable where U : DKHNPHMKALK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U IBPIPGILMJG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D870", Offset = "0x1F7CA70", VA = "0x181F7D870")]
	internal DPAOMCDLCCA([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CD08E0", Offset = "0x3CCFAE0", VA = "0x183CD08E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CD08E0", Offset = "0x3CCFAE0", VA = "0x183CD08E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JNDLMNIJPJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29DF240", Offset = "0x29DE440", VA = "0x1829DF240")]
	public static DPAOMCDLCCA<T, U> FJAAFKPDAIA<U>([In] U HIKEOGPAJAF) where U : DKHNPHMKALK<T>
	{
		return default(DPAOMCDLCCA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CJFNOILOBFK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U IBPIPGILMJG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0260", Offset = "0x4BCF460", VA = "0x184BD0260")]
	internal CJFNOILOBFK([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C72890", Offset = "0x3C71A90", VA = "0x183C72890", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x51F4C20", Offset = "0x51F3E20", VA = "0x1851F4C20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x51F4C20", Offset = "0x51F3E20", VA = "0x1851F4C20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MIGPPMKJKJA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C390", Offset = "0x2A6B590", VA = "0x182A6C390")]
	public static CJFNOILOBFK<T, U> FJAAFKPDAIA<U>([In] U HIKEOGPAJAF) where U : IEnumerator<T>
	{
		return default(CJFNOILOBFK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IJILMOCJMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0540", Offset = "0x2B9F740", VA = "0x182BA0540")]
	public static string KBCEOFKOLKI<T>(this IEnumerable<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4930", Offset = "0x2BA3B30", VA = "0x182BA4930")]
	public static string LGOBBFKCEFF<T>(this IEnumerable<T> HIKEOGPAJAF, string HBDNCCCHBFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FILFKLIBOPE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B202A0", Offset = "0x2B1F4A0", VA = "0x182B202A0")]
	public static bool FDJCPMHDEPF<TSourceEnumerator, TSource>(this TSourceEnumerator HIKEOGPAJAF, [In] TSource JNHGHHKKNBB) where TSourceEnumerator : DKHNPHMKALK<TSource> where TSource : HHDDKAPPENK<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B20040", Offset = "0x2B1F240", VA = "0x182B20040")]
	public static int ADOAFLGDFLN<TSourceEnumerator, TSource>(this TSourceEnumerator HIKEOGPAJAF, [In] TSource JMDCGOKJIDA) where TSourceEnumerator : DKHNPHMKALK<TSource> where TSource : HHDDKAPPENK<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B20420", Offset = "0x2B1F620", VA = "0x182B20420")]
	public static int MMDIIGEPPMA<TSourceEnumerator, TSource>(this TSourceEnumerator HIKEOGPAJAF, [In] TSource JMDCGOKJIDA) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DKHNPHMKALK<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T EBFPDFJFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GJOCFKOMGEA<T> : DKHNPHMKALK<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct GGNPCKHLGGH<T, U> : IEnumerable<T>, IEnumerable where U : GJOCFKOMGEA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U IBPIPGILMJG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0950", Offset = "0x3CCFB50", VA = "0x183CD0950")]
	internal GGNPCKHLGGH([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38B3A20", Offset = "0x38B2C20", VA = "0x1838B3A20", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0850", Offset = "0x3CCFA50", VA = "0x183CD0850", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0850", Offset = "0x3CCFA50", VA = "0x183CD0850", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GGBJJGIFFKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29DF270", Offset = "0x29DE470", VA = "0x1829DF270")]
	public static GGNPCKHLGGH<T, U> FJAAFKPDAIA<U>([In] U HIKEOGPAJAF) where U : GJOCFKOMGEA<T>
	{
		return default(GGNPCKHLGGH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct LHCIICLJEAC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct DCIFPDBIHCO : DKHNPHMKALK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] EHOIIJCLOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int NDMIKHDBHBN;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5761750", Offset = "0x5760950", VA = "0x185761750", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5761060", Offset = "0x5760260", VA = "0x185761060", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5761390", Offset = "0x5760590", VA = "0x185761390", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB460", Offset = "0x1AAA660", VA = "0x181AAB460")]
		private DCIFPDBIHCO(T[] HIKEOGPAJAF, int DHNLEFJCEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5761010", Offset = "0x5760210", VA = "0x185761010")]
		public static DCIFPDBIHCO FJAAFKPDAIA(T[] HIKEOGPAJAF)
		{
			return default(DCIFPDBIHCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8B80", Offset = "0x1FC7D80", VA = "0x181FC8B80", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8BB0", Offset = "0x1FC7DB0", VA = "0x181FC8BB0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] DDOGPENCCJO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E0A0", Offset = "0x3F5D2A0", VA = "0x183F5E0A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A340", Offset = "0x2B99540", VA = "0x182B9A340")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
	internal LHCIICLJEAC(T[] PFKJAOOHGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x426C330", Offset = "0x426B530", VA = "0x18426C330")]
	public static LHCIICLJEAC<T> ENKECPBOOIC()
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50")]
	public IEnumerable<T> ILALHCGAKPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x426C400", Offset = "0x426B600", VA = "0x18426C400")]
	public ReadOnlySpan<T> IGCPKIKCNFG()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x426C200", Offset = "0x426B400", VA = "0x18426C200")]
	public DPAOMCDLCCA<T, LHCIICLJEAC<T>.DCIFPDBIHCO> DJBCFJPHHKC()
	{
		return default(DPAOMCDLCCA<T, DCIFPDBIHCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x426C4A0", Offset = "0x426B6A0", VA = "0x18426C4A0")]
	public DCIFPDBIHCO MMLLIHGACCA()
	{
		return default(DCIFPDBIHCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x426C180", Offset = "0x426B380", VA = "0x18426C180")]
	public IEnumerator<T> DCPEOMEKOMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x426C540", Offset = "0x426B740", VA = "0x18426C540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LJFPBJNAABG
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x25AC0C0", Offset = "0x25AB2C0", VA = "0x1825AC0C0")]
	public static LHCIICLJEAC<T> KLHJLPOPLML<T>(params T[] PFKJAOOHGBN) where T : notnull
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69C6230", Offset = "0x69C5430", VA = "0x1869C6230")]
	public static Stream JOOAJODDPAJ(this LHCIICLJEAC<byte> HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(MAHDLFLAHIJ<>.AJKMOPLIDPA))]
public struct MAHDLFLAHIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FOKBEFPNKIO : GJOCFKOMGEA<T>, DKHNPHMKALK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] IGAJBKMDFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int LNLONFLBFPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int NDMIKHDBHBN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3C1A5C0", Offset = "0x3C197C0", VA = "0x183C1A5C0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T ELLGIMLIIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3C19D60", Offset = "0x3C18F60", VA = "0x183C19D60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T IDNMEPAIADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3C19B50", Offset = "0x3C18D50", VA = "0x183C19B50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3C19FC0", Offset = "0x3C191C0", VA = "0x183C19FC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3C1A1B0", Offset = "0x3C193B0", VA = "0x183C1A1B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C1A580", Offset = "0x3C19780", VA = "0x183C1A580")]
		internal FOKBEFPNKIO(T[] FDPJMKODKPJ, int IHGHLPOONHD, int DHNLEFJCEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3C19EE0", Offset = "0x3C190E0", VA = "0x183C19EE0")]
		public static FOKBEFPNKIO FJAAFKPDAIA(MAHDLFLAHIJ<T> HIKEOGPAJAF)
		{
			return default(FOKBEFPNKIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x386E580", Offset = "0x386D780", VA = "0x18386E580", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3869700", Offset = "0x3868900", VA = "0x183869700", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct AMAMHKAIHJB : DKHNPHMKALK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FOKBEFPNKIO IBPIPGILMJG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3C9AB70", Offset = "0x3C99D70", VA = "0x183C9AB70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3C9A950", Offset = "0x3C99B50", VA = "0x183C9A950", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3C9AA60", Offset = "0x3C99C60", VA = "0x183C9AA60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D870", Offset = "0x1F7CA70", VA = "0x181F7D870")]
		private AMAMHKAIHJB([In] FOKBEFPNKIO OBCBMANCKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A7E0", Offset = "0x3C999E0", VA = "0x183C9A7E0")]
		public static AMAMHKAIHJB FJAAFKPDAIA([In] MAHDLFLAHIJ<T> HIKEOGPAJAF)
		{
			return default(AMAMHKAIHJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A890", Offset = "0x3C99A90", VA = "0x183C9A890", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A8D0", Offset = "0x3C99AD0", VA = "0x183C9A8D0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A7A0", Offset = "0x3C999A0", VA = "0x183C9A7A0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class AJKMOPLIDPA
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] IGAJBKMDFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int LNLONFLBFPH;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x447B160", Offset = "0x447A360", VA = "0x18447B160")]
	public static MAHDLFLAHIJ<T> FJAAFKPDAIA()
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x447B0A0", Offset = "0x447A2A0", VA = "0x18447B0A0")]
	public static MAHDLFLAHIJ<T> EIGIPLIHNAM(int HHGNDILCLEE)
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1AAB460", Offset = "0x1AAA660", VA = "0x181AAB460")]
	internal MAHDLFLAHIJ(T[] FDPJMKODKPJ, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x447B210", Offset = "0x447A410", VA = "0x18447B210", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IJBKMPNEGOL
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int GNEKLANIMIB<TCtx, T>([In] TCtx MOPANCMKHLH, T DIAAOCPNHKC, T LLLBDLGIMPP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B95810", Offset = "0x2B94A10", VA = "0x182B95810")]
	public static void CKOHIKCJKJA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B960F0", Offset = "0x2B952F0", VA = "0x182B960F0")]
	public static string FDJLBEGHFMJ<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50")]
	public static T[] ECLAHGAPEBN<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A240", Offset = "0x2B99440", VA = "0x182B9A240")]
	public static T JMJOGDIBBHK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8D50", Offset = "0x1FC7F50", VA = "0x181FC8D50")]
	public static T NEODAOFGJMA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F300", Offset = "0x2B9E500", VA = "0x182B9F300")]
	public static T NDCDAADAPHI<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9E830", VA = "0x182B9F630")]
	public static void OLOHHMDPKEO<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B99840", Offset = "0x2B98A40", VA = "0x182B99840")]
	public static void FPFHFGPCJHK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FF92F0", Offset = "0x1FF84F0", VA = "0x181FF92F0")]
	public static int ILJNEEMJODN<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B99C30", Offset = "0x2B98E30", VA = "0x182B99C30")]
	public static ReadOnlySpan<T> IGCPKIKCNFG<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B9EF10", Offset = "0x2B9E110", VA = "0x182B9EF10")]
	public static T[] LLPFAPMPDEJ<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B95890", Offset = "0x2B94A90", VA = "0x182B95890")]
	public static T COLNKPDAMPK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B95770", Offset = "0x2B94970", VA = "0x182B95770")]
	public static T[] CKNPBMENOKA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A0F0", Offset = "0x2B992F0", VA = "0x182B9A0F0")]
	public static LHCIICLJEAC<T> JGJAFHCKJMB<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B9FCA0", Offset = "0x2B9EEA0", VA = "0x182B9FCA0")]
	public static void PBLNBBGFGAP<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C6E0", Offset = "0x2B9B8E0", VA = "0x182B9C6E0")]
	public static void LDIINDHGDHK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B99A70", Offset = "0x2B98C70", VA = "0x182B99A70")]
	public static void HDMLFENMIIH<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A450", Offset = "0x2B99650", VA = "0x182B9A450")]
	public static void LAKKMKEHFHG<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B95730", Offset = "0x2B94930", VA = "0x182B95730")]
	public static void ACAJIKLBJOM<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2BA01C0", Offset = "0x2B9F3C0", VA = "0x182BA01C0")]
	public static T PFBJBMEFDOJ<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B9CA50", Offset = "0x2B9BC50", VA = "0x182B9CA50")]
	public static void LDPNMKMBKDP<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A7A0", Offset = "0x2B999A0", VA = "0x182B9A7A0")]
	private static void LAMHFMADGIK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B99FE0", Offset = "0x2B991E0", VA = "0x182B99FE0")]
	public static void IMJJLGNDCEN<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B99D20", Offset = "0x2B98F20", VA = "0x182B99D20")]
	public static MAHDLFLAHIJ<T> IJDMAMHKEEG<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, OJOANALFDFD<T, T> GLMCGGEBLBN)
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F040", Offset = "0x2B9E240", VA = "0x182B9F040")]
	public static bool MFKDEBIIBOM<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, T JMDCGOKJIDA) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B958D0", Offset = "0x2B94AD0", VA = "0x182B958D0")]
	public static bool EJHJEADNLNA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA) where T : HHDDKAPPENK<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D140", Offset = "0x2B2C340", VA = "0x182B2D140")]
	public static bool OJBMAONCMFP<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B99BE0", Offset = "0x2B98DE0", VA = "0x182B99BE0")]
	public static bool HLJIJANFIGD<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F1E0", Offset = "0x2B9E3E0", VA = "0x182B9F1E0")]
	public static void MHMPDMIJHAL<T, TCtx>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F430", Offset = "0x2B9E630", VA = "0x182B9F430")]
	private static void NDIFDFGAIGO<T, TCtx>(MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML, int KDKHIJEEJNH, int PCMKKMJDLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B95990", Offset = "0x2B94B90", VA = "0x182B95990")]
	private static int EPGFGCGCHFC<T, TCtx>(MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML, int KDKHIJEEJNH, int PCMKKMJDLJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C4F0", Offset = "0x2B2B6F0", VA = "0x182B2C4F0")]
	public static MAHDLFLAHIJ<T>.AMAMHKAIHJB DCPEOMEKOMK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(MAHDLFLAHIJ<T>.AMAMHKAIHJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C4F0", Offset = "0x2B2B6F0", VA = "0x182B2C4F0")]
	public static MAHDLFLAHIJ<T>.FOKBEFPNKIO EBJANLOGAHE<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(MAHDLFLAHIJ<T>.FOKBEFPNKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x29A3E80", Offset = "0x29A3080", VA = "0x1829A3E80")]
	public static DPAOMCDLCCA<T, MAHDLFLAHIJ<T>.AMAMHKAIHJB> ACCPBNBFICP<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(DPAOMCDLCCA<T, MAHDLFLAHIJ<T>.AMAMHKAIHJB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class AAMKEDLLIIC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x31D9C90", Offset = "0x31D8E90", VA = "0x1831D9C90")]
	public static T[] KMPFJCFFCHG<T>(int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	public static void PJNBPHIHGLL<T>(T[] PFKJAOOHGBN)
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
