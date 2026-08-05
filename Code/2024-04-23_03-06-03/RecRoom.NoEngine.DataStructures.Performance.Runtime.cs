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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6367460", Offset = "0x6366460", VA = "0x186367460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ANBDHOICIKM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26AB9C0", Offset = "0x26AA9C0", VA = "0x1826AB9C0")]
	public static HAOCLPALDAM<T> PBOAKIPGJOK<T>(this T[] HFLBADIEKAM) where T : notnull
	{
		return default(HAOCLPALDAM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class LCNOMGEJHDM<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EJCNFOOPALK<T> BIHKANIIDAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D360", Offset = "0x3E1C360", VA = "0x183E1D360", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D4D0", Offset = "0x3E1C4D0", VA = "0x183E1D4D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D3B0", Offset = "0x3E1C3B0", VA = "0x183E1D3B0")]
	public static LCNOMGEJHDM<T> MGIIAIMPALM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x395E0C0", Offset = "0x395D0C0", VA = "0x18395E0C0")]
	internal LCNOMGEJHDM([In] EJCNFOOPALK<T> OFFMGNOKEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D2F0", Offset = "0x3E1C2F0", VA = "0x183E1D2F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D390", Offset = "0x3E1C390", VA = "0x183E1D390")]
	public void LMMCIAAMEEN(int MJMIIGGLEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D310", Offset = "0x3E1C310", VA = "0x183E1D310", Slot = "8")]
	public EJCNFOOPALK<T>.KHGBKMINBMK GetEnumerator()
	{
		return default(EJCNFOOPALK<T>.KHGBKMINBMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D500", Offset = "0x3E1C500", VA = "0x183E1D500", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D500", Offset = "0x3E1C500", VA = "0x183E1D500", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HOACKFAJJBE<T, U> : IEnumerable<T>, IEnumerable where U : FABBOBGDBML<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U FDCEMPDAPGO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E14D30", Offset = "0x1E13D30", VA = "0x181E14D30")]
	internal HOACKFAJJBE([In] U ABNJJAFLONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3899990", Offset = "0x3898990", VA = "0x183899990", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3899990", Offset = "0x3898990", VA = "0x183899990", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FEHFIIIIIPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26B2C80", Offset = "0x26B1C80", VA = "0x1826B2C80")]
	public static HOACKFAJJBE<T, U> MGIIAIMPALM<U>([In] U HFLBADIEKAM) where U : FABBOBGDBML<T>
	{
		return default(HOACKFAJJBE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FJDNLJOKGKJ<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U FDCEMPDAPGO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3899B60", Offset = "0x3898B60", VA = "0x183899B60")]
	internal FJDNLJOKGKJ([In] U ABNJJAFLONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9140E0", Offset = "0x9130E0", VA = "0x1809140E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38997E0", Offset = "0x38987E0", VA = "0x1838997E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38997E0", Offset = "0x38987E0", VA = "0x1838997E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HGKFFJHBJPL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27CA2D0", Offset = "0x27C92D0", VA = "0x1827CA2D0")]
	public static FJDNLJOKGKJ<T, U> MGIIAIMPALM<U>([In] U HFLBADIEKAM) where U : IEnumerator<T>
	{
		return default(FJDNLJOKGKJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class NGNMGOFPAJF
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B800", Offset = "0x2A0A800", VA = "0x182A0B800")]
	public static string ACOLLHEHIFO<T>(this IEnumerable<T> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E8C0", Offset = "0x2A0D8C0", VA = "0x182A0E8C0")]
	public static string KPHLGFEHNGI<T>(this IEnumerable<T> HFLBADIEKAM, string ICAPIODKBIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NKBLBGCOKBL
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A24ED0", Offset = "0x2A23ED0", VA = "0x182A24ED0")]
	public static bool DHMCJDFOOIJ<TSourceEnumerator, TSource>(this TSourceEnumerator HFLBADIEKAM, [In] TSource LLMAIFIKIOC) where TSourceEnumerator : FABBOBGDBML<TSource> where TSource : ECBLMMOEAKL<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2A24C70", Offset = "0x2A23C70", VA = "0x182A24C70")]
	public static int BOHJMBKJCBI<TSourceEnumerator, TSource>(this TSourceEnumerator HFLBADIEKAM, [In] TSource LDGMLLMKHLF) where TSourceEnumerator : FABBOBGDBML<TSource> where TSource : ECBLMMOEAKL<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FABBOBGDBML<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DGGBFKFKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NCNOMJMGMLE<T> : FABBOBGDBML<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DNCJLJOCAMB<T, U> : IEnumerable<T>, IEnumerable where U : NCNOMJMGMLE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U FDCEMPDAPGO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3A445E0", Offset = "0x3A435E0", VA = "0x183A445E0")]
	internal DNCJLJOCAMB([In] U ABNJJAFLONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35C9F40", Offset = "0x35C8F40", VA = "0x1835C9F40", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A44550", Offset = "0x3A43550", VA = "0x183A44550", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3A44550", Offset = "0x3A43550", VA = "0x183A44550", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IFJNGJKLEGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26B2C50", Offset = "0x26B1C50", VA = "0x1826B2C50")]
	public static DNCJLJOCAMB<T, U> MGIIAIMPALM<U>([In] U HFLBADIEKAM) where U : NCNOMJMGMLE<T>
	{
		return default(DNCJLJOCAMB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct HAOCLPALDAM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct GCFBBIGFNBD : FABBOBGDBML<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] LOLHHEJKLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int GGKMDJIPGHP;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x39998C0", Offset = "0x39988C0", VA = "0x1839998C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x39992A0", Offset = "0x39982A0", VA = "0x1839992A0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3999410", Offset = "0x3998410", VA = "0x183999410", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18FF2A0", Offset = "0x18FE2A0", VA = "0x1818FF2A0")]
		private GCFBBIGFNBD(T[] HFLBADIEKAM, int GPEHCABDGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3999120", Offset = "0x3998120", VA = "0x183999120")]
		public static GCFBBIGFNBD MGIIAIMPALM(T[] HFLBADIEKAM)
		{
			return default(GCFBBIGFNBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F890", Offset = "0x1E3E890", VA = "0x181E3F890", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F8C0", Offset = "0x1E3E8C0", VA = "0x181E3F8C0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] NDBDIJOOKML;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GBPKIPDCGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3A02210", Offset = "0x3A01210", VA = "0x183A02210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28C5150", Offset = "0x28C4150", VA = "0x1828C5150")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x94ABA0", Offset = "0x949BA0", VA = "0x18094ABA0")]
	internal HAOCLPALDAM(T[] PAFIMPMPKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3A02340", Offset = "0x3A01340", VA = "0x183A02340")]
	public static HAOCLPALDAM<T> LGJIMEKOCEB()
	{
		return default(HAOCLPALDAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
	public IEnumerable<T> AKPGPNBCCOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A02060", Offset = "0x3A01060", VA = "0x183A02060")]
	public ReadOnlySpan<T> BGLPNOHGJJL()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A020F0", Offset = "0x3A010F0", VA = "0x183A020F0")]
	public HOACKFAJJBE<T, HAOCLPALDAM<T>.GCFBBIGFNBD> HCBMFLBGBCD()
	{
		return default(HOACKFAJJBE<T, GCFBBIGFNBD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A022B0", Offset = "0x3A012B0", VA = "0x183A022B0")]
	public GCFBBIGFNBD KMFOEFGLFBF()
	{
		return default(GCFBBIGFNBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3A02230", Offset = "0x3A01230", VA = "0x183A02230")]
	public IEnumerator<T> IEKFBOGGJFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3A02400", Offset = "0x3A01400", VA = "0x183A02400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BDNGOLJLDMO
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x26B9B10", Offset = "0x26B8B10", VA = "0x1826B9B10")]
	public static HAOCLPALDAM<T> CIHLACPLEBP<T>(params T[] PAFIMPMPKHD) where T : notnull
	{
		return default(HAOCLPALDAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6367400", Offset = "0x6366400", VA = "0x186367400")]
	public static Stream HPNHJHNNJCC(this HAOCLPALDAM<byte> HFLBADIEKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(EJCNFOOPALK<>.PDPKJGEDGJE))]
public struct EJCNFOOPALK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct KHGBKMINBMK : NCNOMJMGMLE<T>, FABBOBGDBML<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] KCDBKCHOEOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int OEGPINEBAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int GGKMDJIPGHP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3D85CC0", Offset = "0x3D84CC0", VA = "0x183D85CC0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T DGAFMNCPBOC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3D85610", Offset = "0x3D84610", VA = "0x183D85610", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3D85870", Offset = "0x3D84870", VA = "0x183D85870", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3D858D0", Offset = "0x3D848D0", VA = "0x183D858D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3524660", Offset = "0x3523660", VA = "0x183524660")]
		internal KHGBKMINBMK(T[] DCGPAEFOGCA, int MJMIIGGLEFB, int GPEHCABDGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D85420", Offset = "0x3D84420", VA = "0x183D85420")]
		public static KHGBKMINBMK MGIIAIMPALM(EJCNFOOPALK<T> HFLBADIEKAM)
		{
			return default(KHGBKMINBMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3589000", Offset = "0x3588000", VA = "0x183589000", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3584550", Offset = "0x3583550", VA = "0x183584550", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct HAEHDKOOGKM : FABBOBGDBML<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KHGBKMINBMK FDCEMPDAPGO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3A004D0", Offset = "0x39FF4D0", VA = "0x183A004D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3A001B0", Offset = "0x39FF1B0", VA = "0x183A001B0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3A003E0", Offset = "0x39FF3E0", VA = "0x183A003E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E14D30", Offset = "0x1E13D30", VA = "0x181E14D30")]
		private HAEHDKOOGKM([In] KHGBKMINBMK ABNJJAFLONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3A00020", Offset = "0x39FF020", VA = "0x183A00020")]
		public static HAEHDKOOGKM MGIIAIMPALM([In] EJCNFOOPALK<T> HFLBADIEKAM)
		{
			return default(HAEHDKOOGKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3A000D0", Offset = "0x39FF0D0", VA = "0x183A000D0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3A00110", Offset = "0x39FF110", VA = "0x183A00110", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x39FFFE0", Offset = "0x39FEFE0", VA = "0x1839FFFE0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class PDPKJGEDGJE
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] KCDBKCHOEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int OEGPINEBAMA;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3514D00", Offset = "0x3513D00", VA = "0x183514D00")]
	public static EJCNFOOPALK<T> MGIIAIMPALM()
	{
		return default(EJCNFOOPALK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3514C50", Offset = "0x3513C50", VA = "0x183514C50")]
	public static EJCNFOOPALK<T> ANNLLFMKKDB(int AFDLPCPCHIJ)
	{
		return default(EJCNFOOPALK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x18FF2A0", Offset = "0x18FE2A0", VA = "0x1818FF2A0")]
	internal EJCNFOOPALK(T[] DCGPAEFOGCA, int MJMIIGGLEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3514DA0", Offset = "0x3513DA0", VA = "0x183514DA0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GLCICBLFMLN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int AMBANKPAIMB<TCtx, T>([In] TCtx PNMNIPGGMGH, T LEGDDGHJEMC, T KNJHKKJANOJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28C4BE0", Offset = "0x28C3BE0", VA = "0x1828C4BE0")]
	public static void FAAFJENLCBJ<T>(this EJCNFOOPALK<T> HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28C5640", Offset = "0x28C4640", VA = "0x1828C5640")]
	public static string JKBFOCHCAIA<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
	public static T[] GHAPKBONLIF<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F7E0", Offset = "0x1E3E7E0", VA = "0x181E3F7E0")]
	public static T HBEPMKJLJFA<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM, int AFFJDCKHCJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F7E0", Offset = "0x1E3E7E0", VA = "0x181E3F7E0")]
	public static T NPLGHKKEOOE<T>(this EJCNFOOPALK<T> HFLBADIEKAM, int AFFJDCKHCJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28C4E30", Offset = "0x28C3E30", VA = "0x1828C4E30")]
	public static T FIHOCAABGGJ<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM, int AFFJDCKHCJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28CA300", Offset = "0x28C9300", VA = "0x1828CA300")]
	public static void PGLEONAELKI<T>(this EJCNFOOPALK<T> HFLBADIEKAM, int AFFJDCKHCJD, [In] T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x28CA070", Offset = "0x28C9070", VA = "0x1828CA070")]
	public static void NABFHGLLLPO<T>(this EJCNFOOPALK<T> HFLBADIEKAM, int AFFJDCKHCJD, T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E64090", Offset = "0x1E63090", VA = "0x181E64090")]
	public static int PFPIMPJHDDH<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28C2750", Offset = "0x28C1750", VA = "0x1828C2750")]
	public static ReadOnlySpan<T> BGLPNOHGJJL<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x28C2B60", Offset = "0x28C1B60", VA = "0x1828C2B60")]
	public static T[] DEAJAMOLDIA<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x28C2820", Offset = "0x28C1820", VA = "0x1828C2820")]
	public static T CEFLCANIFEN<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x28C9F00", Offset = "0x28C8F00", VA = "0x1828C9F00")]
	public static T[] LODAEMGNMNG<T>(this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x28CA1D0", Offset = "0x28C91D0", VA = "0x1828CA1D0")]
	public static HAOCLPALDAM<T> OLCLANJGBMC<T>(this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return default(HAOCLPALDAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28C2260", Offset = "0x28C1260", VA = "0x1828C2260")]
	public static void BGLDHBEBEIE<T>(this EJCNFOOPALK<T> HFLBADIEKAM, [In] T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28C4CA0", Offset = "0x28C3CA0", VA = "0x1828C4CA0")]
	public static void FGNGJKDLLEG<T>(this EJCNFOOPALK<T> HFLBADIEKAM, T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28C28F0", Offset = "0x28C18F0", VA = "0x1828C28F0")]
	public static void CENKJJGAGNC<T>(this EJCNFOOPALK<T> HFLBADIEKAM, int GPEHCABDGEJ, [In] T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28C7ED0", Offset = "0x28C6ED0", VA = "0x1828C7ED0")]
	public static void LHDOHJPBAPM<T>(this EJCNFOOPALK<T> HFLBADIEKAM, int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x28CA120", Offset = "0x28C9120", VA = "0x1828CA120")]
	public static T NNCELKBBMGO<T>(this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28C83E0", Offset = "0x28C73E0", VA = "0x1828C83E0")]
	public static void LMMCIAAMEEN<T>(this EJCNFOOPALK<T> HFLBADIEKAM, int MJMIIGGLEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28C2C90", Offset = "0x28C1C90", VA = "0x1828C2C90")]
	private static void DFKJIFMCJFO<T>(this EJCNFOOPALK<T> HFLBADIEKAM, int AFDLPCPCHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28C52C0", Offset = "0x28C42C0", VA = "0x1828C52C0")]
	public static void HCLIMFMHPCF<T>(this EJCNFOOPALK<T> HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28C5440", Offset = "0x28C4440", VA = "0x1828C5440")]
	public static EJCNFOOPALK<T> HKOPKLJMPAD<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM, OPDIJMGBGKM<T, T> PCGJLDKNCLL)
	{
		return default(EJCNFOOPALK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28CA260", Offset = "0x28C9260", VA = "0x1828CA260")]
	public static bool PBJJFOLFFFO<T>(this EJCNFOOPALK<T> HFLBADIEKAM, [In] T LDGMLLMKHLF) where T : ECBLMMOEAKL<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x28CA180", Offset = "0x28C9180", VA = "0x1828CA180")]
	public static bool NPKMANILOIC<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x28C4BA0", Offset = "0x28C3BA0", VA = "0x1828C4BA0")]
	public static bool EKKHNOMFFCH<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM, int AFFJDCKHCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28C9F80", Offset = "0x28C8F80", VA = "0x1828C9F80")]
	public static void MELJNGFANJJ<T, TCtx>(this EJCNFOOPALK<T> HFLBADIEKAM, [In] TCtx PNMNIPGGMGH, AMBANKPAIMB<TCtx, T> MBOAOFGOIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x28C21A0", Offset = "0x28C11A0", VA = "0x1828C21A0")]
	private static void AECGCMGMJIO<T, TCtx>(EJCNFOOPALK<T> HFLBADIEKAM, [In] TCtx PNMNIPGGMGH, AMBANKPAIMB<TCtx, T> MBOAOFGOIND, int JFJLPPHKJPH, int AANPHDGHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x28C4750", Offset = "0x28C3750", VA = "0x1828C4750")]
	private static int EHDKEKADFKM<T, TCtx>(EJCNFOOPALK<T> HFLBADIEKAM, [In] TCtx PNMNIPGGMGH, AMBANKPAIMB<TCtx, T> MBOAOFGOIND, int JFJLPPHKJPH, int AANPHDGHHIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2763540", Offset = "0x2762540", VA = "0x182763540")]
	public static EJCNFOOPALK<T>.HAEHDKOOGKM IEKFBOGGJFJ<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return default(EJCNFOOPALK<T>.HAEHDKOOGKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2763540", Offset = "0x2762540", VA = "0x182763540")]
	public static EJCNFOOPALK<T>.KHGBKMINBMK ANLCFNJDOCO<T>(this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return default(EJCNFOOPALK<T>.KHGBKMINBMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x28C46E0", Offset = "0x28C36E0", VA = "0x1828C46E0")]
	public static HOACKFAJJBE<T, EJCNFOOPALK<T>.HAEHDKOOGKM> DLFLEHEBAOH<T>([In] this EJCNFOOPALK<T> HFLBADIEKAM)
	{
		return default(HOACKFAJJBE<T, EJCNFOOPALK<T>.HAEHDKOOGKM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class PLEBEINACGK
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A56080", Offset = "0x2A55080", VA = "0x182A56080")]
	public static T[] EMFOEMFHMNE<T>(int GFFAGBDKDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	public static void MEKNAGHPNEP<T>(T[] PAFIMPMPKHD)
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
