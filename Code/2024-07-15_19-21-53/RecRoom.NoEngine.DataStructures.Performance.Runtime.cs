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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AB2A0", Offset = "0x69A9AA0", VA = "0x1869AB2A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C1C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C200", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PAMDFDKOFKL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2995C50", Offset = "0x2994450", VA = "0x182995C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C79300", Offset = "0x3C77B00", VA = "0x183C79300", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C79340", Offset = "0x3C77B40", VA = "0x183C79340")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C79130", Offset = "0x3C77930", VA = "0x183C79130")]
	public static AIHFGIJFNJJ<T> FJAAFKPDAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C79400", Offset = "0x3C77C00", VA = "0x183C79400")]
	internal AIHFGIJFNJJ([In] MAHDLFLAHIJ<T> CIGKBEKHOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C790F0", Offset = "0x3C778F0", VA = "0x183C790F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C792C0", Offset = "0x3C77AC0", VA = "0x183C792C0")]
	public void LDPNMKMBKDP(int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C79260", Offset = "0x3C77A60", VA = "0x183C79260", Slot = "8")]
	public MAHDLFLAHIJ<T>.FOKBEFPNKIO GetEnumerator()
	{
		return default(MAHDLFLAHIJ<T>.FOKBEFPNKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C79380", Offset = "0x3C77B80", VA = "0x183C79380", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C79380", Offset = "0x3C77B80", VA = "0x183C79380", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F728B0", Offset = "0x1F710B0", VA = "0x181F728B0")]
	internal DPAOMCDLCCA([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC7E0", Offset = "0x3CBAFE0", VA = "0x183CBC7E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC7E0", Offset = "0x3CBAFE0", VA = "0x183CBC7E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JNDLMNIJPJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29D0540", Offset = "0x29CED40", VA = "0x1829D0540")]
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
	[Cpp2IlInjected.Address(RVA = "0x4BB9180", Offset = "0x4BB7980", VA = "0x184BB9180")]
	internal CJFNOILOBFK([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F900", Offset = "0x3C5E100", VA = "0x183C5F900", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x51EFE60", Offset = "0x51EE660", VA = "0x1851EFE60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x51EFE60", Offset = "0x51EE660", VA = "0x1851EFE60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MIGPPMKJKJA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DF10", Offset = "0x2A5C710", VA = "0x182A5DF10")]
	public static CJFNOILOBFK<T, U> FJAAFKPDAIA<U>([In] U HIKEOGPAJAF) where U : IEnumerator<T>
	{
		return default(CJFNOILOBFK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IJILMOCJMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B92050", Offset = "0x2B90850", VA = "0x182B92050")]
	public static string KBCEOFKOLKI<T>(this IEnumerable<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B96440", Offset = "0x2B94C40", VA = "0x182B96440")]
	public static string LGOBBFKCEFF<T>(this IEnumerable<T> HIKEOGPAJAF, string HBDNCCCHBFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FILFKLIBOPE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B11DB0", Offset = "0x2B105B0", VA = "0x182B11DB0")]
	public static bool FDJCPMHDEPF<TSourceEnumerator, TSource>(this TSourceEnumerator HIKEOGPAJAF, [In] TSource JNHGHHKKNBB) where TSourceEnumerator : DKHNPHMKALK<TSource> where TSource : HHDDKAPPENK<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B11B50", Offset = "0x2B10350", VA = "0x182B11B50")]
	public static int ADOAFLGDFLN<TSourceEnumerator, TSource>(this TSourceEnumerator HIKEOGPAJAF, [In] TSource JMDCGOKJIDA) where TSourceEnumerator : DKHNPHMKALK<TSource> where TSource : HHDDKAPPENK<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B11F30", Offset = "0x2B10730", VA = "0x182B11F30")]
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
	[Cpp2IlInjected.Address(RVA = "0x3CBC850", Offset = "0x3CBB050", VA = "0x183CBC850")]
	internal GGNPCKHLGGH([In] U OBCBMANCKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3899B30", Offset = "0x3898330", VA = "0x183899B30", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC750", Offset = "0x3CBAF50", VA = "0x183CBC750", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3CBC750", Offset = "0x3CBAF50", VA = "0x183CBC750", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GGBJJGIFFKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29D0570", Offset = "0x29CED70", VA = "0x1829D0570")]
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
			[Cpp2IlInjected.Address(RVA = "0x5743850", Offset = "0x5742050", VA = "0x185743850", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5743160", Offset = "0x5741960", VA = "0x185743160", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5743490", Offset = "0x5741C90", VA = "0x185743490", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1AA1530", Offset = "0x1A9FD30", VA = "0x181AA1530")]
		private DCIFPDBIHCO(T[] HIKEOGPAJAF, int DHNLEFJCEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5743110", Offset = "0x5741910", VA = "0x185743110")]
		public static DCIFPDBIHCO FJAAFKPDAIA(T[] HIKEOGPAJAF)
		{
			return default(DCIFPDBIHCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDBC0", Offset = "0x1FBC3C0", VA = "0x181FBDBC0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDBF0", Offset = "0x1FBC3F0", VA = "0x181FBDBF0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F50B10", Offset = "0x3F4F310", VA = "0x183F50B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BE50", Offset = "0x2B8A650", VA = "0x182B8BE50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x924F80", VA = "0x180926780")]
	internal LHCIICLJEAC(T[] PFKJAOOHGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42572E0", Offset = "0x4255AE0", VA = "0x1842572E0")]
	public static LHCIICLJEAC<T> ENKECPBOOIC()
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
	public IEnumerable<T> ILALHCGAKPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42573B0", Offset = "0x4255BB0", VA = "0x1842573B0")]
	public ReadOnlySpan<T> IGCPKIKCNFG()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42571B0", Offset = "0x42559B0", VA = "0x1842571B0")]
	public DPAOMCDLCCA<T, LHCIICLJEAC<T>.DCIFPDBIHCO> DJBCFJPHHKC()
	{
		return default(DPAOMCDLCCA<T, DCIFPDBIHCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4257450", Offset = "0x4255C50", VA = "0x184257450")]
	public DCIFPDBIHCO MMLLIHGACCA()
	{
		return default(DCIFPDBIHCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4257130", Offset = "0x4255930", VA = "0x184257130")]
	public IEnumerator<T> DCPEOMEKOMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42574F0", Offset = "0x4255CF0", VA = "0x1842574F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LJFPBJNAABG
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x259D370", Offset = "0x259BB70", VA = "0x18259D370")]
	public static LHCIICLJEAC<T> KLHJLPOPLML<T>(params T[] PFKJAOOHGBN) where T : notnull
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69AB240", Offset = "0x69A9A40", VA = "0x1869AB240")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C07830", Offset = "0x3C06030", VA = "0x183C07830", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T ELLGIMLIIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3C06FD0", Offset = "0x3C057D0", VA = "0x183C06FD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T IDNMEPAIADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3C06DC0", Offset = "0x3C055C0", VA = "0x183C06DC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3C07230", Offset = "0x3C05A30", VA = "0x183C07230", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3C07420", Offset = "0x3C05C20", VA = "0x183C07420", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C077F0", Offset = "0x3C05FF0", VA = "0x183C077F0")]
		internal FOKBEFPNKIO(T[] FDPJMKODKPJ, int IHGHLPOONHD, int DHNLEFJCEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3C07150", Offset = "0x3C05950", VA = "0x183C07150")]
		public static FOKBEFPNKIO FJAAFKPDAIA(MAHDLFLAHIJ<T> HIKEOGPAJAF)
		{
			return default(FOKBEFPNKIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3858050", Offset = "0x3856850", VA = "0x183858050", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x38564F0", Offset = "0x3854CF0", VA = "0x1838564F0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C87D30", Offset = "0x3C86530", VA = "0x183C87D30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3C87B10", Offset = "0x3C86310", VA = "0x183C87B10", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3C87C20", Offset = "0x3C86420", VA = "0x183C87C20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1F728B0", Offset = "0x1F710B0", VA = "0x181F728B0")]
		private AMAMHKAIHJB([In] FOKBEFPNKIO OBCBMANCKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C879A0", Offset = "0x3C861A0", VA = "0x183C879A0")]
		public static AMAMHKAIHJB FJAAFKPDAIA([In] MAHDLFLAHIJ<T> HIKEOGPAJAF)
		{
			return default(AMAMHKAIHJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C87A50", Offset = "0x3C86250", VA = "0x183C87A50", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C87A90", Offset = "0x3C86290", VA = "0x183C87A90", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C87960", Offset = "0x3C86160", VA = "0x183C87960", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x4465A30", Offset = "0x4464230", VA = "0x184465A30")]
	public static MAHDLFLAHIJ<T> FJAAFKPDAIA()
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4465970", Offset = "0x4464170", VA = "0x184465970")]
	public static MAHDLFLAHIJ<T> EIGIPLIHNAM(int HHGNDILCLEE)
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1AA1530", Offset = "0x1A9FD30", VA = "0x181AA1530")]
	internal MAHDLFLAHIJ(T[] FDPJMKODKPJ, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4465AE0", Offset = "0x44642E0", VA = "0x184465AE0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B87320", Offset = "0x2B85B20", VA = "0x182B87320")]
	public static void CKOHIKCJKJA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B87C00", Offset = "0x2B86400", VA = "0x182B87C00")]
	public static string FDJLBEGHFMJ<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
	public static T[] ECLAHGAPEBN<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B8BD50", Offset = "0x2B8A550", VA = "0x182B8BD50")]
	public static T JMJOGDIBBHK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDD90", Offset = "0x1FBC590", VA = "0x181FBDD90")]
	public static T NEODAOFGJMA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B90E10", Offset = "0x2B8F610", VA = "0x182B90E10")]
	public static T NDCDAADAPHI<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B91140", Offset = "0x2B8F940", VA = "0x182B91140")]
	public static void OLOHHMDPKEO<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B350", Offset = "0x2B89B50", VA = "0x182B8B350")]
	public static void FPFHFGPCJHK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330")]
	public static int ILJNEEMJODN<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B740", Offset = "0x2B89F40", VA = "0x182B8B740")]
	public static ReadOnlySpan<T> IGCPKIKCNFG<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B90A20", Offset = "0x2B8F220", VA = "0x182B90A20")]
	public static T[] LLPFAPMPDEJ<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B873A0", Offset = "0x2B85BA0", VA = "0x182B873A0")]
	public static T COLNKPDAMPK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B87280", Offset = "0x2B85A80", VA = "0x182B87280")]
	public static T[] CKNPBMENOKA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8BC00", Offset = "0x2B8A400", VA = "0x182B8BC00")]
	public static LHCIICLJEAC<T> JGJAFHCKJMB<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(LHCIICLJEAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B917B0", Offset = "0x2B8FFB0", VA = "0x182B917B0")]
	public static void PBLNBBGFGAP<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E1F0", Offset = "0x2B8C9F0", VA = "0x182B8E1F0")]
	public static void LDIINDHGDHK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B580", Offset = "0x2B89D80", VA = "0x182B8B580")]
	public static void HDMLFENMIIH<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH, [In] T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B8BF60", Offset = "0x2B8A760", VA = "0x182B8BF60")]
	public static void LAKKMKEHFHG<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B87240", Offset = "0x2B85A40", VA = "0x182B87240")]
	public static void ACAJIKLBJOM<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B91CD0", Offset = "0x2B904D0", VA = "0x182B91CD0")]
	public static T PFBJBMEFDOJ<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E560", Offset = "0x2B8CD60", VA = "0x182B8E560")]
	public static void LDPNMKMBKDP<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B8C2B0", Offset = "0x2B8AAB0", VA = "0x182B8C2B0")]
	private static void LAMHFMADGIK<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B8BAF0", Offset = "0x2B8A2F0", VA = "0x182B8BAF0")]
	public static void IMJJLGNDCEN<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B830", Offset = "0x2B8A030", VA = "0x182B8B830")]
	public static MAHDLFLAHIJ<T> IJDMAMHKEEG<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, OJOANALFDFD<T, T> GLMCGGEBLBN)
	{
		return default(MAHDLFLAHIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B90B50", Offset = "0x2B8F350", VA = "0x182B90B50")]
	public static bool MFKDEBIIBOM<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, T JMDCGOKJIDA) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B873E0", Offset = "0x2B85BE0", VA = "0x182B873E0")]
	public static bool EJHJEADNLNA<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA) where T : HHDDKAPPENK<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B1EC50", Offset = "0x2B1D450", VA = "0x182B1EC50")]
	public static bool OJBMAONCMFP<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B6F0", Offset = "0x2B89EF0", VA = "0x182B8B6F0")]
	public static bool HLJIJANFIGD<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF, int HCDMGOGKHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B90CF0", Offset = "0x2B8F4F0", VA = "0x182B90CF0")]
	public static void MHMPDMIJHAL<T, TCtx>(this MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B90F40", Offset = "0x2B8F740", VA = "0x182B90F40")]
	private static void NDIFDFGAIGO<T, TCtx>(MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML, int KDKHIJEEJNH, int PCMKKMJDLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B874A0", Offset = "0x2B85CA0", VA = "0x182B874A0")]
	private static int EPGFGCGCHFC<T, TCtx>(MAHDLFLAHIJ<T> HIKEOGPAJAF, [In] TCtx MOPANCMKHLH, GNEKLANIMIB<TCtx, T> LBAPACHEDML, int KDKHIJEEJNH, int PCMKKMJDLJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B1E000", Offset = "0x2B1C800", VA = "0x182B1E000")]
	public static MAHDLFLAHIJ<T>.AMAMHKAIHJB DCPEOMEKOMK<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(MAHDLFLAHIJ<T>.AMAMHKAIHJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B1E000", Offset = "0x2B1C800", VA = "0x182B1E000")]
	public static MAHDLFLAHIJ<T>.FOKBEFPNKIO EBJANLOGAHE<T>(this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(MAHDLFLAHIJ<T>.FOKBEFPNKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2995B90", Offset = "0x2994390", VA = "0x182995B90")]
	public static DPAOMCDLCCA<T, MAHDLFLAHIJ<T>.AMAMHKAIHJB> ACCPBNBFICP<T>([In] this MAHDLFLAHIJ<T> HIKEOGPAJAF)
	{
		return default(DPAOMCDLCCA<T, MAHDLFLAHIJ<T>.AMAMHKAIHJB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class AAMKEDLLIIC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x31CA000", Offset = "0x31C8800", VA = "0x1831CA000")]
	public static T[] KMPFJCFFCHG<T>(int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
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
