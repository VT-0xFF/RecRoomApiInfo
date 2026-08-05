using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A430", Offset = "0x7A28E30", VA = "0x187A2A430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class DJMOIEGBMIM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected DJMOIEGBMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class OAAGHNOINII<T> : DJMOIEGBMIM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LNOGDBDIKPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum PALOHPLLDNM
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public PALOHPLLDNM OHCGINPDMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T HNDDBOOOBBE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int KCHDDKPIHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool FDNLOIKLJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool APIGCKCCKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? GCADJAFJLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LNOGDBDIKPH>? NJBOGJMLLGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BKNBNCNBBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x52C7530", Offset = "0x52C5F30", VA = "0x1852C7530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x52C7740", Offset = "0x52C6140", VA = "0x1852C7740")]
	protected OAAGHNOINII(bool APIGCKCCKPO, bool FDNLOIKLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x52C6D20", Offset = "0x52C5720", VA = "0x1852C6D20")]
	protected bool ANEJLOLLNOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x52C6F90", Offset = "0x52C5990", VA = "0x1852C6F90")]
	protected void ENBPCNPICIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x52C72C0", Offset = "0x52C5CC0", VA = "0x1852C72C0")]
	protected void KJEFLOPOKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8820", Offset = "0x3CF7220", VA = "0x183CF8820")]
	private static void BAIMNPGGBBK<U>(List<U>? FMFEHIEKOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x52C70B0", Offset = "0x52C5AB0", VA = "0x1852C70B0", Slot = "4")]
	public void HEHCILJMFIP(T HNDDBOOOBBE, bool ABGJACGNKPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x52C6DC0", Offset = "0x52C57C0", VA = "0x1852C6DC0", Slot = "5")]
	public void CBCJJMKDJJC(T HNDDBOOOBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x52C7590", Offset = "0x52C5F90", VA = "0x1852C7590")]
	public void OPINELCICKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class COOFKGJALFM : OAAGHNOINII<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A28AB0", Offset = "0x7A274B0", VA = "0x187A28AB0")]
	public COOFKGJALFM(bool APIGCKCCKPO = false, bool FDNLOIKLJLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A288B0", Offset = "0x7A272B0", VA = "0x187A288B0")]
	public void PADLNKFJPNL()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A28850", Offset = "0x7A27250", VA = "0x187A28850")]
	public static COOFKGJALFM JHHIBKDHNEN(COOFKGJALFM KKLEDCILBFG, Action HNDDBOOOBBE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A287F0", Offset = "0x7A271F0", VA = "0x187A287F0")]
	public static COOFKGJALFM BCDMHHCGKPL(COOFKGJALFM KKLEDCILBFG, Action HNDDBOOOBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BOIHPMOODLM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEHCILJMFIP(Action<T> HNDDBOOOBBE, bool ABGJACGNKPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBCJJMKDJJC(Action<T> HNDDBOOOBBE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JEBDGPAIPLL<T> : OAAGHNOINII<Action<T>>, BOIHPMOODLM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4355C10", Offset = "0x4354610", VA = "0x184355C10")]
	public JEBDGPAIPLL(bool APIGCKCCKPO = false, bool FDNLOIKLJLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CC0DC0", Offset = "0x4CBF7C0", VA = "0x184CC0DC0")]
	public void PADLNKFJPNL(T PPOLMDFNGFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4355500", Offset = "0x4353F00", VA = "0x184355500")]
	public static JEBDGPAIPLL<T> JHHIBKDHNEN(JEBDGPAIPLL<T> KKLEDCILBFG, Action<T> HNDDBOOOBBE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4355460", Offset = "0x4353E60", VA = "0x184355460")]
	public static JEBDGPAIPLL<T> BCDMHHCGKPL(JEBDGPAIPLL<T> KKLEDCILBFG, Action<T> HNDDBOOOBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NONCBENIHAN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEHCILJMFIP(Action<T, U> HNDDBOOOBBE, bool ABGJACGNKPP = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBCJJMKDJJC(Action<T, U> HNDDBOOOBBE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class KKHFJLAMDJE<T, U> : OAAGHNOINII<Action<T, U>>, NONCBENIHAN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4355C10", Offset = "0x4354610", VA = "0x184355C10")]
	public KKHFJLAMDJE(bool APIGCKCCKPO = false, bool FDNLOIKLJLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E090C0", Offset = "0x4E07AC0", VA = "0x184E090C0")]
	public void PADLNKFJPNL(T PPOLMDFNGFC, U AAJCAKCHJCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4355500", Offset = "0x4353F00", VA = "0x184355500")]
	public static KKHFJLAMDJE<T, U> JHHIBKDHNEN(KKHFJLAMDJE<T, U> KKLEDCILBFG, Action<T, U> HNDDBOOOBBE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4355460", Offset = "0x4353E60", VA = "0x184355460")]
	public static KKHFJLAMDJE<T, U> BCDMHHCGKPL(KKHFJLAMDJE<T, U> KKLEDCILBFG, Action<T, U> HNDDBOOOBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EEJMHJNKCID<T, U, V> : OAAGHNOINII<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4355C10", Offset = "0x4354610", VA = "0x184355C10")]
	public EEJMHJNKCID(bool APIGCKCCKPO = false, bool FDNLOIKLJLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43555A0", Offset = "0x4353FA0", VA = "0x1843555A0")]
	public void PADLNKFJPNL(T PPOLMDFNGFC, U AAJCAKCHJCG, V LFDANFLODKB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4355500", Offset = "0x4353F00", VA = "0x184355500")]
	public static EEJMHJNKCID<T, U, V> JHHIBKDHNEN(EEJMHJNKCID<T, U, V> KKLEDCILBFG, Action<T, U, V> HNDDBOOOBBE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4355460", Offset = "0x4353E60", VA = "0x184355460")]
	public static EEJMHJNKCID<T, U, V> BCDMHHCGKPL(EEJMHJNKCID<T, U, V> KKLEDCILBFG, Action<T, U, V> HNDDBOOOBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IKKIIIKOGJA<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class IOJADCPDKMP<T, U, V, W> : OAAGHNOINII<Action<T, U, V, W>>, IKKIIIKOGJA<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4355C10", Offset = "0x4354610", VA = "0x184355C10")]
	public IOJADCPDKMP(bool APIGCKCCKPO = false, bool FDNLOIKLJLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6760", Offset = "0x4AA5160", VA = "0x184AA6760")]
	public void PADLNKFJPNL(T PPOLMDFNGFC, U AAJCAKCHJCG, V LFDANFLODKB, W DBLNEKCBDJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4355500", Offset = "0x4353F00", VA = "0x184355500")]
	public static IOJADCPDKMP<T, U, V, W> JHHIBKDHNEN(IOJADCPDKMP<T, U, V, W> KKLEDCILBFG, Action<T, U, V, W> HNDDBOOOBBE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4355460", Offset = "0x4353E60", VA = "0x184355460")]
	public static IOJADCPDKMP<T, U, V, W> BCDMHHCGKPL(IOJADCPDKMP<T, U, V, W> KKLEDCILBFG, Action<T, U, V, W> HNDDBOOOBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class GJIDJIBJEFP<T, U, V, W, X> : OAAGHNOINII<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4355C10", Offset = "0x4354610", VA = "0x184355C10")]
	public GJIDJIBJEFP(bool APIGCKCCKPO = false, bool FDNLOIKLJLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x48D1DB0", Offset = "0x48D07B0", VA = "0x1848D1DB0")]
	public void PADLNKFJPNL(T PPOLMDFNGFC, U AAJCAKCHJCG, V LFDANFLODKB, W DBLNEKCBDJI, X CJBFFOKBLHB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4355500", Offset = "0x4353F00", VA = "0x184355500")]
	public static GJIDJIBJEFP<T, U, V, W, X> JHHIBKDHNEN(GJIDJIBJEFP<T, U, V, W, X> KKLEDCILBFG, Action<T, U, V, W, X> HNDDBOOOBBE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4355460", Offset = "0x4353E60", VA = "0x184355460")]
	public static GJIDJIBJEFP<T, U, V, W, X> BCDMHHCGKPL(GJIDJIBJEFP<T, U, V, W, X> KKLEDCILBFG, Action<T, U, V, W, X> HNDDBOOOBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class LKOKBMAFIMJ<T, U, V, W, X, Y> : OAAGHNOINII<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4355C10", Offset = "0x4354610", VA = "0x184355C10")]
	public LKOKBMAFIMJ(bool APIGCKCCKPO = false, bool FDNLOIKLJLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4EDAB40", Offset = "0x4ED9540", VA = "0x184EDAB40")]
	public void PADLNKFJPNL(T PPOLMDFNGFC, U AAJCAKCHJCG, V LFDANFLODKB, W DBLNEKCBDJI, X CJBFFOKBLHB, Y CNBLFOFLDDG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4355500", Offset = "0x4353F00", VA = "0x184355500")]
	public static LKOKBMAFIMJ<T, U, V, W, X, Y> JHHIBKDHNEN(LKOKBMAFIMJ<T, U, V, W, X, Y> KKLEDCILBFG, Action<T, U, V, W, X, Y> HNDDBOOOBBE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4355460", Offset = "0x4353E60", VA = "0x184355460")]
	public static LKOKBMAFIMJ<T, U, V, W, X, Y> BCDMHHCGKPL(LKOKBMAFIMJ<T, U, V, W, X, Y> KKLEDCILBFG, Action<T, U, V, W, X, Y> HNDDBOOOBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IJFLCMMKLGK<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AKJHEKJEJOA<TKey, TVal> PCNCMCGMADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BCAKIKADDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly AKJHEKJEJOA<TKey, TVal>.IOGJABJGMKL? CNEEHHFJPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int JMCGEMJKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AKJHEKJEJOA<TKey, TVal>.KMIPOCEGAKE? JLJFFCFAMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int PINDGLJJOOI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int GKLKKABONHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4A840B0", Offset = "0x4A82AB0", VA = "0x184A840B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int AFGHANPJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9B5540", Offset = "0x9B3F40", VA = "0x1809B5540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4A85170", Offset = "0x4A83B70", VA = "0x184A85170")]
	public IJFLCMMKLGK(int JMCGEMJKCPJ, [Optional] AKJHEKJEJOA<TKey, TVal>.KMIPOCEGAKE? JLJFFCFAMOE, [Optional] IEqualityComparer<TKey>? JEJCPEPDCKI, [Optional] AKJHEKJEJOA<TKey, TVal>.IOGJABJGMKL? CNEEHHFJPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4A83E80", Offset = "0x4A82880", VA = "0x184A83E80")]
	public void BCHOKDDEBEK(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA, bool DGFMNPGMFCO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4A84E60", Offset = "0x4A83860", VA = "0x184A84E60")]
	public bool MCAHBKNKKFN(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4A84FC0", Offset = "0x4A839C0", VA = "0x184A84FC0")]
	public bool OCHHJJBEIMP(TKey EBIFOIFHMFN, [Out] TVal PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A84A60", Offset = "0x4A83460", VA = "0x184A84A60")]
	private void MAGCDFLFEGG(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA, int PICLDLMFMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A848B0", Offset = "0x4A832B0", VA = "0x184A848B0")]
	public bool KMEJEAEDONC(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA, bool DGFMNPGMFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A850C0", Offset = "0x4A83AC0", VA = "0x184A850C0")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4A84100", Offset = "0x4A82B00", VA = "0x184A84100")]
	private void DABKJHONNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A84D20", Offset = "0x4A83720", VA = "0x184A84D20")]
	private bool MBKCLBKMFIN(TKey NJBPFCDJFGD, EACKOLKKNIF NBAKHABPJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4A84660", Offset = "0x4A83060", VA = "0x184A84660")]
	private void DBHHDNFONIA(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA, EACKOLKKNIF NBAKHABPJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A84780", Offset = "0x4A83180", VA = "0x184A84780")]
	private void HPEBPDOAJGE(TKey NJBPFCDJFGD, TVal OILNFPPOKDD, EACKOLKKNIF NBAKHABPJGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LECAKKJMHFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DGOJBIDGDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool CAEEKBHLKNN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public LECAKKJMHFI(Action APIACJCBFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7A29890", Offset = "0x7A28290", VA = "0x187A29890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x33B88C0", Offset = "0x33B72C0", VA = "0x1833B88C0")]
	public static HDLBIOFLEHA<T> IDEDHGEBOCJ<T>(T PPJFMHBDGNA, Action APIACJCBFLM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HDLBIOFLEHA<T> : LECAKKJMHFI where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4940DF0", Offset = "0x493F7F0", VA = "0x184940DF0")]
	public HDLBIOFLEHA(T PPJFMHBDGNA, Action APIACJCBFLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class DKDGIGPONGN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DMIFJLPKJDD<T>? NCNFPOGEABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> MFBGDKBBMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool CAEEKBHLKNN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DKDGIGPONGN<T> KPJGFDDMHFP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> LBHEIOFHAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3F194C0", Offset = "0x3F17EC0", VA = "0x183F194C0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F19600", Offset = "0x3F18000", VA = "0x183F19600")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DDFCNJDHCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F19780", Offset = "0x3F18180", VA = "0x183F19780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3F1A360", Offset = "0x3F18D60", VA = "0x183F1A360")]
	public DKDGIGPONGN(DMIFJLPKJDD<T> BCEAGIGBBBP, DMIFJLPKJDD<T> FAHHGJBAGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3F19C00", Offset = "0x3F18600", VA = "0x183F19C00")]
	public DKDGIGPONGN(DMIFJLPKJDD<T> BCEAGIGBBBP, int FNEPEEDFAPL, DMIFJLPKJDD<T> FAHHGJBAGEA, int JPAAPPADCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3F1A450", Offset = "0x3F18E50", VA = "0x183F1A450")]
	private DKDGIGPONGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3F193B0", Offset = "0x3F17DB0", VA = "0x183F193B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F19A10", Offset = "0x3F18410", VA = "0x183F19A10")]
	public T[] OBPCLLMNCNO()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3F19840", Offset = "0x3F18240", VA = "0x183F19840")]
	public static ReadOnlySequence<T> MEHFEEABIDG(DKDGIGPONGN<T>? EHMCDCMCIPF)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DLHGENCNAGI : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct JKFJCLOFEID : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
		public static JKFJCLOFEID DDDHPONDPCL()
		{
			return default(JKFJCLOFEID);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A28B10", Offset = "0x7A27510", VA = "0x187A28B10")]
	public static string EBOKGPNDEPE(Type OHCGINPDMEI, [Optional] string? DBMIDKOOPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3467380", Offset = "0x3465D80", VA = "0x183467380")]
	public static string? EBOKGPNDEPE<T>([Optional] string? DBMIDKOOPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3467400", Offset = "0x3465E00", VA = "0x183467400")]
	public static string? PPGEJPLBLMN<T>([Optional] string? ADGNIHDELNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
	public static DLHGENCNAGI JAENMCONLHL(string DBMIDKOOPOC, string? ADGNIHDELNG)
	{
		return default(DLHGENCNAGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BCIJNBHDOGP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool OKIACIABGCD(string BBOLBMGLLOA, BCIJNBHDOGP PDAMAJPCBIB);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MODMLHBFDAC<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MODMLHBFDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51446E0", Offset = "0x51430E0", VA = "0x1851446E0")]
		internal void GJLFKCFAIOF(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int PMMCFCOBIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string KNLKEBPDMBB;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A27320", Offset = "0x7A25D20", VA = "0x187A27320")]
	public static Dictionary<string, BCIJNBHDOGP> JNLAFBKFMNC(Type CFBHLGDMOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x33AD5C0", Offset = "0x33ABFC0", VA = "0x1833AD5C0")]
	public static Dictionary<string, BCIJNBHDOGP> JNLAFBKFMNC<T>(Type CFBHLGDMOBM, IReadOnlyDictionary<T, string> FFNPBDACDJN) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x33ADDF0", Offset = "0x33AC7F0", VA = "0x1833ADDF0")]
	public static Dictionary<string, BCIJNBHDOGP> LMLEGDFFGGE<T>(List<T> BMNAGFNAINN) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A27650", Offset = "0x7A26050", VA = "0x187A27650")]
	public static Dictionary<string, BCIJNBHDOGP> KMOGDAGDJJE(Type CFBHLGDMOBM, OKIACIABGCD DKDHCHKEBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A27160", Offset = "0x7A25B60", VA = "0x187A27160")]
	public static Dictionary<int, string> HJPADPNHFJK(Dictionary<string, BCIJNBHDOGP> HBNNPNFAEOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class MJKMNFLLIGE : ACEELKDBFDK
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool OFAMNMKCICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? GANIPGGOLCA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual ACEELKDBFDK? IOOCGJCNKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7A29FD0", Offset = "0x7A289D0", VA = "0x187A29FD0")]
	protected MJKMNFLLIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string CENGCFKJIFH();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A29980", Offset = "0x7A28380", VA = "0x187A29980", Slot = "8")]
	public virtual string KJKJADLNIBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7A29A00", Offset = "0x7A28400", VA = "0x187A29A00", Slot = "9")]
	public void KLFMDMIOCAD(StringBuilder AMHCDBILPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7A29920", Offset = "0x7A28320", VA = "0x187A29920", Slot = "10")]
	public void EFIBDFNBMMD(StringBuilder AMHCDBILPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7A29CB0", Offset = "0x7A286B0", VA = "0x187A29CB0", Slot = "11")]
	public void NLOJOBDKBHA(StringBuilder AMHCDBILPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A29DD0", Offset = "0x7A287D0", VA = "0x187A29DD0", Slot = "12")]
	public void NMLBLMOLBCJ(StringBuilder AMHCDBILPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A29F30", Offset = "0x7A28930", VA = "0x187A29F30")]
	public static void PJNOHBMPNJK(StringBuilder AMHCDBILPAL, string NEADOILGEFJ, string CLCHKFCEEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A36670", Offset = "0x6A35070", VA = "0x186A36670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BIIINANGMJA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7A28330", Offset = "0x7A26D30", VA = "0x187A28330")]
	public BIIINANGMJA(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NIFMAHIOCID<TErr> : BIIINANGMJA where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr BBMMOBKKFAK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x51AFC90", Offset = "0x51AE690", VA = "0x1851AFC90")]
	private NIFMAHIOCID([In] TErr IBMADKAODCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x51AFBC0", Offset = "0x51AE5C0", VA = "0x1851AFBC0")]
	public static NIFMAHIOCID<TErr> DDDHPONDPCL([In] TErr IBMADKAODCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CECDAMNOKKD : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm ILNIOEIBKDJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool BHIKCABMDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool IIEBNIKFHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool LKPOGBKCOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A286A0", Offset = "0x7A270A0", VA = "0x187A286A0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long NHAANPHMDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7A28710", Offset = "0x7A27110", VA = "0x187A28710", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A28780", Offset = "0x7A27180", VA = "0x187A28780", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A28630", Offset = "0x7A27030", VA = "0x187A28630")]
	public CECDAMNOKKD(HashAlgorithm ILNIOEIBKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A28460", Offset = "0x7A26E60", VA = "0x187A28460", Slot = "35")]
	public override int Read(byte[] KGINKPKLCFG, int LMGBAALNFHC, int PGJKBFGEJNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7A28600", Offset = "0x7A27000", VA = "0x187A28600", Slot = "38")]
	public override void Write(byte[] KGINKPKLCFG, int LMGBAALNFHC, int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7A28500", Offset = "0x7A26F00", VA = "0x187A28500", Slot = "33")]
	public override long Seek(long LMGBAALNFHC, SeekOrigin JOCLDJFCONL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7A28590", Offset = "0x7A26F90", VA = "0x187A28590", Slot = "34")]
	public override void SetLength(long PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7A28390", Offset = "0x7A26D90", VA = "0x187A28390")]
	public byte[] ADIGJILKDHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ACEELKDBFDK
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KJKJADLNIBM();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CENGCFKJIFH();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LJADAAJOKBP<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HBGFGMLJJGN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string BLLBCNDIEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DMIFJLPKJDD<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static DMIFJLPKJDD<T>? ADIBCNHPDGF;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object LACKHJFDCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? DCCHHOCLPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool CAEEKBHLKNN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool IFMEABDJOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD09970", Offset = "0xD08370", VA = "0x180D09970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3F25BA0", Offset = "0x3F245A0", VA = "0x183F25BA0")]
	private static DMIFJLPKJDD<T> BLOLCOMBONB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3F26550", Offset = "0x3F24F50", VA = "0x183F26550")]
	private static void FCBNOHNFDKK(DMIFJLPKJDD<T> IHBJHPLKKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3F278D0", Offset = "0x3F262D0", VA = "0x183F278D0")]
	private DMIFJLPKJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3F26F70", Offset = "0x3F25970", VA = "0x183F26F70")]
	public static DMIFJLPKJDD<T> IDEDHGEBOCJ(ReadOnlyMemory<T> KIJJLGLBELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F26D60", Offset = "0x3F25760", VA = "0x183F26D60")]
	public static DMIFJLPKJDD<T> IDEDHGEBOCJ(IMemoryOwner<T> GGEICBODNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F27510", Offset = "0x3F25F10", VA = "0x183F27510")]
	public static void NAGLKOLHOJC(DMIFJLPKJDD<T> BCEAGIGBBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3F26050", Offset = "0x3F24A50", VA = "0x183F26050", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3F26B00", Offset = "0x3F25500", VA = "0x183F26B00")]
	public DMIFJLPKJDD<T> GAMFPBEINAD(IMemoryOwner<T> GGEICBODNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3F27410", Offset = "0x3F25E10", VA = "0x183F27410")]
	private void JCADNCCFPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3F26C10", Offset = "0x3F25610", VA = "0x183F26C10")]
	private DMIFJLPKJDD<T> IBLJMOPPCMC(DMIFJLPKJDD<T> IHBJHPLKKAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PPNHEJCBGLO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7A2AB00", Offset = "0x7A29500", VA = "0x187A2AB00")]
	public PPNHEJCBGLO(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AGFLGCKDAGO<TOk> : PPNHEJCBGLO where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk JAIMCIKEOLF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4FC78C0", Offset = "0x4FC62C0", VA = "0x184FC78C0")]
	private AGFLGCKDAGO([In] TOk GMNPMMEINEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4936850", Offset = "0x4935250", VA = "0x184936850")]
	public static AGFLGCKDAGO<TOk> DDDHPONDPCL([In] TOk GMNPMMEINEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct CEGCKGHHPPP<TOk, TErr> : IEquatable<CEGCKGHHPPP<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> EOFPBENOABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr BBMMOBKKFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk JAIMCIKEOLF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NLJFBHBLJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x65652B0", Offset = "0x6563CB0", VA = "0x1865652B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KMBADCGHGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6566380", Offset = "0x6564D80", VA = "0x186566380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6569910", Offset = "0x6568310", VA = "0x186569910")]
	internal CEGCKGHHPPP([In] TErr IBMADKAODCH, [In] TOk GMNPMMEINEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x65649D0", Offset = "0x65633D0", VA = "0x1865649D0")]
	public static CEGCKGHHPPP<TOk, TErr> MEJHLGKCEPL([In] TErr IBMADKAODCH)
	{
		return default(CEGCKGHHPPP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6565D00", Offset = "0x6564700", VA = "0x186565D00")]
	public static CEGCKGHHPPP<TOk, TErr> NAGLLDEGLBB([In] TOk GMNPMMEINEG)
	{
		return default(CEGCKGHHPPP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x364F460", Offset = "0x364DE60", VA = "0x18364F460")]
	public CEGCKGHHPPP<TOk?, UErr?> AFDJCFPDFFJ<UErr>()
	{
		return default(CEGCKGHHPPP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x36504E0", Offset = "0x364EEE0", VA = "0x1836504E0")]
	public CEGCKGHHPPP<UOk?, TErr?> CFNEMAAPOMK<UOk>()
	{
		return default(CEGCKGHHPPP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3650B40", Offset = "0x364F540", VA = "0x183650B40")]
	public CEGCKGHHPPP<UOk?, TErr?> HNCANNAFOPA<UOk>()
	{
		return default(CEGCKGHHPPP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3651CA0", Offset = "0x36506A0", VA = "0x183651CA0")]
	public CEGCKGHHPPP<TOk?, UErr?> MMCKEBPFKMK<UErr>()
	{
		return default(CEGCKGHHPPP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6564510", Offset = "0x6562F10", VA = "0x186564510")]
	public CEGCKGHHPPP<HGCBNLHKPOI, TErr> IOJLNIIOFKG()
	{
		return default(CEGCKGHHPPP<HGCBNLHKPOI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6563990", Offset = "0x6562390", VA = "0x186563990")]
	public static bool HFGMMLFJJJB([In] CEGCKGHHPPP<TOk, TErr> AKJAPDOPIOF, [In] CEGCKGHHPPP<TOk, TErr> CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6560B70", Offset = "0x655F570", VA = "0x186560B70", Slot = "4")]
	public bool Equals(CEGCKGHHPPP<TOk, TErr> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6560DC0", Offset = "0x655F7C0", VA = "0x186560DC0", Slot = "0")]
	public override bool Equals(object OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6562770", Offset = "0x6561170", VA = "0x186562770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x65692E0", Offset = "0x6567CE0", VA = "0x1865692E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class FFHEIOGKGKC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct ABOMENFMCPJ<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<CEGCKGHHPPP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<CEGCKGHHPPP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4855390", Offset = "0x4853D90", VA = "0x184855390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x48559D0", Offset = "0x48543D0", VA = "0x1848559D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x361DDE0", Offset = "0x361C7E0", VA = "0x18361DDE0")]
	public static CEGCKGHHPPP<TOk?, TErr?> JAIMCIKEOLF<TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [In] TOk GMNPMMEINEG)
	{
		return default(CEGCKGHHPPP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3620A50", Offset = "0x361F450", VA = "0x183620A50")]
	public static CEGCKGHHPPP<HGCBNLHKPOI, TErr?> JAIMCIKEOLF<TErr>([In] this CEGCKGHHPPP<HGCBNLHKPOI, TErr> IJPDNJELPLO)
	{
		return default(CEGCKGHHPPP<HGCBNLHKPOI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x361DDE0", Offset = "0x361C7E0", VA = "0x18361DDE0")]
	public static CEGCKGHHPPP<TOk?, TErr?> BBMMOBKKFAK<TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [In] TErr IBMADKAODCH)
	{
		return default(CEGCKGHHPPP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x36210F0", Offset = "0x361FAF0", VA = "0x1836210F0")]
	public static TOk? NFOEMNEKICH<TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3620780", Offset = "0x361F180", VA = "0x183620780")]
	[AsyncStateMachine(typeof(ABOMENFMCPJ<, >))]
	public static Task<TOk?>? INOENOIFHCD<TOk, TErr>(this Task<CEGCKGHHPPP<TOk, TErr>> IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3620470", Offset = "0x361EE70", VA = "0x183620470")]
	public static TErr? GMOPCJGGAGK<TErr, TOk>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x361F2F0", Offset = "0x361DCF0", VA = "0x18361F2F0")]
	public static bool FMEKCNDAPEK<TOk, TErr, UErr, UOk>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [Out] CEGCKGHHPPP<UOk, UErr> DMBIEAFFKGC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x361EBC0", Offset = "0x361D5C0", VA = "0x18361EBC0")]
	public static bool CJHGLNLBHML<TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [Out] TOk GMNPMMEINEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3620B60", Offset = "0x361F560", VA = "0x183620B60")]
	public static bool KGJMFFCINDJ<TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [Out][NotNullWhen(true)] TErr IBMADKAODCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x361EDF0", Offset = "0x361D7F0", VA = "0x18361EDF0")]
	public static bool EIFOABAFFEL<TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [Out][NotNullWhen(true)] TOk GMNPMMEINEG, [Out][NotNullWhen(false)] TErr IBMADKAODCH) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3620680", Offset = "0x361F080", VA = "0x183620680")]
	public static bool HBFILLKKDJN<TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [Out][NotNullWhen(true)] TOk GMNPMMEINEG, [Out] CEGCKGHHPPP<TOk, TErr> DMBIEAFFKGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x361F420", Offset = "0x361DE20", VA = "0x18361F420")]
	public static bool FMEKCNDAPEK<TOk, TErr, UErr, UOk>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [Out][NotNullWhen(true)] TOk GMNPMMEINEG, [Out] CEGCKGHHPPP<UOk, UErr> DMBIEAFFKGC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3621570", Offset = "0x361FF70", VA = "0x183621570")]
	public static bool PMJHGDNKADJ<TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [Out][NotNullWhen(true)] TOk GMNPMMEINEG, [Out] CEGCKGHHPPP<HGCBNLHKPOI, TErr> DMBIEAFFKGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x361E610", Offset = "0x361D010", VA = "0x18361E610")]
	public static CEGCKGHHPPP<UOk, UErr> CGDEOOHAHMC<UOk, UErr, TOk, TErr>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, [In] CEGCKGHHPPP<UOk, UErr> FOAJJFFCIFO) where TOk : UOk where TErr : UErr
	{
		return default(CEGCKGHHPPP<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x361DF50", Offset = "0x361C950", VA = "0x18361DF50")]
	public static CEGCKGHHPPP<TOk?[]?, TErr?> CBFOLCHEOLP<TOk, TErr>(this IEnumerable<CEGCKGHHPPP<TOk, TErr>> IJPDNJELPLO)
	{
		return default(CEGCKGHHPPP<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3620C30", Offset = "0x361F630", VA = "0x183620C30")]
	public static CEGCKGHHPPP<UOk?, TErr?> MCEOBLJGFIN<UOk, TErr, TOk>([In] this CEGCKGHHPPP<TOk, TErr> IJPDNJELPLO, Func<TOk, UOk> LGAEGJEJFFC)
	{
		return default(CEGCKGHHPPP<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KIGEHIPMBOA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD8F0", Offset = "0x3BBC2F0", VA = "0x183BBD8F0")]
	public static CEGCKGHHPPP<TOk, T> JAIMCIKEOLF<TOk>([In] TOk GMNPMMEINEG) where TOk : notnull
	{
		return default(CEGCKGHHPPP<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4E02020", Offset = "0x4E00A20", VA = "0x184E02020")]
	public static CEGCKGHHPPP<HGCBNLHKPOI, T> JAIMCIKEOLF()
	{
		return default(CEGCKGHHPPP<HGCBNLHKPOI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD8F0", Offset = "0x3BBC2F0", VA = "0x183BBD8F0")]
	public static CEGCKGHHPPP<T, TErr> BBMMOBKKFAK<TErr>([In] TErr IBMADKAODCH) where TErr : notnull
	{
		return default(CEGCKGHHPPP<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct CKJHJKENENG<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly JMHKHGLEGLA AFLHELFGIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> LBPOFNAAOJN;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EA86F0", Offset = "0x4EA70F0", VA = "0x184EA86F0")]
	public static CKJHJKENENG<TKey, TValue> DDDHPONDPCL(string OJFCDDMGKNP)
	{
		return default(CKJHJKENENG<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA88B0", Offset = "0x4EA72B0", VA = "0x184EA88B0")]
	internal CKJHJKENENG(Dictionary<TKey, TValue> PPJFMHBDGNA, JMHKHGLEGLA HHMJKHKPOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8810", Offset = "0x4EA7210", VA = "0x184EA8810")]
	public MMDFDHELAMN<TKey, TValue> JDFAJJLPCCD([Out] Dictionary<TKey, TValue> PPJFMHBDGNA)
	{
		return default(MMDFDHELAMN<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct MMDFDHELAMN<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> LBPOFNAAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly FGOKKMJCBCC OPCDAFLAOCA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x28A5D70", Offset = "0x28A4770", VA = "0x1828A5D70")]
	internal MMDFDHELAMN(Dictionary<TKey, TValue> PPJFMHBDGNA, FGOKKMJCBCC CHLEACBACOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x48876D0", Offset = "0x48860D0", VA = "0x1848876D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct LBPAGFIDENO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly JMHKHGLEGLA AFLHELFGIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> LBPOFNAAOJN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4EA86F0", Offset = "0x4EA70F0", VA = "0x184EA86F0")]
	public static LBPAGFIDENO<T> DDDHPONDPCL(string OJFCDDMGKNP)
	{
		return default(LBPAGFIDENO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4EA88B0", Offset = "0x4EA72B0", VA = "0x184EA88B0")]
	internal LBPAGFIDENO(HashSet<T> PPJFMHBDGNA, JMHKHGLEGLA HHMJKHKPOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8810", Offset = "0x4EA7210", VA = "0x184EA8810")]
	public GEDGECHKBAO<T> JDFAJJLPCCD([Out] HashSet<T> PPJFMHBDGNA)
	{
		return default(GEDGECHKBAO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct GEDGECHKBAO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> LBPOFNAAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FGOKKMJCBCC OPCDAFLAOCA;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28A5D70", Offset = "0x28A4770", VA = "0x1828A5D70")]
	internal GEDGECHKBAO(HashSet<T> PPJFMHBDGNA, FGOKKMJCBCC CHLEACBACOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x48876D0", Offset = "0x48860D0", VA = "0x1848876D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BFBOIFMCCLO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JMHKHGLEGLA AFLHELFGIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> LBPOFNAAOJN;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4EA86F0", Offset = "0x4EA70F0", VA = "0x184EA86F0")]
	public static BFBOIFMCCLO<T> DDDHPONDPCL(string OJFCDDMGKNP)
	{
		return default(BFBOIFMCCLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4EA88B0", Offset = "0x4EA72B0", VA = "0x184EA88B0")]
	internal BFBOIFMCCLO(Stack<T> PPJFMHBDGNA, JMHKHGLEGLA HHMJKHKPOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8810", Offset = "0x4EA7210", VA = "0x184EA8810")]
	public HMMILLPICHD<T> JDFAJJLPCCD([Out] Stack<T> PPJFMHBDGNA)
	{
		return default(HMMILLPICHD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct HMMILLPICHD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> LBPOFNAAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly FGOKKMJCBCC OPCDAFLAOCA;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28A5D70", Offset = "0x28A4770", VA = "0x1828A5D70")]
	internal HMMILLPICHD(Stack<T> PPJFMHBDGNA, FGOKKMJCBCC CHLEACBACOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x48876D0", Offset = "0x48860D0", VA = "0x1848876D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class ABDAOPLOLHD<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct BKBJDMGKNLD : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly ABDAOPLOLHD<T> PJGJHAFIKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int JEOGKIGFKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool NOALGCLIKEA;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x25871C0", Offset = "0x2585BC0", VA = "0x1825871C0")]
		public BKBJDMGKNLD(ABDAOPLOLHD<T> GBDMJHAPPHC, int HEOLPAJMKMD, bool PECBALEFDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6487FB0", Offset = "0x64869B0", VA = "0x186487FB0")]
		public ABDAOPLOLHD<T>.OJLFDJOLPJJ KCFKLFFNEEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x64880A0", Offset = "0x6486AA0", VA = "0x1864880A0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x64880A0", Offset = "0x6486AA0", VA = "0x1864880A0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class OJLFDJOLPJJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly ABDAOPLOLHD<T> PJGJHAFIKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int CCEKCDEAOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int NDLDDFHBOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool NOALGCLIKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool LMAFOEKEMGL;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x52E4830", Offset = "0x52E3230", VA = "0x1852E4830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x52E4960", Offset = "0x52E3360", VA = "0x1852E4960", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x52E49D0", Offset = "0x52E33D0", VA = "0x1852E49D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x52E4F70", Offset = "0x52E3970", VA = "0x1852E4F70")]
		public OJLFDJOLPJJ(ABDAOPLOLHD<T> GBDMJHAPPHC, int HEOLPAJMKMD, bool PECBALEFDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x52E4870", Offset = "0x52E3270", VA = "0x1852E4870", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x52E4900", Offset = "0x52E3300", VA = "0x1852E4900", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FGFNNJNLLID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FGFNNJNLLID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x47C4440", Offset = "0x47C2E40", VA = "0x1847C4440")]
		internal T JAOIKODCLIP(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] PFIILBNCAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int NDLDDFHBOLN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PECHNPNMCJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4853F10", Offset = "0x4852910", VA = "0x184853F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T GNNLOKFDOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x47A4D40", Offset = "0x47A3740", VA = "0x1847A4D40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T AJHMAPOACNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4853F70", Offset = "0x4852970", VA = "0x184853F70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4854090", Offset = "0x4852A90", VA = "0x184854090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x247D860", Offset = "0x247C260", VA = "0x18247D860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1999B60", Offset = "0x1998560", VA = "0x181999B60")]
	private static int MPLIDADKEKA(int DOAKEFBOPIA, int ENHEICOLGJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4854600", Offset = "0x4853000", VA = "0x184854600")]
	public ABDAOPLOLHD(int PICLDLMFMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4854300", Offset = "0x4852D00", VA = "0x184854300")]
	public ABDAOPLOLHD(int PICLDLMFMMM, Func<T> KGLGOMDOBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4854560", Offset = "0x4852F60", VA = "0x184854560")]
	public ABDAOPLOLHD(T[] NNLLAHLBLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x48542D0", Offset = "0x4852CD0", VA = "0x1848542D0")]
	public void PCNKDFMADCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4854210", Offset = "0x4852C10", VA = "0x184854210")]
	public IEnumerable<T> NKMLAOGHIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4854170", Offset = "0x4852B70", VA = "0x184854170")]
	public ABDAOPLOLHD<T>.OJLFDJOLPJJ KCFKLFFNEEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4835BB0", Offset = "0x48345B0", VA = "0x184835BB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4835BB0", Offset = "0x48345B0", VA = "0x184835BB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HNGGKHILHDD
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x36A3110", Offset = "0x36A1B10", VA = "0x1836A3110")]
	public static ABDAOPLOLHD<T> DDDHPONDPCL<T>(int PICLDLMFMMM, Func<T> KGLGOMDOBHI) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B500", Offset = "0x7A29F00", VA = "0x187A2B500")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B4C0", Offset = "0x7A29EC0", VA = "0x187A2B4C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B4E0", Offset = "0x7A29EE0", VA = "0x187A2B4E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B520", Offset = "0x7A29F20", VA = "0x187A2B520")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B4A0", Offset = "0x7A29EA0", VA = "0x187A2B4A0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2693580", Offset = "0x2691F80", VA = "0x182693580")]
		public RRColor(float LIFAHFCIJCG, float ELGCFHPJOFO, float LKKBJAKGIGL, float KEEADJCBJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x78F5550", Offset = "0x78F3F50", VA = "0x1878F5550", Slot = "4")]
		public bool Equals(RRColor OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B0F0", Offset = "0x7A29AF0", VA = "0x187A2B0F0", Slot = "0")]
		public override bool Equals(object OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B1F0", Offset = "0x7A29BF0", VA = "0x187A2B1F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A2B270", Offset = "0x7A29C70", VA = "0x187A2B270", Slot = "5")]
		public string ToString(string GKPIBGBGJLP, IFormatProvider LGNOAONHIHN)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B090", Offset = "0x7A29A90", VA = "0x187A2B090")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B030", Offset = "0x7A29A30", VA = "0x187A2B030")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B060", Offset = "0x7A29A60", VA = "0x187A2B060")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B0C0", Offset = "0x7A29AC0", VA = "0x187A2B0C0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7A2B000", Offset = "0x7A29A00", VA = "0x187A2B000")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x59D39A0", Offset = "0x59D23A0", VA = "0x1859D39A0")]
		public RRColor32(byte LIFAHFCIJCG, byte ELGCFHPJOFO, byte LKKBJAKGIGL, byte KEEADJCBJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2064E20", Offset = "0x2063820", VA = "0x182064E20", Slot = "4")]
		public bool Equals(RRColor32 OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7A2AB60", Offset = "0x7A29560", VA = "0x187A2AB60", Slot = "0")]
		public override bool Equals(object OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x11F8C60", Offset = "0x11F7660", VA = "0x1811F8C60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A2ABE0", Offset = "0x7A295E0", VA = "0x187A2ABE0")]
		public static RRColor32 MEHFEEABIDG(RRColor LHJMDMLADDA)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7A2AD30", Offset = "0x7A29730", VA = "0x187A2AD30")]
		public static RRColor MEHFEEABIDG(RRColor32 LHJMDMLADDA)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7A2ADA0", Offset = "0x7A297A0", VA = "0x187A2ADA0", Slot = "5")]
		public string ToString(string GKPIBGBGJLP, IFormatProvider LGNOAONHIHN)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class CLMFAPEPDHD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct GPICBLAILGK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly CLMFAPEPDHD<T> LAECCMODDPE;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T ABKPALEDJBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x48FE490", Offset = "0x48FCE90", VA = "0x1848FE490")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x48FE460", Offset = "0x48FCE60", VA = "0x1848FE460", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
		public GPICBLAILGK(CLMFAPEPDHD<T> LAECCMODDPE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MOLHAKNADMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<GPICBLAILGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CLMFAPEPDHD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x51455F0", Offset = "0x5143FF0", VA = "0x1851455F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x48CB620", Offset = "0x48CA020", VA = "0x1848CB620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly SemaphoreSlim ADJINFMCHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private T CPNFMFAECNK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6587ED0", Offset = "0x65868D0", VA = "0x186587ED0")]
	public CLMFAPEPDHD([In] T CPNFMFAECNK, int PBIJEIFPFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6588010", Offset = "0x6586A10", VA = "0x186588010")]
	public CLMFAPEPDHD([In] T CPNFMFAECNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x65879B0", Offset = "0x65863B0", VA = "0x1865879B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6587E90", Offset = "0x6586890", VA = "0x186587E90")]
	public GPICBLAILGK LFDBIJBMBMG()
	{
		return default(GPICBLAILGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6587D50", Offset = "0x6586750", VA = "0x186587D50")]
	[AsyncStateMachine(typeof(CLMFAPEPDHD<>.MOLHAKNADMM))]
	public Task<CLMFAPEPDHD<T>.GPICBLAILGK> FADKJIJKKDM(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6587E70", Offset = "0x6586870", VA = "0x186587E70")]
	public void KPFMEHCCJFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class KCHMMMNMPMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7A29530", Offset = "0x7A27F30", VA = "0x187A29530")]
	public static CLMFAPEPDHD<HGCBNLHKPOI> DDDHPONDPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x36A4440", Offset = "0x36A2E40", VA = "0x1836A4440")]
	public static CLMFAPEPDHD<T> DDDHPONDPCL<T>([In] T CPNFMFAECNK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class PMDDOOKCNGL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct BAENKGAMIJM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly PMDDOOKCNGL<T> EJKLOFFEKJD;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T ABKPALEDJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x512B100", Offset = "0x5129B00", VA = "0x18512B100")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6457650", Offset = "0x6456050", VA = "0x186457650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
		internal BAENKGAMIJM(PMDDOOKCNGL<T> LAECCMODDPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct MFHAKMFBGFH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly PMDDOOKCNGL<T> EJKLOFFEKJD;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T ABKPALEDJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x512B100", Offset = "0x5129B00", VA = "0x18512B100")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x512B0B0", Offset = "0x5129AB0", VA = "0x18512B0B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
		internal MFHAKMFBGFH(PMDDOOKCNGL<T> LAECCMODDPE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NPOCGNPJIGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<MFHAKMFBGFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public PMDDOOKCNGL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private CLMFAPEPDHD<HGCBNLHKPOI>.GPICBLAILGK <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<CLMFAPEPDHD<HGCBNLHKPOI>.GPICBLAILGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x51CA260", Offset = "0x51C8C60", VA = "0x1851CA260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x48CB620", Offset = "0x48CA020", VA = "0x1848CB620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CLMFAPEPDHD<int> KGNNNLFGPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CLMFAPEPDHD<HGCBNLHKPOI> EPBEGNILIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CLMFAPEPDHD<HGCBNLHKPOI> CGAEGIFILIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T JLNDJOILDKG;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x53E32C0", Offset = "0x53E1CC0", VA = "0x1853E32C0")]
	internal PMDDOOKCNGL(CLMFAPEPDHD<int> PNKHIADBNGB, CLMFAPEPDHD<HGCBNLHKPOI> LOGJLIHNFFG, CLMFAPEPDHD<HGCBNLHKPOI> BOCLGHDNABC, [In] T CPNFMFAECNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x53E24D0", Offset = "0x53E0ED0", VA = "0x1853E24D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x53E2CA0", Offset = "0x53E16A0", VA = "0x1853E2CA0")]
	public BAENKGAMIJM GEMJEIFKNLH()
	{
		return default(BAENKGAMIJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x53E2830", Offset = "0x53E1230", VA = "0x1853E2830")]
	public MFHAKMFBGFH EIMCNBJPGEJ()
	{
		return default(MFHAKMFBGFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x53E2F80", Offset = "0x53E1980", VA = "0x1853E2F80")]
	[AsyncStateMachine(typeof(PMDDOOKCNGL<>.NPOCGNPJIGA))]
	public Task<PMDDOOKCNGL<T>.MFHAKMFBGFH> HJAEOPGHBCE(CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EHCONIHDBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7A28E20", Offset = "0x7A27820", VA = "0x187A28E20")]
	public static PMDDOOKCNGL<HGCBNLHKPOI> DDDHPONDPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x34BDFA0", Offset = "0x34BC9A0", VA = "0x1834BDFA0")]
	public static PMDDOOKCNGL<T> DDDHPONDPCL<T>([In] T CPNFMFAECNK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class NHEEHIFKDCE<TData> : MJKMNFLLIGE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly string JKDKJBPPNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly TData LPLAAGCJFBO;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
	public override string CENGCFKJIFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x51AC670", Offset = "0x51AB070", VA = "0x1851AC670")]
	internal NHEEHIFKDCE(string FLPDJFEEMLN, [In] TData DFPGGEDGGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class ONAKIDNMLAI
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A5E0", Offset = "0x7A28FE0", VA = "0x187A2A5E0")]
	public static NHEEHIFKDCE<HGCBNLHKPOI> DDDHPONDPCL(string FLPDJFEEMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x33B88C0", Offset = "0x33B72C0", VA = "0x1833B88C0")]
	public static NHEEHIFKDCE<TData> DDDHPONDPCL<TData>(string FLPDJFEEMLN, [In] TData DFPGGEDGGGN) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class JMHKHGLEGLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	internal bool HJEAAKGODGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string EGDIMEHKNIK;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD959A0", Offset = "0xD943A0", VA = "0x180D959A0")]
	private JMHKHGLEGLA(bool DJGKFNJJKBG, string HIBOKAJGLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7A29350", Offset = "0x7A27D50", VA = "0x187A29350")]
	public static JMHKHGLEGLA DDDHPONDPCL(string HIBOKAJGLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7A293C0", Offset = "0x7A27DC0", VA = "0x187A293C0")]
	public FGOKKMJCBCC JDFAJJLPCCD()
	{
		return default(FGOKKMJCBCC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct FGOKKMJCBCC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly JMHKHGLEGLA NKIIFECOEHK;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
	internal FGOKKMJCBCC(JMHKHGLEGLA OJFCDDMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7A29070", Offset = "0x7A27A70", VA = "0x187A29070", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class CDGOMBJIGND<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class JKMOECLBOEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JKMOECLBOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4D029E0", Offset = "0x4D013E0", VA = "0x184D029E0")]
		internal int ABFKCECNEBD(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HashSet<T>? IOIPEHCFFMD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> NLCDKGGDPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x655EB60", Offset = "0x655D560", VA = "0x18655EB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IMJFLDMBKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x655E950", Offset = "0x655D350", VA = "0x18655E950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9B5550", Offset = "0x9B3F50", VA = "0x1809B5550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x655E9A0", Offset = "0x655D3A0", VA = "0x18655E9A0")]
	public bool HEHCILJMFIP(T GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x655E6B0", Offset = "0x655D0B0", VA = "0x18655E6B0")]
	public bool CBCJJMKDJJC(T GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x655E820", Offset = "0x655D220", VA = "0x18655E820")]
	public bool EGACGLIMIFH(T GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x655E870", Offset = "0x655D270", VA = "0x18655E870")]
	public void FLIPKGKFCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x655EBA0", Offset = "0x655D5A0", VA = "0x18655EBA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public CDGOMBJIGND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class OPHEEGEKGGC
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class JPENJBAGEJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JPENJBAGEJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7A29480", Offset = "0x7A27E80", VA = "0x187A29480")]
		internal int ABFKCECNEBD(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<object>? IOIPEHCFFMD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> NLCDKGGDPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A8C0", Offset = "0x7A292C0", VA = "0x187A2A8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool IMJFLDMBKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A7D0", Offset = "0x7A291D0", VA = "0x187A2A7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9B5550", Offset = "0x9B3F50", VA = "0x1809B5550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A7E0", Offset = "0x7A291E0", VA = "0x187A2A7E0")]
	public bool HEHCILJMFIP(object GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A660", Offset = "0x7A29060", VA = "0x187A2A660")]
	public bool CBCJJMKDJJC(object GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A700", Offset = "0x7A29100", VA = "0x187A2A700")]
	public bool EGACGLIMIFH(object GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A760", Offset = "0x7A29160", VA = "0x187A2A760")]
	public void FLIPKGKFCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A950", Offset = "0x7A29350", VA = "0x187A2A950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public OPHEEGEKGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class OLCCGHGGJNO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct CODBBBBDBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float DIODDCDNNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T ABKPALEDJBA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<object, CODBBBBDBGP> LCGNOGHMHOC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T CGAFGCMOAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x187FC80", Offset = "0x187E680", VA = "0x18187FC80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x187F020", Offset = "0x187DA20", VA = "0x18187F020", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? BJIJEOEPLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5530", Offset = "0x9B3F30", VA = "0x1809B5530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OALDOILAGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x519AA90", Offset = "0x5199490", VA = "0x18519AA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x52E79E0", Offset = "0x52E63E0", VA = "0x1852E79E0")]
	public bool EDHPJFLGKJG(T PPJFMHBDGNA, object GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x518D640", Offset = "0x518C040", VA = "0x18518D640")]
	public bool EPDPGJBDDAF(object GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5033080", Offset = "0x5031A80", VA = "0x185033080")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x52E9A30", Offset = "0x52E8430", VA = "0x1852E9A30")]
	public bool OCHHJJBEIMP(object GNAAILLDOKI, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x52E8870", Offset = "0x52E7270", VA = "0x1852E8870")]
	[OJHKKHAABNM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JMHDAEPMAIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x518DD70", Offset = "0x518C770", VA = "0x18518DD70")]
	public OLCCGHGGJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class MKCEGHKMBOG : GNPIHNJMIDI<MDCBAMNMOAI>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class FPCFGLPJHAO : IEqualityComparer<MDCBAMNMOAI>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		internal static readonly FPCFGLPJHAO LALLOKGAEJH;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7A292C0", Offset = "0x7A27CC0", VA = "0x187A292C0", Slot = "4")]
		public bool Equals(MDCBAMNMOAI CJBFFOKBLHB, MDCBAMNMOAI CNBLFOFLDDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CBD0", Offset = "0x6C1B5D0", VA = "0x186C1CBD0", Slot = "5")]
		public int GetHashCode(MDCBAMNMOAI OIIGDBLKEDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FPCFGLPJHAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A230", Offset = "0x7A28C30", VA = "0x187A2A230")]
	public MKCEGHKMBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A180", Offset = "0x7A28B80", VA = "0x187A2A180", Slot = "4")]
	public override bool HEHCILJMFIP(MDCBAMNMOAI GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A040", Offset = "0x7A28A40", VA = "0x187A2A040", Slot = "5")]
	public override bool CBCJJMKDJJC(MDCBAMNMOAI GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A0F0", Offset = "0x7A28AF0", VA = "0x187A2A0F0")]
	private static void FGMLENIJNMC(MDCBAMNMOAI GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1761070", Offset = "0x175FA70", VA = "0x181761070", Slot = "6")]
	protected override string TokenToString(MDCBAMNMOAI GNAAILLDOKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class MDCBAMNMOAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly string GILNPGJIIPO;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public MDCBAMNMOAI(string GILNPGJIIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7A298D0", Offset = "0x7A282D0", VA = "0x187A298D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class GNPIHNJMIDI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IEqualityComparer<T> KADCJBCBGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private HashSet<T>? IOIPEHCFFMD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IMJFLDMBKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x48F4720", Offset = "0x48F3120", VA = "0x1848F4720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xB86090", Offset = "0xB84A90", VA = "0x180B86090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xBFFBB0", Offset = "0xBFE5B0", VA = "0x180BFFBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x48F50F0", Offset = "0x48F3AF0", VA = "0x1848F50F0")]
	public GNPIHNJMIDI(IEqualityComparer<T> KADCJBCBGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x48F4760", Offset = "0x48F3160", VA = "0x1848F4760", Slot = "4")]
	public virtual bool HEHCILJMFIP(T GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x48F44D0", Offset = "0x48F2ED0", VA = "0x1848F44D0", Slot = "5")]
	public virtual bool CBCJJMKDJJC(T GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x48F4640", Offset = "0x48F3040", VA = "0x1848F4640")]
	public void FLIPKGKFCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x48F4B00", Offset = "0x48F3500", VA = "0x1848F4B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class BMLDEAJOFHA<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<WeakReference<T>>? IOIPEHCFFMD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IMJFLDMBKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6495610", Offset = "0x6494010", VA = "0x186495610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6495430", Offset = "0x6493E30", VA = "0x186495430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6495730", Offset = "0x6494130", VA = "0x186495730")]
	public void HEHCILJMFIP(T GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6495290", Offset = "0x6493C90", VA = "0x186495290")]
	public void CBCJJMKDJJC(T GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x64955D0", Offset = "0x6493FD0", VA = "0x1864955D0")]
	public void FLIPKGKFCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x64959A0", Offset = "0x64943A0", VA = "0x1864959A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public BMLDEAJOFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class LLHIEDBNMEM
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x367CF20", Offset = "0x367B920", VA = "0x18367CF20")]
	public static void JDKMPEEHLEK<T>(this List<T> FMFEHIEKOMI, int DOAKEFBOPIA) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class NECODKJDKIB<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct HNBGDPEOLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float DIODDCDNNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public T ABKPALEDJBA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<MDCBAMNMOAI, HNBGDPEOLMB> LCGNOGHMHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EqualityComparer<T> ONKMALKALDP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T CGAFGCMOAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9AED90", Offset = "0x9AD790", VA = "0x1809AED90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9AED70", Offset = "0x9AD770", VA = "0x1809AED70", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private MDCBAMNMOAI? BJIJEOEPLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9B6FD0", Offset = "0x9B59D0", VA = "0x1809B6FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OALDOILAGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x519AA90", Offset = "0x5199490", VA = "0x18519AA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x519A870", Offset = "0x5199270", VA = "0x18519A870")]
	public bool EDHPJFLGKJG(T PPJFMHBDGNA, MDCBAMNMOAI GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x518D640", Offset = "0x518C040", VA = "0x18518D640")]
	public bool EPDPGJBDDAF(MDCBAMNMOAI GNAAILLDOKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5033080", Offset = "0x5031A80", VA = "0x185033080")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x519B120", Offset = "0x5199B20", VA = "0x18519B120")]
	public bool OCHHJJBEIMP(MDCBAMNMOAI GNAAILLDOKI, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x519AAF0", Offset = "0x51994F0", VA = "0x18519AAF0")]
	[OJHKKHAABNM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JMHDAEPMAIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x519B1B0", Offset = "0x5199BB0", VA = "0x18519B1B0")]
	public NECODKJDKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class KOALPBFCFAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<object, float> LCGNOGHMHOC;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float KFJIFPEMNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xE5FD30", Offset = "0xE5E730", VA = "0x180E5FD30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xE5FD40", Offset = "0xE5E740", VA = "0x180E5FD40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7A295A0", Offset = "0x7A27FA0", VA = "0x187A295A0")]
	public void EDHPJFLGKJG(float PPJFMHBDGNA, object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7A29610", Offset = "0x7A28010", VA = "0x187A29610")]
	public void EPDPGJBDDAF(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7A297B0", Offset = "0x7A281B0", VA = "0x187A297B0")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7A29680", Offset = "0x7A28080", VA = "0x187A29680")]
	private void IODAFCGNGMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7A29800", Offset = "0x7A28200", VA = "0x187A29800")]
	public KOALPBFCFAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface JMDKONJHDFB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FDMLDNIKPAA FIJMKDMBBFC;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BDLALLLEJJP : JMDKONJHDFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct DOKCMFKNKLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float MBHBHBLMGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float LLJAPGMKKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal readonly bool BFBBKCKIDFH;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float FPLMNCHJHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7A28B50", Offset = "0x7A27550", VA = "0x187A28B50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7A28CC0", Offset = "0x7A276C0", VA = "0x187A28CC0")]
		public DOKCMFKNKLA(float GJCFLJFIOAP, float BKICKHECIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7A28B60", Offset = "0x7A27560", VA = "0x187A28B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class FAPECCIFPLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public BDLALLLEJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FAPECCIFPLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7A28FD0", Offset = "0x7A279D0", VA = "0x187A28FD0")]
		internal void JGAOAMAKHGO(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly int CIIHPLFOGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int HAJIOKINPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly JMDKONJHDFB[] JFEAGACMABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly FDMLDNIKPAA[] MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly DOKCMFKNKLA[] EOEIMKEGKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private DOKCMFKNKLA BLGCPLONKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FOAOAEBMOMB JBGIBFNPBFO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event FDMLDNIKPAA FIJMKDMBBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7A27F90", Offset = "0x7A26990", VA = "0x187A27F90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7A280E0", Offset = "0x7A26AE0", VA = "0x187A280E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7A281A0", Offset = "0x7A26BA0", VA = "0x187A281A0")]
	public BDLALLLEJJP(int CIIHPLFOGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7A28050", Offset = "0x7A26A50", VA = "0x187A28050")]
	public FOAOAEBMOMB JHCKOBOAMGA(DOKCMFKNKLA BAKNOLAPDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7A27A10", Offset = "0x7A26410", VA = "0x187A27A10")]
	public void AFPBOLKBNCC(JMDKONJHDFB BKMJBLGDPMP, [Optional] DOKCMFKNKLA JEHGBEHODBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7A27E80", Offset = "0x7A26880", VA = "0x187A27E80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void FDMLDNIKPAA(float IHNAEJKGEHJ);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class OMCNPGFCAPA
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class EKNNCEAHMGH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly JMDKONJHDFB LHAMNCPGGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly FDMLDNIKPAA PCKPGHHEKOC;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7A28F40", Offset = "0x7A27940", VA = "0x187A28F40")]
		public EKNNCEAHMGH(JMDKONJHDFB LHAMNCPGGAD, FDMLDNIKPAA PCKPGHHEKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7A28EF0", Offset = "0x7A278F0", VA = "0x187A28EF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A570", Offset = "0x7A28F70", VA = "0x187A2A570")]
	internal static bool IFMPIDGOIOI(float KEEADJCBJCP, float LKKBJAKGIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7A16500", Offset = "0x7A14F00", VA = "0x187A16500")]
	internal static float OMFBLHMONJC(float KEEADJCBJCP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A4B0", Offset = "0x7A28EB0", VA = "0x187A2A4B0")]
	public static IDisposable GMKGMOPIOBD(this JMDKONJHDFB LHAMNCPGGAD, FDMLDNIKPAA PCKPGHHEKOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FOAOAEBMOMB : JMDKONJHDFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private float IHNAEJKGEHJ;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float KNDMCDNNLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7A29130", Offset = "0x7A27B30", VA = "0x187A29130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FDMLDNIKPAA? FIJMKDMBBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7A29090", Offset = "0x7A27A90", VA = "0x187A29090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7A29220", Offset = "0x7A27C20", VA = "0x187A29220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public FOAOAEBMOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NELNDHCJAHH<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHGGLHHAFJE<T> KFLMIKHDEOF([Out] T PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPINELCICKH();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NKIBDONFBOB<T> : NELNDHCJAHH<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ConcurrentStack<T> GOHIAOKGBHK;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x51B72E0", Offset = "0x51B5CE0", VA = "0x1851B72E0", Slot = "4")]
	public OHGGLHHAFJE<T> KFLMIKHDEOF([Out] T PPJFMHBDGNA)
	{
		return default(OHGGLHHAFJE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x51B7260", Offset = "0x51B5C60", VA = "0x1851B7260")]
	public void HPODIEKJDDB(T EHNOLKKHKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x435B260", Offset = "0x4359C60", VA = "0x18435B260", Slot = "5")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
	protected virtual void GJHHKJCAJDO(T FMHKAEAMPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x51B71C0", Offset = "0x51B5BC0", VA = "0x1851B71C0")]
	private T BLCCCENAIKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x51B7380", Offset = "0x51B5D80", VA = "0x1851B7380")]
	public NKIBDONFBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct OHGGLHHAFJE<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly T EHNOLKKHKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NKIBDONFBOB<T> KBEOLPOGFHP;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
	internal OHGGLHHAFJE(T PPJFMHBDGNA, NKIBDONFBOB<T> KBEOLPOGFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x52D6FC0", Offset = "0x52D59C0", VA = "0x1852D6FC0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NMNLGKNBJKM : NKIBDONFBOB<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly NMNLGKNBJKM LALLOKGAEJH;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A2A0", Offset = "0x7A28CA0", VA = "0x187A2A2A0")]
	public static OHGGLHHAFJE<StringBuilder> BLCCCENAIKI([Out] StringBuilder PPJFMHBDGNA)
	{
		return default(OHGGLHHAFJE<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A340", Offset = "0x7A28D40", VA = "0x187A2A340", Slot = "6")]
	protected override void GJHHKJCAJDO(StringBuilder FMHKAEAMPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A3F0", Offset = "0x7A28DF0", VA = "0x187A2A3F0")]
	public NMNLGKNBJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JNODHIBPIGN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x735B680", Offset = "0x735A080", VA = "0x18735B680")]
	public JNODHIBPIGN(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class KKDPNGOKMJD<TKey, TValue> : EEPINIKFLPC<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, HFKDNKJPDOB where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class ACLMPJEDCOE : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public KKDPNGOKMJD<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x187FC80", Offset = "0x187E680", VA = "0x18187FC80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x475BA70", Offset = "0x475A470", VA = "0x18475BA70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public ACLMPJEDCOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x475BB10", Offset = "0x475A510", VA = "0x18475BB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4857AE0", Offset = "0x48564E0", VA = "0x184857AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x48571B0", Offset = "0x4855BB0", VA = "0x1848571B0")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4857070", Offset = "0x4855A70", VA = "0x184857070")]
		private void EKCCALBOGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4857F60", Offset = "0x4856960", VA = "0x184857F60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly EEPINIKFLPC<TKey, TValue> GDLPJIGFGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IDictionary<TKey, TValue> OAMHMDIDAMK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4E07BE0", Offset = "0x4E065E0", VA = "0x184E07BE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool KMCAIMHLNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4E07DC0", Offset = "0x4E067C0", VA = "0x184E07DC0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4E08050", Offset = "0x4E06A50", VA = "0x184E08050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> KAIGPNAKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4E07E10", Offset = "0x4E06810", VA = "0x184E07E10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> FIGJBBINHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4E07F30", Offset = "0x4E06930", VA = "0x184E07F30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4E07A50", Offset = "0x4E06450", VA = "0x184E07A50")]
	public KKDPNGOKMJD(EEPINIKFLPC<TKey, TValue> GDLPJIGFGIH, [Optional] IDictionary<TKey, TValue>? OAMHMDIDAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4E054E0", Offset = "0x4E03EE0", VA = "0x184E054E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4E06DE0", Offset = "0x4E057E0", VA = "0x184E06DE0")]
	public void PGADAJJKNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4E05180", Offset = "0x4E03B80", VA = "0x184E05180", Slot = "9")]
	public void Add(TKey NJBPFCDJFGD, TValue PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4E06A90", Offset = "0x4E05490", VA = "0x184E06A90")]
	public void NIHACPGLLMA(TKey NJBPFCDJFGD, TValue PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4E04DE0", Offset = "0x4E037E0", VA = "0x184E04DE0")]
	public void APLPNPHNDAM(TKey NJBPFCDJFGD, TValue PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4E065F0", Offset = "0x4E04FF0", VA = "0x184E065F0")]
	public void NHFOMNGNGOC(TKey NJBPFCDJFGD, TValue PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4E06500", Offset = "0x4E04F00", VA = "0x184E06500")]
	public void MMIFHJLNNFN(TKey NJBPFCDJFGD, TValue PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4E07090", Offset = "0x4E05A90", VA = "0x184E07090", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4E072C0", Offset = "0x4E05CC0", VA = "0x184E072C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4E07620", Offset = "0x4E06020", VA = "0x184E07620", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4E05570", Offset = "0x4E03F70", VA = "0x184E05570", Slot = "8")]
	public bool ContainsKey(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4E05E00", Offset = "0x4E04800", VA = "0x184E05E00")]
	public bool EDKBOKIJKEI(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4E05F20", Offset = "0x4E04920", VA = "0x184E05F20")]
	public bool EPNLCCIFCNF(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4E06EF0", Offset = "0x4E058F0", VA = "0x184E06EF0", Slot = "10")]
	public bool Remove(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4E078B0", Offset = "0x4E062B0", VA = "0x184E078B0", Slot = "11")]
	public bool TryGetValue(TKey NJBPFCDJFGD, [Out] TValue PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4E056E0", Offset = "0x4E040E0", VA = "0x184E056E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NAKGFAINKPB, int JMDPMMMKOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C850", Offset = "0x4D9B250", VA = "0x184D9C850", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4E05FE0", Offset = "0x4E049E0", VA = "0x184E05FE0", Slot = "19")]
	[IteratorStateMachine(typeof(KKDPNGOKMJD<, >.ACLMPJEDCOE))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4E06D90", Offset = "0x4E05790", VA = "0x184E06D90", Slot = "21")]
	public bool OPNLJFBOADM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4E06140", Offset = "0x4E04B40", VA = "0x184E06140")]
	private TValue KGGLCEEFACE(TKey NJBPFCDJFGD)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface BPMLCGNPBLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string KOBLDKFNION
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface HFKDNKJPDOB
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OPNLJFBOADM();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface EEPINIKFLPC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HFKDNKJPDOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public sealed class AKJHEKJEJOA<TKey, TVal> : EEPINIKFLPC<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HFKDNKJPDOB where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate int KMIPOCEGAKE(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate void IOGJABJGMKL(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA, EACKOLKKNIF NBAKHABPJGI);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class FIJDEPOBEHG
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey BKFIOJPHBFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xEC09F0", Offset = "0xEBF3F0", VA = "0x180EC09F0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal ABKPALEDJBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB86090", Offset = "0xB84A90", VA = "0x180B86090")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xBFFBB0", Offset = "0xBFE5B0", VA = "0x180BFFBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int FPLMNCHJHFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC976B0", Offset = "0xC960B0", VA = "0x180C976B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xE7FEF0", Offset = "0xE7E8F0", VA = "0x180E7FEF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset ACHKCLHKCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x11CB770", Offset = "0x11CA170", VA = "0x1811CB770")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x11CAE50", Offset = "0x11C9850", VA = "0x1811CAE50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x47D4E20", Offset = "0x47D3820", VA = "0x1847D4E20")]
		public FIJDEPOBEHG(TKey NJBPFCDJFGD, TVal OILNFPPOKDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PFEAFIAOHOH : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AKJHEKJEJOA<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LinkedList<FIJDEPOBEHG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x187FC80", Offset = "0x187E680", VA = "0x18187FC80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x53D1230", Offset = "0x53CFC30", VA = "0x1853D1230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public PFEAFIAOHOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x438DBA0", Offset = "0x438C5A0", VA = "0x18438DBA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x53CF1F0", Offset = "0x53CDBF0", VA = "0x1853CF1F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x53CE5E0", Offset = "0x53CCFE0", VA = "0x1853CE5E0")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x53D1050", Offset = "0x53CFA50", VA = "0x1853D1050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public const int MGIIOMBLDCK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, LinkedListNode<FIJDEPOBEHG>> HBKAIMPOAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LinkedList<FIJDEPOBEHG> FPFDEPMNGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KMIPOCEGAKE? JLJFFCFAMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly TimeSpan GPMEGPDAHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly IOGJABJGMKL? CNEEHHFJPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly CDEAGLKCDKF IDNCMGDCBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool AJALGDEPFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<TKey> BEFKPDLDJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<TVal> OGMHIOBOPBD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int AFGHANPJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF90", Offset = "0x9BB990", VA = "0x1809BCF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int GKLKKABONHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xCA3DD0", Offset = "0xCA27D0", VA = "0x180CA3DD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xDD8890", Offset = "0xDD7290", VA = "0x180DD8890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x50362A0", Offset = "0x5034CA0", VA = "0x1850362A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int AJLCNPFMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5033080", Offset = "0x5031A80", VA = "0x185033080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> FIGJBBINHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x50363E0", Offset = "0x5034DE0", VA = "0x1850363E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.KIKCBAAAAFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5034600", Offset = "0x5033000", VA = "0x185034600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool KMCAIMHLNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5036330", Offset = "0x5034D30", VA = "0x185036330", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5036490", Offset = "0x5034E90", VA = "0x185036490", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x50329F0", Offset = "0x50313F0", VA = "0x1850329F0")]
	private bool JGHEDLAEAFM(int CIIHPLFOGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x50305C0", Offset = "0x502EFC0", VA = "0x1850305C0")]
	private void FDOICCFLOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5034DA0", Offset = "0x50337A0", VA = "0x185034DA0")]
	public AKJHEKJEJOA(int CIIHPLFOGKO, [Optional] KMIPOCEGAKE? JLJFFCFAMOE, [Optional] IEqualityComparer<TKey>? JEJCPEPDCKI, [Optional] IOGJABJGMKL? CNEEHHFJPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5034CB0", Offset = "0x50336B0", VA = "0x185034CB0")]
	public AKJHEKJEJOA(TimeSpan GPMEGPDAHAJ, [Optional] IEqualityComparer<TKey>? JEJCPEPDCKI, [Optional] IOGJABJGMKL? CNEEHHFJPIB, [Optional] CDEAGLKCDKF? IDNCMGDCBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5034D20", Offset = "0x5033720", VA = "0x185034D20")]
	public AKJHEKJEJOA(int CIIHPLFOGKO, TimeSpan GPMEGPDAHAJ, [Optional] IEqualityComparer<TKey>? JEJCPEPDCKI, [Optional] IOGJABJGMKL? CNEEHHFJPIB, [Optional] CDEAGLKCDKF? IDNCMGDCBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5034F60", Offset = "0x5033960", VA = "0x185034F60")]
	public AKJHEKJEJOA(int CIIHPLFOGKO, KMIPOCEGAKE? JLJFFCFAMOE, TimeSpan GPMEGPDAHAJ, [Optional] IEqualityComparer<TKey>? JEJCPEPDCKI, [Optional] IOGJABJGMKL? CNEEHHFJPIB, [Optional] CDEAGLKCDKF? IDNCMGDCBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x50330D0", Offset = "0x5031AD0", VA = "0x1850330D0", Slot = "21")]
	public bool OPNLJFBOADM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5030A70", Offset = "0x502F470", VA = "0x185030A70", Slot = "22")]
	public bool FFGCDCMNPMJ(int PICLDLMFMMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x502C970", Offset = "0x502B370", VA = "0x18502C970")]
	private bool BHMAHOMGBFB(int PICLDLMFMMM, EACKOLKKNIF NBAKHABPJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x50339B0", Offset = "0x50323B0", VA = "0x1850339B0")]
	public void PMHEFKOCJCJ(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x502C2F0", Offset = "0x502ACF0", VA = "0x18502C2F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OIBJKKOCOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x502C180", Offset = "0x502AB80", VA = "0x18502C180", Slot = "9")]
	public void Add(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x502E960", Offset = "0x502D360", VA = "0x18502E960", Slot = "8")]
	public bool ContainsKey(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x50342A0", Offset = "0x5032CA0", VA = "0x1850342A0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5033EA0", Offset = "0x50328A0", VA = "0x185033EA0", Slot = "10")]
	public bool Remove(TKey NJBPFCDJFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5034390", Offset = "0x5032D90", VA = "0x185034390", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> OIBJKKOCOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x502DFD0", Offset = "0x502C9D0", VA = "0x18502DFD0")]
	private bool CEFDPLNCFCL(TKey NJBPFCDJFGD, [Out] TVal PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x502DDB0", Offset = "0x502C7B0", VA = "0x18502DDB0")]
	private TVal BLCCCENAIKI(TKey EBIFOIFHMFN)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5034AB0", Offset = "0x50334B0", VA = "0x185034AB0", Slot = "11")]
	public bool TryGetValue(TKey EBIFOIFHMFN, [Out] TVal PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x502E7D0", Offset = "0x502D1D0", VA = "0x18502E7D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x502F120", Offset = "0x502DB20", VA = "0x18502F120", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NAKGFAINKPB, int JMDPMMMKOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5032760", Offset = "0x5031160", VA = "0x185032760")]
	private void HPEBPDOAJGE(TKey NJBPFCDJFGD, TVal OILNFPPOKDD, EACKOLKKNIF NBAKHABPJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5032D60", Offset = "0x5031760", VA = "0x185032D60")]
	private bool NADLPNKJGHA(FIJDEPOBEHG COOAKMMEPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5030D30", Offset = "0x502F730", VA = "0x185030D30")]
	private void FMACLGHMKLP(LinkedListNode<FIJDEPOBEHG> MDHDBEKBFDE, TVal NLGALJNEPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x502F800", Offset = "0x502E200", VA = "0x18502F800")]
	private void EDHPJFLGKJG(TKey NJBPFCDJFGD, TVal PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x50337A0", Offset = "0x50321A0", VA = "0x1850337A0")]
	private void PKHOJFKNBEP(FIJDEPOBEHG COOAKMMEPFL, TVal NLGALJNEPJK, int CMLICKDGMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5032420", Offset = "0x5030E20", VA = "0x185032420", Slot = "19")]
	[IteratorStateMachine(typeof(AKJHEKJEJOA<, >.PFEAFIAOHOH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5034650", Offset = "0x5033050", VA = "0x185034650", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum EACKOLKKNIF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class BPGGJEICCOB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly TKey IDDDMFLAOCN;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x64C2E40", Offset = "0x64C1840", VA = "0x1864C2E40")]
	public BPGGJEICCOB(TKey CONODNPAHCH, Exception JELEKGKHKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MHPGHEGOHNE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE00", Offset = "0x6BB9800", VA = "0x186BBAE00")]
	public MHPGHEGOHNE(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class ANMLBAEDBPO<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class FMMILHDCNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public ANMLBAEDBPO<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FMMILHDCNJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x47E0AF0", Offset = "0x47DF4F0", VA = "0x1847E0AF0")]
		internal Task<TResource> EDHBGCNCBNN(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct PEEDDILHBCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public ANMLBAEDBPO<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x53CB210", Offset = "0x53C9C10", VA = "0x1853CB210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x53CBD90", Offset = "0x53CA790", VA = "0x1853CBD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct PBOMLEICLBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x53C1E80", Offset = "0x53C0880", VA = "0x1853C1E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x53C2900", Offset = "0x53C1300", VA = "0x1853C2900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly HHEEAELAOEG<TId, Task<TResource>> FLGMBIHGHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> LEOFOKDHBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? AGKDDKHFBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Action<TResource>? CMCJNHKBHBG;

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x50BF500", Offset = "0x50BDF00", VA = "0x1850BF500")]
	public ANMLBAEDBPO(int AOMFOMGHHBK = 0, [Optional] IEqualityComparer<TId>? HADOPODFGPG, [Optional] Func<TId, CancellationToken, Task<TResource>>? DFECANMALFC, [Optional] Action<TResource>? BHLHKNJOPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x50BE9A0", Offset = "0x50BD3A0", VA = "0x1850BE9A0")]
	public HDLBIOFLEHA<Task<TResource>> MOGAEEJPKMP(TId ICHIIHCEGJD, [Optional] Func<TId, CancellationToken, Task<TResource>>? DFECANMALFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x50BDE30", Offset = "0x50BC830", VA = "0x1850BDE30")]
	private void INJOKLOEEKC(Task<TResource> GLCABFFLNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x50BEF30", Offset = "0x50BD930", VA = "0x1850BEF30")]
	[AsyncStateMachine(typeof(ANMLBAEDBPO<, >.PEEDDILHBCM))]
	private Task NAPFNPEFALN(Task<TResource> GLCABFFLNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4953800", Offset = "0x4952200", VA = "0x184953800")]
	public void CDLFJPFKPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x50BE190", Offset = "0x50BCB90", VA = "0x1850BE190")]
	public HHEEAELAOEG<TId, Task<TResource>>.CJJBHAKLGPJ KCFKLFFNEEA()
	{
		return default(HHEEAELAOEG<TId, Task<TResource>>.CJJBHAKLGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x50BF330", Offset = "0x50BDD30", VA = "0x1850BF330", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x50BF330", Offset = "0x50BDD30", VA = "0x1850BF330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x50BE560", Offset = "0x50BCF60", VA = "0x1850BE560")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(ANMLBAEDBPO<, >.PBOMLEICLBI))]
	internal static Task MMFJGGKDIBP(Task<TResource> GLCABFFLNII, CancellationTokenSource LBOCPDNMHLP, Dictionary<Task<TResource>, CancellationTokenSource> KDANENNCDNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class HHEEAELAOEG<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class MEGPJHBLCPA : IEquatable<MEGPJHBLCPA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly TValue ABKPALEDJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int BHHGLJFHPBO;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x10CE760", Offset = "0x10CD160", VA = "0x1810CE760")]
		public MEGPJHBLCPA(TValue PPJFMHBDGNA, int NDGBBEBMJIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5127610", Offset = "0x5126010", VA = "0x185127610", Slot = "4")]
		public bool Equals(MEGPJHBLCPA? OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x51276A0", Offset = "0x51260A0", VA = "0x1851276A0", Slot = "0")]
		public override bool Equals(object? OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x51278F0", Offset = "0x51262F0", VA = "0x1851278F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct CJJBHAKLGPJ : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Dictionary<TKey, MEGPJHBLCPA>.Enumerator IHOPIEFFOMJ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x657BDD0", Offset = "0x657A7D0", VA = "0x18657BDD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x657C180", Offset = "0x657AB80", VA = "0x18657C180", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x657BF10", Offset = "0x657A910", VA = "0x18657BF10")]
		public CJJBHAKLGPJ(HHEEAELAOEG<TKey, TValue> LCGNOGHMHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x657B980", Offset = "0x657A380", VA = "0x18657B980", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x657BA00", Offset = "0x657A400", VA = "0x18657BA00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x657BC80", Offset = "0x657A680", VA = "0x18657BC80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class MKPAKENOPKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HHEEAELAOEG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public MEGPJHBLCPA refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MKPAKENOPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5136F80", Offset = "0x5135980", VA = "0x185136F80")]
		internal void EDHBGCNCBNN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<TKey, MEGPJHBLCPA> NHJDMHADNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Func<TKey, TValue>? PBDNKKNHOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Action<TValue>? OHFEOGDEOAI;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x495F130", Offset = "0x495DB30", VA = "0x18495F130")]
	public HHEEAELAOEG(int AOMFOMGHHBK = 0, [Optional] IEqualityComparer<TKey>? JEJCPEPDCKI, [Optional] Func<TKey, TValue>? NDBLLGNOAPO, [Optional] Action<TValue>? BEOGHMLMCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x495EC50", Offset = "0x495D650", VA = "0x18495EC50")]
	public HDLBIOFLEHA<TValue> MOGAEEJPKMP(TKey NJBPFCDJFGD, [Optional] Func<TKey, TValue>? GIADPKLOKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x495DFD0", Offset = "0x495C9D0", VA = "0x18495DFD0")]
	private void HPODIEKJDDB(TKey NJBPFCDJFGD, MEGPJHBLCPA NAGJGHHDEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x495DC90", Offset = "0x495C690", VA = "0x18495DC90")]
	public void CDLFJPFKPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x495E250", Offset = "0x495CC50", VA = "0x18495E250")]
	public CJJBHAKLGPJ KCFKLFFNEEA()
	{
		return default(CJJBHAKLGPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x495EFF0", Offset = "0x495D9F0", VA = "0x18495EFF0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x495EFF0", Offset = "0x495D9F0", VA = "0x18495EFF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
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
