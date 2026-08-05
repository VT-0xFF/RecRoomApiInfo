using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD9A0", Offset = "0x6FFBFA0", VA = "0x186FFD9A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BGNINECLFOG<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T PLBILPKBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class GAGECFMGMPK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1A0F080", Offset = "0x1A0D680", VA = "0x181A0F080")]
	public static string NGCDLMDPBHA<T>(this IEnumerable<T> CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1A02D20", Offset = "0x1A01320", VA = "0x181A02D20")]
	public static string MIHLDDFAALA<T>(this IEnumerable<T> CDBMADFDGCE, string CNALHDMMHJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PNCHNEMMAFJ<T, U> : IEnumerable<T>, IEnumerable where U : DAFFFBNNMBB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U HBNIOPEOCDK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x22BE400", Offset = "0x22BCA00", VA = "0x1822BE400")]
	internal PNCHNEMMAFJ(in U GCEOFBACMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D43510", Offset = "0x1D41B10", VA = "0x181D43510", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22BE370", Offset = "0x22BC970", VA = "0x1822BE370", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22BE370", Offset = "0x22BC970", VA = "0x1822BE370", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OFHDPPBFHEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2597040", Offset = "0x2595640", VA = "0x182597040")]
	public static PNCHNEMMAFJ<T, U> OGNDBCBGIDA<U>(in U CDBMADFDGCE) where U : DAFFFBNNMBB<T>
	{
		return default(PNCHNEMMAFJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PKLHAJANPKH
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2309830", Offset = "0x2307E30", VA = "0x182309830")]
	public static bool HLHCGGDOJOL<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator CDBMADFDGCE, in TArgs CHPIMGNELOI, in MBKONNCJCHM<TArgs, TSource, bool> OIILKNGKCEE) where TSourceEnumerator : BGNINECLFOG<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2309AE0", Offset = "0x23080E0", VA = "0x182309AE0")]
	public static int PCAKBAAEEIM<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator CDBMADFDGCE, in TArgs CHPIMGNELOI, MBKONNCJCHM<TArgs, TSource, bool> OIILKNGKCEE) where TSourceEnumerator : BGNINECLFOG<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x23094E0", Offset = "0x2307AE0", VA = "0x1823094E0")]
	public static bool FJDIEHCLELN<TSourceEnumerator, TSource>(this TSourceEnumerator CDBMADFDGCE, in TSource MDCAOIKFJBP) where TSourceEnumerator : BGNINECLFOG<TSource> where TSource : BIMCIIHFHMF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2308FA0", Offset = "0x23075A0", VA = "0x182308FA0")]
	public static int EBCGJECBNIL<TSourceEnumerator, TSource>(this TSourceEnumerator CDBMADFDGCE, in TSource MOLEJFDINLH) where TSourceEnumerator : BGNINECLFOG<TSource> where TSource : BIMCIIHFHMF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2308F10", Offset = "0x2307510", VA = "0x182308F10")]
	public static JFEECOHGFII<TSourceEnumerator, TSource, TResult> CEIIEKCOOLL<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator CDBMADFDGCE, GPNEDPFOBOH<TSource, TResult> OHJHOGOEIKD) where TSourceEnumerator : AALDFIAOENI, BGNINECLFOG<TSource>
	{
		return default(JFEECOHGFII<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2308F10", Offset = "0x2307510", VA = "0x182308F10")]
	public static BIDAGNAPLBM<TSourceEnumerator, TSource, TResult> DBCNBALLJEH<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator CDBMADFDGCE, Func<TSource, TResult> OHJHOGOEIKD) where TSourceEnumerator : AALDFIAOENI, IEnumerator<TSource>
	{
		return default(BIDAGNAPLBM<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EIPPJGMMJDH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x24684B0", Offset = "0x2466AB0", VA = "0x1824684B0")]
	public static bool FPDKMADBOBP<TSourceEnumerator>(TSourceEnumerator CDBMADFDGCE) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2467FF0", Offset = "0x24665F0", VA = "0x182467FF0")]
	public static T DIGOMNJPHLH<TSourceEnumerator>(TSourceEnumerator CDBMADFDGCE) where TSourceEnumerator : BGNINECLFOG<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x246FEA0", Offset = "0x246E4A0", VA = "0x18246FEA0")]
	public static T[] MBKPFENACJC<TSourceEnumerator>(TSourceEnumerator CDBMADFDGCE) where TSourceEnumerator : AALDFIAOENI, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2468270", Offset = "0x2466870", VA = "0x182468270")]
	public static T EDMDJJPKNNA<TSourceEnumerator>(TSourceEnumerator CDBMADFDGCE) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BOIJPGJCCML<T, U> : IEnumerable<T>, IEnumerable where U : BGNINECLFOG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U HBNIOPEOCDK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B660", Offset = "0x1E69C60", VA = "0x181E6B660")]
	internal BOIJPGJCCML(in U GCEOFBACMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B5E0", Offset = "0x1E69BE0", VA = "0x181E6B5E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E6B5E0", Offset = "0x1E69BE0", VA = "0x181E6B5E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NONFMMIKKJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2596C60", Offset = "0x2595260", VA = "0x182596C60")]
	public static BOIJPGJCCML<T, U> OGNDBCBGIDA<U>(in U CDBMADFDGCE) where U : BGNINECLFOG<T>
	{
		return default(BOIJPGJCCML<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct IGDHAFFDNCH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AAIEKIPCPDD : AALDFIAOENI, BGNINECLFOG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] KCEOGOBKDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int LOBFCLLFOGP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int AEJJJIDCFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x179AB70", Offset = "0x1799170", VA = "0x18179AB70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2C501D0", Offset = "0x2C4E7D0", VA = "0x182C501D0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2C4FC10", Offset = "0x2C4E210", VA = "0x182C4FC10", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2C50080", Offset = "0x2C4E680", VA = "0x182C50080", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xBED3F0", Offset = "0xBEB9F0", VA = "0x180BED3F0")]
		private AAIEKIPCPDD(T[] CDBMADFDGCE, int OLGOBCPPPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FB00", Offset = "0x2C4E100", VA = "0x182C4FB00")]
		public static AAIEKIPCPDD OGNDBCBGIDA(T[] CDBMADFDGCE)
		{
			return default(AAIEKIPCPDD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FAD0", Offset = "0x2C4E0D0", VA = "0x182C4FAD0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2C064B0", Offset = "0x2C04AB0", VA = "0x182C064B0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly T[] FHFDNILHCJD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x179AB70", Offset = "0x1799170", VA = "0x18179AB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x179ACD0", Offset = "0x17992D0", VA = "0x18179ACD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF0", Offset = "0x9C05F0", VA = "0x1809C1FF0")]
	internal IGDHAFFDNCH(T[] IACDCADJJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x179AEB0", Offset = "0x17994B0", VA = "0x18179AEB0")]
	public static IGDHAFFDNCH<T> OPDGLPPADOA()
	{
		return default(IGDHAFFDNCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
	public IEnumerable<T> ILPCFMACGJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x179AD90", Offset = "0x1799390", VA = "0x18179AD90")]
	public ReadOnlySpan<T> KAMBPAPCODI()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x179AF60", Offset = "0x1799560", VA = "0x18179AF60")]
	public BOIJPGJCCML<T, IGDHAFFDNCH<T>.AAIEKIPCPDD> PBKMJJDNDMP()
	{
		return default(BOIJPGJCCML<T, AAIEKIPCPDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x179AE20", Offset = "0x1799420", VA = "0x18179AE20")]
	public AAIEKIPCPDD NFMOJFKDLBB()
	{
		return default(AAIEKIPCPDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x179AB90", Offset = "0x1799190", VA = "0x18179AB90")]
	public IEnumerator<T> FGHGHABHEPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x179B080", Offset = "0x1799680", VA = "0x18179B080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BDLFCEFAMKF
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x19F4EC0", Offset = "0x19F34C0", VA = "0x1819F4EC0")]
	public static IGDHAFFDNCH<T> DIOJELLCEHC<T>(params T[] IACDCADJJAN) where T : notnull
	{
		return default(IGDHAFFDNCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FFD940", Offset = "0x6FFBF40", VA = "0x186FFD940")]
	public static Stream GECKHAGGHGF(this IGDHAFFDNCH<byte> CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AALDFIAOENI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DMBFAPIDLDO<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U HBNIOPEOCDK;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x226E9A0", Offset = "0x226CFA0", VA = "0x18226E9A0")]
	internal DMBFAPIDLDO(in U GCEOFBACMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x226E5E0", Offset = "0x226CBE0", VA = "0x18226E5E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x226E5E0", Offset = "0x226CBE0", VA = "0x18226E5E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DNBGMOLAKAK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x24657E0", Offset = "0x2463DE0", VA = "0x1824657E0")]
	public static DMBFAPIDLDO<T, U> OGNDBCBGIDA<U>(in U CDBMADFDGCE) where U : IEnumerator<T>
	{
		return default(DMBFAPIDLDO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class JLGGHIILFMA<T> : IDisposable, AALDFIAOENI, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private JNDIPEAOJAL<T> PPHLNLFEKDF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2CFAF60", Offset = "0x2CF9560", VA = "0x182CFAF60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2CFAFA0", Offset = "0x2CF95A0", VA = "0x182CFAFA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB120", Offset = "0x2CF9720", VA = "0x182CFB120")]
	public static JLGGHIILFMA<T> OGNDBCBGIDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB000", Offset = "0x2CF9600", VA = "0x182CFB000")]
	public static JLGGHIILFMA<T> JPGBKILGGIL(int LEFNHMBHKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB2C0", Offset = "0x2CF98C0", VA = "0x182CFB2C0")]
	internal JLGGHIILFMA(in JNDIPEAOJAL<T> PMIAAPCBGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2CFAF40", Offset = "0x2CF9540", VA = "0x182CFAF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB230", Offset = "0x2CF9830", VA = "0x182CFB230")]
	public void PDDBDHJNBOH(in T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2CFAF80", Offset = "0x2CF9580", VA = "0x182CFAF80")]
	public void GBHFNJDCGGK(int FJLPCOJGEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CFAFC0", Offset = "0x2CF95C0", VA = "0x182CFAFC0", Slot = "8")]
	public JNDIPEAOJAL<T>.CNCMHAOMHGH GetEnumerator()
	{
		return default(JNDIPEAOJAL<T>.CNCMHAOMHGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB250", Offset = "0x2CF9850", VA = "0x182CFB250", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB250", Offset = "0x2CF9850", VA = "0x182CFB250", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(JNDIPEAOJAL<>.HGBCGEFMAPC))]
public struct JNDIPEAOJAL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct CNCMHAOMHGH : AALDFIAOENI, DAFFFBNNMBB<T>, BGNINECLFOG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] MABPKHJLMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int OIPDGPDBJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int LOBFCLLFOGP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int AEJJJIDCFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x18BCEF0", Offset = "0x18BB4F0", VA = "0x1818BCEF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3466220", Offset = "0x3464820", VA = "0x183466220", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T AOIEFMBAJBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3464FA0", Offset = "0x34635A0", VA = "0x183464FA0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3465390", Offset = "0x3463990", VA = "0x183465390", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3465D70", Offset = "0x3464370", VA = "0x183465D70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x24D6070", Offset = "0x24D4670", VA = "0x1824D6070")]
		internal CNCMHAOMHGH(T[] PBLKKAHMFFL, int FJLPCOJGEJP, int OLGOBCPPPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x34651E0", Offset = "0x34637E0", VA = "0x1834651E0")]
		public static CNCMHAOMHGH OGNDBCBGIDA(ref JNDIPEAOJAL<T> CDBMADFDGCE)
		{
			return default(CNCMHAOMHGH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2788680", Offset = "0x2786C80", VA = "0x182788680", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1E69160", Offset = "0x1E67760", VA = "0x181E69160", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct OEPBCLBGCFG : AALDFIAOENI, BGNINECLFOG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CNCMHAOMHGH HBNIOPEOCDK;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int AEJJJIDCFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2F289C0", Offset = "0x2F26FC0", VA = "0x182F289C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2F29C10", Offset = "0x2F28210", VA = "0x182F29C10", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2F28F60", Offset = "0x2F27560", VA = "0x182F28F60", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2F295F0", Offset = "0x2F27BF0", VA = "0x182F295F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1E6B660", Offset = "0x1E69C60", VA = "0x181E6B660")]
		private OEPBCLBGCFG(in CNCMHAOMHGH GCEOFBACMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2F28A30", Offset = "0x2F27030", VA = "0x182F28A30")]
		public static OEPBCLBGCFG OGNDBCBGIDA(in JNDIPEAOJAL<T> CDBMADFDGCE)
		{
			return default(OEPBCLBGCFG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2F289F0", Offset = "0x2F26FF0", VA = "0x182F289F0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2F28AF0", Offset = "0x2F270F0", VA = "0x182F28AF0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2F28980", Offset = "0x2F26F80", VA = "0x182F28980", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class HGBCGEFMAPC
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] MABPKHJLMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int OIPDGPDBJLK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D102C0", Offset = "0x2D0E8C0", VA = "0x182D102C0")]
	public static JNDIPEAOJAL<T> OGNDBCBGIDA()
	{
		return default(JNDIPEAOJAL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D101E0", Offset = "0x2D0E7E0", VA = "0x182D101E0")]
	public static JNDIPEAOJAL<T> JPGBKILGGIL(int LEFNHMBHKEC)
	{
		return default(JNDIPEAOJAL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xBED3F0", Offset = "0xBEB9F0", VA = "0x180BED3F0")]
	internal JNDIPEAOJAL(T[] PBLKKAHMFFL, int FJLPCOJGEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A7B0", Offset = "0x1F08DB0", VA = "0x181F0A7B0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class LIMODLFENBB
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2342060", Offset = "0x2340660", VA = "0x182342060")]
	public static void AFFJDJOCMDN<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2344070", Offset = "0x2342670", VA = "0x182344070")]
	public static string IFGKGLMHAGL<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
	public static T[] EBOPELDAFLE<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x23420D0", Offset = "0x23406D0", VA = "0x1823420D0")]
	public static T MBNHJLNEIKL<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE, int GPAKLECDLDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23420D0", Offset = "0x23406D0", VA = "0x1823420D0")]
	public static T BJALLOEIMBB<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, int GPAKLECDLDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2343F40", Offset = "0x2342540", VA = "0x182343F40")]
	public static T IBJMDFAPNIG<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE, int GPAKLECDLDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23426F0", Offset = "0x2340CF0", VA = "0x1823426F0")]
	public static void FGMAFKALEHD<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, int GPAKLECDLDD, in T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2345A90", Offset = "0x2344090", VA = "0x182345A90")]
	public static void INJFFLIFMPP<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, int GPAKLECDLDD, T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x18BCEF0", Offset = "0x18BB4F0", VA = "0x1818BCEF0")]
	public static int PAGNLNABBPO<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2345CB0", Offset = "0x23442B0", VA = "0x182345CB0")]
	public static ReadOnlySpan<T> KAMBPAPCODI<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x234B580", Offset = "0x2349B80", VA = "0x18234B580")]
	public static void PDDBDHJNBOH<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, in T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2342360", Offset = "0x2340960", VA = "0x182342360")]
	public static void EOEKDCMIPPI<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, int OLGOBCPPPBB, in T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2343EF0", Offset = "0x23424F0", VA = "0x182343EF0")]
	public static void HFOGEGPFAHB<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2349810", Offset = "0x2347E10", VA = "0x182349810")]
	public static T KHLLOCMALCA<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2342C10", Offset = "0x2341210", VA = "0x182342C10")]
	public static void GBHFNJDCGGK<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, int FJLPCOJGEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2349A80", Offset = "0x2348080", VA = "0x182349A80")]
	private static void LOKGJOEGFAD<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x23425D0", Offset = "0x2340BD0", VA = "0x1823425D0")]
	public static void FBJOPIHCMHF<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x23422D0", Offset = "0x23408D0", VA = "0x1823422D0")]
	public static bool ELDGHLLGMJJ<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE, in T MOLEJFDINLH) where T : BIMCIIHFHMF<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2343F30", Offset = "0x2342530", VA = "0x182343F30")]
	public static bool HJJCFGPENBE<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2349890", Offset = "0x2347E90", VA = "0x182349890")]
	public static bool KMPDAIINOMK<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE, int GPAKLECDLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xF42D50", Offset = "0xF41350", VA = "0x180F42D50")]
	public static JNDIPEAOJAL<T>.OEPBCLBGCFG FGHGHABHEPH<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return default(JNDIPEAOJAL<T>.OEPBCLBGCFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xF42D50", Offset = "0xF41350", VA = "0x180F42D50")]
	public static JNDIPEAOJAL<T>.CNCMHAOMHGH IKOIINILKBP<T>(this ref JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return default(JNDIPEAOJAL<T>.CNCMHAOMHGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA020", Offset = "0x1FA8620", VA = "0x181FAA020")]
	public static BOIJPGJCCML<T, JNDIPEAOJAL<T>.OEPBCLBGCFG> BFEHJLFLBJG<T>(this in JNDIPEAOJAL<T> CDBMADFDGCE)
	{
		return default(BOIJPGJCCML<T, JNDIPEAOJAL<T>.OEPBCLBGCFG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JFEECOHGFII<TSourceEnumerator, TSource, TResult> : AALDFIAOENI, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : AALDFIAOENI, BGNINECLFOG<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator KCEOGOBKDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GPNEDPFOBOH<TSource, TResult> EFDLNHELCMK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x21A1240", Offset = "0x219F840", VA = "0x1821A1240", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult PLBILPKBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x21A1B90", Offset = "0x21A0190", VA = "0x1821A1B90", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x21A19D0", Offset = "0x219FFD0", VA = "0x1821A19D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D42A00", Offset = "0x1D41000", VA = "0x181D42A00")]
	internal JFEECOHGFII(in TSourceEnumerator CDBMADFDGCE, GPNEDPFOBOH<TSource, TResult> OHJHOGOEIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x21A15F0", Offset = "0x219FBF0", VA = "0x1821A15F0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x21A17A0", Offset = "0x219FDA0", VA = "0x1821A17A0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x21A1050", Offset = "0x219F650", VA = "0x1821A1050", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BIDAGNAPLBM<TSourceEnumerator, TSource, TResult> : AALDFIAOENI, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : AALDFIAOENI, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator KCEOGOBKDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> EFDLNHELCMK;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2520C00", Offset = "0x251F200", VA = "0x182520C00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult PLBILPKBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x21A1D10", Offset = "0x21A0310", VA = "0x1821A1D10", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x21A18D0", Offset = "0x219FED0", VA = "0x1821A18D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D42A00", Offset = "0x1D41000", VA = "0x181D42A00")]
	internal BIDAGNAPLBM(in TSourceEnumerator CDBMADFDGCE, Func<TSource, TResult> OHJHOGOEIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2520CF0", Offset = "0x251F2F0", VA = "0x182520CF0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2520E10", Offset = "0x251F410", VA = "0x182520E10", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2520A90", Offset = "0x251F090", VA = "0x182520A90", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DAFFFBNNMBB<T> : BGNINECLFOG<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EJFKAEIGOBP
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xF42D00", Offset = "0xF41300", VA = "0x180F42D00")]
	public static IGDHAFFDNCH<T> ACLIBENHKLP<T>(this T[] CDBMADFDGCE) where T : notnull
	{
		return default(IGDHAFFDNCH<T>);
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
