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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F1BD10", Offset = "0x6F1B110", VA = "0x186F1BD10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MCDFMPHCDMI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	protected MCDFMPHCDMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DGKCPBMMODP<T> : MCDFMPHCDMI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LCJCACLGMOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum IFHPIKPMMAG
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
		public IFHPIKPMMAG JLNNFEOBAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T FJBAKNFCPGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int DNPEGEKONAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool KEJDIOKFOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KCPIHADCOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB100", Offset = "0x6CA500")]
	protected List<T> MMPHJFCKKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB160", Offset = "0x6CA560")]
	private List<LCJCACLGMOK> FOAMAAGEPAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NFNLKPEONEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3052690", Offset = "0x3051A90", VA = "0x183052690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x30529B0", Offset = "0x3051DB0", VA = "0x1830529B0")]
	protected DGKCPBMMODP(bool KCPIHADCOBL, bool KEJDIOKFOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30526D0", Offset = "0x3051AD0", VA = "0x1830526D0")]
	protected bool LEMOFDPFJAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x30525D0", Offset = "0x30519D0", VA = "0x1830525D0")]
	protected void FAGMICKGOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30522C0", Offset = "0x30516C0", VA = "0x1830522C0")]
	protected void EBDGLIODCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21C6A10", Offset = "0x21C5E10", VA = "0x1821C6A10")]
	private static void KKFAJIMCGOC<U>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB1C0", Offset = "0x6CA5C0")] ref List<U?>? OCCNFAKIALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3052470", Offset = "0x3051870", VA = "0x183052470", Slot = "4")]
	public void EBOHBLNDMAL(T FJBAKNFCPGP, bool HJIDJJJHHJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3052750", Offset = "0x3051B50", VA = "0x183052750", Slot = "5")]
	public void PBDAKCGNFND(T FJBAKNFCPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x30528A0", Offset = "0x3051CA0", VA = "0x1830528A0")]
	public void PEHJALIONDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EIDBNOCJPAI
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBOHBLNDMAL(Action FJBAKNFCPGP, bool HJIDJJJHHJI = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBDAKCGNFND(Action FJBAKNFCPGP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB240", Offset = "0x6CA640")]
public sealed class LNCHJMFHBFC : DGKCPBMMODP<Action>, EIDBNOCJPAI
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BC20", Offset = "0x6F1B020", VA = "0x186F1BC20")]
	public LNCHJMFHBFC(bool KCPIHADCOBL = false, bool KEJDIOKFOFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B950", Offset = "0x6F1AD50", VA = "0x186F1B950")]
	public void GDOLIKHHLHI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BBC0", Offset = "0x6F1AFC0", VA = "0x186F1BBC0")]
	public static LNCHJMFHBFC PPNKFAMNDAO(LNCHJMFHBFC HFEOMBHHHBH, Action FJBAKNFCPGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BB60", Offset = "0x6F1AF60", VA = "0x186F1BB60")]
	public static LNCHJMFHBFC JCNKLHFINDD(LNCHJMFHBFC HFEOMBHHHBH, Action FJBAKNFCPGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PIEOPKAAPFM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBOHBLNDMAL(Action<T> FJBAKNFCPGP, bool HJIDJJJHHJI = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBDAKCGNFND(Action<T> FJBAKNFCPGP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB2B0", Offset = "0x6CA6B0")]
public sealed class AIFAKKEFFHF<T> : DGKCPBMMODP<Action<T>>, PIEOPKAAPFM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A358A0", Offset = "0x2A34CA0", VA = "0x182A358A0")]
	public AIFAKKEFFHF(bool KCPIHADCOBL = false, bool KEJDIOKFOFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A35310", Offset = "0x2A34710", VA = "0x182A35310")]
	public void GDOLIKHHLHI(T CECLOGMADIP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A35810", Offset = "0x2A34C10", VA = "0x182A35810")]
	public static AIFAKKEFFHF<T> PPNKFAMNDAO(AIFAKKEFFHF<T> HFEOMBHHHBH, Action<T> FJBAKNFCPGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A35780", Offset = "0x2A34B80", VA = "0x182A35780")]
	public static AIFAKKEFFHF<T> JCNKLHFINDD(AIFAKKEFFHF<T> HFEOMBHHHBH, Action<T> FJBAKNFCPGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KBPHFEEDDKK<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB320", Offset = "0x6CA720")]
public sealed class CNIAKPFLJLG<T, U> : DGKCPBMMODP<Action<T, U>>, KBPHFEEDDKK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A358A0", Offset = "0x2A34CA0", VA = "0x182A358A0")]
	public CNIAKPFLJLG(bool KCPIHADCOBL = false, bool KEJDIOKFOFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC810", Offset = "0x2BFBC10", VA = "0x182BFC810")]
	public void GDOLIKHHLHI(T CECLOGMADIP, U ENOMIPCIFIK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2A35810", Offset = "0x2A34C10", VA = "0x182A35810")]
	public static CNIAKPFLJLG<T, U> PPNKFAMNDAO(CNIAKPFLJLG<T, U> HFEOMBHHHBH, Action<T, U> FJBAKNFCPGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2A35780", Offset = "0x2A34B80", VA = "0x182A35780")]
	public static CNIAKPFLJLG<T, U> JCNKLHFINDD(CNIAKPFLJLG<T, U> HFEOMBHHHBH, Action<T, U> FJBAKNFCPGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB390", Offset = "0x6CA790")]
public sealed class NNPHLAIKNOD<T, U, V> : DGKCPBMMODP<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2A358A0", Offset = "0x2A34CA0", VA = "0x182A358A0")]
	public NNPHLAIKNOD(bool KCPIHADCOBL = false, bool KEJDIOKFOFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2AA38C0", Offset = "0x2AA2CC0", VA = "0x182AA38C0")]
	public void GDOLIKHHLHI(T CECLOGMADIP, U ENOMIPCIFIK, V GCKJNKPJMJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2A35810", Offset = "0x2A34C10", VA = "0x182A35810")]
	public static NNPHLAIKNOD<T, U, V> PPNKFAMNDAO(NNPHLAIKNOD<T, U, V> HFEOMBHHHBH, Action<T, U, V> FJBAKNFCPGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A35780", Offset = "0x2A34B80", VA = "0x182A35780")]
	public static NNPHLAIKNOD<T, U, V> JCNKLHFINDD(NNPHLAIKNOD<T, U, V> HFEOMBHHHBH, Action<T, U, V> FJBAKNFCPGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DBKCJOGBPGE<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB400", Offset = "0x6CA800")]
public sealed class OENHMINGLFK<T, U, V, W> : DGKCPBMMODP<Action<T, U, V, W>>, DBKCJOGBPGE<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2A358A0", Offset = "0x2A34CA0", VA = "0x182A358A0")]
	public OENHMINGLFK(bool KCPIHADCOBL = false, bool KEJDIOKFOFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2F2CCA0", Offset = "0x2F2C0A0", VA = "0x182F2CCA0")]
	public void GDOLIKHHLHI(T CECLOGMADIP, U ENOMIPCIFIK, V GCKJNKPJMJF, W EFCIMGFJGNL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2A35810", Offset = "0x2A34C10", VA = "0x182A35810")]
	public static OENHMINGLFK<T, U, V, W> PPNKFAMNDAO(OENHMINGLFK<T, U, V, W> HFEOMBHHHBH, Action<T, U, V, W> FJBAKNFCPGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2A35780", Offset = "0x2A34B80", VA = "0x182A35780")]
	public static OENHMINGLFK<T, U, V, W> JCNKLHFINDD(OENHMINGLFK<T, U, V, W> HFEOMBHHHBH, Action<T, U, V, W> FJBAKNFCPGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB470", Offset = "0x6CA870")]
public sealed class CPPCBNJBABL<T, U, V, W, X> : DGKCPBMMODP<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A358A0", Offset = "0x2A34CA0", VA = "0x182A358A0")]
	public CPPCBNJBABL(bool KCPIHADCOBL = false, bool KEJDIOKFOFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C05DF0", Offset = "0x2C051F0", VA = "0x182C05DF0")]
	public void GDOLIKHHLHI(T CECLOGMADIP, U ENOMIPCIFIK, V GCKJNKPJMJF, W EFCIMGFJGNL, X GEAEMIOLNKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A35810", Offset = "0x2A34C10", VA = "0x182A35810")]
	public static CPPCBNJBABL<T, U, V, W, X> PPNKFAMNDAO(CPPCBNJBABL<T, U, V, W, X> HFEOMBHHHBH, Action<T, U, V, W, X> FJBAKNFCPGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A35780", Offset = "0x2A34B80", VA = "0x182A35780")]
	public static CPPCBNJBABL<T, U, V, W, X> JCNKLHFINDD(CPPCBNJBABL<T, U, V, W, X> HFEOMBHHHBH, Action<T, U, V, W, X> FJBAKNFCPGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB4E0", Offset = "0x6CA8E0")]
public sealed class OPHKHMFDBJA<T, U, V, W, X, Y> : DGKCPBMMODP<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A358A0", Offset = "0x2A34CA0", VA = "0x182A358A0")]
	public OPHKHMFDBJA(bool KCPIHADCOBL = false, bool KEJDIOKFOFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5A74A80", Offset = "0x5A73E80", VA = "0x185A74A80")]
	public void GDOLIKHHLHI(T CECLOGMADIP, U ENOMIPCIFIK, V GCKJNKPJMJF, W EFCIMGFJGNL, X GEAEMIOLNKK, Y KFMHCNGHPHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A35810", Offset = "0x2A34C10", VA = "0x182A35810")]
	public static OPHKHMFDBJA<T, U, V, W, X, Y> PPNKFAMNDAO(OPHKHMFDBJA<T, U, V, W, X, Y> HFEOMBHHHBH, Action<T, U, V, W, X, Y> FJBAKNFCPGP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A35780", Offset = "0x2A34B80", VA = "0x182A35780")]
	public static OPHKHMFDBJA<T, U, V, W, X, Y> JCNKLHFINDD(OPHKHMFDBJA<T, U, V, W, X, Y> HFEOMBHHHBH, Action<T, U, V, W, X, Y> FJBAKNFCPGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class GCOABNGNKLA : FMOECAIIOJO
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static bool POLIHCDMHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly string? HGFMLBCFKJA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public virtual FMOECAIIOJO? PPPGIFCHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AB90", Offset = "0x6F19F90", VA = "0x186F1AB90")]
	protected GCOABNGNKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string APIKMAODCDM();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A760", Offset = "0x6F19B60", VA = "0x186F1A760", Slot = "8")]
	public virtual string LPIAIFIJNMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A7E0", Offset = "0x6F19BE0", VA = "0x186F1A7E0", Slot = "9")]
	public void PJNHALCOKJF(StringBuilder FBNNLJMDHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A500", Offset = "0x6F19900", VA = "0x186F1A500", Slot = "10")]
	public void AJKJDFABFMK(StringBuilder FBNNLJMDHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AA70", Offset = "0x6F19E70", VA = "0x186F1AA70", Slot = "11")]
	public void PLACMAHAAFN(StringBuilder FBNNLJMDHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A600", Offset = "0x6F19A00", VA = "0x186F1A600", Slot = "12")]
	public void ENMFNGIDJJG(StringBuilder FBNNLJMDHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A560", Offset = "0x6F19960", VA = "0x186F1A560")]
	public static void AKBMIEAAIPD(StringBuilder FBNNLJMDHID, string CIDIPJNLOCI, string DDHGDBHLBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1245790", Offset = "0x1244B90", VA = "0x181245790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KOFEPOMPCPN<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HOHNNBBNAEB<TKey, TVal> DNLPBMIBDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB5F0", Offset = "0x6CA9F0")]
	internal readonly Dictionary<TKey, (TVal value, int size)> KICLCONAGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly int GGJKKGIJIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB6C0", Offset = "0x6CAAC0")]
	private readonly HOHNNBBNAEB<TKey, TVal>.JMPPHADGFHD KKJFHMKCBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int CPEKDIFIANP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal int JPGKIKJIMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2219C50", Offset = "0x2219050", VA = "0x182219C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HFFNLLDDLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x221A2D0", Offset = "0x22196D0", VA = "0x18221A2D0")]
	public KOFEPOMPCPN(int GGJKKGIJIDA, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB720", Offset = "0x6CAB20")] HOHNNBBNAEB<TKey, TVal>.JMPPHADGFHD KKJFHMKCBCO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB780", Offset = "0x6CAB80")] IEqualityComparer<TKey> CKJMACJNBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2219EF0", Offset = "0x22192F0", VA = "0x182219EF0")]
	public void IJKCMHAMEBO(TKey KOFPKIJDAMC, TVal KKIAKNLLHIO, bool CHPDJMGOFIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2219DC0", Offset = "0x22191C0", VA = "0x182219DC0")]
	public bool FIPIJJGNGAN(TKey KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2219E40", Offset = "0x2219240", VA = "0x182219E40")]
	public bool HPMOKKNEDOE(TKey JAAPKECBADL, out TVal KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x221A100", Offset = "0x2219500", VA = "0x18221A100")]
	private void MDKKKKGDNOG(TKey KOFPKIJDAMC, TVal KKIAKNLLHIO, int JECAINLJFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2219C90", Offset = "0x2219090", VA = "0x182219C90")]
	public bool FFGOHAEBFMH(TKey KOFPKIJDAMC, TVal KKIAKNLLHIO, bool CHPDJMGOFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x221A060", Offset = "0x2219460", VA = "0x18221A060")]
	private bool LOKGNNMKMNN(TKey KOFPKIJDAMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DIJMJGOCOPC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F19850", Offset = "0x6F18C50", VA = "0x186F19850")]
	public DIJMJGOCOPC(string HGJHDPGFLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EHNCOCLGOIL<TErr> : DIJMJGOCOPC where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly TErr BHFLICJGAPO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E200", Offset = "0x2E6D600", VA = "0x182E6E200")]
	private EHNCOCLGOIL(in TErr AFGDINFMGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E130", Offset = "0x2E6D530", VA = "0x182E6E130")]
	public static EHNCOCLGOIL<TErr> OHIOHLNJBHE(in TErr AFGDINFMGHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public sealed class HOHNNBBNAEB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int JMPPHADGFHD(TKey KOFPKIJDAMC, TVal KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class AKJODPFJAHG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TKey HFAPGGDMKBD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9CDA70", Offset = "0x9CCE70", VA = "0x1809CDA70")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public TVal EEMAOFBHODN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int FMHNBEKGHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB7A4F0", Offset = "0xB798F0", VA = "0x180B7A4F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB945B0", Offset = "0xB939B0", VA = "0x180B945B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DateTime KFIBEGPJOFO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xB9A7F0", Offset = "0xB99BF0", VA = "0x180B9A7F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x30F1C20", Offset = "0x30F1020", VA = "0x1830F1C20")]
		public AKJODPFJAHG(TKey KOFPKIJDAMC, TVal CPAHGHLMHEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ACDJHFBNBND : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBE50", Offset = "0x6CB250")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public HOHNNBBNAEB<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBEB0", Offset = "0x6CB2B0")]
		private LinkedList<HOHNNBBNAEB<TKey, TVal>.AKJODPFJAHG>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AKJODPFJAHG <cacheEntry>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x1397B20", Offset = "0x1396F20", VA = "0x181397B20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3971AD0", Offset = "0x3970ED0", VA = "0x183971AD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1A389D0", Offset = "0x1A37DD0", VA = "0x181A389D0")]
		[DebuggerHidden]
		public ACDJHFBNBND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2027A50", Offset = "0x2026E50", VA = "0x182027A50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3971250", Offset = "0x3970650", VA = "0x183971250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3970B60", Offset = "0x396FF60", VA = "0x183970B60")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x39719C0", Offset = "0x3970DC0", VA = "0x1839719C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const int CIJIFJONOIE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB840", Offset = "0x6CAC40")]
	private readonly Dictionary<TKey, LinkedListNode<HOHNNBBNAEB<TKey, TVal>.AKJODPFJAHG>> PHLBLJAPCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB8A0", Offset = "0x6CACA0")]
	private readonly LinkedList<HOHNNBBNAEB<TKey, TVal>.AKJODPFJAHG> ENLJABIJGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB900", Offset = "0x6CAD00")]
	private readonly HOHNNBBNAEB<TKey, TVal>.JMPPHADGFHD KKJFHMKCBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly TimeSpan CBMHLBBIDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly OCNCPDJOIDH HIGDDCPHKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private bool IKHAEAJOLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly List<TKey> BIIHIOCIGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly List<TVal> MNPODODFLLO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HFFNLLDDLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A00", Offset = "0x8D0E00", VA = "0x1808D1A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal int JPGKIKJIMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xE5B630", Offset = "0xE5AA30", VA = "0x180E5B630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE5B670", Offset = "0xE5AA70", VA = "0x180E5B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x235DB10", Offset = "0x235CF10", VA = "0x18235DB10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ICollection<TVal> KHKNKHMLPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2DBE120", Offset = "0x2DBD520", VA = "0x182DBE120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	ICollection<TKey> IDictionary<TKey, TVal>.FPGPOCOMECH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2DBD450", Offset = "0x2DBC850", VA = "0x182DBD450", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PAJHIMACICC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2DBE0B0", Offset = "0x2DBD4B0", VA = "0x182DBE0B0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2DBE190", Offset = "0x2DBD590", VA = "0x182DBE190", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC870", Offset = "0x2DBBC70", VA = "0x182DBC870")]
	private bool JFEIFLIOCNE(int EPMEDFGLJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC040", Offset = "0x2DBB440", VA = "0x182DBC040")]
	private void FDJIPCPOOPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2DBDC30", Offset = "0x2DBD030", VA = "0x182DBDC30")]
	public HOHNNBBNAEB(int EPMEDFGLJOE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB960", Offset = "0x6CAD60")] HOHNNBBNAEB<TKey, TVal>.JMPPHADGFHD KKJFHMKCBCO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CB9C0", Offset = "0x6CADC0")] IEqualityComparer<TKey> CKJMACJNBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2DBDB10", Offset = "0x2DBCF10", VA = "0x182DBDB10")]
	public HOHNNBBNAEB(int EPMEDFGLJOE, TimeSpan CBMHLBBIDFC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBA20", Offset = "0x6CAE20")] IEqualityComparer<TKey?>? CKJMACJNBGC, [Optional] OCNCPDJOIDH? HIGDDCPHKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2DBDD00", Offset = "0x2DBD100", VA = "0x182DBDD00")]
	public HOHNNBBNAEB(int EPMEDFGLJOE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBA80", Offset = "0x6CAE80")] HOHNNBBNAEB<TKey?, TVal?>.JMPPHADGFHD? KKJFHMKCBCO, TimeSpan CBMHLBBIDFC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBAE0", Offset = "0x6CAEE0")] IEqualityComparer<TKey?>? CKJMACJNBGC, [Optional] OCNCPDJOIDH? HIGDDCPHKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC810", Offset = "0x2DBBC10", VA = "0x182DBC810")]
	public bool IMDHEJGLMDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB170", Offset = "0x2DBA570", VA = "0x182DBB170")]
	public bool AGIMBFOJPHE(int JECAINLJFKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2DBBF70", Offset = "0x2DBB370", VA = "0x182DBBF70")]
	public void DADPJLGDIHI(TKey KOFPKIJDAMC, TVal KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27E0EE0", Offset = "0x27E02E0", VA = "0x1827E0EE0", Slot = "14")]
	public void Add([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBB40", Offset = "0x6CAF40")] KeyValuePair<TKey, TVal> ADJFAODNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB3C0", Offset = "0x2DBA7C0", VA = "0x182DBB3C0", Slot = "9")]
	public void Add(TKey KOFPKIJDAMC, TVal KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB840", Offset = "0x2DBAC40", VA = "0x182DBB840", Slot = "8")]
	public bool ContainsKey(TKey KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB840", Offset = "0x2DBAC40", VA = "0x182DBB840", Slot = "16")]
	public bool Contains([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBBA0", Offset = "0x6CAFA0")] KeyValuePair<TKey, TVal> ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD0A0", Offset = "0x2DBC4A0", VA = "0x182DBD0A0", Slot = "10")]
	public bool Remove(TKey KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD280", Offset = "0x2DBC680", VA = "0x182DBD280", Slot = "18")]
	public bool Remove([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBC00", Offset = "0x6CB000")] KeyValuePair<TKey, TVal> ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC640", Offset = "0x2DBBA40", VA = "0x182DBC640")]
	private TVal IKHPLCCBENN(TKey JAAPKECBADL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2DBD490", Offset = "0x2DBC890", VA = "0x182DBD490", Slot = "11")]
	public bool TryGetValue(TKey JAAPKECBADL, out TVal KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB770", Offset = "0x2DBAB70", VA = "0x182DBB770", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2DBBBC0", Offset = "0x2DBAFC0", VA = "0x182DBBBC0", Slot = "17")]
	public void CopyTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBC60", Offset = "0x6CB060")] KeyValuePair<TKey, TVal>[] KGHLGBOMEFA, int BHHKGKOCFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB5F0", Offset = "0x2DBA9F0", VA = "0x182DBB5F0")]
	private bool CMAGABOGNKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBCC0", Offset = "0x6CB0C0")] HOHNNBBNAEB<TKey, TVal>.AKJODPFJAHG OOAGECDEMHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2DBAA00", Offset = "0x2DB9E00", VA = "0x182DBAA00")]
	private void AGFGHLGDLIK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBD20", Offset = "0x6CB120")] LinkedListNode<HOHNNBBNAEB<TKey, TVal>.AKJODPFJAHG> DIMELAPFIHG, TVal NDKKBDCFLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCC20", Offset = "0x2DBC020", VA = "0x182DBCC20")]
	private void NMLCIHAMFBM(TKey KOFPKIJDAMC, TVal KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCA70", Offset = "0x2DBBE70", VA = "0x182DBCA70")]
	private void JIOMKPLOPMB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBD80", Offset = "0x6CB180")] HOHNNBBNAEB<TKey, TVal>.AKJODPFJAHG OOAGECDEMHF, TVal NDKKBDCFLEC, int OPDNNCILKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2DBC520", Offset = "0x2DBB920", VA = "0x182DBC520", Slot = "19")]
	[IteratorStateMachine(typeof(HOHNNBBNAEB<, >.ACDJHFBNBND))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A8EE40", Offset = "0x2A8E240", VA = "0x182A8EE40", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KBHJADIMCED : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AFA0", Offset = "0x6F1A3A0", VA = "0x186F1AFA0")]
	public KBHJADIMCED(string HGJHDPGFLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NINBJNOONGM<TOk> : KBHJADIMCED where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly TOk GMEFEFEMKMN;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27CC420", Offset = "0x27CB820", VA = "0x1827CC420")]
	private NINBJNOONGM(in TOk IIIPDDCDMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x27CC2F0", Offset = "0x27CB6F0", VA = "0x1827CC2F0")]
	public static NINBJNOONGM<TOk> OHIOHLNJBHE(in TOk IIIPDDCDMMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public sealed class LADIEOLHALC<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private readonly struct NNEAGJBNIAB : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly LADIEOLHALC<T> NHAMIPIPAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly int JMDDKOKMMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly bool NDOKLMJIGCM;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0D00", Offset = "0x2AA0100", VA = "0x182AA0D00")]
		public NNEAGJBNIAB(LADIEOLHALC<T> LCKHNIKLMMC, int KDKLKGCGFFB, bool JPCNADHMKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0BE0", Offset = "0x2A9FFE0", VA = "0x182AA0BE0")]
		public LADIEOLHALC<T>.ECINDDKFIPC FNKOJPGNHJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0CC0", Offset = "0x2AA00C0", VA = "0x182AA0CC0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0CC0", Offset = "0x2AA00C0", VA = "0x182AA0CC0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ECINDDKFIPC : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly LADIEOLHALC<T> NHAMIPIPAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly int AMKBBHBJNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int BNMFLMNDDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly bool NDOKLMJIGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool GJCCMHBHJNF;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public T NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2E5E470", Offset = "0x2E5D870", VA = "0x182E5E470")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2E5E620", Offset = "0x2E5DA20", VA = "0x182E5E620", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2E5E7E0", Offset = "0x2E5DBE0", VA = "0x182E5E7E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2E5EE00", Offset = "0x2E5E200", VA = "0x182E5EE00")]
		public ECINDDKFIPC(LADIEOLHALC<T> LCKHNIKLMMC, int KDKLKGCGFFB, bool JPCNADHMKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2E5E510", Offset = "0x2E5D910", VA = "0x182E5E510", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2E5E5A0", Offset = "0x2E5D9A0", VA = "0x182E5E5A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JKGMOPONMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CBFA0", Offset = "0x6CB3A0")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public JKGMOPONMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2058600", Offset = "0x2057A00", VA = "0x182058600")]
		internal T MNICOLMCAIE(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly T[] EOPICMMCNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int BNMFLMNDDFM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MLIGHCOIHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A260", Offset = "0x2B29660", VA = "0x182B2A260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T NEGPJPJCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1935A00", Offset = "0x1934E00", VA = "0x181935A00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T GJEEICJJLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A2A0", Offset = "0x2B296A0", VA = "0x182B2A2A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A040", Offset = "0x2B29440", VA = "0x182B2A040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1BC06A0", Offset = "0x1BBFAA0", VA = "0x181BC06A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xBAE6D0", Offset = "0xBADAD0", VA = "0x180BAE6D0")]
	private static int BGNBOEOKNEH(int NANJAGEOPJI, int PGBALNGGNPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A420", Offset = "0x2B29820", VA = "0x182B2A420")]
	public LADIEOLHALC(int JECAINLJFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A2D0", Offset = "0x2B296D0", VA = "0x182B2A2D0")]
	public LADIEOLHALC(int JECAINLJFKC, Func<T> BKJPPCDDHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A720", Offset = "0x2B29B20", VA = "0x182B2A720")]
	public LADIEOLHALC(T[] CJPIHDACEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A180", Offset = "0x2B29580", VA = "0x182B2A180")]
	public void GCNBGNDNMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A1B0", Offset = "0x2B295B0", VA = "0x182B2A1B0")]
	public IEnumerable<T> KEBOJLHLIHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A100", Offset = "0x2B29500", VA = "0x182B2A100")]
	public LADIEOLHALC<T>.ECINDDKFIPC FNKOJPGNHJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x24967D0", Offset = "0x2495BD0", VA = "0x1824967D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x24967D0", Offset = "0x2495BD0", VA = "0x1824967D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BIEDCMAHGGL
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3304200", Offset = "0x3303600", VA = "0x183304200")]
	public static LADIEOLHALC<T> OHIOHLNJBHE<T>(int JECAINLJFKC, Func<T> BKJPPCDDHCA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FMOECAIIOJO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LPIAIFIJNMA();

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string APIKMAODCDM();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class EACCEKENHBD : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string MIOHAAIMNDI(string MPJINGGNEFK);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	protected EACCEKENHBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class PLNBADDOPPM<TData> : GCOABNGNKLA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string GDOICJCLMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData PFGIEBFKMGE;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
	public override string APIKMAODCDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x26B6560", Offset = "0x26B5960", VA = "0x1826B6560")]
	internal PLNBADDOPPM(string HGJHDPGFLKO, in TData KJFNAECAHBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NKDKILMEBJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x12C99D0", Offset = "0x12C8DD0", VA = "0x1812C99D0")]
	public static PLNBADDOPPM<TData> OHIOHLNJBHE<TData>(string HGJHDPGFLKO, in TData KJFNAECAHBA) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GFBFCFLNAML
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string ABIHMFFDOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BJGAAEALPEI<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	TOptions EEMAOFBHODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct FKHOBCEMFFK<TOk, TErr> : IEquatable<FKHOBCEMFFK<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly EqualityComparer<TErr> EDJLLHCFIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal readonly TErr BHFLICJGAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly TOk GMEFEFEMKMN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool PGFAJGPIIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3479980", Offset = "0x3478D80", VA = "0x183479980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool PHAHABADMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3479700", Offset = "0x3478B00", VA = "0x183479700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3480180", Offset = "0x347F580", VA = "0x183480180")]
	internal FKHOBCEMFFK(in TErr AFGDINFMGHH, in TOk IIIPDDCDMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x347A770", Offset = "0x3479B70", VA = "0x18347A770")]
	public static FKHOBCEMFFK<TOk, TErr> EEJGJPJGBOL(in TErr AFGDINFMGHH)
	{
		return default(FKHOBCEMFFK<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x347DDF0", Offset = "0x347D1F0", VA = "0x18347DDF0")]
	public static FKHOBCEMFFK<TOk, TErr> OLOHOBFGLPI(in TOk IIIPDDCDMMF)
	{
		return default(FKHOBCEMFFK<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x21D6130", Offset = "0x21D5530", VA = "0x1821D6130")]
	public FKHOBCEMFFK<UOk?, TErr?> LKMDANCGBPH<UOk>()
	{
		return default(FKHOBCEMFFK<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x21D5CA0", Offset = "0x21D50A0", VA = "0x1821D5CA0")]
	public FKHOBCEMFFK<UOk?, TErr?> KGCJBMOEJCG<UOk>()
	{
		return default(FKHOBCEMFFK<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x21D57D0", Offset = "0x21D4BD0", VA = "0x1821D57D0")]
	public FKHOBCEMFFK<TOk?, UErr?> CDNKPMGIIKA<UErr>()
	{
		return default(FKHOBCEMFFK<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x347E1B0", Offset = "0x347D5B0", VA = "0x18347E1B0")]
	public FKHOBCEMFFK<GPBBNBCMMCG, TErr> PKACOBGODNJ()
	{
		return default(FKHOBCEMFFK<GPBBNBCMMCG, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x347CCE0", Offset = "0x347C0E0", VA = "0x18347CCE0")]
	public static bool MCJHDEKAHDI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC060", Offset = "0x6CB460")] in FKHOBCEMFFK<TOk, TErr> OEMIPMEJOAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC0D0", Offset = "0x6CB4D0")] in FKHOBCEMFFK<TOk, TErr> NJNCIEAMKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x347AA40", Offset = "0x3479E40", VA = "0x18347AA40", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC140", Offset = "0x6CB540")] FKHOBCEMFFK<TOk, TErr> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x347AF50", Offset = "0x347A350", VA = "0x18347AF50", Slot = "0")]
	public override bool Equals(object LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x347C810", Offset = "0x347BC10", VA = "0x18347C810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x347EBF0", Offset = "0x347DFF0", VA = "0x18347EBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DJLPLCBBMCG
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CEBMNEBGLJN<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Task<FKHOBCEMFFK<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private FKHOBCEMFFK<TOk, TErr> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private TaskAwaiter<FKHOBCEMFFK<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public CEBMNEBGLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB850", Offset = "0x2CDAC50", VA = "0x182CDB850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JPMODJNKPKB<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
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
		private IEnumerable<FKHOBCEMFFK<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IEnumerable<FKHOBCEMFFK<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEnumerator<FKHOBCEMFFK<TOk, TErr>> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private FKHOBCEMFFK<TOk, TErr> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TOk <ok>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x204C140", Offset = "0x204B540", VA = "0x18204C140")]
		[DebuggerHidden]
		public JPMODJNKPKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2027A50", Offset = "0x2026E50", VA = "0x182027A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3277980", Offset = "0x3276D80", VA = "0x183277980", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3277930", Offset = "0x3276D30", VA = "0x183277930")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3277CB0", Offset = "0x32770B0", VA = "0x183277CB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3277C00", Offset = "0x3277000", VA = "0x183277C00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x235E630", Offset = "0x235DA30", VA = "0x18235E630", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2D426D0", Offset = "0x2D41AD0", VA = "0x182D426D0")]
	public static FKHOBCEMFFK<TOk?, TErr?> GMEFEFEMKMN<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC1E0", Offset = "0x6CB5E0")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE, in TOk IIIPDDCDMMF)
	{
		return default(FKHOBCEMFFK<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D42D80", Offset = "0x2D42180", VA = "0x182D42D80")]
	public static FKHOBCEMFFK<GPBBNBCMMCG, TErr?> GMEFEFEMKMN<TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC280", Offset = "0x6CB680")] this in FKHOBCEMFFK<GPBBNBCMMCG, TErr?> JCOLBAAGCGE)
	{
		return default(FKHOBCEMFFK<GPBBNBCMMCG, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D426D0", Offset = "0x2D41AD0", VA = "0x182D426D0")]
	public static FKHOBCEMFFK<TOk?, TErr?> BHFLICJGAPO<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC2F0", Offset = "0x6CB6F0")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE, in TErr AFGDINFMGHH)
	{
		return default(FKHOBCEMFFK<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D44340", Offset = "0x2D43740", VA = "0x182D44340")]
	public static TOk? NJDDJDHENCN<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC360", Offset = "0x6CB760")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2D42DB0", Offset = "0x2D421B0", VA = "0x182D42DB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CEBMNEBGLJN<, >))]
	public static Task<TOk?>? HKFECIFHKDF<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC440", Offset = "0x6CB840")] this Task<FKHOBCEMFFK<TOk?, TErr?>>? JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D44090", Offset = "0x2D43490", VA = "0x182D44090")]
	public static TErr? MHAHAFCCDNO<TErr, TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC4A0", Offset = "0x6CB8A0")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D431B0", Offset = "0x2D425B0", VA = "0x182D431B0")]
	public static bool HOBAHBGNEDB<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC510", Offset = "0x6CB910")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC580", Offset = "0x6CB980")] out FKHOBCEMFFK<UOk?, UErr?> BMMHNOJACFI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D42D40", Offset = "0x2D42140", VA = "0x182D42D40")]
	public static bool DBNOBJCIPOM<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC5E0", Offset = "0x6CB9E0")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE, [PIJLCHPMKPF(true)] out TOk IIIPDDCDMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2D44520", Offset = "0x2D43920", VA = "0x182D44520")]
	public static bool OFAENOOGCKP<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC690", Offset = "0x6CBA90")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE, [PIJLCHPMKPF(true)] out TErr AFGDINFMGHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2D44030", Offset = "0x2D43430", VA = "0x182D44030")]
	public static bool LEJDEPHLLJG<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC740", Offset = "0x6CBB40")] this in FKHOBCEMFFK<TOk, TErr> JCOLBAAGCGE, [PIJLCHPMKPF(true)] out TOk IIIPDDCDMMF, [PIJLCHPMKPF(false)] out TErr AFGDINFMGHH) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D43C90", Offset = "0x2D43090", VA = "0x182D43C90")]
	public static bool JKLLPOKAOHD<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC7B0", Offset = "0x6CBBB0")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE, [PIJLCHPMKPF(true)] out TOk IIIPDDCDMMF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC820", Offset = "0x6CBC20")] out FKHOBCEMFFK<TOk?, TErr?> BMMHNOJACFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2D43090", Offset = "0x2D42490", VA = "0x182D43090")]
	public static bool HOBAHBGNEDB<TOk, TErr, UErr, UOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC880", Offset = "0x6CBC80")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE, [PIJLCHPMKPF(true)] out TOk IIIPDDCDMMF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC8F0", Offset = "0x6CBCF0")] out FKHOBCEMFFK<UOk?, UErr?> BMMHNOJACFI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D44680", Offset = "0x2D43A80", VA = "0x182D44680")]
	public static bool PEBCNAJEJPD<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC950", Offset = "0x6CBD50")] this in FKHOBCEMFFK<TOk?, TErr?> JCOLBAAGCGE, [PIJLCHPMKPF(true)] out TOk IIIPDDCDMMF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CC9C0", Offset = "0x6CBDC0")] out FKHOBCEMFFK<GPBBNBCMMCG, TErr?> BMMHNOJACFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2D427D0", Offset = "0x2D41BD0", VA = "0x182D427D0")]
	public static FKHOBCEMFFK<UOk, UErr> CFLDFKCGHAD<UOk, UErr, TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CCA20", Offset = "0x6CBE20")] this in FKHOBCEMFFK<TOk, TErr> JCOLBAAGCGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CCA90", Offset = "0x6CBE90")] in FKHOBCEMFFK<UOk, UErr> AHNODGPGJKH) where TOk : UOk where TErr : UErr
	{
		return default(FKHOBCEMFFK<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2D43D30", Offset = "0x2D43130", VA = "0x182D43D30")]
	public static FKHOBCEMFFK<TOk?[]?, TErr?> LCEAFEIAAHK<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CCB00", Offset = "0x6CBF00")] this IEnumerable<FKHOBCEMFFK<TOk?, TErr?>>? JCOLBAAGCGE)
	{
		return default(FKHOBCEMFFK<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1157360", Offset = "0x1156760", VA = "0x181157360")]
	[IteratorStateMachine(typeof(JPMODJNKPKB<, >))]
	public static IEnumerable<TOk?>? BCBBJINIFCA<TOk, TErr>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CCBD0", Offset = "0x6CBFD0")] this IEnumerable<FKHOBCEMFFK<TOk?, TErr?>>? JCOLBAAGCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BGGGMPHPOOD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2494220", Offset = "0x2493620", VA = "0x182494220")]
	public static FKHOBCEMFFK<TOk, T> GMEFEFEMKMN<TOk>(in TOk IIIPDDCDMMF) where TOk : notnull
	{
		return default(FKHOBCEMFFK<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x24C9070", Offset = "0x24C8470", VA = "0x1824C9070")]
	public static FKHOBCEMFFK<GPBBNBCMMCG, T> GMEFEFEMKMN()
	{
		return default(FKHOBCEMFFK<GPBBNBCMMCG, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2494220", Offset = "0x2493620", VA = "0x182494220")]
	public static FKHOBCEMFFK<T, TErr> BHFLICJGAPO<TErr>(in TErr AFGDINFMGHH) where TErr : notnull
	{
		return default(FKHOBCEMFFK<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EHMPLBFMIMH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public delegate bool CDJKPFNMBKE(string HILEBLJBOCB, EHMPLBFMIMH HKEOJGNJAJP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public int EALIBHBPMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public string LALAIELHBFI;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F198C0", Offset = "0x6F18CC0", VA = "0x186F198C0")]
	public static Dictionary<string, EHMPLBFMIMH> GEFPKKBIOGE(Type LJNPFAEMBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F19BB0", Offset = "0x6F18FB0", VA = "0x186F19BB0")]
	public static Dictionary<string, EHMPLBFMIMH> KDELNACCMHA(Type LJNPFAEMBEB, CDJKPFNMBKE JBMCHMEJALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A020", Offset = "0x6F19420", VA = "0x186F1A020")]
	public static Dictionary<int, string> OKPCJBBJJFA(Dictionary<string, EHMPLBFMIMH> CANIEFMHGCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct KLBCBGMJKEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20")]
	public static KLBCBGMJKEB OILFFIENIEA(Type JLNNFEOBAMK, [Optional] string? HIAOGDGEKHC, [Optional] string? HEELIGJAOLI, bool CLGAHOJDBMD = false)
	{
		return default(KLBCBGMJKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20")]
	public static KLBCBGMJKEB OILFFIENIEA<T>([Optional] string? HIAOGDGEKHC, [Optional] string? HEELIGJAOLI, bool CLGAHOJDBMD = false)
	{
		return default(KLBCBGMJKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class NIBIHKFMNHF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PIGEIGAOOJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public PIGEIGAOOJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x26AD8F0", Offset = "0x26ACCF0", VA = "0x1826AD8F0")]
		internal int PKJMBOAONPD(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CCC30", Offset = "0x6CC030")]
	private HashSet<T> AODIHFFJMKM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IReadOnlyCollection<T> PAOBFMALNJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x27CB470", Offset = "0x27CA870", VA = "0x1827CB470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool BOMAGAFBIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x27CB5D0", Offset = "0x27CA9D0", VA = "0x1827CB5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C0750", Offset = "0x9BFB50", VA = "0x1809C0750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC0C1E0", Offset = "0xC0B5E0", VA = "0x180C0C1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27CB490", Offset = "0x27CA890", VA = "0x1827CB490")]
	public bool EBOHBLNDMAL(T GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x27CB640", Offset = "0x27CAA40", VA = "0x1827CB640")]
	public bool PBDAKCGNFND(T GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x27CB600", Offset = "0x27CAA00", VA = "0x1827CB600")]
	public bool KBBBHMHGNAB(T GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x27CB720", Offset = "0x27CAB20", VA = "0x1827CB720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
	public NIBIHKFMNHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ICHPPOJKHCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly string LMEJIAMHHKD;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FE490", VA = "0x1807FF090")]
	public ICHPPOJKHCG(string LMEJIAMHHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AC10", Offset = "0x6F1A010", VA = "0x186F1AC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class LMDJEEFCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class FDEDLLMKDDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public FDEDLLMKDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A450", Offset = "0x6F19850", VA = "0x186F1A450")]
		internal int PKJMBOAONPD(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CCC90", Offset = "0x6CC090")]
	private HashSet<object> AODIHFFJMKM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyCollection<object> PAOBFMALNJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B460", Offset = "0x6F1A860", VA = "0x186F1B460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool BOMAGAFBIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B680", Offset = "0x6F1AA80", VA = "0x186F1B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9C0750", Offset = "0x9BFB50", VA = "0x1809C0750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xC0C1E0", Offset = "0xC0B5E0", VA = "0x180C0C1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B530", Offset = "0x6F1A930", VA = "0x186F1B530")]
	public bool EBOHBLNDMAL(object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B6F0", Offset = "0x6F1AAF0", VA = "0x186F1B6F0")]
	public bool PBDAKCGNFND(object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B690", Offset = "0x6F1AA90", VA = "0x186F1B690")]
	public bool KBBBHMHGNAB(object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B610", Offset = "0x6F1AA10", VA = "0x186F1B610")]
	public void IPGILEBEMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B790", Offset = "0x6F1AB90", VA = "0x186F1B790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public LMDJEEFCDOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JIEMGALBLIM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct IBOKIDBOLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float NAADMGLOHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public T EEMAOFBHODN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6CCCF0", Offset = "0x6CC0F0")]
	private readonly Dictionary<object, JIEMGALBLIM<T>.IBOKIDBOLPJ> CEDFPOKBHBN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public virtual T KJMCEEDEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1397B20", Offset = "0x1396F20", VA = "0x181397B20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x13972A0", Offset = "0x13966A0", VA = "0x1813972A0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public object? OGOMMCPKIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NAANDMNLDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x204E0A0", Offset = "0x204D4A0", VA = "0x18204E0A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D26810", Offset = "0x2D25C10", VA = "0x182D26810")]
	public bool NMLCIHAMFBM(T KKIAKNLLHIO, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x204C930", Offset = "0x204BD30", VA = "0x18204C930")]
	public bool AHKPFGCGLCO(object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x204E0E0", Offset = "0x204D4E0", VA = "0x18204E0E0")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x204CB30", Offset = "0x204BF30", VA = "0x18204CB30")]
	public bool HPMOKKNEDOE(object GAOLOMEJCOK, out T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2D25E20", Offset = "0x2D25220", VA = "0x182D25E20")]
	private bool JDOLJKHFLJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x204E250", Offset = "0x204D650", VA = "0x18204E250")]
	public JIEMGALBLIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class FAPPIIBPOHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<object, float> CEDFPOKBHBN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float KEKHPELHLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9CDAA0", Offset = "0x9CCEA0", VA = "0x1809CDAA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xB62660", Offset = "0xB61A60", VA = "0x180B62660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A360", Offset = "0x6F19760", VA = "0x186F1A360")]
	public void NMLCIHAMFBM(float KKIAKNLLHIO, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A1D0", Offset = "0x6F195D0", VA = "0x186F1A1D0")]
	public void AHKPFGCGLCO(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A240", Offset = "0x6F19640", VA = "0x186F1A240")]
	private void AOGIKKAGFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A3D0", Offset = "0x6F197D0", VA = "0x186F1A3D0")]
	public FAPPIIBPOHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public delegate void KKABMHHNEPK(float FAMFJMPMIMI);
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IKJCBOEDPOD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class LKKMGDMGFMJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly GEHKEKDDOIE KLCOPKJFGOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly KKABMHHNEPK GBCKPIBLKJM;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B3D0", Offset = "0x6F1A7D0", VA = "0x186F1B3D0")]
		public LKKMGDMGFMJ(GEHKEKDDOIE KLCOPKJFGOJ, KKABMHHNEPK GBCKPIBLKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B380", Offset = "0x6F1A780", VA = "0x186F1B380", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AF20", Offset = "0x6F1A320", VA = "0x186F1AF20")]
	internal static bool OKNHLFCJOKE(float EJOFMGLMADH, float CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5021C50", Offset = "0x5021050", VA = "0x185021C50")]
	internal static float EHAKCDHFFCH(float EJOFMGLMADH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AE60", Offset = "0x6F1A260", VA = "0x186F1AE60")]
	public static IDisposable JPIOAKPJELH(this GEHKEKDDOIE KLCOPKJFGOJ, KKABMHHNEPK GBCKPIBLKJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class ACCMLDLODEK : GEHKEKDDOIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct LFDJABGLHOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly float ENLGDLEAANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly float NALFHPNKMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal readonly bool MFCBPLJLPNA;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float FMHNBEKGHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6F1B090", Offset = "0x6F1A490", VA = "0x186F1B090")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B220", Offset = "0x6F1A620", VA = "0x186F1B220")]
		public LFDJABGLHOH(float GNBCIEFMNKN, float IGMAELCNDHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B0A0", Offset = "0x6F1A4A0", VA = "0x186F1B0A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class MBGOFEGMJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ACCMLDLODEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public MBGOFEGMJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1BC80", Offset = "0x6F1B080", VA = "0x186F1BC80")]
		internal void CMPEIODOLEL(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly int EPMEDFGLJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private int NIAKDFFPLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GEHKEKDDOIE[] DLBMNJOHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KKABMHHNEPK[] LEGFAAONKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LFDJABGLHOH[] GHFJNNAJPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private LFDJABGLHOH BKMCMGGJLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IIPLCKMPFKP GOPMELLNOCO;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KKABMHHNEPK HDEJCDAIDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6F18AE0", Offset = "0x6F17EE0", VA = "0x186F18AE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6F190F0", Offset = "0x6F184F0", VA = "0x186F190F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6F191B0", Offset = "0x6F185B0", VA = "0x186F191B0")]
	public ACCMLDLODEK(int EPMEDFGLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6F18A50", Offset = "0x6F17E50", VA = "0x186F18A50")]
	public IIPLCKMPFKP BOIOPPMKFFK(LFDJABGLHOH PJNDNKMLPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6F18CB0", Offset = "0x6F180B0", VA = "0x186F18CB0")]
	public void KKKLJCNDGJO(GEHKEKDDOIE BGCDCGIILDI, [Optional] LFDJABGLHOH DOAGNJGLDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6F18BA0", Offset = "0x6F17FA0", VA = "0x186F18BA0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class IIPLCKMPFKP : GEHKEKDDOIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private float FAMFJMPMIMI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float JAELEIALCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1ADA0", Offset = "0x6F1A1A0", VA = "0x186F1ADA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KKABMHHNEPK? HDEJCDAIDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1AC60", Offset = "0x6F1A060", VA = "0x186F1AC60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6F1AD00", Offset = "0x6F1A100", VA = "0x186F1AD00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public IIPLCKMPFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GEHKEKDDOIE
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KKABMHHNEPK HDEJCDAIDBN;
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
