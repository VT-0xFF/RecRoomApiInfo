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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x609B2E0", Offset = "0x609A0E0", VA = "0x18609B2E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DGGFIJNNCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x224E700", Offset = "0x224D500", VA = "0x18224E700")]
	public static NDFFLICPAGJ<T> ALMGOGNLGLB<T>(this T[] CNFBJPGPBBJ) where T : notnull
	{
		return default(NDFFLICPAGJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class CBIJNAHMMFP<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LGHDEKJBNJM<T> CKHDHJCLJCM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4976DB0", Offset = "0x4975BB0", VA = "0x184976DB0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4976D80", Offset = "0x4975B80", VA = "0x184976D80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4976DE0", Offset = "0x4975BE0", VA = "0x184976DE0")]
	public static CBIJNAHMMFP<T> KJKFMOENPNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBAE0", Offset = "0x3BFA8E0", VA = "0x183BFBAE0")]
	internal CBIJNAHMMFP([In] LGHDEKJBNJM<T> HBHLLIKFPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4976D10", Offset = "0x4975B10", VA = "0x184976D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4976CF0", Offset = "0x4975AF0", VA = "0x184976CF0")]
	public void CMOPNAIDGPB(int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4976D30", Offset = "0x4975B30", VA = "0x184976D30", Slot = "8")]
	public LGHDEKJBNJM<T>.MIJJFDIGKAJ GetEnumerator()
	{
		return default(LGHDEKJBNJM<T>.MIJJFDIGKAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4976F00", Offset = "0x4975D00", VA = "0x184976F00", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4976F00", Offset = "0x4975D00", VA = "0x184976F00", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MJOPIHFOANL<T, U> : IEnumerable<T>, IEnumerable where U : GFBAABEFAOE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U ONJJHLJPDAD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DDE0", Offset = "0x1D5CBE0", VA = "0x181D5DDE0")]
	internal MJOPIHFOANL([In] U GBMJFFENPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E3F0", Offset = "0x3A5D1F0", VA = "0x183A5E3F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E3F0", Offset = "0x3A5D1F0", VA = "0x183A5E3F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ACAHDCJEBGB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2243010", Offset = "0x2241E10", VA = "0x182243010")]
	public static MJOPIHFOANL<T, U> KJKFMOENPNA<U>([In] U CNFBJPGPBBJ) where U : GFBAABEFAOE<T>
	{
		return default(MJOPIHFOANL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JMBDNNCCPGJ<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U ONJJHLJPDAD;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E730", Offset = "0x3A5D530", VA = "0x183A5E730")]
	internal JMBDNNCCPGJ([In] U GBMJFFENPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E160", Offset = "0x3A5CF60", VA = "0x183A5E160", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E570", Offset = "0x3A5D370", VA = "0x183A5E570", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E570", Offset = "0x3A5D370", VA = "0x183A5E570", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AKEDBNDOBBP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2244B50", Offset = "0x2243950", VA = "0x182244B50")]
	public static JMBDNNCCPGJ<T, U> KJKFMOENPNA<U>([In] U CNFBJPGPBBJ) where U : IEnumerator<T>
	{
		return default(JMBDNNCCPGJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class LENCCBEFDOA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27874B0", Offset = "0x27862B0", VA = "0x1827874B0")]
	public static string AFOKKFLKENK<T>(this IEnumerable<T> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x278A230", Offset = "0x2789030", VA = "0x18278A230")]
	public static string OCMJHIHMBFP<T>(this IEnumerable<T> CNFBJPGPBBJ, string HKJHPNHHGBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class INGFGADLAEN
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27436E0", Offset = "0x27424E0", VA = "0x1827436E0")]
	public static bool CNFJLHBEHKH<TSourceEnumerator, TSource>(this TSourceEnumerator CNFBJPGPBBJ, [In] TSource PEFIMPHEJCD) where TSourceEnumerator : GFBAABEFAOE<TSource> where TSource : NLAOOBBGEHG<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2743860", Offset = "0x2742660", VA = "0x182743860")]
	public static int PBOLEEPKJAP<TSourceEnumerator, TSource>(this TSourceEnumerator CNFBJPGPBBJ, [In] TSource NKKIECLCEML) where TSourceEnumerator : GFBAABEFAOE<TSource> where TSource : NLAOOBBGEHG<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GFBAABEFAOE<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ODMJFPGIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OBIMGACDMMN<T> : GFBAABEFAOE<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct CKGEPNCHNDI<T, U> : IEnumerable<T>, IEnumerable where U : OBIMGACDMMN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U ONJJHLJPDAD;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x378A8A0", Offset = "0x37896A0", VA = "0x18378A8A0")]
	internal CKGEPNCHNDI([In] U GBMJFFENPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32FD700", Offset = "0x32FC500", VA = "0x1832FD700", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8810", Offset = "0x3DE7610", VA = "0x183DE8810", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8810", Offset = "0x3DE7610", VA = "0x183DE8810", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OBICKCNFHBJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2243040", Offset = "0x2241E40", VA = "0x182243040")]
	public static CKGEPNCHNDI<T, U> KJKFMOENPNA<U>([In] U CNFBJPGPBBJ) where U : OBIMGACDMMN<T>
	{
		return default(CKGEPNCHNDI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct NDFFLICPAGJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ENBCJFJMAKD : GFBAABEFAOE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] IBJKPIBECLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int DFPCKHJCOAJ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3259DA0", Offset = "0x3258BA0", VA = "0x183259DA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3259860", Offset = "0x3258660", VA = "0x183259860", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3259BC0", Offset = "0x32589C0", VA = "0x183259BC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x17CEC40", Offset = "0x17CDA40", VA = "0x1817CEC40")]
		private ENBCJFJMAKD(T[] CNFBJPGPBBJ, int ENPOKNEMOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3259630", Offset = "0x3258430", VA = "0x183259630")]
		public static ENBCJFJMAKD KJKFMOENPNA(T[] CNFBJPGPBBJ)
		{
			return default(ENBCJFJMAKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D85810", Offset = "0x1D84610", VA = "0x181D85810", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D85880", Offset = "0x1D84680", VA = "0x181D85880", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] IABDKHCNJLK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AAKPPKIKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3237820", Offset = "0x3236620", VA = "0x183237820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2CCBB10", Offset = "0x2CCA910", VA = "0x182CCBB10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	internal NDFFLICPAGJ(T[] AAKJIOEDOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F310", Offset = "0x3E5E110", VA = "0x183E5F310")]
	public static NDFFLICPAGJ<T> NJBMLHJLPOH()
	{
		return default(NDFFLICPAGJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
	public IEnumerable<T> DILDKFDKNBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F160", Offset = "0x3E5DF60", VA = "0x183E5F160")]
	public ReadOnlyMemory<T> MOIOJBIAOAG()
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F0D0", Offset = "0x3E5DED0", VA = "0x183E5F0D0")]
	public ReadOnlySpan<T> KMOCMDHIJEF()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F1F0", Offset = "0x3E5DFF0", VA = "0x183E5F1F0")]
	public MJOPIHFOANL<T, NDFFLICPAGJ<T>.ENBCJFJMAKD> NEGOBDPHIHO()
	{
		return default(MJOPIHFOANL<T, ENBCJFJMAKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F040", Offset = "0x3E5DE40", VA = "0x183E5F040")]
	public ENBCJFJMAKD ICIDOEPKLFJ()
	{
		return default(ENBCJFJMAKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F3D0", Offset = "0x3E5E1D0", VA = "0x183E5F3D0")]
	public IEnumerator<T> OOEEFIELKKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F450", Offset = "0x3E5E250", VA = "0x183E5F450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PJLOIDHOBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x24183A0", Offset = "0x24171A0", VA = "0x1824183A0")]
	public static NDFFLICPAGJ<T> OGCIDOOHANF<T>(params T[] AAKJIOEDOGA) where T : notnull
	{
		return default(NDFFLICPAGJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x609B360", Offset = "0x609A160", VA = "0x18609B360")]
	public static Stream PANEEAAHMDK(this NDFFLICPAGJ<byte> CNFBJPGPBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(LGHDEKJBNJM<>.GJNDMNGDABJ))]
public struct LGHDEKJBNJM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct MIJJFDIGKAJ : OBIMGACDMMN<T>, GFBAABEFAOE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] DEBNCNDAIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int HKPADAMHOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int DFPCKHJCOAJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7F30", Offset = "0x3DE6D30", VA = "0x183DE7F30", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T FOJBALCJAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3DE77B0", Offset = "0x3DE65B0", VA = "0x183DE77B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7960", Offset = "0x3DE6760", VA = "0x183DE7960", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7BA0", Offset = "0x3DE69A0", VA = "0x183DE7BA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CF20", Offset = "0x3A9BD20", VA = "0x183A9CF20")]
		internal MIJJFDIGKAJ(T[] CHPHEMNFCNL, int BPFMGMBDOBA, int ENPOKNEMOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE78A0", Offset = "0x3DE66A0", VA = "0x183DE78A0")]
		public static MIJJFDIGKAJ KJKFMOENPNA(LGHDEKJBNJM<T> CNFBJPGPBBJ)
		{
			return default(MIJJFDIGKAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x32BFA00", Offset = "0x32BE800", VA = "0x1832BFA00", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x32B9660", Offset = "0x32B8460", VA = "0x1832B9660", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct BFENMFFNOCG : GFBAABEFAOE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MIJJFDIGKAJ ONJJHLJPDAD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4675790", Offset = "0x4674590", VA = "0x184675790", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4675520", Offset = "0x4674320", VA = "0x184675520", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4675630", Offset = "0x4674430", VA = "0x184675630", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DDE0", Offset = "0x1D5CBE0", VA = "0x181D5DDE0")]
		private BFENMFFNOCG([In] MIJJFDIGKAJ GBMJFFENPGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4675320", Offset = "0x4674120", VA = "0x184675320")]
		public static BFENMFFNOCG KJKFMOENPNA([In] LGHDEKJBNJM<T> CNFBJPGPBBJ)
		{
			return default(BFENMFFNOCG);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x46753D0", Offset = "0x46741D0", VA = "0x1846753D0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4675410", Offset = "0x4674210", VA = "0x184675410", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x46752E0", Offset = "0x46740E0", VA = "0x1846752E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class GJNDMNGDABJ
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] DEBNCNDAIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int HKPADAMHOJJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4660", Offset = "0x3BF3460", VA = "0x183BF4660")]
	public static LGHDEKJBNJM<T> KJKFMOENPNA()
	{
		return default(LGHDEKJBNJM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4700", Offset = "0x3BF3500", VA = "0x183BF4700")]
	public static LGHDEKJBNJM<T> LDLHEJOCAGH(int BKPALGGNBEN)
	{
		return default(LGHDEKJBNJM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x17CEC40", Offset = "0x17CDA40", VA = "0x1817CEC40")]
	internal LGHDEKJBNJM(T[] CHPHEMNFCNL, int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF47B0", Offset = "0x3BF35B0", VA = "0x183BF47B0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class APCHIPDCPGL
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7420", Offset = "0x2CC6220", VA = "0x182CC7420")]
	public static void ECEAPGIDAKG<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC9890", Offset = "0x2CC8690", VA = "0x182CC9890")]
	public static string HCNBKNECMOP<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
	public static T[] IOHGPCOMJJF<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1D85940", Offset = "0x1D84740", VA = "0x181D85940")]
	public static T IKJEAFPPDKF<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ, int PGCIMAABPAK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CCBB10", Offset = "0x2CCA910", VA = "0x182CCBB10")]
	public static T LGNMNOJBNDM<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, int PGCIMAABPAK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC4D0", Offset = "0x2CCB2D0", VA = "0x182CCC4D0")]
	public static T PNJIIPELLJO<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ, int PGCIMAABPAK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2CC9130", Offset = "0x2CC7F30", VA = "0x182CC9130")]
	public static void FOBLAMHLHCD<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, int PGCIMAABPAK, [In] T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC420", Offset = "0x2CCB220", VA = "0x182CCC420")]
	public static void PEPANEMPOJO<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, int PGCIMAABPAK, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130")]
	public static int AIFGPJKHHPG<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2CCBFA0", Offset = "0x2CCADA0", VA = "0x182CCBFA0")]
	public static ReadOnlySpan<T> KMOCMDHIJEF<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2CCBDC0", Offset = "0x2CCABC0", VA = "0x182CCBDC0")]
	public static T[] JHDEKGBNKJF<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4F90", Offset = "0x2CC3D90", VA = "0x182CC4F90")]
	public static T APCJBGKLMDA<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7480", Offset = "0x2CC6280", VA = "0x182CC7480")]
	public static T[] FFOMDKPCKIK<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCBC00", Offset = "0x2CCAA00", VA = "0x182CCBC00")]
	public static NDFFLICPAGJ<T> IMKKKOGPKOL<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return default(NDFFLICPAGJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4B30", Offset = "0x2CC3930", VA = "0x182CC4B30")]
	public static void ANMBPKAMKOK<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, [In] T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC0B0", Offset = "0x2CCAEB0", VA = "0x182CCC0B0")]
	public static void MFBEHFNLOCG<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CCC1E0", Offset = "0x2CCAFE0", VA = "0x182CCC1E0")]
	public static void PALGEKGKIDP<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, int ENPOKNEMOMH, [In] T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2CCB990", Offset = "0x2CCA790", VA = "0x182CCB990")]
	public static void IHIODFMFKMD<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4A40", Offset = "0x2CC3840", VA = "0x182CC4A40")]
	public static T AKFDODCHPOH<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5410", Offset = "0x2CC4210", VA = "0x182CC5410")]
	public static void CMOPNAIDGPB<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7630", Offset = "0x2CC6430", VA = "0x182CC7630")]
	private static void FMNNOHFMJEL<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, int BKPALGGNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4FB0", Offset = "0x2CC3DB0", VA = "0x182CC4FB0")]
	public static void BBGCGJHDDBK<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5130", Offset = "0x2CC3F30", VA = "0x182CC5130")]
	public static LGHDEKJBNJM<T> CGCPFECLPOJ<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ, ALLDDHIKJMO<T, T> HDALAJPCJGJ)
	{
		return default(LGHDEKJBNJM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2CCBC90", Offset = "0x2CCAA90", VA = "0x182CCBC90")]
	public static bool INNMFECLHCG<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ, [In] T NKKIECLCEML) where T : NLAOOBBGEHG<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2757C60", Offset = "0x2756A60", VA = "0x182757C60")]
	public static bool NJDBJPCDOCO<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4A00", Offset = "0x2CC3800", VA = "0x182CC4A00")]
	public static bool ABMMIKMJCKK<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ, int PGCIMAABPAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26E3580", Offset = "0x26E2380", VA = "0x1826E3580")]
	public static LGHDEKJBNJM<T>.BFENMFFNOCG OOEEFIELKKG<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return default(LGHDEKJBNJM<T>.BFENMFFNOCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26E3580", Offset = "0x26E2380", VA = "0x1826E3580")]
	public static LGHDEKJBNJM<T>.MIJJFDIGKAJ AOAHPDMMKFP<T>(this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return default(LGHDEKJBNJM<T>.MIJJFDIGKAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x26E3610", Offset = "0x26E2410", VA = "0x1826E3610")]
	public static MJOPIHFOANL<T, LGHDEKJBNJM<T>.BFENMFFNOCG> INEBOGEMABH<T>([In] this LGHDEKJBNJM<T> CNFBJPGPBBJ)
	{
		return default(MJOPIHFOANL<T, LGHDEKJBNJM<T>.BFENMFFNOCG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class GKAONNKHNJM
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26F5B90", Offset = "0x26F4990", VA = "0x1826F5B90")]
	public static T[] GDCKKKOOLLL<T>(int DDGPJFNNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	public static void EJMNLCKDMND<T>(T[] AAKJIOEDOGA)
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
