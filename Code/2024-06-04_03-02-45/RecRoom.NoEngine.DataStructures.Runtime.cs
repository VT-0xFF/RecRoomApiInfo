using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69257F0", Offset = "0x6923FF0", VA = "0x1869257F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FIGABINILDI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected FIGABINILDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PFPDEFNOEDL<T> : FIGABINILDI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OPNNNCEPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum HPKEEIDKKAN
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
		public HPKEEIDKKAN HKAKMPIMEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T BMOCGPMNBAF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LCLNOEDEDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool KPBAIHDGGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool NPPOFBFKGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? DOHIGBMJBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OPNNNCEPLKH>? POBIBEOMAML;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JAGDLOGGHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46533F0", Offset = "0x4651BF0", VA = "0x1846533F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4653C40", Offset = "0x4652440", VA = "0x184653C40")]
	protected PFPDEFNOEDL(bool NPPOFBFKGIA, bool KPBAIHDGGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4653900", Offset = "0x4652100", VA = "0x184653900")]
	protected bool GOJBKKCCMNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4653460", Offset = "0x4651C60", VA = "0x184653460")]
	protected void FEFPEOMKCHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46539A0", Offset = "0x46521A0", VA = "0x1846539A0")]
	protected void MOJFGNNDLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDC50", Offset = "0x2AEC450", VA = "0x182AEDC50")]
	private static void LJJIIPOOHPJ<U>(List<U>? MAKDKEMHGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46531E0", Offset = "0x46519E0", VA = "0x1846531E0", Slot = "4")]
	public void CNLMKNIMMKA(T BMOCGPMNBAF, bool PEANNPPJILJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4653580", Offset = "0x4651D80", VA = "0x184653580", Slot = "5")]
	public void GALPDKBCKMP(T BMOCGPMNBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4653750", Offset = "0x4651F50", VA = "0x184653750")]
	public void GLOOIBDLHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LFHDLKLNBFG : PFPDEFNOEDL<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6924A40", Offset = "0x6923240", VA = "0x186924A40")]
	public LFHDLKLNBFG(bool NPPOFBFKGIA = false, bool KPBAIHDGGFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6924780", Offset = "0x6922F80", VA = "0x186924780")]
	public void EHHNDHAPNMD()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69249E0", Offset = "0x69231E0", VA = "0x1869249E0")]
	public static LFHDLKLNBFG OBCMMDOIGAL(LFHDLKLNBFG MKNBLDKJGPE, Action BMOCGPMNBAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6924980", Offset = "0x6923180", VA = "0x186924980")]
	public static LFHDLKLNBFG KCENMCPGDOF(LFHDLKLNBFG MKNBLDKJGPE, Action BMOCGPMNBAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KPACPKKFLJO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNLMKNIMMKA(Action<T> BMOCGPMNBAF, bool PEANNPPJILJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GALPDKBCKMP(Action<T> BMOCGPMNBAF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class EPMNOCMNENI<T> : PFPDEFNOEDL<Action<T>>, KPACPKKFLJO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3779DC0", Offset = "0x37785C0", VA = "0x183779DC0")]
	public EPMNOCMNENI(bool NPPOFBFKGIA = false, bool KPBAIHDGGFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3777C80", Offset = "0x3776480", VA = "0x183777C80")]
	public void EHHNDHAPNMD(T AFCJJMLHKMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3779D10", Offset = "0x3778510", VA = "0x183779D10")]
	public static EPMNOCMNENI<T> OBCMMDOIGAL(EPMNOCMNENI<T> MKNBLDKJGPE, Action<T> BMOCGPMNBAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3779C70", Offset = "0x3778470", VA = "0x183779C70")]
	public static EPMNOCMNENI<T> KCENMCPGDOF(EPMNOCMNENI<T> MKNBLDKJGPE, Action<T> BMOCGPMNBAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PKPIAODMDEK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FIPPODCNHJE<T, U> : PFPDEFNOEDL<Action<T, U>>, PKPIAODMDEK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3779DC0", Offset = "0x37785C0", VA = "0x183779DC0")]
	public FIPPODCNHJE(bool NPPOFBFKGIA = false, bool KPBAIHDGGFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF80A0", Offset = "0x3AF68A0", VA = "0x183AF80A0")]
	public void EHHNDHAPNMD(T AFCJJMLHKMJ, U EDLCBPGGEOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3779D10", Offset = "0x3778510", VA = "0x183779D10")]
	public static FIPPODCNHJE<T, U> OBCMMDOIGAL(FIPPODCNHJE<T, U> MKNBLDKJGPE, Action<T, U> BMOCGPMNBAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3779C70", Offset = "0x3778470", VA = "0x183779C70")]
	public static FIPPODCNHJE<T, U> KCENMCPGDOF(FIPPODCNHJE<T, U> MKNBLDKJGPE, Action<T, U> BMOCGPMNBAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NIICELDHKHK<T, U, V> : PFPDEFNOEDL<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3779DC0", Offset = "0x37785C0", VA = "0x183779DC0")]
	public NIICELDHKHK(bool NPPOFBFKGIA = false, bool KPBAIHDGGFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x44491F0", Offset = "0x44479F0", VA = "0x1844491F0")]
	public void EHHNDHAPNMD(T AFCJJMLHKMJ, U EDLCBPGGEOC, V BLNBBLFAAGC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3779D10", Offset = "0x3778510", VA = "0x183779D10")]
	public static NIICELDHKHK<T, U, V> OBCMMDOIGAL(NIICELDHKHK<T, U, V> MKNBLDKJGPE, Action<T, U, V> BMOCGPMNBAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3779C70", Offset = "0x3778470", VA = "0x183779C70")]
	public static NIICELDHKHK<T, U, V> KCENMCPGDOF(NIICELDHKHK<T, U, V> MKNBLDKJGPE, Action<T, U, V> BMOCGPMNBAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JMEIDJIJPIO<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class IOAOCAIDKPK<T, U, V, W> : PFPDEFNOEDL<Action<T, U, V, W>>, JMEIDJIJPIO<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3779DC0", Offset = "0x37785C0", VA = "0x183779DC0")]
	public IOAOCAIDKPK(bool NPPOFBFKGIA = false, bool KPBAIHDGGFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DBDB80", Offset = "0x3DBC380", VA = "0x183DBDB80")]
	public void EHHNDHAPNMD(T AFCJJMLHKMJ, U EDLCBPGGEOC, V BLNBBLFAAGC, W NCACLCNGFPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3779D10", Offset = "0x3778510", VA = "0x183779D10")]
	public static IOAOCAIDKPK<T, U, V, W> OBCMMDOIGAL(IOAOCAIDKPK<T, U, V, W> MKNBLDKJGPE, Action<T, U, V, W> BMOCGPMNBAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3779C70", Offset = "0x3778470", VA = "0x183779C70")]
	public static IOAOCAIDKPK<T, U, V, W> KCENMCPGDOF(IOAOCAIDKPK<T, U, V, W> MKNBLDKJGPE, Action<T, U, V, W> BMOCGPMNBAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class OMFCDLOHHDG<T, U, V, W, X> : PFPDEFNOEDL<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3779DC0", Offset = "0x37785C0", VA = "0x183779DC0")]
	public OMFCDLOHHDG(bool NPPOFBFKGIA = false, bool KPBAIHDGGFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x45900E0", Offset = "0x458E8E0", VA = "0x1845900E0")]
	public void EHHNDHAPNMD(T AFCJJMLHKMJ, U EDLCBPGGEOC, V BLNBBLFAAGC, W NCACLCNGFPK, X PNGIKMLKECD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3779D10", Offset = "0x3778510", VA = "0x183779D10")]
	public static OMFCDLOHHDG<T, U, V, W, X> OBCMMDOIGAL(OMFCDLOHHDG<T, U, V, W, X> MKNBLDKJGPE, Action<T, U, V, W, X> BMOCGPMNBAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3779C70", Offset = "0x3778470", VA = "0x183779C70")]
	public static OMFCDLOHHDG<T, U, V, W, X> KCENMCPGDOF(OMFCDLOHHDG<T, U, V, W, X> MKNBLDKJGPE, Action<T, U, V, W, X> BMOCGPMNBAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class AFOKKDKKKAE<T, U, V, W, X, Y> : PFPDEFNOEDL<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3779DC0", Offset = "0x37785C0", VA = "0x183779DC0")]
	public AFOKKDKKKAE(bool NPPOFBFKGIA = false, bool KPBAIHDGGFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C790", Offset = "0x3B9AF90", VA = "0x183B9C790")]
	public void EHHNDHAPNMD(T AFCJJMLHKMJ, U EDLCBPGGEOC, V BLNBBLFAAGC, W NCACLCNGFPK, X PNGIKMLKECD, Y MADKMAGKKBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3779D10", Offset = "0x3778510", VA = "0x183779D10")]
	public static AFOKKDKKKAE<T, U, V, W, X, Y> OBCMMDOIGAL(AFOKKDKKKAE<T, U, V, W, X, Y> MKNBLDKJGPE, Action<T, U, V, W, X, Y> BMOCGPMNBAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3779C70", Offset = "0x3778470", VA = "0x183779C70")]
	public static AFOKKDKKKAE<T, U, V, W, X, Y> KCENMCPGDOF(AFOKKDKKKAE<T, U, V, W, X, Y> MKNBLDKJGPE, Action<T, U, V, W, X, Y> BMOCGPMNBAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MDDDIGOJCJH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CBPJIEKGGMD<TKey, TVal> PIIMGMALJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> KMGNKBJDLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CBPJIEKGGMD<TKey, TVal>.JILCJBAHNMH? KLDFBEACOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int HKPFNGBKAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CBPJIEKGGMD<TKey, TVal>.MHKPDPFLLMA? PFFMOINACPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int HMFCDBJFLJH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int MKJKMJPIGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x433FEA0", Offset = "0x433E6A0", VA = "0x18433FEA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FJDDEBMGINO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84CE60", Offset = "0x84B660", VA = "0x18084CE60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4341260", Offset = "0x433FA60", VA = "0x184341260")]
	public MDDDIGOJCJH(int HKPFNGBKAIL, [Optional] CBPJIEKGGMD<TKey, TVal>.MHKPDPFLLMA? PFFMOINACPH, [Optional] IEqualityComparer<TKey>? MGHGMPIHICE, [Optional] CBPJIEKGGMD<TKey, TVal>.JILCJBAHNMH? KLDFBEACOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4341010", Offset = "0x433F810", VA = "0x184341010")]
	public void OLLLCKNPDOE(TKey JOEHGGMHBAA, TVal IPHHABIKCHD, bool NHCLDGAGIAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4340D50", Offset = "0x433F550", VA = "0x184340D50")]
	public bool HGAONNDHMCJ(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4340BA0", Offset = "0x433F3A0", VA = "0x184340BA0")]
	public bool GFIHGBPIMCF(TKey DIODKLJFBKA, [Out] TVal IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x43408C0", Offset = "0x433F0C0", VA = "0x1843408C0")]
	private void EBOBOJAMOHO(TKey JOEHGGMHBAA, TVal IPHHABIKCHD, int GGKCGCGFHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x43405C0", Offset = "0x433EDC0", VA = "0x1843405C0")]
	public bool CFGHJDPGGBD(TKey JOEHGGMHBAA, TVal IPHHABIKCHD, bool NHCLDGAGIAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4340CA0", Offset = "0x433F4A0", VA = "0x184340CA0")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4340030", Offset = "0x433E830", VA = "0x184340030")]
	private void CEIEEKCIKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4340EC0", Offset = "0x433F6C0", VA = "0x184340EC0")]
	private bool MOELOJCMOFF(TKey JOEHGGMHBAA, IADPNJPOJEP DAGAMHLIEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x433FF00", Offset = "0x433E700", VA = "0x18433FF00")]
	private void BNDMPGJCHAL(TKey JOEHGGMHBAA, TVal IPHHABIKCHD, IADPNJPOJEP DAGAMHLIEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4340790", Offset = "0x433EF90", VA = "0x184340790")]
	private void DBGLBOJPIKA(TKey JOEHGGMHBAA, TVal FCGMGAOCKCN, IADPNJPOJEP DAGAMHLIEBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KGJOFFPMKCN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action ALLNLIGCNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JIEBBDLBGPG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public KGJOFFPMKCN(Action JFBDEHKEHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6924740", Offset = "0x6922F40", VA = "0x186924740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x289C620", Offset = "0x289AE20", VA = "0x18289C620")]
	public static HHIKLOPOAIH<T> DLNFHNOLCMJ<T>(T IPHHABIKCHD, Action JFBDEHKEHKC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HHIKLOPOAIH<T> : KGJOFFPMKCN where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T JDDKPJKLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CAC580", Offset = "0x3CAAD80", VA = "0x183CAC580")]
	public HHIKLOPOAIH(T IPHHABIKCHD, Action JFBDEHKEHKC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GCDKEKMPKHA : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct DLDBHJEHDIJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
		public static DLDBHJEHDIJ OJFFIHPLODM()
		{
			return default(DLDBHJEHDIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A89FA0", Offset = "0x2A887A0", VA = "0x182A89FA0")]
	public static string? BCAABJLPPOA<T>([Optional] string? CPDMOBAPEIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A89F20", Offset = "0x2A88720", VA = "0x182A89F20")]
	public static string? AKJNDNIGAOH<T>([Optional] string? KGNNFNEILFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	public static GCDKEKMPKHA CGJPOCGNPIB(string CPDMOBAPEIG, string? KGNNFNEILFO)
	{
		return default(GCDKEKMPKHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FOFCIDGPHKD
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate bool IBNKLALGOBJ(string EBCFHGDEAHF, FOFCIDGPHKD OBDLJGLKNPJ);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HKDBEDMGPGM<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HKDBEDMGPGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEF00", Offset = "0x3CAD700", VA = "0x183CAEF00")]
		internal void GIEJOANDLPN(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int GNHCOHKDBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string MMDKIAPHBLM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6923E70", Offset = "0x6922670", VA = "0x186923E70")]
	public static Dictionary<string, FOFCIDGPHKD> PFABNJGCJMJ(Type NPKONCFIEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EAB0", Offset = "0x2A7D2B0", VA = "0x182A7EAB0")]
	public static Dictionary<string, FOFCIDGPHKD> PFABNJGCJMJ<T>(Type NPKONCFIEAK, IReadOnlyDictionary<T, string> NNEBCPNMJEF) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E330", Offset = "0x2A7CB30", VA = "0x182A7E330")]
	public static Dictionary<string, FOFCIDGPHKD> AMIGFECELFK<T>(List<T> DCEJJIDCHHL) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69238F0", Offset = "0x69220F0", VA = "0x1869238F0")]
	public static Dictionary<string, FOFCIDGPHKD> CFGNAMGGKPH(Type NPKONCFIEAK, IBNKLALGOBJ LIPGNMOAMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6923CB0", Offset = "0x69224B0", VA = "0x186923CB0")]
	public static Dictionary<int, string> DLHAHENEKCD(Dictionary<string, FOFCIDGPHKD> CMAEAOPOFPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PLHOCJDFICM : DCIBOGBGGHI
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static bool NLNCHDOAMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly string? PCFGAEFDCIA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual DCIBOGBGGHI? EEFHJEJEJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6925F70", Offset = "0x6924770", VA = "0x186925F70")]
	protected PLHOCJDFICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string ILHCPMBLOJC();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6925AE0", Offset = "0x69242E0", VA = "0x186925AE0", Slot = "8")]
	public virtual string GJGKNODBOCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6925CC0", Offset = "0x69244C0", VA = "0x186925CC0", Slot = "9")]
	public void ODCAJMKEKJL(StringBuilder JOMGKNMBICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6925A80", Offset = "0x6924280", VA = "0x186925A80", Slot = "10")]
	public void DGEBPMPGOOC(StringBuilder JOMGKNMBICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69258C0", Offset = "0x69240C0", VA = "0x1869258C0", Slot = "11")]
	public void ANNPGMAPGHF(StringBuilder JOMGKNMBICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6925B60", Offset = "0x6924360", VA = "0x186925B60", Slot = "12")]
	public void LGCKJPFCNJI(StringBuilder JOMGKNMBICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69259E0", Offset = "0x69241E0", VA = "0x1869259E0")]
	public static void CAMGEHPPKGK(StringBuilder JOMGKNMBICL, string EGJEMOICCAN, string GPBHLLMFDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5B43600", Offset = "0x5B41E00", VA = "0x185B43600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FDGJBIIOJOO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6923820", Offset = "0x6922020", VA = "0x186923820")]
	public FDGJBIIOJOO(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NHMLBDNNJEO<TErr> : FDGJBIIOJOO where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TErr ONOAMANMMNL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x442DC10", Offset = "0x442C410", VA = "0x18442DC10")]
	private NHMLBDNNJEO([In] TErr BPJHAELLGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x442DB30", Offset = "0x442C330", VA = "0x18442DB30")]
	public static NHMLBDNNJEO<TErr> OJFFIHPLODM([In] TErr BPJHAELLGKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DCIBOGBGGHI
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GJGKNODBOCH();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ILHCPMBLOJC();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OADGNOHHALD<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions JDDKPJKLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ECNNHDOOFII
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string NFHMJLJCCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LIAABJDBELL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6924AA0", Offset = "0x69232A0", VA = "0x186924AA0")]
	public LIAABJDBELL(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EEPKFLGPELB<TOk> : LIAABJDBELL where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly TOk LMNFDFBBNKE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3747AD0", Offset = "0x37462D0", VA = "0x183747AD0")]
	private EEPKFLGPELB([In] TOk FJAIOLDBGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3747810", Offset = "0x3746010", VA = "0x183747810")]
	public static EEPKFLGPELB<TOk> OJFFIHPLODM([In] TOk FJAIOLDBGMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct MEKCEIEFNPI<TOk, TErr> : IEquatable<MEKCEIEFNPI<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly EqualityComparer<TErr> ADGJEKAPNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TErr ONOAMANMMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal readonly TOk LMNFDFBBNKE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GEHKCLHFLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x435E260", Offset = "0x435CA60", VA = "0x18435E260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IBDIBDACKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x435C960", Offset = "0x435B160", VA = "0x18435C960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x435F190", Offset = "0x435D990", VA = "0x18435F190")]
	internal MEKCEIEFNPI([In] TErr BPJHAELLGKN, [In] TOk FJAIOLDBGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x435C8A0", Offset = "0x435B0A0", VA = "0x18435C8A0")]
	public static MEKCEIEFNPI<TOk, TErr> AAECEADJKHG([In] TErr BPJHAELLGKN)
	{
		return default(MEKCEIEFNPI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x435E320", Offset = "0x435CB20", VA = "0x18435E320")]
	public static MEKCEIEFNPI<TOk, TErr> MNLLNKPHFIH([In] TOk FJAIOLDBGMK)
	{
		return default(MEKCEIEFNPI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x29A3C60", Offset = "0x29A2460", VA = "0x1829A3C60")]
	public MEKCEIEFNPI<TOk?, UErr?> CAJCOLMAOCF<UErr>()
	{
		return default(MEKCEIEFNPI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x29A4520", Offset = "0x29A2D20", VA = "0x1829A4520")]
	public MEKCEIEFNPI<UOk?, TErr?> CHPFMKJOGKF<UOk>()
	{
		return default(MEKCEIEFNPI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29A2E90", Offset = "0x29A1690", VA = "0x1829A2E90")]
	public MEKCEIEFNPI<UOk?, TErr?> BMGLGCEDOLM<UOk>()
	{
		return default(MEKCEIEFNPI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29A4D00", Offset = "0x29A3500", VA = "0x1829A4D00")]
	public MEKCEIEFNPI<TOk?, UErr?> LCOCENGBPCB<UErr>()
	{
		return default(MEKCEIEFNPI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x435C9F0", Offset = "0x435B1F0", VA = "0x18435C9F0")]
	public MEKCEIEFNPI<KNDENJDHONE, TErr> DFBHJNBCKMG()
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x435DA20", Offset = "0x435C220", VA = "0x18435DA20")]
	public static bool JAJJILMADFD([In] MEKCEIEFNPI<TOk, TErr> LDKECOBJCHJ, [In] MEKCEIEFNPI<TOk, TErr> JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x435CA90", Offset = "0x435B290", VA = "0x18435CA90", Slot = "4")]
	public bool Equals(MEKCEIEFNPI<TOk, TErr> OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x435CD10", Offset = "0x435B510", VA = "0x18435CD10", Slot = "0")]
	public override bool Equals(object OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x435D620", Offset = "0x435BE20", VA = "0x18435D620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x435EC80", Offset = "0x435D480", VA = "0x18435EC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NFHOGCNIJIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct HONCFFJHHBO<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Task<MEKCEIEFNPI<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<MEKCEIEFNPI<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4680", Offset = "0x3CC2E80", VA = "0x183CC4680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3CC49C0", Offset = "0x3CC31C0", VA = "0x183CC49C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB970", Offset = "0x2BDA170", VA = "0x182BDB970")]
	public static MEKCEIEFNPI<TOk?, TErr?> LMNFDFBBNKE<TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [In] TOk FJAIOLDBGMK)
	{
		return default(MEKCEIEFNPI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB9D0", Offset = "0x2BDA1D0", VA = "0x182BDB9D0")]
	public static MEKCEIEFNPI<KNDENJDHONE, TErr?> LMNFDFBBNKE<TErr>([In] this MEKCEIEFNPI<KNDENJDHONE, TErr> EGJINJKGIAK)
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB970", Offset = "0x2BDA170", VA = "0x182BDB970")]
	public static MEKCEIEFNPI<TOk?, TErr?> ONOAMANMMNL<TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [In] TErr BPJHAELLGKN)
	{
		return default(MEKCEIEFNPI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB420", Offset = "0x2BD9C20", VA = "0x182BDB420")]
	public static TOk? KGFMPOFJIJJ<TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAFA0", Offset = "0x2BD97A0", VA = "0x182BDAFA0")]
	[AsyncStateMachine(typeof(HONCFFJHHBO<, >))]
	public static Task<TOk?>? IIAKIDFBGOJ<TOk, TErr>(this Task<MEKCEIEFNPI<TOk, TErr>> EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2BD99A0", Offset = "0x2BD81A0", VA = "0x182BD99A0")]
	public static TErr? DLIGPHKCGCC<TErr, TOk>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9C60", Offset = "0x2BD8460", VA = "0x182BD9C60")]
	public static bool EPFLAEGBJFA<TOk, TErr, UErr, UOk>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [Out] MEKCEIEFNPI<UOk, UErr> HEMCDHCKIGB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAE40", Offset = "0x2BD9640", VA = "0x182BDAE40")]
	public static bool FFLKEDCICNA<TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [Out][NotNullWhen(true)] TOk FJAIOLDBGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9190", Offset = "0x2BD7990", VA = "0x182BD9190")]
	public static bool CAEEPFNKDPD<TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [Out][NotNullWhen(true)] TErr BPJHAELLGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAEB0", Offset = "0x2BD96B0", VA = "0x182BDAEB0")]
	public static bool GKFENEIBJIO<TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [Out][NotNullWhen(true)] TOk FJAIOLDBGMK, [Out][NotNullWhen(false)] TErr BPJHAELLGKN) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB270", Offset = "0x2BD9A70", VA = "0x182BDB270")]
	public static bool JNMJLKEBBJI<TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [Out][NotNullWhen(true)] TOk FJAIOLDBGMK, [Out] MEKCEIEFNPI<TOk, TErr> HEMCDHCKIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9D90", Offset = "0x2BD8590", VA = "0x182BD9D90")]
	public static bool EPFLAEGBJFA<TOk, TErr, UErr, UOk>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [Out][NotNullWhen(true)] TOk FJAIOLDBGMK, [Out] MEKCEIEFNPI<UOk, UErr> HEMCDHCKIGB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDBC70", Offset = "0x2BDA470", VA = "0x182BDBC70")]
	public static bool PKICGAHOOBI<TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [Out][NotNullWhen(true)] TOk FJAIOLDBGMK, [Out] MEKCEIEFNPI<KNDENJDHONE, TErr> HEMCDHCKIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9510", Offset = "0x2BD7D10", VA = "0x182BD9510")]
	public static MEKCEIEFNPI<UOk, UErr> CLCAKOJNFNI<UOk, UErr, TOk, TErr>([In] this MEKCEIEFNPI<TOk, TErr> EGJINJKGIAK, [In] MEKCEIEFNPI<UOk, UErr> NOFEINPOGPG) where TOk : UOk where TErr : UErr
	{
		return default(MEKCEIEFNPI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8E20", Offset = "0x2BD7620", VA = "0x182BD8E20")]
	public static MEKCEIEFNPI<TOk?[]?, TErr?> BBDDFMLMLFL<TOk, TErr>(this IEnumerable<MEKCEIEFNPI<TOk, TErr>> EGJINJKGIAK)
	{
		return default(MEKCEIEFNPI<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KJLJBNEEKGP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x299C810", Offset = "0x299B010", VA = "0x18299C810")]
	public static MEKCEIEFNPI<TOk, T> LMNFDFBBNKE<TOk>([In] TOk FJAIOLDBGMK) where TOk : notnull
	{
		return default(MEKCEIEFNPI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x40A3EE0", Offset = "0x40A26E0", VA = "0x1840A3EE0")]
	public static MEKCEIEFNPI<KNDENJDHONE, T> LMNFDFBBNKE()
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x299C810", Offset = "0x299B010", VA = "0x18299C810")]
	public static MEKCEIEFNPI<T, TErr> ONOAMANMMNL<TErr>([In] TErr BPJHAELLGKN) where TErr : notnull
	{
		return default(MEKCEIEFNPI<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class MOCDJGEDIGE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct FFKOBCCFMFB : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly MOCDJGEDIGE<T> LJGDFLKDFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly int EKBMPIPDNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly bool HIBDFCEIGNG;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E28140", Offset = "0x1E26940", VA = "0x181E28140")]
		public FFKOBCCFMFB(MOCDJGEDIGE<T> LHMMDMHNIJC, int EOLPPEOMKIA, bool IIFEJPJMMAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1810", Offset = "0x3AE0010", VA = "0x183AE1810")]
		public MOCDJGEDIGE<T>.MBKIJBPDFIN ALKLFOKMKDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1910", Offset = "0x3AE0110", VA = "0x183AE1910", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1910", Offset = "0x3AE0110", VA = "0x183AE1910", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class MBKIJBPDFIN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly MOCDJGEDIGE<T> LJGDFLKDFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly int MNFPOEDLKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int PBBMGAMMMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly bool HIBDFCEIGNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool DBKCNGCHEJP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x4338DF0", Offset = "0x43375F0", VA = "0x184338DF0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x4338FC0", Offset = "0x43377C0", VA = "0x184338FC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x43391D0", Offset = "0x43379D0", VA = "0x1843391D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4339740", Offset = "0x4337F40", VA = "0x184339740")]
		public MBKIJBPDFIN(MOCDJGEDIGE<T> LHMMDMHNIJC, int EOLPPEOMKIA, bool IIFEJPJMMAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4338EB0", Offset = "0x43376B0", VA = "0x184338EB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4338F50", Offset = "0x4337750", VA = "0x184338F50", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NBODAPOLCPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NBODAPOLCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x440DBB0", Offset = "0x440C3B0", VA = "0x18440DBB0")]
		internal T GNBKHIKCGNL(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly T[] DBKOEJGMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int PBBMGAMMMGL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EOAOPDDEMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x43C1170", Offset = "0x43BF970", VA = "0x1843C1170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T APOKPICBEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3AC81C0", Offset = "0x3AC69C0", VA = "0x183AC81C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T AOCMNLBJEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x43C1100", Offset = "0x43BF900", VA = "0x1843C1100")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x43C0F40", Offset = "0x43BF740", VA = "0x1843C0F40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FDFCDEPBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x18B3CF0", Offset = "0x18B24F0", VA = "0x1818B3CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x110EDF0", Offset = "0x110D5F0", VA = "0x18110EDF0")]
	private static int NMCNHKCBLOH(int JBDLDJOINOF, int IDGMEKAEIMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x43C14E0", Offset = "0x43BFCE0", VA = "0x1843C14E0")]
	public MOCDJGEDIGE(int GGKCGCGFHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x43C11D0", Offset = "0x43BF9D0", VA = "0x1843C11D0")]
	public MOCDJGEDIGE(int GGKCGCGFHKJ, Func<T> PMOMFPOKDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x43C13A0", Offset = "0x43BFBA0", VA = "0x1843C13A0")]
	public MOCDJGEDIGE(T[] BFMOHBHIKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x43C1140", Offset = "0x43BF940", VA = "0x1843C1140")]
	public void LBFAKKFFNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x43C0DD0", Offset = "0x43BF5D0", VA = "0x1843C0DD0")]
	public IEnumerable<T> AAEJBFAPDLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x43C0EA0", Offset = "0x43BF6A0", VA = "0x1843C0EA0")]
	public MOCDJGEDIGE<T>.MBKIJBPDFIN ALKLFOKMKDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CE70", Offset = "0x3B6B670", VA = "0x183B6CE70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CE70", Offset = "0x3B6B670", VA = "0x183B6CE70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class PMLNLCPPGCE
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A570", Offset = "0x2C68D70", VA = "0x182C6A570")]
	public static MOCDJGEDIGE<T> OJFFIHPLODM<T>(int GGKCGCGFHKJ, Func<T> PMOMFPOKDPC) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F2D020", Offset = "0x1F2B820", VA = "0x181F2D020")]
		public RRColor(float KEIFIHHDEOD, float KDPFAJCONKP, float ICPBHPBDLLK, float NKCCEIKLOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6925FE0", Offset = "0x69247E0", VA = "0x186925FE0", Slot = "4")]
		public bool Equals(RRColor OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6926060", Offset = "0x6924860", VA = "0x186926060", Slot = "0")]
		public override bool Equals(object OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6926160", Offset = "0x6924960", VA = "0x186926160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69261E0", Offset = "0x69249E0", VA = "0x1869261E0", Slot = "5")]
		public string ToString(string NFAJBIAKHPK, IFormatProvider ALMMGGMHJHB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class NFCBIENEAKD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct PJBNMLLODBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly NFCBIENEAKD<T> PKLOAOBELOC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T JDDKPJKLOJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4662D70", Offset = "0x4661570", VA = "0x184662D70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4662D40", Offset = "0x4661540", VA = "0x184662D40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
		public PJBNMLLODBE(NFCBIENEAKD<T> PKLOAOBELOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PLLJLNLFNBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<PJBNMLLODBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NFCBIENEAKD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4667940", Offset = "0x4666140", VA = "0x184667940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B98070", Offset = "0x3B96870", VA = "0x183B98070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly SemaphoreSlim GDDFHFMFJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private T GILLLOLFBKN;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4429BA0", Offset = "0x44283A0", VA = "0x184429BA0")]
	public NFCBIENEAKD([In] T GILLLOLFBKN, int EJEOIJHLLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4429A10", Offset = "0x4428210", VA = "0x184429A10")]
	public NFCBIENEAKD([In] T GILLLOLFBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x44294F0", Offset = "0x4427CF0", VA = "0x1844294F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x44294B0", Offset = "0x4427CB0", VA = "0x1844294B0")]
	public PJBNMLLODBE DBIEFNCAJCK()
	{
		return default(PJBNMLLODBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4429680", Offset = "0x4427E80", VA = "0x184429680")]
	[AsyncStateMachine(typeof(NFCBIENEAKD<>.PLLJLNLFNBB))]
	public Task<NFCBIENEAKD<T>.PJBNMLLODBE> OCKNDPGNBEF(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4429530", Offset = "0x4427D30", VA = "0x184429530")]
	public void MFCMAMLFJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FJCABCPFNNA
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6923880", Offset = "0x6922080", VA = "0x186923880")]
	public static NFCBIENEAKD<KNDENJDHONE> OJFFIHPLODM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x28A7A00", Offset = "0x28A6200", VA = "0x1828A7A00")]
	public static NFCBIENEAKD<T> OJFFIHPLODM<T>([In] T GILLLOLFBKN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class CNGIKMHGHKK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct PHBFIDJEAIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly CNGIKMHGHKK<T> KCCMHDHBLEL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T JDDKPJKLOJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3BE92D0", Offset = "0x3BE7AD0", VA = "0x183BE92D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4658060", Offset = "0x4656860", VA = "0x184658060", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
		internal PHBFIDJEAIN(CNGIKMHGHKK<T> PKLOAOBELOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct GMMIMKMMPAM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly CNGIKMHGHKK<T> KCCMHDHBLEL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T JDDKPJKLOJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3BE92D0", Offset = "0x3BE7AD0", VA = "0x183BE92D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3BE9280", Offset = "0x3BE7A80", VA = "0x183BE9280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
		internal GMMIMKMMPAM(CNGIKMHGHKK<T> PKLOAOBELOC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LPBGPPAPPJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<GMMIMKMMPAM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CNGIKMHGHKK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NFCBIENEAKD<KNDENJDHONE>.PJBNMLLODBE <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<NFCBIENEAKD<KNDENJDHONE>.PJBNMLLODBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4171EA0", Offset = "0x41706A0", VA = "0x184171EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3B98070", Offset = "0x3B96870", VA = "0x183B98070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly NFCBIENEAKD<int> PDGEJEFFOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NFCBIENEAKD<KNDENJDHONE> DGPCCKELMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NFCBIENEAKD<KNDENJDHONE> NOKOLCOEOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T IJCHFMOMDLF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x50817A0", Offset = "0x507FFA0", VA = "0x1850817A0")]
	internal CNGIKMHGHKK(NFCBIENEAKD<int> JGNMKACEPEK, NFCBIENEAKD<KNDENJDHONE> OLIHLCLJCAJ, NFCBIENEAKD<KNDENJDHONE> PKEHJEEPJEE, [In] T GILLLOLFBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5080A80", Offset = "0x507F280", VA = "0x185080A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5080F80", Offset = "0x507F780", VA = "0x185080F80")]
	public PHBFIDJEAIN FJPNMKBHKGN()
	{
		return default(PHBFIDJEAIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x50816B0", Offset = "0x507FEB0", VA = "0x1850816B0")]
	public GMMIMKMMPAM IINHDBGECBD()
	{
		return default(GMMIMKMMPAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x50813A0", Offset = "0x507FBA0", VA = "0x1850813A0")]
	[AsyncStateMachine(typeof(CNGIKMHGHKK<>.LPBGPPAPPJP))]
	public Task<CNGIKMHGHKK<T>.GMMIMKMMPAM> FLLHFMDLJNM(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NLEKHGNBCIO
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6925720", Offset = "0x6923F20", VA = "0x186925720")]
	public static CNGIKMHGHKK<KNDENJDHONE> OJFFIHPLODM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8AB0", Offset = "0x2BE72B0", VA = "0x182BE8AB0")]
	public static CNGIKMHGHKK<T> OJFFIHPLODM<T>([In] T GILLLOLFBKN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LNLAJFCMPCI<TData> : PLHOCJDFICM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly string PJHOPJJKDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly TData IGFBHOELDIM;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
	public override string ILHCPMBLOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4168720", Offset = "0x4166F20", VA = "0x184168720")]
	internal LNLAJFCMPCI(string CLBGCJICGJG, [In] TData MLKNGAFFKGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class HFIENBJGNOG
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x69241B0", Offset = "0x69229B0", VA = "0x1869241B0")]
	public static LNLAJFCMPCI<KNDENJDHONE> OJFFIHPLODM(string CLBGCJICGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x289C620", Offset = "0x289AE20", VA = "0x18289C620")]
	public static LNLAJFCMPCI<TData> OJFFIHPLODM<TData>(string CLBGCJICGJG, [In] TData MLKNGAFFKGE) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LOIMGAHMBFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly Dictionary<object, float> MGOJPELCHEI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float BMMODDOEGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B1960", Offset = "0x8B0160", VA = "0x1808B1960")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA67080", Offset = "0xA65880", VA = "0x180A67080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6924B50", Offset = "0x6923350", VA = "0x186924B50")]
	public void IOHFIDJCCAN(float IPHHABIKCHD, object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6924BC0", Offset = "0x69233C0", VA = "0x186924BC0")]
	public void LLIKHMBMBAE(object OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6924B00", Offset = "0x6923300", VA = "0x186924B00")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6924C30", Offset = "0x6923430", VA = "0x186924C30")]
	private void NCHJCGOLILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6924D60", Offset = "0x6923560", VA = "0x186924D60")]
	public LOIMGAHMBFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class DKGIOEECPCP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HACFNHBEMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public HACFNHBEMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A810", Offset = "0x3C69010", VA = "0x183C6A810")]
		internal int EMNGNLNLEHP(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private HashSet<T>? OAGDNIFLANJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> FDIELPKLAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5774E70", Offset = "0x5773670", VA = "0x185774E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NHBHNCLDAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5775080", Offset = "0x5773880", VA = "0x185775080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84F0B0", Offset = "0x84D8B0", VA = "0x18084F0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84F0A0", Offset = "0x84D8A0", VA = "0x18084F0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5774C90", Offset = "0x5773490", VA = "0x185774C90")]
	public bool CNLMKNIMMKA(T OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5774EB0", Offset = "0x57736B0", VA = "0x185774EB0")]
	public bool GALPDKBCKMP(T OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5775030", Offset = "0x5773830", VA = "0x185775030")]
	public bool HFKAHFAOINF(T OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x57750D0", Offset = "0x57738D0", VA = "0x1857750D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public DKGIOEECPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PHMCAOLOCAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly string KOKMGOOGGID;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public PHMCAOLOCAA(string KOKMGOOGGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6925870", Offset = "0x6924070", VA = "0x186925870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class ADHBKFMFMPL
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class AMPKDPLDKCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AMPKDPLDKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6923640", Offset = "0x6921E40", VA = "0x186923640")]
		internal int EMNGNLNLEHP(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<object>? OAGDNIFLANJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> FDIELPKLAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6923280", Offset = "0x6921A80", VA = "0x186923280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NHBHNCLDAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6923410", Offset = "0x6921C10", VA = "0x186923410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84F0B0", Offset = "0x84D8B0", VA = "0x18084F0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x84F0A0", Offset = "0x84D8A0", VA = "0x18084F0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x69231A0", Offset = "0x69219A0", VA = "0x1869231A0")]
	public bool CNLMKNIMMKA(object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6923310", Offset = "0x6921B10", VA = "0x186923310")]
	public bool GALPDKBCKMP(object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69233B0", Offset = "0x6921BB0", VA = "0x1869233B0")]
	public bool HFKAHFAOINF(object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6923420", Offset = "0x6921C20", VA = "0x186923420")]
	public void PFNAJBNEJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6923490", Offset = "0x6921C90", VA = "0x186923490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ADHBKFMFMPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PGCEKNIGHHM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct NBHOLLIIKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float GDDPMDEKDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public T JDDKPJKLOJP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, NBHOLLIIKNO> MGOJPELCHEI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T AAIEBKFLFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x10225D0", Offset = "0x1020DD0", VA = "0x1810225D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1021BC0", Offset = "0x10203C0", VA = "0x181021BC0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? JJNEDGAGMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DKNPBHHPJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4653C80", Offset = "0x4652480", VA = "0x184653C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4654950", Offset = "0x4653150", VA = "0x184654950")]
	public bool IOHFIDJCCAN(T IPHHABIKCHD, object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x436E960", Offset = "0x436D160", VA = "0x18436E960")]
	public bool LLIKHMBMBAE(object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCE00", Offset = "0x3AFB600", VA = "0x183AFCE00")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4654050", Offset = "0x4652850", VA = "0x184654050")]
	public bool GFIHGBPIMCF(object OECMOOGGOOF, [Out] T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4655EF0", Offset = "0x46546F0", VA = "0x184655EF0")]
	[OHBLJHFIMOK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JKDLCFEAHHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x436EA10", Offset = "0x436D210", VA = "0x18436EA10")]
	public PGCEKNIGHHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class FLPNPIPMMNE<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<WeakReference<T>>? OAGDNIFLANJ;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NHBHNCLDAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3B03440", Offset = "0x3B01C40", VA = "0x183B03440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3B03290", Offset = "0x3B01A90", VA = "0x183B03290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3B02E50", Offset = "0x3B01650", VA = "0x183B02E50")]
	public void CNLMKNIMMKA(T OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B030E0", Offset = "0x3B018E0", VA = "0x183B030E0")]
	public void GALPDKBCKMP(T OECMOOGGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B03570", Offset = "0x3B01D70", VA = "0x183B03570")]
	public void PFNAJBNEJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3B035C0", Offset = "0x3B01DC0", VA = "0x183B035C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public FLPNPIPMMNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal static class EIEAECCBCKG
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2917B80", Offset = "0x2916380", VA = "0x182917B80")]
	public static void LOHHOEBFOIL<T>(this List<T> MAKDKEMHGGE, int JBDLDJOINOF) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface CJKBLONCKAL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EEBGOAJJAHA ECOEECLFMDK;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NAGOHFBEGAG : CJKBLONCKAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct JOGBGNKJICL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly float PPJONGAFJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly float AICBEBBPJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		internal readonly bool CPEGFNCLDBH;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float JAFNMFMLFDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6924460", Offset = "0x6922C60", VA = "0x186924460")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x69245E0", Offset = "0x6922DE0", VA = "0x1869245E0")]
		public JOGBGNKJICL(float CKMEAPHLBGJ, float KLHAFEOKDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6924470", Offset = "0x6922C70", VA = "0x186924470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class ADFKFGBAIIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NAGOHFBEGAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ADFKFGBAIIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6923100", Offset = "0x6921900", VA = "0x186923100")]
		internal void GFDHDGLBMPK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly int MELGOCPNHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private int FLJJJCBHGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CJKBLONCKAL[] NLOPHDPGOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly EEBGOAJJAHA[] NALLEMLECHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly JOGBGNKJICL[] GDOJCEGPDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private JOGBGNKJICL FDFGOLHJAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly JJOBFPIAHKI DACJFEKLIMO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EEBGOAJJAHA ECOEECLFMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6924F90", Offset = "0x6923790", VA = "0x186924F90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x69254D0", Offset = "0x6923CD0", VA = "0x1869254D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6925590", Offset = "0x6923D90", VA = "0x186925590")]
	public NAGOHFBEGAG(int MELGOCPNHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6924DF0", Offset = "0x69235F0", VA = "0x186924DF0")]
	public JJOBFPIAHKI DEBDOONHGPK(JOGBGNKJICL EMJPGPJNPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6925050", Offset = "0x6923850", VA = "0x186925050")]
	public void HMNPIFNCGIC(CJKBLONCKAL BCKNPLPOMHC, [Optional] JOGBGNKJICL JMLIEGEMCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6924E80", Offset = "0x6923680", VA = "0x186924E80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public delegate void EEBGOAJJAHA(float NIKAAMMCFGG);
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class CBOBBECMJDG
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class ABOCGABGGIJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly CJKBLONCKAL EKHBFAHDBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly EEBGOAJJAHA GLJPAFELCNE;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6923070", Offset = "0x6921870", VA = "0x186923070")]
		public ABOCGABGGIJ(CJKBLONCKAL EKHBFAHDBDN, EEBGOAJJAHA GLJPAFELCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6923020", Offset = "0x6921820", VA = "0x186923020", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69236F0", Offset = "0x6921EF0", VA = "0x1869236F0")]
	internal static bool EMJOGJEPIML(float NKCCEIKLOPK, float ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6918900", Offset = "0x6917100", VA = "0x186918900")]
	internal static float FFBPNEPAFJG(float NKCCEIKLOPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6923760", Offset = "0x6921F60", VA = "0x186923760")]
	public static IDisposable IONPDKHFDOA(this CJKBLONCKAL EKHBFAHDBDN, EEBGOAJJAHA GLJPAFELCNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JJOBFPIAHKI : CJKBLONCKAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private float NIKAAMMCFGG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public float NAGGKKBJLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6924230", Offset = "0x6922A30", VA = "0x186924230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event EEBGOAJJAHA? ECOEECLFMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6924320", Offset = "0x6922B20", VA = "0x186924320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x69243C0", Offset = "0x6922BC0", VA = "0x1869243C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public JJOBFPIAHKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FNNIJEPEGMM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x63C42D0", Offset = "0x63C2AD0", VA = "0x1863C42D0")]
	public FNNIJEPEGMM(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class BNCIFNJODBO<TKey, TValue> : POHKODFJGLE<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, KAGPKNIDCGA where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class BOBNFLHIFCA : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public BNCIFNJODBO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x10225D0", Offset = "0x1020DD0", VA = "0x1810225D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4D47730", Offset = "0x4D45F30", VA = "0x184D47730", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public BOBNFLHIFCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x39F6310", Offset = "0x39F4B10", VA = "0x1839F6310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4D47160", Offset = "0x4D45960", VA = "0x184D47160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4D47550", Offset = "0x4D45D50", VA = "0x184D47550")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4D468F0", Offset = "0x4D450F0", VA = "0x184D468F0")]
		private void LBICBBCOFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4D47640", Offset = "0x4D45E40", VA = "0x184D47640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly POHKODFJGLE<TKey, TValue> LBJFNEFDALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IDictionary<TKey, TValue> PCPFCCIMNBC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4D3CE50", Offset = "0x4D3B650", VA = "0x184D3CE50", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool HJHOCNCEBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public TValue EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4D3D030", Offset = "0x4D3B830", VA = "0x184D3D030", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4D3D2E0", Offset = "0x4D3BAE0", VA = "0x184D3D2E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> BPAFOBLIEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4D3D080", Offset = "0x4D3B880", VA = "0x184D3D080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TValue> OLMEJCHIBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4D3D1B0", Offset = "0x4D3B9B0", VA = "0x184D3D1B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4D3CCB0", Offset = "0x4D3B4B0", VA = "0x184D3CCB0")]
	public BNCIFNJODBO(POHKODFJGLE<TKey, TValue> LBJFNEFDALD, [Optional] IDictionary<TKey, TValue>? PCPFCCIMNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4D3A4F0", Offset = "0x4D38CF0", VA = "0x184D3A4F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4D3B1A0", Offset = "0x4D399A0", VA = "0x184D3B1A0")]
	public void FHGLCJKPACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4D3A180", Offset = "0x4D38980", VA = "0x184D3A180", Slot = "9")]
	public void Add(TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4D3B720", Offset = "0x4D39F20", VA = "0x184D3B720")]
	public void JEDFBDJCEPB(TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4D3AF20", Offset = "0x4D39720", VA = "0x184D3AF20")]
	public void EODHKDHPHBD(TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4D3BCC0", Offset = "0x4D3A4C0", VA = "0x184D3BCC0")]
	public void KMKFJHOEIAM(TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4D3BA90", Offset = "0x4D3A290", VA = "0x184D3BA90")]
	public void KCAIMPFCOJO(TKey JOEHGGMHBAA, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4D3C310", Offset = "0x4D3AB10", VA = "0x184D3C310", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> ECMCDEIDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4D3C500", Offset = "0x4D3AD00", VA = "0x184D3C500", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4D3C860", Offset = "0x4D3B060", VA = "0x184D3C860", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4D3A630", Offset = "0x4D38E30", VA = "0x184D3A630", Slot = "8")]
	public bool ContainsKey(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4D3A420", Offset = "0x4D38C20", VA = "0x184D3A420")]
	public bool CJOAHMBABME(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4D3AE50", Offset = "0x4D39650", VA = "0x184D3AE50")]
	public bool EIGFJGKJJPO(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4D3C050", Offset = "0x4D3A850", VA = "0x184D3C050", Slot = "10")]
	public bool Remove(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4D3CB00", Offset = "0x4D3B300", VA = "0x184D3CB00", Slot = "11")]
	public bool TryGetValue(TKey JOEHGGMHBAA, [Out] TValue IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4D3A700", Offset = "0x4D38F00", VA = "0x184D3A700", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] JAOFFCELONG, int FAIGDKFEIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x402F910", Offset = "0x402E110", VA = "0x18402F910", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4D3B580", Offset = "0x4D39D80", VA = "0x184D3B580", Slot = "19")]
	[IteratorStateMachine(typeof(BNCIFNJODBO<, >.BOBNFLHIFCA))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4D3B680", Offset = "0x4D39E80", VA = "0x184D3B680", Slot = "21")]
	public bool JECKPKAGOPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4D3B3C0", Offset = "0x4D39BC0", VA = "0x184D3B3C0")]
	private TValue FOCKJOLHOHB(TKey JOEHGGMHBAA)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KAGPKNIDCGA
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JECKPKAGOPD();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface POHKODFJGLE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KAGPKNIDCGA
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public sealed class CBPJIEKGGMD<TKey, TVal> : POHKODFJGLE<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KAGPKNIDCGA where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public delegate int MHKPDPFLLMA(TKey JOEHGGMHBAA, TVal IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate void JILCJBAHNMH(TKey JOEHGGMHBAA, TVal IPHHABIKCHD, IADPNJPOJEP DAGAMHLIEBK);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class EOKBPBILLIE
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public TKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TVal JDDKPJKLOJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8B8E10", Offset = "0x8B7610", VA = "0x1808B8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int JAFNMFMLFDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x882440", Offset = "0x880C40", VA = "0x180882440")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x881B20", Offset = "0x880320", VA = "0x180881B20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public DateTimeOffset LLILLHGBMFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xBF3E20", Offset = "0xBF2620", VA = "0x180BF3E20")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x14A7A10", Offset = "0x14A6210", VA = "0x1814A7A10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x376F650", Offset = "0x376DE50", VA = "0x18376F650")]
		public EOKBPBILLIE(TKey JOEHGGMHBAA, TVal FCGMGAOCKCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class OABGGJABHNF : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CBPJIEKGGMD<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private LinkedList<EOKBPBILLIE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x10225D0", Offset = "0x1020DD0", VA = "0x1810225D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x39F9870", Offset = "0x39F8070", VA = "0x1839F9870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public OABGGJABHNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x39F0F30", Offset = "0x39EF730", VA = "0x1839F0F30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4534D40", Offset = "0x4533540", VA = "0x184534D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x45367F0", Offset = "0x4534FF0", VA = "0x1845367F0")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4536850", Offset = "0x4535050", VA = "0x184536850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public const int HGFCDBGHBIP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Dictionary<TKey, LinkedListNode<EOKBPBILLIE>> BEBOOFOIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly LinkedList<EOKBPBILLIE> EOHMJIALPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MHKPDPFLLMA? PFFMOINACPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TimeSpan ICIKLHOIDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly JILCJBAHNMH? KLDFBEACOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly FNGFBHPFCDF GLIOPOHHPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool KOKONJJMHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly List<TKey> AKHOLFMLMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<TVal> LKGCLDJJIOG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FJDDEBMGINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x852490", Offset = "0x850C90", VA = "0x180852490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int MKJKMJPIGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAC6BF0", Offset = "0xAC53F0", VA = "0x180AC6BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAC6810", Offset = "0xAC5010", VA = "0x180AC6810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4E847D0", Offset = "0x4E82FD0", VA = "0x184E847D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	internal int DANFFKLEDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3AFCE00", Offset = "0x3AFB600", VA = "0x183AFCE00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public ICollection<TVal> OLMEJCHIBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4E84A20", Offset = "0x4E83220", VA = "0x184E84A20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ICollection<TKey> IDictionary<TKey, TVal>.HCOMDIKKHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4E7E270", Offset = "0x4E7CA70", VA = "0x184E7E270", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HJHOCNCEBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public TVal EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4E84920", Offset = "0x4E83120", VA = "0x184E84920", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4E84AB0", Offset = "0x4E832B0", VA = "0x184E84AB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DAB0", Offset = "0x4E6C2B0", VA = "0x184E6DAB0")]
	private bool FIAGNBCEPIO(int MELGOCPNHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4E669D0", Offset = "0x4E651D0", VA = "0x184E669D0")]
	private void CIEIKMJEMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4E81770", Offset = "0x4E7FF70", VA = "0x184E81770")]
	public CBPJIEKGGMD(int MELGOCPNHFM, [Optional] MHKPDPFLLMA? PFFMOINACPH, [Optional] IEqualityComparer<TKey>? MGHGMPIHICE, [Optional] JILCJBAHNMH? KLDFBEACOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4E7FC10", Offset = "0x4E7E410", VA = "0x184E7FC10")]
	public CBPJIEKGGMD(TimeSpan ICIKLHOIDOK, [Optional] IEqualityComparer<TKey>? MGHGMPIHICE, [Optional] JILCJBAHNMH? KLDFBEACOLE, [Optional] FNGFBHPFCDF? GLIOPOHHPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4E7F630", Offset = "0x4E7DE30", VA = "0x184E7F630")]
	public CBPJIEKGGMD(int MELGOCPNHFM, TimeSpan ICIKLHOIDOK, [Optional] IEqualityComparer<TKey>? MGHGMPIHICE, [Optional] JILCJBAHNMH? KLDFBEACOLE, [Optional] FNGFBHPFCDF? GLIOPOHHPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x4E81930", Offset = "0x4E80130", VA = "0x184E81930")]
	public CBPJIEKGGMD(int MELGOCPNHFM, MHKPDPFLLMA? PFFMOINACPH, TimeSpan ICIKLHOIDOK, [Optional] IEqualityComparer<TKey>? MGHGMPIHICE, [Optional] JILCJBAHNMH? KLDFBEACOLE, [Optional] FNGFBHPFCDF? GLIOPOHHPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4E712E0", Offset = "0x4E6FAE0", VA = "0x184E712E0", Slot = "21")]
	public bool JECKPKAGOPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C230", Offset = "0x4E7AA30", VA = "0x184E7C230", Slot = "22")]
	public bool OKBHDIMEDCK(int GGKCGCGFHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4E76A30", Offset = "0x4E75230", VA = "0x184E76A30")]
	private bool MCBMAOLIODL(int GGKCGCGFHKJ, IADPNJPOJEP DAGAMHLIEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x4E71E50", Offset = "0x4E70650", VA = "0x184E71E50")]
	public void KAMKODPJIMO(TKey JOEHGGMHBAA, TVal IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4E610D0", Offset = "0x4E5F8D0", VA = "0x184E610D0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ECMCDEIDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4E60F50", Offset = "0x4E5F750", VA = "0x184E60F50", Slot = "9")]
	public void Add(TKey JOEHGGMHBAA, TVal IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4E692F0", Offset = "0x4E67AF0", VA = "0x184E692F0", Slot = "8")]
	public bool ContainsKey(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D990", Offset = "0x4E7C190", VA = "0x184E7D990", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CF90", Offset = "0x4E7B790", VA = "0x184E7CF90", Slot = "10")]
	public bool Remove(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4E7DEB0", Offset = "0x4E7C6B0", VA = "0x184E7DEB0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x4E74D50", Offset = "0x4E73550", VA = "0x184E74D50")]
	private bool LIMCENFGDCJ(TKey JOEHGGMHBAA, [Out] TVal IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4E7B070", Offset = "0x4E79870", VA = "0x184E7B070")]
	private TVal NBGKOOJKKKA(TKey DIODKLJFBKA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4E7EF90", Offset = "0x4E7D790", VA = "0x184E7EF90", Slot = "11")]
	public bool TryGetValue(TKey DIODKLJFBKA, [Out] TVal IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4E68EB0", Offset = "0x4E676B0", VA = "0x184E68EB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C3C0", Offset = "0x4E6ABC0", VA = "0x184E6C3C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] JAOFFCELONG, int FAIGDKFEIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4E6CFF0", Offset = "0x4E6B7F0", VA = "0x184E6CFF0")]
	private void DBGLBOJPIKA(TKey JOEHGGMHBAA, TVal FCGMGAOCKCN, IADPNJPOJEP DAGAMHLIEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4E71F90", Offset = "0x4E70790", VA = "0x184E71F90")]
	private bool LHEAKBFBNGB(EOKBPBILLIE LLFAGLDHMCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4E61910", Offset = "0x4E60110", VA = "0x184E61910")]
	private void BIEEGHOILGB(LinkedListNode<EOKBPBILLIE> AAKFGHIPFBA, TVal MKIPENAKAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4E6E8F0", Offset = "0x4E6D0F0", VA = "0x184E6E8F0")]
	private void IOHFIDJCCAN(TKey JOEHGGMHBAA, TVal IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4E67750", Offset = "0x4E65F50", VA = "0x184E67750")]
	private void CJJJFJBJFFK(EOKBPBILLIE LLFAGLDHMCM, TVal MKIPENAKAOC, int BHDGLHEOELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DB00", Offset = "0x4E6C300", VA = "0x184E6DB00", Slot = "19")]
	[IteratorStateMachine(typeof(CBPJIEKGGMD<, >.OABGGJABHNF))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E2C0", Offset = "0x4E7CAC0", VA = "0x184E7E2C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum IADPNJPOJEP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class OBFCKNKJDKB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly TKey PGLMFNFCFIK;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x453DC20", Offset = "0x453C420", VA = "0x18453DC20")]
	public OBFCKNKJDKB(TKey KDLOJGADBPL, Exception JFLEAGGNHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class IHNPMNEEEJM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5CC29F0", Offset = "0x5CC11F0", VA = "0x185CC29F0")]
	public IHNPMNEEEJM(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class BBDHGHHNKHH<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class DGPLFCLAJNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BBDHGHHNKHH<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public DGPLFCLAJNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x56F5410", Offset = "0x56F3C10", VA = "0x1856F5410")]
		internal Task<TResource> NPLNNJANFOO(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct KFANLNIJIEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public BBDHGHHNKHH<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4088900", Offset = "0x4087100", VA = "0x184088900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4089200", Offset = "0x4087A00", VA = "0x184089200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct OBLPGGDBFOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x453F000", Offset = "0x453D800", VA = "0x18453F000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x453F6E0", Offset = "0x453DEE0", VA = "0x18453F6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly FOGNPGAPKMM<TId, Task<TResource>> DOHCKPJMKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> CCNBNILDOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? MLJGCGDDPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Action<TResource>? NBGJJBOFCEM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4D17580", Offset = "0x4D15D80", VA = "0x184D17580")]
	public BBDHGHHNKHH(int GAPGEKFLOJH = 0, [Optional] IEqualityComparer<TId>? AJLIJPOILMI, [Optional] Func<TId, CancellationToken, Task<TResource>>? HABCLEFLPKI, [Optional] Action<TResource>? HODNJHABAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4D16350", Offset = "0x4D14B50", VA = "0x184D16350")]
	public HHIKLOPOAIH<Task<TResource>> CDLJBHELEOK(TId EGNLNANJFMI, [Optional] Func<TId, CancellationToken, Task<TResource>>? HABCLEFLPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4D16F60", Offset = "0x4D15760", VA = "0x184D16F60")]
	private void LDFLPKEEIGJ(Task<TResource> GECIOHOBBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4D17190", Offset = "0x4D15990", VA = "0x184D17190")]
	[AsyncStateMachine(typeof(BBDHGHHNKHH<, >.KFANLNIJIEE))]
	private Task OBPCGGIBGHM(Task<TResource> GECIOHOBBCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4D16910", Offset = "0x4D15110", VA = "0x184D16910")]
	public void FDNPIMLJAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x4D16250", Offset = "0x4D14A50", VA = "0x184D16250")]
	public FOGNPGAPKMM<TId, Task<TResource>>.FKPPFOEBEEK ALKLFOKMKDP()
	{
		return default(FOGNPGAPKMM<TId, Task<TResource>>.FKPPFOEBEEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4D174E0", Offset = "0x4D15CE0", VA = "0x184D174E0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4D174E0", Offset = "0x4D15CE0", VA = "0x184D174E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4D16AA0", Offset = "0x4D152A0", VA = "0x184D16AA0")]
	[AsyncStateMachine(typeof(BBDHGHHNKHH<, >.OBLPGGDBFOL))]
	[CompilerGenerated]
	internal static Task IGOEKOAJADH(Task<TResource> GECIOHOBBCH, CancellationTokenSource CHMDHDGNDPD, Dictionary<Task<TResource>, CancellationTokenSource> MJHMGDNMGFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FOGNPGAPKMM<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private sealed class EIJKAAJNDEJ : IEquatable<EIJKAAJNDEJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly TValue JDDKPJKLOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int HFPFBJGDIPJ;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9196A0", Offset = "0x917EA0", VA = "0x1809196A0")]
		public EIJKAAJNDEJ(TValue IPHHABIKCHD, int GGODKMKCGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3756950", Offset = "0x3755150", VA = "0x183756950", Slot = "4")]
		public bool Equals(EIJKAAJNDEJ? OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x37568A0", Offset = "0x37550A0", VA = "0x1837568A0", Slot = "0")]
		public override bool Equals(object? GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3756A70", Offset = "0x3755270", VA = "0x183756A70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct FKPPFOEBEEK : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<TKey, EIJKAAJNDEJ>.Enumerator KJHNNBFHHHP;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF510", Offset = "0x3AFDD10", VA = "0x183AFF510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public (TKey Key, TValue Value, int RefCount) APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF9C0", Offset = "0x3AFE1C0", VA = "0x183AFF9C0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF800", Offset = "0x3AFE000", VA = "0x183AFF800")]
		public FKPPFOEBEEK(FOGNPGAPKMM<TKey, TValue> MGOJPELCHEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF150", Offset = "0x3AFD950", VA = "0x183AFF150", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF1D0", Offset = "0x3AFD9D0", VA = "0x183AFF1D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF300", Offset = "0x3AFDB00", VA = "0x183AFF300", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class FAGFBDGLAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public FOGNPGAPKMM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public EIJKAAJNDEJ refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FAGFBDGLAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB5A0", Offset = "0x3AC9DA0", VA = "0x183ACB5A0")]
		internal void NPLNNJANFOO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<TKey, EIJKAAJNDEJ> FMNCNNDPICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Func<TKey, TValue>? IOOIGPOIKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Action<TValue>? DPLEMINLPGF;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3B193E0", Offset = "0x3B17BE0", VA = "0x183B193E0")]
	public FOGNPGAPKMM(int GAPGEKFLOJH = 0, [Optional] IEqualityComparer<TKey>? MGHGMPIHICE, [Optional] Func<TKey, TValue>? PFEJOCDHMKF, [Optional] Action<TValue>? GLCBKPCDJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3B17E10", Offset = "0x3B16610", VA = "0x183B17E10")]
	public HHIKLOPOAIH<TValue> CDLJBHELEOK(TKey JOEHGGMHBAA, [Optional] Func<TKey, TValue>? CLABPHMMLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3B188E0", Offset = "0x3B170E0", VA = "0x183B188E0")]
	private void CHEAPHHCLBO(TKey JOEHGGMHBAA, EIJKAAJNDEJ HAPCBHPODCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3B18FD0", Offset = "0x3B177D0", VA = "0x183B18FD0")]
	public void FDNPIMLJAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3B17DD0", Offset = "0x3B165D0", VA = "0x183B17DD0")]
	public FKPPFOEBEEK ALKLFOKMKDP()
	{
		return default(FKPPFOEBEEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3B191F0", Offset = "0x3B179F0", VA = "0x183B191F0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3B191F0", Offset = "0x3B179F0", VA = "0x183B191F0", Slot = "5")]
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
