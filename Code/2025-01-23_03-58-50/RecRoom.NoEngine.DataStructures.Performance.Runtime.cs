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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x704E1A0", Offset = "0x704C9A0", VA = "0x18704E1A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DKNMGMFOEDG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DD40", Offset = "0x2E5C540", VA = "0x182E5DD40")]
	public static KMIPOEIGPEN<T> DLLFOJLGNFA<T>(this T[] EGGDEECAALI) where T : notnull
	{
		return default(KMIPOEIGPEN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class HALBNNEOOFE<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BKFEAGFNBCE<T> IHHCJAPPENJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4207900", Offset = "0x4206100", VA = "0x184207900", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x42078C0", Offset = "0x42060C0", VA = "0x1842078C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4207700", Offset = "0x4205F00", VA = "0x184207700")]
	public static HALBNNEOOFE<T> DFLBOLBHLFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x406AC40", Offset = "0x4069440", VA = "0x18406AC40")]
	internal HALBNNEOOFE([In] BKFEAGFNBCE<T> CLCEHBDJMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4207830", Offset = "0x4206030", VA = "0x184207830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4207940", Offset = "0x4206140", VA = "0x184207940")]
	public void PHEPMEPOHIN(int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4207870", Offset = "0x4206070", VA = "0x184207870", Slot = "8")]
	public BKFEAGFNBCE<T>.HFANKDNFDBF GetEnumerator()
	{
		return default(BKFEAGFNBCE<T>.HFANKDNFDBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4207980", Offset = "0x4206180", VA = "0x184207980", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4207980", Offset = "0x4206180", VA = "0x184207980", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PGIAPKHAHKN<T, U> : IEnumerable<T>, IEnumerable where U : IIJBDJDBMEF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U PCMIGKPBKCL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x22CBA20", Offset = "0x22CA220", VA = "0x1822CBA20")]
	internal PGIAPKHAHKN([In] U DDLDHCJHPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x47204D0", Offset = "0x471ECD0", VA = "0x1847204D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x47204D0", Offset = "0x471ECD0", VA = "0x1847204D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KJNANNOGBPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F57780", Offset = "0x2F55F80", VA = "0x182F57780")]
	public static PGIAPKHAHKN<T, U> DFLBOLBHLFN<U>([In] U EGGDEECAALI) where U : IIJBDJDBMEF<T>
	{
		return default(PGIAPKHAHKN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct DBCHGPAHFGN<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U PCMIGKPBKCL;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x22CBA20", Offset = "0x22CA220", VA = "0x1822CBA20")]
	internal DBCHGPAHFGN([In] U DDLDHCJHPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47204D0", Offset = "0x471ECD0", VA = "0x1847204D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x47204D0", Offset = "0x471ECD0", VA = "0x1847204D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DCOHIFDOELG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F57780", Offset = "0x2F55F80", VA = "0x182F57780")]
	public static DBCHGPAHFGN<T, U> DFLBOLBHLFN<U>([In] U EGGDEECAALI) where U : IEnumerator<T>
	{
		return default(DBCHGPAHFGN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class OMIEJCAHHDP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x321A180", Offset = "0x3218980", VA = "0x18321A180")]
	public static string JLMOMHONEOA<T>(this IEnumerable<T> EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32055C0", Offset = "0x3203DC0", VA = "0x1832055C0")]
	public static string DEGCINOELGP<T>(this IEnumerable<T> EGGDEECAALI, string DAAAAMDGEJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MAIMENBJBOL
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x312DB30", Offset = "0x312C330", VA = "0x18312DB30")]
	public static bool AOANHLIHFGA<TSourceEnumerator, TSource>(this TSourceEnumerator EGGDEECAALI, [In] TSource DEDDGCENOOL) where TSourceEnumerator : IIJBDJDBMEF<TSource> where TSource : DCNOAHAHPKJ<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x312DCB0", Offset = "0x312C4B0", VA = "0x18312DCB0")]
	public static int HHKLADBPABP<TSourceEnumerator, TSource>(this TSourceEnumerator EGGDEECAALI, [In] TSource INDENPJBLHO) where TSourceEnumerator : IIJBDJDBMEF<TSource> where TSource : DCNOAHAHPKJ<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x312D8C0", Offset = "0x312C0C0", VA = "0x18312D8C0")]
	public static int AJDKOOGIJBM<TSourceEnumerator, TSource>(this TSourceEnumerator EGGDEECAALI, [In] TSource INDENPJBLHO) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IIJBDJDBMEF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T NEPDGMBEJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BFLJNIONMBF<T> : IIJBDJDBMEF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct LDODJIMKHGF<T, U> : IEnumerable<T>, IEnumerable where U : BFLJNIONMBF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U PCMIGKPBKCL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4221850", Offset = "0x4220050", VA = "0x184221850")]
	internal LDODJIMKHGF([In] U DDLDHCJHPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BD20", Offset = "0x3D8A520", VA = "0x183D8BD20", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4720440", Offset = "0x471EC40", VA = "0x184720440", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4720440", Offset = "0x471EC40", VA = "0x184720440", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ENPOBFJLMLB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2F57720", Offset = "0x2F55F20", VA = "0x182F57720")]
	public static LDODJIMKHGF<T, U> DFLBOLBHLFN<U>([In] U EGGDEECAALI) where U : BFLJNIONMBF<T>
	{
		return default(LDODJIMKHGF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct KMIPOEIGPEN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FPAPLNCJCAH : IIJBDJDBMEF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] JMHJLJJFIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int BLOCPDDJGHD;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4080B20", Offset = "0x407F320", VA = "0x184080B20", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4080500", Offset = "0x407ED00", VA = "0x184080500", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x40807D0", Offset = "0x407EFD0", VA = "0x1840807D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9961A0", Offset = "0x9949A0", VA = "0x1809961A0")]
		private FPAPLNCJCAH(T[] EGGDEECAALI, int ECDOOAABOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF920", Offset = "0x3CEE120", VA = "0x183CEF920")]
		public static FPAPLNCJCAH DFLBOLBHLFN(T[] EGGDEECAALI)
		{
			return default(FPAPLNCJCAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x231EF50", Offset = "0x231D750", VA = "0x18231EF50", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x231EF80", Offset = "0x231D780", VA = "0x18231EF80", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] PJFNPFOAMAM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x466DC20", Offset = "0x466C420", VA = "0x18466DC20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2E98350", Offset = "0x2E96B50", VA = "0x182E98350")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	internal KMIPOEIGPEN(T[] GHAIAFELBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x466DD80", Offset = "0x466C580", VA = "0x18466DD80")]
	public static KMIPOEIGPEN<T> PNJBLIJBOPG()
	{
		return default(KMIPOEIGPEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
	public IEnumerable<T> NNFDOGHDOFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x466DCE0", Offset = "0x466C4E0", VA = "0x18466DCE0")]
	public ReadOnlySpan<T> NCJIGEOAHGP()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x466DA70", Offset = "0x466C270", VA = "0x18466DA70")]
	public PGIAPKHAHKN<T, KMIPOEIGPEN<T>.FPAPLNCJCAH> AHDOFKOPOFD()
	{
		return default(PGIAPKHAHKN<T, FPAPLNCJCAH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x466DC40", Offset = "0x466C440", VA = "0x18466DC40")]
	public FPAPLNCJCAH MDPJHBEGDAH()
	{
		return default(FPAPLNCJCAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x466DBA0", Offset = "0x466C3A0", VA = "0x18466DBA0")]
	public IEnumerator<T> IGEPHCDGPEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x466DE50", Offset = "0x466C650", VA = "0x18466DE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EGJHLHHHGBB
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2976640", Offset = "0x2974E40", VA = "0x182976640")]
	public static KMIPOEIGPEN<T> PIDKMCBCHKM<T>(params T[] GHAIAFELBIF) where T : notnull
	{
		return default(KMIPOEIGPEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x704E140", Offset = "0x704C940", VA = "0x18704E140")]
	public static Stream GGPPHFJGCLI(this KMIPOEIGPEN<byte> EGGDEECAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(BKFEAGFNBCE<>.EHEEBNGPKII))]
public struct BKFEAGFNBCE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct HFANKDNFDBF : BFLJNIONMBF<T>, IIJBDJDBMEF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] EAJMIIBEAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int OCHCHFOJMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int BLOCPDDJGHD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x421F220", Offset = "0x421DA20", VA = "0x18421F220", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T HJAEGMACPBN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x421E830", Offset = "0x421D030", VA = "0x18421E830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T FMGOLCJMGEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x421E960", Offset = "0x421D160", VA = "0x18421E960", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x421EB40", Offset = "0x421D340", VA = "0x18421EB40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x421EDB0", Offset = "0x421D5B0", VA = "0x18421EDB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x421F180", Offset = "0x421D980", VA = "0x18421F180")]
		internal HFANKDNFDBF(T[] HEMCJGBMGKH, int NELOIEKKMHO, int ECDOOAABOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x421E750", Offset = "0x421CF50", VA = "0x18421E750")]
		public static HFANKDNFDBF DFLBOLBHLFN(BKFEAGFNBCE<T> EGGDEECAALI)
		{
			return default(HFANKDNFDBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D48320", Offset = "0x3D46B20", VA = "0x183D48320", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6AA0", Offset = "0x3CC52A0", VA = "0x183CC6AA0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct NFEEHODEOCA : IIJBDJDBMEF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HFANKDNFDBF PCMIGKPBKCL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4A448A0", Offset = "0x4A430A0", VA = "0x184A448A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4A444E0", Offset = "0x4A42CE0", VA = "0x184A444E0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4A44750", Offset = "0x4A42F50", VA = "0x184A44750", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x22CBA20", Offset = "0x22CA220", VA = "0x1822CBA20")]
		private NFEEHODEOCA([In] HFANKDNFDBF DDLDHCJHPPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4A442F0", Offset = "0x4A42AF0", VA = "0x184A442F0")]
		public static NFEEHODEOCA DFLBOLBHLFN([In] BKFEAGFNBCE<T> EGGDEECAALI)
		{
			return default(NFEEHODEOCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4A443E0", Offset = "0x4A42BE0", VA = "0x184A443E0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4A44420", Offset = "0x4A42C20", VA = "0x184A44420", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4A443A0", Offset = "0x4A42BA0", VA = "0x184A443A0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class EHEEBNGPKII
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] EAJMIIBEAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int OCHCHFOJMBO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x53BF540", Offset = "0x53BDD40", VA = "0x1853BF540")]
	public static BKFEAGFNBCE<T> DFLBOLBHLFN()
	{
		return default(BKFEAGFNBCE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x53BF5F0", Offset = "0x53BDDF0", VA = "0x1853BF5F0")]
	public static BKFEAGFNBCE<T> FFPNBOAEDBI(int DEOEMPAJCCC)
	{
		return default(BKFEAGFNBCE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9961A0", Offset = "0x9949A0", VA = "0x1809961A0")]
	internal BKFEAGFNBCE(T[] HEMCJGBMGKH, int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x53BF6B0", Offset = "0x53BDEB0", VA = "0x1853BF6B0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DDMBNMCDJLN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int JNPNLNBHGBJ<TCtx, T>([In] TCtx IEOHBKBLMAA, T GJAJAHIEACP, T MCEIDNFODED);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E97510", Offset = "0x2E95D10", VA = "0x182E97510")]
	public static void ANFLKJPBFFP<T>(this BKFEAGFNBCE<T> EGGDEECAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E987E0", Offset = "0x2E96FE0", VA = "0x182E987E0")]
	public static string ENDPMDANHMB<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870")]
	public static T[] MIPPDEAHBPA<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x231F580", Offset = "0x231DD80", VA = "0x18231F580")]
	public static T EFGCOGNKKLM<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI, int KKPBEBNOEKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x231F580", Offset = "0x231DD80", VA = "0x18231F580")]
	public static T LJCCBPCEAAB<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int KKPBEBNOEKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E973E0", Offset = "0x2E95BE0", VA = "0x182E973E0")]
	public static T AGJEIIAEIIG<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI, int KKPBEBNOEKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E97CA0", Offset = "0x2E964A0", VA = "0x182E97CA0")]
	public static void KLHHFEENEBM<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int KKPBEBNOEKN, [In] T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E97CA0", Offset = "0x2E964A0", VA = "0x182E97CA0")]
	public static void DHOAOMGJONP<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int KKPBEBNOEKN, T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x23206E0", Offset = "0x231EEE0", VA = "0x1823206E0")]
	public static int CMIIIOEDNBH<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0130", Offset = "0x2E9E930", VA = "0x182EA0130")]
	public static ReadOnlySpan<T> NCJIGEOAHGP<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E97AC0", Offset = "0x2E962C0", VA = "0x182E97AC0")]
	public static T[] DFEGGNEMEJJ<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2EA00F0", Offset = "0x2E9E8F0", VA = "0x182EA00F0")]
	public static T MELPKPJFICC<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C5E0", Offset = "0x2E9ADE0", VA = "0x182E9C5E0")]
	public static T[] ENGECDIKJEI<T>(this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2E97590", Offset = "0x2E95D90", VA = "0x182E97590")]
	public static KMIPOEIGPEN<T> BOECMDLAGJI<T>(this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return default(KMIPOEIGPEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D470", Offset = "0x2E9BC70", VA = "0x182E9D470")]
	public static void JGCMIIMCCFC<T>(this BKFEAGFNBCE<T> EGGDEECAALI, [In] T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CF00", Offset = "0x2E9B700", VA = "0x182E9CF00")]
	public static void GOFBPIENEOH<T>(this BKFEAGFNBCE<T> EGGDEECAALI, T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA02F0", Offset = "0x2E9EAF0", VA = "0x182EA02F0")]
	public static void PEGGGLMFMFF<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int ECDOOAABOPD, [In] T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D9C0", Offset = "0x2E9C1C0", VA = "0x182E9D9C0")]
	public static void JLOKKABMJHA<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int ECDOOAABOPD, [In] BKFEAGFNBCE<T> MCAFGDLBCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C690", Offset = "0x2E9AE90", VA = "0x182E9C690")]
	public static void FOOCBICACLP<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int ECDOOAABOPD, T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2E98310", Offset = "0x2E96B10", VA = "0x182E98310")]
	public static void DOCBBKKFCAB<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E9DA80", Offset = "0x2E9C280", VA = "0x182E9DA80")]
	public static T KIJMFDKCPHJ<T>(this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0460", Offset = "0x2E9EC60", VA = "0x182EA0460")]
	public static void PHEPMEPOHIN<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E9E2D0", Offset = "0x2E9CAD0", VA = "0x182E9E2D0")]
	private static void LKGKOOKCGDF<T>(this BKFEAGFNBCE<T> EGGDEECAALI, int DEOEMPAJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2E97870", Offset = "0x2E96070", VA = "0x182E97870")]
	public static void CPGLBCDJJEJ<T>(this BKFEAGFNBCE<T> EGGDEECAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D1A0", Offset = "0x2E9B9A0", VA = "0x182E9D1A0")]
	public static BKFEAGFNBCE<T> IGANKIJEKEL<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI, NHGJECAGIPO<T, T> GNDPINHFAAG)
	{
		return default(BKFEAGFNBCE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E97660", Offset = "0x2E95E60", VA = "0x182E97660")]
	public static bool CGFLGFPAOEK<T>(this BKFEAGFNBCE<T> EGGDEECAALI, T INDENPJBLHO) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D0D0", Offset = "0x2E9B8D0", VA = "0x182E9D0D0")]
	public static bool ICMMHOLDFJO<T>(this BKFEAGFNBCE<T> EGGDEECAALI, [In] T INDENPJBLHO) where T : DCNOAHAHPKJ<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E9E040", Offset = "0x2E9C840", VA = "0x182E9E040")]
	public static bool LJDEGIELPAP<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E9DFA0", Offset = "0x2E9C7A0", VA = "0x182E9DFA0")]
	public static bool LBMPMAGDJNF<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI, int KKPBEBNOEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA00A0", Offset = "0x2E9E8A0", VA = "0x182EA00A0")]
	public static void MDCEOIOALBG<T, TCtx>(this BKFEAGFNBCE<T> EGGDEECAALI, [In] TCtx IEOHBKBLMAA, JNPNLNBHGBJ<TCtx, T> CLPMCACHEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2E9DEA0", Offset = "0x2E9C6A0", VA = "0x182E9DEA0")]
	private static void KPKOIPHEGAB<T, TCtx>(BKFEAGFNBCE<T> EGGDEECAALI, [In] TCtx IEOHBKBLMAA, JNPNLNBHGBJ<TCtx, T> CLPMCACHEEC, int IKOMCGCGHII, int KCEGIOMKHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C7F0", Offset = "0x2E9AFF0", VA = "0x182E9C7F0")]
	private static int GAPAMCJOCGJ<T, TCtx>(BKFEAGFNBCE<T> EGGDEECAALI, [In] TCtx IEOHBKBLMAA, JNPNLNBHGBJ<TCtx, T> CLPMCACHEEC, int IKOMCGCGHII, int KCEGIOMKHAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE46F0", Offset = "0x2DE2EF0", VA = "0x182DE46F0")]
	public static BKFEAGFNBCE<T>.NFEEHODEOCA IGEPHCDGPEC<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return default(BKFEAGFNBCE<T>.NFEEHODEOCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2DE46F0", Offset = "0x2DE2EF0", VA = "0x182DE46F0")]
	public static BKFEAGFNBCE<T>.HFANKDNFDBF LGNHJMPJPCO<T>(this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return default(BKFEAGFNBCE<T>.HFANKDNFDBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E6E0", Offset = "0x2E5CEE0", VA = "0x182E5E6E0")]
	public static PGIAPKHAHKN<T, BKFEAGFNBCE<T>.NFEEHODEOCA> MDPIHAOHLCO<T>([In] this BKFEAGFNBCE<T> EGGDEECAALI)
	{
		return default(PGIAPKHAHKN<T, BKFEAGFNBCE<T>.NFEEHODEOCA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class EEHIEOIDMHK
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2ECCDD0", Offset = "0x2ECB5D0", VA = "0x182ECCDD0")]
	public static T[] CLAEFJCJENE<T>(int BOOADEANLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	public static void AIAGMOGLJDA<T>(T[] GHAIAFELBIF)
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
