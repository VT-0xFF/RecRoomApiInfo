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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70F6520", Offset = "0x70F5920", VA = "0x1870F6520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IOCPOPBGEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0990", Offset = "0x2DDFD90", VA = "0x182DE0990")]
	public static AILDJCCBGLL<T> LMFGKBEKMNP<T>(this T[] MPLBPEBNKFP) where T : notnull
	{
		return default(AILDJCCBGLL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class OIFBLODPIEE<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OGHLOBLCDJI<T> ICFOFAMGABF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B84470", Offset = "0x4B83870", VA = "0x184B84470", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B84430", Offset = "0x4B83830", VA = "0x184B84430")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B844B0", Offset = "0x4B838B0", VA = "0x184B844B0")]
	public static OIFBLODPIEE<T> ODOFIFAGLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x40B2D20", Offset = "0x40B2120", VA = "0x1840B2D20")]
	internal OIFBLODPIEE([In] OGHLOBLCDJI<T> HKNABNLJGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B84390", Offset = "0x4B83790", VA = "0x184B84390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B845F0", Offset = "0x4B839F0", VA = "0x184B845F0")]
	public void PDOANCAJAIF(int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B843D0", Offset = "0x4B837D0", VA = "0x184B843D0", Slot = "8")]
	public OGHLOBLCDJI<T>.GNKKMLILJHJ GetEnumerator()
	{
		return default(OGHLOBLCDJI<T>.GNKKMLILJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B84630", Offset = "0x4B83A30", VA = "0x184B84630", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B84630", Offset = "0x4B83A30", VA = "0x184B84630", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HEEJAAKOMGF<T, U> : IEnumerable<T>, IEnumerable where U : AKDBPGPNABO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U CAHIMBEBGJJ;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x22DF670", Offset = "0x22DEA70", VA = "0x1822DF670")]
	internal HEEJAAKOMGF([In] U LGHHOJKALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CBAC60", Offset = "0x3CBA060", VA = "0x183CBAC60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CBAC60", Offset = "0x3CBA060", VA = "0x183CBAC60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JCIKLLEMJNN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F65830", Offset = "0x2F64C30", VA = "0x182F65830")]
	public static HEEJAAKOMGF<T, U> ODOFIFAGLAJ<U>([In] U MPLBPEBNKFP) where U : AKDBPGPNABO<T>
	{
		return default(HEEJAAKOMGF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct EDADAJJFIOD<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U CAHIMBEBGJJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2509540", Offset = "0x2508940", VA = "0x182509540")]
	internal EDADAJJFIOD([In] U LGHHOJKALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x25097F0", Offset = "0x2508BF0", VA = "0x1825097F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CBAFF0", Offset = "0x3CBA3F0", VA = "0x183CBAFF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CBAFF0", Offset = "0x3CBA3F0", VA = "0x183CBAFF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CLKJJCDOHKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F657A0", Offset = "0x2F64BA0", VA = "0x182F657A0")]
	public static EDADAJJFIOD<T, U> ODOFIFAGLAJ<U>([In] U MPLBPEBNKFP) where U : IEnumerator<T>
	{
		return default(EDADAJJFIOD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IDDACFMKJHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3094BB0", Offset = "0x3093FB0", VA = "0x183094BB0")]
	public static string AMFAMNFBJPE<T>(this IEnumerable<T> MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3098FC0", Offset = "0x30983C0", VA = "0x183098FC0")]
	public static string HADAHGKLGAH<T>(this IEnumerable<T> MPLBPEBNKFP, string EMIOBFGLAJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DCJNMJBNBEO
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E91E80", Offset = "0x2E91280", VA = "0x182E91E80")]
	public static bool DAKIHLNJPCO<TSourceEnumerator, TSource>(this TSourceEnumerator MPLBPEBNKFP, [In] TSource FKIFNEPLBJJ) where TSourceEnumerator : AKDBPGPNABO<TSource> where TSource : GHOFIKLHDEE<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E920C0", Offset = "0x2E914C0", VA = "0x182E920C0")]
	public static int DBOPENJBFBK<TSourceEnumerator, TSource>(this TSourceEnumerator MPLBPEBNKFP, [In] TSource HCPAOILCJCB) where TSourceEnumerator : AKDBPGPNABO<TSource> where TSource : GHOFIKLHDEE<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E92310", Offset = "0x2E91710", VA = "0x182E92310")]
	public static int MOJOMPJENBK<TSourceEnumerator, TSource>(this TSourceEnumerator MPLBPEBNKFP, [In] TSource HCPAOILCJCB) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AKDBPGPNABO<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DLFFLJHEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DPGAPIGOEAN<T> : AKDBPGPNABO<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FMNEKAAELOA<T, U> : IEnumerable<T>, IEnumerable where U : DPGAPIGOEAN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U CAHIMBEBGJJ;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB2B0", Offset = "0x3CBA6B0", VA = "0x183CBB2B0")]
	internal FMNEKAAELOA([In] U LGHHOJKALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CBABE0", Offset = "0x3CB9FE0", VA = "0x183CBABE0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3CBAE00", Offset = "0x3CBA200", VA = "0x183CBAE00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3CBAE00", Offset = "0x3CBA200", VA = "0x183CBAE00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NPFEGCIOEDF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2F65910", Offset = "0x2F64D10", VA = "0x182F65910")]
	public static FMNEKAAELOA<T, U> ODOFIFAGLAJ<U>([In] U MPLBPEBNKFP) where U : DPGAPIGOEAN<T>
	{
		return default(FMNEKAAELOA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct AILDJCCBGLL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FPJLIAGNDHO : AKDBPGPNABO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] AJFJPEPDFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int CBHNADMFCEN;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x40B4E40", Offset = "0x40B4240", VA = "0x1840B4E40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x40B4760", Offset = "0x40B3B60", VA = "0x1840B4760", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x40B4A20", Offset = "0x40B3E20", VA = "0x1840B4A20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AFA10", Offset = "0x9AEE10", VA = "0x1809AFA10")]
		private FPJLIAGNDHO(T[] MPLBPEBNKFP, int IIACLAMOIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40B45F0", Offset = "0x40B39F0", VA = "0x1840B45F0")]
		public static FPJLIAGNDHO ODOFIFAGLAJ(T[] MPLBPEBNKFP)
		{
			return default(FPJLIAGNDHO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x232C0F0", Offset = "0x232B4F0", VA = "0x18232C0F0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x232B3C0", Offset = "0x232A7C0", VA = "0x18232B3C0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] PAKKLMNEEMO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EPMKILCCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41DF000", Offset = "0x41DE400", VA = "0x1841DF000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3135000", Offset = "0x3134400", VA = "0x183135000")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	internal AILDJCCBGLL(T[] CHDCMIMONFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x41DF160", Offset = "0x41DE560", VA = "0x1841DF160")]
	public static AILDJCCBGLL<T> MGEHKGIFIKI()
	{
		return default(AILDJCCBGLL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
	public IEnumerable<T> NDLKEAGAJDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41DF240", Offset = "0x41DE640", VA = "0x1841DF240")]
	public ReadOnlySpan<T> OLKFHIECDOE()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41DF020", Offset = "0x41DE420", VA = "0x1841DF020")]
	public HEEJAAKOMGF<T, AILDJCCBGLL<T>.FPJLIAGNDHO> MFFMMCIIOKJ()
	{
		return default(HEEJAAKOMGF<T, FPJLIAGNDHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x41DEEE0", Offset = "0x41DE2E0", VA = "0x1841DEEE0")]
	public FPJLIAGNDHO FHHLNMOGGFE()
	{
		return default(FPJLIAGNDHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41DEF80", Offset = "0x41DE380", VA = "0x1841DEF80")]
	public IEnumerator<T> JDJKPBEKJIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x41DF2E0", Offset = "0x41DE6E0", VA = "0x1841DF2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JLDFOMPEOIL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC180", Offset = "0x2DDB580", VA = "0x182DDC180")]
	public static AILDJCCBGLL<T> AJLEANBDGMM<T>(params T[] CHDCMIMONFN) where T : notnull
	{
		return default(AILDJCCBGLL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x70F64C0", Offset = "0x70F58C0", VA = "0x1870F64C0")]
	public static Stream BJHDJKNCDJA(this AILDJCCBGLL<byte> MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(OGHLOBLCDJI<>.LKCAEPLEFFK))]
public struct OGHLOBLCDJI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct GNKKMLILJHJ : DPGAPIGOEAN<T>, AKDBPGPNABO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] BCOEHHDHMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int KINMOKMDHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int CBHNADMFCEN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x41AE4B0", Offset = "0x41AD8B0", VA = "0x1841AE4B0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T HNCPBIIBGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x41ADAE0", Offset = "0x41ACEE0", VA = "0x1841ADAE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T KEBJCJGGMEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x41AD950", Offset = "0x41ACD50", VA = "0x1841AD950", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x41ADE20", Offset = "0x41AD220", VA = "0x1841ADE20", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x41AE0B0", Offset = "0x41AD4B0", VA = "0x1841AE0B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x41AE350", Offset = "0x41AD750", VA = "0x1841AE350")]
		internal GNKKMLILJHJ(T[] KNHLIMDEMDB, int ABPDJOGPHFP, int IIACLAMOIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x41ADC90", Offset = "0x41AD090", VA = "0x1841ADC90")]
		public static GNKKMLILJHJ ODOFIFAGLAJ(OGHLOBLCDJI<T> MPLBPEBNKFP)
		{
			return default(GNKKMLILJHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D37720", Offset = "0x3D36B20", VA = "0x183D37720", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3D34A80", Offset = "0x3D33E80", VA = "0x183D34A80", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct EAJFADKHJJA : AKDBPGPNABO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GNKKMLILJHJ CAHIMBEBGJJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3C7ABF0", Offset = "0x3C79FF0", VA = "0x183C7ABF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3C7A8C0", Offset = "0x3C79CC0", VA = "0x183C7A8C0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3C7A9E0", Offset = "0x3C79DE0", VA = "0x183C7A9E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x22DF670", Offset = "0x22DEA70", VA = "0x1822DF670")]
		private EAJFADKHJJA([In] GNKKMLILJHJ LGHHOJKALAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A700", Offset = "0x3C79B00", VA = "0x183C7A700")]
		public static EAJFADKHJJA ODOFIFAGLAJ([In] OGHLOBLCDJI<T> MPLBPEBNKFP)
		{
			return default(EAJFADKHJJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A6C0", Offset = "0x3C79AC0", VA = "0x183C7A6C0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A7B0", Offset = "0x3C79BB0", VA = "0x183C7A7B0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7A680", Offset = "0x3C79A80", VA = "0x183C7A680", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class LKCAEPLEFFK
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] BCOEHHDHMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int KINMOKMDHAE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4B81390", Offset = "0x4B80790", VA = "0x184B81390")]
	public static OGHLOBLCDJI<T> ODOFIFAGLAJ()
	{
		return default(OGHLOBLCDJI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4B812D0", Offset = "0x4B806D0", VA = "0x184B812D0")]
	public static OGHLOBLCDJI<T> KGHMFFJBCLK(int GNOHMAFCFKD)
	{
		return default(OGHLOBLCDJI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9AFA10", Offset = "0x9AEE10", VA = "0x1809AFA10")]
	internal OGHLOBLCDJI(T[] KNHLIMDEMDB, int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B81440", Offset = "0x4B80840", VA = "0x184B81440", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MJAPEOAPNDD
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int PHLKEANOJJB<TCtx, T>([In] TCtx FODBDHHLEGI, T FGFJFGGJOII, T CABLGFIBABJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x31356C0", Offset = "0x3134AC0", VA = "0x1831356C0")]
	public static void DNAOJJGPLEN<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3138C00", Offset = "0x3138000", VA = "0x183138C00")]
	public static string JJHJCCFBMIG<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
	public static T[] DKHIDAAKHHB<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3135000", Offset = "0x3134400", VA = "0x183135000")]
	public static T AFFELPLAAIM<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP, int IBIAGDBMPOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3135000", Offset = "0x3134400", VA = "0x183135000")]
	public static T HEJPNBNFFBD<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int IBIAGDBMPOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3135230", Offset = "0x3134630", VA = "0x183135230")]
	public static T AMAKALKFEBA<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP, int IBIAGDBMPOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x313C710", Offset = "0x313BB10", VA = "0x18313C710")]
	public static void KJLAKIGFJAC<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int IBIAGDBMPOH, [In] T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x313CEC0", Offset = "0x313C2C0", VA = "0x18313CEC0")]
	public static void NICPPNFICJK<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int IBIAGDBMPOH, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x232B450", Offset = "0x232A850", VA = "0x18232B450")]
	public static int OHCLAPOBIHH<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x313D8A0", Offset = "0x313CCA0", VA = "0x18313D8A0")]
	public static ReadOnlySpan<T> OLKFHIECDOE<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3138610", Offset = "0x3137A10", VA = "0x183138610")]
	public static T[] IKCJEAJIJHM<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3135500", Offset = "0x3134900", VA = "0x183135500")]
	public static T BJONCHFFCDN<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3140330", Offset = "0x313F730", VA = "0x183140330")]
	public static T[] PLEGELLDPCK<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3135F40", Offset = "0x3135340", VA = "0x183135F40")]
	public static AILDJCCBGLL<T> ENBLKKLOKLE<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return default(AILDJCCBGLL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3135740", Offset = "0x3134B40", VA = "0x183135740")]
	public static void EBDKDKCDLND<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, [In] T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3138880", Offset = "0x3137C80", VA = "0x183138880")]
	public static void JBDEDMMHBPA<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x31360D0", Offset = "0x31354D0", VA = "0x1831360D0")]
	public static void FOCPHFOBPNF<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int IIACLAMOIEE, [In] T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3136010", Offset = "0x3135410", VA = "0x183136010")]
	public static void EPOBNHADADP<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int IIACLAMOIEE, [In] OGHLOBLCDJI<T> KLODBELJCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3136300", Offset = "0x3135700", VA = "0x183136300")]
	public static void FPENCIMGGLM<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int IIACLAMOIEE, T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x31385D0", Offset = "0x31379D0", VA = "0x1831385D0")]
	public static void IEMNCPPEKKN<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int IIACLAMOIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x31402D0", Offset = "0x313F6D0", VA = "0x1831402D0")]
	public static T PFFEIBIPKED<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x313DAE0", Offset = "0x313CEE0", VA = "0x18313DAE0")]
	public static void PDOANCAJAIF<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31365A0", Offset = "0x31359A0", VA = "0x1831365A0")]
	private static void GLKGHIFLLKL<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, int GNOHMAFCFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3135540", Offset = "0x3134940", VA = "0x183135540")]
	public static void CDMKLDGEKPL<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3135CF0", Offset = "0x31350F0", VA = "0x183135CF0")]
	public static OGHLOBLCDJI<T> EIBGMEMLIIJ<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP, JCNLODCBEPP<T, T> IJNBGFKDKCN)
	{
		return default(OGHLOBLCDJI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3135360", Offset = "0x3134760", VA = "0x183135360")]
	public static bool BDKJEBALGLD<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, T HCPAOILCJCB) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x313CDC0", Offset = "0x313C1C0", VA = "0x18313CDC0")]
	public static bool LAKBINKEPFM<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP, [In] T HCPAOILCJCB) where T : GHOFIKLHDEE<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x302BA80", Offset = "0x302AE80", VA = "0x18302BA80")]
	public static bool BEICAADJBDO<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x313D990", Offset = "0x313CD90", VA = "0x18313D990")]
	public static bool OOACIJHPAKB<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP, int IBIAGDBMPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3138AC0", Offset = "0x3137EC0", VA = "0x183138AC0")]
	public static void JIKEBDELIBK<T, TCtx>(this OGHLOBLCDJI<T> MPLBPEBNKFP, [In] TCtx FODBDHHLEGI, PHLKEANOJJB<TCtx, T> APGLPMLJAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x31384D0", Offset = "0x31378D0", VA = "0x1831384D0")]
	private static void IAFGDJDJEEC<T, TCtx>(OGHLOBLCDJI<T> MPLBPEBNKFP, [In] TCtx FODBDHHLEGI, PHLKEANOJJB<TCtx, T> APGLPMLJAEK, int AJLALNLANDN, int FJCFLBJHALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x313D200", Offset = "0x313C600", VA = "0x18313D200")]
	private static int NNJONGCEKDH<T, TCtx>(OGHLOBLCDJI<T> MPLBPEBNKFP, [In] TCtx FODBDHHLEGI, PHLKEANOJJB<TCtx, T> APGLPMLJAEK, int AJLALNLANDN, int FJCFLBJHALM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x302B7D0", Offset = "0x302ABD0", VA = "0x18302B7D0")]
	public static OGHLOBLCDJI<T>.EAJFADKHJJA JDJKPBEKJIJ<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return default(OGHLOBLCDJI<T>.EAJFADKHJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x302B7D0", Offset = "0x302ABD0", VA = "0x18302B7D0")]
	public static OGHLOBLCDJI<T>.GNKKMLILJHJ JGBCPKDJEAM<T>(this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return default(OGHLOBLCDJI<T>.GNKKMLILJHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x30D85A0", Offset = "0x30D79A0", VA = "0x1830D85A0")]
	public static HEEJAAKOMGF<T, OGHLOBLCDJI<T>.EAJFADKHJJA> BENMHIMJAPM<T>([In] this OGHLOBLCDJI<T> MPLBPEBNKFP)
	{
		return default(HEEJAAKOMGF<T, OGHLOBLCDJI<T>.EAJFADKHJJA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class OLJCJLMHBGA
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3217BC0", Offset = "0x3216FC0", VA = "0x183217BC0")]
	public static T[] JPOCOOIKKGI<T>(int BGDDCGNLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	public static void EPPCPMHELGH<T>(T[] CHDCMIMONFN)
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
