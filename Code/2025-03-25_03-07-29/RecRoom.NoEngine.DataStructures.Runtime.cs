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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7931890", Offset = "0x7930C90", VA = "0x187931890")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HIGIDPOLNCC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	protected HIGIDPOLNCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DBGFMLANNNA<T> : HIGIDPOLNCC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct KAFCKKGGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum PCDNPIOECIG
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
		public PCDNPIOECIG MAIGGPEPIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T AKLHLNJOCEK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int DOADOKJCKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool HIKCHFDOCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool PBMEJCMOFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? ILKEEMNDAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<KAFCKKGGLLC>? IKNAAIINEMG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GPPNALLIFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x65AA2F0", Offset = "0x65A96F0", VA = "0x1865AA2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65AA600", Offset = "0x65A9A00", VA = "0x1865AA600")]
	protected DBGFMLANNNA(bool PBMEJCMOFKE, bool HIKCHFDOCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65AA560", Offset = "0x65A9960", VA = "0x1865AA560")]
	protected bool PHKBNHGKBLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65A9E50", Offset = "0x65A9250", VA = "0x1865A9E50")]
	protected void DFOKGKDHDID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x65A9BE0", Offset = "0x65A8FE0", VA = "0x1865A9BE0")]
	protected void CAKIPPBCHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38DFA10", Offset = "0x38DEE10", VA = "0x1838DFA10")]
	private static void FGJLMLNGJDK<U>(List<U>? JMHKEMEJOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65AA350", Offset = "0x65A9750", VA = "0x1865AA350", Slot = "4")]
	public void LLICHLCEEGA(T AKLHLNJOCEK, bool MMLNCCHEDLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65A9F70", Offset = "0x65A9370", VA = "0x1865A9F70", Slot = "5")]
	public void FBDLIPAFCGJ(T AKLHLNJOCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x65AA140", Offset = "0x65A9540", VA = "0x1865AA140")]
	public void GAPBPDEBKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OLDENIALAEA : DBGFMLANNNA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7932120", Offset = "0x7931520", VA = "0x187932120")]
	public OLDENIALAEA(bool PBMEJCMOFKE = false, bool HIKCHFDOCPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7931E60", Offset = "0x7931260", VA = "0x187931E60")]
	public void BHNBAFNFKNN()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7932060", Offset = "0x7931460", VA = "0x187932060")]
	public static OLDENIALAEA JMJJCCCHNMB(OLDENIALAEA BHPKECALHBK, Action AKLHLNJOCEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79320C0", Offset = "0x79314C0", VA = "0x1879320C0")]
	public static OLDENIALAEA LFJIMNCFLAB(OLDENIALAEA BHPKECALHBK, Action AKLHLNJOCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AMFFBIKAKGP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLICHLCEEGA(Action<T> AKLHLNJOCEK, bool MMLNCCHEDLA = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBDLIPAFCGJ(Action<T> AKLHLNJOCEK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class OHMOKFGANBG<T> : DBGFMLANNNA<Action<T>>, AMFFBIKAKGP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x470BB00", Offset = "0x470AF00", VA = "0x18470BB00")]
	public OHMOKFGANBG(bool PBMEJCMOFKE = false, bool HIKCHFDOCPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x515BC20", Offset = "0x515B020", VA = "0x18515BC20")]
	public void BHNBAFNFKNN(T CFOOONLCHLJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x47F1F80", Offset = "0x47F1380", VA = "0x1847F1F80")]
	public static OHMOKFGANBG<T> JMJJCCCHNMB(OHMOKFGANBG<T> BHPKECALHBK, Action<T> AKLHLNJOCEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x47F2020", Offset = "0x47F1420", VA = "0x1847F2020")]
	public static OHMOKFGANBG<T> LFJIMNCFLAB(OHMOKFGANBG<T> BHPKECALHBK, Action<T> AKLHLNJOCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IFIPMEBIOFP<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLICHLCEEGA(Action<T, U> AKLHLNJOCEK, bool MMLNCCHEDLA = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBDLIPAFCGJ(Action<T, U> AKLHLNJOCEK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class ABNIGPKKHEA<T, U> : DBGFMLANNNA<Action<T, U>>, IFIPMEBIOFP<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x470BB00", Offset = "0x470AF00", VA = "0x18470BB00")]
	public ABNIGPKKHEA(bool PBMEJCMOFKE = false, bool HIKCHFDOCPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x47EF010", Offset = "0x47EE410", VA = "0x1847EF010")]
	public void BHNBAFNFKNN(T CFOOONLCHLJ, U IKCHLKCBELB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x47F1F80", Offset = "0x47F1380", VA = "0x1847F1F80")]
	public static ABNIGPKKHEA<T, U> JMJJCCCHNMB(ABNIGPKKHEA<T, U> BHPKECALHBK, Action<T, U> AKLHLNJOCEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x47F2020", Offset = "0x47F1420", VA = "0x1847F2020")]
	public static ABNIGPKKHEA<T, U> LFJIMNCFLAB(ABNIGPKKHEA<T, U> BHPKECALHBK, Action<T, U> AKLHLNJOCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IEAHLFMOJAO<T, U, V> : DBGFMLANNNA<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x470BB00", Offset = "0x470AF00", VA = "0x18470BB00")]
	public IEAHLFMOJAO(bool PBMEJCMOFKE = false, bool HIKCHFDOCPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x49B50E0", Offset = "0x49B44E0", VA = "0x1849B50E0")]
	public void BHNBAFNFKNN(T CFOOONLCHLJ, U IKCHLKCBELB, V AEPDMGGJHKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x47F1F80", Offset = "0x47F1380", VA = "0x1847F1F80")]
	public static IEAHLFMOJAO<T, U, V> JMJJCCCHNMB(IEAHLFMOJAO<T, U, V> BHPKECALHBK, Action<T, U, V> AKLHLNJOCEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x47F2020", Offset = "0x47F1420", VA = "0x1847F2020")]
	public static IEAHLFMOJAO<T, U, V> LFJIMNCFLAB(IEAHLFMOJAO<T, U, V> BHPKECALHBK, Action<T, U, V> AKLHLNJOCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PKMHNEGCCJE<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class NDJNJGFKHOP<T, U, V, W> : DBGFMLANNNA<Action<T, U, V, W>>, PKMHNEGCCJE<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x470BB00", Offset = "0x470AF00", VA = "0x18470BB00")]
	public NDJNJGFKHOP(bool PBMEJCMOFKE = false, bool HIKCHFDOCPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0050", Offset = "0x4FEF450", VA = "0x184FF0050")]
	public void BHNBAFNFKNN(T CFOOONLCHLJ, U IKCHLKCBELB, V AEPDMGGJHKC, W FIMFKJDMEKB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x47F1F80", Offset = "0x47F1380", VA = "0x1847F1F80")]
	public static NDJNJGFKHOP<T, U, V, W> JMJJCCCHNMB(NDJNJGFKHOP<T, U, V, W> BHPKECALHBK, Action<T, U, V, W> AKLHLNJOCEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x47F2020", Offset = "0x47F1420", VA = "0x1847F2020")]
	public static NDJNJGFKHOP<T, U, V, W> LFJIMNCFLAB(NDJNJGFKHOP<T, U, V, W> BHPKECALHBK, Action<T, U, V, W> AKLHLNJOCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class KOMDBLHHCKG<T, U, V, W, X> : DBGFMLANNNA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x470BB00", Offset = "0x470AF00", VA = "0x18470BB00")]
	public KOMDBLHHCKG(bool PBMEJCMOFKE = false, bool HIKCHFDOCPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8150", Offset = "0x4CE7550", VA = "0x184CE8150")]
	public void BHNBAFNFKNN(T CFOOONLCHLJ, U IKCHLKCBELB, V AEPDMGGJHKC, W FIMFKJDMEKB, X JFJPEDLJOKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x47F1F80", Offset = "0x47F1380", VA = "0x1847F1F80")]
	public static KOMDBLHHCKG<T, U, V, W, X> JMJJCCCHNMB(KOMDBLHHCKG<T, U, V, W, X> BHPKECALHBK, Action<T, U, V, W, X> AKLHLNJOCEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x47F2020", Offset = "0x47F1420", VA = "0x1847F2020")]
	public static KOMDBLHHCKG<T, U, V, W, X> LFJIMNCFLAB(KOMDBLHHCKG<T, U, V, W, X> BHPKECALHBK, Action<T, U, V, W, X> AKLHLNJOCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OMGNHMGBMIO<T, U, V, W, X, Y> : DBGFMLANNNA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x470BB00", Offset = "0x470AF00", VA = "0x18470BB00")]
	public OMGNHMGBMIO(bool PBMEJCMOFKE = false, bool HIKCHFDOCPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x51E8F20", Offset = "0x51E8320", VA = "0x1851E8F20")]
	public void BHNBAFNFKNN(T CFOOONLCHLJ, U IKCHLKCBELB, V AEPDMGGJHKC, W FIMFKJDMEKB, X JFJPEDLJOKC, Y MJINJIJLGDP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x47F1F80", Offset = "0x47F1380", VA = "0x1847F1F80")]
	public static OMGNHMGBMIO<T, U, V, W, X, Y> JMJJCCCHNMB(OMGNHMGBMIO<T, U, V, W, X, Y> BHPKECALHBK, Action<T, U, V, W, X, Y> AKLHLNJOCEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x47F2020", Offset = "0x47F1420", VA = "0x1847F2020")]
	public static OMGNHMGBMIO<T, U, V, W, X, Y> LFJIMNCFLAB(OMGNHMGBMIO<T, U, V, W, X, Y> BHPKECALHBK, Action<T, U, V, W, X, Y> AKLHLNJOCEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DGKIKKBFNII<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NENMPGKCOOL<TKey, TVal> HOIJMCLDEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FPHCCOBOGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NENMPGKCOOL<TKey, TVal>.IJNKKHPLGPF? NHOOAJPAIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int BPNABCHNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NENMPGKCOOL<TKey, TVal>.NNGPNIDDJON? OODOGPKCDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int NGMNLPBIFON;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int KBJLBKEPMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x65C70C0", Offset = "0x65C64C0", VA = "0x1865C70C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LIHNDKDCAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x992560", Offset = "0x991960", VA = "0x180992560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x65C78C0", Offset = "0x65C6CC0", VA = "0x1865C78C0")]
	public DGKIKKBFNII(int BPNABCHNOFF, [Optional] NENMPGKCOOL<TKey, TVal>.NNGPNIDDJON? OODOGPKCDIJ, [Optional] IEqualityComparer<TKey>? MPJINLPPEPK, [Optional] NENMPGKCOOL<TKey, TVal>.IJNKKHPLGPF? NHOOAJPAIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x65C6B30", Offset = "0x65C5F30", VA = "0x1865C6B30")]
	public void DOIDOMHKNML(TKey MCBJECJLDOM, TVal FIIKLGCIAGG, bool IEKLOCHGCBC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x65C7630", Offset = "0x65C6A30", VA = "0x1865C7630")]
	public bool PDNEBBJCNHC(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65C6FC0", Offset = "0x65C63C0", VA = "0x1865C6FC0")]
	public bool HNOOOLJPLPG(TKey CKJNIFPMEBF, [Out] TVal FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x65C7370", Offset = "0x65C6770", VA = "0x1865C7370")]
	private void NPIBCHLOJLF(TKey MCBJECJLDOM, TVal FIIKLGCIAGG, int EOKAMHLPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x65C6D60", Offset = "0x65C6160", VA = "0x1865C6D60")]
	public bool EEGBEDJANPL(TKey MCBJECJLDOM, TVal FIIKLGCIAGG, bool IEKLOCHGCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x65C6F10", Offset = "0x65C6310", VA = "0x1865C6F10")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x65C65D0", Offset = "0x65C59D0", VA = "0x1865C65D0")]
	private void BFNBMHNMBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65C7230", Offset = "0x65C6630", VA = "0x1865C7230")]
	private bool NLJPPONFCMM(TKey MCBJECJLDOM, ALKKIKHCJPL CIAFGFLDDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x65C7110", Offset = "0x65C6510", VA = "0x1865C7110")]
	private void NDMAKDHOMJD(TKey MCBJECJLDOM, TVal FIIKLGCIAGG, ALKKIKHCJPL CIAFGFLDDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65C7790", Offset = "0x65C6B90", VA = "0x1865C7790")]
	private void PLJAHNMHKLH(TKey MCBJECJLDOM, TVal NMBONOELKFM, ALKKIKHCJPL CIAFGFLDDGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AKDNPAEAGAJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action EDJGHPLHBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool DIBFCHGCHEB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public AKDNPAEAGAJ(Action EKMCBBBPJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x792E890", Offset = "0x792DC90", VA = "0x18792E890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x364C040", Offset = "0x364B440", VA = "0x18364C040")]
	public static IAMMFEOALJI<T> DCJNBNANGBG<T>(T FIIKLGCIAGG, Action EKMCBBBPJNF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IAMMFEOALJI<T> : AKDNPAEAGAJ where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x49A9E10", Offset = "0x49A9210", VA = "0x1849A9E10")]
	public IAMMFEOALJI(T FIIKLGCIAGG, Action EKMCBBBPJNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class CNLKCBHOIOK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MMJFKAKHOIO<T>? JOEKEKMLGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> MGIJEFDBOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool DIBFCHGCHEB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CNLKCBHOIOK<T> OGOLFLHIENG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> GGFOGMJPOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6214B70", Offset = "0x6213F70", VA = "0x186214B70")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long HAABCAIFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62147F0", Offset = "0x6213BF0", VA = "0x1862147F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JKHINNGGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6214970", Offset = "0x6213D70", VA = "0x186214970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6215360", Offset = "0x6214760", VA = "0x186215360")]
	public CNLKCBHOIOK(MMJFKAKHOIO<T> PGIBDEOBONP, MMJFKAKHOIO<T> DOINOAJKNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62154F0", Offset = "0x62148F0", VA = "0x1862154F0")]
	public CNLKCBHOIOK(MMJFKAKHOIO<T> PGIBDEOBONP, int FOGJBEMBBDP, MMJFKAKHOIO<T> DOINOAJKNMA, int PECLBOLKGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6215450", Offset = "0x6214850", VA = "0x186215450")]
	private CNLKCBHOIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6214760", Offset = "0x6213B60", VA = "0x186214760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6214CA0", Offset = "0x62140A0", VA = "0x186214CA0")]
	public T[] ICFDPGCHGNH()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6214D50", Offset = "0x6214150", VA = "0x186214D50")]
	public static ReadOnlySequence<T> MDKCMNAEKLA(CNLKCBHOIOK<T>? IDLIAABJGAD)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KNNGNCINDND : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct HCAEOCDAOJG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
		public static HCAEOCDAOJG AFLKMMODJAC()
		{
			return default(HCAEOCDAOJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7930D50", Offset = "0x7930150", VA = "0x187930D50")]
	public static string EACIELLJPFD(Type MAIGGPEPIHD, [Optional] string? JNMCOONCPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x36B7C20", Offset = "0x36B7020", VA = "0x1836B7C20")]
	public static string? EACIELLJPFD<T>([Optional] string? JNMCOONCPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x36B7BA0", Offset = "0x36B6FA0", VA = "0x1836B7BA0")]
	public static string? CLEJPHIHKAL<T>([Optional] string? MGMNMKKLIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
	public static KNNGNCINDND KJCCMOBODJG(string JNMCOONCPIH, string? MGMNMKKLIOM)
	{
		return default(KNNGNCINDND);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FMBCGIKOAML
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool FFMPBNLILNJ(string FOIGFKKJCDM, FMBCGIKOAML MKJPGPKDMIP);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EJKPNPMBCOD<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EJKPNPMBCOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4288300", Offset = "0x4287700", VA = "0x184288300")]
		internal void HMPHGPJPCMM(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int KBBLKNKJAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string JBKLCDJEPHC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x792FF30", Offset = "0x792F330", VA = "0x18792FF30")]
	public static Dictionary<string, FMBCGIKOAML> KPOCBOOJNFC(Type PNPFBMNGOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x35AD340", Offset = "0x35AC740", VA = "0x1835AD340")]
	public static Dictionary<string, FMBCGIKOAML> KPOCBOOJNFC<T>(Type PNPFBMNGOMK, IReadOnlyDictionary<T, string> PEKGIOKANPC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35ACBC0", Offset = "0x35ABFC0", VA = "0x1835ACBC0")]
	public static Dictionary<string, FMBCGIKOAML> IDAPNIBHHLK<T>(List<T> FDODDLGADNM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x792F9B0", Offset = "0x792EDB0", VA = "0x18792F9B0")]
	public static Dictionary<string, FMBCGIKOAML> AEFLLFCEBGA(Type PNPFBMNGOMK, FFMPBNLILNJ MFCBIJFNOBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x792FD70", Offset = "0x792F170", VA = "0x18792FD70")]
	public static Dictionary<int, string> CMOHFLHAHMA(Dictionary<string, FMBCGIKOAML> PBOFAFGAOJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class BPMPLDFNAFC : EPFFDEGDAEO
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool INIFDIKDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? CDJPCFIJDKC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual EPFFDEGDAEO? JALJHBAMAOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x792EFF0", Offset = "0x792E3F0", VA = "0x18792EFF0")]
	protected BPMPLDFNAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string CHDHFHDBOKA();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x792EB00", Offset = "0x792DF00", VA = "0x18792EB00", Slot = "8")]
	public virtual string EHALGCGJCNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x792ECA0", Offset = "0x792E0A0", VA = "0x18792ECA0", Slot = "9")]
	public void MACIEKAGDHM(StringBuilder COHMOONJIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x792E940", Offset = "0x792DD40", VA = "0x18792E940", Slot = "10")]
	public void AJPCCBMNFAD(StringBuilder COHMOONJIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x792EB80", Offset = "0x792DF80", VA = "0x18792EB80", Slot = "11")]
	public void JPOJCEKABBA(StringBuilder COHMOONJIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x792E9A0", Offset = "0x792DDA0", VA = "0x18792E9A0", Slot = "12")]
	public void CDFBPABHHBM(StringBuilder COHMOONJIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x792EF50", Offset = "0x792E350", VA = "0x18792EF50")]
	public static void NPBPNDHFGIE(StringBuilder COHMOONJIEI, string LBJINJOODBJ, string HACJOCBJIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x695E290", Offset = "0x695D690", VA = "0x18695E290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PJGFIEOMEID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7932200", Offset = "0x7931600", VA = "0x187932200")]
	public PJGFIEOMEID(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CGMKPAEFNJL<TErr> : PJGFIEOMEID where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr MFMENGGCIOH;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61388F0", Offset = "0x6137CF0", VA = "0x1861388F0")]
	private CGMKPAEFNJL([In] TErr AKJBGGGAPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6138820", Offset = "0x6137C20", VA = "0x186138820")]
	public static CGMKPAEFNJL<TErr> AFLKMMODJAC([In] TErr AKJBGGGAPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FMNCGFEFMDA : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm KMMBHIEFOGH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool JEHIKCGNLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool OLBOEBIBKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool HHLHNPOHDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long HAABCAIFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7930580", Offset = "0x792F980", VA = "0x187930580", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long CPGAKMJDLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x79305F0", Offset = "0x792F9F0", VA = "0x1879305F0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7930660", Offset = "0x792FA60", VA = "0x187930660", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7930510", Offset = "0x792F910", VA = "0x187930510")]
	public FMNCGFEFMDA(HashAlgorithm KMMBHIEFOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7930340", Offset = "0x792F740", VA = "0x187930340", Slot = "35")]
	public override int Read(byte[] GODPNOEEIEP, int NPELPNMIGOA, int PPLOBPJCNII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x79304E0", Offset = "0x792F8E0", VA = "0x1879304E0", Slot = "38")]
	public override void Write(byte[] GODPNOEEIEP, int NPELPNMIGOA, int PPLOBPJCNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79303E0", Offset = "0x792F7E0", VA = "0x1879303E0", Slot = "33")]
	public override long Seek(long NPELPNMIGOA, SeekOrigin JBAEEIKJKPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7930470", Offset = "0x792F870", VA = "0x187930470", Slot = "34")]
	public override void SetLength(long FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7930270", Offset = "0x792F670", VA = "0x187930270")]
	public byte[] DCEPNABFPEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EPFFDEGDAEO
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EHALGCGJCNK();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CHDHFHDBOKA();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NCMCMNCIACO<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AKLFBPCCIHN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string JLILAJGDLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MMJFKAKHOIO<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static MMJFKAKHOIO<T>? GPBHKCHEEDK;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object KHMGBENKKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? NPCBKMEDEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool DIBFCHGCHEB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool FNCFKFPOBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6B30", Offset = "0xCD5F30", VA = "0x180CD6B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0C70", Offset = "0x4FA0070", VA = "0x184FA0C70")]
	private static MMJFKAKHOIO<T> MBDAJKHBIKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4FA06C0", Offset = "0x4F9FAC0", VA = "0x184FA06C0")]
	private static void IAAOBPCMIPI(MMJFKAKHOIO<T> CEMBNABNOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x482D370", Offset = "0x482C770", VA = "0x18482D370")]
	private MMJFKAKHOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4F9FDF0", Offset = "0x4F9F1F0", VA = "0x184F9FDF0")]
	public static MMJFKAKHOIO<T> DCJNBNANGBG(ReadOnlyMemory<T> EDNAEEAAGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4F9FA10", Offset = "0x4F9EE10", VA = "0x184F9FA10")]
	public static MMJFKAKHOIO<T> DCJNBNANGBG(IMemoryOwner<T> JAPIGAOPIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F780", Offset = "0x4F9EB80", VA = "0x184F9F780")]
	public static void BJIKPJKCLMG(MMJFKAKHOIO<T> PGIBDEOBONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0240", Offset = "0x4F9F640", VA = "0x184FA0240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F670", Offset = "0x4F9EA70", VA = "0x184F9F670")]
	public MMJFKAKHOIO<T> ABAPGMIIMIM(IMemoryOwner<T> JAPIGAOPIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4FA04C0", Offset = "0x4F9F8C0", VA = "0x184FA04C0")]
	private void HNGOHONFAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F8C0", Offset = "0x4F9ECC0", VA = "0x184F9F8C0")]
	private MMJFKAKHOIO<T> CPBMEHGOKGM(MMJFKAKHOIO<T> CEMBNABNOIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PMLLKBMNHNE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7932260", Offset = "0x7931660", VA = "0x187932260")]
	public PMLLKBMNHNE(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CEPGMAOEICD<TOk> : PMLLKBMNHNE where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk DFEOPGHJHAD;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61373E0", Offset = "0x61367E0", VA = "0x1861373E0")]
	private CEPGMAOEICD([In] TOk FOEJNMGLCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F83BB0", Offset = "0x4F82FB0", VA = "0x184F83BB0")]
	public static CEPGMAOEICD<TOk> AFLKMMODJAC([In] TOk FOEJNMGLCIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct AEAAIINGJNL<TOk, TErr> : IEquatable<AEAAIINGJNL<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> FAIPJAIOFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr MFMENGGCIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk DFEOPGHJHAD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GEOMLCNECEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x47F5F10", Offset = "0x47F5310", VA = "0x1847F5F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DCMKDLKDFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x47F65E0", Offset = "0x47F59E0", VA = "0x1847F65E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x47FE7F0", Offset = "0x47FDBF0", VA = "0x1847FE7F0")]
	internal AEAAIINGJNL([In] TErr AKJBGGGAPLO, [In] TOk FOEJNMGLCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x47F87A0", Offset = "0x47F7BA0", VA = "0x1847F87A0")]
	public static AEAAIINGJNL<TOk, TErr> GFGNKGHBAED([In] TErr AKJBGGGAPLO)
	{
		return default(AEAAIINGJNL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x47F7F80", Offset = "0x47F7380", VA = "0x1847F7F80")]
	public static AEAAIINGJNL<TOk, TErr> FODCLHNLHNB([In] TOk FOEJNMGLCIB)
	{
		return default(AEAAIINGJNL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4840", Offset = "0x2CC3C40", VA = "0x182CC4840")]
	public AEAAIINGJNL<TOk?, UErr?> CNAFABEEHKI<UErr>()
	{
		return default(AEAAIINGJNL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6D50", Offset = "0x2CC6150", VA = "0x182CC6D50")]
	public AEAAIINGJNL<UOk?, TErr?> GKHDICMKIMF<UOk>()
	{
		return default(AEAAIINGJNL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5400", Offset = "0x2CC4800", VA = "0x182CC5400")]
	public AEAAIINGJNL<UOk?, TErr?> DFLHANCNEMJ<UOk>()
	{
		return default(AEAAIINGJNL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2CC70B0", Offset = "0x2CC64B0", VA = "0x182CC70B0")]
	public AEAAIINGJNL<TOk?, UErr?> HMMGCNOBFBN<UErr>()
	{
		return default(AEAAIINGJNL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x47FB340", Offset = "0x47FA740", VA = "0x1847FB340")]
	public AEAAIINGJNL<DKANDHFOMPH, TErr> IPMGNNDFDCI()
	{
		return default(AEAAIINGJNL<DKANDHFOMPH, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x47FA2A0", Offset = "0x47F96A0", VA = "0x1847FA2A0")]
	public static bool IGEKHAEJGKN([In] AEAAIINGJNL<TOk, TErr> AJLPPHLPDOI, [In] AEAAIINGJNL<TOk, TErr> PODDNHBLFOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x47F6CA0", Offset = "0x47F60A0", VA = "0x1847F6CA0", Slot = "4")]
	public bool Equals(AEAAIINGJNL<TOk, TErr> JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x47F6D70", Offset = "0x47F6170", VA = "0x1847F6D70", Slot = "0")]
	public override bool Equals(object JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x47F9580", Offset = "0x47F8980", VA = "0x1847F9580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x47FD890", Offset = "0x47FCC90", VA = "0x1847FD890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class FEACBFANHHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FPHAIEHGEFH<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<AEAAIINGJNL<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<AEAAIINGJNL<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x474FF60", Offset = "0x474F360", VA = "0x18474FF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x47505A0", Offset = "0x474F9A0", VA = "0x1847505A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x359AD10", Offset = "0x359A110", VA = "0x18359AD10")]
	public static AEAAIINGJNL<TOk?, TErr?> DFEOPGHJHAD<TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [In] TOk FOEJNMGLCIB)
	{
		return default(AEAAIINGJNL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x359AD70", Offset = "0x359A170", VA = "0x18359AD70")]
	public static AEAAIINGJNL<DKANDHFOMPH, TErr?> DFEOPGHJHAD<TErr>([In] this AEAAIINGJNL<DKANDHFOMPH, TErr> CAMFIHKHJNG)
	{
		return default(AEAAIINGJNL<DKANDHFOMPH, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x359AD10", Offset = "0x359A110", VA = "0x18359AD10")]
	public static AEAAIINGJNL<TOk?, TErr?> MFMENGGCIOH<TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [In] TErr AKJBGGGAPLO)
	{
		return default(AEAAIINGJNL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x359C300", Offset = "0x359B700", VA = "0x18359C300")]
	public static TOk? LGFKFFIDGHP<TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x359B2C0", Offset = "0x359A6C0", VA = "0x18359B2C0")]
	[AsyncStateMachine(typeof(FPHAIEHGEFH<, >))]
	public static Task<TOk?>? GJOIKLNFJMG<TOk, TErr>(this Task<AEAAIINGJNL<TOk, TErr>> CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3599440", Offset = "0x3598840", VA = "0x183599440")]
	public static TErr? AIPECICEHBB<TErr, TOk>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3599790", Offset = "0x3598B90", VA = "0x183599790")]
	public static bool CAPINHLGKIB<TOk, TErr, UErr, UOk>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [Out] AEAAIINGJNL<UOk, UErr> ILMJIEHNICP) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x359B590", Offset = "0x359A990", VA = "0x18359B590")]
	public static bool HJFMJCABLLI<TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [Out] TOk FOEJNMGLCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x359CCB0", Offset = "0x359C0B0", VA = "0x18359CCB0")]
	public static bool PONEDIKPHNL<TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [Out][NotNullWhen(true)] TErr AKJBGGGAPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x359AFC0", Offset = "0x359A3C0", VA = "0x18359AFC0")]
	public static bool DOLCBKBDDAN<TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [Out][NotNullWhen(true)] TOk FOEJNMGLCIB, [Out][NotNullWhen(false)] TErr AKJBGGGAPLO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x359B1C0", Offset = "0x359A5C0", VA = "0x18359B1C0")]
	public static bool FACPGFLEJIP<TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [Out][NotNullWhen(true)] TOk FOEJNMGLCIB, [Out] AEAAIINGJNL<TOk, TErr> ILMJIEHNICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x35999F0", Offset = "0x3598DF0", VA = "0x1835999F0")]
	public static bool CAPINHLGKIB<TOk, TErr, UErr, UOk>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [Out][NotNullWhen(true)] TOk FOEJNMGLCIB, [Out] AEAAIINGJNL<UOk, UErr> ILMJIEHNICP) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x359A910", Offset = "0x3599D10", VA = "0x18359A910")]
	public static bool DBFNAABBGLI<TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [Out][NotNullWhen(true)] TOk FOEJNMGLCIB, [Out] AEAAIINGJNL<DKANDHFOMPH, TErr> ILMJIEHNICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x359BB20", Offset = "0x359AF20", VA = "0x18359BB20")]
	public static AEAAIINGJNL<UOk, UErr> JPGADOABHKE<UOk, UErr, TOk, TErr>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, [In] AEAAIINGJNL<UOk, UErr> OICAMEEFOOB) where TOk : UOk where TErr : UErr
	{
		return default(AEAAIINGJNL<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x359C690", Offset = "0x359BA90", VA = "0x18359C690")]
	public static AEAAIINGJNL<TOk?[]?, TErr?> MCIPAFFJEKI<TOk, TErr>(this IEnumerable<AEAAIINGJNL<TOk, TErr>> CAMFIHKHJNG)
	{
		return default(AEAAIINGJNL<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x359CA00", Offset = "0x359BE00", VA = "0x18359CA00")]
	public static AEAAIINGJNL<UOk?, TErr?> NHIAKGOHIGD<UOk, TErr, TOk>([In] this AEAAIINGJNL<TOk, TErr> CAMFIHKHJNG, Func<TOk, UOk> AGKBPHANLKJ)
	{
		return default(AEAAIINGJNL<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class OJCIDFNBHEG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1DA0", Offset = "0x3BB11A0", VA = "0x183BB1DA0")]
	public static AEAAIINGJNL<TOk, T> DFEOPGHJHAD<TOk>([In] TOk FOEJNMGLCIB) where TOk : notnull
	{
		return default(AEAAIINGJNL<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5160890", Offset = "0x515FC90", VA = "0x185160890")]
	public static AEAAIINGJNL<DKANDHFOMPH, T> DFEOPGHJHAD()
	{
		return default(AEAAIINGJNL<DKANDHFOMPH, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1DA0", Offset = "0x3BB11A0", VA = "0x183BB1DA0")]
	public static AEAAIINGJNL<T, TErr> MFMENGGCIOH<TErr>([In] TErr AKJBGGGAPLO) where TErr : notnull
	{
		return default(AEAAIINGJNL<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct FCMNPECNDFE<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly ICGIJHJMJOI GMFDJPFGAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> FJAKJAOMLJM;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x46C1350", Offset = "0x46C0750", VA = "0x1846C1350")]
	public static FCMNPECNDFE<TKey, TValue> AFLKMMODJAC(string PFPNPMCGHHC)
	{
		return default(FCMNPECNDFE<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x46C1510", Offset = "0x46C0910", VA = "0x1846C1510")]
	internal FCMNPECNDFE(Dictionary<TKey, TValue> FIIKLGCIAGG, ICGIJHJMJOI NMOCOMCICNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x46C1470", Offset = "0x46C0870", VA = "0x1846C1470")]
	public NPBIPBAMEPN<TKey, TValue> ONFMLMOGMNH([Out] Dictionary<TKey, TValue> FIIKLGCIAGG)
	{
		return default(NPBIPBAMEPN<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct NPBIPBAMEPN<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> FJAKJAOMLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly MLHMPOCLOJA CDBEODJIAEB;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2850AA0", Offset = "0x284FEA0", VA = "0x182850AA0")]
	internal NPBIPBAMEPN(Dictionary<TKey, TValue> FIIKLGCIAGG, MLHMPOCLOJA ALEBALOKMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5056BA0", Offset = "0x5055FA0", VA = "0x185056BA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct PIECAEDLAHJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly ICGIJHJMJOI GMFDJPFGAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> FJAKJAOMLJM;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46C1350", Offset = "0x46C0750", VA = "0x1846C1350")]
	public static PIECAEDLAHJ<T> AFLKMMODJAC(string PFPNPMCGHHC)
	{
		return default(PIECAEDLAHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x46C1510", Offset = "0x46C0910", VA = "0x1846C1510")]
	internal PIECAEDLAHJ(HashSet<T> FIIKLGCIAGG, ICGIJHJMJOI NMOCOMCICNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46C1470", Offset = "0x46C0870", VA = "0x1846C1470")]
	public DFMEAJKKAKG<T> ONFMLMOGMNH([Out] HashSet<T> FIIKLGCIAGG)
	{
		return default(DFMEAJKKAKG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DFMEAJKKAKG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> FJAKJAOMLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MLHMPOCLOJA CDBEODJIAEB;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2850AA0", Offset = "0x284FEA0", VA = "0x182850AA0")]
	internal DFMEAJKKAKG(HashSet<T> FIIKLGCIAGG, MLHMPOCLOJA ALEBALOKMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5056BA0", Offset = "0x5055FA0", VA = "0x185056BA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct CBPPHDJANHC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ICGIJHJMJOI GMFDJPFGAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> FJAKJAOMLJM;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x46C1350", Offset = "0x46C0750", VA = "0x1846C1350")]
	public static CBPPHDJANHC<T> AFLKMMODJAC(string PFPNPMCGHHC)
	{
		return default(CBPPHDJANHC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x46C1510", Offset = "0x46C0910", VA = "0x1846C1510")]
	internal CBPPHDJANHC(Stack<T> FIIKLGCIAGG, ICGIJHJMJOI NMOCOMCICNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x46C1470", Offset = "0x46C0870", VA = "0x1846C1470")]
	public BELKNJEEEAM<T> ONFMLMOGMNH([Out] Stack<T> FIIKLGCIAGG)
	{
		return default(BELKNJEEEAM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct BELKNJEEEAM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> FJAKJAOMLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly MLHMPOCLOJA CDBEODJIAEB;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2850AA0", Offset = "0x284FEA0", VA = "0x182850AA0")]
	internal BELKNJEEEAM(Stack<T> FIIKLGCIAGG, MLHMPOCLOJA ALEBALOKMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5056BA0", Offset = "0x5055FA0", VA = "0x185056BA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class AOOCMNPBGFC<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct JCKONLDBAFN : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly AOOCMNPBGFC<T> JHKDEKNHDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int AKCDIMLNDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool EJFDEJNNBLM;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2535370", Offset = "0x2534770", VA = "0x182535370")]
		public JCKONLDBAFN(AOOCMNPBGFC<T> KKDALLBMKBI, int OFPHHJKEDGJ, bool FJMOLDCNALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9D50", Offset = "0x4BC9150", VA = "0x184BC9D50")]
		public AOOCMNPBGFC<T>.IFLAOCPBCID NHFIHKFCIDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9E40", Offset = "0x4BC9240", VA = "0x184BC9E40", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9E40", Offset = "0x4BC9240", VA = "0x184BC9E40", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class IFLAOCPBCID : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly AOOCMNPBGFC<T> JHKDEKNHDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int AMOGBLBAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int LHIJELAOLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool EJFDEJNNBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool AJCFIKINGFG;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x49C3440", Offset = "0x49C2840", VA = "0x1849C3440")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x49C35E0", Offset = "0x49C29E0", VA = "0x1849C35E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x49C3750", Offset = "0x49C2B50", VA = "0x1849C3750", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x49C3C70", Offset = "0x49C3070", VA = "0x1849C3C70")]
		public IFLAOCPBCID(AOOCMNPBGFC<T> KKDALLBMKBI, int OFPHHJKEDGJ, bool FJMOLDCNALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x49C3480", Offset = "0x49C2880", VA = "0x1849C3480", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x49C3510", Offset = "0x49C2910", VA = "0x1849C3510", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HPAENJDFDNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public HPAENJDFDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x48FE240", Offset = "0x48FD640", VA = "0x1848FE240")]
		internal T GLDKGICDEPL(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] EDOPKNEFNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int LHIJELAOLFI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EKHBFIJKIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4A22500", Offset = "0x4A21900", VA = "0x184A22500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T NDNCOCJHCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x46B3BE0", Offset = "0x46B2FE0", VA = "0x1846B3BE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T FOBEBPIMKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4A228B0", Offset = "0x4A21CB0", VA = "0x184A228B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4A22670", Offset = "0x4A21A70", VA = "0x184A22670")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int HAABCAIFHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1072220", Offset = "0x1071620", VA = "0x181072220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1927920", Offset = "0x1926D20", VA = "0x181927920")]
	private static int POHNBAJGMDC(int KDCAMOIGIMA, int GHDAIPOHNAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4A22990", Offset = "0x4A21D90", VA = "0x184A22990")]
	public AOOCMNPBGFC(int EOKAMHLPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A22A10", Offset = "0x4A21E10", VA = "0x184A22A10")]
	public AOOCMNPBGFC(int EOKAMHLPIFK, Func<T> OJNGPAPKDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A228F0", Offset = "0x4A21CF0", VA = "0x184A228F0")]
	public AOOCMNPBGFC(T[] OLEAEELGLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A22560", Offset = "0x4A21960", VA = "0x184A22560")]
	public void IKNDKFEFIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A22750", Offset = "0x4A21B50", VA = "0x184A22750")]
	public IEnumerable<T> MKMHPDPNEED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A22810", Offset = "0x4A21C10", VA = "0x184A22810")]
	public AOOCMNPBGFC<T>.IFLAOCPBCID NHFIHKFCIDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x47B7680", Offset = "0x47B6A80", VA = "0x1847B7680", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47B7680", Offset = "0x47B6A80", VA = "0x1847B7680", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class NKNEMGOOONA
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x379F3D0", Offset = "0x379E7D0", VA = "0x18379F3D0")]
	public static AOOCMNPBGFC<T> AFLKMMODJAC<T>(int EOKAMHLPIFK, Func<T> OJNGPAPKDBD) where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7932C90", Offset = "0x7932090", VA = "0x187932C90")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7932C50", Offset = "0x7932050", VA = "0x187932C50")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7932C70", Offset = "0x7932070", VA = "0x187932C70")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7932CB0", Offset = "0x79320B0", VA = "0x187932CB0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7932C30", Offset = "0x7932030", VA = "0x187932C30")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x263E990", Offset = "0x263DD90", VA = "0x18263E990")]
		public RRColor(float NAEIDONDAPA, float CEENAEAMICL, float NLOOBJLDIMA, float NJNDFFALKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x77FFAC0", Offset = "0x77FEEC0", VA = "0x1877FFAC0", Slot = "4")]
		public bool Equals(RRColor JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7932870", Offset = "0x7931C70", VA = "0x187932870", Slot = "0")]
		public override bool Equals(object JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7932970", Offset = "0x7931D70", VA = "0x187932970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x79329F0", Offset = "0x7931DF0", VA = "0x1879329F0", Slot = "5")]
		public string ToString(string LMHNLPFPEOI, IFormatProvider JLCNNKJMBCG)
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
			[Cpp2IlInjected.Address(RVA = "0x7932810", Offset = "0x7931C10", VA = "0x187932810")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x79327B0", Offset = "0x7931BB0", VA = "0x1879327B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x79327E0", Offset = "0x7931BE0", VA = "0x1879327E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7932840", Offset = "0x7931C40", VA = "0x187932840")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7932780", Offset = "0x7931B80", VA = "0x187932780")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x58E1610", Offset = "0x58E0A10", VA = "0x1858E1610")]
		public RRColor32(byte NAEIDONDAPA, byte CEENAEAMICL, byte NLOOBJLDIMA, byte NJNDFFALKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4240", Offset = "0x1FF3640", VA = "0x181FF4240", Slot = "4")]
		public bool Equals(RRColor32 JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x79322C0", Offset = "0x79316C0", VA = "0x1879322C0", Slot = "0")]
		public override bool Equals(object JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x11C1CE0", Offset = "0x11C10E0", VA = "0x1811C1CE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7932350", Offset = "0x7931750", VA = "0x187932350")]
		public static RRColor32 MDKCMNAEKLA(RRColor AMLIHKJCCAK)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x79324A0", Offset = "0x79318A0", VA = "0x1879324A0")]
		public static RRColor MDKCMNAEKLA(RRColor32 AMLIHKJCCAK)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7932510", Offset = "0x7931910", VA = "0x187932510", Slot = "5")]
		public string ToString(string LMHNLPFPEOI, IFormatProvider JLCNNKJMBCG)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class FKJNALNLEMA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct KNPFILEIHFD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly FKJNALNLEMA<T> OOMIHOFFNGP;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T HNMCNCHEPGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x4CE80F0", Offset = "0x4CE74F0", VA = "0x184CE80F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4CE80C0", Offset = "0x4CE74C0", VA = "0x184CE80C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
		public KNPFILEIHFD(FKJNALNLEMA<T> OOMIHOFFNGP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LABHNOBECOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<KNPFILEIHFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FKJNALNLEMA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A900", Offset = "0x4D69D00", VA = "0x184D6A900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4830640", Offset = "0x482FA40", VA = "0x184830640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly SemaphoreSlim DBOIEBHAMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private T KBIEIFLIPFC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x46E8170", Offset = "0x46E7570", VA = "0x1846E8170")]
	public FKJNALNLEMA([In] T KBIEIFLIPFC, int PKFBDPPHLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x46E7F40", Offset = "0x46E7340", VA = "0x1846E7F40")]
	public FKJNALNLEMA([In] T KBIEIFLIPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x46E7A20", Offset = "0x46E6E20", VA = "0x1846E7A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x46E7A60", Offset = "0x46E6E60", VA = "0x1846E7A60")]
	public KNPFILEIHFD FIDAMAIHJPA()
	{
		return default(KNPFILEIHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x46E7D00", Offset = "0x46E7100", VA = "0x1846E7D00")]
	[AsyncStateMachine(typeof(FKJNALNLEMA<>.LABHNOBECOB))]
	public Task<FKJNALNLEMA<T>.KNPFILEIHFD> PMKGLKMBOEO(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x46E7AA0", Offset = "0x46E6EA0", VA = "0x1846E7AA0")]
	public void MNMHCPMOKFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AKONMCDNKJO
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x792E8D0", Offset = "0x792DCD0", VA = "0x18792E8D0")]
	public static FKJNALNLEMA<DKANDHFOMPH> AFLKMMODJAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x363C7F0", Offset = "0x363BBF0", VA = "0x18363C7F0")]
	public static FKJNALNLEMA<T> AFLKMMODJAC<T>([In] T KBIEIFLIPFC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class LEEGNCGGOBI<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct KIDLOPFKCDE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly LEEGNCGGOBI<T> BBDLNCKHKKD;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T HNMCNCHEPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x48135D0", Offset = "0x48129D0", VA = "0x1848135D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5FB0", Offset = "0x4CD53B0", VA = "0x184CD5FB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
		internal KIDLOPFKCDE(LEEGNCGGOBI<T> OOMIHOFFNGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct GCHKMJMINAN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly LEEGNCGGOBI<T> BBDLNCKHKKD;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T HNMCNCHEPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x48135D0", Offset = "0x48129D0", VA = "0x1848135D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4813580", Offset = "0x4812980", VA = "0x184813580", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
		internal GCHKMJMINAN(LEEGNCGGOBI<T> OOMIHOFFNGP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HKCONIPBPLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<GCHKMJMINAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public LEEGNCGGOBI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private FKJNALNLEMA<DKANDHFOMPH>.KNPFILEIHFD <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<FKJNALNLEMA<DKANDHFOMPH>.KNPFILEIHFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4891710", Offset = "0x4890B10", VA = "0x184891710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4830640", Offset = "0x482FA40", VA = "0x184830640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FKJNALNLEMA<int> DJCHEFHLEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FKJNALNLEMA<DKANDHFOMPH> CAIOMNEMNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FKJNALNLEMA<DKANDHFOMPH> IJDCNIAKBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T CDFOGMGGJOL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4D77140", Offset = "0x4D76540", VA = "0x184D77140")]
	internal LEEGNCGGOBI(FKJNALNLEMA<int> LMAHPPIHILJ, FKJNALNLEMA<DKANDHFOMPH> BINPMLDHFJH, FKJNALNLEMA<DKANDHFOMPH> HECGPCAKDPC, [In] T KBIEIFLIPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4D76C60", Offset = "0x4D76060", VA = "0x184D76C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4D76860", Offset = "0x4D75C60", VA = "0x184D76860")]
	public KIDLOPFKCDE AHKKEODFCBM()
	{
		return default(KIDLOPFKCDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D765B0", Offset = "0x4D759B0", VA = "0x184D765B0")]
	public GCHKMJMINAN AHGLPFENCIH()
	{
		return default(GCHKMJMINAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4D76D60", Offset = "0x4D76160", VA = "0x184D76D60")]
	[AsyncStateMachine(typeof(LEEGNCGGOBI<>.HKCONIPBPLP))]
	public Task<LEEGNCGGOBI<T>.GCHKMJMINAN> INBADNHDCLE(CancellationToken BLABAMPAGAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class LHLGAGIHALJ
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7930D90", Offset = "0x7930190", VA = "0x187930D90")]
	public static LEEGNCGGOBI<DKANDHFOMPH> AFLKMMODJAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x36BD870", Offset = "0x36BCC70", VA = "0x1836BD870")]
	public static LEEGNCGGOBI<T> AFLKMMODJAC<T>([In] T KBIEIFLIPFC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class OAPCAHNDPEI<TData> : BPMPLDFNAFC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly string DCKEPMDAMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly TData CBNHMBHNHHG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
	public override string CHDHFHDBOKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5139E80", Offset = "0x5139280", VA = "0x185139E80")]
	internal OAPCAHNDPEI(string EIGJGBPHOMK, [In] TData AMHCLKHIFKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OPEHOOKGLJI
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7932180", Offset = "0x7931580", VA = "0x187932180")]
	public static OAPCAHNDPEI<DKANDHFOMPH> AFLKMMODJAC(string EIGJGBPHOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x364C040", Offset = "0x364B440", VA = "0x18364C040")]
	public static OAPCAHNDPEI<TData> AFLKMMODJAC<TData>(string EIGJGBPHOMK, [In] TData AMHCLKHIFKH) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class ICGIJHJMJOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	internal bool LAEJIAGPGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string LLOCAIFAENG;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5AE00", VA = "0x180D5BA00")]
	private ICGIJHJMJOI(bool KHNBOOOHLNE, string LDPIELLLGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7930A90", Offset = "0x792FE90", VA = "0x187930A90")]
	public static ICGIJHJMJOI AFLKMMODJAC(string LDPIELLLGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7930B00", Offset = "0x792FF00", VA = "0x187930B00")]
	public MLHMPOCLOJA ONFMLMOGMNH()
	{
		return default(MLHMPOCLOJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct MLHMPOCLOJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly ICGIJHJMJOI CCNGDBJFJPH;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	internal MLHMPOCLOJA(ICGIJHJMJOI PFPNPMCGHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7931790", Offset = "0x7930B90", VA = "0x187931790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class CIFOLGBAFHJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class NKLPIMLNHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NKLPIMLNHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x502A1C0", Offset = "0x50295C0", VA = "0x18502A1C0")]
		internal int JBLDCMCEELD(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HashSet<T>? JALNHLDMAOP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> PMAEMBAFOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x613B6C0", Offset = "0x613AAC0", VA = "0x18613B6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PJJBPEGAENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x613BB60", Offset = "0x613AF60", VA = "0x18613BB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x992550", Offset = "0x991950", VA = "0x180992550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x613B9A0", Offset = "0x613ADA0", VA = "0x18613B9A0")]
	public bool LLICHLCEEGA(T HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x613B700", Offset = "0x613AB00", VA = "0x18613B700")]
	public bool FBDLIPAFCGJ(T HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x613B950", Offset = "0x613AD50", VA = "0x18613B950")]
	public bool LDBOOCLJOMK(T HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x613B870", Offset = "0x613AC70", VA = "0x18613B870")]
	public void LAJKENDFKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x613BBB0", Offset = "0x613AFB0", VA = "0x18613BBB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public CIFOLGBAFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class OFGINBALPIL
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OKPLBDEMDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OKPLBDEMDCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7931DB0", Offset = "0x79311B0", VA = "0x187931DB0")]
		internal int JBLDCMCEELD(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<object>? JALNHLDMAOP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> PMAEMBAFOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7931910", Offset = "0x7930D10", VA = "0x187931910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PJJBPEGAENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7931BF0", Offset = "0x7930FF0", VA = "0x187931BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x992550", Offset = "0x991950", VA = "0x180992550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7931B10", Offset = "0x7930F10", VA = "0x187931B10")]
	public bool LLICHLCEEGA(object HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x79319A0", Offset = "0x7930DA0", VA = "0x1879319A0")]
	public bool FBDLIPAFCGJ(object HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7931AB0", Offset = "0x7930EB0", VA = "0x187931AB0")]
	public bool LDBOOCLJOMK(object HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7931A40", Offset = "0x7930E40", VA = "0x187931A40")]
	public void LAJKENDFKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7931C00", Offset = "0x7931000", VA = "0x187931C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public OFGINBALPIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class FLMNLPKDHJA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct LENOIADAMGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float ONAKLKNBALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T HNMCNCHEPGK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<object, LENOIADAMGC> GCADBJPOPIH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T KJGDHEBJOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1825820", Offset = "0x1824C20", VA = "0x181825820", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1824AB0", Offset = "0x1823EB0", VA = "0x181824AB0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? JGAPAJHJBAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x991DA0", Offset = "0x9911A0", VA = "0x180991DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MEAMJNHCOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4706500", Offset = "0x4705900", VA = "0x184706500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x47081B0", Offset = "0x47075B0", VA = "0x1847081B0")]
	public bool KLGDMCBDBFI(T FIIKLGCIAGG, object HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4708B00", Offset = "0x4707F00", VA = "0x184708B00")]
	public bool MHIADOPKDEM(object HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4706560", Offset = "0x4705960", VA = "0x184706560")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x47066E0", Offset = "0x4705AE0", VA = "0x1847066E0")]
	public bool HNOOOLJPLPG(object HEJFDMJNIGB, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4707090", Offset = "0x4706490", VA = "0x184707090")]
	[AMAFACFOGFD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JIMGOOKPGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4708BA0", Offset = "0x4707FA0", VA = "0x184708BA0")]
	public FLMNLPKDHJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class EPNCCHIJEIL : MKFDEOOKDBH<NIOICMFLLAK>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class NBCPCLHKLEN : IEqualityComparer<NIOICMFLLAK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		internal static readonly NBCPCLHKLEN DMADMDPHOOL;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x79317B0", Offset = "0x7930BB0", VA = "0x1879317B0", Slot = "4")]
		public bool Equals(NIOICMFLLAK JFJPEDLJOKC, NIOICMFLLAK MJINJIJLGDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6B4FA20", Offset = "0x6B4EE20", VA = "0x186B4FA20", Slot = "5")]
		public int GetHashCode(NIOICMFLLAK HAPOBHMBDHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NBCPCLHKLEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x792F940", Offset = "0x792ED40", VA = "0x18792F940")]
	public EPNCCHIJEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x792F800", Offset = "0x792EC00", VA = "0x18792F800", Slot = "4")]
	public override bool LLICHLCEEGA(NIOICMFLLAK HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x792F750", Offset = "0x792EB50", VA = "0x18792F750", Slot = "5")]
	public override bool FBDLIPAFCGJ(NIOICMFLLAK HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x792F8B0", Offset = "0x792ECB0", VA = "0x18792F8B0")]
	private static void PPFKCAJCOLG(NIOICMFLLAK HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1709D90", Offset = "0x1709190", VA = "0x181709D90", Slot = "6")]
	protected override string TokenToString(NIOICMFLLAK HEJFDMJNIGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class NIOICMFLLAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly string IPMMIPAFKGF;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public NIOICMFLLAK(string IPMMIPAFKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7931840", Offset = "0x7930C40", VA = "0x187931840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class MKFDEOOKDBH<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IEqualityComparer<T> JNJOJFOHKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private HashSet<T>? JALNHLDMAOP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PJJBPEGAENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4F9A1B0", Offset = "0x4F995B0", VA = "0x184F9A1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xB327A0", Offset = "0xB31BA0", VA = "0x180B327A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xBD2F90", Offset = "0xBD2390", VA = "0x180BD2F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A880", Offset = "0x4F99C80", VA = "0x184F9A880")]
	public MKFDEOOKDBH(IEqualityComparer<T> JNJOJFOHKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4F99E10", Offset = "0x4F99210", VA = "0x184F99E10", Slot = "4")]
	public virtual bool LLICHLCEEGA(T HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4F99BC0", Offset = "0x4F98FC0", VA = "0x184F99BC0", Slot = "5")]
	public virtual bool FBDLIPAFCGJ(T HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4F99D30", Offset = "0x4F99130", VA = "0x184F99D30")]
	public void LAJKENDFKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A4E0", Offset = "0x4F998E0", VA = "0x184F9A4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class LLCILPEOAFD<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<WeakReference<T>>? JALNHLDMAOP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PJJBPEGAENO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F510", Offset = "0x4D8E910", VA = "0x184D8F510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EF20", Offset = "0x4D8E320", VA = "0x184D8EF20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4D8F2A0", Offset = "0x4D8E6A0", VA = "0x184D8F2A0")]
	public void LLICHLCEEGA(T HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4D8F0C0", Offset = "0x4D8E4C0", VA = "0x184D8F0C0")]
	public void FBDLIPAFCGJ(T HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4D8F260", Offset = "0x4D8E660", VA = "0x184D8F260")]
	public void LAJKENDFKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x4D8F630", Offset = "0x4D8EA30", VA = "0x184D8F630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public LLCILPEOAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class MBAIFDMAGOG
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x36E7A60", Offset = "0x36E6E60", VA = "0x1836E7A60")]
	public static void KMFGPAKLNAM<T>(this List<T> JMHKEMEJOPH, int KDCAMOIGIMA) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class AHPICFKIEOH<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct DPOAAGHKOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float ONAKLKNBALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public T HNMCNCHEPGK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<NIOICMFLLAK, DPOAAGHKOJO> GCADBJPOPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EqualityComparer<T> DGPOJJLGJDC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T KJGDHEBJOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9932A0", Offset = "0x9926A0", VA = "0x1809932A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x993530", Offset = "0x992930", VA = "0x180993530", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private NIOICMFLLAK? JGAPAJHJBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x99BAC0", Offset = "0x99AEC0", VA = "0x18099BAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool MEAMJNHCOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4706500", Offset = "0x4705900", VA = "0x184706500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x48E5C70", Offset = "0x48E5070", VA = "0x1848E5C70")]
	public bool KLGDMCBDBFI(T FIIKLGCIAGG, NIOICMFLLAK HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4708B00", Offset = "0x4707F00", VA = "0x184708B00")]
	public bool MHIADOPKDEM(NIOICMFLLAK HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4706560", Offset = "0x4705960", VA = "0x184706560")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4706780", Offset = "0x4705B80", VA = "0x184706780")]
	public bool HNOOOLJPLPG(NIOICMFLLAK HEJFDMJNIGB, [Out] T FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x48E58A0", Offset = "0x48E4CA0", VA = "0x1848E58A0")]
	[AMAFACFOGFD("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JIMGOOKPGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x48E5EC0", Offset = "0x48E52C0", VA = "0x1848E5EC0")]
	public AHPICFKIEOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class CBPABDBLELI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<object, float> GCADBJPOPIH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float GMCCEDHOFED
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xE2E720", Offset = "0xE2DB20", VA = "0x180E2E720")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xE2E730", Offset = "0xE2DB30", VA = "0x180E2E730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x792F1E0", Offset = "0x792E5E0", VA = "0x18792F1E0")]
	public void KLGDMCBDBFI(float FIIKLGCIAGG, object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x792F250", Offset = "0x792E650", VA = "0x18792F250")]
	public void MHIADOPKDEM(object HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x792F190", Offset = "0x792E590", VA = "0x18792F190")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x792F060", Offset = "0x792E460", VA = "0x18792F060")]
	private void BCDFHINNIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x792F2C0", Offset = "0x792E6C0", VA = "0x18792F2C0")]
	public CBPABDBLELI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface EMCCFILHLEN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CDKMFFODKCF GLFDMFDCLGP;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class MIHMEPLBLHG : EMCCFILHLEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct HNEOPGOKBBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float OJDEIJAKKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float HBNMGDOLNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal readonly bool MLDGJAOBMHH;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float FONFMMJKOIO
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x79307B0", Offset = "0x792FBB0", VA = "0x1879307B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7930930", Offset = "0x792FD30", VA = "0x187930930")]
		public HNEOPGOKBBB(float LLNIGMDIFON, float IDOPGLOKNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x79307C0", Offset = "0x792FBC0", VA = "0x1879307C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class EMMIPCLGJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MIHMEPLBLHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EMMIPCLGJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x792F6B0", Offset = "0x792EAB0", VA = "0x18792F6B0")]
		internal void DCKDHHMEOBO(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly int MFDGLHBGGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int IOJALBECOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly EMCCFILHLEN[] EAIKNLIOAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CDKMFFODKCF[] MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly HNEOPGOKBBB[] MPBHOEAHJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private HNEOPGOKBBB AOMPGKCEECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CMIBACOKHIM PIIMJMJNDKO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CDKMFFODKCF GLFDMFDCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7931480", Offset = "0x7930880", VA = "0x187931480", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7931540", Offset = "0x7930940", VA = "0x187931540", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7931600", Offset = "0x7930A00", VA = "0x187931600")]
	public MIHMEPLBLHG(int MFDGLHBGGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7930F70", Offset = "0x7930370", VA = "0x187930F70")]
	public CMIBACOKHIM GIBOEFEDFBF(HNEOPGOKBBB IAJIOGCMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7931000", Offset = "0x7930400", VA = "0x187931000")]
	public void LGGDOLODBPG(EMCCFILHLEN JPPIDAMEGCK, [Optional] HNEOPGOKBBB ANFBAIBCMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7930E60", Offset = "0x7930260", VA = "0x187930E60", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void CDKMFFODKCF(float CLBNNMGBMLF);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class DIHADIPBDBG
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class HGLDDNPFOOM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly EMCCFILHLEN EBNGNMCFHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly CDKMFFODKCF FJLFOAFFGHE;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7930720", Offset = "0x792FB20", VA = "0x187930720")]
		public HGLDDNPFOOM(EMCCFILHLEN EBNGNMCFHJB, CDKMFFODKCF FJLFOAFFGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x79306D0", Offset = "0x792FAD0", VA = "0x1879306D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x792F580", Offset = "0x792E980", VA = "0x18792F580")]
	internal static bool BMAPKIBNFBG(float NJNDFFALKHH, float NLOOBJLDIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x791E7B0", Offset = "0x791DBB0", VA = "0x18791E7B0")]
	internal static float PMADMOLBBID(float NJNDFFALKHH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x792F5F0", Offset = "0x792E9F0", VA = "0x18792F5F0")]
	public static IDisposable GKJIHFNJHHM(this EMCCFILHLEN EBNGNMCFHJB, CDKMFFODKCF FJLFOAFFGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CMIBACOKHIM : EMCCFILHLEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private float CLBNNMGBMLF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float CFEDJPOLEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x792F350", Offset = "0x792E750", VA = "0x18792F350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CDKMFFODKCF? GLFDMFDCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x792F440", Offset = "0x792E840", VA = "0x18792F440", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x792F4E0", Offset = "0x792E8E0", VA = "0x18792F4E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public CMIBACOKHIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface HLCEIMEMLMO<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MOIDAHPGPIF<T> GOPOIGEKMOO([Out] T FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAPBPDEBKKO();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NFMJCGCDGGN<T> : HLCEIMEMLMO<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ConcurrentStack<T> MEGPBGFMPBP;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5019150", Offset = "0x5018550", VA = "0x185019150", Slot = "4")]
	public MOIDAHPGPIF<T> GOPOIGEKMOO([Out] T FIIKLGCIAGG)
	{
		return default(MOIDAHPGPIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x50191F0", Offset = "0x50185F0", VA = "0x1850191F0")]
	public void ICCKCAPBKGG(T JBCEOOHMNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4BFD020", Offset = "0x4BFC420", VA = "0x184BFD020", Slot = "5")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "6")]
	protected virtual void NCOPCAMGKAK(T IEBHOLBJBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x50190B0", Offset = "0x50184B0", VA = "0x1850190B0")]
	private T CNKKCIMLPML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5019270", Offset = "0x5018670", VA = "0x185019270")]
	public NFMJCGCDGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct MOIDAHPGPIF<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly T JBCEOOHMNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NFMJCGCDGGN<T> BELFBFACPMM;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
	internal MOIDAHPGPIF(T FIIKLGCIAGG, NFMJCGCDGGN<T> BELFBFACPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4740", Offset = "0x4FA3B40", VA = "0x184FA4740", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JDIAFMPNABE : NFMJCGCDGGN<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly JDIAFMPNABE DMADMDPHOOL;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7930BC0", Offset = "0x792FFC0", VA = "0x187930BC0")]
	public static MOIDAHPGPIF<StringBuilder> CNKKCIMLPML([Out] StringBuilder FIIKLGCIAGG)
	{
		return default(MOIDAHPGPIF<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7930C60", Offset = "0x7930060", VA = "0x187930C60", Slot = "6")]
	protected override void NCOPCAMGKAK(StringBuilder IEBHOLBJBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7930D10", Offset = "0x7930110", VA = "0x187930D10")]
	public JDIAFMPNABE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GOMDDIKLGDD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7280590", Offset = "0x727F990", VA = "0x187280590")]
	public GOMDDIKLGDD(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class AONEJMCCAMM<TKey, TValue> : HPHDIHNGOMA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, BCJGKKCHNIF where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MBEGNCMMODO : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AONEJMCCAMM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1825820", Offset = "0x1824C20", VA = "0x181825820", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x477F5D0", Offset = "0x477E9D0", VA = "0x18477F5D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public MBEGNCMMODO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x477F620", Offset = "0x477EA20", VA = "0x18477F620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4F5E350", Offset = "0x4F5D750", VA = "0x184F5E350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4F5DF50", Offset = "0x4F5D350", VA = "0x184F5DF50")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4F5DE10", Offset = "0x4F5D210", VA = "0x184F5DE10")]
		private void CHDBNOFNPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4F5EAE0", Offset = "0x4F5DEE0", VA = "0x184F5EAE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly HPHDIHNGOMA<TKey, TValue> BJPDILMJDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IDictionary<TKey, TValue> BLEGKGIDDCH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4A22000", Offset = "0x4A21400", VA = "0x184A22000", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GKMGMAJNIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4A221E0", Offset = "0x4A215E0", VA = "0x184A221E0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4A224B0", Offset = "0x4A218B0", VA = "0x184A224B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> CHBNKJJCBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4A22230", Offset = "0x4A21630", VA = "0x184A22230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> LDOFPMHDPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4A22350", Offset = "0x4A21750", VA = "0x184A22350", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4A21E70", Offset = "0x4A21270", VA = "0x184A21E70")]
	public AONEJMCCAMM(HPHDIHNGOMA<TKey, TValue> BJPDILMJDBB, [Optional] IDictionary<TKey, TValue>? BLEGKGIDDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4A1F8F0", Offset = "0x4A1ECF0", VA = "0x184A1F8F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4A1F1A0", Offset = "0x4A1E5A0", VA = "0x184A1F1A0")]
	public void ACGDAGJNABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4A1F460", Offset = "0x4A1E860", VA = "0x184A1F460", Slot = "9")]
	public void Add(TKey MCBJECJLDOM, TValue FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4A20F90", Offset = "0x4A20390", VA = "0x184A20F90")]
	public void IMLIHEGEICK(TKey MCBJECJLDOM, TValue FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4A1F760", Offset = "0x4A1EB60", VA = "0x184A1F760")]
	public void CLFEAEABANL(TKey MCBJECJLDOM, TValue FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4A205E0", Offset = "0x4A1F9E0", VA = "0x184A205E0")]
	public void GADBGNGBECP(TKey MCBJECJLDOM, TValue FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4A203C0", Offset = "0x4A1F7C0", VA = "0x184A203C0")]
	public void EDMCELKMDGA(TKey MCBJECJLDOM, TValue FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4A21470", Offset = "0x4A20870", VA = "0x184A21470", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4A21500", Offset = "0x4A20900", VA = "0x184A21500", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4A21860", Offset = "0x4A20C60", VA = "0x184A21860", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4A1FA30", Offset = "0x4A1EE30", VA = "0x184A1FA30", Slot = "8")]
	public bool ContainsKey(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4A201B0", Offset = "0x4A1F5B0", VA = "0x184A201B0")]
	public bool DMHJJNKGLFB(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4A20510", Offset = "0x4A1F910", VA = "0x184A20510")]
	public bool EJNDILMCKDN(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4A21210", Offset = "0x4A20610", VA = "0x184A21210", Slot = "10")]
	public bool Remove(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4A21C00", Offset = "0x4A21000", VA = "0x184A21C00", Slot = "11")]
	public bool TryGetValue(TKey MCBJECJLDOM, [Out] TValue FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4A1FAF0", Offset = "0x4A1EEF0", VA = "0x184A1FAF0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] KCPGIJAPEHH, int PLNJMGKPKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4A21BC0", Offset = "0x4A20FC0", VA = "0x184A21BC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A20B30", Offset = "0x4A1FF30", VA = "0x184A20B30", Slot = "19")]
	[IteratorStateMachine(typeof(AONEJMCCAMM<, >.MBEGNCMMODO))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4A21120", Offset = "0x4A20520", VA = "0x184A21120", Slot = "21")]
	public bool MFNEHPGLAFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4A20DB0", Offset = "0x4A201B0", VA = "0x184A20DB0")]
	private TValue IIEPDMPMFJE(TKey MCBJECJLDOM)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface OBPMOBAPPAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string DLAEAGALFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface BCJGKKCHNIF
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFNEHPGLAFF();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface HPHDIHNGOMA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, BCJGKKCHNIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public sealed class NENMPGKCOOL<TKey, TVal> : HPHDIHNGOMA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, BCJGKKCHNIF where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate int NNGPNIDDJON(TKey MCBJECJLDOM, TVal FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate void IJNKKHPLGPF(TKey MCBJECJLDOM, TVal FIIKLGCIAGG, ALKKIKHCJPL CIAFGFLDDGN);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class DAHOIOOIALC
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB9A2C0", Offset = "0xB996C0", VA = "0x180B9A2C0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal HNMCNCHEPGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB327A0", Offset = "0xB31BA0", VA = "0x180B327A0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xBD2F90", Offset = "0xBD2390", VA = "0x180BD2F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int FONFMMJKOIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC64D20", Offset = "0xC64120", VA = "0x180C64D20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xE45CF0", Offset = "0xE450F0", VA = "0x180E45CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset EGCHMOEAGIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xE610B0", Offset = "0xE604B0", VA = "0x180E610B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xE610A0", Offset = "0xE604A0", VA = "0x180E610A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x65A1170", Offset = "0x65A0570", VA = "0x1865A1170")]
		public DAHOIOOIALC(TKey MCBJECJLDOM, TVal NMBONOELKFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class EIMNEJCOMPP : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public NENMPGKCOOL<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LinkedList<DAHOIOOIALC>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1825820", Offset = "0x1824C20", VA = "0x181825820", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4286400", Offset = "0x4285800", VA = "0x184286400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public EIMNEJCOMPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4286490", Offset = "0x4285890", VA = "0x184286490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4285B40", Offset = "0x4284F40", VA = "0x184285B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4283700", Offset = "0x4282B00", VA = "0x184283700")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x42860F0", Offset = "0x42854F0", VA = "0x1842860F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public const int AEOEEDGLHOB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, LinkedListNode<DAHOIOOIALC>> GGOBJPLKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LinkedList<DAHOIOOIALC> KBMGJOBJJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NNGPNIDDJON? OODOGPKCDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly TimeSpan ELGBLKHBPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly IJNKKHPLGPF? NHOOAJPAIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly DLAOPFBBEBB GOAAEGOJDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool ADGHLIJODCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<TKey> MAMOLOMOIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<TVal> JEINMLJNCDP;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int LIHNDKDCAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A1080", Offset = "0x9A0480", VA = "0x1809A1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int KBJLBKEPMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xC6CCD0", Offset = "0xC6C0D0", VA = "0x180C6CCD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xDA2CE0", Offset = "0xDA20E0", VA = "0x180DA2CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4FFC810", Offset = "0x4FFBC10", VA = "0x184FFC810", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int ENICEKEEJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4706560", Offset = "0x4705960", VA = "0x184706560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> LDOFPMHDPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4FFC950", Offset = "0x4FFBD50", VA = "0x184FFC950", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.LCFOPGKJIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4FFAB70", Offset = "0x4FF9F70", VA = "0x184FFAB70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool GKMGMAJNIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal PPOFLIOMKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4FFC8A0", Offset = "0x4FFBCA0", VA = "0x184FFC8A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4FFCA00", Offset = "0x4FFBE00", VA = "0x184FFCA00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6B10", Offset = "0x4FF5F10", VA = "0x184FF6B10")]
	private bool JCPAACAMKJE(int MFDGLHBGGAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9900", Offset = "0x4FF8D00", VA = "0x184FF9900")]
	private void MNDBEEDKKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB380", Offset = "0x4FFA780", VA = "0x184FFB380")]
	public NENMPGKCOOL(int MFDGLHBGGAA, [Optional] NNGPNIDDJON? OODOGPKCDIJ, [Optional] IEqualityComparer<TKey>? MPJINLPPEPK, [Optional] IJNKKHPLGPF? NHOOAJPAIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB540", Offset = "0x4FFA940", VA = "0x184FFB540")]
	public NENMPGKCOOL(TimeSpan ELGBLKHBPOB, [Optional] IEqualityComparer<TKey>? MPJINLPPEPK, [Optional] IJNKKHPLGPF? NHOOAJPAIJN, [Optional] DLAOPFBBEBB? GOAAEGOJDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB300", Offset = "0x4FFA700", VA = "0x184FFB300")]
	public NENMPGKCOOL(int MFDGLHBGGAA, TimeSpan ELGBLKHBPOB, [Optional] IEqualityComparer<TKey>? MPJINLPPEPK, [Optional] IJNKKHPLGPF? NHOOAJPAIJN, [Optional] DLAOPFBBEBB? GOAAEGOJDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4FFBE70", Offset = "0x4FFB270", VA = "0x184FFBE70")]
	public NENMPGKCOOL(int MFDGLHBGGAA, NNGPNIDDJON? OODOGPKCDIJ, TimeSpan ELGBLKHBPOB, [Optional] IEqualityComparer<TKey>? MPJINLPPEPK, [Optional] IJNKKHPLGPF? NHOOAJPAIJN, [Optional] DLAOPFBBEBB? GOAAEGOJDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9860", Offset = "0x4FF8C60", VA = "0x184FF9860", Slot = "21")]
	public bool MFNEHPGLAFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6C10", Offset = "0x4FF6010", VA = "0x184FF6C10", Slot = "22")]
	public bool JLLALDBOPCJ(int EOKAMHLPIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4770", Offset = "0x4FF3B70", VA = "0x184FF4770")]
	private bool DMOMIEOIMID(int EOKAMHLPIFK, ALKKIKHCJPL CIAFGFLDDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4FF21E0", Offset = "0x4FF15E0", VA = "0x184FF21E0")]
	public void AJAPKMAIBCL(TKey MCBJECJLDOM, TVal FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF2C10", Offset = "0x4FF2010", VA = "0x184FF2C10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DENKIGKMPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4FF2AA0", Offset = "0x4FF1EA0", VA = "0x184FF2AA0", Slot = "9")]
	public void Add(TKey MCBJECJLDOM, TVal FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3230", Offset = "0x4FF2630", VA = "0x184FF3230", Slot = "8")]
	public bool ContainsKey(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA610", Offset = "0x4FF9A10", VA = "0x184FFA610", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA2D0", Offset = "0x4FF96D0", VA = "0x184FFA2D0", Slot = "10")]
	public bool Remove(TKey MCBJECJLDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAA30", Offset = "0x4FF9E30", VA = "0x184FFAA30", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> DENKIGKMPCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5C30", Offset = "0x4FF5030", VA = "0x184FF5C30")]
	private bool EHBDNDLGNMN(TKey MCBJECJLDOM, [Out] TVal FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3000", Offset = "0x4FF2400", VA = "0x184FF3000")]
	private TVal CNKKCIMLPML(TKey CKJNIFPMEBF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB020", Offset = "0x4FFA420", VA = "0x184FFB020", Slot = "11")]
	public bool TryGetValue(TKey CKJNIFPMEBF, [Out] TVal FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3110", Offset = "0x4FF2510", VA = "0x184FF3110", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3A60", Offset = "0x4FF2E60", VA = "0x184FF3A60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KCPGIJAPEHH, int PLNJMGKPKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA190", Offset = "0x4FF9590", VA = "0x184FFA190")]
	private void PLJAHNMHKLH(TKey MCBJECJLDOM, TVal NMBONOELKFM, ALKKIKHCJPL CIAFGFLDDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4FF72D0", Offset = "0x4FF66D0", VA = "0x184FF72D0")]
	private bool KAAAOMLBCNK(DAHOIOOIALC PKMIGEPEMGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4FF87C0", Offset = "0x4FF7BC0", VA = "0x184FF87C0")]
	private void KNGCHBLDBAD(LinkedListNode<DAHOIOOIALC> GMKNPHNJNDJ, TVal CENPJDFMJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7EC0", Offset = "0x4FF72C0", VA = "0x184FF7EC0")]
	private void KLGDMCBDBFI(TKey MCBJECJLDOM, TVal FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4FF62D0", Offset = "0x4FF56D0", VA = "0x184FF62D0")]
	private void HJBADNFEDKO(DAHOIOOIALC PKMIGEPEMGF, TVal CENPJDFMJJI, int DOGNDPLMNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6170", Offset = "0x4FF5570", VA = "0x184FF6170", Slot = "19")]
	[IteratorStateMachine(typeof(NENMPGKCOOL<, >.EIMNEJCOMPP))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4FFABC0", Offset = "0x4FF9FC0", VA = "0x184FFABC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum ALKKIKHCJPL : byte
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
public class IBIHNCCCGNN<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly TKey IHDALDKELJM;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x49ABBA0", Offset = "0x49AAFA0", VA = "0x1849ABBA0")]
	public IBIHNCCCGNN(TKey CGJLHLGADHD, Exception JFHJDHHPKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JPGDEFMBALB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7F90", Offset = "0x6AD7390", VA = "0x186AD7F90")]
	public JPGDEFMBALB(string EIGJGBPHOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class PABJKCBDJJA<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class MILGMNFDPBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public PABJKCBDJJA<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MILGMNFDPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4F93DD0", Offset = "0x4F931D0", VA = "0x184F93DD0")]
		internal Task<TResource> DGOPNGPILHI(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct MJLJFKIPBMH : IAsyncStateMachine
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
		public PABJKCBDJJA<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4F98320", Offset = "0x4F97720", VA = "0x184F98320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4F98CE0", Offset = "0x4F980E0", VA = "0x184F98CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct MLIDPFBLLIH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4F9D9E0", Offset = "0x4F9CDE0", VA = "0x184F9D9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4F9E720", Offset = "0x4F9DB20", VA = "0x184F9E720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly JPHKGPFKAGE<TId, Task<TResource>> CGCACFDGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> ILIEOAAODGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? FMFNPGLOLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Action<TResource>? NIPGMEFBHKI;

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5292970", Offset = "0x5291D70", VA = "0x185292970")]
	public PABJKCBDJJA(int LAIMGLECPGE = 0, [Optional] IEqualityComparer<TId>? CCNJBIEJFNE, [Optional] Func<TId, CancellationToken, Task<TResource>>? MMFHNFHONLH, [Optional] Action<TResource>? COMLGBHCBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5291710", Offset = "0x5290B10", VA = "0x185291710")]
	public IAMMFEOALJI<Task<TResource>> ADMLOKEGAIO(TId IIKCEJDFBDH, [Optional] Func<TId, CancellationToken, Task<TResource>>? MMFHNFHONLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5291DB0", Offset = "0x52911B0", VA = "0x185291DB0")]
	private void EIABPGCJPCK(Task<TResource> ALKPEINKLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x52925A0", Offset = "0x52919A0", VA = "0x1852925A0")]
	[AsyncStateMachine(typeof(PABJKCBDJJA<, >.MJLJFKIPBMH))]
	private Task OOEOEPJPHOM(Task<TResource> ALKPEINKLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x481A6F0", Offset = "0x4819AF0", VA = "0x18481A6F0")]
	public void AMMAAKGPILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x52922B0", Offset = "0x52916B0", VA = "0x1852922B0")]
	public JPHKGPFKAGE<TId, Task<TResource>>.DEGHLOGJNJE NHFIHKFCIDL()
	{
		return default(JPHKGPFKAGE<TId, Task<TResource>>.DEGHLOGJNJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x52928D0", Offset = "0x5291CD0", VA = "0x1852928D0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x52928D0", Offset = "0x5291CD0", VA = "0x1852928D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5291C80", Offset = "0x5291080", VA = "0x185291C80")]
	[AsyncStateMachine(typeof(PABJKCBDJJA<, >.MLIDPFBLLIH))]
	[CompilerGenerated]
	internal static Task BLLLEFOCBPA(Task<TResource> ALKPEINKLAJ, CancellationTokenSource ILOJCDEHDJK, Dictionary<Task<TResource>, CancellationTokenSource> KBDCBEOCBIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class JPHKGPFKAGE<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class GHIPNNENIFG : IEquatable<GHIPNNENIFG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly TValue HNMCNCHEPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int BEJHGHMPEMJ;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x107D470", Offset = "0x107C870", VA = "0x18107D470")]
		public GHIPNNENIFG(TValue FIIKLGCIAGG, int OLEJNLLMGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x4822900", Offset = "0x4821D00", VA = "0x184822900", Slot = "4")]
		public bool Equals(GHIPNNENIFG? JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x4822990", Offset = "0x4821D90", VA = "0x184822990", Slot = "0")]
		public override bool Equals(object? HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x4822AC0", Offset = "0x4821EC0", VA = "0x184822AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct DEGHLOGJNJE : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Dictionary<TKey, GHIPNNENIFG>.Enumerator EKCDFINHJHL;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x65BD7C0", Offset = "0x65BCBC0", VA = "0x1865BD7C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x65BDC20", Offset = "0x65BD020", VA = "0x1865BDC20", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x65BDA80", Offset = "0x65BCE80", VA = "0x1865BDA80")]
		public DEGHLOGJNJE(JPHKGPFKAGE<TKey, TValue> GCADBJPOPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x65BD420", Offset = "0x65BC820", VA = "0x1865BD420", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x65BD460", Offset = "0x65BC860", VA = "0x1865BD460", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x65BD670", Offset = "0x65BCA70", VA = "0x1865BD670", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class MLABOHBONMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public JPHKGPFKAGE<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public GHIPNNENIFG refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MLABOHBONMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D980", Offset = "0x4F9CD80", VA = "0x184F9D980")]
		internal void DGOPNGPILHI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<TKey, GHIPNNENIFG> IHBPDABBNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Func<TKey, TValue>? GHDIDGJNHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Action<TValue>? KGHIEPDOKJO;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4C1C1A0", Offset = "0x4C1B5A0", VA = "0x184C1C1A0")]
	public JPHKGPFKAGE(int LAIMGLECPGE = 0, [Optional] IEqualityComparer<TKey>? MPJINLPPEPK, [Optional] Func<TKey, TValue>? HLEEFMOLPBF, [Optional] Action<TValue>? ONPFKMCPIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C1B1E0", Offset = "0x4C1A5E0", VA = "0x184C1B1E0")]
	public IAMMFEOALJI<TValue> ADMLOKEGAIO(TKey MCBJECJLDOM, [Optional] Func<TKey, TValue>? KFHNOCHGOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C1BC90", Offset = "0x4C1B090", VA = "0x184C1BC90")]
	private void ICCKCAPBKGG(TKey MCBJECJLDOM, GHIPNNENIFG DNJAANMLALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4C1B710", Offset = "0x4C1AB10", VA = "0x184C1B710")]
	public void AMMAAKGPILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4C1BF50", Offset = "0x4C1B350", VA = "0x184C1BF50")]
	public DEGHLOGJNJE NHFIHKFCIDL()
	{
		return default(DEGHLOGJNJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4C1BFD0", Offset = "0x4C1B3D0", VA = "0x184C1BFD0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4C1BFD0", Offset = "0x4C1B3D0", VA = "0x184C1BFD0", Slot = "5")]
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
