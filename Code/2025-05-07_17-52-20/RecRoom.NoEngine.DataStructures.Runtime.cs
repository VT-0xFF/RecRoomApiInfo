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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D88F60", Offset = "0x7D87F60", VA = "0x187D88F60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JFHDDOPKNCA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected JFHDDOPKNCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HEGMOBKPOIK<T> : JFHDDOPKNCA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct EFAMHFJOPLM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum OKDOJDLDCNE
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
		public OKDOJDLDCNE MLCOGCMJLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T BDCLNIJAFBF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int HMICDCMMGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool EPCOADLJBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool GBDKBBOCIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NCGJKAINIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<EFAMHFJOPLM>? GHBKIIDLIBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BNPOHGOKMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4AD1000", Offset = "0x4AD0000", VA = "0x184AD1000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4AD1070", Offset = "0x4AD0070", VA = "0x184AD1070")]
	protected HEGMOBKPOIK(bool GBDKBBOCIEP, bool EPCOADLJBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0F60", Offset = "0x4ACFF60", VA = "0x184AD0F60")]
	protected bool OIALEDAJPOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0600", Offset = "0x4ACF600", VA = "0x184AD0600")]
	protected void BCBLPKEFPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0CD0", Offset = "0x4ACFCD0", VA = "0x184AD0CD0")]
	protected void NFGGBJAOIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3620", Offset = "0x3CB2620", VA = "0x183CB3620")]
	private static void GMKMJFDBJAG<U>(List<U>? OLEDHEBBJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0900", Offset = "0x4ACF900", VA = "0x184AD0900", Slot = "4")]
	public void IIGLPCDPOEE(T BDCLNIJAFBF, bool IDMJGPAKIGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0720", Offset = "0x4ACF720", VA = "0x184AD0720", Slot = "5")]
	public void GNAALOCCJEL(T BDCLNIJAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0B20", Offset = "0x4ACFB20", VA = "0x184AD0B20")]
	public void INBDHNEFJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GCADBNOOJOM : HEGMOBKPOIK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D87490", Offset = "0x7D86490", VA = "0x187D87490")]
	public GCADBNOOJOM(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D871D0", Offset = "0x7D861D0", VA = "0x187D871D0")]
	public void CIBKKMOJDEC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D87430", Offset = "0x7D86430", VA = "0x187D87430")]
	public static GCADBNOOJOM MBKCEPDOHAP(GCADBNOOJOM KILBJIGPBMG, Action BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D873D0", Offset = "0x7D863D0", VA = "0x187D873D0")]
	public static GCADBNOOJOM KGEEBEJGEIG(GCADBNOOJOM KILBJIGPBMG, Action BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KLMHCJNNIPO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGLPCDPOEE(Action<T> BDCLNIJAFBF, bool IDMJGPAKIGN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNAALOCCJEL(Action<T> BDCLNIJAFBF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NPNKPOOAOFG<T> : HEGMOBKPOIK<Action<T>>, KLMHCJNNIPO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x44EC8E0", Offset = "0x44EB8E0", VA = "0x1844EC8E0")]
	public NPNKPOOAOFG(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5408BA0", Offset = "0x5407BA0", VA = "0x185408BA0")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8FF0", Offset = "0x4AF7FF0", VA = "0x184AF8FF0")]
	public static NPNKPOOAOFG<T> MBKCEPDOHAP(NPNKPOOAOFG<T> KILBJIGPBMG, Action<T> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8F50", Offset = "0x4AF7F50", VA = "0x184AF8F50")]
	public static NPNKPOOAOFG<T> KGEEBEJGEIG(NPNKPOOAOFG<T> KILBJIGPBMG, Action<T> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DAGLKFFOOFC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGLPCDPOEE(Action<T, U> BDCLNIJAFBF, bool IDMJGPAKIGN = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNAALOCCJEL(Action<T, U> BDCLNIJAFBF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class KICNHCAEGMA<T, U> : HEGMOBKPOIK<Action<T, U>>, DAGLKFFOOFC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x44EC8E0", Offset = "0x44EB8E0", VA = "0x1844EC8E0")]
	public KICNHCAEGMA(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC930", Offset = "0x4FDB930", VA = "0x184FDC930")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8FF0", Offset = "0x4AF7FF0", VA = "0x184AF8FF0")]
	public static KICNHCAEGMA<T, U> MBKCEPDOHAP(KICNHCAEGMA<T, U> KILBJIGPBMG, Action<T, U> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8F50", Offset = "0x4AF7F50", VA = "0x184AF8F50")]
	public static KICNHCAEGMA<T, U> KGEEBEJGEIG(KICNHCAEGMA<T, U> KILBJIGPBMG, Action<T, U> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MOHJIJKGENJ<T, U, V> : HEGMOBKPOIK<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x44EC8E0", Offset = "0x44EB8E0", VA = "0x1844EC8E0")]
	public MOHJIJKGENJ(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x535ADD0", Offset = "0x5359DD0", VA = "0x18535ADD0")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO, V IINHKHEMEHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8FF0", Offset = "0x4AF7FF0", VA = "0x184AF8FF0")]
	public static MOHJIJKGENJ<T, U, V> MBKCEPDOHAP(MOHJIJKGENJ<T, U, V> KILBJIGPBMG, Action<T, U, V> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8F50", Offset = "0x4AF7F50", VA = "0x184AF8F50")]
	public static MOHJIJKGENJ<T, U, V> KGEEBEJGEIG(MOHJIJKGENJ<T, U, V> KILBJIGPBMG, Action<T, U, V> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BGMFNFBPHPN<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HLMBLDJFCGB<T, U, V, W> : HEGMOBKPOIK<Action<T, U, V, W>>, BGMFNFBPHPN<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x44EC8E0", Offset = "0x44EB8E0", VA = "0x1844EC8E0")]
	public HLMBLDJFCGB(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B07450", Offset = "0x4B06450", VA = "0x184B07450")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO, V IINHKHEMEHJ, W NJMPEFLBAHN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8FF0", Offset = "0x4AF7FF0", VA = "0x184AF8FF0")]
	public static HLMBLDJFCGB<T, U, V, W> MBKCEPDOHAP(HLMBLDJFCGB<T, U, V, W> KILBJIGPBMG, Action<T, U, V, W> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8F50", Offset = "0x4AF7F50", VA = "0x184AF8F50")]
	public static HLMBLDJFCGB<T, U, V, W> KGEEBEJGEIG(HLMBLDJFCGB<T, U, V, W> KILBJIGPBMG, Action<T, U, V, W> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MKICKDDDNKK<T, U, V, W, X> : HEGMOBKPOIK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x44EC8E0", Offset = "0x44EB8E0", VA = "0x1844EC8E0")]
	public MKICKDDDNKK(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x533F010", Offset = "0x533E010", VA = "0x18533F010")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO, V IINHKHEMEHJ, W NJMPEFLBAHN, X CEJAAIDLEPA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8FF0", Offset = "0x4AF7FF0", VA = "0x184AF8FF0")]
	public static MKICKDDDNKK<T, U, V, W, X> MBKCEPDOHAP(MKICKDDDNKK<T, U, V, W, X> KILBJIGPBMG, Action<T, U, V, W, X> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8F50", Offset = "0x4AF7F50", VA = "0x184AF8F50")]
	public static MKICKDDDNKK<T, U, V, W, X> KGEEBEJGEIG(MKICKDDDNKK<T, U, V, W, X> KILBJIGPBMG, Action<T, U, V, W, X> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HIILDAAMMBI<T, U, V, W, X, Y> : HEGMOBKPOIK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x44EC8E0", Offset = "0x44EB8E0", VA = "0x1844EC8E0")]
	public HIILDAAMMBI(bool GBDKBBOCIEP = false, bool EPCOADLJBNM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4AF87A0", Offset = "0x4AF77A0", VA = "0x184AF87A0")]
	public void CIBKKMOJDEC(T LEMBKBGMCDG, U LHJOAJGMHHO, V IINHKHEMEHJ, W NJMPEFLBAHN, X CEJAAIDLEPA, Y IMNDAJIDDFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8FF0", Offset = "0x4AF7FF0", VA = "0x184AF8FF0")]
	public static HIILDAAMMBI<T, U, V, W, X, Y> MBKCEPDOHAP(HIILDAAMMBI<T, U, V, W, X, Y> KILBJIGPBMG, Action<T, U, V, W, X, Y> BDCLNIJAFBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8F50", Offset = "0x4AF7F50", VA = "0x184AF8F50")]
	public static HIILDAAMMBI<T, U, V, W, X, Y> KGEEBEJGEIG(HIILDAAMMBI<T, U, V, W, X, Y> KILBJIGPBMG, Action<T, U, V, W, X, Y> BDCLNIJAFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OJBCGPDKLFC<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FAKLKHOBCAF<TKey, TVal> GHJGKIPJDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> GKPKHDGCNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FAKLKHOBCAF<TKey, TVal>.JCNIAMJACJF? AJBEMMOIIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int AIFBGODJJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FAKLKHOBCAF<TKey, TVal>.KLHIIMGJNAN? NEIBHEBGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int NMMMMLEDBKP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int OHDAOPOFPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x552B2F0", Offset = "0x552A2F0", VA = "0x18552B2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EFJAAKPECFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x552B5D0", Offset = "0x552A5D0", VA = "0x18552B5D0")]
	public OJBCGPDKLFC(int AIFBGODJJLK, [Optional] FAKLKHOBCAF<TKey, TVal>.KLHIIMGJNAN? NEIBHEBGDCA, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] FAKLKHOBCAF<TKey, TVal>.JCNIAMJACJF? AJBEMMOIIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x552AE00", Offset = "0x5529E00", VA = "0x18552AE00")]
	public void LBJDJBEFMLC(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, bool JBBLDBKEMGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x552ABE0", Offset = "0x5529BE0", VA = "0x18552ABE0")]
	public bool IKMEICODLOF(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x552B030", Offset = "0x552A030", VA = "0x18552B030")]
	public bool LKMKPGKLGLC(TKey KBMOAEOFKJM, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x552A240", Offset = "0x5529240", VA = "0x18552A240")]
	private void ECJNKKFALMD(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x552B130", Offset = "0x552A130", VA = "0x18552B130")]
	public bool OCDGKMPDGED(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, bool JBBLDBKEMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x552AD50", Offset = "0x5529D50", VA = "0x18552AD50")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x552A650", Offset = "0x5529650", VA = "0x18552A650")]
	private void HFBJGNADKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x552B480", Offset = "0x552A480", VA = "0x18552B480")]
	private bool PMGBCNDKKAC(TKey OEHHKNIGGMI, AKOFMBHIPNP DKBCGBFNIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x552B350", Offset = "0x552A350", VA = "0x18552B350")]
	private void PJLIGHBCKMB(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, AKOFMBHIPNP DKBCGBFNIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x552A520", Offset = "0x5529520", VA = "0x18552A520")]
	private void FKAKKEJCDGG(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF, AKOFMBHIPNP DKBCGBFNIGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FDIIDDCLBHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action EJKMLLMKNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EFFCLIFCPEK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public FDIIDDCLBHF(Action AAMIKNLELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D87190", Offset = "0x7D86190", VA = "0x187D87190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x36E6230", Offset = "0x36E5230", VA = "0x1836E6230")]
	public static CLCFAKNAJCK<T> FLLMCNLHKNL<T>(T OHLIHBDBKCE, Action AAMIKNLELJB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CLCFAKNAJCK<T> : FDIIDDCLBHF where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67E8630", Offset = "0x67E7630", VA = "0x1867E8630")]
	public CLCFAKNAJCK(T OHLIHBDBKCE, Action AAMIKNLELJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class MKFFIMPEBDB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MJBGFHIEDKK<T>? HDCGOOAKBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> LNGMBMDPJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool EFFCLIFCPEK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly MKFFIMPEBDB<T> KKKNNENCOAG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> GHONMMDKFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x533E1A0", Offset = "0x533D1A0", VA = "0x18533E1A0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x533E060", Offset = "0x533D060", VA = "0x18533E060")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x533E410", Offset = "0x533D410", VA = "0x18533E410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x533E6D0", Offset = "0x533D6D0", VA = "0x18533E6D0")]
	public MKFFIMPEBDB(MJBGFHIEDKK<T> NONNEFPCKAH, MJBGFHIEDKK<T> LPLGOCAEONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x533E7D0", Offset = "0x533D7D0", VA = "0x18533E7D0")]
	public MKFFIMPEBDB(MJBGFHIEDKK<T> NONNEFPCKAH, int NGFMNKONPKM, MJBGFHIEDKK<T> LPLGOCAEONJ, int AHEINAHGGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x533E620", Offset = "0x533D620", VA = "0x18533E620")]
	private MKFFIMPEBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x533DDB0", Offset = "0x533CDB0", VA = "0x18533DDB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x533DEF0", Offset = "0x533CEF0", VA = "0x18533DEF0")]
	public T[] HGAAFLBNLDD()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x533E220", Offset = "0x533D220", VA = "0x18533E220")]
	public static ReadOnlySequence<T> OIFHDJNIHDL(MKFFIMPEBDB<T>? NFKNDNEHMAF)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JHGAEEHEAGF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable LIFEMEGPEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T FPGFCMMHMJG;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4E36910", Offset = "0x4E35910", VA = "0x184E36910")]
	public JHGAEEHEAGF(IDisposable AMICCGMJHBK, [In] T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD520", Offset = "0x3CBC520", VA = "0x183CBD520")]
	public static JHGAEEHEAGF<U> FOPBGEEEGFF<U>([In] JHGAEEHEAGF<T> AMICCGMJHBK, [In] U OHLIHBDBKCE) where U : notnull
	{
		return default(JHGAEEHEAGF<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E36790", Offset = "0x4E35790", VA = "0x184E36790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KLPMJEMCNIL
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x38F2AE0", Offset = "0x38F1AE0", VA = "0x1838F2AE0")]
	public static JHGAEEHEAGF<T> ACADPGMDEBE<T>(IDisposable AMICCGMJHBK, [In] T OHLIHBDBKCE) where T : notnull
	{
		return default(JHGAEEHEAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x38F2B40", Offset = "0x38F1B40", VA = "0x1838F2B40")]
	public static JHGAEEHEAGF<T> ILKKFEDAJIM<T>([In] this JHGAEEHEAGF<T> OCACDKEJIIB, [Out] T OHLIHBDBKCE) where T : notnull
	{
		return default(JHGAEEHEAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x38458A0", Offset = "0x38448A0", VA = "0x1838458A0")]
	public static JHGAEEHEAGF<U?> FOPBGEEEGFF<U, T>([In] JHGAEEHEAGF<T> HEEGIENOAML, [In] U OHLIHBDBKCE)
	{
		return default(JHGAEEHEAGF<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct JMJECAHGFJF : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct OOEEFBGALEM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
		public static OOEEFBGALEM ACADPGMDEBE()
		{
			return default(OOEEFBGALEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D88BD0", Offset = "0x7D87BD0", VA = "0x187D88BD0")]
	public static string NKGFJDCBDOP(Type MLCOGCMJLBB, [Optional] string? LIICCBEIELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x38B49F0", Offset = "0x38B39F0", VA = "0x1838B49F0")]
	public static string? NKGFJDCBDOP<T>([Optional] string? LIICCBEIELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x38B4970", Offset = "0x38B3970", VA = "0x1838B4970")]
	public static string? FFAACAIGAAI<T>([Optional] string? HEKGBLOGOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
	public static JMJECAHGFJF ECGNHAOMACM(string LIICCBEIELN, string? HEKGBLOGOAJ)
	{
		return default(JMJECAHGFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FDEEMEDLPLM
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool NKAFBHPOBJG(string BCGNBDHPFAB, FDEEMEDLPLM KHJOHHNPGEF);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PPLBEDLCPHL<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PPLBEDLCPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5631150", Offset = "0x5630150", VA = "0x185631150")]
		internal void AKAEMFDNHEA(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int PCHMHBNEGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string LAADEINHGNK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D86E60", Offset = "0x7D85E60", VA = "0x187D86E60")]
	public static Dictionary<string, FDEEMEDLPLM> PECHGHAKADN(Type NNODEEMKOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x383AEE0", Offset = "0x3839EE0", VA = "0x18383AEE0")]
	public static Dictionary<string, FDEEMEDLPLM> PECHGHAKADN<T>(Type NNODEEMKOHL, IReadOnlyDictionary<T, string> FDLMALDJBJC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x383A760", Offset = "0x3839760", VA = "0x18383A760")]
	public static Dictionary<string, FDEEMEDLPLM> PEAIEMIPFCO<T>(List<T> DCOMGCLLLJH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D868E0", Offset = "0x7D858E0", VA = "0x187D868E0")]
	public static Dictionary<string, FDEEMEDLPLM> ADEIBIBOBJO(Type NNODEEMKOHL, NKAFBHPOBJG JCDOOGJLMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D86CA0", Offset = "0x7D85CA0", VA = "0x187D86CA0")]
	public static Dictionary<int, string> MPEDEGPAHNM(Dictionary<string, FDEEMEDLPLM> NEKLMLONNIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class OGMCLKGLBPG : HIKDGBNCNDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool DMICDGLJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? KIEGCLLKGDI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual HIKDGBNCNDJ? GCEONJBMONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D89680", Offset = "0x7D88680", VA = "0x187D89680")]
	protected OGMCLKGLBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JJNMHFCAPPI();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D895A0", Offset = "0x7D885A0", VA = "0x187D895A0", Slot = "8")]
	public virtual string LAFICHOHNKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D89100", Offset = "0x7D88100", VA = "0x187D89100", Slot = "9")]
	public void FFGOBIKMION(StringBuilder ALFALFBMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D89620", Offset = "0x7D88620", VA = "0x187D89620", Slot = "10")]
	public void PIODEBNCGLK(StringBuilder ALFALFBMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D88FE0", Offset = "0x7D87FE0", VA = "0x187D88FE0", Slot = "11")]
	public void EPFIIKONCKM(StringBuilder ALFALFBMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D893A0", Offset = "0x7D883A0", VA = "0x187D893A0", Slot = "12")]
	public void JNFCACILNFO(StringBuilder ALFALFBMDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D89500", Offset = "0x7D88500", VA = "0x187D89500")]
	public static void KPHNFFIJJJG(StringBuilder ALFALFBMDFN, string PAGMGOCFAHK, string HIDHHAGFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3FD30", Offset = "0x6D3ED30", VA = "0x186D3FD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KPDHCCFLFIE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D88C10", Offset = "0x7D87C10", VA = "0x187D88C10")]
	public KPDHCCFLFIE(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NPPCJGJKOCK<TErr> : KPDHCCFLFIE where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr OBCANBDNECG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x540B8B0", Offset = "0x540A8B0", VA = "0x18540B8B0")]
	private NPPCJGJKOCK([In] TErr AOGJMPFJDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x540B7D0", Offset = "0x540A7D0", VA = "0x18540B7D0")]
	public static NPPCJGJKOCK<TErr> ACADPGMDEBE([In] TErr AOGJMPFJDNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IKPLMGJILOL : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm EIPAPECJLEB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool NCIPIFCEDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool ICGOFMOJEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool KHGELGKDEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D883D0", Offset = "0x7D873D0", VA = "0x187D883D0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long MJJFMHOFJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D88440", Offset = "0x7D87440", VA = "0x187D88440", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D884B0", Offset = "0x7D874B0", VA = "0x187D884B0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D88360", Offset = "0x7D87360", VA = "0x187D88360")]
	public IKPLMGJILOL(HashAlgorithm EIPAPECJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D88180", Offset = "0x7D87180", VA = "0x187D88180", Slot = "35")]
	public override int Read(byte[] IIGKBHIENFB, int LLPAIMMACAP, int JAALIADHHOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D88330", Offset = "0x7D87330", VA = "0x187D88330", Slot = "38")]
	public override void Write(byte[] IIGKBHIENFB, int LLPAIMMACAP, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D88220", Offset = "0x7D87220", VA = "0x187D88220", Slot = "33")]
	public override long Seek(long LLPAIMMACAP, SeekOrigin CKOFKNABLLG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D882B0", Offset = "0x7D872B0", VA = "0x187D882B0", Slot = "34")]
	public override void SetLength(long OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D880A0", Offset = "0x7D870A0", VA = "0x187D880A0")]
	public byte[] KLJNHBBKJDH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HIKDGBNCNDJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LAFICHOHNKA();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JJNMHFCAPPI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ILKBOCNMCLO<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OENMMKCDPOM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string PLILPCAPEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MJBGFHIEDKK<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static MJBGFHIEDKK<T>? JDAKPBFJMEK;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object KCEKFIELLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? NPCCDIGOBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool EFFCLIFCPEK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xD6F400", Offset = "0xD6E400", VA = "0x180D6F400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x533B4D0", Offset = "0x533A4D0", VA = "0x18533B4D0")]
	private static MJBGFHIEDKK<T> EBAFJGJIHPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x533A880", Offset = "0x5339880", VA = "0x18533A880")]
	private static void BPLFDIAOGPN(MJBGFHIEDKK<T> BPNOFBAMPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x44DFDF0", Offset = "0x44DEDF0", VA = "0x1844DFDF0")]
	private MJBGFHIEDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x533BBD0", Offset = "0x533ABD0", VA = "0x18533BBD0")]
	public static MJBGFHIEDKK<T> FLLMCNLHKNL(ReadOnlyMemory<T> OAEJJMIBANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x533B9B0", Offset = "0x533A9B0", VA = "0x18533B9B0")]
	public static MJBGFHIEDKK<T> FLLMCNLHKNL(IMemoryOwner<T> GAHFIFKEICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x533AE70", Offset = "0x5339E70", VA = "0x18533AE70")]
	public static void COLGLDDMJEE(MJBGFHIEDKK<T> NONNEFPCKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x533AFB0", Offset = "0x5339FB0", VA = "0x18533AFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x533BF90", Offset = "0x533AF90", VA = "0x18533BF90")]
	public MJBGFHIEDKK<T> FMLNAEFDMPJ(IMemoryOwner<T> GAHFIFKEICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x533C300", Offset = "0x533B300", VA = "0x18533C300")]
	private void PAIAEEJDMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x533C0A0", Offset = "0x533B0A0", VA = "0x18533C0A0")]
	private MJBGFHIEDKK<T> IDAJACLFNNI(MJBGFHIEDKK<T> BPNOFBAMPIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PIAPGKAGFDI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7D89D10", Offset = "0x7D88D10", VA = "0x187D89D10")]
	public PIAPGKAGFDI(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PMGDGEJFJKC<TOk> : PIAPGKAGFDI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk IIJKJPIHGDF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5626DB0", Offset = "0x5625DB0", VA = "0x185626DB0")]
	private PMGDGEJFJKC([In] TOk FHBBHJHMBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A930B0", Offset = "0x4A920B0", VA = "0x184A930B0")]
	public static PMGDGEJFJKC<TOk> ACADPGMDEBE([In] TOk FHBBHJHMBGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct HHHCCNLMPJL<TOk, TErr> : IEquatable<HHHCCNLMPJL<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> DBFKNAFIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr OBCANBDNECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk IIJKJPIHGDF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool OMIAEGIJGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4AE1080", Offset = "0x4AE0080", VA = "0x184AE1080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool JKFIBANKCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4ADE200", Offset = "0x4ADD200", VA = "0x184ADE200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4AE26C0", Offset = "0x4AE16C0", VA = "0x184AE26C0")]
	internal HHHCCNLMPJL([In] TErr AOGJMPFJDNP, [In] TOk FHBBHJHMBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4ADFD90", Offset = "0x4ADED90", VA = "0x184ADFD90")]
	public static HHHCCNLMPJL<TOk, TErr> KEIFJFJMJIE([In] TErr AOGJMPFJDNP)
	{
		return default(HHHCCNLMPJL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4AE00E0", Offset = "0x4ADF0E0", VA = "0x184AE00E0")]
	public static HHHCCNLMPJL<TOk, TErr> LINFIGFALEL([In] TOk FHBBHJHMBGK)
	{
		return default(HHHCCNLMPJL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4810", Offset = "0x3CB3810", VA = "0x183CB4810")]
	public HHHCCNLMPJL<TOk?, UErr?> JDPJDCNLBBK<UErr>()
	{
		return default(HHHCCNLMPJL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CB40E0", Offset = "0x3CB30E0", VA = "0x183CB40E0")]
	public HHHCCNLMPJL<UOk?, TErr?> CJGEPMFLCHI<UOk>()
	{
		return default(HHHCCNLMPJL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4E80", Offset = "0x3CB3E80", VA = "0x183CB4E80")]
	public HHHCCNLMPJL<UOk?, TErr?> LAGDIGIFDGK<UOk>()
	{
		return default(HHHCCNLMPJL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4200", Offset = "0x3CB3200", VA = "0x183CB4200")]
	public HHHCCNLMPJL<TOk?, UErr?> FPCHJGBHMGD<UErr>()
	{
		return default(HHHCCNLMPJL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4ADF0C0", Offset = "0x4ADE0C0", VA = "0x184ADF0C0")]
	public HHHCCNLMPJL<BONGKMFJEJA, TErr> GBKLLMPNPJF()
	{
		return default(HHHCCNLMPJL<BONGKMFJEJA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4AE0750", Offset = "0x4ADF750", VA = "0x184AE0750")]
	public static bool MMJMCICIDNJ([In] HHHCCNLMPJL<TOk, TErr> JOOBCOFNIAM, [In] HHHCCNLMPJL<TOk, TErr> MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4ADE530", Offset = "0x4ADD530", VA = "0x184ADE530", Slot = "4")]
	public bool Equals(HHHCCNLMPJL<TOk, TErr> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4ADE880", Offset = "0x4ADD880", VA = "0x184ADE880", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4ADF8C0", Offset = "0x4ADE8C0", VA = "0x184ADF8C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1200", Offset = "0x4AE0200", VA = "0x184AE1200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KLCAENAAGHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct EFCHMAGPDMO<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<HHHCCNLMPJL<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<HHHCCNLMPJL<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x44C3BE0", Offset = "0x44C2BE0", VA = "0x1844C3BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x44C3F10", Offset = "0x44C2F10", VA = "0x1844C3F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38F1190", Offset = "0x38F0190", VA = "0x1838F1190")]
	public static HHHCCNLMPJL<TOk?, TErr?> IIJKJPIHGDF<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [In] TOk FHBBHJHMBGK)
	{
		return default(HHHCCNLMPJL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38F11E0", Offset = "0x38F01E0", VA = "0x1838F11E0")]
	public static HHHCCNLMPJL<BONGKMFJEJA, TErr?> IIJKJPIHGDF<TErr>([In] this HHHCCNLMPJL<BONGKMFJEJA, TErr> OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<BONGKMFJEJA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38F1190", Offset = "0x38F0190", VA = "0x1838F1190")]
	public static HHHCCNLMPJL<TOk?, TErr?> OBCANBDNECG<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [In] TErr AOGJMPFJDNP)
	{
		return default(HHHCCNLMPJL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x38F09A0", Offset = "0x38EF9A0", VA = "0x1838F09A0")]
	public static TOk? GNJBMCDFEPE<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38F25C0", Offset = "0x38F15C0", VA = "0x1838F25C0")]
	[AsyncStateMachine(typeof(EFCHMAGPDMO<, >))]
	public static Task<TOk?>? NDEKBDGLALP<TOk, TErr>(this Task<HHHCCNLMPJL<TOk, TErr>> OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x38F1FE0", Offset = "0x38F0FE0", VA = "0x1838F1FE0")]
	public static TErr? LNFJNNEAMLC<TErr, TOk>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x38EE9E0", Offset = "0x38ED9E0", VA = "0x1838EE9E0")]
	public static bool AMJMHFCFGDN<TOk, TErr, UErr, UOk>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out] HHHCCNLMPJL<UOk, UErr> KEGPEOFCCOA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x38EFCF0", Offset = "0x38EECF0", VA = "0x1838EFCF0")]
	public static bool BFFKDMHOKPK<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out] TOk FHBBHJHMBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x38F2300", Offset = "0x38F1300", VA = "0x1838F2300")]
	public static bool LNKNCHPIBKH<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TErr AOGJMPFJDNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x38F0EA0", Offset = "0x38EFEA0", VA = "0x1838F0EA0")]
	public static bool IHPOOKDPHMA<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TOk FHBBHJHMBGK, [Out][NotNullWhen(false)] TErr AOGJMPFJDNP) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x38F2890", Offset = "0x38F1890", VA = "0x1838F2890")]
	public static bool OIOAGHPJMMB<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TOk FHBBHJHMBGK, [Out] HHHCCNLMPJL<TOk, TErr> KEGPEOFCCOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x38EEC40", Offset = "0x38EDC40", VA = "0x1838EEC40")]
	public static bool AMJMHFCFGDN<TOk, TErr, UErr, UOk>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TOk FHBBHJHMBGK, [Out] HHHCCNLMPJL<UOk, UErr> KEGPEOFCCOA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x38F1480", Offset = "0x38F0480", VA = "0x1838F1480")]
	public static bool LFEMIHHLODE<TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [Out][NotNullWhen(true)] TOk FHBBHJHMBGK, [Out] HHHCCNLMPJL<BONGKMFJEJA, TErr> KEGPEOFCCOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x38F0160", Offset = "0x38EF160", VA = "0x1838F0160")]
	public static HHHCCNLMPJL<UOk, UErr> GANMBCDALGG<UOk, UErr, TOk, TErr>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, [In] HHHCCNLMPJL<UOk, UErr> COFBNOFIHKI) where TOk : UOk where TErr : UErr
	{
		return default(HHHCCNLMPJL<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x38F1830", Offset = "0x38F0830", VA = "0x1838F1830")]
	public static HHHCCNLMPJL<TOk?[]?, TErr?> LFGJCHPCMEH<TOk, TErr>(this IEnumerable<HHHCCNLMPJL<TOk, TErr>> OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x38F1BD0", Offset = "0x38F0BD0", VA = "0x1838F1BD0")]
	public static HHHCCNLMPJL<UOk?, TErr?> LLJPNEEKOIC<UOk, TErr, TOk>([In] this HHHCCNLMPJL<TOk, TErr> OCACDKEJIIB, Func<TOk, UOk> OKNCOOAFLJH)
	{
		return default(HHHCCNLMPJL<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class IHEHLAHANEB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCFD0", Offset = "0x3CBBFD0", VA = "0x183CBCFD0")]
	public static HHHCCNLMPJL<TOk, T> IIJKJPIHGDF<TOk>([In] TOk FHBBHJHMBGK) where TOk : notnull
	{
		return default(HHHCCNLMPJL<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C04970", Offset = "0x4C03970", VA = "0x184C04970")]
	public static HHHCCNLMPJL<BONGKMFJEJA, T> IIJKJPIHGDF()
	{
		return default(HHHCCNLMPJL<BONGKMFJEJA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CBD070", Offset = "0x3CBC070", VA = "0x183CBD070")]
	public static HHHCCNLMPJL<T, TErr> OBCANBDNECG<TErr>([In] TErr AOGJMPFJDNP) where TErr : notnull
	{
		return default(HHHCCNLMPJL<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct BIHKDCPPJCH<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IKOMJAOIFBO AODABAFDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> CDMFIODGJCE;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A46700", Offset = "0x4A45700", VA = "0x184A46700")]
	public static BIHKDCPPJCH<TKey, TValue> ACADPGMDEBE(string INLEBAAACKH)
	{
		return default(BIHKDCPPJCH<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A468E0", Offset = "0x4A458E0", VA = "0x184A468E0")]
	internal BIHKDCPPJCH(Dictionary<TKey, TValue> OHLIHBDBKCE, IKOMJAOIFBO DIMHCLMLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A46830", Offset = "0x4A45830", VA = "0x184A46830")]
	public OAPPEFFLDGP<TKey, TValue> PNEMLBOPKAD([Out] Dictionary<TKey, TValue> OHLIHBDBKCE)
	{
		return default(OAPPEFFLDGP<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct OAPPEFFLDGP<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> CDMFIODGJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly JIAPKFDFLEC OFAOHELMMEO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x297E150", Offset = "0x297D150", VA = "0x18297E150")]
	internal OAPPEFFLDGP(Dictionary<TKey, TValue> OHLIHBDBKCE, JIAPKFDFLEC OMMMLKJGIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C07C90", Offset = "0x4C06C90", VA = "0x184C07C90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GAPAOOCELJG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IKOMJAOIFBO AODABAFDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> CDMFIODGJCE;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A46700", Offset = "0x4A45700", VA = "0x184A46700")]
	public static GAPAOOCELJG<T> ACADPGMDEBE(string INLEBAAACKH)
	{
		return default(GAPAOOCELJG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A468E0", Offset = "0x4A458E0", VA = "0x184A468E0")]
	internal GAPAOOCELJG(HashSet<T> OHLIHBDBKCE, IKOMJAOIFBO DIMHCLMLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4A46830", Offset = "0x4A45830", VA = "0x184A46830")]
	public IIMIMOANPEJ<T> PNEMLBOPKAD([Out] HashSet<T> OHLIHBDBKCE)
	{
		return default(IIMIMOANPEJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct IIMIMOANPEJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> CDMFIODGJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JIAPKFDFLEC OFAOHELMMEO;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x297E150", Offset = "0x297D150", VA = "0x18297E150")]
	internal IIMIMOANPEJ(HashSet<T> OHLIHBDBKCE, JIAPKFDFLEC OMMMLKJGIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C07C90", Offset = "0x4C06C90", VA = "0x184C07C90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JMPAPBHIDAD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IKOMJAOIFBO AODABAFDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> CDMFIODGJCE;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4A46700", Offset = "0x4A45700", VA = "0x184A46700")]
	public static JMPAPBHIDAD<T> ACADPGMDEBE(string INLEBAAACKH)
	{
		return default(JMPAPBHIDAD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4A468E0", Offset = "0x4A458E0", VA = "0x184A468E0")]
	internal JMPAPBHIDAD(Stack<T> OHLIHBDBKCE, IKOMJAOIFBO DIMHCLMLGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4A46830", Offset = "0x4A45830", VA = "0x184A46830")]
	public APFEKAJNBOL<T> PNEMLBOPKAD([Out] Stack<T> OHLIHBDBKCE)
	{
		return default(APFEKAJNBOL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct APFEKAJNBOL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> CDMFIODGJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly JIAPKFDFLEC OFAOHELMMEO;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x297E150", Offset = "0x297D150", VA = "0x18297E150")]
	internal APFEKAJNBOL(Stack<T> OHLIHBDBKCE, JIAPKFDFLEC OMMMLKJGIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4C07C90", Offset = "0x4C06C90", VA = "0x184C07C90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class IBMPPKILLBB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct CENFIMPKKJI : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IBMPPKILLBB<T> PCAAKKAJNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int PLKHFOOACGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool KANOGHEBNFD;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x26593C0", Offset = "0x26583C0", VA = "0x1826593C0")]
		public CENFIMPKKJI(IBMPPKILLBB<T> HCAMONPFOJM, int BGFIHDMALOM, bool OFIDGHFDCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x67CBEF0", Offset = "0x67CAEF0", VA = "0x1867CBEF0")]
		public IBMPPKILLBB<T>.DEPAMLLMAFP OMLAPONJPHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x67CBFF0", Offset = "0x67CAFF0", VA = "0x1867CBFF0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x67CBFF0", Offset = "0x67CAFF0", VA = "0x1867CBFF0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class DEPAMLLMAFP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly IBMPPKILLBB<T> PCAAKKAJNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int DFKPILONHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int PHHGAGPDGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool KANOGHEBNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool LHEEFHMMAEG;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6A57560", Offset = "0x6A56560", VA = "0x186A57560")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6A57720", Offset = "0x6A56720", VA = "0x186A57720", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6A579B0", Offset = "0x6A569B0", VA = "0x186A579B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6A57FA0", Offset = "0x6A56FA0", VA = "0x186A57FA0")]
		public DEPAMLLMAFP(IBMPPKILLBB<T> HCAMONPFOJM, int BGFIHDMALOM, bool OFIDGHFDCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6A57620", Offset = "0x6A56620", VA = "0x186A57620", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A576B0", Offset = "0x6A566B0", VA = "0x186A576B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class IGJBGKMFBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IGJBGKMFBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4BFEE00", Offset = "0x4BFDE00", VA = "0x184BFEE00")]
		internal T GOAGLAFDPGD(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] DFDKFLKALLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int PHHGAGPDGEG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BGHIFIPHPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4BEB830", Offset = "0x4BEA830", VA = "0x184BEB830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T FFKIBMLIABP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x49251B0", Offset = "0x49241B0", VA = "0x1849251B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T ACAGEKDEDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4BEB8C0", Offset = "0x4BEA8C0", VA = "0x184BEB8C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4BEB6F0", Offset = "0x4BEA6F0", VA = "0x184BEB6F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2564280", Offset = "0x2563280", VA = "0x182564280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A5B660", Offset = "0x1A5A660", VA = "0x181A5B660")]
	private static int KOMODOIIBMM(int OHHMJGCBCKD, int DDGBDMFPMAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB9A0", Offset = "0x4BEA9A0", VA = "0x184BEB9A0")]
	public IBMPPKILLBB(int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4BEBA30", Offset = "0x4BEAA30", VA = "0x184BEBA30")]
	public IBMPPKILLBB(int CFNMLMNHCMF, Func<T> NNLDCALBAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4BEBD40", Offset = "0x4BEAD40", VA = "0x184BEBD40")]
	public IBMPPKILLBB(T[] OLCBBPLHPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB890", Offset = "0x4BEA890", VA = "0x184BEB890")]
	public void JPOBIPJMCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB760", Offset = "0x4BEA760", VA = "0x184BEB760")]
	public IEnumerable<T> FFMJJEEAJEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB900", Offset = "0x4BEA900", VA = "0x184BEB900")]
	public IBMPPKILLBB<T>.DEPAMLLMAFP OMLAPONJPHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x496DDF0", Offset = "0x496CDF0", VA = "0x18496DDF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x496DDF0", Offset = "0x496CDF0", VA = "0x18496DDF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OKKOOPCLDFO
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39D86F0", Offset = "0x39D76F0", VA = "0x1839D86F0")]
	public static IBMPPKILLBB<T> ACADPGMDEBE<T>(int CFNMLMNHCMF, Func<T> NNLDCALBAID) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A740", Offset = "0x7D89740", VA = "0x187D8A740")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A700", Offset = "0x7D89700", VA = "0x187D8A700")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A720", Offset = "0x7D89720", VA = "0x187D8A720")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A760", Offset = "0x7D89760", VA = "0x187D8A760")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A6E0", Offset = "0x7D896E0", VA = "0x187D8A6E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2782E40", Offset = "0x2781E40", VA = "0x182782E40")]
		public RRColor(float NFFBJCCKPJF, float NBMDAEPHDMM, float CNIMJCCKEDM, float FDJHCIBLFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F000", Offset = "0x7C4E000", VA = "0x187C4F000", Slot = "4")]
		public bool Equals(RRColor MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A320", Offset = "0x7D89320", VA = "0x187D8A320", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A420", Offset = "0x7D89420", VA = "0x187D8A420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A4A0", Offset = "0x7D894A0", VA = "0x187D8A4A0", Slot = "5")]
		public string ToString(string CKHLMMECGLE, IFormatProvider AMMODFLNLEK)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A2C0", Offset = "0x7D892C0", VA = "0x187D8A2C0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A260", Offset = "0x7D89260", VA = "0x187D8A260")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A290", Offset = "0x7D89290", VA = "0x187D8A290")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A2F0", Offset = "0x7D892F0", VA = "0x187D8A2F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A230", Offset = "0x7D89230", VA = "0x187D8A230")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5C7D0A0", Offset = "0x5C7C0A0", VA = "0x185C7D0A0")]
		public RRColor32(byte NFFBJCCKPJF, byte NBMDAEPHDMM, byte CNIMJCCKEDM, byte FDJHCIBLFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x213A3A0", Offset = "0x21393A0", VA = "0x18213A3A0", Slot = "4")]
		public bool Equals(RRColor32 MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D89D70", Offset = "0x7D88D70", VA = "0x187D89D70", Slot = "0")]
		public override bool Equals(object MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x12B3880", Offset = "0x12B2880", VA = "0x1812B3880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D89E70", Offset = "0x7D88E70", VA = "0x187D89E70")]
		public static RRColor32 OIFHDJNIHDL(RRColor JKIBOICMIDJ)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D89E00", Offset = "0x7D88E00", VA = "0x187D89E00")]
		public static RRColor OIFHDJNIHDL(RRColor32 JKIBOICMIDJ)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7D89FC0", Offset = "0x7D88FC0", VA = "0x187D89FC0", Slot = "5")]
		public string ToString(string CKHLMMECGLE, IFormatProvider AMMODFLNLEK)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class CDFGKJPNDEB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct KPMEOJKKMFM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly CDFGKJPNDEB<T> HKMHKAFJGJP;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x502CF50", Offset = "0x502BF50", VA = "0x18502CF50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x502CF70", Offset = "0x502BF70", VA = "0x18502CF70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
		public KPMEOJKKMFM(CDFGKJPNDEB<T> HKMHKAFJGJP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NKHADFCBGCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<KPMEOJKKMFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CDFGKJPNDEB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x53EDC00", Offset = "0x53ECC00", VA = "0x1853EDC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x498CF60", Offset = "0x498BF60", VA = "0x18498CF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim ACKDLIJPIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T LJEENFPIGIA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x67A60A0", Offset = "0x67A50A0", VA = "0x1867A60A0")]
	public CDFGKJPNDEB([In] T LJEENFPIGIA, int BOOHLFKJKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x67A6140", Offset = "0x67A5140", VA = "0x1867A6140")]
	public CDFGKJPNDEB([In] T LJEENFPIGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x67A59F0", Offset = "0x67A49F0", VA = "0x1867A59F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x67A5A50", Offset = "0x67A4A50", VA = "0x1867A5A50")]
	public KPMEOJKKMFM HEDCIKIEJKN()
	{
		return default(KPMEOJKKMFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x67A5E20", Offset = "0x67A4E20", VA = "0x1867A5E20")]
	[AsyncStateMachine(typeof(CDFGKJPNDEB<>.NKHADFCBGCC))]
	public Task<CDFGKJPNDEB<T>.KPMEOJKKMFM> MOLPCGDJDLH(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x67A5A30", Offset = "0x67A4A30", VA = "0x1867A5A30")]
	public void HBMPBEFNNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DLFHKKDNIFG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7D86590", Offset = "0x7D85590", VA = "0x187D86590")]
	public static CDFGKJPNDEB<BONGKMFJEJA> ACADPGMDEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x36A7050", Offset = "0x36A6050", VA = "0x1836A7050")]
	public static CDFGKJPNDEB<T> ACADPGMDEBE<T>([In] T LJEENFPIGIA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class IHAOANGCKIP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct NPMPGHICDJA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly IHAOANGCKIP<T> GHJHLELBCEA;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5408820", Offset = "0x5407820", VA = "0x185408820")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5408840", Offset = "0x5407840", VA = "0x185408840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
		internal NPMPGHICDJA(IHAOANGCKIP<T> HKMHKAFJGJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct DONPNPEBIPE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly IHAOANGCKIP<T> GHJHLELBCEA;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5408820", Offset = "0x5407820", VA = "0x185408820")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E530", Offset = "0x6A6D530", VA = "0x186A6E530", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
		internal DONPNPEBIPE(IHAOANGCKIP<T> HKMHKAFJGJP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct JPMOGOPBGEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<DONPNPEBIPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IHAOANGCKIP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private CDFGKJPNDEB<BONGKMFJEJA>.KPMEOJKKMFM <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<CDFGKJPNDEB<BONGKMFJEJA>.KPMEOJKKMFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA33C0", Offset = "0x4EA23C0", VA = "0x184EA33C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x498CF60", Offset = "0x498BF60", VA = "0x18498CF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CDFGKJPNDEB<int> FCBPGICOMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CDFGKJPNDEB<BONGKMFJEJA> OBHOFBEBNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CDFGKJPNDEB<BONGKMFJEJA> GOANIPKJECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T HHFHEIMGHGP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4C044D0", Offset = "0x4C034D0", VA = "0x184C044D0")]
	internal IHAOANGCKIP(CDFGKJPNDEB<int> EIMPBDDCPCK, CDFGKJPNDEB<BONGKMFJEJA> IJNDFJKJBHC, CDFGKJPNDEB<BONGKMFJEJA> AJMAGCOAPOG, [In] T LJEENFPIGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4C03730", Offset = "0x4C02730", VA = "0x184C03730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4C03D40", Offset = "0x4C02D40", VA = "0x184C03D40")]
	public NPMPGHICDJA NPNJAONMOHB()
	{
		return default(NPMPGHICDJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4C039A0", Offset = "0x4C029A0", VA = "0x184C039A0")]
	public DONPNPEBIPE FOKICFNDJFF()
	{
		return default(DONPNPEBIPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4C040C0", Offset = "0x4C030C0", VA = "0x184C040C0")]
	[AsyncStateMachine(typeof(IHAOANGCKIP<>.JPMOGOPBGEE))]
	public Task<IHAOANGCKIP<T>.DONPNPEBIPE> OLAOPJBABKD(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IBLLDCHLEAH
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7D87EA0", Offset = "0x7D86EA0", VA = "0x187D87EA0")]
	public static IHAOANGCKIP<BONGKMFJEJA> ACADPGMDEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x387BB50", Offset = "0x387AB50", VA = "0x18387BB50")]
	public static IHAOANGCKIP<T> ACADPGMDEBE<T>([In] T LJEENFPIGIA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class KHNHKAGGAAA<TData> : OGMCLKGLBPG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string LNILHMKIEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData HCNIDPKECHH;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA8B0", Offset = "0x4FD98B0", VA = "0x184FDA8B0")]
	internal KHNHKAGGAAA(string NAAMEAFIHJI, [In] TData APDBNIMCPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HDGFKEPBFNA
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7D874F0", Offset = "0x7D864F0", VA = "0x187D874F0")]
	public static KHNHKAGGAAA<BONGKMFJEJA> ACADPGMDEBE(string NAAMEAFIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x36E6230", Offset = "0x36E5230", VA = "0x1836E6230")]
	public static KHNHKAGGAAA<TData> ACADPGMDEBE<TData>(string NAAMEAFIHJI, [In] TData APDBNIMCPID) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class IKOMJAOIFBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool DIAGLAMEIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string JIBDIFKMODN;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xE063D0", Offset = "0xE053D0", VA = "0x180E063D0")]
	private IKOMJAOIFBO(bool HHCLFFGGMOM, string OFAJEGKFDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7D87F70", Offset = "0x7D86F70", VA = "0x187D87F70")]
	public static IKOMJAOIFBO ACADPGMDEBE(string OFAJEGKFDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7D87FE0", Offset = "0x7D86FE0", VA = "0x187D87FE0")]
	public JIAPKFDFLEC PNEMLBOPKAD()
	{
		return default(JIAPKFDFLEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct JIAPKFDFLEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IKOMJAOIFBO JILCBMCCCCI;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
	internal JIAPKFDFLEC(IKOMJAOIFBO INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7D88BB0", Offset = "0x7D87BB0", VA = "0x187D88BB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class OJAGPBLHCJG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class ICMCGLDCCFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ICMCGLDCCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4BEFAD0", Offset = "0x4BEEAD0", VA = "0x184BEFAD0")]
		internal int BKBAEDABKBJ(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? KKADDLCCCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> HGHCCAKDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5529F70", Offset = "0x5528F70", VA = "0x185529F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PCICPEBGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5529B80", Offset = "0x5528B80", VA = "0x185529B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5529DA0", Offset = "0x5528DA0", VA = "0x185529DA0")]
	public bool IIGLPCDPOEE(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5529C20", Offset = "0x5528C20", VA = "0x185529C20")]
	public bool GNAALOCCJEL(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5529BD0", Offset = "0x5528BD0", VA = "0x185529BD0")]
	public bool DGAEJOHLCDJ(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5529AA0", Offset = "0x5528AA0", VA = "0x185529AA0")]
	public void APMCNHFNGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5529FB0", Offset = "0x5528FB0", VA = "0x185529FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OJAGPBLHCJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class PHIGNGELHED
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NKGDJFBMEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NKGDJFBMEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7D88EB0", Offset = "0x7D87EB0", VA = "0x187D88EB0")]
		internal int BKBAEDABKBJ(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? KKADDLCCCFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> HGHCCAKDLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7D89AD0", Offset = "0x7D88AD0", VA = "0x187D89AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PCICPEBGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7D898E0", Offset = "0x7D888E0", VA = "0x187D898E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7D899F0", Offset = "0x7D889F0", VA = "0x187D899F0")]
	public bool IIGLPCDPOEE(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7D89950", Offset = "0x7D88950", VA = "0x187D89950")]
	public bool GNAALOCCJEL(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7D898F0", Offset = "0x7D888F0", VA = "0x187D898F0")]
	public bool DGAEJOHLCDJ(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7D89870", Offset = "0x7D88870", VA = "0x187D89870")]
	public void APMCNHFNGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7D89B60", Offset = "0x7D88B60", VA = "0x187D89B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PHIGNGELHED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GCBGOACHPCG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct GMNEBAHJIAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float IOJHJCADCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T FPGFCMMHMJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, GMNEBAHJIAE> BCFIBNCLPAG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T GHJEAJCFOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x19428A0", Offset = "0x19418A0", VA = "0x1819428A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1940E70", Offset = "0x193FE70", VA = "0x181940E70", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? BCBOBODMLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HJEIAMHJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4A44E70", Offset = "0x4A43E70", VA = "0x184A44E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A2A0", Offset = "0x4A492A0", VA = "0x184A4A2A0")]
	public bool KEOHOAAEDBA(T OHLIHBDBKCE, object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4A44DD0", Offset = "0x4A43DD0", VA = "0x184A44DD0")]
	public bool BLDIAILIAMJ(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x492B490", Offset = "0x492A490", VA = "0x18492B490")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A7B0", Offset = "0x4A497B0", VA = "0x184A4A7B0")]
	public bool LKMKPGKLGLC(object EJJDDFFADPC, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4A49010", Offset = "0x4A48010", VA = "0x184A49010")]
	[MAKNJFCMNJF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JJIOGHKNFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AAA0", Offset = "0x4A49AA0", VA = "0x184A4AAA0")]
	public GCBGOACHPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class JDAIBCKBDGJ : MNBEOGMBAED<BDMLCHKFOFH>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class MEAPILPCFGH : IEqualityComparer<BDMLCHKFOFH>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly MEAPILPCFGH MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7D88C70", Offset = "0x7D87C70", VA = "0x187D88C70", Slot = "4")]
		public bool Equals(BDMLCHKFOFH CEJAAIDLEPA, BDMLCHKFOFH IMNDAJIDDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6F29350", Offset = "0x6F28350", VA = "0x186F29350", Slot = "5")]
		public int GetHashCode(BDMLCHKFOFH BOMDCGFKGKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MEAPILPCFGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7D88850", Offset = "0x7D87850", VA = "0x187D88850")]
	public JDAIBCKBDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7D88710", Offset = "0x7D87710", VA = "0x187D88710", Slot = "4")]
	public override bool IIGLPCDPOEE(BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7D88660", Offset = "0x7D87660", VA = "0x187D88660", Slot = "5")]
	public override bool GNAALOCCJEL(BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7D887C0", Offset = "0x7D877C0", VA = "0x187D887C0")]
	private static void MBGACHMHAHF(BDMLCHKFOFH EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x181F1E0", Offset = "0x181E1E0", VA = "0x18181F1E0", Slot = "6")]
	protected override string TokenToString(BDMLCHKFOFH EJJDDFFADPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class BDMLCHKFOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string BMELCPJFNEC;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public BDMLCHKFOFH(string BMELCPJFNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7D86540", Offset = "0x7D85540", VA = "0x187D86540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class MNBEOGMBAED<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> EFGNCEEFOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? KKADDLCCCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool PCICPEBGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x53510E0", Offset = "0x53500E0", VA = "0x1853510E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5351E00", Offset = "0x5350E00", VA = "0x185351E00")]
	public MNBEOGMBAED(IEqualityComparer<T> EFGNCEEFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5351610", Offset = "0x5350610", VA = "0x185351610", Slot = "4")]
	public virtual bool IIGLPCDPOEE(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x53512B0", Offset = "0x53502B0", VA = "0x1853512B0", Slot = "5")]
	public virtual bool GNAALOCCJEL(T EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5351000", Offset = "0x5350000", VA = "0x185351000")]
	public void APMCNHFNGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5351AF0", Offset = "0x5350AF0", VA = "0x185351AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class LMNICFCCFJG<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? KKADDLCCCFJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PCICPEBGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5127190", Offset = "0x5126190", VA = "0x185127190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x51276F0", Offset = "0x51266F0", VA = "0x1851276F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5127470", Offset = "0x5126470", VA = "0x185127470")]
	public void IIGLPCDPOEE(T EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x51272C0", Offset = "0x51262C0", VA = "0x1851272C0")]
	public void GNAALOCCJEL(T EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5127140", Offset = "0x5126140", VA = "0x185127140")]
	public void APMCNHFNGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x51278A0", Offset = "0x51268A0", VA = "0x1851278A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LMNICFCCFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class AECHBLHKOGP
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x362C370", Offset = "0x362B370", VA = "0x18362C370")]
	public static void FMOLGLEKKMF<T>(this List<T> OLEDHEBBJPH, int OHHMJGCBCKD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GAHFMPEKOIE<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct NLFHIMLFEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float IOJHJCADCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T FPGFCMMHMJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<BDMLCHKFOFH, NLFHIMLFEMD> BCFIBNCLPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> IPPEFIAKPDE;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T GHJEAJCFOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9F1560", Offset = "0x9F0560", VA = "0x1809F1560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9F1530", Offset = "0x9F0530", VA = "0x1809F1530", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private BDMLCHKFOFH? BCBOBODMLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HJEIAMHJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4A44E70", Offset = "0x4A43E70", VA = "0x184A44E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4A45490", Offset = "0x4A44490", VA = "0x184A45490")]
	public bool KEOHOAAEDBA(T OHLIHBDBKCE, BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4A44DD0", Offset = "0x4A43DD0", VA = "0x184A44DD0")]
	public bool BLDIAILIAMJ(BDMLCHKFOFH EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x492B490", Offset = "0x492A490", VA = "0x18492B490")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4A45750", Offset = "0x4A44750", VA = "0x184A45750")]
	public bool LKMKPGKLGLC(BDMLCHKFOFH EJJDDFFADPC, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4A44ED0", Offset = "0x4A43ED0", VA = "0x184A44ED0")]
	[MAKNJFCMNJF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JJIOGHKNFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4A457E0", Offset = "0x4A447E0", VA = "0x184A457E0")]
	public GAHFMPEKOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JEAJAHJCLOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> BCFIBNCLPAG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float AKIJPGKGPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xECEA30", Offset = "0xECDA30", VA = "0x180ECEA30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xECEA40", Offset = "0xECDA40", VA = "0x180ECEA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7D88AB0", Offset = "0x7D87AB0", VA = "0x187D88AB0")]
	public void KEOHOAAEDBA(float OHLIHBDBKCE, object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7D889F0", Offset = "0x7D879F0", VA = "0x187D889F0")]
	public void BLDIAILIAMJ(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7D88A60", Offset = "0x7D87A60", VA = "0x187D88A60")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7D888C0", Offset = "0x7D878C0", VA = "0x187D888C0")]
	private void BLCDACINCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7D88B20", Offset = "0x7D87B20", VA = "0x187D88B20")]
	public JEAJAHJCLOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface AEAIFIOMDPM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BFAMDEMJIGI GIDLGFMCOMO;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class HKMALGKDFBG : AEAIFIOMDPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct EILJMFGIJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float JDIKNMDACEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float DCICOKIGPEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool LKIDIFGHMGH;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float EOMGDLMNCFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x7D86600", Offset = "0x7D85600", VA = "0x187D86600")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7D86780", Offset = "0x7D85780", VA = "0x187D86780")]
		public EILJMFGIJBO(float IPAELMFFKOA, float LLDMNGOPBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7D86610", Offset = "0x7D85610", VA = "0x187D86610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OHMBIEBEOBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HKMALGKDFBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OHMBIEBEOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7D896F0", Offset = "0x7D886F0", VA = "0x187D896F0")]
		internal void NHEKGNGAEAP(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int GDBMBEIFFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int AJEEDJCCIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly AEAIFIOMDPM[] GIGINGDGBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly BFAMDEMJIGI[] DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EILJMFGIJBO[] NPCCCFOBCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EILJMFGIJBO LMJHJMNFFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BAKGMMHDEOL DADJCKNLEBC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BFAMDEMJIGI GIDLGFMCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7D87740", Offset = "0x7D86740", VA = "0x187D87740", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7D87570", Offset = "0x7D86570", VA = "0x187D87570", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7D87D10", Offset = "0x7D86D10", VA = "0x187D87D10")]
	public HKMALGKDFBG(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7D87C80", Offset = "0x7D86C80", VA = "0x187D87C80")]
	public BAKGMMHDEOL NENEAGDPGIP(EILJMFGIJBO OOGHBEFHNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7D87800", Offset = "0x7D86800", VA = "0x187D87800")]
	public void JNBLAKPOPPE(AEAIFIOMDPM NLLBBIJADDJ, [Optional] EILJMFGIJBO FLDKJLNEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7D87630", Offset = "0x7D86630", VA = "0x187D87630", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void BFAMDEMJIGI(float NHDJKKLKHBP);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IPPGICFCFLI
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class PBEODNNBAMB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly AEAIFIOMDPM CMOPECAAOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly BFAMDEMJIGI COLEJLDPDCO;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7D897E0", Offset = "0x7D887E0", VA = "0x187D897E0")]
		public PBEODNNBAMB(AEAIFIOMDPM CMOPECAAOEJ, BFAMDEMJIGI COLEJLDPDCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7D89790", Offset = "0x7D88790", VA = "0x187D89790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7D88530", Offset = "0x7D87530", VA = "0x187D88530")]
	internal static bool GDMCOJJAPEB(float FDJHCIBLFFB, float CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7D75080", Offset = "0x7D74080", VA = "0x187D75080")]
	internal static float GKLDJAMPMPM(float FDJHCIBLFFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7D885A0", Offset = "0x7D875A0", VA = "0x187D885A0")]
	public static IDisposable PFAELLDPAGL(this AEAIFIOMDPM CMOPECAAOEJ, BFAMDEMJIGI COLEJLDPDCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BAKGMMHDEOL : AEAIFIOMDPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float NHDJKKLKHBP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float HPDONMNCHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7D86450", Offset = "0x7D85450", VA = "0x187D86450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BFAMDEMJIGI? GIDLGFMCOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7D863B0", Offset = "0x7D853B0", VA = "0x187D863B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7D86310", Offset = "0x7D85310", VA = "0x187D86310", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BAKGMMHDEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface HJJLLGOMIMK<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLMBDIOJEPP<T> CILCEMKBDAL([Out] T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INBDHNEFJBE();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class PAILFHFIMIL<T> : HJJLLGOMIMK<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> HCLNIFBCCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x55F5790", Offset = "0x55F4790", VA = "0x1855F5790", Slot = "4")]
	public CLMBDIOJEPP<T> CILCEMKBDAL([Out] T OHLIHBDBKCE)
	{
		return default(CLMBDIOJEPP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x55F5830", Offset = "0x55F4830", VA = "0x1855F5830")]
	public void KKIPOBFIFOD(T HPHFCNFHHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4A89F50", Offset = "0x4A88F50", VA = "0x184A89F50", Slot = "5")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "6")]
	protected virtual void AFNGOEBMCCG(T LNLDMEGOIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x55F58B0", Offset = "0x55F48B0", VA = "0x1855F58B0")]
	private T PHDCGNDDLGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x55F5960", Offset = "0x55F4960", VA = "0x1855F5960")]
	public PAILFHFIMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct CLMBDIOJEPP<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T HPHFCNFHHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PAILFHFIMIL<T> CNODPANFMJB;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
	internal CLMBDIOJEPP(T OHLIHBDBKCE, PAILFHFIMIL<T> CNODPANFMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x67E8670", Offset = "0x67E7670", VA = "0x1867E8670", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NAJAMDAFNEO : PAILFHFIMIL<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly NAJAMDAFNEO MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7D88D30", Offset = "0x7D87D30", VA = "0x187D88D30")]
	public static CLMBDIOJEPP<StringBuilder> PHDCGNDDLGA([Out] StringBuilder OHLIHBDBKCE)
	{
		return default(CLMBDIOJEPP<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7D88D10", Offset = "0x7D87D10", VA = "0x187D88D10", Slot = "6")]
	protected override void AFNGOEBMCCG(StringBuilder LNLDMEGOIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7D88E70", Offset = "0x7D87E70", VA = "0x187D88E70")]
	public NAJAMDAFNEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PIPFJMHCGBB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x76761B0", Offset = "0x76751B0", VA = "0x1876761B0")]
	public PIPFJMHCGBB(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class CJPADBAAHLA<TKey, TValue> : OCCLPCKCBCG<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, BKLADMDPEGM where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class NOOMAGMIMLP : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CJPADBAAHLA<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x19428A0", Offset = "0x19418A0", VA = "0x1819428A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x49D1670", Offset = "0x49D0670", VA = "0x1849D1670", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public NOOMAGMIMLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x48C7170", Offset = "0x48C6170", VA = "0x1848C7170", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x54003A0", Offset = "0x53FF3A0", VA = "0x1854003A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x53FFB80", Offset = "0x53FEB80", VA = "0x1853FFB80")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5400790", Offset = "0x53FF790", VA = "0x185400790")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5400880", Offset = "0x53FF880", VA = "0x185400880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly OCCLPCKCBCG<TKey, TValue> LIAHGDFAGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> ABODHAAGEAK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x67E6230", Offset = "0x67E5230", VA = "0x1867E6230", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x67E6300", Offset = "0x67E5300", VA = "0x1867E6300", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x67E65D0", Offset = "0x67E55D0", VA = "0x1867E65D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> JABHKAJJCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x67E6390", Offset = "0x67E5390", VA = "0x1867E6390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> CLOMIHCLDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x67E64B0", Offset = "0x67E54B0", VA = "0x1867E64B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67E5FC0", Offset = "0x67E4FC0", VA = "0x1867E5FC0")]
	public CJPADBAAHLA(OCCLPCKCBCG<TKey, TValue> LIAHGDFAGBG, [Optional] IDictionary<TKey, TValue>? ABODHAAGEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x67E3860", Offset = "0x67E2860", VA = "0x1867E3860", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67E4620", Offset = "0x67E3620", VA = "0x1867E4620")]
	public void FMFABMFMKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67E32C0", Offset = "0x67E22C0", VA = "0x1867E32C0", Slot = "9")]
	public void Add(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67E4740", Offset = "0x67E3740", VA = "0x1867E4740")]
	public void FODMEGOOLPJ(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67E5210", Offset = "0x67E4210", VA = "0x1867E5210")]
	public void PPMIMHNBPNL(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x67E4C90", Offset = "0x67E3C90", VA = "0x1867E4C90")]
	public void OGFCFHDNDAJ(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x67E4160", Offset = "0x67E3160", VA = "0x1867E4160")]
	public void DMMKIMJDHFL(TKey OEHHKNIGGMI, TValue OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x67E5600", Offset = "0x67E4600", VA = "0x1867E5600", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x67E56A0", Offset = "0x67E46A0", VA = "0x1867E56A0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x67E59F0", Offset = "0x67E49F0", VA = "0x1867E59F0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x67E39A0", Offset = "0x67E29A0", VA = "0x1867E39A0", Slot = "8")]
	public bool ContainsKey(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x67E4BC0", Offset = "0x67E3BC0", VA = "0x1867E4BC0")]
	public bool OFEMHGMMPGE(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x67E4A90", Offset = "0x67E3A90", VA = "0x1867E4A90")]
	public bool IOIFGPOAECE(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x67E5460", Offset = "0x67E4460", VA = "0x1867E5460", Slot = "10")]
	public bool Remove(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x67E5D40", Offset = "0x67E4D40", VA = "0x1867E5D40", Slot = "11")]
	public bool TryGetValue(TKey OEHHKNIGGMI, [Out] TValue OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x67E3CC0", Offset = "0x67E2CC0", VA = "0x1867E3CC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F244C0", Offset = "0x4F234C0", VA = "0x184F244C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x67E4980", Offset = "0x67E3980", VA = "0x1867E4980", Slot = "19")]
	[IteratorStateMachine(typeof(CJPADBAAHLA<, >.NOOMAGMIMLP))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x67E37C0", Offset = "0x67E27C0", VA = "0x1867E37C0", Slot = "21")]
	public bool CBBCAAJLNNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x67E4510", Offset = "0x67E3510", VA = "0x1867E4510")]
	private TValue DNKIIKLDKKL(TKey OEHHKNIGGMI)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface JGODANCIHHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string OGADDFNLPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface BKLADMDPEGM
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBBCAAJLNNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface OCCLPCKCBCG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, BKLADMDPEGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class FAKLKHOBCAF<TKey, TVal> : OCCLPCKCBCG<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, BKLADMDPEGM where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int KLHIIMGJNAN(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void JCNIAMJACJF(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE, AKOFMBHIPNP DKBCGBFNIGO);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class NEMNBEPDNDH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int EOMGDLMNCFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset OLNIMJCMBIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1286C40", Offset = "0x1285C40", VA = "0x181286C40")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1286C30", Offset = "0x1285C30", VA = "0x181286C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x53AA610", Offset = "0x53A9610", VA = "0x1853AA610")]
		public NEMNBEPDNDH(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class JNEGMHPBHMB : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public FAKLKHOBCAF<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<NEMNBEPDNDH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x19428A0", Offset = "0x19418A0", VA = "0x1819428A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x4E79E80", Offset = "0x4E78E80", VA = "0x184E79E80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public JNEGMHPBHMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x48C4F60", Offset = "0x48C3F60", VA = "0x1848C4F60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4E777C0", Offset = "0x4E767C0", VA = "0x184E777C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4E77140", Offset = "0x4E76140", VA = "0x184E77140")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4E79C00", Offset = "0x4E78C00", VA = "0x184E79C00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int EDANJLOMEGH = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<NEMNBEPDNDH>> OHFFBCEMMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<NEMNBEPDNDH> LIOAHNNFOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly KLHIIMGJNAN? NEIBHEBGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan GLKALOKLFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JCNIAMJACJF? AJBEMMOIIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly HGAOMCLAJHP GGEOBOOOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool CKODCHFAMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> FIPBJPFOGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> PECJGEGKENO;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int EFJAAKPECFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA00120", Offset = "0x9FF120", VA = "0x180A00120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int OHDAOPOFPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xD021E0", Offset = "0xD011E0", VA = "0x180D021E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xE31130", Offset = "0xE30130", VA = "0x180E31130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4936710", Offset = "0x4935710", VA = "0x184936710", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int AFEICHCHJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x492B490", Offset = "0x492A490", VA = "0x18492B490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> CLOMIHCLDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4936860", Offset = "0x4935860", VA = "0x184936860", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.HAHEFDEMFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x49344A0", Offset = "0x49334A0", VA = "0x1849344A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4936800", Offset = "0x4935800", VA = "0x184936800", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4936910", Offset = "0x4935910", VA = "0x184936910", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x492A580", Offset = "0x4929580", VA = "0x18492A580")]
	private bool BEMCBPGPIOI(int GDBMBEIFFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4932930", Offset = "0x4931930", VA = "0x184932930")]
	private void OLFBLCMDKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4936630", Offset = "0x4935630", VA = "0x184936630")]
	public FAKLKHOBCAF(int GDBMBEIFFOO, [Optional] KLHIIMGJNAN? NEIBHEBGDCA, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] JCNIAMJACJF? AJBEMMOIIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x49350D0", Offset = "0x49340D0", VA = "0x1849350D0")]
	public FAKLKHOBCAF(TimeSpan GLKALOKLFGM, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] JCNIAMJACJF? AJBEMMOIIJP, [Optional] HGAOMCLAJHP? GGEOBOOOEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4935CD0", Offset = "0x4934CD0", VA = "0x184935CD0")]
	public FAKLKHOBCAF(int GDBMBEIFFOO, TimeSpan GLKALOKLFGM, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] JCNIAMJACJF? AJBEMMOIIJP, [Optional] HGAOMCLAJHP? GGEOBOOOEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4935D50", Offset = "0x4934D50", VA = "0x184935D50")]
	public FAKLKHOBCAF(int GDBMBEIFFOO, KLHIIMGJNAN? NEIBHEBGDCA, TimeSpan GLKALOKLFGM, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] JCNIAMJACJF? AJBEMMOIIJP, [Optional] HGAOMCLAJHP? GGEOBOOOEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x492A5D0", Offset = "0x49295D0", VA = "0x18492A5D0", Slot = "21")]
	public bool CBBCAAJLNNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x492B3E0", Offset = "0x492A3E0", VA = "0x18492B3E0", Slot = "22")]
	public bool CFHLGKLFNEA(int CFNMLMNHCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x492D8D0", Offset = "0x492C8D0", VA = "0x18492D8D0")]
	private bool DIEKDCIABIJ(int CFNMLMNHCMF, AKOFMBHIPNP DKBCGBFNIGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x492CB10", Offset = "0x492BB10", VA = "0x18492CB10")]
	public void DGBNDJBCMEF(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4929D10", Offset = "0x4928D10", VA = "0x184929D10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x492A410", Offset = "0x4929410", VA = "0x18492A410", Slot = "9")]
	public void Add(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x492B6E0", Offset = "0x492A6E0", VA = "0x18492B6E0", Slot = "8")]
	public bool ContainsKey(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4934030", Offset = "0x4933030", VA = "0x184934030", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4933E20", Offset = "0x4932E20", VA = "0x184933E20", Slot = "10")]
	public bool Remove(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4934210", Offset = "0x4933210", VA = "0x184934210", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x49333C0", Offset = "0x49323C0", VA = "0x1849333C0")]
	private bool PGAFKNEHGID(TKey OEHHKNIGGMI, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x49338B0", Offset = "0x49328B0", VA = "0x1849338B0")]
	private TVal PHDCGNDDLGA(TKey KBMOAEOFKJM)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4934530", Offset = "0x4933530", VA = "0x184934530", Slot = "11")]
	public bool TryGetValue(TKey KBMOAEOFKJM, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x492B4F0", Offset = "0x492A4F0", VA = "0x18492B4F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x492BE20", Offset = "0x492AE20", VA = "0x18492BE20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4930BE0", Offset = "0x492FBE0", VA = "0x184930BE0")]
	private void FKAKKEJCDGG(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF, AKOFMBHIPNP DKBCGBFNIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x49314A0", Offset = "0x49304A0", VA = "0x1849314A0")]
	private bool ICMEFLHHPNM(NEMNBEPDNDH NEGDNCJNBAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4930240", Offset = "0x492F240", VA = "0x184930240")]
	private void EMJICAOGPJD(LinkedListNode<NEMNBEPDNDH> KFIMPLBHNNM, TVal DAIGGDIKJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4931EE0", Offset = "0x4930EE0", VA = "0x184931EE0")]
	private void KEOHOAAEDBA(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x492AAC0", Offset = "0x4929AC0", VA = "0x18492AAC0")]
	private void CCNAGEFKGNM(NEMNBEPDNDH NEGDNCJNBAH, TVal DAIGGDIKJOJ, int IPMBIEKIIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4930F40", Offset = "0x492FF40", VA = "0x184930F40", Slot = "19")]
	[IteratorStateMachine(typeof(FAKLKHOBCAF<, >.JNEGMHPBHMB))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x49344F0", Offset = "0x49334F0", VA = "0x1849344F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum AKOFMBHIPNP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class PDLEACCAFIO<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey FBPDAJEOIKF;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x55FC100", Offset = "0x55FB100", VA = "0x1855FC100")]
	public PDLEACCAFIO(TKey FDFHAKBKBHC, Exception HBNIOKPNOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class IPNJCDGFAOB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EC4AF0", Offset = "0x6EC3AF0", VA = "0x186EC4AF0")]
	public IPNJCDGFAOB(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DCMNDOHINLE<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class BIGCEJPHBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public DCMNDOHINLE<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BIGCEJPHBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x63AA2E0", Offset = "0x63A92E0", VA = "0x1863AA2E0")]
		internal Task<TResource> ODHAIPGEKKC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct KADIOGLBAHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public DCMNDOHINLE<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4F4B660", Offset = "0x4F4A660", VA = "0x184F4B660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x4F4BC40", Offset = "0x4F4AC40", VA = "0x184F4BC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct CMGLAGLNIEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x67F47E0", Offset = "0x67F37E0", VA = "0x1867F47E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x67F54A0", Offset = "0x67F44A0", VA = "0x1867F54A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly OFHFIGEMBPB<TId, Task<TResource>> PLDGMLEMENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> MNHGFOKAOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CNCNIKKDHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? NMGIABCLOEC;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A52AC0", Offset = "0x6A51AC0", VA = "0x186A52AC0")]
	public DCMNDOHINLE(int HNDEALABJHB = 0, [Optional] IEqualityComparer<TId>? NCCENAFDELI, [Optional] Func<TId, CancellationToken, Task<TResource>>? CBBEBIHJHCE, [Optional] Action<TResource>? HCNJDGNNCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A51240", Offset = "0x6A50240", VA = "0x186A51240")]
	public CLCFAKNAJCK<Task<TResource>> DJBJOAFCKAH(TId HJPLNJNIFLL, [Optional] Func<TId, CancellationToken, Task<TResource>>? CBBEBIHJHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A524F0", Offset = "0x6A514F0", VA = "0x186A524F0")]
	private void OAEBBEFCKCM(Task<TResource> BGKKDAHMDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A519D0", Offset = "0x6A509D0", VA = "0x186A519D0")]
	[AsyncStateMachine(typeof(DCMNDOHINLE<, >.KADIOGLBAHP))]
	private Task FBBIBNAGOJG(Task<TResource> BGKKDAHMDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x67FB050", Offset = "0x67FA050", VA = "0x1867FB050")]
	public void FENMDCKDFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A52750", Offset = "0x6A51750", VA = "0x186A52750")]
	public OFHFIGEMBPB<TId, Task<TResource>>.MJPBKMHHPEJ OMLAPONJPHN()
	{
		return default(OFHFIGEMBPB<TId, Task<TResource>>.MJPBKMHHPEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A52970", Offset = "0x6A51970", VA = "0x186A52970", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A52970", Offset = "0x6A51970", VA = "0x186A52970", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A52030", Offset = "0x6A51030", VA = "0x186A52030")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DCMNDOHINLE<, >.CMGLAGLNIEC))]
	internal static Task NEIACFHDFIK(Task<TResource> BGKKDAHMDLM, CancellationTokenSource HELAMEEKEEM, Dictionary<Task<TResource>, CancellationTokenSource> BIINMLCHMEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class OFHFIGEMBPB<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class BILPAFNGAAN : IEquatable<BILPAFNGAAN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue FPGFCMMHMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int DPOJKCPEKAH;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x11856E0", Offset = "0x11846E0", VA = "0x1811856E0")]
		public BILPAFNGAAN(TValue OHLIHBDBKCE, int ICBCBEKDOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x63AA7E0", Offset = "0x63A97E0", VA = "0x1863AA7E0", Slot = "4")]
		public bool Equals(BILPAFNGAAN? MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x63AA730", Offset = "0x63A9730", VA = "0x1863AA730", Slot = "0")]
		public override bool Equals(object? BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x63AA990", Offset = "0x63A9990", VA = "0x1863AA990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct MJPBKMHHPEJ : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, BILPAFNGAAN>.Enumerator OKLIBDLOGKI;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x533CF10", Offset = "0x533BF10", VA = "0x18533CF10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x533D2D0", Offset = "0x533C2D0", VA = "0x18533D2D0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x533D050", Offset = "0x533C050", VA = "0x18533D050")]
		public MJPBKMHHPEJ(OFHFIGEMBPB<TKey, TValue> BCFIBNCLPAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x533CAA0", Offset = "0x533BAA0", VA = "0x18533CAA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x533CB60", Offset = "0x533BB60", VA = "0x18533CB60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x533CBA0", Offset = "0x533BBA0", VA = "0x18533CBA0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class DNEHKCFEFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public OFHFIGEMBPB<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public BILPAFNGAAN refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DNEHKCFEFKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A940", Offset = "0x6A69940", VA = "0x186A6A940")]
		internal void ODHAIPGEKKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, BILPAFNGAAN> CFHABHJHHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? AEGONKOHIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? HGDHPKNBGEK;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5515780", Offset = "0x5514780", VA = "0x185515780")]
	public OFHFIGEMBPB(int HNDEALABJHB = 0, [Optional] IEqualityComparer<TKey>? FHGJDKOPHBN, [Optional] Func<TKey, TValue>? EGFCHFKNJIB, [Optional] Action<TValue>? MGPHFAIGLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5514110", Offset = "0x5513110", VA = "0x185514110")]
	public CLCFAKNAJCK<TValue> DJBJOAFCKAH(TKey OEHHKNIGGMI, [Optional] Func<TKey, TValue>? IALHFIIBJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5515120", Offset = "0x5514120", VA = "0x185515120")]
	private void KKIPOBFIFOD(TKey OEHHKNIGGMI, BILPAFNGAAN AKNJDJEBNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5514CB0", Offset = "0x5513CB0", VA = "0x185514CB0")]
	public void FENMDCKDFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5515510", Offset = "0x5514510", VA = "0x185515510")]
	public MJPBKMHHPEJ OMLAPONJPHN()
	{
		return default(MJPBKMHHPEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5515630", Offset = "0x5514630", VA = "0x185515630", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5515630", Offset = "0x5514630", VA = "0x185515630", Slot = "5")]
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
