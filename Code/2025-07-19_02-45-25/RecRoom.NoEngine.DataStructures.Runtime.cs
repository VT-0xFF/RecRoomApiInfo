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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x82DF2B0", Offset = "0x82DE2B0", VA = "0x1882DF2B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IKOGKDKNFCC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected IKOGKDKNFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class FOEMMINANJI<T> : IKOGKDKNFCC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LGBEDJJFBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JONADNHDHCN
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
		public JONADNHDHCN BJLNCBFOGNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T DMHPHEGJKMB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int MIBGDKELNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool IKJFPMBEHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool LENDMFMLEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? DNOLCKJJNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LGBEDJJFBOJ>? LPHKKKJJBEN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BLDHFFJJPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4DBCB60", Offset = "0x4DBBB60", VA = "0x184DBCB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4DBD240", Offset = "0x4DBC240", VA = "0x184DBD240")]
	protected FOEMMINANJI(bool LENDMFMLEMB, bool IKJFPMBEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4DBCBB0", Offset = "0x4DBBBB0", VA = "0x184DBCBB0")]
	protected bool FADHDHNGNKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4DBD140", Offset = "0x4DBC140", VA = "0x184DBD140")]
	protected void LKLBIELLAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4DBCC50", Offset = "0x4DBBC50", VA = "0x184DBCC50")]
	protected void HGBGJENKPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D72210", Offset = "0x3D71210", VA = "0x183D72210")]
	private static void PJNMCFIODAF<U>(List<U>? KKAPDLIJLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4DBC990", Offset = "0x4DBB990", VA = "0x184DBC990", Slot = "4")]
	public void DOPEKGIEJEC(T DMHPHEGJKMB, bool PMMKCLMLGLM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DBCF90", Offset = "0x4DBBF90", VA = "0x184DBCF90", Slot = "5")]
	public void LKIPLGLLFFP(T DMHPHEGJKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4DBCE20", Offset = "0x4DBBE20", VA = "0x184DBCE20")]
	public void JPJFAMEFLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LELKCPPPMEI : FOEMMINANJI<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82DEF30", Offset = "0x82DDF30", VA = "0x1882DEF30")]
	public LELKCPPPMEI(bool LENDMFMLEMB = false, bool IKJFPMBEHMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC70", Offset = "0x82DDC70", VA = "0x1882DEC70")]
	public void BAHFCECOEJD()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82DEE70", Offset = "0x82DDE70", VA = "0x1882DEE70")]
	public static LELKCPPPMEI EHAFMEMPAKB(LELKCPPPMEI IBAKGNCJCMJ, Action DMHPHEGJKMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82DEED0", Offset = "0x82DDED0", VA = "0x1882DEED0")]
	public static LELKCPPPMEI NGOFFJNCAPO(LELKCPPPMEI IBAKGNCJCMJ, Action DMHPHEGJKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PFIHPBENEDJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOPEKGIEJEC(Action<T> DMHPHEGJKMB, bool PMMKCLMLGLM = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKIPLGLLFFP(Action<T> DMHPHEGJKMB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FHLIAIDPCMK<T> : FOEMMINANJI<Action<T>>, PFIHPBENEDJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D96EA0", Offset = "0x4D95EA0", VA = "0x184D96EA0")]
	public FHLIAIDPCMK(bool LENDMFMLEMB = false, bool IKJFPMBEHMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D969D0", Offset = "0x4D959D0", VA = "0x184D969D0")]
	public void BAHFCECOEJD(T HBPDACJCCKM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D96D80", Offset = "0x4D95D80", VA = "0x184D96D80")]
	public static FHLIAIDPCMK<T> EHAFMEMPAKB(FHLIAIDPCMK<T> IBAKGNCJCMJ, Action<T> DMHPHEGJKMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D96E10", Offset = "0x4D95E10", VA = "0x184D96E10")]
	public static FHLIAIDPCMK<T> NGOFFJNCAPO(FHLIAIDPCMK<T> IBAKGNCJCMJ, Action<T> DMHPHEGJKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NBJGOKOKEKK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOPEKGIEJEC(Action<T, U> DMHPHEGJKMB, bool PMMKCLMLGLM = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKIPLGLLFFP(Action<T, U> DMHPHEGJKMB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class MDNONHHFIOF<T, U> : FOEMMINANJI<Action<T, U>>, NBJGOKOKEKK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D96EA0", Offset = "0x4D95EA0", VA = "0x184D96EA0")]
	public MDNONHHFIOF(bool LENDMFMLEMB = false, bool IKJFPMBEHMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x569CB20", Offset = "0x569BB20", VA = "0x18569CB20")]
	public void BAHFCECOEJD(T HBPDACJCCKM, U BPLNAAIEKBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D96D80", Offset = "0x4D95D80", VA = "0x184D96D80")]
	public static MDNONHHFIOF<T, U> EHAFMEMPAKB(MDNONHHFIOF<T, U> IBAKGNCJCMJ, Action<T, U> DMHPHEGJKMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D96E10", Offset = "0x4D95E10", VA = "0x184D96E10")]
	public static MDNONHHFIOF<T, U> NGOFFJNCAPO(MDNONHHFIOF<T, U> IBAKGNCJCMJ, Action<T, U> DMHPHEGJKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class GHCPNHMBOCA<T, U, V> : FOEMMINANJI<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D96EA0", Offset = "0x4D95EA0", VA = "0x184D96EA0")]
	public GHCPNHMBOCA(bool LENDMFMLEMB = false, bool IKJFPMBEHMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7840", Offset = "0x4EB6840", VA = "0x184EB7840")]
	public void BAHFCECOEJD(T HBPDACJCCKM, U BPLNAAIEKBH, V LJALOPCLDCK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4D96D80", Offset = "0x4D95D80", VA = "0x184D96D80")]
	public static GHCPNHMBOCA<T, U, V> EHAFMEMPAKB(GHCPNHMBOCA<T, U, V> IBAKGNCJCMJ, Action<T, U, V> DMHPHEGJKMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D96E10", Offset = "0x4D95E10", VA = "0x184D96E10")]
	public static GHCPNHMBOCA<T, U, V> NGOFFJNCAPO(GHCPNHMBOCA<T, U, V> IBAKGNCJCMJ, Action<T, U, V> DMHPHEGJKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FDLFLHLPMJD<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class PAEMPNPEBDK<T, U, V, W> : FOEMMINANJI<Action<T, U, V, W>>, FDLFLHLPMJD<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D96EA0", Offset = "0x4D95EA0", VA = "0x184D96EA0")]
	public PAEMPNPEBDK(bool LENDMFMLEMB = false, bool IKJFPMBEHMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B420", Offset = "0x5A1A420", VA = "0x185A1B420")]
	public void BAHFCECOEJD(T HBPDACJCCKM, U BPLNAAIEKBH, V LJALOPCLDCK, W PGMOKNOMMMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D96D80", Offset = "0x4D95D80", VA = "0x184D96D80")]
	public static PAEMPNPEBDK<T, U, V, W> EHAFMEMPAKB(PAEMPNPEBDK<T, U, V, W> IBAKGNCJCMJ, Action<T, U, V, W> DMHPHEGJKMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4D96E10", Offset = "0x4D95E10", VA = "0x184D96E10")]
	public static PAEMPNPEBDK<T, U, V, W> NGOFFJNCAPO(PAEMPNPEBDK<T, U, V, W> IBAKGNCJCMJ, Action<T, U, V, W> DMHPHEGJKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FMNCAGNLGKH<T, U, V, W, X> : FOEMMINANJI<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4D96EA0", Offset = "0x4D95EA0", VA = "0x184D96EA0")]
	public FMNCAGNLGKH(bool LENDMFMLEMB = false, bool IKJFPMBEHMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4DAD010", Offset = "0x4DAC010", VA = "0x184DAD010")]
	public void BAHFCECOEJD(T HBPDACJCCKM, U BPLNAAIEKBH, V LJALOPCLDCK, W PGMOKNOMMMJ, X OEFDFBLCHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4D96D80", Offset = "0x4D95D80", VA = "0x184D96D80")]
	public static FMNCAGNLGKH<T, U, V, W, X> EHAFMEMPAKB(FMNCAGNLGKH<T, U, V, W, X> IBAKGNCJCMJ, Action<T, U, V, W, X> DMHPHEGJKMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D96E10", Offset = "0x4D95E10", VA = "0x184D96E10")]
	public static FMNCAGNLGKH<T, U, V, W, X> NGOFFJNCAPO(FMNCAGNLGKH<T, U, V, W, X> IBAKGNCJCMJ, Action<T, U, V, W, X> DMHPHEGJKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ICLAHEOIDEF<T, U, V, W, X, Y> : FOEMMINANJI<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D96EA0", Offset = "0x4D95EA0", VA = "0x184D96EA0")]
	public ICLAHEOIDEF(bool LENDMFMLEMB = false, bool IKJFPMBEHMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5008E20", Offset = "0x5007E20", VA = "0x185008E20")]
	public void BAHFCECOEJD(T HBPDACJCCKM, U BPLNAAIEKBH, V LJALOPCLDCK, W PGMOKNOMMMJ, X OEFDFBLCHHF, Y GDBEEAKMPMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D96D80", Offset = "0x4D95D80", VA = "0x184D96D80")]
	public static ICLAHEOIDEF<T, U, V, W, X, Y> EHAFMEMPAKB(ICLAHEOIDEF<T, U, V, W, X, Y> IBAKGNCJCMJ, Action<T, U, V, W, X, Y> DMHPHEGJKMB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D96E10", Offset = "0x4D95E10", VA = "0x184D96E10")]
	public static ICLAHEOIDEF<T, U, V, W, X, Y> NGOFFJNCAPO(ICLAHEOIDEF<T, U, V, W, X, Y> IBAKGNCJCMJ, Action<T, U, V, W, X, Y> DMHPHEGJKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BONBCNIPFCH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JNNLABIDEOO<TKey, TVal> IAKODJKEKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FOLLFLNLNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JNNLABIDEOO<TKey, TVal>.JHONMCCPFJH? KMIOHKFDJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int OLEIFAJKGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JNNLABIDEOO<TKey, TVal>.BLPLPDOBLDG? HJDOBHPMGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int CFMHNHNAJAN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int LPDPOJHPOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x652AAE0", Offset = "0x6529AE0", VA = "0x18652AAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OJEKMOODCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x652B500", Offset = "0x652A500", VA = "0x18652B500")]
	public BONBCNIPFCH(int OLEIFAJKGJA, [Optional] JNNLABIDEOO<TKey, TVal>.BLPLPDOBLDG? HJDOBHPMGOJ, [Optional] IEqualityComparer<TKey>? JEMEJNFHHJE, [Optional] JNNLABIDEOO<TKey, TVal>.JHONMCCPFJH? KMIOHKFDJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x652B230", Offset = "0x652A230", VA = "0x18652B230")]
	public void NCKGNPPOAOD(TKey DAKIIEIEKNI, TVal IOALKPFEKEK, bool IJHJJJAFPEO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x652AB20", Offset = "0x6529B20", VA = "0x18652AB20")]
	public bool EHBJKOMLMEG(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x652A7E0", Offset = "0x65297E0", VA = "0x18652A7E0")]
	public bool BOIPBPENDNC(TKey OOENCEFPPHA, [Out] TVal IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x652A8B0", Offset = "0x65298B0", VA = "0x18652A8B0")]
	private void DNDAAEGFFOK(TKey DAKIIEIEKNI, TVal IOALKPFEKEK, int BKLOHAHJLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x652A590", Offset = "0x6529590", VA = "0x18652A590")]
	public bool ANPEPJOGLNM(TKey DAKIIEIEKNI, TVal IOALKPFEKEK, bool IJHJJJAFPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x652B1D0", Offset = "0x652A1D0", VA = "0x18652B1D0")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x652AD10", Offset = "0x6529D10", VA = "0x18652AD10")]
	private void HKMAKMNLKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x652A700", Offset = "0x6529700", VA = "0x18652A700")]
	private bool BNEHPKBILDE(TKey DAKIIEIEKNI, MAINGJBGLPJ LPKJHGCILMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x652AC40", Offset = "0x6529C40", VA = "0x18652AC40")]
	private void GIABKJBLOLO(TKey DAKIIEIEKNI, TVal IOALKPFEKEK, MAINGJBGLPJ LPKJHGCILMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x652B3E0", Offset = "0x652A3E0", VA = "0x18652B3E0")]
	private void OKEHDHCBNBN(TKey DAKIIEIEKNI, TVal GHNFCHHGJAG, MAINGJBGLPJ LPKJHGCILMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BNOHBHKOIAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action KOJOMHIIBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NOGFKAPJOFB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public BNOHBHKOIAE(Action JAADGDFNDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82DCBC0", Offset = "0x82DBBC0", VA = "0x1882DCBC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x39DD070", Offset = "0x39DC070", VA = "0x1839DD070")]
	public static DMEMIKDFAED<T> MEFBGKEPBLF<T>(T IOALKPFEKEK, Action JAADGDFNDMC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class DMEMIKDFAED<T> : BNOHBHKOIAE where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4496EE0", Offset = "0x4495EE0", VA = "0x184496EE0")]
	public DMEMIKDFAED(T IOALKPFEKEK, Action JAADGDFNDMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class NKCJNDJFNDM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FBNNBHIIEKK<T>? PNMAFNELEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> PCGKKGKEPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool NOGFKAPJOFB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly NKCJNDJFNDM<T> JBLEAIPIMOC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> AFCNIHKEIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57941C0", Offset = "0x57931C0", VA = "0x1857941C0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5794240", Offset = "0x5793240", VA = "0x185794240")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BMKKEHNACIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5794000", Offset = "0x5793000", VA = "0x185794000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5794740", Offset = "0x5793740", VA = "0x185794740")]
	public NKCJNDJFNDM(FBNNBHIIEKK<T> ADILNGCOAGB, FBNNBHIIEKK<T> NMKCKPHKGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x57948B0", Offset = "0x57938B0", VA = "0x1857948B0")]
	public NKCJNDJFNDM(FBNNBHIIEKK<T> ADILNGCOAGB, int OBJODNIPNPB, FBNNBHIIEKK<T> NMKCKPHKGEE, int OLJOGIAEFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5794800", Offset = "0x5793800", VA = "0x185794800")]
	private NKCJNDJFNDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x57940C0", Offset = "0x57930C0", VA = "0x1857940C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5794570", Offset = "0x5793570", VA = "0x185794570")]
	public T[] OLMNNADJINC()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x57943C0", Offset = "0x57933C0", VA = "0x1857943C0")]
	public static ReadOnlySequence<T> MJOOONLKLLN(NKCJNDJFNDM<T>? DJMNHAGBIMA)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MIAMAPHBBME<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable FMEKOCOHDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T BDJLGAHJNPH;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x56D80C0", Offset = "0x56D70C0", VA = "0x1856D80C0")]
	public MIAMAPHBBME(IDisposable FICFFHNKAMC, [In] T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x42C5510", Offset = "0x42C4510", VA = "0x1842C5510")]
	public static MIAMAPHBBME<U> LHKGKDHCDLP<U>([In] MIAMAPHBBME<T> FICFFHNKAMC, [In] U IOALKPFEKEK) where U : notnull
	{
		return default(MIAMAPHBBME<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x56D8020", Offset = "0x56D7020", VA = "0x1856D8020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HHENACHEBPL
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C73940", Offset = "0x3C72940", VA = "0x183C73940")]
	public static MIAMAPHBBME<T> MPFKOOIPONO<T>(IDisposable FICFFHNKAMC, [In] T IOALKPFEKEK) where T : notnull
	{
		return default(MIAMAPHBBME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C738E0", Offset = "0x3C728E0", VA = "0x183C738E0")]
	public static MIAMAPHBBME<T> JKBNEFIEJEJ<T>([In] this MIAMAPHBBME<T> OLHDOIOOPGE, [Out] T IOALKPFEKEK) where T : notnull
	{
		return default(MIAMAPHBBME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3C2FDF0", Offset = "0x3C2EDF0", VA = "0x183C2FDF0")]
	public static MIAMAPHBBME<U?> LHKGKDHCDLP<U, T>([In] MIAMAPHBBME<T> AFIGJKPGHJN, [In] U IOALKPFEKEK)
	{
		return default(MIAMAPHBBME<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct CBOONJONPNE : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct GEEIHKNELBK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
		public static GEEIHKNELBK MPFKOOIPONO()
		{
			return default(GEEIHKNELBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82DCC00", Offset = "0x82DBC00", VA = "0x1882DCC00")]
	public static string HADKJGLLCJI(Type BJLNCBFOGNL, [Optional] string? OMAFOLLJKHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C010", Offset = "0x3A3B010", VA = "0x183A3C010")]
	public static string? HADKJGLLCJI<T>([Optional] string? OMAFOLLJKHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A3BF90", Offset = "0x3A3AF90", VA = "0x183A3BF90")]
	public static string? GIHAJDGGEAI<T>([Optional] string? FFKMHOMPGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
	public static CBOONJONPNE PGHEBAMGCKG(string OMAFOLLJKHF, string? FFKMHOMPGOG)
	{
		return default(CBOONJONPNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FAMPAELGAGC
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool CCOLODBJNCG(string CKFOLAOAKNO, FAMPAELGAGC LJLOJCKDILF);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HFCNMMAOFBL<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HFCNMMAOFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A2A0", Offset = "0x4F392A0", VA = "0x184F3A2A0")]
		internal void LJCGMJICDJI(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int EINBKGFECKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string CFCJBFAKNLE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82DD540", Offset = "0x82DC540", VA = "0x1882DD540")]
	public static Dictionary<string, FAMPAELGAGC> LMAJIGIJLEP(Type NJDEACBHLAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C630", Offset = "0x3C2B630", VA = "0x183C2C630")]
	public static Dictionary<string, FAMPAELGAGC> LMAJIGIJLEP<T>(Type NJDEACBHLAK, IReadOnlyDictionary<T, string> NMKMKDHPCIO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3C2CE60", Offset = "0x3C2BE60", VA = "0x183C2CE60")]
	public static Dictionary<string, FAMPAELGAGC> MFOCCLGKNAC<T>(List<T> KEMCFHLGLJP) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82DD870", Offset = "0x82DC870", VA = "0x1882DD870")]
	public static Dictionary<string, FAMPAELGAGC> MJNGDPFCDDO(Type NJDEACBHLAK, CCOLODBJNCG GDLJKCALAPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82DD380", Offset = "0x82DC380", VA = "0x1882DD380")]
	public static Dictionary<int, string> JBDEHPNPLNF(Dictionary<string, FAMPAELGAGC> MKOOPFGGHLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class JFHNFKOLNEJ : BJPMMCEJAGH
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool NGBJLIMLFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? DBBACCGBJAC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual BJPMMCEJAGH? MLHIFEDAFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x82DE860", Offset = "0x82DD860", VA = "0x1882DE860")]
	protected JFHNFKOLNEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string OFBAEHEOPOE();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82DE460", Offset = "0x82DD460", VA = "0x1882DE460", Slot = "8")]
	public virtual string DECKNFGLCDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82DE1C0", Offset = "0x82DD1C0", VA = "0x1882DE1C0", Slot = "9")]
	public void CMKNHDFEJME(StringBuilder CLDLIPEGJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82DE4E0", Offset = "0x82DD4E0", VA = "0x1882DE4E0", Slot = "10")]
	public void HMHNFBGGLAD(StringBuilder CLDLIPEGJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x82DE540", Offset = "0x82DD540", VA = "0x1882DE540", Slot = "11")]
	public void IKEBMFEKFGF(StringBuilder CLDLIPEGJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82DE700", Offset = "0x82DD700", VA = "0x1882DE700", Slot = "12")]
	public void PBKCBBGALIL(StringBuilder CLDLIPEGJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x82DE660", Offset = "0x82DD660", VA = "0x1882DE660")]
	public static void LCELEGBAGCA(StringBuilder CLDLIPEGJJL, string CJOMCGGBBON, string LHHOMPJNJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71D0990", Offset = "0x71CF990", VA = "0x1871D0990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EKGFAFJAIHO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82DD320", Offset = "0x82DC320", VA = "0x1882DD320")]
	public EKGFAFJAIHO(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NLDPEFLCGDC<TErr> : EKGFAFJAIHO where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr KHCFDGKDJDE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5798160", Offset = "0x5797160", VA = "0x185798160")]
	private NLDPEFLCGDC([In] TErr PFLBCFINGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57980A0", Offset = "0x57970A0", VA = "0x1857980A0")]
	public static NLDPEFLCGDC<TErr> MPFKOOIPONO([In] TErr PFLBCFINGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AEFHMNFIEDN : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm GHPJPLACMED;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool FLHKDMFLLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool DBBFGCDIJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool PLABOHEJDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82DC110", Offset = "0x82DB110", VA = "0x1882DC110", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long JILMILDHLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x82DC180", Offset = "0x82DB180", VA = "0x1882DC180", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82DC1F0", Offset = "0x82DB1F0", VA = "0x1882DC1F0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82DC0A0", Offset = "0x82DB0A0", VA = "0x1882DC0A0")]
	public AEFHMNFIEDN(HashAlgorithm GHPJPLACMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x82DBEC0", Offset = "0x82DAEC0", VA = "0x1882DBEC0", Slot = "35")]
	public override int Read(byte[] MPPMMFHHGAK, int MOAJDMPNBPN, int MFFPIAPMHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82DC070", Offset = "0x82DB070", VA = "0x1882DC070", Slot = "38")]
	public override void Write(byte[] MPPMMFHHGAK, int MOAJDMPNBPN, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82DBF60", Offset = "0x82DAF60", VA = "0x1882DBF60", Slot = "33")]
	public override long Seek(long MOAJDMPNBPN, SeekOrigin NAOOBLMKEHE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82DBFF0", Offset = "0x82DAFF0", VA = "0x1882DBFF0", Slot = "34")]
	public override void SetLength(long IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82DBDE0", Offset = "0x82DADE0", VA = "0x1882DBDE0")]
	public byte[] GPDPLJBMEJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BJPMMCEJAGH
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DECKNFGLCDD();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OFBAEHEOPOE();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BKCCENPKEOH<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface ACOHEBNAIHI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string IOMFGAJJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FBNNBHIIEKK<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static FBNNBHIIEKK<T>? BDHECAFMNBI;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object FKNJFGEDJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? FDKMKBIJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool NOGFKAPJOFB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool CEHLMEAICFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xABB4F0", Offset = "0xABA4F0", VA = "0x180ABB4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4D76E60", Offset = "0x4D75E60", VA = "0x184D76E60")]
	private static FBNNBHIIEKK<T> MNIEPJJBAGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4D76030", Offset = "0x4D75030", VA = "0x184D76030")]
	private static void GAIIBGCJALP(FBNNBHIIEKK<T> MDFHODFKIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x48F9010", Offset = "0x48F8010", VA = "0x1848F9010")]
	private FBNNBHIIEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4D76800", Offset = "0x4D75800", VA = "0x184D76800")]
	public static FBNNBHIIEKK<T> MEFBGKEPBLF(ReadOnlyMemory<T> DFGJHNEFDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4D769B0", Offset = "0x4D759B0", VA = "0x184D769B0")]
	public static FBNNBHIIEKK<T> MEFBGKEPBLF(IMemoryOwner<T> FJBGNMDHALB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4D76D50", Offset = "0x4D75D50", VA = "0x184D76D50")]
	public static void MIMEDHEPMKN(FBNNBHIIEKK<T> ADILNGCOAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4D75E20", Offset = "0x4D74E20", VA = "0x184D75E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4D76740", Offset = "0x4D75740", VA = "0x184D76740")]
	public FBNNBHIIEKK<T> KFJPMHBMPGL(IMemoryOwner<T> FJBGNMDHALB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D76580", Offset = "0x4D75580", VA = "0x184D76580")]
	private void IHIEJBBBPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D772D0", Offset = "0x4D762D0", VA = "0x184D772D0")]
	private FBNNBHIIEKK<T> NOGFBAJLIAC(FBNNBHIIEKK<T> MDFHODFKIMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MBADLMNCJKI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82DF080", Offset = "0x82DE080", VA = "0x1882DF080")]
	public MBADLMNCJKI(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KJDOJMLKBDH<TOk> : MBADLMNCJKI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk MEIMBBHKNPG;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53C8740", Offset = "0x53C7740", VA = "0x1853C8740")]
	private KJDOJMLKBDH([In] TOk KLNCABDNLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53C8560", Offset = "0x53C7560", VA = "0x1853C8560")]
	public static KJDOJMLKBDH<TOk> MPFKOOIPONO([In] TOk KLNCABDNLHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DAFIFKKNPFP<TOk, TErr> : IEquatable<DAFIFKKNPFP<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> IMOOBMIHPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr KHCFDGKDJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk MEIMBBHKNPG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool DGIDBAJGGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E6DFB0", Offset = "0x6E6CFB0", VA = "0x186E6DFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool CFBBIHNAIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E6C580", Offset = "0x6E6B580", VA = "0x186E6C580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6E6FF80", Offset = "0x6E6EF80", VA = "0x186E6FF80")]
	internal DAFIFKKNPFP([In] TErr PFLBCFINGFG, [In] TOk KLNCABDNLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E6D2A0", Offset = "0x6E6C2A0", VA = "0x186E6D2A0")]
	public static DAFIFKKNPFP<TOk, TErr> FNNPJAIMCAD([In] TErr PFLBCFINGFG)
	{
		return default(DAFIFKKNPFP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C150", Offset = "0x6E6B150", VA = "0x186E6C150")]
	public static DAFIFKKNPFP<TOk, TErr> BJMNBDCIKJJ([In] TOk KLNCABDNLHI)
	{
		return default(DAFIFKKNPFP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C520", Offset = "0x3D6B520", VA = "0x183D6C520")]
	public DAFIFKKNPFP<TOk?, UErr?> PAKDAJDGDLD<UErr>()
	{
		return default(DAFIFKKNPFP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AF40", Offset = "0x3D69F40", VA = "0x183D6AF40")]
	public DAFIFKKNPFP<UOk?, TErr?> LDIAPEINIBA<UOk>()
	{
		return default(DAFIFKKNPFP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3D6BF20", Offset = "0x3D6AF20", VA = "0x183D6BF20")]
	public DAFIFKKNPFP<UOk?, TErr?> LPHHIHAIHFE<UOk>()
	{
		return default(DAFIFKKNPFP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D6CDB0", Offset = "0x3D6BDB0", VA = "0x183D6CDB0")]
	public DAFIFKKNPFP<TOk?, UErr?> PEMMBMGMLOO<UErr>()
	{
		return default(DAFIFKKNPFP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C3D0", Offset = "0x6E6B3D0", VA = "0x186E6C3D0")]
	public DAFIFKKNPFP<GAAICFLNCNK, TErr> CLFKGKBCCID()
	{
		return default(DAFIFKKNPFP<GAAICFLNCNK, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E6E260", Offset = "0x6E6D260", VA = "0x186E6E260")]
	public static bool PHGIAKEDBEK([In] DAFIFKKNPFP<TOk, TErr> AKPAAKDLPCB, [In] DAFIFKKNPFP<TOk, TErr> AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C730", Offset = "0x6E6B730", VA = "0x186E6C730", Slot = "4")]
	public bool Equals(DAFIFKKNPFP<TOk, TErr> EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C7F0", Offset = "0x6E6B7F0", VA = "0x186E6C7F0", Slot = "0")]
	public override bool Equals(object EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E6DAE0", Offset = "0x6E6CAE0", VA = "0x186E6DAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F090", Offset = "0x6E6E090", VA = "0x186E6F090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class HDEOBLKLKHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct ANKMKGMMHFF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<DAFIFKKNPFP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<DAFIFKKNPFP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x527D4B0", Offset = "0x527C4B0", VA = "0x18527D4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4DC1810", Offset = "0x4DC0810", VA = "0x184DC1810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct KGBMICBHHLO<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<GAAICFLNCNK, TErr>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Task<DAFIFKKNPFP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<DAFIFKKNPFP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x53AFC10", Offset = "0x53AEC10", VA = "0x1853AFC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4902470", Offset = "0x4901470", VA = "0x184902470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E9E0", Offset = "0x3C6D9E0", VA = "0x183C6E9E0")]
	public static DAFIFKKNPFP<TOk?, TErr?> MEIMBBHKNPG<TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [In] TOk KLNCABDNLHI)
	{
		return default(DAFIFKKNPFP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3C70700", Offset = "0x3C6F700", VA = "0x183C70700")]
	public static DAFIFKKNPFP<GAAICFLNCNK, TErr?> MEIMBBHKNPG<TErr>([In] this DAFIFKKNPFP<GAAICFLNCNK, TErr> OLHDOIOOPGE)
	{
		return default(DAFIFKKNPFP<GAAICFLNCNK, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E9E0", Offset = "0x3C6D9E0", VA = "0x183C6E9E0")]
	public static DAFIFKKNPFP<TOk?, TErr?> KHCFDGKDJDE<TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [In] TErr PFLBCFINGFG)
	{
		return default(DAFIFKKNPFP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C704E0", Offset = "0x3C6F4E0", VA = "0x183C704E0")]
	public static TOk? MCMLBPOJKOB<TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C70A10", Offset = "0x3C6FA10", VA = "0x183C70A10")]
	[AsyncStateMachine(typeof(ANKMKGMMHFF<, >))]
	public static Task<TOk?>? NCGKBNJICHH<TOk, TErr>(this Task<DAFIFKKNPFP<TOk, TErr>> OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C717B0", Offset = "0x3C707B0", VA = "0x183C717B0")]
	public static TErr? PHIPEFNOGAD<TErr, TOk>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C6EDC0", Offset = "0x3C6DDC0", VA = "0x183C6EDC0")]
	public static bool LGFMCNHELDK<TOk, TErr, UErr, UOk>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [Out] DAFIFKKNPFP<UOk, UErr> GPIAGJEBNHK) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E410", Offset = "0x3C6D410", VA = "0x183C6E410")]
	public static bool JAIKOBBGIKI<TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [Out] TOk KLNCABDNLHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DAA0", Offset = "0x3C6CAA0", VA = "0x183C6DAA0")]
	public static bool BHHIAENKIMB<TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [Out][NotNullWhen(true)] TErr PFLBCFINGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3C719A0", Offset = "0x3C709A0", VA = "0x183C719A0")]
	public static bool POKCKAIGJAG<TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [Out][NotNullWhen(true)] TOk KLNCABDNLHI, [Out][NotNullWhen(false)] TErr PFLBCFINGFG) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D9A0", Offset = "0x3C6C9A0", VA = "0x183C6D9A0")]
	public static bool AOLHCFHIPHJ<TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [Out][NotNullWhen(true)] TOk KLNCABDNLHI, [Out] DAFIFKKNPFP<TOk, TErr> GPIAGJEBNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F140", Offset = "0x3C6E140", VA = "0x183C6F140")]
	public static bool LGFMCNHELDK<TOk, TErr, UErr, UOk>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [Out][NotNullWhen(true)] TOk KLNCABDNLHI, [Out] DAFIFKKNPFP<UOk, UErr> GPIAGJEBNHK) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DCB0", Offset = "0x3C6CCB0", VA = "0x183C6DCB0")]
	public static bool EOGNLJHKGLN<TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [Out][NotNullWhen(true)] TOk KLNCABDNLHI, [Out] DAFIFKKNPFP<GAAICFLNCNK, TErr> GPIAGJEBNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3C70F30", Offset = "0x3C6FF30", VA = "0x183C70F30")]
	public static DAFIFKKNPFP<UOk, UErr> NDNJKGAKLEH<UOk, UErr, TOk, TErr>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, [In] DAFIFKKNPFP<UOk, UErr> CIABMLDDFBB) where TOk : UOk where TErr : UErr
	{
		return default(DAFIFKKNPFP<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E6A0", Offset = "0x3C6D6A0", VA = "0x183C6E6A0")]
	public static DAFIFKKNPFP<TOk?[]?, TErr?> JMEJBMLEGOP<TOk, TErr>(this IEnumerable<DAFIFKKNPFP<TOk, TErr>> OLHDOIOOPGE)
	{
		return default(DAFIFKKNPFP<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E1D0", Offset = "0x3C6D1D0", VA = "0x183C6E1D0")]
	public static DAFIFKKNPFP<UOk?, TErr?> IBDNFGELPGG<UOk, TErr, TOk>([In] this DAFIFKKNPFP<TOk, TErr> OLHDOIOOPGE, Func<TOk, UOk> NKPOAIDJOHI)
	{
		return default(DAFIFKKNPFP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E010", Offset = "0x3C6D010", VA = "0x183C6E010")]
	[AsyncStateMachine(typeof(KGBMICBHHLO<, >))]
	public static Task<DAFIFKKNPFP<GAAICFLNCNK, TErr?>>? GHBBHAKIJCE<TErr, TOk>(this Task<DAFIFKKNPFP<TOk, TErr>> OLHDOIOOPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OJAJFEBFPJD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x438A0E0", Offset = "0x43890E0", VA = "0x18438A0E0")]
	public static DAFIFKKNPFP<TOk, T> MEIMBBHKNPG<TOk>([In] TOk KLNCABDNLHI) where TOk : notnull
	{
		return default(DAFIFKKNPFP<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x593D510", Offset = "0x593C510", VA = "0x18593D510")]
	public static DAFIFKKNPFP<GAAICFLNCNK, T> MEIMBBHKNPG()
	{
		return default(DAFIFKKNPFP<GAAICFLNCNK, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x438A0E0", Offset = "0x43890E0", VA = "0x18438A0E0")]
	public static DAFIFKKNPFP<T, TErr> KHCFDGKDJDE<TErr>([In] TErr PFLBCFINGFG) where TErr : notnull
	{
		return default(DAFIFKKNPFP<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct PKGIMJLHHFI<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly CLDPPAFAHJG KDPMBMPHEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TValue> EFAOLJEGOGA;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x52A3620", Offset = "0x52A2620", VA = "0x1852A3620")]
	public static PKGIMJLHHFI<TKey, TValue> MPFKOOIPONO(string IEGLIFIOOBM)
	{
		return default(PKGIMJLHHFI<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x52A3730", Offset = "0x52A2730", VA = "0x1852A3730")]
	internal PKGIMJLHHFI(Dictionary<TKey, TValue> IOALKPFEKEK, CLDPPAFAHJG KBKEHHCFDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x52A3580", Offset = "0x52A2580", VA = "0x1852A3580")]
	public BLEIBCGJMMI<TKey, TValue> CEILKKKNBJB([Out] Dictionary<TKey, TValue> IOALKPFEKEK)
	{
		return default(BLEIBCGJMMI<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BLEIBCGJMMI<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TKey, TValue> EFAOLJEGOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly APOPOOKJMEP MOPBAJFMPND;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2CA00C0", Offset = "0x2C9F0C0", VA = "0x182CA00C0")]
	internal BLEIBCGJMMI(Dictionary<TKey, TValue> IOALKPFEKEK, APOPOOKJMEP IJHBPHOGCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x54B8870", Offset = "0x54B7870", VA = "0x1854B8870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NABPDDAAPOC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CLDPPAFAHJG KDPMBMPHEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HashSet<T> EFAOLJEGOGA;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x52A3620", Offset = "0x52A2620", VA = "0x1852A3620")]
	public static NABPDDAAPOC<T> MPFKOOIPONO(string IEGLIFIOOBM)
	{
		return default(NABPDDAAPOC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x52A3730", Offset = "0x52A2730", VA = "0x1852A3730")]
	internal NABPDDAAPOC(HashSet<T> IOALKPFEKEK, CLDPPAFAHJG KBKEHHCFDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x52A3580", Offset = "0x52A2580", VA = "0x1852A3580")]
	public NMHOMKDIFDI<T> CEILKKKNBJB([Out] HashSet<T> IOALKPFEKEK)
	{
		return default(NMHOMKDIFDI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct NMHOMKDIFDI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly HashSet<T> EFAOLJEGOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly APOPOOKJMEP MOPBAJFMPND;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2CA00C0", Offset = "0x2C9F0C0", VA = "0x182CA00C0")]
	internal NMHOMKDIFDI(HashSet<T> IOALKPFEKEK, APOPOOKJMEP IJHBPHOGCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x54B8870", Offset = "0x54B7870", VA = "0x1854B8870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct JFPCAKLDIHL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CLDPPAFAHJG KDPMBMPHEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Stack<T> EFAOLJEGOGA;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x52A3620", Offset = "0x52A2620", VA = "0x1852A3620")]
	public static JFPCAKLDIHL<T> MPFKOOIPONO(string IEGLIFIOOBM)
	{
		return default(JFPCAKLDIHL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x52A3730", Offset = "0x52A2730", VA = "0x1852A3730")]
	internal JFPCAKLDIHL(Stack<T> IOALKPFEKEK, CLDPPAFAHJG KBKEHHCFDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x52A3580", Offset = "0x52A2580", VA = "0x1852A3580")]
	public LNCFBJNEEJL<T> CEILKKKNBJB([Out] Stack<T> IOALKPFEKEK)
	{
		return default(LNCFBJNEEJL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct LNCFBJNEEJL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly Stack<T> EFAOLJEGOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly APOPOOKJMEP MOPBAJFMPND;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA00C0", Offset = "0x2C9F0C0", VA = "0x182CA00C0")]
	internal LNCFBJNEEJL(Stack<T> IOALKPFEKEK, APOPOOKJMEP IJHBPHOGCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x54B8870", Offset = "0x54B7870", VA = "0x1854B8870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DefaultMember("Item")]
public sealed class JMDKFENJEHH<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct CEIMHECHBKF : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly JMDKFENJEHH<T> POAHHDEFLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly int KPDCJPEFEDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool BECJCIPJDBG;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28EF570", Offset = "0x28EE570", VA = "0x1828EF570")]
		public CEIMHECHBKF(JMDKFENJEHH<T> JOEHPNNMIOL, int IOILIABBENH, bool PABLONCBPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x68AD640", Offset = "0x68AC640", VA = "0x1868AD640")]
		public JMDKFENJEHH<T>.HCEHLADLDMO GHDHEBFDHCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x68AD720", Offset = "0x68AC720", VA = "0x1868AD720", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x68AD720", Offset = "0x68AC720", VA = "0x1868AD720", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class HCEHLADLDMO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly JMDKFENJEHH<T> POAHHDEFLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly int HJHGLMCCKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int LIKLAKLPDOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly bool BECJCIPJDBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool AENHGKNPCPI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4F33830", Offset = "0x4F32830", VA = "0x184F33830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x4F33A70", Offset = "0x4F32A70", VA = "0x184F33A70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x4F33C70", Offset = "0x4F32C70", VA = "0x184F33C70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4F341B0", Offset = "0x4F331B0", VA = "0x184F341B0")]
		public HCEHLADLDMO(JMDKFENJEHH<T> JOEHPNNMIOL, int IOILIABBENH, bool PABLONCBPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4F338F0", Offset = "0x4F328F0", VA = "0x184F338F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4F33970", Offset = "0x4F32970", VA = "0x184F33970", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KAKDBCBNLAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KAKDBCBNLAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5395950", Offset = "0x5394950", VA = "0x185395950")]
		internal T IPHOKKAPDOM(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly T[] LHGNOOIFNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int LIKLAKLPDOC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EOOCOJFFIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x52BA490", Offset = "0x52B9490", VA = "0x1852BA490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T AJOLFNCECJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4D71D30", Offset = "0x4D70D30", VA = "0x184D71D30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T KBDAEPHICEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x52BA6E0", Offset = "0x52B96E0", VA = "0x1852BA6E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x52BA4D0", Offset = "0x52B94D0", VA = "0x1852BA4D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x289D3F0", Offset = "0x289C3F0", VA = "0x18289D3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CD7640", Offset = "0x1CD6640", VA = "0x181CD7640")]
	private static int CAEJPFLLFOP(int HLGKMAPOEBE, int FCCMJLNEMIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x52BA7C0", Offset = "0x52B97C0", VA = "0x1852BA7C0")]
	public JMDKFENJEHH(int BKLOHAHJLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x52BA830", Offset = "0x52B9830", VA = "0x1852BA830")]
	public JMDKFENJEHH(int BKLOHAHJLKP, Func<T> PLDOINGHJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x52BAC10", Offset = "0x52B9C10", VA = "0x1852BAC10")]
	public JMDKFENJEHH(T[] NKOHPCLOFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x52BA790", Offset = "0x52B9790", VA = "0x1852BA790")]
	public void JJJALPGLOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x52BA620", Offset = "0x52B9620", VA = "0x1852BA620")]
	public IEnumerable<T> EPHGDBNGJKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x52BA710", Offset = "0x52B9710", VA = "0x1852BA710")]
	public JMDKFENJEHH<T>.HCEHLADLDMO GHDHEBFDHCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B420", Offset = "0x4E4A420", VA = "0x184E4B420", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B420", Offset = "0x4E4A420", VA = "0x184E4B420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class ANFKJPECDIB
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x31ACD00", Offset = "0x31ABD00", VA = "0x1831ACD00")]
	public static JMDKFENJEHH<T> MPFKOOIPONO<T>(int BKLOHAHJLKP, Func<T> PLDOINGHJNC) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6EDB1B0", Offset = "0x6EDA1B0", VA = "0x186EDB1B0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x82E01D0", Offset = "0x82DF1D0", VA = "0x1882E01D0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x82E01F0", Offset = "0x82DF1F0", VA = "0x1882E01F0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x82E0210", Offset = "0x82DF210", VA = "0x1882E0210")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x82E01B0", Offset = "0x82DF1B0", VA = "0x1882E01B0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A28A00", Offset = "0x2A27A00", VA = "0x182A28A00")]
		public RRColor(float AEJLPHJDEHN, float MBDFGBLNLEC, float LDPKBPICKKH, float JDINPJIAKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8159660", Offset = "0x8158660", VA = "0x188159660", Slot = "4")]
		public bool Equals(RRColor EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x82DFDF0", Offset = "0x82DEDF0", VA = "0x1882DFDF0", Slot = "0")]
		public override bool Equals(object EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x82DFEF0", Offset = "0x82DEEF0", VA = "0x1882DFEF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x82DFF70", Offset = "0x82DEF70", VA = "0x1882DFF70", Slot = "5")]
		public string ToString(string IEAPGIAMHDB, IFormatProvider MACLOGBKBBE)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x82DFD90", Offset = "0x82DED90", VA = "0x1882DFD90")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x82DFD30", Offset = "0x82DED30", VA = "0x1882DFD30")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x82DFD60", Offset = "0x82DED60", VA = "0x1882DFD60")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x82DFDC0", Offset = "0x82DEDC0", VA = "0x1882DFDC0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x82DFD00", Offset = "0x82DED00", VA = "0x1882DFD00")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60CA8B0", Offset = "0x60C98B0", VA = "0x1860CA8B0")]
		public RRColor32(byte AEJLPHJDEHN, byte MBDFGBLNLEC, byte LDPKBPICKKH, byte JDINPJIAKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x242CF30", Offset = "0x242BF30", VA = "0x18242CF30", Slot = "4")]
		public bool Equals(RRColor32 EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x82DF840", Offset = "0x82DE840", VA = "0x1882DF840", Slot = "0")]
		public override bool Equals(object EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x152C290", Offset = "0x152B290", VA = "0x18152C290", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x82DF940", Offset = "0x82DE940", VA = "0x1882DF940")]
		public static RRColor32 MJOOONLKLLN(RRColor JKODNDABGFB)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x82DF8D0", Offset = "0x82DE8D0", VA = "0x1882DF8D0")]
		public static RRColor MJOOONLKLLN(RRColor32 JKODNDABGFB)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x82DFA90", Offset = "0x82DEA90", VA = "0x1882DFA90", Slot = "5")]
		public string ToString(string IEAPGIAMHDB, IFormatProvider MACLOGBKBBE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class BPPFLNOBPFP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct IHFDDCOLAHJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly BPPFLNOBPFP<T> KDCFBBLEMOL;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T BDJLGAHJNPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x501C410", Offset = "0x501B410", VA = "0x18501C410")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x501C3E0", Offset = "0x501B3E0", VA = "0x18501C3E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
		public IHFDDCOLAHJ(BPPFLNOBPFP<T> KDCFBBLEMOL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct LNPGHPIFFPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<IHFDDCOLAHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public BPPFLNOBPFP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x54BACB0", Offset = "0x54B9CB0", VA = "0x1854BACB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4F51AE0", Offset = "0x4F50AE0", VA = "0x184F51AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly SemaphoreSlim CCOMLGGGNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private T LFGKBEOOJHO;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x65F20A0", Offset = "0x65F10A0", VA = "0x1865F20A0")]
	public BPPFLNOBPFP([In] T LFGKBEOOJHO, int IHMKFDGMFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x65F1F30", Offset = "0x65F0F30", VA = "0x1865F1F30")]
	public BPPFLNOBPFP([In] T LFGKBEOOJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x65F1A70", Offset = "0x65F0A70", VA = "0x1865F1A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x65F1EF0", Offset = "0x65F0EF0", VA = "0x1865F1EF0")]
	public IHFDDCOLAHJ JPGNNANKDDJ()
	{
		return default(IHFDDCOLAHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x65F1BC0", Offset = "0x65F0BC0", VA = "0x1865F1BC0")]
	[AsyncStateMachine(typeof(BPPFLNOBPFP<>.LNPGHPIFFPL))]
	public Task<BPPFLNOBPFP<T>.IHFDDCOLAHJ> INOBHPMIJGN(CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x65F1A50", Offset = "0x65F0A50", VA = "0x1865F1A50")]
	public void DOEILNLCCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LFBCDHLGMEI
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x82DEF90", Offset = "0x82DDF90", VA = "0x1882DEF90")]
	public static BPPFLNOBPFP<GAAICFLNCNK> MPFKOOIPONO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x39D4600", Offset = "0x39D3600", VA = "0x1839D4600")]
	public static BPPFLNOBPFP<T> MPFKOOIPONO<T>([In] T LFGKBEOOJHO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class GICJMHDFHOP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct LLDKCDLLDPD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly GICJMHDFHOP<T> KIJPBBGKOEK;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T BDJLGAHJNPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x54B7C50", Offset = "0x54B6C50", VA = "0x1854B7C50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x54B78F0", Offset = "0x54B68F0", VA = "0x1854B78F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
		internal LLDKCDLLDPD(GICJMHDFHOP<T> KDCFBBLEMOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct OMNLKLLFPOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly GICJMHDFHOP<T> KIJPBBGKOEK;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T BDJLGAHJNPH
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x54B7C50", Offset = "0x54B6C50", VA = "0x1854B7C50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5959350", Offset = "0x5958350", VA = "0x185959350", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
		internal OMNLKLLFPOI(GICJMHDFHOP<T> KDCFBBLEMOL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct AIGDGNEGDMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<OMNLKLLFPOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GICJMHDFHOP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private BPPFLNOBPFP<GAAICFLNCNK>.IHFDDCOLAHJ <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<BPPFLNOBPFP<GAAICFLNCNK>.IHFDDCOLAHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x519D050", Offset = "0x519C050", VA = "0x18519D050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4F51AE0", Offset = "0x4F50AE0", VA = "0x184F51AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly BPPFLNOBPFP<int> NPIGNIIFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BPPFLNOBPFP<GAAICFLNCNK> NBHKHMJIJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BPPFLNOBPFP<GAAICFLNCNK> ILEEDBCOJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private T PKPJFEEBMON;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB5C0", Offset = "0x4EBA5C0", VA = "0x184EBB5C0")]
	internal GICJMHDFHOP(BPPFLNOBPFP<int> JELEELJLBON, BPPFLNOBPFP<GAAICFLNCNK> DLAPDEGOJNH, BPPFLNOBPFP<GAAICFLNCNK> MJEGGEMNLLJ, [In] T LFGKBEOOJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA9D0", Offset = "0x4EB99D0", VA = "0x184EBA9D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB130", Offset = "0x4EBA130", VA = "0x184EBB130")]
	public LLDKCDLLDPD KBNPPCHGIKL()
	{
		return default(LLDKCDLLDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB4D0", Offset = "0x4EBA4D0", VA = "0x184EBB4D0")]
	public OMNLKLLFPOI KENBDFDJMJH()
	{
		return default(OMNLKLLFPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB70", Offset = "0x4EB9B70", VA = "0x184EBAB70")]
	[AsyncStateMachine(typeof(GICJMHDFHOP<>.AIGDGNEGDMG))]
	public Task<GICJMHDFHOP<T>.OMNLKLLFPOI> JIBONNKPMMH(CancellationToken KGALDHLEDNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DGOGKOAMGJH
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x82DD250", Offset = "0x82DC250", VA = "0x1882DD250")]
	public static GICJMHDFHOP<GAAICFLNCNK> MPFKOOIPONO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3A97300", Offset = "0x3A96300", VA = "0x183A97300")]
	public static GICJMHDFHOP<T> MPFKOOIPONO<T>([In] T LFGKBEOOJHO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class ENHFGEECAON<TData> : JFHNFKOLNEJ where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly string PKCPPLKFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly TData FGNOGEEOKID;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
	public override string OFBAEHEOPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4923520", Offset = "0x4922520", VA = "0x184923520")]
	internal ENHFGEECAON(string OBCNAJEENCI, [In] TData INCJDDLACNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LILMODOHAGE
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x82DF000", Offset = "0x82DE000", VA = "0x1882DF000")]
	public static ENHFGEECAON<GAAICFLNCNK> MPFKOOIPONO(string OBCNAJEENCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x39DD070", Offset = "0x39DC070", VA = "0x1839DD070")]
	public static ENHFGEECAON<TData> MPFKOOIPONO<TData>(string OBCNAJEENCI, [In] TData INCJDDLACNP) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class CLDPPAFAHJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal bool HJGEBPMNIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly string NOABAILENCL;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xF3BEA0", Offset = "0xF3AEA0", VA = "0x180F3BEA0")]
	private CLDPPAFAHJG(bool KGENHKKFNGN, string PHMCOGACBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x82DD100", Offset = "0x82DC100", VA = "0x1882DD100")]
	public static CLDPPAFAHJG MPFKOOIPONO(string PHMCOGACBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x82DD040", Offset = "0x82DC040", VA = "0x1882DD040")]
	public APOPOOKJMEP CEILKKKNBJB()
	{
		return default(APOPOOKJMEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct APOPOOKJMEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly CLDPPAFAHJG APPOPGIENKD;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
	internal APOPOOKJMEP(CLDPPAFAHJG IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x82DC270", Offset = "0x82DB270", VA = "0x1882DC270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class INDJJOOEBOI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class GLMLAAMAGGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GLMLAAMAGGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0FA0", Offset = "0x4ECFFA0", VA = "0x184ED0FA0")]
		internal int LDGJALPKPAI(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private HashSet<T>? CIPAHIKLLKF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> JOPCHBBDKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5040D50", Offset = "0x503FD50", VA = "0x185040D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CDGGPEIJCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5040E90", Offset = "0x503FE90", VA = "0x185040E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5040B80", Offset = "0x503FB80", VA = "0x185040B80")]
	public bool DOPEKGIEJEC(T GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5040D80", Offset = "0x503FD80", VA = "0x185040D80")]
	public bool LKIPLGLLFFP(T GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5040EC0", Offset = "0x503FEC0", VA = "0x185040EC0")]
	public bool MBIHOFJOLNE(T GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5040CD0", Offset = "0x503FCD0", VA = "0x185040CD0")]
	public void FGJHDMILFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5040F00", Offset = "0x503FF00", VA = "0x185040F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public INDJJOOEBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class IDNPIOCKKCM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class JJHBMFHEGMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public JJHBMFHEGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x82DE8D0", Offset = "0x82DD8D0", VA = "0x1882DE8D0")]
		internal int LDGJALPKPAI(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private HashSet<object>? CIPAHIKLLKF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> JOPCHBBDKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x82DDE70", Offset = "0x82DCE70", VA = "0x1882DDE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool CDGGPEIJCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x82DDFA0", Offset = "0x82DCFA0", VA = "0x1882DDFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x82DDD20", Offset = "0x82DCD20", VA = "0x1882DDD20")]
	public bool DOPEKGIEJEC(object GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x82DDF00", Offset = "0x82DCF00", VA = "0x1882DDF00")]
	public bool LKIPLGLLFFP(object GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x82DDFB0", Offset = "0x82DCFB0", VA = "0x1882DDFB0")]
	public bool MBIHOFJOLNE(object GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x82DDE00", Offset = "0x82DCE00", VA = "0x1882DDE00")]
	public void FGJHDMILFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x82DE010", Offset = "0x82DD010", VA = "0x1882DE010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IDNPIOCKKCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class ELCBPAGODNE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct KOOMDLGCNEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float FLHJHIDFNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public T BDJLGAHJNPH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<object, KOOMDLGCNEC> PBIFPLDBICK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T DOMMDAJHLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x11FD610", Offset = "0x11FC610", VA = "0x1811FD610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1BCBF90", Offset = "0x1BCAF90", VA = "0x181BCBF90", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? HCOOFLEFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ILLFPDOKKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x490D910", Offset = "0x490C910", VA = "0x18490D910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x490DF80", Offset = "0x490CF80", VA = "0x18490DF80")]
	public bool KNDFACNEOHH(T IOALKPFEKEK, object GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x490D980", Offset = "0x490C980", VA = "0x18490D980")]
	public bool KDIFOBEKNMA(object GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x490D950", Offset = "0x490C950", VA = "0x18490D950")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x490C020", Offset = "0x490B020", VA = "0x18490C020")]
	public bool BOIPBPENDNC(object GFDDDAIMFOH, [Out] T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x490C300", Offset = "0x490B300", VA = "0x18490C300")]
	[MDIDPKNNAGM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CDEFLICCJCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x490E1A0", Offset = "0x490D1A0", VA = "0x18490E1A0")]
	public ELCBPAGODNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class CKAAAFLMEJP : OODHOCHKFFE<GKBPMJBFGGP>
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class HDFNEMMOPCM : IEqualityComparer<GKBPMJBFGGP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal static readonly HDFNEMMOPCM KONBGMLOLPI;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x82DDC80", Offset = "0x82DCC80", VA = "0x1882DDC80", Slot = "4")]
		public bool Equals(GKBPMJBFGGP OEFDFBLCHHF, GKBPMJBFGGP GDBEEAKMPMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x73BB7E0", Offset = "0x73BA7E0", VA = "0x1873BB7E0", Slot = "5")]
		public int GetHashCode(GKBPMJBFGGP PGIOEBKALDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HDFNEMMOPCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x82DCFD0", Offset = "0x82DBFD0", VA = "0x1882DCFD0")]
	public CKAAAFLMEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x82DCDE0", Offset = "0x82DBDE0", VA = "0x1882DCDE0", Slot = "4")]
	public override bool DOPEKGIEJEC(GKBPMJBFGGP GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x82DCF20", Offset = "0x82DBF20", VA = "0x1882DCF20", Slot = "5")]
	public override bool LKIPLGLLFFP(GKBPMJBFGGP GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x82DCE90", Offset = "0x82DBE90", VA = "0x1882DCE90")]
	private static void FFNOHEOCPEL(GKBPMJBFGGP GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xAC9DA0", Offset = "0xAC8DA0", VA = "0x180AC9DA0", Slot = "6")]
	protected override string TokenToString(GKBPMJBFGGP GFDDDAIMFOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class GKBPMJBFGGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly string MBIOIHMFAJB;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public GKBPMJBFGGP(string MBIOIHMFAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x82DDC30", Offset = "0x82DCC30", VA = "0x1882DDC30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class OODHOCHKFFE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IEqualityComparer<T> FFIFKGOLOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private HashSet<T>? CIPAHIKLLKF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> JOPCHBBDKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x595B1B0", Offset = "0x595A1B0", VA = "0x18595B1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CDGGPEIJCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5040E90", Offset = "0x503FE90", VA = "0x185040E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x595BA40", Offset = "0x595AA40", VA = "0x18595BA40")]
	public OODHOCHKFFE(IEqualityComparer<T> FFIFKGOLOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x595AE60", Offset = "0x5959E60", VA = "0x18595AE60", Slot = "4")]
	public virtual bool DOPEKGIEJEC(T GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x595B1E0", Offset = "0x595A1E0", VA = "0x18595B1E0", Slot = "5")]
	public virtual bool LKIPLGLLFFP(T GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x595B130", Offset = "0x595A130", VA = "0x18595B130")]
	public void FGJHDMILFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x595B6C0", Offset = "0x595A6C0", VA = "0x18595B6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class FIBCAEDDJIJ<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<WeakReference<T>>? CIPAHIKLLKF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CDGGPEIJCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4D97B60", Offset = "0x4D96B60", VA = "0x184D97B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4D97D60", Offset = "0x4D96D60", VA = "0x184D97D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4D97800", Offset = "0x4D96800", VA = "0x184D97800")]
	public void DOPEKGIEJEC(T GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4D97A20", Offset = "0x4D96A20", VA = "0x184D97A20")]
	public void LKIPLGLLFFP(T GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4D97C50", Offset = "0x4D96C50", VA = "0x184D97C50")]
	public bool MBIHOFJOLNE(T GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4D97A00", Offset = "0x4D96A00", VA = "0x184D97A00")]
	public void FGJHDMILFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4D97EA0", Offset = "0x4D96EA0", VA = "0x184D97EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FIBCAEDDJIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class MAMFIKKMMBJ
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3A81080", Offset = "0x3A80080", VA = "0x183A81080")]
	public static void JCHFIOPIJFJ<T>(this List<T> KKAPDLIJLLM, int HLGKMAPOEBE) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OIAFBGFPPAL<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private struct DIHKLCJLCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public float FLHJHIDFNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public T BDJLGAHJNPH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<GKBPMJBFGGP, DIHKLCJLCON> PBIFPLDBICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly EqualityComparer<T> GCFDNGHNPEH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T DOMMDAJHLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private GKBPMJBFGGP? HCOOFLEFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool ILLFPDOKKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x490D910", Offset = "0x490C910", VA = "0x18490D910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5931F90", Offset = "0x5930F90", VA = "0x185931F90")]
	public bool KNDFACNEOHH(T IOALKPFEKEK, GKBPMJBFGGP GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x490D980", Offset = "0x490C980", VA = "0x18490D980")]
	public bool KDIFOBEKNMA(GKBPMJBFGGP GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x490D950", Offset = "0x490C950", VA = "0x18490D950")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x490BFB0", Offset = "0x490AFB0", VA = "0x18490BFB0")]
	public bool BOIPBPENDNC(GKBPMJBFGGP GFDDDAIMFOH, [Out] T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5931950", Offset = "0x5930950", VA = "0x185931950")]
	[MDIDPKNNAGM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CDEFLICCJCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5932070", Offset = "0x5931070", VA = "0x185932070")]
	public OIAFBGFPPAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class KCLNBIEAOJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<object, float> PBIFPLDBICK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float EDDPIMBOIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xABF1F0", Offset = "0xABE1F0", VA = "0x180ABF1F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x134F670", Offset = "0x134E670", VA = "0x18134F670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x82DEB70", Offset = "0x82DDB70", VA = "0x1882DEB70")]
	public void KNDFACNEOHH(float IOALKPFEKEK, object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x82DEB00", Offset = "0x82DDB00", VA = "0x1882DEB00")]
	public void KDIFOBEKNMA(object GFDDDAIMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x82DEAB0", Offset = "0x82DDAB0", VA = "0x1882DEAB0")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x82DE980", Offset = "0x82DD980", VA = "0x1882DE980")]
	private void AKGLOOMONAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x82DEBE0", Offset = "0x82DDBE0", VA = "0x1882DEBE0")]
	public KCLNBIEAOJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface FPDGHKIJGGA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ONBBOFJDKPN HJBANLHPGIH;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class BBKPBLJCGNA : FPDGHKIJGGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct OKPKJIALGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly float AGMPLOGOAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly float KJPCIMAPFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal readonly bool KJIKLILMPOK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float GEDPMFLNHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x82DF330", Offset = "0x82DE330", VA = "0x1882DF330")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x82DF4B0", Offset = "0x82DE4B0", VA = "0x1882DF4B0")]
		public OKPKJIALGAL(float LMLEMDDGACN, float KLLLDNANLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x82DF340", Offset = "0x82DE340", VA = "0x1882DF340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class MPCDACCMCCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BBKPBLJCGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MPCDACCMCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x82DF0E0", Offset = "0x82DE0E0", VA = "0x1882DF0E0")]
		internal void GDOFOOHJLCE(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int HDEDDOIEPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int ENMLLNCEDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly FPDGHKIJGGA[] DCJKLHOOFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly ONBBOFJDKPN[] JMDACFLNFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly OKPKJIALGAL[] GHBHAMFGAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private OKPKJIALGAL FBBLCILCGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly PEPIEACHCCN ONFCFNDBHAB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ONBBOFJDKPN HJBANLHPGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82DC460", Offset = "0x82DB460", VA = "0x1882DC460", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x82DC290", Offset = "0x82DB290", VA = "0x1882DC290", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x82DCA30", Offset = "0x82DBA30", VA = "0x1882DCA30")]
	public BBKPBLJCGNA(int HDEDDOIEPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x82DC520", Offset = "0x82DB520", VA = "0x1882DC520")]
	public PEPIEACHCCN HNJBBIAMLOK(OKPKJIALGAL GHPPGCHDHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x82DC5B0", Offset = "0x82DB5B0", VA = "0x1882DC5B0")]
	public void NIICCNFCAEJ(FPDGHKIJGGA DJPBMKGICAH, [Optional] OKPKJIALGAL JCCFDNAPKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x82DC350", Offset = "0x82DB350", VA = "0x1882DC350", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate void ONBBOFJDKPN(float KEFKOKKEEEI);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NOBPHMEANHC
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private class DBDLALEGCEL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly FPDGHKIJGGA CNPJHPACIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly ONBBOFJDKPN HCEFPMMOBCM;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x82DD1C0", Offset = "0x82DC1C0", VA = "0x1882DD1C0")]
		public DBDLALEGCEL(FPDGHKIJGGA CNPJHPACIAL, ONBBOFJDKPN HCEFPMMOBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x82DD170", Offset = "0x82DC170", VA = "0x1882DD170", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x82DF180", Offset = "0x82DE180", VA = "0x1882DF180")]
	internal static bool CLDDHIOKFCB(float JDINPJIAKOC, float LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x82C9180", Offset = "0x82C8180", VA = "0x1882C9180")]
	internal static float CFKBJFEDMKD(float JDINPJIAKOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x82DF1F0", Offset = "0x82DE1F0", VA = "0x1882DF1F0")]
	public static IDisposable ILFFOFAHKFC(this FPDGHKIJGGA CNPJHPACIAL, ONBBOFJDKPN HCEFPMMOBCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PEPIEACHCCN : FPDGHKIJGGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float KEFKOKKEEEI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float DCMODBLEEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x82DF750", Offset = "0x82DE750", VA = "0x1882DF750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ONBBOFJDKPN? HJBANLHPGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x82DF6B0", Offset = "0x82DE6B0", VA = "0x1882DF6B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x82DF610", Offset = "0x82DE610", VA = "0x1882DF610", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PEPIEACHCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface LJIHCCLCIIL<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AJGBDJDFKOB<T> LHJKIDHMHHP([Out] T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPJFAMEFLHG();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PDCGANDEOLF<T> : LJIHCCLCIIL<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ConcurrentStack<T> OPKCDHHPACO;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5A37DA0", Offset = "0x5A36DA0", VA = "0x185A37DA0", Slot = "4")]
	public AJGBDJDFKOB<T> LHJKIDHMHHP([Out] T IOALKPFEKEK)
	{
		return default(AJGBDJDFKOB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5A37D40", Offset = "0x5A36D40", VA = "0x185A37D40")]
	public void ECPMCGAOIHB(T NGAPODPLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x52895F0", Offset = "0x52885F0", VA = "0x1852895F0", Slot = "5")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "6")]
	protected virtual void KMPAIJIJNFB(T CFFCINIJGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5A37E30", Offset = "0x5A36E30", VA = "0x185A37E30")]
	private T LMKONLJOAEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5A37EB0", Offset = "0x5A36EB0", VA = "0x185A37EB0")]
	public PDCGANDEOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct AJGBDJDFKOB<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly T NGAPODPLKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly PDCGANDEOLF<T> LNCIHDIOBFP;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
	internal AJGBDJDFKOB(T IOALKPFEKEK, PDCGANDEOLF<T> LNCIHDIOBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x519FDB0", Offset = "0x519EDB0", VA = "0x18519FDB0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class CDIBKHNBBDF : PDCGANDEOLF<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly CDIBKHNBBDF KONBGMLOLPI;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x82DCC60", Offset = "0x82DBC60", VA = "0x1882DCC60")]
	public static AJGBDJDFKOB<StringBuilder> LMKONLJOAEP([Out] StringBuilder IOALKPFEKEK)
	{
		return default(AJGBDJDFKOB<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x82DCC40", Offset = "0x82DBC40", VA = "0x1882DCC40", Slot = "6")]
	protected override void KMPAIJIJNFB(StringBuilder CFFCINIJGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x82DCDA0", Offset = "0x82DBDA0", VA = "0x1882DCDA0")]
	public CDIBKHNBBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OICMAFALCDK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7B35770", Offset = "0x7B34770", VA = "0x187B35770")]
	public OICMAFALCDK(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class AJGGDOMDFEM<TKey, TValue> : POAICMAGPLA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, HGCNFDDKLFI where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class MFDBBNKNNLJ : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AJGGDOMDFEM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x11FD610", Offset = "0x11FC610", VA = "0x1811FD610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x4E195B0", Offset = "0x4E185B0", VA = "0x184E195B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public MFDBBNKNNLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E19650", Offset = "0x4E18650", VA = "0x184E19650", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x56B2A70", Offset = "0x56B1A70", VA = "0x1856B2A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x56B2890", Offset = "0x56B1890", VA = "0x1856B2890")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x56B2A20", Offset = "0x56B1A20", VA = "0x1856B2A20")]
		private void FNICMDFFEAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x56B3580", Offset = "0x56B2580", VA = "0x1856B3580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly POAICMAGPLA<TKey, TValue> ICMMFAPPFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly IDictionary<TKey, TValue> EKCHJLDIJOF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x51A2980", Offset = "0x51A1980", VA = "0x1851A2980", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool COBLKMLKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x51A2BF0", Offset = "0x51A1BF0", VA = "0x1851A2BF0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x51A2E50", Offset = "0x51A1E50", VA = "0x1851A2E50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> MEHKDENMJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x51A2C50", Offset = "0x51A1C50", VA = "0x1851A2C50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> JDDHHJMKIPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x51A2D50", Offset = "0x51A1D50", VA = "0x1851A2D50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x51A28D0", Offset = "0x51A18D0", VA = "0x1851A28D0")]
	public AJGGDOMDFEM(POAICMAGPLA<TKey, TValue> ICMMFAPPFED, [Optional] IDictionary<TKey, TValue>? EKCHJLDIJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x51A0520", Offset = "0x519F520", VA = "0x1851A0520", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x51A0D50", Offset = "0x519FD50", VA = "0x1851A0D50")]
	public void FIAMLICFIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x51A00A0", Offset = "0x519F0A0", VA = "0x1851A00A0", Slot = "9")]
	public void Add(TKey DAKIIEIEKNI, TValue IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x51A0E70", Offset = "0x519FE70", VA = "0x1851A0E70")]
	public void GCMPCGJJDGE(TKey DAKIIEIEKNI, TValue IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x51A18A0", Offset = "0x51A08A0", VA = "0x1851A18A0")]
	public void PHGJLGGKMMH(TKey DAKIIEIEKNI, TValue IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x51A1260", Offset = "0x51A0260", VA = "0x1851A1260")]
	public void ILMFKDDODMG(TKey DAKIIEIEKNI, TValue IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x519FE40", Offset = "0x519EE40", VA = "0x18519FE40")]
	public void AFMLHBGNJBI(TKey DAKIIEIEKNI, TValue IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x51A1F40", Offset = "0x51A0F40", VA = "0x1851A1F40", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x51A2110", Offset = "0x51A1110", VA = "0x1851A2110", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x51A22D0", Offset = "0x51A12D0", VA = "0x1851A22D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x51A0620", Offset = "0x519F620", VA = "0x1851A0620", Slot = "8")]
	public bool ContainsKey(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x51A0400", Offset = "0x519F400", VA = "0x1851A0400")]
	public bool CCJPLELDAGD(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x51A15C0", Offset = "0x51A05C0", VA = "0x1851A15C0")]
	public bool KNOKIJBGCLA(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x51A1CC0", Offset = "0x51A0CC0", VA = "0x1851A1CC0", Slot = "10")]
	public bool Remove(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x51A2730", Offset = "0x51A1730", VA = "0x1851A2730", Slot = "11")]
	public bool TryGetValue(TKey DAKIIEIEKNI, [Out] TValue IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x51A08F0", Offset = "0x519F8F0", VA = "0x1851A08F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] MFIJBPNIELL, int EFMHKDAINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x51A2630", Offset = "0x51A1630", VA = "0x1851A2630", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x51A1000", Offset = "0x51A0000", VA = "0x1851A1000", Slot = "19")]
	[IteratorStateMachine(typeof(AJGGDOMDFEM<, >.MFDBBNKNNLJ))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x51A16E0", Offset = "0x51A06E0", VA = "0x1851A16E0", Slot = "21")]
	public bool MLGBLPNEKMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x51A1AF0", Offset = "0x51A0AF0", VA = "0x1851A1AF0")]
	private TValue PNJIFIADHFF(TKey DAKIIEIEKNI)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface LCHGMNHJKGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string NELMLKKFKFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface HGCNFDDKLFI
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLGBLPNEKMM();
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface POAICMAGPLA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HGCNFDDKLFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DefaultMember("Item")]
public sealed class JNNLABIDEOO<TKey, TVal> : POAICMAGPLA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HGCNFDDKLFI where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int BLPLPDOBLDG(TKey DAKIIEIEKNI, TVal IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate void JHONMCCPFJH(TKey DAKIIEIEKNI, TVal IOALKPFEKEK, MAINGJBGLPJ LPKJHGCILMN);

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class MMEMONEHBDB
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey OKAFGBBEFIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal BDJLGAHJNPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int GEDPMFLNHNC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset CDOLLPPMPJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x13AC120", Offset = "0x13AB120", VA = "0x1813AC120")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x14BC880", Offset = "0x14BB880", VA = "0x1814BC880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x56EA070", Offset = "0x56E9070", VA = "0x1856EA070")]
		public MMEMONEHBDB(TKey DAKIIEIEKNI, TVal GHNFCHHGJAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MNOHGLIHLPN : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public JNNLABIDEOO<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private LinkedList<MMEMONEHBDB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x11FD610", Offset = "0x11FC610", VA = "0x1811FD610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x56F8E80", Offset = "0x56F7E80", VA = "0x1856F8E80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public MNOHGLIHLPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E13DA0", Offset = "0x4E12DA0", VA = "0x184E13DA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x56F7330", Offset = "0x56F6330", VA = "0x1856F7330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x56F6510", Offset = "0x56F5510", VA = "0x1856F6510")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x56F8B60", Offset = "0x56F7B60", VA = "0x1856F8B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int PNGKEICECHD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<MMEMONEHBDB>> GFHOKIEEMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<MMEMONEHBDB> JGMOCJLFPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly BLPLPDOBLDG? HJDOBHPMGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan OOBHCFOFMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly JHONMCCPFJH? KMIOHKFDJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly NPOGFCNMGND MOAEIOPIGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool BDLIODMNDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<TKey> KNODHABLJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<TVal> GDPHFIFHOPH;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int OJEKMOODCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xD16000", Offset = "0xD15000", VA = "0x180D16000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int LPDPOJHPOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xE60240", Offset = "0xE5F240", VA = "0x180E60240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xF86380", Offset = "0xF85380", VA = "0x180F86380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x52CEE60", Offset = "0x52CDE60", VA = "0x1852CEE60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int LHHJBDKKIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5019EA0", Offset = "0x5018EA0", VA = "0x185019EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> JDDHHJMKIPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x52CEF40", Offset = "0x52CDF40", VA = "0x1852CEF40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.CHGOAPHFANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x52CCC60", Offset = "0x52CBC60", VA = "0x1852CCC60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool COBLKMLKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x52CEEB0", Offset = "0x52CDEB0", VA = "0x1852CEEB0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x52CEF70", Offset = "0x52CDF70", VA = "0x1852CEF70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x52C5F00", Offset = "0x52C4F00", VA = "0x1852C5F00")]
	private bool GFCFDHFMGDH(int HDEDDOIEPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x52C7F10", Offset = "0x52C6F10", VA = "0x1852C7F10")]
	private void KKFMJCIBCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x52CD630", Offset = "0x52CC630", VA = "0x1852CD630")]
	public JNNLABIDEOO(int HDEDDOIEPID, [Optional] BLPLPDOBLDG? HJDOBHPMGOJ, [Optional] IEqualityComparer<TKey>? JEMEJNFHHJE, [Optional] JHONMCCPFJH? KMIOHKFDJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x52CD1F0", Offset = "0x52CC1F0", VA = "0x1852CD1F0")]
	public JNNLABIDEOO(TimeSpan OOBHCFOFMEL, [Optional] IEqualityComparer<TKey>? JEMEJNFHHJE, [Optional] JHONMCCPFJH? KMIOHKFDJPD, [Optional] NPOGFCNMGND? MOAEIOPIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x52CD1A0", Offset = "0x52CC1A0", VA = "0x1852CD1A0")]
	public JNNLABIDEOO(int HDEDDOIEPID, TimeSpan OOBHCFOFMEL, [Optional] IEqualityComparer<TKey>? JEMEJNFHHJE, [Optional] JHONMCCPFJH? KMIOHKFDJPD, [Optional] NPOGFCNMGND? MOAEIOPIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x52CE440", Offset = "0x52CD440", VA = "0x1852CE440")]
	public JNNLABIDEOO(int HDEDDOIEPID, BLPLPDOBLDG? HJDOBHPMGOJ, TimeSpan OOBHCFOFMEL, [Optional] IEqualityComparer<TKey>? JEMEJNFHHJE, [Optional] JHONMCCPFJH? KMIOHKFDJPD, [Optional] NPOGFCNMGND? MOAEIOPIGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x52CA140", Offset = "0x52C9140", VA = "0x1852CA140", Slot = "21")]
	public bool MLGBLPNEKMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x52C57B0", Offset = "0x52C47B0", VA = "0x1852C57B0", Slot = "22")]
	public bool EMDAJHGJAIE(int BKLOHAHJLKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x52C7A10", Offset = "0x52C6A10", VA = "0x1852C7A10")]
	private bool KHOJGFLHBMC(int BKLOHAHJLKP, MAINGJBGLPJ LPKJHGCILMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x52CBCF0", Offset = "0x52CACF0", VA = "0x1852CBCF0")]
	public void ODADMGGOEJG(TKey DAKIIEIEKNI, TVal IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x52C2EC0", Offset = "0x52C1EC0", VA = "0x1852C2EC0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ADPMEPGEIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x52C3070", Offset = "0x52C2070", VA = "0x1852C3070", Slot = "9")]
	public void Add(TKey DAKIIEIEKNI, TVal IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x52C3680", Offset = "0x52C2680", VA = "0x1852C3680", Slot = "8")]
	public bool ContainsKey(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x52CC940", Offset = "0x52CB940", VA = "0x1852CC940", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x52CC6E0", Offset = "0x52CB6E0", VA = "0x1852CC6E0", Slot = "10")]
	public bool Remove(TKey DAKIIEIEKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x52CCB30", Offset = "0x52CBB30", VA = "0x1852CCB30", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> ADPMEPGEIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x52C5D00", Offset = "0x52C4D00", VA = "0x1852C5D00")]
	private bool FAIOGBIGEIC(TKey DAKIIEIEKNI, [Out] TVal IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x52C97B0", Offset = "0x52C87B0", VA = "0x1852C97B0")]
	private TVal LMKONLJOAEP(TKey OOENCEFPPHA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x52CD010", Offset = "0x52CC010", VA = "0x1852CD010", Slot = "11")]
	public bool TryGetValue(TKey OOENCEFPPHA, [Out] TVal IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x52C3580", Offset = "0x52C2580", VA = "0x1852C3580", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x52C3A60", Offset = "0x52C2A60", VA = "0x1852C3A60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] MFIJBPNIELL, int EFMHKDAINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x52CC400", Offset = "0x52CB400", VA = "0x1852CC400")]
	private void OKEHDHCBNBN(TKey DAKIIEIEKNI, TVal GHNFCHHGJAG, MAINGJBGLPJ LPKJHGCILMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x52C9E60", Offset = "0x52C8E60", VA = "0x1852C9E60")]
	private bool MHGOBFMDBFK(MMEMONEHBDB MLDGFONCOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x52CA600", Offset = "0x52C9600", VA = "0x1852CA600")]
	private void NBAOKNOFGII(LinkedListNode<MMEMONEHBDB> LBJEEGBAFKD, TVal MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x52C8860", Offset = "0x52C7860", VA = "0x1852C8860")]
	private void KNDFACNEOHH(TKey DAKIIEIEKNI, TVal IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A90", Offset = "0x52C3A90", VA = "0x1852C4A90")]
	private void DJEDMFKPJNB(MMEMONEHBDB MLDGFONCOAM, TVal MNBECLGJOEJ, int IOFDJCFHBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x52C5F50", Offset = "0x52C4F50", VA = "0x1852C5F50", Slot = "19")]
	[IteratorStateMachine(typeof(JNNLABIDEOO<, >.MNOHGLIHLPN))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x52CCC90", Offset = "0x52CBC90", VA = "0x1852CCC90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public enum MAINGJBGLPJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class CHJKNBPGBBI<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly TKey KDOGFPMKNMF;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68BA030", Offset = "0x68B9030", VA = "0x1868BA030")]
	public CHJKNBPGBBI(TKey JJGPINDBMPP, Exception BMHAEMEHBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CLPGLLMJKIJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x734FB60", Offset = "0x734EB60", VA = "0x18734FB60")]
	public CLPGLLMJKIJ(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DGHFOCDINCJ<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class MPFAAKMKGBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public DGHFOCDINCJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MPFAAKMKGBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x570D750", Offset = "0x570C750", VA = "0x18570D750")]
		internal Task<TResource> EDMAHFBCDOK(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct GBDGNODDHOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public DGHFOCDINCJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BFF0", Offset = "0x4E4AFF0", VA = "0x184E4BFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x4E4C2B0", Offset = "0x4E4B2B0", VA = "0x184E4C2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct ICMNGBOODKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x500C3C0", Offset = "0x500B3C0", VA = "0x18500C3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x500CB00", Offset = "0x500BB00", VA = "0x18500CB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly NKHDBLBJEMC<TId, Task<TResource>> KHGEJDBCGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> GJNCKKCGFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CBGJKEAADHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Action<TResource>? HACNDPABAEO;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E91A20", Offset = "0x6E90A20", VA = "0x186E91A20")]
	public DGHFOCDINCJ(int NHNOMPICMAD = 0, [Optional] IEqualityComparer<TId>? LCNFCBAOBOG, [Optional] Func<TId, CancellationToken, Task<TResource>>? CCAPJBLIJPI, [Optional] Action<TResource>? EBBCEGOFCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E91120", Offset = "0x6E90120", VA = "0x186E91120")]
	public DMEMIKDFAED<Task<TResource>> LOMPPLNIHPJ(TId PBJHGGBBAAF, [Optional] Func<TId, CancellationToken, Task<TResource>>? CCAPJBLIJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E904A0", Offset = "0x6E8F4A0", VA = "0x186E904A0")]
	private void AFGNFJCCJFA(Task<TResource> CAIMNCAIJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E91760", Offset = "0x6E90760", VA = "0x186E91760")]
	[AsyncStateMachine(typeof(DGHFOCDINCJ<, >.GBDGNODDHOL))]
	private Task ONJOEAMJAKH(Task<TResource> CAIMNCAIJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E90DB0", Offset = "0x6E8FDB0", VA = "0x186E90DB0")]
	public void JKBCIEIEELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E90810", Offset = "0x6E8F810", VA = "0x186E90810")]
	public NKHDBLBJEMC<TId, Task<TResource>>.PEMLBEEFBJE GHDHEBFDHCI()
	{
		return default(NKHDBLBJEMC<TId, Task<TResource>>.PEMLBEEFBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E918F0", Offset = "0x6E908F0", VA = "0x186E918F0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6E918F0", Offset = "0x6E908F0", VA = "0x186E918F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6E90A20", Offset = "0x6E8FA20", VA = "0x186E90A20")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DGHFOCDINCJ<, >.ICMNGBOODKC))]
	internal static Task IMLAFHCBNGJ(Task<TResource> CAIMNCAIJDI, CancellationTokenSource OKJNNIEFEBK, Dictionary<Task<TResource>, CancellationTokenSource> OABAIPKFKCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class NKHDBLBJEMC<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class MCCGGHMNODI : IEquatable<MCCGGHMNODI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly TValue BDJLGAHJNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int PKKLMNACMOJ;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x12FAD30", Offset = "0x12F9D30", VA = "0x1812FAD30")]
		public MCCGGHMNODI(TValue IOALKPFEKEK, int CCHLINPJMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5698BF0", Offset = "0x5697BF0", VA = "0x185698BF0", Slot = "4")]
		public bool Equals(MCCGGHMNODI? EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5698C70", Offset = "0x5697C70", VA = "0x185698C70", Slot = "0")]
		public override bool Equals(object? PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5698D80", Offset = "0x5697D80", VA = "0x185698D80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public struct PEMLBEEFBJE : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<TKey, MCCGGHMNODI>.Enumerator CGBNGKJFFEA;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x5A38CC0", Offset = "0x5A37CC0", VA = "0x185A38CC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x5A390B0", Offset = "0x5A380B0", VA = "0x185A390B0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5A38E10", Offset = "0x5A37E10", VA = "0x185A38E10")]
		public PEMLBEEFBJE(NKHDBLBJEMC<TKey, TValue> PBIFPLDBICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5A38A10", Offset = "0x5A37A10", VA = "0x185A38A10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5A38A50", Offset = "0x5A37A50", VA = "0x185A38A50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5A38C20", Offset = "0x5A37C20", VA = "0x185A38C20", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class KNBCICHPALG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public NKHDBLBJEMC<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public MCCGGHMNODI refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KNBCICHPALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x53D54C0", Offset = "0x53D44C0", VA = "0x1853D54C0")]
		internal void EDMAHFBCDOK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Dictionary<TKey, MCCGGHMNODI> BEHEGDDHJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Func<TKey, TValue>? CJOHHHAJBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Action<TValue>? JJAOKONGJFJ;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5796580", Offset = "0x5795580", VA = "0x185796580")]
	public NKHDBLBJEMC(int NHNOMPICMAD = 0, [Optional] IEqualityComparer<TKey>? JEMEJNFHHJE, [Optional] Func<TKey, TValue>? EEHMKEOJKMH, [Optional] Action<TValue>? LGPPBAPOLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5796110", Offset = "0x5795110", VA = "0x185796110")]
	public DMEMIKDFAED<TValue> LOMPPLNIHPJ(TKey DAKIIEIEKNI, [Optional] Func<TKey, TValue>? ODLKFCDNIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x57951A0", Offset = "0x57941A0", VA = "0x1857951A0")]
	private void ECPMCGAOIHB(TKey DAKIIEIEKNI, MCCGGHMNODI DOLBNNIOPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5795530", Offset = "0x5794530", VA = "0x185795530")]
	public void JKBCIEIEELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5795290", Offset = "0x5794290", VA = "0x185795290")]
	public PEMLBEEFBJE GHDHEBFDHCI()
	{
		return default(PEMLBEEFBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x57963C0", Offset = "0x57953C0", VA = "0x1857963C0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x57963C0", Offset = "0x57953C0", VA = "0x1857963C0", Slot = "5")]
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
