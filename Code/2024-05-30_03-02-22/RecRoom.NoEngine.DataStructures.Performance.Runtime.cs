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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x64B4FF0", Offset = "0x64B41F0", VA = "0x1864B4FF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PNPICJDENBA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2776D10", Offset = "0x2775F10", VA = "0x182776D10")]
	public static NHLFPEKPJIF<T> KJJNPEFAIGA<T>(this T[] CJKIBFNGPNM) where T : notnull
	{
		return default(NHLFPEKPJIF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class FEIEICFJJOG<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CEHBIJEANKB<T> KFFKCHCFKNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x39043F0", Offset = "0x39035F0", VA = "0x1839043F0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3904250", Offset = "0x3903450", VA = "0x183904250")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3904280", Offset = "0x3903480", VA = "0x183904280")]
	public static FEIEICFJJOG<T> EPPBEPCPNMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3904490", Offset = "0x3903690", VA = "0x183904490")]
	internal FEIEICFJJOG([In] CEHBIJEANKB<T> FNFDOEGAMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3904230", Offset = "0x3903430", VA = "0x183904230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3904390", Offset = "0x3903590", VA = "0x183904390")]
	public void FMBNBHNDMOD(int BIFLOKBJAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x39043B0", Offset = "0x39035B0", VA = "0x1839043B0", Slot = "8")]
	public CEHBIJEANKB<T>.BOJNBLPCCDB GetEnumerator()
	{
		return default(CEHBIJEANKB<T>.BOJNBLPCCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3904420", Offset = "0x3903620", VA = "0x183904420", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3904420", Offset = "0x3903620", VA = "0x183904420", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct JOMAKAOFOPE<T, U> : IEnumerable<T>, IEnumerable where U : HPLJKIFCBFP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U IHELDFFOFNG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E7B6A0", Offset = "0x1E7A8A0", VA = "0x181E7B6A0")]
	internal JOMAKAOFOPE([In] U NBJLILNDAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A22720", Offset = "0x3A21920", VA = "0x183A22720", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A22720", Offset = "0x3A21920", VA = "0x183A22720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CMFIHDCBCEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x274A7F0", Offset = "0x27499F0", VA = "0x18274A7F0")]
	public static JOMAKAOFOPE<T, U> EPPBEPCPNMI<U>([In] U CJKIBFNGPNM) where U : HPLJKIFCBFP<T>
	{
		return default(JOMAKAOFOPE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HBNJDPADAFK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U IHELDFFOFNG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A22CB0", Offset = "0x3A21EB0", VA = "0x183A22CB0")]
	internal HBNJDPADAFK([In] U NBJLILNDAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3626FC0", Offset = "0x36261C0", VA = "0x183626FC0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A22890", Offset = "0x3A21A90", VA = "0x183A22890", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A22890", Offset = "0x3A21A90", VA = "0x183A22890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OCELAKBADFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x289B4A0", Offset = "0x289A6A0", VA = "0x18289B4A0")]
	public static HBNJDPADAFK<T, U> EPPBEPCPNMI<U>([In] U CJKIBFNGPNM) where U : IEnumerator<T>
	{
		return default(HBNJDPADAFK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class AMMGADJFMPP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDF30", Offset = "0x2FED130", VA = "0x182FEDF30")]
	public static string BIINBDNHJLN<T>(this IEnumerable<T> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2FDB280", Offset = "0x2FDA480", VA = "0x182FDB280")]
	public static string ANEGDHCCEFG<T>(this IEnumerable<T> CJKIBFNGPNM, string POOGHFJHLCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MHKIFMKENOJ
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A2C0", Offset = "0x2A694C0", VA = "0x182A6A2C0")]
	public static bool PFFPDALCFMB<TSourceEnumerator, TSource>(this TSourceEnumerator CJKIBFNGPNM, [In] TSource OIJOJELHKIF) where TSourceEnumerator : HPLJKIFCBFP<TSource> where TSource : FDLFGGGKCNP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A130", Offset = "0x2A69330", VA = "0x182A6A130")]
	public static int MEILLLHKFCK<TSourceEnumerator, TSource>(this TSourceEnumerator CJKIBFNGPNM, [In] TSource HLCKBKFCMPI) where TSourceEnumerator : HPLJKIFCBFP<TSource> where TSource : FDLFGGGKCNP<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HPLJKIFCBFP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T NPODDCIDCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HBFFCAAMDBD<T> : HPLJKIFCBFP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct LDEKNBPIILE<T, U> : IEnumerable<T>, IEnumerable where U : HBFFCAAMDBD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U IHELDFFOFNG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A7E0", Offset = "0x3B199E0", VA = "0x183B1A7E0")]
	internal LDEKNBPIILE([In] U NBJLILNDAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3633990", Offset = "0x3632B90", VA = "0x183633990", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D9DE90", Offset = "0x3D9D090", VA = "0x183D9DE90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D9DE90", Offset = "0x3D9D090", VA = "0x183D9DE90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PDLBHLFAAJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x274A7C0", Offset = "0x27499C0", VA = "0x18274A7C0")]
	public static LDEKNBPIILE<T, U> EPPBEPCPNMI<U>([In] U CJKIBFNGPNM) where U : HBFFCAAMDBD<T>
	{
		return default(LDEKNBPIILE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct NHLFPEKPJIF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct NMDBJKPOGLP : HPLJKIFCBFP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] MNJGPAMNECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int NKLGDJMCHOO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x41CBD60", Offset = "0x41CAF60", VA = "0x1841CBD60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x41CB7F0", Offset = "0x41CA9F0", VA = "0x1841CB7F0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x41CBA80", Offset = "0x41CAC80", VA = "0x1841CBA80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x19E1BA0", Offset = "0x19E0DA0", VA = "0x1819E1BA0")]
		private NMDBJKPOGLP(T[] CJKIBFNGPNM, int PMNHOLIPOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x41CB5C0", Offset = "0x41CA7C0", VA = "0x1841CB5C0")]
		public static NMDBJKPOGLP EPPBEPCPNMI(T[] CJKIBFNGPNM)
		{
			return default(NMDBJKPOGLP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1EBA670", Offset = "0x1EB9870", VA = "0x181EBA670", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1EBA6E0", Offset = "0x1EB98E0", VA = "0x181EBA6E0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] BJMEHJHBNEL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BOHPGPGHAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3FC62E0", Offset = "0x3FC54E0", VA = "0x183FC62E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x29BAAA0", Offset = "0x29B9CA0", VA = "0x1829BAAA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	internal NHLFPEKPJIF(T[] HPGKNFECNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x41ABD60", Offset = "0x41AAF60", VA = "0x1841ABD60")]
	public static NHLFPEKPJIF<T> NECMJGIIDLF()
	{
		return default(NHLFPEKPJIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
	public IEnumerable<T> HAJGBBJEGDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41ABAB0", Offset = "0x41AACB0", VA = "0x1841ABAB0")]
	public ReadOnlySpan<T> COCFFDODCDL()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41ABB40", Offset = "0x41AAD40", VA = "0x1841ABB40")]
	public JOMAKAOFOPE<T, NHLFPEKPJIF<T>.NMDBJKPOGLP> DDEJNFDNPHL()
	{
		return default(JOMAKAOFOPE<T, NMDBJKPOGLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41ABC50", Offset = "0x41AAE50", VA = "0x1841ABC50")]
	public NMDBJKPOGLP GOMHEKLKMNF()
	{
		return default(NMDBJKPOGLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x41ABCE0", Offset = "0x41AAEE0", VA = "0x1841ABCE0")]
	public IEnumerator<T> KBKKLBPIAFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41ABE10", Offset = "0x41AB010", VA = "0x1841ABE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MNABKEPHMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27CBA00", Offset = "0x27CAC00", VA = "0x1827CBA00")]
	public static NHLFPEKPJIF<T> GPBIHIEBAAG<T>(params T[] HPGKNFECNHG) where T : notnull
	{
		return default(NHLFPEKPJIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x64B4F90", Offset = "0x64B4190", VA = "0x1864B4F90")]
	public static Stream LKCEDCNOODG(this NHLFPEKPJIF<byte> CJKIBFNGPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(CEHBIJEANKB<>.CMGMLLBIEPE))]
public struct CEHBIJEANKB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct BOJNBLPCCDB : HBFFCAAMDBD<T>, HPLJKIFCBFP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] NFDABHOBKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int JAIJCKLBHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int NKLGDJMCHOO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4BF3DF0", Offset = "0x4BF2FF0", VA = "0x184BF3DF0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T LAPMLJKECPL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4BF35F0", Offset = "0x4BF27F0", VA = "0x184BF35F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4BF3850", Offset = "0x4BF2A50", VA = "0x184BF3850", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4BF39F0", Offset = "0x4BF2BF0", VA = "0x184BF39F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x38F97A0", Offset = "0x38F89A0", VA = "0x1838F97A0")]
		internal BOJNBLPCCDB(T[] GECPOPGBBAH, int BIFLOKBJAPK, int PMNHOLIPOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4BF3540", Offset = "0x4BF2740", VA = "0x184BF3540")]
		public static BOJNBLPCCDB EPPBEPCPNMI(CEHBIJEANKB<T> CJKIBFNGPNM)
		{
			return default(BOJNBLPCCDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x35F5650", Offset = "0x35F4850", VA = "0x1835F5650", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x35F1150", Offset = "0x35F0350", VA = "0x1835F1150", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct OCHGOKIAFCM : HPLJKIFCBFP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BOJNBLPCCDB IHELDFFOFNG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4283750", Offset = "0x4282950", VA = "0x184283750", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4283490", Offset = "0x4282690", VA = "0x184283490", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4283590", Offset = "0x4282790", VA = "0x184283590", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B6A0", Offset = "0x1E7A8A0", VA = "0x181E7B6A0")]
		private OCHGOKIAFCM([In] BOJNBLPCCDB NBJLILNDAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4283290", Offset = "0x4282490", VA = "0x184283290")]
		public static OCHGOKIAFCM EPPBEPCPNMI([In] CEHBIJEANKB<T> CJKIBFNGPNM)
		{
			return default(OCHGOKIAFCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4283340", Offset = "0x4282540", VA = "0x184283340", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4283380", Offset = "0x4282580", VA = "0x184283380", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4283250", Offset = "0x4282450", VA = "0x184283250", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class CMGMLLBIEPE
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] NFDABHOBKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int JAIJCKLBHIJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD600", Offset = "0x4EAC800", VA = "0x184EAD600")]
	public static CEHBIJEANKB<T> EPPBEPCPNMI()
	{
		return default(CEHBIJEANKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD6A0", Offset = "0x4EAC8A0", VA = "0x184EAD6A0")]
	public static CEHBIJEANKB<T> JDLKDIFCMCD(int EFDILNFHNJD)
	{
		return default(CEHBIJEANKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x19E1BA0", Offset = "0x19E0DA0", VA = "0x1819E1BA0")]
	internal CEHBIJEANKB(T[] GECPOPGBBAH, int BIFLOKBJAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD750", Offset = "0x4EAC950", VA = "0x184EAD750", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HFMDAFOOHPP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int ECIEDBFPGLB<TCtx, T>([In] TCtx ILEBKFMPDJP, T GFINPEICFEL, T ENBAOKALGHB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29B8400", Offset = "0x29B7600", VA = "0x1829B8400")]
	public static void HJOADCBEFJH<T>(this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29B5EE0", Offset = "0x29B50E0", VA = "0x1829B5EE0")]
	public static string HEMKLOMKAHG<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
	public static T[] OLOHOPAMJBL<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB100", Offset = "0x1EBA300", VA = "0x181EBB100")]
	public static T JIBGFLOLNJM<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM, int BJOOMLAOBEG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB100", Offset = "0x1EBA300", VA = "0x181EBB100")]
	public static T MJNPGFNGJHD<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, int BJOOMLAOBEG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29BAFE0", Offset = "0x29BA1E0", VA = "0x1829BAFE0")]
	public static T KLNKBOAGAEF<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM, int BJOOMLAOBEG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29B8670", Offset = "0x29B7870", VA = "0x1829B8670")]
	public static void HNJFJKPNHAB<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, int BJOOMLAOBEG, [In] T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29BBB10", Offset = "0x29BAD10", VA = "0x1829BBB10")]
	public static void OEHJIDNKMMP<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, int BJOOMLAOBEG, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1EDFEE0", Offset = "0x1EDF0E0", VA = "0x181EDFEE0")]
	public static int FBOPOPPKFDB<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29B3750", Offset = "0x29B2950", VA = "0x1829B3750")]
	public static ReadOnlySpan<T> COCFFDODCDL<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x29BB830", Offset = "0x29BAA30", VA = "0x1829BB830")]
	public static T[] NBPLMKONJKD<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29B3310", Offset = "0x29B2510", VA = "0x1829B3310")]
	public static T BAPIFEMCNHK<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29B3290", Offset = "0x29B2490", VA = "0x1829B3290")]
	public static T[] AMFDKDKCEAB<T>(this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29BB6D0", Offset = "0x29BA8D0", VA = "0x1829BB6D0")]
	public static NHLFPEKPJIF<T> MCBKEFPFAAF<T>(this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return default(NHLFPEKPJIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29BB3D0", Offset = "0x29BA5D0", VA = "0x1829BB3D0")]
	public static void LGLNKEHGBKE<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, [In] T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29B39B0", Offset = "0x29B2BB0", VA = "0x1829B39B0")]
	public static void ENNBCBOHGLK<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29B8460", Offset = "0x29B7660", VA = "0x1829B8460")]
	public static void HLFHLDCGEJO<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, int PMNHOLIPOMJ, [In] T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x29B34B0", Offset = "0x29B26B0", VA = "0x1829B34B0")]
	public static void BFKMEMCNNLL<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x29B34F0", Offset = "0x29B26F0", VA = "0x1829B34F0")]
	public static T CGJOGMCNNHG<T>(this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29B3D70", Offset = "0x29B2F70", VA = "0x1829B3D70")]
	public static void FMBNBHNDMOD<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, int BIFLOKBJAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29B91C0", Offset = "0x29B83C0", VA = "0x1829B91C0")]
	private static void JBFDHDHPFLB<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, int EFDILNFHNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29B33A0", Offset = "0x29B25A0", VA = "0x1829B33A0")]
	public static void BFDHFEEMFPE<T>(this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29B3550", Offset = "0x29B2750", VA = "0x1829B3550")]
	public static CEHBIJEANKB<T> CIALDCDEGDF<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM, HDHHBPNMKGE<T, T> ANDICNNNBCG)
	{
		return default(CEHBIJEANKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29B3850", Offset = "0x29B2A50", VA = "0x1829B3850")]
	public static bool EKHJJHLGIFH<T>(this CEHBIJEANKB<T> CJKIBFNGPNM, [In] T HLCKBKFCMPI) where T : FDLFGGGKCNP<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x29B8CE0", Offset = "0x29B7EE0", VA = "0x1829B8CE0")]
	public static bool ICKIPDGCPNL<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x29BAB50", Offset = "0x29B9D50", VA = "0x1829BAB50")]
	public static bool JPLFGAHDHHO<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM, int BJOOMLAOBEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x29B3AE0", Offset = "0x29B2CE0", VA = "0x1829B3AE0")]
	public static void FFACDFLKHMB<T, TCtx>(this CEHBIJEANKB<T> CJKIBFNGPNM, [In] TCtx ILEBKFMPDJP, ECIEDBFPGLB<TCtx, T> ALFFLPEDJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x29B31D0", Offset = "0x29B23D0", VA = "0x1829B31D0")]
	private static void AHPMMGCDIJL<T, TCtx>(CEHBIJEANKB<T> CJKIBFNGPNM, [In] TCtx ILEBKFMPDJP, ECIEDBFPGLB<TCtx, T> ALFFLPEDJLJ, int BDCMPLBCLGN, int OEANGHFBIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x29BAB90", Offset = "0x29B9D90", VA = "0x1829BAB90")]
	private static int KDDPNCJBJNE<T, TCtx>(CEHBIJEANKB<T> CJKIBFNGPNM, [In] TCtx ILEBKFMPDJP, ECIEDBFPGLB<TCtx, T> ALFFLPEDJLJ, int BDCMPLBCLGN, int OEANGHFBIIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29B3820", Offset = "0x29B2A20", VA = "0x1829B3820")]
	public static CEHBIJEANKB<T>.OCHGOKIAFCM KBKKLBPIAFK<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return default(CEHBIJEANKB<T>.OCHGOKIAFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29B3820", Offset = "0x29B2A20", VA = "0x1829B3820")]
	public static CEHBIJEANKB<T>.BOJNBLPCCDB EDHJEMFBPBP<T>(this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return default(CEHBIJEANKB<T>.BOJNBLPCCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x29B5B00", Offset = "0x29B4D00", VA = "0x1829B5B00")]
	public static JOMAKAOFOPE<T, CEHBIJEANKB<T>.OCHGOKIAFCM> HEFOJNPOCPL<T>([In] this CEHBIJEANKB<T> CJKIBFNGPNM)
	{
		return default(JOMAKAOFOPE<T, CEHBIJEANKB<T>.OCHGOKIAFCM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class KNPDECNEJKC
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A25B90", Offset = "0x2A24D90", VA = "0x182A25B90")]
	public static T[] PMDCEIJBNLB<T>(int AGHIAPEPFJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	public static void OBGJDANCNFE<T>(T[] HPGKNFECNHG)
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
