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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A12B80", Offset = "0x6A11180", VA = "0x186A12B80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CIBEEGBDBMG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	protected CIBEEGBDBMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KOFDCNCFNJJ<T> : CIBEEGBDBMG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct IKGNGCEKOCN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum DEDBKPHCEJP
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
		public DEDBKPHCEJP PBLNJHEPKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T OGLJLDNLGIJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int DCBHKFACDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool NPMOODIKICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool NHOMMLLHLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? DDODPMCGPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<IKGNGCEKOCN>? IEOBPAEIAKN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MLNIBJLJDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4213610", Offset = "0x4211C10", VA = "0x184213610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4213680", Offset = "0x4211C80", VA = "0x184213680")]
	protected KOFDCNCFNJJ(bool NHOMMLLHLNF, bool NPMOODIKICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4212C20", Offset = "0x4211220", VA = "0x184212C20")]
	protected bool BGOAMONHMCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4212CC0", Offset = "0x42112C0", VA = "0x184212CC0")]
	protected void FEABPMMKFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4213370", Offset = "0x4211970", VA = "0x184213370")]
	protected void PEOFIJOMIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A94C60", Offset = "0x2A93260", VA = "0x182A94C60")]
	private static void INMCPEHJGNP<U>(List<U>? DNOAHHGKGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4212FB0", Offset = "0x42115B0", VA = "0x184212FB0", Slot = "4")]
	public void MJFEDCBJOBF(T OGLJLDNLGIJ, bool AOPDJHHPDEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4212DE0", Offset = "0x42113E0", VA = "0x184212DE0", Slot = "5")]
	public void GAGDAFIMOPK(T OGLJLDNLGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x42131C0", Offset = "0x42117C0", VA = "0x1842131C0")]
	public void OAIAOCAHOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class BGECMLEGDCD : KOFDCNCFNJJ<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A10010", Offset = "0x6A0E610", VA = "0x186A10010")]
	public BGECMLEGDCD(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FE10", Offset = "0x6A0E410", VA = "0x186A0FE10")]
	public void NGOOLELHLHP()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FDB0", Offset = "0x6A0E3B0", VA = "0x186A0FDB0")]
	public static BGECMLEGDCD DABBFBOOFEB(BGECMLEGDCD LHGHPIKEDFN, Action OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FD50", Offset = "0x6A0E350", VA = "0x186A0FD50")]
	public static BGECMLEGDCD CPEBBFJPNJI(BGECMLEGDCD LHGHPIKEDFN, Action OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MMFDOBEFBOJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJFEDCBJOBF(Action<T> OGLJLDNLGIJ, bool AOPDJHHPDEE = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAGDAFIMOPK(Action<T> OGLJLDNLGIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GFLPBNMBKPD<T> : KOFDCNCFNJJ<Action<T>>, MMFDOBEFBOJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37E6370", Offset = "0x37E4970", VA = "0x1837E6370")]
	public GFLPBNMBKPD(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FCF0", Offset = "0x3D1E2F0", VA = "0x183D1FCF0")]
	public void NGOOLELHLHP(T LBKJPGMAINP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DD20", Offset = "0x3D1C320", VA = "0x183D1DD20")]
	public static GFLPBNMBKPD<T> DABBFBOOFEB(GFLPBNMBKPD<T> LHGHPIKEDFN, Action<T> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DC80", Offset = "0x3D1C280", VA = "0x183D1DC80")]
	public static GFLPBNMBKPD<T> CPEBBFJPNJI(GFLPBNMBKPD<T> LHGHPIKEDFN, Action<T> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LNDMHKFEDOL<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class MLMADGFCCJE<T, U> : KOFDCNCFNJJ<Action<T, U>>, LNDMHKFEDOL<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37E6370", Offset = "0x37E4970", VA = "0x1837E6370")]
	public MLMADGFCCJE(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x44DCAD0", Offset = "0x44DB0D0", VA = "0x1844DCAD0")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DD20", Offset = "0x3D1C320", VA = "0x183D1DD20")]
	public static MLMADGFCCJE<T, U> DABBFBOOFEB(MLMADGFCCJE<T, U> LHGHPIKEDFN, Action<T, U> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DC80", Offset = "0x3D1C280", VA = "0x183D1DC80")]
	public static MLMADGFCCJE<T, U> CPEBBFJPNJI(MLMADGFCCJE<T, U> LHGHPIKEDFN, Action<T, U> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NLMLNFBKPBM<T, U, V> : KOFDCNCFNJJ<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37E6370", Offset = "0x37E4970", VA = "0x1837E6370")]
	public NLMLNFBKPBM(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4577840", Offset = "0x4575E40", VA = "0x184577840")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF, V DCMJEJAEEHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DD20", Offset = "0x3D1C320", VA = "0x183D1DD20")]
	public static NLMLNFBKPBM<T, U, V> DABBFBOOFEB(NLMLNFBKPBM<T, U, V> LHGHPIKEDFN, Action<T, U, V> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DC80", Offset = "0x3D1C280", VA = "0x183D1DC80")]
	public static NLMLNFBKPBM<T, U, V> CPEBBFJPNJI(NLMLNFBKPBM<T, U, V> LHGHPIKEDFN, Action<T, U, V> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LPEHECEAFAA<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CLDFNPCBGJJ<T, U, V, W> : KOFDCNCFNJJ<Action<T, U, V, W>>, LPEHECEAFAA<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37E6370", Offset = "0x37E4970", VA = "0x1837E6370")]
	public CLDFNPCBGJJ(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x52418A0", Offset = "0x523FEA0", VA = "0x1852418A0")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF, V DCMJEJAEEHK, W FHNDBKCMHNE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DD20", Offset = "0x3D1C320", VA = "0x183D1DD20")]
	public static CLDFNPCBGJJ<T, U, V, W> DABBFBOOFEB(CLDFNPCBGJJ<T, U, V, W> LHGHPIKEDFN, Action<T, U, V, W> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DC80", Offset = "0x3D1C280", VA = "0x183D1DC80")]
	public static CLDFNPCBGJJ<T, U, V, W> CPEBBFJPNJI(CLDFNPCBGJJ<T, U, V, W> LHGHPIKEDFN, Action<T, U, V, W> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PANDAMDIBCM<T, U, V, W, X> : KOFDCNCFNJJ<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37E6370", Offset = "0x37E4970", VA = "0x1837E6370")]
	public PANDAMDIBCM(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x473E050", Offset = "0x473C650", VA = "0x18473E050")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF, V DCMJEJAEEHK, W FHNDBKCMHNE, X OOALEDCPNBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DD20", Offset = "0x3D1C320", VA = "0x183D1DD20")]
	public static PANDAMDIBCM<T, U, V, W, X> DABBFBOOFEB(PANDAMDIBCM<T, U, V, W, X> LHGHPIKEDFN, Action<T, U, V, W, X> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DC80", Offset = "0x3D1C280", VA = "0x183D1DC80")]
	public static PANDAMDIBCM<T, U, V, W, X> CPEBBFJPNJI(PANDAMDIBCM<T, U, V, W, X> LHGHPIKEDFN, Action<T, U, V, W, X> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NPCLPKJKFHH<T, U, V, W, X, Y> : KOFDCNCFNJJ<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37E6370", Offset = "0x37E4970", VA = "0x1837E6370")]
	public NPCLPKJKFHH(bool NHOMMLLHLNF = false, bool NPMOODIKICM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4587910", Offset = "0x4585F10", VA = "0x184587910")]
	public void NGOOLELHLHP(T LBKJPGMAINP, U KPCGDJJONPF, V DCMJEJAEEHK, W FHNDBKCMHNE, X OOALEDCPNBJ, Y HDFOCKKCOOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DD20", Offset = "0x3D1C320", VA = "0x183D1DD20")]
	public static NPCLPKJKFHH<T, U, V, W, X, Y> DABBFBOOFEB(NPCLPKJKFHH<T, U, V, W, X, Y> LHGHPIKEDFN, Action<T, U, V, W, X, Y> OGLJLDNLGIJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D1DC80", Offset = "0x3D1C280", VA = "0x183D1DC80")]
	public static NPCLPKJKFHH<T, U, V, W, X, Y> CPEBBFJPNJI(NPCLPKJKFHH<T, U, V, W, X, Y> LHGHPIKEDFN, Action<T, U, V, W, X, Y> OGLJLDNLGIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AEBNPKNJGIJ<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FMHCEMJFILO<TKey, TVal> BALDNHIKALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> OIKHGLNGGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FMHCEMJFILO<TKey, TVal>.FIAPIJMBIFO? OEIKNGELFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int HMMCJLOPMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FMHCEMJFILO<TKey, TVal>.LHIDMCLNDKJ? KJIMOENDFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int EPFAGOFEFOC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int IHEILCDDDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFAF0", Offset = "0x3CCE0F0", VA = "0x183CCFAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BDJKBNBIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x865830", Offset = "0x863E30", VA = "0x180865830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0EB0", Offset = "0x3CCF4B0", VA = "0x183CD0EB0")]
	public AEBNPKNJGIJ(int HMMCJLOPMAB, [Optional] FMHCEMJFILO<TKey, TVal>.LHIDMCLNDKJ? KJIMOENDFEO, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FMHCEMJFILO<TKey, TVal>.FIAPIJMBIFO? OEIKNGELFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CD00D0", Offset = "0x3CCE6D0", VA = "0x183CD00D0")]
	public void DANFKACECPB(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, bool LEJFFACJNFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3CCFC80", Offset = "0x3CCE280", VA = "0x183CCFC80")]
	public bool BCCLAFGNCOP(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0D00", Offset = "0x3CCF300", VA = "0x183CD0D00")]
	public bool MMCLNKMOKEF(TKey LAGEFHPKEIC, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3CCFDF0", Offset = "0x3CCE3F0", VA = "0x183CCFDF0")]
	private void BFBPLCJFCEB(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3CD08B0", Offset = "0x3CCEEB0", VA = "0x183CD08B0")]
	public bool KCBMGCHNHLC(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, bool LEJFFACJNFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0E00", Offset = "0x3CCF400", VA = "0x183CD0E00")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0320", Offset = "0x3CCE920", VA = "0x183CD0320")]
	private void EMPNOKCGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0BB0", Offset = "0x3CCF1B0", VA = "0x183CD0BB0")]
	private bool MLJCMENCKND(TKey BHEIPBKEDLG, PFILCAPGHIC CLPBFEAPBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0A80", Offset = "0x3CCF080", VA = "0x183CD0A80")]
	private void KKBLLMBBKEN(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, PFILCAPGHIC CLPBFEAPBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CCFB50", Offset = "0x3CCE150", VA = "0x183CCFB50")]
	private void AKNOHBLJEHO(TKey BHEIPBKEDLG, TVal LECBAKCNNCK, PFILCAPGHIC CLPBFEAPBCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ABIAJLLBGGH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DHAABJGHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MEAEDBMMGIE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public ABIAJLLBGGH(Action DPHFDCIPJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F040", Offset = "0x6A0D640", VA = "0x186A0F040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29248C0", Offset = "0x2922EC0", VA = "0x1829248C0")]
	public static BCBDLBGONLF<T> GIGNPOIHFIA<T>(T CBAEIEAPLIH, Action DPHFDCIPJAD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BCBDLBGONLF<T> : ABIAJLLBGGH where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B0E0", Offset = "0x4E496E0", VA = "0x184E4B0E0")]
	public BCBDLBGONLF(T CBAEIEAPLIH, Action DPHFDCIPJAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class EFIOHGGEHFL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MEMGCDILONA<T>? FBDPNCDKJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> GPKEKBGILBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool MEAEDBMMGIE;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EFIOHGGEHFL<T> BHJAMJDAEMH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> IEJLPCIEMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x37E8F30", Offset = "0x37E7530", VA = "0x1837E8F30")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x37E94F0", Offset = "0x37E7AF0", VA = "0x1837E94F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DFLAHLKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x37E91F0", Offset = "0x37E77F0", VA = "0x1837E91F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37E9880", Offset = "0x37E7E80", VA = "0x1837E9880")]
	public EFIOHGGEHFL(MEMGCDILONA<T> KDLEODPAOCJ, MEMGCDILONA<T> JOLHDIMIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37E9980", Offset = "0x37E7F80", VA = "0x1837E9980")]
	public EFIOHGGEHFL(MEMGCDILONA<T> KDLEODPAOCJ, int GEIGDPFELPO, MEMGCDILONA<T> JOLHDIMIKNH, int FJLMFNONBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37E97D0", Offset = "0x37E7DD0", VA = "0x1837E97D0")]
	private EFIOHGGEHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x37E9160", Offset = "0x37E7760", VA = "0x1837E9160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37E9370", Offset = "0x37E7970", VA = "0x1837E9370")]
	public T[] JNKPEPBDKEI()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37E9030", Offset = "0x37E7630", VA = "0x1837E9030")]
	public static ReadOnlySequence<T> CPPJIHNILOM(EFIOHGGEHFL<T>? LEJKAHCECBB)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct AJJOLPGOGOH : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct NCCDDLMPFHN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0")]
		public static NCCDDLMPFHN HCLFOFEHDJP()
		{
			return default(NCCDDLMPFHN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31A27A0", Offset = "0x31A0DA0", VA = "0x1831A27A0")]
	public static string? FPJNKIGMBBG<T>([Optional] string? BGOMCHAPJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x31A2820", Offset = "0x31A0E20", VA = "0x1831A2820")]
	public static string? PIENIEOGKAK<T>([Optional] string? HLJIEIMNHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0")]
	public static AJJOLPGOGOH ICICDJFMCPH(string BGOMCHAPJDJ, string? HLJIEIMNHBC)
	{
		return default(AJJOLPGOGOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HGBNDFBPIAF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool GPOOCBFDCDL(string POECJPJIGAG, HGBNDFBPIAF KHACKPBNIOJ);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LJLOAOFANGD<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LJLOAOFANGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x42C8820", Offset = "0x42C6E20", VA = "0x1842C8820")]
		internal void DCLPIHKJGHE(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int HEJFAMNFDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string FOPNLIFBPJF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A116E0", Offset = "0x6A0FCE0", VA = "0x186A116E0")]
	public static Dictionary<string, HGBNDFBPIAF> DLDAMGPOKNN(Type LDPJJJAKFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B088D0", Offset = "0x2B06ED0", VA = "0x182B088D0")]
	public static Dictionary<string, HGBNDFBPIAF> DLDAMGPOKNN<T>(Type LDPJJJAKFIJ, IReadOnlyDictionary<T, string> PNEAGCLGIPI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B09110", Offset = "0x2B07710", VA = "0x182B09110")]
	public static Dictionary<string, HGBNDFBPIAF> JJCKBJLDMIE<T>(List<T> DFAONOBAFJC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A11BD0", Offset = "0x6A101D0", VA = "0x186A11BD0")]
	public static Dictionary<string, HGBNDFBPIAF> MMHDKGIOKMC(Type LDPJJJAKFIJ, GPOOCBFDCDL BCMOMEKAMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A11A10", Offset = "0x6A10010", VA = "0x186A11A10")]
	public static Dictionary<int, string> DODILNLINAA(Dictionary<string, HGBNDFBPIAF> CHNGFEKJHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class FNFMNGCMHCP : PFPHCNGMPPA
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool GLGJKPGGOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? HBHOCJKGGEH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual PFPHCNGMPPA? AOHMEHBPAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A10830", Offset = "0x6A0EE30", VA = "0x186A10830")]
	protected FNFMNGCMHCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string MKLJNMAODHM();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A10280", Offset = "0x6A0E880", VA = "0x186A10280", Slot = "8")]
	public virtual string IDAPNHHOMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A10300", Offset = "0x6A0E900", VA = "0x186A10300", Slot = "9")]
	public void MDIOIACOKHP(StringBuilder FDCDLEKJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A10180", Offset = "0x6A0E780", VA = "0x186A10180", Slot = "10")]
	public void GAJFAEEDINH(StringBuilder FDCDLEKJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A10710", Offset = "0x6A0ED10", VA = "0x186A10710", Slot = "11")]
	public void OOCFADFICFG(StringBuilder FDCDLEKJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A105B0", Offset = "0x6A0EBB0", VA = "0x186A105B0", Slot = "12")]
	public void MECPPGIPLBF(StringBuilder FDCDLEKJNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A101E0", Offset = "0x6A0E7E0", VA = "0x186A101E0")]
	public static void GKCMEMJCFBH(StringBuilder FDCDLEKJNHH, string GCLKHFDGKHA, string BFKDNAGJNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5BFA500", Offset = "0x5BF8B00", VA = "0x185BFA500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LLNBNMCCIGN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A12570", Offset = "0x6A10B70", VA = "0x186A12570")]
	public LLNBNMCCIGN(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OJADFOHOIFM<TErr> : LLNBNMCCIGN where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr OIGIKKOKENE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4676710", Offset = "0x4674D10", VA = "0x184676710")]
	private OJADFOHOIFM([In] TErr DBJNGIIJNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4676630", Offset = "0x4674C30", VA = "0x184676630")]
	public static OJADFOHOIFM<TErr> HCLFOFEHDJP([In] TErr DBJNGIIJNDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PFPHCNGMPPA
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IDAPNHHOMNC();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MKLJNMAODHM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FKEPHGIKEFN<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	TOptions BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LEJHKPOFPCM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string DMEEEGDNKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MEMGCDILONA<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static MEMGCDILONA<T>? KAMNPBOKDBF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static object PBELDLDNHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IMemoryOwner<T>? IDFELODNBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool MEAEDBMMGIE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9E9190", Offset = "0x9E7790", VA = "0x1809E9190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x44C4790", Offset = "0x44C2D90", VA = "0x1844C4790")]
	private static MEMGCDILONA<T> GCLPKNPDHCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x44C55A0", Offset = "0x44C3BA0", VA = "0x1844C55A0")]
	private static void IIMEBHFDDPO(MEMGCDILONA<T> BFNHIAMOFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x383C380", Offset = "0x383A980", VA = "0x18383C380")]
	private MEMGCDILONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x44C4E80", Offset = "0x44C3480", VA = "0x1844C4E80")]
	public static MEMGCDILONA<T> GIGNPOIHFIA(ReadOnlyMemory<T> KKGILNKDEBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x44C4C60", Offset = "0x44C3260", VA = "0x1844C4C60")]
	public static MEMGCDILONA<T> GIGNPOIHFIA(IMemoryOwner<T> DLECHHFKLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x44C5CB0", Offset = "0x44C42B0", VA = "0x1844C5CB0")]
	public static void OLMHAJPOEMA(MEMGCDILONA<T> KDLEODPAOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x44C4500", Offset = "0x44C2B00", VA = "0x1844C4500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x44C5B90", Offset = "0x44C4190", VA = "0x1844C5B90")]
	public MEMGCDILONA<T> LFJDNNPAPPK(IMemoryOwner<T> DLECHHFKLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x44C53A0", Offset = "0x44C39A0", VA = "0x1844C53A0")]
	private void HGNLNDANBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x44C5240", Offset = "0x44C3840", VA = "0x1844C5240")]
	private MEMGCDILONA<T> GPDEMOPAMCM(MEMGCDILONA<T> BFNHIAMOFIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DPMFOCJPCKE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A10070", Offset = "0x6A0E670", VA = "0x186A10070")]
	public DPMFOCJPCKE(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NLKOFMLNBKP<TOk> : DPMFOCJPCKE where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly TOk JMFJMAHDDOM;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4575610", Offset = "0x4573C10", VA = "0x184575610")]
	private NLKOFMLNBKP([In] TOk AEDNHEBBEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C0C0", Offset = "0x3E9A6C0", VA = "0x183E9C0C0")]
	public static NLKOFMLNBKP<TOk> HCLFOFEHDJP([In] TOk AEDNHEBBEIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AILDPMCFPMB : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly ReadOnlySequence<byte> GPKEKBGILBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private SequencePosition BNDIJLNGDOL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool EAECKJBAICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override bool PCJONPNOBND
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override bool LJMCBCALEKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public override long DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A0FAE0", Offset = "0x6A0E0E0", VA = "0x186A0FAE0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override long KBHBDHIEKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A0FB40", Offset = "0x6A0E140", VA = "0x186A0FB40", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A0FC10", Offset = "0x6A0E210", VA = "0x186A0FC10", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FA10", Offset = "0x6A0E010", VA = "0x186A0FA10")]
	public AILDPMCFPMB(ReadOnlySequence<byte> LEJKAHCECBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F5C0", Offset = "0x6A0DBC0", VA = "0x186A0F5C0", Slot = "33")]
	public override long Seek(long ANNLKNNLIGI, SeekOrigin AKJEKBLKOGB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F120", Offset = "0x6A0D720", VA = "0x186A0F120", Slot = "35")]
	public override int Read(byte[] EPBKIHMMALG, int ANNLKNNLIGI, int JPBPNOCHNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F950", Offset = "0x6A0DF50", VA = "0x186A0F950", Slot = "34")]
	public override void SetLength(long CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F9B0", Offset = "0x6A0DFB0", VA = "0x186A0F9B0", Slot = "38")]
	public override void Write(byte[] EPBKIHMMALG, int ANNLKNNLIGI, int JPBPNOCHNLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct PIJKHLBEMKP<TOk, TErr> : IEquatable<PIJKHLBEMKP<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly EqualityComparer<TErr> FLGKEDNBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TErr OIGIKKOKENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TOk JMFJMAHDDOM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HNHHNGIICHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x47591B0", Offset = "0x47577B0", VA = "0x1847591B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool INHDJHENBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x475A200", Offset = "0x4758800", VA = "0x18475A200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4761A70", Offset = "0x4760070", VA = "0x184761A70")]
	internal PIJKHLBEMKP([In] TErr DBJNGIIJNDD, [In] TOk AEDNHEBBEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x47598A0", Offset = "0x4757EA0", VA = "0x1847598A0")]
	public static PIJKHLBEMKP<TOk, TErr> CDLOABFODLB([In] TErr DBJNGIIJNDD)
	{
		return default(PIJKHLBEMKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x475AD00", Offset = "0x4759300", VA = "0x18475AD00")]
	public static PIJKHLBEMKP<TOk, TErr> EJKHGMKHOEK([In] TOk AEDNHEBBEIN)
	{
		return default(PIJKHLBEMKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEF50", Offset = "0x2BAD550", VA = "0x182BAEF50")]
	public PIJKHLBEMKP<TOk?, UErr?> KKOHDJDGHDO<UErr>()
	{
		return default(PIJKHLBEMKP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD9C0", Offset = "0x2BABFC0", VA = "0x182BAD9C0")]
	public PIJKHLBEMKP<UOk?, TErr?> ADBBEJGBHHC<UOk>()
	{
		return default(PIJKHLBEMKP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE840", Offset = "0x2BACE40", VA = "0x182BAE840")]
	public PIJKHLBEMKP<UOk?, TErr?> CACEPGJCPAG<UOk>()
	{
		return default(PIJKHLBEMKP<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2BAEE30", Offset = "0x2BAD430", VA = "0x182BAEE30")]
	public PIJKHLBEMKP<TOk?, UErr?> HILDIFPCEAA<UErr>()
	{
		return default(PIJKHLBEMKP<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x475E8D0", Offset = "0x475CED0", VA = "0x18475E8D0")]
	public PIJKHLBEMKP<HNKFFDNJINI, TErr> KCPHKICLFIF()
	{
		return default(PIJKHLBEMKP<HNKFFDNJINI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x475D630", Offset = "0x475BC30", VA = "0x18475D630")]
	public static bool JEKPEIKHIPM([In] PIJKHLBEMKP<TOk, TErr> KKEPMPAJLEA, [In] PIJKHLBEMKP<TOk, TErr> HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x475B670", Offset = "0x4759C70", VA = "0x18475B670", Slot = "4")]
	public bool Equals(PIJKHLBEMKP<TOk, TErr> LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x475B330", Offset = "0x4759930", VA = "0x18475B330", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x475C180", Offset = "0x475A780", VA = "0x18475C180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4760920", Offset = "0x475EF20", VA = "0x184760920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class OBJOBOKJNDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KDDCGPIEOJM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Task<PIJKHLBEMKP<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<PIJKHLBEMKP<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x41D45A0", Offset = "0x41D2BA0", VA = "0x1841D45A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x41D4C20", Offset = "0x41D3220", VA = "0x1841D4C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2C91450", Offset = "0x2C8FA50", VA = "0x182C91450")]
	public static PIJKHLBEMKP<TOk?, TErr?> JMFJMAHDDOM<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [In] TOk AEDNHEBBEIN)
	{
		return default(PIJKHLBEMKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2C91500", Offset = "0x2C8FB00", VA = "0x182C91500")]
	public static PIJKHLBEMKP<HNKFFDNJINI, TErr?> JMFJMAHDDOM<TErr>([In] this PIJKHLBEMKP<HNKFFDNJINI, TErr> OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<HNKFFDNJINI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2C91450", Offset = "0x2C8FA50", VA = "0x182C91450")]
	public static PIJKHLBEMKP<TOk?, TErr?> OIGIKKOKENE<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [In] TErr DBJNGIIJNDD)
	{
		return default(PIJKHLBEMKP<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C91180", Offset = "0x2C8F780", VA = "0x182C91180")]
	public static TOk? GFKPGNBAEEK<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C918D0", Offset = "0x2C8FED0", VA = "0x182C918D0")]
	[AsyncStateMachine(typeof(KDDCGPIEOJM<, >))]
	public static Task<TOk?>? MBNKCOLLGNG<TOk, TErr>(this Task<PIJKHLBEMKP<TOk, TErr>> OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2C923B0", Offset = "0x2C909B0", VA = "0x182C923B0")]
	public static TErr? MKHLLDCHNPM<TErr, TOk>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2C8FD00", Offset = "0x2C8E300", VA = "0x182C8FD00")]
	public static bool COOOHOJNPIN<TOk, TErr, UErr, UOk>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out] PIJKHLBEMKP<UOk, UErr> KMMBFOLKINI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2C92670", Offset = "0x2C90C70", VA = "0x182C92670")]
	public static bool NDBFBJGBPEG<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F6D0", Offset = "0x2C8DCD0", VA = "0x182C8F6D0")]
	public static bool ALHMFBPIHKB<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TErr DBJNGIIJNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2C91750", Offset = "0x2C8FD50", VA = "0x182C91750")]
	public static bool JOEPMLFFJGC<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN, [Out][NotNullWhen(false)] TErr DBJNGIIJNDD) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2C90DA0", Offset = "0x2C8F3A0", VA = "0x182C90DA0")]
	public static bool DIHIBNDOJCE<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN, [Out] PIJKHLBEMKP<TOk, TErr> KMMBFOLKINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2C8FE30", Offset = "0x2C8E430", VA = "0x182C8FE30")]
	public static bool COOOHOJNPIN<TOk, TErr, UErr, UOk>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN, [Out] PIJKHLBEMKP<UOk, UErr> KMMBFOLKINI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F320", Offset = "0x2C8D920", VA = "0x182C8F320")]
	public static bool AKFOLJNOKOK<TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [Out][NotNullWhen(true)] TOk AEDNHEBBEIN, [Out] PIJKHLBEMKP<HNKFFDNJINI, TErr> KMMBFOLKINI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C91DE0", Offset = "0x2C903E0", VA = "0x182C91DE0")]
	public static PIJKHLBEMKP<UOk, UErr> MKCJMCHDHKH<UOk, UErr, TOk, TErr>([In] this PIJKHLBEMKP<TOk, TErr> OLDDCPCBGIL, [In] PIJKHLBEMKP<UOk, UErr> JLMICGLMAKN) where TOk : UOk where TErr : UErr
	{
		return default(PIJKHLBEMKP<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F810", Offset = "0x2C8DE10", VA = "0x182C8F810")]
	public static PIJKHLBEMKP<TOk?[]?, TErr?> BIPMOADMDKF<TOk, TErr>(this IEnumerable<PIJKHLBEMKP<TOk, TErr>> OLDDCPCBGIL)
	{
		return default(PIJKHLBEMKP<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MEJFDNCHGOE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F440", Offset = "0x2A9DA40", VA = "0x182A9F440")]
	public static PIJKHLBEMKP<TOk, T> JMFJMAHDDOM<TOk>([In] TOk AEDNHEBBEIN) where TOk : notnull
	{
		return default(PIJKHLBEMKP<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x44C3DE0", Offset = "0x44C23E0", VA = "0x1844C3DE0")]
	public static PIJKHLBEMKP<HNKFFDNJINI, T> JMFJMAHDDOM()
	{
		return default(PIJKHLBEMKP<HNKFFDNJINI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A9F3B0", Offset = "0x2A9D9B0", VA = "0x182A9F3B0")]
	public static PIJKHLBEMKP<T, TErr> OIGIKKOKENE<TErr>([In] TErr DBJNGIIJNDD) where TErr : notnull
	{
		return default(PIJKHLBEMKP<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public sealed class EJLMCKJBBPD<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private readonly struct DBLLGFMCPFL : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly EJLMCKJBBPD<T> LICEJNGDJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly int KGPHKCAEGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly bool CMMNBICHLCO;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3920", Offset = "0x1EA1F20", VA = "0x181EA3920")]
		public DBLLGFMCPFL(EJLMCKJBBPD<T> LIGKCFOOPNO, int BNCNFIFKBEF, bool FNKHKAPNONC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x57CD5D0", Offset = "0x57CBBD0", VA = "0x1857CD5D0")]
		public EJLMCKJBBPD<T>.KOJDKHIMKFN AKHPNFMFJMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x57CD6D0", Offset = "0x57CBCD0", VA = "0x1857CD6D0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x57CD6D0", Offset = "0x57CBCD0", VA = "0x1857CD6D0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class KOJDKHIMKFN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly EJLMCKJBBPD<T> LICEJNGDJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly int AIKEMHHKJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int ILBACOBMBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly bool CMMNBICHLCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool MIOAGFNKGFB;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x4213D40", Offset = "0x4212340", VA = "0x184213D40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4213F50", Offset = "0x4212550", VA = "0x184213F50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x4214050", Offset = "0x4212650", VA = "0x184214050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x42145C0", Offset = "0x4212BC0", VA = "0x1842145C0")]
		public KOJDKHIMKFN(EJLMCKJBBPD<T> LIGKCFOOPNO, int BNCNFIFKBEF, bool FNKHKAPNONC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4213E40", Offset = "0x4212440", VA = "0x184213E40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4213EE0", Offset = "0x42124E0", VA = "0x184213EE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DBAHBHOLKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DBAHBHOLKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x57CB890", Offset = "0x57C9E90", VA = "0x1857CB890")]
		internal T KHJIJLCBBPO(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly T[] GLPHGNLCKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int ILBACOBMBOH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int DIJBJJPECAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x37FA6F0", Offset = "0x37F8CF0", VA = "0x1837FA6F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T NKNICMABPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x37FA4F0", Offset = "0x37F8AF0", VA = "0x1837FA4F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T AOODDNLKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x37FA780", Offset = "0x37F8D80", VA = "0x1837FA780")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x37FA610", Offset = "0x37F8C10", VA = "0x1837FA610")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x191E5F0", Offset = "0x191CBF0", VA = "0x18191E5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x116BA10", Offset = "0x116A010", VA = "0x18116BA10")]
	private static int INDADLDEPLA(int LLPJHIPCNFD, int DOIKAIEGGLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x37FAB00", Offset = "0x37F9100", VA = "0x1837FAB00")]
	public EJLMCKJBBPD(int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x37FA890", Offset = "0x37F8E90", VA = "0x1837FA890")]
	public EJLMCKJBBPD(int ENCFHCJIMBE, Func<T> MPNLFCFIOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x37FAC30", Offset = "0x37F9230", VA = "0x1837FAC30")]
	public EJLMCKJBBPD(T[] ONEIHMPFJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x37FA750", Offset = "0x37F8D50", VA = "0x1837FA750")]
	public void LHOLGILJODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x37FA7C0", Offset = "0x37F8DC0", VA = "0x1837FA7C0")]
	public IEnumerable<T> PIADOEHDGNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x37FA450", Offset = "0x37F8A50", VA = "0x1837FA450")]
	public EJLMCKJBBPD<T>.KOJDKHIMKFN AKHPNFMFJMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x37C5DE0", Offset = "0x37C43E0", VA = "0x1837C5DE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37C5DE0", Offset = "0x37C43E0", VA = "0x1837C5DE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PAIHLMLAIMH
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8EF0", Offset = "0x2CA74F0", VA = "0x182CA8EF0")]
	public static EJLMCKJBBPD<T> HCLFOFEHDJP<T>(int ENCFHCJIMBE, Func<T> MPNLFCFIOHJ) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x1FA84C0", Offset = "0x1FA6AC0", VA = "0x181FA84C0")]
		public RRColor(float LJNBPEFJOFE, float KPEPPJDBMBI, float HEOHCJKCOLM, float FAGKOOGCGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A12C00", Offset = "0x6A11200", VA = "0x186A12C00", Slot = "4")]
		public bool Equals(RRColor LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A12C80", Offset = "0x6A11280", VA = "0x186A12C80", Slot = "0")]
		public override bool Equals(object LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A12D80", Offset = "0x6A11380", VA = "0x186A12D80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A12E00", Offset = "0x6A11400", VA = "0x186A12E00", Slot = "5")]
		public string ToString(string JFOBPJMAIKI, IFormatProvider JANJHBNFPIB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class KLKPDHKDKII<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct KIFLODGFIOF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly KLKPDHKDKII<T> GINDCHJNDMN;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T BLBBIKKJHJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4202830", Offset = "0x4200E30", VA = "0x184202830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4202800", Offset = "0x4200E00", VA = "0x184202800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
		public KIFLODGFIOF(KLKPDHKDKII<T> GINDCHJNDMN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct PKIOBLLLAGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<KIFLODGFIOF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public KLKPDHKDKII<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4768B80", Offset = "0x4767180", VA = "0x184768B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E9DFE0", Offset = "0x3E9C5E0", VA = "0x183E9DFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly SemaphoreSlim GOBFLAEEDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T HHMLOJPFGAO;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x420EC70", Offset = "0x420D270", VA = "0x18420EC70")]
	public KLKPDHKDKII([In] T HHMLOJPFGAO, int JGPAJEHOAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x420EB80", Offset = "0x420D180", VA = "0x18420EB80")]
	public KLKPDHKDKII([In] T HHMLOJPFGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x420E660", Offset = "0x420CC60", VA = "0x18420E660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x420E620", Offset = "0x420CC20", VA = "0x18420E620")]
	public KIFLODGFIOF BDENGGEBLEB()
	{
		return default(KIFLODGFIOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x420EA50", Offset = "0x420D050", VA = "0x18420EA50")]
	[AsyncStateMachine(typeof(KLKPDHKDKII<>.PKIOBLLLAGF))]
	public Task<KLKPDHKDKII<T>.KIFLODGFIOF> PFGHGGHILCN(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x420E6A0", Offset = "0x420CCA0", VA = "0x18420E6A0")]
	public void FHKCCBGJELG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LAKKLIIFOPH
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A12500", Offset = "0x6A10B00", VA = "0x186A12500")]
	public static KLKPDHKDKII<HNKFFDNJINI> HCLFOFEHDJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x291FA00", Offset = "0x291E000", VA = "0x18291FA00")]
	public static KLKPDHKDKII<T> HCLFOFEHDJP<T>([In] T HHMLOJPFGAO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class EJPHOJLNABO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct PLEJNLGJDEH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly EJPHOJLNABO<T> MLIKNBGJCIJ;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T BLBBIKKJHJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF400", Offset = "0x3DADA00", VA = "0x183DAF400")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x476B870", Offset = "0x4769E70", VA = "0x18476B870", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
		internal PLEJNLGJDEH(EJPHOJLNABO<T> GINDCHJNDMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct HAPDLLGIAIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly EJPHOJLNABO<T> MLIKNBGJCIJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T BLBBIKKJHJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF400", Offset = "0x3DADA00", VA = "0x183DAF400")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3DAF310", Offset = "0x3DAD910", VA = "0x183DAF310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
		internal HAPDLLGIAIN(EJPHOJLNABO<T> GINDCHJNDMN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ICFOPHOKJOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<HAPDLLGIAIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EJPHOJLNABO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private KLKPDHKDKII<HNKFFDNJINI>.KIFLODGFIOF <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<KLKPDHKDKII<HNKFFDNJINI>.KIFLODGFIOF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E9DAA0", Offset = "0x3E9C0A0", VA = "0x183E9DAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E9DFE0", Offset = "0x3E9C5E0", VA = "0x183E9DFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KLKPDHKDKII<int> LBJPEHHDBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly KLKPDHKDKII<HNKFFDNJINI> NEPHBAPKEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly KLKPDHKDKII<HNKFFDNJINI> ANNAFKEMNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private T ALJGHBIIELD;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x38311D0", Offset = "0x382F7D0", VA = "0x1838311D0")]
	internal EJPHOJLNABO(KLKPDHKDKII<int> KLGAADGHFPA, KLKPDHKDKII<HNKFFDNJINI> EBBIBMMBNMB, KLKPDHKDKII<HNKFFDNJINI> DHABPAFOLHE, [In] T HHMLOJPFGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x38307F0", Offset = "0x382EDF0", VA = "0x1838307F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3830A30", Offset = "0x382F030", VA = "0x183830A30")]
	public PLEJNLGJDEH JPBHPDIMEHI()
	{
		return default(PLEJNLGJDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3830600", Offset = "0x382EC00", VA = "0x183830600")]
	public HAPDLLGIAIN BHGJGDNIHGJ()
	{
		return default(HAPDLLGIAIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3831010", Offset = "0x382F610", VA = "0x183831010")]
	[AsyncStateMachine(typeof(EJPHOJLNABO<>.ICFOPHOKJOM))]
	public Task<EJPHOJLNABO<T>.HAPDLLGIAIN> KJDOKHHEPKA(CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class LNACHJHAKBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A125D0", Offset = "0x6A10BD0", VA = "0x186A125D0")]
	public static EJPHOJLNABO<HNKFFDNJINI> HCLFOFEHDJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7DA0", Offset = "0x2BE63A0", VA = "0x182BE7DA0")]
	public static EJPHOJLNABO<T> HCLFOFEHDJP<T>([In] T HHMLOJPFGAO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BCHLFGKJAEG<TData> : FNFMNGCMHCP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string CANNEAPCBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly TData MEEFJAOGPIF;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E4C140", Offset = "0x4E4A740", VA = "0x184E4C140")]
	internal BCHLFGKJAEG(string NFOHONOFFAP, [In] TData FHNKDHIILBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GOHMJHMILKC
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A11660", Offset = "0x6A0FC60", VA = "0x186A11660")]
	public static BCHLFGKJAEG<HNKFFDNJINI> HCLFOFEHDJP(string NFOHONOFFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29248C0", Offset = "0x2922EC0", VA = "0x1829248C0")]
	public static BCHLFGKJAEG<TData> HCLFOFEHDJP<TData>(string NFOHONOFFAP, [In] TData FHNKDHIILBL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KEMAGBLCDGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<object, float> OLGJECBHAKN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float MDNKPNEAHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE20", Offset = "0x8CC420", VA = "0x1808CDE20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5750", Offset = "0xAB3D50", VA = "0x180AB5750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A123B0", Offset = "0x6A109B0", VA = "0x186A123B0")]
	public void PBGBCGOCNGM(float CBAEIEAPLIH, object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A122F0", Offset = "0x6A108F0", VA = "0x186A122F0")]
	public void JHPDIDIEFLE(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A12360", Offset = "0x6A10960", VA = "0x186A12360")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A121C0", Offset = "0x6A107C0", VA = "0x186A121C0")]
	private void GKFIOCGAJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A12420", Offset = "0x6A10A20", VA = "0x186A12420")]
	public KEMAGBLCDGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JLMDKADECPA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class MNPGDNPLOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public MNPGDNPLOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x44E5A10", Offset = "0x44E4010", VA = "0x1844E5A10")]
		internal int BPCEAPBELGJ(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T>? PFNGNOHGJOF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IReadOnlyCollection<T> NPMEGEINAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4100B40", Offset = "0x40FF140", VA = "0x184100B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OIAGGLCOINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4100790", Offset = "0x40FED90", VA = "0x184100790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x865080", Offset = "0x863680", VA = "0x180865080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4100960", Offset = "0x40FEF60", VA = "0x184100960")]
	public bool MJFEDCBJOBF(T OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x41007E0", Offset = "0x40FEDE0", VA = "0x1841007E0")]
	public bool GAGDAFIMOPK(T OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4100C70", Offset = "0x40FF270", VA = "0x184100C70")]
	public bool PMELAKIMKGE(T OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4100B80", Offset = "0x40FF180", VA = "0x184100B80")]
	public void PMEFIDEFMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4100CC0", Offset = "0x40FF2C0", VA = "0x184100CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public JLMDKADECPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class KHCGFHKKCLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly string HDPINCHBJIO;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public KHCGFHKKCLN(string HDPINCHBJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A124B0", Offset = "0x6A10AB0", VA = "0x186A124B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class GENPGFDOLOA
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FGGMMBELEKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FGGMMBELEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A100D0", Offset = "0x6A0E6D0", VA = "0x186A100D0")]
		internal int BPCEAPBELGJ(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private HashSet<object>? PFNGNOHGJOF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyCollection<object> NPMEGEINAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A10A30", Offset = "0x6A0F030", VA = "0x186A10A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool OIAGGLCOINL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A108A0", Offset = "0x6A0EEA0", VA = "0x186A108A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x865080", Offset = "0x863680", VA = "0x180865080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A10950", Offset = "0x6A0EF50", VA = "0x186A10950")]
	public bool MJFEDCBJOBF(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A108B0", Offset = "0x6A0EEB0", VA = "0x186A108B0")]
	public bool GAGDAFIMOPK(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A10B30", Offset = "0x6A0F130", VA = "0x186A10B30")]
	public bool PMELAKIMKGE(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A10AC0", Offset = "0x6A0F0C0", VA = "0x186A10AC0")]
	public void PMEFIDEFMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A10B90", Offset = "0x6A0F190", VA = "0x186A10B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public GENPGFDOLOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GPBEEAFKGJF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct NDGLJCCNLMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float AOAAHHMBLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public T BLBBIKKJHJE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Dictionary<object, NDGLJCCNLMC> OLGJECBHAKN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public virtual T CDPEEHEGKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1077520", Offset = "0x1075B20", VA = "0x181077520", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1076AF0", Offset = "0x10750F0", VA = "0x181076AF0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public object? NEDEMIOEJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x865800", Offset = "0x863E00", VA = "0x180865800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OFLLKLACFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DDC0", Offset = "0x3D7C3C0", VA = "0x183D7DDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3D80190", Offset = "0x3D7E790", VA = "0x183D80190")]
	public bool PBGBCGOCNGM(T CBAEIEAPLIH, object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3C80430", Offset = "0x3C7EA30", VA = "0x183C80430")]
	public bool JHPDIDIEFLE(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3C62A60", Offset = "0x3C61060", VA = "0x183C62A60")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DF40", Offset = "0x3D7C540", VA = "0x183D7DF40")]
	public bool MMCLNKMOKEF(object OEDJKICDDGA, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3D7ECB0", Offset = "0x3D7D2B0", VA = "0x183D7ECB0")]
	[DMMOHDONLFE("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OHFJJEKHMLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C80CC0", Offset = "0x3C7F2C0", VA = "0x183C80CC0")]
	public GPBEEAFKGJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class EDKHENFJMJA<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private List<WeakReference<T>>? PFNGNOHGJOF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OIAGGLCOINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x37E3D60", Offset = "0x37E2360", VA = "0x1837E3D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x37E42D0", Offset = "0x37E28D0", VA = "0x1837E42D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x37E4040", Offset = "0x37E2640", VA = "0x1837E4040")]
	public void MJFEDCBJOBF(T OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x37E3E90", Offset = "0x37E2490", VA = "0x1837E3E90")]
	public void GAGDAFIMOPK(T OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x37E4480", Offset = "0x37E2A80", VA = "0x1837E4480")]
	public void PMEFIDEFMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x37E44D0", Offset = "0x37E2AD0", VA = "0x1837E44D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public EDKHENFJMJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class MNCGBCHEDHH
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x293B8E0", Offset = "0x2939EE0", VA = "0x18293B8E0")]
	public static void MAFLKMDCAIA<T>(this List<T> DNOAHHGKGFF, int LLPJHIPCNFD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CEMIAKLHGHA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KFLGADPIJKL BPLPOHONNBM;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GHDHKPLGDOG : CEMIAKLHGHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct MHPFDPCMAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly float BKDEJNGAEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly float LDKKJADJJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		internal readonly bool DJDJJCHPPBF;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float PMILGDKKIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6A126A0", Offset = "0x6A10CA0", VA = "0x186A126A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6A12810", Offset = "0x6A10E10", VA = "0x186A12810")]
		public MHPFDPCMAMA(float ODFMKGCLIGE, float EACEIFBMGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6A126B0", Offset = "0x6A10CB0", VA = "0x186A126B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class AHEIKOFAOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GHDHKPLGDOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AHEIKOFAOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F080", Offset = "0x6A0D680", VA = "0x186A0F080")]
		internal void COAKGHGKBFN(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly int NAFKLJDAKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int MCIONFBOFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly CEMIAKLHGHA[] DAEKGJFCGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly KFLGADPIJKL[] AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly MHPFDPCMAMA[] DNLJGGBCMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private MHPFDPCMAMA LGJIHFDLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly JPGEAIOKJKE CECPPJBKOLO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KFLGADPIJKL BPLPOHONNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6A11410", Offset = "0x6A0FA10", VA = "0x186A11410", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6A112C0", Offset = "0x6A0F8C0", VA = "0x186A112C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A114D0", Offset = "0x6A0FAD0", VA = "0x186A114D0")]
	public GHDHKPLGDOG(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A11380", Offset = "0x6A0F980", VA = "0x186A11380")]
	public JPGEAIOKJKE IMLOHDIIMHN(MHPFDPCMAMA FKCOHIKICFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A10D40", Offset = "0x6A0F340", VA = "0x186A10D40")]
	public void AALNDFPBAFO(CEMIAKLHGHA JEDCNCCGILG, [Optional] MHPFDPCMAMA LJODCGNMGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A111B0", Offset = "0x6A0F7B0", VA = "0x186A111B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void KFLGADPIJKL(float HJEJDDDNHBP);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NJKALGBFOLO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class NPKAOBIDIHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly CEMIAKLHGHA ALKCKHEPNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly KFLGADPIJKL AHJILKLLLDE;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A12AF0", Offset = "0x6A110F0", VA = "0x186A12AF0")]
		public NPKAOBIDIHB(CEMIAKLHGHA ALKCKHEPNOC, KFLGADPIJKL AHJILKLLLDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A12AA0", Offset = "0x6A110A0", VA = "0x186A12AA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A12A30", Offset = "0x6A11030", VA = "0x186A12A30")]
	internal static bool FAGPFPCNDCM(float FAGKOOGCGBH, float HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A01CA0", Offset = "0x6A002A0", VA = "0x186A01CA0")]
	internal static float FONGDGFCKBB(float FAGKOOGCGBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A12970", Offset = "0x6A10F70", VA = "0x186A12970")]
	public static IDisposable EJCILBLFICG(this CEMIAKLHGHA ALKCKHEPNOC, KFLGADPIJKL AHJILKLLLDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class JPGEAIOKJKE : CEMIAKLHGHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private float HJEJDDDNHBP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float HKMCDELLBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A12030", Offset = "0x6A10630", VA = "0x186A12030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KFLGADPIJKL? BPLPOHONNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A12120", Offset = "0x6A10720", VA = "0x186A12120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A11F90", Offset = "0x6A10590", VA = "0x186A11F90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public JPGEAIOKJKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PCDDOABCJHI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x648ED20", Offset = "0x648D320", VA = "0x18648ED20")]
	public PCDDOABCJHI(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class MDKJBFLFJFI<TKey, TValue> : NOLCBHKJIPA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, KKLHPJOJDDH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BMIPDMIICAA : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public MDKJBFLFJFI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x1077520", Offset = "0x1075B20", VA = "0x181077520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x4E7DD80", Offset = "0x4E7C380", VA = "0x184E7DD80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public BMIPDMIICAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x396EEA0", Offset = "0x396D4A0", VA = "0x18396EEA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D3F0", Offset = "0x4E7B9F0", VA = "0x184E7D3F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DC40", Offset = "0x4E7C240", VA = "0x184E7DC40")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4E7CFE0", Offset = "0x4E7B5E0", VA = "0x184E7CFE0")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DC90", Offset = "0x4E7C290", VA = "0x184E7DC90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly NOLCBHKJIPA<TKey, TValue> GNNMGPOCMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IDictionary<TKey, TValue> ODEDDGDDBPJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x44B9910", Offset = "0x44B7F10", VA = "0x1844B9910", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x44B9BC0", Offset = "0x44B81C0", VA = "0x1844B9BC0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x44B9E70", Offset = "0x44B8470", VA = "0x1844B9E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> NHIDLCIOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x44B9C10", Offset = "0x44B8210", VA = "0x1844B9C10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> HLMNKOOFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D40", Offset = "0x44B8340", VA = "0x1844B9D40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x44B9840", Offset = "0x44B7E40", VA = "0x1844B9840")]
	public MDKJBFLFJFI(NOLCBHKJIPA<TKey, TValue> GNNMGPOCMJN, [Optional] IDictionary<TKey, TValue>? ODEDDGDDBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x44B7040", Offset = "0x44B5640", VA = "0x1844B7040", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x44B7E50", Offset = "0x44B6450", VA = "0x1844B7E50")]
	public void JMHFJGOIEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x44B6CB0", Offset = "0x44B52B0", VA = "0x1844B6CB0", Slot = "9")]
	public void Add(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x44B7A10", Offset = "0x44B6010", VA = "0x1844B7A10")]
	public void DOEFGCOLLOD(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x44B7F70", Offset = "0x44B6570", VA = "0x1844B7F70")]
	public void KEBPLJPJLLP(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x44B83A0", Offset = "0x44B69A0", VA = "0x1844B83A0")]
	public void KNLFOCJOHAK(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x44B8AE0", Offset = "0x44B70E0", VA = "0x1844B8AE0")]
	public void NJCPONHEKDL(TKey BHEIPBKEDLG, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x44B8E50", Offset = "0x44B7450", VA = "0x1844B8E50", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x44B9090", Offset = "0x44B7690", VA = "0x1844B9090", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x44B9250", Offset = "0x44B7850", VA = "0x1844B9250", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x44B7180", Offset = "0x44B5780", VA = "0x1844B7180", Slot = "8")]
	public bool ContainsKey(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x44B7D80", Offset = "0x44B6380", VA = "0x1844B7D80")]
	public bool JHIIJIGBEMK(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x44B8920", Offset = "0x44B6F20", VA = "0x1844B8920")]
	public bool LCHPLHMCCPK(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x44B8CA0", Offset = "0x44B72A0", VA = "0x1844B8CA0", Slot = "10")]
	public bool Remove(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x44B9690", Offset = "0x44B7C90", VA = "0x1844B9690", Slot = "11")]
	public bool TryGetValue(TKey BHEIPBKEDLG, [Out] TValue CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x44B76F0", Offset = "0x44B5CF0", VA = "0x1844B76F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x41A51A0", Offset = "0x41A37A0", VA = "0x1841A51A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x44B7C70", Offset = "0x44B6270", VA = "0x1844B7C70", Slot = "19")]
	[IteratorStateMachine(typeof(MDKJBFLFJFI<, >.BMIPDMIICAA))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x44B6B30", Offset = "0x44B5130", VA = "0x1844B6B30", Slot = "21")]
	public bool AEACFPILGAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x44B87B0", Offset = "0x44B6DB0", VA = "0x1844B87B0")]
	private TValue KPEJMDONECH(TKey BHEIPBKEDLG)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface KKLHPJOJDDH
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEACFPILGAI();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface NOLCBHKJIPA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KKLHPJOJDDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DefaultMember("Item")]
public sealed class FMHCEMJFILO<TKey, TVal> : NOLCBHKJIPA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KKLHPJOJDDH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public delegate int LHIDMCLNDKJ(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public delegate void FIAPIJMBIFO(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH, PFILCAPGHIC CLPBFEAPBCA);

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class EPDBGJBGGGG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey IGAHPOGKKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8D4790", Offset = "0x8D2D90", VA = "0x1808D4790")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal BLBBIKKJHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B10", Offset = "0x8D7110", VA = "0x1808D8B10")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8D90D0", Offset = "0x8D76D0", VA = "0x1808D90D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int PMILGDKKIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8A1FC0", Offset = "0x8A05C0", VA = "0x1808A1FC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8A1DF0", Offset = "0x8A03F0", VA = "0x1808A1DF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset DBIOPIAJPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xC3DD30", Offset = "0xC3C330", VA = "0x180C3DD30")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x14DF1C0", Offset = "0x14DD7C0", VA = "0x1814DF1C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x383DB00", Offset = "0x383C100", VA = "0x18383DB00")]
		public EPDBGJBGGGG(TKey BHEIPBKEDLG, TVal LECBAKCNNCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FANADKEGHAB : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public FMHCEMJFILO<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private LinkedList<EPDBGJBGGGG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1077520", Offset = "0x1075B20", VA = "0x181077520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3AC5420", Offset = "0x3AC3A20", VA = "0x183AC5420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public FANADKEGHAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3969AD0", Offset = "0x39680D0", VA = "0x183969AD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C16E50", Offset = "0x3C15450", VA = "0x183C16E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C17DE0", Offset = "0x3C163E0", VA = "0x183C17DE0")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C18070", Offset = "0x3C16670", VA = "0x183C18070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const int KCAOCJIHKJK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly Dictionary<TKey, LinkedListNode<EPDBGJBGGGG>> ELLEMHLLLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly LinkedList<EPDBGJBGGGG> GIEKMDKBHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly LHIDMCLNDKJ? KJIMOENDFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly TimeSpan GMHPGPEGHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly FIAPIJMBIFO? OEIKNGELFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly JICBKFOJJHG FPCJDOBMIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool LLDGLDJDHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly List<TKey> EEOHBOMFBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly List<TVal> AAKMCHIMLJB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BDJKBNBIKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8723F0", Offset = "0x8709F0", VA = "0x1808723F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int IHEILCDDDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xB0B850", Offset = "0xB09E50", VA = "0x180B0B850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xB0B270", Offset = "0xB09870", VA = "0x180B0B270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D730", Offset = "0x3C6BD30", VA = "0x183C6D730", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int IGCGNKBIMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3C62A60", Offset = "0x3C61060", VA = "0x183C62A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> HLMNKOOFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D8E0", Offset = "0x3C6BEE0", VA = "0x183C6D8E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.GGNGAMNIDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A020", Offset = "0x3C68620", VA = "0x183C6A020", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D880", Offset = "0x3C6BE80", VA = "0x183C6D880", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D970", Offset = "0x3C6BF70", VA = "0x183C6D970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3C63120", Offset = "0x3C61720", VA = "0x183C63120")]
	private bool NECAJNIOEOB(int NAFKLJDAKHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3C68C00", Offset = "0x3C67200", VA = "0x183C68C00")]
	private void PIKDCHONFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B9B0", Offset = "0x3C69FB0", VA = "0x183C6B9B0")]
	public FMHCEMJFILO(int NAFKLJDAKHD, [Optional] LHIDMCLNDKJ? KJIMOENDFEO, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FIAPIJMBIFO? OEIKNGELFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B930", Offset = "0x3C69F30", VA = "0x183C6B930")]
	public FMHCEMJFILO(TimeSpan GMHPGPEGHBB, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FIAPIJMBIFO? OEIKNGELFAK, [Optional] JICBKFOJJHG? FPCJDOBMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3C6AFB0", Offset = "0x3C695B0", VA = "0x183C6AFB0")]
	public FMHCEMJFILO(int NAFKLJDAKHD, TimeSpan GMHPGPEGHBB, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FIAPIJMBIFO? OEIKNGELFAK, [Optional] JICBKFOJJHG? FPCJDOBMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3C6D2B0", Offset = "0x3C6B8B0", VA = "0x183C6D2B0")]
	public FMHCEMJFILO(int NAFKLJDAKHD, LHIDMCLNDKJ? KJIMOENDFEO, TimeSpan GMHPGPEGHBB, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] FIAPIJMBIFO? OEIKNGELFAK, [Optional] JICBKFOJJHG? FPCJDOBMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3C59790", Offset = "0x3C57D90", VA = "0x183C59790", Slot = "21")]
	public bool AEACFPILGAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3C5D920", Offset = "0x3C5BF20", VA = "0x183C5D920", Slot = "22")]
	public bool CAIHABGDKBM(int ENCFHCJIMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3C66A20", Offset = "0x3C65020", VA = "0x183C66A20")]
	private bool OKFEINFCBKK(int ENCFHCJIMBE, PFILCAPGHIC CLPBFEAPBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3C62C00", Offset = "0x3C61200", VA = "0x183C62C00")]
	public void LHLEJLJODIO(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3C5C150", Offset = "0x3C5A750", VA = "0x183C5C150", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3C5C5F0", Offset = "0x3C5ABF0", VA = "0x183C5C5F0", Slot = "9")]
	public void Add(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3C5DE00", Offset = "0x3C5C400", VA = "0x183C5DE00", Slot = "8")]
	public bool ContainsKey(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3C69950", Offset = "0x3C67F50", VA = "0x183C69950", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3C69470", Offset = "0x3C67A70", VA = "0x183C69470", Slot = "10")]
	public bool Remove(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3C69B30", Offset = "0x3C68130", VA = "0x183C69B30", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3C63170", Offset = "0x3C61770", VA = "0x183C63170")]
	private bool NMOOPAJILOI(TKey BHEIPBKEDLG, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3C5CF40", Offset = "0x3C5B540", VA = "0x183C5CF40")]
	private TVal BDJJCDMMBKL(TKey LAGEFHPKEIC)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A500", Offset = "0x3C68B00", VA = "0x183C6A500", Slot = "11")]
	public bool TryGetValue(TKey LAGEFHPKEIC, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3C5DB30", Offset = "0x3C5C130", VA = "0x183C5DB30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F300", Offset = "0x3C5D900", VA = "0x183C5F300", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3C5B720", Offset = "0x3C59D20", VA = "0x183C5B720")]
	private void AKNOHBLJEHO(TKey BHEIPBKEDLG, TVal LECBAKCNNCK, PFILCAPGHIC CLPBFEAPBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3C5AC60", Offset = "0x3C59260", VA = "0x183C5AC60")]
	private bool AKLNIJOKMML(EPDBGJBGGGG HCCGMGOAADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3C61C20", Offset = "0x3C60220", VA = "0x183C61C20")]
	private void EJJNNKPEOND(LinkedListNode<EPDBGJBGGGG> BKFBCMIDLBG, TVal KPJPGFGPJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3C68880", Offset = "0x3C66E80", VA = "0x183C68880")]
	private void PBGBCGOCNGM(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3C5A720", Offset = "0x3C58D20", VA = "0x183C5A720")]
	private void AFEKELPIMGF(EPDBGJBGGGG HCCGMGOAADA, TVal KPJPGFGPJMK, int IACFIIENNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3C62900", Offset = "0x3C60F00", VA = "0x183C62900", Slot = "19")]
	[IteratorStateMachine(typeof(FMHCEMJFILO<, >.FANADKEGHAB))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A070", Offset = "0x3C68670", VA = "0x183C6A070", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum PFILCAPGHIC : byte
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
public class DMHOGDEDNNL<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly TKey HEJJPONMPBK;

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5839160", Offset = "0x5837760", VA = "0x185839160")]
	public DMHOGDEDNNL(TKey MEBIPHMLPPI, Exception EEOIAMFNMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JJLDDCOIEKM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5D77880", Offset = "0x5D75E80", VA = "0x185D77880")]
	public JJLDDCOIEKM(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class KMPILIIFONB<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LHMINFBOHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public KMPILIIFONB<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LHMINFBOHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x42BFE70", Offset = "0x42BE470", VA = "0x1842BFE70")]
		internal Task<TResource> HKNMCBOJGLL(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct MDGJNAKKHGE : IAsyncStateMachine
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
		public KMPILIIFONB<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x44B6010", Offset = "0x44B4610", VA = "0x1844B6010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x44B6970", Offset = "0x44B4F70", VA = "0x1844B6970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct BDEJKNDDOBA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4E4EF50", Offset = "0x4E4D550", VA = "0x184E4EF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4E4FCB0", Offset = "0x4E4E2B0", VA = "0x184E4FCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly DNONAAAOGON<TId, Task<TResource>> OLOAKIJKJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> KFOCGPKLMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? JMPNHJHFBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Action<TResource>? HDAKLKBMOLP;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4211380", Offset = "0x420F980", VA = "0x184211380")]
	public KMPILIIFONB(int MFMBBAGJHLE = 0, [Optional] IEqualityComparer<TId>? NBBHDALODBG, [Optional] Func<TId, CancellationToken, Task<TResource>>? JFILKDJICOM, [Optional] Action<TResource>? FNJOBPDOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4210680", Offset = "0x420EC80", VA = "0x184210680")]
	public BCBDLBGONLF<Task<TResource>> ECLIHBNIDDO(TId BLCJLIJFBDL, [Optional] Func<TId, CancellationToken, Task<TResource>>? JFILKDJICOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x420FD30", Offset = "0x420E330", VA = "0x18420FD30")]
	private void DNKELGKLJFP(Task<TResource> PEBIPFJADEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4211090", Offset = "0x420F690", VA = "0x184211090")]
	[AsyncStateMachine(typeof(KMPILIIFONB<, >.MDGJNAKKHGE))]
	private Task OACFFOJBLDB(Task<TResource> PEBIPFJADEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4210D30", Offset = "0x420F330", VA = "0x184210D30")]
	public void MNLMFOIGPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x420FA80", Offset = "0x420E080", VA = "0x18420FA80")]
	public DNONAAAOGON<TId, Task<TResource>>.ACMIKNAKBHK AKHPNFMFJMK()
	{
		return default(DNONAAAOGON<TId, Task<TResource>>.ACMIKNAKBHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4211190", Offset = "0x420F790", VA = "0x184211190", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4211190", Offset = "0x420F790", VA = "0x184211190", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4210AD0", Offset = "0x420F0D0", VA = "0x184210AD0")]
	[AsyncStateMachine(typeof(KMPILIIFONB<, >.BDEJKNDDOBA))]
	[CompilerGenerated]
	internal static Task KNMIOCNPLHH(Task<TResource> PEBIPFJADEI, CancellationTokenSource BICNBDHNPOJ, Dictionary<Task<TResource>, CancellationTokenSource> MEFJHCPPDPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DNONAAAOGON<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private sealed class IPMDDBFOELB : IEquatable<IPMDDBFOELB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly TValue BLBBIKKJHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int FCDPDIPEECD;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x960460", Offset = "0x95EA60", VA = "0x180960460")]
		public IPMDDBFOELB(TValue CBAEIEAPLIH, int KMEOGCMHOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC2B0", Offset = "0x3ECA8B0", VA = "0x183ECC2B0", Slot = "4")]
		public bool Equals(IPMDDBFOELB? LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC340", Offset = "0x3ECA940", VA = "0x183ECC340", Slot = "0")]
		public override bool Equals(object? HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC510", Offset = "0x3ECAB10", VA = "0x183ECC510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct ACMIKNAKBHK : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private Dictionary<TKey, IPMDDBFOELB>.Enumerator MIGHOOOGKDF;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x3CC9410", Offset = "0x3CC7A10", VA = "0x183CC9410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3CC9880", Offset = "0x3CC7E80", VA = "0x183CC9880", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC96D0", Offset = "0x3CC7CD0", VA = "0x183CC96D0")]
		public ACMIKNAKBHK(DNONAAAOGON<TKey, TValue> OLGJECBHAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9050", Offset = "0x3CC7650", VA = "0x183CC9050", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9110", Offset = "0x3CC7710", VA = "0x183CC9110", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC92B0", Offset = "0x3CC78B0", VA = "0x183CC92B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class LJCDPDJJDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public DNONAAAOGON<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public IPMDDBFOELB refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LJCDPDJJDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x42C76A0", Offset = "0x42C5CA0", VA = "0x1842C76A0")]
		internal void HKNMCBOJGLL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Dictionary<TKey, IPMDDBFOELB> IECLMOBPIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Func<TKey, TValue>? ICIJINHEOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Action<TValue>? EKFKLAIPPPG;

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x58408C0", Offset = "0x583EEC0", VA = "0x1858408C0")]
	public DNONAAAOGON(int MFMBBAGJHLE = 0, [Optional] IEqualityComparer<TKey>? BJLAODBBCMC, [Optional] Func<TKey, TValue>? GHPLGDEIDED, [Optional] Action<TValue>? GOIILIGLGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x583F960", Offset = "0x583DF60", VA = "0x18583F960")]
	public BCBDLBGONLF<TValue> ECLIHBNIDDO(TKey BHEIPBKEDLG, [Optional] Func<TKey, TValue>? GHIDHABMDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x583FC90", Offset = "0x583E290", VA = "0x18583FC90")]
	private void HLGENIPLFCF(TKey BHEIPBKEDLG, IPMDDBFOELB LAHBJEMCMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5840060", Offset = "0x583E660", VA = "0x185840060")]
	public void MNLMFOIGPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x583EF00", Offset = "0x583D500", VA = "0x18583EF00")]
	public ACMIKNAKBHK AKHPNFMFJMK()
	{
		return default(ACMIKNAKBHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x58406D0", Offset = "0x583ECD0", VA = "0x1858406D0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x58406D0", Offset = "0x583ECD0", VA = "0x1858406D0", Slot = "5")]
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
