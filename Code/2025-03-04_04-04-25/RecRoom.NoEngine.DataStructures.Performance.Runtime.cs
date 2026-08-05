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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7619EB0", Offset = "0x76184B0", VA = "0x187619EB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DDFMDALOMKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3202960", Offset = "0x3200F60", VA = "0x183202960")]
	public static CMNAKGAJECJ<T> BLFLBEABEBE<T>(this T[] JDCFMPOHCEA) where T : notnull
	{
		return default(CMNAKGAJECJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class NOHDKHNEHBB<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LDIDKHKLAFM<T> PJBCGMNPFFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4EEAE00", Offset = "0x4EE9400", VA = "0x184EEAE00", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4EEADC0", Offset = "0x4EE93C0", VA = "0x184EEADC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAC40", Offset = "0x4EE9240", VA = "0x184EEAC40")]
	public static NOHDKHNEHBB<T> FEOBEKOIKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAEC0", Offset = "0x4EE94C0", VA = "0x184EEAEC0")]
	internal NOHDKHNEHBB([In] LDIDKHKLAFM<T> AAMBBOLAGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4EEABC0", Offset = "0x4EE91C0", VA = "0x184EEABC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAC00", Offset = "0x4EE9200", VA = "0x184EEAC00")]
	public void EKABFIJKLOE(int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAD70", Offset = "0x4EE9370", VA = "0x184EEAD70", Slot = "8")]
	public LDIDKHKLAFM<T>.CGAOLCMHHDL GetEnumerator()
	{
		return default(LDIDKHKLAFM<T>.CGAOLCMHHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAE40", Offset = "0x4EE9440", VA = "0x184EEAE40", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAE40", Offset = "0x4EE9440", VA = "0x184EEAE40", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AJJDFIHNGOI<T, U> : IEnumerable<T>, IEnumerable where U : PPCKCBNJKIP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U CBGJBIFAPIK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x253F230", Offset = "0x253D830", VA = "0x18253F230")]
	internal AJJDFIHNGOI([In] U KGHMANIHPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1048800", Offset = "0x1046E00", VA = "0x181048800", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x47890C0", Offset = "0x47876C0", VA = "0x1847890C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x47890C0", Offset = "0x47876C0", VA = "0x1847890C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CLOEOLHDKFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3442E50", Offset = "0x3441450", VA = "0x183442E50")]
	public static AJJDFIHNGOI<T, U> FEOBEKOIKMG<U>([In] U JDCFMPOHCEA) where U : PPCKCBNJKIP<T>
	{
		return default(AJJDFIHNGOI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct INCPBLHJHCJ<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U CBGJBIFAPIK;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x47892C0", Offset = "0x47878C0", VA = "0x1847892C0")]
	internal INCPBLHJHCJ([In] U KGHMANIHPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4789050", Offset = "0x4787650", VA = "0x184789050", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4789050", Offset = "0x4787650", VA = "0x184789050", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GEEKLMGAMDF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3447DA0", Offset = "0x34463A0", VA = "0x183447DA0")]
	public static INCPBLHJHCJ<T, U> FEOBEKOIKMG<U>([In] U JDCFMPOHCEA) where U : IEnumerator<T>
	{
		return default(INCPBLHJHCJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class JGJEOBNJMLN
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x346BA00", Offset = "0x346A000", VA = "0x18346BA00")]
	public static string NDGLMPNHLAO<T>(this IEnumerable<T> JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x34570E0", Offset = "0x34556E0", VA = "0x1834570E0")]
	public static string KAOLFCFJAPG<T>(this IEnumerable<T> JDCFMPOHCEA, string HADKLKHEHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FNDBFPINHKP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33C3000", Offset = "0x33C1600", VA = "0x1833C3000")]
	public static bool OALPGCHFLHI<TSourceEnumerator, TSource>(this TSourceEnumerator JDCFMPOHCEA, [In] TSource MBDDOPABDGG) where TSourceEnumerator : PPCKCBNJKIP<TSource> where TSource : ONOAGGFEAEF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x33C2E70", Offset = "0x33C1470", VA = "0x1833C2E70")]
	public static int MELKALJCDCJ<TSourceEnumerator, TSource>(this TSourceEnumerator JDCFMPOHCEA, [In] TSource KBGCCIOIGBD) where TSourceEnumerator : PPCKCBNJKIP<TSource> where TSource : ONOAGGFEAEF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33C2C00", Offset = "0x33C1200", VA = "0x1833C2C00")]
	public static int IBOIFFAKMCK<TSourceEnumerator, TSource>(this TSourceEnumerator JDCFMPOHCEA, [In] TSource KBGCCIOIGBD) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PPCKCBNJKIP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FJMLFGNPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CNHFIGEHNIH<T> : PPCKCBNJKIP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct OOCHMAEFKIK<T, U> : IEnumerable<T>, IEnumerable where U : CNHFIGEHNIH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U CBGJBIFAPIK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x47891B0", Offset = "0x47877B0", VA = "0x1847891B0")]
	internal OOCHMAEFKIK([In] U KGHMANIHPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x41193B0", Offset = "0x41179B0", VA = "0x1841193B0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4788EB0", Offset = "0x47874B0", VA = "0x184788EB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4788EB0", Offset = "0x47874B0", VA = "0x184788EB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NKCBAPFHFFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3442E80", Offset = "0x3441480", VA = "0x183442E80")]
	public static OOCHMAEFKIK<T, U> FEOBEKOIKMG<U>([In] U JDCFMPOHCEA) where U : CNHFIGEHNIH<T>
	{
		return default(OOCHMAEFKIK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct CMNAKGAJECJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ACNLLNCCPJC : PPCKCBNJKIP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] OODPELMENGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int AGMGMPEADMJ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x47C8020", Offset = "0x47C6620", VA = "0x1847C8020", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x47C7AF0", Offset = "0x47C60F0", VA = "0x1847C7AF0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x47C7F50", Offset = "0x47C6550", VA = "0x1847C7F50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAAF470", Offset = "0xAADA70", VA = "0x180AAF470")]
		private ACNLLNCCPJC(T[] JDCFMPOHCEA, int EAHKFAJBNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4420120", Offset = "0x441E720", VA = "0x184420120")]
		public static ACNLLNCCPJC FEOBEKOIKMG(T[] JDCFMPOHCEA)
		{
			return default(ACNLLNCCPJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2589060", Offset = "0x2587660", VA = "0x182589060", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2587D50", Offset = "0x2586350", VA = "0x182587D50", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] ELCAEGINFAO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x49D1610", Offset = "0x49CFC10", VA = "0x1849D1610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x34A9DF0", Offset = "0x34A83F0", VA = "0x1834A9DF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	internal CMNAKGAJECJ(T[] CJFOOLJEHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C48590", Offset = "0x5C46B90", VA = "0x185C48590")]
	public static CMNAKGAJECJ<T> DGEEMDAPOEK()
	{
		return default(CMNAKGAJECJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
	public IEnumerable<T> GIEPBGEFBMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C48660", Offset = "0x5C46C60", VA = "0x185C48660")]
	public ReadOnlySpan<T> DJGGCPNMMFA()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C48700", Offset = "0x5C46D00", VA = "0x185C48700")]
	public AJJDFIHNGOI<T, CMNAKGAJECJ<T>.ACNLLNCCPJC> JODDKKKAAEI()
	{
		return default(AJJDFIHNGOI<T, ACNLLNCCPJC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C48830", Offset = "0x5C46E30", VA = "0x185C48830")]
	public ACNLLNCCPJC LKHCCDPMJMD()
	{
		return default(ACNLLNCCPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5C48510", Offset = "0x5C46B10", VA = "0x185C48510")]
	public IEnumerator<T> BNIMLGJMJBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C488D0", Offset = "0x5C46ED0", VA = "0x185C488D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NJCPNFMNKJN
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3198EE0", Offset = "0x31974E0", VA = "0x183198EE0")]
	public static CMNAKGAJECJ<T> LBEMDJJIDDJ<T>(params T[] CJFOOLJEHLK) where T : notnull
	{
		return default(CMNAKGAJECJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7619E50", Offset = "0x7618450", VA = "0x187619E50")]
	public static Stream FFDADKOPAHC(this CMNAKGAJECJ<byte> JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(LDIDKHKLAFM<>.CECGIFPCDAK))]
public struct LDIDKHKLAFM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct CGAOLCMHHDL : CNHFIGEHNIH<T>, PPCKCBNJKIP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] IEHAAILKLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int JMNHMIGEKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int AGMGMPEADMJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5A76F20", Offset = "0x5A75520", VA = "0x185A76F20", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T BEMNLIGGPAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5A76610", Offset = "0x5A74C10", VA = "0x185A76610")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T NGAKFLHGEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5A76570", Offset = "0x5A74B70", VA = "0x185A76570", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5A76890", Offset = "0x5A74E90", VA = "0x185A76890", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5A76D70", Offset = "0x5A75370", VA = "0x185A76D70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4E6DDC0", Offset = "0x4E6C3C0", VA = "0x184E6DDC0")]
		internal CGAOLCMHHDL(T[] FDMJAFAEFBP, int BBEJNKBNMID, int EAHKFAJBNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5A763D0", Offset = "0x5A749D0", VA = "0x185A763D0")]
		public static CGAOLCMHHDL FEOBEKOIKMG(LDIDKHKLAFM<T> JDCFMPOHCEA)
		{
			return default(CGAOLCMHHDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40D60F0", Offset = "0x40D46F0", VA = "0x1840D60F0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x40D0BC0", Offset = "0x40CF1C0", VA = "0x1840D0BC0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct NGLMKBFLJHE : PPCKCBNJKIP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CGAOLCMHHDL CBGJBIFAPIK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4E9B600", Offset = "0x4E99C00", VA = "0x184E9B600", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4E9B2C0", Offset = "0x4E998C0", VA = "0x184E9B2C0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4E9B440", Offset = "0x4E99A40", VA = "0x184E9B440", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x253F230", Offset = "0x253D830", VA = "0x18253F230")]
		private NGLMKBFLJHE([In] CGAOLCMHHDL KGHMANIHPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B150", Offset = "0x4E99750", VA = "0x184E9B150")]
		public static NGLMKBFLJHE FEOBEKOIKMG([In] LDIDKHKLAFM<T> JDCFMPOHCEA)
		{
			return default(NGLMKBFLJHE);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B200", Offset = "0x4E99800", VA = "0x184E9B200", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B240", Offset = "0x4E99840", VA = "0x184E9B240", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B110", Offset = "0x4E99710", VA = "0x184E9B110", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class CECGIFPCDAK
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] IEHAAILKLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int JMNHMIGEKFN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4BB2DC0", Offset = "0x4BB13C0", VA = "0x184BB2DC0")]
	public static LDIDKHKLAFM<T> FEOBEKOIKMG()
	{
		return default(LDIDKHKLAFM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4BB2E70", Offset = "0x4BB1470", VA = "0x184BB2E70")]
	public static LDIDKHKLAFM<T> KNALDNDGHEJ(int CCAKDDNOMFJ)
	{
		return default(LDIDKHKLAFM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAAF470", Offset = "0xAADA70", VA = "0x180AAF470")]
	internal LDIDKHKLAFM(T[] FDMJAFAEFBP, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4BB2F30", Offset = "0x4BB1530", VA = "0x184BB2F30", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KFHLBPLIEIC
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int FHAHGILJONC<TCtx, T>([In] TCtx HEPINKPGFIG, T CLHNCHKFPON, T KMNANLEEDKO);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x34A5AF0", Offset = "0x34A40F0", VA = "0x1834A5AF0")]
	public static void MHAKNCNBNPL<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x34A5DF0", Offset = "0x34A43F0", VA = "0x1834A5DF0")]
	public static string NOEFKMJIFCC<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
	public static T[] NBEAMLDGOJA<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x34A9DF0", Offset = "0x34A83F0", VA = "0x1834A9DF0")]
	public static T NPPDIJEBOHO<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA, int BKHEBBAMMAK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x34A9DF0", Offset = "0x34A83F0", VA = "0x1834A9DF0")]
	public static T PDFGDBEJOPK<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int BKHEBBAMMAK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34A59C0", Offset = "0x34A3FC0", VA = "0x1834A59C0")]
	public static T KLLOEJEFCAF<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA, int BKHEBBAMMAK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x349F890", Offset = "0x349DE90", VA = "0x18349F890")]
	public static void ECFLGDLFBIO<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int BKHEBBAMMAK, [In] T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x349EC20", Offset = "0x349D220", VA = "0x18349EC20")]
	public static void AOLJFOPLEED<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int BKHEBBAMMAK, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2587DE0", Offset = "0x25863E0", VA = "0x182587DE0")]
	public static int HOEIOPNDBAB<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x349F630", Offset = "0x349DC30", VA = "0x18349F630")]
	public static ReadOnlySpan<T> DJGGCPNMMFA<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34A5B80", Offset = "0x34A4180", VA = "0x1834A5B80")]
	public static T[] NJEAGIDGELK<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x34A2500", Offset = "0x34A0B00", VA = "0x1834A2500")]
	public static T EMGEIEKHGID<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x349EA70", Offset = "0x349D070", VA = "0x18349EA70")]
	public static T[] AJNEDLDKNGC<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x34A3290", Offset = "0x34A1890", VA = "0x1834A3290")]
	public static CMNAKGAJECJ<T> JAANGNJFPJB<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return default(CMNAKGAJECJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x34A2C30", Offset = "0x34A1230", VA = "0x1834A2C30")]
	public static void HBHDBABAKDP<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, [In] T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x349F300", Offset = "0x349D900", VA = "0x18349F300")]
	public static void BAEOOBMHANB<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x34A5790", Offset = "0x34A3D90", VA = "0x1834A5790")]
	public static void KLHNJBNJIGK<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int EAHKFAJBNDN, [In] T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x349E9B0", Offset = "0x349CFB0", VA = "0x18349E9B0")]
	public static void AGEABGPEFLG<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int EAHKFAJBNDN, [In] LDIDKHKLAFM<T> BMKDAHEBDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x349F730", Offset = "0x349DD30", VA = "0x18349F730")]
	public static void DLLEGKFOKLH<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int EAHKFAJBNDN, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x34A3250", Offset = "0x34A1850", VA = "0x1834A3250")]
	public static void IKJELBOAPFN<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x349F5D0", Offset = "0x349DBD0", VA = "0x18349F5D0")]
	public static T CGNPMLFNAKC<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x349FBE0", Offset = "0x349E1E0", VA = "0x18349FBE0")]
	public static void EKABFIJKLOE<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x34A3360", Offset = "0x34A1960", VA = "0x1834A3360")]
	private static void JMCNAKAKFPM<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x34A53B0", Offset = "0x34A39B0", VA = "0x1834A53B0")]
	public static void KKIOKOIHHPE<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x34A5530", Offset = "0x34A3B30", VA = "0x1834A5530")]
	public static LDIDKHKLAFM<T> KKJJGGFFFGK<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA, EJMIMAGAOLC<T, T> OFBHJNDNMBD)
	{
		return default(LDIDKHKLAFM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x34AA020", Offset = "0x34A8620", VA = "0x1834AA020")]
	public static bool OCDDHDAHAOD<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, T KBGCCIOIGBD) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x34AA1C0", Offset = "0x34A87C0", VA = "0x1834AA1C0")]
	public static bool OLGIPJKFOPP<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA, [In] T KBGCCIOIGBD) where T : ONOAGGFEAEF<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x34A5B70", Offset = "0x34A4170", VA = "0x1834A5B70")]
	public static bool MOBPININNFE<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x34A31F0", Offset = "0x34A17F0", VA = "0x1834A31F0")]
	public static bool HFGGDFIPHMA<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA, int BKHEBBAMMAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34A2BE0", Offset = "0x34A11E0", VA = "0x1834A2BE0")]
	public static void GAGGLGNJIAN<T, TCtx>(this LDIDKHKLAFM<T> JDCFMPOHCEA, [In] TCtx HEPINKPGFIG, FHAHGILJONC<TCtx, T> IBMJOOIIPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x349EB20", Offset = "0x349D120", VA = "0x18349EB20")]
	private static void AKPAIMHJBIC<T, TCtx>(LDIDKHKLAFM<T> JDCFMPOHCEA, [In] TCtx HEPINKPGFIG, FHAHGILJONC<TCtx, T> IBMJOOIIPKB, int GFOALKBOEGE, int DNCFJGOFKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x34A2540", Offset = "0x34A0B40", VA = "0x1834A2540")]
	private static int FKADAOGHLCL<T, TCtx>(LDIDKHKLAFM<T> JDCFMPOHCEA, [In] TCtx HEPINKPGFIG, FHAHGILJONC<TCtx, T> IBMJOOIIPKB, int GFOALKBOEGE, int DNCFJGOFKKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x33F19E0", Offset = "0x33EFFE0", VA = "0x1833F19E0")]
	public static LDIDKHKLAFM<T>.NGLMKBFLJHE BNIMLGJMJBK<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return default(LDIDKHKLAFM<T>.NGLMKBFLJHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x33F19E0", Offset = "0x33EFFE0", VA = "0x1833F19E0")]
	public static LDIDKHKLAFM<T>.CGAOLCMHHDL PBCEIIECEDD<T>(this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return default(LDIDKHKLAFM<T>.CGAOLCMHHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x349F540", Offset = "0x349DB40", VA = "0x18349F540")]
	public static AJJDFIHNGOI<T, LDIDKHKLAFM<T>.NGLMKBFLJHE> CFLOOMEAPJO<T>([In] this LDIDKHKLAFM<T> JDCFMPOHCEA)
	{
		return default(AJJDFIHNGOI<T, LDIDKHKLAFM<T>.NGLMKBFLJHE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class AJHLLBDFICM
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3B75250", Offset = "0x3B73850", VA = "0x183B75250")]
	public static T[] MPPDPPJHEAM<T>(int IBMHAIHIDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	public static void PBMIPCGNMHF<T>(T[] CJFOOLJEHLK)
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
