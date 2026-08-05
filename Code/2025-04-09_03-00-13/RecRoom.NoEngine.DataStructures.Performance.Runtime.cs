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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EE9D0", Offset = "0x79EDDD0", VA = "0x1879EE9D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JODBFFJMKNL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x338C560", Offset = "0x338B960", VA = "0x18338C560")]
	public static GHDELNLDBAO<T> ADFLEFPPBOD<T>(this T[] JOCJBPPJMJJ) where T : notnull
	{
		return default(GHDELNLDBAO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class NBEDGLKEHNJ<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AJFCGHOLDCP<T> FOBLOMCENPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x50D2D70", Offset = "0x50D2170", VA = "0x1850D2D70", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x50D2D30", Offset = "0x50D2130", VA = "0x1850D2D30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50D2E80", Offset = "0x50D2280", VA = "0x1850D2E80")]
	public static NBEDGLKEHNJ<T> HBLBJMFGHFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x42FAA10", Offset = "0x42F9E10", VA = "0x1842FAA10")]
	internal NBEDGLKEHNJ([In] AJFCGHOLDCP<T> BGCEKLPNCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50D2DB0", Offset = "0x50D21B0", VA = "0x1850D2DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x50D2DF0", Offset = "0x50D21F0", VA = "0x1850D2DF0")]
	public void FHDKNMLGMGO(int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50D2E30", Offset = "0x50D2230", VA = "0x1850D2E30", Slot = "8")]
	public AJFCGHOLDCP<T>.FMDICCABPEB GetEnumerator()
	{
		return default(AJFCGHOLDCP<T>.FMDICCABPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x50D2FB0", Offset = "0x50D23B0", VA = "0x1850D2FB0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50D2FB0", Offset = "0x50D23B0", VA = "0x1850D2FB0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct FONPLHOCLEB<T, U> : IEnumerable<T>, IEnumerable where U : HFJBCMJHCGM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U MLBBCBCPJFG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x262AC10", Offset = "0x262A010", VA = "0x18262AC10")]
	internal FONPLHOCLEB([In] U CBEBKIBOLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x42DEF10", Offset = "0x42DE310", VA = "0x1842DEF10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x42DEF10", Offset = "0x42DE310", VA = "0x1842DEF10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DDBGLJOHCLM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3AB0", Offset = "0x2CF2EB0", VA = "0x182CF3AB0")]
	public static FONPLHOCLEB<T, U> HBLBJMFGHFK<U>([In] U JOCJBPPJMJJ) where U : HFJBCMJHCGM<T>
	{
		return default(FONPLHOCLEB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct DCFBMJCCGFF<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U MLBBCBCPJFG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x262AC10", Offset = "0x262A010", VA = "0x18262AC10")]
	internal DCFBMJCCGFF([In] U CBEBKIBOLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42DEF10", Offset = "0x42DE310", VA = "0x1842DEF10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42DEF10", Offset = "0x42DE310", VA = "0x1842DEF10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GAGFKNNBEHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3AB0", Offset = "0x2CF2EB0", VA = "0x182CF3AB0")]
	public static DCFBMJCCGFF<T, U> HBLBJMFGHFK<U>([In] U JOCJBPPJMJJ) where U : IEnumerator<T>
	{
		return default(DCFBMJCCGFF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class LHMAGDCFBOC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37062B0", Offset = "0x37056B0", VA = "0x1837062B0")]
	public static string FJDACNOOCGJ<T>(this IEnumerable<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x36F1820", Offset = "0x36F0C20", VA = "0x1836F1820")]
	public static string EGIKGHGCPMK<T>(this IEnumerable<T> JOCJBPPJMJJ, string EKFPLLKMIAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BGCEOKLOEOG
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x338EF20", Offset = "0x338E320", VA = "0x18338EF20")]
	public static bool DBBFHBJKHDM<TSourceEnumerator, TSource>(this TSourceEnumerator JOCJBPPJMJJ, [In] TSource MGCEJOCCONP) where TSourceEnumerator : HFJBCMJHCGM<TSource> where TSource : BDMMFIPCFEO<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x338F0A0", Offset = "0x338E4A0", VA = "0x18338F0A0")]
	public static int LEKGMCLGOGH<TSourceEnumerator, TSource>(this TSourceEnumerator JOCJBPPJMJJ, [In] TSource FFOEEMKIKJO) where TSourceEnumerator : HFJBCMJHCGM<TSource> where TSource : BDMMFIPCFEO<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x338ECB0", Offset = "0x338E0B0", VA = "0x18338ECB0")]
	public static int BPGPBFKEFEH<TSourceEnumerator, TSource>(this TSourceEnumerator JOCJBPPJMJJ, [In] TSource FFOEEMKIKJO) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HFJBCMJHCGM<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T JKNLEFEANEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LLBLOMPCEMD<T> : HFJBCMJHCGM<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct EFGDONFLAEG<T, U> : IEnumerable<T>, IEnumerable where U : LLBLOMPCEMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U MLBBCBCPJFG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42DEFB0", Offset = "0x42DE3B0", VA = "0x1842DEFB0")]
	internal EFGDONFLAEG([In] U CBEBKIBOLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x42DEE60", Offset = "0x42DE260", VA = "0x1842DEE60", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x42DEE80", Offset = "0x42DE280", VA = "0x1842DEE80", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x42DEE80", Offset = "0x42DE280", VA = "0x1842DEE80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AGHPINKGALE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3AE0", Offset = "0x2CF2EE0", VA = "0x182CF3AE0")]
	public static EFGDONFLAEG<T, U> HBLBJMFGHFK<U>([In] U JOCJBPPJMJJ) where U : LLBLOMPCEMD<T>
	{
		return default(EFGDONFLAEG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct GHDELNLDBAO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FFKMPJNIMOI : HFJBCMJHCGM<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] ECMABGDKJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int HEDIIMFFIJC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4726CF0", Offset = "0x47260F0", VA = "0x184726CF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4726590", Offset = "0x4725990", VA = "0x184726590", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x47268E0", Offset = "0x4725CE0", VA = "0x1847268E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB61480", Offset = "0xB60880", VA = "0x180B61480")]
		private FFKMPJNIMOI(T[] JOCJBPPJMJJ, int CJFNAFNJJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4726540", Offset = "0x4725940", VA = "0x184726540")]
		public static FFKMPJNIMOI HBLBJMFGHFK(T[] JOCJBPPJMJJ)
		{
			return default(FFKMPJNIMOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x267CC80", Offset = "0x267C080", VA = "0x18267CC80", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x267CCB0", Offset = "0x267C0B0", VA = "0x18267CCB0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] KBCPHILBNKH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x48587E0", Offset = "0x4857BE0", VA = "0x1848587E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x365D550", Offset = "0x365C950", VA = "0x18365D550")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	internal GHDELNLDBAO(T[] LLPLHOOOAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4858800", Offset = "0x4857C00", VA = "0x184858800")]
	public static GHDELNLDBAO<T> GBADJOAJCAL()
	{
		return default(GHDELNLDBAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0")]
	public IEnumerable<T> KNALCBEAMKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4858740", Offset = "0x4857B40", VA = "0x184858740")]
	public ReadOnlySpan<T> DHLFIIHGBON()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48588D0", Offset = "0x4857CD0", VA = "0x1848588D0")]
	public FONPLHOCLEB<T, GHDELNLDBAO<T>.FFKMPJNIMOI> IPLPMPJGEJF()
	{
		return default(FONPLHOCLEB<T, FFKMPJNIMOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4858A00", Offset = "0x4857E00", VA = "0x184858A00")]
	public FFKMPJNIMOI MDBDIEHIAKK()
	{
		return default(FFKMPJNIMOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x48586C0", Offset = "0x4857AC0", VA = "0x1848586C0")]
	public IEnumerator<T> DBEEDGEHMMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4858AA0", Offset = "0x4857EA0", VA = "0x184858AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EPBKBABIJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x33FE020", Offset = "0x33FD420", VA = "0x1833FE020")]
	public static GHDELNLDBAO<T> MDKOMKKBHPD<T>(params T[] LLPLHOOOAEB) where T : notnull
	{
		return default(GHDELNLDBAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x79EE970", Offset = "0x79EDD70", VA = "0x1879EE970")]
	public static Stream COAMCDODPIF(this GHDELNLDBAO<byte> JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(AJFCGHOLDCP<>.NJHMBPGEJCA))]
public struct AJFCGHOLDCP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FMDICCABPEB : LLBLOMPCEMD<T>, HFJBCMJHCGM<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] EOBCGPODGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int PMDOEIDFEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int HEDIIMFFIJC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x477FB70", Offset = "0x477EF70", VA = "0x18477FB70", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T JEDHFCNJNPN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x477F090", Offset = "0x477E490", VA = "0x18477F090")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T MMHKMGKCJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x477F270", Offset = "0x477E670", VA = "0x18477F270", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x477F5F0", Offset = "0x477E9F0", VA = "0x18477F5F0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x477F8B0", Offset = "0x477ECB0", VA = "0x18477F8B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x477FA90", Offset = "0x477EE90", VA = "0x18477FA90")]
		internal FMDICCABPEB(T[] KKIPPMFKGPH, int ECKHNAPCKGD, int CJFNAFNJJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x477F210", Offset = "0x477E610", VA = "0x18477F210")]
		public static FMDICCABPEB HBLBJMFGHFK(AJFCGHOLDCP<T> JOCJBPPJMJJ)
		{
			return default(FMDICCABPEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4364BC0", Offset = "0x4363FC0", VA = "0x184364BC0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4360880", Offset = "0x435FC80", VA = "0x184360880", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct DPAKAGMDJOD : HFJBCMJHCGM<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FMDICCABPEB MLBBCBCPJFG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x66FE900", Offset = "0x66FDD00", VA = "0x1866FE900", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x66FE5B0", Offset = "0x66FD9B0", VA = "0x1866FE5B0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x66FE7B0", Offset = "0x66FDBB0", VA = "0x1866FE7B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x262AC10", Offset = "0x262A010", VA = "0x18262AC10")]
		private DPAKAGMDJOD([In] FMDICCABPEB CBEBKIBOLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x66FE390", Offset = "0x66FD790", VA = "0x1866FE390")]
		public static DPAKAGMDJOD HBLBJMFGHFK([In] AJFCGHOLDCP<T> JOCJBPPJMJJ)
		{
			return default(DPAKAGMDJOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x66FE440", Offset = "0x66FD840", VA = "0x1866FE440", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x66FE480", Offset = "0x66FD880", VA = "0x1866FE480", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x66FE350", Offset = "0x66FD750", VA = "0x1866FE350", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class NJHMBPGEJCA
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] EOBCGPODGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int PMDOEIDFEPD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48DFCA0", Offset = "0x48DF0A0", VA = "0x1848DFCA0")]
	public static AJFCGHOLDCP<T> HBLBJMFGHFK()
	{
		return default(AJFCGHOLDCP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48DFD50", Offset = "0x48DF150", VA = "0x1848DFD50")]
	public static AJFCGHOLDCP<T> LOHJIFHKNGB(int HDAIOJEADNO)
	{
		return default(AJFCGHOLDCP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xB61480", Offset = "0xB60880", VA = "0x180B61480")]
	internal AJFCGHOLDCP(T[] KKIPPMFKGPH, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48DFE10", Offset = "0x48DF210", VA = "0x1848DFE10", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IHCENGKBBIO
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int CBPJPGAKMNK<TCtx, T>([In] TCtx PDBOIKJNMKA, T BICHNBDCKLH, T CKCKMBIGMMF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3665B00", Offset = "0x3664F00", VA = "0x183665B00")]
	public static void OAHDOECNNKP<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3661D00", Offset = "0x3661100", VA = "0x183661D00")]
	public static string NHCGLAEEAEB<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0")]
	public static T[] OIJFGPGAKPO<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x267E060", Offset = "0x267D460", VA = "0x18267E060")]
	public static T IOLMGDEDCOJ<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x267E060", Offset = "0x267D460", VA = "0x18267E060")]
	public static T DOFCLJBEHDG<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3661930", Offset = "0x3660D30", VA = "0x183661930")]
	public static T MMLICGMMMEK<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x365CDC0", Offset = "0x365C1C0", VA = "0x18365CDC0")]
	public static void JFGGMENNDNP<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC, [In] T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x365CDC0", Offset = "0x365C1C0", VA = "0x18365CDC0")]
	public static void CJKHNNDOCIA<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xD1DB70", Offset = "0xD1CF70", VA = "0x180D1DB70")]
	public static int JEMBEAPNKLB<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x365D450", Offset = "0x365C850", VA = "0x18365D450")]
	public static ReadOnlySpan<T> DHLFIIHGBON<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3660870", Offset = "0x365FC70", VA = "0x183660870")]
	public static T[] IIPJLCHNEPM<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3661860", Offset = "0x3660C60", VA = "0x183661860")]
	public static T LCLPNBKONCG<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36617B0", Offset = "0x3660BB0", VA = "0x1836617B0")]
	public static T[] KAOPFKJKOMM<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x365D8E0", Offset = "0x365CCE0", VA = "0x18365D8E0")]
	public static GHDELNLDBAO<T> EGIDMJEJNNJ<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(GHDELNLDBAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3661420", Offset = "0x3660820", VA = "0x183661420")]
	public static void JJBKLNLGAIJ<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x365C010", Offset = "0x365B410", VA = "0x18365C010")]
	public static void AGAIAPKAFMH<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3660500", Offset = "0x365F900", VA = "0x183660500")]
	public static void IHGDPCFIMLB<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int CJFNAFNJJLB, [In] T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x365D820", Offset = "0x365CC20", VA = "0x18365D820")]
	public static void EEJOOAKCEPF<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int CJFNAFNJJLB, [In] AJFCGHOLDCP<T> JGMAGBDHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x365C350", Offset = "0x365B750", VA = "0x18365C350")]
	public static void BBPLODNBCFE<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int CJFNAFNJJLB, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36604C0", Offset = "0x365F8C0", VA = "0x1836604C0")]
	public static void IGICEDPNCHE<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3660DA0", Offset = "0x36601A0", VA = "0x183660DA0")]
	public static T JEEDPJJIAJP<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x365DD60", Offset = "0x365D160", VA = "0x18365DD60")]
	public static void FHDKNMLGMGO<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3665E40", Offset = "0x3665240", VA = "0x183665E40")]
	private static void PHNLOPOKADA<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x365CBB0", Offset = "0x365BFB0", VA = "0x18365CBB0")]
	public static void CJEMNCEDADJ<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3660AE0", Offset = "0x365FEE0", VA = "0x183660AE0")]
	public static AJFCGHOLDCP<T> IPLKNPADEBH<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ, DHBDAOLGCAL<T, T> PLBFECFPMBG)
	{
		return default(AJFCGHOLDCP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3660C00", Offset = "0x3660000", VA = "0x183660C00")]
	public static bool JEBJOEBLLEI<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, T FFOEEMKIKJO) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x365D9B0", Offset = "0x365CDB0", VA = "0x18365D9B0")]
	public static bool FBDMDGAHCAE<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] T FFOEEMKIKJO) where T : BDMMFIPCFEO<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x339F6A0", Offset = "0x339EAA0", VA = "0x18339F6A0")]
	public static bool MPMNNGFDLEO<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x365C4B0", Offset = "0x365B8B0", VA = "0x18365C4B0")]
	public static bool BPFGALBDGHF<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3660470", Offset = "0x365F870", VA = "0x183660470")]
	public static void HBKAFNOHGDL<T, TCtx>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] TCtx PDBOIKJNMKA, CBPJPGAKMNK<TCtx, T> IKBKHMPLBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x365C250", Offset = "0x365B650", VA = "0x18365C250")]
	private static void BAKBNFJCJDJ<T, TCtx>(AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] TCtx PDBOIKJNMKA, CBPJPGAKMNK<TCtx, T> IKBKHMPLBLN, int HMMOELDHLFD, int BKEKDIMMPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x365C510", Offset = "0x365B910", VA = "0x18365C510")]
	private static int CDAADOOHHOH<T, TCtx>(AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] TCtx PDBOIKJNMKA, CBPJPGAKMNK<TCtx, T> IKBKHMPLBLN, int HMMOELDHLFD, int BKEKDIMMPGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x339EF50", Offset = "0x339E350", VA = "0x18339EF50")]
	public static AJFCGHOLDCP<T>.DPAKAGMDJOD DBEEDGEHMMA<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(AJFCGHOLDCP<T>.DPAKAGMDJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x339EF50", Offset = "0x339E350", VA = "0x18339EF50")]
	public static AJFCGHOLDCP<T>.FMDICCABPEB MINDJFKHEPL<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(AJFCGHOLDCP<T>.FMDICCABPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3401360", Offset = "0x3400760", VA = "0x183401360")]
	public static FONPLHOCLEB<T, AJFCGHOLDCP<T>.DPAKAGMDJOD> JNCBCDHAKAJ<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(FONPLHOCLEB<T, AJFCGHOLDCP<T>.DPAKAGMDJOD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class HEMCDLPBJNI
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3603220", Offset = "0x3602620", VA = "0x183603220")]
	public static T[] JJNNJAIHPMF<T>(int MNDMOIHIBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	public static void IICOMJDJDGD<T>(T[] LLPLHOOOAEB)
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
