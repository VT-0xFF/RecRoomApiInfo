using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7275190", Offset = "0x7273790", VA = "0x187275190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LGLPBFGNCDF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T PGNBHIOAFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class KMNKHEDMALG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x387D300", Offset = "0x387B900", VA = "0x18387D300")]
	public static string ILCIAMPEHGM<T>(this IEnumerable<T> PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3872770", Offset = "0x3870D70", VA = "0x183872770")]
	public static string ADIFAMAPOOF<T>(this IEnumerable<T> PBJDHAKDMFG, string PLFNIICKDPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MHDNPLFPGBA<T, U> : IEnumerable<T>, IEnumerable where U : CFCGKFLEMGP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U DGODLLKEJHG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7950", Offset = "0x1FF5F50", VA = "0x181FF7950")]
	internal MHDNPLFPGBA(in U NLCCEHBOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x15C4C80", Offset = "0x15C3280", VA = "0x1815C4C80", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7510", Offset = "0x1FF5B10", VA = "0x181FF7510", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7510", Offset = "0x1FF5B10", VA = "0x181FF7510", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LDDHOCNEOJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x199A1B0", Offset = "0x19987B0", VA = "0x18199A1B0")]
	public static MHDNPLFPGBA<T, U> JBGFDEKBNPE<U>(in U PBJDHAKDMFG) where U : CFCGKFLEMGP<T>
	{
		return default(MHDNPLFPGBA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JOFOFBKDCEF
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x19FAEF0", Offset = "0x19F94F0", VA = "0x1819FAEF0")]
	public static bool HINNKCDFJCA<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator PBJDHAKDMFG, in TArgs GDDHAFPALIL, in GFHGBDHHALP<TArgs, TSource, bool> DMBCKDLEKGI) where TSourceEnumerator : LGLPBFGNCDF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x19FABB0", Offset = "0x19F91B0", VA = "0x1819FABB0")]
	public static int EFBAMNLJFHP<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator PBJDHAKDMFG, in TArgs GDDHAFPALIL, GFHGBDHHALP<TArgs, TSource, bool> DMBCKDLEKGI) where TSourceEnumerator : LGLPBFGNCDF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x19FB6E0", Offset = "0x19F9CE0", VA = "0x1819FB6E0")]
	public static bool NOADGKJKBNP<TSourceEnumerator, TSource>(this TSourceEnumerator PBJDHAKDMFG, in TSource CDIFGMFCFLG) where TSourceEnumerator : LGLPBFGNCDF<TSource> where TSource : IKGEBLJKMLJ<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x19FB1A0", Offset = "0x19F97A0", VA = "0x1819FB1A0")]
	public static int MPEJAMPECEF<TSourceEnumerator, TSource>(this TSourceEnumerator PBJDHAKDMFG, in TSource FEBHELIDNED) where TSourceEnumerator : LGLPBFGNCDF<TSource> where TSource : IKGEBLJKMLJ<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x19FAE60", Offset = "0x19F9460", VA = "0x1819FAE60")]
	public static MOGEMDKJELK<TSourceEnumerator, TSource, TResult> EFFIHDJCLPC<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator PBJDHAKDMFG, GNHHEMIOHNJ<TSource, TResult> OAFBJNCKOHI) where TSourceEnumerator : HNIKJHFAOCK, LGLPBFGNCDF<TSource>
	{
		return default(MOGEMDKJELK<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x19FAE60", Offset = "0x19F9460", VA = "0x1819FAE60")]
	public static NBBHOFENDOF<TSourceEnumerator, TSource, TResult> MGEOJKKPKBK<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator PBJDHAKDMFG, Func<TSource, TResult> OAFBJNCKOHI) where TSourceEnumerator : HNIKJHFAOCK, IEnumerator<TSource>
	{
		return default(NBBHOFENDOF<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AHHONGOEPLK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F7E3E0", Offset = "0x2F7C9E0", VA = "0x182F7E3E0")]
	public static bool DDNOHBCEDCH<TSourceEnumerator>(TSourceEnumerator PBJDHAKDMFG) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F7E160", Offset = "0x2F7C760", VA = "0x182F7E160")]
	public static T BLOGLOJCICL<TSourceEnumerator>(TSourceEnumerator PBJDHAKDMFG) where TSourceEnumerator : LGLPBFGNCDF<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F71700", Offset = "0x2F6FD00", VA = "0x182F71700")]
	public static T[] AGLAGAFAHAA<TSourceEnumerator>(TSourceEnumerator PBJDHAKDMFG) where TSourceEnumerator : HNIKJHFAOCK, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2F7E4F0", Offset = "0x2F7CAF0", VA = "0x182F7E4F0")]
	public static T HJKIDBEINJL<TSourceEnumerator>(TSourceEnumerator PBJDHAKDMFG) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct PJBJPKEHBBH<T, U> : IEnumerable<T>, IEnumerable where U : LGLPBFGNCDF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U DGODLLKEJHG;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
	internal PJBJPKEHBBH(in U NLCCEHBOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7590", Offset = "0x1FF5B90", VA = "0x181FF7590", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7590", Offset = "0x1FF5B90", VA = "0x181FF7590", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KNPMHPMHPNN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x199A180", Offset = "0x1998780", VA = "0x18199A180")]
	public static PJBJPKEHBBH<T, U> JBGFDEKBNPE<U>(in U PBJDHAKDMFG) where U : LGLPBFGNCDF<T>
	{
		return default(PJBJPKEHBBH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct BCFFEGHAMLG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IGGPHOEJMOJ : HNIKJHFAOCK, LGLPBFGNCDF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] GLIMMGHNBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int JABNGGFCFHE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int KLPPADFIIJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x218C780", Offset = "0x218AD80", VA = "0x18218C780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x218CD30", Offset = "0x218B330", VA = "0x18218CD30", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x218C7E0", Offset = "0x218ADE0", VA = "0x18218C7E0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x218C9E0", Offset = "0x218AFE0", VA = "0x18218C9E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x110AD10", Offset = "0x1109310", VA = "0x18110AD10")]
		private IGGPHOEJMOJ(T[] PBJDHAKDMFG, int IIOMOLKAONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x218C730", Offset = "0x218AD30", VA = "0x18218C730")]
		public static IGGPHOEJMOJ JBGFDEKBNPE(T[] PBJDHAKDMFG)
		{
			return default(IGGPHOEJMOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x218C7A0", Offset = "0x218ADA0", VA = "0x18218C7A0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x218C7D0", Offset = "0x218ADD0", VA = "0x18218C7D0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly T[] AAOPLFDAILE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DIDJDLOPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x218C780", Offset = "0x218AD80", VA = "0x18218C780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1226AB0", Offset = "0x12250B0", VA = "0x181226AB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	internal BCFFEGHAMLG(T[] JHKFLJIAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x50BB2E0", Offset = "0x50B98E0", VA = "0x1850BB2E0")]
	public static BCFFEGHAMLG<T> JKPLIBNKDEM()
	{
		return default(BCFFEGHAMLG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
	public IEnumerable<T> GMJLEMCOHBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50BB390", Offset = "0x50B9990", VA = "0x1850BB390")]
	public ReadOnlySpan<T> OKIDHPJGHBM()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x50BB130", Offset = "0x50B9730", VA = "0x1850BB130")]
	public PJBJPKEHBBH<T, BCFFEGHAMLG<T>.IGGPHOEJMOJ> COBCGCNGDLO()
	{
		return default(PJBJPKEHBBH<T, IGGPHOEJMOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x50BB250", Offset = "0x50B9850", VA = "0x1850BB250")]
	public IGGPHOEJMOJ CODKIJAEEMD()
	{
		return default(IGGPHOEJMOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50BB420", Offset = "0x50B9A20", VA = "0x1850BB420")]
	public IEnumerator<T> PFBFKEIKCCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x50BB4A0", Offset = "0x50B9AA0", VA = "0x1850BB4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MNGPMBJGMKE
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x178DF20", Offset = "0x178C520", VA = "0x18178DF20")]
	public static BCFFEGHAMLG<T> JNDAPEPKEAH<T>(params T[] JHKFLJIAOGC) where T : notnull
	{
		return default(BCFFEGHAMLG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HNIKJHFAOCK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IMEGHFBKMIM<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U DGODLLKEJHG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7950", Offset = "0x1FF5F50", VA = "0x181FF7950")]
	internal IMEGHFBKMIM(in U NLCCEHBOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15C4C80", Offset = "0x15C3280", VA = "0x1815C4C80", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7510", Offset = "0x1FF5B10", VA = "0x181FF7510", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7510", Offset = "0x1FF5B10", VA = "0x181FF7510", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CNONLKCKGPN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x199A1B0", Offset = "0x19987B0", VA = "0x18199A1B0")]
	public static IMEGHFBKMIM<T, U> JBGFDEKBNPE<U>(in U PBJDHAKDMFG) where U : IEnumerator<T>
	{
		return default(IMEGHFBKMIM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class FJNFOPHOKNH<T> : IDisposable, HNIKJHFAOCK, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private PDOIJMIAGIK<T> CFEELKCPLJD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x21FDA80", Offset = "0x21FC080", VA = "0x1821FDA80", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x21FD7B0", Offset = "0x21FBDB0", VA = "0x1821FD7B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x21FD970", Offset = "0x21FBF70", VA = "0x1821FD970")]
	public static FJNFOPHOKNH<T> JBGFDEKBNPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x21FD7D0", Offset = "0x21FBDD0", VA = "0x1821FD7D0")]
	public static FJNFOPHOKNH<T> BKFPKOLMMMA(int IOKNIDFIOPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x21FDB30", Offset = "0x21FC130", VA = "0x1821FDB30")]
	internal FJNFOPHOKNH(in PDOIJMIAGIK<T> EGHMJNHBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x21FD8F0", Offset = "0x21FBEF0", VA = "0x1821FD8F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x21FDAA0", Offset = "0x21FC0A0", VA = "0x1821FDAA0")]
	public void PEECNHFNIGK(in T FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x21FD910", Offset = "0x21FBF10", VA = "0x1821FD910")]
	public void GDEHEDKPGOA(int EGIKAKGFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x21FD930", Offset = "0x21FBF30", VA = "0x1821FD930", Slot = "8")]
	public PDOIJMIAGIK<T>.JOIFAEDJEIC GetEnumerator()
	{
		return default(PDOIJMIAGIK<T>.JOIFAEDJEIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x21FDAC0", Offset = "0x21FC0C0", VA = "0x1821FDAC0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x21FDAC0", Offset = "0x21FC0C0", VA = "0x1821FDAC0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(PDOIJMIAGIK<>.DOCCFOIOIMO))]
public struct PDOIJMIAGIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JOIFAEDJEIC : HNIKJHFAOCK, CFCGKFLEMGP<T>, LGLPBFGNCDF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] MGGINKGGIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int ICGIJGAKGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int JABNGGFCFHE;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int KLPPADFIIJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD4FCC0", Offset = "0xD4E2C0", VA = "0x180D4FCC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2E74B30", Offset = "0x2E73130", VA = "0x182E74B30", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T MNBGIMHDMEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2E73CC0", Offset = "0x2E722C0", VA = "0x182E73CC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2E74090", Offset = "0x2E72690", VA = "0x182E74090", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2E74530", Offset = "0x2E72B30", VA = "0x182E74530", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2064FD0", Offset = "0x20635D0", VA = "0x182064FD0")]
		internal JOIFAEDJEIC(T[] NEGBPLHGJID, int EGIKAKGFKPB, int IIOMOLKAONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2E739E0", Offset = "0x2E71FE0", VA = "0x182E739E0")]
		public static JOIFAEDJEIC JBGFDEKBNPE(ref PDOIJMIAGIK<T> PBJDHAKDMFG)
		{
			return default(JOIFAEDJEIC);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x276E390", Offset = "0x276C990", VA = "0x18276E390", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF71E0", Offset = "0x1FF57E0", VA = "0x181FF71E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct MPDCMGCDDPA : HNIKJHFAOCK, LGLPBFGNCDF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JOIFAEDJEIC DGODLLKEJHG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int KLPPADFIIJB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x26DDB20", Offset = "0x26DC120", VA = "0x1826DDB20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x29910F0", Offset = "0x298F6F0", VA = "0x1829910F0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2990560", Offset = "0x298EB60", VA = "0x182990560", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2990A20", Offset = "0x298F020", VA = "0x182990A20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1FF7990", Offset = "0x1FF5F90", VA = "0x181FF7990")]
		private MPDCMGCDDPA(in JOIFAEDJEIC NLCCEHBOCJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2990320", Offset = "0x298E920", VA = "0x182990320")]
		public static MPDCMGCDDPA JBGFDEKBNPE(in PDOIJMIAGIK<T> PBJDHAKDMFG)
		{
			return default(MPDCMGCDDPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x29903E0", Offset = "0x298E9E0", VA = "0x1829903E0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2990420", Offset = "0x298EA20", VA = "0x182990420", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x29902E0", Offset = "0x298E8E0", VA = "0x1829902E0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class DOCCFOIOIMO
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] MGGINKGGIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int ICGIJGAKGGH;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2DED660", Offset = "0x2DEBC60", VA = "0x182DED660")]
	public static PDOIJMIAGIK<T> JBGFDEKBNPE()
	{
		return default(PDOIJMIAGIK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DED580", Offset = "0x2DEBB80", VA = "0x182DED580")]
	public static PDOIJMIAGIK<T> BKFPKOLMMMA(int IOKNIDFIOPP)
	{
		return default(PDOIJMIAGIK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x110AD10", Offset = "0x1109310", VA = "0x18110AD10")]
	internal PDOIJMIAGIK(T[] NEGBPLHGJID, int EGIKAKGFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2DED730", Offset = "0x2DEBD30", VA = "0x182DED730", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IMJOCFJOADJ
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2164510", Offset = "0x2162B10", VA = "0x182164510")]
	public static void LFGPNIBMGLP<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x21630E0", Offset = "0x21616E0", VA = "0x1821630E0")]
	public static string JODBBBDHPFN<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x86D3F0", Offset = "0x86B9F0", VA = "0x18086D3F0")]
	public static T[] KADLIMEMOIJ<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2160E40", Offset = "0x215F440", VA = "0x182160E40")]
	public static T PIDCPOPDLLJ<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG, int JMCLMPHOKNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2160E40", Offset = "0x215F440", VA = "0x182160E40")]
	public static T HBPBGGLAJFB<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG, int JMCLMPHOKNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xD4FCC0", Offset = "0xD4E2C0", VA = "0x180D4FCC0")]
	public static int FKNOBCOHJNH<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21655F0", Offset = "0x2163BF0", VA = "0x1821655F0")]
	public static ReadOnlySpan<T> OKIDHPJGHBM<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2164580", Offset = "0x2162B80", VA = "0x182164580")]
	public static ReadOnlyMemory<T> OJOFHMALICJ<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2168340", Offset = "0x2166940", VA = "0x182168340")]
	public static void PEECNHFNIGK<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG, in T FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x215F990", Offset = "0x215DF90", VA = "0x18215F990")]
	public static void CJIDPAHKBHA<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG, int IIOMOLKAONM, in T FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x21644D0", Offset = "0x2162AD0", VA = "0x1821644D0")]
	public static void KHMDPDLENDM<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG, int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x215FEB0", Offset = "0x215E4B0", VA = "0x18215FEB0")]
	public static void GDEHEDKPGOA<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG, int EGIKAKGFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2160FC0", Offset = "0x215F5C0", VA = "0x182160FC0")]
	private static void IKJPEDHIJIO<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG, int IOKNIDFIOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x215F7F0", Offset = "0x215DDF0", VA = "0x18215F7F0")]
	public static void CCIICLEBIPJ<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2160CB0", Offset = "0x215F2B0", VA = "0x182160CB0")]
	public static bool GMNMDFFJOBD<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG, in T FEBHELIDNED) where T : IKGEBLJKMLJ<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1BF4FC0", Offset = "0x1BF35C0", VA = "0x181BF4FC0")]
	public static bool PGDNGHJKGGD<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x215F7C0", Offset = "0x215DDC0", VA = "0x18215F7C0")]
	public static bool AIMKNGJGFJG<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG, int JMCLMPHOKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x160EFF0", Offset = "0x160D5F0", VA = "0x18160EFF0")]
	public static PDOIJMIAGIK<T>.MPDCMGCDDPA PFBFKEIKCCB<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return default(PDOIJMIAGIK<T>.MPDCMGCDDPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x160EFF0", Offset = "0x160D5F0", VA = "0x18160EFF0")]
	public static PDOIJMIAGIK<T>.JOIFAEDJEIC GINPLGNKPHE<T>(this ref PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return default(PDOIJMIAGIK<T>.JOIFAEDJEIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F890", Offset = "0x1B6DE90", VA = "0x181B6F890")]
	public static PJBJPKEHBBH<T, PDOIJMIAGIK<T>.MPDCMGCDDPA> PEMMDGPOEDK<T>(this in PDOIJMIAGIK<T> PBJDHAKDMFG)
	{
		return default(PJBJPKEHBBH<T, PDOIJMIAGIK<T>.MPDCMGCDDPA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MOGEMDKJELK<TSourceEnumerator, TSource, TResult> : HNIKJHFAOCK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : HNIKJHFAOCK, LGLPBFGNCDF<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator GLIMMGHNBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GNHHEMIOHNJ<TSource, TResult> NGHGGDBKPGF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x298B7D0", Offset = "0x2989DD0", VA = "0x18298B7D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult PGNBHIOAFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x298BD40", Offset = "0x298A340", VA = "0x18298BD40", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x298BD00", Offset = "0x298A300", VA = "0x18298BD00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x15C3FB0", Offset = "0x15C25B0", VA = "0x1815C3FB0")]
	internal MOGEMDKJELK(in TSourceEnumerator PBJDHAKDMFG, GNHHEMIOHNJ<TSource, TResult> OAFBJNCKOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x298B910", Offset = "0x2989F10", VA = "0x18298B910", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x298BBE0", Offset = "0x298A1E0", VA = "0x18298BBE0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x298B570", Offset = "0x2989B70", VA = "0x18298B570", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NBBHOFENDOF<TSourceEnumerator, TSource, TResult> : HNIKJHFAOCK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : HNIKJHFAOCK, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator GLIMMGHNBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> NGHGGDBKPGF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x24E8FF0", Offset = "0x24E75F0", VA = "0x1824E8FF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult PGNBHIOAFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x24E9520", Offset = "0x24E7B20", VA = "0x1824E9520", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x24E9420", Offset = "0x24E7A20", VA = "0x1824E9420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x15C3FB0", Offset = "0x15C25B0", VA = "0x1815C3FB0")]
	internal NBBHOFENDOF(in TSourceEnumerator PBJDHAKDMFG, Func<TSource, TResult> OAFBJNCKOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x24E9130", Offset = "0x24E7730", VA = "0x1824E9130", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x24E92B0", Offset = "0x24E78B0", VA = "0x1824E92B0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x24E8ED0", Offset = "0x24E74D0", VA = "0x1824E8ED0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CFCGKFLEMGP<T> : LGLPBFGNCDF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MODOIKLHEOJ
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x15FA7B0", Offset = "0x15F8DB0", VA = "0x1815FA7B0")]
	public static BCFFEGHAMLG<T> ALNFIPJHCMC<T>(this T[] PBJDHAKDMFG)
	{
		return default(BCFFEGHAMLG<T>);
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
