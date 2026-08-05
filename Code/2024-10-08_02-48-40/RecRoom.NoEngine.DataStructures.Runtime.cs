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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D45C90", Offset = "0x6D44E90", VA = "0x186D45C90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PKEFDFBNIMC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	protected PKEFDFBNIMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HNCAOOOFPAG<T> : PKEFDFBNIMC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LDKKPFBMDBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum FHJIJIACOPB
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
		public FHJIJIACOPB EIHDAHDDDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ECFGAICLGCA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FDJLGPIKLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool ADJGBKFGOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool GDILDAHOILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? IHLGNCKANFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LDKKPFBMDBK>? GPFIKCJMJCO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DNHJPNJJJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x404A740", Offset = "0x4049940", VA = "0x18404A740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x404B160", Offset = "0x404A360", VA = "0x18404B160")]
	protected HNCAOOOFPAG(bool GDILDAHOILF, bool ADJGBKFGOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x404A7A0", Offset = "0x40499A0", VA = "0x18404A7A0")]
	protected bool ANINICLLFAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x404A9F0", Offset = "0x4049BF0", VA = "0x18404A9F0")]
	protected void BOBKADCCKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x404AD20", Offset = "0x4049F20", VA = "0x18404AD20")]
	protected void KBDFNICBANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x30233C0", Offset = "0x30225C0", VA = "0x1830233C0")]
	private static void MNDCCJIFCFN<U>(List<U>? NAGHBLHDGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x404AB10", Offset = "0x4049D10", VA = "0x18404AB10", Slot = "4")]
	public void JIJNOIKPNBF(T ECFGAICLGCA, bool IEAPEBAJLCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x404AF90", Offset = "0x404A190", VA = "0x18404AF90", Slot = "5")]
	public void LOGGCHCCBFB(T ECFGAICLGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x404A840", Offset = "0x4049A40", VA = "0x18404A840")]
	public void AODHOHPPLKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OAACCCGABIO : HNCAOOOFPAG<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D45FD0", Offset = "0x6D451D0", VA = "0x186D45FD0")]
	public OAACCCGABIO(bool GDILDAHOILF = false, bool ADJGBKFGOAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D45D10", Offset = "0x6D44F10", VA = "0x186D45D10")]
	public void BAPLBLGGGFM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D45F70", Offset = "0x6D45170", VA = "0x186D45F70")]
	public static OAACCCGABIO HMOCCFHDLLN(OAACCCGABIO PCKADPDPFML, Action ECFGAICLGCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D45F10", Offset = "0x6D45110", VA = "0x186D45F10")]
	public static OAACCCGABIO CHJCPHIJMGD(OAACCCGABIO PCKADPDPFML, Action ECFGAICLGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DCLHMIFOFNO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIJNOIKPNBF(Action<T> ECFGAICLGCA, bool IEAPEBAJLCK = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOGGCHCCBFB(Action<T> ECFGAICLGCA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class MNNONBMLAOA<T> : HNCAOOOFPAG<Action<T>>, DCLHMIFOFNO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1CA0", Offset = "0x3EA0EA0", VA = "0x183EA1CA0")]
	public MNNONBMLAOA(bool GDILDAHOILF = false, bool ADJGBKFGOAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47C83B0", Offset = "0x47C75B0", VA = "0x1847C83B0")]
	public void BAPLBLGGGFM(T EBCBPNKDEPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1C00", Offset = "0x3EA0E00", VA = "0x183EA1C00")]
	public static MNNONBMLAOA<T> HMOCCFHDLLN(MNNONBMLAOA<T> PCKADPDPFML, Action<T> ECFGAICLGCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1B60", Offset = "0x3EA0D60", VA = "0x183EA1B60")]
	public static MNNONBMLAOA<T> CHJCPHIJMGD(MNNONBMLAOA<T> PCKADPDPFML, Action<T> ECFGAICLGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AIFGIHBIMMM<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FJEDCFIBPFL<T, U> : HNCAOOOFPAG<Action<T, U>>, AIFGIHBIMMM<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1CA0", Offset = "0x3EA0EA0", VA = "0x183EA1CA0")]
	public FJEDCFIBPFL(bool GDILDAHOILF = false, bool ADJGBKFGOAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1530", Offset = "0x3EA0730", VA = "0x183EA1530")]
	public void BAPLBLGGGFM(T EBCBPNKDEPP, U PMDFOFEPBHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1C00", Offset = "0x3EA0E00", VA = "0x183EA1C00")]
	public static FJEDCFIBPFL<T, U> HMOCCFHDLLN(FJEDCFIBPFL<T, U> PCKADPDPFML, Action<T, U> ECFGAICLGCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1B60", Offset = "0x3EA0D60", VA = "0x183EA1B60")]
	public static FJEDCFIBPFL<T, U> CHJCPHIJMGD(FJEDCFIBPFL<T, U> PCKADPDPFML, Action<T, U> ECFGAICLGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KJOMNGBJNPC<T, U, V> : HNCAOOOFPAG<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1CA0", Offset = "0x3EA0EA0", VA = "0x183EA1CA0")]
	public KJOMNGBJNPC(bool GDILDAHOILF = false, bool ADJGBKFGOAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x44B76D0", Offset = "0x44B68D0", VA = "0x1844B76D0")]
	public void BAPLBLGGGFM(T EBCBPNKDEPP, U PMDFOFEPBHL, V IGDCKHODAOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1C00", Offset = "0x3EA0E00", VA = "0x183EA1C00")]
	public static KJOMNGBJNPC<T, U, V> HMOCCFHDLLN(KJOMNGBJNPC<T, U, V> PCKADPDPFML, Action<T, U, V> ECFGAICLGCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1B60", Offset = "0x3EA0D60", VA = "0x183EA1B60")]
	public static KJOMNGBJNPC<T, U, V> CHJCPHIJMGD(KJOMNGBJNPC<T, U, V> PCKADPDPFML, Action<T, U, V> ECFGAICLGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FIGJEPCEJHD<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class IJPGGEDICAO<T, U, V, W> : HNCAOOOFPAG<Action<T, U, V, W>>, FIGJEPCEJHD<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1CA0", Offset = "0x3EA0EA0", VA = "0x183EA1CA0")]
	public IJPGGEDICAO(bool GDILDAHOILF = false, bool ADJGBKFGOAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x417C0A0", Offset = "0x417B2A0", VA = "0x18417C0A0")]
	public void BAPLBLGGGFM(T EBCBPNKDEPP, U PMDFOFEPBHL, V IGDCKHODAOC, W ANMJILICOFJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1C00", Offset = "0x3EA0E00", VA = "0x183EA1C00")]
	public static IJPGGEDICAO<T, U, V, W> HMOCCFHDLLN(IJPGGEDICAO<T, U, V, W> PCKADPDPFML, Action<T, U, V, W> ECFGAICLGCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1B60", Offset = "0x3EA0D60", VA = "0x183EA1B60")]
	public static IJPGGEDICAO<T, U, V, W> CHJCPHIJMGD(IJPGGEDICAO<T, U, V, W> PCKADPDPFML, Action<T, U, V, W> ECFGAICLGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class DECCFGEAPEA<T, U, V, W, X> : HNCAOOOFPAG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1CA0", Offset = "0x3EA0EA0", VA = "0x183EA1CA0")]
	public DECCFGEAPEA(bool GDILDAHOILF = false, bool ADJGBKFGOAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B27D90", Offset = "0x5B26F90", VA = "0x185B27D90")]
	public void BAPLBLGGGFM(T EBCBPNKDEPP, U PMDFOFEPBHL, V IGDCKHODAOC, W ANMJILICOFJ, X AKHPALIKFFK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1C00", Offset = "0x3EA0E00", VA = "0x183EA1C00")]
	public static DECCFGEAPEA<T, U, V, W, X> HMOCCFHDLLN(DECCFGEAPEA<T, U, V, W, X> PCKADPDPFML, Action<T, U, V, W, X> ECFGAICLGCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1B60", Offset = "0x3EA0D60", VA = "0x183EA1B60")]
	public static DECCFGEAPEA<T, U, V, W, X> CHJCPHIJMGD(DECCFGEAPEA<T, U, V, W, X> PCKADPDPFML, Action<T, U, V, W, X> ECFGAICLGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KCMDANIDLCJ<T, U, V, W, X, Y> : HNCAOOOFPAG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1CA0", Offset = "0x3EA0EA0", VA = "0x183EA1CA0")]
	public KCMDANIDLCJ(bool GDILDAHOILF = false, bool ADJGBKFGOAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x448A930", Offset = "0x4489B30", VA = "0x18448A930")]
	public void BAPLBLGGGFM(T EBCBPNKDEPP, U PMDFOFEPBHL, V IGDCKHODAOC, W ANMJILICOFJ, X AKHPALIKFFK, Y PGLPHKNNCEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1C00", Offset = "0x3EA0E00", VA = "0x183EA1C00")]
	public static KCMDANIDLCJ<T, U, V, W, X, Y> HMOCCFHDLLN(KCMDANIDLCJ<T, U, V, W, X, Y> PCKADPDPFML, Action<T, U, V, W, X, Y> ECFGAICLGCA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1B60", Offset = "0x3EA0D60", VA = "0x183EA1B60")]
	public static KCMDANIDLCJ<T, U, V, W, X, Y> CHJCPHIJMGD(KCMDANIDLCJ<T, U, V, W, X, Y> PCKADPDPFML, Action<T, U, V, W, X, Y> ECFGAICLGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MKGEEMPILAK<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MAAEIKNCNEJ<TKey, TVal> PGNAOKKGIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> MJELEKCBKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MAAEIKNCNEJ<TKey, TVal>.PFEAKNCDNLA? GBOOGJMHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int IDIEEHJLPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MAAEIKNCNEJ<TKey, TVal>.PAFHHBINOPA? HJDHEHKBOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int JCAKGALLEAJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int IEOKHDHOEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x47B1D90", Offset = "0x47B0F90", VA = "0x1847B1D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PKFMAHJGDIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x47B2190", Offset = "0x47B1390", VA = "0x1847B2190")]
	public MKGEEMPILAK(int IDIEEHJLPGL, [Optional] MAAEIKNCNEJ<TKey, TVal>.PAFHHBINOPA? HJDHEHKBOGB, [Optional] IEqualityComparer<TKey>? NGGEBGGCMGI, [Optional] MAAEIKNCNEJ<TKey, TVal>.PFEAKNCDNLA? GBOOGJMHKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47B1340", Offset = "0x47B0540", VA = "0x1847B1340")]
	public void JMPPPIADLOP(TKey CPBLLDDDHEE, TVal JECHHBGMFLN, bool HACJAIEIMIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47B2030", Offset = "0x47B1230", VA = "0x1847B2030")]
	public bool PNGIIBIFLBP(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x47B1240", Offset = "0x47B0440", VA = "0x1847B1240")]
	public bool GOLMABOLCED(TKey MLKPBJMLLBK, [Out] TVal JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x47B1AD0", Offset = "0x47B0CD0", VA = "0x1847B1AD0")]
	private void JPKOAHCIPMH(TKey CPBLLDDDHEE, TVal JECHHBGMFLN, int JAICOMOJIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x47B1090", Offset = "0x47B0290", VA = "0x1847B1090")]
	public bool BFBOJONNEDC(TKey CPBLLDDDHEE, TVal JECHHBGMFLN, bool HACJAIEIMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x47B0FE0", Offset = "0x47B01E0", VA = "0x1847B0FE0")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x47B1570", Offset = "0x47B0770", VA = "0x1847B1570")]
	private void JOFDELOPEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x47B0EA0", Offset = "0x47B00A0", VA = "0x1847B0EA0")]
	private bool AMJLNDPBJDO(TKey CPBLLDDDHEE, ENCEGIKDION HJGNFPCEHLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x47B1DE0", Offset = "0x47B0FE0", VA = "0x1847B1DE0")]
	private void MLHJGHHLNAI(TKey CPBLLDDDHEE, TVal JECHHBGMFLN, ENCEGIKDION HJGNFPCEHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x47B1F00", Offset = "0x47B1100", VA = "0x1847B1F00")]
	private void OPJBCMCMEPN(TKey CPBLLDDDHEE, TVal MIOIFIAKEJG, ENCEGIKDION HJGNFPCEHLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NFPIHANDMMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action CEBKNKBEKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LAIPMKBCIGG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public NFPIHANDMMP(Action NBNNJMECLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D45C50", Offset = "0x6D44E50", VA = "0x186D45C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C25C10", Offset = "0x2C24E10", VA = "0x182C25C10")]
	public static GENINCKMOLO<T> LGJIMIKIEOH<T>(T JECHHBGMFLN, Action NBNNJMECLBA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GENINCKMOLO<T> : NFPIHANDMMP where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T GOGBANOMEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3F60900", Offset = "0x3F5FB00", VA = "0x183F60900")]
	public GENINCKMOLO(T JECHHBGMFLN, Action NBNNJMECLBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class JFKBIJGPOEC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JDJDFAOEPHO<T>? DNNDJFEDHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> GBMEIKDFNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool LAIPMKBCIGG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JFKBIJGPOEC<T> NPJAAMJGCPB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> EGKKBPIBIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4357AF0", Offset = "0x4356CF0", VA = "0x184357AF0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DIBMJIIAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4357F90", Offset = "0x4357190", VA = "0x184357F90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool IDJFCBEKMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4357D50", Offset = "0x4356F50", VA = "0x184357D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x43585E0", Offset = "0x43577E0", VA = "0x1843585E0")]
	public JFKBIJGPOEC(JDJDFAOEPHO<T> DGHHAHBDLPE, JDJDFAOEPHO<T> BKIOBCPBJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4358190", Offset = "0x4357390", VA = "0x184358190")]
	public JFKBIJGPOEC(JDJDFAOEPHO<T> DGHHAHBDLPE, int GFHPFKLIAOK, JDJDFAOEPHO<T> BKIOBCPBJCH, int IADHLICNKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4358540", Offset = "0x4357740", VA = "0x184358540")]
	private JFKBIJGPOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4357A60", Offset = "0x4356C60", VA = "0x184357A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4357CA0", Offset = "0x4356EA0", VA = "0x184357CA0")]
	public T[] KEDDAKPCPDO()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4357940", Offset = "0x4356B40", VA = "0x184357940")]
	public static ReadOnlySequence<T> CFMDMKLGJEH(JFKBIJGPOEC<T>? MNKOLJPGIAD)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HMNHFOHBAHD : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct EBJLNNBPDND : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
		public static EBJLNNBPDND MIFIOLMMIDE()
		{
			return default(EBJLNNBPDND);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2E387C0", Offset = "0x2E379C0", VA = "0x182E387C0")]
	public static string? FCDFAPJEHLP<T>([Optional] string? GHNPAEPIBGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2E38840", Offset = "0x2E37A40", VA = "0x182E38840")]
	public static string? MGHHNGPOLPP<T>([Optional] string? OECPLFEJABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
	public static HMNHFOHBAHD CGKFCMKKFDK(string GHNPAEPIBGC, string? OECPLFEJABO)
	{
		return default(HMNHFOHBAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KMMOFIPPECC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool GMHFDAECHKB(string DOJPJBELCEA, KMMOFIPPECC ICHFBFNFELM);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NLODLAKCMKM<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NLODLAKCMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x48623F0", Offset = "0x48615F0", VA = "0x1848623F0")]
		internal void FPHBNELAHDA(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int ODDCGAGBKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string KCADJDLIGLP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D44900", Offset = "0x6D43B00", VA = "0x186D44900")]
	public static Dictionary<string, KMMOFIPPECC> DDFAABNPKPP(Type DOHFHJMDLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2EE43E0", Offset = "0x2EE35E0", VA = "0x182EE43E0")]
	public static Dictionary<string, KMMOFIPPECC> DDFAABNPKPP<T>(Type DOHFHJMDLGP, IReadOnlyDictionary<T, string> GBMGPBBLDMI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2EE4C10", Offset = "0x2EE3E10", VA = "0x182EE4C10")]
	public static Dictionary<string, KMMOFIPPECC> GPDEFOCLDDD<T>(List<T> LPEFNOLHMHI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D44DF0", Offset = "0x6D43FF0", VA = "0x186D44DF0")]
	public static Dictionary<string, KMMOFIPPECC> NMMNNEICOJH(Type DOHFHJMDLGP, GMHFDAECHKB DJOOGJGPBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D44C30", Offset = "0x6D43E30", VA = "0x186D44C30")]
	public static Dictionary<int, string> HIKFKOLIONP(Dictionary<string, KMMOFIPPECC> KLCFDAPKGEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KKIKBNLICGH : NDNNGNKGHFF
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool ENLNMHGGNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? GOGCONOLDBF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual NDNNGNKGHFF? BNBOKFBOLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D44890", Offset = "0x6D43A90", VA = "0x186D44890")]
	protected KKIKBNLICGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string PBDEAEJPOGL();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D44440", Offset = "0x6D43640", VA = "0x186D44440", Slot = "8")]
	public virtual string GCPAMECDBCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D444C0", Offset = "0x6D436C0", VA = "0x186D444C0", Slot = "9")]
	public void HDCLPLAOGII(StringBuilder GIDJBHALCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D443E0", Offset = "0x6D435E0", VA = "0x186D443E0", Slot = "10")]
	public void FPAPKOIJFII(StringBuilder GIDJBHALCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D44770", Offset = "0x6D43970", VA = "0x186D44770", Slot = "11")]
	public void POOFKEEOKGA(StringBuilder GIDJBHALCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D441E0", Offset = "0x6D433E0", VA = "0x186D441E0", Slot = "12")]
	public void CEJGABLIAIK(StringBuilder GIDJBHALCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D44340", Offset = "0x6D43540", VA = "0x186D44340")]
	public static void DGFIIDKFGDJ(StringBuilder GIDJBHALCOM, string EAEKCOMNKCF, string JFDEGBINIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE60", Offset = "0x5EEB060", VA = "0x185EEBE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KICFIMOKMGD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D44180", Offset = "0x6D43380", VA = "0x186D44180")]
	public KICFIMOKMGD(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BGAOKLKPKGI<TErr> : KICFIMOKMGD where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr BGGCGGOOMOG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x51CE770", Offset = "0x51CD970", VA = "0x1851CE770")]
	private BGAOKLKPKGI([In] TErr KBDJGPGHDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x51CE6A0", Offset = "0x51CD8A0", VA = "0x1851CE6A0")]
	public static BGAOKLKPKGI<TErr> MIFIOLMMIDE([In] TErr KBDJGPGHDEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JKEINBPFBEC : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm FLOOLKBJHOP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool PBDKADJHBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool ICDPPIALCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool ONALIACHNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long DIBMJIIAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D43C70", Offset = "0x6D42E70", VA = "0x186D43C70", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long LFHLHOFOIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D43CE0", Offset = "0x6D42EE0", VA = "0x186D43CE0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6D43D50", Offset = "0x6D42F50", VA = "0x186D43D50", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D43C00", Offset = "0x6D42E00", VA = "0x186D43C00")]
	public JKEINBPFBEC(HashAlgorithm FLOOLKBJHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D43A30", Offset = "0x6D42C30", VA = "0x186D43A30", Slot = "35")]
	public override int Read(byte[] GJBDDGHNJBG, int ECDKJELMFBH, int NDEFEFEFLCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D43BD0", Offset = "0x6D42DD0", VA = "0x186D43BD0", Slot = "38")]
	public override void Write(byte[] GJBDDGHNJBG, int ECDKJELMFBH, int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D43AD0", Offset = "0x6D42CD0", VA = "0x186D43AD0", Slot = "33")]
	public override long Seek(long ECDKJELMFBH, SeekOrigin BJICPEILKCC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D43B60", Offset = "0x6D42D60", VA = "0x186D43B60", Slot = "34")]
	public override void SetLength(long JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D43960", Offset = "0x6D42B60", VA = "0x186D43960")]
	public byte[] KJCPPKHAIKE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NDNNGNKGHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GCPAMECDBCC();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PBDEAEJPOGL();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MIFLDGENOJO<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions GOGBANOMEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JKAHDLMKNDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string OMAIDOCJEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JDJDFAOEPHO<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static JDJDFAOEPHO<T>? BAAGFPMMNEP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object JPCIONIPAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? CMHBEJLFNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool LAIPMKBCIGG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NBBOOJLBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9197E0", Offset = "0x9189E0", VA = "0x1809197E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x434F110", Offset = "0x434E310", VA = "0x18434F110")]
	private static JDJDFAOEPHO<T> OFIKCHICKAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x434DB10", Offset = "0x434CD10", VA = "0x18434DB10")]
	private static void CGFKIBAJFCK(JDJDFAOEPHO<T> MEDPIBNDFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3AF63F0", Offset = "0x3AF55F0", VA = "0x183AF63F0")]
	private JDJDFAOEPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x434EBE0", Offset = "0x434DDE0", VA = "0x18434EBE0")]
	public static JDJDFAOEPHO<T> LGJIMIKIEOH(ReadOnlyMemory<T> AEPBMMMBMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x434EDB0", Offset = "0x434DFB0", VA = "0x18434EDB0")]
	public static JDJDFAOEPHO<T> LGJIMIKIEOH(IMemoryOwner<T> AHLMGBPMABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x434E0C0", Offset = "0x434D2C0", VA = "0x18434E0C0")]
	public static void DPLBONICABL(JDJDFAOEPHO<T> DGHHAHBDLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x434E200", Offset = "0x434D400", VA = "0x18434E200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x434E900", Offset = "0x434DB00", VA = "0x18434E900")]
	public JDJDFAOEPHO<T> KKPEAPDMHAN(IMemoryOwner<T> AHLMGBPMABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x434E800", Offset = "0x434DA00", VA = "0x18434E800")]
	private void EJLINPAFHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x434EFC0", Offset = "0x434E1C0", VA = "0x18434EFC0")]
	private JDJDFAOEPHO<T> NBMHAILNPMJ(JDJDFAOEPHO<T> MEDPIBNDFAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LBELCIPJODC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D451B0", Offset = "0x6D443B0", VA = "0x186D451B0")]
	public LBELCIPJODC(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EJGMJJAIAHM<TOk> : LBELCIPJODC where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk AMGAMGDDLJD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6D30", Offset = "0x3AD5F30", VA = "0x183AD6D30")]
	private EJGMJJAIAHM([In] TOk GDGOPIMOLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6C60", Offset = "0x3AD5E60", VA = "0x183AD6C60")]
	public static EJGMJJAIAHM<TOk> MIFIOLMMIDE([In] TOk GDGOPIMOLAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct KJEOKHCIBGM<TOk, TErr> : IEquatable<KJEOKHCIBGM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> ODDKFGKCGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr BGGCGGOOMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk AMGAMGDDLJD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool CIHHOLJHBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x44A5D90", Offset = "0x44A4F90", VA = "0x1844A5D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LEFADDJKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x44A8E40", Offset = "0x44A8040", VA = "0x1844A8E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x44AA7C0", Offset = "0x44A99C0", VA = "0x1844AA7C0")]
	internal KJEOKHCIBGM([In] TErr KBDJGPGHDEH, [In] TOk GDGOPIMOLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x44A5B40", Offset = "0x44A4D40", VA = "0x1844A5B40")]
	public static KJEOKHCIBGM<TOk, TErr> BGHKEEHDOKE([In] TErr KBDJGPGHDEH)
	{
		return default(KJEOKHCIBGM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44A7060", Offset = "0x44A6260", VA = "0x1844A7060")]
	public static KJEOKHCIBGM<TOk, TErr> GENOPPFEMMG([In] TOk GDGOPIMOLAK)
	{
		return default(KJEOKHCIBGM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3188720", Offset = "0x3187920", VA = "0x183188720")]
	public KJEOKHCIBGM<TOk?, UErr?> CDLOOODPPHA<UErr>()
	{
		return default(KJEOKHCIBGM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3188F60", Offset = "0x3188160", VA = "0x183188F60")]
	public KJEOKHCIBGM<UOk?, TErr?> JJBDEAFDLJA<UOk>()
	{
		return default(KJEOKHCIBGM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3189830", Offset = "0x3188A30", VA = "0x183189830")]
	public KJEOKHCIBGM<UOk?, TErr?> LJCGDCPEABL<UOk>()
	{
		return default(KJEOKHCIBGM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3188C00", Offset = "0x3187E00", VA = "0x183188C00")]
	public KJEOKHCIBGM<TOk?, UErr?> FACCOAEDNIO<UErr>()
	{
		return default(KJEOKHCIBGM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x44A60C0", Offset = "0x44A52C0", VA = "0x1844A60C0")]
	public KJEOKHCIBGM<EPFCCNCFAEJ, TErr> EHNIJFEECLA()
	{
		return default(KJEOKHCIBGM<EPFCCNCFAEJ, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x44A8500", Offset = "0x44A7700", VA = "0x1844A8500")]
	public static bool IELJJBKMIFI([In] KJEOKHCIBGM<TOk, TErr> PCICJLNHPMM, [In] KJEOKHCIBGM<TOk, TErr> OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x44A6560", Offset = "0x44A5760", VA = "0x1844A6560", Slot = "4")]
	public bool Equals(KJEOKHCIBGM<TOk, TErr> KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x44A63D0", Offset = "0x44A55D0", VA = "0x1844A63D0", Slot = "0")]
	public override bool Equals(object KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x44A7780", Offset = "0x44A6980", VA = "0x1844A7780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x44A9E40", Offset = "0x44A9040", VA = "0x1844A9E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class IENEAFOKEIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MPJHDCFHIID<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<KJEOKHCIBGM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<KJEOKHCIBGM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x47CB860", Offset = "0x47CAA60", VA = "0x1847CB860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x47CBEA0", Offset = "0x47CB0A0", VA = "0x1847CBEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2E45AE0", Offset = "0x2E44CE0", VA = "0x182E45AE0")]
	public static KJEOKHCIBGM<TOk?, TErr?> AMGAMGDDLJD<TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [In] TOk GDGOPIMOLAK)
	{
		return default(KJEOKHCIBGM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2E45B40", Offset = "0x2E44D40", VA = "0x182E45B40")]
	public static KJEOKHCIBGM<EPFCCNCFAEJ, TErr?> AMGAMGDDLJD<TErr>([In] this KJEOKHCIBGM<EPFCCNCFAEJ, TErr> AEFKHDNCNFD)
	{
		return default(KJEOKHCIBGM<EPFCCNCFAEJ, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2E45AE0", Offset = "0x2E44CE0", VA = "0x182E45AE0")]
	public static KJEOKHCIBGM<TOk?, TErr?> BGGCGGOOMOG<TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [In] TErr KBDJGPGHDEH)
	{
		return default(KJEOKHCIBGM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2E46CF0", Offset = "0x2E45EF0", VA = "0x182E46CF0")]
	public static TOk? EDBFPMKNFHC<TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2E483D0", Offset = "0x2E475D0", VA = "0x182E483D0")]
	[AsyncStateMachine(typeof(MPJHDCFHIID<, >))]
	public static Task<TOk?>? JFLHPGNAOPN<TOk, TErr>(this Task<KJEOKHCIBGM<TOk, TErr>> AEFKHDNCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E45F10", Offset = "0x2E45110", VA = "0x182E45F10")]
	public static TErr? ANHIPEMACKL<TErr, TOk>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E471F0", Offset = "0x2E463F0", VA = "0x182E471F0")]
	public static bool IMGCNEPDIKO<TOk, TErr, UErr, UOk>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [Out] KJEOKHCIBGM<UOk, UErr> MNMOFLPMMHI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2E48B30", Offset = "0x2E47D30", VA = "0x182E48B30")]
	public static bool KEMFAOCAEOK<TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [Out][NotNullWhen(true)] TOk GDGOPIMOLAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2E48EA0", Offset = "0x2E480A0", VA = "0x182E48EA0")]
	public static bool MIHKPMAHEIN<TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [Out][NotNullWhen(true)] TErr KBDJGPGHDEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E48DC0", Offset = "0x2E47FC0", VA = "0x182E48DC0")]
	public static bool KIDHNDKIKGG<TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [Out][NotNullWhen(true)] TOk GDGOPIMOLAK, [Out][NotNullWhen(false)] TErr KBDJGPGHDEH) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2E467D0", Offset = "0x2E459D0", VA = "0x182E467D0")]
	public static bool BGMFBPDPMGG<TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [Out][NotNullWhen(true)] TOk GDGOPIMOLAK, [Out] KJEOKHCIBGM<TOk, TErr> MNMOFLPMMHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E47450", Offset = "0x2E46650", VA = "0x182E47450")]
	public static bool IMGCNEPDIKO<TOk, TErr, UErr, UOk>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [Out][NotNullWhen(true)] TOk GDGOPIMOLAK, [Out] KJEOKHCIBGM<UOk, UErr> MNMOFLPMMHI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E48780", Offset = "0x2E47980", VA = "0x182E48780")]
	public static bool JJDPKOANBOE<TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [Out][NotNullWhen(true)] TOk GDGOPIMOLAK, [Out] KJEOKHCIBGM<EPFCCNCFAEJ, TErr> MNMOFLPMMHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E46350", Offset = "0x2E45550", VA = "0x182E46350")]
	public static KJEOKHCIBGM<UOk, UErr> BGCBJDMGDCJ<UOk, UErr, TOk, TErr>([In] this KJEOKHCIBGM<TOk, TErr> AEFKHDNCNFD, [In] KJEOKHCIBGM<UOk, UErr> JNLAAHCIJJI) where TOk : UOk where TErr : UErr
	{
		return default(KJEOKHCIBGM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2E468D0", Offset = "0x2E45AD0", VA = "0x182E468D0")]
	public static KJEOKHCIBGM<TOk?[]?, TErr?> COOGFDGKIGH<TOk, TErr>(this IEnumerable<KJEOKHCIBGM<TOk, TErr>> AEFKHDNCNFD)
	{
		return default(KJEOKHCIBGM<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BAIOABGLIDO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5520", Offset = "0x2CA4720", VA = "0x182CA5520")]
	public static KJEOKHCIBGM<TOk, T> AMGAMGDDLJD<TOk>([In] TOk GDGOPIMOLAK) where TOk : notnull
	{
		return default(KJEOKHCIBGM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x51BF190", Offset = "0x51BE390", VA = "0x1851BF190")]
	public static KJEOKHCIBGM<EPFCCNCFAEJ, T> AMGAMGDDLJD()
	{
		return default(KJEOKHCIBGM<EPFCCNCFAEJ, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5520", Offset = "0x2CA4720", VA = "0x182CA5520")]
	public static KJEOKHCIBGM<T, TErr> BGGCGGOOMOG<TErr>([In] TErr KBDJGPGHDEH) where TErr : notnull
	{
		return default(KJEOKHCIBGM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct PFFOGGDJMPL<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IGNNIOGICPO ODOBNJJLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> JGPNGCOEGCJ;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4565B20", Offset = "0x4564D20", VA = "0x184565B20")]
	public static PFFOGGDJMPL<TKey, TValue> MIFIOLMMIDE(string GFIAFOEJCDD)
	{
		return default(PFFOGGDJMPL<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4565C40", Offset = "0x4564E40", VA = "0x184565C40")]
	internal PFFOGGDJMPL(Dictionary<TKey, TValue> JECHHBGMFLN, IGNNIOGICPO LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4565A80", Offset = "0x4564C80", VA = "0x184565A80")]
	public IONAIIBCEPF<TKey, TValue> GGJNLINKBLM([Out] Dictionary<TKey, TValue> JECHHBGMFLN)
	{
		return default(IONAIIBCEPF<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct IONAIIBCEPF<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> JGPNGCOEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly GODBBCHELON DJCMHEABHCA;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x23BD980", Offset = "0x23BCB80", VA = "0x1823BD980")]
	internal IONAIIBCEPF(Dictionary<TKey, TValue> JECHHBGMFLN, GODBBCHELON JFFHCBNBIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3F05440", Offset = "0x3F04640", VA = "0x183F05440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct DNFADCHGIFL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly IGNNIOGICPO ODOBNJJLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> JGPNGCOEGCJ;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4565B20", Offset = "0x4564D20", VA = "0x184565B20")]
	public static DNFADCHGIFL<T> MIFIOLMMIDE(string GFIAFOEJCDD)
	{
		return default(DNFADCHGIFL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4565C40", Offset = "0x4564E40", VA = "0x184565C40")]
	internal DNFADCHGIFL(HashSet<T> JECHHBGMFLN, IGNNIOGICPO LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4565A80", Offset = "0x4564C80", VA = "0x184565A80")]
	public PIHLBHJMNBI<T> GGJNLINKBLM([Out] HashSet<T> JECHHBGMFLN)
	{
		return default(PIHLBHJMNBI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct PIHLBHJMNBI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> JGPNGCOEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GODBBCHELON DJCMHEABHCA;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x23BD980", Offset = "0x23BCB80", VA = "0x1823BD980")]
	internal PIHLBHJMNBI(HashSet<T> JECHHBGMFLN, GODBBCHELON JFFHCBNBIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F05440", Offset = "0x3F04640", VA = "0x183F05440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LNFIDIPPGOD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IGNNIOGICPO ODOBNJJLPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> JGPNGCOEGCJ;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4565B20", Offset = "0x4564D20", VA = "0x184565B20")]
	public static LNFIDIPPGOD<T> MIFIOLMMIDE(string GFIAFOEJCDD)
	{
		return default(LNFIDIPPGOD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4565C40", Offset = "0x4564E40", VA = "0x184565C40")]
	internal LNFIDIPPGOD(Stack<T> JECHHBGMFLN, IGNNIOGICPO LOOLDADLMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4565A80", Offset = "0x4564C80", VA = "0x184565A80")]
	public AEGHBHDBGFD<T> GGJNLINKBLM([Out] Stack<T> JECHHBGMFLN)
	{
		return default(AEGHBHDBGFD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct AEGHBHDBGFD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> JGPNGCOEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GODBBCHELON DJCMHEABHCA;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x23BD980", Offset = "0x23BCB80", VA = "0x1823BD980")]
	internal AEGHBHDBGFD(Stack<T> JECHHBGMFLN, GODBBCHELON JFFHCBNBIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3F05440", Offset = "0x3F04640", VA = "0x183F05440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class LOMEIPJBOKE<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct DKIGHDLDLBP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly LOMEIPJBOKE<T> OIIJPIEPJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int DDLHCMEEDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool KAIHCBHNOCM;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x20E9AD0", Offset = "0x20E8CD0", VA = "0x1820E9AD0")]
		public DKIGHDLDLBP(LOMEIPJBOKE<T> JANAFGLBOCK, int DHADHDEKDPK, bool LPPNDCEBFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B33F80", Offset = "0x5B33180", VA = "0x185B33F80")]
		public LOMEIPJBOKE<T>.GHHNDPLFAHG AKJNNDDNIOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5B34070", Offset = "0x5B33270", VA = "0x185B34070", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B34070", Offset = "0x5B33270", VA = "0x185B34070", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class GHHNDPLFAHG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly LOMEIPJBOKE<T> OIIJPIEPJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int MDDNLDDEHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int MPKEPCKHJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool KAIHCBHNOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool GGIHLMPODDK;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x3F655E0", Offset = "0x3F647E0", VA = "0x183F655E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3F657A0", Offset = "0x3F649A0", VA = "0x183F657A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3F65970", Offset = "0x3F64B70", VA = "0x183F65970", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F65B10", Offset = "0x3F64D10", VA = "0x183F65B10")]
		public GHHNDPLFAHG(LOMEIPJBOKE<T> JANAFGLBOCK, int DHADHDEKDPK, bool LPPNDCEBFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F65620", Offset = "0x3F64820", VA = "0x183F65620", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F656B0", Offset = "0x3F648B0", VA = "0x183F656B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class CKNMJGNKHBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public CKNMJGNKHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x57C8270", Offset = "0x57C7470", VA = "0x1857C8270")]
		internal T IKGCEPPOOKO(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] KEFJEODBKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int MPKEPCKHJGB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int CIGAEHBCFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x456FE40", Offset = "0x456F040", VA = "0x18456FE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T HLBNAJGJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E53450", Offset = "0x3E52650", VA = "0x183E53450")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T KDADLGIOJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4570090", Offset = "0x456F290", VA = "0x184570090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x456FFB0", Offset = "0x456F1B0", VA = "0x18456FFB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DIBMJIIAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA860", Offset = "0x1DA9A60", VA = "0x181DAA860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1458270", Offset = "0x1457470", VA = "0x181458270")]
	private static int HDBLKHLAGPP(int KINMHNEMPOD, int KOHJFMFCHKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x45700D0", Offset = "0x456F2D0", VA = "0x1845700D0")]
	public LOMEIPJBOKE(int JAICOMOJIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x45701F0", Offset = "0x456F3F0", VA = "0x1845701F0")]
	public LOMEIPJBOKE(int JAICOMOJIGD, Func<T> ICNDFBNGEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4570450", Offset = "0x456F650", VA = "0x184570450")]
	public LOMEIPJBOKE(T[] HJAFNJHIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x456FEA0", Offset = "0x456F0A0", VA = "0x18456FEA0")]
	public void IBGMMNHAIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x456FD80", Offset = "0x456EF80", VA = "0x18456FD80")]
	public IEnumerable<T> AOBGMLEENBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x456FCE0", Offset = "0x456EEE0", VA = "0x18456FCE0")]
	public LOMEIPJBOKE<T>.GHHNDPLFAHG AKJNNDDNIOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA020", Offset = "0x3AC9220", VA = "0x183ACA020", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3ACA020", Offset = "0x3AC9220", VA = "0x183ACA020", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class FMILBJEAOAC
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2DFD720", Offset = "0x2DFC920", VA = "0x182DFD720")]
	public static LOMEIPJBOKE<T> MIFIOLMMIDE<T>(int JAICOMOJIGD, Func<T> ICNDFBNGEMO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class KBKFKDCBKPM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct PKCICKJGIDI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly KBKFKDCBKPM<T> AMPPJKNMIIK;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T GOGBANOMEKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x4AA9D90", Offset = "0x4AA8F90", VA = "0x184AA9D90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4AA9DB0", Offset = "0x4AA8FB0", VA = "0x184AA9DB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
		public PKCICKJGIDI(KBKFKDCBKPM<T> AMPPJKNMIIK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MHCNLIKHABG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<PKCICKJGIDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public KBKFKDCBKPM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4787800", Offset = "0x4786A00", VA = "0x184787800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4019E70", Offset = "0x4019070", VA = "0x184019E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim NBPJOOBIGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T DKECFALHIPG;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x446C460", Offset = "0x446B660", VA = "0x18446C460")]
	public KBKFKDCBKPM([In] T DKECFALHIPG, int CHGLGNEHKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x446C380", Offset = "0x446B580", VA = "0x18446C380")]
	public KBKFKDCBKPM([In] T DKECFALHIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x446BDB0", Offset = "0x446AFB0", VA = "0x18446BDB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x446C290", Offset = "0x446B490", VA = "0x18446C290")]
	public PKCICKJGIDI PGGDJGAFFAO()
	{
		return default(PKCICKJGIDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x446C150", Offset = "0x446B350", VA = "0x18446C150")]
	[AsyncStateMachine(typeof(KBKFKDCBKPM<>.MHCNLIKHABG))]
	public Task<KBKFKDCBKPM<T>.PKCICKJGIDI> OOGFJAFOIHN(CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x446C270", Offset = "0x446B470", VA = "0x18446C270")]
	public void PGGCPPPDNKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HFACGOANBMK
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D43420", Offset = "0x6D42620", VA = "0x186D43420")]
	public static KBKFKDCBKPM<EPFCCNCFAEJ> MIFIOLMMIDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C25AD0", Offset = "0x2C24CD0", VA = "0x182C25AD0")]
	public static KBKFKDCBKPM<T> MIFIOLMMIDE<T>([In] T DKECFALHIPG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class LDCBDKEBLIF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct HJAKJGBJLKO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly LDCBDKEBLIF<T> ICNAIMEICOF;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T GOGBANOMEKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x4038A00", Offset = "0x4037C00", VA = "0x184038A00")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4038B40", Offset = "0x4037D40", VA = "0x184038B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
		internal HJAKJGBJLKO(LDCBDKEBLIF<T> AMPPJKNMIIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct MLICLJLMCBM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly LDCBDKEBLIF<T> ICNAIMEICOF;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T GOGBANOMEKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x4038A00", Offset = "0x4037C00", VA = "0x184038A00")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x47BFE00", Offset = "0x47BF000", VA = "0x1847BFE00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
		internal MLICLJLMCBM(LDCBDKEBLIF<T> AMPPJKNMIIK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MGPPKFBBKNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<MLICLJLMCBM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LDCBDKEBLIF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private KBKFKDCBKPM<EPFCCNCFAEJ>.PKCICKJGIDI <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<KBKFKDCBKPM<EPFCCNCFAEJ>.PKCICKJGIDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4785640", Offset = "0x4784840", VA = "0x184785640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4019E70", Offset = "0x4019070", VA = "0x184019E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly KBKFKDCBKPM<int> LIHCILGEEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KBKFKDCBKPM<EPFCCNCFAEJ> KFLBIHJINHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KBKFKDCBKPM<EPFCCNCFAEJ> NKBLCICLFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T IKCLJHBDFFA;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4536100", Offset = "0x4535300", VA = "0x184536100")]
	internal LDCBDKEBLIF(KBKFKDCBKPM<int> NFMGBJHOPGN, KBKFKDCBKPM<EPFCCNCFAEJ> KBNMCJANCED, KBKFKDCBKPM<EPFCCNCFAEJ> ABELEPCBENG, [In] T DKECFALHIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4535510", Offset = "0x4534710", VA = "0x184535510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4535D80", Offset = "0x4534F80", VA = "0x184535D80")]
	public HJAKJGBJLKO OMCAHAFDGID()
	{
		return default(HJAKJGBJLKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4535590", Offset = "0x4534790", VA = "0x184535590")]
	public MLICLJLMCBM FGHBHDAKNDG()
	{
		return default(MLICLJLMCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4535860", Offset = "0x4534A60", VA = "0x184535860")]
	[AsyncStateMachine(typeof(LDCBDKEBLIF<>.MGPPKFBBKNC))]
	public Task<LDCBDKEBLIF<T>.MLICLJLMCBM> GLLEKKIBHGF(CancellationToken DDNLBFLLCLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JBODPOIBNNC
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D43890", Offset = "0x6D42A90", VA = "0x186D43890")]
	public static LDCBDKEBLIF<EPFCCNCFAEJ> MIFIOLMMIDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C940", Offset = "0x2E6BB40", VA = "0x182E6C940")]
	public static LDCBDKEBLIF<T> MIFIOLMMIDE<T>([In] T DKECFALHIPG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class CCFMJGNHIMA<TData> : KKIKBNLICGH where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string PGKAKDMACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData OMAPODLEEDD;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
	public override string PBDEAEJPOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x56C6DF0", Offset = "0x56C5FF0", VA = "0x1856C6DF0")]
	internal CCFMJGNHIMA(string ADNFLGLLNKI, [In] TData LJIEGDEDOHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MEJCAAABDKM
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6D45BD0", Offset = "0x6D44DD0", VA = "0x186D45BD0")]
	public static CCFMJGNHIMA<EPFCCNCFAEJ> MIFIOLMMIDE(string ADNFLGLLNKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C25C10", Offset = "0x2C24E10", VA = "0x182C25C10")]
	public static CCFMJGNHIMA<TData> MIFIOLMMIDE<TData>(string ADNFLGLLNKI, [In] TData LJIEGDEDOHM) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class IGNNIOGICPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool ICNNOPOHEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string EPECGHMDBJI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x94ED50", Offset = "0x94DF50", VA = "0x18094ED50")]
	private IGNNIOGICPO(bool LCEGNFOFKGJ, string HIEIKFADEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D43550", Offset = "0x6D42750", VA = "0x186D43550")]
	public static IGNNIOGICPO MIFIOLMMIDE(string HIEIKFADEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D43490", Offset = "0x6D42690", VA = "0x186D43490")]
	public GODBBCHELON GGJNLINKBLM()
	{
		return default(GODBBCHELON);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct GODBBCHELON : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IGNNIOGICPO PIPOPCHIENN;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	internal GODBBCHELON(IGNNIOGICPO GFIAFOEJCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D43400", Offset = "0x6D42600", VA = "0x186D43400", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class FCCNDCLGCEB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class GLPPPNHOAEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public GLPPPNHOAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3FC7790", Offset = "0x3FC6990", VA = "0x183FC7790")]
		internal int NCENOAKFNOH(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? HCJCFKPJHKO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> MPMIELEPPND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E69130", Offset = "0x3E68330", VA = "0x183E69130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EBHLGDOBDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E68D60", Offset = "0x3E67F60", VA = "0x183E68D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x89A5C0", Offset = "0x8997C0", VA = "0x18089A5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3E68E00", Offset = "0x3E68000", VA = "0x183E68E00")]
	public bool JIJNOIKPNBF(T NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3E68FC0", Offset = "0x3E681C0", VA = "0x183E68FC0")]
	public bool LOGGCHCCBFB(T NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3E68DB0", Offset = "0x3E67FB0", VA = "0x183E68DB0")]
	public bool IMBCHPJELFP(T NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3E68C80", Offset = "0x3E67E80", VA = "0x183E68C80")]
	public void BCDNFGFFIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3E69170", Offset = "0x3E68370", VA = "0x183E69170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public FCCNDCLGCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class ANFGKOFMNEN
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class OHJONOABFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OHJONOABFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D46030", Offset = "0x6D45230", VA = "0x186D46030")]
		internal int NCENOAKFNOH(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? HCJCFKPJHKO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> MPMIELEPPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6D42E80", Offset = "0x6D42080", VA = "0x186D42E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool EBHLGDOBDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6D42C90", Offset = "0x6D41E90", VA = "0x186D42C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x89A5C0", Offset = "0x8997C0", VA = "0x18089A5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D42D00", Offset = "0x6D41F00", VA = "0x186D42D00")]
	public bool JIJNOIKPNBF(object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D42DE0", Offset = "0x6D41FE0", VA = "0x186D42DE0")]
	public bool LOGGCHCCBFB(object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6D42CA0", Offset = "0x6D41EA0", VA = "0x186D42CA0")]
	public bool IMBCHPJELFP(object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D42C20", Offset = "0x6D41E20", VA = "0x186D42C20")]
	public void BCDNFGFFIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D42F10", Offset = "0x6D42110", VA = "0x186D42F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public ANFGKOFMNEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class LOGBCGONBOC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct CHIIJDCLLPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float GOOCIEMHBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T GOGBANOMEKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, CHIIJDCLLPG> HEPGHFONHMI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T BJPOPLDDBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x13437E0", Offset = "0x13429E0", VA = "0x1813437E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1342DD0", Offset = "0x1341FD0", VA = "0x181342DD0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? ECKNGKBGKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x89AD00", Offset = "0x899F00", VA = "0x18089AD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DHCODKJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4569030", Offset = "0x4568230", VA = "0x184569030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x456B390", Offset = "0x456A590", VA = "0x18456B390")]
	public bool MNIPKGIAFIL(T JECHHBGMFLN, object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x456B5E0", Offset = "0x456A7E0", VA = "0x18456B5E0")]
	public bool PCHNNANGKFF(object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x454ED00", Offset = "0x454DF00", VA = "0x18454ED00")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x456ABF0", Offset = "0x4569DF0", VA = "0x18456ABF0")]
	public bool GOLMABOLCED(object NIOIDOPDJKO, [Out] T JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x45696D0", Offset = "0x45688D0", VA = "0x1845696D0")]
	[EFPNGMIACCF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FLJNIKOOPIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x456B680", Offset = "0x456A880", VA = "0x18456B680")]
	public LOGBCGONBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class EEHPCIFJNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly string PLDAODAGFAI;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public EEHPCIFJNOJ(string PLDAODAGFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D433B0", Offset = "0x6D425B0", VA = "0x186D433B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class KOKIBCKEMGH<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private List<WeakReference<T>>? HCJCFKPJHKO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool EBHLGDOBDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x44C1BA0", Offset = "0x44C0DA0", VA = "0x1844C1BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x44C1F30", Offset = "0x44C1130", VA = "0x1844C1F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x44C1CC0", Offset = "0x44C0EC0", VA = "0x1844C1CC0")]
	public void JIJNOIKPNBF(T NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x44C20D0", Offset = "0x44C12D0", VA = "0x1844C20D0")]
	public void LOGGCHCCBFB(T NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x44C1B60", Offset = "0x44C0D60", VA = "0x1844C1B60")]
	public void BCDNFGFFIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x44C2270", Offset = "0x44C1470", VA = "0x1844C2270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KOKIBCKEMGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class KEJCLOCBPMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E190", Offset = "0x2E4D390", VA = "0x182E4E190")]
	public static void BLPAAOKFBGM<T>(this List<T> NAGHBLHDGIK, int KINMHNEMPOD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class DCADIJPOKOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<object, float> HEPGHFONHMI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float PBGHKPGMFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA0F670", Offset = "0xA0E870", VA = "0x180A0F670")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA0F280", Offset = "0xA0E480", VA = "0x180A0F280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D43240", Offset = "0x6D42440", VA = "0x186D43240")]
	public void MNIPKGIAFIL(float JECHHBGMFLN, object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D432B0", Offset = "0x6D424B0", VA = "0x186D432B0")]
	public void PCHNNANGKFF(object NIOIDOPDJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D430C0", Offset = "0x6D422C0", VA = "0x186D430C0")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D43110", Offset = "0x6D42310", VA = "0x186D43110")]
	private void HAJAOHBNLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D43320", Offset = "0x6D42520", VA = "0x186D43320")]
	public DCADIJPOKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface HADDBMBPBBD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PNIGDBBEAKK DHHGPENFCJN;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LJOPDIJGBEK : HADDBMBPBBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct IKEFAILOCNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float LJGFOBFFBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly float ECFIGNEHKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal readonly bool LHNMCLPFALC;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float NCANLJNAAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6D435C0", Offset = "0x6D427C0", VA = "0x186D435C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D43730", Offset = "0x6D42930", VA = "0x186D43730")]
		public IKEFAILOCNK(float NJJFLJLDLKI, float BBMKIHEGKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D435D0", Offset = "0x6D427D0", VA = "0x186D435D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class LFDHDAFIBDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LJOPDIJGBEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public LFDHDAFIBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6D45210", Offset = "0x6D44410", VA = "0x186D45210")]
		internal void PBLCBKLNBAA(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int LCNCMFGPICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int FPEHHMNNENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HADDBMBPBBD[] MOCMBPEIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PNIGDBBEAKK[] PAHMCFCAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IKEFAILOCNK[] IFHMONAGAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private IKEFAILOCNK CCCAFOGONJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly KDNPFGAHOCA FMLKAILFJHF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PNIGDBBEAKK DHHGPENFCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6D45480", Offset = "0x6D44680", VA = "0x186D45480", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6D452B0", Offset = "0x6D444B0", VA = "0x186D452B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6D45A40", Offset = "0x6D44C40", VA = "0x186D45A40")]
	public LJOPDIJGBEK(int LCNCMFGPICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6D459B0", Offset = "0x6D44BB0", VA = "0x186D459B0")]
	public KDNPFGAHOCA PFIKAOJAGDF(IKEFAILOCNK GELGLJHAMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6D45540", Offset = "0x6D44740", VA = "0x186D45540")]
	public void OCFDECMJJJK(HADDBMBPBBD GOCADIFFMHM, [Optional] IKEFAILOCNK BCCDDDPHFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6D45370", Offset = "0x6D44570", VA = "0x186D45370", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void PNIGDBBEAKK(float JONKJDMHCLM);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ADMIHABHMLF
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PHJAFCJHPIH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly HADDBMBPBBD BOBFADCKAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly PNIGDBBEAKK FKNFKAHALGJ;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6D46130", Offset = "0x6D45330", VA = "0x186D46130")]
		public PHJAFCJHPIH(HADDBMBPBBD BOBFADCKAHO, PNIGDBBEAKK FKNFKAHALGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6D460E0", Offset = "0x6D452E0", VA = "0x186D460E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D42AF0", Offset = "0x6D41CF0", VA = "0x186D42AF0")]
	internal static bool IMLKLCGABBC(float APIBENHOAOO, float EGCFJOLCAMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6D326C0", Offset = "0x6D318C0", VA = "0x186D326C0")]
	internal static float MLFICJPHEBO(float APIBENHOAOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D42B60", Offset = "0x6D41D60", VA = "0x186D42B60")]
	public static IDisposable PFEDDHILEAC(this HADDBMBPBBD BOBFADCKAHO, PNIGDBBEAKK FKNFKAHALGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KDNPFGAHOCA : HADDBMBPBBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private float JONKJDMHCLM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float DAKGJFEMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6D43F00", Offset = "0x6D43100", VA = "0x186D43F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PNIGDBBEAKK? DHHGPENFCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6D43E60", Offset = "0x6D43060", VA = "0x186D43E60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6D43DC0", Offset = "0x6D42FC0", VA = "0x186D43DC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KDNPFGAHOCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface JLCNGKDLCML<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BPEKBPPJDKB<T> MIINEHAMMLL([Out] T JECHHBGMFLN);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AODHOHPPLKC();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ADFFJKELFGN<T> : JLCNGKDLCML<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ConcurrentStack<T> DINEOIMKAFB;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3F03190", Offset = "0x3F02390", VA = "0x183F03190", Slot = "4")]
	public BPEKBPPJDKB<T> MIINEHAMMLL([Out] T JECHHBGMFLN)
	{
		return default(BPEKBPPJDKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3F03110", Offset = "0x3F02310", VA = "0x183F03110")]
	public void IMHGPOENCOG(T LEMNKCBBGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3F030C0", Offset = "0x3F022C0", VA = "0x183F030C0", Slot = "5")]
	public void AODHOHPPLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "6")]
	protected virtual void GCKCKKMHMEI(T OPFMPNCLCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3F03230", Offset = "0x3F02430", VA = "0x183F03230")]
	private T PLOCNKMCLIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3F032D0", Offset = "0x3F024D0", VA = "0x183F032D0")]
	public ADFFJKELFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct BPEKBPPJDKB<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly T LEMNKCBBGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly ADFFJKELFGN<T> GBANJLPKCDM;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
	internal BPEKBPPJDKB(T JECHHBGMFLN, ADFFJKELFGN<T> GBANJLPKCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x52F98A0", Offset = "0x52F8AA0", VA = "0x1852F98A0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class KHEJNAGDMFK : ADFFJKELFGN<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly KHEJNAGDMFK FAKOKDPOOAM;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D44010", Offset = "0x6D43210", VA = "0x186D44010")]
	public static BPEKBPPJDKB<StringBuilder> PLOCNKMCLIO([Out] StringBuilder JECHHBGMFLN)
	{
		return default(BPEKBPPJDKB<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D43FF0", Offset = "0x6D431F0", VA = "0x186D43FF0", Slot = "6")]
	protected override void GCKCKKMHMEI(StringBuilder OPFMPNCLCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D44140", Offset = "0x6D43340", VA = "0x186D44140")]
	public KHEJNAGDMFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class AFGCIJIEBIM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6791C70", Offset = "0x6790E70", VA = "0x186791C70")]
	public AFGCIJIEBIM(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class LPJJOHNFKOG<TKey, TValue> : BJPENGIKLEL<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, MDODDLIFDJE where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class ANILPOEAJGG : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public LPJJOHNFKOG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x13437E0", Offset = "0x13429E0", VA = "0x1813437E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x44759C0", Offset = "0x4474BC0", VA = "0x1844759C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public ANILPOEAJGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3D245F0", Offset = "0x3D237F0", VA = "0x183D245F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4475400", Offset = "0x4474600", VA = "0x184475400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4475830", Offset = "0x4474A30", VA = "0x184475830")]
		private void ODPIAJHKBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4474A80", Offset = "0x4473C80", VA = "0x184474A80")]
		private void FNDCHHHCBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4475920", Offset = "0x4474B20", VA = "0x184475920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BJPENGIKLEL<TKey, TValue> DMLNKJPNGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IDictionary<TKey, TValue> HNPIEIJEBLF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4575E00", Offset = "0x4575000", VA = "0x184575E00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CFPKGOMMBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4575FE0", Offset = "0x45751E0", VA = "0x184575FE0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x45762B0", Offset = "0x45754B0", VA = "0x1845762B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> LOCGEIOJDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4576030", Offset = "0x4575230", VA = "0x184576030", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> CHNBFAGHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4576150", Offset = "0x4575350", VA = "0x184576150", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4575C70", Offset = "0x4574E70", VA = "0x184575C70")]
	public LPJJOHNFKOG(BJPENGIKLEL<TKey, TValue> DMLNKJPNGLG, [Optional] IDictionary<TKey, TValue>? HNPIEIJEBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x45739C0", Offset = "0x4572BC0", VA = "0x1845739C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4574500", Offset = "0x4573700", VA = "0x184574500")]
	public void IIKCCNHANNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4573230", Offset = "0x4572430", VA = "0x184573230", Slot = "9")]
	public void Add(TKey CPBLLDDDHEE, TValue JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4573830", Offset = "0x4572A30", VA = "0x184573830")]
	public void CNFDOEMLKEJ(TKey CPBLLDDDHEE, TValue JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4574900", Offset = "0x4573B00", VA = "0x184574900")]
	public void JCPAHGBOBMM(TKey CPBLLDDDHEE, TValue JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4574A90", Offset = "0x4573C90", VA = "0x184574A90")]
	public void JGNNGNCFOAH(TKey CPBLLDDDHEE, TValue JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4573670", Offset = "0x4572870", VA = "0x184573670")]
	public void CCOKEDMKPEL(TKey CPBLLDDDHEE, TValue JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x45752F0", Offset = "0x45744F0", VA = "0x1845752F0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x45754E0", Offset = "0x45746E0", VA = "0x1845754E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x45756A0", Offset = "0x45748A0", VA = "0x1845756A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4573A50", Offset = "0x4572C50", VA = "0x184573A50", Slot = "8")]
	public bool ContainsKey(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4574F90", Offset = "0x4574190", VA = "0x184574F90")]
	public bool OCJJIGIBLKM(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x45742E0", Offset = "0x45734E0", VA = "0x1845742E0")]
	public bool FHFNDANOEEM(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4575110", Offset = "0x4574310", VA = "0x184575110", Slot = "10")]
	public bool Remove(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4575AD0", Offset = "0x4574CD0", VA = "0x184575AD0", Slot = "11")]
	public bool TryGetValue(TKey CPBLLDDDHEE, [Out] TValue JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4573E00", Offset = "0x4573000", VA = "0x184573E00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] IEIBCNCHGJN, int AEOBJDNFNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x443D2F0", Offset = "0x443C4F0", VA = "0x18443D2F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x45743A0", Offset = "0x45735A0", VA = "0x1845743A0", Slot = "19")]
	[IteratorStateMachine(typeof(LPJJOHNFKOG<, >.ANILPOEAJGG))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x45730A0", Offset = "0x45722A0", VA = "0x1845730A0", Slot = "21")]
	public bool ANKNBBONJLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4574720", Offset = "0x4573920", VA = "0x184574720")]
	private TValue IKEOKEDEGBM(TKey CPBLLDDDHEE)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface MDODDLIFDJE
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ANKNBBONJLP();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface BJPENGIKLEL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, MDODDLIFDJE
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public sealed class MAAEIKNCNEJ<TKey, TVal> : BJPENGIKLEL<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, MDODDLIFDJE where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate int PAFHHBINOPA(TKey CPBLLDDDHEE, TVal JECHHBGMFLN);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void PFEAKNCDNLA(TKey CPBLLDDDHEE, TVal JECHHBGMFLN, ENCEGIKDION HJGNFPCEHLP);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class MCEOLKKKOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA7FAC0", Offset = "0xA7ECC0", VA = "0x180A7FAC0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal GOGBANOMEKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA22AE0", Offset = "0xA21CE0", VA = "0x180A22AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int NCANLJNAAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8D5A10", Offset = "0x8D4C10", VA = "0x1808D5A10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D5600", Offset = "0x8D4800", VA = "0x1808D5600")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset BALPKNCHKCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xEF9890", Offset = "0xEF8A90", VA = "0x180EF9890")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1966930", Offset = "0x1965B30", VA = "0x181966930")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x476FD90", Offset = "0x476EF90", VA = "0x18476FD90")]
		public MCEOLKKKOEJ(TKey CPBLLDDDHEE, TVal MIOIFIAKEJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class CIPEFFFMLLO : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public MAAEIKNCNEJ<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LinkedList<MCEOLKKKOEJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x13437E0", Offset = "0x13429E0", VA = "0x1813437E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x57C47C0", Offset = "0x57C39C0", VA = "0x1857C47C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public CIPEFFFMLLO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F140", Offset = "0x3D1E340", VA = "0x183D1F140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x57C3680", Offset = "0x57C2880", VA = "0x1857C3680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x57C4280", Offset = "0x57C3480", VA = "0x1857C4280")]
		private void ODPIAJHKBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x57C4720", Offset = "0x57C3920", VA = "0x1857C4720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int CFMFJHNKLHO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<TKey, LinkedListNode<MCEOLKKKOEJ>> JLKMCHHJLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LinkedList<MCEOLKKKOEJ> AODNHADCLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly PAFHHBINOPA? HJDHEHKBOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly TimeSpan PNLHCAIGDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly PFEAKNCDNLA? GBOOGJMHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly CLMPFIKOBAD ABMGNDIJCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool BAGBADAJHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<TKey> DBPJDKOOIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<TVal> NIACMGGPJMN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int PKFMAHJGDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8A5090", Offset = "0x8A4290", VA = "0x1808A5090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int IEOKHDHOEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x98D7B0", Offset = "0x98C9B0", VA = "0x18098D7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x98D7A0", Offset = "0x98C9A0", VA = "0x18098D7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4757E00", Offset = "0x4757000", VA = "0x184757E00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int EAKHIGHGOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x454ED00", Offset = "0x454DF00", VA = "0x18454ED00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> CHNBFAGHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4757F80", Offset = "0x4757180", VA = "0x184757F80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.HADMLDOOKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4752120", Offset = "0x4751320", VA = "0x184752120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CFPKGOMMBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4757ED0", Offset = "0x47570D0", VA = "0x184757ED0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4757FD0", Offset = "0x47571D0", VA = "0x184757FD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4749960", Offset = "0x4748B60", VA = "0x184749960")]
	private bool NLLKPFHHGMK(int LCNCMFGPICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4746680", Offset = "0x4745880", VA = "0x184746680")]
	private void IDOBIJJCBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4755B00", Offset = "0x4754D00", VA = "0x184755B00")]
	public MAAEIKNCNEJ(int LCNCMFGPICH, [Optional] PAFHHBINOPA? HJDHEHKBOGB, [Optional] IEqualityComparer<TKey>? NGGEBGGCMGI, [Optional] PFEAKNCDNLA? GBOOGJMHKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4753390", Offset = "0x4752590", VA = "0x184753390")]
	public MAAEIKNCNEJ(TimeSpan PNLHCAIGDKP, [Optional] IEqualityComparer<TKey>? NGGEBGGCMGI, [Optional] PFEAKNCDNLA? GBOOGJMHKLD, [Optional] CLMPFIKOBAD? ABMGNDIJCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x47534E0", Offset = "0x47526E0", VA = "0x1847534E0")]
	public MAAEIKNCNEJ(int LCNCMFGPICH, TimeSpan PNLHCAIGDKP, [Optional] IEqualityComparer<TKey>? NGGEBGGCMGI, [Optional] PFEAKNCDNLA? GBOOGJMHKLD, [Optional] CLMPFIKOBAD? ABMGNDIJCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4753560", Offset = "0x4752760", VA = "0x184753560")]
	public MAAEIKNCNEJ(int LCNCMFGPICH, PAFHHBINOPA? HJDHEHKBOGB, TimeSpan PNLHCAIGDKP, [Optional] IEqualityComparer<TKey>? NGGEBGGCMGI, [Optional] PFEAKNCDNLA? GBOOGJMHKLD, [Optional] CLMPFIKOBAD? ABMGNDIJCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4738F10", Offset = "0x4738110", VA = "0x184738F10", Slot = "21")]
	public bool ANKNBBONJLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4737510", Offset = "0x4736710", VA = "0x184737510", Slot = "22")]
	public bool AEFEGOIDNNL(int JAICOMOJIGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x474D400", Offset = "0x474C600", VA = "0x18474D400")]
	private bool ONGFNOPJGML(int JAICOMOJIGD, ENCEGIKDION HJGNFPCEHLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4745F50", Offset = "0x4745150", VA = "0x184745F50")]
	public void HPDIHAPBFNP(TKey CPBLLDDDHEE, TVal JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4739A50", Offset = "0x4738C50", VA = "0x184739A50", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LFDONPLGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x47392F0", Offset = "0x47384F0", VA = "0x1847392F0", Slot = "9")]
	public void Add(TKey CPBLLDDDHEE, TVal JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x473C4F0", Offset = "0x473B6F0", VA = "0x18473C4F0", Slot = "8")]
	public bool ContainsKey(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x47518C0", Offset = "0x4750AC0", VA = "0x1847518C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4750C70", Offset = "0x474FE70", VA = "0x184750C70", Slot = "10")]
	public bool Remove(TKey CPBLLDDDHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4751DA0", Offset = "0x4750FA0", VA = "0x184751DA0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LFDONPLGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4740790", Offset = "0x473F990", VA = "0x184740790")]
	private bool DCNBJDEHCAL(TKey CPBLLDDDHEE, [Out] TVal JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4750980", Offset = "0x474FB80", VA = "0x184750980")]
	private TVal PLOCNKMCLIO(TKey MLKPBJMLLBK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x47523A0", Offset = "0x47515A0", VA = "0x1847523A0", Slot = "11")]
	public bool TryGetValue(TKey MLKPBJMLLBK, [Out] TVal JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x473C220", Offset = "0x473B420", VA = "0x18473C220", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x473F230", Offset = "0x473E430", VA = "0x18473F230", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IEIBCNCHGJN, int AEOBJDNFNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x474F450", Offset = "0x474E650", VA = "0x18474F450")]
	private void OPJBCMCMEPN(TKey CPBLLDDDHEE, TVal MIOIFIAKEJG, ENCEGIKDION HJGNFPCEHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4738D80", Offset = "0x4737F80", VA = "0x184738D80")]
	private bool ALFCKFJAFAE(MCEOLKKKOEJ MJDNOFAJHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x47432D0", Offset = "0x47424D0", VA = "0x1847432D0")]
	private void DPNPFBJJPNL(LinkedListNode<MCEOLKKKOEJ> HBEBIMLAOCN, TVal JJOJMFAMEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4747BE0", Offset = "0x4746DE0", VA = "0x184747BE0")]
	private void MNIPKGIAFIL(TKey CPBLLDDDHEE, TVal JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x473B5C0", Offset = "0x473A7C0", VA = "0x18473B5C0")]
	private void CMAHEMHOHEM(MCEOLKKKOEJ MJDNOFAJHJP, TVal JJOJMFAMEML, int IOKDJCHFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x47458D0", Offset = "0x4744AD0", VA = "0x1847458D0", Slot = "19")]
	[IteratorStateMachine(typeof(MAAEIKNCNEJ<, >.CIPEFFFMLLO))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4752170", Offset = "0x4751370", VA = "0x184752170", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum ENCEGIKDION : byte
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class CPLPGNDIFJJ<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly TKey AAKAJBIIOIC;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x58AAA10", Offset = "0x58A9C10", VA = "0x1858AAA10")]
	public CPLPGNDIFJJ(TKey PKBJNBPKNKL, Exception DKNINGGCJGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class OPDDLNFABLG : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x605EFE0", Offset = "0x605E1E0", VA = "0x18605EFE0")]
	public OPDDLNFABLG(string ADNFLGLLNKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class AEEPOAHLHPA<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FOFHCCKNLGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AEEPOAHLHPA<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public FOFHCCKNLGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5EF0", Offset = "0x3EB50F0", VA = "0x183EB5EF0")]
		internal Task<TResource> MOADPENIGNJ(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct MCIPDBMONLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AEEPOAHLHPA<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x47700D0", Offset = "0x476F2D0", VA = "0x1847700D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4770D70", Offset = "0x476FF70", VA = "0x184770D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct JLALOIGHNFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4387570", Offset = "0x4386770", VA = "0x184387570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4387F90", Offset = "0x4387190", VA = "0x184387F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly HDCJMEDCJMB<TId, Task<TResource>> BAKHIGNEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> JACJADDOMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? ICPGABFFBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Action<TResource>? LEOHNLMLPKG;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3F05270", Offset = "0x3F04470", VA = "0x183F05270")]
	public AEEPOAHLHPA(int OAEHNBCMBMJ = 0, [Optional] IEqualityComparer<TId>? OGGBBCAOOIL, [Optional] Func<TId, CancellationToken, Task<TResource>>? OJIFBEBFEMF, [Optional] Action<TResource>? BPJHOHCJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3F045A0", Offset = "0x3F037A0", VA = "0x183F045A0")]
	public GENINCKMOLO<Task<TResource>> BPLLHBCLFLF(TId MHMAFIBKDFF, [Optional] Func<TId, CancellationToken, Task<TResource>>? OJIFBEBFEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3F03B90", Offset = "0x3F02D90", VA = "0x183F03B90")]
	private void BKBGOKOLGFD(Task<TResource> HMHJFGCCEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3F04CA0", Offset = "0x3F03EA0", VA = "0x183F04CA0")]
	[AsyncStateMachine(typeof(AEEPOAHLHPA<, >.MCIPDBMONLI))]
	private Task FOIDOGFFJAE(Task<TResource> HMHJFGCCEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3F04780", Offset = "0x3F03980", VA = "0x183F04780")]
	public void BPOAAOHNIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3F03AA0", Offset = "0x3F02CA0", VA = "0x183F03AA0")]
	public HDCJMEDCJMB<TId, Task<TResource>>.PFFLBGJGKEM AKJNNDDNIOE()
	{
		return default(HDCJMEDCJMB<TId, Task<TResource>>.PFFLBGJGKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3F050A0", Offset = "0x3F042A0", VA = "0x183F050A0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3F050A0", Offset = "0x3F042A0", VA = "0x183F050A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3F04910", Offset = "0x3F03B10", VA = "0x183F04910")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(AEEPOAHLHPA<, >.JLALOIGHNFL))]
	internal static Task ECJMNPCBLJC(Task<TResource> HMHJFGCCEGP, CancellationTokenSource AILGNJPMFAO, Dictionary<Task<TResource>, CancellationTokenSource> CIKKMKGGJHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class HDCJMEDCJMB<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class GJPIFMKLPBG : IEquatable<GJPIFMKLPBG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TValue GOGBANOMEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int PNKIOJALNKA;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xC115E0", Offset = "0xC107E0", VA = "0x180C115E0")]
		public GJPIFMKLPBG(TValue JECHHBGMFLN, int FCPKBCELAOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F706A0", Offset = "0x3F6F8A0", VA = "0x183F706A0", Slot = "4")]
		public bool Equals(GJPIFMKLPBG? KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F70600", Offset = "0x3F6F800", VA = "0x183F70600", Slot = "0")]
		public override bool Equals(object? JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F707C0", Offset = "0x3F6F9C0", VA = "0x183F707C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct PFFLBGJGKEM : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<TKey, GJPIFMKLPBG>.Enumerator PKNGCEPHODD;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4A8F520", Offset = "0x4A8E720", VA = "0x184A8F520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4A8F8E0", Offset = "0x4A8EAE0", VA = "0x184A8F8E0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4A8F670", Offset = "0x4A8E870", VA = "0x184A8F670")]
		public PFFLBGJGKEM(HDCJMEDCJMB<TKey, TValue> HEPGHFONHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4A8F0E0", Offset = "0x4A8E2E0", VA = "0x184A8F0E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4A8F120", Offset = "0x4A8E320", VA = "0x184A8F120", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4A8F290", Offset = "0x4A8E490", VA = "0x184A8F290", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class AJFHFOLCBAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HDCJMEDCJMB<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public GJPIFMKLPBG refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AJFHFOLCBAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F42FE0", Offset = "0x3F421E0", VA = "0x183F42FE0")]
		internal void MOADPENIGNJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Dictionary<TKey, GJPIFMKLPBG> OHLLJMEJAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly Func<TKey, TValue>? LIGBKGCGEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Action<TValue>? CEOINNBJKAC;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4018C70", Offset = "0x4017E70", VA = "0x184018C70")]
	public HDCJMEDCJMB(int OAEHNBCMBMJ = 0, [Optional] IEqualityComparer<TKey>? NGGEBGGCMGI, [Optional] Func<TKey, TValue>? PCKHHDEIIHI, [Optional] Action<TValue>? PCIMLIMNAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4017770", Offset = "0x4016970", VA = "0x184017770")]
	public GENINCKMOLO<TValue> BPLLHBCLFLF(TKey CPBLLDDDHEE, [Optional] Func<TKey, TValue>? KKOIFKJDPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4018970", Offset = "0x4017B70", VA = "0x184018970")]
	private void IMHGPOENCOG(TKey CPBLLDDDHEE, GJPIFMKLPBG PLEBIDENJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4018080", Offset = "0x4017280", VA = "0x184018080")]
	public void BPOAAOHNIAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x40173B0", Offset = "0x40165B0", VA = "0x1840173B0")]
	public PFFLBGJGKEM AKJNNDDNIOE()
	{
		return default(PFFLBGJGKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4018AA0", Offset = "0x4017CA0", VA = "0x184018AA0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4018AA0", Offset = "0x4017CA0", VA = "0x184018AA0", Slot = "5")]
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
