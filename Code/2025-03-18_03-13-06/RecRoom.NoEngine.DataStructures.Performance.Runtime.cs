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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7710D50", Offset = "0x770FF50", VA = "0x187710D50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JDPBLIDEPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32C9360", Offset = "0x32C8560", VA = "0x1832C9360")]
	public static LHKPKGFBDFM<T> NDBANFMDGEO<T>(this T[] NAELBAPCKEH) where T : notnull
	{
		return default(LHKPKGFBDFM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class NHHNMEHPHHA<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PKMCDMEOPGC<T> GEBLDODDHJA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E33900", Offset = "0x4E32B00", VA = "0x184E33900", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E33870", Offset = "0x4E32A70", VA = "0x184E33870")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E33940", Offset = "0x4E32B40", VA = "0x184E33940")]
	public static NHHNMEHPHHA<T> PEFMILKIAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x476E1F0", Offset = "0x476D3F0", VA = "0x18476E1F0")]
	internal NHHNMEHPHHA([In] PKMCDMEOPGC<T> PIJKIPKKMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E33830", Offset = "0x4E32A30", VA = "0x184E33830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E337F0", Offset = "0x4E329F0", VA = "0x184E337F0")]
	public void DAFLEPFEOFO(int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E338B0", Offset = "0x4E32AB0", VA = "0x184E338B0", Slot = "8")]
	public PKMCDMEOPGC<T>.DAHGHFKFMBI GetEnumerator()
	{
		return default(PKMCDMEOPGC<T>.DAHGHFKFMBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E33A70", Offset = "0x4E32C70", VA = "0x184E33A70", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E33A70", Offset = "0x4E32C70", VA = "0x184E33A70", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HIOEJNACACI<T, U> : IEnumerable<T>, IEnumerable where U : GCGKOMDDNNI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U GFPIPIFBJMF;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2578770", Offset = "0x2577970", VA = "0x182578770")]
	internal HIOEJNACACI([In] U IAHCPHAJMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x46B22F0", Offset = "0x46B14F0", VA = "0x1846B22F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x46B22F0", Offset = "0x46B14F0", VA = "0x1846B22F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BHNOHHHEOIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34427C0", Offset = "0x34419C0", VA = "0x1834427C0")]
	public static HIOEJNACACI<T, U> PEFMILKIAFF<U>([In] U NAELBAPCKEH) where U : GCGKOMDDNNI<T>
	{
		return default(HIOEJNACACI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KBKHLIMNCHI<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U GFPIPIFBJMF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4A5B720", Offset = "0x4A5A920", VA = "0x184A5B720")]
	internal KBKHLIMNCHI([In] U IAHCPHAJMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A5B640", Offset = "0x4A5A840", VA = "0x184A5B640", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A5B640", Offset = "0x4A5A840", VA = "0x184A5B640", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IMIBAEMCGPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3835F60", Offset = "0x3835160", VA = "0x183835F60")]
	public static KBKHLIMNCHI<T, U> PEFMILKIAFF<U>([In] U NAELBAPCKEH) where U : IEnumerator<T>
	{
		return default(KBKHLIMNCHI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CHHCIEDHDFC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x326B9C0", Offset = "0x326ABC0", VA = "0x18326B9C0")]
	public static string FOJCKGEKJJK<T>(this IEnumerable<T> NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32728F0", Offset = "0x3271AF0", VA = "0x1832728F0")]
	public static string LHDMHMAEBCA<T>(this IEnumerable<T> NAELBAPCKEH, string FIACBIMNECJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CEBBBNONGGE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3265F40", Offset = "0x3265140", VA = "0x183265F40")]
	public static bool HGINNEDBKMG<TSourceEnumerator, TSource>(this TSourceEnumerator NAELBAPCKEH, [In] TSource LOKFKJLCEOD) where TSourceEnumerator : GCGKOMDDNNI<TSource> where TSource : KIIJBEBJMFN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3265B40", Offset = "0x3264D40", VA = "0x183265B40")]
	public static int ELECFDBEDLD<TSourceEnumerator, TSource>(this TSourceEnumerator NAELBAPCKEH, [In] TSource OMFJNFBDJCA) where TSourceEnumerator : GCGKOMDDNNI<TSource> where TSource : KIIJBEBJMFN<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3265DA0", Offset = "0x3264FA0", VA = "0x183265DA0")]
	public static int ENPIPHLKHJA<TSourceEnumerator, TSource>(this TSourceEnumerator NAELBAPCKEH, [In] TSource OMFJNFBDJCA) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GCGKOMDDNNI<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T PEOKKFBMNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GJFPECOICIB<T> : GCGKOMDDNNI<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct BGNFCHNFIKH<T, U> : IEnumerable<T>, IEnumerable where U : GJFPECOICIB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U GFPIPIFBJMF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x45D2D30", Offset = "0x45D1F30", VA = "0x1845D2D30")]
	internal BGNFCHNFIKH([In] U IAHCPHAJMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x41C4610", Offset = "0x41C3810", VA = "0x1841C4610", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x46B2360", Offset = "0x46B1560", VA = "0x1846B2360", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x46B2360", Offset = "0x46B1560", VA = "0x1846B2360", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class COEMILGBDGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3442790", Offset = "0x3441990", VA = "0x183442790")]
	public static BGNFCHNFIKH<T, U> PEFMILKIAFF<U>([In] U NAELBAPCKEH) where U : GJFPECOICIB<T>
	{
		return default(BGNFCHNFIKH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct LHKPKGFBDFM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct DDGCHDMJCOO : GCGKOMDDNNI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] IHADECHJEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int HCBPNJECLDC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6382200", Offset = "0x6381400", VA = "0x186382200", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6381D10", Offset = "0x6380F10", VA = "0x186381D10", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6381DB0", Offset = "0x6380FB0", VA = "0x186381DB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB06F50", Offset = "0xB06150", VA = "0x180B06F50")]
		private DDGCHDMJCOO(T[] NAELBAPCKEH, int KOOLKCPAFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x498C880", Offset = "0x498BA80", VA = "0x18498C880")]
		public static DDGCHDMJCOO PEFMILKIAFF(T[] NAELBAPCKEH)
		{
			return default(DDGCHDMJCOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x25BCB00", Offset = "0x25BBD00", VA = "0x1825BCB00", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x25BCB60", Offset = "0x25BBD60", VA = "0x1825BCB60", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] ODJPAEGNOHM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x411DA60", Offset = "0x411CC60", VA = "0x18411DA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x32D0670", Offset = "0x32CF870", VA = "0x1832D0670")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	internal LHKPKGFBDFM(T[] LGLFHJLCKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CC80", Offset = "0x4B7BE80", VA = "0x184B7CC80")]
	public static LHKPKGFBDFM<T> CENLOHBLGNG()
	{
		return default(LHKPKGFBDFM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
	public IEnumerable<T> MAELDPMFFGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CE80", Offset = "0x4B7C080", VA = "0x184B7CE80")]
	public ReadOnlySpan<T> MIBCKECHABG()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CD50", Offset = "0x4B7BF50", VA = "0x184B7CD50")]
	public HIOEJNACACI<T, LHKPKGFBDFM<T>.DDGCHDMJCOO> JAFFKGJOAGN()
	{
		return default(HIOEJNACACI<T, DDGCHDMJCOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CFA0", Offset = "0x4B7C1A0", VA = "0x184B7CFA0")]
	public DDGCHDMJCOO PLDJCEDEPLG()
	{
		return default(DDGCHDMJCOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CF20", Offset = "0x4B7C120", VA = "0x184B7CF20")]
	public IEnumerator<T> PACLDABBHPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D040", Offset = "0x4B7C240", VA = "0x184B7D040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AJLJMINCHHG
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x32C94D0", Offset = "0x32C86D0", VA = "0x1832C94D0")]
	public static LHKPKGFBDFM<T> GKMGONKDEEP<T>(params T[] LGLFHJLCKKH) where T : notnull
	{
		return default(LHKPKGFBDFM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7710CF0", Offset = "0x770FEF0", VA = "0x187710CF0")]
	public static Stream OMHBEKKDENB(this LHKPKGFBDFM<byte> NAELBAPCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(PKMCDMEOPGC<>.DBCHKMIOCCC))]
public struct PKMCDMEOPGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct DAHGHFKFMBI : GJFPECOICIB<T>, GCGKOMDDNNI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] ALFIAAHFLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int FHPCFEJBAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int HCBPNJECLDC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x636DD60", Offset = "0x636CF60", VA = "0x18636DD60", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T LFLBKGICJEH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x636D5E0", Offset = "0x636C7E0", VA = "0x18636D5E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T AGLJFINPKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x636D290", Offset = "0x636C490", VA = "0x18636D290", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x636D750", Offset = "0x636C950", VA = "0x18636D750", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x636D8F0", Offset = "0x636CAF0", VA = "0x18636D8F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x461A750", Offset = "0x4619950", VA = "0x18461A750")]
		internal DAHGHFKFMBI(T[] IDDPONMNMLO, int IPBKHOJKHLJ, int KOOLKCPAFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x636D620", Offset = "0x636C820", VA = "0x18636D620")]
		public static DAHGHFKFMBI PEFMILKIAFF(PKMCDMEOPGC<T> NAELBAPCKEH)
		{
			return default(DAHGHFKFMBI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x417B0B0", Offset = "0x417A2B0", VA = "0x18417B0B0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x417AA40", Offset = "0x4179C40", VA = "0x18417AA40", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct DFKOHDHDFEG : GCGKOMDDNNI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DAHGHFKFMBI GFPIPIFBJMF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x638D010", Offset = "0x638C210", VA = "0x18638D010", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x638CCC0", Offset = "0x638BEC0", VA = "0x18638CCC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x638CE80", Offset = "0x638C080", VA = "0x18638CE80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2578770", Offset = "0x2577970", VA = "0x182578770")]
		private DFKOHDHDFEG([In] DAHGHFKFMBI IAHCPHAJMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x638CB20", Offset = "0x638BD20", VA = "0x18638CB20")]
		public static DFKOHDHDFEG PEFMILKIAFF([In] PKMCDMEOPGC<T> NAELBAPCKEH)
		{
			return default(DFKOHDHDFEG);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x638CAE0", Offset = "0x638BCE0", VA = "0x18638CAE0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x638CBD0", Offset = "0x638BDD0", VA = "0x18638CBD0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x638CAA0", Offset = "0x638BCA0", VA = "0x18638CAA0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class DBCHKMIOCCC
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] ALFIAAHFLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int FHPCFEJBAPL;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5130090", Offset = "0x512F290", VA = "0x185130090")]
	public static PKMCDMEOPGC<T> PEFMILKIAFF()
	{
		return default(PKMCDMEOPGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x512FFD0", Offset = "0x512F1D0", VA = "0x18512FFD0")]
	public static PKMCDMEOPGC<T> GHHCIAJEOFK(int ECPBKIMJCKH)
	{
		return default(PKMCDMEOPGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xB06F50", Offset = "0xB06150", VA = "0x180B06F50")]
	internal PKMCDMEOPGC(T[] IDDPONMNMLO, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5130140", Offset = "0x512F340", VA = "0x185130140", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MECFMGPMLGI
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int NBHDOLMFGAK<TCtx, T>([In] TCtx BKOBFFIPGEL, T DOEPDJPJMCB, T DHHGPPJBNNK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x355A9E0", Offset = "0x3559BE0", VA = "0x18355A9E0")]
	public static void FFMIMIFACMK<T>(this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3552980", Offset = "0x3551B80", VA = "0x183552980")]
	public static string BPDNNGPLKMM<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
	public static T[] HHIMKBOGOLC<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x32D0640", Offset = "0x32CF840", VA = "0x1832D0640")]
	public static T NKAAMPBENGI<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH, int JMNJKPGAJIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x355BD10", Offset = "0x355AF10", VA = "0x18355BD10")]
	public static T OAAJKBFPJAD<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int JMNJKPGAJIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x355B1B0", Offset = "0x355A3B0", VA = "0x18355B1B0")]
	public static T GNCFJOHIJII<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH, int JMNJKPGAJIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x355AC70", Offset = "0x3559E70", VA = "0x18355AC70")]
	public static void GFIEJLHFJLN<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int JMNJKPGAJIF, [In] T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x355A3D0", Offset = "0x35595D0", VA = "0x18355A3D0")]
	public static void DMLGGEJOGJM<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int JMNJKPGAJIF, T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25BDAC0", Offset = "0x25BCCC0", VA = "0x1825BDAC0")]
	public static int DHILAPMPDFL<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x355B6D0", Offset = "0x355A8D0", VA = "0x18355B6D0")]
	public static ReadOnlySpan<T> MIBCKECHABG<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x355BBE0", Offset = "0x355ADE0", VA = "0x18355BBE0")]
	public static T[] NHEKLCNBFEE<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x355B1E0", Offset = "0x355A3E0", VA = "0x18355B1E0")]
	public static T IGFAPHOIEIF<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x355A700", Offset = "0x3559900", VA = "0x18355A700")]
	public static T[] EMBGFFKCJNG<T>(this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x355B910", Offset = "0x355AB10", VA = "0x18355B910")]
	public static LHKPKGFBDFM<T> NCBILEJCHFI<T>(this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return default(LHKPKGFBDFM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x355C8C0", Offset = "0x355BAC0", VA = "0x18355C8C0")]
	public static void OFEFHMDJLMD<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, [In] T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x355A810", Offset = "0x3559A10", VA = "0x18355A810")]
	public static void FDPHBFKIENF<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x355ADE0", Offset = "0x3559FE0", VA = "0x18355ADE0")]
	public static void GMILALKDDAH<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int KOOLKCPAFBB, [In] T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x355B5B0", Offset = "0x355A7B0", VA = "0x18355B5B0")]
	public static void KFPIJNGEIAH<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int KOOLKCPAFBB, [In] PKMCDMEOPGC<T> ALKPNNHBNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x355B210", Offset = "0x355A410", VA = "0x18355B210")]
	public static void JBDNFGHJCDJ<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int KOOLKCPAFBB, T OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x355CD70", Offset = "0x355BF70", VA = "0x18355CD70")]
	public static void OFIGKBFCILK<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int KOOLKCPAFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x355B670", Offset = "0x355A870", VA = "0x18355B670")]
	public static T KNCOIAAHAHO<T>(this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x35564B0", Offset = "0x35556B0", VA = "0x1835564B0")]
	public static void DAFLEPFEOFO<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3558D00", Offset = "0x3557F00", VA = "0x183558D00")]
	private static void DEMOBBOFCGO<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, int ECPBKIMJCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x355BF40", Offset = "0x355B140", VA = "0x18355BF40")]
	public static void NLADMABHKNO<T>(this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x355B4A0", Offset = "0x355A6A0", VA = "0x18355B4A0")]
	public static PKMCDMEOPGC<T> KFABHKFANJO<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH, DGMGEKNALFP<T, T> EANMHLPNGFF)
	{
		return default(PKMCDMEOPGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x355CDB0", Offset = "0x355BFB0", VA = "0x18355CDB0")]
	public static bool OGPGHNCGHLC<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, T OMFJNFBDJCA) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x355B9E0", Offset = "0x355ABE0", VA = "0x18355B9E0")]
	public static bool NEGFPGLKBPN<T>(this PKMCDMEOPGC<T> NAELBAPCKEH, [In] T OMFJNFBDJCA) where T : KIIJBEBJMFN<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3528CD0", Offset = "0x3527ED0", VA = "0x183528CD0")]
	public static bool HMMGIGDCPMP<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x355C770", Offset = "0x355B970", VA = "0x18355C770")]
	public static bool OEDNCKJEPAE<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH, int JMNJKPGAJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x355B8C0", Offset = "0x355AAC0", VA = "0x18355B8C0")]
	public static void MPECLBCIEDC<T, TCtx>(this PKMCDMEOPGC<T> NAELBAPCKEH, [In] TCtx BKOBFFIPGEL, NBHDOLMFGAK<TCtx, T> KCICMNACAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x355B7C0", Offset = "0x355A9C0", VA = "0x18355B7C0")]
	private static void MNBACBFMFPA<T, TCtx>(PKMCDMEOPGC<T> NAELBAPCKEH, [In] TCtx BKOBFFIPGEL, NBHDOLMFGAK<TCtx, T> KCICMNACAKE, int IIJKIDKIJLA, int FFOLCFINKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x355C100", Offset = "0x355B300", VA = "0x18355C100")]
	private static int OAPBIGIBAGM<T, TCtx>(PKMCDMEOPGC<T> NAELBAPCKEH, [In] TCtx BKOBFFIPGEL, NBHDOLMFGAK<TCtx, T> KCICMNACAKE, int IIJKIDKIJLA, int FFOLCFINKEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x32C9490", Offset = "0x32C8690", VA = "0x1832C9490")]
	public static PKMCDMEOPGC<T>.DFKOHDHDFEG PACLDABBHPO<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return default(PKMCDMEOPGC<T>.DFKOHDHDFEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x32C9490", Offset = "0x32C8690", VA = "0x1832C9490")]
	public static PKMCDMEOPGC<T>.DAHGHFKFMBI DDEKLPEMPHE<T>(this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return default(PKMCDMEOPGC<T>.DAHGHFKFMBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x32C9390", Offset = "0x32C8590", VA = "0x1832C9390")]
	public static HIOEJNACACI<T, PKMCDMEOPGC<T>.DFKOHDHDFEG> CACNOFGCLOO<T>([In] this PKMCDMEOPGC<T> NAELBAPCKEH)
	{
		return default(HIOEJNACACI<T, PKMCDMEOPGC<T>.DFKOHDHDFEG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class NAPOGNOJMHL
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x360B970", Offset = "0x360AB70", VA = "0x18360B970")]
	public static T[] HNFCDPIBEHC<T>(int IAGJHPFNLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	public static void LPEDKBHHHPL<T>(T[] LGLFHJLCKKH)
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
