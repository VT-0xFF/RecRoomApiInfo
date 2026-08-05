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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x79A0100", Offset = "0x799F500", VA = "0x1879A0100")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JODBFFJMKNL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3376400", Offset = "0x3375800", VA = "0x183376400")]
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
		[Cpp2IlInjected.Address(RVA = "0x50B1D30", Offset = "0x50B1130", VA = "0x1850B1D30", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x50B1CF0", Offset = "0x50B10F0", VA = "0x1850B1CF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50B1E40", Offset = "0x50B1240", VA = "0x1850B1E40")]
	public static NBEDGLKEHNJ<T> HBLBJMFGHFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x42DBE10", Offset = "0x42DB210", VA = "0x1842DBE10")]
	internal NBEDGLKEHNJ([In] AJFCGHOLDCP<T> BGCEKLPNCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50B1D70", Offset = "0x50B1170", VA = "0x1850B1D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x50B1DB0", Offset = "0x50B11B0", VA = "0x1850B1DB0")]
	public void FHDKNMLGMGO(int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50B1DF0", Offset = "0x50B11F0", VA = "0x1850B1DF0", Slot = "8")]
	public AJFCGHOLDCP<T>.FMDICCABPEB GetEnumerator()
	{
		return default(AJFCGHOLDCP<T>.FMDICCABPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x50B1F70", Offset = "0x50B1370", VA = "0x1850B1F70", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50B1F70", Offset = "0x50B1370", VA = "0x1850B1F70", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x2626C90", Offset = "0x2626090", VA = "0x182626C90")]
	internal FONPLHOCLEB([In] U CBEBKIBOLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x42C03A0", Offset = "0x42BF7A0", VA = "0x1842C03A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x42C03A0", Offset = "0x42BF7A0", VA = "0x1842C03A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DDBGLJOHCLM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9440", Offset = "0x2CF8840", VA = "0x182CF9440")]
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
	[Cpp2IlInjected.Address(RVA = "0x2626C90", Offset = "0x2626090", VA = "0x182626C90")]
	internal DCFBMJCCGFF([In] U CBEBKIBOLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42C03A0", Offset = "0x42BF7A0", VA = "0x1842C03A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42C03A0", Offset = "0x42BF7A0", VA = "0x1842C03A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GAGFKNNBEHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9440", Offset = "0x2CF8840", VA = "0x182CF9440")]
	public static DCFBMJCCGFF<T, U> HBLBJMFGHFK<U>([In] U JOCJBPPJMJJ) where U : IEnumerator<T>
	{
		return default(DCFBMJCCGFF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class LHMAGDCFBOC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x36F2A70", Offset = "0x36F1E70", VA = "0x1836F2A70")]
	public static string FJDACNOOCGJ<T>(this IEnumerable<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x36DEAE0", Offset = "0x36DDEE0", VA = "0x1836DEAE0")]
	public static string EGIKGHGCPMK<T>(this IEnumerable<T> JOCJBPPJMJJ, string EKFPLLKMIAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BGCEOKLOEOG
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3378DD0", Offset = "0x33781D0", VA = "0x183378DD0")]
	public static bool DBBFHBJKHDM<TSourceEnumerator, TSource>(this TSourceEnumerator JOCJBPPJMJJ, [In] TSource MGCEJOCCONP) where TSourceEnumerator : HFJBCMJHCGM<TSource> where TSource : BDMMFIPCFEO<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3378F50", Offset = "0x3378350", VA = "0x183378F50")]
	public static int LEKGMCLGOGH<TSourceEnumerator, TSource>(this TSourceEnumerator JOCJBPPJMJJ, [In] TSource FFOEEMKIKJO) where TSourceEnumerator : HFJBCMJHCGM<TSource> where TSource : BDMMFIPCFEO<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3378B60", Offset = "0x3377F60", VA = "0x183378B60")]
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
	[Cpp2IlInjected.Address(RVA = "0x42C0440", Offset = "0x42BF840", VA = "0x1842C0440")]
	internal EFGDONFLAEG([In] U CBEBKIBOLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x42C02F0", Offset = "0x42BF6F0", VA = "0x1842C02F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x42C0310", Offset = "0x42BF710", VA = "0x1842C0310", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x42C0310", Offset = "0x42BF710", VA = "0x1842C0310", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AGHPINKGALE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9470", Offset = "0x2CF8870", VA = "0x182CF9470")]
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
			[Cpp2IlInjected.Address(RVA = "0x470DE50", Offset = "0x470D250", VA = "0x18470DE50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x470D6F0", Offset = "0x470CAF0", VA = "0x18470D6F0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x470DA40", Offset = "0x470CE40", VA = "0x18470DA40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB716C0", Offset = "0xB70AC0", VA = "0x180B716C0")]
		private FFKMPJNIMOI(T[] JOCJBPPJMJJ, int CJFNAFNJJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x470D6A0", Offset = "0x470CAA0", VA = "0x18470D6A0")]
		public static FFKMPJNIMOI HBLBJMFGHFK(T[] JOCJBPPJMJJ)
		{
			return default(FFKMPJNIMOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x26793F0", Offset = "0x26787F0", VA = "0x1826793F0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2679420", Offset = "0x2678820", VA = "0x182679420", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x48402F0", Offset = "0x483F6F0", VA = "0x1848402F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3649EC0", Offset = "0x36492C0", VA = "0x183649EC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
	internal GHDELNLDBAO(T[] LLPLHOOOAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4840310", Offset = "0x483F710", VA = "0x184840310")]
	public static GHDELNLDBAO<T> GBADJOAJCAL()
	{
		return default(GHDELNLDBAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710")]
	public IEnumerable<T> KNALCBEAMKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4840250", Offset = "0x483F650", VA = "0x184840250")]
	public ReadOnlySpan<T> DHLFIIHGBON()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48403E0", Offset = "0x483F7E0", VA = "0x1848403E0")]
	public FONPLHOCLEB<T, GHDELNLDBAO<T>.FFKMPJNIMOI> IPLPMPJGEJF()
	{
		return default(FONPLHOCLEB<T, FFKMPJNIMOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4840510", Offset = "0x483F910", VA = "0x184840510")]
	public FFKMPJNIMOI MDBDIEHIAKK()
	{
		return default(FFKMPJNIMOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x48401D0", Offset = "0x483F5D0", VA = "0x1848401D0")]
	public IEnumerator<T> DBEEDGEHMMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x48405B0", Offset = "0x483F9B0", VA = "0x1848405B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EPBKBABIJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x33E9D10", Offset = "0x33E9110", VA = "0x1833E9D10")]
	public static GHDELNLDBAO<T> MDKOMKKBHPD<T>(params T[] LLPLHOOOAEB) where T : notnull
	{
		return default(GHDELNLDBAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x79A00A0", Offset = "0x799F4A0", VA = "0x1879A00A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x47533B0", Offset = "0x47527B0", VA = "0x1847533B0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T JEDHFCNJNPN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x47528D0", Offset = "0x4751CD0", VA = "0x1847528D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T MMHKMGKCJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4752AB0", Offset = "0x4751EB0", VA = "0x184752AB0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4752E30", Offset = "0x4752230", VA = "0x184752E30", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x47530F0", Offset = "0x47524F0", VA = "0x1847530F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x47532D0", Offset = "0x47526D0", VA = "0x1847532D0")]
		internal FMDICCABPEB(T[] KKIPPMFKGPH, int ECKHNAPCKGD, int CJFNAFNJJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4752A50", Offset = "0x4751E50", VA = "0x184752A50")]
		public static FMDICCABPEB HBLBJMFGHFK(AJFCGHOLDCP<T> JOCJBPPJMJJ)
		{
			return default(FMDICCABPEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4345930", Offset = "0x4344D30", VA = "0x184345930", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x433F5D0", Offset = "0x433E9D0", VA = "0x18433F5D0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6698110", Offset = "0x6697510", VA = "0x186698110", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6697DC0", Offset = "0x66971C0", VA = "0x186697DC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6697FC0", Offset = "0x66973C0", VA = "0x186697FC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2626C90", Offset = "0x2626090", VA = "0x182626C90")]
		private DPAKAGMDJOD([In] FMDICCABPEB CBEBKIBOLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6697BA0", Offset = "0x6696FA0", VA = "0x186697BA0")]
		public static DPAKAGMDJOD HBLBJMFGHFK([In] AJFCGHOLDCP<T> JOCJBPPJMJJ)
		{
			return default(DPAKAGMDJOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6697C50", Offset = "0x6697050", VA = "0x186697C50", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6697C90", Offset = "0x6697090", VA = "0x186697C90", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6697B60", Offset = "0x6696F60", VA = "0x186697B60", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x48E5530", Offset = "0x48E4930", VA = "0x1848E5530")]
	public static AJFCGHOLDCP<T> HBLBJMFGHFK()
	{
		return default(AJFCGHOLDCP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48E55E0", Offset = "0x48E49E0", VA = "0x1848E55E0")]
	public static AJFCGHOLDCP<T> LOHJIFHKNGB(int HDAIOJEADNO)
	{
		return default(AJFCGHOLDCP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xB716C0", Offset = "0xB70AC0", VA = "0x180B716C0")]
	internal AJFCGHOLDCP(T[] KKIPPMFKGPH, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48E56A0", Offset = "0x48E4AA0", VA = "0x1848E56A0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3652470", Offset = "0x3651870", VA = "0x183652470")]
	public static void OAHDOECNNKP<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x364E670", Offset = "0x364DA70", VA = "0x18364E670")]
	public static string NHCGLAEEAEB<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710")]
	public static T[] OIJFGPGAKPO<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x267A7D0", Offset = "0x2679BD0", VA = "0x18267A7D0")]
	public static T IOLMGDEDCOJ<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x267A7D0", Offset = "0x2679BD0", VA = "0x18267A7D0")]
	public static T DOFCLJBEHDG<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x364E2A0", Offset = "0x364D6A0", VA = "0x18364E2A0")]
	public static T MMLICGMMMEK<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3649730", Offset = "0x3648B30", VA = "0x183649730")]
	public static void JFGGMENNDNP<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC, [In] T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3649730", Offset = "0x3648B30", VA = "0x183649730")]
	public static void CJKHNNDOCIA<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xD18FD0", Offset = "0xD183D0", VA = "0x180D18FD0")]
	public static int JEMBEAPNKLB<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3649DC0", Offset = "0x36491C0", VA = "0x183649DC0")]
	public static ReadOnlySpan<T> DHLFIIHGBON<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x364D1E0", Offset = "0x364C5E0", VA = "0x18364D1E0")]
	public static T[] IIPJLCHNEPM<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x364E1D0", Offset = "0x364D5D0", VA = "0x18364E1D0")]
	public static T LCLPNBKONCG<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x364E120", Offset = "0x364D520", VA = "0x18364E120")]
	public static T[] KAOPFKJKOMM<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x364A250", Offset = "0x3649650", VA = "0x18364A250")]
	public static GHDELNLDBAO<T> EGIDMJEJNNJ<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(GHDELNLDBAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x364DD90", Offset = "0x364D190", VA = "0x18364DD90")]
	public static void JJBKLNLGAIJ<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3648980", Offset = "0x3647D80", VA = "0x183648980")]
	public static void AGAIAPKAFMH<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x364CE70", Offset = "0x364C270", VA = "0x18364CE70")]
	public static void IHGDPCFIMLB<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int CJFNAFNJJLB, [In] T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x364A190", Offset = "0x3649590", VA = "0x18364A190")]
	public static void EEJOOAKCEPF<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int CJFNAFNJJLB, [In] AJFCGHOLDCP<T> JGMAGBDHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3648CC0", Offset = "0x36480C0", VA = "0x183648CC0")]
	public static void BBPLODNBCFE<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int CJFNAFNJJLB, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x364CE30", Offset = "0x364C230", VA = "0x18364CE30")]
	public static void IGICEDPNCHE<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x364D710", Offset = "0x364CB10", VA = "0x18364D710")]
	public static T JEEDPJJIAJP<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x364A6D0", Offset = "0x3649AD0", VA = "0x18364A6D0")]
	public static void FHDKNMLGMGO<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x36527B0", Offset = "0x3651BB0", VA = "0x1836527B0")]
	private static void PHNLOPOKADA<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3649520", Offset = "0x3648920", VA = "0x183649520")]
	public static void CJEMNCEDADJ<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x364D450", Offset = "0x364C850", VA = "0x18364D450")]
	public static AJFCGHOLDCP<T> IPLKNPADEBH<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ, DHBDAOLGCAL<T, T> PLBFECFPMBG)
	{
		return default(AJFCGHOLDCP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x364D570", Offset = "0x364C970", VA = "0x18364D570")]
	public static bool JEBJOEBLLEI<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, T FFOEEMKIKJO) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x364A320", Offset = "0x3649720", VA = "0x18364A320")]
	public static bool FBDMDGAHCAE<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] T FFOEEMKIKJO) where T : BDMMFIPCFEO<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3389420", Offset = "0x3388820", VA = "0x183389420")]
	public static bool MPMNNGFDLEO<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3648E20", Offset = "0x3648220", VA = "0x183648E20")]
	public static bool BPFGALBDGHF<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ, int JKHIIFLAPEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x364CDE0", Offset = "0x364C1E0", VA = "0x18364CDE0")]
	public static void HBKAFNOHGDL<T, TCtx>(this AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] TCtx PDBOIKJNMKA, CBPJPGAKMNK<TCtx, T> IKBKHMPLBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3648BC0", Offset = "0x3647FC0", VA = "0x183648BC0")]
	private static void BAKBNFJCJDJ<T, TCtx>(AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] TCtx PDBOIKJNMKA, CBPJPGAKMNK<TCtx, T> IKBKHMPLBLN, int HMMOELDHLFD, int BKEKDIMMPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3648E80", Offset = "0x3648280", VA = "0x183648E80")]
	private static int CDAADOOHHOH<T, TCtx>(AJFCGHOLDCP<T> JOCJBPPJMJJ, [In] TCtx PDBOIKJNMKA, CBPJPGAKMNK<TCtx, T> IKBKHMPLBLN, int HMMOELDHLFD, int BKEKDIMMPGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3388CD0", Offset = "0x33880D0", VA = "0x183388CD0")]
	public static AJFCGHOLDCP<T>.DPAKAGMDJOD DBEEDGEHMMA<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(AJFCGHOLDCP<T>.DPAKAGMDJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3388CD0", Offset = "0x33880D0", VA = "0x183388CD0")]
	public static AJFCGHOLDCP<T>.FMDICCABPEB MINDJFKHEPL<T>(this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(AJFCGHOLDCP<T>.FMDICCABPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x33ED160", Offset = "0x33EC560", VA = "0x1833ED160")]
	public static FONPLHOCLEB<T, AJFCGHOLDCP<T>.DPAKAGMDJOD> JNCBCDHAKAJ<T>([In] this AJFCGHOLDCP<T> JOCJBPPJMJJ)
	{
		return default(FONPLHOCLEB<T, AJFCGHOLDCP<T>.DPAKAGMDJOD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class HEMCDLPBJNI
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x35ED0D0", Offset = "0x35EC4D0", VA = "0x1835ED0D0")]
	public static T[] JJNNJAIHPMF<T>(int MNDMOIHIBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
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
