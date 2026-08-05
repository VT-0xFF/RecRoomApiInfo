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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CEC10", Offset = "0x85CD210", VA = "0x1885CEC10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FOMLPLBFOIG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected FOMLPLBFOIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PMCCIKCFKAI<T> : FOMLPLBFOIG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct JIHNMKMMFLK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum MONJCOFKMNL
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
		public MONJCOFKMNL EHLAHNIAPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T CBDPHPPPDFI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int ANPBPLDFAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool LBIDOMNKACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool PGNFCBOBBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? FPHGJIIGJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<JIHNMKMMFLK>? MGIOCLPEJDC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LOOGIADNINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C85FC0", Offset = "0x5C845C0", VA = "0x185C85FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C86230", Offset = "0x5C84830", VA = "0x185C86230")]
	protected PMCCIKCFKAI(bool PGNFCBOBBNI, bool LBIDOMNKACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5C86010", Offset = "0x5C84610", VA = "0x185C86010")]
	protected bool MDLHHCHFMCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C85930", Offset = "0x5C83F30", VA = "0x185C85930")]
	protected void GEDAEPBOJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C85A40", Offset = "0x5C84040", VA = "0x185C85A40")]
	protected void GPIMHBAJCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x44E2910", Offset = "0x44E0F10", VA = "0x1844E2910")]
	private static void HBEEJDOCCLE<U>(List<U>? AHJLBOEGGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C85DE0", Offset = "0x5C843E0", VA = "0x185C85DE0", Slot = "4")]
	public void KMLBEHGKDFG(T CBDPHPPPDFI, bool LKCOFMEDJFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C85C20", Offset = "0x5C84220", VA = "0x185C85C20", Slot = "5")]
	public void HCDNAOEAAEJ(T CBDPHPPPDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C860B0", Offset = "0x5C846B0", VA = "0x185C860B0")]
	public void OOIGDCNPPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HBPNKKOKOOA : PMCCIKCFKAI<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85CCDB0", Offset = "0x85CB3B0", VA = "0x1885CCDB0")]
	public HBPNKKOKOOA(bool PGNFCBOBBNI = false, bool LBIDOMNKACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85CCB50", Offset = "0x85CB150", VA = "0x1885CCB50")]
	public void JKGEGDFKKNG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85CCAF0", Offset = "0x85CB0F0", VA = "0x1885CCAF0")]
	public static HBPNKKOKOOA HMGEOIDOOPE(HBPNKKOKOOA PLPBEMAPLEF, Action CBDPHPPPDFI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85CCD50", Offset = "0x85CB350", VA = "0x1885CCD50")]
	public static HBPNKKOKOOA PBENHLEGKII(HBPNKKOKOOA PLPBEMAPLEF, Action CBDPHPPPDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OEMLEMPIFDH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMLBEHGKDFG(Action<T> CBDPHPPPDFI, bool LKCOFMEDJFH = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCDNAOEAAEJ(Action<T> CBDPHPPPDFI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GJIKMKGBNOL<T> : PMCCIKCFKAI<Action<T>>, OEMLEMPIFDH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F30300", Offset = "0x4F2E900", VA = "0x184F30300")]
	public GJIKMKGBNOL(bool PGNFCBOBBNI = false, bool LBIDOMNKACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4FF2B60", Offset = "0x4FF1160", VA = "0x184FF2B60")]
	public void JKGEGDFKKNG(T IHNLGGEEIFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C0A0", Offset = "0x4F2A6A0", VA = "0x184F2C0A0")]
	public static GJIKMKGBNOL<T> HMGEOIDOOPE(GJIKMKGBNOL<T> PLPBEMAPLEF, Action<T> CBDPHPPPDFI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4F30270", Offset = "0x4F2E870", VA = "0x184F30270")]
	public static GJIKMKGBNOL<T> PBENHLEGKII(GJIKMKGBNOL<T> PLPBEMAPLEF, Action<T> CBDPHPPPDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ELFJAIPBENF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMLBEHGKDFG(Action<T, U> CBDPHPPPDFI, bool LKCOFMEDJFH = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCDNAOEAAEJ(Action<T, U> CBDPHPPPDFI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NCECCJAFPPJ<T, U> : PMCCIKCFKAI<Action<T, U>>, ELFJAIPBENF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F30300", Offset = "0x4F2E900", VA = "0x184F30300")]
	public NCECCJAFPPJ(bool PGNFCBOBBNI = false, bool LBIDOMNKACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x59C7A80", Offset = "0x59C6080", VA = "0x1859C7A80")]
	public void JKGEGDFKKNG(T IHNLGGEEIFC, U IENFLKPPKCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C0A0", Offset = "0x4F2A6A0", VA = "0x184F2C0A0")]
	public static NCECCJAFPPJ<T, U> HMGEOIDOOPE(NCECCJAFPPJ<T, U> PLPBEMAPLEF, Action<T, U> CBDPHPPPDFI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4F30270", Offset = "0x4F2E870", VA = "0x184F30270")]
	public static NCECCJAFPPJ<T, U> PBENHLEGKII(NCECCJAFPPJ<T, U> PLPBEMAPLEF, Action<T, U> CBDPHPPPDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FENKKBHLGFH<T, U, V> : PMCCIKCFKAI<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F30300", Offset = "0x4F2E900", VA = "0x184F30300")]
	public FENKKBHLGFH(bool PGNFCBOBBNI = false, bool LBIDOMNKACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4F2D6B0", Offset = "0x4F2BCB0", VA = "0x184F2D6B0")]
	public void JKGEGDFKKNG(T IHNLGGEEIFC, U IENFLKPPKCG, V EFGJHINBPCN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C0A0", Offset = "0x4F2A6A0", VA = "0x184F2C0A0")]
	public static FENKKBHLGFH<T, U, V> HMGEOIDOOPE(FENKKBHLGFH<T, U, V> PLPBEMAPLEF, Action<T, U, V> CBDPHPPPDFI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4F30270", Offset = "0x4F2E870", VA = "0x184F30270")]
	public static FENKKBHLGFH<T, U, V> PBENHLEGKII(FENKKBHLGFH<T, U, V> PLPBEMAPLEF, Action<T, U, V> CBDPHPPPDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BNHLBGDMFCJ<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class KANEHOOLHFD<T, U, V, W> : PMCCIKCFKAI<Action<T, U, V, W>>, BNHLBGDMFCJ<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4F30300", Offset = "0x4F2E900", VA = "0x184F30300")]
	public KANEHOOLHFD(bool PGNFCBOBBNI = false, bool LBIDOMNKACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x55A5FF0", Offset = "0x55A45F0", VA = "0x1855A5FF0")]
	public void JKGEGDFKKNG(T IHNLGGEEIFC, U IENFLKPPKCG, V EFGJHINBPCN, W EDHBJBGECMO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C0A0", Offset = "0x4F2A6A0", VA = "0x184F2C0A0")]
	public static KANEHOOLHFD<T, U, V, W> HMGEOIDOOPE(KANEHOOLHFD<T, U, V, W> PLPBEMAPLEF, Action<T, U, V, W> CBDPHPPPDFI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4F30270", Offset = "0x4F2E870", VA = "0x184F30270")]
	public static KANEHOOLHFD<T, U, V, W> PBENHLEGKII(KANEHOOLHFD<T, U, V, W> PLPBEMAPLEF, Action<T, U, V, W> CBDPHPPPDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HFOGABCADOI<T, U, V, W, X> : PMCCIKCFKAI<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4F30300", Offset = "0x4F2E900", VA = "0x184F30300")]
	public HFOGABCADOI(bool PGNFCBOBBNI = false, bool LBIDOMNKACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x50B52C0", Offset = "0x50B38C0", VA = "0x1850B52C0")]
	public void JKGEGDFKKNG(T IHNLGGEEIFC, U IENFLKPPKCG, V EFGJHINBPCN, W EDHBJBGECMO, X POMPNNDHCKO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C0A0", Offset = "0x4F2A6A0", VA = "0x184F2C0A0")]
	public static HFOGABCADOI<T, U, V, W, X> HMGEOIDOOPE(HFOGABCADOI<T, U, V, W, X> PLPBEMAPLEF, Action<T, U, V, W, X> CBDPHPPPDFI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4F30270", Offset = "0x4F2E870", VA = "0x184F30270")]
	public static HFOGABCADOI<T, U, V, W, X> PBENHLEGKII(HFOGABCADOI<T, U, V, W, X> PLPBEMAPLEF, Action<T, U, V, W, X> CBDPHPPPDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class IKGOFBLBLMO<T, U, V, W, X, Y> : PMCCIKCFKAI<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4F30300", Offset = "0x4F2E900", VA = "0x184F30300")]
	public IKGOFBLBLMO(bool PGNFCBOBBNI = false, bool LBIDOMNKACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5255760", Offset = "0x5253D60", VA = "0x185255760")]
	public void JKGEGDFKKNG(T IHNLGGEEIFC, U IENFLKPPKCG, V EFGJHINBPCN, W EDHBJBGECMO, X POMPNNDHCKO, Y JLAHKMCOIFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4F2C0A0", Offset = "0x4F2A6A0", VA = "0x184F2C0A0")]
	public static IKGOFBLBLMO<T, U, V, W, X, Y> HMGEOIDOOPE(IKGOFBLBLMO<T, U, V, W, X, Y> PLPBEMAPLEF, Action<T, U, V, W, X, Y> CBDPHPPPDFI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4F30270", Offset = "0x4F2E870", VA = "0x184F30270")]
	public static IKGOFBLBLMO<T, U, V, W, X, Y> PBENHLEGKII(IKGOFBLBLMO<T, U, V, W, X, Y> PLPBEMAPLEF, Action<T, U, V, W, X, Y> CBDPHPPPDFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HNMMPOJJAIA<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NOICILHGILI<TKey, TVal> JADLIFKMGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> EKLLPPFCOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NOICILHGILI<TKey, TVal>.FACDFGCPJEI? DDLHELKDEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int LNENIOLHLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NOICILHGILI<TKey, TVal>.OHMIAGADLED? BCLBBNPHGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int PBENEIIIKNG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int FHCEILAEGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5141050", Offset = "0x513F650", VA = "0x185141050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KEINBJHGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x51420E0", Offset = "0x51406E0", VA = "0x1851420E0")]
	public HNMMPOJJAIA(int LNENIOLHLCC, [Optional] NOICILHGILI<TKey, TVal>.OHMIAGADLED? BCLBBNPHGJC, [Optional] IEqualityComparer<TKey>? GFNNIFMENBP, [Optional] NOICILHGILI<TKey, TVal>.FACDFGCPJEI? DDLHELKDEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x51416E0", Offset = "0x513FCE0", VA = "0x1851416E0")]
	public void KNJIHDKOAKJ(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK, bool CMLFGKGEBHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51410A0", Offset = "0x513F6A0", VA = "0x1851410A0")]
	public bool IFLEJNCIAGC(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5141C00", Offset = "0x5140200", VA = "0x185141C00")]
	public bool NBJEBNMBDKD(TKey OMKCFPLCHGE, [Out] TVal FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x51419A0", Offset = "0x513FFA0", VA = "0x1851419A0")]
	private void LNEECJNHDFD(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK, int MLMBLBFOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5141EF0", Offset = "0x51404F0", VA = "0x185141EF0")]
	public bool OMLOOFGLLDN(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK, bool CMLFGKGEBHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5142080", Offset = "0x5140680", VA = "0x185142080")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51411D0", Offset = "0x513F7D0", VA = "0x1851411D0")]
	private void JLOGHPLKHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51418B0", Offset = "0x513FEB0", VA = "0x1851418B0")]
	private bool KNJMELKGAOM(TKey HFLDIIIPBCG, PLMAKIEOFED DAAMNHJEIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5141E10", Offset = "0x5140410", VA = "0x185141E10")]
	private void OHGCPPOKBHE(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK, PLMAKIEOFED DAAMNHJEIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5141CE0", Offset = "0x51402E0", VA = "0x185141CE0")]
	private void NIHNLBHJKCL(TKey HFLDIIIPBCG, TVal PGNMBFKGLAH, PLMAKIEOFED DAAMNHJEIGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EIKKJGBEGMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DKNCBDCOAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HMDAGKKAAPC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public EIKKJGBEGMM(Action CANPFBOHDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x85CC080", Offset = "0x85CA680", VA = "0x1885CC080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A180", Offset = "0x3B88780", VA = "0x183B8A180")]
	public static CJGHGFLGCGA<T> EEPJBIPIECL<T>(T FKMNCAKIOFK, Action CANPFBOHDNC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CJGHGFLGCGA<T> : EIKKJGBEGMM where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE54C0", Offset = "0x6DE3AC0", VA = "0x186DE54C0")]
	public CJGHGFLGCGA(T FKMNCAKIOFK, Action CANPFBOHDNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class NBNGBFNBDKJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly LDDFFHMLMJC<T>? DKIEHKFJLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> OENHDPMODFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool HMDAGKKAAPC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly NBNGBFNBDKJ<T> KBCDDOOGPEK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> BAHFPIOCAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x59C58D0", Offset = "0x59C3ED0", VA = "0x1859C58D0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x59C5BB0", Offset = "0x59C41B0", VA = "0x1859C5BB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool ACEIOKDFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x59C56D0", Offset = "0x59C3CD0", VA = "0x1859C56D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x59C5FA0", Offset = "0x59C45A0", VA = "0x1859C5FA0")]
	public NBNGBFNBDKJ(LDDFFHMLMJC<T> EIBDLCDDCJE, LDDFFHMLMJC<T> MNHEDPFGGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x59C6410", Offset = "0x59C4A10", VA = "0x1859C6410")]
	public NBNGBFNBDKJ(LDDFFHMLMJC<T> EIBDLCDDCJE, int JNIDLJHCIED, LDDFFHMLMJC<T> MNHEDPFGGDC, int FCPPDLMDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x59C5EF0", Offset = "0x59C44F0", VA = "0x1859C5EF0")]
	private NBNGBFNBDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x59C5850", Offset = "0x59C3E50", VA = "0x1859C5850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x59C5C70", Offset = "0x59C4270", VA = "0x1859C5C70")]
	public T[] POAGEPOACJA()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x59C59D0", Offset = "0x59C3FD0", VA = "0x1859C59D0")]
	public static ReadOnlySequence<T> HPNBGLLBBBG(NBNGBFNBDKJ<T>? PEFGHDGBIEG)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OPGIFAOANHJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable DJJPDGAJAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T FAGODIAEODP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B9DB00", Offset = "0x5B9C100", VA = "0x185B9DB00")]
	public OPGIFAOANHJ(IDisposable DBPGJLKPCJJ, [In] T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x44DF2B0", Offset = "0x44DD8B0", VA = "0x1844DF2B0")]
	public static OPGIFAOANHJ<U> BIAJEDEJMOK<U>([In] OPGIFAOANHJ<T> DBPGJLKPCJJ, [In] U FKMNCAKIOFK) where U : notnull
	{
		return default(OPGIFAOANHJ<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5B9D930", Offset = "0x5B9BF30", VA = "0x185B9D930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NBHPCBPJMFP
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3F0B220", Offset = "0x3F09820", VA = "0x183F0B220")]
	public static OPGIFAOANHJ<T> BPFPEFLIIPC<T>(IDisposable DBPGJLKPCJJ, [In] T FKMNCAKIOFK) where T : notnull
	{
		return default(OPGIFAOANHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3F0B280", Offset = "0x3F09880", VA = "0x183F0B280")]
	public static OPGIFAOANHJ<T> HBBIGFKAAED<T>([In] this OPGIFAOANHJ<T> CCKLBDLJPNG, [Out] T FKMNCAKIOFK) where T : notnull
	{
		return default(OPGIFAOANHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3DA5880", Offset = "0x3DA3E80", VA = "0x183DA5880")]
	public static OPGIFAOANHJ<U?> BIAJEDEJMOK<U, T>([In] OPGIFAOANHJ<T> LMFPHMACPOA, [In] U FKMNCAKIOFK)
	{
		return default(OPGIFAOANHJ<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct EDAJBCAFGNC : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct FJKIFHDECGE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
		public static FJKIFHDECGE BPFPEFLIIPC()
		{
			return default(FJKIFHDECGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85CBF40", Offset = "0x85CA540", VA = "0x1885CBF40")]
	public static string FCEJOKPOOKE(Type EHLAHNIAPLD, [Optional] string? PNONCOMILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3C07E90", Offset = "0x3C06490", VA = "0x183C07E90")]
	public static string? FCEJOKPOOKE<T>([Optional] string? PNONCOMILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C07E10", Offset = "0x3C06410", VA = "0x183C07E10")]
	public static string? CAIGGIJLOPK<T>([Optional] string? OMGFNFFCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
	public static EDAJBCAFGNC IEJLJBDKGKG(string PNONCOMILIK, string? OMGFNFFCCPD)
	{
		return default(EDAJBCAFGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JOOCGPBNKPG
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool HNNKJPMKOIO(string DHFNEMNIBMK, JOOCGPBNKPG HILBJHHIPBD);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PPGMBJDOJBL<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public PPGMBJDOJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2BC0", Offset = "0x5CA11C0", VA = "0x185CA2BC0")]
		internal void EDHLNLKBHFH(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int FBLLKKIPJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string NJLNINNCAGA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85CDBC0", Offset = "0x85CC1C0", VA = "0x1885CDBC0")]
	public static Dictionary<string, JOOCGPBNKPG> PLFHDALFLEM(Type BDFOOGAJCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D3D0", Offset = "0x3E3B9D0", VA = "0x183E3D3D0")]
	public static Dictionary<string, JOOCGPBNKPG> PLFHDALFLEM<T>(Type BDFOOGAJCDK, IReadOnlyDictionary<T, string> PGFKNMOOFLD) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3E3CD10", Offset = "0x3E3B310", VA = "0x183E3CD10")]
	public static Dictionary<string, JOOCGPBNKPG> MJLHPFGMKNC<T>(List<T> MELCAIFAHKH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85CD800", Offset = "0x85CBE00", VA = "0x1885CD800")]
	public static Dictionary<string, JOOCGPBNKPG> LKEBKKHILHD(Type BDFOOGAJCDK, HNNKJPMKOIO GJFEPDCKGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85CD640", Offset = "0x85CBC40", VA = "0x1885CD640")]
	public static Dictionary<int, string> JNJCMIAEFJA(Dictionary<string, JOOCGPBNKPG> LBHNPIBFMBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class LJOOEKCBACG : LCPFPNABOAN
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool BOCFLIIOGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? EKIEFBJMKFM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual LCPFPNABOAN? NFJCCJPPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85CEA50", Offset = "0x85CD050", VA = "0x1885CEA50")]
	protected LJOOEKCBACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JBIKIOHHBGC();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85CE970", Offset = "0x85CCF70", VA = "0x1885CE970", Slot = "8")]
	public virtual string JEGIFAMIEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85CE6C0", Offset = "0x85CCCC0", VA = "0x1885CE6C0", Slot = "9")]
	public void HPEDACGIDPA(StringBuilder OBAEAHGDBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85CE9F0", Offset = "0x85CCFF0", VA = "0x1885CE9F0", Slot = "10")]
	public void MMLGHLCDACP(StringBuilder OBAEAHGDBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x85CE440", Offset = "0x85CCA40", VA = "0x1885CE440", Slot = "11")]
	public void CIOCKGNPADF(StringBuilder OBAEAHGDBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85CE560", Offset = "0x85CCB60", VA = "0x1885CE560", Slot = "12")]
	public void DECBMOLLBHA(StringBuilder OBAEAHGDBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x85CE3A0", Offset = "0x85CC9A0", VA = "0x1885CE3A0")]
	public static void BLPINPJIJIG(StringBuilder OBAEAHGDBJI, string AMFFBMMHAII, string KGGOOEDHIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7498620", Offset = "0x7496C20", VA = "0x187498620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HEGECLHPMJK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x85CCE10", Offset = "0x85CB410", VA = "0x1885CCE10")]
	public HEGECLHPMJK(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CLNKMCKOGEM<TErr> : HEGECLHPMJK where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr LAGMPFDOKEE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC60C0", Offset = "0x6EC46C0", VA = "0x186EC60C0")]
	private CLNKMCKOGEM([In] TErr GHDHAGOHOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC5FF0", Offset = "0x6EC45F0", VA = "0x186EC5FF0")]
	public static CLNKMCKOGEM<TErr> BPFPEFLIIPC([In] TErr GHDHAGOHOBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CFDDOGKMMLA : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm FDLCEEONEBP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool IDFHMLGNBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool CNOBNGBEHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool KCLHLIBKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85CBB80", Offset = "0x85CA180", VA = "0x1885CBB80", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long IIKJNDDFMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x85CBBF0", Offset = "0x85CA1F0", VA = "0x1885CBBF0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85CBC60", Offset = "0x85CA260", VA = "0x1885CBC60", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x85CBB10", Offset = "0x85CA110", VA = "0x1885CBB10")]
	public CFDDOGKMMLA(HashAlgorithm FDLCEEONEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x85CB930", Offset = "0x85C9F30", VA = "0x1885CB930", Slot = "35")]
	public override int Read(byte[] COEFMBJKIKA, int EFCGAKGCCGN, int FEEKNNBMJMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x85CBAE0", Offset = "0x85CA0E0", VA = "0x1885CBAE0", Slot = "38")]
	public override void Write(byte[] COEFMBJKIKA, int EFCGAKGCCGN, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x85CB9D0", Offset = "0x85C9FD0", VA = "0x1885CB9D0", Slot = "33")]
	public override long Seek(long EFCGAKGCCGN, SeekOrigin COELDBNFGAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x85CBA60", Offset = "0x85CA060", VA = "0x1885CBA60", Slot = "34")]
	public override void SetLength(long FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x85CB850", Offset = "0x85C9E50", VA = "0x1885CB850")]
	public byte[] FIHPIGMFPJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LCPFPNABOAN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JEGIFAMIEII();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JBIKIOHHBGC();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FIABBMLPIOD<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface EPFGFFJPCFI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string EJMJAJBGGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LDDFFHMLMJC<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static LDDFFHMLMJC<T>? LNOMFFBDKJG;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object DKNJIGLKHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? PDCGAJPLELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool HMDAGKKAAPC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool AFNNFFJLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAE7930", Offset = "0xAE5F30", VA = "0x180AE7930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x56D2930", Offset = "0x56D0F30", VA = "0x1856D2930")]
	private static LDDFFHMLMJC<T> FIKHBJKCMCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x56D2390", Offset = "0x56D0990", VA = "0x1856D2390")]
	private static void FIHEDAHKPIH(LDDFFHMLMJC<T> FGLNIGMPEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x52768C0", Offset = "0x5274EC0", VA = "0x1852768C0")]
	private LDDFFHMLMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x56D21D0", Offset = "0x56D07D0", VA = "0x1856D21D0")]
	public static LDDFFHMLMJC<T> EEPJBIPIECL(ReadOnlyMemory<T> BIHMAKMFGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56D1E10", Offset = "0x56D0410", VA = "0x1856D1E10")]
	public static LDDFFHMLMJC<T> EEPJBIPIECL(IMemoryOwner<T> MHPJGAGKOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x56D1780", Offset = "0x56CFD80", VA = "0x1856D1780")]
	public static void ADDDDLADLAN(LDDFFHMLMJC<T> EIBDLCDDCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x56D1BE0", Offset = "0x56D01E0", VA = "0x1856D1BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56D2FB0", Offset = "0x56D15B0", VA = "0x1856D2FB0")]
	public LDDFFHMLMJC<T> OBHFLNAIMDF(IMemoryOwner<T> MHPJGAGKOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x56D2DD0", Offset = "0x56D13D0", VA = "0x1856D2DD0")]
	private void JFCBHLFELIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x56D18A0", Offset = "0x56CFEA0", VA = "0x1856D18A0")]
	private LDDFFHMLMJC<T> AOJLNOFABKO(LDDFFHMLMJC<T> FGLNIGMPEEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EFODPKKDOFI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x85CC020", Offset = "0x85CA620", VA = "0x1885CC020")]
	public EFODPKKDOFI(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class IHJKELDDOGB<TOk> : EFODPKKDOFI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk LMCDMBILHLK;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x523B3B0", Offset = "0x52399B0", VA = "0x18523B3B0")]
	private IHJKELDDOGB([In] TOk MALHBILBLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x523B160", Offset = "0x5239760", VA = "0x18523B160")]
	public static IHJKELDDOGB<TOk> BPFPEFLIIPC([In] TOk MALHBILBLAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct PKAAAAMEMEI<TOk, TErr> : IEquatable<PKAAAAMEMEI<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> PCNHLFMJLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr LAGMPFDOKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk LMCDMBILHLK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JLBBAJGJICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5C72DA0", Offset = "0x5C713A0", VA = "0x185C72DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HAPIECMDHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5C72A50", Offset = "0x5C71050", VA = "0x185C72A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5C773C0", Offset = "0x5C759C0", VA = "0x185C773C0")]
	internal PKAAAAMEMEI([In] TErr GHDHAGOHOBN, [In] TOk MALHBILBLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5C73EB0", Offset = "0x5C724B0", VA = "0x185C73EB0")]
	public static PKAAAAMEMEI<TOk, TErr> GNDEPGIIPKF([In] TErr GHDHAGOHOBN)
	{
		return default(PKAAAAMEMEI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5C74C10", Offset = "0x5C73210", VA = "0x185C74C10")]
	public static PKAAAAMEMEI<TOk, TErr> LDCJECIICEI([In] TOk MALHBILBLAH)
	{
		return default(PKAAAAMEMEI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x44E2050", Offset = "0x44E0650", VA = "0x1844E2050")]
	public PKAAAAMEMEI<TOk?, UErr?> MMAKABBCHEP<UErr>()
	{
		return default(PKAAAAMEMEI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x44E1850", Offset = "0x44DFE50", VA = "0x1844E1850")]
	public PKAAAAMEMEI<UOk?, TErr?> HMOICDDCELJ<UOk>()
	{
		return default(PKAAAAMEMEI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x44DFB40", Offset = "0x44DE140", VA = "0x1844DFB40")]
	public PKAAAAMEMEI<UOk?, TErr?> DOBCLJJODAN<UOk>()
	{
		return default(PKAAAAMEMEI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x44E1B80", Offset = "0x44E0180", VA = "0x1844E1B80")]
	public PKAAAAMEMEI<TOk?, UErr?> KHNHEBPDKJA<UErr>()
	{
		return default(PKAAAAMEMEI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5C75BC0", Offset = "0x5C741C0", VA = "0x185C75BC0")]
	public PKAAAAMEMEI<GDCHOBJFCMN, TErr> NFLIHBFIJNM()
	{
		return default(PKAAAAMEMEI<GDCHOBJFCMN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5C75980", Offset = "0x5C73F80", VA = "0x185C75980")]
	public static bool LMIMJGGKHMP([In] PKAAAAMEMEI<TOk, TErr> LEOAACGBJCD, [In] PKAAAAMEMEI<TOk, TErr> GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5C72FF0", Offset = "0x5C715F0", VA = "0x185C72FF0", Slot = "4")]
	public bool Equals(PKAAAAMEMEI<TOk, TErr> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5C72E60", Offset = "0x5C71460", VA = "0x185C72E60", Slot = "0")]
	public override bool Equals(object IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5C74070", Offset = "0x5C72670", VA = "0x185C74070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5C76330", Offset = "0x5C74930", VA = "0x185C76330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class ODAMBAKPGPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JHMFEEBAJDL<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<PKAAAAMEMEI<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<PKAAAAMEMEI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x54BD3B0", Offset = "0x54BB9B0", VA = "0x1854BD3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x52382C0", Offset = "0x52368C0", VA = "0x1852382C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct KGBCKDCCOGM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<GDCHOBJFCMN, TErr>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Task<PKAAAAMEMEI<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<PKAAAAMEMEI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x55B9730", Offset = "0x55B7D30", VA = "0x1855B9730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x45A5B10", Offset = "0x45A4110", VA = "0x1845A5B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct DNLKPFHIJFM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Task<PKAAAAMEMEI<TOk, TErr>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<PKAAAAMEMEI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x45C0B40", Offset = "0x45BF140", VA = "0x1845C0B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x45C0E00", Offset = "0x45BF400", VA = "0x1845C0E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3F467D0", Offset = "0x3F44DD0", VA = "0x183F467D0")]
	public static PKAAAAMEMEI<TOk?, TErr?> LMCDMBILHLK<TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [In] TOk MALHBILBLAH)
	{
		return default(PKAAAAMEMEI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3F46980", Offset = "0x3F44F80", VA = "0x183F46980")]
	public static PKAAAAMEMEI<GDCHOBJFCMN, TErr?> LMCDMBILHLK<TErr>([In] this PKAAAAMEMEI<GDCHOBJFCMN, TErr> CCKLBDLJPNG)
	{
		return default(PKAAAAMEMEI<GDCHOBJFCMN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3F467D0", Offset = "0x3F44DD0", VA = "0x183F467D0")]
	public static PKAAAAMEMEI<TOk?, TErr?> LAGMPFDOKEE<TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [In] TErr GHDHAGOHOBN)
	{
		return default(PKAAAAMEMEI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3F469F0", Offset = "0x3F44FF0", VA = "0x183F469F0")]
	public static TOk? LOLLIGFJDCE<TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F45AA0", Offset = "0x3F440A0", VA = "0x183F45AA0")]
	[AsyncStateMachine(typeof(JHMFEEBAJDL<, >))]
	public static Task<TOk?>? JCCBOLEFDPC<TOk, TErr>(this Task<PKAAAAMEMEI<TOk, TErr>> CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3F43240", Offset = "0x3F41840", VA = "0x183F43240")]
	public static TErr? DFCAFGNEFAD<TErr, TOk>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3F43EC0", Offset = "0x3F424C0", VA = "0x183F43EC0")]
	public static bool IEGIHNPGGNO<TOk, TErr, UErr, UOk>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [Out] PKAAAAMEMEI<UOk, UErr> MBFKCEFNJOJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3F439E0", Offset = "0x3F41FE0", VA = "0x183F439E0")]
	public static bool GKIKAEFBBGC<TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [Out] TOk MALHBILBLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3F47050", Offset = "0x3F45650", VA = "0x183F47050")]
	public static bool MCBFGNJHKPB<TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [Out][NotNullWhen(true)] TErr GHDHAGOHOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3F473D0", Offset = "0x3F459D0", VA = "0x183F473D0")]
	public static bool PLJHPACBOAI<TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [Out][NotNullWhen(true)] TOk MALHBILBLAH, [Out][NotNullWhen(false)] TErr GHDHAGOHOBN) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F462A0", Offset = "0x3F448A0", VA = "0x183F462A0")]
	public static bool KJKHOOPGCCM<TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [Out][NotNullWhen(true)] TOk MALHBILBLAH, [Out] PKAAAAMEMEI<TOk, TErr> MBFKCEFNJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3F43C70", Offset = "0x3F42270", VA = "0x183F43C70")]
	public static bool IEGIHNPGGNO<TOk, TErr, UErr, UOk>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [Out][NotNullWhen(true)] TOk MALHBILBLAH, [Out] PKAAAAMEMEI<UOk, UErr> MBFKCEFNJOJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F46470", Offset = "0x3F44A70", VA = "0x183F46470")]
	public static bool KJMECFOEDPC<TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [Out][NotNullWhen(true)] TOk MALHBILBLAH, [Out] PKAAAAMEMEI<GDCHOBJFCMN, TErr> MBFKCEFNJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F45180", Offset = "0x3F43780", VA = "0x183F45180")]
	public static PKAAAAMEMEI<UOk, UErr> IOAMOLKAKMO<UOk, UErr, TOk, TErr>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, [In] PKAAAAMEMEI<UOk, UErr> CGLIDCMIAEF) where TOk : UOk where TErr : UErr
	{
		return default(PKAAAAMEMEI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3F43660", Offset = "0x3F41C60", VA = "0x183F43660")]
	public static PKAAAAMEMEI<TOk?[]?, TErr?> FBEBDGHBOGK<TOk, TErr>(this IEnumerable<PKAAAAMEMEI<TOk, TErr>> CCKLBDLJPNG)
	{
		return default(PKAAAAMEMEI<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3F47190", Offset = "0x3F45790", VA = "0x183F47190")]
	public static PKAAAAMEMEI<UOk?, TErr?> NFBMEBNEPPE<UOk, TErr, TOk>([In] this PKAAAAMEMEI<TOk, TErr> CCKLBDLJPNG, Func<TOk, UOk> CGFOPJGBCOB)
	{
		return default(PKAAAAMEMEI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F460E0", Offset = "0x3F446E0", VA = "0x183F460E0")]
	[AsyncStateMachine(typeof(KGBCKDCCOGM<, >))]
	public static Task<PKAAAAMEMEI<GDCHOBJFCMN, TErr?>>? KAGDEEOELED<TErr, TOk>(this Task<PKAAAAMEMEI<TOk, TErr>> CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F45F00", Offset = "0x3F44500", VA = "0x183F45F00")]
	[AsyncStateMachine(typeof(DNLKPFHIJFM<, >))]
	public static Task<bool>? JLBBAJGJICM<TOk, TErr>(this Task<PKAAAAMEMEI<TOk, TErr>> PIKAFIDPPMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ODFENAIADGG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x44DDB70", Offset = "0x44DC170", VA = "0x1844DDB70")]
	public static PKAAAAMEMEI<TOk, T> LMCDMBILHLK<TOk>([In] TOk MALHBILBLAH) where TOk : notnull
	{
		return default(PKAAAAMEMEI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B3D0C0", Offset = "0x5B3B6C0", VA = "0x185B3D0C0")]
	public static PKAAAAMEMEI<GDCHOBJFCMN, T> LMCDMBILHLK()
	{
		return default(PKAAAAMEMEI<GDCHOBJFCMN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x44DDD00", Offset = "0x44DC300", VA = "0x1844DDD00")]
	public static PKAAAAMEMEI<T, TErr> LAGMPFDOKEE<TErr>([In] TErr GHDHAGOHOBN) where TErr : notnull
	{
		return default(PKAAAAMEMEI<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct MPKKECLGGHH<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IICHOBNLMGC DDFNFGCDKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Dictionary<TKey, TValue> NNLANCIBNLL;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0C40", Offset = "0x4FEF240", VA = "0x184FF0C40")]
	public static MPKKECLGGHH<TKey, TValue> BPFPEFLIIPC(string HHPFOCCGJIF)
	{
		return default(MPKKECLGGHH<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0D60", Offset = "0x4FEF360", VA = "0x184FF0D60")]
	internal MPKKECLGGHH(Dictionary<TKey, TValue> FKMNCAKIOFK, IICHOBNLMGC NKIFJLNHKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0B90", Offset = "0x4FEF190", VA = "0x184FF0B90")]
	public BFCIMLDOMOP<TKey, TValue> AMIECELDEDH([Out] Dictionary<TKey, TValue> FKMNCAKIOFK)
	{
		return default(BFCIMLDOMOP<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct BFCIMLDOMOP<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Dictionary<TKey, TValue> NNLANCIBNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly LPOKOIEMBKD KBBMFECEGOJ;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D76EB0", Offset = "0x2D754B0", VA = "0x182D76EB0")]
	internal BFCIMLDOMOP(Dictionary<TKey, TValue> FKMNCAKIOFK, LPOKOIEMBKD JOGPMJLKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B88860", Offset = "0x5B86E60", VA = "0x185B88860", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct APCEIIDKIDC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IICHOBNLMGC DDFNFGCDKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<T> NNLANCIBNLL;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0C40", Offset = "0x4FEF240", VA = "0x184FF0C40")]
	public static APCEIIDKIDC<T> BPFPEFLIIPC(string HHPFOCCGJIF)
	{
		return default(APCEIIDKIDC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0D60", Offset = "0x4FEF360", VA = "0x184FF0D60")]
	internal APCEIIDKIDC(HashSet<T> FKMNCAKIOFK, IICHOBNLMGC NKIFJLNHKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0B90", Offset = "0x4FEF190", VA = "0x184FF0B90")]
	public PKIDMKAHLKO<T> AMIECELDEDH([Out] HashSet<T> FKMNCAKIOFK)
	{
		return default(PKIDMKAHLKO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PKIDMKAHLKO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<T> NNLANCIBNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LPOKOIEMBKD KBBMFECEGOJ;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D76EB0", Offset = "0x2D754B0", VA = "0x182D76EB0")]
	internal PKIDMKAHLKO(HashSet<T> FKMNCAKIOFK, LPOKOIEMBKD JOGPMJLKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5B88860", Offset = "0x5B86E60", VA = "0x185B88860", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct GIIHFHONNJI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IICHOBNLMGC DDFNFGCDKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Stack<T> NNLANCIBNLL;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0C40", Offset = "0x4FEF240", VA = "0x184FF0C40")]
	public static GIIHFHONNJI<T> BPFPEFLIIPC(string HHPFOCCGJIF)
	{
		return default(GIIHFHONNJI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0D60", Offset = "0x4FEF360", VA = "0x184FF0D60")]
	internal GIIHFHONNJI(Stack<T> FKMNCAKIOFK, IICHOBNLMGC NKIFJLNHKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0B90", Offset = "0x4FEF190", VA = "0x184FF0B90")]
	public OKNDDFMJNMC<T> AMIECELDEDH([Out] Stack<T> FKMNCAKIOFK)
	{
		return default(OKNDDFMJNMC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct OKNDDFMJNMC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Stack<T> NNLANCIBNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly LPOKOIEMBKD KBBMFECEGOJ;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2D76EB0", Offset = "0x2D754B0", VA = "0x182D76EB0")]
	internal OKNDDFMJNMC(Stack<T> FKMNCAKIOFK, LPOKOIEMBKD JOGPMJLKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B88860", Offset = "0x5B86E60", VA = "0x185B88860", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
public sealed class FPOHMPBIPFE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct CBBHKMNEDEK : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly FPOHMPBIPFE<T> KHLLEJJMKOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly int OJJPLJGLDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly bool JDKKHELOEFI;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2976010", Offset = "0x2974610", VA = "0x182976010")]
		public CBBHKMNEDEK(FPOHMPBIPFE<T> FCFHEFKEJPB, int HHGBEFMFDNL, bool AFKKIIAKKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA340", Offset = "0x6CF8940", VA = "0x186CFA340")]
		public FPOHMPBIPFE<T>.DDABLIHKMCM DKMCAGKLCHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA430", Offset = "0x6CF8A30", VA = "0x186CFA430", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA430", Offset = "0x6CF8A30", VA = "0x186CFA430", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class DDABLIHKMCM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly FPOHMPBIPFE<T> KHLLEJJMKOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly int JCBJOLJJGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int CBJBFOFELBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly bool JDKKHELOEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool BEJCAPGEKHE;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x459F720", Offset = "0x459DD20", VA = "0x18459F720")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x459F850", Offset = "0x459DE50", VA = "0x18459F850", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x459FA00", Offset = "0x459E000", VA = "0x18459FA00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x459FBE0", Offset = "0x459E1E0", VA = "0x18459FBE0")]
		public DDABLIHKMCM(FPOHMPBIPFE<T> FCFHEFKEJPB, int HHGBEFMFDNL, bool AFKKIIAKKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x459F760", Offset = "0x459DD60", VA = "0x18459F760", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x459F7F0", Offset = "0x459DDF0", VA = "0x18459F7F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class OEPJHOENBPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public OEPJHOENBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5B3FB00", Offset = "0x5B3E100", VA = "0x185B3FB00")]
		internal T KHGBLAEHIPK(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly T[] EOEHGGCDAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int CBJBFOFELBF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int FEIDNKKBDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4F543C0", Offset = "0x4F529C0", VA = "0x184F543C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T MKKCMPLEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4F1AE70", Offset = "0x4F19470", VA = "0x184F1AE70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T PELAIAPNCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4F54180", Offset = "0x4F52780", VA = "0x184F54180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4F542A0", Offset = "0x4F528A0", VA = "0x184F542A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x292D5F0", Offset = "0x292BBF0", VA = "0x18292D5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D8A130", Offset = "0x1D88730", VA = "0x181D8A130")]
	private static int NEPHAMINJHF(int LEPAEEGOBDO, int FODNOPLPBPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F54410", Offset = "0x4F52A10", VA = "0x184F54410")]
	public FPOHMPBIPFE(int MLMBLBFOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4F54520", Offset = "0x4F52B20", VA = "0x184F54520")]
	public FPOHMPBIPFE(int MLMBLBFOLPC, Func<T> BEPJGDAMCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F54920", Offset = "0x4F52F20", VA = "0x184F54920")]
	public FPOHMPBIPFE(T[] HLOMEJLEMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F54150", Offset = "0x4F52750", VA = "0x184F54150")]
	public void GLOPEGPDDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F54300", Offset = "0x4F52900", VA = "0x184F54300")]
	public IEnumerable<T> NBDEHLOPCNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4F540C0", Offset = "0x4F526C0", VA = "0x184F540C0")]
	public FPOHMPBIPFE<T>.DDABLIHKMCM DKMCAGKLCHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4F411B0", Offset = "0x4F3F7B0", VA = "0x184F411B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4F411B0", Offset = "0x4F3F7B0", VA = "0x184F411B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class ACCFDENPMKP
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x32A3DA0", Offset = "0x32A23A0", VA = "0x1832A3DA0")]
	public static FPOHMPBIPFE<T> BPFPEFLIIPC<T>(int MLMBLBFOLPC, Func<T> BEPJGDAMCPD) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x716E6C0", Offset = "0x716CCC0", VA = "0x18716E6C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x85CF980", Offset = "0x85CDF80", VA = "0x1885CF980")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x85CF9A0", Offset = "0x85CDFA0", VA = "0x1885CF9A0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x85CF9C0", Offset = "0x85CDFC0", VA = "0x1885CF9C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x85CF960", Offset = "0x85CDF60", VA = "0x1885CF960")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0F60", Offset = "0x2ADF560", VA = "0x182AE0F60")]
		public RRColor(float FIECNFDCBKN, float ANEMBPECCCL, float DFKKOPOBCBA, float IAFDMJDNHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x844A3E0", Offset = "0x84489E0", VA = "0x18844A3E0", Slot = "4")]
		public bool Equals(RRColor IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85CF5A0", Offset = "0x85CDBA0", VA = "0x1885CF5A0", Slot = "0")]
		public override bool Equals(object IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85CF6A0", Offset = "0x85CDCA0", VA = "0x1885CF6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85CF720", Offset = "0x85CDD20", VA = "0x1885CF720", Slot = "5")]
		public string ToString(string IENFMLICFPK, IFormatProvider KONCNBNKGKA)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x85CF540", Offset = "0x85CDB40", VA = "0x1885CF540")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x85CF4E0", Offset = "0x85CDAE0", VA = "0x1885CF4E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x85CF510", Offset = "0x85CDB10", VA = "0x1885CF510")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x85CF570", Offset = "0x85CDB70", VA = "0x1885CF570")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x85CF4B0", Offset = "0x85CDAB0", VA = "0x1885CF4B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6337980", Offset = "0x6335F80", VA = "0x186337980")]
		public RRColor32(byte FIECNFDCBKN, byte ANEMBPECCCL, byte DFKKOPOBCBA, byte IAFDMJDNHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x24C4E00", Offset = "0x24C3400", VA = "0x1824C4E00", Slot = "4")]
		public bool Equals(RRColor32 IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x85CEFF0", Offset = "0x85CD5F0", VA = "0x1885CEFF0", Slot = "0")]
		public override bool Equals(object IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x15B33F0", Offset = "0x15B19F0", VA = "0x1815B33F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85CF0F0", Offset = "0x85CD6F0", VA = "0x1885CF0F0")]
		public static RRColor32 HPNBGLLBBBG(RRColor JNNOBIJIOOK)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85CF080", Offset = "0x85CD680", VA = "0x1885CF080")]
		public static RRColor HPNBGLLBBBG(RRColor32 JNNOBIJIOOK)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85CF240", Offset = "0x85CD840", VA = "0x1885CF240", Slot = "5")]
		public string ToString(string IENFMLICFPK, IFormatProvider KONCNBNKGKA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class DICJOHBFCKL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct MHCFIMMPBEG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly DICJOHBFCKL<T> OIKEJFGAHHK;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T FAGODIAEODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5959260", Offset = "0x5957860", VA = "0x185959260")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5959230", Offset = "0x5957830", VA = "0x185959230", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
		public MHCFIMMPBEG(DICJOHBFCKL<T> OIKEJFGAHHK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct FENFHHOFOAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<MHCFIMMPBEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public DICJOHBFCKL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4F2BBC0", Offset = "0x4F2A1C0", VA = "0x184F2BBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4A7FA20", Offset = "0x4A7E020", VA = "0x184A7FA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly SemaphoreSlim BDCHPONMJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T JLOKLPELFOB;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x45A90B0", Offset = "0x45A76B0", VA = "0x1845A90B0")]
	public DICJOHBFCKL([In] T JLOKLPELFOB, int MNPJAOOOLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x45A8F50", Offset = "0x45A7550", VA = "0x1845A8F50")]
	public DICJOHBFCKL([In] T JLOKLPELFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x45A8EB0", Offset = "0x45A74B0", VA = "0x1845A8EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x45A8EF0", Offset = "0x45A74F0", VA = "0x1845A8EF0")]
	public MHCFIMMPBEG EPNMFCKHBFM()
	{
		return default(MHCFIMMPBEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x45A8A30", Offset = "0x45A7030", VA = "0x1845A8A30")]
	[AsyncStateMachine(typeof(DICJOHBFCKL<>.FENFHHOFOAC))]
	public Task<DICJOHBFCKL<T>.MHCFIMMPBEG> BLPJLPIJLHP(CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x45A8F30", Offset = "0x45A7530", VA = "0x1845A8F30")]
	public void PGOHLOPGNNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class PKMKHMHIFFN
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x85CEC90", Offset = "0x85CD290", VA = "0x1885CEC90")]
	public static DICJOHBFCKL<GDCHOBJFCMN> BPFPEFLIIPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8630", Offset = "0x3BD6C30", VA = "0x183BD8630")]
	public static DICJOHBFCKL<T> BPFPEFLIIPC<T>([In] T JLOKLPELFOB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class IIIBHNAJHJP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct ADCHFCHKEAB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly IIIBHNAJHJP<T> KGGIEGBPNIJ;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T FAGODIAEODP
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4FF5480", Offset = "0x4FF3A80", VA = "0x184FF5480")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x51E43D0", Offset = "0x51E29D0", VA = "0x1851E43D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
		internal ADCHFCHKEAB(IIIBHNAJHJP<T> OIKEJFGAHHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct GLCDENKDGEI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly IIIBHNAJHJP<T> KGGIEGBPNIJ;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T FAGODIAEODP
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4FF5480", Offset = "0x4FF3A80", VA = "0x184FF5480")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5390", Offset = "0x4FF3990", VA = "0x184FF5390", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
		internal GLCDENKDGEI(IIIBHNAJHJP<T> OIKEJFGAHHK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct AJKFLDMKLJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder<GLCDENKDGEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public IIIBHNAJHJP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private DICJOHBFCKL<GDCHOBJFCMN>.MHCFIMMPBEG <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<DICJOHBFCKL<GDCHOBJFCMN>.MHCFIMMPBEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x53F7680", Offset = "0x53F5C80", VA = "0x1853F7680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4A7FA20", Offset = "0x4A7E020", VA = "0x184A7FA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly DICJOHBFCKL<int> LAJBFBJNGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly DICJOHBFCKL<GDCHOBJFCMN> BKAHEPFJGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DICJOHBFCKL<GDCHOBJFCMN> EMPFCHNIJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private T GIHMNJCEAPG;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5247350", Offset = "0x5245950", VA = "0x185247350")]
	internal IIIBHNAJHJP(DICJOHBFCKL<int> DDFHEKOPNHJ, DICJOHBFCKL<GDCHOBJFCMN> EJAACNODCPD, DICJOHBFCKL<GDCHOBJFCMN> DGIMCNLHIGH, [In] T JLOKLPELFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5246B70", Offset = "0x5245170", VA = "0x185246B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x52467F0", Offset = "0x5244DF0", VA = "0x1852467F0")]
	public ADCHFCHKEAB ABOOHALKFOP()
	{
		return default(ADCHFCHKEAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5247080", Offset = "0x5245680", VA = "0x185247080")]
	public GLCDENKDGEI OFCKLKGLICM()
	{
		return default(GLCDENKDGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5246F50", Offset = "0x5245550", VA = "0x185246F50")]
	[AsyncStateMachine(typeof(IIIBHNAJHJP<>.AJKFLDMKLJC))]
	public Task<IIIBHNAJHJP<T>.GLCDENKDGEI> EHNNPCJNBDB(CancellationToken MEKNAIONNND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KMJDMMMKGEN
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x85CE2D0", Offset = "0x85CC8D0", VA = "0x1885CE2D0")]
	public static IIIBHNAJHJP<GDCHOBJFCMN> BPFPEFLIIPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3E68110", Offset = "0x3E66710", VA = "0x183E68110")]
	public static IIIBHNAJHJP<T> BPFPEFLIIPC<T>([In] T JLOKLPELFOB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class NDBHFDEFONM<TData> : LJOOEKCBACG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly string OGPGDHDIMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly TData AIJFAAIOPNI;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
	public override string JBIKIOHHBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x59CEB10", Offset = "0x59CD110", VA = "0x1859CEB10")]
	internal NDBHFDEFONM(string IFEHDCDCFPK, [In] TData DAJAOHIJHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class JNBNBNLONHF
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x85CD5C0", Offset = "0x85CBBC0", VA = "0x1885CD5C0")]
	public static NDBHFDEFONM<GDCHOBJFCMN> BPFPEFLIIPC(string IFEHDCDCFPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A180", Offset = "0x3B88780", VA = "0x183B8A180")]
	public static NDBHFDEFONM<TData> BPFPEFLIIPC<TData>(string IFEHDCDCFPK, [In] TData DAJAOHIJHHL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class IICHOBNLMGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal bool HLDMEKFKKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly string BNNIEBMHGHB;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xF9AD70", Offset = "0xF99370", VA = "0x180F9AD70")]
	private IICHOBNLMGC(bool FLALGPOPNDP, string AHONIKIIKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x85CCFD0", Offset = "0x85CB5D0", VA = "0x1885CCFD0")]
	public static IICHOBNLMGC BPFPEFLIIPC(string AHONIKIIKBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x85CCF10", Offset = "0x85CB510", VA = "0x1885CCF10")]
	public LPOKOIEMBKD AMIECELDEDH()
	{
		return default(LPOKOIEMBKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct LPOKOIEMBKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IICHOBNLMGC HMCGFFOOIIM;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
	internal LPOKOIEMBKD(IICHOBNLMGC HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x85CEAC0", Offset = "0x85CD0C0", VA = "0x1885CEAC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class GAJAAABLKKN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class MICPOJMBIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MICPOJMBIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x596C950", Offset = "0x596AF50", VA = "0x18596C950")]
		internal int LNEFFCKKOKI(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private HashSet<T>? PEKHLALMAMM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> PABJNJKFNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1180", Offset = "0x4FCF780", VA = "0x184FD1180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MGCEIANKLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1100", Offset = "0x4FCF700", VA = "0x184FD1100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1360", Offset = "0x4FCF960", VA = "0x184FD1360")]
	public bool KMLBEHGKDFG(T HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4FD11B0", Offset = "0x4FCF7B0", VA = "0x184FD11B0")]
	public bool HCDNAOEAAEJ(T HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1140", Offset = "0x4FCF740", VA = "0x184FD1140")]
	public bool DIIFLEHJKPJ(T HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4FD12D0", Offset = "0x4FCF8D0", VA = "0x184FD12D0")]
	public void JICJNIOHBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4FD14D0", Offset = "0x4FCFAD0", VA = "0x184FD14D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GAJAAABLKKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class JHDOLFBOEBO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class GPNLCDCHIMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GPNLCDCHIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x85CCA40", Offset = "0x85CB040", VA = "0x1885CCA40")]
		internal int LNEFFCKKOKI(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private HashSet<object>? PEKHLALMAMM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> PABJNJKFNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x85CD0B0", Offset = "0x85CB6B0", VA = "0x1885CD0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MGCEIANKLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x85CD040", Offset = "0x85CB640", VA = "0x1885CD040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xAA1220", Offset = "0xA9F820", VA = "0x180AA1220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x85CD250", Offset = "0x85CB850", VA = "0x1885CD250")]
	public bool KMLBEHGKDFG(object HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x85CD140", Offset = "0x85CB740", VA = "0x1885CD140")]
	public bool HCDNAOEAAEJ(object HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x85CD050", Offset = "0x85CB650", VA = "0x1885CD050")]
	public bool DIIFLEHJKPJ(object HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x85CD1E0", Offset = "0x85CB7E0", VA = "0x1885CD1E0")]
	public void JICJNIOHBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x85CD330", Offset = "0x85CB930", VA = "0x1885CD330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JHDOLFBOEBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class CJOALINNILP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct HBHNOKLNHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float AEOOGMFJCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public T FAGODIAEODP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Dictionary<object, HBHNOKLNHKG> KMJJPAEMNAD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T GPGPFJPAGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x12868E0", Offset = "0x1284EE0", VA = "0x1812868E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1C5F680", Offset = "0x1C5DC80", VA = "0x181C5F680", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? KBALIMLJKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OAAKNFDOPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE9D0", Offset = "0x4AACFD0", VA = "0x184AAE9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE5620", Offset = "0x6DE3C20", VA = "0x186DE5620")]
	public bool GKJOFPFBKFG(T FKMNCAKIOFK, object HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE960", Offset = "0x4AACF60", VA = "0x184AAE960")]
	public bool LOLEOCABCAK(object HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4AAEB10", Offset = "0x4AAD110", VA = "0x184AAEB10")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE5740", Offset = "0x6DE3D40", VA = "0x186DE5740")]
	public bool NBJEBNMBDKD(object HNGIMMGBLII, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6DE57E0", Offset = "0x6DE3DE0", VA = "0x186DE57E0")]
	[HCMEEGOFNEK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool PJODBCBBOPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x693F460", Offset = "0x693DA60", VA = "0x18693F460")]
	public CJOALINNILP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class DJODPCGDIDE : BPNGABIEJBL<GMFFHJDCBPL>
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal class EFDIDEAMLDL : IEqualityComparer<GMFFHJDCBPL>
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal static readonly EFDIDEAMLDL DOBPPELCKJD;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x85CBF80", Offset = "0x85CA580", VA = "0x1885CBF80", Slot = "4")]
		public bool Equals(GMFFHJDCBPL POMPNNDHCKO, GMFFHJDCBPL JLAHKMCOIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7683310", Offset = "0x7681910", VA = "0x187683310", Slot = "5")]
		public int GetHashCode(GMFFHJDCBPL NDBJJGOPOFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EFDIDEAMLDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x85CBED0", Offset = "0x85CA4D0", VA = "0x1885CBED0")]
	public DJODPCGDIDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x85CBD90", Offset = "0x85CA390", VA = "0x1885CBD90", Slot = "4")]
	public override bool KMLBEHGKDFG(GMFFHJDCBPL HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x85CBCE0", Offset = "0x85CA2E0", VA = "0x1885CBCE0", Slot = "5")]
	public override bool HCDNAOEAAEJ(GMFFHJDCBPL HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x85CBE40", Offset = "0x85CA440", VA = "0x1885CBE40")]
	private static void PFMMMAMMHMF(GMFFHJDCBPL HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xAFB120", Offset = "0xAF9720", VA = "0x180AFB120", Slot = "6")]
	protected override string TokenToString(GMFFHJDCBPL HNGIMMGBLII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class GMFFHJDCBPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly string OLECDBIFLOB;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public GMFFHJDCBPL(string OLECDBIFLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x85CC9F0", Offset = "0x85CAFF0", VA = "0x1885CC9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class BPNGABIEJBL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEqualityComparer<T> NBPCHKHLAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private HashSet<T>? PEKHLALMAMM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> PABJNJKFNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6A27280", Offset = "0x6A25880", VA = "0x186A27280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MGCEIANKLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1100", Offset = "0x4FCF700", VA = "0x184FD1100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A27F20", Offset = "0x6A26520", VA = "0x186A27F20")]
	public BPNGABIEJBL(IEqualityComparer<T> NBPCHKHLAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6A27590", Offset = "0x6A25B90", VA = "0x186A27590", Slot = "4")]
	public virtual bool KMLBEHGKDFG(T HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6A272B0", Offset = "0x6A258B0", VA = "0x186A272B0", Slot = "5")]
	public virtual bool HCDNAOEAAEJ(T HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6A27500", Offset = "0x6A25B00", VA = "0x186A27500")]
	public void JICJNIOHBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6A27B80", Offset = "0x6A26180", VA = "0x186A27B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class JNGCNCIAPNN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<WeakReference<T>>? PEKHLALMAMM;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool MGCEIANKLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x54F9C30", Offset = "0x54F8230", VA = "0x1854F9C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x54F9D30", Offset = "0x54F8330", VA = "0x1854F9D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x54FA130", Offset = "0x54F8730", VA = "0x1854FA130")]
	public void KMLBEHGKDFG(T HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x54F9FB0", Offset = "0x54F85B0", VA = "0x1854F9FB0")]
	public void HCDNAOEAAEJ(T HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x54F9E90", Offset = "0x54F8490", VA = "0x1854F9E90")]
	public bool DIIFLEHJKPJ(T HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x54FA110", Offset = "0x54F8710", VA = "0x1854FA110")]
	public void JICJNIOHBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x54FA350", Offset = "0x54F8950", VA = "0x1854FA350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JNGCNCIAPNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal static class GPKNFJBFMNN
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB33D0", Offset = "0x3DB19D0", VA = "0x183DB33D0")]
	public static void DMKEDDAHJJA<T>(this List<T> AHJLBOEGGKN, int LEPAEEGOBDO) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EPJHCPDGDJO<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private struct FKGMKCCPGOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float AEOOGMFJCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public T FAGODIAEODP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<GMFFHJDCBPL, FKGMKCCPGOH> KMJJPAEMNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly EqualityComparer<T> GPJGDFAGDAJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T GPGPFJPAGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA94FC0", Offset = "0xA935C0", VA = "0x180A94FC0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private GMFFHJDCBPL? KBALIMLJKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool OAAKNFDOPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE9D0", Offset = "0x4AACFD0", VA = "0x184AAE9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE880", Offset = "0x4AACE80", VA = "0x184AAE880")]
	public bool GKJOFPFBKFG(T FKMNCAKIOFK, GMFFHJDCBPL HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE960", Offset = "0x4AACF60", VA = "0x184AAE960")]
	public bool LOLEOCABCAK(GMFFHJDCBPL HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4AAEB10", Offset = "0x4AAD110", VA = "0x184AAEB10")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4AAEAA0", Offset = "0x4AAD0A0", VA = "0x184AAEAA0")]
	public bool NBJEBNMBDKD(GMFFHJDCBPL HNGIMMGBLII, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4AAEB40", Offset = "0x4AAD140", VA = "0x184AAEB40")]
	[HCMEEGOFNEK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool PJODBCBBOPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4AAF1E0", Offset = "0x4AAD7E0", VA = "0x184AAF1E0")]
	public EPJHCPDGDJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PKPMHGCJIEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<object, float> KMJJPAEMNAD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float JCBOECKLIID
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F50", Offset = "0x13D8550", VA = "0x1813D9F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x85CEE30", Offset = "0x85CD430", VA = "0x1885CEE30")]
	public void GKJOFPFBKFG(float FKMNCAKIOFK, object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x85CEEA0", Offset = "0x85CD4A0", VA = "0x1885CEEA0")]
	public void LOLEOCABCAK(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x85CEF10", Offset = "0x85CD510", VA = "0x1885CEF10")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x85CED00", Offset = "0x85CD300", VA = "0x1885CED00")]
	private void FCMOMBEHMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x85CEF60", Offset = "0x85CD560", VA = "0x1885CEF60")]
	public PKPMHGCJIEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface NIKANHPDLKP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MAEGMFJEANC FELDMBNMJMF;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FFGINDGPJKI : NIKANHPDLKP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct AEBPLLJBAHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly float JKGHENBEODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly float ONIBBDPIEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		internal readonly bool EJBELALFPGK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float OJPHAFPPPNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x85CB570", Offset = "0x85C9B70", VA = "0x1885CB570")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x85CB6F0", Offset = "0x85C9CF0", VA = "0x1885CB6F0")]
		public AEBPLLJBAHP(float NEIBMENBNPA, float LGCPIJCGKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x85CB580", Offset = "0x85C9B80", VA = "0x1885CB580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class HFEKKLCMBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public FFGINDGPJKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public HFEKKLCMBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x85CCE70", Offset = "0x85CB470", VA = "0x1885CCE70")]
		internal void KFAJCOOMDPJ(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int FAALOCBOHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int KLPOINEEIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NIKANHPDLKP[] KDOGPIEPKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MAEGMFJEANC[] KEBEIAGOJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly AEBPLLJBAHP[] IBLPGFOGGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private AEBPLLJBAHP NCIBJDIOBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KLLLPHCNBJC AOCFCGAPONC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MAEGMFJEANC FELDMBNMJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x85CC6E0", Offset = "0x85CACE0", VA = "0x1885CC6E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85CC7A0", Offset = "0x85CADA0", VA = "0x1885CC7A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x85CC860", Offset = "0x85CAE60", VA = "0x1885CC860")]
	public FFGINDGPJKI(int FAALOCBOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x85CC650", Offset = "0x85CAC50", VA = "0x1885CC650")]
	public KLLLPHCNBJC HCBAFNCNBML(AEBPLLJBAHP KNPJHKKMLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x85CC1D0", Offset = "0x85CA7D0", VA = "0x1885CC1D0")]
	public void EJNIHAKIFGL(NIKANHPDLKP LEJJGKIMMBC, [Optional] AEBPLLJBAHP JGBKEJMBABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x85CC0C0", Offset = "0x85CA6C0", VA = "0x1885CC0C0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate void MAEGMFJEANC(float IJMEJNMHDND);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MEINGJEFFBA
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private class JMANABCFKBA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly NIKANHPDLKP JDHPPINLBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly MAEGMFJEANC GDMDDGECOJI;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x85CD530", Offset = "0x85CBB30", VA = "0x1885CD530")]
		public JMANABCFKBA(NIKANHPDLKP JDHPPINLBBH, MAEGMFJEANC GDMDDGECOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x85CD4E0", Offset = "0x85CBAE0", VA = "0x1885CD4E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x85CEAE0", Offset = "0x85CD0E0", VA = "0x1885CEAE0")]
	internal static bool CMEFBHCGJKL(float IAFDMJDNHDH, float DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x85BB470", Offset = "0x85B9A70", VA = "0x1885BB470")]
	internal static float DCFPJIKIPGM(float IAFDMJDNHDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x85CEB50", Offset = "0x85CD150", VA = "0x1885CEB50")]
	public static IDisposable EJLILIDOGGC(this NIKANHPDLKP JDHPPINLBBH, MAEGMFJEANC GDMDDGECOJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KLLLPHCNBJC : NIKANHPDLKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private float IJMEJNMHDND;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float NGOCGNPALPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85CE0A0", Offset = "0x85CC6A0", VA = "0x1885CE0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MAEGMFJEANC? FELDMBNMJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x85CE190", Offset = "0x85CC790", VA = "0x1885CE190", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x85CE230", Offset = "0x85CC830", VA = "0x1885CE230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KLLLPHCNBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface GCCHEFKIGPN<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGAJBCLHCIM<T> PEPFMPMNHIJ([Out] T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOIGDCNPPFG();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GLKAGNAFMGP<T> : GCCHEFKIGPN<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ConcurrentStack<T> IJIFKPINLNO;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5AA0", Offset = "0x4FF40A0", VA = "0x184FF5AA0", Slot = "4")]
	public GGAJBCLHCIM<T> PEPFMPMNHIJ([Out] T FKMNCAKIOFK)
	{
		return default(GGAJBCLHCIM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5B30", Offset = "0x4FF4130", VA = "0x184FF5B30")]
	public void PILMPNHBFAM(T LKGMDOIJIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x45A2BF0", Offset = "0x45A11F0", VA = "0x1845A2BF0", Slot = "5")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "6")]
	protected virtual void CNLEEFGAAKK(T NAJHBKPKHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5A10", Offset = "0x4FF4010", VA = "0x184FF5A10")]
	private T JLOHDPKHFGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5B90", Offset = "0x4FF4190", VA = "0x184FF5B90")]
	public GLKAGNAFMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct GGAJBCLHCIM<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly T LKGMDOIJIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly GLKAGNAFMGP<T> KKEHMECDMMK;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
	internal GGAJBCLHCIM(T FKMNCAKIOFK, GLKAGNAFMGP<T> KKEHMECDMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1040", Offset = "0x4FDF640", VA = "0x184FE1040", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class KFBHCLJIEJP : GLKAGNAFMGP<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public static readonly KFBHCLJIEJP DOBPPELCKJD;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x85CDF20", Offset = "0x85CC520", VA = "0x1885CDF20")]
	public static GGAJBCLHCIM<StringBuilder> JLOHDPKHFGN([Out] StringBuilder FKMNCAKIOFK)
	{
		return default(GGAJBCLHCIM<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x85CDF00", Offset = "0x85CC500", VA = "0x1885CDF00", Slot = "6")]
	protected override void CNLEEFGAAKK(StringBuilder NAJHBKPKHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x85CE060", Offset = "0x85CC660", VA = "0x1885CE060")]
	public KFBHCLJIEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BLPMFAFAHEG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7E015C0", Offset = "0x7DFFBC0", VA = "0x187E015C0")]
	public BLPMFAFAHEG(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public class JHJBGHCHFJO<TKey, TValue> : NGLFCNBCIBB<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, FMCGHLHFOBD where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class FFFNPMMPEGG : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JHJBGHCHFJO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x12868E0", Offset = "0x1284EE0", VA = "0x1812868E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x4F3A3E0", Offset = "0x4F389E0", VA = "0x184F3A3E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public FFFNPMMPEGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A430", Offset = "0x4F38A30", VA = "0x184F3A430", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4F39980", Offset = "0x4F37F80", VA = "0x184F39980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A210", Offset = "0x4F38810", VA = "0x184F3A210")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4F39430", Offset = "0x4F37A30", VA = "0x184F39430")]
		private void LGNDDFAIONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A300", Offset = "0x4F38900", VA = "0x184F3A300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NGLFCNBCIBB<TKey, TValue> LHFKDHEGAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly IDictionary<TKey, TValue> LIHLBOGBFPO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x54BC2B0", Offset = "0x54BA8B0", VA = "0x1854BC2B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HBGKHJAILJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x54BC480", Offset = "0x54BAA80", VA = "0x1854BC480", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x54BC6E0", Offset = "0x54BACE0", VA = "0x1854BC6E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> EKLAPLIICMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x54BC4C0", Offset = "0x54BAAC0", VA = "0x1854BC4C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> LNKJHKJCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x54BC5D0", Offset = "0x54BABD0", VA = "0x1854BC5D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x54BC130", Offset = "0x54BA730", VA = "0x1854BC130")]
	public JHJBGHCHFJO(NGLFCNBCIBB<TKey, TValue> LHFKDHEGAAJ, [Optional] IDictionary<TKey, TValue>? LIHLBOGBFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x54B9BC0", Offset = "0x54B81C0", VA = "0x1854B9BC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x54B9A40", Offset = "0x54B8040", VA = "0x1854B9A40")]
	public void BDNLAHMLFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x54B9590", Offset = "0x54B7B90", VA = "0x1854B9590", Slot = "9")]
	public void Add(TKey HFLDIIIPBCG, TValue FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x54BA880", Offset = "0x54B8E80", VA = "0x1854BA880")]
	public void IDCPMGFGBDJ(TKey HFLDIIIPBCG, TValue FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x54BAAE0", Offset = "0x54B90E0", VA = "0x1854BAAE0")]
	public void LMMEKNMGELC(TKey HFLDIIIPBCG, TValue FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x54BADA0", Offset = "0x54B93A0", VA = "0x1854BADA0")]
	public void MLPGCOBLEIO(TKey HFLDIIIPBCG, TValue FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x54BA5F0", Offset = "0x54B8BF0", VA = "0x1854BA5F0")]
	public void GPAFLFMGMDF(TKey HFLDIIIPBCG, TValue FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x54BB760", Offset = "0x54B9D60", VA = "0x1854BB760", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x54BB960", Offset = "0x54B9F60", VA = "0x1854BB960", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x54BBCC0", Offset = "0x54BA2C0", VA = "0x1854BBCC0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x54B9C30", Offset = "0x54B8230", VA = "0x1854B9C30", Slot = "8")]
	public bool ContainsKey(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x54B9AF0", Offset = "0x54B80F0", VA = "0x1854B9AF0")]
	public bool CEKKLIPACBH(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x54BAC70", Offset = "0x54B9270", VA = "0x1854BAC70")]
	public bool LNBOLMBBFLF(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x54BB500", Offset = "0x54B9B00", VA = "0x1854BB500", Slot = "10")]
	public bool Remove(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x54BBF90", Offset = "0x54BA590", VA = "0x1854BBF90", Slot = "11")]
	public bool TryGetValue(TKey HFLDIIIPBCG, [Out] TValue FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x54BA220", Offset = "0x54B8820", VA = "0x1854BA220", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] OHHBFAGELLA, int NCHALONGAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x54BBE80", Offset = "0x54BA480", VA = "0x1854BBE80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x54BA720", Offset = "0x54B8D20", VA = "0x1854BA720", Slot = "19")]
	[IteratorStateMachine(typeof(JHJBGHCHFJO<, >.FFFNPMMPEGG))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x54BA4C0", Offset = "0x54B8AC0", VA = "0x1854BA4C0", Slot = "21")]
	public bool FBCMOFJBHPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x54BB250", Offset = "0x54B9850", VA = "0x1854BB250")]
	private TValue NNCLOCJEHLG(TKey HFLDIIIPBCG)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DNGADGFIHNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string FLLDEEPKBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface FMCGHLHFOBD
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBCMOFJBHPP();
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface NGLFCNBCIBB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FMCGHLHFOBD
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[DefaultMember("Item")]
public sealed class NOICILHGILI<TKey, TVal> : NGLFCNBCIBB<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FMCGHLHFOBD where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate int OHMIAGADLED(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate void FACDFGCPJEI(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK, PLMAKIEOFED DAAMNHJEIGF);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private class KBLPGILAGAO
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey PMMIAHCCEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal FAGODIAEODP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAEDFA0", Offset = "0xAEC5A0", VA = "0x180AEDFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int OJPHAFPPPNA
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset AABABDOBAIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x14274A0", Offset = "0x1425AA0", VA = "0x1814274A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x155F7E0", Offset = "0x155DDE0", VA = "0x18155F7E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x55AD920", Offset = "0x55ABF20", VA = "0x1855AD920")]
		public KBLPGILAGAO(TKey HFLDIIIPBCG, TVal PGNMBFKGLAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class POBOMLIJIDL : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NOICILHGILI<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private LinkedList<KBLPGILAGAO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x12868E0", Offset = "0x1284EE0", VA = "0x1812868E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x5C9D190", Offset = "0x5C9B790", VA = "0x185C9D190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public POBOMLIJIDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F910", Offset = "0x4F1DF10", VA = "0x184F1F910", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B1D0", Offset = "0x5C997D0", VA = "0x185C9B1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CC30", Offset = "0x5C9B230", VA = "0x185C9CC30")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CFB0", Offset = "0x5C9B5B0", VA = "0x185C9CFB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public const int MKLLAIKHMGK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<TKey, LinkedListNode<KBLPGILAGAO>> HKEAGMCEDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly LinkedList<KBLPGILAGAO> IPGOECJLHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly OHMIAGADLED? BCLBBNPHGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly TimeSpan IMFBBFNDKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly FACDFGCPJEI? DDLHELKDEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly NBJJMADLGPF MFIPPPMMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private bool GJABABNPOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<TKey> KMPLLGJFPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly List<TVal> CJMLBKDNLHB;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int KEINBJHGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xB17F80", Offset = "0xB16580", VA = "0x180B17F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int FHCEILAEGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xEAD280", Offset = "0xEAB880", VA = "0x180EAD280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xFDBE70", Offset = "0xFDA470", VA = "0x180FDBE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5A23ED0", Offset = "0x5A224D0", VA = "0x185A23ED0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int BHFGHLHIEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5148CF0", Offset = "0x51472F0", VA = "0x185148CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> LNKJHKJCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5A24000", Offset = "0x5A22600", VA = "0x185A24000", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.FJEKOOGIMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5A1E600", Offset = "0x5A1CC00", VA = "0x185A1E600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool HBGKHJAILJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A23F60", Offset = "0x5A22560", VA = "0x185A23F60", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A24030", Offset = "0x5A22630", VA = "0x185A24030", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5A1BFA0", Offset = "0x5A1A5A0", VA = "0x185A1BFA0")]
	private bool MPIOMAPDPBN(int FAALOCBOHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5A0F8B0", Offset = "0x5A0DEB0", VA = "0x185A0F8B0")]
	private void GENBKJMLOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5A23E10", Offset = "0x5A22410", VA = "0x185A23E10")]
	public NOICILHGILI(int FAALOCBOHHG, [Optional] OHMIAGADLED? BCLBBNPHGJC, [Optional] IEqualityComparer<TKey>? GFNNIFMENBP, [Optional] FACDFGCPJEI? DDLHELKDEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5A1FAD0", Offset = "0x5A1E0D0", VA = "0x185A1FAD0")]
	public NOICILHGILI(TimeSpan IMFBBFNDKIC, [Optional] IEqualityComparer<TKey>? GFNNIFMENBP, [Optional] FACDFGCPJEI? DDLHELKDEIP, [Optional] NBJJMADLGPF? MFIPPPMMDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5A20340", Offset = "0x5A1E940", VA = "0x185A20340")]
	public NOICILHGILI(int FAALOCBOHHG, TimeSpan IMFBBFNDKIC, [Optional] IEqualityComparer<TKey>? GFNNIFMENBP, [Optional] FACDFGCPJEI? DDLHELKDEIP, [Optional] NBJJMADLGPF? MFIPPPMMDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A1F6C0", Offset = "0x5A1DCC0", VA = "0x185A1F6C0")]
	public NOICILHGILI(int FAALOCBOHHG, OHMIAGADLED? BCLBBNPHGJC, TimeSpan IMFBBFNDKIC, [Optional] IEqualityComparer<TKey>? GFNNIFMENBP, [Optional] FACDFGCPJEI? DDLHELKDEIP, [Optional] NBJJMADLGPF? MFIPPPMMDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5A0F840", Offset = "0x5A0DE40", VA = "0x185A0F840", Slot = "21")]
	public bool FBCMOFJBHPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5A0F020", Offset = "0x5A0D620", VA = "0x185A0F020", Slot = "22")]
	public bool EBIPFHAJNDC(int MLMBLBFOLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5A0AA30", Offset = "0x5A09030", VA = "0x185A0AA30")]
	private bool DGCMMCCLCKM(int MLMBLBFOLPC, PLMAKIEOFED DAAMNHJEIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5A05210", Offset = "0x5A03810", VA = "0x185A05210")]
	public void ADPGIIFDGLO(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5A06400", Offset = "0x5A04A00", VA = "0x185A06400", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A05A90", Offset = "0x5A04090", VA = "0x185A05A90", Slot = "9")]
	public void Add(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5A06E50", Offset = "0x5A05450", VA = "0x185A06E50", Slot = "8")]
	public bool ContainsKey(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5A1DD20", Offset = "0x5A1C320", VA = "0x185A1DD20", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D860", Offset = "0x5A1BE60", VA = "0x185A1D860", Slot = "10")]
	public bool Remove(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5A1E4D0", Offset = "0x5A1CAD0", VA = "0x185A1E4D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B050", Offset = "0x5A19650", VA = "0x185A1B050")]
	private bool MJCICEELGAH(TKey HFLDIIIPBCG, [Out] TVal FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5A183A0", Offset = "0x5A169A0", VA = "0x185A183A0")]
	private TVal JLOHDPKHFGN(TKey OMKCFPLCHGE)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5A1EF20", Offset = "0x5A1D520", VA = "0x185A1EF20", Slot = "11")]
	public bool TryGetValue(TKey OMKCFPLCHGE, [Out] TVal FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5A06BC0", Offset = "0x5A051C0", VA = "0x185A06BC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5A06EA0", Offset = "0x5A054A0", VA = "0x185A06EA0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OHHBFAGELLA, int NCHALONGAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C390", Offset = "0x5A1A990", VA = "0x185A1C390")]
	private void NIHNLBHJKCL(TKey HFLDIIIPBCG, TVal PGNMBFKGLAH, PLMAKIEOFED DAAMNHJEIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5A12DB0", Offset = "0x5A113B0", VA = "0x185A12DB0")]
	private bool JANBMOJLINP(KBLPGILAGAO FBADGHIEADN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5A16690", Offset = "0x5A14C90", VA = "0x185A16690")]
	private void JBMEIBJNHJG(LinkedListNode<KBLPGILAGAO> IEEBKIBAGGP, TVal BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5A0FFC0", Offset = "0x5A0E5C0", VA = "0x185A0FFC0")]
	private void GKJOFPFBKFG(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A0D0", Offset = "0x5A186D0", VA = "0x185A1A0D0")]
	private void MALNECIAAGF(KBLPGILAGAO FBADGHIEADN, TVal BDPHCAGFJCP, int OFLMIJCDMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5A126D0", Offset = "0x5A10CD0", VA = "0x185A126D0", Slot = "19")]
	[IteratorStateMachine(typeof(NOICILHGILI<, >.POBOMLIJIDL))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5A1E630", Offset = "0x5A1CC30", VA = "0x185A1E630", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum PLMAKIEOFED : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class ABGLKOLKGAP<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly TKey IPDPGHGHJFD;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x51DEAC0", Offset = "0x51DD0C0", VA = "0x1851DEAC0")]
	public ABGLKOLKGAP(TKey MAAOBGHCPBB, Exception ACENGOJDDLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GOKMFLMBMOD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7615B70", Offset = "0x7614170", VA = "0x187615B70")]
	public GOKMFLMBMOD(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class HPFPKBEMHCF<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class DEJAMDLAADL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public HPFPKBEMHCF<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public DEJAMDLAADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x45A1FD0", Offset = "0x45A05D0", VA = "0x1845A1FD0")]
		internal Task<TResource> BALFLJPPHKC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct AHEFGEIKGAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public HPFPKBEMHCF<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x53F3200", Offset = "0x53F1800", VA = "0x1853F3200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x53F37A0", Offset = "0x53F1DA0", VA = "0x1853F37A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct MHBKIFKBHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5958750", Offset = "0x5956D50", VA = "0x185958750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x59591D0", Offset = "0x59577D0", VA = "0x1859591D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly DBNAPDADEAG<TId, Task<TResource>> MFBHCGCGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> GEJNIIDPCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? IOGAKKHMIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Action<TResource>? IFKAFMLONGL;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5147790", Offset = "0x5145D90", VA = "0x185147790")]
	public HPFPKBEMHCF(int FAFEDGNEKFC = 0, [Optional] IEqualityComparer<TId>? NMINKACOKMM, [Optional] Func<TId, CancellationToken, Task<TResource>>? MJIIEMOLGEL, [Optional] Action<TResource>? IAKEKIDCKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5147190", Offset = "0x5145790", VA = "0x185147190")]
	public CJGHGFLGCGA<Task<TResource>> APOMBOKLKAC(TId JIEJOKBHEMF, [Optional] Func<TId, CancellationToken, Task<TResource>>? MJIIEMOLGEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x51475E0", Offset = "0x5145BE0", VA = "0x1851475E0")]
	private void OHCKCEIJJDL(Task<TResource> PIKAFIDPPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5147340", Offset = "0x5145940", VA = "0x185147340")]
	[AsyncStateMachine(typeof(HPFPKBEMHCF<, >.AHEFGEIKGAI))]
	private Task DFCMBKLDEGO(Task<TResource> PIKAFIDPPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5147160", Offset = "0x5145760", VA = "0x185147160")]
	public void AFCMMBJGBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5147440", Offset = "0x5145A40", VA = "0x185147440")]
	public DBNAPDADEAG<TId, Task<TResource>>.LOBHNIHOBNP DKMCAGKLCHH()
	{
		return default(DBNAPDADEAG<TId, Task<TResource>>.LOBHNIHOBNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x51476F0", Offset = "0x5145CF0", VA = "0x1851476F0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x51476F0", Offset = "0x5145CF0", VA = "0x1851476F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x51474B0", Offset = "0x5145AB0", VA = "0x1851474B0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(HPFPKBEMHCF<, >.MHBKIFKBHHG))]
	internal static Task JIBEBNAGICP(Task<TResource> PIKAFIDPPMC, CancellationTokenSource PHIDKGOIJJO, Dictionary<Task<TResource>, CancellationTokenSource> BJCGNAPIDOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class DBNAPDADEAG<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class KFLGAPNFFHP : IEquatable<KFLGAPNFFHP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly TValue FAGODIAEODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int PLNGEDDCLLG;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1026F80", Offset = "0x1025580", VA = "0x181026F80")]
		public KFLGAPNFFHP(TValue FKMNCAKIOFK, int AEPMKAKNIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x55B8FF0", Offset = "0x55B75F0", VA = "0x1855B8FF0", Slot = "4")]
		public bool Equals(KFLGAPNFFHP? IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x55B9080", Offset = "0x55B7680", VA = "0x1855B9080", Slot = "0")]
		public override bool Equals(object? NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x55B9240", Offset = "0x55B7840", VA = "0x1855B9240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public struct LOBHNIHOBNP : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<TKey, KFLGAPNFFHP>.Enumerator BLKIFPDMICE;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x574B3F0", Offset = "0x57499F0", VA = "0x18574B3F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x574B830", Offset = "0x5749E30", VA = "0x18574B830", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x574B6B0", Offset = "0x5749CB0", VA = "0x18574B6B0")]
		public LOBHNIHOBNP(DBNAPDADEAG<TKey, TValue> KMJJPAEMNAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x574B030", Offset = "0x5749630", VA = "0x18574B030", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x574B0F0", Offset = "0x57496F0", VA = "0x18574B0F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x574B290", Offset = "0x5749890", VA = "0x18574B290", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class KECAMMCMCJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public DBNAPDADEAG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public KFLGAPNFFHP refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KECAMMCMCJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x55B7240", Offset = "0x55B5840", VA = "0x1855B7240")]
		internal void BALFLJPPHKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly Dictionary<TKey, KFLGAPNFFHP> MPMOLEPONOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Func<TKey, TValue>? AJKMNLGMJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Action<TValue>? CFOBPGOOMLE;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4597250", Offset = "0x4595850", VA = "0x184597250")]
	public DBNAPDADEAG(int FAFEDGNEKFC = 0, [Optional] IEqualityComparer<TKey>? GFNNIFMENBP, [Optional] Func<TKey, TValue>? HDLHLECADJP, [Optional] Action<TValue>? ALLEKLKAKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4596730", Offset = "0x4594D30", VA = "0x184596730")]
	public CJGHGFLGCGA<TValue> APOMBOKLKAC(TKey HFLDIIIPBCG, [Optional] Func<TKey, TValue>? IEDBODBPPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4596EA0", Offset = "0x45954A0", VA = "0x184596EA0")]
	private void PILMPNHBFAM(TKey HFLDIIIPBCG, KFLGAPNFFHP OLKPKPEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4595DA0", Offset = "0x45943A0", VA = "0x184595DA0")]
	public void AFCMMBJGBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4596CD0", Offset = "0x45952D0", VA = "0x184596CD0")]
	public LOBHNIHOBNP DKMCAGKLCHH()
	{
		return default(LOBHNIHOBNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x45971B0", Offset = "0x45957B0", VA = "0x1845971B0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x45971B0", Offset = "0x45957B0", VA = "0x1845971B0", Slot = "5")]
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
