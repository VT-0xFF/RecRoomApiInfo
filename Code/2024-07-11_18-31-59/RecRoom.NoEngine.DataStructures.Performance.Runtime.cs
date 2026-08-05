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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AB3A0", Offset = "0x69A9DA0", VA = "0x1869AB3A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PAMDFDKOFKL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2995950", Offset = "0x2994350", VA = "0x182995950")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C79400", Offset = "0x3C77E00", VA = "0x183C79400", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C79440", Offset = "0x3C77E40", VA = "0x183C79440")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C79230", Offset = "0x3C77C30", VA = "0x183C79230")]
	public static AIHFGIJFNJJ<T> FJAAFKPDAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C79500", Offset = "0x3C77F00", VA = "0x183C79500")]
	internal AIHFGIJFNJJ([In] MAHDLFLAHIJ<T> CIGKBEKHOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C791F0", Offset = "0x3C77BF0", VA = "0x183C791F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C793C0", Offset = "0x3C77DC0", VA = "0x183C793C0")]
	public void LDPNMKMBKDP(int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C79360", Offset = "0x3C77D60", VA = "0x183C79360", Slot = "8")]
	public MAHDLFLAHIJ<T>.FOKBEFPNKIO GetEnumerator()
	{
		return default(MAHDLFLAHIJ<T>.FOKBEFPNKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C79480", Offset = "0x3C77E80", VA = "0x183C79480", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C79480", Offset = "0x3C77E80", VA = "0x183C79480", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F728B0", Offset = "0x1F712B0", VA = "0x181F728B0")]
	internal DPAOMCDLCCA([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC8E0", Offset = "0x3CBB2E0", VA = "0x183CBC8E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC8E0", Offset = "0x3CBB2E0", VA = "0x183CBC8E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JNDLMNIJPJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29D0640", Offset = "0x29CF040", VA = "0x1829D0640")]
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
	[Cpp2IlInjected.Address(RVA = "0x4BB9280", Offset = "0x4BB7C80", VA = "0x184BB9280")]
	internal CJFNOILOBFK([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FA00", Offset = "0x3C5E400", VA = "0x183C5FA00", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x51EFF60", Offset = "0x51EE960", VA = "0x1851EFF60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x51EFF60", Offset = "0x51EE960", VA = "0x1851EFF60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MIGPPMKJKJA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E010", Offset = "0x2A5CA10", VA = "0x182A5E010")]
	public static CJFNOILOBFK<T, U> FJAAFKPDAIA<U>([In] U HIKEOGPAJAF) where U : IEnumerator<T>
	{
		return default(CJFNOILOBFK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IJILMOCJMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B91DD0", Offset = "0x2B907D0", VA = "0x182B91DD0")]
	public static string KBCEOFKOLKI<T>(this IEnumerable<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B961C0", Offset = "0x2B94BC0", VA = "0x182B961C0")]
	public static string LGOBBFKCEFF<T>(this IEnumerable<T> HIKEOGPAJAF, string HBDNCCCHBFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FILFKLIBOPE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B11B30", Offset = "0x2B10530", VA = "0x182B11B30")]
	public static bool FDJCPMHDEPF<TSourceEnumerator, TSource>(this TSourceEnumerator HIKEOGPAJAF, [In] TSource JNHGHHKKNBB) where TSourceEnumerator : DKHNPHMKALK<TSource> where TSource : HHDDKAPPENK<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B118D0", Offset = "0x2B102D0", VA = "0x182B118D0")]
	public static int ADOAFLGDFLN<TSourceEnumerator, TSource>(this TSourceEnumerator HIKEOGPAJAF, [In] TSource JMDCGOKJIDA) where TSourceEnumerator : DKHNPHMKALK<TSource> where TSource : HHDDKAPPENK<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B11CB0", Offset = "0x2B106B0", VA = "0x182B11CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CBC950", Offset = "0x3CBB350", VA = "0x183CBC950")]
	internal GGNPCKHLGGH([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3899C30", Offset = "0x3898630", VA = "0x183899C30", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC850", Offset = "0x3CBB250", VA = "0x183CBC850", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC850", Offset = "0x3CBB250", VA = "0x183CBC850", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GGBJJGIFFKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29D0670", Offset = "0x29CF070", VA = "0x1829D0670")]
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
			[Cpp2IlInjected.Address(RVA = "0x5743950", Offset = "0x5742350", VA = "0x185743950", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5743260", Offset = "0x5741C60", VA = "0x185743260", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5743590", Offset = "0x5741F90", VA = "0x185743590", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1AA1530", Offset = "0x1A9FF30", VA = "0x181AA1530")]
		private DCIFPDBIHCO(T[] HIKEOGPAJAF, int DHNLEFJCEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5743210", Offset = "0x5741C10", VA = "0x185743210")]
		public static DCIFPDBIHCO FJAAFKPDAIA(T[] HIKEOGPAJAF)
		{
			return default(DCIFPDBIHCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDBC0", Offset = "0x1FBC5C0", VA = "0x181FBDBC0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDBF0", Offset = "0x1FBC5F0", VA = "0x181FBDBF0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F50C10", Offset = "0x3F4F610", VA = "0x183F50C10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BBD0", Offset = "0x2B8A5D0", VA = "0x182B8BBD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
	internal LHCIICLJEAC(T[] PFKJAOOHGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42573E0", Offset = "0x4255DE0", VA = "0x1842573E0")]
	public static LHCIICLJEAC<T> ENKECPBOOIC()
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2B10", VA = "0x1808C4110")]
	public IEnumerable<T> ILALHCGAKPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42574B0", Offset = "0x4255EB0", VA = "0x1842574B0")]
	public ReadOnlySpan<T> IGCPKIKCNFG()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42572B0", Offset = "0x4255CB0", VA = "0x1842572B0")]
	public DPAOMCDLCCA<T, LHCIICLJEAC<T>.DCIFPDBIHCO> DJBCFJPHHKC()
	{
		return default(DPAOMCDLCCA<T, DCIFPDBIHCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4257550", Offset = "0x4255F50", VA = "0x184257550")]
	public DCIFPDBIHCO MMLLIHGACCA()
	{
		return default(DCIFPDBIHCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4257230", Offset = "0x4255C30", VA = "0x184257230")]
	public IEnumerator<T> DCPEOMEKOMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42575F0", Offset = "0x4255FF0", VA = "0x1842575F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LJFPBJNAABG
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x259D370", Offset = "0x259BD70", VA = "0x18259D370")]
	public static LHCIICLJEAC<T> KLHJLPOPLML<T>(params T[] PFKJAOOHGBN) where T : notnull
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69AB340", Offset = "0x69A9D40", VA = "0x1869AB340")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C07930", Offset = "0x3C06330", VA = "0x183C07930", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T ELLGIMLIIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3C070D0", Offset = "0x3C05AD0", VA = "0x183C070D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T IDNMEPAIADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3C06EC0", Offset = "0x3C058C0", VA = "0x183C06EC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3C07330", Offset = "0x3C05D30", VA = "0x183C07330", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3C07520", Offset = "0x3C05F20", VA = "0x183C07520", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C078F0", Offset = "0x3C062F0", VA = "0x183C078F0")]
		internal FOKBEFPNKIO(T[] FDPJMKODKPJ, int IHGHLPOONHD, int DHNLEFJCEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3C07250", Offset = "0x3C05C50", VA = "0x183C07250")]
		public static FOKBEFPNKIO FJAAFKPDAIA(MAHDLFLAHIJ<T> HIKEOGPAJAF)
		{
			return default(FOKBEFPNKIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3858150", Offset = "0x3856B50", VA = "0x183858150", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x38565F0", Offset = "0x3854FF0", VA = "0x1838565F0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C87E30", Offset = "0x3C86830", VA = "0x183C87E30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3C87C10", Offset = "0x3C86610", VA = "0x183C87C10", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3C87D20", Offset = "0x3C86720", VA = "0x183C87D20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1F728B0", Offset = "0x1F712B0", VA = "0x181F728B0")]
		private AMAMHKAIHJB([In] FOKBEFPNKIO OBCBMANCKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C87AA0", Offset = "0x3C864A0", VA = "0x183C87AA0")]
		public static AMAMHKAIHJB FJAAFKPDAIA([In] MAHDLFLAHIJ<T> HIKEOGPAJAF)
		{
			return default(AMAMHKAIHJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C87B50", Offset = "0x3C86550", VA = "0x183C87B50", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C87B90", Offset = "0x3C86590", VA = "0x183C87B90", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C87A60", Offset = "0x3C86460", VA = "0x183C87A60", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x4465B30", Offset = "0x4464530", VA = "0x184465B30")]
	public static MAHDLFLAHIJ<T> FJAAFKPDAIA()
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4465A70", Offset = "0x4464470", VA = "0x184465A70")]
	public static MAHDLFLAHIJ<T> EIGIPLIHNAM(int HHGNDILCLEE)
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1AA1530", Offset = "0x1A9FF30", VA = "0x181AA1530")]
	internal MAHDLFLAHIJ(T[] FDPJMKODKPJ, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4465BE0", Offset = "0x44645E0", VA = "0x184465BE0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B870A0", Offset = "0x2B85AA0", VA = "0x182B870A0")]
	public static void CKOHIKCJKJA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B87980", Offset = "0x2B86380", VA = "0x182B87980")]
	public static string FDJLBEGHFMJ<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2B10", VA = "0x1808C4110")]
	public static T[] ECLAHGAPEBN<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B8BAD0", Offset = "0x2B8A4D0", VA = "0x182B8BAD0")]
	public static T JMJOGDIBBHK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDD90", Offset = "0x1FBC790", VA = "0x181FBDD90")]
	public static T NEODAOFGJMA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B90B90", Offset = "0x2B8F590", VA = "0x182B90B90")]
	public static T NDCDAADAPHI<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B90EC0", Offset = "0x2B8F8C0", VA = "0x182B90EC0")]
	public static void OLOHHMDPKEO<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B0D0", Offset = "0x2B89AD0", VA = "0x182B8B0D0")]
	public static void FPFHFGPCJHK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECD30", VA = "0x181FEE330")]
	public static int ILJNEEMJODN<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B4C0", Offset = "0x2B89EC0", VA = "0x182B8B4C0")]
	public static ReadOnlySpan<T> IGCPKIKCNFG<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B907A0", Offset = "0x2B8F1A0", VA = "0x182B907A0")]
	public static T[] LLPFAPMPDEJ<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B87120", Offset = "0x2B85B20", VA = "0x182B87120")]
	public static T COLNKPDAMPK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B87000", Offset = "0x2B85A00", VA = "0x182B87000")]
	public static T[] CKNPBMENOKA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B980", Offset = "0x2B8A380", VA = "0x182B8B980")]
	public static LHCIICLJEAC<T> JGJAFHCKJMB<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B91530", Offset = "0x2B8FF30", VA = "0x182B91530")]
	public static void PBLNBBGFGAP<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8DF70", Offset = "0x2B8C970", VA = "0x182B8DF70")]
	public static void LDIINDHGDHK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B300", Offset = "0x2B89D00", VA = "0x182B8B300")]
	public static void HDMLFENMIIH<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B8BCE0", Offset = "0x2B8A6E0", VA = "0x182B8BCE0")]
	public static void LAKKMKEHFHG<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B86FC0", Offset = "0x2B859C0", VA = "0x182B86FC0")]
	public static void ACAJIKLBJOM<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B91A50", Offset = "0x2B90450", VA = "0x182B91A50")]
	public static T PFBJBMEFDOJ<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E2E0", Offset = "0x2B8CCE0", VA = "0x182B8E2E0")]
	public static void LDPNMKMBKDP<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B8C030", Offset = "0x2B8AA30", VA = "0x182B8C030")]
	private static void LAMHFMADGIK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B870", Offset = "0x2B8A270", VA = "0x182B8B870")]
	public static void IMJJLGNDCEN<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B5B0", Offset = "0x2B89FB0", VA = "0x182B8B5B0")]
	public static MAHDLFLAHIJ<T> IJDMAMHKEEG<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, OJOANALFDFD<T, T> GLMCGGEBLBN)
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B908D0", Offset = "0x2B8F2D0", VA = "0x182B908D0")]
	public static bool MFKDEBIIBOM<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, T JMDCGOKJIDA) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B87160", Offset = "0x2B85B60", VA = "0x182B87160")]
	public static bool EJHJEADNLNA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA) where T : HHDDKAPPENK<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B1E9D0", Offset = "0x2B1D3D0", VA = "0x182B1E9D0")]
	public static bool OJBMAONCMFP<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B470", Offset = "0x2B89E70", VA = "0x182B8B470")]
	public static bool HLJIJANFIGD<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B90A70", Offset = "0x2B8F470", VA = "0x182B90A70")]
	public static void MHMPDMIJHAL<T, TCtx>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B90CC0", Offset = "0x2B8F6C0", VA = "0x182B90CC0")]
	private static void NDIFDFGAIGO<T, TCtx>(MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML, int KDKHIJEEJNH, int PCMKKMJDLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B87220", Offset = "0x2B85C20", VA = "0x182B87220")]
	private static int EPGFGCGCHFC<T, TCtx>(MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML, int KDKHIJEEJNH, int PCMKKMJDLJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B1DD80", Offset = "0x2B1C780", VA = "0x182B1DD80")]
	public static MAHDLFLAHIJ<T>.AMAMHKAIHJB DCPEOMEKOMK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(MAHDLFLAHIJ<T>.AMAMHKAIHJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B1DD80", Offset = "0x2B1C780", VA = "0x182B1DD80")]
	public static MAHDLFLAHIJ<T>.FOKBEFPNKIO EBJANLOGAHE<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(MAHDLFLAHIJ<T>.FOKBEFPNKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2995890", Offset = "0x2994290", VA = "0x182995890")]
	public static DPAOMCDLCCA<T, MAHDLFLAHIJ<T>.AMAMHKAIHJB> ACCPBNBFICP<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(DPAOMCDLCCA<T, MAHDLFLAHIJ<T>.AMAMHKAIHJB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class AAMKEDLLIIC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x31CA100", Offset = "0x31C8B00", VA = "0x1831CA100")]
	public static T[] KMPFJCFFCHG<T>(int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
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
