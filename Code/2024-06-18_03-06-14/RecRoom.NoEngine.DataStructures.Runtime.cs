using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x699E8D0", Offset = "0x699D2D0", VA = "0x18699E8D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MABNBKINPOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	protected MABNBKINPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GKAELHFIGIN<T> : MABNBKINPOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct EJIIHIGBCCG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum BLMJLHPNLBB
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
		public BLMJLHPNLBB ADDOHDGDFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T GKKKLNHPKBN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int OMJOMPNANNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool KMMBKGDOCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool MMFHHINBPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? EONOMFBJGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<EJIIHIGBCCG>? DGAFGPLGAGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FNMGBEJIIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D37360", Offset = "0x3D35D60", VA = "0x183D37360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D37BA0", Offset = "0x3D365A0", VA = "0x183D37BA0")]
	protected GKAELHFIGIN(bool MMFHHINBPNE, bool KMMBKGDOCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D37940", Offset = "0x3D36340", VA = "0x183D37940")]
	protected bool PHLPIOKELGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D373C0", Offset = "0x3D35DC0", VA = "0x183D373C0")]
	protected void IKFGBICGAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D374D0", Offset = "0x3D35ED0", VA = "0x183D374D0")]
	protected void JLHDOBJMNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A67F50", Offset = "0x2A66950", VA = "0x182A67F50")]
	private static void NLJFMEJMGPI<U>(List<U>? AGFBCPPODBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D37740", Offset = "0x3D36140", VA = "0x183D37740", Slot = "4")]
	public void KODKNHDNNHA(T GKKKLNHPKBN, bool EJBNBBFFBLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D379E0", Offset = "0x3D363E0", VA = "0x183D379E0", Slot = "5")]
	public void PLMGPBLKDNE(T GKKKLNHPKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D371C0", Offset = "0x3D35BC0", VA = "0x183D371C0")]
	public void EIMPLACCFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MNIMPDIHNFL : GKAELHFIGIN<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x699E0E0", Offset = "0x699CAE0", VA = "0x18699E0E0")]
	public MNIMPDIHNFL(bool MMFHHINBPNE = false, bool KMMBKGDOCAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x699DE20", Offset = "0x699C820", VA = "0x18699DE20")]
	public void EDIAJIJOMBB()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x699E020", Offset = "0x699CA20", VA = "0x18699E020")]
	public static MNIMPDIHNFL IIJOINIBEHF(MNIMPDIHNFL JNNOEHFGDFB, Action GKKKLNHPKBN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x699E080", Offset = "0x699CA80", VA = "0x18699E080")]
	public static MNIMPDIHNFL JDKHPBLOJJF(MNIMPDIHNFL JNNOEHFGDFB, Action GKKKLNHPKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DCOFHBDPONK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KODKNHDNNHA(Action<T> GKKKLNHPKBN, bool EJBNBBFFBLJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLMGPBLKDNE(Action<T> GKKKLNHPKBN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FCOLMBOCIND<T> : GKAELHFIGIN<Action<T>>, DCOFHBDPONK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3834160", Offset = "0x3832B60", VA = "0x183834160")]
	public FCOLMBOCIND(bool MMFHHINBPNE = false, bool KMMBKGDOCAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2270", Offset = "0x3BF0C70", VA = "0x183BF2270")]
	public void EDIAJIJOMBB(T FOCADABILLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3834020", Offset = "0x3832A20", VA = "0x183834020")]
	public static FCOLMBOCIND<T> IIJOINIBEHF(FCOLMBOCIND<T> JNNOEHFGDFB, Action<T> GKKKLNHPKBN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38340C0", Offset = "0x3832AC0", VA = "0x1838340C0")]
	public static FCOLMBOCIND<T> JDKHPBLOJJF(FCOLMBOCIND<T> JNNOEHFGDFB, Action<T> GKKKLNHPKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DJIECKGJJBC<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PFDDDEMFJMK<T, U> : GKAELHFIGIN<Action<T, U>>, DJIECKGJJBC<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3834160", Offset = "0x3832B60", VA = "0x183834160")]
	public PFDDDEMFJMK(bool MMFHHINBPNE = false, bool KMMBKGDOCAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x46C5860", Offset = "0x46C4260", VA = "0x1846C5860")]
	public void EDIAJIJOMBB(T FOCADABILLC, U IHKAEDPDEDK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3834020", Offset = "0x3832A20", VA = "0x183834020")]
	public static PFDDDEMFJMK<T, U> IIJOINIBEHF(PFDDDEMFJMK<T, U> JNNOEHFGDFB, Action<T, U> GKKKLNHPKBN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38340C0", Offset = "0x3832AC0", VA = "0x1838340C0")]
	public static PFDDDEMFJMK<T, U> JDKHPBLOJJF(PFDDDEMFJMK<T, U> JNNOEHFGDFB, Action<T, U> GKKKLNHPKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FNKGBDBKDEI<T, U, V> : GKAELHFIGIN<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3834160", Offset = "0x3832B60", VA = "0x183834160")]
	public FNKGBDBKDEI(bool MMFHHINBPNE = false, bool KMMBKGDOCAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C39120", Offset = "0x3C37B20", VA = "0x183C39120")]
	public void EDIAJIJOMBB(T FOCADABILLC, U IHKAEDPDEDK, V CGDFPKFKHGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3834020", Offset = "0x3832A20", VA = "0x183834020")]
	public static FNKGBDBKDEI<T, U, V> IIJOINIBEHF(FNKGBDBKDEI<T, U, V> JNNOEHFGDFB, Action<T, U, V> GKKKLNHPKBN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38340C0", Offset = "0x3832AC0", VA = "0x1838340C0")]
	public static FNKGBDBKDEI<T, U, V> JDKHPBLOJJF(FNKGBDBKDEI<T, U, V> JNNOEHFGDFB, Action<T, U, V> GKKKLNHPKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PBALEPKPBJE<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class GGKJKJLDGKL<T, U, V, W> : GKAELHFIGIN<Action<T, U, V, W>>, PBALEPKPBJE<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3834160", Offset = "0x3832B60", VA = "0x183834160")]
	public GGKJKJLDGKL(bool MMFHHINBPNE = false, bool KMMBKGDOCAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D29B30", Offset = "0x3D28530", VA = "0x183D29B30")]
	public void EDIAJIJOMBB(T FOCADABILLC, U IHKAEDPDEDK, V CGDFPKFKHGF, W HOMMGDFGJHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3834020", Offset = "0x3832A20", VA = "0x183834020")]
	public static GGKJKJLDGKL<T, U, V, W> IIJOINIBEHF(GGKJKJLDGKL<T, U, V, W> JNNOEHFGDFB, Action<T, U, V, W> GKKKLNHPKBN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38340C0", Offset = "0x3832AC0", VA = "0x1838340C0")]
	public static GGKJKJLDGKL<T, U, V, W> JDKHPBLOJJF(GGKJKJLDGKL<T, U, V, W> JNNOEHFGDFB, Action<T, U, V, W> GKKKLNHPKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class EBGNHFJDCGK<T, U, V, W, X> : GKAELHFIGIN<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3834160", Offset = "0x3832B60", VA = "0x183834160")]
	public EBGNHFJDCGK(bool MMFHHINBPNE = false, bool KMMBKGDOCAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x38338B0", Offset = "0x38322B0", VA = "0x1838338B0")]
	public void EDIAJIJOMBB(T FOCADABILLC, U IHKAEDPDEDK, V CGDFPKFKHGF, W HOMMGDFGJHF, X PHDMOAMCFBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3834020", Offset = "0x3832A20", VA = "0x183834020")]
	public static EBGNHFJDCGK<T, U, V, W, X> IIJOINIBEHF(EBGNHFJDCGK<T, U, V, W, X> JNNOEHFGDFB, Action<T, U, V, W, X> GKKKLNHPKBN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38340C0", Offset = "0x3832AC0", VA = "0x1838340C0")]
	public static EBGNHFJDCGK<T, U, V, W, X> JDKHPBLOJJF(EBGNHFJDCGK<T, U, V, W, X> JNNOEHFGDFB, Action<T, U, V, W, X> GKKKLNHPKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BNGIPEHOBCC<T, U, V, W, X, Y> : GKAELHFIGIN<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3834160", Offset = "0x3832B60", VA = "0x183834160")]
	public BNGIPEHOBCC(bool MMFHHINBPNE = false, bool KMMBKGDOCAE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E29220", Offset = "0x4E27C20", VA = "0x184E29220")]
	public void EDIAJIJOMBB(T FOCADABILLC, U IHKAEDPDEDK, V CGDFPKFKHGF, W HOMMGDFGJHF, X PHDMOAMCFBE, Y CPHIHAJIIFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3834020", Offset = "0x3832A20", VA = "0x183834020")]
	public static BNGIPEHOBCC<T, U, V, W, X, Y> IIJOINIBEHF(BNGIPEHOBCC<T, U, V, W, X, Y> JNNOEHFGDFB, Action<T, U, V, W, X, Y> GKKKLNHPKBN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38340C0", Offset = "0x3832AC0", VA = "0x1838340C0")]
	public static BNGIPEHOBCC<T, U, V, W, X, Y> JDKHPBLOJJF(BNGIPEHOBCC<T, U, V, W, X, Y> JNNOEHFGDFB, Action<T, U, V, W, X, Y> GKKKLNHPKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FCKIPGJOOHB<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CODGJNGJIAK<TKey, TVal> NAOFJBJFBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> ACIAIOLACOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CODGJNGJIAK<TKey, TVal>.APNCHEFCAJE? PMLPBPBHEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int NKFGIIKAMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CODGJNGJIAK<TKey, TVal>.JJKKJLBOIBC? ADGLPPPDIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int AJEFIOJIANA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int PLLNPNDOIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0CD0", Offset = "0x3BEF6D0", VA = "0x183BF0CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JNJKJLALEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8566A0", Offset = "0x8550A0", VA = "0x1808566A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1650", Offset = "0x3BF0050", VA = "0x183BF1650")]
	public FCKIPGJOOHB(int NKFGIIKAMEA, [Optional] CODGJNGJIAK<TKey, TVal>.JJKKJLBOIBC? ADGLPPPDIGJ, [Optional] IEqualityComparer<TKey>? CELMPCDCIGH, [Optional] CODGJNGJIAK<TKey, TVal>.APNCHEFCAJE? PMLPBPBHEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0780", Offset = "0x3BEF180", VA = "0x183BF0780")]
	public void EIINNDNEKNJ(TKey LDDEKIBHION, TVal DBOBEHLEAAE, bool MEKHKEPJHPG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0360", Offset = "0x3BEED60", VA = "0x183BF0360")]
	public bool BKNHNNFGJGA(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0ED0", Offset = "0x3BEF8D0", VA = "0x183BF0ED0")]
	public bool NMDJKMBCDDJ(TKey KEFBHDJBMMG, [Out] TVal DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3BF04C0", Offset = "0x3BEEEC0", VA = "0x183BF04C0")]
	private void CDKFELPHPEC(TKey LDDEKIBHION, TVal DBOBEHLEAAE, int BKEGNEKBPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0D20", Offset = "0x3BEF720", VA = "0x183BF0D20")]
	public bool NELIHGKJDAL(TKey LDDEKIBHION, TVal DBOBEHLEAAE, bool MEKHKEPJHPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3BF09B0", Offset = "0x3BEF3B0", VA = "0x183BF09B0")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3BF10F0", Offset = "0x3BEFAF0", VA = "0x183BF10F0")]
	private void PGJJJMGGBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0A60", Offset = "0x3BEF460", VA = "0x183BF0A60")]
	private bool HDKHCCBDGNF(TKey LDDEKIBHION, GOFBCHMFFEI GDIKEMIFDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0FD0", Offset = "0x3BEF9D0", VA = "0x183BF0FD0")]
	private void OAPGAIDHMLD(TKey LDDEKIBHION, TVal DBOBEHLEAAE, GOFBCHMFFEI GDIKEMIFDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0BA0", Offset = "0x3BEF5A0", VA = "0x183BF0BA0")]
	private void HMDDLOIPEEA(TKey LDDEKIBHION, TVal EHIEOLDDJEB, GOFBCHMFFEI GDIKEMIFDHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HHODKOPHPJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action IGBIIJDPKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool IHGNBJMOFEB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public HHODKOPHPJG(Action LBAFLCIBONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x699C7D0", Offset = "0x699B1D0", VA = "0x18699C7D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28BF6B0", Offset = "0x28BE0B0", VA = "0x1828BF6B0")]
	public static MAGIJMJBHDB<T> CBNOJCEAKCL<T>(T DBOBEHLEAAE, Action LBAFLCIBONF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class MAGIJMJBHDB<T> : HHODKOPHPJG where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T NHLIMKDHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4459E30", Offset = "0x4458830", VA = "0x184459E30")]
	public MAGIJMJBHDB(T DBOBEHLEAAE, Action LBAFLCIBONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class OMOGEJKOABD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HFLDCEHOEBN<T>? LKMAOJHGIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> IPDCOCDPJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool IHGNBJMOFEB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly OMOGEJKOABD<T> EOPMNGGGOOO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> AOALANKPNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4620FE0", Offset = "0x461F9E0", VA = "0x184620FE0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NBLIGAPNOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x46210F0", Offset = "0x461FAF0", VA = "0x1846210F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DJEJGGIOHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4621330", Offset = "0x461FD30", VA = "0x184621330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4621C20", Offset = "0x4620620", VA = "0x184621C20")]
	public OMOGEJKOABD(HFLDCEHOEBN<T> PJELHMPMBOJ, HFLDCEHOEBN<T> KDNOFBANBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4621D10", Offset = "0x4620710", VA = "0x184621D10")]
	public OMOGEJKOABD(HFLDCEHOEBN<T> PJELHMPMBOJ, int PFNBAEBFNFJ, HFLDCEHOEBN<T> KDNOFBANBDI, int HKIJEAMDPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x46217C0", Offset = "0x46201C0", VA = "0x1846217C0")]
	private OMOGEJKOABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4621060", Offset = "0x461FA60", VA = "0x184621060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x46214A0", Offset = "0x461FEA0", VA = "0x1846214A0")]
	public T[] MEAGOHACMGM()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4621550", Offset = "0x461FF50", VA = "0x184621550")]
	public static ReadOnlySequence<T> OCHPDIOAFKC(OMOGEJKOABD<T>? EEKOBDBJGKD)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct EIFADGOBFBO : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct AIIKFCMMCOB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
		public static AIIKFCMMCOB KHKANEAPNIK()
		{
			return default(AIIKFCMMCOB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29B3240", Offset = "0x29B1C40", VA = "0x1829B3240")]
	public static string? EFLAIHEEFEB<T>([Optional] string? CPAEDHOBPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29B32C0", Offset = "0x29B1CC0", VA = "0x1829B32C0")]
	public static string? NPBMEHNEADO<T>([Optional] string? DBOPGEOJONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	public static EIFADGOBFBO EOFJCPMGPOI(string CPAEDHOBPIK, string? DBOPGEOJONB)
	{
		return default(EIFADGOBFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JOFDKDIOOGF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool CEDFFCGEFJL(string LIBANKJGFBP, JOFDKDIOOGF IJKEPEDFJJM);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OMOBNHAHKFN<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public OMOBNHAHKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4620EA0", Offset = "0x461F8A0", VA = "0x184620EA0")]
		internal void MFGLJONFDMD(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int BLJILELIBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string DGGDMDHJJDP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x699D8E0", Offset = "0x699C2E0", VA = "0x18699D8E0")]
	public static Dictionary<string, JOFDKDIOOGF> NBBMAKJAIPK(Type FALNMJPDMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B86070", Offset = "0x2B84A70", VA = "0x182B86070")]
	public static Dictionary<string, JOFDKDIOOGF> NBBMAKJAIPK<T>(Type FALNMJPDMOJ, IReadOnlyDictionary<T, string> NGBJOGOFKOO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B86890", Offset = "0x2B85290", VA = "0x182B86890")]
	public static Dictionary<string, JOFDKDIOOGF> OEHFGLMLNCC<T>(List<T> DEJPBGILGGM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x699D360", Offset = "0x699BD60", VA = "0x18699D360")]
	public static Dictionary<string, JOFDKDIOOGF> AKIDODKGEDI(Type FALNMJPDMOJ, CEDFFCGEFJL MOKKMOCDNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x699D720", Offset = "0x699C120", VA = "0x18699D720")]
	public static Dictionary<int, string> JOOMKINMMHH(Dictionary<string, JOFDKDIOOGF> LBIKMBJEOGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DNHFHLFKGGH : LHAJNHDLEEF
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool AOMKEPGNKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? MCKDGHLPOGE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual LHAJNHDLEEF? FDLKEKIBNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x699C150", Offset = "0x699AB50", VA = "0x18699C150")]
	protected DNHFHLFKGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BMFLCAMIMMJ();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x699BFB0", Offset = "0x699A9B0", VA = "0x18699BFB0", Slot = "8")]
	public virtual string OJLKLEOEBAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x699BAB0", Offset = "0x699A4B0", VA = "0x18699BAB0", Slot = "9")]
	public void CDFCJBCLBOP(StringBuilder EHCMFAEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x699BD50", Offset = "0x699A750", VA = "0x18699BD50", Slot = "10")]
	public void DGPMHLIMCJP(StringBuilder EHCMFAEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x699C030", Offset = "0x699AA30", VA = "0x18699C030", Slot = "11")]
	public void PDKDNKJJBJF(StringBuilder EHCMFAEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x699BE50", Offset = "0x699A850", VA = "0x18699BE50", Slot = "12")]
	public void NBGLKBKADPG(StringBuilder EHCMFAEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x699BDB0", Offset = "0x699A7B0", VA = "0x18699BDB0")]
	public static void KBBPFPOKDOC(StringBuilder EHCMFAEAOHB, string GGLEFNIGOIN, string AODNDNFKGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B7C420", Offset = "0x5B7AE20", VA = "0x185B7C420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PJGDCJFIEIE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x699E950", Offset = "0x699D350", VA = "0x18699E950")]
	public PJGDCJFIEIE(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class COKOOPEJGMH<TErr> : PJGDCJFIEIE where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr GPGNIOBBKLO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x534F100", Offset = "0x534DB00", VA = "0x18534F100")]
	private COKOOPEJGMH([In] TErr CEAKAAHDJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x534F030", Offset = "0x534DA30", VA = "0x18534F030")]
	public static COKOOPEJGMH<TErr> KHKANEAPNIK([In] TErr CEAKAAHDJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LHAJNHDLEEF
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OJLKLEOEBAG();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BMFLCAMIMMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FMAMBJHMNCE<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	TOptions NHLIMKDHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BMBAKDMIEDF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string CFHHNGCLDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class HFLDCEHOEBN<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static HFLDCEHOEBN<T>? BBJOPLPAPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static object MDKPMCLEFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IMemoryOwner<T>? PHPLBEILHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool IHGNBJMOFEB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FIGHPIBDBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3DE0", Offset = "0x9D27E0", VA = "0x1809D3DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3DC41A0", Offset = "0x3DC2BA0", VA = "0x183DC41A0")]
	private static HFLDCEHOEBN<T> EOENOJNCILA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC4790", Offset = "0x3DC3190", VA = "0x183DC4790")]
	private static void JOKHGCLOIBK(HFLDCEHOEBN<T> OHPACNNLCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5430", Offset = "0x3DC3E30", VA = "0x183DC5430")]
	private HFLDCEHOEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC36F0", Offset = "0x3DC20F0", VA = "0x183DC36F0")]
	public static HFLDCEHOEBN<T> CBNOJCEAKCL(ReadOnlyMemory<T> DACLFJFAECP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC38C0", Offset = "0x3DC22C0", VA = "0x183DC38C0")]
	public static HFLDCEHOEBN<T> CBNOJCEAKCL(IMemoryOwner<T> JJLIJOHCJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5050", Offset = "0x3DC3A50", VA = "0x183DC5050")]
	public static void PLIJDLNNEHL(HFLDCEHOEBN<T> PJELHMPMBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3CA0", Offset = "0x3DC26A0", VA = "0x183DC3CA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3DC4D40", Offset = "0x3DC3740", VA = "0x183DC4D40")]
	public HFLDCEHOEBN<T> MKOPHGCIALK(IMemoryOwner<T> JJLIJOHCJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3DC4F50", Offset = "0x3DC3950", VA = "0x183DC4F50")]
	private void PDLGLHHFDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3DC4640", Offset = "0x3DC3040", VA = "0x183DC4640")]
	private HFLDCEHOEBN<T> HFFODLLHAKM(HFLDCEHOEBN<T> OHPACNNLCHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LOJKKOPCJJK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x699DDC0", Offset = "0x699C7C0", VA = "0x18699DDC0")]
	public LOJKKOPCJJK(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CAAKIAJMNKF<TOk> : LOJKKOPCJJK where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly TOk HLJFENILILA;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4F8D5E0", Offset = "0x4F8BFE0", VA = "0x184F8D5E0")]
	private CAAKIAJMNKF([In] TOk CEDKPMFKDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x405CF40", Offset = "0x405B940", VA = "0x18405CF40")]
	public static CAAKIAJMNKF<TOk> KHKANEAPNIK([In] TOk CEDKPMFKDOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class APNMHFIOAHC : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ReadOnlySequence<byte> IPDCOCDPJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private SequencePosition MDGNFDLPNJK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool AAFILBKMOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override bool EGMACGKDCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override bool LCPEGBJJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override long NBLIGAPNOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x699B7A0", Offset = "0x699A1A0", VA = "0x18699B7A0", Slot = "11")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override long IOJOFKPMLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x699B800", Offset = "0x699A200", VA = "0x18699B800", Slot = "12")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x699B8D0", Offset = "0x699A2D0", VA = "0x18699B8D0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x699B6D0", Offset = "0x699A0D0", VA = "0x18699B6D0")]
	public APNMHFIOAHC(ReadOnlySequence<byte> EEKOBDBJGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x699B280", Offset = "0x6999C80", VA = "0x18699B280", Slot = "32")]
	public override long Seek(long LJEHDHLGGJA, SeekOrigin FLANCHPFPCL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x699ADE0", Offset = "0x69997E0", VA = "0x18699ADE0", Slot = "34")]
	public override int Read(byte[] BLNHMFAPOOE, int LJEHDHLGGJA, int OHELHAFFKFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "22")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x699B610", Offset = "0x699A010", VA = "0x18699B610", Slot = "33")]
	public override void SetLength(long DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x699B670", Offset = "0x699A070", VA = "0x18699B670", Slot = "37")]
	public override void Write(byte[] BLNHMFAPOOE, int LJEHDHLGGJA, int OHELHAFFKFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct FNBKHJCMJJM<TOk, TErr> : IEquatable<FNBKHJCMJJM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly EqualityComparer<TErr> GJHPIOKBAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TErr GPGNIOBBKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TOk HLJFENILILA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool OBFDLJFLBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BEC0", Offset = "0x3C2A8C0", VA = "0x183C2BEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ADGLPDILLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3C2AF00", Offset = "0x3C29900", VA = "0x183C2AF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DDD0", Offset = "0x3C2C7D0", VA = "0x183C2DDD0")]
	internal FNBKHJCMJJM([In] TErr CEAKAAHDJAF, [In] TOk CEDKPMFKDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C240", Offset = "0x3C2AC40", VA = "0x183C2C240")]
	public static FNBKHJCMJJM<TOk, TErr> PEEEDOMLBMA([In] TErr CEAKAAHDJAF)
	{
		return default(FNBKHJCMJJM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C6A0", Offset = "0x3C2B0A0", VA = "0x183C2C6A0")]
	public static FNBKHJCMJJM<TOk, TErr> PKADOEEHHEM([In] TOk CEDKPMFKDOC)
	{
		return default(FNBKHJCMJJM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A651F0", Offset = "0x2A63BF0", VA = "0x182A651F0")]
	public FNBKHJCMJJM<TOk?, UErr?> BFDCGIBCKCH<UErr>()
	{
		return default(FNBKHJCMJJM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A65CD0", Offset = "0x2A646D0", VA = "0x182A65CD0")]
	public FNBKHJCMJJM<UOk?, TErr?> IFKBBIOPEEI<UOk>()
	{
		return default(FNBKHJCMJJM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2A667A0", Offset = "0x2A651A0", VA = "0x182A667A0")]
	public FNBKHJCMJJM<UOk?, TErr?> OKDIHIHMFCC<UOk>()
	{
		return default(FNBKHJCMJJM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2A650D0", Offset = "0x2A63AD0", VA = "0x182A650D0")]
	public FNBKHJCMJJM<TOk?, UErr?> AHEPCOMDMDD<UErr>()
	{
		return default(FNBKHJCMJJM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C296D0", Offset = "0x3C280D0", VA = "0x183C296D0")]
	public FNBKHJCMJJM<LMMCANLFCCL, TErr> CPBHDHIPCHN()
	{
		return default(FNBKHJCMJJM<LMMCANLFCCL, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2B980", Offset = "0x3C2A380", VA = "0x183C2B980")]
	public static bool IKJGJDJDJIH([In] FNBKHJCMJJM<TOk, TErr> FKJLOGAHGLJ, [In] FNBKHJCMJJM<TOk, TErr> MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3C29F90", Offset = "0x3C28990", VA = "0x183C29F90", Slot = "4")]
	public bool Equals(FNBKHJCMJJM<TOk, TErr> HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3C29930", Offset = "0x3C28330", VA = "0x183C29930", Slot = "0")]
	public override bool Equals(object HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A660", Offset = "0x3C29060", VA = "0x183C2A660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DAA0", Offset = "0x3C2C4A0", VA = "0x183C2DAA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class OBLLPNIDKLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct HKBHMPPMCKA<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Task<FNBKHJCMJJM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<FNBKHJCMJJM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEB10", Offset = "0x3DDD510", VA = "0x183DDEB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEE30", Offset = "0x3DDD830", VA = "0x183DDEE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2CA09E0", Offset = "0x2C9F3E0", VA = "0x182CA09E0")]
	public static FNBKHJCMJJM<TOk?, TErr?> HLJFENILILA<TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [In] TOk CEDKPMFKDOC)
	{
		return default(FNBKHJCMJJM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0BB0", Offset = "0x2C9F5B0", VA = "0x182CA0BB0")]
	public static FNBKHJCMJJM<LMMCANLFCCL, TErr?> HLJFENILILA<TErr>([In] this FNBKHJCMJJM<LMMCANLFCCL, TErr> BBCPNLGGBMJ)
	{
		return default(FNBKHJCMJJM<LMMCANLFCCL, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2CA09E0", Offset = "0x2C9F3E0", VA = "0x182CA09E0")]
	public static FNBKHJCMJJM<TOk?, TErr?> GPGNIOBBKLO<TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [In] TErr CEAKAAHDJAF)
	{
		return default(FNBKHJCMJJM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0430", Offset = "0x2C9EE30", VA = "0x182CA0430")]
	public static TOk? FKHJCCACAAH<TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0C50", Offset = "0x2C9F650", VA = "0x182CA0C50")]
	[AsyncStateMachine(typeof(HKBHMPPMCKA<, >))]
	public static Task<TOk?>? ILKJNMMNMPG<TOk, TErr>(this Task<FNBKHJCMJJM<TOk, TErr>> BBCPNLGGBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F4D0", Offset = "0x2C9DED0", VA = "0x182C9F4D0")]
	public static TErr? ABOHEFKCEKK<TErr, TOk>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1920", Offset = "0x2CA0320", VA = "0x182CA1920")]
	public static bool NGBIOMAOPOP<TOk, TErr, UErr, UOk>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [Out] FNBKHJCMJJM<UOk, UErr> COOFOGEJEHP) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1060", Offset = "0x2C9FA60", VA = "0x182CA1060")]
	public static bool INDHHHJBKDB<TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [Out][NotNullWhen(true)] TOk CEDKPMFKDOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0F20", Offset = "0x2C9F920", VA = "0x182CA0F20")]
	public static bool IMLDLFAACEC<TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [Out][NotNullWhen(true)] TErr CEAKAAHDJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1670", Offset = "0x2CA0070", VA = "0x182CA1670")]
	public static bool LILHBJLHKBC<TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [Out][NotNullWhen(true)] TOk CEDKPMFKDOC, [Out][NotNullWhen(false)] TErr CEAKAAHDJAF) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FC60", Offset = "0x2C9E660", VA = "0x182C9FC60")]
	public static bool EPPPKDHCAMH<TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [Out][NotNullWhen(true)] TOk CEDKPMFKDOC, [Out] FNBKHJCMJJM<TOk, TErr> COOFOGEJEHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA17F0", Offset = "0x2CA01F0", VA = "0x182CA17F0")]
	public static bool NGBIOMAOPOP<TOk, TErr, UErr, UOk>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [Out][NotNullWhen(true)] TOk CEDKPMFKDOC, [Out] FNBKHJCMJJM<UOk, UErr> COOFOGEJEHP) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1230", Offset = "0x2C9FC30", VA = "0x182CA1230")]
	public static bool KGHFLBEHNBK<TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [Out][NotNullWhen(true)] TOk CEDKPMFKDOC, [Out] FNBKHJCMJJM<LMMCANLFCCL, TErr> COOFOGEJEHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C9FD60", Offset = "0x2C9E760", VA = "0x182C9FD60")]
	public static FNBKHJCMJJM<UOk, UErr> FFIDJPNALLH<UOk, UErr, TOk, TErr>([In] this FNBKHJCMJJM<TOk, TErr> BBCPNLGGBMJ, [In] FNBKHJCMJJM<UOk, UErr> MAJFEBAGNLL) where TOk : UOk where TErr : UErr
	{
		return default(FNBKHJCMJJM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F8F0", Offset = "0x2C9E2F0", VA = "0x182C9F8F0")]
	public static FNBKHJCMJJM<TOk?[]?, TErr?> BJJJHAAIAII<TOk, TErr>(this IEnumerable<FNBKHJCMJJM<TOk, TErr>> BBCPNLGGBMJ)
	{
		return default(FNBKHJCMJJM<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KHIEIKCDDKH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A7F0", Offset = "0x2A691F0", VA = "0x182A6A7F0")]
	public static FNBKHJCMJJM<TOk, T> HLJFENILILA<TOk>([In] TOk CEDKPMFKDOC) where TOk : notnull
	{
		return default(FNBKHJCMJJM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x41C14D0", Offset = "0x41BFED0", VA = "0x1841C14D0")]
	public static FNBKHJCMJJM<LMMCANLFCCL, T> HLJFENILILA()
	{
		return default(FNBKHJCMJJM<LMMCANLFCCL, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A890", Offset = "0x2A69290", VA = "0x182A6A890")]
	public static FNBKHJCMJJM<T, TErr> GPGNIOBBKLO<TErr>([In] TErr CEAKAAHDJAF) where TErr : notnull
	{
		return default(FNBKHJCMJJM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public sealed class PIPOODNNAMI<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private readonly struct MNONDJMEAEP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly PIPOODNNAMI<T> FINLKJIMOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly int MMACNGDDLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly bool JACNANOCDAN;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F820", Offset = "0x1E8E220", VA = "0x181E8F820")]
		public MNONDJMEAEP(PIPOODNNAMI<T> PEDEOCHCNFH, int IBCOOKIDGHF, bool LDIKCKMNNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4481800", Offset = "0x4480200", VA = "0x184481800")]
		public PIPOODNNAMI<T>.MOHDLDFMLJL PNMCCDOOLCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x44818F0", Offset = "0x44802F0", VA = "0x1844818F0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x44818F0", Offset = "0x44802F0", VA = "0x1844818F0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class MOHDLDFMLJL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly PIPOODNNAMI<T> FINLKJIMOCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly int HOFCJOCIONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int FBBOFGCNIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly bool JACNANOCDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool LGJCKKEBCAF;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x4483C50", Offset = "0x4482650", VA = "0x184483C50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4483DC0", Offset = "0x44827C0", VA = "0x184483DC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4484070", Offset = "0x4482A70", VA = "0x184484070", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4484310", Offset = "0x4482D10", VA = "0x184484310")]
		public MOHDLDFMLJL(PIPOODNNAMI<T> PEDEOCHCNFH, int IBCOOKIDGHF, bool LDIKCKMNNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4483D10", Offset = "0x4482710", VA = "0x184483D10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4483DA0", Offset = "0x44827A0", VA = "0x184483DA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IGCKMPDIIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public IGCKMPDIIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A520", Offset = "0x3E98F20", VA = "0x183E9A520")]
		internal T DBFCLFEJFAB(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly T[] OGLCLMPKFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int FBBOFGCNIFP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PEBMIEKEFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x46D3650", Offset = "0x46D2050", VA = "0x1846D3650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T NHBEFFGDNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1420", Offset = "0x3BDFE20", VA = "0x183BE1420")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T FIFIAJBOHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x46D36B0", Offset = "0x46D20B0", VA = "0x1846D36B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x46D34F0", Offset = "0x46D1EF0", VA = "0x1846D34F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int NBLIGAPNOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x18FFC60", Offset = "0x18FE660", VA = "0x1818FFC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x11501A0", Offset = "0x114EBA0", VA = "0x1811501A0")]
	private static int BCGDIOILKAC(int ILOCEPPJPDO, int NDKEFFPEPII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x46D3790", Offset = "0x46D2190", VA = "0x1846D3790")]
	public PIPOODNNAMI(int BKEGNEKBPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x46D3810", Offset = "0x46D2210", VA = "0x1846D3810")]
	public PIPOODNNAMI(int BKEGNEKBPFA, Func<T> NGICOEMIGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x46D3B10", Offset = "0x46D2510", VA = "0x1846D3B10")]
	public PIPOODNNAMI(T[] KJGLHKICAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46D3620", Offset = "0x46D2020", VA = "0x1846D3620")]
	public void KGLHKDKLDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46D3560", Offset = "0x46D1F60", VA = "0x1846D3560")]
	public IEnumerable<T> JGAPNPAGCIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x46D36F0", Offset = "0x46D20F0", VA = "0x1846D36F0")]
	public PIPOODNNAMI<T>.MOHDLDFMLJL PNMCCDOOLCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C95950", Offset = "0x3C94350", VA = "0x183C95950", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C95950", Offset = "0x3C94350", VA = "0x183C95950", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NGMPFMANAMP
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EEC0", Offset = "0x2C7D8C0", VA = "0x182C7EEC0")]
	public static PIPOODNNAMI<T> KHKANEAPNIK<T>(int BKEGNEKBPFA, Func<T> NGICOEMIGAF) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1F944A0", Offset = "0x1F92EA0", VA = "0x181F944A0")]
		public RRColor(float OFMNIPCGFAG, float DMNKJLDAGMM, float JCAJPPHEFGK, float GDMICPKKGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x699E9B0", Offset = "0x699D3B0", VA = "0x18699E9B0", Slot = "4")]
		public bool Equals(RRColor HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x699EA30", Offset = "0x699D430", VA = "0x18699EA30", Slot = "0")]
		public override bool Equals(object HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x699EB30", Offset = "0x699D530", VA = "0x18699EB30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x699EBB0", Offset = "0x699D5B0", VA = "0x18699EBB0", Slot = "5")]
		public string ToString(string PHCNDPLEFBH, IFormatProvider KBHNFPBNMLC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class BLPPAHLFEEH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct KFPIKPKMOIC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly BLPPAHLFEEH<T> PNKIPLFDMPC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T NHLIMKDHAIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x41C07F0", Offset = "0x41BF1F0", VA = "0x1841C07F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x41C07C0", Offset = "0x41BF1C0", VA = "0x1841C07C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
		public KFPIKPKMOIC(BLPPAHLFEEH<T> PNKIPLFDMPC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct HFMMGCFIEGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<KFPIKPKMOIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BLPPAHLFEEH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5930", Offset = "0x3DC4330", VA = "0x183DC5930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3830830", Offset = "0x382F230", VA = "0x183830830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly SemaphoreSlim AKLDCEOJBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T OMEKNKALOKC;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E27600", Offset = "0x4E26000", VA = "0x184E27600")]
	public BLPPAHLFEEH([In] T OMEKNKALOKC, int GLFIICGFPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E275C0", Offset = "0x4E25FC0", VA = "0x184E275C0")]
	public BLPPAHLFEEH([In] T OMEKNKALOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E26F50", Offset = "0x4E25950", VA = "0x184E26F50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E27430", Offset = "0x4E25E30", VA = "0x184E27430")]
	public KFPIKPKMOIC GPELGIFHFHB()
	{
		return default(KFPIKPKMOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4E26F90", Offset = "0x4E25990", VA = "0x184E26F90")]
	[AsyncStateMachine(typeof(BLPPAHLFEEH<>.HFMMGCFIEGM))]
	public Task<BLPPAHLFEEH<T>.KFPIKPKMOIC> EJOGKANPOJC(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E27410", Offset = "0x4E25E10", VA = "0x184E27410")]
	public void GMGDECOKIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IJPBLFIFBHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x699C810", Offset = "0x699B210", VA = "0x18699C810")]
	public static BLPPAHLFEEH<LMMCANLFCCL> KHKANEAPNIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2960650", Offset = "0x295F050", VA = "0x182960650")]
	public static BLPPAHLFEEH<T> KHKANEAPNIK<T>([In] T OMEKNKALOKC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class DPDBIPPLNFM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct FOMAHHFGLHI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly DPDBIPPLNFM<T> LNPMBFEHBIE;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T NHLIMKDHAIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3C57B10", Offset = "0x3C56510", VA = "0x183C57B10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3C577B0", Offset = "0x3C561B0", VA = "0x183C577B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
		internal FOMAHHFGLHI(DPDBIPPLNFM<T> PNKIPLFDMPC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct JIAAGPNECEN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly DPDBIPPLNFM<T> LNPMBFEHBIE;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T NHLIMKDHAIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x3C57B10", Offset = "0x3C56510", VA = "0x183C57B10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x40D5D80", Offset = "0x40D4780", VA = "0x1840D5D80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
		internal JIAAGPNECEN(DPDBIPPLNFM<T> PNKIPLFDMPC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct GJIDMNPBMHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<JIAAGPNECEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DPDBIPPLNFM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private BLPPAHLFEEH<LMMCANLFCCL>.KFPIKPKMOIC <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<BLPPAHLFEEH<LMMCANLFCCL>.KFPIKPKMOIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D32C70", Offset = "0x3D31670", VA = "0x183D32C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3830830", Offset = "0x382F230", VA = "0x183830830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BLPPAHLFEEH<int> FLEAPBFPLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly BLPPAHLFEEH<LMMCANLFCCL> PCEGPNNELJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly BLPPAHLFEEH<LMMCANLFCCL> EKADMADOFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private T DDCIALOFCJI;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x57DB570", Offset = "0x57D9F70", VA = "0x1857DB570")]
	internal DPDBIPPLNFM(BLPPAHLFEEH<int> JHMGFAJGJJI, BLPPAHLFEEH<LMMCANLFCCL> OBLJHIMKOJM, BLPPAHLFEEH<LMMCANLFCCL> INNCIFNNJCO, [In] T OMEKNKALOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x57DABE0", Offset = "0x57D95E0", VA = "0x1857DABE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x57DB170", Offset = "0x57D9B70", VA = "0x1857DB170")]
	public FOMAHHFGLHI LDGCBMDFIJC()
	{
		return default(FOMAHHFGLHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x57DADD0", Offset = "0x57D97D0", VA = "0x1857DADD0")]
	public JIAAGPNECEN EKIKMIMNEHM()
	{
		return default(JIAAGPNECEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x57DA800", Offset = "0x57D9200", VA = "0x1857DA800")]
	[AsyncStateMachine(typeof(DPDBIPPLNFM<>.GJIDMNPBMHP))]
	public Task<DPDBIPPLNFM<T>.JIAAGPNECEN> CPMONDALIMH(CancellationToken AOLOJHLCMLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class JPOOFDOIGFD
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x699DC10", Offset = "0x699C610", VA = "0x18699DC10")]
	public static DPDBIPPLNFM<LMMCANLFCCL> KHKANEAPNIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B8D9D0", Offset = "0x2B8C3D0", VA = "0x182B8D9D0")]
	public static DPDBIPPLNFM<T> KHKANEAPNIK<T>([In] T OMEKNKALOKC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class OIDANPOCPEH<TData> : DNHFHLFKGGH where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly TData MAOHOGCCNAD;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
	public override string BMFLCAMIMMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4605AC0", Offset = "0x46044C0", VA = "0x184605AC0")]
	internal OIDANPOCPEH(string BDCMABOIIFF, [In] TData EEOBDBMOHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JDILPEFNGPB
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x699D1B0", Offset = "0x699BBB0", VA = "0x18699D1B0")]
	public static OIDANPOCPEH<LMMCANLFCCL> KHKANEAPNIK(string BDCMABOIIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x28BF6B0", Offset = "0x28BE0B0", VA = "0x1828BF6B0")]
	public static OIDANPOCPEH<TData> KHKANEAPNIK<TData>(string BDCMABOIIFF, [In] TData EEOBDBMOHPL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class MNNOJABHBPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<object, float> NLHDNBOLFGK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float ODIPNLGIFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBB0", Offset = "0x8BA5B0", VA = "0x1808BBBB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F90", Offset = "0xAA0990", VA = "0x180AA1F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x699E330", Offset = "0x699CD30", VA = "0x18699E330")]
	public void LHEEOHBDCCH(float DBOBEHLEAAE, object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x699E2C0", Offset = "0x699CCC0", VA = "0x18699E2C0")]
	public void GLFBFJPCLNC(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x699E270", Offset = "0x699CC70", VA = "0x18699E270")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x699E140", Offset = "0x699CB40", VA = "0x18699E140")]
	private void CIPFOMIKEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x699E3A0", Offset = "0x699CDA0", VA = "0x18699E3A0")]
	public MNNOJABHBPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class LNIADFFBGCB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class DHKPHDHGDEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DHKPHDHGDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x57BE430", Offset = "0x57BCE30", VA = "0x1857BE430")]
		internal int AJBGPCLGLHJ(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T>? ADICIMMHNJB;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IReadOnlyCollection<T> HAIHMJIBLBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x42A1D70", Offset = "0x42A0770", VA = "0x1842A1D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AMHOEHAJGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x42A1DB0", Offset = "0x42A07B0", VA = "0x1842A1DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x857570", Offset = "0x855F70", VA = "0x180857570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x42A1E50", Offset = "0x42A0850", VA = "0x1842A1E50")]
	public bool KODKNHDNNHA(T JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x42A2010", Offset = "0x42A0A10", VA = "0x1842A2010")]
	public bool PLMGPBLKDNE(T JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x42A1E00", Offset = "0x42A0800", VA = "0x1842A1E00")]
	public bool IKNOCAOHLJM(T JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x42A2180", Offset = "0x42A0B80", VA = "0x1842A2180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public LNIADFFBGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HFDCBECCBCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly string GLBKGGHEPHP;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public HFDCBECCBCM(string GLBKGGHEPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x699C4A0", Offset = "0x699AEA0", VA = "0x18699C4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class NFLEMDIBMBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ELOOGLPBLJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public ELOOGLPBLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x699C3F0", Offset = "0x699ADF0", VA = "0x18699C3F0")]
		internal int AJBGPCLGLHJ(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private HashSet<object>? ADICIMMHNJB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyCollection<object> HAIHMJIBLBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x699E430", Offset = "0x699CE30", VA = "0x18699E430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool AMHOEHAJGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x699E4C0", Offset = "0x699CEC0", VA = "0x18699E4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x857570", Offset = "0x855F70", VA = "0x180857570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x699E530", Offset = "0x699CF30", VA = "0x18699E530")]
	public bool KODKNHDNNHA(object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x699E680", Offset = "0x699D080", VA = "0x18699E680")]
	public bool PLMGPBLKDNE(object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x699E4D0", Offset = "0x699CED0", VA = "0x18699E4D0")]
	public bool IKNOCAOHLJM(object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x699E610", Offset = "0x699D010", VA = "0x18699E610")]
	public void PIHBFPCPCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x699E720", Offset = "0x699D120", VA = "0x18699E720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public NFLEMDIBMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EBGDNFNNEHI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct CGBIGGKDCLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float KKGCHBOKDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public T NHLIMKDHAIB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Dictionary<object, CGBIGGKDCLF> NLHDNBOLFGK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public virtual T IBJKAMBPOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x10610C0", Offset = "0x105FAC0", VA = "0x1810610C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1060690", Offset = "0x105F090", VA = "0x181060690", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public object? OIGLABEHKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x850E60", Offset = "0x84F860", VA = "0x180850E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GDMEHHNGNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3830A10", Offset = "0x382F410", VA = "0x183830A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3831170", Offset = "0x382FB70", VA = "0x183831170")]
	public bool LHEEOHBDCCH(T DBOBEHLEAAE, object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3830970", Offset = "0x382F370", VA = "0x183830970")]
	public bool GLFBFJPCLNC(object JCIFCENKMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3830920", Offset = "0x382F320", VA = "0x183830920")]
	public void EIMPLACCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3832B90", Offset = "0x3831590", VA = "0x183832B90")]
	public bool NMDJKMBCDDJ(object JCIFCENKMKP, [Out] T DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3831740", Offset = "0x3830140", VA = "0x183831740")]
	[HDAIPMIDGLC("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MJNGLHKONHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3832F20", Offset = "0x3831920", VA = "0x183832F20")]
	public EBGDNFNNEHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class EKJHOALCHAB<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<WeakReference<T>>? ADICIMMHNJB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool AMHOEHAJGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3867260", Offset = "0x3865C60", VA = "0x183867260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x38670C0", Offset = "0x3865AC0", VA = "0x1838670C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3867380", Offset = "0x3865D80", VA = "0x183867380")]
	public void KODKNHDNNHA(T JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3867630", Offset = "0x3866030", VA = "0x183867630")]
	public void PLMGPBLKDNE(T JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x38675F0", Offset = "0x3865FF0", VA = "0x1838675F0")]
	public void PIHBFPCPCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x38677D0", Offset = "0x38661D0", VA = "0x1838677D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public EKJHOALCHAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class AMJGMJHNGMM
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x28C32E0", Offset = "0x28C1CE0", VA = "0x1828C32E0")]
	public static void GPAHCCJDELG<T>(this List<T> AGFBCPPODBI, int ILOCEPPJPDO) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KPJJDLENIAC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OOJBEOCHJEB MKDIFLHMLMB;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class JCGOAOCFLOH : KPJJDLENIAC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct HGOKBNDCIJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly float FNEPMCHENFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly float PFONOCNHHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		internal readonly bool JPOGMMCJBGM;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float DLJBGHKKEBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x699C4F0", Offset = "0x699AEF0", VA = "0x18699C4F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x699C670", Offset = "0x699B070", VA = "0x18699C670")]
		public HGOKBNDCIJP(float BPFHAJJBCKE, float PECJJMDPJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x699C500", Offset = "0x699AF00", VA = "0x18699C500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DFPCJADIEND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public JCGOAOCFLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DFPCJADIEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x699BA10", Offset = "0x699A410", VA = "0x18699BA10")]
		internal void OLFPCPFFDEL(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly int OLPFIFFGHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int NJLFHFJFJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly KPJJDLENIAC[] CBDIKPINEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly OOJBEOCHJEB[] GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HGOKBNDCIJP[] FCAPMADOFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HGOKBNDCIJP JCKAAKEPOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EDKILIBKIOP IHDMOICCBJO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OOJBEOCHJEB MKDIFLHMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x699CA50", Offset = "0x699B450", VA = "0x18699CA50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x699C990", Offset = "0x699B390", VA = "0x18699C990", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x699D020", Offset = "0x699BA20", VA = "0x18699D020")]
	public JCGOAOCFLOH(int OLPFIFFGHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x699CF90", Offset = "0x699B990", VA = "0x18699CF90")]
	public EDKILIBKIOP POMGCFIJDLI(HGOKBNDCIJP JNBPKGCEPEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x699CB10", Offset = "0x699B510", VA = "0x18699CB10")]
	public void JOLBAGCHKNM(KPJJDLENIAC KLLNIGCIJGL, [Optional] HGOKBNDCIJP FILGDHKPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x699C880", Offset = "0x699B280", VA = "0x18699C880", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void OOJBEOCHJEB(float FDEJJPMNJPD);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class JMAEDKHIKBK
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class LDJJCHOBNHM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly KPJJDLENIAC AKPAALHONIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly OOJBEOCHJEB BHKFHJNIBAC;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x699DD30", Offset = "0x699C730", VA = "0x18699DD30")]
		public LDJJCHOBNHM(KPJJDLENIAC AKPAALHONIA, OOJBEOCHJEB BHKFHJNIBAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x699DCE0", Offset = "0x699C6E0", VA = "0x18699DCE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x699D2F0", Offset = "0x699BCF0", VA = "0x18699D2F0")]
	internal static bool ILNGNMOMGPC(float GDMICPKKGFK, float JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x698D110", Offset = "0x698BB10", VA = "0x18698D110")]
	internal static float HJKCBAKKLIO(float GDMICPKKGFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x699D230", Offset = "0x699BC30", VA = "0x18699D230")]
	public static IDisposable APMCKAKKPIN(this KPJJDLENIAC AKPAALHONIA, OOJBEOCHJEB BHKFHJNIBAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class EDKILIBKIOP : KPJJDLENIAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private float FDEJJPMNJPD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float EGJHHCAKFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x699C300", Offset = "0x699AD00", VA = "0x18699C300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OOJBEOCHJEB? MKDIFLHMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x699C260", Offset = "0x699AC60", VA = "0x18699C260", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x699C1C0", Offset = "0x699ABC0", VA = "0x18699C1C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public EDKILIBKIOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class AHABCJJLFOL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x641D600", Offset = "0x641C000", VA = "0x18641D600")]
	public AHABCJJLFOL(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class DEDFAAABJKP<TKey, TValue> : EGAINBPEJAM<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, LHCBOMJMOAG where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class HDPOAKGBGCI : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DEDFAAABJKP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x10610C0", Offset = "0x105FAC0", VA = "0x1810610C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3DB0FA0", Offset = "0x3DAF9A0", VA = "0x183DB0FA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
		[DebuggerHidden]
		public HDPOAKGBGCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3A76570", Offset = "0x3A74F70", VA = "0x183A76570", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3DB05D0", Offset = "0x3DAEFD0", VA = "0x183DB05D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3DB00D0", Offset = "0x3DAEAD0", VA = "0x183DB00D0")]
		private void KBJJHHPKCPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3DAFFE0", Offset = "0x3DAE9E0", VA = "0x183DAFFE0")]
		private void FLCLOIILAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0F00", Offset = "0x3DAF900", VA = "0x183DB0F00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly EGAINBPEJAM<TKey, TValue> OBEICKIOHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IDictionary<TKey, TValue> NFLNENCFMKC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5769CD0", Offset = "0x57686D0", VA = "0x185769CD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool DODHMAHIADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5769F40", Offset = "0x5768940", VA = "0x185769F40", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x576A210", Offset = "0x5768C10", VA = "0x18576A210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> JDHEAGIPOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5769FD0", Offset = "0x57689D0", VA = "0x185769FD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> CJDGMCBMBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x576A0F0", Offset = "0x5768AF0", VA = "0x18576A0F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5769C10", Offset = "0x5768610", VA = "0x185769C10")]
	public DEDFAAABJKP(EGAINBPEJAM<TKey, TValue> OBEICKIOHEN, [Optional] IDictionary<TKey, TValue>? NFLNENCFMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5767790", Offset = "0x5766190", VA = "0x185767790", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5768650", Offset = "0x5767050", VA = "0x185768650")]
	public void MFBGDMIDHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5766FA0", Offset = "0x57659A0", VA = "0x185766FA0", Slot = "9")]
	public void Add(TKey LDDEKIBHION, TValue DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5767530", Offset = "0x5765F30", VA = "0x185767530")]
	public void CMNIAGICDCH(TKey LDDEKIBHION, TValue DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x57683F0", Offset = "0x5766DF0", VA = "0x1857683F0")]
	public void HHFOAIHDNPG(TKey LDDEKIBHION, TValue DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x57687D0", Offset = "0x57671D0", VA = "0x1857687D0")]
	public void NKDJEAJNODK(TKey LDDEKIBHION, TValue DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5768F00", Offset = "0x5767900", VA = "0x185768F00")]
	public void PJEIDFAONBN(TKey LDDEKIBHION, TValue DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5769290", Offset = "0x5767C90", VA = "0x185769290", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5769480", Offset = "0x5767E80", VA = "0x185769480", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x57697E0", Offset = "0x57681E0", VA = "0x1857697E0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x57678D0", Offset = "0x57662D0", VA = "0x1857678D0", Slot = "8")]
	public bool ContainsKey(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x57681D0", Offset = "0x5766BD0", VA = "0x1857681D0")]
	public bool GJLPEMKAIFF(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x57680B0", Offset = "0x5766AB0", VA = "0x1857680B0")]
	public bool FLHJJJFCILB(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5768FF0", Offset = "0x57679F0", VA = "0x185768FF0", Slot = "10")]
	public bool Remove(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x57699A0", Offset = "0x57683A0", VA = "0x1857699A0", Slot = "11")]
	public bool TryGetValue(TKey LDDEKIBHION, [Out] TValue DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5767BD0", Offset = "0x57665D0", VA = "0x185767BD0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] MHMBNFEOIBK, int KJCAHDMHMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x418A260", Offset = "0x4188C60", VA = "0x18418A260", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5768290", Offset = "0x5766C90", VA = "0x185768290", Slot = "19")]
	[IteratorStateMachine(typeof(DEDFAAABJKP<, >.HDPOAKGBGCI))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5767490", Offset = "0x5765E90", VA = "0x185767490", Slot = "21")]
	public bool BBJCOFIDMAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5768D10", Offset = "0x5767710", VA = "0x185768D10")]
	private TValue PINDLGBBPBC(TKey LDDEKIBHION)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface LHCBOMJMOAG
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BBJCOFIDMAE();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EGAINBPEJAM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LHCBOMJMOAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DefaultMember("Item")]
public sealed class CODGJNGJIAK<TKey, TVal> : EGAINBPEJAM<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LHCBOMJMOAG where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public delegate int JJKKJLBOIBC(TKey LDDEKIBHION, TVal DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public delegate void APNCHEFCAJE(TKey LDDEKIBHION, TVal DBOBEHLEAAE, GOFBCHMFFEI GDIKEMIFDHP);

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BNOJCHIKHOM
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8C0BB0", Offset = "0x8BF5B0", VA = "0x1808C0BB0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal NHLIMKDHAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8BA990", Offset = "0x8B9390", VA = "0x1808BA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int DLJBGHKKEBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x88BD30", Offset = "0x88A730", VA = "0x18088BD30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x88B180", Offset = "0x889B80", VA = "0x18088B180")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset LPFLHPNJLKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xC2A070", Offset = "0xC28A70", VA = "0x180C2A070")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x14EA2F0", Offset = "0x14E8CF0", VA = "0x1814EA2F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4E2C280", Offset = "0x4E2AC80", VA = "0x184E2C280")]
		public BNOJCHIKHOM(TKey LDDEKIBHION, TVal EHIEOLDDJEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class AABNPCOLMOE : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CODGJNGJIAK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private LinkedList<BNOJCHIKHOM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x10610C0", Offset = "0x105FAC0", VA = "0x1810610C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3A79920", Offset = "0x3A78320", VA = "0x183A79920", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
		[DebuggerHidden]
		public AABNPCOLMOE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3A71070", Offset = "0x3A6FA70", VA = "0x183A71070", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F5B0", Offset = "0x3C9DFB0", VA = "0x183C9F5B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E7C0", Offset = "0x3C9D1C0", VA = "0x183C9E7C0")]
		private void KBJJHHPKCPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3CA12A0", Offset = "0x3C9FCA0", VA = "0x183CA12A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const int JLLJDPCELFN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly Dictionary<TKey, LinkedListNode<BNOJCHIKHOM>> CLIJEEFBEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly LinkedList<BNOJCHIKHOM> LHBMPFMFBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly JJKKJLBOIBC? ADGLPPPDIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly TimeSpan MFNDBJIFDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly APNCHEFCAJE? PMLPBPBHEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly MOEMAIEFBPA CLMBHJMFNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool NFOCPCBBPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<TKey> AFEPDNFBOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly List<TVal> LNDJENFENNA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JNJKJLALEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85C460", Offset = "0x85AE60", VA = "0x18085C460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int PLLNPNDOIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xAF4E10", Offset = "0xAF3810", VA = "0x180AF4E10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xAF4940", Offset = "0xAF3340", VA = "0x180AF4940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x526CB80", Offset = "0x526B580", VA = "0x18526CB80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int EBGKPFIHEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3830920", Offset = "0x382F320", VA = "0x183830920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> CJDGMCBMBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x526CD00", Offset = "0x526B700", VA = "0x18526CD00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.NCKJCAEGBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5268EC0", Offset = "0x52678C0", VA = "0x185268EC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool DODHMAHIADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x526CC50", Offset = "0x526B650", VA = "0x18526CC50", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x526CDB0", Offset = "0x526B7B0", VA = "0x18526CDB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x525A030", Offset = "0x5258A30", VA = "0x18525A030")]
	private bool BEMIGPOLOOG(int OLPFIFFGHOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x525D8F0", Offset = "0x525C2F0", VA = "0x18525D8F0")]
	private void CEJFDMALEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x526AB20", Offset = "0x5269520", VA = "0x18526AB20")]
	public CODGJNGJIAK(int OLPFIFFGHOM, [Optional] JJKKJLBOIBC? ADGLPPPDIGJ, [Optional] IEqualityComparer<TKey>? CELMPCDCIGH, [Optional] APNCHEFCAJE? PMLPBPBHEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x526A030", Offset = "0x5268A30", VA = "0x18526A030")]
	public CODGJNGJIAK(TimeSpan MFNDBJIFDNP, [Optional] IEqualityComparer<TKey>? CELMPCDCIGH, [Optional] APNCHEFCAJE? PMLPBPBHEBP, [Optional] MOEMAIEFBPA? CLMBHJMFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5269FB0", Offset = "0x52689B0", VA = "0x185269FB0")]
	public CODGJNGJIAK(int OLPFIFFGHOM, TimeSpan MFNDBJIFDNP, [Optional] IEqualityComparer<TKey>? CELMPCDCIGH, [Optional] APNCHEFCAJE? PMLPBPBHEBP, [Optional] MOEMAIEFBPA? CLMBHJMFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x526C020", Offset = "0x526AA20", VA = "0x18526C020")]
	public CODGJNGJIAK(int OLPFIFFGHOM, JJKKJLBOIBC? ADGLPPPDIGJ, TimeSpan MFNDBJIFDNP, [Optional] IEqualityComparer<TKey>? CELMPCDCIGH, [Optional] APNCHEFCAJE? PMLPBPBHEBP, [Optional] MOEMAIEFBPA? CLMBHJMFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5259F90", Offset = "0x5258990", VA = "0x185259F90", Slot = "21")]
	public bool BBJCOFIDMAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5258BB0", Offset = "0x52575B0", VA = "0x185258BB0", Slot = "22")]
	public bool ANCIGNLCJNE(int BKEGNEKBPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x525E9A0", Offset = "0x525D3A0", VA = "0x18525E9A0")]
	private bool CKCGNOJNIBG(int BKEGNEKBPFA, GOFBCHMFFEI GDIKEMIFDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x525A1B0", Offset = "0x5258BB0", VA = "0x18525A1B0")]
	public void BJDAAADFLKD(TKey LDDEKIBHION, TVal DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5259730", Offset = "0x5258130", VA = "0x185259730", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IMMLPPOHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x52599D0", Offset = "0x52583D0", VA = "0x1852599D0", Slot = "9")]
	public void Add(TKey LDDEKIBHION, TVal DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x52614D0", Offset = "0x525FED0", VA = "0x1852614D0", Slot = "8")]
	public bool ContainsKey(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5268720", Offset = "0x5267120", VA = "0x185268720", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x52681A0", Offset = "0x5266BA0", VA = "0x1852681A0", Slot = "10")]
	public bool Remove(TKey LDDEKIBHION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5268900", Offset = "0x5267300", VA = "0x185268900", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> IMMLPPOHEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5264F80", Offset = "0x5263980", VA = "0x185264F80")]
	private bool GPJPHJANEMD(TKey LDDEKIBHION, [Out] TVal DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x52587F0", Offset = "0x52571F0", VA = "0x1852587F0")]
	private TVal AMGKFNFCLFC(TKey KEFBHDJBMMG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5269950", Offset = "0x5268350", VA = "0x185269950", Slot = "11")]
	public bool TryGetValue(TKey KEFBHDJBMMG, [Out] TVal DBOBEHLEAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x52612A0", Offset = "0x525FCA0", VA = "0x1852612A0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5262360", Offset = "0x5260D60", VA = "0x185262360", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] MHMBNFEOIBK, int KJCAHDMHMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5265600", Offset = "0x5264000", VA = "0x185265600")]
	private void HMDDLOIPEEA(TKey LDDEKIBHION, TVal EHIEOLDDJEB, GOFBCHMFFEI GDIKEMIFDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5263F70", Offset = "0x5262970", VA = "0x185263F70")]
	private bool EHJKJJJOPEL(BNOJCHIKHOM KLIFNEOOIHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x525CDD0", Offset = "0x525B7D0", VA = "0x18525CDD0")]
	private void CAKCKAOJKPM(LinkedListNode<BNOJCHIKHOM> AGMLHKMDAPO, TVal JHNCHHHEDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5265FC0", Offset = "0x52649C0", VA = "0x185265FC0")]
	private void LHEEOHBDCCH(TKey LDDEKIBHION, TVal DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x52570E0", Offset = "0x5255AE0", VA = "0x1852570E0")]
	private void AHAIDGFOGDH(BNOJCHIKHOM KLIFNEOOIHH, TVal JHNCHHHEDDG, int JOAMDNFKLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5265220", Offset = "0x5263C20", VA = "0x185265220", Slot = "19")]
	[IteratorStateMachine(typeof(CODGJNGJIAK<, >.AABNPCOLMOE))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5268F10", Offset = "0x5267910", VA = "0x185268F10", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum GOFBCHMFFEI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class NKKBLOLPBOC<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly TKey GHANEIHHGJO;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x44E5900", Offset = "0x44E4300", VA = "0x1844E5900")]
	public NKKBLOLPBOC(TKey PADMIPKPOJN, Exception GOOPONCNKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CBCJFNACEPP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC2F0", Offset = "0x5CEACF0", VA = "0x185CEC2F0")]
	public CBCJFNACEPP(string BDCMABOIIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class JHFAOJJKCFJ<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class JFOJPMNGGMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JHFAOJJKCFJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public JFOJPMNGGMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x405D210", Offset = "0x405BC10", VA = "0x18405D210")]
		internal Task<TResource> KGGIJBFAINJ(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct ONCDKBFJGDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public JHFAOJJKCFJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x46220C0", Offset = "0x4620AC0", VA = "0x1846220C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4622D60", Offset = "0x4621760", VA = "0x184622D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct PEJBLKLGICG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x46C1290", Offset = "0x46BFC90", VA = "0x1846C1290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x46C1F70", Offset = "0x46C0970", VA = "0x1846C1F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly AJLOMKOCDIG<TId, Task<TResource>> FOJNBGHCOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> KHIHDEIGNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? LPAIIMFHKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Action<TResource>? FIOGHINNBOG;

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x40D5420", Offset = "0x40D3E20", VA = "0x1840D5420")]
	public JHFAOJJKCFJ(int KPGKJLKABIL = 0, [Optional] IEqualityComparer<TId>? DMCONHAKIFD, [Optional] Func<TId, CancellationToken, Task<TResource>>? CHBKHALOMNF, [Optional] Action<TResource>? NHFONFNIEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x40D4D20", Offset = "0x40D3720", VA = "0x1840D4D20")]
	public MAGIJMJBHDB<Task<TResource>> PLLMHPCNJKD(TId OBDGAAHPMCD, [Optional] Func<TId, CancellationToken, Task<TResource>>? CHBKHALOMNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x40D44F0", Offset = "0x40D2EF0", VA = "0x1840D44F0")]
	private void OLNEJMGCPEH(Task<TResource> JCINMAJOONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x40D3BD0", Offset = "0x40D25D0", VA = "0x1840D3BD0")]
	[AsyncStateMachine(typeof(JHFAOJJKCFJ<, >.ONCDKBFJGDF))]
	private Task BHOKIOJBGGI(Task<TResource> JCINMAJOONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x40D4490", Offset = "0x40D2E90", VA = "0x1840D4490")]
	public void KEMJONDPFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x40D51E0", Offset = "0x40D3BE0", VA = "0x1840D51E0")]
	public AJLOMKOCDIG<TId, Task<TResource>>.KNIBDJNPBKG PNMCCDOOLCI()
	{
		return default(AJLOMKOCDIG<TId, Task<TResource>>.KNIBDJNPBKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x40D5250", Offset = "0x40D3C50", VA = "0x1840D5250", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x40D5250", Offset = "0x40D3C50", VA = "0x1840D5250", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x40D4360", Offset = "0x40D2D60", VA = "0x1840D4360")]
	[AsyncStateMachine(typeof(JHFAOJJKCFJ<, >.PEJBLKLGICG))]
	[CompilerGenerated]
	internal static Task HJMJAIJDKOB(Task<TResource> JCINMAJOONI, CancellationTokenSource KOEDCJNDIIF, Dictionary<Task<TResource>, CancellationTokenSource> GFOIDJGCFBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class AJLOMKOCDIG<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private sealed class PFHMFDJFLMO : IEquatable<PFHMFDJFLMO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly TValue NHLIMKDHAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int EKGIAJPFBIL;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x94A9D0", Offset = "0x9493D0", VA = "0x18094A9D0")]
		public PFHMFDJFLMO(TValue DBOBEHLEAAE, int MMPFKEAIBHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x46C6DC0", Offset = "0x46C57C0", VA = "0x1846C6DC0", Slot = "4")]
		public bool Equals(PFHMFDJFLMO? HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x46C6D20", Offset = "0x46C5720", VA = "0x1846C6D20", Slot = "0")]
		public override bool Equals(object? GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x46C7000", Offset = "0x46C5A00", VA = "0x1846C7000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct KNIBDJNPBKG : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private Dictionary<TKey, PFHMFDJFLMO>.Enumerator OIOOPKPNJFK;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x41F2560", Offset = "0x41F0F60", VA = "0x1841F2560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x41F2BD0", Offset = "0x41F15D0", VA = "0x1841F2BD0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x41F2750", Offset = "0x41F1150", VA = "0x1841F2750")]
		public KNIBDJNPBKG(AJLOMKOCDIG<TKey, TValue> NLHDNBOLFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x41F21C0", Offset = "0x41F0BC0", VA = "0x1841F21C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x41F2280", Offset = "0x41F0C80", VA = "0x1841F2280", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x41F2370", Offset = "0x41F0D70", VA = "0x1841F2370", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class BMFNNDMLGKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AJLOMKOCDIG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public PFHMFDJFLMO refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public BMFNNDMLGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4E281F0", Offset = "0x4E26BF0", VA = "0x184E281F0")]
		internal void KGGIJBFAINJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Dictionary<TKey, PFHMFDJFLMO> CGKBDEIOKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Func<TKey, TValue>? CCDNMDGKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Action<TValue>? JOFHFHKMONP;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D00960", Offset = "0x3CFF360", VA = "0x183D00960")]
	public AJLOMKOCDIG(int KPGKJLKABIL = 0, [Optional] IEqualityComparer<TKey>? CELMPCDCIGH, [Optional] Func<TKey, TValue>? COKHHIDNHIF, [Optional] Action<TValue>? NFKMHABKHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D00080", Offset = "0x3CFEA80", VA = "0x183D00080")]
	public MAGIJMJBHDB<TValue> PLLMHPCNJKD(TKey LDDEKIBHION, [Optional] Func<TKey, TValue>? EJEGFOCMHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF1F0", Offset = "0x3CFDBF0", VA = "0x183CFF1F0")]
	private void IPJKJLPDPPI(TKey LDDEKIBHION, PFHMFDJFLMO NDDIEMKAHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF440", Offset = "0x3CFDE40", VA = "0x183CFF440")]
	public void KEMJONDPFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D006D0", Offset = "0x3CFF0D0", VA = "0x183D006D0")]
	public KNIBDJNPBKG PNMCCDOOLCI()
	{
		return default(KNIBDJNPBKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D00830", Offset = "0x3CFF230", VA = "0x183D00830", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D00830", Offset = "0x3CFF230", VA = "0x183D00830", Slot = "5")]
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
