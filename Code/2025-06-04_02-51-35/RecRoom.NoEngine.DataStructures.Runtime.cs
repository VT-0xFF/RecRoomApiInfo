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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8108E90", Offset = "0x8107690", VA = "0x188108E90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CBAGNPNCLMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected CBAGNPNCLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PJGFKEDDBFK<T> : CBAGNPNCLMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct DELJOLKDMBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum DNHJCDMLBAG
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
		public DNHJCDMLBAG CEPGAJKBPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T AMNCPNDDCLP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int MIDDPCEJPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool DFNLGOOPCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool JLLLBIOIBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? BFIGHEONEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<DELJOLKDMBF>? GJHFMHMJAJH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CLLJHLPBOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58B0F50", Offset = "0x58AF750", VA = "0x1858B0F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x58B19F0", Offset = "0x58B01F0", VA = "0x1858B19F0")]
	protected PJGFKEDDBFK(bool JLLLBIOIBGD, bool DFNLGOOPCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x58B14D0", Offset = "0x58AFCD0", VA = "0x1858B14D0")]
	protected bool HDNPHIGJIGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x58B1180", Offset = "0x58AF980", VA = "0x1858B1180")]
	protected void DGMNNAIBHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x58B1750", Offset = "0x58AFF50", VA = "0x1858B1750")]
	protected void KJJAFOKCPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4195CD0", Offset = "0x41944D0", VA = "0x184195CD0")]
	private static void LOHACIMFIKE<U>(List<U>? NFJJCCDFOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x58B12B0", Offset = "0x58AFAB0", VA = "0x1858B12B0", Slot = "4")]
	public void GGGBGBDKNKJ(T AMNCPNDDCLP, bool IPJBJMCFACN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x58B1570", Offset = "0x58AFD70", VA = "0x1858B1570", Slot = "5")]
	public void HKOLMKDGPPH(T AMNCPNDDCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x58B0FC0", Offset = "0x58AF7C0", VA = "0x1858B0FC0")]
	public void CGGBONADGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KECNPIDOCPH : PJGFKEDDBFK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x81088A0", Offset = "0x81070A0", VA = "0x1881088A0")]
	public KECNPIDOCPH(bool JLLLBIOIBGD = false, bool DFNLGOOPCFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x81085E0", Offset = "0x8106DE0", VA = "0x1881085E0")]
	public void DMJBMMIBENB()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8108840", Offset = "0x8107040", VA = "0x188108840")]
	public static KECNPIDOCPH LENELBPCALE(KECNPIDOCPH KFMGDKICPGD, Action AMNCPNDDCLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81087E0", Offset = "0x8106FE0", VA = "0x1881087E0")]
	public static KECNPIDOCPH LALOBGJEHJP(KECNPIDOCPH KFMGDKICPGD, Action AMNCPNDDCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JJOOLKFAFDL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGGBGBDKNKJ(Action<T> AMNCPNDDCLP, bool IPJBJMCFACN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKOLMKDGPPH(Action<T> AMNCPNDDCLP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class LBOAOFAOKMM<T> : PJGFKEDDBFK<Action<T>>, JJOOLKFAFDL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x469BFB0", Offset = "0x469A7B0", VA = "0x18469BFB0")]
	public LBOAOFAOKMM(bool JLLLBIOIBGD = false, bool DFNLGOOPCFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x52705A0", Offset = "0x526EDA0", VA = "0x1852705A0")]
	public void DMJBMMIBENB(T ODKLOJBBLOI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x46AA6C0", Offset = "0x46A8EC0", VA = "0x1846AA6C0")]
	public static LBOAOFAOKMM<T> LENELBPCALE(LBOAOFAOKMM<T> KFMGDKICPGD, Action<T> AMNCPNDDCLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x46AA620", Offset = "0x46A8E20", VA = "0x1846AA620")]
	public static LBOAOFAOKMM<T> LALOBGJEHJP(LBOAOFAOKMM<T> KFMGDKICPGD, Action<T> AMNCPNDDCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JPPPCFILKBD<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGGBGBDKNKJ(Action<T, U> AMNCPNDDCLP, bool IPJBJMCFACN = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKOLMKDGPPH(Action<T, U> AMNCPNDDCLP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class EGCONEOAIAE<T, U> : PJGFKEDDBFK<Action<T, U>>, JPPPCFILKBD<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x469BFB0", Offset = "0x469A7B0", VA = "0x18469BFB0")]
	public EGCONEOAIAE(bool JLLLBIOIBGD = false, bool DFNLGOOPCFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x46A9C90", Offset = "0x46A8490", VA = "0x1846A9C90")]
	public void DMJBMMIBENB(T ODKLOJBBLOI, U DOGJEIPGHMN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x46AA6C0", Offset = "0x46A8EC0", VA = "0x1846AA6C0")]
	public static EGCONEOAIAE<T, U> LENELBPCALE(EGCONEOAIAE<T, U> KFMGDKICPGD, Action<T, U> AMNCPNDDCLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x46AA620", Offset = "0x46A8E20", VA = "0x1846AA620")]
	public static EGCONEOAIAE<T, U> LALOBGJEHJP(EGCONEOAIAE<T, U> KFMGDKICPGD, Action<T, U> AMNCPNDDCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LHOJEGADNEI<T, U, V> : PJGFKEDDBFK<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x469BFB0", Offset = "0x469A7B0", VA = "0x18469BFB0")]
	public LHOJEGADNEI(bool JLLLBIOIBGD = false, bool DFNLGOOPCFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x52FF260", Offset = "0x52FDA60", VA = "0x1852FF260")]
	public void DMJBMMIBENB(T ODKLOJBBLOI, U DOGJEIPGHMN, V KENANDNBOGI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x46AA6C0", Offset = "0x46A8EC0", VA = "0x1846AA6C0")]
	public static LHOJEGADNEI<T, U, V> LENELBPCALE(LHOJEGADNEI<T, U, V> KFMGDKICPGD, Action<T, U, V> AMNCPNDDCLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x46AA620", Offset = "0x46A8E20", VA = "0x1846AA620")]
	public static LHOJEGADNEI<T, U, V> LALOBGJEHJP(LHOJEGADNEI<T, U, V> KFMGDKICPGD, Action<T, U, V> AMNCPNDDCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BCKCNIHPOOE<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class FBEJKPAPIFI<T, U, V, W> : PJGFKEDDBFK<Action<T, U, V, W>>, BCKCNIHPOOE<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x469BFB0", Offset = "0x469A7B0", VA = "0x18469BFB0")]
	public FBEJKPAPIFI(bool JLLLBIOIBGD = false, bool DFNLGOOPCFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B9A380", Offset = "0x4B98B80", VA = "0x184B9A380")]
	public void DMJBMMIBENB(T ODKLOJBBLOI, U DOGJEIPGHMN, V KENANDNBOGI, W JFOFHMLAJFN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x46AA6C0", Offset = "0x46A8EC0", VA = "0x1846AA6C0")]
	public static FBEJKPAPIFI<T, U, V, W> LENELBPCALE(FBEJKPAPIFI<T, U, V, W> KFMGDKICPGD, Action<T, U, V, W> AMNCPNDDCLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x46AA620", Offset = "0x46A8E20", VA = "0x1846AA620")]
	public static FBEJKPAPIFI<T, U, V, W> LALOBGJEHJP(FBEJKPAPIFI<T, U, V, W> KFMGDKICPGD, Action<T, U, V, W> AMNCPNDDCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NHHLJBNPNCO<T, U, V, W, X> : PJGFKEDDBFK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x469BFB0", Offset = "0x469A7B0", VA = "0x18469BFB0")]
	public NHHLJBNPNCO(bool JLLLBIOIBGD = false, bool DFNLGOOPCFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55C2C50", Offset = "0x55C1450", VA = "0x1855C2C50")]
	public void DMJBMMIBENB(T ODKLOJBBLOI, U DOGJEIPGHMN, V KENANDNBOGI, W JFOFHMLAJFN, X BDGPJOKJNIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46AA6C0", Offset = "0x46A8EC0", VA = "0x1846AA6C0")]
	public static NHHLJBNPNCO<T, U, V, W, X> LENELBPCALE(NHHLJBNPNCO<T, U, V, W, X> KFMGDKICPGD, Action<T, U, V, W, X> AMNCPNDDCLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46AA620", Offset = "0x46A8E20", VA = "0x1846AA620")]
	public static NHHLJBNPNCO<T, U, V, W, X> LALOBGJEHJP(NHHLJBNPNCO<T, U, V, W, X> KFMGDKICPGD, Action<T, U, V, W, X> AMNCPNDDCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OJLJGFGMMBM<T, U, V, W, X, Y> : PJGFKEDDBFK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x469BFB0", Offset = "0x469A7B0", VA = "0x18469BFB0")]
	public OJLJGFGMMBM(bool JLLLBIOIBGD = false, bool DFNLGOOPCFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x57416A0", Offset = "0x573FEA0", VA = "0x1857416A0")]
	public void DMJBMMIBENB(T ODKLOJBBLOI, U DOGJEIPGHMN, V KENANDNBOGI, W JFOFHMLAJFN, X BDGPJOKJNIL, Y HDAFCDJNHAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x46AA6C0", Offset = "0x46A8EC0", VA = "0x1846AA6C0")]
	public static OJLJGFGMMBM<T, U, V, W, X, Y> LENELBPCALE(OJLJGFGMMBM<T, U, V, W, X, Y> KFMGDKICPGD, Action<T, U, V, W, X, Y> AMNCPNDDCLP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x46AA620", Offset = "0x46A8E20", VA = "0x1846AA620")]
	public static OJLJGFGMMBM<T, U, V, W, X, Y> LALOBGJEHJP(OJLJGFGMMBM<T, U, V, W, X, Y> KFMGDKICPGD, Action<T, U, V, W, X, Y> AMNCPNDDCLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AIPOLDGONBN<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EHFEBOBIOIL<TKey, TVal> LDPEMMFGPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> LOCPNDLKAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EHFEBOBIOIL<TKey, TVal>.KMIKFGEAPAE? LIDDLLCBNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int NMFNJBAHCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EHFEBOBIOIL<TKey, TVal>.OKCGMPLMDKM? BFJIMODNGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int FADBFBGIEJP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int PANPJKDJGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4D227C0", Offset = "0x4D20FC0", VA = "0x184D227C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KCIKODHLHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D23970", Offset = "0x4D22170", VA = "0x184D23970")]
	public AIPOLDGONBN(int NMFNJBAHCHH, [Optional] EHFEBOBIOIL<TKey, TVal>.OKCGMPLMDKM? BFJIMODNGPA, [Optional] IEqualityComparer<TKey>? DHLAOFKLJBD, [Optional] EHFEBOBIOIL<TKey, TVal>.KMIKFGEAPAE? LIDDLLCBNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D233A0", Offset = "0x4D21BA0", VA = "0x184D233A0")]
	public void LBHKABAHAFG(TKey MNMCNOJCKAF, TVal MGONBEDEDON, bool BDBFHEPPLGH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D22650", Offset = "0x4D20E50", VA = "0x184D22650")]
	public bool CKDPDGELABC(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D23870", Offset = "0x4D22070", VA = "0x184D23870")]
	public bool PLBNMDLFKAN(TKey MHLEAJOKLMG, [Out] TVal MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D22820", Offset = "0x4D21020", VA = "0x184D22820")]
	private void GPEPKLJHBPD(TKey MNMCNOJCKAF, TVal MGONBEDEDON, int GGIJOHIPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D230A0", Offset = "0x4D218A0", VA = "0x184D230A0")]
	public bool IGGEGKEEGAB(TKey MNMCNOJCKAF, TVal MGONBEDEDON, bool BDBFHEPPLGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D225A0", Offset = "0x4D20DA0", VA = "0x184D225A0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D22B00", Offset = "0x4D21300", VA = "0x184D22B00")]
	private void HAMJBLFMOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4D235F0", Offset = "0x4D21DF0", VA = "0x184D235F0")]
	private bool LPIHKCKJBJC(TKey MNMCNOJCKAF, GAMJGECLEHN BEPEOMJMPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4D23270", Offset = "0x4D21A70", VA = "0x184D23270")]
	private void KFIDHEMNOML(TKey MNMCNOJCKAF, TVal MGONBEDEDON, GAMJGECLEHN BEPEOMJMPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D23740", Offset = "0x4D21F40", VA = "0x184D23740")]
	private void NKJGHPPBPLG(TKey MNMCNOJCKAF, TVal AMJBMFFPJLL, GAMJGECLEHN BEPEOMJMPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ILAPAAGLAIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action EHGLJKCKFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HFCHLFGENLL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public ILAPAAGLAIB(Action FGPNMBDMFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8107520", Offset = "0x8105D20", VA = "0x188107520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x372D440", Offset = "0x372BC40", VA = "0x18372D440")]
	public static KMBNNOIKNHN<T> INHDMBAMCNE<T>(T MGONBEDEDON, Action FGPNMBDMFMD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KMBNNOIKNHN<T> : ILAPAAGLAIB where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51BE4B0", Offset = "0x51BCCB0", VA = "0x1851BE4B0")]
	public KMBNNOIKNHN(T MGONBEDEDON, Action FGPNMBDMFMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class FPPLCLGGLAC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JLPDPBOHMLL<T>? BMOLFPJJMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> BGCLPBJGNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool HFCHLFGENLL;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly FPPLCLGGLAC<T> EBKBGKJDDBM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> ELNIKIBLHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4BC98D0", Offset = "0x4BC80D0", VA = "0x184BC98D0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4BC92A0", Offset = "0x4BC7AA0", VA = "0x184BC92A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KBMDKILMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4BC9660", Offset = "0x4BC7E60", VA = "0x184BC9660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4BC9F20", Offset = "0x4BC8720", VA = "0x184BC9F20")]
	public FPPLCLGGLAC(JLPDPBOHMLL<T> JCGGHBPGDAB, JLPDPBOHMLL<T> NNHNPAEAOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4BCA020", Offset = "0x4BC8820", VA = "0x184BCA020")]
	public FPPLCLGGLAC(JLPDPBOHMLL<T> JCGGHBPGDAB, int COEFDMIBPJJ, JLPDPBOHMLL<T> NNHNPAEAOPE, int NDAODLEBNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4BC9E70", Offset = "0x4BC8670", VA = "0x184BC9E70")]
	private FPPLCLGGLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4BC9210", Offset = "0x4BC7A10", VA = "0x184BC9210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4BC94E0", Offset = "0x4BC7CE0", VA = "0x184BC94E0")]
	public T[] FJIGKPPDAMG()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4BC9720", Offset = "0x4BC7F20", VA = "0x184BC9720")]
	public static ReadOnlySequence<T> KEINEINMKGA(FPPLCLGGLAC<T>? HCNLFKBLDPE)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FGADCMDNJEC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable GEFAGIIPHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T HDAKFEADKFH;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB330", Offset = "0x4BA9B30", VA = "0x184BAB330")]
	public FGADCMDNJEC(IDisposable PKBMMFHCONE, [In] T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4147220", Offset = "0x4145A20", VA = "0x184147220")]
	public static FGADCMDNJEC<U> MHIOPCBNAEG<U>([In] FGADCMDNJEC<T> PKBMMFHCONE, [In] U MGONBEDEDON) where U : notnull
	{
		return default(FGADCMDNJEC<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB250", Offset = "0x4BA9A50", VA = "0x184BAB250", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CGDPJFBHBJC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x37B6280", Offset = "0x37B4A80", VA = "0x1837B6280")]
	public static FGADCMDNJEC<T> CCPKJDCALBG<T>(IDisposable PKBMMFHCONE, [In] T MGONBEDEDON) where T : notnull
	{
		return default(FGADCMDNJEC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37B6220", Offset = "0x37B4A20", VA = "0x1837B6220")]
	public static FGADCMDNJEC<T> BMHPFGBGKPM<T>([In] this FGADCMDNJEC<T> DKBBJFIDEGB, [Out] T MGONBEDEDON) where T : notnull
	{
		return default(FGADCMDNJEC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37B62E0", Offset = "0x37B4AE0", VA = "0x1837B62E0")]
	public static FGADCMDNJEC<U?> MHIOPCBNAEG<U, T>([In] FGADCMDNJEC<T> DKPDOKGEBLI, [In] U MGONBEDEDON)
	{
		return default(FGADCMDNJEC<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct IJJNNKCGKIG : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct AIBBNKMMFKD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
		public static AIBBNKMMFKD CCPKJDCALBG()
		{
			return default(AIBBNKMMFKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81074E0", Offset = "0x8105CE0", VA = "0x1881074E0")]
	public static string ABLIDONBCGL(Type CEPGAJKBPDM, [Optional] string? PGAJDANONMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A22F40", Offset = "0x3A21740", VA = "0x183A22F40")]
	public static string? ABLIDONBCGL<T>([Optional] string? PGAJDANONMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A22FC0", Offset = "0x3A217C0", VA = "0x183A22FC0")]
	public static string? PEALHMFJKGK<T>([Optional] string? BLAOOMBGOPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	public static IJJNNKCGKIG COODOOJDJHL(string PGAJDANONMK, string? BLAOOMBGOPN)
	{
		return default(IJJNNKCGKIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FNJAKAHDIOH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool OJECPACHPMN(string BCMMCNKBLIE, FNJAKAHDIOH HHKIFEDJOKO);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DFEFMBDDEFO<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DFEFMBDDEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA680", Offset = "0x6CF8E80", VA = "0x186CFA680")]
		internal void HBHADKINFKB(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int IJLILEGPOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string OIIFFHEFDML;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8106CD0", Offset = "0x81054D0", VA = "0x188106CD0")]
	public static Dictionary<string, FNJAKAHDIOH> MFFMECOLCDG(Type LHEHOGAPCOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39CD990", Offset = "0x39CC190", VA = "0x1839CD990")]
	public static Dictionary<string, FNJAKAHDIOH> MFFMECOLCDG<T>(Type LHEHOGAPCOJ, IReadOnlyDictionary<T, string> DIPHMCDFGGM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x39CD210", Offset = "0x39CBA10", VA = "0x1839CD210")]
	public static Dictionary<string, FNJAKAHDIOH> BEPNPADLBLC<T>(List<T> CEKDFGPHBEL) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8107000", Offset = "0x8105800", VA = "0x188107000")]
	public static Dictionary<string, FNJAKAHDIOH> PEKMEILNIEN(Type LHEHOGAPCOJ, OJECPACHPMN PODHLCFFDGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8106B10", Offset = "0x8105310", VA = "0x188106B10")]
	public static Dictionary<int, string> BLEEFEDBLOJ(Dictionary<string, FNJAKAHDIOH> BJNLPCOGDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class EMOGOMODAJG : GCGCHICJANP
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool AOAGOGPJMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? JCPAMMPFGMA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual GCGCHICJANP? AHECJAJPEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8106830", Offset = "0x8105030", VA = "0x188106830")]
	protected EMOGOMODAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JKBFHJHLJNK();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8106510", Offset = "0x8104D10", VA = "0x188106510", Slot = "8")]
	public virtual string IKACJCCLCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8106590", Offset = "0x8104D90", VA = "0x188106590", Slot = "9")]
	public void OKFLCIFJKHP(StringBuilder IJNDLNIEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8106390", Offset = "0x8104B90", VA = "0x188106390", Slot = "10")]
	public void DCMKFBJELPL(StringBuilder IJNDLNIEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x81063F0", Offset = "0x8104BF0", VA = "0x1881063F0", Slot = "11")]
	public void DDCGGIBMKKC(StringBuilder IJNDLNIEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8106230", Offset = "0x8104A30", VA = "0x188106230", Slot = "12")]
	public void CMDBLPMKIAA(StringBuilder IJNDLNIEHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8106190", Offset = "0x8104990", VA = "0x188106190")]
	public static void BONBMMLGJHH(StringBuilder IJNDLNIEHII, string HGCMMCJBAPF, string JEKCOBAOGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x707BD20", Offset = "0x707A520", VA = "0x18707BD20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DDBPAECGFJM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8105F00", Offset = "0x8104700", VA = "0x188105F00")]
	public DDBPAECGFJM(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EBFBPCKMCAF<TErr> : DDBPAECGFJM where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr JPEPFGHLPPJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4699310", Offset = "0x4697B10", VA = "0x184699310")]
	private EBFBPCKMCAF([In] TErr MMBEKGPPOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4699230", Offset = "0x4697A30", VA = "0x184699230")]
	public static EBFBPCKMCAF<TErr> CCPKJDCALBG([In] TErr MMBEKGPPOOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NHAFOCAHCEE : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm EDLBIJFOLNB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool JDKIPMFHOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool IBIOJMININB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool LHOJJBHMKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8108D40", Offset = "0x8107540", VA = "0x188108D40", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long EOALAOOGNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8108DB0", Offset = "0x81075B0", VA = "0x188108DB0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8108E20", Offset = "0x8107620", VA = "0x188108E20", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8108CD0", Offset = "0x81074D0", VA = "0x188108CD0")]
	public NHAFOCAHCEE(HashAlgorithm EDLBIJFOLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8108B00", Offset = "0x8107300", VA = "0x188108B00", Slot = "35")]
	public override int Read(byte[] FLHFCEEIHBP, int BJCMHPBMOOK, int FMGALNGIOGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8108CA0", Offset = "0x81074A0", VA = "0x188108CA0", Slot = "38")]
	public override void Write(byte[] FLHFCEEIHBP, int BJCMHPBMOOK, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8108BA0", Offset = "0x81073A0", VA = "0x188108BA0", Slot = "33")]
	public override long Seek(long BJCMHPBMOOK, SeekOrigin CCEAAKFKCFC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8108C30", Offset = "0x8107430", VA = "0x188108C30", Slot = "34")]
	public override void SetLength(long MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8108A30", Offset = "0x8107230", VA = "0x188108A30")]
	public byte[] DJNHGKFEPKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GCGCHICJANP
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IKACJCCLCKH();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JKBFHJHLJNK();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface JGBKNGOIJGA<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface KBAOIDKJPAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string AIBIFFDKDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JLPDPBOHMLL<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static JLPDPBOHMLL<T>? JJJGBOJDMEI;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object KEPCIIJHDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? NJPKMFLEFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool HFCHLFGENLL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JNLECKPDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xE4BC70", Offset = "0xE4A470", VA = "0x180E4BC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x50D7A20", Offset = "0x50D6220", VA = "0x1850D7A20")]
	private static JLPDPBOHMLL<T> EBPMLMMNDJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x50D8960", Offset = "0x50D7160", VA = "0x1850D8960")]
	private static void OMCHJALHDOJ(JLPDPBOHMLL<T> HOLBPJLGONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE830", Offset = "0x4BAD030", VA = "0x184BAE830")]
	private JLPDPBOHMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x50D8360", Offset = "0x50D6B60", VA = "0x1850D8360")]
	public static JLPDPBOHMLL<T> INHDMBAMCNE(ReadOnlyMemory<T> HBPINLCGMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x50D8540", Offset = "0x50D6D40", VA = "0x1850D8540")]
	public static JLPDPBOHMLL<T> INHDMBAMCNE(IMemoryOwner<T> OPINGFGDHKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x50D73C0", Offset = "0x50D5BC0", VA = "0x1850D73C0")]
	public static void AHPNGNLJNPB(JLPDPBOHMLL<T> JCGGHBPGDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x50D7500", Offset = "0x50D5D00", VA = "0x1850D7500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x50D8060", Offset = "0x50D6860", VA = "0x1850D8060")]
	public JLPDPBOHMLL<T> GJNOLKEIEHM(IMemoryOwner<T> OPINGFGDHKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x50D8860", Offset = "0x50D7060", VA = "0x1850D8860")]
	private void LHMMHKHKPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50D7F00", Offset = "0x50D6700", VA = "0x1850D7F00")]
	private JLPDPBOHMLL<T> FIOKBICGAAN(JLPDPBOHMLL<T> HOLBPJLGONI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OCAPGGDGDEG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8108F10", Offset = "0x8107710", VA = "0x188108F10")]
	public OCAPGGDGDEG(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ODLEENNABFP<TOk> : OCAPGGDGDEG where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk HMKNLNAIJEF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5729240", Offset = "0x5727A40", VA = "0x185729240")]
	private ODLEENNABFP([In] TOk FNAGDBLAAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x55A8AF0", Offset = "0x55A72F0", VA = "0x1855A8AF0")]
	public static ODLEENNABFP<TOk> CCPKJDCALBG([In] TOk FNAGDBLAAIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct AOGODOAGAAO<TOk, TErr> : IEquatable<AOGODOAGAAO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> JJGBFEGGPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr JPEPFGHLPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk HMKNLNAIJEF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HCPEJCEFHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4E3F1A0", Offset = "0x4E3D9A0", VA = "0x184E3F1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool FCHJHPPBECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4E431D0", Offset = "0x4E419D0", VA = "0x184E431D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4E483D0", Offset = "0x4E46BD0", VA = "0x184E483D0")]
	internal AOGODOAGAAO([In] TErr MMBEKGPPOOG, [In] TOk FNAGDBLAAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4E40E30", Offset = "0x4E3F630", VA = "0x184E40E30")]
	public static AOGODOAGAAO<TOk, TErr> FHCIOKIBAPH([In] TErr MMBEKGPPOOG)
	{
		return default(AOGODOAGAAO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E3E9F0", Offset = "0x4E3D1F0", VA = "0x184E3E9F0")]
	public static AOGODOAGAAO<TOk, TErr> DMAFJBHGADB([In] TOk FNAGDBLAAIL)
	{
		return default(AOGODOAGAAO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2F63680", Offset = "0x2F61E80", VA = "0x182F63680")]
	public AOGODOAGAAO<TOk?, UErr?> CNJKLDOMLFO<UErr>()
	{
		return default(AOGODOAGAAO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2F65D40", Offset = "0x2F64540", VA = "0x182F65D40")]
	public AOGODOAGAAO<UOk?, TErr?> KGLPGEMDMHC<UOk>()
	{
		return default(AOGODOAGAAO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2F64BA0", Offset = "0x2F633A0", VA = "0x182F64BA0")]
	public AOGODOAGAAO<UOk?, TErr?> DEMKDCFDDLK<UOk>()
	{
		return default(AOGODOAGAAO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2F65F80", Offset = "0x2F64780", VA = "0x182F65F80")]
	public AOGODOAGAAO<TOk?, UErr?> OEDPMFGMCFA<UErr>()
	{
		return default(AOGODOAGAAO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4E415C0", Offset = "0x4E3FDC0", VA = "0x184E415C0")]
	public AOGODOAGAAO<KCHLBHAFJKA, TErr> GIBILENNADH()
	{
		return default(AOGODOAGAAO<KCHLBHAFJKA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4E438F0", Offset = "0x4E420F0", VA = "0x184E438F0")]
	public static bool NALNDDPCEFD([In] AOGODOAGAAO<TOk, TErr> HGBNKPCDEON, [In] AOGODOAGAAO<TOk, TErr> DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4E3F990", Offset = "0x4E3E190", VA = "0x184E3F990", Slot = "4")]
	public bool Equals(AOGODOAGAAO<TOk, TErr> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4E3FDA0", Offset = "0x4E3E5A0", VA = "0x184E3FDA0", Slot = "0")]
	public override bool Equals(object KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4E41C70", Offset = "0x4E40470", VA = "0x184E41C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4E45DD0", Offset = "0x4E445D0", VA = "0x184E45DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KOAKJCFJLHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JHLHKLBCOBC<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<AOGODOAGAAO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<AOGODOAGAAO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x50B6320", Offset = "0x50B4B20", VA = "0x1850B6320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x50B6CE0", Offset = "0x50B54E0", VA = "0x1850B6CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C1D0", Offset = "0x3A9A9D0", VA = "0x183A9C1D0")]
	public static AOGODOAGAAO<TOk?, TErr?> HMKNLNAIJEF<TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [In] TOk FNAGDBLAAIL)
	{
		return default(AOGODOAGAAO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C2E0", Offset = "0x3A9AAE0", VA = "0x183A9C2E0")]
	public static AOGODOAGAAO<KCHLBHAFJKA, TErr?> HMKNLNAIJEF<TErr>([In] this AOGODOAGAAO<KCHLBHAFJKA, TErr> DKBBJFIDEGB)
	{
		return default(AOGODOAGAAO<KCHLBHAFJKA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C1D0", Offset = "0x3A9A9D0", VA = "0x183A9C1D0")]
	public static AOGODOAGAAO<TOk?, TErr?> JPEPFGHLPPJ<TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [In] TErr MMBEKGPPOOG)
	{
		return default(AOGODOAGAAO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B940", Offset = "0x3A9A140", VA = "0x183A9B940")]
	public static TOk? GFDIFHPEKGM<TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AE20", Offset = "0x3A99620", VA = "0x183A9AE20")]
	[AsyncStateMachine(typeof(JHLHKLBCOBC<, >))]
	public static Task<TOk?>? AMDFHACOAPG<TOk, TErr>(this Task<AOGODOAGAAO<TOk, TErr>> DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C600", Offset = "0x3A9AE00", VA = "0x183A9C600")]
	public static TErr? IBGHCPMDHLJ<TErr, TOk>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DEC0", Offset = "0x3A9C6C0", VA = "0x183A9DEC0")]
	public static bool POAABHCEGEJ<TOk, TErr, UErr, UOk>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [Out] AOGODOAGAAO<UOk, UErr> NPPCHDNKMKC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BFA0", Offset = "0x3A9A7A0", VA = "0x183A9BFA0")]
	public static bool HDNDNFBLDAK<TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [Out] TOk FNAGDBLAAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B800", Offset = "0x3A9A000", VA = "0x183A9B800")]
	public static bool FCMGINIINKM<TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [Out][NotNullWhen(true)] TErr MMBEKGPPOOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C8C0", Offset = "0x3A9B0C0", VA = "0x183A9C8C0")]
	public static bool IBHPBCJBGCD<TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [Out][NotNullWhen(true)] TOk FNAGDBLAAIL, [Out][NotNullWhen(false)] TErr MMBEKGPPOOG) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CFE0", Offset = "0x3A9B7E0", VA = "0x183A9CFE0")]
	public static bool MHPEENALKMD<TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [Out][NotNullWhen(true)] TOk FNAGDBLAAIL, [Out] AOGODOAGAAO<TOk, TErr> NPPCHDNKMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D9E0", Offset = "0x3A9C1E0", VA = "0x183A9D9E0")]
	public static bool POAABHCEGEJ<TOk, TErr, UErr, UOk>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [Out][NotNullWhen(true)] TOk FNAGDBLAAIL, [Out] AOGODOAGAAO<UOk, UErr> NPPCHDNKMKC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CC30", Offset = "0x3A9B430", VA = "0x183A9CC30")]
	public static bool JPANCGIOEAN<TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [Out][NotNullWhen(true)] TOk FNAGDBLAAIL, [Out] AOGODOAGAAO<KCHLBHAFJKA, TErr> NPPCHDNKMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D200", Offset = "0x3A9BA00", VA = "0x183A9D200")]
	public static AOGODOAGAAO<UOk, UErr> NFBCFGLBDBL<UOk, UErr, TOk, TErr>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, [In] AOGODOAGAAO<UOk, UErr> FOIMOKIBLGB) where TOk : UOk where TErr : UErr
	{
		return default(AOGODOAGAAO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B1E0", Offset = "0x3A999E0", VA = "0x183A9B1E0")]
	public static AOGODOAGAAO<TOk?[]?, TErr?> DDMIHIABLPM<TOk, TErr>(this IEnumerable<AOGODOAGAAO<TOk, TErr>> DKBBJFIDEGB)
	{
		return default(AOGODOAGAAO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B550", Offset = "0x3A99D50", VA = "0x183A9B550")]
	public static AOGODOAGAAO<UOk?, TErr?> EEAAOBPGDMI<UOk, TErr, TOk>([In] this AOGODOAGAAO<TOk, TErr> DKBBJFIDEGB, Func<TOk, UOk> GKPFBHDKPON)
	{
		return default(AOGODOAGAAO<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class IGFFPFEBLJP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x417D010", Offset = "0x417B810", VA = "0x18417D010")]
	public static AOGODOAGAAO<TOk, T> HMKNLNAIJEF<TOk>([In] TOk FNAGDBLAAIL) where TOk : notnull
	{
		return default(AOGODOAGAAO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4E783A0", Offset = "0x4E76BA0", VA = "0x184E783A0")]
	public static AOGODOAGAAO<KCHLBHAFJKA, T> HMKNLNAIJEF()
	{
		return default(AOGODOAGAAO<KCHLBHAFJKA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x417D010", Offset = "0x417B810", VA = "0x18417D010")]
	public static AOGODOAGAAO<T, TErr> JPEPFGHLPPJ<TErr>([In] TErr MMBEKGPPOOG) where TErr : notnull
	{
		return default(AOGODOAGAAO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct HOKCLPEKFLA<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly KABDGBIFGIH OICCPFDPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> JBCHBMKKBMN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D30F50", Offset = "0x4D2F750", VA = "0x184D30F50")]
	public static HOKCLPEKFLA<TKey, TValue> CCPKJDCALBG(string MJAGIMDGJBK)
	{
		return default(HOKCLPEKFLA<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D31130", Offset = "0x4D2F930", VA = "0x184D31130")]
	internal HOKCLPEKFLA(Dictionary<TKey, TValue> MGONBEDEDON, KABDGBIFGIH BLKPAKOKCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4D31080", Offset = "0x4D2F880", VA = "0x184D31080")]
	public DFNNMAPAOLP<TKey, TValue> IBBDKJCFLFK([Out] Dictionary<TKey, TValue> MGONBEDEDON)
	{
		return default(DFNNMAPAOLP<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DFNNMAPAOLP<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> JBCHBMKKBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KDIHGDFOKDN EGCCMGANCFO;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC820", Offset = "0x2ABB020", VA = "0x182ABC820")]
	internal DFNNMAPAOLP(Dictionary<TKey, TValue> MGONBEDEDON, KDIHGDFOKDN CCLIJOOJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C9E390", Offset = "0x4C9CB90", VA = "0x184C9E390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LNENGBPDMAB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly KABDGBIFGIH OICCPFDPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> JBCHBMKKBMN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D30F50", Offset = "0x4D2F750", VA = "0x184D30F50")]
	public static LNENGBPDMAB<T> CCPKJDCALBG(string MJAGIMDGJBK)
	{
		return default(LNENGBPDMAB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4D31130", Offset = "0x4D2F930", VA = "0x184D31130")]
	internal LNENGBPDMAB(HashSet<T> MGONBEDEDON, KABDGBIFGIH BLKPAKOKCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4D31080", Offset = "0x4D2F880", VA = "0x184D31080")]
	public GKFEGKJLOKJ<T> IBBDKJCFLFK([Out] HashSet<T> MGONBEDEDON)
	{
		return default(GKFEGKJLOKJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct GKFEGKJLOKJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> JBCHBMKKBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KDIHGDFOKDN EGCCMGANCFO;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC820", Offset = "0x2ABB020", VA = "0x182ABC820")]
	internal GKFEGKJLOKJ(HashSet<T> MGONBEDEDON, KDIHGDFOKDN CCLIJOOJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C9E390", Offset = "0x4C9CB90", VA = "0x184C9E390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct MEEOFBFOOHC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KABDGBIFGIH OICCPFDPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> JBCHBMKKBMN;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4D30F50", Offset = "0x4D2F750", VA = "0x184D30F50")]
	public static MEEOFBFOOHC<T> CCPKJDCALBG(string MJAGIMDGJBK)
	{
		return default(MEEOFBFOOHC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4D31130", Offset = "0x4D2F930", VA = "0x184D31130")]
	internal MEEOFBFOOHC(Stack<T> MGONBEDEDON, KABDGBIFGIH BLKPAKOKCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4D31080", Offset = "0x4D2F880", VA = "0x184D31080")]
	public PLOIIHPEOIO<T> IBBDKJCFLFK([Out] Stack<T> MGONBEDEDON)
	{
		return default(PLOIIHPEOIO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PLOIIHPEOIO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> JBCHBMKKBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly KDIHGDFOKDN EGCCMGANCFO;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC820", Offset = "0x2ABB020", VA = "0x182ABC820")]
	internal PLOIIHPEOIO(Stack<T> MGONBEDEDON, KDIHGDFOKDN CCLIJOOJKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4C9E390", Offset = "0x4C9CB90", VA = "0x184C9E390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class NPLOBMPPEDD<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct JFOBJAIAKPN : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly NPLOBMPPEDD<T> HMEAKNABFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int KJGOCOCAMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool BHFEGCGIBPP;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2747190", Offset = "0x2745990", VA = "0x182747190")]
		public JFOBJAIAKPN(NPLOBMPPEDD<T> DIIOBAFKCCH, int AAKMHHKEBPN, bool BCGCCJNIMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x50B1B70", Offset = "0x50B0370", VA = "0x1850B1B70")]
		public NPLOBMPPEDD<T>.MGKKKHCODOO KFPOPIJHFBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x50B1C70", Offset = "0x50B0470", VA = "0x1850B1C70", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x50B1C70", Offset = "0x50B0470", VA = "0x1850B1C70", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class MGKKKHCODOO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly NPLOBMPPEDD<T> HMEAKNABFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int JHDENAEPKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int MFDMJKGOEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool BHFEGCGIBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool BLHFHFMAGMB;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x553DA90", Offset = "0x553C290", VA = "0x18553DA90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x553DBD0", Offset = "0x553C3D0", VA = "0x18553DBD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x553DD20", Offset = "0x553C520", VA = "0x18553DD20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x553DF60", Offset = "0x553C760", VA = "0x18553DF60")]
		public MGKKKHCODOO(NPLOBMPPEDD<T> DIIOBAFKCCH, int AAKMHHKEBPN, bool BCGCCJNIMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x553DB10", Offset = "0x553C310", VA = "0x18553DB10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x553DBB0", Offset = "0x553C3B0", VA = "0x18553DBB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class CIHCLMFIOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CIHCLMFIOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x66A23F0", Offset = "0x66A0BF0", VA = "0x1866A23F0")]
		internal T CHOMCFDJKME(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] BNLDAGKLCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int MFDMJKGOEFM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BOBMFBFNNNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x55F69C0", Offset = "0x55F51C0", VA = "0x1855F69C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T EBPBANINJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4B93D40", Offset = "0x4B92540", VA = "0x184B93D40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T ALDBJLLBKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x55F6AC0", Offset = "0x55F52C0", VA = "0x1855F6AC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x55F6C50", Offset = "0x55F5450", VA = "0x1855F6C50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x26AF170", Offset = "0x26AD970", VA = "0x1826AF170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1B7B400", Offset = "0x1B79C00", VA = "0x181B7B400")]
	private static int BOAOKNPGJEK(int PNJCJGEIDHG, int AEPPOMGGPKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55F6E00", Offset = "0x55F5600", VA = "0x1855F6E00")]
	public NPLOBMPPEDD(int GGIJOHIPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55F6FD0", Offset = "0x55F57D0", VA = "0x1855F6FD0")]
	public NPLOBMPPEDD(int GGIJOHIPOOO, Func<T> FCOFJGPNPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55F6F30", Offset = "0x55F5730", VA = "0x1855F6F30")]
	public NPLOBMPPEDD(T[] DBAICDFECAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55F6990", Offset = "0x55F5190", VA = "0x1855F6990")]
	public void GKKCLIAEDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55F68C0", Offset = "0x55F50C0", VA = "0x1855F68C0")]
	public IEnumerable<T> EDBPAMNJEIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x55F6A20", Offset = "0x55F5220", VA = "0x1855F6A20")]
	public NPLOBMPPEDD<T>.MGKKKHCODOO KFPOPIJHFBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4C41750", Offset = "0x4C3FF50", VA = "0x184C41750", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4C41750", Offset = "0x4C3FF50", VA = "0x184C41750", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HBNNBLFAJHI
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39F2430", Offset = "0x39F0C30", VA = "0x1839F2430")]
	public static NPLOBMPPEDD<T> CCPKJDCALBG<T>(int GGIJOHIPOOO, Func<T> FCOFJGPNPDN) where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x8109980", Offset = "0x8108180", VA = "0x188109980")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8109940", Offset = "0x8108140", VA = "0x188109940")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8109960", Offset = "0x8108160", VA = "0x188109960")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x81099A0", Offset = "0x81081A0", VA = "0x1881099A0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8109920", Offset = "0x8108120", VA = "0x188109920")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2875E10", Offset = "0x2874610", VA = "0x182875E10")]
		public RRColor(float NLCEHLDPLPE, float NJNCNBNNFHN, float LDEEDNGKJOE, float HBMOFOICGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A3A0", Offset = "0x7F88BA0", VA = "0x187F8A3A0", Slot = "4")]
		public bool Equals(RRColor KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8109570", Offset = "0x8107D70", VA = "0x188109570", Slot = "0")]
		public override bool Equals(object KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8109670", Offset = "0x8107E70", VA = "0x188109670", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x81096F0", Offset = "0x8107EF0", VA = "0x1881096F0", Slot = "5")]
		public string ToString(string HKOGDKBPFKC, IFormatProvider LLKCOGOHBNI)
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
			[Cpp2IlInjected.Address(RVA = "0x8109510", Offset = "0x8107D10", VA = "0x188109510")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x81094B0", Offset = "0x8107CB0", VA = "0x1881094B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x81094E0", Offset = "0x8107CE0", VA = "0x1881094E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8109540", Offset = "0x8107D40", VA = "0x188109540")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8109480", Offset = "0x8107C80", VA = "0x188109480")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F43640", Offset = "0x5F41E40", VA = "0x185F43640")]
		public RRColor32(byte NLCEHLDPLPE, byte NJNCNBNNFHN, byte LDEEDNGKJOE, byte HBMOFOICGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x22673C0", Offset = "0x2265BC0", VA = "0x1822673C0", Slot = "4")]
		public bool Equals(RRColor32 KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8108FE0", Offset = "0x81077E0", VA = "0x188108FE0", Slot = "0")]
		public override bool Equals(object KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x13D3B00", Offset = "0x13D2300", VA = "0x1813D3B00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8109060", Offset = "0x8107860", VA = "0x188109060")]
		public static RRColor32 KEINEINMKGA(RRColor GJJIDOPGHFC)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x81091B0", Offset = "0x81079B0", VA = "0x1881091B0")]
		public static RRColor KEINEINMKGA(RRColor32 GJJIDOPGHFC)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8109220", Offset = "0x8107A20", VA = "0x188109220", Slot = "5")]
		public string ToString(string HKOGDKBPFKC, IFormatProvider LLKCOGOHBNI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class CCEPMHEKAEH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct HDFICGLCLEA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly CCEPMHEKAEH<T> LCDCONDCOOB;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T HDAKFEADKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x4CF4A10", Offset = "0x4CF3210", VA = "0x184CF4A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4CF49E0", Offset = "0x4CF31E0", VA = "0x184CF49E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
		public HDFICGLCLEA(CCEPMHEKAEH<T> LCDCONDCOOB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JIIMAKLHGNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<HDFICGLCLEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CCEPMHEKAEH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x50BAAC0", Offset = "0x50B92C0", VA = "0x1850BAAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0FC0", Offset = "0x4BBF7C0", VA = "0x184BC0FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim LEBJMPOABIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T IIDHOGPKICC;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x668A770", Offset = "0x6688F70", VA = "0x18668A770")]
	public CCEPMHEKAEH([In] T IIDHOGPKICC, int JDEHJODOKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x668A730", Offset = "0x6688F30", VA = "0x18668A730")]
	public CCEPMHEKAEH([In] T IIDHOGPKICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x668A130", Offset = "0x6688930", VA = "0x18668A130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x668A650", Offset = "0x6688E50", VA = "0x18668A650")]
	public HDFICGLCLEA JFKFCFLCAAG()
	{
		return default(HDFICGLCLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x668A170", Offset = "0x6688970", VA = "0x18668A170")]
	[AsyncStateMachine(typeof(CCEPMHEKAEH<>.JIIMAKLHGNK))]
	public Task<CCEPMHEKAEH<T>.HDFICGLCLEA> FMMNILELGKM(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x668A630", Offset = "0x6688E30", VA = "0x18668A630")]
	public void GAMCANOFNLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class ONFKFAGKBIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8108F70", Offset = "0x8107770", VA = "0x188108F70")]
	public static CCEPMHEKAEH<KCHLBHAFJKA> CCPKJDCALBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3845120", Offset = "0x3843920", VA = "0x183845120")]
	public static CCEPMHEKAEH<T> CCPKJDCALBG<T>([In] T IIDHOGPKICC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class OGHKHDMHMJP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct BCHEHOMCEIG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly OGHKHDMHMJP<T> AOHNDBPIOKC;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T HDAKFEADKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x472FC50", Offset = "0x472E450", VA = "0x18472FC50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6162820", Offset = "0x6161020", VA = "0x186162820", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
		internal BCHEHOMCEIG(OGHKHDMHMJP<T> LCDCONDCOOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct EKEIOGNCCDN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly OGHKHDMHMJP<T> AOHNDBPIOKC;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T HDAKFEADKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x472FC50", Offset = "0x472E450", VA = "0x18472FC50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x472FB60", Offset = "0x472E360", VA = "0x18472FB60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
		internal EKEIOGNCCDN(OGHKHDMHMJP<T> LCDCONDCOOB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LMKMLBNJHIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<EKEIOGNCCDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public OGHKHDMHMJP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private CCEPMHEKAEH<KCHLBHAFJKA>.HDFICGLCLEA <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<CCEPMHEKAEH<KCHLBHAFJKA>.HDFICGLCLEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x53274B0", Offset = "0x5325CB0", VA = "0x1853274B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4BC0FC0", Offset = "0x4BBF7C0", VA = "0x184BC0FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CCEPMHEKAEH<int> KFLGLAJELJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CCEPMHEKAEH<KCHLBHAFJKA> OPDEIIGMNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CCEPMHEKAEH<KCHLBHAFJKA> BPBAEEMKDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T CAHHLOMINPF;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5731070", Offset = "0x572F870", VA = "0x185731070")]
	internal OGHKHDMHMJP(CCEPMHEKAEH<int> CJBJODHPKNP, CCEPMHEKAEH<KCHLBHAFJKA> FAHIOAGKNGB, CCEPMHEKAEH<KCHLBHAFJKA> MKKEAIEIMIF, [In] T IIDHOGPKICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5730810", Offset = "0x572F010", VA = "0x185730810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x57302D0", Offset = "0x572EAD0", VA = "0x1857302D0")]
	public BCHEHOMCEIG CDCGONEOHDP()
	{
		return default(BCHEHOMCEIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5730D20", Offset = "0x572F520", VA = "0x185730D20")]
	public EKEIOGNCCDN NGNIADILBPN()
	{
		return default(EKEIOGNCCDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5730AC0", Offset = "0x572F2C0", VA = "0x185730AC0")]
	[AsyncStateMachine(typeof(OGHKHDMHMJP<>.LMKMLBNJHIC))]
	public Task<OGHKHDMHMJP<T>.EKEIOGNCCDN> KNLODNOHLOH(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DCKPPGJLCJH
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8105E30", Offset = "0x8104630", VA = "0x188105E30")]
	public static OGHKHDMHMJP<KCHLBHAFJKA> CCPKJDCALBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x37F4330", Offset = "0x37F2B30", VA = "0x1837F4330")]
	public static OGHKHDMHMJP<T> CCPKJDCALBG<T>([In] T IIDHOGPKICC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class BAFGCCNMMHJ<TData> : EMOGOMODAJG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string IGFPALBFAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData KFMKJLCMCLK;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
	public override string JKBFHJHLJNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x612F5A0", Offset = "0x612DDA0", VA = "0x18612F5A0")]
	internal BAFGCCNMMHJ(string ILBALOOKKCP, [In] TData IMINNNCPCJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MKLCJFFMFKN
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8108900", Offset = "0x8107100", VA = "0x188108900")]
	public static BAFGCCNMMHJ<KCHLBHAFJKA> CCPKJDCALBG(string ILBALOOKKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x372D440", Offset = "0x372BC40", VA = "0x18372D440")]
	public static BAFGCCNMMHJ<TData> CCPKJDCALBG<TData>(string ILBALOOKKCP, [In] TData IMINNNCPCJF) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class KABDGBIFGIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool LCDGFBMFGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string FKMHBOFJDDL;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xEB4450", Offset = "0xEB2C50", VA = "0x180EB4450")]
	private KABDGBIFGIH(bool KPNHBMGIGAI, string AJNEPOAPCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8108490", Offset = "0x8106C90", VA = "0x188108490")]
	public static KABDGBIFGIH CCPKJDCALBG(string AJNEPOAPCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8108500", Offset = "0x8106D00", VA = "0x188108500")]
	public KDIHGDFOKDN IBBDKJCFLFK()
	{
		return default(KDIHGDFOKDN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct KDIHGDFOKDN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KABDGBIFGIH EBJHICCCMHP;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
	internal KDIHGDFOKDN(KABDGBIFGIH MJAGIMDGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x81085C0", Offset = "0x8106DC0", VA = "0x1881085C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class CLKEEBPJGEK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class ABOABFFEHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ABOABFFEHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4C5E530", Offset = "0x4C5CD30", VA = "0x184C5E530")]
		internal int KHNKBOPFFHM(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? FBGHJPGGDGG;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> DMLEJHFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x67985E0", Offset = "0x6796DE0", VA = "0x1867985E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JDHDENHBJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8A00", Offset = "0x4BB7200", VA = "0x184BB8A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6798230", Offset = "0x6796A30", VA = "0x186798230")]
	public bool GGGBGBDKNKJ(T KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6798460", Offset = "0x6796C60", VA = "0x186798460")]
	public bool HKOLMKDGPPH(T KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6798410", Offset = "0x6796C10", VA = "0x186798410")]
	public bool HKLOAKDICEJ(T KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6798140", Offset = "0x6796940", VA = "0x186798140")]
	public void DEAKDPAMKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6798620", Offset = "0x6796E20", VA = "0x186798620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CLKEEBPJGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class BFPHHCAGGHH
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class MPGLEIGINFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MPGLEIGINFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8108980", Offset = "0x8107180", VA = "0x188108980")]
		internal int KHNKBOPFFHM(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? FBGHJPGGDGG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> DMLEJHFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8105990", Offset = "0x8104190", VA = "0x188105990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool JDHDENHBJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8105980", Offset = "0x8104180", VA = "0x188105980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x81057A0", Offset = "0x8103FA0", VA = "0x1881057A0")]
	public bool GGGBGBDKNKJ(object KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x81058E0", Offset = "0x81040E0", VA = "0x1881058E0")]
	public bool HKOLMKDGPPH(object KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8105880", Offset = "0x8104080", VA = "0x188105880")]
	public bool HKLOAKDICEJ(object KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8105730", Offset = "0x8103F30", VA = "0x188105730")]
	public void DEAKDPAMKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8105A20", Offset = "0x8104220", VA = "0x188105A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BFPHHCAGGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class OMIJJPJLHCC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct DBGGBHGKNFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float APGBNHABJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T HDAKFEADKFH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, DBGGBHGKNFE> FDLLKGDBNDF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T IFBGPBNHAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1125510", Offset = "0x1123D10", VA = "0x181125510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1A72C50", Offset = "0x1A71450", VA = "0x181A72C50", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? ODLGDEGFFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OONNHIMBNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4D31520", Offset = "0x4D2FD20", VA = "0x184D31520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x574DDE0", Offset = "0x574C5E0", VA = "0x18574DDE0")]
	public bool FPNDDCPMLEC(T MGONBEDEDON, object KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4D31D90", Offset = "0x4D30590", VA = "0x184D31D90")]
	public bool PCPMPDBIOOI(object KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x46C26F0", Offset = "0x46C0EF0", VA = "0x1846C26F0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x574FF20", Offset = "0x574E720", VA = "0x18574FF20")]
	public bool PLBNMDLFKAN(object KAJENDFCCBJ, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x574E660", Offset = "0x574CE60", VA = "0x18574E660")]
	[IAIFEEAHNEM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JKLFFOBPELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x51BE400", Offset = "0x51BCC00", VA = "0x1851BE400")]
	public OMIJJPJLHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class CMFHIFMOMMG : FMHBKGEHDJG<JHEECHAOLLM>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class HOEDCDJPEIJ : IEqualityComparer<JHEECHAOLLM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly HOEDCDJPEIJ HPECEAELCLK;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x81073B0", Offset = "0x8105BB0", VA = "0x1881073B0", Slot = "4")]
		public bool Equals(JHEECHAOLLM BDGPJOKJNIL, JHEECHAOLLM HDAFCDJNHAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7263D90", Offset = "0x7262590", VA = "0x187263D90", Slot = "5")]
		public int GetHashCode(JHEECHAOLLM HPLLAPMNIJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HOEDCDJPEIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8105DC0", Offset = "0x81045C0", VA = "0x188105DC0")]
	public CMFHIFMOMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8105C60", Offset = "0x8104460", VA = "0x188105C60", Slot = "4")]
	public override bool GGGBGBDKNKJ(JHEECHAOLLM KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8105D10", Offset = "0x8104510", VA = "0x188105D10", Slot = "5")]
	public override bool HKOLMKDGPPH(JHEECHAOLLM KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8105BD0", Offset = "0x81043D0", VA = "0x188105BD0")]
	private static void FABJLNLIAGB(JHEECHAOLLM KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1971FB0", Offset = "0x19707B0", VA = "0x181971FB0", Slot = "6")]
	protected override string TokenToString(JHEECHAOLLM KAJENDFCCBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class JHEECHAOLLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string KCHEDJKMIKH;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public JHEECHAOLLM(string KCHEDJKMIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8108150", Offset = "0x8106950", VA = "0x188108150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class FMHBKGEHDJG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> JPBEDJHBGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? FBGHJPGGDGG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> DMLEJHFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8A50", Offset = "0x4BB7250", VA = "0x184BB8A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JDHDENHBJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8A00", Offset = "0x4BB7200", VA = "0x184BB8A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4BB9150", Offset = "0x4BB7950", VA = "0x184BB9150")]
	public FMHBKGEHDJG(IEqualityComparer<T> JPBEDJHBGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4BB8500", Offset = "0x4BB6D00", VA = "0x184BB8500", Slot = "4")]
	public virtual bool GGGBGBDKNKJ(T KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4BB86F0", Offset = "0x4BB6EF0", VA = "0x184BB86F0", Slot = "5")]
	public virtual bool HKOLMKDGPPH(T KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4BB8230", Offset = "0x4BB6A30", VA = "0x184BB8230")]
	public void DEAKDPAMKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4BB8A90", Offset = "0x4BB7290", VA = "0x184BB8A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class FHOMLAFAIFF<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? FBGHJPGGDGG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool JDHDENHBJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD280", Offset = "0x4BABA80", VA = "0x184BAD280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD3B0", Offset = "0x4BABBB0", VA = "0x184BAD3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4BACE40", Offset = "0x4BAB640", VA = "0x184BACE40")]
	public void GGGBGBDKNKJ(T KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD0D0", Offset = "0x4BAB8D0", VA = "0x184BAD0D0")]
	public void HKOLMKDGPPH(T KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4BACDF0", Offset = "0x4BAB5F0", VA = "0x184BACDF0")]
	public void DEAKDPAMKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4BAD560", Offset = "0x4BABD60", VA = "0x184BAD560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FHOMLAFAIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class LEIDJKEOMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3A53130", Offset = "0x3A51930", VA = "0x183A53130")]
	public static void KCKKIFBMGKH<T>(this List<T> NFJJCCDFOPE, int PNJCJGEIDHG) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class HOLPKCBDGIM<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct NKGFLAGOMHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float APGBNHABJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T HDAKFEADKFH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<JHEECHAOLLM, NKGFLAGOMHM> FDLLKGDBNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> GJILBNECAME;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T IFBGPBNHAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private JHEECHAOLLM? ODLGDEGFFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool OONNHIMBNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4D31520", Offset = "0x4D2FD20", VA = "0x184D31520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4D31580", Offset = "0x4D2FD80", VA = "0x184D31580")]
	public bool FPNDDCPMLEC(T MGONBEDEDON, JHEECHAOLLM KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4D31D90", Offset = "0x4D30590", VA = "0x184D31D90")]
	public bool PCPMPDBIOOI(JHEECHAOLLM KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x46C26F0", Offset = "0x46C0EF0", VA = "0x1846C26F0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4D31E40", Offset = "0x4D30640", VA = "0x184D31E40")]
	public bool PLBNMDLFKAN(JHEECHAOLLM KAJENDFCCBJ, [Out] T MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4D317C0", Offset = "0x4D2FFC0", VA = "0x184D317C0")]
	[IAIFEEAHNEM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool JKLFFOBPELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4D31F60", Offset = "0x4D30760", VA = "0x184D31F60")]
	public HOLPKCBDGIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class JKDCHJLBPGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> FDLLKGDBNDF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float ACBBGEKLFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x11223F0", Offset = "0x1120BF0", VA = "0x1811223F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x12897E0", Offset = "0x1287FE0", VA = "0x1812897E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x81081F0", Offset = "0x81069F0", VA = "0x1881081F0")]
	public void FPNDDCPMLEC(float MGONBEDEDON, object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8108390", Offset = "0x8106B90", VA = "0x188108390")]
	public void PCPMPDBIOOI(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x81081A0", Offset = "0x81069A0", VA = "0x1881081A0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8108260", Offset = "0x8106A60", VA = "0x188108260")]
	private void NABBIAFMJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8108400", Offset = "0x8106C00", VA = "0x188108400")]
	public JKDCHJLBPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface CPIJNNKNCEA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event AGGEJNEFLHB DEHPGMHFFOA;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JFJKIGGENDI : CPIJNNKNCEA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct JFNFBBGILJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float IDHAAILNKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float AEOJNBIMJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool KBFIABEIPGM;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float AMAGOKKEMNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8107E80", Offset = "0x8106680", VA = "0x188107E80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8107FF0", Offset = "0x81067F0", VA = "0x188107FF0")]
		public JFNFBBGILJG(float BAGLBFCLNDM, float LLHBGCFGAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8107E90", Offset = "0x8106690", VA = "0x188107E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class IECOFHJEHBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JFJKIGGENDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IECOFHJEHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8107440", Offset = "0x8105C40", VA = "0x188107440")]
		internal void DJIAAINPLKO(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int BEMGFNOEFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int GKNJLIKMLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CPIJNNKNCEA[] OOIKBFEMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly AGGEJNEFLHB[] PJHMONPOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly JFNFBBGILJG[] GJGDPAOJCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private JFNFBBGILJG MLHKNCNNKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly DIADNJMIGGJ CBKEMDKIPCD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event AGGEJNEFLHB DEHPGMHFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8107730", Offset = "0x8105F30", VA = "0x188107730", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8107670", Offset = "0x8105E70", VA = "0x188107670", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8107CF0", Offset = "0x81064F0", VA = "0x188107CF0")]
	public JFJKIGGENDI(int BEMGFNOEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8107C60", Offset = "0x8106460", VA = "0x188107C60")]
	public DIADNJMIGGJ OFDHGHCABAA(JFNFBBGILJG LGACFNJFHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x81077F0", Offset = "0x8105FF0", VA = "0x1881077F0")]
	public void LENKOLEEIMN(CPIJNNKNCEA ONIFKJAAFHA, [Optional] JFNFBBGILJG KAMLFJLMMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8107560", Offset = "0x8105D60", VA = "0x188107560", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void AGGEJNEFLHB(float JFMGOBGJJJI);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class ABFLNMIJJBF
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class FGIPMCBFPEE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly CPIJNNKNCEA AMDIJNGMPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly AGGEJNEFLHB LKHIOLGKDDF;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8106A80", Offset = "0x8105280", VA = "0x188106A80")]
		public FGIPMCBFPEE(CPIJNNKNCEA AMDIJNGMPBN, AGGEJNEFLHB LKHIOLGKDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8106A30", Offset = "0x8105230", VA = "0x188106A30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x81056C0", Offset = "0x8103EC0", VA = "0x1881056C0")]
	internal static bool HIEGPKDDPKO(float HBMOFOICGEH, float LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x80F7860", Offset = "0x80F6060", VA = "0x1880F7860")]
	internal static float JBMIOLHGIMN(float HBMOFOICGEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8105600", Offset = "0x8103E00", VA = "0x188105600")]
	public static IDisposable GDFNEALKAJL(this CPIJNNKNCEA AMDIJNGMPBN, AGGEJNEFLHB LKHIOLGKDDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DIADNJMIGGJ : CPIJNNKNCEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float JFMGOBGJJJI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float OANJMBHMDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8105F60", Offset = "0x8104760", VA = "0x188105F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event AGGEJNEFLHB? DEHPGMHFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x81060F0", Offset = "0x81048F0", VA = "0x1881060F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8106050", Offset = "0x8104850", VA = "0x188106050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DIADNJMIGGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface CGAIOGJIMMH<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJJEOHECFLJ<T> NENGBNEGMOH([Out] T MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGGBONADGHB();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BKNBNCMOOKF<T> : CGAIOGJIMMH<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> NFLBCBNJLKC;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6178830", Offset = "0x6177030", VA = "0x186178830", Slot = "4")]
	public JJJEOHECFLJ<T> NENGBNEGMOH([Out] T MGONBEDEDON)
	{
		return default(JJJEOHECFLJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x61788D0", Offset = "0x61770D0", VA = "0x1861788D0")]
	public void NJIHLBBHOIK(T FIKENLOEBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x53723F0", Offset = "0x5370BF0", VA = "0x1853723F0", Slot = "5")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	protected virtual void CIEFHPHNHEM(T NLNOBADCKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6178780", Offset = "0x6176F80", VA = "0x186178780")]
	private T CEJDCFFPPDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6178950", Offset = "0x6177150", VA = "0x186178950")]
	public BKNBNCMOOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct JJJEOHECFLJ<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T FIKENLOEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly BKNBNCMOOKF<T> KFIOJDEKGOI;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
	internal JJJEOHECFLJ(T MGONBEDEDON, BKNBNCMOOKF<T> KFIOJDEKGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x50C10B0", Offset = "0x50BF8B0", VA = "0x1850C10B0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FDFBHBPMBBB : BKNBNCMOOKF<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly FDFBHBPMBBB HPECEAELCLK;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x81068A0", Offset = "0x81050A0", VA = "0x1881068A0")]
	public static JJJEOHECFLJ<StringBuilder> CEJDCFFPPDB([Out] StringBuilder MGONBEDEDON)
	{
		return default(JJJEOHECFLJ<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x8106940", Offset = "0x8105140", VA = "0x188106940", Slot = "6")]
	protected override void CIEFHPHNHEM(StringBuilder NLNOBADCKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x81069F0", Offset = "0x81051F0", VA = "0x1881069F0")]
	public FDFBHBPMBBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class JDGMOFLGAOA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x79B7970", Offset = "0x79B6170", VA = "0x1879B7970")]
	public JDGMOFLGAOA(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class EDIKNOHGCPA<TKey, TValue> : CNFPEEDMLDM<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, PAMBCAJDAEE where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class GEIGPMLAKJI : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public EDIKNOHGCPA<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1125510", Offset = "0x1123D10", VA = "0x181125510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4C11460", Offset = "0x4C0FC60", VA = "0x184C11460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public GEIGPMLAKJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4C116F0", Offset = "0x4C0FEF0", VA = "0x184C116F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4C830D0", Offset = "0x4C818D0", VA = "0x184C830D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4C83030", Offset = "0x4C81830", VA = "0x184C83030")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4C82EF0", Offset = "0x4C816F0", VA = "0x184C82EF0")]
		private void CLFKDHFELPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4C83F10", Offset = "0x4C82710", VA = "0x184C83F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CNFPEEDMLDM<TKey, TValue> EANPMFNIDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> HFKILLFNPNG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x469FD80", Offset = "0x469E580", VA = "0x18469FD80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FEDAMJDDKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x469FE90", Offset = "0x469E690", VA = "0x18469FE90", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x46A0140", Offset = "0x469E940", VA = "0x1846A0140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> MDFMDLBAKID
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x469FEE0", Offset = "0x469E6E0", VA = "0x18469FEE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> AOPGOIANMLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x46A0010", Offset = "0x469E810", VA = "0x1846A0010", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x469FB10", Offset = "0x469E310", VA = "0x18469FB10")]
	public EDIKNOHGCPA(CNFPEEDMLDM<TKey, TValue> EANPMFNIDFF, [Optional] IDictionary<TKey, TValue>? HFKILLFNPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x469D4D0", Offset = "0x469BCD0", VA = "0x18469D4D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x469EB60", Offset = "0x469D360", VA = "0x18469EB60")]
	public void NKBONFIPGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x469D2A0", Offset = "0x469BAA0", VA = "0x18469D2A0", Slot = "9")]
	public void Add(TKey MNMCNOJCKAF, TValue MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x469E3A0", Offset = "0x469CBA0", VA = "0x18469E3A0")]
	public void GPLEMMLLBIK(TKey MNMCNOJCKAF, TValue MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x469CDC0", Offset = "0x469B5C0", VA = "0x18469CDC0")]
	public void ACCCDLADHMC(TKey MNMCNOJCKAF, TValue MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x469DEF0", Offset = "0x469C6F0", VA = "0x18469DEF0")]
	public void FDIOMNALCKI(TKey MNMCNOJCKAF, TValue MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x469E760", Offset = "0x469CF60", VA = "0x18469E760")]
	public void JLIDJKIJFPF(TKey MNMCNOJCKAF, TValue MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x469F140", Offset = "0x469D940", VA = "0x18469F140", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x469F190", Offset = "0x469D990", VA = "0x18469F190", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x469F690", Offset = "0x469DE90", VA = "0x18469F690", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x469D610", Offset = "0x469BE10", VA = "0x18469D610", Slot = "8")]
	public bool ContainsKey(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x469DDD0", Offset = "0x469C5D0", VA = "0x18469DDD0")]
	public bool DAMIPLDIKGK(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x469EAA0", Offset = "0x469D2A0", VA = "0x18469EAA0")]
	public bool NFMGHPLGLMF(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x469EF50", Offset = "0x469D750", VA = "0x18469EF50", Slot = "10")]
	public bool Remove(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x469F970", Offset = "0x469E170", VA = "0x18469F970", Slot = "11")]
	public bool TryGetValue(TKey MNMCNOJCKAF, [Out] TValue MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x469D930", Offset = "0x469C130", VA = "0x18469D930", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] LPBOBEPEKNH, int LJDJNPPCHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x469F850", Offset = "0x469E050", VA = "0x18469F850", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x469E6B0", Offset = "0x469CEB0", VA = "0x18469E6B0", Slot = "19")]
	[IteratorStateMachine(typeof(EDIKNOHGCPA<, >.GEIGPMLAKJI))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x469E9F0", Offset = "0x469D1F0", VA = "0x18469E9F0", Slot = "21")]
	public bool LJFAAOBCDDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x469ED80", Offset = "0x469D580", VA = "0x18469ED80")]
	private TValue OKEPIMGAHBL(TKey MNMCNOJCKAF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface DNELIAIICIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string EPOCPMDMODB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface PAMBCAJDAEE
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJFAAOBCDDA();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface CNFPEEDMLDM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, PAMBCAJDAEE
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class EHFEBOBIOIL<TKey, TVal> : CNFPEEDMLDM<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, PAMBCAJDAEE where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int OKCGMPLMDKM(TKey MNMCNOJCKAF, TVal MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void KMIKFGEAPAE(TKey MNMCNOJCKAF, TVal MGONBEDEDON, GAMJGECLEHN BEPEOMJMPKF);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class PCOFKAIMECA
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey IIACIMCDNIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal HDAKFEADKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int AMAGOKKEMNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset OBFLNGFIBOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x139CFD0", Offset = "0x139B7D0", VA = "0x18139CFD0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x139CFE0", Offset = "0x139B7E0", VA = "0x18139CFE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5812CB0", Offset = "0x58114B0", VA = "0x185812CB0")]
		public PCOFKAIMECA(TKey MNMCNOJCKAF, TVal AMJBMFFPJLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class NMFHICBANDP : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public EHFEBOBIOIL<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<PCOFKAIMECA>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1125510", Offset = "0x1123D10", VA = "0x181125510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x55E2BC0", Offset = "0x55E13C0", VA = "0x1855E2BC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public NMFHICBANDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9C00", Offset = "0x4BA8400", VA = "0x184BA9C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x55E0DD0", Offset = "0x55DF5D0", VA = "0x1855E0DD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x55DFDF0", Offset = "0x55DE5F0", VA = "0x1855DFDF0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x55E2990", Offset = "0x55E1190", VA = "0x1855E2990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int JJJAEEJHBAE = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<PCOFKAIMECA>> ECCIHCDFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<PCOFKAIMECA> LOIKBKOKLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly OKCGMPLMDKM? BFJIMODNGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan EFLNDIGGAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly KMIKFGEAPAE? LIDDLLCBNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly MGDGHCBONGK KAAMMGFKBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool KHOKGIEPJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> CFBPBKLEJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> GEKAJOCODBG;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int KCIKODHLHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC75DA0", VA = "0x180C775A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int PANPJKDJGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xDC2EB0", Offset = "0xDC16B0", VA = "0x180DC2EB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xEE4A70", Offset = "0xEE3270", VA = "0x180EE4A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x46CB6C0", Offset = "0x46C9EC0", VA = "0x1846CB6C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int MMOHENNKDDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x46C26F0", Offset = "0x46C0EF0", VA = "0x1846C26F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> AOPGOIANMLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x46CB830", Offset = "0x46CA030", VA = "0x1846CB830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.ACBOOGMPHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x46C9950", Offset = "0x46C8150", VA = "0x1846C9950", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool FEDAMJDDKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal NOJAFKJLFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x46CB7D0", Offset = "0x46C9FD0", VA = "0x1846CB7D0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x46CB8E0", Offset = "0x46CA0E0", VA = "0x1846CB8E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x46C66D0", Offset = "0x46C4ED0", VA = "0x1846C66D0")]
	private bool JLEEDNCJMIM(int BEMGFNOEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x46C2A10", Offset = "0x46C1210", VA = "0x1846C2A10")]
	private void FGLIKBMAOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x46CA780", Offset = "0x46C8F80", VA = "0x1846CA780")]
	public EHFEBOBIOIL(int BEMGFNOEFHN, [Optional] OKCGMPLMDKM? BFJIMODNGPA, [Optional] IEqualityComparer<TKey>? DHLAOFKLJBD, [Optional] KMIKFGEAPAE? LIDDLLCBNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x46CA620", Offset = "0x46C8E20", VA = "0x1846CA620")]
	public EHFEBOBIOIL(TimeSpan EFLNDIGGAIJ, [Optional] IEqualityComparer<TKey>? DHLAOFKLJBD, [Optional] KMIKFGEAPAE? LIDDLLCBNGM, [Optional] MGDGHCBONGK? KAAMMGFKBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x46CA120", Offset = "0x46C8920", VA = "0x1846CA120")]
	public EHFEBOBIOIL(int BEMGFNOEFHN, TimeSpan EFLNDIGGAIJ, [Optional] IEqualityComparer<TKey>? DHLAOFKLJBD, [Optional] KMIKFGEAPAE? LIDDLLCBNGM, [Optional] MGDGHCBONGK? KAAMMGFKBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x46CB240", Offset = "0x46C9A40", VA = "0x1846CB240")]
	public EHFEBOBIOIL(int BEMGFNOEFHN, OKCGMPLMDKM? BFJIMODNGPA, TimeSpan EFLNDIGGAIJ, [Optional] IEqualityComparer<TKey>? DHLAOFKLJBD, [Optional] KMIKFGEAPAE? LIDDLLCBNGM, [Optional] MGDGHCBONGK? KAAMMGFKBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x46C6720", Offset = "0x46C4F20", VA = "0x1846C6720", Slot = "21")]
	public bool LJFAAOBCDDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x46C2800", Offset = "0x46C1000", VA = "0x1846C2800", Slot = "22")]
	public bool ELNJPCKGIJA(int GGIJOHIPOOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x46C8A60", Offset = "0x46C7260", VA = "0x1846C8A60")]
	private bool OENDHBIJNJC(int GGIJOHIPOOO, GAMJGECLEHN BEPEOMJMPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x46C74B0", Offset = "0x46C5CB0", VA = "0x1846C74B0")]
	public void NNLOAAEAPBJ(TKey MNMCNOJCKAF, TVal MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x46C0E80", Offset = "0x46BF680", VA = "0x1846C0E80", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NAGJHHJDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x46C0B80", Offset = "0x46BF380", VA = "0x1846C0B80", Slot = "9")]
	public void Add(TKey MNMCNOJCKAF, TVal MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x46C1860", Offset = "0x46C0060", VA = "0x1846C1860", Slot = "8")]
	public bool ContainsKey(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x46C93E0", Offset = "0x46C7BE0", VA = "0x1846C93E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x46C92D0", Offset = "0x46C7AD0", VA = "0x1846C92D0", Slot = "10")]
	public bool Remove(TKey MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x46C96C0", Offset = "0x46C7EC0", VA = "0x1846C96C0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> NAGJHHJDFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x46C34B0", Offset = "0x46C1CB0", VA = "0x1846C34B0")]
	private bool FOCGCKAPFDH(TKey MNMCNOJCKAF, [Out] TVal MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x46C1240", Offset = "0x46BFA40", VA = "0x1846C1240")]
	private TVal CEJDCFFPPDB(TKey MHLEAJOKLMG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x46C9C10", Offset = "0x46C8410", VA = "0x1846C9C10", Slot = "11")]
	public bool TryGetValue(TKey MHLEAJOKLMG, [Out] TVal MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x46C16C0", Offset = "0x46BFEC0", VA = "0x1846C16C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x46C2020", Offset = "0x46C0820", VA = "0x1846C2020", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LPBOBEPEKNH, int LJDJNPPCHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x46C6F70", Offset = "0x46C5770", VA = "0x1846C6F70")]
	private void NKJGHPPBPLG(TKey MNMCNOJCKAF, TVal AMJBMFFPJLL, GAMJGECLEHN BEPEOMJMPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x46C6AF0", Offset = "0x46C52F0", VA = "0x1846C6AF0")]
	private bool NEONKAOPLOE(PCOFKAIMECA ICBHJJOHJHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x46C5570", Offset = "0x46C3D70", VA = "0x1846C5570")]
	private void IKLIALGKPKE(LinkedListNode<PCOFKAIMECA> IBMOKGDOMDK, TVal AHKAAJJNOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x46C3B10", Offset = "0x46C2310", VA = "0x1846C3B10")]
	private void FPNDDCPMLEC(TKey MNMCNOJCKAF, TVal MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x46C4930", Offset = "0x46C3130", VA = "0x1846C4930")]
	private void IFAEPKMLIHP(PCOFKAIMECA ICBHJJOHJHJ, TVal AHKAAJJNOPN, int DPJLINPFFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x46C4660", Offset = "0x46C2E60", VA = "0x1846C4660", Slot = "19")]
	[IteratorStateMachine(typeof(EHFEBOBIOIL<, >.NMFHICBANDP))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x46C99A0", Offset = "0x46C81A0", VA = "0x1846C99A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum GAMJGECLEHN : byte
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
public class CBEJHJAJLAF<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey CILPFONNECM;

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x65B37A0", Offset = "0x65B1FA0", VA = "0x1865B37A0")]
	public CBEJHJAJLAF(TKey LIGMPLDDGNI, Exception GJEDNEMABLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NDPMHMNNIHF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x71F69F0", Offset = "0x71F51F0", VA = "0x1871F69F0")]
	public NDPMHMNNIHF(string ILBALOOKKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class FLKAIJPABOG<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class KMNDFPLCPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public FLKAIJPABOG<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KMNDFPLCPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x51C1150", Offset = "0x51BF950", VA = "0x1851C1150")]
		internal Task<TResource> GCCKFOFLGGG(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct ENAEDFANLFD : IAsyncStateMachine
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
		public FLKAIJPABOG<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x474D1D0", Offset = "0x474B9D0", VA = "0x18474D1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x474DBF0", Offset = "0x474C3F0", VA = "0x18474DBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct OBNAOPBPKKI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x571E640", Offset = "0x571CE40", VA = "0x18571E640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x571F120", Offset = "0x571D920", VA = "0x18571F120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly JECNEKGFMCM<TId, Task<TResource>> JOFIHDPMGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> IIALLELKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? KBNBFOBKOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? IMGDAIHJAOO;

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4BB6580", Offset = "0x4BB4D80", VA = "0x184BB6580")]
	public FLKAIJPABOG(int DOKKPGJAENM = 0, [Optional] IEqualityComparer<TId>? LFNLDHPNACD, [Optional] Func<TId, CancellationToken, Task<TResource>>? PKAOCDEJGPO, [Optional] Action<TResource>? EIFFAAMOLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4BB50E0", Offset = "0x4BB38E0", VA = "0x184BB50E0")]
	public KMBNNOIKNHN<Task<TResource>> HPMGOHHMHCH(TId EBHOIBHGECB, [Optional] Func<TId, CancellationToken, Task<TResource>>? PKAOCDEJGPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4BB59C0", Offset = "0x4BB41C0", VA = "0x184BB59C0")]
	private void JBPHFNLMCHP(Task<TResource> FEGBHCAEMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4BB4C80", Offset = "0x4BB3480", VA = "0x184BB4C80")]
	[AsyncStateMachine(typeof(FLKAIJPABOG<, >.ENAEDFANLFD))]
	private Task ENEBAOCIMDF(Task<TResource> FEGBHCAEMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4BB5080", Offset = "0x4BB3880", VA = "0x184BB5080")]
	public void HGLBJNKBHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4BB6210", Offset = "0x4BB4A10", VA = "0x184BB6210")]
	public JECNEKGFMCM<TId, Task<TResource>>.ONBNHBFLIAB KFPOPIJHFBP()
	{
		return default(JECNEKGFMCM<TId, Task<TResource>>.ONBNHBFLIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4BB6440", Offset = "0x4BB4C40", VA = "0x184BB6440", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4BB6440", Offset = "0x4BB4C40", VA = "0x184BB6440", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4BB60E0", Offset = "0x4BB48E0", VA = "0x184BB60E0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(FLKAIJPABOG<, >.OBNAOPBPKKI))]
	internal static Task JGIPBBBNHBN(Task<TResource> FEGBHCAEMDO, CancellationTokenSource KFHNGCODDFA, Dictionary<Task<TResource>, CancellationTokenSource> MCOKMJPADGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class JECNEKGFMCM<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class JLKEPMAKFEA : IEquatable<JLKEPMAKFEA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue HDAKFEADKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int PLNHOOFCGOM;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x11F8F60", Offset = "0x11F7760", VA = "0x1811F8F60")]
		public JLKEPMAKFEA(TValue MGONBEDEDON, int IEGGDMAKMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x50D1AA0", Offset = "0x50D02A0", VA = "0x1850D1AA0", Slot = "4")]
		public bool Equals(JLKEPMAKFEA? KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x50D19F0", Offset = "0x50D01F0", VA = "0x1850D19F0", Slot = "0")]
		public override bool Equals(object? HPLLAPMNIJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x50D1BC0", Offset = "0x50D03C0", VA = "0x1850D1BC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct ONBNHBFLIAB : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, JLKEPMAKFEA>.Enumerator KOCLFMMJHHH;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x5753410", Offset = "0x5751C10", VA = "0x185753410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x5753730", Offset = "0x5751F30", VA = "0x185753730", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5753660", Offset = "0x5751E60", VA = "0x185753660")]
		public ONBNHBFLIAB(JECNEKGFMCM<TKey, TValue> FDLLKGDBNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5752F00", Offset = "0x5751700", VA = "0x185752F00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5752F40", Offset = "0x5751740", VA = "0x185752F40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5753000", Offset = "0x5751800", VA = "0x185753000", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class GPGKHPDDKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public JECNEKGFMCM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public JLKEPMAKFEA refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GPGKHPDDKIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4CB2B20", Offset = "0x4CB1320", VA = "0x184CB2B20")]
		internal void GCCKFOFLGGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, JLKEPMAKFEA> GFDOEDOMKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? NENBDNMNFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? JLFOHENDANH;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x50AD770", Offset = "0x50ABF70", VA = "0x1850AD770")]
	public JECNEKGFMCM(int DOKKPGJAENM = 0, [Optional] IEqualityComparer<TKey>? DHLAOFKLJBD, [Optional] Func<TKey, TValue>? GMKFHHAMOPF, [Optional] Action<TValue>? BBOFLHOHIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x50ACDC0", Offset = "0x50AB5C0", VA = "0x1850ACDC0")]
	public KMBNNOIKNHN<TValue> HPMGOHHMHCH(TKey MNMCNOJCKAF, [Optional] Func<TKey, TValue>? IGLOFFNOGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x50AD2E0", Offset = "0x50ABAE0", VA = "0x1850AD2E0")]
	private void NJIHLBBHOIK(TKey MNMCNOJCKAF, JLKEPMAKFEA FFGELDMPKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x50AC200", Offset = "0x50AAA00", VA = "0x1850AC200")]
	public void HGLBJNKBHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x50AD130", Offset = "0x50AB930", VA = "0x1850AD130")]
	public ONBNHBFLIAB KFPOPIJHFBP()
	{
		return default(ONBNHBFLIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x50AD580", Offset = "0x50ABD80", VA = "0x1850AD580", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x50AD580", Offset = "0x50ABD80", VA = "0x1850AD580", Slot = "5")]
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
