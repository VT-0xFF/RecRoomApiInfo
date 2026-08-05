using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

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
		[Cpp2IlInjected.Address(RVA = "0x6F6A560", Offset = "0x6F68B60", VA = "0x186F6A560")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
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
public abstract class MOAOPBJFOJC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	protected MOAOPBJFOJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KMBDNOBMODH<T> : MOAOPBJFOJC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct BHNJFKJHEAD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum GOMOAPHCBIO
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
		public GOMOAPHCBIO KLGGKKGCLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ILLCNPCAHGD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int HAFNGGNPAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool EBEHHNMMCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool PNBJBMPNHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CD980", Offset = "0x6CCD80")]
	protected List<T> BCIBHBAFMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CD9E0", Offset = "0x6CCDE0")]
	private List<BHNJFKJHEAD> NGBIBIMEBJN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool AONGCONJBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2663E00", Offset = "0x2662400", VA = "0x182663E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26640B0", Offset = "0x26626B0", VA = "0x1826640B0")]
	protected KMBDNOBMODH(bool PNBJBMPNHIM, bool EBEHHNMMCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2663B70", Offset = "0x2662170", VA = "0x182663B70")]
	protected bool COEJDKPEMEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2663BF0", Offset = "0x26621F0", VA = "0x182663BF0")]
	protected void DMGHNIJCFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x26639C0", Offset = "0x2661FC0", VA = "0x1826639C0")]
	protected void CJILGGKAKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1CB6D30", Offset = "0x1CB5330", VA = "0x181CB6D30")]
	private static void KFAGBJPKDDI<U>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDA40", Offset = "0x6CCE40")] ref List<U?>? CKIKFMIOAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2663F50", Offset = "0x2662550", VA = "0x182663F50", Slot = "4")]
	public void PDDBDHJNBOH(T ILLCNPCAHGD, bool OHCJEONKCBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2663CB0", Offset = "0x26622B0", VA = "0x182663CB0", Slot = "5")]
	public void EIILGGCBFDG(T ILLCNPCAHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2663E40", Offset = "0x2662440", VA = "0x182663E40")]
	public void FBJOPIHCMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FKJJHIFKALK
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDDBDHJNBOH(Action ILLCNPCAHGD, bool OHCJEONKCBG = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIILGGCBFDG(Action ILLCNPCAHGD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDAC0", Offset = "0x6CCEC0")]
public sealed class IOAJAPLOKEP : KMBDNOBMODH<Action>, FKJJHIFKALK
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A130", Offset = "0x6F68730", VA = "0x186F6A130")]
	public IOAJAPLOKEP(bool PNBJBMPNHIM = false, bool EBEHHNMMCCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F69EC0", Offset = "0x6F684C0", VA = "0x186F69EC0")]
	public void JLDGENJLEHM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F69E60", Offset = "0x6F68460", VA = "0x186F69E60")]
	public static IOAJAPLOKEP DEHKCACAKPN(IOAJAPLOKEP IPCFPFAKAPO, Action ILLCNPCAHGD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A0D0", Offset = "0x6F686D0", VA = "0x186F6A0D0")]
	public static IOAJAPLOKEP LHOAPOJEHOD(IOAJAPLOKEP IPCFPFAKAPO, Action ILLCNPCAHGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IPCAFGHHDKN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDDBDHJNBOH(Action<T> ILLCNPCAHGD, bool OHCJEONKCBG = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIILGGCBFDG(Action<T> ILLCNPCAHGD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDB30", Offset = "0x6CCF30")]
public sealed class AFANAFKFEIG<T> : KMBDNOBMODH<Action<T>>, IPCAFGHHDKN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x17A5130", Offset = "0x17A3730", VA = "0x1817A5130")]
	public AFANAFKFEIG(bool PNBJBMPNHIM = false, bool EBEHHNMMCCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x29D89D0", Offset = "0x29D6FD0", VA = "0x1829D89D0")]
	public void JLDGENJLEHM(T KAIHGPIIHIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E65D20", Offset = "0x1E64320", VA = "0x181E65D20")]
	public static AFANAFKFEIG<T> DEHKCACAKPN(AFANAFKFEIG<T> IPCFPFAKAPO, Action<T> ILLCNPCAHGD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E67F10", Offset = "0x1E66510", VA = "0x181E67F10")]
	public static AFANAFKFEIG<T> LHOAPOJEHOD(AFANAFKFEIG<T> IPCFPFAKAPO, Action<T> ILLCNPCAHGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DIPAONPIGHI<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDBA0", Offset = "0x6CCFA0")]
public sealed class MAOADMCMPGC<T, U> : KMBDNOBMODH<Action<T, U>>, DIPAONPIGHI<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x17A5130", Offset = "0x17A3730", VA = "0x1817A5130")]
	public MAOADMCMPGC(bool PNBJBMPNHIM = false, bool EBEHHNMMCCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x378FA50", Offset = "0x378E050", VA = "0x18378FA50")]
	public void JLDGENJLEHM(T KAIHGPIIHIB, U CMMPCJPBGDK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1E65D20", Offset = "0x1E64320", VA = "0x181E65D20")]
	public static MAOADMCMPGC<T, U> DEHKCACAKPN(MAOADMCMPGC<T, U> IPCFPFAKAPO, Action<T, U> ILLCNPCAHGD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1E67F10", Offset = "0x1E66510", VA = "0x181E67F10")]
	public static MAOADMCMPGC<T, U> LHOAPOJEHOD(MAOADMCMPGC<T, U> IPCFPFAKAPO, Action<T, U> ILLCNPCAHGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDC10", Offset = "0x6CD010")]
public sealed class BMDPADGKOAA<T, U, V> : KMBDNOBMODH<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x17A5130", Offset = "0x17A3730", VA = "0x1817A5130")]
	public BMDPADGKOAA(bool PNBJBMPNHIM = false, bool EBEHHNMMCCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1E66300", Offset = "0x1E64900", VA = "0x181E66300")]
	public void JLDGENJLEHM(T KAIHGPIIHIB, U CMMPCJPBGDK, V EMGLKKBADKE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E65D20", Offset = "0x1E64320", VA = "0x181E65D20")]
	public static BMDPADGKOAA<T, U, V> DEHKCACAKPN(BMDPADGKOAA<T, U, V> IPCFPFAKAPO, Action<T, U, V> ILLCNPCAHGD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E67F10", Offset = "0x1E66510", VA = "0x181E67F10")]
	public static BMDPADGKOAA<T, U, V> LHOAPOJEHOD(BMDPADGKOAA<T, U, V> IPCFPFAKAPO, Action<T, U, V> ILLCNPCAHGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BOFALDMBPJB<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDC80", Offset = "0x6CD080")]
public sealed class AEBDKHPGBEA<T, U, V, W> : KMBDNOBMODH<Action<T, U, V, W>>, BOFALDMBPJB<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x17A5130", Offset = "0x17A3730", VA = "0x1817A5130")]
	public AEBDKHPGBEA(bool PNBJBMPNHIM = false, bool EBEHHNMMCCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29D1640", Offset = "0x29CFC40", VA = "0x1829D1640")]
	public void JLDGENJLEHM(T KAIHGPIIHIB, U CMMPCJPBGDK, V EMGLKKBADKE, W JNNIOKBNJHE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E65D20", Offset = "0x1E64320", VA = "0x181E65D20")]
	public static AEBDKHPGBEA<T, U, V, W> DEHKCACAKPN(AEBDKHPGBEA<T, U, V, W> IPCFPFAKAPO, Action<T, U, V, W> ILLCNPCAHGD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E67F10", Offset = "0x1E66510", VA = "0x181E67F10")]
	public static AEBDKHPGBEA<T, U, V, W> LHOAPOJEHOD(AEBDKHPGBEA<T, U, V, W> IPCFPFAKAPO, Action<T, U, V, W> ILLCNPCAHGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDCF0", Offset = "0x6CD0F0")]
public sealed class GMNPJAAELPB<T, U, V, W, X> : KMBDNOBMODH<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x17A5130", Offset = "0x17A3730", VA = "0x1817A5130")]
	public GMNPJAAELPB(bool PNBJBMPNHIM = false, bool EBEHHNMMCCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x33C5F80", Offset = "0x33C4580", VA = "0x1833C5F80")]
	public void JLDGENJLEHM(T KAIHGPIIHIB, U CMMPCJPBGDK, V EMGLKKBADKE, W JNNIOKBNJHE, X HEICJNINGBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E65D20", Offset = "0x1E64320", VA = "0x181E65D20")]
	public static GMNPJAAELPB<T, U, V, W, X> DEHKCACAKPN(GMNPJAAELPB<T, U, V, W, X> IPCFPFAKAPO, Action<T, U, V, W, X> ILLCNPCAHGD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E67F10", Offset = "0x1E66510", VA = "0x181E67F10")]
	public static GMNPJAAELPB<T, U, V, W, X> LHOAPOJEHOD(GMNPJAAELPB<T, U, V, W, X> IPCFPFAKAPO, Action<T, U, V, W, X> ILLCNPCAHGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDD60", Offset = "0x6CD160")]
public sealed class KFHBJKBOAGC<T, U, V, W, X, Y> : KMBDNOBMODH<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x17A5130", Offset = "0x17A3730", VA = "0x1817A5130")]
	public KFHBJKBOAGC(bool PNBJBMPNHIM = false, bool EBEHHNMMCCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2655810", Offset = "0x2653E10", VA = "0x182655810")]
	public void JLDGENJLEHM(T KAIHGPIIHIB, U CMMPCJPBGDK, V EMGLKKBADKE, W JNNIOKBNJHE, X HEICJNINGBE, Y DNLDNFFNIEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E65D20", Offset = "0x1E64320", VA = "0x181E65D20")]
	public static KFHBJKBOAGC<T, U, V, W, X, Y> DEHKCACAKPN(KFHBJKBOAGC<T, U, V, W, X, Y> IPCFPFAKAPO, Action<T, U, V, W, X, Y> ILLCNPCAHGD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E67F10", Offset = "0x1E66510", VA = "0x181E67F10")]
	public static KFHBJKBOAGC<T, U, V, W, X, Y> LHOAPOJEHOD(KFHBJKBOAGC<T, U, V, W, X, Y> IPCFPFAKAPO, Action<T, U, V, W, X, Y> ILLCNPCAHGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class BNAKFCOEFAL : BONKIFBLCIE
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static bool FLPIBAIFHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly string? GPIMLIJNDLD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public virtual BONKIFBLCIE? NJAAIEMLDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B40", Offset = "0x7F3140", VA = "0x1807F4B40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F67F80", Offset = "0x6F66580", VA = "0x186F67F80")]
	protected BNAKFCOEFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KDCKINHCHKH();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F67DE0", Offset = "0x6F663E0", VA = "0x186F67DE0", Slot = "8")]
	public virtual string LMOENAAFFDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F67B50", Offset = "0x6F66150", VA = "0x186F67B50", Slot = "9")]
	public void LMINAPEEEFL(StringBuilder NAOMIEJBPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F67A50", Offset = "0x6F66050", VA = "0x186F67A50", Slot = "10")]
	public void BDDAGGILLLK(StringBuilder NAOMIEJBPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F67E60", Offset = "0x6F66460", VA = "0x186F67E60", Slot = "11")]
	public void MGNOKDOPPCA(StringBuilder NAOMIEJBPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F678F0", Offset = "0x6F65EF0", VA = "0x186F678F0", Slot = "12")]
	public void BCEIKCENBBA(StringBuilder NAOMIEJBPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F67AB0", Offset = "0x6F660B0", VA = "0x186F67AB0")]
	public static void EAHILGHPJOC(StringBuilder NAOMIEJBPOI, string BHLGPCEAOGF, string JACHKOLPCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1819080", Offset = "0x1817680", VA = "0x181819080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GEPKMIJBOIJ<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KPONBJKAGAP<TKey, TVal> PJGDHCJKJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDE70", Offset = "0x6CD270")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BFDCJCKAIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly int GDFOEOOGDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDF40", Offset = "0x6CD340")]
	private readonly KPONBJKAGAP<TKey, TVal>.HHGOLBOJNJN EJNKNJABOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int GHBFKPMHMCD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal int ACJHIDHMEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x24DF300", Offset = "0x24DD900", VA = "0x1824DF300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MJANMLEEEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x90DC40", Offset = "0x90C240", VA = "0x18090DC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x24DF980", Offset = "0x24DDF80", VA = "0x1824DF980")]
	public GEPKMIJBOIJ(int GDFOEOOGDAN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CDFA0", Offset = "0x6CD3A0")] KPONBJKAGAP<TKey, TVal>.HHGOLBOJNJN EJNKNJABOKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE000", Offset = "0x6CD400")] IEqualityComparer<TKey> FODJEGHNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x24DF340", Offset = "0x24DD940", VA = "0x1824DF340")]
	public void DDLOGCPPHDN(TKey BOMEFJIOGGM, TVal MOLEJFDINLH, bool NAHPOFCBPBG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x24DF4B0", Offset = "0x24DDAB0", VA = "0x1824DF4B0")]
	public bool DPCBLMDHOGB(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24DF8D0", Offset = "0x24DDED0", VA = "0x1824DF8D0")]
	public bool PFDPJLFFHJD(TKey LKAJHHPOHHJ, out TVal MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24DF700", Offset = "0x24DDD00", VA = "0x1824DF700")]
	private void NKGAILGKPKJ(TKey BOMEFJIOGGM, TVal MOLEJFDINLH, int OCMPILAHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24DF5D0", Offset = "0x24DDBD0", VA = "0x1824DF5D0")]
	public bool LMFBIEOKDJP(TKey BOMEFJIOGGM, TVal MOLEJFDINLH, bool NAHPOFCBPBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24DF530", Offset = "0x24DDB30", VA = "0x1824DF530")]
	private bool HEILEFJICNK(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LDOCHAJHJNJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A200", Offset = "0x6F68800", VA = "0x186F6A200")]
	public LDOCHAJHJNJ(string DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AHAJHFJCNJJ<TErr> : LDOCHAJHJNJ where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly TErr MACFCMNFDHO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29E2FA0", Offset = "0x29E15A0", VA = "0x1829E2FA0")]
	private AHAJHFJCNJJ(in TErr BGJEGOFMIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29E2ED0", Offset = "0x29E14D0", VA = "0x1829E2ED0")]
	public static AHAJHFJCNJJ<TErr> OGNDBCBGIDA(in TErr BGJEGOFMIBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public sealed class KPONBJKAGAP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int HHGOLBOJNJN(TKey BOMEFJIOGGM, TVal MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class OEOMOFPDPHE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TKey GGPPGDHBOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x90BEC0", Offset = "0x90A4C0", VA = "0x18090BEC0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TVal INKIKMDHKDA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int JLLEAFLJKMH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xBE6A50", Offset = "0xBE5050", VA = "0x180BE6A50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xBE6A70", Offset = "0xBE5070", VA = "0x180BE6A70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DateTime GNDEOOLKODA
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xC32B90", Offset = "0xC31190", VA = "0x180C32B90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2F28730", Offset = "0x2F26D30", VA = "0x182F28730")]
		public OEOMOFPDPHE(TKey BOMEFJIOGGM, TVal PMMAPONKBCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JCLHCALIIKH : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE6D0", Offset = "0x6CDAD0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public KPONBJKAGAP<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE730", Offset = "0x6CDB30")]
		private LinkedList<KPONBJKAGAP<TKey, TVal>.OEOMOFPDPHE>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private OEOMOFPDPHE <cacheEntry>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x12EEA80", Offset = "0x12ED080", VA = "0x1812EEA80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x242C970", Offset = "0x242AF70", VA = "0x18242C970", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x19A28C0", Offset = "0x19A0EC0", VA = "0x1819A28C0")]
		[DebuggerHidden]
		public JCLHCALIIKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x218B440", Offset = "0x2189A40", VA = "0x18218B440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x242BF00", Offset = "0x242A500", VA = "0x18242BF00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x242B8B0", Offset = "0x2429EB0", VA = "0x18242B8B0")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x242C8F0", Offset = "0x242AEF0", VA = "0x18242C8F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const int MMELNENOELI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE0C0", Offset = "0x6CD4C0")]
	private readonly Dictionary<TKey, LinkedListNode<KPONBJKAGAP<TKey, TVal>.OEOMOFPDPHE>> EGOPBPODOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE120", Offset = "0x6CD520")]
	private readonly LinkedList<KPONBJKAGAP<TKey, TVal>.OEOMOFPDPHE> DGGLHHMFJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE180", Offset = "0x6CD580")]
	private readonly KPONBJKAGAP<TKey, TVal>.HHGOLBOJNJN EJNKNJABOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly TimeSpan JBDFINKEBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly EFBDGHEJBKN IFGDDFMGOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private bool LHNDABLLMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly List<TKey> DPOIJFPNJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly List<TVal> KLFFGGIBDCB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MJANMLEEEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99CE90", Offset = "0x99B490", VA = "0x18099CE90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal int ACJHIDHMEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C20", Offset = "0x9A8220", VA = "0x1809A9C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C10", Offset = "0x9A8210", VA = "0x1809A9C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x21B1AF0", Offset = "0x21B00F0", VA = "0x1821B1AF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ICollection<TVal> DFPIHABKBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x354E470", Offset = "0x354CA70", VA = "0x18354E470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ICollection<TKey> IDictionary<TKey, TVal>.FFGBGKIEHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x354C770", Offset = "0x354AD70", VA = "0x18354C770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool MIKIMACELCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x354E430", Offset = "0x354CA30", VA = "0x18354E430", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x354E4E0", Offset = "0x354CAE0", VA = "0x18354E4E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3547FB0", Offset = "0x35465B0", VA = "0x183547FB0")]
	private bool CLIONLBOBEG(int LEFNHMBHKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3549F50", Offset = "0x3548550", VA = "0x183549F50")]
	private void HJEJOOLEPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x354E190", Offset = "0x354C790", VA = "0x18354E190")]
	public KPONBJKAGAP(int LEFNHMBHKEC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE1E0", Offset = "0x6CD5E0")] KPONBJKAGAP<TKey, TVal>.HHGOLBOJNJN EJNKNJABOKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE240", Offset = "0x6CD640")] IEqualityComparer<TKey> FODJEGHNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x354CE00", Offset = "0x354B400", VA = "0x18354CE00")]
	public KPONBJKAGAP(int LEFNHMBHKEC, TimeSpan JBDFINKEBMI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE2A0", Offset = "0x6CD6A0")] IEqualityComparer<TKey?>? FODJEGHNNLJ, [Optional] EFBDGHEJBKN? IFGDDFMGOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x354D2D0", Offset = "0x354B8D0", VA = "0x18354D2D0")]
	public KPONBJKAGAP(int LEFNHMBHKEC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE300", Offset = "0x6CD700")] KPONBJKAGAP<TKey?, TVal?>.HHGOLBOJNJN? EJNKNJABOKE, TimeSpan JBDFINKEBMI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE360", Offset = "0x6CD760")] IEqualityComparer<TKey?>? FODJEGHNNLJ, [Optional] EFBDGHEJBKN? IFGDDFMGOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3549AC0", Offset = "0x35480C0", VA = "0x183549AC0")]
	public bool EEHBMCKLIOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x35494B0", Offset = "0x3547AB0", VA = "0x1835494B0")]
	public bool DJKPCODJIHE(int OCMPILAHMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3549D60", Offset = "0x3548360", VA = "0x183549D60")]
	public void FGMAFKALEHD(TKey BOMEFJIOGGM, TVal MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x290EC90", Offset = "0x290D290", VA = "0x18290EC90", Slot = "14")]
	public void Add([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE3C0", Offset = "0x6CD7C0")] KeyValuePair<TKey, TVal> MDCAOIKFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3547270", Offset = "0x3545870", VA = "0x183547270", Slot = "9")]
	public void Add(TKey BOMEFJIOGGM, TVal MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x35480D0", Offset = "0x35466D0", VA = "0x1835480D0", Slot = "8")]
	public bool ContainsKey(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x35480D0", Offset = "0x35466D0", VA = "0x1835480D0", Slot = "16")]
	public bool Contains([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE420", Offset = "0x6CD820")] KeyValuePair<TKey, TVal> MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x354C580", Offset = "0x354AB80", VA = "0x18354C580", Slot = "10")]
	public bool Remove(TKey BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x354C730", Offset = "0x354AD30", VA = "0x18354C730", Slot = "18")]
	public bool Remove([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE480", Offset = "0x6CD880")] KeyValuePair<TKey, TVal> MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x354C060", Offset = "0x354A660", VA = "0x18354C060")]
	private TVal MBNHJLNEIKL(TKey LKAJHHPOHHJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x354C7B0", Offset = "0x354ADB0", VA = "0x18354C7B0", Slot = "11")]
	public bool TryGetValue(TKey LKAJHHPOHHJ, out TVal MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3548000", Offset = "0x3546600", VA = "0x183548000", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x35487F0", Offset = "0x3546DF0", VA = "0x1835487F0", Slot = "17")]
	public void CopyTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE4E0", Offset = "0x6CD8E0")] KeyValuePair<TKey, TVal>[] IACDCADJJAN, int AJIOAJHCAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x354B1C0", Offset = "0x35497C0", VA = "0x18354B1C0")]
	private bool JIKFBIPKCII([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE540", Offset = "0x6CD940")] KPONBJKAGAP<TKey, TVal>.OEOMOFPDPHE PLFALDDAIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x354A430", Offset = "0x3548A30", VA = "0x18354A430")]
	private void IBNFBFEMDBD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE5A0", Offset = "0x6CD9A0")] LinkedListNode<KPONBJKAGAP<TKey, TVal>.OEOMOFPDPHE> HALFCCFGFAB, TVal KIFJIAOCCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3547900", Offset = "0x3545F00", VA = "0x183547900")]
	private void BDAJONNAIOB(TKey BOMEFJIOGGM, TVal MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x354B8E0", Offset = "0x3549EE0", VA = "0x18354B8E0")]
	private void JJLBABAMONM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE600", Offset = "0x6CDA00")] KPONBJKAGAP<TKey, TVal>.OEOMOFPDPHE PLFALDDAIKD, TVal KIFJIAOCCHE, int IFDFHCDFHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3549EC0", Offset = "0x35484C0", VA = "0x183549EC0", Slot = "19")]
	[IteratorStateMachine(typeof(KPONBJKAGAP<, >.JCLHCALIIKH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24CFE10", Offset = "0x24CE410", VA = "0x1824CFE10", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JKODHJCHDGD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A190", Offset = "0x6F68790", VA = "0x186F6A190")]
	public JKODHJCHDGD(string DPAJDIEBNKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OHFOMCHJCKB<TOk> : JKODHJCHDGD where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly TOk OGGDJDLNMEL;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E350", Offset = "0x2F2C950", VA = "0x182F2E350")]
	private OHFOMCHJCKB(in TOk JELFNPFPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2715AF0", Offset = "0x27140F0", VA = "0x182715AF0")]
	public static OHFOMCHJCKB<TOk> OGNDBCBGIDA(in TOk JELFNPFPKCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public sealed class MJFIOODNFMO<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private readonly struct KCKLKICJDAO : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly MJFIOODNFMO<T> PPHLNLFEKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly int IANJKMILNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly bool FIOGLGLFNPI;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2544E20", Offset = "0x2543420", VA = "0x182544E20")]
		public KCKLKICJDAO(MJFIOODNFMO<T> PMIAAPCBGPN, int DGIIJADFMCE, bool AOFKOMBAJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2544D00", Offset = "0x2543300", VA = "0x182544D00")]
		public MJFIOODNFMO<T>.FAACMEKIDPA FGHGHABHEPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2544DE0", Offset = "0x25433E0", VA = "0x182544DE0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2544DE0", Offset = "0x25433E0", VA = "0x182544DE0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class FAACMEKIDPA : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly MJFIOODNFMO<T> PPHLNLFEKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly int CJDIGDJBICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int LOBFCLLFOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly bool FIOGLGLFNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool BBLMNDGEOJD;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x225B720", Offset = "0x2259D20", VA = "0x18225B720")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x225B9A0", Offset = "0x2259FA0", VA = "0x18225B9A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x225BB50", Offset = "0x225A150", VA = "0x18225BB50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x225BC50", Offset = "0x225A250", VA = "0x18225BC50")]
		public FAACMEKIDPA(MJFIOODNFMO<T> PMIAAPCBGPN, int DGIIJADFMCE, bool AOFKOMBAJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x225B810", Offset = "0x2259E10", VA = "0x18225B810", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x225B8A0", Offset = "0x2259EA0", VA = "0x18225B8A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GACGJBILKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE820", Offset = "0x6CDC20")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public GACGJBILKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3534480", Offset = "0x3532A80", VA = "0x183534480")]
		internal T JBOBNDEBFPJ(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly T[] AGNNMCCOIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int LOBFCLLFOGP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EENIOHMELPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D400", Offset = "0x2B5BA00", VA = "0x182B5D400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T PLBILPKBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2258F10", Offset = "0x2257510", VA = "0x182258F10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T LEMPBCPLEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D5C0", Offset = "0x2B5BBC0", VA = "0x182B5D5C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B5D560", Offset = "0x2B5BB60", VA = "0x182B5D560")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1D51010", Offset = "0x1D4F610", VA = "0x181D51010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xCBF6B0", Offset = "0xCBDCB0", VA = "0x180CBF6B0")]
	private static int OLHJKBABJNI(int OLGOBCPPPBB, int BFDDLCIBNMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D8C0", Offset = "0x2B5BEC0", VA = "0x182B5D8C0")]
	public MJFIOODNFMO(int OCMPILAHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D6D0", Offset = "0x2B5BCD0", VA = "0x182B5D6D0")]
	public MJFIOODNFMO(int OCMPILAHMAJ, Func<T> AKEHHOFOLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2B5DB20", Offset = "0x2B5C120", VA = "0x182B5DB20")]
	public MJFIOODNFMO(T[] PBLKKAHMFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D6A0", Offset = "0x2B5BCA0", VA = "0x182B5D6A0")]
	public void KGPDDAPAMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D5F0", Offset = "0x2B5BBF0", VA = "0x182B5D5F0")]
	public IEnumerable<T> JCPMGFHLECN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D380", Offset = "0x2B5B980", VA = "0x182B5D380")]
	public MJFIOODNFMO<T>.FAACMEKIDPA FGHGHABHEPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2464670", Offset = "0x2462C70", VA = "0x182464670", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2464670", Offset = "0x2462C70", VA = "0x182464670", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OODFNNHONGC
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2303A00", Offset = "0x2302000", VA = "0x182303A00")]
	public static MJFIOODNFMO<T> OGNDBCBGIDA<T>(int OCMPILAHMAJ, Func<T> AKEHHOFOLOD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface BONKIFBLCIE
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LMOENAAFFDC();

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KDCKINHCHKH();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class FPLCNKLFNGK : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KOCCOHMJDND(string LAMHHEIMNAC);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8D40F0", Offset = "0x8D26F0", VA = "0x1808D40F0")]
	protected FPLCNKLFNGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BIAFOPIOMIO<TData> : BNAKFCOEFAL where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string APNBCBOBIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData JEFFIAODLOM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
	public override string KDCKINHCHKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2520A30", Offset = "0x251F030", VA = "0x182520A30")]
	internal BIAFOPIOMIO(string DPAJDIEBNKM, in TData JAIGDBINGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class HKHJGOPJKEN
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xE17E60", Offset = "0xE16460", VA = "0x180E17E60")]
	public static BIAFOPIOMIO<TData> OGNDBCBGIDA<TData>(string DPAJDIEBNKM, in TData JAIGDBINGHO) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LLMPEEEGAMN
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string AIMJINNPCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LLLOGEPNBFK<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TOptions INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct GLOEKJIOMHK<TOk, TErr> : IEquatable<GLOEKJIOMHK<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly EqualityComparer<TErr> OMCMGBMDCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal readonly TErr MACFCMNFDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly TOk OGGDJDLNMEL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool FKJIPDKOPKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x33C1910", Offset = "0x33BFF10", VA = "0x1833C1910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HPJOGCONBMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x33C0DD0", Offset = "0x33BF3D0", VA = "0x1833C0DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x33C1EA0", Offset = "0x33C04A0", VA = "0x1833C1EA0")]
	internal GLOEKJIOMHK(in TErr BGJEGOFMIBK, in TOk JELFNPFPKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x33C0C30", Offset = "0x33BF230", VA = "0x1833C0C30")]
	public static GLOEKJIOMHK<TOk, TErr> COOGMFAAGIG(in TErr BGJEGOFMIBK)
	{
		return default(GLOEKJIOMHK<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x33C0780", Offset = "0x33BED80", VA = "0x1833C0780")]
	public static GLOEKJIOMHK<TOk, TErr> AHFJMBDNGCC(in TOk JELFNPFPKCK)
	{
		return default(GLOEKJIOMHK<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1CB15E0", Offset = "0x1CAFBE0", VA = "0x181CB15E0")]
	public GLOEKJIOMHK<UOk?, TErr?> KGJPJLBHAJG<UOk>()
	{
		return default(GLOEKJIOMHK<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1CB1150", Offset = "0x1CAF750", VA = "0x181CB1150")]
	public GLOEKJIOMHK<UOk?, TErr?> HCJPOJLAHPF<UOk>()
	{
		return default(GLOEKJIOMHK<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1CB0C80", Offset = "0x1CAF280", VA = "0x181CB0C80")]
	public GLOEKJIOMHK<TOk?, UErr?> EJGNGGKLFMK<UErr>()
	{
		return default(GLOEKJIOMHK<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x33C1880", Offset = "0x33BFE80", VA = "0x1833C1880")]
	public GLOEKJIOMHK<CMCGOMMIJLE, TErr> KBGAENFAMIM()
	{
		return default(GLOEKJIOMHK<CMCGOMMIJLE, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x33C0AF0", Offset = "0x33BF0F0", VA = "0x1833C0AF0")]
	public static bool BDIEMMGDBNG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE8E0", Offset = "0x6CDCE0")] in GLOEKJIOMHK<TOk, TErr> CBNLLBDNGLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE950", Offset = "0x6CDD50")] in GLOEKJIOMHK<TOk, TErr> FDIDEGFPCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x33C0E70", Offset = "0x33BF470", VA = "0x1833C0E70", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CE9C0", Offset = "0x6CDDC0")] GLOEKJIOMHK<TOk, TErr> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x33C0FA0", Offset = "0x33BF5A0", VA = "0x1833C0FA0", Slot = "0")]
	public override bool Equals(object FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x33C16F0", Offset = "0x33BFCF0", VA = "0x1833C16F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4017DB0", Offset = "0x40163B0", VA = "0x184017DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class MGGKBBFBOFF
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EOHJPEAKNCN<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Task<GLOEKJIOMHK<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GLOEKJIOMHK<TOk, TErr> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private TaskAwaiter<GLOEKJIOMHK<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public EOHJPEAKNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x18DA690", Offset = "0x18D8C90", VA = "0x1818DA690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class AAKFOIADCJH<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TOk <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerable<GLOEKJIOMHK<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IEnumerable<GLOEKJIOMHK<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEnumerator<GLOEKJIOMHK<TOk, TErr>> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private GLOEKJIOMHK<TOk, TErr> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TOk <ok>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (TOk?)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x18C5790", Offset = "0x18C3D90", VA = "0x1818C5790")]
		[DebuggerHidden]
		public AAKFOIADCJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x218B440", Offset = "0x2189A40", VA = "0x18218B440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C503A0", Offset = "0x2C4E9A0", VA = "0x182C503A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C50350", Offset = "0x2C4E950", VA = "0x182C50350")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C506D0", Offset = "0x2C4ECD0", VA = "0x182C506D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C50620", Offset = "0x2C4EC20", VA = "0x182C50620", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2288970", Offset = "0x2286F70", VA = "0x182288970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1A9F930", Offset = "0x1A9DF30", VA = "0x181A9F930")]
	public static GLOEKJIOMHK<TOk?, TErr?> OGGDJDLNMEL<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CEA60", Offset = "0x6CDE60")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE, in TOk JELFNPFPKCK)
	{
		return default(GLOEKJIOMHK<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1A9FCF0", Offset = "0x1A9E2F0", VA = "0x181A9FCF0")]
	public static GLOEKJIOMHK<CMCGOMMIJLE, TErr?> OGGDJDLNMEL<TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CEB00", Offset = "0x6CDF00")] this in GLOEKJIOMHK<CMCGOMMIJLE, TErr?> CDBMADFDGCE)
	{
		return default(GLOEKJIOMHK<CMCGOMMIJLE, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A9F930", Offset = "0x1A9DF30", VA = "0x181A9F930")]
	public static GLOEKJIOMHK<TOk?, TErr?> MACFCMNFDHO<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CEB70", Offset = "0x6CDF70")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE, in TErr BGJEGOFMIBK)
	{
		return default(GLOEKJIOMHK<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A9DF30", Offset = "0x1A9C530", VA = "0x181A9DF30")]
	public static TOk? DIIHIGIPAKB<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CEBE0", Offset = "0x6CDFE0")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1A9F0A0", Offset = "0x1A9D6A0", VA = "0x181A9F0A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EOHJPEAKNCN<, >))]
	public static Task<TOk?>? JMIBFCHKDKM<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CECC0", Offset = "0x6CE0C0")] this Task<GLOEKJIOMHK<TOk?, TErr?>>? CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1A9EEB0", Offset = "0x1A9D4B0", VA = "0x181A9EEB0")]
	public static TErr? GIIOIDLHJIN<TErr, TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CED20", Offset = "0x6CE120")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1A9E200", Offset = "0x1A9C800", VA = "0x181A9E200")]
	public static bool ECIJECOFIPD<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CED90", Offset = "0x6CE190")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CEE00", Offset = "0x6CE200")] out GLOEKJIOMHK<UOk?, UErr?> JKIJMDHHHGO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1A9EE00", Offset = "0x1A9D400", VA = "0x181A9EE00")]
	public static bool FAGDPILPLMB<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CEE60", Offset = "0x6CE260")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE, [HLBOCLLKMAH(true)] out TOk JELFNPFPKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1A9FD20", Offset = "0x1A9E320", VA = "0x181A9FD20")]
	public static bool PAHBBNNIGEI<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CEF10", Offset = "0x6CE310")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE, [HLBOCLLKMAH(true)] out TErr BGJEGOFMIBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1A9F4F0", Offset = "0x1A9DAF0", VA = "0x181A9F4F0")]
	public static bool KLBGBHBKCMP<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CEFC0", Offset = "0x6CE3C0")] this in GLOEKJIOMHK<TOk, TErr> CDBMADFDGCE, [HLBOCLLKMAH(true)] out TOk JELFNPFPKCK, [HLBOCLLKMAH(false)] out TErr BGJEGOFMIBK) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1A9F000", Offset = "0x1A9D600", VA = "0x181A9F000")]
	public static bool JELBLNEJMHD<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF030", Offset = "0x6CE430")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE, [HLBOCLLKMAH(true)] out TOk JELFNPFPKCK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF0A0", Offset = "0x6CE4A0")] out GLOEKJIOMHK<TOk?, TErr?> JKIJMDHHHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1A9E440", Offset = "0x1A9CA40", VA = "0x181A9E440")]
	public static bool ECIJECOFIPD<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF100", Offset = "0x6CE500")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE, [HLBOCLLKMAH(true)] out TOk JELFNPFPKCK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF170", Offset = "0x6CE570")] out GLOEKJIOMHK<UOk?, UErr?> JKIJMDHHHGO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1A9F670", Offset = "0x1A9DC70", VA = "0x181A9F670")]
	public static bool LEEIPJCFJEM<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF1D0", Offset = "0x6CE5D0")] this in GLOEKJIOMHK<TOk?, TErr?> CDBMADFDGCE, [HLBOCLLKMAH(true)] out TOk JELFNPFPKCK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF240", Offset = "0x6CE640")] out GLOEKJIOMHK<CMCGOMMIJLE, TErr?> JKIJMDHHHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1A9DC00", Offset = "0x1A9C200", VA = "0x181A9DC00")]
	public static GLOEKJIOMHK<UOk, UErr> CBELNHKHKDK<UOk, UErr, TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF2A0", Offset = "0x6CE6A0")] this in GLOEKJIOMHK<TOk, TErr> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF310", Offset = "0x6CE710")] in GLOEKJIOMHK<UOk, UErr> OINELIMPDDO) where TOk : UOk where TErr : UErr
	{
		return default(GLOEKJIOMHK<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A9FA30", Offset = "0x1A9E030", VA = "0x181A9FA30")]
	public static GLOEKJIOMHK<TOk?[]?, TErr?> NBCEEGPOPBK<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF380", Offset = "0x6CE780")] this IEnumerable<GLOEKJIOMHK<TOk?, TErr?>>? CDBMADFDGCE)
	{
		return default(GLOEKJIOMHK<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1466940", Offset = "0x1464F40", VA = "0x181466940")]
	[IteratorStateMachine(typeof(AAKFOIADCJH<, >))]
	public static IEnumerable<TOk?>? DNNEPKOAJHO<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF450", Offset = "0x6CE850")] this IEnumerable<GLOEKJIOMHK<TOk?, TErr?>>? CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ADCMCEGPBMJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2669580", Offset = "0x2667B80", VA = "0x182669580")]
	public static GLOEKJIOMHK<TOk, T> OGGDJDLNMEL<TOk>(in TOk JELFNPFPKCK) where TOk : notnull
	{
		return default(GLOEKJIOMHK<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C521A0", Offset = "0x2C507A0", VA = "0x182C521A0")]
	public static GLOEKJIOMHK<CMCGOMMIJLE, T> OGGDJDLNMEL()
	{
		return default(GLOEKJIOMHK<CMCGOMMIJLE, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26694C0", Offset = "0x2667AC0", VA = "0x1826694C0")]
	public static GLOEKJIOMHK<T, TErr> MACFCMNFDHO<TErr>(in TErr BGJEGOFMIBK) where TErr : notnull
	{
		return default(GLOEKJIOMHK<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct HANELNNFMJI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public delegate bool BCJJLNGMNNG(string DOPCJOLBLKK, HANELNNFMJI ENOIHKIKINH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public int KEFANKKKDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public string OIEKDMNOICF;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F69290", Offset = "0x6F67890", VA = "0x186F69290")]
	public static Dictionary<string, HANELNNFMJI> PMDIGLIJACE(Type JJAFEMBKNDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F68E20", Offset = "0x6F67420", VA = "0x186F68E20")]
	public static Dictionary<string, HANELNNFMJI> EMAGHBGBOMI(Type JJAFEMBKNDO, BCJJLNGMNNG PFNPJMPCDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F68C70", Offset = "0x6F67270", VA = "0x186F68C70")]
	public static Dictionary<int, string> EKMLFOECPNA(Dictionary<string, HANELNNFMJI> PAKFOBAPADB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct JPPJCPKKJIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850")]
	public static JPPJCPKKJIG NIOOODEFKMO(Type KLGGKKGCLHM, [Optional] string? FKPLDMKBIFN, [Optional] string? IBBELBFMJAH, bool FMBAGDMLHKC = false)
	{
		return default(JPPJCPKKJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850")]
	public static JPPJCPKKJIG NIOOODEFKMO<T>([Optional] string? FKPLDMKBIFN, [Optional] string? IBBELBFMJAH, bool FMBAGDMLHKC = false)
	{
		return default(JPPJCPKKJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class FIPILBKCNJG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class LMHFOMNBOLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public LMHFOMNBOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28DC5C0", Offset = "0x28DABC0", VA = "0x1828DC5C0")]
		internal int FCCDFOGBCLI(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF4B0", Offset = "0x6CE8B0")]
	private HashSet<T> JFMMDEMIFBN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IReadOnlyCollection<T> IBCOBDFIEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x31BE970", Offset = "0x31BCF70", VA = "0x1831BE970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool IEFDKMIOCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x31BE860", Offset = "0x31BCE60", VA = "0x1831BE860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xB910F0", Offset = "0xB8F6F0", VA = "0x180B910F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x31BE9D0", Offset = "0x31BCFD0", VA = "0x1831BE9D0")]
	public bool PDDBDHJNBOH(T DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x31BE890", Offset = "0x31BCE90", VA = "0x1831BE890")]
	public bool EIILGGCBFDG(T DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x31BE990", Offset = "0x31BCF90", VA = "0x1831BE990")]
	public bool JDABAMPMFDA(T DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x31BEB10", Offset = "0x31BD110", VA = "0x1831BEB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
	public FIPILBKCNJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OHJLPFOFFLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly string BJENCHOPGIO;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public OHJLPFOFFLG(string BJENCHOPGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A5F0", Offset = "0x6F68BF0", VA = "0x186F6A5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class DMMBJKBEDJE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class EJPNIAGFOJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public EJPNIAGFOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F68570", Offset = "0x6F66B70", VA = "0x186F68570")]
		internal int FCCDFOGBCLI(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF510", Offset = "0x6CE910")]
	private HashSet<object> JFMMDEMIFBN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyCollection<object> IBCOBDFIEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F68120", Offset = "0x6F66720", VA = "0x186F68120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool IEFDKMIOCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F68000", Offset = "0x6F66600", VA = "0x186F68000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xB910F0", Offset = "0xB8F6F0", VA = "0x180B910F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F68250", Offset = "0x6F66850", VA = "0x186F68250")]
	public bool PDDBDHJNBOH(object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F68080", Offset = "0x6F66680", VA = "0x186F68080")]
	public bool EIILGGCBFDG(object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F681F0", Offset = "0x6F667F0", VA = "0x186F681F0")]
	public bool JDABAMPMFDA(object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F68010", Offset = "0x6F66610", VA = "0x186F68010")]
	public void CBMIDCGCBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F68330", Offset = "0x6F66930", VA = "0x186F68330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public DMMBJKBEDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class DMMNFKPMDLN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct NCMANDGPCHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float ODPIHCJNICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public T INKIKMDHKDA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CF570", Offset = "0x6CE970")]
	private readonly Dictionary<object, DMMNFKPMDLN<T>.NCMANDGPCHM> PPGANGPLNJB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual T LOCFCDKBFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x12EEA80", Offset = "0x12ED080", VA = "0x1812EEA80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x12EE200", Offset = "0x12EC800", VA = "0x1812EE200", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public object? NFFPJBBFMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x919C70", Offset = "0x918270", VA = "0x180919C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GOAODNGONAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x22726F0", Offset = "0x2270CF0", VA = "0x1822726F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2272150", Offset = "0x2270750", VA = "0x182272150")]
	public bool BDAJONNAIOB(T MOLEJFDINLH, object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1F12210", Offset = "0x1F10810", VA = "0x181F12210")]
	public bool KOIAEECBLND(object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2272730", Offset = "0x2270D30", VA = "0x182272730")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2274070", Offset = "0x2272670", VA = "0x182274070")]
	public bool PFDPJLFFHJD(object DCEGGIJLHGI, out T MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2273D00", Offset = "0x2272300", VA = "0x182273D00")]
	private bool NGHDAADEPHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2274690", Offset = "0x2272C90", VA = "0x182274690")]
	public DMMNFKPMDLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class GPJKCHLCNIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<object, float> PPGANGPLNJB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float OMDCDHIACCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x935910", Offset = "0x933F10", VA = "0x180935910")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC8BA40", Offset = "0xC8A040", VA = "0x180C8BA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F68960", Offset = "0x6F66F60", VA = "0x186F68960")]
	public void BDAJONNAIOB(float MOLEJFDINLH, object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6F68AF0", Offset = "0x6F670F0", VA = "0x186F68AF0")]
	public void KOIAEECBLND(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6F689D0", Offset = "0x6F66FD0", VA = "0x186F689D0")]
	private void EIJLDOKABFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6F68B60", Offset = "0x6F67160", VA = "0x186F68B60")]
	public GPJKCHLCNIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public delegate void EEOIEHPIFNK(float PBBMALJCNKC);
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GMNPIODEMDF
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class PBCGLLNCJHI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly BPLOLNHMHBH FHEDFPKCHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly EEOIEHPIFNK AJNAMFOHMMI;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A690", Offset = "0x6F68C90", VA = "0x186F6A690")]
		public PBCGLLNCJHI(BPLOLNHMHBH FHEDFPKCHHK, EEOIEHPIFNK AJNAMFOHMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A640", Offset = "0x6F68C40", VA = "0x186F6A640", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F688E0", Offset = "0x6F66EE0", VA = "0x186F688E0")]
	internal static bool MIAILNPACCP(float GNJGFBLEGKK, float HEPECHBEGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5099A40", Offset = "0x5098040", VA = "0x185099A40")]
	internal static float ILMIGICBEGP(float GNJGFBLEGKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6F68820", Offset = "0x6F66E20", VA = "0x186F68820")]
	public static IDisposable JDIPEAKHGFA(this BPLOLNHMHBH FHEDFPKCHHK, EEOIEHPIFNK AJNAMFOHMMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class IEEAEJFKLPK : BPLOLNHMHBH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct MGEIMJBMCGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly float FBLMNIJABOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly float JFHEJCIOGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal readonly bool JJDFFNAFLGB;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float JLLEAFLJKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6F6A270", Offset = "0x6F68870", VA = "0x186F6A270")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A400", Offset = "0x6F68A00", VA = "0x186F6A400")]
		public MGEIMJBMCGJ(float FIDLKHDDPII, float HOLOHKLLGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A280", Offset = "0x6F68880", VA = "0x186F6A280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HAGGBKHADIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public IEEAEJFKLPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public HAGGBKHADIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6F68BE0", Offset = "0x6F671E0", VA = "0x186F68BE0")]
		internal void KFOBOIGOBCI(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly int LEFNHMBHKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private int FMMNBFPFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly BPLOLNHMHBH[] CCMOGLNAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly EEOIEHPIFNK[] FOAHDAGNGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MGEIMJBMCGJ[] HOFKOEHADMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private MGEIMJBMCGJ BPADKBGIHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GHGPDJGBMAE GLLFPECJAPJ;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EEOIEHPIFNK PFLHHGICMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6F69B60", Offset = "0x6F68160", VA = "0x186F69B60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6F69C20", Offset = "0x6F68220", VA = "0x186F69C20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6F69CE0", Offset = "0x6F682E0", VA = "0x186F69CE0")]
	public IEEAEJFKLPK(int LEFNHMBHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6F69580", Offset = "0x6F67B80", VA = "0x186F69580")]
	public GHGPDJGBMAE BHMFIMNPPDC(MGEIMJBMCGJ NILANNAAGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6F69610", Offset = "0x6F67C10", VA = "0x186F69610")]
	public void CFKPGPPGFOL(BPLOLNHMHBH DOINFIHGNDM, [Optional] MGEIMJBMCGJ HKJFLLJLIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6F69A50", Offset = "0x6F68050", VA = "0x186F69A50", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class GHGPDJGBMAE : BPLOLNHMHBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private float PBBMALJCNKC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float AHNANEIODBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6F68620", Offset = "0x6F66C20", VA = "0x186F68620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EEOIEHPIFNK? PFLHHGICMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6F686E0", Offset = "0x6F66CE0", VA = "0x186F686E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6F68780", Offset = "0x6F66D80", VA = "0x186F68780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public GHGPDJGBMAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface BPLOLNHMHBH
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EEOIEHPIFNK PFLHHGICMKF;
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
